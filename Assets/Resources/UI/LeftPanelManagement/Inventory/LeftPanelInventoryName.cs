using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class LeftPanelInventoryName : MonoBehaviour {

	public Text itemName0; 
	public Text itemName1; 
	public Text itemName2; 
	public Text itemName3; 
	public Text itemName4; 
	public Text itemName5; 
	public Text itemName6; 
	public Text itemName7; 
	public Text itemName8; 
	public Text itemName9; 





	public void itemNames(){
		itemName0.text = ItemData.itemDataList [GameControl.invSlotArray [0,0]].itemName;
		itemName1.text = ItemData.itemDataList [GameControl.invSlotArray [1,0]].itemName;
		itemName2.text = ItemData.itemDataList [GameControl.invSlotArray [2,0]].itemName;
		itemName3.text = ItemData.itemDataList [GameControl.invSlotArray [3,0]].itemName;
		itemName4.text = ItemData.itemDataList [GameControl.invSlotArray [4,0]].itemName;
		itemName5.text = ItemData.itemDataList [GameControl.invSlotArray [5,0]].itemName;
		itemName6.text = ItemData.itemDataList [GameControl.invSlotArray [6,0]].itemName;
		itemName7.text = ItemData.itemDataList [GameControl.invSlotArray [7,0]].itemName;
		itemName8.text = ItemData.itemDataList [GameControl.invSlotArray [8,0]].itemName;
		itemName9.text = ItemData.itemDataList [GameControl.invSlotArray [9,0]].itemName;


	}


	void Start(){
		itemNames ();
	}



}
