using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LunaMain : MonoBehaviour {

	public Canvas endTurnPanel; 

	public Text Board; 
	static int iLuna;



	// Use this for initialization
	void Start () {
		loadLuna ();
		Board.text = "This is all the content available for her for this update, keep tuned for more!";

	}





	void loadLuna(){
		iLuna = 0;

		while (iLuna < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iLuna].charID == 14000){
				WorldControl.NPCID = NPCCharList.CharFollower [iLuna].charID;
				WorldControl.PortraitIDLayer0 = NPCCharList.CharFollower [iLuna].charPortraitLayer0;
				WorldControl.PortraitIDLayer1 = NPCCharList.CharFollower [iLuna].charPortraitLayer1;
				WorldControl.PortraitIDLayer2 = NPCCharList.CharFollower [iLuna].charPortraitLayer2;
				break; 
			}
			iLuna++;

		}

	}
}
