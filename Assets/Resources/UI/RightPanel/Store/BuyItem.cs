using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BuyItem : MonoBehaviour {
	int i; 
	int x; 

	AddItemScript addItem = new AddItemScript();
	public Text Board; 

	public void buyItem(){
		if (WorldControl.dropItem < 10000 && WorldControl.dropItem != 0) {
			WorldControl.stashFull = true; 
			i = 0; 
			x = 0; 

			while (i < 10) {
				if (GameControl.invSlotArray [i, 0] == WorldControl.dropItem) {
					if (GameControl.invSlotArray [i, 1] < 5) {
						WorldControl.stashFull = false; 
						break; 
					}
				}
				 
				i++;
				if (WorldControl.stashFull == false) {
					break; 
				}
			}

			/*
			 while (i < 10) {
				while (x < 5) {

					if (GameControl.invSlotArray [x, 0] == WorldControl.dropItem) {
						if (GameControl.invSlotArray [x, 1] < 5) {
							WorldControl.stashFull = false; 
							break; 
						}
					}

					x++; 

				}
				x = 0; 
				i++;
				if (WorldControl.stashFull == false) {
					break; 
				}
			}
			*/

			i = 0; 

			if (WorldControl.stashFull == true) {
				while (i < 10) {
					if (GameControl.invSlotArray [i, 0] == 0) {
						WorldControl.stashFull = false; 
						break; 
					}

					i++;
				}

			}

			int cost = ItemData.itemDataList [WorldControl.dropItem].itemCost * 2; 
			if (WorldControl.stashFull == false && GameControl.charGold >= cost) {
				
				addItem.addItemScript ();
				GameControl.charGold = GameControl.charGold - cost; 
				Board.text = "Purchase successful!"; 

			} else if (WorldControl.stashFull == true) {
				Board.text = "Your inventory is full!"; 
			} else if (GameControl.charGold < cost) {
				Board.text = "Your dont have enough gold!"; 
			} 
		} else if (WorldControl.dropItem != 0) {

			WorldControl.stashFull = true; 
			i = 0; 

			while (i < 10) {
				if (GameControl.invSlotArray [i, 0] == 0) {
					WorldControl.stashFull = false; 
					break; 
				}

				i++;
			}



			int cost = ItemData.itemDataList [WorldControl.dropItem].itemCost * 2; 
			if (WorldControl.stashFull == false && GameControl.charGold >= cost) {
				
				addItem.addItemScript ();
				GameControl.charGold = GameControl.charGold - cost; 
				Board.text = "Purchase successful!"; 

			} else if (WorldControl.stashFull == true) {
				Board.text = "Your inventory is full!"; 
			} else if (GameControl.charGold < cost) {
				Board.text = "Your dont have enough gold!"; 
			}


		} else {
			Board.text = "Select an item to buy!";
		}


	}




	/*
	void buyItem (int itemID){


		WorldControl.stashFull = true; 
		i = 0; 

		while (i < 5) 
		{
			if (GameControl.invSlotArray [i, 0] == 0) {
				WorldControl.stashFull = false; 
				break; 
			}

			i++;
		}




		if (WorldControl.stashFull == false && GameControl.charGold >= 250) {
			WorldControl.dropItem = 10004; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 250; 
			Board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			Board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 250) {
			Board.text = "Your dont have enough gold!"; 
		}



	}*/


	void Awake(){
		WorldControl.dropItem = 0; 

	}


}
