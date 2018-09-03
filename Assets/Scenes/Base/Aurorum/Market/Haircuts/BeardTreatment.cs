using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class BeardTreatment : MonoBehaviour {
	public Text board; 
	CharacteristicsSettler charSettler = new CharacteristicsSettler();




	/// <summary>
	/// Color
	/// </summary>
	public void buyBeardDontGrow(){

		/*
		if (GameControl.charGold >= 10 && GameControl.beardGrow == true) {
			GameControl.beardGrow = false; 
			GameControl.charGold = GameControl.charGold - 10; 
			board.text = "You just bought this item!";
		} else if (GameControl.charGold < 10) {
			board.text = "Your dont have enough gold!"; 
		} else if (GameControl.beardGrow == false) {
			board.text = "Your beard isnt growing already!"; 
		}*/


	}

	/// <summary>
	/// Color
	/// </summary>	
	public void buyBeardGrow(){

	/*
		if (GameControl.charGold >= 10 && GameControl.beardGrow == false) {
			GameControl.beardGrow = true;
			GameControl.charGold = GameControl.charGold - 10; 
			board.text = "You just bought this item!";
		} else if (GameControl.charGold < 10) {
			board.text = "Your dont have enough gold!"; 
		} else if (GameControl.beardGrow== true) {
			board.text = "Your beard is growing already!"; 
		}*/
			
	}


	/// <summary>
	/// Color
	/// </summary>	
	/// /*
	/*public void buyIncreaseLengthBeard(){


		if (GameControl.charGold >= 10 && GameControl.beardLength < 80) {
			//GameControl.beardLength = GameControl.beardLength + 3; 
			//charSettler.setBeard ();
			GameControl.charGold = GameControl.charGold - 10; 
			board.text = "You just bought this item!";
		} else if (GameControl.charGold < 10) {
			board.text = "Your dont have enough gold!"; 
		} else if (GameControl.beardLength >= 0) {
			board.text = "Your beard is as long as it can be!"; 
		}

	}
	*/

	/// <summary>
	/// Color
	/// </summary>	
	/*
	public void buyReduceLengthBeard(){


		if (GameControl.charGold >= 20 && GameControl.beardLength > 0) {
			//GameControl.beardLength = GameControl.beardLength - 3; 
			//charSettler.setBeard ();
			if (GameControl.beardLength <= 0) {
				GameControl.mcBeardStyle = 0; 
			}
			GameControl.charGold = GameControl.charGold - 20; 
			board.text = "You just bought this item!";
		} else if (GameControl.charGold < 20) {
			board.text = "Your dont have enough gold!"; 
		} else if (GameControl.beardLength <= 0) {
			board.text = "You are shaven already"; 
		}

	}
*/

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
