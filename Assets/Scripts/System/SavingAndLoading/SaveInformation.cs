using UnityEngine;
using System; 
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary; 
using System.IO; 
using UnityEngine.UI;

public class SaveInformation : MonoBehaviour {

	/*
	public Text Board; 
	public RectTransform panSaveQuestion; 
	public RectTransform panBaseMenu;
	*/
	public static int saveNum;
	int i;
	int x;


	SaveLoadTitles saveLoadtTitles = new SaveLoadTitles();
	PanLeftLoadButtons panLeftLoadButtons = new PanLeftLoadButtons();
	/*
	public void save1(){
		saveNum = 1; 
		panSaveQuestion.SetAsLastSibling ();
		Board.text = "Do you want to save in the slot 1?";

	}
	public void save2(){
		Board.text = "Do you want to save in the slot 2?";
		panSaveQuestion.SetAsLastSibling ();
		saveNum = 2; 


	}
	public void save3(){
		Board.text = "Do you want to save in the slot 3?";
		panSaveQuestion.SetAsLastSibling ();
		saveNum = 3; 
	

	}
	*/
		
	public void saveGame(int selector){
		if (selector == 0) {
			saveNum = 1;
			saveFunct ();
		}

		if (selector == 1) {
			saveNum = 2;
			saveFunct ();
		}

		if (selector == 2) {
			saveNum = 3;
			saveFunct ();
		}

		if (selector == 3) {
			saveNum = 4;
			saveFunct ();
		}

		if (selector == 4) {
			saveNum = 5;
			saveFunct ();
		}



	}



