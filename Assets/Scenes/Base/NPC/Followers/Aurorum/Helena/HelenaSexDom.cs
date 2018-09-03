using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HelenaSexDom : MonoBehaviour {


	static int iHelena; 
	public Text Board; 
	int randNum;
	public Canvas endTurnPanel; 
	public Canvas panMainPanel;

	public Text scene0Name;
	public Text scene1Name;

	public Button scene0Butt; 
	public Button scene1Butt;

	public Text scene2Name;
	public Text scene3Name;

	public Button scene2Butt; 
	public Button scene3Butt;


	public void sexSceneSelector(int selector){

		loadHelenaData ();

		switch (selector) {
		case 0:
			Board.text = Scene0 ();
			break;
		case 1:
			Board.text = Scene1 ();
			break;
		case 2:
			Board.text = Scene2 ();
			break;
		case 3:
			Board.text = Scene3 ();
			break;
		}

	}


	string Scene0(){
		string toReturn;

		if (NPCCharList.CharFollower [iHelena].attWillpower < 66 && NPCCharList.CharFollower [iHelena].heightChar < GameControl.heightChar) {
			return "You need to make her dominant and make her taller than yourself!";
		}



		toReturn = "Today is a quiet day in the castle, with not much going on. You are in your studio, looking through your window, wondering how many acts of debauchery are being committed right now.\n\nThe sound of the door opening snaps you from your fantasies. Helena is at the doorstep, a smirk on her face.\n\n<i>“Heh, have you realized how small you are "+GameControl.playerName +"?”</i> I nod, at least compared to her I’m definitely shorter.\n\nShe walks towards me and grabs my ass cheek.\n\n<i>“Heh, soon I’ll be able to grab the whole thing just a hand.”</i> After groping me she pulls me hard against her chest. <i>“Heh, soon these will bigger than your head too.”</i>\n\nShe pushes me with enough strength to throw me to the floor. \n\n<i>“Ups, I guess I’m getting stronger too.”</i> she stands on top of me, her crotch in front of my face.\n\n<i>“You know, since you are there, why don’t you make yourself useful for once?”</i>";

		if (NPCCharList.CharFollower [iHelena].dickSizeCM > 0) {
			toReturn += "\n\nWith a swift move she takes her cock out. It lingers in front of me, soft.\n\n<i>“What are you waiting for? Get to work!”</i>\n\nShe grabs you by the hair and pulls you, smacking her dick against your face. With no options left, you have to submit to her and her phallus. It’s powerful smell invades your nostrils and make you salivate. \n\nYou take the head first, enjoying the salty flavor of it while you clean it. Your delight arouses Helena even more, her meat growing and filling your mouth, to the point that you have some trouble breathing.\n\n<i>“Don’t be a weakling and take it all! You’ll stay there until I had cum, and you better don’t waste a single drop either!”</i>\n\nAlthough you start to move on your own, this is not enough to satiate her lust, who after grabbing you by the ears starts to thrust and fuck your head at the pace she desires.\n\nShe uses you, yes, but you love how powerful is her will, and you can’t help yourself but to masturbate while she shakes your body for her pleasure. \n\n<i>“Hahaha really? You are pathetic "+ GameControl.playerName+ ". But since you worship my cock this much, here is your reward!”</i>\n\nShe suddenly starts to cum deep in my mouth. Most of her seed goes straight to your stomach, but some of her delicious nectar lands on your mouth and tongue, giving you the chance to taste it well before gulping it down while climaxing yourself.\n\nThe amount is too much that some of it spills, you lick your lips, and finally bend over to lick what’s on the floor. \n\n<i>“That’s it "+ GameControl.playerName+ ", don't waste a single drop.”</i>\n\nSatisfied for now, Helena is ready to leave.\n\n<i>“Keep the good work "+ GameControl.playerName+ " and I may give you another dose of cum.”</i>\n\nShe leaves, and you start to masturbate again, your recent experience with her deserving at least several orgasms for your body to be sated. \n\n";
		} else {
			toReturn += "\n\nWith a swift move she exposes her cunt to you. You can already smell her intoxicating aroma, her lips asking to be licked, sucked, fucked. \n\n<i>“What are you waiting for? Get to work!”</i>\n\nShe grabs you by the hair and pulls you, smacking your face against her pussy. You cant oppose such willpower and just submit to her. \n\nThe powerful aroma invades your nostrils, making you salivate. You open your mouth and her pussy invades all of it, to the point that you have some trouble breathing.\n\n<i>“You’re gonna eat me out until I climax, so if you want some air you better make it fast.”</i> \n\nYour tongue licks her weak spots and penetrates her pussy, cleaning it from her salty wetness. \n\nAlthough you move eagerly, this isn’t enough to satiate her lust, and after grabbing you by the ears she starts to thrust her hips and fuck your mouth at the pace she desires. \n\nShe uses you, yes, but you love how powerful is her will, and you can’t help yourself but to masturbate while she shakes your body for her pleasure. \n\n<i>“Hahaha really? You are pathetic "+ GameControl.playerName+ ". But since you worship my pussy this much, here is your reward!”</i>\n\nHelena starts to climax, her fluids landing straight into your mouth. With no choice you drink most of it, not like you mind since you love the taste. \n\n<i>“That’s it "+ GameControl.playerName+ ", don't waste a single drop.”</i>\n\nSatisfied for now, Helena is ready to leave.\n\n<i>“Keep the good work "+ GameControl.playerName+ " and I may give you another dose of me.”</i>\n\nShe leaves, and you start to masturbate again, your recent experience with her deserving at least several orgasms for your body to be sated. \n\n";

		}
		endTurnFun ();
		return toReturn;	
	}

	string Scene1(){
		string toReturn;


		if (NPCCharList.CharFollower [iHelena].attWillpower < 66 && NPCCharList.CharFollower [iHelena].heightChar < 360) {
			return "You need to make her dominant and make her taller at least 3.60 m in height!";
		}
		toReturn = "Helena visits you while you are in your chambers, not doing much really.\n\n<i>“Here you are "+ GameControl.playerName+ "... I was thinking, have you realized how now your size fits your weak personality? Short, pathetic, sad.”</i> Helena’s tone has become more aggressive. \n\nEvery time she has grown bigger, she has also turned more demanding and dominant.\n\n<i>“Come on, stand up and walk towards me.”</i> You do as she says.";

		if (GameControl.heightChar >= 170 && GameControl.heightChar <= 200) {
			toReturn += "\n\nAt this point she is so tall that your face is at her crotch level. ";

		} else if (GameControl.heightChar < 170) {
			toReturn += "\n\nHelena is so tall your face can’t even reach her crotch.";

		} else {
			toReturn += "\n\nHelena is significantly taller than you, to the point that you wont even need to bend much to reach her crotch with your face.";

		}
		toReturn += "\n\nYour dominatrix maid grabs your head with her hand as if it was an apple <i>“You’re so tinny "+ GameControl.playerName+ ", it’s so funny how I can toy with you.”</i>\n\nA smirk appears in her face. <i>“Actually, that gives me an idea... Follow me.”</i>\n\nYou do as you are told and follow her to the throne room. There isn’t too many people there, just some guards and servants. ";



		if (NPCCharList.CharFollower [iHelena].dickSizeCM > 0) {
			toReturn += "\n\n<i>“Not a big audience, but this will do. Turn around.”</i> When you do so she tears your outfit apart with ease, leaving you naked. \n\n You can feel her humongous dick slapping the back of the head, her thick precum drenching your hair. \n\n<i>“Let’s have some fun!”</i> she grabs you and raises you in the air. You struggle by instinct, although you don’t really want to fight her.\n\n<i>“Calm down right now or I will really be rough, "+ GameControl.playerName+ "!”</i> you finally manage to suppress the fighting spirit inside you and submit to her will and her cock. \n\n<i>“I can see that you are excited... Well, here is your prize for being such a good slut!”</i>\n\nWithout further ado she pulls you and fucks you in the ass, her dick so big it bulges your stomach.\n\nYou weep at first, the pain being too much, but your body rapidly adjust to your domina’s size.\n\n<i>“You were lusting for this, right? For this big cock to wreck you apart, like the pathetic bitch in heat that you are!”</i>\n\nShe mocks you and keeps fucking you in front of your servants and retainers, a true display of her current power over you. \n\n<i>“That’s right, your nothing like a bitch in heat, and I’ll make use of you until you are nothing but a mindless sex toy!”</i>\n\nMoving you up and down, she isn’t lying when she says you are nothing but a sex toy, moving you as if you were a simple onahole. \n\n<i>“Ahh... Fuck, you are so tight, get ready to be filled!”</i> Shortly after her warning you can feel how loads and loads of her cum start to fill your body.\n\nShe holds you balls deep until she has released everything, then throwing you to the side. \n\nYou lay on your stomach, cum leaking from your behind, your stomach bulging a little bit still for the sperm enema she just gave you.\n\n<i>“Ahh... It’s so great, I’ll make sure to treat you with ointments so you stay this tight, so I can release myself whenever I want.”</i>\n\nA servant promptly approaches Helena and starts to clean her cock with a towel. \n\n<i>“But for now you need to clean this mess, and make sure to take "+ GameControl.playerName+ " to its chambers. I wonder how long it will take it to be able to walk again.”</i>\n\nShe leaves the throne room, to do who knows what now, while your servants take care of you.";

		} else {
			toReturn += "\n\n<i>“Not a big audience, but this will do. Kneel.”</i> When you do so she tears your outfit apart with ease, leaving you naked. \n\nYou can see her shadow on top of you, the wetness of her pussy drenching your head and hair.\n\n<i>“Let’s have some fun!”</i> She starts to crouch, inserting your head in her pussy. You can barely breath right there, but she doesn’t minds it and keeps going down until she stops at your shoulders.\n\n<i>“Ah the size of your head is perfect "+ GameControl.playerName+ ", you’ll be my personal dildo from now on!”</i>\n\nShe starts to move up and down. You have a hard time not losing your balance, but you manage. \n\nThe intoxicating smell and taste of her fluids is too much for your body, who it’s aroused to the point of climax. Unable to hold yourself anymore, you start to masturbate while Helena keeps pleasing herself with your body. \n\n<i>“You were lusting for this moment "+ GameControl.playerName+ "? So naughty and pathetic, you are like a bitch in heat!”</i>\n\nShe mocks you but never stops fucking herslef with you, it isn’t long until she finally is on the edge of climax, her pussy clenching even tighter around you. \n\n<i>“Ahhh! Fuck! I can’t take it anymore, I’m cumming!”</i> her fluids start to drench your entire body, and you almost drown in so much femcum, but you can’t help yourself but to climax too.\n\nYou lie on a pool of her femcum and your own fluids, coughing.\n \n<i>“Hah so naughty, cumming from being used like that! You’ll be such a wonderful toy "+ GameControl.playerName+ ", but for now I have other business to attend to. Servants, take "+ GameControl.playerName+ " to a bed, and clean this mess.”</i> \n\nShe leaves the throne room, to do who knows what now, while your servants take care of you.\n\n";
		}

		endTurnFun ();
		return toReturn;	

	}

	string Scene2 (){
		string toReturn = ""; 

		if (NPCCharList.CharFollower [iHelena].attWillpower < 66 ) {
			return "You need to make Helena dominant! Increase her willpower!!";
		}else if (NPCCharList.CharFollower [iHelena].heightChar < 200){
			return "You need to make Helena taller!";
		}else{
			toReturn = "After a servant informed you that Helena wants to see you immediately you rush towards her chamber. \n\nYou’re anxious, knowing how Helena’s can be extremely punishing at times.\n\nWhen you knock the door Helena cheerfully answers <i>“Come inside "+ GameControl.playerName+"!”</i> \n\nYou thank the goddess that today she’s in a good mood.\n\nWhen you open the door Helena is waiting you in lingerie <i>“"+ GameControl.playerName+" I like to think of myself as a fair mistress, don’t you think so?”</i>\n\nNo.\n\n<i>“... And since you’ve behaved appropriately, I think I could give you a reward... come here you little thing...”</i>\n\nThe giantess invites you to get close to her with a hand gesture, and you do as she says, since at least her rewards aren’t disappointing \n\nOnce in front of her and before you can react she rips your clothes apart and grabs you by the hips, lifting you in the air.\n\nYou naturally react and struggle, but she calms you down <i>“Stay put and enjoy yourself "+ GameControl.playerName+"...”</i>";
			if (GameControl.dick1Size > 0) {
				toReturn += "\n\nShe puts your cock in her mouth and starts to softly caress it with her tongue, it’s slurping sounds echoing through the room.\n\nHelena may be a very tough mistress, but she knows how to treat anyone who has earned a reward: She takes care of your cock in a motherly fashion, treating your cock with love and tenderness that you wouldn’t believe it existed in her anymore. \n\n You expect her to take you down, but she has no problem lifting you; you’re not harder to deal than a big doll, at least for her, and you even enjoy a little bit to be dragged around.\n\nWithout much effort she takes your whole length inside her mouth, until her nose hits you in the belly. She smiles and looks into your eyes while she keeps deep throating you, inviting you just to release yourself in her.\n\nYou can’t resist her amazing tongue and warm mouth for too long, who could when she effortlessly can take it all and overwhelm you?\n\nWhen you shot your load it goes straight into her stomach, but she winks an eye to you, signaling that she’s fine with swallowing it all.\n\nWhen you’re done she keeps sucking you until your cock cums a second time, and finally deflates to its normal state.\n\nNow that you’re empty she takes you down. \n\n<i>“Hope you liked that "+ GameControl.playerName+", keep doing well and there’ll be more to come.”</i>\n\nShe tells you to leave with a hand gesture, and end up in the hall, naked, but satisfied.";
			} else {
				toReturn += "\n\nShe uses her tongue to lick your pussy and clit, softly caressing your body, its slurping sounds echoing through the room. \n\nHelena may be a very tough mistress, but she knows how to treat anyone who has earned a reward: She introduces her tongue inside you, carefully and in a motherly fashion, treating you with tenderness and love as she keeps going deeper into your sex. \n\n You expect her to take you down, but she has no problem lifting you; you’re not harder to deal than a big doll, at least for her, and you even enjoy a little bit to be dragged around.\n\nShe goes deep with her mouth until her nose hits you in the belly and she turns up and looks into your eyes with a smile on her face, inviting you to just relax and release in her face once you need it.\n\nYou can’t resist her amazing and warm tongue for too long, and who could really defy such an skilled use of a mouth as she is displaying right now?\n\nWhen you’re on your edge you squirt all over her face. Her faces is drenched in your juices, but she doesn’t mind, and even licks you clean once you’re over, swallowing whatever is in her mouth.\n\nNow that you’re done she takes you down.\n\n<i>“Hope you liked that "+ GameControl.playerName+", keep doing well and there’ll be more to come.”</i>\n\nShe tells you to leave with a hand gesture, and end up in the hall, naked, but satisfied.";
			}

		}
		endTurnFun ();
		return toReturn;

	}

	string Scene3(){
		string toReturn = "";

		if (NPCCharList.CharFollower [iHelena].attWillpower < 66) {
			return "You need to make Helena dominant! Increase her willpower!!";
		} else {

			toReturn = "<i>“You’ve been bad " + GameControl.playerName + ", why you force me to do this...”</i>\n\nThe reason of your punishment? Irrelevant; Helena always finds a good excuse to exert her authority with you. \n\nWhat matters is that right now you are tied to a padded wooden horse in the dungeon, your mouth gagged, and just waiting until Helena’s ready to proceed with what she deems appropriate for your faults, which is never proportional.\n\n<i>“Ahh love how this feels...”</i> you can hear when she puts the bottle of lube on the table just before feeling her cold hand slapping your butt, a slap so loud it echoed through the room.\n\n<i>“Did you liked that? Come on, tell me the truth... Oh right, you can’t.”</i> She hits you again and again until your ass is red.\n\n<i>“Well that’s enough foreplay, now comes the real thing. I know you’ll like it, you little masochist bitch...”</i>\n\nShe spreads your butt cheeks and you feel embarrassed when she exposes your asshole, even though this isn’t the first the she does this. ";
			if (GameControl.dick1Size > 0) {
				toReturn += "\n\nThen, you can feel how the tip of her warm cock starts to push into your insides.";
			} else {
				toReturn += "\n\nThen, you can feel how the tip of her strap starts to push into your insides.";
			}
			toReturn += "\n\nYou struggle for a moment, but she doesn’t slows down at all. As a matter of fact, she trusts forward, slapping now your already red ass with her body, as deep as she can be.\n\nGrabbing you by the hips, she commences to push in and out. Her movements at first are fast, mechanical, as if she really means to punish you instead of enjoy it herself, but soon she leaves behind her tough facade and she starts to enjoy herself, unable to hold off her own moans.\n\n<i>“Nghhh... Ahhh... D-Damn "+ GameControl.playerName+"... if you didn’t had such a naughty ass I wouldn’t be doing this you know... Nghhh...”</i>\n\nShe slaps you again and trusts you harder, hating yourself for the fact that you are enjoying how she is using you to satisfy herself.";

			if (GameControl.dick1Size > 0) {
				toReturn += "\n\nYour hard dick flips around, dripping precum all over the floor, making a small pool on it. \n\nAt this point, you wish you could beg Helena to untie you and let you touch yourself, grab and jerk your dirty cock until you squeeze every single drop of cum while she keeps ravaging you from behind.\n\nBut although you can’t you love being dominated by her, letting her control what you can and can’t do: In a sense, depriving you to do what you want is the kind of control that you need in a life where everyone always does as you say.\n\nFree from you royal duties, from your role, you can let yourself loose.\n\nHelena’s loves to do this for the opposite reason: For once she’s able to take control and be in power, although this power is flimsy and vulnerable, she’s make good use of it when she can, as right now. \n\nShe accelerates her pace, and by her increased moans you know she is about to climax.\n\nYou’re no far yourself, pre as thick as cum is leaking like crazy, and you can feel the pressure building up.";
				if (NPCCharList.CharFollower [iHelena].dickSizeCM > 0) {
					toReturn += "\n\n<i>“Here it comes "+ GameControl.playerName+"! My whole load just for you! Take it in your ass! Nghh!”</i> Helena delivers a huge load in your ass, it’s pressure forcing you to cum at the same time.\n\nYour cum flies over, it’s first powerful jets hitting your face and stomach, but the rest just landing in the floor, mixing with the cum of Helena that’s spills from your back entrance.";
				} else {
					toReturn += "\n\n<i>“Nghh! F-Fuck! I’m cumming!”</i> Helena starts to climax, you can feel how some of her squirt hits you, and she increases her speed, hitting you in the right spot and forcing you to cum at the same time. \n\nYour cum flies over, it’s first powerful jets hitting your face and stomach, but the rest just landing in the floor, mixing with the squirt of Helena’s.";

				}
			} else {
				toReturn += "\n\nYour wet cunt is dripping like a waterfall and in the dire need of being penetrated, a need that will not be fulfilled today. \n\nAt this point, you wish you could beg Helena to untie you and let you touch yourself, play with your clit and finger yourself until you squirt all over yourself while she keeps ravaging you from behind.\n\nBut although you can’t you love being dominated by her, letting her control what you can and can’t do: In a sense, depriving you to do what you want is the kind of control that you need in a life where everyone always does as you say.\n\nFree from you royal duties, from your role, you can let yourself loose.\n\nHelena’s loves to do this for the opposite reason: For once she’s able to take control and be in power, although this power is flimsy and vulnerable, she’s make good use of it when she can, as right now. \n\nShe accelerates her pace, and by her increased moans you know she is about to climax.\n\nYou’re not far yourself; your legs are already drenched in your juices, and your body trembling, resisting the climax until Helena’s ready too.";
				if (NPCCharList.CharFollower [iHelena].dickSizeCM > 0) {
					toReturn += "\n\n<i>“Here it comes "+ GameControl.playerName+"! My whole load just for you! Take it in your ass! Nghh!”</i> Helena delivers a huge load in your ass, it’s pressure forcing you to cum at the same time.\n\nYou squirt with such force that it almost looks like you are peeing, making a poll underneath you, a mix of your fluids and Helena’s cum. ";
				} else {
					toReturn += "\n\n<i>“Nghh! F-Fuck! I’m cumming!”</i> Helena starts to climax, you can feel how some of her squirt hits you, and she increases her speed, hitting you in the right spot and forcing you to cum at the same time. \n\n\nYou squirt with such force that it almost looks like you are peeing, making a poll underneath you, a mix of your fluids and Helena’s. ";

				}
			}

			toReturn += "\n\n\n<i>“Ahhh... T-That was great...”</i> she needs a minute to recover her breath and untie you. \n\n<i>“H-Hope you have learned your lession... unless you want to end up here again...”</i> oh, you know you haven’t learned nothing, nothing at all...";
			endTurnFun ();
			return toReturn;
		}


	}


	/*string drinkLevel4(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum < 33) {
			toReturn = "";
			if (NPCCharList.CharFollower [iHelena].dickSizeCM > 0) {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			} else {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			}
			toReturn += "\n\n";
			return toReturn;
		} else if (randNum < 66) {
			toReturn = "";
			if (NPCCharList.CharFollower [iHelena].dickSizeCM > 0) {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			} else {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			}
			toReturn += "\n\n";
			return toReturn;
		} else {
			toReturn = "";
			if (NPCCharList.CharFollower [iHelena].dickSizeCM > 0) {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			} else {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			}
			toReturn += "\n\n";
			return toReturn;
		}

	}*/

	void Start(){

		scene0Name.text = "Growing up";
		scene1Name.text = "Giantess";
		scene2Name.text = "Big oral";
		scene3Name.text = "Pegging";

		/*if (NPCCharList.CharFollower [iHelena].attWillpower >= 66 && NPCCharList.CharFollower [iHelena].heightChar > GameControl.heightChar) {
			scene0Butt.interactable = true; 
			scene0Name.text = "Growing up";
		}
		if (NPCCharList.CharFollower [iHelena].attWillpower >= 66 && NPCCharList.CharFollower [iHelena].heightChar >= 360) {
			scene1Butt.interactable = true; 
			scene1Name.text = "Giantess";
		}*/
			

	}


	void loadHelenaData(){
		iHelena = 0;

		while (iHelena < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iHelena].charID >= 3000 && NPCCharList.CharFollower [iHelena].charID < 4000){
				WorldControl.NPCID = NPCCharList.CharFollower [iHelena].charID;
				WorldControl.PortraitIDLayer0 = NPCCharList.CharFollower [iHelena].charPortraitLayer0;
				WorldControl.PortraitIDLayer1 = NPCCharList.CharFollower [iHelena].charPortraitLayer1;
				WorldControl.PortraitIDLayer2 = NPCCharList.CharFollower [iHelena].charPortraitLayer2;
				WorldControl.furryPic = NPCCharList.CharFollower [iHelena].isFurry;
				WorldControl.futaPic = NPCCharList.CharFollower [iHelena].isFuta;
				break; 
			}
			iHelena++;

		}

	}



	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		panMainPanel.sortingOrder = -500; 
		endTurnPanel.sortingOrder = 500;


	}


}
