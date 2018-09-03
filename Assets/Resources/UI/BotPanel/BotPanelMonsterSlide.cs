using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BotPanelMonsterSlide : MonoBehaviour {

	public Slider sliderHP;
	public Slider sliderArousal;
	public Slider sliderMP;
	public Text textHP;
	public Text textArousal;
	public Text textMP;


	static int i;


	public void loadEnemy()
	{
		//for now is only loading monster 1, check the original slider for more info 
		i = 0; 

		sliderHP.maxValue = NPCCharList.CharMonster [i].maxHealth;
		sliderArousal.maxValue = NPCCharList.CharMonster[i].maxArousal;
		sliderMP.maxValue = NPCCharList.CharMonster[i].maxMP;


	}



	void Start(){
		loadEnemy ();
	}

	void Update () 
	{

		sliderHP.value = NPCCharList.CharMonster [i].currentHealth;
		sliderArousal.value = NPCCharList.CharMonster [i].currentArousal;
		sliderMP.value = NPCCharList.CharMonster [i].currentMP;

		textHP.text = Mathf.Round( NPCCharList.CharMonster [i].currentHealth).ToString() + "/" + NPCCharList.CharMonster [i].maxHealth.ToString ();
		textArousal.text = Mathf.Round(NPCCharList.CharMonster [i].currentArousal).ToString() + "/" + NPCCharList.CharMonster [i].maxArousal.ToString ();
		textMP.text = Mathf.Round(NPCCharList.CharMonster [i].currentMP).ToString()+ "/"+ NPCCharList.CharMonster [i].maxMP.ToString ();


	}
}
