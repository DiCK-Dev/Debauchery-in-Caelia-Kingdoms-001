using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PanQuestVivicaSelect : MonoBehaviour {

	public GameObject itemPrefab; 
	descriptionVivicaQuest descrVivicaQuest = new descriptionVivicaQuest();

	void Start ()
	{

		startButton ();



	}

	/*public void myButtonDelegate(int myValue){
		//SceneManager.LoadScene (myValue);
		Debug.Log (myValue);

	}*/

	public void startButton(){
		string descr = descrVivicaQuest.retDescription(); 

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
