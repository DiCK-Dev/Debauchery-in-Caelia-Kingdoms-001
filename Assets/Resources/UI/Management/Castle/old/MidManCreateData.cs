using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MidManCreateData : MonoBehaviour {


	public GameObject itemPrefabName; 
	public GameObject itemPrefabJob;
	public GameObject itemPrefabClass; 

	public void initFunName(){

		GameObject NPCName = Instantiate (itemPrefabName) as GameObject;
		NPCName.name = gameObject.name + " NPCName";
		NPCName.transform.parent = gameObject.transform;

		Text NPCname = NPCName.GetComponent<Text> ();
		NPCname.text = NPCCharList.CharRetainers [MidManCreatePan.retainerIndex].charName + " " +  NPCCharList.CharRetainers [MidManCreatePan.retainerIndex].charNickname + " " + NPCCharList.CharRetainers [MidManCreatePan.retainerIndex].charSurname ; 

	}

	public void initFunJob(){

		GameObject NPCJob = Instantiate (itemPrefabJob) as GameObject;
		NPCJob.name = gameObject.name + " NPCJob";
		NPCJob.transform.parent = gameObject.transform;

		Text npcJob = NPCJob.GetComponent<Text> ();
		npcJob.text = NPCCharList.CharRetainers [MidManCreatePan.retainerIndex].cityJobs.toDescription(); 

	}

	public void initFunClass(){

		GameObject NPCClass = Instantiate (itemPrefabClass) as GameObject;
		NPCClass.name = gameObject.name + " NPCName";
		NPCClass.transform.parent = gameObject.transform;

		Text classname = NPCClass.GetComponent<Text> ();
		classname.text = NPCCharList.CharRetainers [MidManCreatePan.retainerIndex].charClass.toDescription(); 
		MidManCreatePan.retainerIndex++;

	}



}