	public void saveFunct()
	{
		BinaryFormatter binFor = new BinaryFormatter (); 
		FileStream file = File.Create (Application.persistentDataPath + "/playerInfo" +saveNum+ ".dat");


		PlayerData data  = new PlayerData ();


		data.gameVersion = GameControl.gameVersion; 

		i = 0; 
		x = 0; 
		while (i < 10)
		{
			while(x < 2)
			{
				data.invSlotArray [i, x] = GameControl.invSlotArray [i, x];
					x++;
			}
			x = 0; 

			i++;
		}


		data.playerName = GameControl.playerName;

		data.charGold = GameControl.charGold; 

		data.MCClass = GameControl.MCClass;

		data.actualHealth = GameControl.actualHealth; 
		data.maxHealth = GameControl.maxHealth; // this may increase with prowess.. maybe its like 50 + prowess?

		data.actualArousal = GameControl.actualArousal;
		data.maxArousal = GameControl.maxArousal; // This should increase with maybe some stuff... up to 120 maybe? 

		data.attPhysical = GameControl.attPhysical; 
		data.attMental = GameControl.attMental;
		data.attSocial  = GameControl.attSocial;

		data.attMagicPower = GameControl.attMagicPower;

		data.attHypnotism = GameControl.attHypnotism;

		data.charCorruption  = GameControl.charCorruption;

		data.attPiety = GameControl.attPiety;

		data.attStyle = GameControl.attStyle;

		data.attAlignment = GameControl.attAlignment;

		data.charReputation = GameControl.charReputation; 

		i = 0; 
		while (i < 8) {
			data.charAddictions [i] = GameControl.charAddictions [i]; 
			i++;
		}

		i = 0;
		while (i < GameControl.MCAttacks.Count) {
			data.MCAttacks.Add(GameControl.MCAttacks [i]);
			i++;
		}


		////////////////////// Core skills
		data.coreSkillMartial = GameControl.coreSkillMartial;
		data.coreSkillSecurity = GameControl.coreSkillSecurity;
		data.coreSkillLabor = GameControl.coreSkillLabor;
		data.coreSkillTactics = GameControl.coreSkillTactics;
		data.coreSkillGovernance = GameControl.coreSkillGovernance;
		data.coreSkillStewardship = GameControl.coreSkillStewardship;
		data.coreSkillPersuasion = GameControl.coreSkillPersuasion;
		data.coreSkillIntrigue = GameControl.coreSkillIntrigue;
		data.coreSkillDiplomacy = GameControl.coreSkillDiplomacy;

		////////////////////// Utility skills
		data.utilitySkillCrafting = GameControl.utilitySkillCrafting; 
		data.utilitySkillHouseKeeping = GameControl.utilitySkillHouseKeeping; 
		data.utilitySkillFarmHand = GameControl.utilitySkillFarmHand; 
		data.utilitySkillMedicine = GameControl.utilitySkillMedicine;
		data.utilitySkillAlchemy = GameControl.utilitySkillAlchemy;
		data.utilitySkillLearning = GameControl.utilitySkillLearning;
		data.utilitySkillPerformance = GameControl.utilitySkillPerformance;
		data.utilitySkillEtiquette = GameControl.utilitySkillEtiquette;
		data.utilitySkillStreetwise = GameControl.utilitySkillStreetwise;

		////////////////////// Sex skills
		data.sexSkillMasseuse = GameControl.sexSkillMasseuse;
		data.sexSkillStripping = GameControl.sexSkillStripping; 
		data.sexSkillBondage = GameControl.sexSkillBondage;
		data.sexSkillPetplay = GameControl.sexSkillPetplay;
		data.sexSkillPetting = GameControl.sexSkillPetting;
		data.sexSkillGroupSex = GameControl.sexSkillGroupSex;
		data.sexSkillPenetration = GameControl.sexSkillPenetration;
		data.sexSkillWhoring = GameControl.sexSkillWhoring; 
		data.sexSkillEscorting = GameControl.sexSkillEscorting;





		//combat

		i = 0; 
		while (i < 4)
		{
			data.activeSkills [i] = GameControl.activeSkills [i];
			i++;
		}

		i = 0; 
		while (i < 6)
		{
			data.skillSetLevel [i]= GameControl.skillSetLevel [i];
			i++;
		}

		i = 0; 
		while (i < 4)
		{
			data.activeLust [i] = GameControl.activeLust [i];
			i++;
		}

		i = 0; 
		while (i < 6)
		{
			data.lustSetLevel [i]  = GameControl.lustSetLevel [i];
			i++;
		}



		i = 0; 
		while (i < 6)
		{
			data.lustSetCounter [i]  = GameControl.lustSetCounter [i];
			i++;
		}


		i = 0; 
		while (i < 6)
		{
			data.skillSetCounter [i]= GameControl.skillSetCounter [i];
			i++;
		}


		data.mcHead  = GameControl.mcHead; 
		data.mcArms  = GameControl.mcArms;  
		data.mcLegs  = GameControl.mcLegs;
		data.mcSkinType  = GameControl.mcSkinType; 
		data.mcSkinColor  = GameControl.mcSkinColor; 
		data.mcFurColor  = GameControl.mcFurColor; 
		data.mcRace = GameControl.mcRace;  
		data.mcDickType  = GameControl.mcDickType; 

		i = 0; 

		while (i < 12)
		{

			data.charEquipment [i] = GameControl.charEquipment [i];

			i++;
		}


		data.mcSex = GameControl.mcSex; 

		data.mcGender  = GameControl.mcGender; // 0 asexual, 1 woman, 2 male, 3 dickgirl (no vag), 4 futa (vag and penis), 5 herm-male

		data.mcShoulderBlades  = GameControl.mcShoulderBlades;
		data.mcTailType  = GameControl.mcTailType;
		data.mcFeatherColor = GameControl.mcFeatherColor;
		data.mcBeardStyle  = GameControl.mcBeardStyle;

		data.mcBeardLength  = GameControl.mcBeardLength; // cms, each 5 the next
		data.mcHeadAccesory1  = GameControl.mcHeadAccesory1; //antlers, horns
		data.mcHeadAccesory2  = GameControl.mcHeadAccesory2;  // other face-related things


		data.fertileVery = GameControl.fertileVery;
		data.fertility = GameControl.fertility; 
		data.fertile = GameControl.fertile;
		data.cumProduction  = GameControl.cumProduction; // ml maybe? 
		data.milkProduction  = GameControl.milkProduction; 
		data.lactating =  GameControl.lactating; 
		data.lactatingTurns = GameControl.lactatingTurns; // how many days are left lacatating


		data.mcHairColor  = GameControl.mcHairColor; 
		data.mcHairType  = GameControl.mcHairType; 
		data.mcHairStyle  = GameControl.mcHairStyle; 
		data.mcHairLength  = GameControl.mcHairLength; 

		data.hairLength =  GameControl.hairLength;

		data.mcEyesType  = GameControl.mcEyesType; // index for list, changes iris 
		data.mcEyesColor  = GameControl.mcEyesColor; //index for colours


		data.heightChar  = GameControl.heightChar;  // 

		data.mcHeightName  = GameControl.mcHeightName; 
		data.mcBodyShape  = GameControl.mcBodyShape; 


		data.hasTentacles  = GameControl.hasTentacles; 
		data.hasVagina  = GameControl.hasVagina; 
		data.isGoo  = GameControl.isGoo; 
		data.hasFur  = GameControl.hasFur; 
		data.hasFeathers  = GameControl.hasFeathers; 
		data.hasScales = GameControl.hasScales;
		data.isPhantom  = GameControl.isPhantom;
		data.hasKnot  = GameControl.hasKnot; 
		data.isFlying = GameControl.isFlying; 



		data.breastRow  = GameControl.breastRow;  // up to two 


		i = 0; 
		while (i < 30)
		{
			data.tattoo [i] = GameControl.tattoo [i];

			i++;
		}


		i = 0; 
		while (i < 30)
		{

			data.piercings [i] = GameControl.piercings [i];

			i++;
		}


		 
		data.isVirgin = GameControl.isVirgin; 
		data.isPregnant  = GameControl.isPregnant; 
		data.pregnantCounter  = GameControl.pregnantCounter; 
		data.pregnantText  = GameControl.pregnantText; // this NEEDs to be saved.
		data.mcChildRace = GameControl.mcChildRace;

		data.mcGenderBehavior  = GameControl.mcGenderBehavior; 
		data.genderBehaviorStat  = GameControl.genderBehaviorStat; 

		data.mcFacialFeatures = GameControl.mcFacialFeatures; 
		data.facialFeaturesStat = GameControl.facialFeaturesStat; 

		data.mcBodyFeatures = GameControl.mcBodyFeatures;
		data.bodyFeaturesStat = GameControl.bodyFeaturesStat;

		data.mcPhysique  = GameControl.mcPhysique; 
		data.physiqueStat  = GameControl.physiqueStat; 

		data.buildStat  = GameControl.buildStat;
		data.mcBuild  = GameControl.mcBuild;

		data.dickNum  = GameControl.dickNum; 

		data.dick1Size  = GameControl.dick1Size; // 
		data.dick2Size  = GameControl.dick2Size; // 
		data.dick1Thick  = GameControl.dick1Thick; // 
		data.dick2Thick  = GameControl.dick2Thick; //

		data.mcDick1Name  = GameControl.mcDick1Name;
		data.mcDick2Name  = GameControl.mcDick2Name;

		data.testiclesSize  = GameControl.testiclesSize; //
		data.mcTesticlesName  = GameControl.mcTesticlesName; //

		data.clitorisSize  = GameControl.clitorisSize;   
		data.mcVagLooseness  = GameControl.mcVagLooseness; 


		data.mcBreast1Name  = GameControl.mcBreast1Name;
		data.mcBreast2Name  = GameControl.mcBreast2Name;

		data.mcBreast1Cup = GameControl.mcBreast1Cup; 
		data.mcBreast2Cup = GameControl.mcBreast2Cup;

		data.breast1Size  = GameControl.breast1Size;  
		data.breast2Size  = GameControl.breast2Size; 

		data.areola1Size  = GameControl.areola1Size; 
		data.areola2Size  = GameControl.areola2Size; 

		data.mcAssName  = GameControl.mcAssName; // 
		data.mcHipsName  = GameControl.mcHipsName; 
		data.mcWaistName  = GameControl.mcWaistName; 

		data.assSize  = GameControl.assSize; // 
		data.hipsSize  = GameControl.hipsSize; //  
		data.waistSize  = GameControl.waistSize; //




		/// <summary>
		/// WORLD CONTROL
		/// </summary>////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		/// 
		data.furryOn = WorldControl.furryOn; // If true,furry portraits will load. 
		data.futaOn = WorldControl.futaOn;


		i = 0; 
		while (i < 20) {
			data.tagControl [i] = WorldControl.tagControl [i];
			i++;
		}
		//sys save
		data.fontSize = WorldControl.fontSize; 

		// World info - SAVE

		data.day = WorldControl.day; // day counter
		data.dayTime = WorldControl.dayTime; // the day is divided in 6 phases, 3 days, 3 night. 
		data.dayTimeName = WorldControl.dayTimeName;
		data.partyID1 = WorldControl.partyID1;
		data.partyID2 = WorldControl.partyID2;
		data.partyID3 = WorldControl.partyID3;


		// Map control SAVE
		i = 0; 
		while (i < 6) {

			data.storyChapter [i] = WorldControl.storyChapter [i]; 
			i++;
		}

		i = 0;
		while (i < 15) {
			data.chapter1Locations [i] = WorldControl.chapter1Locations [i];
			i++; 
		}


		//STASH


		i = 0; 
		x = 0; 
		while (i < 5)
		{
			while(x < 2)
			{
				data.stashCons [i, x] = WorldControl.stashCons [i, x];
					x++;
			}
			x = 0; 

			i++;
		}


		i = 0; 
		x = 0; 
		while (i < 5)
		{
			while(x < 2)
			{
				data.stashEquip [i, x] = WorldControl.stashEquip [i, x];
				x++;
			}
			x = 0; 

			i++;
		}






		/// <summary> NPCS
		/// //////////////////////////////////////////////////////////////////////
		/// </summary>

		data.dateCD = NPCControl.dateCD; 
		data.purifyCD = NPCControl.purifyCD; 
		data.corruptCD = NPCControl.corruptCD; 

		//


		data.NPCGenID = NPCControl.NPCGenID;


		//data.npc1000Meet = NPCControl.npc1000Meet; 
		//data.npc1000Corruption = NPCControl.npc1000Corruption; 
		data.npc1000Relationship = NPCControl.npc1000Relationship;
		//data.npc1000Issue = NPCControl.npc1000Issue;

		//


		i = 0; 
		x = 0; 
		while (i < 3)
		{
			while(x < 3)
			{
				data.npc1000Talk [i, x] = NPCControl.npc1000Talk [i, x];
				x++;
			}
			x = 0; 

			i++;
		}



		// Junia - Barn manager ID 2000 - Junia
		//data.npc2000Meet = NPCControl.npc2000Meet; 
		//npc2000Talk = new [5,5]; //0-past, 1-Barn, 2- Something
		//data.npc2000Corruption = 25; 
		//npc200Relationship = 0;
		//npc2000Issue = 0; 




		// Helena - Maid ID 3000 - Helena

		i = 0; 
		x = 0; 
		while (i < 3)
		{
			while(x < 3)
			{
				data.npc3000Talk [i, x] = NPCControl.npc3000Talk [i, x];
				x++;
			}
			x = 0; 

			i++;
		}
			

		data.npc3000Corruption = NPCControl.npc3000Corruption; 
		data.npc3000Relationship = NPCControl.npc3000Relationship;

		i = 0; 
		while (i < 5)
		{

			data.npc3000CorruptionPath [i] = NPCControl.npc3000CorruptionPath [i];

			i++;
		}


		i = 0; 
		while (i < 5)
		{

			data.npc3000PurifyPath [i] = NPCControl.npc3000PurifyPath[i];

			i++;
		}

		i = 0; 
		while (i < 5)
		{

			data.npc3000EnslavePath [i] = NPCControl.npc3000EnslavePath [i];

			i++;
		}




		i = 0; 
		while (i < 4)
		{

			data.npc3000Dominance [i] = NPCControl.npc3000Dominance [i];

			i++;
		}

		i = 0; 
		while (i < 4)
		{

			data.npc3000Submission [i] = NPCControl.npc3000Submission [i];

			i++;
		}

		data.npc3000Broken = NPCControl.npc3000Broken; 
		data.npc3000Slave = NPCControl.npc3000Slave; 




		// Misaki - ID 4000
		data.npc4000Meet = NPCControl.npc4000Meet;
		data.npc4000follower = NPCControl.npc4000follower; // when you do her quest and becomes follower


		i = 0; 
		x = 0; 
		while (i < 2)
		{
			while(x < 2)
			{
				data.npc4000Talk [i, x] = NPCControl.npc4000Talk [i, x];
				x++;
			}
			x = 0; 

			i++;
		} 
			
		data.npc4000Corruption = NPCControl.npc4000Corruption; 
		data.npc4000Relationship = NPCControl.npc4000Relationship;



		// Yoshika - ID - 5000
		data.npc5000Meet = NPCControl.npc5000Meet;

		i = 0; 
		x = 0; 
		while (i < 3)
		{
			while(x < 3)
			{
				data.npc5000Talk [i, x] = NPCControl.npc5000Talk [i, x];
				x++;
			}
			x = 0; 

			i++;
		} 


		data.npc5000Relationship = NPCControl.npc5000Relationship;

		i = 0; 
		while (i < 5)
		{

				data.npc5000CorruptionPath [i] = NPCControl.npc5000CorruptionPath [i];

			i++;
		} 

		i = 0; 
		while (i < 5)
		{

				data.npc5000PurifyPath [i] = NPCControl.npc5000PurifyPath [i];

			i++;
		} 

		/// lucina 6000
		//data.npc6000Incest = NPCControl.npc6000Incest; 
		data.npc6000CorruptPath = NPCControl.npc6000CorruptPath; // means its being corrupted
		data.npc6000PurifyPath = NPCControl.npc6000PurifyPath; 
		data.npc6000CorruptPathStage = NPCControl.npc6000CorruptPathStage;
		data.npc6000PurifyPathStage = NPCControl.npc6000PurifyPathStage;
		data.npc6000slimeQueen = NPCControl.npc6000slimeQueen;
		data.npc6000Symbiote = NPCControl.npc6000Symbiote;

		i = 0;
		x = 0;
		while (i < 3) {
			while (x < 3) {


				data.npc6000Talk [i, x] = NPCControl.npc6000Talk [i, x];
				x++;
			}

			i++;
		}

		i = 0;
		while (i < 5) {

			data.npc6000slimeQueen[i] = NPCControl.npc6000slimeQueen [i];


			i++;
		}

		i = 0;
		while (i < 5) {

			data.npc6000Symbiote[i] = NPCControl.npc6000Symbiote [i];


			i++;
		}

	
	




		//////////////////////////////////////////////////////////////////////////////////////
		/////       CITIES    /////////////////////////////////////////////////////////////////////////

		data.city100Prosperity = CityControl.city100Prosperity; 
		data.city100Order = CityControl.city100Order;
		data.city100Happiness = CityControl.city100Happiness;
		data.city100Corruption = CityControl.city100Corruption; 

		data.city100Infrastructure = CityControl.city100Infrastructure;
		data.city100Education = CityControl.city100Education;
		data.city100Defense = CityControl.city100Defense; 
		data.city100Piety = CityControl.city100Piety;

		i = 0; 
		while (i < 90)
		{

			data.city100Slaves [i] = CityControl.city100Slaves [i];


			i++;
		} 

		//city100Slaves = new [90];

		data.city100DowntownMeet = CityControl.city100DowntownMeet; 
		//agora
		data.city100AgoraMeet = CityControl.city100AgoraMeet; 

		data.city100BathMeet = CityControl.city100BathMeet; 
		data.city100BathLevel = CityControl.city100BathLevel;

		data.city100ColosseumMeet = CityControl.city100ColosseumMeet; 
		data.city100ColosseumLevel = CityControl.city100ColosseumLevel;  

		data.city100GymMeet = CityControl.city100GymMeet; 

		data.city100AmphitheatreMeet = CityControl.city100AmphitheatreMeet; 
		data.city100AmphitheatreLevel = CityControl.city100AmphitheatreLevel; 
		//market



		i = 0; 
		while (i < 10)
		{

			data.city100MarketMeet[i] = CityControl.city100MarketMeet [i];


			i++;
		} 

		//city100MarketMeet = new [10];  // Market[0], Potion store[1], tailor - 1000[2], Blacksmith[3], Inn[4], slave market[5], tattoo[6], gym[7]


		// Chapel
		data.city100ChapelMeet = CityControl.city100ChapelMeet; 
		data.city100ChapelLevel = CityControl.city100ChapelLevel; 

		i = 0;
		while (i < 50) {
			data.city100ChapelWorkers [i] = CityControl.city100ChapelWorkers [i];
			i++;
		}

		i = 0;
		while (i < 10) {
			data.city100ChapelEfficiency [i] = CityControl.city100ChapelEfficiency [i]; 
			i++;
		}
			

		data.city100ChapelCorruption = CityControl.city100ChapelCorruption;

		//Barn
		data.city100BarnMeet = CityControl.city100BarnMeet;

		//Bordello
		data.city100BordelloMeet = CityControl.city100BordelloMeet;
		data.city100BordelloLevel = CityControl.city100BordelloLevel; 

		// MANDATES
		data.mandateSkimpyServitude = CityControl.mandateSkimpyServitude; 


		i = 0;
		while (i < 30) {
			data.mandatesChurch[i] = CityControl.mandatesChurch [i];
			i++;
		}

		i = 0;
		while (i < 10) {
			data.mandatesMinistersFinance[i] = CityControl.mandatesMinistersFinance[i];
			i++;
		}
			

		data.city100Taxes = CityControl.city100Taxes; 
		//taxes: 0 normal, 1 low, 2 high, 3 draconian


		i = 0;
		while (i < 10) {
			data.city100Ministers[i] = CityControl.city100Ministers [i];
			i++;
		}

		i = 0;
		while (i < 10) {
			data.city100MinistersEfficiency [i] = CityControl.city100MinistersEfficiency [i];
			i++;
		}
		// ministers

		data.experimentBodyPure = CityControl.experimentsBodyPure;
		data.experimentBodyCorrupt = CityControl.experimentsBodyCorrupt;
		data.experimentSoulPure = CityControl.experimentsSoulPure;
		data.experimentSoulCorrupt = CityControl.experimentsSoulCorrupt;





		//////////////////////////////////////////////////////////////////////////////////////////////////
		/// Generic NPCs and NPCs NPCData
		//////////////////////////////////////////////////////////////////////////////////////////////////


		/*i = 0;
		while (i < NPCCharList.CharList.Count) {
			data.CharList.Add(NPCCharList.CharList [i]);
			i++;
		}*/

		i = 0;
		while (i < RulesNPC.savedRules.Count) {
			data.savedRules.Add (RulesNPC.savedRules [i]);
			i++;
		}

		i = 0;
		while (i < NPCCharList.CharRetainers.Count) {
			data.CharRetainers.Add(NPCCharList.CharRetainers[i]);
			i++;
		}

		i = 0;
		while (i < NPCCharList.CharEnemies.Count) {
			data.CharEnemies.Add(NPCCharList.CharEnemies[i]);
			i++;
		}

		i = 0;
		while (i < NPCCharList.CharNeutral.Count) {
			data.CharNeutral.Add(NPCCharList.CharNeutral[i]);
			i++;
		}

		i = 0;
		while (i < NPCCharList.CharRetainerPrisoner.Count) {
			data.CharRetainerPrisoner.Add(NPCCharList.CharRetainerPrisoner [i]);
			i++;
		}

		i = 0;
		while (i < NPCCharList.CharRetainerSlave.Count) {
			data.CharRetainerSlave.Add(NPCCharList.CharRetainerSlave[i]);
			i++;
		}

		i = 0;
		while (i < NPCCharList.CharEnemyPrisoner.Count) {
			data.CharEnemyPrisoner.Add(NPCCharList.CharEnemyPrisoner[i]);
			i++;
		}

		i = 0;
		while (i < NPCCharList.CharEnemySlave.Count) {
			data.CharEnemySlave.Add(NPCCharList.CharEnemySlave[i]);
			i++;
		}


		i = 0;
		while (i < NPCCharList.CharFollower.Count) {
			data.CharFollower.Add(NPCCharList.CharFollower[i]);
			i++;
		}




		//////////////////////////////////////////////////////////////////////////////////////////////////
		/// special items control
		//////////////////////////////////////////////////////////////////////////////////////////////////
		data.item20014FirstUse = SpecialItemsControl.item20014FirstUse;  




		//////////////////////////////////////////////////////////////////////////////////////////////////
		/// Law control
		//////////////////////////////////////////////////////////////////////////////////////////////////
		i = 0;
		while (i < LawController.ActiveLaws.Count) {
			data.ActiveLaws.Add(LawController.ActiveLaws[i]);
			i++;
		}



		///////////////////

		//////////////////////////////////////////////////////////////////////////////////////////////////
		/// Quest controller 
		//////////////////////////////////////////////////////////////////////////////////////////////////
		i = 0;
		while (i < QuestsController.ActiveQuests.Count) {
			data.ActiveQuests.Add(QuestsController.ActiveQuests[i]);
				i++;
		}


		//////////////////////////////////////////////////////////////////////////////////////////////////
		/// Quest control
		//////////////////////////////////////////////////////////////////////////////////////////////////
		data.mainQuestFinished = QuestControl.mainQuestFinished;

		data.helenaQuest = QuestControl.helenaQuest; // this define in which stage she is. the max is  
		data.helenaCorrupt = QuestControl.helenaCorrupt; 
		data.helenaSlave = QuestControl.helenaSlave; 
		data.helenaDominant = QuestControl.helenaDominant;

		data.abbadonQuest = QuestControl.abbadonQuest;
		data.abbadonGender = QuestControl.abbadonGender;
		data.abbadonCorrupt = QuestControl.abbadonCorrupt;
		data.abbadonHelp = QuestControl.abbadonHelp;


		data.lucinaQuest = QuestControl.lucinaQuest; 
		data.lucinaCorrupt = QuestControl.lucinaCorrupt; 
		data.lucinaSlimeQueen = QuestControl.lucinaSlimeQueen; 

		data.itzelQuest = QuestControl.itzelQuest; 
		data.itzelFollowerCornelia = QuestControl.itzelFollowerCornelia; //
		data.itzelChurchCornelia = QuestControl.itzelChurchCornelia; 
		data.itzelCorrupt = QuestControl.itzelCorrupt;

		data.albaQuest = QuestControl.albaQuest;
		data.albaHelp = QuestControl.albaHelp;


		data.corruptionPoints = QuestControl.corruptionPoints; // used with the 3 followers only to define itzel start

		data.vivicaCounter = QuestControl.vivicaCounter; 
		data.vivicaQuest = QuestControl.vivicaQuest;



		data.virgilQuest = QuestControl.virgilQuest;
		data.virgilCorruptMaid = QuestControl.virgilCorruptMaid; 
		data.virgilDrugs  = QuestControl.virgilDrugs; 
		data.virgilNerdyGirl = QuestControl.virgilNerdyGirl; // if false, it means he picked the slutty futa 
		data.virgilWhoreGirl = QuestControl.virgilWhoreGirl;

		data.celiaQuest = QuestControl.celiaQuest;
		data.celiaStartCorrupt  = QuestControl.celiaStartCorrupt; // false is pure 
		data.celiaCheater = QuestControl.celiaCheater;

		data.lucretiusQuest = QuestControl.lucretiusQuest;
		data.lucretiusStartCorrupt = QuestControl.lucretiusStartCorrupt; // false is pure 

		//save v1.1

			// city control
		data.armyArmourHeavy = CityControl.armyArmourHeavy; // if else is skimpy

				// city slaves
		data.slavesForcedLabor = CityControl.slavesForcedLabor; // these are triggered in quest 4 of Faustina 
		data.slavesSexWork = CityControl.slavesSexWork;
		data.slavesReeducation = CityControl.slavesReeducation;


		//Quest control
		data.faustinaQuest = QuestControl.faustinaQuest; 
		data.faustinaStartCorrupt = QuestControl.faustinaStartCorrupt; 
		data.faustinaEqual = QuestControl.faustinaEqual;
		data.faustinaDom = QuestControl.faustinaDom; // SHE IS THE DOM, NO YOUR DOM PATH
		data.faustinaSub = QuestControl.faustinaSub; 


		//castle control

		data.castleCleanliness = CastleController.castleCleanliness;
		data.castleFoodQuality = CastleController.castleFoodQuality;
		data.castleSecurity = CastleController.castleSecurity;

		data.castleSupplies = CastleController.castleSupplies;

		data.castleHealthcare = CastleController.castleHealthcare;
		data.slaveMasterEff = CastleController.slaveMasterEff;
		data.maxSecurityTrain = CastleController.maxSecurityTrain;
		data.maxMartialTrain = CastleController.maxMartialTrain;

		data.castleMentalcare = CastleController.castleMentalcare;


		data.castleReinforced = CastleController.castleReinforced;
		data.castleDailyReport = CastleController.castleDailyReport;

		data.castleBoudoir = CastleController.castleBoudoir;
		data.castlePrivateRoom = CastleController.castlePrivateRoom;
		data.castleMCRoomSpace = CastleController.castleMCRoomSpace;




		binFor.Serialize (file, data); 

		file.Close();




		/*
		panBaseMenu.SetAsLastSibling ();
		Board.text = "Your game has been saved!";
		*/

		//saveLoadtTitles.loadNameAll ();
		//panLeftLoadButtons.blockLoad ();
		//panLeftLoadButtons.blockLoad ();

	
	}



}


