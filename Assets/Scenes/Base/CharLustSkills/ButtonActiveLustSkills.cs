using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonActiveLustSkills : MonoBehaviour {

	public Button butt110; 
	public Button butt120; 
	public Button butt130; 

	public Button butt210; 
	public Button butt220; 
	public Button butt230; 

	public Button butt310; 
	public Button butt320; 
	public Button butt330; 

	public Button butt410; 
	public Button butt420; 
	public Button butt430; 

	public Button butt510; 
	public Button butt520; 
	public Button butt530; 

	public Button butt610; 
	public Button butt620; 
	public Button butt630; 



	public void deactButton100skills(){
		if (GameControl.lustSetLevel [0] == 3) {
			butt110.GetComponent<Button> ().interactable = true; 
			butt120.GetComponent<Button> ().interactable = true; 
			butt130.GetComponent<Button> ().interactable = true; 

		} else if (GameControl.lustSetLevel [0] == 2) {
			butt110.GetComponent<Button> ().interactable = true; 
			butt120.GetComponent<Button> ().interactable = true;
			butt130.GetComponent<Button> ().interactable = false; 

		} else if (GameControl.lustSetLevel [0] == 1) {
			butt110.GetComponent<Button> ().interactable = true; 
			butt120.GetComponent<Button> ().interactable = false; 
			butt130.GetComponent<Button> ().interactable = false; 
		} else {
			butt110.GetComponent<Button> ().interactable = false; 
			butt120.GetComponent<Button> ().interactable = false; 
			butt130.GetComponent<Button> ().interactable = false; 

		}
	}

	public void deactButton200skills(){
		if (GameControl.lustSetLevel [1] == 3) {
			butt210.GetComponent<Button> ().interactable = true; 
			butt220.GetComponent<Button> ().interactable = true; 
			butt230.GetComponent<Button> ().interactable = true; 

		} else if (GameControl.lustSetLevel [1] == 2) {
			butt210.GetComponent<Button> ().interactable = true; 
			butt220.GetComponent<Button> ().interactable = true;
			butt230.GetComponent<Button> ().interactable = false; 

		} else if (GameControl.lustSetLevel [1] == 1) {
			butt210.GetComponent<Button> ().interactable = true; 
			butt220.GetComponent<Button> ().interactable = false; 
			butt230.GetComponent<Button> ().interactable = false; 
		} else {
			butt210.GetComponent<Button> ().interactable = false; 
			butt220.GetComponent<Button> ().interactable = false; 
			butt230.GetComponent<Button> ().interactable = false; 

		}
	}

	public void deactButton300skills(){
		if (GameControl.lustSetLevel[2] == 3) {
			butt310.GetComponent<Button> ().interactable = true; 
			butt320.GetComponent<Button> ().interactable = true; 
			butt330.GetComponent<Button> ().interactable = true; 

		} else if (GameControl.lustSetLevel [2] == 2) {
			butt310.GetComponent<Button> ().interactable = true; 
			butt320.GetComponent<Button> ().interactable = true;
			butt330.GetComponent<Button> ().interactable = false; 

		} else if (GameControl.lustSetLevel [2] == 1) {
			butt310.GetComponent<Button> ().interactable = true; 
			butt320.GetComponent<Button> ().interactable = false; 
			butt330.GetComponent<Button> ().interactable = false; 
		} else {
			butt310.GetComponent<Button> ().interactable = false; 
			butt320.GetComponent<Button> ().interactable = false; 
			butt330.GetComponent<Button> ().interactable = false; 

		}
	}

	public void deactButton400skills(){
		if (GameControl.lustSetLevel [3] == 3) {
			butt410.GetComponent<Button> ().interactable = true; 
			butt420.GetComponent<Button> ().interactable = true; 
			butt430.GetComponent<Button> ().interactable = true; 

		} else if (GameControl.lustSetLevel [3] == 2) {
			butt410.GetComponent<Button> ().interactable = true; 
			butt420.GetComponent<Button> ().interactable = true;
			butt430.GetComponent<Button> ().interactable = false; 

		} else if (GameControl.lustSetLevel [3] == 1) {
			butt410.GetComponent<Button> ().interactable = true; 
			butt420.GetComponent<Button> ().interactable = false; 
			butt430.GetComponent<Button> ().interactable = false; 
		} else {
			butt410.GetComponent<Button> ().interactable = false; 
			butt420.GetComponent<Button> ().interactable = false; 
			butt430.GetComponent<Button> ().interactable = false; 

		}
	}

	public void deactButton500skills(){
		if (GameControl.lustSetLevel [4] == 3) {
			butt510.GetComponent<Button> ().interactable = true; 
			butt520.GetComponent<Button> ().interactable = true; 
			butt530.GetComponent<Button> ().interactable = true; 

		} else if (GameControl.lustSetLevel [4] == 2) {
			butt510.GetComponent<Button> ().interactable = true; 
			butt520.GetComponent<Button> ().interactable = true;
			butt530.GetComponent<Button> ().interactable = false; 

		} else if (GameControl.lustSetLevel [4] == 1) {
			butt510.GetComponent<Button> ().interactable = true; 
			butt520.GetComponent<Button> ().interactable = false; 
			butt530.GetComponent<Button> ().interactable = false; 
		} else {
			butt510.GetComponent<Button> ().interactable = false; 
			butt520.GetComponent<Button> ().interactable = false; 
			butt530.GetComponent<Button> ().interactable = false; 

		}
	}

	public void deactButton600skills(){
		if (GameControl.lustSetLevel [5] == 3) {
			butt610.GetComponent<Button> ().interactable = true; 
			butt620.GetComponent<Button> ().interactable = true; 
			butt630.GetComponent<Button> ().interactable = true; 

		} else if (GameControl.lustSetLevel [5] == 2) {
			butt610.GetComponent<Button> ().interactable = true; 
			butt620.GetComponent<Button> ().interactable = true;
			butt630.GetComponent<Button> ().interactable = false; 

		} else if (GameControl.lustSetLevel [5] == 1) {
			butt610.GetComponent<Button> ().interactable = true; 
			butt620.GetComponent<Button> ().interactable = false; 
			butt630.GetComponent<Button> ().interactable = false; 
		} else {
			butt610.GetComponent<Button> ().interactable = false; 
			butt620.GetComponent<Button> ().interactable = false; 
			butt630.GetComponent<Button> ().interactable = false; 

		}
	}








	// Use this for initialization
	void Start () {
		deactButton100skills ();
		deactButton200skills ();
		deactButton300skills ();
		deactButton400skills ();
		deactButton500skills ();
		deactButton600skills ();

	}
	// Update is called once per frame
	void Update () {
	
	}
}
