using UnityEngine;
using System.Collections;

public class AlbaSexSceneCasual {

	static int iAlba; 

	public static string sexScene1(){
		loadAlba ();
		string toRet = "You spent an entire day thinking on where to take Alba on a date. Thought of a few restaurants and even dig up some bars, to see what she would like. Yet, at the end of all that mess, you figured she always took you to where she pleased, and decided on a simple place this time: a lake. You’ve heard the lake was a popular place for couples to hang out, and decided it was good enough, after all maybe neither of you would arrive to it.\n \nYou told Alba about it and she agreed. To your surprise, not only did she not take you somewhere else but also the place was deserted. You look at her with intrigue in your eyes and she smiles at you with pride.\n \n<i>“When I heard you wanted to take me here I had to make a few arrangements. The people that come here are not usually to my liking so I decided to rent the entire place for ourselves. Call it what you will, I just didn’t want any prude around. Besides I am in the mood for a swim.”</i> Saying that Alba took her clothes off and enter the lake, you followed after her.\n \nAfter swimming for hours you came back to the shore and drank all the beer you had brought for her. It was her who did most of the drinking anyway, making you glad you’d found out her favorite brand.";

		if (NPCCharList.CharFollower [iAlba].dickSize > 0) {
			toRet += "\n\nYou saw her there, drinking all she could while droplets of water slid over her body, guiding your eyes towards the dick you´ve given her before. Still as desirable as ever. Your mind wondered a bit before you heard her talking.";
		}

		toRet += "\n\n<i>“This was, very out of what we are used to. Nice and all but, not really my thing.”</i> You figured as much. This place lacked the aggressiveness Alba loves, but she must have had a reason for coming despite of that. <i>“It was nice to relax after all the new business my machines are getting me. But, you know? We can still do something else to salvage this day.”</i> You chuckle, knowing full well what she means.";

		if (GameControl.hasVagina) {
			toRet += "\n\nLuckily you came prepared. It only took you a few seconds to go and fetch your strap-on. You adjusted it and went back to Alba.";
		}

		if (NPCCharList.CharFollower [iAlba].dickSize > 0) {
			toRet += "\n\nYou were ready to please her, and she could tell right away. You placed yourself on top of her and kissed her, groping her still wet boobs. She rested her arms on your back and let you kiss her neck and chest. You squished one of her boobs, sucking on it while your fingers slid inside her cunt. You made sure to stimulate her dick while your middle and index finger made enough space inside her for you to enter.";
		} else {
			toRet += "\n\nYou were ready to please her, and she could tell right away. You placed yourself on top of her and kissed her, groping her still wet boobs. She rested her arms on your back and let you kiss her neck and chest. You squished one of her boobs, sucking on it while your fingers slid inside her cunt. You made sure to stimulate her clit while your middle and index finger made enough space inside her for you to enter.";
		}

		if (GameControl.dick1Size > 0) {
			toRet += "\n\nYour dick was growing harder as you touched her, twitching with every moan she made.";
		}
		if (NPCCharList.CharFollower [iAlba].dickSize > 0) {
			toRet += "\n\nAlba´s dick reacted not only to your caresses but to your fingers as well, you could feel it hardening slowly against your abdomen.";
		}
		toRet += "\n\n<i>“Enough with that already. [MC].”</i> She urged you. <i>“Just fuck me!”</i> You couldn’t be happier to hear that. You took your fingers out of her and replace them with your cock in one swift motion. Ramming her as fast as you could from the get go. You could tell she was pleased, by the sound of her panting.\n \nWith every move of your cock you hammered her deeper into the mud. Slow waves, surely product of a boat nearby, started reaching your bodies, not letting you get dry. This made easier for you to keep sliding inside Alba. You could taste the lake on the skin of her chest as you licked one of her nipples.\n \nYou stopped your kisses to see her pleasured expression and noticed how her wet hair made her horns more pronounced as they went deeper in the mud on which Alba was now fully cover thanks to you. You saw the waves from before washing away some of that dirt and covering most of Alba’s body. That gave you an idea. While you kept fucking Alba into the ground your fingers worked their way inside Alba’s ass, aided by the moisture of the lake’s water.\n \nThis, of course, didn’t go unnoticed by Alba, who flinched as she felt the third finger enter her. She pushed you a bit away from her and positioned herself on all fours.\n \n<i>“You always wait too much.”</i> She tells you with a smile and presenting her butt to you while her little tail waggled. You give an apologetic look before you place your dick back inside her. This time you entered her asshole. Alba took you with the same ease as before, if only it felt a little tighter while moving.\n \nYou kept smashing against her. Scratching her boobs with your nails as you moved, biting her back just a little before grabbing her by the horns and fuck her harder. She loved every bit of it and could not make herself stop moaning.\n \nYou kept going until the moon rose to the sky and both of you were tired and filthy with many fluids. You lay there next to her looking at the night sky as she approached you and rested her head on your shoulder.\n \n<i>“Not bad for a ‘boring’ date, huh? I think if we had brought something to eat we could have lasted until the sunrise.”</i> She laughs and hugs you, giving soft caresses to your chest with her claws to help you relax. <i>“I don’t recall thanking you for your help with my presentation. But I’m too tired to say thanks now so I guess that’ll never happen.”</i> This time you laugh and put your arm around her, pulling her close. You don’t need her gratitude, and you’d tell her that if it weren’t that maybe that could mean more sex, in which case you’d accept all the gratitude in the world.\n \n<i>“Sleep now, [MC]. I’ll make sure my servants see you home.”</i> She snuggled against you and slept calmly. You realized how tired you were too. But you preferred watching Alba sleep, as her relaxed expression made her look like a different sweet person. Overall she looked the happiest like that.\n \nIt felt like a blink, but it was far from that. You had fallen asleep and as you woke up you were suddenly back in your room, squeaky clean. You realized the sun had risen hours ago. You were also starving. Maybe you’ll call Alba again after lunch and check what she has in mind for your next date.";

		return toRet;

	}


	static void loadAlba(){
		iAlba = 0;
		while (iAlba < NPCCharList.CharFollower.Count)
		{
			if (NPCCharList.CharFollower [iAlba].charID == 13000 ) 
			{
				break; 
			}
			iAlba++;
		}
	}


}
