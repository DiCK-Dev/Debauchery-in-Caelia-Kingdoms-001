using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TailorScene : MonoBehaviour {
	public Text board; 
	int i;
	int x; 

	public RectTransform panEndTurn;

	public RectTransform panFlirt; 
	AddItemScript addItem = new AddItemScript();


	public void startText(){
		if (GameControl.charArmorTags [1] == true && GameControl.charArmorTags [2] == true) {
			if (CityControl.city100Corruption < 50) {
				board.text = "The tailor is in good conditions. You can see that the place is full of mannequins that were showing several types of clothings, from formal to suggestive. The place has been cleaned up a little.\n\nYou discern Leontia talking with a human female and pointing out some things in the back of the store. You can see that her petite body hasn’t changed since the last time you see her. You see her slender legs poking out of a pair of very small shorts. When she sees you, she says one final word to what seemed to be her assistant and dismisses her.\n\nShe walks towards you but she stops when she sees what you’re wearing, her jaw almost dropping as she darts quite close to you but without touching your exposed skin, but you can see in her eyes that it isn’t for the lack of desire. <i>“It’s an armor, but it looks like fine silk. This is truly a fine piece of wearing,”</i> she says, before noticing her impertinence, walking back and apologizing. <i>”I’m sorry, my Liege. But every time I see something so well-made over someone as enticing… I mean, I can’t control myself… H-How can I help you?,”</i> she says as she tries to avoid looking at your exhibited skin too much.";
			} else {
				board.text = "The tailor has been changing just a bit. You can see that the place is full of mannequins that are displaying several sets of clothing, but you can see that now most of them are quite skimpy or at least sexy, while their poses are suggestive to say the least.\n\nWhen the small goat sees you, you can see her walking with a tone of confidence, in your direction. Her small body is still petite, but alluring in a sort of way. Her way of walking is completely different from what you remember of the first time you saw her.\n\nWhen she sees that you’re wearing that armor, she smiles mischievously. <i>”Such exposing clothing, wrapped in such a beautiful person”</i> she says as she takes a small walk around you, as if she were inspecting that armor, but you can feel her eyes over all your naughty bits. <i>”If you want a spare, I can find you something. But being honest, your exposed skin look just as good as anything that is inside this store,”</i> she says as she waits for your answer.\n";
			}



		} else {


			if (CityControl.city100Corruption < 50) {
				board.text = "The tailor is in good conditions. You can see that the place is full of mannequins that were showing several types of clothings, from formal to suggestive. The place has been cleaned up a little.\n\n\nYou can see Leontia talking with a human female and pointing out some things in the back of the store. You can see that her petite body hasn’t changed since the last time you see her. You see her slender legs poking out of a pair of very small shorts. When she sees you, she says one final word to what seemed to be her assistant and dismissed her.\n\n\nShe walks towards you with a smile on her face. -Good to see you! Have you come to see some of the fine clothing i have for sale, or for something else?-\n";
			} else {
				board.text = "The tailor has been changing just a bit. You can see that the place is full of mannequins that were displaying several sets of clothing, but you can see that now most of them are quite skimpy or at least sexy, while their pose is suggestive to say the least.\n\n\nWhen the small goat sees you, you can see her walking with a tone of confidence, in your direction. Her small body is still petite, but alluring in a sort of way. Her way of walking was completely different from what you remember of the first time you saw her.\n\n\n-It's nice to see you around!- She lets out a mischievous smile. -Are you here to get some sexy clothes that nice body of yours, or perhaps to get your clothings off of you...-";

			}


		}


		if (CityControl.city100MarketMeet [2] == false) {
			board.text = "The tailor building is the most normal of the buildings in the commercial district, as the only thing that differentiate it from the others is the small sign that says “Tailor” at the entrance. A scream of frustration could be heard from the inside, something that hurried you to enter. The place is tidy enough, but seems that the higher parts of the building were full of dust.\n\n\nAs you approach the origin of the sound, you find out a small female ripping apart a length of red fabric with its own hands as she lets out several sounds of frustration. She starts getting tangled with the shreds of red clothing. -WHY - I - CAN’T - DO IT?-  After that, you knocked a couple of times the wall next to you, so she could notice your presence. When she turns to see you, her face almost falls off in fear. -Nononononono- She started picking up the mess she just did. but you decide to help her a bit.\n\n\n-I’m sorry you had to look at this. My name is Leontia- She places the shreds into a bin on the side of the store. -I’m just getting used to the tailoring once more. Since the transformation, it has been harder for me to do it- You take a good look at her. She is almost like a petite human female, but she has a pair of horns coming out of her head, her legs were also monster in appearance and her hands were also covered in fur. -Four fingers... That’s the problem-\n\n\nAfter that, she returns to the desk that was close to them. -But don’t worry. I can tailor just fine. The dresses around us are the proof- You can see that the clothing around you is of good quality. -I have a lot of designs that you can see. From casual clothing to the type you would only wear in the privacy of your house. But...- She looks around. -I would thank you if you could return after i clean this whole mess. It won’t be that much time, i promise!- You sigh and nod at her request, promising to return in a couple of hours. She thanks you several times before you leave the place, into the city.\n"; 
			CityControl.city100MarketMeet [2] = true;
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

	public void buyCloth1(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 180) {
			WorldControl.dropItem = 20008; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 180; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 180) {
			board.text = "Your dont have enough gold!"; 
		}


	}


	/// <summary>
	/// ITEM 2
	/// </summary>

	public void buyCloth2(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 300) {
			WorldControl.dropItem = 20009; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 300; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 300) {
			board.text = "Your dont have enough gold!"; 
		}


	}

	/// <summary>
	/// ITEM 3
	/// </summary>

	public void buyCloth3(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 220) {
			WorldControl.dropItem = 20012; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 220; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 220) {
			board.text = "Your dont have enough gold!"; 
		}


	}



	/// <summary>
	/// Armour 1
	/// </summary>

	public void buyCloth4(){
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
			WorldControl.dropItem = 20005; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 350; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 350) {
			board.text = "Your dont have enough gold!"; 
		}


	}

	/// <summary>
	/// Armour 2
	/// </summary>

	public void buyCloth5(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 120) {
			WorldControl.dropItem = 20007; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 120; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 120) {
			board.text = "Your dont have enough gold!"; 
		}


	}

	/// <summary>
	/// Armour 3
	/// </summary>

	public void buyCloth6(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 600) {
			WorldControl.dropItem = 20010; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 600; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 600) {
			board.text = "Your dont have enough gold!"; 
		}


	}

	/// <summary>
	/// Armour 4
	/// </summary>

	public void buyCloth7(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 700) {
			WorldControl.dropItem = 20011; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 700; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 700) {
			board.text = "Your dont have enough gold!"; 
		}


	}



	/// <summary>
	/// Armour 5
	/// </summary>

	public void buyCloth8(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 300) {
			WorldControl.dropItem = 20013; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 300; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 300) {
			board.text = "Your dont have enough gold!"; 
		}


	}



	/// <summary>
	/// Helmet 1
	/// </summary>

	public void buyHeadgear1(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 50) {
			WorldControl.dropItem = 30003; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 50; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 50) {
			board.text = "Your dont have enough gold!"; 
		}


	}


	/// <summary>
	/// Helmet 2
	/// </summary>

	public void buyHeadgear2(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 100) {
			WorldControl.dropItem = 30004; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 100; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 100) {
			board.text = "Your dont have enough gold!"; 
		}


	}

	/// <summary>
	/// Mask 1
	/// </summary>

	public void buyMask1(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 30) {
			WorldControl.dropItem = 40001; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 30; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 30) {
			board.text = "Your dont have enough gold!"; 
		}


	}


	/// <summary>
	/// Mask 2
	/// </summary>
	public void buyMask2(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 70) {
			WorldControl.dropItem = 40003; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 70; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 70) {
			board.text = "Your dont have enough gold!"; 
		}


	}



	/// <summary>
	/// Mask 3
	/// </summary>

	public void buyMask3(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 300) {
			WorldControl.dropItem = 40004; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 300; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 300) {
			board.text = "Your dont have enough gold!"; 
		}


	}

	/// <summary>
	/// Neck 1
	/// </summary>

	public void buyNeck1(){
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
			WorldControl.dropItem = 50001; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 40; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 40) {
			board.text = "Your dont have enough gold!"; 
		}


	}


	/// <summary>
	/// Neck2
	/// </summary>

	public void buyNeck2(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 50) {
			WorldControl.dropItem = 50004; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 50; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 50) {
			board.text = "Your dont have enough gold!"; 
		}


	}

	/// <summary>
	/// Neck 3
	/// </summary>

	public void buyNeck3(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 70) {
			WorldControl.dropItem = 50005; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 70; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 70) {
			board.text = "Your dont have enough gold!"; 
		}


	}



	/// <summary>
	///  Shoulders1
	/// </summary>

	public void buyShoulders1(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 100) {
			WorldControl.dropItem = 60001; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 100; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 100) {
			board.text = "Your dont have enough gold!"; 
		}


	}


	/// <summary>
	///  Shoulders2
	/// </summary>

	public void buyShoulders2(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 80) {
			WorldControl.dropItem = 60002; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 80; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 80) {
			board.text = "Your dont have enough gold!"; 
		}


	}


	/// <summary>
	///  Shoulders3
	/// </summary>

	public void buyShoulders3(){
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
			WorldControl.dropItem = 40; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 40; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 40) {
			board.text = "Your dont have enough gold!"; 
		}


	}

	/// <summary>
	///  Hands 1
	/// </summary>

	public void buyHands1(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 50) {
			WorldControl.dropItem = 70002; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 50; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 50) {
			board.text = "Your dont have enough gold!"; 
		}


	}


	/// <summary>
	///  Hands 2
	/// </summary>

	public void buyHands2(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 60) {
			WorldControl.dropItem = 70003; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 60; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 60) {
			board.text = "Your dont have enough gold!"; 
		}


	}


	/// <summary>
	///  Hands 3
	/// </summary>

	public void buyHands3(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 100) {
			WorldControl.dropItem = 70004; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 100; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 100) {
			board.text = "Your dont have enough gold!"; 
		}


	}


	/// <summary>
	///  Hands 4
	/// </summary>

	public void buyHands4(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 80) {
			WorldControl.dropItem = 70005; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 80; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 80) {
			board.text = "Your dont have enough gold!"; 
		}


	}

	/// <summary>
	///  Hands 5
	/// </summary>

	public void buyHands5(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 30) {
			WorldControl.dropItem = 70006; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 30; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 30) {
			board.text = "Your dont have enough gold!"; 
		}


	}



	/// <summary>
	///  Legs1
	/// </summary>

	public void buyLegs1(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 50) {
			WorldControl.dropItem = 80003; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 50; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 50) {
			board.text = "Your dont have enough gold!"; 
		}


	}



	/// <summary>
	///  Legs 2
	/// </summary>

	public void buyLegs2(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 30) {
			WorldControl.dropItem = 80004; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 30; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 30) {
			board.text = "Your dont have enough gold!"; 
		}


	}


	/// <summary>
	///  Legs 3
	/// </summary>

	public void buyLegs3(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 80) {
			WorldControl.dropItem = 80005; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 80; 
			board.text = "Purchase successful!"  ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 80) {
			board.text = "Your dont have enough gold!"; 
		}


	}


	public void flirtNPC1(){
		panFlirt.SetAsLastSibling ();
		board.text = "Uh what you want honey?"; 
	}



	public void textClothing(){
		board.text = "You find the prices on the wall: \n\nTraveling clothes: 180 G. \nReligious habit: 300 G.\nSexy silk dress: 220 G.\nSexy consul clothing: 350 G. \nSexy femenine clothing: 120 G.\nPatrician Suit: 400 G.\nSenator clothing: 550 G. \nObscene silk dress: 300 G.  "; 
	}
	public void textHeadgear(){
		board.text = "You find the prices on the wall: \n\nDark brown hood: 50 G. \nLaurel Crown: 100 G."; 
	}
	public void textFace(){
		board.text = "You find the prices on the wall: \n\nRed bandolier: 30 G. \nLibrarian Glasses: 70 G. \nDark shades: 300 G."; 
	}
	public void textNeck(){
		board.text = "You find the prices on the wall: \n\nRed scarf: 40 G.\nSpiked Collar: 50 G.\nSimple Gold necklace: 70 G. "; 
	}
	public void textShoulders(){
		board.text = "You find the prices on the wall: \n\nRed cape: 100 G. \nSurvival backpack: 80 G.\nRed school backpack: 40 G. "; 
	}
	public void textHands(){
		board.text = "You find the prices on the wall: \n\nBlack fishnet armsleeves: 50 G.\nPink spandex armsleevs: 60 G.\nSpiked wristband: 100 G.\nFingerless gloves: 80 G.\nArm bandages: 30 G. "; 
	}
	public void textShoes(){
		board.text = "You find the prices on the wall: \n\nElegant Sandals: 50 G.\nFeet Bandages: 30 G.\nBlack high heels: 80 G."; 
	}




	void Awake () {
		WorldControl.location = "Aurorum - Tailor"; 
		startText ();
		WorldControl.PortraitIDLayer0 = 0;
		WorldControl.PortraitIDLayer1 = 0;
		WorldControl.PortraitIDLayer2 = 0;
		if (CityControl.city100Corruption > 50) {
			WorldControl.NPCID = 0;
		}
	}






}
