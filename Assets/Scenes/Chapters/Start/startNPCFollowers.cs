using UnityEngine;
using System.Collections;

public class startNPCFollowers : MonoBehaviour {



	public static int switchIsChar = 0; // help to set if the char starts as a prisoner, slave, etc. // 0 neutral, 1 recruited, 2 enemy, 3 isprisonerplayer, 4 isprisoner enemy, 5 isslave
	// system to build
	int randNum;
	int randNum2; 
	int hashcode;
	string completeName;
	int i;
	int x;
	int raceID; // this is just a control, it helps define at the start if its going to be a human, monstergirl or exotic

	Parser parser = new Parser();

	int charID;  // id thats going to be used to look for him, should use a genNPC control for this
	string charName;  
	int charGender; //0 female, 1 male, 2 dickgirl, 3 futa, 4 hermale
	bool isRecruited; //these 5 will define whats his position in the world
	bool isEnemy;
	bool isNeutral;
	bool isPrisonerPlayer;
	bool isPrisonerEnemy;
	bool isSlave;
	bool isFriend;
	bool isLover;
	bool isFurry;
	bool isFuta;
	int attPhysical;  
	int attMental; 
	int attSocial; 
	int skillMartial;
	int skillSecurity;
	int skillLabor;
	int skillTactics; 
	int skillGovernance;
	int skillStewardship;
	int skillPersuasion;
	int skillIntrigue;
	int skillDiplomacy;
	int backgroundPast;  //this is an attribute related to its past, like "Veteran" or "clerk", give bonuses to certain jobs

	int backgroundChild; 





	string backgroundStory;  // generic text for its past
	int charTrait1; 
	int charTrait2;
	int charFlaw1;
	int charFlaw2; 

	string charTrait1Name;
	string charTrait2Name;
	string charFlaw1Name;
	string charFlaw2Name;

	// // // //
	int charLoyalty; 
	int charCorruption; 
	string charPosition; 


	int charRelationship;
	string charPersonality; 
	int charPersonalityID; 
	string charFetish;
	int charFetishID; 
	int charSubmission; 
	int charClassType; // which class it is. // 0 soldier, warrior, 1 clerk, 2 bureaucrat, 3 monk/nun, 4 priest, 5 alchemist, 6 mystic, 7 thief, 8 infiltrator, 9 paladin, 10 dark paladin, 11 feral, 12 barbarian 
	//13 scout, 14 ranger, 15 community worker, 16 whore, 17 farmer, 18 industry worker, 19 politician, 20 diplomat, 21 inquisitor, 22 enforcer
	string charClassTypeName; // the string for it...

	//system
	int charCD;

	//appearance - head and general, accesories
	string charAppRace; 
	string charAppFurColor;
	string charAppFeatherColor;
	string charAppSkinColor;
	string charAppSkinType; 
	string dickType; //race 
	string lowerBack; 
	string shoulderBlades; 
	string beardStyle; 
	string headAccesory1; 
	string headAccesory2; 
	string hairColor;
	string hairStyle; 
	string hairName; 
	string eyesType;
	string eyesColor;
	bool hasFur;
	bool hasFeathers; 

	bool hasTentacles;
	bool isFlying;
	//special propeties

	int isExotic; // 0 normal/nonspecial,  1 gooGirl, 2 phantom, 3 undead, 4 mage, 5 lich, 6 naga, 7 pixie, 8 giant, 9 vampire, 10 succubus, 11 incubus, 12 centaur, 13 dragon, 14 golem, 15 angel, 
	//16 plant, 17 wildling human, 18 is arachnid, 19 doll, 20 ant, 21 gargoyle, 22 gobling, 23 harpy, 24 holstaur, 25 bee,26 imp, 27 kobold, 28 kraken, 29 living statue, 30 living armour 
	// 31 medusa, 32 mermaid, 33 minotaur, 34 mummy, 35 ogre, 36 ogre, 37 oni, 38 satyr, 39 scylla, 40 skeleton, 41 troll, 42 valkyrie


