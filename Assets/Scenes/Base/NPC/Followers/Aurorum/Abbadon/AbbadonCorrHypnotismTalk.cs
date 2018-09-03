using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class AbbadonCorrHypnotismTalk : MonoBehaviour {

	int hashcode = GameControl.playerName.GetHashCode();
	float randNum;

	static string pronheshe;
	static string pronhisher;
	static string pronhimher; 

	static int iAbbadon = 0;
	public Text Board; 

	public Canvas PanEndTurn; 

	public Canvas PanCorruption;


	public void hypnotismTalk(){

		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);

		loadAbbadon ();


		//difficulty 
		//float difficulty = NPCCharList.CharFollower[iAbbadon].attWillpower - (NPCCharList.CharFollower[iAbbadon].charCorruption*0.25f) - 50f - (GameControl.attHypnotism*0.8f);  
		float difficulty = 5;

		/*if (GameControl.attHypnotism < 90) {
			randNum += 90; 
		}*/


		if(NPCCharList.CharFollower [iAbbadon].attWillpower == 105){
			Board.text = "You visit Abbadon’s home in order to practice your hypnosis technique. Although "+ pronheshe +" wasn’t expecting you, you are welcomed inside, and directed to their living room. <i>“Well " + GameControl.playerName +", a surprise visit from you? I suppose I shouldn’t be shocked… Do you have anything </i>important<i> to share or you are just itching for my attention?”</i> "+ pronhisher +" joke forces a little snort of amusement out of you, and you insist it’s an ulterior motive. In fact, you have something to show " + pronhimher +".\n\n<i>“Something for me? A gift perhaps?”</i> "+ pronheshe +" straightens up, eying you curiously. With a nod and a smile, you draw out the pendulum of your late uncle. <i>“What’s that? A bracelet?”</i> You tell " + pronhimher +" that you’ll do a trick with it, but that "+ pronheshe +" will need to stay quiet pay close attention to it. \n\nAbbadon snorts softly, shaking "+ pronhisher +" head. After a moment’s pause however, "+ pronheshe +" acquiesces. <i>“Sounds boring, but fine. I’ll do as you say.”</i> It takes a while (even with Abbadon’s patience) but you finally crack their will. For the first time, Abbadon slips into a trance.\n\nYou ask " + pronhimher +" to answer very basic questions at first: "+ pronhisher +" name, what their job is, and what "+ pronhisher +" favorite drink is. Abbadon answers to all of them appropriately, but as time stretches out, the risk of " + pronhimher +" breaking from the trance increases. You give " + pronhimher +" a basic set of instructions: Every time you snap your finger twice and address " + pronhimher +" with a question, "+ pronheshe +" will answer with honesty and once you are done with the conversation "+ pronheshe +" should forget it ever happened. "+ pronheshe +" nods at you plainly, eyes completely empty as "+ pronheshe +" intones a soft agreement.\n\nAfterwards, you leave Abbadon’s home, straighten yourself out, and knock once more on "+ pronhisher +"’s door. After a moment’s pause, Abbadon receives you at the door. "+ pronheshe +" acts as though it’s the first time you’ve met today…\n\nYour first successful attempt at hypnotizing " + pronhimher +".";
			NPCCharList.CharFollower [iAbbadon].attWillpower = 100;
			endTurnFun ();
			return;
		}

		//succeed
		if (randNum > difficulty) {
			corruptionChanges ();
			if (NPCCharList.CharFollower [iAbbadon].charCorruption < 25) {
				Board.text = talkLevel0 ();
			} else if (NPCCharList.CharFollower [iAbbadon].charCorruption < 50) {
				Board.text = talkLevel1 ();
			} else if (NPCCharList.CharFollower [iAbbadon].charCorruption < 75) {
				Board.text = talkLevel2 ();
			} else if (NPCCharList.CharFollower [iAbbadon].charCorruption < 100) {
				Board.text = talkLevel3 ();
			} else {
				Board.text = talkLevel4 ();
			}

		} else { //failure
			if (NPCCharList.CharFollower [iAbbadon].charCorruption <= 60) {
				Board.text = failureLowCorr ();
			} else {
				Board.text = failureHighCorr ();
			}

		}
		endTurnFun ();

	}


	string talkFeelings(){
		
		string P1 = "You are hanging out with Abbadon, and take a moment to snap your fingers twice to get to know better how "+ pronheshe +" actually feels about you. "; 
		string P2; 

		if (NPCCharList.CharFollower [iAbbadon].charRelationship < 0 && NPCCharList.CharFollower [iAbbadon].charLove <= 0) {
			P2 = "\n\n<i>“I really can’t stand you " + GameControl.playerName +". Everything you do is a stark contrast to what I stand for. I really hope that you are one day supplanted by someone more competent.”</i>  ";
		} else if (NPCCharList.CharFollower [iAbbadon].charRelationship < 0 && NPCCharList.CharFollower [iAbbadon].charLove > 0 && NPCCharList.CharFollower [iAbbadon].charLove < 50) {
			P2 = "\n\n<i>“I really want to like you: You are attractive and interesting… Sadly, you do yourself no favors with all of the stupid decisions you’ve made until now. Perhaps if you made up for them we’d be able to get something going.”</i>";
		} else if (NPCCharList.CharFollower [iAbbadon].charRelationship < 0 && NPCCharList.CharFollower [iAbbadon].charLove >= 50) {
			P2 = "\n\n<i>“I truly love you " + GameControl.playerName +". But I’m angry at that. I’m angry at me for wanting you, and I’m angry at you for all of the terrible shit you have done up until this point.”</i> Abbadon pauses and sighs, shaking "+ pronhisher +" head idly. <i>”Honestly, I’m just waiting for you to apologize, and to make up for what you’ve done. Maybe then we could be back together.”</i>\n\n"+ pronheshe +" sounds almost bitter, despite "+ pronhisher +" trance.";
		} else if (NPCCharList.CharFollower [iAbbadon].charRelationship >= 0 && NPCCharList.CharFollower [iAbbadon].charRelationship < 50 && NPCCharList.CharFollower [iAbbadon].charLove <= 0) {
			P2 = "\n\n<i>“You’ve been doing well up until this point… I do feel you still have a ways to go to prove yourself however. Keep up your support of the city, and I would be more than happy to give you my full approval.”</i>";
		} else if (NPCCharList.CharFollower [iAbbadon].charRelationship >= 0 && NPCCharList.CharFollower [iAbbadon].charRelationship < 50 && NPCCharList.CharFollower [iAbbadon].charLove > 0 && NPCCharList.CharFollower [iAbbadon].charLove < 50) {
			P2 = "\n\n<i>“I don’t know you particularly well yet. I… can’t deny that I’m interested in you however. You have been a respectful partner to me, and great company. I look forward to further deepening our relationship.”</i>";
		} else if (NPCCharList.CharFollower [iAbbadon].charRelationship >= 0 && NPCCharList.CharFollower [iAbbadon].charRelationship < 50 && NPCCharList.CharFollower [iAbbadon].charLove > 50) {
			P2 = "\n\n<i>“You are fascinating. There is no other word for it… I don’t think we have had the chance to get to know each other properly though.”\n\n“I am sure we would make a wonderful couple.”</i>";
		} else if (NPCCharList.CharFollower [iAbbadon].charRelationship >= 50 && NPCCharList.CharFollower [iAbbadon].charLove <= 0) {
			P2 = "\n\n<i>“You have been a force of good for the city " + GameControl.playerName +", and I am really glad to serve alongside someone like you.”</i>";
		} else if (NPCCharList.CharFollower [iAbbadon].charRelationship >= 50 && NPCCharList.CharFollower [iAbbadon].charLove > 0 && NPCCharList.CharFollower [iAbbadon].charLove < 50) {
			P2 = "\n\n<i>“You have been a force of good for the city " + GameControl.playerName +", and I like you.”</i> Abbadon sounds almost bashful despite "+ pronhisher +" trance, clearing "+ pronhisher +" throat. <i>”Maybe if things keep going this well there can be something between the two of us.”</i>";
		} else if (NPCCharList.CharFollower [iAbbadon].charRelationship >= 50 && NPCCharList.CharFollower [iAbbadon].charLove >= 50) {
			P2 = "\n\nAbbadon blushes unconsciously, even in throes of "+ pronhisher +" trance. <i>“I am in love with you " + GameControl.playerName +". There is little else I can say about that. Over the time we have spent together, you have proven to be both a great leader, and a great lover. I’m happy to be with you.”</i>\n";
		} else {
			P2 = "\n\nThis is a bug report it!";
		}



		string P3 = "\n\nAfter "+ pronheshe +" is done, you command " + pronhimher +" to forget about the meeting you two had today, but that "+ pronheshe +" should respect you more from now on. ";
		return P1 + P2 + P3;
	}

	string talkLevel0(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum < 20) {
			toReturn = "You visit Abbadon, who quickly allows you into the living room even though you didn’t previously warn " + pronhimher +" about your pending visit. Once there, it doesn’t take long until you two have the privacy necessary for your to continue with your plan and put " + pronhimher +" in a trance. \n\nFor now you decide to keep it simple, and you ask " + pronhimher +" to tell you something personal about "+ pronhisher +" past.\n\n<i>“My past...”</i> "+ pronheshe +" pauses for a moment. As the moment stretches, you begin to fear "+ pronheshe +" has broken from the trance, but finally you are given a proper answer. <i>“I’ve always been daddy’s child, always trying to impress him… I don’t think I ever did.”</i> Even in a trance-like state, you can see "+ pronhisher +" emotions bubbling to the surface, and quickly decide that this will suffice for today.\n\n ";
			return toReturn;
		} else if (randNum < 40) {
			toReturn = "Today you find yourself in Abbadon’s studio, preparing for yet another hypnotism session. The young noble may have planned on a business meeting, but it seems all too easy to use for your ulterior purposes instead. \n\nOnce inside and with some privacy, you snap your fingers twice. Again Abbadon’s consciousness settles into your hands. Today you decide to ask " + pronhimher +" what "+ pronheshe +" finds romantic. \n\n<i>“Romantic uh... I find myself to be a patron of the arts. I enjoy going to the theater, the odd gallery. Although I do so less than I would like, I enjoy riding horses… As well as deep, intelligent conversations.”</i> For a moment that seems to be the only information you’ll get out of him, but he continues after a short breath. <i>”Although open to experiences, I am vehemently opposed to commoner activities. You know; parties, dancing, drinking? So terribly unrefined.”</i>\n\nWhen "+ pronheshe +" is done, you ask a couple more similarly-themed related questions before you go back to your castle. After a longer session like that, "+ pronhisher +" will is likely a little weaker now. \n";
			return toReturn;
		} else if (randNum < 60) {
			toReturn = "After a short business meeting with Abbadon, you decide to put " + pronhimher +" into a trance. You snap your fingers, and watch as he settles back into his role. Next up is finding out what "+ pronhisher +" current goals are.\n\n<i>“Goals... I just want to keep gathering power, enough to kick Alba from this city. I despise her. She is an immoral beast.”</i>\n\nThat statement turns out to be just the tip of the iceberg; Abbadon then starts to rant about Alba, making it very clear to you that "+ pronheshe +" hates the fact that someone can become successful with nothing but her own greed for a business partner. When "+ pronheshe +" finally runs out of steam, you order " + pronhimher +" to forget about the conversation you shared and depart for your castle.";
			return toReturn;
		}  else if (randNum < 80) {
			toReturn = talkFeelings();
			return toReturn;
		} else {
			toReturn = "After having dinner with Abbadon you decide to take a break and snap your fingers twice. As usual it takes just a blink of the eyes to put " + pronhimher +" at the mercy of your questions. Once "+ pronheshe +" has been given a few moments to settle into their trance, you ask " + pronhimher +" to be honest about "+ pronhisher +" dreams and what "+ pronheshe +" wishes for the future.\n\n<i>“Wishes... I just want the city to become its former self. I want the city to prosper with my House at its head, as it had been for centuries.”</i>\n\nEven though "+ pronhisher +" voice doesn’t rise much further than a simple monotone, a hint of nostalgia seeps into it. Before finishing for the evening, you ask about "+ pronhisher +" past. Sadly the conversation doesn’t bring anything interesting to light, and you soon bring the questioning to a halt. Eventually, dinner comes to an end, and you make your leave.\n";
			return toReturn;
		}

	}

	string talkLevel1(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum < 20) {
			toReturn = "You visit Abbadon without previous warning, and although there is some reluctance, "+ pronheshe +" allows you inside. After telling " + pronhimher +" that you just wanted to hang out for a while, "+ pronheshe +" lets out a small sigh. <i>“That’s fine " + GameControl.playerName +", I was doing some paperwork, but I suppose a break wont hurt.”</i> you entertain " + pronhimher +" for a while before you snap your fingers twice and make " + pronhimher +" susceptible to your questions.";
			if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 0) {
				toReturn += "\n\nOnce entranced, you ask " + pronhimher +" to tell you about their past. Abbadon answers, not breaking contact with "+ pronhisher +" empty eyes. <i>“The truth is, when I was young I always wanted to have a penis. Well, I think I always did, because that’s what my father wanted. Thanks to alchemy, that’s entirely possible, but I’m too afraid to change by myself. I would need someone to push me and give me the confidence to do it.”</i>";

			} else {
				toReturn += "\n\nOnce entranced, you ask " + pronhimher +" to tell you about their past. Abbadon answers, not breaking contact with "+ pronhisher +" empty eyes. <i>“The truth is I always wanted to have a penis so that my father could be proud of me. I’m happy that you encouraged me to change my body.”</i>";

			}
			toReturn += "\n\nAfter listening for a little longer, you tell " + pronhimher +" to forget about the meeting the two of you just had, before leaving to your castle. ";
			return toReturn;
		} else if (randNum < 40) {
			return "Abbadon invited you to hang out at "+ pronhisher +" house, and you used this opportunity to put ask " + pronhimher +" some questions under "+ pronhisher +" hypnotic state. \n\nAfter you are certain that "+ pronheshe +" is good and pliable, you ask " + pronhimher +" about "+ pronhisher +" sex life. <i>“I don’t have much of a sex life lately. The closest thing to it is when I masturbate.”</i> You then ask " + pronhimher +" about how "+ pronheshe +" does it and how often. <i>“I didn’t masturbate much in the past, but lately I am enjoying it more, and do it at least once a week… I’ve been using only my ass to masturbate though; there is something unique about it. Somewhat recently I acquired a dildo that’s in my bedroom.”</i>\n\nNow that is some interesting knowledge. You tell " + pronhimher +" that from now on they should try to make even more time to play with their ass. <i>“Very well my Liege.”</i>\n\nOnce you’ve had a chance to master your facial expression you tell Abbadon to forget about the conversation before snapping your fingers. The rest of the meeting seems to go without a hitch.";
		} else if (randNum < 60) {
			return "After a short business meeting with Abbadon, you snap your fingers twice. This time you ask " + pronhimher +" what "+ pronhisher +" current goals are.\n\n<i>“Goals... I just want to keep gathering power. Before I wanted to ruin Alba. I know that this has changed; lately I’ve been more self-aware of my actual power. Having the ability to command people around me, and force them to treat me as their lord. There is something... exciting about it, and now I want <i>more</i> power to see how far I can go with this.”</i>\n\nAbbadon then starts to tell you about "+ pronhisher +" fantasies, although they are not sexual <i>per se</i>, they are about dominating and controlling "+ pronhisher +" underlings, not far away from a perverted fantasy. When "+ pronheshe +" is done, you order " + pronhimher +" to forget about the conversation the two of you just had and leave for your castle. ";
		} else if (randNum < 80) {
			return "After having dinner with Abbadon you decide to take a break. You snap your fingers and begin some fresh questions with " + pronhimher +". After being sure that "+ pronheshe +" is in a trance, you ask what their dreams are, and what "+ pronheshe +" wishes for the future.\n\n<i>“Wishes... I am not sure anymore. I wanted to return to the old times, but many things back then were just wrong or too </i>restrictive<i>. I want order in this city, but also changes. The only thing I want that remains unchanged is the wish that my House is at the head of this new future.”</i>\n\nEven though "+ pronhisher +" voice doesn’t rise much further than a simple monotone, a hint of nostalgia seeps into it. Before finishing for the evening, you ask about "+ pronhisher +" past. Sadly the conversation doesn’t bring anything interesting to light, and you soon bring the questioning to a halt. Eventually, dinner comes to an end, and you make your leave. \n";
		} else {
			return talkFeelings();
		}

	}


	string talkLevel2(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum < 16) {
			return "You visit Abbadon without previous warning, and your influence on " + pronhimher +" is enough that "+ pronheshe +" allows you inside without any reluctance. At being told that you just wanted to hang out with " + pronhimher +", "+ pronheshe +" claps "+ pronhisher +" hands together, smiling faintly. <i>“I would enjoy that, " + GameControl.playerName +". I was just doing some paperwork, but a break wouldn’t hurt.”</i> you entertain " + pronhimher +" for a while before you snap your finger twice and "+ pronheshe +" is ready to answer your questions. \n\nOnce entranced, you ask " + pronhimher +" to tell you about "+ pronhisher +" past. Abbadon answers while looking at you with empty eyes. <i>“No one knows this... but when I was younger I loved to spy on people. Usually when they were in their throes of passion… I masturbated many times looking at people fuck, even my parents.”</i>\n\nAfter listening for a little longer and absorbing several similar anecdotes, you tell " + pronhimher +" to forget about the meeting the two of you just had, before leaving to your castle.\n";
		} else if (randNum < 32) {
			return "As usual, after an invite from Abbadon to spend time at "+ pronhisher +" house, you take the opportunity to settle " + pronhimher +" into a trance.\n\nAfter you are certain that "+ pronheshe +" is properly pliable and ready for questioning, you ask " + pronhimher +" about "+ pronhisher +" sex life. <i>“I don’t have much of a sex life. At least, not lately. Unless you count masturbation, which is as close as it gets these days.”</i> Taking the opportunity to follow this line of questioning, you ask about "+ pronhisher +" masturbation habits. <i>“I love to use my ass. I have a very big dildo in my bedroom that’s perfectly shaped for it. I can usually climax just from that.</i> "+ pronhisher +" voice remains unchanged, even though "+ pronhisher +" breathing grows a little more intense. <i>”If I wasn’t as busy as I am I would do it every day, but I have so many daily tasks that I usually only spend time entertaining myself twice or thrice a week.”</i>\n\nYou tell " + pronhimher +" that from now on "+ pronheshe +" should try to do it more often… Indeed, even if "+ pronheshe +" has a lot of work to do, they could always try it while sat on a dildo. <i>“Very well my Liege, I’ll stuff my ass more often then.”</i>\n\nDespite the abruptness of "+ pronhisher +"’s statement, there doesn’t appear to be anything untoward when you tell him to forget this conversation. After that, the rest of the meeting goes as it usually does. Although it’s hard not to see " + pronhimher +" in a different light.";
		}else if (randNum < 48) {
			return "After a short business meeting with Abbadon, you decide to put " + pronhimher +" into a trance and ask " + pronhimher +" about what are "+ pronhisher +" actual current goals. \n\n<i>“Goals... I am not sure what my goals are anymore. Lately I am not enjoying day-to-day management, there are so many rules and regulations that are in my way that I just end up frustrated. </i>Maybe<i> if my House becomes more powerful I’ll be able to change things, and cut through some of this red tape. It may sound a bit much, but I need to have far more power over those who are in my charge.”</i>\n\nAbbadon then starts to tell you about "+ pronhisher +" fantasies. In some cases it’s possible to spot the sexual undertones, especially when it comes to abusing and dominating "+ pronhisher +" underlings. When "+ pronheshe +" is done, you order " + pronhimher +" to forget about the conversation the two of you just had and leave for your castle. ";
		}else if (randNum < 64) {
			toReturn = "After having dinner with Abbadon you decide to take a break. You snap your fingers and begin some fresh questions with " + pronhimher +". After being sure that "+ pronheshe +" is in a trance, you ask what their dreams are, and what "+ pronheshe +" wishes for the future.";
			if (NPCCharList.CharFollower [iAbbadon].charLove > 0) {
				toReturn += "\n\n<i>“Wishes... I am not sure anymore. I used to care about the city and its past, but now I have other needs. I wish you had more time to be with me… and to stuff my ass. There is something about the way you do it that makes me feel so much more fulfilled.”</i>\n\nYou can hear it in "+ pronhisher +"’s voice, even through the monotonous tones. Particularly in the way they shuffle on the spot. You tell " + pronhimher +" that you’ll take care of "+ pronhisher +" needs more from this point. Of course, only so long as "+ pronheshe +" behaves. Abbadon nods an agreement before you tell " + pronhimher +" to stop and forget about the conversation the two of you just had, before finishing your dinner with " + pronhimher +". ";
			} else {
				toReturn += "\n\n<i>“Wishes... I am not sure anymore. I used to care about the city and its past, but now I have other needs. I wish I had the time to get my ass filled with big cocks, but there is too much to do to handle relationships right now.”</i>\n\nYou can hear it in "+ pronhisher +"’s voice, even through the monotonous tones. There is a hint of sexual frustration in Abbadon’s words. You tell " + pronhimher +" that "+ pronheshe +" doesn’t needs a relationship for that. "+ pronheshe +" has power and influence, and they could use that on anyone… or they could always just flirt with citizens who seem worthy of such a thing. Abbadon nods and you tell " + pronhimher +" to stop and forget about the conversation the two of you just had, before finishing the dinner with " + pronhimher +". ";
			}
			return toReturn;
		}else if (randNum < 80) {
			toReturn = "You visit Abbadon and "+ pronheshe +" immediately lets you inside, even if you didn’t schedule the meeting. You tell " + pronhimher +" that you just wanted to hang out and see how "+ pronheshe +" is doing. <i>“I wasn’t doing anything important, come on and join me.”</i> you entertain yourself for a while before you put " + pronhimher +" into a trance. \n\nOnce "+ pronheshe +"’s good and settled into "+ pronhisher +" trance, you decide to ask a more interesting question. You ask if Abbadon has any secrets. Abbadon answers with empty eyes. <i>“Yes. As a matter of fact, only my father died. My mother fell to the corruption. I’ve been hiding her in my basement. Sometimes the Corruption turns a person insane, and my mother is one of these cases. At this point in time, my mother only seems to live for sex… I should have killed her, but I didn’t have the guts to do so.”</i>";
			if (WorldControl.tagControl [7]) {
				toReturn += "\n\nAbbadon continues for a little while, describing the situation. After listening intently, you tell " + pronhimher +" that "+ pronheshe +" should be lusting more for her. After that, you order Abbadon to forget about your meeting, and you leave for your castle. ";
			} else {
				toReturn += "\n\nAbbadon continues for a little while, describing the situation. After listening intently, you tell " + pronhimher +" that "+ pronheshe +" should just forget about her. After that, you order Abbadon to forget about your meeting, and you leave for your castle.  ";
			}
			return toReturn;
		} else {
			return talkFeelings();
		}

	}

	string talkLevel3(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum < 16) {
			return "You visit Abbadon, who quickly allows you into the living room even though you didn’t previously warn " + pronhimher +" about your pending visit. <i>“That’s fine " + GameControl.playerName +", I was enjoying my free time anyway, so your visit is not an inconvenience.”</i> Once settled in, it doesn’t take long until you two have the privacy necessary for your to continue with your plan and put " + pronhimher +" in a trance. \n\nOnce Abbadon is under, you ask " + pronhimher +" to tell you about "+ pronhisher +" past. Abbadon answers while looking into your eyes with "+ pronhisher +"S bereft of reason. <i>“There is something I’ve never told anyone. The first time I had sex was shortly after the plague started. I was riding outside of the city when I was ambushed by a very large horse man.</i> There’s a moment of pause before Abbadon continues, squirming where "+ pronheshe +" sits. <i>”He rammed his big dick up my asshole for hours before he let me go. I don’t know the true depths of how it may have changed me, but since then the only way for me to truly feel pleasure is with a full ass. ”</i>\n\nAfter listening for a little longer, you tell " + pronhimher +" to forget about the meeting the two of you just had, before returning to your castle. ";
		} else if (randNum < 32) {
			toReturn = "Abbadon invites you to hang out at "+ pronhisher +" house, and you take the opportunity to put " + pronhimher +" into a trance and answer a few more questions. ";
			if (NPCCharList.CharFollower [iAbbadon].charLove <= 0) {
				toReturn += "\n\nAfter you are certain that "+ pronheshe +" is doing as they should, you ask " + pronhimher +" about "+ pronhisher +" sex life. There’s only the briefest moment’s pause before Abbadon begins. <i>“Lately I’ve been sneaking around with different servants and forcing them to take me hard from behind. I’ve made sure they keep it a secret with threats. They fear, quite rightly, the harsh punishment I would hand out for disobeying me. However even when I don’t have any of my men at hand, I keep at least one or two large dildos to use whenever the need takes me… even if I’m not at home, I will sneak off into somewhere private like a bathroom to satiate my lust.”</i>\n\nGrinning toothily, you tell " + pronhimher +" that from now one "+ pronheshe +" should try to be less shy about doing things in front of others. <i>“Very well my Liege, I’ll do that.”</i>\n\nWhen "+ pronheshe +" is done, you order " + pronhimher +" to forget about the conversation the two of you just had and leave for your castle. ";
			} else {
				toReturn += "\n\nAfter you are certain that "+ pronheshe +" is doing as they should, you ask " + pronhimher +" about "+ pronhisher +" sex life. <i>“I’m always thinking about getting my ass fucked. I wished you could be doing that all the time, but when you can’t I always carry a big dildo to use whenever I feel like, even if I’m not at home I sneak into a bathroom or somewhere with privacy to satiate my lust.”</i>\n\nYou tell " + pronhimher +" that from now one "+ pronheshe +" should try to be less shy about doing things in front of others. <i>“Very well my Liege, I’ll do that.”</i>\n\nAfter that you tell " + pronhimher +" that "+ pronheshe +" will forget about the conversation the two of you had, and finish the rest of the meeting goes as usual.";
			}
			return toReturn;
		} else if (randNum < 48) {
			return "After a short business meeting with Abbadon, you decide to put " + pronhimher +" into a trance and ask " + pronhimher +" about what are "+ pronhisher +" actual current goals. \n\n<i>“Caring about the city, my House, those are things from the past.”</i> Well… that wasn’t exactly what you expected. Quite the quick turnaround. <i>”What I want now is just more power and money so I can make whatever I want with anyone. If the city need to change to accommodate me, it should, and I am looking forward doing so.”</i>\n\nAbbadon then starts to tell you about "+ pronhisher +" fantasies with excruciating detail, and the noticeable pattern is that many of them end up with Abbadon being fucked in the ass. Although most of the time in control, although at this point "+ pronheshe +" doesn’t even care that much about that as "+ pronheshe +" used to. When "+ pronheshe +" is done, you order " + pronhimher +" to forget about the conversation the two of you just had and leave for your castle. ";
		} else if (randNum < 64) {
			toReturn = "After having dinner with " + pronhimher +" you decide to take a moment to perform some hypnotism. Once under your control, you ask " + pronhimher +" to be honest about "+ pronhisher +" dreams, and what "+ pronheshe +" wishes for the future.";
			if (NPCCharList.CharFollower [iAbbadon].charLove > 0) {
				toReturn += "\n\n<i>“I only wish for one thing: To get you to fuck my ass as much as you can. I am still too shy to do it anywhere, and I hate that. I wish I was brave enough to ask you to fuck me everywhere at any time.”</i>\n\nYou can see that even if "+ pronhisher +" voice is monotone for the most part, there is a hint of excitement in it. You tell " + pronhimher +" that you’ll take care of it more from this point, so long "+ pronheshe +" behaves. Abbadon nods and you tell " + pronhimher +" to stop and forget about the conversation the two of you just had, before finishing the dinner with " + pronhimher +". ";
			} else {
				toReturn += "\n\n<i>“I only wish for one thing: To get my ass fucked all the time. But I’m still too shy to do it everywhere and at any time. Being more brave... I wish for that.”</i>\n\nYou can see that even if "+ pronhisher +" voice is monotone for the most part, there is a hint of sexual frustration in it. You tell " + pronhimher +" that "+ pronheshe +" doesn’t needs a relationship for that, and that "+ pronheshe +" can use anyone under "+ pronhisher +" command or flirt with citizens "+ pronheshe +" deems worth it of fucking "+ pronhisher +" ass.  Abbadon nods and you tell " + pronhimher +" to stop and forget about the conversation the two of you just had, before finishing the dinner with " + pronhimher +". ";
			}
			return toReturn;
		}  else if (randNum < 80) {
			toReturn = "You visit Abbadon and "+ pronheshe +" immediately lets you inside, even if you didn’t schedule the meeting. You tell " + pronhimher +" that you just wanted to hang out and see how "+ pronheshe +" is doing. <i>“I wasn’t doing anything important, come on and join me.”</i> you entertain yourself for a while before you put " + pronhimher +" into a trance. ";
			if (WorldControl.tagControl[7]) {
				toReturn += "\n\nOnce Abbadon is settled into "+ pronhisher +" trance, you ask what "+ pronheshe +" feels about "+ pronhisher +" mother. Abbadon answers while looking at you with "+ pronhisher +" empty eyes. <i>“Lately I’ve been lusting over my mother. I am still afraid of having my way with her, but I </i>have<i> let her suck me off several times now. She really looks happy when I feed her with my fluids.”</i>\n\nAfter listening for a little longer, you tell " + pronhimher +" to take more risks with her, and forget about the meeting the two of you just had, before leaving for your castle.";
			} else {
				toReturn += "\n\nOnce Abbadon is settled into "+ pronhisher +" trance, you ask what "+ pronheshe +" feels about "+ pronhisher +" mother.. Abbadon answers while looking at you with "+ pronhisher +" empty eyes. <i>“I am not lusting for her anymore, I don’t know why but our connection feels more distant with every day.”</i>\n\nAfter listening for a little longer, you tell " + pronhimher +" to continue "+ pronhisher +" seperation with "+ pronhisher +" family. Then with another order to forget your meeting, you depart for your castle.";
			}
			return toReturn;
		}  else {
			return talkFeelings();
		}

	}

	string talkLevel4(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum < 16) {
			return "You visit Abbadon, who quickly allows you into the living room even though you didn’t previously warn " + pronhimher +" about your pending visit. <i>“Please, come in " + GameControl.playerName +". I was just having some fun with my ass… Your visit is far from inconvenient. Maybe you could… help me a bit?”</i> The two of you spend some time fooling around before you hypnotize " + pronhimher +" once more.\n\nAfter "+ pronheshe +" is under your control again, you order " + pronhimher +" to tell you about "+ pronhisher +" past. Abbadon answers while looking at you with "+ pronhisher +" empty eyes. <i>“The truth is, I’ve always lusted over my parents since I witnessed them fucking in their room. The beautiful body of my mother, the generous cock of my father.”</i> Abbadon pauses to take a breath. <i>”It’s a shame I’ll never be able to ride that magnificent cock.”</i>\n\nAfter listening for a little longer, you tell " + pronhimher +" to forget about the meeting the two of you just had, before leaving for your castle.";
		} else if (randNum < 32) {
			toReturn = "This time you receive an invitation from Abbadon to spend some time at "+ pronhisher +" house, and you used this opportunity to put " + pronhimher +" into a trance again.";
			if (NPCCharList.CharFollower [iAbbadon].charLove <= 0) {
				toReturn += "\n\nAfter you are certain that "+ pronheshe +" is properly under, you ask " + pronhimher +" about "+ pronhisher +" sex life. <i>“It’s wonderful, whenever I feel the urge there is always a servant available to fuck me in the ass. Such a thing would usually be inconceivable, but now I scream so loudly that usually the whole staff just joins to make a big orgy… Eventually I’m practically drowning in cum and my ass is totally full of seed. If I’m not at home I always bring along my favorite toy if I need a masturbation break. It doesn’t matter if it’s in front of everyone, I just go right ahead.”</i>\n\nYou tell " + pronhimher +" that "+ pronheshe +" is doing a good job, and should keep up the good work. <i>“I will, my liege.”</i>\n\nThe room seems to be filled with the scent of arousal, even as you order " + pronhimher +" to forget about this conversation. After wards, the day passes in peace.";
			} else {
				toReturn += "\n\nAfter you are certain that "+ pronheshe +" is properly under, you ask " + pronhimher +" about "+ pronhisher +" sex life. <i>“I’m always thinking about people laying into my rear. If I feel the need I just plug myself up with a dildo, even if it’s in front of everyone.”</i>\n\nYou tell " + pronhimher +" that "+ pronheshe +" is doing a good job, and should keep up the good work. <i>“I will, my liege.”</i>\n\nThe room seems to be filled with the scent of arousal, even as you order " + pronhimher +" to forget about this conversation. After wards, the day passes in peace.";
			}
			return toReturn;
		} else if (randNum < 48) {
			return "After a short business meeting with Abbadon, you decide to put " + pronhimher +" into a trance and ask " + pronhimher +" about what are "+ pronhisher +" actual current goals.  \n\n<i>“I have a new goal in life. I am proud of this goal. I want this whole city to change. I wanted corrupted, and I want it to be mine. I want common and royal alike to suck me off or face banishment.”</i>\n\nAAbbadon then starts to tell you about "+ pronhisher +" fantasies with excruciating detail, and the noticeable pattern is that many of them end up with Abbadon being fucked in the ass. Although most of the time in control, although at this point "+ pronheshe +" doesn’t even care that much about that as "+ pronheshe +" used to. When "+ pronheshe +" is done, you order " + pronhimher +" to forget about the conversation the two of you just had and leave for your castle. ";
		} else if (randNum < 64) {
			toReturn = "After having dinner with " + pronhimher +" you decide to take a moment to perform some hypnotism. Once under your control, you ask " + pronhimher +" to be honest about "+ pronhisher +" dreams, and what "+ pronheshe +" wishes for the future.";
			if (NPCCharList.CharFollower [iAbbadon].charLove > 0) {
				toReturn += "\n\n<i>“I only wish for one thing: To get you to fuck my ass as much as you can. I don’t care where or when, I just want you to be with me, pleasuring me. I wish you could be fucking me right now.”</i>\n\nYou can tell that even if "+ pronhisher +" voice is monotone for the most part, there is a hint of excitement in it. You tell " + pronhimher +" that you’ll take care of it more from this point, so long "+ pronheshe +" behaves. Abbadon nods and you tell " + pronhimher +" to stop and forget about the conversation the two of you just had, before finishing the dinner with " + pronhimher +". ";
			} else {
				toReturn += "\n\n<i>“I don’t have a wish anymore. It used to be for a life of anal sex, all the time. That wish has become a reality now; there is always someone to take care of my needs, even in the middle of a meeting. Even as we speak, I am leaking cum from a fuck I enjoyed before you arrived.”</i> You lean down and catch a glance of thick ivory trickling between "+ pronhisher +" thighs.\n\nYou can hear that even if "+ pronhisher +" voice is monotone for the most part, excitement bleeds through. With a soft pat on the head, you tell " + pronhimher +" that "+ pronheshe +" is doing a fine job, and should keep up the good work. Abbadon nods and you tell " + pronhimher +" to stop and forget about the conversation the two of you just had, before dessert is brought in.";
			}
			return toReturn;
		}  else if (randNum < 80) {
			toReturn = "You visit Abbadon and "+ pronheshe +" immediately lets you inside, even if you didn’t schedule the meeting. You tell " + pronhimher +" that you just wanted to hang out and see how "+ pronheshe +" is doing. <i>“I wasn’t doing anything </i>too<i> important, come on and join me.”</i> you entertain yourself for a while before you put " + pronhimher +" into a trance.  ";
			if (WorldControl.tagControl[7]) {
				toReturn += "\n\nOnce Abbadon is under, you ask if "+ pronheshe +" about "+ pronhisher +" mother. Abbadon answers while looking at you with "+ pronhisher +" empty eyes. <i>“It’s wonderful. She is as insatiable as I am. As of late, I’ve spent hours in the basement with her. If only my father were here, we could all be together as one big happy family.”</i>\n\nThere is some small measure of fondness mixed into "+ pronhisher +"’s monotonous voice. After listing for a little while longer, you tell " + pronhimher +" to keep up their familial enjoyment, before leaving for your castle. \n";
			} else {
				toReturn += "\n\nOnce Abbadon is settled into "+ pronhisher +" trance, you ask what "+ pronheshe +" feels about "+ pronhisher +" mother.. Abbadon answers while looking at you with "+ pronhisher +" empty eyes. <i>“I am not lusting for her anymore, I don’t know why but our connection feels more distant with every day.”</i>\n\nAfter listening for a little longer, you tell " + pronhimher +" to continue "+ pronhisher +" seperation with "+ pronhisher +" family. Then with another order to forget your meeting, you depart for your castle. ";
			}
			return toReturn;
		}else {
			return talkFeelings();
		}

	}


	string failureHighCorr(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);

		if (randNum < 33) {
			return "You visited Abbadon today, but "+ pronhisher +" reception was anything but warm. <i>“What do you want "+ GameControl.playerName +"? I’m too busy today to deal with you. Next time warm me about your visits!”</i> "+ pronheshe +" then slammed the door in your face.\n\nAnnoyed, you have no other option but to return to your castle and visit Abbadon later. ";
		} else if (randNum < 66) {
			return "Today you attempted to corrupt Abbadon again with your special concoction, but this is not your lucky day. When you arrive to "+ pronhisher +" home, a maid informs you that "+ pronheshe +" had to leave early to deal with some business. You ask to the young lady if you can wait for " + pronhimher +" inside, but she refuses, saying that Abbadon may not even come today.\n\nDisappointed, you go back to your castle. ";
		} else {

			return "Today you attempted to corrupt Abbadon again with your special concoction, but this is not your lucky day. When you arrive to "+ pronhisher +" home, a maid informs you that "+ pronheshe +" had to leave early to deal with some business. You ask to the young lady if you can wait for " + pronhimher +" inside, but she refuses, saying that Abbadon may not even come today.\n\nDisappointed, you go back to your castle. ";
		}

		if (randNum < 33) {
			toReturn = "";
			if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 0) {
				toReturn += "\n\n";
			} else {
				toReturn += "\n\n";
			}
			toReturn += "\n\n";
			return toReturn;
		} else if (randNum < 66) {
			toReturn = "";
			if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 0) {
				toReturn += "\n\n";
			} else {
				toReturn += "\n\n";
			}
			toReturn += "\n\n";
			return toReturn;
		} else {
			toReturn = "";
			if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 0) {
				toReturn += "\n\n";
			} else {
				toReturn += "\n\n";
			}
			toReturn += "\n\n";
			return toReturn;
		}
	}

	string failureLowCorr(){
		string toReturn = "";
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum < 33) {
			return "You visited Abbadon today, but "+ pronhisher +" reception was anything but warm. <i>“What do you want "+ GameControl.playerName +"? I’m too busy today to deal with you. Next time warm me about your visits!”</i> "+ pronheshe +" then slammed the door in your face.\n\nAnnoyed, you have no other option but to return to your castle and visit Abbadon later. ";
		} else if (randNum < 66) {
			return "Today you attempted to corrupt Abbadon again with your special concoction, but this is not your lucky day. When you arrive to "+ pronhisher +" home, a maid informs you that "+ pronheshe +" had to leave early to deal with some business. You ask to the young lady if you can wait for " + pronhimher +" inside, but she refuses, saying that Abbadon may not even come today.\n\nDisappointed, you go back to your castle. ";
		} else {
			return "Today you attempted to corrupt Abbadon again with your special concoction, but this is not your lucky day. When you arrive to "+ pronhisher +" home, a maid informs you that "+ pronheshe +" had to leave early to deal with some business. You ask to the young lady if you can wait for " + pronhimher +" inside, but she refuses, saying that Abbadon may not even come today.\n\nDisappointed, you go back to your castle. ";
		}
	}



	void corruptionChanges(){
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime +2); 

		NPCCharList.CharFollower[iAbbadon].charCorruption += Random.Range (0f, 1.5f);
		NPCCharList.CharFollower[iAbbadon].charRelationship += Random.Range (0.5f, 1.5f);
		NPCCharList.CharFollower[iAbbadon].charLoyalty += Random.Range (0.5f, 1.5f);

		if (NPCCharList.CharFollower [iAbbadon].charCorruption < 80) {
			GameControl.charCorruption += Random.Range (0f, 1.5f);

		} else {
			GameControl.charCorruption += Random.Range (0.5f, 2f);

		}

		if (GameControl.attHypnotism < 20) {
			GameControl.attHypnotism += Random.Range (2f, 6f);
		} else if (GameControl.attHypnotism < 50) {
			GameControl.attHypnotism += Random.Range (0.5f, 1.5f);
		}

	}




	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		PanCorruption.sortingOrder = -500;
		PanEndTurn.sortingOrder = 500;
	}

	void loadAbbadon(){

		iAbbadon = 0;
		while (iAbbadon < NPCCharList.CharFollower.Count) {
			if (NPCCharList.CharFollower [iAbbadon].charID == 1000 ) {
				if (NPCCharList.CharFollower [iAbbadon].charGender == NPCData.CharGender.MALE) {
					pronheshe = "he";
					pronhisher = "his";
					pronhimher = "him";

				} else {
					pronheshe = "she";
					pronhisher = "her";
					pronhimher = "her";
				}
				break; 
			}

			iAbbadon++;
		}

	}
}
