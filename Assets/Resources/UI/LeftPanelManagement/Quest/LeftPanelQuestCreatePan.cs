using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LeftPanelQuestCreatePan : MonoBehaviour {
	public static int iterator = 0; 
	public GameObject[] Tests;
	public GameObject itemPrefab; 


	void mainQuest(){

		foreach(Quest quest in QuestsController.ActiveQuests){
			GameObject newItem  = Instantiate (itemPrefab) as GameObject;
			//newItem.name = gameObject.name + " PanelQuest" + QuestsController.questIndex.ToString();
			newItem.name = "Testing"+ iterator.ToString();
			iterator++;
			//newItem.tag = QuestsController.questIndex.ToString();
			newItem.tag = "Test";
			newItem.transform.parent = gameObject.transform;

			newItem.GetComponent<LeftPanelQuestCreateSelect> ().initFun ();
			newItem.GetComponent<LeftPanelQuestCreateName> ().initFun ();
			newItem.GetComponent<LeftPanelQuestCreateGo> ().initFun ();

		}
		QuestsController.questIndex = 0; 


	}




	void Start () {
		mainQuest ();
		/*
		GameObject.FindGameObjectWithTag ("Test").GetComponentInChildren<Text>().text = "this is a test of changing a specific component";


		Tests = GameObject.FindGameObjectsWithTag ("Test");

		foreach (GameObject go in Tests) {
			if (GameObject.FindGameObjectWithTag ("Test").name == "Testing0") {
				go.GetComponentInChildren<Text>().text = "Suc0";
			}


			if (GameObject.FindGameObjectWithTag ("Test").name == "Testing1") {
				go.GetComponentInChildren<Text>().text = "Suc1";
			}

		}
		int i = 0;
		while (i < Tests.Length) {
			if (i == 0) {
				Tests [0].GetComponentInChildren<Text> ().text = "suc0";
			}
			if (i == 1) {
				Tests [1].GetComponentInChildren<Text> ().text = "suc1";
			}

			i++;
		}
			

		*/



	}

}
