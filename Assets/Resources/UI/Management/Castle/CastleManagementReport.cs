using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CastleManagementReport : MonoBehaviour {

	public Text Board; 
	//public Canvas canRules, canStyle, canTattoo, canPiercing, canEquipment, canRewards, canPunishment, canBoard;


	public void showSummary(){
		Board.text = manRulesControl.returnReport ();
	}



}
