using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SlidersCharOnly : MonoBehaviour {

	public Slider slider1; 
	public Slider slider2; 

	public void PlayerHP(){
		slider1.value = GameControl.actualHealth; 
		slider1.maxValue = GameControl.maxHealth;

	}

	public void PlayerLust(){
		slider2.value = GameControl.actualArousal; 
		slider2.maxValue = GameControl.maxArousal;

	}


	void Update () {
		PlayerHP ();
		PlayerLust ();
	
	}
}
