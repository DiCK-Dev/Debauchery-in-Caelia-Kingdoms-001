using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

[System.Serializable]
public class NPCCharList{
	// this list has every single object, this is where they save and load at the end
	//public static List<NPCData> CharList = new List<NPCData>();

	public static List<NPCData> CharRetainers = new List<NPCData> ();

	public static List<NPCData> CharEnemies = new List<NPCData> ();

	public static List<NPCData> CharNeutral = new List<NPCData> ();

	public static List<NPCData> CharMonster = new List<NPCData> ();

	public static List<NPCData> CharRetainerPrisoner = new List<NPCData> ();

	public static List<NPCData> CharRetainerSlave = new List<NPCData> ();

	public static List<NPCData> CharEnemyPrisoner = new List<NPCData> ();

	public static List<NPCData> CharEnemySlave = new List<NPCData> ();

	public static List<NPCData> CharFollower = new List<NPCData> ();


}


[System.Serializable]
public class NPCData /*: MonoBehaviour*/ {
	/*
	void testing(){

		string charname = CityPosition.GRANDINQUISITOR.toDescription ();
	}
*/






	public int charID;  // id thats going to be used to look for him, should use a genNPC control for this
	public int charPortraitLayer0; // id of its portrait, will be used for enemies and stuff alike, several can have the same
	public int charPortraitLayer1; 
	public int charPortraitLayer2; 
	public int charPortraitLayer3; 
	public int charPortraitLayer3a; 
	public int charPortraitLayer4; 
	public int charPortraitLayer5; 
	public int charPortraitLayer6; 
	public int charPortraitLayer7; 
	public int charPortraitLayer8; 
	public int charPortraitLayer9; 
	public int charPortraitLayer10; 
	public int charPortraitLayer11; 
	public int charPortraitLayer12; 
	public int charPortraitLayer13; 
	public int charPortraitLayer14; 
	public int charPortraitLayer15; 
	public int charPortraitLayer16; 
	public int charPortraitLayer17; 
	public int charPortraitLayer18; 
	public int charPortraitLayer19; 

	public int questControl; 

	public string charName;  // add nick and surname 
	public string charNickname;
	public string charSurname; 
	public enum CharSex { Woman, Man, Dickgirl, Futanari, Cuntboy, Trap, Eunuch, Maleherm, Count }; // 0 female, trap 5
	public CharSex charSex;


	public enum CharGender {[Description("Female")]FEMALE = 0, [Description("Male")] MALE = 1, [Description("Androgynous")] ANDROGYNOUS = 2, Count};
	public CharGender charGender; // Appararent gender, female, male, androgynous

	//special followers
	public int corruptionStage; // it sets the max and ammount of corruption, 0(0-25), 1(25-50), 2(50-75), 3(75-90), 4(100), 
	public int slaveStage; // goes from 0 to 4

	public bool isBrokenControl = false; //it helps us with the broken scene of the chars
	public bool isSlaveControl = false; // used for the make her/him slave scene 


	///////////////////////// special names for breed
	public string relX = ""; // How its refered to the par1
	public string relY = ""; // how its refered to the par2
	public string relCF = ""; // ch fe
	public string relCM = ""; // ch ma
	public string relCN = ""; // ch neu
	public string relSF = ""; // sib fem
	public string relSM = ""; // Sib male
	public string relSN = ""; // sib neut
	// // // // // // // // //

	public enum CharAge{[Description("Young adult")]YoungAdult = 0, Adult = 1, Mature = 2, Old = 3, Ancient = 4, Count};
	public CharAge charAge; 

	public enum CityFaction{NONE, MC, ABBADON, JUNIA, Count};
	public CityFaction cityFaction; 
	// change to sex 


	public bool isRecruited; // if it is in player side. 
	public bool isEnemy;// if its in the enemy AI side
	public bool isMonster; // for neutral monsters and enemies that can be captured
	public bool isNeutral; // used for neutral, hirable characters
	public bool isPrisoner; // this is used with isRecruited or isEnemy to decide in which side it is prisoner. 
	public bool isSlave; // this is used with isRecruited or isEnemy to decide in which side it is prisoner. 
	public bool isParty = false; // if its a party member or not
	public bool isBroken; // used for broken characters 
	public bool isQuesting = false; // if it is in a quest
	public int isMarriedID; // married to ID, 0 means is not married, 1 means to player 
	public float charValue; //value in gold, both to recruit and ransom
	public float charGold; 
	public bool isDead;

	// USED FOR SLAVERY AND WORKING CONTROL
	public bool isBranded; 
	public int workReward; // from -5 to 5, resets every day, only used if working 

	// list of lovers of this character, w/e the person is married. // MAKE AN OBJECT WHERE YOU CAN SAVE THIS DATA, NOT JUST THE ID
	//create a small object that defines only some basic elements like name and id 
	public List<NPCFamily> isMarried; // data o
	public List<NPCFamily> isParent; // it childs 
	public List<NPCFamily> isProgeny; // list of its two parents 

	public List<Titles> charTitles;

	public bool isFriend; // reachs with loyalty over 80, lost if it goes below 30
	public bool isLover; // reachs with charLove over 80, lost if it goes below 30

	public bool isFurry; // to determine portrait 
	public bool isFuta; 

	//these are affected by rank 
	public float attPhysical;  
	public float attMental; 
	public float attSocial; 

	public float[] attBonus = new float[4];
	public float attMagicPower; // special 


	// these are not affected by rank
	public float attBeauty; //(ugly, plain, good looking, captivating, stunning)
	public float attTemperament; //(apathethic,cold, reserved, lively, passional)
	public float attWillpower; // (submissive, docile, humble, assertive, willful) <- changed, used for how easy to control it is
	public float attNature; //(spinless, coward, uncertain, brave, determined) <-- Submissive, docile, humble, assertive, willful
	public float attOpenness; //(Frigthened, uninterested, timid, open, unashamed)
	public float attDignity; // how much self worth it has 
	public float attObedience; 
	public float attHappiness; 
	public float attLibido; // 
	public float attMorality; // how good and bad, it can be corrupt good, it means the person is just twisted
	public float attPiety;
	public float attStyle; // depends on its clothing

