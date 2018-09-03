using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class PanQuestVivicaGo : MonoBehaviour {


	public GameObject itemPrefab; 



	void Start ()
	{


		GameObject selectButt = Instantiate (itemPrefab) as GameObject;
		selectButt.name = gameObject.name + " SelectButt";
		selectButt.transform.parent = gameObject.transform;

		Button buttonCtrl = selectButt.GetComponent<Button> ();
		buttonCtrl.onClick.AddListener (() => myButtonDelegate ( 54 ));


	}

	public void myButtonDelegate(int sceneNum){
		SceneManager.LoadScene (sceneNum);



	}


}
