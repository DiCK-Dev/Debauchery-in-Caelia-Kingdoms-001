using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Settings : MonoBehaviour {

	public Text FurryText; 
	public Text FutaText;



	public void furryOff()
	{

		if (WorldControl.furryOn == true) 
		{
			WorldControl.furryOn = false; 
			FurryText.text = "Furry is disabled"; 
		}
		else 
		{
			WorldControl.furryOn = true; 
			FurryText.text = "Furry is enabled"; 
		}
	}

	public void futaOff()
	{
		if (WorldControl.futaOn == true) {
			WorldControl.futaOn = false; 
			FutaText.text = "Futa is disabled";
		} else {
			WorldControl.futaOn = true;
			FutaText.text = "Futa is enabled"; 
		}
	}


	void Awake (){
		if (WorldControl.furryOn == true) {
			FurryText.text = "Furry is enabled";
		} else { 
			FurryText.text = "Furry is disabled";
		}

		if (WorldControl.futaOn == true) {
			FutaText.text = "Futa is enabled";
		} else {
			FutaText.text = "futa is disabled";
		}
	}


}
