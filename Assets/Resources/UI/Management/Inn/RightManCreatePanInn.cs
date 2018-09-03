using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RightManCreatePanInn : MonoBehaviour {

	public static bool listchanged;

	public GameObject itemPrefab; 
	public static int retainerIndex = 0; 
	public GameObject[] goList;

	public static int manSelector; 

	void mainManagement(){

		foreach (NPCData npc in NPCCharList.CharRetainers) {
			if (NPCCharList.CharRetainers[retainerIndex].isNeutral) {
				GameObject selectButt = Instantiate (itemPrefab) as GameObject;
				selectButt.name = "NPC" + retainerIndex.ToString ();
				selectButt.tag = "NPC";
				selectButt.transform.parent = gameObject.transform;
				int retID = NPCCharList.CharRetainers [retainerIndex].charID;
				int idx = retainerIndex;
				Button buttonCtrl = selectButt.GetComponent<Button> ();
				buttonCtrl.onClick.AddListener (() => buttonSelect (retID, idx));


				selectButt.GetComponent<RightManCreateDataInn> ().initFunName ();
				selectButt.GetComponent<RightManCreateDataInn> ().initFunImage1 ();
				selectButt.GetComponent<RightManCreateDataInn> ().initFunImage2 ();
				selectButt.GetComponent<RightManCreateDataInn> ().initFunImage3 ();
				retainerIndex++;

			} else {
				retainerIndex++;
			}

		} 

		retainerIndex = 0;

	}



	public void buttonSelect(int charID, int idx)
	{
		WorldControl.NPCID = charID;
		WorldControl.idx = idx;
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
