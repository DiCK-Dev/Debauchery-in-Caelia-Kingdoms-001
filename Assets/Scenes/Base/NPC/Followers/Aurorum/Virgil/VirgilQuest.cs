using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VirgilQuest : MonoBehaviour {

	public Text Board; 
	static int iVirgil;

	int iVar, i; 

	static int confirmationControl; 
	static int continueControl; 

	public Canvas endTurnPanel; 
	public Canvas panConfirmation;


	public Text option0Name;
	public Text option1Name;
	public Text option2Name;
	public Text option3Name;

	public Button option2Butt; 
	public Button option3Butt; 


	static string lordlady; // lord/lady



	void questStart(){
		int i = 0;
		switch (QuestControl.virgilQuest) {
		case 0: // intro - Aurorum university 
			WorldControl.day += 2; 
			Board.text = VirgilQuestCorrupt.corruptQuest (0); // this detects both
			WorldControl.PortraitIDLayer0 = 10050;
			WorldControl.day += 2; 
			//create new quest
			iVar = loadChar (7000);

			if (NPCCharList.CharFollower [iVar].charCorruption > 50) {
				NPCCharList.CharFollower [loadChar (10000)].charCorruption = 50;
				NPCCharList.CharFollower [iVirgil].charCorruption = 50;
				QuestControl.virgilQuest = 100; 
			} else {
				NPCCharList.CharFollower [loadChar (10000)].charCorruption = 0;
				NPCCharList.CharFollower [iVirgil].charCorruption = 0;
				QuestControl.virgilQuest = 1; 
			}

			while (i < QuestsController.ActiveQuests.Count) {
				QuestsController.RemoveID (9000);
				i++;
			}

			QuestsController.RemoveID (9000);
			Quest virgilQuest1 = new Quest ();
			QuestsController.createQuest (virgilQuest1, "First lesson", "After your unsuccesful meeting with Celia, you decide to visit Virgil and learn the basics of the city.", 64, 9001);
			endTurnFun ();
			break;
		case 1: // First lesson pure 
			WorldControl.day += 2; 
			Board.text = VirgilQuestPure.pureQuest (0);
			option0Name.text = "Tease him";
			option1Name.text = "Confront him";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 0;

			break; 
		case 2: // improving his attitude
			WorldControl.day += 2; 
			Board.text = VirgilQuestPure.pureQuest (3);
			option0Name.text = "Easy girl";
			option1Name.text = "Pure girl";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 1;
			break;
		case 3: // wingman
			WorldControl.day += 2; 
			Board.text = VirgilQuestPure.pureQuest (4);
			option0Name.text = "Spike";
			option1Name.text = "Encourage";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 2;
			break;

		case 4: // learning time I  pure 
			Board.text = VirgilQuestPure.pureQuest (10);
			WorldControl.day += 2; 

			QuestControl.virgilQuest = 5;

			PanLeftManagement.endTurnControl = true; 
			QuestsController.RemoveID (9004);
			Quest virgilQuest5 = new Quest ();
			QuestsController.createQuest (virgilQuest5, "Learning time II", "Today's lesson is about alchemy and other relevant topics.", 64, 9005);

			endTurnFun ();
			break;
		case 5: // learning time II pure 
			Board.text = VirgilQuestPure.pureQuest (11);
			WorldControl.day += 2; 

			QuestControl.virgilQuest = 6;

			PanLeftManagement.endTurnControl = true; 
			QuestsController.RemoveID (9005);
			Quest virgilQuest6 = new Quest ();
			QuestsController.createQuest (virgilQuest6, "Learning time III", "The final lesson!", 64, 9006);


			endTurnFun ();
			break;
		case 6: // learning time III pure 
			WorldControl.day += 2; 
			Board.text = VirgilQuestPure.pureQuest (12);
			option0Name.text = "Philosophy book";
			option1Name.text = "Manifest";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 4;

			while (i < QuestsController.ActiveQuests.Count) {
				QuestsController.RemoveID (9004);
				i++;
			}


			break; 
		case 7: // time out 
			WorldControl.day += 2; 
			Board.text = "Virgil asked you to meet him tonight, but instead of the usual place, his office, he says he’ll wait for you at the rooftop of the building. \n\nOnce there, you find the Wallaby waiting for you at one of the corners. He raises his hand and salutes you, but you can see he is worried. When you arrive at his side, the first question you ask is why he chose this particular place. \n\n<i>“Eh?... Is it that weird?... Well, I wanted to talk about something but, the office was not a good place for that and I don’t really know many places of the city to visit that are appropriate.”</i> \n\nYou nod and ask if everything is all right. <i>“That’s a good question, my Liege, I wonder exactly the same thing... Is everything all right? In this city? With me?... Things have been changing since you arrived and... I need guidance. I want you to help me to understand where we’re going. Can you help me "+ GameControl.playerName+ "?”</i>\n\nThe both of you turn around and look at the city. At this time of the night there is a peaceful aura created by the silence and the dim lights illuminating the streets, but you know that he is right, things have and will keep changing.\n\nYou look at him, his concerned expression more pronounced thanks to the moonlight, waiting for you.\n\nAt this point, you think this might be the last chance you have to influence him before is too late, although past decisions can still out weight what you tell him now, it’s worth a shot. \n\nYou could suggest him that the future of the city relies on order, a strong social structure and probably tough policy. You could, too, tell him that it is time to go back to the original roots, to return to that primal stage of society and to let freedom reign. \n\n<i>“"+ GameControl.playerName+ "?”</i>\n\nWhat will you tell him?";

			option0Name.text = "Order";
			option1Name.text = "Freedom";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 5;

			break; 

		case 8: // finally lesson
			WorldControl.day += 2; 
			QuestControl.virgilQuest = 200;
			QuestsController.RemoveID (9008);
			Quest celiaQuest1 = new Quest ();

			NPCCharList.CharFollower [iVirgil].isRecruited = true;

			if (NPCCharList.CharFollower [loadChar (10000)].charCorruption >= 50) {
				QuestsController.createQuest (celiaQuest1, "Meeting Celia", "Although you already met Celia, you didn't had the chance to speak with the dean.", 67, 10000);

			} else {
				QuestsController.createQuest (celiaQuest1, "Meeting Celia", "Although you already met Celia, you didn't had the chance to speak with the dean.", 67, 10000);

			}

			PanLeftManagement.endTurnControl = true;

			if (NPCCharList.CharFollower [iVirgil].charCorruption >= 50) {
				NPCCharList.CharFollower [iVirgil].charCorruption = 100;
				Board.text = VirgilQuestCorrupt.corruptQuest (23);

	 
			} else {
				NPCCharList.CharFollower [iVirgil].charCorruption = 0;
				Board.text = VirgilQuestPure.pureQuest (16);
			} 

			if (NPCCharList.CharFollower [iVirgil].charLove > 0) {

				option0Name.text = "Stay";
				option1Name.text = "Leave";
				panConfirmation.sortingOrder = 500;
				confirmationControl = 6;
			} else {


				endTurnFun ();
			}
			break;
		case 100: // first lesson corr
			WorldControl.day += 2; 
			Board.text = VirgilQuestCorrupt.corruptQuest (1);
			option0Name.text = "Let him";
			option1Name.text = "Stop him";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 100;
			break;
		case 101:
			WorldControl.day += 2; 
			Board.text = VirgilQuestCorrupt.corruptQuest (4);
			option0Name.text = "Easy girl";
			option1Name.text = "Pure girl";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 102;
			break;
		case 102:
			WorldControl.day += 2; 
			Board.text = VirgilQuestCorrupt.corruptQuest (5);
			option0Name.text = "Do drugs"; // dont do drugs kids 
			option1Name.text = "Encourage him";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 103;
			break;
		case 103: // learning time I
			Board.text = VirgilQuestCorrupt.corruptQuest (21);
			WorldControl.day += 2; 

			QuestControl.virgilQuest = 104;

			PanLeftManagement.endTurnControl = true; 

			QuestsController.RemoveID (9004);
			Quest virgilQuest5c = new Quest ();
			QuestsController.createQuest (virgilQuest5c, "Learning time II", "Hopefully he'll be able to teach whatever you need to learn.", 64, 9005);

			endTurnFun ();

			break; 
		case 104: // learning time II 
			WorldControl.day += 2; 
			Board.text = VirgilQuestPure.pureQuest (11);

			QuestControl.virgilQuest = 105;

			PanLeftManagement.endTurnControl = true; 
			QuestsController.RemoveID (9005);
			Quest virgilQuest6c = new Quest ();
			QuestsController.createQuest (virgilQuest6c, "Learning time III", "The final lesson!", 64, 9006);

			endTurnFun ();
			break; 

		case 105: // learning time III 
			Board.text = VirgilQuestPure.pureQuest (12);
			WorldControl.day += 2; 
			option0Name.text = "Philosophy book"; // dont do drugs kids 
			option1Name.text = "Manifest";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 110;

			while (i < QuestsController.ActiveQuests.Count) {
				QuestsController.RemoveID (9004);
				i++;
			}

			break;
		case 106: // time out
			QuestControl.virgilQuest = 7;
			questStart ();
			break;
		case 107: // final lesson
			QuestControl.virgilQuest = 8;
			questStart ();
			return;
		default:
			Board.text = "This is all the content available for Virgil in 0.2.5 dev, look forward the next update!";
			endTurnFun ();
			//the quest currently ends at 200
			break;


		}

	}


	public void confirmFun(int selector){
		///////////////////////////// Tease him / cronfront him 
		if (selector == 0 && confirmationControl == 0) {
			

			Board.text = VirgilQuestPure.pureQuest (1);

			QuestControl.virgilQuest = 2;
			QuestsController.RemoveID (9001);
			Quest virgilQuest2 = new Quest ();
			QuestsController.createQuest (virgilQuest2, "Improving his attitude", "Virgils attitude is of no use to you, you come up with a plan and a surprise that may help him change...", 64, 9002);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 0) {
			Board.text = VirgilQuestPure.pureQuest (2);


			QuestControl.virgilQuest = 2;
			QuestsController.RemoveID (9001);
			Quest virgilQuest2 = new Quest ();
			QuestsController.createQuest (virgilQuest2, "Improving his attitude", "Virgils attitude is of no use to you, you come up with a plan and a surprise that may help him change...", 64, 9002);
			endTurnFun ();
			return;
		}

		///////////////////////////// easy girl / pure girl

		if (selector == 0 && confirmationControl == 1) {
			Board.text = "Yeah, this girl is probably going to make the whole process of building up his confidence faster. You start to talk good about this woman, her achievements, and why you personally recommend her. She looks at you with skepticism, since you barely knew her name at all a couple of days ago, and most of what you said about her was a lie, but all of your servants stay quiet, as they should.\n\n<i>“V-very well, if you recommend her personally, I’ll guess it would be both rude and dumb to refuse. You’ll come with me.”</i> For now, she will have to live in the small place he has in the university, but he will be able to afford a house to move soon enough.\n\nYou slap her ass when she is on her way out, and she laughs. You hint to Virgil that he can have good fun with her too. <i>“I... I’ll think about it...”</i> he says ashamed, but you know he wouldn’t do something like this anytime soon. ";

			NPCCharList.CharFollower [iVirgil].charCorruption += 25;
			NPCCharList.CharFollower [iVirgil].attLibido = 100;
			QuestControl.virgilQuest = 3;
			QuestsController.RemoveID (9002);
			Quest virgilQuest3 = new Quest ();
			QuestsController.createQuest (virgilQuest3, "The Wingman", "After giving Virgil some time to get used to his new life, you decide it's time to give the next step.", 64, 9003);
			endTurnFun ();

			return;
		}

		if (selector == 1 && confirmationControl == 1) {
			Board.text = "Yes, this girl will help him to build his confidence and become the righteous man that you need in your ranks. You start to talk good about this woman and her achievements. She is proud, but she is humble enough to not make it obvious.  \n\n<i>“V-very well, if you recommend her personally, I’ll guess it would be both rude and dumb to refuse. You’ll come with me.”</i> For now, she will have to live in the small place he has in the university, but he will be able to afford a house to move soon enough.\n\nShe bows profusely and thanks you for being always a good leader, and you too thank her for her diligent service. You tell to Virgil that you could learn a lot of things from her, and he nods, confident that these words have truth in them.";

			NPCCharList.CharFollower [iVirgil].attLibido = 0;
			QuestControl.virgilQuest = 3;
			QuestsController.RemoveID (9002);
			Quest virgilQuest3 = new Quest ();
			QuestsController.createQuest (virgilQuest3, "The Wingman", "After giving Virgil some time to get used to his new life, you decide it's time to give the next step.", 64, 9003);
			endTurnFun ();
			return;
		}

		///////////////////////////// Spike / encourage

		if (selector == 0 && confirmationControl == 2) {
			Board.text = VirgilQuestPure.pureQuest (5);
			NPCCharList.CharFollower [iVirgil].charCorruption += 25; 
			NPCCharList.CharFollower [iVirgil].charAddictions [0] = 100;
			option0Name.text = "Slut";
			option1Name.text = "Nerdy girl";
			option2Name.text = "Yourself";
			option2Butt.interactable = true;
			panConfirmation.sortingOrder = 500;
			confirmationControl = 3;
			PanLeftManagement.endTurnControl = true; 

			QuestControl.virgilQuest = 4;

			int i = 0;
			while (i < QuestsController.ActiveQuests.Count) {
				QuestsController.RemoveID (9004);
				i++;
			}

			QuestsController.RemoveID (9003);

			Quest virgilQuest4 = new Quest ();
			QuestsController.createQuest (virgilQuest4, "Learning time!", "Hopefully he'll be able to teach whatever you need to learn.", 64, 9004);
			return;
		}

		if (selector == 1 && confirmationControl == 2) {
			Board.text = VirgilQuestPure.pureQuest (6);
			option0Name.text = "Slut";
			option1Name.text = "Nerdy girl";
			option2Name.text = "Yourself";
			option2Butt.interactable = true;
			panConfirmation.sortingOrder = 500;
			confirmationControl = 3;

			QuestControl.virgilQuest = 4;

			int i = 0;
			while (i < QuestsController.ActiveQuests.Count) {
				QuestsController.RemoveID (9004);
				i++;
			}



			PanLeftManagement.endTurnControl = true; 
			QuestsController.RemoveID (9003);
			Quest virgilQuest4 = new Quest ();
			QuestsController.createQuest (virgilQuest4, "Learning time!", "Hopefully he'll be able to teach whatever you need to learn.", 64, 9004);

			return;
		}

		///////////////////////////// slutty nerdy yourself from spike 

		if (selector == 0 && confirmationControl == 3) {
			Board.text = VirgilQuestPure.pureQuest (7);

			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 3) {
			Board.text = VirgilQuestPure.pureQuest (8);

			endTurnFun ();
			return;
		}

		if (selector == 2 && confirmationControl == 3) {
			Board.text = VirgilQuestPure.pureQuest (9);

			endTurnFun ();
			return;
		}

		///////////////////////////// philosophy manifest

		if (selector == 0 && confirmationControl == 4) {
			Board.text = VirgilQuestPure.pureQuest (13);

			QuestControl.virgilQuest = 7;

			PanLeftManagement.endTurnControl = true; 
			QuestsController.RemoveID (9006);
			Quest virgilQuest7 = new Quest ();
			QuestsController.createQuest (virgilQuest7, "Time out", "Virgil asks you to visit him to have a personal talk with you.", 64, 9007);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 4) {
			Board.text = VirgilQuestPure.pureQuest (14);

			QuestControl.virgilQuest = 7;

			PanLeftManagement.endTurnControl = true; 
			QuestsController.RemoveID (9006);
			Quest virgilQuest7 = new Quest ();
			QuestsController.createQuest (virgilQuest7, "Time out", "Virgil asks you to visit him to have a personal talk with you.", 64, 9007);
			endTurnFun ();
			return;
		}

		///////////////////////////// order freedom

		if (selector == 0 && confirmationControl == 5) {
			NPCCharList.CharFollower [iVirgil].charCorruption -= 25;
			if (NPCCharList.CharFollower [iVirgil].charCorruption >= 100) {
				NPCCharList.CharFollower [iVirgil].charCorruption = 100;
			} else if (NPCCharList.CharFollower [iVirgil].charCorruption < 0) {
				NPCCharList.CharFollower [iVirgil].charCorruption = 0;
			}


			Board.text = VirgilQuestPure.pureQuest (15);


			QuestControl.virgilQuest = 8;

			PanLeftManagement.endTurnControl = true; 
			QuestsController.RemoveID (9007);
			Quest virgilQuest8 = new Quest ();
			QuestsController.createQuest (virgilQuest8, "Final lesson", "You finally finished your course with Virgil, what's next?.", 64, 9008);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 5) {

			NPCCharList.CharFollower [iVirgil].charCorruption += 25;
			if (NPCCharList.CharFollower [iVirgil].charCorruption >= 100) {
				NPCCharList.CharFollower [iVirgil].charCorruption = 100;
			} else if (NPCCharList.CharFollower [iVirgil].charCorruption < 0) {
				NPCCharList.CharFollower [iVirgil].charCorruption = 0;
			}


			Board.text = VirgilQuestCorrupt.corruptQuest(22);

			QuestControl.virgilQuest = 8;

			PanLeftManagement.endTurnControl = true; 
			QuestsController.RemoveID (9007);
			Quest virgilQuest8 = new Quest ();
			QuestsController.createQuest (virgilQuest8, "Final lesson", "You finally finished your course with Virgil, what's next?.", 64, 9008);
			endTurnFun ();
			return;
		}

		///////////////////////////// Stay / leave

		if (selector == 0 && confirmationControl == 6) {
			Board.text = VirgilQuestPure.pureQuest(17);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 6) {
			Board.text = "You profoundly apologize, but right now is not a good moment for that. You can see the sadness on his face, and you try to cheer him up telling him you both will have a lot of time for being together in the future. <i>“Y-you promise?”</i> yeah, of course you do. He jumps on you and kisses you one last time. <i>“Very well, but you will have to make up for leaving me today then.”</i> both of you laugh, and you caress his cheek before taking your stuff and leaving the place. \n\nNow it is time to deal with Celia.";
			endTurnFun ();
			return;
		}

		///////////////////////////// let him  stop him

		if (selector == 0 && confirmationControl == 100) {
			Board.text = "When he realizes you don’t mind he keeps getting closer to your crotch, but you grab his hand once he is close enough, and confront him. He panics at your reaction, and starts to beg for forgiveness <i>“No! I am sorry my Liege! My body has a mind of it’s own! I didn’t mean it!”</i> You laugh at his words, and command him to sit on the chair. He immediately does so, looking down as a scolded child. \n\nYou ask about what is his problem “I... Is...” You ask him to hurry, and he shrieks out of fear <i>“Yes!... This... Problem started with the new church! All of those skimpy clothed followers of god, the obscene sounds from the confessional... Have awoken this inside me and I cant control it... You know, I barely head outside and... Well, my body has needs!”</i>\n\nSo, what Virgil needs is a girlfriend or boyfriend uh? Well, you can take care of that, one way or another, but it’s apparent that for now you’ll not be able to get the lessons that you need out of him.\n\nYou tell him that you will help get what he needs <i>“W-what? Really? My Liege I am really thankful for that!”</i> he does a grateful low bow at you. When he stands up again, you notice he still has a raging boner. Although this is not something that is going to be fixed in a single day but, for now you could have some fun with him, what should you do...";

			NPCCharList.CharFollower [iVirgil].charLove = 10;

			option0Name.text = "69";
			option1Name.text = "Mutual masturbation";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 101;

			PanLeftManagement.endTurnControl = true; 
			QuestControl.virgilQuest = 101;
			QuestsController.RemoveID (9001);

			Quest virgilQuest2 = new Quest ();
			QuestsController.createQuest (virgilQuest2, "Improving his attitude", "Virgils attitude is of no use to you, you come up with a plan and a surprise that may help him change...", 64, 9002);

			return;
		}

		if (selector == 1 && confirmationControl == 100) {
			Board.text = "You grab his hand before he can reacts. He shrieks out of fear <i>“Sorry my Liege! It was not my intention!”</i> But you are not happy with his answer, and ask him to explain himself. <i>“I... Eh... Is just, you know! It’s that damn church, full of scantly dressed people, those obscene sounds coming out of the confessional... You know, its messing with my head! I have... These feelings, down there, all the time!”</i> Well, at least the church is doing it’s job as you expected. \n\nNonetheless, this is of no use to you, and if he cant focus on teaching you, you’ll have to deal with this thing first. You think for a moment, while expecting the worst. Finally, you tell him that you’ll help him with his issue <i>“Seriously? Thank you my Liege! I am really grateful!”</i> You say that is nothing, and to be ready for when you come back.\n\nYou go back to your castle after this... unfortunate day, and wonder how you’ll manage to get an awkward brat like him to get laid.";

			NPCCharList.CharFollower [iVirgil].charLove = 0;

			PanLeftManagement.endTurnControl = true; 
			QuestControl.virgilQuest = 101;
			QuestsController.RemoveID (9001);
			Quest virgilQuest2 = new Quest ();
			QuestsController.createQuest (virgilQuest2, "Improving his attitude", "Virgils attitude is of no use to you, you come up with a plan and a surprise that may help him change...", 64, 9002);
			endTurnFun ();
			return;
		}

		///////////////////////////// 69  mutual


		if (selector == 0 && confirmationControl == 101) {
			Board.text = VirgilQuestCorrupt.corruptQuest (2);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 101) {
			Board.text = VirgilQuestCorrupt.corruptQuest (3);
			endTurnFun ();
			return;
		}

		///////////////////////////// Easy girl pure girl 

		if (selector == 0 && confirmationControl == 102) {
			Board.text = "Yeah, this girl is probably going to make the whole process of building up his confidence a lot faster... Or, at the very least, drain enough of his libido away for him to focus. You start to vouch the qualities of this woman and her achievements, and why you would personally recommend her. She looks at you with skepticism; considering you barely even know her name and you’re babbling nothing but random lies. Thankfully all of your servants stay quiet, as they should.\n\n<i>“V-very well, if you recommend her personally, I guess it would be both rude and stupid to refuse. You’ll come with me.”</i> For now, she will have to live in the small place he has at the university, but he will be able to afford a house to move soon enough.\n\nYou slap her ass when she is on her way out, and she laughs. You hint to Virgil that he can have good fun with her too. <i>“I... I’ll make sure to test that out, my Liege...”</i> he says, the erection in his pants growing bigger.\n\nLastly, you hand him a bag of gold coins; enough to buy some new clothing appropriate for his new station. <i>“My Liege... This is too much I... I’ll repay you all of this, I swear!”</i> You nod, knowing he will but for now he needs to get used to his new life. With some luck, this will help with his attitude... at least bossing someone around and not being dependent on Celia’s mood swings should have some positive effect on him. ";
			NPCCharList.CharFollower [iVirgil].charCorruption += 25; 
			NPCCharList.CharFollower [iVirgil].attLibido = 100;

			QuestControl.virgilQuest = 102;
			QuestsController.RemoveID (9002);
			Quest virgilQuest3 = new Quest ();
			QuestsController.createQuest (virgilQuest3, "The Wingman", "After giving Virgil some time to get used to his new life, you decide it's time to give the next step.", 64, 9003);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 102) {
			Board.text = "Yes, this girl will help him to build his confidence and become the righteous man that you need in your endeavors. You start to talk up the qualities of this this woman and her achievements. She is proud, but she’s humble enough to not make it obvious.  \n\n<i>“V-very well, if you recommend her personally, I’ll guess it would be both rude and dumb to refuse. You’ll come with me.”</i> For now, she will have to live in the small place he has in the university, but he will be able to afford a house to move soon enough.\n\nShe bows profusely and thanks you for being such a good leader, and you too thank her for her diligent service. You tell to Virgil that he could learn a lot of things from her... but he ignores you, day dreaming with a smile on his face about what he’ll do to her. Oh boy...\n\nLastly, you hand him a bag of gold coins; enough to buy some new clothing appropriate for his new station. <i>“My Liege... This is too much I... I’ll repay you all of this, I swear!”</i> You nod, knowing he will but for now he needs to get used to his new life. With some luck, this will help with his attitude... at least bossing someone around and not being dependent on Celia’s mood swings should have some positive effect on him. ";
			NPCCharList.CharFollower [iVirgil].charCorruption -= 25; 
			NPCCharList.CharFollower [iVirgil].attLibido = 0;

			QuestControl.virgilQuest = 102;
			QuestsController.RemoveID (9002);
			Quest virgilQuest3 = new Quest ();
			QuestsController.createQuest (virgilQuest3, "The Wingman", "After giving Virgil some time to get used to his new life, you decide it's time to give the next step.", 64, 9003);
			endTurnFun ();
			return;
		}

		///////////////////////////// Do drugs / encourage from wingman

		if (selector == 0 && confirmationControl == 103) {
			Board.text = VirgilQuestCorrupt.corruptQuest (6);

			PanLeftManagement.endTurnControl = true; 

			NPCCharList.CharFollower [iVirgil].charCorruption += 25; 
			NPCCharList.CharFollower [iVirgil].charAddictions [0] = 100;

			option0Name.text = "Slut";
			option1Name.text = "Nerdy girl";
			option2Name.text = "Yourself";
			option2Butt.interactable = true;
			confirmationControl = 104;

			QuestControl.virgilQuest = 103;
			QuestsController.RemoveID (9003);
			Quest virgilQuest4 = new Quest ();
			QuestsController.createQuest (virgilQuest4, "Learning time!", "Hopefully he'll be able to teach whatever you need to learn. ", 64, 9004);
			return;
		}

		if (selector == 1 && confirmationControl == 103) {
			Board.text = VirgilQuestCorrupt.corruptQuest (7);

			NPCCharList.CharFollower [iVirgil].charCorruption -= 25; 

			option0Name.text = "Slut";
			option1Name.text = "Nerdy girl";
			option2Name.text = "Yourself";
			option2Butt.interactable = true;
			confirmationControl = 105;

			QuestControl.virgilQuest = 103;
			QuestsController.RemoveID (9003);
			Quest virgilQuest4 = new Quest ();
			QuestsController.createQuest (virgilQuest4, "Learning time!", "Hopefully he'll be able to teach whatever you need to learn. ", 64, 9004);
			return;
		}

		///////////////////////////// drugs sluty nerdy yoursef

		if (selector == 0 && confirmationControl == 104) {
			Board.text = VirgilQuestCorrupt.corruptQuest (8);
			option0Name.text = "Fuck him";
			option1Name.text = "Fuck her";
			option2Name.text = "Leave";
			option2Butt.interactable = true;
			confirmationControl = 106;
			return;
		}

		if (selector == 1 && confirmationControl == 104) {
			Board.text = VirgilQuestCorrupt.corruptQuest (9);
			option0Name.text = "Have sex";
			option1Name.text = "Leave";
			option2Name.text = "";
			option2Butt.interactable = false;
			confirmationControl = 108;
			return;
		}

		if (selector == 2 && confirmationControl == 104) {
			Board.text = VirgilQuestPure.pureQuest (9);
			endTurnFun ();
			return;
		}

		///////////////////////////// encourage  sluty nerdy yoursef

		if (selector == 0 && confirmationControl == 105) { //slut
			Board.text = VirgilQuestCorrupt.corruptQuest (14);
			option0Name.text = "Fuck him";
			option1Name.text = "Fuck her";
			option2Name.text = "Leave";
			option2Butt.interactable = true;
			confirmationControl = 107;
			return;
		}

		if (selector == 1 && confirmationControl == 105) {
			Board.text = VirgilQuestCorrupt.corruptQuest (18);
			option0Name.text = "Have sex";
			option1Name.text = "Leave";
			option2Name.text = "";
			option2Butt.interactable = false;
			confirmationControl = 109;
			return;
		}

		if (selector == 2 && confirmationControl == 105) {
			Board.text = VirgilQuestPure.pureQuest(9);
			endTurnFun ();
			return;
		}

		///////////////////////////// drug / slut /   Fuck him fuck her leave

		if (selector == 0 && confirmationControl == 106) {
			Board.text = VirgilQuestCorrupt.corruptQuest (11);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 106) {
			Board.text = VirgilQuestCorrupt.corruptQuest (12);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 106) {
			Board.text = VirgilQuestCorrupt.corruptQuest (13);
			endTurnFun ();
			return;
		}

		///////////////////////////// encourage / slut /   Fuck him fuck her leave

		if (selector == 0 && confirmationControl == 107) {
			Board.text = VirgilQuestCorrupt.corruptQuest (15);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 107) {
			Board.text = VirgilQuestCorrupt.corruptQuest (12);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 107) {
			Board.text = VirgilQuestCorrupt.corruptQuest (13);
			endTurnFun ();
			return;
		}

		///////////////////////////// drug / nerdy /   have sex leave

		if (selector == 0 && confirmationControl == 108) {
			Board.text = VirgilQuestCorrupt.corruptQuest (16);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 108) {
			Board.text = VirgilQuestCorrupt.corruptQuest (17);
			endTurnFun ();
			return;
		}

		///////////////////////////// encourage / nerdy /   have sex leave

		if (selector == 0 && confirmationControl == 109) {
			Board.text = VirgilQuestCorrupt.corruptQuest (19);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 109) {
			Board.text = VirgilQuestCorrupt.corruptQuest (20);
			endTurnFun ();
			return;
		}

		///////////////////////////// philosophy manifest 

		if (selector == 0 && confirmationControl == 110) {

			Board.text = VirgilQuestPure.pureQuest (13);

			QuestControl.virgilQuest = 106;

			PanLeftManagement.endTurnControl = true; 
			QuestsController.RemoveID (9006);
			Quest virgilQuest7c = new Quest ();
			QuestsController.createQuest (virgilQuest7c, "Time out", "Virgil asks you to visit him to have a personal talk with you.", 64, 9007);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 110) {

			Board.text = VirgilQuestPure.pureQuest (14);

			QuestControl.virgilQuest = 106;

			PanLeftManagement.endTurnControl = true; 
			QuestsController.RemoveID (9006);
			Quest virgilQuest7c = new Quest ();
			QuestsController.createQuest (virgilQuest7c, "Time out", "Virgil asks you to visit him to have a personal talk with you.", 64, 9007);
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
		loadVirgil ();
		questStart ();
		if (GameControl.mcGender == GameControl.MCGender.MALE) {
			lordlady = "Lord";
		} else {
			lordlady = "Lady";
		}
	}
	

	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		panConfirmation.sortingOrder = -500;
		endTurnPanel.sortingOrder = 500;


	}



	void loadVirgil(){
		iVirgil = 0;

		while (iVirgil < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iVirgil].charID == 9000){
				WorldControl.NPCID = NPCCharList.CharFollower [iVirgil].charID;
				WorldControl.PortraitIDLayer0 = NPCCharList.CharFollower [iVirgil].charPortraitLayer0;
				WorldControl.PortraitIDLayer1 = NPCCharList.CharFollower [iVirgil].charPortraitLayer1;
				WorldControl.PortraitIDLayer2 = NPCCharList.CharFollower [iVirgil].charPortraitLayer2;
				break; 
			}
			iVirgil++;

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
