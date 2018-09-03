using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class BlacksmithScene : MonoBehaviour {
	public Text board; 
	int i;
	int x; 



	public RectTransform panEndTurn;
	public RectTransform panFlirt; 
	AddItemScript addItem = new AddItemScript();


	public void startText(){

		if (GameControl.charArmorTags [1] == true && GameControl.charArmorTags [2] == true) {
			if (CityControl.city100Corruption < 50) {
				board.text = "As you enter the blacksmith, you can see that the place now has a selection of weapons and armor on the sides of the store. Most of them are new, but some looks like they had been used at least once. Most of the smithing had a design that matched the city’s style. He has several slaves working for him, moving things and cleaning the place.\n\nYou see Faberius polishing a pair of greaves with strong motions next to the exit that leads to the anvil. You could see his muscles pressing against his sweaty almost-translucent shirt. You see that his frown increased when he heard the door opening, but it returns to its original frown when he sees that it's you. \n\n<i>My god, oil me and throw me into the stallion’s nest, but just look at that!</i> He says before tossing the greaves behind the counter, hitting other things but he doesn’t seems to care. <i>”It’s been a while since I’ve seen something as… that armor”</i> You know he is lying, as you can feel his gaze all over your body, as if he is trying to eat you whole with just his eyes. He doesn’t seems to mind the staring at your lewd parts. <i>“Just tell me what do you require, I’m getting some… inspiration.”</i>";
			} else {
				string boygirl = "boy";
				if (GameControl.mcGender == GameControl.MCGender.FEMALE) {
					boygirl = "girl";
				}

				board.text = "As you enter the blacksmith, you can see that the place has been lightened up a little. You can see that there is some armor on the sides of the store, but now most of them had lewd designs or dirty signs over them. There are also some straps and restraints for individual use, and you know for their size that they aren’t meant for horses.\n\nYou see Faberius body being oiled by their slaves, whose faces now were full of lust, rather than fear of its owner. He was shirtless, his iron muscles glistening with the light of the high torches that lighted the place. You could see that instead of pants, he was now wearing a leather strap that delineates his cock completely.\n\nWhen he sees you, he dismiss the slaves and walks back to the counter, whistling at your revealing clothing. <i>“We have ourselves a party "+ boygirl +"”</i> You can see that he takes a good look at your body, his own breathing getting heavier by your naughty bits showing to him. <i>“Are you sure that you want to cover that ravishing body? That would be a shame…”</i>";
			}
		} else {



			if (CityControl.city100Corruption < 50) {
				board.text = "As you enter the blacksmith, you can see that the place now has a selection of weapons and armor on the sides of the store. Most of them are new, but some looks like they had been used at least once. Most of the smithing had a design that matched the city’s style. He has several slaves working for him, moving things and cleaning the place.\n\nYou see Faberius polishing a pair of greaves with strong motions next to the exit that leads to the anvil. You could see his muscles pressing against his sweaty shirt. You see that his frown increased when he heard the door opening, but it returns to its original frown when he sees that it's you. -Good. Someone worth a coin- He says before placing the greaves behind the counter.\n\nHe places both hands on the counter. -What brought you here? Is there something that finally caught your attention, or you came here to get some “training”?- He said in a blunt tone.";
			} else {
				board.text = "As you enter the blacksmith, you can see that the place has been lightened up a little. You can see that there is some armor on the sides of the store, but now most of them had lewd designs or dirty signs over them. There are also some straps and restraints for individual use, and you know for their size that they aren’t meant for horses.\n\nYou see Faberius body being oiled by their slaves, whose faces now were full of lust, rather than fear of its owner. He was shirtless, his iron muscles glistening with the light of the high torches that lighted the place. You could see that instead of pants, he was now wearing a leather strap that delineated his cock completely.\n\nWhen he sees you, he dismiss the slaves and walks back to the counter. -You want some of the pain-dispensers I have... or do you want to get some discipline?- His face is that of someone full of severity, but his usual frown didn’t disappeared at all.";

			}

		}




		if (CityControl.city100MarketMeet [3] == false) {
			CityControl.city100MarketMeet [3] = true; 
			board.text = "When you enter the blacksmith store for the first time, you hear something through a door on the side of the building. You decide to take a peek, and find out that someone is working on an anvil. It is a shirtless human male, his body sculpted with a lot of muscle in it. He is hammering a piece of metal in an anvil, which clanks echoes across the whole building. After a while, he finally left the piece in a water barrel and turns to see you and grunts.\n\nHe takes off his blacksmithing apron and walks towards you. -I hope that you’re planning on buying something soon. I don’t like peeping people, I like customers. They bring money- He crosses his arms in front of you. You ask him if he has something on storage already or if everything is by order. He somehow sighed in relief. -Thank Valeriss that you don’t asked if this is the blacksmith. I’m so done with retarded people- He walks inside the store and gets in the counter, cleaning the sweat from his body with a rag. You see that he is older than you thought, but definitely not weaker. -I always have a couple of spare weapons and armor if you plan on traveling through the roads out of this place, cheap and ugly, but they get the job done-\n\nBefore you can ask anything else, he continues. -If you want something bigger, sturdier or fancy, I can present you my personal collection, but don't waste my time, and I don’t accept credit anymore.  A lot of assholes think they can get away with it. Maybe next time i’ll break their legs in advance and save myself some time.- He got lost in thoughts of that, before looking at you. -Armors or weapons, I got both of them. But for now, I got to go and get the stuff from my storehouse, and that’s gonna take a while. Maybe if you can return in a couple of hours, I can scrap some stuff for you to see. Okay? The name’s Faberius, by the way- You nod and say that you will return soon. He spits in the spittoon next to him and nods, before disappearing in the back door of the store.\n";
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 250) {
			WorldControl.dropItem = 10002; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 250; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 250) {
			board.text = "Your dont have enough gold!"; 
		}


	}


	/// <summary>
	/// ITEM 2
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 250) {
			WorldControl.dropItem = 10004; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 250; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 250) {
			board.text = "Your dont have enough gold!"; 
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 250) {
			WorldControl.dropItem = 10006; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 250; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 250) {
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
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 200) {
			board.text = "Your dont have enough gold!"; 
		}


	}

	/// <summary>
	/// Armour 2
	/// </summary>

	public void buyArmor2(){
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
			WorldControl.dropItem = 20002; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 350; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 350) {
			board.text = "Your dont have enough gold!"; 
		}


	}

	/// <summary>
	/// Armour 3
	/// </summary>

	public void buyArmor3(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 800) {
			WorldControl.dropItem = 20003; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 800; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 800) {
			board.text = "Your dont have enough gold!"; 
		}


	}

	/// <summary>
	/// Armour 4
	/// </summary>

	public void buyArmor4(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 2000) {
			WorldControl.dropItem = 20004; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 2000; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 2000) {
			board.text = "Your dont have enough gold!"; 
		}


	}



	/// <summary>
	/// Armour 5
	/// </summary>

	public void buyArmor5(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 500) {
			WorldControl.dropItem = 20006; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 500; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 500) {
			board.text = "Your dont have enough gold!"; 
		}


	}


	public void buyArmor6(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 1500) {
			WorldControl.dropItem = 20014; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 1500; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 1500) {
			board.text = "Your dont have enough gold!"; 
		}


	}



	/// <summary>
	/// Helmet 1
	/// </summary>

	public void buyHelmet1(){
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 150) {
			WorldControl.dropItem = 30001; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 150; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 150) {
			board.text = "Your dont have enough gold!"; 
		}


	}


	/// <summary>
	/// Helmet 2
	/// </summary>

	public void buyHelmet2(){
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
			WorldControl.dropItem = 30002; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 200; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 200) {
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 100) {
			WorldControl.dropItem = 40002; 
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 120) {
			WorldControl.dropItem = 50002; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 120; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 120) {
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 30) {
			WorldControl.dropItem = 50003; 
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 120) {
			WorldControl.dropItem = 60004; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 120; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 120) {
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 200) {
			WorldControl.dropItem = 60005; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 200; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 200) {
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 140) {
			WorldControl.dropItem = 70001; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 140; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 140) {
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 200) {
			WorldControl.dropItem = 100; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 200; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 200) {
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 80) {
			WorldControl.dropItem = 80001; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 80; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 80) {
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




		if (WorldControl.stashFull == false && GameControl.charGold >= 100) {
			WorldControl.dropItem = 80002; 
			addItem.addItemScript ();
			GameControl.charGold = GameControl.charGold - 100; 
			board.text = "Purchase successful!"   ; 

		} else if (WorldControl.stashFull == true) {
			board.text = "Your inventory is full!"; 
		} else if (GameControl.charGold < 100) {
			board.text = "Your dont have enough gold!"; 
		}


	}


	public void textWeapons(){
		board.text = "You find the prices written on the wall: \n\nGladius: 250 G.\nLeather whip: 250 G.\nHunting bow: 250 G."; 
	}
	public void textArmor(){
		board.text = "You find the prices written on the wall: \n\nLegionary armour: 200 G.\nCenturio armour: 450 G.\nLegatus armour: 800 G.\nCaesar Armour: 2000 G.\nCataprach armour: 500 G. \nMaidens armour: 1500 G. "; 
	}
	public void textHelmet(){
		board.text = "You find the prices written on the wall: \n\nGalea helmet: 150 G.\nGladiator Helmet: 200 G."; 
	}
	public void textFace(){
		board.text = "You find the prices written on the wall: \n\nGladiator mask: 100 G."; 
	}
	public void textNeck(){
		board.text = "You find the prices written on the wall: \n\nSteel Gorget: 120 G. \nSlave Collar: 30 G.\n"; 
	}
	public void textShoulders(){
		board.text = "You find the prices written on the wall: \n\nSteel pauldrons: 120 G. \nSteel pauldrons with red cape: 200 G."; 
	}
	public void textHands(){
		board.text = "You find the prices written on the wall: \n\nSteel gauntlets: 140 G."; 
	}
	public void textShoes(){
		board.text = "You find the prices written on the wall: \n\nCombat boots: 80 G.\nSteel greaves: 100 G."; 
	}



	public void flirtNPC1(){
		panFlirt.SetAsLastSibling ();
		board.text = "Uh what you want honey?"; 
	}


	void Awake () {
		WorldControl.location = "Aurorum - Blacksmith"; 
		startText ();
	}












	void Start () {
		WorldControl.PortraitIDLayer0 = 0;
		WorldControl.PortraitIDLayer1 = 0;
		WorldControl.PortraitIDLayer2 = 0;
	}


}
