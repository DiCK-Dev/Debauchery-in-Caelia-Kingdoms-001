using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

public class FollowerCreator : MonoBehaviour {






	public static List<NPCData> TempList = new List<NPCData>(); // data o


	NPCSettlerSex npcSettlerSex = new NPCSettlerSex();
	NPCSettlerName npcSettlerName = new NPCSettlerName();
	NPCSettlerAllegiance npcSettlerfaction = new NPCSettlerAllegiance ();
	NPCSettlerSide npcSettlerSide = new NPCSettlerSide();
	NPCSettlerClass npcSettlerClass = new NPCSettlerClass();
	NPCSettlerRank npcSettlerRank = new NPCSettlerRank();
	NPCSettlerFetish npcSettlerFetish = new NPCSettlerFetish();
	NPCSettlerAttributes npcSettlerAttributes = new NPCSettlerAttributes();
	NPCSettlerCoreSkills npcSettlerCoreSkills = new NPCSettlerCoreSkills();
	NPCSettlerUtilitySkill npcSettlerUtilitySkills = new NPCSettlerUtilitySkill();
	NPCSettlerSexSkills npcSettlerSexSkills = new NPCSettlerSexSkills();
	NPCSettlerPosition npcSettlerPosition = new NPCSettlerPosition();
	NPCSettlerPersonAtt npcSettlerPersonAtt = new NPCSettlerPersonAtt();
	NPCSettlerBackground npcSettlerBG = new NPCSettlerBackground();
	NPCSettlerRace npcSettlerRace = new NPCSettlerRace();
	RaceCreator raceCreator = new RaceCreator();
	NPCSettlerHead npcSettlerHead = new NPCSettlerHead();
	NPCSettlerBody npcSettlerBody = new NPCSettlerBody();
	NPCSettlerFertility npcSettlerFertility = new NPCSettlerFertility();
	NPCSettlerCombatStats npcSettlerCombatStats = new NPCSettlerCombatStats();
	NPCSettlerEquipment npcSettlerEquip = new NPCSettlerEquipment();
	NPCSettlerTraits npcSettlerTraits = new NPCSettlerTraits();
	NPCSettlerTraitsBonus npcSettlerTraitsBonus = new NPCSettlerTraitsBonus();


	public static int switchIsChar = 0; // help to set if the char starts as a prisoner, slave, etc. // 0 neutral, 1 recruited, 2 enemy, 3 isprisonerplayer, 4 isprisoner enemy, 5 isslave
	// system to build
	int randNum;
	int randNum2; 
	int hashcode = GameControl.playerName.GetHashCode();
	string completeName;
	int i;
	int raceID; // this is just a control, it helps define at the start if its going to be a human, monstergirl or exotic



	public int charID;  // id thats going to be used to look for him, should use a genNPC control for this
	public int charPortrait; // id of its portrait, will be used for enemies and stuff alike, several can have the same
	public string charName;  // add nick and surname 
	public string charNickname;
	public string charSurname; 
	public NPCData.CharSex charSexC; 

	public NPCData.CharGender charGenderC; 

	//special followers
	public int corruptionStage = 0; // it sets the max and ammount of corruption, 0(0-25), 1(25-50), 2(50-75), 3(75-90), 4(100), 
	public int slaveStage = 0; // goes from 0 to 4

	public NPCData.CharAge charAgeC; 

	public NPCData.CityFaction cityFactionC;	// change to sex 


	public bool isRecruited; // if it is in player side. 
	public bool isEnemy;// if its in the enemy AI side
	public bool isMonster; // for neutral monsters and enemies that can be captured
	public bool isNeutral; // used for neutral, hirable characters
	public bool isPrisoner; // this is used with isRecruited or isEnemy to decide in which side it is prisoner. 
	public bool isSlave; // this is used with isRecruited or isEnemy to decide in which side it is prisoner. 
	public bool isParty = false; // if its a party member or not
	public bool isQuesting = false; // if it is in a quest
	public bool isBroken; 
	public int isMarriedID; // married to ID, 0 means is not married, 1 means to player 
	public float charGold;
	public float charValue; //value in gold, both to recruit and ransom


	// list of lovers of this character, w/e the person is married. // MAKE AN OBJECT WHERE YOU CAN SAVE THIS DATA, NOT JUST THE ID
	//create a small object that defines only some basic elements like name and id 
	public List<NPCFamily> isMarried; // data o
	public List<NPCFamily> isParent; // it childs 
	public List<NPCFamily> isProgeny; // list of its two parents 


	public bool isFriend; // reachs with loyalty over 80, lost if it goes below 30
	public bool isLover; // reachs with charLove over 80, lost if it goes below 30

	public bool isFurry; // to determine portrait 
	public bool isFuta; 

	//not in this creator, we will have one for initials, those will use a selector for this one in specific, this is for normal NPCs
	public NPCData.Jobs cityPositionC; 

	public NPCData.CharClass charClassC; 
	// which class it is. // 0 soldier,1 warrior, 2 clerk, 3 bureaucrat, 4 monk/nun, 5 priest, 6 alchemist, 7 mystic, 8 thief, 9 infiltrator, 10 paladin, 11 dark paladin, 12 feral, 13 barbarian 
	//14 scout, 15 ranger, 16 community worker, 17 whore, 18 farmer, 19 industry worker, 20 politician, 21 diplomat, 22 inquisitor, 23 enforcer, 24 Performer, 25 Artist, 26 Scholar

	//these are affected by rank 
	public float attPhysical;  
	public float attMental; 
	public float attSocial; 

	public float attMagicPower; // special 
	public float attMagicPowerBonus; // the only bonus for an att

	// these are not affected by rank
	public float attBeauty; //(ugly, plain, good looking, captivating, stunning)
	public float attTemperament; //(apathethic,cold, reserved, lively, passional)
	public float attWillpower; // (submissive, docile, humble, assertive, willful)
	public float attNature; //(spinless, coward, uncertain, brave, determined)
	public float attOpenness; //(Frigthened, uninterested, timid, open, unashamed)
	public float attDignity; // how much self worth it has 
	public float attObedience; 
	public float attHappiness; 
	public float attLibido; // 
	public float attMorality; // how good and bad, it can be corrupt good, it means the person is just twisted
	public float attPiety;
	public float attStyle; // depends on its clothing


	public NPCData.CharPersonality charPersonalityC; 

	public NPCData.CharRank charRankC; // S, A, B, C

	public NPCData.CharFetish charFetishC;

	public List<NPCData.CharTraits> charTraitsC; // list of its two parents



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

	public NPCData.BgAdulthood bgAdulthoodC;

	public NPCData.BgChildhood bgChildhoodC;

	public NPCData.BgUpgring bgUpbringC;

	public string[] bgStory = new string[3];  // childhood, young adulthood, current



	public float charLoyalty; 
	public float charLove = 0; 
	public float charCorruption; 
	public float charRelationship;

	public float[] charAddictions = new float[8]; // alcohol, tobacco, opium, coke, shrooms, hero, semen



	//system
	public int charCD;

	public NPCData.CharRace charRaceC; 

	public NPCData.HeadType headTypeC;

	//public NPCData.TailType tailTypeC;

	public NPCData.CharFurColor charFurColorC; 

	public NPCData.CharFeatherColor charFeatherColorC;

	public NPCData.CharSkinColor charSkinColorC; 

	public NPCData.CharSkinType charSkinTypeC; 

	public NPCData.DickType dickTypeC; 

	public NPCData.LowerBack lowerBackC;

	public NPCData.ShoulderBlades shoulderBladesC; 

	public NPCData.ArmsType armsTypeC;

	public NPCData.LegsType legsTypeC;

	public NPCData.HeadAccesory1 headAccesory1C;

	public NPCData.HeadAccesory2 headAccesory2C;

	public NPCData.EyesType eyesTypeC;


	public bool hasFur; // everyone uses the fur colours tho
	public bool hasFeathers; 
	public bool hasScales;
	public bool hasTentacles;
	public bool isFlying;
	//special propeties

	public NPCData.BeardStyle beardStyleC;

	public NPCData.BeardLength beardLengthC;

	public NPCData.HairColor hairColorC;

	public NPCData.HairStyle hairStyleC;

	public NPCData.HairType hairTypeC;

	public float hairLengthCM; 

	public NPCData.HairLength hairLengthC;

	public NPCData.EyesColor eyesColorC;


	// this defines the overal behavior of the person, this is like body language
	public NPCData.GenderBehavior genderBehaviorC;
	public float genderBehaviorStat; // this is what sets the above, this can make a char more feminine or masculine after certain point


	// this defines how feminine or not is the face
	public NPCData.FacialFeatures facialFeaturesC; 
	public float facialFeaturesStat; 

	// this define how masculine or not is the body
	public NPCData.BodyFeatures bodyFeaturesC; 
	public float bodyFeaturesStat; 





	public float heightChar; // in cm
	public NPCData.HeightName heightNameC; 

	public NPCData.BodyPhysique bodyPhysiqueC; 
	public float bodyPhysStat; // to change it, 0 to 100
	//"skinny", "slender", "thin", "slim", "average", "curvy"/*5*/, "plump", "chubby", "extra chubby"
	public NPCData.BodyBuild bodyBuildC; 
	public float bodyBuildStat; // to change it

	public string[] charTattoos = new string[17]; 
	//0 Forehead //1 left cheek //2 righ cheek //3 neck //4 upper chest  
	//5 left breast //6 right breast //7 belly //8 low belly //9 upper back
	//10 lower back //11 left arm //12 right arm  //13 left ass cheek //14 right ass cheek
	//15 left leg //16 right leg //17 anus


	public string[] charPiercings = new string[20]; // in a single line

	//0 Earl  //1 Left eyebrow //2 Right eyebrow //3 Left nostril //4 Right nostril
	//5 Septum Piercing //6 Left ear lobe  //7 right ear lobe //8 Lef ear helix //9 right ear helix  
	//10 left lip  //11 Right lip //12 Labret piercing  //13 Tongue piercing //14 upper lip frenum piercing
	//15 lower lip frenum piercing  //16 left nipple piercing //17 right nipple piercing  //18 Navel piercing //19 Dick piercing
	//20 clitoris piercing





	public int dickNum; //how many dicks it has
	public float dickSizeCM; // in cm
	public NPCData.DickSize dickSizeC; 


	public NPCData.TesticleSize testiclesSizeC; // in cm, used to determine if you have or not
	public float testicleSizeCM; 

	public float clitorisSize; // in cm



	public int breastRow; 
	public float breast1Size; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler
	public float breast2Size; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler


	public NPCData.BreastName breast1NameC;
	public NPCData.BreastName breast2NameC; 

	public NPCData.BreastCup breast1CupC;
	public NPCData.BreastCup breast2CupC;


	public float areola1Size; // aerola size of the first row, 1 change, in cm
	public float areola2Size; // aerola size of the first row, 1 change, in cm



	//string assname, int asssize, string hipsname, int hipssize, string waistname, int wasitsize 

	public NPCData.AssName assNameC; 
	public float assSize; 


	public NPCData.HipsName hipsNameC; 
	public float hipsSize; 

	public NPCData.WaistName waistNameC; 
	public float waistSize; 

	//genitals and fertility
	public bool hasKnot; 
	public bool hasVagina; 
	public bool isVirgin; 
	public bool isFertile; 
	public bool isPregnant; 
	public NPCData.CharRace childRaceC; 
	public int pregnantCD; // turns until giving birth
	public string pregnantText; // 
	public bool isLactating;
	public float lactationML; // how much it lactates in ml
	public float charFertility; 

	public NPCData.VagLoose vagLoose; 
	public float vagLooseness; // 0 virgin, 1-5 etc 


	// combat
	public float maxHealth;
	public float currentHealth; 

	public float maxArousal; 
	public float currentArousal; 

	public float maxMP;
	public float currentMP; 

	public float charCombatAttack; // it is calculated by its attributes, equipment and traits 
	public float charLustAttack; 
	public float charCombatDefense;
	public float charLustDefense;
	public float charMagicDefense; 


	// add EQUIPMENT, COM AND LUST DEF TOO 
	public int[] charEquipment = new int[12];

	// power and politics 
	public float charReputation; 
	public float politicalPower;


	public float[] evidenceValue = new float[3];
	public string[] evidenceText = new string[3];

	public float charInformation; // this determines how much you have spied of them, unlocking more knowledge and info about them. It increases with relationship or spies. 0 to 100



	public void setChar(){




		TempList.Add (new NPCData (charID, charPortrait, charName, charNickname, charSurname, charSexC, corruptionStage, slaveStage, charGenderC, charAgeC, cityFactionC,
			isRecruited, isEnemy,  isMonster,  isNeutral, isPrisoner,  isSlave, isBroken, charGold,  charValue, isFurry, isFuta,  attPhysical,  attMental, attSocial ,
			attMagicPower, attBeauty,  attTemperament, attWillpower, attNature,  attOpenness, attDignity, attObedience, attHappiness, attLibido, attMorality,
			attPiety, attStyle, charRankC,  charPersonalityC, charFetishC, charClassC, cityPositionC, coreSkillMartial,  coreSkillSecurity ,
			coreSkillLabor, coreSkillTactics, coreSkillGovernance, coreSkillStewardship,  coreSkillPersuasion, coreSkillIntrigue, coreSkillDiplomacy, utilitySkillCrafting, utilitySkillHouseKeeping , 
			utilitySkillFarmHand,  utilitySkillMedicine, utilitySkillAlchemy, utilitySkillLearning, utilitySkillPerformance, utilitySkillEtiquette, utilitySkillStreetwise,  sexSkillMasseuse ,
			sexSkillStripping, sexSkillBondage, sexSkillPetplay,  sexSkillPetting, sexSkillGroupSex, sexSkillPenetration, sexSkillWhoring, sexSkillEscorting, bgAdulthoodC, bgChildhoodC ,
			bgStory, bgUpbringC, charLoyalty, charLove, charCorruption, charRelationship, charAddictions, charCD, charRaceC, headTypeC,  charFurColorC, charFeatherColorC ,
			charSkinColorC, charSkinTypeC, dickTypeC, lowerBackC, shoulderBladesC, armsTypeC, legsTypeC, beardStyleC, beardLengthC, headAccesory1C, headAccesory2C ,
			hairColorC, hairStyleC, hairTypeC, hairLengthCM, hairLengthC, eyesTypeC , eyesColorC, hasFur,  hasFeathers, hasScales, hasTentacles, isFlying ,
			genderBehaviorC, genderBehaviorStat, facialFeaturesC, facialFeaturesStat, bodyFeaturesC, bodyFeaturesStat, heightChar, heightNameC, bodyPhysiqueC ,
			bodyPhysStat, bodyBuildC, bodyBuildStat, hasKnot , hasVagina, isVirgin, isFertile, isPregnant, pregnantCD, pregnantText, isLactating, charFertility , childRaceC,
			lactationML, dickNum, dickSizeC , dickSizeCM,  testiclesSizeC, testicleSizeCM, clitorisSize, breastRow, breast1Size,  breast2Size, breast1NameC,
			breast2NameC, breast1CupC, breast2CupC,  areola1Size, areola2Size, vagLoose, vagLooseness, assNameC , assSize, hipsNameC , hipsSize, waistNameC,
			waistSize, maxHealth, currentHealth, maxArousal, currentArousal,  maxMP,  currentMP,
			/*charEquipment,*/ charReputation,  politicalPower,  charInformation 




		));



	}



