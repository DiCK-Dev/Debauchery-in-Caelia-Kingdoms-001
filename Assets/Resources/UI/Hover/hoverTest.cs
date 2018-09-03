using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class hoverTest : MonoBehaviour {

	public GameObject panHover;
	public RectTransform panHoverRect;
	public Text itemName;
	public Text itemInfo;


	public void selecItem(int itemSelect){


	}

	public void panHoverOver(int selector){
		if (selector == 0) {
			panHover.SetActive(true); 
			panHoverRect.anchorMin = new Vector2 (0.10f, 0.20f);
			panHoverRect.anchorMax = new Vector2 (0.30f, 0.60f);





		}

		if (selector == 1) {
			panHover.SetActive(true); 
			panHoverRect.anchorMin = new Vector2 (0.40f, 0.20f);
			panHoverRect.anchorMax = new Vector2 (0.60f, 0.60f);
		}





	}

	public void panHoverDeact(){
		panHover.SetActive(false); 
	}


}
