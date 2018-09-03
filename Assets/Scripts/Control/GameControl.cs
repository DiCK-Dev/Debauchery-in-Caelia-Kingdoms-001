using UnityEngine;
using System.Collections;
using System.Collections.Generic; 
using System.ComponentModel;

public class GameControl : MonoBehaviour {
	// GameControl has all the variables that define the maincharacter, from health to body parts. 


	static GameControl instance; // helps to get ONLY ONE in the whole game
	public static GameControl control; 



	//public static skillSetFunct = SkillSet 

	//inventory
	// array contains your inventory, first goes the ID of the item, the second the amount 

	public static float gameVersion = 1.1f; 

	public static int[,] invSlotArray = new int[10,2];
	public static float charGold = 0; 

	public static NPCData.CharClass MCClass; 


	// Attributes
	public static string playerName = ""; 


	public static float actualHealth = 100; 
	public static float maxHealth = 100; // this may increase with prowess.. maybe its like 50 + prowess? 

	public static float actualArousal = 0;
	public static float maxArousal = 100; // This should increase with maybe some stuff... up to 120 maybe? 

	public static float actualMP = 0;
	public static float maxMP = 0; // This should increase with maybe some stuff... up to 120 maybe? 

	public static float attPhysical = 30; // they lvl up with decimals, like 0.1 
	public static float attMental = 30;
	public static float attSocial = 30;
	public static float attMagicPower = 0;

	public static float attHypnotism = 0; 

	public static float[] attBonus = new float[4];

	public static float charCorruption = 0;

	public static float attPiety;

	public static float attStyle;

	public static float attAlignment; 

	public static float[] attEquipStyle = new float[12]; //1000 weapons, 2000 armor, 3000 head, 4000 face, 5000 neck, 6000 shoulders, 7000 arms, 8000 legs, 9000 make up, 10000 ring, 11000 amulet, 12000 trophy


	public static float charReputation = 0; 

	public static float[] charAddictions = new float[8]; // tobacco, alcohol, opium, coke, shrooms, hero, semen

	// Core
	public static float coreSkillMartial = 10; //0
	public static float coreSkillSecurity = 10;
	public static float coreSkillLabor = 10;
	public static float coreSkillTactics = 10; //3
	public static float coreSkillGovernance = 10;
	public static float coreSkillStewardship = 10;
	public static float coreSkillPersuasion = 10; //6
	public static float coreSkillIntrigue = 10;
	public static float coreSkillDiplomacy = 10;

	public static float[] coreSkillBonus = new float[9];

	public static float utilitySkillCrafting = 5; 
	public static float utilitySkillHouseKeeping = 5; 
	public static float utilitySkillFarmHand = 5; 
	public static float utilitySkillMedicine = 5;
	public static float utilitySkillAlchemy = 5;
	public static float utilitySkillLearning = 5;
	public static float utilitySkillPerformance = 5;
	public static float utilitySkillEtiquette = 5;
	public static float utilitySkillStreetwise = 5;
	public static float[] utilitySkillBonus = new float[9]; 

	public static float sexSkillMasseuse = 0;
	public static float sexSkillStripping = 0; 
	public static float sexSkillBondage = 0;
	public static float sexSkillPetplay = 0;
	public static float sexSkillPetting = 0;
	public static float sexSkillGroupSex = 0;
	public static float sexSkillPenetration = 0;
	public static float sexSkillWhoring = 0; 
	public static float sexSkillEscorting = 0; 
	public static float[] sexSkillBonus = new float[9]; 



	public static bool[] charArmorTags = new bool[50]; //0 slave, 1 exhibitionism, 2 Holy, 3 Demonic, 4 Royal, 5 Whore, 6 Alchemist, 7 Militar, 8 Tribal, 9 Exotic, 10 sexy, 11 Celibate

	// status effect, dont save
	public static bool[] statusEffect = new bool[5]; // 0 - Always horny, 30 lust always.


	//combat
	public static int[] activeSkills = new int[4]; //  your 4 skill  active by id 
	public static int[] skillSetCounter = new int[6]; 
	public static int[] skillSetLevel = new int[6]; //  this saves the lvl of the skils of your char 

