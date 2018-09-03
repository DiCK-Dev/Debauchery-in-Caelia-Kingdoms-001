using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LeftPanelSliders : MonoBehaviour {

	public Slider sliderHP;
	public Slider sliderArousal;
	public Slider sliderMP;
	public Text textHP;
	public Text textArousal;
	public Text textMP;

	string intactualhp;
	string intmaxhp;
	string intactualarousal;
	string intmaxarousal;
	string intactualmp;
	string intmaxmp; 

	void Awake(){
		sliderHP.maxValue = GameControl.maxHealth;
		sliderArousal.maxValue = GameControl.maxArousal;
		sliderMP.maxValue = GameControl.maxMP;
		intmaxhp = GameControl.maxHealth.ToString ();
		intmaxarousal = GameControl.maxArousal.ToString ();
		intmaxmp = GameControl.maxMP.ToString ();
	}

	void Update () 
	{
		intactualhp = Mathf.Round( GameControl.actualHealth).ToString ();
		intactualarousal = Mathf.Round(GameControl.actualArousal).ToString ();
		intactualmp = Mathf.Round(GameControl.actualMP).ToString ();
	
		sliderHP.value = GameControl.actualHealth; 
		sliderArousal.value = GameControl.actualArousal;
		sliderMP.value = GameControl.actualMP;
		textHP.text = intactualhp + " / " + intmaxhp;
		textArousal.text = intactualarousal + " / " + intmaxarousal;
		textMP.text = intactualmp + " / " + intmaxmp; 


	}
}
