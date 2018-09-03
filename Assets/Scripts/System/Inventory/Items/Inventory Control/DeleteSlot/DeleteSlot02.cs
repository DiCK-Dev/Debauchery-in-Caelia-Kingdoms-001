using UnityEngine;
using System.Collections;

public class DeleteSlot02 : MonoBehaviour {
	
	AddItemScript addItem = new AddItemScript();

	public void delSlot02(){

		GameControl.invSlotArray [2, 0] = 0;
		GameControl.invSlotArray [2, 1] = 0; 
		addItem.addItemScript ();
		Debug.Log ("El nuevo valor del slot 02 es " + GameControl.invSlotArray [2, 0]);
	}


}
