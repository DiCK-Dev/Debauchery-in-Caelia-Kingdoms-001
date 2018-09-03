using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PutConsumables : MonoBehaviour {


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


	bool itemAdded = false; 

	public Text Board; 

	int i;
	int x; 

	// DEACTIVATING
	public void deactButton1(){
		if (GameControl.invSlotArray[0,0] > 0) {
			buttSlot1.GetComponent<Button> ().interactable = true; 
	
		} else {
			buttSlot1.GetComponent<Button> ().interactable = false; 
	
		}

	}

	public void deactButton2(){
		if (GameControl.invSlotArray[1,0] > 0) {
			buttSlot2.GetComponent<Button> ().interactable = true; 
		
		} else {
			buttSlot2.GetComponent<Button> ().interactable = false; 

		}


	}
	public void deactButton3(){
		if (GameControl.invSlotArray[2,0] > 0) {
			buttSlot3.GetComponent<Button> ().interactable = true; 

		} else {
			buttSlot3.GetComponent<Button> ().interactable = false; 

		}

	}

	public void deactButton4(){
		if (GameControl.invSlotArray[3,0] > 0) {
			buttSlot4.GetComponent<Button> ().interactable = true; 

		} else {
			buttSlot4.GetComponent<Button> ().interactable = false; 

		}

	}

	public void deactButton5(){
		if (GameControl.invSlotArray[4,0] > 0) {
			buttSlot5.GetComponent<Button> ().interactable = true; 

		} else {
			buttSlot5.GetComponent<Button> ().interactable = false; 

		}

	}


	//HOVER

	// Checking if the stash is full

	public void checkStack(){
		i = 0; 
		x = 0; 
		WorldControl.stashFull = true; 
		while (i < 10) {
			if (WorldControl.stashCons [i,0] <= 0) {
				WorldControl.stashFull = false;
				break; 
			}
			else 
			{
				WorldControl.stashFull = true; 
			}

			i++;
		}

		i = 0;
		while (i < 10) 
		{

			while (x < 5) 
			{
				if (WorldControl.stashCons [i,0] == GameControl.invSlotArray [x, 0]) 
				{
					if (WorldControl.stashCons [i, 1] < 5) 
					{
						WorldControl.stashFull = false; 
						break; 
					}

				}

				x++;
			}

			x = 0; 
			i++;

		}
		closeForFull ();
	}

	// closes the buttons if stack is full
	public void closeForFull(){
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

	public void addItemStack(int selector){
		itemAdded = false; 
		i = 0;
		x = 0; 
		while (i < 10) {
			if (WorldControl.stashCons [i,0] == WorldControl.dropItem) {
				if (WorldControl.stashCons [i, 1] < 5) {
					WorldControl.stashCons [i, 1] += 1;
					itemAdded = true;
					Board.text = "You just added " + ItemData.itemDataList [WorldControl.dropItem].itemName + " to the stack!"; 
					break; 
				}

			}
			i++;
		}





		i = 0;

		if (itemAdded == false) 
		{
			while (i < 10) {
				if (WorldControl.stashCons [i, 0] <= 0) {
					WorldControl.stashCons [i, 0] = WorldControl.dropItem; 
					WorldControl.stashCons [i, 1] = 1; 
					itemAdded = true; 
					Board.text = "You just added " + ItemData.itemDataList [WorldControl.dropItem].itemName + " to the stack!"; 
					break; 

				}
				i++;
			}
		}
		if (itemAdded == false) {
			GameControl.invSlotArray [selector, 1] += 1;
			Board.text = "There is no more space for this item!";
		}




	}




	// per button case add items 

	public void addConsumableToStack(int selector){


		if (GameControl.invSlotArray[selector,0] < 10000 && GameControl.invSlotArray[selector,0] != 0 ) {
			WorldControl.dropItem = GameControl.invSlotArray [selector, 0];
			addItemStack (selector);
			GameControl.invSlotArray [selector, 1] = GameControl.invSlotArray [selector, 1] - 1;
			if (GameControl.invSlotArray [selector, 1] <= 0) {
				GameControl.invSlotArray [selector, 0] = 0;
			}

		} else {
			if (GameControl.invSlotArray [selector, 0] == 0) {
			} else {
				Board.text = "This piece of equipment is too big for this stash!"; 
			}
		}


	}
	/*
	public void itemSlot1(){

		if (GameControl.invSlotArray[0,0] < 10000) {
			WorldControl.dropItem = GameControl.invSlotArray [0, 0];
			addItemStack ();
			GameControl.invSlotArray [0, 1] = GameControl.invSlotArray [0, 1] - 1;
			if (GameControl.invSlotArray [0, 1] <= 0) {
				GameControl.invSlotArray [0, 0] = 0;
			}
		} else {
			Board.text = "This equipment is too big for this stash!"; 
		}

	}




	public void itemSlot2(){


		if (GameControl.invSlotArray[1,0] < 10000) {
			WorldControl.dropItem = GameControl.invSlotArray [1, 0];
			addItemStack ();
			GameControl.invSlotArray [1, 1] = GameControl.invSlotArray [1, 1] - 1;
			if (GameControl.invSlotArray [1, 1] <= 0) {
				GameControl.invSlotArray [1, 0] = 0;
			}
		} else {
			Board.text = "This equipment is too big for this stash!"; 
			
		}
	}





	public void itemSlot3(){
		if (GameControl.invSlotArray[2,0] < 10000) {
			WorldControl.dropItem = GameControl.invSlotArray [2, 0];
			addItemStack ();
			GameControl.invSlotArray [2, 1] = GameControl.invSlotArray [2, 1] - 1;
			if (GameControl.invSlotArray [2, 1] <= 0) {
				GameControl.invSlotArray [2, 0] = 0;
			}
		} else {
			Board.text = "This equipment is too big for this stash!"; 

		}
	}


	public void itemSlot4(){
		if (GameControl.invSlotArray[3,0] < 10000) {
			WorldControl.dropItem = GameControl.invSlotArray [3, 0];
			addItemStack ();
			GameControl.invSlotArray [3, 1] = GameControl.invSlotArray [3, 1] - 1;
			if (GameControl.invSlotArray [3, 1] <= 0) {
				GameControl.invSlotArray [3, 0] = 0;
			}
		} else {
			Board.text = "This equipment is too big for this stash!"; 

		}
	}
	public void itemSlot5(){

		if (GameControl.invSlotArray[4,0] < 10000) {
			WorldControl.dropItem = GameControl.invSlotArray [4, 0];
			addItemStack ();
			GameControl.invSlotArray [4, 1] = GameControl.invSlotArray [4, 1] - 1;
			if (GameControl.invSlotArray [4, 1] <= 0) {
				GameControl.invSlotArray [4, 0] = 0;
			} else {
				Board.text = "This equipment is too big for this stash!"; 

			}
		}
	}


*/
	void Awake () {


	}


	void Start () { 



	}
	void Update (){

		


	}




}
