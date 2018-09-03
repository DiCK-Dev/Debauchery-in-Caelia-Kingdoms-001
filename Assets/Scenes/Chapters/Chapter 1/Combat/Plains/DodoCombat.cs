using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class DodoCombat : MonoBehaviour {



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

		WorldControl.enemyID = 140; 
		WorldControl.furryPic = true; 
		WorldControl.futaPic = false; 

		WorldControl.enemyHP = 85;
		WorldControl.enemyLust = 25;
		WorldControl.enemyMaxHP =85;
		WorldControl.enemyMaxLust = 100; 

		WorldControl.enemyCombDefense = 0.27f; // dmg reduction %
		WorldControl.enemyLustDefense = 0.27f; // dmg reduction %



		// appears in the UI

		WorldControl.eneName = "Horny dodo girl";
		WorldControl.eneRace = "Dodo";

		WorldControl.eneComType = "Lustful"; 
		WorldControl.eneLustType = "Touchy"; 

		WorldControl.eneDescription = "As you are wandering across the plains, you hear a flapping of sorts close you. As you search the origin of the sound, you found out that it is someone at the base of one of the smallest bushes that appears from time to time in that location. You barely can discern someone that is trying to flap what appeared to be wings. As you approach, you can see that it is a small female making all the ruckus. As you approach, you caught her attention, as she turns around and stands up completely. <i>”I need someone! Anyone! You’ll work just fine!,”</i> she says, before flapping her wings and moving against you."; 
		if (WorldControl.furryOn == true) {
			WorldControl.eneDescription += "\n\nAfter she moves out of the bushes, you could get her body details. It is a female that resembles a bird of sorts, her whole body covered in a colorful spray of colors, as if to attract males. She has a pair of human legs that end in a pair of big bird feet. Her hands are almost human but it has a pair of long colorful bird wings born from her arms, that end in her chest. Her head is a hybrid between a woman and a bird, completed with a beak but having human hair as colorful as her feathers. She sports a bird tail standing between a pair of plump and soft buttcheeks. She has a pair of C-Breasts hanging from her chest"; 
		} else {
			WorldControl.eneDescription += "\n\nAfter she moves out of the bushes, you could get her body details. It is a female that’s mostly human, except for some parts of her body. It has a pair of human legs that end in a pair of woman feet with the texture of the feet of a bird. Her arms are human at first, but after a bit they transformed into a pair of colorful wings with long feathers in them. Her head is like one of a human woman, but her hair is as colorful as her feathers. She sports a bird tail standing between a pair of plump and soft buttcheeks. She has a pair of C-Breasts hanging from her chest\n"; 
		}


		//////////////////// SCENES
		if (GameControl.mcGender == GameControl.MCGender.FEMALE) {
			mcpronoun = "girl";
		} else {
			mcpronoun = "boy";
		}


		//submit

		WorldControl.textSubmit = "You take the decision to surrender yourself to your enemy, seeing that you don’t have a chance and don’t want to have one. You slowly undress your clothes as you present yourself to your opponent. When the dodo sees that you are surrendering, she shrills in excitement and flaps her wings several times. <i>“Girls! Look what I found! Come over here, quickly.”</i>  \n\nAnd, as if she had just let out a battlecry, you can see two other dodo girls coming out of the places nearby after a couple of seconds, flying closer to your location. The three of them are quite similar in body shapes, but their hairs and feather colors are definitely different. <i>“What is it?,”</i> as the original dodo girl points at you. <i>“He’s up and willing!”</i>  as the other dodo girls look at you and scream in excitement just like the first one did.";
		if (GameControl.testiclesSize > 0) {
			line1 = "and their "+ ballsSize +" orbs that go with it";
		} else {
			line1 = "";
		}
		if (GameControl.testiclesSize > 0) {
			line2 = "and balls";
		} else {
			line2 = "";
		}

		if (GameControl.dick1Size > 0) {
			WorldControl.textSubmit += "They didn’t waste any more time and jump towards you, pushing you against your back and rubbing your "+ dickSize +" dick "+ line1 +". One of them hovers just enough to place herself over your face, pushing her pussy against your mouth. <i>”Start licking, runt!,”</i> she says, as she rubs it against your face, forcing you to use your tongue to please her warm pussy that is soaking your face with her vaginal juices. The second dodo grabs one of your hands and places it over her breasts, as she uses your other hand to penetrate herself with your fingers. The third one and original, rubs her twat against your cock, that it is already hard from all the abuse you’re having from the other two little dodo’s.\n\nThe original dodo girl impales herself all over your cock, as you can feel her throbbing insides rubbing against your shaft as she bounces up and down over your groin. The moans of the three are loud in your ears, her rubbing against your body and the scent of sex is getting harder, as you can feel your body being consumed by the ecstasy of being the fucktoy of the little horny birds in the plains. \n\nAfter what you felt is an eternity, you can’t hold it anymore as your body contorts from all the pleasure that you’re having, cumming with a loud moan on your own, as you fill the dodo’s hungry snatch with your searing hot jizz, as you can hear her squealing in delight, orgasming on her own, all over your cock "+ line2 +". And as if they were waiting for a signal, you can feel the cunt that is almost sucking your hand massaging it and the twat that you’re licking and sucking in front of your face, soaks you in her love fluids as both of them get to cum too, your whole body being surrounded by a circle of sex and lust.\n\nYou didn’t know when, but you finally fall unconscious. You wake up a couple of hours, laid against a bush next to your clothes as your body has drenched sex juices and feather all over it. You clean yourself the best you can and dress up, to return to the city.";
		} else {
			WorldControl.textSubmit += "They didn’t waste any more time and jump towards you, pushing you against your back and rubs your moist pussy. One of them hovers just enough to place herself over your face, pushing her pussy against your mouth. <i>”Start licking, runt!,”</i> she says, as she rubs it against your face, forcing you to use your tongue to please her warm pussy that is soaking you with her scent. The second one grabs one of your hands and places it over her breasts, as she uses your other hand to penetrate herself with your fingers. The third one and original, search through the things you have in your clothing, finding out the strap-on you always carry. <i>“Look what I found,”</i> she says as she equips herself with the strap-on. And without further warning she  rubs the dildo against your pussy, that it is already wet from all the abuse you’re having from the other two little dodo’s.\n\nThe original dodo girl thrust your strap-on inside your warm cunt, as you can feel your insides throbbing around the strap-on as she bounces in and out of you. The moans of the three are loud in your ears, her rubbing against your body and the scent of sex is getting harder, as you can feel your body being consumed by the ecstasy of being the fucktoy of the little horny birds in the plains. \n\nAfter what you felt is an eternity, you can’t hold it anymore as your body contorts from all the pleasure that you’re having, cumming with a loud moan on your own, as your own pussy drenches the strap-on as you can hear her enjoying your squealing with delight, orgasming on her own. And as if they were waiting for a signal, you can feel the cunt that is almost sucking your hand massaging it and the twat that you’re licking and sucking in front of your face, soaks you in her love fluids as both of them get to cum too, your whole body being surrounded by a circle of sex and lust.\n\nYou didn’t know when, but you finally fall unconscious. You wake up a couple of hours, laid against a bush next to your clothes as your body has drenched sex juices and feather all over it. You clean yourself the best you can and dress up, to return to the city."; 
		}



		//
		WorldControl.textDefeat = "You finally fall into the ground, utterly defeated by the dodo girl. You probably underestimate an opponent of her size, probably that is one of the reasons of your defeat: There is no small enemy. You rise and try to escape slowly, but she dodo girl flaps her wings and fly enough to catch you quite easily. <i>“You won’t escape from me, you runt,”</i> she says, with a mischievous smile on her face, her cunt dripping with her love fluids, eagerly awaiting for someone to scratch its itch, and you think that’s gonna be you.";
		if (GameControl.dick1Size > 0) {
		
			WorldControl.textDefeat += "You try to fight back, but you can’t stop her from removing your clothes by force. She keeps her eyes over your cock, which got hard due to all the rubbing and anticipation. After a bit of struggle, you place yourself with your back against a tree, as the dodo girl hovers against you and hugs your waist with her legs, rubbing your cock with her wet snatch. <i>“You think that you’re gonna escape after what I’ve been through to find you?! No, " + mcpronoun +  ",”</i>. she says out loud as she impales herself over your cock. <i>“You will stay there and let me savor your cock until I say I’m done! Got it?!”</i>\n\nYou can feel how her cunt is holding your cock with a strong grip, massaging it while she rubs her breasts against your " + breasts +  " chest. She is flapping her wings to push herself off your cock and her legs to thrust herself back. The rubbing of her insides was something out of the ordinary, as the little dodo girl was hovering as she pumps herself over your cock. When you try to place your hands on her jiggly bits, she shrieks without stopping her grinding. <i>“No hands or I fall!,”</i> as she continues her ordeal with you.\n\nThe only thing that you can do at the time is to let yourself go, as the avian girl in front of you uses you as a fucktoy on the wall, as there is nothing else you can do to stop it. But after a bit of grinding, you start to think that perhaps it’s something nice, as you have a chance to feel the dodo’s body rubbing against yours, as she seems desperate for something to impale herself into. When you finally feel that you are on the verge of cumming, you can only let out a hard moan before your cock starts pouring your seed inside her needy pussy but you can see that she doesn’t stop pumping, drips of your jizz spilling into the floor each time the pushes herself off your cock before engulfing it once more with her insides.\n\nYour cock keeps spurting jizz, staining her belly and ass while doing so, until you feel how she hugs you hard with her legs, digging her nails into your skin as her cunt tries to milk your sensitive dick after you came, as she finally presses her torso against your own, panting with a smile of pleasure on her face, her tongue touching your torso. <i>“Finally… I’m sated for now.”</i> And as if you disappeared from existence, she pulls out your dick from her and starts to use her wings to move away from the place, drops of your cum falling into the ground below her as she leaves the place flying, without saying another word.\n";
		} else {
			WorldControl.textDefeat += "You try to fight back, but you can’t stop her from removing your clothes by force. She keeps her eyes over your mouth. After a bit of struggle, you place yourself with your back against a tree, as the dodo girl hovers against you and hugs your face with her legs, rubbing your face with her wet snatch. <i>“You think that you’re gonna escape after what I’ve been through to find you?! No, "+ mcpronoun +"!,”</i> she says out loud as she forces herself over your mouth. <i>“You will stay there and let me savor your tongue until I say I’m done! Got it?!”</i>\n\nYou can feel how her cunt is dripping wet as you start to savor it with your tongue, your mind getting numb by the intoxicating scent of sex that is filling your nostrils, while she rubs her breasts against your head. She is flapping her wings to lever herself off your face and her legs to force you to lick her harder. The wetness and heat of her cunt are out of the ordinary, as the little dodo girl is hovering as she pumps herself over your cock. When you try to place your hands on her jiggly bits, she shrieks without stopping her grinding. <i>“No hands or I fall!,”</i> as she continues her ordeal with you.\n\nThe only thing that you can do at the time is to let yourself go, as the avian girl in front of you uses you as a fucktoy on the wall, as there is nothing else you can do to stop it. But after a bit of grinding, you start to think that perhaps it’s something nice, as you have a chance to feel the dodo’s body rubbing against yours, as she seems desperate for something to impale herself into. When you finally feel that you are on the verge of cumming, you can only let out a hard moan before your pussy begin to soak your own thighs as the heat of your orgasm flows through your whole body, but you can see that she doesn’t stop pushing, drips of your fluids are sent flying a bit each time the rubs herself against your sex-soaked mouth.\n\nYour legs tremble as they stain with your own femcum, until you feel how she hugs you hard with her legs, digging her nails into your skin as her cunt convulsed around your tongue as her fluids fall off through your neck and into your chest, as she finally rests her torso against you, her breasts pressing against your head while she is panting with a smile of pleasure on her face, her tongue flailing out. <i>“Finally… I’m sated for now.”</i> And as if you disappeared from existence, she pulls out your dick from her and starts to use her wings to move away from the place, drops of your cum falling into the ground below her as she leaves the place flying, without saying another word.\n";
		}




		/////////////////////////////////////////
		WorldControl.textVictory = "The Dodo girl was no match for you! She yields and ask for forgiveness! But her fate is up to you.";
		WorldControl.location = "Plains - Dodo Girl Combat"; 

		WorldControl.dropGold = Random.Range(8, 20); 


		// loot 

		randNum = Random.Range (0, 100);

		if (randNum > 80) {
			WorldControl.dropItem = 1025;
		} else if (randNum > 60) {
			WorldControl.dropItem = 1026;
		}  else if (randNum > 40) {
			WorldControl.dropItem = 1027;
		}  else if (randNum > 20) {
			WorldControl.dropItem = 1028;
		} else {
			WorldControl.dropItem = 1029; 
		}





	}






	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
