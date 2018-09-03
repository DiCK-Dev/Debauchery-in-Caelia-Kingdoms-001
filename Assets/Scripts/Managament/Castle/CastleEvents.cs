using UnityEngine;
using System.Collections;

public class CastleEvents {

	public static string castleEvents(int idx, float prehap){
		string ret = ""; 
		if (NPCCharList.CharRetainers [idx].isSlave) {
			if (prehap > NPCCharList.CharRetainers [idx].attHappiness) {
				ret = "\n\n" +attemptEscape (idx);
			}
		} else {
			if (NPCCharList.CharRetainers [idx].attHappiness < 40) {
				if (prehap > NPCCharList.CharRetainers [idx].attHappiness) {
					ret = "\n\n" +quitJob(idx);
				}
			}
		}

		return ret + "\n\n" + checkAlive (idx);


	}


	static string attemptEscape(int idx){
		float PSMS = (NPCCharList.CharRetainers [idx].attPhysical + NPCCharList.CharRetainers [idx].attMental) / 2; 
		float ES = CastleController.castleSecurity * 60; // eff security
		if (CastleController.castleReinforced) {
			ES = CastleController.castleSecurity * 80;
		}

		if (NPCCharList.CharRetainers [idx].attHappiness < 50 && ES < 75) {
			int randNum = Random.Range (0, 100);
			if (randNum > ES) {
				NPCCharList.CharRetainers [idx].cityJobs = NPCData.Jobs.Escape;
				CastleUpdate.tempCastleDailyReport += NPCCharList.CharRetainers [idx].charName + " has escaped!";
				return NPCCharList.CharRetainers [idx].charName + " has escaped!";
			} else if (randNum > (ES / 2)) {
				NPCCharList.CharRetainers [idx].workReward = -5;
				NPCCharList.CharRetainers [idx].currentHealth -= Random.Range (0, 25);
				return NPCCharList.CharRetainers [idx].charName + " tried to escape but got caught by your guards, hurting it in the process!";
			}
		} else if (NPCCharList.CharRetainers [idx].attHappiness < 15) {
			int randNum = Random.Range (0, 100);
			if (randNum > ES) {
				NPCCharList.CharRetainers [idx].cityJobs = NPCData.Jobs.Escape;
				CastleUpdate.tempCastleDailyReport += NPCCharList.CharRetainers [idx].charName + " has escaped!";
				return NPCCharList.CharRetainers [idx].charName + " has escaped!";
			} else if (randNum > (ES / 2)) {
				NPCCharList.CharRetainers [idx].workReward = -5;
				NPCCharList.CharRetainers [idx].currentHealth -= Random.Range (0, 25);
				return NPCCharList.CharRetainers [idx].charName + " tried to escape but got caught by your guards!";
			}
		}
		return "";
	}

	static string quitJob(int idx){
		if(Random.Range(0,100) < (100 - (NPCCharList.CharRetainers [idx].attHappiness/1.2f) + (NPCCharList.CharRetainers [idx].charLoyalty /2))){
			NPCCharList.CharRetainers [idx].cityJobs = NPCData.Jobs.NONE;
			NPCCharList.CharRetainers [idx].isRecruited = false; 
			NPCCharList.CharRetainers [idx].isNeutral = true; 
			NPCCharList.CharRetainers [idx].charLoyalty = NPCCharList.CharRetainers [idx].charLoyalty / 2;
			NPCCharList.CharRetainers [idx].charRelationship = NPCCharList.CharRetainers [idx].charRelationship / 2;
			NPCCharList.CharRetainers [idx].charLove = NPCCharList.CharRetainers [idx].charLove / 2;
			CastleUpdate.tempCastleDailyReport += NPCCharList.CharRetainers [idx].charName + " has quited! You can probably find it looking for work again in the inn, but don't expect it to be friendly towards you after this event!";

			return NPCCharList.CharRetainers [idx].charName + " has quited! You can probably find it looking for work again in the inn, but don't expect it to be friendly towards you after this event!";
		}
		return "";
	}

	static string checkAlive(int idx){
		if (NPCCharList.CharRetainers [idx].currentHealth >= 0) {
			return ""; 
		}
		if (NPCCharList.CharRetainers [idx].isDead) {
			return "";	
		}

		if (NPCCharList.CharRetainers [idx].currentHealth < 0 && NPCCharList.CharRetainers [idx].currentHealth > -20) {
			NPCCharList.CharRetainers [idx].cityJobs = NPCData.Jobs.CastleRest;
			return  NPCCharList.CharRetainers [idx].charName +" it's in critical condition and and needs medical attendance soon, or it will pass away!";
		}
		if (NPCCharList.CharRetainers [idx].currentHealth <= -20 || NPCCharList.CharRetainers [idx].isDead != true) {
			return "Sadly, " + NPCCharList.CharRetainers [idx].charName + " has died from it's poor health!";
		}

		return "";
	}

}