	public float attFear; 
	public float attExpectation;
	public float attSpoiled; 

	public enum CharRank{C, B, A, S};
	public CharRank charRank;

	public enum CharPersonality{Plain, Boring, Delicate, Lively, Proud, Lazy, Serious, Virtous, Lewd, Assertive, Cheerful, Stoic, Kind, Irritable, Uptight, Friendly, Harsh, Schemer, Savage, Courteous, Shy, Belligerent, Romantic, Count}; 
	public CharPersonality charPersonality; 

	public enum CharFetish{None, Dominant, Submissive,[Description("Anal ahore")] AnalWhore, [Description("Group sex")] GroupSex, [Description("Cum slut")]CumSlut, Incest, Crossdressing, Exhibitionism, [Description("Pet play")]PetPlay, [Description("Rape fantasy")]RapeFantasy, Voyeurism, Monsters, [Description("Size difference")]SizeDifference, Count}; 	
	public CharFetish charFetish;

	public enum CharClass{Soldier, Warrior, Clerk, Bureaucrat , Monk, Priest, Alchemist, Mystic, Thief, Infiltrator, Paladin, [Description("Dark Paladin")]DarkPaladin, Feral, Barbarian, Scout, 
		Ranger, [Description("Community Worker")]CommunityWorker, Whore, Farmer, [Description("Guild worker")]GuildWorker, Politician, Diplomat, Inquisitor, Enforcer, Performer, Artist, Scholar, Count }; 
	public CharClass charClass; 
	// which class it is. // 0 soldier,1 warrior, 2 clerk, 3 bureaucrat, 4 monk/nun, 5 priest, 6 alchemist, 7 mystic, 8 thief, 9 infiltrator, 10 paladin, 11 dark paladin, 12 feral, 13 barbarian 
	//14 scout, 15 ranger, 16 community worker, 17 whore, 18 farmer, 19 industry worker, 20 politician, 21 diplomat, 22 inquisitor, 23 enforcer, 24 Performer, 25 Artist, 26 Scholar

	public enum CharTraits {NONE, Prideful, Genius, Vigorous, Celibate, Mystic, Duelist, Impaler, Diligent, Disciplined, Humble, Honest, Brave, Seducer, Administrator, Strategist, Zealot,
		Bloodthirsty, Slow, Charming, Imbecile, [Description("Low energy")]LowEnergy, [Description("Weak personality")]WeakPersonality, [Description("Strong personality")]StrongPersonality, Dull, Meticulous, Deformed, Persuasive, Organized, Rough, Distracted, Naturalist, Cooperative, Volatile, Sensitive, Hedonist, Cruel, Lustful, Greedy, Slothful, Infirm, Deceitful, Craven, Frail, Schemer, Blind, Clumsy, Sportive, Deaf, Mute, Alcoholic, 
		[Description("Cum Addict")]CumAddict, Saint, Arrogant, Hopeful, Hopeless, Insane, Eccentric, Introverted, Extroverted, [Description("Drug Addict")]DrugAddict, Smoker, Scars, Affable, Exotic, Musician, Heroic, Crook, Painter, Teacher, [Description("Weak Magic")]WeakMagic, [Description("Strong Magic")]StrongMagic,
		[Description("Powerful Magic")]PowerfulMagic, [Description("Beast tamer")]BeastTamer, Forceful, Trapper, Bimbo,[Description("Broken will")] BrokenWill, Dependant, Fearless, [Description("Missing fingers")]MissingFingers, 
		[Description("Missing toes")]MissingToes, Elegant, Heretic, Fierce, Lascivious, Kind, Nymphomaniac, Model, Studious, [Description("One eye")] OneEye,  [Description("Very Fertile")]VeryFertile, Noble, Prince, Princess, King, Queen, Undead, [Description("Addictive personality")]AddictivePersonality,  Count  
	
	}; 


	public List<CharTraits> charTraits; 

	//only classes and races can use the numbers, the rest need to be manual 

	public enum CharAttacks
	{
		CLASSOPEN, /*<soldier 1-4>*/PrecisionStrike, HoldLine, CombatManuevers, ReachingAttack /* </soldier>*/, /*<Warrior 5-8>*/ BreakShield, Charge, WarCry, Disarm/*</Warrior>*/, /*<Monk 9-12>*/ Meditation, PalmStrike, FluidStance, UnexpectedGrapple /*</Monk>*/, /*<Alchemist 13-16>*/ HulkingPotion, ArousingFumes, 
		DebilitatingFumes, PoisonDarts, /*<Thief 17-20>*/ SmokeBombs, ConcussiveStrike, FoulPlay, PoisonDagger/*</thief>*/, /*<Infiltrator 21-24>*/ ShadowStrike, HitAndRun, CloackAndDagger, SexyDistraction, /*<Paladin 25-28>*/ Smite, DivineFavor, Banish, HealingPrayer /*</Paladin>*/,
		/*<DarkPaladins 29-32>*/ Temptation, LifeSteal, DarkIntervention, MindVision /*</DarkPaladin>*/, /*<Feral 33-36>*/ FeralCry, PinDown, InescapableGrab, DominantPresence /*<Feral>*/, /*<Barbarian 37-40>*/ RecklessCharge, MercilessAttack, BleedingSwipe, Taunt /*</Barbarian>*/, 
		/*<Scout 41-44>*/ ArrowTraps, Ambush, TacticalRetreat, Decoy/*</Scout>*/, /*<Ranger 45-48>*/ TakeAim, Headshot, DoubleShot, SupressingFire /*</Ranger>*/, /*<Inquisitor 49-52>*/ LitanyOfPain, ImplacableSermon, Scourge, IronResolve/*</Inquisitor>*/,/*<Enforcer 53-56>*/ StunningBlow, ShieldWall, PepperGrenade, ShieldCharge /*</Enforcer>*/, 
		/*<Performer 57-60>*/ ElegantStance, HypnoticDance, GraciousAttack, RiskyPerformance/*</Performer>*/, /*<Whore 61-64>*/ Striptease, CrotchGrab, ForcedKissing, IndecentSmile /*</Whore>*/, /*<Mystic 65-68>*/ Concentration, ProtectiveRitual, Hex, IronWill /*</Mystic>*/,  CLASSCLOSE, 
		GENERICOPEN, Bash /*<71-82>*/, Slash, HardBlow, LoudSlap, PocketSand, TakeCover, TripUp, Fondling, BodyShowoff, PlayfulChase, SelfSpanking, SeductiveGesture, GENERICCLOSE,
		RACEOPEN, /*< Wolf 85-89>*/ HuntersMusk, AlphasAura, Rending, FeralBite, /*<Succubus 90-93>*/ DemonicAura, SuccubusTouch, EnticingShow, Charm, /*<Bunny 94-97>*/ HornyLeap, BouncyGrab, BunnyHump, MatingSeason, /*<Equine 98-101>*/ EquineCharge, WildRide, StallionsMusk, ImpetiousKick, RACECLOSE, 

