#!/usr/bin/env python3
"""
resize_images.py — Recursively resize images in a directory using the Mitchell filter.

Usage:
    python resize_images.py <directory> <max_size> [options]

Examples:
    python resize_images.py ./photos 1920          # longest edge ≤ 1920 px
    python resize_images.py ./photos 800x600       # fit within 800×600 box
    python resize_images.py ./photos 1280 --inplace
    python resize_images.py ./photos 1280 --output ./resized --quality 90
"""

import argparse
import sys
from pathlib import Path

from PIL import Image

# ── Supported extensions ───────────────────────────────────────────────────────
IMAGE_EXTENSIONS = {".jpg", ".jpeg", ".png", ".webp", ".bmp", ".tiff", ".tif"}

# Pillow's LANCZOS is the Mitchell-family resampling filter used for high-quality
# downscaling.  PIL.Image.LANCZOS (a.k.a. Resampling.LANCZOS) uses a sinc-based
# kernel that closely matches the Mitchell–Netravali bicubic filter that most
# image-processing tools label "Mitchell".
MITCHELL = Image.Resampling.LANCZOS


def parse_max_size(value: str) -> tuple[int, int]:
    """Accept '1920' (square box) or '1920x1080' (width×height box)."""
    if "x" in value.lower():
        w, h = value.lower().split("x", 1)
        return int(w), int(h)
    side = int(value)
    return side, side


def compute_new_size(
    original: tuple[int, int], max_box: tuple[int, int]
) -> tuple[int, int] | None:
    """
    Return the new (width, height) that fits inside max_box while preserving
    aspect ratio.  Returns None if the image already fits (no upscaling).
    """
    ow, oh = original
    mw, mh = max_box

    if ow <= mw and oh <= mh:
        return None  # already small enough

    ratio = min(mw / ow, mh / oh)
    return (round(ow * ratio), round(oh * ratio))


def resize_file(
    src: Path,
    dst: Path,
    max_box: tuple[int, int],
    quality: int,
    skip_existing: bool,
) -> str:
    """
    Resize a single image file and save to dst.
    Returns a short status string for logging.
    """
    if skip_existing and dst.exists():
        return "skipped (exists)"

    with Image.open(src) as img:
        original_size = img.size
        new_size = compute_new_size(original_size, max_box)

        if new_size is None:
            # Copy without re-encoding only if writing to a different location
            if dst != src:
                dst.parent.mkdir(parents=True, exist_ok=True)
                img.save(dst, quality=quality)
            return f"unchanged ({original_size[0]}×{original_size[1]})"

        resized = img.resize(new_size, MITCHELL)

        dst.parent.mkdir(parents=True, exist_ok=True)
        # Preserve EXIF when possible
        exif = img.info.get("exif", b"")
        save_kwargs: dict = {"quality": quality}
        if exif:
            save_kwargs["exif"] = exif

        resized.save(dst, **save_kwargs)

    return (
        f"{original_size[0]}×{original_size[1]} → {new_size[0]}×{new_size[1]}"
    )


def collect_images(root: Path) -> list[Path]:
    return sorted(
        p
        for p in root.rglob("*")
        if p.is_file() and p.suffix.lower() in IMAGE_EXTENSIONS
    )


def main() -> None:
    parser = argparse.ArgumentParser(
        description="Recursively resize images using the Mitchell (Lanczos) filter."
    )
    parser.add_argument("directory", type=Path, help="Root directory to scan.")
    parser.add_argument(
        "max_size",
        type=str,
        help="Maximum size as a single integer (longest edge) or WxH (e.g. 1920 or 1920x1080).",
    )
    parser.add_argument(
        "--output",
        "-o",
        type=Path,
        default=None,
        help="Output directory.  Mirrors source tree.  Defaults to <directory>_resized.",
    )
    parser.add_argument(
        "--inplace",
        action="store_true",
        help="Overwrite originals instead of writing to a separate output directory.",
    )
    parser.add_argument(
        "--quality",
        "-q",
        type=int,
        default=85,
        help="JPEG/WebP save quality (1–95, default 85).",
    )
    parser.add_argument(
        "--skip-existing",
        action="store_true",
        help="Skip output files that already exist.",
    )
    parser.add_argument(
        "--dry-run",
        action="store_true",
        help="Print what would happen without writing any files.",
    )

    args = parser.parse_args()

    # ── Validate inputs ────────────────────────────────────────────────────────
    root: Path = args.directory.resolve()
    if not root.is_dir():
        sys.exit(f"Error: '{root}' is not a directory.")

    try:
        max_box = parse_max_size(args.max_size)
    except ValueError:
        sys.exit(f"Error: invalid max_size '{args.max_size}'. Use '1920' or '1920x1080'.")

    if args.inplace:
        output_root = root
    else:
        output_root = (args.output or root.parent / (root.name + "_resized")).resolve()

    # ── Collect images ─────────────────────────────────────────────────────────
    images = collect_images(root)
    if not images:
        print("No images found.")
        return

    print(
        f"Found {len(images)} image(s) in '{root}'\n"
        f"Max box : {max_box[0]}×{max_box[1]} px\n"
        f"Filter  : Mitchell (Lanczos)\n"
        f"Output  : {'in-place' if args.inplace else output_root}\n"
        f"Quality : {args.quality}\n"
        + ("*** DRY RUN — no files will be written ***\n" if args.dry_run else "")
    )

    ok = skipped = errors = 0

    for src in images:
        rel = src.relative_to(root)
        dst = output_root / rel

        if args.dry_run:
            with Image.open(src) as img:
                new_size = compute_new_size(img.size, max_box)
            if new_size:
                print(f"  [resize]  {rel}  →  {new_size[0]}×{new_size[1]}")
            else:
                print(f"  [copy]    {rel}  (already fits)")
            ok += 1
            continue

        try:
            status = resize_file(src, dst, max_box, args.quality, args.skip_existing)
            print(f"  ✓  {rel}  ({status})")
            if "skipped" in status:
                skipped += 1
            else:
                ok += 1
        except Exception as exc:
            print(f"  ✗  {rel}  ERROR: {exc}", file=sys.stderr)
            errors += 1

    print(
        f"\nDone.  {ok} processed, {skipped} skipped, {errors} error(s)."
    )
    if errors:
        sys.exit(1)


if __name__ == "__main__":
    main()
