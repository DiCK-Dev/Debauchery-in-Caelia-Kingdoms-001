using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class SceneBunny : MonoBehaviour {



	Parser myParser = new Parser(); 

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

		WorldControl.location = "Forest - Victory";






	}



	public void Scene1(){
		GameControl.actualArousal = 0; 
		Board.text = "You finally see how your opponent is defeated, her legs trembling from exhaustion, or maybe a hint of fear from her behalf. -I’ll do anything you want… Please. I’m your prey.- She sits slowly on the ground, as if to not disturb you. You see how she lays on her back, spreading her legs. You can see how her cunt is almost dripping wet, probably from her anticipation of finding someone who could deal with her lust. You see in her eyes the urge to escape mixed with the desire to mate with you. You didn’t gave her the opportunity to take a decision.";
		if ( GameControl.mcSex == GameControl.MCSex.Woman || GameControl.mcSex == GameControl.MCSex.Cuntboy) {
			Board.text += "You undress your "+ clothes +" until you are completely naked, exposing your figure and placing yourself hovering above her, your "+ breasts +" chest hovering above her head. You place your cunt over her small body, her eyes fixated on your womanhood as she isn’t sure yet of your intentions as a whole, so you decided that you would give her a little push. You take her small hands and place them over your pussy and force her to rub it.\n\n\nYou could feel her little hands rubbing against your barely-wet pussy, reluctant at first but after a bit of obeying, she starts to get the hang of it. You command her to keep doing it, her hands starting to get soaked with your pre-juices. She nods a bit as she starts doing it faster, as you can feel how your body gets warmer and your cunt gets wetter with each rub from her hands.\n\n\nAs you feel that you are wet enough, you kneel down above her and place your [vagina] in front of her face, holding her in place from the root of her bunny ears. She doesn’t understand at first, but when she sniffs your female scent coming out of your womanhood, she gets the drift and starts licking it. She presses her petite torso against your thighs as she starts licking your nether lips, constantly looking at you as if she were looking for approval from you about her licking skills. She uses her tongue to cover your snatch with her drool, focusing on your lust button and then going down on your pussy, as you enjoy her careful lapping over it.\n\n\nAs you see that she isn’t going forward, you wait for her to be on your inner lips, before pushing your cunt against her face using her bunny ears as support, rubbing it against your pussy. She squirms a bit for the surprise, but can’t do anything more than open her eyes wide as you start to rub your snatch against her mouth and nose. You can feel her tongue trying to plunge your inner walls as you keep pressing your soft flesh against her mouth wildly. Even though you are using her face in a savage way, you hear small moans coming out of her throat, muffled by the blocking of your pussy against her mouth. Perhaps she likes to be a prey after all.\n\n\nYou continue to rub and force her to lick you until you feel that you are at the brink of your orgasm. At that moment, you keep pressing your cunt against her and cum in there. The feeling of her nose and tongue against your pussy was delightful. You see how her eyes roll back into her head, as you can see how she is forced to have a taste of your femspunk. Her face was one of pure bliss, as she fell into her back and laid herself there, breathing heavily. You decide that she had enough for the moment, so you take your clothing and leave her laying on the floor of the forest.";

		} else if (GameControl.mcSex == GameControl.MCSex.Man  ) {

			Board.text += "You remove your "+ clothes +" until you are completely naked, exposing your figure and placing yourself hovering above her, your "+ breasts +" chest hovering above her head.. You place your " + dickSize +  " "+ dick +" dick over her small body, her eyes fixated on your manhood as she isn’t sure yet of your intentions as a whole, so you decide that you would give her a little push. You take her small hands and place them over your cock and force her to stroke you.\n\n\nYou could feel her little hands rubbing against your half-limped dick, reluctant at first but after a bit of doing it, she starts to get the hang of it. You command her to keep doing it, her hands starting to get soaked with your precum. She nods a bit as she starts doing it faster, as you can feel how your body gets warmer and your prick gets harder with each rub from her hands.\n\n\nAs you feel you are hard enough, you kneel down above her and place your "+ dickSize +" prick and balls in front of her face, holding her in place from the root of her bunny ears. She doesn’t understand at first, but when she sniffs your male musk coming out of your cock, she gets the drift and starts licking it. She presses her petite torso against your "+ ballsSize + " as she starts licking your cock, constantly looking at you as if she were looking for approval from you about her licking skills. She uses her tongue to cover your cock with her drool, focusing on the tip and then going down its whole length, as you enjoy her careful lapping over it.\n\n\nAs you see that she isn’t going forward, you wait for her to be on your tip, before pushing your cock against her face using her bunny ears as support, filling its mouth with your prick-flesh. She squirms a bit for the surprise, but can’t do anything more than open her eyes wide as you start to thrust your dick inside her mouth. You can feel her tongue trying to wrap your shaft as you keep fucking it like a beast. Her mouth felt wetter and softer every time you ravage her face, as if it were getting used to your size. Even though you are using her face in a savage way, you hear small moans coming out of her throat, muffled by the invasion of your cock, as it pushes against her throat continuously. Perhaps she likes to be a prey after all.\n\n\nYou continue to thrust until you feel that you are at the brink of your orgasm. At that moment, you push as far as you can inside her throat and let yourself cum in there. The feeling of her throat against your cock was something delightful for you. You see how her eyes roll back into her head, as you can see how she is being forced to steadily gulp your cum load over and over again. When you feel that you can give her no more cum, you pull out, as a good amount of cum starts spilling from her mouth and falling into her chest. Her face was one of pure bliss, as she fell into her back and laid herself there, breathing heavily. You decide that she had enough for the moment, so you take your clothing and leave her laying on the floor of the forest. \n"; 


		}

	}


	public void Scene2(){
		GameControl.actualArousal = 0; 
		Board.text = "After a short but fierce battle, your bunny enemy lies facedown in the ground in front of you. You can see that she’s aroused, but utterly defeated. You can see that she has her rear lifted despite her torso being on the ground, as if she tries all her best to entice you into taking her in the spot. -Won’t you see something you like?- You can see her tight pucker below her fluffy tail and above her soft pussy. You made up your mind of what you want to do with the small bunny girl."; 
		if ( GameControl.mcSex == GameControl.MCSex.Woman || GameControl.mcSex == GameControl.MCSex.Cuntboy) {
			Board.text += "You approach her as you remove your " + clothes + " and wear your strap-on, grabbing both of her asscheeks after that. -Ravage me...- She said in a lowly tonem wiggling a bit her ass as you touch her ass and expose her little back hole. You press the strap around her asshole, which makes her shiver a bit. -You found the rabbit hole...- She says almost moaning, probably from the sensation of your dildo against her hole. You held her in place with your  arms pushing her body against the ground, as your " + breasts + " chest is pressing against her rear as you tease her entrance several times.\n\n\nYou can see how she scratches the ground below her, as your dildo pushes across her ringhole, enjoying her moanings and twitching as you invade her insides. You can see that she wasn’t tense yet she trembles from your strong entrance in her, after all she is still a petite woman. You didn’t wait more than a second to starting ramming her, the little bunny’s hole was nice and tight for you to use.\n\n\nYou can hear her moans of pleasure as you slam your strap inside her pucker, your own sexual fluids sliding through your thighs, while the little Lost moans like a common whore, pinching her own small breasts as you ram her against the ground unceasingly. The struggle to fuck her with the dildo against her rectum is all you need to enjoy the act, the feeling of domination over your enemy was just a plus for the moment. Your penetrations continue as each one of them are being followed by a moan of lust from your fluffy recipient of lust.\n\n\nWhen you feel that your strap is almost entirely inside her, you lift her torso and place it against your " + breasts + " chest, as she twitches and moans closer to your ears. -Bounce me!- As you hold her small body and start lifting her up and down over the dildo. Finally, you feel your orgasm coming closer to you, so you held her in place over it and don’t waste any more time, as you get to cum with force, feeling how she clamps her small hands around your waist, as you moaning and thrashing is evident to her. You can see her pucker tightening around the strap, probably from her own orgasm.\n\n\nAfter you feel that you have no more to give, you let her go. The bunny limps slowly until she hits the ground, trying to catch her breath. You can see how her asshole is twitching from all the stimulation. Her face is one of pure bliss, she didn’t look able to articulate a word that is not a moan. You feel satisfied, and so did she, so you take your clothing and return to your city, leaving the lost bunny behind.\n";
		} else if (GameControl.mcSex == GameControl.MCSex.Man    && GameControl.charArmorTags[11] == false) {

			Board.text += "You approach her as you remove your " + clothes + ", exposing your " + dickSize + " cock and get to grab both of her asscheeks. -Ravage me...- She said in a lowly tonem wiggling a bit her ass as you touch her ass and expose her little back hole. You press your dick around her asshole, which makes her shiver a bit. -You found the rabbit hole...- She says almost moaning, probably from the sensation of your dick against her hole. You held her in place with your arms pushing her body against the ground, as your " + breasts + " chest is pressing against her rear as you tease her entrance several times.\n\n\nYou can see how she scratches the ground below her, as your rod pushes across her ringhole, enjoying her tightness as you invade her insides. You can see that she wasn’t tensing yet she trembles from your strong entrance in her, after all she is still a petite woman. You didn’t wait more than a second to starting ramming her. The friction of her insides around your cock was amazing, the little bunny’s hole was nice and tight for you to use.\n\n\nYou can hear her moans of pleasure as you slam your cock inside her pucker, your own precum working as a lubricant, as the little Lost moans like a common whore, as she is pinching her own small breasts as you ram her against the ground unceasingly. The friction of your cock against her rectum and the warm of her insides are all you need to enjoy the act, the feeling of domination over your enemy was just a plus for the moment. Your penetrations continue as each one of them are being followed by a moan of lust from your fluffy recipient of cock-flesh, your " + ballsSize + " balls smacking her ass with each thrust..\n\n\nWhen you feel that your cock is sufficiently inside of her, you lift her torso and place it against your " + breasts + " chest, as she twitches and moans closer to your ears. -Bounce me!- As you hold her small body and start lifting her up and down over your shaft. Finally, you feel your orgasm coming closer to you, so you held her in place over your cock and don’t waste any more time, cumming inside her ass with force, as you feel how she clamps her small hands around your legs, as your cum starts filling her insides more and more. Your cock continues twitching as it unloads its cum inside her peckish asshole. You can feel her pucker tightening around your cock, pushing you ever more over the edge.\n\n\nAfter you feel that you have no more to give, you let her go. The bunny limps slowly until she hits the ground, trying to catch her breath. You can see how her insides are unable to hold all your cum and trickle down her ass and into the ground below both of you. Her face is one of pure bliss, she didn’t look able to articulate a word that is not a moan. You feel satisfied, and so did she, so you take your clothing and return to your city, leaving the lost bunny behind.\n";
			charVirginity ();
		} else if (GameControl.mcSex == GameControl.MCSex.Man    && GameControl.charArmorTags[11] == true) {
			Board.text = "You approach her as you remove your clothes and take your dildo from your clothes, grabbing both of her asscheeks after that. [i]“Ravage me…,”[/i] she said in a lowly tone, wiggling her ass as you touch it and expose her little back hole. You press the sex toy around her asshole with your hand, which makes her shiver a bit. [i]“You found the rabbit hole,”[/i] she says almost moaning, probably from the sensation of your dildo against her hole. You held her in place with your arm pushing her body against the ground, as your [BREASTS] chest is pressing against her rear while you tease her entrance several times.\n\nYou can see how she scratches the ground below her, as your dildo pushes across her ringhole, enjoying her moanings and twitching as you invade her insides. You can see that she wasn’t tense yet she trembles from your strong entrance in her, after all she is still a petite woman. You didn’t wait more than a second to starting ramming her with your sex toy, the little bunny’s hole is nice and tight for you to use.\n\nYou can hear her moans of pleasure as you slam your dildo inside her pucker, your own sexual fluids sliding off the tip of your cock, while the little Lost moans like a common whore, pinching her own small breasts as you ram her against the ground unceasingly. The struggle to fuck her with the dildo against her rectum is all you need to enjoy the act, the feeling of domination over your enemy was just a plus for the moment. Your sex toy invasions continue as each one of them are being followed by a moan of lust from your fluffy recipient of lust.\n\nWhen you feel that your strap is almost entirely inside her, you lift her back and place it against your [BREASTS] chest, as she twitches and moans closer to your ears. [i]“Bounce me!,”[/i] as you hold her small body with one arm and start using her as leverage to fuck her with your dildo. Finally, you feel your orgasm coming closer to you, so you held her in place over it and don’t waste any more time, as you get to cum with force, your cock spurting your thick seed into the bunny’s buttocks as she clamps her small hands around your waist, as your moaning and thrashing is evident to her. You can see her pucker tightening around the strap, probably from her own orgasm.\n\nAfter you feel that you have no more to give, you let her go. The bunny limps slowly until she hits the ground, trying to catch her breath. You can see how her asshole is twitching from all the stimulation. Her face is one of pure bliss, she didn’t look able to articulate a word that is not a moan. You feel satisfied, and so did she, so you take your clothing and return to your city, leaving the lost bunny behind.";
		}

	}

	public void Scene3(){
		GameControl.actualArousal = 0; 
		Board.text = "You can see that your bunny opponent falls into the ground, extremely aroused. She rubs her pussy with desperation with one hand, and with the other the tries to reach you in vain. -Too hot… Must fuck...- You can see a lot of femjuice trickling down her legs. She is almost gushing!. You can’t help but feel aroused for the bunny that has been reduced to nothing more than a whore. And with that, you decide to take care of the situation.\n";
		if ( GameControl.mcSex == GameControl.MCSex.Woman || GameControl.mcSex == GameControl.MCSex.Cuntboy) {
			Board.text += "You quickly undress your " + clothes + ", exposing your " + race + " pussy while you wear your strap on. The eyes of the bunny over your naughty parts is incredible, her eyes were overflowing with carnal desire. At the moment that you get to reach of her bunny, she uses her bunny legs to leap into you like a hunter to its prey, but she is unable to knock you down, instead holding onto you and looking you with frenzied eyes. She starts by licking your neck, as her hands try her best to grope your  body. -Fuck me! Come on... - She says in a needy voice, her cunt is dripping all over your belly, rubbing against you in an attempt to sate the lust that is driving her mad.\n\n\nYou pin her against a tree nearby, pushing your hard dildo against her hungry twat, as she was already moaning and screaming in ecstasy. You didn’t have any difficulty penetrating her, the love juices flowing all over your strap-on, her insides fitting you as a scabbard, her inner walls trying to make it cum, even though its fake. -Yes! Fuck me! It feels so good. Don’t stop- She yells. You get to fuck her like there is no tomorrow, your hips crashing against her cunt incessantly, your nipples rubbing against her own, as you relish on her whole body, making her bunny legs bounce with each thrust inside her, along with her back against the tree that was holding her in place.\n\n\nAfter a bit, you can feel that you are at the brink of orgasming, her wildly desirous attitude are too much to last, so you increase your thrusting. You feel how she lets out an ecstatic moan as she cums all over the dildo you were using. You couldn’t last longer, cumming all over yourself, soaking your thighs and legs as you keep fucking her, filling the place with the scent of sex. After a bit, you can feel the fluids of both of you spilling into the ground.\n\n\nAfter you finally stop orgasming, you let her go slowly, so she slips into the puddle of sexual fluids that both of you made, her face was a complete mess. She only could mumble something: -More… more...- As she kept her legs spread, as if waiting for more of your caress. You decide that it’s good for the moment, and let that bunny to her insatiable appetites. \n";
		} else if (GameControl.mcSex == GameControl.MCSex.Man   && GameControl.charArmorTags[11] == false) {
			Board.text += "You quickly undress your " + clothes + ", exposing your "  +  dickSize + " dick and "  +  ballsSize + " balls. The eyes of the bunny over your naughty parts is incredible, her eyes were overflowing with carnal desire. At the moment that you get to reach of her bunny, she uses her bunny legs to leap into you like a hunter to its prey, but she is unable to knock you down, instead holding onto you and looking you with frenzied eyes. She starts by licking your neck, as her hands try her best to grope your  body. -Fuck me! Come on... - She says in a needy voice, her cunt is dripping all over your belly, rubbing against you in an attempt to sate the lust that is driving her mad.\n\n\nYou pin her against a tree nearby, pushing your "  +  dickSize + " wang against her hungry twat, as she was already moaning and screaming in ecstasy. You didn’t have any difficulty penetrating her, the love juices flowing all over your cock, her insides fitting you as a scabbard, her inner walls massaging your prick as if they are trying to make you cum already. -Yes! Fuck me! It feels so good. Don’t stop- She yells. You get to fuck her like there is no tomorrow, your hips crashing against her ass incessantly, your nipples rubbing against her own, as you relish on her whole body, making her bunny legs bounce with each thrust inside her, along with her back against the tree that was holding her in place.\n\n\nAfter a bit, you can feel that you are at the brink of orgasming, her tight cunt around your cock and her wildly desirous attitude are too much to last, so you increase your thrusting. ou feel how she lets out an ecstatic moan as she cums all over your cock. Her cunt begins to massage your cock, trying to milk it for all its worth. You couldn’t last longer, cumming all over her pussy, releasing your sperm inside her nether lips as you keep fucking her. After a bit, you can feel the fluids of both of you spilling into the ground, now from a white coloration from your load.\n\n\nAfter you finally stop orgasming, you let her go slowly, so she slips into the puddle of sexual fluids that both of you made, her face was a complete mess. She only could mumble something: -More… more...- As she kept her legs spread, as if waiting for more of your dick. You decide that it's good for the moment, and let that bunny to her insatiable appetites. \n";
			charVirginity ();

		} else if (GameControl.mcSex == GameControl.MCSex.Man    && GameControl.charArmorTags[11] == true) {
			Board.text += "You quickly undress your clothes, exposing your pussy while you wear your strap on. The eyes of the bunny over your naughty parts is incredible, her eyes were overflowing with carnal desire. At the moment that you get to reach of her bunny, she uses her bunny legs to leap into you like a hunter to its prey, but she is unable to knock you down, instead holding onto you and looking you with frenzied eyes. She starts by licking your neck, as her hands try her best to grope your body. -Fuck me! Come on... - She says in a needy voice, her cunt is dripping all over your belly, rubbing against you in an attempt to sate the lust that is driving her mad.\n\nYou pin her against a tree nearby, pushing your hard dildo against her hungry twat, as she was already moaning and screaming in ecstasy. You didn’t have any difficulty penetrating her with the sex toy, the love juices flowing all over your strap-on, her insides fitting you as a scabbard, her inner walls trying to make it cum, even though its fake. -Yes! Fuck me! It feels so good. Don’t stop- She yells. You get to fuck her like there is no tomorrow, your hips crashing against her cunt incessantly, your nipples rubbing against her own, as you relish on her whole body, making her bunny legs bounce with each thrust inside her, along with her back against the tree that was holding her in place.\n\nAfter a bit, you can feel that you are at the brink of orgasming, her wildly desirous attitude are too much to last, so you increase your thrusting. You feel how she lets out an ecstatic moan as she cums all over the dildo you were using. You couldn’t last longer, cumming all over yourself, soaking your thighs and legs as you keep fucking her, filling the place with the scent of sex. After a bit, you can feel the fluids of both of you spilling into the ground.\n\nAfter you finally stop orgasming, you let her go slowly, so she slips into the puddle of sexual fluids that both of you made, her face was a complete mess. She only could mumble something: -More… more...- As she kept her legs spread, as if waiting for more of your caress. You decide that it’s good for the moment, and let that bunny to her insatiable appetites. ";
		}

	}




	void Start (){
		CityControl.city100Slaves[0] += 1;


	}




	void charVirginity(){

		if(GameControl.isVirgin == true){
			Board.text += "\n\nYour character lost its virginity!";
			GameControl.isVirgin = false; 
		}

	}






}
