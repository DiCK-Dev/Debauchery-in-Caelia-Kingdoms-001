using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 


public class LeftPanelQuestCreateGo : MonoBehaviour {


	public GameObject itemPrefab; 

	sceneSelectorMainQuest sceneSelector = new sceneSelectorMainQuest();

	public void initFun(){
		//int sceneNum = sceneSelector.retScene (); 
		int sceneNum = QuestsController.ActiveQuests[QuestsController.questIndex].scene;

		GameObject selectButt = Instantiate (itemPrefab) as GameObject;
		selectButt.name = gameObject.name + " SelectButt";
		selectButt.transform.parent = gameObject.transform;

		Button buttonCtrl = selectButt.GetComponent<Button> ();
		buttonCtrl.onClick.AddListener (() => myButtonDelegate ( sceneNum ));

		QuestsController.questIndex++; 



	}

	void Start ()
	{



	}

	public void myButtonDelegate(int sceneNum){
		SceneManager.LoadScene (sceneNum);

	

	}




}
