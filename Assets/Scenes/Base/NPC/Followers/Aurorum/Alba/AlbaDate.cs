using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AlbaDate : MonoBehaviour {

	public Text Board; 
	static int iAlba;
	int iVar;

	static int confirmationControl; 

	public Canvas endTurnPanel; 


	public Canvas panConfirmation;

	public Canvas panMainPanel;

	public Text option0Name;
	public Text option1Name;




	public void albaDate(){
		loadAlba ();
		if (NPCCharList.CharFollower [iAlba].charLove < 33) {
			date1 ();
		} else if (NPCCharList.CharFollower [iAlba].charLove < 66) {
			date2 ();
		} else if (NPCCharList.CharFollower [iAlba].charLove < 100) {
			date3 ();
		} else {
			Board.text = "Alba is fully in love with you! ";
		}

	}

	void date1(){
		WorldControl.day += 2;
		NPCCharList.CharFollower [iAlba].charLove = 33;

		panMainPanel.sortingOrder = -400;

		panConfirmation.sortingOrder = 500;

		confirmationControl = 0;

		option0Name.text = "Alba for yourself!";
		option1Name.text = "Let's have fun!";

		Board.text = "Lately you and Alba have spent a lot of time together and you think is time to move your relationship forward. Your plan something different from the usual, maybe more intimate, maybe something were you two could know each other better and leave the tedious life of ruling the kingdom behind for a night. You go to her house with the idea in mind, even when you know she's not exactly the romantic type of girl.\n\n<i>“A date?”</i> Alba raises an eyebrow before drinking all the wine from her cup <i>”Aren't you a cutie, [MC]? I didn't expect that from you...”</i> she laughs as she orders another glass of wine to one of her servants, then she looks at you with a playful smile and walks at your direction seductively <i>“I guess it wouldn't hurt, what do you have in mind to keep me entertained?”</i> she whispers close to your ear as she plays with a string of your hair. \n\nYou tell her about a near restaurant with excellent exotic food and music. She laughs again but she agrees <DIALOGUE>“Very well [MC], this time I’ll follow your lead, but don’t get too used to it.”</DIALOGUE>, agreeing with your plan.\n\nWhen you are on your way to the restaurant, Alba suddenly takes your hand and looks at you with a playful smile. \n\n<i>“Lets have some fun first, come!”</i> she says as she pulls you to a crowded bar full of bandits and low lifes. She walks towards the bartender eagerly <i>“Two jars of beer! and another one for my friend”</i> she laughs as she sits and makes some space for you. \n\nYou ask about the restaurant and she shrugs with a playful expression <i>“Don´t worry [MC], we´re not missing your fancy dinner, let's relax and enjoy ourselves a little bit first… you seem so tense”</i> she says as she passes her claws softly through your neck, giving you chills. \n\nThe barman gives you the beers and Alba winks at him before taking her jar. She drinks it all in one gulp and leaves the jar on the table violently before looking at you mischievously. When you reach for your beer she takes it from your hands and bring it closer to her mouth, but before the glass could touch her lips, she recline the jar softly and let the beer fall on her chest, wetting her clothes.\n\n<i>“Oops, my bad”</i> she whispers before drinking what was left in the jar. She puts the glass aside and starts unbuttoning her top <i>“It would be a shame if this goes to waste… would you clean it for me? I don't want to catch a cold”</i> she asks enticingly as she opens her shirt for you to see her generous, dripping breasts.\n\nYou can see how the bartender it's gazing over her tits. <DIALOGUE>“Hey kid, if you won’t take her offer, I will.”</DIALOGUE>\n\nAllowing the bartender to suck Alba’s breast would lead to public and bisexual options, or you can go forward and keep Alba for yourself. ";



	}

	void date2(){
		WorldControl.day += 2;
		NPCCharList.CharFollower [iAlba].charLove = 66;

		Board.text = "Ever since your last date, the memory of Alba’s wet boobs flood your mind. The smell of beer, her arousing looks, you can’t stop thinking about that. Somehow, sharing a fun time with her at the bar, makes you feel like you became much closer to how it was before.\n \nThinking of a second date was not that far fetched either. She’d say yes the first time, why wouldn’t she agree for a second time?\n \nYou didn’t want to think on what you had to lose. You gather all your courage and went straight to her palace.\n \nOnce you arrive one of her servants opened the door and guided you towards a living room lavishly decorated. You had no doubt she had put effort in every single detail in this room, as it is the one her guests see first. Giving a powerful impression was crucial in her biz.\n \n<i>“Madam is in her room, please wait until I announce your presence.”</i>\n \nYou waited in that living room analyzing every detail. Curious to find anything she had missed. There was nothing like that. Everything there looked in order, even strategically placed. Something you would’ve find very odd if you only met her wild side. However, in the time you’ve been together you’ve come to know her each day more. You wonder what else she has to show you.\n \nUnder ten minutes pass and her servant comes back. She looks at you from the entrance of the living room and in a very sober manner, asks you to come with her.\n \n<i>”Madam wants to see you in her private room”</i> she informs you while both of you keep a steady pace to Alba’s room. You get the chance to see how much the decoration seemed to change. Less and less colors until you reached the completely bare and gray stairway. <i>”The room she wants to see you is downstairs. It’s the only room there. I can only accompany you until here.”</i>\n \nWhen Alba’s servant said her private room, you thought she meant her bedroom. Now you are completely sure that isn’t it.\n \nYou reach down the stairs and follow a narrow passageway that ends with a metallic door. You knock on it three times before you hear a familiar voice.\n \n<i>“The door is open. You can only enter if you are [MC], otherwise don’t waste my time.”</i>\n \nYou open the door carefully, sneaking a peek first, without entering.\n \nInside the room were several machines that you’ve never seen before. Tempted by curiosity you open the door completely.\n \nYou can now see Alba, inspecting one of the mysterious machines before her. The noise the door makes when it closes behinds you catches her attention and makes her look right at you.\n \n<i>“Just the person I was looking for!”</i> she exclaims excitedly and approaches you grabbing your arm. <i>“Well, not really, but you’ll do.”</i> She walks you to the machine she was seeing before. You can notice that, unlike all the others, this one looks clean and unused.\n \nYou try to understand what this thing is. It has a u shaped seat with a reclined back rest, and in front of the seat there is a box with a handle. The box has a pole of wood with a bright red long dick attached to it.\n \n<i>“I was just about to try this baby.”</i> She says while removing the lower half of her clothes, moving her as in your way. Her little tail moves along as well. When she finishes she throws her clothes at you and sits on the machine.";
		if (GameControl.dick1Size > 0) {
			Board.text += "\n\nYou smell the scent on the fabric, so enticingly good. Your blood starts rushing straight to your dick. You want to taste her so bad.  ";
		} else {
			Board.text += "\n\nYou smell the scent on the fabric, so enticingly good. You can feel yourself starting to get wet. You want to taste her so bad.";
		}
		Board.text += "\n\nAlba sees you flickering your tongue against her underpants.\n \n<i>“Hey [MC], the real thing is over here, and you better come now, I can’t wait for you all day.”</i>\n \nYou look at her sitting. The u shape seat perfectly separates her legs letting you see straight into her pussy from afar.\n \nYou rush there, planting your face straight between her labia, desperately slurping all her humidity. She wasn’t as aroused as you are, but your expert tongue changes that with just a few more licks.\n \nShe pants loudly, and grabs you by the hair. First pushing you against her until you open up her vulva with your tongue, and then removing you once her own fluid starts dripping.\n \n<i>“That’ll be enough preparations, let us start with the actual deal!”</i>\n \nShe throws you against the box with the handle, and lays on the back of her seat.\n \n<i>“Get that near me.”</i>\n \nWanting to see where this is going you push the box until the dick on it caresses Alba’s entrance. She adjusts its tip inside her with ease thanks to your skilled licking.\n \n<i>“There. Now use the handle over there.”</i>\n \nYou crank the box slowly, watching how that long red dildo pushed deeper with each rotation until you could only see its base. A few rotations more and the dick pulled out of Alba’s juicy cunt.\n \n<i>“Well, we now know it works.”</i> She says sounding a bit irritated. <i>“But is it seriously all you can do?”</i>\n \nOf course not. You think to yourself. If Alba wanted some sweet ravishing, that’s what she was going to get.\n \nYou turn the handle once more, keeping a faster, yet steady pace. This seems to make Alba really horny. Each cycle pushed her against the chair with a moan.\n \nShe looked at you with a sneer.\n \n<i>“You wish it were you, huh?”</i> Without breaking eye contact she opens more her legs and with one hand starts caressing her clit. Her other hand reaches to a bottle on the floor you hadn’t notice before, pouring all its contents over her breasts. She throws the bottle and plays with one of her boobs, uncovering it for you to see her nipple.\n \nYou sure do wish that red dick was you. But in a certain way, it is you. And you decide to go even faster.\n \n<i>“Ah!...ah! Yes!”</i> Alba screams. <i>“Come here and lick me!”</i>\n \nYou do it without a second thought, and urgently go straight to her breast, tasting the sweet delicious flavor of that bottle, and feeling her soft skin under your teeth.\n \n<i>“Stop! I want something to lick too!”</i> You undress in a second and put your crotch against her mouth, where she licks every inch to her will.\n \nWhile you enjoy yourself, you finally notice that the machine has not stopped ever since you left it by its own. Alba notices where you are looking.\n \n<i>“Ah! You like that? It uses half of the energy you use and stores the other half for ahh… for free hand usage.”</i> You’d think it’s impressive if you were actually thinking right now. But Alba never stopped caressing you with her fingers and that became all your brain could focus on.\n \nAlba comes first, still being trusted by her new invention. She keeps stimulating you until you come too.\n \nNow that you can think clearly, you finally hear Alba asking you to get the machine out of her. You do and help her stand up.\n \n<i>“Well, that was fun.”</i> She says, with a satisfied grin. <i>“No doubt this baby will be a total success.”</i>\n \nYou agree. She truly knows what she is doing when it comes to her machines. You get curious about the other machines too, but before you could ask anything about them she gives you your clothes back and rushes you thru the door.\n \n<i>“I have other things to do, but thanks for stopping by. I’ll call for you if I feel like it.”</i>\n \nShe said she’ll call you. That means there’ll be a next time for sure. You can’t wait.";

		endTurnFun ();

	}

	void date3(){
		WorldControl.day += 2;
		NPCCharList.CharFollower [iAlba].charLove = 100;
		NPCCharList.CharFollower [iAlba].breast1Size = 0;

		panMainPanel.sortingOrder = -400;
		panConfirmation.sortingOrder = 500;


		confirmationControl = 2;

		option0Name.text = "Be entertained";
		option1Name.text = "Refuse";

		Board.text = "Not a day passes where you wish you could just go to Alba´s castle and ask her out again. Last time was a hell lot of fun, but it was not a proper outgoing. You only keep waiting because she said she´ll call you. And you want her to ask you out for a change.\n \nYou were keeping yourself busy checking everything in your place worked correctly, although you knew there was nothing to worry about, you wanted to kill some time, when suddenly someone called to your door. Usually, you’d let someone else open the entrance for you. But this days you were anticipating Alba’s arrival, so you opened the door on your own every time since your last date.\n \nTo your delight it was one of Alba´s servants. A beautiful girl, but not nearly as sensual as Alba. Surely the girl is bringing news of her.\n \n<i>“Greetings, I bring a message for [MC].”</i> She says before realizing it’s you. <i>“Oh, I’m sorry. I am to take you to Madam Alba’s home. She is requesting your assistance once again.”</i>\n \nAssistance is not the same as a date, but if it was the kind of assistance you gave her last time, you’d be more than happy to be of service. You agree to go with her and she takes you to one of Alba’s chariots.\n \nYou hop inside and take a seat. You notice there was another servant already in the seat in front of you. This one was a guy but similarly good looking. As soon as the other servant closes the door behind her, the chariot starts moving.\n \n<i>“Madam Alba has told us to keep you entertained while we reach our destination.”</i>";

	}


	public void confirmFun(int selector){
		///////////////////////////// alba yourself / lets have fun 

		if (selector == 0 && confirmationControl == 0) {
			Board.text = "You can´t resist Alba´s invitation and, ignoring the bartender, you get closer to her and start alternating a few kisses over her wet skin, tasting the trails of beer on her breasts. She smiles, pleased. \n\n<i>“Oh, come on MC, you can do better than that.”</i> she teases as she squeezes her tits together with both of her hands. You take her word and start licking and sucking, feeling her soft and curvy flesh in your mouth. You raise your hands and touch her breasts between caresses and hickeys.\n\nAlba moans softly as she starts licking her own claws, letting you do what you please with her tits. Suddenly, she stops you and pushes you away \n<i>“Enough of that, MC. Let´s give ´em a real show”</i> she says as she sits on the bar and, grabbing the neck of your shirt, she pulls you to her. ";

			if (GameControl.dick1Size > 0) {
				Board.text += "\n\nShe passes her hands under your clothes as she starts to move them lower, until she touches your cock over the fabric, teasing you with soft circular movements.\n\nYou can feel the glances on both of you but you don´t care. Alba´s inviting expression is everything you can see right now. \n\n<i>“Oh my, it looks like I'm not the only excited one here...”</i> she smirks while she starts to uncover your nether parts. ";
				Board.text += "\n\nYour boner immediately pops out from your pants. <i>“You get hard so easy… let’s have a taste...”</i> Alba jumps from her chair and leans forward. You can feel her warm breath on your cock, and the stares of the crowd that’s now surrounding you. \n\nBeing the center of attention makes you feel unease but excited. Your body reacts on its own, and your hand pulls Alba’s head towards you. She doesn’t resists at all, if anything she eagerly takes your cock in her mouth, smiling playfully while her skilled tongue fondles all your weak spots.\n\nWhat you’ve always liked about her is how lustful she is; a true lover of sex and debauchery, no qualms, and always ready to fulfill her own desires, doesn’t matter with whom or where. \n\nAlthough you’ve plenty of experience, Alba is a true challenge for your manhood and she can sense it. As expected from a predator like her, she assaults you with such pleasure that you finally can’t stand it anymore and start to release inside of her mouth. \n\nThe first load goes straight into her throat, swallowing it with “gusto”, but she quickly takes it out so you can paint her face and breasts with the jizz that’s left in you. \n\nWhen you’re over you have made a mess: Her hair and chin are dripping with cum, a small pool in her chest  <i>“You were packing up uh? Hope you’re not done yet, because I’m not...”</i> \n\nAlba is not lying, there is a small pool underneath her. The problem is that the crowd around you is getting too excited and hostile, no surprise considering the place that Alba decided to visit, and before it gets too late you grab Alba by her hand and run away, throwing a small bag of gold to the owner of the “reputable” establishment.\n\n<i>“*sigh* why you did that [MC]? We all could had fun, you know...”</i> you know how perverse she is, but still you rather want her just for yourself.\n\n<i>“Awww that’s so cute… Well if that’s what you want, you can have me… but tomorrow, I think for today's the mood is ruined.”</i>\n\nYou agree, and to be honest you still haven’t recovered yet from her oral job back then. \n\n<i>“Thanks for inviting me, come back soon, I promise next time we’ll go where you want to go.”</i>\n\nYou give her a kiss in her mouth, and surprisingly for you she answers back tenderly, instead of her typical aggressiveness. \n\nYou return to your castle happy with how things turned out. ";
			} else {
				Board.text += "\n\nShe passes her hands under your clothes as she starts to move them lower, until she touches your pussy over the fabric, teasing you with soft circular movements.\n\nYou can feel the glances on both of you but you don´t care. Alba´s inviting expression is everything you can see right now. \n\n<i>“Oh my, it looks like I'm not the only excited one here...”</i> she smirks while she starts to uncover your nether parts. ";
				Board.text += "\n\nYour dripping pussy is now available for your lusty companion. <i>“You get wet so easy… let’s see how you taste...”</i> Alba jumps from her chair and leans forward. You can feel her warm breath on your pussy, and the stares of the crowd that’s now surrounding you. \n\nBeing the center of attention makes you feel unease but excited. Your body reacts on its own, and your hand pulls Alba’s head towards you. She doesn’t resists at all, if anything she eagerly takes your pussy in her mouth, smiling playfully while her skilled tongue fondles all your weak spots.\n\nWhat you’ve always liked about her is how lustful she is; a true lover of sex and debauchery, no qualms, and always ready to fulfill her own desires, doesn’t matter with whom or where. \n\nAlthough you’ve plenty of experience, Alba is a true challenge for your womanhood and she can sense it. As expected from a predator like her, she assaults you with such pleasure that you finally can’t stand it anymore and start to release inside of her mouth. \n\nWhen you squirt Alba’s eagerly drinks it, although there is so much that you end up soaking her hair, face and chest with your fluids.  <i>“I’m that good uh? Hope you’re not done yet, because I’m not...”</i> \n\nAlba is not lying, there is a small pool underneath her. The problem is that the crowd around you is getting too excited and hostile, no surprise considering the place that Alba decided to visit, and before it gets too late you grab Alba by her hand and run away, throwing a small bag of gold to the owner of the “reputable” establishment.\n\n<i>“*sigh* why you did that [MC]? We all could had fun, you know...”</i> you know how perverse she is, but still you rather want her just for yourself.\n\n<i>“Awww that’s so cute… Well if that’s what you want, you can have me… but tomorrow, I think for today's the mood is ruined.”</i>\n\nYou agree, and to be honest you still haven’t recovered yet from her oral job back then. \n\n<i>“Thanks for inviting me, come back soon, I promise next time we’ll go where you want to go.”</i>\n\nYou give her a kiss in her mouth, and surprisingly for you she answers back tenderly, instead of her typical aggressiveness. \n\nYou return to your castle happy with how things turned out. \n";
			}

			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 0) {
			Board.text = "Heck, why not? Let’s see how far Alba will take. You nod at the bartender and Alba smirks <i>“Very well… eyes on me.”</i> she whispers before walking to the man behind the bar.\nHe was a horse-man with black mane and brown skin, big and corpulent.\n\nShe offers her breasts to him without taking her gaze away from you. The bartender smiles and bends to start touching and licking Alba´s soft and wet skin, passing his manly hands through her nipples with his mouth going over her tits eagerly.\n\nAlba starts panting as she looks at you lustfully. The view is arousing and you start to react to it as well, and you´re not the only one, for a crowd already gathered around the scene to watch.\n\nThe man finishes cleaning her up and takes a couple of steps away before taking out his massive horse boner from his pants <i>“Wanna try? Speciality of the house”</i> he says with a seductive smirk.\n\nShe accepts and starts licking it, drenching her face in thick precum, then she grabs it from the base and starts sucking it, first from the tip and then taking it deeper. Suddenly, she stops and looks at you naughtily <i>“Are you going to stay there and watch or will you share the drink with me, [MC]?”</i>  she asks, making space for you to join.\n\nWhat do you do?";
			confirmationControl = 1;

			option0Name.text = "Suck bartender";
			option1Name.text = "Just watch";

			return;
		}

		///////////////////////////// suck bartender / just watch

		if (selector == 0 && confirmationControl == 1) {
			Board.text = "You don’t want to let down Alba in your first date and decide to take her offer, besides, you can't deny that looks like fun. You walk to them and kneel next to her, looking at the huge, thick cock in front of you,\n\nShe smiles with satisfaction, giving you enough room to join the party. You take the member with one hand and you kiss it slowly before start licking it. Alba does the same and you both cover the massive bartender´s dick with your mouths. The people around you starts taking their own erections, enjoying the view from afar.\n\nAlba stops for a moment to look at you <i>“I´m so glad I found a treasure like you, MC. It's so hard to find a partner willing to do this kind of things with me.”</i> she says as she kisses you on the cheek before sucking the horse-man cock again.\n\nBoth of you start moving faster and hungrily, taking turns to take the member in your mouth, seeing how far you can reach. The bartender leans on the bar, panting with pleasure as he takes a half empty jar with beer.\n\nThe horse-man cums in the jar, filling it to the top with his sperm. He finish the show with a dry moan and both of you stand up. Alba takes the jar from the bartender´s hand and gives you a lustful look before giving the glass to you <i>“Speciality of the house”</i> she says with the bartender´s words. You look at the foul mix of fluids and beer, and hesitate for a moment before drinking it all it all, swallowing his thick juices, for the crowd’s delight.\n\nWith your belly full you two walk out of the establishment. \n\n<i>“Thanks for inviting me [MC], it’s been a very special night, and I hope you’ll come back soon, I promise next time we’ll go where you want to go.”</i>\n\nYou give her a kiss in her mouth, and surprisingly for you she answers back tenderly, instead of her typical aggressiveness. \n\n<i>“It still tastes like cum… such a wonderful taste!”</i> she passionately kisses you once more before she leaves. \n\nYou return to your castle happy with how things turned out. \n";
			endTurnFun ();

			return;
		}

		if (selector == 1 && confirmationControl == 1) {
			Board.text = "You tell her that you’re fine with just watching.\n \n<i>“Such pity. You don’t come across drinks like this often at any other place.”</i>\n \nShe licks the enormous tip of the bartender, pressing the rim between her lips slightly before taking it down hear throat with expert ease.\n \nThe bartender bends his neck back, drowned with pleasure.\n \nNot even Alba’s expertize could make that dick fit entirely in her mouth, but she compensated with soft caresses to the shaft of the man.\n \nShe looked at you playfully while performing her art. Enjoying every bit of that cock while pitying you for not being there with her.\n \n<i>“This could be you [MC].”</i> She says after removing the bartender’s horse dick from her mouth for a second.  <i>“Can you imagine? Me giving you head? I’m sure you are not the only one who can.”</i>\n \nYou were so invested in her doings that did not realized what she meant until then. All the bar goers where watching her sucking manically at the bartender’s dong with completely aroused.\n \nYou think that some of them might even be touching themselves but don’t care to look any longer. You rather see Alba going at it again, kissing that giant dick while heavily masturbating the untouched rest of it.\n \nDesperate for release the bar tender grabs Alba by the shoulder and neck and pushes himself completely inside Alba’s throat. Alba can’t help to choke a bit, but that did not make the man stop. He was already blinded with lust and kept ramming Alba’s head.\n \nEventually Alba decided to relax and let the bartender do all the work for himself. She became like a rag doll, enjoying the new depths this man was teaching her.\n \nThe guy’s breath became so erratic with each penetration until he finally got release, as well as you and many other customers that had come closer just to watch. They all came in Alba’s horns, hair, face and inside her mouth. She could not be more drenched in spunk.\n \n<i>“This was so fun!”</i> Alba said with a slightly hoarse voice.\n \nShe stood up and walked with you outside the bar.\n \n<i>“I guess we wouldn’t have come all the way here if it wasn’t for you trying to take us out.”</i> She smiles widely. <i>“But certainly my idea of going out was superior than whatever you had planned.”</i>\n \nYou can’t deny that, you also had fun.\n \nYou take her to her castle where her servants welcome her.\n \n<i>“We got to do this again some other time.”</i>\n \nShe leaves you outside but that doesn’t matter to you.\n \nYou go back to your castle eagerly awaiting for that next time.\n";

			endTurnFun ();
			return;
		}

		///////////////////////////// be entertained / refuse 

		if (selector == 0 && confirmationControl == 2) {
			Board.text = "You accept their proposal and watch them reach into their crotch with one hand and removing enough close for you to see with the other. Both of them have their eyes closed.\n \nYou can see how the girl already has three fingers inside her. Maybe she was thinking of doing this before they even arrived. She is moaning subtly, unlike the noise she was making with her fingers penetrating hard her cunt.\n \nThe guy was caressing his dick, encouraged by the noise the other servant was producing and by your stare on him. He did all he could to resist the urge to be as noisy as his fellow servant.\n \nYou do feel entertained. This show is giving you the urge to touch yourself as well. You reach into your pants and caress your crotch. The servants stop masturbating once they realize you are not looking.\n \n<i>“Please, let us help you.”</i> Says the guy. Both of them approach you.";

			if (GameControl.dick1Size > 0) {
				Board.text += "\n\nThey seat on each side of your crotch and caress your dick over the clothes. Then they remove everything between them and your dick. Both of them licking it immediately, one at the base and the other at the tip. They look entranced with your flavor.\n \nOne of the servants decides to deep throat you, pushing your cock as far as possible. Unlike Alba, this servants are not as experienced so half of your meat is still undevoured. The other servant compensates by caressing that exposed half until you cum on the other’s mouth.\n";
			} else {
				Board.text += "\n\nThey expose your crotch and your chest. One of the servants kneels in front of you and licks your entrance, penetrating you with sudden tongue movements.\n \nYou’d moan but the other servant is kissing your lips while caressing your chest. The servant leaves your lips to go down onto your nipples, biting them while the other is busy eating you out until you cum.";
			}
			Board.text += "\n\nFinally you arrive at Alba’s castle. More servants greet you at the entrance but only the girl that accompanied you in the chariot takes you to Alba’s bedroom.\n \nBoth of you enter without knocking.\n \nAlba was expecting you, so she did not act surprised when you caught her dressing in front of the mirror.\n \n<i>“You are here already. Good.”</i> She says while covering her naked breasts with her usual corset.\n \n<i>“Last time I showed you a little gadget I’ve been working on. But today I have investors coming to visit. So this is even more crucial than before.”</i> You can hear the excitement in her voice. She sounds confident that this project of hers will make her a lot of money, and increase her reputation in the business world.\n \n<i>“Let’s go. Everything and everyone is waiting for us. You were the only missing piece.”</i>\n \nYou accompany her to a big auditorium. The seats were full of investors in their finest clothing. And at the podium several of Alba’s machines were lined up.\n \n<i>“Tonight you’ll see all I am capable of, don’t be shy if you get to hot.”</i>\n \nYou see how her servants, now naked for the public, start to position themselves in the machines. While that takes place, Alba takes off her shorts and sits in a special swing, with two additional, smaller swings to place each leg. Living her cunt exposed to the public.\n \n<i>“Don’t mind if I also enjoy myself with this.”</i> She says playfully caressing her clit with one of her claws.\n \n<i>“First we have a newer version of my previous work.”</i>\n \nShe points at one of the servants that has his dick inside a box that moves away and back at him again, successfully masturbating the servant.\n \n<i>“Mm…that version was so boring. So I had to put in a little extra.”</i> She says inserting a finger inside her entrance.\n \nThe servant presses a button and the box starts vibrating uncontrollably. The servant can’t do anything except moan.\n \n<i>“Ahh…”</i>Moans Alba at her own fingers. <i>“You can even take it off its base…ahhh!”</i> She yells when a second finger gets inside her. You can’t help but to get aroused.\n \nThe servant takes the box and carefully lies down with his back against the ground. The box still vibrating with his dick inside it.\n \n<i>“Next we have…”</i>She lets out yet another moan while scissoring her fingers. <i>“we have an invention ahh for the more daring.”</i>\n \nAlba points at the servant that had knocked on your door today, she was using the machine you and Alba used last time, assisted by the other servant on the chariot. Her pussy was being smashed with such force that her eyes rolled back and her moaning became audible for everyone there. When she looked like she had reached her climax, the servant stopped working the handle but the machine did not stop.\n \n<i>“As you can see it can be enjoyed even without help.”</i>\n \nThe servant keep being fucked by the machine mercilessly. Faster than ever before.\n \nAlba tells you to come closer to her, you do and she says in your ear.\n \n<i>“As you can see, I made a few changes. Now it fucks you twice as hard when it works on its own.”</i>\n \nAlba kept going, stimulating herself and removing more and more clothing.\n \nDespite Alba’s introductions, all machines are functioning at the same time. The audience had already choose where to invest their attention and all of them were shamelessly masturbating.\n \nSome even had stood up and go all the way to the podium to cum over the servants or ask them for a little lick.\n \nShe was already finished announcing her sixth invention when she asked you to fuck her in front of everyone. She sat the other way around so she’d face the audience while her back was hovering the ground.";
			if (GameControl.dick1Size > 0) {
				Board.text += "\n\nYou were already erect and ready to fuck her.";
			} else {
				Board.text += "\n\nIt only took you a fraction of a second to put on your strap on. You were so ready to fuck her.";
			}
			Board.text += "\n\nAs soon as she placed herself on the swing you were already deep inside her. Moving to your heart’s content. Alba moaned with such urgency that everyone in the auditorium turn to see you.\n \n<i>“Ahh! And now, marvel at my newest invention!”</i>\n \nThe swing made moving inside Alba so much easier. You had all control over her body.\n \nThe entire audience kept their eyes on both of you fucking with ease. Half of the audience hurriedly stood on a circle with you in the middle, all of them with their crotches exposed crazily masturbating.\n \nBetween huge moans, Alba used the air she sporadically could get to talk about the advantages of fucking with her swing. With your help she showcased every position to her knowledge for her future clients who reached climax more than several times.\n \nYou too had come many times already by the time the exhibition was over.\n \nAfter that, Alba let some of her clients fuck the staff, and she took you to her room.\n \n<i>“You were great today. Such a handy companion. You deserve some rest.”</i>\n \nShe got in her bed, still naked and open her arms to you. You never dreamed of her offering you such kind gesture. You went besides her, hugged her and sleep until the next morning.\n";

			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 2) {
			Board.text = "You decline their offer in the most polite way, and decide to look at the window until you reach Alba’s place.";

			Board.text += "\n\nFinally you arrive at Alba’s castle. More servants greet you at the entrance but only the girl that accompanied you in the chariot takes you to Alba’s bedroom.\n \nBoth of you enter without knocking.\n \nAlba was expecting you, so she did not act surprised when you caught her dressing in front of the mirror.\n \n<i>“You are here already. Good.”</i> She says while covering her naked breasts with her usual corset.\n \n<i>“Last time I showed you a little gadget I’ve been working on. But today I have investors coming to visit. So this is even more crucial than before.”</i> You can hear the excitement in her voice. She sounds confident that this project of hers will make her a lot of money, and increase her reputation in the business world.\n \n<i>“Let’s go. Everything and everyone is waiting for us. You were the only missing piece.”</i>\n \nYou accompany her to a big auditorium. The seats were full of investors in their finest clothing. And at the podium several of Alba’s machines were lined up.\n \n<i>“Tonight you’ll see all I am capable of, don’t be shy if you get to hot.”</i>\n \nYou see how her servants, now naked for the public, start to position themselves in the machines. While that takes place, Alba takes off her shorts and sits in a special swing, with two additional, smaller swings to place each leg. Living her cunt exposed to the public.\n \n<i>“Don’t mind if I also enjoy myself with this.”</i> She says playfully caressing her clit with one of her claws.\n \n<i>“First we have a newer version of my previous work.”</i>\n \nShe points at one of the servants that has his dick inside a box that moves away and back at him again, successfully masturbating the servant.\n \n<i>“Mm…that version was so boring. So I had to put in a little extra.”</i> She says inserting a finger inside her entrance.\n \nThe servant presses a button and the box starts vibrating uncontrollably. The servant can’t do anything except moan.\n \n<i>“Ahh…”</i>Moans Alba at her own fingers. <i>“You can even take it off its base…ahhh!”</i> She yells when a second finger gets inside her. You can’t help but to get aroused.\n \nThe servant takes the box and carefully lies down with his back against the ground. The box still vibrating with his dick inside it.\n \n<i>“Next we have…”</i>She lets out yet another moan while scissoring her fingers. <i>“we have an invention ahh for the more daring.”</i>\n \nAlba points at the servant that had knocked on your door today, she was using the machine you and Alba used last time, assisted by the other servant on the chariot. Her pussy was being smashed with such force that her eyes rolled back and her moaning became audible for everyone there. When she looked like she had reached her climax, the servant stopped working the handle but the machine did not stop.\n \n<i>“As you can see it can be enjoyed even without help.”</i>\n \nThe servant keep being fucked by the machine mercilessly. Faster than ever before.\n \nAlba tells you to come closer to her, you do and she says in your ear.\n \n<i>“As you can see, I made a few changes. Now it fucks you twice as hard when it works on its own.”</i>\n \nAlba kept going, stimulating herself and removing more and more clothing.\n \nDespite Alba’s introductions, all machines are functioning at the same time. The audience had already choose where to invest their attention and all of them were shamelessly masturbating.\n \nSome even had stood up and go all the way to the podium to cum over the servants or ask them for a little lick.\n \nShe was already finished announcing her sixth invention when she asked you to fuck her in front of everyone. She sat the other way around so she’d face the audience while her back was hovering the ground.";
			if (GameControl.dick1Size > 0) {
				Board.text += "\n\nYou were already erect and ready to fuck her.";
			} else {
				Board.text += "\n\nIt only took you a fraction of a second to put on your strap on. You were so ready to fuck her.";
			}
			Board.text += "\n\nAs soon as she placed herself on the swing you were already deep inside her. Moving to your heart’s content. Alba moaned with such urgency that everyone in the auditorium turn to see you.\n \n<i>“Ahh! And now, marvel at my newest invention!”</i>\n \nThe swing made moving inside Alba so much easier. You had all control over her body.\n \nThe entire audience kept their eyes on both of you fucking with ease. Half of the audience hurriedly stood on a circle with you in the middle, all of them with their crotches exposed crazily masturbating.\n \nBetween huge moans, Alba used the air she sporadically could get to talk about the advantages of fucking with her swing. With your help she showcased every position to her knowledge for her future clients who reached climax more than several times.\n \nYou too had come many times already by the time the exhibition was over.\n \nAfter that, Alba let some of her clients fuck the staff, and she took you to her room.\n \n<i>“You were great today. Such a handy companion. You deserve some rest.”</i>\n \nShe got in her bed, still naked and open her arms to you. You never dreamed of her offering you such kind gesture. You went besides her, hugged her and sleep until the next morning.\n";

			endTurnFun ();

			return;
		}

		///////////////////////////// temp

		if (selector == 0 && confirmationControl == 9999) {
			Board.text = "";
			return;
		}

		if (selector == 1 && confirmationControl == 9999) {
			Board.text = "";
			return;
		}
	}




	static int loadChar(int id){
		int i = 0;
		while (i < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [i].charID == id){
				return i;
			}
			i++;

		}
		return 0;

	}

	void loadAlba(){
		iAlba = 0;

		while (iAlba < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iAlba].charID == 13000){
				WorldControl.NPCID = NPCCharList.CharFollower [iAlba].charID;
				break; 
			}
			iAlba++;

		}

	}

	void endTurnFun(){
		//panContinue.sortingOrder = -500;
		panConfirmation.sortingOrder = -500;
		panMainPanel.sortingOrder = -500;

		PanLeftManagement.endTurnControl = true; 
		endTurnPanel.sortingOrder = 500;


	}

}
