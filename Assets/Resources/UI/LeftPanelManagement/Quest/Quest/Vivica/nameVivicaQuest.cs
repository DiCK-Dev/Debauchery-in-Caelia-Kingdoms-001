using UnityEngine;
using System.Collections;

public class nameVivicaQuest : MonoBehaviour {
	
	static int iVivica; 

	void loadVivica(){
		iVivica = 0;

		while (iVivica < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iVivica].charID == 8000){
				WorldControl.NPCID = NPCCharList.CharFollower [iVivica].charID;
				WorldControl.PortraitIDLayer0 = NPCCharList.CharFollower [iVivica].charPortraitLayer0;
				WorldControl.PortraitIDLayer1 = NPCCharList.CharFollower [iVivica].charPortraitLayer2;
				WorldControl.PortraitIDLayer2 = NPCCharList.CharFollower [iVivica].charPortraitLayer2;
				WorldControl.furryPic = NPCCharList.CharFollower [iVivica].isFurry;
				WorldControl.futaPic = NPCCharList.CharFollower [iVivica].isFuta;
				break; 
			}
			iVivica++;

		}

	}




	public string retName(){
		if (QuestControl.vivicaQuest < 14) {
			switch (QuestControl.vivicaQuest) {
			case 0:
				return "Siblings";
			case 1:
				return "Childhood memories";
			case 2:
				return "What I am now";
			case 3:
				return "Hidden power";
			case 4:
				return "Schools of Magic";
			case 5:
				return "School of Destruction";
			case 6:
				return "School of Persuasion";
			case 7:
				return "School of Restoration";
			case 8:
				return "School of Entropy";
			case 9:
				return "Artifacts";

			case 10:
				return "The Old Pact";

			case 11:
				loadVivica ();
				if (NPCCharList.CharFollower [iVivica].corruptionStage >= 4) {
					return "Plotting";
				} else {
					return "Intervention";
				}
			case 12:
				loadVivica ();
				if (NPCCharList.CharFollower [iVivica].corruptionStage >= 4) {
					return "The Ritual";
				} else {
					return "Family bonds";
				}
			case 13:
				loadVivica ();
				if (NPCCharList.CharFollower [iVivica].corruptionStage >= 4) {
					return "Possession";
				} else {
					return "The Banishment";
				}
			case 14:
				return "quest 14 - bug";

			}

		}

		return "bug or done";

	}

}




