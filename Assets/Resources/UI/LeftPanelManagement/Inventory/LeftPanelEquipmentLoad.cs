using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LeftPanelEquipmentLoad : MonoBehaviour {

	public Text Equip0;
	public Text Equip1;
	public Text Equip2;
	public Text Equip3;
	public Text Equip4;
	public Text Equip5;
	public Text Equip6;
	public Text Equip7;
	public Text Equip8;

	public Text EquipAcc0;
	public Text EquipAcc1;
	public Text EquipAcc2;

	public static bool invFull;
	public static int itemSelection;

	public Text Board;

	public Button buttEquipRemove0;
	public Button buttEquipRemove1;
	public Button buttEquipRemove2;
	public Button buttEquipRemove3;
	public Button buttEquipRemove4;
	public Button buttEquipRemove5;
	public Button buttEquipRemove6;
	public Button buttEquipRemove7;
	public Button buttEquipRemove8;

	public void equipName(){

		if (GameControl.charEquipment [0] != 10000 && GameControl.charEquipment [0] != 0) {
			Equip0.text = ItemData.itemDataList [GameControl.charEquipment [0]].itemName;
		} else {
			Equip0.text = "Unarmed"; 
		}

		if (GameControl.charEquipment [1] != 20000 && GameControl.charEquipment [1] != 0) {
			Equip1.text = ItemData.itemDataList[GameControl.charEquipment[1]].itemName;
		} else {
			Equip1.text = "Naked"; 
		}

		if (GameControl.charEquipment [2] != 30000 && GameControl.charEquipment [2] != 0) {
			Equip2.text = ItemData.itemDataList[GameControl.charEquipment[2]].itemName;
		} else {
			Equip2.text = "Empty"; 
		}


		if (GameControl.charEquipment [3] != 40000 && GameControl.charEquipment [3] != 0) {
			Equip3.text = ItemData.itemDataList[GameControl.charEquipment[3]].itemName;
		} else {
			Equip3.text = "Empty"; 
		}

		if (GameControl.charEquipment [4] != 50000 && GameControl.charEquipment [4] != 0) {
			Equip4.text = ItemData.itemDataList[GameControl.charEquipment[4]].itemName;
		} else {
			Equip4.text = "Empty"; 
		}

		if (GameControl.charEquipment [5] != 60000 && GameControl.charEquipment [5] != 0) {
			Equip5.text = ItemData.itemDataList[GameControl.charEquipment[5]].itemName;
		} else {
			Equip5.text = "Empty"; 
		}

		if (GameControl.charEquipment [6] != 70000 && GameControl.charEquipment [6] != 0) {
			Equip6.text = ItemData.itemDataList[GameControl.charEquipment[6]].itemName;
		} else {
			Equip6.text = "Empty"; 
		}

		if (GameControl.charEquipment [7] != 80000 && GameControl.charEquipment [7] != 0) {
			Equip7.text = ItemData.itemDataList[GameControl.charEquipment[7]].itemName;
		} else {
			Equip7.text = "Empty"; 
		}

		if (GameControl.charEquipment [8] != 90000 && GameControl.charEquipment [8] != 0) {
			Equip8.text = ItemData.itemDataList[GameControl.charEquipment[8]].itemName;
		} else {
			Equip8.text = "Empty"; 
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
			if (GameControl.charEquipment [0] != 10000 && GameControl.charEquipment [0] != 0) {
				Board.text = ItemData.itemDataList [GameControl.charEquipment [0]].itemDescription;
			} else {
				Board.text = "You are fighting barehanded."; 
			}
		}


		if (selector == 1) {

			if (GameControl.charEquipment [1] != 20000 && GameControl.charEquipment [1] != 0) {
				Board.text = ItemData.itemDataList [GameControl.charEquipment [1]].itemDescription;
			} else {
				Board.text = "You are not using armour or clothing to cover your body!"; 
			}

		}

		if (selector == 2) {

			if (GameControl.charEquipment [2] != 30000 && GameControl.charEquipment [2] != 0) {
				Board.text = ItemData.itemDataList [GameControl.charEquipment [2]].itemDescription;
			} else {
				Board.text = "You are not wearing a head accesory."; 
			}

		}

		if (selector == 3) {
			if (GameControl.charEquipment [3] != 40000 && GameControl.charEquipment [3] != 0) {
				Board.text = ItemData.itemDataList [GameControl.charEquipment [3]].itemDescription;
			} else {
				Board.text = "You are not wearing a face accesory."; 
			}

		}


		if (selector == 4) {
			if (GameControl.charEquipment [4] != 50000 && GameControl.charEquipment [4] != 0) {
				Board.text = ItemData.itemDataList [GameControl.charEquipment [4]].itemDescription;
			} else {
				Board.text = "You are not wearing a neck accesory."; 
			}

		}

		if (selector == 5) {
			if (GameControl.charEquipment [5] != 60000 && GameControl.charEquipment [5] != 0) {
				Board.text = ItemData.itemDataList [GameControl.charEquipment [5]].itemDescription;
			} else {
				Board.text = "You are not wearing a shoulder accesory."; 
			}

		}


		if (selector == 6) {
			if (GameControl.charEquipment [6] != 70000 && GameControl.charEquipment [6] != 0) {
				Board.text = ItemData.itemDataList [GameControl.charEquipment [6]].itemDescription;
			} else {
				Board.text = "You are not wearing armwear."; 
			}

		}

		if (selector == 7) {
			if (GameControl.charEquipment [7] != 80000 && GameControl.charEquipment [7] != 0) {
				Board.text = ItemData.itemDataList [GameControl.charEquipment [7]].itemDescription;
			} else {
				Board.text = "You are not wearing footwear."; 
			}

		}

		if (selector == 8) {
			if (GameControl.charEquipment [8] != 90000 && GameControl.charEquipment [8] != 0) {
				Board.text = ItemData.itemDataList [GameControl.charEquipment [8]].itemDescription;
			} else {
				Board.text = "You are not wearing make up."; 
			}

		}


	}





	public void blockButt()
	{	
		buttEquipRemove0.interactable = false; 
		buttEquipRemove1.interactable = false; 
		buttEquipRemove2.interactable = false; 
		buttEquipRemove3.interactable = false; 
		buttEquipRemove4.interactable = false; 
		buttEquipRemove5.interactable = false; 
		buttEquipRemove6.interactable = false; 
		buttEquipRemove7.interactable = false; 
		buttEquipRemove8.interactable = false; 


	
		if (GameControl.charEquipment [0] != 10000 && GameControl.charEquipment [0] != 0) {
			buttEquipRemove0.interactable = true; 
		}

		if (GameControl.charEquipment [1] != 20000 && GameControl.charEquipment [1] != 0) {
			buttEquipRemove1.interactable = true; 
		}

		if (GameControl.charEquipment [2] != 30000 && GameControl.charEquipment [2] != 0) {
			buttEquipRemove2.interactable = true; 
		}

		if (GameControl.charEquipment [3] != 40000 && GameControl.charEquipment [3] != 0) {
			buttEquipRemove3.interactable = true; 
		}

		if (GameControl.charEquipment [4] != 50000 && GameControl.charEquipment [4] != 0) {
			buttEquipRemove4.interactable = true; 
		}

		if (GameControl.charEquipment [5] != 60000 && GameControl.charEquipment [5] != 0) {
			buttEquipRemove5.interactable = true; 
		}

		if (GameControl.charEquipment [6] != 70000 && GameControl.charEquipment [6] != 0) {
			buttEquipRemove6.interactable = true; 
		}

		if (GameControl.charEquipment [7] != 80000 && GameControl.charEquipment [7] != 0) {
			buttEquipRemove7.interactable = true; 
		}

		if (GameControl.charEquipment [8] != 90000 && GameControl.charEquipment [8] != 0) {
			buttEquipRemove8.interactable = true; 
		}




	}

	void Awake(){

		blockButt ();
		equipName ();
	}





}
