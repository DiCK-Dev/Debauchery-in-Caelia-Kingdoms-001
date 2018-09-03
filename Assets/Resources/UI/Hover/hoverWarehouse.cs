using UnityEngine;
using System.Collections;
using UnityEngine.UI; 


public class hoverWarehouse : MonoBehaviour {


	public GameObject panHover;
	public RectTransform panHoverRect;
	public Text itemName;
	public Text itemInfo;
	public Text itemCost; 
	public int SlotSelector;


	//if its button 1 to 5. any row, use for the cons stash
	public void panHoverOver(int selector){
		if (WorldControl.stashCons [SlotSelector, 0] != 0) {
			if (selector == 0) {
				panHover.SetActive(true); 
				panHoverRect.anchorMin = new Vector2 (0.10f, 0.30f);
				panHoverRect.anchorMax = new Vector2 (0.30f, 0.70f);

			}

			if (selector == 1) {
				panHover.SetActive(true); 
				panHoverRect.anchorMin = new Vector2 (0.25f, 0.30f);
				panHoverRect.anchorMax = new Vector2 (0.45f, 0.70f);
			}

			if (selector == 2) {
				panHover.SetActive(true); 
				panHoverRect.anchorMin = new Vector2 (0.40f, 0.30f);
				panHoverRect.anchorMax = new Vector2 (0.60f, 0.70f);
			}
			if (selector == 3) {
				panHover.SetActive(true); 
				panHoverRect.anchorMin = new Vector2 (0.55f, 0.30f);
				panHoverRect.anchorMax = new Vector2 (0.75f, 0.70f);
			}
			if (selector == 4) {
				panHover.SetActive(true); 
				panHoverRect.anchorMin = new Vector2 (0.70f, 0.30f);
				panHoverRect.anchorMax = new Vector2 (0.90f, 0.70f);
			}

		}

	}

	public void panHoverOverEquip(int selector){
		if (WorldControl.stashEquip [SlotSelector, 0] != 0) {
			if (selector == 0) {
				panHover.SetActive(true); 
				panHoverRect.anchorMin = new Vector2 (0.10f, 0.30f);
				panHoverRect.anchorMax = new Vector2 (0.30f, 0.70f);

			}

			if (selector == 1) {
				panHover.SetActive(true); 
				panHoverRect.anchorMin = new Vector2 (0.25f, 0.30f);
				panHoverRect.anchorMax = new Vector2 (0.45f, 0.70f);
			}

			if (selector == 2) {
				panHover.SetActive(true); 
				panHoverRect.anchorMin = new Vector2 (0.40f, 0.30f);
				panHoverRect.anchorMax = new Vector2 (0.60f, 0.70f);
			}
			if (selector == 3) {
				panHover.SetActive(true); 
				panHoverRect.anchorMin = new Vector2 (0.55f, 0.30f);
				panHoverRect.anchorMax = new Vector2 (0.75f, 0.70f);
			}
			if (selector == 4) {
				panHover.SetActive(true); 
				panHoverRect.anchorMin = new Vector2 (0.70f, 0.30f);
				panHoverRect.anchorMax = new Vector2 (0.90f, 0.70f);
			}

		}

	}


	//inv
	public void panHoverOverMCInventory(int selector){
		if (GameControl.invSlotArray [SlotSelector, 0] != 0) {
			if (selector == 0) {
				panHover.SetActive(true); 
				panHoverRect.anchorMin = new Vector2 (0.10f, 0.30f);
				panHoverRect.anchorMax = new Vector2 (0.30f, 0.70f);

			}

			if (selector == 1) {
				panHover.SetActive(true); 
				panHoverRect.anchorMin = new Vector2 (0.25f, 0.30f);
				panHoverRect.anchorMax = new Vector2 (0.45f, 0.70f);
			}

			if (selector == 2) {
				panHover.SetActive(true); 
				panHoverRect.anchorMin = new Vector2 (0.40f, 0.30f);
				panHoverRect.anchorMax = new Vector2 (0.60f, 0.70f);
			}
			if (selector == 3) {
				panHover.SetActive(true); 
				panHoverRect.anchorMin = new Vector2 (0.55f, 0.30f);
				panHoverRect.anchorMax = new Vector2 (0.75f, 0.70f);
			}
			if (selector == 4) {
				panHover.SetActive(true); 
				panHoverRect.anchorMin = new Vector2 (0.70f, 0.30f);
				panHoverRect.anchorMax = new Vector2 (0.90f, 0.70f);
			}

		}

	}

	//enter the slot
	public void hoverConsInfo(int selector){

		if (WorldControl.stashCons [selector, 0] != 0) {
			int itemintcost = ItemData.itemDataList [WorldControl.stashCons [selector, 0]].itemCost * 2; 
			itemName.text = ItemData.itemDataList [WorldControl.stashCons [selector, 0]].itemName;
			itemInfo.text = ItemData.itemDataList [WorldControl.stashCons [selector, 0]].itemDescription;
			itemCost.text = "Cost: " + itemintcost.ToString () + " Qty: " + WorldControl.stashCons [selector, 1].ToString ();

		}
			
	}


	//enter the slot
	public void hoverEquipInfo(int selector){

		if (WorldControl.stashEquip [selector, 0] != 0) {
			int itemintcost = ItemData.itemDataList [WorldControl.stashEquip [selector, 0]].itemCost * 2; 
			itemName.text = ItemData.itemDataList [WorldControl.stashEquip [selector, 0]].itemName;
			itemInfo.text = ItemData.itemDataList [WorldControl.stashEquip[selector, 0]].itemDescription;
			itemCost.text = "Cost: " + itemintcost.ToString () + " Qty: " +  WorldControl.stashEquip[selector, 1].ToString();

		}

	}


	//enter the slot
	public void hoverCharInvInfo(int selector){

		if (GameControl.invSlotArray[selector, 0] != 0) {
			int itemintcost = ItemData.itemDataList [GameControl.invSlotArray [selector, 0]].itemCost * 2; 
			itemName.text = ItemData.itemDataList [GameControl.invSlotArray [selector, 0]].itemName;
			itemInfo.text = ItemData.itemDataList [GameControl.invSlotArray[selector, 0]].itemDescription;
			itemCost.text = "Cost: " + itemintcost.ToString () + " Qty: " + GameControl.invSlotArray[selector, 1].ToString();

		}

	}


	public void panHoverDeact(){
		panHover.SetActive(false); 
	}

	void Awake(){
		panHover.SetActive(false); 

	}





}
