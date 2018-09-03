using UnityEngine;
using System.Collections;

public class CastleLivingConditionsUpdate {



	public static string updateConditions(int idx, int idxRL){
		string ret = "";
		ret += updateWages (RulesNPC.savedRules[idxRL].wage, idx);
		updateSleep (RulesNPC.savedRules [idxRL].sleeping, idx);
		ret += updateDiet (RulesNPC.savedRules [idxRL].diet, RulesNPC.savedRules [idxRL].foodAphrodisiacs, idx);
		ret += updateHealthcare (idx);
		ret += updateMentalcare (idx);
		updateCleanliness (idx);
		return ret;
	}




	static string updateWages(fileRulesNPC.Wages wage, int idx){
		if (NPCCharList.CharRetainers [idx].isSlave) {
			//slave
			switch(wage){
			case fileRulesNPC.Wages.None:
				NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 2);
				return "";
			case fileRulesNPC.Wages.Low:
				if (GameControl.charGold < 1) {
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 2);
					return "\n\nYou didn't had enough money to pay " +NPCCharList.CharRetainers [idx].charName + "'s wage!" ;
				}
				GameControl.charGold -= 1;
				NPCCharList.CharRetainers [idx].attHappiness += Random.Range (0, 1.5f);
				NPCCharList.CharRetainers [idx].charLoyalty += Random.Range (0, 0.5f);
				return "";
			case fileRulesNPC.Wages.Average: 
				if (GameControl.charGold < 3) {
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 2);
					return "\n\nYou didn't had enough money to pay " +NPCCharList.CharRetainers [idx].charName + "'s wage!" ;
				}
				if (NPCCharList.CharRetainers [idx].attObedience < 50) {
					NPCCharList.CharRetainers [idx].attSpoiled += Random.Range (0, 2);
					NPCCharList.CharRetainers [idx].attObedience += Random.Range (0, 1);
				}
				GameControl.charGold -= 3;
				NPCCharList.CharRetainers [idx].attHappiness += Random.Range (1, 3);
				NPCCharList.CharRetainers [idx].charLoyalty += Random.Range (0, 1);
				return "";
			case fileRulesNPC.Wages.Good: 
				if (GameControl.charGold < 5) {
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 2);
					return "\n\nYou didn't had enough money to pay " +NPCCharList.CharRetainers [idx].charName + "'s wage!" ;
				}
				if (NPCCharList.CharRetainers [idx].attObedience < 50) {
					NPCCharList.CharRetainers [idx].attSpoiled += Random.Range (0, 4);
					NPCCharList.CharRetainers [idx].attObedience += Random.Range (0, 1.5f);
				}
				GameControl.charGold -= 5;
				NPCCharList.CharRetainers [idx].attHappiness += Random.Range (1.5f, 4);
				NPCCharList.CharRetainers [idx].charLoyalty += Random.Range (0, 1.5f);
				return "";
			case fileRulesNPC.Wages.High: 
				if (GameControl.charGold < 10) {
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 2);
					return "\n\nYou didn't had enough money to pay " +NPCCharList.CharRetainers [idx].charName + "'s wage!" ;
				}
				if (NPCCharList.CharRetainers [idx].attObedience < 50) {
					NPCCharList.CharRetainers [idx].attSpoiled += Random.Range (0, 6);
					NPCCharList.CharRetainers [idx].attObedience += Random.Range (0, 2f);
				}
				GameControl.charGold -= 10;
				NPCCharList.CharRetainers [idx].attHappiness += Random.Range (2, 5);
				NPCCharList.CharRetainers [idx].charLoyalty += Random.Range (0, 2);
				return "";
			case fileRulesNPC.Wages.Exorbitant: 
				if (GameControl.charGold < 20) {
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 2);
					return "\n\nYou didn't had enough money to pay " +NPCCharList.CharRetainers [idx].charName + "'s wage!" ;
				}
				if (NPCCharList.CharRetainers [idx].attObedience < 50) {
					NPCCharList.CharRetainers [idx].attSpoiled += Random.Range (0, 8);
					NPCCharList.CharRetainers [idx].attObedience += Random.Range (0, 2.5f);
				}
				GameControl.charGold -= 20;
				NPCCharList.CharRetainers [idx].attHappiness += Random.Range (3, 7);
				NPCCharList.CharRetainers [idx].charLoyalty += Random.Range (1, 3);
				return "";

			}
		} else {
			//free
			switch(wage){
			case fileRulesNPC.Wages.None:
				NPCCharList.CharRetainers [idx].attHappiness -= 1 +Random.Range (0, 2);
				NPCCharList.CharRetainers [idx].charLoyalty -= Random.Range (0, 1.5f);
				return "";
			case fileRulesNPC.Wages.Low:
				if (GameControl.charGold < 1) {
					NPCCharList.CharRetainers [idx].attHappiness -= 1 + Random.Range (0, 2);
					NPCCharList.CharRetainers [idx].charLoyalty -= Random.Range (0, 1.5f);
					return "\n\nYou didn't had enough money to pay " +NPCCharList.CharRetainers [idx].charName + "'s wage!";
				}
				GameControl.charGold -= 1;
				NPCCharList.CharRetainers [idx].attHappiness += Random.Range (0, 1f);
				NPCCharList.CharRetainers [idx].charLoyalty += Random.Range (0, 1f);
				return "";
			case fileRulesNPC.Wages.Average: 
				if (GameControl.charGold < 3) {
					NPCCharList.CharRetainers [idx].attHappiness -= 1 + Random.Range (0, 2);
					NPCCharList.CharRetainers [idx].charLoyalty -= Random.Range (0, 1.5f);
					return "\n\nYou didn't had enough money to pay " +NPCCharList.CharRetainers [idx].charName + "'s wage!";
				}
				GameControl.charGold -= 3;
				NPCCharList.CharRetainers [idx].attHappiness += Random.Range (1, 3);
				return "";
			case fileRulesNPC.Wages.Good: 
				if (GameControl.charGold < 5) {
					NPCCharList.CharRetainers [idx].attHappiness -= 1 + Random.Range (0, 2);
					NPCCharList.CharRetainers [idx].charLoyalty -= Random.Range (0, 1.5f);
					return "\n\nYou didn't had enough money to pay " +NPCCharList.CharRetainers [idx].charName + "'s wage!";
				}
				GameControl.charGold -= 5;
				NPCCharList.CharRetainers [idx].attHappiness += Random.Range (2, 4);
				NPCCharList.CharRetainers [idx].charLoyalty += Random.Range (0, 2f);
				return"";
			case fileRulesNPC.Wages.High: 
				if (GameControl.charGold < 10) {
					NPCCharList.CharRetainers [idx].attHappiness -= 1 + Random.Range (0, 2);
					NPCCharList.CharRetainers [idx].charLoyalty -= Random.Range (0, 1.5f);
					return "\n\nYou didn't had enough money to pay " +NPCCharList.CharRetainers [idx].charName + "'s wage!";
				}
				GameControl.charGold -= 10;
				NPCCharList.CharRetainers [idx].attHappiness += Random.Range (3, 5);
				NPCCharList.CharRetainers [idx].charLoyalty += Random.Range (0.5f, 1.5f);
				return "";
			case fileRulesNPC.Wages.Exorbitant: 
				if (GameControl.charGold < 20) {
					NPCCharList.CharRetainers [idx].attHappiness -= 1 + Random.Range (0, 2);
					NPCCharList.CharRetainers [idx].charLoyalty -= Random.Range (0, 1.5f);
					return "\n\nYou didn't had enough money to pay " +NPCCharList.CharRetainers [idx].charName + "'s wage!";
				}
				GameControl.charGold -= 20;
				NPCCharList.CharRetainers [idx].attHappiness += Random.Range (3, 7);
				NPCCharList.CharRetainers [idx].charLoyalty += Random.Range (0.5f, 2f);
				return "";

			}
		}
		return "bug in CastleLivingConditionsUpdate.updateWage";


	}


	static void updateSleep(fileRulesNPC.Sleeping sleeping, int idx){
		if (NPCCharList.CharRetainers [idx].isSlave) {
			switch(sleeping){
			case fileRulesNPC.Sleeping.Ground:
				if ((int)NPCCharList.CharRetainers [idx].bgUpbring >= 3) {
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (1, 2.5f);
				}
				NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (1, 3);
				return;
			case fileRulesNPC.Sleeping.Barracks:
				if ((int)NPCCharList.CharRetainers [idx].bgUpbring >= 3) {
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0.5f, 1.5f);
				}
				return;
			case fileRulesNPC.Sleeping.PrivateRoom:
				NPCCharList.CharRetainers [idx].attHappiness += 0.5f + Random.Range (0, 2);
				return;
			case fileRulesNPC.Sleeping.Boudoir:
				NPCCharList.CharRetainers [idx].attHappiness += 1f + Random.Range (0, 4);
				return;
			case fileRulesNPC.Sleeping.MCRoom:
				if (NPCCharList.CharRetainers [idx].charRelationship >= 70) {
					NPCCharList.CharRetainers [idx].attHappiness += Random.Range (1, 5f);
				} else if (NPCCharList.CharRetainers [idx].charRelationship < 30) {
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 2);
				} else {
					NPCCharList.CharRetainers [idx].attHappiness += Random.Range (0, 3.5f);
				}
				return;
			case fileRulesNPC.Sleeping.Dungeon:
				if ((int)NPCCharList.CharRetainers [idx].bgUpbring >= 3) {
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0.5f, 3f);
				}
				NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (1, 5);

				return;
			}

		} else {
			switch(sleeping){
			case fileRulesNPC.Sleeping.Ground:
				if ((int)NPCCharList.CharRetainers [idx].bgUpbring >= 3) {
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 1.5f);
				}
				NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 3.5f);
				return;
			case fileRulesNPC.Sleeping.Barracks:
				if ((int)NPCCharList.CharRetainers [idx].bgUpbring >= 3) {
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0f, 1f);
				}
				NPCCharList.CharRetainers [idx].attHappiness += Random.Range (0f, 1f);
				return;
			case fileRulesNPC.Sleeping.PrivateRoom:
				NPCCharList.CharRetainers [idx].attHappiness += 1f + Random.Range (0, 2);
				return;
			case fileRulesNPC.Sleeping.Boudoir:
				NPCCharList.CharRetainers [idx].attHappiness += 1.5f + Random.Range (0, 3);
				return;
			case fileRulesNPC.Sleeping.MCRoom:
				if (NPCCharList.CharRetainers [idx].charRelationship >= 70) {
					NPCCharList.CharRetainers [idx].attHappiness += Random.Range (1, 5f);
				} else if (NPCCharList.CharRetainers [idx].charRelationship < 30) {
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 2);
				} else {
					NPCCharList.CharRetainers [idx].attHappiness += Random.Range (0, 3.5f);
				}
				return;
			case fileRulesNPC.Sleeping.Dungeon:
				if ((int)NPCCharList.CharRetainers [idx].bgUpbring >= 3) {
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0.5f, 3f);
				}
				NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (2, 7);

				return;
			}
		}
	}





	static string updateDiet(fileRulesNPC.Diet diet, bool aphrodisiac, int idx){
		Random.InitState (WorldControl.day * System.DateTime.Now.Millisecond +15 ); 
		if (aphrodisiac && CastleController.castleSupplies > 5) {
			CastleController.castleSupplies--;
			NPCCharList.CharRetainers [idx].currentArousal += Random.Range (4, 15);
		}

		if (NPCCharList.CharRetainers [idx].isSlave) {
			switch (diet) {
			case fileRulesNPC.Diet.RancidFood:
				if ((int)NPCCharList.CharRetainers [idx].bgUpbring >= 3){
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (1f, 3f);
				}
				NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 3);
				return "";
			case fileRulesNPC.Diet.CheapFood:
				if (CastleController.castleSupplies >= 1) {
					CastleController.castleSupplies--;
					if ((int)NPCCharList.CharRetainers [idx].bgUpbring >= 3) {
						NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0.5f, 1.5f) - CastleController.castleFoodQuality;
					}
					return "";
				} else {
					if ((int)NPCCharList.CharRetainers [idx].bgUpbring >= 3){
						NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (1f, 3f);
					}
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 3);
					return "\n\nYou don't have enough supplies for food! You forced " + NPCCharList.CharRetainers [idx].charName + " to eat rancid food!" ;
				}
			case fileRulesNPC.Diet.FreshFood:
				if (CastleController.castleSupplies >= 2) {
					CastleController.castleSupplies -= 2;
					NPCCharList.CharRetainers [idx].attHappiness += Random.Range (1.5f, 3.5f) * CastleController.castleFoodQuality;
					return "";
				} else {
					if ((int)NPCCharList.CharRetainers [idx].bgUpbring >= 3){
						NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (1f, 3f);
					}
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 3);
					return "\n\nYou don't have enough supplies for food! You forced " + NPCCharList.CharRetainers [idx].charName + " to eat rancid food!" ;
				}
			case fileRulesNPC.Diet.LeftOvers:
				if (CastleController.castleSupplies >= 2) {
					CastleController.castleSupplies -= 2;
					NPCCharList.CharRetainers [idx].attHappiness += Random.Range (2f, 4.5f) * CastleController.castleFoodQuality;
					return "";
				} else {
					if ((int)NPCCharList.CharRetainers [idx].bgUpbring >= 3){
						NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (1f, 3f);
					}
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 3);
					return "\n\nYou don't have enough supplies for food! You forced " + NPCCharList.CharRetainers [idx].charName + " to eat rancid food!" ;
				}

			case fileRulesNPC.Diet.BeastsCum:
				if (NPCCharList.CharRetainers [idx].charCorruption < 60) {
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (4, 8);
				} else if (NPCCharList.CharRetainers [idx].charCorruption < 80) {
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (2, 4);
				} else {
					NPCCharList.CharRetainers [idx].attHappiness += Random.Range (1, 3);
				}
				return "";

			}
		} else {
			switch (diet) {
			case fileRulesNPC.Diet.RancidFood:
				if ((int)NPCCharList.CharRetainers [idx].bgUpbring >= 3){
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (1f, 3f);
				}
				NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (2, 5);
				return "";
			case fileRulesNPC.Diet.CheapFood:
				if (CastleController.castleSupplies >= 1) {
					CastleController.castleSupplies -= 1;
					if ((int)NPCCharList.CharRetainers [idx].bgUpbring >= 3) {
						NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0f, 1f) - CastleController.castleFoodQuality;
					}
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0f, 1f) - CastleController.castleFoodQuality;
					return "";
				} else {
					if ((int)NPCCharList.CharRetainers [idx].bgUpbring >= 3){
						NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (1f, 3f);
					}
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (2, 5);
					return "\n\nYou don't have enough supplies for food! You forced " + NPCCharList.CharRetainers [idx].charName + " to eat rancid food!";
				}

			case fileRulesNPC.Diet.FreshFood:
				if (CastleController.castleSupplies >= 2) {
					CastleController.castleSupplies -= 2;
					NPCCharList.CharRetainers [idx].attHappiness += Random.Range (1f, 2.5f) * CastleController.castleFoodQuality;
					return "";
				} else {
					if ((int)NPCCharList.CharRetainers [idx].bgUpbring >= 3){
						NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (1f, 3f);
					}
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (2, 5);
					return "\n\nYou don't have enough supplies for food! You forced " + NPCCharList.CharRetainers [idx].charName + " to eat rancid food!";
				}

			case fileRulesNPC.Diet.LeftOvers:
				if (CastleController.castleSupplies >= 2) {
					CastleController.castleSupplies -= 2;
					NPCCharList.CharRetainers [idx].attHappiness += Random.Range (2f, 4f) * CastleController.castleFoodQuality;
					return "";
				} else {
					if ((int)NPCCharList.CharRetainers [idx].bgUpbring >= 3){
						NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (1f, 3f);
					}
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (2, 5);
					return "\n\nYou don't have enough supplies for food! You forced " + NPCCharList.CharRetainers [idx].charName + " to eat rancid food!";
				}

			case fileRulesNPC.Diet.BeastsCum:
				if (NPCCharList.CharRetainers [idx].charCorruption < 60) {
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (5, 10);
				} else if (NPCCharList.CharRetainers [idx].charCorruption < 80) {
					NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (2.5f, 5);
				} else {
					NPCCharList.CharRetainers [idx].attHappiness += Random.Range (1, 3);
				}
				return "";
			}
		}
		return "bug in CastleLivingConditionsUpdate.updateDiet";
	}

	static string updateHealthcare(int idx){
		
		NPCCharList.CharRetainers [idx].currentHealth += Random.Range (2, 5); // this is the daily base

		if (NPCCharList.CharRetainers [idx].currentHealth < NPCCharList.CharRetainers [idx].maxHealth && CastleController.castleHealthcare > 0) {
			if (CastleController.castleSupplies > 1) {
				CastleController.castleSupplies--;
				NPCCharList.CharRetainers [idx].currentHealth += (2 + Random.Range(0,5)) * CastleController.castleHealthcare;
				return "\n\n" + NPCCharList.CharRetainers [idx].charName + " has been attended by your healer.";
			} else {
				return "\n\nNot enough supplies for the healer to attend " + NPCCharList.CharRetainers [idx].charName + "!";
			}

		}
		return "";


	}

	static string updateMentalcare(int idx){

		if (NPCCharList.CharRetainers [idx].attHappiness < 40 && CastleController.castleMentalcare > 0) {

			NPCCharList.CharRetainers [idx].attHappiness += Random.Range (1, 5) * CastleController.castleMentalcare;
			string HESHE = "He", himher = "him";
			if (NPCCharList.CharRetainers [idx].charGender == NPCData.CharGender.FEMALE) {
				HESHE = "She";
				himher = "her";
			}
			return "\n\n" + HESHE + " visted your counselor, who helped " + himher + " to feel better.";
		}
		return "";
	}

	static void updateCleanliness(int idx){
		if (CastleController.castleCleanliness < 20) {
			NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0.5f, 2);
		} else if (CastleController.castleCleanliness < 40) {
			NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 1f);
		} else if (CastleController.castleCleanliness > 80) {
			NPCCharList.CharRetainers [idx].attHappiness += Random.Range (0, 1f);
		}
	}





}
