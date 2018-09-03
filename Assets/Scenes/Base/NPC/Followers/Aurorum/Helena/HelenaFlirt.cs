using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HelenaFlirt : MonoBehaviour {
	int hashcode = GameControl.playerName.GetHashCode();
	float randNum; 

	static int iHelena = 0;
	public Text Board; 

	public Canvas PanEndTurn; 

	public Canvas PanRelationship;

	public void flirt(){

		loadHelena ();
		relationshipChange ();
		if (NPCCharList.CharFollower [iHelena].charRelationship < 33) {
			Board.text = flirtLevel1();
		} else if (NPCCharList.CharFollower [iHelena].charRelationship < 50) {
			Board.text = flirtLevel1();
		} else  {
			Board.text = flirtLevel2();
		}
		endTurnFun ();

	}

	string flirtLevel0(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (NPCCharList.CharFollower [iHelena].attWillpower >= 66) {
			if (randNum < 33) {
				toReturn = "";
				return toReturn;
			} else if (randNum < 66) {
				toReturn = "";
				return toReturn;
			} else {
				return "";
			}
		} else {
			if (randNum < 33) {
				toReturn = "";
				return toReturn;
			} else if (randNum < 66) {
				toReturn = "";
				return toReturn;
			} else {
				return "";
			}
		}

	}


	string flirtLevel1(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (NPCCharList.CharFollower [iHelena].attWillpower >= 66) {
			if (randNum < 33) {
				toReturn = "Helena’s been working for hours in your studio doing paperwork and making sure that everything is in order in the kingdom. You’ve been helping her, mostly by signing the documents that she writes or approves. \n\nToday she decides to show you some kindness, and once a lull beginds to form in the endless work she decides to give you a break. <i>“Pour me some wine. And because you’ve been good today, you can serve a cup for yourself too.”</i> you promptly do as she says, profusely thanking her for her generosity. \n\nShe smirks <i>“You’ve really learned you place and learned to properly serve me, I may give you a reward later... Or not.”</i> you bow and thank her for even considering a reward.\n\n<i>“Well, that’s enough resting, get back to work.”</i> you finish what’s left of your drink in a single gulp and go back to work while she settles back and watches you. ";
				return toReturn;
			} else if (randNum < 66) {
				toReturn = "After an exhausting day of work, Helena is enjoying a very well deserved meal. You are standing at her side, alongside the rest of the servants, but your work is to make sure that everything goes smoothly and according to her taste. \n\n<i>“Hmmm... The wine is good, and the food is delicious... but this turkey is too dry! I was thinking about throwing it to the dogs, but being the generous lady that I am, you may take a serving for yourself "+ GameControl.playerName  +".”</i> You thank her the gesture and you order one of the servants to save a serving for you. \n\n<i>“Just make sure that everything is perfect next time, or you will be the one thrown to the dogs the next time.”</i> you nervously gulp and apologize, promising to make sure that you’ll make sure everything is going to be to her liking next time.\n\nShe laughs at you, amused by your fear, but not another word passes her lips for the rest of the meal. \n\nOnce you return to the kitchen and dig into the turkey it practically melts in your mouth; she was lying. With a sigh at being toyed with, you wolf down the rest of the food.\n";
				return toReturn;
			} else {
				return "You are in the throne room accompanying Helena during a business meeting. A group of merchants and nobles of the city had a brief dispute, but Helena swiftly and single-handedly took care of the issue.\n\nAlthough you didn’t do much, it is your hand that has to sign everything off, and your mouth that makes the final approval… which you do as commanded by Helena. The group respect Helena’s authority over yours, mocking you fearlessly. Much to your surprise, Helena defends you and praises your good behavior.\n\n<i>“Stop with this right now, this is my pet and only I have the right to laugh at it.”</i> Well… not so much the kind of defense you were expecting, but the nobles and merchants cease immediately, apologizing profusely. \n\nThe rest of the meeting goes without any other incident, and when everyone is gone Helena comes back to you, ranting about what happened earlier. <i>“Those idiots, how dare they think that they have any right to mock you. Mocking you is mocking me, since you are my property, so if I’m not around make sure to make them understand this fact, got it?”</i> you nod. \n\n<i>“Very well... I’ll take a rest now, but you did a good job today, take a break too.”</i>\n\nYou thank her for her praise but your words only reach her back, as Helena has already turned around and left.";
			}
		} else {
			if (randNum < 33) {
				toReturn = "You’ve been working for hours in your studio, doing paperwork and making sure everything is in order in your kingdom. Helena has been with you from the beginning, eager to assist with each task.\n\nFinally you decide to take a break and your faithful maid pours a cup of wine for you. With a smile you indicate another empty cup, asking her to pour some for herself; she’s earned it for her efforts.\n\n<i>“I’m really thankful my liege, but are you sure?”</i> Helena, as usual, is cautious but you assure her that this is fine. <i>“Very well my liege!”</i> she happily says while joining you.\n\nThe two of you drink in silence for a minute, just relaxing and enjoying your beverages. After a while the peaceful silence passes and the stress starts to melt away. You begin to praise the head maid for her consistent hard work and dutifulness, and how proud of her you are <i>“Thank you my liege...”</i> Although her cheeks turn red with embarrassment, she struggles to hide the smile on her face.\n\nEventually your cups run dry, and the both of you return to work. At the very least her mood appears to have brightened up again, working at full pace once more.";
				return toReturn;
			} else if (randNum < 66) {
				toReturn = "After many hours of dealing with subjects, you are enjoying a very well deserved meal. You are surrounded by servants and the head maid, Helena, works hard to ensure that everything goes smoothly and according to your taste. \n\nToday you decide to give her a break, and invite her to sit at your side and join you. <i>“But my liege that’s not protocol.”</i> she says, knowing that she needs to set an example to the rest of servants there. Smirking, you know full well by the occasional glance that she really wants to have a taste of the food that’s served up while it’s still hot. \n\nYou nod and insist, finally persuading her. <i>“If that’s your wish, I’ll be delighted my liege.”</i> she seats herself at your side and another servant immediately serves her food. Blessedly there’s no sign of resentment to them, and she is treated as a respected guest instead of their boss for the rest of the meal.\n\nYou use this chance to praise her and tell her that you are satisfied with what she has done with the castle and its staff. Although she is embarrassed by your kind words she nods, maintaining some modesty <i>”I’m only doing my duty, my liege, this isn’t something you need to thank me for.”</i>\n\nWhen the two of you are done you order the rest of the servants to take care of everything, giving Helena an extra break. Overjoyed from even this small gesture, you see how she works extra hard during the rest of the day in order to earn your favor once more.";
				return toReturn;
			} else {
				return "You are in your throne room, having a meeting with a group of merchants and nobles of the city. Both sides are making unreasonable demands, but to your great surprise Helena assists you. Time spent studying your uncle’s books appears to have gifted her with a great deal of knowledge about the topics at hand. Although it still requires some argument, both sides are brought to a begrudging agreement.\n\nWith the situation resolved, you decide to praise the head maid in front of everyone, talking about how intelligent and capable she is, and how she has been essential for running the kingdom until now. The others agree and comment how much they envy you for having such a servant at your side.\n\nWhen the meeting is over you ask Helena to stay <i>“Is everything fine my liege? Should I had kept quiet?”</i> you shake your head and tell her that what she did was great, you just wanted to thank her in private and tell her how important she is to you… admittedly that last remark is rather ambiguous.\n\nHelena is embarrassed, and you can barely hear the thank you from her murmuring mouth. You give her a pat on the back and tell her to take a break, since she has earned it. She respectfully bows before leaving the room, happy with the result of todays events. \n";
			}
		}


	}

	string flirtLevel2(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (NPCCharList.CharFollower [iHelena].attWillpower >= 66) {
			if (randNum < 33) {
				WorldControl.dayTime = 5;
				toReturn = "You’ve been looking for Helena for hours, but can’t find her anywhere in the castle. You wonder if she already got bored of you and left the castle, but if that’s the case no one knows anything about it. \n\n\nYou remember that in the past, when Helena used to be a shy and gentle girl, she used to go to the rooftop to look at the stars, but you can’t imagine her still doing that. Still at this point that its the last option left, and you decide to check it out. \n\nTo your surprise she is there, wearing her exposed dominatrix garments. The melancholic expression that she used to have is nowhere to be seen and instead she looks as fierce as ever, and angry.\n\n \n<i>“I was wondering how much time it would take you to figure out that I was up here. As usual you are nothing but a disappointment.”</i>";
				if (NPCCharList.CharFollower [iHelena].dickSizeCM > 0) {
					toReturn += "\n\nShe walks towards you, her throbbing dick already dripping thick precum. <i>“Kneel.”</i> she commands softly, and you immediately do as she says.\n\nWithout any warning she drives her cock into your waiting mouth, ravaging the back of your throat like a toy to be used at her own whim. \n\nWhile her salty fluids fill your mouth, she starts to talk about the past <i>“Remember when I was weak and dumb? That stupid girl that believed that everything would turn back to normal? That’s gone, forever. So don’t look for her anymore, understood?!”</i> she grabs the back of your head and slams her cock even harder into your throat, before abruptly filling your stomach with scalding-hot spunk.\n\nShe pulls out her cock just in time to give you a facial with the last ropes of ivory. She looks at you, smirking at you pathetic state. \n\n<i>“That’s the thank you for showing me my true self. Now go back to work.”</i> knowing that this is all for today, you bow at her and leave the place before you really enrage her. ";
				} else {
					toReturn += "\n\nShe walks towards you, her pussy already dripping with fluids. <i>“Kneel.”</i> she commands softly, and you immediately do as she says.\n\nWithout any warning she just pulls your head towards her entrance, rubbing your face against her body. You stick your tongue out, licking her with care even though she is shaking you. \n\nWhile the taste of her salty fluids fill your mouth, she starts to talk about the past <i>“Remember when I was weak and dumb? That stupid girl that believed that everything would turn back to normal? That’s gone, forever. So don’t look for her anymore, understood?!”</i> she grabs you and pulls you with even more strength, to the point you can barely breathe, until you feel a stream of her femcum in your mouth. \n\nAfter she forces you to drink it all she looks at you, smirking at you pathetic state. \n\n<i>“That’s the thank you for showing me my true self. Now go back to work.”</i> knowing that this is all for today, you bow at her and leave the place before you really enrage her. ";
				}
				return toReturn;
			} else if (randNum < 66) {
				toReturn = "Since Helena changed she is sleeping in your bedroom, although she allows you to sleep on an old mattress laid out on the floor. \n\nIs usual for her to just go to sleep right away, too exhausted from managing the kingdom to take care of you this late, but today she seems a little more energetic, talking with you about the past.\n\n<i>“Heh... You remember when I thought we couldn’t be together because you had to look for a fancy partner? Aren’t you glad we were wrong?”</i> although usually fiery, there is a kind softness to her voice tonight.\n\n<i>“I always thought you had to look for someone with power, when what you really needed was someone to guide you. If only I had known earlier... But what’s done is done. Why you don’t sleep on my bed tonight? Come on, you earned it.”</i> she pats the side of the bed and you join her as fast as you can, before she changes her mind. \n\n<i>“Heh it’s been a very exhausting day, being queen is harder than I thought, but I don’t regret the change. Why you don’t serve me one more time? It would help me sleep better.”</i> ";
				if (NPCCharList.CharFollower [iHelena].dickSizeCM > 0) {
					toReturn += "\n\nShe grabs her flaccid mast and shakes it, inviting you to use your mouth. You smile back at her and go down under the bedsheets, taking her cock in your mouth. You dutifully suck and bob your head until her prick reaches its full strength. It doesn’t take much until she drains whatever remains in her turgid sack’s reserves into your waiting gullet. You barely get a good-night before she drifts off, and you fall asleep at her side.";
				} else {
					toReturn += "\n\nShe spreads open her pussy, inviting you to use your mouth. You smile back at her and go down under the bedsheets, grinding her clit between your lips and tonguing her slit until she rocks her way to orgasm, painting your face with fem-cum. You barely get a good-night before she drifts off, and you fall asleep at her side.\n";
				}
				return toReturn;
			} else {
				toReturn = "It’s been a busy day, and you find yourself and Helena walking from meeting to meeting with no rest. Your servants are just as busy, and you haven’t had the chance to talk with any of them beyond giving them orders on Helena’s own behalf.\n\nYou are on your way to the studio, exhausted, when you see Helena coming your way in the hallway, almost running. You can see a bright smile on her face when she sees you, stopping you right there. \n\n<i>“"+ GameControl.playerName  +" I am going to take a break, you know what that means.”</i> although you want to explain to her how busy you are, you know that that it’s a wasted argument… When she wants something from you, she gets it. Reluctantly you remove your leg wear and turn around, bending over to offer your ass to her.";
				if (NPCCharList.CharFollower [iHelena].dickSizeCM > 0) {
					toReturn += "\n\nShe gets naked in a second, her dick already hard <i>“All this work gets me stressed out, it’s good to have someone like you to relieve myself.”</i> and with that, she saunters over and starts to fuck you. She fucks you not out of love or lust, but just as a way for her to clear her mind and relax her body, using you as nothing else but a walking sex toy. \n\nIt doesn’t take long until you can feel her releasing her hot loads deep inside you. Her moans and laughter are so loud you are certain most of the people on the castle are aware of what’s going on, but is not like they will defy their mistress.\n\nShe pushes up against the wall, redressing once she’s finished stuffing your bowels. <i>“Ahh... Thanks "+ GameControl.playerName  +", is really nice to have you around, I might give you a reward for this later, but for now go back to work, you have too much to do and you are already late.”</i> although <i>she</i> is the reason of why you are late, you just thank her and go back to fulfill your tasks, although as promised she later did gave you a reward so your act was not in vain. ";
				} else {
					toReturn += "\n\nShe gets naked in a second except for a big strap on, which she starts to lube to get it ready. <i>“All this work gets me stressed out, it’s good to have someone like you to relieve myself... By the way do you think I should get a dick? I fuck you so much it might be a good idea...”</i> and with that last remark she just starts to fuck you. She fucks you not out of love or lust, but just as a way for her to clear her mind and relax her body, using you as nothing else but a walking sex toy. \n\nIt doesn’t take long until you can feel her hot fem-cum splashing against your ass. Her moans and laughter are so loud you are certain most of the people on the castle are aware of what’s going on, but is not like they will defy their mistress.\n\nShe pushes up against the wall, redressing once she’s finished sating her needs. <i>“Ahh... Thanks "+ GameControl.playerName  +", is really nice to have you around, I might give you a reward for this later, but for now go back to work, you have too much to do and you are already late.”</i> although <i>she</i> is the reason of why you are late, you just thank her and go back to fulfill your tasks, although as promised she later did gave you a reward so your act was not in vain. ";
				}
				return toReturn;
			}
		} else {
			if (randNum < 33) {
				WorldControl.dayTime = 5;
				toReturn = "You’ve been looking for Helena for hours, but can’t find her anywhere in the castle. At first you believe she may have left you, but if that’s the case no one knows anything about it. \n\nWhen you finally give up you decide to take in a little fresh air on the rooftop. To your surprise, you find Helena there, sitting on the floor and gazing at the stars. You were about to scold her, angry because she has disappeared for so many hours, but you stop when you see her calm and peaceful expression; something that you don’t see too often. \n\nYou walk and stand at her side, and ask her what’s going on. She jumps on the spot, startled by your sudden appearance <i>“Uh?! Oh "+ GameControl.playerName  +"! I apologize!</i> She awkwardly clears her throat, <i>”For how many hours have I been here?”</i> you tell her the truth, about two or three. \n\n<i>“That long? I’m sorry is just when I come to this place, time flies away.”</i> You wave her down and ask if everything is fine <i>“Ah... Yes, you don’t have to worry "+ GameControl.playerName  +". When I had to live in this castle all by myself, and the city was a mess, this was my only refuge, a place where I could feel free and safe.”</i> \n\nKnowing now that she’s in no trouble, you give her a comforting smile and a pat on the head before sitting at her side. Immediately she leans towards you, her head against your chest. <i>“I hope I didn’t worry you too much.”</i> you caress her cheek and tell her not to worry, but to warn you in advance next time she plans to go missing.\n\n<i>“I will.”</i> she turns around and gives you a soft kiss on your lips. <i>“Let’s stay a little longer, please?”</i> instead of an answer, you kiss her back before nodding slowly.\n\nThe two of you enjoy the silence of the night and your company for an hour before going back inside and rest. ";
				return toReturn;
			} else if (randNum < 66) {
				WorldControl.dayTime = 5;
				toReturn = "You are ready to go to sleep, dressed in your nightwear and struggling to keep your eyes open when an abrupt knock at your door snaps you out of your daze.\n\nAnnoyed, you ask who dares to bother you at this time, but when you hear Helena apologizing you hop up from the bed and rush to the door. Thankfully you manage to stop her just before she leaves, attempting to look casual. You ask what happened but she says she just wanted to talk with you. Although tired, you can see that she is nervous and sad. Stifling a yawn, you step aside and wave her into the your room.\n\nThe two of you sit on the bed and you can see tears on her eyes. When you ask again she just hugs. Not a soft hug, but embracing you with all her might, as if you were about to leave and she was trying to hold you back. \n\n<i>“Is... Is just that I hate this "+ GameControl.playerName  +"! The fact that we will never truly be together... That I’ll be always at your side but not with you...”</i> you pat her head and try to calm her down, laughing a little bit and telling her that she has nothing to worry about. After all; you make the rules and if you want, you can be with whoever you want. \n\n<i>“I... I know that "+ GameControl.playerName  +", but we both know it is more complex than that...”</i> she stops crying for the most part, at least to the point that you can clearly understand her through hiccuping gulps. <i>“But I am nothing but a useless servant. You need to be with someone with power if you want to succeed, to grow your position and kingdom...”</i> you hug her back and caress the back of her head. \n\nAlthough she is right, you tell her, you aren’t as frivolous as to only think about your partners or marriage as a mere political move. This is something deeper than that, and she should know it.\n\nYour words finally calm her down, although you know that she is still doubtful, at least she is happy to hear you say these words. <i>“Yes... You are right "+ GameControl.playerName  +", maybe I am still living with ideas of the past, maybe things will change now. Thank you.”</i> she gives you a kiss before getting on her feet again.\n\n<i>“I... I’ll leave now, sorry for interrupting your sleep "+ GameControl.playerName  +", I’ll compensate, I promise.”</i> she gives you a gentle smile before turning around and leaving. You fall asleep shortly after, exhausted.";
				return toReturn;
			} else {
				GameControl.actualArousal += 15;
				return "It’s been a busy day, and you find yourself walking from meeting to meeting with no rest. Helena and the rest of your servants are just as busy, and you haven’t had the chance to talk with any of them beyond giving them orders. \n\nYou are on your way to your studio, feeling utterly drained when you see Helena coming your way in the halls, almost running. She barely stops to give you a polite salute before trying to continue with her journey, but you surprise her once she’s past you with a hug by the waist.\n\nAfter letting out a surprised squeak she happily laughs <i>“Hahaha what’s going on"+ GameControl.playerName  +"?”</i> you can feel her hands tenderly sliding over yours. <i>“Don’t you have a lot of work to do?”</i> she jokes, but you can see that she is as exhausted as you are, and a small break won’t hurt anyone. \n\nYou move your hands up, softly caressing her chest. She leans into you, and you can feel how she grinds her ass against your crotch, enticing you. \n\nYou are in need of her as much as she is in need of you, the two of you have been lusting for one-another for a while now. <i>“Mmmh "+ GameControl.playerName  +"...”</i>\n\nAt the same moment that you feel her hand touching your crotch you can hear the steps of someone coming up. Startled, she immediately jumps away from you. <i>“Ah... Maybe we should do this later "+ GameControl.playerName  +", we still have a lot of work to do.”</i> although you are annoyed, she is right that this is probably not the right place or time, and agree to continue later.\n\n<i>“Don’t worry, I’ll make sure to exhaust you next time.”</i> she jokes before hurrying to her tasks again.";
			}
		}

	}







	void relationshipChange(){
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime +2); 

		NPCCharList.CharFollower[iHelena].charRelationship += Random.Range (1.5f, 3f);
		NPCCharList.CharFollower[iHelena].charLoyalty += Random.Range (0.5f, 1.5f);
		NPCCharList.CharFollower[iHelena].charLove += Random.Range (1.5f, 5f);
		if (NPCCharList.CharFollower [iHelena].charRelationship > 100) {
			NPCCharList.CharFollower[iHelena].charRelationship = 100;
		} 
		if (NPCCharList.CharFollower [iHelena].charLoyalty > 100) {
			NPCCharList.CharFollower[iHelena].charLoyalty = 100;
		} 
		if (NPCCharList.CharFollower [iHelena].charLove > 100) {
			NPCCharList.CharFollower[iHelena].charLove = 100;
		} 


	}


	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		PanRelationship.sortingOrder = -500;
		PanEndTurn.sortingOrder = 500;
	}

	void loadHelena(){

		iHelena = 0;
		while (iHelena < NPCCharList.CharFollower.Count) {
			if (NPCCharList.CharFollower [iHelena].charID == 3000 ) {
				break; 
			}

			iHelena++;
		}

	}


}