		MAGICOPEN, Heal, IceSpikes, FireBall, ElectricShock, AirBlast, Purification, PerverseVisions, MagicBinds, EtherealHands, ArousingWave, MAGICCLOSE

	};


	public List<CharAttacks> charAttacks; 

	//ysed as occupation too
	public enum Jobs{[Description("no occupation")]NONE, [Description("resting")]CastleRest, [Description("Domestic servant")]CastleDomestic, [Description("Cook")]CastleCook, [Description("Healer")]CastleHealer, [Description("Hunter")]CastleHunter, [Description("Entertainer")]CastleEntertainer, [Description("Artisan")]CastleArtisan, [Description("Farmhand")]CastleFarmhand, [Description("Scribe")]CastleScribe, [Description("Prostitute")] CastleProstitute, [Description("Accountant")]CastleAccountant, [Description("Slave master")]CastleSlaveMaster, [Description("Guard")]CastleGuard, [Description("Captain of the guard")] CastleCaptain, [Description("Courtier")]CastleCourtier, [Description("Counselor")]CastleCounselor, 
	 [Description("Minister")] MINISTER, [Description("Grand Alchemist")]GRANDALCHEMIST, [Description("Grand Priestess")]GRANDPRIESTESS,  [Description("Grand Inquisitor")] /*5*/ GRANDINQUISITOR, Count /*BEYOND THIS POINT THESE ARE SOLELY FOR FOLLOWERS*/,   [Description("Head maid")]  HEADMAID, [Description("Faction leader")] FACTIONLEADER, [Description("Shop owner")]SHOPOWNER, [Description("Mother")] /*10*/ MOTHER, [Description("Sister")] SISTER,  [Description("Retainer")] /*12*/RETAINER, [Description("General")] GENERAL, Death, Escape};
	public Jobs cityJobs; 

	// General: 1-2, Court: 3-6, Barracks: 7-9, Research 10-12, Library: 13-14


	public float coreSkillMartial; //0
	public float coreSkillSecurity;
	public float coreSkillLabor;
	public float coreSkillTactics; 
	public float coreSkillGovernance;
	public float coreSkillStewardship;
	public float coreSkillPersuasion;
	public float coreSkillIntrigue;
	public float coreSkillDiplomacy; //8
	public float[] coreSkillBonus = new float[9]; 

	public float utilitySkillCrafting; 
	public float utilitySkillHouseKeeping; 
	public float utilitySkillFarmHand; 
	public float utilitySkillMedicine;
	public float utilitySkillAlchemy;
	public float utilitySkillLearning;
	public float utilitySkillPerformance;
	public float utilitySkillEtiquette;
	public float utilitySkillStreetwise;
	public float[] utilitySkillBonus = new float[9]; 

	public float sexSkillMasseuse;
	public float sexSkillStripping; 
	public float sexSkillBondage;
	public float sexSkillPetplay;
	public float sexSkillPetting;
	public float sexSkillGroupSex;
	public float sexSkillPenetration;
	public float sexSkillWhoring; 
	public float sexSkillEscorting; 
	public float[] sexSkillBonus = new float[9]; 

	public enum BgAdulthood{[Description("Ten years war veteran")]TenYearsVeteran, Crusader, Enforcer, [Description("Arena Champion")]ArenaChampion, [Description("Monster hunter")]MonsterHunter, Criminal,
		[Description("Royal guard")]RoyalGuard, [Description("Caravan guard")]CaravanGuard, Inquisitor, Vigilante, [Description("Free slave")]FreeSlave, Farmer, [Description("Guild worker")]GuildWorker,
		Smith, Rancher, [Description("Army tactician")]ArmyTactician, [Description("Bounty hunter")]BountyHunter, [Description("Army scout")]ArmyScout, [Description("Slave hunter")]SlaveHunter, 
		[Description("Game master")]GameMaster, [Description("Town major")]TownMajor, [Description("Governor assistant")]GovernorAssistant, Priest, Courtier, [Description("Community organizer")]CommOrganizer,
		[Description("Successful merchant")]succMerchant, [Description("Nobleman steward")]NobleSteward, [Description("Minister")]Minister, [Description("Army manager")]ArmyManager, Banker, Whore,
		Cassanova, Monk, [Description("Highclass escort")]HichclassEscort, Corruptor, Spy, Saboteur, Agitator, Smuggler, Assasin, Ambassador, Broker, Sage, Polyglot, [Description("Army official")]ArmyOfficial,
		Adventurer, Survivalist, Alchemist, Academic, Mage, [Description("Dark mage")] DarkMage, Count

	}; 
	public BgAdulthood bgAdulthood;



