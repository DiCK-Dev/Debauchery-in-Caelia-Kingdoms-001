using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class LeftPanelInventoryItemUse : MonoBehaviour {

	public Text useItemText; 
	UseItem useItem = new UseItem();
	public static int itemSelect;

	/// <summary>
	/// Thorwing items is in the panLeftConfirmation
	/// </summary>

	public void itemSelectSlot(int selector){
		itemSelect = selector;
	}


	public void itemUse(){

		if (GameControl.invSlotArray [itemSelect, 1] > 0) {
			useItem.invItemUse (itemSelect);
			useItemText.text = WorldControl.itemUseText;
		} else {
			useItemText.text = "You have no more items left! ";
		}


	}





}
