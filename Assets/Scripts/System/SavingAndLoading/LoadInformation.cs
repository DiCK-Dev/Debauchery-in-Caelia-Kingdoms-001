using UnityEngine;
using System; 
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary; 
using System.IO; 
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class LoadInformation : MonoBehaviour {
	public Text Board; 
	public RectTransform panLoadQuestion; 
	public RectTransform panBaseMenu;


	FollowerCreator followerCreator = new FollowerCreator ();

	SetEquipment setEquipment = new SetEquipment();

	public static int loadNum;

	int i;
	int x;



	public void load1(){
		loadNum = 1; 
		if (File.Exists (Application.persistentDataPath + "/playerInfo" + loadNum + ".dat")) {
			panLoadQuestion.SetAsLastSibling ();
			Board.text = "Do you want to load this save?";
		} else {
			Board.text = "There is no file in this slot!";
		}
	}
	public void load2(){
		loadNum = 2; 
		if (File.Exists (Application.persistentDataPath + "/playerInfo" + loadNum + ".dat")) {
			panLoadQuestion.SetAsLastSibling ();
			Board.text = "Do you want to load this save?";
		} else {
			Board.text = "There is no file in this slot!";
		}
	}

	public void load3(){
		loadNum = 3; 
		if (File.Exists (Application.persistentDataPath + "/playerInfo" + loadNum + ".dat")) {
			panLoadQuestion.SetAsLastSibling ();
			Board.text = "Do you want to load this save?";
		} else {
			Board.text = "There is no file in this slot!";
		}
	}

	public void load1Main(){
		loadNum = 1; 
		loadFunct ();
		SceneManager.LoadScene (3);
	}

	public void load2Main(){
		loadNum = 2; 
		loadFunct ();
		SceneManager.LoadScene (3);
	}

	public void load3Main(){
		loadNum = 3; 
		loadFunct ();
		SceneManager.LoadScene (3);
	}

	public void load4Main(){
		loadNum = 4; 
		loadFunct ();
		SceneManager.LoadScene (3);
	}

	public void load5Main(){
		loadNum = 5; 
		loadFunct ();
		SceneManager.LoadScene (3);
	}


	public void loadGame(int selector){
		if (selector == 0) {
			loadNum = 1;
			loadFunct ();
		}

		if (selector == 1) {
			loadNum = 2;
			loadFunct ();
		}

		if (selector == 2) {
			loadNum = 3;
			loadFunct ();
		}

		if (selector == 3) {
			loadNum = 4;
			loadFunct ();
		}

		if (selector == 4) {
			loadNum = 5;
			loadFunct ();
		}



	}






	public void loadFunct()
	{
		//NPCCharList.CharList.Clear ();

		RulesNPC.savedRules.Clear ();

		NPCCharList.CharFollower.Clear ();

		NPCCharList.CharRetainers.Clear ();

		NPCCharList.CharEnemies.Clear ();

		NPCCharList.CharNeutral.Clear ();

		NPCCharList.CharMonster.Clear ();

		NPCCharList.CharRetainerPrisoner.Clear ();

		NPCCharList.CharRetainerSlave.Clear ();

		NPCCharList.CharEnemyPrisoner.Clear ();

		NPCCharList.CharEnemySlave.Clear ();

		GameControl.MCAttacks.Clear ();

		LawController.ActiveLaws.Clear ();

		QuestsController.ActiveQuests.Clear ();


		if(File.Exists(Application.persistentDataPath + "/playerInfo"+ loadNum +".dat")) 
		{
			Debug.Log ("Load Funct loaded"); 
			BinaryFormatter binFor = new BinaryFormatter();
			FileStream file = File.Open (Application.persistentDataPath + "/playerInfo"+ loadNum +".dat", FileMode.Open); 
			PlayerData data = (PlayerData)binFor.Deserialize (file);
			file.Close();

		//	GameControl.actualHealth = data.actualHealth; 

			//from this point, anything new additiong goes into these saves
			//////////////////////////////////////////////////////////////////////

			//CURRENTLY WE ARE AT 1.1f
			if (data.gameVersion == GameControl.gameVersion) {
				//1.1
				GameControl.attHypnotism = data.attHypnotism;
			}else if (data.gameVersion == 1.0f) {
				//i.e. this is used for wen the gameVersion is 1.X, this should update the 1.0 to the newest one
				//followerCreator.charFaustina();
			}


			


			//////////////////////////////////////////////////////////////////////

			i = 0; 
			x = 0; 
			while (i < 10)
			{
				while(x < 2)
				{
					GameControl.invSlotArray [i, x] = data.invSlotArray [i, x];
					x++;
				}
				x = 0; 

				i++;
			} 

			GameControl.playerName = data.playerName;

			GameControl.charGold = data.charGold; 

			GameControl.MCClass = data.MCClass;

			GameControl.actualHealth = data.actualHealth;
			GameControl.maxHealth = data.maxHealth;

			GameControl.actualArousal = data.actualArousal;
			GameControl.maxArousal = data.maxArousal;

			GameControl.attPhysical = data.attPhysical;
			GameControl.attMental = data.attMental;
			GameControl.attSocial = data.attSocial;

			GameControl.attMagicPower = data.attMagicPower;

			GameControl.charCorruption = data.charCorruption;

			GameControl.attPiety = data.attPiety; 

			GameControl.attStyle = data.attStyle;

			GameControl.attAlignment = data.attAlignment;

			GameControl.charReputation = data.charReputation; 

			i = 0;
			while (i < 8) {
				GameControl.charAddictions [i] = data.charAddictions [i];
				i++;
			}

			i = 0;
			while (i < data.MCAttacks.Count) {
				GameControl.MCAttacks.Add(data.MCAttacks[i]);
				i++;
			}


			////////////////////// Core skills
			GameControl.coreSkillMartial = data.coreSkillMartial;
			GameControl.coreSkillSecurity = data.coreSkillSecurity;
			GameControl.coreSkillLabor = data.coreSkillLabor;
			GameControl.coreSkillTactics = data.coreSkillTactics;
			GameControl.coreSkillGovernance = data.coreSkillGovernance;
			GameControl.coreSkillStewardship = data.coreSkillStewardship;
			GameControl.coreSkillPersuasion = data.coreSkillPersuasion;
			GameControl.coreSkillIntrigue = data.coreSkillIntrigue;
			GameControl.coreSkillDiplomacy = data.coreSkillDiplomacy;


			////////////////////// Utility skills
			GameControl.utilitySkillCrafting = data.utilitySkillCrafting; 
			GameControl.utilitySkillHouseKeeping = data.utilitySkillHouseKeeping; 
			GameControl.utilitySkillFarmHand = data.utilitySkillFarmHand; 
			GameControl.utilitySkillMedicine = data.utilitySkillMedicine;
			GameControl.utilitySkillAlchemy = data.utilitySkillAlchemy;
			GameControl.utilitySkillLearning = data.utilitySkillLearning;
			GameControl.utilitySkillPerformance = data.utilitySkillPerformance;
			GameControl.utilitySkillEtiquette = data.utilitySkillEtiquette;
			GameControl.utilitySkillStreetwise = data.utilitySkillStreetwise;

			////////////////////// Sex skills
			GameControl.sexSkillMasseuse = data.sexSkillMasseuse;
			GameControl.sexSkillStripping = data.sexSkillStripping; 
			GameControl.sexSkillBondage = data.sexSkillBondage;
			GameControl.sexSkillPetplay = data.sexSkillPetplay;
			GameControl.sexSkillPetting = data.sexSkillPetting;
			GameControl.sexSkillGroupSex = data.sexSkillGroupSex;
			GameControl.sexSkillPenetration = data.sexSkillPenetration;
			GameControl.sexSkillWhoring = data.sexSkillWhoring; 
			GameControl.sexSkillEscorting = data.sexSkillEscorting;




			i = 0; 
			while (i < 4)
			{

				GameControl.activeSkills [i] = data.activeSkills [i];

				i++;
			} 

			i = 0; 
			while (i < 6)
			{

				GameControl.skillSetLevel [i] = data.skillSetLevel[i];

				i++;
			} 

			i = 0; 
			while (i < 4)
			{

				GameControl.activeLust [i] = data.activeLust [i];

				i++;
			} 

			i = 0; 
			while (i < 6)
			{

				GameControl.lustSetLevel [i] = data.lustSetLevel[i];

				i++;
			} 



			i = 0; 
			while (i < 6)
			{

				GameControl.skillSetCounter [i] = data.skillSetCounter[i];

				i++;
			} 


			i = 0; 
			while (i < 6)
			{

				GameControl.lustSetCounter [i] = data.lustSetCounter[i];

				i++;
			} 






				//Body transformable and races 

			GameControl.mcHead= data.mcHead;
			GameControl.mcArms = data.mcArms;
			GameControl.mcLegs = data.mcLegs;
			GameControl.mcSkinType = data.mcSkinType;
			GameControl.mcSkinColor = data.mcSkinColor;
			GameControl.mcFurColor = data.mcFurColor; 
			GameControl.mcRace = data.mcRace;
			GameControl.mcDickType = data.mcDickType;






			i = 0; 
			while (i < 12)
			{

				GameControl.charEquipment [i] = data.charEquipment [i];

				i++;
			} 

			GameControl.mcSex = data.mcSex;
			GameControl.mcGender = data.mcGender;


			GameControl.mcShoulderBlades = data.mcShoulderBlades;
			GameControl.mcTailType = data.mcTailType;
			GameControl.mcFeatherColor = data.mcFeatherColor;
			GameControl.mcBeardStyle = data.mcBeardStyle;

			GameControl.mcBeardLength = data.mcBeardLength;
			GameControl.mcHeadAccesory1 = data.mcHeadAccesory1;
			GameControl.mcHeadAccesory2 = data.mcHeadAccesory2;



			GameControl.fertileVery = data.fertileVery;
			GameControl.fertile = data.fertile;
			GameControl.fertility = data.fertility;
			GameControl.cumProduction = data.cumProduction;
			GameControl.milkProduction = data.milkProduction;
			GameControl.lactating = data.lactating;
			GameControl.lactatingTurns = data.lactatingTurns;


			GameControl.mcHairColor = data.mcHairColor;
			GameControl.mcHairType = data.mcHairType;
			GameControl.mcHairStyle = data.mcHairStyle;
			GameControl.mcHairLength = data.mcHairLength;

			GameControl.hairLength = data.hairLength;


			GameControl.mcEyesType = data.mcEyesType;
			GameControl.mcEyesColor = data.mcEyesColor;


			GameControl.heightChar = data.heightChar;

			GameControl.mcHeightName = data.mcHeightName;
			GameControl.mcBodyShape = data.mcBodyShape;



			//Specials 
			GameControl.hasTentacles = data.hasTentacles;
			GameControl.hasVagina = data.hasVagina;
			GameControl.isGoo = data.isGoo;
			GameControl.hasFur = data.hasFur;
			GameControl.hasFeathers = data.hasFeathers;
			GameControl.hasScales = data.hasScales;
			GameControl.isPhantom = data.isPhantom;
			GameControl.hasKnot = data.hasKnot;
			GameControl.isFlying = data.isFlying;


			GameControl.breastRow = data.breastRow;





			i = 0; 
			while (i < 30)
			{

				GameControl.tattoo [i] = data.tattoo [i];

				i++;
			} 

			i = 0; 
			while (i < 30)
			{
				GameControl.piercings [i] = data.piercings [i];


				i++;
			} 


			GameControl.isVirgin = data.isVirgin;
			GameControl.isPregnant = data.isPregnant;
			GameControl.pregnantCounter = data.pregnantCounter;
			GameControl.pregnantText = data.pregnantText;
			GameControl.mcChildRace = data.mcChildRace;


			GameControl.mcGenderBehavior= data.mcGenderBehavior;
			GameControl.genderBehaviorStat = data.genderBehaviorStat; 

			GameControl.mcFacialFeatures = data.mcFacialFeatures;
			GameControl.facialFeaturesStat = data.facialFeaturesStat;

			GameControl.mcBodyFeatures = data.mcBodyFeatures;
			GameControl.bodyFeaturesStat = data.bodyFeaturesStat;


			GameControl.physiqueStat = data.physiqueStat;
			GameControl.mcPhysique = data.mcPhysique;

			GameControl.buildStat = data.buildStat;
			GameControl.mcBuild = data.mcBuild;

			GameControl.dickNum = data.dickNum;

			GameControl.dick1Size = data.dick1Size;
			GameControl.dick2Size = data.dick2Size;
			GameControl.dick1Thick = data.dick1Thick;
			GameControl.dick2Thick = data.dick2Thick;

			GameControl.mcDick1Name = data.mcDick1Name;
			GameControl.mcDick2Name = data.mcDick2Name;

			GameControl.testiclesSize = data.testiclesSize;
			GameControl.mcTesticlesName = data.mcTesticlesName;

			GameControl.clitorisSize = data.clitorisSize;
			GameControl.mcVagLooseness = data.mcVagLooseness;

			GameControl.breast1Size = data.breast1Size;
			GameControl.breast2Size = data.breast2Size;

			GameControl.mcBreast1Cup = data.mcBreast1Cup;
			GameControl.mcBreast2Cup = data.mcBreast2Cup; 

			GameControl.mcBreast1Name = data.mcBreast1Name;
			GameControl.mcBreast2Name = data.mcBreast2Name;

			GameControl.areola1Size = data.areola1Size;
			GameControl.areola2Size = data.areola2Size;

			GameControl.mcAssName = data.mcAssName;
			GameControl.mcHipsName = data.mcHipsName;
			GameControl.mcWaistName = data.mcWaistName;

			GameControl.assSize = data.assSize;
			GameControl.hipsSize = data.hipsSize;
			GameControl.waistSize = data.waistSize;




				/// <summary>
				/// WORLD CONTROL
				/// </summary>////////////////////////////////////////////////////////////////////////////////////////////////////////////////

			WorldControl.furryOn = data.furryOn;
			WorldControl.futaOn = data.futaOn;

			i = 0; 
			while (i < 20) {
				WorldControl.tagControl [i] = data.tagControl [i];
				i++;
			}

			//sys 
			WorldControl.fontSize = data.fontSize; 
			if (WorldControl.fontSize < 10) {
				WorldControl.fontSize = 16;
			}
				// World info - SAVE 
			WorldControl.day = data.day;
			WorldControl.dayTime = data.dayTime;
			WorldControl.dayTimeName = data.dayTimeName;
			WorldControl.partyID1 = data.partyID1;
			WorldControl.partyID2 = data.partyID2;
			WorldControl.partyID3 = data.partyID3;


			i = 0;
			while (i < 6) {
				WorldControl.storyChapter [i] = data.storyChapter [i];
				i++;
			}

			i = 0;
			while (i < 15) {
				WorldControl.chapter1Locations[i] = data.chapter1Locations [i];
				i++;
			}



			i = 0; 
			x = 0; 
			while (i < 5)
			{
				while(x < 2)
				{
					WorldControl.stashCons [i, x] = data.stashCons[i, x];
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
					WorldControl.stashEquip[i, x] = data.stashEquip[i, x];
					x++;
				}
				x = 0; 

				i++;
			} 





				/// <summary> NPCS
				/// //////////////////////////////////////////////////////////////////////
				/// </summary>



			NPCControl.dateCD = data.dateCD;
			NPCControl.purifyCD = data.purifyCD;
			NPCControl.corruptCD = data.corruptCD;



			NPCControl.NPCGenID = data.NPCGenID;

			//NPCControl.npc1000Meet = data.npc1000Meet;
			//NPCControl.npc1000Corruption = data.npc1000Corruption;
			NPCControl.npc1000Relationship = data.npc1000Relationship;
		//	NPCControl.npc1000Issue = data.npc1000Issue;




			i = 0; 
			x = 0; 
			while (i < 3)
			{
				while(x < 3)
				{
					NPCControl.npc1000Talk [i, x] = data.npc1000Talk[i, x];
					x++;
				}
				x = 0; 

				i++;
			} 

			i = 0; 


				/*
				// Junia - Barn manager ID 2000 - Junia
				npc200Meet = false 
				bool[,] npc200Talk = new bool[5,5] //0-past, 1-Barn, 2- Something
				npc200Corruption = 25 
				npc200Relationship = 0
				npc200Issue = 0 
				*/


				// Helena - Maid ID 3000 - Helena

			i = 0; 
			x = 0; 
			while (i < 3)
			{
				while(x < 3)
				{
					NPCControl.npc3000Talk [i, x] = data.npc3000Talk[i, x];
					x++;
				}
				x = 0; 

				i++;
			} 


			NPCControl.npc3000Corruption = data.npc3000Corruption;
			NPCControl.npc3000Relationship = data.npc3000Relationship;
			i = 0; 
			while (i < 5)
			{

				NPCControl.npc3000CorruptionPath [i] = data.npc3000CorruptionPath[i];

				i++;
			} 

			i = 0; 
			x = 0; 
			while (i < 5)
			{
					NPCControl.npc3000PurifyPath [i] = data.npc3000PurifyPath[i];


				i++;
			} 

			i = 0;  
			while (i < 5)
			{
				NPCControl.npc3000EnslavePath [i] = data.npc3000EnslavePath[i];

				i++;
			} 
				
			NPCControl.npc3000Broken = data.npc3000Broken;
			NPCControl.npc3000Slave = data.npc3000Slave;


			i = 0; 
			while (i < 4)
			{
					NPCControl.npc3000Dominance[i] = data.npc3000Dominance[i];


				i++;
			} 


			i = 0; 
			while (i < 4)
			{
					NPCControl.npc3000Submission [i] = data.npc3000Submission[i];

				i++;
			} 





				// Misaki - ID 4000
			NPCControl.npc4000Meet = data.npc4000Meet;
			NPCControl.npc4000follower = data.npc4000follower;
			i = 0; 
			x = 0; 
			while (i < 2)
			{
				while(x < 2)
				{
					NPCControl.npc4000Talk [i, x] = data.npc4000Talk[i, x];
					x++;
				}
				x = 0; 

				i++;
			} 


			NPCControl.npc4000Corruption = data.npc4000Corruption;
			NPCControl.npc4000Relationship = data.npc4000Relationship;


				// Yoshika - ID - 5000
			NPCControl.npc5000Meet = data.npc5000Meet;

			i = 0; 
			x = 0; 
			while (i < 3)
			{
				while(x < 3)
				{
					NPCControl.npc5000Talk [i, x] = data.npc5000Talk[i, x];
					x++;
				}
				x = 0; 

				i++;
			} 
				  
			NPCControl.npc5000Relationship = data.npc5000Relationship;

			i = 0; 
			while (i < 5)
			{

					NPCControl.npc5000CorruptionPath [i] = data.npc5000CorruptionPath[i];


				i++;
			} 


			i = 0; 
			while (i < 5)
			{

					NPCControl.npc5000PurifyPath [i] = data.npc5000PurifyPath[i];


				i++;
			} 
	



			/// lucina 6000
			//NPCControl.npc6000Incest = data.npc6000Incest; 
			NPCControl.npc6000CorruptPath = data.npc6000CorruptPath; // means its being corrupted
			NPCControl.npc6000PurifyPath = data.npc6000PurifyPath; 
			NPCControl.npc6000CorruptPathStage = data.npc6000CorruptPathStage;
			NPCControl.npc6000PurifyPathStage = data.npc6000PurifyPathStage;
			NPCControl.npc6000slimeQueen = data.npc6000slimeQueen;
			NPCControl.npc6000Symbiote = data.npc6000Symbiote;

			i = 0;
			x = 0;
			while (i < 3) {
				while (x < 3) {


					NPCControl.npc6000Talk [i, x] = data.npc6000Talk [i, x];
					x++;
				}

				i++;
			}


			i = 0;
			while (i < 5) {

				NPCControl.npc6000slimeQueen [i] = data.npc6000slimeQueen[i];


				i++;
			}

			i = 0;
			while (i < 5) {

				NPCControl.npc6000Symbiote [i] = data.npc6000Symbiote[i];


				i++;
			}




				//////////////////////////////////////////////////////////////////////////////////////
				/////       CITIES    /////////////////////////////////////////////////////////////////////////

			CityControl.armyArmourHeavy = data.armyArmourHeavy; // if else is skimpy


			CityControl.slavesForcedLabor = data.slavesForcedLabor; // these are triggered in quest 4 of Faustina 
			CityControl.slavesSexWork = data.slavesSexWork;
			CityControl.slavesReeducation = data.slavesReeducation;

			CityControl.city100Prosperity = data.city100Prosperity;
			CityControl.city100Order = data.city100Order;
			CityControl.city100Happiness= data.city100Happiness;
			CityControl.city100Corruption = data.city100Corruption;

			CityControl.city100Infrastructure = data.city100Infrastructure;
			CityControl.city100Education = data.city100Education;
			CityControl.city100Defense = data.city100Defense; 
			CityControl.city100Piety = data.city100Piety;

			i = 0; 
			while (i < 90)
			{
				CityControl.city100Slaves [i] = data.city100Slaves[i];

				i++;
			} 
	

			CityControl.city100DowntownMeet = data.city100DowntownMeet;
				//agora
			CityControl.city100AgoraMeet = data.city100AgoraMeet;

			CityControl.city100BathMeet = data.city100BathMeet;
			CityControl.city100BathLevel = data.city100BathLevel;

			CityControl.city100ColosseumMeet = data.city100ColosseumMeet;
			CityControl.city100ColosseumLevel = data.city100ColosseumLevel;

			CityControl.city100GymMeet = data.city100GymMeet;

			CityControl.city100AmphitheatreMeet = data.city100AmphitheatreMeet;
			CityControl.city100AmphitheatreLevel = data.city100AmphitheatreLevel;
		

			//market
			i = 0; 
			while (i < 10)
			{
				CityControl.city100MarketMeet [i] = data.city100MarketMeet[i];
				i++;
			} 
				//bool[] city100MarketMeet = new bool[10]  // Market[0], Potion store[1], tailor - 1000[2], Blacksmith[3], Inn[4], slave market[5], tattoo[6], gym[7]


				// Chapel
			CityControl.city100ChapelMeet = data.city100ChapelMeet;
			CityControl.city100ChapelLevel = data.city100ChapelLevel;



			i = 0;
			while (i < 50){
				CityControl.city100ChapelWorkers[i] = data.city100ChapelWorkers[i];
				i++;
			}

			i = 0;
			while(i < 10){
				CityControl.city100ChapelEfficiency[i] = data.city100ChapelEfficiency[i];
				i++;
			}
 
			CityControl.city100ChapelCorruption = data.city100ChapelCorruption; 


				//Barn
			CityControl.city100BarnMeet = data.city100BarnMeet;

				//Bordello
			CityControl.city100BordelloMeet = data.city100BordelloMeet;
			CityControl.city100BordelloLevel = data.city100BordelloLevel;
				// MANDATES
			CityControl.mandateSkimpyServitude = data.mandateSkimpyServitude;


			i = 0;
			while (i < 30) {
				CityControl.mandatesChurch [i] = data.mandatesChurch[i];
				i++;
			}

			i = 0;
			while (i < 10) {
				CityControl.mandatesMinistersFinance[i] = data.mandatesMinistersFinance[i];
				i++;
			}


			CityControl.city100Taxes = data.city100Taxes; 
			//taxes: 0 normal, 1 low, 2 high, 3 draconian


			i = 0;
			while (i < 10) {
				CityControl.city100Ministers [i] = data.city100Ministers[i];
				i++;
			}

			i = 0;
			while (i < 10) {
				CityControl.city100MinistersEfficiency [i] = data.city100MinistersEfficiency [i];
				i++;
			}

			// ministers

			CityControl.experimentsBodyPure = data.experimentBodyPure;
			CityControl.experimentsBodyCorrupt = data.experimentBodyCorrupt;
			CityControl.experimentsSoulPure = data.experimentSoulPure;
			CityControl.experimentsSoulCorrupt = data.experimentSoulCorrupt;



			//////////////////////////////////////////////////////////////////////////////////////////////////
			/// Generic NPCs and NPCs NPCData
			//////////////////////////////////////////////////////////////////////////////////////////////////

			/*i = 0;
			while (i < data.CharList.Count) {
				NPCCharList.CharList.Add(data.CharList [i]);
				i++;
			}*/

			i = 0;

			while (i < data.savedRules.Count) {
				RulesNPC.savedRules.Add (data.savedRules [i]);
				i++;
			}

			i = 0;
			while (i < data.CharRetainers.Count) {
				NPCCharList.CharRetainers.Add(data.CharRetainers[i]);
				i++;
			}

			i = 0;
			while (i < data.CharEnemies.Count) {
				NPCCharList.CharEnemies.Add(data.CharEnemies[i]);
				i++;
			}

			i = 0;
			while (i < data.CharNeutral.Count) {
				NPCCharList.CharNeutral.Add(data.CharNeutral[i]);
				i++;
			}

			i = 0;
			while (i < data.CharRetainerPrisoner.Count) {
				NPCCharList.CharRetainerPrisoner.Add(data.CharRetainerPrisoner[i]);
				i++;
			}

			i = 0;
			while (i < data.CharRetainerSlave.Count) {
				NPCCharList.CharRetainerSlave.Add(data.CharRetainerSlave[i]);
				i++;
			}

			i = 0;
			while (i < data.CharEnemyPrisoner.Count) {
				NPCCharList.CharEnemyPrisoner.Add(data.CharEnemyPrisoner[i]);
				i++;
			}

			i = 0;
			while (i < data.CharEnemySlave.Count) {
				NPCCharList.CharEnemySlave.Add(data.CharEnemySlave[i]);
				i++;
			}


			i = 0;
			while (i < data.CharFollower.Count) {
				NPCCharList.CharFollower.Add(data.CharFollower[i]);
				i++;
			}





			//////////////////////////////////////////////////////////////////////////////////////////////////
			/// special items control
			//////////////////////////////////////////////////////////////////////////////////////////////////

			SpecialItemsControl.item20014FirstUse = data.item20014FirstUse;


			//////////////////////////////////////////////////////////////////////////////////////////////////
			/// Law control
			//////////////////////////////////////////////////////////////////////////////////////////////////
			i = 0;
			while (i < data.ActiveLaws.Count) {
				LawController.ActiveLaws.Add (data.ActiveLaws [i]);
				i++;
			}


			i = 0;
			while (i < data.ActiveQuests.Count) {
				QuestsController.ActiveQuests.Add (data.ActiveQuests [i]);
				i++;
			}


			//////////////////////////////////////////////////////////////////////////////////////////////////
			/// Quest control
			//////////////////////////////////////////////////////////////////////////////////////////////////
			QuestControl.mainQuestFinished = data.mainQuestFinished;

			QuestControl.helenaQuest = data.helenaQuest; // this define in which stage she is. the max is  
			QuestControl.helenaCorrupt = data.helenaCorrupt; 
			QuestControl.helenaSlave = data.helenaSlave; 
			QuestControl.helenaDominant = data.helenaDominant;

			QuestControl.abbadonQuest = data.abbadonQuest;
			QuestControl.abbadonGender = data.abbadonGender;
			QuestControl.abbadonCorrupt = data.abbadonCorrupt;
			QuestControl.abbadonHelp = data.abbadonHelp;

			QuestControl.lucinaQuest = data.lucinaQuest; 
			QuestControl.lucinaCorrupt = data.lucinaCorrupt; 
			QuestControl.lucinaSlimeQueen = data.lucinaSlimeQueen; 

			QuestControl.itzelQuest = data.itzelQuest; 
			QuestControl.itzelFollowerCornelia = data.itzelFollowerCornelia; //
			QuestControl.itzelChurchCornelia = data.itzelChurchCornelia; 
			QuestControl.itzelCorrupt = data.itzelCorrupt;

			QuestControl.albaQuest = data.albaQuest;
			QuestControl.albaHelp = data.albaHelp;

			QuestControl.corruptionPoints = data.corruptionPoints;

			QuestControl.vivicaCounter = data.vivicaCounter; 
			QuestControl.vivicaQuest = data.vivicaQuest;

			QuestControl.virgilQuest = data.virgilQuest ;
			QuestControl.virgilCorruptMaid = data.virgilCorruptMaid; 
			QuestControl.virgilDrugs= data.virgilDrugs; 
			QuestControl.virgilNerdyGirl= data.virgilNerdyGirl; // if false, it means he picked the slutty futa 
			QuestControl.virgilWhoreGirl = data.virgilWhoreGirl;

			QuestControl.celiaQuest = data.celiaQuest;
			QuestControl.celiaStartCorrupt = data.celiaStartCorrupt; // false is pure 
			QuestControl.celiaCheater = data.celiaCheater;

			QuestControl.lucretiusQuest = data.lucretiusQuest;
			QuestControl.lucretiusStartCorrupt= data.lucretiusStartCorrupt ; // false is pure 

			QuestControl.faustinaQuest = data.faustinaQuest; 
			QuestControl.faustinaStartCorrupt = data.faustinaStartCorrupt; 
			QuestControl.faustinaEqual = data.faustinaEqual;
			QuestControl.faustinaDom = data.faustinaDom; // SHE IS THE DOM, NO YOUR DOM PATH
			QuestControl.faustinaSub = data.faustinaSub; 



			//

			CastleController.castleCleanliness = data.castleCleanliness;
			CastleController.castleFoodQuality = data.castleFoodQuality;
			CastleController.castleSecurity = data.castleSecurity;

			CastleController.castleSupplies = data.castleSupplies;

			CastleController.castleHealthcare = data.castleHealthcare;
			CastleController.slaveMasterEff = data.slaveMasterEff;
			CastleController.maxSecurityTrain = data.maxSecurityTrain;
			CastleController.maxMartialTrain = data.maxMartialTrain;

			CastleController.castleMentalcare = data.castleMentalcare;


			CastleController.castleReinforced = data.castleReinforced;
			CastleController.castleDailyReport = data.castleDailyReport;

			CastleController.castleBoudoir = data.castleBoudoir;
			CastleController.castlePrivateRoom = data.castlePrivateRoom;
			CastleController.castleMCRoomSpace = data.castleMCRoomSpace;

			setEquipment.setEquipModifiers ();
			SceneManager.LoadScene (3);



		
		}

	}


	void Awake (){

	}





}