	string appfemininity; 
	int appfemininityStat; // this is how femenine it face is, it can change, if it does it changes the string above 
	string appfemininityFace;
	int appfemininityFaceStat; // this is how femenine it behaves, it can change, if it does it changes the string above
	int appGender;
	int heightChar; // in cm
	string heightName; //petite, trap, giant, normal
	string bodyPhisique; // slim, chubby, etc.
	int bodyPhysStat; // to change it
	string bodyBuild; // weak, strong, etc
	int bodyBuildStat; // to change it

	string appTattoo; // in a single line goes all the tattooes
	string appPierciengs; // in a single line



	//genitals and fertility
	bool hasKnot; 

	int dickNum; //how many dicks it has
	string dickName; //small, big, etc
	int dickSize; // in cm
	int testiclesSize; // in cm, used to determine if you have or not
	string testiclesName; //small, big, etc.
	int clitorisSize; // in cm
	bool hasVagina; 
	bool isVirgin; 

	int breastRow; 
	int breast1Size; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler
	string breast1Name; // flat, small, etc.
	string breast1Cup; // AA, A, B
	int breast2Size; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler
	string breast2Name; // flat, small, etc.
	string breast2Cup; // AA, A, B
	float nipple1Size; // aerola size of the first row, 1 change, in cm
	float nipple2Size; // aerola size of the first row, 1 change, in cm
	int vagLooseness; // 0 virgin, 1-5 etc 
	bool isPregnant; 
	int pregnantCD; // turns until giving birth
	string pregnantText; // 


	//string assname, int asssize, string hipsname, int hipssize, string waistname, int wasitsize 

	string assName; // determines the name in game
	int assSize; // determines the size
	string hipsName;
	int hipsSize;
	string waistName; 
	int waistSize; 

	float maxHealth;
	float maxArousal; 
	float initialArousal;


	// service
	int serviceWhoring; 

	int charReputation; 

	int blackmailEvidenceCount; // this determines how much evidence you have to blakmail them, from 0 up to 3 top
	int blackmailEv1Value;
	int blackmailEv2Value;
	int blackmailEv3Value;

	string blackmailEv1; //The evidence line used 
	string blackmailEv2; // 
	string blackmailEv3; // 
	int charInvestigation; // this determines how much you have spied of them, unlocking more knowledge about them. It increases with relationship or spies. 0 to 100

	int equipArmorID; // this will be used to drop the loot
	string equipArmorDescription; // text used for in game, could be just the name of the item but it would be better to add a special description

	int equipWeaponID; 
	string equipWeaponDescription;

	string charFaction;
	string backgroundPastText;
	string backgroundChildText;
	int politicalPower;
	int isMarriedID = 0;


	//followers
	int corruptionStage;
	int slaveStage = 0;


