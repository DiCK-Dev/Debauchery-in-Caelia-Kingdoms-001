using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class PutEquip : MonoBehaviour {



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

	int i;
	int x; 


	// DEACTIVATING
	public void deactButton1(){
		if (GameControl.invSlotArray[0,0] >= 10000) {
			buttSlot1.GetComponent<Button> ().interactable = true; 

		} else {
			buttSlot1.GetComponent<Button> ().interactable = false; 

		}

	}
	public void deactButton2(){
		if (GameControl.invSlotArray[1,0] >= 10000) {
			buttSlot2.GetComponent<Button> ().interactable = true; 

		} else {
			buttSlot2.GetComponent<Button> ().interactable = false; 

		}

	}
	public void deactButton3(){
		if (GameControl.invSlotArray[2,0] >= 10000) {
			buttSlot3.GetComponent<Button> ().interactable = true; 

		} else {
			buttSlot3.GetComponent<Button> ().interactable = false; 

		}

	}
	public void deactButton4(){
		if (GameControl.invSlotArray[3,0] >= 10000) {
			buttSlot4.GetComponent<Button> ().interactable = true; 

		} else {
			buttSlot4.GetComponent<Button> ().interactable = false; 

		}

	}
	public void deactButton5(){
		if (GameControl.invSlotArray[4,0] >= 10000) {
			buttSlot5.GetComponent<Button> ().interactable = true; 

		} else {
			buttSlot5.GetComponent<Button> ().interactable = false; 

		}

	}




	// CHECK 
	public void checkStack(){
		i = 0;  
		WorldControl.stashFull = true; 
		while (i < 10) {
			if (WorldControl.stashEquip [i,0] <= 0) {
				WorldControl.stashFull = false;
				break; 
			}
			else 
			{
				WorldControl.stashFull = true; 
			}

			i++;
		}
		closeForFull ();	

	}

	//deactivate everything if its full 
	public void closeForFull(){
		if (WorldControl.stashFull == true) {


			Board.text = "Your stash is full and you cant add anything else!"; 

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


	// add item 

	public void addItemStack(){
		i = 0;


		{
			while (i < 10) {
				if (WorldControl.stashEquip [i, 0] <= 0) {
					WorldControl.stashEquip [i, 0] = WorldControl.dropItem; 
					WorldControl.stashEquip [i, 1] = 1; 
					Board.text = "You just added " + ItemData.itemDataList [WorldControl.dropItem].itemName + " to the stack!"; 
					break; 

				}
				i++;
			}
		}

	}


	// per case button

	public void addEquipSlot(int selector){
		checkStack ();
		if (WorldControl.stashFull == false) {
			if (GameControl.invSlotArray [selector, 0] >= 10000) {
				WorldControl.dropItem = GameControl.invSlotArray [selector, 0];
				addItemStack ();
				GameControl.invSlotArray [selector, 1] = 0;
				GameControl.invSlotArray [selector, 0] = 0;
			
			} else {
				if (GameControl.invSlotArray [selector, 0] == 0) {
				} else {
					Board.text = "This space is only for equipment!"; 
				}
			}
		}
	}



	public void itemSlot1(){

		if (GameControl.invSlotArray[0,0] >= 10000) {
			WorldControl.dropItem = GameControl.invSlotArray [0, 0];
			addItemStack ();
			GameControl.invSlotArray [0, 1] = GameControl.invSlotArray [0, 1] - 1;
			if (GameControl.invSlotArray [0, 1] <= 0) {
				GameControl.invSlotArray [0, 0] = 0;
			}
		} else {
			Board.text = "This equipment is too small for this stash!... That makes no sense actually..."; 
		}

	}


	public void itemSlot2(){

		if (GameControl.invSlotArray[1,0] >= 10000) {
			WorldControl.dropItem = GameControl.invSlotArray [1, 0];
			addItemStack ();
			GameControl.invSlotArray [1, 1] = GameControl.invSlotArray [1, 1] - 1;
			if (GameControl.invSlotArray [1, 1] <= 0) {
				GameControl.invSlotArray [1, 0] = 0;
			}
		} else {
			Board.text = "This equipment is too small for this stash!... That makes no sense actually..."; 
		}

	}

	public void itemSlot3(){

		if (GameControl.invSlotArray[2,0] >= 10000) {
			WorldControl.dropItem = GameControl.invSlotArray [2, 0];
			addItemStack ();
			GameControl.invSlotArray [2, 1] = GameControl.invSlotArray [2, 1] - 1;
			if (GameControl.invSlotArray [2, 1] <= 0) {
				GameControl.invSlotArray [2, 0] = 0;
			}
		} else {
			Board.text = "This equipment is too small for this stash!... That makes no sense actually..."; 
		}

	}

	public void itemSlot4(){

		if (GameControl.invSlotArray[3,0] >= 10000) {
			WorldControl.dropItem = GameControl.invSlotArray [3, 0];
			addItemStack ();
			GameControl.invSlotArray [3, 1] = GameControl.invSlotArray [3, 1] - 1;
			if (GameControl.invSlotArray [3, 1] <= 0) {
				GameControl.invSlotArray [3, 0] = 0;
			}
		} else {
			Board.text = "This equipment is too small for this stash!... That makes no sense actually..."; 
		}

	}

	public void itemSlot5(){

		if (GameControl.invSlotArray[4,0] >= 10000) {
			WorldControl.dropItem = GameControl.invSlotArray [4, 0];
			addItemStack ();
			GameControl.invSlotArray [4, 1] = GameControl.invSlotArray [4, 1] - 1;
			if (GameControl.invSlotArray [4, 1] <= 0) {
				GameControl.invSlotArray [4, 0] = 0;
			}
		} else {
			Board.text = "This equipment is too small for this stash!... That makes no sense actually..."; 
		}

	}

	void Awake () {



	}





	
	// Update is called once per frame
	void Update () {





	}
}
