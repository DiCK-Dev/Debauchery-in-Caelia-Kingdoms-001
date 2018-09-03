using UnityEngine;
using System.Collections;

public class CreateEnemies : MonoBehaviour {
	int randNum;

	NPCCreator npcCreator = new NPCCreator();

	public int region; 

	public void createEnemy(){
		switch(region){
		case 0:
			Random.InitState (WorldControl.day * System.DateTime.Now.Millisecond * WorldControl.dayTime);
			randNum = Random.Range (0, 100);

			if (randNum > 80) {
				npcCreator.charCreator (1000, 1000, 2, 1000, 1000, 1000, 1000, 1000, 1000, 0, 0, false);
			}else if (randNum > 60){
				npcCreator.charCreator (1000, 1000, 2, 1000, 1000, 1000, 1000, 1000, 1000, 4, 36, false);
			}else if (randNum > 40) {
				npcCreator.charCreator (1000, 1000, 2, 1000, 1000, 1000, 1000, 1000, 1000, 1, 2, false);
			} else if (randNum > 20) {
				npcCreator.charCreator (1000, 1000, 2, 1000, 1000, 1000, 1000, 1000, 1000, 4, 67, false);
			} else {
				npcCreator.charCreator (1000, 1000, 2, 1000, 1000, 1000, 1000, 1000, 1000, 4, 34, false);
			}

			NPCCharList.CharMonster [0].charCorruption += Random.Range (15, 50);
			if (NPCCharList.CharMonster [0].charCorruption > 100) {
				NPCCharList.CharMonster [0].charCorruption = 100;
			}

			break;
		case 13000:
			if (QuestControl.albaHelp) {
				npcCreator.charCreator (0, 0, 2, 1000, 12, 2, 1000, 82, 1000, 4, /*?*/55, false);
				break;
			} else {
				npcCreator.charCreator (0, 0, 2, 1000, 8, 2, 1000, 82, 1000, 1, 3, false);

				break;
			}
		default:
			break;
		}


	}

	public void Awake(){
		NPCCharList.CharMonster.Clear ();
		createEnemy ();

	}

}
