using UnityEngine;
using System.Collections;

public class SlaveRewardsEffects  {




	public static void rewardsEffects(float rewardLevel, float rewardBase, float fearBonus, float spoilBonus, float happBonus, float loyBonus, float relBonus, float loveBonus, float obedBonus, float extraExpect, float healthChange, int moneyCost, int specialCase, float slaveMasterEff){
		int idxR = rulesIdx ();
		float happBase = 0, obeBase = 0, loyBase = 0, relBase = 0, loveBase = 0; 
		if (idxR < 0) {
			Debug.Log ("This is a bug");
			return;
		}

		float expBonus = (((rewardLevel * 5) - NPCCharList.CharRetainers [WorldControl.idx].attExpectation) / 100) + rewardBase;
		NPCCharList.CharRetainers [WorldControl.idx].attFear = 20 * -(expBonus + (-rewardBase) + fearBonus);
		NPCCharList.CharRetainers [WorldControl.idx].attSpoiled = 20 * (expBonus + (-rewardBase) + spoilBonus);

		switch (specialCase)
		{
		case 0: // nothing
			if (NPCCharList.CharRetainers [WorldControl.idx].charRelationship < 0) {
				happBase = 2.5f; obeBase = 3.5f; loyBase = 1f; relBase = 0f; loveBase = 0f;
			} else if (NPCCharList.CharRetainers [WorldControl.idx].charRelationship < 50) {
				happBase = 5f; obeBase = 5f; loyBase = 2.5f; relBase = 0f; loveBase = 0f;
			} else {
				happBase = 5f; obeBase = 5f; loyBase = 3.5f; relBase = 0f; loveBase = 0f;
			}
			break;
		case 1: // personal reward
			if (NPCCharList.CharRetainers [WorldControl.idx].charRelationship < 0) {
				happBase = 2.5f; obeBase = 3.5f; loyBase = 2.5f; relBase = 2.5f; loveBase = 0f;
			} else if (NPCCharList.CharRetainers [WorldControl.idx].charRelationship < 50) {
				happBase = 5f; obeBase = 5f; loyBase = 3.5f; relBase = 3.5f; loveBase = 0.5f;
			} else {
				happBase = 5f; obeBase = 5f; loyBase = 3.5f; relBase = 3.5f; loveBase = 1f;
			}
			break;
		case 2: // gift reward
			if (NPCCharList.CharRetainers [WorldControl.idx].charRelationship < 0) {
				happBase = 4f; obeBase = 4f; loyBase = 1f; relBase = 2.5f; loveBase = 0f;
			} else if (NPCCharList.CharRetainers [WorldControl.idx].charRelationship < 50) {
				happBase = 5f; obeBase = 5f; loyBase = 2.5f; relBase = 1.5f; loveBase = 0f;
			} else {
				happBase = 5f; obeBase = 5f; loyBase = 3f; relBase = 2.5f; loveBase = 0.5f;
			}
			break;
		case 3: // sex reward
			if (NPCCharList.CharRetainers [WorldControl.idx].charRelationship < 0) {
				happBase = -1.5f; obeBase = 1f; loyBase = -0.5f; relBase = -1f; loveBase = -0.5f;
			} else if (NPCCharList.CharRetainers [WorldControl.idx].charRelationship < 50) {
				happBase = 2f; obeBase = 2f; loyBase = 1f; relBase = 1.5f; loveBase = 0.5f;
			} else {
				happBase = 7f; obeBase = 7f; loyBase = 3.5f; relBase = 3f; loveBase = 2.5f;
			}
			break;
		case 1000: // torture
			happBase = 10f; obeBase = 8f; loyBase = 6f; relBase = 6f; loveBase = 5f;
			break;
		case 1001: // sexual punishment
			happBase = 7f; obeBase = 6f; loyBase = 3f; relBase = 3f; loveBase = 2f;
			break;
		case 1002: // public sexual punishment
			happBase = 8.5f; obeBase = 7f; loyBase = 4f; relBase = 4f; loveBase = 3f;
			break;

		}

		NPCCharList.CharRetainers [WorldControl.idx].attHappiness += happBase * (expBonus + happBonus);
		Debug.Log ( "happ " +(happBase * (expBonus + happBonus)).ToString ());
		if (expBonus >= 0) {
			NPCCharList.CharRetainers [WorldControl.idx].attObedience += (obeBase * (expBonus + obedBonus))*slaveMasterEff;
			Debug.Log ( "obe " +(obeBase* (expBonus + obedBonus)).ToString ());

		} else {
			NPCCharList.CharRetainers [WorldControl.idx].attObedience += (obeBase * -(expBonus + -(obedBonus)))*slaveMasterEff;
			Debug.Log ( "obe " +( obeBase * -(expBonus + -(obedBonus))).ToString ());

		}

		NPCCharList.CharRetainers [WorldControl.idx].charLoyalty += loyBase * (expBonus + loyBonus);
		Debug.Log ( "loy " +(loyBase * (expBonus + loyBonus)).ToString ());

		NPCCharList.CharRetainers [WorldControl.idx].charRelationship += relBase * (expBonus + relBonus);
		Debug.Log ( "rel  " +(relBase * (expBonus + relBonus)).ToString ());

		NPCCharList.CharRetainers [WorldControl.idx].charLove += loveBase * (expBonus + loveBonus);
		Debug.Log ( "love " +(loveBase* (expBonus + loveBase)).ToString ());

		NPCCharList.CharRetainers [WorldControl.idx].attExpectation += extraExpect;

		NPCCharList.CharRetainers [WorldControl.idx].currentHealth += healthChange;

		if (NPCCharList.CharRetainers [WorldControl.idx].workReward > 0 && rewardLevel > 0) {
			NPCCharList.CharRetainers [WorldControl.idx].workReward -= (int)rewardLevel;
			if (NPCCharList.CharRetainers [WorldControl.idx].workReward < 0) {
				NPCCharList.CharRetainers [WorldControl.idx].workReward = 0;
			}
		} else if (NPCCharList.CharRetainers [WorldControl.idx].workReward > 0 && rewardLevel < 0) {
			NPCCharList.CharRetainers [WorldControl.idx].workReward += (int)rewardLevel;
			if (NPCCharList.CharRetainers [WorldControl.idx].workReward < 0) {
				NPCCharList.CharRetainers [WorldControl.idx].workReward = 0;
			}
		} else if (NPCCharList.CharRetainers [WorldControl.idx].workReward < 0 && rewardLevel > 0) {
			NPCCharList.CharRetainers [WorldControl.idx].workReward += (int)rewardLevel;
			if (NPCCharList.CharRetainers [WorldControl.idx].workReward > 0) {
				NPCCharList.CharRetainers [WorldControl.idx].workReward = 0;
			}
		} else if (NPCCharList.CharRetainers [WorldControl.idx].workReward < 0 && rewardLevel < 0) {
			NPCCharList.CharRetainers [WorldControl.idx].workReward -= (int)rewardBase;
			if (NPCCharList.CharRetainers [WorldControl.idx].workReward > 0) {
				NPCCharList.CharRetainers [WorldControl.idx].workReward = 0;
			}
		}


	}

