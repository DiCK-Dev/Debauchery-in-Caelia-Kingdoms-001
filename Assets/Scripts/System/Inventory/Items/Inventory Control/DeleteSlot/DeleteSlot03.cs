using UnityEngine;
using System.Collections;

public class DeleteSlot03 : MonoBehaviour {

	AddItemScript addItem = new AddItemScript();

	public void delSlot03(){
		GameControl.invSlotArray [3, 0] = 0;
		GameControl.invSlotArray [3, 1] = 0; 
		addItem.addItemScript ();
		Debug.Log ("El nuevo valor del slot 03 es " + GameControl.invSlotArray [3, 0]);
	}


}

