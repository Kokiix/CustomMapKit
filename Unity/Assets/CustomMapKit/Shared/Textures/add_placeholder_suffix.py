import os
import re

# Regex to match .jpg, .jpeg, or .png (case-insensitive)
pattern = re.compile(r'(\.(jpg|jpeg|png))', re.IGNORECASE)

def rename_files(directory="."):
    for root, _, files in os.walk(directory):
        for file in files:
            if pattern.search(file):
                # Replace the first occurrence of the extension with _placeholder + extension
                new_name = pattern.sub(r'_placeholder\1', file, count=1)
                
                old_path = os.path.join(root, file)
                new_path = os.path.join(root, new_name)
                
                print(f"Renaming: {old_path} -> {new_path}")
                os.rename(old_path, new_path)

if __name__ == "__main__":
    # You can change '.' to a specific absolute path if desired
    rename_files('.')