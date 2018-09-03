using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 


public class Lucina : MonoBehaviour {
	static int iLucina; 

	public Text Board; 




	void Start () {
		loadLucina ();
		Board.text = "This is all the content for Lucina for now, keep tuned for new content!";
		if (QuestControl.lucinaQuest == 0) {
			QuestsController.RemoveID (6000);
			Quest LucinaQuest1 = new Quest ();
			QuestsController.createQuest (LucinaQuest1, "Reunion", "Helena comes at you with haste to inform you about an unexpected guess in the dungeon.", 62, 6000);

		}

		//SceneManager.LoadScene (62);

	}


	void loadLucina(){
		iLucina = 0;

		while (iLucina < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iLucina].charID == 6000){
				WorldControl.NPCID = NPCCharList.CharFollower [iLucina].charID;
				WorldControl.PortraitIDLayer0 = NPCCharList.CharFollower [iLucina].charPortraitLayer0;
				WorldControl.PortraitIDLayer1 = NPCCharList.CharFollower [iLucina].charPortraitLayer1;
				WorldControl.PortraitIDLayer2 = NPCCharList.CharFollower [iLucina].charPortraitLayer2;
				break; 
			}
			iLucina++;

		}

	}
	


}