	void charHelena(){



		charID = 3000; 
		charPortrait = 3001;
		charSexC  = NPCData.CharSex.Woman; 
		charName = "Helena";
		charSurname = "";
		charGenderC = NPCData.CharGender.FEMALE;
		cityFactionC = NPCData.CityFaction.MC;

		isRecruited = false;
		isEnemy = false;
		isMonster = false;
		isPrisoner = false;
		isNeutral = false;

		cityPositionC = NPCData.Jobs.HEADMAID;

		charClassC = NPCData.CharClass.Clerk;

		charRankC = NPCData.CharRank.S;

		charFetishC = NPCData.CharFetish.Exhibitionism;

		charPersonalityC = NPCData.CharPersonality.Shy; 

		attPhysical = 55;  
		attMental = 75;
		attSocial = 36;  
		attMagicPower = 0;

		coreSkillMartial = 8; //0
		coreSkillSecurity = 44;
		coreSkillLabor = 82;
		coreSkillTactics = 16; 
		coreSkillGovernance = 53;
		coreSkillStewardship = 74;
		coreSkillPersuasion = 27;
		coreSkillIntrigue = 18;
		coreSkillDiplomacy= 38; 

		utilitySkillCrafting = 21; 
		utilitySkillHouseKeeping =  89; 
		utilitySkillFarmHand =  47; 
		utilitySkillMedicine =  15;
		utilitySkillAlchemy =  3;
		utilitySkillLearning =  35;
		utilitySkillPerformance =  32;
		utilitySkillEtiquette =  73;
		utilitySkillStreetwise =  21;

		sexSkillMasseuse = 28;
		sexSkillStripping = 0; 
		sexSkillBondage = 0;
		sexSkillPetplay = 0;
		sexSkillPetting = 12;
		sexSkillGroupSex = 0;
		sexSkillPenetration = 17;
		sexSkillWhoring = 0; 
		sexSkillEscorting = 6; 

		attBeauty = 57; //(ugly, plain, good looking, captivating, stunning)
		attTemperament = 45; //(apathethic,cold, reserved, lively, passional)
		attWillpower = 0; // (submissive, docile, humble, assertive, willful)
		attNature = 34; //(spinless, coward, uncertain, brave, determined)
		attOpenness = 42; //(Frigthened, uninterested, timid, open, unashamed)
		attDignity = 88; // how much self worth it has 
		attObedience = 50; 
		attHappiness = 70; 
		attLibido = 25; // 
		attMorality = 90; // how good and bad, it can be corrupt good, it means the person is just twisted
		attPiety = 55;

		bgUpbringC = NPCData.BgUpgring.VeryPoor;


		charGold = 0;


		bgChildhoodC = NPCData.BgChildhood.Bookworm;
		bgAdulthoodC = NPCData.BgAdulthood.GovernorAssistant;

		bgStory [0] = "";
		bgStory [1] = "";
		bgStory [2] = "";


		charRaceC = NPCData.CharRace.Human; 

		charFurColorC = NPCData.CharFurColor.Gray; 

		charFeatherColorC = NPCData.CharFeatherColor.Gray;

		charSkinColorC = NPCData.CharSkinColor.fair; 

		charSkinTypeC = NPCData.CharSkinType.Human; 

		dickTypeC = NPCData.DickType.human; 

		lowerBackC = NPCData.LowerBack.NONE;

		shoulderBladesC = NPCData.ShoulderBlades.NONE; 

		headTypeC = NPCData.HeadType.HUMAN;

		//tailTypeC = NPCData.TailType.NONE;

		armsTypeC =  NPCData.ArmsType.HUMAN;

		legsTypeC =  NPCData.LegsType.HUMAN;

		headAccesory1C = NPCData.HeadAccesory1.NONE;

		headAccesory2C = NPCData.HeadAccesory2.NONE;

		eyesTypeC = NPCData.EyesType.human0;

		hasFur = false; // everyone uses the fur colours tho
		hasFeathers = false; 
		hasScales = false;
		hasTentacles = false;
		isFlying = false;

		isFurry = false; // to determine portrait 
		isFuta = false; 


		beardStyleC = NPCData.BeardStyle.NONE;

		beardLengthC = NPCData.BeardLength.NONE;

		hairColorC = NPCData.HairColor.auburn;

		hairStyleC = NPCData.HairStyle.bob;

		hairTypeC = NPCData.HairType.Normal;

		hairLengthCM = 32; 

		hairLengthC = NPCData.HairLength.overshoulder;

		eyesColorC = NPCData.EyesColor.blue;

		genderBehaviorStat = 85;
		genderBehaviorC = npcSettlerPersonAtt.setGenderBehavior(genderBehaviorStat);

		facialFeaturesStat = 85; 
		facialFeaturesC = npcSettlerHead.setFacialFeat(facialFeaturesStat); 

		bodyFeaturesStat= 85; 
		bodyFeaturesC = npcSettlerBody.setBodyFeatures(facialFeaturesStat); 

		heightChar = 172; // in cm
		heightNameC = npcSettlerBody.setHeightName(heightChar);


		bodyPhysStat = 2; // to change it
		bodyPhysiqueC = npcSettlerBody.setBodyPhysique(bodyPhysStat); 

		bodyBuildStat = 2; // to change it
		bodyBuildC= npcSettlerBody.setBodyBuild(bodyBuildStat); 


		dickNum = 0; //how many dicks it has
		dickSizeCM = 0; // in cm
		dickSizeC = NPCData.DickSize.NONE; 


		testicleSizeCM = 0; 
		testiclesSizeC = NPCData.TesticleSize.NONE; // in cm, used to determine if you have or not

		clitorisSize = 1.5f;



		breastRow = 1; 
		breast1Size = 6; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler
		breast2Size = 0; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler

		breast1NameC = npcSettlerBody.setBreastName (breast1Size);
		breast2NameC = npcSettlerBody.setBreastName (breast2Size);

		breast1CupC = npcSettlerBody.setBreastCup (breast1Size);
		breast2CupC = npcSettlerBody.setBreastCup (breast2Size);

		areola1Size = npcSettlerBody.setAureoleSize(); // aerola size of the first row, 1 change, in cm
		areola2Size = areola1Size; // aerola size of the first row, 1 change, in cm




		waistSize = 2; 
		waistNameC = npcSettlerBody.setWaistName(waistSize); 

		hipsSize = 2; 
		hipsNameC = npcSettlerBody.setHipsName(hipsSize); 

		assSize = 3; 
		assNameC = npcSettlerBody.setAssName(assSize); 


		hasKnot = false; 
		hasVagina = true; 
		isVirgin = false; 
		isFertile = true; 
		charFertility = 0.5f; 
		//isPregnant = npcSettlerFertility.isPregnant(pregnantselector, charSexC); 
		childRaceC = NPCData.CharRace.Human; 
		pregnantCD = 0; // turns until giving birth
		pregnantText = ""; // 
		isLactating = false;
		lactationML = 350; // how much it lactates in ml

		vagLooseness = 1;
		vagLoose = NPCData.VagLoose.thight;


		maxHealth = 90;
		currentHealth = maxHealth; 

		maxArousal = 110; 
		currentArousal = 0; 

		maxMP = 0;
		currentMP = maxMP; 


		int i = 0;
		while (i < 12) {
			charEquipment[i] = npcSettlerEquip.setCharEquipment(i, bgUpbringC, charClassC, charRaceC);
			i++; 
		}

		// power and politics 
		charReputation = 25; 
		politicalPower = 32;

		charAgeC = NPCData.CharAge.Adult;	


		charLoyalty = 25;
		charCorruption = 0;
		corruptionStage = 0;

		i = 0;
		while (i < 8) {
			charAddictions [i] = 0;
			i++;

		}

		charValue = 0;

		TempList.Clear();

		setChar();

		TempList [0].charTraits.Add (NPCData.CharTraits.Administrator); 
		TempList [0].charTraits.Add (NPCData.CharTraits.Affable); 
		TempList [0].charTraits.Add (NPCData.CharTraits.Clumsy);
		TempList [0].charTraits.Add (NPCData.CharTraits.Honest); 

		NPCCharList.CharFollower.Add (TempList [0]);
		Debug.Log ("Helena created");
	}







	void charAbbadon(){



		charID = 1000; 
		charPortrait = 1000;
		charSexC  = NPCData.CharSex.Cuntboy; 
		charName = "Abbadon";
		charSurname = "";
		charGenderC = NPCData.CharGender.MALE;
		cityFactionC = NPCData.CityFaction.ABBADON;

		isRecruited = false;
		isEnemy = false;
		isMonster = false;
		isPrisoner = false;
		isNeutral = false;

		cityPositionC = NPCData.Jobs.FACTIONLEADER;

		charClassC = NPCData.CharClass.Politician;

		charRankC = NPCData.CharRank.S;

		charFetishC = NPCData.CharFetish.AnalWhore;

		charPersonalityC = NPCData.CharPersonality.Harsh; 

		attPhysical = 75;  
		attMental = 45;
		attSocial = 86;  
		attMagicPower = 0;

		coreSkillMartial = 71; //0
		coreSkillSecurity = 54;
		coreSkillLabor = 12;
		coreSkillTactics = 46; 
		coreSkillGovernance = 83;
		coreSkillStewardship = 68;
		coreSkillPersuasion = 47;
		coreSkillIntrigue = 38;
		coreSkillDiplomacy= 68; 

		utilitySkillCrafting = 35; 
		utilitySkillHouseKeeping =  3; 
		utilitySkillFarmHand =  21; 
		utilitySkillMedicine =  5;
		utilitySkillAlchemy =  0;
		utilitySkillLearning =  41;
		utilitySkillPerformance =  62;
		utilitySkillEtiquette =  83;
		utilitySkillStreetwise =  41;

		sexSkillMasseuse = 18;
		sexSkillStripping = 0; 
		sexSkillBondage = 0;
		sexSkillPetplay = 0;
		sexSkillPetting = 38;
		sexSkillGroupSex = 0;
		sexSkillPenetration = 57;
		sexSkillWhoring = 0; 
		sexSkillEscorting = 12; 

		attBeauty = 72; //(ugly, plain, good looking, captivating, stunning)
		attTemperament = 75; //(apathethic,cold, reserved, lively, passional)
		attWillpower = 92; // (submissive, docile, humble, assertive, willful)
		attNature = 74; //(spinless, coward, uncertain, brave, determined)
		attOpenness = 22; //(Frigthened, uninterested, timid, open, unashamed)
		attDignity = 92; // how much self worth it has 
		attObedience = 12; 
		attHappiness = 45; 
		attLibido = 45; // 
		attMorality = 50; // how good and bad, it can be corrupt good, it means the person is just twisted
		attPiety = 45;

		bgUpbringC = NPCData.BgUpgring.Noble;


		charGold = 0;


		bgChildhoodC = NPCData.BgChildhood.NobleFamily;
		bgAdulthoodC = NPCData.BgAdulthood.Courtier;

		bgStory [0] = "";
		bgStory [1] = "";
		bgStory [2] = "";


		charRaceC = NPCData.CharRace.Human; 

		charFurColorC = NPCData.CharFurColor.Gray; 

		charFeatherColorC = NPCData.CharFeatherColor.Gray;

		charSkinColorC = NPCData.CharSkinColor.fair; 

		charSkinTypeC = NPCData.CharSkinType.Human; 

		dickTypeC = NPCData.DickType.human; 

		lowerBackC = NPCData.LowerBack.NONE;

		shoulderBladesC = NPCData.ShoulderBlades.NONE; 

		headTypeC = NPCData.HeadType.HUMAN;

		//tailTypeC = NPCData.TailType.NONE;

		armsTypeC =  NPCData.ArmsType.HUMAN;

		legsTypeC =  NPCData.LegsType.HUMAN;

		headAccesory1C = NPCData.HeadAccesory1.NONE;

		headAccesory2C = NPCData.HeadAccesory2.NONE;

		eyesTypeC = NPCData.EyesType.human0;

		hasFur = false; // everyone uses the fur colours tho
		hasFeathers = false; 
		hasScales = false;
		hasTentacles = false;
		isFlying = false;

		isFurry = false; // to determine portrait 
		isFuta = false; 


		beardStyleC = NPCData.BeardStyle.NONE;

		beardLengthC = NPCData.BeardLength.NONE;

		hairColorC = NPCData.HairColor.auburn;

		hairStyleC = NPCData.HairStyle.sassy;

		hairTypeC = NPCData.HairType.Normal;

		hairLengthCM = 32; 

		hairLengthC = NPCData.HairLength.overshoulder;

		eyesColorC = NPCData.EyesColor.black;

		genderBehaviorStat = 35;
		genderBehaviorC = npcSettlerPersonAtt.setGenderBehavior(genderBehaviorStat);

		facialFeaturesStat = 65; 
		facialFeaturesC = npcSettlerHead.setFacialFeat(facialFeaturesStat); 

		bodyFeaturesStat= 65; 
		bodyFeaturesC = npcSettlerBody.setBodyFeatures(facialFeaturesStat); 

		heightChar = 152; // in cm
		heightNameC = npcSettlerBody.setHeightName(heightChar);


		bodyPhysStat = 2; // to change it, 0 to 100
		bodyPhysiqueC = npcSettlerBody.setBodyPhysique(bodyPhysStat); 

		bodyBuildStat = 2; // to change it
		bodyBuildC= npcSettlerBody.setBodyBuild(bodyBuildStat); 


		dickNum = 0; //how many dicks it has
		dickSizeCM = 0; // in cm
		dickSizeC = NPCData.DickSize.NONE; 


		testicleSizeCM = 0; 
		testiclesSizeC = NPCData.TesticleSize.NONE; // in cm, used to determine if you have or not

		clitorisSize = 1.5f;



		breastRow = 1; 
		breast1Size = 0; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler
		breast2Size = 0; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler

		breast1NameC = npcSettlerBody.setBreastName (breast1Size);
		breast2NameC = npcSettlerBody.setBreastName (breast2Size);

		breast1CupC = npcSettlerBody.setBreastCup (breast1Size);
		breast2CupC = npcSettlerBody.setBreastCup (breast2Size);

		areola1Size = npcSettlerBody.setAureoleSize(); // aerola size of the first row, 1 change, in cm
		areola2Size = areola1Size; // aerola size of the first row, 1 change, in cm




		waistSize = 2; 
		waistNameC = npcSettlerBody.setWaistName(waistSize); 

		hipsSize = 2; 
		hipsNameC = npcSettlerBody.setHipsName(hipsSize); 

		assSize = 3; 
		assNameC = npcSettlerBody.setAssName(assSize); 


		hasKnot = false; 
		hasVagina = true; 
		isVirgin = false; 
		isFertile = true; 
		charFertility = 0.5f; 
		//isPregnant = npcSettlerFertility.isPregnant(pregnantselector, charSexC); 
		childRaceC = NPCData.CharRace.Human; 
		pregnantCD = 0; // turns until giving birth
		pregnantText = ""; // 
		isLactating = false;
		lactationML = 350; // how much it lactates in ml

		vagLooseness = 1;
		vagLoose = NPCData.VagLoose.thight;


		maxHealth = 120;
		currentHealth = maxHealth; 

		maxArousal = 100; 
		currentArousal = 0; 

		maxMP = 0;
		currentMP = maxMP; 


		int i = 0;
		while (i < 12) {
			charEquipment[i] = npcSettlerEquip.setCharEquipment(i, bgUpbringC, charClassC, charRaceC);
			i++; 
		}

		// power and politics 
		charReputation = 670; 
		politicalPower = 780;

		charAgeC = NPCData.CharAge.YoungAdult;	


		charLoyalty = 0;
		charCorruption = 27;
		corruptionStage = 0;

		i = 0;
		while (i < 8) {
			charAddictions [i] = 0;
			i++;

		}

		charValue = 0;

		TempList.Clear();

		setChar();

		TempList [0].charTraits.Add (NPCData.CharTraits.Arrogant); 
		TempList [0].charTraits.Add (NPCData.CharTraits.Bloodthirsty); 
		TempList [0].charTraits.Add (NPCData.CharTraits.Eccentric);
		TempList [0].charTraits.Add (NPCData.CharTraits.Fierce); 

		NPCCharList.CharFollower.Add (TempList [0]);
		Debug.Log ("Abbadoncreated");
	}


