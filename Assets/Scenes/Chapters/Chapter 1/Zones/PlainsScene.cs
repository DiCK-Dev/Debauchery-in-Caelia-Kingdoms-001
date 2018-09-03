using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class PlainsScene : MonoBehaviour {

	public Text Board; 
	int randNum; 
	int i;
	public Canvas Event1;
	public Canvas Event2;
	public Canvas Event3;
	/*public RectTransform Event4;
	public RectTransform Event5;
	public RectTransform Event6;
	public RectTransform Event7;

	public RectTransform Event9;
	public RectTransform Event10;*/
	//public RectTransform Event4;
	public Canvas panEndTurn; 

	string dicksize;
	string mcpronoun; 
	string mcname; 

	AddItemScript addItemScript = new AddItemScript();
	Parser parser = new Parser();


	public void randomEvents(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 100);
		WorldControl.NPCID = 0; 
		if (randNum > 90) {
			//event 1 caravan 
			Event1.sortingOrder = 500;
			WorldControl.location = "Forest - Gypsy Caravan"; 
			Board.text = "As you wander through the plains, you stumble with a gypsy caravan that is traveling across the island. You know that the gypsies are one of the last groups that have the guts to travel that far from their homes since the Plague appeared, especially with the Lost roaming the across the wilds, and the roads that are built around them.\n\nThey stationed close to a small rivulet, their caravans designed to become stands in the blink of an eye. It’s fascinating how they are somehow divided by transformations. Almost all of the ones who had bird features were on the same wagon, and so with the ones who had feline features. There were a couple of feline dancers practicing their steps close to the water. Many of them are using the time for resting or eating, as they are probably weary from their journey. \n\nAs you walk among the stands, you hear someone whistling to catch your attention. When you turn, you see a gypsy female with feline features, calling you with her index finger. As you approach, you see that she is sitting in a table inside one of the stands. She places a deck of cards in the table. \"Wanna try me? A simple game of cards. The winner gets to play with the loser,\" she says, subtly licking her lips. \"The first one it’s on me. Do you have what it takes to win?\" You smile at the challenge, and sat on the chair in front of her as you take a hand of cards, as so does she.\n\nYou truly have a hard time playing against her. It’s truly a game of wits, as you have to be alert all the time, being careful to cut off any attempt of cheating from her behalf. You see her trying to trick you at every chance she can get, but you know the drill, something that surprises her even though she tries to conceal her excitement. Finally, on the last game to decide the winner, you have the upper hand. You know that you can win, but thinking about it for a second, do you really want to win? She’s smoking hot and deep inside, you couldn’t help but wonder what kind of things she has in store for you. And so, you wonder: Lay off your move to claim your victory and your prize, or concede and leave your destiny in her skillful hands?\n";

		} else if (randNum > 80) {
			Event2.sortingOrder = 500;
			Board.text = "You keep traveling with your bodyguard through the plains, until you realize that you got separated from it and you don’t remember when. You try to walk back the same way you using, readying your weapon just in case something takes the opportunity to attack you. There is a good reason why you brought a guard in the first place.\n\nThe road back is full of bushes and other kind of dangers, but you hear a familiar voice calling your name in the distance. You hurry through the steppes towards that voice calling you."; 

		} else if (randNum > 70) {
			Event3.sortingOrder = 500;
			Board.text = "You travel across the plains, full of dangerous unexplored beauty. You can see the road that leads to the next city is ahead, but you are still far from your next destination. During your journey, you find out an old structure made of stone, in the middle of nowhere. You hear some ruckus happening inside the place, so you investigate the matter.\n\nAs you sneak through the destroyed building, you can hear the distinctive sound of combat happening in the middle of it. You hurry, only to find fighting a couple of savages from those tribes you’ve seen lately. Both are fighting with everything they have: biting, scratching or slamming against each other. There is traces of blood around them, as you approach the combat carefully. You can see that they were a man and a woman with lion characteristics, the ones fighting. It seems that the man is winning, although is hard to see as they move too much on the floor. \n\nWhen they see you, they split from each other and keep an eye on you, panting and trying to repair their wardrobe malfunctions, as they have many after that quarrel. You ask why they are fighting. She speaks first, gulping some saliva before starting. \"We always come here when I want to shut him up. So I challenged him to a duel again, but he won’t stop cheating! He starts rubbing my cunt and breasts, distracting me! That’s not fair\"\n\nThe man crosses his arms. \"You have to do everything to win a duel! That’s why I win every time\" And after a bit of arguing, they look at you at the same time. She walks close to you. \"You saw us fight, right? Then you can tell him that I won, despite his treacherous ways!\" .He walks close to you from the other side. \"Tell her that in the outside world, there is no such thing as fairness. Only the strong survives\"\n\nBoth of them wait for your answer, looking at you in a way that leaves the whole result of the dispute in your words.\n";
		} else if (randNum > 60) {
			endTurnFun ();
			Board.text = "As you travel through the plains, you can see a small group of people in the distance. Judging from their clothing, they look like they belong to one of the tribes of Lost that have organized through the zone. Their mind twisted but not broken completely. Most of them are lions and tigers of different species, some of them are pulling a cart filled with a couple of Lost.\n\nYou’d rather wait for them to leave before continuing your exploration of the plains, but nothing else of importance happened after that, so you returned to your city. Maybe you’ll pay them a visit later.";			

		} else if (randNum > 50) {
			endTurnFun ();
			Board.text = "You can see that there is a Gypsy Caravan moving fast through the clear plains in a mile in front of you. At first, you wonder what is the hurry with them, but after looking what is behind them, you understand its urgency. There is a string of stallions right behind them, chasing them very closely.\n\nYou feel amazed of the diligence of the Gypsies, but you return to the city before those stallions decide that running behind a cart that fast is futile, and search for an easier pick.";
		} else if (randNum > 40) {
			endTurnFun ();
			Board.text = "After an hour of wandering through the plains, you found out a place where someone recently has been sleeping. You find a campfire that has been lit recently, the place where someone slept, but no other signs. You wonder if the wanderer met a corrupting fate or perhaps it has already moved from this zone. \n\nYou search for his whereabouts on the surroundings, but you only can find a small vial in the campfire, so you decide to take it with you before leaving the place and return to your city.";
			WorldControl.dropItem = 1015; 
			addItemScript.addItemScript ();
		} else if (randNum > 30) {
			endTurnFun ();
			Board.text = "After strolling a couple of hours, you found yourself in the parts that are deeper in the plains, closer to the different tribes that populate the place. \n\nYou can see that in the distance, a group of stallions are gathering and moving in the distance in a large group, moving to an unknown location. You wonder what kind of things they are doing in the wild, that could occupy such numbers. You go to the place where they were gathering and found out a small vial among the things they left behind. You take it and move back to the city, before they think of turning back.\n";
			WorldControl.dropItem = 1020;
			addItemScript.addItemScript ();
		} else if (randNum > 20) {
			//duplictaed, change
			Board.text = "You can see that there is a Gypsy Caravan moving fast through the clear plains in a mile in front of you. At first, you wonder what is the hurry with them, but after looking what is behind them, you understand its urgency. There is a string of stallions right behind them, chasing them very closely.\n\nYou feel amazed of the diligence of the Gypsies, but you return to the city before those stallions decide that running behind a cart that fast is futile, and search for an easier pick.";
			endTurnFun ();


		} else  {
			//duplicated, change
			Board.text = "As you travel through the plains, you can see a small group of people in the distance. Judging from their clothing, they look like they belong to one of the tribes of Lost that have organized through the zone. Their mind twisted but not broken completely. Most of them are lions and tigers of different species, some of them are pulling a cart filled with a couple of Lost.\n\nYou’d rather wait for them to leave before continuing your exploration of the plains, but nothing else of importance happened after that, so you returned to your city. Maybe you’ll pay them a visit later.";
			endTurnFun ();



		} 

	}





	public void event1A(){
		//game over
		endTurnFun ();
		Board.text = "You earned your win, and so you lay the cards in the table. Her face is of complete shock, from her gestures you suppose that this isn’t something that happens too often. She stood silent for a second, looking at your hand then sighing and looking to you. \"We made a deal, and a deal is made to be paid. What it will be?\" She says in a tone that makes you think that it’s something that is a common phrase among the gypsies of that caravan.\n";
		if (GameControl.dick1Size > 0) {
			Board.text = "You undo your lower clothing as you were sitting in the chair, exposing your "+ dicksize +" cock and tell her that you would like a good blow from her. \"Let me take care of it then,\" she says with a mischievous smile and and kneels in front of your chair, licking and stroking your member while giving you an excited look. You can feel her soft hands massaging your cock as drops of her saliva slip off her tongue and soak it completely. You can see how she started to pant slowly, as she started to suck off the tip slightly and then licking your whole prick.\n\nAfter a couple of licks of courage, she takes your cock inside her mouth as far as she can and uses her tongue to play with it. You are surprised that she is capable of taking that much dick inside her mouth, but with this you know that this isn’t one of her first times in that area of expertise. After a pair of seconds of engulfing it, she pulls out a bit and started bobbing it in and out of her mouth. You can feel her throat purring around your shaft, something that feels amazing to the point of making you moan a bit, as she moves faster and faster. You can smell that she is getting excited by the blowjob, her body trembling a bit every time she takes your prick close to her throat.\n\nYou can feel how your own body trembles from all the sensations, as you feel that you are close to cumming. When you know that you are at the edge of orgasm, you use your hands to held her head as she has your dick inside her, releasing a load of cum into her mouth and throat, as you see that her eyes are of complete surprise. She has to hold your legs as she swallows it completely, trying her best not to let it spill of the floor, gulps of your seed streaming down her throat as she drinks from your cock.\n\nAfter a pair of seconds, she wraps your cock with her tongue, cleaning it from your spunk. She lets out your cock slowly, panting as she looked at you. \"That was hot… If this is losing, I almost don’t mind it… Almost.\" She says as she cleans her jaw with her arm, and then licks the cum in it.. \" I—I think I have to do something on the back…,\" she says, while rubbing her pussy from below her skirt as she almost stumbles to the back of the wagon, probably to relieve herself. You hide your genitals once more in your clothing and leave the caravan for the time being.\n";
		} else {
			Board.text = "You undo your lower clothing as you were sitting, exposing your own pussy and tell her that you would like a good lick from her. \"Let me take care of it then,\" she says with a mischievous smile, and and kneels in front of your chair, giving a good lick to your snatch while giving you an excited look. You can feel her soft hands massaging your labia as drops of her saliva slip off her tongue and soak it completely. You can see how she pants a bit, as she started to suck off your clit slightly, as she is getting lust-drunk from your female scent.\n\nAfter a couple of licks of courage, she plunged her tongue inside your as far as she can and uses her tongue to play with your inner walls. You are surprised that she is capable of sucking and licking that good, but now you are sure that this isn’t one of her first times in this area of expertise. After a pair of seconds, she pulls out a bit and started frenzying all over your pussy. You can feel her tongue rolling around your clit again and again, making you pant faster and faster. You can smell that she is getting excited by the cunnilingus, her body trembling with lust every time she darts her tongue and lips all over your cunt.\n\nYou can feel how your own body trembles, as you feel that you are close to cumming. When you know that you are at the edge of orgasm, you use your hands to held her head as she has her tongue inside you, releasing a load of femspunk into her mouth and face, as you look that her eyes are of complete surprise. She has to hold your legs as she is being soaked in it.\n\nAfter a pair of seconds, she licks the streaks of juice that she has on her mouth, panting as she looked at you. \"That was hot… If this is losing, i almost don’t mind it… Almost.\" she says as she cleans her jaw with her arm. \"I—I think i have to do something on the back...\" she says, while rubbing her pussy from below her skirt as she almost stumbles to the back of the wagon, probably to relieve herself. You hide your genitals once more in your clothing and leave the caravan for the time being.\n";
		}
	}

	public void event1B(){
		//concede
		endTurnFun ();
		Board.text = "Your curiosity wins at the end. You place your cards facedown on the table and say that you give up and that she won the bet, trying your best to conceal the truth from her. Quickly, you realize that she didn’t care about the truth at all. She left her own set of cards on the table and slowly rises from her chair. \"I’m just good at this game. Don’t feel bad about it,\" she walks towards you and places a hand on your chin. \"We made a deal, and a deal is made to be paid. \" She says in a tone that makes you think that it’s something that’s a common phrase among the gypsies of that caravan.\n\nShe sits on the table just next to you, and so you find out what she wanted you to do: To have a taste of her. She lays on her back as she pulls you to her, spreading her legs. She surely knows what she wanted to do on that day, because you can see that she is not wearing any underwear below her long skirt. You have a good look at her womanhood, her cunt is getting wetter the more you look at it, perhaps due to the position she is right now and the fact that you’re staring at her pussy, as streaks of lubricant slowly drip into the table. \"Come o~n, I’m waiting.\"\n\nYou started touching it, teasing her slowly with your hands, and every time you do it, her body contorts and relaxes in a cycle as her body fills with desire. You can see how she tries to push her cunt near you, the more you play with it. Finally, you have a taste of her, licking her nether lips around all her sexual fluids, not minding its strong taste at all. You can see how she starts clawing the table a bit, as her breath is getting deeper every time your tongue laps her pussy. The scent of her arousal is getting stronger and stronger, turning you on more and more, your mouth soaked by her sloppy sex, focused only on enjoying her cunt and her moans of pleasure, which are increasing by the second.\n\nYou suddenly feel how she traps you with one of her legs, pushing you against her vagina, as she cums hard, soaking half your face with her femjuice as she lets out a big moan of delight, holding you in place until her orgasm finally stops. You take a deep breath after she releases you from her grasp as she tries to recover her composure.  \"...Oh, boy. Your mouth feels as good as it looks...\" She says, still panting. You rise and leave her to her mumblings with a smile of satisfaction on your face, retiring from the caravan for now.\n";
	}


	public void event2A(){
		if (GameControl.attPhysical >= 50) {
			Board.text = "As you run up a hill, you only hear some bushes moving near you and you feel a sting on your neck. You touch that place, finding that a dart pierced your skin, probably laced with something noxious. You turn to see three people with feline features running towards you, spears ready and pointing at you. You don’t know if you’re supposed to feel different, as your body seems to endure the dart’s poisonous effects. You prepare yourself with your weapon, as they try to stab you with their weapons, their true intentions yet unknown.\n\nYou dodged their attacks with some difficulty, but avoided most of the harm as you start to feel a bit aroused. Probably an aphrodisiac\"laced dart. You caused them more trouble with your weapon and your body, as you are mostly focused on the combat at hand. \n\nYou can feel how their will to fight and their lust shifted quickly, as one of them tries to trap you with a net, but you avoided the attack and use the net on the lioness instead. They see that they are losing rather quickly, as they seem to be novice combatants. After a bit, they surrender and quickly leave a strange bottle in the ground, in exchange for letting them go. You barely take the bottle as you see them sprinting off your presence. You check your wounds as you hear the voice of your bodyguard getting closer.\n\nAfter you reunite with it, you return to the city to wait for the effect of the aphrodisiac to wear off.\n";
			endTurnFun ();
			WorldControl.dropItem = 1019;
			addItemScript.addItemScript ();
		} else {
			Board.text = "As you run up a hill, you only hear some bushes moving near you and you feel a sting on your neck. You touch that place, finding that a dart pierced your skin, probably laced with something poisonous. You turn to see three people with feline features running towards you, spears ready and pointing at you. You feel dizzy, yet you prepare yourself with your weapon, as they try to stab you with their weapons, their true intentions yet unknown.\n\nYou try to dodge with the best of your ability, but you feel hot and dizzy. You can feel how your groin is on fire and how you can’t take your eyes from their naughty bits. At least the pain from the first wound shakes you enough to focus on the combat.\n\nThe combat continued, as you suffered more damage than the one you did. One of them tries to use a net on you, but you avoided it and kick it away from you, before attacking them once more. They see that this fight is not worth the risk anymore, because you can see how they start to retreat, taking most of their stuff with them. You lay for a moment on the ground, your lower clothing soaked in your fluids as you rest for a bit, until you hear the voice of your bodyguard close to you, to which you fall unconscious from the mix of pain and lust that is boiling inside you. After a couple of hours, you wake up in your castle.";
			GameControl.actualArousal += 20; 
			endTurnFun ();
		}



	}

	public void event2B(){
		Board.text = "As you run up a hill, you only hear some bushes moving near you and you feel a sting on your neck. You touch that place, finding that a dart pierced your skin, probably laced with something noxious. You turn to see three people with feline features running towards you, spears ready and pointing at you. You don’t know if you’re supposed to feel different, as your body seems to endure the dart’s poisonous effects. You prepare yourself with your weapon, as they try to stab you with their weapons, their true intentions yet unknown.\n\nYou dodge the attacks as you start talking to them, asking the reason of why they are attacking you. \"We won’t be fooled by the wicked lies of one of the Lost!\" They think that you are one of the Lost?! They must still be new in this. You ask them why they think that, as you fall back a couple of meters without taking your eyes off them, especially the pointy ends of their spears.\n\nThey look at each other and then they look at you. \"Because you are on the plains and you are not of the Tribes.\" You explain them that you are not a Lost, especially since you are more dressed. Speaking of clothing, its hard to keep it on you, as you start feeling hotter, probably from the dart. \"A Lost would never stop to talk… Why are you here? No one crosses these plains alone anymore\" You explain that your business it’s only yours and that he is someone important from the close city of Aurorum, that this won’t go unpunished.\n\nThe woman of the group. \"Wait! Perhaps we can get to some arrangement\" To which she takes out a small potion. \"If we give this to you, you’ll forgive us for this?\" You tell them that potion is a good payment. They give it to you and they leave the place, obviously spooked from your intimidating tone of voice. You check your wounds as you hear the voice of your bodyguard getting closer.\n\nAfter you reunite with it, you return to the city to wait for the effect of the aphrodisiac to wear off.";
		WorldControl.dropItem = 1015;
		endTurnFun ();
	}



	public void event3A(){
		Board.text = "You turn to see him, telling him that despite his cheating, they are somehow even. And that only shows that she is stronger than him, and that he requires trickery to emulate her normal combat style.  The man raises his hands into the air and starts walking out of the building. \"That’s it! I’m ou! Fuck both of you!\" Until his voice stopped being heard by both of them.\n\nShe claps excited several times while looking at you. \"Thanks for that. Perhaps… I’ll see you later, when this asshole is all over his head once more\" She says, slapping your thigh as she slowly walks outside the place, before turning to see you at the entrance of the building. \"It’s good to see people that aren’t that mad about winning at all costs\" She leaves the place, leaving you wondering if this is how you were before the Plague, or this is due to the taint of it.\n";
		GameControl.charCorruption -= 1; 
		endTurnFun ();
	}

	public void event3B(){
		endTurnFun ();
		GameControl.charCorruption += 1; 
		Board.text = " You turn to see her, telling her that even though she is playing by the rules, they will use that on her advantage. And with that way of thinking, she will only get herself ravaged by the monsters in the wild, or worse, transform completely into a Lost. The woman crosses her arms and moves her head to the side. \"I won’t stand talking to the ones like you one second longer! I’m done!\" She walks out of the building quickly, obviously frustrated.\n\nHe nods and sighs in relief as he turns his eyes to you. \"Finally! Thanks, [SIR/MA’AM]. I’m pretty sure that she didn’t learn anything about this, so maybe she’ll require several doses of this conversation, so i’ll see you around\" He says, slapping your thigh as he walks outside. \"It’s good to see that someone is willing to do anything to get what they want. We need more people like you, people like me...\" He says before leaving the place, leaving you wondering if this is how you were before the Plague, or this is due to the taint of it. ";
	}



	void Awake(){
		//WorldControl.PortraitID = 0;
		dicksize = parser.callDickName();
		WorldControl.location = "Plains"; 
		randomEvents ();
	}

	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		panEndTurn.sortingOrder = 500;

	}



}
