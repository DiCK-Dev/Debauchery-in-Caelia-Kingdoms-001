using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VivicaQuest : MonoBehaviour {
	static int iVivica = 0; 
	public Text Board; 

	int iVar; 
	
	static int confirmationControl; 

	public Canvas panRel; 




	public Canvas endTurnPanel; 
	public Canvas panConfirmation;


	public Text option0Name;
	public Text option1Name;
	public Text option2Name;
	public Text option3Name;

	public Button option1Butt; 
	public Button option2Butt; 
	public Button option3Butt; 



	void questStart(){
		int i = 0;
		switch (NPCCharList.CharFollower [iVivica].questControl) {
		case 0:
			Board.text = "Please type the relationships that you have with Vivica and Lucina, i.e. landlady or roommate.\n\nThe first choice it's how you're going to call Vivica, second how she is going to call you, third it's how you're going to call Lucina, fourth how Lucina will refer to you and lastly fifth how Lucina will refer to Vivica.";
			panRel.sortingOrder = 500;
			option0Name.text = "Continue"; 
			confirmationControl = 0; 
			option1Butt.interactable = false;
			NPCCharList.CharFollower [iVivica].charRelationship = 0; 
			NPCCharList.CharFollower [iVivica].charLove = 0;
			NPCCharList.CharFollower [iVivica].charCorruption = 50; 
			NPCCharList.CharFollower [iVivica].attMorality = 50;
			NPCCharList.CharFollower [iVivica].attWillpower = 50;
			NPCCharList.CharFollower [iVivica].attMagicPower = 50; 
			break;
		case 1:
			Board.text = "The next time that you arrive to her, you can see that she is getting some things set up in her bedroom. Most of them are books related to magic theories and alchemy. You tell her that you want to know more of what happened to her. She smiles at your curiosity. <i>“But first, I wanna know about you and your adventures! I have the right to know!”</i> she says with an inquisitive tone, and you sit down and begin to talk, to which she nods happily. You talk about your time in the forest, and the guardian that your "+NPCCharList.CharFollower [loadChar(6000)].relX+" placed to take care of you. You tell of your years of training and the sacrifices made to get you to where you are today.\n\nShe looks quite interested in your past. <i>“You’re quite the survivalist, "+NPCCharList.CharFollower [iVivica].relSN+".”</i> she said after hearing your story. You try to lighten the mood, going into the topic of your childhoods instead.. <i>“Well, of course I remember those things. What about you?”</i> she says with doubt in her eyes. You tell her that you remember, but it has been so long since then, that you want to talk with her about some good times. She sighs and nods. <i>“It has been a while, isn’t it?”</i>\n\nFull of pride, she smiles and sits next toy ou. “Do you remember that my tutors always said that I had a knack for learning? Honestly, that was a pain for me. Learning and developing before everyone else places expectations on you.” You tell her that there were acolytes in the temple, or even some noble people that were ahead of others too, something that made her cross her arms. <i>“They had nothing on me though. Always jealous. Always talking about me behind my back. They were all afraid….. yes, they were all afraid that I was better than them. That I was smarter than them! Do you agree with me, "+NPCCharList.CharFollower [iVivica].relSN+"? You were there too…”</i>";

			panConfirmation.sortingOrder = 500;
			confirmationControl = 1; 
			option0Name.text = "Agree"; 
			option1Name.text = "Disagree"; 
			break; 
		case 2:
			Board.text = "You decide to hear a bit more about your "+NPCCharList.CharFollower [iVivica].relSF+", so you decide to talk to her a bit more about her childhood, interested in filling in the gaps that you are unfamiliar with. Your little "+NPCCharList.CharFollower [iVivica].relSF+" smiles a bit confused while saying, <i>“Come on, you were there.”</i> But you tell her that since the last time you talked, you noticed how little you knew about your little "+NPCCharList.CharFollower [iVivica].relSF+"’s life. You remind her the times that both of you worked at the temple of the city and how she were always there with you.\n\nFloating closer she grins and nods at your memory, <i>“You were one of the only ones that treated me like family, as if I wasn’t someone weird or dangerous, you just treated me as… me. I wanted to help you as much as I could. You were the errand boy, so it was fun to help you carry things, even though I never was known for my strength.”</i> she says, looking at her delicate arms and hands. <i>“You were always so busy working, so I had to take any chance to spend some time with you.”</i> she says with nostalgia and gloom, her eyes looking at the floor.\n\nYour plan was to remember nice things at first, not to dive into some depressive things. Seizing the opportunity as she is looking at the floor, you seize your chance and get close to her. You tickle her sides, making her laugh with force as she tries to stop your hands from tickling her for a second.\n\n<i>“Stop it! I’m sensitive!”</i> Though at this angle you can see how little your "+NPCCharList.CharFollower [iVivica].relSF+" is covered. She is practically naked, just like your "+NPCCharList.CharFollower [loadChar(6000)].relX+". You wonder if something similar happened to them, that would be ironic.";

			panConfirmation.sortingOrder = 500;
			confirmationControl = 2; 
			option0Name.text = "Enjoy her body"; 
			option1Name.text = "Resist thoughts"; 
			break;
		case 3:
			Board.text = "This time, you ask your "+NPCCharList.CharFollower [iVivica].relSF+" about her studies in alchemy, making note of her collection of books within her room. She looks around and nods, as if its something quite obvious at that point. <i>“Do you remember the tutors that mom hired as she always knew that I was quite gifted even at a young age? Ugh, how I hated the first one…”</i> she says with a shudder. You remember that she tore through a lot of tutors, as most of them couldn’t endure her temperament and behavior.\n\nShe continues <i>“When "+NPCCharList.CharFollower [loadChar(6000)].relX+" first introduced the old one, I thought that she would bail just like the others,but surprisingly she endured long enough for me to take a liking on her sturdiness. But I remember how "+NPCCharList.CharFollower [loadChar(6000)].relX+" moved all her influences to find me the best alchemy teacher in the region, and that lady seemed to be the best of the best around here.  At first I thought that she was just an old hag with no skills, but she proved me wrong quickly, with her intelligence, skill, and quick wit.”</i> she says, while sitting on your lap and resting against your chest without saying anything else.\n\nShe laughs a bit. <i>“I kinda tried something that I knew may not work and the table caught fire. Luckily the old one was able to douse it quickly. But the temple priests told "+NPCCharList.CharFollower [loadChar(6000)].relX+" to find me another place to practice. So my "+NPCCharList.CharFollower [loadChar(6000)].relX+" used the old tower at the castle, even thought it was quite ruined but it has enough space for me to practice all I wanted without risk of accidents on others.”</i> You remember the old tower, a place that you forgot what was for and your father didn’t wanted to talk about it. Your "+NPCCharList.CharFollower [loadChar(6000)].relX+" seemed reticent at first, but the alchemist convinced her, but you are not sure how. <i>“I did learned everything she asked of me. I tried my best to learn everything she had in the books she brought with her as I learned a lot from her in the field of alchemy. Even the old one was impressed with how quickly I was able to learn and apply my own thoughts into the recipes.”</i>\n\nYou feel your "+NPCCharList.CharFollower [iVivica].relSF+" tense up a bit as she continues on, <i>“But with all good things, it couldn’t last forever.  You remember that fateful night when "+NPCCharList.CharFollower [loadChar(6000)].relX+" came into the tower and hurried us to leave the city with her. It was the night that our uncle attacked father. We left the tower through a secret passage to the city walls. I wondered why our "+NPCCharList.CharFollower [loadChar(6000)].relX+" was with us and not with father, thinking that you might go to him and get swept away by death.”</i> \n\nVivica clenches her fist but still goes on, <i>“We ran through the forest on a horse as far as we could, and before I could realize what happened, I was in a cave far away from the city.  I was furious. I argued with the old one for hours until she told me that if I returned to the city, I would get killed. That the only thing I could do was to study more, to build up my powers and wait for the day that I would be strong enough to reclaim my heritage”</i> she says, then she looks at you with a hint of surprise and relief.\n\nYou wraps your arms around her as she accepts your embrace, but says nothing about it.  After a while her stomach rumbles a bit, so you tell her that perhaps its time to go and get something to eat. <i>“Yeah, all this nostalgia is making me hungry.”</i> Both of you leave the room and head to the dining hall for some food to swallow down the bad memories.";

			QuestsController.RemoveID (8003);
			Quest vivicaQuest5 = new Quest ();

			NPCCharList.CharFollower [iVivica].questControl = 4;
			QuestsController.createQuest (vivicaQuest5, "Changes.", "Vivica opens up about her transformation.", 68, 8004);


			endTurnFun ();
			break;
		default:
			Board.text = "This is all for this version, look forward for more next month!";
			endTurnFun();
			break;
		}

	}




	public void confirmFun(int selector){

		if (selector == 0 && confirmationControl == 0) {
			Board.text = VivicaQuestPure.pureQuest(0);

			endTurnFun ();


			QuestsController.RemoveID (8000);
			Quest vivicaQuest2 = new Quest ();

			NPCCharList.CharFollower [loadChar (8000)].questControl = 1;
			QuestsController.createQuest (vivicaQuest2, "Catching up", "After a busy day you go back to your castle, just to find out there is an uninvited guest.", 68, 8001);
			return;
		}

		///////////////////////////// agree / disagree

		if (selector == 0 && confirmationControl == 1) {
			Board.text = "You remember them and you know that they weren’t like that, but it wouldn’t hurt to agree and get her on your side even more.  You tell her that those fools were so full of pride and jealousy that they weren’t unable to get more power. That they feared her, because they couldn’t contain her power, and that’s why they were unable to grasp true mastery over the power that surrounds them. She smiles at your honey words for her, as its obvious that was what she wanted to hear.\n\n<i>“That’s what I was saying! Maybe it was for the best. I am destined for great things.”</i> your "+NPCCharList.CharFollower [iVivica].relSF+" cheekily says. You tell her that she must get ready to push away anyone that could hamper her grow, as she has the obligation to be as strongest as she can and lead the weak. Her power demands respect from the weak-willed, especially since she is a magic-user.\n\nShe gets closer to you and hugs you slowly, pressing her face against your chest. <i>“Yes "+NPCCharList.CharFollower [iVivica].relSN+", I am able to rend my enemies with magic. No one will separate our family again. Not while I’m around,”</i> your "+NPCCharList.CharFollower [iVivica].relSF+" says while surges of lightning course through her wings, giving you a literal magic show.\n\nYou think of the capacities of your "+NPCCharList.CharFollower [iVivica].relSF+", and the potential that she has of helping you to further your goals. You pat her head and leave the place without saying anything else.";

			NPCCharList.CharFollower [iVivica].charRelationship = 5;

			QuestsController.RemoveID (8001);
			Quest vivicaQuest3 = new Quest ();

			NPCCharList.CharFollower [iVivica].questControl = 2;
			QuestsController.createQuest (vivicaQuest3, "Intimate night.", "After so many years, you finally get the chance to get closer to you "+NPCCharList.CharFollower [iVivica].relSF+".", 68, 8002);

			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 1) {
			Board.text = "You were there, you remember the situation and you know that it wasn’t the case. You tell her that they weren’t jealous to the core, because they followed her instructions whenever they could. You can’t talk for all of them, but most of them looked up to her, or at least considered her knowledgeable and reliable. She shakes her head at your answer. <i>“You don’t get it. They never talked to me. How could they look up to me, if they didn’t even talked to me? They were envious!”</i> she says as some tears roll out of her eyes. You turned to see her and cleaned one of her tears with your finger, telling her that they felt inferior. You begin to mention some of the rumors they would spread around her, mentioning an inflated ego and a need to shun her, and how they tried to push it onto you.\n\nYour "+NPCCharList.CharFollower [iVivica].relSF+" closes her eyes and places her face against your chest. <i>“Why didn’t you try to tell me?!”</i> You tell her that it was because she always seemed to be so happy and cheerful when she was with you. It’s the first time that you’ve seen her like this and knowing the reason of her tears. You hug her carefully, telling her that you feel sorry for not telling her about this misunderstanding. <i>“Thanks, "+NPCCharList.CharFollower [iVivica].relSN+". I know that I can always count on you”</i>\n\nYou embrace her for quite a while, before she separates a bit and thanks you. After that, you excuse yourself before leaving the place.";

			NPCCharList.CharFollower [iVivica].charReputation = 0; 

			QuestsController.RemoveID (8001);
			Quest vivicaQuest3 = new Quest ();

			NPCCharList.CharFollower [iVivica].questControl = 2;
			QuestsController.createQuest (vivicaQuest3, "Intimate night.", "After so many years, you finally get the chance to get closer to you "+NPCCharList.CharFollower [iVivica].relSF+".", 68, 8002);

			endTurnFun ();
			return;
		}
		///////////////////////////// enjoy her body / resist thoughts 

		if (selector == 0 && confirmationControl == 2) {
			Board.text = "You begin to feel aroused as she forces over you, as she tries to make you submit. Its a struggle that its more of a game rather than a challenge. But you enjoy the feeling of her naked skin against your body. Even thought you think that its something more evident, she doesn’t seems to notice, too absorbed on the play to notice your gaze. After a couple of minutes, both of you call it even and rest a bit, laughing a bit from the “combat”.\n\nBefore you leave the room your "+NPCCharList.CharFollower [iVivica].relSF+" slowly floats up you and kisses you on the cheek softly before turning around as you finally return to your duties.";

			NPCCharList.CharFollower [iVivica].charLove = 5; 

			QuestsController.RemoveID (8002);
			Quest vivicaQuest4 = new Quest ();

			NPCCharList.CharFollower [iVivica].questControl = 3;
			QuestsController.createQuest (vivicaQuest4, "Sadness.", "You spend your night talking wth Vivica, remembering the sad past that the two of you share.", 68, 8003);

			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 2) {
			Board.text = "Shaking such thoughts from your mind, you see that she is struggling to tickle you, so you use your whole body to pin her against the ground and tickle the sides of her head while she tries to bite your hand, without good results. You tell her that you’re her older sibling, its obvious that you have the upper hand. You can see that she tries to raise one hand, but you quickly tell her that the magic is prohibited right now. She laughs and shakes her head. <i>“You’re such a killjoy,”</i> she says as she rest her head on the floor. <i>“You win”</i> she says, panting from the exercise.\n\nSmiling at your victory, you get up and pat your "+NPCCharList.CharFollower [iVivica].relSF+"’s head before leaving the room.";

			NPCCharList.CharFollower [iVivica].charLove = 0; 

			QuestsController.RemoveID (8002);
			Quest vivicaQuest4 = new Quest ();

			NPCCharList.CharFollower [iVivica].questControl = 3;
			QuestsController.createQuest (vivicaQuest4, "Sadness.", "You spend your night talking wth Vivica, remembering the sad past that the two of you share.", 68, 8003);

			endTurnFun ();
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





	void Start () {
		loadVivica ();
		questStart ();


	}





	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		panConfirmation.sortingOrder = -500;
		endTurnPanel.sortingOrder = 500;


	}


	void loadVivica(){
		iVivica = 0;

		while (iVivica < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iVivica].charID == 8000){
				WorldControl.NPCID = NPCCharList.CharFollower [iVivica].charID;
				WorldControl.PortraitIDLayer0 = NPCCharList.CharFollower [iVivica].charPortraitLayer0;
				WorldControl.PortraitIDLayer1 = NPCCharList.CharFollower [iVivica].charPortraitLayer1;
				WorldControl.PortraitIDLayer2 = NPCCharList.CharFollower [iVivica].charPortraitLayer2;
				break; 
			}
			iVivica++;

		}

	}




	int loadChar(int id){
		int i = 0;
		while (i < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [i].charID == id){
				return i;
			}
			i++;

		}
		return 0;

	}


}
