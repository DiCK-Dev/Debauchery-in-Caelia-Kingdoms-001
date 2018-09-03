using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CombatSexSceneVictoryForest : MonoBehaviour {


	public Text Board; 
	public Canvas endTurnPanel; 
	public Canvas mainPanel;

	public Text option0Name;
	public Text option1Name;
	public Text option2Name;
	public Text option3Name;
	public Text option4Name;
	public Text option5Name;
	public Text option6Name;
	public Text option7Name;

	public Button option0Butt; 
	public Button option1Butt; 
	public Button option2Butt; 
	public Button option3Butt; 
	public Button option4Butt; 
	public Button option5Butt; 
	public Button option6Butt; 
	public Button option7Butt; 


	public void selectScene(int selector){
		GameControl.actualArousal = 0;
		if (selector == 0) { 
			
			if (NPCCharList.CharMonster [0].charRace == NPCData.CharRace.Elf) {// GET ORAL / MC GETS SUCKED
				if (GameControl.dick1Size > 0) {
					Board.text = CombatSexSceneVictoryElf.NPCSucksMCDick ();
				} else {
					Board.text = CombatSexSceneVictoryElf.NPCSucksMCVag ();
				}
			}else if (NPCCharList.CharMonster [0].charRace == NPCData.CharRace.Wolf) {
				Board.text = CombatSexSceneVictoryWolf.MCDickWolfVagSex ();

			} else if (NPCCharList.CharMonster [0].charRace == NPCData.CharRace.dragon) {
				Board.text = CombatSexSceneVictoryDragon.MCNNPCNAnal();
			}else {
				Board.text = CombatSexSceneVictoryGeneric.GenericSexOral ();
			}
		}
		if (selector == 1) { 
			if (NPCCharList.CharMonster [0].charRace == NPCData.CharRace.Elf) {// GIVE ORAL / MC SUCKS NPC
				if (NPCCharList.CharMonster [0].dickSize > 0) {
					Board.text = CombatSexSceneVictoryElf.MCSucksNPCDick ();
				} else {
					Board.text = CombatSexSceneVictoryElf.MCSucksNPCVag ();
				}
			} else if (NPCCharList.CharMonster [0].charRace == NPCData.CharRace.dragon) {
				Board.text = CombatSexSceneVictoryDragon.MCVagNPCDickDP();
			}else if (NPCCharList.CharMonster [0].charRace == NPCData.CharRace.Wolf) {
				Board.text = CombatSexSceneVictoryWolf.MCDickNPCNAnal ();

			}else {
				Board.text = CombatSexSceneVictoryGeneric.GenericSexRide ();
			}
		}
		if (selector == 2) {

			if (NPCCharList.CharMonster [0].charRace == NPCData.CharRace.Elf) {// RIDE NPC  VAG
				Board.text = CombatSexSceneVictoryElf.NPCFucksMCVag();
			} else if (NPCCharList.CharMonster [0].charRace == NPCData.CharRace.dragon) {
				Board.text = CombatSexSceneVictoryDragon.MCDickNPCNOral();
			}else if (NPCCharList.CharMonster [0].charRace == NPCData.CharRace.Wolf) {
				Board.text = CombatSexSceneVictoryWolf.MCNonWolfDickOral ();

			} else {
				Board.text = CombatSexSceneVictoryGeneric.GenericSexFuckNPC ();
			}
		}


		if (selector == 3) {

			if (NPCCharList.CharMonster [0].charRace == NPCData.CharRace.Elf) {// RIDE NPC ANAL
				Board.text = CombatSexSceneVictoryElf.NPCFucksMCAss();
			} else {
				//Board.text = CombatSexSceneVictoryGeneric.GenericSexFuckNPC ();
			}
		}

		if (selector == 4) {

			if (NPCCharList.CharMonster [0].charRace == NPCData.CharRace.Elf) {// FUCK NPC ANAL
				Board.text = CombatSexSceneVictoryElf.MCFucksNPCAss ();
			} else {
				//Board.text = CombatSexSceneVictoryGeneric.GenericSexFuckNPC ();
			}
		}

		if (selector == 5) {

			if (NPCCharList.CharMonster [0].charRace == NPCData.CharRace.Elf) {// FUCK NPC ANAL
				Board.text = CombatSexSceneVictoryElf.MCFucksNPCVag ();
			} else {
				//Board.text = CombatSexSceneVictoryGeneric.GenericSexFuckNPC ();
			}
		}

		endTurnFun ();
	}


	void Start () {

		string heshe = "he", hisher = "his", himher = "him", HESHE = "He", HISHER = "His", HIMHER = "Him"; 
		if (NPCCharList.CharMonster [0].charGender == NPCData.CharGender.FEMALE) {
			heshe = "she"; hisher = "her"; himher = "her"; HESHE = "She"; HISHER = "Her"; HIMHER = "Her"; 
		}

		option0Name.text = "";
		option1Name.text = "";
		option2Name.text = "";
		option3Name.text = "";
		option4Name.text = "";
		option5Name.text = "";
		option6Name.text = "";
		option7Name.text = "";

		option0Butt.interactable = false;
		option1Butt.interactable = false;
		option2Butt.interactable = false;
		option3Butt.interactable = false;
		option4Butt.interactable = false;
		option5Butt.interactable = false;
		option6Butt.interactable = false;
		option7Butt.interactable = false;

		if (NPCCharList.CharMonster [0].charRace == NPCData.CharRace.Elf) {
			option0Name.text = "Get oral";
			option0Butt.interactable = true;

			option1Name.text = "Give oral";
			option1Butt.interactable = true;

			option2Name.text = "Ride " + himher + " (vag)";
			if (NPCCharList.CharMonster [0].dickSize > 0 && GameControl.hasVagina) {
				option2Butt.interactable = true;
			} else {
				option2Butt.interactable = false;
			}

			option3Name.text = "Ride " + himher + " (anal)";
			if (NPCCharList.CharMonster [0].dickSize > 0) {
				option3Butt.interactable = true;
			} else {
				option3Butt.interactable = false;
			}

			option4Name.text = "Fuck " + himher + " (anal)";
			if (GameControl.dick1Size > 0) {
				option4Butt.interactable = true;
			} else {
				option4Butt.interactable = false;
			}

			option5Name.text = "Fuck " + himher + " (vag)";
			if (GameControl.dick1Size > 0 && NPCCharList.CharMonster [0].dickSize <= 0 && NPCCharList.CharMonster [0].hasVagina) {
				option5Butt.interactable = true;
			} else {
				option5Butt.interactable = false;
			}



		} else if (NPCCharList.CharMonster [0].charRace == NPCData.CharRace.Wolf) {
			option0Name.text = "Fuck (vagina)";
			if (GameControl.dick1Size > 0 && NPCCharList.CharMonster [0].hasVagina) {
				option0Butt.interactable = true;
			} else {
				option0Butt.interactable = false;
			}

			option1Name.text = "Fuck (anal)";
			if (GameControl.dick1Size > 0) {
				option1Butt.interactable = true;
			} else {
				option1Butt.interactable = false;
			}

			option2Name.text = "Suck cock";
			if (NPCCharList.CharMonster [0].dickSize > 0) {
				option2Butt.interactable = true;
			} else {
				option2Butt.interactable = false;
			}

		} else if (NPCCharList.CharMonster [0].charRace == NPCData.CharRace.dragon) {
			option0Name.text = "Use tail (anal to yourself)";
			option0Butt.interactable = true;


			option1Name.text = "Ride (req: vag)";
			if (GameControl.hasVagina && NPCCharList.CharMonster [0].dickSize > 0 ) {
				option1Butt.interactable = true;
			} else {
				option1Butt.interactable = false;
			}

			option2Name.text = "Receive oral (req: dick)";
			if (GameControl.dick1Size > 0) {
				option2Butt.interactable = true;
			} else {
				option2Butt.interactable = false;
			}

		}else {
			option0Name.text = "Get oral";
			option0Butt.interactable = true;

			if (NPCCharList.CharMonster [0].dickSize > 0) {
				option1Butt.interactable = true;
				option1Name.text = "Ride "+himher+"";
			} else {
				option1Butt.interactable = false;
				option1Name.text = "Ride "+himher+"";
			}

			if (GameControl.dick1Size > 0) {
				option2Butt.interactable = true;
				option2Name.text = "Fuck "+himher+"";
			} else {
				option2Butt.interactable = false;
				option2Name.text = "Fuck "+himher+"";
			}

		}



	}


	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		mainPanel.sortingOrder = -500;
		endTurnPanel.sortingOrder = 500;
	}

}
