using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class SceneFlower : MonoBehaviour {

	int randNum;

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

	string line1;




	// this is used to SETTLE the scene, add a simple script that changes the global ID and this will do the rest
	void Awake () {
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

		buttScene2.enabled = !buttScene2.enabled;
		if (WorldControl.enemyLust >= 50) {
			buttScene2.enabled = !buttScene2.enabled;
		}
		buttScene3.enabled = !buttScene3.enabled;
		if (WorldControl.enemyLust >= WorldControl.enemyMaxLust) {
			buttScene3.enabled = !buttScene3.enabled;
		}

	}


	public void Scene1(){
		GameControl.actualArousal = 0; 
		Board.text = "You see how the plant walks back and falls into the floor, as she looks completely defeated. The sweet scent of her pussy was all over the floor below her. Her bountiful breasts are bouncing slowly with her panting, as her tentacles begin to lay down around her, exhausted. Those tentacles, you remember how she has been trying to fuck you with those tentacles, perhaps is time for her to know how it feels to be on the other side of the combat.";
		if ( GameControl.mcSex == GameControl.MCSex.Woman || GameControl.mcSex == GameControl.MCSex.Cuntboy) {
			if (GameControl.hasVagina == true) {
				line1 = "your cunt flooding with femjuice, soaking your thighs wet.";
			} else {
				line1 = "";
			}
			Board.text += "You undress your " + clothes + " as you don’t want them to be stained with the sweet-scented fluids of your plant-enemy. You decide to wear your reliable strap-on on this occasion. You walk close to her, as she looks at you expectantly, while you pick up one tentacle from the floor around her. It is quite soft, but firm and sinewy at the end. It doesn’t fight back, but definitely reacts to your touch in the same way as the plant lady in front of you. -What are you planning to do with that, hun?- She says, trying to sound seductive but you feel a tint of nervousness in her tone.\n\nYou go close to her and kneel in front of her, tentacle in hand. You smile to her as you start rubbing the tip of the tentacle in her pussy, which is a bit hidden below her green and long cock. You can hear her moan and twitch slowly, as the tentacle starts to wet her own snatch with that sap of hers. The moans of your enemy get to excite you, getting you harder and harder. -Come on… I want you inside me… Or me inside you. Why do you torture me like this?- After a pair of seconds, you insert the tentacle inside her pussy and start thrusting it inside her. \n\nYou can see how she begins to moan harder and harder, even playing with her own enormous breasts, toying with her own nipples. You align your cock with her asshole, your excitement got the best of you as you plunge it with your strap-on, surprising her with your action. -That’s… Yes! Great idea!- She yells as your dildo pass her sphincter and press on. You can feel the tentacle squirming in your hand as it helps you to fuck her with it. You keep using it like some natural dildo with her, her pussy stretching with every thrust of it.\n\nHer ass is quite soft as you can feel it every time with your hips, as you thrust against her back door, while she moans truly like an ecstatic slut as you fuck her both of her holes. She ran her hands across her body and yours, but it seems to be only increasing her pleasure instead of sate it. -This way of breeding… Amazing.- She says between moans just before you see her cum. Her whole body contracts as you see her cock tremble as streams of sap start to be poured from her own cock to cover her whole body at the same time that her asshole gets to tighten around your cock. You can’t hold much more as you get to cum too. " + line1 + " You can feel her greedy cunt being filled with the tentacle’s cream. The plant lady’s face was of pure ecstasy, her hard nipples leaking a sugary liquid that soaked her own pair of breasts, giving her a glistening gloss.\n\nWhen your orgasm finally stopped, you see that the tentacle went limp, just as the plant lady’s body. She looks like she’s too exhausted to move, or to do anything else. You pull out your strap from her ass, as you see her still touching her body quite slowly, as a reminiscent of her lust. You get your clothes from the floor, but decide to dress in the city, as your body is stained with that syrupy thing. You leave the place, as the plant is left moaning in the floor of the forest.\n";


		} else if (GameControl.mcSex == GameControl.MCSex.Man   && GameControl.charArmorTags [11] == false) {
			if (GameControl.testiclesSize > 0) {
				line1 = ballsSize + " balls";
			} else {
				line1 = "dick";
			}
			Board.text += "You undress your " + clothes + " as you don’t want them to be stained with the sweet-scented fluids of your plant-enemy. You stroke your " + dickSize + " penis a bit, just by looking at the splendid piece of lady you have yourself in front of you. You walk close to her, as she looks at you expectantly, while you pick up one tentacle from the floor around her. It is quite soft, but firm and sinewy at the end. It doesn’t fight back, but definitely reacts to your touch in the same way as the plant lady in front of you. -What are you planning to do with that, hun?- She says, trying to sound seductive but you feel a tint of nervousness in her tone.\n\nYou go close to her and kneel in front of her, tentacle in hand. You smile to her as you start rubbing the tip of the tentacle in her pussy, which is a bit hidden below her green and long cock. You can hear her moan and twitch slowly, as the tentacle starts to wet her own snatch with that sap of hers. The moans of your enemy get to excite you, getting you harder and harder. -Come on… I want you inside me… Or me inside you. Why do you torture me like this?- After a pair of seconds, you insert the tentacle inside her pussy and start thrusting inside her with it. \n\nYou can see how she begins to moan harder and harder, even playing with her own enormous breasts, toying with her own nipples. You align your cock with her asshole, your excitement got the best of you as you plunge it with your " + dickSize + " cock, surprising her with your action. -That’s… Yes! Great idea!- She yells as your prick cross her sphincter and press on, as her tightness around your cock is quite delightful. You can feel the tentacle squirming in your hand as it helps you to fuck her with it. You keep using it like some natural dildo with her, her pussy stretching with every thrust of it.\n\nHer ass is quite soft as you can feel it every time with your " + line1 + ", as you thrust against her back door, while she moans truly like an ecstatic slut as you fuck her both of her holes. She ran her hands across her body and yours, but it seems to be only increasing her pleasure instead of sate it. -This way of breeding… Amazing.- She says between moans just before you see her cum. Her whole body contracts as you see her cock tremble as streams of sap start to be poured from her own cock to cover her whole body at the same time that her asshole gets to tighten around your cock. You can’t hold much more as you get to cum too, your shaft flooding her clamped pucker with a big load of cum. You can feel her insides being filled with your cream as her own tentacle seems to be doing the same to her greedy cunt. The plant lady’s face was of pure ecstasy, her hard nipples leaking a sugary liquid that soaked her own pair of breasts, giving her a glistening gloss.\n\nWhen your orgasm finally stopped, you see that the tentacle went limp, just as the plant lady’s body. She looks like she’s too exhausted to move, or to do anything else. You pull out your cock from her ass, as you see her still touching her body quite slowly, as a reminiscent of her lust. You get your clothes from the floor, but decide to dress in the city, as your body is stained with that syrupy thing. You leave the place, as the plant is left moaning in the floor of the forest.\n";
			charVirginity ();
		} else if (GameControl.mcSex == GameControl.MCSex.Man   && GameControl.charArmorTags [11] == true) {
			Board.text += "You undress your clothes as you don’t want them to be stained with the sweet-scented fluids of your plant-enemy. You decide to take your big dildo on this occasion. You walk close to her, as she looks at you expectantly, while you pick up one tentacle from the floor around her. It is quite soft, but firm and sinewy at the end. It doesn’t fight back, but definitely reacts to your touch in the same way as the plant lady in front of you. <i>“What are you planning to do with that, hun?</i> She says, trying to sound seductive but you feel a tint of nervousness in her tone.\n\nYou go close to her and kneel in front of her, tentacle in hand. You smile to her as you start rubbing the tip of the tentacle in her pussy, which is a bit hidden below her green and long cock. You can hear her moan and twitch slowly, as the tentacle starts to wet her own snatch with that sap of hers. The moans of your enemy get to excite you, getting you harder and harder. <i>“Come on… I want you inside me… Or me inside you. Why do you torture me like this?”</i> After a pair of seconds, you insert the tentacle inside her pussy and start thrusting it inside her. \n\nYou can see how she begins to moan harder and harder, even playing with her own enormous breasts, toying with her own nipples. You align your sex toy with her asshole, your excitement got the best of you as you plunge it with your dildo, surprising her with your action. <i>“That’s… Yes! Great idea!”</i> She yells as your dildo pass her sphincter and press on. You can feel the tentacle squirming in your hand as it helps you to fuck her with it. You keep using it like some natural dildo with her, her pussy stretching with every thrust of it.\n\nHer ass is quite soft as you can feel it every time with your other hand, as you use it to thrust your sex toy against her back door, while she moans truly like an ecstatic slut as you fuck both of her holes. She ran her hands across her body and yours, but it seems to be only increasing her pleasure instead of sate it. <i>“This way of breeding… Amazing.”</i> She says between moans just before you see her cum. Her whole body contracts as you see her cock tremble as streams of sap start to be poured from her own cock to cover her whole body at the same time that her asshole gets to tighten around your cock. You can’t hold much more as you get to cum too, your cock throbbing as your orgasm sends your cum flying into one of her buttocks, smearing it with your spunk. You can feel her greedy cunt being filled with the tentacle’s cream. The plant lady’s face was of pure ecstasy, her hard nipples leaking a sugary liquid that soaked her own pair of breasts, giving her a glistening gloss.\n\nWhen your orgasm finally stopped, you see that the tentacle went limp, just as the plant lady’s body. She looks like she’s too exhausted to move, or to do anything else. You pull out your dildo from her ass, as you see her still touching her body quite slowly, as a reminiscent of her lust. You get your clothes from the floor, but decide to dress in the city, as your body is stained with t";
		}

	}


	public void Scene2(){
		GameControl.actualArousal = 0; 
		Board.text = "You defeat your opponent with a combination of force and seduction. You see how your enemy falls into her jiggly ass, her nipples erect and that sappy scent filling slowly the air around you. You can see that she tries to stand up, but she is unable to do so. You can see her two giant orbs standing softly in her chest, as if they were waiting to be groped. Now as you won the fight, it was time to claim your prize.";
		if ( GameControl.mcSex == GameControl.MCSex.Woman || GameControl.mcSex == GameControl.MCSex.Cuntboy) {
			Board.text += "You remove your " +  clothes + " slowly, as you had a good amount of time, because you can see that she is helpless. You place your reliable strap-on just where you require it to be right now: In your groin. Using your hand to get a good feel of her twat, you perceive that she is already is dripping with lubrication. She squirms and groans at your caressing. -Fecundate me...- She almost whispers as you touch her. Perhaps that’s the only thing she wants: To breed or be breeded. Well, you can surely help her with one of those, at least in what the act refers. You align your strap-on with her green cunt, perceiving how is being soaked in her sex fluids. You see that she is definitely ready, so you thrust your dildo inside her needy snatch.\n\nSuddenly, all of her tentacles start to squirm and twist just at the same time as she does. You now are in front of those huge breasts of her, as you hear her panting with your fucking. You don’t lose your opportunity and tease them with your mouth and "+ race + " hands. As you press her nipples with your lips, you can feel a surge of a sweet liquid flowing through your face. You can hear her moans increase every time you have a taste of that sugary liquid that pours out of her pillowy breasts. They feel so soft to the touch, as you lick them and ran your hands all around them. -Please, have a taste! They are so full...- You don’t waste any more time as you caress both of her amazing breasts and feel rewarded with a thick and tasty liquid from them. Your cock twitches with excitement inside her pussy, as you massage them with your hands and mouth. -Yeah, just like that, hun.-\n\nAs your fucking of the plant lady continued, you hear how she cries a moan of pleasure that fills the place, as she gets to finally cum all over your strap-on. You see how her breasts gets to soak your hands with that thick liquid as she orgasms, the plants over her head open themselves a bit more as she yells and thrashes a bit for the pleasure.\n\nYour orgasm is strong, your femjuice start to flow from your own pussy, slowly soaking your thighs then dripping into the ground below you. You lay your head over her cushion-like tits until you can’t cum anymore. After that, you see that the plant lady is completely exhausted and completely silent, a look of satisfaction filling her face.\n\nYou lift yourself from the ground, completely drenched in her sap. So, you take your " +  clothes + " and put them in your bag, as you return to the city, going to the rivulet that is close by first to clean yourself a bit, before longing for a bath in your Manor.\n";


		} else if (GameControl.mcSex == GameControl.MCSex.Man   && GameControl.charArmorTags [11] == false){
			Board.text += "You remove your " +  clothes + " slowly, as you had a good amount of time, because you can see that she is helpless. Using your hand to get a good feel of her twat, you perceive that she is already is dripping with lubrication. She squirms and groans at your caressing. -Fecundate me...- She almost whispers as you touch her. Perhaps that’s the only thing she wants: To breed or be breeded. Well, you can surely help her with one of those. You align your " +  dickSize + " "+ dick + " dick with her green cunt, feeling how is being soaked in her sex fluids. You see that she is definitely ready, so you thrust your cock inside her needy snatch.\n\nSuddenly, all of her tentacles start to squirm and twist just at the same time as she does. You now are in front of those huge breasts of her, as you hear her panting with your fucking. You don’t lose your opportunity and tease them with your mouth and "+ race + " hands. As you press her nipples with your lips, you can feel a surge of a sweet liquid flowing through your face. You can hear her moans increase every time you have a taste of that sugary liquid that pours out of her pillowy breasts. They feel so soft to the touch, as you lick them and ran your hands all around them. -Please, have a taste! They are so full...- You don’t waste anymore time as you caress both of her amazing breasts and feel rewarded with a thick and tasty liquid from them. Your cock twitches with excitement inside her pussy, as you massage them with your hands and mouth. -Yeah, just like that, hun.-\n\nAs your fucking of the plant lady continued, you hear how she cries a moan of pleasure that fills the place, as she gets to finally cum all over your cock. You see how her breasts gets to soak your hands with that thick liquid as she orgasms, the plants over her head open themselves a bit more as she yells and thrashes a bit for the pleasure. Your cock feels like is being massaged by her skilled snatch until you finally gave her what she wanted.\n\nYour orgasm is strong, your thick cream begins to be poured inside the plant’s teasing pussy. Her inner walls rub against your pulsing dick, as it unloads your balls of spunk until they make sure that there is nothing more in there. You lay your head over her cushion-like tits until you can’t cum anymore. After that, you see that the plant lady is completely exhausted and completely silent, a look of satisfaction filling her face.\n\nYou lift yourself from the ground, completely drenched in her sap. So, you take your " +  clothes + " and put them in your bag, as you return to the city, going to the rivulet that is close by first to clean yourself a bit, before longing for a bath in your Manor.\n";
			charVirginity ();
		} else if (GameControl.mcSex == GameControl.MCSex.Man   && GameControl.charArmorTags [11] == true) {
			Board.text = "You remove your clothes slowly, as you had a good amount of time to do it, because you can see that she is helpless, exposing your "+ dickSize +" cock. You take your dildo and place it in your hand, ready for anything. Using your other hand to get a good feel of her twat, you perceive that she is already dripping with lubrication. She squirms and groans at your caressing. <i>“Fecundate me…”</i> She almost whispers as you touch her. Perhaps that’s the only thing she wants: To breed or be breeded. Well, you can surely help her with one of those, at least in what the act refers. You align your sex toy with her green cunt, perceiving how is being soaked in her sex fluids. You see that she is definitely ready, so you thrust your dildo inside her needy snatch, using your hand.\n\nSuddenly, all of her tentacles start to squirm and twist just at the same time as she does. You now are in front of those huge breasts of her, as you hear her panting with your dildo toying with her insides. You don’t lose your opportunity and tease them with your mouth and free hand. As you press her nipples with your lips, you can feel a surge of a sweet liquid flowing through your face. You can hear her moans increase every time you have a taste of that sugary liquid that pours out of her pillowy breasts. They feel so soft to the touch, as you lick them and ran your hands all around them. <i>“Please, have a taste! They are so full…”</i> You don’t waste any more time as you caress both of her amazing breasts and feel rewarded with a thick and tasty liquid from them. Yourdildo slides easier than before, as you massage them with your hands and mouth. <i>“Yeah, just like that, hun.”</i>\n\nAs your fucking of the plant lady continued, you hear how she cries a moan of pleasure that fills the place, as she gets to finally cum all over your strap-on. You see how her breasts gets to soak your hands with that thick liquid as she orgasms, the plants over her head open themselves a bit more as she yells and thrashes a bit for the pleasure.\n\nYour orgasm is strong, your cum begin to spurt from your cock, staining the plant’s back and sliding into her ample ass. You lay your head over her cushion-like tits until you can’t cum anymore. After that, you see that the plant lady is exhausted and completely silent, a look of satisfaction filling her face.\n\nYou lift yourself from the ground, completely drenched in her sap. So, you take your clothings and put them in your bag, as you return to the city, going to the rivulet that is close by first to clean yourself a bit, before longing for a bath in your Manor.";
		}

	}

	public void Scene3(){
		GameControl.actualArousal = 0; 
		Board.text = "You see how your opponent falls into her knees panting. One of her hands is rubbing her soaked pussy as the other plays with one of her breasts, pinching her nipple with frustration. She has her tongue out as its tentacles squirms in the floor below her. she looks in a complete lust-driven craze. -Too hot...- As she continues trying to calm her urges in vain. You smile in satisfaction of your work, as you have a plan in mind in this situation.";
		if ( GameControl.mcSex == GameControl.MCSex.Woman || GameControl.mcSex == GameControl.MCSex.Cuntboy) {
			Board.text += "You undress your " +  clothes + " alongside with your stuff and place them under a tree nearby. But before you leave them in there, you take your reliable strap-on and wear it. You place yourself behind her and tease her pussy with your strap-on dildo, she wiggles her ass as she tries to tease you to fuck her already. You smack one of her asscheeks only making her pant harder. You take one of her tentacles and tease its own entrance on her ass. -Fill all my holes… I don’t care how… Please, just do it- She moans with desire and frustration as you push her tentacle inside her pucker, making her shiver in delight. You pushed it as it tries to escape, until it stops trying to and follows the thrusting without your intervention.\n\nYou take a second tentacle and place it slowly between her ample breasts, forcing it to rub itself between them continually, which after a pair of rubbing, complies with your plan. You continue to do that with all the tentacles you could reach. When you see that she is covered in her own tentacles, all of them rubbing themselves over her tender skin, ample tits and round ass, you finally plunge your strap-on dildo inside her. She is caught in a tentacle cage of pleasure, almost every bit of her is being rubbed or humped by a tentacle.\n\nAfter that, her pussy is drenched in sexual fluids, making it more enjoyable for you as her inner walls tremble with pleasure as they try to wrap themselves around your cock, their heat and slipperiness filling you with pleasure. She rubs her own body as you grab the last tentacle and shove it down her throat as if were a cock, forcing her to suck it until she does it on her own. When you do it, you feel how she cums hard, her whole body shakes with delight. The tentacles start to pour all over her body, a heavily amount of sexual fluids, covering her whole body in plant jizz. The sight of her being covered in those fluids sends you over the edge, making you cum on your own ,your own snatch twitching as a load of femspunk starts to slide off your inner lips.\n\nWhen you finally stop juicing yourself, you pull out your strap-on off her but see that the tentacles are not stopping yet. They keep rubbing her and fucking her as she has this look of pure bliss on her face. Perhaps she hasn’t had enough. You go and get your clothing, leaving the plant to play with her own toys a little more.";


		} else if (GameControl.mcSex == GameControl.MCSex.Man   && GameControl.charArmorTags [11] == false){
			Board.text += "You undress your " +  clothes + " alongside with your stuff and place them under a tree nearby. You place yourself behind her and tease her pussy with your " +  dickSize + " spar, she wiggles her ass as she tries to tease you to fuck her already. You smack one of her asscheeks only making her pant harder. You take one of her tentacles and tease its own entrance on her ass. -Fill all my holes… I don’t care how… Please, just do it- She moans with desire and frustration as you push her tentacle inside her pucker, making her shiver in delight. You pushed it as it tries to escape, until it stops trying and follows the thrusting without your intervention.\n\nYou take a second tentacle and place it slowly between her ample breasts, forcing it to rub itself between them continually, which after a pair of rubbing, complies with your plan. You continue to do that with all the tentacles you could reach. When you see that she is covered in her own tentacles, all of them rubbing themselves over her tender skin, ample tits and round ass, you finally plunge your " +  dickSize + " " + dick +" cock inside her. She is caught in a tentacle cage of pleasure, almost every bit of her is being rubbed or humped by a tentacle.\n\nAfter that, her pussy is drenched in sexual fluids, making it more enjoyable for you as her inner walls tremble with pleasure as they try to wrap themselves around your cock, their heat and slipperiness filling you with pleasure. She rubs her own body as you grab the last tentacle and shove it down her throat as if were your own cock, forcing her to suck it until she does it on her own. When you do it, you feel how she cums hard, her whole body shakes with delight as her cunt clamp hard around your cock, her insides trying to milk your balls until the last drop of them. The tentacles start to pour all over her body, a heavily amount of sexual fluids, covering her whole body in plant jizz.\n\nWhen you finally stop filling her with your spunk, you pull out your penis off her but see that the tentacles are not stopping yet. They keep rubbing her and fucking her as she has this look of pure bliss on her face. Perhaps she hasn’t had enough. You go and get your clothing, leaving the plant to play with her own toys a little more.\n";
			charVirginity ();
		} else if (GameControl.mcSex == GameControl.MCSex.Man   && GameControl.charArmorTags [11] == true) {
			Board.text += "You undress your clothes alongside with your stuff and place them under a tree nearby, displaying your "+ dickSize +" shaft. But before you leave them in there, you take your big-ass dildo and leave it in your hand. You place yourself behind her and tease her pussy with it, she wiggles her ass as she tries to tease you to fuck her already. You smack one of her asscheeks, only making her pant harder. You take one of her tentacles and tease its own entrance on her ass. <i>“Fill all my holes… I don’t care how… Please, just do it,”</i> she moans with desire and frustration as you push her tentacle inside her pucker, making her shiver in delight. You pushed it as it tries to escape, until it stops trying to and follows the thrusting without your intervention.\n\nYou take a second tentacle and place it slowly between her ample breasts, forcing it to rub itself between them continually, which after a pair of rubbing, complies with your plan. You continue to do that with all the tentacles you could reach. When you see that she is covered in her own tentacles, all of them rubbing themselves over her tender skin, ample tits and round ass, you finally plunge your dildo inside her. She is caught in a tentacle cage of pleasure, almost every bit of her is being rubbed or humped by a tentacle.\n\nAfter that, her pussy is drenched in sexual fluids, making it more enjoyable for you as her moans of pleasure fill the air as her cunt tries to wrap itself around your dildo, the heat and scent that emanates from it filling you with pleasure. She rubs her own body as you grab the last tentacle and shove it down her throat as if were a cock, forcing her to suck it until she does it on her own. When you do it, you feel how she cums hard, her whole body shakes with delight. The tentacles start to pour all over her body, a heavily amount of sexual fluids, covering her whole body in plant jizz. The sight of her being covered in those fluids sends you over the edge, making you cum on your own, your own cock pulsating as load after load of spunk flies and mixed with the sap of the plant girl over her body.\n\nWhen you finally stop cumming, you pull out your dildo off her but see that the tentacles are not stopping yet. They keep rubbing her and fucking her as she has this look of pure bliss on her face. Perhaps she hasn’t had enough. You go and get your clothing, leaving the plant to play with her own toys a little more.";
		}

	}




	void Start (){

		CityControl.city100Slaves[2] += 1;

	}





	//////////////////////////////////////////////////////////////////////
	void mcPregnancy()
	{
		if (GameControl.fertile == true && GameControl.isPregnant == false) {
			Random.InitState(System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 100);

			if (GameControl.fertileVery == true) {
				if (randNum > 70) {
					GameControl.pregnantCounter = 10; 
					GameControl.isPregnant = true; 
					GameControl.pregnantText = ""; 

				}
			} else {
				if (randNum > 85) {
					GameControl.pregnantCounter = 10; 
					GameControl.isPregnant = true; 
					GameControl.pregnantText = ""; 

				}

			}


		} 

	}
	//////////////////////////////////////////////////////////////////////////






	void charVirginity(){

		if(GameControl.isVirgin == true){
			Board.text += "\n\nYour character lost its virginity!";
			GameControl.isVirgin = false; 
		}

	}




}
