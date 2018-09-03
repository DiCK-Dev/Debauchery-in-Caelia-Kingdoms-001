using UnityEngine;
using System.Collections;

public class leftPanQuestCreateVivica : MonoBehaviour {


	public GameObject itemVivicaPrefab; 

	void vivicaQuest(){
		if (QuestControl.vivicaCounter <= 0 && QuestControl.vivicaQuest < 14) {
			//change it to the end
			GameObject newItem = Instantiate (itemVivicaPrefab) as GameObject;
			newItem.name = gameObject.name + " VivicaQuest";
			newItem.transform.parent = gameObject.transform;
		}

	}


	void Start(){

		vivicaQuest ();
	}

}
