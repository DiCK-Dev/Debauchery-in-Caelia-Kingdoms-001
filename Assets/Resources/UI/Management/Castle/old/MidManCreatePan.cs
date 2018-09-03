using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MidManCreatePan : MonoBehaviour {
	public static bool listchanged;

	public GameObject itemPrefab; 
	public static int retainerIndex = 0; 
	public GameObject[] goList;

	void mainManagement(){
		Debug.Log ("Enter main management");
		foreach (NPCData npc in NPCCharList.CharRetainers) {
			GameObject selectButt = Instantiate (itemPrefab) as GameObject;
			selectButt.name = "NPC"+ retainerIndex.ToString();
			Debug.Log ("Main management for each number " + retainerIndex.ToString());
			selectButt.tag = "NPC";
			selectButt.transform.parent = gameObject.transform;
			int retID = NPCCharList.CharRetainers [retainerIndex].charID; 
			Button buttonCtrl = selectButt.GetComponent<Button> ();
			buttonCtrl.onClick.AddListener (() => buttonSelect ( retID));

			selectButt.GetComponent<MidManCreateData> ().initFunName();
			selectButt.GetComponent<MidManCreateData> ().initFunJob();
			selectButt.GetComponent<MidManCreateData> ().initFunClass();


			//retainerIndex++;

		}
		retainerIndex = 0;

		/*
		int i = 0;
		while (i < NPCCharList.CharRetainers.Count) {
			GameObject selectButt = Instantiate (itemPrefab) as GameObject;
			i++;
		}
		*/



	}


	public void buttonSelect(int charID)
	{
		WorldControl.NPCID = charID;
		Debug.Log ("WorldControl NPCID is "+ WorldControl.NPCID.ToString());
	}


	void Start () {
		listchanged = false; 
		mainManagement ();


		goList = GameObject.FindGameObjectsWithTag ("NPC");


	}

	void Update(){
		if (listchanged == true) {
			foreach (GameObject go in goList) {
				Destroy (go);

			}
			mainManagement ();
			goList = GameObject.FindGameObjectsWithTag ("NPC");
			listchanged = false; 
		}



	}

}