	public static int[] activeLust = new int[4]; 
	public static int[] lustSetLevel = new int[6]; 
	public static int[] lustSetCounter = new int[6]; 


	// skills - each skill will have its own counter and level. 


	//Body transformable and races 
	public enum MCRace  {Human, Wolf, Bunny, Feline, Plant, Equine, Avian, Lizard, Lion, Fox, Mouse, /*BEYOND THIS THE LIST IS FOR EXOTIC AND SPECIFIC RACES, THE REST FOLLOW ORDER*/Hybrid, DEMON};
	public static MCRace mcRace = MCRace.Human; 

	public enum MCHead {[Description("human")]HUMAN, [Description("wolf-like")]WOLF, [Description("bunny-like")]BUNNY, [Description("feline-like")]FELINE, PLANT, EQUINE, AVIAN, LIZARD, LION, FOX, MOUSE };
	public static MCHead mcHead = MCHead.HUMAN;

	public enum MCArms {[Description("human arms")]HUMAN, [Description("wolf claws")]WOLF, [Description("bunny hands")]BUNNY, [Description("feline hands")]FELINE, PLANT, EQUINE, AVIAN, LIZARD, LION, FOX, MOUSE };
	public static MCArms mcArms = MCArms.HUMAN; 

	public enum MCLegs {[Description("human legs and feet")]HUMAN, [Description("wolf legs and feet")]WOLF, [Description("bunny legs and feet")]BUNNY, [Description("feline legs and feet")]FELINE, PLANT, [Description("horse legs with hoves")]EQUINE, AVIAN, LIZARD, LION, FOX, MOUSE };
	public static MCLegs mcLegs = MCLegs.HUMAN;

	public enum MCSkinType {[Description("human skin")]HUMAN, DEMON, ORC, SHARK, PORCELAIN, GOO };
	public static MCSkinType mcSkinType = MCSkinType.HUMAN;

	public enum MCSkinColor {fair, brown, olive, dark, ebony, russet, [Description("dark brown")]darkBrown,  [Description("pale white")]paleWhite, green, red, purple, blue, [Description("pale blue")]paleBlue, [Description("dark blue")]darkBlue, pink, [Description("light blue")]lightBlue, [Description("light green")]lightGreen, [Description("black and red")]blackRed, [Description("black and purple")]blackPurple, Count };
	public static MCSkinColor mcSkinColor = MCSkinColor.olive;

	public enum MCFurColor {Grey, [Description("snow white")]SnowWhite, white, brown, black, pink, blue, [Description("Dark chocolate")]DarkCholocate, [Description("black and white")]BlackWhite, [Description("yellow ocher")]YellowOcher, [Description("dark red")]DarkRed, Purple, Count};
	public static MCFurColor mcFurColor = MCFurColor.Grey;

	public enum MCFeatherColor {Grey, [Description("snow white")]SnowWhite, white, brown, black, pink, blue, [Description("Dark chocolate")]DarkCholocate, [Description("black and white")]BlackWhite, [Description("yellow ocher")]YellowOcher, [Description("dark red")]DarkRed, Purple, Count };
	public static MCFeatherColor mcFeatherColor;



	public enum MCDickType{human, wolf, equine, fox, lion, demon    };
	public static MCDickType mcDickType = MCDickType.human;

	//equipment
	public static int[] charEquipment = new int[12]; //weapon, armor, head, face, neck, shoulders, arms, legs, makeup, ring, amulet, trophy

	// caracteristicas que tiene tu cuerpo y necesitan una lista
	//public static int charGender = 0; // OUTDATED, need to update the rest of the game 0 asexual, 1 woman, 2 male, 3 dickgirl (no vag), 4 futa (vag and penis), 5 herm-male

	public enum MCSex
	{
		[Description("woman")]Woman, [Description("man")]Man, [Description("dickgirl")]Dickgirl, [Description("futa")]Futanari, [Description("cuntboy")]Cuntboy, [Description("trap")]Trap, [Description("maleherm")]Maleherm, [Description("eunuch")]Eunuch 
	}; 
	public static MCSex mcSex = MCSex.Eunuch;  

