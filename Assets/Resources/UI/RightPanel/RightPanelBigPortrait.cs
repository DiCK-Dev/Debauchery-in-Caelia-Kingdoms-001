using UnityEngine;
using System.Collections;

public class RightPanelBigPortrait : MonoBehaviour {


	public GameObject itemPrefab; 



	public void createPortrait() {
		GameObject newItem = Instantiate (itemPrefab) as GameObject;
		newItem.name = gameObject.name + " BigPortrait";
		//newItem.transform.parent = gameObject.transform;
	}


}
