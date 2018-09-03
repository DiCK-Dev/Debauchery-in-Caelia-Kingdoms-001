using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class LucinaOld : MonoBehaviour {

	public Text Board; 
	static int iLucina;

	static int sexConfirmation; 
	static int continueControl; 


	static string mcpronSonDau = "";
	string mcpronLordLady; 

	public Canvas panInitialQuestion; 
	public Canvas endTurnPanel; 
	public Canvas panContinue;
	public Canvas panCorruptChoice; 
	public Canvas panSexConfirmation; 

	public Canvas panSlimeQueen; 

	public Canvas panMainMenu;

	//public RectTransform panBackCity; 
	public Canvas mainPanelSlimeQueen; 
	public Canvas mainPanelSymbiote; 

	public Text panConfirmationTitle;
	public Animator panConfirmation; 
	static int conSelector; 

	public Canvas sexScenes; 

	Parser myParser = new Parser(); 





	public void lucinaStart(){


		SceneManager.LoadScene (62);

		
		switch (QuestControl.lucinaQuest)
		{
		case 0: 
			Board.text = "This is still work in progress, look forward to next updates!";
			panMainMenu.sortingOrder = 500; 
			//panInitialQuestion.sortingOrder = 500; 
			//QuestControl.lucinaQuest = 1;
			break;
		case 1: //talk past
			Board.text = "You ask about her past, as he didn’t had the opportunity before they got separated at that time. She seems surprised and definitely happy by your curiosity.  She thinks an answer for half a minute. <i>\"Well, before I engaged with your father, I was an acolyte of the temple. I was studying to become a priestess of Cornelia, to be able to lead the townsfolk in prayer and faith. We also performed healing services if needed. Unfortunately I wasn’t advanced enough to learn how to do it.\"</i>\n\n<i>\"One important thing I learned from my time at the temple is that a disciplined mind is capable of extraordinary feats. I never truly understood the training and meditation they forced us to do at the temple back then, but now I see that they were trying to strengthen our minds. After all, if I wanted to be a priestesses, I had to be ready to resist temptation and corruption. After I became an orphan when I was a child, one of the head priestess saw my potential and took me into the temple.\"</i>\n\nShe smiled sourly as she goes on reminiscing about her past. <i>\"At first it was good, but after some years in there, a sense of wanderlust grew within me. I found nature fascinating, even more than the thick books that were dusty in the temple halls. The same head priestess that took me in saw my curiosity, so she took me on walks through the forest. She knew a lot about it, and I learned a lot from her experience.\"</i>\n\nYou tell her that she describes that head priestess as if she were her parental figure. She solemnly nods at your commentary. <i>\"Yes. she was like a parent to me, definitely. She did not want to care too much for me as so she didn’t spoil the temple's training. After all, she has been always a follower of Cornelia, the Goddess of Discipline, but I’ve been a follower of Servilia, so her treatment is somewhat strange.  But despite anything, I could feel the love from her in her own way...</i>\"\n\nYou can see her tearing a bit, so you circle her shoulders with one or your arms . <i>\"It was good to remember those things. Perhaps we can continue this at another time, you must be a busy leader right now.\"</i> she says as she leaves the room."; 
			continueControl = 0;
			panContinue.sortingOrder = 500;
			break;
		case 2: //talk symbiote
			Board.text = "You couldn’t help but stare back to your mother's clothes and you end up appreciating her form once again, as that things surely tries to accentuate her forms to entice others, definitely a Lost trait. Your mother notices that and clears her throat to call your attention. She sighs, <i>“I suppose you want to hear of how I ended stuck wearing this thing,”</i> she emphasizes as she ran a finger on the black ooze over her body.\n\n<i>\"After I made sure that you were safe, I escaped from the castle and spent a few days covering my tracks. I thought your uncle would send troops to finish the job, but he didn’t, and that surely surprised me. I was scared of what he could try to do to me if he had caught me, but I wasn’t scared enough for not looking for my children.\"</i> she says as it gives you a gentle smile before continuing, <i>”I started to look for you in the forest. It is vast but I know it well. I avoided most of the environment dangers and scared off some of the creatures with my bow.\"</i>\n\nYou tell her that he didn’t knew that she has that much knowledge of surviving in the wild. Your mother chuckles at your comment. <i>]\"Before you were even born, I studied this forest a lot, so I know it from side to side. Places where to find fresh water and some food, where to set up camp, that kind of things. Anyways, I made up camp on a particularly dark night few days prior to my arrival at the castle. I went to a nearby pond which I knew held clean drinking water. But I shouldn't have been so confident in my knowledge of the forest. The plague also affected the forest, twisting it in unknown ways during the course of the years.\"</i>\n\nYour mother looks down ashamed at her failure as she is probably remembering what happened at the pond. <i>\"As I got close to the water, I saw it shimmering slightly. Now that i think about it, I should have taken that as my signal to run. But I dealt with everything up until that point with such skill that I didn’t saw that the pond didn't had any water but rather had something vile instead. A formless thing reached out to pull me into the pond, but pulled the bow instead. After that I tried to ran back to the camp with the monster behind me.\"</i>\n\nShe shudders, you try to approach her but she raises a hand to stop you, as she continues her story. <i>\"Without my weapon I was defenseless, but I still had something that these lust-guided monsters didn't... my mind. I devised a plan as I returned to the camp. When I arrived, I hid behind my make-shift tent quickly. As soon as the monster got within range of the campfire, I pushed my tent along with the monster, forcing it into the fire. I didn’t had time to celebrate however, as I took out the lamp oil I carried with me and throw the bottle at the fire. It writhed in pain like nothing I have ever seen.\"</i> \n\nYour mother sits down again in the chair that she was using. You walk to the back of that chair and place your hands over her shoulders, before asking what happened next. <i>\"The fire engulfed the tent, as the fire was stronger than ever. I grabbed all the supplies that I could get and dashed out of there. I barely walked a small track before I realized that something slimy was holding onto my leg and expanding from there. I tried removing it but I was tired. and yet nothing worked, as it was expanding and covering my entire leg in a matter of minutes. So I walked until I was sure that I was out of the camp’s range, and then I did the only thing I could think that could help me fight back: I meditated. I thought that the last weapon I had at that moment was my own mind. All I could think of at that time is how I want to protect the family I had left. My purpose was giving me strength as that thing tried to overcome my willpower.\"</i>\n\nShe smiles at the memory for the first time since she started speaking about it. <i>\"You could say that my family saved me from that monster’s corruption. Everything was worth it, as I reunited with you again. I will make sure that your sister also returns.\"</i>\n\nAfter that, you thank your mother for her time and leave her to continue with her investigation, thinking on all the things she had to endure just to find you."; 
			continueControl = 2;
			panContinue.sortingOrder = 500;
			break;
		case 3: // talk city past
			Board.text = "Now that you are close to your mother, you want to know about the city, it's past and how she survived it. You ask her if she knows more things about the city that you should know as the one in charge.  Your mother looks up from the book she is reading and sighs. <i>\"All of this happened when your uncle took over, at least that’s what I heard from where I was at the time. He spreaded corruption and antipathy to the higher spheres. The decadence of the city began with your uncle, the gap between the poor and the rich became an abyss, as the lower ones crumbled over the weight of the ones in charge. The diseases spread like wildfire, and the temple services weren’t enough to deal with it\"</i>\n\n<i>\"Then there were the crime issues. Some of the other houses took the advantage of the poor condition of the lower citizens, but your uncle did nothing to stop them. They were paying him off, probably. More money exclusively for him, to satisfy his own needs despite the condition of the city. The people suffered under his rule, every person from Aurorum that I crossed paths, were disgusted with their new ruler. He cut from any place he could to cover his monstrous lifestyle, treating their servants like cattle, left to die in the streets of hunger and disease.\"</i> she says this while seething with anger. <i>\"The other houses had their own armies guarding them and their properties but crime leaked into the city until it filled it to the brim.\"</i>\n\nYou ask your mother how she knew all of that stuff. She sighs and looks at the floor for a second. “My child, perhaps I left the place behind, but my heart was with the city of Aurorum. I dwelled in the forest as close as I could to avoid detection. The ones who worked at the temple always left some supplies for me in some specific places of the forest. I was searching for you two, after all. I dwelled in the ruined parts of the city, when the Plague intensified, but I was always searching for you two. Until your bodies were in front of me, I would never stop trying” \n\nShe then walks to the door and says, \"But now I found my child, and I would like to celebrate with some tea.  Do you want some?\"  You politely decline and excuse yourself, thinking on how your uncle really screwed the whole city only for his benefit. How truly far are you from him in reality?\n"; 
			continueControl = 4; 
			panContinue.sortingOrder = 500;
			break;
		case 4: // corruption/purification
			Board.text = "Now that you are close to your mother again you realize that although she is the same person inside, the symbiont definitely  has had some influence over her, corrupting her thoughts. You know you can help to overpower the beast and take full control of herself, but you could also push her into the abyss and corrupt her, what is your choice?  "; 
			panCorruptChoice.sortingOrder = 500;

			break;
		case 5: // corrupt / purify 1
			panContinue.sortingOrder = 500; 
			if (QuestControl.lucinaCorrupt == true) {
				Board.text = "You think that your mother is fighting the opportunity that creature is giving her. You can see that thing is making her more sensitive, increases her stamina and is trying to free her from the shackles of the discipline of the others. You want her to sate her urges whenever she wants and with whoever she wants. You can see how she sees you, her eyes full of lust, so you start to think on a plan to further your goals.\n\n";
				Board.text += "At first you see when she goes to the library. When you are sure that she will be there, you instruct to your servants to wear skimpy clothing and to work at the library as they play with each other from time to time, with the excuse that you require a lot of books for one investigation you’re doing on your own. You peek from one of the sides of the library, watching as your mother is enjoying the show as two servants are fondling each other close to her before returning to their duties.\n\nYou can see that she is trying to concentrate on her books but she can’t look away as three of them are making out close to her, their moans and sighs filling her ears, until she puts the book down as she pants on her own. You can see that she moves one of her flexible hands down her legs, covering herself with the table that is in front of her. After the servants retire from the place, she rise from the chair that is all sticky and not from her skin. You can see that she moves quickly as you follow her. You can see that she goes to the baths, probably to wash herself and cool off a bit. And with that, the first part of your plan is complete and you have an idea for the second.\n";

				continueControl = 6; 
			} else {
				Board.text = "You think that despite the creature that is surrounding her body, you know that your mother is still inside her, fighting for her mind everyday. You want to help her clean her corruption as much as possible, before she loses herself to her urges and you lose her a second time. And with that, you start thinking on ways of helping her with her mental fortitude.\n\n";
				Board.text += "You found your mother in her bedroom, trying to read some books about her condition, so you knock the door as she tells you to get in. You tell her that you have a small surprise for her, as you tell her to follow you, because you have a small surprise for her. <i>”For me? You shouldn’t have,”</i> she says as she follows you into one of the rooms of the castle. \n\nAfter you’re inside, you show her that you found some of her old dresses, as you tell her that you remember her in some of these ones. She gets closer to them, her face brightens when she sees them. <i>”Oh for Valeriss! Where did you find them?,”</i> she says, as she touches them carefully as not to damage them, feeling their fabrics. You tell her that you found them a while ago, but you first wanted to repair them and wash them. <i>”I remember this one! With this one I attend to a grand ball when you were young. And with that one I always went to help your father with their work, it was like my ‘work clothing’. All of these clothes bring back memories. I wish I could wear them once more,”</i> she says with a wishful tone. You place a hand over hers and tell her that she will do it one day, that she should be thinking on the next dress to wear because that is a fact.\n\nShe smiles at you and nods. <i>”You’re right. I can’t think negatively about this. I’m sure that I will wear these ones someday and be the person I once was, without a doubt”</i> she says, a little bit more hopeful than before. She excuses herself before leaving, as you look at the dresses for a second. Probably she won’t fit with that chest of hers in most of these, perhaps she’ll need new clothing.\n";

				continueControl = 6; 

			}

			break; 
		case 6: // corrupt / purify 2 
			panContinue.sortingOrder = 500; 
			if (QuestControl.lucinaCorrupt == true) {
				Board.text = "You know that you’ve been improving with your corruption path over your mother, Lucina. She is more prone to deal with her urges rather than contain them, especially those that have you in between them. So you craft a series of events to push her enough to corrupt her completely for the last time.\n\n";
				Board.text += "For this plan, you decide to wait for her to be visibly in need to sate her lust. You know that she tries to hide and masturbate to lower her lust as far as possible, as that it's her way to still keep a grasp of purity in her: By not including others. But you are going to change that.\n\nOn that occasion, you can see that she is trying to sneak out to the garden once more to masturbate, but you cut her short on the spot. You can see that her nipples are pressing through the black latex creature that is covering her whole body. Her face is red, something that is more evident over her black surface. You ask her where she is going. <i>“Oh, dear. I have some urges to attend… If you excuse me,”</i> she says, trying to get past you but you stand your ground. You tell her that she is your mother, and that maybe perhaps she isn’t holding a title of power enough to spread her influence by her own, she has the servants in his castle to her disposition.\n\nShe is surprised of that remark of yours. <i>“Are you telling me that I can use the servants of the castle to use them as I like?,”</i> she says with a hint of excitement on her voice, as you can smell the scent of fluids coming from her groin. And because of that, you brought one of your servants to help her in this situation. You snap your fingers as one male servant arrives next to you and calls for his orders. You tell him that from now on, he will respond to your mother’s urges until further notice. The servant agrees and gets closer to your mother. She is touching herself already, her lust getting to unbearable levels. <i>“Lick it,”</i> she orders him. After he gets the order, he kneels in front of her and began teasing her rubbery cunt with her tongue, licking the sticky fluids that are already soaking her insides. She starts moaning like a whore as the servants works her pussy with diligence. You can see how she grabs his head as he presses it against her twat.\n\nAnd with that, you leave your mother with the new toy, as you can hear her lusty screams echoing through the corridors close to her. You smile with that, knowing that she is a step closer to your goal.\n";

				continueControl = 8;
			} else {
				Board.text = "You know that you are on the right path to help your mother to regain her purity, but you know that she has still some ghosts from her past that she requires to exorcise before returning to be the proud woman that she was. So you think of a plan to return her those good qualities she had from her older self. \n\n";
				Board.text += "You want her to remember her older self a bit more, so she can remember what it was to be a noble, just to keep her mind focused on the important things. So you prepared a special occasion and invited your mother to attend. <i>”I can’t wait to go to a special occasion with my child! But I don’t know what to wear!,”</i> she says before laughing, faking some distress, as both of you know that she is unable to wear anything, but she seems to be taking it with humor.\n\nThe day arrives and your mother is excited as both of you arrive at the event’s room in the castle. When she arrives, she is speechless to find many familiar faces reunited. You did your research and tracked most of the people that it was known to be close to your original family. It wasn’t something easy as most of them were in jail or exiled, but your mother was worth it. As she arrives, the announcer calls her “Former Lady of Aurorum”. When she sits next to you, most of the people around her cheer her. She is at the edge of tears, as she starts talking with most of them.\n\nAfter that, you call for a toast, celebrating the return of Lucina to the city that she helped build alongside your father. The people gathered clapped at your speech, as most of them thanked your mother and your father for everything you did to help them. At the end of the night, the guests left as most of them said that they would be residing in the city again, after knowing that her child is guiding the place once more. When they left, your mother cleans her tears as she looks at you. <i>”Thank you my child for this gift. This is more than a mother would deserve.”</i> she says as she hugs you. <i>”You’re just like your father… Just like him,”</i> she says, before leaving the place to her room once more.";
				continueControl = 8; 
			}
			break;
		case 7: // slime queen
			Board.text = "Lately you realize that the beast is becoming stronger and stronger, and Lucina is struggling a lot to keep it out of her mind. You could help her to overtake the creature, but you could also show her why it is best to let herself go to the beast. \n";
			panSlimeQueen.sortingOrder = 500; 

			break; 
		case 8: // ending
			if (QuestControl.lucinaCorrupt) {
				if (QuestControl.lucinaSlimeQueen) {
					Board.text = "After you finally helped your mother on how to deal, with the symbiote and pushed her to take the path of the beast, you decide to ask her some questions, as you are sure that she knows the city from the inside, or at least she knew. So you must return to your objective of retaking the city that you want to rule. So you decided to press the matter with her, as you know that she is unresponsive at first, but you insist on asking her about the situation, especially when it seems that traces of her former self resurface for a bit. One of those times, you command her to answer, more to the instinctive part of her that follows anyone else that is stronger than her, something that makes her shake for a second before starting to speak.\n\n<i>\"The church...\"</i> she says before taking a good look through the window, as you can see the church at the distance. You remember now, she was part of the church. <i>\"Their influence... important to the city\"</i> The slime girl places herself against the window as you can see that there it seems to be a small congregation of people at the entrance. <i>\"Itzel. She is new. She must join you... With her, the city will be yours, my progeny.\"</i> And with that, you think that you have enough to work with, so you enlist to finally meet this priest.";
				} else {
					Board.text = "After you finally helped your mother on how to deal, with the symbiote and pushed her to take the path of the servant, you must return to your objective of retaking the city that you want to rule. So you decide to ask her some questions, as you are sure that she knows the city from the inside, and now that she is more docile to your orders, this is an easier task. So you call for her to your office and demand her to explain what she knows about the city, without leaving any vital information out just because it isn’t fair, as you know that she knows the city from the inside better than most of the people around there. She look at the floor before nodding. <i>\"Of course, my master...\"</i> She starts by thinking about it for a bit.\n\nAfter a bit of thinking and the sound of your foot tapping against the floor, she says. <i>\"I think that the church is the better option… if you like it.\"</i> she says before taking a good look through the window, as you can see the church at the distance. You remember now, she was part of the church. Well, at least she is free of those restrictive and stupid ways. <i>\"Despite their weak way of seeing things, their influence is strong in the citizens. \"</i> Your mother points at the congregation of people that were gathering inside. <i>\"I’ve heard about the priest in my errands, my master. Her name is Itzel.\"</i> And with that, you think that you have enough to work with, so you enlist to finally meet this priest.";
				}
			} else {
				if (QuestControl.lucinaSlimeQueen) {
					Board.text = "After you finally helped your mother on how to deal with the symbiote, you pushed her to take control of that creature with her forcé of will. So you must return to your objective of retaking the city that you want to rule. You decide to ask her some questions, as you are sure that she knows the city from the inside. So you brought the matter to her, to which she starts to remember how the city works. You can see that she liquefies, as she tries to think on a proper way of helping you. <i>\"Oh my child, your father had the same issue as you at first, but he wasn’t out of the bloodline at least.\"</i> \n\nAfter a bit of wandering, you can see that she oozes close to you, her torso returning to her normal shape. <i>\"The church...\"</i> she says, before sliding through the floor towards your office, searching for something specific. You can even see her gorgeous body squeezing through the door more than pushing it open. In there, she searches for something in your shelf, until she takes out a small book and opens it. <i>\"I was right. Iztel is the name of the new priest\"</i> She then moves close to the window, pointing at the church. <i>\"The influence of the church in the city is big. Since the schism from the Citadel, there has been problems with the church. I’m sure that you can help the priest Itzel to deal with that and in return, she will help you on returning this city to its splendor that your father sought it to be\"</i>. You ask her if she wants to follow you, but she shakes her head. <i>\"They shouldn’t see me like this...\"</i> she says after covering her body, so you decide to leave her to be so you can finally meet this priest and further your goals.";
				} else {
					Board.text = "After you finally helped your mother on how to deal with the symbiote, you pushed her to expel that creature’s conscience once and for all, regaining your mother finally without fear of losing her to the slime queen’s grasp. but after that, you must return to your objective of retaking the city that you want to rule. And with that, you decide to ask her some questions, as you are sure that she knows the city from the inside better than most of the people around there. So you brought the matter to her, to which she starts to remember how the city works. You can see that she walks from side to side, thinking on a way of helping you. <i>\"Oh my child, your father had the same issue as you at first, but he wasn’t out of the bloodline at least.\"</i> \n\nAfter a bit of wandering, you can see that she founds out an answer. <i>\"The church...\"</i> she says, before sliding through the floor towards your office, searching for something specific. She slams the door for the hurry, but you follow her quite close. <i>\"I was right. Iztel is the name of the new priest\"</i> She then moves close to the window, pointing at the church. <i>\"The influence of the church in the city is big. Since the schism from the Citadel, there has been problems with the church. I’m sure that you can help the priest Itzel to deal with it in the same way that you helped me, she will help you on returning this city to its splendor that your father sought it to be\"</i>. You can see hope in her eyes, so you decide to finally meet this priest and further your goals.";
				}

			}
			endTurnFun ();
			QuestControl.lucinaQuest = 9;
			NPCCharList.CharFollower [iLucina].isRecruited = true; 
			break;
		case 9: // normal start
			lucinaWelcome ();
			if (QuestControl.lucinaSlimeQueen == true) {
				mainPanelSlimeQueen.sortingOrder = 500;
			} else {
				mainPanelSymbiote.sortingOrder = 500;
			}
			break;

		}


	}


	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	public void continueScenes(){
		// this controls what happens when you give it continue, goes on the button continue
		switch (continueControl) {

		case 0: //Talk about her past 2
			Board.text = "You tell your mother to continue the conversation from the last time you spoke. She smiles and point to the chair that is in front of her, so you sit as she recalls where she was. <i>\"The trips to the forest continued for several years. She said that one day I’ll be able to channel the powers of life, but first I needed to understand how life works\"</i>\n\nYou quickly interject by asking if she had any trouble with the native wildlife. She says with a confident smile on her face, <i>\"None could face the holy faith of the priestess, and my bow skills helped from time to time. After a while, we used the paths less dangerous. Some of the usual predators got used to our presence after a couple of clashes, so they left us alone at the end.\"</i>\n\nShe runs a hand over her skin, as you can see its rubbery texture reacting to her touch. <i>\"Even when I learned everything that I had to learn for the forest, the strolls continued.  I loved spending time with her. Now that I think of it, maybe she saw me as her daughter, I’m not sure. And with her company, It was easier for me to understand the lessons of Servilis, as I just want her to be proud of me.But after the Plague struck the cities, a lot of healers got infected, so she was called to the city of Kha-arak and I was left to make the trips on my own.\"</i> her cheerful demeanor sombers a bit, you think that maybe that was the last time she saw that priest.\n\nOut of the corner of your eye you see Helena waiting for you to notice her.  As you make eye contact she hastily says, <i>\"My Liege, my lady, dinner is ready.\"</i>\n\n<i>\"I’m sure that we can continue this conversation on a later time. You need to eat properly.  You have a city to rule and you cannot do it with an empty stomach,\"</i> your mother says as both of you have a meal together, before you return to your duties.";
			continueControl = 1; 
			break;
		case 1: //Talk about her past 2
			Board.text = "You ask your mother how she went from priestess to lady. <i>\"Since when did you get so curious about your mother?,\"</i> she asks you with a smile as she leaves the book in the table.\n\nYou tell her that you really don’t know much about your family, more than the short time you were together, and you want to catch up on what happened to her. She touches your forearm and nods slowly to my reply. <i>\"Where was I?. Right, after the priestess left the temple. I had started to collect herbs and berries to help the head priestess and the orphans close to the temple. On one of these trips I had met a stranger that seemed lost in the woods, as his clothing was ragged and he surely looked exhausted. I approached him with caution but still willing to help. When he saw me, he walked quickly towards me and plead me to help him to get out of the forest. As an acolyte of Servilis, I was charged to help those in need, so I assured him that I would help him back to the nearby town.\"</i>\n\nYou can guess that she is probably talking about your father, so you raise your eyebrows as she looks at you. Your mother giggles and nods to your signal, <i>\"It wasn’t that hard to notice, right?. But yes, he was your father. Though I had no idea that he was a young lord. He was wearing commoner clothing and had a basic sword on hand, surely he looked just like any adventurer or mercenary.  As I lead him through the forest, we talked about many things. We got along quite well, as I spoke about the clergy and he told me about the city and the culture of faraway lands. After that, we spoke about many other things. He surely had its special charm,\"</i> she says as she places a finger on her lip, before laughing a bit.\n\nYou ask her about that last remark, he sounds quite the ladies man. Your mother laughs and moves a hand, <i>\"Totally the opposite. But he was very genuine and honest.  He had a dashing smile. When we got to the edge of the forest, he said with a lot of confidence that he wanted to see me again, giving me its name. How could I refuse such invitation from someone that I like to talk to?. When I went back to the temple I told the head priestess of Servilia the bumping with the stranger. I didn’t thought that it was something bad. They listened but when she heard the name of the stranger, she worried a bit. She told me that she knew the lord's family personally and knew the boy to be good, but his father wasn’t the best of the best. She said that my oath wasn’t complete yet and was free to do what I wanted.\"</i>\n\nYour mother takes out the relicary that she always carries and takes a good look at the drawing of your father in it. She left the priesthood that she wanted so much for your father? That’s some sacrifice. <i>\"It was a short courtship and then I had you. I think I spent all my energy on you and your sister. I think that I did the right thing. After all, Servilis is the Goddess of Love, and I surely love my family with all my soul\"</i>\n\nYou give her a hug and thank her for being so open with her past. <i>\"I love to talk to you, my child. Anytime,\"</i> she replies stroking the hair on your head as you move away from her and leave the place.";
			endTurnFun ();
			panContinue.sortingOrder = -500;
			QuestControl.lucinaQuest = 2;
			break;
		case 2: // talk symbiote
			Board.text = "On this occasion, you ask her what she knows about that creature, as perhaps he can search more information on his travels if he knows a bit more about it. <i>”She was a slime girl, but she was faster and had a command of her own slime in a level that I’ve never seen again since. After some time of investigation, I think that it was a slime queen”</i> she says, as she pats with one of her fingers, a book that is in the table in front of them. <i>“They normally have other slimes protecting them, but perhaps this one was too young. Either way, it’s dead but I think one of its parts latched onto me.\"</i>\n\n<i>\"It seems to be some sort of parasite with a singular purpose,\"</i> she says as she takes a look at one of the books that she has over her lap. <i>“It cannot communicate with me, but I am able to prevent it from spreading further with mental fortitude.  The remains of the slime queen could have wanted to survive by picking a nearby host and transforming them into the new slime queen, and that somehow worries me, because it’s somehow different\"</i> she says as she scratches her arm, definitely worried..\n\nYou ask her what she means. You can see her eyes going blank for a second, as if she is drifting through her memories for a second. <i>]\"Ahem, I mean it feels rubbery to the touch, like some kind of elastic thing.  I think the oil and the fire may have caused some sort of reaction that mutated this thing.  Because I know that it feeds from the corruption too. I think that without this thing, I would be another Lost wandering in the wilds\"</i>\n\nYou walk to her side and say that she is safe in the castle and that she doesn’t need to worry about those dangers getting in there. She smiles as she pulls you close to her chest. <i>“I’m supposed to be the one supporting you, my child. Not the other way around”</i> she releases you, as you excuse yourself telling her that you have some things to do and leave.";
			continueControl = 3; 
			break;
		case 3: // talk symbiote
			Board.text = "This time you ask your mother if that rubbery thing is something uncomfortable. She blushes a bit. <i>\"It feels quite strange. Sometimes it feels like I’m wearing nothing at all. And it doesn't feel as tight as it looks.  It’s like second skin, at least it is now like that, it took me some time to get used to it\"</i>\n\n<i>\"Being completely honest, it has made me more... sensitive,”</i> she adds in a shame tone. <i>“Just going to the library or to the courtyard can be taxing on the mind. I find it quite difficult to resist at times.\"</i>\n\nYou wonder if hugging her is algo causing her some troubles, so you ask her if you should avoid physical contact with her to help her stay calm. Your mother gets up from her chair and stands in front of you, her face is a mix between frustration and anger. <i>\"I didn't search for you on the wilds and finally found you, just for some monster leftovers take you away from me again. This doesn’t change the fact that you’re my child, and I want to make up for the time that you grew away from me. This ‘thing’ won’t stop me from that\"</i>  \n\nYour mother embraces you tightly without saying anything else and you hug her back. It seems that the events after your father's death have afflicted her more than you thought. She pulls back and you can see that her face is a bit red. She quickly leaves the room and says, \"I’m sorry, I have to leave.\"";
			endTurnFun ();
			panContinue.sortingOrder = -500;
			QuestControl.lucinaQuest = 3;
			break;
		case 4:
			Board.text = "Now you know how she survived, but you want to know how she escaped from your uncle’s grasp. How she outwitted the guards of the old Lord of the city. <i>\"I may be a bit old, but I’m resourceful, my child,”</i> she says with a thin smile on her face. <i>“First thing I did was go to the old tower. You know, that your sister was getting tutored by that old woman teaching her alchemy. She was always gifted in these mystic arts. We had her room moved to the tower after that incident with her setting her curtains on fire. At least in the tower she could practice her… powers, without the risk of burning everything down. The alchemist said that her abilities were fascinating, but definitely strange\"</i> she says, drifting through the past of her family probably.\n\nShe snaps out of her memories, then returns her gaze to you. <i>\"But I’m getting off topic. I head straight for her tower and found that she was getting a lesson from the old woman.  I told her about what happened and you remember her temper, she got angry at your uncle. Just like when you two fought over small things.”</i> she said with a smile on her face, as both of you remember a bit about your sister. She was always on the brink of anger. You always thought that it was due to her powers. <i>“She realized that we could not fight all of the guards, so we probably have to think on another way. The old one spoke up and said that she knew a secret passage that could get all three of us out of the castle. Seeing that we have no other choice, I asked her to lead us to the passage. She guided us through the dark halls of the castle, as she opened some loose bricks on one of the bedrooms. She guided us through the complete darkness, until we finally say the light at the end of the tunnel. After getting used to the light once more, I found out that we got outside of the castle walls and into the city.”</i>\n\nConfused, you ask your mother where your sister is, if they escaped together. Your mother replies with a hint of pain in her chest. <i>\"I could not risk him catching all of us. I told the old woman to take my daughter far from here, to a place where I couldn’t guess at first. Your sister was angry and tried to fight the old woman, as she screamed our names as she was being taken away. She said that she would never forgive me for sending her away from her family as they left. I wanted to talk to her, to explain why I took that decision, but I don’t think she would've listened to me. After that, I went directly to find your protector, as I knew the perfect candidate for that.\"</i>\n\nYou don’t blame your mother for sending you away, as you knew that it was for your own safety and you tell her that. Knowing that your sister is out there gives you a glint of hope. After that, you excuse yourself for the moment and return to your duties.\n";
			continueControl = 5; 
			break;
		case 5:
			Board.text = "There was one last thing that was on your mind about what happened. You find your mother and ask about your father's death. You know that it’s something delicate, but you must know.  \n\nShe gets up and walks into the balcony, looking at the place where the guards are stationed in the distance. After that, she turns to see you and calls you with one hand, she starts speaking when you reach her side. <i>\"Your father wanted the city to prosper and progress but even he knew that it’s a battle that is fought every day.  He fought night and day to bring splendor to the city. He collected fair taxes and build important things so the city could improve and grow. When the war with the Citadel grew close, your uncle and your father discussed for days. Your father wanted the city to maintain his sovereignty, but your uncle wanted to give the city to the Citadel, in exchange for profits. We expected him to be loyal to his family, but he started plotting after the discussion failed“</i>\n\nMother puts a hand on her heart as if to steady herself and says, <i>\"He gathered some of his troops among other from some houses that betrayed your father, and helped the Citadel troops to force a coup d’etat. They surrounded the place where your father and his loyal troops stood. They asked him to surrender the city, and that they would spare their lives.”</i> she says, as you can see that her hands tremble a bit.\n\n<i>\"Your father didn’t want them to take the city, but he doesn’t want any unnecessary bloodshed too, so he finally surrendered the title of Lord. At that time I made sure that you and your sister were away from the castle,\"</i> she points to a faraway spot with a shaky finger, close to one of the walls that surround the castle. <i>“At that spot, that’s where they executed your father and their loyal soldiers”</i>\n\nYou hug your mother from her side. The silence reigns for several minutes, as she contain all her tears until she turns around and looks at you, <i>\"Things are different now, you're here in your rightful place as leader and I will help you with the best of my ability. I’m sure that you father would be proud of your performance\"</i>\t";
			endTurnFun ();
			panContinue.sortingOrder = -500;
			QuestControl.lucinaQuest = 4;
			break;
		case 6:
			continueControl = 7; 
			if (QuestControl.lucinaCorrupt == true) {
				Board.text = "You start by watching when she baths, as you know that its something important to help her keep that monster calm. So, when you are sure that she is taking a bath, you get naked quickly and enter into the same bath as her. You can see that she is trying to clean her new skin with the best of her ability, but for some reason she is doing it slowly. Perhaps it's too sensitive, so you approach her slowly until she notices you.\n\nYou greet her as she wasn’t expecting you, judging from her face as she is blushing a bit. You can see her peeking at your naughty parts from time to time as she bits her lower lip. You tell her that you can help her bath if she can help you bath, she’s your mother after all and you thought that both of you could spent some time together in family. She gulps but her lust slowly wins her as she accepts. So, you use your hand to wash her malleable skin carefully. She closes her eyes as she enjoys your tact, as you rub her body in a sensual way, from her belly to her breasts, exciting her more and more.\n\nWhen you finally washed her, she returns to reality as you can see that her legs rub against each other, probably from her lust increasing. After that, she washes you in the same manner, enjoying every bit of you, but avoiding your genitals. but at least you know that this is a step forward. You can even hear her panting as she finishes washing you. After that, you can see her excusing herself before drying herself with a towel and almost running to her bedroom. You know what she is planning to do, and you expect her to do it.";

			} else {
				Board.text = "You wanted to help your mother get on track on her pure mind, so you thought that a walk through the city would help her ease her mind. You invite her on a walk, as she was a bit embarrassed of having to walk naked in the middle of the streets. You tell her that she has nothing to worry about, as some of the ones that are transformed are in the same situation, as you as you point at a centaur boy that walks normally across the street with his junk barely packed against his body. <i>”I think you’re right,”</i> she says, with a more confident tone on her voice.\n\nAfter that, both of you keep looking at other people that were transformed and they have adapted to the situation. Some of them have special clothings that helped him deal with his situation, others didn’t care at that point but most of them were having a normal life, especially a couple of demonlike persons fucking in a secluded part of the park, something that made your mother blush and push you quicker to move away from their moans. You had a meal together in a restaurant that your mother remembered. You try to show her that the city is the same that she remembers, even though it changed a bit, just like her.\n\nWhen both of you finally got tired, you returned to the castle as your mother takes your hands and looks at you. <i>”Thank you, my child. This trip calmed me a lot from my anxieties. Maybe I look different on the outside, but I’m still Lucina on the inside. Thank you for reminding me that”</i> she says as she hugs you close to her. After a couple of seconds, you can feel her nipples pressing against your body as she quickly retreats from you with her face flustered. <i>”I gotta go, love you!,”</i> she said very fast before retreating to her bedroom. You’ll have to deal with that later.\n";

			}
			break; 
		case 7:
			if (QuestControl.lucinaCorrupt == true) {
				sexConfirmation = 1; 
				panSexConfirmation.sortingOrder = 500;
				panContinue.sortingOrder = -500; 
				Board.text = "This scene has incest and sex with Lucina, do you want to proceed?";
			} else {
				Board.text = "You were training since you’ve heard you father’s destiny in a closer detail. You could say that the conversation made you a bit more paranoid, but you needed the extra training anyway. After a couple more hours of training, you clean yourself up before leaving the training halls. You got a purification elixir ready for your mother, as you hope that you can help her endure the mental strain that thing must cause her. You think that if she has a strong soul, her mind will follow.\n\nWalking to you mother's room, you hear some strange noises from within. Curious about what could make such noises, you take a peek inside her room as the door was a bit open. You find your mother on her bed masturbating, moving her fingers in and out of her rubbery vagina.  Her movements make a \"shquick\" sound as she played with her own blackish lower lips.  From this angle you can also see that the thing that has claimed her skin, has reached deeper into her than you originally thought. You can't help but feel excited by the sight of your mother in this position, as she is still a beautiful woman after all. \n\nYour mother begins to play with her breasts and starts arching her body. You can’t help but keep staring at her as you can hear her moans of pleasure. You can see the latex around her pussy shine brighter with her vaginal juices. You touch the door as you almost fall, yelling a bit for the surprise of almost falling into the floor, but you recover your balance on time.\n\nYou can only hear the voice of your parent coming from inside the door. <i>\""+ GameControl.playerName +", I heard you there. Close the door,”</i> you sigh and close the door behind you, before approaching her slowly. <i>\"Were you spying on me? I’m flattered, but... you are the Leader of the city. I'm completely sure plenty of people would love to have your attention, not from one of an old lady like me.”</i>\n\nYou take a step towards her and tell her that she doesn’t look old at all, that she looks truly beautiful. She blushes and shamefully says, <i>\"I’m sorry if i was too loud with this. I needed to relieve myself, as the lust adds up and if I don't get off. After a while it becomes unbearable”</i>\n\nYou immediately assure your mother you don’t have any problem with her masturbating, as she truly needs it with that creature covering her, and that she shouldn’t be ashamed. <i>\"I guess you're right, we are family and don't need to hide things from each other. And I truly need this, as I can’t find other ways to sate this lust that grows in me. But I didn’t finished, and I feel so hot,\"</i> your mother says before blushing. You tell her that you have something for her, but first you need that she is free of lust, and that perhaps you can help her with that.\n\nShe looks at you for a second, before looking at her side and nodding. <i>“T-That would be nice, my child. I would be very grateful,”</i> she says, as you can see that her nipples are getting harder, probably just by thinking about it. So you carefully lower one of your hands through her rubbery body until you reach her cunt and without further adding, you start fingering her carefully. You can hear her moans of ecstasy returning very fast, as her whole body reacts to your caresses of her sensitive parts.\n\nShe grabs your body as she presses her black rubbery breasts against you, her nipples hard from your fingers inside her. Even her clit was covered by that goo, and when you touch it you can feel it even more sensitive than what you thought, as she moans out loudly every time you play with her button. <i>”Oh, my child,”</i> she says in a lusty tone as you can feel her cunt massaging your fingers. As she lets out a longer moan, you can see how she finally cums hard against your fingers, trying to milk them as if they were a real cock. You can feel her juices flowing out of her twat as she trembles with each wave her orgasm makes her feel, until her body finally rests over your body as she gasps from lust and exhaustion. <i>”...That was amazing. Thank you so much for helping me,”</i> as you can see her motioning to kiss you, probably by reflex. But when she is about to do it, she stops and shakes her head for a second.\n\nYou show her the purification elixir, as you tell her that it will help her to keep her mind fortitude, that you’re sure of it. She takes the small bottle and looks at you. <i>”This thing is expensive! Are you sure that you want to give it to me?,”</i> she looks at you with a surprised face. You nod as you want her to stay like she has been always. She smiles as she drinks the small vial and quickly falls into the bed, completely exhausted. You can feel that she is more pure than before, so you let her rest for the night. After that, you kiss her on her cheek and close the door as you leave.\n";
				QuestControl.lucinaQuest = 6;
				endTurnFun ();
				panContinue.sortingOrder = -500; 
			}
			break; 
		case 8:
			continueControl = 9; 
			if (QuestControl.lucinaCorrupt == true) {
				Board.text = "This time, you find your mother after a while, as one of the servants is leaving the room, completely drenched in fluids that you think are from your mother. You enter the room without knocking and you find your mother panting, but her face is of one of frustration, so you ask her what is going on. <i>“Nothing. It’s just that… the servants are enough. They don’t fill me, as I have to order them what to do. I want something that fills me up on it’s own, something more wild than an order,”</i> she says, as she rubs her pussy a bit, just playing with herself. You tell her that you have the solution to her predicament, so you ask her to follow you.\n\nYou guide her to a secluded place in the poor side of the town, close to a park where you knew that the people already transformed came to sate their urges, despite the condition of the city. So, you guide her and tell her that she can find new people every day in that place. And that there are several secluded places around here, so she’ll find a place to sate herself. She almost drools at the sight of several other creatures populating that zone, some of them carrying dicks as big as a horse and others displaying tits bigger than their own heads. She moves quickly to one of them, as she is talking to him and rubbing her body against his. After a couple of minutes, she takes him from the hand and enter quickly into one hf the alleys that are close to that park.\n\nYou take a small peek, and found out that she is being fucked by that creature, enjoying her holes as she is being held against the wall, her insides being invaded with a huge cock as she moans wildly and loudly, without further worrying about someone finding her. So, you leave the place, satisfied with the results of your plan.\n";

			} else {
				Board.text = "You know that your mother feels bad because she remembers how your father died and feel that he died for nothing. You investigate on the matter and ask her to follow you to the library. On the way, you tell her that you understand that she feels bad and off balance because of that reason. <i>”Oh, don’t worry my child. It’s just that I feel a bit nostalgic, that’s all”</i> she says in a neutral tone of voice. You tell her that you know that this is taxing on her mind and that you want to help her, she’s your family after all.\n\nYou take a book from a special shelf and show it to your mother, explaining to her that she should read the introduction. <i>”Okay, my child. What kind of book is this?”</i> she says, as she reads the introduction. You tell her that it’s a book that talks about your father, and it’s one that you didn’t asked to be written, he did it on himself. You tell her that it’s a popular book and that it has been asked several times to be copied. Your mother covers her black latex mouth as she reads a part of it. <i>”Perhaps the last Lord of the city as a free reign was the last true lord we had in this city. And we won’t allow his memory to fade,”</i> she says, her tears being drunk by the rubber on her face, before looking at you. <i>”Oh my sweet child. This...”</i> she says, before hugging you. You embrace her back as she presses her naked body against yours, as you can feel how her face is searching for yours. As you cross eyes with her, you can feel her mouth entwining with yours in a kiss that is more than familiar. Her tongue search for yours as she helds you in place, before pulling away from you, her face being one of fear.\n\nBefore you can say anything, she covers her mouth. <i>”I’m sorry, I-I...”</i> and after saying that, she turns and leaves the place in a haste, dropping the book at the same time. After that, you’re left alone in the library, as you hold the book that she drop and place it back in the shelf. Oh, dear...";

			}
			break; 
		case 9:
			if (QuestControl.lucinaCorrupt == true) {
				sexConfirmation = 2; 
				panSexConfirmation.sortingOrder = 500;
				panContinue.sortingOrder = -500; 
				Board.text = "This scene has incest and sex with Lucina, do you want to proceed?";
			} else {
				sexConfirmation = 0; 
				panSexConfirmation.sortingOrder = 500;
				panContinue.sortingOrder = -500; 
				Board.text = "This scene has incest and sex with Lucina, do you want to proceed?";
			}
			break; 
		case 10:
			continueControl = 11; 
			if (QuestControl.lucinaCorrupt == true) {
				if (QuestControl.lucinaSlimeQueen == true) {
					Board.text = "You know that your mother is completely corrupt, now the only step left for her to become the lady you’ve been yearning for, is to become the creature that she has been fighting so hard to avoid. After all, the body she has is so exotic and enticing to you, that she should be like that forever, just for your pleasure. She will be the better version that she can be, so you devise a plan to help her to make the final jump.\n\n";
					Board.text += "After a couple of days, you finally thought of something. You know that she is more open sexually with you, even doing lewd things in public, but you can see that she stops the slime creature from time to time, as if the corruption was too much for the slime to bear and It tries to finally overcome her. \n\nYou are enjoying a lustful night with your dear mother, enjoying a good fuck, her breasts pushing against your body as both of you grind against each other. Both of your bodies are covered in your fluids, as your mother is moaning her lungs out from the sensations you are causing to her. After the whole activity finally ends, both of you are panting heavily as your bodies are aching with delight from their respective orgasms. You tell her that the sex was good, but you are sure that it could be better. You can see her looking at you with a puzzled smile. <i>“What are you talking about, my child?,”</i> she says as she lifts her torso from the bed.\n\nYou wave your hands as you tell her that she is quite good, but somehow you tell her that you were expecting a little bit more of her. Maybe it’s because you were expecting something else by seeing her just like that. As you talk, you ran a finger across her rubbery skin. You can see that she looks at her body and then turns her eyes to you. <i>“So, you think that you would like me more, if I were more… “Flexible?,”</i> she says as she weights her breasts a bit. You tell her that it could be a great improvement, you are sure of that. <i>“But, I’ve been fighting it as far as I can remember. That would be, so backwards…”</i> you can see that her tone of voice is full of doubt.\n\nYou explain to her that now she has a new way of seeing things. You tell her that she must feel it too, that her combat against the urges of the slime are useless, that she is slipping offf it’s grasp with each passing day. Perhaps it’s for the best for her to embrace her new race and try to control it from the inside. You stand from the bed as you dress yourself once more, leaving the room as you can see that she is thinking a bit about what you said.";

				} else {
					Board.text = "Your mother has been fighting that creature with her pure will alone, but deep inside you are sure that it’s doomed to fail if she keeps doing it on sheer willpower alone. You know something stronger that can help her to retake control of her body. You know that her corruption and lust can help her overcome that creature until she is no more than a slave to her conscience. And with that, you start thinking on a way to ensure that she is ready to unleash her corruption just like that.\n\n";
					Board.text += "After a couple of days, you can see that she is more open sexually with you, even doing lewd things in public, but you can see that sometimes she looks troubled, as if she is being troubled by that creature in some way.\n\nOne night, you can see that she is returning from one party, as she seems to be a bit drunk. You can see that she is holding her head with both hands, so you ask her if something is wrong. <i>“Oh, this? Is this goddamn creature trying to chew off my conscience. Oh, my head is killing me and I didn’t even drank that much,”</i> she says as she is holding herself from you.\n\nYou tell her that she is still having troubles with that creature, because she is trying to fight it just in the way that she used to do it. You tell her that maybe it’s time to use her new way of viewing her life, to find a solution to that creature’s pesky habits. That she has her strong sense of lust, that her now corrupted state is stronger than any control that she could muster from discipline. <i>“So, you think that maybe this thing can be fought, now that I have more balls? I like the way you think, my child,”</i> she says as she kisses you on your cheek. You tell her that it could be a great improvement, you are sure of that. <i>“Perhaps when I’m more equilibrated… I’m sure to try out this new plan of yours. It will be fun, that’s for sure!”</i> you can see that her tone of voice is faking a relaxed state, you can feel her nerves as her words tremble a bit.\n\nYou help her to return to her bed, as she slowly falls asleep in it, not before trying to entice you to take her, but you let her sleep. She will need it when she wakes up. You wonder how the symbiote changes her hangovers.\n";

				}
			} else {
				if (QuestControl.lucinaSlimeQueen == true) {

					Board.text = "You know that being a slime queen has its benefits, but you worry that she could lose her mind in the transformation. Perhaps what she needs is that her will is strong as ever, perhaps some help on your behalf to help her accept that creature and tame her with her soul. You know that she has the abilities to do it, but you still devise a plan to help her with that without endangering her sanity or personality.\n\n";
					Board.text += "You can see that your mother is thinking in one bench In the park that you showed to her. You approach her as you can see sighing, asking her what’s wrong. <i>”I’m sorry, my child. It’s just that I feel that I haven’t accomplished anything against this creature,”</i> she says as she runs a hand over her latex cover. You pat one of her shoulders carefully, as you know how easy for her is to get aroused with direct contact.\n\nYou tell her that maybe, the reason is because she has been fighting in the wrong way. She looks at you a bit confused, so you elaborate. You tell her that maybe holding off that creature at bay is too tiring for her. Maybe if she stops trying to stop the river and focus on redirecting it, maybe that would be easier for her psyche. She thinks about the metaphor that you just said and looks at the ground. <i>”So, you’re telling me that I should let the creature fulfill its cycle and then I should temper it with my willpower”</i>. You nod and tell her that more or less, that’s your idea. She looks at you and then into the ground. <i>”I dunno if I’ll be able to hold it,”</i> and with that you ran a hand below her back, something that makes her pant just a bit. You tell her that any other person in her condition would have jumped already at you.\n\nYou tell her that if there is someone with that capacity, is her. She looks at you, kissing the corner of your lips before standing up. <i>”Maybe I need to think about it,”</i> she says before standing up from the bench and walking, as you can smell the scent of her arousal. Oh, mother…";

				} else {
					Board.text = "You know that your mother has been fighting against this creature for so long to be here with her children, so you want to help her to finally help her to keep that thing at bay once and for all, to teach it that she is the true owner of her body and to make it learn that it’s its job to comply to her consciousness. She is your mother, and a creature holding for dear life won’t take her away from you, from her people a second time.\n\nAnd with that, you start planning a way to make it a reality.\n\n";
					Board.text += "You know that you must help her to have a resolute mind. You know that she is being constantly besieged by that creature’s mind, trying to take control of your mother’s mind, but you know that her willpower is strong and her soul is pure enough, but you worry that the plan you’ve been crafting for a bit could deplete her completely, leaving her to the symbiote’s control. And for that, you decide to pay her a visit.\n\nYou find her meditating in her room, as the place is completely silent. You approach her, as you can see that she is a bit troubled and ask her what is it. She looks at you with a warm smile and sighs. <i>”I’m sorry, my child. It’s this… thing. It whispers and tries to lure me. Normally it’s okay, but today is… a bit harder than the usual. That’s why I’m meditating,”</i>  as you can see that her body is trembling, probably from lust. You go to her and wait until she says that she is a bit more relaxed, so you can explain to her that you want to actually help her with the symbiote. You tell her that she has been doing a great job, but it’s time that she accepts the help from her family. She takes a good look at you and nods after a bit. <i>”You’re just like your father…”</i>\n\nYou start talking with her about how the creature tries to entice her into submission. You can see that the conversation seems to ease her mind a bit, probably from having someone that is hearing her issues. Sometimes you can see how she fights the lust from the conversations before coughing before she recovers her composure. You tell her that you will help her ease her mind from time to time, just to help her with that. She hugs you from your side. <i>”Thank you for your concern. Sometimes I forgot that I’m not alone in this…”</i> she says, before kissing your forehead before letting you go, as you have some other things to do.";
				}
			}

			break;
		case 11:
			continueControl = 12; 
			if (QuestControl.lucinaCorrupt == true) {
				if (QuestControl.lucinaSlimeQueen == true) {
					Board.text = "You have been spying on your mother from time to time. She thinks that she no one is looking at her, as she is trying to let herself go to the creature that is covering her skin, but you can see that she is still unsure, because when she hears someone getting close, she stops and hides herself. You plan on doing something about that.\n\nSince she has been accepting the slime into her system, her body has been changing slightly but continuously. After one day, you caught with her as she is trying to continue her testing on letting herself go to the creature. You tell her that she looks better than before and ask her if she has done something different. You ran a hand across her ass, causing her to pant slightly. <i>”I’ve done a couple of things, my child. All of them, just for you. Do you like it?”</i> she says, as she presses her breasts between her arms, presenting them to you. You tell her that her body is looking quite nice. You’ve heard that the slimes can alter her body shape, and you tell her that is pretty interesting. You tell her of the whole array of possibilities that you could do with someone with that ability. She looks interested about those things.\n\nYou tell her also that the slimes have more control over the things they cover, and that they can use tentacles if they want. At first she looks puzzled but after you keep telling her about the myriad of things why a slime queen is so interesting, she seems more convinced. After a couple of minutes, she nods. <i>”Thank you, my child. Maybe you don’t know, but you’ve helped me a lot this day,”</i> she says as she gives you a kiss before running away. You smile as you know better than her what are you doing. You leave her to increase her experiments to become a slime queen.";

				} else {
					Board.text = "Since that occasion, you’ve seen your mother gasping and panting from time to time, as you can see that her body is excited without an external origin. You think that she is trying to see what she is capable of doing in that state. You hear from what she has been explaining to you, that sometimes she can feel the creature’s thoughts when she is turned enough, so you think that its time for you to step up the stakes, as you know that she must prove herself stronger to that creature. When you think that she is ready for the next step, you call her into your office, as you know that you have more privacy than your own bedroom due to the servants curiosity.\n\nAs you try to explain her what she must do, she interrupts you. <i>”Don’t worry, my child. I’ve been trying this the whole time. But I think that this will be the first time that I’m going to sink knee deep into it. I know that it can work, but I need a bit more help for that, sweetie. Can you help me with this?”</i> she says as she is placing herself in the floor. You nod at her request for help, so you get ready to help her when she starts to contact the instinct of that symbiote. You explain to her that she must be able to embrace the lust and take control of it, so that the symbiote has nothing to control her. She takes a second to understand the implications but after that, she nods at you. <i>”I’ve been horny this whole time. I can handle it, time to prove my point”</i>\n\nAfter a bit, you can see that she is panting as her body trembles just like before. <i>”Found it… Time to ride the wave”</i> she says with a lecherous smile on her face, as you start talking slowly to her, trying to cheer for her a bit. Her body gets hot as you can see how she starts to get more and more excited, as she fights the impulse of teasing herself. After a couple of minutes, you can see that she starts to relax quickly, as she opens her eyes with a smile on her face. <i>”I knew that it couldn’t handle me!”</i> she says as she almost trips off when she tries to reach for you. <i>”Now it knows that it doesn’t have more control over me. But damn, being hot it's killing me”</i> she says with a surprise on her face as she starts masturbating on her own. You can see that she is too busy trying to relieve herself so you let her be for the moment. Perhaps she must control her urges on her own, and you don’t want to spoil her efforts, so you leave her in your office as you return to your duties.\n";
				}
			} else {
				if (QuestControl.lucinaSlimeQueen == true) {
					Board.text = "This time you try to help her by staying with her during her meditation trainings, but maybe she needs someone who can support her. You are with her during the times that she has to fight the creature’s urges, helping her to relieve herself when she does a good job. After all, she has now that kind of trust with you, so you can help her in that manner. Several times you see that she is at the brink of letting herself go, but she manages to return every time.\n\nOne of that times, you can see that she has you pinned against the ground, her mouth drooling as she has a direct gaze at your crotch. Her own cunt is dripping with juices as she is just about to ravage you. You tell her that she should think what your sister would think if she returns and only finds a monster instead of her mother. That she hasn’t fought for all this time only to fall at the end. You can see how your mother snaps back into her usual self, so you took the chance and turn the tables, inmobilizing her as you wait for her to rest for a bit. She thanks you with a careful kiss, before having a more romantic sex..\n\nIt has been a while, but you think that she is ready to take the next step on controlling that creature.";

				} else {
					Board.text = "This time, you’ve been helping her with the control of her own lust. Sometimes you’ve forced her to hear some erotic readings, training her resistance to the lust, among other things to help her increase her force of will. You hear from what she has been explaining to you, that sometimes she can feel the creature’s thoughts when she is weak enough, so you think that it's time for you to step up the stakes, as you know that she must prove herself stronger to that creature. When you think that she is ready for the next step, you call her into your office, as you know that you have more privacy than your own bedroom due to the servants curiosity.\n\nYou explain her that it's time to not resist but to fight back. The fact that she is only holding the creature at bay is doomed to fail at the end, something that makes your mother a bit sad, but you move a hand, trying to stop her on her tracks. You explain her that she must fight that creature with her mind, so the creature stops trying to take your place. She takes a second to understand the implications but after that, she nods at you. <i>”You’re right. Time to do this, then”</i>\n\nAnd with that, you explain to her that she must find that creature’s instinctive mind and beat it. She sits and starts to meditate as she tries to find that part of the symbiote. After a bit, you can see that she is panting as her body trembles just like before. <i>”Found it… Time to fight back”</i> she says, as you start talking slowly to her, trying to cheer for her a bit. After a couple of minutes, you can see that she starts to relax quickly, as she opens her eyes with a smile on her face. <i>”It works! It truly works!”</i> she says as she almost trips off when she tries to reach for you. <i>”Now it’s silent! I can’t believe it! Oh, my child. I dunno what to say…”</i> she says with a surprise on her face, but you can see that she is slowly drifting into a sleep, probably she is tired now. And with that, you leave her to rest a bit in your office as she has earned it.\n";
				}
			}

			break;
		case 12:
			endTurnFun ();
			panContinue.sortingOrder = -500;
			if (QuestControl.lucinaCorrupt == true) {
				if (QuestControl.lucinaSlimeQueen == true) {
					//NPCCharList.CharFollower [iLucina].charPortrait = 6150;
					Board.text = "You finally know that she advanced significantly and that its time for you to give her the last push. You tell her that you’re planning on visit her into her bedroom, and she arrives rather quickly to the scene. You tell her that you already know what she is trying to do. You can see fear in her eyes, but you raise one of your palms as you tell her that you’re going to help her to achieve her goal. <i>”A-Are you sure, my child? Aren’t you embarrassed of my weakness?”</i> she says, avoiding your gaze. You take her by her chin and make her look at you. You tell her that its not weakness if she is going to become something better for you. You tell her that she must finally take the final step and let herself go.\n\nAnd with that, she nods at you and takes a step back, placing herself in a special place of her bedroom. You can see how the symbiote starts covering her completely, surrounding her in some kind of cocoon. It takes a while, as you’re planning on kick it to see if it increases the process, but when you were planning to do it, you can see it open. It hatches in a small explosion of black goo that stains your clothings a bit but nothing more. From it, your mother emerges as she is covered from head to toe in black latex.  Her hair seems to be between a solid and a liquid form.  Her blue eyes seem to shine with a bright energy.  Her breasts and genitals are no longer encased in latex, now they are made of latex. She also has four appendage coming out of her back that look like tentacles. Completing the picture are the heels seemingly coming out of your mothers foot. Despite the transformation, she look as gorgeous as ever, perhaps even more now.\n\nAfter that, you can see that despite you told her, it seems that her slime queen instinctive mind took over her rather quickly. She doesn’t say a word as she looks around. Her posture changes a bit as you can see that she seems to be hunting something. After a bit, you tell her that if she is horny, then she can search for someone to sate her urges, then she can comeback for more. After that, you can see her liquefying, her body making herself a mass of oozing rubber as she darts out of the bedroom, probably hunting for some unaware soul. Perhaps you’ll visit her later to have some fun with her.";


				} else {
					sexConfirmation = 3; 
					panSexConfirmation.sortingOrder = 500;
					panContinue.sortingOrder = -500; 
					Board.text = "This scene has incest and sex with Lucina, do you want to proceed?";
				}
			} else {
				if (QuestControl.lucinaSlimeQueen == true) {
					//NPCCharList.CharFollower [iLucina].charPortrait = 6150;
					Board.text = "You found that the purification elixir has been helping her to take control of the creature, perhaps it will help her one last time. And with that, you go to her bedroom and explain the situation to her. She is a bit hesitant at first, but you know that she has been thinking on doing it on her own. <i>”I don’t want to lose you a second time,”</i> she says, definitely worried about the outcome. And you know that hesitation is what its keeping her from trying. You grab her hands and tell her that you have a purification elixir, something that will help her to overcome that fear. You take out the pristine bottle and place it on her hands.\n\nShe looks at it, then at you and nods. <i>”You’re right, my child, I have to do this. You’re as brave as your father,”</i> she says as she runs a hand through your cheek, just before drinking the elixir. After that, she closes her eyes and lets the symbiote take her slowly. You can see how the creature starts covering her head, as she walks back into one corner of the bedroom as her whole body starts being encircled by some kind of latex cocoon. After that, you cannot do other thing than wait, and you have to do it for a couple of hours. You are starting to get worried, but your faith in her didn’t falter. Finally, she erupted from the cocoon in an explosion of black goo. Her hair seems to be between a solid and a liquid form.  Her blue eyes seem to shine with a bright energy.  Her breasts and genitals are no longer encased in latex, now they are made of latex. She also has four appendage coming out of her back that look like tentacles. Completing the picture are the heels seemingly coming out of your mothers foot. Despite the transformation, she look as gorgeous as ever, perhaps even more now.\n\nYou can see how she opens her eyes, the spark of intelligence still in them. It seems that she emerged triumphant from the battle with that creature. You call for her, as she notices you and walks slowly in your direction and hugs you delicately. <i>”I DID IT, MY CHILD! You had faith in me all this time! Thank you!”</i> she says just before kissing you passionately, as you can feel that her body reacts to your touch, but she isn’t being tortured by the desire of that creature. She seems to be finally free from its mind, her body now more akin to that creatures. <i>”I need… some water. Come and visit me another time, perhaps we can put this new body to good use. I would love to test it with my lover…”</i> she gives you a wink before liquefying and leaving the room. Oh, Lucina, it’s good to see that she is finally free to do what she wants.";



				} else {
					sexConfirmation = 3; 
					panSexConfirmation.sortingOrder = 500;
					panContinue.sortingOrder = -500; 
					Board.text = "This scene has incest and sex with Lucina, do you want to proceed?";
				}
			}

			break;


		}


	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


	public void lucinaCorruptChoice(int selector){
		if (selector == 0) {
			QuestControl.lucinaCorrupt = true; 
			QuestControl.lucinaQuest = 5; 

			endTurnFun ();
			panCorruptChoice.sortingOrder = -500; 
			Board.text = "After some thought, you decide that freeing her from her old self and finishing what the monster started is the best thing for both of you. ";
			NPCCharList.CharFollower [iLucina].corruptionStage = 4; 
		} else {
			NPCCharList.CharFollower [iLucina].corruptionStage = 0; 
			Board.text = "After some thought, you decide that you need to free her from the influence of the beast, returning her into her old self. ";
			QuestControl.lucinaCorrupt = false; 
			QuestControl.lucinaQuest = 5; 
			endTurnFun ();
			panCorruptChoice.sortingOrder = -500; 


		}

	}


	public void lucinaSlimeQueenChoice(int selector){
		if (selector == 0) {
			QuestControl.lucinaSlimeQueen = true;
			continueControl = 10;
			panContinue.sortingOrder = 500;
			panSlimeQueen.sortingOrder = -500; 
			QuestControl.lucinaQuest = 8;

		}

		if (selector == 1) {
			QuestControl.lucinaSlimeQueen = false;
			continueControl = 10;
			panContinue.sortingOrder = 500;
			panSlimeQueen.sortingOrder = -500; 
			QuestControl.lucinaQuest = 8;
		}


	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////

	public void confirmSex(int selector){
		//0 yes, 1 no

		if (selector == 0 && sexConfirmation == 0) { // pure sex scene at purification scene 4
			sexPurification0Scene4();
			panSexConfirmation.sortingOrder = -500;
			QuestControl.lucinaQuest = 7;
			return;
		}

		if (selector == 1 && sexConfirmation == 0) {
			Board.text = "Sorry, no scene yet, this is a placeholder. ";
			endTurnFun ();
			QuestControl.lucinaQuest = 7;
			panSexConfirmation.sortingOrder = -500;
			return;
		}

		if (selector == 0 && sexConfirmation == 1) { //  sex scene at corruption scene 4
			QuestControl.lucinaQuest = 6;
			Board.text = "You got a corruption elixir ready for your mother, as you think that if she embraces her urges rather than fight them, she will become something more akin to her true self, more than someone fighting her needs. But you need a last proof that she is ready to take her lust a little bit more seriously.\n\nYou walk to you mother's room, you can’t find her in there. After a bit of searching around, you hear some strange sound from somewhere up close. Curious about what could make such noises, you follow the moanings all the way to the garden. Among the trees you find your mother masturbating, moving her fingers in and out of her rubbery vagina.  Her movements make a \"shquick\" sound as she played with her own blackish lower lips. As she plays with herself, you can see that she is holding a part of your underwear close to her, as she is mumbling your name between moans. You smile at the sight of your mother giving herself freely to her desires.\n\nYou walk slowly in her direction, not even trying to conceal your presence to her, as she looks at you and stops masturbating as she looks at you arriving at the spot. <i>”"+ GameControl.playerName +", what are you doing here?”</i>, she says as her voice is still containing a tone of pleasure. You tell her that it was hard not to hear her moanings as you know her so well. She blushes as she places both hands alongside your clothing over her pussy, leaving her breasts bare, her nipples still pointing at you.\n\n<i>”I’m so sorry, my child! But these last few days I’ve been so horny, so lustful. I can feel my mind fortitude slowly fading. I need some release from this aching lust that I can’t sate with anything that,”</i> she stops talking, her black-rubber face is mixing with red. <i>”That isn’t me, right?,”</i> you tell her as if it's something normal. She looks at you surprised but she doesn’t say no to you. You tell her that you have something for her that will help her to stop feeling so bad, and that will help her with her predicament. You tell her as you show her the corruption elixir. She doesn’t know why, but she drools a bit by looking at the elixir. <i>”How?,”</i> she asks, but you interrupt her and tell that she first must show her that she is willing to do what her instincts tell her to do. That she must tell you what she wants right now. <i>”But I can’t, because you’re… And I am...”</i>\n\nShe looks at you, her body trembling probably from the lust that is building inside her. She grabs one of her breasts as she plays with one of her nipples. <i>”I need you to help me cum. I’ve wanted you to help me since I saw you at the baths. I want to feel your tongue inside me,”</i> she says between moans as she spread her legs once more, exposing her black rubber pussy to you, dripping with her juices. You smile as she begs for her own blood to help her with her release. And with that, you kneel in front of her as the scent of her arousal fill your nose.\n\nYou start teasing her pussy with your tongue, the taste of her is different just as you expected. But when you thought that it would be strange, is totally the opposite. It’s softer than you thought at first and you can even feel it pressing against your tongue as you lick her inner lips. You can feel your mother’s hands running through your hair, as you play with her clit, now a black button that sends her shivering in delight every time you run your wet tongue over it.\n\n<i>”Don’t stop, my child!,”</i> she says, as you can feel how her cunt welcomes your caressings with her juices flowing all over your mouth and tongue. The scent of her sex is intoxicating as you enjoy hearing her moans of delight of being licked by her own offspring. She pinches her nipples, as she tries to push her own snatch more and more against you until you finally feel her own orgasm hitting her like a thunder, her whole body arching as she keeps you in place with her hands, forcing you to be soaked with her vaginal fluids as she moans and thrashes like a bitch in heat. <i>”This is better than using clothing,”</i> she says, as she let go the grip over your head, panting heavily.";
			if (GameControl.dick1Size > 0) {
				Board.text += "After that, you stand and take out your corruption elixir, undressing your lower half and pouring it over your dick. You can see its defiling powers getting you hard in no time. <i>”It’s time for your dose, mother,”</i> you say with a smile of satisfaction in your face, as she looks at it with a renewed sense of lust as she moves almost like truly a goo girl and wraps your cock with her mouth, sucking all the corruption elixir with needy desire. She sucks you with a lot of force until you can’t hold out your orgasm, filling her mouth with a mix of the corruption elixir and your own spunk, as she gulps more and more of your cum, until she can’t suck anymore of it, releasing your dick and falling into her back, her face of lust as her body almost becomes a puddle in the floor. You know that she is now prone to sate her urges at the spot, as you can feel how she is more tainted than before. And with that, you leave her on her own lusty thoughts. ";

			} else if (GameControl.hasVagina == true) {
				Board.text += "After that, you stand and take out your corruption elixir, undressing your lower half and pouring it over your pussy. You can see its defiling powers getting you wet in no time. <i>”It’s time for your dose, mother,”</i> you say with a smile of satisfaction in your face, as she looks at it with a renewed sense of lust as she moves almost like truly a goo girl and licks your cunt with her flexible tongue, licking all the corruption elixir with needy desire. She licks you with a lot of force until you can’t hold out your orgasm, filling her mouth with a mix of the corruption elixir and your own vaginal fluids, as she gulps more and more of your femspunk, until she can’t lick anymore of it, releasing your snatch and falling into her back, her face of lust as her body almost becomes a puddle in the floor. You know that she is now prone to sate her urges at the spot, as you can feel how she is more tainted than before. And with that, you leave her on her own lusty thoughts. \n";

			} else {
				Board.text += "After that, you stand and take out your corruption elixir, undressing your lower half and pouring it over your body. You can see its defiling powers getting you aroused in no time. <i>”It’s time for your dose, mother,”</i> you say with a smile of satisfaction in your face, as she looks at it with a renewed sense of lust as she moves almost like truly a goo girl and licks your body and ass with her flexible tongue, licking all the corruption elixir with needy desire. She licks you with a lot of force until you can’t hold out your orgasm, filling her mouth with a mix of the corruption elixir and your own vaginal fluids, as she gulps more and more of your femspunk, until she can’t lick anymore of it, releasing your snatch and falling into her back, her face of lust as her body almost becomes a puddle in the floor. You know that she is now prone to sate her urges at the spot, as you can feel how she is more tainted than before. And with that, you leave her on her own lusty thoughts. \n";
			}
			endTurnFun (); 
			panSexConfirmation.sortingOrder = -500;
			return;
	

		}

		if (selector == 1 && sexConfirmation == 1) { // sex scene at corruption scene 4
			QuestControl.lucinaQuest = 6;
			Board.text = "Sorry, no scene yet, this is a placeholder. ";
			endTurnFun ();
			panSexConfirmation.sortingOrder = -500;
			return;

		}

		if (selector == 0 && sexConfirmation == 2) { 
			sexCorruption3Scene4 ();
			panSexConfirmation.sortingOrder = -500;
			panContinue.sortingOrder = -500;
			endTurnFun ();
			QuestControl.lucinaQuest = 7; 
			return;
		}

		if (selector == 1 && sexConfirmation == 2) { 
			QuestControl.lucinaQuest = 7;
			panSexConfirmation.sortingOrder = -500;
			Board.text = "Sorry, no scene yet, this is a placeholder. ";
			endTurnFun ();
			panSexConfirmation.sortingOrder = -500;
			return;

		}

		if (selector == 0 && sexConfirmation == 3) {
			QuestControl.lucinaQuest = 8;
			endTurnFun ();
			panSexConfirmation.sortingOrder = -500;
			if (QuestControl.lucinaCorrupt == true) {
				Board.text = "After you ask her to come in the same spot as before, you tell your mother that it’s time to take the final step into her true freedom from that thing. You tell her that you’ve been thinking about her big steps she has been taking since the creature realized that it’s useless to tease you and excite you to try and take control of her. You think that maybe she can take complete control over that puny creature and expulse it from her body. After all, it knows that you’re not a woman that it can stomp into oblivion You tell her that perhaps she won’t be complete human, but you try to reassure her by telling her that she looks gorgeous just the way she looks.\n\nShe tells you that she wants you to see her, because she wants you to be near when she is finally free from that little parasite. After that, you can see that she sits on your desk and starts trying to lure that creature out of her mind, or at least that’s what you think she must be doing, just like the last time But in this occasion is a bit different, as you can see that your mother is even enjoying the ride, as you can see that her nipples are showing and her own cunt is dripping just a bit. After a couple of minutes, you can see how from her slimy and jet black body, a trail of black smoke starts appearing as she starts to moan and pant from delight, as it seems that the conscience of that creature finally dissolves into thin air. After that, you can see that your mother stands up slowly and takes a good look at you, as she places a hand over her waist, giving you a good show of her excited body. <i>”I got rid of that thing. Good graces. If it wasn’t for you, probably that thing would be still tormenting me, my child”</i> she says with a bit submissive look on her face. You go and hug her from happiness, as she is still digesting the thing that just happened. <i>”Is finally over. I don’t care if this slime is still over me. As long as I’m able to serve you well, I don’t need anything else.”</i> she says, before hugging you as she presses her big breasts against your chest, turning you on rather quickly.\n\nShe notices your excitement and giggles, as you tell her that you can’t help it as she looks quite sexy. She blushes but she smiles. <i>”I can help you with that, if you don’t mind…”</i> she says in a teasing tone, as you can’t help but nod at her remark.\n\n";
				if (GameControl.dick1Size > 0) {
					Board.text += "She pulls off the lower part of your clothes as she grabs your "+  GameControl.mcDick1Name.toDescription() +  "  "+ GameControl.mcDickType.toDescription()  + " cock and starts stroking it, as she gives you a lewd look while she is giving you a handjob until she feels that you’re as hard as you can. After that, she slides into her knees and starts sucking your dick with expertise. You know that this time, the symbiote isn’t doing anything to push her, you know that this is truly your mother giving you a blowjob on her own free will. You can see how she fixes her eyes over yours, her wet mouth and tongue wrapping around your dick, giving you a lot of pleasure. She is enjoying a lot your face of delight, and you can see a hint of fear from doing it wrong, but its quickly pushed away from your face of excitement.\n\nWhen you feel that you’re about to cum, you cock starts throbbing and that is the signal for your mother to engulf as much of your cock as she can, until you start spurting your whole load of cum into her throat, as you can see how she gulps it to the last drop, her lips sealing shut around your sensitive shaft, trying her best not to spill a drop from it. When she finally see that you’re completely dry from your seed, she stands up as she slurps the last drops of semen from her mouth. <i>”I will serve you from now on, my child. Just say the word and I will do it, I just want to make you happy!”</i> she says, as she walks around you seductively before leaving the place to rest. This is surely that start of something quite interesting for you.";
				} else {
					Board.text += "She pulls off the lower part of your clothes as she gets a hold of your pussy and starts rubbing it, as she gives you a lewd look while she is giving you a fingerjob until she feels that you’re as wet as you can. After that, she slides into her knees and starts licking your cunt with expertise. You know that this time, the symbiote isn’t doing anything to push her, you know that this is truly your mother giving you a good licking on her own free will. You can see how she fixes her eyes over yours, her wet mouth and tongue wrapping around your clit and enjoying your fluids, giving you a lot of pleasure. She is enjoying a lot your face of delight, and you can see a hint of fear from doing it wrong, but it's quickly pushed away from your face of excitement.\n\nWhen you feel that you’re about to cum, you start to tremble and moan loudly, and that is the signal for your mother to lick faster and tease you harder, until you start spurting your whole load of vaginal juices into her mouth and tongue, as you can see how she gulps it to the last drop, as she is using one of her fingers to tease your insides, as your inner thighs try to milk her finger as if it were a true cock. When she finally see that you’re completely spent, she stands up as she slurps the last drops femspunk from her mouth. <i>”I will serve you from now on, my child. Just say the word and I will do it, I just want to make you happy!…”</i> she says, as she walks around you seductively before leaving the place to rest. This is surely that start of something quite interesting for you.\n";
				}

			} else {
				Board.text = "You tell your mother that it’s time to take the final step into her freedom from that thing. You tell her that you’ve been thinking about her big steps she has been taking since the creature stopped harassing her constantly. You think that maybe she can take complete control over that instinct and release it, leaving the slime body over her but at least free from the mind control of the creature. You tell her that perhaps she won’t be complete human, but you try to reassure her by telling her that she looks gorgeous just the way she looks.\n\nShe tells you that she will try it with you watching over her. And with that, you do the same as before: Both of you in your office as she meditates to take control of that creature. But this time is a bit different, as you can see that your mother is quite relaxed. After a couple of minutes, you can see a part of her slime symbiote flowing off her and pooling into the ground, and after a couple of seconds you can see how it disappears in a small cloud of black smoke. After that, you can see that your mother stands up slowly and takes a good look at you, as if waiting for something. <i>”I think that it’s finally gone…”</i> she says with a dumbfounded look on her face. You go and hug her from happiness, as she is still digesting the thing that just happened. <i>”Is it finally over? Well, I still have the slime, but I think that I can live with that… as long as I have you, my child”</i> she says, before hugging you as she presses her big breasts against your chest, turning you on rather quickly.\n\nShe notices your excitement and giggles, as you tell her that you can’t help it as she looks quite sexy. She blushes but she smiles. <i>”Maybe it’s time for a small celebration, don’t you think?”</i> she says in a teasing tone, as you can’t help but nod at her remark.\n\n";
				if (GameControl.dick1Size > 0) {
					Board.text += "She pulls off the lower part of your clothes as she grabs your "+  GameControl.mcDick1Name.toDescription() +  "  "+ GameControl.mcDickType.toDescription()  + " cock and starts stroking it, as she gives you a lewd look while she is giving you a handjob until she feels that you’re as hard as you can. After that, she slides into her knees and starts sucking your dick with expertise. You know that this time, the symbiote isn’t doing anything to push her, you know that this is truly your mother giving you a blowjob on her own free will. You can see how she fixes her eyes over yours, her wet mouth and tongue wrapping around your dick, giving you a lot of pleasure. She is enjoying a lot your face of delight.\n\nWhen you feel that you’re about to cum, your cock starts throbbing and that is the signal for your mother to engulf as much of your cock as she can, until you start spurting your whole load of cum into her throat, as you can see how she gulps it to the last drop, her lips sealing shut around your sensitive shaft, trying her best not to spill a drop from it. When she finally see that you’re completely dry from your seed, she stands up as she slurps the last drops of semen from her mouth. <i>”And this is only the beginning, my lovely child… No one knows you like your mother does…”</i> she says, as she walks around you seductively before leaving the place to rest. This is surely that start of something quite interesting for you.\n";
				} else {
					Board.text += "She pulls off the lower part of your clothes as she gets a hold of your pussy and starts rubbing it, as she gives you a lewd look while she is giving you a fingerjob until she feels that you’re as wet as you can. After that, she slides into her knees and starts licking your cunt with expertise. You know that this time, the symbiote isn’t doing anything to push her, you know that this is truly your mother giving you a good licking on her own free will. You can see how she fixes her eyes over yours, her wet mouth and tongue wrapping around your clit and enjoying your fluids, giving you a lot of pleasure. She is enjoying a lot your face of delight.\n\nWhen you feel that you’re about to cum, you start to tremble and moan loudly, and that is the signal for your mother to lick faster and tease you harder, until you start spurting your whole load of vaginal juices into her mouth and tongue, as you can see how she gulps it to the last drop, as she is using one of her fingers to tease your insides, as your inner thighs try to milk her finger as if it were a true cock. When she finally see that you’re completely spent, she stands up as she slurps the last drops femspunk from her mouth. <i>”And this is only the beginning, my lovely child… No one knows you like your mother does…”</i> she says, as she walks around you seductively before leaving the place to rest. This is surely that start of something quite interesting for you.\n\n";
				}
			}
			return;
		}

		if (selector == 1 && sexConfirmation == 3) {
			QuestControl.lucinaQuest = 8;
			Board.text = "Sorry, no scene yet, this is a placeholder. ";
			endTurnFun ();
			panSexConfirmation.sortingOrder = -500;
			return;
		}

	}



	////////////////////////////////////////////////////////////////////////////////////////////////////////
	void lucinaWelcome()
	{

		if (GameControl.charArmorTags [1] == true && GameControl.charArmorTags [2] == true) {
				if (NPCCharList.CharFollower [iLucina].corruptionStage < 2) {
					Board.text = "As you look for your mother in her chamber you can see that she isn’t there right now. Your servants points you at the library. You find your mother sitting at a table, as she has a lot of books in front of her. She seems to be looking for something specific among them, but you can't point what is it. As you ask her what she is doing, she just smiles and turns to see you. \n\nWhen she lands her eyes on you, her rubbery face fills with surprise as she barely places the book on the table without dropping it, as she doesn't take her eyes off your exposed body. <i>\"My child, your clothes…\"</i> she says with a bit of interest. <i>“It looks… definitely different. Not bad, don’t get me wrong, on the contrary…”</i> she says, as she gulps a second as she takes the book again and tries to focus on it, trying to cover her blush that is barely visible over her latex cheeks. <i>\"W-What can I do for you, my gorgeous child?\"</i>";
				} else {
					Board.text = "As you look for your mother in her chamber you can see that she isn’t there right now. Your servants points you at the library. You find your mother sitting at a table, as she has a lot of books in front of her. She seems to be looking for something specific among them, but you can't point what is it. As you ask her what she is doing, she just smiles and turns to see you. \n\nWhen she lands her eyes on you, her rubbery face fills with lust as she throws the book into a pile of discarded books that is close to her place, without taking her eyes all over your exposed body as she stands and gets closer to you. <i>\"It seems that you want to follow your mother’s trend on clothing. I love it, yet you somehow look… even more enticing than before\"</i> she says as she is almost eating you entirely with only her eyes. <i>“I can recognize this body anywhere, I’ve dreamed of it a lot”</i> she says, as she takes you from your shoulders, pressing her body against yours on purpose as she guides you to a chair next to the place where she was at the first place. <i>\"Came here for some mommy’s love, or maybe for something else?\"</i>";
				}

		} else {
				Board.text = "As you look for your mother in her chamber you can see that she isn’t there right now. Your servants point you at the library. You find your mother sitting at a table, as she has a lot of books in front of her, as she seems to be looking for something specific among them. As you ask her what she is doing, she just smiles. <i>\"I’m doing some investigation,\"</i> she says with a tad of exhaustion. <i>“I haven’t found much information about how to deal with this thing. I’ve been trying everything, but it seems impervious to everything”</i> she says, before leaving the book she’s reading into the table and turns to see you, giving you all her attention. <i>\"Did you need something, my child?\"</i>\n";
		}
		


	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	//// PURIFY

	void sexCorruption3Scene4(){
		string PAR0 = "You finally got the corruption elixir but you wanted to make sure that doesn’t go to waste on your mother, Lucina. So you go with her to make sure that she is a slave to her own lust and urges, finding her in your room, as if she would be waiting for you to arrive.\n\nYou ask her if she has been having fun since the last time you saw her, something that makes her cross her legs. <i>”Well, yes. But I’ve been wanting to try something new, something kinky. But I think that the other person wouldn’t want to try it with me,”</i> she says with a tone of shame on her voice. You tell her that she should try it. That the world is for hers to take, and that there isn’t something that she couldn’t get, if she push herself over it. Maybe you have the solution with you, as you show her the corruption elixir that you brought for her. But if she truly wants it, perhaps she should try that thing with that person, if she truly wants it.\n\nYour mother stands from her place and walks over to you. <i>”I think you’re right, my child,”</i> she says, before pressing her delightful and soft feminine body against yours as she pushes you against her bed. <i>”And I know who I want to be my first prey,”</i> as she slowly removes your clothes, until you are completely naked.";
		string PAR1 = "";
		string PAR2 = "";
		string PAR3 = "";
		string PAR4 = "";

		string PAR2L1 = "";
		string PAR2L2 = "";
		if (GameControl.dick1Size > 0) {

			if (GameControl.testiclesSize > 0) {
				PAR2L1 = " and "+ ballsSize +" testicles";
			}
			if (GameControl.hasVagina == true) {
				PAR2L2 = " as your own pussy is soaking wet and dripping your strong-scented juices";
			}

			PAR1 = "\n\nShe exposes your cock, which is already hard from the whole teasing of her body over yours, her soft breasts pressing against your torso as she rubs her already wet pussy against your "+ dickRace +" "+ dickSize +" cock. <i>”Oh, my child. I’ve been waiting a long time for doing this. I’ve been having wet dreams with this moment,”</i> she says, her voice filling itself with desire every time she rubs her rubbery cunt at your hard prick. She is holding your arms but without pressing them, only barely holding them as she teases her entrance with your "+ dickSize +" hard rod.";
			PAR2 = "\n\n<i>”I want you to fuck me like a man, I want to love you not just like family but also as a woman,”</i> and after saying that, she impales herself over your shaft, as you can feel her insides welcoming you with her wet and flexible insides. You can feel her gooey skin spreading around your own as she grinds herself all over your dick. You can feel her nipples hard as stones, rubbing against your torso, her the moans of your mother filling the room. <i>”Push it in, my child! Let momma take care of your cock!,”</i> she says between moans, as her bountiful ass jiggles and smacks itself against your thighs"+ PAR2L1 +""+ PAR2L2 +", every time she thrusts your cock inside her nether walls.";
			PAR3 = "\n\nYou can’t help but let yourself go with the pleasure, thrusting your hips against your own mother’s cunt, feeling the warmness of her insides too delightful. She leans to press one of her breasts into your face, forcing you to suck one of her nipples. <i>”Don’t stop!,”</i> she pleads as you keep sucking and fucking her, until you can feel that you’re at your limit, so you began cumming into your relative’s hungry snatch. She moans in delight as you fill her insides with your hot thick cum, the gooey thing in her skin trembling alongside her as she reach her orgasm on her own, its cunt milking your dick as the black thing wrapping around it like a second tongue, lapping it as it tries to force all your cum out of your cock as your mother grabs one of her breasts as she keeps cumming. <i>”So sensitive!,”</i> she yells as she arches her back, as her creature feeds on the cum that is trying to drip from her quenched twat until there is nothing left.";
			PAR4 = "\n\nYour relative falls over you for a second, both of you spent from the lovemaking. After a couple of minutes, your mother stands up, pulling out your cock from her pussy, as she starts walking towards your clothing and grabs the corruption elixir. <i>”Momma’s gonna take her prize,”</i> she says as she gulps it, her body trembling as she corruption finally takes complete control of her, her smile becoming more seductive as she looks at you. <i>”Perhaps next time we can talk of more interesting things, my sexy "+ GameControl.playerName +"”</i> she gives you a wink as she walks slowly outside the room with a more confident step, leaving you to rest.";
		} else if (GameControl.hasVagina) {
			PAR1 = "\n\nShe takes out a double dildo from one of her drawers as she exposes your pussy, which is already wet from the whole teasing of her body over yours, her soft breasts pressing against your torso as she rubs her already wet pussy against your own cunt, while soaking the dildo with both of your juices. <i>”Oh, my child. I’ve been waiting a long time for doing this. I’ve been having wet dreams with this moment,”</i> she says, her voice filling itself with desire every time she rubs her rubbery cunt and your sensitive womanhood over the fake cock. She is holding one of your arms but without pressing it, only barely holding it as she teases your entrance and hers with the fluid-soaked sex toy.";
			PAR2 = "\n\n<i>”I want you to fuck me like a man, I want to love you not just like family but also as a woman,”</i> and after saying that, she thrusts her sex toy inside you and her, as you can feel your insides being invaded with that fake dick drenching in your mother’s vaginal juices. You can feel her gooey skin spreading around your own as she grinds herself all over your dick. You can feel her nipples hard as stones, rubbing against your chest, her the moans of your mother filling the room. <i>”Push it in just like me, my child! Let momma take good care of your pussy!,”</i> she says between moans, as her bountiful ass jiggles and smacks itself against your thighs, every time she thrusts that dildo inside your nether walls.";
			PAR3 = "\n\nYou can’t help but let yourself go with the pleasure, thrusting your hips against your own mother’s cunt, feeling her wetness over your own thighs delightful. She leans to press one of her breasts into your face, forcing you to suck one of her nipples. <i>”Don’t stop!,”</i> she pleads as you keep sucking and fucking her, until you can feel that you’re at your limit, so you began cumming over the sex toy that is fucking your relative’s snatch too. She moans in delight as the gooey thing in her skin trembling alongside her as she reach her orgasm on her own, its cunt massaging the sex toy as your mother grabs one of her breasts as she keeps cumming. <i>”So sensitive!,”</i> she yells as she arches her back, as her creature feeds on the femspunk that is trying to drip from your quenched twats until there is nothing left.";
			PAR4 = "\n\nYour relative falls over you for a second, both of you spent from the lovemaking. After a couple of minutes, your mother stands up, pulling out the sex toy from her pussy, as she starts walking towards your clothing and grabs the corruption elixir. <i>”Momma’s gonna take her prize,”</i> she says as she gulps it, her body trembling as she corruption finally takes complete control of her, her smile becoming more seductive as she looks at you. <i>”Perhaps next time we can talk of more interesting things, my sexy "+  GameControl.playerName +"”</i> she gives you a wink as she walks slowly outside the room with a more confident step, leaving you to rest.";
		} else {
			PAR1 = "No scene for asexuals yet, sorry.";
			PAR2 = "";
			PAR3 = "";
			PAR4 = "";
		}

		Board.text = PAR0 + PAR1 + PAR2 + PAR3+ PAR4;


	}

	void sexPurification0Scene4(){

			string PAR0 = "On this time, your mother calls for you as you know the reason, especially of how your last time together ended. She said that she didn’t wanted to act like nothing happened and wanted to talk seriously with you. So, you went to her bedroom, where she is waiting already for you, dying of nerves. When you arrive, she smiles at you with that maternal look that makes you feel like everything is going to be okay, as she points to the side of her for you to sit, so you comply.\n\n<i>”Look my dear, I know I’ve done something wrong in the last time,”</i> she rubs her wrists as she continues. <i>”I want you to know that it was more of the heat of the moment.”</i> You stop her with you hand and tell her that you want to know the truth, that it’s time for her to be completely honest. She looks at you in the eye and then sighs. <i>”I’ve tried to control it, but I just can’t, my child. I-I’ve fallen in love with you, I thought that it wasn’t possible, but I do.”</i> she looks away from you, waiting for you to scorn her. You take her chin and make her look at you as you kiss her passionately, her tongue answering with desire to you caressings. Her face blushes at your kiss as she is shocked by your move. You tell her that nobody has to know that you’re lovers, until the time is right. That you want to know her more, not like a mother but like a woman, that you want to give her a chance. So you kiss her once more, and she melts between your arms as she kisses you back with unbridled passion, both of you undressing each other until you’re both naked in her bed. <i>”Please, my child. Grant me my wish, even if only this night. Take me...”</i> ";
			string PAR1 = "";
			string PAR2 = "";
			string PAR3 = "";
			string PAR4 = "";
			string PAR5 = "";
			string PAR6 = "";
			if (GameControl.dick1Size > 0) {
				string P1L1 = "";
				if (GameControl.hasVagina == true) {
					P1L1 = " before she runs down her hand to your slippery snatch, getting wetter by the minute";
				}
				PAR1 = "You remove slowly your clothes as you touch your mother’s body. You can feel that her skin is so sensitive with that creature covering her whole body. She is already panting, her face blushing brightly. You ran your hands over her soft, elastic breasts as you can feel that her nipples press against your hands, as her hand rubs your " + GameControl.mcDickType.toDescription () + " " + GameControl.mcDick1Name.toDescription () + " cock " + P1L1 + ".\n\n";
				PAR2 = "You kiss her with passion, your tongues entangling with each other as you can feel her desire as she embraces you with her pliable and warm arms, the feeling of her rubbery skin against your back as she holds you against her, enjoying your mouth as her groin rubs against your dick. <i>”I love how you feel against my skin,”</i> she says, as she breaks the kiss for one second. You can feel her soaked pussy trying to tease your shaft. It’s so exciting to know that you’re just about to fuck someone you’ve been desiring for a while, and knowing that she desires you in the same way fills you with lust.\n\n";
				PAR3 = "So you push your dick inside her wanting twat, her latex insides welcoming you with excitement, as you can feel them pressing against it, massaging it with its warm and wetness. She circles your waist with her broad hips, not wanting to let you go as you ram your " + GameControl.mcDick1Name.toDescription () + " prick inside her consecutively. Your hands run through her skin, as you can see that even the slightest touch of your fingers sends her into a frenzy, her moans filling the entire room as she mixes them with your name, as it seems that it’s driving her crazy.\n\n";
				PAR4 = "<i>”Give it to me, my dear " + GameControl.playerName + ",”</i> she coos in a low tone next to your ear. <i>”Touch me, fill me...”</i> she says, before her sensual voice sends you into a lust rage, pounding her pussy with force as you continue enjoying her whole body. You can hear how the bed croaks with the force of your hips as you ram her wildly.\n\n";
				PAR5 = "You can feel how your own orgasm gets closer, so you push it as deep as you can and kiss her one last time, just in time for you to start cumming uncontrollably into your own mother’s cunt, filling her with your virile seed. You can feel how one strong moan is muffled by your kiss, as her own snatch starts convulsing around your cock as she gets to cum on her own. You can feel your dick pouring its contents at the same time that she tries to milk you with her insides, her inner walls massaging your cock with a silken rubbing, until your bodies are finally spent.\n\n";
				PAR6 = "As the lust haze finally disappears, you can see that she holds you in her arms. <i>”Oh dear, I would love to improve our relationship to something more… If you’re willing, of course”</i> she says, still blushing a bit even though you just had sex. So you ran a hand through her cheek and tell her that you would be interested in that. She smiles and kiss you one last time, before both of you enjoy each other’s company before falling asleep.";

			} else {
				PAR1 = "You remove slowly your clothes, and take out a double dildo as you touch your mother’s body. You can feel that her skin is so sensitive with that creature covering her whole body. She is already panting, her face blushing brightly. You ran your hands over her soft, elastic breasts as you can feel that her nipples press against your hands, as her hand rubs your slippery snatch, getting wetter by the minute. You place the sex toy between each other’s cunts, dripping them with both of your fluids.\n\n";
				PAR2 = "You kiss her with passion, your tongues entangling with each other as you can feel her desire as she embraces you with her pliable and warm arms, the feeling of her rubbery skin against your back as she holds you against her, enjoying your mouth as her groin rubs against your own snatch. <i>”I love how you feel against my skin,”</i> she says, as she breaks the kiss for one second. You can feel her soaked pussy trying to push the fake cock inside her. It’s so exciting to know that you’re just about to fuck someone you’ve been desiring for a while, and knowing that she desires you in the same way fills you with lust.\n\n\n";
				PAR3 = "So you push the dildo inside her wanting twat at the same time that you impale yourself into the other side of it, the firm texture of the dildo filling your insides, as you can feel how she presses against it, thrusting it inside you as if it were her cock, just in the same way you push it inside her. She circles your waist with her broad hips, not wanting to let you go as you bounce the sex toy inside both of you consecutively. Your hands run through her skin, as you can see that even the slightest touch of your fingers sends her into a frenzy, her moans filling the entire room as she mixes them with your name, as it seems that it’s driving her crazy.\n\n";
				PAR4 = "<i>”I want to hear you scream in delight, my dear " + GameControl.playerName + ",”</i> she coos in a low tone next to your ear. <i>”Touch me, feel me...”</i> she says, before her sensual voice sends you into a lust rage, rocking the dildo with force as you continue enjoying her whole body. You can hear how the bed croaks with the force of your hips as both of you ram themselves wildly.\n\n";
				PAR5 = "You can feel how your own orgasm gets closer, so you push it as deep as you can and kiss her one last time, just in time for you to start cumming uncontrollably into the sex toy, drenching it with your vaginal juices. You can feel how one strong moan is muffled by your kiss, as her own snatch starts convulsing around the fake cock as she gets to cum on her own. You can feel your pussy soaking her thighs and belly with your fluids, her screams of ecstasy filling the room, until your bodies are finally spent.\n\n";
				PAR6 = "As the lust haze finally disappears, you can see that she holds you in her arms. <i>”Oh dear, I would love to improve our relationship to something more… If you’re willing, of course”</i> she says, still blushing a bit even though you just had sex. So you ran a hand through her cheek and tell her that you would be interested in that. She smiles and kiss you one last time, before both of you enjoy each other’s company before falling asleep.";
			}

			Board.text = PAR0 + PAR1 + PAR2 + PAR3 + PAR4 + PAR5 + PAR6;
			endTurnFun ();
	
	}

		


	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


	public void slimeQueenIssue(){
		if (NPCControl.npc6000slimeQueen [4] == false && NPCControl.npc6000Symbiote[4] == false) {
			if (NPCCharList.CharFollower [iLucina].corruptionStage == 0 || NPCCharList.CharFollower [iLucina].corruptionStage == 4) {
				//mainPanel.sortingOrder = -500;
				panSlimeQueen.sortingOrder = 500; 
				Board.text = "Do you want to convince Lucina to become a slime queen, or to fight the monster? NOTE: Right now, only the slime queen path is implemented.";
			} else {
				Board.text = "You need to purify or corrupt her first";
			}

		} else {
			if (NPCControl.npc6000slimeQueen [4] == true) {


				if (NPCControl.npc6000CorruptPathStage > 2)
				{
					
					if (NPCControl.npc6000slimeQueen [0] == false) {
						endTurnFun ();
						NPCControl.npc6000slimeQueen [0] = true;
						Board.text = "You know that your mother is completely corrupt, now the only step left for her to become the lady you’ve been yearning for, is to become the creature that she has been fighting so hard to avoid. After all, the body she has is so exotic and enticing to you, that she should be like that forever, just for your pleasure. She will be the better version that she can be, so you devise a plan to help her to make the final jump.\n\n";
						Board.text += "After a couple of days, you finally thought of something. You know that she is more open sexually with you, even doing lewd things in public, but you can see that she stops the slime creature from time to time, as if the corruption was too much for the slime to bear and It tries to finally overcome her. \n\nYou are enjoying a lustful night with your dear mother, enjoying a good fuck, her breasts pushing against your body as both of you grind against each other. Both of your bodies are covered in your fluids, as your mother is moaning her lungs out from the sensations you are causing to her. After the whole activity finally ends, both of you are panting heavily as your bodies are aching with delight from their respective orgasms. You tell her that the sex was good, but you are sure that it could be better. You can see her looking at you with a puzzled smile. <i>“What are you talking about, my child?,”</i> she says as she lifts her torso from the bed.\n\nYou wave your hands as you tell her that she is quite good, but somehow you tell her that you were expecting a little bit more of her. Maybe it’s because you were expecting something else by seeing her just like that. As you talk, you ran a finger across her rubbery skin. You can see that she looks at her body and then turns her eyes to you. <i>“So, you think that you would like me more, if I were more… “Flexible?,”</i> she says as she weights her breasts a bit. You tell her that it could be a great improvement, you are sure of that. <i>“But, I’ve been fighting it as far as I can remember. That would be, so backwards…”</i> you can see that her tone of voice is full of doubt.\n\nYou explain to her that now she has a new way of seeing things. You tell her that she must feel it too, that her combat against the urges of the slime are useless, that she is slipping offf it’s grasp with each passing day. Perhaps it’s for the best for her to embrace her new race and try to control it from the inside. You stand from the bed as you dress yourself once more, leaving the room as you can see that she is thinking a bit about what you said.";

						Board.text = "You have been spying on your mother from time to time. She thinks that she no one is looking at her, as she is trying to let herself go to the creature that is covering her skin, but you can see that she is still unsure, because when she hears someone getting close, she stops and hides herself. You plan on doing something about that.\n\nSince she has been accepting the slime into her system, her body has been changing slightly but continuously. After one day, you caught with her as she is trying to continue her testing on letting herself go to the creature. You tell her that she looks better than before and ask her if she has done something different. You ran a hand across her ass, causing her to pant slightly. <i>”I’ve done a couple of things, my child. All of them, just for you. Do you like it?”</i> she says, as she presses her breasts between her arms, presenting them to you. You tell her that her body is looking quite nice. You’ve heard that the slimes can alter her body shape, and you tell her that is pretty interesting. You tell her of the whole array of possibilities that you could do with someone with that ability. She looks interested about those things.\n\nYou tell her also that the slimes have more control over the things they cover, and that they can use tentacles if they want. At first she looks puzzled but after you keep telling her about the myriad of things why a slime queen is so interesting, she seems more convinced. After a couple of minutes, she nods. <i>”Thank you, my child. Maybe you don’t know, but you’ve helped me a lot this day,”</i> she says as she gives you a kiss before running away. You smile as you know better than her what are you doing. You leave her to increase her experiments to become a slime queen.";

						//NPCCharList.CharFollower [iLucina].charPortrait = 6150;
						Board.text = "You finally know that she advanced significantly and that its time for you to give her the last push. You tell her that you’re planning on visit her into her bedroom, and she arrives rather quickly to the scene. You tell her that you already know what she is trying to do. You can see fear in her eyes, but you raise one of your palms as you tell her that you’re going to help her to achieve her goal. <i>”A-Are you sure, my child? Aren’t you embarrassed of my weakness?”</i> she says, avoiding your gaze. You take her by her chin and make her look at you. You tell her that its not weakness if she is going to become something better for you. You tell her that she must finally take the final step and let herself go.\n\nAnd with that, she nods at you and takes a step back, placing herself in a special place of her bedroom. You can see how the symbiote starts covering her completely, surrounding her in some kind of cocoon. It takes a while, as you’re planning on kick it to see if it increases the process, but when you were planning to do it, you can see it open. It hatches in a small explosion of black goo that stains your clothings a bit but nothing more. From it, your mother emerges as she is covered from head to toe in black latex.  Her hair seems to be between a solid and a liquid form.  Her blue eyes seem to shine with a bright energy.  Her breasts and genitals are no longer encased in latex, now they are made of latex. She also has four appendage coming out of her back that look like tentacles. Completing the picture are the heels seemingly coming out of your mothers foot. Despite the transformation, she look as gorgeous as ever, perhaps even more now.\n\nAfter that, you can see that despite you told her, it seems that her slime queen instinctive mind took over her rather quickly. She doesn’t say a word as she looks around. Her posture changes a bit as you can see that she seems to be hunting something. After a bit, you tell her that if she is horny, then she can search for someone to sate her urges, then she can comeback for more. After that, you can see her liquefying, her body making herself a mass of oozing rubber as she darts out of the bedroom, probably hunting for some unaware soul. Perhaps you’ll visit her later to have some fun with her.";


					
					} else if (NPCControl.npc6000slimeQueen [1] == false) {
						NPCControl.npc6000slimeQueen [1] = true;
						endTurnFun ();
						Board.text = "After a couple of days, you finally thought of something. You know that she is more open sexually with you, even doing lewd things in public, but you can see that she stops the slime creature from time to time, as if the corruption was too much for the slime to bear and It tries to finally overcome her. \n\nYou are enjoying a lustful night with your dear mother, enjoying a good fuck, her breasts pushing against your body as both of you grind against each other. Both of your bodies are covered in your fluids, as your mother is moaning her lungs out from the sensations you are causing to her. After the whole activity finally ends, both of you are panting heavily as your bodies are aching with delight from their respective orgasms. You tell her that the sex was good, but you are sure that it could be better. You can see her looking at you with a puzzled smile. <i>“What are you talking about, my child?,”</i> she says as she lifts her torso from the bed.\n\nYou wave your hands as you tell her that she is quite good, but somehow you tell her that you were expecting a little bit more of her. Maybe it’s because you were expecting something else by seeing her just like that. As you talk, you ran a finger across her rubbery skin. You can see that she looks at her body and then turns her eyes to you. <i>“So, you think that you would like me more, if I were more… “Flexible?,”</i> she says as she weights her breasts a bit. You tell her that it could be a great improvement, you are sure of that. <i>“But, I’ve been fighting it as far as I can remember. That would be, so backwards…”</i> you can see that her tone of voice is full of doubt.\n\nYou explain to her that now she has a new way of seeing things. You tell her that she must feel it too, that her combat against the urges of the slime are useless, that she is slipping offf it’s grasp with each passing day. Perhaps it’s for the best for her to embrace her new race and try to control it from the inside. You stand from the bed as you dress yourself once more, leaving the room as you can see that she is thinking a bit about what you said.";
					} else if (NPCControl.npc6000slimeQueen [2] == false) {
						NPCControl.npc6000slimeQueen [2] = true;
						endTurnFun ();
						Board.text = "You have been spying on your mother from time to time. She thinks that she no one is looking at her, as she is trying to let herself go to the creature that is covering her skin, but you can see that she is still unsure, because when she hears someone getting close, she stops and hides herself. You plan on doing something about that.\n\nSince she has been accepting the slime into her system, her body has been changing slightly but continuously. After one day, you caught with her as she is trying to continue her testing on letting herself go to the creature. You tell her that she looks better than before and ask her if she has done something different. You ran a hand across her ass, causing her to pant slightly. <i>”I’ve done a couple of things, my child. All of them, just for you. Do you like it?”</i> she says, as she presses her breasts between her arms, presenting them to you. You tell her that her body is looking quite nice. You’ve heard that the slimes can alter her body shape, and you tell her that is pretty interesting. You tell her of the whole array of possibilities that you could do with someone with that ability. She looks interested about those things.\n\nYou tell her also that the slimes have more control over the things they cover, and that they can use tentacles if they want. At first she looks puzzled but after you keep telling her about the myriad of things why a slime queen is so interesting, she seems more convinced. After a couple of minutes, she nods. <i>”Thank you, my child. Maybe you don’t know, but you’ve helped me a lot this day,”</i> she says as she gives you a kiss before running away. You smile as you know better than her what are you doing. You leave her to increase her experiments to become a slime queen.";
					} else if (NPCControl.npc6000slimeQueen [3] == false) {
						NPCControl.npc6000slimeQueen [3] = true;
						endTurnFun ();
						//NPCCharList.CharFollower [iLucina].charPortrait = 6150;
						Board.text = "You finally know that she advanced significantly and that its time for you to give her the last push. You tell her that you’re planning on visit her into her bedroom, and she arrives rather quickly to the scene. You tell her that you already know what she is trying to do. You can see fear in her eyes, but you raise one of your palms as you tell her that you’re going to help her to achieve her goal. <i>”A-Are you sure, my child? Aren’t you embarrassed of my weakness?”</i> she says, avoiding your gaze. You take her by her chin and make her look at you. You tell her that its not weakness if she is going to become something better for you. You tell her that she must finally take the final step and let herself go.\n\nAnd with that, she nods at you and takes a step back, placing herself in a special place of her bedroom. You can see how the symbiote starts covering her completely, surrounding her in some kind of cocoon. It takes a while, as you’re planning on kick it to see if it increases the process, but when you were planning to do it, you can see it open. It hatches in a small explosion of black goo that stains your clothings a bit but nothing more. From it, your mother emerges as she is covered from head to toe in black latex.  Her hair seems to be between a solid and a liquid form.  Her blue eyes seem to shine with a bright energy.  Her breasts and genitals are no longer encased in latex, now they are made of latex. She also has four appendage coming out of her back that look like tentacles. Completing the picture are the heels seemingly coming out of your mothers foot. Despite the transformation, she look as gorgeous as ever, perhaps even more now.\n\nAfter that, you can see that despite you told her, it seems that her slime queen instinctive mind took over her rather quickly. She doesn’t say a word as she looks around. Her posture changes a bit as you can see that she seems to be hunting something. After a bit, you tell her that if she is horny, then she can search for someone to sate her urges, then she can comeback for more. After that, you can see her liquefying, her body making herself a mass of oozing rubber as she darts out of the bedroom, probably hunting for some unaware soul. Perhaps you’ll visit her later to have some fun with her.";
					} else {
						Board.text = "The transformation of your mother is finished!"; 
					}
				} else {
					
					if (NPCControl.npc6000slimeQueen [0] == false) {
						NPCControl.npc6000slimeQueen [0] = true;
						endTurnFun ();

						Board.text = "You know that being a slime queen has its benefits, but you worry that she could lose her mind in the transformation. Perhaps what she needs is that her will is strong as ever, perhaps some help on your behalf to help her accept that creature and tame her with her soul. You know that she has the abilities to do it, but you still devise a plan to help her with that without endangering her sanity or personality.\n\n";
						Board.text = "You can see that your mother is thinking in one bench In the park that you showed to her. You approach her as you can see sighing, asking her what’s wrong. <i>”I’m sorry, my child. It’s just that I feel that I haven’t accomplished anything against this creature,”</i> she says as she runs a hand over her latex cover. You pat one of her shoulders carefully, as you know how easy for her is to get aroused with direct contact.\n\nYou tell her that maybe, the reason is because she has been fighting in the wrong way. She looks at you a bit confused, so you elaborate. You tell her that maybe holding off that creature at bay is too tiring for her. Maybe if she stops trying to stop the river and focus on redirecting it, maybe that would be easier for her psyche. She thinks about the metaphor that you just said and looks at the ground. <i>”So, you’re telling me that I should let the creature fulfill its cycle and then I should temper it with my willpower”</i>. You nod and tell her that more or less, that’s your idea. She looks at you and then into the ground. <i>”I dunno if I’ll be able to hold it,”</i> and with that you ran a hand below her back, something that makes her pant just a bit. You tell her that any other person in her condition would have jumped already at you.\n\nYou tell her that if there is someone with that capacity, is her. She looks at you, kissing the corner of your lips before standing up. <i>”Maybe I need to think about it,”</i> she says before standing up from the bench and walking, as you can smell the scent of her arousal. Oh, mother…";

					
						Board.text = "This time you try to help her by staying with her during her meditation trainings, but maybe she needs someone who can support her. You are with her during the times that she has to fight the creature’s urges, helping her to relieve herself when she does a good job. After all, she has now that kind of trust with you, so you can help her in that manner. Several times you see that she is at the brink of letting herself go, but she manages to return every time.\n\nOne of that times, you can see that she has you pinned against the ground, her mouth drooling as she has a direct gaze at your crotch. Her own cunt is dripping with juices as she is just about to ravage you. You tell her that she should think what your sister would think if she returns and only finds a monster instead of her mother. That she hasn’t fought for all this time only to fall at the end. You can see how your mother snaps back into her usual self, so you took the chance and turn the tables, inmobilizing her as you wait for her to rest for a bit. She thanks you with a careful kiss, before having a more romantic sex..\n\nIt has been a while, but you think that she is ready to take the next step on controlling that creature.";


						//NPCCharList.CharFollower [iLucina].charPortrait = 6150;
						Board.text = "You found that the purification elixir has been helping her to take control of the creature, perhaps it will help her one last time. And with that, you go to her bedroom and explain the situation to her. She is a bit hesitant at first, but you know that she has been thinking on doing it on her own. <i>”I don’t want to lose you a second time,”</i> she says, definitely worried about the outcome. And you know that hesitation is what its keeping her from trying. You grab her hands and tell her that you have a purification elixir, something that will help her to overcome that fear. You take out the pristine bottle and place it on her hands.\n\nShe looks at it, then at you and nods. <i>”You’re right, my child, I have to do this. You’re as brave as your father,”</i> she says as she runs a hand through your cheek, just before drinking the elixir. After that, she closes her eyes and lets the symbiote take her slowly. You can see how the creature starts covering her head, as she walks back into one corner of the bedroom as her whole body starts being encircled by some kind of latex cocoon. After that, you cannot do other thing than wait, and you have to do it for a couple of hours. You are starting to get worried, but your faith in her didn’t falter. Finally, she erupted from the cocoon in an explosion of black goo. Her hair seems to be between a solid and a liquid form.  Her blue eyes seem to shine with a bright energy.  Her breasts and genitals are no longer encased in latex, now they are made of latex. She also has four appendage coming out of her back that look like tentacles. Completing the picture are the heels seemingly coming out of your mothers foot. Despite the transformation, she look as gorgeous as ever, perhaps even more now.\n\nYou can see how she opens her eyes, the spark of intelligence still in them. It seems that she emerged triumphant from the battle with that creature. You call for her, as she notices you and walks slowly in your direction and hugs you delicately. <i>”I DID IT, MY CHILD! You had faith in me all this time! Thank you!”</i> she says just before kissing you passionately, as you can feel that her body reacts to your touch, but she isn’t being tortured by the desire of that creature. She seems to be finally free from its mind, her body now more akin to that creatures. <i>”I need… some water. Come and visit me another time, perhaps we can put this new body to good use. I would love to test it with my lover…”</i> she gives you a wink before liquefying and leaving the room. Oh, Lucina, it’s good to see that she is finally free to do what she wants.";

					} else if (NPCControl.npc6000slimeQueen [1] == false) {
						NPCControl.npc6000slimeQueen [1] = true;
						endTurnFun ();
						Board.text = "You can see that your mother is thinking in one bench In the park that you showed to her. You approach her as you can see sighing, asking her what’s wrong. <i>”I’m sorry, my child. It’s just that I feel that I haven’t accomplished anything against this creature,”</i> she says as she runs a hand over her latex cover. You pat one of her shoulders carefully, as you know how easy for her is to get aroused with direct contact.\n\nYou tell her that maybe, the reason is because she has been fighting in the wrong way. She looks at you a bit confused, so you elaborate. You tell her that maybe holding off that creature at bay is too tiring for her. Maybe if she stops trying to stop the river and focus on redirecting it, maybe that would be easier for her psyche. She thinks about the metaphor that you just said and looks at the ground. <i>”So, you’re telling me that I should let the creature fulfill its cycle and then I should temper it with my willpower”</i>. You nod and tell her that more or less, that’s your idea. She looks at you and then into the ground. <i>”I dunno if I’ll be able to hold it,”</i> and with that you ran a hand below her back, something that makes her pant just a bit. You tell her that any other person in her condition would have jumped already at you.\n\nYou tell her that if there is someone with that capacity, is her. She looks at you, kissing the corner of your lips before standing up. <i>”Maybe I need to think about it,”</i> she says before standing up from the bench and walking, as you can smell the scent of her arousal. Oh, mother…";
					} else if (NPCControl.npc6000slimeQueen [2] == false) {
						NPCControl.npc6000slimeQueen [2] = true;
						endTurnFun ();
						Board.text = "This time you try to help her by staying with her during her meditation trainings, but maybe she needs someone who can support her. You are with her during the times that she has to fight the creature’s urges, helping her to relieve herself when she does a good job. After all, she has now that kind of trust with you, so you can help her in that manner. Several times you see that she is at the brink of letting herself go, but she manages to return every time.\n\nOne of that times, you can see that she has you pinned against the ground, her mouth drooling as she has a direct gaze at your crotch. Her own cunt is dripping with juices as she is just about to ravage you. You tell her that she should think what your sister would think if she returns and only finds a monster instead of her mother. That she hasn’t fought for all this time only to fall at the end. You can see how your mother snaps back into her usual self, so you took the chance and turn the tables, inmobilizing her as you wait for her to rest for a bit. She thanks you with a careful kiss, before having a more romantic sex..\n\nIt has been a while, but you think that she is ready to take the next step on controlling that creature.";
					} else if (NPCControl.npc6000slimeQueen [3] == false) {
						NPCControl.npc6000slimeQueen [3] = true;
						endTurnFun ();
						//NPCCharList.CharFollower [iLucina].charPortrait = 6150;
						Board.text = "You found that the purification elixir has been helping her to take control of the creature, perhaps it will help her one last time. And with that, you go to her bedroom and explain the situation to her. She is a bit hesitant at first, but you know that she has been thinking on doing it on her own. <i>”I don’t want to lose you a second time,”</i> she says, definitely worried about the outcome. And you know that hesitation is what its keeping her from trying. You grab her hands and tell her that you have a purification elixir, something that will help her to overcome that fear. You take out the pristine bottle and place it on her hands.\n\nShe looks at it, then at you and nods. <i>”You’re right, my child, I have to do this. You’re as brave as your father,”</i> she says as she runs a hand through your cheek, just before drinking the elixir. After that, she closes her eyes and lets the symbiote take her slowly. You can see how the creature starts covering her head, as she walks back into one corner of the bedroom as her whole body starts being encircled by some kind of latex cocoon. After that, you cannot do other thing than wait, and you have to do it for a couple of hours. You are starting to get worried, but your faith in her didn’t falter. Finally, she erupted from the cocoon in an explosion of black goo. Her hair seems to be between a solid and a liquid form.  Her blue eyes seem to shine with a bright energy.  Her breasts and genitals are no longer encased in latex, now they are made of latex. She also has four appendage coming out of her back that look like tentacles. Completing the picture are the heels seemingly coming out of your mothers foot. Despite the transformation, she look as gorgeous as ever, perhaps even more now.\n\nYou can see how she opens her eyes, the spark of intelligence still in them. It seems that she emerged triumphant from the battle with that creature. You call for her, as she notices you and walks slowly in your direction and hugs you delicately. <i>”I DID IT, MY CHILD! You had faith in me all this time! Thank you!”</i> she says just before kissing you passionately, as you can feel that her body reacts to your touch, but she isn’t being tortured by the desire of that creature. She seems to be finally free from its mind, her body now more akin to that creatures. <i>”I need… some water. Come and visit me another time, perhaps we can put this new body to good use. I would love to test it with my lover…”</i> she gives you a wink before liquefying and leaving the room. Oh, Lucina, it’s good to see that she is finally free to do what she wants.";
					} else {
						Board.text = "The transformation of your mother is finished!"; 
					}



				}

			}

			if (NPCControl.npc6000Symbiote[4] == true) {
				if (NPCControl.npc6000CorruptPathStage > 2) {
					if (NPCControl.npc6000Symbiote [0] == false) {
						Board.text = "";
					} else if (NPCControl.npc6000Symbiote [1] == false) {
						Board.text = "";
					} else if (NPCControl.npc6000Symbiote [2] == false) {
						Board.text = "";
					} else if (NPCControl.npc6000Symbiote [3] == false) {
						Board.text = "";
					} else {
						Board.text = "The transformation of your mother is finished!"; 
					}
				} else {
					if (NPCControl.npc6000Symbiote [0] == false) {
						Board.text = "";
					} else if (NPCControl.npc6000Symbiote [1] == false) {
						Board.text = "";
					} else if (NPCControl.npc6000Symbiote [2] == false) {
						Board.text = "";
					} else if (NPCControl.npc6000Symbiote [3] == false) {
						Board.text = "";
					} else {
						Board.text = "The transformation of your mother is finished!"; 
					}


				}
			}


		}

	}

	public void selectIssue(int selector){
		//panSlimeQueen.sortingOrder = -500;
		if (selector == 0) {
			
			panConfirmationTitle.text = "Do you want to transform her into a Slime Queen?";
			callConfirmation (2);
		}

		if(selector == 1){
			panConfirmationTitle.text = "Do you want her to fight the slime?";
			callConfirmation (3);
		}

	}







	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	public void selectSexScene(int selector){
		switch (selector) {
		case 1:
			sexSlimeQueen1 ();
			break;
		case 2:
			sexSlimeQueen2 ();
			break;
		case 3:
			sexSlimeQueen3 ();
			break;
		case 4:
			sexSlimeQueen4 ();
			break;
		case 5:
			sexSlimeQueen5 ();
			break;
		case 6:
			sexSlimeQueen6 ();
			break;

		default:
			break;
		}


	}


	void sexSlimeQueen1(){
		GameControl.actualArousal = 0;
		endTurnFun ();

		if (NPCCharList.CharFollower [iLucina].corruptionStage > 2) {
			Board.text = "You decide to take a rest from your daily duties, so you tell your mother that you have some plans for her, something that sparks a hint of lust in her eyes. She flows closer to you like a predator, her new body jiggling even more than before as she does. You guide her to your bedroom, and as you are getting closer to your bed, as you turn around you can feel how your mother is pushing her body against you, forcing you to lay your back on the bed, as she grind her soft rubbery body against yours. The sensation of her new form is fantastic, as she almost molds herself around body as she is having her face almost against yours, her eyes full of desire. <i>”Need…”</i> she says in a teasing voice with the best of her abilities, as you can feel her breasts pushing against your torso.\n\nYou point at the lower part of your clothes, as you tell her that you would like some attention inside your pants. She slides slowly from your chest and gets closer to your groin. <i>”Leave all to me…”</i>  she says in an alluring tone, as she uses her flexible hands to undress your lower half of your clothes.\n\n";
			if (GameControl.dick1Size > 0 /*&& GameControl.charArmorTags[1] == false &&GameControl.charArmorTags[2] == false*/) {
				string line1 = "";
				string line2 = "";
				if (GameControl.testiclesSize > 0) {
					line1 = ", and your balls are empty of your juices";
				}
				if (GameControl.hasVagina == true) {
					line2 = ", as she rubs the entrance of your cunt with her other hand, enjoying the lubrication that she can feel that you are generating already";
				}
				Board.text += "After she removes it, she exposes your " + GameControl.mcDick1Name.toDescription () + " " + GameControl.mcDick1Name.toDescription () +" dick and give it a small lick, leaving a small trail of saliva and  all over it"+ line2+". She start stroking it as you can feel that her new texture of her hands was something delightful, her almost malleable skin rubs against your skin as if it’s already lubricated and warm, causing you to get hard in no time. You could swear that it’s softer than before, even though her aspect remains almost the same. Did her body structure changed with the transformation? <i>”Do you… like it?”</i> she says as she wraps your shaft with her tongue. You can feel how she is being submissive to you, as if she needs you more than you need her. You smile with satisfaction as she keeps working your cock, now introducing it into her sloppy mouth, her new insides are amazing, as if they flex over and over again at your dick, rubbing it as she tries to make you cum.\n\nYou take her head and start facefucking her, as you can see that she enjoys being used by you like a common whore, her eyes rolling into her head as you thrust your dick into her throat, bobbing her head in and out, as you satisfy your urges. You can feel the scent of arousal from your mother’s own pussy, as a testament of her own pleasure from your way of fucking her face, as if she surrendered to the fact that she is being used by her own son for his carnal urges. \n\nFinally, you can’t hold on anymore so you push your dick as deep as you can, as you pour your load inside her hungry slime mouth, as you can see a faint trace of your white cum flowing through her throat and inside her, as she trembles from her own orgasm as she is being filled with your hot white cream, dissolving after a bit of entering her belly. After you finally stop filling her until your cock is dripping with a mix of her saliva and your spunk"+ line1 +", you push her aside as she is enjoying herself with her fingers after that. You tell her that she has done a good work but she still needs to clean her mess before she leaves. <i>”At your order,”</i> she says as she nods and licks all the cum from your dick before leaving the room.";


			} else if (GameControl.hasVagina) {
				Board.text += "After she removes it, she rubs the entrance of your cunt with her other hand, enjoying the lubrication that she can feel that you are generating already. She start rubbing it as you can feel that her new texture of her hands was something delightful, her almost malleable skin rubs against your skin as if it’s already lubricated and warm, causing you to get wet in no time. You could swear that it’s softer than before, even though her aspect remains almost the same. Did her body structure changed with the transformation? <i>”Do you… like it?”</i> she says as she laps your cunt with her tongue. You can feel how she is being submissive to you, as if she needs you more than you need her. You smile with satisfaction as she keeps working your pussy, now introducing her flexible tongue inside your pussy, her new tongue flesh is amazing, as if they flex over and over again at your dick, rubbing it as she tries to make you cum.\n\nYou take her head and start facefucking her against your twat, as you can see that she enjoys being used by you like a common whore, her eyes rolling into her head as you press your cunt into her face, bobbing her head in and out, as you satisfy your urges. You can feel the scent of arousal from your mother’s own pussy, as a testament of her own pleasure from your way of treating her face, as if she surrendered to the fact that she is being used by her own son for his carnal urges. \n\nFinally, you can’t hold on anymore so you press your cunt as deep as you can, as you soak her mouth and latex skin with your vaginal juices, as you can see a faint trace of your femspunk flowing through her throat and inside her, as she trembles from her own orgasm as she is being filled with your sour pussy juices, dissolving after a bit of entering her belly. After you finally stop filling her until you’re exhausted, you push her aside as she is enjoying herself with her fingers after that. You tell her that she has done a good work but she still needs to clean her mess before she leaves. <i>”At your order,”</i> she says as she nods and licks all the fluids from your pussy and thighs before leaving the room.";



			} else {
				Board.text += "No scene for eunuch's yet.";

			}
		} else {
			Board.text = "You know that since she has taken control of her slime queen body, her libido has been increasing, something that has been making you a bit more tired than usual, but its all worth it in the end. You wake up next to her, as she caresses your cheek. <i>“Good day, my love”</i> she says, as you can see that you’re in her bedroom. A pair of hands brought you back into the bed. Its one of the slime-drones that was brought to life by one of the first times that your mother and you had sex, you remember that her name is Selena. She has grown into adulthood quicker than the others, her breasts are already B’s and her hips are second only to your mother. <i>”Its not often for you to have some spare time for her”</i> your mother says as you nod to her, laying close to Selena. You start chatting with her as your mother have other plans in mind for your time together with Selena.\n\nShe removes the lower part of your clothes, as you continue hearing the ups and downs of Selena. She slides slowly from your chest and gets closer to your groin. <i>”Don’t mind me, continue your conversation”</i>  she says in an alluring tone, as she uses her flexible hands to tease your groin.";

			if (GameControl.dick1Size > 0 /*&& GameControl.charArmorTags[1] == false &&GameControl.charArmorTags[2] == false*/) {
	
				string line1 = "";
				string line2 = "";
				if (GameControl.testiclesSize > 0) {
					line1 = ", and your balls are empty of your juices";
				}
				if (GameControl.hasVagina == true) {
					line2 = ", as she rubs the entrance of your cunt with her other hand, enjoying the lubrication that she can feel that you are generating already";
				}
				Board.text += "After she removes it, she exposes your " + GameControl.mcDick1Name.toDescription () + " "+ GameControl.mcDick1Name.toDescription () + " dick and give it a small lick, leaving a small trail of saliva and  all over it"+ line2 +". She start stroking it as you can feel that her new texture of her hands was something delightful, her almost malleable skin rubs against your skin as if it’s already lubricated and warm, causing you to get hard in no time. You could swear that it’s softer than before, even though her aspect remains almost the same. Did her body structure changed with the transformation? As she does that, you can hear from Selena how she started playing with Helena, as she was scared at her at first. <i>”Keep going”</i> she says as she wraps your shaft with her tongue. You smile with satisfaction as she keeps working your cock, now introducing it into her sloppy mouth, her new insides are amazing, as if they flex over and over again at your dick, rubbing it as she tries to make you cum. You try to continue the conversation with Selena, asking her about the castle and the results of her meanderings. She answers that she is always looking for you inside the castle, but she usually caught you having sex with your mother, Lucina. \n\nAs she hears that, your mother starts bobbing her head faster and harder. You can see Selena gets closer to your ear and saying that she got off several times to your escapades. You can feel the scent of arousal from your mother’s own pussy, as a testament of her own pleasure from what she has been hearing from you two. After that, you can feel Selena’s hand teasing the base of your cock as she kisses you while your mother keeps working your cock.\n\nFinally, you can’t hold on anymore so you push your dick as deep as you can, as you pour your load inside her hungry slime mouth, while you can see a faint trace of your white cum flowing through her throat and inside her, as she trembles from her own orgasm while she is being filled with your hot white cream, dissolving after a bit of entering her belly. Your daughter strokes you until she feels that you can’t go on. After you finally stop filling her until your cock is dripping with a mix of her saliva and your spunk"+ line1 +", as your mother cleans her mouth then looks at your daughter. <i>”My girl, just remember not to hog its cock when your sisters are with you”</i> she says in a tone of reprimand, something that makes your daughter wave her hand as she liquefies and starts leaving the room. You tell your mother that you have some lewd daughter. <i>”Just like you, my love”</i> she says with a mischievous smile. And with that, you dress yourself and leave the room thinking about what other kind of things await for you with your new and special family.";


			} else if (GameControl.hasVagina) {
				Board.text += "After she removes it, she rubs the entrance of your cunt with her other hand, enjoying the lubrication that she can feel that you are generating already. She start rubbing it as you can feel that her new texture of her hands was something delightful, her almost malleable skin rubs against your skin as if it’s already lubricated and warm, causing you to get wet in no time. You could swear that it’s softer than before, even though her aspect remains almost the same. Did her body structure changed with the transformation? As she does that, you can hear from Selena how she started playing with Helena, as she was scared at her at first. <i>”Keep going”</i> she says as she laps your cunt with her tongue. You can feel how she is being submissive to you, as if she needs you more than you need her. You smile with satisfaction as she keeps working your pussy, now introducing her flexible tongue inside your pussy, her new tongue flesh is amazing, as if they flex over and over again at your dick, rubbing it as she tries to make you cum. You try to continue the conversation with Selena, asking her about the castle and the results of her meanderings. She answers that she is always looking for you inside the castle, but she usually caught you having sex with your mother, Lucina. \n\nYou take her head and start facefucking her against your twat. You can see Selena gets closer to your ear and saying that she got off several times to your escapades. You can feel the scent of arousal from your mother’s own pussy, as a testament of her own pleasure from what she has been hearing from you two. After that, you can feel Selena’s hand teasing the top of your cunt as she kisses you while your mother keeps working it.\n\nFinally, you can’t hold on anymore so you press your cunt as deep as you can, as you soak her mouth and latex skin with your vaginal juices, as you can see a faint trace of your femspunk flowing through her throat and inside her, as she trembles from her own orgasm as she is being filled with your sour pussy juices, dissolving after a bit of entering her belly. Your daughter strokes you until she feels that you can’t go on. After you finally stop filling her until you’re exhausted, as your mother cleans her mouth then looks at your daughter. <i>”My girl, just remember not to hog its pussy when your sisters are with you”</i> she says in a tone of reprimand, something that makes your daughter wave her hand as she liquefies and starts leaving the room. You tell your mother that you have some lewd daughter. <i>”Just like you, my love”</i> she says with a mischievous smile. And with that, you dress yourself and leave the room thinking about what other kind of things await for you with your new and special family.You tell her that she has done a good work but she still needs to clean her mess before she leaves. <i>”At your order,”</i> she says as she nods and licks all the fluids from your pussy and thighs before leaving the room.";



			} else {
				Board.text = "no scene for eunuchs yet, sorry!"; 

			}

		}


	}

	void sexSlimeQueen2(){
		GameControl.actualArousal = 0;
		endTurnFun ();

		if (NPCCharList.CharFollower [iLucina].corruptionStage > 2) {
			Board.text = "You've come to really appreciate things in the castle, especially since you remember your time in the cabin. Having a large bathing room has its benefits. It has been definitely an improving to the cold river that you used with your Guardian taking care of you after your trainings. But now you have your own baths and you always plan on using them as much as you can, and after some combat training, you definitely have a good excuse to use them.\n\nYou undress slowly from your clothes as you enter the bath and enjoy a bit of its relaxing sensation, but after a couple of minutes you hear something strange in the baths. After a bit of looking, you can see that the water in the baths is running lower than before. When you realize that it’s coming from the faucet, you know what is happening. Before you can say something to your mother, she jumps and sits over your lap, pressing her breasts against your torso. You know that she is bigger than before in all her measures because of the excess of water that she consumed. <i>”Found you!”</i> she says, as you can’t deny that her breasts are quite delightful right now.\n\nBefore you can say anything on the matter, she starts rubbing her enormous breasts against your groin, trying to tease you as much as she can. <i>”Fuck me, my dear!,”</i> she says as you can feel the excitement doing its work, getting you pent up in no time, as she lowers herself closer to your groin with a clear intention in her mind.\n\n";
			if (GameControl.dick1Size > 0 /*&& GameControl.charArmorTags[1] == false &&GameControl.charArmorTags[2] == false*/) {
				
				Board.text += "She starts covering your " + GameControl.mcDick1Name.toDescription () + " "+ GameControl.mcDick1Name.toDescription () + " with her gigantic tits, her boob flesh running around your shaft, massaging it with great delight. You can feel that her breasts are amazing, but you have other plans in mind. You take one of her boobs with your hands and lifts it until you can see her big and perky nipple pressing against your cock. You hold it as you press your cock’s tip against her nipple, slowly pushing itself inside her breast. When she realizes what are you planning to do, she gets a hold of your legs and start pushing her breast against your cock. The tightness of her nipple is amazing, as she massages the tit flesh, sending ripples of pleasure across your whole shaft and into your body. After your whole length is inside, you start thrusting without dilation, as the hole you forced inside her accepted you more and more with each thrust you made inside that part of her. You couldn’t last that longer with that force of sensations making you crazy, as you can see that she is enjoying herself too. Her own latex tentacles plunge into every hole she has, fixing her into an state of lust that you’re causing her too.\n\nWhen you finally cum, you can see load after load of your own cum flowing into her chest and dissolving after a couple of seconds inside her. She gets an orgasm on her own, as her tentacles spurt slime all around her just before you collapse from exhaustion over her enormous body. She helds you as you slowly drift into unconsciousness for a couple of hours.\n\n";


			} else if (GameControl.hasVagina) {

				Board.text += "Your own pussy is soaking wet from her ministrations as she moves in front of you while still rubbing herself against you, your own scent of arousal mixing with hers. You tell her that she must make herself responsible from her actions. You can see that she is having a puzzled smile but after taking a good look at your pussy, she finally understand what you meant by that. But before she could answer at that, you take her from her shoulders and proceed to press her face against your twat. You can feel her hands around your back as you force her in and out of your cunt. You can feel how your groin slaps her latex-covered face every time you ram her with your thighs. She feels lighter since the transformation, which made easier that fucking, as her ample breasts bounce against your legs, every time you thrust her mouth and tongue with your pussy. You are already pent up from that rubbing, so you can’t hold on that much, as you began soaking her face with your femspunk, her needy twat sucking every load to the last drop. <i>”Yes! Soak me, please!”</i>\n\nAfter you finished with her, she slips back into the bath, floating over the water for a couple of seconds as she has her own orgasm, her face of complete delight as her tentacles won’t stop spurting her slime all around her body. After that she finally returns to you, helping you to get cleaned off without further incidents. After that, you leave her to clean herself as you feel reinvigorated. You truly have come to appreciate the small things in the castle, like your own personal whore in the baths.\n\n";


			} else {
				Board.text += "Not scene for eunuch yet.";

			}
		} else {
			Board.text = "You've come to really appreciate things in the castle, especially since you remember your time in the cabin. Having a large bathing room has its benefits. It has been definitely an improving to the cold river that you used with your Guardian taking care of you after your trainings. But now you have your own baths and you always plan on using them as much as you can, and after some  “training”, you definitely have a good excuse to use them.\n\nYou undress slowly from your clothes as you enter the bath and enjoy a bit of its relaxing sensation, but after a couple of minutes you hear something strange in the baths. After a bit of looking, you can see that the water in the baths is of somehow a different consistency. When you realize that, you see that someone is at the other end of the baths, and with that you know what is happening. Before you can say something to your mother, she starts talking first. <i>”I hope you have some strength left for mommy. Come to me, I’ll wash you”</i> she says, as you can’t deny that her silhouette is quite delightful right now. So you start approaching to her, as you can feel that the water isn’t what you thought it is at first, as it’s a mix between slime and water. Probably your mother is the bath right now. \n\nBefore you can say anything on the matter, she starts rubbing her enormous and soapy breasts against your back, trying to tease you as much as she can while washing you slowly. <i>”Good to know that you can’t get enough of me, my child,”</i> she says as you can feel the excitement doing its work.\n\n";
			if (GameControl.dick1Size > 0 /*&& GameControl.charArmorTags[1] == false &&GameControl.charArmorTags[2] == false*/) {
				string line1 = "";


				if (GameControl.hasVagina == true) {
					line1 = ", as your cunt is dripping with juices, your own scent of arousal mixing with hers";
				}
				Board.text += "Your own cock is rock hard from her ministrations as she moves in front of you while still rubbing herself against you"+ line1 +", so you tell her that she must make herself responsible from her actions. You can see that she is having a puzzled smile but after taking a good look at your rock-solid " + GameControl.mcDick1Name.toDescription () + " "+ GameControl.mcDick1Name.toDescription () + " she finally understand what you meant by that. But before she could answer at that, you take her from her shoulders and proceed to thrust your cock inside her. You can feel her hands around your back as you force her in and out of your cock. You can feel how your groin slaps her latex-covered ass every time you ram her with your thighs. She feels lighter since the transformation, which made easier that fucking, as her ample breasts bounce against your chest, every time you thrust her twat with your strong prick. You are already pent up from that rubbing, so you can’t hold on that much, as you began filling her cunt with your thick spunk, her needy twat sucking every load to the last drop. <i>”Yes, my child! Fill me up, please!”</i>\n\nAfter you finished with her, she slips back into the bath, floating over the water for a couple of seconds  as she has her own orgasm,her face of complete delight as her tentacles won’t stop spurting her slime all around her body. After that she finally returns to you, helping you to get cleaned off without further incidents. After that, you leave her to clean herself as you feel reinvigorated. You truly have come to appreciate the small things in the castle, like your own mother being fucked by you in the baths.\n\n";



			} else if (GameControl.hasVagina) {

				Board.text += "Your own pussy is soaking wet from her ministrations as she moves in front of you while still rubbing herself against you, your own scent of arousal mixing with hers. You tell her that she must make herself responsible from her actions. You can see that she is having a puzzled smile but after taking a good look at your pussy, she finally understand what you meant by that. But before she could answer at that, you take her from her shoulders and proceed to press her face against your twat. You can feel her hands around your back as you force her in and out of your cunt. You can feel how your groin slaps her latex-covered face every time you ram her with your thighs. She feels lighter since the transformation, which made easier that fucking, as her ample breasts bounce against your legs, every time you thrust her mouth and tongue with your pussy. You are already pent up from that rubbing, so you can’t hold on that much, as you began soaking her face with your femspunk, her needy twat sucking every load to the last drop. <i>”Yes, my child! Soak me completely, please!”</i>\n\nAfter you finished with her, she slips back into the bath, floating over the water for a couple of seconds as she has her own orgasm, her face of complete delight as her tentacles won’t stop spurting her slime all around her body. After that she finally returns to you, helping you to get cleaned off without further incidents. After that, you leave her to clean herself as you feel reinvigorated. You truly have come to appreciate the small things in the castle, like your own mother being fucked by you in the baths.\n\n";


			} else {
				Board.text += "Not scene for eunuch yet.";

			}

		}


	}

	void sexSlimeQueen3(){
		GameControl.actualArousal = 0;
		endTurnFun ();

		if (NPCCharList.CharFollower [iLucina].corruptionStage > 2) {
			Board.text = "You’ve been reading the laws and past mandates, to know more about what your father did in the golden era of the city. You strive to do the same or even better, but it’s not an easy task. You are a bit frustrated, so you place the book down as you try to rest your head a bit by looking at your surroundings. As your eyes wander through the library, you can see someone lurking around the bookshelves of the place. At first glance you couldn’t discern its features but after a bit you recognized it as your mother, Lucina.\n\nSince she gave into the slime queen, she seems less interested in reading and more in hunting desirable prey. You know that she is able to read, just that she isn’t prone to do it anymore, as she has more lust-fueled things in mind now. She thinks that you haven’t seen her, so she circles you and prepared to jump over you and get the advantage. When she is ready to enact her plan, you call out for her by her name and force her out of hiding, inviting her to accompany you.\n\nShe gets closer to you as she grabs one of your legs as she rubs her rubbery face against your leg. <i>”I’ve missed your touch…”</i> You can see that she looks hornier than usual, perhaps you could use the rest. <i>”I need…,”</i> she says as she rubs her face against your crotch. She helps you with some desperation to remove your clothes as you tell her to sit down next to you. When she does, she doesn’t lose time and leans to you, as you know that she enjoys the contact with you since she became the creature she is today. \n\n";
			if (GameControl.dick1Size > 0 /*&& GameControl.charArmorTags[1] == false &&GameControl.charArmorTags[2] == false*/) {
				
				Board.text += "Without further warning, she starts stroking you with one of her elastic hands until you’re as hard as you can get. When you think that she is planning on giving you a handjob, she start impaling her gooey hand against your " + GameControl.mcDick1Name.toDescription () + " "+ GameControl.mcDick1Name.toDescription () + " prick, forcing it inside her slime arm. The tightness and the way her arm rubs against your prick is unbelievable, the pleasure is hard to bear without succumbing to the sweet release of your orgasm. You can see a mischievous smile on her face as she knows that it isn’t that far before you cum, but you wouldn’t go down without a fight. As you can see that your mother is focused on your face, you slip your other hand and take one of the tentacles around her. When she feels that, it’s too late as you plunge it inside her pussy. She lets out a moan of pleasure, her grip over your cock softened a bit, leaving you some breathing room.\n\nAfter that, you lunge at her and kiss her deeply, trying to force a middle ground. Her saliva tastes sweet as her tongue wraps around yours as if it were your cock, probably from all that training that he has been doing in the last times you’ve seen her. Suddenly that becomes a challenge, as you ram her pussy with her tentacle while she keeps engulfing your cock with her gooey arm. Both of you are sweating as the ripples of pleasure wave one after another as both of you feel close to cumming, especially from the look on her face. The challenge finally ends when she screams in ecstasy, her own orgasm hitting her like a thunder, as her arms spasms and convulses around your prick, as her own tentacle fills her with her own goo. When you see that you won, you finally let yourself to cum, your spunk flying in front of you and into the floor.\n\nShe liquefies after that, as she moves into the puddle of your juices, slowly absorbing them. You start dressing once more as you leave her to her instinctive behavior.";


			} else if (GameControl.hasVagina) {
				Board.text += "Without further warning, she starts rubbing your cunt you with one of her elastic hands until you’re as wet as you can get. When you think that she is planning on giving you a fingerjob, she start impaling her gooey hand against your pussy, forcing her slime hand inside you as you can feel how it turns into a gooey dildo inside you. The tightness and the way her arm rubs against your inner walls is unbelievable, the pleasure is hard to bear without succumbing to the sweet release of your orgasm. You can see a mischievous smile on her face as she knows that it isn’t that far before you cum, but you wouldn’t go down without a fight. As you can see that your mother is focused on your face, you slip your other hand and take one of the tentacles around her. When she feels that, it’s too late as you plunge it inside her pussy. She lets out a moan of pleasure, her push against your twat softened a bit, leaving you some breathing room.\n\nAfter that, you lunge at her and kiss her deeply, trying to force a middle ground. Her saliva tastes sweet as her tongue wraps around yours as if it were your clit, probably from all that training that he has been doing in the last times you’ve seen her. Suddenly that becomes a challenge, as you ram her pussy with her tentacle while she keeps teasing your nether lips with her gooey arm. Both of you are sweating as the ripples of pleasure wave one after another as both of you feel close to cumming, especially from the look on her face. The challenge finally ends when she screams in ecstasy, her own orgasm hitting her like a thunder, as her arms spasms and convulses inside your cunt, as her own tentacle fills her with her own goo. When you see that you won, you finally let yourself to cum, your femspunk dripping below you and into the floor.\n\nShe liquefies after that, as she moves into the puddle of your juices, slowly absorbing them. You start dressing once more as you leave her to her instinctive behavior.";



			} else {
				Board.text += "No scenes for eunuch yet.";

			}
		} else {
			Board.text = "You’ve been reading the laws and past mandates, to know more about what your father did in the golden era of the city. You strive to do the same or even better, but it’s not an easy task. You are a bit frustrated, so you place the book down as you try to rest your head a bit by looking at your surroundings. As your eyes wander through the library, you can see someone lurking around the bookshelves of the place. At first glance you couldn’t discern its features but after a bit you recognized it as your mother, Lucina.\n\nYou can see that your mother is walking with one of your slime-daughters at her side. When your mother sees you, she talks with your daughter and tells her something before sending her to the door. <i>“You’re just like your father, "+ GameControl.playerName +". He was always getting prepared for the day-to-day of guiding a city.”</i> You nod at her but you explain that its hard to understand still. She claps her hands once. <i>”Don’t worry, my child, I will help you with that. That’s why I’m here after all”</i>  .she says, as she moves strange, as if she is oozing but walking, and that somehow makes her walk faster. Doesn’t matter how many times you’ve seen it, it’s still strange to you. After a couple of minutes, she places some books on the table next to you. <i>”These ones should do the trick”</i> she says proudly as you thank her for her help, but she shakes her head. <i>”I’m not done helping you, my child,”</i> she says by smiling at you as she sits next to you.\n\nShe grabs one of your legs as her hand goes up until she caresses your groin. <i>”You need some relief, my child…”</i> You can see that she looks hornier than usual, perhaps you could use the rest. <i>”Let momma take care of you for a bit,”</i> she says as she rubs her rubbery hand against your crotch. She helps you with some eagerness  to remove your clothes. When she does, she doesn’t lose time and leans to you, as you know that she enjoys the contact with you since she became the creature she is today. \n\n\n";
			if (GameControl.dick1Size > 0/* && GameControl.charArmorTags[1] == false &&GameControl.charArmorTags[2] == false*/) {
				Board.text += "Without further warning, she starts stroking you with one of her elastic hands until you’re as hard as you can get. When you think that she is planning on giving you a handjob, she start impaling her gooey hand against your " + GameControl.mcDick1Name.toDescription () + " "+ GameControl.mcDick1Name.toDescription () + " prick, forcing it inside her slime arm. The tightness and the way her arm rubs against your prick is unbelievable, the pleasure is hard to bear without succumbing to the sweet release of your orgasm. You can see a mischievous smile on her face as she knows that it isn’t that far before you cum, but you wouldn’t go down without a fight. As you can see that your mother is focused on your face, you slip your other hand and take one of the tentacles around her. When she feels that, it’s too late as you plunge it inside her pussy. She lets out a moan of pleasure, her grip over your cock softened a bit, leaving you some breathing room.\n\nAfter that, you lunge at her and kiss her deeply, trying to force a middle ground. Her saliva tastes sweet as her tongue wraps around yours as if it were your cock, probably from all that training that he has been doing in the last times you’ve seen her. Suddenly that becomes a challenge, as you ram her pussy with her tentacle while she keeps engulfing your cock with her gooey arm. Both of you are sweating as the ripples of pleasure wave one after another as both of you feel close to cumming, especially from the look on her face. The challenge finally ends when she screams in ecstasy, her own orgasm hitting her like a thunder, as her arms spasms and convulses around your prick, as her own tentacle fills her with her own goo. When you see that you won, you finally let yourself to cum, your spunk flying in front of you and into the floor.\n\nAfter that, you dress up and take the books with you. As you open the door, you can see that the slime-daughter was peeping at your act. Your mother can’t help but smile and clap at her curiosity. She helps her to stand as you open the door wide for both of them. <i>”I don’t blame her. You’re quite the stud”</i> she says before leaving. As the daughter leaves before her, she gives you a small peck before waving you goodbye.";



			} else if (GameControl.hasVagina) {
				Board.text += "Without further warning, she starts rubbing your cunt you with one of her elastic hands until you’re as wet as you can get. When you think that she is planning on giving you a fingerjob, she start impaling her gooey hand against your pussy, forcing her slime hand inside you as you can feel how it turns into a gooey dildo inside you. The tightness and the way her arm rubs against your inner walls is unbelievable, the pleasure is hard to bear without succumbing to the sweet release of your orgasm. You can see a mischievous smile on her face as she knows that it isn’t that far before you cum, but you wouldn’t go down without a fight. As you can see that your mother is focused on your face, you slip your other hand and take one of the tentacles around her. When she feels that, it’s too late as you plunge it inside her pussy. She lets out a moan of pleasure, her push against your twat softened a bit, leaving you some breathing room.\n\nAfter that, you lunge at her and kiss her deeply, trying to force a middle ground. Her saliva tastes sweet as her tongue wraps around yours as if it were your clit, probably from all that training that he has been doing in the last times you’ve seen her. Suddenly that becomes a challenge, as you ram her pussy with her tentacle while she keeps teasing your nether lips with her gooey arm. Both of you are sweating as the ripples of pleasure wave one after another as both of you feel close to cumming, especially from the look on her face. The challenge finally ends when she screams in ecstasy, her own orgasm hitting her like a thunder, as her arms spasms and convulses inside your cunt, as her own tentacle fills her with her own goo. When you see that you won, you finally let yourself to cum, your femspunk dripping below you and into the floor.\n\nAfter that, you dress up and take the books with you. As you open the door, you can see that the slime-daughter was peeping at your act. Your mother can’t help but smile and clap at her curiosity. She helps her to stand as you open the door wide for both of them. <i>”I don’t blame her. You’re quite the stud”</i> she says before leaving. As the daughter leaves before her, she gives you a small peck before waving you goodbye.";



			} else {
				Board.text += "No scenes for eunuchs yet.";

			}

		}


	}


	void sexSlimeQueen4(){
		GameControl.actualArousal = 0;
		endTurnFun ();

		if (NPCCharList.CharFollower [iLucina].corruptionStage > 2) {

			if (GameControl.dick1Size > 0 && GameControl.charArmorTags[1] == false &&GameControl.charArmorTags[2] == false) {
				Board.text = "Since your mother became the creature that she is today, some things have changed in her bedroom. It has become more of a hive than a normal bedroom, but you didn’t mind as long as she is as servicing as ever. But it’s still strange to see one of the slime-drones sending you a message. <i>”Mother. Hive. Call.”</i>. You hope that the reason she is calling you, isn’t too taxing or takes too long, because you have some things to do on the day.\n\nAs you open the door to her “hive”, you can see that there are a couple more of those slime-drones, as they look like smaller versions of your mother Lucina. When they see you entering, they step aside and bow a bit, as you can see that your mother is in her bed, waiting for you. As you approach her, you can see that the place have some strange things on the walls that can fit a person inside, they seem to be used to transform people. As you place one knee in the bed, she flows closer to you and reaches your lips with her own, greeting you with a deep and passionate kiss. You break the kiss as you can feel how one of her tentacles start rubbing your groin. <i>”Your juices… I need them… To create more,”</i> she says as she rubs her own pussy with her tentacles, waiting for you to help her with her predicament.\n\n\nYou remove your clothes as you didn’t want to ruin them with the great amount of goo that is around the hive. She spreads her pussy to you as your "+ GameControl.mcDick1Name.toDescription () + " "+ GameControl.mcDick1Name.toDescription () +  " cock rubs against her entrance, teasing her ebony clit that is hard as a diamond as you soak your dick in her juices. As you enjoy the scent of her womanhood, you can hear a couple of moans behind you. As you turn around, you can see that the other slimes are fucking each other as other tentacles that came from the hive are screwing them too, ravishing all the holes they could find from them, as the sound of sex fills the entire room quickly.\n\nOne of your mother’s tentacles wraps around your cock as it tries to tease you to enter her, something that makes you return your attention to your mother. As you don’t want to make her wait further, you push your throbbing dick inside her needy cunt, her velvety interior teasing only like your only mother could know how to. The sensation of her inner walls is the best, nothing less you would expect from your new mother’s body. You start pounding her elastic ass continuously, enjoying her lustful moans as she plays with her own big breasts as her pussy massages your cock like an expert. Her legs circle your waist as she doesn’t want you to pull out. The warmth and the wetness of her insides is all you need, as you start cumming inside her pussy. You can feel how her inner walls milk you for all you’re worth. You can see your spunk filling her womb as her whole body spasms from her orgasm, her nether walls sucking your fluids until you’re completely limp. She embraces you and brings you close to her, pressing you against her chest. <i>“Love you… My child…”</i>. After that, she liquefies as she seems tired.\n\nAfter that, you try to take your clothings. It took a bit longer than expected, but you still have time to finish other things. But before you can do it, you feel a couple of small tentacles running across your naked body. As you turn back, you can see that the drones are interested in you and looks like that the want their part. It looks like that you can say goodbye to your duties for a couple of hours more.";

			} else if (GameControl.hasVagina) {

				Board.text = "Since your mother became the creature that she is today, some things have changed in her bedroom. It has become more of a hive than a normal bedroom, but you didn’t mind as long as she is as servicing as ever. But it’s still strange to see one of the slime-drones sending you a message. <i>”Mother. Hive. Call.”</i>. You hope that the reason she is calling you, isn’t too taxing or takes too long, because you have some things to do on the day.\n\nAs you open the door to her “hive”, you can see that there are a couple more of those slime-drones, as they look like smaller versions of your mother Lucina. When they see you entering, they step aside and bow a bit, as you can see that your mother is in her bed, waiting for you. As you approach her, you can see that the place have some strange things on the walls that can fit a person inside, they seem to be used to transform people. As you place one knee in the bed, she flows closer to you and reaches your lips with her own, greeting you with a deep and passionate kiss. You break the kiss as you can feel how one of her tentacles start rubbing your groin. <i>”Your juices… I need them… To create more,”</i> she says as she rubs her own pussy with her tentacles, waiting for you to help her with her predicament.\n\nYou remove your clothes as you didn’t want to ruin them with the great amount of goo that is around the hive. She spreads your pussy with one of her tentacles as it rubs against your entrance, teasing your clit as it soak itself in your juices. As you enjoy the contact of her appendage with your own cunt, you can hear a couple of moans behind you. As you turn around, you can see that the other slimes are fucking each other as other tentacles that came from the hive are screwing them too, ravishing all the holes they could find from them, as the sound of sex fills the entire room quickly.\n\nYour mother’s tentacle pushes itself against your pussy as it tries to tease its entrance, something that makes you return your attention to your mother. As you don’t want to make her wait further, you use one of your hands to push that thick tentacle inside your needy cunt, her velvety texture teasing your insides only like your only mother could know how to. The sensation of her tentacle rubbing against your inner walls is the best, nothing less you would expect from your new mother’s body.She starts pounding your "+ GameControl.mcAssName.toDescription () +" ass continuously,mixing your lustful moans with her own as she plays with her own big breasts while her appendage massages your sensitive spots like an expert. Her hands get a hold of your legs as she doesn’t want you to pull out. The savage pounding of her tentacle and the pressing against your sensitive flesh is all you need, as you start cumming over her tentacle. You can feel how your inner walls milk her tentacle for all its worth. You can see your  femspunk flowing through her tentacle and into her womb as her whole body spasms from her orgasm, her tentacle draining you of your pussy juice until its licked clean. She embraces you and brings you close to her, pressing you against her chest. <i>“Love you… My child…”</i>. After that, she liquefies as she seems tired.\n\nAfter that, you try to take your clothings. It took a bit longer than expected, but you still have time to finish other things. But before you can do it, you feel a couple of small tentacles running across your naked body. As you turn back, you can see that the drones are interested in you and looks like that the want their part. It looks like that you can say goodbye to your duties for a couple of hours more."; 
			} else {
				Board.text += "No scene for eunuchs or this armor yet";

			}
		} else {

			if (GameControl.dick1Size > 0 && GameControl.charArmorTags[1] == false &&GameControl.charArmorTags[2] == false) {
				Board.text = "Your Mother asked to see you in her room tonight for something special.  You head there coming up with things in your mind that could happen there. One way or another, you’re quite interested in what she should have in store for you.  Since she has taken control of the slime that tried to overcome her, it has been quite a ride with her and her new libido.\n\nYou open the door and walk in to a sight that you didn’t expect at first. All around the bedroom-hive of your mother, your slime daughters are fucking each other in different kind of ways. Licking each other pussies or rubbing them against one another, grinding incessantly as their moans echo through the entire room, sending you extra blood into your groin in no time. As you look around, you can see your mother at the end of the room, so you walk towards her, avoiding your daughters for a moment.\n\nWhen she sees that you’ve placed your eyes over your daughters, she smiles and points at the whole room with her hands. <i>\"I wanted you to see, my dear, that your daughters are all in love with you, almost as much as I am.  Thinking of you impregnating me made them grow impatient, so… they started things before you even arrived. I hope you don’t mind having company this time\"</i> Your mother says as she looks at someone behind you. As you turn, you see Selena, your oldest slime-daughter.\n\nSelena kisses you happily before continuing. <i>\"Mother has given me permission to join you today… Can I?\"</i> she says with a pleading tone. Not being able to resist your daughters pleading face or maybe it’s her lascivious body, you nod to her question. After that, your mother pushes you onto the bed and straddles over your waist.  <i>\"It is a great honor, daughter, the queen does not share her mate lightly.  Just remember that its juices are mine.\" </i>\n\n\nSelena hastily nods and kisses you as your mother rubs your "+ GameControl.mcDick1Name.toDescription () + " "+ GameControl.mcDick1Name.toDescription () + " cock on her shiny nether lips. She sits on your cock slowly, wanting the pleasure to be more enjoyable for both of you. You groan in pleasure and see that your daughter is soaking wet by looking at your cock thrusting inside your mother. Not wanting to leave her out of the fun for too much time, you make her sit on your face, her glistening cunt pressing against your face as you start licking it with delight, as you can see her body trembling from the pleasure, her back arching as her pleasure courses through her like a surge of lightning. As you do, you can’t see your mother but sure you can feel her twat wrapping itself around your cock like a glove.\n\nYour mother grabs Selena by the neck and kisses her own daughter, as she is enjoying your throbbing cock inside her oozy pussy. The sole sensation makes you thrust your hips against your mother’s ass, pounding it with raw force as you push a finger into Selena's pussy to as you can feel her reaching her orgasm as her moans are being muffled by your mother’s own mouth, as they are still enjoying each other’s mouths. She is still inexperienced, that’s because she couldn’t last longer before her body finally goes limp.\n\nShe pouts saying, <i>\"No fair, I didn't want to cum first. Not that soon at least.”</i> After hearing that, your mother gets a mischievous look and whispers something to her daughters ear as she is still rocking your cock back and forth. After that, you can see Selena smiling just like her, as she reach through her mother's slime stomach and grab your cock while it's still inside your mother. You are surprised as you can see her doing that, but your surprise is quickly replaced by lust as she starts to stroke it in time with your thrusts. Your daughter’s grip combined with the warm of your mother’s insides is too much for you to endure. Your vision fades out as you come hard into your mother's bowels, your cock painting her insides and your daughter’s hand white with your thick cream. As you fill her up, you mother moans in delight as she pinches her own breasts and cums hard all over your cock, drenching your legs in her juices.\n\nAs you are resting from the whole event, your mother says, <i>\"Don't worry my son, I will keep your cock safe and sucked. And I will help you protect the city, like always.\"</i> After hearing that, you nod as your mother's begins to rock once again on your cock.  You close your eyes and drift off into slumber satisfied.";


			} else if (GameControl.hasVagina) {
				Board.text = "Your Mother asked to see you in her room tonight for something special.  You head there coming up with things in your mind that could happen there. One way or another, you’re quite interested in what she should have in store for you.  Since she has taken control of the slime that tried to overcome her, it has been quite a ride with her and her new libido.\n\nYou open the door and walk in to a sight that you didn’t expect at first. All around the bedroom-hive of your mother, your slime daughters are fucking each other in different kind of ways. Licking each other pussies or rubbing them against one another, grinding incessantly as their moans echo through the entire room, sending you extra blood into your groin in no time. As you look around, you can see your mother at the end of the room, so you walk towards her, avoiding your daughters for a moment.\n\nWhen she sees that you’ve placed your eyes over your daughters, she smiles and points at the whole room with her hands. <i>\"I wanted you to see, my dear, that your daughters are all in love with you, almost as much as I am.  Thinking of impregnating you made them grow impatient, so… they started things before you even arrived. I hope you don’t mind having company this time\"</i> Your mother says as she looks at someone behind you. As you turn, you see Selena, your oldest slime-daughter.\n\nSelena kisses you happily before continuing. <i>\"Mother has given me permission to join you today… Can I?\"</i> she says with a pleading tone. Not being able to resist your daughters pleading face or maybe it’s her lascivious body, you nod to her question. After that, your mother pushes you onto the bed and straddles over your waist.  <i>\"It is a great honor, daughter, the queen does not share her mate lightly.  Just remember that its juices are mine.\" </i>\n\nSelena hastily nods and kisses you as your mother rubs your pussy as she takes out one of her tentacles, rubbing your cunt with it. She lets it inside your pussy slowly, wanting the pleasure to be more enjoyable for both of you. You groan in pleasure and see that your daughter is soaking wet by looking at your mother’s appendage thrusting inside you. Not wanting to leave her out of the fun for too much time, you make her sit on your face, her glistening cunt pressing against your face as you start licking it with delight, as you can see her body trembling from the pleasure, her back arching as her pleasure courses through her like a surge of lightning. As you do, you can’t see your mother but sure you can feel her tentacle rubbing itself inside your twat like a hand in a glove.\n\nYour mother grabs Selena by the neck and kisses her own daughter, as she is enjoying your wet pussy with her throbbing and flexible tentacle. The sole sensation makes you thrust your hips against your mother’s appendage, pounding it with raw force as you push a finger into Selena's pussy too, and you can feel her reaching her orgasm as her moans are being muffled by your mother’s own mouth, enjoying each other’s mouths. She is still inexperienced, that’s because she couldn’t last longer before her body finally goes limp.\n\nShe pouts saying, <i>\"No fair, I didn't want to cum first. Not that soon at least!”</i> After hearing that, your mother gets a mischievous look and whispers something to her daughters ear as she is still penetrating your excited pussy. After that, you can see Selena smiling just like her, as she reaches your cunt and grab your clit with her ooze fingers while your mother is still inside you. You are surprised as you can see her doing that in combination, but your surprise is quickly replaced by lust as she starts to penetrate you, sending you a lot of ripples of pleasure through your whole body, forcing you to arch your back on moments. Your daughter’s grip combined with the warmth of your mother’s tentacle is too much for you to endure. Your vision fades out as you come hard over your mother’s black appendage, your pussy soaking it in fluids, as you can see them flowing through her tentacle and into her lower belly. As you fill her up, you mother moans in delight as she pinches her own breasts and cums hard inside your cunt, filling it with her oozing juices. The sensation of being filled with your mother’s fluids is delightful.\n\nAs you are resting from the whole event, your mother says, <i>\"Don't worry my son, I will keep your cunt safe and sucked. And I will help you protect the city, like always.\"</i> After hearing that, you nod as your mother's begins to rock once again against your pussy. You close your eyes and drift off into slumber satisfied.";


			} else {
				Board.text += "no scene for eunuch or this armor yet.";

			}

		}


	}


	void sexSlimeQueen5(){
		GameControl.actualArousal = 0;
		endTurnFun ();

		if (NPCCharList.CharFollower [iLucina].corruptionStage > 2) {
			Board.text = "You’ve been hanging with your mother a lot since she finally accepted her true form, surrendering herself to the symbiote. But, despite the fact that she acts now more on her instincts and base lusts, you can see that there is a hint of care, as if she is holding herself back from using all her abilities.\n\nYou call for her to your bedroom one day, asking her why she is holding herself back, You thought that she was letting herself free. She looks at you with a bit of interest. <i>”You… sure? Can I… Feed?”</i> she looks at you quite interested, her slime body circling you slowly as you tell her that you’re curious of the whole capabilities. She licks her own lips as you can see that her nipples get hard just by hearing what you’re saying. <i>”I’ll feed. You like it or not…”</i> she says, just before her whole body dispersing a bit, just to cover you completely. It’s truly a surprising visage, as if she is made completely of black rubber, her whole body engulfs you, as you can feel her whole goo removing your clothes as your mother rubs your whole skin, as her head is next to yours.";
			if (GameControl.dick1Size > 0 && GameControl.charArmorTags[1] == false &&GameControl.charArmorTags[2] == false) {
				string line1 = "";
				string line2 = "";
				if (GameControl.testiclesSize > 0) {
					line1 = "as your balls are being fondled";
				}
				if (GameControl.hasVagina == true) {
					line2 = ", as you feel how she pushes herself teasing your pussy with her malleable goo";
				}

				Board.text += "You can see your naked body below the translucent parts of her rubbery body, as if she is making herself transparent for you to see what she is doing to you. You can feel how she strokes your " + GameControl.mcDick1Name.toDescription () + " "+ GameControl.mcDick1Name.toDescription () + " cock "+ line1 +" by using her slime body"+ line2 +". You can see how your cock gets hard in no time, as if it has a will on its own, but you can feel how your mother is using her whole rubber body, to stroke it and rub it, the feeling of her elastic body over your genitals is fantastic. As she does that, she start teasing your nipples, twisting and pinching them with force. <i>”So… sensitive,”</i> she says as you can even feel it teasing your anus, but without entering.\n\nYour whole body is being bombarded with that rubbing sensation, as if innumerable hands tease your whole body at the same time, sending ripples of pleasure as your cock is being stroked with force by your mother, as you can see how her lust-filled eyes are fixed on it, waiting for you to cum. And speaking of which, you can feel your own orgasm hitting you like a gale, your whole body trembling as you can see a stream of cum floating away from your penis, as it disappears into the gooey body of your mother. <i>”More… MORE!”</i> she says with a lecherous tone of voice, as you can feel her rubbing over your genitals getting more and more desperate. Your body is still sensitive from cumming already, but she gets you on the edge a second time. And without adding anything else, you cum once more, your fluids filling your mother’s latex body, as you can swear that she is getting a bit more energic. You try to move your body, but you can’t, as you feel trapped until your mother’s lusts are sated completely. But the pleasure is too much for you, as if she knew every sensitive spot in your body.\n\nAfter a while, you pass out. You wake up after that, not knowing how much time has passed. You turn to see your mother sleeping next to you, her whole body a shade of gray, probably from all the spunk that she consumed from you. For the first time in a while, you can see that she is sated, her face like an animal that is resting, her whole body is more voluptuous than before, probably from your fluids. Your head is about to explode, so you lift yourself up and go to drink something, before your mother thinks twice about her sate state.";


			} else if (GameControl.hasVagina) {

				Board.text += "You can see your naked body below the translucent parts of her rubbery body, as if she is making herself transparent for you to see what she is doing to you. You can feel how she pushes herself teasing your pussy with her malleable goo. You can see how your cunt gets wet in no time as it can be, but you can feel how your mother is using her whole rubber body, to tease it and rub it, the feeling of her elastic body over your genitals is fantastic. As she does that, she start teasing your nipples, twisting and pinching them with force. <i>”So… sensitive,”</i> she says as you can even feel it teasing your anus, but without entering.\n\nYour whole body is being bombarded with that rubbing sensation, as if innumerable hands tease your whole body at the same time, sending ripples of pleasure as your cunt is finally being ravaged by a dick made of your mother’s rubber slime, as you can see how her lust-filled eyes are fixed on it, waiting for you to cum. And speaking of which, you can feel your own orgasm hitting you like a gale, your whole body trembling as you can see a stream of vaginal juice floating away from your twat, as it disappears into the gooey body of your mother. <i>”More… MORE!”</i> she says with a lecherous tone of voice, as you can feel her rubbing over your genitals getting more and more desperate. Your body is still sensitive from cumming already, but she gets you on the edge a second time. And without adding anything else, you cum once more, your fluids filling your mother’s latex body while her body grows a bit, as you can swear that she is getting a bit more energic. You try to move your body, but you can’t, as you feel trapped until your mother’s lusts are sated completely. But the pleasure is too much for you, as if she knew every sensitive spot in your body.\n\nAfter a while, you pass out. You wake up after that, not knowing how much time has passed. You turn to see your mother sleeping next to you, her whole body a shade of gray, probably from all the spunk that she consumed from you. For the first time in a while, you can see that she is sated, her face like an animal that is resting, her whole body is more voluptuous than before, probably from your fluids. Your head is about to explode, so you lift yourself up and go to drink something, before your mother thinks twice about her sate state";


			} else {

				Board.text += "No scenes for eunuchs or this armor yet.";
			}
		} else {
			Board.text = "You’ve been hanging with your mother a lot since she finally accepted her true form, but taking control of the symbiote, steeling her will and keeping her rational side. And you’re quite happy to know that your mother is still there, you can’t help but wonder what it would be if she used the whole extent of her abilities on you. Not on the bad sense of the word, but curious of her new sexual capacities.\n\nYou go to her hive after calling for her to see you there, asking her why she is holding herself back, You as her if she thinks that she could be dangerous to you. She looks at you with a bit of interest and worry. <i>”I would love it, my child. But I worry that you could see me as just another monster…”</i> she looks at you a bit ashamed. You grab her face and kiss her, telling her that she is your mother despite everything, and that you will love her even if her body is of latex. She licks her own lips as you can see that her nipples get hard just by hearing what you’re saying. <i>”If you say so… I’ll be gentle, my child, I’ll swear”</i> she says, just before she liquifies herself as she covers your whole body with her own. Despite that looking a bit strange, you can feel her warmth and her scent so you don’t feel afraid of her, her whole body engulfs you, as you can feel her goo removing your clothes as your mother rubs your whole skin, as her head is next to yours.\n\n";
			if (GameControl.dick1Size > 0 && GameControl.charArmorTags[1] == false &&GameControl.charArmorTags[2] == false) {
				string line1 = "";
				string line2 = "";
				if (GameControl.testiclesSize > 0) {
					line1 = "as your balls are being fondled";
				}
				if (GameControl.hasVagina == true) {
					line2 = ", as you feel how she pushes herself teasing your pussy with her malleable goo";
				}
				Board.text += "You can see your naked body below the translucent parts of her rubbery body, as if she is making herself transparent for you to see what she is doing to you. You can feel how she strokes your " + GameControl.mcDick1Name.toDescription () + " "+ GameControl.mcDick1Name.toDescription () + " cock "+ line1 +" by using her slime body"+ line2 +". You can see how your cock gets hard in no time, as if it has a will on its own, but you can feel how your mother is using her whole rubber body, to stroke it and rub it, the feeling of her elastic body over your genitals is fantastic. As she does that, she kisses you passionately while teasing your nipples, twisting and pinching them with force. <i>”Thank you for not being scared of me, my child,”</i> she says as you can even feel it teasing your anus, but without entering.\n\nYour whole body is being bombarded with that rubbing sensation, as if innumerable hands tease your whole body at the same time, sending ripples of pleasure as your cock is being stroked with tenderness by your mother, as you can see how her lust-filled eyes are fixed on it, waiting for you to cum. And speaking of which, you can feel your own orgasm hitting you like a gale, your whole body trembling as you can see a stream of cum floating away from your penis, as it disappears into the gooey body of your mother. <i>”Oh, yes! Please, fill me with your juices! Mark me with your scent”</i> she says with a lecherous tone of voice, as you can feel her rubbing over your genitals getting more and more desperate. Your body is still sensitive from cumming already, but she gets you on the edge a second time. And without adding anything else, you cum once more, your fluids filling your mother’s latex body, as you can swear that she is getting a bit more energic. You try to move your body, but you can’t, as you feel trapped until your mother’s lusts are sated completely. But the pleasure is too much for you, as if she knew every sensitive spot in your body.\n\nAfter a while, you pass out. You wake up after that, not knowing how much time has passed. You turn to see your mother sleeping next to you, her whole body a shade of gray, probably from all the spunk that she consumed from you. For the first time in a while, you can see that she is sated, her face like an animal that is resting, her whole body is more voluptuous than before, probably from your fluids. Your head is about to explode, so you lift yourself up and go to drink something, before your mother thinks twice about her sate state.";


			} else if (GameControl.hasVagina) {

				Board.text += "You can see your naked body below the translucent parts of her rubbery body, as if she is making herself transparent for you to see what she is doing to you. You can feel how she pushes herself teasing your pussy with her malleable goo. You can see how your cunt gets wet in no time as it can be, but you can feel how your mother is using her whole rubber body, to tease it and rub it, the feeling of her elastic body over your genitals is fantastic. As she does that, she kisses you passionately while teasing your nipples, twisting and pinching them with force. <i>”Thank you for not being scared of me, my child,”</i> she says as you can even feel it teasing your anus, but without entering.\n\nYour whole body is being bombarded with that rubbing sensation, as if innumerable hands tease your whole body at the same time, sending ripples of pleasure as your cunt is finally being ravaged by a dick made of your mother’s rubber slime, as you can see how her lust-filled eyes are fixed on it, waiting for you to cum. And speaking of which, you can feel your own orgasm hitting you like a gale, your whole body trembling as you can see a stream of vaginal juice floating away from your twat, as it disappears into the gooey body of your mother. <i>”Oh, yes! Please, fill me with your juices! Mark me with your scent”</i> she says with a lecherous tone of voice, as you can feel her rubbing over your genitals getting more and more desperate. Your body is still sensitive from cumming already, but she gets you on the edge a second time. And without adding anything else, you cum once more, your fluids filling your mother’s latex body while her body grows a bit, as you can swear that she is getting a bit more energic. You try to move your body, but you can’t, as you feel trapped until your mother’s lusts are sated completely. But the pleasure is too much for you, as if she knew every sensitive spot in your body.\n\nAfter a while, you pass out. You wake up after that, not knowing how much time has passed. You turn to see your mother sleeping next to you, her whole body a shade of gray, probably from all the spunk that she consumed from you. For the first time in a while, you can see that she is sated, her face like an animal that is resting, her whole body is more voluptuous than before, probably from your fluids. Your head is about to explode, so you lift yourself up and go to drink something, before your mother thinks twice about her sate state";


			} else {

				Board.text += "No scenes for eunuchs or this armor yet.";
			}

		}


	}

	void sexSlimeQueen6(){
		GameControl.actualArousal = 0;
		endTurnFun ();

		if (NPCCharList.CharFollower [iLucina].corruptionStage > 2) {
			Board.text = "That day, you wanted to show your slime-daughters some love, so you asked your mother if he can see you on her hive later on that day. Your mother seemed excited when you explained to her that you wanted to spend some “quality time” with them. She nods at your request and answers only with a mischievous smile. You didn’t heard a word but you know that she will get them ready for the occasion.\n\nYou arrive at her hive and knock the door a couple of times, after that you can see that the door opens slowly. As you enter, you’re surprised of what you find. There were several of your slime-daughters that reached adulthood waiting for you, her bodies ripe for the taking. You can see that some of them have their breasts and hips increased, probably from absorbing more water. When they saw you arriving, they swarmed around you as you barely could close the door. From the bed, you can see that your mother is looking at you quite satisfied with the results of her preparations.\n\nSome of them hastily remove your clothes as they place it in a pile next to the group. As others press their delightful bodies against yours, her sensitive curves feeling wonderful as they grind them continuously against your body. You barely have any place of your body untouched, mostly your face. But you can feel your lust increasing as you can hear her moans being more evident as their touching and grinding continues. After that, you can see that your mother lifts from the bed and walks towards you, as she loses through the small crowd of people.	\n\n";
			if (GameControl.dick1Size > 0 && GameControl.charArmorTags[1] == false &&GameControl.charArmorTags[2] == false) {
				
				Board.text += "It wasn’t too long before they started stroking your "  + GameControl.mcDick1Name.toDescription () + " "+ GameControl.mcDick1Name.toDescription () +  " cock between a couple of them. One of them strokes the base as you can feel as other licked the tip of it. Another one press her breasts against your  chest, her nipples rock hard pressing against your skin as she bounces her soft breasts up and down as another one does the same behind you. Another one runs their latex hands across your "+  GameControl.mcHipsName.toDescription() +" hips, as your hands are trapped on two cunts, being forced to finger them as they soak them in their vaginal juices.\n\nAfter a couple of minutes of that sexual grinding coming from all parts, your cock is at the edge and you can’t hold it anymore. And when you finally feel the sweet wave of your orgasm, you can see that some of them move aside as you can see your mother kneeling in front of you, as your seed spurts from your pulsating cock and covers her face and ample breasts, as she looks quite pleasured from the results. After that, you can feel that your daughters start once more their grinding and sucking, as some of them kisses you passionately, moving your head from time to time just to change the recipient of such kisses. You know your mother’s skilled tongue, as she is cleaning your shaft from your own fluids. After that, she starts alternating from a handjob and into a blowjob and after another couple of minutes, you feel how you cum once more, as she gets a second serving of your jizz covering even more her face and her shoulders. This happens several times, as you can hear some of your daughters cumming from the fingerjobs you’re giving them.\n\nAfter several times of your orgasms, you feel that you have nothing more. You can see that your mother is completely drenched in your spunk, as she licks herself with her tongue as her skin starts absorbing your seed. <i>”So tasty…”</i> she says, just before you pass out from exhaustion. You can only hear the giggling of your daughters as they don’t stop rubbing themselves against you.";


			} else if (GameControl.hasVagina) {

				Board.text += "It wasn’t too long before they started rubbing your pussy between a couple of them. One of them rubs the inner walls as you can feel as other licked your clit. Another one press her breasts against your "+  GameControl.mcBreast1Name.toDescription() +" chest, her nipples rock hard pressing against your skin as she bounces her soft breasts up and down as another one does the same behind you. Another one runs their latex hands across your " +  GameControl.mcHipsName.toDescription() +" hips, as your hands are trapped on two cunts, being forced to finger them as they soak them in their vaginal juices.\n\nAfter a couple of minutes of that sexual grinding coming from all parts, your cunt is at the edge and you can’t hold it anymore. And when you finally feel the sweet wave of your orgasm, you can see that some of them move aside as you can see your mother kneeling in front of you, as your femspunk sprays from your pulsating cock and covers her face and ample breasts with your vaginal juice, as she looks quite pleasured from the results. After that, you can feel that your daughters start once more their grinding and licking, as some of them kisses you passionately, moving your head from time to time just to change the recipient of such kisses. You know your mother’s skilled tongue, as she is cleaning your shaft from your own fluids. After that, she starts alternating from a handjob and into a blowjob and after another couple of minutes, you feel how you cum once more, as she gets a second serving of your jizz covering even more her face and her shoulders. This happens several times, as you can hear some of your daughters cumming from the fingerjobs you’re giving them.\n\nAfter several times of your orgasms, you feel that you have nothing more. You can see that your mother is completely drenched in your spunk, as she licks herself with her tongue as her skin starts absorbing your seed. <i>”So tasty…”</i> she says, just before you pass out from exhaustion. You can only hear the giggling of your daughters as they don’t stop rubbing themselves against you.\n";


			} else {
				Board.text += "no scene for eunuch or this armor yet";

			}
		} else {
			Board.text = "That day, you wanted to show your slime-daughters some love, so you asked your mother if he can see you on her hive later on that day. Your mother seemed excited when you explained to her that you wanted to spend some “quality time” with them. <i>”Oh, don’t worry, my love. I’m going to make sure that they are ready to pass a day with their father”</i>. You nod interested at her choice of words.\n\nYou arrive at her hive and knock the door a couple of times, after that you can see that the door opens slowly. As you enter, you’re surprised of what you find. There were several of your slime-daughters that reached adulthood waiting for you, her bodies ripe for the taking. You can see that some of them have their breasts and hips increased, probably from absorbing more water. When they saw you arriving, they swarmed around you as you barely could close the door. From the bed, you can see that your mother is looking at you quite satisfied with the results of her preparations. <i>”They were waiting for you, "+ GameControl.playerName +"”</i>\n\nSome of them hastily remove your clothes as they place it in a pile next to the group. As others press their delightful bodies against yours, her sensitive curves feeling wonderful as they grind them continuously against your body. You barely have any place of your body untouched, mostly your face. But you can feel your lust increasing as you can hear her moans being more evident as their touching and grinding continues. After that, you can see that your mother lifts from the bed and walks towards you, as she loses through the small crowd of people.\n";
			if (GameControl.dick1Size > 0 && GameControl.charArmorTags[1] == false &&GameControl.charArmorTags[2] == false) {

				Board.text += "It wasn’t too long before they started stroking your " + GameControl.mcDick1Name.toDescription () + " "+ GameControl.mcDick1Name.toDescription () +  " cock between a couple of them. One of them strokes the base as you can feel as other licked the tip of it. Another one press her breasts against your chest, her nipples rock hard pressing against your skin as she bounces her soft breasts up and down as another one does the same behind you. Another one runs their latex hands across your [HIPS] hips, as your hands are trapped on two cunts, being forced to finger them as they soak them in their vaginal juices.\n\nAfter a couple of minutes of that sexual grinding coming from all parts, your cock is at the edge and you can’t hold it anymore. And when you finally feel the sweet wave of your orgasm, you can see that some of them move aside as you can see your mother kneeling in front of you, as your seed spurts from your pulsating cock and covers her face and ample breasts, as she looks quite pleasured from the results. After that, you can feel that your daughters start once more their grinding and sucking, as some of them kisses you passionately, moving your head from time to time just to change the recipient of such kisses. You know your mother’s skilled tongue, as she is cleaning your shaft from your own fluids. After that, she starts alternating from a handjob and into a blowjob and after another couple of minutes, you feel how you cum once more, as she gets a second serving of your jizz covering even more her face and her shoulders. This happens several times, as you can hear some of your daughters cumming from the fingerjobs you’re giving them.\n\nAfter several times of your orgasms, you feel that you have nothing more. You can see that your mother is completely drenched in your spunk, as she licks herself with her tongue as her skin starts absorbing your seed. <i>”So tasty…”</i> she says, just before you pass out from exhaustion. You can only hear the giggling of your daughters as they don’t stop rubbing themselves against you.\n";


			} else if (GameControl.hasVagina) {

				Board.text += "It wasn’t too long before they started rubbing your pussy between a couple of them. One of them rubs the inner walls as you can feel as other licked your clit . Another one press her breasts against your "+  GameControl.mcBreast1Name.toDescription () +" chest, her nipples rock hard pressing against your skin as she bounces her soft breasts up and down as another one does the same behind you. Another one runs their latex hands across your "+ GameControl.mcHipsName.toDescription() +" hips, as your hands are trapped on two cunts, being forced to finger them as they soak them in their vaginal juices.\n\nAfter a couple of minutes of that sexual grinding coming from all parts, your cunt is at the edge and you can’t hold it anymore. And when you finally feel the sweet wave of your orgasm, you can see that some of them move aside as you can see your mother kneeling in front of you, as your femspunk sprays from your pulsating cock and covers her face and ample breasts with your vaginal juice, as she looks quite pleasured from the results. After that, you can feel that your daughters start once more their grinding and licking, as some of them kisses you passionately, moving your head from time to time just to change the recipient of such kisses. You know your mother’s skilled tongue, as she is cleaning your shaft from your own fluids. After that, she starts alternating from a handjob and into a blowjob and after another couple of minutes, you feel how you cum once more, as she gets a second serving of your jizz covering even more her face and her shoulders. This happens several times, as you can hear some of your daughters cumming from the fingerjobs you’re giving them.\n\nAfter several times of your orgasms, you feel that you have nothing more. You can see that your mother is completely drenched in your spunk, as she licks herself with her tongue as her skin starts absorbing your seed. <i>”So tasty…”</i> she says, just before you pass out from exhaustion. You can only hear the giggling of your daughters as they don’t stop rubbing themselves against you.";


			} else {
				Board.text += "no scene for eunuch or this armor yet";

			}

		}


	}


	void sexSlimeQueenSTRUCTURE(){
		GameControl.actualArousal = 0;
		endTurnFun ();

		if (NPCCharList.CharFollower [iLucina].corruptionStage > 2) {
			if (GameControl.dick1Size > 0 && GameControl.charArmorTags[1] == false &&GameControl.charArmorTags[2] == false) {
				Board.text = "";
				Board.text += "";


			} else if (GameControl.hasVagina) {




			} else {


			}
		} else {
			if (GameControl.dick1Size > 0 && GameControl.charArmorTags[1] == false &&GameControl.charArmorTags[2] == false) {




			} else if (GameControl.hasVagina) {




			} else {


			}

		}


	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



	public void initialChoice(int intPick){

		if (intPick == 0) {
			Board.text = "Your mother is an attractive woman and the Plague has only emphasized that fact. You can’t help but remember the softness of her enormous breasts pressing against your chest, as if her rubbery nipples react to the touch of your skin. Her lusty silhouette seems to be comfortable by being so close to you. Her wide hips touching close to your groin. As you can see her ass moving provocatively as she starts leaving, you can even think that she is doing it instinctively without her noticing. Her lips calling for you, as she said that last phrase as the heels echoed a bit as she walks, probably created by that creature to make her more appealing… And it works perfectly.\n\n You’ve been away from her for quite some time, but you surely are attracted to her feminine characteristics just as any other women. The fact that she is family is even better, as no one should know you better instinctively than her. You wonder if the new skin she has, have some other special effects at the touch, and the sensations that perhaps has changed within her. And with that though, you feel yourself smiling, as you enjoy quite a view of her ass, as she finally leaves the place. You will make sure to give her a follow up in all the senses of the word, she is your mother after all, and a sexy one to say the least. \n\nYou realize that going with the priest will have to wait, this is an more urgent matter.";
		} else {
			Board.text = "You shake the thoughts off your mind. Surely this plague has shifted your scale of morality a bit, but you pass on that subject completely. You know that she is your mother, the one that raised you when you were a child, and that is final. You’ve lost her once, you don’t want to lose her twice for the weirdness of this new world. And with that, you see her leave the place, a tormented soul due to the creature that is trying to control her. And you plan on not letting her lose her mind to it.\n\nYou realize that going with the priest will have to wait, this is an more urgent matter.";
		}


		endTurnFun ();

	}




	void mcPronounSet(){
		if ( GameControl.mcGender == GameControl.MCGender.FEMALE) {
			mcpronLordLady = "Lady";
		} else {
			mcpronLordLady = "Lord";
		}

	}


	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		endTurnPanel.sortingOrder = 500;


	}


	public void noSelection(){
		panConfirmation.SetBool ("isDisplayed", false);

	}

	public void callConfirmation(int selector){

		panConfirmation.SetBool ("isDisplayed", true);
		conSelector = selector; 
	
	}



	public void enableSexScenes(){
		if (NPCControl.npc6000slimeQueen [3] == true) {
			sexScenes.sortingOrder = 500;
		} else {
			Board.text = "You need to either make her a slime queen or take full control of the symbiote (not implemented yet) before you can proceed.";
		}


	}


	public void yesSelection()
	{
		panConfirmation.SetBool ("isDisplayed", false);
		if (conSelector == 0) {
			NPCControl.npc6000CorruptPath = true;
	
		}

		if (conSelector == 1) {

			NPCControl.npc6000PurifyPath = true; 
	
		}

		if (conSelector == 2) {
			NPCControl.npc6000slimeQueen [4] = true;
			panSlimeQueen.sortingOrder = -500;
			slimeQueenIssue ();
			endTurnFun ();
			QuestControl.lucinaSlimeQueen = true; 

		}

		if (conSelector == 3) {
	
			//slimeQueenIssue ();
			Board.text =  "Not implemented yet!";
			QuestControl.lucinaSlimeQueen = false; 
		}



	}


	void loadLucina(){
		iLucina = 0;

		while (iLucina < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iLucina].charID == 6000){
				WorldControl.NPCID = NPCCharList.CharFollower [iLucina].charID;
				WorldControl.PortraitIDLayer0 = NPCCharList.CharFollower [iLucina].charPortraitLayer0;
				WorldControl.PortraitIDLayer1 = NPCCharList.CharFollower [iLucina].charPortraitLayer1;
				WorldControl.PortraitIDLayer2 = NPCCharList.CharFollower [iLucina].charPortraitLayer2;
				WorldControl.furryPic = NPCCharList.CharFollower [iLucina].isFurry;
				WorldControl.futaPic = NPCCharList.CharFollower [iLucina].isFuta;
				break; 
			}
			iLucina++;

		}

	}



	void increaseRelationshipLow(){


		NPCCharList.CharFollower [iLucina].charRelationship += 2;
		NPCCharList.CharFollower [iLucina].charLoyalty += 2;


		if(NPCCharList.CharFollower [iLucina].charRelationship > 100){
			NPCCharList.CharFollower [iLucina].charRelationship = 100;
		}

		if (NPCCharList.CharFollower [iLucina].charLoyalty > 100){
			NPCCharList.CharFollower [iLucina].charLoyalty = 100;
		}
	
	
	}

	void loadParser(){
		face = myParser.callCharFace ();
		arms = myParser.callCharArmsType ();
		legs = myParser.callCharLegsType ();
		race = myParser.callCharRace ();
		gender = myParser.callCharGender ();
		beard = myParser.callCharBeard ();
		physique = myParser.callCharPhysique ();
		build = myParser.callCharBuild ();
		eyesColor = myParser.callCharEyesColor ();
		hairColor = myParser.callCharHairColor ();
		dickRace = myParser.callDickType ();
		breasts = myParser.callBreastsName1 (); 
		dickSize = myParser.callDickName ();
		clothes = ItemData.itemDataList [GameControl.charEquipment [1]].itemName; 
		ballsSize = myParser.callTesticlesName ();
		assSize = myParser.callAss (); 

	}

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
	string dickRace; 
	string dickSize;
	string breasts;
	string clothes; 
	string ballsSize; 
	string assSize; 




	void Awake(){
		loadLucina ();


		lucinaStart ();


	}

}
