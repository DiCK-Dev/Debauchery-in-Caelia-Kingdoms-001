using UnityEngine;
using System.Collections;

public class DeleteSlot00 : MonoBehaviour {

	AddItemScript addItem = new AddItemScript();

	public void delSlot00(){

		GameControl.invSlotArray [0, 0] = 0;
		GameControl.invSlotArray [0, 1] = 0; 
		addItem.addItemScript ();
		Debug.Log ("El nuevo valor del slot 00 es " + GameControl.invSlotArray [0, 0]);
	}


}
