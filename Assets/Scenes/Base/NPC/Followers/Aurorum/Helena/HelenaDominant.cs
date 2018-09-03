using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HelenaDominant : MonoBehaviour {
	int hashcode = GameControl.playerName.GetHashCode();
	float randNum;

	static int iHelena = 0;
	public Text Board; 

	public Canvas PanEndTurn; 

	public Canvas PanCorruption;

	public void helenaDominant(){

		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);

		loadHelena ();

		if (NPCCharList.CharFollower [iHelena].charCorruption < 66) {
			Board.text = "This action would make Helena a dominatrix, but it needs 66 of corruption or more before you can start with this process.";
			return; 
		}

		if (NPCCharList.CharFollower [iHelena].attWillpower >= 60 && NPCCharList.CharFollower [iHelena].attWillpower < 66) {
			NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3220;
			HelenaTransformation.helenaUpdatePortrait ();

		}

		NPCCharList.CharFollower [iHelena].attWillpower += 6;

		if (NPCCharList.CharFollower [iHelena].attWillpower > 100) {
			NPCCharList.CharFollower [iHelena].attWillpower = 100;
		}


		if (NPCCharList.CharFollower [iHelena].attWillpower < 33) {
			Board.text = dominantLevel0 ();
		} else if (NPCCharList.CharFollower [iHelena].attWillpower < 66) {
			Board.text = dominantLevel1 ();
		} else {
			Board.text = dominantLevel2 ();
		}

		endTurnFun ();

	}

	string dominantLevel0(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum < 33) {
			toReturn = "You call Helena into your chambers and ask her to sit and pay attention to you.\n\nShe is confused, and although she does as you say, she speaks up <i>“My liege... can I ask what is this about?”</i> you tell her that she doesn’t have to worry should be patient. After all… it’s a surprise. ";
			if (NPCCharList.CharFollower [iHelena].charRelationship > 50) {
				toReturn += "\n\nShe nods and smiles at you <i>“Fine my liege, I trust you!”</i>";
			} else {
				toReturn += "\n\nShe reluctantly nods, apprently still concerned.. <i>“As you say… my liege.”</i>";
			}
			toReturn += "\n\nYou stand in front of her and bring out your pendulum, raising it until its in front of her face. <i>“Ohhh... This is pretty my liege, it is for me?”</i> you tell her that she just needs to be quiet for a moment and pay attention to it, and she obediently does so. \n\nIt doesn’t takes long for her to settle under your control; her weak will makes such a matter child’s play.\n\nOnce she is in this suggestive state, you tell her that from now on she has to be harsher to the servants and slaves in the castle, but to forget about this meeting.\n\nWhen you snap your fingers she wakes up. <i>“Uhh... What I am doing here, my liege?”</i> You lie, of course. You tell her that she had been just in the middle of explaining how unruly some of the servants have been.\n\n<i>“Ah yes, that’s right! I need to go back and take care of that!”</i>\n\nYou follow her from a safe distance, watching to see how she acts with them <i>“No! You shouldn’t do that! Next time you will... you will be in charge of mopping the dungeon!”</i> Helena’s strong relationship with the rest of the servitude is really troublesome, and it clearly reduces the effects of your influence on her. She’s threatening to punish them at least, which is far more than she would do before. You can consider progress being made.";
			return toReturn;
		} else if (randNum < 66) {
			WorldControl.day += 2;
			toReturn = "There is a shop owner in the city that owes you some money. The amount is honestly rather small, and usually the kind of value you would overlook; the effort is more costly than the gains. On this occasion however, you think this would be the perfect scenario to keep tinkering with Helena’s mind. \n\nYou summon Helena into your chamber and ask her to sit and pay careful attention to your pendulum. <i>“My liege, what’s this for?”</i> Helena asks, curious about the situation. You just tell her to relax and focus, there is nothing to fear. \n\nShe is reluctant but does as you say and in no time her weak mind is under your control.\n\nYou command her to go to the city and deal with this shop owner and make an example out of her, and to claim the money that’s rightfully yours. \n\nAfter you clap your fingers she stands up and walks towards the city. You follow her closely, but thanks to the trance she doesn’t pays any attention to you. \n\nShe soon arrives at her destination; a fruit stand. The owner is a woman in her 30’s, waiting for business. Helena’s first action is to take one of her fruits, bite it and then throw it away. \n\n<i>“Disgusting, no wonder why you aren’t selling anything. But that doesn’t exempt you from paying your taxes.”</i> the woman begs her, saying that she has no money left, but Helena is relentless. \n\n<i>“Well, if you don’t have gold, I have an idea.”</i> Helena kicks one of the fruit baskets and throws away one of the boxes to the ground, spitting and crushing them with her feet to make sure to ruin them. \n\n<i>“I would have taken some of your goods back to the castle in recompense, but they are so awful... This will do, and next time make sure to have the money at hand or I wouldn’t be this generous.”</i>\n\nWhen Helena is done, she turns around and goes back to the castle. When you ask her debrief you later, she seems to struggle to piece her memory together; the story is a lot milder at least. Nonetheless, you can see that her personality is starting to change, even when the effects of the hypnosis are gone.\n";
			return toReturn;
		} else {
			WorldControl.dayTime = 5; 
			toReturn = "You’ve been putting Helena’s patience to test, having her deal with a nobleman that’s been painfully rude lately.\n\nSadly, Helena’s submissive personality means that she always gives in whenever he makes a demand. Today, however, you hope to change things up a little.\n\nOnce the noble is waiting at the throne room for you, you summon Helena into your chamber and ask her to sit down so you can give her the appropriate instructions to deal with him. As usually happens when you intend to hypnotize Helena it only takes you a couple of minutes to break her weak willpower.\n\nNow under your control, you order her to go to the throne room and deal with this nobleman, and make sure that he doesn’t step all over her this time.\n\nWith a snap of your fingers she stands up and walks towards the room. You follow her a short way before ducking behind a door to watch the scene from secrecy.\n\nOnce she enters the man starts yelling at her, demanding explanations for her lateness. Helena keeps her cool under the constant barrage of berating language, waiting until the noble is out of breath.\n\nAfterward, she proceeds to calmly explain the situation. She informs him that he is causing an outright scandal, and making himself appear like an idiot and a fool. She ridicules and condescends him for a great many minutes before she seems done. Once finished she smiles sweetly and asks politely for the noble to leave before she has to call the guards and invite him for a long stay in the dungeon.\n\nYou can see how his face turns red with fury at the treatment, but once he realizes the genuine nature of her threats he leaves with haste.\n\nProud of Helena’s expert delivery, you reward her with a day off and a cup of fine wine. Hopefully you’ll see an even greater shift in her attitude soon.";
			return toReturn;
		}

	}

	string dominantLevel1(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum < 33) {
			toReturn = "Continuing with your training of Helena she is brought under your control with very little effort.\n\nToday you will push her to deal with your servants again. In the past, this has been one of the most difficult tasks: Her friendship and relationship with the rest of the staff has been softening her too much. But she has been improving lately; even without your interference she is harder on them than she used to be.\n\nYou slink up to one of your maids unnoticed, casually tripping her while she carries a vase expensive enough to buy a small house. She creates a terrible mess and you take Helena to the side, ordering her to deal out a proper punishment.\n\nAlthough the actual punishment for what she did should be very severe you doubt Helena at this point will go to the full extent of the law. If she does you’ll just have to stop her, considering you’re the one who forced this situation. You’re trying to test Helena, not get rid of an otherwise-useful servant.\n\nWhen you are finished with your commands Helena leaves the room and goes straight to the girl. You see your faithful retainer scolding the girl harshly, and threating her with punishments worse than firing her. It’s an impressive sight watching Helena nearly scare the girl half to death. The poor thing damned-near pisses herself.\n\nAt the end you are glad when she finishes instead of escalating the matter any further; progress has been made, you can be certain of that.";
			return toReturn;
		} else if (randNum < 66) {
			WorldControl.dayTime = 5; 
			GameControl.charGold += 50;
			toReturn = "You’ve sent Helena to deal with one food establishment that hasn’t paid its taxes for months. Knowing that she is not ready yet to take care of this on her own, you hypnotize her before she leaves, instructing her to be harsh to send a message.\n\nYou disguise yourself and follow her and her small entourage of body guards. When she arrives at the restaurant, she announces herself by slamming the door open telling to the clients to leave the place. \n\nShe asks the owner (an old, bald man) why he hasn't paid. He informs her fretfully that it is because he barely makes enough money to run the establishment, and there is nothing left to pay.\n\nHelena finds the answer unsatisfying, saying that minutes ago the place had plenty of people. The man, defeated, bows to her and asks for forgiveness, handing her a bag with what he owes, but Helena says that there needs to be a proper punishment for his lateness.\n\nWhen Helena snaps her fingers the guards start to trash the place, breaking windows, bottles of liquor and ruining his tables and chairs. \n\nThe man begs for forgiveness, but Helena says that it is too late to repent for his sins, and tells to the guards to keep going.\n\nOnce the place is truly ruined Helena orders to the guards to stop, and tells to the poor owner — now crying — that he can continue to do business now… but that if he “forgets” in the future to pay on time she will come to pay him a visit again, and next time she wont be so generous. \n\nSatisfied with the results, you go back to your castle to wait for Helena and her report.\n\n<i>“It was a success my liege, here is the money.”</i> she hands you a small bag with gold, you ask if she had any trouble. <i>“Nothing I couldn’t handle my liege, he and others will understand now the consequences of not paying in time.”</i> you nod and dismiss her, giving her the rest of the day for herself as a reward. ";
			return toReturn;
		} else {
			WorldControl.day += 2;
			toReturn = "You’ve been dealing with a merchant during the last couple of days, the man refuses to return the gold he owes you after he failed to deliver goods, claiming they were stolen and he doesn’t have the money as a result.\n\nWhatever the case, you are already tired of dealing with him and decide to send Helena to handle the situation in any way she wants. Of course, she’s still far too weak-willed, and you first order her into your chamber.\n\nShe’s reluctant to be sat on the spot and told to wait, but as usual she is drawn under your pendant’s influence without issue.\n\nWith your powerful, suggestive voice you order her to go to the throne room and get rid of the merchant once and for all.\n\nWhen you snap your fingers she immediately stands up and goes to the throne room. There, she is merciless in her attacks on the merchant’s character, clearly outlining his greed, his vices, and every little flaw. She humiliates him, until the merchant appears to feel so small he nearly collapses in on himself.\n\nStill, Helena doesn’t relent until she her breath runs out. Once finished, she calls for a handful of guards to “escort” the merchant to the nearest exit. The man is too baffled to do anything other than be practically carried away.\n\nHelena is definitely getting stronger, and you are happy with the results that you’ve seen today.\n";
			return toReturn;
		}

	}

	string dominantLevel2(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum < 33) {
			toReturn = "After many sessions changing Helena’s mind you finally think she is almost ready, and lately you’ve seen her being harsher and tougher with everyone, including the servants that she formerly treated so well. \t\n\nAs in the past, any excuse is good to keep pushing Helena in the right direction, and today is no different: One of your servants was caught stealing from the kitchen. It’s hardly the worst crime, but it is still unacceptable behavior from loyal servants and slaves. \n\nTricking Helena into being hypnotized has become harder, since she does whatever she wants more often than not lately. Nonetheless her will still falters before your own, and you command her to take care of the girl. You tell her to stop fooling around and going soft on them just because they are people she knows. \n\nYou follow her after you snap your fingers. She rushes to the living room where the servant is standing, looking down and waiting for their punishment. \n\n<i>“How you dare to rob from the castle? Haven’t we given you food and shelter? Is our generosity not enough to fulfill your greed?”</i> the girl wants to answer back, but Helena slaps her across the face. \n\n<i>“No excuses, there is not a single reason that I will accept for this type of behavior. Not from you nor from anyone else, do you understand?!”</i> The maid nods while sobbing, crying from the combination of scolding and the pain on her face. \n\n<i>“Now you’ll sleep tonight at the dungeon, maybe you will learn your lesson that way. And behave, if I hear any complain from the guards, you will stay there for an entire week!”</i> she tries to protest, fearing how the guards will behave and abuse her, but Helena isn’t moved. \n\n<i>“This is your punishment and I will not change it for any reason. If I hear anything else from you today, you’ll rot in there for a month, understood?!”</i> the girl nods and backs up while one guard approaches her to escort her to her “bedroom” for tonight.\n\nSatisfied, you think that Helena is making good progress. In no time she’ll be ready to take over. \n";
			return toReturn;
		} else if (randNum < 66) {
			WorldControl.dayTime = 5;
			toReturn = "There have been troubles in the red district, and many establishment have outright refused to pay recently. Although many of them have paid after some persuasion, there are still a few that refuse to do so.\n\nSuch an opportunity should not be wasted, and after putting Helena under your control you send her to take the gold back and punish the defiant. \n\nYou disguise yourself as one of her escort guards in order to follow, so that you can see in person what she exactly does. \n\nThe house is protected by both guards and prostitutes, but Helena uses her commanding and authoritative voice to force her way in, the commoners too afraid to oppose her. \n\nOnce inside, the woman that owes you rushes downstairs to meet Helena. She demands an explanation before being cut off by your faithful Helena. <i>”An explanation? I’ve no time for fulfilling petty requests. You will pay us or suffer the consequences.”</i>\n\nThe woman laughs until she notices the smile on Helena’s face, frowning and asking how she can be so confident.\n\n<i>“Don’t you realize? You have fucked up. You have no leverage here. You had one chance before failing to take me seriously. Now you will suffer the consequences.”</i>\n\nHelena turns around to face the servants of the woman <i>“Listen up. You have one choice: Or do as I tell you, or stay here and burn along with this house.”</i> she pauses just for a couple of seconds before continuing, brushing her nails idly on her dress. <i>“Time’s up, I am not known for my patience. All of you throw down your weapons and hold this traitor for me. Put her on her knees, and strip her from her clothes.”</i> \n\nThe woman screams at her servants to stand their ground, but they are rightfully intimidated by your guards despite their superior numbers. Although reluctant, they finally submit to Helena’s will, and when their leader turns around and tries to escape the maids at her side manage to lunge and restrain her long enough for her former guards to force her to her knees. They undress her with quick tugs, throwing torn cloth to the side in preparation for Helena.\n\nThe woman is still defiant while Helena walks towards her, but her expression very quickly changes once a loud slap cracks off of her face. <i>“Stupid bitch, you’ll learn your place now.”</i>";
			if (NPCCharList.CharFollower [iHelena].dickSizeCM > 0) {
				toReturn += "\n\nHelena exposes her dick and slaps the woman’s face with it a couple of times <i>“Now you’ll pleasure me, and if dare to harm me in any way you’ll end up begging for a fast death, something I would never give you.”</i> she then proceeds to force her dick in the woman’s mouth.\n\nIt seems the threat does its job; The woman doesn’t dare to bring any harm to Helena’s genitals. Although judging by her furious expression she doesn’t seem too eager to please, either.\n\n<i>“If you won’t work, I’ll take care of it then.”</i> Helena grabs her by the head and starts thrusting her cock down the woman’s gullet, practically choking her on cock. It’s not until the woman’s face has gone red from the lack of air that she’s finally released.\n\n<i>“If you don’t want to die with a faceful of genital, I suggest you to put some effort in now.”</i> \n\nReluctant, she starts to use her tongue and move on her own, pleasing Helena.\n\nThe intensity of the scene alongside the skillful tongue of the woman brings Helena to climax in matter of minutes, force feeding her victim a lurid load of sexual juices. \n\nOnce she is finished she casts the woman aside and asks to the servants to bring the gold of their former master. They bow to her and rush inside. It takes a few minutes before they retrieve a small coffer loaded with golden coins. It <i>is</i> a small fortune, but nothing exorbitant compared to your own riches.\n\n<i>“This will do. You are free now, do whatever you want with your former master, it is not my business anymore.”</i> After you leave you can hear the screams of the woman as her former guards begin to form a queue for the next go at her.";
			} else {
				toReturn += "\n\nHelena exposes her pussy and slaps the woman’s face a couple of times more <i>“Now you’ll pleasure me, and if dare to harm me in any way you’ll end up begging for a fast death, something I would never give you.”</i> she then proceeds to rub her pussy against the woman’s face.\n\nIt seems the threat does its job; The woman doesn’t dare to bring any harm to Helena’s genitals. Although judging by her furious expression she doesn’t seem too eager to please, either.\n\n<i>“If you won’t work, I’ll take care of it then.”</i> Helena grabs her by the head and drags the woman into her cunt, pinning her between soaking pussy lips until she can’t breathe, stopping only once her victim’s face is red with suffocation.\n\n<i>“If you don’t want to die with a faceful of genital, I suggest you to put some effort in now.”</i> \n\nReluctant, she starts to use her tongue and move on her own, pleasing Helena.\n\nThe intensity of the scene alongside the skillful tongue of the woman brings Helena to climax in matter of minutes, force feeding her victim a lurid load of sexual juices. \n\nOnce she is finished she casts the woman aside and asks to the servants to bring the gold of their former master. They bow to her and rush inside. It takes a few minutes before they retrieve a small coffer loaded with golden coins. It <i>is</i> a small fortune, but nothing exorbitant compared to your own riches.\n\n<i>“This will do. You are free now, do whatever you want with your former master, it is not my business anymore.”</i> After you leave you can hear the screams of the woman as her former guards begin to form a queue for the next go at her.";
			}
			return toReturn;
		} else {
			toReturn = "As of late Helena’s been assisting you beyond managing the servants. She even produces policy ideas and helps you handle issues pertaining to the kingdom itself.\n\nAlthough more eager to participate and give feedback, she still needs to be pushed a little more until she finally has the willpower to take care of everything by herself. \n\nToday there is an important meeting to talk about certain taxes. Helena as expected knows everything about it, or at least she is aware of which ideas will be popular and how they will impact the kingdom and its population. \n\nWhen the time comes, you tell her that you forgot that you had another meeting and that you rather go there, since she can take care of everything here. \n\n<i>“Are you sure about that?”</i> she asks, lacking the respectful tone that she used to have, clearly agitated by your indiscretions. With a shrug you attempt to look a little embarrassed, but you nod and reassure her that she can take care of it.\n\n<i>“Yes, you are right… Very well, I’ll make sure everything is in order then.”</i> \n\nShe turns around and leaves you behind. Indeed there’s no meeting to go to; you walk outside and have a sit-down in the park and relax for a while. By the time you’re sure the meeting will have finished, you return. Much to your surprise you see her sat in your throne, smiling to herself.\n\n<i>“Hope you don’t mind, but I assumed this was the best way for them to respect my authority while you were not here.”</i> It’s not exactly a valid reason for being sat in your seat, and she doesn’t appear to be in any hurry to vacate it.\n\nYou ask how it went <i>“It went fine. It’s taking them time to accept me in this position, but I know how to handle those who defy the throne… in the end it as a very productive meeting.”</i> \n\n<i>“I think they respect me more than you to be honest, you should toughen up.”</i> she says while standing from the throne and getting ready to leave <i>“I have other work to do now, do you need anything else?”</i> you shake your head.\n\n<i>“Good then.”</i> she leaves without preamble, still smiling to herself. Later you find out about the threats she had to deal out to get the nobles in line. Nonetheless she got the job done, which is what matters. Her attitude has changed so much, and you are not far from your final goal… and then she’ll be ready to take over. \n\n";
			return toReturn;
		}

	}



	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		PanCorruption.sortingOrder = -500;
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
