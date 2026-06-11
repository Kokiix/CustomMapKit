using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MatchPoitnsHUD : MonoBehaviour
{
	[SerializeField]
	private Material inactiveMaterial;

	[SerializeField]
	private Material[] activeMaterials;

	[SerializeField]
	private MeshRenderer primaryPointMesh;

	[SerializeField]
	private MeshRenderer[] secondaryPointObjects;

	[SerializeField]
	private TMP_Text[] pointsTexts;

	public void Start()
	{
	}

	public void UpdateVisuals(int winnerTeamId, Dictionary<int, int> roundScores)
	{
	}

	public void UpdateVisuals(int teamNumber, int roundScore, bool isWinner, Material[] primaryPointMeshMaterials)
	{
	}
}
