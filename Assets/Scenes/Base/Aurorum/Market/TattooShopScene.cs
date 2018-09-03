using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TattooShopScene : MonoBehaviour {
	public Text board; 
	int i;
	int x; 
	AddItemScript addItem = new AddItemScript();

	CharacteristicsSettler charSettler = new CharacteristicsSettler();

	public void startText(){
		if (CityControl.city100Corruption < 50) {
			board.text = "";
		} else {
			board.text = "";

		}
		if (CityControl.city100MarketMeet [6] == false) {
			board.text = "You can see that there is a very bored, rude and generic human attending the place. You immediately think that you need to change her for someone else, but the problem is to find that person first";
		}
	}



	public void buyText()
	{
		board.text = "You can see in a poster the prices:\n\nHaircut: 25 G.\nShave or beard change: 25 G.\nHair color: 25 G.\nEye color change: 50 G.\nHair treatments: 30 G.\nBeard treatment: 10 G. ";

	}


	/// <summary>
	/// Hairstyle 1  
	/// </summary>
	// LAGANA

	/*
	public void buyHairStyle1(){


		if (GameControl.charGold >= 200) {

			GameControl.charGold = GameControl.charGold - 200; 
			board.text = "You just bought this item!";
			GameControl.hairStyle = 0; 
		} else if (GameControl.charGold < 200) {
			board.text = "Your dont have enough gold!"; 
		}


	}*/

	/// <summary>
	/// Beardstyle 1
	/// </summary>
	// LAGANA
	public void buyBeardStyle1(){


		if (GameControl.charGold >= 200) {

			GameControl.charGold = GameControl.charGold - 200; 
			board.text = "You just bought this item!";
			GameControl.mcBeardStyle = 0; 
		} else if (GameControl.charGold < 200) {
			board.text = "Your dont have enough gold!"; 
		}
			
	}

	/// <summary>
	/// Hair length
	/// </summary>
	// LAGANA
	public void buyHairLength(){


		if (GameControl.charGold >= 200) {

			GameControl.charGold = GameControl.charGold - 200; 
			board.text = "You just bought this item!";
			GameControl.hairLength = GameControl.hairLength + 5;
		} else if (GameControl.charGold < 200) {
			board.text = "Your dont have enough gold!"; 
		}

	}



	/// <summary>
	/// Armour 1
	/// </summary>

	public void buyArmor1(){
		WorldControl.stashFull = true; 
		i = 0; 

		while (i < 5) 
		{
			if (GameControl.invSlotArray [i, 0] == 0) {
				WorldControl.stashFull = false; 
				break; 
			}

			i++;
		}




		if (WorldControl.stashFull == false && GameControl.charGold >= 200) {
			WorldControl.dropItem = 20001; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 200; 
			board.text = "You just bought this item! you have this in slot 0,0: " + GameControl.invSlotArray[0,0] + " and this quantity in 0, 1: " + GameControl.invSlotArray[0,1]  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 200) {
			board.text = "Your dont have enough gold!"; 
		}


	}


	/// <summary>
	/// ITEM 13
	/// </summary>

	public void buySlot13(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		while(i < 5)
		{
			while (x < 5) 
			{

				if (GameControl.invSlotArray[x,0] == 100) 
				{
					if (GameControl.invSlotArray [x, 1] < 5) 
					{
						WorldControl.stashFull = false; 
						break; 
					}
				}

				x++; 

			}
			x = 0; 
			i++;
			if (WorldControl.stashFull == false) {
				break; 
			}
		}

		i = 0; 

		if (WorldControl.stashFull == true) {
			while (i < 5) {
				if (GameControl.invSlotArray [i, 0] == 0) {
					WorldControl.stashFull = false; 
					break; 
				}

				i++;
			}

		}


		if (WorldControl.stashFull == false && GameControl.charGold >= 200) {
			WorldControl.dropItem = 100; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 200; 
			board.text = "You just bought this item! you have this in slot 0,0: " + GameControl.invSlotArray[0,0] + " and this quantity in 0, 1: " + GameControl.invSlotArray[0,1]  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 200) {
			board.text = "Your dont have enough gold!"; 
		}


	}












	void Awake () {
		WorldControl.location = "Aurorum - Fashion salon"; 
	}
	// Use this for initialization
	void Start () {
		startText ();
	}

	// Update is called once per frame
	void Update () {

	}



}
