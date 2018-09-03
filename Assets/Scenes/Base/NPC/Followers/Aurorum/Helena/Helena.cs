using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Helena : MonoBehaviour {
	static string mcpronoun; 
	int hashcode = GameControl.playerName.GetHashCode();
	int randNum;

	public Canvas endTurnPanel; 

	public Text Board; 
	static int iHelena;

	static int confirmationControl; 
	static int continueControl; 

	//public Canvas panContinue;


	public Canvas panConfirmation;

	public Canvas panMainPanel;

	public Text option0Name;
	public Text option1Name;
	public Text option2Name;
	public Text option3Name;

	public Button option2Butt; 
	public Button option3Butt; 

	static int iAbbadon;
	static int iAlba;


	// // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // 
	public void helenaStart(){
		switch (QuestControl.helenaQuest) {
		case 0:
			loadFollowers ();
			WorldControl.day += 21;


			GameControl.charGold -= 3000;
			if (GameControl.charGold < 0) {
				GameControl.charGold = 0;
				Board.text = "You wasted the money that was originally meant to repair your castle, and have to ask Abbadon and Alba for a loan to pay for the repairs. They do this reluctantly, costing you some of their good will. \n\n";
				NPCCharList.CharFollower [iAlba].charLoyalty -= 5;
				NPCCharList.CharFollower [iAlba].charRelationship -= 10;
				NPCCharList.CharFollower [iAbbadon].charLoyalty -= 5;
				NPCCharList.CharFollower [iAbbadon].charRelationship -= 10;
			} else {
				Board.text = "";
			}

			Board.text += "For the next three weeks you oversee the workers that are in charge of repairing your castle, who promised to have everything done in a month. However at this point, they are well behind schedule. You talk with the foreman, a very stout and muscular half human, half bear, who explains to you that his workers are just too exhausted since they can’t afford to properly feed or house themselves.\n\nYou talk to him about the issue, looking for a solution to your mutual problem. He suggests that you increase their wages a total of 50 gold coins, just enough for proper food and rest until the project is over. The cost makes you hesitate, and the fact that they failed to honor the contract with you brings an idea to mind. This would be a perfect opportunity to test out your castle’s dungeon, using the foreman as an example to any who would think of stealing from your kingdom.";
			panConfirmation.sortingOrder = 500; 
			confirmationControl = 0;
			option0Name.text = "Increase wages";
			option1Name.text = "To the dungeon!";
			option2Name.text = "";
			option2Butt.interactable = false; 
			break;
		case 1: 
			Board.text = "Your castle is still lacking one of its key components: It’s servants! Without them, your castle is only a quiet and empty husk that gathers dust. You call Helena into your throne room and ask her to contact the former servants. <i>“The former servants? They’ve left long ago, and I’ve lost contact with them… Those that hadn’t succumbed to the plague fled the city, and almost all of them would likely refuse to return to this place after… Well let’s just say your uncle did not leave them with many fond memories.”</i>\n\nYou sigh, biting your tongue to avoid any cursing before asking her what your options are. <i>“Well there is an academy that trains and educates butlers and servants for the nobility here in the city. You can get plenty of staff from that place, but hiring them would be costly… Because you’d hire them, right my liege?”</i> Although it hadn’t been considered until now, you could pressure the academy to ‘donate’ servants to you. This would certainly tarnish your standing with the city permanently, so you abandon the idea.\n\nWhen you ask her to escort you, she hesitates briefly before nervously asking you to follow. While you are unsure at first, the reason for her unease is clear as you find that the most direct path to the academy is through the infamous red district. While thankful that your shoes separate your feet from the filthy street, a spark of creativity comes to mind. Why not hire the prostitutes and deranged from here? Not only would they be immensely cheaper to take in, few would care if you kidnap and force a more productive lifestyle upon them. In fact, some may even commend you for cleaning up the streets! However, their current… ‘talents’ and upbringing would be reflected in their performance. They would certainly need work, but they could also prove entertaining in more than a few ways… \n";

			panConfirmation.sortingOrder = 500; 
			confirmationControl = 1;
			option0Name.text = "Hire professionals";
			option1Name.text = "Hire whores";
			option2Name.text = "";
			option2Butt.interactable = false; 
			break;
		case 2: 
			WorldControl.day += 7;

			Board.text = "After several days of hard work and effort, Helena comes to you with a number of complaints. <i>“My liege, these people are... Unfit to work! They refuse to follow my orders, and they are incapable of taking care of even basic housework. You must do something about this!”</i>\n\nThe frustration’s source is clear as you command the new staff into the throne room, the men and women you hired proving to be anything but respectful. Many idly talk amongst themselves, some slouching against walls and others picking their noses. One even has the gall to fall asleep in direct view of your seat! The guards notice this and begin to flank the servants, them hushing their conversations and quickly standing at attention.\n\nYou and Helena walk in front of the row, inspecting and correcting their posture. Throughout this, you witness the sweet, patient and shy Helena take on a more upfront and confrontational personality, her blood boiling from the attitude of the servants. Being the one person who cared for the castle and called it her home for so long, it is a justified response. These new servants came into the manor and disrespected both of you after graciously hiring and housing them all! While she may just be a maid, Helena has been nothing but loyal and easy going. Even she must have a limit of patience.\n \nYou address the hirelings, telling them that serving the castle is their current purpose, not chatting. When one begins to chuckle loudly, there isn’t a moment to silence the offender before they are on the floor, a bright red hand print burning on a cheek as Helena stares furiously down at them. As everyone, yourself included, stares at her with jaws dropped, she seems to suddenly realize what she did and backs away, apologizing profusely to you for her actions.\n\nYou could scold her about her sudden hostility, or possibly encourage her to take more action in the future.";
			panConfirmation.sortingOrder = 500; 
			confirmationControl = 3;
			option0Name.text = "Scold her";
			option1Name.text = "Encourage her";
			option2Name.text = "";
			option2Butt.interactable = false; 
			break;

		case 3: // seasonal festival
			WorldControl.day += 10;
			Board.text = "After a week of preparations, everything is finally ready for the seasonal festival. \n\nHelena has been working nonstop to prepare this, even with the unprepared staff causing her difficulties. <i>“My liege, we only have a few days left, but we still need to decide what kind of entertainment we will provide.”</i> she says in a stressed tone, <i>“May I suggest to leave me in charge of that? I’ve searched the city and found several potential musicians and performers that would do a great job entertaining the guests.”</i>\n\nShe urges you to follow her to the main square to show you what she has in mind. While walking through the busy streets, you can see how the people are ogling your new staff, their lustful bodies and skimpy uniforms catching many stares. Once at the main square, Helena guides you to the show that begins the moment you are seated. While it was entertaining, the artists clearly talented, you note how a good share of the public are still eying your maids, their interests in the flesh shadowing the arts.\n\n\n<i>“Did you like the spectacle?”</i> asks Helena once it concludes. You nod, but your darker thoughts arise: What if instead of hiring these artists, why not use your current staff for entertainment? Many know how to dance, cater to guests, and can utilize more sensual skills for a fun and passionate night. While some may not be as eager to partake in this, a quick detour to the alchemist would ensure that the food and drink would have enough aphrodisiacs to get everyone into the mood.\n\n<i>“My liege? Are you there?”</i> Helena snaps you out of your dirty thoughts and you apologize for being distracted. <i>“Should we hire them my liege?”</i> \n\nNote: Debauchery will be a group sex scene with several characters, and bi content for your character.";
			panConfirmation.sortingOrder = 500; 
			confirmationControl = 5;
			option0Name.text = "Hire artists";
			option1Name.text = "Debauchery";
			option2Name.text = "";
			option3Name.text = "";
			option2Butt.interactable = false;
			option3Butt.interactable = false;
			break;

		case 4: // dark secrets 
			WorldControl.PortraitIDLayer0 = 0; 
			WorldControl.PortraitIDLayer1 = 0; 
			WorldControl.PortraitIDLayer2 = 0; 

			Board.text = "After the festival, you stumbled with a secret passage inside of your bedroom, with stairs that go deep under the ground. Nor the people in charge of repairing your castle nor Helena mentioned this place, and by the amount of dust and webs, you are fairly certain none has entered this place in years.\n\nYou equip yourself ready to explore, making sure to block your door of your bedroom, and commanding your guards to not be disturbed until further orders.\n\nWith a torch in your hand, you start to walk downstairs. Although you thought at first this couldn’t be deeper than the dungeon, you find out that there is an enormous cavern down there. You carefully keep your descend until you finally reach the bottom. There, you can see there is a small laboratory, with an altar of a goddess in the middle of it. The woman has a vessel in her hands, pouring some dark, murky liquid to a small pool underneath her. \n\nThe laboratory has vials, racks with ingredients, and other tools for alchemy. There is a table with a big book on top of it. You get close to it, but after you dust it you see it has no name or anything. When you open it, you can see that the former owner was probably your uncle, the writing similar to other documents that he had signed in the past. \n\nThe book is part diary, part experimentation log. You can see that your uncle was obsessed with the topic of the soul and its properties, specifically how to change it. According to him, a soul can be tainted or purified, but clearly he was only interested on the former. \n\nHe explored different ways to do this. Alchemy was more fast and powerful, according to him, but hypnosis was also a good alternative when he needed subtlety. According to him, you can also use dark magic, but there are very few practitioners of the arcane arts, and he was not one of them.\n\nReading more in depth the book you find several recipes for drugs and techniques for the proper use of hypnosis. You learn the basics of them. Although your skill is still low, there is no doubt you’ll be able to test it and see if this is true at all, or just the rantings of a mad man.\n\nBefore you leave the place, you see that your uncle installed pots to grow up plants that he watered with the black fluid of the statue. There is plenty of supply for you to use on individuals, but not enough if you wanted to do a mass scale corruption of the city. ";
			Board.text += "\n\nVisits to Helena, Abbadon and Alba unlocked.";
			GameControl.attHypnotism = 10; 
			GameControl.charCorruption += 3;
			GameControl.utilitySkillAlchemy += 5; 
			endTurnFun ();

			loadFollowers ();
			NPCCharList.CharFollower [iHelena].isRecruited = true;
			NPCCharList.CharFollower [iAbbadon].isRecruited = true;
			NPCCharList.CharFollower [iAlba].isRecruited = true;
			NPCCharList.CharFollower [iAbbadon].attWillpower = 105;

			QuestControl.helenaQuest = 5;
			Quest LucinaQuest1 = new Quest ();
			QuestsController.createQuest (LucinaQuest1, "Reunion", "Helena comes at you with haste to inform you about an unexpected guess in the dungeon.", 62, 6000);
			QuestsController.RemoveID (3004);

			Quest AbbadonQuest10 = new Quest ();
			NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1000;
			NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 0;
			NPCCharList.CharFollower [iAbbadon].charPortraitLayer2 = 0;

			QuestsController.createQuest (AbbadonQuest10, "Traditions", "Abbadon has been struggling lately by personal issues, you decide to talk with him and see if you can help.", 61, 1010);


			break; 

		case 5:
			panMainPanel.sortingOrder = 500;
			Board.text = "What do you want to do with Helena?";
			NPCCharList.CharFollower [iHelena].attWillpower = 0; 
			Board.text += "\n\nCurrent willpower: " + NPCCharList.CharFollower [iHelena].attWillpower.ToString ();
			QuestControl.helenaQuest = 6;

			break; 
		default:
			
			panMainPanel.sortingOrder = 500;
			Board.text = "What do you want to do with Helena?";
			Board.text += "\n\nCurrent willpower: "+ NPCCharList.CharFollower [iHelena].attWillpower.ToString() ;
			Board.text += "\n\nCurrent love: "+ NPCCharList.CharFollower [iHelena].charLove.ToString() ;
			Board.text += "\n\nHelena's height: "+ NPCCharList.CharFollower [iHelena].heightChar.ToString() + " cm." ;

			break; 


		}

	}




	// // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // 


	public void confirmFun(int selector){

		///////////////////////////// Increase wages / Dungeon

		if (selector == 0 && confirmationControl == 0) {
			WorldControl.day += 7;
			GameControl.attAlignment += 1;
			CityControl.city100Infrastructure += 1;
			if (GameControl.charGold < 50) {
				Board.text = "You tell him that Abbadon and Alba will take care of the issue themselves. And the man profusely thanks you while he goes back with his crew, yelling the good news.";
				NPCCharList.CharFollower [iAlba].charRelationship -= 1;
				NPCCharList.CharFollower [iAbbadon].charRelationship -= 1;
			} else {
				Board.text = "You hand him a bag of gold and the man profusely thanks you while he goes back with his crew, yelling the good news. ";
				GameControl.charGold -= 50; 
			}

		
			Board.text += "\n\nThe very next day you can see the workers eagerly doing their task, working with renewed strength as if it was again the first day. You wonder if they actually spent the money on food or drugs, or if they were just pretending, but nonetheless at least the results are showing.\n\nIn takes them a week to finish the whole project, as they originally promised. Although there are still some rooms and places that could be improved or fixed, the place is livable and comfortable, ready to be fully staffed again. \n";
			QuestControl.helenaQuest = 1; 
			endTurnFun ();
			Quest HelenaQuest1 = new Quest();
			QuestsController.createQuest(HelenaQuest1, "New hirings", "With your castle repaired, it's time to staff it again!", 13, 3001);
			QuestsController.RemoveID (3000);
			return;
		}

		if (selector == 1 && confirmationControl == 0) {
			Board.text = "You smile at him, and he answers in kind, confident that you will yield to his workers demands, but instead of giving him what he wants you raise your hand. In short notice a couple of guards come to you, and you order them to take him to the dungeon. <i>“What are you doing?! This is a mistake! You can’t do this!”</i> You don’t waste your breath to explain him what you can and cannot do on your city, and command your captain to get him ready for you. \n\nWhile they leave, you tell the worker to get back to work, and that they’ll soon witness what will happen to them if they don't finish on time. Although you still haven’t done anything to their foreman, they immediately go back to their task with renewed strength, everything to avoid your rage. \n\nOnce at the dungeon, you ask your guards to leave you alone with him. You can see they had give him a beating already and chained <i>“This is just a misunderstanding... I didn’t mean to offend you, my liege!”</i> you chuckle at his weak apology, and tell him that it is too late for that, otherwise his workers will be disappointed at you. <i>“You... You bastard!”</i>\n\nNow you step aside and wonder, which punishment would be more fitting? Corporal punishment? Or maybe breaking his ass and will would be a good lesson for his workers?\n";
			confirmationControl = 100;
			option0Name.text = "Sexual punishment";
			option1Name.text = "Corporal punishment";
			return;
		}

		///////////////////////////// Hire Professionals / Whores 

		if (selector == 0 && confirmationControl == 1) {
			Board.text = "You keep going until you arrive to a fancy, yet overgrown mansion. You knock the the door and a young man, barely an adult, opens the door. He is wearing an elegant butler uniform, but when you pay attention to it you can see that, as the house, its old and damaged. \n\nHe bows and invites you inside, guiding you through the deplorable halls until you arrive to a living room, where an old woman receives you, inviting you with a hand gesture to sit in front of her. Once comfortable, a servant brings you tea. <i>“Welcome "+ GameControl.playerName +", I heard the news about you, welcome to the city and to my humble house, I’m sorry if I don’t have much to offer, but these years have been tough for all of us, and the demand of properly educated servants is... Modest.”</i> You thank her for her hospitality, and tell her about your interest on acquiring new staff from her school. \n\n<i>“Yes but of course my liege, I have the best this city has to offer. Nonetheless, I fear that the handful of people at my disposal are all I have left, and therefore their price is quite considerable, but I am certain nothing that’s unaffordable for you. But please, give them a good look first, so you can see they are worth every gold piece.”</i>\n\nShe claps her hands and at least a dozen of servants come, and in seconds they set up a table in front of you, where they put dishes for you to taste. The food is top quality, rivaling that of the best chefs on the city, while you can see how they work in a disciplined matter, following every order the woman gives them without any hesitation. She asks them to perform a wide variety of skills, from cleaning the living room, to set up a table for over 20 guests in few minutes. Indeed they are impressive, and as she has said, probably worth every gold piece. \n\n<i>“Excellent work don’t you think? You’ll never have to worry about any menial task again. Now, I’ll can give you all my people, you gonna need them to take care of a castle as big as yours, but the cost is 1000 gold pieces. They’ll settle in a day, and will get everything ready in less than a week. Do we have a deal?”</i>\n\nYou could settle for her price without negotiation. Doing so would really improve your standing with the city and your subjects. You could too just try to negotiate and offer her the bare minimum, 200 G gold pieces. She won’t accept right away, but there are several implications that will indeed persuade her to agree to such low price. Nonetheless, rumors about abusing your power will arise. You could, as your last option, just use the force and send your guards to escort the new servitude to your castle, pretty much taking them as slaves or prisoners. ";
			if (GameControl.charGold < 1000) {
				Board.text += "\n\nAlthough you are lacking funds, you could get a loan from Abbadon, Alba, and other Houses in the city, at the cost of your relationship with them. ";
			} 


			confirmationControl = 2;
			option0Name.text = "Pay full";
			option1Name.text = "Negotiate";
			option2Name.text = "Take them by force";
			option2Butt.interactable = true; 
			return;
		}

		if (selector == 1 && confirmationControl == 1) {
			Board.text = "You tell Helena to stop right there. She looks around, still nervous <i>“Yes my liege? Is there something?”</i> You tell her that you are outraged of the living conditions of the people around you, wearing almost no clothes and skinny bodies. <i>“Oh no my liege, is not because they are poor, is because they...”</i> she pauses, her face red, but you ask her to continue. <i>“They are... You know, street girls.”</i> you chuckle and then explain her your new plan, you want to take these people off the street and take them into your castle \n\n<i>“I... I don’t think that’s a good idea my liege, they have no training, no manners, the only know how... Well, they are not proper ladies and lads! Unfit for servicing you!”</i> You tell her that you need to judge how well they serve by yourself. <i>“I... Uhm...”</i> at this point, she is realizing that you are just playing with her. Angry, she goes along with your plan, and helps you to look to fitting candidates, asking them their skills and knowledge. Although of course all are experienced in sex, you can see many of them have other skills too, from cooking, cleaning, and even a few of them know how to read or are experienced in haute couture fashion and manners. How they ended up in the streets is no mystery, considering the current affairs, but that doesn’t matter much now.\n\nAfter several hours of interviews, Helena has approved enough candidates to fill the staff. <i>“Fine, I’ll think this do, these girls and boys can be useful for the castle.”</i> you ask what’s her opinion of them. <i>“Not as bad as I expected... For now, we’ll see how they perform soon enough to pass judgment.”</i>\n\nHelena talks with them about their wage, and in total, she’ll need 100 in total to hire them, considering you’ll provide food and shelter already. \n\nYou could hire them in their terms, but you could also ask your guards to bring them to your castle and force them to work for you, pretty much as slaves, although this will reflect poorly in your reputation. ";
			if (GameControl.charGold < 100) {
				Board.text += "You lack enough gold to hire them, but you can extort some money from Abbadon and Alba to pay them instead. ";
			}
			confirmationControl = 101;
			option0Name.text = "Pay them";
			option1Name.text = "Kidnap them";
			option2Name.text = "";
			option2Butt.interactable = false; 
			return;
		}

		///////////////////////////// Pay full price / negotiate / use froce 

		if (selector == 0 && confirmationControl == 2) {
			WorldControl.day += 4;
			LawController.EnactLaw (new LawStaffProfessionals());
			GameControl.attAlignment += 1;
			CityControl.city100Corruption -= 3;
			NPCCharList.CharFollower [iHelena].charRelationship += 3;
			NPCCharList.CharFollower [iHelena].charLoyalty += 3;
			if (GameControl.charGold < 1000) {
				Board.text = "Although even with negotiations you are down on gold, you know Abbadon and Alba will help you out if you need, although they will be angry at you for abusing their wallet. <i>“Delightful, they’ll pack their belongings and will go to your castle in a couple of hours. Take care of them, they need years of training to be this good.”</i>\n\n";
				NPCCharList.CharFollower [iAlba].charLoyalty -= 2;
				NPCCharList.CharFollower [iAlba].charRelationship -= 2;
				NPCCharList.CharFollower [iAbbadon].charLoyalty -= 2;
				NPCCharList.CharFollower [iAbbadon].charRelationship -= 2;
			} else {
				Board.text = "";
				GameControl.charGold -= 1000;
			}

			Board.text += "You agree to pay the full price she is asking <i>“Delightful, they’ll pack their belongings and will go to your castle in a couple of hours. Take care of them, they need years of training to be this good.”</i>\n\nAs the woman said, only a couple of hours after you came back to your castle the new servants arrive. Helena shows them their new bedrooms and gives them a tour of the castle and assign them the tasks they will be doing from now on.\n\nIn just few days they have adapted to their new life, taking care of all their tasks properly. Helena, of course, is happy about this results. <i>“I must say my liege these people are a blessing, I haven’t faced any trouble with them, nor had to discipline anyone for improper behavior. Since they behave so well, I think we should start thinking about the next seasonal festival. The city used to celebrate it before the plague, but in recent years there  has been nothing. It would be a good idea to organize one, to show the changes that you are capable to make, and show off what you have managed to accomplish at least in your own house.”</i>\n\nConvinced about the benefits of the feast, and giving yourself a break after so much hard work and effort isn’t a bad idea either. You ask her to take care of the festival until you give her further orders. <i>“Yes my liege, that’ll be a pleasure!”</i> happy, she leaves the castle to contact merchants and the entertainment of the party. ";
			endTurnFun ();
			Quest HelenaQuest3 = new Quest();
			QuestsController.createQuest(HelenaQuest3, "Seasonal Festival", "The festivities are here, a great chance to show off to the city what you can do.", 13, 3003);
			QuestControl.helenaQuest = 3;
			QuestsController.RemoveID (3002);
			QuestsController.RemoveID (3001);
			return;
		}

		if (selector == 1 && confirmationControl == 2) {
			WorldControl.day += 4;
			LawController.EnactLaw (new LawStaffProfessionals());
			CityControl.city100Corruption -= 3;
			NPCCharList.CharFollower [iHelena].charRelationship += 3;
			NPCCharList.CharFollower [iHelena].charLoyalty += 3;
			if (GameControl.charGold < 200) {
				Board.text = "Although even with negotiations you are down on gold, you know Abbadon and Alba will help you out if you need, although they will be angry at you for abusing their wallet.";
				NPCCharList.CharFollower [iAlba].charLoyalty -= 1;
				NPCCharList.CharFollower [iAlba].charRelationship -= 1;
				NPCCharList.CharFollower [iAbbadon].charLoyalty -= 1;
				NPCCharList.CharFollower [iAbbadon].charRelationship -= 1;
			} else {
				GameControl.charGold -= 200;
				Board.text = "";
			}

			Board.text += "You negotiate with her, trying to reduce the price as much as you can. <i>“200 gold pieces? That’s too low! That won’t even cover much of what I had used on training them and sustaining them!”</i> Although you understand her predicament, your offer is what you are able to afford to pay for her services. <i>“Is too little, I refuse!”</i> she says angry, but you explain her that in order to earn the confidence of the people, and their support, you need their people. <i>“But t-”</i> you interrupt her, telling her that she can either accept the sum that you can offer right now, or you will use other methods to get what you want.\n\nShe doesn’t yields at first, but the threat you give her is very real, and ends up breaking her will. <i>“Very well, I accept these terms, but this may destroy my business.”</i> she grabs the bag with coins and orders her people to get ready to leave with you. Before going, you tell her that she has nothing to worry about, the city soon will become prosperous again, and when that happen her business will flourish again. <i>“I look forward to that.”</i> she says, disinterested of your opinion. \n \n\nIn a couple of hours after you came back to your castle the new servants arrive. Helena shows them their new bedrooms and gives them a tour of the castle and assign them the tasks they will be doing from now on.";
			Board.text += "\n\nIn just few days they have adapted to their new life, taking care of all their tasks properly. Helena, of course, is happy about this results. <i>“I must say my liege these people are a blessing, I haven’t faced any trouble with them, nor had to discipline anyone for improper behavior. Since they behave so well, I think we should start thinking about the next seasonal festival. The city used to celebrate it before the plague, but in recent years there  has been nothing. It would be a good idea to organize one, to show the changes that you are capable to make, and show off what you have managed to accomplish at least in your own house.”</i>\n\nConvinced about the benefits of the feast, and giving yourself a break after so much hard work and effort isn’t a bad idea either. You ask her to take care of the festival until you give her further orders. <i>“Yes my liege, that’ll be a pleasure!”</i> happy, she leaves the castle to contact merchants and the entertainment of the party. ";
			endTurnFun ();
			Quest HelenaQuest3 = new Quest();
			QuestsController.createQuest(HelenaQuest3, "Seasonal Festival", "The festivities are here, a great chance to show off to the city what you can do.", 13, 3003);
			QuestControl.helenaQuest = 3;
			QuestsController.RemoveID (3002);
			QuestsController.RemoveID (3001);
			return;
		}


		if (selector == 2 && confirmationControl == 2) {
			WorldControl.day += 4;
			LawController.EnactLaw (new LawStaffProfessionals());
			CityControl.city100Corruption -= 3;
			GameControl.attAlignment -= 3;
			NPCCharList.CharFollower [iHelena].charRelationship -= 3;
			NPCCharList.CharFollower [iHelena].charLoyalty -= 3;

			Board.text = "You tell her that in this dark times, trying to profit from the dire circumstances is wrong and unacceptable. She looks at you with a confused look <i>“What? What is your point?”</i> you, simply put, will take the servants with you, since they are necessary not just to keep your castle in shape, but to show to the rest of the country that there is going to be change, and things will improve. \n\n<i>“If you take them without paying, only your life will improve! How I’m supposed to keep my business working after you take everything?”</i> Although her concerns are real, you assure her she has nothing to worry about. Soon the city will fare better, and you’ll make sure she’ll be rewarded for her support to the crown. <i>“I...”</i> she tries to fight you, but when she sees guards at the window she desists, and orders her men and women to follow you. \n\nYou thank her for her support and leave to your castle. A couple of hours later, all of the servants arrive, and Helena shows them their new bedrooms, their new tasks, and gives them a tour through the castle. ";
			Board.text += "\n\nIn just few days they have adapted to their new life, taking care of all their tasks properly. Helena, of course, is happy about this results. <i>“I must say my liege these people are a blessing, I haven’t faced any trouble with them, nor had to discipline anyone for improper behavior. Since they behave so well, I think we should start thinking about the next seasonal festival. The city used to celebrate it before the plague, but in recent years there  has been nothing. It would be a good idea to organize one, to show the changes that you are capable to make, and show off what you have managed to accomplish at least in your own house.”</i>\n\nConvinced about the benefits of the feast, and giving yourself a break after so much hard work and effort isn’t a bad idea either. You ask her to take care of the festival until you give her further orders. <i>“Yes my liege, that’ll be a pleasure!”</i> happy, she leaves the castle to contact merchants and the entertainment of the party. ";

			endTurnFun ();
			Quest HelenaQuest3 = new Quest();
			QuestsController.createQuest(HelenaQuest3, "Seasonal Festival", "The festivities are here, a great chance to show off to the city what you can do.", 13, 3003);
			QuestControl.helenaQuest = 3;
			QuestsController.RemoveID (3002);
			QuestsController.RemoveID (3001);
			return;
		}

		///////////////////////////// Scold her // encourage her

		if (selector == 0 && confirmationControl == 3) {
			Board.text = "You ask Helena to follow you. Once in private, you tell her that she was out of line, if anyone is going to slap them is you, but she has no authority to do that, not without your permission. <i>“I apologize my liege, it was not my intention, it will not happen again.”</i> you can see that she is really regretful of what she just did, more about what the harm she did to the girl itself than you actual scolding, nonetheless this helps to keep her submissive nature in check. \n\nAfter dealing with her, you come back and you make sure they understand they will behave from now on, or they will have a visit to the dungeon. You make emphasis that whatever they like it or not, they’ll take orders from Helena, and do all the chores and tasks that she commands them. \n\nHelena bows and apologizes for her previous behavior, and assures them that it wont happen again, but that its important to take care of the castle, otherwise your image and reputation will be diminished, and that helps no one.\n\nAlthough they still are rebellious, you ask to one of your guards to stick with Helena to help her handle any improper treatment to their superior, and you give him permission to take them to the dungeon if the need arises. Helena is not comfortable with your choice, but you need to take precautions so they actually start to do their assigned tasks.\n\nA week later, you can see significant progress, and now your staff start to do their actual job. Happy about the results, Helena comes to you to ask you about a seasonal festival. <i>“I must say my liege these people are learning faster than I thought, I haven’t faced any trouble with them since you talked with them, nor had to discipline anyone for improper behavior. Since they behave so well, I think we should start thinking about the next seasonal festival. The city used to celebrate it before the plague, but in recent years there  has been nothing. It would be a good idea to organize one, to show the changes that you are capable to make, and show off what you have managed to accomplish at least in your own house.”</i>\n\nConvinced about the benefits of the feast, and giving yourself a break after so much hard work and effort isn’t a bad idea either. You ask her to take care of the festival until you give her further orders. <i>“Yes my liege, that’ll be a pleasure!”</i> happy, she leaves the castle to contact merchants and the entertainment of the party. ";
			NPCCharList.CharFollower [iHelena].attNature = 0; 
			NPCCharList.CharFollower [iHelena].attMorality = 95;
			NPCCharList.CharFollower [iHelena].attWillpower = 0;
			NPCCharList.CharFollower [iHelena].charRelationship -= 2;
			Quest HelenaQuest3 = new Quest();
			QuestsController.createQuest(HelenaQuest3, "Seasonal Festival", "The festivities are here, a great chance to show off to the city what you can do.", 13, 3003);
			QuestsController.RemoveID (3002);
			QuestsController.RemoveID (3001);
			QuestControl.helenaQuest = 3;
			WorldControl.day += 7;
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 3) {
			Board.text = "You tell her that she has no reason to apologize, and you inform to the rest of the staff that if they keep that behavior, Helena has the right to punish them as she sees fit. <i>“Are you sure of that, my liege?”</i> she asks, still insecure about your trust in her, but you nod.\n\nA week later Helena come backs to you, with a girl shackled. <i>“My liege, I need to report that she has tried to escape, and not just that, she been doing almost no work since she arrived. I need your assistance about how to deal with her.”</i> This is the first time that Helena needs to punish of the of the staff, and is in need of your guide.\n\nFirst, you ask what she thinks she should do. <i>“Well, I was thinking on making her take care of the latrines and other heavy duty tasks for a week, less food, and maybe make her sleep in a cell. That sounds harsh, but her attempt to escape is a big deal.”</i> Although in Helena’s mind thats a tough punishment, truth it could be worse, being put in <i>the box</i>, solitary confinement and of course, putting to good use the dungeon and the diverse tools that are in there. \n\nWhen you suggest this, you can see how the girl suddenly shakes with fear, what you take as evidence that these type of punishments work. <i>“But... That’s too much, don’t you think, my liege? I don’t want to harm her...”</i>\n\nIts going to be up to you what punishment she takes, but Helena will oversight it, exposing her. This may make her more cold and tough on the staff, and there is no doubt some of her sweet and almost naive attitude will go away with such experience, nonetheless this will help to have your people in line, what punishment she should administer? ";
			WorldControl.day += 7;
			confirmationControl = 4;
			option0Name.text = "Cruel punishment";
			option1Name.text = "Her choice";
			option2Name.text = "";
			return;
		}


		///////////////////////////// cruel punishment / her choice

		if (selector == 0 && confirmationControl == 4) {
			Board.text = "You tell Helena that she’ll have to oversee the proper punishment, and that she’ll have to follow the directions that you gave earlier.  <i>“But my liege...”</i> she tries to argue against your decision, but you tell her that this is not negotiable, and that you expect her to do as you expect, or you’ll give her a personal teaching about it. \n\nShe gulps and nods <i>“Yes my liege, I’ll take care of it.”</i> she tries to leave, but the girl behind her is shaking and immobile. <i>“Come on, let’s go!”</i> Helena says while struggling, but the other girl refuses. <i>“Would you mind to help me, "+ GameControl.playerName +"?”</i> she says, while trying to push her, but you refuse, since this is <i>her</i> task, but you tell Helena that she’ll take her place if they don't get going immediately. \n\nThe fear and adrenaline awake something in her, punching the prisoner in the stomach. <i>“Come on! Move now!”</i> while she grasps for air its easier for Helena to push her around out of the room and into the dungeon.\n\nDuring the next week you can see Helena diligently punishing her. At first, she had troubles even commanding the guards to do what it had to be done, but after several days she starts to do the new routine without any difficulty. At the end, she returns the almost broken girl to her bedroom, and reports to you. \n\n<i>“I took care of the issue my liege, she will now behave appropriately, I doubt she’ll give more troubles.”</i> you ask how she feels after doing this. <i>“It’s hard my liege, I don't enjoy it, but you give me no choice, so I’ll do what needs to be done.”</i>\n\nAfter having a long conversation with her, she is still for the most part the sweet girl that you originally met, but her survival instincts are helping her to do her tasks and to cope with her internal conflict. She is still far from having an iron fist or having a cruel mind and character, but she has proven that she’ll do anything to get out of herself living through horrible consequences. ";
			Board.text += "\n\nFinally, you can see significant progress, and now your staff start to do their actual job. Happy about the results, Helena comes to you to ask you about a seasonal festival. <i>“I must say my liege these people are learning faster than I thought, I haven’t faced any trouble with them since you talked with them, nor had to discipline anyone for improper behavior. Since they behave so well, I think we should start thinking about the next seasonal festival. The city used to celebrate it before the plague, but in recent years there  has been nothing. It would be a good idea to organize one, to show the changes that you are capable to make, and show off what you have managed to accomplish at least in your own house.”</i>\n\nConvinced about the benefits of the feast, and giving yourself a break after so much hard work and effort isn’t a bad idea either. You ask her to take care of the festival until you give her further orders. <i>“Yes my liege, that’ll be a pleasure!”</i> happy, she leaves the castle to contact merchants and the entertainment of the party. ";
			NPCCharList.CharFollower [iHelena].attNature = 25; 
			NPCCharList.CharFollower [iHelena].attMorality = 85;
			NPCCharList.CharFollower [iHelena].attWillpower = 0;
			NPCCharList.CharFollower [iHelena].charRelationship -= 2;
			Quest HelenaQuest3 = new Quest();
			QuestsController.createQuest(HelenaQuest3, "Seasonal Festival", "The festivities are here, a great chance to show off to the city what you can do.", 13, 3003);
			QuestsController.RemoveID (3002);
			QuestsController.RemoveID (3001);
			QuestControl.helenaQuest = 3;
			WorldControl.day += 7;
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 4) {
			Board.text = "You tell Helena that she’ll have to oversee the proper punishment, just as she sees fit. <i>“Thank you for trusting me my liege, I’ll take care of her and you’ll see she will behave appropriately very soon.”</i> You tell her to go on then, and she nods.\n\nWhile trying to leave she struggles with the prisoner, but she persuades her <i>“Come on, we’ll do it my way or our liege way, is up to you.”</i> with that threat, the girls gets going. \n\nDuring the next week you can see Helena diligently taking care of the girl, teaching her, giving her task and making sure she learns her place without the use of excessive violence. At first she had troubles to assert her authority, but after several days she starts to do the new routine without any difficulty, her personality stronger than before. At the end, the girl has improved her behavior, and Helena reports to you. \n\n<i>“I took care of the issue my liege, she will now behave appropriately. I’m glad that you gave me this opportunity, I think I also learned from it a lot.”</i> you ask how she feels after doing this. <i>“It was hard at first my liege, but I start to enjoy this. Having a positive impact in this place gives me confidence.”</i>\n\nAfter having a long conversation with her, she is still the sweet girl that you originally met, and although she is still far from having an iron fist, now she’ll be able to lead the servitude without your constant presence.";
			Board.text += "\n\nFinally, you can see significant progress, and now your staff start to do their actual job. Happy about the results, Helena comes to you to ask you about a seasonal festival. <i>“I must say my liege these people are learning faster than I thought, I haven’t faced any trouble with them since you talked with them, nor had to discipline anyone for improper behavior. Since they behave so well, I think we should start thinking about the next seasonal festival. The city used to celebrate it before the plague, but in recent years there  has been nothing. It would be a good idea to organize one, to show the changes that you are capable to make, and show off what you have managed to accomplish at least in your own house.”</i>\n\nConvinced about the benefits of the feast, and giving yourself a break after so much hard work and effort isn’t a bad idea either. You ask her to take care of the festival until you give her further orders. <i>“Yes my liege, that’ll be a pleasure!”</i> happy, she leaves the castle to contact merchants and the entertainment of the party. ";

			NPCCharList.CharFollower [iHelena].attNature = 25; 
			NPCCharList.CharFollower [iHelena].attMorality = 80;
			NPCCharList.CharFollower [iHelena].charRelationship += 4;
			NPCCharList.CharFollower [iHelena].attWillpower = 0;
			Quest HelenaQuest3 = new Quest();
			QuestsController.createQuest(HelenaQuest3, "Seasonal Festival", "The festivities are here, a great chance to show off to the city what you can do.", 13, 3003);
			QuestsController.RemoveID (3002);
			QuestsController.RemoveID (3001);
			QuestControl.helenaQuest = 3;
			WorldControl.day += 7;
			endTurnFun ();
			return;
		}

		///////////////////////////// Hire artists / Debauchery

		if (selector == 0 && confirmationControl == 5) {
			Board.text = "You smile at her and agree, dismissing your corrupt thoughts, the artists would be a great sane and healthy show for the city. <i>“That’s a great choice my liege! I’ll give them the good news!”</i> she runs off to inform the artists and get everything for the night.\n\nFew days later, the Festival is finally here, and you can see many familiar faces, including Abbadon and Alba, among other important people of the city. ";
			loadFollowers ();
			if (NPCCharList.CharFollower [iAbbadon].charRelationship < 10) {
				Board.text += "\n\nAbbadon comes to you and greets you formally <i>“The festival looks good "+ GameControl.playerName +", good job.”</i> is the only thing that Abbadon says, before going back to his seat. Clearly, you have done a poor job improving your relationship with him.";
			} else {
				Board.text += "\n\nAbbadon comes to you and greets you <i>“"+ GameControl.playerName +", you have done an amazing job so far, and this festival looks like its going to be amazing, good job!”</i> ";

				if (NPCCharList.CharFollower [iAbbadon].charLove > 0) {
					Board.text += "\n\nHe gets closer to you, his flat chest against yours, and his face so close you can feel his excited breath <i>“I may give you a reward later for your hard work.”</i> and with that, he moves back to his seat. ";

				}else {
					Board.text += "\n\n<i>“I hope you keep doing a good job like this, I’ll look forward to do more business with you.”</i> with that, he turns around and goes back to his seat.";

				}
			}

			if (NPCCharList.CharFollower [iAlba].charRelationship < 10) {
				Board.text += "\n\nMoments later Alba approaches you. <i>“Nice party, worthy for kids. But where is all the fun? After years of boredom in this city and you make a festival with clowns or whatever the fuck they are? Well, at least you tried "+ GameControl.playerName +".”</i> She leaves to her own table. Your cold relationship with her making her kinda hostile. ";

			} else {
				if (NPCCharList.CharFollower [iAlba].charLove > 0) {
					Board.text += "\n\nMoments later Alba approaches you. <i>“Well, this is not the type of party I was looking for, but at least you are trying.”</i> she doesn’t sounds angry, but is not too happy with the party.";

					if (NPCCharList.CharFollower [iAbbadon].charLove > 0) {
						Board.text += "\n\n<i>“Hey, I know, why you don't sit with me? I can make this party entertaining for the both of us, if you know what I mean.”</i> she leans towards you and shamelessly gives you a deep, wet kiss in front of everyone, not a surprise coming from her. \n\nYou can see how Abbadon is boiling with rage, but manages to keep his cool at the end, although his enmity with Alba keeps growing. \n\n<i>“Think about it, alright?”</i> Alba says before going back to her table. ";

					}else {
						Board.text += "\n\n<i>“Hey, I know, why you don't sit with me? I can make this party entertaining for the both of us, if you know what I mean.”</i> she leans towards you and shamelessly gives you a deep, wet kiss in front of everyone, not a surprise coming from her. \n\n<i>“Think about it, alright?”</i> Alba says before going back to her table.";

					}
				}else {
					Board.text += "\n\n<i>“Well, I’ll try to have as much fun as I can, see you later "+ GameControl.playerName +", and don’t forget, my house is always open to you.”</i>";

				}
			}

			Board.text += "\n\nThe music starts shortly after, and your staff brings plates of food and drinks for everyone. The main square is full of people, the whole city partying together, for once in years forgetting about the horribleness of the past. \n\nYou indulge yourself with food and wine, and everyone around you does the same.\n\nHours later, when its already evening, the appetite of most of the people is satisfied and everyone is dancing and socializing. You can see how Abbadon and Alba are in their own tables, having fun with their own friends, while Helena is at your side, making sure everything stays in order.\n\nYou decide it could be a good time to try to get more intimate with one of your subjects...";

			confirmationControl = 6;
			option0Name.text = "Helena";
			option1Name.text = "Abbadon";
			option2Name.text = "Alba";
			option3Name.text = "None";
			option2Butt.interactable = true;
			option3Butt.interactable = true;
			return;
		}

		if (selector == 1 && confirmationControl == 5) {
			loadFollowers ();
			if (LawController.IsEnacted<LawStaffWhores> ()) {
				Board.text = "You tell her that she should only hire the musicians, but that your staff can take care of entertaining the guests. For that matter, you tell her to make sure there is plenty of supply of hard alcohol, drugs and aphrodisiacs. <i>“My Liege that’s... Very well, as you wish.”</i> angry and disappointed, she knows she wont change your mind, and reluctantly leaves to take care of the preparations. ";

			} else {
				Board.text = "You tell her that she should only hire the musicians, and that she needs to go to the red district and hire as many girls and boys as she can to provide for the entertainment of the guests. For that matter, you tell her to make sure there is plenty of supply of hard alcohol, drugs and aphrodisiacs too. <i>“My Liege that’s... Very well, as you wish.”</i> angry and disappointed, she knows she wont change your mind, and reluctantly leaves to take care of the preparations. ";

			}

			Board.text += "\n\nFew days later, the Festival is finally here, and you can see many familiar faces, including Abbadon and Alba, among other important people of the city. ";
			if (NPCCharList.CharFollower [iAbbadon].charRelationship < 10) {
				Board.text += "\n\nAbbadon comes to you and greets you formally, but you can see he is angry <i>“You really had to ruin our wonderful festival with something like this "+ GameControl.playerName +"? Scandalous, I think this year I’ll pass.”</i> Abbadon turns around and leaves, his esteem for you diminished. ";
			} else {
				Board.text += "Abbadon comes to you and greets you formally, but you can see he is disappointed <i>“The festival is not supposed to be a party like this, "+ GameControl.playerName +". I’m really sad of how things turned out, hope you get some common sense back and make the right think in the future. For now, I think this year I’ll pass.”</i> Abbadon turns around and leaves, his esteem for you diminished. ";
			}

			if (NPCCharList.CharFollower [iAlba].charRelationship < 10) {
				Board.text += "\n\nMoments later Alba approaches you. <i>“Nice party "+ GameControl.playerName +"! I thought you were boring and lame, but this definitely shows otherwise. Looking forward to have some fun around.”</i> She leaves to her own table, her relationship with you improved.  ";
			} else {
				Board.text += "\n\nMoments later Alba approaches you. <i>“Nice party "+ GameControl.playerName +"! Not like I am surprised, you really have a good eye for these type of things. Looking forward to have some fun around!”</i> She leaves to her own table, her relationship with you improved.  ";		
			}
			Board.text += "\n\nThe music starts shortly after, and your staff brings plates of food and drinks for everyone. They did follow your indications of adding aphrodisiacs and drugs to the food, so no one present will try to skip any of the fun. The main square is full of people, the whole city partying together, for once in years forgetting about the horribleness of the past. \n\nYou indulge yourself with food and wine, and everyone around you does the same. You can see how the guest start to inappropriately touch to your skimpy clothed servants, who if anything are enjoying themselves too. \n\nHours later, when its already evening, the appetite of most of the people is satisfied and there are several small orgies around, but nothing organized. You can see Alba is not fooling around, and is   being surrounded by five well hung men, using both of her holes, mouth and hands at the same time, her body already covered in sperm of previous partners. ";		

			if (GameControl.dick1Size > 0) {
				Board.text += "\n\nYou are also having fun yourself, taking one of the more handsome men for yourself, his generous dick up your ass while a young courtier rides your dick at the same time, the two of you making wet slurping noises with your deep kiss. \n\nHelena is at your side, trying to look away, quiet and nervous. She hasn't eaten or drank anything yet, knowing everything is tainted, and she really feels uncomfortable with your threesome  but knows it is her duty to stay. \n\nThe three of you keep fucking until you feel your ass being filled with the seed of the young man, and everyone changes position: He is now riding your dick, its firm butt against your body, while the girl is now on her knees, switching between sucking his dicks and yours.\n\nAfter ten minutes you finally have your first climax, but the night is still young and you have an idea: If Helena doesn’t wants to be fucked, she will not be fucked, but she can still be used as a cum receptacle for the city, and give her some drugs so she can have some fun too. \n\nShould you go with this idea? Or spare her the night?";
			} else {
				Board.text += "\n\nYou are also having fun yourself, taking one of the more handsome men for yourself, his generous dick up your ass while a young courtier eats you out at the same time, the two of them making obnoxious noises. \n\nHelena is at your side, trying to look away, quiet and nervous. She hasn't eaten or drank anything yet, knowing everything is tainted, and she really feels uncomfortable with your threesome  but knows it is her duty to stay. \n\nThe three of you keep fucking until you feel your ass being filled with the seed of the young man, and everyone changes position: You are now riding his dick, while the girl is now on her knees, switching between sucking his balls and your cum filled ass.\n\nAfter ten minutes you finally have your first climax, but the night is still young and you have an idea: If Helena doesn’t wants to be fucked, she will not be fucked, but she can still be used as a cum receptacle for the city, and give her some drugs so she can have some fun too. \n\nShould you go with this idea? Or spare her the night?";
			}

			confirmationControl = 102;
			option0Name.text = "Forced bukkake";
			option1Name.text = "Spare her";
			option2Name.text = "";
			option3Name.text = "";
			option2Butt.interactable = false;
			option3Butt.interactable = false;
			return;
		}

		///////////////////////////// Helena / Abbadon / Alba / None 

		if (selector == 0 && confirmationControl == 6) {
			Board.text = "You stand up and grab Helena’s hand <i>“My liege?”</i> she asks confused, and you tell her that you need to talk with her in private. You guide her through the crowd until you finally enter one of the many empty buildings in the city. <i>“My liege is everything alright? What’s going on?”</i> she asks, fearing there is something wrong, but you calm her down, telling her that you just wanted some time alone with her.";
			if (NPCCharList.CharFollower [iHelena].charRelationship <= 0) {
				Board.text += "\n\n<i>“That... I appreciate it my liege, but is just that I’m not ready... There is so much work to do...”</i> she looks reluctant since your relationship with her hasn’t been the best. \n\nInstead of flirting, you end up talking with her about what had happened in the past, all the troubles and the mistakes the both of you have done, getting to know each others motive better. \n\n<i>“I know your work is hard, and you need to make tough choices... But I’m happy we had this chance to talk and know each other a little bit more, maybe we can amend the past.”</i>\n\nShe gives you a smile and walks towards the exit. <i>“Let’s go back to the festival, it needs our attention.”</i>\n\nAt the end of the night, your relationship with her has improved. ";
				NPCCharList.CharFollower [iHelena].charRelationship += 10;

			} else {
				Board.text += "\n\n<i>“I...”</i> she whispers, her face red and too ashamed to say more. You lean towards her, your face inches away from hers. <i>“My...”</i> she mutters and closes her eyes. You lean forward, your lips gently touching hers, her heart beating hard, her face flushing, your mouths meeting for the first time. You push forwards again, and this time she welcomes you inside her mouth, but still immobile, letting you in charge.\n\nYour tongues touch each other, you move slowly to not overwhelm the inexperienced girl. You embrace her, one of your hands moving down until they finally feel the softness of her derriere. \n\nIt takes a couple of minutes until she embraces you back, softly grabbing your arms. After several minutes, the two of you take a pause, but even if Helena liked what just happened, she still feels uncomfortable. <i>“My liege... I think we need to get back, or someone may see us.”</i> although you want to stay and go for more, you understand that she is not ready yet for the next step, and agree to come back. \n\nShe smiles and thanks you, happy for what just happened, and for the rest of the night her mood is undoubtedly more cheerful than usual.";
				NPCCharList.CharFollower [iHelena].charRelationship += 10;
				NPCCharList.CharFollower [iHelena].charLove += 5;


			}
			Board.text += "\n\nThe feasts doesn’t ends until the next morning. Helena and the rest of important people left to rest hours ago, while you decided to stay a little longer since this was the first time you were in a festival. \n\nExhausted and drunk, you go back, but once in your room you stumble around. When you almost fall to the ground you hit the wall, and without realizing you hit a secret mechanism that activates a sliding door. Although the sounds is loud, everyone in the castle is asleep or had passed out, and no one comes to inspect what is going on. \n\nYou can see there are stairs behind the secret door, but you can’t see whats down there. You sober up enough to lock your door, so you can investigate after the hangover. \n\n";

			endTurnFun ();

			/*hire artist changed*/
			CityControl.city100Corruption -= 5;
			NPCCharList.CharFollower [iHelena].charCorruption -= 5;
			NPCCharList.CharFollower [iAbbadon].charCorruption -= 5;
			NPCCharList.CharFollower [iAbbadon].charRelationship += 5;
			NPCCharList.CharFollower [iAlba].charCorruption -= 5;
			NPCCharList.CharFollower [iAlba].charRelationship -= 3;
			CityControl.city100Happiness += 3;
			CityControl.city100Education += 1.5f;
			Quest HelenaQuest4 = new Quest();
			QuestsController.createQuest(HelenaQuest4, "Dark secrets", "You found a secret passage on your bedroom, what you'll find inside?.", 13, 3004);
			QuestControl.helenaQuest = 4;
			QuestsController.RemoveID (3003);
			return;
		}

		if (selector == 1 && confirmationControl == 6) {
			Board.text = "You stand up and walk towards Abbadon’s table. Even from far away you can see that he is drunk, and by how he behaves, he is clearly the dominant, aggressive.\n\n When he sees you coming, he commands to the people surrounding him to make space, moving the crowd around Abbadon so the two of you can have some privacy, although that place is hardly private.";

			if (NPCCharList.CharFollower [iAbbadon].charRelationship <= 0) {
				Board.text += "\n\n<i>“...Hey "+ GameControl.playerName +"... Good party uh? But this doesn’t change the fact that you are a piece of shit...”</i> he is mad at you for all the troubles you have caused for him so far.\n\n<i>“But this is a festival, time for all of us to get along, drink with me.”</i> he serves you a cup of wine, and cheers with you. <i>“For prosper times!”</i> he says, before the two of you gulp down the entire drink.\n\nAfter that, you stay with him for the rest of the night, telling stories, having drunk philosophical debates, and overall having a good time. \n\n<i>“It was nice to share the night with you "+ GameControl.playerName +"... But I need to leave now.”</i> he says, struggling to stand straight. <i>“I hope we can get to know each others even more soon, you are entertaining when you are drunk.”</i> he says, before leaving, escorted by his people. \n\nAlthough you couldn’t advance much your relationship with him, at least you are a step closer to be his friend.";
				NPCCharList.CharFollower [iAbbadon].charRelationship += 10;

			} else {
				Board.text += "\n\n<i>“...Hey "+ GameControl.playerName +"... Fantastic party, I’m glad you are here. Come, join me!”</i> he taps the seat at his side and welcomes you.\n\n<i>“Time to get along more, drink with me.”</i> he serves you a cup of wine, and cheers with you. <i>“For prosper times!”</i> he says, before the two of you gulp down the entire drink.\n\nThe next hour everything goes fine, but when he is totally wasted he becomes clingy, grabbing you by the arm and resting on your chest. <i>“Hey "+ GameControl.playerName +"... Wouldn’t you like to have... some fun?”</i> just after he finish these words, you can feel his hand moving from your chest to your crotch. <i>“I’ve been looking forward to repay what you have done for the city, you know...”</i> ";
				if (GameControl.dick1Size > 0) {
					Board.text += "\n\nHe doesn’t waits for your answer before he leans forward, assaulting your mouth with his tongue, while after a minute of struggle manages to take your half erect dick out. <i>“Mhh... I really missed a tool like this "+ GameControl.playerName +".”</i> he says before he goes back into kissing you, making a lot of slurping sounds. \n\nYou see that the guards around you for the most part block the sight of you two, and all of them are turned around, as if this routine isn't new for them. \n\nYour attention goes back to Abbadon when you feel a nice warm sensation around your cock, Abbadon slowly trying to engulf your whole mast. He starts to sloppily blow you, doing a poor job because of his current state, nonetheless what he lacks of skill makes up for effort, moving his head up and down with haste and gluttony. \n\nIt doesn’t take long until your body starts to shake, your cum ready to shoot. <i>“Mggmm aahhmmm”</i> he says something unintelligible but he increases his pace, ready to receive your warm seed. You push his head down until his nose touches your belly and the first load goes straight into his stomach. \n\nHe stays like that for a while, where the last loads end up in his mouth and not in his throat. He whorishly sits up again and shows you the mouthful you just gave him before swallowing it. <i>“Such a thick load "+ GameControl.playerName +"... No one is taking care of you?”</i> he kisses you again, his breath now stinking and alcohol and sperm. <i>“We are not over yet, now you need to take care of me...”</i> He stands up and easily removes his skirt. You can see he has a type of chastity belt that protects his pussy, but is open on the back.\n\n<i>“Sorry "+ GameControl.playerName +", but I only like the backdoor.”</i> he serves you a cup with a golden drink. <i>“Take this, it has aphrodisiac properties.”</i> You gulp it down, delighted by its sweet taste, a mix of honey and exotic fruits. \n\nAs he said, in no time your body is ready for action again, your dick even harder than before. <i>“Just what I needed.”</i> He pushes you back, turns around and bends over. <i>“Come on, get me ready.”</i> he says as he puts his ass in front of your face. You gladly eat him out, using your fingers too until his body is prepared.\n\n<i>“Let’s go.”</i> he turns around sit on top of you, facing you, using his hand to guide your mast to his back entry. You feel him shivering when your head enters him, and the pleasure of his warm, private place while it covers your whole length. \n\nHe starts to move up and down, riding you in a slow pace, but his ass rapidly adapts to the shape of your cock. <i>“Uhmm... Is almost as if your dick was made for my ass, "+ GameControl.playerName +".”</i> he mutters before embracing you in a kiss. \n\nYou take his hips, helping him in his task. In just few moments, the two of you are synced, and his movements become wilder and more aggressive, bitting your lips, with his nails scratching your back <i>“Ah!... "+ GameControl.playerName +"! Do you feel it?! This... Ah!... Connection!... That we have!”</i> he says between moanings, the two of you closer to your climax with every bump. \n\nWhen you feel his body squeezing you he hugs you, yelling for more. Your hips start to move on their own, moving as fast as they can and after few seconds, you finally feel how your seed escapes your body. \n\nAbbadon can’t control himself and yells loudly, something that without doubt the other people at the festival have heard, and it takes a minute until his body relaxes again, almost lifeless on top of you. <i>“Ah... Ah... You’re great "+ GameControl.playerName +"...”</i> he gives you a slow kiss and hugs you, before he fall asleep on top of you.\n\nYou let him rest for half an hour until you wake him out again. <i>“I apologize "+ GameControl.playerName +"... I hope I’m not too heavy for you.”</i> you just kiss him again, and you see him smile, one of the few times you’ve seen him happy. <i>“Well, I think is time for me to leave... I’ve already make an scandal here. But I’ll see you soon, alright?”</i> he pecks your cheek and dresses up, before leaving. ";

				} else {
					Board.text += "\n\nHe doesn’t waits for your answer before he leans forward, assaulting your mouth with his tongue, while after a minute of struggle manages to remove your legwear. <i>“Mhh... Let’s take care of this.”</i> he says before he goes back into kissing you, making a lot of slurping sounds. \n\nYou see that the guards around you for the most part block the sight of you two, and all of them are turned around, as if this routine isn't new for them. \n\nYour attention goes back to Abbadon when you feel a nice warm sensation on your clit, Abbadon slowly sucking your pearl, before giving it a long lick. He starts to sloppily eat you out, doing a poor job because of his current state, nonetheless what he lacks of skill makes up for effort, moving his head up and down with haste and gluttony. \n\nIt doesn’t take long until your body starts to shake, your body ready for the first climax of the night. <i>“Mggmm aahhmmm”</i> he says something unintelligible but he increases his pace, ready to receive your fluids. You push his head down until he can’t breath, your body shivering of pleasure while he swallows your fluids with delight. \n\nHe stays down there for a minute, cleaning you up. He sits up again, his lustful face displaying a smirk, and kisses you, sharing the taste of alcohol and your own pussy with you. <i>“Such a good taste "+ GameControl.playerName +"... I should take care of you more often "+ GameControl.playerName +".”</i> he kisses you again, more eager than before. <i>“We are not over yet, now you need to take care of me...”</i> He stands up and easily removes his skirt. You can see he has a type of chastity belt that protects his pussy, but is open on the back.\n\n<i>“Sorry "+ GameControl.playerName +", but I only like the backdoor.”</i> he serves you a cup with a golden drink. <i>“Take this, it has aphrodisiac properties, and will energize you again too.”</i> You gulp it down, delighted by its sweet taste, a mix of honey and exotic fruits. \n\nAs he said, in no time your body is ready for action again, your pussy overflowing with desire. Abbadon hands you a strap with an enormous dildo <i>“This is what I need, hope you don’t mind to put your hips to good use.”</i> He pushes you back, turns around and bends over. <i>“Come on, get me ready.”</i> he says as he puts his ass in front of your face. You gladly eat him out, using your fingers too until his body is prepared.\n\n<i>“Let’s go.”</i> he turns around and sit on top of you, facing you, using his hand to guide the toy you are wearing to his back entry. You feel him shivering when the head enters him, and you can see the pleasure in his eyes, while he engulfs its whole length.\n\nHe starts to move up and down, riding you in a slow pace, but his ass rapidly adapts to the shape of the cock. <i>“Uhmm... This is my favorite toy... It’s a shame I don’t have many chances to use it with someone else.”</i> he mutters before embracing you in a kiss. \n\nYou take his hips, helping him in his task. In just few moments, the two of you are synced, and his movements become wilder and more aggressive, bitting your lips, with his nails scratching your back <i>“Ah!... "+ GameControl.playerName +"! Do you feel it?! This... Ah!... Connection!... That we have!”</i> he says between moanings, the two of you closer to your climax with every bump. \n\nWhen you feel his body squeezing you he hugs you, yelling for more. Your hips start to move on their own, moving as fast as they can and after few seconds, the two of you embrace in a lengthy kiss while your bodies climax. \n\nAbbadon at the end can’t control himself and yells loudly, something that without doubt the other people at the festival have heard, and it takes a minute until his body relaxes again, almost lifeless on top of you. <i>“Ah... Ah... You’re great "+ GameControl.playerName +"...”</i> he gives you a slow kiss and hugs you, before he fall asleep on top of you.\n\nYou let him rest for half an hour until you wake him out again. <i>“I apologize "+ GameControl.playerName +"... I hope I’m not too heavy for you.”</i> you just kiss him again, and you see him smile, one of the few times you’ve seen him happy. <i>“Well, I think is time for me to leave... I’ve already make an scandal here. But I’ll see you soon, alright?”</i> he pecks your cheek and dresses up, before leaving.";
				}
				Board.text += "\n\nThe feasts doesn’t ends until the next morning. Helena and the rest of important people left to rest hours ago, while you decided to stay a little longer since this was the first time you were in a festival. \n\nExhausted and drunk, you go back, but once in your room you stumble around. When you almost fall to the ground you hit the wall, and without realizing you hit a secret mechanism that activates a sliding door. Although the sounds is loud, everyone in the castle is asleep or had passed out, and no one comes to inspect what is going on. \n\nYou can see there are stairs behind the secret door, but you can’t see whats down there. You sober up enough to lock your door, so you can investigate after the hangover. \n\n";


				NPCCharList.CharFollower [iAbbadon].charRelationship += 10;
				NPCCharList.CharFollower [iAbbadon].charLove += 5;

			}

			endTurnFun ();

			/*hire artist changed*/
			CityControl.city100Corruption -= 5;
			NPCCharList.CharFollower [iHelena].charCorruption -= 5;
			NPCCharList.CharFollower [iAbbadon].charCorruption -= 5;
			NPCCharList.CharFollower [iAbbadon].charRelationship += 5;
			NPCCharList.CharFollower [iAlba].charCorruption -= 5;
			NPCCharList.CharFollower [iAlba].charRelationship -= 3;
			CityControl.city100Happiness += 3;
			CityControl.city100Education += 1.5f;
			Quest HelenaQuest4 = new Quest();
			QuestsController.createQuest(HelenaQuest4, "Dark secrets", "You found a secret passage on your bedroom, what you'll find inside?.", 13, 3004);
			QuestControl.helenaQuest = 4;
			QuestsController.RemoveID (3003);
			return;
		}

		if (selector == 2 && confirmationControl == 6) {
			Board.text = "You stand up and walk towards Alba’s table. Her entire group is drunk or high, and everyone is singing or doing something lewd. Alba is cheering at a small group of his men and women that are engaged in a small orgy, but stops to welcome you when you arrive, to high to care for whatever past the two of you have. \n\n<i>“"+ GameControl.playerName +"! Join us! We have anything you want! Wine, dust, and a lot of wild choices to pick, just sit down!”</i> she jumps of her seat and once at your side she forces you to sit down. <i>“Come on, have some of this!”</i> before you can react, she forces you something down your throat.\n\nIt doesn’t take long until you start to feel its effects, a sensation of euphoria and lust invades your body, a wide smile through your face while every problem goes away, leaving you only worried about having fun that night. \n\n<i>“Amazing right? And there are so many things left to do.”</i> She sensually sits on your lap, drinks something that’s floursent pink and this time forces it through your mouth with a wet, sloppy kiss. The aphrodisiac works immediately, losing control of yourself and starting to tear apart the skimpy attire of Alba while she answers in kind, both of you exposing your naked bodies for the whole city to awe.";

			if (GameControl.dick1Size > 0) {
				Board.text += "\n\nShe leans forward, offering you her breast for you to suck it, an offer you don't refuse, while your hands explore her ample ass and her wet pussy. You can feel her furry hands touching your throbbing rod, smearing her fur with your pre. \n\nAfter several minutes Alba cuts out the foreplay, her body in need of the real thing. <i>“No more messing around, it’s time for the main dish!”</i> she says while pushing her body against yours, her cunt just inches away from your hard mast. \n\nYou use your hand to guide your member, it’s overflowing entrance urging you to enter <i>“I can’t wait anymore!”</i> she yells before letting her body go, engulfing the entirety of your cock with in a single move, a loud slapping sound when your bodies slam each other. \n\nThe crowd cheers eagerly at the consummation of the act, and you can hear how they also start to engage in lewd acts themselves, encouraged by you two. \n\nYou can see Alba’s passion on her eyes while she starts to ride you, her mouth open, grasping for air for all the effort and excitement. Her pace is wild, pretty much jumping and diving on you each time, making obnoxious wet noise.\n\nThe closer she is to her climax, the pain of her claws of your back is increased. At some point you fear that she may tear your back apart, but Alba keeps giving you drugs and drinks until you lose your senses, focusing only on releasing your seed deep inside her. \n\n<i>“I’m almost there "+ GameControl.playerName +"! Fill me up! Give me your cum!”</i> she begs at you while her body shivers and her nether parts clench around your dick. You grab her by her hips and pull until you are balls deep, and you can feel her climax when your first load hits her insides. \n\nShe holds on to you while you keep releasing your seed, making sure she gets as much as she can inside her. Once its over, she falls to the table, her pussy dripping with your cum, her gaze lost. \n\nBefore you can stand up you feel someone using an ointment on your back, a servant of Alba that’s used to take care of those that have sex with her. By the dripping blood, its obvious she did a mess, but the woman takes care of you immediately, numbing your pain. \n\nWith Alba passing out by the drugs and pleasure, you decide to go back to your table and enjoy the rest of the night.";
			} else {
				Board.text += "\n\nShe leans forward, offering you her breast for you to suck it, an offer you don't refuse, while your hands explore her ample ass and her wet pussy. You can feel her furry hands touching your nether parts, smearing her fur with your fluids. \n\nAfter several minutes Alba cuts out the foreplay, her body in need of the real thing. <i>“No more messing around, it’s time for the main dish!”</i> she takes you and pushes you to the table, forcing you to lie on top of it. She rapidly sit on your face, giving you a direct view of her back door while she smears her fluids on your mouth and nose, its inebriating fragrance invading your nostrils. \n\n<i>“What are you waiting?! Eat me out!”</i> she commands you while rubbing her pussy on you. You give up to her demands and you open your mouth to have a good taste of her, and using your tongue to lick her more sensitive parts. <i>“Nghh... That’s the spot! Keep going!”</i>\n\nShe says while eagerly moving her hips more. \n\nIt doesn’t take long until she too answers in kind <i>“It’s not fair that I am the only one having fun... It’s my turn to have a close encounter with you.”</i> she says while leaning downward, feeling her hot breath on your already wet entrance. \n\nWithout further delay, you feel her energetic mouth eating you out without any finesse, obnoxious slurping sounds being heard by everyone around you. \n\nThe crowd cheers eagerly at the consummation of the act, and you can hear how they also start to engage in lewd acts themselves, encouraged by you two. \n\nYou can feel Alba’s passion with what she is doing with her hands and mouth, only pausing to grasp for air. Her pace is wild, her hips moving up and down, as if she was trying to get fucked by your face.\n\nShe is grabbing your ass, and the closer she is to her climax, the pain of her claws is increased. At some point you fear that she may tear your ass apart, but Alba servants keep giving you drugs and drinks until you lose your senses, focusing only on releasing your own orgasm.\n\n<i>“I’m almost there "+ GameControl.playerName +"! Fill me up! Give me all you got!”</i> she begs at you while her body shivers and her nether parts clench. You grab her by her hips and pull her until you are unable to breath, using all your might to make her cum. This lewd act is what she needed to let herself go, overflowing your mouth with her fluids, which thanks to your mental state it tastes like delicious nectar that you make sure to drink until the last drop. \n\nYou yourself can’t hold anymore and waves of pleasure inundate your mind. She holds on to you while you keep releasing your fluids into her mouth, making sure she gets as much as she can inside her. Once its over, she falls to the side, her gaze lost. \n\nBefore you can stand up you feel someone using an ointment on your buttocks, a servant of Alba that’s used to take care of those that have sex with her. By the dripping blood, its obvious she did a mess, but the woman takes care of you immediately, numbing your pain. \n\nWith Alba passing out by the drugs and pleasure, you decide to go back to your table and enjoy the rest of the night.";
			}
			Board.text += "\n\nThe feasts doesn’t ends until the next morning. Helena and the rest of important people left to rest hours ago, while you decided to stay a little longer since this was the first time you were in a festival. \n\nExhausted and drunk, you go back, but once in your room you stumble around. When you almost fall to the ground you hit the wall, and without realizing you hit a secret mechanism that activates a sliding door. Although the sounds is loud, everyone in the castle is asleep or had passed out, and no one comes to inspect what is going on. \n\nYou can see there are stairs behind the secret door, but you can’t see whats down there. You sober up enough to lock your door, so you can investigate after the hangover. \n\n";

			/*hire artist changed*/
			endTurnFun ();
			CityControl.city100Corruption -= 5;
			NPCCharList.CharFollower [iHelena].charCorruption -= 5;
			NPCCharList.CharFollower [iAbbadon].charCorruption -= 5;
			NPCCharList.CharFollower [iAbbadon].charRelationship += 5;
			NPCCharList.CharFollower [iAlba].charCorruption -= 5;
			NPCCharList.CharFollower [iAlba].charRelationship += 10;
			NPCCharList.CharFollower [iAlba].charLove += 5;
			CityControl.city100Happiness += 3;
			CityControl.city100Education += 1.5f;
			Quest HelenaQuest4 = new Quest();
			QuestsController.createQuest(HelenaQuest4, "Dark secrets", "You found a secret passage on your bedroom, what you'll find inside?.", 13, 3004);
			QuestControl.helenaQuest = 4;
			QuestsController.RemoveID (3003);
			return;
		}

		if (selector == 3 && confirmationControl == 6) {
			Board.text = "You take the night to focus on yourself, not interested in flirting with anyone present.\n\nThe feasts doesn’t ends until the next morning. Helena and the rest of important people left to rest hours ago, while you decided to stay a little longer since this was the first time you were in a festival. \n\nExhausted and drunk, you go back, but once in your room you stumble around. When you almost fall to the ground you hit the wall, and without realizing you hit a secret mechanism that activates a sliding door. Although the sounds is loud, everyone in the castle is asleep or had passed out, and no one comes to inspect what is going on. \n\nYou can see there are stairs behind the secret door, but you can’t see whats down there. You sober up enough to lock your door, so you can investigate after the hangover. \n\n";

			/*hire artist changed*/
			endTurnFun ();
			CityControl.city100Corruption -= 5;
			NPCCharList.CharFollower [iHelena].charCorruption -= 5;
			NPCCharList.CharFollower [iAbbadon].charCorruption -= 5;
			NPCCharList.CharFollower [iAbbadon].charRelationship += 5;
			NPCCharList.CharFollower [iAlba].charCorruption -= 5;
			NPCCharList.CharFollower [iAlba].charRelationship -= 3;
			CityControl.city100Happiness += 3;
			CityControl.city100Education += 1.5f;
			Quest HelenaQuest4 = new Quest();
			QuestsController.createQuest(HelenaQuest4, "Dark secrets", "You found a secret passage on your bedroom, what you'll find inside?.", 13, 3004);
			QuestControl.helenaQuest = 4;
			QuestsController.RemoveID (3003);
			return;
		}


		///////////////////////////// sexual punishment // Corporal punishment

		if (selector == 0 && confirmationControl == 100) {
			WorldControl.day += 7;
			GameControl.attAlignment -= 2;
			CityControl.city100Infrastructure += 1;

			Board.text = "What’s the point of having a dungeon if you're not going to have any fun with it?\n\nYou order your guards to undress him. His body is strong, covered in sweat. You ask him if he's scared, but he just grunts at you. You smile and tell him that he will be.\n\nYour first order is to ask your guards to leave the room, but bring a servant first. When she comes, you order her to bring the toys. Ashamed, she hurries and shortly comes back with a wide selection of gags, canes, whips, dildos, and more. You tell her to just wait there in silence, while you do your own thing. \n\nWith that settled, you command him to kneel, but as expected, he refuses. You grab a cane, and with a precise strike behind of the back of his legs you force him to bend. With no alternative left, you keep hitting him until he learns his lesson and stays down. \n\n ";
			if (GameControl.dick1Size > 0) {
				Board.text += "Now that he's been softened up, it's time to have some fun. You grab a gag that forces his mouth open, and after a couple of strong slaps across his face he allows you to put it in. \n\nBefore you undress yourself you give him another slap, just to reaffirm your position. You can see that his spirit is slowly breaking. Exactly what you need.\n\nOnce you're naked you walk around him, and as a wonderful surprise you realize that his cock is hard and already dripping precum on the floor. You laugh at the pathetic man, mocking him for enjoying this mistreatment. But you also tell him that he should be proud of finally accepting his place beneath you.\n\nYou give him a kick on the guts, forcing out an ambiguous yelp caught between pleasure and pain. Amused, you stand in front of him again, and ask if he is just a masochist bitch that was looking forward to be punished. Although he doesn't answer, you can see in his eyes that he is looking forward to more.\n\nFine, you say, you’ll use him and treat him like the worthless trash that he is. You slap his face with your dick, smearing it with your precum. You can feel him whiffing your dick, and eagerly accepting any drop that falls into his mouth.\n\nReady or not, you grab him by the hair and aim your dick towards his mouth, forcing yourself to the hilt with a single trust. At first he chokes on it, wildly grasping for air. But after a couple of minutes of rigorous use he starts to get used to it, even enjoying it if his tongue is any indication.\n\nYou call over the servant enjoying the show, asking her to slam the biggest dildo she has in his ass. She only nods and acts in silence, while the man that’s sucking you is enjoying every inch thats getting on his ass. \nHe starts to move his tongue with more energy once the toy bottoms out, and you keep <i>punishing</i> his mouth, a pool of drool and precum already forming underneath you two. \n\nIt takes ten long minutes of insulting and face fucking until you finally reach the edge, ready to cum. You slap him on the face once more and tell him that is his time to redeem himself. You grab him by the ears and thrust faster, pushing yourself as deep as you can inside his throat. \n\nHis moans of pleasure surround you, letting go a powerful growl when you start to fill his stomach with your seed. At the same time, you can feel his hot cum landing on your feet, his climax even more powerful than yours.\n\nWhen you recover, you bring in your guards and command them to untie him and bring him with you.";
			} else {
				Board.text += "Now that he's been softened up, it's time to have some fun. You grab a gag that forces his mouth open, and after a couple of strong slaps across his face he allows you to put it in. \n\nBefore you undress yourself you give him another slap, just to reaffirm your position. You can see that his spirit is slowly breaking. Exactly what you need.\n\nOnce you're naked you walk around him, and as a wonderful surprise you realize that his cock is hard and already dripping precum on the floor. You laugh at the pathetic man, mocking him for enjoying this mistreatment. But you also tell him that he should be proud of finally accepting his place beneath you.\n\nYou give him a kick on the guts, forcing out an ambiguous yelp caught between pleasure and pain. Amused, you stand in front of him again, and ask if he is just a masochist bitch that was looking forward to be punished. Although he doesn't answer, you can see in his eyes that he is looking forward to more.\n\nFine, you say, you’re gonna use him and treat him like the worthless trash that he is. You slap his ass until its red this time, his dick becoming harder with each hit.\n\nYou call over the servant enjoying the show and ask her to bring you the biggest strap-on she has. She brings the toy to you, and once you're belted on, you grab him by the hair. You aim your new dick towards his ass, and force yourself in with a single thrust. He moans, clearly enjoying himself, but you decide to shut him up and ask the servant to push another dildo inside his mouth.\n\nHe chokes for a moment, but quickly adjusts while you keep roughly using him, humiliating him with each thrust into his ass. \n\nHe starts to move his body on his own, lusting for more punishment, a pool of his own pre building underneath him. \nIt takes ten long minutes of insults and fucking until you finally reach the edge, your body ready for orgasm. You slap him on the ass once more and tell him that its his time to redeem himself. You grab his balls and squeeze them as you speed up, plunging as deep as you can inside him. \n\nHis moans of pleasure fill the room, letting loose a powerful growl when he finally lets loose his seed upon the ground. At the same time, you can feel a shock of lightning crossing your body, forcing you to fall to the ground once is over. \n\nOnce you've recovered yourself, you command your guards to untie him and bring him with you. ";
			}
			Board.text += "You leave the dungeon just in time to meet the workers before they leave, your guards carrying the broken man behind you. With a simple hand gesture the guards walk towards the small crowd and throw the man to the ground, covered in your combined cum and sweat, still asking for more. \n\nYou tell them that they have a week to finish their job, or they know what’s next for them. No one dares to say anything, and fearfully grab their boss to take him away from your castle. \n\nAs predicted, they worked hard and the castle was repaired on time, and although you haven’t earned their appreciation with this job, now they know you mean business and to not accept deals they can’t or won’t fulfill. \n\nNow it's time to staff your castle.";
			QuestControl.helenaQuest = 1; 
			endTurnFun ();

			Quest HelenaQuest1 = new Quest();
			QuestsController.createQuest(HelenaQuest1, "New hirings", "With your castle repaired, it's time to staff it again!", 13, 3001);
			QuestsController.RemoveID (3000);
			return;
		}

		if (selector == 1 && confirmationControl == 100) {
			WorldControl.day += 7;
			GameControl.attAlignment -= 2;
			CityControl.city100Infrastructure += 1;

			Board.text = "Good ol’ fashioned corporal punishment is something everyone can understand. You go to a table and grab a wooden club <i>“What... What are you going to do with-”</i> before he can finish, you hit him hard in the stomach with it, forcing him to desperately grasp for air, his legs giving up for a second. \n\nWhen he just starts to recover, still defiant to you, you punch him in the face. It doesn’t take much until he starts to crack, even if he is big and has a macho attitude, his civilian life is uneventful and boring, making him ill equipped to deal with violence. <i>“Please, forgive me my liege...”</i> he says between sobs, but you refuse, hitting him now on the knees. \n\nYou leave the dungeon just on time to meet the workers before they leave, with your guards carrying the beaten man. With a simple hand gesture they walk towards the small crow and throw the man to the ground, with broken bones and bruises everywhere but still alive, if barely. \n\nYou tell them that they have a week to finish their job, or they know what’s next for them. No one dares to say anything, and fearfully grab his boss to take it away from your castle. \n\nAs predicted, they worked harder and the castle was repaired on time, although you haven’t earn their appreciation with this job, now they know you mean business, and to not accept deals they can’t or won’t fulfill. \n\nNow is time to staff your castle.\n";
			QuestControl.helenaQuest = 1; 

			Quest HelenaQuest1 = new Quest();
			QuestsController.createQuest(HelenaQuest1, "New hirings", "With your castle repaired, it's time to staff it again!", 13, 3001);
			QuestsController.RemoveID (3000);
			endTurnFun ();
			return;
		}

		///////////////////////////// Whores hire them / kidnap them 

		if (selector == 0 && confirmationControl == 101) {
			Board.text = "You agree to hire them for the amount of gold that they need, and they eagerly follow you to your castle. You can hear the murmurs of the citizenry while you parade through the city with an horde of whores and escorts on your back. Some of the people cheer, but you can see that most of them act with disgust or dismay. \n\nOnce at home, Helena guides them to their new bedrooms and assigns them basic instructions. Few days after they are accommodated, you can see they are struggling with their new tasks, taking some time to get used to their new lifestyle. \n\nHelena is clearly angry at them and their lack of skills <i>“I told you my liege, they are not prepared for these type of tasks. If you allow me, I can take care of them and train them.”</i>\n\nYou agree, knowing she is the most prepared person for the task at your disposal. <i>“Very well, I’ll start with their training soon, I hope to have results soon.”</i>\n\nHelena turns away and leaves, yelling something to the new staff on her way out. \n";

			endTurnFun ();
			WorldControl.day += 4;
			NPCCharList.CharFollower [iHelena].charRelationship += 1;
			NPCCharList.CharFollower [iHelena].charLoyalty += 1;
			CityControl.city100Corruption += 3;
			GameControl.attAlignment += 1;
			LawController.EnactLaw (new LawStaffWhores());
			Quest HelenaQuest2 = new Quest();
			QuestsController.createQuest(HelenaQuest2, "Discipline the staff", "Your new staff isn't behaving as it should, is up to you and Helena to teach them their place.", 13, 3002);
			QuestsController.RemoveID (3001);
			QuestControl.helenaQuest = 2;
			return;
		}

		if (selector == 1 && confirmationControl == 101) {
			Board.text = "You ask them to wait a moment, and you go back with your guards, asking them to surround the streets and take the group back to your castle. The guard nods at you and in few moments, the entire group is surrounded by them. One of the girls yells at you loudly while struggling with one of the guards <i>“What are you doing?! We had an agreement! Come on, let us go!”</i> but the guard just keeps pushing her away, sword in hand now, until the group behaves due to the fear.\n\nYou can hear the murmurs of the citizenry while you parade through the city with an horde of whores and escorts being pushed by your guards on your back. Some of the people cheer and insult them, praising you for taking them out of the streets, but you can see that most of the people act with disgust or dismay to such act. \n\nOnce at home, Helena guides them to their new bedrooms and assigns them basic instructions. Helena does her bests to calm them, and you can see she isn’t happy about what you just did either, but at this point she has used to your actions. Few days after they are accommodated, you can see they are struggling with their new tasks, taking some time to get used to their new lifestyle, and your guards have been working extra hard hunting them down when they try to escape, but so far none of them have gone away. \n\nHelena is exhausted, their lack of skills and motivation making them almost useless <i>“I told you my liege, they are not prepared for these type of tasks. If you allow me, I can take care of them and train them.”</i>\n\nYou agree, knowing she is the most prepared person for the task at your disposal. <i>“Very well, I’ll start with their training soon, I hope to have results soon... Although you should reconsider the deal they had, that would lift their spirits.”</i>\n\nHelena turns away and leaves, yelling something to the new staff on her way out. ";

			endTurnFun ();
			WorldControl.day += 4;
			NPCCharList.CharFollower [iHelena].charRelationship -= 3;
			NPCCharList.CharFollower [iHelena].charLoyalty -= 3;
			CityControl.city100Corruption += 3;
			GameControl.attAlignment -= 3;
			LawController.EnactLaw (new LawStaffWhores());
			Quest HelenaQuest2 = new Quest();
			QuestsController.createQuest(HelenaQuest2, "Discipline the staff", "Your new staff isn't behaving as it should, is up to you and Helena to teach them their place.", 13, 3002);
			QuestsController.RemoveID (3001);
			QuestControl.helenaQuest = 2;
			return;
		}

		///////////////////////////// Bukkake / spare her 

		if (selector == 0 && confirmationControl == 102) {
			Board.text = "You whisper to the young man to get a hold on Helena if she resists. He just nods and stands behind her, and proceed to ask Helena how is she feeling. \n\n<i>“I... I don’t feel comfortable here, my liege, but I need to stay in case you or the staff needs something from me.”</i> You thank her for her duty and tell her that, in fact, you have a request for her. \n\n<i>“Uh... What do you need, my liege?”</i> you tell her that she needs to ease up while you serve a drink with drugs. <i>“No, it’s fine my liege! I don't need a drink!”</i> she says while trying to move away, but the man holds her in place. \n\nYou bring the cup close to her face but she resists, turning her head away and closing her mouth. <i>“Don’t be like this darling.”</i> says the courtier, grabbing Helena’s head and blocking her nose, forcing her to grasp for air with her mouth, opportunity you use to force some of the liquid through her throat. \n\nShe moves and struggles for a couple of minutes before the effects of the drug numb her body, making her fall to her knees, her gaze lost and a dumb smile on her face. \n\nYou ask your partners to help you take her to the middle of the festival. Once there, you give a short speech thanking everyone for coming, and tell them that for tonight, your maid Helena is going to be working as the cum dumpster of the city, but to only use her mouth or there going to be consequences. The people applaud you and thank you for your generosity. \n\nAlba, still high and drenched in cum, approaches you. Before she even says something she gives you a kiss, her breath tasting like cum and alcohol, but you still return the favor while touching her breasts and ass. <i>“This party it’s better than I expected "+ GameControl.playerName +". But I cannot allow your maid to have all the fun, I’m going to help the crowd to get ready to shoot their juicy loads into her, if you don’t mind.”</i> you laugh and nod in approval, and with a happy face she turns around, walking towards the crowd thats either fucking each other or masturbating.\n\n<i>“Don’t be shy people, if you need a hand, or a nice ass or pussy to fuck, just use me!”</i> declares Alba, whom is immediately surrounded by a group of men and women to have their way with her. \n\nIt doesn’t take long until the first person is ready to unload on Helena, a middle aged man with an average cock. He stands with his cock just inches away from Helena, but she doesn’t reacts until the first jet of the hot load hits her right cheek, closing her eyes until the man is done. <i>“What... What is this?...”</i> she whispers while scooping some of the cum to give it a look. \n\n<i>“Is this... Ahh!”</i> she says, snapping out of her previous trance. You can hear some of the people laughing while she desperately tries to clean her face, but Alba takes notice and takes a break of being fucked to address Helena. <i>“Come on kiddo, there is nothing to worry about!”</i> Alba says, but Helena stands up and tries to leave, but stumbles and falls to the ground again. <i>“So you won’t behave uh? Well, let me help you out then.”</i> Alba grabs a cup that its filled with a strong aphrodisiac and several loads of cum, before sitting on top of Helena, who can’t resist. <i>“Come, take some!”</i> says Alba before taking a big gulp of the cup, to then kiss Helena and share the awful concoction made of saliva, cum and drugs. \n\nHelena tries to resist, but in her poor state she can’t. By the end of the third kiss Helena is not fighting anymore, but engaging in a wet kiss with Alba, and there is a small pool of fluids under your maid. \n\n<i>“Now, let’s go back to have fun! Give us your cum people!”</i> Alba yells to the crowd, who finally have the chance to get closer to the two girls and unload their charges. Whatever misses Helena’s mouth, Alba makes sure to lick it back and either swallow it for herself or spit it into your maids mouth. \n\nHelena is hallucinating who knows what, but she is totally unaware of what is going on, but at least she eagerly drinks whatever is pour into her mouth, while Alba is taking the heavy duty to serve anyone who needs a little more to get their seed flowing. \n\nAt the end of the night, Helena is asleep on the ground, her whole body covered in cum, still laughing and smiling while looking at the horizon, unaware of the awful stench that surrounds her. \n\nThe feasts doesn’t ends until the next morning. You ask to one of your servants to take care of Helena while the rest of important people have left to rest hours ago.\n\nExhausted and drunk, you go back, but once in your room you stumble around. When you almost fall to the ground you hit the wall, and without realizing you hit a secret mechanism that activates a sliding door. Although the sounds is loud, everyone in the castle is asleep or had passed out, and no one comes to inspect what is going on. \n\nYou can see there are stairs behind the secret door, but you can’t see whats down there. You sober up enough to lock your door, so you can investigate after the hangover. ";

			endTurnFun ();
			loadFollowers ();
			NPCCharList.CharFollower [iHelena].charCorruption += 7;
			NPCCharList.CharFollower [iHelena].charRelationship -= 5;
			NPCCharList.CharFollower [iHelena].charLove -= 5;
			GameControl.attAlignment -= 3;
			NPCCharList.CharFollower [iAlba].charRelationship += 7;
			NPCCharList.CharFollower [iAlba].charLoyalty += 7;
			CityControl.city100Corruption += 5;
			NPCCharList.CharFollower [iAbbadon].charRelationship -= 5;
			NPCCharList.CharFollower [iAbbadon].charLoyalty -= 5;
			CityControl.city100Happiness += 5;

			Quest HelenaQuest4 = new Quest();
			QuestsController.createQuest(HelenaQuest4, "Dark secrets", "You found a secret passage on your bedroom, what you'll find inside?.", 13, 3004);
			QuestControl.helenaQuest = 4;
			QuestsController.RemoveID (3003);
			return;
		}

		if (selector == 1 && confirmationControl == 102) {
			Board.text = "You leave Helena alone while you keep enjoying yourself. At first just with the couple, but you end up joining to crowd in a massive orgy, Alba usually at your side sharing jokes, partners and cum.\n\nExhausted and drunk, you go back, but once in your room you stumble around. When you almost fall to the ground you hit the wall, and without realizing you hit a secret mechanism that activates a sliding door. Although the sounds is loud, everyone in the castle is asleep or had passed out, and no one comes to inspect what is going on. \n\nYou can see there are stairs behind the secret door, but you can’t see whats down there. You sober up enough to lock your door, so you can investigate after the hangover. ";

			endTurnFun ();
			loadFollowers ();
			NPCCharList.CharFollower [iHelena].charCorruption += 4;
			NPCCharList.CharFollower [iHelena].charRelationship -= 4;
			NPCCharList.CharFollower [iAlba].charRelationship += 5;
			NPCCharList.CharFollower [iAlba].charLoyalty += 5;
			CityControl.city100Corruption += 5;
			NPCCharList.CharFollower [iAbbadon].charRelationship -= 5;
			NPCCharList.CharFollower [iAbbadon].charLoyalty -= 5;
			CityControl.city100Happiness += 5;


			Quest HelenaQuest4 = new Quest();
			QuestsController.createQuest(HelenaQuest4, "Dark secrets", "You found a secret passage on your bedroom, what you'll find inside?.", 13, 3004);
			QuestControl.helenaQuest = 4;
			QuestsController.RemoveID (3003);
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

	// // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // 



	public void helenaWelcome()
	{

		if (NPCCharList.CharFollower [iHelena].charCorruption > 50) {
			//corrupt
			Board.text = "You are not sure, but you can swear you hear her moaning a minute ago. When you enter the throne room, you can see Helena standing from your throne. When you call her, she wipes her hand. <i> “Oh hello there " + mcpronoun + "… I was taking my break… Anyway, do you need me for something darling? I could give you a hand if you want me to…” </i> She licks her lips and gets closer to you.\n\nDo you need Helena for anything? ";

			if (NPCCharList.CharFollower [iHelena].attWillpower > 90) {
				Board.text = "You see Helena bossing servants around, giving a good spanking to one of the lazy maids. When she sees you, she commands you to walk toward her with a hand gesture. Once you get there, she tells you to sit and you immediately do so. <i> “Hi doggie, did you need something from your master?” </i>";

			} else if (NPCCharList.CharFollower [iHelena].attWillpower < 10) {
				Board.text = "You see Helena being bossed and mocked by the rest of the servitude. She has clearly lost all the control she had in the past. When you call her, she immediately walks towards you. You can see how she is aroused by the treatment she just received. She kneels in front of you, her face very close to your crotch. <i> “My Liege… Do you need something… I am here to serve you…” </i> You know that she would eat you out right there if you just asked, but what you need from Helena?";

			}


			if (GameControl.charArmorTags [1] == true && GameControl.charArmorTags[2] == false) {
				Board.text = "When you enter the throne room, Helena immediately walks towards you. <i>“It’s always a pleasure to see you my Liege… Mmm”</i> She looks at your exposed body parts, licking her lips. <i> “How can I serve you?… With my mouth perhaps?”</i> ";

			}

			if (GameControl.charArmorTags [1] == true && GameControl.charArmorTags[2] ==  true) {
				Board.text = "When you enter the throne room, Helena immediately walks towards you. <i>“It’s always a pleasure to see you my Liege… But I don't get why waste all of this with the sisterhood…”</i> She looks at your exposed body parts, licking her lips. <i> “Very well, I guess fucking is not on the orders today, so how can I serve you?… With my mouth perhaps?”</i> ";

			}

			if (WorldControl.tagControl [5] == true) {
				Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond);
				randNum = Random.Range (0, 100);
				if(randNum > 50){
					Board.text = "When you enter the throne room you find Helena being fucked from behind by one of the stable boys, her moans echo the whole place, and it doesn’t take long until both of them cum. He stays inside of her for a minute, waiting for his dick to go limp, and once he is done he frees her. \n\nShe walks towards you with a smile on her face. <i> “My apologies my Liege, that took more than expected… How can I serve you? And if you are wondering, no, my tank is not full yet…” </i>\n\nDo you need Helena for anything?";

				}else{
					string line1 = "";
					if (WorldControl.tagControl [4] == true) {
						line1 = "Helena, knowing your love for cum, seems to have saved some on her mouth, once she is with you, she opens her mouth showing a good amount of semen, and inviting you to kiss her. You of course won’t waste the chance and engage in a wet, salty kiss with your head maid. \n\n<i> “Tasty right? I knew you wouldn’t resist… Do you need me for something else?” </i>";
					} else {
						line1 = "Helena walks towards you, and once she is in front she opens her mouth, displaying all the cum still inside it, before swallowing it with a big gulp. <i>“I’ve learned so much since you came here, my Liege… What can I do for you?” </i>";
					}
					Board.text = "When you enter the throne room you find Helena sucking the two big cocks from other servants of the castle. It doesn’t take long until they bath her in their cum, although she tries to swallow as much as it is possible for her. Once she is done, she walks towards you." + line1;
				}

			}

		} else {// // //
			//pure 

			Board.text = "You find Helena working, and as busy as usual. You call her and she cheerful walks towards you, with a smile on her face. <i> “Good day my " + mcpronoun + ", how I can be of your service?”</i>\n\nDo you need Helena for anything? ";

			if (NPCCharList.CharFollower [iHelena].attWillpower > 90) {
				Board.text = "You can see her bossing people around. When you call her, she gives you a look and with a hand gesture commands you to get close to her. She talks down to you, as she’s been doing for a while. <i> “Hello my servant, you came here to lick my boots again or do you need something else?” </i>\n\nDo you need Helena for anything? ";

			} else if (NPCCharList.CharFollower [iHelena].attWillpower < 10) {
				Board.text = "You can see how the servitude ignores or mocks the weak nature of Helena. Clearly, she is not in control. When you call her she immediately walks towards you. <i> “Y-yes my Liege! What can I do for you?” </i> She kneels in front of you, ready to follow your very order, do you need Helena for anything? ";

			}


			if (GameControl.charArmorTags [1] == true && GameControl.charArmorTags[2] == false) {
				Board.text = "You find Helena working, and as busy as usual. She is pretending you aren’t there: your clothing, or lack of them, make her feel uncomfortable. \n\nWhen you call her she reluctantly walks towards you. <i>“Y-yes my Liege? Do you need me?… I’m sorry is just… Can maybe you wear something else?…</i> You tell her that you wear whatever you want, and she nods and apologizes. <i>“O-of course, forgive my impertinence…”</i> \n\nDo you need Helena for anything?";

			}

			if (GameControl.charArmorTags [1] == true && GameControl.charArmorTags[2] ==  true) {
				Board.text = "You find Helena working, and as busy as usual. She is pretending you aren’t there: Your clothing, or lack of them, make her feel uncomfortable. \n\nWhen you call her she reluctantly walks towards you. <i> “" + mcpronoun + "… I know this is a holy armour of the sisterhood but… Don’t you think it reveals a little too much?… I D-dont think it is appropriate…”</i>";

			}


		} // // //

		if (NPCCharList.CharFollower [iHelena].charRelationship < 40) {
			Board.text += "\n\nYou barely know Helena, if you want to unlock more options, you need to know her more. You need to talk with her first. Each topic has more than one conversation.";

		}

	}// // // // // //









	// // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // 

	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		panConfirmation.sortingOrder = -500;
		panMainPanel.sortingOrder = -500; 
		endTurnPanel.sortingOrder = 500;


	}

	void charVirginity()
	{

		if(GameControl.isVirgin == true){
			Board.text += "\n\nYour character lost its virginity!";
			GameControl.isVirgin = false; 
		}

	}


	void loadHelenaData(){
		iHelena = 0;

		while (iHelena < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iHelena].charID >= 3000 && NPCCharList.CharFollower [iHelena].charID < 4000){
				WorldControl.NPCID = NPCCharList.CharFollower [iHelena].charID;
				WorldControl.PortraitIDLayer0 = NPCCharList.CharFollower [iHelena].charPortraitLayer0;
				WorldControl.PortraitIDLayer1 = NPCCharList.CharFollower [iHelena].charPortraitLayer1;
				WorldControl.PortraitIDLayer2 = NPCCharList.CharFollower [iHelena].charPortraitLayer2;
				WorldControl.furryPic = NPCCharList.CharFollower [iHelena].isFurry;
				WorldControl.futaPic = NPCCharList.CharFollower [iHelena].isFuta;
				break; 
			}
			iHelena++;

		}

	}

	void loadFollowers(){
		iAbbadon = 0;
		while (iAbbadon < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iAbbadon].charID == 1000 ){
				break; 
			}
			iAbbadon++;

		}

		iAlba = 0;
		while (iAlba < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iAlba].charID == 13000 ){
				break; 
			}
			iAlba++;

		}

	}


	void Start()
	{ // change to awake

		if (GameControl.mcGender == GameControl.MCGender.FEMALE) {
			mcpronoun = "Lady";
		} else {
			mcpronoun = "Lord"; 
		}
		loadHelenaData (); 
		helenaStart ();




	}

}
