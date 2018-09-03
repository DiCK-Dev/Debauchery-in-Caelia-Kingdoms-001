using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CombatWolf : MonoBehaviour {
	
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
	string breasts;
	string clothes;
	string dickSize;

	string line1;


	// this is used to SETTLE the scene, add a simple script that changes the global ID and this will do the rest
	void Awake () {


		//parser
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
		string breasts = myParser.callBreastsName1 (); 
		string clothes = ItemData.itemDataList [GameControl.charEquipment [1]].itemName; 
		string dickSize = myParser.callDickName ();



		// SET THE STATS OF THE ENEMY
		WorldControl.enemyID = 110; 
		WorldControl.furryPic = true; 
		WorldControl.futaPic = false; 


		WorldControl.enemyHP = 80;
		WorldControl.enemyLust = 15;
		WorldControl.enemyMaxHP = 80;
		WorldControl.enemyMaxLust = 125; 

		WorldControl.enemyCombDefense = 0.25f; // dmg reduction %
		WorldControl.enemyLustDefense = 0.4f; // dmg reduction %



		// appears in the UI

		WorldControl.eneName = "Werewolf";
		WorldControl.eneRace = "Wolf";

		WorldControl.eneComType = "Strong will"; 
		WorldControl.eneLustType = "Aggresive"; 
		WorldControl.eneDescription = "You were aware of your surroundings on the forest, as you know very well that there are dangerous creatures wandering through the different parts of it. Your senses found out that something was lurking close to you, stalking your steps. You started walking erratically, only to confirm your suspicion: You were found. After that, you knew that whatever it is, it’s waiting for you to let your guard down, to strike you in an ambush. You could see its shade moving through the corner of your eye. So you moved into a clearing of the forest and confronted your enemy. The shade moved from among the trees, its yellow eyes fixed at you, filled with authority.. -You dare challenge my authority in MY domain? I’ll put you into your place, prey- He said as he let out a low growl, cracking its joints and baring its teeth."; 

		if (WorldControl.furryOn == true) {
			WorldControl.eneDescription += "\nYour enemy took a step into the light, letting you take a good look of it. It was a big male humanoid figure. His whole body was covered in thick blue fur. Its face was a hybrid of a wolf and a human, with yellow eyes, pointy canine ears and a canine muzzle. Its strong athletic legs ended in a pair of wolfish digitigrade paws that are a bit stained with dry blood. Its hands ended in claws. In his back there was a tail that was still, as if waiting along its owner for the correct time to attack. Its large cock stood erect, overflowing with fluids with a strong musky scent, overflowing with excitement from finally finding someone like you.\n"; 
		} else {
			WorldControl.eneDescription += "\nYour enemy took a step into the light, letting you take a good look of it. It was a big human male on most of its body, except for its arms and legs, that were covered in a thick patch of blue fur. Its head was mostly human, except that it had a pair of wolf ears sprouting from the top of its head, along with some extra animal features. Its legs ended in a pair of human feet with wolfish traits along them. In his back there was a tail that was standing still, as if waiting along its owner for the correct time to attack. Its large cock stood erect, overflowing with fluids with a strong musky scent, overflowing with excitement from finally finding someone like you."; 
		}




		///////////////////////// text submit and defeat
		WorldControl.textSubmit = "After the fight starts, you open your arms and tell to your opponent that you don’t want to fight anymore. That you won’t stand a chance against a superior opponent like him. The wolf chuckles and growls weary of your movements. The thought of being taken by such an alpha predator was making you excited already.";
		if (GameControl.hasVagina == true ) {
			mcPregnancy ();
			if (GameControl.dick1Size > 0) {
				line1 = "He also looks at your "+ dickSize + " shaft that is half-erect between your legs." ;
			} else {
				line1 = ""; 
			}
			WorldControl.textSubmit += "\nAnd with that, you shed your " + clothes +  "and push it to the side, presenting your body to your opponent. The wolf can see your cunt, your "+ breasts + " breasts. "+ line1 +" He walks in your direction with the confidence of a leader and fondle your ass and chest. -Good to see you can recognize a true alpha. Perhaps i should reward you for your obedience- He says, placing a claw on your shoulders then pressing it to force you on all fours.\n";

		} else {
			if (GameControl.dick1Size > 0) {
				line1 = "He also looks at your "+ dickSize + " shaft that is half-erect between your legs."  ;
			} else {
				line1 = ""; 
			}
			WorldControl.textSubmit += "\nAnd with that, you shed your "+ clothes +" and push it to the side, presenting your body to your opponent. The wolf can see your tight asshole, your "+ breasts + " breasts. "+ line1 +" He walks in your direction with the confidence of a leader and fondle your ass and chest. -Good to see you can recognize a true alpha. Perhaps i should reward you for your obedience- He says, placing a claw on your shoulders then pressing it to force you on all fours.\n\nThen he kneels behind you, squeezing firmly your ass with one of his claws before slapping it with force. You couldn’t help but moan a bit for that. -You will have the honor of feeling my knot. Of being breed by an alpha, even thought you can’t breed properly...- You can feel his big cock pushing against your asshole’s crown. Knowing that you’re going to be treated like an alpha’s bitch was making you so excited, your precum already making a small puddle below you. You can feel how your opponent’s leans his torso over your back as his cock forces its entrance inside your back door. Its large pulsing dick stretched your anus as the alpha established its dominance over you. He begins to pound it with vigor, each thrust pushing itself further into your needy hole.\n\n-Take it all!- You heard from above you, as you felt something even bigger forcing itself inside your asshole. You can feel its engorged knot entering your anus and sealing it completely. The pressure it makes against your inner walls was intoxicating, waves of pleasure flowing through your whole body as his cock started to fill you with a thick stream of hot cum and his throbbing knot was holding it all in place. You cum as you feel himself at his mercy, as his cock was breeding you as if you were one of his mates.\n\nYou didn’t counted the time that passed since both of you got tied, as your mind is clouded by the pleasure that his cock and knot caused you, until you felt its pressure no more. He slipped its soaked cock out of you alongside with its knot, leaving you in a puddle of your own sexual fluids. -I’ll se you again, bitch- You can see him walking away, his cock still dripping a mix of your fluids as he walked slowly into the thickness of the forest. After a while, you stood up from the ground, pick up your clothes and slowly walked back to the city. \n";
		}



		WorldControl.textDefeat = "You fell into your knees as the wolf finally struck you for the last time, sending you staggering against a tree nearby and forcing you to sit on the floor. Your blurred vision cleared only to perceive the wolf almost next to you, his cock is rock hard almost in front of your face. -Don’t move!- You ignore his words and keep trying to escape, but your opponent almost rip off your " + clothes + " and toss it aside as he tries to pin you down. You fight with him, only to fall face down as you try to escape his clutch, only to be held with one of his claws on your neck, being pinned against the floor in that manner."; 
		if (GameControl.hasVagina == true) {
			mcPregnancy ();
			WorldControl.textDefeat += "\nYou thrash your arms and legs a bit. -Enough!- As you try to do it, you feel one of its claws digging in your skin a bit, causing you a bit of pain, which makes you stop. After that, you can feel how he uses his other claw to finger your pussy a bit, as it was getting a bit wet by his caressing. He uses the claw that is holding you to lift you and place you against the same tree that was next to you, facing it. You can feel its cock rubbing against your pussy as he kept his claw still hurting you slightly, to keep you in place.\n\nYou feel how his cock makes its entrace inside your pussy, as he approaches your back and starts to play with the back of your neck, biting it a bit as he ravaged your twat with force. -If you don’t stay still, i’ll bite you harder...- He says as you can feel his sharp teeth running over your skin, sending you pleasurable shivers across your spine. His cock was pulsing with each pounding of her pussy, as his tongue lapped every part that his fangs delineated, sending waves of pleasure across your neck, being followed by an increasing heat.\n\nAt first you feel scared, but every time you feel his teeth only teasing your skin of your shoulders and neck, you start to enjoy that danger of the situation. The fact that his teeth are so close to your neck, mixed with the pleasure of being fucked so dominantly, feeds the lust with adrenaline as your heart pounds faster and faster. Your hands holds themselves of the tree in front of you, as your enemy keeps fucking you against it, pushing your body against the log every time he thrusts his throbbing rod against your snatch.\n\nWhen he finally decides to cum inside you, he bites you a bit harder than before, making you cry of pleasure, as your body is being filled with the cum of such dangerous creature. He could make you bleed, but he decides to ravage you, filling you with pleasure as much as he is enjoying your body. You cum, your body can’t handle that much emotions, as your love juices flow over the prick of the wolf, as your femcum starts to paint itself white from the spunk of your wolfish enemy. When he couldn’t fill you more, he releases the grip, letting you slip off the tree, your cunt leaking his jizz. -Good thing that you stood still- He says, before leaving you to yourself. You take the clothings that are scattered across the ground and return to your city.\n";


			

		} else {
			WorldControl.textDefeat = "\nYou thrash your arms and legs a bit. -Enough!- As you try to do it, you feel one of its claws digging in your skin a bit, causing you a bit of pain, which makes you stop. After that, you can feel how he uses his other claw to finger your asshole a bit. He uses the claw that is holding you to lift you and place you against the same tree that was next to you, facing it. You can feel its cock rubbing against your anus as he kept his claw still hurting you slightly, to keep you in place.\n\n\nYou feel how his cock makes its entrance inside your back door, as he approaches your back and starts to play with the back of your neck, biting it a bit as he ravaged your ass with force. -If you don’t stay still, i’ll bite you harder...- He says as you can feel his sharp teeth running over your skin, sending you pleasurable shivers across your spine. His cock was pulsing with each pounding of your asshole, as his tongue lapped every part that his fangs delineated, sending waves of pleasure across your neck, being followed by an increasing heat.\n\n\nAt first you feel scared, but every time you feel his teeth only teasing your skin of your shoulders and neck, you start to enjoy that danger of the situation. The fact that his teeth are so close to your neck, mixed with the pleasure of being fucked so dominantly, feeds the lust with adrenaline as your heart pounds faster and faster. Your hands holds themselves of the tree in front of you, as your enemy keeps fucking you against it, pushing your body against the log every time he thrusts his throbbing rod against your snatch.\n\n\nWhen he finally decides to cum inside you, he bites you a bit harder than before, making you cry of pleasure, as your body is being filled with the cum of such dangerous creature. He could make you bleed, but he decides to ravage you, filling you with pleasure as much as he is enjoying your body. Your body can’t handle that many emotions and you start to furiously cum on the ground while your ass is overflowing with the beast seed. When he is done using you, he releases the grip, letting you slip off the tree, your ass leaking his jizz. -Good thing that you stood still- He says, before leaving you to yourself. You take the clothings that are scattered across the ground and return to your city.";
		}
			


		/////////////////////////////////////////////////////
		WorldControl.textVictory = "He was no match for you. Although his gaze shows hatred, he has no other option but to yield at you. What will you do?";
		WorldControl.location = "Forest - Combat"; 

		WorldControl.dropGold = Random.Range(8, 20); 


		// loot 
		randNum = Random.Range (0, 100);

		if (randNum > 80) {
			WorldControl.dropItem = 1005;
		} else if (randNum > 60) {
			WorldControl.dropItem = 1006;
		}  else if (randNum > 40) {
			WorldControl.dropItem = 1007;
		}  else if (randNum > 20) {
			WorldControl.dropItem = 1008;
		} else {
			WorldControl.dropItem = 1009; 
		}
	}



	public void mcPregnancy()
	{
		if (GameControl.fertile == true && GameControl.hasVagina) {
			Random.InitState(System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 100);

			if (GameControl.fertileVery == true) {
				if (randNum > 70) {
					GameControl.pregnantCounter = 10; 
					GameControl.isPregnant = true; 
					GameControl.pregnantText = "You can feel how your distended womb is thrashing and moving inside you, and somehow you can feel that the birth is at hand, so you call for your servants to help you with this event. You can feel how your water breaks when you are walking to your bedroom, being helped by your servants until you’re finally laying in your bed.\n\nYou can feel how the little creature is pushing against your cervix, as you feel the instinctive urge to push your insides out, while you try to calm down a bit and continue the labour. The servants panic, as they aren’t sure how much time will be before the midwife arrives, even when some of them have been on some births before this one. It would be funny if you didn’t feel like your insides are being torn by that creature, as if it’s clawing its way out.\n\nWhen the midwife arrives, she takes control of the situation and helps you to go through with the birth, You can feel how the product advances through your cervix all the way into your vagina in a couple of hours. You push and breathe with the best of your ability, as you can feel how it's head shows as it stretches your cunt even more than his father did at the time.\n\nYou grit your teeth as your child finally pushes its path to freedom, as you can feel your body relaxing after giving birth to it, as you try to catch your breath. You can see that the child has a small tail and its ears are higher than normal, definitely is a wolf’s child. After knowing that, you finally blackout from exhaustion. You sleep for what you feel are like days, but you finally woke up and see that you are already clean, probably the servants took the time to wash you in your bed, almost as if nothing have happened."; 

				}
			} else {
				if (randNum > 85) {
					GameControl.pregnantCounter = 10; 
					GameControl.isPregnant = true; 
					GameControl.pregnantText = "You can feel how your distended womb is thrashing and moving inside you, and somehow you can feel that the birth is at hand, so you call for your servants to help you with this event. You can feel how your water breaks when you are walking to your bedroom, being helped by your servants until you’re finally laying in your bed.\n\nYou can feel how the little creature is pushing against your cervix, as you feel the instinctive urge to push your insides out, while you try to calm down a bit and continue the labour. The servants panic, as they aren’t sure how much time will be before the midwife arrives, even when some of them have been on some births before this one. It would be funny if you didn’t feel like your insides are being torn by that creature, as if it’s clawing its way out.\n\nWhen the midwife arrives, she takes control of the situation and helps you to go through with the birth, You can feel how the product advances through your cervix all the way into your vagina in a couple of hours. You push and breathe with the best of your ability, as you can feel how it's head shows as it stretches your cunt even more than his father did at the time.\n\nYou grit your teeth as your child finally pushes its path to freedom, as you can feel your body relaxing after giving birth to it, as you try to catch your breath. You can see that the child has a small tail and its ears are higher than normal, definitely is a wolf’s child. After knowing that, you finally blackout from exhaustion. You sleep for what you feel are like days, but you finally woke up and see that you are already clean, probably the servants took the time to wash you in your bed, almost as if nothing have happened."; 

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
