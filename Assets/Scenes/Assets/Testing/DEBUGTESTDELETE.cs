using UnityEngine;
using System.Collections;

public class DEBUGTESTDELETE : MonoBehaviour {

	public void updateCastleDebug(){
		CastleUpdate.updateCastle ();
	}

	NPCCreator npcCreator = new NPCCreator();
	// Use this for initialization
	void Awake () {
		CastleController.castleCleanliness = 50;
		CastleController.castleFoodQuality = 50;
		CastleController.castleSupplies = 1500;
		GameControl.charGold = 4000;
		npcCreator.charCreator (1000, 1000, 3, 1000, 1000, 1000, 1000, 1000, 1000, 1, 1000, false);
		npcCreator.charCreator (1000, 1000, 3, 1000, 1000, 1000, 1000, 1000, 1000, 1, 1000, false);
		npcCreator.charCreator (1000, 1000, 3, 1000, 1000, 1000, 1000, 1000, 1000, 1, 1000, false);
		npcCreator.charCreator (1000, 1000, 3, 1, 1000, 1000, 1000, 1000, 1000, 1, 1000, false);
		npcCreator.charCreator (1000, 1000, 2, 1, 1000, 1000, 1000, 1000, 1000, 1, 1000, false);


	




	}
	


}
