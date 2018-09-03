using UnityEngine;
using System.Collections;

public class NPCSettlerPersonAtt {

	static int iterator = 0;
	int randNum;
	int hashcode = GameControl.playerName.GetHashCode();

	public NPCData.CharPersonality setPersonality(){
		iterator += 1;
		int countvalue = (int)NPCData.CharPersonality.Count -1;

		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
	
		return (NPCData.CharPersonality)Random.Range (0, countvalue);


	}



	public float setBeauty(int selector){
		iterator += 5;

		if (selector >= 80) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (80, 100);
		} else if (selector >= 60) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (60, 80);
		} else if (selector >= 40) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (40, 60);
		} else if (selector >= 20) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 40);
		} else if (selector >= 0) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (0, 20);
		} else {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (0, 100);
		}

	}

	public float setTemperament(NPCData.CharClass charClass){
		iterator += 5;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return Random.Range (0, 100);
	}

	public float setWillpower(NPCData.CharClass charClass){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return Random.Range (0, 100);
	}

	public float setNature(NPCData.CharClass charClass){
		iterator += 3;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return Random.Range (0, 100);
	}
	public float setOpenness(NPCData.CharClass charClass){
		iterator += 2;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return Random.Range (0, 100);
	}
	public float setDignity(NPCData.CharClass charClass){
		iterator += 4;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return Random.Range (0, 100);

	}

	public float setObedience(NPCData.CharClass charClass){
		iterator += 2;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return Random.Range (0, 100);
	}
	public float setHappiness(NPCData.CharClass charClass){
		iterator += 6;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return Random.Range (30, 100);
	}
	public float setLibido(NPCData.CharClass charClass){
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return Random.Range (0, 100);
	}
	public float setMorality(NPCData.CharClass charClass){
		iterator += 2;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return Random.Range (0, 100);
	}

	public float setPiety(NPCData.CharClass charClass){
		iterator += 3;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return Random.Range (0, 100);
	}


	public NPCData.GenderBehavior setGenderBehavior(float behStat)
	{
		if (behStat >= 85) {
			return NPCData.GenderBehavior.VeryFeminine;
		} else if (behStat >= 65) {
			return NPCData.GenderBehavior.feminine;
		} else if (behStat >= 35) {
			return NPCData.GenderBehavior.androgynous;
		} else if (behStat >= 15) {
			return NPCData.GenderBehavior.masculine;
		} else{
			return NPCData.GenderBehavior.VeryMasculine;
		}


	}

	public float setBehaviorStat(NPCData.CharGender charGender)
	{
		iterator += 1; 
		if (charGender == NPCData.CharGender.MALE) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (0, 60);
		} else if (charGender == NPCData.CharGender.FEMALE) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (40, 100);
		} else {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 80);
		}

	}


	public NPCData.CharAge setCharAge( NPCData.CharRace charRace){
		iterator += 1; 
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		int count = (int)NPCData.CharAge.Count -1;
		int normalage = (int)NPCData.CharAge.Old - 1;

		switch (charRace) {
		case NPCData.CharRace.angel:
			return (NPCData.CharAge)Random.Range (0, count);
		case NPCData.CharRace.succubus:
			return (NPCData.CharAge)Random.Range (0, count);
		case NPCData.CharRace.incubus:
			return (NPCData.CharAge)Random.Range (0, count);
		default:
			return (NPCData.CharAge)Random.Range (0, normalage);
		}

	}


	public float setLoyalty(NPCData.CharRace charRace, NPCData.CharClass charClass){
		float retValue = 0; 
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 



		switch (charRace) 
		{
		case NPCData.CharRace.angel:
			retValue += Random.Range (0, 10);
			break;
		case NPCData.CharRace.succubus:
			retValue += Random.Range (0, 10) -10;
			break;
		case NPCData.CharRace.incubus:
			retValue += Random.Range (0, 10)-10;
			break;

		default: 
			break; 
		}

		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 

		switch (charClass) {
		case NPCData.CharClass.Inquisitor:
			return retValue + Random.Range (0, 5);
		case NPCData.CharClass.CommunityWorker:
			return retValue + Random.Range (5, 10);
		case NPCData.CharClass.DarkPaladin:
			return retValue + Random.Range (5, 10) -15;
		case NPCData.CharClass.Feral:
			return retValue + Random.Range (5, 10) -15;
		case NPCData.CharClass.Paladin:
			return retValue + Random.Range (5, 10) ;
		case NPCData.CharClass.Politician:
			return retValue + Random.Range (5, 10) -15;
		case NPCData.CharClass.Priest:
			return retValue + Random.Range (0, 5);
		case NPCData.CharClass.Thief:
			return retValue + Random.Range (5, 10) -15;
		default: 
			return retValue;
		}

	}

	public float setCorruption(NPCData.CharRace charRace, NPCData.CharClass charClass){
		float retValue = 0; 
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 



		switch (charRace) 
		{
		case NPCData.CharRace.angel:
			retValue += Random.Range (-15, 10);
			break;
		case NPCData.CharRace.succubus:
			retValue += Random.Range (25, 85);
			break;
		case NPCData.CharRace.incubus:
			retValue += Random.Range (25, 85);
			break;

		default: 
			break; 
		}
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 

		switch (charClass) {
		case NPCData.CharClass.Inquisitor:
			return retValue + Random.Range (-5, 5);
		case NPCData.CharClass.DarkPaladin:
			return retValue + Random.Range (10, 40);
		case NPCData.CharClass.Paladin:
			return retValue + Random.Range (-20, 10);
		case NPCData.CharClass.Politician:
			return retValue + Random.Range (5, 25);
		case NPCData.CharClass.Priest:
			return retValue + Random.Range (-10, 5);
		case NPCData.CharClass.Thief:
			return retValue + Random.Range (5, 20);
		case NPCData.CharClass.Monk:
			return retValue + Random.Range (-15, 10);
		case NPCData.CharClass.Whore:
			return retValue + Random.Range (5, 30);
		
		default: 
			return retValue + Random.Range (0, 20);
		}

	}




	public float setAddiction(int selector, NPCData.CharRace charRace, NPCData.CharClass charClass){
		return 0; 
	}

	public float setCharValue(NPCData.CharRank charRank, NPCData.CharClass charClass, NPCData.BgUpgring upbring, NPCData.CharRace charRace, float beauty, float willpower,float obedience){
		float retValue = 0;

		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		switch (charRank) {
		case NPCData.CharRank.S:
			retValue = Random.Range (250, 400); 
			break;
		case NPCData.CharRank.A:
			retValue = Random.Range (100, 200); 
			break;
		case NPCData.CharRank.B:
			retValue = Random.Range (50, 80); 
			break;
		default:
			retValue = Random.Range (5, 40); 
			break;
		}

		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 

		switch (charClass) {
		case NPCData.CharClass.Alchemist:
			retValue += Random.Range (30, 80);
			break;
		case NPCData.CharClass.Artist:
			retValue += Random.Range (50, 100);
			break;
		case NPCData.CharClass.DarkPaladin:
			retValue += Random.Range (20, 40);
			break;
		case NPCData.CharClass.Farmer:
			retValue += Random.Range (20, 40)-40;
			break;
		case NPCData.CharClass.Feral:
			retValue += Random.Range (20, 40)-40;
			break;
		case NPCData.CharClass.GuildWorker:
			retValue += Random.Range (20, 40)-30;
			break;
		case NPCData.CharClass.Paladin:
			retValue += Random.Range (20, 40);
			break;
		case NPCData.CharClass.Performer:
			retValue += Random.Range (10, 30);
			break;
		case NPCData.CharClass.Warrior:
			retValue += Random.Range (20, 40)-40;
			break;
		default:
			retValue += Random.Range (5, 20); 
			break;
			
		}


		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		switch (upbring) {
		case NPCData.BgUpgring.Royal:
			retValue += Random.Range (1000, 1500); 
			break;
		case NPCData.BgUpgring.Noble:
			retValue += Random.Range (500, 750); 
			break;
		case NPCData.BgUpgring.VeryRich:
			retValue += Random.Range (350, 500); 
			break;
		case NPCData.BgUpgring.Rich:
			retValue += Random.Range (200, 350); 
			break;
		case NPCData.BgUpgring.MiddleClass:
			retValue += Random.Range (100, 200); 
			break;
		case NPCData.BgUpgring.Poor:
			retValue += Random.Range (50, 100); 
			break;
		default:
			retValue += Random.Range (20, 50); 
			break;
		}

		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		switch (charRace) {
		case NPCData.CharRace.Human:
			retValue += Random.Range (50, 100); 
			break;
		case NPCData.CharRace.angel:
			retValue += Random.Range (100, 150); 
			break;
		case NPCData.CharRace.succubus:
			retValue += Random.Range (30, 70); 
			break;
		case NPCData.CharRace.incubus:
			retValue += Random.Range (30, 70); 
			break;
		default:
			retValue += Random.Range (10, 40); 
			break;
		}

		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		if (beauty >= 80) {
			retValue += Random.Range (150, 300); 
		} else if (beauty >= 60) {
			retValue += Random.Range (60, 100); 
		} else if (beauty >= 40) {
			retValue += Random.Range (40, 60); 
		} else if (beauty >= 20) {
			retValue += Random.Range (0, 60)-20; 
		} else {
			retValue += Random.Range (0, 50) - 100; 
		}

		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		if (willpower >= 80) {
			retValue += Random.Range (50, 100); 
		} else if (willpower >= 60) {
			retValue += Random.Range (40, 80); 
		} else if (willpower >= 40) {
			retValue += Random.Range (30, 60); 
		} else if (willpower >= 20) {
			retValue += Random.Range (20, 40); 
		} else  {
			retValue += Random.Range (0, 20)-40; 
		}

		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		if (obedience >= 80) {
			retValue += Random.Range (150, 200); 
		} else if (obedience >= 60) {
			retValue += Random.Range (100, 150); 
		} else if (obedience >= 40) {
			retValue += Random.Range (50, 100); 
		} else if (obedience >= 20) {
			retValue += Random.Range (0, 100) -50; 
		} else {
			retValue += Random.Range (0, 50) - 100; 
		}

		if (retValue < 50) {
			retValue = 50;
		}

		return retValue;
	}






	/*
	void setMinMaxRankC()
	{
		if (NPCCreator.TempList [0].attBeauty > 100) {
			NPCCreator.TempList [0].attBeauty = 100; 
		}
		if (NPCCreator.TempList [0].attBeauty < 0) {
			NPCCreator.TempList [0].attBeauty = 0; 
		}
		if (NPCCreator.TempList [0].attDignity > 100) {
			NPCCreator.TempList [0].attDignity = 100; 
		}
		if (NPCCreator.TempList [0].attDignity < 0) {
			NPCCreator.TempList [0].attDignity = 0; 
		}
		if (NPCCreator.TempList [0].attHappiness > 100) {
			NPCCreator.TempList [0].attHappiness = 100; 
		}
		if (NPCCreator.TempList [0].attHappiness < 0) {
			NPCCreator.TempList [0].attHappiness = 0; 
		}

		if (NPCCreator.TempList [0].attLibido > 100) {
			NPCCreator.TempList [0].attLibido = 100; 
		}
		if (NPCCreator.TempList [0].attLibido < 0) {
			NPCCreator.TempList [0].attLibido = 0; 
		}
		if (NPCCreator.TempList [0].attNature > 100) {
			NPCCreator.TempList [0].attNature = 100; 
		}
		if (NPCCreator.TempList [0].attNature < 0) {
			NPCCreator.TempList [0].attNature = 0; 
		}
		if (NPCCreator.TempList [0].attObedience > 100) {
			NPCCreator.TempList [0].attObedience = 100; 
		}
		if (NPCCreator.TempList [0].attObedience < 0) {
			NPCCreator.TempList [0].attObedience = 0; 
		}
		if (NPCCreator.TempList [0].attOpenness > 100) {
			NPCCreator.TempList [0].attOpenness = 100; 
		}
		if (NPCCreator.TempList [0].attOpenness < 0) {
			NPCCreator.TempList [0].attOpenness = 0; 
		}
		if (NPCCreator.TempList [0].attTemperament > 100) {
			NPCCreator.TempList [0].attTemperament = 100; 
		}
		if (NPCCreator.TempList [0].attTemperament < 0) {
			NPCCreator.TempList [0].attTemperament = 0; 
		}
		if (NPCCreator.TempList [0].attWillpower > 100) {
			NPCCreator.TempList [0].attWillpower = 100; 
		}
		if (NPCCreator.TempList [0].attWillpower < 0) {
			NPCCreator.TempList [0].attWillpower = 0; 
		}
	
		if (NPCCreator.TempList [0].attMagicPower > 70) {
			NPCCreator.TempList [0].attMagicPower = 70; 
		}
		if (NPCCreator.TempList [0].attMagicPower < 0) {
			NPCCreator.TempList [0].attMagicPower = 0; 
		}
		if (NPCCreator.TempList [0].attPhysical > 70) {
			NPCCreator.TempList [0].attPhysical = 70; 
		}
		if (NPCCreator.TempList [0].attPhysical < 0) {
			NPCCreator.TempList [0].attPhysical = 1; 
		}
		if (NPCCreator.TempList [0].attMental > 70) {
			NPCCreator.TempList [0].attMental = 70; 
		}
		if (NPCCreator.TempList [0].attMental < 0) {
			NPCCreator.TempList [0].attMental = 1; 
		}
		if (NPCCreator.TempList [0].attSocial > 70) {
			NPCCreator.TempList [0].attSocial = 70; 
		}
		if (NPCCreator.TempList [0].attSocial < 0) {
			NPCCreator.TempList [0].attSocial = 1; 
		}

		if (NPCCreator.TempList [0].charCorruption > 100) {
			NPCCreator.TempList [0].charCorruption = 100; 
		}
		if (NPCCreator.TempList [0].charCorruption < 0) {
			NPCCreator.TempList [0].charCorruption = 0; 
		}


		if (NPCCreator.TempList [0].coreSkillDiplomacy > 70) {
			NPCCreator.TempList [0].coreSkillDiplomacy = 70; 
		}
		if (NPCCreator.TempList [0].coreSkillGovernance > 70) {
			NPCCreator.TempList [0].coreSkillGovernance = 70; 
		}
		if (NPCCreator.TempList [0].coreSkillIntrigue > 70) {
			NPCCreator.TempList [0].coreSkillIntrigue = 70; 
		}
		if (NPCCreator.TempList [0].coreSkillLabor > 70) {
			NPCCreator.TempList [0].coreSkillLabor = 70; 
		}
		if (NPCCreator.TempList [0].coreSkillMartial > 70) {
			NPCCreator.TempList [0].coreSkillMartial = 70; 
		}
		if (NPCCreator.TempList [0].coreSkillPersuasion > 70) {
			NPCCreator.TempList [0].coreSkillPersuasion = 70; 
		}
		if (NPCCreator.TempList [0].coreSkillSecurity > 70) {
			NPCCreator.TempList [0].coreSkillSecurity = 70; 
		}
		if (NPCCreator.TempList [0].coreSkillStewardship > 70) {
			NPCCreator.TempList [0].coreSkillStewardship = 70; 
		}
		if (NPCCreator.TempList [0].coreSkillTactics > 70) {
			NPCCreator.TempList [0].coreSkillTactics = 70; 
		}

		if (NPCCreator.TempList [0].utilitySkillAlchemy > 70) {
			NPCCreator.TempList [0].utilitySkillAlchemy = 70; 
		}

		if (NPCCreator.TempList [0].utilitySkillCrafting > 70) {
			NPCCreator.TempList [0].utilitySkillCrafting = 70; 
		}
		if (NPCCreator.TempList [0].utilitySkillEtiquette > 70) {
			NPCCreator.TempList [0].utilitySkillEtiquette = 70; 
		}
		if (NPCCreator.TempList [0].utilitySkillFarmHand > 70) {
			NPCCreator.TempList [0].utilitySkillFarmHand = 70; 
		}
		if (NPCCreator.TempList [0].utilitySkillHouseKeeping > 70) {
			NPCCreator.TempList [0].utilitySkillHouseKeeping = 70; 
		}
		if (NPCCreator.TempList [0].utilitySkillLearning > 70) {
			NPCCreator.TempList [0].utilitySkillLearning = 70; 
		}
		if (NPCCreator.TempList [0].utilitySkillMedicine > 70) {
			NPCCreator.TempList [0].utilitySkillMedicine = 70; 
		}
		if (NPCCreator.TempList [0].utilitySkillPerformance > 70) {
			NPCCreator.TempList [0].utilitySkillPerformance = 70; 
		}
		if (NPCCreator.TempList [0].utilitySkillStreetwise > 70) {
			NPCCreator.TempList [0].utilitySkillStreetwise = 70; 
		}
		if (NPCCreator.TempList [0].sexSkillBondage > 70) {
			NPCCreator.TempList [0].sexSkillBondage = 70; 
		}
		if (NPCCreator.TempList [0].sexSkillPenetration > 70) {
			NPCCreator.TempList [0].sexSkillPenetration = 70; 
		}
		if (NPCCreator.TempList [0].sexSkillEscorting > 70) {
			NPCCreator.TempList [0].sexSkillEscorting = 70; 
		}
		if (NPCCreator.TempList [0].sexSkillGroupSex > 70) {
			NPCCreator.TempList [0].sexSkillGroupSex = 70; 
		}
		if (NPCCreator.TempList [0].sexSkillMasseuse > 70) {
			NPCCreator.TempList [0].sexSkillMasseuse = 70; 
		}
		if (NPCCreator.TempList [0].sexSkillPetplay > 70) {
			NPCCreator.TempList [0].sexSkillPetplay = 70; 
		}
		if (NPCCreator.TempList [0].sexSkillPetting > 70) {
			NPCCreator.TempList [0].sexSkillPetting = 70; 
		}
		if (NPCCreator.TempList [0].sexSkillStripping > 70) {
			NPCCreator.TempList [0].sexSkillStripping = 70; 
		}
		if (NPCCreator.TempList [0].sexSkillWhoring > 70) {
			NPCCreator.TempList [0].sexSkillWhoring = 70; 
		}





	}*/

	void setMinMaxRankB(){
		if (NPCCreator.TempList [0].attBeauty > 100) {
			NPCCreator.TempList [0].attBeauty = 100; 
		}
		if (NPCCreator.TempList [0].attBeauty < 0) {
			NPCCreator.TempList [0].attBeauty = 0; 
		}
		if (NPCCreator.TempList [0].attDignity > 100) {
			NPCCreator.TempList [0].attDignity = 100; 
		}
		if (NPCCreator.TempList [0].attDignity < 0) {
			NPCCreator.TempList [0].attDignity = 0; 
		}
		if (NPCCreator.TempList [0].attHappiness > 100) {
			NPCCreator.TempList [0].attHappiness = 100; 
		}
		if (NPCCreator.TempList [0].attHappiness < 0) {
			NPCCreator.TempList [0].attHappiness = 0; 
		}

		if (NPCCreator.TempList [0].attLibido > 100) {
			NPCCreator.TempList [0].attLibido = 100; 
		}
		if (NPCCreator.TempList [0].attLibido < 0) {
			NPCCreator.TempList [0].attLibido = 0; 
		}
		if (NPCCreator.TempList [0].attNature > 100) {
			NPCCreator.TempList [0].attNature = 100; 
		}
		if (NPCCreator.TempList [0].attNature < 0) {
			NPCCreator.TempList [0].attNature = 0; 
		}
		if (NPCCreator.TempList [0].attObedience > 100) {
			NPCCreator.TempList [0].attObedience = 100; 
		}
		if (NPCCreator.TempList [0].attObedience < 0) {
			NPCCreator.TempList [0].attObedience = 0; 
		}
		if (NPCCreator.TempList [0].attOpenness > 100) {
			NPCCreator.TempList [0].attOpenness = 100; 
		}
		if (NPCCreator.TempList [0].attOpenness < 0) {
			NPCCreator.TempList [0].attOpenness = 0; 
		}
		if (NPCCreator.TempList [0].attTemperament > 100) {
			NPCCreator.TempList [0].attTemperament = 100; 
		}
		if (NPCCreator.TempList [0].attTemperament < 0) {
			NPCCreator.TempList [0].attTemperament = 0; 
		}
		if (NPCCreator.TempList [0].attWillpower > 100) {
			NPCCreator.TempList [0].attWillpower = 100; 
		}
		if (NPCCreator.TempList [0].attWillpower < 0) {
			NPCCreator.TempList [0].attWillpower = 0; 
		}

		if (NPCCreator.TempList [0].attMagicPower > 80) {
			NPCCreator.TempList [0].attMagicPower = 80; 
		}
		if (NPCCreator.TempList [0].attMagicPower < 0) {
			NPCCreator.TempList [0].attMagicPower = 0; 
		}
		if (NPCCreator.TempList [0].attPhysical > 80) {
			NPCCreator.TempList [0].attPhysical = 80; 
		}
		if (NPCCreator.TempList [0].attPhysical < 0) {
			NPCCreator.TempList [0].attPhysical = 1; 
		}
		if (NPCCreator.TempList [0].attMental > 80) {
			NPCCreator.TempList [0].attMental = 80; 
		}
		if (NPCCreator.TempList [0].attMental < 0) {
			NPCCreator.TempList [0].attMental = 1; 
		}
		if (NPCCreator.TempList [0].attSocial > 80) {
			NPCCreator.TempList [0].attSocial = 80; 
		}
		if (NPCCreator.TempList [0].attSocial < 0) {
			NPCCreator.TempList [0].attSocial = 1; 
		}

		if (NPCCreator.TempList [0].charCorruption > 100) {
			NPCCreator.TempList [0].charCorruption = 100; 
		}
		if (NPCCreator.TempList [0].charCorruption < 0) {
			NPCCreator.TempList [0].charCorruption = 0; 
		}

		if (NPCCreator.TempList [0].coreSkillDiplomacy > 80) {
			NPCCreator.TempList [0].coreSkillDiplomacy = 80; 
		}
		if (NPCCreator.TempList [0].coreSkillGovernance > 80) {
			NPCCreator.TempList [0].coreSkillGovernance = 80; 
		}
		if (NPCCreator.TempList [0].coreSkillIntrigue > 80) {
			NPCCreator.TempList [0].coreSkillIntrigue = 80; 
		}
		if (NPCCreator.TempList [0].coreSkillLabor > 80) {
			NPCCreator.TempList [0].coreSkillLabor = 80; 
		}
		if (NPCCreator.TempList [0].coreSkillMartial > 80) {
			NPCCreator.TempList [0].coreSkillMartial = 80; 
		}
		if (NPCCreator.TempList [0].coreSkillPersuasion > 80) {
			NPCCreator.TempList [0].coreSkillPersuasion = 80; 
		}
		if (NPCCreator.TempList [0].coreSkillSecurity > 80) {
			NPCCreator.TempList [0].coreSkillSecurity = 80; 
		}
		if (NPCCreator.TempList [0].coreSkillStewardship > 80) {
			NPCCreator.TempList [0].coreSkillStewardship = 80; 
		}
		if (NPCCreator.TempList [0].coreSkillTactics > 80) {
			NPCCreator.TempList [0].coreSkillTactics = 80; 
		}

		if (NPCCreator.TempList [0].utilitySkillAlchemy > 80) {
			NPCCreator.TempList [0].utilitySkillAlchemy = 80; 
		}

		if (NPCCreator.TempList [0].utilitySkillCrafting > 80) {
			NPCCreator.TempList [0].utilitySkillCrafting = 80; 
		}
		if (NPCCreator.TempList [0].utilitySkillEtiquette > 80) {
			NPCCreator.TempList [0].utilitySkillEtiquette = 80; 
		}
		if (NPCCreator.TempList [0].utilitySkillFarmHand > 80) {
			NPCCreator.TempList [0].utilitySkillFarmHand = 80; 
		}
		if (NPCCreator.TempList [0].utilitySkillHouseKeeping > 80) {
			NPCCreator.TempList [0].utilitySkillHouseKeeping = 80; 
		}
		if (NPCCreator.TempList [0].utilitySkillLearning > 80) {
			NPCCreator.TempList [0].utilitySkillLearning = 80; 
		}
		if (NPCCreator.TempList [0].utilitySkillMedicine > 80) {
			NPCCreator.TempList [0].utilitySkillMedicine = 80; 
		}
		if (NPCCreator.TempList [0].utilitySkillPerformance > 80) {
			NPCCreator.TempList [0].utilitySkillPerformance = 80; 
		}
		if (NPCCreator.TempList [0].utilitySkillStreetwise > 80) {
			NPCCreator.TempList [0].utilitySkillStreetwise = 80; 
		}
		if (NPCCreator.TempList [0].sexSkillBondage > 80) {
			NPCCreator.TempList [0].sexSkillBondage = 80; 
		}
		if (NPCCreator.TempList [0].sexSkillPenetration > 80) {
			NPCCreator.TempList [0].sexSkillPenetration = 80; 
		}
		if (NPCCreator.TempList [0].sexSkillEscorting > 80) {
			NPCCreator.TempList [0].sexSkillEscorting = 80; 
		}
		if (NPCCreator.TempList [0].sexSkillGroupSex > 80) {
			NPCCreator.TempList [0].sexSkillGroupSex = 80; 
		}
		if (NPCCreator.TempList [0].sexSkillMasseuse > 80) {
			NPCCreator.TempList [0].sexSkillMasseuse = 80; 
		}
		if (NPCCreator.TempList [0].sexSkillPetplay > 80) {
			NPCCreator.TempList [0].sexSkillPetplay = 80; 
		}
		if (NPCCreator.TempList [0].sexSkillPetting > 80) {
			NPCCreator.TempList [0].sexSkillPetting = 80; 
		}
		if (NPCCreator.TempList [0].sexSkillStripping > 80) {
			NPCCreator.TempList [0].sexSkillStripping = 80; 
		}
		if (NPCCreator.TempList [0].sexSkillWhoring > 80) {
			NPCCreator.TempList [0].sexSkillWhoring = 80; 
		}


	}


	void setMinMaxRankA()
	{
		if (NPCCreator.TempList [0].attBeauty > 100) {
			NPCCreator.TempList [0].attBeauty = 100; 
		}
		if (NPCCreator.TempList [0].attBeauty < 0) {
			NPCCreator.TempList [0].attBeauty = 0; 
		}
		if (NPCCreator.TempList [0].attDignity > 100) {
			NPCCreator.TempList [0].attDignity = 100; 
		}
		if (NPCCreator.TempList [0].attDignity < 0) {
			NPCCreator.TempList [0].attDignity = 0; 
		}
		if (NPCCreator.TempList [0].attHappiness > 100) {
			NPCCreator.TempList [0].attHappiness = 100; 
		}
		if (NPCCreator.TempList [0].attHappiness < 0) {
			NPCCreator.TempList [0].attHappiness = 0; 
		}

		if (NPCCreator.TempList [0].attLibido > 100) {
			NPCCreator.TempList [0].attLibido = 100; 
		}
		if (NPCCreator.TempList [0].attLibido < 0) {
			NPCCreator.TempList [0].attLibido = 0; 
		}
		if (NPCCreator.TempList [0].attNature > 100) {
			NPCCreator.TempList [0].attNature = 100; 
		}
		if (NPCCreator.TempList [0].attNature < 0) {
			NPCCreator.TempList [0].attNature = 0; 
		}
		if (NPCCreator.TempList [0].attObedience > 100) {
			NPCCreator.TempList [0].attObedience = 100; 
		}
		if (NPCCreator.TempList [0].attObedience < 0) {
			NPCCreator.TempList [0].attObedience = 0; 
		}
		if (NPCCreator.TempList [0].attOpenness > 100) {
			NPCCreator.TempList [0].attOpenness = 100; 
		}
		if (NPCCreator.TempList [0].attOpenness < 0) {
			NPCCreator.TempList [0].attOpenness = 0; 
		}
		if (NPCCreator.TempList [0].attTemperament > 100) {
			NPCCreator.TempList [0].attTemperament = 100; 
		}
		if (NPCCreator.TempList [0].attTemperament < 0) {
			NPCCreator.TempList [0].attTemperament = 0; 
		}
		if (NPCCreator.TempList [0].attWillpower > 100) {
			NPCCreator.TempList [0].attWillpower = 100; 
		}
		if (NPCCreator.TempList [0].attWillpower < 0) {
			NPCCreator.TempList [0].attWillpower = 0; 
		}

		if (NPCCreator.TempList [0].attMagicPower > 80) {
			NPCCreator.TempList [0].attMagicPower = 80; 
		}
		if (NPCCreator.TempList [0].attMagicPower < 0) {
			NPCCreator.TempList [0].attMagicPower = 0; 
		}
		if (NPCCreator.TempList [0].attPhysical > 80) {
			NPCCreator.TempList [0].attPhysical = 80; 
		}
		if (NPCCreator.TempList [0].attPhysical < 0) {
			NPCCreator.TempList [0].attPhysical = 1; 
		}
		if (NPCCreator.TempList [0].attMental > 80) {
			NPCCreator.TempList [0].attMental = 80; 
		}
		if (NPCCreator.TempList [0].attMental < 0) {
			NPCCreator.TempList [0].attMental = 1; 
		}
		if (NPCCreator.TempList [0].attSocial > 80) {
			NPCCreator.TempList [0].attSocial = 80; 
		}
		if (NPCCreator.TempList [0].attSocial < 0) {
			NPCCreator.TempList [0].attSocial = 1; 
		}

		if (NPCCreator.TempList [0].charCorruption > 100) {
			NPCCreator.TempList [0].charCorruption = 100; 
		}
		if (NPCCreator.TempList [0].charCorruption < 0) {
			NPCCreator.TempList [0].charCorruption = 0; 
		}

		if (NPCCreator.TempList [0].coreSkillDiplomacy > 90) {
			NPCCreator.TempList [0].coreSkillDiplomacy = 90; 
		}
		if (NPCCreator.TempList [0].coreSkillGovernance > 90) {
			NPCCreator.TempList [0].coreSkillGovernance = 90; 
		}
		if (NPCCreator.TempList [0].coreSkillIntrigue > 90) {
			NPCCreator.TempList [0].coreSkillIntrigue = 90; 
		}
		if (NPCCreator.TempList [0].coreSkillLabor > 90) {
			NPCCreator.TempList [0].coreSkillLabor = 90; 
		}
		if (NPCCreator.TempList [0].coreSkillMartial > 90) {
			NPCCreator.TempList [0].coreSkillMartial = 90; 
		}
		if (NPCCreator.TempList [0].coreSkillPersuasion > 90) {
			NPCCreator.TempList [0].coreSkillPersuasion = 90; 
		}
		if (NPCCreator.TempList [0].coreSkillSecurity > 90) {
			NPCCreator.TempList [0].coreSkillSecurity = 90; 
		}
		if (NPCCreator.TempList [0].coreSkillStewardship > 90) {
			NPCCreator.TempList [0].coreSkillStewardship = 90; 
		}
		if (NPCCreator.TempList [0].coreSkillTactics > 90) {
			NPCCreator.TempList [0].coreSkillTactics = 90; 
		}

		if (NPCCreator.TempList [0].utilitySkillAlchemy > 90) {
			NPCCreator.TempList [0].utilitySkillAlchemy = 90; 
		}

		if (NPCCreator.TempList [0].utilitySkillCrafting > 90) {
			NPCCreator.TempList [0].utilitySkillCrafting = 90; 
		}
		if (NPCCreator.TempList [0].utilitySkillEtiquette > 90) {
			NPCCreator.TempList [0].utilitySkillEtiquette = 90; 
		}
		if (NPCCreator.TempList [0].utilitySkillFarmHand > 90) {
			NPCCreator.TempList [0].utilitySkillFarmHand = 90; 
		}
		if (NPCCreator.TempList [0].utilitySkillHouseKeeping > 90) {
			NPCCreator.TempList [0].utilitySkillHouseKeeping = 90; 
		}
		if (NPCCreator.TempList [0].utilitySkillLearning > 90) {
			NPCCreator.TempList [0].utilitySkillLearning = 90; 
		}
		if (NPCCreator.TempList [0].utilitySkillMedicine > 90) {
			NPCCreator.TempList [0].utilitySkillMedicine = 90; 
		}
		if (NPCCreator.TempList [0].utilitySkillPerformance > 90) {
			NPCCreator.TempList [0].utilitySkillPerformance = 90; 
		}
		if (NPCCreator.TempList [0].utilitySkillStreetwise > 90) {
			NPCCreator.TempList [0].utilitySkillStreetwise = 90; 
		}
		if (NPCCreator.TempList [0].sexSkillBondage > 90) {
			NPCCreator.TempList [0].sexSkillBondage = 90; 
		}
		if (NPCCreator.TempList [0].sexSkillPenetration > 90) {
			NPCCreator.TempList [0].sexSkillPenetration = 90; 
		}
		if (NPCCreator.TempList [0].sexSkillEscorting > 90) {
			NPCCreator.TempList [0].sexSkillEscorting = 90; 
		}
		if (NPCCreator.TempList [0].sexSkillGroupSex > 90) {
			NPCCreator.TempList [0].sexSkillGroupSex = 90; 
		}
		if (NPCCreator.TempList [0].sexSkillMasseuse > 90) {
			NPCCreator.TempList [0].sexSkillMasseuse = 90; 
		}
		if (NPCCreator.TempList [0].sexSkillPetplay > 90) {
			NPCCreator.TempList [0].sexSkillPetplay = 90; 
		}
		if (NPCCreator.TempList [0].sexSkillPetting > 90) {
			NPCCreator.TempList [0].sexSkillPetting = 90; 
		}
		if (NPCCreator.TempList [0].sexSkillStripping > 90) {
			NPCCreator.TempList [0].sexSkillStripping = 90; 
		}
		if (NPCCreator.TempList [0].sexSkillWhoring > 90) {
			NPCCreator.TempList [0].sexSkillWhoring = 90; 
		}



	}



	void setMinMaxRankS(){
		if (NPCCreator.TempList [0].attBeauty > 100) {
			NPCCreator.TempList [0].attBeauty = 100; 
		}
		if (NPCCreator.TempList [0].attBeauty < 0) {
			NPCCreator.TempList [0].attBeauty = 0; 
		}
		if (NPCCreator.TempList [0].attDignity > 100) {
			NPCCreator.TempList [0].attDignity = 100; 
		}
		if (NPCCreator.TempList [0].attDignity < 0) {
			NPCCreator.TempList [0].attDignity = 0; 
		}
		if (NPCCreator.TempList [0].attHappiness > 100) {
			NPCCreator.TempList [0].attHappiness = 100; 
		}
		if (NPCCreator.TempList [0].attHappiness < 0) {
			NPCCreator.TempList [0].attHappiness = 0; 
		}

		if (NPCCreator.TempList [0].attLibido > 100) {
			NPCCreator.TempList [0].attLibido = 100; 
		}
		if (NPCCreator.TempList [0].attLibido < 0) {
			NPCCreator.TempList [0].attLibido = 0; 
		}
		if (NPCCreator.TempList [0].attNature > 100) {
			NPCCreator.TempList [0].attNature = 100; 
		}
		if (NPCCreator.TempList [0].attNature < 0) {
			NPCCreator.TempList [0].attNature = 0; 
		}
		if (NPCCreator.TempList [0].attObedience > 100) {
			NPCCreator.TempList [0].attObedience = 100; 
		}
		if (NPCCreator.TempList [0].attObedience < 0) {
			NPCCreator.TempList [0].attObedience = 0; 
		}
		if (NPCCreator.TempList [0].attOpenness > 100) {
			NPCCreator.TempList [0].attOpenness = 100; 
		}
		if (NPCCreator.TempList [0].attOpenness < 0) {
			NPCCreator.TempList [0].attOpenness = 0; 
		}
		if (NPCCreator.TempList [0].attTemperament > 100) {
			NPCCreator.TempList [0].attTemperament = 100; 
		}
		if (NPCCreator.TempList [0].attTemperament < 0) {
			NPCCreator.TempList [0].attTemperament = 0; 
		}
		if (NPCCreator.TempList [0].attWillpower > 100) {
			NPCCreator.TempList [0].attWillpower = 100; 
		}
		if (NPCCreator.TempList [0].attWillpower < 0) {
			NPCCreator.TempList [0].attWillpower = 0; 
		}

		if (NPCCreator.TempList [0].attMagicPower > 80) {
			NPCCreator.TempList [0].attMagicPower = 80; 
		}
		if (NPCCreator.TempList [0].attMagicPower < 0) {
			NPCCreator.TempList [0].attMagicPower = 0; 
		}
		if (NPCCreator.TempList [0].attPhysical > 80) {
			NPCCreator.TempList [0].attPhysical = 80; 
		}
		if (NPCCreator.TempList [0].attPhysical < 0) {
			NPCCreator.TempList [0].attPhysical = 1; 
		}
		if (NPCCreator.TempList [0].attMental > 80) {
			NPCCreator.TempList [0].attMental = 80; 
		}
		if (NPCCreator.TempList [0].attMental < 0) {
			NPCCreator.TempList [0].attMental = 1; 
		}
		if (NPCCreator.TempList [0].attSocial > 80) {
			NPCCreator.TempList [0].attSocial = 80; 
		}
		if (NPCCreator.TempList [0].attSocial < 0) {
			NPCCreator.TempList [0].attSocial = 1; 
		}

		if (NPCCreator.TempList [0].charCorruption > 100) {
			NPCCreator.TempList [0].charCorruption = 100; 
		}
		if (NPCCreator.TempList [0].charCorruption < 0) {
			NPCCreator.TempList [0].charCorruption = 0; 
		}

		if (NPCCreator.TempList [0].coreSkillDiplomacy > 100) {
			NPCCreator.TempList [0].coreSkillDiplomacy = 100; 
		}
		if (NPCCreator.TempList [0].coreSkillGovernance > 100) {
			NPCCreator.TempList [0].coreSkillGovernance = 100; 
		}
		if (NPCCreator.TempList [0].coreSkillIntrigue > 100) {
			NPCCreator.TempList [0].coreSkillIntrigue = 100; 
		}
		if (NPCCreator.TempList [0].coreSkillLabor > 100) {
			NPCCreator.TempList [0].coreSkillLabor = 100; 
		}
		if (NPCCreator.TempList [0].coreSkillMartial > 100) {
			NPCCreator.TempList [0].coreSkillMartial = 100; 
		}
		if (NPCCreator.TempList [0].coreSkillPersuasion > 100) {
			NPCCreator.TempList [0].coreSkillPersuasion = 100; 
		}
		if (NPCCreator.TempList [0].coreSkillSecurity > 100) {
			NPCCreator.TempList [0].coreSkillSecurity = 100; 
		}
		if (NPCCreator.TempList [0].coreSkillStewardship > 100) {
			NPCCreator.TempList [0].coreSkillStewardship = 100; 
		}
		if (NPCCreator.TempList [0].coreSkillTactics > 100) {
			NPCCreator.TempList [0].coreSkillTactics = 100; 
		}

		if (NPCCreator.TempList [0].utilitySkillAlchemy > 100) {
			NPCCreator.TempList [0].utilitySkillAlchemy = 100; 
		}

		if (NPCCreator.TempList [0].utilitySkillCrafting > 100) {
			NPCCreator.TempList [0].utilitySkillCrafting = 100; 
		}
		if (NPCCreator.TempList [0].utilitySkillEtiquette > 100) {
			NPCCreator.TempList [0].utilitySkillEtiquette = 100; 
		}
		if (NPCCreator.TempList [0].utilitySkillFarmHand > 100) {
			NPCCreator.TempList [0].utilitySkillFarmHand = 100; 
		}
		if (NPCCreator.TempList [0].utilitySkillHouseKeeping > 100) {
			NPCCreator.TempList [0].utilitySkillHouseKeeping = 100; 
		}
		if (NPCCreator.TempList [0].utilitySkillLearning > 100) {
			NPCCreator.TempList [0].utilitySkillLearning = 100; 
		}
		if (NPCCreator.TempList [0].utilitySkillMedicine > 100) {
			NPCCreator.TempList [0].utilitySkillMedicine = 100; 
		}
		if (NPCCreator.TempList [0].utilitySkillPerformance > 100) {
			NPCCreator.TempList [0].utilitySkillPerformance = 100; 
		}
		if (NPCCreator.TempList [0].utilitySkillStreetwise > 100) {
			NPCCreator.TempList [0].utilitySkillStreetwise = 100; 
		}
		if (NPCCreator.TempList [0].sexSkillBondage > 100) {
			NPCCreator.TempList [0].sexSkillBondage = 100; 
		}
		if (NPCCreator.TempList [0].sexSkillPenetration > 100) {
			NPCCreator.TempList [0].sexSkillPenetration = 100; 
		}
		if (NPCCreator.TempList [0].sexSkillEscorting > 100) {
			NPCCreator.TempList [0].sexSkillEscorting = 100; 
		}
		if (NPCCreator.TempList [0].sexSkillGroupSex > 100) {
			NPCCreator.TempList [0].sexSkillGroupSex = 100; 
		}
		if (NPCCreator.TempList [0].sexSkillMasseuse > 100) {
			NPCCreator.TempList [0].sexSkillMasseuse = 100; 
		}
		if (NPCCreator.TempList [0].sexSkillPetplay > 100) {
			NPCCreator.TempList [0].sexSkillPetplay = 100; 
		}
		if (NPCCreator.TempList [0].sexSkillPetting > 100) {
			NPCCreator.TempList [0].sexSkillPetting = 100; 
		}
		if (NPCCreator.TempList [0].sexSkillStripping > 100) {
			NPCCreator.TempList [0].sexSkillStripping = 100; 
		}
		if (NPCCreator.TempList [0].sexSkillWhoring > 100) {
			NPCCreator.TempList [0].sexSkillWhoring = 100; 
		}


	}





}
