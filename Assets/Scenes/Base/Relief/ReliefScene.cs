using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ReliefScene : MonoBehaviour {
	public Text Board;

	Parser myParser = new Parser();
	public Button button1;
	public Button button11;
	public Button button12;
	/*
	public Button button2;
	public Button button3;
	public Button button4;
	public Button button5;
	*/
	public Canvas panEndTurn; 
	public Canvas mainCanvas; 


	string dickSize; 
	string breasts; 


	public void deactLowLust(){
		if (GameControl.actualArousal < 50) {
			//button4.interactable = false; 
			//button5.interactable = false; 
		}



	}



	void reliefScenes () {

		if (GameControl.actualArousal >= 50) {
			Board.text = "You wander around castle, lust building inside you, and start to wonder how you can relief yourself, what you have in mind?"; 
		}else {
			Board.text = "You dont feel that aroused, though you can find something to fix that..."; 
		}








	}


	public void reliefScene1(){

		dickSize = GameControl.mcDick1Name.toDescription ();
		breasts = GameControl.mcBreast1Name.toDescription ();
		endTurnFun ();

		GameControl.actualArousal = 0; 

		Board.text = ""; 
		if (GameControl.dick1Size > 0) {
			Board.text += "You go to your office, undress your lower clothes, exposing your cock. You start touching it slowly at first, playing with its length and enjoying the ripples of pleasure that it brings. You can feel how it starts to get hard, slowly growing in your hand as you continue to rub it faster and faster.\n\n\nAs your stroking gets faster, your lust increases and your body feels hotter until your shaft is at full-length and as hard as it can be. You can feel a trickle of precum, showing at the tip of your cock, proof that your member is ready for anything at that moment.\n\n\nYou start to think on things that you have seen or did in the past weeks. Every ass touched, every moan that you liked flowed through your mind like a torrent. You could feel your cock twitching with each time you rubbed, as if it remembered the same stuff and longed for them once more.\n\n\nYou start to pant as your hand move all by itself, rubbing your cock with intensity as your own hips begin to thrust a bit against your hand, soaking it in your precum as you grip it firmly, pressing it like a tight cunt. With your other hand, you start to massage your balls, as they were twitching from the pleasure that your cock was feeling at the moment. You don’t last long after that, the feeling of your impending orgasm rushes from your groin to the tip of your dick as your lower body shrinks in anticipation.\n\n\nYou finally have your orgasm from your "+ dickSize +" cock, spurting a stream of jizz into the floor that is in front of you, as waves of pleasure flows through your body again and again, as your mind is invaded with the only thought of “keep cumming”. After a couple of seconds of bliss, you finally recover your senses, take a deep breath and clean your mess quickly before returning to your duties. ";
		} else {
			Board.text += "You get into your office, close the door and remove your clothes, until you are finally naked, sitting in your comfortable chair. You can see that your pussy is already moist and is already a bit aroused, the scent of sexual fluids slowly seeping into your nostrils, as if trying to entice you to pay it some special attention.\n\n\nYou start to play with it, sighing in pleasure as you finally feel how your pussy is sending ripples of pleasure every time you touch it slowly. The labia starts to engorge as you touch it, your groin trembling from the delight that your fingers are causing as you caress it with anticipation. You ran a finger over your clitoris, calling it to go out and play. Every time you touch it, ripples of bliss start to wave across your body, filling you with a mix of relief and desire for more.\n\n\nYour other hand starts to play with your "+ breasts+ " breasts, pressing your nipples and massaging your breast-flesh with unspent desire as your hand only wanted to feel more and more of your sensitive flesh as your other hand explored the depths of your now overly-sensitive cunt, causing you spasms of delightment and thrust your hips against your own fingers every time your hands touch some sensitive place at the same time. \n\n\nYou can feel how your body moves instinctively, your hand in your slit rubbing faster by the second, your clit being attacked without mercy as your moans get to the point that you can’t hide them anymore nor have the wish to do so. You other hand jumps from one of your breasts to the other, pinching and massaging them in an effort of sating the increasing lust that is driving you mad.\n\n\nFinally, you can feel at the verge of orgasm. And without further warning, you feel how your whole body shrinks as your last moan is the biggest of them all. You can feel your orgasm hitting you like a wave of pleasure, pushing every nerve in your body to its limit as your tongue lashes out and you shut your eyes while your pussy walls begin to writhe and tremble, as your cunt starts dripping sexual juices all over the floor below you.\n\n\nYou lose your mind for what you think are seconds, as your sensual body is covered in a fine layer of sweat. The room is reeking with the smell of sex, as you slowly recover your conscience. You realize that at some point you changed hands, as your breasts are soaked in your lady juices. You finally clean yourself a bit before taking your clothes and taking a bath, finally relaxed and sated for the moment.";
		}


	}

	public void reliefScene11(){
		//armour scene
		if (GameControl.charArmorTags [1] == true && GameControl.charArmorTags [2] == true) {
			endTurnFun ();
			if (GameControl.dick1Size > 0) {
				Board.text = "As you are wearing the armor of the Maidens of Love, you feel that going to hide to your office to masturbate on your own isn’t going to work. You need something better than that, at least not that alone. You take a walk through the city, as you can feel the stares of the citizens trying their best not to be too obvious to you.\n\nYou arrive at the nice neighborhood you know well, but you change the alley as always. You accommodate yourself close to the entrance of it, but not completely exposed. You start remembering the eyes of the people that were looking at you on your way there, making memory of other occasions that the others have stared at your gorgeous armor and how it accentuates your figure. How many of them felt flustered or aroused at the mere sight of you, those memories flow through your head as you can feel your body getting hotter and hotter.\n\nYou start stroking your "+ GameControl.mcDick1Name.toDescription() +" "+ GameControl.mcDickType.toDescription() +"cock with one hand and you tease your chest with the other, as you realize that its already leaking precum from the thoughts you just had. You can’t help but moan loudly, almost proudly of yourself. After a while, you can see that one random citizen appears through the street in front of you, being guided by your lusty noises. You feel exposed to it, as your cock gets as hard as it can get, while your own hips move on its own, as if they are trying to show some good spectacle to it. \n\nYou can hear its panting from your show and you can feel your own orgasm coming through, your body trembling from all the pleasure that you’re having by being exposed to this random citizen. And without further dilation, you cum. Your dick convulses as it spurts its content with force, as your body is consumed in pulses of delight. Your body can’t help but feel exhibited as it does, until you finally are spent. As your lust numbness recedes, you can see a small puddle of fluids on the floor where the citizen was, probably went to its house to finish what you caused to it.\n\nYou clean yourself a bit as you recover your breath, as this kind of orgasms are quite powerful. And with that, you take a deep breath and return to work.\n\n";
			} else {
				Board.text = "As you are wearing the armor of the Maidens of Love, you feel that going to hide to your office to masturbate on your own isn’t going to work. You need something better than that, at least not that alone. You take a walk through the city, as you can feel the stares of the citizens trying their best not to be too obvious to you.\n\nYou arrive at the nice neighborhood you know well, but you change the alley as always. You accommodate yourself close to the entrance of it, but not completely exposed. You start remembering the eyes of the people that were looking at you on your way there, making memory of other occasions that the others have stared at your gorgeous armor and how it accentuates your figure. How many of them felt flustered or aroused at the mere sight of you, those memories flow through your head as you can feel your body getting hotter and hotter.\n\nWhen you start rubbing your cunt with one hand and you tease your cunt, you realize that its already dripping  juices from the thoughts you just had. You can’t help but moan loudly, almost proudly of yourself. After a while, you can see that one random citizen appears through the street in front of you, being guided by your lusty noises. You feel exposed to it, as your pussy get as wet as it can get, while your own hips dance on its own, as if they are trying to show some good spectacle to it. \n\nYou can hear its panting from your show and you can feel your own orgasm coming through, your body trembling from all the pleasure that you’re having by being exposed to this random citizen. And without further dilation, you cum. Your cunt convulses as it drips off its content into your thighs and the ground below you, while your body is consumed in pulses of delight. Your body can’t help but feel exhibited as it does, until you finally are spent. As your lust numbness recedes, you can see a small puddle of fluids on the floor where the citizen was, probably went to its house to finish what you caused to it.\n\nYou clean yourself a bit as you recover your breath, as this kind of orgasms are quite powerful. And with that, you take a deep breath and return to work.";

			}

		} else {
			Board.text = "You need to be using the Sisterhood's armour for this scene.";

		}



	}



	public void reliefScene12(){
		//armour scene
		string line1 = "";
		string line2 = "";
			endTurnFun ();
		if (GameControl.dick1Size > 0) {
			line1 = " while your dick pulsates as it spurts its contents with force all over his belly";	
		} 

		if (GameControl.hasVagina){
			line2 = "as your cunt starts trembling from your own orgasm, as you pour your lady fluids all over his groin.";	

		}

		Board.text = "You decide to make the most of your lust, and decide to make the most of someone else’s day too. So you get ready for going out, donning your clothes and taking a walk through the city, as you start hunting for your lucky citizen of the day.\n\nYou arrive at the nice neighborhood you know well, but you change the alley as always. You wait for someone to get too close to you on the alley. You expose your body as some of the people around you, walk around and noticing your exposed naughty bits. Most of them keep walking except one of them. It looks like a well-endowed man, as he seems to be quite interested in your show. The way that he looks at you is enough to send shivers down your spine, as you can feel his lust growing within the minute.\n\nYou motion him to follow you into the alley, something that he does willingly. When he gets inside, you place yourself against him, as you grab his hands and pin him against the ground. Despite your movements, you feel that he could not bear himself to touch you on his own. You grab his crotch and remove his lower clothing, exposing his dick. You can feel with your hand that he is already hard, his desire almost palpitating against your hand. \n\nAnd with that, you place his manhood between your buttocks and squeeze it with them, feeling its hardness against your ass flesh as you still have your hands over his own, immobilizing him a bit as you rub his cock with your ass. You can see his face full of lust as his precum stains your buttcheeks, as you press your body against his own, while hotdogging his cock. You can’t help but moan loudly, almost proudly of yourself as you can see how he trembles from the pleasure that you’re giving him. His hands tremble from the desire of touching you, but you stop him from doing it, as you continue storming him with your "+ GameControl.mcAssName.toDescription() +" ass.\n\nWithout further adding, you can see how he starts cumming from all the sensations that you caused to him, a powerful moan echoing through the alley as his dick spurts all his thick content over your ass and lower back, glistening with all that strong-scented sperm, as your body trembling from all the pleasure that you’re having by teasing until orgasm to a random citizen. And without further dilation, you cum. You can’t hold it anymore, "+ line2 +""+ line1 +" until you are finally spent. You raise from the guy, your ass leaking his seed slowly as you can see that he can barely babble, his face fixed in pleasure and delight. \n\nAnd with that, you clean yourself a bit as you recover your breath, as this kind of orgasms are quite powerful. After that, you take a deep breath and return to your castle.";


	}



	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		panEndTurn.sortingOrder = 500;
		mainCanvas.sortingOrder = -500;

	}


	void Awake () {
		WorldControl.location = "Relief"; 
		reliefScenes ();
		//deactLowLust ();

	}


}
