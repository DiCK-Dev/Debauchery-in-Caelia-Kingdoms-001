using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class SceneWolf : MonoBehaviour {

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
		Board.text = "After a decent fight, you finally defeat your wolf opponent. You can see that he tries to stay on his feet, but is unable to do so. -You won the battle and prove that you are stronger than me. Claim your prize, but you’ll have to force me until the end- You see that he stills has his pride, as his arousal is close to none on his eyes. So, you’ll have to show him who’s in charge right now.";
		if ( GameControl.mcSex == GameControl.MCSex.Woman || GameControl.mcSex == GameControl.MCSex.Cuntboy) {
			Board.text += "You undress your " + clothes + ", as you displayed your " + breasts + " breasts and walked close to him, as you can see its muscles tensing just a bit, knowing that is the hardest they will get for the remainder of the encounter. You push him with force, to make him fall into the ground face down, exposing his athletic ass to you. He growls in that position and tries to cover it with his claws, but you know is futile. You take your reliable strap-on from your clothing and place it on your crotch, before anything else.\n\nYou slap his claws out of the way, hearing a small whimper as you see his tight asshole exposed. Probably it isn’t used that much, as a predator that he is. You can bet that is extra tight, just waiting for a cock to show him what it's like to be ravaged. As you toss its tail aside and grab its buttcheeks, you can hear the claims of the defeated wolf. -Don you dare! I’m a hunter! I’m not going to be treated like a mere quarry...- You slap him in one of its buttcheeks, making him whimper once more and thrash a bit in defiance. You slap him again with force, as his squirming continued but he stayed silent. That is better. You place your strap’s cock against his pucker’s ring and started pressing your entrance inside him.\n\nYou can see as he tried to reach you, but from that position the only thing he could do was hold his torso up, turning to see you ravish his back door like a cheap dirty whore. Gaining momentum, you intrude in his ass, making him moan once. Without further adding, you get to fucking him with force, pushing your  hips against his strong asscheeks, rocking him back and forth with each thrust. He thrashes and swing his arms trying to retaliate, but is useless. You turn to see him and perceive that his cock is rock hard between his legs and his tongue is hanging out from its mouth, although his face is of someone who is fighting his own urge. -So… savage… So… strong...- It seems that the apex predator couldn’t resist a good fucking in the ass.\n\nYou continue abusing his tight asshole, until you couldn’t hold your orgasm anymore. Your cunt convulsed as you push the strap-on inside as far as you can, as you drip a load of femjuice as you cum. You can see how your opponent lowers his head into the ground and claws it as his own cock gets to cum hard too, spilling its spunk in the floor below him. You tell him that he seems to be enjoying it, at which he can barely answers. -I’m… not… you predator...- He says, as you pull your strap out of him, looking how he keeps his eyes low for the shame of enjoying it, perhaps. It’s so hot to see a hunter being soaked with your juices, in a puddle of its own spunk, as he lowers his ass and keeps panting in the ground in front of you. You take your clothings, remove the strap-on and dress them once more, before returning to your city after such a good fuck.\n";


		} else if (GameControl.dick1Size > 0 && GameControl.charArmorTags [11] == false) {
			if (GameControl.hasKnot == true) {
				line1 = "Your knot invaded his insides, helping you keep your cream in place";
			} else {
				line1 = "";
			}
			Board.text += "You undress your " + clothes + ", as you displayed your " + dickSize + " hard cock to your opponent along with your " + breasts + " breasts and walked close to him, as you can see its muscles tensing just a bit, knowing that’s the hardest they will get for the remainder of the encounter. You push him with force, to make him fall into the ground face down, exposing his athletic ass to you. He growls in that position and tries to cover it with his claws, but you know is futile.\n\nYou slap his claws out of the way, hearing a small whimper as you see his tight asshole exposed. Probably it isn’t used that much, as a predator that he is. You can bet that is extra tight, just waiting for a cock to show him what it's like to be ravaged. As you toss its tail aside and grab its buttcheeks, you can hear the claims of the defeated wolf. -Don you dare! I’m a hunter! I’m not going to be treated like a mere quarry...- You slap him in one of its buttcheeks, making him whimper once more and thrash a bit in defiance. You slap him again with force, as his squirming continued but he stayed silent. That is better. You place your cock’s tip against his pucker’s ring and started pressing your entrance inside him.\n\nYou can see as he tried to reach you, but from that position the only thing he could do was hold his torso up, turning to see you ravish his back door like a cheap dirty whore. Gaining momentum, you intrude in his ass, making him moan once. Without further adding, you get to fucking him with force, pushing your  hips against his strong asscheeks making your " + ballsSize + " balls and his own touch, rocking him back and forth with each thrust. He thrashes and swing his arms trying to retaliate, but is useless. You turn to see him and perceive that his cock is rock hard between his legs and his tongue is hanging out from its mouth, although his face is of someone who is fighting his own urge. -So… savage… So… strong...- It seems that the apex predator couldn’t resist a good fucking in the ass.\n\nYou continue abusing his tight asshole, enjoying its warm and tight insides until you couldn’t hold your orgasm anymore. Your dick convulsed as you push it inside as far as you can, letting your wolf whore take all your cum for himself. You can feel your cream filling your brawny opponent, as he lowers his head into the ground and claws the ground as you spurt your sperm until his asshole can’t take it no more. " + line1 + "Your knot invaded his insides, helping you keep your cream in place[/KNOT] You can see how his own cock gets to cum hard too, spilling its spunk in the floor below him. You tell him that he seems to be enjoying it, at which he can barely answers. -I’m… not… you predator...- He says, as you pull your shaft out of him, looking how he seems to be holding all your cum inside him like a pro. It’s so hot to see a hunter being covered in your cum, in a puddle of its own spunk, as he lowers his ass and keeps panting in the ground in front of you. You take your clothings and dress them once more, before returning to your city after such a good fuck.\n";
			charVirginity ();

		} else if (GameControl.mcSex == GameControl.MCSex.Man   && GameControl.charArmorTags [11] == true) {

			Board.text += "You undress your clothes, as you displayed your [BREASTS] chest and walked close to him, as you can see its muscles tensing just a bit, knowing that is the hardest they will get for the remainder of the encounter. You push him with force, to make him fall into the ground face down, exposing his athletic ass to you. He growls in that position and tries to cover it with his claws, but you know that his struggling is futile. You take out a big dildo and hold it in your hand, before anything else.\n\nYou slap his claws out of the way, hearing a small whimper as you see his tight asshole exposed. Probably it isn’t used that much, as a predator that he is. You can bet that is extra tight, just waiting someone to show him what it's like to be ravaged. As you toss its tail aside and grab its buttcheeks, you can hear the claims of the defeated wolf. <i>“Don you dare! I’m a hunter! I’m not going to be treated like a mere quarry…”</i> You slap him in one of its buttcheeks, making him whimper once more and thrash a bit in defiance. You slap him again with force, as his squirming continued but he stood silent. That is better. You place your dildo against his pucker’s ring and started pressing its tip inside him.\n\nYou can see as he tried to reach you, but from that position the only thing he could do was hold his torso up, turning to see you ravish his back door like a cheap dirty whore. Gaining momentum, you intrude in his ass, making him moan once. Without further adding, you get to fucking him with force with your dildo, pushing the sex toy with your hand against his strong asscheeks, rocking him back and forth with each push. He thrashes and swing his arms trying to retaliate, but is useless. You turn to see him and perceive that his cock is rock hard between his legs and his tongue is hanging out from its mouth, although his face is of someone who is fighting his own urge. <i>“So… savage… So… strong…”</i> It seems that the apex predator couldn’t resist someone tearing up his ass that good.\n\nYou continue abusing his tight asshole, until the wolf moans and thrashing as you use him send you over the edge. Your cock convulse as you leave the dildo inside as far as you can, as you pour a load of your own cum into the wolf thighs. You can see how your opponent lowers his head into the ground and claws it as his own cock gets to cum hard too, spilling its spunk in the floor below him. You tell him that he seems to be enjoying it, at which he can barely answers. <i>”I’m… not… enjoying it, predator…,”</i> he says, as you pull your dildo out of him, looking how he keeps his eyes low for the shame of enjoying it, perhaps. It’s so hot to see a hunter being soaked with your juices, in a puddle of its own spunk, as he lowers his ass and keeps panting in the ground in front of you. You take your clothings, store the dildo and dress once more, before returning to your city after such a good use of someone.";

		}

	}



	public void Scene2(){
		if (GameControl.hasVagina == true) {
			mcPregnancy ();
		}
		GameControl.actualArousal = 0; 
		Board.text = "You finally defeat your opponent after a dangerous combat. You can see that it has lost its will to fight, but his cock is hard and dripping with precum, as he can’t take his eyes out of your groin. So, you decide to have some fun with your helpless opponent. -You won… Take me as you like- He says, as he is sitting on the floor with his head low. And with that big and long cock ready, you just know what to do. ";
		if ( GameControl.mcSex == GameControl.MCSex.Woman || GameControl.mcSex == GameControl.MCSex.Cuntboy && GameControl.charArmorTags [11] == false) {
			Board.text += "You undress your " + clothes + "and toss it aside, showing your pussy and your " + breasts + "breasts to your opponent. Your opponent is a bit puzzled by your actions as you sit on its lap and get to rub your pussy against his cock, making him squint by its wetness that soaked his wang. -Do you want to mate on your terms, then?- You hear from him as you feel his throbbing cock getting harder with each rub. You wouldn’t let that opportunity to ride that cock until next week, so you only nod to his answer as you align your pussy with his dick.\n\nIt takes you a bit of effort, as you impale yourself in that big cock of his. You can feel its cock meat pushing itself inside your pussy, rubbing every part of your inner walls as it fills you completely. You can hear him moaning in a low tone, mixing it with a low growl. He tries to get a hold of your body, so you guide him to your  torso as you begin bouncing up and down into his mighty rod, your body getting warmer as your breathing transformed into a ceaseless panting as more of his cock you were taking inside you.\n\n-You are a strong mate… I don’t feel shame by being fucked by the ones like you... - He says out loud, mixed with moanings as your cunt entrances him more and more. His cock pulsates with every bounce as you feel your orgasm getting closer. You start playing with your  nipples until you feel your orgasm getting close. Without warning, you feel the wolf’s cock convulsing as he starts to cum inside you, filling your lusting twat with his hot and thick cream. You can feel it stuffing your insides at its peak as his cock poured in his fiery load.\n\nThe sensation of the wolf’s cum painting your nether walls sends you over the edge, as you get to cum over his cock, soaking it in a mix of his own spunk and your juices as your whole body trembles in pleasure as the orgasm hit you like a surge or heat through your whole body. \n\nWhen it finally passes, you pull out of his cock with a loud popping sound, streaks of cum dripping between your thighs and into the ground beneath you. Your body is trembling as you walk away from your enemy, which keeps his head low, avoiding your gaze as you dress up once more and return to your city, before that wolf recover his forces and wants to enact his revenge.";
			charVirginity ();
		} else if (GameControl.mcSex == GameControl.MCSex.Man   ) {
			Board.text += "You undress your " + clothes + "and toss it aside, showing your " + breasts + "breasts to your opponent. Your " + dickSize + " cock stand proudly between your legs.Your opponent is a bit puzzled by your actions as you sit on its lap and get to rub your asscheeks against his cock, making him squint by the softness that rubs over his wang. -Do you want to mate on your terms, then?- You hear from him as you feel his throbbing cock getting harder with each rub. You wouldn’t let that opportunity to ride that cock until next week, so you only nod to his answer as you align your asshole with his dick.\n\nIt takes you a bit of effort, as you impale yourself in that big cock of his. You can feel its cock meat pushing itself inside your pucker, rubbing every part of your inner walls as it fills you completely. You can hear him moaning in a low tone, mixing it with a low growl. He tries to get a hold of your body, so you guide him to your  torso as you begin bouncing up and down into his mighty rod, your body getting warmer as your breathing transformed into a ceaseless panting as more of his cock you were taking inside you.\n\n-You are a strong mate… I don’t feel shame by being fucked by the ones like you... - He says out loud, mixed with moanings as your back door entrances him more and more. His cock pulsates with every bounce as you feel your orgasm getting closer. You start playing with your  nipples until you feel your orgasm getting close. Without warning, you feel the wolf’s cock convulsing as he starts to cum inside you, filling your lusting hole with his hot and thick cream. You can feel it stuffing your insides at its peak as his cock poured in his fiery load.\n\nThe sensation of the wolf’s cum painting your rectum sends you over the edge, as you get to cum on your own, as your whole body trembles in pleasure as the orgasm hit you like a surge of heat through your whole body. Your " + dickSize + " cock spurted a streak of cum into the wolf’s chest, staining with your own jizz.\n\nWhen it finally passes, you pull out of his cock with a loud popping sound, streaks of cum dripping between your ass and into the ground beneath you. Your body is trembling as you walk away from your enemy, which keeps his head low, avoiding your gaze as you dress up once more and return to your city, before that wolf recover his forces and wants to enact his revenge.\n";


		} else if( GameControl.mcSex == GameControl.MCSex.Woman || GameControl.mcSex == GameControl.MCSex.Cuntboy && GameControl.charArmorTags [11] == true) {
			Board.text += "You undress your clothes and toss it aside, showing your "+ breasts +" breasts to your opponent. Your cunt is already moist by looking at your defeated enemy. The wolf is a bit puzzled by your actions as you sit on its lap and get to rub your asscheeks against his cock, making him squint by the softness that rubs over his wang. <i>“Do you want to mate on your terms, then?,”</i> you hear from him as you feel his throbbing cock getting harder with each rub. You wouldn’t let that opportunity to ride that cock until next week, so you only nod to his answer as you align your asshole with his dick.\n\nIt takes you a bit of effort, as you impale yourself in that big cock of his. You can feel its dick meat pushing itself inside your pucker, rubbing every part of your inner walls as it fills you completely. You can hear him moaning in a low tone, mixing it with a low growl. He tries to get a hold of your body, so you guide him to your torso as you begin bouncing up and down into his mighty rod, your body getting warmer as your breathing transformed into a ceaseless panting as more of his cock you were taking inside you.\n\n<i>“You are a strong mate… I don’t feel shame by being fucked by the ones like you... “</i> he says out loud, mixed with moanings as your back door entrances him more and more. His cock throbs with every bounce as you feel your orgasm getting closer. You start playing with your nipples until you feel your orgasm getting close. Without warning, you feel the wolf’s cock convulsing as he starts to cum inside you, filling your lusting backdoor with his hot and thick cream. You can feel it stuffing your insides at its peak as his cock poured in his fiery load.\n\nThe sensation of the wolf’s cum painting your rectum sends you over the edge, as you get to cum on your own, as your whole body trembles in pleasure as the orgasm hit you like a surge of heat through your whole body. Your pussy soaks the wolf’s chest with your vaginal juices, staining him with your scent.\n\nWhen it finally passes, you pull out of his cock with a loud popping sound, streaks of cum dripping between your asshole and into the ground beneath you. Your body is trembling as you walk away from your enemy, which keeps his head low, avoiding your gaze as you dress up once more and return to your city, before that wolf recover his forces and wants to enact his revenge.";
		}

	}

	public void Scene3(){
		if (GameControl.hasVagina == true) {
			mcPregnancy ();
		}
		GameControl.actualArousal = 0; 
		Board.text = "You can see that your enemy falls into the ground, his cock was soaked in its own precum as your opponent was jerking off furiously, trying to get himself off with no success. -Fuck… Must fill… Anything… Anyhow- He mumbles as his eyes were filled with lust as they focused on you, his huge balls throbbing and surely brimming with cum. You decided that it was time to be responsible of that situation, as you know that it can be a lot of fun.\n";
		if (GameControl.mcSex == GameControl.MCSex.Man  ) {
			if (GameControl.dick1Size > 0) {
				line1 = "Your enemy can also see your "+ dickSize+ " dick, pointing at him, totally erect.";
			} else {
				line1 = "";
			}
	
			Board.text += "You undress your "  +  clothes + "before that wolf torn it out, as you can see that it was his plan if you give him the chance. As you got naked, you expose your pussy and "  +  breasts + "to your opponent. "+ line1 +" Your enemy is getting wilder and wilder as you keep teasing him. So you got closer enough and sat into the ground in front of him, spreading your legs and presenting him your wet snatch. The scent of it makes him roar and he jumps over you in a frenzy, rubbing its cock all over your belly, soaking you in its precum.\n\nAfter a second, he grabs you with its wolf arms and holds you in place as he thrust his cock inside you with savagery. He didn’t stop for anything, wanting nothing more than ram his cock inside you unceasingly. You can feel its urge to fill you with his cum until you can no longer walk on your own. You can feel his cock invading your nether lips over and over, his lust-frenzy making him increase his speed, fucking you like a madman. -Must fill… fill, fill, fill...- Before you can say anything, he groans as he cums, filling your belly with its hot sperm. And with that, you cum too, your body trembling as your cunt milked him out for all he’s worth.  You can feel it filling your womb without delay. But he didn’t stop fucking your hole, his brutal pounding of your pussy seems never ending.\n\nBefore you can say anything else, you feel him cumming once more, pushing more and more cum inside your womb. You can see how your belly was distended, a bulge was being formed as the spunk of your opponent wasn’t spilling out of you, as he is not stopping. You see the face of your enemy, which is still full of lust, as he keeps his thrusting at the same merciless frequency. You are moaning nonstop, as the werewolf’s cock is driving you mad with lust. You can feel him cumming once more, distending your belly to the point that it was quite visible for both of you. \n\nYou feel as if you were about to pop, as the wolf finally cum one last time before getting exhausted. This time, it started to leak through the sides of his cock, his sperm dripping into the floor like a non-stop rivulet of cream out of your pussy. You can see how your opponent finally falls into his back, completely exhausted. You see that the bulge was slowly receding, a huge amount of sperm was spilling in the floor, slowly deflating your stomach until it got small enough for you to rise from the ground. Your legs were completely drenched in your enemy fluids and your belly was sore from holding all that cum, but you grabbed your clothings and decided that you would dress in the way of the city, before that enemy decided that it has still a bit of semen in his testicles.\n";

		} else if ( GameControl.mcSex == GameControl.MCSex.Woman || GameControl.mcSex == GameControl.MCSex.Cuntboy  && GameControl.charArmorTags [11] == false ){

			Board.text += "You undress your "  +  clothes + "before that wolf torn it out, as you can see that it was his plan if you give him the chance. As you got naked, you expose your asshole and "  +  breasts + "to your opponent. Your enemy can also see your "+ dickSize+ " dick, pointing at him, totally erect. Your enemy is getting wilder and wilder as you keep teasing him. So you got closer enough and sat into the ground in front of him, spreading your legs and presenting him your tight hole. The sight of it makes him roar and he jumps over you in a frenzy, rubbing its cock all over your belly, soaking you in its precum.\n\nAfter a second, he grabs you with its wolf arms and holds you in place as he thrust his cock inside you with savagery. He didn’t stop for anything, wanting nothing more than ram his cock inside your pucker unceasingly. You can feel its urge to fill you with his cum until you can no longer walk on your own. You can feel his cock invading your rectum over and over, his lust-frenzy making him increase his speed, fucking you like a madman. -Must fill… fill, fill, fill...- Before you can say anything, he groans as he cums, filling your belly with its hot sperm. And with that, you cum too, your body trembling as your back door milked him out for all he’s worth.  You can feel it filling your colon without delay. But he didn’t stop fucking your hole, his brutal pounding of your ass seems never ending.\n\nBefore you can say anything else, you feel him cumming once more, pushing more and more cum inside your asshole. You can see how your belly was distended, a bulge was being formed as the spunk of your opponent wasn’t spilling out of you, as he is not stopping. You see the face of your enemy, which is still full of lust, as he keeps his thrusting at the same merciless frequency. You are moaning nonstop, as the werewolf’s cock is driving you mad with lust. You can feel him cumming once more, distending your belly to the point that it was quite visible for both of you. \n\nYou feel as if you were about to pop, as the wolf finally cum one last time before getting exhausted. This time, it started to leak through the sides of his cock, his sperm dripping into the floor like a non-stop rivulet of cream out of your asshole. You can see how your opponent finally falls into his back, completely exhausted. You see that the bulge was slowly receding, a huge amount of sperm was spilling in the floor, slowly deflating your stomach until it got small enough for you to rise from the ground. Your legs were completely drenched in your enemy fluids and your belly was sore from holding all that cum, but you grabbed your clothings and decided that you would dress in the way of the city, before that enemy decided that it has still a bit of semen in his testicles.\n";
			charVirginity ();

		}else if ( GameControl.mcSex == GameControl.MCSex.Woman || GameControl.mcSex == GameControl.MCSex.Cuntboy  && GameControl.charArmorTags [11] ==true ){

			Board.text = "You undress your clothes before that wolf torn it out, as you can see that it was his plan if you give him the chance. As you got naked, you expose your asshole and "+ breasts +" to your opponent. Your enemy can also see your pussy, getting wet due to anticipation of what you know it’s going to happen. Your enemy is getting wilder and wilder as you keep teasing him. So you got closer enough and sat into the ground in front of him, spreading your legs and presenting him your tight anus, yet covering your cunt. The sight of it makes him roar and he jumps over you in a frenzy, rubbing its cock all over your belly, soaking you in its precum.\n\nAfter a second, he grabs you with its wolf arms and holds you in place as he thrust his cock inside your asshole with savagery. He didn’t stop for anything, wanting nothing more than ram his cock inside your pucker unceasingly. You can feel its urge to fill you with his cum until you can no longer walk on your own. You can feel his cock invading your rectum over and over, his lust-frenzy making him increase his speed, fucking you like a madman. <i>“Must fill… fill, fill, fill…”</i> Before you can say anything, he groans as he cums, filling your belly with its hot sperm. And with that, you cum too, your pussy unloading its juices into your thighs as your back door milked him out for all he’s worth.  You can feel it filling your colon without delay. But he didn’t stop fucking your hole, his brutal pounding of your ass seems never ending.\n\nBefore you can say anything else, you feel him cumming once more, pushing more and more cum inside your asshole. You can see how your belly was distended, a bulge was being formed as the spunk of your opponent wasn’t spilling out of you, as he is not stopping. You see the face of your enemy, which is still full of lust, as he keeps his thrusting at the same merciless frequency. You are moaning nonstop, as the werewolf’s cock is driving you mad with lust. You can feel him cumming once more, distending your belly to the point that it was quite visible for both of you. \n\nYou feel as if you were about to pop of how full you are, as the wolf finally cum one last time before getting exhausted. This time, it started to leak through the sides of his cock, his sperm dripping into the floor like a non-stop rivulet of cream out of your asshole. You can see how your opponent finally falls into his back, completely exhausted. You see that the bulge was slowly receding, a huge amount of sperm was spilling in the floor, slowly deflating your stomach until it got small enough for you to rise from the ground. Your legs were completely drenched in your enemy fluids mixed with your own and your belly was sore from holding all that cum, but you grabbed your clothings and decided that you would dress in the way of the city, before that enemy decided that it has still a bit of semen in his testicles.";


		}

	}


	void mcPregnancy()
	{
		if (GameControl.fertile == true && GameControl.isPregnant == false) {
			Random.InitState(System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 100);

			if (GameControl.fertileVery == true) {
				if (randNum > 70) {
					GameControl.pregnantCounter = 10; 
					GameControl.isPregnant = true; 
					GameControl.pregnantText = "You can feel how your distended womb is thrashing and moving inside you, and somehow you can feel that the birth is at hand, so you call for your servants to help you with this event. You can feel how your water breaks when you are walking to your bedroom, being helped by your servants until you’re finally laying in your bed.\n\nYou can feel how the little creature is pushing against your cervix, as you feel the instinctive urge to push your insides out, while you try to calm down a bit and continue the labour. The servants panic, as they aren’t sure how much time will be before the midwife arrives, even when some of them have been on some births before this one. It would be funny if you didn’t feel like your insides are being torn by that creature, as if it’s clawing its way out.\n\nWhen the midwife arrives, she takes control of the situation and helps you to go through with the birth, You can feel how the product advances through your cervix all the way into your vagina in a couple of hours. You push and breathe with the best of your ability, as you can feel how it's head shows as it stretches your cunt even more than his father did at the time.\n\nYou grit your teeth as your child finally pushes its path to freedom, as you can feel your body relaxing after giving birth to it, as you try to catch your breath. You can see that the child has a small tail and its ears are higher than normal, definitely is a wolf’s child. After knowing that, you finally blackout from exhaustion. You sleep for what you feel are like days, but you finally woke up and see that you are already clean, probably the servants took the time to wash you in your bed, almost as if nothing have happened.\n"; 

				}
			} else {
				if (randNum > 85) {
					GameControl.pregnantCounter = 10; 
					GameControl.isPregnant = true; 
					GameControl.pregnantText = "You can feel how your distended womb is thrashing and moving inside you, and somehow you can feel that the birth is at hand, so you call for your servants to help you with this event. You can feel how your water breaks when you are walking to your bedroom, being helped by your servants until you’re finally laying in your bed.\n\nYou can feel how the little creature is pushing against your cervix, as you feel the instinctive urge to push your insides out, while you try to calm down a bit and continue the labour. The servants panic, as they aren’t sure how much time will be before the midwife arrives, even when some of them have been on some births before this one. It would be funny if you didn’t feel like your insides are being torn by that creature, as if it’s clawing its way out.\n\nWhen the midwife arrives, she takes control of the situation and helps you to go through with the birth, You can feel how the product advances through your cervix all the way into your vagina in a couple of hours. You push and breathe with the best of your ability, as you can feel how it's head shows as it stretches your cunt even more than his father did at the time.\n\nYou grit your teeth as your child finally pushes its path to freedom, as you can feel your body relaxing after giving birth to it, as you try to catch your breath. You can see that the child has a small tail and its ears are higher than normal, definitely is a wolf’s child. After knowing that, you finally blackout from exhaustion. You sleep for what you feel are like days, but you finally woke up and see that you are already clean, probably the servants took the time to wash you in your bed, almost as if nothing have happened.\n"; 

				}

			}


		} 

	}//


	void Start (){

		CityControl.city100Slaves[1] += 1;

	}



	void charVirginity(){

		if(GameControl.isVirgin == true){
			Board.text += "\n\nYour character lost its virginity!";
			GameControl.isVirgin = false; 
		}

	}






}