	public enum BgChildhood{[Description("Young army auxiliar")] YoungArmyAuxiliar, [Description("Veteran family")] VeteranFamily, [Description("Street Fighter")] StreetFighter, [Description("Young squire")] YoungSquire,
		[Description("Swordman apprentice")] SwordmanApprentice, [Description("Caravan guard")]CaravanGuard,[Description("Royal Guard apprentice")]RoyalGuardApprentice, Watchman,[Description("Criminal family")]CriminalFamily,
		[Description("Enforcer parents")]EnforcerParents, [Description("Farmer family")]FarmerFamily, [Description("Young servant")]YoungServant, [Description("Forcer labor")]ForcerLabor,[Description("Slave family")]SlaveFamily,
		[Description("Smith assistant")]SmithAssistant, [Description("Chess player")]ChessPlayer, Bookworm, [Description("Parent General")]parentGeneral, [Description("Young scout")]YoungScout,  [Description("History lover")]HistoryLover,
		[Description("Blue blood")]BlueBlood, [Description("Nobleman's family")]NobleFamily, [Description("Priestess nmother")]PriestessMother, [Description("Gangster kid")]GangsterKid, [Description("Charity volunteer")]CharityVolunteer,
		[Description("Merchant parent")]MerchantParent, [Description("Merchant Assistant")]MerchantAssistant, [Description("Clerk parent")]ClerkParent, [Description("Young page")]YoungPage, [Description("School student")]SchoolStudent,
		[Description("Young acolyte")]YoungAcolyte, [Description("Inquisitor parent")] InquisitorParent, [Description("Whore mother")]WhoreParent, [Description("Promiscuous family")]PromiscuousFamily, [Description("Incestuous family")]IncestuousFamily,
		[Description("Street Urchin")]StreetUrchin, [Description("Game poacher")]GamePoacher, Bastard, [Description("Assasin parent")]AssasinParent, [Description("Involved in royal affairs")]RoyalAffair, [Description("Ambassador parent")]AmbassadorParent,
		[Description("Speech Lessons")]SpeechLessons, [Description("Noblewoman's hostage")]NobleHostage, [Description("Exchange Student")]ExchangeStudent, [Description("Minister parent")]MinisterParent,[Description("Savage family")]SavageFamily,
		[Description("Tribal family")]TribalFamily,[Description("Wild child")]WildChild, Count

	}; 
	public BgChildhood bgChildhood;

	public string[] bgStory = new string[3];  // childhood, young adulthood, current

	public enum BgUpgring{[Description("Very poor")]VeryPoor, Poor, [Description("Middle class")]MiddleClass, Rich, [Description("Very rich")]VeryRich, Noble, Royal, Count}; // if the char was poor or rich 
	public BgUpgring bgUpbring;


	public float charLoyalty; 
	public float charLove;
	public float charCorruption; 
	public float charRelationship;


	public float[] charAddictions = new float[8]; // tobacco, alcohol, devil, dust, blue cap shrooms, hero, semen


	//system
	public int charCD;




	//By mammal we mean they live in land actually, not actual mammal's 
	//moved lizard from between equine and lion
	public enum CharRace{Human, FURRYOPEN, /*2*/Wolf, Bunny, Feline, Equine, Lion, Mouse, Rodent, Fox, /*10*/Deer, wallaby, FURRYCLOSE, AVIANOPEN, /*13*/Dodo, Hawk, Crow, Lovebird, AVIANCLOSE, AQUATICOPEN/*18*/, Shark, Dolphine, Kraken, AQUATICCLOSE, EXOTICOPEN, [Description("Goo girl")]GooGirl, Phantom, 
		Undead, Lich, Naga/*30*/, Pixie, Giant, Vampire, succubus/*34*/, incubus, centaur,/*36*/ dragon, golem, angel, drider/*40*/, doll, ant, gargoyle, goblin, harpy, holstaur,Plant, bee, imp, kobold/*50*/, kraken, [Description("living statue")]LivingStatue, [Description("LivingArmour")]LivingArmour, medusa, mermaid,/*55*/ minotaur, mummy, ogre,
		oni, /*60*/satyr, scylla, skeleton, troll, valkyrie, Hybrid, Lizard, Baphomet, /*67*/ Elf, EXOTICCLOSE}



	public CharRace charRace; 

	public enum HeadType{[Description("human")]HUMAN, [Description("wolf")]WOLF, [Description("bunny")]BUNNY, [Description("feline")]FELINE, [Description("plant")]PLANT, [Description("equine")]EQUINE, [Description("avian")]AVIAN, [Description("lizard")]LIZARD, [Description("lion")]LION, [Description("fox")]FOX, [Description("mouse")]MOUSE, [Description("deer")]DEER, dodo, wallaby, bull, dragon};
	public HeadType headType;



	public enum CharFurColor{Gray, [Description("snow white")]SnowWhite, white, brown, black, pink, Orange, blue, [Description("Dark chocolate")]DarkCholocate, [Description("black and white")]BlackWhite,
		[Description("yellow ocher")]YellowOcher, [Description("dark red")]DarkRed, Purple, khaki, Count
	
	}; 
	public CharFurColor charFurColor; 

	public enum CharFeatherColor{Gray, [Description("snow white")]SnowWhite, white, brown, black, pink, blue, [Description("Dark chocolate")]DarkCholocate, [Description("black and white")]BlackWhite,
		[Description("yellow ocher")]YellowOcher, [Description("dark red")]DarkRed, Purple, khaki, Count
	};
	public CharFeatherColor charFeatherColor;

	public enum CharSkinColor{fair, [Description("pale white")]paleWhite, brown, [Description("dark brown")]darkBrown, black, olive, /*6*/blue,/*7*/ red, /*8*/green /*8*/, bluedark, purple, [Description("pale blue")]paleBlue, [Description("dark blue")]darkBlue, pink, [Description("light blue")]lightBlue, [Description("light green")]lightGreen, [Description("black and red")]blackRed,
		[Description("black and purple")]blackPurple, [Description("porcelain white")]porcelainWhite, Count
	};
	public CharSkinColor charSkinColor; 

	public enum CharSkinType{Human, Demon, Porcelain, dragon, Count
	};
	public CharSkinType charSkinType; 


	//{"human", "wolf", "bunny", "feline","plant",  "equine" , "avian", "lizard", "lion", "fox"};
	public enum DickType{human, wolf, equine, fox, lion, demon, dragon
	};
	public DickType dickType; 

	public enum LowerBack{NONE, wolf, bunny, feline, plant, equine, avian, lizard, lion, fox, rodent, [Description("deer")]deer, demon, wallaby, baphomet, bull, dragon, Count}
	public LowerBack lowerBack;

	/*
	public enum TailType{NONE, wolf, dodo, bunny, equine};
	public TailType tailType; 
	*/

