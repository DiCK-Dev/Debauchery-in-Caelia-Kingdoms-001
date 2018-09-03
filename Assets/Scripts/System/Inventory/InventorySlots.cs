using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class InventorySlots : MonoBehaviour {


	//this is to add items to the stash

	public Text itemSlot;
	public int Selector;
	public Button buttSlot; 




	void invSlotName(){

		if (GameControl.invSlotArray [Selector, 0] != 0) {
			itemSlot.text =  ItemData.itemDataList [GameControl.invSlotArray [Selector, 0]].itemName + " Qty: " + GameControl.invSlotArray [Selector, 1].ToString(); 
			buttSlot.interactable = true;
		} else {
			itemSlot.text = "Empty";
			buttSlot.interactable = false;
		}



	}

	void Update(){
		invSlotName ();

	}









}