	void charYoshika(){



		charID = 5000; 
		charPortrait = 5050;
		charSexC  = NPCData.CharSex.Man; 
		charName = "Yoshika";
		charSurname = "";
		charGenderC = NPCData.CharGender.MALE;
		cityFactionC = NPCData.CityFaction.MC;

		isRecruited = false;
		isEnemy = false;
		isMonster = false;
		isPrisoner = false;
		isNeutral = false;

		cityPositionC = NPCData.Jobs.RETAINER;

		charClassC = NPCData.CharClass.Warrior;

		charRankC = NPCData.CharRank.S;

		charFetishC = NPCData.CharFetish.Submissive;

		charPersonalityC = NPCData.CharPersonality.Courteous; 

		attPhysical = 85;  
		attMental = 32;
		attSocial = 46;  
		attMagicPower = 0;

		coreSkillMartial = 88; //0
		coreSkillSecurity = 64;
		coreSkillLabor = 52;
		coreSkillTactics = 16; 
		coreSkillGovernance = 23;
		coreSkillStewardship = 14;
		coreSkillPersuasion = 16;
		coreSkillIntrigue = 6;
		coreSkillDiplomacy= 48; 

		utilitySkillCrafting = 66; 
		utilitySkillHouseKeeping =  49; 
		utilitySkillFarmHand =  57; 
		utilitySkillMedicine =  25;
		utilitySkillAlchemy =  6;
		utilitySkillLearning =  25;
		utilitySkillPerformance =  12;
		utilitySkillEtiquette =  63;
		utilitySkillStreetwise =  0;

		sexSkillMasseuse = 28;
		sexSkillStripping = 31; 
		sexSkillBondage = 79;
		sexSkillPetplay = 67;
		sexSkillPetting = 52;
		sexSkillGroupSex = 25;
		sexSkillPenetration = 47;
		sexSkillWhoring = 0; 
		sexSkillEscorting = 6; 

		attBeauty = 67; //(ugly, plain, good looking, captivating, stunning)
		attTemperament = 45; //(apathethic,cold, reserved, lively, passional)
		attWillpower = 15; // (submissive, docile, humble, assertive, willful)
		attNature = 84; //(spinless, coward, uncertain, brave, determined)
		attOpenness = 49; //(Frigthened, uninterested, timid, open, unashamed)
		attDignity = 28; // how much self worth it has 
		attObedience = 78; 
		attHappiness = 50; 
		attLibido = 45; // 
		attMorality = 90; // how good and bad, it can be corrupt good, it means the person is just twisted
		attPiety = 75;

		bgUpbringC = NPCData.BgUpgring.VeryPoor;


		charGold = 0;


		bgChildhoodC = NPCData.BgChildhood.RoyalGuardApprentice;
		bgAdulthoodC = NPCData.BgAdulthood.RoyalGuard;

		bgStory [0] = "";
		bgStory [1] = "";
		bgStory [2] = "";


		charRaceC = NPCData.CharRace.Deer; 

		charFurColorC = NPCData.CharFurColor.Gray; 

		charFeatherColorC = NPCData.CharFeatherColor.Gray;

		charSkinColorC = NPCData.CharSkinColor.fair; 

		charSkinTypeC = NPCData.CharSkinType.Human; 

		dickTypeC = NPCData.DickType.human; 

		lowerBackC = NPCData.LowerBack.deer;

		shoulderBladesC = NPCData.ShoulderBlades.NONE; 

		headTypeC = NPCData.HeadType.DEER;

		//tailTypeC = NPCData.TailType.NONE;

		armsTypeC =  NPCData.ArmsType.DEER;

		legsTypeC =  NPCData.LegsType.DEER;

		headAccesory1C = NPCData.HeadAccesory1.deerAntlers;

		headAccesory2C = NPCData.HeadAccesory2.NONE;

		eyesTypeC = NPCData.EyesType.human0;

		hasFur = true; // everyone uses the fur colours tho
		hasFeathers = false; 
		hasScales = false;
		hasTentacles = false;
		isFlying = false;

		isFurry = true; // to determine portrait 
		isFuta = false; 


		beardStyleC = NPCData.BeardStyle.NONE;

		beardLengthC = NPCData.BeardLength.NONE;

		hairColorC = NPCData.HairColor.brown;

		hairStyleC = NPCData.HairStyle.disheveled;

		hairTypeC = NPCData.HairType.Normal;

		hairLengthCM = 32; 

		hairLengthC = NPCData.HairLength.overshoulder;

		eyesColorC = NPCData.EyesColor.darkBrown;

		genderBehaviorStat = 15;
		genderBehaviorC = npcSettlerPersonAtt.setGenderBehavior(genderBehaviorStat);

		facialFeaturesStat = 15; 
		facialFeaturesC = npcSettlerHead.setFacialFeat(facialFeaturesStat); 

		bodyFeaturesStat= 15; 
		bodyFeaturesC = npcSettlerBody.setBodyFeatures(facialFeaturesStat); 

		heightChar = 182; // in cm
		heightNameC = npcSettlerBody.setHeightName(heightChar);


		bodyPhysStat = 3; // to change it, 0 to 100
		bodyPhysiqueC = npcSettlerBody.setBodyPhysique(bodyPhysStat); 

		bodyBuildStat = 6; // to change it
		bodyBuildC= npcSettlerBody.setBodyBuild(bodyBuildStat); 


		dickNum = 1; //how many dicks it has
		dickSizeCM = 24; // in cm
		dickSizeC = npcSettlerBody.setDickSize(dickSizeCM); 


		testicleSizeCM = 12; 
		testiclesSizeC = npcSettlerBody.setTesticlesSize(testicleSizeCM); // in cm, used to determine if you have or not

		clitorisSize = 0f;



		breastRow = 1; 
		breast1Size = 0; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler
		breast2Size = 0; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler

		breast1NameC = npcSettlerBody.setBreastName (breast1Size);
		breast2NameC = npcSettlerBody.setBreastName (breast2Size);

		breast1CupC = npcSettlerBody.setBreastCup (breast1Size);
		breast2CupC = npcSettlerBody.setBreastCup (breast2Size);

		areola1Size = npcSettlerBody.setAureoleSize(); // aerola size of the first row, 1 change, in cm
		areola2Size = areola1Size; // aerola size of the first row, 1 change, in cm




		waistSize = 3; 
		waistNameC = npcSettlerBody.setWaistName(waistSize); 

		hipsSize = 3; 
		hipsNameC = npcSettlerBody.setHipsName(hipsSize); 

		assSize = 3; 
		assNameC = npcSettlerBody.setAssName(assSize); 


		hasKnot = false; 
		hasVagina = false; 
		isVirgin = false; 
		isFertile = true; 
		charFertility = 0.5f; 
		//isPregnant = npcSettlerFertility.isPregnant(pregnantselector, charSexC); 
		childRaceC = NPCData.CharRace.Human; 
		pregnantCD = 0; // turns until giving birth
		pregnantText = ""; // 
		isLactating = false;
		lactationML = 350; // how much it lactates in ml

		vagLooseness = 0;
		vagLoose = NPCData.VagLoose.virgin;


		maxHealth = 150;
		currentHealth = maxHealth; 

		maxArousal = 70; 
		currentArousal = 0; 

		maxMP = 0;
		currentMP = maxMP; 


		int i = 0;
		while (i < 12) {
			charEquipment[i] = npcSettlerEquip.setCharEquipment(i, bgUpbringC, charClassC, charRaceC);
			i++; 
		}

		// power and politics 
		charReputation = 45; 
		politicalPower = 12;

		charAgeC = NPCData.CharAge.Adult;	


		charLoyalty = 75;
		charCorruption = 78;
		corruptionStage = 3;

		i = 0;
		while (i < 8) {
			charAddictions [i] = 0;
			i++;

		}

		charValue = 0;

		TempList.Clear();

		setChar();

		TempList [0].charTraits.Add (NPCData.CharTraits.Brave); 
		TempList [0].charTraits.Add (NPCData.CharTraits.Cooperative); 
		TempList [0].charTraits.Add (NPCData.CharTraits.Dependant);
		TempList [0].charTraits.Add (NPCData.CharTraits.Disciplined); 

		NPCCharList.CharFollower.Add (TempList [0]);
		Debug.Log ("Yoshika created");
	}



	void charMisaki(){



		charID = 4000; 
		charPortrait = 4050;

		charSexC  = NPCData.CharSex.Woman; 
		charName = "Misaki";
		charSurname = "";
		charGenderC = NPCData.CharGender.FEMALE;
		cityFactionC = NPCData.CityFaction.MC;

		isRecruited = false;
		isEnemy = false;
		isMonster = false;
		isPrisoner = false;
		isNeutral = false;

		cityPositionC = NPCData.Jobs.RETAINER;

		charClassC = NPCData.CharClass.Whore;

		charRankC = NPCData.CharRank.S;

		charFetishC = NPCData.CharFetish.GroupSex;

		charPersonalityC = NPCData.CharPersonality.Lewd; 

		attPhysical = 65;  
		attMental = 35;
		attSocial = 86;  
		attMagicPower = 0;

		coreSkillMartial = 29; //0
		coreSkillSecurity = 24;
		coreSkillLabor = 12;
		coreSkillTactics = 26; 
		coreSkillGovernance = 33;
		coreSkillStewardship = 34;
		coreSkillPersuasion = 87;
		coreSkillIntrigue = 68;
		coreSkillDiplomacy= 24; 

		utilitySkillCrafting = 21; 
		utilitySkillHouseKeeping =  39; 
		utilitySkillFarmHand =  57; 
		utilitySkillMedicine =  4;
		utilitySkillAlchemy =  0;
		utilitySkillLearning =  20;
		utilitySkillPerformance =  62;
		utilitySkillEtiquette =  36;
		utilitySkillStreetwise =  21;

		sexSkillMasseuse = 28;
		sexSkillStripping = 88; 
		sexSkillBondage = 32;
		sexSkillPetplay = 75;
		sexSkillPetting = 70;
		sexSkillGroupSex = 95;
		sexSkillPenetration = 87;
		sexSkillWhoring = 74; 
		sexSkillEscorting = 15; 

		attBeauty = 57; //(ugly, plain, good looking, captivating, stunning)
		attTemperament = 45; //(apathethic,cold, reserved, lively, passional)
		attWillpower = 50; // (submissive, docile, humble, assertive, willful)
		attNature = 34; //(spinless, coward, uncertain, brave, determined)
		attOpenness = 42; //(Frigthened, uninterested, timid, open, unashamed)
		attDignity = 88; // how much self worth it has 
		attObedience = 60; 
		attHappiness = 70; 
		attLibido = 25; // 
		attMorality = 90; // how good and bad, it can be corrupt good, it means the person is just twisted
		attPiety = 55;

		bgUpbringC = NPCData.BgUpgring.VeryPoor;


		charGold = 0;


		bgChildhoodC = NPCData.BgChildhood.PromiscuousFamily;
		bgAdulthoodC = NPCData.BgAdulthood.Whore;

		bgStory [0] = "";
		bgStory [1] = "";
		bgStory [2] = "";


		charRaceC = NPCData.CharRace.Fox; 

		charFurColorC = NPCData.CharFurColor.Orange; 

		charFeatherColorC = NPCData.CharFeatherColor.Gray;

		charSkinColorC = NPCData.CharSkinColor.fair; 

		charSkinTypeC = NPCData.CharSkinType.Human; 

		dickTypeC = NPCData.DickType.human; 

		lowerBackC = NPCData.LowerBack.fox;

		shoulderBladesC = NPCData.ShoulderBlades.NONE; 

		headTypeC = NPCData.HeadType.FOX;

		//tailTypeC = NPCData.TailType.NONE;

		armsTypeC =  NPCData.ArmsType.FOX;

		legsTypeC =  NPCData.LegsType.FOX;

		headAccesory1C = NPCData.HeadAccesory1.NONE;

		headAccesory2C = NPCData.HeadAccesory2.NONE;

		eyesTypeC = NPCData.EyesType.human0;

		hasFur = true; // everyone uses the fur colours tho
		hasFeathers = false; 
		hasScales = false;
		hasTentacles = false;
		isFlying = false;

		isFurry = true; // to determine portrait 
		isFuta = false; 


		beardStyleC = NPCData.BeardStyle.NONE;

		beardLengthC = NPCData.BeardLength.NONE;

		hairColorC = NPCData.HairColor.brown;

		hairStyleC = NPCData.HairStyle.LongHair;

		hairTypeC = NPCData.HairType.Normal;

		hairLengthCM = 72; 

		hairLengthC = NPCData.HairLength.midback;

		eyesColorC = NPCData.EyesColor.red;

		genderBehaviorStat = 95;
		genderBehaviorC = npcSettlerPersonAtt.setGenderBehavior(genderBehaviorStat);

		facialFeaturesStat = 95; 
		facialFeaturesC = npcSettlerHead.setFacialFeat(facialFeaturesStat); 

		bodyFeaturesStat= 95; 
		bodyFeaturesC = npcSettlerBody.setBodyFeatures(facialFeaturesStat); 

		heightChar = 177; // in cm
		heightNameC = npcSettlerBody.setHeightName(heightChar);


		bodyPhysStat = 3; // to change it, 0 to 100
		bodyPhysiqueC = npcSettlerBody.setBodyPhysique(bodyPhysStat); 

		bodyBuildStat = 3; // to change it
		bodyBuildC= npcSettlerBody.setBodyBuild(bodyBuildStat); 


		dickNum = 0; //how many dicks it has
		dickSizeCM = 0; // in cm
		dickSizeC = NPCData.DickSize.NONE; 


		testicleSizeCM = 0; 
		testiclesSizeC = NPCData.TesticleSize.NONE; // in cm, used to determine if you have or not

		clitorisSize = 1.5f;



		breastRow = 1; 
		breast1Size = 8; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler
		breast2Size = 0; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler

		breast1NameC = npcSettlerBody.setBreastName (breast1Size);
		breast2NameC = npcSettlerBody.setBreastName (breast2Size);

		breast1CupC = npcSettlerBody.setBreastCup (breast1Size);
		breast2CupC = npcSettlerBody.setBreastCup (breast2Size);

		areola1Size = npcSettlerBody.setAureoleSize(); // aerola size of the first row, 1 change, in cm
		areola2Size = areola1Size; // aerola size of the first row, 1 change, in cm




		waistSize = 2; 
		waistNameC = npcSettlerBody.setWaistName(waistSize); 

		hipsSize = 3; 
		hipsNameC = npcSettlerBody.setHipsName(hipsSize); 

		assSize = 4; 
		assNameC = npcSettlerBody.setAssName(assSize); 


		hasKnot = false; 
		hasVagina = true; 
		isVirgin = false; 
		isFertile = true; 
		charFertility = 0.5f; 
		//isPregnant = npcSettlerFertility.isPregnant(pregnantselector, charSexC); 
		childRaceC = NPCData.CharRace.Fox; 
		pregnantCD = 0; // turns until giving birth
		pregnantText = ""; // 
		isLactating = false;
		lactationML = 350; // how much it lactates in ml

		vagLooseness = 2;
		vagLoose = NPCData.VagLoose.thight;


		maxHealth = 100;
		currentHealth = maxHealth; 

		maxArousal = 120; 
		currentArousal = 0; 

		maxMP = 0;
		currentMP = maxMP; 


		int i = 0;
		while (i < 12) {
			charEquipment[i] = npcSettlerEquip.setCharEquipment(i, bgUpbringC, charClassC, charRaceC);
			i++; 
		}

		// power and politics 
		charReputation = -35; 
		politicalPower = 5;

		charAgeC = NPCData.CharAge.Adult;	


		charLoyalty = 35;
		charCorruption = 57;
		corruptionStage = 2;

		i = 0;
		while (i < 8) {
			charAddictions [i] = 0;
			i++;

		}

		charValue = 0;

		TempList.Clear();

		setChar();

		TempList [0].charTraits.Add (NPCData.CharTraits.Extroverted); 
		TempList [0].charTraits.Add (NPCData.CharTraits.StrongPersonality); 
		TempList [0].charTraits.Add (NPCData.CharTraits.Seducer);
		TempList [0].charTraits.Add (NPCData.CharTraits.Persuasive); 

		NPCCharList.CharFollower.Add (TempList [0]);
		Debug.Log ("Misaki created");
	}

