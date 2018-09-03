using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class InventoryText : MonoBehaviour {


	public Text inventoryText; 
	void Start () {
		defaultText ();
	
	}

	public void defaultText(){

		inventoryText.text = "default text, here goes the equipment"; 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