	public void setChar(){
		/*

		NPCCharList.CharList.Add (new NPCData (	charID,  charName,  charGender,  isRecruited,  isEnemy,  isNeutral,  isPrisonerPlayer,  isPrisonerEnemy, isSlave, isFriend, isLover, isFurry, isFuta,  attPhysical,  attMental,  attSocial, skillMartial,  skillSecurity,  skillLabor,  skillTactics,  skillGovernance,  skillStewardship,  skillPersuasion, 
			skillIntrigue,  skillDiplomacy,   backgroundPast, backgroundChild, backgroundStory, charTrait1, charTrait2, charFlaw1, charFlaw2,  charLoyalty, charCorruption, charPosition, charTrait1Name, charTrait2Name, charFlaw1Name, charFlaw2Name, charRelationship, charPersonality, charPersonalityID, charFetish, charFetishID, charSubmission, charClassType, charClassTypeName, charCD, charAppRace, charAppFurColor, charAppFeatherColor, charAppSkinColor, charAppSkinType, dickType, lowerBack, shoulderBlades,  beardStyle, headAccesory1, headAccesory2, hairColor, hairStyle, hairName, 
			eyesType, eyesColor, hasFur, hasFeathers, hasTentacles, isFlying, isExotic,  appfemininity, appfemininityStat, appfemininityFace, appfemininityFaceStat, appGender, heightChar, heightName, bodyPhisique, bodyPhysStat, bodyBuild, bodyBuildStat,appTattoo, 
			appPierciengs, hasKnot, dickNum, dickName, dickSize, testiclesSize, testiclesName, clitorisSize, hasVagina, isVirgin, breastRow, breast1Size, breast1Name, breast1Cup, breast2Size, breast2Name, breast2Cup, nipple1Size, nipple2Size, vagLooseness, isPregnant,
			pregnantCD, pregnantText, assName, assSize, hipsName, hipsSize, waistName, waistSize, maxHealth, maxArousal, initialArousal, serviceWhoring, charReputation, blackmailEvidenceCount,  blackmailEv1Value,  blackmailEv2Value,  blackmailEv3Value, blackmailEv1, blackmailEv2, blackmailEv3, charInvestigation, equipArmorID, equipArmorDescription, equipWeaponID, equipWeaponDescription, charFaction,  backgroundPastText, backgroundChildText, politicalPower, isMarriedID, corruptionStage, slaveStage));
*/
	}


	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	public void setHelena(){
		charCorruption = 25;
		charLoyalty = 70;
		maxHealth = 100;
		maxArousal = 100;
		initialArousal = 0;
		charSubmission = 35; 
		charRelationship = 20;
		isFriend = false;
		isLover = false;
		charCD = 0;
		corruptionStage = 1;

		politicalPower = 30;

		isFurry = false;
		isFuta = false; 

		//this sets the race for the setRace();
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 23); 
		raceID = Random.Range (0, 100);
		hashcode = GameControl.playerName.GetHashCode ();  

		charID = 3050;

		isNeutral = false;
		isRecruited = true;
		isEnemy = false;
		isPrisonerPlayer= false;
		isPrisonerEnemy = false;
		isSlave = false; 


		appfemininity = "feminine";
		appfemininityFace = "feminine";
		/*
		hashcode = GameControl.playerName.GetHashCode ();  
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond); 
		randNum = Random.Range (0, 100);
		*/
		charGender = 0;

		charClassType = 23;
		charClassTypeName = "Maid";


		attPhysical = 45;

		attMental = 75;

		attSocial = 55; 

		backgroundPast = 26; //steward assistant

		backgroundChild = 11; // young maid

		backgroundPastText = "steward for a nobleman";
		backgroundChildText = "young maid";

		charTrait1 = 7;

		charTrait1Name = "Disciplined";

		charTrait2 = 8;

		charTrait2Name = "Humble";




		charFlaw1 = 12;

		charFlaw1Name = "Craven";

		charFlaw2 = 15;

		charFlaw2Name = "Shy";

		charPersonalityID = 3;
		charPersonality = "Kind";


		charFetishID = 7;
		charFetish = "Exhibitionist";


		charLoyalty = 50; 

		charCorruption = 25;


		charPosition = "not working"; 


		charAppRace = "Human";

		charName = "Helena";


		charAppFurColor= "";
		charAppFeatherColor = "";
		charAppSkinType= "human"; 
		hasFur = false; 
		hasFeathers = false; 
		hasTentacles = false; 
		isFlying = false; 
		isExotic = 0; 
		hasKnot = false; 
		breastRow = 1;
		isPregnant = false; 
		pregnantText = "";
		lowerBack= ""; 
		shoulderBlades= ""; 
		headAccesory1= ""; 
		headAccesory2= ""; 
		eyesType= "normal";

		dickType= "human"; 
		beardStyle= "no beard"; 
		dickNum= 0; 
		dickName= ""; 
		dickSize= 0; 

