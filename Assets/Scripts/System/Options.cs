using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Options : MonoBehaviour {
	public Text textButtFurry;
	public Text textButtFuta; 
	public Text Board; 
	int i;


	public void optionText(){
		Board.text = "What you want to change? NOTE: Tags will be implemented soon.";
	}

	public void furryActivate(){
			if (WorldControl.furryOn == false) {
				WorldControl.furryOn = true;
				textButtFurry.text = "Furry is enabled";
				Board.text = "Furry is now activated!";
	
		}else   {
				WorldControl.furryOn = false;
				textButtFurry.text = "Furry is disabled";
				Board.text = "Furry is now deactivated!";

			}

 
	}

	public void futaActivate(){
		if (WorldControl.futaOn == false) {
			WorldControl.futaOn = true; 
			textButtFuta.text = "Futa is enabled";
			Board.text = "Futa is now activated!";
		} else {
			WorldControl.futaOn = false; 
			textButtFuta.text = "Futa is disabled";
			Board.text = "Futa is now deactivated!"; 
		}
	}



	// Use this for initialization
	void Start () {
		if (WorldControl.furryOn == true) {
			textButtFurry.text = "Furry is enabled";
		} else {
			textButtFurry.text = "Furry is disabled";
		}


		if (WorldControl.futaOn == true) {
			textButtFuta.text = "Futa is enabled";
		} else {
			textButtFuta.text = "Futa is disabled";
		}
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}
}
