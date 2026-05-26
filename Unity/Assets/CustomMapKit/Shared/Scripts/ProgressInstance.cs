using System;
using UnityEngine;

[Serializable]
public class ProgressInstance
{
	public int xpToUnlock;

	public CosmeticInstance cosmetic;

	public string[] maps;

	public bool unlocked;

	public bool dlcExlusive;

	[HideInInspector]
	public int index;
}
