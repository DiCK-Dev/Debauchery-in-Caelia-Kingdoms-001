using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CombatFlowerGirl : MonoBehaviour {



	Parser myParser = new Parser(); 

	int randNum; 
	public Text defeatText; 
	public Text submitText; 
	public Text SceneText; 
	string line1; 

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
	string dickSize; 
	string ass;


	// this is used to SETTLE the scene, add a simple script that changes the global ID and this will do the rest
	void Awake () {
		//
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
		string ass = myParser.callAss ();


		// SET THE STATS OF THE ENEMY

		WorldControl.enemyID = 120; 

		WorldControl.furryPic = false; 
		WorldControl.futaPic = true; 

		WorldControl.enemyHP = 70;
		WorldControl.enemyLust = 10;
		WorldControl.enemyMaxHP = 70;
		WorldControl.enemyMaxLust = 135; 

		WorldControl.enemyCombDefense = 0.35f; // dmg reduction %
		WorldControl.enemyLustDefense = 0.2f; // dmg reduction %



		// appears in the UI

		WorldControl.eneName = "Plant girl";
		WorldControl.eneRace = "Plant";
			
		WorldControl.eneComType = "Strong lust"; 
		WorldControl.eneLustType = "Alluring"; 
		WorldControl.eneDescription = "You wandered a bit through the forest, knowing that it was a dangerous place due to the Plague’s mutations. You found out one of the denizens of the woods, rooted close to a small creek. It was a beautiful plant that had the silhouette of a female, that looked like it was resting. Its head had a flower that shined with vivid colors. Its scent was so good, so sexually suggestive that you lost yourself for a second in carnal thoughts, and before you could think of anything else you found yourself taking a couple of steps on the plant’s direction. That creature awakes from its slumber, opening a pair of colorful eyes that centered over you. -Its time for me to pollinate. You’ll do a nice job for that.-\n\n\nWhen she stood properly, you had a chance to see her features. It was a female that was mostly human, except for her green skin coloration and leaf sprouts coming out of her skin in almost all of the extension of her body. Her head was like a human female, but it had a big and colorful flower that had an alluring fragrance coming out of it. Her arms ended in a pair of hands with quite large fingers. Her legs ended in a pair of human feel full of roots coming out of them. She had a handful of plant tentacles coming out of her back, moving as if they had a will on their own, all of them pointing at you and slowly moving behind her. She had a pair of D-breasts jiggling slowly on her torso and a nice, almost overflowing ass on her back."; 
		if (WorldControl.futaOn == true) {
			WorldControl.eneDescription += "\n\nThere was a big green cock hanging from between her legs, drenched in juice from what you could suppose it has her cunt below it.";
		}




		///////////////////////// text submit and defeat
		WorldControl.textSubmit = "You decide that it is more interesting to see what the plant has in mind for you. Those tentacles of hers looks so alluring, just like the flowers on her head. And so, you undress your "+ clothes  +" and present your body to the plant lady, wanting to be ravaged by her. The plant looks at you, its tentacles lashing behind her. -I’ll fertilize you completely- She says, her tentacles rushing to you, wrapping your arms and legs. They spread your arms and legs as the plant slowly walks close to you.\n";
			if (GameControl.hasVagina == true ) {
			mcPregnancy ();
			if (GameControl.dick1Size > 0) {
				line1 = "Your "+ dickSize +" "+ dick +" dick already dripping precum by the same reason." ;
			} else {
				line1 = ""; 
			}
			WorldControl.textSubmit += "She sees that you have a cunt soaked with the excitement of being ravished by her. "+ line1 +  " You "+  breasts +" breasts also entince her. After that, you feel how their other tentacles start to rub your whole body, teasing your skin with her soft appendages. They rub every naughty part of your body with a perceivable lust on every touch.\n\n\nShe teases your cunt and your asshole with some of them, enjoying how you moan as she does. And you are getting more and more excited by the fact that you are bound to her, just about to be used by her and her ravishing tentacles until she can’t continue and perhaps even farther than you can endure. One of them plays with your torso as the others rubbed against your ass and slap if occasionally.\n\n\n-Let’s begin then...- The plant lady moves a hand, as the tentacles that are close to your cunt and asshole insert themselves in your holes with force. You can feel them invading every part of your inner walls from both of your cunt and your pucker, brutally thrusting themselves again and again against your insides. One of them plunges inside your mouth, as if it were the plant’s cock, shoving itself against your throat. It have a bittersweet taste that is numbing your mind, making you harder to think other than to the wish to get rammed forever by those broad and long tentacles.\n\n\nYou lost the track of time, only focusing on the thrusting of those tentacles against your holes, and the rubbing of those appendages against your body. You look at the plant lady, as she is playing with herself, her hands fingering her own pussy that was hidden below a set of balls and a glistening green cock. You hear her moan aloud as you feel every tentacle around your body, twitching and squirming. Without delay, you feel how every last one of them starts to unload its contents all over you with a bittersweet liquid that you think is her cum. They cover you from head to toe, as the ones that are inside you stuff you with loads and loads of plant’s cum. You can feel the sap load pressing against your sensitive insides more and more, making you moan harder than before. You feel like if you are about to lose your mind, as there is no signal of them to stop stuffing you with her thick spunk.\n\n\nWhen you finally though that the plant will stop, you feel the tentacles moving once more just like before. -I have to make sure you’re properly fertilized- You body is still sensitive from cumming, so the tentacles feel even more stronger than before. You slowly lose your mind until you pass out from the pleasure.\n\n\nYou wake up finally, seeing yourself in a pool of bittersweet cum without the plant in sight. Your whole body is aching but you don’t feel regret for a single moment. You found that your clothing is still in its place, perhaps its not useful for someone that walks everywhere naked. So, you pick it up and return to your city.\n";
		

		} else {
			if (GameControl.dick1Size > 0) {
				line1 = "Your "+ dickSize +" "+ dick +" dick already dripping precum by the same reason.";
			} else {
				line1 = ""; 
			}
			WorldControl.textSubmit += "She sees your " +  breasts + " breasts alongside your "+ ass + " ass, inspecting it. "+ line1 +" After that, you feel how their other tentacles start to rub your whole body, teasing your skin with her soft appendages. They rub every naughty part of your body with a perceivable lust on every touch.\n\n\nShe teases your asshole with some of them, enjoying how you moan as she does. And you are getting more and more excited by the fact that you are bound to her, just about to be used by her and her ravishing tentacles until she can’t continue and perhaps even farther than you can endure. One of them plays with your torso as the others rubbed against your ass and slap if occasionally.\n\n\n-Let’s begin then...- The plant lady moves a hand, as the tentacles that are close to your asshole insert itself in your hole with force. You can feel it invading every part of your inner walls from your pucker, brutally thrusting itself again and again against your insides. One of the others plunges inside your mouth, as if it were the plant’s cock, shoving itself against your throat. It have a bittersweet taste that is numbing your mind, making you harder to think other than to the wish to get rammed forever by those broad and long tentacles.\n\n\nYou lost the track of time, only focusing on the thrusting of those tentacles against your holes, and the rubbing of those appendages against your body. You look at the plant lady, as she is playing with herself, her hands fingering her own pussy that was hidden below a set of balls and a glistening green cock. You hear her moan aloud as you feel every tentacle around your body, twitching and squirming. Without delay, you feel how every last one of them starts to unload its contents all over you with a bittersweet liquid that you think is her cum. They cover you from head to toe, as the ones that are inside you stuff you with loads and loads of plant’s cum. You can feel the sap load pressing against your sensitive insides more and more, making you moan harder than before. You feel like if you are about to lose your mind, as there is no signal of them to stop stuffing you with her thick spunk. The whole sensation of the situation sends you to an orgasm. \n\n\nWhen you finally though that the plant will stop, you feel the tentacles moving once more just like before. -I have to make sure you’re properly fertilized- You body is still sensitive from cumming, so the tentacles feel even more stronger than before. You slowly lose your mind until you pass out from the pleasure.\n\n\nYou wake up finally, seeing yourself in a pool of bittersweet cum without the plant in sight. Your whole body is aching but you don’t feel regret for a single moment. You found that your clothing is still in its place, perhaps its not useful for someone that walks everywhere naked. So, you pick it up and return to your city.\n";
		}



		WorldControl.textDefeat = "You can’t keep fighting, the attacks of the plant are too much for you to bear. You lay on your ass and see how the plant lady walks on your direction, her eyes fixed on your clothing. She throws her tentacles at you as it begins to remove your " + clothes +  " from you. You try to fight back, but its useless. All of your clothing lays scattered across the ground around you as she wraps your whole body in her tentacles, pressing against your " + breasts +  " chest."; 
		if (GameControl.hasVagina == true) {
			WorldControl.textDefeat += "You wriggle trying to free yourself from her grasp, but its completely useless. She has a very good hold of you. She turns your body as you are trapped, now with your ass facing\n to her. You turn your head, only to see that she is approaching to your ass with a long and green cock that is already wet. You feel it pushing against your snatch’s entrance. The tentacles hold you in place as she pushes it inside you firmly. You can feel it rubbing your nether lips with each pounding of your pussy. -After a while… Its good to finally breed someone...- She says as she grabs your ass and gives it a good squeeze as she keeps thrusting its big shaft. You don’t want to enjoy it, but you can feel how your body starts to get warmer and warmer, and your breathing are replaced by panting.\n\n\nThe throb of her cock inside your pussy only increases your pleasure, until you can’t hold it anymore and start to moan from the sensation. The plant rubs its tentacles around your body as it keeps intruding inside your body. The more you feel her cock inside you, the more you start to want more of it, as if its intoxicating scent was making you harder to think straight.\n\n\nThe plant has its way with your pussy on and on, as she plays with her own breasts, pinching its hard nipples as you continue moaning and groaning each time her cock gets to pound your sensitive snatch. You get to cum as the plant continued its thrusting, covering her shaft with your femspunk and trying to trap his cock and drain it of every last drop of sap that it could have inside it. And so, your wish was granted and you can feel how your opponent has its orgasm, painting your insides with the color of her plant’s cum, pouring a lot of it inside your twat.\n\n\nYou can’t do anything to stop him, but at that point you don’t want to stop him. It feels so good that the only thing that you can do is yell of pleasure as the lasts drops of her sexual juices fill your belly. After that, you feel how the plant starts to let you down on the ground as her face was of satisfaction and exhaustion. When you turn around, you see that all of her tentacles have poured a lot of her cum in the floor around you. She deposits you on the floor as she returns slowly to the forest. You try to see more, but you pass out.\n\n\nYou wake up several hours after, pick up your clothes from the ground around you and tell yourself never to lose again, or risk the danger of liking her dick too much and now from your own volition.\n\n\n"; 

		
		} else {
			WorldControl.textDefeat += "You wriggle trying to free yourself from her grasp, but its completely useless. She has a very good hold of you. She turns your body as you are trapped, now with your ass facing\n to her. You turn your head, only to see that she is approaching to your ass with a long and green cock that is already wet. You feel it pushing against your asshole’s entrance. The tentacles hold you in place as she pushes it inside you firmly. You can feel it rubbing your insides with each thrust against your pucker. -After a while… Its good to finally breed someone...- She says as she grabs your ass and gives it a good squeeze as she keeps thrusting its big shaft. You don’t want to enjoy it, but you can feel how your body starts to get warmer and warmer, and your breathing are replaced by panting.\n\n\nThe throb of her cock inside your asshole only increases your pleasure, until you can’t hold it anymore and start to moan from the sensation. The plant rubs its tentacles around your body as it keeps intruding inside your body. The more you feel her cock inside you, the more you start to want more of it, as if its intoxicating scent was making you harder to think straight.\n\n\nThe plant has its way with your back door on and on, as she plays with her own breasts, pinching its hard nipples as you continue moaning and groaning each time her cock gets to pound your sensitive anus. You get to cum as the plant continued its thrusting, as you try to trap his cock with your insides and drain it of every last drop of sap that it could have inside it. And so, your wish was granted and you can feel how your opponent has its orgasm, painting your insides with the color of her plant’s cum, pouring a lot of it inside your pucker.\n\n\nYou can’t do anything to stop him, but at that point you don’t want to stop him. It feels so good that the only thing that you can do is yell of pleasure as the lasts drops of her sexual juices fill your belly. After that, you feel how the plant starts to let you down on the ground as her face was of satisfaction and exhaustion. When you turn around, you see that all of her tentacles have poured a lot of her cum in the floor around you. She deposits you on the floor as she returns slowly to the forest. You try to see more, but you pass out.\n\n\nYou wake up several hours after, pick up your clothes from the ground around you and tell yourself never to lose again, or risk the danger of liking her dick too much and now from your own volition.\n"; 
		}




		WorldControl.location = "Forest - Combat"; 
		WorldControl.textVictory = "The plant girl was no match for you! She yields and ask for forgiveness! But her fate is up to you.";


		// loot 
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 100);

		if (randNum > 80) {
			WorldControl.dropItem = 1010;
		} else if (randNum > 60) {
			WorldControl.dropItem = 1011;
		}  else if (randNum > 40) {
			WorldControl.dropItem = 1012;
		}  else if (randNum > 20) {
			WorldControl.dropItem = 1013;
		} else {
			WorldControl.dropItem = 1014; 
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