	void charLucina(){



		charID = 6000; 
		charPortrait = 6000;
		charSexC  = NPCData.CharSex.Woman; 
		charName = "Lucina";
		charSurname = "";
		charGenderC = NPCData.CharGender.FEMALE;
		cityFactionC = NPCData.CityFaction.MC;

		isRecruited = false;
		isEnemy = false;
		isMonster = false;
		isPrisoner = false;
		isNeutral = false;

		cityPositionC = NPCData.Jobs.MOTHER;

		charClassC = NPCData.CharClass.Priest;

		charRankC = NPCData.CharRank.S;

		charFetishC = NPCData.CharFetish.Incest;

		charPersonalityC = NPCData.CharPersonality.Cheerful; 

		attPhysical = 44;  
		attMental = 84;
		attSocial = 62;  
		attMagicPower = 5;

		coreSkillMartial = 46; //0
		coreSkillSecurity = 54;
		coreSkillLabor = 42;
		coreSkillTactics = 26; 
		coreSkillGovernance = 63;
		coreSkillStewardship = 44;
		coreSkillPersuasion = 67;
		coreSkillIntrigue = 28;
		coreSkillDiplomacy= 84; 

		utilitySkillCrafting = 31; 
		utilitySkillHouseKeeping =  79; 
		utilitySkillFarmHand =  63; 
		utilitySkillMedicine =  44;
		utilitySkillAlchemy =  10;
		utilitySkillLearning =  60;
		utilitySkillPerformance =  32;
		utilitySkillEtiquette =  76;
		utilitySkillStreetwise =  4;

		sexSkillMasseuse = 68;
		sexSkillStripping = 18; 
		sexSkillBondage = 20;
		sexSkillPetplay = 0;
		sexSkillPetting = 78;
		sexSkillGroupSex = 12;
		sexSkillPenetration = 37;
		sexSkillWhoring = 0; 
		sexSkillEscorting = 65; 

		attBeauty =87; //(ugly, plain, good looking, captivating, stunning)
		attTemperament = 65; //(apathethic,cold, reserved, lively, passional)
		attWillpower = 30; // (submissive, docile, humble, assertive, willful)
		attNature = 74; //(spinless, coward, uncertain, brave, determined)
		attOpenness = 32; //(Frigthened, uninterested, timid, open, unashamed)
		attDignity = 68; // how much self worth it has 
		attObedience = 75; 
		attHappiness = 80; 
		attLibido = 45; // 
		attMorality = 90; // how good and bad, it can be corrupt good, it means the person is just twisted
		attPiety = 85;

		bgUpbringC = NPCData.BgUpgring.Noble;


		charGold = 0;


		bgChildhoodC = NPCData.BgChildhood.CharityVolunteer;
		bgAdulthoodC = NPCData.BgAdulthood.Priest;

		bgStory [0] = "";
		bgStory [1] = "";
		bgStory [2] = "";


		charRaceC = NPCData.CharRace.Human; 

		charFurColorC = NPCData.CharFurColor.Gray; 

		charFeatherColorC = NPCData.CharFeatherColor.Gray;

		charSkinColorC = NPCData.CharSkinColor.fair; 

		charSkinTypeC = NPCData.CharSkinType.Human; 

		dickTypeC = NPCData.DickType.human; 

		lowerBackC = NPCData.LowerBack.NONE;

		shoulderBladesC = NPCData.ShoulderBlades.NONE; 

		headTypeC = NPCData.HeadType.HUMAN;

		//tailTypeC = NPCData.TailType.NONE;

		armsTypeC =  NPCData.ArmsType.HUMAN;

		legsTypeC =  NPCData.LegsType.HUMAN;

		headAccesory1C = NPCData.HeadAccesory1.NONE;

		headAccesory2C = NPCData.HeadAccesory2.NONE;

		eyesTypeC = NPCData.EyesType.human0;

		hasFur = false; // everyone uses the fur colours tho
		hasFeathers = false; 
		hasScales = false;
		hasTentacles = false;
		isFlying = false;

		isFurry = false; // to determine portrait 
		isFuta = false; 


		beardStyleC = NPCData.BeardStyle.NONE;

		beardLengthC = NPCData.BeardLength.NONE;

		hairColorC = NPCData.HairColor.blonde;

		hairStyleC = NPCData.HairStyle.sassy;

		hairTypeC = NPCData.HairType.Normal;

		hairLengthCM = 35; 

		hairLengthC = NPCData.HairLength.sshort;

		eyesColorC = NPCData.EyesColor.blue;

		genderBehaviorStat = 95;
		genderBehaviorC = npcSettlerPersonAtt.setGenderBehavior(genderBehaviorStat);

		facialFeaturesStat = 95; 
		facialFeaturesC = npcSettlerHead.setFacialFeat(facialFeaturesStat); 

		bodyFeaturesStat= 95; 
		bodyFeaturesC = npcSettlerBody.setBodyFeatures(facialFeaturesStat); 

		heightChar = 169; // in cm
		heightNameC = npcSettlerBody.setHeightName(heightChar);


		bodyPhysStat = 2; // to change it, 0 to 100
		bodyPhysiqueC = npcSettlerBody.setBodyPhysique(bodyPhysStat); 

		bodyBuildStat = 3; // to change it
		bodyBuildC= npcSettlerBody.setBodyBuild(bodyBuildStat); 


		dickNum = 0; //how many dicks it has
		dickSizeCM = 0; // in cm
		dickSizeC = NPCData.DickSize.NONE; 


		testicleSizeCM = 0; 
		testiclesSizeC = NPCData.TesticleSize.NONE; // in cm, used to determine if you have or not

		clitorisSize = 1.5f;



		breastRow = 1; 
		breast1Size = 9; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler
		breast2Size = 0; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler

		breast1NameC = npcSettlerBody.setBreastName (breast1Size);
		breast2NameC = npcSettlerBody.setBreastName (breast2Size);

		breast1CupC = npcSettlerBody.setBreastCup (breast1Size);
		breast2CupC = npcSettlerBody.setBreastCup (breast2Size);

		areola1Size = npcSettlerBody.setAureoleSize(); // aerola size of the first row, 1 change, in cm
		areola2Size = areola1Size; // aerola size of the first row, 1 change, in cm




		waistSize = 2; 
		waistNameC = npcSettlerBody.setWaistName(waistSize); 

		hipsSize = 3; 
		hipsNameC = npcSettlerBody.setHipsName(hipsSize); 

		assSize = 4; 
		assNameC = npcSettlerBody.setAssName(assSize); 


		hasKnot = false; 
		hasVagina = true; 
		isVirgin = false; 
		isFertile = true; 
		charFertility = 0.5f; 
		//isPregnant = npcSettlerFertility.isPregnant(pregnantselector, charSexC); 
		childRaceC = NPCData.CharRace.Human; 
		pregnantCD = 0; // turns until giving birth
		pregnantText = ""; // 
		isLactating = false;
		lactationML = 350; // how much it lactates in ml

		vagLooseness = 1;
		vagLoose = NPCData.VagLoose.verythight;


		maxHealth = 120;
		currentHealth = maxHealth; 

		maxArousal = 120; 
		currentArousal = 0; 

		maxMP = 30;
		currentMP = maxMP; 


		int i = 0;
		while (i < 12) {
			charEquipment[i] = npcSettlerEquip.setCharEquipment(i, bgUpbringC, charClassC, charRaceC);
			i++; 
		}

		// power and politics 
		charReputation = 295; 
		politicalPower = 105;

		charAgeC = NPCData.CharAge.Mature;	


		charLoyalty = 95;
		charCorruption = 57;
		corruptionStage = 2;

		i = 0;
		while (i < 8) {
			charAddictions [i] = 0;
			i++;

		}

		charValue = 0;

		TempList.Clear();

		setChar();

		TempList [0].charTraits.Add (NPCData.CharTraits.Brave); 
		TempList [0].charTraits.Add (NPCData.CharTraits.Diligent); 
		TempList [0].charTraits.Add (NPCData.CharTraits.Exotic);
		TempList [0].charTraits.Add (NPCData.CharTraits.Hopeful); 

		NPCCharList.CharFollower.Add (TempList [0]);
		Debug.Log ("Lucina created");
	}




	void charItzel(){



		charID = 7000; 
		charPortrait = 7050;
		charSexC  = NPCData.CharSex.Woman; 
		charName = "Itzel";
		charSurname = "";
		charGenderC = NPCData.CharGender.FEMALE;
		cityFactionC = NPCData.CityFaction.MC;

		isRecruited = false;
		isEnemy = false;
		isMonster = false;
		isPrisoner = false;
		isNeutral = false;

		cityPositionC = NPCData.Jobs.GRANDPRIESTESS;

		charClassC = NPCData.CharClass.Priest;

		charRankC = NPCData.CharRank.S;

		charFetishC = NPCData.CharFetish.CumSlut;

		charPersonalityC = NPCData.CharPersonality.Romantic; 

		attPhysical = 22;  
		attMental = 47;
		attSocial = 91;  
		attMagicPower = 10;

		coreSkillMartial = 8;
		coreSkillSecurity = 41;
		coreSkillLabor = 30;
		coreSkillTactics = 16; 
		coreSkillGovernance = 63;
		coreSkillStewardship = 36;
		coreSkillPersuasion = 85;
		coreSkillIntrigue = 28;
		coreSkillDiplomacy= 74; 

		utilitySkillCrafting = 21; 
		utilitySkillHouseKeeping =  89; 
		utilitySkillFarmHand =  47; 
		utilitySkillMedicine =  15;
		utilitySkillAlchemy =  3;
		utilitySkillLearning =  65;
		utilitySkillPerformance =  87;
		utilitySkillEtiquette =  83;
		utilitySkillStreetwise =  11;

		sexSkillMasseuse = 18;
		sexSkillStripping = 0; 
		sexSkillBondage = 0;
		sexSkillPetplay = 0;
		sexSkillPetting = 10;
		sexSkillGroupSex = 0;
		sexSkillPenetration = 0;
		sexSkillWhoring = 0; 
		sexSkillEscorting = 6; 

		attBeauty = 77; //(ugly, plain, good looking, captivating, stunning)
		attTemperament = 85; //(apathethic,cold, reserved, lively, passional)
		attWillpower = 60; // (submissive, docile, humble, assertive, willful)
		attNature = 34; //(spinless, coward, uncertain, brave, determined)
		attOpenness = 22; //(Frigthened, uninterested, timid, open, unashamed)
		attDignity = 62; // how much self worth it has 
		attObedience = 75; 
		attHappiness = 80; 
		attLibido = 25; // 
		attMorality = 90; // how good and bad, it can be corrupt good, it means the person is just twisted
		attPiety = 95;

		bgUpbringC = NPCData.BgUpgring.VeryPoor;


		charGold = 0;


		bgChildhoodC = NPCData.BgChildhood.CharityVolunteer;
		bgAdulthoodC = NPCData.BgAdulthood.Priest;

		bgStory [0] = "";
		bgStory [1] = "";
		bgStory [2] = "";


		charRaceC = NPCData.CharRace.Human; 

		charFurColorC = NPCData.CharFurColor.Gray; 

		charFeatherColorC = NPCData.CharFeatherColor.Gray;

		charSkinColorC = NPCData.CharSkinColor.brown; 

		charSkinTypeC = NPCData.CharSkinType.Human; 

		dickTypeC = NPCData.DickType.human; 

		lowerBackC = NPCData.LowerBack.NONE;

		shoulderBladesC = NPCData.ShoulderBlades.NONE; 

		headTypeC = NPCData.HeadType.HUMAN;

		//tailTypeC = NPCData.TailType.NONE;

		armsTypeC =  NPCData.ArmsType.HUMAN;

		legsTypeC =  NPCData.LegsType.HUMAN;

		headAccesory1C = NPCData.HeadAccesory1.NONE;

		headAccesory2C = NPCData.HeadAccesory2.NONE;

		eyesTypeC = NPCData.EyesType.human0;

		hasFur = false; // everyone uses the fur colours tho
		hasFeathers = false; 
		hasScales = false;
		hasTentacles = false;
		isFlying = false;

		isFurry = false; // to determine portrait 
		isFuta = false; 


		beardStyleC = NPCData.BeardStyle.NONE;

		beardLengthC = NPCData.BeardLength.NONE;

		hairColorC = NPCData.HairColor.brown;

		hairStyleC = NPCData.HairStyle.LongHair;

		hairTypeC = NPCData.HairType.Normal;

		hairLengthCM = 80; 

		hairLengthC = NPCData.HairLength.midback;

		eyesColorC = NPCData.EyesColor.darkBrown;

		genderBehaviorStat = 85;
		genderBehaviorC = npcSettlerPersonAtt.setGenderBehavior(genderBehaviorStat);

		facialFeaturesStat = 85; 
		facialFeaturesC = npcSettlerHead.setFacialFeat(facialFeaturesStat); 

		bodyFeaturesStat= 85; 
		bodyFeaturesC = npcSettlerBody.setBodyFeatures(facialFeaturesStat); 

		heightChar = 155; // in cm
		heightNameC = npcSettlerBody.setHeightName(heightChar);


		bodyPhysStat = 1; // to change it, 0 to 100
		bodyPhysiqueC = npcSettlerBody.setBodyPhysique(bodyPhysStat); 

		bodyBuildStat = 1; // to change it
		bodyBuildC= npcSettlerBody.setBodyBuild(bodyBuildStat); 


		dickNum = 0; //how many dicks it has
		dickSizeCM = 0; // in cm
		dickSizeC = NPCData.DickSize.NONE; 


		testicleSizeCM = 0; 
		testiclesSizeC = NPCData.TesticleSize.NONE; // in cm, used to determine if you have or not

		clitorisSize = 1.5f;



		breastRow = 1; 
		breast1Size = 1; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler
		breast2Size = 0; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler

		breast1NameC = npcSettlerBody.setBreastName (breast1Size);
		breast2NameC = npcSettlerBody.setBreastName (breast2Size);

		breast1CupC = npcSettlerBody.setBreastCup (breast1Size);
		breast2CupC = npcSettlerBody.setBreastCup (breast2Size);

		areola1Size = npcSettlerBody.setAureoleSize(); // aerola size of the first row, 1 change, in cm
		areola2Size = areola1Size; // aerola size of the first row, 1 change, in cm




		waistSize = 1; 
		waistNameC = npcSettlerBody.setWaistName(waistSize); 

		hipsSize = 1; 
		hipsNameC = npcSettlerBody.setHipsName(hipsSize); 

		assSize = 3; 
		assNameC = npcSettlerBody.setAssName(assSize); 


		hasKnot = false; 
		hasVagina = true; 
		isVirgin = false; 
		isFertile = true; 
		charFertility = 0.5f; 
		//isPregnant = npcSettlerFertility.isPregnant(pregnantselector, charSexC); 
		childRaceC = NPCData.CharRace.Human; 
		pregnantCD = 0; // turns until giving birth
		pregnantText = ""; // 
		isLactating = false;
		lactationML = 350; // how much it lactates in ml

		vagLooseness = 1;
		vagLoose = NPCData.VagLoose.thight;


		maxHealth = 90;
		currentHealth = maxHealth; 

		maxArousal = 110; 
		currentArousal = 0; 

		maxMP = 0;
		currentMP = maxMP; 


		int i = 0;
		while (i < 12) {
			charEquipment[i] = npcSettlerEquip.setCharEquipment(i, bgUpbringC, charClassC, charRaceC);
			i++; 
		}

		// power and politics 
		charReputation = 95; 
		politicalPower = 120;

		charAgeC = NPCData.CharAge.YoungAdult;	


		charLoyalty = 65;
		charCorruption = 17;
		corruptionStage = 0;

		i = 0;
		while (i < 8) {
			charAddictions [i] = 0;
			i++;

		}

		charValue = 0;

		TempList.Clear();

		setChar();

		TempList [0].charTraits.Add (NPCData.CharTraits.Administrator); 
		TempList [0].charTraits.Add (NPCData.CharTraits.Affable); 
		TempList [0].charTraits.Add (NPCData.CharTraits.Clumsy);
		TempList [0].charTraits.Add (NPCData.CharTraits.Honest); 

		NPCCharList.CharFollower.Add (TempList [0]);
		Debug.Log ("Itzel created");
	}


