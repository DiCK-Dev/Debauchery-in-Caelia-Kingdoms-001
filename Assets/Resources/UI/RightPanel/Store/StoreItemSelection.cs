using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StoreItemSelection : MonoBehaviour {

	int i; 
	public Text Board; 
	public Text itemName; 
	public int itemID;

	public void selectItem(){
		WorldControl.dropItem = itemID;
		int cost = ItemData.itemDataList [itemID].itemCost * 2; 
		Board.text = ItemData.itemDataList[itemID].itemDescription;
		Board.text += "\n\nItem cost: " + cost.ToString() + " G.";
	}

	public void ItemName(){
		itemName.text = ItemData.itemDataList [itemID].itemName;

	}

	void Start(){
		ItemName ();
	}



}
