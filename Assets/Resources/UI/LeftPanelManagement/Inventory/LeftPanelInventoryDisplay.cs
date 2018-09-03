using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LeftPanelInventoryDisplay : MonoBehaviour {

	public Text itemName;
	public Text itemDescription;
	public Text itemQuantity;

	static int selectorUpdater;

	public void uploadQty(){
		string quantity = GameControl.invSlotArray [selectorUpdater, 1].ToString ();
		itemQuantity.text = "Qty: " + quantity;


	}

	public void loadItemSummary(int selector){
		selectorUpdater = selector;
		string quantity = GameControl.invSlotArray [selector, 1].ToString ();
		string cost = ItemData.itemDataList [GameControl.invSlotArray [selector, 0]].itemCost.ToString ();

		itemName.text = ItemData.itemDataList [GameControl.invSlotArray [selector, 0]].itemName; 
		itemDescription.text = ItemData.itemDataList [GameControl.invSlotArray [selector, 0]].itemDescription;
		itemDescription.text += "\n\nValue: " + cost;
		itemQuantity.text = "Qty: " + quantity;

	}





}