[Serializable] // Tells unity the next data can be saved

class PlayerData 
{

	/// <summary>
	/// Game control
	/// </summary>///////////////////////////////////////////

	public float gameVersion; 


	public  int[,] invSlotArray = new int[10,2];
	public  float charGold;

	public string playerName; 

	public NPCData.CharClass MCClass; 

	public  float actualHealth; 
	public  float maxHealth; // this may increase with prowess.. maybe its like 50 + prowess? 

	public  float actualArousal;
	public  float maxArousal; // This should increase with maybe some stuff... up to 120 maybe? 

	public  float attPhysical; 
	public  float attMental;
	public  float attSocial;

	public float attMagicPower = 0;

	public float attHypnotism = 0; 

	public float[] attBonus = new float[4];

	public  float charCorruption;

	public float attPiety;

	public  float attStyle;

	public float attAlignment; 

	public  float[] attEquipStyle = new float[12]; 

	public float charReputation = 0; 

	public float[] charAddictions = new float[8]; // tobacco, alcohol, opium, coke, shrooms, hero, semen


	public List<NPCData.CharAttacks> MCAttacks = new List<NPCData.CharAttacks>(); 


	////////////////////// Core skills
	public float coreSkillMartial;
	public float coreSkillSecurity;
	public float coreSkillLabor;
	public float coreSkillTactics;
	public float coreSkillGovernance;
	public float coreSkillStewardship;
	public float coreSkillPersuasion;
	public float coreSkillIntrigue;
	public float coreSkillDiplomacy;

