using UnityEngine;
using System.Collections;
using UnityEngine.UI; 


public class EquineScene : MonoBehaviour {

	int randNum; 

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
		panTurnEnd.SetAsLastSibling ();
		GameControl.actualArousal = 0; 
		Board.text = "You finally defeat the mighty and proud stallion, as you see him falling to his knees in front of you, definitely exhausted from the combat. He is now so different from what he looks like usually, probably because all his confidence is gone. You feel a strong sense of power over him, and with it an idea of how to teach him a lesson.";

		if ( GameControl.mcSex == GameControl.MCSex.Woman || GameControl.mcSex == GameControl.MCSex.Cuntboy ) {
			Board.text += "You quickly undress your " + clothes + " and wear your strap-on, as you don’t know what is the stallion capable of doing even in that state, exposing your your pussy, moist from the lust combat and the sight of your enemy defeated. Your enemy turns to all his fours, trying to escape, but you only see his athletic ass tensing every time he tries to crawl away from you.\n\n\nYou stroke your strap and spit on it, soaking it in your saliva as you walk close to him and grab his firm ass for a bit, as you see him stopping on his tracks, moving his tail slowly from its way, presenting his ass to you. Perhaps this stallion is more perverted of what you originally thought. You open his buttocks, exposing his tight little asshole, pressing your dick against its crown as the stallion looks in the other way as you can see that his own cock starts getting hard from your ministrations.\n\n\nYou think that your spit is enough as you push yourself inside his asshole, as you see his buttocks pressing against the dildo as it slides inside him. You can seehow his asshole engulfs the strap-on with eagerness, as you start to increase the pace on how you’re fucking his ass. You can see that he tries to contain the pleasure that he is feeling, probably trying to conserve some of his pride, so you start slapping his well-toned ass from time to time, hearing some low whinning at first, but when your groins starts to smack his buttocks as you reach farther into his ass, you can hear him moaning more and more, his pride crumbling below the pleasure that it’s probably unleashing inside him.\n\n\nYou push his back to the front as you keep his rear up high, and place yourself as if you are mounting him. Your firm dildo rubs against his insides more and more, the stallion starts to scream in delight as his ass is being reamed by you, turning him from the proud horseman into a puddle of moans and fluids, as his own cock has made a large puddle of precum in the floor below him.\n\n\nWhen you finally feel yourself at the brink of your orgasm, you grab his arms and pull them to use them as leverage as you push your strap-on as deep as you can while you reach your orgasm, your own cunt trembling as you cum hard. As you soak your own thighs from your own cumming, you can hear him cry out loud in ecstasy as he has his own orgasm, spilling a lot of horse cum into the floor below him, soaking his own legs.\n\n\nYou can see how his anus convulses around your dildo, its crown pressing around it as it tried to hold it in place. You can see him not moving from where he is right now, probably from the shame of enjoying such a humiliating act over him. You pull out of him as you spank him one last time, before leaving the place before he regains his strength and tries to retaliate.\n"; 

		}
		else if (GameControl.mcSex == GameControl.MCSex.Man    && GameControl.charArmorTags[11] == false) 
		{
			if (GameControl.testiclesSize > 0) {
				line1 = " and your pair of "+ ballsSize +" balls";
			} else {
				line1 = "";
			}

			if (GameControl.hasVagina == true) {
				line2 = ", alongside your pussy, moist from the lust combat and the sight of your enemy defeated";
			} else {
				line2 = "";
			}

			Board.text += "You quickly undress your " + clothes + ", as you don’t know what is the stallion capable of doing even in that state, exposing your "+ dickSize +" "+ dick +" cock, "+ line1 +" "+ line2+ ". Your enemy turns to all his fours, trying to escape, but you only see his athletic ass tensing every time he tries to crawl away from you.\n\n\nYou stroke your cock, soaking it in your precum as you walk close to him and grab his firm ass for a bit, as you see him stopping on his tracks, moving his tail slowly from its way, presenting his ass to you. Perhaps this stallion is more perverted of what you originally thought. You open his buttocks, exposing his tight little asshole, pressing your cock against its crown as the stallion looks in the other way as you can see that his own cock starts getting hard from your ministrations.\n\n\nYou think that your precum is enough as you push yourself inside his asshole, as you feel his buttocks pressing against your cock as it slides inside him. You can feel how his insides feel warm and inviting, as you start to increase the pace on how you’re fucking his ass. You can see that he tries to contain the pleasure that he is feeling, probably trying to conserve some of his pride, so you start slapping his well-toned ass from time to time, hearing some low whinning at first, but as your groin starts to smack his buttocks as you reach farther into his ass, you can hear him moaning more and more, his pride crumbling below the pleasure that he is feeling at the moment.\n\n\nYou push his back to the front as you keep his rear up high, and place yourself as if you are mounting him. Your throbbing cock rubs against his insides more and more, as the stallion starts to scream in delight as his ass is being reamed by your hot dick, turning him from the proud horseman into a puddle of moans and fluids, as his own cock has made a large puddle of precum in the floor below him.\n\n\nWhen you finally feel yourself at the brink of your orgasm, you grab his arms and pull them to use them as leverage as you push your cock as deep as you can as you reach your orgasm, cumming inside the stallion with force, his pulsating cock pouring its load on the inner walls of him, painting them white. As you start filling him up, you can hear him cry out loud in ecstasy as he has his own orgasm, spilling a lot of horse cum into the floor below him, soaking his own legs.\n\n\nYou can feel how his anus convulses around your cock, its crown pressing around it as it tried to hold it in place as you finally let out the final drops of your jizz inside his hungry asshole. You can see him not moving from his place, probably from the shame of enjoying such a humilliating act over him. You pull out of him as you spank him one last time, before leaving the place before he regains his strength and tries to retaliate.\n";
			charVirginity ();

		}else if (GameControl.mcSex == GameControl.MCSex.Man    && GameControl.charArmorTags[11] == true) {
			if (GameControl.testiclesSize > 0) {
				line1 = " and your pair of "+ ballsSize +" balls";
			} else {
				line1 = "";
			}

			if (GameControl.hasVagina == true) {
				line2 = ", alongside your pussy, moist from the lust combat and the sight of your enemy defeated";
			} else {
				line2 = "";
			}

			Board.text += "You quickly undress your clothes and take your dildo from your clothing, as you don’t know what is the stallion capable of doing even in that state, exposing your "+ dickSize +" cock,"+ line1 +""+ line2+". Your enemy turns to all his fours, trying to escape, but you only see his athletic ass tensing every time he tries to crawl away from you.\n\nYou ready your big dildo and spit on it, soaking it in your saliva as you walk close to him and grab his firm ass for a bit, as you see him stopping on his tracks, moving his tail slowly from its way, presenting his ass to you. Perhaps this stallion is more perverted of what you originally thought. You open his buttocks, exposing his tight little asshole, pressing your dick against its crown as the stallion looks in the other way as you can see that his own cock starts getting hard from your ministrations.\n\nYou think that your spit is enough as you push the sex toy inside his asshole, as you see his buttocks pressing against the dildo as it slides inside him. You can see how his asshole engulfs it with eagerness, as you start to increase the pace on how you’re fucking his ass. You can see that he tries to contain the pleasure that he is feeling, probably trying to conserve some of his pride, so you start slapping his well-toned ass from time to time, hearing some low whining at first, but when your groins starts to smack his buttocks as you reach farther into his ass, you can hear him moaning more and more, his pride crumbling below the pleasure that it’s probably unleashing inside him.\n\nYou push his back to the front as you keep his rear up high, and place yourself as if you are mounting him. Your push your firm dildo against his insides more and more, the stallion starts to scream in delight as his ass is being reamed by you, turning him from the proud horseman into a puddle of moans and fluids, as his own cock has made a large puddle of precum in the floor below him.\n\nYou start to masturbate with one hand, matching the speed of the other, and when you finally feel yourself at the brink of your orgasm, you insert the sex toy as deep as you can. Both of you cum, bathing in each others cum. When your balls and his are spent, you take your equipment and move away, leaving the poor stallion drenched in your victory fluids. \n";
		}

	}


	//COCK RIDE VICTORY - Stallion(Chapter1), Ride Cock,
	public void Scene2(){
		panTurnEnd.SetAsLastSibling ();

		GameControl.actualArousal = 0; 
		Board.text = "After a complicated combat, you finally defeat your equine enemy. He lays into the ground, without any will to fight you further. You can see how he is stroking his cock, full of unspent lust, trying in vain to sate his desire to fuck something. You can see his enormous cock throbbing in his hand, leaking precum each time he stroke it with frustration. You can’t let such amazing cock go without the attention it deserves.";
		if ( GameControl.mcSex == GameControl.MCSex.Woman || GameControl.mcSex == GameControl.MCSex.Cuntboy && GameControl.charArmorTags[11] == false) {
			Board.text += "You slowly undress your clothes, enjoying the frustration the horse is feeling when just a couple of minutes ago, he was so full of himself. You walk in his direction and place one of your feet over his chest and force him to lay on his back, making him to focus its attention on you. <i>”This is wrong! I’m the one supposed to be taming you, not the opposite!”</i> he says as it tries to fight back, but it’s useless. You tell him that if he behaves, he’ll get a good treatment.\n\nYou can see that he stays silent after you say that, perhaps because he knows what he is capable of, or maybe is because his twitching cock standing proud between his legs is helping you to persuade him. You slap his cock a bit, just to see how hard it is, as you can see him moan a bit from the rough touch.\n\nAfter that, you sit in his lap, pressing your ass against his equine dick, your pussy pushing against his belly, your fluids staining him. You can feel his precum sliding from the tip of his cock into your buttocks, as you know that his shaft is soaked in his own juices, so you press the entrance of your cunt against the tip of his cock, teasing him slowly as you can see the frustration in his eyes.\n\n<i>“Stop teasing me… Do it now!”</i> You enjoy how the proud stallion is finally asking for the things he wants. So, you keep teasing him with your pussy, your hole yielding just a bit so he can feel your warm insides for a second. He tries to grab your hips, but you use your hands and push them back into his place. You can see him panting, his eyes filling with an ever greater lust than before. <i>“Let me in… Please!”</i>\n\nWhen you heard how he plead for him, you finally oblige him, as you push yourself over his cock, slowly engulfing it with your asshole as far as you can, helping yourself with your arms to bounce all over his groin.\n\nThe sensation of the pulsating cock of the horse is amazing, you could swear that it’s getting bigger inside you, as if his loss of control made his cock fill even more than the usual. Probably he is used to set the pace, but you’ll show him what it feels to be on the other side of the domination. You increase the pace over his cock just to go slower after a bit, as you can see that the stallion is drowning in sweat, his body trembling from the need of release, as even his balls churn from time to time, pleading to cum just as much as him. <i>“I need to cum! Let me cum!”</i> he pleads, as you engulf his cock again and again, enjoying both his cockmeat and his face in that moment.\n\nAfter a couple of minutes of pleasure of playing with your equine enemy, you know that your own orgasm is building in your pussy, so you increase your bouncing until you feel your cumming hitting you like a landslide, your whole body trembling as your pussy juice flows like a small river from your cunt to his cock and belly,, staining him with your own vaginal juices, as you can feel how his cock explodes in his own orgasm, as he starts to unleash a big load of his equine semen inside your pucker, as your rectum walls enjoy milking him until you feel satisfied with his performance.\n\nWhen you see the face of the stallion, completely spent and all covered in your cum, you pull out of his cock, as it's covered in his own jizz. You tell him that he shouldn’t resist, just as he would say in his situation, but you see that he is barely hearing you. So, you take your clothings and return to the city.\n";
			charVirginity ();
			mcPregnancy ();
		} else if (GameControl.mcSex == GameControl.MCSex.Man   ) {


			if (GameControl.hasVagina == true) {
				line1 = ", as your pussy rubs itself and taints him with your juices";
			} else {
				line1 = "";
			}

			Board.text += "You slowly undress your clothes, enjoying the frustration the horse is feeling when just a couple of minutes ago, he was so full of himself. You walk in his direction and place one of your feet over his chest and force him to lay on his back, making him to focus its attention on you. <i>”This is wrong! I’m the one supposed to be taming you, not the opposite!”</i> he says as it tries to fight back, but it’s useless. You tell him that if he behaves, he’ll get a good treatment.\n\nYou can see that he stays silent after you say that, perhaps because he knows what he is capable of, or maybe is because his twitching cock standing proud between his legs is helping you to persuade him. You slap his cock a bit, just to see how hard it is, as you can see him moan a bit from the rough touch.\n\nAfter that, you sit in his lap, pressing your ass against his equine dick, your own dick pushing against his belly, your precum staining him"+ line1 +". You can feel his precum sliding from the tip of his cock into your buttocks, as you know that his shaft is soaked in his own juices, so you press the crown of your asshole against the tip of his cock, teasing him slowly as you can see the frustration in his eyes.\n\n<i>“Stop teasing me… Do it now!”</i> You enjoy how the proud stallion is finally asking for the things he wants. So, you keep teasing him with your pucker, your entrance yielding just a bit so he can feel your warm insides for a second. He tries to grab your hips, but you use your hands and push them back into his place. You can see him panting, his eyes filling with an ever greater lust than before. <i>“Let me in… Please!”</i>\n\nWhen you heard how he plead for him, you finally oblige him, as you push yourself over his cock, slowly engulfing it with your asshole as far as you can, helping yourself with your arms to bounce all over his groin.\n\nThe sensation of the pulsating cock of the horse is amazing, you could swear that it’s getting bigger inside you, as if his loss of control made his cock fill even more than the usual. Probably he is used to set the pace, but you’ll show him what it feels to be on the other side of the domination. You increase the pace over his cock just to go slower after a bit, as you can see that the stallion is drowning in sweat, his body trembling from the need of release, as even his balls churn from time to time, pleading to cum just as much as him. <i>“I need to cum! Let me cum!”</i> he pleads, as you engulf his cock again and again, enjoying both his cockmeat and his face in that moment.\n\nAfter a couple of minutes of pleasure of playing with your equine enemy, you know that your own orgasm is building in your own cock, so you increase your bouncing until you feel your cumming hitting you like a landslide, your whole body trembling as your cock spurts its gooey contents all over the face and body of the equine that is in front of you, staining him with your own spunk, as you can feel how his cock explodes in his own orgasm, as you can feel how he starts to unleash a big load of his equine semen inside your pucker, as your rectum walls enjoy milking him until you feel satisfied with his performance.\n\nWhen you see the face of the stallion, completely spent and all covered in your cum, you pull out of his cock, as it's covered in his own jizz. You tell him that he shouldn’t resist, just as he would say in his situation, but you see that he is barely hearing you. So, you take your clothings and return to the city.";


		}else if ( GameControl.mcSex == GameControl.MCSex.Woman || GameControl.mcSex == GameControl.MCSex.Cuntboy && GameControl.charArmorTags[11] == true) {
			Board.text += "You slowly undress your clothes, enjoying the frustration the horse is feeling when just a couple of minutes ago, he was so full of himself. You walk in his direction and place one of your feet over his chest and force him to lay on his back, making him to focus its attention on you. <i>”This is wrong! I’m the one supposed to be taming you, not the opposite!”</i> he says as it tries to fight back, but it’s useless. You tell him that if he behaves, he’ll get a good treatment.\n\nYou can see that he stays silent after you say that, perhaps because he knows what he is capable of, or maybe is because his twitching cock standing proud between his legs is helping you to persuade him. You slap his cock a bit, just to see how hard it is, as you can see him moan a bit from the rough touch.\n\nAfter that, you sit in his lap, pressing your] ass against his equine dick, your pussy rubbing itself against his belly and staining him with your juices. You can feel his precum sliding from the tip of his cock into your buttocks, as you now know that his shaft is soaked in his own juices, so you press the crown of your asshole against the tip of his cock, teasing him slowly as you can see the frustration in his eyes.\n\n<i>“Stop teasing me… Do it now!”</i> You enjoy how the proud stallion is finally asking for the things he wants. So, you keep teasing him with your pucker, your entrance yielding just a bit so he can feel your warm insides for a second. He tries to grab your hips, but you use your hands and push them back into his place. You can see him panting, his eyes filling with an ever greater lust than before. <i>“Let me in… Please!”</i>\n\nWhen you heard how he plead for him, you finally oblige him, as you push yourself over his cock, slowly engulfing it with your asshole as far as you can, helping yourself with your arms to bounce all over his groin.\n\nThe sensation of the pulsating cock of the horse is amazing, you could swear that it’s getting bigger inside you, as if his loss of control made his cock fill even more than the usual. Probably he is used to set the pace, but you’ll show him what it feels to be on the other side of the domination. You increase the pace over his cock just to go slower after a bit, as you can see that the stallion is drowning in sweat, his body trembling from the need of release, as even his balls churn from time to time, pleading to cum just as much as him. <i>“I need to cum! Let me cum!”</i> he pleads, as you engulf his cock again and again, enjoying both his cockmeat and his face in that moment.\n\nAfter a couple of minutes of pleasure of playing with your equine enemy, you know that your own orgasm is building in your cunt, so you increase your bouncing until you feel your cumming hitting you like a landslide, your whole body trembling as your pussy soaks the belly of the enemy in front of you, staining him with your own femspunk, as you can feel how his cock explodes in his own orgasm, as he starts to unleash a big load of his equine semen inside your pucker, as your rectum walls enjoy milking him until you feel satisfied with his performance.\n\nWhen you see the face of the stallion, completely spent and all covered in your cum, you pull out of his cock, as it's covered in his own jizz. You tell him that he shouldn’t resist, just as he would say in his situation, but you see that he is barely hearing you. So, you take your clothings and return to the city.";

		}

	}



	//. ORAL VICTORY - Stallion(Chapter1), button3,

	public void Scene3(){
		panTurnEnd.SetAsLastSibling ();

		GameControl.actualArousal = 0; 
		Board.text = "You finally defeat your opponent, playing with his lust against him, as you can see the stallion falling to his knees, jerking his cock furiously, trying to satisfy his increasing lust, effort that wasn't working as expected, his tongue flailing out from the frustration that accumulated during the combat.\n\nYou know that he will do anything you want at this point, his mind completely clouded by the lust that is slowly consuming him and making him moan like an animal in heat, and he wasn't that far from that, snorting with force as he pinched his own balls with force, causing him pain but his face shows otherwise.";
		if ( GameControl.mcSex == GameControl.MCSex.Woman || GameControl.mcSex == GameControl.MCSex.Cuntboy) {
			Board.text += "You remove your clothes and expose your pussy, already moist from the urge that the stallion is showing. You can see that his hands are still jerking himself off, so you thought that you can make his mouth a little more busy. You take his head with both hands and press your cunt  against his mouth without much trouble, as you can feel his tongue pushing against your pussy, still craving for any kind of relief.\n\nYou push your hips against his face by pulling his hair, as the stallion’s long tongue thrust inside his cunt, playing with your inner walls as he continues stroking his enormous dick. You can see that the rough treatment that you are causing to him, is only making him harder. At the start, you use your hands to force his lips against your twat as he keeps licking your nether lips, but after a couple of seconds, you feel how his tongue starts to stroke your clit with a sense of desire, as his lust is talking for him. You take off your hands of his head, as the stallion licks your pussy non-stop. His eyes are rolling into the back of his head, as his wet slurping noises fill your ears, while he sucks your sex juices like a vacuum.\n\nAfter a couple of minutes, you can feel how you are getting on the edge of orgasm, so you grab his head once more and push your groin as far as you can, as you finally cum with all your unspent lust. Your vaginal juices flow through your pussy and soak his face and tongue, as you can see his face turning into one of pure pleasure, even though he is being treated like a cheap whore.\n\nAt the same time, you can see how his own cock cums hard by your facefuck, unloading his stallion’s jizz all over himself, staining his legs and belly as your orgasm finally ends soaking his face. After that, his tongue relaxes as you push him against his own back as he keeps touching his cock from time to time, lost in a world of pleasure that is far away from the reality. You dress once more, leaving the stallion to feel defeated for a bit longer.\n";

		} else if (GameControl.mcSex == GameControl.MCSex.Man  ) {


			if (GameControl.hasVagina == true) {
				line1 = ", alongside your pussy, already moist from the urge that the stallion is showing";
			} else {
				line1 = "";
			}

			if (GameControl.testiclesSize > 0) {
				line2 = " and your pair of " + ballsSize + " testicles";
			} else {
				line2 = "";
			}

			Board.text += "You remove your clothes and expose your " + dickSize + " shaft," + line2 + "" + line1 + ". You can see that his hands are still jerking himself off, so you thought that you can make his mouth a little more busy. You take his head with both hands and push your cock against his mouth, forcing it inside without much trouble, as his warm mouth gladly admit it as his face is still craving for any kind of relief.\n\nYou push your hips against his face by pulling his hair, as the stallion’s tongue wraps around your cockflesh, playing with it as he continues stroking his enormous dick. You can see that the rough treatment that you are causing to him, is only making him harder. At the start, you use your hands to bob his head in and out of your manhood, but after a couple of seconds, you feel how his tongue starts to stroke your cock with a sense of desire, as his lust is talking for him. You take off your hands of his head, as the stallion engulfs your dick again and again. His eyes are rolling into the back of his head, as his wet slurping noises fill your ears, while he sucks your precum like a vacuum.\n\nAfter a couple of minutes, you can feel how you are getting on the edge of orgasm, so you grab his head once more and push your cock as far as you can, as you finally cum with all your unspent lust. Your cock spurts your load inside his throat and back of his mouth, as you can see his face turning into one of pure pleasure, even though he is being treated like a cheap whore.\n\nAt the same time, you can see how his own cock cums hard by your facefuck, unloading his stallion’s jizz all over himself, staining his legs and belly as you pour the last of your cum inside the stallion’s needy mouth. After that, his tongue relaxes as you pull out your cock from his mouth as he keeps touching his cock from time to time, lost in a world of pleasure that is far away from the reality. You dress once more, leaving the stallion to feel defeated for a bit longer.";


		} 

	}




	void mcPregnancy()
	{
		if (GameControl.fertile == true) {
			Random.InitState(System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 100);

			if (GameControl.fertileVery == true) {
				if (randNum > 70) {
					GameControl.pregnantCounter = 10; 
					GameControl.isPregnant = true; 
					GameControl.pregnantText = "You can feel how your gigantic womb is thrashing and moving inside you, and somehow you can feel that the birth is at hand, so you call for your servants to help you with this event. You can feel how your water breaks when you are walking to your bedroom, being helped by your servants until you’re finally laying in your bed.\n\nYou can feel how the little creature is pushing against your cervix, as you feel the instinctive urge to push your insides out, as you try to calm down a bit and continue the labour. The servants panic, as they aren’t sure how much time will be before the midwife arrives, even when some of them have been on some births before this one. It would be funny if you didn’t feel like your insides are being torn by that creature.\n\nWhen the midwife arrives, she takes control of the situation and helps you to go through with the birth, You can feel how the product advances through your cervix all the way into your vagina in a couple of hours. You push and breathe with the best of your ability, as you can feel how its head shows as it stretches your cunt even more than his father did at the time.\n\nYou grit your teeth as your child finally pushes its path to freedom, as you can feel your body relaxing after giving birth to it, as you try to catch your breath. You can see that the child is quite big and his legs ended in hooves, definitively a stallion’s child. After knowing that, you finally blackout from exhaustion. You sleep for what you feel are like days, but you finally woke up and see that you are already clean, probably the servants took the time to wash you in your bed, almost as if nothing have happened."; 

				}
			} else {
				if (randNum > 85) {
					GameControl.pregnantCounter = 10; 
					GameControl.isPregnant = true; 
					GameControl.pregnantText = "You can feel how your gigantic womb is thrashing and moving inside you, and somehow you can feel that the birth is at hand, so you call for your servants to help you with this event. You can feel how your water breaks when you are walking to your bedroom, being helped by your servants until you’re finally laying in your bed.\n\nYou can feel how the little creature is pushing against your cervix, as you feel the instinctive urge to push your insides out, as you try to calm down a bit and continue the labour. The servants panic, as they aren’t sure how much time will be before the midwife arrives, even when some of them have been on some births before this one. It would be funny if you didn’t feel like your insides are being torn by that creature.\n\nWhen the midwife arrives, she takes control of the situation and helps you to go through with the birth, You can feel how the product advances through your cervix all the way into your vagina in a couple of hours. You push and breathe with the best of your ability, as you can feel how its head shows as it stretches your cunt even more than his father did at the time.\n\nYou grit your teeth as your child finally pushes its path to freedom, as you can feel your body relaxing after giving birth to it, as you try to catch your breath. You can see that the child is quite big and his legs ended in hooves, definitively a stallion’s child. After knowing that, you finally blackout from exhaustion. You sleep for what you feel are like days, but you finally woke up and see that you are already clean, probably the servants took the time to wash you in your bed, almost as if nothing have happened."; 

				}

			}


		} 

	}//



	void Start (){
		CityControl.city100Slaves[3] += 1;
		Board.text = "What you want to do to the stallion? For the second scene you need to increase his lust up to 50 during battle. For the third one you need to defeat him with lust!";

	}


	void charVirginity(){

		if(GameControl.isVirgin == true){
			Board.text += "\n\nYour character lost its virginity!";
			GameControl.isVirgin = false; 
		}

	}






}
