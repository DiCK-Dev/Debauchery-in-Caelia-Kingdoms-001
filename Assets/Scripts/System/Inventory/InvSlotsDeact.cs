using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InvSlotsDeact : MonoBehaviour {



	public Button ButtSlot1;
	public Button ButtSlot2;
	public Button ButtSlot3;
	public Button ButtSlot4;
	public Button ButtSlot5;




	public void deactButton(){
		if (GameControl.invSlotArray[0,0] > 0) {
			ButtSlot1.GetComponent<Button> ().interactable = true; 

		} else {
			ButtSlot1.GetComponent<Button> ().interactable = false; 
		}
		if (GameControl.invSlotArray[1,0] > 0) {
			ButtSlot2.GetComponent<Button> ().interactable = true; 

		} else {
			ButtSlot2.GetComponent<Button> ().interactable = false; 
		}
		if (GameControl.invSlotArray[2,0] > 0) {
			ButtSlot3.GetComponent<Button> ().interactable = true; 

		} else {
			ButtSlot3.GetComponent<Button> ().interactable = false; 
		}
		if (GameControl.invSlotArray[3,0] > 0) {
			ButtSlot4.GetComponent<Button> ().interactable = true; 

		} else {
			ButtSlot4.GetComponent<Button> ().interactable = false; 
		}
		if (GameControl.invSlotArray[4,0] > 0) {
			ButtSlot5.GetComponent<Button> ().interactable = true; 

		} else {
			ButtSlot5.GetComponent<Button> ().interactable = false; 
		}

	}






	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		deactButton ();
	}
}
