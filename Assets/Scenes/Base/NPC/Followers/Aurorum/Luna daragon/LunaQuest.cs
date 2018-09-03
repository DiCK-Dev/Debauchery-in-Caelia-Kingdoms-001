using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LunaQuest : MonoBehaviour {
	public Text Board; 
	static int iLuna;

	int iVar, iVar2; 

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
		switch (NPCCharList.CharFollower [iLuna].questControl) {
		case 0: // 
			//Board.text = VirgilQuestCorrupt.corruptQuest (0); // this detects both

			WorldControl.day += 2; 

			Board.text = "After the urgent meeting that you had with your advisers, you are urged to deal with Luna as soon as you can. Helena briefed you shortly afterward with all the information that they were given from Abbadon and Alba. \n\nLuna Daragon took over the underground criminal empire that had been built decades ago by her family. They made their fortune by trafficking goods, drugs, and slaves. \n\nThe outbreak affected all of society, including them. Shortly after it started many members of her family fell to madness or were transformed into beasts. Weakened, for the next years they would struggle to keep their power, and in more than one occasion they were close to losing everything. \n\nLuna Daragon became the last of her family’s dynasty, keeping her power thanks to her ruthlessness. Nowadays, she focus on dealing with slaves in the black market (instead of using the legal and regulated market, as she should), and has a particular taste for exotic creatures. \n\nHer power languished for years, but now she is expanding her business and control once again to the point that she is threatening stability in the city. Fearing that her fights with law enforcement forces and gangs will paint the streets with blood, you’ve been urged to deal with her.\n\nShe is as dominant as she is dangerous and arriving to any consensus with her is going to be tough. You could try to hypnotize her and change her personality, make her trust you and then transform her into your pawn. \n\nYou could also try to earn her trust and get close to her using other methods, but as far as you know she will ask for total submission from you, something that inevitably will lead to you being humiliated, but at least the city will stay under your control. \n\nNOTE: The story has two branches, where she is a dominatrix and the other when you make her submissive. In the dominatrix route you’ll be subject to being fucked and humiliated. You’ll be able to skip the most hardcore content if you wish. ";

			option0Name.text = "Luna dominant";
			option1Name.text = "Luna submissive";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 0;

			break;
		case 1: // an unpleasant meeting sub
			Board.text = "You struggle to make an arrangement to meet Luna, who is paranoid and incredibly cautious. Nonetheless, you finally get an appointment in one of her lairs. \n\nAs you are on your way in you start to understand why Abbadon and Alba are so afraid of her; the slums are her territory, her fortress, and everyone around you looks ready to stab without a moment’s hesitation if the drow commands them to do so.\n\nDuring the briefing given by Helena you realized that your opponent does, in fact, have a weakness, a weakness for beautiful, virgin slaves.\n\nKnowing how invincible she believes she is in her own turf, you’ll exploit her hubris and make her fall.\n\nYour plan is simple: You’ll oil a girl in a special concoction which will arouse the drow to the point that she won’t be able to stop until she climaxes. Not only that, but the potion will also weaken her immune system, giving you an opportunity to drug her with a poison that will certainly be pumped faster through her body the more excited she gets. \n\nOnce she is unable to defend herself, you can hypnotize her. A simple, yet effective plan. \n\nNOTE: If you don't want to see the scene between Luna and the virgin, you can skip it.";
			WorldControl.day += 5; 
			option0Name.text = "Proceed";
			option1Name.text = "Skip";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 1;

			break;
		case 2: //insatiable urges 
			WorldControl.day += 5;
			Board.text = "Your hypnosis is eroding Luna’s will. For how long she’ll be able to hold back?  \n\nAs you expected, it doesn’t take long before you receive a message from Luna telling you that she really needs to see you.\n\nThe shaky handwriting really emphasizes her desperation and you decide to wait another day before you fulfill her request, making sure that she’s at her limit. \n\nYou arrive to the same safe house that you visited before. The carpet is still stained by the cum of the the first session there. It doesn’t takes long before Luna shows up panting heavily. You’re certain that she ran to the safe house the moment she received the news that you had arrived, you can’t stop yourself from flashing her a bright smile as you salute her. \n\n<i>“"+GameControl.playerName+"... W-We... We have business to talk, that’s what you wanted right? So let’s do that.”</i> You nod and appreciate the fact that she is willing to negotiate.\n\n<i>“I’m busy, so hurry, what do you want?”</i> You know that she just wants to finish the conversation and go straight to the finale, but you decide to tease her a little bit. \n\nYou lay out your first demand knowing fullwell that it’s far too excessive for her to even consider accepting, not enough to offend her, but more than enough to be refused out of hand.\n\n<i>“That’s too much and you’re crazy if you think I’d gonna agree to that.”</i> \n\nYou’re about to demand for her to blow you, do you want to skip it?";
			option0Name.text = "Proceed";
			option1Name.text = "Skip";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 2;
			break;
		case 3:// night cravings
			WorldControl.day += 5;
			Board.text= "It is the middle of the night when suddenly you hear someone urgently knocking at your door. When you ask who it is a guard tells you that you are urgently needed at the throne room.\n\nYou quickly arm yourself and open the door. The guard informs you that a servant has been taken hostage by an unknown woman. Although you don’t know exactly who that woman could be, the number of people that could do something like this in the city are very few, and it is no surprise to you when you arrive in a hurry to discover that the mystery woman is Luna Daragon.\n\n<i>“I’ve been requesting a meeting with you these past days, when are you going to answer my call "+GameControl.playerName+"?!”</i> Luna asks, clearly desperate. \n\nIndeed after your first session with her she’s been asking for you in the castle, but you’ve always refused to meet her, just to tease her and make her crave you more. The truth is that you were going to wait one or two more days before actually meeting her, but maybe you underestimated how crazy and desperate this woman can be.\n\nStill, no real harm has been done yet, and to a certain extent you are happy that she is willing to assault your castle just so she can have a taste of your body again.\n\nYou tell her to let the servant go now that she since she now has your attention, and that there is no more need to threaten that you with her. \n\nShe hesitates, but you insist that unless she lets her go right now that you’ll turn around and go back to your bedroom, while your guards deal with her.\n\nDefeated, she let’s the poor scared thing go, who in turn runs away once she recovers from the shock. \n\n<i>“I...”</i> she has changed, she looks like an addict that’s in dire need of her fix. \n\nWant to skip the scene?";
			option0Name.text = "Proceed";
			option1Name.text = "Skip";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 3;
			break;
		case 4: //final submission
			Board.text = "You’ve been fucking Luna’s ass and mouth every day for the last week and a half. Her body is beginning to crave for your touch more and more, just as planned. \n\nEven now she is still feisty and trying to fight back against your internal commands, but slowly and surely she is losing that battle, and she has learned to behave and follow your orders without <i>too much</i> protesting.\n\nAt this point she can’t be satisfied from just having her ass fucked and you can easily see how her pussy is drenched with her juices, inviting you to take her virginity, but at the same time she is trying to hold off as much as possible. \n\nToday you think she is tamed and trained enough to cross that final line and you get everything ready for the joyous event. \n\nUntil now, her routine consisted of her sucking you off in your bedroom before you fucked her ass for hours until you were satisfied, but today you want to have an audience, and you order her to follow you to the throne room. \n\n<i>“W-What is this? T-This is not how we do things, "+GameControl.playerName+"!”</i> You tell her that this is how its going to be done today, and that she has no say about in the matter. You can see that she’s angry, but her expression quickly changes to defeat and submission, and she does as you say. \n\nWhen you arrive at the throne room she can see you have gathered not only the majority of your servants and guards, but also many of her own people, including the slaves, to make her humiliation as complete as possible. \n\n<i>“A-Are you crazy "+GameControl.playerName+"?!”</i> Luna whispers to you <i>“I can’t- I can’t do this in front of these people!”</i> You warn her one last time that if she keeps whining, she’ll be thrown away as it was her wish to come to you in the first place, and that if she says no now then you’ll never have sex with her ever again. \n\n<i>“N-No! I... I get it, I... I’ll do as you wish.”</i>\n\nThere is a nice bed prepared in the center of the room for the show and the two of you walk until you are in front of it. You give a short speech, telling them that Luna Daragon is about to submit to you and the kingdom, and that you’ll reward her for being a good citizen. \n\nThe expressions of the onlookers are mixed; Many of them are eager to see the show, but there are just as many that are disappointed, disgusted, or even angered by what’s going on. One thing is for certain, all the slaves from Luna are happy that she is finally about to get what she deserves. \n\nNOTE: The next scene has public content (that you can disable or enable it from the options menu), you can also skip all the scene altogether. ";
			WorldControl.day += 10;

			option0Name.text = "Proceed";
			option1Name.text = "Skip";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 4;
			break;

		case 100: // an unpleasant meeting dominant
			if (GameControl.charGold < 1000) {
				endTurnFun ();
				Board.text = "You need at least 1000 gold available to gift Luna otherwise she’ll just reject your authority!";
			} else {
				WorldControl.day += 4;

				Board.text = "You struggle to make an arrangement to meet Luna, who is paranoid and incredibly cautious. Nonetheless, you finally get an appointment in one of her lairs. \n\nAs you are on your way in you start to understand why Abbadon and Alba are so afraid of her; the slums are her territory, her fortress, and everyone around you looks ready to attack without a moment’s hesitation if the Drow commands them to do so.\n\nKnowing how greedy she is, you prepare a coffer full of gold and hide it in guarded stash in the city.\n\nThe plan is simply: Talk to her, arrange a deal that benefits both her and the city, and keep going on with your peaceful life. \n\nIt’s easier said than done, knowing you face someone who is known to be both ruthless and incredibly pragmatic when it comes to solving disputes. \n\nWhen you arrive to the small building you can tell that this is just one of the probably dozens safe houses she has. The building is heavily guarded by two big, tall, and muscular guards. They allow you inside with no further escort, and they don’t even bother to take your weapons away, knowing that you’re no match for Luna.\n\nAfter walking through a long hall you arrive to a living room, nicely decorated for a place in the middle of the slums. You’re sure that this is the first time that Luna has actually visited this place herself and, by the lack of dust on the furniture, you are certain that she had everything set up just for the occasion. \n\n The dominant woman is standing in the middle of the room, waiting for you. When you arrive she inspects you from top to bottom, unfazed by your presence. \n\n<i>“So you are the famous "+ GameControl.playerName +"? I expected something more impressive.”</i> She smirks, completely uninterested in how you’ll take her insults. \n\nYou tell her that you’re the ruler of the city but she shakes her head, still smiling. \n\n<i>“You give yourself too much credit. You’re just ruler because those uptight nobles allow it, because you’re docile, and it’s convenient for them to have an easily manipulable figure like yourself instead of someone with no qualms about strong-arming them to get what they want.”</i>\n\nAlthough you would like to retort her remarks, you know better than contradicting someone like her in her own house. \n\nPleased by your silence, she continues <i>“I knew I was right. But that’s good, because that means there is a chance we can make an actual deal here. You see people say that I’m a control freak, and they’re right, so I don’t want people like you disturbing my businesses.”</i>\n\nYou open your mouth, ready to say something, but she doesn’t pauses her speech.\n\n<i>“Now things aren’t that easy, I can’t just take your word that you’ll leave me alone. I want proof, and I’ll tell you right now that I’m not easily convinced. So if you want this discussion to go anywhere then your next words better please me.”</i>\n\nNow that you have her permission, you tell her that you’ve gathered 1000 gold coins as a gift. She raises an eyebrow, actually surprised that you took such initiative by yourself, although she is still wary. \n\n<i>“Is that so? Well, where it is?”</i> You inform her where it is hidden, and the password for retrieving it. She quickly sends someone with instructions to gather the gold. \n\n<i>“If this is a ruse, you’ll pay greatly for wasting my time, but if not...”</i> she walks towards you. \n\nHer presence makes you feel intimidated, even if she isn’t particularly tall nor muscular she has an aura of confidence that surrounds her that is remarkably potent.  \n\n<i>“A thousand coins are a nice gift, but you won’t be able to buy my trust with gifts. You’ll have to earn it with your actions, so how about it, Kneel and show me your true colors, show me that you’re nothing but the lap dog of anyone with power in the city and maybe I’ll give you a chance to keep proving to me that you’re worth something.”</i>\n\nKnowing that resistance at this point is not an option, you do as she says. You can hear her laugh, and before she continues she puts a boot in your face.\n\n<i>“Now lick it clean, dog.”</i>\n\nYou hesitate, slowly open your mouth, but she runs out of her short patience and shoves it into your mouth.\n\n<i>“That’s how you do it! Now we’ll try again and I expect you to show some initiative!”</i> She pulls her foot back and you finally submit, licking her as she wishes.\n\nShortly after you begin a guard comes back, informing Luna that they have indeed found the gold where you told them. \n\nWith a bright smile on her face Luna moves back and sits down.\n\n<i>“Well, I must admit at least your word is worth something, but you’re still far from proving yourself. I think you’ve done enough for today, but you will come back soon so I can keep testing you. Got it?”</i>\n\nYou nod and slowly stand up.\n\n<i>“Very well, go away, I need to make sure you didn’t miss a single coin.”</i>\n\nYou go back to your castle. At least for now it looks like she’s been pleased, and hopefully you’ll be able to met her future demands so she’ll trust you and support your claim to the throne.\n\n";

				GameControl.charGold -= 1000;
				NPCCharList.CharFollower [iLuna].questControl = 101; 
				QuestsController.RemoveID (14001);
				Quest LunaQuest2 = new Quest ();
				QuestsController.createQuest (LunaQuest2, "A little tease.", "You're visiting Luna's safe house on her order, what does she has in mind?", 65, 14002);

				endTurnFun ();
			}

			break;
		case 101: // a  little taste
			WorldControl.day += 5;
			Board.text = "You get a message from Luna to go back and you don’t disappoint her, arriving to the meeting point exactly at the time specified. You meet her at another safe house that isn’t too different from the first one, although this one is located further into her territory. \n\n She is disrespectfully late, making you wait almost an hour and, as you would expect, doesn’t apologize. For that matter she probably arrived late on purpose. \n\n<i>“Why are you still standing? You should welcome me on your knees.”</i> Your first instinct is to apologize and then follow her command.\n\n<i>“Today’s gonna be busy, so let’s go straight to business.”</i>\n\nThe next scene contains oral sex to Luna, you can skip it.";
			option0Name.text = "Yummy!";
			option1Name.text = "Skip";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 100;

			break;
		case 102: // a royal little bitch
			Board.text = "You are commanded to met Luna in her personal house, or at least one of them.\n\nClearly you’ve made progress, and now you’re getting close to her, an opportunity that you shouldn’t and wont waste.\n\nYou walk deep into the slums, taking you almost an hour to finally arrive to your destination.\n\nThe entire block sharply contrasts with the rest of its surroundings: Large, Clean , well maintained, and well guarded buildings, that are similar, if better looking, than where Abbadon or Alba live. \n\nThis comes as no surprise to you since you didn’t expect her to live the same as everyone else around, but it’s surprising how many secrets this city still hides from you. \n\nWhen a guard sees you coming he casually invites you into the district and points to one of the bigger houses on the block, informing you where you’ll find Luna. \n\nThe house is surrounded by beautiful gardens and you can see that all of her staff are well hung, handsome men and beautiful, exquisite women. \n\nThey are all dressed in different outfits: Some as traditional maids, some in rags or naked, and others in latex outfits that cover their entire bodies. If anything, Luna is a woman that encourages diversity among her playthings. \n\nThe next scene contains humiliation, rubber suits and public use for your character, do you wish to proceed?";
			option0Name.text = "Humiliate me!";
			option1Name.text = "Skip";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 101;

			break;
		case 103:
			Board.text = "Today Luna arrived to your castle making her way into your throne room.\n\nShe has a very smug expression on her face. <i>“Hey "+ GameControl.playerName +", I sent a letter to every person that’s worth the attention in the city to come and visit you tonight, we’re going to give them a show, so get ready!”</i>\n\nShe throws you an outfit made only of leather straps. You take it and turn around to go upstairs and change but Luna stops you.\n\n<i>“Where do you think you’re going? Did I twll you to leave?”</i> you bow and apologize before undressing right there, even if quite a few of your servants are still around.\n\nAt least Helena is out doing some errands so you don’t have to face her... For now. \n\nOnce dressed there isn’t much left but to wait. You command to your servants to prepare a feast as soon as they can. \n\n\nThis scene contains humiliation and public use of your followers, do you wish to proceed!";
			option0Name.text = "Proceed!";
			option1Name.text = "Skip";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 102;

			break;
		}
	}


	public void confirmFun(int selector){
		///////////////////////////// luna dominant / luna submissive

		if (selector == 0 && confirmationControl == 0) {
			Board.text = "The best way to control Luna is to please her and become her ally. It’s not going to be an easy task, knowing about her temper and how much of a control freak she is, but it’s something you can handle. ";

			NPCCharList.CharFollower [iLuna].questControl = 100; 
			QuestsController.RemoveID (14000);
			Quest LunaQuest1 = new Quest ();
			QuestsController.createQuest (LunaQuest1, "An unpleasant meeting", "You're ready to visit Luna Daragon for the first time.", 65, 14001);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 0) {
			Board.text = "You’ve decided to put her in her place, a proper punishment she deserves for messing with you and your kingdom. You know the task isn’t going to be easy; she is a control freak that’s going to be tough to break, but you’re certain that you’ll be able to handle her. ";

			NPCCharList.CharFollower [iLuna].questControl = 1; 
			QuestsController.RemoveID (14000);
			Quest LunaQuest1 = new Quest ();
			QuestsController.createQuest (LunaQuest1, "An unpleasant meeting", "You're ready to visit Luna Daragon for the first time.", 65, 14001);
			endTurnFun ();
			return;
		}

		///////////////////////////// Proceed skip

		if (selector == 0 && confirmationControl == 1) {
			Board.text = LunaQuestSubmissive.submissiveQuest(0);

			NPCCharList.CharFollower [iLuna].questControl = 2; 
			QuestsController.RemoveID (14001);
			Quest LunaQuest2 = new Quest ();
			QuestsController.createQuest (LunaQuest2, "Insatiable urges", "Your hypnosis is eroding Luna’s will. For how long she’ll be able to hold back?", 65, 14002);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 1) {
			Board.text = "You managed to hypnotize Luna, You’ve implanted a seed in her head, a desire, an urge, and you’ll let it grow over time, until she willingly submits to you.\n\nYou tell her that from now on the only way she’ll be able to orgasm is if it’s with you, and that every time she cums from that point on it will be harder next time. She nods, her eyes blank. The command isn’t about trusting you, being loyal, or even changing her usual behavior, but now her body can only crave for you and everything else will be unsatisfying. \n\nWith this, you suspect she’ll be all over you soon. \n\nYou return to your castle and wait until what’s going to come next. ";

			NPCCharList.CharFollower [iLuna].questControl = 2; 
			QuestsController.RemoveID (14001);
			Quest LunaQuest2 = new Quest ();
			QuestsController.createQuest (LunaQuest2, "Insatiable urges", "Your hypnosis is eroding Luna’s will. For how long she’ll be able to hold back?", 65, 14002);
			endTurnFun ();
			return;
		}

		///////////////////////////// proceed skip insatiable lust

		if (selector == 0 && confirmationControl == 2) {
			Board.text = LunaQuestSubmissive.submissiveQuest(1);

			NPCCharList.CharFollower [iLuna].questControl = 3; 
			QuestsController.RemoveID (14002);
			Quest LunaQuest3 = new Quest ();
			QuestsController.createQuest (LunaQuest3, "Night cravings", "Your hypnosis is eroding Luna’s will, to the point that she can't cointain herself anymore.", 65, 14003);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 2) {
			Board.text = "After satisfying her lust you leave Luna’s lair, leaving her atop a puddle of your combined fluids. \n\nYou thank her for the service and tell her that if she wants to cum again, then she’ll have to come to you next time.\n\nWith everything settled you turn around and leave her there, day dreaming about what the future. ";

			NPCCharList.CharFollower [iLuna].questControl = 3; 
			QuestsController.RemoveID (14002);
			Quest LunaQuest3 = new Quest ();
			QuestsController.createQuest (LunaQuest3, "Night cravings", "Your hypnosis is eroding Luna’s will, to the point that she can't cointain herself anymore.", 65, 14003);
			endTurnFun ();
			return;
		}

		///////////////////////////// proceed / skip night cravings

		if (selector == 0 && confirmationControl == 3) {
			Board.text = LunaQuestSubmissive.submissiveQuest(2);

			NPCCharList.CharFollower [iLuna].questControl = 4; 
			QuestsController.RemoveID (14003);
			Quest LunaQuest4 = new Quest ();
			QuestsController.createQuest (LunaQuest4, "Final submission", "Luna's will is cracked, and it's time for her to accept her new self.", 65, 14004);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 3) {
			Board.text = "After satisfying her lust you leave Luna’s lair, leaving her atop a puddle of your combined fluids. \n\nYou thank her for the service and tell her that if she wants to cum again, then she’ll have to come to you next time.\n\nWith everything settled you turn around and leave her there, day dreaming about what the future. ";

			NPCCharList.CharFollower [iLuna].questControl = 4; 
			QuestsController.RemoveID (14003);
			Quest LunaQuest4 = new Quest ();
			QuestsController.createQuest (LunaQuest4, "Final submission", "Luna's will is cracked, and it's time for her to accept her new self.", 65, 14004);
			endTurnFun ();
			return;
		}

		///////////////////////////// proceed skip final sub

		if (selector == 0 && confirmationControl == 4) {
			Board.text = LunaQuestSubmissive.submissiveQuest(3);
			NPCCharList.CharFollower [iLuna].questControl = 200; 
			NPCCharList.CharFollower [iLuna].attWillpower = 0;
			NPCCharList.CharFollower [iLuna].isRecruited = true; 
			QuestsController.RemoveID (14004);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 4) {
			Board.text = "There is a big gathering, full of debauchery and excesses. During the night Luna was broken, humiliated, until she finally learned her place.\n\nWhen everything is over you have an obedient slut at your command, ready to fulfill your wishes. Now, with her under your control, you certainly have nothing to worry about the organized crime in Aurorum, at least until a new threat appears. ";
			NPCCharList.CharFollower [iLuna].questControl = 200; 
			NPCCharList.CharFollower [iLuna].attWillpower = 0;
			NPCCharList.CharFollower [iLuna].isRecruited = true; 
			QuestsController.RemoveID (14004);
			endTurnFun ();
			return;
		}

		///////////////////////////// suck skip a little tease 

		if (selector == 0 && confirmationControl == 100) {
			Board.text = "She wastes no time and quickly removes her thong, showing you her naughty cock. She walks towards you until her bouncing cock slaps you in the face.\n\n<i>“You better know what to do now.”</i> You open your mouth, but even before you can start licking it she shoves it until her tip hits your throat. \n\n<i>“Fuck it, I’ll have to do it myself!”</i> She grabs you by the back of your head and starts to use you as a cheap sex toy, disregarding your rank, your well being, or any semblance of decor just so she can get off quicker. \n\nYou struggle; although she doesn’t have the most massive cock you’ve ever seen, it is quite a beast, and you can’t help but to gag when she keeps hitting your throat with it. ";
			iVar = loadChar (3000);
			if (NPCCharList.CharFollower [iVar].attWillpower >= 66) {
				Board.text += "\n\nThe only person in the city who’s been able to dominate you with such energy has been Helena; making you feel like a pathetic bitch, and, to your dismay, you begin to love every moment of it too!";
			} else {
				Board.text += "\n\nThere hasn’t been anyone who’s been able to dominate you as Luna is doing in the whole city,making you feel like a pathetic bitch, and, to your dismay, you begin to love every moment of it!";
			}

			Board.text += "\n\nLuna’s corruptive influence really brings out the most masochistic part of you; She helps you forget the many months of struggle to keep your flimsy power, and with that an strange sense of freedom and happiness that you haven’t experienced before.\n\nEven though she is just using you, for now you can forget about everything and just let yourself go, let your body enjoy the moment, and without even touching yourself you climax at the moment that the first spurt of cum hits your throat.\n\nYou’ve never been so delighted in your life, as every new load of cum makes you mind get blown away in ecstasy. \n\nTime slows down, and what are just mere seconds for you are like minutes, hours. \n\nWhen she is finally done with you she throws you away to the ground. \n\n<i>“Not bad, you pass this round, but you aren’t anywhere near satisfying me.”</i> She says to the mindless mess that’s on the ground.\n\n<i>“See you around, bitch.”</i>\n\nYou couldn’t hear her last words, still lost in your pleasure.\n\nWhen you finally wake up you see that no ones around, and you quickly make way towards your castle, humiliated by the fact that your whole outfit was drenched in her cum. \n";

			NPCCharList.CharFollower [iLuna].questControl = 102; 
			QuestsController.RemoveID (14002);
			Quest LunaQuest3 = new Quest ();
			QuestsController.createQuest (LunaQuest3, "Royal little bitch.", "You're turning into Luna's favorite bitch, what will happen now?", 65, 14003);

			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 100) {
			Board.text = "After fulfilling her wishes of debauchery you go back to your castle. \n\nYou managed to pass her second test, but she said that there is more to come, and considering how she treated you today, you know she really means it. ";

			NPCCharList.CharFollower [iLuna].questControl = 102; 
			QuestsController.RemoveID (14002);
			Quest LunaQuest3 = new Quest ();
			QuestsController.createQuest (LunaQuest3, "Royal little bitch.", "You're turning into Luna's favorite bitch, what will happen now?", 65, 14003);

			endTurnFun ();
			return;
		}

		///////////////////////////// humiliate me! skip

		if (selector == 0 && confirmationControl == 101) {
			Board.text = "You are welcomed into the house by a butler who guides you until you’re finally in Luna’s chamber, a very lavish and exotically decorated room that leaves no doubt in your mind that her fortune challenges that of your retainers.\n\n<i>“Just in time, a minute longer and you’d be in troubles. Get naked and put this on.”</i> She hands you a black rubber mask and a full rubber suit. \n\nYou do as she orders. The rubber mask covers nearly all of your head but leaves your mouth and eyes exposed, the rubber suit clings to your body and makes it so that you can feel every little twitch and movement that would otherwise be too minor to notice.\n\n<i>“Perfect! To be honest I would prefer to cover everything but your holes, but today we’ll going out and I don't want you crashing into everything.”</i>\n\nShe makes a gesture for you to kneel with her hand and once that you are on all fours she puts a leash around your neck.\n\n<i>“Come on! walk dog! We’re going to the city!”</i>\n\nShe pulls on the leash just to show you that she means business and you start to walk towards the main square. \n\nOnce outside the house, you can see that none of the staff reacts to what she is doing, and can tell that they must be used to seeing similar displays. \n\nThe slums aren’t any different either, although this time going back to somewhere you know takes significantly less time since Luna knows every corner of her turf and therefore, every shortcut as well. \n\nWhen the two of you arrive to the square things change: People are looking at the two of you, some of them fascinated, curious, and scared. \n\nSomeone people scream obscenities, insulting you both for such lewd display, but Luna enjoys their gaze, and you start to feel aroused by what’s going on.\n\nShe walks you around as a dog, and even forces you to woof in front of the crowd. \n\nThe fact that no one knows who you are, or at least you assume that they don’t, makes it more thrilling, and lets you follow Luna’s instruction without much pressure. \n\nIt doesn’t takes long for the two of you to be surrounded by a crowd, and it’s at this moment that the real fun begins. \n\n<i>“You people are such a nice crowd! All this love, all of these insults! Yes, we’re fucking perverts, but this bitch on all fours is the bigger one! Want a proof? Get close and use it, you’ll see!”</i>\n\nPeople look at each other, reluctant for a moment, but finally a not so brave young man walks forward, his dick already in the open. \n\nLuna pulls your leash, forcing your head up. \n\n<i>“Don’t disappoint me now, or I’ll take that mask off.”</i> You gulp out of fear, and when the man is in reach you open your mouth, welcoming his warm member.\n\nYou start to eagerly suck him, fearing Luna’s retaliation, and it doesn’t takes long for the inexperienced youth to shoot his load in your mouth and face. \n\nAlthough at first you were scared, now your body is trembling with excitement, and you can’t help yourself but to swallow whatever cum landed in your mouth and lips.\n\nPeople start to cheer and yell obscenities, delighted by your initial slutiness, and eager to try you themselves. \n\nQuickly another man jumps and takes your mouth, while Luna opens a zipper that exposes your ass.\n\n<i>“Come on, use this beautiful ass too! It’s free!”</i> They waste no time and soon you feel someone penetrating your back door while others start to grope your body.\n\nYou are overwhelmed, but you love the pleasure that you’re feeling, and work as many cocks and pussies as you can with your mouth, hands, and asshole.\n\n<i>“Told ya people, this is nothing but a bitch in heat, keep going until all of you are satisfied!”</i>\n\nExcited by the prospect of being fucked for  hours you climax for the first time today, your fluids mixing with your sweat inside your body, smearing your skin. \n\nThe crowd roughly uses you while Luna stands there, watching you get wrecked, and enjoys the show. \n\nWhen you’re done, the black suit is covered in white jizz and fluids, the same fluid can be seen oozing out from all of your holes as well. \n\nYou’ve swallowed so much cum that you think this is the only thing you’ll be able to taste for the next few days. \n\nAlthough you’re exhausted, Luna forces you on all fours again and guides you back to her chamber.\n\nOnce there, you can finally remove the mask and suit. Even though for the most part your body was protected from foreign fluids, you still end up covered in your own juices.\n\n<i>“Such a magnifique experience "+ GameControl.playerName +", you did well today, you may prove useful in the end. To be honest, I already have a plan in mind for your last test...”</i>\n\nEven after hours of being fucked and used, exhausted, your body still gets aroused at the thought of what’s to come.\n\n<i>“Hahaha such an insatiable bitch, very well. Bend over again, you’ll have my cock to please now, so get ready!”</i>\n\nIn no time Luna’s riding your ass, rougher than anyone in the city and although she doesn’t have the biggest cock you’ve fucked today, she is exceptionally skilled in using hers, making you climax two more times before she’s done, painting your back and hair with her thick cum. \n\n<i>“Ahhh... such an eager bitch... You did well, but now I’ll have to rest. I’ll contact you very soon.”</i>\n\nContent, you dress yourself, and the fact that the cum stains your outfit doesn’t embarrasses you, if anything it makes you feel better.\n\nYou quickly go back to your castle in that state, lucky for you most of the city were gathering in a big orgy, so almost no one noticed your questionable fashion choice. ";

			NPCCharList.CharFollower [iLuna].questControl = 103; 
			QuestsController.RemoveID (14003);
			Quest LunaQuest4 = new Quest ();
			QuestsController.createQuest (LunaQuest4, "The cost of trust", "Luna's says you're ready for the final test, what insane thing will she do now?...", 65, 14004);

			endTurnFun ();

			return;
		}

		if (selector == 1 && confirmationControl == 101) {
			Board.text = "After fulfilling her wishes of debauchery you go back to your castle. \n\nYou managed to pass her third test, and now you’re ready for the last and final test. ";

			NPCCharList.CharFollower [iLuna].questControl = 103; 
			QuestsController.RemoveID (14003);
			Quest LunaQuest4 = new Quest ();
			QuestsController.createQuest (LunaQuest4, "The cost of trust", "Luna's says you're ready for the final test, what insane thing will she do now?...", 65, 14004);

			endTurnFun ();

			return;
		}

		///////////////////////////// proceed skip the cost of trust

		if (selector == 0 && confirmationControl == 102) {
			if (GameControl.dick1Size > 0) {
				Board.text = "Luna, bored, starts to play with her dick while she waits.\n\n<i>“You know, I took a powerful aphrodisiac today, so we’ll keep going until dawn.”</i>\n\nYou start to get hard at the idea of being fucked all night long. \n\n<i>“So naughty, come her and start sucking on my cock. You need to be wearing my cum before they arrive!”</i>\n\nYou immediately jump on your knees and start to suck her off. Her throbbing cock, extra sensitive thanks to the drugs, releases on your face and hair very quickly. \n\nThe amount of cum and its thickness is amazing, the strong smell makes you feel lightheaded. \n\n<i>“It’s the first load of many, so have a good taste of it.”</i> You scoop some from your face and lick it. \n\nIts taste is really intoxicating and it’s so thick you almost have to chew it to swallow it.\n\nWhile you finish gulping your first mouthful Luna has taken seat in your throne.\n\nShe flops her dick, which stays rock hard.\n\nYou can hear that people mumbling far away, the meeting about to start.\n\n<i>“They’re on their way, so get on my dick to welcome them.”</i>\n\nYou smile and nod before jumping eagerly again on top of her cock, this time putting it inside your ass.\n\nLuna passively fucks you, not putting any real effort and just waiting for the rest to come, while you can’t help yourself and start to move your hips, getting off by the pleasure and the excitement of what’s to come.\n\nThe first one to enter it’s Helena.";
			} else {
				Board.text = "Luna, bored, starts to play with her dick while she waits.\n\n<i>“You know, I took a powerful aphrodisiac today, so we’ll keep going until dawn.”</i>\n\nYou start to get wet at the idea of being fucked all night long. \n\n<i>“So naughty, come her and start sucking on my cock. You need to be wearing my cum before they arrive!”</i>\n\nYou immediately jump on your knees and start to suck her off. Her throbbing cock, extra sensitive thanks to the drugs, releases on your face and hair very quickly. \n\nThe amount of cum and its thickness is amazing, the strong smell makes you feel lightheaded. \n\n<i>“It’s the first load of many, so have a good taste of it.”</i> You scoop some from your face and lick it. \n\nIts taste is really intoxicating and it’s so thick you almost have to chew it to swallow it.\n\nWhile you finish gulping your first mouthful Luna has taken seat in your throne.\n\nShe flops her dick, which stays rock hard.\n\nYou can hear that people mumbling far away, the meeting about to start.\n\n<i>“They’re on their way, so get on my dick to welcome them.”</i>\n\nYou smile and nod before jumping eagerly again on top of her cock, this time putting it inside your pussy.\n\nLuna passively fucks you, not putting any real effort and just waiting for the rest to come, while you can’t help yourself and start to move your hips, getting off by the pleasure and the excitement of what’s to come.\n\nThe first one to enter it’s Helena.";
			}
			iVar = loadChar (3000);

			if (NPCCharList.CharFollower [iVar].charCorruption < 66) {
				Board.text += "\n\n<i>“Oh my god! W-What is this?!”</i> your  shy maid quickly covers her eyes and turns around.\n\nHurried, the rest of the group joins.";
			} else if (NPCCharList.CharFollower [iVar].attWillpower < 66) {
				Board.text += "\n\n<i>“Oh! M-My liege, I-I apologize to interrupt your fun, b-but Abbadon and the others have arrived!”</i>\n\nHurried, the rest of the group joins.";
			} else {
				Board.text += "\n\n<i>“Hey what the fuck are you two doing!? "+ GameControl.playerName +" is MY bitch!”</i>\n\nHurried, the rest of the group joins.";
			}

			iVar = loadChar (1000);

			if (NPCCharList.CharFollower [iVar].charCorruption < 66) {
				Board.text += "\n\n<i>“"+ GameControl.playerName +"! A-Are you crazy?! I-I’m leaving! We’ll talk when you come back to your senses!”</i>";
			} else {
				Board.text += "\n\n<i>“"+ GameControl.playerName +"?! Luna?! Why are you... Damn you "+ GameControl.playerName +"! This is not what I meant when I asked you to deal with her!”</i>\n\nAlthough Abbadon is mad there is no sign that heshe will leave. If anything, heshe is getting aroused by the scene.\n\n<i>“D-Damn... this is so lewd...”</i>";
			}

			if (GameControl.dick1Size > 0) {
				Board.text += "\n\nAlba has mixed feelings. Although she knows Luna is an enemy she’d never reject a good ol’ orgy and, if anything, you managed to bring Luna where all of you can talk and make a deal, and fuck you. \n\n<i>“You two could at least have waited for us...”</i>\n\nAlba walks forward and starts kissing you while she uses her hand to play with your dick. \n\nOther nobles arrive many of them leave, but some of them stay. \n\nOnce everyone who’s going to stay has arrived, Luna begins to address them. \n\n<i>“So I’ve gather you all here to see how much of a bitch "+ GameControl.playerName +" is, but also to talk about the city.”</i> you let out a pathetic moan when she says the word bitch.\n\nThe room starts to heat up, and although many of them stayed only because they were curious, there are others who can’t help themselves and start to touch themselves, make out with one another, and a few even start fucking in a corner far away. \n\n<i>“So this is the deal, and the only deal I’ll offer: Recognize me as the owner of my district as I define it, giving me total control over it, and I’ll make sure that none of my men and women get out of line, or I’ll take care of them personally if they do.”</i>\n\nThe situation is complicated, “as she defines it” means she’d be taking some blocks that are owned by other landlords, although nothing that affects Alba or Abbadon. \n\nMany of them are reluctant, but Alba promises to compensate them for any losses. Knowing there is no choice and that allowing Luna’s underground empire to keep growing is going to be even worst, they reluctantly agree.\n\n<i>“Great, then lets celebrate! Let’s all fuck "+ GameControl.playerName +" until they fall apart!”</i> Many cheer though you aren’t sure if it is for the deal or with the idea of wrecking you, and after that the meeting turns into a full blown orgy.\n\nLuna starts to fuck you more eagerly now that she doesn’t have to deal with any business, while Alba gets on all fours and starts licking your cock. ";
			} else {
				Board.text += "\n\nAlba has mixed feelings. Although she knows Luna is an enemy she’d never reject a good ol’ orgy and, if anything, you managed to bring Luna where all of you can talk and make a deal, and fuck you. \n\n<i>“You two could at least have waited for us...”</i>\n\nAlba walks forward and starts kissing you while she uses her hand to play with your clit. \n\nOther nobles arrive many of them leave, but some of them stay. \n\nOnce everyone who’s going to stay has arrived, Luna begins to address them. \n\n<i>“So I’ve gather you all here to see how much of a bitch "+ GameControl.playerName +" is, but also to talk about the city.”</i> you let out a pathetic moan when she says the word bitch.\n\nThe room starts to heat up, and although many of them stayed only because they were curious, there are others who can’t help themselves and start to touch themselves, make out with one another, and a few even start fucking in a corner far away. \n\n<i>“So this is the deal, and the only deal I’ll offer: Recognize me as the owner of my district as I define it, giving me total control over it, and I’ll make sure that none of my men and women get out of line, or I’ll take care of them personally if they do.”</i>\n\nThe situation is complicated, “as she defines it” means she’d be taking some blocks that are owned by other landlords, although nothing that affects Alba or Abbadon. \n\nMany of them are reluctant, but Alba promises to compensate them for any losses. Knowing there is no choice and that allowing Luna’s underground empire to keep growing is going to be even worst, they reluctantly agree.\n\n<i>“Great, then lets celebrate! Let’s all fuck "+ GameControl.playerName +" until they fall apart!”</i> Many cheer though you aren’t sure if it is for the deal or with the idea of wrecking you, and after that the meeting turns into a full blown orgy.\n\nLuna starts to fuck you more eagerly now that she doesn’t have to deal with any business, while Alba gets on all fours and starts licking your pussy. ";
			}

			iVar2 = loadChar (3000);
			if (NPCCharList.CharFollower [iVar2].charCorruption >= 66 && NPCCharList.CharFollower [iVar2].attWillpower >= 66 && NPCCharList.CharFollower [iVar].charCorruption >= 66) {
				if (NPCCharList.CharFollower [iVar2].dickSize > 0) {
					Board.text += "\n\nHelena was mad and started to mumble to herself <i>“Tsk... fucking "+ GameControl.playerName +", always getting dominated by anyone with a big dick... Hey you, Abbadon! I’ve heard you have a very tight ass! Come here and let me fuck it!”</i>\n\n<i>“N-No way! Why would I do it with a lowlife like you!”</i>\n\n<i>“Hah! Lowlife! As if you don’t get fucked by your servants already... I can see how you’re trembling, craving for a thick cock up your ass, so stop fooling around and open wide right here!”</i>\n\nHelena was really pushy, mostly because she was mad at what you were doing right now, but your maid was right about Abbadon craving for a rough fucking.\n\nLooking at how you, Alba, Luna, and the entire crowd were enjoying themselves, heshe really didn’t have much of a choice. <i>“Fine, let’s see if you’re worth it or if "+ GameControl.playerName +" just likes to surround themself with mediocre people.”</i>\n\n<i>“Mediocre? I’ll show you...”</i> Abbadon’s insult incited Helena to action ensuring that she would fuck Abbadon will all she has.\n\nThe moment Abbadon removed hisher skirt, Helena immediately assaulted hisher ass with her hard cock.\n\nAlthough you were very busy, it was impossible to not notice Abbadon’s loud moans of pleasure.\n\n<i>“F-Fuck! Y-You’re being too rough! Ahhh! Nghh!”</i>\n\nHelena laughed, enjoying how she was dominating Abbadon’s ass and soul. <i>“I knew you couldn’t take it! "+ GameControl.playerName +" is a wimp! Maybe I’ll make you my bitch instead!”</i>\n\n<i>“D-Don’t get full of yourself! I had better cocks than yours!”</i> Abbadon retorted, which only made Helena double down on her fucking.\n\n<i>“Ahhh! F-Fuck! W-Well! I-I admit this isn’t a bad dick either! B-But I’m no one’s bitch!”</i> Abbadon said while heshe could barely could held himherself together.\n\n<i>“Haha we’ll see!”</i>";
				} else {
					Board.text += "\n\nHelena was mad and started to mumble to herself <i>“Tsk... fucking "+ GameControl.playerName +", always getting dominated by anyone with a big dick... Hey you, Abbadon! I’ve heard you have a very tight ass! Come here and let me play with it!”</i>\n\n<i>“N-No way! Why would I do it with a lowlife like you!”</i>\n\n<i>“Hah! Lowlife! As if you don’t get fucked by your servants already... I can see how you’re trembling, craving to get something up your ass, so stop fooling around and open wide right here!”</i>\n\nHelena was really pushy, mostly because she was mad at what you were doing right now, but your maid was right about Abbadon craving for a rough fucking.\n\nLooking at how you, Alba, Luna, and the entire crowd were enjoying themselves, heshe really didn’t have much of a choice. <i>“Fine, let’s see if you’re worth it or if "+ GameControl.playerName +" just likes to surround themself with mediocre people.”</i>\n\n<i>“Mediocre? I’ll show you...”</i> Abbadon’s insult incited Helena to action ensuring that she would fuck Abbadon will all she has.\n\nThe moment Abbadon removed hisher skirt, Helena immediately assaulted hisher ass with 3 of her fingers.\n\nAlthough you were very busy, it was impossible to not notice Abbadon’s loud moans of pleasure.\n\n<i>“F-Fuck! Y-You’re being too rough! Ahhh! Nghh!”</i>\n\nHelena laughed, enjoying how she was dominating Abbadon’s ass and soul. <i>“I knew you couldn’t take it! "+ GameControl.playerName +" is a wimp! Maybe I’ll make you my bitch instead!”</i>\n\n<i>“D-Don’t get full of yourself! I’ve enjoyed really thick cocks!”</i> Abbadon retorted, which made Helena switch to use her full fist on Abbadon’s ass.\n\n<i>“Ahhh! F-Fuck! W-Well! I-I admit this isn’t bad! B-But I’m no one’s bitch!”</i> Abbadon said while heshe could barely could held himherself together.\n\n<i>“Haha we’ll see!”</i>";
				}
			} else if (NPCCharList.CharFollower [iVar2].charCorruption >= 66 && NPCCharList.CharFollower [iVar2].attWillpower < 66 && NPCCharList.CharFollower [iVar].charCorruption >= 66) {
				Board.text += "\n\nAbbadon’s need some release after looking at you, Luna and Alba having a threesome, when heshe realizes that Helena’s as aroused as himher.\n\n<i>“Helena! Come here right now!”</i> Helena respectfully approaches to the noble.\n\n<i>“As you can see, your master is too busy to attend to me, so you’ll have to take its place.”</i>";
				if (NPCCharList.CharFollower [iVar].dickSize > 0) {
					Board.text += "\n\nYour maid submissively nods. Abbadon smiles while heshe lifts hisher skirt, exposing hisher hard cock.";
				} else {
					Board.text += "\n\nYour maid submissively nods. Abbadon smiles while heshe lifts hisher skirt, exposing hisher wet cunt.";
				}
				Board.text += "\n\n<i>“Now, take it with your mouth and make me cum!”</i>\n\nHelena kneels and starts to eat himher out. Your head maid doesn’t stops just there, but she also starts to masturbate herself while she serves the picky noble. \n\n<i>“Nghh you have such a nice mouth, "+ GameControl.playerName +" has trained you well indeed! Keep going!”</i>\n\nAbbadon doesn’t makes Helena wait too long before heshe releases in her mouth, tainting her face, hair and uniform.\n\n<i>“That’s good, but now I want to try something else...”</i>";
			} else if (NPCCharList.CharFollower [iVar2].charCorruption < 66 && NPCCharList.CharFollower [iVar].charCorruption >= 66) {
				Board.text += "\n\nAbbadon needed some release after looking at you, Luna, and Alba having a threesome, when heshe realized that Helena was aroused as himher.\n\n<i>“Helena! Come here right now!”</i> but to Abbadon dismay, Helena ran away instead of approaching himher.\n\n<i>“Damn! Fucking "+ GameControl.playerName +" needs to learn how to train its servants better!”</i>\n\nAlthough furious for a brief moment, it doesn’t takes long until Abbadon finds someone willing to fill hisher ass with a big, thick cock. ";
			} else if (NPCCharList.CharFollower [iVar2].charCorruption >= 66 && NPCCharList.CharFollower [iVar2].attWillpower >= 66 && NPCCharList.CharFollower [iVar].charCorruption < 66) {
				Board.text += "\n\nHelena’s feeling aroused, and that feeling became explosive when mixed with her anger towards Luna.\n\nSadly, with you, Luna, and Alba busy, Helena’s choices are limited to the rest of boring guests.\n\nAn innocent looking girl makes the mistake of walking too close to Helena <i>“Whatever, I’ll make you my bitch for the night!”</i>\n\nYour maid quickly undresses the girl, who in no time starts to moan as the bitch that Helena said she’d turn. ";
			} else if (NPCCharList.CharFollower [iVar2].charCorruption >= 66 && NPCCharList.CharFollower [iVar2].attWillpower < 66 && NPCCharList.CharFollower [iVar].charCorruption < 66) {
				Board.text += "\n\nHelena’s feeling aroused, but with you, Alba and Luna busy, she has no one to fulfill her needs. \n\nLucky for her, it doesn’t takes long until a small group of men and women start to surround her, complimenting her on her face, breasts, and ass.\n\nHelena shyly nods and thanks them <i>“T-Thank you all for your praise...”</i> one of them can’t wait anymore and grabs her ass.\n\nTo their surprise, Helena doesn’t reacts, and realizing how much of a submissive bitch she is, they start to grope her, until one of them kneels her down and puts his cock in front of her face. \n\n<i>“Come on, suck it bitch!”</i> although Helena closes her eyes and approaches slowly, you can see how eagerly her tongue moves around the erect member once she starts, and from this point things quickly escalate. ";
			} else { // if helena non corrupt, Abbadon non corrupt
				Board.text += "\n\nYou can’t see Abbadon nor Helena in the crowd. They probably left the room, since they aren’t corrupt enough to hang around in an orgy.";
			}



			Board.text += "\n\nMeanwhile, Alba’s switching between licking you and Luna.\n\n<i>“Nghh... Damn Luna! Your cum tastes so good it’s almost addictive!”</i> Alba says after swallowing one of the drow many loads.\n\n<i>“Hah it’s the drugs, they have that side effect!”</i> While the dark elf goes back to drilling your ass, Alba keeps sucking and caressing her balls, awaiting for the next discharge. \n\nMistress Daragon is a woman of her word, and she keeps defiling your holes during the whole night, with the help of your retainers and many others.\n\nThe night ends with a bukkake, where you receive the last load from all of your guests who come forward one by one. To finish the show you rinse your mouth with the mixed cum of them all and gulp it all down at once with a sonorous burp at the end to the delight of Luna and the rest of your guests.\n\n<i>“Thank you all for coming! Now that we’ve proven that "+ GameControl.playerName +" is nothing but a bitch in heat, dealing with the city is going to be easy. Fear not, as I will not cause more chaos than necessary. Just don’t mess with me or my territory or I’ll make sure you personally pay back!”</i>\n\nWith that last threat levied everyone starts to leave. You don’t know what Helena, Abbadon, and the others think about you after tonight, but you accomplished your task, now the city is safe, and with Daragon supporting your claim, now it’s really going to be hard to remove you from your throne. ";


			NPCCharList.CharFollower [iLuna].questControl = 200; 
			QuestsController.RemoveID (14004);
			NPCCharList.CharFollower [iLuna].attWillpower = 100;
			NPCCharList.CharFollower [iLuna].isRecruited = true; 

			endTurnFun ();

			return;
		}

		if (selector == 1 && confirmationControl == 102) {
			Board.text = "After a very lengthy orgy you’re done with Luna... for now. \n\nWith she trusting you you can focus back on ruling your kingdom.";


			NPCCharList.CharFollower [iLuna].questControl = 200; 
			QuestsController.RemoveID (14004);
			NPCCharList.CharFollower [iLuna].attWillpower = 100;
			NPCCharList.CharFollower [iLuna].isRecruited = true; 

			endTurnFun ();


			return;
		}

		///////////////////////////// temp

		if (selector == 0 && confirmationControl == 9999) {
			Board.text = "";

			Board.text += "\n\n";

			return;
		}

		if (selector == 1 && confirmationControl == 9999) {
			Board.text = "";

			Board.text += "\n\n";

			return;
		}
	}


	void Start () {
		loadLuna ();
		questStart ();
		if (GameControl.mcGender == GameControl.MCGender.MALE) {
			lordlady = "Lord";
		} else {
			lordlady = "Lady";
		}
	}

	void loadLuna(){
		iLuna = 0;

		while (iLuna < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iLuna].charID == 14000){
				WorldControl.NPCID = NPCCharList.CharFollower [iLuna].charID;
				WorldControl.PortraitIDLayer0 = NPCCharList.CharFollower [iLuna].charPortraitLayer0;
				WorldControl.PortraitIDLayer1 = NPCCharList.CharFollower [iLuna].charPortraitLayer1;
				WorldControl.PortraitIDLayer2 = NPCCharList.CharFollower [iLuna].charPortraitLayer2;
				break; 
			}
			iLuna++;

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




	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		panConfirmation.sortingOrder = -500;
		endTurnPanel.sortingOrder = 500;


	}

}
