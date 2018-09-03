using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class NPCEquipment : MonoBehaviour {
	public static int equipSelector;
	static int invSelectorID; 
	public Text Board; 

	public Dropdown ddInventory; 
	List<int> listInvID = new List<int>();

	public void unequip(){
		if (checkFreeSpace ()) {
			int i = 0;
			while (i < 10) {
				if (GameControl.invSlotArray [i, 0] == 0) {
					GameControl.invSlotArray [i, 0] = NPCCharList.CharRetainers [WorldControl.idx].charEquipment [equipSelector];
					GameControl.invSlotArray [i, 1] = 1;
					NPCCharList.CharRetainers [WorldControl.idx].charEquipment [equipSelector] = 0; 
					GameControl.cleanInv ();
					updateDD ();
					break;
				}
				i++;
			}
		} else {
			Board.text = "You don't have free space in your inventory!";
		}
	}

	public void ddSelector(){
		invSelectorID = listInvID [ddInventory.value];
	}

	public void equipItem(){
		int i = 0;
		if (invSelectorID == 0) {
			return;
		}
		while (i < 10) {
			if (GameControl.invSlotArray [i, 0] == invSelectorID) {
				break;
			}
			i++;
		}
		int temp = NPCCharList.CharRetainers [WorldControl.idx].charEquipment [checkSwitch()]; 
		NPCCharList.CharRetainers [WorldControl.idx].charEquipment [checkSwitch()] = GameControl.invSlotArray [i, 0];
		GameControl.invSlotArray [i, 0] = temp;
		GameControl.cleanInv ();
		updateDD ();

	}

	//to be used in the NPC item selection screen 
	public void selectItem(int selector){
		equipSelector = selector; 
		Board.text = ItemData.itemDataList[NPCCharList.CharRetainers[WorldControl.idx].charEquipment[selector]].itemDescription;
	}




	bool checkFreeSpace(){
		int i = 0;
		while (i < 10) {
			if (GameControl.invSlotArray [i, 0] == 0) 
			{
				return true;
			}
			i++;
		}
		return false; 

	}

	void updateDD(){
		ddInventory.ClearOptions ();
		listInvID.Clear ();
		int i = 0;
		while (i < 10) {
			if (GameControl.invSlotArray [i, 0] >= 10000) 
			{
				ddInventory.options.Add (new Dropdown.OptionData (ItemData.itemDataList [GameControl.invSlotArray [i, 0]].itemName));
				listInvID.Add (GameControl.invSlotArray [i, 0]);
			}
			i++;
		}
		ddInventory.value = 1;
		ddInventory.value = 0;
	}

	int checkSwitch(){
		if (invSelectorID >= 10000 && invSelectorID < 20000) {
			return 0; 
		}
		if (invSelectorID >= 20000 && invSelectorID < 30000) {
			return 1; 
		}
		if (invSelectorID >= 30000 && invSelectorID < 40000) {
			return 2; 
		}
		if (invSelectorID >= 40000 && invSelectorID < 50000) {
			return 3; 
		}
		if (invSelectorID >= 50000 && invSelectorID < 60000) {
			return 4; 
		}
		if (invSelectorID >= 60000 && invSelectorID < 70000) {
			return 5; 
		}
		if (invSelectorID >= 70000 && invSelectorID < 80000) {
			return 6; 
		}
		if (invSelectorID >= 80000 && invSelectorID < 90000) {
			return 7; 
		}
		if (invSelectorID >= 90000 && invSelectorID < 100000) {
			return 8; 
		}
		if (invSelectorID >= 100000 && invSelectorID < 110000) {
			return 9; 
		}
		if (invSelectorID >= 110000 && invSelectorID < 120000) {
			return 10; 
		}
		if (invSelectorID >= 120000 && invSelectorID < 130000) {
			return 11; 
		}
		Debug.Log ("There is a bug in checkswitch, NPCEquipment.cs");
		return 0;
	}

}
