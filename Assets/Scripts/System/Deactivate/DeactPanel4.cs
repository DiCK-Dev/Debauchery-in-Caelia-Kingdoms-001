using UnityEngine;
using System.Collections;

public class DeactPanel4 : MonoBehaviour {
	
	public GameObject myPaneldeact1;
	public GameObject myPaneldeact2;
	public GameObject myPaneldeact3;
	public GameObject myPaneldeact4;

	public void changePanel4 (){


		myPaneldeact1.gameObject.SetActive (false);
		myPaneldeact2.gameObject.SetActive (false);
		myPaneldeact3.gameObject.SetActive (false);
		myPaneldeact4.gameObject.SetActive (false);

	}
}
