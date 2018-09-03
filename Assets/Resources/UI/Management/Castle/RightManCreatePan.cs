using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RightManCreatePan : MonoBehaviour {

	public static bool listchanged;

	public GameObject itemPrefab; 
	public static int retainerIndex = 0; 
	public GameObject[] goList;

	void mainManagement(){

		foreach (NPCData npc in NPCCharList.CharRetainers) {
			if (checkJob (npc.cityJobs)) {
				GameObject selectButt = Instantiate (itemPrefab) as GameObject;
				selectButt.name = "NPC" + retainerIndex.ToString ();
				selectButt.tag = "NPC";
				selectButt.transform.parent = gameObject.transform;
				int retID = NPCCharList.CharRetainers [retainerIndex].charID;
				int idx = retainerIndex;
				Button buttonCtrl = selectButt.GetComponent<Button> ();
				buttonCtrl.onClick.AddListener (() => buttonSelect (retID, idx));


				selectButt.GetComponent<RightManCreateData> ().initFunName ();
				selectButt.GetComponent<RightManCreateData> ().initFunImage1 ();
				selectButt.GetComponent<RightManCreateData> ().initFunImage2 ();
				selectButt.GetComponent<RightManCreateData> ().initFunImage3 ();
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

	bool checkJob(NPCData.Jobs job){
		switch (job) {
		case NPCData.Jobs.CastleRest: return true; 
		case NPCData.Jobs.CastleDomestic: return true; 
		case NPCData.Jobs.CastleCook: return true; 
		case NPCData.Jobs.CastleHealer: return true; 
		case NPCData.Jobs.CastleEntertainer: return true; 
		case NPCData.Jobs.CastleHunter: return true; 
		case NPCData.Jobs.CastleArtisan: return true; 
		case NPCData.Jobs.CastleFarmhand: return true; 
		case NPCData.Jobs.CastleScribe: return true; 
		case NPCData.Jobs.CastleProstitute: return true; 
		case NPCData.Jobs.CastleAccountant: return true; 
		case NPCData.Jobs.CastleSlaveMaster: return true; 
		case NPCData.Jobs.CastleGuard: return true; 
		case NPCData.Jobs.CastleCaptain: return true; 
		case NPCData.Jobs.CastleCourtier: return true; 
		case NPCData.Jobs.CastleCounselor: return true; 
		default: return false;
		}

	}

}