	public static string rewardsSlaveMaster(float rewardLevel, float rewardBase, float fearBonus, float spoilBonus, float happBonus, float loyBonus, float relBonus, float loveBonus, float obedBonus, float extraExpect, float healthChange, int moneyCost, int specialCase, float slaveMasterEff, int idx, int idxRL){
		int idxR = idxRL;
		float happBase = 0, obeBase = 0, loyBase = 0, relBase = 0, loveBase = 0; 
		if (idxR < 0 || RulesNPC.savedRules.Count == 0) {
			return "this is a bug";
		}
		if (slaveMasterEff == 0) {
			return "";
		}
		if (NPCCharList.CharRetainers [idx].workReward == 0) {
			return "";
		}

		float expBonus = (((rewardLevel * 5) - NPCCharList.CharRetainers [idx].attExpectation) / 100) + rewardBase;
		NPCCharList.CharRetainers [idx].attFear = 20 * -(expBonus + (-rewardBase) + fearBonus);
		NPCCharList.CharRetainers [idx].attSpoiled = 20 * (expBonus + (-rewardBase) + spoilBonus);

		switch (specialCase)
		{
		case 0: // nothing
			if (NPCCharList.CharRetainers [idx].charRelationship < 0) {
				happBase = 2.5f; obeBase = 3.5f; loyBase = 1f; relBase = 0f; loveBase = 0f;
			} else if (NPCCharList.CharRetainers [idx].charRelationship < 50) {
				happBase = 5f; obeBase = 5f; loyBase = 2.5f; relBase = 0f; loveBase = 0f;
			} else {
				happBase = 5f; obeBase = 5f; loyBase = 3.5f; relBase = 0f; loveBase = 0f;
			}
			break;
		case 1: // personal reward
			if (NPCCharList.CharRetainers [idx].charRelationship < 0) {
				happBase = 2.5f; obeBase = 3.5f; loyBase = 2.5f; relBase = 2.5f; loveBase = 0f;
			} else if (NPCCharList.CharRetainers [idx].charRelationship < 50) {
				happBase = 5f; obeBase = 5f; loyBase = 3.5f; relBase = 3.5f; loveBase = 0.5f;
			} else {
				happBase = 5f; obeBase = 5f; loyBase = 3.5f; relBase = 3.5f; loveBase = 1f;
			}
			break;
		case 2: // gift reward
			if (NPCCharList.CharRetainers [idx].charRelationship < 0) {
				happBase = 4f; obeBase = 4f; loyBase = 1f; relBase = 2.5f; loveBase = 0f;
			} else if (NPCCharList.CharRetainers [idx].charRelationship < 50) {
				happBase = 5f; obeBase = 5f; loyBase = 2.5f; relBase = 1.5f; loveBase = 0f;
			} else {
				happBase = 5f; obeBase = 5f; loyBase = 3f; relBase = 2.5f; loveBase = 0.5f;
			}
			break;
		case 3: // sex reward
			if (NPCCharList.CharRetainers [idx].charRelationship < 0) {
				happBase = -1.5f; obeBase = 1f; loyBase = -0.5f; relBase = -1f; loveBase = -0.5f;
			} else if (NPCCharList.CharRetainers [idx].charRelationship < 50) {
				happBase = 2f; obeBase = 2f; loyBase = 1f; relBase = 1.5f; loveBase = 0.5f;
			} else {
				happBase = 7f; obeBase = 7f; loyBase = 3.5f; relBase = 3f; loveBase = 2.5f;
			}
			break;
		case 1000: // torture
			happBase = 10f; obeBase = 8f; loyBase = 6f; relBase = 6f; loveBase = 5f;
			break;
		case 1001: // sexual punishment
			happBase = 7f; obeBase = 6f; loyBase = 3f; relBase = 3f; loveBase = 2f;
			break;
		case 1002: // public sexual punishment
			happBase = 8.5f; obeBase = 7f; loyBase = 4f; relBase = 4f; loveBase = 3f;
			break;

		}

		NPCCharList.CharRetainers [idx].attHappiness += happBase * (expBonus + happBonus);
		Debug.Log ( "happ " +(happBase * (expBonus + happBonus)).ToString ());
		if (expBonus >= 0) {
			NPCCharList.CharRetainers [idx].attObedience += (obeBase * (expBonus + obedBonus))*slaveMasterEff;
			Debug.Log ( "obe " +(obeBase* (expBonus + obedBonus)).ToString ());

		} else {
			NPCCharList.CharRetainers [idx].attObedience += (obeBase * -(expBonus + -(obedBonus)))*slaveMasterEff;
			Debug.Log ( "obe " +( obeBase * -(expBonus + -(obedBonus))).ToString ());

		}

		NPCCharList.CharRetainers [idx].charLoyalty += loyBase * (expBonus + loyBonus);
		Debug.Log ( "loy " +(loyBase * (expBonus + loyBonus)).ToString ());

		NPCCharList.CharRetainers [idx].charRelationship += relBase * (expBonus + relBonus);
		Debug.Log ( "rel  " +(relBase * (expBonus + relBonus)).ToString ());

		NPCCharList.CharRetainers [idx].charLove += loveBase * (expBonus + loveBonus);
		Debug.Log ( "love " +(loveBase* (expBonus + loveBase)).ToString ());

		NPCCharList.CharRetainers [idx].attExpectation += extraExpect;

		NPCCharList.CharRetainers [idx].currentHealth += healthChange;

		string himher = "him", hisher = "his";
		if (NPCCharList.CharRetainers [idx].charGender == NPCData.CharGender.FEMALE) {
			himher = "her"; hisher = "her";
		}


		if (NPCCharList.CharRetainers [idx].workReward > 0 && rewardLevel > 0) {
			NPCCharList.CharRetainers [idx].workReward = 0;
			return "The slavemaster rewarded " +himher + " for " + hisher + " good behavior." ;

		} else if (NPCCharList.CharRetainers [idx].workReward > 0 && rewardLevel < 0) {
			NPCCharList.CharRetainers [idx].workReward = 0;

			return "The slavemaster rewarded " +himher + " for " + hisher + " good behavior." ;

		} else if (NPCCharList.CharRetainers [idx].workReward < 0 && rewardLevel > 0) {
			NPCCharList.CharRetainers [idx].workReward = 0;

			return "The slavemaster punished " +himher + " for " + hisher + " bad behavior." ;

		} else if (NPCCharList.CharRetainers [idx].workReward < 0 && rewardLevel < 0) {
			NPCCharList.CharRetainers [idx].workReward = 0;

			return "The slavemaster punished " +himher + " for " + hisher + " bad behavior." ;

		}
		return "bug in rewardsSalveMaster in SlaveRewardsEffects.cs";




	}



	static int rulesIdx(){
		int i = 0;
		while (i < RulesNPC.savedRules.Count) {
			if (RulesNPC.savedRules [i].id == WorldControl.NPCID) {
				return i;
			}
			i++;
		}
		return -1; 

	}

}
