using System;

[Serializable]
public struct WeaponData
{
	public string WeaponName;

	public uint SpawnChance;

	public bool IsSpawnable;

	public WeaponData(string weaponName, uint spawnChance, bool isSpawnable)
	{
		WeaponName = null;
		SpawnChance = 0u;
		IsSpawnable = false;
	}
}
