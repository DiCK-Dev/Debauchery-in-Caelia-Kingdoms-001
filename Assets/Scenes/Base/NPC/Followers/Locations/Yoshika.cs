using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Yoshika : MonoBehaviour {

	static int iYoshika = 0;  // used for char
	int x = 0; // used for whiles
	public Text Board; 
	static int confirmationSwitch;
	public Canvas endTurnPanel;
	public Canvas mainPanel;
	//public RectTransform panFinalCorruption; 
	//public RectTransform panPurifyQuestion; 
	//public Button buttDate;
	//public Button buttPurify;
	//public Button buttCorrupt; 
	public Button buttScene4; 
	public Button buttScene5; 

	public Button buttSceneSlave1; 
	public Button buttSceneSlave2; 

	public Text scene3title; 
	public Text scene4title; 
	public Text scene5title; 

	string mcpronoun = ""; 

	Parser myParser = new Parser(); 

	public Animator panConfirmation; 
	static int conSelector; // used to select the case 
	public Text panConfirmationTitle;



	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	/*
	public void confirmationFunction(int selectoption){
		///////// corruption
		if (selectoption == 0 && confirmationSwitch == 0) {
			NPCControl.npc5000CorruptionPath [4] = true; 
			yoshikaCorruption ();
		}
		if (selectoption == 1 && confirmationSwitch == 0) {
			panConfirmation.SetAsFirstSibling ();
		}
		///////// purification
		if (selectoption == 0 && confirmationSwitch == 1) {
			NPCControl.npc5000PurifyPath [4] = true; 
			yoshikaPurify ();
		}
		if (selectoption == 1 && confirmationSwitch == 1) {
			panConfirmation.SetAsFirstSibling ();
		}
		///////// Enslave
		if (selectoption == 0 && confirmationSwitch == 2) {
			NPCCharList.CharFollower[iYoshika].slaveStage = 1; 
			enslaveYoshika();
		}
		if (selectoption == 1 && confirmationSwitch == 2) {
			panConfirmation.SetAsFirstSibling ();
		}
		/////////
	
	
	}
	*/

	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


	public void talkYoshikaPast()
	{

		if (NPCControl.npc5000Talk [0, 0] == false) {
				Board.text = "You decide to ask him more about himself, as you barely know him right now. He nods and sighs as he rolls up his sleeves a bit as he motions you to follow him to a quieter place of the gym. You see that is somehow hard for him to start, so you give him time to recall.\n\nHe leans on a chair nearby and finally starts his story, while looking at the wall on the side of the gym, but you know that he isn’t looking at the wall itself, he is looking back at his memories. -My past?... Well, I do remember my family and the time I had with them. I come from a wealthy family of the city of Kujiang Daitoshi, the city that is closest from here on the road to the Citadel. My mother was quite nice to me and, don’t get me wrong, my father was nice to me too. But he was strict before anything else, because he had a lot of honor on his bones. He trained me since I was a young boy. He’s the descendant of brave warriors after all, his name was Doi. But my father didn’t lived with my mother and me, he always had to return to his training ground with my Master. I was too young at that time to follow them, so I had to improve my skills on my own and when my father had enough time to train me...-\n\nHe takes a sip of a steaming vase that was close to him, you can see him face twisted in a more serious stance. Perhaps this is something that requires a lot of concentration, or maybe something else is happening. -When I got old enough to train as it should be, and my mother taught me how to write and read properly, I enlisted with the militia. After that I...- You can see that he takes his head with one of his hands, visibly in pain. -I... - He clenches his teeth. \n\nAt that moment you told him to stop and let his mind rest a bit. He sighs and looks at you. -Yeah,  I need to think things a little bit more… Perhaps i’ll see you later- You see that he seems to be frustrated more than anything, perhaps his mind showed him something that he didn’t like at all. You know that his story doesn’t match with the past of the zone, but you wonder what truly happened with him. Good for you, you were already reading a book about the city, so you’ll have to read more about it later. And with that thing in mind, you leave the place.\n"; 
				NPCControl.npc5000Talk [0, 0] = true; 
				endTurnFun ();
				NPCCharList.CharFollower[iYoshika].charRelationship += 2;
				NPCCharList.CharFollower[iYoshika].charLoyalty += 2;

	
		}  else if (NPCControl.npc5000Talk [0, 1] == false) {
				Board.text = "After a bit of small talk, you decide that is time to resume the questions about his past. You can see him nodding at your petition as he guides you to the same part of the gym that both of you used last time. You see that this time, there were 2 cups of tea in a chair close to you, as he takes one of them and takes a sip. You take your own and taste the tea, which now is cold but he doesn’t seems to mind at all. -I’ve been remembering. It’s like I forgot large parts of my life and I don’t know why. Especially the last year, it’s so messy in my head, but well...-\n\nYou tell him that he should continue from where he left. Perhaps that could help him remember. -Yeah, I think that too. I told you that I joined the militia, right?- You nod. -Well, after that I trained day and night to be the best version of myself, just like my Master taught me. And with the lessons that my Master gave me from time to time, I quickly rise in the soldier’s ranks. My mother was so proud of me, even my father said that I was doing a great job. That sooner than later I would be worthy of his heritage. And coming from someone like my father, that was sure an accomplishment on my part- He sneers. -It was a good life. I had the chance to see the world on my own. It was truly a good way to steel my willpower. I fought and won my share of battles, even though they were skirmishes more than open combat. But they gave me what I needed most: Experience-\n\n-Then after that, everything gets hazy- He clenches his fist in frustration. He puts the glass in the chair and pounds the wall with the side of its fist. -The only thing that I can remember for sure, is that the Plague appeared. I do remember it, because I have in my mind the images of combat against them. Not sure when, not sure why, but i’m sure I fought with them. But with everything that happened on those dark years, i’m sure that almost every soldier had to fight with them at some point, so it doesn’t tell me that much of my past-\n\nYou ask him if there are other bits of memory he could have of his memory. -I can remember the times that I was alone. I can remember that many of the civilians fell to the Plague. There were a lot of turmoil in the city. I can’t remember what happened to my mother, but i’m sure that my father was fine. After all, I lived with him in the forest-\n\nYou ask him how both of you decided to live in the forest and be their protectors. He looks up, trying to remember. -Well… We... - He stops for a second. -He lived here in Aurorum- You tell him that is not possible, as you searched for the records on your manor for someone called Doi and nothing appeared. And that maybe the city was in a bad shape at the start due to the Plague, but you are sure that the ink can’t be Plagued and transform. He looks truly puzzled. -I… I can’t remember why we were on the cabin in the woods. But at least I can remember that’s where my father is buried, at least. But… why I can’t remember?- He sighs and looks at his hands, which were trembling. -And why I feel so angry just by trying to remember it?- He looks at you, as if he were waiting for you to give him the answer. \n\nYou sigh and tell him that you’ll try and find out in the archives of the city. But you tell him that you don’t promise anything. He nods as he takes a deep breath. -I know that it must be bothersome to help me solve this situation- So he looks through the window and cross his arms. -So… Thank you for helping me out- You pat his shoulder as you put your now empty cup next to his and thanks him for the drink, that you have some things to do and thank him for telling him this. He smiles and offers you to shake hands, so you accept the gesture and respond accordingly. You leave the troubled deer to his own meanderings as you leave the place.\n";
				NPCControl.npc5000Talk [0, 1] = true; 
				endTurnFun ();
				NPCCharList.CharFollower[iYoshika].charRelationship += 2;
				NPCCharList.CharFollower[iYoshika].charLoyalty += 2;

				
		}  else if (NPCControl.npc5000Talk [0, 2] == false) {
			Board.text = "You talk to the stag and ask him if he has been remembering things since the last time you see him. He nods, making the small antlers over his head bob a bit. You could swear that they are a bit shorter than usual, as if he just cut the tops of them. -Well, I got to remember some things, but it wasn’t easy.- He points with his head to outside the gym, as both of you go for a walk. He guides you to the skirts of town, to a place where you can see the road that leads to his home.\n\nHe keeps looking at the road, perhaps that is the place that sparked his memories. Maybe it's just some place that resonates with him. -I… I can remember some things with my father. How we fought together, and how we returned home together. But I can’t remember both of us arriving at the shack in the forest...- Then he turns to see you. -I think it's obvious that I got the Plague. It’s so easy to forget that these are over my head sometimes...- He pulls his antlers a bit except one that it chopped in half, just to get his point. -But I can’t remember how I contracted it-\n\nYou tell him that perhaps something bad happened when he got the Plague. Perhaps is the Plague that affected his mind and got him all messed up. -That’s horrible. Not being sure of what happened with my mind. It's like I have no past at all- You tell him that’s like a blank slate. He looks back into the forest and lowers his shoulders. -Perhaps you’re right. Whatever I wanted back is the same that I want now, because i’m the same person. So, i’ll keep training those people. Perhaps with time my memory will come back-\n\n-I got to ask you… How was YOUR past, "+ GameControl.playerName + "?- You look at him and explain him that you lived in the forest with a guardian, and how you inherited a title when you returned. -So… You DO lived in the forest. Well… that explain some things-  You shrug at his answer. -I don’t want to be the only one knowing that much of the other-\n\nAfter a minute or so, he turns back. -Time to go back. The gym isn’t going to take care of itself. You gave me the mission to run it, and that’s what i’m going to do now- He walks back with you and part ways when you arrive. -See you soon then-";	
			NPCControl.npc5000Talk [0, 2] = true; 
			NPCCharList.CharFollower[iYoshika].charRelationship += 2;
			NPCCharList.CharFollower[iYoshika].charLoyalty += 2;
			NPCCharList.CharFollower [iYoshika].charLove += 10;
				endTurnFun ();
			if (NPCCharList.CharFollower [iYoshika].charLove  == 20) {
				Board.text = Board.text + "\n\nYou have more information about him, now you can continue to corrupt/purify him. You feel in your own soul, that his soul is weak. You know that if you corrupt him too much, his soul will break and transform him into a submissive slave. (There will be a warning when the No-Return point is reached). You can corrupt him enough to make him a normal slave too, through proper training. All of this in the Path of Corruption.\n\nIn the Path of Purification, you can decide to take a lighter path and get into a deeper relationship with him through a series of dates. At the end, you can take the choice of purifying him, strengthening his soul.\n\nThere is also the issue with his memory. You can help him decide to take the decision of trying to recover his memories or live a new life away from them. You can investigate in his past and take the choice of helping him recover his own self, or build a new one from the ashes.";
				NPCCharList.CharFollower[iYoshika].isFriend = true; 
			}

		} else {
				Board.text = "Yoshika tells you that there is nothing else to know about her past";
				mainPanel.sortingOrder = 500;

		}


	}

	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	public void talkYoshikaForest()
	{


		if (NPCControl.npc5000Talk [1, 0] == false) {
				Board.text = "So, as you know that he was living in the forest, perhaps he knows better its current situation. He motions you with his hand to follow him just outside the gym. He looks at the edge of the city and places its hands over his own waist. -Well, the current state of the forest is unfavorable. I can’t remember since when, but i’m sure that the place is swarming with the Lost people. They group together by species, like truly animals. Most of the preys are being pushed out by the predators. And I know that all of that was happening due to the interference of the creature of the cave we fought-\n\nYou ask him a little bit more about that creature. It sure wasn’t something normal, even to the “Plague Lost people” standards. -I don’t know a lot about it. I just know that it was too hard to defeat, at least for me and my bow. But… It may sound silly, so i’m not sure if I should say it- You tell him that you saw in first row how the remains of a recently dead creature expunged some kind of dark ooze, that he can get him to believe in some strange things about that creature. -Well, my mother told me about how the gods can curse someone. And the ritual I made into those remains was something that my mother taught me, to search for atonement to the gods- He takes out a small silver amulet of his pants. -And somehow it worked. Perhaps it has to do with the like. Maybe it was cursed and needed someone to lift the curse. I thought something like that, but I wasn’t sure how to do it. It if wasn’t for you there, maybe I would be still fighting that thing from time to time. After all, I felt that I cannot leave the forest, until that thing was put down for good- You tell him that perhaps there are some things out there that are too mystical to be understood in mundane terms. -I’m sure of it. I’m just worried that my mother told me more stories of demons and evil creatures, than stories of heroes fighting against them- And with that, you thank him for his time and wave goodbye for now. \n\n"; 
				NPCControl.npc5000Talk [1, 0] = true; 
				endTurnFun ();
				NPCCharList.CharFollower[iYoshika].charRelationship += 2;
				NPCCharList.CharFollower[iYoshika].charLoyalty += 2;

		}   
		else if (NPCControl.npc5000Talk [1, 1] == false)
		{
				Board.text = "You were wondering about the last conversation about the forest, and you tell him that both of them were so focused on the event of that creature, that you forgot to ask him more things about the forest. As the strange rituals that happens in them, the ones that everyone seems to be talking about.  -Oh, so you found the “Fertility Goddess Cult”- He says as if you just asked him about an old store in the city. -They call themselves just like that. As its name implies, they are a group that somehow are tied to the old deities that were revered before the Citadel imposed the Valeriss belief into the Reigns. They make strange rituals in the woods and collect strange artifacts, but they aren’t inherently evil, that I can say. As I understand, they integrated the Plague into their beliefs and accept all the people that are interested in what they have to say-\n\nYou ask him their beliefs. -I think they are related to your own desires and will. I’m not too sure, i’ve been “busy” in their indoctrinations. But they don’t mind that i’ve been transformed by the Plague, and that’s a good start for those who are transformed. Probably that’s why many of them follow them to the forest. At least they don’t treat them any different from other people-\n\nYou ask him if there are other things that you should know. -Other than that, I don’t think so. There are slave caravans that hunt the Lost and takes them away from time to time. I don’t mind because one thing is to be infected with the Plague and your soul stay intact, and the other is being Lost and unable to do anything else than rut in shame-\n\nHe keeps explaining some mundane details about the terrain around the city, then you thank him for the help and leave the place.\n"; 

				NPCControl.npc5000Talk [1, 1] = true; 
				NPCControl.npc5000Relationship = NPCControl.npc5000Relationship + 5; 

				NPCCharList.CharFollower[iYoshika].charRelationship += 2;
				NPCCharList.CharFollower[iYoshika].charLoyalty += 2;
			NPCCharList.CharFollower [iYoshika].charLove += 5;
			endTurnFun ();
			if (NPCCharList.CharFollower [iYoshika].charLove  == 20) {
				Board.text = Board.text + "\n\nYou have more information about him, now you can continue to corrupt/purify him. You feel in your own soul, that his soul is weak. You know that if you corrupt him too much, his soul will break and transform him into a submissive slave. (There will be a warning when the No-Return point is reached). You can corrupt him enough to make him a normal slave too, through proper training. All of this in the Path of Corruption.\n\nIn the Path of Purification, you can decide to take a lighter path and get into a deeper relationship with him through a series of dates. At the end, you can take the choice of purifying him, strengthening his soul.\n\nThere is also the issue with his memory. You can help him decide to take the decision of trying to recover his memories or live a new life away from them. You can investigate in his past and take the choice of helping him recover his own self, or build a new one from the ashes.";
				NPCCharList.CharFollower[iYoshika].isFriend = true; 
			}

		} 
		else 
		{
				Board.text = "Yoshika ells you that there is nothing else to know about her past";
				mainPanel.sortingOrder = 500;

		}
				
	}


	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


	public void talkYoshikaHobbies()
	{



		if (NPCControl.npc5000Talk [2, 0] == false) {
				Board.text = "You tell him that you will wait him in the park, so he should come after he is done with whatever he is doing right now. -Of course. Why not?-. You bring two cups of coffee with you this time. It is a change for the taste of the tea he is always drinking and offering to you. After a while, you see him arrive in his long robes that he usually wears in his home in the forest, but his torso is uncovered, probably due to the dry sweat from the exercise.\n\n-What is it?- He asks you, to which you answer that you wanted to know a bit more about who he is. That you wanted to know him a bit more, as he seems to be someone nice. He is a bit surprised by your question, and even more by the cup of coffee that you brought him. -Thanks for the drink- He gives it a sip, raising its eyebrows. -Fantastic!-\n\nAfter that he leans in a banister that was close. -Well, thankfully I can remember those things perfectly. As you can figure, one of the most important hobbies for me since I was a child, is the archery. My dad insisted on that I must be trained to wield the traditional weapons of my family: The bow, the sword and the spear, and the style that my dad learned from its father and so on. I know how to use them, but my favorite one has been and is still the bow. I think that there is something on how the arrows cut the air as they fly that I love to hear. Haven’t thought it too much before- You see that he looks somewhat puzzled, as if this question is something hard for him to answer, but he doesn’t look angry, more akin to a person that truly don’t know the answer.\n\n-Well, when I was a child I took a liking for painting, but I never got the time to do it. I tried to do it at home but the paint is expensive and hard to come by. I like to paint, just as much as I like to look at the scenery. Dunno, perhaps I can do it here- He looks a bit nostalgic. Perhaps that is something that you can use later on, be it for his own good or maybe to your advantage.\n\n-I took a liking to the Colosseum. I get to see new ways of fighting from the people that train there, many of them I have never seen before. And they say the same about me, so is a mutual accord. It brings me back memories of old combats and practices. So, that’s there too. I think that’s all- He turns to see you. -Thanks for hearing out this stag with his messed up past. It's… different- He finishes his drink and returns to the gym to continue his work.\n";
				NPCControl.npc5000Talk [2, 0] = true; 
				endTurnFun ();
				NPCCharList.CharFollower[iYoshika].charRelationship += 2;
				NPCCharList.CharFollower[iYoshika].charLoyalty += 2;
				
		}  else if (NPCControl.npc5000Talk [2, 1] == false) {
				Board.text = "Now you know about him, but you wonder sometimes about now what are his plans for his future. Does he have a goal? You worry a bit, especially since his memories are messed up in some parts. You worry that he can’t remember what he was planning to do. And so, as you talk with him in the gym, you decide that is time to ask him about his aspirations.\n\n-Well… Do you always know how to throw me off balance, but this time i’ve been prepared, you see... At first I thought that I had nothing to aspire, more than continue fighting that creature on the forest. But, after taking my time to meditate on the matter, maybe my memory is twisted, but my soul it has been always the same. And I want to be an example to the others. I want to help the people that live in this city, to be the best version of themselves. That’s why I accepted your offer of helping in the gym, and that’s the reason i’ll continue in it. Maybe one day i’ll find a young pupil to pass on the style that my father taught me-\n\nYou see that for a moment, his gaze is resolute. The difference that taking a decision can make in a person is amazing. He smiles softly as he notices that you are looking at him. -Sorry. Got a bit carried away- He scratch his arm for a second. -You’ve been a guiding light through all of this. I’m sure that if i’ll keep myself around you, I know that i’ll improve one way or the other. And maybe find a way to repay you for all you have done for me. That is a good short-term aspiration. I know that I will think of something- You tell him that he is doing a lot helping him with the gym. \n\nHe clasps one of his hands, as he looks like is trembling with energy. -Well… If you think so. Then i’ll work even harder. I won’t let you down, " + mcpronoun + "- He stands slowly and jogs back into the gym, almost forgot to wave you goodbye  \n";
				NPCControl.npc5000Talk [2, 1] = true; 
				endTurnFun ();
				NPCCharList.CharFollower[iYoshika].charRelationship += 2;
				NPCCharList.CharFollower[iYoshika].charLoyalty += 2;
	
		}  else if (NPCControl.npc5000Talk [2, 2] == false) {
				Board.text = "You talk with him once more, as you feel how your friendship with him has been improving more and more. You could feel how your conversations with Yoshika have been more and more comfortable. You know that he trust you just a bit more than before, and as you are talking being accompanied by your respective meals, you decide to drop the question that wandered through your mind from time to time. What about his romantic life?\n\nThe question surely stops him on the stop, as he was about to take a bite of a loaf of bread but it made him lower it and turn to see you. -Being honest? No. I’ve had sex before and do it casually, but… There has been no spark in any of them- That answers the other question you had in mind at least, he is not a virgin. He looks at the floor as he finally gets to take a bite of the bread he is holding. You ask him about that “Spark” he is looking for. -You know. There must be some kind of spark between two people to be able to bind paths. As if their souls resonated between each other. But usually there is only flesh in the matter-\n\nYou tell him that he sounds more romantic that he usually seems to be. -What can I say?  not something that I have someone to talk about it. Or at least that was before you came along- You ask him if he considers you as a friend. -You are right. You’ve been nothing more than kind to me, helping me with something dangerous where others would have said it's none of their business. And that shows a big desire to help, or at least a desire to make things right- \n\nHe shakes his head. -Got derailed again. Where was i? Oh right. When I was a bit younger, I had a small group of admirers when I was in the militia. But I was too focused on training, that I had no time for them. That’s why I got the rank of Captain quickly. I do remember one of the soldiers assigned to my squad, used to trap the girls that were behind my back- He smiles, a little nostalgic of the memory, as you continue your meal while he returns to the present. After all, what you wanted is that he recovers his memories, and those moments you know that he is basking in them, even if it were for a moment.\n\n-You know, perhaps it's time for me to think in those things. I’m not obsessed with my training, at least not as much as when I was in the militia- He laughs a bit in a slow volume and pats you in the back. -Perhaps you can help me with that. With this wisdom of yours, you must be swarming with people around you, just trying to ignite a spark- You smile your own way and tell him that he has no idea.  -Thanks for sharing your wisdom with me, " + GameControl.playerName + ". It's good to talk to someone I can trust completely. Drop by anytime if you want to talk, no matter the reason- The deer says as you can feel an alluring tone in his voice, as both of you continue their usual conversation until is time for you to go. He hugs you and part on his way. You were a bit surprised of that, but take it as a good sign before leaving to do your own things.\n"; 
				NPCControl.npc5000Talk [2, 2] = true; 
				NPCCharList.CharFollower[iYoshika].charRelationship += 2;
				NPCCharList.CharFollower[iYoshika].charLoyalty += 2;
	
			NPCCharList.CharFollower [iYoshika].charLove += 5;
			endTurnFun ();
			if (NPCCharList.CharFollower [iYoshika].charLove  == 20) {
				Board.text = Board.text + "\n\nYou have more information about him, now you can continue to corrupt/purify him. You feel in your own soul, that his soul is weak. You know that if you corrupt him too much, his soul will break and transform him into a submissive slave. (There will be a warning when the No-Return point is reached). You can corrupt him enough to make him a normal slave too, through proper training. All of this in the Path of Corruption.\n\nIn the Path of Purification, you can decide to take a lighter path and get into a deeper relationship with him through a series of dates. At the end, you can take the choice of purifying him, strengthening his soul.\n\nThere is also the issue with his memory. You can help him decide to take the decision of trying to recover his memories or live a new life away from them. You can investigate in his past and take the choice of helping him recover his own self, or build a new one from the ashes.";
				NPCCharList.CharFollower[iYoshika].isFriend = true; 
			}

		} else {
				Board.text = "Yoshika tells you that there is nothing else to know about her past";
				mainPanel.sortingOrder = 500;
		
		}
			
	}


	/// <summary>
	/// Date
	/// </summary>
	public void dateYoshika(){



		if(NPCCharList.CharFollower [iYoshika].charLove <= 25 && NPCCharList.CharFollower [iYoshika].isSlave == false && NPCCharList.CharFollower [iYoshika].charLove >= 15 ){
			Board.text = "The last few days have been quite different from the usual flowing in your routine. Especially since you met with Yoshika. You have been taking your time to hear about his past, and the time to understand his current situation. He is such a nice guy, regardless of his past  And you have been growing fond of him, more than the fact that he is helping you with the gymnasium. The time has proven that he is loyal and trustworthy, maybe even more than you thought at first. And maybe he has no title right now, but for you, he is as noble as any other member of the aristocracy.\n\nOne of those days, you ask him if he has some time off on his week. He smiles a bit surprised but confirms you that he can take half the day off and appoint some time for you, you’re his boss after all, but he doesn’t want to overlook the business completely, especially since it has been thriving that much in the past weeks. You couldn’t help but smile for his diligence with work and wait for the appointed day, not without telling him to bring his bow and arrows to the appointment.\n\nYou choose a perfect place behind your manor, where both of you could have a little bit of privacy. There were a lot of space that is unused, with some trees at a good distance. Perfect for the plan that you thought Yoshika would be interested. The day you two accorded finally arrived, and the deer pays you the visit he promised, even earlier than you expected.\n\nYou invite him to pass to the garden, he is a little bit worried, you can see it on his face. You ask him what is wrong, to which he replies a little bit uncomfortable. <i>\"I did something wrong? If that’s the case, then i’m sorry\"</i> You place a hand over his shoulder and tell him that he is alright, it's just that you want to spend a little bit more time with him. That surely changed his face quickly to a one of surprise. -You want to spend time with me? That’s… wonderful. I dunno what to say- He says as he follows you to the garden, which was already prepared for your arrival.\n\nYou can see that your servants were leaving as both of you arrived. You can see that the stag wasn’t expecting such details, as he smiles at the sight: There is a table in the place, covered in different dishes that are already served for eating. And yes, you brought the tea that he is always drinking. You can see that your visitor is speechless, as he waits for you to sit first, before sitting on a chair next to you and leaving his bow behind him. He looks at you and then looks at the food, trying to tell you without saying a word, if he is allowed to eat. You find that way of being of him, charming in his own way.\n\nHe starts eating with voracity, but without being impolite. You can see that he starts eating the fruits first, then the meat and the bread. You know that he doesn’t mind doing it, as he is doing exercise daily and perhaps requires the energy more than you think. You get to eat as always, until you see him finishing his meal long before you. -...Sorry, got used to eat like this in the militia- You tell him that you don’t mind, sure it looks like he needed that. -Yeah. It's hard to get good meals when a good amount of the money goes to the gym- \n\nYou raise an eyebrow and ask him what he means. -Well, sometimes a piece of equipment fails or something else comes up. So, I don’t want to disturb you or your assistants, so I take part of my money to get them repaired. It’s not that much...- You see how he evades your eyes, but you sigh and tell him that he should tell you about those things, It's your duty as the one in charge that the place is well funded. -But you’ve been so nice to me. I want to help you in any way i can- You tell him that you want him to tell you about those things, even if it requires more meetings in person.\n\nHe smiles and nods several times. -I will do that then, my " + mcpronoun + "- You know that he doesn’t do it with bad intentions, but it's his money and he earns it every day with the sweat of his muscles, literally. After that, you can see that he doesn’t know how to continue the conversation. You tell him to grab his bow and follow you, to which he does. After a couple of seconds of walking, you tell him that you remember how much he likes his bow and that is why you thought of this.\n\nIn front of both of you, there are a couple of fruits placed in stands that are far away from you. You even took the trouble of asking your servants to make a small drawing of what you think is a Lost in a plank of wood, they even drew their genitals probably for realism. The deer shrinks in place and looks at you. -Do you want me to… shoot at those targets?- You nod at him. -But… I don’t think i’ll be able to do it, especially since my teacher is gone...- He looks at the fruits with worry in his eyes.\n\nYou place a hand over his shoulder and tell him that you trust him. You saw him do it when you meet, you’re sure that he’ll be able to do it again. -I-I’ll be honest. That was the first time I did it on my own… I never did it without someone else telling me to do it. But… when i saw you in danger, I knew that I had to do something. They would have raped you… or worse- You feel special then, looks like at least you are able to spark something inside the deer that he isn’t used to. Then you instruct him to think the same way of when he was looking at someone in danger, then shoot.\n\nHe grabs his bow and places the arrow in his hand, takes a deep breath and starts aiming at one of the fruits that was hanging from a small rope tied to a tree, far away from him. He exhales and fires the arrow. You heard the same sound from the first time you saw him, as you see that the pumpkin falls into the ground, as the arrow hits it and pulls the rope enough to make it fall. You can see the surprise in Yoshika’s eyes as he looks at you. -I did it again!- You say that you knew that he is quite capable with the bow. That he should never forget that.\n\nHe insists that you should try shooting the bow, to which you comply for this time. You take the bow and point at the wooden plank, aim for a second and shoot. The arrow flies fast and hits the monster, but you can see that the arrow hit it… just exactly in its freshly-painted genitals. Yoshika can’t help but laugh at the situation. -For me, that’s a killer shot- Both of you keep training until you see that it’s late. Yoshika knows it too, but promises to come back at any other time, if you want to. You say that you’ll be delighted to have him to visit again sometime. And with that saying, you wave goodbye to the deer’s silhouette as it disappears in the streets of the Aurorum.\n";
			endTurnFun (); 
			NPCCharList.CharFollower [iYoshika].charLove = 30;
			NPCCharList.CharFollower[iYoshika].charRelationship += 2;
			NPCCharList.CharFollower[iYoshika].charLoyalty += 2;


		}else if (NPCCharList.CharFollower [iYoshika].charLove <= 50 && NPCCharList.CharFollower [iYoshika].charLove >= 26 && NPCCharList.CharFollower [iYoshika].isSlave == false) {
				Board.text = "After a couple of times more of seeing the deer and enjoying some days of archery practicing, you thought of doing something special for Yoshika. Now you’re quite sure that you want to date him, you want to do something special for the gym attendant. After all, despite his insecurities, he is someone that is capable of great things, and now you want to give him the opportunity to create something else. You remember the pleasant conversations you’ve had with him and found out something that gives you another great idea. With this, you hope to see if he feels something for you too. Only time will tell, but you are planning on giving time a hand.\n\nYou ask the deer for another free day, and he asks if it’s going to be the usual appointment, or maybe something more... private. You instruct him that he doesn’t require his bow this time and the place will be a bit more public for the other plan he thought. You ask him to bring some fine clothing, but nothing too fancy. You can see that now he is confused by your requests, but accepts anyway. And so, the time passed until the day finally arrives.\n\nYou ask him to see you in the park, and you see that he arrived a bit late to the meeting. You can see that he is not wearing his usual large clothes. Now he is wearing a pair of formal pants and a long white shirt that presses against his muscles. Probably the best size he could find in time. You don’t mind at all, as looking at him doing those things is good enough for you.\n\nHe looks a bit flustered of you seeing him like that. -Sorry for being late. It's just that I forgot the last time i dressed like this. After all, this isn’t the ceremonial dressing for a Guardian Prince- You ask him if it bothers him. He shakes his head. -Not at all, it’s just that you… you know… nevermind- He looks around. -Where are we heading?- You tell him that it’s a surprise as you ask him to follow you through the streets of Aurorum.\n\nYou finally arrive at your destination, at which point Yoshika couldn’t believe his eyes: It is an Art Gallery. -Whoa! So many paintings!- He says, looking at the exhibitions that were outside the doors. You tell him that he hasn’t seen the tip of the whole place as you enter the building, being slowly followed by the stag, who is looking at the different paintings around and causing its neck some straining while doing so.\n\nYou show him the different styles of paintings, from landscapes to portraits. He takes a look to many of them, inspecting the details. You answer the questions that he could have about those paintings to the best of your ability, but you can see that its hunger for more knowledge of that kind of art, surpass your own. You look at the stag’s features as he looks entranced by a landscape of the forest that surrounds the city. He looks so happy that you can’t avoid to feel your spirits lifting a bit. After all, that kind of joy is rare and is a breath of fresh air in the middle of that Plague.\n\n-I know this place- He says in a high tone as he points out at one of the paintings. -I used to go to this place. At least...- You can see that for a second, his brightness dims for a second. -...until my father died.- He looks at the painting with nostalgia. You tell him that his father would be so proud of him if he could see him right now. -I really hope so...-.He looks at you from the corner of his eye. -I can take you there other time… if you like- He places his hands on his pockets. You raise an eyebrow but after a second you tell him that you would be pleased to get to know that place with him. He sighs in relief then smiles once more, that dimness fading as soon as it appeared. -That would be nice-\n\nBoth of you finally arrive to what seems to be a stand full of painting tools and an empty portrait being held in an easel. You see how Yoshika gets close to the painting, circle it but finds nothing. -I don’t understand this one. It’s something more modern?- You laugh at that remark and tell him that maybe the name of the painting can give him some clarification. He goes closer to the plate and reads it out loud. -Ode to an Unfinished Painting by… YOSHIKA? But that’s me!- He looks completely lost, in the lower case term. \n\nYou explain that you couldn’t resist it and that stand was your fault. You walk to the painting tools and places them in a bag, then hands it to him. You explain that you remember that he wanted to paint more, and that’s why you bought him enough paint and the tools needed for a painting. You thought that this was the perfect occasion to give them to him. So, you decided to pay for this stand and place all the tools in there, so it can be a surprise.\n\nOnce more, Yoshika was speechless. -You did all of this, just for me?- You affirm. He looks at the bag and hangs it to his shoulder. -...Thanks a lot. I...- He looks at you and takes a step on your direction, then proceeds to give you a hug without further warning, which last for many seconds. It was one of the first things that you saw him do without orders. You held him just like that for a while, enjoying his normal scent until he finally returns to his position. -Sorry, it's just...- You can see that his face is getting a bit red. -I think that i’m getting the wrong idea on my head. Just give me a minute- He picks all the painting stuff and walks out of the gallery.\n\nYou can see him outside the building, trying to regain his composure as he stares at a small brush from the bag you gave him. After that, it takes a deep breath as he looks at you arriving next to him. He thanks you for this gift, saying that he won’t let you down with his painting skills, or at least he will try not to. After that, he gives you a quick but strong goodbye hug and walks away quickly, obviously ashamed by everything that happened that day, but still happy. "; 
				endTurnFun (); 

				NPCCharList.CharFollower [iYoshika].charLove = 60;
				NPCCharList.CharFollower[iYoshika].charRelationship += 3;
				NPCCharList.CharFollower[iYoshika].charLoyalty += 3;
				
		}else if (NPCCharList.CharFollower [iYoshika].charLove <= 75 && NPCCharList.CharFollower [iYoshika].charLove >= 55 && NPCCharList.CharFollower [iYoshika].isSlave == false) {
				Board.text = "You make up your mind to take this a step further and ask that deer to be your partner. And so, you wanted to do it in the first place that you had a conversation with him: His shack in the Forest. So, you decided to go and pay him a visit, once he is already in his home. You know the road to his house like the back of your hand, as he has explained it to you several times. You found the square-shaped rock he talked about, the entwined trees, everything is in its place.\n\nAfter a while, you found the cabin where he sleeps. You can see the grave that is next to it, but for now your mind is on something else. So, you knock the wooden door and wait for someone to answer. -Is that you, "  + GameControl.playerName + "? I don’t think that a Lost one would knock with such calm. Come in, i’ll be with you in a second- You can hear from the inside, so you follow his reply and enter his home. You can see that the place has been cleansed recently, especially since the last time you set foot in there. You can see that the easel is close to the side and that the tools looks like they have been used a lot, which is a good thing. Maybe you can peek to see his work in progress.\n\nYou think that it won’t hurt anyone, you’re pretty sure that it must be a scenery, especially since that place has such good views of other parts of the Forest. So you take a peek at the painting, but what you see isn’t definitely what you expected at first. It is a portrait of you sitting in an expensive chair, carrying a pleasant smile. You don’t remember posing for him, so you only think that he made this only with his memory. It isn’t very well made, but yet it’s good enough for you. You decide to return to your seat, before Yoshika found you peeking on his masterpiece.\n\nAfter a minute, you can see that Yoshika appears from one of the back rooms, with a shirt hastily placed over his torso and his long robe still covering his legs. He places a plate with two cups filled with tea, as always. -I’m sorry, i was cleaning my other room a bit. I found out in one of the books that i found about painting techniques in the library, that an arranged place helps to arrange your mind- He sits in a chair that is close to you. -And to what do I owe this visit? Especially this late-\n\nYou knew the reason, but before anything you ask him how his work with the painting is going, now that you see the back of the easel in one of the corners of the living room. You can see that the deer quickly looks at the painting with a hint of fear. -The painting? Well...- He turns to see you, blushing obviously. -It’s doing… good. I’m definitely improving my technique- You ask him if you can view its progress. He raises both hands, alarmed but keeps himself silent, fighting to say something. After a couple of seconds, he sighs and lowers his shoulders a bit, somehow defeated. -...Of course you can-\n\nYou walk closer to the painting and look at your portrait one more time. You are about to tell how he caught your good side, but he explodes without warning. -I admit it! I’m sorry, but i’ve been looking at you for quite some time, "  + GameControl.playerName + ". I can’t help it. It’s just that… I can’t stop doing it. I’m sorry for being so vocal about this, and i know that you are a " + mcpronoun +", but i can’t stop this feeling i have- He lowers his shoulder line after he says that, you turn to see him and walk in his direction, as he continues his explanation. -You know my memory is a mess. And somehow i got worried that if i lost my memory of most of my recent life, i will lose the memory of you too. And you’re too important to me, and that’s why i want to have a portrait of you. So that i never forget you, because i lov....- You can see him shrinked in his chair, avoiding your eyes once more, probably waiting for you to scold him or shun his words. -I’m sorry for feeling like this. Just don’t go.-\n\nYou move next to him and take his face with one of your hands, turning it slowly so that he could see you in the eyes. You tell him that your plan isn’t leaving that place, until he hears you. You can see that you have his undivided attention, as you ran a hand across his cheek. You tell him that you came into his house, with the sole purpose of asking him one single thing. If he wanted to be your partner. -But i’m not enough… But i want...- You can see that his face was of total confusion, so you approached to his face while keeping your eyes over his own.\n\nYou can even feel on your hand that his face is getting warmer. You hover your lips over his own, trying to get his answer out of his lips, one way or the other. And when you thought that he would not answer to your call, you can feel how his face moves and his mouth matches yours, locking themselves in a passionate kiss. As you finally got your answer, you match his affection with the same strength. Your tongues entwine, as you can feel his desire for you with every lap of it. You feel his hands over your head, as you push against him and he pulls you closer, to the point that the chair falls back and both of you with it, but he didn’t stopped, not even a second.\n\nAfter a while, you finally stop that kiss, as you look around and see that the chair is broken, then ask him if he is okay. -Of course! I would love to!- He says out loud, looking at you. -Nothing else would make me happier, "  + GameControl.playerName + "- You touch his back but don’t feel any wetness, so you think that he isn’t bleeding at least. He sits and leans his back against the wall that is behind him as he hugs you properly like if you were the most precious thing he has in his whole house.\n\nYou lost the track of time, but when you realized, you see that it’s already morning. You see him resting peacefully holding you in his arms. After a bit, he wakes up and see the whole situation. -Oh, for Valeriss. It's late!- He helps you to get up. -You can’t be late! You’re the " + mcpronoun +" of Aurorum. You have a honor to hold!- He says, helping you clean your clothes. He stops and looks at you. -...My dear "  + GameControl.playerName + "- You smile at the words rolling out of his mouth, at which point he smiles too. You see him getting dressed real quickly, before both of you hurry to the city, parting ways when you arrive, not before the stag gets closer to you and gives you a quick goodbye kiss before parting ways.\n"; 
				endTurnFun (); 
				NPCCharList.CharFollower [iYoshika].charLove = 85; 
				NPCCharList.CharFollower[iYoshika].charRelationship += 5;
				NPCCharList.CharFollower[iYoshika].charLoyalty += 5;
			NPCCharList.CharFollower [iYoshika].isLover = true;

		}else if  ( NPCCharList.CharFollower [iYoshika].charLove < 100 && NPCCharList.CharFollower [iYoshika].charLove >= 80 && NPCCharList.CharFollower [iYoshika].isSlave == false)  {

			if(GameControl.charArmorTags [1] == true && GameControl.charArmorTags [2] == true){
					Board.text = "These things that you feel for Yoshika has only been growing stronger and stronger, and you are sure that the feeling is mutual, as you feel how the stag has been being more open to you in the last few encounters you have had with him in the last weeks. And you think that this has gone to the point of love, but you want to prove it to your loving stag the way it deserves.\n\nAnd you remember the place he said during one of your dates. It seemed important to him, and by extension it's important to you too. So, you decided to ask him if he could take you to that place. He looks reluctant at first, but after a pair of seconds, he says that he will see you at his home the next night. So, you took everything you would need in case of a Lost would lurk near them, so you decided to wear your " + ItemData.itemDataList [GameControl.charEquipment [0]].itemName + " on this occasion. You are a little early this time, so you wait for him outside the cabin he calls his home. It's hard to see during the night, and that is a good thing if you think about it. After a while, you see his silhouette moving swiftly through the bushes, until you see him finally. He is wearing formal clothing, something that you didn’t expect. -Sorry for making you wait, my dear. I had to think about some things. Like what i was planning to wear for tonight- After that, he gives you a greeting kiss and motions you to follow him.\n\nAfter a couple of minutes of pleasant walking, you finally arrive at the clearing. You can see that the more he approaches, the slower he moves. So you place yourself behind him and move him with you. You know that this place reminds him of his father’s death somehow, but you wanted to fix that tonight. So you walked with him to a comfortable place between the grass, next to a high wall that helps you stay hidden from the rest of the forest and patted the place next to you, to which he quickly followed by sitting next to you. -Can i speak about this place, my dear?- You tell him that he doesn’t require permission to speak about his mind, even though you know that he keeps asking for it every time.\n\nHe looks at the floor. -I feel like it has been ages since i’ve been here, let alone being here with someone else- Then he looks at the stars, which makes you do it too. -I can barely remember my father in the recent times, but i remember coming here with him from time to time. It’s a relaxing place, the strong wind takes most of the sounds away- You see that the view is beautiful, the painting couldn’t capture such beauty.\n\n-I can’t remember how much time has passed since he died. I can’t even remember when I buried him. I can only remember pieces of his actions. I felt lost without him, void of hope. I could only honor his memory by doing his sacred duty: Protect this Forest and everyone inside him as the Prince Guardian by fending off that vile creature from everyone. But i was too scared of doing it- Then he looks at you. -But then you came in. Without you, I would be probably still hiding in my cabin, alone and without purpose-\n\nYou tell him that you’re giving him too much credit. -Don’t you think that i don’t know that i’m weak-willed? I’m well aware of that, even without a real proof of it. But you still believe in me. And i think that’s the difference. You’re the first person i can remember -if that means something in my case- that believes that i can do it. And from that, i draw strength, even though i don’t know who i am truly- You tell him that he is still himself. That the Plague may have ruined his memories, but it has left his soul intact and that’s what matters.\n\n-I don’t know how you can keep that spirits up in this dark times. And maybe… that’s the reason i love you- You turn to see him quickly, and you see that his face is searing red. Once more, he avoids your gaze by looking at the ground in front of him. -You are truly my beacon of light. And I only want to love you as much as i can. But i don’t know if you feel the same about me. You are amazing after all. I’m pretty sure that you can catch bigger fishes, so...- You place a hand on his chest, to make him stop talking for a second.\n\nYou tell him that you love him too, and that’s why you wanted to go there with him during that night. Maybe he doesn’t have all his memories back, but they can start their own. And you want to start by changing a bad memory into a good one. And with that, you kiss the stag deeply, as you start to undress his formal clothing carefully, as unwrapping a fragile present. You feel how he understands your intentions and you can feel his tongue fighting back with passion. His skilled hands slowly undress you, enjoying the process of their lovemaking. Your intercouse lasted for an eternity, or at least that’s what you felt about it. You continued until both of you were exhausted, both of your bodies lying in the light of the moon and the stars.\n\n-I like this memory more than the other one...- He says, while both of you sit against the wall and enjoy the majestic view of the Forest at the distance. You know at that night, that the stag has now an important place in your heart, and you have one place in his.\n\nAfter that, you get dressed enough to move and return to the cabin of your lover. Your night was comforting and the day after was clearer for some reason. Your mind more focused after knowing that you have someone supporting you. And with that, you return to the city, your will reinvigorated.  \n";
					charVirginity();
				}else {
					Board.text = "These things that you feel for Yoshika has only been growing stronger and stronger, and you are sure that the feeling is mutual, as you feel how the stag has been being more open to you in the last few encounters you have had with him in the last weeks. And you think that this has gone to the point of love, but you want to prove it to your loving stag the way it deserves.\n\nAnd you remember the place he said during one of your dates. It seemed important to him, and by extension it's important to you too. So, you decided to ask him if he could take you to that place. He looks reluctant at first, but after a pair of seconds, he says that he will see you at his home the next night. So, you took everything you would need in case of a Lost would lurk near them, so you decided to wear your " + ItemData.itemDataList [GameControl.charEquipment [0]].itemName + " on this occasion. You are a little early this time, so you wait for him outside the cabin he calls his home. It's hard to see during the night, and that is a good thing if you think about it. After a while, you see his silhouette moving swiftly through the bushes, until you see him finally. He is wearing formal clothing, something that you didn’t expect. -Sorry for making you wait, my dear. I had to think about some things. Like what i was planning to wear for tonight- After that, he gives you a greeting kiss and motions you to follow him.\n\nAfter a couple of minutes of pleasant walking, you finally arrive at the clearing. You can see that the more he approaches, the slower he moves. So you place yourself behind him and move him with you. You know that this place reminds him of his father’s death somehow, but you wanted to fix that tonight. So you walked with him to a comfortable place between the grass, next to a high wall that helps you stay hidden from the rest of the forest and patted the place next to you, to which he quickly followed by sitting next to you. -Can i speak about this place, my dear?- You tell him that he doesn’t require permission to speak about his mind, even though you know that he keeps asking for it every time.\n\nHe looks at the floor. -I feel like it has been ages since i’ve been here, let alone being here with someone else- Then he looks at the stars, which makes you do it too. -I can barely remember my father in the recent times, but i remember coming here with him from time to time. It’s a relaxing place, the strong wind takes most of the sounds away- You see that the view is beautiful, the painting couldn’t capture such beauty.\n\n-I can’t remember how much time has passed since he died. I can’t even remember when I buried him. I can only remember pieces of his actions. I felt lost without him, void of hope. I could only honor his memory by doing his sacred duty: Protect this Forest and everyone inside him as the Prince Guardian by fending off that vile creature from everyone. But i was too scared of doing it- Then he looks at you. -But then you came in. Without you, I would be probably still hiding in my cabin, alone and without purpose-\n\nYou tell him that you’re giving him too much credit. -Don’t you think that i don’t know that i’m weak-willed? I’m well aware of that, even without a real proof of it. But you still believe in me. And i think that’s the difference. You’re the first person i can remember -if that means something in my case- that believes that i can do it. And from that, i draw strength, even though i don’t know who i am truly- You tell him that he is still himself. That the Plague may have ruined his memories, but it has left his soul intact and that’s what matters.\n\n-I don’t know how you can keep that spirits up in this dark times. And maybe… that’s the reason i love you- You turn to see him quickly, and you see that his face is searing red. Once more, he avoids your gaze by looking at the ground in front of him. -You are truly my beacon of light. And I only want to love you as much as i can. But i don’t know if you feel the same about me. You are amazing after all. I’m pretty sure that you can catch bigger fishes, so...- You place a hand on his chest, to make him stop talking for a second.\n\nYou tell him that you love him too, and that’s why you wanted to go there with him during that night. Maybe he doesn’t have all his memories back, but they can start their own. And you want to start by changing a bad memory into a good one. And with that, you kiss the stag deeply, as you start to undress his formal clothing carefully, as unwrapping a fragile present. You feel how he understands your intentions and you can feel his tongue fighting back with passion. His skilled hands slowly undress you, enjoying the process. But he doesn't go too far, knowing that you are, for now at least, chaste, so instead he uses his hands to pleasure you, touching your tender skin. You do the same to him and both of you continue to please each otheruntil both of you were exhausted,your bodies lying in the light of the moon and the stars.\n\n-I like this memory more than the other one...- He says, while both of you sit against the wall and enjoy the majestic view of the Forest at the distance. You know at that night, that the stag has now an important place in your heart, and you have one place in his.\n\nAfter that, you get dressed enough to move and return to the cabin of your lover. Your night was comforting and the day after was clearer for some reason. Your mind more focused after knowing that you have someone supporting you. And with that, you return to the city, your will reinvigorated.  \n";
				}
				endTurnFun (); 
			NPCCharList.CharFollower [iYoshika].charLove = 100; 
				NPCCharList.CharFollower[iYoshika].charRelationship += 5;
				NPCCharList.CharFollower[iYoshika].charLoyalty += 5;
	
				
		}else if (NPCCharList.CharFollower [iYoshika].isSlave == true) {
			Board.text = "Yoshika has been enslaved and cannot be dated anymore.";

		} else if ( NPCCharList.CharFollower [iYoshika].charLove >= 100){
			Board.text = "Both of you are already in love, no more dates available.";


		} else{ 
			Board.text = "You need to improve your relationship with him before dating, try talking with her.";
		}




	}


	/// <summary>	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	/// purify
	/// </summary>

	public void purifyQuestion(){
		if (NPCCharList.CharFollower[iYoshika].corruptionStage == 4) {
			Board.text = "Yoshika is too corrupt to be purified now";
		} else if (NPCControl.npc5000CorruptionPath [4] == true) {
			Board.text = "You are already corrupting him!"; 
		} else {
			
			NPCControl.npc5000PurifyPath [4] = true; 
			//purify ();

		}

	}
	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	public void yoshikaPurify(){


		if(NPCCharList.CharFollower [iYoshika].charLove < 20){
			Board.text = "You need to know him more, try talking about his past and other issues first! Note: You need to finish the different conversations available in the talk menu."; 


		}else {
			
			if (NPCControl.npc5000PurifyPath [4] == false) {


				if (NPCCharList.CharFollower [iYoshika].corruptionStage == 4) {
					Board.text = "Yoshika is too corrupt to be purified!";
				} else if (NPCControl.npc5000PurifyPath [4] == true) {
					Board.text = "You are already corrupting him!"; 
				} else if (NPCCharList.CharFollower [iYoshika].corruptionStage == 0) {
					Board.text = "Yoshika is as pure as he can be!";
				}
				else 
				{ 

					panConfirmationTitle.text = "Do you want to purify Yoshika?";
					callConfirmation (1);


				}
					

			}else {



				if (NPCCharList.CharFollower[iYoshika].corruptionStage == 1) 
				{
					endTurnFun ();

						if (NPCControl.npc5000PurifyPath  [0] == false) {
							Board.text = "You know that Yoshika is dealing very well with his present, but you know that he won’t be completely pure until he exorcises his inner demons completely. So, you start devising a plan to help him deal with them, without being something overwhelming.";
							NPCControl.npc5000PurifyPath  [0] = true; 
							NPCCharList.CharFollower[iYoshika].charRelationship += 1;
							NPCCharList.CharFollower[iYoshika].charLoyalty += 2;

							
						} else if (NPCControl.npc5000PurifyPath  [1] == false) {
							Board.text = "You’ve been searching for information about Yoshika’s past, and found out a piece of information that threw a new light into the deer’s condition. You verified this and confirmed it with several other people, and when you were sure that it wasn’t some kind of mistake, you called for Yoshika with a courier, telling him that you found some important information about his past. When the courier returned, you can see that the deer followed him back, panting from all the running he probably did.\n\nYou told him to sit down and relax, because this is something really big for him. You can see that his feet are trembling as his hands are clenched in a fist, waiting for your answer. You take out several sheets of paper. You explain him that you found a book from your late uncle that has information on the people that helped him to overthrow your father. You open the book and point at one specific name that was written on the list: “Yoshika”. The deer is surprised to see his name in some paper. You tell him that you thought that it could be someone else, but you started investigating with the old guard of the castle, and most of them said that the deer was so similar to one of the traitors that executed your father.\n\nHe was frozen by the remark. <i>”So, I am... a traitor?,”</i> he says utterly destroyed by that remark. You tell him that maybe the plague messed up with his memories, probably he ran into the forest out of guilt or maybe he got caught by the Lost or something. The deer stands up, his eyes full of anger. <i>“And that’s why I created this whole farce? Just so I could feel better than before?! Fuck! I’m so messed up,”</i> he punches the wall of the office. You tell him that he isn’t that man anymore, but he was pissed by his own actions. <i>”I’m sorry, my liege, but I can’t stand this,”</i> he says, before leaving the office without saying anything else. You think that he requires some time to digest this information, so you leave him be for now.\n";
							NPCControl.npc5000PurifyPath [1] = true; 
							
							NPCCharList.CharFollower[iYoshika].charRelationship += 1;
							NPCCharList.CharFollower[iYoshika].charLoyalty += 2;
							
						} else if (NPCControl.npc5000PurifyPath  [2] == false) {
							Board.text = "This time you go to the cabin of Yoshika, as you’ve heard from some of his staff that he has been hard to deal with in the last few days. Perhaps he requires some help to deal with his actual problem of dealing with his past. You arrive at the cabin and found out that the place is a chaos. Everything is a mess, broken things lying on the floor as you can see the trail of destruction leading into the room. Inside, you can see that Yoshika has been drinking and sleeping on the floor.\n\nYou call for him with a scream, telling him to stand up. You can see that he barely follows your command as he tries to held himself from one wall. You can’t help but help him to get into the shower, as you scrub his strong body to get him clean enough to go out. Usually you wouldn’t do this, but its something of utmost importance to you, and he won’t probably remember it. As he is ready, you can see that he is a bit recomposed. You tell him that if he wants to be forgiven, he needs to make amends to the city that he helped to get into this hole. <i>”...You’re right. I… I can’t wallow in my self pity forever. Especially when the alcohol I got tastes horrible. I don’t understand how they can gulp it every day,”</i> he says, trying to ease the tension in the air. <i>”I’ll start today. Maybe I can help the guard or somewhere else”</i>. You tell him that’s the spirit. And with that, you help him to get into the city and when you’re inside he thanks you with a kiss. <i>”Perhaps I can repay you later,”</i> he says, as he starts walking into the military district of the city. At least this is a step into the right direction.\n";
							NPCControl.npc5000PurifyPath  [2] = true; 
							
							NPCCharList.CharFollower[iYoshika].charRelationship += 1;
							NPCCharList.CharFollower[iYoshika].charLoyalty += 2;
							
						} else if (NPCControl.npc5000PurifyPath  [3] == false) {
							
							string PAR0 = "The next time you got a message from Yoshika, that if he can see you in the place where your father died. You’re surprised that he knew the place, but you went anyway as you got the Purification Elixir and wanted to give it to him. Maybe that is what he needs to finally be free of most of his burden. You arrive at the wall where the records say that it was, and you found him in there, kneeling and doing a small prayer. you wait for him to finish, before he stands up and looks at you. <i>”I’m sorry for my behavior from last time. I just needed something that could help me to take a bit off my shame,”</i> he says, before scratching his arm. You tell him that you have something to help him.\n\nBut before you can take out the Elixir, he stops you for a second. <i>”Hold on, "+ GameControl.playerName +",”</i> he says before taking a step into you, looking at you in the eye. <i>”Before anything, I want to say something first. You see, maybe I’m not the one that I thought I was, but I’m certain of one thing. I want to be with you, despite everything. And that’s why I wanted to show you my loyalty through any way necessary,”</i> he kneels after saying that. You tell him to stand up and follow you into your castle.\n\nYou arrive at your bedroom and show him the Elixir. You tell him that if he truly feels loyal to you, that he’ll drink it and if he is true to those feelings, then the elixir will work. He nods at your request and takes the bottle. He takes a deep sigh and drinks it in one gulp. after a couple of seconds, you can see him falling into the floor. You walk quickly with him and held his head as he wakes up once more. You can sense that he is finally clean of corruption at last. You kiss him passionately, as he holds you in his arms, a passion that you never expected from the deer, as he stands without breaking the kiss as he pushes you against the bed.";
							string PAR1 = "";
							string PAR2 = "";
							string PAR3 = "";
							string PAR4 = "";

							string PAR2L1 = "";

						if ( GameControl.hasVagina) {
								if(GameControl.dick1Size > 0){
									PAR2L1 = " and stroking your own " + dickSize +" shaft, feeling the precum dripping from it"; 
								}

								PAR1 = "Truly this Yoshika is different from the one you usually know. He removes your clothes with ease as he kisses all the way from your chest to your belly, until he is in front of your moist pussy. He licks it carefully, as the touch of his tongue feels especially right, as every time he laps your clit, your body trembles in delight as the pleasure crosses your body like a thunderbolt. You can feel his desire in your skin, as he tastes your juices with a strange lust, as if lusted for you to enjoy him, or at least that’s what he made you feel.";
								PAR2 = "After a bit of caressing of your cunt, he removes his clothes, exposing his thick cock to you. He places it against the entrance of your wet vagina, as he hovers a bit above you, his tongue searching yours until its entwined in a kiss full of love and passion. He pushes his cock inside you as he began panting between moans. His touch only made crave more of him, his dick rubbing your insides with a silk touch as his hand ran across your whole body, touching sensitive parts of your body, from your " + breasts +" breasts to your "+ assSize +" ass "+ PAR2L1 +".";
								PAR3 = "That sensation feels heavenly, the elixir definitely had an effect on the stag, at least for this special occasion. He wasn’t that rash, but he is taking the initiative right now. Perhaps this was him before the plague changed him? You can feel how he thrusts harder and harder, filling your body with pleasure, as you can’t help but moan from his ministrations.";
								PAR4 = "Before you can say anything else, he groans lustily as he finally reach his orgasm. Your insides began to get filled with his pure seed, as he keeps pounding your pussy as its spunk start pouring into the bed below you, but you didn’t care as you can feel being filled by the stag’s jizz is more than enough to send you into a potent orgasm. You can feel your whole body spasming as your twat tries to trap his cock until there is not a single drop of cum inside his balls, as you massage it into a blissful rest. When you finally feel that he is empty, you can feel how he falls next to you, completely spent. <i>”With this… I prove… My loyalty to you,”</i> he says, before falling asleep, completely spent. You decide to sleep with him in that situation, as he has earned it.";

						} else if (GameControl.dick1Size > 0  ) {

								PAR1 = "Truly this Yoshika is different from the one you usually know. He removes your clothes with ease as he kisses all the way from your chest to your belly. He uses one finger to tease your asshole carefully, as the touch of his wet finger feels especially right, as every time he crosses your anus crown, your body trembles in delight as the pleasure crosses your body like a thunderbolt. You can feel his desire in your skin, as he licks your chest with a strange lust, as if lusted for you to enjoy him, or at least that’s what he made you feel.";
								PAR2 = "After a bit of caressing of your pucker, he removes his clothes, exposing his thick cock to you. He places it against the entrance of your asshole, as he hovers a bit above you, his tongue searching yours until its entwined in a kiss full of love and passion. He pushes his cock inside you as he began panting between moans. His touch only made crave more of him, his dick rubbing your insides with a silk touch as his hand ran across your whole body, touching sensitive parts of your body, from your "+ breasts +" breasts to your "+ assSize +" ass and stroking your own " + dickSize +" shaft, feeling the precum dripping from it.";
								PAR3 = "That sensation feels heavenly, the elixir definitely had an effect on the stag, at least for this special occasion. He wasn’t that rash, but he is taking the initiative right now. Perhaps this was him before the plague changed him? You can feel how he thrusts harder and harder, filling your body with pleasure, as you can’t help but moan from his ministrations.";
								PAR4 = "Before you can say anything else, he groans lustily as he finally reach his orgasm. Your insides began to get filled with his pure seed, as he keeps pounding your asshole as its spunk start pouring into the bed below you, but you didn’t care as you can feel being filled by the stag’s jizz is more than enough to send you into a potent orgasm. You can feel your whole body spasming as your own cock unloads its content into your lover’s belly as your anus tries to trap his cock until there is not a single drop of cum inside his balls, as you massage it into a blissful rest. When you finally feel that he is empty, you can feel how he falls next to you, completely spent. <i>”With this… I prove… My loyalty to you,”</i> he says, before falling asleep, completely spent. You decide to sleep with him in that situation, as he has earned it.";

						} else {
								PAR1 = "Truly this Yoshika is different from the one you usually know. He removes your clothes with ease as he kisses all the way from your chest to your belly. He uses one finger to tease your asshole carefully, as the touch of his wet finger feels especially right, as every time he crosses your anus crown, your body trembles in delight as the pleasure crosses your body like a thunderbolt. You can feel his desire in your skin, as he licks your chest with a strange lust, as if lusted for you to enjoy him, or at least that’s what he made you feel.";
								PAR2 = "After a bit of caressing of your pucker, he removes his clothes, exposing his thick cock to you. He places it against the entrance of your asshole, as he hovers a bit above you, his tongue searching yours until its entwined in a kiss full of love and passion. He pushes his cock inside you as he began panting between moans. His touch only made crave more of him, his dick rubbing your insides with a silk touch as his hand ran across your whole body, touching sensitive parts of your body, from your "+ breasts +" breasts to your "+ assSize +" ass.";
								PAR3 = "That sensation feels heavenly, the elixir definitely had an effect on the stag, at least for this special occasion. He wasn’t that rash, but he is taking the initiative right now. Perhaps this was him before the plague changed him? You can feel how he thrusts harder and harder, filling your body with pleasure, as you can’t help but moan from his ministrations.";
								PAR4 = "Before you can say anything else, he groans lustily as he finally reach his orgasm. Your insides began to get filled with his pure seed, as he keeps pounding your asshole as its spunk start pouring into the bed below you, but you didn’t care as you can feel being filled by the stag’s jizz is more than enough to send you into a potent orgasm. You can feel your whole body spasming as your anus tries to trap his cock until there is not a single drop of cum inside his balls, as you massage it into a blissful rest. When you finally feel that he is empty, you can feel how he falls next to you, completely spent. <i>”With this… I prove… My loyalty to you,”</i> he says, before falling asleep, completely spent. You decide to sleep with him in that situation, as he has earned it.";

						}

							Board.text = PAR0 + PAR1 + PAR2 + PAR3 + PAR4;

							NPCCharList.CharFollower[iYoshika].charRelationship += 1;
							NPCCharList.CharFollower[iYoshika].charLoyalty += 2;
							NPCControl.npc5000PurifyPath [0] = false;
							NPCControl.npc5000PurifyPath [1] = false;
							NPCControl.npc5000PurifyPath [2] = false;
							NPCControl.npc5000PurifyPath [4] = false;
							NPCCharList.CharFollower[iYoshika].corruptionStage = 0; 
						NPCCharList.CharFollower [iYoshika].charCorruption = 0; 
							
					}

					

				}else if (NPCCharList.CharFollower[iYoshika].corruptionStage == 2 ) {
					endTurnFun ();

						if (NPCControl.npc5000PurifyPath  [0] == false) {
							Board.text = "You know that the deer is still half-way into his complete purification, but you know that his will is broken and he requires someone to help him to restore to its original greatness. So you start thinking of a plan to help him improve his situation.";
							NPCControl.npc5000PurifyPath  [0] = true; 
							
							NPCCharList.CharFollower[iYoshika].charRelationship += 1;
							NPCCharList.CharFollower[iYoshika].charLoyalty += 2;

							
						} else if (NPCControl.npc5000PurifyPath  [1] == false) {
							Board.text = "You call him to your office, the deer seems to be a bit worried around the place. He sits when he sees a chair available, as he waits for you to explain why you need him. So, you only wanted for him to know that even though both of you know that he has several memory problems, he has been fighting to break his way through them. That maybe perhaps he isn’t who he thinks he is because his mind is messed up, but he can be of true help to Aurorum.\n\nHis demeanor changes a bit as he hears you, perhaps a bit too slightly, but you can see that he was worried of being scolded by you. But when he see that you’re praising him, he looks a bit confused, but after that he relaxed his pose a bit. <i>”Thank you, my liege. I-I’ve been doing my best, even when sometimes isn’t enough. But if you say that I’ve done well, then I’ve done great,”</i> he says with a hint of confidente sparking inside his eyes. \n\nYou tell him that despite the start of your partnership, he has been loyal since the first day and for that you thank him. <i>”Thank you”</i> he nods solemnly, so you finally dismiss him. You can see that his posture changed just a bit, but you know that the seed of pride has been always there, it just requires a little help to grow a bit.";
							NPCControl.npc5000PurifyPath [1] = true; 
							
							NPCCharList.CharFollower[iYoshika].charRelationship += 1;
							NPCCharList.CharFollower[iYoshika].charLoyalty += 2;
							
						} else if (NPCControl.npc5000PurifyPath  [2] == false) {
							Board.text = "This time, you go to the gym where he resides. You can see him sitting in his office, a little bit tired. You arrive and sit in the chair in front of him, surprising him a lot. <i>”My liege! How can I help you today?”</i> he says with a haste, trying to accommodate the different papers that are on the desk. You tell him that you’ve seen him a bit more frustrated lately. <i>”I’m sorry, my liege. It’s just that… I feel that I’m not doing a change in the city, that’s all.”</i> he says with a sigh.\n\nYou tell him to stand up and follow him to the gym, something that he does. You point at a couple of persons that are sparring a bit at the end of the building. You tell them that if they arrived just like that at the gym. <i>”Well, no. They were quite scared of fighting,”</i> he says, as if it’s something basic but you tell him that they have improved since they’ve been assisting this place. And you go with every other person that is working at the moment. You can see that he knows the name and condition of almost everyone in the gym. You tell him that sometimes you don’t need to be a Liege to change the life of others. You can see that he is surprised by how many lives he has touched. <i>”Honestly I haven’t noticed it,”</i> he says, while turning to see you and bowing. <i>”Thank you, my liege”</i>. You tell him that it’s not big deal, that he should stick to that idea and keep himself as disciplined as possible.\n\nHe nods and you say goodbye before leaving the building to that deer, as you know that it’s in capable hands.\n";
							NPCControl.npc5000PurifyPath  [2] = true; 
							
							NPCCharList.CharFollower[iYoshika].charRelationship += 1;
							NPCCharList.CharFollower[iYoshika].charLoyalty += 2;
							
						} else if (NPCControl.npc5000PurifyPath  [3] == false) {
							
							string PAR0 = "This time, you have the Purification Elixir, but you wanted to make sure that it would work on the deer. So, this time you ask Yoshika if he can take one day off, to which he complies. You’re his boss, after all. So you get everything ready for the surprise. After you’re sure that the deer is outside the gym, you call for him to the gym once more, just to get some things ready for the next day.\n\nThe stag arrives at the building, as you were waiting for him outside of it. You open the door to the gym as you let the light enter through the windows. As the deer gets inside, he can see that there is a group of people waiting for him as they improvised a table. He is surprised and unable to speak due to it. You walk to him and explain that these people wanted to thank him for all what he did for them. <i>”Oh for Valeriss, it wasn’t necessary,”</i> he tried to excuse, but almost all of them pulled him into the table, which has a lot of different kinds of food, so you have an amazing meal with the patrons and Yoshika, as they talk from the different times that the stag helped him.\n\nWhen the meal was finished, some of them were already touching each other. You can see that the air around all of you is getting permeated more and more by the scent of sex and lust. You tell Yoshika that some of them wanted to thank you in a more physical way, the deer looks at you surprised as some of them started to undress him playfully between laughs. You remove your clothes because you don’t want to miss any of the fun.";
							string PAR1 = "";
							string PAR2 = "";
							string PAR3 = "";
							string PAR4 = "";

							string PAR1L1 = "";
							string PAR3L1 = "";

							 if (GameControl.dick1Size > 0 ) {
								if (GameControl.hasVagina == true) {
									PAR1L1 = " as your moist pussy is dripping with liquid desire";
									PAR3L1 = " as your cunt soaks his forehead and your own thighs";
								}
								PAR1 = "As you display your " + dickSize +" cock"+ PAR1L1 +", you can see that the deer is already being teased with the hands of several patrons that surely had the desire to touch his chiseled body. You can see that someone else is already touching his strong ass. You lay on the floor as the deer place himself over you, as you can feel his big cock on your face, the scent of his virility is so strong that is intoxicating to you. You can see that the deer is in the same situation with your own "+ dickRace +" dick, but he starts licking it as it’s already half-erect from all the moanings that surrounds you.";
								PAR2 = "You don’t waste any time and introduce his cock inside your mouth, as you can feel his ample cock-flesh pressing against your lips, stretching them as you use your tongue to wrap his cock as you tease him with your own warm mouth. You can feel how the deer does the same to your cock, his lapping being amazing, as you can feel the tip of your cock pushing against the roof of his mouth as he moans in delight at the taste of your precum. You can get a taste of him precum in your mouth, the taste being stronger than you thought, as he starts pressing his hips against your face, as you held his shaft with one hand as you stroke it, trying to win the race that both of you placed without word, trying to make him cum before you do. So both of you start sucking and licking each other's cocks as you can feel the pleasure of the skillful tongue of your antled opponent, as your mouth works to entice him to fill it with his warm seed. You can see that someone joins in the party, as it starts fucking the deer’s ass as you are working his cock. ";
								PAR3 = "After a couple of minutes, you can feel how your mouth is getting filled with the thick deer’s cream as he moans all over your cock while he cums. You can feel how he pours load after load of strong-scented cum inside your throat, almost forcing you to swallow it as you try not to drown in it. The feeling of being filled with his cum gets you to your orgasm, paying the favor in the same manner as him by filling his mouth with your hot spunk"+ PAR3L1+", while you can hear someone else’s moaning as he gets to fill his asshole with another creature’s sperm. The echo of moanings filled the place as everyone was being fucked or was fucking.\n";
								PAR4 = "The orgy continued for hours until all of you were spent. You woke up the next day, covered in fluids as Yoshika was already trying to clean the mess that all of you caused. You can see that his posture changed completely, as he seems to be more sure of himself. At that time, you offer him the Elixir and tell him that he earned it. <i>”Thank you, my liege. I’m sure that I’ll help you more if I’m pure, especially in this city,”</i> and with that, he drinks the elixir. You can see him falling into the floor slowly, asleep. And with that, you call for your workers to clean the place up and send back Yoshika to his cabin. And with that, you leave the place, satisfied of the results.";
							} else {
						
								PAR1 = "As you display your pussy, the deer is already being teased with the hands of several patrons that surely had the desire to touch his chiseled body since they placed their eyes on him. You can see that someone else is already touching his strong ass. You lay on the floor as the deer place himself over you, as his big cock is on your face, the scent of his virility is so strong that is intoxicating to you. You can see that the deer is in the same situation with your own cunt, but he starts licking it as it’s already wet from all the moanings that surrounds you.";
								PAR2 = "You don’t waste any time and introduce his cock inside your mouth, as you can feel his ample cock-flesh pressing against your lips, stretching them as you use your tongue to wrap his cock as you tease him with your own warm mouth. You can feel how the deer does the same to your cunt, his lapping being amazing, as you can feel your pussy lips pressing against his mouth as he moans in delight at the taste of your vaginal juices. You can get a taste of him precum in your mouth, the taste being stronger than you thought, while he starts pressing his hips against your face, as you held his shaft with one hand as you stroke it, trying to win the race that both of you placed without word, trying to make him cum before you do. So both of you start sucking and licking each other genitals as you can feel the pleasure of the skillful tongue of your antled opponent, as your mouth works to entice him to fill it with his warm seed. You can see that someone joins in the party, as it starts fucking the deer’s ass as you are working his cock. ";
								PAR3 = "After a couple of minutes, you can feel how your mouth is getting filled with the thick deer’s cream as he moans all over your cock while he cums. You can feel how he pours load after load of strong-scented cum inside your throat, almost forcing you to swallow it as you try not to drown in it. The feeling of being filled with his cum gets you to your orgasm, paying the favor in the same manner as him by soaking his face in your juices, as you can hear someone else’s moaning as he gets to fill his asshole with another creature’s sperm. The echo of moanings filled the place as everyone was being fucked or was fucking.";
								PAR4 = "The orgy continued for hours until all of you were spent. You woke up the next day, covered in fluids as Yoshika was already trying to clean the mess that all of you caused. You can see that his posture changed completely, as he seems to be more sure of himself. At that time, you offer him the Elixir and tell him that he earned it. <i>”Thank you, my liege. I’m sure that I’ll help you more if I’m pure, especially in this city,”</i> and with that, he drinks the elixir. You can see him falling into the floor slowly, asleep. And with that, you call for your workers to clean the place up and send back Yoshika to his cabin. And with that, you leave the place, satisfied of the results.\n";
							}
								
							Board.text = PAR0 + PAR1 + PAR2 + PAR3 + PAR4;


							NPCCharList.CharFollower[iYoshika].charRelationship += 1;
							NPCCharList.CharFollower[iYoshika].charLoyalty += 2;
							NPCControl.npc5000PurifyPath [0] = false;
							NPCControl.npc5000PurifyPath [1] = false;
							NPCControl.npc5000PurifyPath [2] = false;
							NPCControl.npc5000PurifyPath [4] = false;
							NPCCharList.CharFollower[iYoshika].corruptionStage = 1; 
						NPCCharList.CharFollower [iYoshika].charCorruption = 25; 
					
						}

					



				}else if (NPCCharList.CharFollower[iYoshika].corruptionStage == 3 ) 
				{ //////////////
					endTurnFun ();


						if (NPCControl.npc5000PurifyPath  [0] == false) {
							Board.text = "You can see that the corruption has get a hold of Yoshika’s soul. He is truly at the brink of losing himself to the Plague’s mind twisting effects. You won’t stand for him to fall into that way of living, so you think of a way to bring him back to sanity.\nYou know that the most urgent thing to correct is his submissiveness. You craft a plan to show him that there is more in the world than to follow other’s orders.";
							NPCControl.npc5000PurifyPath  [0] = true; 
							
							NPCCharList.CharFollower[iYoshika].charRelationship += 1;
							NPCCharList.CharFollower[iYoshika].charLoyalty += 2;

						} else if (NPCControl.npc5000PurifyPath  [1] == false) {
							Board.text = "You decide that the first step on this plan is to show him that he must see the things happening around him and that he must have his own opinion of things. So you decide to call for him to come to your Manor. You can see that when he sees you at the door of the Manor, he lower his head as he gets closer to you as he fidgets a bit in front of your manor, even though he has been here several times before.\n\nYou tell him to relax, to which he shakes his head. <i>”It's not my home, after all. I’m worried that i might broke something. My shoulders are hard to measure, being honest”</i> You motion him to follow you, until you are in one of the offices of your home. Inside, you can see that there is another person waiting patiently. You let them present themselves as you sit on the desk, and you can see that Yoshika is having a bit of a hard time doing so.\n\nYou explain to the stag that this time he will be under the orders of the Guard’s Chief.  You explain him that you want for him to learn the ropes of being a guard, in case that anything could happen in the building that you left for his care. You can see that the deer nods in approval as the guard look at him with a hint of skepticism, but the Guard’s Chief tells you that he will show him what he has to do with the problems that could arise where a lot of people usually gather.\n\nYou dismiss them as you say that there are things you must attend, so they leave your manor without further delay. You take your time to disguise yourself as another person and get to follow them closely, being careful of not drawing attention to you. You chose this guard carefully, because you know from other sources, that he is a despotic chief. At the start, everything goes smoothly but it isn’t that long before a roughhousing happens.\n\nYou can see how the Chief breaks it up the fight and then, when they are hurt and dizzy he attacks them from behind and start to beat them up on the floor with an iron rod. You can see that Yoshika is standing there, just looking how he keeps abusing his authority and with his unethical tactics. You can see how the deer’s trembles a bit from all that violence against others, especially the ones that can’t defend themselves anymore, even though they did something wrong.\n\nThe watch continues, and others instances of abuse were seen by Yoshika. When the duty is finally over, the Guard’s Chief instruct him to return to the Manor. You hurry back to your home before he arrives and change yourself back into your normal clothing. You can see that the deer is impacted by what he saw but he says anything. You ask him how the watch went. He looks at you with a worried look <i>“Good, I guess”</i> He says but you ask him if he saw something he didn’t liked, to which he looks at you, not knowing if he should answer that question.\n\nYou tell him that he hurt other people, like if you knew it from the start. He looks away, but you pat the ground with your feet, drawing his attention to you once more. You tell him that he must not think that what other do is right just because they have the power or the security to do so.  <i>“But you ordered me to follow him”</i> And you tell him that even the ones in power can be wrong sometimes, and sometimes it's up to the person in there to think about the act.\n\nHe looks at the ground for a while, then turns to see you. <i>“Y-You are right. I saw him being oppressive and i didn’t thought it was wrong. I have to think the things that the people do around me more carefully. I don’t want to condone bad things… I hope that i can do things right”</i> You are satisfied with his answer, so you go with him until the edge of the forest. He looks at you with half a smile before walking the road to his home in the forest. ";
							NPCControl.npc5000PurifyPath [1] = true; 
							
							NPCCharList.CharFollower[iYoshika].charRelationship += 1;
							NPCCharList.CharFollower[iYoshika].charLoyalty += 2;
							
						} else if (NPCControl.npc5000PurifyPath  [2] == false) {
							Board.text = "You think that it’s time for Yoshika to make the next step towards his purification. You know that he must be ready for the elixir to be effective. So, you’ll give him the opportunity to make things right. You call for him to go to your Manor on that day, that he must close early to attend his call.\n\nYou can see that he arrives early, just like he almost always does. He is wearing his ceremonial robes as he arrives. You can see that he enters the place a little bit more relaxed, but still careful of his surroundings. You greet him and instruct him to follow you to the main office. As he walks alongside you, you take your time to tell him that he must be strong for other people, something that puzzles him. As you invite him to enter, he can see what you prepared for him. There are a small group of guards in a circle around the room. In the middle of that circle, there is the Guard’s Chief that he meet earlier, with his hands tied and on his knees. You can see that the scene shocks him a lot.\n\nYou walk in front of the stag and point to one of the guards in the circle. The soldier takes one step forward, takes out a paper and starts to read it: -This guard has been accused by a group of citizens of several brutal beatings among other instances of abuse of power. He has been condemned to demotion of his position and restitution for his crimes to the society. You see that the Ex-chief looks up, finding Yoshika’s eyes and starts talking with desperation. <i>“You were with me! Tell them! Explain that it wasn’t me! They tried to attack me, they are the ones who deserve this punishment! Not me! TELL THEM!”</i> He shouts and looks at him enraged, something that makes the stag wince and shrink one second.\n\nYou explain to Yoshika that they only require his version of the story, as he was with him the whole patrol. It’s crucial in dealing with him. You can see that the eyes full of fury are drilling through the stag’s skull. He is trembling almost imperceptibly, but you place one of your hands on his shoulder and mention him that he should remember the last thing both of you spoke about this.\n\n He looks at you, then he looks back at the other guards. He takes a deep breath and shakes his head. <i>“It was him. I was there when he did those things. I should have stopped him, but now I… I have the opportunity to amend my error. He is guilty of those charges”</i> And with that you smile, giving the order to the other guards to send him to his punishment. The ex-chief screams and kicks as the other drag him out of the office. You tell him that he did the right thing, as he smiles back at you. <i>“At first i thought that i would help him escape”</i> You can see it in his eyes: He wasn’t believing what just happened. <i>“Thanks, " + GameControl.playerName +". Without your advice, i would be probably still lost in these kind of things”</i> You tell him that you give him too much credit, after all you only give him the chance to prove himself. The choice to sink him came out of his mouth.\n\nHe is more stable, you can see that the trembling has passed finally. After that, you can see that maybe it is the rush of the moment, but you see a more confident stag than the one that entered through the main door. He thanks you and says that he has a lot to think that night, and with that he departs from your side, to collect his thoughts on the streets of Aurorum.";
							NPCControl.npc5000PurifyPath  [2] = true; 
							
							NPCCharList.CharFollower[iYoshika].charRelationship += 1;
							NPCCharList.CharFollower[iYoshika].charLoyalty += 2;

						} else if (NPCControl.npc5000PurifyPath  [3] == false) {
							
							Board.text = "You decide that it's time for Yoshika to make the final test to see if he is ready to take the purification elixir. You have everything ready for this, so you call Yoshika to take a day off, and that he should use it to take a walk with him on the streets of the city. He says that he will be there and you make the appointment.\n\nYou double check the arrangements until the day arrives. Yoshika is early as always, wearing his usual ceremonial clothing and he follows you through the streets of the city. You show him some interesting places, as he seems to be interested in places to relax among other things.\n\nYou arrive into a big building, at that moment you turn to see him and instruct him with the most serious face that you can muster, that he should not move from that spot under any circumstance. He raises an eyebrow but nods at your weird instruction. After that, you enter the building and get outside through a door on the other side of where the stag is located.\n\nAfter a while, you can see that a couple gets inside an alley that is just in front of the place where Yoshika is waiting. After a minute or so, a female scream can be heard from the inside of the alley. You can see that the stag looks into that direction. After that, you can see that he is debating inside his head, because he looks the place where you ask him to stay or the origin of those screams. He clenches his fists for a second then takes a good look at the building where you are supposed to be, and then darts to the insides of the alley.\n\nYou follow his discreetly as you take a peek around the corner of the alley, finding the stag looking at a bad situation. There is a man that is half a tiger in aspect, groping what seems to be a woman in the end of the alley, both being barely lighted by the public lights of the other street. He is squeezing his breasts as his tongue is teasing her neck, as she tries to set herself free from his grasp. <i>“Let her go!”</i> You hear that the deer says out loud, as the tiger looks at him and laughs. <i>“Get out of here, before I decide that you’ll be a good knife sheath, fella.”</i> You can see that the fists of Yoshika are trembling. <i>“I won’t say it twice!”</i> The stag answers to him remark. The tiger frowns, as he throws the girl to the back of the alley and unsheathes a knife. You can see how the tension of the situation grows for the “hero”.\n\n<i>“You should have stayed out of this”</i> You can see that he lunges at him, but you know that this will go out well. The stag is ready to receive him with a punch on the wrist of his opponent forcing him to throw the edged weapon, then hits his face with his knee in a great display of flexibility, pushing him against one of the side walls of the back street. You can see that the tiger tries to bite him, but he hits him with his feet on his stomach.\n\nYou see how the woman gets up just in time to see how Yoshika dispatch the thug with a series of blows, finally forcing him into his knees. You see how the guards arrive just in time as you explain the situation to them. The guards recognize you immediately and follow your orders. You go to Yoshika, as he is helping the woman to stand up once more and help him return to the Manor.\n\nInside there, you tell him that you saw how he moved out of the place that you ordered him to stay. He turns to see you and sighs. <i>“I… This time I feel that I did the right thing, " + GameControl.playerName + ". You can punish me if you like, but I would do it again, if needed”</i> You tell him that you are surprised of hearing that about him. <i>“I may not be that skilled or strong, but that is not an excuse for not helping others, even when you gave me orders to not do it.”</i>\n\nYou take out of your pocket the purification elixir and tell him that he is truly ready for this. You tell him that this potion will help him recover his mind, but it may mess with his memories once more, but there is also the possibility that it could help him recover them, it wouldn’t be the first time it happens. He takes the potion and gives it a look. <i>“For my past… and my future”</i> He drinks it and falls into the floor, unconscious. After a bit, he recovers and looks at you and his surroundings. <i>“"+ GameControl.playerName + "? This is not the gym or my house… What am i doing here?”</i> You tell him that he fell exhausted after a stressful day, that he did a great job that day, that he earned some rest. <i>“Well… Thanks? But i gotta go back to my house. I’m tired…”</i> You help him to get on his feet, and you saw him walk slowly, his silhouette disappearing as it always do on the streets of Aurorum.";

							NPCCharList.CharFollower[iYoshika].charRelationship += 1;
							NPCCharList.CharFollower[iYoshika].charLoyalty += 2;
							NPCControl.npc5000PurifyPath [0] = false;
							NPCControl.npc5000PurifyPath [1] = false;
							NPCControl.npc5000PurifyPath [2] = false;
							NPCControl.npc5000PurifyPath [4] = false;
							NPCCharList.CharFollower[iYoshika].corruptionStage = 2; 
						NPCCharList.CharFollower [iYoshika].charCorruption = 50; 
						}

					


				}//////////////

			}
				

		}
	}//



	/// <summary>	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	/// corruption
	/// </summary>
	/// 


	public void yoshikaCorruption(){

		if (NPCControl.npc5000CorruptionPath [4] == false) 
		{

			if (NPCControl.npc5000PurifyPath [4] == true)
			{
				Board.text = "You are already purifying him!"; 
			} else if (NPCCharList.CharFollower[iYoshika].corruptionStage == 4 ){
				Board.text = "Yoshika is already totally corrupted!";

			}else if (NPCCharList.CharFollower[iYoshika].charLove < 20 ){
				Board.text = "You need to know him more, try talking about his past and other issues first! Note: You need to finish the different conversations available in the talk menu."; 


			}else
			{
				panConfirmationTitle.text = "Do you want to corrupt him?";
				callConfirmation (0);
			}

		}else if (NPCCharList.CharFollower[iYoshika].corruptionStage < 3 && NPCControl.npc5000CorruptionPath [4] == false){
				if (NPCControl.npc5000PurifyPath [4] == true) {
					Board.text = "You are already purifying him!"; 
				} else {
					Board.text = "Do you want to corrupt Yoshika?";
					//panConfirmation.SetAsLastSibling ();
					confirmationSwitch = 0;
				}

 
			}
			else 
			{


				if (NPCCharList.CharFollower[iYoshika].corruptionStage == 0 ) 
				{  //////////
					endTurnFun ();

						if (NPCControl.npc5000CorruptionPath [0] == false) {
							Board.text = "You want to return to Yoshika to his former self, a submissive and prideless version of himself. But you know that he has coped slowly with his past. You know that you must break his progress with his memories before turning him back into the path of corruption.";
							NPCControl.npc5000CorruptionPath [0] = true; 

						} else if (NPCControl.npc5000CorruptionPath [1] == false) {
							Board.text = "You call for Yoshika, as you start acting your part on your plan, faking the look of someone that hasn’t sleeping for days. As he arrives, you tell him to sit down as you want to talk seriously with him. He looks genuinely worried about your looks, so you continue. You tell him that you can’t sleep since you discovered that he was present when your father died. That is has been something hard for you to cope with the idea that someone as trustful as him, could participate in such heinous act. You can see a glint of shame in his eyes. <i>”I’m sorry for not doing anything to stop the execution, my Liege,”</i> he says as he bows his head.\n\nYou tell him that apologizing won’t bring your father to life, that he will live for the rest of his life with the memory that he helped to kill one of the most kind and hard-working lords in the history of the entire city, alongside a lot of loyal soldiers to him. He clenches his hands as he looks away. You tell him that you only wanted him to know the truth, that he at least has the right to know that. <i>”Thank you, my liege for your honesty, I… I need some time to deal with this,”</i> he sighs. You tell him that he is dismissed, as you can see him shocked by your words. You know that you planted the seed of pain into his subconscious.";
							NPCControl.npc5000CorruptionPath [1] = true; 

						} else if (NPCControl.npc5000CorruptionPath [2] == false) {
							Board.text = "This time you invite Yoshika to come to your castle, to which he accepts. After having a meal, both of you pass to the garden to sit and enjoy a couple of time together. You can see that he looks troubled, probably from the conversation you had last time. You ask him if something’s wrong. <i>”I’m sorry, my dear liege, but I’ve been having some trouble sleeping. The weight of my actions are heavy and take its toll,”</i> he says, as he sports a pair of eye bags below his eyes. \n\nYou tell him that if he wants to overcome that, that maybe perhaps he could return to his former fantasy. He looks at you a bit alarmed, but you can see in its eyes that he is thinking about it. You tell him that maybe he was a bit corrupted, but at least he had a lot of peace of mind. You tell him that at least that Yoshika was the one you trusted first and that maybe being him, he can recover your trust. <i>”It wasn’t so bad, you’re right in that. Perhaps maybe a bit of corruption will help me with this. And if you’re the one telling me this, then I owe you at least this,”</i> he says as he stands up and looks at you. <i>”But how I am supposed to do it. I can’t remember how I got pure,”</i> he scratches his head. You remember that the purification elixir erases his memories about it.\n\nYou tell him that you’ll deal about it, but for now, he should try and remember that fantasy. <i>”Being a Guardian Prince is something interesting after all...”</i> he says, as he stands up and leaves the place as you guide him into the street. You smile at the thought of returning to his former self is gaining momentum on his mind, and more importantly, his soul.\n";
							NPCControl.npc5000CorruptionPath [2] = true; 

						} else if (NPCControl.npc5000CorruptionPath [3] == false) {
							
							string PAR0 = "You finally got the Corruption Elixir, but you wanted to make sure that he is willing to take it at this stage, so you go to his house inside the Forest as you know that he is home. When you arrive, you can see that he is trying to act just in the way that he was when you found him, but he is having some problems to reach the same level that he had before. You wave at him as he invites you inside his house.\n\nWhen both of you are in, you tell him that you found a way to help him to return to his past state of mind. You show him the Corruption Elixir bottle, something that make the stag to move into his place, as his body remembers the foul liquid, as he salivates without even knowing why. You can see that the stag wants it but he needs the final push. You tell him that it’s the least he can do for you, as you knowing that he returned to his former self, you would have your trusted partner back. He looks down and nods, before turning its gaze back to you.\n\nYou tell him that this elixir has to be administered by… unusual means. As you slowly remove your clothes, telling him that he has to do the same. He nods and removes his clothes as quick as you.\n\n";
							string PAR1 = "";
							string PAR2 = "";
							string PAR3 = "";
							string PAR4 = "";

							string PAR2L1 = "";

				
							Board.text = PAR0 + PAR1 + PAR2 + PAR3 + PAR4; 
							if (GameControl.dick1Size > 0) {
								if (GameControl.hasVagina == true) {
									PAR2L1 = " as your cunt drips slowly your increasing lubricant into the floor below you.";
								} else {
									PAR2L1 = "";
								}
								PAR1 = "You proudfully display your "+ dickRace +" "+ dickSize +" cock as you pour the elixir on it, feeling the corrupting influence soak it, causing it to pulse with desire to plunge into the insides of the pure deer that is in front of you. You tell him to expose his pucker, as he leans into a wall, spreading his buttcheeks, presenting his tight anus to you.";
								PAR2 = "\n\nYou tease his muscular butt by pressing your " + dickSize +" cock against the crown of his asshole"+  PAR2L1+ ". The elixir serves as a great lubricant on this occasion, as you can feel it slowly slipping inside with each thrust you make into his warm insides. You ask him who he is, to which he replies in a normal tone. <i>”I’m a traitor,”</i> he says, as you plunge your shaft inside him, his insides being rubbed by your dick. You can see that his own cock is getting hard by your dick-flesh caressing his rectum with firmness. ";
								PAR3 = "\n\nAfter that, you start pumping your prick inside him with vigor, the sounds of the deer’s lust start to be evident with each time your thighs smack against his ass. You ask him once more who he is. <i>”I don’t know!”</i> he says between moans. Probably because of the elixir, but you can feel that you’re on the edge just by defiling the stag’s asshole, the excitement increasing as your corrupting fluids stains his body, causing him to moan and thrash wildly until you feel your own climax arriving, your cock spurting your corrupting spunk inside his hungry deer insides. Your cum starts filling him up more and more, but despite everything, you can’t see it leaking not a single drop, as the stag moans like a whore as his cock starts painting the wall in front of him.";
								PAR4 = "\n\nAfter a couple of seconds of uninterrupted cumming, you pull out. The seed that leaks from your cock falls into his strong ass and disappears, as if it seeps into his skin. The deer slides into the floor as you ask him who he is. <i>”I’m… the Guardian Prince... of the Forest”</i> he says, his tongue flailing out of his mouth as his own cock made a mess in the floor of his house. At least the deer has returned to his former self, so you dress once more and leave him to his fantasies once more";
							} else {
								PAR1 = "You proudfully display your moist cunt as you pour the elixir on your strap and cunt, feeling the corrupting influence soak both of them, causing your twat to pulse with desire to soak the insides of the pure deer that is in front of you. You tell him to expose his pucker, as he leans into a wall, spreading his buttcheeks, presenting his tight anus to you.\n";
								PAR2 = "\n\nYou tease his muscular butt by pressing yoursex toy against the crown of his asshole. The elixir serves as a great lubricant on this occasion, as you can feel it slowly slipping inside with each thrust you make into his warm insides. You ask him who he is, to which he replies in a normal tone. <i>”I’m a traitor,”</i> he says, as you plunge your strap inside him, his insides being rubbed by your fake cock. You can see that his own cock is getting hard by your firm toy caressing his rectum with firmness. ";
								PAR3 = "\n\nAfter that, you start pumping your strap inside him with vigor, the sounds of the deer’s lust start to be evident with each time your thighs smack against his ass. You ask him once more who he is. <i>”I don’t know!”</i> he says between moans. Probably because of the elixir, but you can feel that you’re on the edge just by defiling the stag’s asshole, the excitement increasing as your corrupting fluids stains his body, causing him to moan and thrash wildly until you feel your own climax arriving, your pussy spurting your corrupting femspunk into the deer thighs, seeping into its surface as if being absorbed supernaturally. Your cum starts to fall into the floor, filling the air with a strong erotical scent as the stag moans like a whore while his cock starts painting the wall in front of him.";
								PAR4 = "\n\nAfter a couple of seconds of uninterrupted cumming, you pull out your sex toy from his pulsating pucker. The deer slides into the floor as you ask him who he is. <i>”I’m… the Guardian Prince... of the Forest”</i> he says, his tongue flailing out of his mouth as his own cock made a mess in the floor of his house. At least the deer has returned to his former self, so you dress once more and leave him to his fantasies once more";
							}


							Board.text = PAR0 + PAR1 + PAR2 + PAR3 + PAR4; 

							NPCControl.npc5000CorruptionPath [0] = false;
							NPCControl.npc5000CorruptionPath [1] = false;
							NPCControl.npc5000CorruptionPath [2] = false;
							NPCControl.npc5000CorruptionPath [4] = false;
							NPCCharList.CharFollower[iYoshika].corruptionStage = 1;
					NPCCharList.CharFollower [iYoshika].charCorruption = 25;
						}



				} else if (NPCCharList.CharFollower[iYoshika].corruptionStage == 1 ) 
				{
					endTurnFun ();


					if (NPCControl.npc5000CorruptionPath [0] == false) {
							
							Board.text = "As you know that Yoshika now is living a delusion that he created on his own, to escape from his past. But he still thinks a lot of himself, proud on his skills and techniques. If you want to corrupt him to the core, you must get rid of that pride of his.";
							NPCControl.npc5000CorruptionPath [0] = true; 
							
					} else if (NPCControl.npc5000CorruptionPath [1] == false) {
							Board.text = "This time you call Yoshika to your office, because you want him to talk about something of his past. The deer quickly attends your callings and enters your office with haste. You can see that he is interested in what you have to say. So, you open a huge book and you start talking to him as you browse through it. You tell him that you can’t find anything about his so-called title of Guardian Prince of the Forest. You can see that he is confused about your remark, so you ask him why he is lying about his past.\n\nHe is dumbfounded. <i>“But, my liege, I’m being honest with you. I’m sure that title has been passed down by generations through my bloodline”</i> he says, worried about what you’ll say. You tell him that you can’t trust someone that can’t stop lying and that until you know who he truly is, he’ll be on close inspection by you. That until he gets some proof of this title, he is nothing more than a lying scum. <i>“Yes, my liege”</i> he says, utterly shocked but complying, as he doesn’t seem to know a way of proving it to you. You tell him that he is dismissed, that he can return to his duties as you turn your back to him. He nods and walks back, visibly crestfallen. You smile with wicked glee as he leaves your office.";
							NPCControl.npc5000CorruptionPath [1] = true; 
							
					} else if (NPCControl.npc5000CorruptionPath [2] == false) {
							Board.text = "This time, you call him with haste, and he arrives quickly at your office, looking visible troubled since the last time you called him into your office. This time you tell him that you’ve done your research and that you’ve come to the conclusion that he could even be an spy of the Citadel. You tell him that the cabin where he lives isn’t in the records, so it must be not that old. You asked the oldest explorers and they said that they can’t remember anything dangerous other than the Lost that dwell in the forest. If the stag was worried before, now he is distressed.\n\nYou tell him that you don’t know what to do with him, but he should have investigated this before, not wait until you had to excavate for this information. You tell him that this shows that he doesn’t even know nothing about his past and that its something too convenient. You tell him that even if he isn’t someone dangerous to your reign, that he should stop acting as if he is someone important and act more like the mindless deer he is. He babbles a couple of seconds before stopping and sighing. <i>”Very well, my liege”</i> he says, before lowering his head. You tell him that for now he should return to his duties, but that you’ll call him once more at a later time, to tell him your verdict.\n\nHe raises from the chair and bows to you. <i>”So be it, my liege...”</i>. And with that, you dismiss him. You can see the confusion in his eyes, something that makes you think that he is closer to what you need than you originally thought.";
							NPCControl.npc5000CorruptionPath [2] = true; 
							
					} else if (NPCControl.npc5000CorruptionPath [3] == false) {
							
							string PAR0 = "You have the corruption elixir ready for him, but you must be sure that his pride is broken enough for it to work properly. You call for the deer once more, this time you can see that he is a bit undecided as he enters your office. You tell him to sit down and when he does, you stand up and start explaining to him that, despite your lack of trust on his words and his actions, you want to help him. But the deer must listen to his demands a bit less and acting on them a bit more. You can see that the stag that once was beaming with pride, hangs his head low and with drooping shoulders.\n\n<i>”You’re right, my liege”</i> he says, looking at you in the eye once more before sighing. <i>”I think that I need some guidance from someone definitely better than me, and that you’ve proven to have a clearer head than mine.”</i> His answer makes you smile, and that you’re more than pleased to help him, but that he must know that nothing comes off free. So you tell him that he has to prove to you that he is truly committed to improve, as you show him the corruption elixir. So you sit on the desk as you remove your lower half of your clothes and tell him that he should drink the content of the elixir from you. The deer looks at the bottle and starts kneeling, slowly getting close to your crotch as you pour the corruption elixir all over your genitals, its corruption powers exciting you by a large amount.";
							string PAR1 = "";
							string PAR2 = "";
							string PAR3 = "";

							string PAR1L1 = "";
							string PAR2L1 = "";


							if (GameControl.dick1Size > 0) {
								if (GameControl.hasVagina == true) {
									PAR1L1 = " as he uses one of his hands to rub the entrance of your vagina";
								} else {
									PAR1L1 = "";
								}

								if (GameControl.testiclesSize > 0) {
									PAR2L1 = " as he fondles your "+ ballsSize +" balls with care and lust";
								} else {
									PAR2L1 = "";
								}


								PAR1 = "\n\nThe deer takes a good look at your " + dickSize +" penis. He doesn’t stop too long as he uses his tongue to enjoy the taste of your " +  dickRace +" cock" + PAR1L1 +". You can feel how your genitals start to swell from his exciting ministrations, as his tongue plays with the head of your cock, enjoying the elixir taste as his eyes roll into the back of his head, his body trembling from pleasure.";
								PAR2 = "\n\nAfter a couple of licks, you can see that the elixir is starting to take effect, because he began to engulf your cock with desperation, his tongue lapping the whole length of your dick, trying to lick clean the elixir from it, alongside your precum as he works the rest of it with his soft hand"+ PAR2L1 +". He bobs his head again and again, trying to tease your shaft into cumming, the warmness and the rubbing of his wet tongue and insides, sends you over the edge, as the eyes of the deer are filled with wicked desire. When he see that you’re on the edge of cumming, he increases his blowjob until you grab his head and push your cock the farthest inside his mouth. Your corrupting cum began to unload inside his needy mouth, as he slurps your fluids like a whore, his tongue wrapping around your shaft as he tries to push your spunk into his mouth. ";
								PAR3 = "\n\nYou can feel how his soul is being corrupted slowly, as he finally let go your cock, his whole mouth and neck is dripped in your cum, as his face of delight couldn’t be matched with anyone else. He licks his hand covered in spunk, you can see that he creamed his own clothing, his cock still poking against his clothing, as the scent of his seed fills him entirely. So you leave him to enjoy his new corruption, alongside the cum that come with it.";
							} else {
								PAR1 = "\n\nThe deer takes a good look at your wet pussy. He doesn’t stop too long as he uses his tongue to enjoy the taste of your twat. You can feel how your genitals start to swell from his exciting ministrations, as his tongue plays with the entrance of your cunt, enjoying the elixir taste as his eyes roll into the back of his head, his body trembling from pleasure.";
								PAR2 = "\n\nAfter a couple of licks, you can see that the elixir is starting to take effect, because he began to push his tongue inside your pussy with desperation, his tongue lapping your nether insides of your cunt, trying to lick clean the elixir from it, alongside your precum as he works the rest of it with his soft hand. He laps with his tongue your clit, trying to tease it into cumming, the warmness and the rubbing of his wet tongue and insides, sends you over the edge, as the eyes of the deer are filled with wicked desire. When he see that you’re on the edge of cumming, he increases his cunnilingus until you grab his head and push his nose and tongue the farthest inside your hole. Your corrupting vaginal fluids began to unload inside his needy mouth, as he slurps your fluids like a whore, his tongue wrapping around your twat as he tries to lick your spunk into his mouth. ";
								PAR3 = "\n\nYou can feel how his soul is being corrupted slowly, as he finally let go your pussy, his whole mouth and neck is dripped in your juices, as his face of delight couldn’t be matched with anyone else. He licks his hand covered in femspunk, you can see that he creamed his own clothing, his cock still poking against his clothing, as the scent of his seed fills him entirely. So you leave him to enjoy his new corruption, alongside the cum that come with it.";
							}

							Board.text = PAR0 + PAR1 + PAR2 + PAR3;


							NPCControl.npc5000CorruptionPath [0] = false;
							NPCControl.npc5000CorruptionPath [1] = false;
							NPCControl.npc5000CorruptionPath [2] = false;
							NPCControl.npc5000CorruptionPath [4] = false;
							NPCCharList.CharFollower[iYoshika].corruptionStage = 2;
							NPCCharList.CharFollower [iYoshika].charCorruption = 50;
					}


				}else if (NPCCharList.CharFollower[iYoshika].corruptionStage == 2 ) {
					endTurnFun ();

			
						if (NPCControl.npc5000CorruptionPath [0] == false) {
							Board.text = "Although you know that Yoshika is more prone to being manipulated and guided to do your biddings, you know that he will not allow himself to be yielding, as long as he has his own opinion about things. So you start to think of a plan to force him into a more submissive state of being. ";
							NPCControl.npc5000CorruptionPath [0] = true; 
							
						} else if (NPCControl.npc5000CorruptionPath [1] == false) {
							Board.text = "You call for Yoshika and ask him if he could do a special favor for you, which he accepts. You ask him to keep an eye on some workers that are unloading some bags from the carts into the castle. But from the beginning, you give him the wrong number of bags that they would bring with him. He nods and gets to work on it, so you wait for your plan to complete itself.\n\nAfter a couple of hours, you see that Yoshika has finally arrived with the cargo you asked for him. When the workers unloaded all the things and your servants have counted all of them, you go and tell Yoshika that some of them are missing. You can see that the deer is a bit nervous and doesn’t know what to answer.\n\nYou tell him that he is such a failure, that when he tries something on his own terms, he is doomed to fail. Now he has to buy the things that are missing and he will lose a lot of money because of him. You explain to him that this kind of things happen, because he wants to do things on his own way. You can see that he is surprised but hurt for his failure. He tries to say anything, but you cut through his words easily, telling him that there is no excuse.\n\nYou tell him that the next time you will tell him how to do the things, which he sighs and nods, walking back to his hut, definitely crestfallen. You smile as he walks away, knowing that you have planted the seed of doubt in him once more, and you know that it will flourish.\n";
							NPCControl.npc5000CorruptionPath [1] = true; 
							
						} else if (NPCControl.npc5000CorruptionPath [2] == false) {
							Board.text = "This time, you call for Yoshika because you tell him that you require some help in making a decision. The deer arrives to your office quickly. “What kind of help do you need?,” he asks, as he probably took the meaning of ‘help’ a little bit more serious of what you meant with it. \n\nYou welcome him to your office and then point at two male servants that are sitting each one in a chair, both of them in front of your desk, looking at the floor, as if awaiting some kind of verdict. He looks at them, then returns his gaze to you. You explain him that they got caught stealing property of the Lord. And to make sure that it won’t happen again, you explain to Yoshika, that you are going to punish them for their crime.\n\nYou explain that you will place the guilty one in stocks in the garden, for the other servants to use at their will for a whole day. That will make an example of their crime, but you can’t seem to find the one guilty, as they blame each other as the mastermind of the crime. You tell him that perhaps he can get to the bottom of this.\n\nYou can see that the deer is a bit distressed, but accepts anyways. He tries to talk to them, but both almost pleas for forgiveness, blaming the other for the crime. After a bit of struggling, Yoshika finally decides for one of them. You call for the guards, and point at the one that Yoshika said that was guilty. They grab him and leave the place, as you can see the deer is nervous about it. You tell him to follow you, something he does without saying anything.\n\nYou guide him to the garden where the guards are stripping him of his clothes and placing a bandage over his eyes as they put him inside the stocks. You explain the crimes of the servant and explain his punishment. Not even two minutes have passed, and the other servants are already touching him and teasing his body with their hands. You explain to Yoshika that having to take choices is something painful, because when you fail, someone else is hurt. You ask him if he is completely sure that he is the thief? What if he’s not? Then the deer has sent someone innocent to this punishment.\n\nOne servant is making the one in the stocks suck his dick, as he presses it against his mouth until he is almost facefucking him. After that, you can see how the will of the deer is falling apart. <i>“Isn’t there another way? I’m not good at this...,”</i>] he says, with his eyes full of doubt. You tell him that there is another way. If he leaves all the decisions to you, then nothing will be his fault, and he will not feel bad for this never again..\n\nHe looks at you, puzzled at your offer but then he looks at the man in the stocks, being fucked by another servant, although he seems to be starting to enjoy the treatment a bit, as his cock seems to be leaking precum from all that. <i>“That doesn’t sound bad at all”</i> he adds. You thank him for coming, something that makes him return to reality, as he was zoning out. He asks for permission to retire, his body cowering on itself as he leaves. It has been a while since you’ve seen that Yoshika, and you welcome him greatly.";
							NPCControl.npc5000CorruptionPath [2] = true; 
							
						} else if (NPCControl.npc5000CorruptionPath [3] == false) {
							
							string PAR0 = "You think that Yoshika is ready for his corruption elixir, but you require one final proof of this. This time, you ask him to go with you to the market, to what he accepts without questions, which is a good sign for you.\n\nSo both of you go to the market and check different shops and carts that are across the market. After a couple of hours of roaming, you find a nice alley that is in the middle of the marketplace, but secluded enough for both of you to enter without calling too much attention. You push him to the alley when no one else is looking, entering you after him.\n\n<i>“What is it?”</i> he asks, as he looks around the alley. The place is a bit dirty but doesn’t looks like it’s completely forgotten by the other citizens. You walk to the end of the alley, where the wall is and turn to see him, showing him the corruption elixir that you had in your pocket. <i>“Is that…?”</i> he looks at the bottle with curiosity, but you can see him drooling a bit by instinct.\n\nYou tell him that with the corruption elixir, he will be free from all the worries of doing something wrong, that he only needs to leave the things to you. You can see his hands slowly trying to reach the elixir, but you move it from reach and you tell him that you require of him a final proof. “I’ll do anything!” he says, with a tone of desperation in his voice, something that makes you smile. \n\nYou tell him that he must allow you to fuck him in that alley. <i>“Here? But… people can come over here and see us”</i>, he looks around but there are no windows that leads in there. You tell him that only by doing what you say, he will get the elixir. He lowers his shoulders and nod, then he lowers his head as he removes his clothes. Just by seeing him subdued to your whims is starting to get you excited.";
							string PAR1 = ""; 
							string PAR2 = "";
							string PAR3 = ""; 
							string PAR4 = "";
							string PAR5 = ""; 
							string PAR6 = "";
							string PAR7 = "";
							string PAR8 = "";

							string PAR1L1 = "";
							string PAR1L2 = ""; 


							if (GameControl.dick1Size > 0) 
							{
								if (GameControl.hasVagina == true) {
									PAR1L1 = " alongside your moist cunt, that is getting wet by the corruption plans you are brewing"; 

								} else {
									PAR1L1 = "";
								}
								if (GameControl.testiclesSize > 0) {
									PAR1L2 = " and "+ ballsSize +" balls to him";
								} else {
									PAR1L2 = ""; 
								}
								PAR1 = "\n\nYou can feel how your "+ dickSize +" " + dickRace +" cock is starting to get bigger just by seeing the well-toned body of the naked deer in front of you, so you remove the lower half of your clothes, exposing your dick"+ PAR1L2 + " "+ PAR1L1 +" alongside your moist cunt, that is getting wet by the corruption plans you are brewing[/IFVAGINA]. You can see him turning and leaning into the wall that is at the end of the alley, presenting his lower back to you. You can see that this is arousing him, as his cock is getting hard too. You lace your dick with the corruption elixir, as its tainting influence starts to seep all over it and working as a sinister oil for your plans."; 
								PAR2 = "\n\nYou use both hands to feel the buttocks of the deer, as they are as hard as iron, his asshole packed tightly between them. You can see that Yoshika looks over his shoulder from time to time, so you turn to see that at the entrance of the alley, the people of the marketplace come and go, minding their own business. Not knowing that the "+ mcpronoun +" of the city is about to fuck someone in an alley, close to them.";
								PAR3 = "\n\nYou press your cock against Yoshika’s asshole, feeling how the deer trembles by the sensations that you are causing him. You slide your shaft inside him with ease, the elixir truly does a great job on this, as you can feel its corruption, slowly tainting the deer that is in front of you, every time your dick rubs inside his pucker."; 
								PAR4 = "\n\nThe deer winces at first, but after you got most of your dick inside him, he finally relaxes his muscles and began to enjoy the ride. You give his ass a very good squeeze, feeling the might of the deer in them. You can feel his sturdy muscles as you grab his waist and thighs while you thrust your shaft inside him continuously. His sighs turn into moans as the deer is consumed by lust, probably as the potion is doing his effect on him.";
								PAR5 = "\n\nHis tongue flails out, as he starts to push himself against your groin, the lusty deer enjoying the fact that you are ramming your cock in a place that definitely isn’t private as much as you do. You can see his cock flailing too, every time you smack your hips against his robust ass, dripping with precum already. His insides welcome your meat, his asshole clenching to your cock, trying to make it as pleasurable as possible. ";
								PAR6 = "\n\nThe excitement proves too much for you in the end, your orgasm finally arriving with a blast. Your cock unloads its cum with pleasure over his insides, the traces of the elixir probably seeping further, tainting as much as they can. The deer lets out a loud moan, as he holds from the wall, while you can see that he cums hard against it, painting it white with its deer cum. ";
								PAR7 = "\n\nAfter a couple of seconds of unloading your spunk inside him, you pull out of his anus with a loud popping sound, as your cock leaks the rest of your cum into the ground, as you can see traces of the dark elixir in them. The deer turns and see that too, kneeling and touching it with his hands and smearing it in the exposed parts of his body, as you can see that your tainted cum disappears, as if it’s absorbed by him.";
								PAR8 = "\n\nAfter that, he tries to reach his clothing, but you take them and ask him if you ordered him to go back to his house naked, he would do it?. He looks at you, then nods a couple of times at your question. You smile and throw his clothings back to him while you dress back. For now he is submissive to you, and is all that matters.";


							} 
							else {
								PAR1 = "\n\nYou can feel how your pussy is getting wet just by seeing the well-toned body of the naked deer in front of you, so you remove the lower half of your clothes, exposing your moist cunt, that is getting hot by the corruption plans you are brewing. You can see him turning and leaning into the wall that is at the end of the alley, presenting his lower back to you. You can see that this is arousing him, as his cock is getting hard. You lace your strap-on with the corruption elixir, as its tainting influence starts to seep all over it and working as a sinister oil for your plans."; 
								PAR2 = "\n\nYou use both hands to feel the buttocks of the deer, as they are as hard as iron, his asshole packed tightly between them. You can see that Yoshika looks over his shoulder from time to time, so you turn to see that at the entrance of the alley, the people of the marketplace come and go, minding their own business. Not knowing that the "+ mcpronoun +" of the city is about to fuck someone in an alley, close to them.";
								PAR3 = "\n\nYou press your corrupted dildo against Yoshika’s asshole, feeling how the deer trembles by the sensations that you are causing him. You slide it inside him with ease, the elixir truly does a great job on this, as you can feel its corruption, slowly tainting the deer that is in front of you, every time your strap-on rubs inside his pucker."; 
								PAR4 = "\n\nThe deer winces at first, but after you got most of your fucktool inside him, he finally relaxes his muscles and began to enjoy the ride. You give his ass a very good squeeze, feeling the might of the deer in them. You can feel his sturdy muscles as you grab his waist and thighs while you thrust your strap-on inside him continuously. His sighs turn into moans as the deer is consumed by lust, probably as the potion is doing his effect on him.";
								PAR5 = "\n\nHis tongue flails out, as he starts to push himself against your groin, the lusty deer enjoying the fact that you are ramming a dildo in a place that definitely isn’t private as much as you do. You can see his cock flailing too, every time you smack your hips against his robust ass, dripping with precum already. His insides welcome your fucktool, his asshole clenching to your cock, trying to make it as pleasurable as possible. \n";
								PAR6 = "\n\nThe excitement proves too much for you in the end, your orgasm finally arriving with a blast. Your pussy dripping its lewd juices all over your thighs and legs. The deer lets out a loud moan, as he holds from the wall, while you can see that he cums hard against it, painting it white with its deer cum. ";
								PAR7 = "\n\nAfter a couple of seconds of uninterrupted orgasming on your behalf, you pull out of his anus with a loud popping sound, as your dildo leaks the rest of the elixir into the ground. The deer turns and see that too, kneeling and touching it with his hands and smearing it in the exposed parts of his body, as you can see that the corruption elixir disappears in his body, as if it’s absorbed.";
								PAR8 = "\n\nAfter that, he tries to reach his clothing, but you take them and ask him if you ordered him to go back to his house naked, he would do it?. He looks at you, then nods a couple of times at your question. You smile and throw his clothings back to him while you dress back. For now he is submissive to you, and is all that matters.";

							}


							Board.text = PAR0 + PAR1 + PAR2 + PAR3 + PAR4 + PAR5 + PAR6 + PAR7 + PAR8; 


							NPCControl.npc5000CorruptionPath [0] = false;
							NPCControl.npc5000CorruptionPath [1] = false;
							NPCControl.npc5000CorruptionPath [2] = false;
							NPCControl.npc5000CorruptionPath [4] = false;
							NPCCharList.CharFollower[iYoshika].corruptionStage = 3;
							NPCCharList.CharFollower [iYoshika].charCorruption = 75;
						}

			}else if (NPCCharList.CharFollower[iYoshika].corruptionStage == 3) 
				{  //////////
					endTurnFun ();


						if (NPCControl.npc5000CorruptionPath [0] == false) {
							Board.text = "You are on a private part of the gym, just for you and Yoshika. You enjoy how the deer moans in a low tone as you jerk him off under his clothing. He is sitting in a puddle made with his own precum. You know this is easier as he is not wearing any underwear, as if waiting for someone to take him whenever they wanted.\n\nYou know how he is truly on the inside, but maybe is a good idea to show other people how much of an easy bitch he truly is. To make him crave for the touch of anyone and spread the craving among others. As you feel him spurt, you start to elaborate a series of things that you could do, to push him to your objective.\n"; 
							NPCControl.npc5000CorruptionPath [0] = true; 

						} else if (NPCControl.npc5000CorruptionPath [1] == false) {
							Board.text = "You arrive to the gym before it opens its door to the public. It’s still early in the morning, but you can see that it's not that much left before dawn. You can see that Yoshika is preparing everything for that day, and you open the door as you have your plan ready in your mind.\n\nYou tell him that you have a new policy that will be in place from that day. He gives you a weird look, but nods after that. -What kind of policy?- He asks, while cleaning his hands with a rag. You tell him that you’re planning on having some fun with them, and at the same time do them some good. He looks a bit puzzled when you mention “them”. You tell him that the new policy for the gym is that the staff of the place must be naked while working.\n\nHe looks quite surprised of that statement. -And why is that? I thought that yielding is something between you and me. Why them?- You tell him that is because they are just as he was before. They don’t know how wrong they are and sometimes need a push just like he required when you meet him. -Do you think so?- You nod and ask him if he feels better since he is submissive. -You sure have a point in there, my " + mcpronoun + "- You smile at his answer and tell him that the policy is not in discussion. After all, this is your place in the end, and he is only there to comply with your demands. You can see him trembling a bit from excitement as his face gets all flustered because of the sensation of being ordered by you.\n\nYou raise your index finger and continue your explanation. You tell him that he is the one who will tell the others about the new policy. You can see that phrase took him out of his meanderings and a hint of fear shows in his eyes. -M-M-Me? But… what will they think of me?- You smile wickedly and nod. -They will know that you are nothing more than a yielding bitch that bends to anyone’s will- You see how the fear in his eyes gets slowly replaced with lust and excitement. -Others will know… how much of a submissive whore I am- It seems that the idea is not that hard for the lewd mind of Yoshika, but you can see that it's something that makes him anxious. -I... don’t think I can do it- You state to him that he will learn how to do it. And with that, you have him goodbye, as he tries to reach you but he doesn’t even try to touch you, as he knows his place.\n\nYou go through the back door of the gym, using the master key of the place you own. You sneak into the place, being careful of not being detected. After the other staff of the place arrive, you can hear Yoshika talking with them and explaining the new policy. At first you hear how they start to ask for explanations about that. After the stag only says that he is following orders, they start to get more angry with him. They start by asking why he is following those orders, at which he stammers his answer: He follow orders from everyone, that’s what he does.\n\nThey start to insult and yell at him, telling him that he is nothing more than a spineless pussy. That he surely likes to be fucked by anyone around him, which makes you laugh a bit, as he isn’t wrong at all. They end the conversation saying that it's good for them to know how much of a whore he is, that he will probably enjoy showing his ass and junk for everyone to use. They continue the verbal abuse until you hear how they walk to the dressing rooms on the other side of the building.\n\nAfter that, you take a sneak peek at the stag, who hasn’t moved from his original place. You can see him jerking himself off in his knees from below his clothes, tongue out as he keeps saying something in a low tone. -I’m a depraved slut… That’s what I am. Can’t wait to tell this to my " + mcpronoun + "...-\n\nYou feel satisfied for the moment with him, leaving that frustrated male to himself, as he is too busy to attend to anyone for now. He just took a big step in revealing himself to his peers. And with that, you return to your manor.\n"; 
							NPCControl.npc5000CorruptionPath [1] = true; 
							

						} else if (NPCControl.npc5000CorruptionPath [2] == false) {
							Board.text = "You’ve been thinking on the way to further the development of Yoshika as a pervert. After talking with your servitude among other rich people, you found out that there is the perfect place for the deer. You make your own investigation until you finally found the place and get ready for the next day.\n\nWhen the day arrives, you wear a disguise in this occasion and go to the gym, just before it closes, as you know that this plan would take more than a mere walk in the park. You can see that is almost night, the road to the gymnasium is almost deserted, save from the occasional citizen. The place is empty already and you see Yoshika getting ready to close the place. So, you walk inside and greet him like always. He stops what he is doing and walks quickly to greet you.\n\n-Good evening, " + mcpronoun + ". Have you come to use me like always? I’m always ready for you- You wave a hand downplaying the matter. You tell him that this night, he is coming with you. He claps with excitement as he works faster to let the place ready for the next day. You are satisfied on the obedience of this deer, but now is time to train the little slut he has inside him, to let it flourish for everyone to see. And when he finishes his chores, you close the gym and start the road to the place you memorized earlier.\n\nYou can see that he is a little startled of not knowing where he is heading, as you guide him through more and more dangerous places. You are not scared of these places, after all you know how to defend yourself, so you can’t help but feel sorry for the ones that try to get in your way. After what felt like an eternity, you finally arrive at the place. You knock four times then two more, as the door unlocked and you motioned the deer to follow you inside. You walked through a torn-down corridor that has a lot of doors until you arrive at a large room with the number 1 on a plate. You take out a small key that you use to open that door and push Yoshika first, then you entered and closed the door behind you. That room has several holes on the walls, half of them are filled with hard cocks from varying sizes and the other half are sporting a couple of female bottoms slowly reeking with a strong smell of fluid as both of you walk close to them. The walls are full of degrading terms and slurs\n\nYou don’t need to tell the deer to get ready because when you turn to see him, he is already removing all his clothes and waiting patiently next to you, but you can see that his cock is slowly getting hard, from the smell of the whole place. -What are my orders- At which point you take him from his arm and guide him to one of the females asses that are close to him. This one has a pair of feline feets, as she clamped her muscles a bit, knowing that we were close to her. You point at the floor beneath her and tell him to get down on his knees and to start licking her, but without touching himself.\n\nHe complies, taking a deep breath of her sexual fluids before starting to lick her pussy. You can see how he tries to start slow and careful. You see with impatience how he is being gentle with his cunnilingus. “You have to do it harder!” You say in a higher tone, to which point you can see that Yoshika gets to do it a little bit faster, but it isn’t enough. You place a hand on the back of his head and push him against the cunt that is in front of him. -How are you planning on pleasing others, if you can’t do it properly? Do it harder!- You keep him in place as you can see how his eyes roll out to the back of his head, being intoxicated by her lewd smell.\n\nYou see how he starts to lick her pussy with lust, his tongue possessed with the desire that he starts to feel inside him. You can see that his cock is rock hard, twitching for attention and that he has to fight the urge to stroke it, as you stated clearly that he is not allowed to do so. He keeps licking as he is consumed by his libido, holding her legs with his hands as his nose is still pressed against her inner labia, sucking her clit with a carnal hunger that continued until you see how her whole rear starts to tremble as she cums all over his face.\n\nWhen you finally see that she finally stopped cumming, you pull him out of it, as you see that his gaze is full of lust, his hands trembling with the need of release from his cock. You pull him from that one and move him in front of a cock. “Now this one. Suck it dry, you slut” You command him, at which point he looks at you and asks. -Can I rub myself?- You deny his request and tell him that his only focus is the other’s genitals in front of him for now.\n\nHe pants as he nods, grabbing the cock with both hands as he introduces it inside his mouth and plays with it using its tongue. You can see that its whole body is twitching with each lap as he uses both hands to stroke it. You can see that he is desperate for his cock at this moment, wrapping his mouth all over it as he tries with all his might for him to cum. As he tries to pull out, you push his mouth back into place. “No rest until you’re done, bitch. Get to it!” You can hear the deer’s moans of pleasure as you push him every time he bobs back his head until you see how his mouth gets to be filled with the cock’s cums until his cheeks are full, as he tries his best to swallow it all. You can see how the stag’s cock get to cum too, spurting a jet of cum into the wall in front of him. You can see him coughing a lot of cum as he takes deep breaths. -This… is amazing. I want more...-\n\nYou tell him that he can have more, but you whisper into his ear that it's not necessary for him to come here. You tell him that there are a lot of pulsing cocks and tasty pussies all around him, just waiting for him to serve. You can see him stand up from where he is and look at you, as if he just found out a truth of the universe. -You are completely right... I just need to serve them as the needy slut I am- You wait for him to get dressed before slowly returning to the alleys that leads both of you home. You are comfortable with the accomplishments he did today, and his face says that he thinks the same. And with that, you return to your manor.\n"; 
							NPCControl.npc5000CorruptionPath [2] = true; 
				
						} else if (NPCControl.npc5000CorruptionPath [3] == false) {
							
							Board.text = "You can feel in your insides that Yoshika is ready for its elixir, so you already bought it. But you don't plan on buying it twice, so you better make sure that the slutty deer is ready for his dose of carnal taint. He has made himself known to others as a worthless bitch and he has been craving more and more sex from total strangers. Now it’s time to push this to the last step and see him submit to someone without further instructions. After all, he needs to do it by himself.\n\nYou have been watching that persons that attend the place, and you found out that there is a new couple that just arrived at the gym. A female with kangaroo features and his partner, a wolf male, you don’t know more of them and being honest: You don’t care. They will work just perfectly for the plan you have for Yoshika.\n\nOne day, you go to the gym and you tell him to follow you to the office. In there, you close the door inside and you see that he is just about to take his clothes off, but you instruct him to stop, at which moment you take the elixir from one of your pouches and show it to him. You can see him gasp at the sight of that bottle. -I-Is that what I think it is?- You can see a hint of excitement in his eyes. “Are you that dumb?” You say with a smile then nod. -Is that for me?- You hear from him, with a tone of hopeful delusion. “Maybe. But you have to deserve it first”. He goes close to you and kneels, holding your lower clothing with its hands. -I’ll do whatever you want for that elixir. Use me as you like, but i need it!- You can see that he has the potential, but you require more proof.\n\nAnd with that, you store the elixir in your bag once more. After that, you fondle his groin and rub his body. -What i should do?- You order him to stop asking questions. You can see how he starts to get more and more excited with your touch. You rub his nipples, squeeze his butt and tease his cock from below his clothes. when you feel that he is hot enough, you stop. He look at you with a perplexed gaze. You motion him to stand up and lead him off the office. You can hear him panting as he walks beside you. When you finally arrive at the entrance of the gym, you point discreetly at the female that is resting in one of the benches of the place. “Ask her to finish you”. He looks at her and without a hint of doubt, he starts to walk on her direction.\n\nYou couldn’t lose the opportunity to see this, so you moved into a more comfortable place where you can hear them and waited for him to start. You can see him still cowering as he walks towards her, whose gorgeous body lies drenched in sweat from all the workout. He stands next to her and starts a conversation with her, you can see that his body was trembling with desire as he probably wanted to cum from all the excitement he is carrying.\n\nAfter a bit of shy conversation, you can see that he drops the phrase that he planned since he arrived next to her: If she wanted to fuck him. She raises an eyebrow and looks at him from head to toe. He isn’t helping his case with that stance, but you already know how he would react and that’s part of the whole course of planning.\n\nYou can see that around the corner, a man is walking in their direction. You recognize him as the boyfriend of that woman, and you can see that he already has seen Yoshika. He gets close with large steps until he is next to the deer and push him aside, knocking him into the floor. -What the fuck do you think you’re doing? She’s mine- The wolf almost growls. You can see that the stag doesn’t know how to react, as he looks around probably trying to find you with its gaze and when he can’t see you, he turns to see the male wolf getting closer to him. You can see him standing up and gets to explain himself.\n\nYou can see how he almost stutters his situation. -I need some release...- Then the wolf takes a good look at him and straights up. -You are that wuss that i heard about last time! The pussy that can only follow orders!- He says out loud. He got closer to him, his body was a little bit more meaty than Yoshika, but you know that the stag can beat the crap out of him as he is trained for combat. You are sure that the wolf is not capable of true fight, and you are completely sure that Yoshika knows this too. But you know that he won’t do anything, and that will be the proof that he is ready.\n\nThe deer lowers his head and looks to the side. The wolf takes him by his neck and with the other gropes his own pants. -So, if you need truly some release... - You see how he exposes his cock and with his other hand he pulls the top of Yoshika and makes him kneel into the floor. -Then start sucking, you fucker- You can see the moment when Yoshika gaze upon the male’s dick. He looks at the wolf in the eye and starts stroking his cock with his hands, then proceeds to lick it with some desperation. You can see how the wolf nods in approval. -I knew that you were a slut on the inside-\n\nYou can see how the deer only nods at his remarks about him, as he continued working his dick. You can see that the wolf’s words only make the deer even more aroused, as you know that being only a recipient of other’s lust is too exciting for him, as he has always been on the inside. You can see him moaning and stroking him, as the woman that is next to them starts to touch herself by looking someone blow his partner. Without further conversation, she stands from the bench and push the deer’s head into the groin of his partner, pushing its cock into his throat, making him gurgle in pleasure as his eyes roll up into his head. -He’s amazing. He can take up all your length, darling! Maybe we should use him more often. His mouth is such a good cocksleeve- She says as she plays with her pussy with her other hand.\n\nThe blowjob continue for more than you expected, as both of them continue to play with the new slut they found. You can see how Yoshika is enjoying himself, until the wolf finally cums all over his face and chest, leaving him in the floor completely wasted. After a couple of laughs they probably go to the baths after the “workout”. You walk until you are next to him and look at him. Despite all those things that happened and the fact that he is covered in someone else’s cum, you can see that the stag is quite satisfied with the income.\n\nYou help him to get into the office. -That was amazing. If only i had known earlier that i was such a servicing slut. It would have saved me many problems from the start. So...- He rubs the pocket where you have the elixir. You tell him that he is ready for the next step then. \n"; 
							if (GameControl.dick1Size > 0) {
								Board.text += "You take the elixir and pour it over your cock. -Time for your dose then, whore- He places himself in his knees, a position he looks like he is more comfortable now and starts sucking it. His mouth is so trained that engulfs your shaft like an expert, teasing it with its tongue as it tries to lick every drop from the elixir with true mastery. As the elixir gets into his body, you can see him cumming in the floor below him, without even touching himself. \n\nYou couldn’t help but cum quickly to his ministrations, as he holds your dick in his mouth, trying to get the smallest drop from the elixir that could be left in your cock, slurping it until you can’t cum anymore, and he stills strokes it until your balls are empty of spunk. After that, he gasps for air as he pulls out your cock and falls into his back. You can feel how his face is of someone that has no way back into a sound mind, but he looks like delighted in his new condition. You leave him like that as you open the door of the office. You never know, maybe another person will pass and will make good use of him once more.\n\n"; 
							} else {
								Board.text += "You take the elixir and pour it over your cunt and clit. -Time for your dose then, whore- He places himself in his knees, a position he looks like he is more comfortable now and starts licking it. His mouth is so trained that he teases your twat like an expert, rubbing it with its tongue as it tries to lick every drop from the elixir with true mastery. As the elixir gets into his body, you can see him cumming in the floor below him, without even touching himself. That is the power of the elixir.\n\nYou couldn’t help but cum quickly to his ministrations, as he plays with your clit, trying to get the smallest drop from the elixir that could be left in your nether lips, slurping it until you can’t cum anymore, and he stills strokes it until there are no traces of sexual fluids in your groin. After that, he gasps for air as he pulls out your from your pussy and falls into his back. You can feel how his face is of someone that has no way back into a sound mind, but he looks like delighted in his new condition. You leave him like that as you open the door of the office. You never know, maybe another person will pass and will make good use of him once more.\n\n"; 
							}
							NPCControl.npc5000CorruptionPath [0] = false;
							NPCControl.npc5000CorruptionPath [1] = false;
							NPCControl.npc5000CorruptionPath [2] = false;
							NPCControl.npc5000CorruptionPath [4] = false;
							NPCCharList.CharFollower[iYoshika].corruptionStage = 4;
							NPCCharList.CharFollower [iYoshika].charCorruption = 100;
						}

				

				

				} //////////

			}



		
	}//


	/// <summary>	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	/// SCENES
	/// </summary>
	public void scene1(){


		GameControl.actualArousal = 0; 

		endTurnFun ();


		if (NPCCharList.CharFollower[iYoshika].corruptionStage == 0 )
		{
			string PAR0 = "";
			string PAR1 = "";
			string PAR2 = "";
			string PAR3 = "";
			string PAR4 = "";

			string PAR3L1 = "";

			// dick
			PAR0 = "As the day passed, you wanted to spend some quality time with the deer that you appointed to the gym. You can see that he is someone fun and interesting enough for you to spend some time. The place is almost empty, probably it is just a low day. You found the stag sitting in his office as he works on the papers required to run the place.\n\nYou go close to him, and he notices you, nodding a bit as you get closer. <i>\"Hey there, my liege. What can I do for you today?\"</i> He says with a helpful tone. You know how much of a loyal follower he is, so you decided to show him some appreciation to the deer you have in front of you, so you wanted to do something special for him, here and now.\n\nSo, you grab his attention and point to the papers with your head, motion he understands perfectly. He piles them up and guard them, cleaning the desk that he is using right now, then you close the door behind you. You can see that Yoshika is still turning his back to you. <i>\"What do you have in mind, my liege?\"</i> he says, as he tries to undress a bit.\n\nYou place yourself behind him and ran your hands over his body, enjoying the firmness of his muscles and the overall toughness of his whole corporeal frame. It's so exciting that someone so strong is so permissive with someone else. <i>\"Someone is excited...\"</i> You hear interest from the stag in front of you, at which you didn’t answer. You shove your hand inside his pants, rubbing his crotch with assertiveness, feeling his dick and balls between your fingers.";

			if (GameControl.dick1Size > 0) {
				if (GameControl.hasVagina == true) {
					PAR3L1 = " as your hidden twat juices itself and your thighs from the pleasure it cannot hold anymore";
				}
		

				PAR1 = "You tell him as you tease his cock with your hand, that maybe you can get some help from him too. He trembles a bit from your touch but agrees to it, as the lust increases for him rather quickly. He starts groping your lower body, feeling your legs as he tries to find your groin, which is hard due to your touch making him harder to focus. It is exciting to see him having trouble to follow your statements as the pleasure flows to him more and more from your caressing. You can feel his cock growing with each stroke of your hand, until is fully erect.";
				PAR2 = "But finally he reaches your groin, desperately trying to get his hand inside your lower clothing. He grabs your "+ dickSize +" "+ dickRace +" dick and starts stroking it with lust, as he started panting from all the stimulation. You can feel that despite his lack of focus, his touch is soft and pleasurable. His strong hand is quite capable of jerking you off from that position and for the time it could take. You make it a challenge against him, to see who could get the other to cum first. You can feel that as you speed up your touch, he does the same to you as you can hear his moans of pleasure getting louder and louder. You can feel how your body starts to get warmer and your own body feels the urge to cum increasing as Yoshika plays with your cock and balls with surprising ability.\n";
				PAR3 = "<i>\"I can't lose...\"</i> He could barely say between moans. You stay silent for a pair of seconds on purpose, as you can feel his cock twitching and pulsing for release. After a bit of you holding your own, you can feel his grip getting tighter as he trembles and begin to cream himself inside his pants. You can feel the thickness of his sperm soaking your hand as he fills his underwear with his own fluids. The sweet taste of victory finally feels amazing, making you spurt a streak of cum over the back of his ass and into the floor in front of him"+ PAR3L1 +".";
				PAR4 = "When he finishes orgasming, you can see that his stance goes limp, he barely holds himself standing. You take a step back and clean yourself with a rag that is close to him. You leave it in his desk and tell him that you will see him again soon. He turns and smiles at your words as he smears the cum he has on his ass, trying to tease you, before licking his hand. <i>\"This kind of training is quite fun, my liege\"</i> You leave him to clean the place up, closing the door behind you, your energies renewed. ";

			} else if ( GameControl.hasVagina == true) {

				PAR1 = "You tell him as you tease his cock with your hand, that maybe you can get some help from him too. He trembles a bit from your touch but agrees to it. He starts groping your lower body, feeling your legs as he tries to find your groin, which is hard due to your touch making him harder to focus. It is exciting to see him having trouble to follow your statements as the pleasure flows to him more and more from your caressing. You can feel his cock growing with each stroke of your hand, until is fully erect.";
				PAR2 = "But finally he reaches your groin, desperately trying to get his hand inside your lower clothing. He grabs your already wet cunt and starts rubbing it with lust, as he started panting from all the stimulation. You can feel that despite his lack of focus, his touch is soft and pleasurable. His strong hand is quite capable of fingering you from that position and for the time it could take. You make it a challenge against him, to see who could get the other to cum first. You can feel that as you speed up your touch, he does the same to you as you can hear his moans of pleasure getting louder and louder. You can feel how your body starts to get warmer and your own body feels the urge to cum increasing as Yoshika plays with your pussy and clit, making the challenge harder with each rub.";
				PAR3 = "<i>\"I can't lose...\"</i> He could barely say between moans. You stay silent for a pair of seconds on purpose, as you can feel his cock twitching and pulsing for release.  After a bit of you holding your own, you can feel his grip getting tighter as he trembles and begin to cream himself inside his pants. You can feel the thickness of his sperm soaking your hand as he fills his underwear with his own fluids. The sweet taste of victory and the fact that you've been holding your orgasm for a lot of time, made you slide a streak of femcum over the floor in front of him and below you.";
				PAR4 = "When he finishes orgasming, you can see that his stance goes limp, he barely holds himself standing. You take a step back and clean yourself with a rag that is close to him. You leave it in his desk and tell him that you will see him again soon. He turns and smiles at your words as he smears the cum he has on his ass, trying to tease you, before licking his hand. <i>\"This kind of training is quite fun, my liege</i> You leave him to clean the place up, closing the door behind you, your energies renewed.";

			} else {
				PAR1 = "no scene for asexuals yet sorry"; 
			}

			Board.text = PAR0 + PAR1 + PAR2 + PAR3 + PAR4 ;

		} else {
			// dick
			if (GameControl.dick1Size > 0 ) {
				Board.text = "You wondered how Yoshika is doing, as you feel the urge to pay him a visit, with a clear intention in your mind: To relax a bit with the deer that you know well. The place is almost empty, probably it is just a low day like any other. You found the stag sitting in a bench and looking around the gymnasium, probably resting a bit.\n\nYou go close to him, and he notices you, nodding a bit as you get closer. -Good day, my " + mcpronoun+". How can i be of service?- He says with a helpful tone. You know how much of an obedient worker he is, so you decided to take a bit of advantage of the deer you have in front of you, but you aren’t planning on being selfish, or at least not in the usual meaning of the word.\n\nSo, you grab his attention and point to the office with your head, motion he understands perfectly. He stands up and follows you closely until both of you are inside the office room of the gym, then you close the door behind you. You can see that Yoshika is still turning his back to you, probably waiting further instructions.\n\nYou place yourself behind him and ran your hands over his body, enjoying the firmness of his muscles and the overall toughness of his whole corporeal frame. It's so exciting that someone so strong can be so compliant to you. -What do you want me to do?- You hear meekly from the stag in front of you, at which you didn’t answer. You shove your hand inside his pants, rubbing his crotch with assertiveness, feeling his dick and balls between your fingers.\n\nYou tell him as you tease his cock with your hand, that he must give you a handjob from that position, without turning around and only using his hands. He trembles a bit from your touch but agrees to it. He starts groping your lower body, feeling your legs as he tries to find your groin, which is hard due to your touch making him harder to focus. It is exciting to see him having trouble to follow your statements as the pleasure flows to him more and more from your caressing. You can feel his cock growing with each stroke of your hand, until is fully erect.\n\nBut finally he reaches your groin, desperately trying to get his hand inside your lower clothing. He grabs your dick and starts stroking it with lust, as he started panting from all the stimulation. You can feel that despite his lack of focus, his touch is soft and pleasurable. His strong hand is quite capable of jerking you off from that position and for the time it could take. You make it a challenge against him, to see who could get the other to cum first. You can feel that as you speed up your touch, he does the same to you as you can hear his moans of pleasure getting louder and louder. You can feel how your body starts to get warmer and your own body feels the urge to cum increasing as Yoshika plays with your cock and balls with surprising ability.\n\n-My " + mcpronoun+", C-Can i cum?- He could barely asks between moans. You stay silent for a pair of seconds on purpose, as you can feel his cock twitching and pulsing for release. When you say that he has permission, you can feel his grip getting tighter as he trembles and begin to cream himself inside his pants. You can feel the thickness of his sperm soaking your hand as he fills his underwear with his own fluids. The thought of his compliance push you to the edge, making you spurt a streak of cum over the back of his ass and into the floor in front of him.\n\nWhen he finishes orgasming, you can see that his stance goes limp, he barely holds himself standing. You take a step back and clean yourself with a rag that is close to him. You toss it into his desk and tell him that you will see him again soon. He turns and smiles at your words as he kneels in the floor and runs a hand over your cum, then licks it. -I will be waiting for it, my " + mcpronoun+ " - You leave him to clean the place up, closing the door behind you, your energies renewed. ";

			} else if ( GameControl.hasVagina == true) {

				Board.text = "You wondered how Yoshika is doing, as you feel the urge to pay him a visit, with a clear intention in your mind: To relax a bit with the deer that you know well. The place is almost empty, probably it is just a low day like any other. You found the stag sitting in a bench and looking around the gymnasium, probably resting a bit.\n\nYou go close to him, and he notices you, nodding a bit as you get closer. -Good day, my "  + mcpronoun +  ". How can i be of service?- He says with a helpful tone. You know how much of an obedient worker he is, so you decided to take a bit of advantage of the deer you have in front of you, but you aren’t planning on being selfish, or at least not in the usual meaning of the word.\n\nSo, you grab his attention and point to the office with your head, motion he understands perfectly. He stands up and follows you closely until both of you are inside the office room of the gym, then you close the door behind you. You can see that Yoshika is still turning his back to you, probably waiting further instructions.\n\nYou place yourself behind him and ran your hands over his body, enjoying the firmness of his muscles and the overall toughness of his whole corporeal frame. It's so exciting that someone so strong can be so compliant to you. -What do you want me to do?- You hear meekly from the stag in front of you, at which you didn’t answer. You shove your hand inside his pants, rubbing his crotch with assertiveness, feeling his dick and balls between your fingers.\n";
				Board.text = Board.text + "You tell him as you tease his cock with your hand, that he must give you a fingerjob from that position, without turning around and only using his hands. He trembles a bit from your touch but agrees to it. He starts groping your lower body, feeling your legs as he tries to find your groin, which is hard due to your touch making him harder to focus. It is exciting to see him having trouble to follow your statements as the pleasure flows to him more and more from your caressing. You can feel his cock growing with each stroke of your hand, until is fully erect.\n\nBut finally he reaches your groin, desperately trying to get his hand inside your lower clothing. He grabs your already wet cunt and starts rubbing it with lust, as he started panting from all the stimulation. You can feel that despite his lack of focus, his touch is soft and pleasurable. His strong hand is quite capable of fingering you from that position and for the time it could take. You make it a challenge against him, to see who could get the other to cum first. You can feel that as you speed up your touch, he does the same to you as you can hear his moans of pleasure getting louder and louder. You can feel how your body starts to get warmer and your own body feels the urge to cum increasing as Yoshika plays with your pussy and clit, making the challenge harder with each rub.\n\n-C-Can i cum?- He could barely asks between moans. You stay silent for a pair of seconds on purpose, as you can feel his cock twitching and pulsing for release. When you say that he has permission, you can feel his grip getting tighter as he trembles and begin to cream himself inside his pants. You can feel the thickness of his sperm soaking your hand as he fills his underwear with his own fluids. The thought of his compliance push you to the edge, making you slide a streak of femcum over the floor in front of him and below you.\n\nWhen he finishes orgasming, you can see that his stance goes limp, he barely holds himself standing. You take a step back and clean yourself with a rag that is close to him. You toss it into his desk and tell him that you will see him again soon. He turns and smiles at your words as he kneels in the floor and runs a hand over your cum, then licks it. -I will be waiting for it, my "  + mcpronoun +  "- You leave him to clean the place up, closing the door behind you, your energies renewed. \n"; 
			} else {
				Board.text = "No scene for asexuals yet, sorry."; 
			}


		}

	}


	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	public void scene2(){




		GameControl.actualArousal = 0; 

		endTurnFun ();


		if (NPCCharList.CharFollower[iYoshika].corruptionStage <= 1 )
		{

			string PAR0 = "";
			string PAR1 = "";
			string PAR2 = "";
			string PAR3 = "";
			string PAR4 = "";

			string PAR1L1 = "";
			string PAR1L2 = "";
			string PAR3L1 = "";
			// dick
			PAR0 = "You wanted nothing more than to visit Yoshika, as you wanted to see how he has been since the last time you've seen him. So, you pay him a visit in the gym. Lucky for you, the place is almost empty, as most patrons are gone for the day. You can see that Yoshika is training in a bench, slowly lifting a kettlebell. You can see his tight pants pressing against his ass as he is forcing the weight up and down. So, you quickly close the entrance of the gym with your master key before anyone else tries to enter and approached your horned objective\n\nYou can see that he is having trouble lifting the weight, so you asked him how he is doing with that. You can see that Yoshika jolted as he heard you, but when he turned to see you from that position, he sighs. <i>\"I’m having a bit of trouble with the weight, my liege. But just gimme a second\"</i> He says, as he tries once more, without much progress. You tell him that you can help him feel better at least. <i>\"What do you mean?\"</i> He asks, but you are busier with his ass, almost as if he is presenting it to you.\n\nYou rub it completely, making him groan a bit his squeal echoing through the place. You tell him to continue his lifting, at which he smiles at you with complicity and tries once more to lift the weight. You lower his pants, exposing his tight anus, as you tease it with one of your fingers. You can hear him moan once, as he releases his grip on the kettlebell. You tell him that he should continue his training until he ends it, because he has other plans for his ass.";
			if (GameControl.dick1Size > 0 ) {
				if (GameControl.testiclesSize > 0) {
					PAR1L1 = " cock along with your balls";
				}
				if (GameControl.hasVagina == true) {
					PAR1L2 = ", as your cunt is moist, waiting to be rubbed against the deer's ass";
					PAR3L1 = " as your cunt soaks his thighs and the floor beneath you at the same time";
				}

				PAR1 = "You undress your lower half, exposing your"+ dickSize  + " "+ dickRace +""+ PAR1L1 +""+ PAR1L2 +". You squeeze one of his buttocks, as he wiggles his ass a bit as he feels your touch. You tell him that you found a way to motivate him to continue his exercises. You spread him with both hands and press your cock against the crown of his pucker, your cock already dripping with a bit of precum from the teasing of him. You can see that the sensation unbalance him, making him throw the lift. ";
				PAR2 = "Before he could even take it back, you push your cock inside his ass, making him moan in a mix of discomfort and pleasure and get to fuck his athletic rear. You tell him to continue his lifting, enjoying the sensation that his insides wrapping around your cock causes. Every time he tries to force the lift up, you can feel his ass squeezing your cock with a delightful tightness that almost teases your dick to cum, and the relaxation that happens when he lowers it.";
				PAR3 = "You can hear him moaning and see that his cock is already dripping precum into the bench. From time to time, he drops the lift into the ground and starts to stroke his own cock, something that makes you smile as you let him be. He whimpers with frustration as he feels your cock pounding him hard, letting you fuck him at your leisure, as he tried to focus on his training and not on the cock that is ramming him with force. After a bit of clamping over your cock, you can’t resist the urge to cum, filling the bending stag’s insides with your viscous cum, pushing your cock as far as you can inside him so he couldn’t spill a drop from your spunk"+ PAR3L1 +". He pushes his ass against you as your filling of his rectum made him moan in delight, throwing the lift aside and clasping the bench as he trembles for release.";
				PAR4 = "You can see that his stroking helped him, as he finally get to cum hard. He didn’t even mind that the floor is getting full of stag’s cum. His whole body goes limp, pushing him aside from the bench and finally getting himself unstuck. He raises his pants, trying not to spill much of your cum from inside him. You tell him that he needs more training, to which he smiles as he tries to recover his breath. <i>\"You're such a tease, "+ GameControl.playerName +". Maybe someday I'll pay it back. That would be fun\"</i> He says, as you go back to the door and unlock it. You can see that there are some people waiting for the door to open. They move aside as you pass and enter with Yoshika. You smile at you work with the stag and leave the place, satisfied.";

			} else if ( GameControl.hasVagina == true) {
				PAR1 = "You undress your lower half, exposing your pussy. From your clothing, you take out your strap-on. You squeeze one of his buttocks, as he wiggles his ass a bit as he feels your touch. You tell him that you found a way to motivate him to continue his exercises. You spread him with both hands, spit a bit against the strap and press it against the crown of his pucker. You can see that the sensation unbalance him, making him throw the lift. ";
				PAR2 = "Before he could even take it back, you push your strap inside his ass, making him moan in a mix of discomfort and pleasure and get to fuck his athletic rear. You tell him to continue his lifting, to follow your game. Every time he tries to force the lift up, you can see the muscles of his ass squeezing your strap and the relaxation of them that happens when he lowers it.";
				PAR3 = "You can hear him moaning and see that his cock is already dripping precum into the bench. From time to time, he drops the lift into the ground and starts to stroke his own cock, something that makes you smile as you let him be. He whimpers with frustration as he feels your cock pounding him hard, letting you fuck him at your leisure, as he tried to focus on his training and not on the strap that is ramming him with force. After looking at the poor stag’s not capable of cumming and the fact that you're taking playing with him a bit, you can’t resist the urge to cum, filling your thighs and legs with femspunk. He pushes his ass against you as your own moans of pleasure due to your orgasm made him moan in delight, throwing the lift aside and clasping the bench as he trembled for release.";
				PAR4 = "You can see that his stroking helped him, as he finally get to cum hard. He didn’t even mind that the floor is getting full of stag’s cum. His whole body goes limp, pushing him aside from the bench and finally getting himself unstuck. He raises his pants, that now are a bit soaked from your own juices. You tell him that he needs more training, to which he smiles as he tries to recover his breath. <i>\"You're such a tease, "+ GameControl.playerName +". Maybe someday I'll pay it back. That would be fun\"</i> He says, as you go back to the door and unlock it. You can see that there are some people waiting for the door to open. They move aside as you pass and enter with Yoshika. You smile at you work with the stag and leave the place, satisfied.";
			} else {
				PAR1 = "no scene for asexuals yet"; 
			}
			Board.text = PAR0 + PAR1 + PAR2 + PAR3 + PAR4 ;



		} else {
			// dick
			if (GameControl.dick1Size > 0    && GameControl.charArmorTags [1] != true && GameControl.charArmorTags [2] != true) {

				Board.text = "You decide to pay your favorite deer a visit at his work. Not because you wanted to bother him, but because you can’t wait to enjoy him in the way you are thinking of. So, you pay him a visit in the gym. Lucky for you, the place is almost empty. You can see that Yoshika is training in a bench, slowly lifting a kettlebell. You can see his tight pants pressing against his ass as he is forcing the weight up and down. So, you quickly close the entrance of the gym with your master key before anyone else tries to enter and approached your horned target.\n\nYou can see that he is having trouble lifting the weight, so you asked him how he is doing with that. You can see that Yoshika jolted as he heard you, but when he turned to see you from that position, he sighs. -I’m having a bit of trouble, my "  + mcpronoun +  ". But i can handle this- He says, as he tries once more, without much progress. You say that you can’t lose the opportunity. -What do you mean?- He asks, but you are busier with his ass, almost as if he is presenting it to you.\n\nYou spank him with force, making him groan a bit, the spank echoing through the room. You tell him to continue his lifting, at which he nods yieldingly and tries once more. You lower his pants, exposing his tight anus, as you tease it with one of your fingers. You can hear him moan once, as he releases his grip on the kettlebell. You tell him that he should continue his training until he ends it, because he has other plans for his ass.\n\nYou undress your lower half, exposing your cock along with your balls. You squeeze one of his buttocks, the one that is still a bit red from the spank. You tell him that you found a way to motivate him to continue his exercises. You spread him with both hands and press your cock against the crown of his pucker, your cock already dripping with a bit of precum from the teasing of him. You can see that the sensation unbalance him, making him throw the lift. \n\nBefore he could even take it back, you push your cock inside his ass, making him moan in a mix of discomfort and pleasure and get to fuck his athletic rear. You instruct him to continue his lifting, enjoying the sensation that his insides wrapping around your cock caused. Every time he tries to force the lift up, you can feel his ass squeezing your cock with a delightful tightness that almost teases your cock to cum and the relaxation that happens when he lowers it.\n\nYou can hear him moaning and see that his cock is already dripping precum into the bench. From time to time, he drops the lift into the ground and tried to stroke his cock. You spank him hard and instruct him that he can finish when the exercises are finished. He whimpers a bit and complies to your bidding, letting you fuck him at your leisure, as he tried to focus on his training and not on the cock that is ramming him with force. After a bit of clamping over your cock, you can’t resist the urge to cum, filling the bending stag’s insides with your viscous cum, pushing your cock as far as you can inside him so he couldn’t spill a drop from your spunk. He pushes his ass against you as your filling of his rectum made him moan in delight, throwing the lift aside and clasping the bench as he trembled for release.\n\nYou can see that he strokes himself desperately in that position, until he can finally cum too. He didn’t even mind that the floor is getting full of stag’s cum. His whole body goes limp, pushing him aside from the bench and finally getting himself unstuck. He raises his pants, trying not to spill much of your cum from inside him. You tell him that he needs more training, to which he smiles as he tries to recover his breath. -I can’t wait for the next help for my exercises, my "  + mcpronoun +  "- He says, as you go back to the door and unlock it. You can see that there are some people waiting for the door to open. They move aside as you pass and enter with Yoshika. You smile at you work with the stag and leave the place, satisfied.\n";
				charVirginity();
			} else if ( GameControl.hasVagina == true) {

				Board.text = "You decide to pay your favorite deer a visit at his work. Not because you wanted to bother him, but because you can’t wait to enjoy him in the way you are thinking of. So, you pay him a visit in the gym. Lucky for you, the place is almost empty. You can see that Yoshika is training in a bench, slowly lifting a kettlebell. You can see his tight pants pressing against his ass as he is forcing the weight up and down. So, you quickly close the entrance of the gym with your master key before anyone else tries to enter and approached your horned target.\n\nYou can see that he is having trouble lifting the weight, so you asked him how he is doing with that. You can see that Yoshika jolted as he heard you, but when he turned to see you from that position, he sighs. -I’m having a bit of trouble, my "  + mcpronoun +  ". But i can handle this- He says, as he tries once more, without much progress. You say that you can’t lose the opportunity. -What do you mean?- He asks, but you are busier with his ass, almost as if he is presenting it to you.\n\nYou spank him with force, making him groan a bit, the spank echoing through the room. You tell him to continue his lifting, at which he nods yieldingly and tries once more. You lower his pants, exposing his tight anus, as you tease it with one of your fingers. You can hear him moan once, as he releases his grip on the kettlebell. You tell him that he should continue his training until he ends it, because he has other plans for his ass.\n\n"; 
				Board.text = Board.text + "You undress your lower half, exposing your pussy. From your clothing, you take out your strap-on. You squeeze one of his buttocks, the one that is still a bit red from the spank. You tell him that you found a way to motivate him to continue his exercises. You spread him with both hands, spit a bit against the strap and press it against the crown of his pucker. You can see that the sensation unbalance him, making him throw the lift. \n\nBefore he could even take it back, you push your strap inside his ass, making him moan in a mix of discomfort and pleasure and get to fuck his athletic rear. You instruct him to continue his lifting. Every time he tries to force the lift up, you can see the muscles of his ass squeezing your strap and the relaxation of them that happens when he lowers it.\n\nYou can hear him moaning and see that his cock is already dripping precum into the bench. From time to time, he drops the lift into the ground and tried to stroke his cock. You spank him hard and instruct him that he can finish when the exercises are finished. He whimpers a bit and complies to your bidding, letting you fuck him at your leisure, as he tried to focus on his training and not on the strap that is ramming him with force. After looking at the poor stag’s not capable of cumming and the power you have over him, you can’t resist the urge to cum, filling your thighs and legs with femspunk. He pushes his ass against you as your own moans of pleasure due to your orgasm made him moan in delight, throwing the lift aside and clasping the bench as he trembled for release.\n\nYou can see that he strokes himself desperately in that position, until he can finally cum too. He didn’t even mind that the floor is getting full of stag’s cum. His whole body goes limp, pushing him aside from the bench and finally getting himself unstuck. He raises his pants, that now are a bit soaked from your own juices. You tell him that he needs more training, to which he smiles as he tries to recover his breath. -I can’t wait for the next help for my exercises, my "  + mcpronoun +  "- He says, as you go back to the door and unlock it. You can see that there are some people waiting for the door to open. They move aside as you pass and enter with Yoshika. You smile at you work with the stag and leave the place, satisfied.\n\n";
			} else {
				Board.text = "No scene for asexuals or chaste yet, sorry."; 
			}


		}

	}



	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	public void scene3(){



		GameControl.actualArousal = 0; 

		endTurnFun ();


		if (NPCCharList.CharFollower[iYoshika].corruptionStage <= 2)
		{

			// dick
			if (GameControl.dick1Size > 0 ) {
				Board.text = "You wanted nothing more at that moment, than to have a moment of intimacy with Yoshika. These days have been quite hard, and you know that enjoying the tender flesh and renewing scent of the stag can do the trick. And so, you arrive at the gym and ask the other staff where the gym manager is. You know that they usually would invent something on the fly, but when they see who you are, they point you to the changing room, that he is cleaning himself.\n\nSo, you seize the opportunity and walk inside the changing rooms. You know that he always washes himself when there is no one else at the time, so you know that he will be alone. So, you get to undress your "+ ItemData.itemDataList [GameControl.charEquipment [1]].itemName + " and try to make your way into the washing rooms with stealth. After a bit of walking inside, you found out Yoshika completely naked, who is sitting  as he is washing himself, as you can see his toned muscles of his back as he washes off the sweat with a rag.\n\nYou sneak behind him, until you are half step away from his back. After that, you push your body against his back and embrace him, rubbing his masculine body with your hands. He jolts one second and drops the rag into the floor. -"  + GameControl.playerName + "?- You say his name as your hands are marking roads through his body continuously. He grabs your hands and pushes himself against your body, marking his athletic ass against your crotch and belly. -I love how you feel, dear- You grab his cock with one of your hands and stroke it repeatedly, making it hard more and more. -Perhaps i can make one more workout before washing...- He turns to face you, embracing you as his hands get to touch your whole silhouette, rubbing his wet skin against your body.\n\nYou grab one of his hands and place it over your pussy, and he doesn’t need more, as he starts to use his fingers to tease it, rubbing it slowly as you are still stroking his cock. When you feel that you are wet enough and that he is rock hard, you push him slowly with both hands into the ground, to which he doesn’t resist that much. After that, you get to tease his cock a bit with your wet snatch, rubbing it against each other as you look at his face. -Come on dear... people has to use the washing room.- He says with his eyes closed, enjoying the sensation definitely.\n\nYou impale yourself with his cock, pushing him inside you as you hold yourself from his shoulders and look at him in the face. You can feel every inch of his cock rubbing against your nether walls, as the stag gets a hold of your ass and squeeze it with his strong hands. -You’ve been fighting lately? You feel stronger...- You can hear his small antlers wildly hitting against the ground each time you bounce over his palpitating cock. The fact that his usual scent is diluted in water, makes the scent of his precum mixed with your sexual fluids more strong, the smell of your lovemaking filling the air around both of you.\n\nYou can hear him moaning in a low tone as he pushed his hips against your snatch from time to time, as you enjoy his eagerness to push his meat inside you. You can’t help but get hornier just by looking his own face of desire as he pummels his shaft inside you in the washing rooms. You are sure that someone heard something, but they saw you enter and probably didn’t want trouble.\n\nYou can feel Yoshika’s body trembling as he starts to cum inside you, his body arching a bit as his hot seed gets to flow into your insides with his viscous cum and paint them white. The hot sensation fills your mind with pleasure, as you can’t hold back your orgasm one second more. You cum hard over his cock, your greedy snatch milking the deer’s dick as much as it can. When both of you were finally spent, you see the rag next to you. You take it and start to clean the new coat of sweat that covers the both of you.\n\nHe snickers and help you to pull a second rag that was above him, using his small antlers. -Gotta use them for something- He said, before cleaning you with it. They both help each other to wash themselves. He kiss you passionately goodbye as you dress yourself back, telling him that you have things to do. He smacks your thighs one time before returning to the gym’s office.\n";
				Board.text = Board.text + "You grab one of his hands and place it over your ass, and he doesn’t need more, as he starts to use his fingers to tease it, rubbing it slowly and preparing it as you are still stroking his cock. When you feel that you are expanded enough and that he is rock hard, you push him slowly with both hands into the ground, to which he doesn’t resist that much. After that, you get to tease his cock a bit with your buttocks, rubbing it against each others as you look at his face. -Come on dear... people has to use the washing room.- He says with his eyes closed, enjoying the sensation definitely.\n\nYou impale yourself with his cock, pushing him inside you as you hold yourself from his shoulders and look at him in the face. You can feel every inch of his cock rubbing against your rectum walls, as the stag gets a hold of your ass and squeeze it with his strong hands. -You’ve been fighting lately? You feel stronger...- You can hear his small antlers wildly hitting against the ground each time you bounce over his palpitating cock. The fact that his usual scent is diluted in water, makes the scent of his precum mixed with your sexual fluids more strong, the smell of your lovemaking filling the air around both of you.\n\nYou can hear him moaning in a low tone as he pushed his hips against your anus from time to time, as you enjoy his eagerness to push his meat inside you. You can’t help but get hornier just by looking his own face of desire as he pummels his shaft inside you in the washing rooms. You are sure that someone heard something, but they saw you enter and probably don’t want trouble.\n\nYou can feel Yoshika’s body trembling as he starts to cum inside you, his body arching a bit as his hot seed gets to flow into your insides with his viscous cum and paint them white. The hot sensation fills your mind with pleasure, as you can’t hold back your orgasm one second more. You cum hard over his cock, your greedy pucker milking the deer’s dick as much as it can. When both of you were finally spent, you see the rag next to you. You take it and start to clean the new coat of sweat that covers the both of you.\n\nHe snickers and help you to pull a second rag that was above him, using his small antlers. -Gotta use them for something- He said, before cleaning you with it. They both help each other to wash themselves. He kiss you passionately goodbye as you dress yourself back, telling him that you have things to do. He smacks your thighs one time before returning to the gym’s office.\n\n"; 

			} else if ( GameControl.hasVagina == true && GameControl.charArmorTags [1] != true && GameControl.charArmorTags [2] != true) {

				Board.text = "You wanted nothing more at that moment, than to have a moment of intimacy with Yoshika. These days have been quite hard, and you know that enjoying the tender flesh and renewing scent of the stag can do the trick. And so, you arrive at the gym and ask the other staff where the gym manager is. You know that they usually would invent something on the fly, but when they see who you are, they point you to the changing room, that he is cleaning himself.\n\nSo, you seize the opportunity and walk inside the changing rooms. You know that he always washes himself when there is no one else at the time, so you know that he will be alone. So, you get to undress your " + ItemData.itemDataList [GameControl.charEquipment [1]].itemName +" and try to make your way into the washing rooms with stealth. After a bit of walking inside, you found out Yoshika completely naked, who is sitting  as he is washing himself, as you can see his toned muscles of his back as he washes off the sweat with a rag.\n\nYou sneak behind him, until you are half step away from his back. After that, you push your body against his back and embrace him, rubbing his masculine body with your hands. He jolts one second and drops the rag into the floor. -" + GameControl.playerName + "?- You say his name as your hands are marking roads through his body continuously. He grabs your hands and pushes himself against your body, marking his athletic ass against your crotch and belly. -I love how you feel, dear- You grab his cock with one of your hands and stroke it repeatedly, making it hard more and more. -Perhaps i can make one more workout before washing...- He turns to face you, embracing you as his hands get to touch your whole silhouette, rubbing his wet skin against your body.\n\nYou grab one of his hands and place it over your pussy, and he doesn’t need more, as he starts to use his fingers to tease it, rubbing it slowly as you are still stroking his cock. When you feel that you are wet enough and that he is rock hard, you push him slowly with both hands into the ground, to which he doesn’t resist that much. After that, you get to tease his cock a bit with your wet snatch, rubbing it against each other as you look at his face. -Come on dear... people has to use the washing room.- He says with his eyes closed, enjoying the sensation definitely.\n\nYou impale yourself with his cock, pushing him inside you as you hold yourself from his shoulders and look at him in the face. You can feel every inch of his cock rubbing against your nether walls, as the stag gets a hold of your ass and squeeze it with his strong hands. -You’ve been fighting lately? You feel stronger...- You can hear his small antlers wildly hitting against the ground each time you bounce over his palpitating cock. The fact that his usual scent is diluted in water, makes the scent of his precum mixed with your sexual fluids more strong, the smell of your lovemaking filling the air around both of you.\n\nYou can hear him moaning in a low tone as he pushed his hips against your snatch from time to time, as you enjoy his eagerness to push his meat inside you. You can’t help but get hornier just by looking his own face of desire as he pummels his shaft inside you in the washing rooms. You are sure that someone heard something, but they saw you enter and probably didn’t want trouble.\n\nYou can feel Yoshika’s body trembling as he starts to cum inside you, his body arching a bit as his hot seed gets to flow into your insides with his viscous cum and paint them white. The hot sensation fills your mind with pleasure, as you can’t hold back your orgasm one second more. You cum hard over his cock, your greedy snatch milking the deer’s dick as much as it can. When both of you were finally spent, you see the rag next to you. You take it and start to clean the new coat of sweat that covers the both of you.\n\nHe snickers and help you to pull a second rag that was above him, using his small antlers. -Gotta use them for something- He said, before cleaning you with it. They both help each other to wash themselves. He kiss you passionately goodbye as you dress yourself back, telling him that you have things to do. He smacks your thighs one time before returning to the gym’s office.\n"; 
				charVirginity();
			} else {
				Board.text = "Sorry, no content yet for eunuch or this armor yet, sorry!"; 
			}



		} else {
			// dick
			if (GameControl.dick1Size > 0  ) {
				Board.text = "You have a special craving that you wanted to test with Yoshika, but this time you require to be away from the gym, even a bit far from the city. You explain to him that he must be in an hour, at the edge of the city, that he won’t require anything else than his usual clothing that time.\n\nYou arrive at the given time, finding out that the deer is already in the place, waiting patiently. You tell him that you hope he hasn’t been waiting for too long. You can hear him answering you without lifting his gaze from the ground. -You never make me wait, my "  + mcpronoun +  ". You are never late, only I am at time or late- You can see that he is halfway trained for someone to assert its dominance over him.\n\nYou explain to him, that you wanted to roleplay a bit. You can see him wondering a bit about your words, but you don’t give him enough time to ponder about it. You tell him that you want to feel what it is like to be Guardian Prince of the Forest and that he can be a whore that he saved from danger. You can see that hearing his role in that act his eyes got full of excitement but his eyes are being painted with guilt. -But that’s...- You ask him if he has anything to object, that you will hear it. He shakes his head. -Nothing...-\n\nThen you tell him to undress and to give you his clothing. He does what you saw and gets naked pretty quickly, as you can see that his body is quite muscular, yet athletic. After he finishes undressing, you take his clothing and instruct him to get ready to play his role, as you walk away and swap your clothing with the one he gave you. After a bit, you walk back to Yoshika and start acting your part in this. “You are out of danger, citizen. I, " + GameControl.playerName + ", the Prince Guardian of the Forest have rescued you from danger.”\n\nYou can see that the eyes of Yoshika are almost like those of another person. His stance and mannerisms changed quite suddenly, as if his mind is prone to fantasize in a vivid way.  -Oh, my saviour! But i’m only a common slut… I only know one way to pay you...- He says, as he slowly rubs your groin. “It would be an insult to decline such an offer of gratitude.” So, you push him to his knees and look at him in the eye. -Then pay your respect to your savior...-\n\nYou can see how he starts to pant by your treatment to him. He moves the robe just enough to expose your dick and rub it. -Suck a heroic cock- He says before licking it and stroking it like if he were a true slut, craving for your cock with such desire that you’re almost sure that it's completely authentic. You can see how he slurps all the precum that slips off the tip of your dick, looking at you in the eye with pride.\n\nFinally, he engulfs it as much as he can, it's small antlers giving you a good place to hold his head. You use these handles to push your cock inside his mouth and throat, as you can see how his eyes raise to the back of his head in delight, as you push your cock flesh into his throat for a second before pulling back into his mouth. He grabs your legs with force before rocking his head back and forth, sucking your cock with desperation. “What are you?” You say out loud, between your own short breathing. He pulls out just enough to answer, without stopping stroking your shaft. -I’m a slut! I crave cocks and pussies- He says, before returning to suck your cock.\n\nThe thought that maybe this is how he lost his memories, turns you on for a second. So the Plague was turning him into a needy and perverted stag. And the thought that this is something that now you are doing it, excites you. That he can be molded to be the submissive guy that anyone would want, makes you tremble. Combined with the great efforts of the slut that you have in front of you, you can feel how you are in the verge of orgasm. Somehow, Yoshika feels this and pulls out his mouth, opening wide to be the receptacle of your fluids.\n\nYou spurt all over his face, as he tries to make that most of your spunk falls into his mouth. The rest soaks his firm chest and his hair. He swallows as much as he can, but some of it drips into the floor and into his groin. You can see that he cums hard on the floor as he gulps load after load of your cum, until there is nothing left in your balls.\n\nAfter that, his face slowly returns to the one you remember from Yoshika. He falls into his back, his face embedded in a constant state of lust. You undress his clothing and place them over his cum-soaked body. You dress once more your " + ItemData.itemDataList [GameControl.charEquipment [1]].itemName + " and decide that you’ll send someone from the manor to help him back into the gym. For now, you have other things to do.\n"; 

			} else if ( GameControl.hasVagina == true) {
				Board.text = "You have a special craving that you wanted to test with Yoshika, but this time you require to be away from the gym, even a bit far from the city. You explain to him that he must be in an hour, at the edge of the city, that he won’t require anything else than his usual clothing that time.\n\nYou arrive at the given time, finding out that the deer is already in the place, waiting patiently. You tell him that you hope he hasn’t been waiting for too long. You can hear him answering you without lifting his gaze from the ground. -You never make me wait, my "  + mcpronoun +  ". You are never late, only I am at time or late- You can see that he is halfway trained for someone to assert its dominance over him.\n\nYou explain to him, that you wanted to roleplay a bit. You can see him wondering a bit about your words, but you don’t give him enough time to ponder about it. You tell him that you want to feel what it is like to be Guardian Prince of the Forest and that he can be a whore that he saved from danger. You can see that hearing his role in that act his eyes got full of excitement but his eyes are being painted with guilt. -But that’s...- You ask him if he has anything to object, that you will hear it. He shakes his head. -Nothing...-\n\nThen you tell him to undress and to give you his clothing. He does what you saw and gets naked pretty quickly, as you can see that his body is quite muscular, yet athletic. After he finishes undressing, you take his clothing and instruct him to get ready to play his role, as you walk away and swap your clothing with the one he gave you. After a bit, you walk back to Yoshika and start acting your part in this. “You are out of danger, citizen. I, "  + GameControl.playerName + ", the Prince Guardian of the Forest have rescued you from danger.”\n\nYou can see that the eyes of Yoshika are almost like those of another person. His stance and mannerisms changed quite suddenly, as if his mind is prone to fantasize in a vivid way.  -Oh, my saviour! But i’m only a common slut… I only know one way to pay you...- He says, as he slowly rubs your groin. “It would be an insult to decline such an offer of gratitude.” So, you push him to his knees and look at him in the eye. -Then pay your respect to your savior...-\n"; 
				Board.text = Board.text + "You can see how he starts to pant by your treatment to him. He moves the robe just enough to expose your cunt and rub it. -Suck a heroic pussy- He says before licking it and rubbing it like if he were a true slut, craving for your snatch with such desire that you’re almost sure that it's completely authentic. You can see how he slurps all the juices that slips off the lips of your pussy, looking at you in the eye with pride.\n\nFinally, he uses his tongue to push it inside as much as he can, it's small antlers giving you a good place to hold his head. You use these handles to push his nose inside your pussy, as you can see how his eyes raise to the back of his head in delight, as you push your pussy flesh into his face for a second before pulling back. He grabs your legs with force before rocking his head forth, trying to tease your nether walls with desperation. “What are you?” You say out loud, between your own short breathing. He pulls out just enough to answer, without stopping the rubbing of your clit and twat. -I’m a slut! I crave cocks and pussies- He says, before returning to licking.\n\nThe thought that maybe this is how he lost his memories, turns you on for a second. So the Plague was turning him into a needy and perverted stag. And the thought that this is something that now you are doing it, excites you. That he can be molded to be the submissive guy that anyone would want, makes you tremble. Combined with the great efforts of the slut that you have in front of you, you can feel how you are in the verge of orgasm. Somehow, Yoshika feels this and push his mouth against it, opening wide to be the receptacle of your fluids.\n\nYou cum all over his face, as he tries to make that most of your femcum falls into his mouth. The rest soaks his firm chest and his hair. He swallows as much as he can, but some of it drips into the floor and into his groin. You can see that he cums hard on the floor as he licks more and more your fluids, until he can no more.\n\nAfter that, his face slowly returns to the one you remember from Yoshika. He falls into his back, his face embedded in a constant state of lust. You undress his clothing and place them over his cum-soaked body. You dress once more your "+ ItemData.itemDataList [GameControl.charEquipment [1]].itemName +" and decide that you’ll send someone from the manor to help him back into the gym. For now, you have other things to do.\n"; 

			} else {
				Board.text = "No scene for asexuals yet, sorry."; 
			}


		}



	}


	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


	public void scene4(){


		GameControl.actualArousal = 0; 

		endTurnFun ();


		if (NPCCharList.CharFollower[iYoshika].corruptionStage <= 3)
		{
			Board.text = "You pay a visit to Yoshika, to see how he is going with all the stuff going on through his head on the past days. You find him training in the gym, but this time he is doing some training combat in a wooden dummy that is on one corner of that room of the gym. You can see him kicking and punching it with force, hearing how his hits echo through his surroundings. When he finally perceives you on his field of vision, he stops his training for a moment and turns to you. You can see that he is shirtless and on short pants, only a towel hanging from his shoulders, his muscles glistening with sweat. -Good to see you around. I’m just checking my state on close combat- He places one hand on the dummy.\n\nYou ask him if he is planning on fighting soon, to which he shakes his head. -Not at all. But it has been a while since i’ve trained this. Or at least that’s what i remember from my past. But if i’m going to help you to make this place a little more secure for everyone, perhaps it's not a bad idea if i teach the clients to protect themselves, of course only if they want to learn. I can remember training like this when i was younger, so my muscles require some refresh in their memory-\n\nYou tell him that maybe you can help him with the training. That maybe you are not a master in close combat, but you know how to fight properly. That its better to train with someone who fights back, as you point at the dummy. He looks at it then looks at you. -You’re right, it would help me a lot. But not here, as this place is a little crammed and we’ll end up hitting something we don’t want to- He walks past you and motions you to follow him. -I just know the place.-\n\nYou follow him to one of the back rooms in the gym. You can see that the place is a bit dusty but it has a lot of space. -This place was full of random things. Probably it was the place where the last owner slept. But i’m sure that this place is fine for some sparring.- You remove most of your " + ItemData.itemDataList [GameControl.charEquipment [0]].itemName + ", so you are in your underwear, showing your figure. Both of you prepare for the combat, looking at each other in the eye. -I’m a bit nervous- And with that, you make the first move. You lunge at him throwing to kick him at his torso with your right leg, but he blocks the attack with his left arm and grabs your leg, as he tries to pull you off balance with both hands. But you jump against him using your free leg and hit him on his back.\n\nHe is forced to release the grip on your leg and you fall into the floor, rolling to the side to stand up once more. -Amazing, "  + GameControl.playerName + ". Great sparring partner- You can see that his breathing is getting heavier, just the same as you. You smile at him and he returns the same kind of smile. You don’t care that his rank is lower than yours, for that moment he is the same rank as you. You exchange blows with him, avoiding and attacking him with your hands, as he just does the same. the blows weren’t nearly painful, but you can feel the rush of adrenaline hitting you like a surge of electricity, your heart beating faster with each hit you avoided. Your body trembling from each time you connect an attack to your enemy. The contact with his body through the combat is turning you on with each moment it passes.\n\nHe lunges at you, as you prepare to block his attacks, but he just hugs you with his strong arms. both of you are panting and at that moment you realize something from the proximity of Yoshika, as you can feel his cock hard against you. You turn to see him, only to feel his lips against yours, pressing them in a passionate kiss. You can feel how he pushes you against the nearest wall, as his hands run chaotic among your body, as he presses his body against yours. You decide to take the matter into your own hands and grab his body, turning the tables and placing him against the same wall where he placed you on the first place.\n\nYou can feel how he tries to move you, but you stand your ground and pull him to you as both of you are overflowing with lust. That pulling and pushing move both of you through the place, until you finally knock him faceup into the ground, landing on top of him, pinning his arms with your hands.\n\nBoth of you are panting, but you feel like the winner of that implied challenge. -You win, "  + GameControl.playerName + ", I yield.- And with that, you claim your implied prize.\n"; 

			// dick
			if (GameControl.dick1Size > 0) {
				Board.text += "You pull down his short pants, exposing that dick you know well. You can see that it's already soaked in precum, from all your foreplay. You undress your underwear, exposing your asshole that is eager for him. You can still feel the rush of combat flowing through your body, as you introduce his cock inside your tight asshole. The fact that you had to win the fight for it, made it more enjoyable for you. You started to bounce over his cock incessantly, as you are on the front row to see him getting more and more aroused, every time you impale yourself over his shaft, as you press your chest against his brawny torso.\n\nYou can see that he wants to use his hands, but you keep him in place with yours as you increase the speed of your hips. His cock rubs every part of your insides, your groin pushing against his own every time it swallows his manhood. You cum hard over him without much delay, your own penis soaking him in your own cum, as your rectum pushing against his dick as it massages it, enticing him to let it all flow. And without further adding, you can feel the deer’s dick pulsing inside you as it lets off a stream of cum that your colon accepts with eagerness, as it keeps caressing it as it pours its white load inside you.\n\nYour body trembles from the feeling until you’re exhausted. Both of you are laying on the floor, covered in sweat but pleased from the results of the sparring. -I’m not sure if this kind of combat would be of use...- You place a hand over his mouth. After all, you know that this is the usual way of fighting outside the city.\n\nAfter that, you stand up, feeling your body trembling from all the effort you did and you take your clothing before washing yourself. You kiss him goodbye, before leaving the place once more.\n"; 

			} else if ( GameControl.hasVagina && GameControl.charArmorTags [1] != true && GameControl.charArmorTags [2] != true) {

				Board.text = Board.text + "You pull down his short pants, exposing that dick you know well. You can see that it's already soaked in precum, from all your foreplay. You undress your underwear, exposing your cunt that is already wet too. You can still feel the rush of combat flowing through your body, as you introduce his cock inside your hot pussy. The fact that you had to win the fight for it, made it more enjoyable for you. You started to bounce over his cock incessantly, as you are on the front row to see him getting more and more aroused, every time you impale yourself over his shaft, as you press your chest against his brawny torso.\n\nYou can see that he wants to use his hands, but you keep him in place with yours as you increase the speed of your hips. His cock rubs every part of your insides, your clit pushing against his groin every time it swallows his manhood. You cum hard on him without much delay, your cunt pushing against his dick as it massages it, enticing him to let it all flow. And without further adding, you can feel the deer’s dick pulsing inside you as it lets off a stream of cum that your pussy accepts with eagerness, as it keeps caressing it as it pours its white load inside you.\n\nYour body trembles from the feeling until you’re exhausted. Both of you are laying on the floor, covered in sweat but pleased from the results of the sparring. -I’m not sure if this kind of combat would be of use...- You place a hand over his mouth. After all, you know that this is the usual way of fighting outside the city.\n\nAfter that, you stand up, feeling your body trembling from all the effort you did and you take your clothing before washing yourself. You kiss him goodbye, before leaving the place once more.\n"; 

				charVirginity();
			} else {
				Board.text = "No scene for asexuals or this armor yet, sorry."; 
			}



		} else {
			// dick
			if (GameControl.dick1Size > 0 ) {
				Board.text = "You take the chance to visit your favorite deer for this kind of things you have in mind.  You can see him in the gym, trying to help anyone who asks him. When you arrive, you can see him almost darting in front of you, his eyes looking at you with excitement. -My " + mcpronoun + "! What brings you here today? I hope i haven’t done anything wrong.- You can see him a bit concerned. -Sorry. It’s just that… each time i see you i worry, because i don’t know if it's because i did something wrong or if i did something right in the gym’s administration-\n\nYou ask him what he was doing. -Uh, i was… training. You know, to refresh my knowledge of martial combat. But honestly, It’s been a long time since i’ve been sparring- You tell him that if he requires some sparring partner, that he should called him. -I thought about it, but I didn’t wanted to bother you. You’re my " + mcpronoun + " after all- \n\nYou instruct him to lead you to the place where you can have a little bit more space to maneuver. He nods at your instruction and leads you to the spare room that is in the back of the place. You follow him, entering the place. -This will do- He moves some things from the center of the room. -I didn’t want to move anything from this place, before telling you about it- You tell him that is okay, that maybe you can think about it later, that you have other ideas in mind right now, for now you instruct him to clear the center of the room.\n\nAfter that, you go and close the door and use the master key to close it. After that, you can see that Yoshika has cleared most of the place, he is very strong and you are sure that it's more stronger than he truly think he is. After that, he comes back at you and waits for his next task. So you decide to ask him to get naked, something that you can see that makes him more energetic than before. He quickly undresses what is left of his ceremonial clothing, as he doesn’t wear them complete as he is in training.\n\nYou command him to sit, as his cock is starting to get hard and you place yourself behind him and take something out of your pocket. It is a bandana that you use to cover his eyes, tying it behind his head as you command him to keep his hands on his back on all times. You can see him fighting not to move his arms as he places them behind him, as you remove your "  + ItemData.itemDataList [GameControl.charEquipment [0]].itemName + " and kneel in front of him and tease his cock with your hand. He starts to pant due to your ministrations to him, until his cock is as hard as a stone.\n\n"; 
				Board.text = Board.text + "You sit in his lap, as you tease him with your buttocks, rubbing it against its length. You can hear how its own breathing gets deeper, as his cock starts to leak precum all over your ass. You can feel his cock pushing a bit against the crown of your asshole, as his hips twitch a bit, trying to feel more of it. He starts to tremble, as his lust gets to even higher levels. When you felt that you have teased him enough with your rubbing, you get to hear him with a tone of lust and desperation. -Please, " + mcpronoun + ". I’m feeling so hot.- You can see his tongue flailing out of his mouth in moments, but he keeps his arms in his back, but you can see that it takes effort to keep them in there.\n\nFinally, you thrust his cock inside you as you can feel it throbbing already for release. You pound yourself against it as you see how the stag moans of pleasure gets to increase more and more, as your pucker gets to tease him more and more. His face is all red from the stimulation. -I can feel your insides… Searing hot- When you feel that he is about to cum, you stop your pumping for a second, waiting for him to get off the edge, then you start riding his cock once more. The frustration gets to build inside him, as his moans get stronger, but you repeat this process several times.\n\n-Please, don’t tease me anymore. I can’t stand it!- He says out loud, his body trembling and covered in sweat from the overflowing of lasciviousness that runs skin deep on him at that moment. The fact that this strong stag in front of you is reduced into a begging pile of lust is exciting. -Let me cum! I beg of you!- He cries out loud.\n\nYou feel that he had enough, so you increase the speed of your bouncings, until you can finally feel him cumming inside you, his thick spunk filling you with a force that didn’t expected from him. You can feel how his cumload fills your insides as his cock convulses as it pours it all inside your hungry anus. You get to cum after that, your rectum clamping his dick as it rubs it with your inner walls, rewarding him for his good behaviour.\n\nAfter that, you can see that he can’t hold his arms behind him and falls limp into the wall behind him. You pull him out, a stream of cum falling off your soaked ass and dripping into the floor. Surely Yoshika filled you from that orgasm. You leave the blissful stag to his own meanderings as you dress once more and take the bandana, storing it in your pocket and open the door. You have more things to do, after all.\n"; 

			} else if ( GameControl.hasVagina == true && GameControl.charArmorTags [1] != true && GameControl.charArmorTags [2] != true) {
				
				Board.text = "You take the chance to visit your favorite deer for this kind of things you have in mind.  You can see him in the gym, trying to help anyone who asks him. When you arrive, you can see him almost darting in front of you, his eyes looking at you with excitement. -My " + mcpronoun + "! What brings you here today? I hope i haven’t done anything wrong.- You can see him a bit concerned. -Sorry. It’s just that… each time i see you i worry, because i don’t know if it's because i did something wrong or if i did something right in the gym’s administration-\n\nYou ask him what he was doing. -Uh, i was… training. You know, to refresh my knowledge of martial combat. But honestly, It’s been a long time since i’ve been sparring- You tell him that if he requires some sparring partner, that he should called him. -I thought about it, but I didn’t wanted to bother you. You’re my " + mcpronoun + " after all- \n\nYou instruct him to lead you to the place where you can have a little bit more space to maneuver. He nods at your instruction and leads you to the spare room that is in the back of the place. You follow him, entering the place. -This will do- He moves some things from the center of the room. -I didn’t want to move anything from this place, before telling you about it- You tell him that is okay, that maybe you can think about it later, that you have other ideas in mind right now, for now you instruct him to clear the center of the room.\n\nAfter that, you go and close the door and use the master key to close it. After that, you can see that Yoshika has cleared most of the place, he is very strong and you are sure that it's more stronger than he truly think he is. After that, he comes back at you and waits for his next task. So you decide to ask him to get naked, something that you can see that makes him more energetic than before. He quickly undresses what is left of his ceremonial clothing, as he doesn’t wear them complete as he is in training.\n\nYou command him to sit, as his cock is starting to get hard and you place yourself behind him and take something out of your pocket. It is a bandana that you use to cover his eyes, tying it behind his head as you command him to keep his hands on his back on all times. You can see him fighting not to move his arms as he places them behind him, as you remove your "  + ItemData.itemDataList [GameControl.charEquipment [0]].itemName + " and kneel in front of him and tease his cock with your hand. He starts to pant due to your ministrations to him, until his cock is as hard as a stone.\n\n[ifVAGINA]\nYou sit in his lap, as you tease him with your pussy, rubbing it against its length. You can hear how its own breathing gets deeper, as his cock starts to leak precum all over your cunt. You can feel his cock pushing a bit against you, as his hips twitch a bit, trying to feel more of your cunt. He starts to tremble, as his lust gets to even higher levels. When you felt that you have teased him enough with your rubbing, you get to hear him with a tone of lust and desperation. -Please, " + mcpronoun + ". I’m feeling so hot.- You can see his tongue flailing out of his mouth in moments, but he keeps his arms in his back, but you can see that it takes effort to keep them in there.\n\nFinally, you thrust his cock inside you as you can feel it throbbing already for release. You pound yourself against it as you see how the stag moans of pleasure gets to increase more and more, as your pussy gets to tease him more and more. His face is all red from the stimulation. -I can feel your insides… Searing hot- When you feel that he is about to cum, you stop your pumping for a second, waiting for him to get off the edge, then you start riding his cock once more. The frustration gets to build inside him, as his moans get stronger, but you repeat this process several times.\n\n-Please, don’t tease me anymore. I can’t stand it!- He says out loud, his body trembling and covered in sweat from the overflowing of lasciviousness that runs skin deep on him at that moment. The fact that this strong stag in front of you is reduced into a begging pile of lust is exciting. -Let me cum! I beg of you!- He cries out loud.\n\nYou feel that he had enough, so you increase the speed of your bouncings, until you can finally feel him cumming inside you, his thick spunk filling you with a force that didn’t expected from him. You can feel how his cumload fills your insides as his cock convulses as it pours it all inside your hungry snatch. You get to cum after that, your pussy clamping his dick as it rubs it with your inner walls, rewarding him for his good behaviour.\n\nAfter that, you can see that he can’t hold his arms behind him and falls limp into the wall behind him. You pull him out, a stream of cum falling off your soaked pussy and dripping into the floor. Surely Yoshika filled you from that orgasm. You leave the blissful stag to his own meanderings as you dress once more and take the bandana, storing it in your pocket and open the door. You have more things to do, after all.\n\n"; 
				charVirginity();

			} else {
				Board.text = "No scene for asexuals or chaste characters yet, sorry."; 
			}


		}

	}

	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	public void scene5(){

		GameControl.actualArousal = 0; 

		endTurnFun ();


		if (NPCCharList.CharFollower[iYoshika].corruptionStage <= 3 )
		{

			// dick
			if (GameControl.dick1Size > 0) {
				Board.text = "You got a message from the owner of the Slave Market. They tell you that they have 3 slaves that are uncontrollable and that they can’t seem to calm down, wearing down their workers without getting exhausted. They resort to you, because they don’t know anyone else to attend who has to deal with Lost people on a daily basis, and that they will pay the one who can help them solve this. You tell them that you just know the guy that is capable of lending them a hand on this predicament.\n\nYou send a message with a courier to Yoshika, telling him that you remember how he wanted to help others in disgrace. You explain him that you found out a small group of people that can be helped by him. When you explain him the methods that you know will work, he nods in approval with a resolute look on his face. And with that, you prepare everything for the appointed day.\n\nYou arrive at the place you told Yoshika that it would be the scenario for their plan. It is one of the smaller arenas from the Colosseum that you asked from Abbadon. There were the slaves, two women and one men, chained through their collars to the walls that surround the camp, long enough to move almost freely through the place. There is a bunny girl, a draconic woman and a bear man. Yoshika is sitting in one of the first rows of seats, waiting for you, dressing in a set of casual clothing. You approach him and ask him if he is ready, to which he sighs a bit then nods. -They are unusual kind of Lost, as they seem to work together. I get that’s the reason why they are harder to train. I’m as ready as I can be- He stands up then gives you a kiss and walks to the edge of the wall as he undresses, jumping inside the arena. \n\nWhen the three Lost see that there is someone else at their reach, they turn to him and start walking in his direction. The bunny girl got to him first, trying to jump at him as she tries to grab the stag’s cock with one hand. But Yoshika grabs her with strength and with one hand and grabs one of her large breasts firmly, pushing her hand away. The draconic female grabs him by behind him as she rubs her body against his back, pushing her iron-hard nipples against his skin. The bear man finally arrives and start to run his hands across the brawny complexion of Yoshika.\n\nBoth you and Yoshika get to see how the mouse girl is already wet, so he sticks one finger inside her pussy, making her moan as she held herself of the stag’s strong arm. As he does that, you see how he uses his mouth to have a taste of the draconic woman’s tits, playing with her fully erect nipples as his other hand strokes the bear’s cock. It is truly a display of coordination on behalf of Yoshika, as his opponents touch him passionately, as it looks like that their lust knows no bounds. The stag’s cock wasn’t free from groping and rubbing, engorging itself in blood by response.\n\nAfter a bit, the mouse girl gets on all fours and wiggles her ass in Yoshika’s direction, trying to entice him with her dripping pussy. The deer saw it as an opportunity, thrusting his cock inside her with relative ease as her moist cunt looks like does all the work in wrapping his cock. The bear guy gets a blowjob as the draconic girl gets to feel his fingers inside her cunny.\n\nThis gangbang continues, as Yoshika rams his cock inside them several times in a row and cums the same number of times. They get to cum too, covering Yoshika’s body in a mix of sweat, jizz and femcum, bathing him in it. You can’t help but feel aroused as you see that your deer endures that long, wearing slowly each one of them with each pounding of their pussies and puckers and filling them with his own cum. The time comes when they can only stay in place and moan out loud with an ecstatic look on their faces while Yoshika pummels their groins with his still hard cock, covered in their fluids from minutes of continuous fuckings. You wonder if he has that much stamina from all the times you’ve fucked with him, or vice versa.\n\nAfter almost two hours, you finally see the slaves laying on the ground, totally spent. You can see the stag still standing in the middle of them, breathing heavily but still with energy to continue. The slaves are completely exhausted, and with that you clap several times. From the sides of the place appear several guards that carry the slaves out of the arena, taking out their collars. Yoshika turns slowly to see you, as he is completely drenched in sexual fluids. You walk into the wall that separates the rows from the arena and jump inside without much effort.\n\nYou approach him and see that despite of what he just did in there, he is still Yoshika, the stag that longs for you. You remove your " + ItemData.itemDataList [GameControl.charEquipment [0]].itemName + " and look at him in the eye. He looks at you with a smile that hides traces of lust and starts walking towards you, slowly at first. After a bit, he picks up his pacing, until he finally reach you and locks you in a deep and passionate kiss, probably something that they couldn’t provide to him but you can.\n";
				Board.text = Board.text + "You push your chest against his torso, pressing your silhouette against his sturdy physical frame. You can see his cock already for you, as if it were waiting for you to arrive. He lifts you with both arms and puts you on the floor carefully, spreading your legs and exposing your asshole to him. He starts licking it with his wet tongue, as your moans looks like it’s exciting him. He goes slow, probably due to his weariness, but it seems that your touch reinvigorates him.\n\nYour body reacts to his caressing, getting more and more ready as you only can see the small antlers moving from side to side as he pushes his tongue across your pucker, making you tremble from excitement. After a bit, he stops and lifts his head, looking at you.\n\nYou can feel his soaked cock against your tight asshole. You can feel his vigorous hands holding your hips as he drives his cock into you, as it slides inside without much effort from all the fluids mixed in it. His thrusts against you are intense, your anus feeling his whole shaft pressing your inner walls every time he pounds your groin with his own hips. -I will always have energy for you- He says in a whisper, close to you. Both of you entwined, as your moans echoes his own in an unexpected harmony.\n\nYour lovemaking continues for a while, until he finally gets to cum inside you. This time was different, as you saw how he pumped more and more of his cum into the others, but this time he just thrusted all the way and then embraces you, as his hot cum gets to fill your insides. It isn’t that much, but it is a miracle that he still has a bit inside his balls, but it looks like that he saved it for you.\n\nAfter that, he pulls out and kiss you in the chest, before finally falling exhausted. You let him rest for a bit, before helping him up. You tell him that he will receive the reward that they offered to him, to which he only nods. -It will help the gym...- You also say that this time, he will rest on the Manor. He earned it, after all. You help him reach the Manor with his clothing half-placed, get him washed before resting finally. \n"; 

			} else if ( GameControl.hasVagina == true  && GameControl.charArmorTags [1] != true && GameControl.charArmorTags [2] != true) {

				Board.text = "You got a message from the owner of the Slave Market. They tell you that they have 3 slaves that are uncontrollable and that they can’t seem to calm down, wearing down their workers without getting exhausted. They resort to you, because they don’t know anyone else to attend who has to deal with Lost people on a daily basis, and that they will pay the one who can help them solve this. You tell them that you just know the guy that is capable of lending them a hand on this predicament.\n\nYou send a message with a courier to Yoshika, telling him that you remember how he wanted to help others in disgrace. You explain him that you found out a small group of people that can be helped by him. When you explain him the methods that you know will work, he nods in approval with a resolute look on his face. And with that, you prepare everything for the appointed day.\n\nYou arrive at the place you told Yoshika that it would be the scenario for their plan. It is one of the smaller arenas from the Colosseum that you asked from Abbadon. There were the slaves, two women and one men, chained through their collars to the walls that surround the camp, long enough to move almost freely through the place. There is a bunny girl, a draconic woman and a bear man. Yoshika is sitting in one of the first rows of seats, waiting for you, dressing in a set of casual clothing. You approach him and ask him if he is ready, to which he sighs a bit then nods. -They are unusual kind of Lost, as they seem to work together. I get that’s the reason why they are harder to train. I’m as ready as I can be- He stands up then gives you a kiss and walks to the edge of the wall as he undresses, jumping inside the arena. \n\nWhen the three Lost see that there is someone else at their reach, they turn to him and start walking in his direction. The bunny girl got to him first, trying to jump at him as she tries to grab the stag’s cock with one hand. But Yoshika grabs her with strength and with one hand and grabs one of her large breasts firmly, pushing her hand away. The draconic female grabs him by behind him as she rubs her body against his back, pushing her iron-hard nipples against his skin. The bear man finally arrives and start to run his hands across the brawny complexion of Yoshika.\n\nBoth you and Yoshika get to see how the mouse girl is already wet, so he sticks one finger inside her pussy, making her moan as she held herself of the stag’s strong arm. As he does that, you see how he uses his mouth to have a taste of the draconic woman’s tits, playing with her fully erect nipples as his other hand strokes the bear’s cock. It is truly a display of coordination on behalf of Yoshika, as his opponents touch him passionately, as it looks like that their lust knows no bounds. The stag’s cock wasn’t free from groping and rubbing, engorging itself in blood by response.\n\nAfter a bit, the mouse girl gets on all fours and wiggles her ass in Yoshika’s direction, trying to entice him with her dripping pussy. The deer saw it as an opportunity, thrusting his cock inside her with relative ease as her moist cunt looks like does all the work in wrapping his cock. The bear guy gets a blowjob as the draconic girl gets to feel his fingers inside her cunny.\n\nThis gangbang continues, as Yoshika rams his cock inside them several times in a row and cums the same number of times. They get to cum too, covering Yoshika’s body in a mix of sweat, jizz and femcum, bathing him in it. You can’t help but feel aroused as you see that your deer endures that long, wearing slowly each one of them with each pounding of their pussies and puckers and filling them with his own cum. The time comes when they can only stay in place and moan out loud with an ecstatic look on their faces while Yoshika pummels their groins with his still hard cock, covered in their fluids from minutes of continuous fuckings. You wonder if he has that much stamina from all the times you’ve fucked with him, or vice versa.\n\nAfter almost two hours, you finally see the slaves laying on the ground, totally spent. You can see the stag still standing in the middle of them, breathing heavily but still with energy to continue. The slaves are completely exhausted, and with that you clap several times. From the sides of the place appear several guards that carry the slaves out of the arena, taking out their collars. Yoshika turns slowly to see you, as he is completely drenched in sexual fluids. You walk into the wall that separates the rows from the arena and jump inside without much effort.\n\nYou approach him and see that despite of what he just did in there, he is still Yoshika, the stag that longs for you. You remove your " + ItemData.itemDataList [GameControl.charEquipment [0]].itemName + " and look at him in the eye. He looks at you with a smile that hides traces of lust and starts walking towards you, slowly at first. After a bit, he picks up his pacing, until he finally reach you and locks you in a deep and passionate kiss, probably something that they couldn’t provide to him but you can.\n";
				Board.text = Board.text + "You push your chest against his torso, pressing your silhouette against his sturdy physical frame. You can see his cock already for you, as if it were waiting for you to arrive. He lifts you with both arms and puts you on the floor carefully, spreading your legs and exposing your pussy to him. He starts licking it with his wet tongue, as the scent of your arousal looks like it’s exciting him. He goes slow, probably due to his weariness, but it seems that your body reinvigorates him.\n\nYour body reacts to his caressing, lubricating more and more around his mouth as you only can see the small antlers moving from side to side as he pushes his tongue across your inner lips and moves to your clit, making you tremble from excitement. After a bit, he stops and lifts his head, a line of your sex juices trickling from his tongue to your cunt. \n\nYou can feel his cock against your soaked pussy. You can feel his vigorous hands holding your hips as he drives his cock into you, as it slides inside without much effort from all the fluids mixed in it. His thrusts against you are intense, your pussy feeling his whole shaft pressing your inner walls every time he pounds your groin with his own hips. -I will always have energy for you- He says in a whisper, close to you. Both of you entwined, as your moans echoes his own in an unexpected harmony.\n\nYour lovemaking continues for a while, until he finally gets to cum inside you. This time was different, as you saw how he pumped more and more of his cum into the others, but this time he just thrusted all the way and then embraces you, as his hot cum gets to fill your insides. It isn’t that much, but it is a miracle that he still has a bit inside his balls, but it looks like that he saved it for you.\n\nAfter that, he pulls out and kiss you in the chest, before finally falling exhausted. You let him rest for a bit, before helping him up. You tell him that he will receive the reward that they offered to him, to which he only nods. -It will help the gym...- You also say that this time, he will rest on the Manor. He earned it, after all. You help him reach the Manor with his clothing half-placed, get him washed before resting finally. \n"; 
				charVirginity();
			} else {
				Board.text = "No scene for asexuals yet or chaste characters yet, sorry."; 
			}



		} else {
			// dick
			if (GameControl.dick1Size > 0  ) {
				Board.text = "This time, you choose to prove your point with Yoshika, to give him a taste of his new lifestyle. You are sure that he will love it. And so, you instruct him to close the gym early that day, to which he complies. You see him waiting patiently in the gym’s entrance, looking around for you. When he sees you, you can see that his dick gets hard just by instinct. As if he knows that when you arrive, something pleasant will happen to him.\n\nYou smile at that level of perversion that the deer is displaying, he is truly one step further into his complete corruption. You instruct him to follow you, and both of you arrive at the garden of your manor. You can see that a small group of people are already there waiting for you two in a circle. As you enter the circle, you give him the order of not cumming until you told him that he can.\n\nThe circle open and both of you enter, you see that there are a mix of women and men among them. You instruct him to get naked, to which he looks at them with excitement. He undresses with ease until there is nothing more than a naked stag in the middle of those people. You just snap your fingers once and tell them to leave the stag’s cock untouched. They walk and start groping Yoshika’s whole body with lust in their eyes. Many of them gets naked too pretty fast, as the others touch his ass and ogle his cock and balls.\n\nYou can see that the stag doesn’t resist to this treatment, even though he can. Now he knows his place as a public whore and enjoys his inner self fully. When two of them uncover their cocks, he grabs each one of them with one of his hands as he start to lick them with delight and suck them with the expertise he has been collecting during his sessions with you. -I’ve always wanted a piece of his fine ass since i’ve seen him at the gym- One of the men says just before pushing his cock inside the deer’s asshole. You can see Yoshika’s tongue flailing out of his mouth as that man gets to fuck him raw like the little bitch he is. \n\nYou can see that a woman put herself in front of him and forces his mouth against her pussy, already wet from seeing that man being ravaged by the other three people. He gets to eating her cunt with a wild passion that you only see when he is being used by someone else. You can see that he is loving the fact that she is pushing with her hands against her snatch, using his small antlers like handles.\n"; 
				Board.text = Board.text + "Some of them rub their genitals against any part of the public stag that they can get. When one of them cums and fills Yoshika’s body with sperm, another one fills their place. Between pussies and cocks he is cornered, as he services them with every part of his body that he can use. You could feel how your own cock gets soaked in your own precum every time he moans for release. You can hear his groans of frustration as he is forcing himself not to cum. There is a symphony of moans around him, as more and more people get to cum after they violate almost every part of his muscular body, until there is nothing more of him than a pile of mumbling cum.\n \nFinally, when most of the people that are there are spent, you tell them that they are dismissed. And so, you wait for them to leave the Manor. When they finally are gone, you can see that Yoshika is touching himself absentmindedly. You undress your " + ItemData.itemDataList [GameControl.charEquipment [0]].itemName + " and place yourself in front of him, exposing your cock and chest to him, telling him that he must please you with his asshole if he wants to finally cum.\n\nLike a man lost in a desert to a bucket of water, he jumps over you with desperation. He impales himself in your cock, his pucker welcoming you with its warm sensation and starts bouncing over you. Each bounce full of recklessness, his mind fogged by the need for release. You can feel your cock pounding his asshole, his inner walls being rubbed with the savagery and strength of his own pumpings. You whisper the permission to cum close to his ear, as you can see him trembling with ecstasy as he finally releases his load in front of you. You feel his shaft spurting a constant stream of cum making an arc in front of you and puddling in the ground. This display of desperation and abide to your orders push you over the edge, as your own orgasm splashes you with force. Your dick rewards the stag with a big load of cum making his way inside his pucker and rectum, making him moan and thrash wildly until he finally stops spurting his jizz.\n\nAfter some minutes of resting, you finally stand up and clean yourself and tell him to do the same. He washes himself with a faraway look on his face and gets dressed. He looks at you with enthusiasm. -That was… amazing… We should do it sometime, if you want.- He says, before leaving the manor sheepishly. You will think about that in another time.\n"; 

			} else if ( GameControl.hasVagina == true  && GameControl.charArmorTags [1] != true && GameControl.charArmorTags [2] != true) {
		
				Board.text = "This time, you choose to prove your point with Yoshika, to give him a taste of his new lifestyle. You are sure that he will love it. And so, you instruct him to close the gym early that day, to which he complies. You see him waiting patiently in the gym’s entrance, looking around for you. When he sees you, you can see that his dick gets hard just by instinct. As if he knows that when you arrive, something pleasant will happen to him.\n\nYou smile at that level of perversion that the deer is displaying, he is truly one step further into his complete corruption. You instruct him to follow you, and both of you arrive at the garden of your manor. You can see that a small group of people are already there waiting for you two in a circle. As you enter the circle, you give him the order of not cumming until you told him that he can.\n\nThe circle open and both of you enter, you see that there are a mix of women and men among them. You instruct him to get naked, to which he looks at them with excitement. He undresses with ease until there is nothing more than a naked stag in the middle of those people. You just snap your fingers once and tell them to leave the stag’s cock untouched. They walk and start groping Yoshika’s whole body with lust in their eyes. Many of them gets naked too pretty fast, as the others touch his ass and ogle his cock and balls.\n\nYou can see that the stag doesn’t resist to this treatment, even though he can. Now he knows his place as a public whore and enjoys his inner self fully. When two of them uncover their cocks, he grabs each one of them with one of his hands as he start to lick them with delight and suck them with the expertise he has been collecting during his sessions with you. -I’ve always wanted a piece of his fine ass since i’ve seen him at the gym- One of the men says just before pushing his cock inside the deer’s asshole. You can see Yoshika’s tongue flailing out of his mouth as that man gets to fuck him raw like the little bitch he is. \n\nYou can see that a woman put herself in front of him and forces his mouth against her pussy, already wet from seeing that man being ravaged by the other three people. He gets to eating her cunt with a wild passion that you only see when he is being used by someone else. You can see that he is loving the fact that she is pushing with her hands against her snatch, using his small antlers like handles.\n"; 
				Board.text = Board.text + "Some of them rub their genitals against any part of the public stag that they can get. When one of them cums and fills Yoshika’s body with sperm, another one fills their place. Between pussies and cocks he is cornered, as he services them with every part of his body that he can use. You could feel how your own pussy gets wetter every time he moans for release. You can hear his groans of frustration as he is forcing himself not to cum. There is a symphony of moans around him, as more and more people get to cum after they violate almost every part of his muscular body, until there is nothing more of him than a pile of mumbling cum.\n \nFinally, when most of the people that are there are spent, you tell them that they are dismissed. And so, you wait for them to leave the Manor. When they finally are gone, you can see that Yoshika is touching himself absentmindedly. You undress your " + ItemData.itemDataList [GameControl.charEquipment [0]].itemName + " and place yourself in front of him, exposing your pussy and chest to him, telling him that he must please you if he wants to finally cum.\n\nLike a man lost in a desert to a bucket of water, he jumps over you with desperation. He pummels your pussy with his hard cock like a battering ram. Each thrust full of recklessness, his mind fogged by the need for release. You can feel him pounding your pussy, your inner walls being rubbed with savagery and strength. You whisper the permission to cum close to his ear, as you can see him trembling with ecstasy as he finally releases his load inside you. You feel his shaft pumping a constant stream of cum inside your nether walls without even stopping his thrusts. This display of desperation and abide to your orders push you over the edge, as your own orgasm splashes you with force. Your cunt rewards the stag with stroke after stroke around his cock, making him moan and thrash wildly until he finally stops spurting his jizz.\n\nAfter some minutes of resting, you finally stand up and clean yourself and tell him to do the same. He washes himself with a faraway look on his face and gets dressed. He looks at you with enthusiasm. -That was… amazing… We should do it sometime, if you want.- He says, before leaving the manor sheepishly. You will think about that in another time.\n"; 
				charVirginity();

			} else {
				Board.text = "No scene for asexuals or chaste characters yet, sorry."; 
			}


		}




	}

	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


	public void enslaveYoshika(){

		if (NPCCharList.CharFollower[iYoshika].corruptionStage < 4){
			Board.text = "You need to corrupt Yoshika more if you want to enslave him."; 

		}else if(NPCCharList.CharFollower[iYoshika].slaveStage == 0 && NPCCharList.CharFollower[iYoshika].corruptionStage >= 4){

			panConfirmationTitle.text = "Do you want to enslave Yoshika? This cannot be undone!";
			callConfirmation (2);
		}else if (NPCCharList.CharFollower[iYoshika].slaveStage == 0 && NPCCharList.CharFollower[iYoshika].corruptionStage < 4){
			Board.text = "You need to corrupt Yoshika more if you want to enslave him."; 
		}else if (NPCCharList.CharFollower[iYoshika].slaveStage >= 4){
			Board.text = "Yoshika has been enslaved already!"; 
		}else if (NPCCharList.CharFollower[iYoshika].slaveStage >= 1){
			
			if (NPCCharList.CharFollower[iYoshika].slaveStage == 1) {
				Board.text = "You told the guards to fetch Yoshika to his cabin and threw him into the dungeon. After a day or two, you went to see how he is doing in there. As you arrive at the cell that is holding him prisoner, you can see him curling in a corner, waiting for someone to come. When he sees you, he got closer to you fast as he holds the bars in his hands. <i>”There has been some misunderstanding, my liege! I shouldn’t be here!,”</i> he says, looking at you in the eye.\n\nYou tell him with a smile that it isn’t a mistake.That he will learn to obey properly as a slave.When he hears you, his face fills with concern. <i>”Why? I haven’t been good enough following orders on my own? What did I do wrong? I did my best! What else I could do for you, my liege?!,”</i> he shouts at you, but you shake your head and tell him that you want complete adoration on his behalf. <i>”But, I can’t live for you. I have to protect the Forest too! It’s my sacred duty. I’ve made an oath”</i>. You tell him the only duty he only needs is you. <i>”Please, let me go! I can’t fail them!”</i> \n\nYou tell him that he’ll be an obedient slave from now on. He slips into the floor, hopeless as he looks at you scared. You yell at him, telling him to say that he will be an obedient slave. He is cowed, but after a couple of seconds nods. You smile as you tell him that you’ll give him a couple of days to lose any hope he could have left in his system. Maybe the lack of food will haste the process. You start to walk away, as you can see how the deer just looks at you as you leave, his face filled with fear. <i>”Father, forgive me...”</i> you hear from the stag before you close the door to the dungeon.\n";
				NPCCharList.CharFollower[iYoshika].slaveStage = 2;
				
				NPCCharList.CharFollower[iYoshika].attWillpower -= 10;	
				NPCCharList.CharFollower[iYoshika].charLoyalty = -50; 
				NPCCharList.CharFollower[iYoshika].charRelationship = -50;
				NPCCharList.CharFollower[iYoshika].isSlave = true; 
				endTurnFun ();
			}else if (NPCCharList.CharFollower[iYoshika].slaveStage == 2) {
				Board.text = "Since you gave Yoshika a good amount of time in the dungeon to understand his new role as your slave, he has been silent the whole time, probably scared of talking and make his situation worse. You can see that he barely eats as he continues serving you and working in his normal duties.\n\nPerhaps you need to twist his purpose to your advantage, so you call him and he quickly attends. You ask him to come close to you and when he does, you can see that he avoid your gaze. You tell him that now as he is your slave, it’s his sacred duty to serve and protect you. <i>”But, my liege, I alr...”</i> and without allowing him finishing his word, you slap him hard, telling him that he should never contradict him. <i>”I’m sorry, my liege,”</i> he answers. You tell him that he should not wear those old robes and order him to disrobe himself and wear the clothes of a formal slave. You snap your fingers and one servant brings one fine piece of clothing that is in the form of an slave outfit. You tell him to dress it with pride.\n\nHe dons the clothing and looks at you with some care. He runs his hands through the clothing. <i>”This is nice,”</i> he says. You tell him that if he behaves correctly, you’ll make sure that he will be treated like a good slave. But if he misbehaves, then he will be punished. you can see that he contains an answer, something that makes you smile, as he is learning fast. And that from now on, he should call you Master. <i>”I will do it, Master”</i>.\n\nAnd as you thought, he adapts to this lifestyle rather quickly. Maybe he is made to be a slave from the start, because he seems more free from his duties than before, working hard to serve you. You know that he serves you because if he don’t, you’ll punish him. You need something stronger than that. And with that thought, you devise a way of gaining his loyalty.";
				NPCCharList.CharFollower[iYoshika].slaveStage = 3;
				
				NPCCharList.CharFollower[iYoshika].attWillpower -= 10;	
				NPCCharList.CharFollower[iYoshika].charLoyalty += 10; 
				NPCCharList.CharFollower[iYoshika].charRelationship += 10;
				endTurnFun ();

			}else if (NPCCharList.CharFollower[iYoshika].slaveStage == 3) {
				Board.text = "You can see that Yoshika is acting like a normal slave, but you require him to be great. So you plan to make him improve his skills by a large amount by reinforcing the treat and punishment. At first, you only slap him for minor transgressions, but when he goes wrong and causes you a severe hindrance, you ask the guards to place him in a stock, naked. <i>”I’m sorry! It won’t happen again”</i>\n\n<i>”I will make sure that you remember this lesson”</i> you say, as you ready your whip and flagellate his strong ass with it. You can hear a squeal of pain. You prepare the whip once more, take impulse and whip his ass with force, making him cry of pain for a second. You continue his punishment for several more whippings, until you leave his buttcheeks all red and bloody. <i>”I hope that this makes you understand that you have to improve your job, or I’ll have the pleasure of punish you again. You understand?”</i> you say in an strong tone. The deer looks at you exhausted and nods slowly. You ask the guards to carry him and send him to his cabin. And if he tries to escape, you’ll hunt him and bring him back with extreme force.\n\nAnd when he behaves, you give him a couple more food or things that a slave your require. And since you did that, Yoshika has improved his efficiency by a lot. It has been a while since you’ve used the whip on him. It finally understands his place.\n";
				NPCCharList.CharFollower[iYoshika].slaveStage = 4;
				
				NPCCharList.CharFollower[iYoshika].attWillpower -= 10;	
				NPCCharList.CharFollower[iYoshika].charLoyalty += 25; 
				NPCCharList.CharFollower[iYoshika].charRelationship += 25;
				endTurnFun ();

			}else if (NPCCharList.CharFollower[iYoshika].slaveStage == 4) {
				endTurnFun ();
				string PAR0 = "After a while of planning, you thought of a way of making him loyal to you, in the same manner that he made himself loyal to his “sacred duty”. You heard that he made an oath to that duty. Perhaps if he makes one to you, then you’ll gain his loyalty.\n\nSo, you call him into your chambers, to which he arrives quite fast. As he arrives, you tell him to stand in front of you and stand still for a second. He does so with efficiency and so, you ask him to talk about the oath he made with the forest. <i>”Well, Master. I did the Oath to the forest… but I can’t remember exactly how it went.”</i>. Good, then he wouldn’t have any problem if he creates his own way of binding an oath. <i>”Of course, my master. I’m sure that yours will be better,”</i> he gulps nervous after he says that.\n\nYou tell him to kneel, so you ready a ceremonial sword and instruct him to kneel, something he does. You place your weapon in his shoulder. <i>”I, "+ GameControl.playerName +", as the power of Liege of Aurorum confers me, release from all the oaths you could have before this one. Now I bind you into another one, a Bow of Slavery. I bind you to serve me from this day until I discard you like the worthless whore you could become. I bind you to be obedient to me over anything else, your life dedicated only to me, your Master. You’ll obey every whim and every desire and in exchange for obedience, I’ll treat you like the good slave you can be”</i> and after saying that, you pat his shoulder.\n\nAfter that, you can see that his attitude changed. He truly only required that, as he looks at you with a smile on your face. <i>”Thank you, Master! That stupid oath was the only thing stopping me from being the slave you deserve!”</i> he says as he looks quite happy. After that, you remove the lower half of your clothes and tell him that the first new mandate is to make him cum. <i>”Of course, Master. Your slave is happy to serve”</i> he says, before kneeling just in front of you.";
				string PAR1 = "";
				string PAR1L1 = "";
				if (GameControl.dick1Size > 0) {
					if (GameControl.hasVagina == true) {
						PAR1L1 = " as he teases your cunt with diligence";
					}
					PAR1 = "\n\nHe starts sucking your "+ dickRace +" "+ dickSize +" dick with truly adoration"+ PAR1L1 +". Every movement, every lick is made to please you to the full extent of the word. His tongue is wonderfully skilled in it as his mouth wraps around your shaft, trying to show you how much he worships your cock. He gets a hold of your legs to leverage better in the art of deep sucking your prick. After a couple of minutes, you can feel your orgasm reaching you so you pull out of the deer and fill his face and antlers with your hot spunk. <i>”The oath is sealed.”</i> you say to your slave.";
				} else if (GameControl.hasVagina == true) {
					PAR1 = "\n\nHe starts sucking your pussy with truly adoration. Every movement, every lick is made to please you to the full extent of the word. His tongue is wonderfully skilled in it as his mouth wraps around your clit, trying to show you how much he worships your cunt. He gets a hold of your legs to leverage better in the art of deep licking your twat. After a couple of minutes, you can feel your orgasm reaching you so you pull out of the deer and fill his face and antlers with your pussy juices. <i>”The oath is sealed.”</i> you say to your slave.";
				} else {
					PAR1 = "\n\nNo scenes for asexuals yet, sorry.";
				}

				Board.text = PAR0 + PAR1;
				NPCCharList.CharFollower[iYoshika].slaveStage = 5;
				
				NPCCharList.CharFollower[iYoshika].attWillpower -= 10;	
				NPCCharList.CharFollower[iYoshika].charLoyalty += 50; 
				NPCCharList.CharFollower[iYoshika].charRelationship += 50;
			}
				
		}


	}

	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	public void slaveScene1(){
		GameControl.actualArousal = 0; 
		endTurnFun ();
		string PAR0 = "You want to enjoy your slave properly, so you call your guards to get him ready into the dungeon, in the same cell as always. When you arrive, you can see that the deer is already chained to the wall, his toned ass and strong back pointing at you, as one of the guards hands you the whip, so you ready yourself to enjoy it as you remove your clothes.\n\nYou give your slave the first whipping, causing him to wince and squeal in pain. The mark that the whip left on its ass fills you with excitement. You ask him who he is. <i>”I’m nothing more than a worthless slave that needs to be punished!,”</i> he says out loud as you whip him again on his ass, the sound of it echoing through the whole room. You ask him that if he deserves to be whipped. <i>”I deserve nothing! My Master is such a nice person for trying to correct this worthless piece of scum!”</i> he answers to your question. His subordination to you is getting you excited quickly.";
		string PAR1 = "";
		string PAR2 = "";
		if (GameControl.mcSex == GameControl.MCSex.Man   ) {
			PAR1 = "\n\nAfter that, you whip him again and ask him if he likes it. <i>”Of course! I love everything my Master does to me! I’m for my Master to use!”</i> he says, panting on his own, his own cock getting harder every time you cause him pain. Your cock is rock hard as you whip him, hearing his cries of pain mixed with the squeals of pleasure of a well-trained slave.";
			PAR2 = "\n\nAfter you left his back and ass all covered in cuts and bruises, you can feel your orgasm hitting you like a thunder, as you stroke your cock and start cumming all over his back and ass, as he moves trying to get the most over himself. You can see him trembling from the suffering that he was feeling at that exact moment, as your hot seed covers his wounds over his chiseled back and toned ass. <i>”Thank you... my Master!”</i>  After that, you’re spent. So you start getting dressed and instruct the guards to clean him up and return him to his place.";
		}else if ( GameControl.mcSex == GameControl.MCSex.Woman || GameControl.mcSex == GameControl.MCSex.Cuntboy){
			PAR1 = "After that, you whip him again and ask him if he likes it. <i>”Of course! I love everything my Master does to me! I’m for my Master to use!”</i> he says, panting on his own, his own cock getting harder every time you cause him pain. Your cunt is flowing like a river as you whip him, hearing his cries of pain mixed with the squeals of pleasure of a well-trained slave.";
			PAR2 = "After you left his back and ass all covered in cuts and bruises, you can feel your orgasm hitting you like a thunder, as you rub your cunt and start cumming all over your hand, as you smear your cunt juices all over his wounded ass. You can see him trembling from the suffering that he was feeling at that exact moment, as your hot fluids covers his wounds over his chiseled back and toned ass. And as you inspect, the little deer had his orgasm on his own, his cock covered in his own jizz, just like the wall in front of him and the floor beneath his legs. <i>”Thank you... my Master!”</i>  After that, you’re spent. So you start getting dressed and instruct the guards to clean him up and return him to his place.";
		}else {
			PAR1 = "No content for asexuals yet, sorry";
			PAR2 = "";
		}
		Board.text = PAR0 + PAR1 + PAR2; 
	}


	////////////
	public void slaveScene2(){
		GameControl.actualArousal = 0; 
		endTurnFun ();
		string PAR0 = "On this occasion you want to relax and use your slave without caring for him, so you ask your guards to get him ready for a relaxing session. They nod at your order and get everything ready. After a bit, you go to the dungeon and find that the deer is already bound with leather straps, as his eyes and ears are covered to avoid him hearing or seeing you.\n\nGetting to know that the deer is unable to see you or hear you, staying there as an object just to be used by you gets you excited quickly. So you undress quickly, removing your clothes with ease, leaving yourself naked just like Yoshika, who is waiting for you to arrive, but not knowing when you do.";
		string PAR1 = "";
		string PAR2 = "";
		string PAR3 = "";
		if (GameControl.dick1Size > 0 ) {
			PAR1 = "So you see that the deer is bound with his face against the wall, his asshole being presented to you. You start pressing your "+ dickSize +" cock inside his tight anus, feeling the difficulty of ravaging him raw. <i>”Master, is that you?!”</i> he says out loud, but you stay silent as you reach as far as you can inside him, before you start pounding his ass with vigor, ramming your "+ dickRace +" dick inside him, rubbing his insides with your cock-flesh as you fuck him with such force that he starts to pant from your strength only. <i>”Oh for Valeriss, it’s so thick,”</i> he yells as he clenches his anus, trying to tease you into cumming already.";
			PAR2 = "You smack his ass with force, hearing his moanings like a true slut. After a couple of minutes of fucking and spanking him, you can finally feel the sweet release of your orgasm, your cock pumping its fiery load inside his ass over and over. And with that, you can see that the deer smiles as he moans in glee. <i>”Yes! Fill me, Master!”</i> he screams as he cums on his own, his dick spilling its contents into the floor. When you finally fill your little stag with your cream, you pull out as he limps, only being suspended by the straps holding him in place. ";
			PAR3 = "After that, you dress up once more and leave the deer to your guards, letting them know that you have finished, feeling definitely more relaxed than before.";
		}else if ( GameControl.hasVagina == true){
			PAR1 = "So you see that the deer is bound with his face against the wall, his asshole being presented to you. You wear your strap-on and start pressing your sex toy inside his tight anus, feeling the difficulty of ravaging him raw. <i>”Master, is that you?!”</i> he says out loud, but you stay silent as you reach as far as you can inside him, before you start pounding his ass with vigor, ramming your dildo inside him, rubbing his insides with your fake cock as you fuck him with such force that he starts to pant from your strength only. <i>”Oh for Valeriss, it’s so thick,”</i> he yells as he clenches his anus, trying to tease you into cumming already.";
			PAR2 = "You smack his ass with force, hearing his moanings like a true slut. After a couple of minutes of fucking and spanking him, you can finally feel the sweet release of your orgasm, your pussy spilling its juicy load into the floor and ass of your deer slave. And with that, you can see that the deer smiles as he moans in glee. <i>”Yes! Use me, Master!”</i> he screams as he cums on his own, his dick spilling its contents into the floor. When you finally fill cream yourself enough, you pull out as he limps, only being suspended by the straps holding him in place. ";
			PAR3 = "After that, you dress up once more and leave the deer to your guards, letting them know that you have finished, feeling definitely more relaxed than before...";
		}else {
			PAR1 = "No content for asexuals yet, sorry.";
			PAR2 = "";
			PAR3 = "";
		}
		Board.text = PAR0 + PAR1 + PAR2;

	}



	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void charVirginity(){

		if(GameControl.isVirgin == true){
			Board.text += "\n\nYour character lost its virginity!";
			GameControl.isVirgin = false; 
		}

	}

	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


	void loadYoshika(){
		iYoshika = 0;
		while (iYoshika < NPCCharList.CharFollower.Count) {
			if (NPCCharList.CharFollower[iYoshika].charID >= 5000 && NPCCharList.CharFollower[iYoshika].charID < 6000) {
				WorldControl.NPCID = NPCCharList.CharFollower [iYoshika].charID;
				//WorldControl.PortraitID = NPCCharList.CharFollower [iYoshika].charPortrait;
				WorldControl.furryPic = NPCCharList.CharFollower [iYoshika].isFurry;
				WorldControl.futaPic = NPCCharList.CharFollower [iYoshika].isFuta;
				break; 
			}

			iYoshika++;
		}


	}

	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		endTurnPanel.sortingOrder = 500;
		mainPanel.sortingOrder = -500;

	}

	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


	public void noSelection(){
		panConfirmation.SetBool ("isDisplayed", false);

	}

	public void callConfirmation(int selector){

		panConfirmation.SetBool ("isDisplayed", true);
		conSelector = selector; 


	}

	public void yesSelection()
	{
		panConfirmation.SetBool ("isDisplayed", false);
		if (conSelector == 0) {
			NPCControl.npc5000CorruptionPath [4] = true; 
			yoshikaCorruption ();
		}

		if (conSelector == 1) {
			NPCControl.npc5000PurifyPath[4]  = true;
			yoshikaPurify ();


		}

		if (conSelector == 2) {
			NPCCharList.CharFollower[iYoshika].slaveStage = 1; 
			enslaveYoshika();
		}


	}




	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



	void Awake () {
		Board.text = "You go to Yoshika cabin, where you find him working out.";
		loadYoshika ();

		if (GameControl.mcGender == GameControl.MCGender.FEMALE) {
			mcpronoun = "Lady"; 
		} else {
			mcpronoun = "Lord"; 
		}



		if ( NPCCharList.CharFollower[iYoshika].corruptionStage >= 3) {
			scene3title.text = "Riding him";

		} else { 
			scene3title.text = "Roleplay";

		}
		if ( NPCCharList.CharFollower[iYoshika].corruptionStage >= 4) {
			scene4title.text = "Sparring sex";
		} else { 
			scene4title.text = "Submission ride";
		}
		if (NPCCharList.CharFollower[iYoshika].corruptionStage >= 4) {
			scene5title.text = "Slave sexual relief";
		} else { 
			scene5title.text = "Groupal gangbang";
		}


		/*
		if (NPCControl.npc5000Relationship < 20) 
		{
			buttDate.enabled = !buttDate.enabled; 
			buttPurify.enabled = !buttPurify.enabled;
			buttCorrupt.enabled = !buttCorrupt.enabled; 
		}*/




		buttScene4.interactable = false; 
		if (NPCCharList.CharFollower[iYoshika].charLove >= 85 || NPCCharList.CharFollower[iYoshika].corruptionStage >= 4  ) {
			buttScene4.interactable = true; 
		}

		buttScene5.interactable = false; 
		if (NPCCharList.CharFollower[iYoshika].charLove >= 100 || NPCCharList.CharFollower[iYoshika].corruptionStage >= 4  ) {
			buttScene5.interactable = true; 
		}


		buttSceneSlave1.interactable = false; 
		if (NPCCharList.CharFollower[iYoshika].slaveStage >= 5) 
		{
			buttSceneSlave1.interactable = true;
		}

		buttSceneSlave2.interactable = false; 
		if (NPCCharList.CharFollower[iYoshika].slaveStage >= 5) 
		{
			buttSceneSlave2.interactable = true;
		}



	}

	////////////////////////////////////////////////////////////////////////////////////
	//PARSER

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
		//string clothes = ItemData.itemDataList [GameControl.charEquipment [1]].itemName; 
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

	////////////////////////////////////////////////////////////////////////////////////

	void Start () {
		loadParser ();
	
	}


}
