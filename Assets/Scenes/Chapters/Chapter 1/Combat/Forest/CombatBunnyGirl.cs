using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class CombatBunnyGirl : MonoBehaviour {



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
		string dickSize = myParser.callDickName ();
		string breasts = myParser.callBreastsName1 (); 





		// SET THE STATS OF THE ENEMY

		WorldControl.enemyID = 100; 
		WorldControl.furryPic = true; 
		WorldControl.futaPic = false; 

		WorldControl.enemyHP = 80;
		WorldControl.enemyLust = 15;
		WorldControl.enemyMaxHP = 80;
		WorldControl.enemyMaxLust = 125; 

		WorldControl.enemyCombDefense = 0.2f; // dmg reduction %
		WorldControl.enemyLustDefense = 0.35f; // dmg reduction %



		// appears in the UI

		WorldControl.eneName = "Lustful bunny girl";
		WorldControl.eneRace = "Rabbit";

		WorldControl.eneComType = "Strong lust"; 
		WorldControl.eneLustType = "Alluring"; 

		WorldControl.eneDescription = "You stroll across the forest, meaning your own business until something caught your attention. It is a small sound of rustling across some bushes that were close to your location. It sounds like something -or someone- small is moving through them. You dismiss the sounds as some animal and try to continue your traveling, but the rustling follows you through the bushes parallel to you, until they were no more of them to hide. At that time, you saw a female silhouette appear from the last bush on your sight. It was small and somehow, it was looking directly at you, expecting something. After a pair of seconds of silence, the small figure stood up in its two feet, getting closer to you but still covered in shadows from the trees, slowly showing that it was a small humanoid female with bunny features. You could smell the scent of sexual fluids coming from her direction, her eyes transmitting you a carnal desire. -Has been a while since i’ve seen someone that’s not a savage predator… I need you… right now...-"; 
		if (WorldControl.furryOn == true) {
			WorldControl.eneDescription += "\nShe takes a step into the light, so you have a chance to discern her features. She was covered in brownish fur from head to toe. Her head was a combination of a bunny and a female human, with the bunny pointy ears and the animal nose, but retained a human type of blonde hair. She had a pair of furry toned legs that ended in medium digitigrade bunny feet. She sports a bunny tail that twitches every time you move suddenly. She had a pair of A-breasts standing proudly on her chest.";
		} else {
			WorldControl.eneDescription += "\nShe takes a step into the light, so you have a chance to discern her features. She was a human female, except that she had her legs covered in soft brownish fur, ending in a human feet with animal details. She had a pair of bunny ears sprouting from her blonde hair. And her frontal teeth were larger than the usual. She had a pair of A-breasts standing proudly on her chest.";
		}


		//////////////////// SCENES

		//submit

		WorldControl.textSubmit = "After the combat starts, you decide that you want nothing more at that moment, than be a recipient of the bunny’s lusts and hungers. You slowly strip off from your " +  ItemData.itemDataList [GameControl.charEquipment [1]].itemName +" and offer yourself to her. Your bunny enemy is reluctant at first, approaching you as her nose twitches as she inspects you. When she sees that you mean business, she smiles broadly and claps several times. -Finally, someone that i can get some relief from all this heat- She leaps with force over you, pinning you against the ground.";
		if (GameControl.dick1Size > 0) {
			WorldControl.textSubmit += "She grabs one of your hands and places it in her ass. -Here, get to work...- She says as she reaches to your groin, grabbing your "+ dickSize + " prick and stroking it with impatience. -I hope it endures the whole mating- She says, before pressing her pussy against it, rubbing your shaft with it until it gets completely hard. -Let us start this...- She aligns her twat with your cock, soaking it with her female juices and then proceeds to impale herself with it. It wasn’t that hard to do it, despite her being so small, as if she is accustomed to hold larger manhoods in her pussy. -Yeah, that hits the spot!- You can feel her insides almost burning as she starts to fuck herself with your rod, the sounds of your cock slipping inside her twat accompanied with her moans is the only thing you can hear. The feeling of being used by the bunny was quite pleasant, to know that she is using you more like a fuckrod was making you tremble with pleasure, as the bunny continued her lust frenzy all over you. \n\nYou see how the bunny leans towards you and licks your " +  breasts + " breasts, as she is heavily breathing, her lust barely being contained with your cock throbbing inside her pussy each time the pushes herself over it, her soft ass smacking against your hips. The friction of her pussy was too much for you to bear, so you couldn’t stop you from cumming inside her. You balls contract as your spunk is being poured inside her hungry cunt, as she is not letting a single drop of it spill on the floor. You can see that her face was of relief, as if it was something she needed. But when you try to relax a bit, you feel how she starts to bounce once more all over your sensitive cock. -Time for the second mating!- She yells, her energies returning as she begins once more rocking your dick back and forth.\n\nYou didn’t last much after a couple of minutes of continued fucking, as she keeps her fucking with you. -Come on, give it to me! I need it!- She says, and so you feel obliged to comply, cumming for a second time. You didn’t knew that you have that much sperm inside your balls, until you feel it tripping up your cock and into her needy womb. She didn’t stop as you keep cumming inside her, your fluids starting to drip a bit as she didn’t seems to be planning on stopping soon. -Again!- She yells in an ecstatic moan, playing with her own body. Your body is exhausted but she knows how to keep your groin from falling. You couldn’t think on anything else that wasn’t her pussy devouring your shaft again and again, along with the sound of fucking with it. At some point of that, you lost your consciousness.\n\nThe waking wasn’t that different from what you though. You see yourself completely drenched in both of your juices and you can see the little bunny resting next to you, completely asleep. You crawl out of her reach and grab your clothing, your whole body hurts but you dress yourself the best you can and proceed to return to the city, using the trees as support.  ";

		} else {
			WorldControl.textSubmit += "She grabs one of your hands and places it in her ass. -Here, get to work...- She says as she reaches to your groin, holding your pussy and rubbing it with impatience. -I hope it endures the whole mating- She says, before pressing her own pussy against it, rubbing your cunt with it until it gets completely wet. -Let us start this...- She aligns her twat with your own, soaking it with her female juices and then proceeds to scissor you with frenzy movements.. -Yeah, that rubs the spot!- You can feel her pussy almost burning as she starts to rub frantically with your groin, her moans is the only thing you can hear as both of your clits touch from time to time. The feeling of being used by the bunny is quite pleasant, to know that she is using you more like a fucktoy was making you tremble with pleasure, as the bunny continued her lust frenzy all over you. \n\nYou see how the bunny leans towards you and licks your "+ breasts +" breasts, as she is heavily breathing, her lust barely being contained with your pussy rubbing and pressing against her own each time she pushes herself over it, her soft ass smacking against your hips. The friction of her pussy was too much for you to bear, so you couldn’t stop you from cumming. Your thighs tremble as your femcum is being poured over her cunt, and with that she lets out a single and longer moan, finally cumming on her own. You can see that her face was of relief, as if it was something she needed. But when you try to relax a bit, you feel how she starts to rub herself once more all over your sensitive twat. -Time for the second mating!- She yells, her energies returning as she begins once more scissoring your cunt back and forth.\n\nYou didn’t last much after a couple of minutes of continued fucking, as she keeps her fucking with you. -Come on, give it to me! I want to hear it!- She says, and so you feel obliged to comply, cumming for a second time. It has been a while since you orgasmed so quickly just after one. She didn’t stop as you keep cumming, your fluids starting to slip into the floor as she didn’t seems to be planning on stopping soon. -Again!- She yells in an ecstatic moan, playing with her own body. Your body is exhausted but she knows how to keep your groin from falling. You couldn’t think of anything else that wasn’t her pussy frenzying over your pussy again and again, along with the sound of fucking with it. At some point of that, you lost your consciousness.\n\nThe waking wasn’t that different from what you though. You see yourself completely drenched in both of your juices and you can see the little bunny resting next to you, completely asleep. You crawl out of her reach and grab your clothing, your whole body hurts but you dress yourself the best you can and proceed to return to the city, using the trees as support.  \n";
		}



		//
		WorldControl.textDefeat = "You tried your best, but it wasn’t enough. You barely could stand in your feet, your will to fight was no more in sight, and your enemy knows this. You place one knee on the floor, utterly defeated by her, perhaps you must never underestimate an enemy only because of its size. You aren’t sure of what the bunnies do with their preys, as you know that they usually have no prey, so you aren’t sure what to expect. When you hear her characteristic way of walking with those paws of hers, you squint, waiting for anything.\n\nShe walks towards you with more confidence, now that she knows that you can’t fight back. -Don’t worry, dear. I won’t hurt you. I’ve been in you situation before… I know what being a prey is like- She push you against a tree that is behind you, placing your back against it. -But i want to be the predator for a change. And this is my chance...- She says, before undressing your "+ ItemData.itemDataList [GameControl.charEquipment [1]].itemName  +" and tossing it to the ground next to you.\n"; 
	
		if (GameControl.dick1Size > 0) {
			WorldControl.textDefeat += "After she undresses you, she sees your " + dickSize + " cock hanging between your legs half-limp. -This is what i was looking for. A wonderful dick for my itch… Don’t worry, i’ll make you’ll love it, as they do it to me- She kneels in front of you and starts to lick your cock and balls with her bunny girl tongue, helpíng herself with her little soft hands to lubricate your pecker. You don’t want to enjoy it, but her wet lapper is hard to resist. You try to take control of the situation, but you are so exhausted that your hands barely rub her bunny ears as you try to pull her away. You try to fight the excitement, but your body seems to enjoy is, as your cock finally gets hard.\n\nAs she realizes that you’re erect, she stands and sit on your lap. -See? It isn’t that hard to get hard- She rubs her short pussy against your crotch, smearing her jove juices all over it until she lifts her tight ass and penetrates herself on your cock quite suddenly. You try your best not to think much about the fact that you are being fucked by a lost bunny in the forest, but the sensation of her cunt rubbing against your prick is hard to ignore. Your body is getting warmer and you are losing your focus as she grinds alone all over your body, moaning like a madwoman.\n\nYou try to fight off the feeling, but it was getting harder by the minute. -You know you want it...- You pant harder as you can see her smile, as if she enjoys the teasing she was doing with you. As you feel how you are closer to cumming, you can feel how the bunny starts to grind to a halt. -Want me to stop?- What? But you are so close to cumming. You shook your head. -Then what do you want?- She says close to your ear, almost in a whisper. Her breath on your ear almost pushed you to the orgasm. You want more, you truly want for her to end what she started, as you start to enjoy the trip. And so, you try to grab her firm ass and entice her to continue her fucking. She gets a hold of your hands and guides them to her nipples as she resumes her bouncing on your lap.\n\nAfter that you see her cumming, probably that sensation of control excite her a lot, as you feel your cock getting a massage, courtesy of an orgasmic bunny girl. She moans and twitches as you feel her nipples getting harder than before. That caressing is more than you can resist, so you cum hard on her hungry twat, which seems that is devouring all your spunk, because she barely spills any of it. Her face is a mix between satisfaction and relief. After that, she lifts herself from you, a trickle of cum hanging from a line between her pussy and the tip of your cock. -Is amazing acting like a predator. I’m done with you… for now- You hear, before passing out.\n\nAfter a couple of hours, you wake up alone and naked. You find your clothing next to you, so you look around and see that you are alone. You dress up quickly before that situation changes and decide to head back into your city, before any other lost decides that its a good opportunity to strike.\n"; 

		} else {
			WorldControl.textDefeat += "After she undresses you, she sees your pussy between your legs half-limp. -This is what i was looking for. A wonderful pussy for my thirst… Don’t worry, i’ll make you’ll love it, as they do it to me- She kneels in front of you and starts to lick your cunt with her bunny girl tongue, using her little soft hands to rub it at the same time. You don’t want to enjoy it, but her wet lapper is hard to resist. You try to take control of the situation, but you are so exhausted that your hands barely rub her bunny ears as you try to pull her away. You try to fight the excitement, but your body seems to enjoy is, as your twat finally gets wet\n\nAs she realizes that you’re wetter, she stands and sit on your lap. -See? It isn’t that hard to get ready- She rubs her short pussy against your crotch, smearing her jove juices all over it until until she scissors you with ease. You try your best not to think much about the fact that you are being fucked by a lost bunny in the forest, but the sensation of her cunt rubbing against your own is hard to ignore. Your body is getting warmer and you are losing your focus as she grinds alone all over your body, moaning like a madwoman.\n\nYou try to fight off the feeling, but it was getting harder by the minute. -You know you want it...- You pant harder as you can see her smile, as if she enjoys the teasing she was doing with you. As you feel how you are closer to cumming, you can feel how the bunny starts to grind to a halt. -Want me to stop?- What? But you are so close to cumming. You shook your head. -Then what do you want?- She says close to your ear, almost in a whisper. Her breath on your ear almost pushed you to the orgasm. You want more, you truly want for her to end what she started, as you start to enjoy the trip. And so, you try to grab her firm ass and entice her to continue her fucking. She gets a hold of your hands and guides them to her nipples as she resumes her rubbing on your crotch.\n\nAfter that you see her cumming, as probably that sensation of control excite her a lot, you feel your pussy getting drenched in a mix of your fluids, courtesy of an orgasmic bunny girl. She moans and twitches as you feel her nipples getting harder than before. That caressing is more than you can resist, so you cum hard on her moist twat. Her face is a mix between satisfaction and relief. After that, she lifts herself from you, a trickle of cum hanging from a line between her pussy and your drenched cunt. -Is amazing acting like a predator. I’m done with you… for now- You hear, before you pass out.\n\nAfter a couple of hours, you wake up alone and naked. You find your clothing next to you, so you look around and see that you are alone. You dress up quickly before that situation changes and decide to head back into your city, before any other lost decides that it’s a good opportunity to strike.";
		}




		/////////////////////////////////////////
		WorldControl.textVictory = "The bunny girl was no match for you! She yields and ask for forgiveness! But her fate is up to you.";
		WorldControl.location = "Forest - Combat"; 

		WorldControl.dropGold = Random.Range(8, 20); 


		// loot 

		randNum = Random.Range (0, 100);

		if (randNum > 80) {
			WorldControl.dropItem = 1000;
		} else if (randNum > 60) {
			WorldControl.dropItem = 1001;
		}  else if (randNum > 40) {
			WorldControl.dropItem = 1002;
		}  else if (randNum > 20) {
			WorldControl.dropItem = 1003;
		} else {
			WorldControl.dropItem = 1004; 
		}
	}



}
