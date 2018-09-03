using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class Alba : MonoBehaviour {


	public Text Board; 
	static int iAlba;

	static int confirmationControl; 


	public Canvas endTurnPanel; 
	//public Canvas panContinue;


	public Canvas panConfirmation;

	public Canvas panMainPanel;

	public Text option0Name;
	public Text option1Name;
	public Text option2Name;

	public Button option1Butt; 

	public Button option2Butt; 



	public void albaStart(){
		switch (QuestControl.albaQuest)
		{
		case 0: // intro 
			Board.text = "Following your maid’s suggestion, you visit the old industrial district. You see that the place, following suit with the rest of the city, is almost in ruins. Very few shops and businesses are open, and the streets are full of drifters. While it is bad, it is not the worst of the districts.     \n\nIn the middle of the district, a tall building stands surrounded by walls, proudly displaying Furiosa’s house banners. As you approach its gates, a couple of guards stop you, asking you to identify yourself. At first they are reluctant to let you inside, but their protests are quickly interrupted by a woman yelling obscenities at them from the third floor of the house, ordering them to stop fooling around and let you inside. They quickly apologize, and open the gates. Once inside, you see a servant ready to welcome you at the entrance of the house. She asks you to follow her to a living room on the second floor, and then proceeds to bring you some snacks while you wait for Alba.\n\nOnly a short time passes before you see her walking down the staircase, wearing clothes so skimpy that it’s almost difficult to distinguish her from a common whore from the red district. She moves her hips in a seductive way as she walks towards you. <i>“I apologize for my guard, he is an idiot. I’ve heard nice things about you "+ GameControl.playerName +", though I can’t help but wonder if you have what it takes.”</i> She shamelessly inspects your body, examining every inch of it. Before you can protest, she sits on your lap and leans into you. <i>“Well, you aren’t bad looking, that’s a good start.”</i> You feel her hand playing with your hair before you push her off your lap and ask her what she is doing. <i>“Oh my, no need to be rude darling. Are you here for business? That’s a shame, but we can still have fun later, right?”</i> You ignore her offer, and start to talk with her about her house and business. Although she behaves like a bimbo half the time, it seems that she actually knows a great deal about her district and how business works, it’s just that the topic is not of much interest to her. \n\n<i>“What, you thought I was a bimbo? I own almost half of the city, of course I’m not. If I was I would be in the same boat as that idiot of House Junia. Now that’s someone who can’t get shit done. But the fact I am not one, doesn’t mean I can’t act like one, you know...”</i> She puts a hand on your knee before laughing, and getting back to business.\n\n<i>“Fine, I think it’s time to be serious. Look, the whole city is hurting, and I’m the only one who has the ability to really save it. You think those circuses in Abbadon’s district will create jobs or profit? No, what you need is me and my businesses.”</i> She asks a servant to bring wine for the two of you. Once served, she proceeds to finish her cup in a single gulp. <i>“Listen, you’ll have my support. You just need to take care of a couple of things first. I doubt it’s anything that you can’t handle… and if you can’t, you are certainly not prepared to take care of that throne.”</i>\n\nShe waits for your answer. You think about what Helena told you; that Alba is in a very fragile position, wherein most of her district dislikes her, but she has little real support from other houses. You know you could use this to your advantage, and refuse to do her bidding for free. Of course, you could just help her and earn her loyalty, which would definitely make it easier to take care of the city.";
			option0Name.text = "Aid her";
			option1Name.text = "Coerce her";
			confirmationControl = 0; 
			panConfirmation.sortingOrder = 500; 

			break;
		case 1: //Rally the troops   // taking the mines for coerce route, thats a battle and not here
			panConfirmation.sortingOrder = 500; 
			Board.text = "You ask Alba to get everyone gathered in front of her mansion. Once they are there, you move onto a small podium, ready to give your speech. You talk about the importance of working together to have a greater hope for the future, and why it’s critical to take the corrupted beasts out, especially from the mines, and reclaim what rightfully belongs to the city.\n\nSome of the people cheer and applaud, but you can see that your words don't have as much effect as you’d expected. <i>“Told ya, they are a tough crowd,”</i> says Alba, before a group of citizens begins to yell questions. <i>“What’s in it for us?!”</i> says a fisherman <i>“Yeah! Why we would risk our lives for your mines?”</i> says a butcher. One by one, the crowd joins these people in asking for a good reason to support you.\n\nAlba grabs your arm and whispers to you <i>“Come on "+ GameControl.playerName +", you need to promise them something. You thought about that right?”</i> You nod silently, and turn to face the crowd again.\n\nYou really didn’t think much about this, expecting them to help you and the city since they would obviously benefit from it, directly or indirectly, but it seems that those benefits are neither specific nor obvious enough.\n\nWith your quick wits, you think you could offer them wealth, by allowing them to ransack and keep whatever they’re able to pillage from the enemy, or you could offer them the use of slaves captured in battle. Which will be your offer?";
			option0Name.text = "Wealth";
			option1Name.text = "Slaves";
			confirmationControl = 2; 
			break;
		case 2: // taking the mines for help route, thats a battle // Riots for coerce, only if bribe
			WorldControl.day += 2;
			int i = 0;
			while (i < NPCCharList.CharRetainers.Count) {
				if (NPCCharList.CharRetainers [i].charID == 1000100) {
					break; 
				}
				i++;
			}
			if (NPCCharList.CharRetainers.Count > 0) {
				if (NPCCharList.CharRetainers [i].isRecruited) {
					WorldControl.day += 7; 
					Board.text = "As Alba predicted, the population isn’t happy with your employment of the brigands, and they’ve been showing their discontent by rioting at the gates of your castle for the last week. Your maid Helena is at your side, wringing her hands nervously. <i>“This looks bad... we have food for a month I believe my liege, if you were wondering.”</i> You begin to weigh your options when the bunny thief sneaks up behind you. <i>“Hey "+ GameControl.playerName +", worrying about what’s going on outside?”</i> You turn and immediately scold her, telling her that it is her and her men’s faults. <i>“Hey, it’s not easy to adapt to this new life! I’m doing what I can to keep them in check!”</i>\n\nYou dismiss her, and she leaves without saying anything else. \n\nYou ask Helena what she thinks. <i>“Uh... I’ve never been in a situation this difficult, but you could go down there and negotiate with the people. Ask them what they want, maybe offer them something.”</i> She pauses, and you see that she’s uncomfortable <i>“Or you could do what has been done in the past: Just use your new retainers to crush them. That’s... pretty evil, but morale in this city is very low, so they won’t keep causing trouble if you take care of them that way.”</i>\n\nYou sigh and wonder. Should you try to negotiate with them? Or send the bandits to crush them?\n";
					option0Name.text = "Negotiate";
					option1Name.text = "Crush";
					confirmationControl = 101; 
					panConfirmation.sortingOrder = 500; 
				} else {
					QuestControl.albaQuest = 3;
					albaStart ();
				}

			} else {
				QuestControl.albaQuest = 3;
				albaStart ();
			}

			break;

		case 3: // Forging the future 
			Board.text = "You go to Alba’s house, where you are immediately welcomed inside and led to an enormous hall. When you get there, you can see Alba and a variety of diverse noblemen and women of the city enjoying a feast. <i>“"+ GameControl.playerName +"! Welcome! Please join us, we are celebrating for the prosperity that the city will be enjoying soon!”</i> You have no choice but to join them, and over the next few hours you enjoy a delicious feast provided by Alba.\n\nWhen the party is over, she leads you upstairs. <i>“Great day right "+ GameControl.playerName +"? But there is still one matter of business we need to talk about.”</i> she opens a door and leads you inside of her studio. <i>“Now, the question is this: What’s gonna be our focus? In the past, before the plague, we used to produce mainly domestic and luxury products, an industry that flourished with all the tourism. Today it’s not like we don’t need them, if anything we need to resupply the whole city again. With the place surrounded by beasts though, maybe you have something else in mind? Perhaps producing military equipment for your guards and army? This will be the first and most important choice you make tonight.”</i>\n\nShe goes into detail: If you focus on your domestic production, happiness and prosperity within the city will increase faster. Investing in the military, however, will yield greater security and defense, but less profit. <i>“In the end, you still will get your taxes, maybe not an equal amount with each choice, but enough to run the city. I’m gonna make sure that the nobles in my district fall in line and help you too. So, what will be your choice?”</i>\n";
			option0Name.text = "Domestic economy";
			option1Name.text = "War economy";
			confirmationControl = 5; 
			panConfirmation.sortingOrder = 500; 

			/*if (QuestControl.albaHelp) {

			} else {

			}*/
			

			break;
		case 4:
			panMainPanel.sortingOrder = 500;
			Board.text = "You visit Alba, what you're going to do now? \n\nAlba love: "+NPCCharList.CharFollower [iAlba].charLove.ToString()+".";
			break;
		default:

			break;
	
		}


	}


	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



	public void confirmFun(int selector){

		///////////////////////////// Aid / Coerce

		if (selector == 0 && confirmationControl == 0) {
			Board.text = "You agree to support her, and ask what it is that she needs to be done. She claps and cheers in response to your answer. <i>“Nice to hear that darling, but let me offer you some hospitality before I go into details about your task. You deserve that, at the very least.”</i> She calls to a servant and leads you to a table, where she takes a seat at your side. <i>“Now "+ GameControl.playerName +", I’m sure you’ve had a busy day, but you can be certain that my dinner will reinvigorate you.”</i>\n\nShe starts to talk about how badly the plague has affected both the city and her district. With the surrounding lands full of beasts, the supply of resources like wood, and metal have become scarce, making production almost impossible. <i>“Lately, our only way to create something new is by recycling old stuff. Unfortunately there are only so many times you can do that, and the situation is beginning to become critical.”</i> \n\nWhen dinner is over, she stands up and moves to your side, her breasts dangerously close to your face <i>“Now, do you want to know about your task, or have some dessert first?”</i>She slowly starts to loosen her top, exposing her nipples to the cool air. Should you take her offer? \n";
			option0Name.text = "Have fun first";
			option1Name.text = "Just business";
			confirmationControl = 1; 
			GameControl.attAlignment += 3;
			return;
		}

		if (selector == 1 && confirmationControl == 0) {
			Board.text = "You shake your head in disagreement. <i>“What? What do you mean by that?”</i> You inform her that she is in no position to be demanding your help, that her district is weak, she is hated, and you could easily turn Abbadon and the other houses against her. \n\nShe looks at you in anger, and clenches her fist for a short moment, but she rapidly recovers her flirting demeanour. <i>“Oh come on "+ GameControl.playerName +"... stop fooling around. I’ll make sure you get a good time for all the trouble, what do you say?”</i> She touches her chest seductively, and begins to sensually lick her lips. \n\n<i>“Take this as my first payment of what is owed to you...”</i> She holds your face between her hands. Although you can feel the cutting edge of her claws, she isn’t threatening you. <i>“What you say?”</i>\n";
			option0Name.text = "Push her away";
			option1Name.text = "Accept her charm";
			confirmationControl = 100; 
			NPCCharList.CharFollower [iAlba].charRelationship -= 5;
			NPCCharList.CharFollower [iAlba].charLoyalty -= 5;
			GameControl.attAlignment -= 3;

			return;
		}

		///////////////////////////// Have fun / Just Business

		if (selector == 0 && confirmationControl == 1) {
			if (GameControl.dick1Size > 0) {
				Board.text = "You smile, which is the only answer she needs before she kneels down. <i>“Just relax, and take this as a down payment...”</i> She takes her top off, and with a swift and skilled move she removes your leg wear, exposing your half erect meat piece.\n\n<i>“Don’t you feel bad for hiding this treasure "+ GameControl.playerName +"?”</i> She jokes while her dangerous looking hands approach you. <i>“You have nothing to fear, I know how to handle such delicate matters.”</i> True to her word, she holds your mast between her paws without harming you, the soft texture of her hair supplementing the already pleasurable experience.\n\n<i>“Do you want more?”</i> She lustfully licks her lips, and between shivers you manage to nod your head. <i>“That’s too bad, you’ll get some of that in the future, once you earned it...”</i> she teases you, but you don’t complain, afraid that she might stop altogether. \n\nShe expertly moves her hands around, giving you a massage that only an expert could. Before long, you feel yourself on your edge, ready to fire your load. \n\n<i>“Don’t be shy "+ GameControl.playerName +", just let yourself go. Aim at me if you really want to.”</i> With those words, she begins to pump you faster. Her expression betrays her excitement, and she bites her lips in an effort to contain herself. As much as she seems to long for more, she also knows that if she gives away too much now, she could lose a potential bargaining chip in the future.\n\nAfter only a few minutes at this pace, you find yourself unable to hold back any longer. Without time to give her any warning, your body gives up. The first load covers her face and hair, forcing her to close one eye, and you throw your head backwards as you shoot what’s left of you. When you finally recover, and look back down at her, you can see that her neck and breasts are covered with your seed. \n\n<i>“Where you store this much "+ GameControl.playerName +"... we should use you to repopulate the city.”</i> She laughs and stands up, licking some of the cum from her face. <i>“Well, let’s talk business now. I’ll take a shower when we are done.”</i>\n\nAlba then guides you to her studio, ignoring the fact that she is covered in your sperm. You can see that the servants around don’t even bat an eyelid at this sight, causing you to think that it may not be an entirely uncommon situation.\n\n";

			} else {
				Board.text = "You smile, which is the only answer she needs before she kneels down. <i>“Just relax, and take this as a down payment...”</i> She takes her top off, and with a swift and skilled move she removes your leg wear, exposing your twitching pussy.\n\n<i>“Don’t you feel bad for hiding this treasure "+ GameControl.playerName +"?”</i> She jokes while her dangerous looking hands approach you. <i>“You have nothing to fear, I know how to handle such delicate matters.”</i> True to her word, she holds your legs in her paws without harming you, and gently pulls you closer.  \n\nThe soft texture of her hair arouses you even further, as her face slowly approaches your nether parts. <i>“Are you ready?”</i>She licks her lips in anticipation, and you softly nod your head. <i>“I bet you are, you won’t regret this...”</i>  At first she just teases you, touching your pearl with her nose and slowly licking your slit, but you don’t complain, afraid that she might stop altogether.\n\nWhen she feels that she has prepared you enough, and that your body is eager to receive her, she takes a deep breath of air before diving into you. Her tongue massages you the way that only an expert could, and before long you find yourself already on the edge, your body shaking in anticipation.\n\n<i>“Don’t be shy "+ GameControl.playerName +", just let yourself go. I’m all ready to clean you up.”</i> With those words, her actions take on a fervid, almost desperate pace. As her eyes meet yours, she softly bites you down there, adding a sweet mix of pain to your intense pleasure. \n\nAfter only a few minutes at the increased pace, you find yourself unable to hold back any longer. Without time to give her any warning, your body gives up. You quiver as your muscles clench violently in ecstasy, and just before you close your eyes, you see her eagerly swallowing all of your fluids. When you finally reopen your eyes, you can see that her face is dripping with your essence.\n\n<i>“Such delicious nectar "+ GameControl.playerName +", I wish we had time to enjoy ourselves more.”</i> She stands up, licking some of the fluid from her face. <i>“Well, let’s talk business now. I’ll take a shower when we are done.”</i> As much as she seems to long for more, she also knows that if she gives away too much now, she could lose a potential bargaining chip in the future.\n\nAlba then guides you to her studio, ignoring the fact that she has no top, and that her makeup is smeared thanks to you. You can see that the servants around don’t even bat an eyelid at this sight, causing you to think that it may not be an entirely uncommon situation.\n\n";
			}
			Board.text += "Finally you reach a big room, with a large library and an enormous table in the middle of it. Upon the table rests a map of the local region. Pointing at the map, she begins to speak. <i>“Here, here are the mines. As you can see, you need to cross the forest in order to reach the mountains and get at them. The route is dangerous, but we can create caravans to move the supplies. The main problem is what lives inside of the mines.”</i> She shows you a couple of drawings, vague sketches, portraying the silhouettes of a half bull, half human monster. <i>“I don’t have much info regarding it, but I know that no squad has ever come back from the mine. You’ll have to take care of it one way or another, or we’ll be stuck without access to one of our primary sources of minerals .”</i>\n\nYou sigh, but nod in agreement, the mines are the only reliable way to obtain minerals during these harsh times. You tell her that she needs to ready up as many volunteers and guards as possible. <i>“We are already spread thin, but I can arrange a gathering with the citizens of my district. You’ll have to be the one to motivate them to joining you though, they won’t listen to me ”</i> You ask her to do just that, and tell her that you’ll be sure to rally them to your aid.\n\n<i>“Don’t worry "+ GameControl.playerName +", I can get this done in just a couple of hours, just let me know when you’re ready.”</i> You thank her, and leave the place, giving yourself some time to prepare a speech.";
			QuestsController.RemoveID (13000);
			Quest AlbaQuest2 = new Quest(); 
			QuestsController.createQuest (AlbaQuest2, "Rally the troops", "Alba asked you to take back the mines, you need to rise the moral of the people to follow you at this task.", 59, 13001);
			QuestControl.albaHelp = true; 
			QuestControl.albaQuest = 1;
			WorldControl.day += 2;
			NPCCharList.CharFollower [iAlba].charLove += 5;
			NPCCharList.CharFollower [iAlba].charRelationship += 15;
			NPCCharList.CharFollower [iAlba].charLoyalty += 15;
			endTurnFun ();
			GameControl.charGold += 250;
			GameControl.attAlignment += 2;
			return;
		}

		if (selector == 1 && confirmationControl == 1) {
			Board.text = "<i>“Oh you are no fun... Just follow me then.”</i> She goes to her studio and shows you a map of the local region. <i>“Here, here are the mines. As you can see, you need to cross the forest in order to reach the mountains and get at them. The route is dangerous, but we can create caravans to move the supplies. The main problem is what lives inside of the mines.”</i> She shows you a couple of drawings, vague sketches, portraying the silhouettes of a half bull, half human monster. <i>“I don’t have much info regarding it, but I know that no squad has ever come back from the mine. You’ll have to take care of it one way or another, or we’ll be stuck without access to one of our primary sources of minerals .”</i>\n\nYou sigh, but nod in agreement, the mines are the only reliable way to obtain minerals during these harsh times. You tell her that she needs to ready up as many volunteers and guards as possible. <i>“We are already spread thin, but I can arrange a gathering with the citizens of my district. You’ll have to be the one to motivate them to joining you though, they won’t listen to me ”</i> You ask her to do just that, and tell her that you’ll be sure to rally them to your aid.\n\n<i>“Don’t worry "+ GameControl.playerName +", I can get this done in just a couple of hours, just let me know when you’re ready.”</i> You thank her, and leave the place, giving yourself some time to prepare a speech.\n";
			QuestsController.RemoveID (13000);
			Quest AlbaQuest2 = new Quest(); 
			QuestsController.createQuest (AlbaQuest2, "Rally the troops", "Alba asked you to take back the mines, you need to rise the moral of the people to follow you at this task.", 59, 13001);
			endTurnFun ();
			QuestControl.albaHelp = true; 
			QuestControl.albaQuest = 1;
			WorldControl.day += 2;
			GameControl.charGold += 250;
			NPCCharList.CharFollower [iAlba].charRelationship += 10;
			NPCCharList.CharFollower [iAlba].charLoyalty += 10;
			GameControl.attAlignment += 2;
			return;
		}

		///////////////////////////// wealth / slaves

		if (selector == 0 && confirmationControl == 2) {
			Board.text = "You tell the crowd that those who follow you will be able to keep their spoils of war, including whatever possessions the vanquished beasts and bandits might have. Although it’s true that many beasts are naked, many others are former nobleman and women, and still have some of their jewels and precious possessions with them. Not to mention that the bandits’ camps have also accumulated a moderate quantity of treasure.\n\nMost of the crowd seems to be convinced now, at least having a reason to take a risk. Others, however, still believe that this isn’t enough, that there should be at least a token of goodwill from you or Alba. When those people raise their voice, the rest rapidly joins them in asking for something more tangible before they join you.\n\nAlba looks at you frustrated <i>“Just let it go, they will keep you asking you for stuff, as if they deserve it.”</i> You know, however, that if you want to have any chance of retaking the mine, you cannot simply let it go.\n\nA single gold coin could very well feed them and their families for a week, and you believe that 200 in total should be all it takes to satisfy them for now. You could also tell them that Alba will take care of this, since this is her district and they are her people, though you’re certain that doing so wouldn’t please her very much.\n\nWho is going to pay?";
			option0Name.text = "Let Alba pay";
			option1Name.text = "Pay them (200G)";

			if (GameControl.charGold < 200) {
				option1Butt.interactable = false; 
			}

			confirmationControl = 3; 
			GameControl.attAlignment += 3;
			return;
		}

		if (selector == 1 && confirmationControl == 2) {
			Board.text = "You tell them that those who follow you will be able to take any slaves that are captured, although you would be the one to keep most of their belongings. Although it’s true that many beasts are naked, many others are former nobleman and women, and still have some of their jewels and precious possessions with them. Not to mention that the bandits’ camps have also accumulated a moderate quantity of treasure.\n\nMost of the crowd seems to be convinced now, at least having a reason to take a risk. Others, however, still believe that this isn’t enough, that there should be at least a token of goodwill from you or Alba. When those people raise their voice, the rest rapidly joins them in asking for something more tangible before they join you.\n\nAlba looks at you frustrated <i>“Just let it go, they will keep you asking you for stuff, as if they deserve it.”</i> You know, however, that if you want to have any chance of retaking the mine, you cannot simply let it go.\n\nYou can see that the prospect of having slaves, of owning beasts, has them very excited. Even if you promise to give them a moderate amount of gold as an initial payment for their services, they are really looking for more than that... they are thirsty for flesh. \n\nYou believe that 200 gold coins should be enough cover the initial payment, a cost that can be covered by either you or Alba, though she won’t be happy if you pledge her gold. \n\nThat being said, you could also offer them something <i>else</i>, since the crowd is now lusting for some action. You ask Alba what she thinks about her taking care of this business. <i>“What? Please this crowd?”</i> She looks at the filthy people in front of her, all eager for some action. She raises one of her eyebrows. <i>“Uh... very well, I think that my servants can take care of them. They are skilled in every type of task, if you get my meaning...”</i>\n\nAfter some deliberation, you are left with three options in front of you: Pay them 300 gold coins out of your own pocket, force Alba to pay them instead, or let the crowd use Alba’s servants. \n";
			option0Name.text = "Let Alba pay";
			option1Name.text = "Pay them (200G)";
			option2Name.text = "Use servants";
			if (GameControl.charGold < 200) {
				option1Butt.interactable = false; 
			}
			option2Butt.interactable = true; 
			GameControl.attAlignment -= 3;
			confirmationControl = 4; 
			return;
		}


		///////////////////////////// Let Alba Pay, pay them

		if (selector == 0 && confirmationControl == 3) {
			Board.text = "No, these are Alba’s people, and she should take responsibility for them. As you continue your speech, you inform the crowd that Alba will take care of the initial payment for their service, but that those who accept this money will be required to help in the expedition. \n\nYou can see that almost all of the crowd is cheerful and eager, with those who still oppose you thrown out of the group. Happy with the results, you turn to Alba, whose face clearly displays her fury.\n\n<i>“Why would you put this burden on me? If I could take care of them, I would have done so already. Shit, if knew that this was going to cost me anything, I would had given the speech myself. I am more charming than you anyway!”</i> She turns away from you<i>“Now I have to get ready to deliver on your promises "+ GameControl.playerName +", so excuse me.”</i> without any further words, she exits to her castle.\n\nYou return to your own castle, and gather your staff to begin planning the journey through the woods and into the mines. ";
			QuestsController.RemoveID (13001);
			Quest albaQuest3 = new Quest ();
			QuestsController.createQuest (albaQuest3, "Taking the mines", "You and Alba are ready to face the perils that lie deep inside the mines.", 60, 13002);
			endTurnFun ();
			QuestControl.albaQuest = 2;
			WorldControl.day += 2;
			NPCCharList.CharFollower [iAlba].charRelationship -= 5;
			NPCCharList.CharFollower [iAlba].charLoyalty -= 5;
			CityControl.city100Order += 5;
			CityControl.city100Defense += 10;
			return;
		}

		if (selector == 1 && confirmationControl == 3) {
			Board.text = "Knowing that Alba’s wealth is already greatly diminished, you decide to give them the gold yourself. Continuing your speech, you inform the crowd that soon your guards will arrive to give them an initial payment for their service, but that those who accept this money will be required to help in the coming expedition.\n\nYou can see that almost all of the crowd is cheerful and eager, with those who still oppose you thrown out of the group. Happy with the results, you turn to Alba, who is smiling at you.\n\n<i>“You really took care of this well. I wouldn’t have bothered to go further than the first speech. Thanks "+ GameControl.playerName +", it’s good to see that you know what you are doing. I have some things to organise for your expedition, so you’ll have to excuse me while I attend to those matters.”</i> She gives you a small slap on the butt before turning and leaving.\n\nYou ask one of your guards to go back to the castle and bring the gold required to pay your citizens. While he does that, you join with your staff and begin planning the journey through the woods and into the mines. \n";
			GameControl.charGold -= 200;
			QuestsController.RemoveID (13001);
			Quest albaQuest3 = new Quest ();
			QuestsController.createQuest (albaQuest3, "Taking the mines", "You and Alba are ready to face the perils that lie deep inside the mines.", 60, 13002);
			endTurnFun ();
			QuestControl.albaQuest = 2;
			WorldControl.day += 2;
			NPCCharList.CharFollower [iAlba].charRelationship += 10;
			NPCCharList.CharFollower [iAlba].charLoyalty += 10;
			CityControl.city100Order += 5;
			CityControl.city100Defense += 10;
			return;
		}



		///////////////////////////// Let Alba pay / pay them / use servants

		if (selector == 0 && confirmationControl == 4) {
			confirmationControl = 3;
			confirmFun (0);
			return;
		}

		if (selector == 1 && confirmationControl == 4) {
			confirmationControl = 3;
			confirmFun (1);
			return;
		}

		if (selector == 2 && confirmationControl == 4) {
			Board.text = "You tell Alba to put her servants to good use. <i>“I’ll do that, "+ GameControl.playerName +".”</i> She turns around and gives some orders to one of her guards. After a few minutes pass, you see her servants exiting her house, and moving to stand on the podium. Most of them have their heads down, and are quivering in fear. \n\n<i>“As "+ GameControl.playerName +" promised, you’ll enjoy a token of our generosity. Come here and enjoy this flesh, but remember that in taking this offer, you pledge to fight with us in the coming battle.”</i> Alba then rips apart the uniform of one of the girls, exposing her breasts. The young girl screams, but Alba just laughs as the two of you move away from the platform. <i>“Don’t worry too much about it, this is good training for them.”</i> Alba says without any hint of mercy in her voice. \n\nThe recruits don’t hesitate for long, and hastily rush towards their victims. Unashamedly, they expose their cocks and cunts, forcefully undressing the servants, and slapping them if they show any hint of resistance. <i>“Hey! If you injure them, you’ll be the one to pay for the physician bill!”</i> As expected, the impatient recruits quickly moderate their behavior, and in only a matter of minutes, everybody on the platform is naked and engaged in some lewd act.\n\n<i>“Disgusting,”</i> Alba says to your surprise. <i>“What? Yes, I love orgies, but these people are disgusting. Filthy and unrefined, like beasts...”</i> although she is criticizing them, you see that her nipples have become hard, and her face flushed crimson. <i>“Wild... at least they make up for that with their energy and eagerness. But it’s nothing compared to what I’ve organized in the past. Now that’s the real deal.”</i> She begins to proudly tell you about the last party she threw, but the conversation is interrupted by the raucous moans of the crowd. <i>“Mmh... I’ll save my story for another occasion. For now, I think that my servants have already persuaded them to do their duty.”</i> She turns around and starts to walk towards her castle <i>“I’ll be sure to have the expedition ready as soon as possible, just contact me when you are ready.”</i>\n";
			QuestsController.RemoveID (13001);
			Quest albaQuest3 = new Quest ();
			QuestsController.createQuest (albaQuest3, "Taking the mines", "You and Alba are ready to face the perils that lie deep inside the mines.", 60, 13002);
			endTurnFun ();
			QuestControl.albaQuest = 2;
			WorldControl.day += 2;
			NPCCharList.CharFollower [iAlba].charRelationship += 5;
			NPCCharList.CharFollower [iAlba].charLoyalty += 5;
			NPCCharList.CharFollower [iAlba].charCorruption += 5;
			CityControl.city100Order -= 3;
			CityControl.city100Happiness += 5; 
			CityControl.city100Defense += 10;
			GameControl.attAlignment -= 3;
			return;
		}


		///////////////////////////// Domestic / military

		if (selector == 0 && confirmationControl == 5) {
			Board.text = "<i>“Great, I guess there is no point in fighting a war when there is nothing but shit at home.”</i> She begins to talk about what steps she’ll take to get everything ready. You realize that she wasn’t lying when she said she was going to produce luxury items, as it looks like she has assigned every artisan to produce non-essential products.\n\nYou ask if this would really be a help to the city. <i>“But of course! Wait, are you actually caring about the peasants of the city? No, of course I wasn’t taking them into consideration, why would I? It’s not like they have much money anyway.”</i>\n\nAlthough she is right in saying that producing luxury items will be more profitable, such an elitist choice could be detrimental to the happiness of the city, increasing the divide between populations, and causing potential problems for the security of the city. Should you allow her to continue with her current plans, or ask her to switch her focus to products that will actually help the citizenry? Should her production be for the commoners or the elite? ";
			option0Name.text = "The people";
			option1Name.text = "The Elite";
			confirmationControl = 6;
			return;
		}

		if (selector == 1 && confirmationControl == 5) {
			Board.text = "She shrugs, not entirely happy with your choice, but not willing to openly disagree with you either. <i>“I can’t argue with the logic behind rearming the army, especially in these times. Now, I believe that there is no point on reclaiming what is ours if we are dressed in rags. We need to show both this city and the world all that we have to offer, and give them hope.”</i> She asks you to follow her into another room, where a variety of different uniforms and armours are on display. \n\nAlthough some of them are both good looking and functional, others are just fashionable uniforms that you might expect on a parade, not in a battlefield. Nevertheless, Alba seems interested in making these the standard outfit for your army. \n\n<i>“I’ve already heard the complaints about these uniforms, but it’s not like you can’t fight in them. It’s just a little more difficult. But think about this, who are you going to recruit with the old rags? Who will volunteer with such an uninspiring attire? And what does it show about our aspirations as a kingdom? Believe me "+ GameControl.playerName +", you’ll get the best of the best if you equip them with this. At the very least, they’ll be more confident when facing the dead for you.”</i>\n\nYou look at her impractical but fancy designs for a while, until you finally make up your mind.\n";
			option0Name.text = "Modern Uniforms";
			option1Name.text = "Fashionable uniforms";
			confirmationControl = 8;

			return;
		}



		///////////////////////////// People / Elite economic focus

		if (selector == 0 && confirmationControl == 6) {
			Board.text = "You can see how she saddens when you tell her that she will switch her production to fulfill the needs of the many, not the few. After a deep sigh, she continues the conversation. <i>“Seriously "+ GameControl.playerName +"? This is going to waste resources on people that can’t even distinguish silver from pig iron. But it’s your call, and if this is what you wish then I’ll tell my people to take care of it.”</i>\n\nAt first she pretends not to be upset, but after a few minutes, she suddenly throws some rare art pieces to the ground, breaking them apart. <i>“Nghh! I had so many plans! I hope you change your mind in the future "+ GameControl.playerName +"! When you realize that we there is no point in pleasing the plebeians.”</i> She raises her hand but you grab it, and after a short staring contest, she gives up. \n\n<i>“My... my bad, I shouldn’t have reacted like this. My apologies "+ GameControl.playerName +", but I think it is time for you to leave. I have a lot of work to do and many people to talk, you will see some results very soon. If you change your mind, let me know.”</i> \n\nShe turns around to leave, but pauses <i>Oh right, silly me, I almost forgot about what I owe you.“”</i> She yells, and in minutes a pair of guards appear before you, carrying a chest filled with gold coins. <i>“What I owe you, 2000 gold coins, this should be enough for now don’t you think? And don’t worry, I’ll move around and ask the other houses to pay what they are due also. Now, if you’d excuse me.”</i>\n\nShe turns around and leaves, and you return to your castle without any complications, making sure to place your money safely in the vault.\n\nFor now, you have Alba’s support, and are making significant progress towards earning the respect and trust of the city. \n";
			GameControl.charGold += 2000;
			endTurnFun ();
			QuestControl.albaQuest = 4;
			WorldControl.day += 2;
			if(QuestControl.abbadonQuest == 5){
				Quest HelenaQuest0 = new Quest();
				QuestsController.createQuest(HelenaQuest0, "Repairs", "With the two bigger Houses backing you, it's time to repair your castle", 13, 3000);
				LawController.RepealLaw (LawController.Get<LawTaxesLow>());
				LawController.EnactLaw (new LawTaxesNormal ());
			} else {
				LawController.RepealLaw (LawController.Get<LawTaxesVeryLow> ());
				LawController.EnactLaw (new LawTaxesLow ());
			}
			QuestsController.RemoveID (13003);
			LawController.EnactLaw (new LawDomesticEconomyCommoner());

			NPCCharList.CharFollower [iAlba].charRelationship += 5;
			NPCCharList.CharFollower [iAlba].charLoyalty += 5;
			CityControl.city100Order += 2;
			CityControl.city100Happiness += 10; 
			CityControl.city100Prosperity += 3; 
			return;
		}

		if (selector == 1 && confirmationControl == 6) {
			Board.text = "You dismiss the idea of helping the commoners, and tell her that she can continue with her plans. She thanks you with a bright smile. <i>“That’s right, there’s no point in wasting our time with the plebeians, "+ GameControl.playerName +". I am glad that we are like-minded. I’ll tell my people to get started as soon as possible. As a matter of fact, there is something I want to show you.”</i>\n\nShe takes your hand and leads you to a beautiful boudoir. There, she asks you to stand where you are, while she proceeds to take something from a box, which rests upon a table to the side of a chaise lounge, in the middle of the room. <i>“Hey "+ GameControl.playerName +", I designed this myself... what you think?”</i> She shows you a very luxurious sex toy in the shape of a human cock, with a decorated base of gold and silver, and an exotic, skin-like texture that makes it look a great deal like the real thing.\n\n<i>“What do you think? Wonderful right? I’m going to sell these to those desperate bitches in the city. It’ll be a roaring success, you’ll see.”</i> She takes a seat, and opens her legs wide, her clothes still covering her more intimate parts. <i>“Want to see a demonstration of the product?”</i> She licks her lips, eager to start her show.\n";
			option0Name.text = "Look demonstration";
			option1Name.text = "Refuse";
			confirmationControl = 7; 
			NPCCharList.CharFollower [iAlba].charRelationship += 15;
			NPCCharList.CharFollower [iAlba].charLoyalty += 15;
			CityControl.city100Happiness += 5; 
			CityControl.city100Prosperity += 5; 
			return;
		}

		///////////////////////////// Look / refuse 

		if (selector == 0 && confirmationControl == 7) {
			Board.text = "<i>“That dumb smile on your face says it all, "+ GameControl.playerName +"...”</i> she begins to slow strip for you, removing her top first, but covering her breasts with one arm. She turns around and seductively removes her shorts, leaving her with only a red thong for cover.\n\nShe bends over, exposing her almost nude ass to you. Without any hesitation you proceed to give it a loud slap. <i>“Mmf... such a strong hand...”</i> She turns around and dances seductively for a few minutes, before she finally reveals her whole nude body to you. \n\n<i>“Enough foreplay.”</i> She sits back down, and spreads her legs, giving you a good look at her nether parts. <i>“Do you like it? Maybe in the future I’ll give you a taste of it.”</i> She grabs the luxurious sex toy and starts to suck on it, while she slowly plays with herself with her other hand. \n\nThe slurping sounds and soft moans echo through the big house, and the fact that one of the most important noblewomen on the city is giving you a private show makes you think about all of the other perks you’ll get to enjoy, although Alba is probably more open and unashamed than most others. \n\nWhen the toy is lubricated with her saliva, and her pussy wet, she proceeds with the rest of the show. At first she only inserts the head, getting used to it’s big size while she starts to play with her breasts. Once her fluids have completely coated the tool, she slowly engulfs it with her lower mouth. \n\n<i>“Mmh… great texture, big size... almost as good as the real deal.”</i> You can no longer hold back, and so quickly expose yourself before beginning to masturbate to the show.<i>“Ahh! Yes! Look at me! Devour me with your eyes "+ GameControl.playerName +"!”</i> Alba gets off by exposing herself, and having your lustful eyes locked onto her naked body only motivate her to increase her pace. \n\nHer groans of pleasure are so loud, you eventually hear a number of curious servants on the other side of the door, playing with themselves and each other; aroused by what’s going on inside. Alba seems to enjoy hiring those who are just as perverted as herself.\n\nAfter several minutes, the two of you reach your limit, your bodies quivering with excitement. <i>“Ahh! "+ GameControl.playerName +"! Let’s just cum! Let’s make a mess!”</i> Only moments later, the two of you clench your muscles as shock waves of joy and pleasure course through your bodies, proceeding to shoot your fluids all across the room.\n\nWhen both of you have finally recovered, you can see your fluids mixing together on the ground. <i>“Ahh, such a waste...”</i> Alba, claps and immediately a maid with tousled hair and suspicious stains on her skirt opens the door. <i>“Come on, clean this place up.”</i> The maid kneels to the floor and starts to lick up your love juices. \n\nAlba smiles and stands up, still naked. <i>“This has been great, but I think it’s time for you to go.”</i> She allows you to dress yourself, and follows you to the exit, undoubtedly happy and cheerful about what just happened. <i>“A great future awaits us, but it’s time to work extra hard to get it done. The noblemen and women will have to accept you now that you have this place running. This is a true show of leadership, which cannot be denied.”</i>\n\nHer cheerful expression transforms into a serious one in an instant. <i>“Nevertheless, don’t be dumb "+ GameControl.playerName +", there is still a lot of work ahead. You may have my support, and maybe that of some other big houses, but there are still a lot of smaller houses that could pose a threat to you, or at the very least be a pain in the ass. That is not to say that the population hasn’t seen enough to praise you like their savior, but you still need to be careful not to do anything stupid. You’re not all powerful yet.”</i>\n\nShe calls out somebody, and in less than a minute, a group of guards enter the room, carrying a large chest. Alba opens it to show you a small fortune in gold coins. <i>“Here is what I owe you, 2000 gold coins. This should be enough to help you start your new life in this city. I will pay taxes from my daily profits, and don’t worry, I’ll move around and ask the other houses to pay their dues too.”</i> She claps curtly, and the guards guide you to the exit.\n\n<i>“By the way "+ GameControl.playerName +", you can come and visit me whenever you want, and we’ll have some more fun...”</i> she exposes her breasts for a short second, showing you her still hard nipples before covering herself up. <i>“Goodbye for now my liege, take care.”</i>\n\nYou return to your castle without any complications, and make sure to place your money safely in the vault. \n\nFor now, you have Alba’s support, and are making significant progress towards earning the respect and trust of the city. \n\n";
			GameControl.charGold += 2000;
			QuestControl.albaQuest = 4;
			WorldControl.day += 2;
			if(QuestControl.abbadonQuest == 5){
				Quest HelenaQuest0 = new Quest();
				QuestsController.createQuest(HelenaQuest0, "Repairs", "With the two bigger Houses backing you, it's time to repair your castle", 13, 3000);
				LawController.RepealLaw (LawController.Get<LawTaxesLow>());
				LawController.EnactLaw (new LawTaxesNormal ());
			} else {
				LawController.RepealLaw (LawController.Get<LawTaxesVeryLow> ());
				LawController.EnactLaw (new LawTaxesLow ());
			}
			endTurnFun ();
			LawController.EnactLaw (new LawDomesticEconomyElite());
			LawController.EnactLaw (new LawUniformsOutdated());
			QuestsController.RemoveID (13003);
			NPCCharList.CharFollower [iAlba].charLove += 5;
			NPCCharList.CharFollower [iAlba].charRelationship += 20;
			NPCCharList.CharFollower [iAlba].charLoyalty += 20;
			NPCCharList.CharFollower [iAlba].charCorruption += 3;
			CityControl.city100Happiness += 5; 
			CityControl.city100Prosperity += 5; 
			return;
		}

		if (selector == 1 && confirmationControl == 7) {
			Board.text = "You shake your head and refuse. <i>“Oh, that’s a shame. Well, I think that for today this is all I’ve got. You made some important choices today "+ GameControl.playerName +", and if you ask me, I think you did the right thing. Let me escort you outside.”</i>\n\nShe follows you to the exit, although her mood is slightly lessened by your refusal, she is undoubtedly happy and cheerful. <i>“A great future awaits for us, but we have to work extra hard to get it done. The noblemen and women will have to accept you now that you’ve got this place running. It is a true show of leadership, which cannot be denied.”</i>\n\nHer cheerful expression transforms into a serious one in an instant. <i>“Nevertheless, don’t be dumb "+ GameControl.playerName +", there is still a lot of work ahead. You may have my support, and maybe that of some other big houses, but there are still a lot of smaller houses that could pose a threat to you, or at the very least be a pain in the ass. That is not to say that the population hasn’t seen enough to praise you like their savior, but you still need to be careful not to do anything stupid. You’re not all powerful yet.”</i>\n\nShe calls out somebody, and in less than a minute, a group of guards enter the room, carrying a large chest. Alba opens it to show you a small fortune in gold coins. <i>“Here is what I owe you, 2000 gold coins. This should be enough to help you start your new life in this city. I will pay taxes from my daily profits, and don’t worry, I’ll move around and ask the other houses to pay their dues too.”</i> She claps curtly, and the guards guide you to the exit.\n\n<i>“By the way "+ GameControl.playerName +", you can come and visit me whenever you want. We can have some fun too...”</i> she exposes her breasts for a short second, showing you her pink nipples before covering herself up. <i>“Goodbye for now my liege, take care.”</i>\n\nYou return to your castle without any complications, and make sure to place your money safely in the vault. \n\nFor now, you have Alba’s support, and are making significant progress towards earning the respect and trust of the city. \n\n";
			GameControl.charGold += 2000;
			QuestControl.albaQuest = 4;
			WorldControl.day += 2;
			if(QuestControl.abbadonQuest == 5){
				Quest HelenaQuest0 = new Quest();
				QuestsController.createQuest(HelenaQuest0, "Repairs", "With the two bigger Houses backing you, it's time to repair your castle", 13, 3000);
				LawController.RepealLaw (LawController.Get<LawTaxesLow>());
				LawController.EnactLaw (new LawTaxesNormal ());
			} else {
				LawController.RepealLaw (LawController.Get<LawTaxesVeryLow> ());
				LawController.EnactLaw (new LawTaxesLow ());
			}
			endTurnFun ();
			LawController.EnactLaw (new LawDomesticEconomyElite());
			LawController.EnactLaw (new LawUniformsOutdated());
			QuestsController.RemoveID (13003);
			NPCCharList.CharFollower [iAlba].charLove -= 5;
			NPCCharList.CharFollower [iAlba].charRelationship += 10;
			NPCCharList.CharFollower [iAlba].charLoyalty += 10;
			CityControl.city100Happiness += 5; 
			CityControl.city100Prosperity += 5; 
			return;
		}


		///////////////////////////// Modern / Fashionable

		if (selector == 0 && confirmationControl == 8) {
			Board.text = "<i>“Not a lover of fashion, huh? Very well, don’t come to me when your army is filled with decrepit peasants. I’ll pass the message, and start production as soon as possible. You should have some equipment ready very soon.”</i>\n\nIn a burst of temper, she turns around and destroys one of the uniforms with her claws, muttering angrily under her breath while she walks towards the exit, and yells out to someone. In less than a minute she comes back with a group of guards, who are carrying a large chest. Alba opens it to show you a small fortune in gold coins. <i>“Here is what I owed you, 2000 gold coins. This should be enough for now don’t you think? And don’t worry, I’ll move around and ask the other houses to pay their dues too. Now, if you’ll excuse me.”</i> She claps curtly, and the guards guide you to the exit.\n\nShe turns around and leaves, and you return to your castle without any complications, making sure to place your money safely in the vault.\n\nFor now, you have Alba’s support, and are making significant progress towards earning the respect and trust of the city. \n\n";
			GameControl.charGold += 2000;
			QuestControl.albaQuest = 4;
			WorldControl.day += 2;
			if(QuestControl.abbadonQuest == 5){
				Quest HelenaQuest0 = new Quest();
				QuestsController.createQuest(HelenaQuest0, "Repairs", "With the two bigger Houses backing you, it's time to repair your castle", 13, 3000);
				LawController.RepealLaw (LawController.Get<LawTaxesLow>());
				LawController.EnactLaw (new LawTaxesNormal ());
			} else {
				LawController.RepealLaw (LawController.Get<LawTaxesVeryLow> ());
				LawController.EnactLaw (new LawTaxesLow ());
			}
			endTurnFun ();
			LawController.EnactLaw (new LawUniformsModern());
			QuestsController.RemoveID (13003);
			NPCCharList.CharFollower [iAlba].charRelationship += 5;
			NPCCharList.CharFollower [iAlba].charLoyalty += 5;
			CityControl.city100Order += 2;
			CityControl.city100Happiness += 2; 
			CityControl.city100Defense += 5;
			CityControl.city100Prosperity += 2; 
			return;
		}

		if (selector == 1 && confirmationControl == 8) {
			Board.text = "<i>“Really? You are the best "+ GameControl.playerName +"! I’ll let my artisans know as soon as possible. You’ll have some equipment ready in no time, and believe me, in the long term you’ll see that I was right.”</i>\n\nShe turns around and touches the soft fabric of one of the uniforms, smiling brightly as she walks towards the exit, and calls out to someone. In less than a minute, a group of guards enters the room carrying a large chest. Alba opens it to show you a small fortune in gold coins. <i>“Here is what I owe you, 2000 gold coins. This should be enough to help you start your new life in this city. I will pay taxes from my daily profits, and don’t worry, I’ll move around and ask the other houses to pay their dues too.”</i> She claps curtly, and the guards guide you to the exit.\n\n<i>“By the way "+ GameControl.playerName +", you can come and visit me whenever you want. We can have some fun too...”</i> she exposes her breasts for a short second, showing you her pink nipples before covering herself up. <i>“Goodbye for now my liege, take care.”</i>\n\nYou return to your castle without any complications, and make sure to place your money safely in the vault. \n\nFor now, you have Alba’s support, and are making significant progress towards earning the respect and trust of the city. \n\n\n";
			GameControl.charGold += 2000;
			QuestControl.albaQuest = 4;
			WorldControl.day += 2;
			if(QuestControl.abbadonQuest == 5){
				Quest HelenaQuest0 = new Quest();
				QuestsController.createQuest(HelenaQuest0, "Repairs", "With the two bigger Houses backing you, it's time to repair your castle", 13, 3000);
				LawController.RepealLaw (LawController.Get<LawTaxesLow>());
				LawController.EnactLaw (new LawTaxesNormal ());
			} else {
				LawController.RepealLaw (LawController.Get<LawTaxesVeryLow> ());
				LawController.EnactLaw (new LawTaxesLow ());
			}

			endTurnFun ();
			LawController.EnactLaw (new LawUniformsFashionable());
			QuestsController.RemoveID (13003);
			NPCCharList.CharFollower [iAlba].charRelationship += 10;
			NPCCharList.CharFollower [iAlba].charLoyalty += 10;
			CityControl.city100Order += 2;
			CityControl.city100Happiness += 5; 
			CityControl.city100Defense += 2;
			CityControl.city100Prosperity += 2; 
			return;
		}



		///////////////////////////// temp

		if (selector == 0 && confirmationControl == 9999) {
			Board.text = "";
			return;
		}

		if (selector == 1 && confirmationControl == 9999) {
			Board.text = "";
			return;
		}



		///////////////////////////// Push her / be charmed 

		if (selector == 0 && confirmationControl == 100) {
			Board.text = "You push her away, refusing her advances, and order her to get in line. Now she is really angry and showing it, her claws poised to attack. Your hand is resting over your weapon, ready to use if the need arises and, seeing this, she finally submits to you. <i>“Fine, I’ll pay you part of what is owed, but if you want the full payment you need to take care of business here. No profits, no taxes. It’s not a hard concept to understand.”</i> She turns around and calls out to someone. Immediately a servant enters, and Alba orders her to bring your gold. <i>“She’ll be back in a moment, and then you can leave. But there are some things you have to fix, whether you like it or not. They are your responsibility, and without them I can’t run this place anyhow. You need to liberate the mines from a gang of brigands which currently occupies them. Take them down, or remove them by any means necessary. Those mines need to be working again if you want this place to follow suit.”</i>\n\nYou tell her that you will see what you can do, though you don’t pay a great deal of attention to her pleas. When the servants return, they hand you a hefty bag of 300 gold coins. <i>“There, use that money wisely. I have other matters to attend, so excuse me.”</i> Alba turns around and leaves you with a servant, who guides you to the exit. Without anything else left to do there, you return to your castle and start your preparations to explore those mines. \n";
			QuestsController.RemoveID (13000);
			Quest AlbaQuest2 = new Quest(); 
			QuestsController.createQuest (AlbaQuest2, "Taking the mines", "Alba asked you to take back the mines. You and a group of Alba's soldiers go to face the perils that lie deep inside it.", 60, 13001);
			QuestControl.albaQuest = 1;
			WorldControl.day += 2;
			endTurnFun ();
			QuestControl.albaHelp = false; 
			GameControl.charGold += 300;
			NPCCharList.CharFollower [iAlba].charRelationship -= 5;
			NPCCharList.CharFollower [iAlba].charLoyalty -= 5;

			return;
		}

		if (selector == 1 && confirmationControl == 100) {
			confirmationControl = 1;
			confirmFun (0);

			return;
		}


		///////////////////////////// Negotiate // crush

		if (selector == 0 && confirmationControl == 101) {
			Board.text = "You tell Helena that you are going to meet the protesters. <i>“Take care, my liege. I’ll inform the guards to get ready to intervene if the need arises.”</i> Without further delay, you head to the gate and order to your soldiers to open it. They hesitate for a moment, but do as commanded. \n\nWhen you step outside, you can hear the roaring turmoil of the crowd. A local leader manages to calm them down just enough to allow you to hear him. He tells you that your new retainers have been ransacking the population, undertaking a wide variety of crimes. They don’t just want reparations, but justice. \n\nYou tell him that adapting to a new lifestyle takes time, and that in such dire times everyone needs to be ready to sacrifice something. You need everyone who can help the cause, even if they are flawed. The crowd doesn’t buy your excuse, and their patience is running low. Their leader tries to find a middle ground, asking you to either purge them, or at the very least discipline them.\n\nPurging them is clearly an extreme option, but things would quickly return to normal, though your ruthlessness will be noticed. Disciplining them would be less efficient, but would allow you to retain control of the brigands.\n";
			option0Name.text = "Purge them";
			option1Name.text = "Discipline them";
			confirmationControl = 102; 
			return;
		}

		if (selector == 1 && confirmationControl == 101) {
			Board.text = "You’ve used up enough of your patience on them already. You ask Helena to inform the thief that she needs to go out there and crush the rioters. <i>“Are you sure my liege? There may be better ways to-”</i> You cut her off, and inform your retainer of the orders yourself. <i>“Yes my liege, as you command.”</i>\n\nYou wait in your tower, ready for the show. Once the bunny girl has gotten her group ready, they all rush outside. Before the crowd can even react, the bandits begin to attack the people, crushing their heads and bones with their weapons. After half an hour of intense fighting, you see that the rioters  are defeated, and your retainer signing you to come downstairs. \n\nOnce you meet her, you can see they have captured a large number of the crowd, including their leaders <i>“We should have done this from day one, my liege, it was rather easy to take them.”</i>\n\nThe prisoners spit at you, insult you and saying that there will be consequences for this in the future. <i>“Ha! Consequences my ass! Now "+ GameControl.playerName +", what should we do with them? Throw them in the dungeon, or just hang them and make an example out of them?”</i>\n\n";
			option0Name.text = "Jail them";
			option1Name.text = "Execute them";
			confirmationControl = 104; 
			return;
		}


		///////////////////////////// Purge / Discipline

		if (selector == 0 && confirmationControl == 102) {
			Board.text = "The people are right, and Alba was right too. Taking these bandits under your protection was a bad idea. You ask the people to follow you back into the castle, so that they can have their justice. \n\nAfter an hour of battle, yourself, your guards and the population manage to capture most of the bandits, with the exception of their leader. You order a lockdown of the place, but before your guards can follow your orders, you hear the girl’s shrill laughter. <i>“Stupid "+ GameControl.playerName +"! You won’t get me so easily! I’ll make sure you pay for betraying me!”</i>\n\nShe runs away, her speed unmatched by any of your people. Though she managed to escape, at least you managed to get the rest of her group. The people are happy that you did the right thing, even if it was too late. \n\nLater that day, the population hangs almost every bandit, with any who are spared becoming slaves for the city. While you are supervising the last execution, you receive a message from Alba, requesting that you join her to talk about business. ";
			LawController.EnactLaw (new LawNoMilitia());
			QuestControl.albaQuest = 3;
			endTurnFun ();
			WorldControl.day += 2;
			QuestsController.RemoveID (13002);
			Quest AlbaQuest4 = new Quest(); 
			QuestsController.createQuest (AlbaQuest4, "Forging the future", "Alba wants you to see her new plans for her district, and ask your opinion about it.", 59, 13003);
			CityControl.city100Order -= 3;
			CityControl.city100Happiness += 4; 
			GameControl.attAlignment -= 5;
			return;
		}

		if (selector == 1 && confirmationControl == 102) {
			WorldControl.day += 5;
			Board.text = "You tell the crowd that you’ll give the brigands one last chance at reform, and that you’ll ensure they redeem themselves for their wrongdoings.\n\nYou talk with the bandits, and after five days, things begin to improve, though the population remains uneasy. A large crowd gathers once more in front of your castle, though it is not as big as before. The same leader talks with you, and explains that your personal army makes everyone feel nervous, despite being better behaved than before.\n\nThe talk goes for hours, until you find some middle ground. You could allow them to organize their own small militias; paramilitary groups and neighborhood watches that can protect them and make them feel more secure. You will lose some power over the city, and you believe that corruption will spread more easily too with your loosened control. The streets would certainly be safer, though. At this point, however, the protest have weakened significantly, enough that you could simply ignore them and continue to expand your private army.\n";
			option0Name.text = "Free militias";
			option1Name.text = "Personal militias only";
			confirmationControl = 103; 
			GameControl.attAlignment += 2;
			return;
		}
		///////////////////////////// Free / personal militias

		if (selector == 0 && confirmationControl == 103) {
			Board.text = "You decide to give in to the people's demands, and tell them that they are free to organize their own groups, so long as they keep you informed about it. \n\nThe leader and the crowd cheer at you, and after he gives a short speech about the importance of freedom, they finally start to leave. Your streets are finally free of their presence, after weeks of occupation. \n\nShortly after, a courier hands you a message from Alba, requesting that you join her to talk about business.\n\n";
			QuestControl.albaQuest = 3;
			WorldControl.day += 2;
			QuestsController.RemoveID (13002);
			Quest AlbaQuest4 = new Quest(); 
			QuestsController.createQuest (AlbaQuest4, "Forging the future", "Alba wants you to see her new plans for her district, and ask your opinion about it.", 59, 13003);
			CityControl.city100Order += 3;
			CityControl.city100Happiness -= 2; 
			CityControl.city100Prosperity -= 1; 
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 103) {
			Board.text = "You inform them that you have already done too much for them, and that they are now pushing you too far. You can still hear them yelling at you when you return to your castle, but after some time they finally disperse, knowing they won’t change your mind anymore, and already got most of what they wanted. \n\nShortly after a courier gives you a message from Alba, asking you to go join her to talk about business, related to her industry. ";
			QuestControl.albaQuest = 3;
			WorldControl.day += 2;
			QuestsController.RemoveID (13002);
			Quest AlbaQuest4 = new Quest(); 
			QuestsController.createQuest (AlbaQuest4, "Forging the future", "Alba wants you to see her new plans for her district, and ask your opinion about it.", 59, 13003);
			CityControl.city100Order += 1;
			CityControl.city100Happiness += 2; 
			CityControl.city100Prosperity -= 1; 
			endTurnFun ();
			return;
		}

		///////////////////////////// jail / execute

		if (selector == 0 && confirmationControl == 104) {
			Board.text = "You order your retainer to take them to the dungeon. <i>“Very well, they will rot in  there. Hope you enjoy your new home, crybaby.”</i>\n\nShe takes the leaders of the group with her, while the rest receive a good beating before they are dismissed. <i>“This worked pretty well. Aren’t you happy you hired us?”</i> You nod, she has indeed been an efficient servant.\n\nThree days go by without any sign of further protest. It seems the population got your message loud and clear. At the end of the day, a courier arrives with a letter from Alba, asking you to join her as soon as you can to talk about business that still needs to be attended. You tell the courier that you’ll be there as soon as you can, and dismiss him.\n";
			WorldControl.day += 3;
			QuestControl.albaQuest = 3;
			QuestsController.RemoveID (13002);
			Quest AlbaQuest4 = new Quest(); 
			QuestsController.createQuest (AlbaQuest4, "Forging the future", "Alba wants you to see her new plans for her district, and ask your opinion about it.", 59, 13003);
			endTurnFun ();
			CityControl.city100Order += 2;
			CityControl.city100Happiness -= 5; 
			CityControl.city100Prosperity -= 0.5f; 
			GameControl.attAlignment -= 2;
			return;
		}

		if (selector == 1 && confirmationControl == 104) {
			Board.text = "You order your retainer to hang them in the main square, to show that you mean business. <i>“Very well. I’ll let their bodies rot for a couple of days, so the whole city can have a good look at these disobedient bastards.”</i>\n\nShe takes the leaders of the group with her, while the rest receive a good beating before being dismissed. <i>“This worked pretty well. Aren’t you happy you hired us?”</i> you nod, she has indeed been an efficient servant \n\nThree days go by and with that display of horror in the square, no new signs of protest arise. It seems as though the population got your message loud and clear. At the end of the day, a courier arrives with a letter from Alba, asking you to join her as soon as you can, to talk about business that still needs to be attended. You tell the courier that you’ll be there as soon as you can, and dismiss him.\n";
			WorldControl.day += 3;
			QuestControl.albaQuest = 3;
			QuestsController.RemoveID (13002);
			Quest AlbaQuest4 = new Quest(); 
			QuestsController.createQuest (AlbaQuest4, "Forging the future", "Alba wants you to see her new plans for her district, and ask your opinion about it.", 59, 13003);
			endTurnFun ();
			CityControl.city100Order += 4;
			CityControl.city100Happiness -= 10; 
			GameControl.attAlignment -= 5;
			return;
		}

		///////////////////////////// temp

		if (selector == 0 && confirmationControl == 9999) {
			Board.text = "";
			return;
		}

		if (selector == 1 && confirmationControl == 9999) {
			Board.text = "";
			return;
		}



	}
	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void loadAlba(){
		iAlba = 0;

		while (iAlba < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iAlba].charID == 13000){
				WorldControl.NPCID = NPCCharList.CharFollower [iAlba].charID;
				WorldControl.PortraitIDLayer0 = NPCCharList.CharFollower [iAlba].charPortraitLayer0;
				WorldControl.PortraitIDLayer1 = NPCCharList.CharFollower [iAlba].charPortraitLayer1;
				WorldControl.PortraitIDLayer2 = NPCCharList.CharFollower [iAlba].charPortraitLayer2;
				WorldControl.furryPic = NPCCharList.CharFollower [iAlba].isFurry;
				WorldControl.futaPic = NPCCharList.CharFollower [iAlba].isFuta;
				break; 
			}
			iAlba++;

		}

	}

	void endTurnFun(){
		//panContinue.sortingOrder = -500;
		panConfirmation.sortingOrder = -500;
		panMainPanel.sortingOrder = -500;

		PanLeftManagement.endTurnControl = true; 
		endTurnPanel.sortingOrder = 500;


	}

	void Awake(){
		loadAlba ();
	}


	void Start () {
		option0Name.text = "";
		option1Name.text = "";
		option2Name.text = "";
		option2Butt.interactable = false; 

		if (GameControl.mcGender == GameControl.MCGender.MALE) {
			//mcpronoun = "Lord";
		} else {
			//mcpronoun = "Lady";
		}
		albaStart ();

	}


}