	public float[] skillCoreBonus = new float[9];

	////////////////////// Utility skills
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


	////////////////////// Sex skills
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


	//combat
	public  int[] activeSkills = new int[4]; //  your 4 skill by id 
	public  int[] skillSetLevel = new int[6]; // [0] is null, this saves the lvl of the skils of your char 
	public  int[] activeLust = new int[4]; 

	public  int[] lustSetLevel = new int[6]; 
	public int[] skillSetCounter = new int[6]; 
	public int[] lustSetCounter = new int[6]; 



	public GameControl.MCHead mcHead;

	public GameControl.MCArms mcArms; 

	public GameControl.MCLegs mcLegs;

	public GameControl.MCSkinType mcSkinType;

	public GameControl.MCSkinColor mcSkinColor;

	public GameControl.MCFurColor mcFurColor;

	public GameControl.MCRace mcRace;

	public  GameControl.MCDickType mcDickType; 

	public  int[] charEquipment = new int[12]; //weapon, armor, head, face, neck, shoulders, arms, legs, makeup


	public GameControl.MCSex mcSex; 

	public  GameControl.MCGender mcGender; // 0 asexual, 1 woman, 2 male, 3 dickgirl (no vag), 4 futa (vag and penis), 5 herm-male


	public  GameControl.MCShoulderBlades mcShoulderBlades;