	//", "angel wings", "demon wings", "dragon wings", "bird wings", "mosquito wings", "pixie wings", "gargoyle wings"};
	public enum ShoulderBlades{NONE, [Description("angel wings")]AngelWings, [Description("demon wings")]DemonWings, [Description("dragon wings")]DragonWings, [Description("avian wings")]AvianWings,
		[Description("mosquito wings")]MosquitoWings, [Description("pixie wings")]PixieWings, [Description("gargoyle wings")]GargoyleWings, Count
	
	
	};
	public ShoulderBlades shoulderBlades; 

	public enum ArmsType{[Description("human arms")]HUMAN, [Description("wolf arms")]WOLF, [Description("bunny arms")]BUNNY, [Description("feline arms")]FELINE, [Description("plant arms")]PLANT, [Description("equine arms")]EQUINE, [Description("avian wings")]AVIAN, [Description("lizard claws")]LIZARD, [Description("lion claws")]LION, [Description("fox arms")]FOX, [Description("mouse arms")]MOUSE, [Description("deer arms")]DEER, [Description("harpy wings")]harpywings, [Description("Baphomet Claws")] BAPHOMETCLAWS,[Description("dragon claws")]dragonclaws};
	public ArmsType armsType;

	public enum LegsType{[Description("human")]HUMAN, [Description("pawns and wolf")]WOLF, [Description("paws and bunny")]BUNNY, [Description("paws and feline")]FELINE, [Description("plant")]PLANT, [Description("hooves and equine")]EQUINE, [Description("harpy")]AVIAN, [Description("reptile")]LIZARD, [Description("paws and lion")]LION, [Description("pawns and fox")]FOX, [Description("paws and mouse")]MOUSE, [Description("hoves and deer")]DEER, harpy, [Description("hoves and bull")]hoves, [Description("dragon")]dragon};
	public LegsType legsType; 

	public enum HeadAccesory1{NONE, 
		[Description("small demonic horns")]DemonicHornsSmall, 
		[Description("demonic horns")]DemonicHorns,
		[Description("big demonic horns")]DemonicHornsBig, 
		/*Antlers, */
		[Description("minotaur horns")]MinotaurHorns, 
		[Description("colorful flowers")]ColorfulFlowers, 
		[Description("Baphomet horns")] BaphometHorns, 
		[Description("bull horns")]bullHorns, 
		[Description("deer antlers")]deerAntlers, 
		[Description("dragon horns")]dragonHorns, 
		Count
	};
	public HeadAccesory1 headAccesory1;


	public enum HeadAccesory2{NONE, [Description("spider eyes")]SpiderEyes, [Description("elf ears")]elfEars, [Description("demon ears")]demonEars, Count};
	public HeadAccesory2 headAccesory2;



	//{"no", "goatee", "ducktail", "van dyke", "chin churtain"
	public enum BeardStyle{NONE, goatee, ducktail,[Description("van dyke")]VanDyke, [Description("chin curtain")]ChinCurtain, Count };
	public BeardStyle beardStyle;

	//"no beard", "a short stubble", "a medium stubble", "a long stubble", "full beard", "long beard", "hip length beard" ,
	public enum BeardLength{NONE, [Description("short stubble")]ShortStubble, [Description("medium stubble")]MediumStubble, [Description("long stubble")]LongStubble, 
		[Description("full beard")]FullBeard, [Description("long beard")]LongBeard, [Description("hip lenght beard")]HipLength, Count };
	public BeardLength beardLength;


	//black", "red", "blonde", "brown", "auburn", "white"/*5*/, "gray", "chesnut", "yellow ochre", "blue", "pink"/*10*/, "green", "sky blue", "purple", "platinum
	public enum HairColor{pink, brown, blonde, black, [Description("light blue")]lightBlue, [Description("dark blue")]darkBlue, purple, [Description("dark brown")]darkBrown, auburn, platinum, Count,  white, gray, chesnut,[Description("yellow ochre")]yellowOchre, green};
	public HairColor hairColor;

	//"no", "pixie", "sassy", "bob", "mowhawk", "comb over", "curly bob", "pompadour", "braids", "twist and bun", "elegant bun", "manly bun", "long ponytails", "long curls"
	public enum HairStyle{disheveled, pixie, sassy, bob, mowhawk, [Description("comb over")]CombOver, [Description("curly bob")]CurlyBob, pompadour, braids, [Description("twist and bun")]twistbun /*9*/, 
		[Description("elegant bun")]ElegantBun, [Description("manly bun")]ManlyBun, [Description("long ponytails")]LongPonytails, [Description("plain long hair")]LongHair /*13*/, [Description("long curls")]LongCurls, bald, Count
	};
	public HairStyle hairStyle;

	public enum HairType{Normal, GooHair, Mane, Serpent, Count};
	public HairType hairType = HairType.Normal; 

	public float hairLengthCM; // is not used as display, just to calculate, where 130+ is as long as it gets, and 0 is shaven


	//{"bald", "shaven", "very short", "short", "shoulder", "above the shouler", "mid-back", "lower back", "Knee length", "Feet length", "overgrown"

	public enum HairLength{bald, shaven, [Description("very short")]VeryShort, [Description("short")]sshort, [Description("shoulder length")]shoulder, [Description("over the shoulder")]overshoulder, 
		[Description("mid back length")]midback, [Description("knee length")]kneelength, [Description("feet length")]feetLength, overgrown, Count
	};

	public HairLength hairLength;

	//this isnt now used as much as to define the type of eyes but just to define the model of the face
	public enum EyesType{[Description("human")]human0, [Description("human")]human1, lizard, 
		[Description("demon")]demon0, [Description("demon")]demon1, 
		dragon, cat, bird, feline, 
		[Description("wolf")]wolf0, [Description("wolf")]wolf1};
	public EyesType eyesType;


	//{"dark brown", "black", "blue", "green", "hazel", "gray"/*5*/, "purple", "yellow", "red", "pink", "pink with yellow star pupils"/*10*/, "yellow slitted cat"/*P*/ };
	public enum EyesColor{[Description("dark brown")]darkBrown, black, blue, green, [Description("light brown")]lightBrown, red, purple, yellow, white, pink /*9*/, /*hazel, gray, [Description("pink with yellow star pupils")]pinkStars,
		[Description("yellow slitted")]yellowSlitted,*/ Count
	};
	public EyesColor eyesColor;

