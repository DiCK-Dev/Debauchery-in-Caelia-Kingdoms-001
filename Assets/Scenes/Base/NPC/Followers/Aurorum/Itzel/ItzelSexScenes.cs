using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItzelSexScenes : MonoBehaviour {
	
	public Text butt1name; 
	static int iItzel; 
	public Text Board;

	public Canvas panEndTurn; 
	public Canvas panSexPanel; 

	public Text sel0Name;
	public Text sel1Name;

	public Canvas panSelection; 
	static int selectionControl; 

	public void sexScenes(int selector){
		switch (selector) {
		case 0:
			sexScene1 ();
			break;
		case 1:

			break;
		case 2:

			break;
		}


	}



	public void sexScene1(){
		endTurnFun ();

		if (NPCCharList.CharFollower [iItzel].charLove < 20) {
			string line1 = "";
	
			NPCCharList.CharFollower [iItzel].charLove = 20;
			if (NPCCharList.CharFollower [iItzel].corruptionStage > 2) {
				if (GameControl.dick1Size > 0) {
					line1 = "When she is closing the door you realize that she has a stain of cum on her clothes. Uh, so it was not a dream after all…";
				} else {
					line1 = "When she is closing the door you realize that she has a wet stain on her clothes. Uh, so it was not a dream after all…";
				}
			
				Board.text = "Reestablishing the church have brought a lot of prosperity to the city, but most importantly, it gave you a chance to meet Itzel, that formerly sweet girl that’s been loyal to you from the start and helped you to move the city forward, to the future it deserves.\n\nThe bond that has been formed by working along is strong, but it’s something more than just friendship, or the relationship between royalty and its vassals, you can feel in her, and in yourself, something stronger than that. \n\nBut she has not given the first step, but by her constant tease, you know she wants you to give the first step. You pay her a visit, the humble shack has also been renovated with the volunteer help of the city, as a thanking gift for her efforts. Although still not a great place, at least is a decent home now. You visit her on a day that you know she will be free of her church obligations, and once you open the door, without even knocking, you can see her sitting on the coach doing a sudden move, as if she was hiding something. She turns around when she hears the door, and with a bright and nervous smile welcomes your presence. <i>“My Liege, such a wonderful surprise! Eh… I wasn’t doing anything! Please come, come, and sit at my side!”</i> You smile back and follow through her suggestion. Once at her side, she moves closer to you, grabbing your arm <i>“As usual your presence is always welcome here,  but I do wonder, did you just come to… hang around, or there is any matter that requires my attention?”</i> You tell her that indeed you came just to be with her <i>“Ah… That’s great!”</i> she licks her lips while her face turns red, more because of her arousal than shyness. \n\nBut instead of going forward she changes topic, since she clearly wants to just tease you for now, and soon enough both of you are chit-chatting about your daily affairs, anecdotes, and overall pleasant things. As the time goes by, your hand start to moves from her shoulder to grab her ass, something that she doesn’t mind at all, and in fact she reacts by putting her hand on your leg, pretty close to your crotch. Both f you tease each other and get closer by the minute, until your faces are just inches away from each other. Your eyes meet, and when she is about to ask if you should you just jump on her, giving her a deep, wet kiss, making out while touching each others body. \n\nThe kiss goes for a minute until its over, a string of saliva connecting your faces. You want to go for more, but today is not the day for that, she says, that everything good needs build up. You kiss her again and agree to her terms, and after embracing each other both of you fall asleep. You have a great dream, filled with pleasure, and swearing that the best mouth in the realm is servicing you, but when you wake up find Itzel peaceful sleeping over your legs, with a broad smile but clearly tired.\n\nYou wake her up, saying that its time for you to go home. <i>“It has been a great visit my Liege… I’ll hope you come back soon.”</i> You nod and smile, of course you will. You give her a deep kiss before leaving, her playful tongue moving all around the inside of your mouth. \n\n" + line1;
			
			} else {
				
				Board.text = "Reestablishing the church have brought a lot of prosperity to the city, but most importantly, it gave you a chance to meet Itzel, that sweet girl that’s been loyal to you from the start and helped you to move the city forward, to the future it deserves.\n\nThe bond that has been formed by working along is strong, but it’s something more than just friendship, or the relationship between royalty and its vassals, you can feel in her, and in yourself, something stronger than that. \n\nBut she will never give the first step, too fearful that something would go wrong, but thankfully you have the confidence that she lacks. You pay her a visit, the humble shack has also been renovated with the volunteer help of the city, as a thanking gift for her efforts. Although still not a great place, at least is a decent home now. You visit her on a day that you know she will be free of her church obligations, and once you open the door, without even knocking, you find her relaxing on the coach, drinking some tea and reading a book. She slowly turns around when she hears the door, and with a bright smile welcomes your presence. <i>“My Liege, such a wonderful surprise! Please come, come, and sit at my side!”</i> You smile back and follow through her suggestion. <i>“As usual your presence is always welcome here,  but I do wonder, did you just come to hang around or there is any matter that requires my attention?”</i> You tell her she can relax, you only came to be with her. <i>“Ah… That’s great! ”</i> her face is red and maybe ironically, she is more nervous than before. \n\nBut her nervousness doesn’t last long, since soon enough both of you are chit-chatting about your daily affairs, anecdotes, and overall pleasant topics. As the time goes by, you end up with an arm around her shoulder, a friendly embrace that she accepts, but once she feels tired, and with more confidence, she slowly moves to rest on your chest. Both of you are there, silent, hugging each other without the need of words to understand what’s going on. \n\nYou play with her hair, and you can feel her strong heartbeat. Finally, she turns her head and your eyes meet, she wants to say something but you stop her with your hand, and slowly lean forward until your lips touch hers. Her soft, warm skin touches yours, and now you know that it was fate the force behind the luck of meeting each other. \n\nThe kiss goes for a minute until its over, and the comfort of her embrace is too much to do anything else. Both of you peacefully fall asleep until it is late. \n\n<i>“It has been… A great visit my Liege… I…”</i> you nod, acknowledging what happened <i>“… I’l see you soon, right?”</i> You smile, of course. <i>“Thanks for… Everything, my Liege, be safe, I look forward for the next time we meet.”</i>\n\nYou happily leave to your castle, knowing this will grow into true love.  ";
			}


		} else {
			if (NPCCharList.CharFollower [iItzel].corruptionStage > 2) {
				Board.text = "Lately you’ve been feeling a bit horny, and maybe paying a visit to Itzel would be a good way to relief yourself.\n\nYou visit her house at night, and you are glad that there is light coming through her window, which means she is still awake. When you enter the place, you see her boiling water, getting ready to prepare some tea. \n\nShe turns around, with a happy and sexy smile on her face, as usual <i>“I had the feeling you were going to come tonight, please come in and make yourself comfortable, I will get this ready in no time.”</i> It’s one of the things you like from her the most, her instincts. You take a seat, cover yourself with one of the blankets and ask her if she has been feeling… lonely too. <i>“Ah…”</i> her face turns red <i>“I hope is not that obvious…”</i> No, not really, you calm her, is just it seems both of you were feeling the same way. <i>“Yeah, well, I believe we both have a strong connection you know… Maybe is destiny, I don’t know, but sometimes I believe we share feelings.”</i> Maybe, and if that’s the case, you are a pretty lucky person. <i>“So I am…”</i> she says while walking towards you, handing you a cup with tea, to then sit very close to you, resting her head on your chest and touching your leg. \n\n";
				if (GameControl.dick1Size > 0) {
					Board.text += "<i>“It is cold tonight right?”</i> You nod, it is indeed cold. <i>“Would you like to feel warmer?”</i> you grab her butt in response, something that excites her <i>“Oh my!… It’s a deal then… I’ll help you, you help me…”</i> she jumps on the coach and gets under the blanket. Considering she barely has any clothes, you remove the seals that cover her nipples and start to play with them while she undresses you down there. ";
					if (GameControl.dick1Size > 15) {
						Board.text += "\n\n<i>“Oh!… It is big!”</i> she says to herself while inspecting your cock, using her soft hand to touch around before starting to jerking you out. You get hard pretty quickly, and she gives it a long lick <i>“Mmmh… I don’t think I’m ready for so much cock… But lets find out”</i> and slowly, you can feel the warm of her mouth wrapping around your member, until she starts to cough.\n\n<i>“Shit… Well, that’s pretty deep for now…”</i>";
					} else {
						Board.text += "\n\n<i>“Oh!… It looks tasty!”</i> she says to herself while inspecting your cock, using her soft hand to touch around before starting to jerking you out. You get hard pretty quickly, and she gives it a long lick <i>“Mmmh… Time to have a real meal”</i> and slowly, you can feel the warm of her mouth wrapping around your member until the very base of it.";
					}
					Board.text += "\n\nShe starts to move up and down, and her skilled tongue starts to play around your cock, making sure to visit every inch of it. You still remember when she was an amateur, and it is incredible that she has become this good in so little time, but your guess is she’s been practicing for you. \n\n<i>“You know, the deal is you will help me too, so lets do that.”</i> she throws the blanket away and puts herself upside down, something easily accomplish thanks to her light weight and small frame, putting her cunt at the reach of your mouth.\n\nBoth of you start to eat each other, enjoying her sweet nectar. The silence of the house is broken only by the slurping sounds of your sexual act and the occasional moaning. \n\nIt doesn’t take long until both of you find each others weak spots, and both of you enjoy teasing them and edging each other for a while. \n\nThe first to give up is Itzel <i>“Ah!… Shit!… I’m almost there!… B-But not yet! I want you to fuck my face! Use me! Be rough and fill my your sperm while I cum!”</i> she embraces you with all of her strength and you comply, starting to pound her little mouth as if it was the most experienced cunt while penetrating her pussy as deep as you can with your tongue.\n\nIn only a minute, both of you are at your limit and, in sync, both of you fill each other with their respective fluids. \n\nYou can hear Itzel drowning in your cum, but that doesn’t slow you nor her down, slurping you down until you are finally done."; 
					if (WorldControl.tagControl [4]) {
						Board.text += "\n\nYou let her fall on the coach, and you can see how she still has a mouthful on cum, playing with it and savoring it. The beautiful sight of the priestess delighted on your cum is too much for you, and you lean forward, giving her a deep wet kiss, mixing her fluids, sperm and saliva. She loves it, and shares your sperm back and for with you. When the kiss is over, you lick some of your cum on her face and spit it into her mouth, something that she receives with pleasure.";
					} else {
						Board.text += "\n\nYou let her fall on the coach, and you can see how she still has a mouthful on cum, you play with her hair while she is fooling around with your sperm and savoring it. The beautiful sight of the priestess delighted on your cum is incredible, and the cherry on the top is the gargles she does before drinking it all. You give her deep wet kiss when the show is over, and peacefully rest on each others side. ";
					}
					Board.text += "\n\nWhen both of you are done, you realize it is very late, and it is time for both of you to rest. <i>“I think I need to sleep now… I’m very tired, but please, come again… I promise I’ll be as good…”</i> she gives you a peck on your lips, and you promise her to visit her again very soon.";

				} else {
					Board.text += "<i>“It is cold tonight right?”</i> You nod, it is indeed cold. <i>“Would you like to feel warmer?”</i> you grab her butt in response, something that excites her <i>“Oh my!… It’s a deal then… I’ll help you, you help me…”</i> she jumps on the coach and gets under the blanket. Considering she barely has any clothes, you remove the seals that cover her nipples and start to play with them while she undresses you down there. \n\n<i>“Oh!… It is wet already!”</i> she says to herself while inspecting your cunt, using her soft hand to open your lips apart. You get excited quickly, and she gives it a long lick <i>“Mmmh… This is better than tea…”</i> and slowly, you can feel the warm of her tongue going around your inner walls.\n\n\nShe starts to move up and down, and her skilled tongue starts to play around your clit, making sure to visit every inch of it. You still remember when she was an amateur, and it is incredible that she has become this good in so little time, but your guess is she’s been practicing for you. \n\n<i>“You know, the deal is you will help me too, so lets do that.”</i> she throws the blanket away and puts herself upside down, something easily accomplish thanks to her light weight and small frame, putting her cunt at the reach of your mouth.\n\nBoth of you start to eat each other, enjoying her sweet nectar. The silence of the house is broken only by the slurping sounds of your sexual act and the occasional moaning. \n\nIt doesn’t take long until both of you find each others weak spots, and both of you enjoy teasing them and edging each other for a while. \n\nThe first to give up is Itzel <i>“Ah!… Shit!… I’m almost there!… B-But not yet! I want you to cum with me, fill me up while we finish!”</i> she embraces you with all of her strength and you comply, starting to use your hips and her little mouth as if it was the most experienced cunt while penetrating her pussy as deep as you can with your tongue.\n\nIn only a minute, both of you are at your limit and, in sync, both of you fill each other with their respective fluids. \n\nYou can hear Itzel drowning in your fluids, but that doesn’t slow you nor her down, slurping you down until you are finally done.\n";
					if (WorldControl.tagControl [4]) {
						Board.text += "\n\nYou let her fall on the coach, and you can see how she still has a mouthful, playing with it and savoring it. The beautiful sight of the priestess delighted on your liquids is too much for you, and you lean forward, giving her a deep wet kiss, mixing both nectars and saliva. She loves it, and shares everything back and for with you. ";
					} else {
						Board.text += "\n\nYou let her fall on the coach, and you can see how she still has a mouthful, you play with her hair while she is fooling around savoring it. The beautiful sight of the priestess delighted thanks to you is incredible, and the cherry on the top is the gargles she does before drinking it all. You give her deep wet kiss when the show is over, and peacefully rest on each others side. \n";
					}
					Board.text += "\n\nWhen both of you are done, you realize it is very late, and it is time for both of you to rest. <i>“I think I need to sleep now… I’m very tired, but please, come again… I promise I’ll improve even more…”</i> she gives you a peck on your lips, and you promise her to visit her again very soon.\n";
				
				}

			} else {
				Board.text = "Lately you’ve been feeling a little lonely, and maybe paying a visit to Itzel would be a good way to cheer you up. \n\nYou visit her house at night, and you are glad that there is light coming through her window, which means she is still awake. When you enter the place, you see her boiling water, getting ready to prepare some tea. \n\nShe turns around, with a happy and welcoming smile on her face, as usual <i>“I had the feeling you were going to come tonight, please come in and wait at the coach, I will get this ready in no time.”</i> It’s one of the things you like from her the most, her instincts. You take a seat, cover yourself with one of the blankets and ask her if she has been feeling lonely too. <i>“Ah…”</i> her face turns red <i>“I hope is not that obvious…”</i> No, not really, you calm her, is just it seems both of you were feeling the same way. <i>“Yeah, well, I believe we both have a strong connection you know… Maybe is destiny, I don’t know, but sometimes I believe we share feelings.”</i> Maybe, and if that’s the case, you are a pretty lucky person. <i>“So I am…”</i> she says while walking towards you, but when she is about to arrive she trips up with the carpet, throwing the still hot liquid on you <i>“Oh no! What have I done!”</i> \n\nThe hot beverage lands on you, but thankfully, most of it lands on the sturdy blanket. Still, you instinctively scream, and you can feel some of the warm liquid on your crotch. <i>“I am really sorry! Please, let me help you!”</i> she rushes to your side and tosses the blanket to the side, and with a handkerchief starts to clean up your legs and crotch. You can see she is really concerned, but you tell her that you are fine and pat her head while she cleans you. <i>“… It scared me, this is my bad, if I wasn't clumsy this wouldn’t have happened”</i> she keeps rubbing you, and the whole scene is making you feel aroused. You fake a scream when she goes upwards <i>“Does it hurt?”</i> you nod, pretending to be in pain, she realizes that she would have to remove your pants to inspect you, but this obviously makes the shy Itzel feel nervous <i>“Ah… I… I think you need to take your pants off, so I can inspect you…”</i> You act reluctant at first, but of course agree at the end. \n\n";
				if (GameControl.dick1Size > 0) {
					Board.text += "You are about to stand up but she stops you <i>“Don’t worry, I’ll help you, since it is my fault…”</i> she slowly starts to remove your pants, and she almost immediately realizes that you are not wearing underwear, and you are half erect cock is exposed and just few inches away from her face. ";
					if (GameControl.dick1Size > 15) {
						Board.text += "\n\n<i>“Oh!… It is big!…”</i> she barely whispers to herself while inspecting your skin, using her soft hand to touch around and asking if it hurts. You shake your head and ask her to get closer and closer, until her hand is almost on your dick. <i>“…I guess you are fine, right?”</i> she says while looking at the sides, nervous. ";
					} else {
						Board.text += "\n\n<i>“Oh!… It is cute…”</i> she barely whispers to herself while inspecting your skin, using her soft hand to touch around and asking if it hurts. You shake your head and ask her to get closer and closer, until her hand is almost on your dick. <i>“…I guess you are fine, right?”</i> she says while looking at the sides, nervous.";
					}

					Board.text += "\n\nYou ask if she believes that <i>“No… I’ll keep going then.”</i> her hands start to touch your cock very carefully, as if it was a very fragile relic, and you can’t stop yourself from having an erection. <i>“Oh my!…”</i> she says in surprise, but what matters is that she doesn’t let it go, still exploring your solid member. \n\nShe turns and looks at you, locking her eyes on you, and she only needs very subtle approval from your part to understand what she needs to do. With a soft grasp, she starts to move her left hand slowly, while with her right hand starts to play with the head of your dick, giving you a lovely massage. You lean back and relax, leaving the priestess to her task while you rest. She doesn’t have much experience, but she is careful and thoughtful, and when she notices a weak spot she makes sure to memorize it.\n\nThe silence of the place is broken by the wet sounds of her task and her breath, both excited and nervous.\n\nHer diligence is too much for you, and it doesn’t take long until you are close to finish, should you warn her?";
			


				} else {
					Board.text += "You are about to stand up but she stops you <i>“Don’t worry, I’ll help you, since it is my fault…”</i> she slowly starts to remove your pants, and she almost immediately realizes that you are not wearing underwear, and you naked cunt is exposed and just few inches away from her face. \n\n<i>“Oh!… It is cute…”</i> she barely whispers to herself while inspecting your skin, using her soft hand to touch around and asking if it hurts. You shake your head and ask her to get closer and closer, until her hand is almost on top of your pussy. <i>“…I guess you are fine, right?”</i> she says while looking at the sides, nervous. \n\n\nYou ask if she believes that <i>“No… I’ll keep going then.”</i> her hands start to touch your nether parts very carefully, with tender love, and you just melt on your seat, enjoying her touch. <i>“You are lovely…”</i> she says in awe.\n\nShe turns and looks at you, locking her eyes on you, and she only needs very subtle approval from your part to understand what she needs to do. Slowly, she starts to penetrate you with her fingers, using her other hand to play with your clit, giving you a lovely massage. You lean back and relax, leaving the priestess to her task while you rest. She doesn’t have much experience, but she is careful and thoughtful, and when she notices a weak spot she makes sure to memorize it.\n\nThe silence of the place is broken by the wet sounds of her task and her breath, both excited and nervous.\n\nHer diligence is too much for you, and it doesn’t take long until you are close to finish, should you";
				}

				sel0Name.text = "Warn her";;
				sel1Name.text = "Don't warn her"; ;

				panEndTurn.sortingOrder = -500;
				panSelection.sortingOrder = 500;
				selectionControl = 0;

			
			}

		}


	}

	void sexScene1a(){
		if (GameControl.dick1Size > 0) {
			if (WorldControl.tagControl [4]) {
				Board.text += "\n\nShe plays with the cum on her mouth, but before she swallows you stop her and ask her to stand up. She does so and, without further delay, you give her a deep, wet kiss, sharing both saliva and your own sperm. She embraces you, happy for your affection.\n\nWhen both of you are done, there is a small thread of cum between your faces, that she playfully takes with her tongue.";
			} else {
				Board.text += "\n\nShe plays with the cum on her mouth, and she opens her mouth wide to show you the mostly liquid mix of your sperm and her saliva, before swallowing all.  She stands up and, without further delay, you give her a deep kiss. She embraces you, happy for your affection.";
			}
			Board.text = "\n\nWhen both of you are done, you realize it is very late. <i>“I think I need to sleep now… I’m very tired, but please, come again… I promise I will still be clumsy…”</i> she gives you a peck on your lips, and you promise her to visit her again very soon.";
		} else {
			Board.text += "\n\nWhen you are done, she stands up and, without further delay, you give her a deep kiss. She embraces you, happy for your affection.\n\n\nAt this point, you realize it is very late. <i>“I think I need to sleep now… I’m very tired, but please, come again… I promise I will still be clumsy…”</i> she gives you a peck on your lips, and you promise her to visit her again very soon.\n";
		}

	}


	public void selectionFun(int selector){
		if (selector == 0 && selectionControl == 0) {
			if (GameControl.dick1Size > 0) {
				Board.text = "You tell her that you are about to finish and, desperate, she starts to look around <i>“What should I do?!”</i> she asks, and you suggest her to open her mouth in front of it. <i>“Like this?”</i> She wide opens her mouth just an inch away from it, her hot breath arousing you to the limit. But the real finisher is when she touches the bottom of your head with her tongue. The first load goes directly into her throat, almost making her cough, but she manages to persists. \n\nMost of the cum landed on her mouth, but a couple of loads went onto her cheeks and face.\n\nShe savors the load that got in her mouth with delight <i>“Your seed is very powerful, my Liege!”</i> and without shame she uses her hand to bring the rest to her mouth.";

			} else {
				Board.text = "You tell her that you are about to finish and, desperate, she starts to look around <i>“What should I do?!”</i> she asks, and you suggest her to open her mouth in front of it. <i>“Like this?”</i> She wide opens her mouth just an inch away from it, her hot breath arousing you to the limit. But the real finisher is when she touches your clit with her tongue. The first load goes directly into her throat, almost making her cough, but she manages to persists. \n\nMost of your fluids land on her mouth, but a couple of loads went onto her cheeks and face.\n\nShe savors  with delight <i>“Your taste is very powerful, my Liege!”</i> and without shame she uses her hand to bring the rest to her mouth.";
			}

			sexScene1a ();
			endTurnFun ();
			panSelection.sortingOrder = -500;
			return; 
		}

		if (selector == 1 && selectionControl == 0) {

			if (GameControl.dick1Size > 0) {
				Board.text = "You don’t warn her, and you start to shoot your load onto an unsuspecting Itzel, who shrieks when the first load hits her face. The second load is a lucky shot, and hits her directly into the mouth. The most important thing is that she never stops pumping you until you are done, painting her with your jizz. \n\nShe savors the load that got in her mouth with delight <i>“Your seed is very powerful, my Liege!”</i> and without shame she uses her hand to bring the rest to her mouth.";
			
			} else {
				Board.text = "You don’t warn her, and you start to shoot your load onto an unsuspecting Itzel, who shrieks when the first hits her face. The second load is a lucky shot, and hits her directly into the mouth. The most important thing is that she never stops her hands you until you are done, painting her face with your fluids.\n\nShe savors with delight <i>“Your taste is very powerful, my Liege!”</i> and without shame she uses her hand to bring the rest to her mouth.";
			}

			sexScene1a ();
			endTurnFun ();
			panSelection.sortingOrder = -500;
			return; 
		}






		if (selector == 0 && selectionControl == 100) {

			return; 
		}

		if (selector == 1 && selectionControl == 100) {

			return; 
		}

	}



	void Start (){
		loadItzel ();


		if (NPCCharList.CharFollower [iItzel].charLove >= 20) 
		{
			if (NPCCharList.CharFollower [iItzel].corruptionStage > 2) {
				butt1name.text = "Blowjob";
			} else {
				butt1name.text = "Handjob";
			}
		}


	}



	void loadItzel(){
		iItzel = 0;

		while (iItzel < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iItzel].charID == 7000){
				WorldControl.NPCID = NPCCharList.CharFollower [iItzel].charID;
				//WorldControl.PortraitID = NPCCharList.CharFollower [iItzel].charPortrait;
				WorldControl.furryPic = NPCCharList.CharFollower [iItzel].isFurry;
				WorldControl.futaPic = NPCCharList.CharFollower [iItzel].isFuta;
				break; 
			}
			iItzel++;

		}

	}


	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		panEndTurn.sortingOrder = 500;
		panSexPanel.sortingOrder = -500; 
		panSelection.sortingOrder = -500;

	}



}