	public enum MCGender
	{
		[Description("Female")]FEMALE, [Description("Male")] MALE, [Description("Androgynous")] ANDROGYNOUS
	};

	public static MCGender mcGender = MCGender.ANDROGYNOUS; 


	//head and specials 

	public enum MCShoulderBlades{NONE, [Description("angel wings")]AngelWings, [Description("demon wings")]DemonWings, [Description("dragon wings")]DragonWings, [Description("avian wings")]AvianWings, [Description("mosquito wings")]MosquitoWings, [Description("pixie wings")]PixieWings, [Description("gargoyle wings")]GargoyleWings, Count };
	public static MCShoulderBlades mcShoulderBlades = MCShoulderBlades.NONE;

	public enum MCTailType {NONE, Wolf, Bunny, Feline, Plant, Equine, Avian, Lizard, Lion, Fox, Mouse, /*THESE ARE AT THE END OF THE LIST AND ARE FOR EXOTIC CASES, THE REST FOLLOW THE RACE ORDER*/DEMON};
	public static MCTailType mcTailType = MCTailType.NONE;



	public enum MCBeardStyle { NONE, [Description("goatee")]goatee, [Description("ducktail beard")]ducktail,[Description("van dyke beard")]VanDyke, [Description("chin curtain beard")]ChinCurtain, Count }
	public static MCBeardStyle mcBeardStyle = MCBeardStyle.NONE;

	public enum MCBeardLength{NONE, [Description("short stubble")]ShortStubble, [Description("medium stubble")]MediumStubble, [Description("long stubble")]LongStubble, [Description("full")]FullBeard, [Description("long")]LongBeard, [Description("hip lenght beard")]HipLength };
	public static MCBeardLength mcBeardLength = MCBeardLength.NONE;   // this defines how long it is, it doesnt take cm or stuff like that anymore

	public enum MCHeadAccesory1{NONE, [Description("small demonic horns")]DemonicHornsSmall, [Description("demonic horns")]DemonicHorns, [Description("big demonic horns")]DemonicHornsBig, Antlers, [Description("minotaur horns")]MinotaurHorns, [Description("colorful flowers")]ColorfulFlowers, Count};
	public static MCHeadAccesory1 mcHeadAccesory1;

	public enum MCHeadAccesory2{NONE, [Description("spider eyes")]SpiderEyes, Count};
	public static MCHeadAccesory2 mcHeadAccesory2;


	public static bool fertileVery = false;
	public static float fertility = 0.3f; 
	public static bool fertile = true;
	public static float cumProduction = 5; // ml maybe? 
	public static float milkProduction = 350; 
	public static bool lactating = false; 
	public static int lactatingTurns; // how many days are left lacatating


	public enum MCHairColor{black, red, blonde, brown, auburn, white, gray, chesnut,[Description("yellow ochre")]yellowOchre, blue, pink, green, [Description("sky blue")]skyblue, purple, platinum, Count };
	public static MCHairColor mcHairColor = MCHairColor.brown;

	public enum MCHairStyle{disheveled, pixie, sassy, bob, mowhawk, [Description("comb over")]CombOver, [Description("curly bob")]CurlyBob, pompadour, braids, [Description("twist and bun")]twistbun, [Description("elegant bun")]ElegantBun, [Description("manly bun")]ManlyBun, [Description("long ponytails")]LongPonytails, [Description("long curls")]LongCurls, Count};
	public static MCHairStyle mcHairStyle = MCHairStyle.disheveled; 

	public enum MCHairType{normal, GooHair, mane, serpent, Count};
	public static MCHairType mcHairType; 

	public enum MCHairLength{bald, shaven, [Description("very short")]VeryShort, [Description("short")]sshort, [Description("shoulder length")]shoulder, [Description("over the shoulder")]overshoulder, [Description("mid back length")]midback,  [Description("lower back")]lowerback, [Description("knee length")]kneelength, [Description("feet length")]feetLength, overgrown, Count };
	public static MCHairLength mcHairLength = MCHairLength.sshort;