	public bool hasFur; // everyone uses the fur colours tho
	public bool hasFeathers; 
	public bool hasScales;
	public bool hasTentacles;
	public bool isFlying;
	//special propeties


	//public ExoticRace exoticRace;  // 0 not,  1 gooGirl, 2 phantom, 3 undead, 4 mage, 5 lich, 6 naga, 7 pixie, 8 giant, 9 vampire, 10 succubus, 11 incubus, 12 centaur, 13 dragon, 14 golem, 15 angel, 
	//16 plant, 17 wildling human, 18 is arachnid, 19 doll, 20 ant, 21 gargoyle, 22 goblin, 23 harpy, 24 holstaur, 25 bee, 26 imp, 27 kobold, 28 kraken, 29 living statue, 30 living armour 
	// 31 medusa, 32 mermaid, 33 minotaur, 34 mummy, 35 ogre, 36 ANOTHER, 37 oni, 38 satyr, 39 scylla, 40 skeleton, 41 troll, 42 valkyrie


	// this defines the overal behavior of the person
	public enum GenderBehavior{[Description("very masculine")]VeryMasculine, masculine, androgynous, feminine, [Description("very feminine")]VeryFeminine}; //if it behaves more feminine or masculine 
	public GenderBehavior genderBehavior;
	public float genderBehaviorStat; // this is what sets the above, this can make a char more feminine or masculine after certain point


	// this defines how feminine or not is the face
	public enum FacialFeatures{[Description("very masculine")]VeryMasculine, masculine, androgynous, feminine, [Description("very feminine")]VeryFeminine};
	public FacialFeatures facialFeatures; 
	public float facialFeaturesStat; 

	// this define how masculine or not is the body
	public enum BodyFeatures{[Description("very masculine")]VeryMasculine, masculine, androgynous, feminine, [Description("very feminine")]VeryFeminine};
	public BodyFeatures bodyFeatures; 
	public float bodyFeaturesStat; 


	public float heightChar; // in cm
	public enum HeightName{[Description("minuscule")]Minuscule, [Description("tiny")]Tiny, [Description("petite")]Petite, [Description("very short")]VeryShort, [Description("short")]Short, [Description("average height")]Average, [Description("tall")]Tall, [Description("very tall")]VeryTall,  [Description("giant")]Giant, Count };
	public HeightName heightName; 

	public enum BodyPhysique{skinny, slender, thin, slim, average, curvy/*5*/, plump, chubby, [Description("extra chubby")]extraChubby, Count};
	public BodyPhysique bodyPhysique; 
	public float bodyPhysStat; // to change it

	public enum BodyBuild{puny, feeble, weak, average, toned, athletic/*5*/, beefy, muscular, hulking, Count};
	public BodyBuild bodyBuild; 
	public float bodyBuildStat; // to change it

	public string[] charTattoos; 
	//0 Forehead //1 left cheek //2 righ cheek //3 neck //4 upper chest  
	//5 left breast //6 right breast //7 belly //8 low belly //9 upper back
	//10 lower back //11 left arm //12 right arm  //13 left ass cheek //14 right ass cheek
	//15 left leg //16 right leg //17 anus


	public string[] charPiercings; // in a single line

	//0 Earl  //1 Left eyebrow //2 Right eyebrow //3 Left nostril //4 Right nostril
	//5 Septum Piercing //6 Left ear lobe  //7 right ear lobe //8 Lef ear helix //9 right ear helix  
	//10 left lip  //11 Right lip //12 Labret piercing  //13 Tongue piercing //14 upper lip frenum piercing
	//15 lower lip frenum piercing  //16 left nipple piercing //17 right nipple piercing  //18 Navel piercing //19 Dick piercing
	//20 clitoris piercing


	//genitals and fertility
	public bool hasKnot; 
	public bool hasVagina; 
	public bool isVirgin; 
	public bool isFertile; 
	public bool isPregnant; 
	public NPCData.CharRace childRace; 
	public int pregnantCD; // turns until giving birth
	public string pregnantText; // 
	public bool isLactating;
	public float lactationML; // how much it lactates in ml
	public float charFertility; 


	public int dickNum; //how many dicks it has
	public enum DickSize{NONE, tiny, small, average, big, [Description("very big")]veryBig, enormous, [Description("arm length")]armLength, [Description("horse length")]horseLength, humongous}; 
	public DickSize dickSize; 
	public float dickSizeCM; // in cm

	//"small like grapes ", "average size", "big as chestnuts", "big as apples", "big as grapefruits", "big as melons", "big as watermelons"
	public enum TesticleSize{NONE, [Description("small like grapes")]smallgrapes, [Description("average size")]averageSize, [Description("big as chestnuts")]bigchestnuts, [Description("big as apples")]bigapples,
		[Description("big as grapefruits")]bigGrapefruits, [Description("big as melons")]bigMelons, [Description("big as watermelons")]bigWatermelon, Count
	
	};
	public TesticleSize testiclesSize; // in cm, used to determine if you have or not
	public float testicleSizeCM; 

	public float clitorisSize; // in cm



	public int breastRow; 
	public float breast1Size; // to determine its current size. Each 10 points is +1 cup, each X changes name, check NPCSettler
	public float breast2Size; // 

	// "flat", "very small", "small", "regular", "ample", "full"/*5*/, "big", "plump", "vast", "enormous", "gigantic"
	public enum BreastName{flat, [Description("very small")]verySmall, small, regular, ample, full, big, plump, vast, enormous, gigantic, Count
	
	};
	public BreastName breast1Name;
	public BreastName breast2Name; 

	public enum BreastCup{AA /*0*/, A, B, BB, C, CC /*5*/, D, DD, E, EE, F/*10*/, FF, G, GG, H, HH/*15*/, HHH, I, II, III, J /*20*/, JJ, JJJ, K, KK, L, LL, LLL, M, MM, MMM/*30*/, N, NN, NNN, O, OO, OOO, P, PP, PPP, Q/*40*/, QQ, QQQ, R, RR, RRR, S, SS, SSS, T, TT/*50*/, TTT, U, UU, UUU, V, VV, VVV, W, WW, WWW/*60*/, X, XX, XXX, Y, YY, YYY, Z, ZZ, ZZZ/*69*/};
	public BreastCup breast1Cup;
	public BreastCup breast2Cup;


