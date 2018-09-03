using UnityEngine;
using System.Collections;

public class DeactPanelName : MonoBehaviour {
	public GameObject myPaneldeact1;



	public void changePanel (){


		if (GameControl.playerName != "") {

			myPaneldeact1.gameObject.SetActive (false);
		}



	}




}