		testiclesSize= 0; 
		testiclesName= ""; 


		clitorisSize= 0; 
		hasVagina= true; 

		breastRow= 1; 
		breast1Size= 5; 
		breast1Name= "Regular"; 
		breast1Cup = "CC"; 
		breast2Size= 0;
		breast2Name= "";
		breast2Cup= ""; 
		nipple1Size= 3f;
		nipple2Size= 0f; 
		vagLooseness= 0; 
		isPregnant= false; 
		pregnantCD= 0; 
		pregnantText= ""; 

		appfemininityFaceStat = 17;
		appfemininityStat = 17;


		blackmailEvidenceCount = 0;
		blackmailEv1 = "";
		blackmailEv2 = "";
		blackmailEv3 = "";
		charInvestigation = 0;


		isVirgin = false;



		charAppSkinColor = "white"; 

		hairColor = "red head"; 

		hairStyle = "her usual"; 

		eyesColor= "blue";




		//////////////////////Generic, already adjusted by gender//////

		bodyBuildStat = 2;
		bodyBuild = "weak";

		bodyPhysStat = 3;
		bodyPhisique = "slim";

		appTattoo = "";
		appPierciengs = ""; 

		assSize = 4;
		assName = "regular";

		waistName = "slim";
		waistSize = 2;

		hipsName = "average";
		hipsSize = 3;


		heightName = "normal sized";

		heightChar = 163; 

		backgroundStory = "";

		charReputation = 30; 

		skillMartial = 12;

		skillSecurity = 28;

		skillLabor = 78;

		skillTactics = 42;

		skillGovernance = 15;

		skillStewardship = 82;

		skillPersuasion = 22;

		skillIntrigue = 38;

		skillDiplomacy = 53;

		charFaction = GameControl.playerName; 