	public float areola1Size; // aerola size of the first row, 1 change, in cm
	public float areola2Size; // aerola size of the first row, 1 change, in cm

	public enum VagLoose{virgin, verythight, thight, loose, veryloose};
	public VagLoose vagLoose; 

	public float vagLooseness; // 0 virgin, 1-5 etc 

	//string assname, int asssize, string hipsname, int hipssize, string waistname, int wasitsize 

	public enum AssName{[Description("non existant")]nonexistant, flat, [Description("very small")]verysmall, small, average, ample/*5*/, full, big, plump, vast, enormous /*10*/, gigantic};
	public AssName assName; 
	public float assSize; 


	public enum HipsName{petite, tiny, slim, small, average, large /*5*/, ample, big, huge, vast, cowlike /*10*/, gigantic};
	public HipsName hipsName; 
	public float hipsSize; 

	public enum WaistName{petite, tiny, slim, small, average, large /*5*/, ample,  big, huge, [Description("very wide")]veryWide, enormous /*10*/, immense};
	public WaistName waistName; 
	public float waistSize; 


	// combat
	public float maxHealth;
	public float currentHealth; 

	public float maxArousal; 
	public float currentArousal; 

	public float maxMP;
	public float currentMP; 

	public float charCombatAttack = 1f; // it is calculated by its attributes, equipment and traits 
	public float charLustAttack = 1f; 
	public float charCombatDefense;
	public float charLustDefense;
	public float charMagicDefense; 
	public float charDodge; 

	// add EQUIPMENT, COM AND LUST DEF TOO 
	public int[] charEquipment;

	// power and politics  // goes from -1000 to 1000 both of them
	public float charReputation; 
	public float politicalPower;


	public float[] evidenceValue = new float[3];
	public string[] evidenceText = new string[3];

	public float charInformation; // this determines how much you have spied of them, unlocking more knowledge and info about them. It increases with relationship or spies. 0 to 100




