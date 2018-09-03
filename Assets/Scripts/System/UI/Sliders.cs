using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Sliders : MonoBehaviour {
	public Slider slider1; 
	public Slider slider2; 
	public Slider slider3; 
	public Slider slider4; 

	public void PlayerHP(){
		slider1.value = GameControl.actualHealth; 
		slider1.maxValue = GameControl.maxHealth;

	}

	public void PlayerLust(){
		slider2.value = GameControl.actualArousal; 
		slider2.maxValue = GameControl.maxArousal;

	}

	public void EnemyHP(){
		slider3.value = WorldControl.enemyHP;
		slider3.maxValue = WorldControl.enemyMaxHP; 

	}

	public void EnemyLust(){
		slider4.value = WorldControl.enemyLust; 
		slider4.maxValue = WorldControl.enemyMaxLust;

	}



	
	// Update is called once per frame
	void Update () 
	{
		PlayerHP ();
		PlayerLust ();
		EnemyHP ();
		EnemyLust ();
	
	}
}
