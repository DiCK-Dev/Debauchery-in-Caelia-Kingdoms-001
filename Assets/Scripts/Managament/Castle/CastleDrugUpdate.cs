using UnityEngine;
using System.Collections;

public class CastleDrugUpdate  {


	public static string drugUpdate(int idx, int idxRL){
		string ret = "";
		ret += useTobacco (idx, idxRL);
		ret += useAlcohol (idx, idxRL);
		ret += useDevil(idx, idxRL);
		ret += useDust(idx, idxRL);
		ret += useBluecap(idx,idxRL);

		return ret;
	}


	static string useTobacco(int idx, int idxRL){

		if (RulesNPC.savedRules [idxRL].drugForcedUse && RulesNPC.savedRules [idxRL].drugTobacco && CastleController.castleSupplies >= 1) {
			tobbacoConsumption (idx, 1);
			NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 3);
			return "\n\nYou forced " + NPCCharList.CharRetainers [idx].charName + " to smoke tobacco today." ;

		}

		if (CastleController.castleSupplies < 1 && RulesNPC.savedRules [idxRL].drugTobacco) {
			if (NPCCharList.CharRetainers [idx].charAddictions [0] > 50) {
				useTabaccoWithdraw (idx, 0);
			} else if (NPCCharList.CharRetainers [idx].charAddictions [0] > 30) {
				useTabaccoWithdraw(idx, 1);
			} 
			return "\n\nYou don't have enough supplies to give tobbaco to " +  NPCCharList.CharRetainers [idx].charName + "." ;
		}

