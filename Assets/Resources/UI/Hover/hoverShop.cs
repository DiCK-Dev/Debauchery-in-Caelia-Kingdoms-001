using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class hoverShop : MonoBehaviour {


	public GameObject panHover;
	public RectTransform panHoverRect;
	public Text itemName;
	public Text itemInfo;
	public Text itemCost; 


	//if its button 1 to 5. any row
	public void panHoverOver(int selector){
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

	//enter the item number
	public void hoverInfo(int selector){
		int itemintcost = ItemData.itemDataList [selector].itemCost * 2; 
		itemName.text = ItemData.itemDataList [selector].itemName;
		itemInfo.text = ItemData.itemDataList [selector].itemDescription;
		itemCost.text = "Cost: " + itemintcost.ToString ();

	}


	public void panHoverDeact(){
		panHover.SetActive(false); 
	}

	void Awake(){
		panHover.SetActive(false); 

	}

}
