using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

public class NPCCreator : MonoBehaviour {

	/// <summary>
	/// WE NEED TO ADD PORTRAITS
	/// </summary>



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
	NPCSettlerAttacks npcSettlerAttacks = new NPCSettlerAttacks();
	NPCSettlerRankAdjustment npcSettlerRankAdjustment = new NPCSettlerRankAdjustment();

	List<NPCData.CharAttacks> attacksTempList = new List <NPCData.CharAttacks> ();

	public static int switchIsChar = 0; // help to set if the char starts as a prisoner, slave, etc. // 0 neutral, 1 recruited, 2 enemy, 3 isprisonerplayer, 4 isprisoner enemy, 5 isslave
	// system to build
	int randNum;
	int randNum2; 
	int hashcode = GameControl.playerName.GetHashCode();
	static int iterator;
	string completeName;
	int i;
	int raceID; // this is just a control, it helps define at the start if its going to be a human, monstergirl or exotic

	Parser parser = new Parser();


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
	public float charLove; // how much it loves the MC 
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

	//public string[] charTattoos = new string[17]; 
	//0 Forehead //1 left cheek //2 righ cheek //3 neck //4 upper chest  
	//5 left breast //6 right breast //7 belly //8 low belly //9 upper back
	//10 lower back //11 left arm //12 right arm  //13 left ass cheek //14 right ass cheek
	//15 left leg //16 right leg //17 anus







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

