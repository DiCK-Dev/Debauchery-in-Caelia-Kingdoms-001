using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BotPanelMCSliders : MonoBehaviour {

	public Slider sliderHP;
	public Slider sliderArousal;
	public Slider sliderMP;
	public Text textHP;
	public Text textArousal;
	public Text textMP;

	void Start(){

	}

	void Update (){

		sliderHP.value = GameControl.actualHealth;
		sliderArousal.value = GameControl.actualArousal;
		sliderMP.value = GameControl.actualMP;

		textHP.text = Mathf.Round( GameControl.actualHealth).ToString() + "/" + GameControl.maxHealth.ToString ();
		textArousal.text = Mathf.Round( GameControl.actualArousal).ToString() + "/" + GameControl.maxArousal.ToString ();
		textMP.text = Mathf.Round( GameControl.actualMP).ToString()+ "/"+ GameControl.maxMP.ToString ();


	}



}