	public static float hairLength = 10; // we dont use it as cm, just as an stat, if anything...

	public enum MCEyesType{human, lizard, demon, dragon, cat, bird, feline};
	public static MCEyesType mcEyesType = MCEyesType.human; 

	public enum MCEyesColor{[Description("dark brown")]darkBrown, black, blue, green, hazel, gray, amber, purple, yellow, red, pink, [Description("pink with yellow star pupils")]pinkStars, [Description("yellow slitted")]yellowSlitted, Count };
	public static MCEyesColor mcEyesColor = MCEyesColor.darkBrown;

	public static float heightChar = 170;  

	public enum MCHeightName{Minuscule, Tiny, Petite, [Description("very short")]VeryShort, Short, [Description("average heigth")]Average, Tall, [Description("very tall")]VeryTall,  Giant, Count };
	public static MCHeightName mcHeightName; 

	public enum MCBodyShape {normal, apple, hourglass, pear, [Description("inverted triangle")]invertedTriangle, rectangle};
	public static MCBodyShape mcBodyShape =  MCBodyShape.normal; 



	public static bool hasTentacles = false; 
	public static bool hasVagina = false; 
	public static bool hasFur = false; 
	public static bool hasScales = false;
	public static bool hasFeathers = false; 
	public static bool isPhantom = false; 
	public static bool isGoo = false; 
	public static bool hasKnot = false; 
	public static bool isFlying = false; 


	public static int breastRow = 1;  // up to two 
	public static string[] tattoo = new string[30]; 
	public static string[] piercings = new string[30];
	public static int specialBody = 0; // 0 null, 1 goo, 2 phantom, 3 snake, 
	public static bool isVirgin = true; 
	public static bool isPregnant = false; 
	public static int pregnantCounter; 
	public static string pregnantText; // this NEEDs to be saved.
	public static NPCData.CharRace mcChildRace; 

	public static float charCombatAttack; // this and charlust isnt really used...
	public static float charLustAttack; 
	public static float charCombatDefense;
	public static float charLustDefense;
	public static float charMagicDefense; 
	public static float charDodge = 20; 


	public enum MCGenderBehavior{[Description("very masculine")]VeryMasculine, masculine, androgynous, feminine, [Description("very feminine")]VeryFeminine}; //if it behaves more feminine or masculine 
	public static MCGenderBehavior mcGenderBehavior = MCGenderBehavior.androgynous; 
	public static float genderBehaviorStat = 50; // this is what sets the above, this can make a char more feminine or masculine after certain point

	public enum MCFacialFeatures{[Description("very masculine")]VeryMasculine, masculine, androgynous, feminine, [Description("very feminine")]VeryFeminine};
	public static MCFacialFeatures mcFacialFeatures = MCFacialFeatures.androgynous; 
	public static float facialFeaturesStat = 50; 

	public enum MCBodyFeatures{[Description("very masculine")]VeryMasculine, masculine, androgynous, feminine, [Description("very feminine")]VeryFeminine};
	public static MCBodyFeatures mcBodyFeatures = MCBodyFeatures.androgynous;
	public static float bodyFeaturesStat = 50; 

	public enum MCPhysique {skinny, slender, thin, slim, average, curvy/*5*/, plump, chubby, [Description("extra chubby")]extraChubby, Count};
	public static MCPhysique mcPhysique = MCPhysique.average;
	public static float physiqueStat; // 0 to 80

	public enum MCBuild{puny, feeble, weak, average, toned, athletic/*5*/, beefy, muscular, hulking, Count};
	public static MCBuild mcBuild = MCBuild.average;
	public static float buildStat; // Every 10 is another level

	public static int dickNum = 0; 
	public static float dick1Size; // 
	public static float dick2Size; // 
	public static float dick1Thick; // 
	public static float dick2Thick; //

	public enum MCDickSize{NONE, tiny, small, average, big, [Description("very big")]veryBig, enormous, [Description("arm length")]armLength, [Description("horse length")]horseLength, humongous}; 
	public static MCDickSize mcDick1Name; 
	public static MCDickSize mcDick2Name; 

