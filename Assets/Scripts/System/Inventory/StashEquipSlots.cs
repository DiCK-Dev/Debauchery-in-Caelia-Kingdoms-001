using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StashEquipSlots : MonoBehaviour {



	public Text itemSlot;
	public int Selector;
	public Button buttSlot; 




	void slotName(){

		if (WorldControl.stashEquip [Selector, 0] != 0) {
			itemSlot.text =  ItemData.itemDataList [WorldControl.stashEquip [Selector, 0]].itemName + " Qty: " + WorldControl.stashEquip [Selector, 1].ToString(); 
			buttSlot.interactable = true;
		} else {
			itemSlot.text = "Empty";
			buttSlot.interactable = false;
		}



	}





	void Start () {
		slotName ();
	}


	void Update () {
		slotName ();
	}
}
