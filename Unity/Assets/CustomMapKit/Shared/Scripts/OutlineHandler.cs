using UnityEngine;
using UnityEngine.UI;

public class OutlineHandler : MonoBehaviour
{
	public static Color TeamColor;

	public static Color EnemyColor;

	public static float OutlineWidthMultiplier;

	[SerializeField]
	private Slider widthMultiplierSlider;

	[SerializeField]
	private ColorInputSetting teamOutline;

	[SerializeField]
	private ColorInputSetting enemyOutline;

	public void WidthMultiplierSlider(float value)
	{
	}

	public void SaveTeamOutline(Color color)
	{
	}

	public void SaveEnemyOutline(Color color)
	{
	}

	public void Awake()
	{
	}
}
