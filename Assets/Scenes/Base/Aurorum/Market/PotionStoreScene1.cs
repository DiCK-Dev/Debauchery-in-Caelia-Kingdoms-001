using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PotionStoreScene1 : MonoBehaviour {
	public Text board; 
	int i;
	int x; 
	string line1;
	public RectTransform panEndTurn; 

	AddItemScript addItem = new AddItemScript();


	public void startText(){



		if (CityControl.city100Corruption < 50) {
			if (WorldControl.futaOn == true) {
				line1 = "You can see that in front of her thighs, a big bulge was pushing against her pants, threatening to rip them if it ever gets hard enough.";
			} else {
				line1 = "";
			}
			
			board.text = "As you enter the potion shop, you see that the place is organized, as most of the flasks in the shelves are labeled properly, but some of them have question marks, perhaps even she doesn’t know what they do. \n\nYou can see Elizabeth cleaning an empty bottle with a rag, her formal clothing having a hard time to contain her breasts, as if they were bigger than normal. A panther tail curled around her own waist, jiggling her ass as she continued her labour. "+  line1 +"\n\nWhen she sees you, she lets the bottle on the table and quickly returns to the counter. -Hey there. You came to buy a potion, or perhaps you came to help me with my experiments?-";


		} else {
			if (WorldControl.futaOn == true) {
				line1 = "Perhaps her bulge couldn’t be hid in that skimpy clothing, so she had her cock covered in a trouser, poking out from her short pants and moving freely as she walked.";
			} else {
				line1 = "";
			}


			board.text = "As you enter the potion shop, you see that the place has changed a bit. Now the place is messier than before, as some of the flasks lie broken on the floor, its contents spilled around. There are even some censers filled with strong scents that made your mind go numb for a second.\n\nYou see Elizabeth close to the counter, mixing a couple of liquids in another censer. Her clothing was a lot more revealing than before, as you now she that she sports a pair of short pants that highlight her ass, as her panther tail waved slowly from side to side. She now wears a tank top that reveals half of her ample pair of tits. " + line1 +"\n\nAs you approach her, she looks at you with a quirky smile. -My, my, my. You came for some flavor in your life, or perhaps would you like to try something spicy?- She said with a lustful smile on her face.";

		}

		if (CityControl.city100MarketMeet [1] == false) {
			CityControl.city100MarketMeet [1] = true;
			board.text = "As you enter the building, you see that the place has a lot of shelves full of flasks. The whole room smells like a mixture of different plants and extracts. You knock close to you, to let whoever runs the place that you entered, walking towards the counter. You heard a high pitched voice coming from the back store, but you couldn’t quite hear what she said. After half a minute, you see a barely 4 feet female panther coming out of the back door, a little agitated and wearing some clothing that doesn’t fit her at all, looking like a child wearing adult clothes. -I’m sorry. I got a little... wardrobe malfunction on my hands- \n\n-Hold on, this is a scientific matter!- And after saying that, she proceeded to drink a potion from one of her flasks, and you see how she starts to grow in height very fast, until she is around 4’7 feet tall, and with that change her clothing seems to fit almost perfectly now. -I’m doing some alchemic experiments in the Size Field. I think that I’m making some progress, but I’ve had my fair share of… setbacks. My name’s Elizabeth and welcome to the potion shop. You are not one of my usual clients…. Are you new in the city?- You nod at the answer. -That would be great news since the roads are in that state of disarray, no one travels here! I moved here shortly after the Plague started, trying to escape from it, and the situation around the city had only worsened since then… Not like that's my fault, mind you.-\n\nYou inform her that you are the new lord of the city and she looks at you with a smirk and clear skepticism in her face, a reaction that's been more common than what you wish. She notices your annoyance and quickly reacts to it, realizing that maybe being in the wrong side of the new lord may be not a good idea. -Oh darling, don’t take it personal, is just that the city is a mess since the Plague, and since the death of the late Lord no one has claimed such title, not even the big houses around. - She leans forward on the counter and gives you a good look from top to bottom, pausing in your more \"interesting\" parts. -Oh and don’t worry, I’m sure you’ll earn the respect of everyone around pretty soon....-\n\nYou ask her what kind of potions she sells in here. -Well, i’m good with the alchemy of transformation. I came here for a quiet place where I can continue my experiments… But I’m sure I can get you some potions that you can use to increase or decrease certain parts of your body. Want a pair of breasts that are the envy of everyone else? I can help you with that. Want a dick too packed that you’ll require a pair of new pants just to hold them in bay? I got a potion for that too. Those are the safe brewings that I can sell. I’m doing research on more potions, so come and visit from time to time, to see what I have tested enough for safe use and sale- She smiles and you notice how she kept growing through the whole conversation, and now now she is 5’2 feet tall, her clothing being too tight and kinda provocative now -But, being honest… Can you return in a hour or so? I need to stabilize my size and this clothing just won’t hold on enough- You sigh and nod, as she waves you goodbye with one hand and with the other she holds her clothing in place. \n";
			panEndTurn.SetAsLastSibling ();
		}

	}



	public void buyText()
	{
			board.text = "What you want to buy?";

	}



	/// <summary>
	/// ITEM 1
	/// </summary>
	public void buySlot1(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		while(i < 5)
		{
			while (x < 5) 
			{

				if (GameControl.invSlotArray[x,0] == 101) 
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

	
		if (WorldControl.stashFull == false && GameControl.charGold >= 30) {
			WorldControl.dropItem = 101; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 30; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 30) {
			board.text = "Your dont have enough gold!"; 
		}
			

	}


	/// <summary>
	/// ITEM 2
	/// </summary>

	public void buySlot2(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		while(i < 5)
		{
			while (x < 5) 
			{

				if (GameControl.invSlotArray[x,0] == 106) 
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


		if (WorldControl.stashFull == false && GameControl.charGold >= 30) {
			WorldControl.dropItem = 106; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 30; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 30) {
			board.text = "Your dont have enough gold!"; 
		}


	}

	/// <summary>
	/// ITEM 3
	/// </summary>

	public void buySlot3(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		while(i < 5)
		{
			while (x < 5) 
			{

				if (GameControl.invSlotArray[x,0] == 111) 
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


		if (WorldControl.stashFull == false && GameControl.charGold >= 25) {
			WorldControl.dropItem = 111; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 25; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 25) {
			board.text = "Your dont have enough gold!"; 
		}


	}


	/// <summary>
	/// ITEM 4
	/// </summary>

	public void buySlot4(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		while(i < 5)
		{
			while (x < 5) 
			{

				if (GameControl.invSlotArray[x,0] == 116) 
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


		if (WorldControl.stashFull == false && GameControl.charGold >= 30) {
			WorldControl.dropItem = 116; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 30; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 30) {
			board.text = "Your dont have enough gold!"; 
		}


	}



	/// <summary>
	/// ITEM 5
	/// </summary>

	public void buySlot5(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		while(i < 5)
		{
			while (x < 5) 
			{

				if (GameControl.invSlotArray[x,0] == 141) 
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


		if (WorldControl.stashFull == false && GameControl.charGold >= 30) {
			WorldControl.dropItem = 141; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 30; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 30) {
			board.text = "Your dont have enough gold!"; 
		}


	}





	/// <summary>
	/// ITEM 6
	/// </summary>

	public void buySlot6(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		while(i < 5)
		{
			while (x < 5) 
			{

				if (GameControl.invSlotArray[x,0] == 126) 
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


		if (WorldControl.stashFull == false && GameControl.charGold >= 30) {
			WorldControl.dropItem = 126; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 30; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 30) {
			board.text = "Your dont have enough gold!"; 
		}


	}

	/// <summary>
	/// ITEM 7
	/// </summary>

	public void buySlot7(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		while(i < 5)
		{
			while (x < 5) 
			{

				if (GameControl.invSlotArray[x,0] == 131) 
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


		if (WorldControl.stashFull == false && GameControl.charGold >= 30) {
			WorldControl.dropItem = 131; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 30; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 30) {
			board.text = "Your dont have enough gold!"; 
		}


	}


	/// <summary>
	/// ITEM 8
	/// </summary>

	public void buySlot8(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		while(i < 5)
		{
			while (x < 5) 
			{

				if (GameControl.invSlotArray[x,0] == 136) 
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


		if (WorldControl.stashFull == false && GameControl.charGold >= 25) {
			WorldControl.dropItem = 136; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 25; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 25) {
			board.text = "Your dont have enough gold!"; 
		}


	}


	/// <summary>
	/// ITEM 9
	/// </summary>

	public void buySlot9(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		while(i < 5)
		{
			while (x < 5) 
			{

				if (GameControl.invSlotArray[x,0] == 121) 
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


		if (WorldControl.stashFull == false && GameControl.charGold >= 30) {
			WorldControl.dropItem = 121; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 30; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 30) {
			board.text = "Your dont have enough gold!"; 
		}


	}



	/// <summary>
	/// ITEM 10
	/// </summary>

	public void buySlot10(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		while(i < 5)
		{
			while (x < 5) 
			{

				if (GameControl.invSlotArray[x,0] == 165) 
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


		if (WorldControl.stashFull == false && GameControl.charGold >= 100) {
			WorldControl.dropItem = 165; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 100; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 100) {
			board.text = "Your dont have enough gold!"; 
		}


	}

	/// <summary>
	/// ITEM 11
	/// </summary>

	public void buySlot11(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		while(i < 5)
		{
			while (x < 5) 
			{

				if (GameControl.invSlotArray[x,0] == 145) 
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


		if (WorldControl.stashFull == false && GameControl.charGold >= 100) {
			WorldControl.dropItem = 145; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 100; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 100) {
			board.text = "Your dont have enough gold!"; 
		}


	}


	/// <summary>
	/// ITEM 12
	/// </summary>

	public void buySlot12(){
		WorldControl.stashFull = true; 
		i = 0; 
		x = 0; 


		while(i < 5)
		{
			while (x < 5) 
			{

				if (GameControl.invSlotArray[x,0] == 146) 
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


		if (WorldControl.stashFull == false && GameControl.charGold >= 100) {
			WorldControl.dropItem = 146; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 100; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 100) {
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

				if (GameControl.invSlotArray[x,0] == 160) 
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


		if (WorldControl.stashFull == false && GameControl.charGold >= 20) {
			WorldControl.dropItem = 160; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 20; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 20) {
			board.text = "Your dont have enough gold!"; 
		}


	}












	void Awake () {
		WorldControl.location = "Aurorum - Potion store"; 
	}
	// Use this for initialization
	void Start () {
		startText ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
