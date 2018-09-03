using UnityEngine;
using System.Collections;

public class CreateHireableWorkers {
	static int dayCount = 10; 
	NPCCreator npcCreator = new NPCCreator();

	public void createNewWorkers(){

		if (dayCount >= 3) {
			cleanOldWorkers ();
			int randNum = Random.Range (2, 6);
			int i = 0;
			while (i < randNum) {
				
				 npcCreator.charCreator (1000, 1000, 3, 1000, 1000, 1000, 1000, 1000, 1000, 1, 1000, false);
				i++;
			}
			dayCount = 0;
			return;
		}
		dayCount++;
	}

	static void cleanOldWorkers(){
		int i = 0;
		while (i < NPCCharList.CharRetainers.Count) {
			if (NPCCharList.CharRetainers [i].isNeutral) {
				NPCCharList.CharRetainers.RemoveAt (i);
				i--;
			}
			i++;
		}

	}

}
