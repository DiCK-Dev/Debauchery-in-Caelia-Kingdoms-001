using UnityEngine;
using System.Collections;

public class NPCSettlerTraitsBonus : MonoBehaviour {
	static int iterator = 0;
	int hashcode = GameControl.playerName.GetHashCode();
	int randNum;
	int i; 

	public void setTraitBonus(NPCData.CharTraits charTrait){
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		//randNum = Random.Range (0, 60);


		switch (charTrait) {
		case NPCData.CharTraits.AddictivePersonality:
			i = Random.Range (0, 7);
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			randNum = Random.Range (5, 30);
			NPCCreator.TempList [0].charAddictions [i] += randNum; 
			break;
		case NPCData.CharTraits.Administrator:
			NPCCreator.TempList [0].coreSkillStewardship += 10;
			NPCCreator.TempList [0].attMental += 5;
			break;
		case NPCData.CharTraits.Affable:
			NPCCreator.TempList [0].attSocial += 5;
			NPCCreator.TempList [0].coreSkillPersuasion += 10;
			break;
		case NPCData.CharTraits.Alcoholic:
			NPCCreator.TempList [0].charAddictions [1] += 80;
			break;
		case NPCData.CharTraits.Arrogant:
			NPCCreator.TempList [0].attSocial -= 5;
			NPCCreator.TempList [0].coreSkillPersuasion -= 10;
			NPCCreator.TempList [0].attWillpower += 5; 
			NPCCreator.TempList [0].attNature += 5;
			break;
		case NPCData.CharTraits.BeastTamer:
			NPCCreator.TempList [0].utilitySkillFarmHand += 20;
			NPCCreator.TempList [0].attPhysical += 2;
			break;
		case NPCData.CharTraits.Bimbo:
			NPCCreator.TempList [0].attMental -= 50;
			NPCCreator.TempList [0].utilitySkillLearning -= 50;
			NPCCreator.TempList [0].attSocial += 25;
			NPCCreator.TempList [0].attPhysical += 10; 
			NPCCreator.TempList [0].coreSkillPersuasion += 30;
			NPCCreator.TempList [0].sexSkillWhoring += 40;
			i = Random.Range (0, 7);
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			randNum = Random.Range (5, 30);
			NPCCreator.TempList [0].charAddictions [i] += randNum;
			break;
		case NPCData.CharTraits.Blind:
			NPCCreator.TempList [0].coreSkillMartial -= 80; 
			NPCCreator.TempList [0].coreSkillSecurity -= 80;
			NPCCreator.TempList [0].utilitySkillMedicine -= 20;
			NPCCreator.TempList [0].utilitySkillCrafting -= 80;
			NPCCreator.TempList [0].attWillpower += 30;
			NPCCreator.TempList [0].attPiety += 10;
			NPCCreator.TempList [0].attSocial += 10;
			break;
		case NPCData.CharTraits.Bloodthirsty:
			NPCCreator.TempList [0].attPhysical += 5;
			NPCCreator.TempList [0].coreSkillMartial += 20;
			NPCCreator.TempList [0].attSocial -= 5;
			NPCCreator.TempList [0].coreSkillPersuasion -= 25;
			break;
		case NPCData.CharTraits.Brave:
			NPCCreator.TempList [0].attPhysical += 5;
			NPCCreator.TempList [0].coreSkillMartial += 5;
			NPCCreator.TempList [0].coreSkillTactics += 5; 
			NPCCreator.TempList [0].utilitySkillLearning -= 5;
			break;
		case NPCData.CharTraits.BrokenWill:
			NPCCreator.TempList [0].attObedience += 100;
			NPCCreator.TempList [0].attWillpower -= 100;
			NPCCreator.TempList [0].attDignity -= 100;
			NPCCreator.TempList [0].attHappiness += 50; 
			NPCCreator.TempList [0].isBroken = true; 
			break;

		case NPCData.CharTraits.Celibate:
			NPCCreator.TempList [0].sexSkillWhoring -= 100;
			NPCCreator.TempList [0].sexSkillStripping -= 20;
			NPCCreator.TempList [0].sexSkillPetting -= 20;
			NPCCreator.TempList [0].sexSkillPetplay -= 20;
			NPCCreator.TempList [0].sexSkillMasseuse -= 20;
			NPCCreator.TempList [0].sexSkillGroupSex -= 100;
			NPCCreator.TempList [0].sexSkillPenetration -= 20;
			NPCCreator.TempList [0].charCorruption -= 20; 
			NPCCreator.TempList [0].attLibido -= 30;

			break;
		case NPCData.CharTraits.Charming:
			NPCCreator.TempList [0].attSocial += 5;
			NPCCreator.TempList [0].attObedience += 15;
			NPCCreator.TempList [0].coreSkillPersuasion += 10;
			NPCCreator.TempList [0].utilitySkillEtiquette += 10;
			break;
		case NPCData.CharTraits.Clumsy:
			NPCCreator.TempList [0].utilitySkillCrafting -= 20;
			NPCCreator.TempList [0].utilitySkillHouseKeeping -= 30;
			NPCCreator.TempList [0].utilitySkillPerformance -= 20;
			break;
		case NPCData.CharTraits.Cooperative:
			NPCCreator.TempList [0].coreSkillTactics += 20;
			NPCCreator.TempList [0].attSocial += 5;
			NPCCreator.TempList [0].coreSkillPersuasion += 5;
			NPCCreator.TempList [0].coreSkillDiplomacy += 10;
			break;
		case NPCData.CharTraits.Craven:
			NPCCreator.TempList [0].attPhysical -= 5;
			NPCCreator.TempList [0].attSocial -= 10;
			NPCCreator.TempList [0].attNature -= 40;
			NPCCreator.TempList [0].attDignity -= 20;
			break;
		case NPCData.CharTraits.Crook:
			NPCCreator.TempList [0].charCorruption += 20;
			NPCCreator.TempList [0].coreSkillGovernance -= 30;
			NPCCreator.TempList [0].coreSkillStewardship -= 10; 
			NPCCreator.TempList [0].attMorality -= 20; 
			break;
		case NPCData.CharTraits.Cruel:
			NPCCreator.TempList [0].attMorality -= 40;
			NPCCreator.TempList [0].attPhysical += 5;
			NPCCreator.TempList [0].attSocial -= 5;
			NPCCreator.TempList [0].attNature += 10;
			break;
		case NPCData.CharTraits.CumAddict:
			NPCCreator.TempList [0].charAddictions [7] += 70;
			break;
		case NPCData.CharTraits.Deaf:
			NPCCreator.TempList [0].attSocial -= 10;
			NPCCreator.TempList [0].coreSkillDiplomacy -= 80;
			NPCCreator.TempList [0].utilitySkillPerformance -= 10;
			NPCCreator.TempList [0].coreSkillMartial -= 10;
			NPCCreator.TempList [0].coreSkillPersuasion -= 80;
			NPCCreator.TempList [0].sexSkillEscorting -= 80;
			NPCCreator.TempList [0].utilitySkillLearning += 30;
			NPCCreator.TempList [0].attMental += 10; 
			break;
		case NPCData.CharTraits.Deceitful:
			NPCCreator.TempList [0].charCorruption += 10;
			NPCCreator.TempList [0].attMorality -= 10;
			NPCCreator.TempList [0].attSocial += 5;
			NPCCreator.TempList [0].coreSkillPersuasion += 10;
			NPCCreator.TempList [0].sexSkillEscorting += 5;
			break;
		case NPCData.CharTraits.Deformed:
			NPCCreator.TempList [0].attBeauty -= 50; 
			NPCCreator.TempList [0].attSocial -= 10;
			NPCCreator.TempList [0].coreSkillPersuasion -= 50;
			NPCCreator.TempList [0].sexSkillEscorting -= 50;
			NPCCreator.TempList [0].attPhysical += 15;
			NPCCreator.TempList [0].coreSkillMartial += 30;
			break;
		case NPCData.CharTraits.Dependant:
			NPCCreator.TempList [0].attNature -= 50;
			NPCCreator.TempList [0].attWillpower -= 10;
			NPCCreator.TempList [0].coreSkillPersuasion += 5;
			NPCCreator.TempList [0].charLoyalty += 50;
			break;
		case NPCData.CharTraits.Diligent:
			NPCCreator.TempList [0].coreSkillLabor += 20;
			NPCCreator.TempList [0].utilitySkillLearning += 15;
			NPCCreator.TempList [0].utilitySkillCrafting += 15; 
			NPCCreator.TempList [0].attPhysical += 2;
			break;
		case NPCData.CharTraits.Disciplined:
			NPCCreator.TempList [0].coreSkillMartial += 20;
			NPCCreator.TempList [0].coreSkillStewardship += 10;
			NPCCreator.TempList [0].utilitySkillEtiquette += 5;
			NPCCreator.TempList [0].utilitySkillLearning += 5;
			break;

		case NPCData.CharTraits.Distracted:
			NPCCreator.TempList [0].attMental -= 5;
			NPCCreator.TempList [0].utilitySkillLearning -= 30;
			NPCCreator.TempList [0].attSocial += 3;
			NPCCreator.TempList [0].coreSkillStewardship -= 6;
			NPCCreator.TempList [0].attObedience -= 20;

			break;
		case NPCData.CharTraits.DrugAddict:
			i = Random.Range (2, 7);
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			randNum = Random.Range (30, 80);
			NPCCreator.TempList [0].charAddictions [i] += randNum; 
			break;
		case NPCData.CharTraits.Duelist:
			NPCCreator.TempList [0].coreSkillMartial += 30;
			NPCCreator.TempList [0].attPhysical += 10;
			NPCCreator.TempList [0].attMental -= 5;
			NPCCreator.TempList [0].utilitySkillLearning -= 20;
			break;
		case NPCData.CharTraits.Dull:
			NPCCreator.TempList [0].attNature -= 40;
			NPCCreator.TempList [0].attSocial -= 20;
			NPCCreator.TempList [0].coreSkillPersuasion -= 10;
			break;
		case NPCData.CharTraits.Eccentric:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			NPCCreator.TempList [0].attSocial += Random.Range (-20, 10);
			NPCCreator.TempList [0].attNature += 15;

			break;
		case NPCData.CharTraits.Elegant:
			NPCCreator.TempList [0].utilitySkillEtiquette += 30;
			NPCCreator.TempList [0].utilitySkillPerformance += 10;
			NPCCreator.TempList [0].coreSkillDiplomacy += 5;
			NPCCreator.TempList [0].coreSkillGovernance += 5;
			break;
		case NPCData.CharTraits.Exotic:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			NPCCreator.TempList [0].attBeauty += 10;
			NPCCreator.TempList [0].attDignity += 10;
			break;
		case NPCData.CharTraits.Extroverted:
			NPCCreator.TempList [0].attSocial += 10;
			NPCCreator.TempList [0].coreSkillPersuasion += 15;
			NPCCreator.TempList [0].coreSkillDiplomacy += 5;

			break;
		case NPCData.CharTraits.Fearless:
			NPCCreator.TempList [0].attNature += 5;
			NPCCreator.TempList [0].attWillpower += 25; 
			NPCCreator.TempList [0].attObedience -= 20;
			break;
		case NPCData.CharTraits.Fierce:
			NPCCreator.TempList [0].attWillpower += 10;
			NPCCreator.TempList [0].attPhysical += 5;
			break;
		case NPCData.CharTraits.Forceful:
			NPCCreator.TempList [0].attSocial -= 10;
			NPCCreator.TempList [0].attPhysical += 10;
			NPCCreator.TempList [0].coreSkillMartial += 5;
			NPCCreator.TempList [0].utilitySkillEtiquette -= 15;
			break;
		case NPCData.CharTraits.Frail:
			NPCCreator.TempList [0].attPhysical -= 30;
			NPCCreator.TempList [0].attMental += 10;
			NPCCreator.TempList [0].attSocial += 5;
			NPCCreator.TempList [0].maxHealth -= 20;
			NPCCreator.TempList [0].currentHealth -= 20;
			break;
		case NPCData.CharTraits.Genius:
			NPCCreator.TempList [0].attMental += 40;
			NPCCreator.TempList [0].attSocial -= 20; 
			NPCCreator.TempList [0].utilitySkillLearning += 50;
			break;
		case NPCData.CharTraits.Greedy:
			NPCCreator.TempList [0].coreSkillStewardship += 20;
			NPCCreator.TempList [0].charCorruption += 10;
			NPCCreator.TempList [0].charLoyalty -= 20;
			NPCCreator.TempList [0].attSocial -= 5;
			break;
		case NPCData.CharTraits.Hedonist:
			NPCCreator.TempList [0].utilitySkillPerformance += 20;
			NPCCreator.TempList [0].utilitySkillStreetwise += 5;
			NPCCreator.TempList [0].coreSkillGovernance -= 10;
			NPCCreator.TempList [0].attObedience -= 10;

			break;
		case NPCData.CharTraits.Heretic:
			NPCCreator.TempList [0].attMorality -= 30; 
			NPCCreator.TempList [0].coreSkillPersuasion += 5;
			NPCCreator.TempList [0].coreSkillIntrigue += 30;
			NPCCreator.TempList [0].coreSkillSecurity += 10;
			NPCCreator.TempList [0].attPiety -= 100;
			break;
		case NPCData.CharTraits.Heroic:
			NPCCreator.TempList [0].attMorality += 30; 
			NPCCreator.TempList [0].attSocial += 5; 
			NPCCreator.TempList [0].coreSkillTactics -= 20;
			NPCCreator.TempList [0].coreSkillMartial += 5;
			break;
		case NPCData.CharTraits.Honest:
			NPCCreator.TempList [0].coreSkillIntrigue -= 30;
			NPCCreator.TempList [0].coreSkillDiplomacy -= 10;
			NPCCreator.TempList [0].coreSkillGovernance += 30;
			NPCCreator.TempList [0].coreSkillPersuasion += 5; 
			break;
		case NPCData.CharTraits.Hopeful:
			NPCCreator.TempList [0].attNature += 10;


			break;
		case NPCData.CharTraits.Hopeless:
			NPCCreator.TempList [0].attNature -= 10;

			break;
		case NPCData.CharTraits.Humble:
			NPCCreator.TempList [0].attObedience += 5;
			NPCCreator.TempList [0].attNature -= 10;
			NPCCreator.TempList [0].attSocial += 5;
			NPCCreator.TempList [0].coreSkillPersuasion += 5;
			NPCCreator.TempList [0].utilitySkillEtiquette += 5;

			break;
		case NPCData.CharTraits.Imbecile:
			NPCCreator.TempList [0].attMental -= 50;
			NPCCreator.TempList [0].utilitySkillLearning -= 100;
			break;
		case NPCData.CharTraits.Impaler:
			NPCCreator.TempList [0].coreSkillMartial += 10;
			NPCCreator.TempList [0].attPhysical += 5;
			NPCCreator.TempList [0].attMorality -= 50;

			break;
		case NPCData.CharTraits.Infirm:
			NPCCreator.TempList [0].attPhysical -= 80;
			NPCCreator.TempList [0].coreSkillMartial -= 80;
			NPCCreator.TempList [0].coreSkillTactics += 10;
			NPCCreator.TempList [0].utilitySkillLearning += 20;
			NPCCreator.TempList [0].attMental += 10;
			break;
		case NPCData.CharTraits.Insane:
			NPCCreator.TempList [0].attMental -= 20;
			NPCCreator.TempList [0].utilitySkillLearning -= 20;
			NPCCreator.TempList [0].utilitySkillEtiquette -= 20;
			NPCCreator.TempList [0].coreSkillDiplomacy -= 20;
			NPCCreator.TempList [0].coreSkillGovernance -= 30;
			NPCCreator.TempList [0].coreSkillSecurity += 50;
			iterator += 1;
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			NPCCreator.TempList [0].attNature = Random.Range (-50, 100);
			iterator += 1;
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			NPCCreator.TempList [0].attWillpower = Random.Range (-50, 100);
			iterator += 1;
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			NPCCreator.TempList [0].attMorality = Random.Range (-50, 100);

			break;
		case NPCData.CharTraits.Introverted:
			NPCCreator.TempList [0].attSocial -= 10;
			NPCCreator.TempList [0].coreSkillPersuasion -= 10;
			NPCCreator.TempList [0].coreSkillIntrigue -= 10;
			NPCCreator.TempList [0].utilitySkillLearning += 10;
			break;
		case NPCData.CharTraits.Kind:
			NPCCreator.TempList [0].attMorality += 50;
			NPCCreator.TempList [0].coreSkillGovernance += 10;
			NPCCreator.TempList [0].coreSkillStewardship -= 10;
			NPCCreator.TempList [0].coreSkillMartial -= 20;
			NPCCreator.TempList [0].coreSkillPersuasion += 10;

			break;
		case NPCData.CharTraits.King:
			NPCCreator.TempList [0].attNature += 20;
			NPCCreator.TempList [0].attObedience -= 100;
			NPCCreator.TempList [0].attWillpower += 20; 
			break;
		case NPCData.CharTraits.Lascivious:
			NPCCreator.TempList [0].sexSkillWhoring += 30;
			NPCCreator.TempList [0].sexSkillStripping += 10;
			NPCCreator.TempList [0].sexSkillPetting += 10;
			NPCCreator.TempList [0].sexSkillPetplay += 10;
			NPCCreator.TempList [0].sexSkillMasseuse += 10;
			NPCCreator.TempList [0].sexSkillGroupSex += 30;
			NPCCreator.TempList [0].sexSkillPenetration += 40;
			NPCCreator.TempList [0].charCorruption += 20; 
			NPCCreator.TempList [0].attLibido += 10;
			break;

		case NPCData.CharTraits.LowEnergy:
			NPCCreator.TempList [0].attPhysical -= 10;
			NPCCreator.TempList [0].attNature -= 15;
			NPCCreator.TempList [0].attWillpower -= 5;
			break;
		case NPCData.CharTraits.Lustful:
			NPCCreator.TempList [0].attLibido += 30;
			NPCCreator.TempList [0].charCorruption += 5; 
			break;
		case NPCData.CharTraits.Meticulous:
			NPCCreator.TempList [0].coreSkillStewardship += 20;
			NPCCreator.TempList [0].coreSkillTactics += 5;
			NPCCreator.TempList [0].utilitySkillCrafting += 20;
			break;
		case NPCData.CharTraits.MissingFingers:
			NPCCreator.TempList [0].attPhysical -= 5;
			NPCCreator.TempList [0].utilitySkillCrafting -= 15;
			NPCCreator.TempList [0].coreSkillMartial -= 20;
			break;
		case NPCData.CharTraits.MissingToes:
			NPCCreator.TempList [0].attPhysical -= 5;
			NPCCreator.TempList [0].utilitySkillPerformance -= 15;
			NPCCreator.TempList [0].coreSkillMartial -= 20;
			break;
		case NPCData.CharTraits.Model:
			NPCCreator.TempList [0].attBeauty += 25;
			NPCCreator.TempList [0].attMental -= 20;
			NPCCreator.TempList [0].utilitySkillLearning -= 30;
			break;
		case NPCData.CharTraits.Musician:
			NPCCreator.TempList [0].utilitySkillPerformance += 40;
			NPCCreator.TempList [0].utilitySkillEtiquette += 10;
			NPCCreator.TempList [0].attSocial += 5;
			break;
		case NPCData.CharTraits.Mute:
			NPCCreator.TempList [0].attSocial -= 30;
			NPCCreator.TempList [0].coreSkillPersuasion -= 100;
			NPCCreator.TempList [0].utilitySkillLearning += 20;
			NPCCreator.TempList [0].attMental += 5;
			NPCCreator.TempList [0].coreSkillIntrigue += 20; 
			break;
		case NPCData.CharTraits.Mystic:
			NPCCreator.TempList [0].attMagicPower += 20; 
			NPCCreator.TempList [0].maxMP += 30;
			NPCCreator.TempList [0].currentMP += 30; 
			break;
		case NPCData.CharTraits.Naturalist:
			NPCCreator.TempList [0].coreSkillTactics += 10;
			NPCCreator.TempList [0].utilitySkillFarmHand += 30;
			NPCCreator.TempList [0].coreSkillLabor += 5;
			NPCCreator.TempList [0].attPhysical += 5; 
			NPCCreator.TempList [0].utilitySkillEtiquette -= 30; 
			break;
		case NPCData.CharTraits.Noble:
			NPCCreator.TempList [0].utilitySkillEtiquette += 50; 
			NPCCreator.TempList [0].coreSkillGovernance -= 20;
			break;
		case NPCData.CharTraits.Nymphomaniac:
			NPCCreator.TempList [0].sexSkillWhoring += 50;
			NPCCreator.TempList [0].sexSkillGroupSex += 50;
			NPCCreator.TempList [0].charCorruption += 25; 
			NPCCreator.TempList [0].attLibido += 50;
			break;
		case NPCData.CharTraits.OneEye:
			NPCCreator.TempList [0].coreSkillMartial -= 30;
			NPCCreator.TempList [0].utilitySkillCrafting -= 30;
			NPCCreator.TempList [0].attSocial += 5;
			NPCCreator.TempList [0].coreSkillSecurity -= 10; 
			break;
		case NPCData.CharTraits.Organized:
			NPCCreator.TempList [0].coreSkillStewardship += 20;
			NPCCreator.TempList [0].coreSkillTactics += 20;
			NPCCreator.TempList [0].coreSkillSecurity += 5; 
			break;
		case NPCData.CharTraits.Painter:
			NPCCreator.TempList [0].utilitySkillPerformance += 30;
			NPCCreator.TempList [0].utilitySkillCrafting += 30;
			break;
		case NPCData.CharTraits.Persuasive:
			NPCCreator.TempList [0].coreSkillPersuasion += 20;
			NPCCreator.TempList [0].attSocial += 5;
			NPCCreator.TempList [0].attNature -= 10;
			break;
		case NPCData.CharTraits.PowerfulMagic:
			NPCCreator.TempList [0].attMagicPower += 50;
			NPCCreator.TempList [0].maxMP += 100;
			NPCCreator.TempList [0].currentMP += 100;
			break;
		case NPCData.CharTraits.Prideful:
			NPCCreator.TempList [0].attNature += 10;
			NPCCreator.TempList [0].attWillpower += 10;
			break;
		case NPCData.CharTraits.Prince:
			NPCCreator.TempList [0].attNature += 20;
			NPCCreator.TempList [0].attObedience -= 50;
			NPCCreator.TempList [0].attWillpower += 20; 
			break;
		case NPCData.CharTraits.Princess:
			NPCCreator.TempList [0].attNature += 20;
			NPCCreator.TempList [0].attObedience -= 50;
			NPCCreator.TempList [0].attWillpower += 20; 
			break;
		case NPCData.CharTraits.Queen:
			NPCCreator.TempList [0].attNature += 20;
			NPCCreator.TempList [0].attObedience -= 100;
			NPCCreator.TempList [0].attWillpower += 20; 
			break;
		case NPCData.CharTraits.Rough:
			NPCCreator.TempList [0].attSocial -= 10;
			NPCCreator.TempList [0].coreSkillPersuasion -= 30;
			NPCCreator.TempList [0].attPhysical += 20;
			NPCCreator.TempList [0].attObedience -= 30; 
			break;
		case NPCData.CharTraits.Saint:
			NPCCreator.TempList [0].attMorality += 100;
			NPCCreator.TempList [0].charCorruption -= 100; 
			break;
		case NPCData.CharTraits.Scars:
			NPCCreator.TempList [0].attBeauty -= 10;
			NPCCreator.TempList [0].attSocial += 2;
			NPCCreator.TempList [0].coreSkillMartial += 5;

			break;
		case NPCData.CharTraits.Schemer:
			NPCCreator.TempList [0].charLoyalty -= 40;
			NPCCreator.TempList [0].coreSkillIntrigue += 20; 
			break;
		case NPCData.CharTraits.Seducer:
			NPCCreator.TempList [0].coreSkillPersuasion += 10;
			NPCCreator.TempList [0].sexSkillEscorting += 40;
			NPCCreator.TempList [0].attSocial += 10;
			NPCCreator.TempList [0].attLibido += 10;
			break;
		case NPCData.CharTraits.Sensitive:
			NPCCreator.TempList [0].attSocial += 5; 
			NPCCreator.TempList [0].attNature -= 10;
			NPCCreator.TempList [0].attWillpower -= 5;
			NPCCreator.TempList [0].attPhysical -= 5;

			break;
		case NPCData.CharTraits.Slothful:
			NPCCreator.TempList [0].coreSkillLabor -= 40;
			NPCCreator.TempList [0].coreSkillStewardship -= 10;
			break;
		case NPCData.CharTraits.Slow:
			NPCCreator.TempList [0].attMental -= 25;
			NPCCreator.TempList [0].utilitySkillLearning -= 40; 
			break;
		case NPCData.CharTraits.Smoker:
			NPCCreator.TempList [0].charAddictions [0] += 50; 
			break;
		case NPCData.CharTraits.Sportive:
			NPCCreator.TempList [0].attPhysical += 10;

			break;
		case NPCData.CharTraits.Strategist:
			NPCCreator.TempList [0].coreSkillTactics += 30;
			NPCCreator.TempList [0].attMental += 5;
			NPCCreator.TempList [0].coreSkillMartial -= 5;
			break;
		case NPCData.CharTraits.StrongMagic:
			NPCCreator.TempList [0].attMagicPower += 25;
			NPCCreator.TempList [0].maxMP += 50;
			NPCCreator.TempList [0].currentMP += 50;
			break;
		case NPCData.CharTraits.StrongPersonality:
			NPCCreator.TempList [0].attWillpower += 30;
			NPCCreator.TempList [0].attNature += 20;
			break;
		case NPCData.CharTraits.Studious:
			NPCCreator.TempList [0].utilitySkillLearning += 30;
			NPCCreator.TempList [0].attMental += 5;
			break;
		case NPCData.CharTraits.Teacher:
			NPCCreator.TempList [0].attSocial += 5;
			NPCCreator.TempList [0].attMental += 2; 
			NPCCreator.TempList [0].utilitySkillLearning += 10;
			NPCCreator.TempList [0].coreSkillPersuasion += 20; 
			break;
		case NPCData.CharTraits.Trapper:
			NPCCreator.TempList [0].coreSkillTactics += 20;
			NPCCreator.TempList [0].utilitySkillFarmHand += 5;
			break;
		case NPCData.CharTraits.WeakMagic:
			NPCCreator.TempList [0].attMagicPower += 15;
			NPCCreator.TempList [0].maxMP += 20;
			NPCCreator.TempList [0].currentMP += 20;
			break;
		case NPCData.CharTraits.WeakPersonality:
			NPCCreator.TempList [0].attWillpower -= 30;
			NPCCreator.TempList [0].attNature -= 20;
			break;
		case NPCData.CharTraits.Zealot:
			NPCCreator.TempList [0].attPiety += 100;
			break;


		default:
			break;

		}



	}








}
