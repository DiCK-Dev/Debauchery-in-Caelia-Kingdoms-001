using UnityEngine;
using System.Collections;

public class RaceCreator {
	static int iterator = 0;
	int hashcode = GameControl.playerName.GetHashCode();
	int randNum;
	int count; 

	int FurryOpen = (int)NPCData.CharRace.FURRYOPEN +1;
	int FurryClose = (int)NPCData.CharRace.FURRYCLOSE -1;
	int AvianOpen = (int)NPCData.CharRace.AVIANOPEN +1; 
	int AvianClose = (int)NPCData.CharRace.AVIANCLOSE -1;
	int AquaticOpen = (int)NPCData.CharRace.AQUATICOPEN +1;
	int AquaticClose = (int)NPCData.CharRace.AQUATICCLOSE -1;
	int ExoticOpen = (int)NPCData.CharRace.EXOTICOPEN +1;
	int ExoticClose = (int)NPCData.CharRace.EXOTICCLOSE -1;





	public NPCData.CharFurColor setFur(NPCData.CharRace charRace){
		count = (int)NPCData.CharFurColor.Count - 1;
		iterator += 1; 

		switch (charRace) {
		case NPCData.CharRace.EXOTICCLOSE:
			//example if you want to thinker with specific races
			return (NPCData.CharFurColor)0;
		default:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator);
			return (NPCData.CharFurColor)Random.Range (0, count); 
		}

	}

	public NPCData.CharFeatherColor setFeathers(NPCData.CharRace charRace){
		iterator += 1;
		switch (charRace) {
		case NPCData.CharRace.EXOTICCLOSE:
			//example if you want to thinker with specific races
			return (NPCData.CharFeatherColor)0;
		default:
			count = (int)NPCData.CharFeatherColor.Count -1;
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator);
			return (NPCData.CharFeatherColor)Random.Range (0, count); 
		}

	}



	public NPCData.CharSkinColor setSkinColor(NPCData.CharRace charRace){
		iterator += 1; 
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator);

		switch (charRace) {
		case NPCData.CharRace.incubus:
			randNum = Random.Range (0, 5);
			switch (randNum) {
			/*case 0: 
				return NPCData.CharSkinColor.purple;*/
			case 1: 
				return NPCData.CharSkinColor.blue;
			case 2: 
				return NPCData.CharSkinColor.red;
			/*case 3: 
				return NPCData.CharSkinColor.blackPurple;
			case 4: 
				return NPCData.CharSkinColor.blackRed; */
			default:
				return NPCData.CharSkinColor.blue;
			}

		case NPCData.CharRace.imp:
			return  NPCData.CharSkinColor.red;
		case NPCData.CharRace.goblin:
			return NPCData.CharSkinColor.green;
		case NPCData.CharRace.dragon:
			randNum = Random.Range (0, 5);
			switch (randNum) {
			case 1: 
				return NPCData.CharSkinColor.blue;
			case 2: 
				return NPCData.CharSkinColor.green;
			case 3: 
				return NPCData.CharSkinColor.red; 
			default:
				return NPCData.CharSkinColor.red;
			}

		case NPCData.CharRace.succubus:
			randNum = Random.Range (0, 5);
			switch (randNum) {
			/*case 0: 
				return NPCData.CharSkinColor.purple;*/
			case 1: 
				return NPCData.CharSkinColor.blue;
			case 2: 
				return NPCData.CharSkinColor.red;
			/*case 3: 
				return NPCData.CharSkinColor.blackPurple;
			case 4: 
				return NPCData.CharSkinColor.blackRed; */
			default:
				return NPCData.CharSkinColor.blue;
			}
		
		default:
			return (NPCData.CharSkinColor)Random.Range (0, 6); 
		}

	}

	public NPCData.CharSkinType setSkinType(NPCData.CharRace charRace){
		switch (charRace) {
		case NPCData.CharRace.succubus:
			return  NPCData.CharSkinType.Demon;
		case NPCData.CharRace.incubus:
			return  NPCData.CharSkinType.Demon;
		case NPCData.CharRace.dragon:
			return NPCData.CharSkinType.dragon;
		default:
			//count = (int)NPCData.CharSkinType.Count -1;
			//Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator);
			return NPCData.CharSkinType.Human; 
		}

	}

	public NPCData.DickType setDickType(NPCData.CharRace charRace){
		switch (charRace) {
		case NPCData.CharRace.Wolf:
			return NPCData.DickType.wolf;
		case NPCData.CharRace.Fox:
			return NPCData.DickType.fox;
		case NPCData.CharRace.Equine:
			return NPCData.DickType.equine;
		case NPCData.CharRace.incubus:
			return NPCData.DickType.demon;
		case NPCData.CharRace.succubus:
			return NPCData.DickType.demon;
		case NPCData.CharRace.dragon:
			return NPCData.DickType.dragon;
		default: 
			return NPCData.DickType.human;

		}

	}



	public NPCData.LowerBack setLowerBack(NPCData.CharRace charRace)
	{
		switch (charRace) 
		{
		case NPCData.CharRace.Wolf:
			return NPCData.LowerBack.wolf; 
		case NPCData.CharRace.Bunny:
			return NPCData.LowerBack.bunny;
		case NPCData.CharRace.Equine:
			return NPCData.LowerBack.equine;
		case NPCData.CharRace.Dodo:
			return NPCData.LowerBack.avian;
		case NPCData.CharRace.Crow:
			return NPCData.LowerBack.avian; 
		case NPCData.CharRace.Fox:
			return NPCData.LowerBack.fox; 
		case NPCData.CharRace.Lion:
			return NPCData.LowerBack.feline;
		case NPCData.CharRace.minotaur:
			return NPCData.LowerBack.bull;
		case NPCData.CharRace.Rodent:
			return NPCData.LowerBack.rodent;
		case NPCData.CharRace.Mouse:
			return NPCData.LowerBack.rodent;
		case NPCData.CharRace.Deer:
			return NPCData.LowerBack.deer;
		case NPCData.CharRace.succubus:
			return NPCData.LowerBack.demon;
		case NPCData.CharRace.incubus:
			return NPCData.LowerBack.demon;
		case NPCData.CharRace.dragon:
			return NPCData.LowerBack.dragon;
		default:
			return NPCData.LowerBack.NONE;
		}
	}

	public NPCData.ShoulderBlades setShoulderBlades(NPCData.CharRace charRace){
		switch (charRace) {
		case NPCData.CharRace.succubus:
			return NPCData.ShoulderBlades.DemonWings;
		case NPCData.CharRace.incubus:
			return NPCData.ShoulderBlades.DemonWings;
		case NPCData.CharRace.dragon:
			return NPCData.ShoulderBlades.DragonWings;
		default:
			return NPCData.ShoulderBlades.NONE;
		}
	}

	public NPCData.HeadType setHeadType(NPCData.CharRace charRace){
		/*if (WorldControl.furryOn == false) {
			return NPCData.HeadType.HUMAN;
		}*/

		switch (charRace) {
		case NPCData.CharRace.Dodo:
			return NPCData.HeadType.dodo;
		case NPCData.CharRace.Wolf:
			return NPCData.HeadType.WOLF;	
		case NPCData.CharRace.minotaur:
			return NPCData.HeadType.bull;
		case NPCData.CharRace.Fox:
			return NPCData.HeadType.FOX;
		case NPCData.CharRace.Bunny:
			return NPCData.HeadType.BUNNY;
		case NPCData.CharRace.Equine:
			return NPCData.HeadType.EQUINE;
		case NPCData.CharRace.Crow:
			return NPCData.HeadType.AVIAN;
		case NPCData.CharRace.Lion:
			return NPCData.HeadType.LION;
		case NPCData.CharRace.Rodent:
			return NPCData.HeadType.MOUSE;
		case NPCData.CharRace.Mouse:
			return NPCData.HeadType.MOUSE;
		case NPCData.CharRace.Deer:
			return NPCData.HeadType.DEER;
		case NPCData.CharRace.dragon:
			return NPCData.HeadType.dragon;
		default:
			return NPCData.HeadType.HUMAN;
		}

	}

	/*
	public NPCData.TailType setTailType(NPCData.CharRace charRace){
		switch (charRace) {
		case NPCData.CharRace.Dodo:
			return NPCData.TailType.dodo;
		case NPCData.CharRace.Wolf:
			return NPCData.TailType.wolf;	
		case NPCData.CharRace.Equine:
			return NPCData.TailType.equine;
		default:
			return NPCData.TailType.NONE;

		}

	}*/





	public NPCData.ArmsType setArms(NPCData.CharRace charRace){
		switch (charRace) {
		case NPCData.CharRace.Dodo:
			return NPCData.ArmsType.harpywings;
		case NPCData.CharRace.Wolf:
			return NPCData.ArmsType.WOLF;	
		case NPCData.CharRace.minotaur:
			return NPCData.ArmsType.HUMAN;
		case NPCData.CharRace.Fox:
			return NPCData.ArmsType.FOX;
		case NPCData.CharRace.Bunny:
			return NPCData.ArmsType.BUNNY;
		case NPCData.CharRace.Equine:
			return NPCData.ArmsType.EQUINE;
		case NPCData.CharRace.Crow:
			return NPCData.ArmsType.harpywings;
		case NPCData.CharRace.Lion:
			return NPCData.ArmsType.LION;
		case NPCData.CharRace.Rodent:
			return NPCData.ArmsType.MOUSE;
		case NPCData.CharRace.Mouse:
			return NPCData.ArmsType.MOUSE;
		case NPCData.CharRace.Deer:
			return NPCData.ArmsType.DEER;
		case NPCData.CharRace.dragon:
			return NPCData.ArmsType.dragonclaws; 
		default:
			return NPCData.ArmsType.HUMAN;

		}

	}





	public NPCData.LegsType setLegs(NPCData.CharRace charRace){
		switch (charRace) {
		case NPCData.CharRace.Dodo:
			return NPCData.LegsType.harpy;
		case NPCData.CharRace.Equine:
			return NPCData.LegsType.EQUINE;
		case NPCData.CharRace.minotaur:
			return NPCData.LegsType.hoves;
		case NPCData.CharRace.Wolf:
			return NPCData.LegsType.WOLF;
		case NPCData.CharRace.Fox:
			return NPCData.LegsType.FOX;
		case NPCData.CharRace.Bunny:
			return NPCData.LegsType.BUNNY;
		case NPCData.CharRace.Crow:
			return NPCData.LegsType.harpy;
		case NPCData.CharRace.Lion:
			return NPCData.LegsType.LION;
		case NPCData.CharRace.Rodent:
			return NPCData.LegsType.MOUSE;
		case NPCData.CharRace.Mouse:
			return NPCData.LegsType.MOUSE;
		case NPCData.CharRace.Deer:
			return NPCData.LegsType.DEER;
		case NPCData.CharRace.dragon:
			return NPCData.LegsType.dragon; 
		default:
			return NPCData.LegsType.HUMAN;
		}
	}



	public NPCData.HeadAccesory1 setHeadAcc1(NPCData.CharRace charRace){
		iterator += 1;
		switch (charRace) {
		case NPCData.CharRace.succubus:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator);
			randNum = Random.Range (0, 100);
			if (randNum >= 90) {
				return NPCData.HeadAccesory1.DemonicHornsBig;
			} else if (randNum >= 60) {
				return NPCData.HeadAccesory1.DemonicHorns;
			} else {
				return NPCData.HeadAccesory1.DemonicHornsSmall;
			}
		case NPCData.CharRace.incubus:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator);
			randNum = Random.Range (0, 100);
			if (randNum >= 90) {
				return NPCData.HeadAccesory1.DemonicHornsBig;
			} else if (randNum >= 60) {
				return NPCData.HeadAccesory1.DemonicHorns;
			} else {
				return NPCData.HeadAccesory1.DemonicHornsSmall;
			}
		case NPCData.CharRace.minotaur:
			return NPCData.HeadAccesory1.bullHorns;
		case NPCData.CharRace.Deer:
			return NPCData.HeadAccesory1.deerAntlers;
		case NPCData.CharRace.dragon:
			return NPCData.HeadAccesory1.dragonHorns;
		default:
			return NPCData.HeadAccesory1.NONE;
		}


	}

	public NPCData.HeadAccesory2 setHeadAcc2(NPCData.CharRace charRace){
		switch (charRace) {
		case NPCData.CharRace.drider:
			return NPCData.HeadAccesory2.SpiderEyes;
		case NPCData.CharRace.succubus:
			return NPCData.HeadAccesory2.elfEars;
		case NPCData.CharRace.incubus:
			return NPCData.HeadAccesory2.elfEars;
		case NPCData.CharRace.Elf:
			return NPCData.HeadAccesory2.elfEars;
		default:
			return NPCData.HeadAccesory2.NONE;
		}

	}


	public NPCData.EyesType setEyes(NPCData.CharRace charRace){
		switch (charRace) {
		case NPCData.CharRace.succubus:
			/*Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator);
			randNum = Random.Range (0, 100);
			if (randNum > 50) {
				return NPCData.EyesType.demon0;
			} else {
				return NPCData.EyesType.demon1;
			}*/
			return NPCData.EyesType.demon1;
		case NPCData.CharRace.incubus:
			return NPCData.EyesType.demon0;
		case NPCData.CharRace.Lion:
			return NPCData.EyesType.feline;
		case NPCData.CharRace.dragon:
			return NPCData.EyesType.dragon;
		default:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator);
			randNum = Random.Range (0, 100);
			if (randNum > 50) {
				return NPCData.EyesType.human0;
			} else {
				return NPCData.EyesType.human1;
			}
		}

	}



	public bool setHasTentacles(NPCData.CharRace charRace){
		switch (charRace) {
		case NPCData.CharRace.Plant:
			return true; 
		default:
			return false; 
		}
	}

	public bool setIsFlying(NPCData.CharRace charRace){
		if ((int)charRace >= AvianOpen && (int)charRace <= AvianClose) {
			return true; 
		}

		switch (charRace) {
		case NPCData.CharRace.incubus:
			return true;
		case NPCData.CharRace.succubus:
			return true; 
		case NPCData.CharRace.Crow:
			return true;
		case NPCData.CharRace.dragon:
			return true; 

		default:
			return false; 
		}
	}


	public bool setHasFur(NPCData.CharRace charRace){
		if ((int)charRace >= FurryOpen && (int)charRace <= FurryClose) {
			return true; 
		}

		switch (charRace) {
		case NPCData.CharRace.minotaur:
			return true; 
		
		default:
			return false; 
		}

	}
			
	public bool setHasFeathers(NPCData.CharRace charRace){
		if ((int)charRace >= AvianOpen && (int)charRace <= AvianClose) {
			return true; 
		}

		switch (charRace) {

		default:
			return false; 
		}

	}


	public bool setHasScales(NPCData.CharRace charRace){
		switch (charRace) {
		case NPCData.CharRace.dragon:
			return true; 
		case NPCData.CharRace.Lizard:
			return true; 
		default:
			return false; 
		}

	}

	public bool setIsFurry(NPCData.CharRace charRace){
		if ((int)charRace >= FurryOpen && (int)charRace <= AquaticClose) {
			return true; 
		}

		switch (charRace) {

		default:
			return false; 
		}

	}

	public bool setIsFuta(NPCData.CharSex charSex){
		switch (charSex) {
		case NPCData.CharSex.Dickgirl:
			return true;
		case NPCData.CharSex.Futanari:
			return true;
		default:
			return false; 

		}

	}



}
