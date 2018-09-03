using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BeardStyle : MonoBehaviour {
	public Text board; 
	CharacteristicsSettler charSettler = new CharacteristicsSettler();


	/// <summary>
	/// Beard
	/// </summary>
	public void buyBeardStyle1(){


		if (GameControl.charGold >= 25) {

			GameControl.charGold = GameControl.charGold - 25; 
			board.text = "You just bought this item!";
			GameControl.mcBeardStyle = 0; 
			//GameControl.beardLength = 0; 
		//	//charSettler.setBeard ();
		} else if (GameControl.charGold < 25) {
			board.text = "Your dont have enough gold!"; 
		}


	}
	/// <summary>
	/// Beard
	/// </summary>
	public void buyBeardStyle2(){


		if (GameControl.charGold >= 25) {

			GameControl.charGold = GameControl.charGold - 25; 
			board.text = "You just bought this item!";
			GameControl.mcBeardStyle = GameControl.MCBeardStyle.ChinCurtain; 
		} else if (GameControl.charGold < 25) {
			board.text = "Your dont have enough gold!"; 
		}


	}
	/// <summary>
	/// Beard
	/// </summary>
	public void buyBeardStyle3(){


		if (GameControl.charGold >= 25) {

			GameControl.charGold = GameControl.charGold - 25; 
			board.text = "You just bought this item!";
			GameControl.mcBeardStyle =  GameControl.MCBeardStyle.NONE; 
		} else if (GameControl.charGold < 25) {
			board.text = "Your dont have enough gold!"; 
		}


	}
	/// <summary>
	/// Beard
	/// </summary>
	public void buyBeardStyle4(){


		if (GameControl.charGold >= 25) {

			GameControl.charGold = GameControl.charGold - 25; 
			board.text = "You just bought this item!";
			GameControl.mcBeardStyle =  GameControl.MCBeardStyle.NONE; 
		} else if (GameControl.charGold < 25) {
			board.text = "Your dont have enough gold!"; 
		}


	}
	/// <summary>
	/// Beard
	/// </summary>
	public void buyBeardStyle5(){


		if (GameControl.charGold >= 25) {

			GameControl.charGold = GameControl.charGold - 25; 
			board.text = "You just bought this item!";
			GameControl.mcBeardStyle =  GameControl.MCBeardStyle.NONE; 
		} else if (GameControl.charGold < 25) {
			board.text = "Your dont have enough gold!"; 
		}


	}
	/// <summary>
	/// Beard
	/// </summary>
	public void buyBeardStyle6(){


		if (GameControl.charGold >= 25) {

			GameControl.charGold = GameControl.charGold - 25; 
			board.text = "You just bought this item!";
			GameControl.mcBeardStyle = 0; 
		} else if (GameControl.charGold < 25) {
			board.text = "Your dont have enough gold!"; 
		}


	}
	/// <summary>
	/// Beard
	/// </summary>
	public void buyBeardStyle7(){


		if (GameControl.charGold >= 25) {

			GameControl.charGold = GameControl.charGold - 25; 
			board.text = "You just bought this item!";
			GameControl.mcBeardStyle = 0; 
		} else if (GameControl.charGold < 25) {
			board.text = "Your dont have enough gold!"; 
		}


	}
	/// <summary>
	/// Beard
	/// </summary>
	public void buyBeardStyle8(){


		if (GameControl.charGold >= 25) {

			GameControl.charGold = GameControl.charGold - 25; 
			board.text = "You just bought this item!";
			GameControl.mcBeardStyle = 0; 
		} else if (GameControl.charGold < 25) {
			board.text = "Your dont have enough gold!"; 
		}


	}
	/// <summary>
	/// Beard
	/// </summary>
	public void buyBeardStyle9(){


		if (GameControl.charGold >= 25) {

			GameControl.charGold = GameControl.charGold - 25; 
			board.text = "You just bought this item!";
			GameControl.mcBeardStyle = 0; 
		} else if (GameControl.charGold < 25) {
			board.text = "Your dont have enough gold!"; 
		}


	}
	/// <summary>
	/// Beard
	/// </summary>
	public void buyBeardStyle10(){


		if (GameControl.charGold >= 25) {

			GameControl.charGold = GameControl.charGold - 25; 
			board.text = "You just bought this item!";
			GameControl.mcBeardStyle = 0; 
		} else if (GameControl.charGold < 25) {
			board.text = "Your dont have enough gold!"; 
		}


	}
	/// <summary>
	/// Beard
	/// </summary>
	public void buyBeardStyle11(){


		if (GameControl.charGold >= 25) {

			GameControl.charGold = GameControl.charGold - 25; 
			board.text = "You just bought this item!";
			GameControl.mcBeardStyle = 0; 
		} else if (GameControl.charGold < 25) {
			board.text = "Your dont have enough gold!"; 
		}


	}
	/// <summary>
	/// Beard
	/// </summary>
	public void buyBeardStyle12(){


		if (GameControl.charGold >= 25) {

			GameControl.charGold = GameControl.charGold - 25; 
			board.text = "You just bought this item!";
			GameControl.mcBeardStyle = 0; 
		} else if (GameControl.charGold < 25) {
			board.text = "Your dont have enough gold!"; 
		}


	}
	/// <summary>
	/// Beard
	/// </summary>
	public void buyBeardStyle13(){


		if (GameControl.charGold >= 25) {

			GameControl.charGold = GameControl.charGold - 25; 
			board.text = "You just bought this item!";
			GameControl.mcBeardStyle = 0; 
		} else if (GameControl.charGold < 25) {
			board.text = "Your dont have enough gold!"; 
		}


	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