	void charVivica(){



		charID = 8000; 
		charPortrait = 8050;
		charSexC  = NPCData.CharSex.Woman; 
		charName = "Vivica";
		charSurname = "";
		charGenderC = NPCData.CharGender.FEMALE;
		cityFactionC = NPCData.CityFaction.MC;

		isRecruited = false;
		isEnemy = false;
		isMonster = false;
		isPrisoner = false;
		isNeutral = false;

		cityPositionC = NPCData.Jobs.RETAINER;

		charClassC = NPCData.CharClass.DarkPaladin;

		charRankC = NPCData.CharRank.S;

		charFetishC = NPCData.CharFetish.Incest;

		charPersonalityC = NPCData.CharPersonality.Belligerent; 

		attPhysical = 65;  
		attMental = 82;
		attSocial = 36;  
		attMagicPower = 80;

		coreSkillMartial = 72; //0
		coreSkillSecurity = 54;
		coreSkillLabor = 2;
		coreSkillTactics = 86; 
		coreSkillGovernance = 20;
		coreSkillStewardship = 22;
		coreSkillPersuasion = 22;
		coreSkillIntrigue = 88;
		coreSkillDiplomacy= 12; 

		utilitySkillCrafting = 10; 
		utilitySkillHouseKeeping =  5; 
		utilitySkillFarmHand =  8; 
		utilitySkillMedicine =  46;
		utilitySkillAlchemy =  75;
		utilitySkillLearning =  82;
		utilitySkillPerformance =  15;
		utilitySkillEtiquette =  32;
		utilitySkillStreetwise =  87;

		sexSkillMasseuse = 8;
		sexSkillStripping = 0; 
		sexSkillBondage = 72;
		sexSkillPetplay = 80;
		sexSkillPetting = 12;
		sexSkillGroupSex = 0;
		sexSkillPenetration = 0;
		sexSkillWhoring = 0; 
		sexSkillEscorting = 15; 

		attBeauty = 87; //(ugly, plain, good looking, captivating, stunning)
		attTemperament = 85; //(apathethic,cold, reserved, lively, passional)
		attWillpower = 90; // (submissive, docile, humble, assertive, willful)
		attNature = 84; //(spinless, coward, uncertain, brave, determined)
		attOpenness = 72; //(Frigthened, uninterested, timid, open, unashamed)
		attDignity = 98; // how much self worth it has 
		attObedience = 10; 
		attHappiness = 35; 
		attLibido = 50; // 
		attMorality = 12; // how good and bad, it can be corrupt good, it means the person is just twisted
		attPiety = 8;

		bgUpbringC = NPCData.BgUpgring.VeryRich;


		charGold = 0;


		bgChildhoodC = NPCData.BgChildhood.NobleFamily;
		bgAdulthoodC = NPCData.BgAdulthood.DarkMage;

		bgStory [0] = "";
		bgStory [1] = "";
		bgStory [2] = "";


		charRaceC = NPCData.CharRace.succubus; 

		charFurColorC = NPCData.CharFurColor.Gray; 

		charFeatherColorC = NPCData.CharFeatherColor.Gray;

		charSkinColorC = NPCData.CharSkinColor.red; 

		charSkinTypeC = NPCData.CharSkinType.Demon; 

		dickTypeC = NPCData.DickType.human; 

		lowerBackC = NPCData.LowerBack.demon;

		shoulderBladesC = NPCData.ShoulderBlades.DemonWings; 

		headTypeC = NPCData.HeadType.HUMAN;

		//tailTypeC = NPCData.TailType.NONE;

		armsTypeC =  NPCData.ArmsType.HUMAN;

		legsTypeC =  NPCData.LegsType.HUMAN;

		headAccesory1C = NPCData.HeadAccesory1.DemonicHorns;

		headAccesory2C = NPCData.HeadAccesory2.NONE;

		eyesTypeC = NPCData.EyesType.demon0;

		hasFur = false; // everyone uses the fur colours tho
		hasFeathers = false; 
		hasScales = false;
		hasTentacles = true;
		isFlying = true;

		isFurry = false; // to determine portrait 
		isFuta = false; 


		beardStyleC = NPCData.BeardStyle.NONE;

		beardLengthC = NPCData.BeardLength.NONE;

		hairColorC = NPCData.HairColor.white;

		hairStyleC = NPCData.HairStyle.LongPonytails;

		hairTypeC = NPCData.HairType.Normal;

		hairLengthCM = 52; 

		hairLengthC = NPCData.HairLength.midback;

		eyesColorC = NPCData.EyesColor.yellow;

		genderBehaviorStat = 85;
		genderBehaviorC = npcSettlerPersonAtt.setGenderBehavior(genderBehaviorStat);

		facialFeaturesStat = 85; 
		facialFeaturesC = npcSettlerHead.setFacialFeat(facialFeaturesStat); 

		bodyFeaturesStat= 85; 
		bodyFeaturesC = npcSettlerBody.setBodyFeatures(facialFeaturesStat); 

		heightChar = 162; // in cm
		heightNameC = npcSettlerBody.setHeightName(heightChar);


		bodyPhysStat = 2; // to change it, 0 to 100
		bodyPhysiqueC = npcSettlerBody.setBodyPhysique(bodyPhysStat); 

		bodyBuildStat = 5; // to change it
		bodyBuildC= npcSettlerBody.setBodyBuild(bodyBuildStat); 


		dickNum = 0; //how many dicks it has
		dickSizeCM = 0; // in cm
		dickSizeC = NPCData.DickSize.NONE; 


		testicleSizeCM = 0; 
		testiclesSizeC = NPCData.TesticleSize.NONE; // in cm, used to determine if you have or not

		clitorisSize = 1.5f;



		breastRow = 1; 
		breast1Size = 2; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler
		breast2Size = 0; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler

		breast1NameC = npcSettlerBody.setBreastName (breast1Size);
		breast2NameC = npcSettlerBody.setBreastName (breast2Size);

		breast1CupC = npcSettlerBody.setBreastCup (breast1Size);
		breast2CupC = npcSettlerBody.setBreastCup (breast2Size);

		areola1Size = npcSettlerBody.setAureoleSize(); // aerola size of the first row, 1 change, in cm
		areola2Size = areola1Size; // aerola size of the first row, 1 change, in cm




		waistSize = 2; 
		waistNameC = npcSettlerBody.setWaistName(waistSize); 

		hipsSize = 2; 
		hipsNameC = npcSettlerBody.setHipsName(hipsSize); 

		assSize = 3; 
		assNameC = npcSettlerBody.setAssName(assSize); 


		hasKnot = false; 
		hasVagina = true; 
		isVirgin = false; 
		isFertile = true; 
		charFertility = 0.5f; 
		//isPregnant = npcSettlerFertility.isPregnant(pregnantselector, charSexC); 
		childRaceC = NPCData.CharRace.Human; 
		pregnantCD = 0; // turns until giving birth
		pregnantText = ""; // 
		isLactating = false;
		lactationML = 350; // how much it lactates in ml

		vagLooseness = 1;
		vagLoose = NPCData.VagLoose.thight;


		maxHealth = 90;
		currentHealth = maxHealth; 

		maxArousal = 110; 
		currentArousal = 0; 

		maxMP = 0;
		currentMP = maxMP; 


		int i = 0;
		while (i < 12) {
			charEquipment[i] = npcSettlerEquip.setCharEquipment(i, bgUpbringC, charClassC, charRaceC);
			i++; 
		}

		// power and politics 
		charReputation = -250; 
		politicalPower = 220;

		charAgeC = NPCData.CharAge.YoungAdult;	


		charLoyalty = 65;
		charCorruption = 57;
		corruptionStage = 0;

		i = 0;
		while (i < 8) {
			charAddictions [i] = 0;
			i++;

		}

		charValue = 0;

		TempList.Clear();

		setChar();

		TempList [0].charTraits.Add (NPCData.CharTraits.Arrogant); 
		TempList [0].charTraits.Add (NPCData.CharTraits.Bloodthirsty); 
		TempList [0].charTraits.Add (NPCData.CharTraits.Deceitful);
		TempList [0].charTraits.Add (NPCData.CharTraits.Fearless); 

		NPCCharList.CharFollower.Add (TempList [0]);
		Debug.Log ("Vivica created");
	}




