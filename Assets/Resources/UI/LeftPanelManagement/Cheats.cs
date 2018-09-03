using UnityEngine;
using System.Collections;

public class Cheats : MonoBehaviour {




	public void addMoney(int amount){
		GameControl.charGold += amount;
		Debug.Log ("CharGold = " + GameControl.charGold.ToString ());
	}

	public void maxStats(){
		GameControl.coreSkillMartial = 100; //0
		GameControl.coreSkillSecurity = 100;
		GameControl.coreSkillLabor = 100;
		GameControl.coreSkillTactics = 100; //3
		GameControl.coreSkillGovernance = 100;
		GameControl.coreSkillStewardship = 100;
		GameControl.coreSkillPersuasion = 100; //6
		GameControl.coreSkillIntrigue = 100;
		GameControl.coreSkillDiplomacy = 100;


		GameControl.utilitySkillCrafting = 100; 
		GameControl.utilitySkillHouseKeeping = 100; 
		GameControl.utilitySkillFarmHand = 100; 
		GameControl.utilitySkillMedicine = 100;
		GameControl.utilitySkillAlchemy = 100;
		GameControl.utilitySkillLearning = 100;
		GameControl.utilitySkillPerformance = 100;
		GameControl.utilitySkillEtiquette = 100;
		GameControl.utilitySkillStreetwise = 100;

		GameControl.sexSkillMasseuse = 100;
		GameControl.sexSkillStripping = 100; 
		GameControl.sexSkillBondage = 100;
		GameControl.sexSkillPetplay = 100;
		GameControl.sexSkillPetting = 100;
		GameControl.sexSkillGroupSex = 100;
		GameControl.sexSkillPenetration = 100;
		GameControl.sexSkillWhoring = 100; 
		GameControl.sexSkillEscorting = 100; 

		GameControl.attPhysical = 100; // they lvl up with decimals, like 0.1 
		GameControl.attMental = 100;
		GameControl.attSocial = 100;
		GameControl.attMagicPower = 100;
	}

	//this is added when you create a character 
	static public void cheatItems(){
		Debug.Log ("cheat items");
		if (GameControl.playerName == "Lynn") {
			Debug.Log ("cheat Lynn");
			GameControl.invSlotArray [9, 0] = 30500;
			GameControl.invSlotArray [9, 1] = 1;
			GameControl.invSlotArray [8, 0] = 40500;
			GameControl.invSlotArray [8, 1] = 1;
			GameControl.invSlotArray [7, 0] = 50500;
			GameControl.invSlotArray [7, 1] = 1;
			GameControl.invSlotArray [6, 0] = 60500;
			GameControl.invSlotArray [6, 1] = 1;
			GameControl.invSlotArray [5, 0] = 70500;
			GameControl.invSlotArray [5, 1] = 1;
			GameControl.invSlotArray [4, 0] = 80500;
			GameControl.invSlotArray [4, 1] = 1;
			GameControl.invSlotArray [3, 0] = 20500;
			GameControl.invSlotArray [3, 1] = 1;

		}
	}

}
