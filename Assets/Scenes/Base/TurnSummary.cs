using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class TurnSummary : MonoBehaviour {
	Parser myParser = new Parser(); 
	public Text Board;
	int random; 
	public static int dreamCD; 

	FollowersSpecialEvents followerspecialevents = new FollowersSpecialEvents();

	public Canvas panEndTurn;

	public Canvas panMain; 

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


	/// <summary>
	///  NPCs int loaders
	/// </summary>
	static int yoshika; //  // used to find them in the NPCCharList.Charlist[yoshika]
	static int misaki; 
	static int abbadon; 
	static int helena; 



	void Awake ()
	{
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

	}


	void loadFollowers()
	{//////////
		int i = 0; 
		while (i < NPCCharList.CharFollower.Count) 
		{/////
			if (NPCCharList.CharFollower [i].charID >= 5000 && NPCCharList.CharFollower [i].charID < 6000) {
				yoshika = i; 
			}
			if (NPCCharList.CharFollower [i].charID >= 4000 && NPCCharList.CharFollower [i].charID < 5000) {
				misaki = i; 
			}
			if (NPCCharList.CharFollower [i].charID >= 1000 && NPCCharList.CharFollower [i].charID < 2000) {
				abbadon = i; 
			}
			if (NPCCharList.CharFollower [i].charID == 3000) {
				helena = i; 
			}

			i++;
		}/////



	}////////// 

	void Start(){
		if (WorldControl.dayTime == 0 && WorldControl.day == 1) 
		{
			Board.text = "Today, you finally start your new adventure. Eager, you know that the future of you and the citizens of this island depend on your choices. Will you be a tyrant or a liberator? Will your cure their mind, or corrupt it instead? These ideas excite you, and you could either start to explore right away outside your city, or visit the the city and get acquatianted with its citizens. \n\n<b>It is important to check the journal, there you will find the main quest and future sidequests!</b>"; 
			return;
		} 



		if (CityControl.city100Corruption >= 50) {
			Board.text = "From the window you can see the city bustling with activity. Well, at least sexual activity, since some people moan so loud you can hear them from your tower. ";
			Board.text = Board.text + "\nThe city is indeed pretty corrupted, right now you calculate that the city is " + CityControl.city100Corruption + "% corrupted"; 
			Board.text += CastleController.castleDailyReport;
			Board.text += "\n\nCastle cleanliness: " + Mathf.Round(CastleController.castleCleanliness).ToString() + ".";
			Board.text += "\nCaste food quality: " + Mathf.Round(CastleController.castleFoodQuality).ToString() + ".";
			Board.text += "\nCastle supplies: " + Mathf.Round(CastleController.castleSupplies).ToString() + ".";
			Board.text += "\nPrivate rooms: " + CastleController.castlePrivateRoom.ToString() + ".";
			Board.text += "\nBoudoir's: " + CastleController.castleBoudoir.ToString() + ".";


		} else {
			if (CityControl.city100Corruption < 50) {
				Board.text = "From the window you can see that the city is very calm and still focused in working. Well, this is better than the derranged alternative. ";
				Board.text = Board.text + "\nRight now you calculate that the city is " + CityControl.city100Corruption + "% corrupted";
				Board.text += CastleController.castleDailyReport;
				Board.text += "\n\nCastle cleanliness: " + CastleController.castleCleanliness.ToString() + ".";
				Board.text += "\nCaste food quality: " + CastleController.castleFoodQuality.ToString() + ".";
				Board.text += "\nCastle supplies: " + CastleController.castleSupplies.ToString() + ".";
				Board.text += "\nPrivate rooms: " + CastleController.castlePrivateRoom.ToString() + ".";
				Board.text += "\nBoudoir's: " + CastleController.castleBoudoir.ToString() + ".";
			}
		}
	}


	/*
	void Start (){


		if (GameControl.isPregnant == true && GameControl.pregnantCounter == 1 && WorldControl.dayTime == 0) {
			giveBirth ();
		}else if (WorldControl.dayTime == 0) {
			dreamCD = 1; 
			specificEvents ();
			pregnancyAdvance ();
		} else {
			if (CityControl.city100Corruption >= 50) {
				Board.text = "From the window you can see the city bustling with activity. Well, at least sexual activity, since some people moan so loud you can hear them from your tower. ";
				Board.text = Board.text + "\nThe city is indeed pretty corrupted, right now you calculate that the city is " + CityControl.city100Corruption + "% corrupted"; 
			} else {
				if (CityControl.city100Corruption < 50) {
					Board.text = "From the window you can see that the city is very calm and still focused in working. Well, this is better than the derranged alternative. ";
					Board.text = Board.text + "\nRight now you calculate that the city is " + CityControl.city100Corruption + "% corrupted"; 
				}
			}
	

		}

		if (WorldControl.dayTime == 0 && WorldControl.day == 1) 
		{
			Board.text = "Today, you finally start your new adventure. Eager, you know that the future of you and the citizens of this island depend on your choices. Will you be a tyrant or a liberator? Will your cure their mind, or corrupt it instead? These ideas excite you, and you could either start to explore right away outside your city, or visit the the city and get acquatianted with its citizens. \n\n<b>It is important to check the journal, there you will find the main quest and future sidequests!</b>"; 
		} 


	}


*/



	void giveBirth(){
		Board.text = GameControl.pregnantText; 
		GameControl.isPregnant = false; 
		GameControl.pregnantCounter = 0;
		panEndTurn.sortingOrder = 500;
		panMain.sortingOrder = -500;
	}

	void pregnancyAdvance(){
		if (GameControl.isPregnant == true && GameControl.pregnantCounter == 8) {
			Board.text += "\n\nYou can feel how your body is changing. Your morning sickness doesn’t help you through your mornings, but you can still deal with it. Now you are almost sure that this is the symptoms of pregnancy, but you aren’t that sure about it, so you’ll wait a couple of days to be sure that this isn’t just some bad streak or maybe that you are just ill. ";
		
		}
		if (GameControl.isPregnant == true && GameControl.pregnantCounter == 6) {
			Board.text += "\n\nYou can finally feel the bulge in your belly that confirms your suspicion, you are surely pregnant. The nausea is gone, but you tire faster than before. But somehow you feel a bit more energetic and even your libido goes from up and down as the day goes. It’s something a bit problematic, but you can deal with this kind of things if you can assure that the child is safe. Your breasts start to get tender and bulge a bit, as you know that they are filling with milk.";
			GameControl.lactatingTurns = 20;
			GameControl.lactating = true; 
		}
		if (GameControl.isPregnant == true && GameControl.pregnantCounter == 4) {
			Board.text += "\n\nYour belly is huge, the child is pushing your insides with his huge body. You feel brimming with life from your head to your toes. The discomforts that you feel from time to time increase by the hour, but the rush of knowing that the due day is close, fills you with a mix of emotions that are harder to control. Dealing with your breasts is something problematic, as they are heavier than ever, almost full of milk.";
		}
		if (GameControl.isPregnant == true && GameControl.pregnantCounter == 2) {
			Board.text += "\n\nYou can barely fit into your clothing and you have to be careful on your trips, but you can’t be any happier, at least when the mood swings are stable enough for you to feel just one thing at once. Your breasts are dripping constantly with milk, ready for the life that is growing inside you. You know that the day is almost there, as you can feel it kicking against you from time to time, almost impatient to get out and know you.";
		}



	}


	void specificEvents(){
		Random.InitState (System.DateTime.Now.Millisecond);
		random = Random.Range (0, 12);



		switch (random)
		{
		case 6:
			/*
			if (NPCCharList.CharList [abbadon].corruptionStage >= 3 ) {
					Board.text = "You woke up early that day, because you know that Abaddon will arrive early for breakfast. So you try to get ready before he arrives, trying to take a bath at your castle. As you do, you can hear how the door opens slowly. You wonder who is getting inside, only to find out that it’s Abaddon, who is already half naked.\n\n-I thought that you would require some help. I know that you can’t do any shit for yourself anyway- He says, before showing that her nipples are getting themselves erect. Perhaps by looking at you naked. You enjoy the sight of his naked body and you invite him to come over. He smiles with a blushed face and runs towards your bath, almost jumping inside.";
					if (GameControl.dick1Size > 1) {
						Board.text = Board.text + "Once inside, you can see that he starts getting some soap on his hands, then proceeds to rub your dick with it. -Gotta scrub it nice and hard, especially down here- He strokes it with force and rubs it with the soap, then proceeds to wash it with water, stroking it once again in a forceful manner. -Do you like this, huh?- He says, her touch makes you harder and harder, as she presses his petite body against yours, as you decide to help him get clean too. So, you use some soap and scrub his body with force, pinching his nipples and spank his ass with might.\n\n-Perhaps you can help me reach the parts that I can’t- He says, exposing his not-surprisingly wet cunt to you. Washing off any sign of soap from your body, you get closer to him, pushing your tip against his pussy, sliding inside easily. You can hear him moan slowly, as he grabs you from your back as you pound it with force. -Scrub it hard, tear me apart!- He says, as you ram your cock inside him again and again, wildly thrusting your hips against his groin as you make him squeal in ecstasy, while you dig your nails in his skin, almost making him bleed. You can feel his insides teasing you each time you thrust inside, rubbing you as you forcefully invade them.\n\nAfter a bit, you can’t hold it anymore, pouring your seed inside him. His body twitches every time your throbbing cock unloads its contents on his insides. After a couple of loads, you can feel his twat convulsing around your cock, his own orgasm hitting him hard as his tongue lash out from his mouth.\n\nWhen your felt that you scrounged every part of his insides enough, you pull out, letting the water clean every stain of your cum from your bodies. You can see him panting as he smiles. -This is better than just a breakfast. We should do this more often...- He pecks you before washing himself quickly. After that, you had a relaxed breakfast, remembering what you just did and headed after to your respective jobs for the day.\n";
					} else { 
						Board.text = Board.text + "Once inside, you can see that he starts getting some water on his hands, then proceeds to rub your cunt with it. -Gotta scrub it nice and hard, especially down here- He strokes it and rubs it with the water with force, as you feel the force of the push with his hands. -Yeah, just like that...- He says, her touch makes you more and more hornier, as she presses his petite body against yours, as you decide to help him get clean too. So, you use some soap and rub his whole body in a forceful way, pinching his nipples and spanking his ass with might.\n\n-Perhaps this can help us reach the parts that we can’t- He says as he takes out a sizeable double dildo from the side of the bath, exposing his not-surprisingly wet cunt to you while he does. Washing off any sign of soap from your body, he gets closer to you, pressing one of the sides against his pussy and the other side against yours, sliding inside easily. You can hear him moan slowly, as he grabs you from your back as you pound it with force. -Scrub it hard, break it in my cunt!- He says, as you press the dildo inside him and at the same time, pushing it against your own cunt, wildly thrusting your hips against his groin as you make him squeal in ecstasy. You can feel your insides being rubbed against it each time you thrust, as it forcefully invaded them.\n\nAfter a bit, you can’t hold it anymore, cumming all over the dildo. You can see how at the same time, his body twitches as every wave of pleasure pushes your hips against him. After a couple of seconds, you can hear him moaning out loud, his own orgasm hitting him hard as his tongue lash out from his mouth.\n\nWhen your felt that it scrounged every part of his insides enough, you pull out the dildo off you two, letting the water clean every stain of your cum from your bodies. You can see him panting as he smiles. -This is better than just a breakfast. We should do this more often...- He pecks you before washing himself quickly. After that, you had a relaxed breakfast, remembering what you just did and headed after to your respective jobs for the day.\n";
					}
				}
				break;
			*/
			genericEvent ();
			break;
		case 5:
			/*
			if (NPCCharList.CharList [abbadon].corruptionStage <= 1 && NPCControl.npc1000Relationship >= 40) {
					Board.text = "You woke up early that day, because you know that Abaddon will arrive early for breakfast. So you try to get ready before he arrives, trying to take a bath at your castle. As you do, you can hear how the door opens slowly. You wonder who is getting inside, only to find out that it’s Abaddon, who is already half naked.\n\n-I thought that you would require some help. I know that you can’t do any shit for yourself anyway- He says, before showing that her nipples are getting themselves erect. Perhaps by looking at you naked. You enjoy the sight of his naked body and you invite him to come over. He smiles with a blushed face and runs towards your bath, almost jumping inside.\n";
					if (GameControl.dick1Size > 1) {
						Board.text = Board.text + "Once inside, you can see that he starts getting some soap on his hands, then proceeds to rub your dick with it. -Gotta get it nice and clean, especially down here- He strokes it and rubs it with the soap, then proceeds to wash it with water, stroking it once again in a teasing manner. -Yeah, just like that...- He says, her touch makes you harder and harder, as she presses his petite body against yours, as you decide to help him get clean too. So, you use some soap and rub his whole body in a seductive way, teasing his nipples and his ass, before washing it with the water around you.\n\n-Perhaps you can help me reach the parts that I can’t- He says, exposing his not-surprisingly wet cunt to you. Washing off any sign of soap from your body, you get closer to him, pushing your tip against his pussy, sliding inside easily. You can hear him moan slowly, as he grabs you from your back as you pound it with force. -Scrub it hard!- He says, as you ram your cock inside him again and again, wildly thrusting your hips against his groin as you make him squeal in ecstasy. You can feel his insides teasing you each time you thrust inside, rubbing you as you forcefully invade them.\n\nAfter a bit, you can’t hold it anymore, pouring your seed inside him. His body twitches every time your throbbing cock unloads its contents on his insides. After a couple of loads, you can feel his twat convulsing around your cock, his own orgasm hitting him hard as his tongue lash out from his mouth.\n\nWhen your felt that you scrounged every part of his insides enough, you pull out, letting the water clean every stain of your cum from your bodies. You can see him panting as he smiles. -This is better than just a breakfast. We should do this more often...- He pecks you before washing himself quickly. After that, you had a relaxed breakfast, remembering what you just did and headed after to your respective jobs for the day.\n\n"; 
					} else { 
						Board.text = Board.text + "Once inside, you can see that he starts getting some water on his hands, then proceeds to rub your cunt with it. -Gotta get it nice and clean, especially down here- He strokes it and rubs it with the water in a teasing manner. -Yeah, just like that...- He says, her touch makes you more and more hornier, as she presses his petite body against yours, as you decide to help him get clean too. So, you use some soap and rub his whole body in a seductive way, teasing his nipples and his ass, before washing it with the water around you.\n\n-Perhaps this can help us reach the parts that we can’t- He says as he takes out a sizeable double dildo from the side of the bath, exposing his not-surprisingly wet cunt to you while he does. Washing off any sign of soap from your body, he gets closer to you, pressing one of the sides against his pussy and the other side against yours, sliding inside easily. You can hear him moan slowly, as he grabs you from your back as you pound it with force. -Scrub it hard!- He says, as you press the dildo inside him and at the same time, pushing it against your own cunt, wildly thrusting your hips against his groin as you make him squeal in ecstasy. You can feel your insides being rubbed against it each time you thrust, as it forcefully invaded them.\n\nAfter a bit, you can’t hold it anymore, cumming all over the dildo. You can see how at the same time, his body twitches as every wave of pleasure pushes your hips against him. After a couple of seconds, you can hear him moaning out loud, his own orgasm hitting him hard as his tongue lash out from his mouth.\n\nWhen your felt that it scrounged every part of his insides enough, you pull out the dildo off you two, letting the water clean every stain of your cum from your bodies. You can see him panting as he smiles. -This is better than just a breakfast. We should do this more often...- He pecks you before washing himself quickly. After that, you had a relaxed breakfast, remembering what you just did and headed after to your respective jobs for the day.\n\n";
					}
				}
				break;
				*/
			genericEvent ();
			break; 

			case 4:

				/*

				if (NPCControl.npc4000Meet == true) {
					if (NPCControl.npc4000Corruption <= 25) {
						Board.text = "";
						if (GameControl.hasVagina == true) {
							Board.text = Board.text + "";
						} else {
							Board.text = Board.text + "";
						}


					} else if(NPCControl.npc4000Corruption >=100) {
						Board.text = "";
						if (GameControl.hasVagina == true) {
							Board.text = Board.text + "";
						} else {
							Board.text = Board.text + "";
						}
					}


				} else {
					genericEvent ();
				}
				genericEvent ();

				*/
				genericEvent ();

				break;
			case 3:

				//					Board.text = Board.text + "";
				/*
			if(NPCControl.npc3000Corruption == 75){
					Board.text = "You woke up at early morning, because you feel strangely hot from your waist down. You feel a surge of pleasure flowing through your whole body, starting from your lower body that is below your sheets right now. You ran a hand below it, and feel something else close to your legs. After a bit of groping, you found out that there is something moving below the sheets. \n";
					if (GameControl.dick1Size > 0) {
						Board.text = Board.text + "When you remove the cover, you can see that Helena is with you on the bed, sucking your cock while you were asleep, completely naked. She just looks at you when she founds out that she has been discovered, giving it a little lap while she waits for you to do something. -I was feeling so horny and you weren’t waking up, so I decided to get a taste of your morning wood- You ran a hand through her hair, to which she continues blowing you. You can feel her soft tongue wrapping around your shaft, as she strokes it with one of her silky hands. She tries her best while working your dick, until you feel the surge of cumming getting close.\n\nWhen you feel how you are getting close, she senses it because she tries to engulf as much as she can of your cock flesh, pressing it against her throat. You spurt your cum finally, pouring it on her throat directly, as you see her gulping each load you let out inside her hungry maw, sucking more and more as she tries to get all of your spunk out of you. Before you finish, she let it out of her mouth and let it pour your seed over her forehead and face. You can see that she is satisfied with her work, but you can smell that she is horny too, as the.scent of arousal gets you rather quickly.\n\n-I have things to do, "+  GameControl.playerName + ", so you owe me one. Perhaps you can pay it to me today...- She gives you a bedroom look, before cleaning herself a bit and leave you to get dressed for your day.";
					} else {
						Board.text = Board.text + "When you remove the cover, you can see that Helena is with you on the bed, licking your pussy while you were asleep. She just looks at you when she founds out that she has been discovered, giving it a little lap while she waits for you to do something. -I was feeling so horny and you weren’t waking up, so I decided to get a taste of your morning wood- You ran a hand through her hair, to which she continues licking you. You can feel her soft tongue wrapping around your clit, as she rubs your cunt with one of her silky hands. You can see that she tries her best while working your twat, until you feel the surge of cumming getting close.\n\nWhen you feel how you are getting close, she senses it because she tries to engulf as much as she can of your cunt, pressing it against her mouth. You spurt your femcum finally, pouring it on her tongue directly, as you see her enjoying each load you let out inside her hungry maw, licking more and more as she tries to get all of your juices out of you. Before you finish, she gets closer and let it pour your juices over her forehead and face. You can see that she is satisfied with her work, but you can smell that she is horny too, as the.scent of arousal gets you rather quickly.\n\n-I have things to do, "+  GameControl.playerName + ", so you owe me one. Perhaps you can pay it to me today...- She gives you a bedroom look, before cleaning herself a bit and leave you to get dressed for your day.";
					}
				} else {
					genericEvent ();
				}

				*/
			genericEvent ();
				break;






			case 2:
			/*
				if(NPCControl.npc3000Corruption == 25){
					Board.text = "You woke up at early morning, because you feel strangely hot from your waist down. You feel a surge of pleasure flowing through your whole body, starting from your lower body that is below your sheets. You move a hand below and feel something moving below the sheets. After a bit of groping, you found out that there is something moving below the sheets. \n\n";
					if (GameControl.dick1Size > 0) {
						Board.text = Board.text + "When you remove the cover, you can see that Helena is with you on the bed, sucking your cock while you were asleep. She just looks at you when she founds out that she has been discovered, giving it a little lap while she waits for you to do something. -I wanted to do something good for you, so that you can have a good start on the day...- You ran a hand through her hair, to which she continues blowing you. You can feel her soft tongue wrapping around your shaft, as she strokes it with one of her silky hands. You can see that she tries her best while working your dick, until you feel the surge of cumming getting close.\n\nWhen you feel how you are getting close, she senses it because she tries to engulf as much as she can of your cock flesh, pressing it against her throat. You spurt your cum finally, pouring it on her throat directly, as you see her gulping each load you let out inside her hungry maw, sucking more and more as she tries to get all of your spunk out of you. After it, you can see how she pulls out your dick with a slurp, as she drinks the last drips of your cum from her lips. You can see that she is satisfied with her work, but you can smell that she is horny too, as the.scent of arousal gets you rather quickly.\n\n-I would love for you to help me, "+ GameControl.playerName +", but I have things to do. Perhaps you can visit me later...- She gives you a bedroom look, before cleaning herself a bit and leave you to get dressed for your day.";
					} else {
						Board.text = Board.text + "When you remove the cover, you can see that Helena is with you on the bed, licking your pussy while you were asleep. She just looks at you when she founds out that she has been discovered, giving it a little lap while she waits for you to do something. -I wanted to do something good for you, so that you can have a good start on the day...- You ran a hand through her hair, to which she continues licking you. You can feel her soft tongue wrapping around your clit, as she rubs your cunt with one of her silky hands. You can see that she tries her best while working your twat, until you feel the surge of cumming getting close.\n\nWhen you feel how you are getting close, she senses it because she tries to engulf as much as she can of your cunt, pressing it against her mouth. You spurt your femcum finally, pouring it on her tongue directly, as you see her enjoying each load you let out inside her hungry maw, licking more and more as she tries to get all of your juices out of you. After it, you can see how she drinks the last drips of your cum from her lips. She seems satisfied with her work, but you can smell that she is horny too, as the.scent of arousal gets you rather quickly.\n\n-I would love for you to help me, "+  GameControl.playerName +", but I have things to do. Perhaps you can visit me later...- She gives you a bedroom look, before cleaning herself a bit and leave you to get dressed for your day.";
					}
				} else {
					genericEvent ();
				}
			*/
			genericEvent ();
				break;





			case 1:
			/*
			if (NPCControl.npc4000follower == true && NPCControl.npc4000Relationship >= 40) {
				if (NPCControl.npc4000Corruption <= 50) 
				{
						Board.text = "You sleep peacefully until morning, where someone entering your room wakes you up. As your sight adjusts, you can see that it’s Misaki, who is wearing only an apron. She is carrying a tray filled with breakfast, as she walks in that enticing way that she always does. -Good morning, sleepyhead!- She says out loud as she places the tray in the bed, next to you. -I wanted to try something special, so I thought that my favorite person would be ecstatic to test the food.- You were about to ask her how she got in here, but you dismiss the question for now.\n\nYou see the meal that she brought you and have a taste of it. Despite of what you would expect, it tastes really good. She looks at you expectantly, probably waiting for your opinion on her food. You take your time, enjoying her waiting face. But after a bit, you tell her that it’s wonderful. -A~mazing! Of course I’m the best- And with that, you eat your breakfast, feeding her a spoon of her own food, from time to time. At the end of it, you can see that there is a small plate on the tray, so you ask her about it. -Oh, that one means that there is still...- She says as she unties her apron, exposing her voluptuous naked body to you. -...the dessert-";
						if (GameControl.hasVagina != true) {
							Board.text = Board.text + "After that, she jumps at you and pushes you against the headboard, pressing her bountiful breasts against your chest as her tongue hunts wildly for your own, as if trying to quench the desire that seems to be accumulating inside her for a while. She almost grabs your hand and places over her chest, as you can feel her soft breasts below your fingers, the scent of arousal filling the air around you. She undresses you with surprising speed without ever breaking the kiss, as she strokes your cock easily, almost automatically. -Part of a balanced breakfast...- She says with a mocking tone as she breaks the kiss. You can feel her pussy teasing you as she rubs it against your cock, soaking it in her fluids. She starts to slide it inside her, letting her insides rub your cock as she pumps herself up and down over it. Her moans quickly fill the room as you don’t fall behind. You grab her breasts and play with her nipples using your tongue. -I hope you enjoy your treat- She says, helding your head against her chest.\n\nAfter a while, you can’t hold it anymore, so you cum inside her, filling her insides with your fresh spunk. When she feels that you are filling her with your jizz, she moans wildly and cums herself all over your cock, milking it for all its worth until you feel that your balls are completely empty. She pants as a smile is hanging from her face. -A cream-filled vixen. I love that dish you make- She says, before kissing you and pulling you out of her slowly, a trickle of your cum spilling from her cunt as she gets the tray from the bed, giving you a great view of her ass as she walks out of the room. -Have a nice day!-.\n";
						} else {
							Board.text = Board.text + "She takes out a double dildo from one of the drawers nearby. After that, she jumps at you and pushes you against the headboard, pressing her bountiful breasts against your chest as her tongue hunts wildly for your own, as if trying to quench the desire that seems to be accumulating inside her for a while. She almost grabs your hand and places over her chest, as you can feel her soft breasts below your fingers, the scent of arousal filling the air around you. She undresses you with surprising speed without ever breaking the kiss, as she rubs your cunt easily, almost automatically. -Part of a balanced breakfast...- She says with a mocking tone as she breaks the kiss. You can feel how she places the double dildo between your cunts and starts to rub it with both of them, mixing your fluids. She starts to slide one of the sides inside her and the other one inside you, letting the dildo rub your insides as she pumps herself up and down over it. Her moans quickly fill the room as you don’t fall behind. You grab her breasts and play with her nipples using your tongue. -I hope you enjoy your treat- She says, holding your head against her chest.\n\nAfter a while, you can’t hold it anymore, so you cum over the dildo, soaking it completely with your fresh spunk. When she feels that you are cumming on your own, she moans wildly and cums herself all over the dildo, moaning alongside you and trembling wildly from the pleasure. She pants as a smile is hanging from her face. -A vixen sandwich. I love that dish you make- She says, before kissing you and pulling it out of both of you slowly, giving you a great view of her ass as she walks out of the room. -Have a nice day!-.\n";
						}


				}
				else if(NPCControl.npc4000Corruption >=100) 
				{
						Board.text = "";
						if (GameControl.hasVagina == true) {
							Board.text = Board.text + "";
						} else {
							Board.text = Board.text + "";
						}
					genericEvent (); // when new content comes, remove
				}


				} else {
					genericEvent ();
				}*/
			genericEvent ();
				break;
			case 0:
			
			if ( NPCCharList.CharFollower[yoshika].isRecruited == true) {
				if (NPCCharList.CharFollower [yoshika].corruptionStage <= 2 && NPCCharList.CharFollower [yoshika].isLover == true) {
					Board.text = "As you were sleeping, you wake up to a servant that informs you that Yoshika is waiting for you at the lounge of your castle. You wonder what he could possibly want, so you put up some clothes and attend to him. You can see him sitting in one of the chairs of the room, almost drenching in sweat, definitely anxious about something.\n\nYou sat next to him and ask what happened to him, as he seems to be unharmed. He leans on the chair and closes his eyes. -Sorry, it’s just that I had one of those nightmares, where I’m a monster. Where I do horrible things...- You remember those nightmares of him. It seems that his mind still has some issues with his memory and sends him flashbacks from time to time. -They look so real... They feel so real- He looks at his own hand. -I almost ran instinctively to your castle, " + GameControl.playerName + ". Sorry if this woke you up this late-\n\nYou place a hand over his shoulder and tell him that it’s okay. That he is going for a lot on these last weeks that you don’t blame him, especially since he resides in the Forest. But maybe you can think of a way to help him relax for a bit. You can see him turning to see you, a spark of desire appearing in the bottom of his eyes. -You are right… Maybe I just need something to warm myself...-";
					if (GameControl.hasVagina == true) {
						Board.text = Board.text + "And with that, you kiss him with a lot of affect, as you can feel how his tongue is more anxious than usual, searching for yours and wrapping it with his own. He embraces you as both of you undress each other as both of you stumble and close the door that leads to other parts of the castle. You can feel how your own pussy is wet and ready for him, as his fingers tease it with passion. You can feel his cock rock hard, as you lean with your face over the wall and spread your legs. His torso leans over your back as the lusty deer places his hands over yours on the wall. Without further notice, you can feel how his cocks plunges inside your moist cunt, and begins to bang you against the wall, repeatedly.\n\nYou can feel how his body stops trembling from worry and fills with lust for you. You can feel his hands running up and down through your whole body, caressing every inch as his dick rubbed against your inner walls, until you feel him finally cumming inside you without ever stopping his rams against your crotch. After a couple of seconds, both of you are spent and slide into the floor. You can see him slipping into sleep. He is probably exhausted from the lack of sleep, but at least he is finally getting some of it. You lay with him in that state, not caring that both of you are naked and he is over you. And with that, you fall asleep for the rest of the night. When you woke up, you find yourself naked in your bed. Did he carried you to your room? Probably. And with that, you start your day.\n";
					} else {
						Board.text = Board.text + "And with that, you kiss him with a lot of affect, as you can feel how his tongue is more anxious than usual, searching for yours and wrapping it with his own. He embraces you as both of you undress each other as both of you stumble and close the door that leads to other parts of the castle. You can feel how your own asshole is ready for him, as his fingers tease it with passion. You can feel his cock rock hard, as you lean with your face over the wall and spread your legs. His torso leans over your back as the lusty deer places his hands over yours on the wall. Without further notice, you can feel how his cocks plunges inside your tight asshole, and begins to bang you against the wall, repeatedly.\n\nYou can feel how his body stops trembling from worry and fills with lust for you. You see his hands running up and down through your whole body, caressing every inch as his dick rubbed against your inner walls, until you feel him finally cumming inside you without ever stopping his rams against your crotch. After a couple of seconds, both of you are spent and slide into the floor. You can see him slipping into sleep. He is probably exhausted from the lack of sleep, but at least he is finally getting some of it. You lay with him in that state, not caring that both of you are naked and he is over you. And with that, you fall asleep for the rest of the night. When you woke up, you find yourself naked in your bed. Did he carried you to your room? Probably. And with that, you start your day.\n";
					}


				} else if (NPCCharList.CharFollower [yoshika].corruptionStage >= 4 && NPCCharList.CharFollower [yoshika].isLover == true) {
					Board.text = "You had a hard day, so you thank the fact that is time for sleep. As you went into your bedroom, you found out that there is someone else in the room. You found out that Yoshika is there, waiting for you on the bed with a mask that covers his eyes completely. He is strapped with ropes on his hands and feet, forcing him on his knees over the bed. There is a small paper over it, that says: “Use in case of a hard day”. He’s always thinking of you, that little bitch.";
					if (GameControl.hasVagina == true) {
						Board.text = Board.text + "You go with him and caress his crotch, which makes him twitch from the surprise, just to have the joy of seeing him pent up. After that, you undress your lower half of your clothes, exposing your moist cunt. You lean over the bed, take his head and place it in front of your needy snatch. You can see Yoshika’s nose twitching for a second, before starting to lick you with a load of energy. You can feel him sucking your clit and caressing your inner lips with ease. After a bit, you pull him against your pussy, as you can feel yourself on the edge. He doesn’t stop licking and teasing your sensitive flesh until you finally cum, a load of femspunk spraying against his face until you finally feel spent.\n\nYou see his cock and found out that he had an orgasm while you had your own. You leave him in his own puddle of cum as you fell asleep on the bed. When you woke up, you found out that he is already gone. At least he knows that when he fills his use, he gets out of the way. Quite practical. ";
					} else {
						Board.text = Board.text + "You go with him and caress his crotch, which makes him twitch from the surprise, just to have the joy of seeing him pent up. After that, you undress your lower half of your clothes, exposing your cock. You lean over the bed, take his head and place it in front of your pulsating dick. You can see Yoshika’s nose twitching for a second, before starting to blow you with a load of energy. You can feel him sucking your tip and then engulfing almost completely. After a bit, you pull him against your cock, as you can feel yourself on the edge. He doesn’t stop licking and teasing your sensitive flesh until you finally cum, a load of spunk spraying against his face until you finally feel spent.\n\nYou see his cock and found out that he had an orgasm while you had your own. You leave him in his own puddle of cum as you fell asleep on the bed. When you woke up, you found out that he is already gone. At least he knows that when he fills his use, he gets out of the way. Quite practical.";
					}
				} else {
					genericEvent ();
				}


				} else {
					genericEvent ();
				}
				break;

			default:
				genericEvent();
				break;

		}

	}

	//			Board.text = Board.text +  ""; 
	void genericEvent()
	{
		Random.InitState (System.DateTime.Now.Millisecond);
		random = Random.Range (0, 10);
		//these cases will be the generic ones if the other loads something thats unavailable.
		switch (random) 
		{
		case 11: 
			if (GameControl.charCorruption > 50) {
				Board.text = "You woke up hungry during the night, so you go to the kitchen and grab some food to ease your appetite. You can hear some moaning coming from the kitchen, as you can see one of the guards fucking one of the maids in the room next to the kitchen. You hope that he isn’t on patrol, or he is gonna get punished.\n\nYou finish your meal and see the night sky through the same window to the rest of the city. You will corrupt this city to its very core. And with that, you return to sleep.";
			}
			break;

		case 10:
			if (GameControl.charCorruption > 50) {
				
				Board.text = "You see yourself sitting in the middle of a large table, filled with a lot of people. They wear fine clothing and expensive jewelry. You wanted to talk with them, but before you can do it, you hear trumpets, announcing someone.\n\nAfter that, you hear one envoy speaking in a loud voice. -All salute, "+  GameControl.playerName + ", the King of the Caelia Kingdom. A toast for him!- All of them cheer your name at the same time as they toast. You hear someone clapping and the door of the hall open, letting in several naked whores among a couple of Lost slaves, the scent of sex filling the room pretty fast. The people start undressing as the fucking starts in front of you. When you hear the first moan, you wake.\n\nYou know that you’ll be able to do it, someday.";
			} else {
				genericEvent ();
			}

			break;

		case 9: 
			GameControl.actualArousal += 20; 
			if (GameControl.actualArousal > GameControl.maxArousal) {
				GameControl.actualArousal = GameControl.maxArousal; 
			}
			if (GameControl.charCorruption < 50) {
				Board.text = "You dream that you are sitting alone in a chair that is located in the middle of a classroom. The place looks like the college of the city, although it’s cleaner and in a better shape of what you remember. You can see that the chalkboard in front of you says: “Final Exam”. You didn’t remember about the final exam! You dress at yourself and found out that you’re naked. -I hope that you’re ready for your final exam, M. "+ GameControl.playerName + "- You turn to see the origin of that voice.";
				if(GameControl.dick1Size > 0 ){
					Board.text = Board.text +  "You can see that there is a sensual woman with demon horns and tail in front of you, completely naked, wearing only a pair of glasses. -Oh, I see that you’re ready for it- She says, as she walks slowly to you and gets a hold of your cock, which is already erect. She kneels and starts to blow you, sucking it with force while you see how she fingers herself while doing so. When you finally cum, she strokes you as she let it all out over her face and amazing breasts, a trickle of your spunk dripping from the side of her glasses. -Amazing. I’ll give you a perfect score-\n\nYou woke up after that. Suddenly, you want to go to the college."; 
				}else{
					Board.text = Board.text +  "You can see that there is a good-looking man with wolf characteristics in front of you, completely naked, wearing only a tie. -Oh, i see that you’re ready for it- He says, as he walks slowly towards you, grabbing your " + breasts + " chest with one hand and rubs your pussy with the other. He kneels and starts to eat you, licking with expertise and teasing your clit with care, stroking his cock with doing so. When you finally reach your orgasm, you can see him cumming on his own, his jizz staining your thighs as you soak his face and tie with your sex juices. -Amazing. I’ll give you a perfect score-\n"; 
				}
			} else {
				Board.text = "You dream that you are sitting in the professor's desk in a classroom. The place looks like the college of the city, although it’s cleaner and in a better shape of what you remember. You can see that the chalkboard next of you says: “Final Exam”. You hope that the students are ready for it! You dress at yourself and found out that you’re naked. You tell them that they can start, and when you say that, they start making out with each other in their desks. At first they are careful, but they quickly turn perverts, doing trio’s or gangbangs. -I hope that you can help me with my exam, M. "+ GameControl.playerName +"-";
				if (GameControl.dick1Size > 0) {
					Board.text = Board.text +  "You can see that there is a sensual woman with demon horns and tail in front of you, completely naked, wearing only a pair of glasses. -Oh, I see that you’re ready for it- She says, as she walks slowly to you and gets a hold of your cock, which is already erect. She kneels and starts to blow you, sucking it with force while you see how she fingers herself while doing so. When you finally cum, she strokes you as she let it all out over her face and amazing breasts, a trickle of your spunk dripping from the side of her glasses. -I won’t mind repeating this class...-\n\nYou woke up after that. Suddenly, you want to be a professor."; 
				} else {
					Board.text = Board.text +  "You can see that there is a good-looking man with wolf characteristics in front of you, completely naked, wearing only a tie. -Oh, i see that you’re ready for it- He says, as he walks slowly towards you, grabbing your chest with one hand and rubs your pussy with the other. He kneels and starts to eat you, licking with expertise and teasing your clit with care, stroking his cock with doing so. When you finally reach your orgasm, you can see him cumming on his own, his jizz staining your thighs as you soak his face and tie with your sex juices. -I won’t mind repeating this class-\n\nYou woke up after that. Suddenly, you want to be a professor."; 
				}

			}

			break; 

		case 8: 
			GameControl.actualArousal += 20; 
			if (GameControl.actualArousal > GameControl.maxArousal) {
				GameControl.actualArousal = GameControl.maxArousal; 
			}
			if (GameControl.charCorruption < 50) {
				Board.text = "You drift into a dream where you are in an alley, being followed by someone, as you are completely naked. You try to escape, but you finally reach to the end of the alley with no chance to escape. You can see a dark silhouette that is looking definitely at you, with a smile hanging from its face. -I finally got you...-";
				if(GameControl.dick1Size > 0 ){
					Board.text = Board.text +  "When she approaches, you finally discern its details. It's a naked woman with tiger characteristics. She pounces at you, pinning you against the ground. -You can’t escape from me...- She rubs her pussy over your "+ dickSize +" cock, her rubs and scent getting it hard in no time and impaling herself over it, brutally riding you. When you finally cum, she doesn’t stop pumping your dick. -This is not over!- You cum again and again, but it seems that she doesn’t plan to stop soon. You faint.\n\nYou wake up in your bed, your sheets all full of your spunk. Helena is gonna be mad…"; 
				}else{
					Board.text = Board.text +  "When he approaches, you finally discern its details. It’s a naked man with demon characteristics. He lunges at you, pinning you against the ground. -You can’t escape from me...- He rubs his big cock against your snatch, his intoxicating musk getting you wetter by the second, before he plunges it inside you, brutally fucking you. You can feel him cumming inside you, filling your insides with his strong-scented jizz but he doesn’t stup ramming your pussy. -This is not over!- You cum again and again the same as he, but it seems that he doesn’t plan to stop soon. You faint.\n\nYou wake up in your bed, your sheets all full of your sex juices. Helena is gonna be mad…\n"; 
				}
			} else {
				Board.text = "You drift into a dream where you are in an alley, following someone that is ahead of you as you are completely naked. It tries to escape, but you finally reach to the end of the alley, finding that it has no chance to run away from you. You can see a dark silhouette in the wall that is looking definitely at you, with a worried face. -Please, don’t...-";

				if (GameControl.dick1Size > 0) {
					Board.text = Board.text +  "When you approach, you finally discern its details. It's a naked woman with tiger characteristics. You pounce at her, pinning it against the ground. -I won’t fight...- You rub your cock over her soft pussy, your rubbings and her scent getting you hard in no time and ramming her with it, screwing her wildly. When you finally cum, you doesn’t stop pumping your dick inside her. -Please, no more!- You cum again and again as you doesn’t plan to stop soon. You finally faint, a bit after her of course.\n\nYou wake up in your bed, your sheets all full of your spunk. Helena is gonna be mad…"; 
				} else {
					Board.text = Board.text +  "When you approach, you finally discern its details. It’s a naked man with demon characteristics. He lunges at you, pinning you against the ground. -How are you so strong?- You rub your snatch against his big demonic cock, his intoxicating musk getting you wetter by the second, before you impale yourself over it, brutally riding him. You can feel him cumming inside you, filling your insides with his strong-scented jizz but you don’t stop ramming your pussy against his cock, even with more force than before. -Again?- You cum again and again the same as he, but you don’t plan to stop soon. You faint.\n\nYou wake up in your bed, your sheets all full of your sex juices. Helena is gonna be mad…"; 
				}

			}

			break; 

		case 7:
			GameControl.actualArousal += 20; 
			if (GameControl.actualArousal > GameControl.maxArousal) {
				GameControl.actualArousal = GameControl.maxArousal; 
			}
			if (GameControl.charCorruption < 50) {
				Board.text = "You fall asleep rather quickly, as you dream that you are back onto the cabin in the woods where you grew up, but you feel different. There is a woman laying on your old bed, waiting for you with spread legs. -I was waiting for you, my dear… I’ve been horny all day-"; 
				if(GameControl.dick1Size > 0 ){
					Board.text = Board.text + "You undress and start fucking her with all your might, her embrace feeling fantastic. You can feel her insides wrapping up your cock so tight that you can only think on thrusting against her warm pussy, feeling like home. Finally, you cum and fill her with your hot jizz, making her cum on her own. You can feel how she kisses you, stifling her moans with your mouth.\n\nAnd with that you wake up. You wonder if that would have been your life, if not for this inheritance.\n\n"; 
				}else{
					Board.text = Board.text + "You undress and start rubbing your cunt against her own with desperation, her embrace feeling fantastic. You can feel her clit pushing against your own so amazingly that you can only think on pressing and rubbing your pussy against her warm cuntflesh, feeling like home. Finally, you cum and moan wildly, causing her an orgasm on her own. You can feel how she kisses you, stifling her moans with your mouth.\n\nAnd with that you wake up. You wonder if that would have been your life, if not for this inheritance."; 
				}
			} else {
				Board.text = "You fall asleep rather quickly, as you dream that you are back onto the cabin in the woods where you grew up, but you feel different. There is a naked woman laying on your old bed, tied completely, from head to toe, her legs forced open with the rope. You can see a mix of lust and fear in her face."; 

				if (GameControl.dick1Size > 0) {
					Board.text = Board.text +  "You undress and start fucking her with all your might, her embrace feeling fantastic. You can feel her insides wrapping up your cock so tight that you can only think on thrusting against her warm pussy, truly feeling like home. Finally, you cum and fill her with your hot jizz, making her cum on her own. You can feel how she moans like a bitch in heat.\n\nAnd with that you wake up. You wonder if that would have been your life, if not for this inheritance.\n"; 
				} else {
					Board.text = Board.text +  "You undress and start rubbing your cunt against her own with desperation, using the ropes as leverage. You can feel her clit pushing against your own so amazingly that you can only think on pressing and rubbing your pussy against her warm cuntflesh, truly feeling like home. Finally, you cum and moan wildly, causing her an orgasm on her own. You can feel how she kisses you, stifling her moans with your mouth.\n\nAnd with that you wake up. You wonder if that would have been your life, if not for this inheritance.\n"; 
				}
	
			}

			break;
		case 6:
			Board.text = "You see yourself sitting in the middle of a large table, filled with a lot of people. They wear fine clothing and expensive jewelry. You wanted to talk with them, but before you can do it, you hear trumpets, announcing someone.\n\nAfter that, you see the King of the Citadel. He lifts his cup. -Today, I would like to celebrate the magnificence of Aurorum, thanks to the effort of "+ GameControl.playerName +". Without his support, the city wouldn’t be the metropolis that is today- All of them cheer your name at the same time as they toast. When the cups clash, you wake up.\n\nYou wonder if you’ll be worthy of that honor someday."; 
			break;
		case 5:
			Board.text = "You woke up hungry during the night, so you go to the kitchen and grab some food to ease your appetite. You can see that the whole place is completely silent, but you can see the guards from one of the windows of the corridor, patrolling outside.\n\nYou finish your meal and see the night sky through the same window. You will restore your city, they will see. And with that, you return to sleep."; 
			break;
		case 4:
			Board.text = "You remember that you dreamt something, but you can’t remember right now. It must have been something that isn’t interesting enough for you to remember it. So you wake up early and got ready for the day."; 
			break;
		case 3:
			Board.text = "You arrive at your bed completely tired, and that’s probably the reason of why you didn’t dreamt anything, so the night was something quite peaceful. Good luck for you, because you needed that. "; 
			break;
		case 2:
			Board.text = "You woke up in the middle of the night, startled. Probably a nightmare, but you can’t quite remember it. You stand up to take a sip of water and then you return to sleep. After that, the night went fine until the next morning."; 
			break;
		case 1:
			Board.text = "You have a nightmare, as you see the story that your guardian told you. You can see it holding a baby, running from a place that is swarming with guards. You can see how it runs into the forest until there is a hill that allows it to see the city from the distance. You can see that its quite similar to how it looks like today, but you think that’s because you don’t know how it looked like back then.\n\nAfter that, you can see how it disappears into the darkness that the trees gave it, until you can no longer see it. You wake with an awful taste in your mouth, but you get ready for the new day."; 
			break;
		case 0:
			Board.text = "You have a nightmare where you can see that the Citadel bring its armies to the door of your city, and without further notice, they start slaying anyone who has any sign of the plague, even the slightest. Women, men or anything in-between, caught by steel or fire.\n\nYou try to protect them, but they are too many. Finally they attack you, maybe because they don’t care who you are. Perhaps all of you are infected to them. You deal with guard after guard, until you finally succumb to exhaustion. You woke up, covered in sweat and searching instinctively for your weapon. It was only a dream… only a dream. \n"; 
			break;
		default:
			genericEvent ();
			break;
		}

	}








}