	void charVirgil(){



		charID = 9000; 
		charPortrait = 9050;
		charSexC  = NPCData.CharSex.Trap; 
		charName = "Virgil";
		charSurname = "";
		charGenderC = NPCData.CharGender.MALE;
		cityFactionC = NPCData.CityFaction.MC;

		isRecruited = false;
		isEnemy = false;
		isMonster = false;
		isPrisoner = false;
		isNeutral = false;

		cityPositionC = NPCData.Jobs.RETAINER;

		charClassC = NPCData.CharClass.CommunityWorker;

		charRankC = NPCData.CharRank.S;

		charFetishC = NPCData.CharFetish.Crossdressing;

		charPersonalityC = NPCData.CharPersonality.Shy; 

		attPhysical = 26;  
		attMental = 71;
		attSocial = 52;  
		attMagicPower = 0;

		coreSkillMartial = 8; //0
		coreSkillSecurity = 72;
		coreSkillLabor = 32;
		coreSkillTactics = 87; 
		coreSkillGovernance = 27;
		coreSkillStewardship = 76;
		coreSkillPersuasion = 18;
		coreSkillIntrigue = 22;
		coreSkillDiplomacy= 65; 

		utilitySkillCrafting = 50; 
		utilitySkillHouseKeeping =  65; 
		utilitySkillFarmHand =  10; 
		utilitySkillMedicine =  14;
		utilitySkillAlchemy =  12;
		utilitySkillLearning =  80;
		utilitySkillPerformance =  88;
		utilitySkillEtiquette =  80;
		utilitySkillStreetwise =  6;

		sexSkillMasseuse = 0;
		sexSkillStripping = 40; 
		sexSkillBondage = 15;
		sexSkillPetplay = 56;
		sexSkillPetting = 10;
		sexSkillGroupSex = 24;
		sexSkillPenetration = 12;
		sexSkillWhoring = 0; 
		sexSkillEscorting = 26; 

		attBeauty = 62; //(ugly, plain, good looking, captivating, stunning)
		attTemperament = 52; //(apathethic,cold, reserved, lively, passional)
		attWillpower = 15; // (submissive, docile, humble, assertive, willful)
		attNature = 22; //(spinless, coward, uncertain, brave, determined)
		attOpenness = 48; //(Frigthened, uninterested, timid, open, unashamed)
		attDignity = 28; // how much self worth it has 
		attObedience = 76; 
		attHappiness = 35; 
		attLibido = 65; // 
		attMorality = 78; // how good and bad, it can be corrupt good, it means the person is just twisted
		attPiety = 69;

		bgUpbringC = NPCData.BgUpgring.VeryPoor;


		charGold = 0;


		bgChildhoodC = NPCData.BgChildhood.Bookworm;
		bgAdulthoodC = NPCData.BgAdulthood.Academic;

		bgStory [0] = "";
		bgStory [1] = "";
		bgStory [2] = "";


		charRaceC = NPCData.CharRace.wallaby; 

		charFurColorC = NPCData.CharFurColor.khaki; 

		charFeatherColorC = NPCData.CharFeatherColor.Gray;

		charSkinColorC = NPCData.CharSkinColor.fair; 

		charSkinTypeC = NPCData.CharSkinType.Human; 

		dickTypeC = NPCData.DickType.human; 

		lowerBackC = NPCData.LowerBack.wallaby;

		shoulderBladesC = NPCData.ShoulderBlades.NONE; 

		headTypeC = NPCData.HeadType.wallaby;

		//tailTypeC = NPCData.TailType.NONE;

		armsTypeC =  NPCData.ArmsType.HUMAN;

		legsTypeC =  NPCData.LegsType.HUMAN;

		headAccesory1C = NPCData.HeadAccesory1.NONE;

		headAccesory2C = NPCData.HeadAccesory2.NONE;

		eyesTypeC = NPCData.EyesType.human0;

		hasFur = true; // everyone uses the fur colours tho
		hasFeathers = false; 
		hasScales = false;
		hasTentacles = false;
		isFlying = false;

		isFurry = true; // to determine portrait 
		isFuta = false; 


		beardStyleC = NPCData.BeardStyle.NONE;

		beardLengthC = NPCData.BeardLength.NONE;

		hairColorC = NPCData.HairColor.blonde;

		hairStyleC = NPCData.HairStyle.CombOver;

		hairTypeC = NPCData.HairType.Normal;

		hairLengthCM = 22; 

		hairLengthC = NPCData.HairLength.sshort;

		eyesColorC = NPCData.EyesColor.green;

		genderBehaviorStat = 75;
		genderBehaviorC = npcSettlerPersonAtt.setGenderBehavior(genderBehaviorStat);

		facialFeaturesStat = 75; 
		facialFeaturesC = npcSettlerHead.setFacialFeat(facialFeaturesStat); 

		bodyFeaturesStat= 75; 
		bodyFeaturesC = npcSettlerBody.setBodyFeatures(facialFeaturesStat); 

		heightChar = 164; // in cm
		heightNameC = npcSettlerBody.setHeightName(heightChar);


		bodyPhysStat = 2; // to change it, 0 to 100
		bodyPhysiqueC = npcSettlerBody.setBodyPhysique(bodyPhysStat); 

		bodyBuildStat = 2; // to change it
		bodyBuildC= npcSettlerBody.setBodyBuild(bodyBuildStat); 


		dickNum = 1; //how many dicks it has
		dickSizeCM = 14; // in cm
		dickSizeC = npcSettlerBody.setDickSize(dickSizeCM);


		testicleSizeCM = 10; 
		testiclesSizeC = npcSettlerBody.setTesticlesSize (testicleSizeCM);// in cm, used to determine if you have or not

		clitorisSize = 0f;



		breastRow = 1; 
		breast1Size = 0; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler
		breast2Size = 0; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler

		breast1NameC = npcSettlerBody.setBreastName (breast1Size);
		breast2NameC = npcSettlerBody.setBreastName (breast2Size);

		breast1CupC = npcSettlerBody.setBreastCup (breast1Size);
		breast2CupC = npcSettlerBody.setBreastCup (breast2Size);

		areola1Size = npcSettlerBody.setAureoleSize(); // aerola size of the first row, 1 change, in cm
		areola2Size = areola1Size; // aerola size of the first row, 1 change, in cm




		waistSize = 2; 
		waistNameC = npcSettlerBody.setWaistName(waistSize); 

		hipsSize = 2; 
		hipsNameC = npcSettlerBody.setHipsName(hipsSize); 

		assSize = 3; 
		assNameC = npcSettlerBody.setAssName(assSize); 


		hasKnot = false; 
		hasVagina = false; 
		isVirgin = true; 
		isFertile = true; 
		charFertility = 0.5f; 
		//isPregnant = npcSettlerFertility.isPregnant(pregnantselector, charSexC); 
		childRaceC = NPCData.CharRace.Human; 
		pregnantCD = 0; // turns until giving birth
		pregnantText = ""; // 
		isLactating = false;
		lactationML = 350; // how much it lactates in ml

		vagLooseness = 1;
		vagLoose = NPCData.VagLoose.thight;


		maxHealth = 90;
		currentHealth = maxHealth; 

		maxArousal = 110; 
		currentArousal = 0; 

		maxMP = 0;
		currentMP = maxMP; 


		int i = 0;
		while (i < 12) {
			charEquipment[i] = npcSettlerEquip.setCharEquipment(i, bgUpbringC, charClassC, charRaceC);
			i++; 
		}

		// power and politics 
		charReputation = 85; 
		politicalPower = 8;

		charAgeC = NPCData.CharAge.YoungAdult;	


		charLoyalty = 80;
		charCorruption = 22;
		corruptionStage = 0;

		i = 0;
		while (i < 8) {
			charAddictions [i] = 0;
			i++;

		}

		charValue = 0;

		TempList.Clear();

		setChar();

		TempList [0].charTraits.Add (NPCData.CharTraits.Honest); 
		TempList [0].charTraits.Add (NPCData.CharTraits.Hopeful); 
		TempList [0].charTraits.Add (NPCData.CharTraits.Humble);
		TempList [0].charTraits.Add (NPCData.CharTraits.Affable); 

		NPCCharList.CharFollower.Add (TempList [0]);
		Debug.Log ("Virgil created");
	}


	void charCelia(){



		charID = 10000; 
		charPortrait = 10050;
		charSexC  = NPCData.CharSex.Futanari; 
		charName = "Celia";
		charSurname = "";
		charGenderC = NPCData.CharGender.FEMALE;
		cityFactionC = NPCData.CityFaction.MC;

		isRecruited = false;
		isEnemy = false;
		isMonster = false;
		isPrisoner = false;
		isNeutral = false;

		cityPositionC = NPCData.Jobs.MINISTER;

		charClassC = NPCData.CharClass.Scholar;

		charRankC = NPCData.CharRank.S;

		charFetishC = NPCData.CharFetish.GroupSex;

		charPersonalityC = NPCData.CharPersonality.Harsh; 

		attPhysical = 45;  
		attMental = 74;
		attSocial = 70;  
		attMagicPower = 0;

		coreSkillMartial = 12; //0
		coreSkillSecurity = 72;
		coreSkillLabor = 15;
		coreSkillTactics = 27; 
		coreSkillGovernance = 70;
		coreSkillStewardship = 83;
		coreSkillPersuasion = 45;
		coreSkillIntrigue = 80;
		coreSkillDiplomacy= 74; 

		utilitySkillCrafting = 21; 
		utilitySkillHouseKeeping =  22; 
		utilitySkillFarmHand =  12; 
		utilitySkillMedicine =  15;
		utilitySkillAlchemy =  0;
		utilitySkillLearning =  75;
		utilitySkillPerformance =  32;
		utilitySkillEtiquette =  70;
		utilitySkillStreetwise =  52;

		sexSkillMasseuse = 20;
		sexSkillStripping = 0; 
		sexSkillBondage = 25;
		sexSkillPetplay = 0;
		sexSkillPetting = 10;
		sexSkillGroupSex = 40;
		sexSkillPenetration = 55;
		sexSkillWhoring = 0; 
		sexSkillEscorting = 6; 

		attBeauty = 82; //(ugly, plain, good looking, captivating, stunning)
		attTemperament = 70; //(apathethic,cold, reserved, lively, passional)
		attWillpower = 82; // (submissive, docile, humble, assertive, willful)
		attNature = 81; //(spinless, coward, uncertain, brave, determined)
		attOpenness = 56; //(Frigthened, uninterested, timid, open, unashamed)
		attDignity = 35; // how much self worth it has 
		attObedience = 27; 
		attHappiness = 52; 
		attLibido = 80; // 
		attMorality = 50; // how good and bad, it can be corrupt good, it means the person is just twisted
		attPiety = 68;

		bgUpbringC = NPCData.BgUpgring.MiddleClass;


		charGold = 0;


		bgChildhoodC = NPCData.BgChildhood.ClerkParent;
		bgAdulthoodC = NPCData.BgAdulthood.Minister;

		bgStory [0] = "";
		bgStory [1] = "";
		bgStory [2] = "";


		charRaceC = NPCData.CharRace.Human; 

		charFurColorC = NPCData.CharFurColor.Gray; 

		charFeatherColorC = NPCData.CharFeatherColor.Gray;

		charSkinColorC = NPCData.CharSkinColor.fair; 

		charSkinTypeC = NPCData.CharSkinType.Human; 

		dickTypeC = NPCData.DickType.human; 

		lowerBackC = NPCData.LowerBack.NONE;

		shoulderBladesC = NPCData.ShoulderBlades.NONE; 

		headTypeC = NPCData.HeadType.HUMAN;

		//tailTypeC = NPCData.TailType.NONE;

		armsTypeC =  NPCData.ArmsType.HUMAN;

		legsTypeC =  NPCData.LegsType.HUMAN;

		headAccesory1C = NPCData.HeadAccesory1.NONE;

		headAccesory2C = NPCData.HeadAccesory2.NONE;

		eyesTypeC = NPCData.EyesType.human0;

		hasFur = false; // everyone uses the fur colours tho
		hasFeathers = false; 
		hasScales = false;
		hasTentacles = false;
		isFlying = false;

		isFurry = false; // to determine portrait 
		isFuta = true; 


		beardStyleC = NPCData.BeardStyle.NONE;

		beardLengthC = NPCData.BeardLength.NONE;

		hairColorC = NPCData.HairColor.black;

		hairStyleC = NPCData.HairStyle.LongHair;

		hairTypeC = NPCData.HairType.Normal;

		hairLengthCM = 62; 

		hairLengthC = NPCData.HairLength.overgrown;

		eyesColorC = NPCData.EyesColor.black;

		genderBehaviorStat = 65;
		genderBehaviorC = npcSettlerPersonAtt.setGenderBehavior(genderBehaviorStat);

		facialFeaturesStat = 85; 
		facialFeaturesC = npcSettlerHead.setFacialFeat(facialFeaturesStat); 

		bodyFeaturesStat= 85;
		bodyFeaturesC = npcSettlerBody.setBodyFeatures(facialFeaturesStat); 

		heightChar = 175; // in cm
		heightNameC = npcSettlerBody.setHeightName(heightChar);


		bodyPhysStat = 3; // to change it, 0 to 100
		bodyPhysiqueC = npcSettlerBody.setBodyPhysique(bodyPhysStat); 

		bodyBuildStat = 3; // to change it
		bodyBuildC= npcSettlerBody.setBodyBuild(bodyBuildStat); 


		dickNum = 1; //how many dicks it has
		dickSizeCM = 22; // in cm
		dickSizeC = npcSettlerBody.setDickSize(dickSizeCM); 


		testicleSizeCM = 12; 
		testiclesSizeC = npcSettlerBody.setTesticlesSize(testicleSizeCM); // in cm, used to determine if you have or not

		clitorisSize = 1.5f;



		breastRow = 1; 
		breast1Size = 12; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler
		breast2Size = 0; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler

		breast1NameC = npcSettlerBody.setBreastName (breast1Size);
		breast2NameC = npcSettlerBody.setBreastName (breast2Size);

		breast1CupC = npcSettlerBody.setBreastCup (breast1Size);
		breast2CupC = npcSettlerBody.setBreastCup (breast2Size);

		areola1Size = npcSettlerBody.setAureoleSize(); // aerola size of the first row, 1 change, in cm
		areola2Size = areola1Size; // aerola size of the first row, 1 change, in cm




		waistSize = 3; 
		waistNameC = npcSettlerBody.setWaistName(waistSize); 

		hipsSize = 3; 
		hipsNameC = npcSettlerBody.setHipsName(hipsSize); 

		assSize = 5; 
		assNameC = npcSettlerBody.setAssName(assSize); 


		hasKnot = false; 
		hasVagina =  true; 
		isVirgin = false; 
		isFertile = true; 
		charFertility = 0.5f; 
		//isPregnant = npcSettlerFertility.isPregnant(pregnantselector, charSexC); 
		childRaceC = NPCData.CharRace.Human; 
		pregnantCD = 0; // turns until giving birth
		pregnantText = ""; // 
		isLactating = false;
		lactationML = 350; // how much it lactates in ml

		vagLooseness = 1;
		vagLoose = NPCData.VagLoose.thight;


		maxHealth = 90;
		currentHealth = maxHealth; 

		maxArousal = 110; 
		currentArousal = 0; 

		maxMP = 0;
		currentMP = maxMP; 


		int i = 0;
		while (i < 12) {
			charEquipment[i] = npcSettlerEquip.setCharEquipment(i, bgUpbringC, charClassC, charRaceC);
			i++; 
		}

		// power and politics 
		charReputation = -125; 
		politicalPower = 352;

		charAgeC = NPCData.CharAge.Adult;	


		charLoyalty = 45;
		charCorruption = 36;
		corruptionStage = 0;

		i = 0;
		while (i < 8) {
			charAddictions [i] = 0;
			i++;

		}

		charValue = 0;

		TempList.Clear();

		setChar();

		TempList [0].charTraits.Add (NPCData.CharTraits.Administrator); 
		TempList [0].charTraits.Add (NPCData.CharTraits.Affable); 
		TempList [0].charTraits.Add (NPCData.CharTraits.Clumsy);
		TempList [0].charTraits.Add (NPCData.CharTraits.Honest); 

		NPCCharList.CharFollower.Add (TempList [0]);
		Debug.Log ("Celia created");
	}

