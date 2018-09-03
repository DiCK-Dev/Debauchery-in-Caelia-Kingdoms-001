using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Base : MonoBehaviour {

	public Button buttBarracks;

	void Awake(){
		WorldControl.location = "Aurorum Castle"; 
		WorldControl.NPCID = 0;
		WorldControl.furryPic = false; 
		WorldControl.futaPic = false; 
	}

	// Use this for initialization
	void Start () {
		if (QuestControl.abbadonQuest >= 3) {
			buttBarracks.interactable = true;
		} else {
			buttBarracks.interactable = false;

		}
	}


}
