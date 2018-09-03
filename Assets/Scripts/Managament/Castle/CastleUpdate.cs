using UnityEngine;
using System.Collections;

public class CastleUpdate {


	public static float tempCastleCleanliness;
	public static float tempCastleFoodQuality;
	public static float tempCastleSecurity;

	//public static float tempCastleSupplies;

	public static float tempCastleHealthcare;
	public static float tempSlaveMasterEff;
	public static float tempMaxSecurityTrain;
	public static float tempMaxMartialTrain;

	public static float tempCastleMentalcare;
	public static string tempCastleDailyReport;



	public static void updateCastle(){
		resetCastle ();


		string report;
		int i = 0;
		while (i < RulesNPC.savedRules.Count) {

			verifyID (i);

			if (NPCCharList.CharRetainers [RulesNPC.savedRules [i].idx].isDead != true && NPCCharList.CharRetainers [RulesNPC.savedRules [i].idx].currentHealth > 0) {
				tempCastleCleanliness -= Random.Range (0, 3);
				float preHapp = NPCCharList.CharRetainers [RulesNPC.savedRules [i].idx].attHappiness;
				report = "";
				report += SlaveRewardsEffects.rewardsSlaveMaster (NPCCharList.CharRetainers [RulesNPC.savedRules [i].idx].workReward, 1, (CastleController.slaveMasterEff / 3), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, CastleController.slaveMasterEff, RulesNPC.savedRules [i].idx, i);
				report += "\n\n"+CastleJobsUpdate.updateJob (RulesNPC.savedRules [i].idx);
				report += CastleLivingConditionsUpdate.updateConditions (RulesNPC.savedRules [i].idx, i);
				report += CastleRulesUpdate.rulesUpdate (RulesNPC.savedRules [i].idx, i);
				report += CastleLuxuriesUpdate.luxuriesUpdate (RulesNPC.savedRules [i].idx, i);
				report += CastleDrugUpdate.drugUpdate (RulesNPC.savedRules [i].idx, i);
				NPCAdjustStats.adjustAll (RulesNPC.savedRules [i].idx);
				tempCastleDailyReport =  CastleEvents.castleEvents (RulesNPC.savedRules [i].idx, preHapp);
				RulesNPC.savedRules [i].reportOld = RulesNPC.savedRules [i].reportNew;
				RulesNPC.savedRules [i].reportNew = report;
			} else if(NPCCharList.CharRetainers [RulesNPC.savedRules [i].idx].isDead) {
				RulesNPC.savedRules [i].reportOld = "Is still dead.";
				RulesNPC.savedRules [i].reportNew = "Is still dead.";
			}
			i++;
		}

		if (tempCastleCleanliness < -20) {
			tempCastleCleanliness = -20;
		}
		if (tempCastleCleanliness > 100) {
			tempCastleCleanliness = 100;
		}
		CastleController.castleDailyReport = tempCastleDailyReport;
		CastleController.castleCleanliness = tempCastleCleanliness;
		CastleController.castleFoodQuality = tempCastleFoodQuality;
		CastleController.castleSecurity = tempCastleSecurity;
		CastleController.castleHealthcare = tempCastleHealthcare;
		CastleController.castleMentalcare = tempCastleMentalcare;
		//CastleController.castleSupplies = tempCastleSupplies;
		CastleController.slaveMasterEff = tempSlaveMasterEff;
		CastleController.maxMartialTrain = tempMaxMartialTrain;
		CastleController.maxSecurityTrain = tempMaxSecurityTrain;
		CastleController.castleDailyReport = tempCastleDailyReport;

	}



	static void verifyID(int idxR){
		if (RulesNPC.savedRules [idxR].id != NPCCharList.CharRetainers [RulesNPC.savedRules [idxR].idx].charID) {
			int i = idxR;
			while (i >= 0) {
				if (RulesNPC.savedRules [idxR].id == NPCCharList.CharRetainers [i].charID) {
					RulesNPC.savedRules [idxR].idx = i;
					return;
				}
				i--;
			}
		}

	}

	static void resetCastle(){
		tempCastleCleanliness = 0; tempCastleFoodQuality = 0; tempCastleSecurity = 0; /*tempCastleSupplies = 0;*/ tempCastleHealthcare = 0; tempSlaveMasterEff = 0;
		tempMaxSecurityTrain = 0; tempMaxMartialTrain = 0; tempCastleDailyReport = "";
		int hashcode = GameControl.playerName.GetHashCode();
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond ); 
	}

}
