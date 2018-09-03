using UnityEngine;
using System.Collections;

public class CastleLuxuriesUpdate {


	public static string luxuriesUpdate(int idx, int idxRL){


		return "";

	}


	public static string bathUpdate(int idx, int idxRL){
		if (RulesNPC.savedRules [idxRL].denyToileting) {
			return "\n\nYou have forbidden this person to go to the bathroom on it's own!";
		}
		if (CastleController.castleSupplies < 1) {
			return "You don't have enough supplies for the private bath!";
		}
		CastleController.castleSupplies--;
		NPCCharList.CharRetainers [idx].attHappiness += 1;
		if (NPCCharList.CharRetainers [idx].attObedience < 50) {
			NPCCharList.CharRetainers [idx].attObedience += Random.Range (0, 0.5f);
			NPCCharList.CharRetainers [idx].attSpoiled += Random.Range (0.5f, 1.5f);

		}
		if (NPCCharList.CharRetainers [idx].attStyle < 50) {
			NPCCharList.CharRetainers [idx].attStyle += Random.Range (1, 2.5f);
		}
		return "";
	}


	public static string physicianUpdate(int idx){
		if (GameControl.charGold < 5) {
			return "You don't have enough money to pay for the private physician!";
		}
		GameControl.charGold -= 5;
		NPCCharList.CharRetainers [idx].attHappiness += 0.3f;
		NPCCharList.CharRetainers [idx].currentHealth += 12 + Random.Range (0, 10);
		if (NPCCharList.CharRetainers [idx].attFear < 0) {
			NPCCharList.CharRetainers [idx].attFear += 2;
		}

		return "";
	}

	public static string personalStylist(int idx){
		if (GameControl.charGold < 5) {
			return "You don't have enough money to pay for the private stylist!";
		}
		if (CastleController.castleSupplies < 2) {
			return "You didn't had enough supplies for the stylist!";
		}
		GameControl.charGold -= 3;
		CastleController.castleSupplies -= 2;
		NPCCharList.CharRetainers [idx].attHappiness += 0.5f;
		if (NPCCharList.CharRetainers [idx].attObedience < 75) {
			NPCCharList.CharRetainers [idx].attSpoiled += Random.Range(1,3);
			NPCCharList.CharRetainers [idx].attObedience += 0.35f;
		}
		NPCCharList.CharRetainers [idx].attStyle += Random.Range (1.5f, 3.5f);
		return "";
	}



	public static string freeTime(int idx){
		string HIMHER = "him";
		if (NPCCharList.CharRetainers [idx].charGender == NPCData.CharGender.FEMALE) {
			HIMHER = "her";
		}
		if (CastleController.castleSupplies < 2) {
			return "You didn't had enough supplies to give " +HIMHER+  " for " + HIMHER+ " free time!";
		}
		CastleController.castleSupplies -= 2;
		NPCCharList.CharRetainers [idx].attHappiness += Random.Range(2,4);
		if (NPCCharList.CharRetainers [idx].attObedience < 75) {
			NPCCharList.CharRetainers [idx].attSpoiled += Random.Range (2.5f, 4);
		} else if (NPCCharList.CharRetainers [idx].attObedience < 90) {
			NPCCharList.CharRetainers [idx].attSpoiled += Random.Range (0.5f, 1.5f);
		}
		return "";
	}

}
