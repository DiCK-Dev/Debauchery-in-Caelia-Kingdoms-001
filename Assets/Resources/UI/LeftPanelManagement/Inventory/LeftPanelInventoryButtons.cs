using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LeftPanelInventoryButtons : MonoBehaviour {

	public Button item0Butt; 
	public Button item1Butt; 
	public Button item2Butt; 
	public Button item3Butt; 
	public Button item4Butt; 
	public Button item5Butt; 
	public Button item6Butt; 
	public Button item7Butt; 
	public Button item8Butt; 
	public Button item9Butt; 


	public void itemButtonsActivate()
	{
		item0Butt.interactable = true;
		item1Butt.interactable = true;
		item2Butt.interactable = true;
		item3Butt.interactable = true;
		item4Butt.interactable = true;
		item5Butt.interactable = true;
		item6Butt.interactable = true;
		item7Butt.interactable = true;
		item8Butt.interactable = true;
		item9Butt.interactable = true;


		if (GameControl.invSlotArray [0, 0] == 0) {
			item0Butt.interactable = false;

		}

		if (GameControl.invSlotArray [1, 0] == 0) {
			item1Butt.interactable = false; 
		}

		if (GameControl.invSlotArray [2, 0] == 0) {
			item2Butt.interactable = false;
		}

		if (GameControl.invSlotArray [3, 0] == 0) {
			item3Butt.interactable = false;
		}

		if (GameControl.invSlotArray [4, 0] == 0) {
			item4Butt.interactable = false; 
		}

		if (GameControl.invSlotArray [5, 0] == 0) {
			item5Butt.interactable = false; 
		}

		if (GameControl.invSlotArray [6, 0] == 0) {
			item6Butt.interactable = false;
		}

		if (GameControl.invSlotArray [7, 0] == 0) {
			item7Butt.interactable = false; 
		}

		if (GameControl.invSlotArray [8, 0] == 0) {
			item8Butt.interactable = false; 
		}

		if (GameControl.invSlotArray [9, 0] == 0) {
			item9Butt.interactable = false; 
		}



	}


	void Start(){

		itemButtonsActivate ();

	}




}