	public GameControl.MCTailType mcTailType;

	public GameControl.MCFeatherColor mcFeatherColor;

	public  GameControl.MCBeardStyle mcBeardStyle;

	public  GameControl.MCBeardLength mcBeardLength; // cms, each 5 the next
	public  GameControl.MCHeadAccesory1 mcHeadAccesory1; //antlers, horns
	public  GameControl.MCHeadAccesory2 mcHeadAccesory2;  // other face-related things

	public bool fertileVery = false;
	public float fertility = 0.3f; 
	public bool fertile = true;
	public float cumProduction = 5; // ml maybe? 
	public float milkProduction = 350; 
	public bool lactating = false; 
	public int lactatingTurns; // how many days are left lacatating

	public GameControl.MCHairColor mcHairColor;
	public  GameControl.MCHairStyle mcHairStyle;
	public  GameControl.MCHairType mcHairType; 
	public  GameControl.MCHairLength mcHairLength; 

	public  float hairLength; // en cm 

	public  GameControl.MCEyesType mcEyesType; // index for list, changes iris 
	public  GameControl.MCEyesColor mcEyesColor = 0; //index for colours

	public float heightChar = 170;  

	public  GameControl.MCHeightName mcHeightName; 
	public  GameControl.MCBodyShape mcBodyShape; 


