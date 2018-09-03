using UnityEngine;
using System.Collections;

public class DeactPanel3 : MonoBehaviour {

	public GameObject myPaneldeact1;
	public GameObject myPaneldeact2;
	public GameObject myPaneldeact3;

	public void changePanel3 (){




		myPaneldeact1.gameObject.SetActive (false);
		myPaneldeact2.gameObject.SetActive (false);
		myPaneldeact3.gameObject.SetActive (false);
	}

}
