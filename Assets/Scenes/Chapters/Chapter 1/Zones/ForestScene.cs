using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ForestScene : MonoBehaviour {
	public Text Board; 
	int randNum; 
	int i;
	int yoshika; // used to find them
	int misaki;  // used to find them in the NPCCharList.Charlist[misaki]
	public Canvas Event1;
	public Canvas Event2;
	public Canvas Event3;
	/*public RectTransform Event4;
	public RectTransform Event5;
	public RectTransform Event6;
	public RectTransform Event7;

	public RectTransform Event9;
	public RectTransform Event10;*/
	public Canvas Event4;
	public Canvas panEndTurn; 


	public Canvas npc4000meet; 
	public Canvas npc5000meet; 



	public Button npc4000option1; // 60 phys
	public Button npc4000option2; // 50 phys
	public Button npc4000option3; // 50 social 


	public Button npc5000option1; // 60 phys
	public Button npc5000option2; // 50 phys
	public Button npc5000option3; // 50 social 

	string mcpronoun; 
	string mcname; 


	AddItemScript addItemScript = new AddItemScript();


	public void events(){





		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 100);
		i = 0; 

		while (i < 2) {


			if (randNum > 70 && WorldControl.day > 2 && WorldControl.day <= 4) {
				Random.InitState (System.DateTime.Now.Millisecond);
				randNum = Random.Range (0, 100);

				if (randNum > 50) {
					encounterMisaki ();
					break;
				} else {
					encounterYoshika ();
					break;
				}


			}else if (randNum > 20 && WorldControl.day > 4 && WorldControl.day <= 7) {
				Random.InitState (System.DateTime.Now.Millisecond);
				randNum = Random.Range (0, 100);

				if (randNum > 50) {
					encounterMisaki ();
					break; 
				} else {
					encounterYoshika ();
					break;
				}

			}else if (WorldControl.day > 7 && NPCControl.npc5000Meet == false ){
				encounterYoshika ();
				break;

			}else if(WorldControl.day > 7 && NPCControl.npc4000Meet == false){
				encounterMisaki ();
				break; 
			}else if(WorldControl.day > 8 && NPCControl.npc4000follower == false && randNum >= 50){
				encounterMisaki ();
				break; 
			}else if (WorldControl.day > 8 && NPCCharList.CharFollower[yoshika].isRecruited == false && randNum >= 50){
				encounterYoshika ();
				break;

			}


			else {
				randomEvents (); 
				break; 
			}


		}

	}//

	public void randomEvents(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 100);
		WorldControl.NPCID = 0; 
		//WorldControl.PortraitID = 0;
		if (randNum > 90) {
			//event 1 
			Event1.sortingOrder = 500;
			WorldControl.location = "Forest - Slave Caravan"; 
			Board.text = "You think that the forest is unusually quiet, as you haven’t found any hostile encounter with any Lost on your roaming. Perhaps you are lucky, or maybe something else is scaring them. In any case, you continue you wanderings until you hear something unusual happening nearby. It sounds like a hurried escape, but you can hear it coming towards your direction.\n\nAfter a couple of seconds you see someone bolting out of the bushes. You were on guard as you see it trying to regain its breath. It is a humanoid figure, but it is hard to tell if it is female or male, as it had a lot of transformations on its body. The transformed one looks at you, and then looks around. -Please, i beg of you! I don’t want to go back to that cage! You must help me!- You see that only a couple of rags were covering it and it is in a bad condition. You know that it's a bit broken, because it's waiting for your answer, instead of just bolting out of sight as fat as he can as if you are some kind of authority for him. Or maybe it knows that it's impossible to escape the traders without some kind of help.. \n\nYou sharpen your senses, and you can hear the faint yelling of someone in the distance. They are probably slave traders, and you can bet that this person escaped from one of the wagons. It didn’t seems to be Lost, at least not completely. Perhaps it isn’t completely Lost yet, or maybe the traders are trying to break it then sell it, and that’s illegal. But you didn’t know which of those were the real situation and the time is running short. Maybe you can catch the escaping prisoner and wait for them to arrive, or you can let it escape and divert the attention of its pursuers.\n"; 
		} else if (randNum > 80) {
			Event2.sortingOrder = 500;
			WorldControl.location = "Forest - Lost explorers"; 
			Board.text = "As you explore the different parts of the forest, you came across a small group of explorers, who seems to be foreigners according to its clothing and accent. The one that is holding a map sees you, getting close to you as the others were wary of your intentions. You don’t blame them too much, the world isn’t like your mentor taught you.\n\nThe man keeps his distance from you. -I’m sorry. We got lost in the way here. And we were searching for some natural formation… Do you care to help us to navigate through the forest?- He points the map. -We don’t require for you to lead us personally, but if you could help us with the map...-\n\nYou take a good look at the places that were marked on the map. Lucky for them, you knew the place they were searching for. You trace two ways to get there, one of them is the safest but they would require to take a long detour but you could lead them for a part of the place. The other option was a straight line to their objective, but it was a place that was plagued by monsters. You take a good look at the other members of the group, many of them had splendid bodies. It would be nice for you to see them having a little a more sexual workout with the monsters that roamed the forest. Decisions, decisions.\n"; 
		} else if (randNum > 70) {
			Event3.sortingOrder = 500;
			Board.text = "You couldn’t help but hear from time to time to some of the citizens, that there are some strange shadows looming across the forest. It’s something that is starting to worry the community as they don’t look like Lost, according to the shadows. As there isn’t any other town or settlement close by, and the next city is through a mountain pass, you couldn’t help but try and investigate the issue. Your worries are that they could be bandits that knew how to avoid the Lost, just the same way that your mentor knew how to survive in the wilds.\n\nAfter a couple of hours without finding anything, you stumble across a strange symbol that is somehow painted in one of the trees. It looks like three spirals joining together in the center by 3 lines. You could see that the painting was slowly fading from sight, as if it’s temporary. You discover another one of those symbols in a tree nearby, and found out that they were leading you to a certain place of the forest still unknown to you. You wonder if a bandit is able to pull off a trick like this.\n\nAfter following those signs for quite a while, you came upon a small clearing of the forest. In the middle of it there is a lantern that emanated a strong light that covered the clearing. Around it you see that there are a good amount of people fucking each other, surrounding the light closely in some sort of ritual. You can see them almost in a trance, focused on rubbing their cocks and cunts on the others as much as they could, as the debauchery goes on and on. One female covered in what seems to be ceremonial tattoos gets close to you. -I see we have ourselves another Drifter- She points to a group on the other side of the orgy. -You can come with us and be enlightened with us, or perhaps, you would require to bath in the gift of our Goddess first- As she point to the orgy that is close to both of you. You ponder in your next choice, or maybe you could try and return later?"; 
		} else if (randNum > 60) {
			Random.InitState (System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 5);
			switch (randNum) {
			case 0:
				WorldControl.dropItem = 101; 
				break; 
			case 1:
				WorldControl.dropItem = 106; 
				break; 
			case 2:
				WorldControl.dropItem = 111; 
				break; 
			case 3:
				WorldControl.dropItem = 116; 
				break;
			default:
				WorldControl.dropItem = 121; 
				break; 
			}

			endTurnFun ();
			Board.text = "You wander through the forest, climbing up slopes and walking down hillsides. The terrain is quite uneven, so you understand why is so hard to deal with anything that happens in here. Its somehow relaxing, as you remember hiking through places like these. \n\n\nAs you stroll, you found out a potion, laying on the ground. You take it and found out that isn’t broken. Probably from one of the guards that succumbed to the Plague. You take it with you as you know that it's rightful owner won’t need it anymore, and return to the city.\n"; 
			addItemScript.addItemScript ();


		} else if (randNum > 50) {
			endTurnFun ();
			Board.text = "As you stroll through the forest, you found out a place where a battle took place at some point. There are marks of combat on the trees along with dried blood. You can see that there are a couple of dried stains of fluids lingering in the ground. You start to get what happened to the person that fought there.\n\n\nYou wonder how many of this places are around the Forest. How many people have succumbed to the Lost that wander through these places? You don’t try to think much about it, as you return to the city, before the transformed victim comes to reclaim whatever is left from him in that place."; 
		} else if (randNum > 40) {
			endTurnFun ();
			Board.text = "The forest is an untamable place that surrounds Aurorum, so you try to explore it without straying too far from the roads, to see what is going on in it. After a bit, you can hear a small female moan. You sneak up on the origin of the sound and found out that it came from a small bunny girl.\n\n\nThere was a werewolf banging her against a tree, making her moan wildly and loudly. He was holding her with his claws as she tries to escape while he rams her cunt with his long cock. Even though you see her trying to release his grip, you can see that it’s more of a roleplay than truly an attempt, her tongue hanging out from her mouth as her eyes are filling with pleasure.\n\n\nAfter a bit of fucking, you see that he cums on her, as she can’t hold that much spunk inside her and spills it into the ground. You decide to escape before the wolf turns around and searches for someone else to sate his lust, returning to the city without making a sound."; 
		} else if (randNum > 30) {
			endTurnFun ();
			Board.text = "After a while, you found out a small river so you decide to take a rest and drink some water. As you got closer, you found out a couple of persons that probably thought the same as you. They were a man and a woman, both with foxlike features.\n\n\nYou wonder about them for a second and try to greet them, but you can see that they take a step back when you try to talk to them. When you take another, they pick their stuff and flee quickly from the edge of the river. You stand there for a second, looking through the place where they left and found out that they dropped a couple of coins. You take them, as you think that they will not return here for a while. And with that, you return to the city."; 
			GameControl.charGold += 10; 
		} else if (randNum > 20) {
			Event4.sortingOrder = 500;
			Board.text = "As you wander through the deepest parts of the forest, you found out a small lagoon. You can see that it’s reeking with the taint of Plague and Plague-infected fluids. Probably this is a place that helps the spread of it among the Lost.\n\n\nYou could take a small bath in it. Something inside you pulls you to do it, to make you a bit more free.\n"; 
		} else  {
			endTurnFun ();
			Board.text = "You wander for a couple of hours on the Forest, but couldn’t find anything interesting on the road, so you return to the city."; 
		} 

	}


	// phys 60
	public void NPC4000Event1A(){

		Board.text = "You agree to help Misaki, and she gives you directions to reach her former village. Once you have the place in sight, you can see that the place is very small, less than a dozen of huts, with a big fireplace in the middle. You can see some people around, all of them of the similar kind than Misaki. \n\nWhen you approach, you can see that they are not as aggressive as you thought they were going to be, although they still look at you with caution. Right in the middle there is a very big individual standing. You wave at him, and he welcomes you with a nod. He asks you what is your reason to come to that place, and you tell him that you are the new " + mcpronoun + " of the city of Aurorum. He doesn’t seem impressed by that, or cares about it, and asks you again what are You dressing for.\n\nYou decide to be straightforward and you explain him that a friend of you asked you to be her champion, and you challenge him to a duel for the necklace that his spouse is wearing. -Uh so that whore sent you to do her dirty work?... I thought that " + mcpronoun + "s or Kings were smarter than that- Oh, now you ARE a " + mcpronoun + ". -...but very well, if you want to fight, you got it.- He smiles at you and walks away, doing a hand gesture to follow him.\n\nYou walk just outside the village, a place with no obstacles where both of you can fight without interference. You take out your weapon, while he takes a massive club. When the duel starts, he attacks at you faster than you expect. You fear that a single hit would be enough to knock you out, but the adrenaline inside you helps you to dodge the attack as you get closer to him. You manage to give precise attacks on his legs and hands, making him slower and clumsier, until you manage to move on his back and strike the back of his knee, forcing him to kneel. \n\nHe yields before you strike him again, and praises your ability. -You are tougher than You dress… Well, I guess I have no choice but to give you the necklace… I just hope you can have a clean conscience for taking my family inheritance away, just to fulfill the whim of that bitch.- At this point, you notice that the stories of Misaki and the chief are very different, and after asking him about her he tells you that she was a thief and a slut, seducing the few men on the tribe and asking them for their treasures, until he got fed up by her attitude and decided to kick her out. \n\nYour first reaction is to apologize, but the chief tells you that it is better to fight and lose against you than against mercenaries, and that if losing that jewel will be enough to get rid of her, well… It’s a high price, but he is willing to pay for it. You nod and you assure him that if anything, you will make sure that the jewel is well protected and safe.\n\nJust before you leave, the chief stops you again. -I hate to admit this, but you are stronger than I am… Since you are an important " + mcpronoun + ", consider this a tribute to your cause… In  exchange, of course, of respecting our tribe and providing us by security.- He hands you a small, bright bottle… Is a purity elixir! indeed this should be enough tribute for the years to come. You even wonder how a small tribe like this got his hand in such item, but nonetheless to agree to their terms. . \n\nWhen you find Misako again she comes back at you, jumping with happiness when she sees the shiny object in your hand from far away.-Hooray! You did it! Thanks my cham…!- You interrupt her, confronting her with what you just learned. She doesn’t seem too angry, or even annoyed by your questions, as if she was already expecting this. -Ow come on, I know I deceived you at first, but the chief was mean to me you know… And, wouldn’t you agree that this thing looks better on me?.- You ask her why she had to lie to you and she just rolls her eyes. -Don’t take it personal, is just you would be more… Motivated to help if I was a damsel in distress, I am wrong? Plus… I didn’t lied about everything, if you give me that, I will go to your city and be your loyal and faithful vassal… Well, at least loyal - She seductively licks her lips, and you believe that you understand what she means by that. \n\nFine, you tell her, and hand her the jewel as you explain that you need someone to take care of the Inn, that’s been empty for a while, that if she would like to take care of the place, sharing the profits with you of course. -That doesn’t sound bad at all… Okay, lead the way.- \n\nOnce you are back you show her the city, she seems pretty impressed by it. -The last time I visited a city I was a kid and… Well, I had forgotten how massive a place like this can be, and a lot of interesting people to… To befriend! Yes...- \n\nWhen you show her the inn she seems pretty content with it, even if the place is all dusty and in need of maintenance, the place is clearly an improvement from living in the wild, or in a hut. You show her what she needs to do and give her some time to accommodate herself. -Dont worry, I will have this working in no time!.- You leave, hoping she is as energetic at working as she probably is at fucking.\n\nYou now can find Misaki hanging in the inn on your city. "; 
		NPCControl.npc4000follower = true; 
		int x; 
		x = 0; 
		while (x < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower[x].charID >= 4000 && NPCCharList.CharFollower[x].charID < 5000){
				NPCCharList.CharFollower [x].isRecruited = true; 
				break; 
			}
			x++;
		}


		WorldControl.dropItem = 156; 
		addItemScript.addItemScript ();
	}

	//phys 40
	public void NPC4000Event1B(){
		Board.text = "You agree to help Misaki, and she gives you directions to reach her former village. Once you have the place in sight, you can see that the place is very small, less than a dozen of huts, with a big fireplace in the middle. You can see some people around, all of them of the similar kind than Misaki. \n\nWhen you approach, you can see that they are not as aggressive as you thought they were going to be, although they still look at you with caution. Right in the middle there is a very big individual standing. You wave at him, and he welcomes you with a nod. He asks you what is the reason for you to come to that place, and you tell him that you are the new " + mcpronoun + " of the city. He doesn’t seem impressed by that, or cares about it, and asks you again what are You dressing for.\n\nYou decide to be straightforward and you tell him that a friend of you asked you to be her champion, and you challenge him to a duel for the necklace that his spouse is wearing. -Uh so that whore sent you to do her dirty work?... I thought that " + mcpronoun + "s or Kings were smarter than that- Oh, now you ARE a " + mcpronoun + ". -...but very well, if you want to fight, you got it.- He smiles at you and walks away, doing a hand gesture to follow him.\n\nYou walk just outside the village, a place with no obstacles where both of you can fight without interference. You take out your weapon, while he takes a massive club. When the duel starts, he attacks at you faster than you expect. You fear that a single hit would be enough to knock you out, but the adrenaline inside you helps you to dodge and get closer to him. You manage to give precise attacks on his legs and hands, making him slower and clumsier, until you manage to move on his back and strike the back of his knee, forcing him to kneel. \n\nHe yields before you strike him again, and praises your ability. -You are tougher than You dress… Well, I guess I have no choice but to give you the necklace… I just hope you can have a clean conscience for taking my family inheritance away, just to fulfill the whim or that bitch.- At this point, you notice that the stories of Misaki and the chief are very different, and after asking him about her he tells you that she was a thief and a slut, seducing the few men on the tribe and asking them for their treasures, until he got fed up by her attitude and decided to kick her out. \n\nYour first reaction is to apologize, but the chief tells you that it is better to fight and lose against you than against mercenaries, and that if losing that jewel will be enough to get rid of her, well… It’s a high price, but he is willing to pay it. You nod and you assure him that if anything, you will make sure that the jewel is well protected and safe, before leaving. \n\nJust before you leave, the chief stops you again. -I hate to admit this, but you are stronger than I am… Since you are an important " + mcpronoun + ", consider this a tribute to your cause… In  exchange, of course, of respecting our tribe and providing us by security.- He hands you a pouch with 150 pieces of gold, which indeed should be enough tribute for the years to come. You even wonder how a small tribe with no trade has so much gold, but nonetheless you agree to his terms. \n\nWhen you find Misako again she comes back at you, jumping with happiness when she sees the shiny object in your hand from far away.-Hooray! You did it! Thanks my cham…!- You interrupt her, confronting her with what you just learned. She doesn’t seem too angry, or even annoyed by your questions, as if she was already expecting this. -Ow come on, I know I deceived you at first, but the chief was mean to me you know… And, wouldn’t you agree that this thing looks better on me?.- You ask her why she had to lie to you and she just rolls her eyes. -Don’t take it personal, is just you would be more… Motivated to help if I was a damsel in distress, I am wrong? Plus… I didn’t lied about everything, if you give me that, I will go to your city and be your loyal and faithful vassal… Well, at least loyal - She seductively licks her lips, and you believe that you understand what she means by that. \n\nFine, you tell her, and hand her the jewel as you explain that you need someone to take care of the inn, that’s been empty for a while, that if she would like to take care of the place, sharing the profits with you of course. -That doesn’t sound bad at all… Okay, lead the way.- \n\nOnce you are back you show her the city, she seems pretty impressed by it. -The last time I visited a city I was a little girl and… Well, I had forgotten how massive a place like this can be, and a lot of interesting people to… To befriend! Yes...- \n\nWhen you show her the inn she seems pretty content with it, even if the place is all dusty and in need of maintenance, the place is clearly an improvement from living in the wild, or in a hut. You show her what she needs to do and give her some time to accommodate herself. -Dont worry, I will have this working in no time!.- You leave, hopping she is as energetic at working as she probably is at fucking.\n\nYou now can find Misaki hanging in the inn on your city. "; 
		NPCControl.npc4000follower = true; 
		int x; 
		x = 0; 
		while (x < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower[x].charID >= 4000 && NPCCharList.CharFollower[x].charID < 5000){
				NPCCharList.CharFollower [x].isRecruited = true; 
				break;
			}
			x++;
		}
		GameControl.charGold = GameControl.charGold + 150; 
		endTurnFun ();
	}

	// social 50
	public void NPC4000Event1C(){
		Board.text = "You agree to help Misaki, and she gives you directions to reach her former village. Once you have the place in sight, you can see that the place is very small, less than a dozen of huts, with a big fireplace in the middle. You can see some people around, all of them of the similar kind than Misaki. \n\nWhen you approach, you can see that they are not as aggressive as you thought they were going to be, although they still look at you with caution. Right in the middle there is a very big individual standing. You wave at him, and he welcomes you with a nod. He asks you what is the reason for you to come here, and you tell him that you are the new " + mcpronoun + " of the city. He doesn’t seem impressed by that, or cares about it, and asks you again what are You dressing for.\n\nYou decide to be straightforward and you explain him that a friend of you asked you to be her champion, and you challenge him to a duel for the necklace that his spouse is wearing. -Uh so that whore sent you to do her dirty work?... I thought that " + mcpronoun + "s or Kings were smarter than that- Oh, now you ARE a " + mcpronoun + ". -...but very well, if you want to fight, you got it.- He smiles at you and walks away, doing a hand gesture to follow him.\n\nYou walk just outside the village, where both of you can talk alone. -Look, that is a relic from my past, my inheritance but… But our tribe is dying, slowly, but it's dying. The Plague of course is the main culprit… Nonetheless, I guess me, as chief, need to do some sacrifices too. I will give you the relic, but in exchange we want you to create a trade route through our village. We will make sure to give protection to the traders and guidance, in exchange of food and goods. Don't worry... our people is not greedy.- He pauses and turns around, looking at this village, and wondering if this is the right choice. -It hurts me to depart from that item, but I hope you find the exchange reasonable.- You decide to agree with his terms. Although at this point it is clear that Misaki deceived you to get the necklace, at least something good will come out from this exchange. \n\nYou ask about Misaki, and he explains to you that she is a thief and a slut, that loves seducing the few men on the tribe and asking them for their treasures. He eventually got tired of this, and the complainings of every female on the village, and decided to kick her out. \n\nBefore you leave, the chief stops you again. -Wait, I’ll have something for you… I guess building roads can be expensive, so we can give you this much to help you with that.- He hands you 50 gold coins, a small fortune for people like this, although you suspect they have more. You thank him for his effort, and promise him to deliver as soon as you can. \n\nWhen you find Misako again she comes back at you, jumping with happiness when she sees the shiny object in your hand from far away.-Hooray! You did it! Thanks my cham…!- You interrupt her, confronting her with what you just learned. She doesn’t seem too angry, or even annoyed by your questions, as if she was already expecting this. -Ow come on, I know I deceived you at first, but the chief was mean to me you know… And, wouldn’t you agree that this thing looks better on me?.- You ask her why she had to lie to you and she just rolls her eyes. -Don’t take it personal, is just you would be more… Motivated to help if I was a damsel in distress, I am wrong? Plus… I didn’t lied about everything, if you give me that, I will go to your city and be your loyal and faithful vassal… Well, at least loyal - She seductively licks her lips, and you believe that you understand what she means by that. \n\nFine, you tell her, and hand her the jewel and explain that you need someone to take care of the Inn, that’s been empty for a while, that if she would like to take care of the place, sharing the profits with you of course. -That doesn’t sound bad at all… Okay, lead the way.- \n\nOnce you are back you show her the city, she seems pretty impressed by it. -The last time I visited a city I was a little girl and… Well, I had forgotten how massive a place like this can be, and a lot of interesting people to sed… To befriend!- \n\nWhen you show her the inn she seems pretty content with it, even if the place is all dusty and in need of maintenance, the place is clearly an improvement from living in the wild, or in a hut. You show her what she needs to do and give her some time to accommodate herself. -Dont worry, I will have this working in no time!.- You leave, hopping she is as energetic at working as she probably is at fucking.\n\nYou now can find Misaki hanging in the inn on your city."; 
		NPCControl.npc4000follower = true; 
		int x; 
		x = 0; 
		while (x < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower[x].charID >= 4000 && NPCCharList.CharFollower[x].charID < 5000){
				NPCCharList.CharFollower [x].isRecruited = true; 
				break;
			}
			x++;
		}
		GameControl.charGold = GameControl.charGold + 50; 
		endTurnFun ();
	}

	// none 
	public void NPC4000Event1D(){
		Board.text = "You agree to help Misaki, and she gives you directions to reach her former village. Once you have the place in sight, you can see that the place is very small, less than a dozen of huts, with a big fireplace in the middle. You can see some people around, all of them of the similar kind than Misaki. \n\nWhen you approach, you can see that they are not as aggressive as you thought they were going to be, although they still look at you with caution. Right in the middle there is a very big individual standing. You wave at him, and he welcomes you with a nod. He asks you what is the reason for you to approach them, and you tell him that you are the new " + mcpronoun + " of the city. He doesn’t seem impressed by that, or cares about it, and asks you again what are You dressing for.\n\nYou decide to be straightforward and you tell him that a friend of you asked you to negotiate in her behalf for the necklace that his wife is wearing. -Uh so that whore sent you to do her dirty work?- He gives you a defiant look. You don't want to waste more time than you need with these people, and you just tell him that you as " + mcpronoun + " have also the command of an army, and that if you want, you can plunder the whole place for the necklace. \n\nHe looks at you with hateful eyes, fists ready to strike, and the tension arising as you have a hand over the grip of your weapon, but in the end, he yields. -Fine, you can take the relic, but understand this, that fucking bitch is deceiving you, the same way that she fucked and deceived all of the men, and some of the women, on the village. Whatever she told you, it’s a lie, this relic has been in my family for generations.- He goes back to the village, and comes back five minutes later, relic in hand. -Take it and never come again, we have nothing else for you… Just don't expect that slut to be faithful to you, she will fuck whatever she has in front of her.- With those last words he turns around and walks back to his home. \n\nWhen you find Misako again she comes back at you, jumping with happiness when she sees the shiny object in your hand from far away.-Hooray! You did it! Thanks my cham…!- You interrupt her, confronting her with what you just learned. She doesn’t seem too angry, or even annoyed by your questions, as if she was already expecting this. -Ow come on, I know I deceived you at first, but the chief was mean to me you know… And, wouldn’t you agree that this thing looks better on me?.- You ask her why she had to lie to you and she just rolls her eyes. -Don’t take it personal, is just you would be more… Motivated to help if I was a damsel in distress, I am wrong? Plus… I didn’t lied about everything, if you give me that, I will go to your city and be your loyal and faithful vassal… Well, at least loyal - She seductively licks her lips, and you believe that you understand what she means by that. \n\nFine, you tell her, and hand her the jewel and explain that you need someone to take care of the Inn, that’s been empty for a while, that if she would like to take care of the place, sharing the profits with you of course. -That doesn’t sound bad at all… Okay, lead the way.- \n\nOnce you are back you show her the city, she seems pretty impressed by it. -The last time I visited a city I was a little girl and… Well, I had forgotten how massive a place like this can be, and a lot of interesting people to… To befriend! Yes...- \n\nWhen you show her the inn she seems pretty content with it, even if the place is all dusty and in need of maintenance, the place is clearly an improvement from living in the wild, or in a hut. You show her what she needs to do and give her some time to accommodate herself. -Dont worry, I will have this working in no time!.- You leave, hoping she is as energetic at working as she probably is at fucking. \n\nYou now can find Misaki hanging in the inn on your city."; 
		NPCControl.npc4000follower = true; 
		int x; 
		x = 0; 
		while (x < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower[x].charID >= 4000 && NPCCharList.CharFollower[x].charID < 5000){
				NPCCharList.CharFollower [x].isRecruited = true; 
				break; 
			}
			x++;
		}
		endTurnFun ();
	}




	// phys 60
	public void NPC5000Event1A(){
		Board.text = "You decide to enter the place and fight whatever is inside, as you feel secure of your capabilities. You instruct Yoshika to wait for you at the entrance and help you with his bow at every chance he can get a clean shot. He nods at you request, so you enter the cave, unsheathing your " + ItemData.itemDataList [GameControl.charEquipment [0]].itemName +" and preparing yourself for the encounter. The cave is strangely well-lit, as if something is glowing faintly on the walls of the place. Perhaps it’s more supernatural than you thought at first place. There is the sound of something mumbling and ruffling, at what you think is the end of the cave.\n\nA shadow moves from the bottom of the stone corridor towards your direction, until you can see it clearly. It’s a moose that is huge, almost twice your size and is holding what seems to be an axe that barely fits into one of its hands. The monster lets out a powerful roar before lunging at you and throwing a powerful slice in your direction. You use your " + ItemData.itemDataList [GameControl.charEquipment [0]].itemName +" to block the attack of your opponent from its flat part of the axe, contesting the strength of the creature. You yell to Yoshika that it’s his chance. The creature battles you with it’s raw force, as you push him back momentarily just in time to see an arrow hitting him in his head.\n\nYou push forward against him, hitting him with your weapon as you can see that from time to time, another arrow flies and hits your opponent. You can see how it tries to escape towards the entrance of the place, so you slam him with your body and attack him with your weapon, forcing him to face you, deflecting every attack that the creature throws at you. Almost every arrow hit its mark, as you keep him off your long-range combatant. Finally, you see how that creature falls to his knees, completely inert. When you are almost sure that the battle is finished, you call for Yoshika. \n\nBoth of You dress at the remains of the creature, and both of you are spectators of how its flesh almost evaporates, until there is nothing more than bones. That is surely something strange, but you can see that the deer is focused on them. -My Master told me about this...- He stands up and walks to them as you decide to follow him and piles them up in a pile. As he takes out a bottle of his clothing and pours it over the bones of that monster, you see that at the end of the cavern, you found a small bottle that contains a liquid that you can’t recall for now, so you take it for further investigation. You can see that the bones start to dissolve just like the flesh until there is nothing left of that creature. You ask him what he just did, to which he turns to see you and nods. -I brought him peace, at last. Or at least that’s what my Master said it does-\n\nYou tell him that he has no other reason to stay here. The deer looks at the place where the pile was. -You are correct. But I have nowhere else to go- You tell him that you have a place on your city. That you’ve been searching someone that could help you with a gymnasium. A place where other people could train properly. You can see him look at the floor below you and then kneeling in front of you. -I will do it, my [" + mcpronoun + "]. But I don’t know if it’s too much to ask, but i would like to keep residing in my hut. There is the tomb of my father, after all- You tell him that it’s no big deal. Both of you return to the cabin, then to the city. \n\nYou now can find Toshika hanging in the Gym on your city."; 
		NPCCharList.CharFollower [yoshika].isRecruited = true; 
		int x; 
		x = 0; 
		while (x < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower[x].charID >= 5000 && NPCCharList.CharFollower[x].charID < 6000){
				NPCCharList.CharFollower [x].isRecruited = true; 
				break; 
			}
			x++;
		}
		endTurnFun ();
	}

	//phys 40
	public void NPC5000Event1B(){
		Board.text = "You decide to enter the place and fight whatever is inside. You instruct Yoshika to wait for you at the entrance and help him with his bow at every chance he can get a clean shot. He nods at you request, so you enter the cave, unsheathing your " + ItemData.itemDataList [GameControl.charEquipment [0]].itemName +" and preparing yourself for the encounter. The cave is strangely well-lit, as if something is glowing faintly on the walls of the place. Perhaps it’s more supernatural than you thought at first place. There is the sound of something mumbling and ruffling, at what you think is the end of the cave.\n\nA shadow moves from the bottom of the stone corridor towards your direction, until you can see it clearly. It’s a moose that is huge, almost twice your size and is holding what seems to be an axe that barely fits into one of its hands. The monster lets out a powerful roar before lunging at you and throwing a powerful slice in your direction. You use your " + ItemData.itemDataList [GameControl.charEquipment [0]].itemName +" to barely deflect the attack of your opponent, pushing you against the side of the cave. You yell to Yoshika that it’s his chance. The creature raises the axe as you ready your weapon once more, before you see an arrow hitting him in his head, dazing him just enough time for you to get out of the wall.\n\nYou can see that every 4 seconds approximately, a new arrow flies through the air and into that creature. You can see how it tries to run towards the stag that is at the entrance of the place, so you slam him with your body and attack him with your weapon, forcing him to face you, but you can’t avoid one of the hits of the axe’s blade, wounding you severely. Almost every arrow hit its mark, as you keep him off your long-range combatant. Finally, you see how that creature falls to his knees, completely inert. You feel how you are bleeding from the wounds, so you sit and call for Yoshika. Before he could arrive, your hand touches something. You found out a pristine potion that isn’t broken, so you pack it among your belongings. He hurries inside the place and finally see that the creature is dead and that you are hurt. He runs to you and looks at your wounds. -You’ll be fine- \n\nBoth of You dress at the remains of the creature, and both of you are spectators of how its flesh almost evaporates, until there is nothing more than bones. That is surely something strange, but you can see that the deer is focused on them. -My Master told me about this...- He stands up and walks to them, piles them up in a pile, takes out a bottle of his clothing and pours it over the bones of that monster. You can see that the bones start to dissolve just like the flesh until there is nothing left of that creature. You ask him what he just did, to which he turns to see you and nods. -I brought him peace at last. Or at least that’s what my Master said it does-\n\nYou know that standing up is painful, but you do it anyway. You tell him that he has no other reason to stay here. The deer looks at the place where the pile was. -You are correct. But I have nowhere else to go- You tell him that you have a place on your city. That you’ve been searching someone that could help you with a gymnasium. A place where other people could train properly. You can see him look at the floor below you and then kneeling in front of you. -I will do it, my [" + mcpronoun + "]. But I don’t know if it’s too much to ask, but i would like to keep residing in my hut. There is the tomb of my father, after all- You tell him that it’s no big deal. He helps you to return to the cabin and then, to the city.\n\nYou now can find Toshika hanging in the Gym on your city."; 
		NPCCharList.CharFollower [yoshika].isRecruited = true; 
		int x; 
		x = 0; 
		while (x < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower[x].charID >= 5000 && NPCCharList.CharFollower[x].charID < 6000){
				NPCCharList.CharFollower [x].isRecruited = true; 
				break; 
			}
			x++;
		}
		endTurnFun ();
	}

	// social 50
	public void NPC5000Event1C(){
		Board.text = "You decide to scout the place and investigate what is inside first. You instruct Yoshika to wait for you at the trees nearby and help you with his bow at every chance he can get a clean shot. He nods at you request, so you enter the cave, unsheathing your " + ItemData.itemDataList [GameControl.charEquipment [0]].itemName +" and preparing for your escape, in case anything goes wrong. The cave is strangely well-lit, as if something is glowing faintly on the walls of the place. Perhaps it’s more supernatural than you thought at first place. There is the sound of something mumbling and ruffling, at what you think is the end of the cave.\n\nA shadow moves from the bottom of the stone corridor towards your direction, until you can see it clearly. It’s a moose that is huge, almost twice your size and is holding what seems to be an axe that barely fits into one of its hands. The monster lets out a powerful roar before lunging at you and throwing a powerful slice in your direction. You dodge the attack completely and prepare your evasive maneuvers, as you run out of the cave, being followed closely by that creature. You yell to Yoshika that it’s his chance. The creature keeps trying to get a hold of you as you run at full speed, as you see how an arrow hits him directly into his head, but it doesn’t stop him at all.\n\nYou know that you can’t stop and risk a dangerous wound from such a weapon, so you keep running through the forest and hope that Yoshika can follow you two while keeping a steady supply of arrows with him. You can see the monster as he tries to get you but you dodge every attack by moving through the trees, You remember the slope that you saw on your way here, so you improvise on the fly. You guide him to that place, until the slope is in front of you. You turn to see the creature almost in front of you, eyes focused on your own. You can see Yoshika on the corner of your eye, you just yell him to slam him as you roll towards the legs of that creature. The monster fails its attack but the deer slams it with his body, pushing him towards the slope, making him fall into a small group of rocks, his body being crushed by the fall. You can see that both of you are panting from the exercise, You dress at him then both of You dress at the place where he landed, it’s not that far from your location.\n\nBoth of You dress at the remains of the creature, and both of you are spectators of how its flesh almost evaporates, until there is nothing more than bones. That is surely something strange, but you can see that the deer is focused on them. -My Master told me about this...- He stands up and descends slowly to them, as you decide to follow him and piles them up in a pile. As he takes out a bottle of his clothing and pours it over the bones of that monster, you see that next to those rocks, you found a small pouch half torn that contains 100 gold, that you pouch, better with you than rotting in that place. You can see that the bones start to dissolve just like the flesh until there is nothing left of that creature. You ask him what he just did, to which he turns to see you and nods. -I brought him peace, at last. Or at least that’s what my Master said it does-\n\nYou tell him that he has no other reason to stay here. The deer looks at the place where the pile was. -You are correct. But I have nowhere else to go- You tell him that you have a place on your city. That you’ve been searching someone that could help you with a gymnasium. A place where other people could train properly. You can see him look at the floor below you and then kneeling in front of you. -I will do it, my [" + mcpronoun + "]. But I don’t know if it’s too much to ask, but i would like to keep residing in my cabin. There is the tomb of my father, after all- You tell him that it’s no big deal. Both of you return to the cabin, then to the city.\n\nYou now can find Toshika hanging in the Gym on your city."; 
		NPCCharList.CharFollower [yoshika].isRecruited = true; 
		int x; 
		x = 0; 
		while (x < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower[x].charID >= 5000 && NPCCharList.CharFollower[x].charID < 6000){
				NPCCharList.CharFollower [x].isRecruited = true; 
				break; 
			}
			x++;
		}
		endTurnFun ();
	}

	// none 
	public void NPC5000Event1D(){
		Board.text = "You are not completely sure of your abilities at this point, so you decide to go with the flow of the moment. You instruct Yoshika to wait for you at the entrance and help him with his bow at every chance he can get a clean shot. He nods at you request, so you enter the cave, unsheathing your " + ItemData.itemDataList [GameControl.charEquipment [0]].itemName +" and preparing yourself for the encounter. The cave is strangely well-lit, as if something is glowing faintly on the walls of the place. Perhaps it’s more supernatural than you thought at first place. There is the sound of something mumbling and ruffling, at what you think is the end of the cave.\n\nA shadow moves from the bottom of the stone corridor towards your direction, until you can see it clearly. It’s a moose that is huge, almost twice your size and is holding what seems to be an axe that barely fits into one of its hands. The monster lets out a powerful roar before lunging at you and throwing a powerful slice in your direction. You have no time to think, and the enemy slices your chest with his attack, wounding you more than you expected and pushing you aside. You keep standing and holding your " + ItemData.itemDataList [GameControl.charEquipment [0]].itemName +" in hand, as you feel the blood dripping from your chest. You try to attack the monster, but you get wounded even more in the process. When you think that the battle went south completely, an arrow hits him on his head, dazing him enough for you to climb onto his back and hold from his neck, trying to strangle him with the strength that you can muster..\n\nYou can see that every 4 seconds approximately, a new arrow flies through the air and into that creature. You can see how it tries to run towards the stag that is at the entrance of the place, but you keep the pressure on its neck, forcing him to pay attention to you, which is a very painful thing. Almost every arrow hit its mark, as you keep him off your long-range combatant. Finally, you see how that creature falls to his knees, completely inert. You fall with him and roll, leaving a trail of blood behind you, as you barely call for Yoshika. He runs to you and looks at your wounds. -You are bleeding hard. We must return soon- \n\nBoth of You dress at the remains of the creature, and both of you are spectators of how its flesh almost evaporates, until there is nothing more than bones. That is surely something strange, but you can see that the deer is focused on them. -My Master told me about this...- He stands up and walks to them, piles them up in a pile, takes out a bottle of his clothing and pours it over the bones of that monster. You can see that the bones start to dissolve just like the flesh until there is nothing left of that creature. You ask him what he just did, to which he turns to see you and nods. -I brought him peace at last. Or at least that’s what my Master said it does-\n\nYou can’t stand on your own, so you talk to him from the floor as he improvises some bandages. You tell him that he has no other reason to stay here. The deer looks at the place where the pile was. -You are correct. But I have nowhere else to go- You tell him that you have a place on your city. That you’ve been searching someone that could help you with a gymnasium. A place where other people could train properly. You can see him look at the floor below you and then kneeling in front of you, after he bandaged you enough to be moved. -I will do it, my [" + mcpronoun + "]. But I don’t know if it’s too much to ask, but i would like to keep residing in my hut. There is the tomb of my father, after all- You tell him that it’s no big deal, after all you saved his life, partially. He carries you to the cabin and then, to the city.\n\nYou now can find Toshika hanging in the Gym on your city. "; 
		NPCCharList.CharFollower [yoshika].isRecruited = true; 
		endTurnFun ();
		int x; 
		x = 0; 
		while (x < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower[x].charID >= 5000 && NPCCharList.CharFollower[x].charID < 6000){
				NPCCharList.CharFollower [x].isRecruited = true; 
				break; 
			}
			x++;
		}
	}





	public void npc4000Buttons(){
		if (GameControl.attPhysical < 50) 
		{
			npc4000option1.enabled = !npc4000option1.enabled; 
		}
		if (GameControl.attPhysical < 40) 
		{

			npc4000option2.enabled = !npc4000option2.enabled; 
		}

		if (GameControl.attSocial < 40) 
		{

			npc4000option3.enabled = !npc4000option3.enabled; 
		}
	}

	public void npc5000Buttons(){
		if (GameControl.attPhysical < 50) 
		{
			npc5000option1.enabled = !npc5000option1.enabled; 
		}

		if (GameControl.attPhysical < 40) 
		{
			npc5000option2.enabled = !npc5000option2.enabled; 
		}

		if (GameControl.attMental < 40) 
		{
			npc5000option3.enabled = !npc5000option3.enabled; 
		}
	}

	public void npc5000QuestHunt(){
		Board.text = "You tell him that you have nothing more important to do at this moment, to which he tells you that he will guide you to the cave where this creature is. The road is eventless, as Yoshika seems to know the better roads to take just to get in there as quickly as possible. Probably he has been traversing this same road every day to the den of the beast. You see a small cliff along the way.\n\nAfter several minutes of walking through the forest, the deer stops you with a motion of his hand. After that, he crouches and points at a cave that is close ahead from your location. There are several strange symbols over it, that you can’t quite understand. Maybe Yoshika made them to warn others?\n\n-He is there- After saying that he turns to see you and stays there, obviously waiting for further instructions. You have to think of a good way of dealing with this situation. You know that Yoshika seems to be good with his bow, and you still have your weapon with you.\n";
	}

	public void npc4000QuestPrevious(){
		Board.text = "You agree to help her, and after some planning, you come up with several plans to deal with the situation. Dueling the chief is the most straightforward and honorable approach, winning against will earn you both the prize and the respect of the tribe, but this depends more on your physical ability. On the other hand you could try to negotiate with him, considering the state of the place, promising trade and better relations will be worth for a trinket. On the other hand, you could just menace the tribe with the troops that you have back at the city, although expect to earn their hatred for this. \n\nNOTE: We recommend to have an empty slot item for the duel that requires 60 on your physical stat.";
	}


	/// <summary>
	/// EVENTS
	/// </summary>



	// Catch the slave
	public void Event1A()
	{
		Board.text = "You take the decision that it's not up to you to choose the fate of the slave. Perhaps is a Lost that’s not fully broken but its halfway there, or perhaps it’s his destiny for not being strong enough. So you start talking to it, trying to calm it down. The slave is nervous at first, but when it hears the sound of footsteps close to both of you, it tried to run away once more.\n\nYou don’t lose the opportunity, so you tackle it and pin it against the ground. You can feel how it tries to struggle with you at first, trying to break itself free but it is futile. After a pair of seconds of struggle, you see that it stopped fighting and relaxed his muscles in total submission. You can see that it's well endowed, perhaps it will fetch a good price in the auction.\n\nJust after that, you see a man coming out of the trees being followed by a couple of soldiers, both of them with mancatchers. The one that seems to be in charge looks at you and the slave, as one of the soldiers caught it in the mancatcher, as the other lifts it from the ground as the man helps you to get up. -Good to see that you saved us a lot of trouble with this one. Who are you?- He pats you on the shoulder. You tell him that you are someone important from the city nearby. He claps his hands. -Good to know, we’re already on our way there to the slave trading post. Perhaps we can make a good donation to the place for the help- You think that its because the slave is not completely broken, maybe to shut you up. You nod pleasantly as you tell him that you have some business to do in the forest, that you’ll see the results when you return. -Good to hear that! Then, we’ll be on our way- He says, before motioning their henchmen to return the way they came. You dust off your clothes and continue through the forest for a little bit more, before returning to the city.\n\nWhen you come back to the city, Helena tells you that some men donated some gold for your cause, 30 gold! Although you feel that your soul changed by your actions.";
		GameControl.charGold = GameControl.charGold +30; 
		GameControl.charCorruption = GameControl.charCorruption + 3; 
	}

	//help the slave
	public void Event1B()
	{

		Board.text = "You think that trying to break someone just for coins is not a good thing at all. Maybe this slave is someone that got the shorter side of the stick and ended up there, or even worse, maybe is someone innocent that someone sold for its benefit. You couldn’t let something like that happen in front of you.\n\nSo you told the slave to hide behind a rock nearby, but it is too scared to move by itself. It seems that the rush of energy stopped when it stopped escaping. You could hear the faint rumbling through the forest nearby, so you grab it by its ragged clothes and drag it across the place until you push it behind some rock formation that is close and command him to stay hidden.\n\nAfter that, you grab a rock and threw it in the other direction. Just after the rock lands, you see a man coming out of the trees, being followed up close by a couple of soldiers, both of them with mancatchers. The man leading them yells at you. -Where is the slave?- You try your best to look tired and point out the direction that you threw the rock, telling them that you tried to stop it but it is too fast for you, but it went that way. They look at each other and nod, running through the direction that you pointed at. \n\nAfter a minute or so, you return to the rock formation and pointed to the slave to run in the other direction, that is somehow close to Aurorum. The slave hugs you for a second, as you could feel its well-endowed body against yours as it ask you for your name. You say that you are someone important from the city of Aurorum. The slave thanks you several times, before running in the direction you pointed, getting lost quickly through the trees. After that, you only wonder if it will find a good place to stay after this whole ordeal. You hope for the best, as you return to the city.\n\nWhen you come back, Helena informs you that someone delivered a letter thanking you, and informing you that he will help others as you did with him. You feel that your soul is changed by your actions! ";
		CityControl.city100Corruption = CityControl.city100Corruption - 0.5f; 
		GameControl.charCorruption = GameControl.charCorruption - 2; 

	}
	public void Event2A()
	{
		Board.text = "You marked a road that they can take to find the place that they wanted to reach. And that the road of the city that you came from wasn’t that far from it, so you could guide them for a small length. The man that leads the expedition nods in agreement, then goes to talk with the rest of the group. After a minute or so, he returns. -That would be great. I will assure you that you will be rewarded properly for this service-\n\nYou mark the pace of the expedition. They ask you questions about the place, if you happened to see some symbols on the trees or things like that. They say that they are researching the oldest cultures of the islands, as some of them have strange rituals that require a forest to work. That makes you wonder of all the things you have seen during the last days. You point a group of monsters that seems to be fucking each other in the distance, as you move through a passing, as most of them have a horrified look in their faces. As all of you crossed a small river, you avoid an accident as you pulled someone from the rapids before it got lost down river.\n\nWhen you pointed the way that was left, most of the explorers thank you for your help with genuine smiles of relief. The leader of the expedition hands you a bag that contained 20 gold coins -Here. Take this. I hope is useful in your journeys- He says, before walking away with the rest of the expedition, waving you goodbye before marching on their way. You sighed in relief, before returning to Aurorum with a new item in your hand.\n\nAlthough the money isn’t that much for you, you feel relieved and better with yourself for helping them."; 
		GameControl.charGold = GameControl.charGold + 20; 
		GameControl.charCorruption = GameControl.charCorruption - 2; 
	}
	public void Event2B()
	{
		Board.text = "You decide that you would have some fun with the explorers. You explain to him that there is a direct route to the place they were looking for. You mark on the map the straight route they can take, but hid the fact that the place is overrun with Lost. The man that leads the expedition nods in agreement, then goes to talk with the rest of the group. After a minute or so, he returns. -That would be great. I thank you for your help with the directions. Have a safe journey!- He says goodbye before being followed by the other members of the expedition. You have a last look at their outstanding figures, before they leave.\n\nAfter a couple of minutes, you start jogging through another route, as you didn’t wanted to miss a thing of the show that was about to start in a bit. You went uphill for a bit as you have to avoid them completely at the same time as you must be able to see them properly.\n\nYou got just in time, as you see the expedition resting on a clearing that was close. You just saw how a pack of werewolves arrive just in time. They overpowered them easily, as they weren’t much of a fighting group. They tried to run but they were pinned against the ground, as the wolves ripped off their clothes. You can see how they started ravishing them as much as they could. One of them pinned one woman against a tree, fucking her vigorously with great force. Another one was forcing a male to suck his cock, its mouth barely holding such amount of meat coming in and out. A pair of Lost wolves ganged on some of the members of the group, staining them with their semen.\n\nThe thing that you were waiting happened. You started to hear moans coming out from the explorers, their faces fixed in a state of pleasure that only increased as they continued the breeding. You smile with satisfaction as they started to enjoy it, probably with the help from traces of the plague that inhabit in the Lost bodies. After a while of enjoying how they were being filled and covered in cum, you return to your city, hearing of the echoes from the cries of lust that you leave behind until they fade into the forest. You can’t wait for new explorers to come searching for the same place. ";
		CityControl.city100Corruption = CityControl.city100Corruption + 0.5f; 
		GameControl.charCorruption = GameControl.charCorruption + 2; 
	}
	public void Event3A()
	{
		Board.text = "You tell her that you are more interested in the \"Enlightenment\" thing, across the pit of lasciviousness that is happening too close to them. She nods in acceptance and guides you to the circle of people that she pointed to you at first. There were several other persons in it, most of them having almost a blank stare in their eyes. You sit next to them as the woman with the tattoos gives you a small berry. -Here. Take this to open your mind- You see the fruit in your hands and shook a bit. You engulf the berry at once and close your eyes for a second. -Now... open your eyes-\n\nYou open your eyes, and start to see the world a bit more blurred. You can see that the colors around you are getting brighter and brighter, your perception of your surroundings changing completely. You no longer feel yourself in the clearing of the forest, you can see that you are now inside some structure made of stone. You feel compelled to walk through a corridor, that you keep walking for hours, or at least that’s what you feel.\n\nWhen you finally see an end to the corridor, you found yourself on what seems to be a luxurious bedroom. There is a fancy bed in the middle of it, which is being occupied by a gorgeous lady of white skin. Her shapely curves sends your mind wandering into lustful thoughts. Her breasts appear to be amazingly soft and you feel the urge to squeeze them just by looking at them. Her body is so gorgeous that you wonder for a second if she has been carved, rather than grown.\n\nYou can see that she has her eyes locked on you. She stands from her bed and slowly walks to you, a long gown marking her silhouette. -It's good to see you here- She says, pushing you carefully into the ground and laying herself on top of you. The sensation of her body against yours makes it harder to focus on her voice. \n\nShe has her face floating a couple inches over your face, her lips barely touching yours. -Don’t resist… You are mine now.- She said, her hands slowly running over your torso. But before she can continue, you feel how your sight is going blurry once more. The only thing that you can hear before everything goes black is her voice: -I’ll get you, sooner or later...-\n\nYou wake up in the middle of the clearing, but now it was empty, there were no signals of them nowhere. You stand up and shook your head a bit. Was that a dream? Or something else? It felt so real. You stumbled on your way back, as your senses returned to normal."; 
		GameControl.charCorruption -= 3; 
	}
	public void Event3B()
	{
		Board.text = "You tell her that you don’t yet feel ready for the “Enlightenment. She nods and guides you to the spree that is coursing around the light. -Let the Lantern guide you on the way, don’t fight it...- She says, before stepping back as you take a good look at that artifact. The light was a bit dazzling, yet you can look into it without hurting your eyes that much. As you focus on it, you can feel how your body started to walk on its own. At first you try to fight, but after a bit you see that it's futile. Your body slowly walks towards the light as you undo your " + ItemData.itemDataList [GameControl.charEquipment [1]].itemName + "  and drop it into the ground, until you are next to the other people, which turns to see your arrival and made you join their ravings, with a mesmerized look on their face.\n\nOne of them starts by licking your neck, its lust was skin deep as it has a taste of your body. Without warning, you feel a pair of silky and generously stocked breasts pressing against your back, its nipples rubbing against your skin with impatience, as she started moaning just by the friction of her tits over your back. Another one didn’t waste any time and sat on your lap, rubbing her cunt against your crotch and belly, moaning close to your face as if she was going crazy. You see how your hands grab her by her bubbly ass, giving it a good squeeze, as you feel how your lust increases more and more.\n\nYou felt yourself moving against your will, your body was searing hot and the only thing that could ease that rising heat was touching and rubbing every breasts, any crotch or ass that you could reach. At first it wasn’t something that isn’t you, but as the time passes you can feel how it starts to be your doing. As the light embraces you, the only thing that you can think is satiate that carnal desire that flows within you. The night continues like that, as you drowned in the pleasure of the orgy along with the other members of it, until you passed out.\n\nYou woke up the next morning, its body aching by the workout of the last night. Your body has the smell of sexual fluids all over it. Your mind couldn’t remember quite well the whole ordeal, but you feel… relaxed. You keep wondering if the “Gift” is no more or less about the Plague. They definitely act like Plagued people. You dress around, but there isn’t a trace of them or the lantern. Perhaps you’ll try and find them again soon. With that in mind, you return to the city to clean yourself."; 
		GameControl.charCorruption += 3; 
	}

	public void event4A(){
		Board.text = "You dip in its waters, feeling its influential taint enveloping you slowly, seeping into your mind."; 
		endTurnFun ();
		GameControl.charCorruption += 5; 

	}


	public void event4B(){
		Board.text = "You resist the urge to taint yourself with it and return to the city before you change your mind.";
		endTurnFun ();

	}










	void encounterMisaki(){
		i = 0; 
		while (i < 2) {


			if (NPCControl.npc4000Meet == false) {
				WorldControl.furryPic = true; 
				WorldControl.NPCID = 4000; 
				//WorldControl.PortraitID = 4050;
				NPCControl.npc4000Meet = true; 
				npc4000meet.sortingOrder = 500;
				Board.text = "You deeply wander through the forest, so deep in fact that after an hour of walking around in denial you accept the fact: You are lost. \n\nThe place is almost completely silent, you can’t even hear animals with the exception of crows that are heard very far away. You try to find your way back with no avail. When you are tired, and wondering what you gonna do, you hear a very faint noise of footsteps right behind you. You move and turn back in no time, taking a fighting stance, just to realize that a beautiful fox girl is in front of you. \n\nShe is pretty voluptuous, with dark brown hair and fiery red eyes, along with four fluffy tails, her fur orange, wearing skimpy clothes. \n\nShe looks at you with curiosity, and once you get down your guard she waves her hand, giving you a broad smile. -Hi adventurer! I assume you are lost, since we are very far away from the main road… Or maybe you are looking for something?.- She raises her eyebrows and keeps smiling as she talks to you in a no threatening way. She definitely isn’t one of the Lost. You explain to her that you were just exploring the zone, but you indeed got lost a couple of hours ago. \n\n-Mmmh… I see, that sounds bad… Do you know that you are in territory of the Isamu Tribe? A very ferocious and deceiving group, let me tell you…- She takes some time to explain to you about them, and how she was from that tribe. She tells you how recently her ex-husband, former chief, died in a duel with the new champion, and how he stole all of her possessions before kicking her out. \n\n-So, that’s my story. I’ve been living here in the wild for the last few weeks trying to… Nevermind, what I mean is that I still have some unfinished business left before I can move out.- You ask her what business she could have, but at first she is reluctant to say, telling you that she is the one that has to deal with it, for honor. Usually you would let it go, but her condition, and her clearly distressed face makes you question her a bit more. \n\n-Well… If you insist, I guess there is no harm in telling you. My ex husband gave me a necklace, a very beautiful one done with the gold-plated bones of a big beast and one big ruby. He gave it to me when we married, but they took it from me when they kicked me out… Now, I assume is in the possession of the chief’s wife. I’ve been trying to sneak out to recover what is mine by right, but I have failed so far.- \n\nYou tell her that maybe the best thing to do is just to let that behind and find a new life. You even tell her that you may have a good place for her to work and stay in your city. -Uh… do you have a city? Are you a king of something like that? That’s pretty fantastic!... But, I hope you understand that I really need that necklace…- Her excitement goes away quickly once she comes back to her reality. -Look, I tell you what, you seem pretty able yourself, maybe you can take back the amulet for me? If you do so, I will become your loyal assistant and serve you, sounds like a good deal, right?.- She gives you a seductive smile, pushing her breasts outwards to make them look even bigger than they already are. -Oh and by the way… My name is Misaki, a pleasure to meet you…- She blows you a kiss, and you present yourself too. \n\nYou can help her right now and try to deal with the tribe. You probably would have to duel the chief, or otherwise convince him to give the item to you. If you decide to leave now, you can find her again while exploring the forest. \n"; 
				break;
			} else if (NPCControl.npc4000Meet == true && NPCControl.npc4000follower == false) {
				WorldControl.furryPic = true; 
				WorldControl.NPCID = 4000; 
				//WorldControl.PortraitID = 4050;
				npc4000meet.sortingOrder = 500; 
				Board.text = "You find Misaki again, still wandering alone in the forest. You get close to her and ask how she’s been doing. She tells you the usual: Life is hard, but she manages. You ask her if she is ready to move on but she insists on the necklace, seems like you will not change her opinion on that.\n\nAs the last time, you can help her right now and try to deal with the tribe. You probably would have to duel the chief, or otherwise convince him to give the item to you. If you decide to leave now, you can find her again while exploring the forest. \n"; 

				break;
			} else {
				WorldControl.NPCID = 0; 
				//WorldControl.PortraitID = 0;
				randomEvents ();
				break; 
			}
			i++;
		}

	}

	void encounterYoshika(){
		i = 0; 
		while (i < 2) { 
			if (NPCControl.npc5000Meet == false) {
				WorldControl.furryPic = true; 
				WorldControl.NPCID = 5000; 
				//WorldControl.PortraitID = 5050;
				NPCControl.npc5000Meet = true; 
				npc5000meet.sortingOrder = 500;
				Board.text = "As you wander through the forest, you hear something unnerving around you. You didn’t hear at first the pair of steps that you’re used to, instead, you hear two pairs of steps coming towards you at full speed. You only have time to move to the side, just to avoid whatever got out from the bushes. In the nick of time, you see a feral werewolf trying to stomp you with a slam but failing to do so. Just when you thought that you avoided the immediate danger, you feel a hit that pushes you away for a pair of meters, making you roll on the dirt for a second.\n\n\nAs you raise your head, you see an stud standing where you were a moment ago, his cock fully erect and his eyes focused on you. As you turn around, you see the feral werewolf drooling and his dick completely hard as well. This is a very bad situation for you, but you wouldn’t go down without a fight. When the wolf jumps to get you, a roll was enough to avoid its attack and to get on your feet, just in time to see the stallion trying to grapple you, but a strike in the face was enough for him to give you space.\n\n\nWhen you thought that this would get worse from now on, you heard a scream that echoed through that part of the forest. -LEAVE!- Just before an arrow flies and hits the wolf in its arm. The beast screams in pain as another arrow hit its side and made him recoil a couple of steps. You weren’t planning on letting go this chance unanswered, and lunge forward towards your equine opponent. You lower your body to dodge its attack and swing your weapon directly at his chest. Your opponent growled in pain from the wound now it had on its chest, but you attack a second time, as you keep hearing the arrows flying around you. The stallion lashes out, but you have enough space to punch him in the face, sending him staggering against a tree nearby. The werewolf, confused of where the attacks are coming from, retreated from the scene as quickly as it came in. The stud didn’t lose more time and flees the scene as well, through another part of the forest.\n\n\nYou catch your breath for a second, as you finally catch a glimpse of someone running into the scene. It was a deerlike men, holding a longbow on its back. It is wearing a set of large dark-toned clothes and and a long skirt that you’ve seen in some people in Kujiang. -Can you move? We need to leave this place. This is a crossroad for many of the Broken, we can’t stay here too much time- And with that being said, he guides you to a clear part of the forest, that has a small cabin located just next to a creek. He guided you inside it and gives you water to wash your wounds. When he felt that both of you were out of danger, he finally continued talking. -My name is Yoshika. And i’m the Guardian Prince of the Forest. I couldn’t bear to see those wretched creatures attacking you, so i intervened. Sorry it took me that long to help you...- You presented yourself. -"+ GameControl.playerName + "... I see. Nice to meet you then- \n\n\nYou look around, finding only that the place is quite humble and ask him what he does in the middle of the forest. -It is my sacred duty to protect these Forest, just like my father did it, and his father did it...- You didn’t knew about a “Guardian Prince” in this forest. You tell him that you’re the "+ mcpronoun +" of the city that is inside the forest. You tell him that he doesn’t require to protect these place alone, that you can help him to do that.\n\n\nHe looks through the window. -I can’t leave just yet. There is still a danger that lurks on the deep of these place that I must deal with… Or at least, I’m supposed to- You ask him what he means with that last thing.\n\n\n-Since my Master died, I’m no longer capable of dealing with those dark forces. I feel that I’m not strong enough to deal with them- You can see how he almost crushes the cup that he is holding, probably from impotence. You think about it for a second, and you got curious about this creature. Perhaps it’s something that you will have to deal with, eventually. So you tell him that maybe you can help him fight it, perhaps even finally beat it.\n\n\nYou can see that he raises his ears at your offer and looks at you closely. -That would be marvelous!- He says, standing up once more and walking to get his bow once more. You prepare but he stops for a second and turns to see you. -Are you sure? I don’t know how long this would take, and maybe you have other things to do at this moment- You think about that, he is right. You try to think if you have other things to do before chasing some dangerous monster in the Forest.\n";
				break;

			} else if (NPCControl.npc5000Meet == true && NPCCharList.CharFollower[yoshika].isRecruited == false) {
				WorldControl.furryPic = true; 
				WorldControl.NPCID = 5000; 
				//WorldControl.PortraitID = 5050; 
				npc5000meet.sortingOrder = 500;
				Board.text = "After a bit of wandering, you finally stumble once more into Yoshika’s home. You knock the door and luckily he answers after a bit. -Wonderful!, " + GameControl.playerName + ". Have you come to help me with my situation?-"; 
				break; 

			} else {
				WorldControl.NPCID = 0; 
				//WorldControl.PortraitID = 0;
				randomEvents ();
				break; 
			}
			i++; 
		}
	}




	void followersLoader(){
		int i = 0; 
		while (i < NPCCharList.CharFollower.Count) 
		{/////
			if (NPCCharList.CharFollower [i].charID >= 5000 && NPCCharList.CharFollower [i].charID < 6000) {
				yoshika = i; 
			}
			if (NPCCharList.CharFollower [i].charID >= 4000 && NPCCharList.CharFollower [i].charID < 5000) {
				misaki = i; 
			}

			i++;
		}/////

	}



	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		panEndTurn.sortingOrder = 500;

	}


	void Awake (){
		WorldControl.NPCID = 0; 
		//WorldControl.PortraitID = 0; 
		events (); 
		npc4000Buttons (); 
		npc5000Buttons ();
		WorldControl.location = "Forest"; 

		if (GameControl.mcGender == GameControl.MCGender.FEMALE) {
			mcpronoun = "Lady"; 
		} else {
			mcpronoun = "Lord"; 
		}

	}

}
