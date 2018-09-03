using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InvSlots : MonoBehaviour {



	public Text Slot1;
	public Text Slot2;
	public Text Slot3;
	public Text Slot4;
	public Text Slot5;


	void slotName(){
		if (GameControl.invSlotArray [0, 0] > 0) {
			Slot1.text = ItemData.itemDataList [GameControl.invSlotArray [0, 0]].itemName + " x" + GameControl.invSlotArray [0, 1]; 
		} else {
			Slot1.text = "Empty";
		}

		if (GameControl.invSlotArray [1, 0] > 0) {
			Slot2.text = ItemData.itemDataList [GameControl.invSlotArray [1, 0]].itemName + " x" + GameControl.invSlotArray[1,1] ; 
		}else {
			Slot2.text = "Empty";
		}

		if (GameControl.invSlotArray [2, 0] > 0) {
			Slot3.text = ItemData.itemDataList [GameControl.invSlotArray [2, 0]].itemName + " x" + GameControl.invSlotArray[2,1] ; 
		}else {
			Slot3.text = "Empty";
		}

		if (GameControl.invSlotArray [3, 0] > 0) {
			Slot4.text = ItemData.itemDataList [GameControl.invSlotArray [3, 0]].itemName + " x" + GameControl.invSlotArray[3,1] ; 
		}else {
			Slot4.text = "Empty";
		}

		if (GameControl.invSlotArray [4, 0] > 0) {
			Slot5.text = ItemData.itemDataList [GameControl.invSlotArray [4, 0]].itemName + " x" + GameControl.invSlotArray[4,1] ; 
		}else {
			Slot5.text = "Empty";
		}


	}




	void Start () {

		//slotName ();
	}

	// Update is called once per frame
	void Update () {
		slotName ();

	}
}
