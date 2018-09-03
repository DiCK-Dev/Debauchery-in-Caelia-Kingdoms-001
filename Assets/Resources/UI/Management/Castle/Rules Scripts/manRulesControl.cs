using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class manRulesControl : MonoBehaviour {

	public Canvas alertCanvas; 
	static bool ddOccupationLoad;

	static int idxCL; // index in the charlist
	static int idxRN; // idx in the rules NPC
	static int npcid = 0;
	public Dropdown ddOccupation;
	public Dropdown ddWages;
	public Dropdown ddSleeping;
	public Dropdown ddDiet;

	static bool ddOccupationSlave; // if the character selected is slave or not 

	public Toggle togAphrodisiacs; 

	public Toggle togSilence;
	public Toggle togHumility;
	public Toggle togChastity;
	public Toggle togDenyOrgasm;
	public Toggle togDenyToileting;
	public Toggle togBehavePet;
	public Toggle togBehaveAlarm;
	public Toggle togGenitalVibes;
	public Toggle togAnalPlug;

	public Toggle togPrivBath;
	public Toggle togPrivPhysician;
	public Toggle togPersStylist;
	public Toggle togFreeTime;

	public Toggle togDrugForcedUse;
	public Toggle togDrugTobacco;
	public Toggle togDrugAlcohol;
	public Toggle togDrugDevilsFire;
	public Toggle togDrugDust;
	public Toggle togDrugBlueCapShroom;

	public Text Name, Bea, Tem, Will, Nat, Ope, Dig, Obe, Hap, Lib, Mor, Pie, Sty; 
	public Text chRank, chClass, chUpbring, chSlave; 

	////////////////////////////////////////////////////////////////////////////////////////////

	void startRules(){
		idxCL = RulesNPC.savedRules [0].idx;
		idxRN = 0;
		updateInfo ();
		loadDropdown ();
		npcid = RulesNPC.savedRules [0].id;

	}

	//used if the ID has changed
	public void rulesSelect(){

		if (npcid != WorldControl.NPCID && WorldControl.NPCID != 0){
			//idx
			int i = 0;
			while (i < NPCCharList.CharRetainers.Count) {
				if (NPCCharList.CharRetainers [i].charID == WorldControl.NPCID) {
					idxCL = i;
					break;
				}
				i++;
			}

			i = 0;


			if (RulesNPC.savedRules.Count > 0) {
				while (i < RulesNPC.savedRules.Count) {
					if (RulesNPC.savedRules [i].id == WorldControl.NPCID) {
						idxRN = i;
						break;
					}
					i++;
					if (i == RulesNPC.savedRules.Count && WorldControl.NPCID != 0) {
						fileRulesNPC npcrules = new fileRulesNPC();
						RulesNPC.savedRules.Add (npcrules);
						RulesNPC.savedRules [i].id = WorldControl.NPCID; 
						RulesNPC.savedRules [i].idx = idxCL;
						idxRN = i;

					}
				}
			} else {
				fileRulesNPC npcrules = new fileRulesNPC();
				RulesNPC.savedRules.Add (npcrules);
				RulesNPC.savedRules [i].id = WorldControl.NPCID; 
				RulesNPC.savedRules [i].idx = idxCL;
				idxRN = 0;

			}
			updateInfo ();
			loadDropdown ();
			npcid = WorldControl.NPCID;
		}

	}
		
	////////////////////////////////////////////////////////////////////////////////////////////


	void Update(){
		rulesSelect ();
	}

	////////////////////////////////////////////////////////////////////////////////////////////



	public void changeOccupation(){
		if (ddOccupationLoad) {
			return;
		}
		if (NPCCharList.CharRetainers [idxCL].isSlave) {
			switch (ddOccupation.value) {
			case 0:
				NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleRest;
				break;
			case 1:
				NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleDomestic;
				break;
			case 2:
				if (checkJobs (NPCData.Jobs.CastleCook, 3)) {
					NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleCook;
				} else {
					alertUser ("There can only be 3 cooks at the same time!");
				}
				break;
			case 3:
				if (checkJobs (NPCData.Jobs.CastleHealer, 2)) {
					NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleHealer;
				} else {
					alertUser ("There can only be 2 healers at the same time!");
				}
				break;
			case 4:
				NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleHunter;
				break;
			case 5:
				NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleEntertainer;
				break;
			case 6:
				NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleArtisan;
				break;
			case 7:
				NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleFarmhand;
				break;
			case 8:
				NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleScribe;
				break;
			case 9:
				NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleProstitute;
				break;
			default:
				break;
			}


		} else {
			switch (ddOccupation.value) {
			case 0:
				NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleRest;
				break;
			case 1:
				NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleDomestic;
				break;
			case 2:
				if (checkJobs (NPCData.Jobs.CastleCook, 3)) {
					NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleCook;
				} else {
					alertUser ("There can only be 3 cooks at the same time!");
				}
				break;
			case 3:
				if (checkJobs (NPCData.Jobs.CastleHealer, 2)) {
					NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleHealer;
				} else {
					alertUser ("There can only be 2 healers at the same time!");
				}
				break;
			case 4:
				NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleHunter;
				break;
			case 5:
				NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleEntertainer;
				break;
			case 6:
				NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleArtisan;
				break;
			case 7:
				NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleFarmhand;
				break;
			case 8:
				NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleScribe;
				break;
			case 9:
				NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleProstitute;
				break;
			case 10:
				if (checkJobs (NPCData.Jobs.CastleAccountant, 1)) {
					NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleAccountant;
				} else {
					alertUser ("You can only have 1 accountant!");
				}
				break;
			case 11:
				if (checkJobs (NPCData.Jobs.CastleSlaveMaster, 1)) {
					NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleSlaveMaster;
				} else {
					alertUser ("You can only have 1 slave master!");
				}
				break;
			case 12:
				NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleGuard;
				break;
			case 13:
				if (checkJobs (NPCData.Jobs.CastleCaptain, 1)) {
					NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleCaptain;
				} else {
					alertUser ("You can only have 1 captain of the guard!");
				}
				break;
			case 14:
				NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleCourtier;
				break;
			case 15:
				if (checkJobs (NPCData.Jobs.CastleCounselor, 1)) {
					NPCCharList.CharRetainers [idxCL].cityJobs = NPCData.Jobs.CastleCounselor;
				} else {
					alertUser ("You can only have 1 counselor!");
				}
				break;
			default:
				break;
			}

		}
		RightManCreatePan.listchanged = true;

	}

	public void changeWages(){
		if (ddOccupationLoad) {
			return;
		}
		RulesNPC.savedRules [idxRN].wage = (fileRulesNPC.Wages)ddWages.value;
	}

	public void changeSleeping(){
		if (ddOccupationLoad) {
			return;
		}
		switch (ddSleeping.value) {
		case 1: // Barracks bed
			RulesNPC.savedRules [idxRN].sleeping = fileRulesNPC.Sleeping.Barracks; 
			break;
		case 2: // private room
			if(checkRooms (fileRulesNPC.Sleeping.PrivateRoom, CastleController.castlePrivateRoom)){
				RulesNPC.savedRules [idxRN].sleeping = fileRulesNPC.Sleeping.PrivateRoom; 
			}else{
				alertUser("You only have " + CastleController.castlePrivateRoom.ToString() + " private rooms available!" );
			}
			break;
		case 3: // boudoir
			if(checkRooms (fileRulesNPC.Sleeping.Boudoir, CastleController.castleBoudoir)){
				RulesNPC.savedRules [idxRN].sleeping = fileRulesNPC.Sleeping.Boudoir; 
			}else{
				alertUser("You only have " + CastleController.castleBoudoir.ToString() + " boudoir's available!" );
			}

			break;
		case 4: // MC room
			RulesNPC.savedRules [idxRN].sleeping = fileRulesNPC.Sleeping.MCRoom; 

			if(checkRooms(fileRulesNPC.Sleeping.MCRoom, CastleController.castleMCRoomSpace)){
				RulesNPC.savedRules [idxRN].sleeping = fileRulesNPC.Sleeping.MCRoom; 
			}else{
				alertUser("You only have room for " + CastleController.castleMCRoomSpace.ToString() + " extra person!" );
			}
			break;
		default:
			RulesNPC.savedRules [idxRN].sleeping = (fileRulesNPC.Sleeping)ddSleeping.value;
			break;
		}
	}

	public void changeDiet(){
		if (ddOccupationLoad) {
			return;
		}
		switch (ddDiet.value) {
		case 4: //make exception for cum if no equipment, maybe load screen with info to close
			//RulesNPC.savedRules [idxRN].diet = fileRulesNPC.Diet.CheapFood; 
			alertUser ("We apologize, but this is not implemented yet");
			break;
		default:
			RulesNPC.savedRules [idxRN].diet = (fileRulesNPC.Diet)ddDiet.value;
			break;
		}
	}

	public void toggleChange(int selector){
		switch (selector) {
		case 0:
			toggleAphro ();
			break; 
		case 1:
			toggleSilence ();
			break;
		case 2:
			toggleHumility ();
			break;
		case 3:
			toggleChastity ();
			break;
		case 4:
			toggleOrgasm ();
			break;
		case 5:
			toggleToileting ();
			break;
		case 6:
			toggleBehavePet ();
			break;
		case 7:
			toggleBehaveAlarm ();
			break;
		case 8:
			toggleGenitalVibes ();
			break;
		case 9:
			toggleAnalPlug ();
			break;
		case 10:
			toggleBath ();
			break;
		case 11:
			togglePhysician ();
			break;
		case 12:
			toggleStylist ();
			break;
		case 13:
			toggleFreetime ();
			break;
		case 14:
			toggleTobacco ();
			break;
		case 15:
			toggleAlcohol ();
			break;
		case 16:
			toggleDevilsFire ();
			break;
		case 17:
			toggleDust ();
			break;
		case 18:
			toggleBlueCap ();
			break;
		case 19:
			toggleForcedUse ();
			break;
		}

	}
	void toggleAphro(){
		RulesNPC.savedRules [idxRN].foodAphrodisiacs = togAphrodisiacs.isOn;
	}

	void toggleSilence(){
		RulesNPC.savedRules [idxRN].forceSilence = togSilence.isOn;
	}

	void toggleHumility(){
		RulesNPC.savedRules [idxRN].forceHumility = togHumility.isOn;
	}

	void toggleChastity(){
		RulesNPC.savedRules [idxRN].chastityBelt = togChastity.isOn;
	}

	void toggleOrgasm(){
		RulesNPC.savedRules [idxRN].denyOrgasm = togDenyOrgasm.isOn;
	}

	void toggleToileting(){
		RulesNPC.savedRules [idxRN].denyToileting = togDenyToileting.isOn;
	}

	void toggleBehavePet(){
		RulesNPC.savedRules [idxRN].behavePet = togBehavePet.isOn;
	}

	void toggleBehaveAlarm(){
		RulesNPC.savedRules [idxRN].behaveAlarm = togBehavePet.isOn;
	}

	void toggleGenitalVibes(){
		RulesNPC.savedRules [idxRN].genitalVibes = togGenitalVibes.isOn;
	}

	void toggleAnalPlug(){
		RulesNPC.savedRules [idxRN].analPlug = togAnalPlug.isOn;
	}

	void toggleBath(){
		RulesNPC.savedRules [idxRN].privateBath = togPrivBath.isOn;
	}

	void togglePhysician(){
		RulesNPC.savedRules [idxRN].privPhysician = togPrivPhysician.isOn;
	}

	void toggleStylist(){
		RulesNPC.savedRules [idxRN].persStylist = togPersStylist.isOn;
	}

	void toggleFreetime(){
		RulesNPC.savedRules [idxRN].freeTime = togFreeTime.isOn;
	}

	void toggleTobacco(){
		RulesNPC.savedRules [idxRN].drugTobacco = togDrugTobacco.isOn;
	}

	void toggleAlcohol(){
		RulesNPC.savedRules [idxRN].drugAlcohol = togDrugAlcohol.isOn;
	}

	void toggleDevilsFire(){
		RulesNPC.savedRules [idxRN].drugDevilsFire = togDrugDevilsFire.isOn;
	}

	void toggleDust(){
		RulesNPC.savedRules [idxRN].drugDust = togDrugDust.isOn;
	}

	void toggleBlueCap(){
		RulesNPC.savedRules [idxRN].drugBlueCapShroom = togDrugBlueCapShroom.isOn;
	}

	void toggleForcedUse(){
		RulesNPC.savedRules [idxRN].drugForcedUse = togDrugForcedUse.isOn;
	}



	void updateInfo(){
		Name.text = NPCCharList.CharRetainers[idxCL].charName + " " + NPCCharList.CharRetainers[idxCL].charNickname + " " + NPCCharList.CharRetainers[idxCL].charSurname;
		Bea.text = Mathf.Round(NPCCharList.CharRetainers[idxCL].attBeauty).ToString();
		Tem.text = Mathf.Round(NPCCharList.CharRetainers [idxCL].attTemperament).ToString ();
		Will.text = Mathf.Round(NPCCharList.CharRetainers [idxCL].attWillpower).ToString ();
		Nat.text = Mathf.Round(NPCCharList.CharRetainers [idxCL].attNature).ToString ();
		Ope.text = Mathf.Round(NPCCharList.CharRetainers [idxCL].attOpenness).ToString ();
		Dig.text = Mathf.Round(NPCCharList.CharRetainers [idxCL].attDignity).ToString ();
		Obe.text = Mathf.Round (NPCCharList.CharRetainers [idxCL].attObedience).ToString ();
		Hap.text = Mathf.Round(NPCCharList.CharRetainers [idxCL].attHappiness).ToString ();
		Lib.text = Mathf.Round(NPCCharList.CharRetainers [idxCL].attLibido).ToString ();
		Mor.text = Mathf.Round(NPCCharList.CharRetainers [idxCL].attMorality).ToString ();
		Pie.text = Mathf.Round(NPCCharList.CharRetainers [idxCL].attPiety).ToString ();
		Sty.text = Mathf.Round(NPCCharList.CharRetainers [idxCL].attStyle).ToString ();

		chRank.text = "Rank: " + NPCCharList.CharRetainers [idxCL].charRank.toDescription ();
		chClass.text = "Class: " + NPCCharList.CharRetainers [idxCL].charClass.toDescription ();
		chUpbring.text = "Upbring: " +NPCCharList.CharRetainers [idxCL].bgUpbring.toDescription ();
		if (NPCCharList.CharRetainers [idxCL].isSlave) {
			chSlave.text = "Slave";
		} else {
			chSlave.text = "Free citizen";
		}

		togAphrodisiacs.isOn = RulesNPC.savedRules[idxRN].foodAphrodisiacs; 

		togSilence.isOn = RulesNPC.savedRules[idxRN].forceSilence;
		togHumility.isOn = RulesNPC.savedRules[idxRN].forceHumility;
		togChastity.isOn = RulesNPC.savedRules[idxRN].chastityBelt;
		togDenyOrgasm.isOn = RulesNPC.savedRules[idxRN].denyOrgasm;
		togDenyToileting.isOn = RulesNPC.savedRules[idxRN].denyToileting;
		togBehavePet.isOn = RulesNPC.savedRules[idxRN].behavePet;
		togBehaveAlarm.isOn = RulesNPC.savedRules[idxRN].behaveAlarm;
		togGenitalVibes.isOn = RulesNPC.savedRules[idxRN].genitalVibes;
		togAnalPlug.isOn = RulesNPC.savedRules[idxRN].analPlug;

		togPrivBath.isOn = RulesNPC.savedRules[idxRN].privateBath;
		togPrivPhysician.isOn = RulesNPC.savedRules[idxRN].privPhysician;
		togPersStylist.isOn = RulesNPC.savedRules[idxRN].persStylist;
		togFreeTime.isOn = RulesNPC.savedRules[idxRN].freeTime;

		togDrugTobacco.isOn = RulesNPC.savedRules[idxRN].drugTobacco;
		togDrugAlcohol.isOn = RulesNPC.savedRules[idxRN].drugAlcohol;
		togDrugDevilsFire.isOn = RulesNPC.savedRules[idxRN].drugDevilsFire;
		togDrugDust.isOn = RulesNPC.savedRules[idxRN].drugDust;
		togDrugBlueCapShroom.isOn = RulesNPC.savedRules[idxRN].drugBlueCapShroom;
		togDrugForcedUse.isOn = RulesNPC.savedRules [idxRN].drugForcedUse;

	}






	void loadDropdown(){
		ddOccupationLoad = true;
		ddOccupation.ClearOptions ();

		if (NPCCharList.CharRetainers [idxCL].isSlave) {
			ddOccupation.options.Add(new Dropdown.OptionData("Rest"));
			ddOccupation.options.Add(new Dropdown.OptionData("Domestic servant"));
			ddOccupation.options.Add(new Dropdown.OptionData("Cook"));
			ddOccupation.options.Add(new Dropdown.OptionData("Healer"));
			ddOccupation.options.Add(new Dropdown.OptionData("Hunter"));
			ddOccupation.options.Add(new Dropdown.OptionData("Entertainer"));
			ddOccupation.options.Add(new Dropdown.OptionData("Artisan"));
			ddOccupation.options.Add(new Dropdown.OptionData("Farmhand"));
			ddOccupation.options.Add(new Dropdown.OptionData("Scribe"));
			ddOccupation.options.Add(new Dropdown.OptionData("Prostitute"));


		} else {
			ddOccupation.options.Add(new Dropdown.OptionData("Rest"));
			ddOccupation.options.Add(new Dropdown.OptionData("Domestic servant"));
			ddOccupation.options.Add(new Dropdown.OptionData("Cook"));
			ddOccupation.options.Add(new Dropdown.OptionData("Healer"));
			ddOccupation.options.Add(new Dropdown.OptionData("Hunter"));
			ddOccupation.options.Add(new Dropdown.OptionData("Entertainer"));
			ddOccupation.options.Add(new Dropdown.OptionData("Artisan"));
			ddOccupation.options.Add(new Dropdown.OptionData("Farmhand"));
			ddOccupation.options.Add(new Dropdown.OptionData("Scribe"));
			ddOccupation.options.Add(new Dropdown.OptionData("Prostitute"));
			ddOccupation.options.Add(new Dropdown.OptionData("Accountant"));
			ddOccupation.options.Add(new Dropdown.OptionData("Slave master"));
			ddOccupation.options.Add(new Dropdown.OptionData("Guard"));
			ddOccupation.options.Add(new Dropdown.OptionData("Captain"));
			ddOccupation.options.Add(new Dropdown.OptionData("Courtier"));
			ddOccupation.options.Add(new Dropdown.OptionData("Counselor"));
		}
		ddOccupation.value = 1;
		ddOccupation.value = ddReturn(0);
		ddWages.value = ddReturn(1);
		ddSleeping.value = ddReturn(2);
		ddDiet.value = ddReturn(3);
		ddOccupationLoad = false;
	}


	bool checkJobs(NPCData.Jobs job, int max){
		int i = 0;
		int count = 0;
		while (i < NPCCharList.CharRetainers.Count) {
			if (NPCCharList.CharRetainers [i].cityJobs == job) {
				count++;
			}
			i++;
		}

		if (count >= max) {
			return false;
		}

		return true; 

	}

	bool checkRooms(fileRulesNPC.Sleeping sleeping, int max){
		int i = 0;
		int count = 0;
		while (i < RulesNPC.savedRules.Count) {
			if (RulesNPC.savedRules[i].sleeping == sleeping) {
				count++;
			}
			i++;
		}

		if (count >= max) {
			return false;
		}

		return true; 
	}

	int checkJobsNum (NPCData.Jobs job){
		int i = 0;
		int count = 0;
		while (i < NPCCharList.CharRetainers.Count) {
			if (NPCCharList.CharRetainers [i].cityJobs == job) {
				count++;
			}
			i++;
		}
		return count;

	}

	int ddReturn(int selector){
		if (selector == 0) {
			NPCData.Jobs job = NPCCharList.CharRetainers [idxCL].cityJobs;
			switch (job) {
			case NPCData.Jobs.CastleRest: return 0;
			case NPCData.Jobs.CastleDomestic: return 1;
			case NPCData.Jobs.CastleCook: return 2;
			case NPCData.Jobs.CastleHealer: return 3;
			case NPCData.Jobs.CastleHunter: return 4;
			case NPCData.Jobs.CastleEntertainer: return 5;
			case NPCData.Jobs.CastleArtisan: return 6;
			case NPCData.Jobs.CastleFarmhand: return 7;
			case NPCData.Jobs.CastleScribe: return 8;
			case NPCData.Jobs.CastleProstitute: return 9;
			case NPCData.Jobs.CastleAccountant: return 10;
			case NPCData.Jobs.CastleSlaveMaster: return 11;
			case NPCData.Jobs.CastleGuard: return 12;
			case NPCData.Jobs.CastleCaptain: return 13;
			case NPCData.Jobs.CastleCourtier: return 14;
			case NPCData.Jobs.CastleCounselor: return 15;
			default: return 0;
			}
		} else if (selector == 1) {
			fileRulesNPC.Wages wages = RulesNPC.savedRules[idxRN].wage;
			switch (wages) {
			case fileRulesNPC.Wages.None: return 0;
			case fileRulesNPC.Wages.Low: return 1;
			case fileRulesNPC.Wages.Average: return 2;
			case fileRulesNPC.Wages.Good: return 3;
			case fileRulesNPC.Wages.High: return 4;
			case fileRulesNPC.Wages.Exorbitant: return 5;
			default: return 0;
			}
		} else if (selector == 2) {
			fileRulesNPC.Sleeping sleeping = RulesNPC.savedRules[idxRN].sleeping;
			switch (sleeping) {
			case fileRulesNPC.Sleeping.Ground: return 0;
			case fileRulesNPC.Sleeping.Barracks: return 1;
			case fileRulesNPC.Sleeping.PrivateRoom: return 2;
			case fileRulesNPC.Sleeping.Boudoir: return 3;
			case fileRulesNPC.Sleeping.MCRoom: return 4;
			case fileRulesNPC.Sleeping.Dungeon: return 5;
			default: return 0;
			}
		} else {
			fileRulesNPC.Diet diet = RulesNPC.savedRules[idxRN].diet;
			switch (diet) {
			case fileRulesNPC.Diet.RancidFood: return 0;
			case fileRulesNPC.Diet.CheapFood: return 1;
			case fileRulesNPC.Diet.FreshFood: return 2;
			case fileRulesNPC.Diet.LeftOvers: return 3;
			case fileRulesNPC.Diet.BeastsCum: return 4;
			default: return 0;
			}
		}

	}
	static public string returnReport(){
		return RulesNPC.savedRules [idxRN].reportNew;
	}

	void alertUser(string msg){
		alertText.alertMessage = msg;
		alertCanvas.sortingOrder = 3000;
	}

	void Awake ()
	{



	}

	void Start(){
		startRules ();

	}





}
