using UnityEngine;
using System.Collections;

public class DeleteSlot01 : MonoBehaviour {

	AddItemScript addItem = new AddItemScript();

	public void delSlot01(){
		GameControl.invSlotArray [1, 0] = 0;
		GameControl.invSlotArray [1, 1] = 0; 
		addItem.addItemScript ();
		Debug.Log ("El nuevo valor del slot 01 es " + GameControl.invSlotArray [1, 0]);
	}


}
