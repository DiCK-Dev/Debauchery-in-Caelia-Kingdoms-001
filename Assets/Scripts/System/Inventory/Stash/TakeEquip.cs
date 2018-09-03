using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TakeEquip : MonoBehaviour {


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



	AddItemScript addItem = new AddItemScript();

	// deactivates the empty stash slot 
	public void deactButton1(){
		if (WorldControl.stashEquip[0,0] > 0) {

			buttSlot1.GetComponent<Button> ().interactable = true; 

		} else { 

			buttSlot1.GetComponent<Button> ().interactable = false; 

		}

	}
	public void deactButton2(){
		if (WorldControl.stashEquip[1,0] > 0) {

			buttSlot2.GetComponent<Button> ().interactable = true; 

		} else { 

			buttSlot2.GetComponent<Button> ().interactable = false; 

		}

	}
	public void deactButton3(){
		if (WorldControl.stashEquip[2,0] > 0) {

			buttSlot3.GetComponent<Button> ().interactable = true; 

		} else { 

			buttSlot3.GetComponent<Button> ().interactable = false; 

		}

	}
	public void deactButton4(){
		if (WorldControl.stashEquip[3,0] > 0) {

			buttSlot4.GetComponent<Button> ().interactable = true; 

		} else { 

			buttSlot4.GetComponent<Button> ().interactable = false; 

		}

	}
	public void deactButton5(){
		if (WorldControl.stashEquip[4,0] > 0) {

			buttSlot5.GetComponent<Button> ().interactable = true; 

		} else { 

			buttSlot5.GetComponent<Button> ().interactable = false; 

		}

	}


	// HOVER 


	//checker 

	public void checkCharInv(){
		WorldControl.stashFull = true; 
		i = 0; 


		while (i < 10) {
			if(GameControl.invSlotArray[i,0] == 0){
				WorldControl.stashFull = false; 
				break; 
			}

			i++;
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

		} else {


		}


	}


	// add item to stack

	public void addItemInv () {

		i = 0; 
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

	// on case button add 

	public void takeEquipSlot(int selector){
		checkCharInv ();
		if (WorldControl.invFull == false) {
			if (WorldControl.stashEquip [selector, 0] != 0) {
				WorldControl.dropItem = WorldControl.stashEquip [selector, 0];

				addItem.addItemScript (); 
				WorldControl.stashEquip [selector, 1] = 0;
				WorldControl.stashEquip [selector, 0] = 0; 
				WorldControl.dropItem = 0;
			}
		}
	}

	public void itemSlot1(){

		WorldControl.dropItem = WorldControl.stashEquip [0, 0];
		Debug.Log (WorldControl.dropItem);
		addItem.addItemScript (); 
		WorldControl.stashEquip [0, 1] = WorldControl.stashCons [0, 1] - 1;
		WorldControl.stashEquip [0, 0] = 0; 
		WorldControl.dropItem = 0;
		Debug.Log (WorldControl.dropItem);
	}
	public void itemSlot2(){

		WorldControl.dropItem = WorldControl.stashEquip [1, 0];

		addItem.addItemScript (); 
		WorldControl.stashEquip [1, 1] = WorldControl.stashCons [1, 1] - 1;
		WorldControl.stashEquip [1, 0] = 0; 
	}
	public void itemSlot3(){

		WorldControl.dropItem = WorldControl.stashEquip [2, 0];

		addItem.addItemScript (); 
		WorldControl.stashEquip [2, 1] = WorldControl.stashCons [2, 1] - 1;
		WorldControl.stashEquip [2, 0] = 0; 
	}
	public void itemSlot4(){

		WorldControl.dropItem = WorldControl.stashEquip [3, 0];

		addItem.addItemScript (); 
		WorldControl.stashEquip [3, 1] = WorldControl.stashCons [3, 1] - 1;
		WorldControl.stashEquip [3, 0] = 0; 
	}
	public void itemSlot5(){

		WorldControl.dropItem = WorldControl.stashEquip [4, 0];

		addItem.addItemScript (); 
		WorldControl.stashEquip [4, 1] = WorldControl.stashCons [4, 1] - 1;
		WorldControl.stashEquip [4, 0] = 0; 
	}



}
