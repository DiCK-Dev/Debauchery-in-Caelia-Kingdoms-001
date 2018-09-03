using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Faustina : MonoBehaviour {

	static int iFaustina;

	public Text Board; 

	static int confirmationControl; 
	static int continueControl; 

	public Canvas endTurnPanel; 
	//public Canvas panContinue;


	public Canvas panConfirmation;

	public Canvas panMainPanel;


	public Text option0Name;
	public Text option1Name;
	public Text option2Name;

	public Button option2Butt; 



	public void faustinaStart(){
		switch (QuestControl.faustinaQuest) {
		case 0: // intro 

			loadLucretius ();
			if (NPCCharList.CharFollower [iLucretius].isRecruited == false) {
				NPCCharList.CharFollower [iLucretius].isRecruited = true; 
			}


			defineFaustinaStart ();
			panConfirmation.sortingOrder = 500; 

			if (QuestControl.faustinaStartCorrupt) {
				//corrupt path
				Board.text = "The warnings of Lucretius were not in vain, just getting an audience with Faustina has proved to be a challenge. After a week of waiting, she finally granted you the opportunity to present your case to her. \n\nWhen you enter the military base for the first time you can see the poor state of it: The barracks are almost in ruins, most soldiers are missing equipment, and most of them are either too young, old, or weak for duty.\n\nA couple of better armed soldiers, part of her body guard, escort you into a big tent. The place is better decorated than the outside, and you can see all the preparations they have: A big campaign map with miniatures representing other cities, armies and monsters, well organized equipment, banners, and other decorations. \n\nBut the place is also full of trash, empty beer barrels, dirty mugs, plates among others. It is obvious that they party a lot too. \n\nFaustina is sitting in the middle in a very high throne, looking you from above. She just looks at you in silence while you approach, not hiding the disgust she feels for you. When you are in front of her, and before you can speak, she throws her empty mug to the side, breaking it, and finally she addresses you. <i>“Oh my, you must be happy that I finally gave you a chance to come with me... You’ve earned a reputation "+ GameControl.playerName +". For some, you are the new savior of the city, but for others you are nothing but dangerous, self righteous scum without anything in its head. I am certain that you are the later, but I’ll give you a chance to prove me wrong or leave the city... But be careful, you’ll pay with your life if you fail.”</i> she points behind you and when you turn around, you see several heads, being shown as trophies on a wood stand. \n\n<i>“Those are from others like you that thought they could lead the city. Too weak to take care of it. All of them had critical flaws, but the worst crime of all is that they lacked vision, a purpose beyond fulfilling their own needs.”</i> She steps down from her throne and walks towards you, her weapons ready to strike. <i>“I can feel your fear, your weakness. You are as useless as these dead heads, just leave and spare us the work to clean your blood from here.”</i>\n\nWith her commanding aura she gets the place in dead silence, everyone waiting for your move. Lucretius warned you about her, he knows she can be persuaded for your cause, but earning her trust will be a difficult task. You know you can yield and submit to her, to manipulate her afterwards, but you also could just try to crush her in her own game, or just try to earn her respect as an equal, what’ll be your course of action? You want to be equal to her, dominant, or submissive?\n";
				option2Butt.interactable = true; 
				option0Name.text = "Equal";
				option1Name.text = "Dominant";
				option2Name.text = "Submissive";
				confirmationControl = 100;

				//NPCCharList.CharFollower [iLucretius].charLove = 10; 
			} else {
				//pure path
				Board.text = "The warnings of Lucretius were not in vain, just getting an audience with Faustina has proved to be a challenge. After a week of waiting, she finally granted you the opportunity to present your case to her. \n\nWhen you enter the military base for the first time you can see the poor state of it: The barracks are almost in ruins, most soldiers are missing equipment, and most of them are either too young, old, or weak for duty.\n\nA couple of better armed soldiers, part of her body guard, escort you into a big tent. The place is better decorated than the outside, and you can see all the preparations they have: A big campaign map with miniatures representing other cities, armies and monsters, well organized equipment, banners, and other decorations. \n\nFaustina is sitting in the middle in a very high throne, looking you from above. She just looks at you in silence while you approach, not hiding the disgust she feels for you. When you are in front of her, and before you can speak, she addresses you. <i>“You’ve earned a reputation "+ GameControl.playerName +". For some, you are the new savior of the city, but for others you are nothing but dangerous scum. I am certain that you are  the later, but I’ll give you a chance to prove me wrong or leave the city... But be careful, you’ll pay with your life if you fail.”</i> she points behind you and when you turn around, you see several heads, being shown as trophies on a wood stand. \n\n<i>“Those are from others like you that thought they could lead the city. Corrupt, incompetent, greedy. All of them had critical flaws, but the worst crime of all is that they lacked vision, a purpose beyond fulfilling their own needs.”</i> She steps down from her throne and walks towards you, her weapons ready to strike. <i>“I can feel your fear, your weakness. You are as useless as these dead heads, just leave and spare us the work to clean your blood from here.”</i>\n\nWith her commanding aura she gets the place in dead silence, everyone waiting for your move. Lucretius warned you about her, he knows she can be persuaded for your cause, but earning her trust will be a difficult task. You know you can yield and submit to her, to manipulate her afterwards, but you also could just try to crush her in her own game, or just try to earn her respect as an equal, what’ll be your course of action?\n";
				option2Butt.interactable = true; 
				option0Name.text = "Equal";
				option1Name.text = "Dominant";
				option2Name.text = "Submissive";
				confirmationControl = 0; 
			}

			break;
		case 1: //Recovery
			panConfirmation.sortingOrder = 500; 

			if (QuestControl.faustinaStartCorrupt) {
				//corrupt path


				if (QuestControl.faustinaEqual) {
					Board.text = "You arrive to inspect the troops alongside Faustina. You can see rows of soldiers in formation. The display is a disaster, all of them lack discipline and pride, if anything you think they are just there so they can pillage towns and rape people. Most of them don't have any real armor or protection, and a few are as naked as the beast you are supposed to be fighting. Most of their weapons are tools like forks, hammers or shovels. You can see that Faustina is as frustrated as you with the situation.\n\n<i>“Years ago we had a formidable army, but the constant siege by monsters has dwindled its size, and with no trade nor investment by the the nobles of the city, this is the best we can afford.”</i> With a quick movement she takes the weapon of one of the soldiers and breaks it in half and throws it to the ground with a sighs. <i>“Totally useless, is a miracle we’ve been able to hold for this long.”</i> \n\nWhen the inspection is finished, both of you stand at the center of the training fields. <i>“Things need to change right now, or the situation will get worse soon.”</i> You negotiate with her and arrive to the agreement that you’ll make sure the noble and rich of the city will contribute to her cause, and that she can expect that her army will get a reasonable investment from their part.  \n\n<i>“Good. Now, I’ve asked to the blacksmiths in the city to present new armour designs for the army. We have two options in front of us.”</i> Two soldiers walk and stand in front of you, wearing a new armour each. At your left the soldier is wearing a formidable armour with plates and chain mail. Strong enough to keep enemies at bay yet still flexible to keep at pace with the often naked enemies. The other armour is really questionable in its design, exposing most of the female soldier body and and offering light protection at best, but still better than what the army is currently using. <i>“As you can see, one of the armour is the traditional approach: Plain, boring, effective. The right armour, although light, should help the soldiers to fight these enemies that are often too fast to keep track of them. Or maybe we could fight fire with fire too...”</i>  She turns around the soldier modeling the skimpy armour, showing her exposed ass. Faustina gives her a loud slap in the ass, and you can hear her yell more of excitement than pain. \n\n<i>“Now that the army is just forming, it would be better if we focus only on perfecting one of the designs, but this decision is too big to be taken just by me, since I don’t know what plans you had for the future. What would be your suggestion?”</i> \n\nYou take a minute to think. Beyond their advantages, you know the uniform used by your military will have a great impact in the heart and minds of your population, and is not hard to conclude which kind of effect will have the skimpy armour. \n";
				}

				if (QuestControl.faustinaSub) {
					Board.text = "You arrive to inspect the troops alongside Faustina. You can see rows of soldiers in formation. The display is a disaster, all of them lack discipline and pride, if anything you think they are just there so they can pillage towns and rape people. Most of them don't have any real armor or protection, and a few are as naked as the beast you are supposed to be fighting. Most of their weapons are tools like forks, hammers or shovels. You can see that Faustina is as frustrated as you with the situation.\n\n<i>“Years ago we had a formidable army, but the constant siege by monsters has dwindled its size, and with no trade nor investment by the the nobles of the city, this is the best we can afford.”</i> With a quick movement you take the weapon of one of the soldiers and break it in half, before throwing it at the ground. You complain about how useless these weapons are, and how is a miracle they’ve been able to hold this long. <i>“Yes you’re right... We are doing what we can.”</i>\n\nWhen the inspection is finished, both of you stand at the center of the training fields. <i>“Things need to change right now... You could help us if you get the nobles of the city to contribute to our cause, otherwise the city would be on their own very soon. If needed, I’m certain some of our soldiers are eager to help compensate them for their services...”</i> Even if you are surrounded by her body guards, it’s tone is more begging than threatening, and they don’t dare to negotiate much. You promise her to make sure the army gets a reasonable investment from their part.  \n\n<i>“That’s good... Now, I’ve asked to the blacksmiths in the city to present new armour designs for the army. We have two options in front of us.”</i> Two soldiers walk and stand in front of you, wearing a new armour each. At your left the soldier is wearing a formidable armour with plates and chain mail. Strong enough to keep enemies at bay yet still flexible to keep at pace with the often naked enemies. The other armour is really questionable in its design, exposing most of the female soldier body and and offering light protection at best, but still better than what the army is currently using. <i>“As you can see, one of the armour is the traditional approach: Plain, boring, effective. The right armour, although light, should help the soldiers to fight these enemies that are often too fast to keep track of them. Or maybe we could fight fire with fire too...”</i> You walk around the soldiers modeling their armor, and you can give a loud slap to the exposed ass of the soldier girl, and nor the girl nor anyone else present dares to complain about your action. If anything, this act improves their moral a little.\n\nFaustina smiles at you, happy with your action <i>“Now that the army is just forming, it would be better if we focus only on perfecting one of the designs, but this decision is too big to be taken just by me, what would be your suggestion?”</i> \n\nYou take a minute to think. Beyond their advantages, you know the uniform used by your military will have a great impact in the heart and minds of your population, and is not hard to conclude which kind of effect will have the skimpy armour. ";
				}

				if (QuestControl.faustinaDom) {
					Board.text = "You arrive to inspect the troops alongside Faustina. You can see rows of soldiers in formation. The display is a disaster, all of them lack discipline and pride, if anything you think they are just there so they can pillage towns and rape people. Most of them don't have any real armor or protection, and a few are as naked as the beast you are supposed to be fighting. Most of their weapons are tools like forks, hammers or shovels. You can see that Faustina is as frustrated as you with the situation.\n\n<i>“Years ago we had a formidable army, but the constant siege by monsters has dwindled its size, and with no trade nor investment by the the nobles of the city, this is the best we can afford.”</i> With a quick movement she takes the weapon of one of the soldiers and breaks it in half and throws it to the ground with a sighs. <i>“Totally useless, is a miracle we’ve been able to hold for this long.”</i>\n\nWhen the inspection is finished, both of you stand at the center of the training fields. <i>“Things need to change right now, and you’ll make sure those rich folks will contribute to our cause, or we’ll take it from their hands.”</i> with her weapon ready to strike, and surrounded by her body guards, you don’t have much room to negotiate, and promise her to make sure the army gets a reasonable investment from their part.  \n\n<i>“Good. Now, I’ve asked to the blacksmiths in the city to present new armour designs for the army. We have two options in front of us.”</i> Two soldiers walk and stand in front of you, wearing a new armour each. At your left the soldier is wearing a formidable armour with plates and chain mail. Strong enough to keep enemies at bay yet still flexible to keep at pace with the often naked enemies. The other armour is really questionable in its design, exposing most of the female soldier body and and offering light protection at best, but still better than what the army is currently using. <i>“As you can see, one of the armour is the traditional approach: Plain, boring, effective. The right armour, although light, should help the soldiers to fight these enemies that are often too fast to keep track of them. Although my plan is to fight fire with fire.”</i> She turns around the soldier modeling the skimpy armour, showing her exposed ass. Faustina commands you to give her a slap on her ass, something you reluctantly do. Your action makes people cheer of excitement, their moral rising. <i>“This is another benefit to it too.”</i> \n\n\n<i>“Now that the army is just forming, it would be better if we focus only on perfecting one of the designs, I don’t think you have any valuable input, but at least have enough courage to speak up and give an opinion.”</i> \n\nYou take a minute to think. Beyond their advantages, you know the uniform used by your military will have a great impact in the heart and minds of your population, and is not hard to conclude which kind of effect will have the skimpy armour. \n";
				}

				option0Name.text = "Heavy armours";
				option1Name.text = "Skimpy armours";
				confirmationControl = 101;

				//NPCCharList.CharFollower [iLucretius].charLove = 10; 
			} else {
				//pure path


				if (QuestControl.faustinaEqual) {
					Board.text = "You arrive to inspect the troops alongside Faustina. You can see rows of soldiers in formation, although they try to stand proud and show discipline the display is a disaster. Most of them don't have any real armor or protection, and most of their weapons are tools like forks, hammers or shovels. You can see that Faustina is as frustrated as you with the situation.\n\n<i>“Years ago we had a formidable army, but the constant siege by monsters has dwindled its size, and with no trade nor investment by the the nobles of the city, this is the best we can afford.”</i> With a quick movement she takes the weapon of one of the soldiers and breaks it in half and throws it to the ground with a sighs. <i>“Totally useless, is a miracle we’ve been able to hold for this long.”</i>\n\nWhen the inspection is finished, both of you stand at the center of the training fields. <i>“Things need to change right now, or the situation will get worse soon.”</i> You negotiate with her and arrive to the agreement that you’ll make sure the noble and rich of the city will contribute to her cause, and that she can expect that her army will get a reasonable investment from their part.  \n\n<i>“Good. Now, I’ve asked to the blacksmiths in the city to present new armour designs for the army. We have two options in front of us.”</i> Two soldiers walk and stand in front of you, wearing a new armour each. At your left the soldier is wearing a formidable armour with plates and chain mail. Strong enough to keep enemies at bay yet still flexible to keep at pace with the often naked enemies. The other armour is really questionable in its design, exposing most of the female soldier body and and offering light protection at best, but still better than what the army is currently using. <i>“As you can see, one of the armour is the traditional approach, but the enemy we face is not a traditional one. The right armour, although light, should help the soldiers to fight these enemies that are often too fast to keep track of them.”</i> You walk around the soldiers modeling their armor, and you can see the exposed ass of the soldier girl. \n\n<i>“Now that the army is just forming, it would be better if we focus only on perfecting one of the designs, but this decision is too big to be taken just by me, what would be your suggestion?”</i> \n\nYou take a minute to think. Beyond their advantages, you know the uniform used by your military will have a great impact in the heart and minds of your population, and is not hard to conclude which kind of effect will have the skimpy armour. ";
				}

				if (QuestControl.faustinaSub) {
					Board.text = "You arrive to inspect the troops alongside Faustina. You can see rows of soldiers in formation, although they try to stand proud and show discipline the display is a disaster. Most of them don't have any real armor or protection, and most of their weapons are tools like forks, hammers or shovels. You can see that Faustina is as frustrated as you with the situation, but her behavior is more cautious as when she faced you the first time, not trying to express too much.\n\n<i>“Years ago we had a formidable army, but the constant siege by monsters has dwindled its size, and with no trade nor investment by the the nobles of the city, this is the best we can afford.”</i> With a quick movement you take the weapon of one of the soldiers and break it in half, before throwing it at the ground. You complain about how useless these weapons are, and how is a miracle they’ve been able to hold this long. <i>“Yes you’re right... We are doing what we can.”</i>\n\nWhen the inspection is finished, both of you stand at the center of the training fields. <i>“Things need to change right now... You could help us if you get the nobles of the city to contribute to our cause, otherwise the city would be on their own very soon.”</i> Even if you are surrounded by her body guards, it’s tone is more begging than threatening, and they don’t dare to negotiate much. You promise her to make sure the army gets a reasonable investment from their part.  \n\n<i>“That’s good... Now, I’ve asked to the blacksmiths in the city to present new armour designs for the army. We have two options in front of us.”</i> Two soldiers walk and stand in front of you, wearing a new armour each. At your left the soldier is wearing a formidable armour with plates and chain mail. Strong enough to keep enemies at bay yet still flexible to keep at pace with the often naked enemies. The other armour is really questionable in its design, exposing most of the female soldier body and and offering light protection at best, but still better than what the army is currently using. <i>“As you can see, one of the armour is the traditional approach, but the enemy we face is not a traditional one. The right armour, although light, should help the soldiers to fight these enemies that are often too fast to keep track of them.”</i> You walk around the soldiers modeling their armor, and you can give a loud slap to the exposed ass of the soldier girl, and nor the girl nor anyone else present dares to complain about your action. \n\nFaustina continues as if nothing just happened <i>“Now that the army is just forming, it would be better if we focus only on perfecting one of the designs, but this decision is too big to be taken just by me, what would be your suggestion?”</i> \n\nYou take a minute to think. Beyond their advantages, you know the uniform used by your military will have a great impact in the heart and minds of your population, and is not hard to conclude which kind of effect will have the skimpy armour. ";				
				}

				if (QuestControl.faustinaDom) {
					Board.text = "You arrive to inspect the troops alongside Faustina. You can see rows of soldiers in formation, although they try to stand proud and show discipline the display is a disaster. Most of them don't have any real armor or protection, and most of their weapons are tools like forks, hammers or shovels. You can see that Faustina is as frustrated as you with the situation.\n\n<i>“Years ago we had a formidable army, but the constant siege by monsters has dwindled its size, and with no trade nor investment by the the nobles of the city, this is the best we can afford.”</i> With a quick movement she takes the weapon of one of the soldiers and breaks it in half and throws it to the ground with a sighs. <i>“Totally useless, is a miracle we’ve been able to hold for this long.”</i>\n\nWhen the inspection is finished, both of you stand at the center of the training fields. <i>“Things need to change right now, and you’ll make sure those rich folks will contribute to our cause, or we’ll take it from their hands.”</i> with her weapon ready to strike, and surrounded by her body guards, you don’t have much room to negotiate, and promise her to make sure the army gets a reasonable investment from their part.  \n\n<i>“Good. Now, I’ve asked to the blacksmiths in the city to present new armour designs for the army. We have two options in front of us.”</i> Two soldiers walk and stand in front of you, wearing a new armour each. At your left the soldier is wearing a formidable armour with plates and chain mail. Strong enough to keep enemies at bay yet still flexible to keep at pace with the often naked enemies. The other armour is really questionable in its design, exposing most of the female soldier body and and offering light protection at best, but still better than what the army is currently using. <i>“One of the armour is the traditional approach, but the enemy we face is not a traditional one. The right armour, although light, should help the soldiers to fight these enemies that are often too fast to keep track of them.”</i> She asks the soldiers modeling their armor to turn around, and you can see the exposed ass of the soldier girl. \n\n<i>“Now that the army is just forming, it would be better if we focus only on perfecting one of the designs, I don’t think you have any valuable input, but at least have enough courage to speak up and give an opinion.”</i> \n\nYou take a minute to think. Beyond their advantages, you know the uniform used by your military will have a great impact in the heart and minds of your population, and is not hard to conclude which kind of effect will have the skimpy armour. \n";				
				}

				option0Name.text = "Heavy armours";
				option1Name.text = "Skimpy armours";
				confirmationControl = 1; 
			}

			break;

		case 2:

			panConfirmation.sortingOrder = 500; 

			if (QuestControl.faustinaStartCorrupt) {
				//corrupt path


				if (QuestControl.faustinaEqual) {
					Board.text = "You group with Faustina and a small contingent of soldiers before the sun raises, mounting horses and ready to leave the city. It takes half an hour until you leave what’s considered the safe zone around Aurorum, consisting mostly on large plains that are being used for farming. Beyond those terrains, the pastures growth larger and the one enter the dangerous forest that lies ahead. \n\n<i>“Civilians don’t dare to go this far, there is a lot of terrain that can still be used for farming, but we need to secure it.”</i> Once at the forest, Faustina commands the soldiers to spread their formation to cover more terrain. <i>“Keep your eyes open "+ GameControl.playerName +", getting raped around here is very common. For that matter, I think a lot of people come here just to get raped... Don’t worry, we are not going too deep today, but we need to make sure things are not getting worse, we’ll send troops to secure the roads of this forest and the mines at the mountains soon enough.”</i>";
				}

				if (QuestControl.faustinaSub) {
					Board.text = "You group with Faustina and a small contingent of soldiers before the sun raises, mounting horses and ready to leave the city. It takes half an hour until you leave what’s considered the safe zone around Aurorum, consisting mostly on large plains that are being used for farming. Beyond those terrains, the pastures growth larger and the one enter the dangerous forest that lies ahead. \n\nYou order Faustina to explain more about the current situation <i>“Civilians don’t dare to go this far, there is a lot of terrain that can still be used for farming, but we need to secure it.”</i> You lead the column, and once the group enters the forest, you command the soldiers to spread their formation to cover more terrain. <i>“We need to keep our eyes open "+ GameControl.playerName +", getting raped around here is very common. For that matter, I think a lot of people just comes here to get raped... We wont go too deep today, but we need to make sure things are not getting worse. Once we renew the equipment we’ll send troops to secure the roads of this forest and the mines at the mountains in order to expand the city and its army.”</i>";
				}

				if (QuestControl.faustinaDom) {
					Board.text = "You group with Faustina and a small contingent of soldiers before the sun raises. <i>“You’ll stay close to me "+ GameControl.playerName +", I want you close enough to smell me, got it? I don’t want you to get lost like a child.”</i> You mount your horse and get ready to leave the city. If you even got away from her a couple of yards, she yells you to get back in formation. It takes half an hour until you leave what’s considered the safe zone around Aurorum, consisting mostly on large plains that are being used for farming. Beyond those terrains, the pastures growth larger and the one enter the dangerous forest that lies ahead. \n\n<i>“Civilians don’t dare to go this far, there is a lot of terrain that can still be used for farming, but we need to secure it.”</i> Once at the forest, Faustina commands the soldiers to spread their formation to cover more terrain. <i>“Try to keep your eyes open "+ GameControl.playerName +", it is common to get raped on this forest... Shit, did I just encouraged you to drop your guard?”</i> She laughs at her own joke for a while <i>“Don’t worry, we are just going to patrol today, but we need to make sure things are not getting worse. Once what we have as an army is better equipped we’ll send troops to secure the roads of this forest and the mines at the mountains in order to expand the city and the army.”</i>";
				}

				Board.text += "\n\nShe keeps talking about her plans when suddenly you hear the scream of one of the soldiers that’s beyond your line of sight. <i>“We are under attack! Get ready!”</i> You can hear the growling of beasts all around you. Your horse panics and you lose control of it <i>“"+ GameControl.playerName +" come back! Argh!”</i> The last thing you see is how she hits a monster that jumps at her with her shield, before being attacked by another two.\n\nIt takes you at least five minutes to calm the horse and dismount it. You rush back to where the combat is taking place and you can hear  Faustina struggling. You sneak around and from behind the bushes, you realize you are almost too late. She is being pinned down, and the beast are tearing apart her armour and clothing, exposing her hard nipples and already wet cunt... Such a bitch. \n\nShe still manages to punch and kick them, but with four around her there is little she can do.\n\nYou know allowing what is about to happen can help to get her corrupted, but you could manage to do the same even if you save her, what should you do? ";


				option0Name.text = "Save her";
				option1Name.text = "Witness";
				confirmationControl = 102;


			} else {
				//pure path


				if (QuestControl.faustinaEqual) {
					Board.text = "You group with Faustina and a small contingent of soldiers before the sun raises, mounting horses and ready to leave the city. It takes half an hour until you leave what’s considered the safe zone around Aurorum, consisting mostly on large plains that are being used for farming. Beyond those terrains, the pastures growth larger and the one enter the dangerous forest that lies ahead. \n\n<i>“Civilians don’t dare to go this far, there is a lot of terrain that can still be used for farming, but we need to secure it.”</i> Once at the forest, Faustina commands the soldiers to spread their formation to cover more terrain. <i>“Keep your eyes open "+ GameControl.playerName +". We are not going too deep today, but we need to make sure things are not getting worse. Once we equip the army we have now we’ll send troops to secure the roads of this forest and the mines at the mountains if we want to expand the city and its army.”</i>";			
				}

				if (QuestControl.faustinaSub) {
					Board.text = "You group with Faustina and a small contingent of soldiers before the sun raises, mounting horses and ready to leave the city. It takes half an hour until you leave what’s considered the safe zone around Aurorum, consisting mostly on large plains that are being used for farming. Beyond those terrains, the pastures growth larger and the one enter the dangerous forest that lies ahead. \n\nYou order Faustina to explain more about the current situation <i>“Civilians don’t dare to go this far, there is a lot of terrain that can still be used for farming, but we need to secure it.”</i> You lead the column, and once the group enters the forest, you command the soldiers to spread their formation to cover more terrain. <i>“We need to keep our eyes open. We wont go too deep today, but we need to make sure things are not getting worse. Once we renew the equipment we’ll send troops to secure the roads of this forest and the mines at the mountains in order to expand the city and its army.”</i>";			
				}

				if (QuestControl.faustinaDom) {
					Board.text = "You group with Faustina and a small contingent of soldiers before the sun raises. <i>“You’ll stay close to me "+ GameControl.playerName +", don’t want you to get lost like a child.”</i> You mount your horse and get ready to leave the city. If you even got away from her a couple of yards, she yells you to get back in formation. It takes half an hour until you leave what’s considered the safe zone around Aurorum, consisting mostly on large plains that are being used for farming. Beyond those terrains, the pastures growth larger and the one enter the dangerous forest that lies ahead. \n\n<i>“Civilians don’t dare to go this far, there is a lot of terrain that can still be used for farming, but we need to secure it.”</i> Once at the forest, Faustina commands the soldiers to spread their formation to cover more terrain. <i>“Try to keep your eyes open "+ GameControl.playerName +", although you won’t pick anything until its too late. We are just going to patrol today, but we need to make sure things are not getting worse. Once what we have as an army is better equipped we’ll send troops to secure the roads of this forest and the mines at the mountains in order to expand the city and the army.”</i>";			
				}

				Board.text += "\n\nShe keeps talking about her plans when suddenly you hear the scream of one of the soldiers that’s beyond your line of sight. <i>“We are under attack! Get ready!”</i> You can hear the growling of beasts all around you. Your horse panics and you lose control of it <i>“"+ GameControl.playerName +" come back! Argh!”</i> The last thing you see is how she hits a monster that jumps at her with her shield, before being attacked by another two.\n\nIt takes you at least five minutes to calm the horse and dismount it. You rush back to where the combat is taking place and you can hear  Faustina struggling. You sneak around and from behind the bushes, you realize you are almost too late. She is being pinned down, and the beast are tearing apart her armour and clothing. She still manages to punch and kick them, but with four around her there is little she can do.\n\nYou know allowing what is about to happen can help to get her corrupted, but you could manage to do the same even if you save her, what should you do? ";

				option0Name.text = "Save her";
				option1Name.text = "Witness";
				confirmationControl = 2; 
			}

			break; 

		case 3:

			panConfirmation.sortingOrder = 500; 

			if (QuestControl.faustinaStartCorrupt) {
				//corrupt path


				if (QuestControl.faustinaEqual) {
					Board.text = "During the next weeks both of you keep working together, both on the management of the army and field duty. The initial roughness that was between the two has been diminishing, and you’ve earned her respect after showing your worth. \n\nToday you’ve been working until late with her, and when the work is done, she invites you to stay over and have dinner with her. You accept, since this is a good chance to get to know her more and get closer. The experience is pleasant, talking mostly about work-related topics until dinner is over and both go to relax to the living room, drinking wine in front of a fire while seated on comfortable couches. \n\nFaustina starts to open up with you after two bottles of wine. She tells you about how she raised through the ranks and earned her reputation as a fierce leader and other meaningless anecdotes of her past, but you can see that something is troubling her, that she needs to speak about something but doesn’t dares to. You don’t try to be too brazen, but after some persuasion you get her talking.\n\n";			
				}

				if (QuestControl.faustinaSub) {
					Board.text = "During the next weeks both of you keep working together, both on the management of the army and field duty. The initial roughness that was between the two has been diminishing, and she has learned to respect you and humble herself to you. \n\nToday you’ve been working until late with her, and when the work is done, she invites you to stay over and have dinner with her. You accept, since this is a good chance to get to know her more and get closer. \n\nThe experience is pleasant, talking mostly about work-related topics until dinner is over and both go to relax to the living room, drinking wine in front of a fire while seated on comfortable couches. \n\nFaustina starts to open up with you after two bottles of wine. She tells you about how she raised through the ranks and earned her reputation as a fierce leader and other meaningless anecdotes of her past, but you can see that something is troubling her, that she needs to speak about something but doesn’t dares to. You directly ask her what’s on her mind, and after a awkward silence, she proceeds to tell you.\n\n";			
				}

				if (QuestControl.faustinaDom) {
					Board.text = "During the next weeks you keep working and following her, both on the management of the army and field duty. The initial roughness that was between the two has been diminishing, and you have learned your place at her side, while she welcomes you as her new pet. \n\nToday you’ve been working until late with her, and when the work is done, she commands you to stay over and have dinner with her. You accept, not like you have much saying on the matter, but this will be a good chance to get to know her more and get closer. The experience is pleasant all things considered, talking mostly about work-related topics until dinner is over and she guides you to the living room to relax, drinking wine in front of a fire while seated on a comfortable couch. \n\nFaustina starts to open up with you after two bottles of wine. She tells you about how she raised through the ranks and earned her reputation as a fierce leader and other meaningless anecdotes of her past, but you can see that something is troubling her, that she needs to speak about something but doesn’t dares to. You shyly ask her if everything is fine, and after a awkward silence, she sighs proceeds to tell you.\n\nAlthough at first she is reluctant, you can see she is relieved of finally having a chance to have a more personal conversation.\n\n";			
				}

				Board.text += "<i>“A lot of shit has happened in my life... But family... That’s the deeper wound I have. You see, my brother was sick, he was always depressed and weakened, to the point he wouldn’t or couldn’t leave the house for days. Nothing ever worked, but when the plague started, either by coincidence, luck or fate, he got infected by it.”</i> she pauses and takes a big breath, still unsure if she should be talking about this <i>“He got better, way better. For once he was happy too, and had vigor he never had before. Of course the society was against this miracle, but me and my parents were very happy.”</i> \n\nShe takes a moment to give another sip to her drink, and her tone becomes even sadder. <i>“Shortly after that the city started to deal with these beasts in cruel manners, we managed to get him out of town and free him in the wild... Who knows what has happened to him, but I doubt I’ll ever see him again.”</i> her teary eyes make evident her feelings, although she does her best to keep her composure. <i>“Sometimes I want to just tell this city to go fuck itself, but things can change, so I try to be patient and hold the line. Nonetheless sometimes I doubt myself, what if I am wrong? What if they are right?”</i>\n\nIt is clear that Faustina is corrupted, or close to be. You can use this chance to push her forward with the corruption and change, or suggest her to straighten out her path. This can complement your past actions to make certain which future awaits for her. \n\nWhat should you do? Should she fight for change? Or should she stick to the values and foundations the city had?";


				option0Name.text = "Fight change";
				option1Name.text = "Embrace change";
				confirmationControl = 103;


			} else {
				//pure path


				if (QuestControl.faustinaEqual) {
					Board.text = "During the next weeks both of you keep working together, both on the management of the army and field duty. The initial roughness that was between the two has been diminishing, and you’ve earned her respect after showing your worth. \n\nToday you’ve been working until late with her, and when the work is done, she invites you to stay over and have dinner with her. You accept, since this is a good chance to get to know her more and get closer. The experience is pleasant, talking mostly about work-related topics until dinner is over and both go to relax to the living room, drinking wine in front of a fire while seated on comfortable couches. \n\nFaustina starts to open up with you after two bottles of wine. She tells you about how she raised through the ranks and earned her reputation as a fierce leader and other meaningless anecdotes of her past, but you can see that something is troubling her, that she needs to speak about something but doesn’t dares to. You don’t try to be too brazen, but after some persuasion you get her talking.";			

				}

				if (QuestControl.faustinaSub) {
					Board.text = "During the next weeks both of you keep working together, both on the management of the army and field duty. The initial roughness that was between the two has been diminishing, and she has learned to respect you and humble herself to you. \n\nToday you’ve been working until late with her, and when the work is done, she invites you to stay over and have dinner with her. You accept, since this is a good chance to get to know her more and get closer. \n\nThe experience is pleasant, talking mostly about work-related topics until dinner is over and both go to relax to the living room, drinking wine in front of a fire while seated on comfortable couches. \n\nFaustina starts to open up with you after two bottles of wine. She tells you about how she raised through the ranks and earned her reputation as a fierce leader and other meaningless anecdotes of her past, but you can see that something is troubling her, that she needs to speak about something but doesn’t dares to. You directly ask her what’s on her mind, and after a awkward silence, she proceeds to tell you.";			
				}

				if (QuestControl.faustinaDom) {
					Board.text = "During the next weeks you keep working and following her, both on the management of the army and field duty. The initial roughness that was between the two has been diminishing, and you have learned your place at her side, while she welcomes you as her new pet. \n\nToday you’ve been working until late with her, and when the work is done, she commands you to stay over and have dinner with her. You accept, not like you have much saying on the matter, but this will be a good chance to get to know her more and get closer. The experience is pleasant all things considered, talking mostly about work-related topics until dinner is over and she guides you to the living room to relax, drinking wine in front of a fire while seated on a comfortable couch. \n\nFaustina starts to open up with you after two bottles of wine. She tells you about how she raised through the ranks and earned her reputation as a fierce leader and other meaningless anecdotes of her past, but you can see that something is troubling her, that she needs to speak about something but doesn’t dares to. You shyly ask her if everything is fine, and after a awkward silence, she sighs proceeds to tell you.\n\nAlthough at first she is reluctant, you can see she is relieved of finally having a chance to have a more personal conversation.";			
				}

				Board.text += "\n\n<i>“Is just... Is just something about my family. You see, my brother was sick, he was always depressed and weakened, to the point he wouldn’t or couldn’t leave the house for days. Nothing ever worked, but when the plague started, either by coincidence, luck or fate, he got infected by it.”</i> she pauses and takes a big breath, still unsure if she should be talking about this <i>“I know this change is supposed to be bad but... He was happy, or at least he looked happy. He also had a vigor he never had before. Of course, this was never put to good use, since he was unable to focus on anything but chasing girls, but my whole family thought this was a miracle, and were welcome to this change. My parents were very happy, and although is hard to admit me, deep inside, was happy to see him like this too.”</i> \n\nShe takes a moment to give another sip to her drink, and her tone becomes even sadder. <i>“Shortly after that the city started to deal with these beasts in cruel manners, we managed to get him out of town and free him in the wild... Who knows what has happened to him, but I doubt I’ll ever see him again.”</i> her teary eyes make evident her feelings, although she does her best to keep her composure. <i>“I am a firm believer of what we are doing is right, that in the end the only way to deal with the corruption is with these harsh terms, but sometimes I doubt myself, what if I am wrong? What if there is other way?”</i>\n\nThis is a good opportunity to either plant the seed of doubt, or keep her through her righteous path. This can complement your past actions to make certain which future awaits for her, what should you do? Should she fight against change, even if it has the potential to help some people? Or should she embrace it instead?";			


				option0Name.text = "Fight change";
				option1Name.text = "Embrace change";
				confirmationControl = 3; 
			}


			break; 
		case 4:

			panConfirmation.sortingOrder = 500; 

			if (NPCCharList.CharFollower [iFaustina].corruptionStage > 0) {
				//corrupt path


				if (QuestControl.faustinaEqual) {
					Board.text = "The following weeks the both of you keep working together, until the army is ready again to be put to good use. \n\nFaustina says that before engaging again with the beasts you need to make an important decision. <i>“"+ GameControl.playerName +" almost everything is ready, soon we’ll by riding and marching through the forest and beyond, and there is no doubt we are going to capture many new slaves and bitches for the city. Until now, we have put them to do forced labor, nonetheless I propose to try something else: Let’s use them instead as sex slaves. This will improve the moral of our troops and citizens, and will be a good recruiting tool too. Of course, they will still misbehave from time to time, but I believe this can be controlled.”</i> After the initial explanation, she lies down a very detailed plan. ";			
				}

				if (QuestControl.faustinaSub) {
					Board.text = "The following weeks Faustina keeps working for you, until the army is ready again to be put to good use. \n\nFaustina says that before engaging again with the beasts you need to make an important decision. <i>“"+ GameControl.playerName +" almost everything is ready, soon we’ll by riding and marching through the forest and beyond, and there is no doubt we are going to capture many new slaves and bitches for the city. Until now, we have put them to do forced labor, nonetheless if you don’t mind me I have an idea you may like: Let’s use them instead as sex slaves. This will improve the moral of our troops and citizens, and will be a good recruiting tool too. Of course, they will still misbehave from time to time, but I believe this can be controlled.”</i> After the initial explanation, she lies down a very detailed plan. ";			
				}

				if (QuestControl.faustinaDom) {
					Board.text = "The following weeks the both of you keep working together, until the army is ready again to be put to good use. \n\nFaustina says that before engaging again with the beasts you need to make an important decision.  <i>“Look, I don’t have time to explain to you all the details, I just want to use the slaves for sex work and not only as forced labor, you don’t have to know more than that. If you wonder, of course they will still misbehave from time to time, but I can take care of that.”</i> She looks at you, hurried to put her plans into motion. ";			

				}
				Board.text = "\n\nIn short she wants to give the most <i>fit</i> slaves as rewards, to be sold and some of them to public use. She has has worked a lot on this plan already, and she obviously looks forward to reap most of the rewards of this. Nonetheless, although short term this would reduce the productivity of the city, long term it may yield benefits: The current slaves are only good for farming or mining, but expanding the number of domestic slaves would be good for commerce and the living standards of the overall population. What should you do?";			



				option0Name.text = "Sex slaves";
				option1Name.text = "Only forced labor";
				confirmationControl = 105;
				NPCCharList.CharFollower [iFaustina].corruptionStage = 4;

			} else {
				//pure path


				if (QuestControl.faustinaEqual) {
					Board.text = "The following weeks the both of you keep working together, until the army is ready again to be put to good use. \n\nFaustina says that before engaging again with the beasts you need to make an important decision. <i>“"+ GameControl.playerName +" almost everything is ready, soon we’ll by riding and marching through the forest and beyond, and with certainty we’ll face a lot of monsters. Until now, we put the prisoners to good use as working slaves, nonetheless I propose to try something else: To reeducate them and put them back in society. Of course, they will still misbehave from time to time, but I believe this can be controlled.”</i> She goes into length about what is her plan. \n\nIn short, she wants to use discipline, punishments and torture to make them docile and obedient. She has worked on so many details that you have to wonder if this is an objective plan or just a sexual fantasy of her. Nonetheless, although the treatment short term would be harsher, long term it may yield benefits: The current slaves are only good for farming or mining, but expanding the number of domestic slaves would be good for commerce and the living standards of the overall population. What should you do?\n";			

				}

				if (QuestControl.faustinaSub) {
					Board.text = "The following weeks Faustina keeps working for you, until the army is ready again to be put to good use. \n\nShe says that, before engaging again with the beasts you need to make an important decision. <i>“"+ GameControl.playerName +" almost everything is ready, soon we’ll by riding and marching through the forest and beyond, and with certainty we’ll face a lot of monsters. Until now, we put the prisoners to good use as working slaves, nonetheless if you don’t mind me proposing this, we can try something else: To try to reeducate them and put them back in society. Of course, they will still misbehave from time to time, but I believe this can be controlled.”</i> She goes into length about what is her plan. \n\nIn short, she wants to use discipline, punishments and torture to make them docile and obedient. She has worked on so many details that you have to wonder if this is an objective plan or just a sexual fantasy of her. Nonetheless, although the treatment short term would be harsher, long term it may yield benefits: The current slaves are only good for farming or mining, but expanding the number of domestic slaves would be a good for commerce and living standards of the overall population. What should you do?";			

				}

				if (QuestControl.faustinaDom) {
					Board.text = "The following weeks you keep working for faustina, until the army is ready again to be put to good use. \n\nShe says that before engaging again with the beasts there is an important decision to be made. <i>“Look, I don’t have time to explain to you all the details, I just want to reeducate the slaves instead of just using them as forced labor, you don’t have to know more than that. If you wonder, of course they will still misbehave from time to time, but I can take care of that.”</i> She looks at you, hurried to put her plans into motion. \n\nIn short, she wants to use discipline, punishments and torture to make the beasts docile and obedient. You can see plans and papers around in so much detail that you have to wonder if this is an objective plan or just a sexual fantasy of her. Nonetheless, although the treatment short term would be harsher, long term it may yield benefits: The current slaves are only good for farming or mining, but expanding the number of domestic slaves would be a good for commerce and living standards of the overall population. What should you do?\n";			

				}

				option0Name.text = "Reeducation";
				option1Name.text = "Only forced labor";
				confirmationControl = 5; 

				NPCCharList.CharFollower [iFaustina].corruptionStage = 0;
			}
			break;

		default:
			panMainPanel.sortingOrder = 500; 



			break; 
		}


	}


	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


	public void confirmFun(int selector){


		//////////////////////////// 	PURE		/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

		///////////////////////////// equal, dom and sub prologue

		if (selector == 0 && confirmationControl == 0) {
			QuestControl.faustinaEqual = true;

			Board.text = "You stand proud and look at her, and with an assertive voice you tell her you’ll take her challenge, and that you’ll prove your worth to the whole city without any doubt. You can hear the murmur of the troops around you, surprised you dared to answer with that tone. Her face shows some anger, but she lets it slip this time, certain that you’ll be proved wrong sooner than later. <i>“You look very confident, but time will tell if you did the right choice.”</i> she turns around and takes her seat again. <i>“Very well, tomorrow you’ll come to inspect the troops, you’ll be with me the next week and will assist me with some of the tough choices I’ll have to make.”</i>\n\nWith a disrespectful hand gesture she orders you to leave. You smile and turn around, giving her the same courtesy she is giving to you. ";
			endTurnFun();
			QuestControl.faustinaQuest = 1; 
			return;
		}

		if (selector == 1 && confirmationControl == 0) {
			QuestControl.faustinaSub = true; 

			Board.text = "Without hesitation you give her a sound slap. After an initial gasp of the crowd, the place is again in dead silence. It takes her a moment to turn her face back to you, and you can see how she tightens her grip on her weapon. The tension is high for a couple of seconds, and before she speaks again, you tell her and the crowd that you take the challenge and prove yourself, but you wont accept anyone doubting your worth. \n\nYou tell them you’ll be back soon to inspect the troops and assist with other military matters, before turning around and leaving the place. ";
			endTurnFun();
			QuestControl.faustinaQuest = 1; 
			return;
		}


		if (selector == 2 && confirmationControl == 0) {

			QuestControl.faustinaDom = true;

			Board.text = "You humble yourself and knee in front of her. In a very weak tone, you tell her that you only look to do her bidding. You hear the crowd murmuring and relieved, but everything goes silent again when you feel a kick on your shoulder, throwing you on the ground. Before you can react, you have her weapon pointing at your neck. <i>“You are as weak as I expected.”</i> you think she will strike now but instead holsters her weapon. <i>“You’ll show me obedience. Clean it.”</i> She puts her dirty boot in front of you, and you dirty your expensive clothes to do what she asks. \n\nShe grunts when you are done <i>“Could be better. Be here tomorrow early in the morning, you’ll follow me on my tasks. Show me the respect I am owe and you’ll live.”</i> she turns around and takes a seat on her throne again, dismissing you with a hand gesture before she goes back to her work. ";
			endTurnFun();
			QuestControl.faustinaQuest = 1; 
			return;
		}


		///////////////////////////// Heavy armour / skimpy armour

		if (selector == 0 && confirmationControl == 1) {

			if (QuestControl.faustinaEqual) {
				Board.text = "You point out that the army needs to be prepared for all kind of enemies, not just monsters, and therefore the more heavy armour that’s being presented is better to deal with any situation. <i>“Maybe is too early to be thinking about foreign invasions or expanding our own territory, but I am not against a well rounded army, I’ll take your advice in consideration.”</i>\n\nDuring the rest of the day she explains to you how the border of the city has been reduced over and over during the last years, and how is of critical importance to push back the hordes of monster or food shortages will increase and trade will be diminished further more. <i>“We’ll go in patrol beyond our current borders in a couple of days, you’ll come with me so I suggest you to get ready for some action.”</i> You tell her you’ll be there and ready to join her when the time has come, and return to your castle. ";

			}

			if (QuestControl.faustinaSub) {
				Board.text = "You point out that the army needs to be prepared for all kind of enemies, not just monsters, and therefore the more heavy armour that’s being presented is better to deal with any situation. <i>“Foreign invasions or expanding our own territory are not yet on our plans, but if you have those goals in mind, having a well rounded army is a good idea. I’ll take your advice in consideration.”</i>\n\nDuring the rest of the day she explains to you how the border of the city has been reduced over and over during the last years, and how is of critical importance to push back the hordes of monster or food shortages will increase and trade will be diminished further more. <i>“We’ll go in patrol beyond our current borders in a couple of days, you can join us.”</i> You tell her you’ll be there, ready to show them your leadership, before you go back to your castle to prepare yourself. ";
			}

			if (QuestControl.faustinaDom) {
				Board.text = "You tell her that you think the heavy armour looks more appropriate for her warriors, but she laughs at you. <i>“Hahaha what do you know about what its or its not appropriate for them? Your “advice” has been heard, but I’ll need to talk with the grown ups about this. Don’t worry, I’ll make sure I tell them your opinion.”</i>\n\nDuring the rest of the day she explains to you how the border of the city has been reduced over and over during the last years, and how is of critical importance to push back the hordes of monster or food shortages will increase and trade will be diminished further more. <i>“We’ll go in patrol beyond our current borders in a couple of days, you’ll come with me, although I fear I will need to defend you if we get under attack. Nonetheless, at the very least you need to see for yourself how are the things outside the city at least once.”</i> You nod and tell her you’ll be there and ready to join her when the time has come, and return to your castle. ";

			}

			endTurnFun ();
			CityControl.armyArmourHeavy = true;
			QuestControl.faustinaQuest = 2;
			NPCCharList.CharFollower [iFaustina].corruptionStage -= 1;

			return;
		}

		if (selector == 1 && confirmationControl == 1) {

			if (QuestControl.faustinaEqual) {
				Board.text = "You point out that the army needs to adapt to the times and therefore the more “light” armour that’s being presented is better to deal with the current situation. <i>“Yes, that is probably the case. If it doesn’t perform well we may be able to change it back to regular armours, I’ll take your advice in consideration.”</i>\n\nDuring the rest of the day she explains to you how the border of the city has been reduced over and over during the last years, and how is of critical importance to push back the hordes of monster or food shortages will increase and trade will be diminished further more. <i>“We’ll go in patrol beyond our current borders in a couple of days, you’ll come with me so I suggest you to get ready for some action.”</i> You tell her you’ll be there and ready to join her when the time has come, and return to your castle. ";

			}

			if (QuestControl.faustinaSub) {
				Board.text = "You point out that the army needs to adapt to the times and therefore the more “light” armour that’s being presented is better to deal with the current situation. <i>“Yes, that’s good judgment. I’ll take your advice in consideration and as soon as we get the resources, I’ll make sure to equip our army appropriately.”</i>\n\nDuring the rest of the day she explains to you how the border of the city has been reduced over and over during the last years, and how is of critical importance to push back the hordes of monster or food shortages will increase and trade will be diminished further more. <i>“We’ll go in patrol beyond our current borders in a couple of days, you can join us.”</i> You tell her you’ll be there, ready to show them your leadership, before you go back to your castle to prepare yourself. ";
			}

			if (QuestControl.faustinaDom) {
				Board.text = "You tell her that you think the light armour looks more appropriate for her warriors, but she laughs at you. <i>“Hahaha what do you know about what its or its not appropriate for them? Your “advice” has been heard, but I’ll need to talk with the grown ups about this. Don’t worry, I’ll make sure I tell them your opinion.”</i>\n\nDuring the rest of the day she explains to you how the border of the city has been reduced over and over during the last years, and how is of critical importance to push back the hordes of monster or food shortages will increase and trade will be diminished further more. <i>“We’ll go in patrol beyond our current borders in a couple of days, you’ll come with me, although I fear I will need to defend you if we get under attack. Nonetheless, at the very least you need to see for yourself how are the things outside the city at least once.”</i> You nod and tell her you’ll be there and ready to join her when the time has come, and return to your castle. ";

			}

			endTurnFun ();
			CityControl.armyArmourHeavy = false;
			QuestControl.faustinaQuest = 2;
			NPCCharList.CharFollower [iFaustina].corruptionStage += 1;
			return;
		}

		///////////////////////////// Save her / witness

		if (selector == 0 && confirmationControl == 2) {

			if (QuestControl.faustinaEqual) {
				Board.text = "You take just a moment to inspect the scene: The monsters are all distracted groping her and tearing her clothes apart. You can see how she struggles and tries to moves towards a knife that is meters away from her, but she can barely act under these circumstances. Without time for any second thought, you run towards them. One of them, a wolf like creature, gets in your way and attacks you with its claws. You barely avoid them, and with a swift hit of your weapon you incapacitate him. The other two put their guard up, while the third keeps Faustina pinned down. \n\nYou engage in combat with the two of them, focusing on your defense, trying to advance until the knife is at your reach. With a single kick you throw it just a meter away from the distressed general, who grabs it and starts to stab the beast at the neck.\n\nBefore you can see how that battle ends, you get tackled by one of the beasts. On th ground, still weapon in hand, you struggle to keep them at bay for thirty seconds that feel like an eternity before Faustina comes stabbing one of them from behind, while you use the surprise to take the last one yourself. \n\n<i>“Ahh... Ah... Thanks "+ GameControl.playerName +", just in time.”</i> She gives you a hand to help you stand up. Although she doesn't directly shows more gratitude, you can feel her attitude towards you has changed. <i>“Let’s try to find the rest of the group.”</i>\n\nBoth of you go deeper into the forest, trying to save as many soldiers as you can. At the end of the day, only half of the group is back into the city. <i>“Ngh... Things were not this bad few months ago, this ambush was big and well organized, at least for beasts. We need to investigate this further, but for now we need to regroup.”</i>\n\nYou part ways once at the gate, promising to join her soon.\n";
			}

			if (QuestControl.faustinaSub) {
				Board.text = "You take just a moment to inspect the scene: The monsters are all distracted groping her and tearing her clothes apart. You can see how she struggles and tries to moves towards a knife that is meters away from her, but she can barely act under these circumstances. Without time for any second thought, you run towards them. One of them, a wolf like creature, gets in your way and attacks you with its claws. You barely avoid them, and with a swift hit of your weapon you incapacitate him. The other two put their guard up, while the third keeps Faustina pinned down. \n\nYou engage in combat with the two of them, focusing on your defense, trying to advance until the knife is at your reach. With a single kick you throw it just a meter away from the distressed general, who grabs it and starts to stab the beast at the neck.\n\nThe corpse beast falls on top of Faustina, which immobilizes. You get tackled by one of the beasts. On the ground, still weapon in hand, you struggle to keep them at bay until with a swing strike you cut one of their arms. The last survivor runs away before you can take it down, and the combat is over. \n\n<i>“Ahh... Ah... Thanks "+ GameControl.playerName +", just in time.”</i> She keeps moving, but cant free herself. You smirk, and you can see how her face is red with shame. <i>“Move this corpse.”</i> She tries to command you, but you mock her and explain to her that she is in no position to be disrespectful. After mumbling for herself, she finally speaks up. <i>“Please "+ GameControl.playerName +"... Please take this corpse off me.”</i> Its good, but not enough. <i>“Not enough?! Mmmhpf... Please "+ GameControl.playerName +", I can’t lift this corpse, I need your help, please rescue me.”</i> you laugh and finally help her get under it. \n\nBoth of you return to the gates on foot. Although you expected her to be more mad, she stays quiet and passive until both are back home. \n\nAt the end of the day, only half of the group is back into the city. <i>“Ngh... Things were not this bad few months ago, this ambush was big and well organized, at least for beasts. We need to investigate this further, but for now we need to regroup.”</i>\n\nYou part ways once at the gate, promising to join her soon.\n";
			}

			if (QuestControl.faustinaDom) {
				Board.text = "You take just a moment to inspect the scene: The monsters are all distracted groping her and tearing her clothes apart. You can see how she struggles and tries to moves towards a knife that is meters away from her, but she can barely act under these circumstances. Without time for any second thought, you run towards them, but you clumsily fall on the ground, throwing your weapon away. All the beast turn to look at you and laugh. Two of them start to walk towards you and the only you can do is to sit on your ass and crawl away from them. When they are almost on top of you the screaming of the beast that was on top of Faustina makes everyone turn. \n\nApparently, your weapon landed in front of her, and with a swift move she grabbed it and killed the beast that was pinning her down. She has killed a second one before they can even react, and the two that were on front of you run away before they face Faustina’s wrath. \n\nHer breathing is agitated, and most of her skin is exposed, but overall she doesn’t looks injured. You ask if she is fine but she looks at you with anger in her eyes. <i>“You are really useless, can’t stand straight even if your life depended on it.”</i> she turns around and whistles calling the horse, but none comes. \n\nAnnoyed, she hands you her backpack. <i>“Carry this, do a good service for once.”</i> although she still acts angry, you feel that her tone is less hostile against you, although she doesn’t show any soft spot to you. \n\nAt the end of the day, only half of the group is back into the city. She talks to the soldiers, almost totally ignoring your presence.  <i>“Ngh... Things were not this bad few months ago, this ambush was big and well organized, at least for beasts. We need to investigate this further, but for now we need to regroup.”</i> once she is done talking with the soldiers, she talks to you before you leave. \n\n<i>“You better stick to me in the future "+ GameControl.playerName +", you can’t do nothing on your own, so you’ll make sure to heed my very order next time.”</i> You nod at her and parts way, telling her that you’ll be back soon.\n";
			}

			QuestControl.faustinaQuest = 3;
			endTurnFun ();
			NPCCharList.CharFollower [iFaustina].corruptionStage -= 1;

			return;
		}

		if (selector == 1 && confirmationControl == 2) {

			Board.text = "You sit down and watch the scene. Faustina really fights hard, breaking noses, teeth and probably some bones, but she cant stop the inevitable. \n\nA big wolf man stays on top of her, holding her, while the other three; a fine catgirl, a horseman and a catboy, tear all her clothes apart, leaving her practically naked except for some rags. ";

			if (WorldControl.futaOn) {
				Board.text += "\n\nAlthough you can see her face shows disgust, you can see her half erection exposed. <i>“Dying for some action, bitch?”</i> says the wolf while he starts to roughly jerk her off <i>“Take your hands off me beast!”</i> The harder her dick gets, the weaker her struggle is.\nThe other beasts get themselves ready, touching themselves while they explore her body with their hands. \n\nThe wolf moves her closer to him, the tip of his cock at the entrance of her backdoor <i>“You are shaking from expectation bitch, don’t worry, we’ll make sure to satiate your lust!”</i> He lifts her from her waist, ready to impale her. <i>“N-No! Stop!”</i> she yells in vain, and with a single pull the beast enters her body, the loud sound of skin slamming skin echoing the forest. The wolf growls in celebration, while the rest of beasts celebrate along his side. \n\nThe wolf uses her, fucking her as if she was an animal like him. The first minutes Faustina struggles and resists, but the act is useless and the might of the wolf cock starts to get the best of her, who now is engaged in a mental fight against the pleasure. \n\nWith her mind focused on something else, the group gets ready to enjoy her: The catgirl jumps on top of her, and without any ceremony squats on Faustina’s dick, riding her with the same enthusiasm that the wolf has. The catboy sits in front of her, and starts to use her breasts to pleasure himself, while the horse forces his big dick through her mouth. The mere sight of that big dick going inside here makes you think she’ll break, or at least her jaw would dislocate, but the General is showing that she can take a heavy pounding through any orifice, resisting even the natural instinct to puke even if the horse dick goes deep into her throat. \n\nThe scene is wild: There is no rhythm, no elegance, just unfulfilled lust. All of them move at their own whim, and you can see how the general has problems holding at anything or anyone there.\n\nYou dare to move a little closer, and you can see how the fierce eyes of Faustina has changed: Her eyes are lost on the horizon, and you can hear moaning. Her whole face is a mess from all the tears and drolling, but it is obvious that she is enjoying the rough treatment now.\n\nIt doesn't take long until the wolf starts to cum inside her, which makes her start to shiver from pleasure. The climax of these two prompt the others to cum too, and after a couple of minutes of shooting fluids the first round is over: The catgirl on top of her, spilling  Faustina cums on her body, and her hair, face and chest drenched in the cum of the other two. Faustina doesn’t reacts much, but the other girl starts to clean with her tongue while the others change holes.\n\n";

			} else {
				Board.text += "\n\nAlthough you can see her face shows disgust, you can see her cunt already wet. <i>“Dying for some action, bitch?”</i> says the wolf while he starts to finger her <i>“Take your hands off me beast!”</i> The deeper he goes, the weaker her struggle is.\nThe other beasts get themselves ready, touching themselves while they explore her body with their hands. \n\nThe wolf moves her closer to him, the tip of his cock at the entrance of her backdoor <i>“You are shaking from expectation bitch, don’t worry, we’ll make sure to satiate your lust!”</i> He lifts her from her waist, ready to impale her. <i>“N-No! Stop!”</i> she yells in vain, and with a single pull the beast enters her body, the loud sound of skin slamming skin echoing the forest. The wolf growls in celebration, while the rest of beasts celebrate along his side. \n\nThe wolf uses her, fucking her as if she was an animal like him. The first minutes Faustina struggles and resists, but the act is useless and the might of the wolf cock starts to get the best of her, who now is engaged in a mental fight against the pleasure. \n\nWith her mind focused on something else, the group gets ready to enjoy her: The catboy moves behind her, filling her empty ass with his cock and letting her lie on top of him. The catgirl jumps on top of her, and without any ceremony squats on Faustina’s face, riding her with the same enthusiasm that the wolf has. The horse sits on her stomach, using the generous breasts of the general to pleasure himself while, thanks to its long reach, penetrates the ass of the catgirl. You wonder if they gonna tear her apart, since none of them show any consideration for her well being, but the General is showing that she can take a heavy pounding through any orifice. \n\nThe scene is wild: There is no rhythm, no elegance, just unfulfilled lust. All of them move at their own whim, and you can see how the general has problems holding at anything or anyone there.\n\nYou dare to move a little closer, and you can see how the fierce eyes of Faustina has changed: Her eyes are lost on the horizon, and you can hear moaning. Her whole face is a mess from all the tears and drolling, but it is obvious that she is enjoying the rough treatment now.\n\nIt doesn't take long until the wolf starts to cum inside her, which makes her start to shiver from pleasure. The climax of these two prompt the others to cum too, and after a couple of minutes of shooting fluids the first round is over: The catgirl on top of her, spilling  the horse cum on Faustina’s body, drenching and her hair, face and chest. Faustina doesn’t reacts much, but the other girl starts to clean with her tongue while the others change holes.\n\n";

			}

			Board.text += "The orgy keeps going for almost an hour, and although the beast are not satisfied, they wise up. <i>“Boss, we need to go, soldiers may come back soon.”</i> says the horseman. <i>“Nggh I still have this hard on... Fuck, forget it, let’s take her with us.”</i> when you heard that, you decide to come out of your hiding spot. <i>“Shit! Run! Run away!”</i> screamed the catboy, and all of them follow through his suggestion. Lucky for you, the beast were exhausted of so much fucking, and didn’t had the strength or the will to put up a fight, which is good since who knows if you could had handle the four of them, even if they were tired. \n\nYou rush to Faustina’s side and you hand her what’s left of her own cape to cover herself. <i>“Ahhh... What happened...”</i> You tell her she doesn’t has to worry, that everything is over, that you rescued her. <i>“Ahh... You did?... Thanks "+ GameControl.playerName +"”</i> She smiles at you and passes out. \n\nYou return to the city carrying her in your arms. Once there, you can see some of the soldiers that were in the squad with you at the gates. At least half of them were kidnapped or else, but at least now you know that things are getting worse. You take her to her tent, where she regains consciousness <i>“I... Don’t know how to thank you, I was wrong "+ GameControl.playerName +", I-”</i> you tell her that its fine, that she needs to rest now but you’ll be back soon to talk with her. She nods at you and falls asleep, and you go to your castle to recover some of your strength yourself. ";

			QuestControl.faustinaQuest = 3;
			endTurnFun ();
			NPCCharList.CharFollower [iFaustina].corruptionStage += 1;

			return;
		}

		///////////////////////////// fight against // embrace 

		if (selector == 0 && confirmationControl == 3) {

			Board.text = "You empathize with her feelings, understanding the dichotomy that she is facing. Nonetheless, is his brother happiness real? Can happiness exist with one lacks self control and agency? You have a deep talk with her about the matter at hand, reassuring her that what she did was the right thing. Although she is reluctant, you persuade her to give up her internal fight, telling her that the city and herself need to look forward now, there is nothing else that can be done about the past. \n\nThe conversation is almost over after two hours, with both of you sitting in the same coach, close to each other but respecting each others personal space. \n\n<i>“Yes, you are right "+ GameControl.playerName +"...”</i> her eyes are fixed on yours, expressing both gratitude and great relief. <i>“I’ve been looking forward to have this talk for years... I’m happy it finally happened.”</i> there is a long pause when she is done talking. The silence is not uncomfortable, both of you are looking deep into each others eyes. \n\nAfter long minutes, you can feel the tip of her fingers touching yours, sexual tension floating in the air. Do you want to keep going?\n\n";

			QuestControl.faustinaQuest = 4;
			endTurnFun ();
			NPCCharList.CharFollower [iFaustina].corruptionStage -= 1;

			return;
		}

		if (selector == 1 && confirmationControl == 3) {

			Board.text = "You empathize with her feelings, understanding the dichotomy that she is facing. You feel moved with her past, and a tragedy that her brother was ostracized from society just when his health was improving. You have a deep talk with her about the matter at hand, reassuring her that its not her fault but society’s, who pushed her to the abyss. Although she is reluctant, you persuade her to give up her internal fight, telling her that the city and herself need to look forward now, there is nothing else that can be done about the past. \n\nThe conversation is almost over after two hours, with both of you sitting in the same coach, close to each other but respecting each others personal space. \n\n<i>“Yes, you are right "+ GameControl.playerName +"...”</i> her eyes are fixed on yours, expressing both gratitude and great relief. <i>“I’ve been looking forward to have this talk for years... I’m happy it finally happened.”</i> there is a long pause when she is done talking. The silence is not uncomfortable, both of you are looking deep into each others eyes. \n\nAfter long minutes, you can feel the tip of her fingers touching yours, sexual tension floating in the air. Do you want to keep going?\n";

			QuestControl.faustinaQuest = 4;
			endTurnFun ();
			NPCCharList.CharFollower [iFaustina].corruptionStage += 1;

			return;
		}

		///////////////////////////// have sex / refuse 

		if (selector == 0 && confirmationControl == 4) {

			Board.text = "You hold hands with her, the silence of the room being interrupted only by the crackling fire. You lean forward, your noses touch and your eyes are lock on hers. \n\n<i>“W...”</i> you silence her with a finger on her lips, and then gently start to caress her cheek. She smiles at you for the first time, at least able to see behind her harsh facade. As you advance towards her, she only closes her eyes, her mouth slightly open waiting for you. You can feel her body shaking when your lips touch. <i>“Ahh... "+ GameControl.playerName +", we shouldn’t...”</i> But her words are contradicted when she starts to embrace you.\n\nYour tongue is fighting with hers, and the two of you push each other to see who stays on top, but at the end she gives up. <i>“Alright, just this time "+ GameControl.playerName +", your reward for passing the challenge.”</i> the both of you keep kissing and touching each other, slowly removing all your clothes.\n\n";


			if (GameControl.dick1Size > 0 && WorldControl.futaOn) {
				//if dick mc and futa
				Board.text += "You grab her generous, soft breasts, playing with her nipples. She reciprocates with her gentle hands, with her hands ending up caressing your ass. <i>“What you have here... Ohhh you are really eager "+ GameControl.playerName +"...”</i> she says when her right hand explores you down there for the first time, softly feeling the length and girth of your mast. She starts to kissing you again, while she slowly jerks you off until your pre is dripping on her belly and legs. \n\nYou return the favor and grab her cock too, playing with its head and balls. When your hands are drenched on her pre, you mix it in your cock, ready to go. \n\n<i>“Don’t be delicate, you bet I can take a pounding.”</i> she guides your dick to her back entrance, rubbing its head around. You can feel her heat, and you can see in her face that she is ready to go wild. \n\nAlthough she told you to let yourself go, you decide to take it slow, enjoying her for the first time. Her strong and rough body is truly the one of an experienced fighter, full of scars from past battles, a very different body from the typical maiden that doesn’t work a single day of her life.  \n\nShe holds at you by the neck and both of you start to move your hips faster. You trust forward deep on her, and kiss her neck. You can feel her bitting your ear and her nails scratching your back. You grab her hair and pull her head, to which her body reacts by clenching your dick tighter. \n\nBitting, scratching, and even an occasional slap, the adrenaline rush from the pain makes the two of you going faster. <i>“Yes! Harder! Fuck me harder! Give me all you have "+ GameControl.playerName +"!”</i> you fulfill her request, dedicating your whole body to satiate her lust.\n\n<i>“Ahh! Yes! Right there! Make me cum "+ GameControl.playerName +"!”</i> you double your efforts, and you can hear the couch and your moanings echoing through the base, but you’re not concerned at all. \n\nAt the final moment, she impales herself deep into you, grabbing your neck and back with her arms, while she forces you to stay close to her with her legs. \n\nYou can’t hold yourself anymore, and start to cum deep inside her. <i>“Ahh! It’s so hot! Fill me up!”</i> Her body shakes from her own climax, bathing you and herself with her semen. After you’re finally empty, you fall on top of her, asleep and exhausted.\n\nAfter a short nap you wake up, with her still under you, playing with your hair. <i>“Thanks "+ GameControl.playerName +", I think the both of us needed that.”</i> You give her a kiss and stand up, ready to leave. <i>“There are still some matters to attend, come back soon for that "+ GameControl.playerName +", and maybe more fun.”</i> you chuckle and promise her to be back soon to inspect the troops and their progress. \n\nWhen you go she is still naked on the coach, still tired but satisfied by your performance. ";

			} else if (GameControl.dick1Size > 0 && WorldControl.futaOn == false) {
				//if dick and non futa
				Board.text += "You grab her generous, soft breasts, playing with her nipples. She reciprocates with her gentle hands, with her hands ending up caressing your ass. <i>“What you have here... Ohhh you are really eager "+ GameControl.playerName +"...”</i> she says when her right hand explores you down there for the first time, softly feeling the length and girth of your mast. She starts to kissing you again, while she slowly jerks you off until your pre is dripping on her belly and legs. \n\nYou return the favor and explore her nether parts, playing with her clit and slowly fingering her. When your hands are drenched on her juice, you decide is time to go. \n\n<i>“Don’t be delicate, you bet I can take a pounding.”</i> she guides your dick to her entrance, rubbing its head around. You can feel her heat, and you can see in her face that she is ready to go wild. \n\nAlthough she told you to let yourself go, you decide to take it slow, enjoying her for the first time. Her strong and rough body is truly the one of an experienced fighter, full of scars from past battles, a very different body from the typical maiden that doesn’t work a single day of her life.  \n\nShe holds at you by the neck and both of you start to move your hips faster. You trust forward deep on her, and kiss her neck. You can feel her bitting your ear and her nails scratching your back. You grab her hair and pull her head, to which her body reacts by clenching your dick tighter. \n\nBitting, scratching, and even an occasional slap, the adrenaline rush from the pain makes the two of you going faster. <i>“Yes! Harder! Fuck me harder! Give me all you have "+ GameControl.playerName +"!”</i> you fulfill her request, dedicating your whole body to satiate her lust.\n\n<i>“Ahh! Yes! Right there! Make me cum "+ GameControl.playerName +"!”</i> you double your efforts, and you can hear the couch and your moanings echoing through the base, but you’re not concerned at all. \n\nAt the final moment, she impales herself deep into you, grabbing your neck and back with her arms, while she forces you to stay close to her with her legs. \n\nYou can’t hold yourself anymore, and start to cum deep inside her. <i>“Ahh! It’s so hot! Fill me up!”</i> Her body shakes from her own climax, and after shooting many loads, you’re finally empty, falling on top of her, asleep and exhausted.\n\nAfter a short nap you wake up, with her still under you, playing with your hair. <i>“Thanks "+ GameControl.playerName +", I think the both of us needed that.”</i> You give her a kiss and stand up, ready to leave. <i>“There are still some matters to attend, come back soon for that "+ GameControl.playerName +", and maybe more fun.”</i> you chuckle and promise her to be back soon to inspect the troops and their progress. \n\nWhen you go she is still naked on the coach, still tired but satisfied by your performance.";

			} else if (GameControl.dick1Size <= 0 && WorldControl.futaOn) {
				//if vagina and futa
				Board.text += "You grab her generous, soft breasts, playing with her nipples. She reciprocates with her gentle hands, with her hands ending up caressing your ass. <i>“Oh my... you are as excited as myself "+ GameControl.playerName +"...”</i> she says when her right hand explores you down there for the first time, softly feeling your already wet pussy. She starts to kissing you again, while she slowly fingers you until you are dripping on her belly and legs. \n\nYou return the favor and grab her cock too, playing with its head and balls. When your hands are drenched on her pre, you rub it on your nether parts, ready to go. \n\n<i>“I won’t be delicate, so you better get ready for a good pounding.”</i> You help her guide her hard cock at your entrance, rubbing its head around first. You can feel the heat of her body, and her face shows that she is ready to go wild. \n\nAlthough she warned you, you weren’t as ready as you thought: With a single trust she slams her cock deep into you, and you can hear her laughing and yelling of pleasure. You get a hold on her: Her strong and rough body is truly the one of an experienced fighter, full of scars from past battles, a very different body from the typical maiden that doesn’t work a single day of her life.  \n\nShe holds at you by the neck and both of you start to move your hips faster. You trust forward to her her deep on you, and kiss her neck. You can feel her bitting your ear and her nails scratching your back. You grab her hair and pull her head, to which her body reacts by clenching your dick tighter. \n\nBitting, scratching, and even an occasional slap, the adrenaline rush from the pain makes the two of you going faster. <i>“Yes! Harder! I want to fuck you harder! Give me all you have "+ GameControl.playerName +"!”</i> you fulfill her request, dedicating your whole body to satiate her lust.\n\n<i>“Ahh! Yes! Right there! Make me cum "+ GameControl.playerName +"!”</i> you double your efforts, and you can hear the couch and your moanings echoing through the base, but you’re not concerned at all. \n\nAt the final moment, she gives you a final deep trust, grabbing your neck and back with her arms, while she forces you to stay close to her with her legs, filling your cunt with her seed. \n\nYou can’t hold yourself anymore, and you start to climax. <i>“Ahh! Yes! Cum with me!”</i> Her powerful orgasms make her shake, and after several waves of pleasure and loads of cum, she is finally done. You, too exhausted, fall asleep on top of her.\n\nAfter a short nap you wake up, with her still under you, playing with your hair. <i>“Thanks "+ GameControl.playerName +", I think the both of us needed that.”</i> You give her a kiss and stand up, ready to leave. <i>“There are still some matters to attend, come back soon for that "+ GameControl.playerName +", and maybe more fun.”</i> you chuckle and promise her to be back soon to inspect the troops and their progress. \n\nWhen you go she is still naked on the coach, still tired but satisfied by your performance. ";

			} else if (GameControl.dick1Size <= 0 && WorldControl.futaOn == false) {
				Board.text += "You grab her generous, soft breasts, playing with her nipples. She reciprocates with her gentle hands, with her hands ending up caressing your ass. <i>“Oh my... you are as excited as myself "+ GameControl.playerName +"...”</i> she says when her right hand explores you down there for the first time, softly feeling your already wet pussy. She starts to kissing you again, while she slowly fingers you until you are dripping on her belly and legs. \n\nYou return the favor and explore her nether parts, playing with her clit and slowly fingering her. When your hands are drenched on her juice, you are ready.\n\nShe ask you to stand and go for something in the wood dresser. There, you find a long sex toy, a double dildo perfect for some action. <i>“Believe it or not, I haven’t used it yet, I was waiting for the right person.”</i> You go back on top of her.\n\n<i>“Still don’t be delicate, you bet I can take a pounding.”</i> once you put the toy inside you, she guides it to her entrance, rubbing its head around. You can feel the heat of her body, and you can see in her face that she is ready to go wild. \n\nAlthough she told you to let yourself go, you decide to take it slow, enjoying her for the first time. Her strong and rough body is truly the one of an experienced fighter, full of scars from past battles, a very different body from the typical maiden that doesn’t work a single day of her life.  \n\nShe holds at you by the neck and both of you start to move your hips faster. You trust forward deep on her, and kiss her neck. You can feel her bitting your ear and her nails scratching your back. You grab her hair and pull her head, to which her body reacts by clenching your dick tighter. \n\nBitting, scratching, and even an occasional slap, the adrenaline rush from the pain makes the two of you going faster. <i>“Yes! Harder! Fuck me harder! Give me all you have "+ GameControl.playerName +"!”</i> you fulfill her request, dedicating your whole body to satiate her lust.\n\n<i>“Ahh! Yes! Right there! Make me cum "+ GameControl.playerName +"!”</i> you double your efforts, and you can hear the couch and your moanings echoing through the base, but you’re not concerned at all. \n\nAt the final moment, she impales herself deep into you, grabbing your neck and back with her arms, while she forces you to stay close to her with her legs. \n\nYou can’t hold yourself anymore, and you start to climax. <i>“Ahh! I’m there too!”</i> Her powerful orgasms make her shake, and after several waves of pleasure, you’re finally done, falling on top of her, asleep and exhausted.\n\nAfter a short nap you wake up, with her still under you, playing with your hair. <i>“Thanks "+ GameControl.playerName +", I think the both of us needed that.”</i> You give her a kiss and stand up, ready to leave. <i>“There are still some matters to attend, come back soon for that "+ GameControl.playerName +", and maybe more fun.”</i> you chuckle and promise her to be back soon to inspect the troops and their progress. \n\nWhen you go she is still naked on the coach, still tired but satisfied by your performance. ";
			}


			NPCCharList.CharFollower [iFaustina].charLove = 10;

			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 4) {

			if (QuestControl.faustinaEqual) {
				Board.text = "You decide to stand up, telling her that it is late and you need to go back to your castle. You can see she is a little disappointed, but still happy for the conversation you just had. <i>“Yes we need some rest, there is still a lot of work left. I still need your opinion to resolve a couple of matters, so I hope I can count with you on that.”</i> you nod, telling her that of course you’ll back soon to inspect the troops, hoping to see some progress soon.\n\n<i>“Very well, have a good night then "+ GameControl.playerName +".”</i> You leave the place, hoping this won’t hurt your relationship. \n";
			}

			if (QuestControl.faustinaSub) {
				Board.text = "You decide to stand up, telling her that it is late and you need to go back to your castle. You can see she is a little disappointed, but still happy for the conversation you just had. <i>“Yes we need some rest, there is still a lot of work left. I still need your opinion to resolve a couple of matters, so I hope I can count with you on that.”</i> you nod, telling her that of course you’ll back soon to inspect the troops, hoping to see some progress soon.\n\n<i>“Very well, have a good night then "+ GameControl.playerName +".”</i> You leave the place, hoping this won’t hurt your relationship. \n";
			}

			if (QuestControl.faustinaDom) {
				Board.text = "You shake your head and tell her that you are not fine with this. All your hopes that she was going to react nicely about it are shattered instantaneously when you receive a slap on your face. <i>“How dare you, you little bitch? After everything I have done for you?! Which kind of slave you are?!”</i> she unsheathes her weapon, but she sobers up enough to stop before is too late, throwing her weapon to the ground.\n\n<i>“Just go, leave me alone. We continue our duties tomorrow.”</i>\n\nYou run away as fast as you can to your castle, hoping she doesn't change her mind, but for your relief the next day she acts as if nothing had happened, although all the subtle interest she had for you is gone now. \n\n\n";
			}

			endTurnFun ();
			return;
		}


		///////////////////////////// reeducation / forced labor

		if (selector == 0 && confirmationControl == 5) {

			Board.text = "You agree to go with her plan. Although is not certain if its even going to work, you lose nothing by letting her do this, and the benefits it may yield are worth it. <i>“Thanks "+ GameControl.playerName +"! You won’t regret your confidence on me.”</i> She leaves the tent suspiciously happy. \n\nDuring the next weeks you see that your judgment was right: The very first thing she got done was to get most of the equipment for reeducating beasts: Some of them are typical torture devices, but some of them, like chairs with dildos, spanking tables, among others don’t seem to fit the new environment that well. Not just that, but her personal tent to take care of disobedient slaves is just a fancy BDSM dungeon, nonetheless her improved mood and the prospects of new playthings are going to motivate her to do her task efficiently. \n\nOnce you give a quick inspection to the place you go back to the castle, the city finally under your total command.";


			CityControl.slavesReeducation = true; 
			endTurnFun ();
			QuestControl.faustinaQuest = 5;
			return;
		}

		if (selector == 1 && confirmationControl == 5) {


			Board.text = "You explain to her why you don’t have so much hope about the beasts, and at this point the city cannot afford these kind of experiments. Your answer saddens her, but she understand your position. <i>“You are right "+ GameControl.playerName +", it is not time to risk the city with these kind of games, I’ll make sure to keep the current policies on place.”</i> She leaves the tent in a bad mood, but she isn’t defiant. \n\nDuring the next weeks Faustina renews a lot of old equipment for the slaves, talk with local leaders and farmers, and makes sure to fix any problem that exists under the current system. Although at first she wasn’t happy, there is too much work to be done that she doesn’t even has the luxury to think about that again. \n\nAfter a long week of work, you are ready to go back to your castle, the city finally under your total command.";


			CityControl.slavesForcedLabor = true; 
			endTurnFun ();
			QuestControl.faustinaQuest = 5;
			return;
		}




		//////////////////////////// 	CORRUPT		/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

		///////////////////////////// equal, dom and sub prologue

		if (selector == 0 && confirmationControl == 100) {
			QuestControl.faustinaEqual = true;

			Board.text = "You stand proud and look at her, and with an assertive voice you tell her you’ll take her challenge, and that you’ll prove your worth to the whole city without any doubt. You can hear the murmur of the troops around you, surprised you dared to answer with that tone, but other just laughing at you. Her face shows some anger, but she lets it slip this time, certain that you’ll be proved wrong sooner than later. <i>“You look very confident eh? But time will tell if you did the right choice. You won’t have a second chance "+ GameControl.playerName +"”</i> she turns around and takes her seat again. <i>“Very well, tomorrow you’ll come to inspect the troops, you’ll be with me the next week and will assist me with some of the tough choices I’ll have to make.”</i>\n\nWith a disrespectful hand gesture she orders you to leave. You smile and turn around, giving her the same courtesy she is giving to you. ";
			endTurnFun();
			QuestControl.faustinaQuest = 1; 
			return;
		}

		if (selector == 1 && confirmationControl == 100) {
			QuestControl.faustinaSub = true; 

			Board.text = "Without hesitation you give her a sound slap. After an initial gasp of the crowd, the place is again in dead silence. It takes her a moment to turn her face back to you, and you can see how she tightens her grip on her weapon. The tension is high for a couple of seconds, and before she speaks again, you tell her and the crowd that you take the challenge and prove yourself, but you wont accept anyone doubting your worth. \n\n<i>“Fucking bastard... But fine, at least you are not a pussy. Just hope you are as good as you say, otherwise...”</i>\n\nYou dismiss her threat and tell them you’ll be back soon to inspect the troops and assist with other military matters, before turning around and leaving the place. \n";
			endTurnFun();
			QuestControl.faustinaQuest = 1; 
			return;
		}


		if (selector == 2 && confirmationControl == 100) {

			QuestControl.faustinaDom = true;

			Board.text = "You humble yourself and knee in front of her. In a very weak tone, you tell her that you only look to do her bidding. You hear the crowd murmuring and relieved, but everything goes silent again when you feel a kick on your shoulder, throwing you on the ground. Before you can react, you have her weapon pointing at your neck. <i>“You are as weak as I expected.”</i> you think she will strike now but instead holsters her weapon. <i>“Very well, I was looking for a new pet, you can stick around for now, I’m certain you’ll enjoy being my bitch. For now start by cleaning my boots.”</i> She puts her dirty boot in front of you, and you dirty your expensive clothes to do what she asks. \n\nShe grunts when you are done <i>“Could be better. Be here tomorrow early in the morning, you’ll follow me on my tasks. Show me the respect I am owe and you’ll live.”</i> she turns around and takes a seat on her throne again, dismissing you with a hand gesture before she goes back to her drink. ";
			endTurnFun();
			QuestControl.faustinaQuest = 1; 
			return;
		}





		///////////////////////////// heavy armours / skimpy armours

		if (selector == 0 && confirmationControl == 101) {


			if (QuestControl.faustinaEqual) {
				Board.text = "You point out that the army needs to be prepared for all kind of enemies, not just monsters, and therefore the more heavy armour that’s being presented is better to deal with any situation. <i>“Maybe is too early to be thinking about foreign invasions or expanding our own territory, and to be honest I find these armours to be very plain, but I’ll think about it.”</i>\n\nDuring the rest of the day she explains to you how the border of the city has been reduced over and over during the last years, and how is of critical importance to push back the hordes of monster or food shortages will increase and trade will be diminished further more. <i>“We’ll go in patrol beyond our current borders in a couple of days, you’ll come with me so I suggest you to get ready for some action. And by action maybe not just fighting.”</i> She quickly grabs your crotch for a second, biting her lips, before she leaves the tent. You return to your castle, making sure your equipment is ready for the expedition. ";
			}

			if (QuestControl.faustinaSub) {
				Board.text = "You point out that the army needs to be prepared for all kind of enemies, not just monsters, and therefore the more heavy armour that’s being presented is better to deal with any situation. <i>“Foreign invasions or expanding our own territory are not yet on our plans, but if you have those goals in mind, having a well rounded army is a good idea. I’ll take your advice in consideration.”</i>\n\nDuring the rest of the day she explains to you how the border of the city has been reduced over and over during the last years, and how is of critical importance to push back the hordes of monster or food shortages will increase and trade will be diminished further more. <i>“We’ll go in patrol beyond our current borders in a couple of days, you should join us "+ GameControl.playerName +". There might be some action... Fun action.”</i> she winks at you and you tell her you’ll be there, ready to show them your leadership, before you go back to your castle to prepare yourself. ";

			}

			if (QuestControl.faustinaDom) {
				Board.text = "You tell her that you think the heavy armour looks more appropriate for her warriors, but she laughs at you. <i>“Hahaha what do you know about what its or its not appropriate for them? Your “advice” has been heard, but I’ll need to talk with the grown ups about this. Don’t worry, I’ll make sure I tell them your opinion.”</i>\n\nDuring the rest of the day she explains to you how the border of the city has been reduced over and over during the last years, and how is of critical importance to push back the hordes of monster or food shortages will increase and trade will be diminished further more. <i>“We’ll go in patrol beyond our current borders in a couple of days, you’ll come with me so I suggest you to get ready for some action. And by action maybe not just fighting.”</i> She quickly grabs your crotch for a second, biting her lips, before she leaves the tent. You return to your castle, making sure your equipment is ready for the expedition. ";
			}

			endTurnFun ();
			CityControl.armyArmourHeavy = true;
			QuestControl.faustinaQuest = 2;
			NPCCharList.CharFollower [iFaustina].corruptionStage -= 1;
			return;
		}

		if (selector == 1 && confirmationControl == 101) {


			if (QuestControl.faustinaEqual) {
				Board.text = "You point out that the army needs to adapt to the times and therefore the more “light” armour that’s being presented is better to deal with the current situation. <i>“Yes, I’m glad we think alike. I have a lot of new tactics that I want to try on the battlefield, if you know what I mean "+ GameControl.playerName +".”</i>\n\nDuring the rest of the day she explains to you how the border of the city has been reduced over and over during the last years, and how is of critical importance to push back the hordes of monster or food shortages will increase and trade will be diminished further more. <i>“We’ll go in patrol beyond our current borders in a couple of days, you’ll come with me so I suggest you to get ready for some action. And by action maybe not just fighting.”</i> She quickly grabs your crotch for a second, biting her lips, before she leaves the tent. You return to your castle, making sure your equipment is ready for the expedition. ";
			}

			if (QuestControl.faustinaSub) {
				Board.text = "You point out that the army needs to adapt to the times and therefore the more “light” armour that’s being presented is better to deal with the current situation. <i>“Yes "+ GameControl.playerName +", I think like you do. I have a lot of new tactics that I want to try on the battlefield, if you know what I mean "+ GameControl.playerName +".”</i> She is clearly happy with your judgment.\n\nDuring the rest of the day she explains to you how the border of the city has been reduced over and over during the last years, and how is of critical importance to push back the hordes of monster or food shortages will increase and trade will be diminished further more. <i>“We’ll go in patrol beyond our current borders in a couple of days, you should join us "+ GameControl.playerName +". There might be some action... Fun action.”</i> she winks at you and you tell her you’ll be there, ready to show them your leadership, before you go back to your castle to prepare yourself. ";

			}

			if (QuestControl.faustinaDom) {
				Board.text = "You point out that the army needs to adapt to the times and therefore the more “light” armour that’s being presented is better to deal with the current situation. <i>“Hahaha yes, I’m certain that’s the reasoning. I’m glad we think alike. I have a lot of new tactics that I want to try on the battlefield, if you know what I mean "+ GameControl.playerName +".”</i>\n\nDuring the rest of the day she explains to you how the border of the city has been reduced over and over during the last years, and how is of critical importance to push back the hordes of monster or food shortages will increase and trade will be diminished further more. <i>“We’ll go in patrol beyond our current borders in a couple of days, you’ll come with me so I suggest you to get ready for some action. And by action maybe not just fighting.”</i> She quickly grabs your crotch for a second, biting her lips, before she leaves the tent. You return to your castle, making sure your equipment is ready for the expedition. ";

			}


			endTurnFun ();
			CityControl.armyArmourHeavy = false;
			QuestControl.faustinaQuest = 2;
			NPCCharList.CharFollower [iFaustina].corruptionStage += 1;
			return;
		}





		///////////////////////////// quest 2 save her / witness

		if (selector == 0 && confirmationControl == 102) {

			if (QuestControl.faustinaEqual) {
				Board.text = "You take just a moment to inspect the scene: The monsters are all distracted groping her and tearing her clothes apart. You can see how she struggles and tries to moves towards a knife that is meters away from her, but she can barely act under these circumstances. Without time for any second thought, you run towards them. One of them, a wolf like creature, gets in your way and attacks you with its claws. You barely avoid them, and with a swift hit of your weapon you incapacitate him. The other two put their guard up, while the third keeps Faustina pinned down. \n\nYou engage in combat with the two of them, focusing on your defense, trying to advance until the knife is at your reach. With a single kick you throw it just a meter away from the distressed general, who grabs it and starts to stab the beast at the neck.\n\nBefore you can see how that battle ends, you get tackled by one of the beasts. On th ground, still weapon in hand, you struggle to keep them at bay for thirty seconds that feel like an eternity before Faustina comes stabbing one of them from behind, while you use the surprise to take the last one yourself. \n\n<i>“Ahh... Ah... Thanks "+ GameControl.playerName +", but I didn’t need saving you know, I had them where I wanted.”</i> Its easy to notice how aroused she is, but you can’t risk her to get harmed before the army is prepared. She gives you a hand to help you stand up. Although she doesn't directly shows more gratitude, you can feel her attitude towards you has changed. <i>“Let’s try to find the rest of the group.”</i>\n\nBoth of you go deeper into the forest, trying to save as many soldiers as you can. At the end of the day, only half of the group is back into the city. <i>“Ngh... Things were not this bad few months ago, this ambush was big and well organized, at least for beasts. We need to investigate this further, but for now we need to regroup.”</i>\n\nYou part ways once at the gate, promising to join her soon.\n";
			}

			if (QuestControl.faustinaSub) {
				Board.text = "You take just a moment to inspect the scene: The monsters are all distracted groping her and tearing her clothes apart. You can see how she struggles and tries to moves towards a knife that is meters away from her, but she can barely act under these circumstances. Without time for any second thought, you run towards them. One of them, a wolf like creature, gets in your way and attacks you with its claws. You barely avoid them, and with a swift hit of your weapon you incapacitate him. The other two put their guard up, while the third keeps Faustina pinned down. \n\nYou engage in combat with the two of them, focusing on your defense, trying to advance until the knife is at your reach. With a single kick you throw it just a meter away from the distressed general, who grabs it and starts to stab the beast at the neck.\n\nThe corpse beast falls on top of Faustina, which immobilizes. You get tackled by one of the beasts. On the ground, still weapon in hand, you struggle to keep them at bay until with a swing strike you cut one of their arms. The last survivor runs away before you can take it down, and the combat is over. \n\n<i>“Ahh... Ah... Thanks "+ GameControl.playerName +", but I had them where I wanted you know...”</i> She keeps moving, but cant free herself from the corpse that’s on top of her. You smirk, and you can see how her face is red with shame. <i>“Come on, move this corpse.”</i> She tries to command you, but you mock her and explain to her that she is in no position to be disrespectful. After mumbling for herself, she finally speaks up. <i>“Please "+ GameControl.playerName +"... Please take this corpse off me.”</i> Its good, but not enough. <i>“Not enough?! Mmmhpf... Please "+ GameControl.playerName +", I can’t lift this corpse, I need your help, please rescue me. There, better?”</i> you laugh and finally help her get under it. \n\nBoth of you return to the gates on foot. Although you expected her to be more mad, she stays quiet and passive until both are back home. \n\nAt the end of the day, only half of the group is back into the city. <i>“Ngh... Things were not this bad few months ago, this ambush was big and well organized, at least for beasts. We need to investigate this further, but for now we need to regroup.”</i>\n\nYou part ways once at the gate, promising to join her soon.";
			}

			if (QuestControl.faustinaDom) {
				Board.text = "You take just a moment to inspect the scene: The monsters are all distracted groping her and tearing her clothes apart. You can see how she struggles and tries to moves towards a knife that is meters away from her, but she can barely act under these circumstances. Without time for any second thought, you run towards them, but you clumsily fall on the ground, throwing your weapon away. All the beast turn to look at you and laugh. Two of them start to walk towards you and the only you can do is to sit on your ass and crawl away from them. When they are almost on top of you the screaming of the beast that was on top of Faustina makes everyone turn. \n\nApparently, your weapon landed in front of her, and with a swift move she grabbed it and killed the beast that was pinning her down. She has killed a second one before they can even react, and the two that were on front of you run away before they face Faustina’s wrath. \n\nHer breathing is agitated, and most of her skin is exposed, but overall she doesn’t looks injured. You ask if she is fine but she looks at you with anger in her eyes. <i>“You are really useless. You really had to crash these party we had? Also you can’t stand straight even if your life depended on it. Come on, we need to get going.”</i> she turns around and whistles calling the horse, but none comes. \n\nAnnoyed, she hands you her backpack. <i>“Carry this, do a good service for once.”</i> although she still acts angry, you feel that her tone is less hostile against you, although she doesn’t show any soft spot to you. \n\nAt the end of the day, only half of the group is back into the city. She talks to the soldiers, almost totally ignoring your presence.  <i>“Ngh... Things were not this bad few months ago, this ambush was big and well organized, at least for beasts. We need to investigate this further, but for now we need to regroup.”</i> once she is done talking with the soldiers, she talks to you before you leave. \n\n<i>“You better stick to me in the future "+ GameControl.playerName +" or at the very least don’t interfere with my fights. You really can’t do nothing on your own, so you’ll make sure to heed my very order next time.”</i> You nod at her and parts way, telling her that you’ll be back soon.\n";
			}


			QuestControl.faustinaQuest = 3;
			NPCCharList.CharFollower [iFaustina].corruptionStage -= 1;
			endTurnFun ();

			return;
		}

		if (selector == 1 && confirmationControl == 102) {
			Board.text = "You sit down and watch the scene. Faustina really fights hard, breaking noses, teeth and probably some bones, but she cant stop the inevitable. \n\nA big wolf man stays on top of her, holding her, while the other three; a fine catgirl, a horseman and a catboy, tear all her clothes apart, leaving her practically naked except for some rags. ";

			if (WorldControl.futaOn) {
				Board.text += "\n\nAlthough you can see her face shows disgust, you can see her half erection exposed. <i>“Dying for some action, bitch?”</i> says the wolf while he starts to roughly jerk her off <i>“Take your hands off me beast!”</i> The harder her dick gets, the weaker her struggle is.\nThe other beasts get themselves ready, touching themselves while they explore her body with their hands. \n\nThe wolf moves her closer to him, the tip of his cock at the entrance of her backdoor <i>“You are shaking from expectation bitch, don’t worry, we’ll make sure to satiate your lust!”</i> He lifts her from her waist, ready to impale her. <i>“N-No! Stop!”</i> she yells in vain, and with a single pull the beast enters her body, the loud sound of skin slamming skin echoing the forest. The wolf growls in celebration, while the rest of beasts celebrate along his side. \n\nThe wolf uses her, fucking her as if she was an animal like him. The first minutes Faustina struggles and resists, but the act is useless and the might of the wolf cock starts to get the best of her, who now is engaged in a mental fight against the pleasure. \n\nWith her mind focused on something else, the group gets ready to enjoy her: The catgirl jumps on top of her, and without any ceremony squats on Faustina’s dick, riding her with the same enthusiasm that the wolf has. The catboy sits in front of her, and starts to use her breasts to pleasure himself, while the horse forces his big dick through her mouth. The mere sight of that big dick going inside here makes you think she’ll break, or at least her jaw would dislocate, but the General is showing that she can take a heavy pounding through any orifice, resisting even the natural instinct to puke even if the horse dick goes deep into her throat. \n\nThe scene is wild: There is no rhythm, no elegance, just unfulfilled lust. All of them move at their own whim, and you can see how the general has problems holding at anything or anyone there.\n\nYou dare to move a little closer, and you can see how the fierce eyes of Faustina has changed: Her eyes are lost on the horizon, and you can hear moaning. Her whole face is a mess from all the tears and drolling, but it is obvious that she is enjoying the rough treatment now.\n\nIt doesn't take long until the wolf starts to cum inside her, which makes her start to shiver from pleasure. The climax of these two prompt the others to cum too, and after a couple of minutes of shooting fluids the first round is over: The catgirl on top of her, spilling  Faustina cums on her body, and her hair, face and chest drenched in the cum of the other two. Faustina doesn’t reacts much, but the other girl starts to clean with her tongue while the others change holes.\n\n";

			} else {
				Board.text += "\n\nAlthough you can see her face shows disgust, you can see her cunt already wet. <i>“Dying for some action, bitch?”</i> says the wolf while he starts to finger her <i>“Take your hands off me beast!”</i> The deeper he goes, the weaker her struggle is.\nThe other beasts get themselves ready, touching themselves while they explore her body with their hands. \n\nThe wolf moves her closer to him, the tip of his cock at the entrance of her backdoor <i>“You are shaking from expectation bitch, don’t worry, we’ll make sure to satiate your lust!”</i> He lifts her from her waist, ready to impale her. <i>“N-No! Stop!”</i> she yells in vain, and with a single pull the beast enters her body, the loud sound of skin slamming skin echoing the forest. The wolf growls in celebration, while the rest of beasts celebrate along his side. \n\nThe wolf uses her, fucking her as if she was an animal like him. The first minutes Faustina struggles and resists, but the act is useless and the might of the wolf cock starts to get the best of her, who now is engaged in a mental fight against the pleasure. \n\nWith her mind focused on something else, the group gets ready to enjoy her: The catboy moves behind her, filling her empty ass with his cock and letting her lie on top of him. The catgirl jumps on top of her, and without any ceremony squats on Faustina’s face, riding her with the same enthusiasm that the wolf has. The horse sits on her stomach, using the generous breasts of the general to pleasure himself while, thanks to its long reach, penetrates the ass of the catgirl. You wonder if they gonna tear her apart, since none of them show any consideration for her well being, but the General is showing that she can take a heavy pounding through any orifice. \n\nThe scene is wild: There is no rhythm, no elegance, just unfulfilled lust. All of them move at their own whim, and you can see how the general has problems holding at anything or anyone there.\n\nYou dare to move a little closer, and you can see how the fierce eyes of Faustina has changed: Her eyes are lost on the horizon, and you can hear moaning. Her whole face is a mess from all the tears and drolling, but it is obvious that she is enjoying the rough treatment now.\n\nIt doesn't take long until the wolf starts to cum inside her, which makes her start to shiver from pleasure. The climax of these two prompt the others to cum too, and after a couple of minutes of shooting fluids the first round is over: The catgirl on top of her, spilling  the horse cum on Faustina’s body, drenching and her hair, face and chest. Faustina doesn’t reacts much, but the other girl starts to clean with her tongue while the others change holes.\n\n";

			}

			Board.text += "The orgy keeps going for almost an hour, and although the beast are not satisfied, they wise up. <i>“Boss, we need to go, soldiers may come back soon.”</i> says the horseman. <i>“Nggh I still have this hard on... Fuck, forget it, let’s take her with us.”</i> when you heard that, you decide to come out of your hiding spot. <i>“Shit! Run! Run away!”</i> screamed the catboy, and all of them follow through his suggestion. Lucky for you, the beast were exhausted of so much fucking, and didn’t had the strength or the will to put up a fight, which is good since who knows if you could had handle the four of them, even if they were tired. \n\nYou rush to Faustina’s side and you hand her what’s left of her own cape to cover herself. <i>“Ahhh... What happened...”</i> You tell her she doesn’t has to worry, that everything is over, that you rescued her. <i>“Ahh... You did?... Thanks "+ GameControl.playerName +"”</i> She smiles at you and passes out. \n\nYou return to the city carrying her in your arms. Once there, you can see some of the soldiers that were in the squad with you at the gates. At least half of them were kidnapped or else, but at least now you know that things are getting worse. You take her to her tent, where she regains consciousness <i>“I... Don’t know how to thank you, I was wrong "+ GameControl.playerName +", I-”</i> you tell her that its fine, that she needs to rest now but you’ll be back soon to talk with her. She nods at you and falls asleep, and you go to your castle to recover some of your strength yourself. ";

			QuestControl.faustinaQuest = 3;
			endTurnFun ();
			NPCCharList.CharFollower [iFaustina].corruptionStage += 1;
			return;
		}


		///////////////////////////// fight against / embrace

		if (selector == 0 && confirmationControl == 103) {
			Board.text = "Although you understand how she was happy when his brother got better, did he really? Can happiness exist with one lacks self control and agency? You know it’s a hard issue, and you have a deep talk with her about the matter at hand. You explain to her that although is normal to feel good for the apparent improvement of his brother, in truth she only has to see around to realize that deep inside, it is a curse that will deprive him for any real progress or achievement. \n\nThe conversation is over after two hours, with both of you sitting in the same coach, close to each other.\n\n<i>“Yes, you are right "+ GameControl.playerName +"...”</i> she finally agrees with you.\n\nHer eyes are fixed on yours, expressing both gratitude and great relief. <i>“I’ve been looking forward to have this talk for years... I’m happy it finally happened.”</i> there is a long pause when she is done talking. The silence is not uncomfortable, both of you are looking deep into each others eyes. \n\nAfter long minutes, you can feel the tip of her fingers touching yours, sexual tension floating in the air. Do you want to keep going?\n\n";

			QuestControl.faustinaQuest = 4;
			option0Name.text = "Have sex";
			option1Name.text = "Refuse";
			confirmationControl = 104; 
			NPCCharList.CharFollower [iFaustina].corruptionStage -= 1;
			return;
		}

		if (selector == 1 && confirmationControl == 103) {
		
			Board.text = "It’s easy to understand why she was happy when his brother got better. You feel moved with her past, and a tragedy that her brother was ostracized from society just when his health was improving. You have a deep talk with her about the matter at hand, reassuring her that its not her fault but society’s, who pushed her to the abyss. Although she is reluctant, you persuade her to give up her internal fight, telling her that the city and herself need to look forward now, there is nothing else that can be done about the past. \n\nThe conversation is over after two hours, with both of you sitting in the same coach, close to each other.\n\n<i>“Yes, you are right "+ GameControl.playerName +"...”</i> she finally agrees with you.\n\nHer eyes are fixed on yours, expressing both gratitude and great relief. <i>“I’ve been looking forward to have this talk for years... I’m happy it finally happened.”</i> there is a long pause when she is done talking. The silence is not uncomfortable, both of you are looking deep into each others eyes. \n\nAfter long minutes, you can feel the tip of her fingers touching yours, sexual tension floating in the air. Do you want to keep going?\n";

			QuestControl.faustinaQuest = 4;

			option0Name.text = "Have sex";
			option1Name.text = "Refuse";
			confirmationControl = 104; 
			NPCCharList.CharFollower [iFaustina].corruptionStage += 1;
			return;
		}


		///////////////////////////// have sex / refuse 

		if (selector == 0 && confirmationControl == 104) {

			Board.text = "You hold hands with her, the silence of the room being interrupted only by the crackling fire. You lean forward, your noses touch and your eyes are lock on hers. \n\n<i>“W...”</i> you silence her with a finger on her lips, and then gently start to caress her cheek. She smiles at you for the first time, at least able to see behind her harsh facade. As you advance towards her, she only closes her eyes, her mouth slightly open waiting for you. You can feel her body shaking when your lips touch. <i>“Ahh... "+ GameControl.playerName +", we shouldn’t...”</i> But her words are contradicted when she starts to embrace you.\n\nYour tongue is fighting with hers, and the two of you push each other to see who stays on top, but at the end she gives up. <i>“Alright, just this time "+ GameControl.playerName +", your reward for passing the challenge.”</i> the both of you keep kissing and touching each other, slowly removing all your clothes.\n\n";


			if (GameControl.dick1Size > 0 && WorldControl.futaOn) {
				//if dick mc and futa
				Board.text += "You grab her generous, soft breasts, playing with her nipples. She reciprocates with her gentle hands, with her hands ending up caressing your ass. <i>“What you have here... Ohhh you are really eager "+ GameControl.playerName +"...”</i> she says when her right hand explores you down there for the first time, softly feeling the length and girth of your mast. She starts to kissing you again, while she slowly jerks you off until your pre is dripping on her belly and legs. \n\nYou return the favor and grab her cock too, playing with its head and balls. When your hands are drenched on her pre, you mix it in your cock, ready to go. \n\n<i>“Don’t be delicate, you bet I can take a pounding.”</i> she guides your dick to her back entrance, rubbing its head around. You can feel her heat, and you can see in her face that she is ready to go wild. \n\nAlthough she told you to let yourself go, you decide to take it slow, enjoying her for the first time. Her strong and rough body is truly the one of an experienced fighter, full of scars from past battles, a very different body from the typical maiden that doesn’t work a single day of her life.  \n\nShe holds at you by the neck and both of you start to move your hips faster. You trust forward deep on her, and kiss her neck. You can feel her bitting your ear and her nails scratching your back. You grab her hair and pull her head, to which her body reacts by clenching your dick tighter. \n\nBitting, scratching, and even an occasional slap, the adrenaline rush from the pain makes the two of you going faster. <i>“Yes! Harder! Fuck me harder! Give me all you have "+ GameControl.playerName +"!”</i> you fulfill her request, dedicating your whole body to satiate her lust.\n\n<i>“Ahh! Yes! Right there! Make me cum "+ GameControl.playerName +"!”</i> you double your efforts, and you can hear the couch and your moanings echoing through the base, but you’re not concerned at all. \n\nAt the final moment, she impales herself deep into you, grabbing your neck and back with her arms, while she forces you to stay close to her with her legs. \n\nYou can’t hold yourself anymore, and start to cum deep inside her. <i>“Ahh! It’s so hot! Fill me up!”</i> Her body shakes from her own climax, bathing you and herself with her semen. After you’re finally empty, you fall on top of her, asleep and exhausted.\n\nAfter a short nap you wake up, with her still under you, playing with your hair. <i>“Thanks "+ GameControl.playerName +", I think the both of us needed that.”</i> You give her a kiss and stand up, ready to leave. <i>“There are still some matters to attend, come back soon for that "+ GameControl.playerName +", and maybe more fun.”</i> you chuckle and promise her to be back soon to inspect the troops and their progress. \n\nWhen you go she is still naked on the coach, still tired but satisfied by your performance. ";

			} else if (GameControl.dick1Size > 0 && WorldControl.futaOn == false) {
				//if dick and non futa
				Board.text += "You grab her generous, soft breasts, playing with her nipples. She reciprocates with her gentle hands, with her hands ending up caressing your ass. <i>“What you have here... Ohhh you are really eager "+ GameControl.playerName +"...”</i> she says when her right hand explores you down there for the first time, softly feeling the length and girth of your mast. She starts to kissing you again, while she slowly jerks you off until your pre is dripping on her belly and legs. \n\nYou return the favor and explore her nether parts, playing with her clit and slowly fingering her. When your hands are drenched on her juice, you decide is time to go. \n\n<i>“Don’t be delicate, you bet I can take a pounding.”</i> she guides your dick to her entrance, rubbing its head around. You can feel her heat, and you can see in her face that she is ready to go wild. \n\nAlthough she told you to let yourself go, you decide to take it slow, enjoying her for the first time. Her strong and rough body is truly the one of an experienced fighter, full of scars from past battles, a very different body from the typical maiden that doesn’t work a single day of her life.  \n\nShe holds at you by the neck and both of you start to move your hips faster. You trust forward deep on her, and kiss her neck. You can feel her bitting your ear and her nails scratching your back. You grab her hair and pull her head, to which her body reacts by clenching your dick tighter. \n\nBitting, scratching, and even an occasional slap, the adrenaline rush from the pain makes the two of you going faster. <i>“Yes! Harder! Fuck me harder! Give me all you have "+ GameControl.playerName +"!”</i> you fulfill her request, dedicating your whole body to satiate her lust.\n\n<i>“Ahh! Yes! Right there! Make me cum "+ GameControl.playerName +"!”</i> you double your efforts, and you can hear the couch and your moanings echoing through the base, but you’re not concerned at all. \n\nAt the final moment, she impales herself deep into you, grabbing your neck and back with her arms, while she forces you to stay close to her with her legs. \n\nYou can’t hold yourself anymore, and start to cum deep inside her. <i>“Ahh! It’s so hot! Fill me up!”</i> Her body shakes from her own climax, and after shooting many loads, you’re finally empty, falling on top of her, asleep and exhausted.\n\nAfter a short nap you wake up, with her still under you, playing with your hair. <i>“Thanks "+ GameControl.playerName +", I think the both of us needed that.”</i> You give her a kiss and stand up, ready to leave. <i>“There are still some matters to attend, come back soon for that "+ GameControl.playerName +", and maybe more fun.”</i> you chuckle and promise her to be back soon to inspect the troops and their progress. \n\nWhen you go she is still naked on the coach, still tired but satisfied by your performance.";

			} else if (GameControl.dick1Size <= 0 && WorldControl.futaOn) {
				//if vagina and futa
				Board.text += "You grab her generous, soft breasts, playing with her nipples. She reciprocates with her gentle hands, with her hands ending up caressing your ass. <i>“Oh my... you are as excited as myself "+ GameControl.playerName +"...”</i> she says when her right hand explores you down there for the first time, softly feeling your already wet pussy. She starts to kissing you again, while she slowly fingers you until you are dripping on her belly and legs. \n\nYou return the favor and grab her cock too, playing with its head and balls. When your hands are drenched on her pre, you rub it on your nether parts, ready to go. \n\n<i>“I won’t be delicate, so you better get ready for a good pounding.”</i> You help her guide her hard cock at your entrance, rubbing its head around first. You can feel the heat of her body, and her face shows that she is ready to go wild. \n\nAlthough she warned you, you weren’t as ready as you thought: With a single trust she slams her cock deep into you, and you can hear her laughing and yelling of pleasure. You get a hold on her: Her strong and rough body is truly the one of an experienced fighter, full of scars from past battles, a very different body from the typical maiden that doesn’t work a single day of her life.  \n\nShe holds at you by the neck and both of you start to move your hips faster. You trust forward to her her deep on you, and kiss her neck. You can feel her bitting your ear and her nails scratching your back. You grab her hair and pull her head, to which her body reacts by clenching your dick tighter. \n\nBitting, scratching, and even an occasional slap, the adrenaline rush from the pain makes the two of you going faster. <i>“Yes! Harder! I want to fuck you harder! Give me all you have "+ GameControl.playerName +"!”</i> you fulfill her request, dedicating your whole body to satiate her lust.\n\n<i>“Ahh! Yes! Right there! Make me cum "+ GameControl.playerName +"!”</i> you double your efforts, and you can hear the couch and your moanings echoing through the base, but you’re not concerned at all. \n\nAt the final moment, she gives you a final deep trust, grabbing your neck and back with her arms, while she forces you to stay close to her with her legs, filling your cunt with her seed. \n\nYou can’t hold yourself anymore, and you start to climax. <i>“Ahh! Yes! Cum with me!”</i> Her powerful orgasms make her shake, and after several waves of pleasure and loads of cum, she is finally done. You, too exhausted, fall asleep on top of her.\n\nAfter a short nap you wake up, with her still under you, playing with your hair. <i>“Thanks "+ GameControl.playerName +", I think the both of us needed that.”</i> You give her a kiss and stand up, ready to leave. <i>“There are still some matters to attend, come back soon for that "+ GameControl.playerName +", and maybe more fun.”</i> you chuckle and promise her to be back soon to inspect the troops and their progress. \n\nWhen you go she is still naked on the coach, still tired but satisfied by your performance. ";

			} else if (GameControl.dick1Size <= 0 && WorldControl.futaOn == false) {
				Board.text += "You grab her generous, soft breasts, playing with her nipples. She reciprocates with her gentle hands, with her hands ending up caressing your ass. <i>“Oh my... you are as excited as myself "+ GameControl.playerName +"...”</i> she says when her right hand explores you down there for the first time, softly feeling your already wet pussy. She starts to kissing you again, while she slowly fingers you until you are dripping on her belly and legs. \n\nYou return the favor and explore her nether parts, playing with her clit and slowly fingering her. When your hands are drenched on her juice, you are ready.\n\nShe ask you to stand and go for something in the wood dresser. There, you find a long sex toy, a double dildo perfect for some action. <i>“Believe it or not, I haven’t used it yet, I was waiting for the right person.”</i> You go back on top of her.\n\n<i>“Still don’t be delicate, you bet I can take a pounding.”</i> once you put the toy inside you, she guides it to her entrance, rubbing its head around. You can feel the heat of her body, and you can see in her face that she is ready to go wild. \n\nAlthough she told you to let yourself go, you decide to take it slow, enjoying her for the first time. Her strong and rough body is truly the one of an experienced fighter, full of scars from past battles, a very different body from the typical maiden that doesn’t work a single day of her life.  \n\nShe holds at you by the neck and both of you start to move your hips faster. You trust forward deep on her, and kiss her neck. You can feel her bitting your ear and her nails scratching your back. You grab her hair and pull her head, to which her body reacts by clenching your dick tighter. \n\nBitting, scratching, and even an occasional slap, the adrenaline rush from the pain makes the two of you going faster. <i>“Yes! Harder! Fuck me harder! Give me all you have "+ GameControl.playerName +"!”</i> you fulfill her request, dedicating your whole body to satiate her lust.\n\n<i>“Ahh! Yes! Right there! Make me cum "+ GameControl.playerName +"!”</i> you double your efforts, and you can hear the couch and your moanings echoing through the base, but you’re not concerned at all. \n\nAt the final moment, she impales herself deep into you, grabbing your neck and back with her arms, while she forces you to stay close to her with her legs. \n\nYou can’t hold yourself anymore, and you start to climax. <i>“Ahh! I’m there too!”</i> Her powerful orgasms make her shake, and after several waves of pleasure, you’re finally done, falling on top of her, asleep and exhausted.\n\nAfter a short nap you wake up, with her still under you, playing with your hair. <i>“Thanks "+ GameControl.playerName +", I think the both of us needed that.”</i> You give her a kiss and stand up, ready to leave. <i>“There are still some matters to attend, come back soon for that "+ GameControl.playerName +", and maybe more fun.”</i> you chuckle and promise her to be back soon to inspect the troops and their progress. \n\nWhen you go she is still naked on the coach, still tired but satisfied by your performance. ";
			}


			NPCCharList.CharFollower [iFaustina].charLove = 10;

			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 104) {

			if (QuestControl.faustinaEqual) {
				Board.text = "You decide to stand up, telling her that it is late and you need to go back to your castle. You can see she is a little disappointed, but still happy for the conversation you just had. <i>“Yes we need some rest, there is still a lot of work left. I still need your opinion to resolve a couple of matters, so I hope I can count with you on that.”</i> you nod, telling her that of course you’ll back soon to inspect the troops, hoping to see some progress soon.\n\n<i>“Very well, have a good night then "+ GameControl.playerName +".”</i> You leave the place, hoping this won’t hurt your relationship. \n";
			}

			if (QuestControl.faustinaSub) {
				Board.text = "You decide to stand up, telling her that it is late and you need to go back to your castle. You can see she is a little disappointed, but still happy for the conversation you just had. <i>“Yes we need some rest, there is still a lot of work left. I still need your opinion to resolve a couple of matters, so I hope I can count with you on that.”</i> you nod, telling her that of course you’ll back soon to inspect the troops, hoping to see some progress soon.\n\n<i>“Very well, have a good night then "+ GameControl.playerName +".”</i> You leave the place, hoping this won’t hurt your relationship. \n";
			}

			if (QuestControl.faustinaDom) {
				Board.text = "You shake your head and tell her that you are not fine with this. All your hopes that she was going to react nicely about it are shattered instantaneously when you receive a slap on your face. <i>“How dare you, you little bitch? After everything I have done for you?! Which kind of slave you are?!”</i> she unsheathes her weapon, but she sobers up enough to stop before is too late, throwing her weapon to the ground.\n\n<i>“Just go, leave me alone. We continue our duties tomorrow.”</i>\n\nYou run away as fast as you can to your castle, hoping she doesn't change her mind, but for your relief the next day she acts as if nothing had happened, although all the subtle interest she had for you is gone now. \n\n\n";
			}

			endTurnFun ();
			return;
		}


		///////////////////////////// Sex slaves / forced labor

		if (selector == 0 && confirmationControl == 105) {
			Board.text = "You agree to go with her plan. Although you are doubtful of the success she says it will have, you lose nothing by letting her do this, and the benefits it may yield are worth it. <i>“Thanks "+ GameControl.playerName +"! You won’t regret your confidence on me.”</i> She leaves the tent very happy. \n\nDuring the next weeks you see how her plan is in full motion, bringing a lot of sex toys, skimpy clothing, and some bondage equipment like some torture devises, handcuffs, spanking tables, among others. Her personal tent has been transformed to take care of disobedient slaves, decorating it as a fancy BDSM dungeon. Her improved mood and the prospects of new playthings is motivating her to do her task efficiently. \n\nOnce you give a quick inspection to the place you go back to the castle, the city finally under your total command.";

			CityControl.slavesSexWork = true;
			QuestControl.faustinaQuest = 5; 
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 105) {
			Board.text = "You explain to her why you don’t have so much hope about the beasts, and at this point the city cannot afford these kind of experiments. Your answer saddens her, but she understand your position. <i>“You are right "+ GameControl.playerName +", it is not time to risk the city with these kind of games, I’ll make sure to keep the current policies on place.”</i> She leaves the tent in a bad mood, but she isn’t defiant. \n\nDuring the next weeks Faustina renews a lot of old equipment for the slaves, talk with local leaders and farmers, and makes sure to fix any problem that exists under the current system. Although at first she wasn’t happy, there is too much work to be done that she doesn’t even has the luxury to think about that again. \n\nAfter a long week of work, you are ready to go back to your castle, the city finally under your total command.";
			CityControl.slavesForcedLabor = true;
			QuestControl.faustinaQuest = 5; 
			endTurnFun ();

			return;
		}



		///////////////////////////// temp

		if (selector == 0 && confirmationControl == 9999) {

			if (QuestControl.faustinaEqual) {
				Board.text = "";
			}

			if (QuestControl.faustinaSub) {
				Board.text = "";
			}

			if (QuestControl.faustinaDom) {
				Board.text = "";
			}

			return;
		}

		if (selector == 1 && confirmationControl == 9999) {

			if (QuestControl.faustinaEqual) {
				Board.text = "";
			}

			if (QuestControl.faustinaSub) {
				Board.text = "";
			}

			if (QuestControl.faustinaDom) {
				Board.text = "";
			}

			return;
		}



	}
	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




	void defineFaustinaStart(){

		int yz = 0; 

		while (yz < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [yz].charID == 11000){
				
				if (NPCCharList.CharFollower [yz].corruptionStage > 0) {
					QuestControl.faustinaStartCorrupt = false;
				} else {
					QuestControl.faustinaStartCorrupt = true;
				}
				break;
			}
			yz++;

		}
	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


	void loadFaustina(){
		iFaustina = 0;

		while (iFaustina < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iFaustina].charID == 12000){
				WorldControl.NPCID = NPCCharList.CharFollower [iFaustina].charID;
				//WorldControl.PortraitID = NPCCharList.CharFollower [iFaustina].charPortrait;
				WorldControl.furryPic = NPCCharList.CharFollower [iFaustina].isFurry;
				WorldControl.futaPic = NPCCharList.CharFollower [iFaustina].isFuta;
				break; 
			}
			iFaustina++;

		}

	}

	static int iLucretius; 

	void loadLucretius(){
		iLucretius = 0;

		while (iLucretius < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iLucretius].charID == 11000){
				break; 
			}
			iLucretius++;

		}

	}



	void endTurnFun(){
		//panContinue.sortingOrder = -500;
		panConfirmation.sortingOrder = -500;
		panMainPanel.sortingOrder = -500;

		PanLeftManagement.endTurnControl = true; 
		endTurnPanel.sortingOrder = 500;


	}


	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void Awake(){
		loadFaustina ();


	}

	void Start(){
		option0Name.text = "";
		option1Name.text = "";
		option2Name.text = "";
		option2Butt.interactable = false; 


		faustinaStart ();
	}

}
