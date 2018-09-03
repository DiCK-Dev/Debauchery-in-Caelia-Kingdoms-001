using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AgoraScene : MonoBehaviour {

	int i; 
	public Text butt1txt;
	public Text Board; 
	public RectTransform endTurnPanel; 
	public RectTransform panAbbadon; 
	public RectTransform BathPanel0; 
	public RectTransform BathPanel1;
	public RectTransform colosseumPanel0; 
	public RectTransform colosseumPanel1; 
	public RectTransform amphiTheatrePanel0; 
	public RectTransform amphiTheatrePanel1; 


	string mcpronoun; 


	public Button bathRepairButt; 
	public Button colosseumRepairButt; 
	public Button AmphitheatreRepairButt; 

	// Abbadon
	/// /////////////////////////////////////////////////////////////////////////////////////////////////
	/*
	public void TalkAbbadon()
	{

		if (NPCControl.npc1000Meet == false) 
		{
			WorldControl.NPCID = 1050;
			if (NPCControl.npc1000Corruption >= 50) {
				WorldControl.NPCID = 1150;
			}
			endTurnPanel.SetAsLastSibling ();
			Board.text = "The Agora is one of the greatest districts in the city of Aurorum, full of places for entertainment and different kinds of enjoyment. From the arena for those who are thirsty of blood and violence to the amphitheater, for the citizens that would rather have a more delicate and sophisticated experience. \n\nBut walking through the streets you realize that there is deadly silence, and looking around is not hard to figure why, most of the buildings are either closed or abandoned, and the few places that are open don't offer anything exciting anymore. \n\nThe place is a mess for sure, and you wonder if the owner of this streets looks equally bad. Well, you sure hope he doesn’t smells like it. \n\nYou finally reach a small mansion, which its great condition contrasts sharply with the rest of its surroundings. You knock the door and it doesn’t take long until a maid attends you, asking you what do you want. When you tell her who you are, she nervously apologizes for her rudeness and immediately invites you inside, asking you to wait for a minute while she goes for the head of the house. \n\nThe place is clean and lighted by lamps, with a beautiful floor of redwood and a green wallpaper. There are paintings of older people, all men who were former patricians of the house. Although the place has good decoration, you think that something seems odd, as if there are things missing from the house, until you realize that the patrician has been probably selling furniture and ornaments to keep its lifestyle, and by the emptiness of the place you assume that its draining him quite fast. \n\nYou pay attention again when you hear someone opening a door upstairs, with some weird moanings too before it closed. Afterwards you hear some  light steps coming from the stairs, and you are surprised when a petite woman comes down. You crouch to her level and ask her if the patrician of the house is coming out soon, but she answers you by throwing a swift punch to your face, that although it hurts and pushes you back a bit, it doesn’t seems that you will require any medical attention. \n\nShe puts her hands at her side and finally speaks to you. -Don’t dare to insult me again like that. You may be the new lord of the city, but I won't tolerate this kind of talk, specially in my house. I AM Sir Abbadon to you, of course patrician of the Great House of Abbadon.- You almost tell him how he dares to do that, but you decide to stop, that he’s not worth the fight. \n\nYou do the typical “apology”, and explain to him that you are here to present yourself. (You expected the other Patricians to actually look for you, but after some time you realize that they won't bother), and that as new Lord you aspire to improve the city as much as you can. \n\n-Really? I see, that's something unexpected…- He sarcastically says laughing a little, but he recovers his composure and takes a more dignified stance. -Look, don't get me wrong, " + mcpronoun +", is just the whole city is almost in ruins, and I am not sure what you can do about that. Also, our house isn’t doing so well lately, neither. You see, people here is so poor that they can barely afford food, so paying to assist to the amphitheater or bet on the arena is somewhat beyond what their lifestyles allows them. And not just that… Assuming you aren’t as dumb as you look, you probably have realized by now that the place is… not in the best conditions.- His attitude changes a little with those last words, losing some of his strength or energy, as you see a hint of doubt in his eyes. -...I guess there is no other way, but if you decide to invest with me, and maybe send people that can help me get things going, I can probably pay you a hefty sum… Over time… As taxes, like a good citizen… Come to my office, to explain you what I have in mind-\n\nWell, Abbadon ain’t stupid, he pretty much asks you to pay for repairs, and once you do that and the places start to operate again, he will probably pay all of it with a good amount of taxes from the revenue of each place. Although you would rather have him pay you the accorded loan plus taxes, it is clear that in the long run it’s win-win for both of you, and well, if the place stay as it is you will get nothing back anyway, so there is no point on leaving the Abbadon House in its current state. \n\nYou agree with the stubborn boy, and once the deal is over he dismisses you. His cocky attitude, the fact that he is so full of himself is kinda annoying, but you suspect that there is some history behind him, although that doesn’t change the fact that he needs to learn some respect. \n";

				NPCControl.npc1000Meet = true; 

			int x = 0;
			while (x < NPCCharList.CharList.Count){
				if (NPCCharList.CharList [x].charID >= 1000 && NPCCharList.CharList [x].charID < 2000) {
					NPCCharList.CharList [x].isRecruited = true; 
					break; 
				}
				x++;
			}

	
		} else 
		{
			WorldControl.NPCID = 0;
			Board.text = "What you want to do? If you want to corrupt Abbadon, or will have to get to know him first, talk to him! Note: You can talk with him about the same topic several times!"; 
			panAbbadon.SetAsLastSibling (); 
		}
	}




	*/









	// Bath /// 
	/// /////////////////////////////////////////////////////////////////////////////////////////////////

	public void LocBath()
	{
		//first texts
		Debug.Log(CityControl.city100BathMeet);
		if (CityControl.city100BathMeet == false) {
			Board.text = "You visit the place but its in awful conditions. You spend some hours taking notes to figure out how much it will cost to repair"; 
			endTurnPanel.SetAsLastSibling ();
			CityControl.city100BathMeet = true; 
		} 
		else 
		{
			if (CityControl.city100BathLevel == 0) 
			{
				Board.text = "the place is still as the last time you visited"; 
				BathPanel0.SetAsLastSibling ();
			}
			else if (CityControl.city100BathLevel == 1) 
			{

				Board.text = "the place is improving"; 
				BathPanel1.SetAsLastSibling ();
			}


		}
	

	}

	public void LocBathRepairText(){
		if (CityControl.city100BathLevel == 0) {
			Board.text = "It will cost you 500 gold to repair this, proceed?"; 
		} else if (CityControl.city100BathLevel == 1){
			Board.text = "It will cost you 1500 gold to repair this, proceed?";
		} else if (CityControl.city100BathLevel == 2){
			Board.text = "It will cost you 2000 gold to repair this, proceed?";
		}else {
			Board.text = "This place is fully repaired"; 
		}

	}

	public void LocBathRepair1(){


		if (CityControl.city100BathLevel == 0) {
			GameControl.charGold = GameControl.charGold - 500; 
			CityControl.city100BathLevel = 1;
			Board.text = "You repaired the baths!"; 
		} 

	}
	public void LocABathRepair2(){


		if (GameControl.charGold >= 1500) {
			GameControl.charGold = GameControl.charGold - 1500; 
			CityControl.city100BathLevel = 2;
			Board.text = "You repaired the amphi!"; 
			endTurnPanel.SetAsLastSibling ();

		} else {
			Board.text = "You dont have enough money!"; 
		}

	}

	// Colosseum
	/// /////////////////////////////////////////////////////////////////////////////////////////////////
	public void LocColosseum()
	{
		//first texts

		if (CityControl.city100ColosseumMeet == false) {
			Board.text = "You visit the place but its a shithole. You spend some hours taking notes to figure out how much it will cost to repair"; 
			endTurnPanel.SetAsLastSibling ();
			CityControl.city100ColosseumMeet = true; 
		} 
		else 
		{
			if (CityControl.city100ColosseumLevel == 0) 
			{
				Board.text = "the place is still as the last time you visited"; 
				colosseumPanel0.SetAsLastSibling ();
			}
			else if (CityControl.city100ColosseumLevel == 1) 
			{
				Board.text = "the place is improving"; 
				colosseumPanel1.SetAsLastSibling ();
			}
		}
	}


	public void LocColosseumRepairText(){
		if (CityControl.city100ColosseumLevel == 0) {
			Board.text = "It will cost you 500 gold to repair this, proceed?"; 
		} else if (CityControl.city100ColosseumLevel == 1){
			Board.text = "It will cost you 1500 gold to repair this, proceed?";
		} else if (CityControl.city100ColosseumLevel == 2){
			Board.text = "It will cost you 2000 gold to repair this, proceed?";
		}else {
			Board.text = "This place is fully repaired"; 
		}

	}


	public void LocColosseumRepair1(){


		if (CityControl.city100ColosseumLevel == 0) {
			GameControl.charGold = GameControl.charGold - 500; 
			CityControl.city100ColosseumLevel = 1;
			Board.text = "You repaired the baths!"; 
		} 

	}
	public void LocColosseumRepair2(){


		if (GameControl.charGold >= 1500) {
			GameControl.charGold = GameControl.charGold - 1500; 
			CityControl.city100ColosseumLevel = 2;
			Board.text = "You repaired the amphi!"; 
			endTurnPanel.SetAsLastSibling ();

		} else {
			Board.text = "You dont have enough money!"; 
		}

	}

	// Agora start scene texts
	/// /////////////////////////////////////////////////////////////////////////////////////////////////

	void AgoraStart (){
		if (CityControl.city100AgoraMeet == false) 
		{
			Board.text = "This is the first time that you set foot in this place. You’ve heard a couple of things of the Agora from your servants, so you decided to pay the place a visit, to see the conditions in which it is. And just as you expected, the place is barely holding still, although far better than the other places that you’ve seen the past few days.\n\n\nYou walk through the Agora, seeing a couple of worn-out signs that point to different places in the Agora. The one that is in better condition that the other was the one that pointed at the “Arena”. The other that is barely legible says: Amphitheater. You visit both places and found that both of them have been closed for quite a while, as the dust has been gathering over them. At least the Arena is easier to repair.\n\n\nYou’ve heard about the owner of this place: Abaddon. The head of one of the most powerful houses still relevant in Aurorum. Perhaps you should pay him a visit and talk about him of the place and their rooms of improvement.\n"; 
			CityControl.city100AgoraMeet = true; 
		}else
		{
			if (CityControl.city100Corruption >= 100) {
				Board.text = "The place has a couple of slaves from the Abbadon House, trying their best to repair what they can from the Arena and the Amphitheater without much success. You can see that the place is being used occasionally for the citizens as a hidden place to fuck. Even though the Arena isn’t what you call “hidden”. At least in the Amphitheater they have more cover.\n\n\nThe place is still in repairs, so there isn’t much to do at the place for now.";
			} else if (CityControl.city100Corruption > 80) {
				Board.text = "The place has a couple of slaves from the Abbadon House, trying their best to repair what they can from the Arena and the Amphitheater without much success. You can see that the place is being used occasionally for the citizens as a hidden place to fuck. Even though the Arena isn’t what you call “hidden”. At least in the Amphitheater they have more cover.\n\n\nThe place is still in repairs, so there isn’t much to do at the place for now.";
			} else if (CityControl.city100Corruption > 60) {
				Board.text = "The place has a couple of slaves from the Abbadon House, trying their best to repair what they can from the Arena and the Amphitheater without much success. You can see that the place is being used occasionally for the citizens as a hidden place to fuck. Even though the Arena isn’t what you call “hidden”. At least in the Amphitheater they have more cover.\n\n\nThe place is still in repairs, so there isn’t much to do at the place for now.";
			} else if (CityControl.city100Corruption > 40) {
				Board.text = "The place has a couple of slaves from the Abbadon House, trying their best to repair what they can from the Arena and the Amphitheater without much success. You can see that the place is being used occasionally for the citizens as a hidden place to fuck. Even though the Arena isn’t what you call “hidden”. At least in the Amphitheater they have more cover.\n\n\nThe place is still in repairs, so there isn’t much to do at the place for now.";
			} else if (CityControl.city100Corruption > 20) {
				Board.text = "The place has a couple of slaves from the Abbadon House, trying their best to repair what they can from the Arena and the Amphitheater without much success. You can see that the place is being used occasionally for the old gladiators, to train their moves and techniques. And the Amphitheater is surrounded by actors from all kinds of plays, from sophisticated to erotical, trying to maintain a semblance of activity. \n\n\nThe place is still in repairs, so there isn’t much to do at the place for now.";
			} else if (CityControl.city100Corruption > 0) {
				Board.text = "The place has a couple of slaves from the Abbadon House, trying their best to repair what they can from the Arena and the Amphitheater without much success. You can see that the place is being used occasionally for the old gladiators, to train their moves and techniques. And the Amphitheater is surrounded by actors from all kinds of plays, from sophisticated to erotical, trying to maintain a semblance of activity. \n\n\nThe place is still in repairs, so there isn’t much to do at the place for now.";
			} else if (CityControl.city100Corruption <= 0) {
				Board.text = "The place has a couple of slaves from the Abbadon House, trying their best to repair what they can from the Arena and the Amphitheater without much success. You can see that the place is being used occasionally for the old gladiators, to train their moves and techniques. And the Amphitheater is surrounded by actors from all kinds of plays, from sophisticated to erotical, trying to maintain a semblance of activity. \n\n\nThe place is still in repairs, so there isn’t much to do at the place for now.";
			} 

		}

	}






	// Amphitheatre
	/// /////////////////////////////////////////////////////////////////////////////////////////////////
	public void LocAmphitheatre()
	{
		//first texts

		if (CityControl.city100AmphitheatreMeet == false) {
			Board.text = "You visit the place but its a shithole. You spend some hours taking notes to figure out how much it will cost to repair"; 
			endTurnPanel.SetAsLastSibling ();
			CityControl.city100AmphitheatreMeet = true; 
		} 
		else 
		{
			if (CityControl.city100AmphitheatreLevel == 0) 
			{
				Board.text = "the place is still as the last time you visited";
				amphiTheatrePanel0.SetAsLastSibling ();
			}
			else if (CityControl.city100AmphitheatreLevel == 1) 
			{

				Board.text = "the place is improving";
				amphiTheatrePanel1.SetAsLastSibling ();
			}
		}
	}


	public void LocAmphitheatreRepairText(){
		if (CityControl.city100AmphitheatreLevel == 0) {
			Board.text = "It will cost you 500 gold to repair this, proceed?"; 
		} else if (CityControl.city100AmphitheatreLevel == 1){
			Board.text = "It will cost you 1500 gold to repair this, proceed?";
		} else if (CityControl.city100AmphitheatreLevel == 2){
			Board.text = "It will cost you 2000 gold to repair this, proceed?";
		}else {
			Board.text = "This place is fully repaired"; 
		}

	}
	public void LocAmphitheatreRepair1(){


		if (CityControl.city100AmphitheatreLevel == 0) {
			GameControl.charGold = GameControl.charGold - 500; 
			CityControl.city100AmphitheatreLevel = 1;
			Board.text = "You repaired the baths!"; 
		} 

	}
	public void LocAmphitheatreRepair2(){


		if (GameControl.charGold >= 1500) {
			GameControl.charGold = GameControl.charGold - 1500; 
			CityControl.city100AmphitheatreLevel = 2;
			Board.text = "You repaired the amphi!"; 
			endTurnPanel.SetAsLastSibling ();

		} else {
			Board.text = "You dont have enough money!"; 
		}

	}

	/// /////////////////////////////////////////////////////////////////////////////////////////////////
	void Awake () 
	{
		WorldControl.location = "Aurorum - Abbadon house"; 
		/*if (NPCControl.npc1000Meet != true) {
			butt1txt.text = "Petite... woman?"; 
		} else {
			butt1txt.text = "Abbadon"; 
		}*/

		if (GameControl.genderBehaviorStat > 10) {
			mcpronoun = "Lady";
		} else {
			mcpronoun = "Lord"; 
		}





	}



	void Start () 
	{
		AgoraStart ();


		// deactivate bath repair 
		if (CityControl.city100BathLevel == 0) 
		{
			if (GameControl.charGold >= 500) {

			} else {
				bathRepairButt.GetComponent<Button> ().interactable = false; 
			}
		}
		if (CityControl.city100BathLevel == 1) {
			if (GameControl.charGold >= 1500) {

			} else {
				bathRepairButt.GetComponent<Button> ().interactable = false; 
			}
		}
		// deactivate colosseum repair
		if (CityControl.city100ColosseumLevel == 0) 
		{
			if (GameControl.charGold >= 500) {

			} else {
				colosseumRepairButt.GetComponent<Button> ().interactable = false; 
			}
		}
		if (CityControl.city100ColosseumLevel == 1) {
			if (GameControl.charGold >= 1500) {

			} else {
				colosseumRepairButt.GetComponent<Button> ().interactable = false; 
			}
		}
		// deactivate amphitheathre repair
		if (CityControl.city100AmphitheatreLevel == 0) 
		{
			if (GameControl.charGold >= 500) {

			} else {
				AmphitheatreRepairButt.GetComponent<Button> ().interactable = false; 
			}
		}
		if (CityControl.city100AmphitheatreLevel == 1) {
			if (GameControl.charGold >= 1500) {

			} else {
				AmphitheatreRepairButt.GetComponent<Button> ().interactable = false; 
			}
		}


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
