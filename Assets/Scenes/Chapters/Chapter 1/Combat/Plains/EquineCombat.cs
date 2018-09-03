using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class EquineCombat : MonoBehaviour {




	string mcpronoun; 
	Parser myParser = new Parser(); 

	int randNum; 

	public Text SceneText; 

	string face; 
	string arms; 
	string legs; 
	string race; 
	string gender;
	string beard;
	string physique;
	string build;
	string eyesColor;
	string hairColor;
	string dick; 
	string dickSize;
	string breasts;

	string line1;
	string line2;
	string line3;
	string line4;




	void Awake(){

		string face = myParser.callCharFace ();
		string arms = myParser.callCharArmsType ();
		string legs = myParser.callCharLegsType ();
		string race = myParser.callCharRace ();
		string gender = myParser.callCharGender ();
		string beard = myParser.callCharBeard ();
		string physique = myParser.callCharPhysique ();
		string build = myParser.callCharBuild ();
		string eyesColor = myParser.callCharEyesColor ();
		string hairColor = myParser.callCharHairColor ();
		string dick = myParser.callDickType ();
		string dickSize = myParser.callDickName ();
		string breasts = myParser.callBreastsName1 (); 
		string ballsSize = myParser.callTesticlesName ();


		// SET THE STATS OF THE ENEMY

		WorldControl.enemyID = 130; 
		WorldControl.furryPic = true; 
		WorldControl.futaPic = false; 

		WorldControl.enemyHP = 130;
		WorldControl.enemyLust = 20;
		WorldControl.enemyMaxHP = 130;
		WorldControl.enemyMaxLust = 100; 

		WorldControl.enemyCombDefense = 0.35f; // dmg reduction %
		WorldControl.enemyLustDefense = 0.2f; // dmg reduction %



		// appears in the UI

		WorldControl.eneName = "Stallion in heat";
		WorldControl.eneRace = "Equine";

		WorldControl.eneComType = "Agressive"; 
		WorldControl.eneLustType = "Harasser"; 

		WorldControl.eneDescription = "The plains isn’t that different from the other locations, in the fact that there are a lot of beasts roaming the place. You see that not far from you, some creature is running fast into your direction. From what you can see, it is a male figure that’s capable of covering large amounts of distance quickly. You try to move away from its path to see if it’s chasing someone, realizing that its current target is you without a hint of doubt. When it finally reach your current location, it doesn’t stop, so you are forced to dodge its tackle with all your skills. That creature finally stops a bit in front of you, slowly turning to meet your eyes. <i>“Looks like I have found myself a new pet. Surrender now, you won’t like me taming you.”</i> Your enemy turned completely to see you and snorts, preparing itself for the battle.\n";
		if (WorldControl.furryOn == true) {
			WorldControl.eneDescription += "After the dust settles, you can see your opponent’s appearance. It is an immense male covered in black fur that somehow resembled a horse-like man. Its strong muscular legs were a mix between a human and a horse, ending in big and blackish hooves. Its head was a mix between a man and a horse of a black color with parts white on the upper part of his muzzle, his horse ears looming above his head and black hair tied in a bun. A horse tail is hanging from above of its athletic and well-toned ass. Its giant cock stood at its length, dripping with fluids, completely ready for you.";
		} else {
			WorldControl.eneDescription += "After the dust settles, you can see your opponent’s appearance. It is an immense humanoid male, almost human except by some body features. Its strong muscular legs are mostly human, except that ended in big horse hooves instead of feet. Its head is of a man, except by a pair of horse ears looming above his head and a long black hair tied in a bun. Its giant cock stood at its length, dripping with fluids, completely ready for you. A horse tail is hanging from above of its athletic and well-toned ass.";
		}


		//////////////////// SCENES
		if (GameControl.mcGender == GameControl.MCGender.FEMALE) {
			mcpronoun = "girl";
		} else {
			mcpronoun = "boy";
		}


		//submit

		WorldControl.textSubmit = "When you see the mighty stallion in front of you, still ready for combat you think that you’re no match for this opponent. The thought of being taken by such a virile creature makes you excited, so you decide to submit to his own lustful thoughts. So, you remove your clothes as you present your naked body to the stallion in front of you. He snorts satisfied with your action. <i>“It’s good to know that you are properly trained”</i>"; 


		if (GameControl.dick1Size > 0) {
			WorldControl.textSubmit += "After that, he takes you from the shoulder and pushes you against the ground with force, as you land face down. <i>“Then I will put your training to the test,”</i> he says, as you can hear him placing himself below you. Without any warning, you feel a strong spank in one of your buttocks, as the surge of pain rushes through your whole body, causing you to wince a bit. As you recovered from the first one, you feel a second spank, that feels harder than the one before, causing you a stronger feeling of pain.\n\n\nHe grabs your ass, pressing the places where he spanked you, causing you a mix of discomfort and pleasure, as he presses his enormous cock against your asshole. You could feel how the precum was dripping against your tight pucker. After that, he rams his cock inside you, as you can feel how his dick flesh invades your insides with raw force, rubbing itself against the majority of your inner walls, almost fitting it like a glove. He rammed his large rod against your insides continuously, the mix of pain and pleasure blurring with each thrust of him \n\n\nAfter a while, you can feel his hands all over your "+ breasts + " chest, pinching your nipples with force and spanking you once more, as he brutally pounded his meat inside you over and over, your body getting covered in small bruises as he pushed you against the ground with each thrust. But even thought he is treating you so forceful, your body was feeling a rush of pleasure every time he did one of those things to your body.\n\n\nAs you finally feel on the verge of cumming, you finally feel the sweet release of the orgasm, your cock spurting your jizz into the ground that is below you, as your ass clenches to his cock, trying to entice him enough to cum for you. And after a couple of massages, you can finally feel his cock throb, as he finally cums. You can feel his cock filling your insides to the brim, as he pulls out and pours the rest of his load all over your ass and back, the strong scent of his jizz intoxicating you. <i>“Good. But you require further training. Return when you improve your insides capacity and we’ll see about that”</i>\n\n\nYou slip into the floor, completely exhausted and your asshole spilling the horse’s spunk as he leaves the place. You gather all your forces to return to the city, as you require some rest.";
		} else {
			WorldControl.textSubmit += "After that, he takes you from the shoulder and pushes you against the ground with force, as you land face down. <i>“Then I will put your training to the test,”</i> he says, as you can hear him placing himself below you. Without any warning, you feel a strong spank in one of your buttocks, as the surge of pain rushes through your whole body, causing you to wince a bit. As you recovered from the first one, you feel a second spank, that feels harder than the one before, causing you a stronger feeling of pain.\n\n\nHe grabs your ass, pressing the places where he spanked you, causing you a mix of discomfort and pleasure, as he presses his enormous cock against your asshole. You could feel how the precum was dripping against your tight pucker. After that, he rams his cock inside you, as you can feel how his dick flesh invades your insides with raw force, rubbing itself against the majority of your inner walls, almost fitting it like a glove. He rammed his large rod against your insides continuously, the mix of pain and pleasure blurring with each thrust of him \n\n\nAfter a while, you can feel his hands all over your "+ breasts + " chest, pinching your nipples with force and spanking you once more, as he brutally pounded his meat inside you over and over, your body getting covered in small bruises as he pushed you against the ground with each thrust. But even thought he is treating you so forceful, your body was feeling a rush of pleasure every time he did one of those things to your body.\n\n\nAs you finally feel on the verge of cumming, you finally feel the sweet release of the orgasm, your pussy dripping its femcum into the ground that is below you, as your ass clenches to his cock, trying to entice him enough to cum for you. And after a couple of massages, you can finally feel his cock throb, as he finally cums. You can feel his cock filling your insides to the brim, as he pulls out and pours the rest of his load all over your ass and back, the strong scent of his jizz intoxicating you. <i>“Good. But you require further training. Return when you improve your insides capacity and we’ll see...”</i>\n\n\nYou slip into the floor, completely exhausted and your asshole spilling the horse’s spunk as he leaves the place. You gather all your forces to return to the city, as you require some rest.";

		
		}



		//
		WorldControl.textDefeat = "You fall defeated into the floor, the strength and resistance of the stallion is too much for you to handle. Even though he is strong, who could have thought that he could be so fast at the same time.\n\n\nHe walks to you and lifts you off the ground, forcing you too see him face to face. <i>“I told you I would tame you if you resisted”</i> and with that, he uses his free hand to undress your clothes, exposing your naked body to him. You try to retaliate, but are too exhausted to do something that can stop him from continuing.\n";
		if (GameControl.dick1Size > 0) {
			if (GameControl.hasVagina == true) {
				mcPregnancy ();
			}
			if (GameControl.testiclesSize > 0) {
				line1 = " and your pair of "+ ballsSize +" balls";
			} else {
				line1 = "";
			}
			WorldControl.textDefeat += "He looks at your "+ dickSize +" "+ dick+" shaft,"+ ballsSize +". He pushes them aside, just to find your asshole packed between your buttocks. You can feel the musky scent of his cock soaked in his own precum, as he presses his cock against your asshole. He grabs you with both hands as he rams himself inside your tight anus. You can feel every bit of his cock as he batters it against your asshole, his cock meat pulsating against your inner walls, sending ripples of pleasure across your whole body.\n\n\nAfter that, he starts to thrust with his waist over and over, using you almost like a fucktoy, pumping you all over his dick using his two athletic hands. You can’t help but moan from the delight that his cock caused by rubbing against your sensitive places inside your rectum. After a while of him fucking you endlessly, you can feel him cum with force on your insides. But as his cock is almost sealing the way, you can feel his cum pushing farther inside you, bulging your belly with his loads of spunk. All these sensations send you over the edge, causing you to cum on your own, your cock spurting your own jizz all over your own chest and belly.\n\n\nWhen you thought that he would pull out, he started pumping you once more. <i>“We are not done yet,”</i> he says, as he rams you harder this time, your body still sensitive from cumming recently. Every rub feels more, every ram feels harder and every moan is louder than the others before it. And after a bit, you can feel him cumming once more, your belly getting bigger and bulging to the point that its hard not to notice it.\n\n\nYour mind is getting numb from all the sensations that he is forcing you to feel. Your body is so full of cum that it’s hard for you to think on anything else. You’ve been cumming several times, even though you have no more cum to spurt, but he doesn’t stop filling you up, his balls churning every time he pours another load of cum inside you, until you finally feel how he lowers you to the ground.\n\n\nYou can feel your belly so full of cum, even though its being drained through your asshole. You can only hear something from the stallion: <i>“This is a lesson. Don’t fight back,”</i> you hear as he leaves you on your own. You wait for the bulge to reduce just enough for you to return to the city.\n";
		} else {
			if (GameControl.hasVagina == true) {
				mcPregnancy ();
			}
			WorldControl.textDefeat += "He looks at your moist cunt and smiles, as it looks like it’s the thing that he is looking for. You can feel the musky scent of his cock soaked in his own precum, as he presses his cock against your pussy. He grabs you with both hands as he rams himself inside your cunt. You can feel every bit of his cock as he batters it against you, his cock meat pulsating against your inner walls, sending ripples of pleasure across your whole body.\n\n\nAfter that, he starts to thrust with his waist over and over, using you almost like a fucktoy, pumping you over his dick using his two strong and athletic hands. You can’t help but moan from the delight that his cock is causing by rubbing against your sensitive places inside your rectum. After a while of him fucking you endlessly, you can feel him cum with force on your insides. But as his cock is almost sealing the way, you can feel his cum pushing farther inside you, bulging your belly with his loads of spunk. All these sensations send you over the edge, causing you to cum on your own, your pussy drooling your sex juices and soaking his cock completely\n\n\nWhen you thought that he would pull out, he started pumping you once more. <i>“We are not done yet,”</i> he says, as he rams you harder this time, your body still sensitive from cumming recently. Every rub feels more, every ram feels harder and every moan is louder than the others before it. And after a bit, you can feel him cumming once more, your belly getting bigger and bulging to the point that it’s hard not to notice it.\n\n\nYour mind is getting numb from all the sensations that he is forcing you to feel. Your body is so full of cum that it’s hard for you to think on anything else. You’ve been orgasming several times, even though you have no more juices in you, but he doesn’t stop filling you up, his balls churning every time he pours another load of cum inside you, until you finally feel how he lowers you to the ground.\n\n\nYou can feel your belly so full of cum, even though its being drained through your pussy. You can only hear something from the stallion: <i>“This is a lesson. Don’t fight back,”</i> you hear as he leaves you on your own. You wait for the bulge to reduce just enough for you to return to the city.\n";
		}




		/////////////////////////////////////////
		WorldControl.textVictory = "The Dodo girl was no match for you! She yields and ask for forgiveness! But her fate is up to you.";
		WorldControl.location = "Plains - Dodo Girl Combat"; 

		WorldControl.dropGold = Random.Range(8, 20); 


		// loot 

		randNum = Random.Range (0, 100);

		if (randNum > 80) {
			WorldControl.dropItem = 1020;
		} else if (randNum > 60) {
			WorldControl.dropItem = 1021;
		}  else if (randNum > 40) {
			WorldControl.dropItem = 1022;
		}  else if (randNum > 20) {
			WorldControl.dropItem = 1023;
		} else {
			WorldControl.dropItem = 1024; 
		}





	}


	public void mcPregnancy()
	{
		if (GameControl.fertile == true && GameControl.isPregnant == false && GameControl.hasVagina) {
			Random.InitState(System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 100);

			if (GameControl.fertileVery == true) {
				if (randNum > 70) {
					GameControl.pregnantCounter = 10; 
					GameControl.isPregnant = true; 
					GameControl.pregnantText = "You can feel how your wide womb is thrashing and moving inside you, and somehow you can feel that the birth is at hand, so you call for your servants to help you with this event. You can feel how your water breaks when you are walking to your bedroom, being helped by your servants until you’re finally laying in your bed.\n\nYou can feel how the little creature is pushing against your cervix, as you feel the instinctive urge to push your insides out, while you try to calm down a bit and continue the labour. The servants panic, as they aren’t sure how much time will be before the midwife arrives, even when some of them have been on some births before this one. It would be funny if you didn’t feel like your insides are being torn by that creature, as if some long things were searching for the exit of your womb.\n\nWhen the midwife arrives, she takes control of the situation and helps you to go through with the birth, You can feel how the product advances through your cervix all the way into your vagina in a couple of hours. You push and breathe with the best of your ability, as you can feel how its head shows as it stretches your cunt even more than his father did at the time.\n\nYou grit your teeth as your child finally pushes its path to freedom, as you can feel your body relaxing after giving birth to it, as you try to catch your breath. You can see that the child’s skin is green and you could swear that it has leaves on its head, definitely a plant’s child. After knowing that, you finally blackout from exhaustion. You sleep for what you feel are like days, but you finally woke up and see that you are already clean, probably the servants took the time to wash you in your bed, almost as if nothing have happened.\n"; 

				}
			} else {
				if (randNum > 85) {
					GameControl.pregnantCounter = 10; 
					GameControl.isPregnant = true; 
					GameControl.pregnantText = "You can feel how your wide womb is thrashing and moving inside you, and somehow you can feel that the birth is at hand, so you call for your servants to help you with this event. You can feel how your water breaks when you are walking to your bedroom, being helped by your servants until you’re finally laying in your bed.\n\nYou can feel how the little creature is pushing against your cervix, as you feel the instinctive urge to push your insides out, while you try to calm down a bit and continue the labour. The servants panic, as they aren’t sure how much time will be before the midwife arrives, even when some of them have been on some births before this one. It would be funny if you didn’t feel like your insides are being torn by that creature, as if some long things were searching for the exit of your womb.\n\nWhen the midwife arrives, she takes control of the situation and helps you to go through with the birth, You can feel how the product advances through your cervix all the way into your vagina in a couple of hours. You push and breathe with the best of your ability, as you can feel how its head shows as it stretches your cunt even more than his father did at the time.\n\nYou grit your teeth as your child finally pushes its path to freedom, as you can feel your body relaxing after giving birth to it, as you try to catch your breath. You can see that the child’s skin is green and you could swear that it has leaves on its head, definitely a plant’s child. After knowing that, you finally blackout from exhaustion. You sleep for what you feel are like days, but you finally woke up and see that you are already clean, probably the servants took the time to wash you in your bed, almost as if nothing have happened.\n"; 

				}

			}


		} 

	}//

	public void charVirginitySubmit(){

		if(GameControl.isVirgin == true && GameControl.hasVagina){
			WorldControl.textSubmit += "\n\nYour character lost its virginity!";
			GameControl.isVirgin = false; 
		}

	}

	public void charVirginityDefeat(){

		if(GameControl.isVirgin == true && GameControl.hasVagina){
			WorldControl.textDefeat += "\n\nYour character lost its virginity!";
			GameControl.isVirgin = false; 
		}

	}



}