		int randNum = Random.Range (0, 100);
		if (RulesNPC.savedRules [idxRL].drugTobacco) {
			if (NPCCharList.CharRetainers [idx].charAddictions [0] > 70) {
				tobbacoConsumption (idx, 0);
				return "\n\n" +NPCCharList.CharRetainers [idx].charName + " had its daily dose of cigarettes.";
			} else if (NPCCharList.CharRetainers [idx].charAddictions [0] >= 50 || NPCCharList.CharRetainers [idx].attMorality <= 30 || NPCCharList.CharRetainers [idx].charCorruption >= 40) {
				if (randNum >= 50) {
					tobbacoConsumption (idx, 1);
					return "\n\n" + NPCCharList.CharRetainers [idx].charName + " had its daily dose of cigarettes.";
				} else {
					if (NPCCharList.CharRetainers [idx].charAddictions [0] >= 30) {
						useTabaccoWithdraw (idx, 2);
					}
					return "\n\n" + NPCCharList.CharRetainers [idx].charName + " refused to smoke today.";
				}


			} else if (NPCCharList.CharRetainers [idx].charAddictions [0] >= 30 || NPCCharList.CharRetainers [idx].attMorality <= 55 || NPCCharList.CharRetainers [idx].charCorruption >= 40) {
				if (randNum >= 75) {
					tobbacoConsumption (idx, 1);
					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " had its daily dose of cigarettes.";

				} else {
					if (NPCCharList.CharRetainers [idx].charAddictions [0] >= 30) {
						useTabaccoWithdraw (idx, 2);
					}
					return "\n\n" + NPCCharList.CharRetainers [idx].charName + " refused to smoke today.";
				}

			}else {
				if (randNum >= 75) {
					tobbacoConsumption (idx, 1);
					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " had its daily dose of cigarettes.";

				} else {
					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " refused to smoke today.";
				}
			}
		} else {
			if (NPCCharList.CharRetainers [idx].charAddictions [0] > 70) {
				useTabaccoWithdraw (idx, 0);
				return "\n\n" +NPCCharList.CharRetainers [idx].charName + " couldn't smoke today, worsening it's mood and health.";
			} else if (NPCCharList.CharRetainers [idx].charAddictions [0] > 30) {
				useTabaccoWithdraw (idx, 1);
				return"\n\n" + NPCCharList.CharRetainers [idx].charName + " couldn't smoke today, worsening it's mood and health.";
			} else {
				return "";
			}

		}

	}

	static void tobbacoConsumption(int idx, int selector){
		CastleController.castleSupplies -= 1;
		if (NPCCharList.CharRetainers [idx].attObedience < 50) {
			NPCCharList.CharRetainers [idx].attObedience += 0.3f;
		}
		if (NPCCharList.CharRetainers [idx].charCorruption < 10) {
			NPCCharList.CharRetainers [idx].charCorruption += 0.1f;
		}
		if (NPCCharList.CharRetainers [idx].attTemperament > 90) {
			NPCCharList.CharRetainers [idx].attTemperament -= 0.15f;
		}
		NPCCharList.CharRetainers [idx].currentHealth -= Random.Range (0, 2);
		NPCCharList.CharRetainers [idx].charAddictions [0] += Random.Range (0, 4);

		if (selector == 0) { // high add
			NPCCharList.CharRetainers [idx].attHappiness += 0.5f;
		}
		if (selector == 1) { // low add
			NPCCharList.CharRetainers [idx].attHappiness += 1.5f;
		}
	}


	static void useTabaccoWithdraw(int idx, int selector){
		
		if (selector == 0) {
			// high withdraw
			NPCCharList.CharRetainers [idx].attHappiness -= 2;
			NPCCharList.CharRetainers [idx].attObedience -= 0.3f;
			if (NPCCharList.CharRetainers [idx].attTemperament > 25) {
				NPCCharList.CharRetainers [idx].attTemperament -= 0.35f;
			}
			NPCCharList.CharRetainers [idx].currentHealth -= Random.Range (0, 5);
			NPCCharList.CharRetainers [idx].charAddictions [0] -= Random.Range (0, 3);
		} else if(selector == 1) {
			NPCCharList.CharRetainers [idx].attHappiness -= 0.7f;
			NPCCharList.CharRetainers [idx].attObedience -= 0.15f;
			if (NPCCharList.CharRetainers [idx].attTemperament > 25) {
				NPCCharList.CharRetainers [idx].attTemperament -= 0.15f;
			}
			NPCCharList.CharRetainers [idx].currentHealth -= Random.Range (0, 2.5f);
			NPCCharList.CharRetainers [idx].charAddictions [0] -= Random.Range (0, 3);
		} else if(selector == 2) {
			//personal withdraw
			NPCCharList.CharRetainers [idx].attHappiness -= 0.35f;
			NPCCharList.CharRetainers [idx].currentHealth -= Random.Range (0, 1.25f);
			NPCCharList.CharRetainers [idx].charAddictions [0] -= Random.Range (0, 3);
		}
	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	static string useAlcohol(int idx, int idxRL){
		if (RulesNPC.savedRules [idxRL].drugForcedUse && RulesNPC.savedRules [idxRL].drugAlcohol && CastleController.castleSupplies >= 1) {
			alcoholConsumption (idx, 1);
			NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 4);
			return "\n\n" +"You forced " + NPCCharList.CharRetainers [idx].charName + " to drink alcohol today." ;

		}

		if (CastleController.castleSupplies < 1 && RulesNPC.savedRules [idxRL].drugAlcohol) {
			if (NPCCharList.CharRetainers [idx].charAddictions [1] > 65) {
				alcoholWithdraw (idx, 0);
			} else if (NPCCharList.CharRetainers [idx].charAddictions [2] > 30) {
				alcoholWithdraw(idx, 1);
			} 
			return "\n\n" +"You don't have enough supplies to give alcohol to " +  NPCCharList.CharRetainers [idx].charName + "." ;
		}

		int randNum = Random.Range (0, 100);
		if (RulesNPC.savedRules [idxRL].drugAlcohol) {
			if (NPCCharList.CharRetainers [idx].charAddictions [1] >= 85) {
				alcoholConsumption (idx, 0);
				return "\n\n" +NPCCharList.CharRetainers [idx].charName + " had its daily dose of alcohol.";
			} else if (NPCCharList.CharRetainers [idx].charAddictions [1] >= 65 || NPCCharList.CharRetainers [idx].attMorality <= 20 || NPCCharList.CharRetainers [idx].charCorruption >= 45) {
				if (randNum >= 50) {
					alcoholConsumption (idx, 1);

					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " had its daily dose of alcohol.";
				} else {
					if (NPCCharList.CharRetainers [idx].charAddictions [1] >= 35) {
						alcoholWithdraw (idx, 2);
					}
					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " refused to drink alcohol.";
				}


			} else if (NPCCharList.CharRetainers [idx].charAddictions [1] >= 35 || NPCCharList.CharRetainers [idx].attMorality <= 60 || NPCCharList.CharRetainers [idx].charCorruption >= 25) {
				if (randNum >= 75) {
			
					alcoholConsumption (idx, 1);
					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " had its daily dose of alcohol.";

				} else {
					if (NPCCharList.CharRetainers [idx].charAddictions [1] >= 35) {
						alcoholWithdraw (idx, 2);
					}
					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " refused to drink alcohol today.";
				}

			}else {
				if (randNum >= 85) {

					alcoholConsumption (idx, 1);
					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " had its daily dose of alcohol.";

				} else {
					return "\n\n" + NPCCharList.CharRetainers [idx].charName + " refused to drink today.";
				}
			}
		} else {
			if (NPCCharList.CharRetainers [idx].charAddictions [1] > 85) {
				alcoholWithdraw (idx, 0);
				return "\n\n" +NPCCharList.CharRetainers [idx].charName + " couldn't drink today, worsening it's mood and health.";
			} else if (NPCCharList.CharRetainers [idx].charAddictions [1] > 35) {
				alcoholWithdraw (idx, 1);
				return "\n\n" +NPCCharList.CharRetainers [idx].charName + " couldn't drink today, worsening it's mood and health.";
			} else {
				return "";
			}
		}
	}

	static void alcoholWithdraw(int idx, int selector){
		if (selector == 0) { // high add no drug
			NPCCharList.CharRetainers [idx].attHappiness -= 3f;
			NPCCharList.CharRetainers [idx].attObedience -= 0.5f;
			if (NPCCharList.CharRetainers [idx].attTemperament > 10) {
				NPCCharList.CharRetainers [idx].attTemperament -= 0.35f;
			}
			NPCCharList.CharRetainers [idx].currentHealth -= Random.Range (2, 8);
			NPCCharList.CharRetainers [idx].charAddictions[1] -= Random.Range(0f,2f);
		}

		if (selector == 1) { // low add no drug
			NPCCharList.CharRetainers [idx].attHappiness -= 1.5f;
			NPCCharList.CharRetainers [idx].attObedience -= 0.25f;
			if (NPCCharList.CharRetainers [idx].attTemperament > 10) {
				NPCCharList.CharRetainers [idx].attTemperament -= 0.15f;
			}
			NPCCharList.CharRetainers [idx].currentHealth -= Random.Range (1, 4);
			NPCCharList.CharRetainers [idx].charAddictions[1] -= 3f;
		}

		if (selector == 2) { // ref drug 
			NPCCharList.CharRetainers [idx].attHappiness -= 0.75f;
			if (NPCCharList.CharRetainers [idx].attTemperament < 90) {
				NPCCharList.CharRetainers [idx].attTemperament += 0.075f;
			}
			NPCCharList.CharRetainers [idx].charAddictions[1] -= Random.Range(0,2);
		}
	}

	static void alcoholConsumption(int idx, int selector){
		CastleController.castleSupplies -= 1;
		if (NPCCharList.CharRetainers [idx].charCorruption < 15) {
			NPCCharList.CharRetainers [idx].charCorruption += 0.15f;
		}
		if (NPCCharList.CharRetainers [idx].attNature > 85) {
			NPCCharList.CharRetainers [idx].attNature -= 0.2f;
		}
		if (NPCCharList.CharRetainers [idx].attObedience < 60) {
			NPCCharList.CharRetainers [idx].attObedience += 0.35f;
		}
		NPCCharList.CharRetainers [idx].charAddictions[1] += Random.Range (0, 1.5f);

		if (selector == 0) { // high add
			NPCCharList.CharRetainers [idx].attHappiness += 1.5f;
		}
		if (selector == 1) { // low add
			NPCCharList.CharRetainers [idx].attHappiness += 2.5f;
		}
	}



	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



	static string useDevil(int idx, int idxRL){
		if (RulesNPC.savedRules [idxRL].drugForcedUse && RulesNPC.savedRules [idxRL].drugDevilsFire && CastleController.castleSupplies >= 2) {
			devilConsumption (idx, 1);
			NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 4);
			CastleController.castleSupplies -= 2;
			return "\n\n" +"You forced " + NPCCharList.CharRetainers [idx].charName + " to use devil's fire today." ;

		}


		if (CastleController.castleSupplies < 2 && RulesNPC.savedRules [idxRL].drugDevilsFire) {
			if (NPCCharList.CharRetainers [idx].charAddictions [2] > 50) {
				devilWithdraw(idx, 0);
			} else if (NPCCharList.CharRetainers [idx].charAddictions [2] > 20) {
				devilWithdraw (idx, 1);
			} 
			return "\n\n" +"You don't have enough supplies to give devil's fire to " +  NPCCharList.CharRetainers [idx].charName + "." ;
		}




		int randNum = Random.Range (0, 100);
		if (RulesNPC.savedRules [idxRL].drugDevilsFire) {
			if (NPCCharList.CharRetainers [idx].charAddictions [2] >= 50) {
				devilConsumption (idx, 0);
				return "\n\n" +NPCCharList.CharRetainers [idx].charName + " had its daily dose of devil's fire.";
			} else if (NPCCharList.CharRetainers [idx].charAddictions [2] >= 35 || NPCCharList.CharRetainers [idx].attMorality <= 10 || NPCCharList.CharRetainers [idx].charCorruption >= 80) {
				if (randNum >= 50) {
					devilConsumption (idx, 1);
					CastleController.castleSupplies -= 2;

					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " had its daily dose of devil's fire.";
				} else {
					if (NPCCharList.CharRetainers [idx].charAddictions [2] >= 20) {
						devilWithdraw(idx, 2);
					}
					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " refused to consume devil's fire.";
				}


			} else if (NPCCharList.CharRetainers [idx].charAddictions [2] >= 20 || NPCCharList.CharRetainers [idx].attMorality <= 20 || NPCCharList.CharRetainers [idx].charCorruption >= 65) {
				if (randNum >= 75) {
					CastleController.castleSupplies -= 2;
					devilConsumption (idx, 1);
					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " had its daily dose of devil's fire.";

				} else {
					if (NPCCharList.CharRetainers [idx].charAddictions [2] >= 20) {
						devilWithdraw (idx, 2);
					}
					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " refused to consume devil's fire today.";
				}

			}else {
				if (randNum >= 98) {

					devilConsumption (idx, 1);
					CastleController.castleSupplies -= 2;
					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " had its daily dose of devil's fire.";

				} else {
					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " refused to consume devil's fire.";
				}
			}
		} else {
			if (NPCCharList.CharRetainers [idx].charAddictions [2] > 50) {
				devilWithdraw (idx, 0);
				return "\n\n" +NPCCharList.CharRetainers [idx].charName + " couldn't consume devil's fire today, worsening it's mood and health.";
			} else if (NPCCharList.CharRetainers [idx].charAddictions [2] > 20) {
				devilWithdraw (idx, 1);
				return "\n\n" +NPCCharList.CharRetainers [idx].charName + " couldn't consume devil's fire today, worsening it's mood and health.";
			} else {
				return "";
			}
		}
	}




	static void devilWithdraw(int idx, int selector){
		if (NPCCharList.CharRetainers [idx].attPhysical > 30) {
			NPCCharList.CharRetainers [idx].attPhysical -= 1 + Random.Range (0, 3);
		}

		if (selector == 0) { // high add no drug
			NPCCharList.CharRetainers [idx].attHappiness -= 3f + Random.Range(0,5);
			NPCCharList.CharRetainers [idx].attObedience -= Random.Range (0, 2);
			if (NPCCharList.CharRetainers [idx].attTemperament > 10) {
				NPCCharList.CharRetainers [idx].attTemperament -= Random.Range(0,2);
			}
			NPCCharList.CharRetainers [idx].currentHealth -= Random.Range (4, 14);
			NPCCharList.CharRetainers [idx].charAddictions[2] -= Random.Range (0, 2);
		}

		if (selector == 1) { // low add no drug
			NPCCharList.CharRetainers [idx].attHappiness -= 1.5f + Random.Range(0,2.5f);
			NPCCharList.CharRetainers [idx].attObedience -= Random.Range(0,1.25f);
			if (NPCCharList.CharRetainers [idx].attTemperament > 10) {
				NPCCharList.CharRetainers [idx].attTemperament -= Random.Range(0,2);
			}
			NPCCharList.CharRetainers [idx].currentHealth -= Random.Range (2, 8);
			NPCCharList.CharRetainers [idx].charAddictions[2] -= Random.Range(0,2);
		}

		if (selector == 2) { // ref drug 
			NPCCharList.CharRetainers [idx].attHappiness -= Random.Range(0,2f);
			NPCCharList.CharRetainers [idx].attHappiness -= 0.75f;
			if (NPCCharList.CharRetainers [idx].attTemperament < 90) {
				NPCCharList.CharRetainers [idx].attTemperament += 0.15f;
			}
			NPCCharList.CharRetainers [idx].charAddictions[2] -= Random.Range(0,3);
		}

	}

	static void devilConsumption(int idx, int selector){
		if (NPCCharList.CharRetainers [idx].charCorruption < 90) {
			NPCCharList.CharRetainers [idx].charCorruption += 0.5f + Random.Range (0.5f, 3.5f);
		}
		if (NPCCharList.CharRetainers [idx].attWillpower > 10) {
			NPCCharList.CharRetainers [idx].attWillpower -= 0.5f + Random.Range (0, 2);
		}
		if (NPCCharList.CharRetainers [idx].attNature > 10) {
			NPCCharList.CharRetainers [idx].attNature -= 0.5f + Random.Range (0, 2);
		}
		if (NPCCharList.CharRetainers [idx].attObedience < 90) {
			NPCCharList.CharRetainers [idx].attObedience += 1 + Random.Range(0,3);
		}
		if (NPCCharList.CharRetainers [idx].attPhysical < 85) {
			NPCCharList.CharRetainers [idx].attPhysical += 0.5f + Random.Range(0,2);
		}
		if (NPCCharList.CharRetainers [idx].attMental > 10) {
			NPCCharList.CharRetainers [idx].attMental -= 1.5f + Random.Range(0,2);
		}
		if (NPCCharList.CharRetainers [idx].attSocial > 10) {
			NPCCharList.CharRetainers [idx].attSocial -= 1.5f + Random.Range(0,2);
		}
		NPCCharList.CharRetainers [idx].charAddictions[2] += 2 + Random.Range (0, 5f);

		if (selector == 0) { // high add
			NPCCharList.CharRetainers [idx].attHappiness += Random.Range(-2,5);
		}
		if (selector == 1) { // low add
			NPCCharList.CharRetainers [idx].attHappiness += Random.Range(0,7);
		}
	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


	static string useDust(int idx, int idxRL){
		if (RulesNPC.savedRules [idxRL].drugForcedUse && RulesNPC.savedRules [idxRL].drugDust && CastleController.castleSupplies >= 6) {
			dustConsumption (idx, 1);
			NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 3);
			return "\n\n" +"You forced " + NPCCharList.CharRetainers [idx].charName + " to use dust today." ;
		}

		if (CastleController.castleSupplies < 6 && RulesNPC.savedRules [idxRL].drugDust) {
			if (NPCCharList.CharRetainers [idx].charAddictions [3] > 55) {
				dustWithdraw(idx, 0);
			} else if (NPCCharList.CharRetainers [idx].charAddictions [3] > 30) {
				dustWithdraw (idx, 1);
			} 
			return "\n\n" +"You don't have enough supplies to give dust to " +  NPCCharList.CharRetainers [idx].charName + "." ;
		}



		int randNum = Random.Range (0, 100);
		if (RulesNPC.savedRules [idxRL].drugDust) {
			if (NPCCharList.CharRetainers [idx].charAddictions [3] >= 70) {
				dustConsumption (idx, 0);
				return "\n\n" + NPCCharList.CharRetainers [idx].charName + " had its daily dose of dust.";
			} else if (NPCCharList.CharRetainers [idx].charAddictions [3] >= 55 || NPCCharList.CharRetainers [idx].attMorality <= 20 || NPCCharList.CharRetainers [idx].charCorruption >= 60) {
				if (randNum >= 50) {
					dustConsumption (idx, 1);

					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " had its daily dose of dust.";
				} else {
					if (NPCCharList.CharRetainers [idx].charAddictions [3] >= 30) {
						dustWithdraw (idx, 2);
					}
					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " refused to consume dust.";
				}


			} else if (NPCCharList.CharRetainers [idx].charAddictions [3] >= 30 || NPCCharList.CharRetainers [idx].attMorality <= 35 || NPCCharList.CharRetainers [idx].charCorruption >= 45) {
				if (randNum >= 75) {

					dustConsumption (idx, 1);
					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " had its daily dose of dust.";

				} else {
					if (NPCCharList.CharRetainers [idx].charAddictions [3] >= 30) {
						dustWithdraw (idx, 2);
					}
					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " refused to consume dust today.";
				}

			}else {
				if (randNum >= 95) {

					dustConsumption (idx, 1);
					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " had its daily dose of dust.";

				} else {
					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " refused to consume dust.";
				}
			}
		} else {
			if (NPCCharList.CharRetainers [idx].charAddictions [3] > 55) {
				dustWithdraw(idx, 0);
				return "\n\n" +NPCCharList.CharRetainers [idx].charName + " couldn't consume dust today, worsening it's mood and health.";
			} else if (NPCCharList.CharRetainers [idx].charAddictions [3] > 30) {
				dustWithdraw (idx, 1);
				return "\n\n" +NPCCharList.CharRetainers [idx].charName + " couldn't consume dust today, worsening it's mood and health.";
			} else {
				return "";
			}
		}
	}



	static void dustWithdraw(int idx, int selector){
		if (NPCCharList.CharRetainers [idx].attMental > 30) {
			NPCCharList.CharRetainers [idx].attMental -= 1 + Random.Range (0, 3);
		}

		if (selector == 0) { // high add no drug
			NPCCharList.CharRetainers [idx].attHappiness -= 3f + Random.Range(0,3);
			NPCCharList.CharRetainers [idx].charLoyalty -= Random.Range (0, 2);
			if (NPCCharList.CharRetainers [idx].attTemperament > 10) {
				NPCCharList.CharRetainers [idx].attTemperament -= Random.Range(0,2);
			}
			NPCCharList.CharRetainers [idx].currentHealth -= Random.Range (2, 10);
			NPCCharList.CharRetainers [idx].charAddictions[3] -= Random.Range (0, 3);
		}

		if (selector == 1) { // low add no drug
			NPCCharList.CharRetainers [idx].attHappiness -= 1.5f + Random.Range(0,1.5f);
			NPCCharList.CharRetainers [idx].charLoyalty -= Random.Range(0,1.25f);
			if (NPCCharList.CharRetainers [idx].attTemperament > 10) {
				NPCCharList.CharRetainers [idx].attTemperament -= Random.Range(0,2);
			}
			NPCCharList.CharRetainers [idx].currentHealth -= Random.Range (2, 5);
			NPCCharList.CharRetainers [idx].charAddictions[3] -= Random.Range(0,3);
		}

		if (selector == 2) { // ref drug 
			NPCCharList.CharRetainers [idx].attHappiness -= Random.Range(0,1f);
			NPCCharList.CharRetainers [idx].attHappiness -= 0.25f;
			if (NPCCharList.CharRetainers [idx].attTemperament < 90) {
				NPCCharList.CharRetainers [idx].attTemperament += 0.15f;
			}
			NPCCharList.CharRetainers [idx].charAddictions[3] -= Random.Range(0.5f,4);
		}

	}



	static void dustConsumption(int idx, int selector){
		CastleController.castleSupplies -= 6;
		if (NPCCharList.CharRetainers [idx].charCorruption < 75) {
			NPCCharList.CharRetainers [idx].charCorruption += 0.5f + Random.Range (0, 1.5f);
		}
		if (NPCCharList.CharRetainers [idx].attTemperament > 10) {
			NPCCharList.CharRetainers [idx].attTemperament -= 0.5f + Random.Range (0, 2);
		}
		if (NPCCharList.CharRetainers [idx].attBeauty > 10) {
			NPCCharList.CharRetainers [idx].attBeauty -= 0.5f + Random.Range (0, 2);
		}
		if (NPCCharList.CharRetainers [idx].charLoyalty < 50) {
			NPCCharList.CharRetainers [idx].charLoyalty += 1 + Random.Range(0,3);
		}
		if (NPCCharList.CharRetainers [idx].attMental < 85) {
			NPCCharList.CharRetainers [idx].attMental += 0.5f + Random.Range(0,2);
		}
		if (NPCCharList.CharRetainers [idx].attPhysical > 10) {
			NPCCharList.CharRetainers [idx].attPhysical -= 1.5f + Random.Range(0,2);
		}
		if (NPCCharList.CharRetainers [idx].attSocial > 75) {
			NPCCharList.CharRetainers [idx].attSocial -= 1.5f + Random.Range(0,2);
		}
		NPCCharList.CharRetainers [idx].charAddictions[3] += 1 + Random.Range (0, 2.5f);

		if (selector == 0) { // high add
			NPCCharList.CharRetainers [idx].attHappiness += Random.Range(0,3);
		}
		if (selector == 1) { // low add
			NPCCharList.CharRetainers [idx].attHappiness += 2 + Random.Range(0,3);
		}
	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



	static string useBluecap(int idx, int idxRL){
		if (RulesNPC.savedRules [idxRL].drugForcedUse && RulesNPC.savedRules [idxRL].drugBlueCapShroom && CastleController.castleSupplies >= 4) {
			bluecapConsumption(idx, 1);
			NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 3);
			return "\n\n" +"You forced " + NPCCharList.CharRetainers [idx].charName + " to use bluecap today." ;
		}

		if (CastleController.castleSupplies < 6 && RulesNPC.savedRules [idxRL].drugBlueCapShroom) {
			if (NPCCharList.CharRetainers [idx].charAddictions [4] > 55) {
				bluecapWithdraw(idx, 0);
			} else if (NPCCharList.CharRetainers [idx].charAddictions [4] > 30) {
				bluecapWithdraw (idx, 1);
			} 
			return "\n\n" +"You don't have enough supplies to give bluecap to " +  NPCCharList.CharRetainers [idx].charName + "." ;
		}



		int randNum = Random.Range (0, 100);
		if (RulesNPC.savedRules [idxRL].drugBlueCapShroom) {
			if (NPCCharList.CharRetainers [idx].charAddictions [4] >= 70) {
				bluecapConsumption (idx, 0);
				return "\n\n" +NPCCharList.CharRetainers [idx].charName + " had its daily dose of bluecap.";
			} else if (NPCCharList.CharRetainers [idx].charAddictions [4] >= 55 || NPCCharList.CharRetainers [idx].attMorality <= 20 || NPCCharList.CharRetainers [idx].charCorruption >= 60) {
				if (randNum >= 50) {
					bluecapConsumption (idx, 1);

					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " had its daily dose of bluecap.";
				} else {
					if (NPCCharList.CharRetainers [idx].charAddictions [4] >= 30) {
						bluecapWithdraw (idx, 2);
					}
					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " refused to consume bluecap.";
				}


			} else if (NPCCharList.CharRetainers [idx].charAddictions [4] >= 30 || NPCCharList.CharRetainers [idx].attMorality <= 35 || NPCCharList.CharRetainers [idx].charCorruption >= 45) {
				if (randNum >= 75) {

					bluecapConsumption (idx, 1);
					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " had its daily dose of bluecap.";

				} else {
					if (NPCCharList.CharRetainers [idx].charAddictions [4] >= 30) {
						bluecapWithdraw (idx, 2);
					}
					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " refused to consume bluecap today.";
				}

			}else {
				if (randNum >= 95) {

					bluecapConsumption (idx, 1);
					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " had its daily dose of bluecap.";

				} else {
					return "\n\n" +NPCCharList.CharRetainers [idx].charName + " refused to consume bluecap.";
				}
			}
		} else {
			if (NPCCharList.CharRetainers [idx].charAddictions [4] > 55) {
				bluecapWithdraw (idx, 0);
				return "\n\n" +NPCCharList.CharRetainers [idx].charName + " couldn't consume bluecap today, worsening it's mood and health.";
			} else if (NPCCharList.CharRetainers [idx].charAddictions [4] > 30) {
				bluecapWithdraw (idx, 1);
				return "\n\n" +NPCCharList.CharRetainers [idx].charName + " couldn't consume bluecap today, worsening it's mood and health.";
			} else {
				return "";
			}
		}
	}


	static void bluecapWithdraw(int idx, int selector){
		if (NPCCharList.CharRetainers [idx].attSocial > 20) {
			NPCCharList.CharRetainers [idx].attSocial -= 1 + Random.Range (0, 3);
		}

		if (selector == 0) { // high add no drug
			NPCCharList.CharRetainers [idx].attHappiness -= 1.5f + Random.Range(0,3);
			NPCCharList.CharRetainers [idx].attObedience -= Random.Range (0, 2);
			if (NPCCharList.CharRetainers [idx].attTemperament > 10) {
				NPCCharList.CharRetainers [idx].attTemperament -= Random.Range(0,2);
			}
			NPCCharList.CharRetainers [idx].currentHealth -= Random.Range (2, 10);
			NPCCharList.CharRetainers [idx].charAddictions[4] -= Random.Range (0, 3);
		}

		if (selector == 1) { // low add no drug
			NPCCharList.CharRetainers [idx].attHappiness -= 1.5f + Random.Range(0,1.5f);
			NPCCharList.CharRetainers [idx].attObedience -= Random.Range(0,1.25f);
			if (NPCCharList.CharRetainers [idx].attTemperament > 10) {
				NPCCharList.CharRetainers [idx].attTemperament -= Random.Range(0,2);
			}
			NPCCharList.CharRetainers [idx].currentHealth -= Random.Range (2, 5);
			NPCCharList.CharRetainers [idx].charAddictions[4] -= Random.Range(0,3);
		}

		if (selector == 2) { // ref drug 
			NPCCharList.CharRetainers [idx].attHappiness -= Random.Range(0,1f);
			NPCCharList.CharRetainers [idx].attHappiness -= 0.25f;
			if (NPCCharList.CharRetainers [idx].attTemperament < 90) {
				NPCCharList.CharRetainers [idx].attTemperament += 0.15f;
			}
			NPCCharList.CharRetainers [idx].charAddictions[4] -= Random.Range(0.5f,4);
		}

	}


	static void bluecapConsumption(int idx, int selector){
		CastleController.castleSupplies -= 4;
		if (NPCCharList.CharRetainers [idx].charCorruption < 75) {
			NPCCharList.CharRetainers [idx].charCorruption += 0.5f + Random.Range (0, 1.5f);
		}
		if (NPCCharList.CharRetainers [idx].attTemperament > 10) {
			NPCCharList.CharRetainers [idx].attTemperament -= 0.5f + Random.Range (0, 2);
		}
		if (NPCCharList.CharRetainers [idx].attBeauty < 70) {
			NPCCharList.CharRetainers [idx].attBeauty += 0.5f + Random.Range (0, 2);
		}
		if (NPCCharList.CharRetainers [idx].attNature < 80) {
			NPCCharList.CharRetainers [idx].attNature += 0.5f + Random.Range (0, 2);
		}
		if (NPCCharList.CharRetainers [idx].attOpenness < 80) {
			NPCCharList.CharRetainers [idx].attOpenness += 0.5f + Random.Range (0, 2);
		}
		if (NPCCharList.CharRetainers [idx].attObedience < 70) {
			NPCCharList.CharRetainers [idx].attObedience += 0.5f + Random.Range(0,2);
		}
		if (NPCCharList.CharRetainers [idx].attSocial < 85) {
			NPCCharList.CharRetainers [idx].attSocial += 0.5f + Random.Range(0,2);
		}
		if (NPCCharList.CharRetainers [idx].attMental > 10) {
			NPCCharList.CharRetainers [idx].attMental -= 1.5f + Random.Range(0,2);
		}


		NPCCharList.CharRetainers [idx].charAddictions[4] += 1 + Random.Range (0, 2.5f);

		if (selector == 0) { // high add
			NPCCharList.CharRetainers [idx].attHappiness += Random.Range(0,3);
		}
		if (selector == 1) { // low add
			NPCCharList.CharRetainers [idx].attHappiness += 2 + Random.Range(0,3);
		}
	}
}