	public bool hasTentacles = false; 
	public bool hasVagina = false; 
	public bool hasFur = false; 
	public bool hasScales = false;
	public bool hasFeathers = false; 
	public bool isPhantom = false; 
	public bool isGoo = false; 
	public bool hasKnot = false; 
	public bool isFlying = false; 


	public int breastRow = 1;  // up to two 
	public string[] tattoo = new string[30]; 
	public string[] piercings = new string[30];

	public bool isVirgin = true; 
	public bool isPregnant = false; 
	public int pregnantCounter; 
	public string pregnantText; // this NEEDs to be saved.
	public NPCData.CharRace mcChildRace; 

	public float charCombatAttack; // it is calculated by its attributes, equipment and traits, no need to save, it can be readjusted after load with char sett
	public float charLustAttack; 
	public float charCombatDefense;
	public float charLustDefense;
	public float charMagicDefense; 


	public GameControl.MCGenderBehavior mcGenderBehavior; 
	public float genderBehaviorStat; // this is what sets the above, this can make a char more feminine or masculine after certain point

	public GameControl.MCFacialFeatures mcFacialFeatures; 
	public float facialFeaturesStat; 

	public GameControl.MCBodyFeatures mcBodyFeatures;
	public float bodyFeaturesStat; 

	public GameControl.MCPhysique mcPhysique;
	public float physiqueStat; // 0 to 8

