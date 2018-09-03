using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class StashConsSlots : MonoBehaviour {



	public Text itemSlot;
	public int Selector;
	public Button buttSlot; 

	void slotName(){
		if (WorldControl.stashCons [Selector, 0] != 0) {
			buttSlot.interactable = true; 
			itemSlot.text = ItemData.itemDataList [WorldControl.stashCons [Selector, 0]].itemName + " Qty: " + WorldControl.stashCons [Selector, 1].ToString()   ; 
		} else {
			buttSlot.interactable = false; 
			itemSlot.text = "Empty";
		}


	}



	void Start () {
		slotName ();
	}
	
	// Update is called once per frame
	void Update () {
		slotName ();
	}
}