	public NPCData(int charid, int charportrait, string charname, string charnickname, string charsurname, CharSex charsex, int corruptionstage, int slavestage, CharGender chargender, CharAge charage, CityFaction cityfaction,
		
		bool isrecruited, bool isenemy, bool ismonster, bool isneutral, bool isprisoner, bool isslave, bool isbroken,  float chargold, float charvalue, bool isfurry, bool isfuta, float attphysical, float attmental, float attsocial  ,
		float attmagicpower, float attbeauty, float atttemperament, float attwillpower, float attnature, float attopenness, float attdignity, float attobedience, float atthappiness, float attlibido, float attmorality,
		float attpiety, float attstyle, CharRank charrank, CharPersonality charpersonality, CharFetish charfetish, CharClass charclass, Jobs cityposition, float coremartial, float coresecurity,
		float corelabor, float coretactics, float coregovernance, float corestewardship, float corepersuasion, float coreintrigue, float corediplomacy, float utilitycraft, float utilityhouse , 
		float utilityfarm, float utilitymedicine, float utilityalchemy, float utilitylearning, float utilityperformance, float utilityetiquette, float utilitystreetwise, float sexmasseuse,
		float sexstripping, float sexbondage, float sexpetplay, float sexpetting, float sexgroupsex, float sexdemonstration, float sexwhoring, float sexescorting,  BgAdulthood bgadult, BgChildhood bgchild ,
		string[] bgstory, BgUpgring bgupbring, float charloy, float charlove, float charcorruption, float charrelation, float[] charaddictions, int charcd, CharRace charrace, HeadType  headtype, CharFurColor charfurcolor, CharFeatherColor charfeathercolor ,
		CharSkinColor charskincolor, CharSkinType charskintype, DickType dicktype, LowerBack lowerback, ShoulderBlades shoulderblades, ArmsType armstype, LegsType legstype, BeardStyle beardstyle, BeardLength beardlength, HeadAccesory1 headacc1, HeadAccesory2 headacc2 ,
		HairColor haircolor, HairStyle hairstyle, HairType hairtype, float hairlenghtcm, HairLength hairlength, EyesType eyestype, EyesColor eyescolor, bool hasfur, bool hasfeathers, bool hasscales, bool hastentacles, bool isflying ,
		GenderBehavior genderbehavior, float genderbehstat, FacialFeatures facialfeatures, float facialfeatstat, BodyFeatures bodyfeatures, float bodyfeatstat, float heigthchar, HeightName heigthname, BodyPhysique bodyphys ,
		float bodyphystat, BodyBuild bodybuild, float bodybuildstat, bool hasknot, bool hasvagina, bool isvirgin, bool isfertile, bool ispregnant, int pregcd, string pregtext, bool islactating, float charfertility, CharRace childrace,
		float lactationml, int dicknum, DickSize dicksize, float dicksizecm,  TesticleSize testiclesize, float testiclesizecm, float clitorissize, int breastrow, float breast1size, float breast2size, BreastName breast1name,
		BreastName breast2name, BreastCup breast1cup, BreastCup breast2cup, float areola1size, float areola2size, VagLoose vagloose, float vaglooseness, AssName assname, float asssize, HipsName hipsname, float hipssize, WaistName waistname,
		float waistsize, float maxhealth, float currenthealth, float maxarousal, float currentarousal, float maxmp, float currentmp,
		/*int[] charequip,*/ float charreputation, float politicalpower, float charinfo 


	)
	{

	

		isMarried = new List<NPCFamily> ();
		isParent = new List<NPCFamily> ();
		isProgeny = new List<NPCFamily>(); // list of its two parents
		charTraits = new List<CharTraits>();
		charAttacks = new List<CharAttacks> ();
		charTitles = new List<Titles> ();
		charID = charid; 
	
		charPortraitLayer0 = charportrait;
		charName = charname; 
		charNickname = charnickname;
		charSurname = charsurname;
		charSex = charsex; 
		corruptionStage = corruptionstage;
		slaveStage = slavestage;
		charGender = chargender;
		charAge = charage; 
		cityFaction = cityfaction; 
		isRecruited = isrecruited; 
		isEnemy = isenemy;
		isMonster = ismonster;
		isNeutral = isneutral;
		isPrisoner = isprisoner;
		isSlave = isslave;
		isBroken = isbroken; 
		charGold = chargold; 
		charValue = charvalue;
		isFurry = isfurry;
		isFuta = isfuta;

		attPhysical = attphysical;
		attMental = attmental;
		attSocial = attsocial;
		attMagicPower = attmagicpower;
		attBeauty = attbeauty;
		attTemperament = atttemperament;
		attWillpower = attwillpower;
		attNature = attnature;
		attOpenness = attopenness;
		attDignity = attdignity;
		attObedience = attobedience;
		attHappiness = atthappiness;
		attLibido = attlibido;
		attMorality = attmorality; 
		attPiety = attpiety;
		attStyle = attstyle;
		charRank = charrank; 
		charPersonality = charpersonality;
		charFetish = charfetish; 
		charClass = charclass;
		cityJobs = cityposition;

		coreSkillMartial = coremartial; //0
		coreSkillSecurity = coresecurity;
		coreSkillLabor = corelabor;
		coreSkillTactics = coretactics; 
		coreSkillGovernance = coregovernance;
		coreSkillStewardship = corestewardship;
		coreSkillPersuasion = corepersuasion;
		coreSkillIntrigue = coreintrigue;
		coreSkillDiplomacy = corediplomacy; //8


		utilitySkillCrafting = utilitycraft; 
		utilitySkillHouseKeeping = utilityhouse; 
		utilitySkillFarmHand = utilityfarm; 
		utilitySkillMedicine = utilitymedicine;
		utilitySkillAlchemy = utilityalchemy;
		utilitySkillLearning = utilitylearning;
		utilitySkillPerformance = utilityperformance;
		utilitySkillEtiquette = utilityetiquette;
		utilitySkillStreetwise = utilitystreetwise;


		sexSkillMasseuse = sexmasseuse;
		sexSkillStripping = sexstripping; 
		sexSkillBondage = sexbondage;
		sexSkillPetplay = sexpetplay;
		sexSkillPetting = sexpetting;
		sexSkillGroupSex = sexgroupsex;
		sexSkillPenetration = sexdemonstration;
		sexSkillWhoring = sexwhoring;  
		sexSkillEscorting = sexescorting; 

		bgAdulthood =bgadult;
		bgChildhood = bgchild; 
		bgStory =  bgstory;  // childhood, young adulthood, current
		bgUpbring = bgupbring;

		charLoyalty = charloy; 
		charLove = charlove; // how much it loves the MC 
		charCorruption = charcorruption; 
		charRelationship = charrelation;

		charAddictions = charaddictions; // alcohol, tobacco, opium, coke, shrooms, hero, semen

		charCD = charcd;

		charRace = charrace; 
		headType = headtype; 
		//tailType = tailtype; 
		charFurColor = charfurcolor; 
		charFeatherColor = charfeathercolor;
		charSkinColor = charskincolor; 
		charSkinType = charskintype; 

		dickType = dicktype; 
		lowerBack = lowerback;
		shoulderBlades = shoulderblades; 
		armsType = armstype;
		legsType = legstype;
		beardStyle = beardstyle;
		beardLength = beardlength;
		headAccesory1 = headacc1;
		headAccesory2 = headacc2;

		hairColor = haircolor;
		hairStyle = hairstyle;
		hairType = hairtype; 
		hairLengthCM = hairlenghtcm; 
		hairLength = hairlength;
		eyesType = eyestype; 
		eyesColor = eyescolor;

		hasFur = hasfur;
		hasFeathers = hasfeathers; 
		hasScales = hasscales; 
		hasTentacles = hastentacles;
		isFlying = isflying;

		genderBehavior = genderbehavior;
		genderBehaviorStat = genderbehstat; // this is what sets the above, this can make a char more feminine or masculine after certain point

		facialFeatures = facialfeatures; 
		facialFeaturesStat = facialfeatstat; 

		bodyFeatures = bodyfeatures; 
		bodyFeaturesStat = bodyfeatstat; 

		heightChar = heigthchar; // in cm
		heightName = heigthname; 

		bodyPhysique = bodyphys; 
		bodyPhysStat = bodyphystat; // to change it

		bodyBuild = bodybuild; 
		bodyBuildStat = bodybuildstat; // to change it

		hasKnot = hasknot; 
		hasVagina = hasvagina; 
		isVirgin = isvirgin; 
		isFertile = isfertile; 
		isPregnant = ispregnant; 
		pregnantCD = pregcd; // turns until giving birth
		pregnantText = pregtext; //
		charFertility = charfertility; 
		isLactating = islactating;
		lactationML = lactationml; // how much it lactates in ml
		childRace = childrace;

		dickNum = dicknum; //how many dicks it has
		dickSize = dicksize; 
		dickSizeCM = dicksizecm; // in cm

		testiclesSize = testiclesize; // in cm, used to determine if you have or not
		testicleSizeCM = testiclesizecm; 

		clitorisSize = clitorissize; // in cm

		areola1Size = areola1size; // aerola size of the first row, 1 change, in cm
		areola2Size = areola2size; // aerola size of the first row, 1 change, in cm

		breastRow = breastrow;
		breast1Size = breast1size;
		breast2Size = breast2size;

		breast1Name = breast1name;
		breast2Name = breast2name;

		breast1Cup = breast1cup;
		breast2Cup = breast2cup; 

		vagLooseness = vaglooseness; // 0 virgin, 1-5 etc 

		assName = assname; 
		assSize = asssize;

		hipsName = hipsname; 
		hipsSize = hipssize; 

		waistName = waistname; 
		waistSize = waistsize; 

		maxHealth = maxhealth;
		currentHealth = currenthealth; 

		maxArousal = maxarousal; 
		currentArousal = currentarousal; 

		maxMP = maxmp;
		currentMP = currentmp; 


		charReputation = charreputation; 
		politicalPower = politicalpower;

		charInformation = charinfo;

		vagloose = vagLoose; 


	}




}
