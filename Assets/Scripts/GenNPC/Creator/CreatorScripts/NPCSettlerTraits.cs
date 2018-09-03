using UnityEngine;
using System.Collections;

public class NPCSettlerTraits 	 {
	int count = (int)NPCData.CharTraits.Count -1;
	static int iterator = 0;
	int hashcode = GameControl.playerName.GetHashCode();
	int randNum;
	public static int trait1, trait2, trait3, trait4, trait5, trait6, trait7, trait8, trait9, trait10; 




	public NPCData.CharTraits setTrait(int iter, NPCData.CharClass charClass, NPCData.CharRace charRace, NPCData.CharPersonality charPersonality, NPCData.BgUpgring upbring, float beauty, NPCData.CharSex charSex)
	{
		int multi = 100/iter; 
		iterator += 1;
		int retValue = 0;

		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		//randNum = Random.Range (0, count);
		randNum = Random.Range (0, 100);

		if (randNum <= multi) 
		{
			
			iterator += 1;
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator + 50); 
			randNum = Random.Range (0, 100);
			
			if (randNum >= 83) {
				retValue = (int)setRaceTraits (charRace);
			} else if (randNum >= 66) {
				retValue = (int)setClassTraits (charClass);
			} else if (randNum >= 50) {
				retValue = (int)setPersonalityTraits (charPersonality);
			} else if (randNum >= 34) {
				retValue = (int)setUpbringTraits (upbring, charSex); 
			} else if (randNum >= 16) {
				retValue = (int)setBeautyTraits (beauty);
			} else {
				retValue = (int)setRandomTrait ();
			}


		}


		if (retValue == trait1) {
			return NPCData.CharTraits.NONE;
		}else if(retValue == trait2){
			return NPCData.CharTraits.NONE;
		}else if(retValue == trait3){
			return NPCData.CharTraits.NONE;
		}else if(retValue == trait4){
			return NPCData.CharTraits.NONE;
		}else if(retValue == trait5){
			return NPCData.CharTraits.NONE;
		}else if(retValue == trait6){
			return NPCData.CharTraits.NONE;
		}else if(retValue == trait7){
			return NPCData.CharTraits.NONE;
		}else if(retValue == trait8){
			return NPCData.CharTraits.NONE;
		}else if(retValue == trait9){
			return NPCData.CharTraits.NONE;
		}else if(retValue == trait10){
			return NPCData.CharTraits.NONE;
		}