	public GameControl.MCBuild mcBuild;
	public float buildStat; // Every 1


	public  int dickNum = 0; 
	public  float dick1Size; // Tamaño del dick
	public  float dick2Size; // tamaño del segundo dick
	public  float dick1Thick; // Tamaño del dick
	public  float dick2Thick; // tamaño del segundo dick

	public GameControl.MCDickSize mcDick1Name; 
	public GameControl.MCDickSize mcDick2Name; 

	public GameControl.MCTesticleName mcTesticlesName; 

	public float testiclesSize; // tamaño testiculos, en CM

	public float clitorisSize = 0; 

	public  GameControl.MCVagLooseness mcVagLooseness; 

	public static float vagLooseStat; 

	public GameControl.MCBreastName mcBreast1Name; 
	public GameControl.MCBreastName mcBreast2Name; 

	public GameControl.MCBreastCup mcBreast1Cup;
	public GameControl.MCBreastCup mcBreast2Cup; 

	public  float breast1Size; 
	public  float breast2Size; 

	public  float areola1Size = 0; 
	public  float areola2Size = 0; 

	public  GameControl.MCAssName mcAssName;
	public  GameControl.MCHipsName mcHipsName; 
	public  GameControl.MCWaistName mcWaistName; 


	public  float assSize; 
	public  float hipsSize; 
	public  float waistSize; 



	/// <summary>
	/// WORLD CONTROL
	/// </summary>////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	/// 
	public  bool furryOn; // If true,furry portraits will load. 
	public  bool futaOn;
	public  bool[] tagControl = new bool[20];
	// SYS SAVE
	public int fontSize; 
	// World info - SAVE 
	public  int day = 0; // day counter
	public  int dayTime = 0; // the day is divided in 6 phases, 3 days, 3 night. 
	public  string dayTimeName = "Morning";
	public int partyID1, partyID2, partyID3; 

	// Map control SAVE
	public bool[] storyChapter = new bool[6]; // 0 ch2, 1 ch3, 2 ch4, 3 ch5 an extra chap? aftermath?
	public bool[] chapter1Locations = new bool[15]; //0 plains, 1 mountains, 2 town1, 3 town2, 4 town3, 5 town4, 6 town5, 7 city1, 8 kujiang, 9+ unused 

	//STASH
	public  int[,] stashCons = new int[5,2];
	public  int[,] stashEquip = new int[5,2];




	/// <summary> NPCS
	/// //////////////////////////////////////////////////////////////////////
	/// </summary>

	public int dateCD = 0; 
	public int purifyCD = 0; 
	public int corruptCD = 0; 

	//
	public int NPCGenID = 0;

	public  bool npc1000Meet = false; 
	public  int npc1000Corruption = 25; 
	public  int npc1000Relationship = 0;
	public  int npc1000Issue = 0; 
	public  bool[,] npc1000Talk = new bool[3,3]; //0-past, 1-agora, 2-fashion
	public  bool[] npc1000CorruptionPath = new bool[5];
	public  bool[] npc1000PurifyPath = new bool[5];


	// Junia - Barn manager ID 2000 - Junia
	public  bool npc200Meet = false; 
	public  bool[,] npc200Talk = new bool[5,5]; //0-past, 1-Barn, 2- Something
	public  int npc200Corruption = 25; 
	public  int npc200Relationship = 0;
	public  int npc200Issue = 0; 

	// Helena - Maid ID 3000 - Helena

	public  bool[,] npc3000Talk = new bool[3,3]; //0-past, 1-Barn, 2- Something
	public  int npc3000Corruption = 25; 
	public  int npc3000Relationship = 0;
	public  bool[] npc3000CorruptionPath = new bool[5];
	public  bool[] npc3000PurifyPath = new bool[5];
	public  bool[] npc3000EnslavePath = new bool[5];
	public  bool npc3000Broken = false; 
	public  bool npc3000Slave = false; 
	public  bool[] npc3000Dominance = new bool[4];
	public  bool[] npc3000Submission = new bool[4];



	// Misaki - ID 4000
	public  bool npc4000Meet = false;
	public  bool npc4000follower = false; // when you do her quest and becomes follower
	public  bool[,] npc4000Talk= new bool[2,2]; // 0 - Past, 1 Her 
	public  int npc4000Corruption = 0; 
	public  int npc4000Relationship = 0;


	// Yoshika - ID - 5000
	public  bool npc5000Meet = false;
	public  bool npc5000Follower = false; // when you do his quest and becomes follower 
	public  bool[,] npc5000Talk= new bool[3,3]; // 0 - Past, 1 Her  
	public  int npc5000Corruption = 0; 
	public  int npc5000Relationship = 0;
	public  bool[] npc5000CorruptionPath = new bool[5];
	public  bool[] npc5000PurifyPath = new bool[5];

	// Lucina - ID - 6000 
	public bool npc6000Incest = false; 
	public bool npc6000CorruptPath; // means its being corrupted
	public bool npc6000PurifyPath; // this is to detect that purifycation has started
	public int npc6000CorruptPathStage;
	public int npc6000PurifyPathStage;
	public bool[] npc6000slimeQueen = new bool[5];
	public bool[] npc6000Symbiote = new bool[5];
	public bool[,] npc6000Talk= new bool[3,3];




	//////////////////////////////////////////////////////////////////////////////////////
	/////       CITIES    /////////////////////////////////////////////////////////////////////////

	public  float city100Prosperity = 0; 
	public  float city100Order = 0;
	public  float city100Happiness = 0;
	public  float city100Corruption = 0; 

	public float city100Infrastructure = 0;
	public float city100Education = 0;
	public float city100Defense = 0; 
	public float city100Piety = 0;

