using UnityEngine;
using System.Collections;

public class sceneSelectorMainQuest : MonoBehaviour {



	public int retScene()
	{

		if (QuestControl.helenaQuest < 10) {
			return 13; 
		} 

		if (QuestControl.abbadonQuest < 10) {
			return 14; 
		} 

		if (QuestControl.lucinaQuest < 9) {
			return 52;
		}
		if (QuestControl.itzelQuest < 7) {
			
			return 53;
		
		}
			
		if (QuestControl.virgilQuest < 6) {

			return 55;

		}

		if (QuestControl.celiaQuest < 7) {

			return 56;

		}
		if (QuestControl.lucretiusQuest < 7) {

			return 57;

		}

		if (QuestControl.faustinaQuest < 5) {

			return 58;

		}

		Debug.Log ("retScene finished");
		return 3; 


	}


}
