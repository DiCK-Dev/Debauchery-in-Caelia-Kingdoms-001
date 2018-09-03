using UnityEngine;
using System.Collections;
using System.Collections.Generic;


[System.Serializable]
public class QuestsController {
	public static List<Quest> ActiveQuests = new List<Quest>();

	public static int questIndex = 0; 

	public static void createQuest(Quest quest, string name, string description, int scene, int id){
		ActiveQuests.Add (quest);
		ActiveQuests [ActiveQuests.Count - 1].name = name;
		ActiveQuests [ActiveQuests.Count - 1].description = description;
		ActiveQuests [ActiveQuests.Count - 1].scene = scene; 
		ActiveQuests [ActiveQuests.Count - 1].ID = id; 
	}

	public static void RemoveComplete() {
		int i = 0;
		while (i < ActiveQuests.Count) {
			if (ActiveQuests [i].complete) {
				ActiveQuests.RemoveAt (i);

				break; 
			}
			i++;
		}
	}


	public static void RemoveID(int id) {
		int i = 0;

		while (i < ActiveQuests.Count) {
			if (ActiveQuests [i].ID == id) {
				ActiveQuests.RemoveAt (i);

				break; 
			}
			i++;
		}
	}


}


[System.Serializable]
public class Quest {
	public int ID; 
	public string name;
	public string description; 
	public int scene; 
	public int step = 0;
	public bool complete = false; 


}