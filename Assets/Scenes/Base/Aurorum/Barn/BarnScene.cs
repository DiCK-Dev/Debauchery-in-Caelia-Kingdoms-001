using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BarnScene : MonoBehaviour {

	public Text buttName;

	public RectTransform mainPanel;
	public RectTransform EndTurnPanel; 
	public RectTransform eliseTalkPanel; 

	public Text Board; 
	// Use this for initialization

	int i = 0; 

	public void callMainPanel() {
		mainPanel.SetAsLastSibling ();
		BarnStart ();

	}
	// Barnstart scene texts
	/// /////////////////////////////////////////////////////////////////////////////////////////////////

	public void BarnStart (){
		if (CityControl.city100BarnMeet == false) 
		{
			Board.text = "You enter the Barn for the first time and are impressed"; 
			CityControl.city100BarnMeet = true; 

		}else
		{
			if (CityControl.city100Corruption >= 100) {
				Board.text = "the market scene of corruption at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption > 90) 
			{
				Board.text = "the market scene of corruption at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption > 70) 
			{
				Board.text = "the market scene of corruption at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption > 50) 
			{
				Board.text = "the market scene of corruption at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption > 30) 
			{
				Board.text = "the market scene of corruption at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption > 10) 
			{
				Board.text = "the market scene of corruption at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption >= 0) 
			{
				Board.text = "the market scene of corruption at " + CityControl.city100Corruption;
			} 

		}

	}


	/// <summary>
	/// /////////////////////////////////////////////////////////////////////////////////////////////////
	public void TalkElise()
	{

		if (NPCControl.npc200Meet == false) 
		{
			EndTurnPanel.SetAsLastSibling ();
			Board.text = "FIRST TALK WITH HER" ;

			NPCControl.npc200Meet = true; 
		} else {
			Board.text = "We already meet you moron!"; 
			eliseTalkPanel.SetAsLastSibling (); 
		}
	}


	public void TalkElisePast (){
		i = 0; 
		EndTurnPanel.SetAsLastSibling ();
		while (i < 2) {


			if (NPCControl.npc200Talk [0, 0] == false) {
				Board.text = "You talk about her past for the first time";
				NPCControl.npc200Talk [0, 0] = true; 
				break; 
			} else if (NPCControl.npc200Talk [0, 1] == false) {
				Board.text = "You talk about her past for the second time";
				NPCControl.npc200Talk [0, 1] = true; 
				break; 
			} else if (NPCControl.npc200Talk [0, 2] == false) {
				Board.text = "You talk about her past for the third time";
				NPCControl.npc200Talk [0, 2] = true; 
				NPCControl.npc200Relationship = NPCControl.npc200Relationship + 5; 
				break; 
			} else {
				Board.text = "You talk about her past for the third time, you know everything there is to know";
				break;
			}


			i++; 
		}
	}



	public void TalkEliseBarn (){
		i = 0; 
		EndTurnPanel.SetAsLastSibling ();
		while (i < 2) {


			if (NPCControl.npc200Talk [1, 0] == false) {
				Board.text = "You talk about her past for the first time";
				NPCControl.npc200Talk [1, 0] = true; 
				break; 
			} else if (NPCControl.npc200Talk [1, 1] == false) {
				Board.text = "You talk about her past for the second time";
				NPCControl.npc200Talk [1, 1] = true; 
				break; 
			} else if (NPCControl.npc200Talk [1, 2] == false) {
				Board.text = "You talk about her past for the third time";
				NPCControl.npc200Talk [1, 2] = true; 
				NPCControl.npc200Relationship = NPCControl.npc200Relationship + 5; 
				break; 
			} else {
				Board.text = "You talk about her past for the third time, you know everything there is to know";
				break;
			}


			i++; 
		}
	}






	/// /////////////////////////////////////////////////////////////////////////////////////////////////


	void Start () {
		BarnStart ();

		if (NPCControl.npc200Meet != true) {
			buttName.text = "Skimpy clothed woman"; 
		} else {
			buttName.text = "Junia"; 
		}


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
