using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TradingPost : MonoBehaviour {
	
	public Text textbutton1; 
	public Text textbutton2; 
	public Text textbutton3; 
	public Text textbutton4; 
	public Text textbutton5; 

	public static int slotSell;

	public Button button1; 
	public Button button2; 
	public Button button3; 
	public Button button4; 
	public Button button5;
	public Button buttonSellAll; 

	public Text Board; 

	int i; 
	int x; 


	public void slot1(){
		if (GameControl.invSlotArray [0, 0] > 0) {
			textbutton1.text = ItemData.itemDataList [GameControl.invSlotArray [0, 0]].itemName + " x" + GameControl.invSlotArray[0,1]; 
			button1.GetComponent<Button> ().interactable = true; 
		} else {
			textbutton1.text = "empty"; 
			button1.GetComponent<Button> ().interactable = false; 
		}
	}
	public void slot2(){
		if (GameControl.invSlotArray [1, 0] > 0) {
			textbutton2.text = ItemData.itemDataList [GameControl.invSlotArray [1, 0]].itemName + " x" + GameControl.invSlotArray[1,1]; 
			button2.GetComponent<Button> ().interactable = true; 
		} else {
			textbutton2.text = "empty"; 
			button2.GetComponent<Button> ().interactable = false; 
		}
	}
	public void slot3(){
		if (GameControl.invSlotArray [2, 0] > 0) {
			textbutton3.text = ItemData.itemDataList [GameControl.invSlotArray [2, 0]].itemName + " x" + GameControl.invSlotArray[2,1]; 
			button3.GetComponent<Button> ().interactable = true; 
		} else {
			textbutton3.text = "empty"; 
			button3.GetComponent<Button> ().interactable = false; 
		}
	}
	public void slot4(){
		if (GameControl.invSlotArray [3, 0] > 0) {
			textbutton4.text = ItemData.itemDataList [GameControl.invSlotArray [3, 0]].itemName + " x" + GameControl.invSlotArray[3,1]; 
			button4.GetComponent<Button> ().interactable = true; 
		} else {
			textbutton4.text = "empty"; 
			button4.GetComponent<Button> ().interactable = false; 
		}
	}
	public void slot5(){
		if (GameControl.invSlotArray [4, 0] > 0) {
			textbutton5.text = ItemData.itemDataList [GameControl.invSlotArray [4, 0]].itemName + " x" + GameControl.invSlotArray[4,1]; 
			button5.GetComponent<Button> ().interactable = true; 
		} else {
			textbutton5.text = "empty"; 
			button5.GetComponent<Button> ().interactable = false; 
		}
	}



	public void sell1(){
		slotSell = 1; 
	}
	public void sell2(){
		slotSell = 2; 
	}
	public void sell3(){
		slotSell = 3; 
	}
	public void sell4(){
		slotSell = 4; 
	}
	public void sell5(){
		slotSell = 5; 
	}




	public void sellItem(){
		switch (slotSell) {
		case 1:
			if (GameControl.invSlotArray[0,0] > 0) {
				WorldControl.dropItem = GameControl.invSlotArray [0, 0];
				GameControl.charGold = GameControl.charGold + ItemData.itemDataList [GameControl.invSlotArray [0, 0]].itemCost; 
				GameControl.invSlotArray [0, 1] = GameControl.invSlotArray [0, 1] - 1; 
				if (GameControl.invSlotArray [0, 1] <= 0) {
					GameControl.invSlotArray [0, 0] = 0; 
				}
				Board.text = "You sold the item for " + ItemData.itemDataList[WorldControl.dropItem].itemCost + " gold!"; 
			}
			break;
		case 2:
			if (GameControl.invSlotArray [1, 0] > 0) {
				WorldControl.dropItem = GameControl.invSlotArray [1, 0];
				GameControl.charGold = GameControl.charGold + ItemData.itemDataList [GameControl.invSlotArray [1, 0]].itemCost; 
				GameControl.invSlotArray [1, 1] = GameControl.invSlotArray [1, 1] - 1; 
				if (GameControl.invSlotArray [1, 1] <= 0) {
					GameControl.invSlotArray [1, 0] = 0; 
				}
				Board.text = "You sold the item for " + ItemData.itemDataList[WorldControl.dropItem].itemCost + " gold!"; 
			}
			break; 
		case 3: 
			if (GameControl.invSlotArray [2, 0] > 0) {
				WorldControl.dropItem = GameControl.invSlotArray [2, 0];
				GameControl.charGold = GameControl.charGold + ItemData.itemDataList [GameControl.invSlotArray [2, 0]].itemCost; 
				GameControl.invSlotArray [2, 1] = GameControl.invSlotArray [2, 1] - 1; 
				if (GameControl.invSlotArray [2, 1] <= 0) {
					GameControl.invSlotArray [2, 0] = 0; 
				}
				Board.text = "You sold the item for " + ItemData.itemDataList[WorldControl.dropItem].itemCost + " gold!"; 
			}
			break;
		case 4:
			if (GameControl.invSlotArray [3, 0] > 0) {
				WorldControl.dropItem = GameControl.invSlotArray [3, 0];
				GameControl.charGold = GameControl.charGold + ItemData.itemDataList [GameControl.invSlotArray [3, 0]].itemCost; 
				GameControl.invSlotArray [3, 1] = GameControl.invSlotArray [3, 1] - 1; 
				if (GameControl.invSlotArray [3, 1] <= 0) {
					GameControl.invSlotArray [3, 0] = 0; 
				}
				Board.text = "You sold the item for " + ItemData.itemDataList[WorldControl.dropItem].itemCost + " gold!"; 
			}
			break;
		case 5:
			if (GameControl.invSlotArray [4, 0] > 0) {
				WorldControl.dropItem = GameControl.invSlotArray [4, 0];
				GameControl.charGold = GameControl.charGold + ItemData.itemDataList [GameControl.invSlotArray [4, 0]].itemCost; 
				GameControl.invSlotArray [4, 1] = GameControl.invSlotArray [4, 1] - 1; 
				if (GameControl.invSlotArray [4, 1] <= 0) {
					GameControl.invSlotArray [4, 0] = 0; 
				}
				Board.text = "You sold the item for " + ItemData.itemDataList[WorldControl.dropItem].itemCost + " gold!"; 
			}
			break; 

		}

	}




	public void sellAll()
	{
		if (GameControl.invSlotArray [0, 0] > 0 || GameControl.invSlotArray [1, 0] > 0 || GameControl.invSlotArray [2, 0] > 0 || GameControl.invSlotArray [3, 0] > 0 || GameControl.invSlotArray [4, 0] > 0)
		{
			i = 0; 
			while (i < 5) 
			{
				x = 0; 
				while (x < 5)
				{ 
					if (GameControl.invSlotArray [i, 0] == 0)
					{
						break; 
					}
					slotSell = i+1; 
					sellItem ();
					x++;

				}
				i++;
			}
			Board.text = "You sold everything!"; 
		} 
		else 
		{
			Board.text = "You have no items to sell!"; 
		}

	}




	void Start () {
	
	}
	

	void Update () {
		slot1 ();
		slot2 ();
		slot3 ();
		slot4 ();
		slot5 ();
	}
}