	public  int[] city100Slaves = new int[90]; //0 Bunny, Wolf, Plant, Dodo, Horse   //5 Chinchilla 

	public  bool city100DowntownMeet = false; 
	//agora
	public  bool city100AgoraMeet = false; 

	public  bool city100BathMeet = false; 
	public  int city100BathLevel = 0;

	public  bool city100ColosseumMeet = false; 
	public  int city100ColosseumLevel = 0;  

	public  bool city100GymMeet = false; 

	public  bool city100AmphitheatreMeet = false; 
	public  int city100AmphitheatreLevel = 0; 
	//market
	public  bool[] city100MarketMeet = new bool[10];  // Market[0], Potion store[1], tailor - 1000[2], Blacksmith[3], Inn[4], slave market[5], tattoo[6], gym[7]


	// Chapel
	public  bool city100ChapelMeet = false; 
	public  int city100ChapelLevel = 0; 


	public int[] city100ChapelWorkers = new int[50]; 
	public int[] city100ChapelEfficiency = new int[10]; 
	public float city100ChapelCorruption = 0;


	//Barn
	public  bool city100BarnMeet;

	//Bordello
	public  bool city100BordelloMeet;
	public  int city100BordelloLevel = 0; 

	// MANDATES
	public bool mandateSkimpyServitude = false; 
	public bool[] mandatesChurch = new bool[30]; // 0 corrupt the church, 1 skimpy attires 
	public int[] mandatesMinistersFinance = new int[10]; // 0 public slaves quota, 1 (3)defaulter punishments


	public int city100Taxes; 
	//taxes: 0 normal, 1 low, 2 high, 3 draconian

	// ministers
	public int[] city100Ministers = new int[10]; // stores the IDs, 0 finances, 1 chancellor, 2 justice, 3 master of shadows, 4 marshall
	public int[] city100MinistersEfficiency = new int[10];


	public bool experimentBodyPure;
	public bool experimentBodyCorrupt;
	public bool experimentSoulPure;
	public bool experimentSoulCorrupt;




	//////////////////////////////////////////////////////////////////////////////////////////////////
	/// Generic NPCs and NPCs NPCData
	//////////////////////////////////////////////////////////////////////////////////////////////////
	public List<fileRulesNPC> savedRules = new List<fileRulesNPC>();

	public List<NPCData> CharList = new List<NPCData>();

	public List<NPCData> CharRetainers = new List<NPCData>();

	public List<NPCData> CharEnemies = new List<NPCData>();

	public List<NPCData> CharNeutral = new List<NPCData>();

	public List<NPCData> CharMonster = new List<NPCData>();

	public List<NPCData> CharRetainerPrisoner = new List<NPCData>();

	public List<NPCData> CharRetainerSlave = new List<NPCData>();

	public List<NPCData> CharEnemyPrisoner = new List<NPCData>();

	public List<NPCData> CharEnemySlave = new List<NPCData>();

	public List<NPCData> CharFollower = new List<NPCData>();


	//////////////////////////////////////////////////////////////////////////////////////////////////
	/// special items control
	//////////////////////////////////////////////////////////////////////////////////////////////////

	public bool item20014FirstUse = false;  



	//////////////////////////////////////////////////////////////////////////////////////////////////
	/// Law control
	//////////////////////////////////////////////////////////////////////////////////////////////////
	public List<Law> ActiveLaws = new List<Law>();



	//////////////////////////////////////////////////////////////////////////////////////////////////
	/// Quest controller
	//////////////////////////////////////////////////////////////////////////////////////////////////
	public List<Quest> ActiveQuests = new List<Quest>(); 


	//////////////////////////////////////////////////////////////////////////////////////////////////
	/// Quest control
	//////////////////////////////////////////////////////////////////////////////////////////////////
	public bool mainQuestFinished; 

	public int helenaQuest; // this define in which stage she is. the max is  
	public bool helenaCorrupt; 
	public bool helenaSlave; 
	public bool helenaDominant;

	public int abbadonQuest; 
	public bool abbadonGender;
	public bool abbadonCorrupt; 
	public bool abbadonHelp; 

	public int lucinaQuest; 
	public bool lucinaCorrupt; 
	public bool lucinaSlimeQueen; 

	public int itzelQuest; 
	public bool itzelFollowerCornelia; //
	public bool itzelChurchCornelia; 
	public bool itzelCorrupt;

	public int albaQuest; 
	public bool albaHelp;

	public int corruptionPoints; // used with the 3 followers only to define itzel start

	public int vivicaCounter; 
	public int vivicaQuest;


	public int virgilQuest;
	public bool virgilCorruptMaid; 
	public bool virgilDrugs; 
	public bool virgilNerdyGirl; // if false, it means he picked the slutty futa 
	public bool virgilWhoreGirl;

	public int celiaQuest;
	public bool celiaStartCorrupt; // false is pure 
	public bool celiaCheater; 

	public int lucretiusQuest;
	public bool lucretiusStartCorrupt; // false is pure 



	//save v1.1
		// city control
	public bool armyArmourHeavy; // if else is skimpy

		// city slaves
	public bool slavesForcedLabor; // these are triggered in quest 4 of Faustina 
	public bool slavesSexWork;
	public bool slavesReeducation;


		//Quest control
	public int faustinaQuest; 
	public bool faustinaStartCorrupt; 
	public bool faustinaEqual;
	public bool faustinaDom; // SHE IS THE DOM, NO YOUR DOM PATH
	public bool faustinaSub; 

	//castle controller

	public float castleCleanliness;
	public float castleFoodQuality;
	public float castleSecurity;

	public float castleSupplies;

	public float castleHealthcare;
	public float slaveMasterEff;
	public float maxSecurityTrain;
	public float maxMartialTrain;

	public float castleMentalcare;


	public bool castleReinforced;
	public string castleDailyReport;

	public int castleBoudoir;
	public int castlePrivateRoom;
	public int castleMCRoomSpace;

}

