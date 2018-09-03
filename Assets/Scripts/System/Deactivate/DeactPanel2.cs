using UnityEngine;
using System.Collections;

public class DeactPanel2 : MonoBehaviour {

	public GameObject myPaneldeact1;
	public GameObject myPaneldeact2;


	public void changePane2 (){




		myPaneldeact1.gameObject.SetActive (false);

		myPaneldeact2.gameObject.SetActive (false);

	}

}
