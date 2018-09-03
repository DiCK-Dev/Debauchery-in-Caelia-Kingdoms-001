using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NPCRetainersSexControl : MonoBehaviour {

	public Text Board; 
	public Canvas endTurnPanel; 
	public Canvas mainPanel;

	public void openSexPan(){
		if (WorldControl.idx < 0) {
			WorldControl.idx = 0;
		}
		if (NPCCharList.CharRetainers.Count == 0) {
			Board.text = "You have no retainers!";
			return;
		}
		Board.text = "What you want to do with " + NPCCharList.CharRetainers [WorldControl.idx].charName + "? These actions will end the turn!";
	}


	public void selectScene(int selector){ // give handjob 
		if (NPCCharList.CharRetainers.Count == 0) {
			Board.text = "You have no retainers!";
			return;
		}

		GameControl.actualArousal = 0;

		if (selector == 0) {
			if (NPCCharList.CharRetainers [WorldControl.idx].hasVagina && NPCCharList.CharRetainers [WorldControl.idx].dickSize > 0) {
				//handjob to npc futa
				Board.text = NPCRetainersSexScenes.Good_HJ_2NPC_F();
				/* NOT IN USRE RIGHT NOW BECAUSE I DONT HAVE THE CONTENT
				if (NPCCharList.CharRetainers [WorldControl.idx].charCorruption > 66) {

				} else if (NPCCharList.CharRetainers [WorldControl.idx].charRelationship > 50) {

				} else {

				}*/
			} else if (NPCCharList.CharRetainers [WorldControl.idx].hasVagina) {
				//handjob to npc vag
				Board.text = NPCRetainersSexScenes.Good_HJ_2NPC_V();
			} else {
				//handjob to npc dick
				Board.text = NPCRetainersSexScenes.Good_HJ_2NPC_D();
			}
				
		}

		if (selector == 1) { //npc handjob to MC- npc Neut
			if (GameControl.hasVagina && GameControl.dick1Size > 0) {
				//handjob to npc futa
				Board.text = NPCRetainersSexScenes.Good_HJ_2MC_F();
			} else if (GameControl.hasVagina) {
				//handjob to npc vag
				Board.text = NPCRetainersSexScenes.Good_HJ_2MC_V();
			} else {
				//handjob to npc dick
				Board.text = NPCRetainersSexScenes.Good_HJ_2MC_D();
			}

		}

		if (selector == 2) { //MC Blowjob to npc - mc neut 
			if (NPCCharList.CharRetainers [WorldControl.idx].hasVagina && NPCCharList.CharRetainers [WorldControl.idx].dickSize > 0) {
				//blowjob to npc futa
				Board.text = NPCRetainersSexScenes.Good_BJ_2NPC_F();
			} else if (NPCCharList.CharRetainers [WorldControl.idx].hasVagina) {
				//blowjob to npc vag
				Board.text = NPCRetainersSexScenes.Good_BJ_2NPC_V();
			} else {
				//blowjob to npc dick
				Board.text = NPCRetainersSexScenes.Good_BJ_2NPC_D();
			}

		}

		endTurnFun ();
	}


	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		mainPanel.sortingOrder = -500;
		endTurnPanel.sortingOrder = 500;
	}


}
