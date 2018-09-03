using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Virgil : MonoBehaviour {

	public Text Board; 
	static int iVirgil;

	static int confirmationControl; 
	static int continueControl; 

	public Canvas endTurnPanel; 
	//public Canvas panContinue;


	public Canvas panConfirmation;

	public Canvas panMainPanel;

	public Text option0Name;
	public Text option1Name;
	public Text option2Name;

	public Button option2Butt; 




	static string mcpronoun; // lord/lady




	public void virgilStart(){
		switch (QuestControl.virgilQuest)
		{

		default:
			Board.text = "You visit Virgil's house, what you want to do?";
			panMainPanel.sortingOrder = 500;
			break;
		}


	}


	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


	void loadVirgil(){
		iVirgil = 0;



		while (iVirgil < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iVirgil].charID == 9000){
				WorldControl.NPCID = NPCCharList.CharFollower [iVirgil].charID;
				WorldControl.PortraitIDLayer0 = NPCCharList.CharFollower [iVirgil].charPortraitLayer0;
				WorldControl.PortraitIDLayer1 = NPCCharList.CharFollower [iVirgil].charPortraitLayer1;
				WorldControl.PortraitIDLayer2 = NPCCharList.CharFollower [iVirgil].charPortraitLayer2;
				break; 
			}
			iVirgil++;

		}

	}


	void endTurnFun(){
		//panContinue.sortingOrder = -500;
		panConfirmation.sortingOrder = -500;
		panMainPanel.sortingOrder = -500;

		PanLeftManagement.endTurnControl = true; 
		endTurnPanel.sortingOrder = 500;


	}

	void Awake(){
		loadVirgil ();
	}

	void Start () {
		virgilStart ();

	}
	


}
