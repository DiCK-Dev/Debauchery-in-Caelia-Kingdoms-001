using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HairTreatment : MonoBehaviour {
	public Text board; 

	CharacteristicsSettler charSettler = new CharacteristicsSettler();



	/// <summary>
	/// Color
	/// </summary>
	public void buyHairDontGrow(){

		/*
		if (GameControl.charGold >= 30 && GameControl.hairGrow == true) {
			GameControl.hairGrow = false; 
			GameControl.charGold = GameControl.charGold - 30; 
			board.text = "You just bought this item!";
		} else if (GameControl.charGold < 30) {
			board.text = "Your dont have enough gold!"; 
		} else if (GameControl.hairGrow == false) {
			board.text = "Your hair isnt growing already!"; 
		}*/


	}

	/// <summary>
	/// Color
	/// </summary>	
	public void buyHairGrow(){
		/*

		if (GameControl.charGold >= 10 && GameControl.hairGrow == false) {
			GameControl.hairGrow = true;
			GameControl.charGold = GameControl.charGold - 10; 
			board.text = "You just bought this item!";
		} else if (GameControl.charGold < 10) {
			board.text = "Your dont have enough gold!"; 
		} else if (GameControl.hairGrow == true) {
			board.text = "Your hair is growing already!"; 
		}*/

	}


	/// <summary>
	/// Color
	/// </summary>	
	public void buyIncreaseLengthHair(){


		if (GameControl.charGold >= 10 && GameControl.hairLength <= 90) {
			GameControl.hairLength = GameControl.hairLength + 5; 
			charSettler.setHairLength ();
			GameControl.charGold = GameControl.charGold - 10; 
			board.text = "You just bought this item!";
		} else if (GameControl.charGold < 10) {
			board.text = "Your dont have enough gold!"; 
		} else if (GameControl.hairLength >= 90) {
			board.text = "Your hair is as long as i cn be!"; 
		}

	}


	/// <summary>
	/// Color
	/// </summary>	
	public void buyReduceLengthHair(){


		if (GameControl.charGold >= 10 && GameControl.hairLength > 0) {
			GameControl.hairLength = GameControl.hairLength - 3; 
			charSettler.setHairLength ();
			GameControl.charGold = GameControl.charGold - 10; 
			board.text = "You just bought this item!";
		} else if (GameControl.charGold < 10) {
			board.text = "Your dont have enough gold!"; 
		} else if (GameControl.hairLength <= 0) {
			board.text = "You are shaven already"; 
		}

	}









	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
