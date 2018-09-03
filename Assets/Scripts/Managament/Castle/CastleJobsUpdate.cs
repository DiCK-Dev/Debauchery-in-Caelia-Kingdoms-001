using UnityEngine;
using System.Collections;

public class CastleJobsUpdate  {


	public static string updateJob(int idx){
		int hashcode =  NPCCharList.CharRetainers [idx].charName.GetHashCode();
		Random.InitState ( WorldControl.day * System.DateTime.Now.Millisecond * idx + hashcode+2); 
		int randNum = Random.Range (0, 100);
		float dif, goldf;
		int gold; 

		NPCData.Jobs job = NPCCharList.CharRetainers [idx].cityJobs;


		switch(job){
		case NPCData.Jobs.CastleRest:
			NPCCharList.CharRetainers [idx].attHappiness += 2 + Random.Range (0, 5);
			NPCCharList.CharRetainers [idx].attFear -= 1 + Random.Range (0, 2);
			if (NPCCharList.CharRetainers [idx].attExpectation > 0) { 
				NPCCharList.CharRetainers [idx].attExpectation -= 1 + Random.Range (0, 2); 
			} else if (NPCCharList.CharRetainers [idx].attExpectation < 0) {
				NPCCharList.CharRetainers [idx].attExpectation += 1 + Random.Range (0, 2); 
			}
			return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " took the day off to rest.";
		
		case NPCData.Jobs.CastleDomestic:
			dif = 100 - (NPCCharList.CharRetainers [idx].attObedience + (NPCCharList.CharRetainers [idx].attHappiness / 2));
			NPCCharList.CharRetainers [idx].attHappiness -= 1 + (Random.Range (0, 1));
			if ((int)NPCCharList.CharRetainers [idx].bgUpbring >= 3) {
				NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 5);
			}
			if (dif < randNum) {
				CastleUpdate.tempCastleCleanliness += (15 + Random.Range (0, 15)) * ((NPCCharList.CharRetainers [idx].utilitySkillHouseKeeping + NPCCharList.CharRetainers [idx].attPhysical) / 140);
				if (NPCCharList.CharRetainers [idx].attPhysical < 45) {
					NPCCharList.CharRetainers [idx].attPhysical += 0.5f + Random.Range (0, 1);
				}
				if (dif > 40) {
					NPCCharList.CharRetainers [idx].workReward += 1;
				}
				NPCCharList.CharRetainers [idx].utilitySkillHouseKeeping += 0.5f + Random.Range (0f, 2f);
				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " did all it's domestic chores.";

			} else if (randNum > (dif - (dif / 2))) {
				CastleUpdate.tempCastleCleanliness += (5 + Random.Range (0, 5)) * ((NPCCharList.CharRetainers [idx].utilitySkillHouseKeeping + NPCCharList.CharRetainers [idx].attPhysical) / 280);
				NPCCharList.CharRetainers [idx].workReward -= 1;
				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " only did half of it's domestic chores.";

			} else {
				NPCCharList.CharRetainers [idx].workReward -= 2;
				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " refused to do it's domestic chores.";
			}

		case NPCData.Jobs.CastleCook:
			dif = 100f - (NPCCharList.CharRetainers [idx].attObedience + (NPCCharList.CharRetainers [idx].attHappiness / 1.9f));
			NPCCharList.CharRetainers [idx].attHappiness -= 0.5f + (Random.Range (0, 1));
			if ((int)NPCCharList.CharRetainers [idx].bgUpbring >= 3) {
				NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 4);
			}
			if (dif < randNum) {
				CastleUpdate.tempCastleFoodQuality += (NPCCharList.CharRetainers [idx].utilitySkillHouseKeeping+NPCCharList.CharRetainers [idx].attMental)/3;
				if (NPCCharList.CharRetainers [idx].attMental < 45) {
					NPCCharList.CharRetainers [idx].attMental += 0.5f + Random.Range (0, 1);
				}
				NPCCharList.CharRetainers [idx].utilitySkillHouseKeeping += 0.5f + Random.Range (0, 2.5f);
				if (dif > 35) {
					NPCCharList.CharRetainers [idx].workReward += 1;
				}
				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " helped all day in the kitchen.";

			} else if (randNum > (dif - (dif / 2))) {
				CastleUpdate.tempCastleFoodQuality += (NPCCharList.CharRetainers [idx].utilitySkillHouseKeeping+NPCCharList.CharRetainers [idx].attMental)/320;
				NPCCharList.CharRetainers [idx].workReward -= 1;
				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " barely helped in the kitchen.";

			} else {
				NPCCharList.CharRetainers [idx].workReward -= 2;
				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " refused to help in the kitchen.";

			}
		case NPCData.Jobs.CastleHealer:
			dif = 100f - (NPCCharList.CharRetainers [idx].attObedience + (NPCCharList.CharRetainers [idx].attHappiness / 1.75f));
			NPCCharList.CharRetainers [idx].attHappiness += 0.5f + (Random.Range (0, 1));
			if ((int)NPCCharList.CharRetainers [idx].bgUpbring >= 3) {
				NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 2f);
			} else {
				NPCCharList.CharRetainers [idx].attHappiness += Random.Range (0, 2f);
			}
			if (dif < randNum) {
				CastleUpdate.tempCastleHealthcare += (NPCCharList.CharRetainers [idx].utilitySkillMedicine+NPCCharList.CharRetainers [idx].attMental)/200;
				if (NPCCharList.CharRetainers [idx].attMental < 60) {
					NPCCharList.CharRetainers [idx].attMental += 0.5f + Random.Range (0, 2);
				}
				NPCCharList.CharRetainers [idx].utilitySkillMedicine += 0.5f + Random.Range (0, 1f);
				if (dif > 30) {
					NPCCharList.CharRetainers [idx].workReward += 1;
				}
				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " took care of the slaves and free citizens in the castle.";

			} else if (randNum > (dif - (dif / 2))) {
				CastleUpdate.tempCastleHealthcare += (NPCCharList.CharRetainers [idx].utilitySkillMedicine+NPCCharList.CharRetainers [idx].attMental)/400;
				NPCCharList.CharRetainers [idx].workReward -= 2;
				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " barely took care of the slaves and free citizens in the castle.";

			} else {
				NPCCharList.CharRetainers [idx].workReward -= 3;
				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " refused to take care of the slaves and free citizens in the castle.";

			}
		case NPCData.Jobs.CastleHunter:
			dif = 100 - ((NPCCharList.CharRetainers [idx].attObedience / 1.2f) + (NPCCharList.CharRetainers [idx].attHappiness / 4) + (NPCCharList.CharRetainers [idx].attWillpower / 4));
			NPCCharList.CharRetainers [idx].attHappiness -= 0.5f + (Random.Range (0, 2));
			if ((int)NPCCharList.CharRetainers [idx].bgUpbring >= 3) {
				NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 3);
			}
			if (dif < randNum) {
				if (NPCCharList.CharRetainers [idx].charCorruption < 20) {
					float rand = Random.Range (-4, 4);
					if (rand > 0) {
						NPCCharList.CharRetainers [idx].charCorruption += rand;
					}
				}
				goldf = (2 + Random.Range (0, 30)) * ((((NPCCharList.CharRetainers [idx].coreSkillMartial + NPCCharList.CharRetainers [idx].attPhysical) / 200) + (NPCCharList.CharRetainers [idx].attWillpower / 100)) / 1.5f);
				gold = (int)goldf;
				if (NPCCharList.CharRetainers [idx].attPhysical < 80) {
					NPCCharList.CharRetainers [idx].attPhysical += 0.5f + Random.Range (0, 1);
				}
				if (dif > 40) {
					NPCCharList.CharRetainers [idx].workReward += 1;
				}
				NPCCharList.CharRetainers [idx].coreSkillMartial += 0.5f + Random.Range (0f, 2f);
				gold = (int)goldf;
				GameControl.charGold += gold; 
				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " went deep inside the forest to hunt and earned " + gold.ToString() + " gold.";

			} else if (randNum > (dif - (dif / 2))) {
				if (NPCCharList.CharRetainers [idx].charCorruption < 20) {
					float rand = Random.Range (-4, 2);
					if (rand > 0) {
						NPCCharList.CharRetainers [idx].charCorruption += rand;
					}
				}
				goldf = (2 + Random.Range (0, 30)) * ((((NPCCharList.CharRetainers [idx].coreSkillMartial + NPCCharList.CharRetainers [idx].attPhysical) / 400) + (NPCCharList.CharRetainers [idx].attWillpower / 200)) / 1.5f);
				gold = (int)goldf;
				NPCCharList.CharRetainers [idx].workReward -= 1;
				GameControl.charGold += gold;
				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " didn't went too deep into the forest to hunt and earned " + gold.ToString() + " gold.";

			} else {
				NPCCharList.CharRetainers [idx].workReward -= 2;
				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " refused to go to hunt.";
			}
		case NPCData.Jobs.CastleEntertainer:
			dif = 100 - ((NPCCharList.CharRetainers [idx].attObedience / 1.2f) + (NPCCharList.CharRetainers [idx].attHappiness / 4) + (NPCCharList.CharRetainers [idx].attLibido / 8));
			NPCCharList.CharRetainers [idx].attHappiness -= 0.5f + (Random.Range (0, 2));
			if ((int)NPCCharList.CharRetainers [idx].bgUpbring >= 3) {
				NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 3);
			}
			if (dif < randNum) {
				if (NPCCharList.CharRetainers [idx].charCorruption < 25) {
					float rand = Random.Range (-4, 2);
					if (rand > 0) {
						NPCCharList.CharRetainers [idx].charCorruption += rand;
					}
				}
					
				if (NPCCharList.CharRetainers [idx].attSocial < 80) {
					NPCCharList.CharRetainers [idx].attSocial += 0.5f + Random.Range (0, 1);
				}
				if (dif > 30) {
					NPCCharList.CharRetainers [idx].workReward += 1;
				}
				NPCCharList.CharRetainers [idx].utilitySkillPerformance += 0.5f + Random.Range (0f, 2f);
				goldf = (2f + Random.Range (0f, 30f)) * ((((NPCCharList.CharRetainers [idx].utilitySkillPerformance + NPCCharList.CharRetainers [idx].attSocial) / 200f) + (NPCCharList.CharRetainers [idx].attNature / 80f) + (NPCCharList.CharRetainers [idx].attBeauty / 60f)) / 2.5f);
				gold = (int)goldf;
				GameControl.charGold += gold;

				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " performed to the crowd, earing "+ gold.ToString() + " gold.";

			} else if (randNum > (dif - (dif / 2))) {
				if (NPCCharList.CharRetainers [idx].charCorruption < 25) {
					float rand = Random.Range (-4, 2);
					if (rand > 0) {
						NPCCharList.CharRetainers [idx].charCorruption += rand;
					}
				}
				goldf = (2f + Random.Range (0f, 30f)) * ((((NPCCharList.CharRetainers [idx].utilitySkillPerformance + NPCCharList.CharRetainers [idx].attSocial) / 400f) + (NPCCharList.CharRetainers [idx].attNature / 160f) + (NPCCharList.CharRetainers [idx].attBeauty / 120f)) / 2.5f);
				gold = (int)goldf;
				GameControl.charGold += gold;
				NPCCharList.CharRetainers [idx].workReward -= 1;

				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " lazily performed to the crowd, earing "+ gold.ToString() + " gold.";

			} else {
				NPCCharList.CharRetainers [idx].workReward -= 2;
				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " refused to perform today.";
			}
		case NPCData.Jobs.CastleArtisan:
			dif = 100f - (NPCCharList.CharRetainers [idx].attObedience + (NPCCharList.CharRetainers [idx].attHappiness / 1.9f));
			NPCCharList.CharRetainers [idx].attHappiness -= 0.5f + (Random.Range (0, 1));
			if ((int)NPCCharList.CharRetainers [idx].bgUpbring >= 3) {
				NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0f, 2f);
			}
			if (dif < randNum) {
				if (NPCCharList.CharRetainers [idx].attPhysical < 80) {
					NPCCharList.CharRetainers [idx].attPhysical += 0.5f + Random.Range (0f, 1.5f);
				}
				NPCCharList.CharRetainers [idx].utilitySkillCrafting += 0.5f + Random.Range (0, 2.5f);
				if (dif > 35) {
					NPCCharList.CharRetainers [idx].workReward += 1;
				}

				goldf = (3f + Random.Range (0f, 35f)) * ((NPCCharList.CharRetainers [idx].utilitySkillCrafting + NPCCharList.CharRetainers [idx].attPhysical) / 200f);
				gold = (int)goldf;
				GameControl.charGold += gold;
				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " went to the city to work as an artisan, earning " + gold.ToString() + " gold.";

			} else if (randNum > (dif - (dif / 2))) {
				NPCCharList.CharRetainers [idx].workReward -= 1;
				goldf = (3f + Random.Range (0f, 35f)) * ((NPCCharList.CharRetainers [idx].utilitySkillCrafting + NPCCharList.CharRetainers [idx].attPhysical) / 400f);
				gold = (int)goldf;
				GameControl.charGold += gold;
				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " reluctantly worked as an artisan, earning " + gold.ToString() +  " gold.";

			} else {
				NPCCharList.CharRetainers [idx].workReward -= 2;
				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " refused to work as an artisan.";

			}
		case NPCData.Jobs.CastleFarmhand:
			dif = 100f - (NPCCharList.CharRetainers [idx].attObedience + (NPCCharList.CharRetainers [idx].attHappiness / 2f));
			NPCCharList.CharRetainers [idx].attHappiness -= 0.5f + (Random.Range (0f, 1.5f));
			if ((int)NPCCharList.CharRetainers [idx].bgUpbring >= 3) {
				NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0f, 3f);
			}
			if (dif < randNum) {
				if (NPCCharList.CharRetainers [idx].attPhysical < 100) {
					NPCCharList.CharRetainers [idx].attPhysical += 0.5f + Random.Range (0f, 1f);
				}
				NPCCharList.CharRetainers [idx].utilitySkillFarmHand += 0.5f + Random.Range (0, 2f);
				if (dif > 35) {
					NPCCharList.CharRetainers [idx].workReward += 1;
				}

				goldf = (1f + Random.Range (0f, 25f)) * ((NPCCharList.CharRetainers [idx].utilitySkillFarmHand + NPCCharList.CharRetainers [idx].attPhysical) / 160f);
				gold = (int)goldf;
				GameControl.charGold += gold;
				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " went to the city to work as a farmhand, earning " + gold.ToString () + " gold.";

			} else if (randNum > (dif - (dif / 2))) {
				NPCCharList.CharRetainers [idx].workReward -= 1;
				goldf = (1f + Random.Range (0f, 25f)) * ((NPCCharList.CharRetainers [idx].utilitySkillFarmHand + NPCCharList.CharRetainers [idx].attPhysical) / 320f);
				gold = (int)goldf;
				GameControl.charGold += gold;
				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " reluctantly went to the city to work as a farmhand, earning " + gold.ToString () + " gold.";


			} else {
				NPCCharList.CharRetainers [idx].workReward -= 2;
				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " refused to work as a farmhand.";

			}
		case NPCData.Jobs.CastleScribe:
			dif = 100f - (NPCCharList.CharRetainers [idx].attObedience + (NPCCharList.CharRetainers [idx].attHappiness / 1.75f));
			NPCCharList.CharRetainers [idx].attHappiness += 0.5f + (Random.Range (0f, 0.5f));
			if ((int)NPCCharList.CharRetainers [idx].bgUpbring >= 3) {
				NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0f, 1.5f);
			}
			if (dif < randNum) {
				if (NPCCharList.CharRetainers [idx].attMental < 100) {
					NPCCharList.CharRetainers [idx].attMental += 0.5f + Random.Range (0f, 1f);
				}
				NPCCharList.CharRetainers [idx].utilitySkillLearning += 0.5f + Random.Range (0, 1.5f);
				if (dif > 35) {
					NPCCharList.CharRetainers [idx].workReward += 1;
				}

				goldf = (1f + Random.Range (0f, 50f)) * ((NPCCharList.CharRetainers [idx].utilitySkillLearning + NPCCharList.CharRetainers [idx].attMental + NPCCharList.CharRetainers [idx].attHappiness) / 300f);
				gold = (int)goldf;
				GameControl.charGold += gold;
				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " work as a scribe, earning " + gold.ToString () + " gold.";

			} else if (randNum > (dif - (dif / 2))) {
				NPCCharList.CharRetainers [idx].workReward -= 1;
				goldf = (1f + Random.Range (0f, 50f)) * ((NPCCharList.CharRetainers [idx].utilitySkillLearning + NPCCharList.CharRetainers [idx].attMental + NPCCharList.CharRetainers [idx].attHappiness) / 600f);
				gold = (int)goldf;
				GameControl.charGold += gold;
				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " reluctantly work as a scribe, earning " + gold.ToString () + " gold.";
			} else {
				NPCCharList.CharRetainers [idx].workReward -= 2;
				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " refused to work as an scribe.";

			}
		case NPCData.Jobs.CastleProstitute:
			dif = 100 - ((NPCCharList.CharRetainers [idx].attObedience / 1.4f) + (NPCCharList.CharRetainers [idx].attHappiness / 4) + (NPCCharList.CharRetainers [idx].attLibido / 4));
			NPCCharList.CharRetainers [idx].attHappiness -= 1f + (Random.Range (0, 4));
			if ((int)NPCCharList.CharRetainers [idx].bgUpbring >= 3) {
				NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 4);
			}
			if (dif < randNum) {
				if (NPCCharList.CharRetainers [idx].charCorruption < 80) {
					float rand = Random.Range (-4, 4);
					if (rand > 0) {
						NPCCharList.CharRetainers [idx].charCorruption += rand;
					}
				}
				if (NPCCharList.CharRetainers [idx].attOpenness < 80) {
					NPCCharList.CharRetainers [idx].attOpenness += Random.Range (0,3);
				}
				if (NPCCharList.CharRetainers [idx].attLibido < 70) {
					NPCCharList.CharRetainers [idx].attLibido += Random.Range (0,3);
				}
				if (NPCCharList.CharRetainers [idx].attDignity > 40) {
					NPCCharList.CharRetainers [idx].attDignity -= Random.Range (0,3);
				}
				if (NPCCharList.CharRetainers [idx].attMorality > 50) {
					NPCCharList.CharRetainers [idx].attMorality -= Random.Range (0,3);
				}


				if (NPCCharList.CharRetainers [idx].attSocial < 100) {
					NPCCharList.CharRetainers [idx].attSocial += 0.5f + Random.Range (0, 1);
				}
				if (dif > 30) {
					NPCCharList.CharRetainers [idx].workReward += 1;
				}
				NPCCharList.CharRetainers [idx].sexSkillWhoring += 0.5f + Random.Range (0f, 2f);
				goldf = (2f + Random.Range (0f, 40f)) * ((((NPCCharList.CharRetainers [idx].sexSkillWhoring + NPCCharList.CharRetainers [idx].attSocial) / 200f) + (NPCCharList.CharRetainers [idx].attNature / 60f) + (NPCCharList.CharRetainers [idx].attBeauty / 40f)) / 2.3f);
				gold = (int)goldf;
				GameControl.charGold += gold;

				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " worked as a prostitute, earning "+ gold.ToString() + " gold.";

			} else if (randNum > (dif - (dif / 2))) {
				if (NPCCharList.CharRetainers [idx].charCorruption < 80) {
					float rand = Random.Range (-4, 4);
					if (rand > 0) {
						NPCCharList.CharRetainers [idx].charCorruption += rand;
					}
				}

				if (NPCCharList.CharRetainers [idx].attOpenness < 80) {
					NPCCharList.CharRetainers [idx].attOpenness += Random.Range (0,3);
				}
				if (NPCCharList.CharRetainers [idx].attLibido < 70) {
					NPCCharList.CharRetainers [idx].attLibido += Random.Range (0,3);
				}
				if (NPCCharList.CharRetainers [idx].attDignity > 40) {
					NPCCharList.CharRetainers [idx].attDignity -= Random.Range (0,3);
				}
				if (NPCCharList.CharRetainers [idx].attMorality > 50) {
					NPCCharList.CharRetainers [idx].attMorality -= Random.Range (0,3);
				}

				goldf = (2f + Random.Range (0f, 40f)) * ((((NPCCharList.CharRetainers [idx].sexSkillWhoring + NPCCharList.CharRetainers [idx].attSocial) / 400f) + (NPCCharList.CharRetainers [idx].attNature / 120f) + (NPCCharList.CharRetainers [idx].attBeauty / 80f)) / 2.3f);
				gold = (int)goldf;
				GameControl.charGold += gold;
				NPCCharList.CharRetainers [idx].workReward -= 1;

				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " reluctantly worked as a prostitute, earning "+ gold.ToString() + " gold.";

			} else {
				NPCCharList.CharRetainers [idx].workReward -= 2;
				return NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " refused to work as a prostitute today.";
			}
		case NPCData.Jobs.CastleAccountant:
			float needSupplies = 500 - CastleController.castleSupplies;
			NPCCharList.CharRetainers [idx].attHappiness += 1f + (Random.Range (0, 2));
			if ((int)NPCCharList.CharRetainers [idx].bgUpbring < 3) {
				NPCCharList.CharRetainers [idx].attHappiness += Random.Range (0, 2);
			}
			if (NPCCharList.CharRetainers [idx].attMental < 100) {
				NPCCharList.CharRetainers [idx].attMental += Random.Range (0, 1);
			}
			if (NPCCharList.CharRetainers [idx].coreSkillStewardship < 100) {
				NPCCharList.CharRetainers [idx].coreSkillStewardship += 0.5f + Random.Range (0, 2);
			}
			if (CastleController.castleSupplies > 500) {
				return "There is no need to buy more supplies for now.";
			}

			if (GameControl.charGold > (needSupplies * (3 - ((NPCCharList.CharRetainers [idx].coreSkillStewardship + NPCCharList.CharRetainers [idx].attMental) / 133)))) {
				GameControl.charGold -= (int)(needSupplies * (3 - ((NPCCharList.CharRetainers [idx].coreSkillStewardship + NPCCharList.CharRetainers [idx].attMental) / 133)));
				CastleController.castleSupplies = 500;
				return "Your accountant "+ NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " has bought " + needSupplies + "x amount of supplies, for " +  (3 - ((NPCCharList.CharRetainers [idx].coreSkillStewardship + NPCCharList.CharRetainers [idx].attMental) / 133)).ToString() + " each." ;
			} else {
				return "your accountant"+ NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " didn't had anough funds to buy the supplies your castle needs.";
			}
		case NPCData.Jobs.CastleSlaveMaster:
			NPCCharList.CharRetainers [idx].attHappiness += 0.5f + (Random.Range (0, 2));
			if ((int)NPCCharList.CharRetainers [idx].bgUpbring < 3) {
				NPCCharList.CharRetainers [idx].attHappiness += Random.Range (0, 1.5f);
			}

			if (NPCCharList.CharRetainers [idx].attSocial < 100) {
				NPCCharList.CharRetainers [idx].attSocial += Random.Range (0, 1);
			}
			if (NPCCharList.CharRetainers [idx].coreSkillPersuasion < 100) {
				NPCCharList.CharRetainers [idx].coreSkillPersuasion += 0.5f + Random.Range (0, 2);
			}
			CastleUpdate.tempSlaveMasterEff += ((NPCCharList.CharRetainers [idx].coreSkillPersuasion + NPCCharList.CharRetainers [idx].attSocial) / 200);
			return "Your slave master, "+ NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + ", took care of your prisoners today.";
		case NPCData.Jobs.CastleCaptain:
			NPCCharList.CharRetainers [idx].attHappiness += 2f + (Random.Range (0, 2));
			if ((int)NPCCharList.CharRetainers [idx].bgUpbring < 3) {
				NPCCharList.CharRetainers [idx].attHappiness += Random.Range (1, 2f);
			}
			if (NPCCharList.CharRetainers [idx].attPhysical < 100) {
				NPCCharList.CharRetainers [idx].attPhysical += Random.Range (0, 1);
			}
			if (NPCCharList.CharRetainers [idx].coreSkillMartial < 100) {
				NPCCharList.CharRetainers [idx].coreSkillMartial += 0.5f + Random.Range (0, 2);
			}
			CastleUpdate.tempCastleSecurity +=  ((NPCCharList.CharRetainers [idx].attPhysical + NPCCharList.CharRetainers [idx].coreSkillSecurity + NPCCharList.CharRetainers [idx].coreSkillMartial) / 250) / (RulesNPC.savedRules.Count / 8);
			CastleUpdate.tempMaxMartialTrain += NPCCharList.CharRetainers [idx].coreSkillMartial;
			CastleUpdate.tempMaxSecurityTrain += NPCCharList.CharRetainers [idx].coreSkillSecurity; 
			return "Your captain of the guard, "+ NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + " trained your guards and patrolled the castle.";
		case NPCData.Jobs.CastleGuard:
			NPCCharList.CharRetainers [idx].attHappiness += 1f + (Random.Range (0, 1));
			if ((int)NPCCharList.CharRetainers [idx].bgUpbring < 3) {
				NPCCharList.CharRetainers [idx].attHappiness += Random.Range (0, 1f);
			} else {
				NPCCharList.CharRetainers [idx].attHappiness -= Random.Range (0, 2f);
			}
			if (NPCCharList.CharRetainers [idx].attPhysical < 75) {
				NPCCharList.CharRetainers [idx].attPhysical += Random.Range (0, 1);
			}
			if (NPCCharList.CharRetainers [idx].coreSkillMartial < CastleController.maxMartialTrain) {
				NPCCharList.CharRetainers [idx].coreSkillMartial += 0.5f + Random.Range (0, 2);
			}
			if (NPCCharList.CharRetainers [idx].coreSkillSecurity < CastleController.maxSecurityTrain) {
				NPCCharList.CharRetainers [idx].coreSkillSecurity += 0.5f + Random.Range (0, 2);
			}
			CastleUpdate.tempCastleSecurity += ((NPCCharList.CharRetainers [idx].attPhysical + NPCCharList.CharRetainers [idx].coreSkillSecurity + NPCCharList.CharRetainers [idx].coreSkillMartial) / 300) / (RulesNPC.savedRules.Count / 8);
			return "Your guard, "+ NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + ", patrolled your castle today.";
		case NPCData.Jobs.CastleCourtier:
			NPCCharList.CharRetainers [idx].attHappiness += 2f + (Random.Range (0, 1));
			if ((int)NPCCharList.CharRetainers [idx].bgUpbring < 3) {
				NPCCharList.CharRetainers [idx].attHappiness += Random.Range (1, 4f);
			} else {
				NPCCharList.CharRetainers [idx].attHappiness += Random.Range (0, 2f);
			}
			if (NPCCharList.CharRetainers [idx].attSocial < 100) {
				NPCCharList.CharRetainers [idx].attSocial += Random.Range (0, 2f);
			}
			if (NPCCharList.CharRetainers [idx].coreSkillGovernance < 100) {
				NPCCharList.CharRetainers [idx].coreSkillGovernance += Random.Range (0, 2.5f);
			}

			return "Your courtier, "+ NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + ", hanged around with you in the court room.";
		case NPCData.Jobs.CastleCounselor:
			NPCCharList.CharRetainers [idx].attHappiness += 2f + (Random.Range (0, 2));
			if ((int)NPCCharList.CharRetainers [idx].bgUpbring < 3) {
				NPCCharList.CharRetainers [idx].attHappiness += Random.Range (0, 3f);
			} 

			if (NPCCharList.CharRetainers [idx].attSocial < 100) {
				NPCCharList.CharRetainers [idx].attSocial += Random.Range (0, 2f);
			}
			if (NPCCharList.CharRetainers [idx].coreSkillDiplomacy < 100) {
				NPCCharList.CharRetainers [idx].coreSkillDiplomacy += Random.Range (0, 2.5f);
			}
			CastleUpdate.tempCastleMentalcare += ((NPCCharList.CharRetainers [idx].coreSkillDiplomacy + NPCCharList.CharRetainers [idx].attSocial) / 50);
			return "Your counselor, "+ NPCCharList.CharRetainers [idx].charName + " " + NPCCharList.CharRetainers [idx].charSurname + ", has helped those who are more depressed to get in a better mood.";
		}

		return "bug in updatejob";
	}

}
