using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LeftPanelAccesoryLoad : MonoBehaviour {

	public Text Equip0;
	public Text Equip1;
	public Text Equip2;


	public static bool invFull;
	public static int itemSelection;

	public Text Board;

	public Button buttEquipRemove0;
	public Button buttEquipRemove1;
	public Button buttEquipRemove2;

	public void equipName(){

		if (GameControl.charEquipment [9] != 100000 && GameControl.charEquipment [9] != 0) {
			Equip0.text = ItemData.itemDataList [GameControl.charEquipment [9]].itemName;
		} else {
			Equip0.text = "No ring"; 
		}

		if (GameControl.charEquipment [10] != 110000 && GameControl.charEquipment [10] != 0) {
			Equip1.text = ItemData.itemDataList[GameControl.charEquipment[10]].itemName;
		} else {
			Equip1.text = "No amulet"; 
		}

		if (GameControl.charEquipment [11] != 120000 && GameControl.charEquipment [11] != 0) {
			Equip2.text = ItemData.itemDataList[GameControl.charEquipment[11]].itemName;
		} else {
			Equip2.text = "No trophy"; 
		}





	}



	public void checkInventory(int itemSel)
	{
		itemSelection = itemSel;
		invFull = true; 
		WorldControl.dropItem = 0; 
		int i = 0;
		while (i < 9) {
			if (GameControl.invSlotArray [i, 0] == 0) {
				invFull = false; 
				WorldControl.dropItem = GameControl.charEquipment [itemSel];
				LeftPanelEquipmentLoad.itemSelection = itemSel;
				blockButt ();
				break;
			}

			i++;
		}

		if (invFull == true) {
			Board.text = "You have no free space in your inventory, throw or use something first."; 
		}




	}


	public void equipSummary(int selector){

		if (selector == 0) {
			if (GameControl.charEquipment [9] != 100000 && GameControl.charEquipment [9] != 0) {
				Board.text = ItemData.itemDataList [GameControl.charEquipment [9]].itemDescription;
			} else {
				Board.text = "You are not using any rings!"; 
			}
		}


		if (selector == 1) {

			if (GameControl.charEquipment [10] != 110000 && GameControl.charEquipment [10] != 0) {
				Board.text = ItemData.itemDataList [GameControl.charEquipment [10]].itemDescription;
			} else {
				Board.text = "You are not using any amulets!"; 
			}

		}

		if (selector == 2) {

			if (GameControl.charEquipment [11] != 120000 && GameControl.charEquipment [11] != 0) {
				Board.text = ItemData.itemDataList [GameControl.charEquipment [11]].itemDescription;
			} else {
				Board.text = "You are not wearing any trophy!"; 
			}

		}





	}





	public void blockButt()
	{	


	
		if (GameControl.charEquipment [9] != 100000 && GameControl.charEquipment [9] != 0) {
			buttEquipRemove0.interactable = true; 
		} else {
			buttEquipRemove0.interactable = false; 

		}

		if (GameControl.charEquipment [10] != 110000 && GameControl.charEquipment [10] != 0) {
			buttEquipRemove1.interactable = true; 
		} else {
			buttEquipRemove1.interactable = false; 

		}

		if (GameControl.charEquipment [11] != 120000 && GameControl.charEquipment [11] != 0) {
			buttEquipRemove2.interactable = true; 
		} else {
			buttEquipRemove2.interactable = false; 

		}


	}

	void Awake(){

		blockButt ();
		equipName ();
	}

	void Update(){
		equipName ();
		blockButt ();
	}







}