	public float charCombatAttack = 1f; // it is calculated by its attributes, equipment and traits 
	public float charLustAttack = 1f; 
	public float charCombatDefense;
	public float charLustDefense;
	public float charMagicDefense; 





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
			attPiety, attStyle, charRankC,  charPersonalityC, charFetishC, charClassC,  cityPositionC, coreSkillMartial,  coreSkillSecurity ,
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
			 charReputation,  politicalPower,  charInformation 




 ));



	}



	public void charCreator(int sexselector, int factionselector, int recruitselector, int positionselector, int classselector, int rankselector, 
		int fetishselector, int beautyselector, int upbringselector, int raceselector, int racespecific, bool pregnantselector){
		//public enum CharSex { Woman, Man, Dickgirl, Futanari, Cuntboy, Trap, Eunuch }; // 0 female, trap 5
		// faction: use 0
		//0 recruited, 1 enemy, 2 monster, 3 neutral, 4 your prisoner, 5 your slave
		// use 12 for retainer in position selector, 1000 for none 
		//class: 0 soldier,1 warrior, 2 clerk, 3 bureaucrat, 4 monk/nun, 5 priest, 6 alchemist UNC, 7 mystic UNC, 8 thief, 9 infiltrator, 10 paladin, 11 dark paladin, 12 feral, 13 barbarian 
		//14 scout, 15 ranger, 16 community worker, 17 whore, 18 farmer, 19 industry worker, 20 politician, 21 diplomat, 22 inquisitor, 23 enforcer, 24 Performer, 25 Artist, 26 Scholar
		// 0 C, 1 B, 2 A, 3 S, 1000 random
		//	Fetish: 0 None, 1 Dominant, 2 Submissive, AnalWhore, GroupSex, CumSlut, Incest, Crossdressing, Exhibitionism, PetPlay, RapeFantasy, Voyeurism, Monsters, SizeDifference, 1000 random	
		// beauty selector: 0, 20, 40, etc. up to 80+  enter more or less what you want from 0 to 100, it will be random. Any other number is a random
		//upbring: 	VeryPoor, Poor, MiddleClass, Rich, VeryRich, Noble, Royal, Count, 1000 for random
		// race: 0 human, 1 furry, 2 avian. 3 aquatic, 4 exotics
		//race specific: 0 human, else check list  
		// pregnant selector, use false to have her non pregnant. Need texts for pregnancy before adding this feature
		//race specific: 1000 random, check NPCSettlerRace for info



		charID = NPCControl.NPCGenID;  // id thats going to be used to look for him, should use a genNPC control for this
		NPCControl.NPCGenID += 1;

		charSexC = npcSettlerSex.setSex(sexselector); 
		charName = npcSettlerName.setName (charSexC);
		charSurname = npcSettlerName.setSurname ();
		charGenderC = npcSettlerSex.setGender (charSexC);
		cityFactionC = npcSettlerfaction.setFaction (factionselector);

		isRecruited = npcSettlerSide.recruitStatus (recruitselector);
		isEnemy = npcSettlerSide.enemyStatus (recruitselector);
		isMonster = npcSettlerSide.monsterStatus (recruitselector);
		isPrisoner = npcSettlerSide.prisonerStatus (recruitselector);
		isNeutral = npcSettlerSide.neutralStatus (recruitselector);
		isSlave = npcSettlerSide.slaveStatus (recruitselector);

		cityPositionC = npcSettlerPosition.setPosition (positionselector);

		charClassC = npcSettlerClass.setClass(classselector);

		charRankC = npcSettlerRank.setRank (rankselector);

		charFetishC = npcSettlerFetish.setFetish (fetishselector);

		charPersonalityC = npcSettlerPersonAtt.setPersonality(); 

		attPhysical = npcSettlerAttributes.setPhysical(charClassC);  
		attMental = npcSettlerAttributes.setMental(charClassC); 
		attSocial = npcSettlerAttributes.setSocial(charClassC);  
		attMagicPower = npcSettlerAttributes.setMagicPower (charClassC);

		coreSkillMartial = npcSettlerCoreSkills.setCoreMartial(charClassC); //0
		coreSkillSecurity = npcSettlerCoreSkills.setCoreSecurity(charClassC);
		coreSkillLabor = npcSettlerCoreSkills.setCoreLabor(charClassC);
		coreSkillTactics = npcSettlerCoreSkills.setCoreTactics(charClassC); 
		coreSkillGovernance = npcSettlerCoreSkills.setCoreGovernance(charClassC);
		coreSkillStewardship = npcSettlerCoreSkills.setStewardship(charClassC);
		coreSkillPersuasion = npcSettlerCoreSkills.setCorePersuasion(charClassC);
		coreSkillIntrigue = npcSettlerCoreSkills.setIntrigue(charClassC);
		coreSkillDiplomacy= npcSettlerCoreSkills.setDiplomacy(charClassC); 

		utilitySkillCrafting = npcSettlerUtilitySkills.setUtilityCrafting(charClassC); 
		utilitySkillHouseKeeping =  npcSettlerUtilitySkills.setHouseKeeping(charClassC); 
		utilitySkillFarmHand =  npcSettlerUtilitySkills.setUtilityFarm(charClassC); 
		utilitySkillMedicine =  npcSettlerUtilitySkills.setUtilityMedicine(charClassC);
		utilitySkillAlchemy =  npcSettlerUtilitySkills.setUtilityAlchemy(charClassC);
		utilitySkillLearning =  npcSettlerUtilitySkills.setUtilityLearning(charClassC);
		utilitySkillPerformance =  npcSettlerUtilitySkills.setUtilityPerformance(charClassC);
		utilitySkillEtiquette =  npcSettlerUtilitySkills.setUtilityEtiquette(charClassC);
		utilitySkillStreetwise =  npcSettlerUtilitySkills.setUtilityStreetwise(charClassC);

		sexSkillMasseuse = npcSettlerSexSkills.setSkillMasseuse(charClassC);
		sexSkillStripping = npcSettlerSexSkills.setSkillStripping(charClassC); 
		sexSkillBondage = npcSettlerSexSkills.setSkillBondage(charClassC);
		sexSkillPetplay = npcSettlerSexSkills.setSkillPetPlay(charClassC);
		sexSkillPetting = npcSettlerSexSkills.setSkillPetting(charClassC);
		sexSkillGroupSex = npcSettlerSexSkills.setSkillGroupSex(charClassC);
		sexSkillPenetration = npcSettlerSexSkills.setSkillDemonstration(charClassC);
		sexSkillWhoring = npcSettlerSexSkills.setSkillWhoring(charClassC); 
		sexSkillEscorting = npcSettlerSexSkills.setSkillEscorting(charClassC); 

		attBeauty = npcSettlerPersonAtt.setBeauty(beautyselector); //(ugly, plain, good looking, captivating, stunning)
		attTemperament = npcSettlerPersonAtt.setTemperament(charClassC); //(apathethic,cold, reserved, lively, passional)
		attWillpower = npcSettlerPersonAtt.setWillpower(charClassC); // (submissive, docile, humble, assertive, willful)
		attNature = npcSettlerPersonAtt.setNature(charClassC); //(spinless, coward, uncertain, brave, determined)
		attOpenness = npcSettlerPersonAtt.setOpenness(charClassC); //(Frigthened, uninterested, timid, open, unashamed)
		attDignity = npcSettlerPersonAtt.setDignity(charClassC); // how much self worth it has 
		attObedience = npcSettlerPersonAtt.setObedience(charClassC); 
		attHappiness = npcSettlerPersonAtt.setHappiness(charClassC); 
		attLibido = npcSettlerPersonAtt.setLibido(charClassC); // 
		attMorality = npcSettlerPersonAtt.setMorality(charClassC); // how good and bad, it can be corrupt good, it means the person is just twisted
		attPiety = npcSettlerPersonAtt.setPiety(charClassC);

		bgUpbringC = npcSettlerBG.setUpbring (upbringselector);

		if (isPrisoner == true || isSlave == true || isNeutral == true) {
			charGold = 0;
		} else {
			charGold = npcSettlerBG.setGold (bgUpbringC);
		}

		bgChildhoodC = npcSettlerBG.setBGChildhood ();
		bgAdulthoodC = npcSettlerBG.setBGAdulthood ();

		bgStory [0] = npcSettlerBG.setChildStory (bgChildhoodC);
		bgStory [1] = npcSettlerBG.setAdultStory (bgAdulthoodC);
		bgStory [2] = npcSettlerBG.setCurrentStory (charClassC);


		charRaceC = npcSettlerRace.setRace(raceselector, racespecific); 
		charRaceC = npcSettlerRace.adjustRaceGender (charRaceC, charSexC);

		charFurColorC = raceCreator.setFur(charRaceC); 

		charFeatherColorC = raceCreator.setFeathers(charRaceC);

		charSkinColorC = raceCreator.setSkinColor(charRaceC); 

		charSkinTypeC = raceCreator.setSkinType(charRaceC); 

		dickTypeC = raceCreator.setDickType(charRaceC); 

		lowerBackC = raceCreator.setLowerBack(charRaceC);

		shoulderBladesC = raceCreator.setShoulderBlades(charRaceC); 

		headTypeC = raceCreator.setHeadType (charRaceC);

		//tailTypeC = raceCreator.setTailType (charRaceC);

		armsTypeC = raceCreator.setArms(charRaceC);

		legsTypeC = raceCreator.setLegs(charRaceC);

		headAccesory1C = raceCreator.setHeadAcc1(charRaceC);

		headAccesory2C = raceCreator.setHeadAcc2(charRaceC);

		eyesTypeC = raceCreator.setEyes(charRaceC);

		hasFur = raceCreator.setHasFur(charRaceC); // everyone uses the fur colours tho
		hasFeathers = raceCreator.setHasFeathers(charRaceC); 
		hasScales = raceCreator.setHasScales(charRaceC);
		hasTentacles = raceCreator.setHasTentacles(charRaceC);
		isFlying = raceCreator.setIsFlying(charRaceC);

		isFurry = raceCreator.setIsFurry(charRaceC); // to determine portrait 
		isFuta = raceCreator.setIsFuta(charSexC); 


		beardStyleC = npcSettlerHead.setBeardStyle(charSexC, charRaceC);

		beardLengthC =  npcSettlerHead.setBeardLength(charSexC, charRaceC);

		hairColorC =  npcSettlerHead.setHairColor();

		hairStyleC =  npcSettlerHead.setHairStyle();

		hairTypeC = npcSettlerHead.setHairType (charRaceC);

		hairLengthCM =  npcSettlerHead.setHairLengthCM(); 

		hairLengthC =  npcSettlerHead.setHairLength(hairLengthCM);

		eyesColorC =  npcSettlerHead.setEyesColor(charRaceC);

		genderBehaviorStat = npcSettlerPersonAtt.setBehaviorStat(charGenderC);
		genderBehaviorC = npcSettlerPersonAtt.setGenderBehavior(genderBehaviorStat);

		facialFeaturesStat = npcSettlerHead.setFacialFeatStat(charGenderC); 
		facialFeaturesC = npcSettlerHead.setFacialFeat(facialFeaturesStat); 

		bodyFeaturesStat= npcSettlerBody.setBodyFeatStat(charGenderC); 
		bodyFeaturesC = npcSettlerBody.setBodyFeatures(facialFeaturesStat); 

		heightChar = npcSettlerBody.SetHeightChar(charRaceC); // in cm
		heightNameC = npcSettlerBody.setHeightName(heightChar);


		bodyPhysStat = npcSettlerBody.SetBodyPhysStat(); // to change it, 0 to 100
		bodyPhysiqueC = npcSettlerBody.setBodyPhysique(bodyPhysStat); 

		bodyBuildStat = npcSettlerBody.setBodyBuildStat(); // to change it
		bodyBuildC= npcSettlerBody.setBodyBuild(bodyBuildStat); 

	
		dickNum = npcSettlerBody.setDickNum(charSexC); //how many dicks it has
		dickSizeCM = npcSettlerBody.setDickSizeCM(heightChar, charSexC); // in cm
		dickSizeC = npcSettlerBody.setDickSize(dickSizeCM); 

	
		testicleSizeCM = npcSettlerBody.setTesticleSizeCM(charSexC, heightChar); 
		testiclesSizeC = npcSettlerBody.setTesticlesSize(testicleSizeCM); // in cm, used to determine if you have or not

		clitorisSize = npcSettlerBody.setClitorisSize();


	
		breastRow = npcSettlerBody.setBreastRow(charRaceC); 
		breast1Size = npcSettlerBody.setBreast1Size(charSexC, charRaceC); // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler
		breast2Size = npcSettlerBody.setBreast2Size(breastRow); // to determine its current size. Each point is +1 cup, each X changes name, check NPCSettler

		breast1NameC = npcSettlerBody.setBreastName (breast1Size);
		breast2NameC = npcSettlerBody.setBreastName (breast2Size);

		breast1CupC = npcSettlerBody.setBreastCup (breast1Size);
		breast2CupC = npcSettlerBody.setBreastCup (breast2Size);


		areola1Size = npcSettlerBody.setAureoleSize(); // aerola size of the first row, 1 change, in cm
		areola2Size = areola1Size; // aerola size of the first row, 1 change, in cm




		waistSize = npcSettlerBody.waistSize(); 
		waistNameC = npcSettlerBody.setWaistName(waistSize); 

		hipsSize = npcSettlerBody.setHipsSize(waistSize); 
		hipsNameC = npcSettlerBody.setHipsName(hipsSize); 

		assSize = npcSettlerBody.setAssSize(hipsSize); 
		assNameC = npcSettlerBody.setAssName(assSize); 

	
		hasKnot = npcSettlerFertility.setHasKnot(charRaceC); 
		hasVagina = npcSettlerFertility.setHasVagina(charSexC); 
		isVirgin = npcSettlerFertility.setIsVirgin(charRaceC); 
		isFertile = npcSettlerFertility.setIsFertile(); 
		charFertility = npcSettlerFertility.setCharFertility(); 
		isPregnant = npcSettlerFertility.isPregnant(pregnantselector, charSexC); 
		childRaceC = npcSettlerFertility.setChildRace(charRaceC); 
		pregnantCD = npcSettlerFertility.setPregnantCD(isPregnant); // turns until giving birth
		pregnantText = npcSettlerFertility.pregnantText(isPregnant, childRaceC); // 
		isLactating = isPregnant;
		lactationML = npcSettlerFertility.setLactationML(charRaceC); // how much it lactates in ml


		vagLooseness = npcSettlerFertility.setVagLooseness (isVirgin);
		vagLoose = npcSettlerFertility.setVagLoose (vagLooseness);


		maxHealth = npcSettlerCombatStats.setMaxHealth(charRaceC);
		currentHealth = maxHealth; 

		maxArousal = npcSettlerCombatStats.setMaxArousal(charRaceC); 
		currentArousal = 0; 

		maxMP = npcSettlerCombatStats.setMaxMP(charRaceC, charClassC);
		currentMP = maxMP; 




		// power and politics 
		charReputation = npcSettlerPosition.setCharReputation(cityPositionC, charClassC); 
		politicalPower = npcSettlerPosition.setPoliticalPower(cityPositionC);

		charAgeC = npcSettlerPersonAtt.setCharAge (charRaceC);	


		charLoyalty = npcSettlerPersonAtt.setLoyalty (charRaceC, charClassC);
		charCorruption = npcSettlerPersonAtt.setCorruption (charRaceC, charClassC);
		int i;

		i = 0;
		while (i < 8) {
			charAddictions [i] = npcSettlerPersonAtt.setAddiction (i, charRaceC, charClassC);
			i++;

		}
			
		charValue = npcSettlerPersonAtt.setCharValue(charRankC, charClassC, bgUpbringC, charRaceC, attBeauty, attWillpower, attObedience);




		//	public List<NPCData.CharTraits> charTraits; 

		TempList.Clear();

		setChar();

		TempList[0].charTattoos = new string[18];
		i = 0;
		while (i < 18) {
			TempList[0].charTattoos[i] = "";
			i++; 
		}

		TempList[0].charPiercings = new string[21];
		i = 0;
		while (i < 21) {
			TempList[0].charPiercings[i] = "";
			i++; 
		}

		TempList[0].charEquipment = new int[12];
		i = 0;
		while (i < 12) {
			TempList[0].charEquipment[i] = npcSettlerEquip.setCharEquipment(i, bgUpbringC, charClassC, charRaceC);
			i++; 
		}
		//CHANGE TO SOMETHING MORE DYNAMIC... LATER 
		TempList [0].charDodge = 10; 

		NPCSettlerTraits.trait1 = 1000; NPCSettlerTraits.trait2 = 1000;  NPCSettlerTraits.trait3 = 1000; NPCSettlerTraits.trait4 = 1000; NPCSettlerTraits.trait5 = 1000; NPCSettlerTraits.trait6 = 1000; NPCSettlerTraits.trait7 = 1000; NPCSettlerTraits.trait8 = 1000; NPCSettlerTraits.trait9 = 1000; NPCSettlerTraits.trait10 = 1000;

		i = 0;
		while (i < 10) {
			i++;

			TempList[0].charTraits.Add (npcSettlerTraits.setTrait (i, charClassC,  charRaceC, charPersonalityC, bgUpbringC, attBeauty, charSexC));
		}

		i =  TempList[0].charTraits.Count;
		while (i > 0) {
			i--;

			if (TempList[0].charTraits[i] == NPCData.CharTraits.NONE) {
				TempList[0].charTraits.RemoveAt (i);
			}

		}

		int count = TempList[0].charTraits.Count;
		i = 0; 
		while (i < count) 
		{

			npcSettlerTraitsBonus.setTraitBonus (TempList[0].charTraits[i]); 
			i++;

		}
			
		npcSettlerRankAdjustment.rankAdjustment ();


		i = 0;
		while (i < 4) {
			iterator += 1;
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			if (i >= 2 && Random.Range(0,100) >= 85) {
				break; 
			}
			attacksTempList.Add(npcSettlerAttacks.classAttacks (charClassC, charRaceC));
			i++;
		}

		i = 0;
		while (i < 4) {
			iterator += 1;
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			if (i >= 2 && Random.Range(0,100) >= 85) {
				break; 
			}
			attacksTempList.Add (npcSettlerAttacks.raceAttacks (charRaceC));
			i++;
		}

		List<NPCData.CharAttacks> attacksDistinctList = attacksTempList.Distinct ().ToList ();

		foreach (NPCData.CharAttacks value in attacksDistinctList) {
			TempList [0].charAttacks.Add (value);
		}



		NPCSettlerPortrait.createPortrait ();



		if (isRecruited == true && isPrisoner == false && isSlave == false) {
			NPCCharList.CharRetainers.Add (TempList [0]);
		}
		if (isEnemy == true  && isPrisoner == false && isSlave == false) {
			NPCCharList.CharEnemies.Add (TempList [0]);
		}
		if (isNeutral == true) {
			NPCCharList.CharRetainers.Add (TempList [0]);

			//NPCCharList.CharNeutral.Add (TempList [0]);
		}
		if (isMonster == true) {
			//this is for debug, remove
			NPCCharList.CharMonster.Add (TempList[0]);

		}
		if (isPrisoner == true && isRecruited == true) {
			NPCCharList.CharRetainerPrisoner.Add (TempList [0]); 
		}
		if (isSlave == true && isRecruited == true) {
			NPCCharList.CharRetainers.Add (TempList [0]);
		}
		if (isPrisoner == true && isEnemy == true) {
			NPCCharList.CharEnemyPrisoner.Add (TempList [0]);
		}
		if (isSlave == true && isEnemy == true) {
			NPCCharList.CharEnemySlave.Add (TempList [0]);
		}
			



		//	 attStyle; sets after equipment, use the dedicated settler in game for this
	
	}


	public void createRandCharDeb(){
		charCreator (1000, 1000, 0, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, false);


	}







}
