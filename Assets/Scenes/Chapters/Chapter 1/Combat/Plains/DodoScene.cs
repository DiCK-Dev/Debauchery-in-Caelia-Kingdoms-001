using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class DodoScene : MonoBehaviour {


	Parser myParser = new Parser(); 

	public RectTransform panTurnEnd;
	public Text Board; 
	public Button buttScene1;
	public Button buttScene2;
	public Button buttScene3;
	public Button buttScene4;
	public Button buttScene5;
	public Button buttScene6;

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
	string clothes; 
	string ballsSize; 

	string line1;
	string line2;
	// this is used to SETTLE the scene, add a simple script that changes the global ID and this will do the rest
	void Awake () {

		buttScene2.enabled = !buttScene2.enabled; 
		if (WorldControl.enemyLust >= 50) {
			buttScene2.enabled = !buttScene2.enabled;
		}
		buttScene3.enabled = !buttScene3.enabled; 
		if (WorldControl.enemyLust >= WorldControl.enemyMaxLust) {
			buttScene3.enabled = !buttScene3.enabled;
		}

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
		string dickSize = myParser.callDickName ();
		string clothes = ItemData.itemDataList [GameControl.charEquipment [1]].itemName; 
		string ballsSize = myParser.callTesticlesName ();

		WorldControl.location = "Plains - Victory";






	}



	public void Scene1(){
		GameControl.actualArousal = 0; 


		Board.text = "After a hard fight, you defeat your opponent and finally drained her of her will to fight. You can see that she has a hard time standing still. You think it’s probably because her body is so plump and ripe, that she has such a trouble balancing by herself on the ground. Her body is quite alluring, even though she is short-stacked, so you don’t want to miss this opportunity with such a nice ass and tits in front of you.";
		if ( GameControl.mcSex == GameControl.MCSex.Woman || GameControl.mcSex == GameControl.MCSex.Cuntboy ) {
			Board.text += "You undress your " + clothes +" and wear your strap-on, taking your time as she lays on her side, presenting her round and plump ass to you. You expose your own pussy and your " + breasts + " breasts, as she places herself on all fours, trying to stand up. You seize the opportunity and grab her ass with both hands, squeezing it and then slapping one of her buttcheeks with some force, her ass-flesh jiggling at your spank. She moans slightly from your rough treatment, turning to see you from her position.\n\n\nYou rub the strap-on against her pussy, that is getting moist from your hard caressing over her. When you feel that her cunt is wet enough, you grab her waist with both hands and thrust your dildo inside her, trying to push it all the way. You can hear her moanings getting louder, as she starts to play with her own breasts, while you fuck her with great force.\n\n\nAs you pound your strap-on against her ample ass, you can see that she is wincing as she is probably getting used to that much cock-flesh inside her. <i>“Oh, yes… Fuck this dirty girl!,”</i> she moans as you ravage her pussy like a demon. Her tits bounce with each time that you thrust her with your fake cock. Her feather ruffle and shake as she cries in delight. <i>“Use me! I’m nothing more than a bird-slut!,”</i> she says almost in a musical tone.\n\n\nAfter that, you hear from her only moans and urges to fuck her harder, mixed together in a symphony that only gets you more lustful, the only desire in your mind at that moment is that this little bird’s brains must be fucked out, so you increase your pace and force, almost pushing her away with each thrust against her, digging your fingers in her tender flesh to keep her in place. <i>“ABUSE THIS CUMBUCKET! USE ME UNTIL YOU’RE FULL!,”</i>.\n\n\nAnd without requiring further inspiration, you can feel your orgasm hitting you like a whirlwind, as your pussy convulses and begin to drool your own femcum through your thighs as you push the dildo as far as you can, making her squeal in ecstasy as her whole body trembles. She flaps her wings every time you feel another wave of your own orgasm hitting you because you move the strap-on inside her, as her tongue flails out of her mouth and her whole body shrinks until you’re finally spent up.\n\n\nShe slips off your dildo, falling into the ground facedown, her rump still presented to you as it drools with her own vaginal juices. You can barely hear some pleas for you to continue using her, coming out of her mouth. You didn’t knew that the dodo’s in these places could be such sluts. And with that, you left her to enjoy herself and return to the city.";

		} else if (GameControl.mcSex == GameControl.MCSex.Man   && GameControl.charArmorTags[11] == false) {
			if (GameControl.testiclesSize > 0) {
				line1 = " and your pair of "+ ballsSize +" balls";
			} else {
				line1 = "";
			}

			if (GameControl.hasVagina == true) {
				line2 = ", alongside your moist cunt ready for anything";
			} else {
				line2 = "";
			}

			Board.text += "You undress your "+ clothes +", taking your time as she lays on her side, presenting her round and plump ass to you. You expose your own "+ dick  +" "+ dickSize+" cock"+ line1 + " "+ line2 +", as she places herself on all fours, trying to stand up. You seize the opportunity and grab her ass with both hands, squeezing it and then slapping one of her buttocks with some force, her ass-flesh jiggling at your spank. She moans slightly from your rough treatment, turning herself to see you from her position.\n\n\nYou rub your dick against her pussy, that is already getting moist from your hard caressings over her. When you feel that your cock is hard enough, you grab her waist with both hands and thrust your cock inside her, trying to push it all the way. You can hear her moaning getting louder, as she starts to play with her own breasts, while you violently fuck her.\n\n\nAs you pound your shaft against her ample ass, you can see that she is wincing as she is probably getting used to that much cock-flesh inside her. <i>“Oh, yes… Fuck this dirty girl!,”</i> she moans as you ravage her pussy like a demon. Her tits bounce with each time that you thrust her with your cock meat. Her feather ruffle and shake as she cries in delight. <i>“Use me! I’m nothing more than a bird-slut!,”</i> she says almost in a musical tone.\n\n\nAfter that, you only hear moans and urges to fuck her harder from her, mixed together in a symphony that only gets your cock harder, the only desire in your mind at that moment is that this little bird’s brains must be fucked out, so you increase your pace and force, almost pushing her away with each thrust against her, digging your fingers in her tender flesh to keep her in place. <i>“ABUSE THIS CUMBUCKET! USE ME UNTIL YOU’RE FULL!,”</i>.\n\n\nAnd without requiring further inspiration, you can feel your orgasm hitting you like a whirlwind, as your cock convulses and begins to fill her insides with your hot jizz, making her squeal in ecstasy, as her whole body trembles. She flaps her wings every time that you pour your load inside her, as her tongue flails out of her mouth and her whole body shrinks, until you’ve finally filled her up, as you see that her cunt can’t hold no more and spills your spunk into the floor beneath her.\n\n\nShe slips off your dick, falling into the ground facedown, her rump still presented to you as it drools with your cum. You can barely hear some pleas for you to continue using her, coming out of her mouth. You didn’t knew that the dodo’s in these places could be such sluts. And with that, you left her to enjoy herself with her pussy full and return to the city.";
			charVirginity ();

		
		} else if (GameControl.mcSex == GameControl.MCSex.Man   && GameControl.charArmorTags[11] == true) {
			if (GameControl.testiclesSize > 0) {
				line1 = " and your pair of "+ ballsSize +" balls";
			} else {
				line1 = "";
			}

			if (GameControl.hasVagina == true) {
				line2 = ", alongside your moist cunt ready for anything";
			} else {
				line2 = "";
			}

			Board.text += "You undress your clothes and take out your reliable dildo on your hand, taking your time as she lays on her side, presenting her round and plump ass to you. You expose your "+ dickSize +" cock"+ line1 +", and your " + breasts +" breasts, as she places herself on all fours, trying to stand up. You seize the opportunity and grab her ass with both hands, squeezing it and then slapping one of her buttcheeks with some force, her ass-flesh jiggling at your spank. She moans slightly from your rough treatment, turning to see you from her position.\n\nYou rub the sex toy against her pussy that is already getting moist from your hard caressing over her. When you feel that her cunt is wet enough, you grab her waist with one hand and thrust your dildo inside her with the other, trying to push it all the way. You can hear her moanings getting louder, as she starts to play with her own breasts, while you fuck her with great force by using the dildo.\n\nAs you pound your sex toy against her ample ass, you can see that she is wincing as she is probably getting used to something that big inside her. <i>“Oh, yes… Abuse this dirty girl!,”</i> she moans as you ravage her pussy like a demon. Her tits bounce with each time that you thrust her with your fake cock. Her feather ruffle and shake as she cries in delight. <i>“Use me! I’m nothing more than a bird-slut!,”</i> she says almost in a musical tone.\n\nAfter that, you hear from her only moans and urges to fuck her harder, mixed together in a symphony that only gets you more lustful, the only desire in your mind at that moment is that this little bird’s insides must be fucked out, so you increase your pace and force, almost pushing her away with each push against her, digging your fingers in her tender flesh to keep her in place. <i>“RAVAGE THIS CUMBUCKET! USE ME UNTIL YOU’RE FULL!,”</i>.\n\nAnd without requiring further inspiration from her behalf, you can feel your orgasm hitting you like a whirlwind, as your cock convulses and begin to spurt your jizz all over her plump ass as you push the dildo as far as you can, making her squeal in ecstasy while her whole body trembles. She flaps her wings every time you feel another wave of your own orgasm hitting you because you push the dildo inside her, as her tongue flails out of her mouth and her whole body shrinks until you’re finally spent up.\n\nShe slips off your dildo even before you can pull it out, falling into the ground facedown, her rump still presented to you as it drools with her own vaginal juices. You can barely hear some pleas for you to continue using her, coming out of her mouth. You didn’t knew that the dodo’s in these places could be such sluts. And with that, you left her to enjoy herself and return to the city.\n";



		}

	}


	//TITJOB/FACESITTING VICTORY - Dodo girl(Chapter1), Forced Oral,
	public void Scene2(){
		panTurnEnd.SetAsLastSibling ();
		Debug.Log ("Scene 2 is working");
		GameControl.actualArousal = 0; 

		Board.text = "You can see how your opponent looks unable to continue fighting, its will to fight completely drained from her body, even though you can see the fires of lust still burning inside her eyes, as she falls into her plump ass and keeps looking at you. <i>”Come on! I promise I’ll make it worthwhile”</i>. she says in an alluring tone, playing with her bountiful breasts with her feathered wings as she grinds her thighs, her moist cunt scent reaching your face.";

		if ( GameControl.mcSex == GameControl.MCSex.Woman || GameControl.mcSex == GameControl.MCSex.Cuntboy) {
			Board.text += "You remove your clothes quickly as you show your moist pussy to her. You kneel carefully over her face, rubbing your pussy against her face. She looks at what you’re doing and you don’t need to say anything, as she uses her long tongue to play with your vaginal lips, her wet tongue playing with your sensitive cunt-meat. The feeling of her tongue and mouth against your delicate cunt is fantastic, your fluids smearing her face, as she slurps them with delight using her long and thin tongue.\n\nYou can’t resist the urge to grab her head and start thrusting your hips against her, your pussy grinding faster and faster against her head, as she reach for your clit, as if she’s trying to make you cum with all her ability. The welcoming sensation of her wet tongue wrapping and stroking your clit each time you push her head against your groin is too much for you to bear.\n\nYou can’t hold your orgasm any longer, as you play with your chest as you held her face against your twat as it begins to cum hard on her face, as you can’t stop pushing your hips against her flexible tongue. Your pussy juices starts to soak her face and breasts as it slides through all her chest. When she see that you’re cumming already, she darts her mouth to slurp your femspunk with the best of her ability, her tongue lapping you happily, as she moans wildly while her whole body trembles from pleasure. You can see that she is orgasming from enjoying your femspunk, her cunt dripping her vaginal fluids into her thighs.\n\nWhen you are completely spent from that orgasm, you pull out of her mouth. She is almost covered from head to her torso with your sex fluids, as her face is one of satisfaction. You think that she truly made it worthwhile as you dress, before leaving the dodo girl to enjoy herself, as she smears your juices all over her chest.";

		} else if (GameControl.mcSex == GameControl.MCSex.Man   ) {

			if (GameControl.testiclesSize > 0) {
				line1 = " and your pair of "+ ballsSize +" balls";
			} else {
				line1 = "";
			}

			if (GameControl.hasVagina == true) {
				line2 = ", as your pussy rubs itself and taints him with your juices";
			} else {
				line2 = "";
			}

			Board.text += "You remove your clothes quickly as you show your "+ dickSize +" dick"+ line1 +""+ line2 +". You kneel carefully over her torso, rubbing your cock against her ample breasts, as you slide it between them. She looks at what you’re doing and you don’t need to say anything, as she uses her wings to squeeze your dick, pumping her boob-flesh up and down all over your cock. The feeling of her soft and sensitive breasts rubbing your cock is fantastic, your precum smearing them causing a wet sound, as she licks the tip of it with her long and thin tongue, slurping your fluids with delight.\n\nYou can’t resist the urge to grab her pillowy breasts and start thrusting your hips against them, your cock grinding faster and faster against her enormous tits, as she reach for the head of your dick and opens her mouth, allowing you to use it as a fuckhole. The welcoming sensation of her wet tongue wrapping and stroking your cock each time you overcome her breasts-flesh, is too much for you to bear.\n\nYou can’t hold your orgasm any longer, as you press her tits against your cock firmly as your cock begins to cum hard on her breasts, as you can’t stop pushing your hips against her torso. Your spunk starts to soak her breasts as your white juice slides through all her chest. When she see that you’re cumming already, she darts her mouth to engulf your cock with the best of her ability, gulping load after load of your jizz, her tongue milking you happily, as her own moans are muffled by your dick in her mouth, as her whole body trembles from pleasure. You can see that she is orgasming from gulping your cum, her cunt dripping her vaginal fluids into her thighs.\n\nWhen you finally have not even a single drop of cum in you, you pull out of her mouth. She is almost covered completely in your jizz, as her face is one of satisfaction. You think that she truly made it worthwhile as you dress, before leaving the dodo girl to enjoy herself, as she smears your seed all over her chest.\n";


		}
	}


	//ANAL/SCISSOR VICTORY - Dodo girl(Chapter1), Lust Fuck,
	public void Scene3(){
		panTurnEnd.SetAsLastSibling ();
		Debug.Log ("Scene 3 is working");

		GameControl.actualArousal = 0; 

		Board.text = "You can see how your feathered enemy is lying on the ground, betrayed by her own lust. She has her tongue out while she plays with her own breasts using her wings while she teases her own pussy with her legs, but you can see that it’s something hard due to her body shape. You can see the reason why she is so desperate to find a mate.\n\n<i>”Please! I’ll do anything you want, but fuck me!,”</i> she pleads to you, her cunt dripping with her own juices. You can see how her own lustful body bounces each time she plays with herself, so you feel happy to oblige for this once.\n";

		if ( GameControl.mcSex == GameControl.MCSex.Woman || GameControl.mcSex == GameControl.MCSex.Cuntboy) {
			Board.text = "You walk to her as you take off your clothes slowly, as you can see her cunt drooling as you expose your own cunt. You run a hand over your "+ breasts +" chest as she spreads her legs.\n\nyou push her against her back with your foot, as you spread your own legs and press your pussy against the dodo girl’s twat, finding that is already soaked in her vaginal juices. So you press your pussy against her groin a bit, just to see her reaction. <i>”Yes! Rub it with your pussy! Just do it already!,”</i> she yells out loud, your teasing driving her mad from lust. So, you grab her by her waist and slowly rub your cunt against her own, the precum from both of you helping you lubricate enough for the pressing to go better than you expected. She squeals in ecstasy as she feels how you press your wet pussy against her dripping cunt, as you tease her breasts with one of your feet, enjoying the softness from her bouncy orbs as you grab her thighs to use them as leverage to press your groin against hers.\n\nYou can hear her lust-filled screams, as she enjoys being used by you. You can see that her thighs are completely drenched in her cunt juice. <i>”It’s so hard to find a such a strong specimen in these parts, so use me until you’re done!.”</i>.\n\nYou can feel how her feathers of her ass rub against your thighs every time your clits rub against each other, sending waves of pleasure cross your whole body. Her whole body jiggles and trembles, as her breasts and ass moves with every time you pull her from her legs. As she tries to hold herself with her mouth from one of your legs, you can’t hold on your orgasm anymore. Your pussy twitches as it soaks your cum agains’t the dodo girl’s own snatch, as both of your moistness flow through your thighs and into the floor below you. After feeling your own moans of ecstasy, she moan in a high pitch as she has her own orgasm. You can feel how your thighs are being soaked with the dodo girl’s vaginal juices, as you keep scissoring her. \n\nYou release the grip of her legs as you can feel your sensitive pussy relaxing slowly from your own orgasm. She falls completely into the floor as this continues. <i>“So sensitive… So good,”</i> she babbles as her tongue in hanging from her mouth. You give her ass a good slap, before dressing once more and leave the place.";

		} else if (GameControl.mcSex == GameControl.MCSex.Man   && GameControl.charArmorTags [11] == false) {

			if (GameControl.testiclesSize > 0) {
				line1 = " and your pair of " + ballsSize + " balls";
			} else {
				line1 = "";
			}

			if (GameControl.hasVagina == true) {
				line2 = ", as your pussy rubs itself and taints him with your juices";
			} else {
				line2 = "";
			}

			Board.text += "You walk to her as you take off your clothes slowly, as you can see her cunt drooling as you expose your " + dickSize + " dick " + line1 + "" + line2 + ". You run a hand over your " + breasts + " chest as she spreads her legs, but you search for another thing as you have other plans in mind.\n\nYou turn her facedown with your arms, as you spread her buttocks and stroke your cock until there is precum at your tip, finding that even her pucker is a bit soaked in her vaginal juices. So you press your cock against her asshole a bit, just to see her reaction. <i>”Yes! I don’t care if you want to put it in there, just fill me with your dick!,”</i> she yells out loud, your teasing driving her mad from lust. So, you grab her by her waist and slowly push your cock inside, the precum from both of you helping you lubricate enough to push against her insides. She squeals in ecstasy as she feels how you ram your cockmeat against her insides, as you grab her breasts with one hand, enjoying the softness from her bouncy orbs each time you thrust your meat against her anus.\n\nYou can hear her lust-filled screams, as she enjoys being ravaged by you. You can see that her thighs are completely drenched in her cunt juice as she rubs it with one of her wings. <i>”It’s so hard to find a such a powerful specimen in these parts, so fuck me until you’re done!.”</i>.\n\nYou can feel how her feathers of her ass rub against your thighs every time her pucker admits your cock, as you can feel it rubbing her hot insides as her asshole’s crown wraps tight around your cock, feeling extremely tight. Her whole body jiggles and trembles, as her breasts and ass moves with every time you pound her. As she clenches her muscles of her ass, you can feel her whole insides pressing against your shaft, as you can’t hold on your orgasm anymore. Your cock twitches as it spurts your cum inside the dodo girl, filling her insides more and more. After feeling your spunk being poured in her, she moan in a high pitch as she has her own orgasm. You can feel how your thighs are being soaked with the dodo girl’s vaginal juices. \n\nYou pull out of her, as you can see that the cum that she is unable to hold in place is sliding off her anus and flowing into the floor below her. She falls completely into the floor as this continues. <i>“So full… So good,”</i> she babbles as her tongue in hanging from her mouth. You give her ass a good slap, before dressing once more and leave the place.";


		} else if (GameControl.mcSex == GameControl.MCSex.Man   && GameControl.charArmorTags [11] == true) {
			Board.text = "No scene yet for characters with chastity tag";
		}
	}



	void Start (){
		CityControl.city100Slaves[4] += 1;
		Board.text = "What you want to do to the dodo girl? For the second scene you need to increase his lust up to 50 during battle. For the third one you need to defeat him with lust! ";


	}





	void charVirginity(){

		if(GameControl.isVirgin == true){
			Board.text += "\n\nYour character lost its virginity!";
			GameControl.isVirgin = false; 
		}

	}




}