	void charLucretius(){

		charID = 11000; 
		charPortrait = 11050;
		charSexC  = NPCData.CharSex.Trap; 
		charName = "Lucretius";
		charSurname = "";
		charGenderC = NPCData.CharGender.MALE;
		cityFactionC = NPCData.CityFaction.MC;

		isRecruited = false;
		isEnemy = false;
		isMonster = false;
		isPrisoner = false;
		isNeutral = false;

		cityPositionC = NPCData.Jobs.GRANDALCHEMIST;

		charClassC = NPCData.CharClass.Alchemist;

		charRankC = NPCData.CharRank.S;

		charFetishC = NPCData.CharFetish.Monsters;

		charPersonalityC = NPCData.CharPersonality.Courteous; 

		attPhysical = 12;  
		attMental = 97;
		attSocial = 33;  
		attMagicPower = 0;

		coreSkillMartial = 0; //0
		coreSkillSecurity = 22;
		coreSkillLabor = 12;
		coreSkillTactics = 47; 
		coreSkillGovernance = 37;
		coreSkillStewardship = 60;
		coreSkillPersuasion = 36;
		coreSkillIntrigue = 65;
		coreSkillDiplomacy= 28; 

		utilitySkillCrafting = 70; 
		utilitySkillHouseKeeping =  32; 
		utilitySkillFarmHand =  33; 
		utilitySkillMedicine =  81;
		utilitySkillAlchemy =  95;
		utilitySkillLearning =  96;
		utilitySkillPerformance =  7;
		utilitySkillEtiquette =  68;
		utilitySkillStreetwise =  50;

		sexSkillMasseuse = 45;
		sexSkillStripping = 12; 
		sexSkillBondage = 79;
		sexSkillPetplay = 20;
		sexSkillPetting = 10;
		sexSkillGroupSex = 45;
		sexSkillPenetration = 60;
		sexSkillWhoring = 0; 
		sexSkillEscorting = 18; 

		attBeauty = 85; //(ugly, plain, good looking, captivating, stunning)
		attTemperament = 75; //(apathethic,cold, reserved, lively, passional)
		attWillpower = 68; // (submissive, docile, humble, assertive, willful)
		attNature = 28; //(spinless, coward, uncertain, brave, determined)
		attOpenness = 65; //(Frigthened, uninterested, timid, open, unashamed)
		attDignity = 100; // how much self worth it has 
		attObedience = 37; 
		attHappiness = 45; 
		attLibido = 85; // 
		attMorality = 50; // how good and bad, it can be corrupt good, it means the person is just twisted
		attPiety = 6;

		bgUpbringC = NPCData.BgUpgring.Rich;


		charGold = 0;


		bgChildhoodC = NPCData.BgChildhood.Bookworm;
		bgAdulthoodC = NPCData.BgAdulthood.Alchemist;

		bgStory [0] = "";
		bgStory [1] = "";
		bgStory [2] = "";


		charRaceC = NPCData.CharRace.doll; 

		charFurColorC = NPCData.CharFurColor.Gray; 

		charFeatherColorC = NPCData.CharFeatherColor.Gray;

		charSkinColorC = NPCData.CharSkinColor.porcelainWhite; 

		charSkinTypeC = NPCData.CharSkinType.Porcelain; 

		dickTypeC = NPCData.DickType.human; 

		lowerBackC = NPCData.LowerBack.NONE;

		shoulderBladesC = NPCData.ShoulderBlades.NONE; 

		headTypeC = NPCData.HeadType.HUMAN;

		//tailTypeC = NPCData.TailType.NONE;

		armsTypeC =  NPCData.ArmsType.HUMAN;

		legsTypeC =  NPCData.LegsType.HUMAN;

		headAccesory1C = NPCData.HeadAccesory1.NONE;

		headAccesory2C = NPCData.HeadAccesory2.NONE;

		eyesTypeC = NPCData.EyesType.human0;

		hasFur = false; // everyone uses the fur colours tho
		hasFeathers = false; 
		hasScales = false;
		hasTentacles = false;
		isFlying = false;

		isFurry = false; // to determine portrait 
		isFuta = false; 


		beardStyleC = NPCData.BeardStyle.NONE;

		beardLengthC = NPCData.BeardLength.NONE;

		hairColorC = NPCData.HairColor.black;

		hairStyleC = NPCData.HairStyle.bob;

		hairTypeC = NPCData.HairType.Normal;

		hairLengthCM = 35; 

		hairLengthC = NPCData.HairLength.overshoulder;

		eyesColorC = NPCData.EyesColor.blue;

		genderBehaviorStat = 55;
		genderBehaviorC = npcSettlerPersonAtt.setGenderBehavior(genderBehaviorStat);

		facialFeaturesStat = 65; 
		facialFeaturesC = npcSettlerHead.setFacialFeat(facialFeaturesStat); 

		bodyFeaturesStat= 65; 
		bodyFeaturesC = npcSettlerBody.setBodyFeatures(facialFeaturesStat); 

		heightChar = 160; // in cm
		heightNameC = npcSettlerBody.setHeightName(heightChar);


		bodyPhysStat = 1; // to change it, 0 to 100
		bodyPhysiqueC = npcSettlerBody.setBodyPhysique(bodyPhysStat); 

		bodyBuildStat = 1; // to change it
		bodyBuildC= npcSettlerBody.setBodyBuild(bodyBuildStat); 


		dickNum = 1; //how many dicks it has
		dickSizeCM = 22; // in cm
		dickSizeC = npcSettlerBody.setDickSize(dickSizeCM); 


		testicleSizeCM = 10; 
		testiclesSizeC = npcSettlerBody.setTesticlesSize(testicleSizeCM); // in cm, used to determine if you have or not

		clitorisSize = 0f;



		breastRow = 1; 
		breast1Size = 0; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler
		breast2Size = 0; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler

		breast1NameC = npcSettlerBody.setBreastName (breast1Size);
		breast2NameC = npcSettlerBody.setBreastName (breast2Size);

		breast1CupC = npcSettlerBody.setBreastCup (breast1Size);
		breast2CupC = npcSettlerBody.setBreastCup (breast2Size);

		areola1Size = npcSettlerBody.setAureoleSize(); // aerola size of the first row, 1 change, in cm
		areola2Size = areola1Size; // aerola size of the first row, 1 change, in cm




		waistSize = 2; 
		waistNameC = npcSettlerBody.setWaistName(waistSize); 

		hipsSize = 2; 
		hipsNameC = npcSettlerBody.setHipsName(hipsSize); 

		assSize = 3; 
		assNameC = npcSettlerBody.setAssName(assSize); 


		hasKnot = false; 
		hasVagina = false; 
		isVirgin = false; 
		isFertile = true; 
		charFertility = 0.5f; 
		//isPregnant = npcSettlerFertility.isPregnant(pregnantselector, charSexC); 
		childRaceC = NPCData.CharRace.Human; 
		pregnantCD = 0; // turns until giving birth
		pregnantText = ""; // 
		isLactating = false;
		lactationML = 350; // how much it lactates in ml

		vagLooseness = 1;
		vagLoose = NPCData.VagLoose.thight;


		maxHealth = 90;
		currentHealth = maxHealth; 

		maxArousal = 110; 
		currentArousal = 0; 

		maxMP = 0;
		currentMP = maxMP; 


		int i = 0;
		while (i < 12) {
			charEquipment[i] = npcSettlerEquip.setCharEquipment(i, bgUpbringC, charClassC, charRaceC);
			i++; 
		}

		// power and politics 
		charReputation = -105; 
		politicalPower = 480;

		charAgeC = NPCData.CharAge.YoungAdult;	


		charLoyalty = 70;
		charCorruption = 40;
		corruptionStage = 0;

		i = 0;
		while (i < 8) {
			charAddictions [i] = 0;
			i++;

		}

		charValue = 0;

		TempList.Clear();

		setChar();

		TempList [0].charTraits.Add (NPCData.CharTraits.Crook); 
		TempList [0].charTraits.Add (NPCData.CharTraits.Diligent); 
		TempList [0].charTraits.Add (NPCData.CharTraits.Forceful);
		TempList [0].charTraits.Add (NPCData.CharTraits.Hedonist); 

		NPCCharList.CharFollower.Add (TempList [0]);
		Debug.Log ("Lucretius created");
	}

	public void charFaustina(){



		charID = 12000; 
		charPortrait = 12050;
		charSexC  = NPCData.CharSex.Futanari; 
		charName = "Faustina";
		charSurname = "";
		charGenderC = NPCData.CharGender.FEMALE;
		cityFactionC = NPCData.CityFaction.MC;

		isRecruited = false;
		isEnemy = false;
		isMonster = false;
		isPrisoner = false;
		isNeutral = false;

		cityPositionC = NPCData.Jobs.GENERAL;

		charClassC = NPCData.CharClass.Paladin;

		charRankC = NPCData.CharRank.S;

		charFetishC = NPCData.CharFetish.Dominant;

		charPersonalityC = NPCData.CharPersonality.Courteous; 

		attPhysical = 95;  
		attMental = 55;
		attSocial = 78;  
		attMagicPower = 0;

		coreSkillMartial = 100; //0
		coreSkillSecurity = 65;
		coreSkillLabor = 20;
		coreSkillTactics = 70; 
		coreSkillGovernance = 15;
		coreSkillStewardship = 38;
		coreSkillPersuasion = 62;
		coreSkillIntrigue = 15;
		coreSkillDiplomacy= 48; 

		utilitySkillCrafting = 45; 
		utilitySkillHouseKeeping =  30; 
		utilitySkillFarmHand =  41; 
		utilitySkillMedicine = 32;
		utilitySkillAlchemy =  0;
		utilitySkillLearning =  35;
		utilitySkillPerformance =  12;
		utilitySkillEtiquette =  88;
		utilitySkillStreetwise =  18;

		sexSkillMasseuse = 25;
		sexSkillStripping = 28; 
		sexSkillBondage = 92;
		sexSkillPetplay = 68;
		sexSkillPetting = 20;
		sexSkillGroupSex = 35;
		sexSkillPenetration = 70;
		sexSkillWhoring = 0; 
		sexSkillEscorting = 0; 

		attBeauty = 76; //(ugly, plain, good looking, captivating, stunning)
		attTemperament = 85; //(apathethic,cold, reserved, lively, passional)
		attWillpower = 100; // (submissive, docile, humble, assertive, willful)
		attNature = 90; //(spinless, coward, uncertain, brave, determined)
		attOpenness = 25; //(Frigthened, uninterested, timid, open, unashamed)
		attDignity = 100; // how much self worth it has 
		attObedience = 6; 
		attHappiness = 35; 
		attLibido = 25; // 
		attMorality = 50; // how good and bad, it can be corrupt good, it means the person is just twisted
		attPiety = 72;

		bgUpbringC = NPCData.BgUpgring.Rich;


		charGold = 0;


		bgChildhoodC = NPCData.BgChildhood.YoungArmyAuxiliar;
		bgAdulthoodC = NPCData.BgAdulthood.ArmyOfficial;

		bgStory [0] = "";
		bgStory [1] = "";
		bgStory [2] = "";


		charRaceC = NPCData.CharRace.Wolf; 

		charFurColorC = NPCData.CharFurColor.brown; 

		charFeatherColorC = NPCData.CharFeatherColor.Gray;

		charSkinColorC = NPCData.CharSkinColor.fair; 

		charSkinTypeC = NPCData.CharSkinType.Human; 

		dickTypeC = NPCData.DickType.human; 

		lowerBackC = NPCData.LowerBack.wolf;

		shoulderBladesC = NPCData.ShoulderBlades.NONE; 

		headTypeC = NPCData.HeadType.WOLF;

		//tailTypeC = NPCData.TailType.NONE;

		armsTypeC =  NPCData.ArmsType.WOLF;

		legsTypeC =  NPCData.LegsType.WOLF;

		headAccesory1C = NPCData.HeadAccesory1.NONE;

		headAccesory2C = NPCData.HeadAccesory2.NONE;

		eyesTypeC = NPCData.EyesType.human0;

		hasFur = true; // everyone uses the fur colours tho
		hasFeathers = false; 
		hasScales = false;
		hasTentacles = false;
		isFlying = false;

		isFurry = true; // to determine portrait 
		isFuta = true; 


		beardStyleC = NPCData.BeardStyle.NONE;

		beardLengthC = NPCData.BeardLength.NONE;

		hairColorC = NPCData.HairColor.brown;

		hairStyleC = NPCData.HairStyle.ElegantBun;

		hairTypeC = NPCData.HairType.Normal;

		hairLengthCM = 30; 

		hairLengthC = NPCData.HairLength.overshoulder;

		eyesColorC = NPCData.EyesColor.darkBrown;

		genderBehaviorStat = 35;
		genderBehaviorC = npcSettlerPersonAtt.setGenderBehavior(genderBehaviorStat);

		facialFeaturesStat = 85; 
		facialFeaturesC = npcSettlerHead.setFacialFeat(facialFeaturesStat); 

		bodyFeaturesStat= 85; 
		bodyFeaturesC = npcSettlerBody.setBodyFeatures(facialFeaturesStat); 

		heightChar = 178; // in cm
		heightNameC = npcSettlerBody.setHeightName(heightChar);


		bodyPhysStat = 4; //
		bodyPhysiqueC = npcSettlerBody.setBodyPhysique(bodyPhysStat); 

		bodyBuildStat = 7; //
		bodyBuildC= npcSettlerBody.setBodyBuild(bodyBuildStat); 


		dickNum = 1; //how many dicks it has
		dickSizeCM = 26; // in cm
		dickSizeC = npcSettlerBody.setDickSize(dickSizeCM); 


		testicleSizeCM = 12; 
		testiclesSizeC = npcSettlerBody.setTesticlesSize(testicleSizeCM); // in cm, used to determine if you have or not

		clitorisSize = 0f;



		breastRow = 1; 
		breast1Size = 10; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler
		breast2Size = 10; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler

		breast1NameC = npcSettlerBody.setBreastName (breast1Size);
		breast2NameC = npcSettlerBody.setBreastName (breast2Size);

		breast1CupC = npcSettlerBody.setBreastCup (breast1Size);
		breast2CupC = npcSettlerBody.setBreastCup (breast2Size);

		areola1Size = npcSettlerBody.setAureoleSize(); // aerola size of the first row, 1 change, in cm
		areola2Size = areola1Size; // aerola size of the first row, 1 change, in cm




		waistSize = 3; 
		waistNameC = npcSettlerBody.setWaistName(waistSize); 

		hipsSize = 5; 
		hipsNameC = npcSettlerBody.setHipsName(hipsSize); 

		assSize = 5; 
		assNameC = npcSettlerBody.setAssName(assSize); 


		hasKnot = true; 
		hasVagina = true; 
		isVirgin = false; 
		isFertile = true; 
		charFertility = 0.5f; 
		//isPregnant = npcSettlerFertility.isPregnant(pregnantselector, charSexC); 
		childRaceC = NPCData.CharRace.Wolf; 
		pregnantCD = 0; // turns until giving birth
		pregnantText = ""; // 
		isLactating = false;
		lactationML = 350; // how much it lactates in ml

		vagLooseness = 1;
		vagLoose = NPCData.VagLoose.thight;


		maxHealth = 200;
		currentHealth = maxHealth; 

		maxArousal = 120; 
		currentArousal = 0; 

		maxMP = 0;
		currentMP = maxMP; 


		int i = 0;
		while (i < 12) {
			charEquipment[i] = npcSettlerEquip.setCharEquipment(i, bgUpbringC, charClassC, charRaceC);
			i++; 
		}

		// power and politics 
		charReputation = 705; 
		politicalPower = 850;

		charAgeC = NPCData.CharAge.Adult;	


		charLoyalty = 70;
		charCorruption = 10;
		corruptionStage = 0;

		i = 0;
		while (i < 8) {
			charAddictions [i] = 0;
			i++;

		}

		charValue = 0;

		TempList.Clear();

		setChar();

		TempList [0].charTraits.Add (NPCData.CharTraits.Fearless); 
		TempList [0].charTraits.Add (NPCData.CharTraits.Impaler); 
		TempList [0].charTraits.Add (NPCData.CharTraits.Meticulous);
		TempList [0].charTraits.Add (NPCData.CharTraits.Prideful); 

		NPCCharList.CharFollower.Add (TempList [0]);
		Debug.Log ("Faustina created");
	}

