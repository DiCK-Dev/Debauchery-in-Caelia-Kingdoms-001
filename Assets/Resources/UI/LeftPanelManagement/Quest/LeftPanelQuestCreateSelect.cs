using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class LeftPanelQuestCreateSelect : MonoBehaviour {

	public GameObject itemPrefab; 
	descriptionMainQuest descrMainQuest = new descriptionMainQuest();

	void Start ()
	{





	}

	/*public void myButtonDelegate(int myValue){
		//SceneManager.LoadScene (myValue);
		Debug.Log (myValue);

	}*/

	public void initFun(){
		//string descr = descrMainQuest.retDescription(); 
		string descr = QuestsController.ActiveQuests[QuestsController.questIndex].description;

		GameObject selectButt = Instantiate (itemPrefab) as GameObject;
		selectButt.name = gameObject.name + " SelectButt";
		selectButt.transform.parent = gameObject.transform;

		Button buttonCtrl = selectButt.GetComponent<Button> ();
		buttonCtrl.onClick.AddListener (() => buttonSelect ( descr ));

	}




	public void buttonSelect(string description){
		LeftPanelQuestBoard.description = description; 

	}









}