	public enum MCTesticleName{NONE, [Description("small like grapes")]smallgrapes, [Description("average size")]averageSize, [Description("big as chestnuts")]bigchestnuts, [Description("big as apples")]bigapples,[Description("big as grapefruits")]bigGrapefruits, [Description("big as melons")]bigMelons, [Description("big as watermelons")]bigWatermelon, Count};
	public static MCTesticleName mcTesticlesName = MCTesticleName.NONE; 

	public static float testiclesSize; // 

	public static float clitorisSize = 0; 

	public enum MCVagLooseness{virgin, [Description("very tight")]verythight, thight, loose, [Description("very loose")]veryloose};
	public static MCVagLooseness mcVagLooseness = MCVagLooseness.virgin;

	public static float vagLooseStat; 


	public enum MCBreastName{flat, [Description("very small")]verySmall, small, regular, ample, full, big, plump, vast, enormous, gigantic, Count};
	public static MCBreastName mcBreast1Name = MCBreastName.flat; 
	public static MCBreastName mcBreast2Name = MCBreastName.flat; 

	public enum MCBreastCup{AA /*0*/, A, B, BB, C, CC /*5*/, D, DD, E, EE, F/*10*/, FF, G, GG, H, HH, HHH, I, II, III, J /*20*/, JJ, JJJ, K, KK, L, LL, LLL, M, MM, MMM/*30*/, N, NN, NNN, O, OO, OOO, P, PP, PPP, Q/*40*/, QQ, QQQ, R, RR, RRR, S, SS, SSS, T, TT/*50*/, TTT, U, UU, UUU, V, VV, VVV, W, WW, WWW/*60*/, X, XX, XXX, Y, YY, YYY, Z, ZZ, ZZZ/*69*/};
	public static MCBreastCup mcBreast1Cup = MCBreastCup.A; 
	public static MCBreastCup mcBreast2Cup = MCBreastCup.A; 

	public static float breast1Size = 0; 
	public static float breast2Size = 0; 

	public static float areola1Size = 3.5f; 
	public static float areola2Size = 0; 


	public enum MCAssName{flat, tiny, [Description("very small")]verysmall, small, average, ample/*5*/, full, big, plump, vast, enormous /*10*/, gigantic};
	public static MCAssName mcAssName = MCAssName.average;

	public enum MCHipsName{petite, tiny, slim, small, average, large /*5*/, ample, big, huge, vast, cowlike /*10*/, gigantic};
	public static MCHipsName mcHipsName = MCHipsName.average;

	public enum MCWaistName{petite, tiny, slim, small, average, large /*5*/, ample,  big, huge, [Description("very wide")]veryWide, enormous /*10*/, immense};
	public static MCWaistName mcWaistName = MCWaistName.average;


	public static float assSize = 2.5f; // 
	public static float hipsSize = 2.5f; //  
	public static float waistSize = 2.5f; //


	public static void cleanInv(){
		int i = 0;
		while (i < 10) {
			if (GameControl.invSlotArray [i, 0] == 10000 || GameControl.invSlotArray [i, 0] == 20000 || GameControl.invSlotArray [i, 0] == 30000 || GameControl.invSlotArray [i, 0] == 40000 || GameControl.invSlotArray [i, 0] == 50000 || GameControl.invSlotArray [i, 0] == 60000 || GameControl.invSlotArray [i, 0] == 70000 || GameControl.invSlotArray [i, 0] == 80000 || GameControl.invSlotArray [i, 0] == 90000 || GameControl.invSlotArray [i, 0] == 100000 || GameControl.invSlotArray [i, 0] == 110000 || GameControl.invSlotArray [i, 0] == 120000) {
				GameControl.invSlotArray [i, 0] = 0;
				GameControl.invSlotArray [i, 1] = 0; 
			}
			i++;
		}
	}


	public static List<NPCData.CharAttacks> MCAttacks = new List<NPCData.CharAttacks>(); 


	void Awake () 
	{
		if (instance != null) 
		{
			Destroy (this.gameObject);
			return; 

		}
		else 
		{
			
			instance = this; 
			GameObject.DontDestroyOnLoad (this.gameObject);
		}


			
	}

		
}
