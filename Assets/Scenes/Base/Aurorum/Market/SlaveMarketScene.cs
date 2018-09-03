using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SlaveMarketScene : MonoBehaviour {
	public Text Board; 
	int i;
	int x; 

	public RectTransform panEndTurn; 

	AddItemScript addItem = new AddItemScript();


	public void startText(){
		if (CityControl.city100Corruption < 50) {
			Board.text = "You can see that the slave market is having a little bit more flow of people than the usual. There were a lot of people getting in and out of the place, some of them with a slave or two walking beside them, with iron collars around their necks. The cages were clean and the people inside them were in good conditions. There was an auction of slaves next to them.\n\nYou can see Aurelia covered in rags, yet you can see her voluptuous body below them. She had a juicy pair of D-breasts and a nice and big piece of ass that was being barely covered by her clothing. She grooms herself a bit when she sees you. -Nice to see you around here! You came here for something in specific, or perhaps you saw something else you like? Any of those has a price, of course- She says with a smile on her face.\n";
		} else {
			Board.text = "The slave market is having more people than the usual. They were a lot of people coming in and out of the place, and some of them had a slave walking next to them, with a leather collar on their necks. As you approached the place, you saw a couple of naked slaves with a lust-gaze on their faces, placed in stocks with a sign above them with the text: “Public Demonstration”.\n\nYou can see Aurelia displaying a new revealing dress that left nothing to the imagination. Her plushy D-breasts were pridefully displayed for everyone to see them, as her round ass was bouncing a bit behind her. She almost jumps at you when she sees you. -Hello there, wealthsome. You know on what to spend your money today, or do you want to spend it on me? I’ll cut the price in half, if you need some incentive...- She says, playing with her lower lip for a second.";

		}

		if (CityControl.city100MarketMeet [5] == false) {
			CityControl.city100MarketMeet [5] = true; 
			Board.text = "As you get into the grounds of the Slave Market, you can see that the place is almost empty, saving from the people attending the place. The place has big and long cage that is half full of Lost people. In front of it, there’s a platform where a female woman with bird features is stationed. She is arguing with another person in a strange language. She has a couple of black feathers ruffling from her shoulders, as the man finally decides to leave, probably saying a lot of profanities while doing so.\n\nYou walk upstairs and approach her, and when she sees you walking in her direction she flattens her feathers and takes a step towards you. -I’m sorry you had to see that. Some people think that they can come here and buy cheap just because they are Lost- She crosses her arms as she look at the man moving away from her sight. After that she sighs and looks at you. -My name is Aurelia. I’m the one in charge of this place, and I am well aware of who are you, Lord, since gossip moves fast around the black market.-\n\nYou asked her for that word you heard: “Lost”. -You don't know about the Plague?- She smiles then points at the cage. -The people of weak soul end up broken, and those are beyond salvation, but we are a civilized city and we rather give them a purpose other than being dead.- She points at the slaves in the cage: All of them were silent and looking at everyone who would go too close. Some of them acted completely like animals. -We call them Lost. And that’s why they are there. They aren’t capable of taking care of themselves. So we can get a coin for the transaction and they get a place to rest and be taken care of. Everyone wins!-\n\n-Well, to tell you the truth, we used to kill them on sight, but since the city is almost depopulated we have to use them to get our economy going. Problem is, almost no one dares to go and capture them anymore, too dangerous… But I heard you are a capable fighter, and it’s likely that hunters, whatever you like it or not, will follow you from a distance waiting to pick anything you beat into submission to bring here. Don’t worry, if we get a good supply of slaves the city will improve and people will be able to pay more taxes, so once more everyone wins!.-\n\nAfter that you hear that the man returns, with the same bad mood than before. -Can you return in an hour or so? I got some subjects to argue with this man- She walks toward the man and start gawking in that strange language once more. So, you decided that it was a good time to walk away from the slave market.";
			panEndTurn.SetAsLastSibling ();
		}

	}



	public void buyText()
	{
		Board.text = "What you want to buy?";

	}



	/// <summary>
	/// ITEM 1
	/// </summary>
	/// Corruption elixir
	public void buyElixir1(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		while(i < 5)
		{
			while (x < 5) 
			{

				if (GameControl.invSlotArray[x,0] == 151) 
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


		if (WorldControl.stashFull == false && GameControl.charGold >= 500) {
			WorldControl.dropItem = 151; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 500; 
			Board.text = "Your purchase is successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			Board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 500) {
			Board.text = "Your dont have enough gold!"; 
		}


	}


	/// <summary>
	/// ITEM 2
	/// </summary>
	/// Purity elixir

	public void buyElixir2(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		while(i < 5)
		{
			while (x < 5) 
			{

				if (GameControl.invSlotArray[x,0] == 156) 
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


		if (WorldControl.stashFull == false && GameControl.charGold >= 500) {
			WorldControl.dropItem = 156; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 500; 
			Board.text = "Your purchase is successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			Board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 500) {
			Board.text = "Your dont have enough gold!"; 
		}


	}

	/// <summary>
	/// ITEM 3
	/// </summary>

	public void buySlavePot1(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 

		if (CityControl.city100Slaves[0] >= 5) {
			while (i < 5) {
				while (x < 5) {

					if (GameControl.invSlotArray [x, 0] == 1000) {
						if (GameControl.invSlotArray [x, 1] < 5) {
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


			if (WorldControl.stashFull == false && GameControl.charGold >= 40) {
				WorldControl.dropItem = 1000; 
				addItem.addItemScript ();
				GameControl.charGold = GameControl.charGold - 40; 
				Board.text = "Your purchase is successful!"; 

			} else if (WorldControl.stashFull == true) {
				Board.text = "Your inventory is full!"; 
			} else if (GameControl.charGold < 40) {
				Board.text = "Your dont have enough gold!"; 
			}

		} else {

			Board.text = "You need to beat at least 5 rabbit-girls in the forest!"; 
		}
	}


	/// <summary>
	/// ITEM 4
	/// </summary>


	public void buySlavePot2(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		if (CityControl.city100Slaves[0] >= 5) {
			while (i < 5) {
				while (x < 5) {

					if (GameControl.invSlotArray [x, 0] == 1004) {
						if (GameControl.invSlotArray [x, 1] < 5) {
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


			if (WorldControl.stashFull == false && GameControl.charGold >= 40) {
				WorldControl.dropItem = 1004; 
				addItem.addItemScript ();
				GameControl.charGold = GameControl.charGold - 40; 
				Board.text = "Your purchase is successful!"; 

			} else if (WorldControl.stashFull == true) {
				Board.text = "Your inventory is full!"; 
			} else if (GameControl.charGold < 40) {
				Board.text = "Your dont have enough gold!"; 
			}

		} else {
			Board.text = "You need to beat at least 5 rabbit-girls in the forest!"; 
		}
	}



	/// <summary>
	/// ITEM 5
	/// </summary>

	public void buySlavePot3(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 

		if (CityControl.city100Slaves[1] >= 5) {
			while (i < 5) {
				while (x < 5) {

					if (GameControl.invSlotArray [x, 0] == 1005) {
						if (GameControl.invSlotArray [x, 1] < 5) {
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


			if (WorldControl.stashFull == false && GameControl.charGold >= 40) {
				WorldControl.dropItem = 1005; 
				addItem.addItemScript ();
				GameControl.charGold = GameControl.charGold - 40; 
				Board.text = "Your purchase is successful!"; 

			} else if (WorldControl.stashFull == true) {
				Board.text = "Your inventory is full!"; 
			} else if (GameControl.charGold < 40) {
				Board.text = "Your dont have enough gold!"; 
			}

		} else {
			Board.text = "You need to defeat 5 werewolfs in the forest before being able to buy this potion!";
		}
	}





	/// <summary>
	/// ITEM 6
	/// </summary>

	public void buySlavePot4(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 

		if (CityControl.city100Slaves[1] >= 5) {
			while (i < 5) {
				while (x < 5) {

					if (GameControl.invSlotArray [x, 0] == 1009) {
						if (GameControl.invSlotArray [x, 1] < 5) {
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


			if (WorldControl.stashFull == false && GameControl.charGold >= 40) {
				WorldControl.dropItem = 1009; 
				addItem.addItemScript ();
				GameControl.charGold = GameControl.charGold - 40; 
				Board.text = "Your purchase is successful!"; 

			} else if (WorldControl.stashFull == true) {
				Board.text = "Your inventory is full!"; 
			} else if (GameControl.charGold < 40) {
				Board.text = "Your dont have enough gold!"; 
			}

		} else {
			Board.text = "You need to defeat 5 werewolfs in the forest before being able to buy this potion!";
		}
	}

	/// <summary>
	/// ITEM 7
	/// </summary>

	public void buySlavePot5(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 

		if (CityControl.city100Slaves[2] >= 5) {
			while (i < 5) {
				while (x < 5) {

					if (GameControl.invSlotArray [x, 0] == 1010) {
						if (GameControl.invSlotArray [x, 1] < 5) {
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


			if (WorldControl.stashFull == false && GameControl.charGold >= 40) {
				WorldControl.dropItem = 1010; 
				addItem.addItemScript ();
				GameControl.charGold = GameControl.charGold - 40; 
				Board.text = "Your purchase is successful!"; 

			} else if (WorldControl.stashFull == true) {
				Board.text = "Your inventory is full!"; 
			} else if (GameControl.charGold < 40) {
				Board.text = "Your dont have enough gold!"; 
			}
		} else {
			Board.text = "You need to defeat 5 plant-girls in the forest before being able to buy this potion!";
		}

	}


	/// <summary>
	/// ITEM 8
	/// </summary>

	public void buySlavePot6(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 

		if (CityControl.city100Slaves[2] >= 5) {
			while (i < 5) {
				while (x < 5) {

					if (GameControl.invSlotArray [x, 0] == 1014) {
						if (GameControl.invSlotArray [x, 1] < 5) {
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


			if (WorldControl.stashFull == false && GameControl.charGold >= 40) {
				WorldControl.dropItem = 1014; 
				addItem.addItemScript ();
				GameControl.charGold = GameControl.charGold - 40; 
				Board.text = "Your purchase is successful!"; 

			} else if (WorldControl.stashFull == true) {
				Board.text = "Your inventory is full!"; 
			} else if (GameControl.charGold < 40) {
				Board.text = "Your dont have enough gold!"; 
			}
		} else {
			Board.text = "You need to defeat 5 plant-girls in the forest before being able to buy this potion!";
		}


	}


	/// <summary>
	/// ITEM 9
	/// </summary>

	public void buySlavePot7(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		while(i < 5)
		{
			while (x < 5) 
			{

				if (GameControl.invSlotArray[x,0] == 1015) 
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


		if (WorldControl.stashFull == false && GameControl.charGold >= 40) {
			WorldControl.dropItem = 1015; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 40; 
			Board.text = "Your purchase is successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			Board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 40) {
			Board.text = "Your dont have enough gold!"; 
		}


	}



	/// <summary>
	/// ITEM 10
	/// </summary>

	public void buySlavePot8(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		while(i < 5)
		{
			while (x < 5) 
			{

				if (GameControl.invSlotArray[x,0] == 1019) 
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


		if (WorldControl.stashFull == false && GameControl.charGold >= 40) {
			WorldControl.dropItem = 1019; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 40; 
			Board.text = "Your purchase is successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			Board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 40) {
			Board.text = "Your dont have enough gold!"; 
		}


	}

	/// <summary>
	/// ITEM 11
	/// </summary>

	public void buySlavePot9(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 

		if (CityControl.city100Slaves[3] >= 5) {
			while (i < 5) {
				while (x < 5) {

					if (GameControl.invSlotArray [x, 0] == 1020) {
						if (GameControl.invSlotArray [x, 1] < 5) {
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


			if (WorldControl.stashFull == false && GameControl.charGold >= 40) {
				WorldControl.dropItem = 1020; 
				addItem.addItemScript ();
				GameControl.charGold = GameControl.charGold - 40; 
				Board.text = "Your purchase is successful!"; 

			} else if (WorldControl.stashFull == true) {
				Board.text = "Your inventory is full!"; 
			} else if (GameControl.charGold < 40) {
				Board.text = "Your dont have enough gold!"; 
			}

		} else {
			Board.text = "You need to defeat 5 equine's in the forest before being able to buy this potion!";
		}

	}


	/// <summary>
	/// ITEM 12
	/// </summary>

	public void buySlavePot10(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		if (CityControl.city100Slaves[3] >= 5) {
			while (i < 5) {
				while (x < 5) {

					if (GameControl.invSlotArray [x, 0] == 1024) {
						if (GameControl.invSlotArray [x, 1] < 5) {
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


			if (WorldControl.stashFull == false && GameControl.charGold >= 40) {
				WorldControl.dropItem = 1024; 
				addItem.addItemScript ();
				GameControl.charGold = GameControl.charGold - 40; 
				Board.text = "Your purchase is successful!"; 

			} else if (WorldControl.stashFull == true) {
				Board.text = "Your inventory is full!"; 
			} else if (GameControl.charGold < 40) {
				Board.text = "Your dont have enough gold!"; 
			}
		} else {
			Board.text = "You need to defeat 5 equine's in the forest before being able to buy this potion!";
		}


	}


	/// <summary>
	/// ITEM 11
	/// </summary>

	public void buySlavePot11(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 

		if (CityControl.city100Slaves[4] >= 5) {

			while (i < 5) {
				while (x < 5) {

					if (GameControl.invSlotArray [x, 0] == 1025) {
						if (GameControl.invSlotArray [x, 1] < 5) {
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


			if (WorldControl.stashFull == false && GameControl.charGold >= 40) {
				WorldControl.dropItem = 1025; 
				addItem.addItemScript ();
				GameControl.charGold = GameControl.charGold - 40; 
				Board.text = "Your purchase is successful!"; 

			} else if (WorldControl.stashFull == true) {
				Board.text = "Your inventory is full!"; 
			} else if (GameControl.charGold < 40) {
				Board.text = "Your dont have enough gold!"; 
			}
		} else {
			Board.text = "You need to defeat 5 dodo girls in the forest before being able to buy this potion!";
		}


	}

	/// <summary>
	/// ITEM 12
	/// </summary>

	public void buySlavePot12(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 

		if (CityControl.city100Slaves[4] >= 5) {

			while (i < 5) {
				while (x < 5) {

					if (GameControl.invSlotArray [x, 0] == 1029) {
						if (GameControl.invSlotArray [x, 1] < 5) {
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


			if (WorldControl.stashFull == false && GameControl.charGold >= 40) {
				WorldControl.dropItem = 1029; 
				addItem.addItemScript ();
				GameControl.charGold = GameControl.charGold - 40; 
				Board.text = "Your purchase is successful!"; 

			} else if (WorldControl.stashFull == true) {
				Board.text = "Your inventory is full!"; 
			} else if (GameControl.charGold < 40) {
				Board.text = "Your dont have enough gold!"; 
			}
		} else {
			Board.text = "You need to defeat 5 dodo girls in the forest before being able to buy this potion!";
		}


	}

	/// <summary>
	/// ITEM 11
	/// </summary>

	public void buySlavePot13(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		while(i < 5)
		{
			while (x < 5) 
			{

				if (GameControl.invSlotArray[x,0] == 1030) 
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


		if (WorldControl.stashFull == false && GameControl.charGold >= 40) {
			WorldControl.dropItem = 1030; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 40; 
			Board.text = "Your purchase is successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			Board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 40) {
			Board.text = "Your dont have enough gold!"; 
		}


	}

	/// <summary>
	/// ITEM 11
	/// </summary>

	public void buySlavePot14(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		while(i < 5)
		{
			while (x < 5) 
			{

				if (GameControl.invSlotArray[x,0] == 1034) 
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


		if (WorldControl.stashFull == false && GameControl.charGold >= 40) {
			WorldControl.dropItem = 1034; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 40; 
			Board.text = "Your purchase is successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			Board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 40) {
			Board.text = "Your dont have enough gold!"; 
		}


	}

	/// <summary>
	/// ITEM 11
	/// </summary>

	public void buySlavePot15(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		while(i < 5)
		{
			while (x < 5) 
			{

				if (GameControl.invSlotArray[x,0] == 1035) 
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


		if (WorldControl.stashFull == false && GameControl.charGold >= 40) {
			WorldControl.dropItem = 1035; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 40; 
			Board.text = "Your purchase is successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			Board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 40) {
			Board.text = "Your dont have enough gold!"; 
		}


	}


	/// <summary>
	/// ITEM 11
	/// </summary>

	public void buySlavePot16(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		while(i < 5)
		{
			while (x < 5) 
			{

				if (GameControl.invSlotArray[x,0] == 1039) 
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


		if (WorldControl.stashFull == false && GameControl.charGold >= 40) {
			WorldControl.dropItem = 1039; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 40; 
			Board.text = "Your purchase is successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			Board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 40) {
			Board.text = "Your dont have enough gold!"; 
		}


	}


	/// <summary>
	/// ITEM 11
	/// </summary>

	public void buySlavePot17(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		while(i < 5)
		{
			while (x < 5) 
			{

				if (GameControl.invSlotArray[x,0] == 1040) 
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


		if (WorldControl.stashFull == false && GameControl.charGold >= 40) {
			WorldControl.dropItem = 1040; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 40; 
			Board.text = "Your purchase is successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			Board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 40) {
			Board.text = "Your dont have enough gold!"; 
		}


	}

	/// <summary>
	/// ITEM 11
	/// </summary>

	public void buySlavePot18(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		while(i < 5)
		{
			while (x < 5) 
			{

				if (GameControl.invSlotArray[x,0] == 1044) 
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


		if (WorldControl.stashFull == false && GameControl.charGold >= 40) {
			WorldControl.dropItem = 1044; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 40; 
			Board.text = "Your purchase is successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			Board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 40) {
			Board.text = "Your dont have enough gold!"; 
		}


	}










	/// <summary>
	/// ITEM 1 veil 
	/// </summary>

	public void buyWeapon1(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 350) {
			WorldControl.dropItem = 10003; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 40; 
			Board.text = "Your purchase is successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			Board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 40) {
			Board.text = "Your dont have enough gold!"; 
		}


	}


	/// <summary>
	/// ITEM 2 Lustick
	/// </summary>

	public void buyWeapon2(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 350) {
			WorldControl.dropItem = 10005; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 350; 
			Board.text = "Your purchase is successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			Board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 350) {
			Board.text = "Your dont have enough gold!"; 
		}


	}

	/// <summary>
	/// ITEM 3
	/// </summary>

	public void buyWeapon3(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 40) {
			WorldControl.dropItem = 10006; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 40; 
			Board.text = "Your purchase is successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			Board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 40) {
			Board.text = "Your dont have enough gold!"; 
		}


	}



	public void textSlavePotions (){
		Board.text = "You visit the personal stash of Aurelia, attended by one of her girls. Here you can see that there are several potions available to transform yourself, extracted from the enemies that you had beaten and had been captured so far, and at the affordable price of 10 gold each! Most of them require " +
			"you to fight and beat an enemy 5 times, but since not every type of enemy is available yet some of them are unlocked from the start, enjoy!\n\nThe price of any bottle is 40 G!"; 

	}
	public void textElixirsPotion (){
		Board.text = "At the end of the market there is a dark alley where you can find a pretty suspicious figure covered by shadows. When you get close the person it doesn't says a word, but shows you a couple of very small bottles, both emanating strong and contradictory sensations. These elixir's are pretty strong, and can be required to either corrupt or purify your followers, or for your own consumption. Since the are very rare to find, their cost is 500 gold each!"; 

	}
	public void textExoticWeapons (){
		Board.text = "You see a very small closed tent that uses purple courtains at its entrance. You enter the place and your nostrils are invaded by the sweet scent of incense. " +
			"The place have only a couple of items at display, and its owner tells you that these are pretty exotic weapons. At simple sight, they may just look like regular items, but they are done with alchemy to be extra durable, and to be used for combat. " +
			"\n\nAny of them costs 350, and they both also increase the effect of your seductive skills sligthly!"; 

	}
	public void textTradingPost (){
		Board.text = "You can find at the center of the market a big, open tent that is buzzing with activity. Here you can see most of the merchants and store owners of the city trading with apparently" +
			" the only crew that dares to travel to this city to supply it with regularity... and no wonder! They get to sell as pretty much everything they got, and to buy everything the city produces! " +
			"As you get close to their wares they just tell you that they only sell in bulk and to the stores in the city, so you need to go to their stores and buy from them, otherwise they would bankrupt, but " +
			"they are still eager to buy anything you want to throw at them at half of its market value, which is more than anyone else in the city would dare to pay anyway."; 
	}


	public void textYouSure(){
		Board.text = "Are you sure you want to sell this?"; 
	}
	public void textYouSureAll(){
		Board.text = "Are you sure you want to sell everything in your inventory?"; 
	}




	void Awake () {
		WorldControl.location = "Aurorum - Slave market"; 
	}
	// Use this for initialization
	void Start () {
		startText ();
	}

	// Update is called once per frame
	void Update () {

	}
}