	public void charAlba(){



		charID = 13000; 
		charPortrait = 13000;
		charSexC  = NPCData.CharSex.Woman; 
		charName = "Alba";
		charSurname = "";
		charGenderC = NPCData.CharGender.FEMALE;
		cityFactionC = NPCData.CityFaction.MC;

		isRecruited = false;
		isEnemy = false;
		isMonster = false;
		isPrisoner = false;
		isNeutral = false;

		cityPositionC = NPCData.Jobs.FACTIONLEADER;

		charClassC = NPCData.CharClass.Whore;

		charRankC = NPCData.CharRank.S;

		charFetishC = NPCData.CharFetish.GroupSex;

		charPersonalityC = NPCData.CharPersonality.Lewd; 

		attPhysical = 72;  
		attMental = 48;
		attSocial = 82;  
		attMagicPower = 0;

		coreSkillMartial = 56; //0
		coreSkillSecurity = 72;
		coreSkillLabor = 15;
		coreSkillTactics = 30; 
		coreSkillGovernance = 38;
		coreSkillStewardship = 78;
		coreSkillPersuasion = 85;
		coreSkillIntrigue = 89;
		coreSkillDiplomacy= 67; 

		utilitySkillCrafting = 68; 
		utilitySkillHouseKeeping =  0; 
		utilitySkillFarmHand =  21; 
		utilitySkillMedicine = 0;
		utilitySkillAlchemy =  0;
		utilitySkillLearning =  38;
		utilitySkillPerformance =  5;
		utilitySkillEtiquette =  70;
		utilitySkillStreetwise =  65;

		sexSkillMasseuse = 15;
		sexSkillStripping = 35; 
		sexSkillBondage = 32;
		sexSkillPetplay = 20;
		sexSkillPetting = 35;
		sexSkillGroupSex = 80;
		sexSkillPenetration = 70;
		sexSkillWhoring = 15; 
		sexSkillEscorting = 5; 

		attBeauty = 87; //(ugly, plain, good looking, captivating, stunning)
		attTemperament = 85; //(apathethic,cold, reserved, lively, passional)
		attWillpower = 85; // (submissive, docile, humble, assertive, willful)
		attNature = 82; //(spinless, coward, uncertain, brave, determined)
		attOpenness = 100; //(Frigthened, uninterested, timid, open, unashamed)
		attDignity = 92; // how much self worth it has 
		attObedience = 15; 
		attHappiness = 40; 
		attLibido = 80; // 
		attMorality = 25; // how good and bad, it can be corrupt good, it means the person is just twisted
		attPiety = 62;

		bgUpbringC = NPCData.BgUpgring.Rich;


		charGold = 100000;


		bgChildhoodC = NPCData.BgChildhood.BlueBlood;
		bgAdulthoodC = NPCData.BgAdulthood.succMerchant;

		bgStory [0] = "";
		bgStory [1] = "";
		bgStory [2] = "";


		charRaceC = NPCData.CharRace.Baphomet; 

		charFurColorC = NPCData.CharFurColor.brown; 

		charFeatherColorC = NPCData.CharFeatherColor.Gray;

		charSkinColorC = NPCData.CharSkinColor.fair; 

		charSkinTypeC = NPCData.CharSkinType.Human; 

		dickTypeC = NPCData.DickType.human; 

		lowerBackC = NPCData.LowerBack.baphomet;

		shoulderBladesC = NPCData.ShoulderBlades.NONE; 

		headTypeC = NPCData.HeadType.HUMAN;

		//tailTypeC = NPCData.TailType.NONE;

		armsTypeC =  NPCData.ArmsType.BAPHOMETCLAWS;

		legsTypeC =  NPCData.LegsType.hoves;

		headAccesory1C = NPCData.HeadAccesory1.BaphometHorns;

		headAccesory2C = NPCData.HeadAccesory2.NONE;

		eyesTypeC = NPCData.EyesType.human0;

		hasFur = true; // everyone uses the fur colours tho
		hasFeathers = false; 
		hasScales = false;
		hasTentacles = false;
		isFlying = false;

		isFurry = false; // to determine portrait 
		isFuta = false; 


		beardStyleC = NPCData.BeardStyle.NONE;

		beardLengthC = NPCData.BeardLength.NONE;

		hairColorC = NPCData.HairColor.blonde;

		hairStyleC = NPCData.HairStyle.bob;

		hairTypeC = NPCData.HairType.Normal;

		hairLengthCM = 30; 

		hairLengthC = NPCData.HairLength.overshoulder;

		eyesColorC = NPCData.EyesColor.green;

		genderBehaviorStat = 85;
		genderBehaviorC = npcSettlerPersonAtt.setGenderBehavior(genderBehaviorStat);

		facialFeaturesStat = 85; 
		facialFeaturesC = npcSettlerHead.setFacialFeat(facialFeaturesStat); 

		bodyFeaturesStat= 85; 
		bodyFeaturesC = npcSettlerBody.setBodyFeatures(facialFeaturesStat); 

		heightChar = 171; // in cm
		heightNameC = npcSettlerBody.setHeightName(heightChar);


		bodyPhysStat = 4; //
		bodyPhysiqueC = npcSettlerBody.setBodyPhysique(bodyPhysStat); 

		bodyBuildStat = 5; //
		bodyBuildC= npcSettlerBody.setBodyBuild(bodyBuildStat); 


		dickNum = 0; //how many dicks it has
		dickSizeCM = 0; // in cm
		dickSizeC = npcSettlerBody.setDickSize(dickSizeCM); 


		testicleSizeCM = 0; 
		testiclesSizeC = npcSettlerBody.setTesticlesSize(testicleSizeCM); // in cm, used to determine if you have or not

		clitorisSize = 1f;



		breastRow = 1; 
		breast1Size = 0; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler
		breast2Size = 0; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler

		breast1NameC = npcSettlerBody.setBreastName (breast1Size);
		breast2NameC = npcSettlerBody.setBreastName (breast2Size);

		breast1CupC = npcSettlerBody.setBreastCup (breast1Size);
		breast2CupC = npcSettlerBody.setBreastCup (breast2Size);

		areola1Size = npcSettlerBody.setAureoleSize(); // aerola size of the first row, 1 change, in cm
		areola2Size = areola1Size; // aerola size of the first row, 1 change, in cm




		waistSize = 3; 
		waistNameC = npcSettlerBody.setWaistName(waistSize); 

		hipsSize = 5; 
		hipsNameC = npcSettlerBody.setHipsName(hipsSize); 

		assSize = 5; 
		assNameC = npcSettlerBody.setAssName(assSize); 


		hasKnot = false; 
		hasVagina = true; 
		isVirgin = false; 
		isFertile = true; 
		charFertility = 0.5f; 
		//isPregnant = npcSettlerFertility.isPregnant(pregnantselector, charSexC); 
		childRaceC = NPCData.CharRace.Baphomet; 
		pregnantCD = 0; // turns until giving birth
		pregnantText = ""; // 
		isLactating = false;
		lactationML = 350; // how much it lactates in ml

		vagLooseness = 1;
		vagLoose = NPCData.VagLoose.thight;


		maxHealth = 130;
		currentHealth = maxHealth; 

		maxArousal = 180; 
		currentArousal = 0; 

		maxMP = 0;
		currentMP = maxMP; 


		int i = 0;
		while (i < 12) {
			charEquipment[i] = npcSettlerEquip.setCharEquipment(i, bgUpbringC, charClassC, charRaceC);
			i++; 
		}

		// power and politics 
		charReputation = 705; 
		politicalPower = 730;

		charAgeC = NPCData.CharAge.Adult;	


		charLoyalty = 15;
		charCorruption = 28;
		corruptionStage = 0;

		i = 0;
		while (i < 8) {
			charAddictions [i] = 0;
			i++;

		}

		charValue = 0;

		TempList.Clear();

		setChar();

		TempList [0].charTraits.Add (NPCData.CharTraits.Administrator); 
		TempList [0].charTraits.Add (NPCData.CharTraits.Crook); 
		TempList [0].charTraits.Add (NPCData.CharTraits.Distracted);
		TempList [0].charTraits.Add (NPCData.CharTraits.Eccentric); 

		NPCCharList.CharFollower.Add (TempList [0]);
		Debug.Log ("Alba created");
	}

	public void charLuna(){

		charID = 14000; 
		charPortrait = 14000;
		charSexC  = NPCData.CharSex.Futanari; 
		charName = "Luna";
		charSurname = "Daragon";
		charGenderC = NPCData.CharGender.FEMALE;
		cityFactionC = NPCData.CityFaction.MC;

		isRecruited = false;
		isEnemy = false;
		isMonster = false;
		isPrisoner = false;
		isNeutral = false;

		cityPositionC = NPCData.Jobs.FACTIONLEADER;

		charClassC = NPCData.CharClass.Thief;

		charRankC = NPCData.CharRank.S;

		charFetishC = NPCData.CharFetish.Dominant;

		charPersonalityC = NPCData.CharPersonality.Lewd; 

		attPhysical = 92;  
		attMental = 84;
		attSocial = 70;  
		attMagicPower = 0;

		coreSkillMartial = 90; //0
		coreSkillSecurity = 95;
		coreSkillLabor = 17;
		coreSkillTactics = 22; 
		coreSkillGovernance = 30;
		coreSkillStewardship = 82;
		coreSkillPersuasion = 77;
		coreSkillIntrigue = 80;
		coreSkillDiplomacy= 11; 

		utilitySkillCrafting = 0; 
		utilitySkillHouseKeeping =  10; 
		utilitySkillFarmHand =  11; 
		utilitySkillMedicine = 5;
		utilitySkillAlchemy =  12;
		utilitySkillLearning =  18;
		utilitySkillPerformance =  32;
		utilitySkillEtiquette =  40;
		utilitySkillStreetwise =  100;

		sexSkillMasseuse = 15;
		sexSkillStripping = 5; 
		sexSkillBondage = 82;
		sexSkillPetplay = 10;
		sexSkillPetting = 35;
		sexSkillGroupSex = 50;
		sexSkillPenetration = 0;
		sexSkillWhoring = 15; 
		sexSkillEscorting = 22; 

		attBeauty = 90; //(ugly, plain, good looking, captivating, stunning)
		attTemperament = 88; //(apathethic,cold, reserved, lively, passional)
		attWillpower = 100; // (submissive, docile, humble, assertive, willful)
		attNature = 92; //(spinless, coward, uncertain, brave, determined)
		attOpenness = 77; //(Frigthened, uninterested, timid, open, unashamed)
		attDignity = 100; // how much self worth it has 
		attObedience = 0; 
		attHappiness = 72; 
		attLibido = 100; // 
		attMorality = 0; // how good and bad, it can be corrupt good, it means the person is just twisted
		attPiety = 22;

		bgUpbringC = NPCData.BgUpgring.Rich;


		charGold = 100000;


		bgChildhoodC = NPCData.BgChildhood.CriminalFamily;
		bgAdulthoodC = NPCData.BgAdulthood.Criminal;

		bgStory [0] = "";
		bgStory [1] = "";
		bgStory [2] = "";


		charRaceC = NPCData.CharRace.Elf; 

		charFurColorC = NPCData.CharFurColor.blue; 

		charFeatherColorC = NPCData.CharFeatherColor.Gray;

		charSkinColorC = NPCData.CharSkinColor.blue; 

		charSkinTypeC = NPCData.CharSkinType.Human; 

		dickTypeC = NPCData.DickType.human; 

		lowerBackC = NPCData.LowerBack.NONE;

		shoulderBladesC = NPCData.ShoulderBlades.NONE; 

		headTypeC = NPCData.HeadType.HUMAN;

		//tailTypeC = NPCData.TailType.NONE;

		armsTypeC =  NPCData.ArmsType.HUMAN;

		legsTypeC =  NPCData.LegsType.HUMAN;

		headAccesory1C = NPCData.HeadAccesory1.NONE;

		headAccesory2C = NPCData.HeadAccesory2.NONE;

		eyesTypeC = NPCData.EyesType.human0;

		hasFur = false; // everyone uses the fur colours tho
		hasFeathers = false; 
		hasScales = false;
		hasTentacles = false;
		isFlying = false;

		isFurry = false; // to determine portrait 
		isFuta = true; 


		beardStyleC = NPCData.BeardStyle.NONE;

		beardLengthC = NPCData.BeardLength.NONE;

		hairColorC = NPCData.HairColor.platinum;

		hairStyleC = NPCData.HairStyle.LongHair;

		hairTypeC = NPCData.HairType.Normal;

		hairLengthCM = 30; 

		hairLengthC = NPCData.HairLength.overshoulder;

		eyesColorC = NPCData.EyesColor.red;

		genderBehaviorStat = 85;
		genderBehaviorC = npcSettlerPersonAtt.setGenderBehavior(genderBehaviorStat);

		facialFeaturesStat = 85; 
		facialFeaturesC = npcSettlerHead.setFacialFeat(facialFeaturesStat); 

		bodyFeaturesStat= 85; 
		bodyFeaturesC = npcSettlerBody.setBodyFeatures(facialFeaturesStat); 

		heightChar = 171; // in cm
		heightNameC = npcSettlerBody.setHeightName(heightChar);


		bodyPhysStat = 4; //
		bodyPhysiqueC = npcSettlerBody.setBodyPhysique(bodyPhysStat); 

		bodyBuildStat = 5; //
		bodyBuildC= npcSettlerBody.setBodyBuild(bodyBuildStat); 


		dickNum = 0; //how many dicks it has
		dickSizeCM = 0; // in cm
		dickSizeC = npcSettlerBody.setDickSize(dickSizeCM); 


		testicleSizeCM = 0; 
		testiclesSizeC = npcSettlerBody.setTesticlesSize(testicleSizeCM); // in cm, used to determine if you have or not

		clitorisSize = 1f;



		breastRow = 1; 
		breast1Size = 7; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler
		breast2Size = 7; // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler

		breast1NameC = npcSettlerBody.setBreastName (breast1Size);
		breast2NameC = npcSettlerBody.setBreastName (breast2Size);

		breast1CupC = npcSettlerBody.setBreastCup (breast1Size);
		breast2CupC = npcSettlerBody.setBreastCup (breast2Size);

		areola1Size = npcSettlerBody.setAureoleSize(); // aerola size of the first row, 1 change, in cm
		areola2Size = areola1Size; // aerola size of the first row, 1 change, in cm




		waistSize = 3; 
		waistNameC = npcSettlerBody.setWaistName(waistSize); 

		hipsSize = 5; 
		hipsNameC = npcSettlerBody.setHipsName(hipsSize); 

		assSize = 5; 
		assNameC = npcSettlerBody.setAssName(assSize); 


		hasKnot = false; 
		hasVagina = true; 
		isVirgin = false; 
		isFertile = true; 
		charFertility = 0.5f; 
		//isPregnant = npcSettlerFertility.isPregnant(pregnantselector, charSexC); 
		childRaceC = NPCData.CharRace.Elf; 
		pregnantCD = 0; // turns until giving birth
		pregnantText = ""; // 
		isLactating = false;
		lactationML = 350; // how much it lactates in ml

		vagLooseness = 1;
		vagLoose = NPCData.VagLoose.thight;


		maxHealth = 200;
		currentHealth = maxHealth; 

		maxArousal = 180; 
		currentArousal = 0; 

		maxMP = 0;
		currentMP = maxMP; 


		int i = 0;
		while (i < 12) {
			charEquipment[i] = npcSettlerEquip.setCharEquipment(i, bgUpbringC, charClassC, charRaceC);
			i++; 
		}

		// power and politics 
		charReputation = 705; 
		politicalPower = 730;

		charAgeC = NPCData.CharAge.Adult;	


		charLoyalty = 15;
		charCorruption = 28;
		corruptionStage = 0;

		i = 0;
		while (i < 8) {
			charAddictions [i] = 0;
			i++;

		}

		charValue = 0;

		TempList.Clear();

		setChar();

		TempList [0].charTraits.Add (NPCData.CharTraits.Cruel); 
		TempList [0].charTraits.Add (NPCData.CharTraits.Crook); 
		TempList [0].charTraits.Add (NPCData.CharTraits.Exotic);
		TempList [0].charTraits.Add (NPCData.CharTraits.Duelist); 

		NPCCharList.CharFollower.Add (TempList [0]);
		Debug.Log ("Luna created");
	}


	public void createFollowers(){
		charHelena ();
		charAbbadon ();
		charYoshika ();
		charMisaki ();
		charLucina ();
		charItzel (); // 7000
		charVivica ();  // id 8000
		charVirgil (); // id 9000
		charCelia ();  //id 10000
		charLucretius (); // id 11000
		charFaustina (); // id 12000
		charAlba();
		// Alba 13000
		//luna 14000
	}




	// DEBUG DELETE PLEASE
	void Awake(){
		createFollowers ();



	}

}