		setChar ();


		 


	}


	////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	public void setAbbadon(){
		charCorruption = 15;
		charLoyalty = 30;
		maxHealth = 100;
		maxArousal = 100;
		initialArousal = 0;
		charSubmission = 0; 
		charRelationship = 0;
		isFriend = false;
		isLover = false;
		charCD = 0;
		corruptionStage = 1;
		politicalPower = 770;

		//this sets the race for the setRace();
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 23); 
		raceID = Random.Range (0, 100);
		hashcode = GameControl.playerName.GetHashCode ();  

		charID = 1050;

		isNeutral = false;
		isRecruited = false;
		isEnemy = false;
		isPrisonerPlayer= false;
		isPrisonerEnemy = false;
		isSlave = false; 

		isFurry = false;
		isFuta = false; 

		/*
		hashcode = GameControl.playerName.GetHashCode ();  
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond); 
		randNum = Random.Range (0, 100);
		*/
		charGender = 4;

		charClassType = 19;
		charClassTypeName = "Politician";


		attPhysical = 78;

		attMental = 63;

		attSocial = 44; 


		appfemininity = "somewhat masculine";
		appfemininityFace = "feminine";



		backgroundPast = 23; //governor assistant
		backgroundPastText = "Court member";


		backgroundChild = 21; // young maid
		backgroundChildText = "Nobleman son";


		charTrait1 = 5;

		charTrait1Name = "Impaler";

		charTrait2 = 10;

		charTrait2Name = "Brave";




		charFlaw1 = 0;

		charFlaw1Name = "Bloodthirsty";

		charFlaw2 = 10;

		charFlaw2Name = "Proud";

		charPersonalityID = 4;
		charPersonality = "Harsh";


		charFetishID = 2;
		charFetish = "Anal whore";




		charCorruption = 25;


		charPosition = "Faction Leader"; 


		charAppRace = "Human";

		charName = "Abbadon";

		charAppFurColor= "";
		charAppFeatherColor = "";
		charAppSkinType= "human"; 
		hasFur = false; 
		hasFeathers = false; 
		hasTentacles = false; 
		isFlying = false; 
		isExotic = 0; 
		hasKnot = false; 
		breastRow = 1;
		isPregnant = false; 
		pregnantText = "";
		lowerBack= ""; 
		shoulderBlades= ""; 
		headAccesory1= ""; 
		headAccesory2= ""; 
		eyesType= "normal";

		dickType= "human"; 
		beardStyle= "no beard"; 
		dickNum= 0; 
		dickName= ""; 
		dickSize= 0; 

		testiclesSize= 0; 
		testiclesName= ""; 


		clitorisSize= 0; 
		hasVagina= true; 

		breastRow= 1; 
		breast1Size= 0; 
		breast1Name= "Flat"; 
		breast1Cup = "AA"; 
		breast2Size= 0;
		breast2Name= "";
		breast2Cup= ""; 
		nipple1Size= 3f;
		nipple2Size= 0f; 
		vagLooseness= 1; 
		isPregnant= false; 
		pregnantCD= 0; 
		pregnantText= ""; 

		appfemininityFaceStat = 16;
		appfemininityStat = 5;

		blackmailEvidenceCount = 0;
		blackmailEv1 = "";
		blackmailEv2 = "";
		blackmailEv3 = "";
		charInvestigation = 0;


		isVirgin = false;



		charAppSkinColor = "white"; 

		hairColor = "black"; 

		hairStyle = "his usual"; 

		eyesColor= "brown";




		//////////////////////Generic, already adjusted by gender/////////////////////////////////////////////////////////////////////////

		bodyBuildStat = 4;
		bodyBuild = "toned";

		bodyPhysStat = 3;
		bodyPhisique = "slim";

		appTattoo = "";
		appPierciengs = ""; 

		assSize = 4;
		assName = "regular";

		waistName = "petite";
		waistSize = 0;

		hipsName = "petite";
		hipsSize = 0;


		heightName = "petite";

		heightChar = 148; 

		backgroundStory = "";

		charReputation = 570; 

		skillMartial = 82;

		skillSecurity = 36;

		skillLabor = 18;

		skillTactics = 22;

		skillGovernance = 85;

		skillStewardship = 48;

		skillPersuasion = 32;

		skillIntrigue = 28;

		skillDiplomacy = 43;



		setChar ();



		charFaction = GameControl.playerName; 

		 


	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	public void setMisaki(){
		charCorruption = 60;
		charLoyalty = 20;
		maxHealth = 100;
		maxArousal = 100;
		initialArousal = 0;
		charSubmission = 10; 
		charRelationship = 12;
		isFriend = false;
		isLover = false;
		charCD = 0;
		corruptionStage = 3;

		isFurry = true;
		isFuta = false; 

		politicalPower = 0;

		//this sets the race for the setRace();
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 23); 
		raceID = Random.Range (0, 100);
		hashcode = GameControl.playerName.GetHashCode ();  

		charID = 4050;

		isNeutral = false;
		isRecruited = false;
		isEnemy = false;
		isPrisonerPlayer= false;
		isPrisonerEnemy = false;
		isSlave = false; 

		/*
		hashcode = GameControl.playerName.GetHashCode ();  
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond); 
		randNum = Random.Range (0, 100);
		*/
		charGender = 0;

		charClassType = 7;
		charClassTypeName = "Thief";


		attPhysical = 53;

		attMental = 33;

		attSocial = 87; 


		appfemininity = "very feminine";
		appfemininityFace = "very feminine";



		backgroundPast = 30; //governor assistant
		backgroundPastText = "Whore";


		backgroundChild = 46; // young maid
		backgroundChildText = "Tribal family";


		charTrait1 = 11;

		charTrait1Name = "Seducer";

		charTrait2 = 1;

		charTrait2Name = "Vigorous";




		charFlaw1 = 11;

		charFlaw1Name = "Deceitful";

		charFlaw2 = 7;

		charFlaw2Name = "Greedy";

		charPersonalityID = 0;
		charPersonality = "Pervert";


		charFetishID = 3;
		charFetish = "Group sex";




		charPosition = "Innkeeper"; 


		charAppRace = "Fox";

		charName = "Misaki";

		charAppFurColor= "Auburn";
		charAppFeatherColor = "";
		charAppSkinType= "human"; 
		hasFur = true; 
		hasFeathers = false; 
		hasTentacles = false; 
		isFlying = false; 
		isExotic = 0; 
		hasKnot = true; 
		breastRow = 1;
		isPregnant = false; 
		pregnantText = "";
		lowerBack= "four fox tails"; 
		shoulderBlades= ""; 
		headAccesory1= ""; 
		headAccesory2= ""; 
		eyesType= "normal";

		dickType= "canine"; 
		beardStyle= "no beard"; 
		dickNum= 0; 
		dickName= ""; 
		dickSize= 0; 

		testiclesSize= 0; 
		testiclesName= ""; 


		clitorisSize= 0; 
		hasVagina= true; 

		breastRow= 1; 
		breast1Size= 11; 
		breast1Name= "Big"; 
		breast1Cup = "FF"; 
		breast2Size= 0;
		breast2Name= "";
		breast2Cup= ""; 
		nipple1Size= 3f;
		nipple2Size= 0f; 
		vagLooseness= 2; 
		isPregnant= false; 
		pregnantCD= 0; 
		pregnantText= ""; 

		appfemininityFaceStat = 20;
		appfemininityStat = 20;

		blackmailEvidenceCount = 0;
		blackmailEv1 = "";
		blackmailEv2 = "";
		blackmailEv3 = "";
		charInvestigation = 0;


		isVirgin = false; // as false as you can get



		charAppSkinColor = "white"; 

		hairColor = "brown"; 

		hairStyle = "her usual"; 

		eyesColor= "red";




		//////////////////////Generic, already adjusted by gender/////////////////////////////////////////////////////////////////////////

		bodyBuildStat = 4;
		bodyBuild = "toned";

		bodyPhysStat = 5;
		bodyPhisique = "curvy";

		appTattoo = "";
		appPierciengs = ""; 

		assSize = 6;
		assName = "full";

		waistName = "slim";
		waistSize = 2;

		hipsName = "large";
		hipsSize = 4;


		heightName = "regular size";

		heightChar = 179; 

		backgroundStory = "";

		charReputation = -18; 

		skillMartial = 32;

		skillSecurity = 81;

		skillLabor = 12;

		skillTactics = 12;

		skillGovernance = 35;

		skillStewardship = 18;

		skillPersuasion = 89;

		skillIntrigue = 78;

		skillDiplomacy = 23;



		setChar ();



		charFaction = GameControl.playerName; 

		 


	}


	////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	public void setYoshika(){
		charCorruption = 78;
		charLoyalty = 75;
		maxHealth = 150;
		maxArousal = 80;
		initialArousal = 0;
		charSubmission = 60; 
		charRelationship = 18;
		isFriend = false;
		isLover = false;
		charCD = 0;
		politicalPower = 120;
		corruptionStage = 3;
		slaveStage = 0; 

		isFurry = true;
		isFuta = false; 

		//this sets the race for the setRace();
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 23); 
		raceID = Random.Range (0, 100);
		hashcode = GameControl.playerName.GetHashCode ();  

		charID = 5050;

		isNeutral = false;
		isRecruited = false;
		isEnemy = false;
		isPrisonerPlayer= false;
		isPrisonerEnemy = false;
		isSlave = false; 

		/*
		hashcode = GameControl.playerName.GetHashCode ();  
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond); 
		randNum = Random.Range (0, 100);
		*/
		charGender = 1;

		charClassType = 1;
		charClassTypeName = "Warrior";


		attPhysical = 91;

		attMental = 46;

		attSocial = 32; 



		appfemininity = "very masculine";
		appfemininityFace = "masculine";


		backgroundPast = 0; //governor assistant
		backgroundPastText = "Ten Years War veteran";


		backgroundChild = 3; // young maid
		backgroundChildText = "Young squire";


		charTrait1 = 5;

		charTrait1Name = "Duelist";

		charTrait2 = 1;

		charTrait2Name = "Vigorous";




		charFlaw1 = 6;

		charFlaw1Name = "Lustful";

		charFlaw2 = 9;

		charFlaw2Name = "Infirm";

		charPersonalityID = 1;
		charPersonality = "Stoic";


		charFetishID = 1;
		charFetish = "Submissive";




		charPosition = "Gym keeper"; 


		charAppRace = "Deer";

		charName = "Yoshika";

		charAppFurColor= "Brown";
		charAppFeatherColor = "";
		charAppSkinType= "human"; 
		hasFur = true; 
		hasFeathers = false; 
		hasTentacles = false; 
		isFlying = false; 
		isExotic = 0; 
		hasKnot = false; 
		breastRow = 1;
		isPregnant = false; 
		pregnantText = "";
		lowerBack= "deer tail"; 
		shoulderBlades= ""; 
		headAccesory1= "broken antlers"; 
		headAccesory2= ""; 
		eyesType= "normal";

		dickType= "human"; 
		beardStyle= "no beard"; 
		dickNum= 1; 
		dickName= "big"; 
		dickSize= 25; 

		testiclesSize= 2; 
		testiclesName= "big as chestnuts"; 


		clitorisSize= 0; 
		hasVagina= false; 

		breastRow= 1; 
		breast1Size= 0; 
		breast1Name= "Flat"; 
		breast1Cup = "AA"; 
		breast2Size= 0;
		breast2Name= "";
		breast2Cup= ""; 
		nipple1Size= 2.2f;
		nipple2Size= 0f; 
		vagLooseness= 0; 
		isPregnant= false; 
		pregnantCD= 0; 
		pregnantText= ""; 

		appfemininityFaceStat = 3;
		appfemininityStat = 6;

		blackmailEvidenceCount = 0;
		blackmailEv1 = "";
		blackmailEv2 = "";
		blackmailEv3 = "";
		charInvestigation = 0;


		isVirgin = false;



		charAppSkinColor = "white"; 

		hairColor = "brown"; 

		hairStyle = "his usual"; 

		eyesColor= "red";




		//////////////////////Generic, already adjusted by gender//////////

		bodyBuildStat = 6;
		bodyBuild = "beefy";

		bodyPhysStat = 4;
		bodyPhisique = "average";

		appTattoo = "";
		appPierciengs = ""; 

		assSize = 4;
		assName = "regular";

		waistName = "average";
		waistSize = 3;

		hipsName = "average";
		hipsSize = 3;


		heightName = "regular size";

		heightChar = 182; 

		backgroundStory = "";

		charReputation = 48; 

		skillMartial = 92;

		skillSecurity = 31;

		skillLabor = 62;

		skillTactics = 16;

		skillGovernance = 25;

		skillStewardship = 18;

		skillPersuasion = 49;

		skillIntrigue = 22;

		skillDiplomacy = 76;



		setChar ();



		charFaction = GameControl.playerName; 

		 


	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	public void setLucina(){
		charCorruption = 55;
		charLoyalty = 80;
		maxHealth = 120;
		maxArousal = 90;
		initialArousal = 0;
		charSubmission = 15; 
		charRelationship = 25;
		isFriend = false;
		isLover = false;
		charCD = 0;

		isFurry = false;
		isFuta = false; 

		politicalPower = 0;

		//this sets the race for the setRace();
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 23); 
		raceID = Random.Range (0, 100);
		hashcode = GameControl.playerName.GetHashCode ();  

		charID = 6050;

		isNeutral = false;
		isRecruited = false;
		isEnemy = false;
		isPrisonerPlayer= false;
		isPrisonerEnemy = false;
		isSlave = false; 

		/*
		hashcode = GameControl.playerName.GetHashCode ();  
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond); 
		randNum = Random.Range (0, 100);
		*/
		charGender = 0;

		charClassType = 4;
		charClassTypeName = "Priestess";


		attPhysical = 56;

		attMental = 44;

		attSocial = 83; 


		appfemininity = "very feminine";
		appfemininityFace = "very feminine";
		appfemininityFaceStat = 18;
		appfemininityStat = 18;


		backgroundPast = 22; //governor assistant
		backgroundPastText = "Priestess";


		backgroundChild = 24; // young maid
		backgroundChildText = "Charity worker";


		charTrait1 = 8;

		charTrait1Name = "Humble";

		charTrait2 = 14;

		charTrait2Name = "Theologian";




		charFlaw1 = 8;

		charFlaw1Name = "Slothful";

		charFlaw2 = 13;

		charFlaw2Name = "Frail";

		charPersonalityID = 1;
		charPersonality = "Stoic";


		charFetishID = 5;
		charFetish = "Incest";




		charPosition = "not working"; 


		charAppRace = "Goo girl";

		charName = "Lucina";

		charAppFurColor= "";
		charAppFeatherColor = "";
		charAppSkinType= "goo"; 
		hasFur = false; 
		hasFeathers = false; 
		hasTentacles = false; 
		isFlying = false; 
		isExotic = 1; 
		hasKnot = true; 
		breastRow = 1;
		isPregnant = false; 
		pregnantText = "";
		lowerBack= ""; 
		shoulderBlades= ""; 
		headAccesory1= ""; 
		headAccesory2= ""; 
		eyesType= "normal";

		dickType= "human"; 
		beardStyle= "no beard"; 
		dickNum= 0; 
		dickName= ""; 
		dickSize= 0; 

		testiclesSize= 0; 
		testiclesName= ""; 


		clitorisSize= 0; 
		hasVagina= true; 

		breastRow= 1; 
		breast1Size= 11; 
		breast1Name= "Big"; 
		breast1Cup = "FF"; 
		breast2Size= 0;
		breast2Name= "";
		breast2Cup= ""; 
		nipple1Size= 3f;
		nipple2Size= 0f; 
		vagLooseness= 2; 
		isPregnant= false; 
		pregnantCD= 0; 
		pregnantText= ""; 

		blackmailEvidenceCount = 0;
		blackmailEv1 = "";
		blackmailEv2 = "";
		blackmailEv3 = "";
		charInvestigation = 0;


		isVirgin = false; // as false as you can get



		charAppSkinColor = "blue"; 

		hairColor = "blue"; 

		hairStyle = "her usual"; 

		eyesColor= "blue";




		//////////////////////Generic, already adjusted by gender/////////////////////////////////////////////////////////////////////////

		bodyBuildStat = 2;
		bodyBuild = "weak";

		bodyPhysStat = 5;
		bodyPhisique = "curvy";

		appTattoo = "";
		appPierciengs = ""; 

		assSize = 6;
		assName = "full";

		waistName = "slim";
		waistSize = 2;

		hipsName = "large";
		hipsSize = 4;


		heightName = "regular size";

		heightChar = 168; 

		backgroundStory = "";

		charReputation = 35; 

		skillMartial = 72;

		skillSecurity = 31;

		skillLabor = 26;

		skillTactics = 62;

		skillGovernance = 75;

		skillStewardship = 12;

		skillPersuasion = 79;

		skillIntrigue = 28;

		skillDiplomacy = 53;


		corruptionStage = 2;

		setChar ();



		charFaction = GameControl.playerName; 

		 


	}



	void Awake(){
		
		setHelena ();
		setAbbadon ();
		setMisaki ();
		setYoshika ();
		setLucina ();

	}



}
