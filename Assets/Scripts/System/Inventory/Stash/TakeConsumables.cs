using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class TakeConsumables : MonoBehaviour {



	public Button buttSlot1; 
	public Button buttSlot2; 
	public Button buttSlot3; 
	public Button buttSlot4; 
	public Button buttSlot5; 
	public Button buttSlot6; 
	public Button buttSlot7; 
	public Button buttSlot8; 
	public Button buttSlot9; 
	public Button buttSlot10; 

	public Text Board; 

	bool itemAdded = false; 

	int i;
	int x; 

	AddItemScript addItem = new AddItemScript();







	//checker 

	public void checkCharInv(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		while(i < 10)
		{
			while (x < 10) 
			{
				
				if (WorldControl.stashCons [i, 0] == GameControl.invSlotArray[x,0]) 
				{
					if (GameControl.invSlotArray [x, 1] < 5) {
						WorldControl.stashFull = false; //it actuallt checks if your inv is full...
						break; 
					} else {
						//WorldControl.stashFull = false; 
					}
				}
				if (WorldControl.stashFull == false) {
					break; 
				}


				x++; 
			
			}
			x = 0; 
			i++;
			if (WorldControl.stashFull == false) {
				break; 
			}
		}

		if (WorldControl.invFull == true) {
			i = 0; 
			while (i < 10) {
				if (GameControl.invSlotArray [i, 0] == 0) {
					WorldControl.stashFull = false; 
					break; 
				}

				i++;
			}

		}
		closeForFull ();
	}




	void closeForFull () {
		if (WorldControl.stashFull == true) {


			Board.text = "Your inventory is full and you cant add anything else!"; 
			buttSlot1.interactable = false; 
			buttSlot2.interactable = false; 
			buttSlot3.interactable = false; 
			buttSlot4.interactable = false; 
			buttSlot5.interactable = false; 
			buttSlot6.interactable = false; 
			buttSlot7.interactable = false; 
			buttSlot8.interactable = false; 
			buttSlot9.interactable = false; 
			buttSlot10.interactable = false; 

		}


	}

	// add item to stack
	/*
	public void addItemInv () {
		i = 0;
		itemAdded = false; 

		while (i < 10) {
			if (GameControl.invSlotArray [i, 0] == WorldControl.dropItem) 
			{
				if (GameControl.invSlotArray [i, 1] < 5) 
				{
					GameControl.invSlotArray [i, 1] = GameControl.invSlotArray [i, 1] + 1; 
					itemAdded = true;
					break; 
				}
			}
				
			i++; 
		}

		i = 0; 
		if (itemAdded == false)
		{
			while (i < 10)
			{
				if (GameControl.invSlotArray [i, 0] == 0) {
					GameControl.invSlotArray[i,0] = WorldControl.dropItem;
					GameControl.invSlotArray [i, 1] = 1;
					break; 
				}
				i++;
			}
		}


	}
	*/

	// on case button add 

	public void takeItemSlot(int selector){
		checkCharInv ();
		if (WorldControl.invFull == false) {
			if (WorldControl.stashCons [selector, 0] != 0) {
				WorldControl.dropItem = WorldControl.stashCons [selector, 0];

				addItem.addItemScript (); 
				WorldControl.stashCons [selector, 1] -= 1;
				if (WorldControl.stashCons [selector, 1] <= 0) {
					WorldControl.stashCons [selector, 0] = 0; 
					WorldControl.stashCons [selector, 1] = 0;
				}

			}
		}

	}

	public void itemSlot1(){

		WorldControl.dropItem = WorldControl.stashCons [0, 0];

		addItem.addItemScript (); 
		WorldControl.stashCons [0, 1] = WorldControl.stashCons [0, 1] - 1;
		if (WorldControl.stashCons [0, 1] <= 0) {
			WorldControl.stashCons [0, 0] = 0; 
		}



	}
	public void itemSlot2(){

		WorldControl.dropItem = WorldControl.stashCons [1, 0];

		addItem.addItemScript (); 
		WorldControl.stashCons [1, 1] = WorldControl.stashCons [1, 1] - 1;
		if (WorldControl.stashCons [1, 1] <= 0) {
			WorldControl.stashCons [1, 0] = 0; 
		}

	}

	public void itemSlot3(){

		WorldControl.dropItem = WorldControl.stashCons [2, 0];

		addItem.addItemScript (); 
		WorldControl.stashCons [2, 1] = WorldControl.stashCons [2, 1] - 1;
		if (WorldControl.stashCons [2, 1] <= 0) {
			WorldControl.stashCons [2, 0] = 0; 
		}
	}
	public void itemSlot4(){

		WorldControl.dropItem = WorldControl.stashCons [3, 0];

		addItem.addItemScript (); 
		WorldControl.stashCons [3, 1] = WorldControl.stashCons [3, 1] - 1;
		if (WorldControl.stashCons [3, 1] <= 0) {
			WorldControl.stashCons [3, 0] = 0; 
		}
	}
	public void itemSlot5(){

		WorldControl.dropItem = WorldControl.stashCons [4, 0];

		addItem.addItemScript (); 
		WorldControl.stashCons [4, 1] = WorldControl.stashCons [4, 1] - 1;
		if (WorldControl.stashCons [4, 1] <= 0) {
			WorldControl.stashCons [4, 0] = 0; 
		}
	}





}