		switch (iter) {

		case 1:

			trait1 = retValue;
			break;
		case 2:
			trait2 = retValue;
			break;
		case 3:
			trait3 = retValue;
			break;
		case 4:
			trait4 = retValue;
			break;
		case 5:
			trait5 = retValue;
			break;
		case 6:
			trait6 = retValue;
			break;
		case 7:
			trait7 = retValue;
			break;
		case 8:
			trait8 = retValue;
			break;
		case 9:
			trait9 = retValue;
			break;
		case 10:
			trait10 = retValue;
			break;
		default:
			
			break;
		}


 
		return (NPCData.CharTraits)retValue;
	}






	NPCData.CharTraits setRaceTraits(NPCData.CharRace charRace){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
	

		switch (charRace) {
		case NPCData.CharRace.angel:
			randNum = Random.Range (0, 11);
			switch (randNum) {
			case 0: 
				return NPCData.CharTraits.Humble;
			case 1: 
				return NPCData.CharTraits.Celibate;
			case 2: 
				return NPCData.CharTraits.Mystic;
			case 3: 
				return NPCData.CharTraits.Zealot;
			case 4: 
				return NPCData.CharTraits.Honest;
			case 5: 
				return NPCData.CharTraits.Brave;
			case 6: 
				return NPCData.CharTraits.Heroic;
			case 7: 
				return NPCData.CharTraits.StrongMagic;
			case 8: 
				return NPCData.CharTraits.Exotic;
			case 9: 
				return NPCData.CharTraits.Saint;
			case 10: 
				return NPCData.CharTraits.Affable;
			case 11: 
				return NPCData.CharTraits.Hopeful; 

			default:
				return NPCData.CharTraits.NONE;
			}


		case NPCData.CharRace.succubus:
			randNum = Random.Range (0, 12);
			switch (randNum) {
			case 0: 
				return NPCData.CharTraits.Prideful; 
			case 1: 
				return NPCData.CharTraits.Seducer;
			case 2: 
				return NPCData.CharTraits.Hedonist;
			case 3: 
				return NPCData.CharTraits.Lustful;
			case 4: 
				return NPCData.CharTraits.Deceitful;
			case 5: 
				return NPCData.CharTraits.Schemer;
			case 6: 
				return NPCData.CharTraits.CumAddict;
			case 7: 
				return NPCData.CharTraits.Bimbo;
			case 8: 
				return NPCData.CharTraits.AddictivePersonality;
			case 9: 
				return NPCData.CharTraits.StrongMagic;
			case 10: 
				return NPCData.CharTraits.Nymphomaniac;
			case 11: 
				return NPCData.CharTraits.Exotic;
			case 12: 
				return NPCData.CharTraits.Heretic;
			default:
				return NPCData.CharTraits.NONE;
			}

		case NPCData.CharRace.goblin:
			randNum = Random.Range (0, 3);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Schemer;
			case 1: 
				return NPCData.CharTraits.Craven;
			case 2: 
				return NPCData.CharTraits.Alcoholic;
			case 3: 
				return NPCData.CharTraits.VeryFertile;

			default:
				return NPCData.CharTraits.NONE;
			}
		case NPCData.CharRace.Wolf:
			randNum = Random.Range (0, 3);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Fearless;
			case 1: 
				return NPCData.CharTraits.Vigorous;
			case 2: 
				return NPCData.CharTraits.VeryFertile;
			case 3: 
				return NPCData.CharTraits.Volatile;

			default:
				return NPCData.CharTraits.NONE;
			}
		default:
			return setRandomTrait ();

		}


	}


	NPCData.CharTraits setClassTraits(NPCData.CharClass charClass){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 

		switch (charClass) 
		{
		case NPCData.CharClass.Soldier:
			randNum = Random.Range (0, 4);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.MissingToes;
			case 1: 
				return NPCData.CharTraits.MissingFingers;
			case 2: 
				return NPCData.CharTraits.Brave;
			case 3: 
				return NPCData.CharTraits.Disciplined;
			default:
				return NPCData.CharTraits.Scars;
			}
		case NPCData.CharClass.Warrior:
			randNum = Random.Range (0, 5);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.MissingToes;
			case 1: 
				return NPCData.CharTraits.MissingFingers;
			case 2: 
				return NPCData.CharTraits.Fearless;
			case 3: 
				return NPCData.CharTraits.Duelist;
			case 4:
				return NPCData.CharTraits.Fierce;
			default:
				return NPCData.CharTraits.Scars;
			}
		case NPCData.CharClass.Clerk:
			randNum = Random.Range (0, 4);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Administrator;
			case 1: 
				return NPCData.CharTraits.Craven;
			case 2: 
				return NPCData.CharTraits.Frail;
			case 3: 
				return NPCData.CharTraits.Clumsy;
			default: 
				return NPCData.CharTraits.Cooperative;

			}
		case NPCData.CharClass.Bureaucrat: 
			randNum = Random.Range (0, 4);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Administrator;
			case 1: 
				return NPCData.CharTraits.Craven;
			case 2: 
				return NPCData.CharTraits.Frail;
			case 3: 
				return NPCData.CharTraits.Clumsy;
			default: 
				return NPCData.CharTraits.Cooperative;

			}
		case NPCData.CharClass.Monk:
			randNum = Random.Range (0, 6);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Fearless;
			case 1: 
				return NPCData.CharTraits.Humble;
			case 2: 
				return NPCData.CharTraits.Zealot;
			case 3: 
				return NPCData.CharTraits.Honest;
			case 4: 
				return NPCData.CharTraits.Teacher;
			case 5: 
				return NPCData.CharTraits.Celibate;
			case 6: 
				return NPCData.CharTraits.Heretic;
			default: 
				return NPCData.CharTraits.Celibate;

			}

		case NPCData.CharClass.Priest:
			randNum = Random.Range (0, 7);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Craven;
			case 1: 
				return NPCData.CharTraits.Humble;
			case 2: 
				return NPCData.CharTraits.Zealot;
			case 3: 
				return NPCData.CharTraits.Honest;
			case 4: 
				return NPCData.CharTraits.Schemer;
			case 5: 
				return NPCData.CharTraits.Celibate;
			case 6: 
				return NPCData.CharTraits.Heretic;
			case 7:
				return NPCData.CharTraits.Teacher;
			default: 
				return setRandomTrait ();

			}
		case NPCData.CharClass.Alchemist:
			randNum = Random.Range (0, 6);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Genius;
			case 1: 
				return NPCData.CharTraits.Studious;
			case 2: 
				return NPCData.CharTraits.Scars;
			case 3: 
				return NPCData.CharTraits.WeakMagic;
			case 4: 
				return NPCData.CharTraits.Teacher;
			case 5: 
				return NPCData.CharTraits.AddictivePersonality;
			case 6: 
				return NPCData.CharTraits.Insane;
			default: 
				return NPCData.CharTraits.Insane;

			}

		case NPCData.CharClass.Mystic:
			randNum = Random.Range (0, 7);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.StrongMagic;
			case 1: 
				return NPCData.CharTraits.Smoker;
			case 2: 
				return NPCData.CharTraits.Teacher;
			case 3: 
				return NPCData.CharTraits.Studious;
			case 4: 
				return NPCData.CharTraits.Genius;
			case 5: 
				return NPCData.CharTraits.Prideful;
			case 6: 
				return NPCData.CharTraits.Heretic;
			case 7:
				return NPCData.CharTraits.Insane;
			default: 
				return NPCData.CharTraits.Celibate;

			}
		case NPCData.CharClass.Thief:
			randNum = Random.Range (0, 5);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Schemer;
			case 1: 
				return NPCData.CharTraits.MissingFingers;
			case 2: 
				return NPCData.CharTraits.OneEye;
			case 3: 
				return NPCData.CharTraits.Alcoholic;
			case 4: 
				return NPCData.CharTraits.Meticulous;
			case 5: 
				return NPCData.CharTraits.BrokenWill;
			default: 
				return NPCData.CharTraits.NONE;

			}
		case NPCData.CharClass.Infiltrator:
			randNum = Random.Range (0, 6);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Disciplined;
			case 1: 
				return NPCData.CharTraits.Schemer;
			case 2: 
				return NPCData.CharTraits.Noble;
			case 3: 
				return NPCData.CharTraits.Duelist;
			case 4: 
				return NPCData.CharTraits.Deceitful;
			case 5: 
				return NPCData.CharTraits.Model;
			case 6: 
				return NPCData.CharTraits.Meticulous;
			default: 
				return NPCData.CharTraits.NONE;

			}

		case NPCData.CharClass.Paladin:
			randNum = Random.Range (0, 6);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Honest;
			case 1: 
				return NPCData.CharTraits.Fearless;
			case 2: 
				return NPCData.CharTraits.Duelist;
			case 3: 
				return NPCData.CharTraits.Zealot;
			case 4: 
				return NPCData.CharTraits.Celibate;
			case 5: 
				return NPCData.CharTraits.Prideful;
			case 6: 
				return NPCData.CharTraits.Kind;
			default: 
				return setRandomTrait ();

			}

		case NPCData.CharClass.DarkPaladin:
			randNum = Random.Range (0, 5);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Deceitful;
			case 1: 
				return NPCData.CharTraits.Schemer;
			case 2: 
				return NPCData.CharTraits.WeakMagic;
			case 3: 
				return NPCData.CharTraits.Heretic;
			case 4: 
				return NPCData.CharTraits.Impaler;
			case 5: 
				return NPCData.CharTraits.Cruel;
			default: 
				return setRandomTrait ();

			}
		case NPCData.CharClass.Feral:
			randNum = Random.Range (0, 5);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Vigorous;
			case 1: 
				return NPCData.CharTraits.Fearless;
			case 2: 
				return NPCData.CharTraits.Slothful;
			case 3: 
				return NPCData.CharTraits.Cruel;
			case 4: 
				return NPCData.CharTraits.Imbecile;
			case 5: 
				return NPCData.CharTraits.Naturalist;
			default: 
				return setRandomTrait ();

			}
		case NPCData.CharClass.Barbarian:
			randNum = Random.Range (0, 5);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Vigorous;
			case 1: 
				return NPCData.CharTraits.Fearless;
			case 2: 
				return NPCData.CharTraits.Bloodthirsty;
			case 3: 
				return NPCData.CharTraits.Sportive;
			case 4: 
				return NPCData.CharTraits.Schemer;
			case 5: 
				return NPCData.CharTraits.Volatile;

			default: 
				return setRandomTrait ();

			}
		case NPCData.CharClass.Scout:
			randNum = Random.Range (0, 3);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Strategist;
			case 1: 
				return NPCData.CharTraits.Trapper;
			case 2: 
				return NPCData.CharTraits.Vigorous;
			case 3: 
				return NPCData.CharTraits.Meticulous;
			default: 
				return setRandomTrait ();

			}
		case NPCData.CharClass.Ranger:
			randNum = Random.Range (0, 7);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Strategist;
			case 1: 
				return NPCData.CharTraits.BeastTamer;
			case 2: 
				return NPCData.CharTraits.Vigorous;
			case 3: 
				return NPCData.CharTraits.Naturalist;
			default: 
				return setRandomTrait ();

			}
		case NPCData.CharClass.CommunityWorker:
			randNum = Random.Range (0, 7);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Distracted;
			case 1: 
				return NPCData.CharTraits.Affable;
			case 2: 
				return NPCData.CharTraits.Persuasive;
			case 3: 
				return NPCData.CharTraits.Cooperative;
			default: 
				return setRandomTrait ();

			}
		case NPCData.CharClass.Whore:
			randNum = Random.Range (0, 5);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Nymphomaniac;
			case 1: 
				return NPCData.CharTraits.AddictivePersonality;
			case 2: 
				return NPCData.CharTraits.CumAddict;
			case 3: 
				return NPCData.CharTraits.Smoker;
			case 4: 
				return NPCData.CharTraits.BrokenWill;
			case 5: 
				return NPCData.CharTraits.Model;
			default: 
				return setRandomTrait ();

			}
		case NPCData.CharClass.Farmer:
			randNum = Random.Range (0, 5);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Vigorous;
			case 1: 
				return NPCData.CharTraits.Clumsy;
			case 2: 
				return NPCData.CharTraits.Imbecile;
			case 3: 
				return NPCData.CharTraits.Humble;
			case 4: 
				return NPCData.CharTraits.Honest;
			case 5: 
				return NPCData.CharTraits.Naturalist;
			default: 
				return setRandomTrait ();

			}
		case NPCData.CharClass.GuildWorker:
			randNum = Random.Range (0, 3);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Vigorous;
			case 1: 
				return NPCData.CharTraits.Diligent;
			case 2: 
				return NPCData.CharTraits.Organized;
			case 3: 
				return NPCData.CharTraits.Rough;

			default: 
				return setRandomTrait ();

			}

		case NPCData.CharClass.Politician:
			randNum = Random.Range (0, 4);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Crook;
			case 1: 
				return NPCData.CharTraits.Administrator;
			case 2: 
				return NPCData.CharTraits.Schemer;
			case 3: 
				return NPCData.CharTraits.Noble;
			case 4: 
				return NPCData.CharTraits.Greedy;
			default: 
				return setRandomTrait ();

			}
		case NPCData.CharClass.Diplomat:
			randNum = Random.Range (0, 4);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Persuasive;
			case 1: 
				return NPCData.CharTraits.Model;
			case 2: 
				return NPCData.CharTraits.Deceitful;
			case 3: 
				return NPCData.CharTraits.Sensitive;
			case 4: 
				return NPCData.CharTraits.Elegant;
			default: 
				return setRandomTrait ();

			}
		case NPCData.CharClass.Inquisitor:
			randNum = Random.Range (0, 4);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Meticulous;
			case 1: 
				return NPCData.CharTraits.Disciplined;
			case 2: 
				return NPCData.CharTraits.Fearless;
			case 3: 
				return NPCData.CharTraits.Zealot;
			case 4: 
				return NPCData.CharTraits.Heretic;

			default: 
				return setRandomTrait ();
			}
		case NPCData.CharClass.Enforcer:
			randNum = Random.Range (0, 4);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Duelist;
			case 1: 
				return NPCData.CharTraits.Cruel;
			case 2: 
				return NPCData.CharTraits.Lustful;
			case 3: 
				return NPCData.CharTraits.Alcoholic;
			case 4: 
				return NPCData.CharTraits.Volatile;
			default: 
				return setRandomTrait ();

			}
		case NPCData.CharClass.Performer:
			randNum = Random.Range (0, 5);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Seducer;
			case 1: 
				return NPCData.CharTraits.Sensitive;
			case 2: 
				return NPCData.CharTraits.Hedonist;
			case 3: 
				return NPCData.CharTraits.Sportive;
			case 4: 
				return NPCData.CharTraits.Elegant; 
			case 5: 
				return NPCData.CharTraits.Prideful;

			default: 
				return setRandomTrait ();

			}

		case NPCData.CharClass.Artist:
			randNum = Random.Range (0, 6);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Genius;
			case 1: 
				return NPCData.CharTraits.Diligent;
			case 2: 
				return NPCData.CharTraits.Sensitive;
			case 3: 
				return NPCData.CharTraits.Prideful;
			case 4: 
				return NPCData.CharTraits.Slothful;
			case 5: 
				return NPCData.CharTraits.Elegant;
			case 6:
				return NPCData.CharTraits.Painter;

			default: 
				return setRandomTrait ();

			}
		case NPCData.CharClass.Scholar:
			randNum = Random.Range (0, 5);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Genius;
			case 1: 
				return NPCData.CharTraits.Distracted;
			case 2: 
				return NPCData.CharTraits.Administrator;
			case 3: 
				return NPCData.CharTraits.Meticulous;
			case 4: 
				return NPCData.CharTraits.Prideful;
			case 5: 
				return NPCData.CharTraits.Naturalist;

			default: 
				return setRandomTrait ();

			}



		default:
			return setRandomTrait ();
		}


	}

	NPCData.CharTraits setUpbringTraits(NPCData.BgUpgring upbring, NPCData.CharSex charSex){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 

		switch (upbring) {
		case NPCData.BgUpgring.Royal:
			randNum = Random.Range (0, 4);
			switch (randNum) 
			{
			case 0: 
				if (charSex == NPCData.CharSex.Man || charSex == NPCData.CharSex.Trap || charSex == NPCData.CharSex.Cuntboy) {
					return NPCData.CharTraits.Prince;
				} else {
					return NPCData.CharTraits.Princess; 
				}

			case 1: 
				if (charSex == NPCData.CharSex.Man || charSex == NPCData.CharSex.Trap || charSex == NPCData.CharSex.Cuntboy) {
					return NPCData.CharTraits.King;
				} else {
					return NPCData.CharTraits.Queen;
				}
			case 2: 
				return NPCData.CharTraits.Noble;
			case 3: 
				return NPCData.CharTraits.Prideful;
			case 4: 
				return NPCData.CharTraits.Elegant;

			default: 
				return setRandomTrait ();
			}
		case NPCData.BgUpgring.Noble:
			randNum = Random.Range (0, 6);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Noble;
			case 1: 
				return NPCData.CharTraits.Duelist;
			case 2: 
				return NPCData.CharTraits.Musician;
			case 3: 
				return NPCData.CharTraits.Prideful;
			case 4: 
				return NPCData.CharTraits.Slothful;
			case 5: 
				return NPCData.CharTraits.Smoker;
			case 6: 
				return NPCData.CharTraits.Elegant;
			default: 
				return setRandomTrait ();

			}
		case NPCData.BgUpgring.VeryRich:
			randNum = Random.Range (0, 5);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Hedonist;
			case 1: 
				return NPCData.CharTraits.Prideful;
			case 2: 
				return NPCData.CharTraits.Eccentric;
			case 3: 
				return NPCData.CharTraits.Craven;
			case 4: 
				return NPCData.CharTraits.Greedy;
			case 5: 
				return NPCData.CharTraits.Smoker;
			default: 
				return setRandomTrait ();

			}
		case NPCData.BgUpgring.Rich:
			randNum = Random.Range (0, 5);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Hedonist;
			case 1: 
				return NPCData.CharTraits.Prideful;
			case 2: 
				return NPCData.CharTraits.Eccentric;
			case 3: 
				return NPCData.CharTraits.Craven;
			case 4: 
				return NPCData.CharTraits.Greedy;
			case 5: 
				return NPCData.CharTraits.Smoker;
			default: 
				return setRandomTrait ();

			}
		case NPCData.BgUpgring.MiddleClass:
			randNum = Random.Range (0, 5);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Administrator;
			case 1: 
				return NPCData.CharTraits.Diligent;
			case 2: 
				return NPCData.CharTraits.Studious;
			case 3: 
				return NPCData.CharTraits.Alcoholic;
			case 4: 
				return NPCData.CharTraits.Hopeful;
			case 5: 
				return NPCData.CharTraits.Cooperative;

			default: 
				return setRandomTrait ();

			}
		case NPCData.BgUpgring.Poor:
			randNum = Random.Range (0, 5);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.DrugAddict;
			case 1: 
				return NPCData.CharTraits.Hopeless;
			case 2: 
				return NPCData.CharTraits.Honest;
			case 3: 
				return NPCData.CharTraits.Humble;
			case 4: 
				return NPCData.CharTraits.Vigorous;
			case 5: 
				return NPCData.CharTraits.Rough;
			default: 
				return setRandomTrait ();

			}
		case NPCData.BgUpgring.VeryPoor:
			randNum = Random.Range (0, 5);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.DrugAddict;
			case 1: 
				return NPCData.CharTraits.BrokenWill;
			case 2: 
				return NPCData.CharTraits.Honest;
			case 3: 
				return NPCData.CharTraits.Humble;
			case 4: 
				return NPCData.CharTraits.Vigorous;
			case 5: 
				return NPCData.CharTraits.Rough;
			default: 
				return setRandomTrait ();

			}
		default:
			return setRandomTrait ();


		}//


	}// // // // 


	NPCData.CharTraits setBeautyTraits(float beauty){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 

		if (beauty >= 80) {
			randNum = Random.Range (0, 3);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Model;
			case 1: 
				return NPCData.CharTraits.Bimbo;
			case 2: 
				return NPCData.CharTraits.Persuasive;
			case 3: 
				return NPCData.CharTraits.Frail;
			default: 
				return setRandomTrait ();

			}

		} else if (beauty >= 20) {
			return setRandomTrait ();
		} else {

			randNum = Random.Range (0, 3);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Scars;
			case 1: 
				return NPCData.CharTraits.Deformed;
			case 2: 
				return NPCData.CharTraits.Schemer;
			default: 
				return setRandomTrait ();

			}
		}// // 


	}// // // //


	NPCData.CharTraits setPersonalityTraits(NPCData.CharPersonality personality){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 

		switch (personality) {
		case NPCData.CharPersonality.Plain:
			randNum = Random.Range (0, 2);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Craven;
			case 1: 
				return NPCData.CharTraits.WeakPersonality;
			case 2: 
				return NPCData.CharTraits.Distracted;
			default: 
				return setRandomTrait ();

			}
		case NPCData.CharPersonality.Boring:
			randNum = Random.Range (0, 3);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.LowEnergy;
			case 1: 
				return NPCData.CharTraits.WeakPersonality;
			case 2: 
				return NPCData.CharTraits.Dull;
			case 3: 
				return NPCData.CharTraits.Introverted;

			default: 
				return setRandomTrait ();

			}
		case NPCData.CharPersonality.Delicate:
			randNum = Random.Range (0, 3);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Frail;
			case 1: 
				return NPCData.CharTraits.Sensitive;
			case 2: 
				return NPCData.CharTraits.Musician;
			case 3: 
				return NPCData.CharTraits.Slothful;

			default: 
				return setRandomTrait ();

			}
		case NPCData.CharPersonality.Lively:
			randNum = Random.Range (0, 3);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Vigorous;
			case 1: 
				return NPCData.CharTraits.StrongPersonality;
			case 2: 
				return NPCData.CharTraits.Affable;
			case 3: 
				return NPCData.CharTraits.Extroverted;
			default: 
				return setRandomTrait ();

			}
		case NPCData.CharPersonality.Proud:
			randNum = Random.Range (0, 3);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Prideful;
			case 1: 
				return NPCData.CharTraits.Duelist;
			case 2: 
				return NPCData.CharTraits.Arrogant;
			case 3: 
				return NPCData.CharTraits.Volatile;

			default: 
				return setRandomTrait ();

			}
		case NPCData.CharPersonality.Lazy:
			randNum = Random.Range (0, 3);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Slothful;
			case 1: 
				return NPCData.CharTraits.LowEnergy;
			case 2: 
				return NPCData.CharTraits.Slow;
			case 3: 
				return NPCData.CharTraits.WeakPersonality;
			default: 
				return setRandomTrait ();

			}

		case NPCData.CharPersonality.Serious:
			randNum = Random.Range (0, 3);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Disciplined;
			case 1: 
				return NPCData.CharTraits.Diligent;
			case 2: 
				return NPCData.CharTraits.StrongPersonality;
			case 3: 
				return NPCData.CharTraits.Elegant;
			default: 
				return setRandomTrait ();

			}
		case NPCData.CharPersonality.Virtous:
			randNum = Random.Range (0, 3);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Saint;
			case 1: 
				return NPCData.CharTraits.Disciplined;
			case 2: 
				return NPCData.CharTraits.Heroic;
			case 3: 
				return NPCData.CharTraits.Elegant;
			default: 
				return setRandomTrait ();

			}
		case NPCData.CharPersonality.Lewd:
			randNum = Random.Range (0, 4);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Lustful;
			case 1: 
				return NPCData.CharTraits.Lascivious;
			case 2: 
				return NPCData.CharTraits.Seducer;
			case 3: 
				return NPCData.CharTraits.Eccentric;
			case 4: 
				return NPCData.CharTraits.Nymphomaniac;
			default: 
				return setRandomTrait ();

			}
		case NPCData.CharPersonality.Assertive:
			randNum = Random.Range (0, 3);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.StrongPersonality;
			case 1: 
				return NPCData.CharTraits.StrongPersonality;
			case 2: 
				return NPCData.CharTraits.Forceful;
			case 3: 
				return NPCData.CharTraits.Volatile;
			default: 
				return setRandomTrait ();

			}
		case NPCData.CharPersonality.Cheerful:
			randNum = Random.Range (0, 3);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Extroverted;
			case 1: 
				return NPCData.CharTraits.Hopeful;
			case 2: 
				return NPCData.CharTraits.Dependant;
			case 3: 
				return NPCData.CharTraits.Charming;
			default: 
				return setRandomTrait ();

			}
		case NPCData.CharPersonality.Stoic:
			randNum = Random.Range (0, 3);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.StrongPersonality;
			case 1: 
				return NPCData.CharTraits.Vigorous;
			case 2: 
				return NPCData.CharTraits.Diligent;
			case 3: 
				return NPCData.CharTraits.Disciplined;
			default: 
				return setRandomTrait ();

			}
		case NPCData.CharPersonality.Kind:
			randNum = Random.Range (0, 3);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Affable;
			case 1: 
				return NPCData.CharTraits.Cooperative;
			case 2: 
				return NPCData.CharTraits.Humble;
			case 3: 
				return NPCData.CharTraits.Hopeful;

			default: 
				return setRandomTrait ();

			}
		case NPCData.CharPersonality.Irritable:
			randNum = Random.Range (0, 3);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.StrongPersonality;
			case 1: 
				return NPCData.CharTraits.Volatile;
			case 2: 
				return NPCData.CharTraits.Prideful;
			case 3: 
				return NPCData.CharTraits.Bloodthirsty;
			default: 
				return setRandomTrait ();

			}
		case NPCData.CharPersonality.Uptight:
			randNum = Random.Range (0, 4);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Celibate;
			case 1: 
				return NPCData.CharTraits.Organized;
			case 2: 
				return NPCData.CharTraits.Studious;
			case 3: 
				return NPCData.CharTraits.Introverted;
			case 4: 
				return NPCData.CharTraits.Elegant;
			default: 
				return setRandomTrait ();

			}
		case NPCData.CharPersonality.Friendly:
			randNum = Random.Range (0, 3);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Extroverted;
			case 1: 
				return NPCData.CharTraits.Affable;
			case 2: 
				return NPCData.CharTraits.Cooperative;
			case 3: 
				return NPCData.CharTraits.Honest;

			default: 
				return setRandomTrait ();

			}
		case NPCData.CharPersonality.Harsh:
			randNum = Random.Range (0, 3);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Rough;
			case 1: 
				return NPCData.CharTraits.Fierce;
			case 2: 
				return NPCData.CharTraits.Volatile;
			case 3: 
				return NPCData.CharTraits.Scars;
			default: 
				return setRandomTrait ();

			}

		case NPCData.CharPersonality.Schemer:
			randNum = Random.Range (0, 3);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Schemer;
			case 1: 
				return NPCData.CharTraits.Craven;
			case 2: 
				return NPCData.CharTraits.Strategist;
			case 3: 
				return NPCData.CharTraits.Deceitful;
			default: 
				return setRandomTrait ();

			}
		case NPCData.CharPersonality.Savage:
			randNum = Random.Range (0, 6);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Volatile;
			case 1: 
				return NPCData.CharTraits.Fierce;
			case 2: 
				return NPCData.CharTraits.Slow;
			case 3: 
				return NPCData.CharTraits.Imbecile;
			case 4: 
				return NPCData.CharTraits.Impaler;
			case 5: 
				return NPCData.CharTraits.Fearless;
			case 6: 
				return NPCData.CharTraits.Sportive;
			default: 
				return setRandomTrait ();

			}
		case NPCData.CharPersonality.Courteous:
			randNum = Random.Range (0, 3);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Elegant;
			case 1: 
				return NPCData.CharTraits.Eccentric;
			case 2: 
				return NPCData.CharTraits.Affable;
			case 3: 
				return NPCData.CharTraits.Brave;

			default: 
				return setRandomTrait ();

			}
		case NPCData.CharPersonality.Shy:
			randNum = Random.Range (0, 3);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Introverted;
			case 1: 
				return NPCData.CharTraits.WeakPersonality;
			case 2: 
				return NPCData.CharTraits.Lascivious;
			case 3: 
				return NPCData.CharTraits.Distracted;

			default: 
				return setRandomTrait ();

			}
		case NPCData.CharPersonality.Belligerent:
			randNum = Random.Range (0, 5);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Volatile;
			case 1: 
				return NPCData.CharTraits.Rough;
			case 2: 
				return NPCData.CharTraits.Impaler;
			case 3: 
				return NPCData.CharTraits.Duelist;
			case 4: 
				return NPCData.CharTraits.Forceful;
			case 5: 
				return NPCData.CharTraits.Insane;

			default: 
				return setRandomTrait ();

			}

		case NPCData.CharPersonality.Romantic:
			randNum = Random.Range (0, 5);
			switch (randNum) 
			{
			case 0: 
				return NPCData.CharTraits.Affable;
			case 1: 
				return NPCData.CharTraits.Charming;
			case 2: 
				return NPCData.CharTraits.Musician;
			case 3: 
				return NPCData.CharTraits.Dependant;
			case 4: 
				return NPCData.CharTraits.Honest;
			case 5: 
				return NPCData.CharTraits.Seducer;

			default: 
				return setRandomTrait ();

			}

		default:
			return setRandomTrait ();

		}




	}








	NPCData.CharTraits setRandomTrait()
	{
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return (NPCData.CharTraits)Random.Range (0, count);

	}






}