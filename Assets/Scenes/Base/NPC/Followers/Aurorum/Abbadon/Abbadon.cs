using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class Abbadon : MonoBehaviour {
	static int iAbbadon = 0; // used to load abbadon 
	static int iAlba = 0; 
	static int iHelena; 

	NPCCreator npcCreator = new NPCCreator();

	public Text Board; 
	public Canvas mainPanel;
	public Canvas panEndTurn;
	//public Canvas panBack;


	public Button buttOutfitCorrupt1; //this can be closed since you require either corruption or relationship.
	public Button buttOutfitNaked; //this can be closed since you require either corruption or relationship.
	public Button buttItems; // closed until you finish the quests of transformation

	public Text textBeastTransformation; 
	public Button buttBeastTransformation; // closed until you finish the quest of transformation
	/*public Button buttScene2; //this can be closed since you require either corruption or relationship.
	public Button buttScene3; 
	public Button buttScene4; 
	public Button buttScene5; 
	public Button buttScene6; */

	//static int continueControl; 
	static int confirmationControl; 
	public Canvas panConfirmation;

	public Text option0Name; 
	public Text option1Name;
	public Text option2Name;


	public Button option1Butt; 
	public Button option2Butt; 
	public Button buttGender; 

	string pronhimher; 
	string pronhisher;
	string pronheshe; 

	//public Text panConfirmationTitle;





	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	public void abbadonStart(){
		switch (QuestControl.abbadonQuest) {
		case 0: 
			NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1000;
			Board.text = "Following your maid’s directions, you find yourself in Abbadon’s district in no time. The place is faring no better than any other district, with streets full of jobless performers and old warriors, with battered equipment clearly displaying the scars of gladiator work in the Colosseum. \n\nIt doesn’t take long for you to arrive at Abbadon’s mansion, a beautiful house at the end of the district; outstanding even in these dire times. You knock on the door and almost immediately are greeted by a maid, who then asks you to wait a moment for the head of the house. It isn’t long before a young person opens the door again. Although he is dressed like a woman, "+  pronhisher +" behavior and attitude is that of a man. You ask him if he is Abbadon. <i>“What do you think, moron? Why would I be here otherwise, to entertain you as a clown?”</i> "+ pronhisher +" words are terse, but "+  pronhisher +" voice leaves you uncertain. Though slightly masculine, it has other, more feminine qualities to it also. You open your mouth to respond, but he quickly shushes you <i>“Just forget it and come inside, I know who you are so don’t both introducing yourself, there is business to talk and I’m a very busy man.”</i> You follow him into a lavish dining room, decorated with gold, silver, and many opulent pieces of comfortable looking furniture. You find yourself sitting in a beautiful armchair, while he rests in another. As you talk, the servants of Abbadon carry in a constant stream of drinks and pastries.\n\n<i>“So, you are "+ GameControl.playerName +" right? I expected something more... impressive, though I’m glad you don't bear any resemblance to your late uncle.”</i> You ask if there is any special reason behind "+  pronhisher +" interest in your uncle’s looks, and he almost spits out "+  pronhisher +" tea. <i>“No! Of course not! You have come here for my support, right? A newly entitled person comes here with claims of power. You are not the first one after your late uncle that has tried that, and let me tell you, not one of them had a happy ending. So I propose to you this; I’ll help you, and back your claims, but only after you have earned it... You can help me with certain tasks that are fit for less... less sophisticated tactics. I’m sure that’s something you can handle.”</i>\n\nBeyond the patronizing tone of Abbadon, you can sense some form of nervousness. Considering what Helena told you, this is no surprise; Abbadon may be one of the biggest houses of Aurorum, but in these times, that is worth almost nothing. You could pressure him into paying the taxes he owes and supporting you, or could just agree to help him in order to earn "+  pronhisher +" loyalty and legitimate support.";
			option0Name.text = "Help him";
			option1Name.text = "Pressure him";
			panConfirmation.sortingOrder = 500; 
			confirmationControl = 0; 
			break;
		case 1: // take punk // show of force
			if (QuestControl.abbadonHelp) {
				Board.text = "Following Abbadon’s request, you go to the Colosseum in which the supposed gang leader resides. From a number of blocks away, you can already see the big encampment that surrounds the place, and that it is crowded with people. Although it is easy to understand why Abbadon and the other citizens would feel threatened by this situation, as you walk amongst the people, you realize that most of them are just regular people who happen to be going through tough times.Most of them are too old or too young to fight, or properly work. No one tries to stop you as you enter the enormous building. \n\nInside, you can see that it’s almost as packed as outside, and you have to push your way through a thick crowd in order to get to its center. There, you can see a couple of small shacks, and what is supposedly the head gang of the place, though to call them that might be a stretch. You approach a very tall and big man, wearing nothing but rags, and ask him if he is in charge. He merely shakes "+  pronhisher +" head, and points to an old man resting in front of a nearby bonfire. \n\nAt this point, it becomes obvious to you that these people are not dangerous criminals, and instead are just people trying to get by. That being the case, you are sure that they must have to steal a great deal in order to survive, considering there are no jobs available, and hardly any commerce. Seeing as the outskirts are full of dangerous monsters, you can hardly blame them for their actions. \n\nYou approach the old man, and he addresses you before you have a chance speak <i>“My liege, we have heard the news that you were going to take care of the city. We are glad that you have come to us, the whole city needs change. It is in sore need of your help.”</i> You cross your arms, feeling uncomfortable about the situation. This was not what you were expecting, you are at least glad to have somebody welcoming you for once.\n\nYou have a long talk with him, but the result changes nothing. They refuse to leave the place, as they have nowhere else to go. It’s clear that asking them to leave won’t do anything, but you still have some options left.\n\nFor one, you could fight the old man and "+  pronhisher +" group. They look tough, but they are not combatants, so taking them would be easy. On the other hand, you could try to make a deal with them, offering them something in return for moving.";
				option0Name.text = "Deal";
				option1Name.text = "Fight";
				panConfirmation.sortingOrder = 500; 
				confirmationControl = 4; 

			} else {

				Board.text = "You take the day to visit the Colosseum where the drifters and their leader resides. From blocks away you can see the big encampment that surrounds the place, and crowded with people. Although is easy to understand why Abbadon and other citizens would feel threated by this situation, once you walk among the people you realize most of them are just regular people going through tough times, with most of them being too old or too young to fight or properly work. No one tries to stop you while you enter the enormous building. \n\nInside, you can see it’s almost as packed as outside, and you have to push your way around to the middle of it. There, you can see a couple of small shacks and whats supposedly is the main gang in charge of the place, if you could call them that. You get close to a very tall and big man, wearing rags, and before he can reacts with a swift punch you throw him at the ground, and then pummel "+  pronhisher +" face with your knuckles. People around you gasp, yell or cry but you keep going until he almost passed out, and finally ask if he is the leader. \n\nHe can’t speak, but slowly points to an old man not far from you. Happy with the mess you did, you let him go and walks toward the old man, who is trembling and begs you to stop before you even do something. \n\nWith a smile on your face, you know you have him where you want. You have either try to reach a favorable deal with him to move everyone from this place, or just kill him as a warning that you won’t tolerate this type of leadership and going against the law in your city. Although it will create discontent, it certainly would help to put them in place.\n\n";
				option0Name.text = "Deal";
				option1Name.text = "Kill him";
				panConfirmation.sortingOrder = 500; 
				confirmationControl = 102; 
			}


			break;
		case 2: // looking for talent
			WorldControl.PortraitIDLayer0 = 0;
			WorldControl.PortraitIDLayer1 = 0;
			WorldControl.PortraitIDLayer2 = 0;
			Board.text= "You spend days looking for a suitable candidate that could help you as captain of the guard, but you have no luck. As Abbadon said, there are very few competent warriors around, and those that are have already been hired. Either that or they are traveling, or simply not interested. You are close to the point of hopelessness, when you hear someone yelling a block away from you. \n\nWhen you arrive, you can see two warriors engaged in a duel. One of them is a very strong amazon, wearing only leather armour and exotic weapons.The other one looks like a gladiator, garbed in chainmail, and wielding a traditional shield and gladius. The amazon mercilessly attacks the gladiator, but he manages to successfully parry or deflect each of her attacks.\n\nAfter several minutes of intense fighting, both of them move to attack, but stop just in time to avoid killing one another. Each is left with only a few small injuries; mostly superficial cuts and scrapes. The two start to discuss which of them deserves the victory, both claiming that they were faster than the other. Although you are amongst a small crowd, which has gathered around the two, the gladiator recognizes you. <i>“Let’s settle this, "+ GameControl.playerName +" is here, and "+ pronheshe +" sits at the throne. Let "+ pronhimher +" decide who won the battle. What do you say, my liege?.”</i> Everyone looks at you, waiting for your verdict. \n\nBoth of them look to be great warriors, and either one could make a great captain of the guard. Favoring one over the other will give you the chance to get closer to them, and eventually offer them the job. So, who will it be?\n";
			option0Name.text = "Amazon";
			option1Name.text = "Gladiator";
			panConfirmation.sortingOrder = 500; 
			WorldControl.day += 4;
			confirmationControl = 7; 


			break; 
		case 3: 
			Board.text = "A couple of days pass, and Abbadon’s architects knock at your door. They have two separate proposals, each regarding the rebuild of a different section of the district. The first plan focuses on the arts, with the theater as the main attraction, and long streets for performers and kiosks. The other option is to focus on sports, utilising the Colosseum as the main attraction, and having merchandise sold within it.\n\n<i>“I would suggest that you support the arts, "+ GameControl.playerName +". During these trying times, if we wish to fight effectively against corruption, we must educate the people. Blood sports are a good distraction, and more profitable, but it has the potential to cause even more chaos on the streets, and that’s no good right?”</i> \n\nAbbadon is clearly in favor of supporting the arts but, as you are the one who has the power to grant the permits, the final decision remains yours to make. \n\nWhich one should you support? ";
			option0Name.text = "Arts";
			option1Name.text = "Blood sports";
			WorldControl.day += 2;
			panConfirmation.sortingOrder = 500; 
			if (QuestControl.abbadonHelp) {
				confirmationControl = 12; 
			} else {
				confirmationControl = 104; 
			}
			break;
		case 4: // premier
			WorldControl.day += 16; 
			panConfirmation.sortingOrder = 500; 

			if (LawController.IsEnacted<LawArtsHigh> () || LawController.IsEnacted<LawArtsLow> ()) {
				Board.text = "Abbadon has moved all "+  pronhisher +" muscle to get the theater ready as soon as possible. After two intense weeks, the main theater has been fully renovated, along with many of the streets of the district. Certainly Abbadon is using most of "+  pronhisher +" capital on this project. If it doesn’t pay off, he will go broke for sure.\n\nYou now have the honour of finding the main show for the event, as he can’t take care of everything himself. You set up an improvised stage in one of the parks, and begin to cast groups of people and companies that are interested in the event. The crowd is bigger than you were originally expecting, but the quality of many of the acts is deplorable. \n\nAfter two long days of casting, you end up with two potential companies. One of them is a very innovative dancing company, which uses elegant moves, jumps, and music to tell a story. They call this new style ballet. They claim that their art has been in development for more than a century, but that they arrived to the city shortly after the plague and never got a chance to perform it in public. \n\nThe other group is a company which has been organized by the most elite girls and boys from the red district, alongside the best musicians from the city. They are performing a genre that they call operetta. Although the show is full of comedy, satire, and risque performances by the girls, its format is very futuristic, and is beyond anything else you have seen.\n\nNo other group has enough quality, or is impressive enough to even challenge these two plays, and turning down the opportunity to choose one would get you killed by Abbadon.\n\nAfter deliberation, you decide to pick...";
				option0Name.text = "Ballet";
				option1Name.text = "Operetta";
				if (QuestControl.abbadonHelp) {
					// help
					confirmationControl = 16;
				} else {
					// coerce
				
					confirmationControl = 107;
				}
			} else {
				// sports
				Board.text ="Abbadon has moved all of "+  pronhisher +" muscle in order to get the Colosseum ready as soon as possible. After two intense weeks, the place has been fully renovated, along with many of the streets of the district. Certainly Abbadon is using most of "+  pronhisher +" capital on this project. If it doesn’t pay off, he will go broke for sure. \n\nYou have the honour of finding the main show for the event, as he can’t take care of everything himself. You set up an improvised stage in one of the parks, and begin to cast groups of people and companies that are interested in the event. The crowd is bigger than you were originally expecting, but the quality of many of the acts is deplorable. \n\nAfter two long days of casting, you end up with two potential groups. One is led by the most famous ludus in Aurorum, a small house that is renowned for the quality of its gladiators. The other group is led by a slaver, who has a wide variety of beasts at their disposal; men, women, and futanaris, among others, who look as fierce as they are gorgeous.\n\nThey’ll face both beasts and slaves of house Abbadon, and although you have no doubt these two groups will have no trouble in obliterating Abbadon’s people, the show that each puts on will be vastly different. The gladiators will clearly exceed in regular combat, leaving a bloody mess behind them. The beasts, although they could be just as lethal, you can tell by their throbbing dicks and dripping cunts that they won’t be going for blood; at least not at first. \n\nNo one else has a group of warriors or monsters that are impressive enough to even challenge these two teams, and turning down the opportunity to choose one would likely get you killed by Abbadon.\n\nAfter some deliberation, you decide to pick...";
				option0Name.text = "Gladiators";
				option1Name.text = "Beasts";
				confirmationControl = 20;
			}

			break;
		default:
			mainPanel.sortingOrder = 500;
			Board.text = "You are thinking about Abbadon, what would you like to do?";
			Board.text += "\n\nCurrent willpower: "+ NPCCharList.CharFollower [iAbbadon].attWillpower.ToString() ;
			Board.text += "\n\nCurrent love: "+ NPCCharList.CharFollower [iAbbadon].charLove.ToString() ;
			break; 

		}


	}

	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


	public void confirmFun(int selector){
		// corruption confirmations start at 100, pure at 0

		//help him
		if (selector == 0 && confirmationControl == 0) {
			Board.text = "<i>“Now that you’ve agreed to help me, let me tell you about the troubles we’re facing.”</i> He sips "+  pronhisher +" tea elegantly, clearing "+  pronhisher +" throat before continuing. <i>“You see, the city has been in turmoil for the past few years. There is no food, no money, and therefore no order. It is because of this lack of order that some of my properties have been seized by undesirable occupants. They’re merely punks, and should pose no threat to you, I’m sure. ”</i>\n\nYou ask why, if they are so easy to deal with, he hasn’t simply done it himself, nor ordered "+  pronhisher +" guards to do so for him. <i>“Your ignorance is... Never mind, if I haven’t it’s because I only have enough men to protect my house and the surrounding neighborhood, and I cannot risk my security or the security of other noble houses to take care of this. Also, it is not my job to keep this city safe and peaceful, this situation should be handled by anyone who claims to be entitled to the city lordship.”</i> \n\nAlthough you don't agree with him entirely, ridding the streets of crime strikes you as a good idea nonetheless. You accept "+  pronhisher +" task, and tell him that you will take care of the gang. <i>“Don’t worry, you don’t need to take every single one by hand, only their leader, who’s currently living in the Colosseum. A good beating should show them, and the city, that there is a new boss around. Doing this will help to remedy the situation, I’m sure of it.”</i>\n\nAbbadon pauses to eat a sweet pastry, and although you already know what your task is, you may wish to hang around with him for a little while longer and get to know him more. You might even learn something about the city along the way.";
			QuestControl.abbadonHelp = true; 
			option0Name.text = "Hang with Abbadon";
			option1Name.text = "End the meeting";
			confirmationControl = 1;
			NPCCharList.CharFollower [iAbbadon].charRelationship += 10;
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 10;
			QuestControl.abbadonQuest = 1; 
			Quest AbbadonQuest2 = new Quest ();
			QuestsController.RemoveID (1000);
			QuestsController.createQuest (AbbadonQuest2, "Take a punk down", "After strolling through Abbadon’s district, you realize that the first thing you need to do is to take care of those who are occupying the most important building in it.", 14, 1001);
			GameControl.attAlignment += 5;
			return; 
		}

		//pressure him 
		if (selector == 1 && confirmationControl == 0) {
			//confront
			Board.text = "You answer "+  pronhisher +" proposal with a laugh, and tell him that under the current circumstances he is hardly in a position to be flexing "+  pronhisher +" muscles. <i>“You... How fucking dare you? You are nobody here, just a useless being living in a ruined castle with a title that no one cares about. If anything, you should be thanking me for even giving you a minute of my time. You had better apologize before I kick you out of here.”</i>\n\nThe brat is seriously angry at you, but if he really didn’t need you he would have thrown you out by now instead of giving you the <i>chance</i> to apologize. Still, even if he caves in, your relationship with him will greatly diminish, and even if "+  pronhisher +" house loses power, it’s unlikely to disappear entirely. Should you try to rectify the situation by apologizing, or just keep pushing?\n";
			QuestControl.abbadonHelp = false; 
			option0Name.text = "Apologize";
			option1Name.text = "Keep pushing";
			confirmationControl = 100;
			NPCCharList.CharFollower [iAbbadon].charRelationship -= 5;
			NPCCharList.CharFollower [iAbbadon].charLoyalty -= 5;
			QuestControl.abbadonQuest = 1; 
			GameControl.attAlignment -= 3;  
			Quest AbbadonQuest2 = new Quest ();
			QuestsController.RemoveID (1000);
			QuestsController.createQuest (AbbadonQuest2, "Show of force", "After strolling through Abbadon’s district, you realize that the first thing you need to do is to take care of those who are occupying the most important building in it.", 14, 1001);
			return; 
		}

		///////////////////////////// Hang // end meeting

		if (selector == 0 && confirmationControl == 1) {
			Board.text = "With a quick hand gesture, you ask to one of the servants for more tea; signalling that you intend to stay for a little while longer. Abbadon doesn’t mind it, nor is he in a hurry to leave. You ask about "+  pronhisher +" House, its legacy, and for a deeper insight into its history. \n\n<i>“Of course, such a lovely topic to discuss. Since the foundation of Aurorum, the house Abbadon has been the cornerstone of its wealth and power. Theaters, bath houses, the Colosseum; all of these were key to the city’s development as a place of culture. A place where people from anywhere on the island would come to relax, and enjoy themselves. It’s for this reason that, as you have no doubt seen by now, this district is the biggest one in the city. The industrial district, owned by House Furius, is the only one that even comes close to matching it. We are a rigorous house, proud of our traditions and strong supporters of arts and education.”</i>\n\nWhen he is done with "+  pronhisher +" speech, he pauses for a moment. You can see that "+  pronhisher +" strong facade weakens a little when he has to face the reality of the current situation. <i>“The unfortunate truth is that since the plague; trade, and therefore tourism, has all but disappeared. I pray for the day that this island can overcome such desperate times and people can once again visit, and revel in the joys that we have to offer. But, alas, I have seen no sign that things will ever change.”</i> He finishes the rest of "+  pronhisher +" cup in a single gulp, perhaps attempting to drown some of "+  pronhisher +" sorrows in tea. \n\n<i>“Then again, perhaps you are the sign.”</i> he pauses, and for a short moment you believe he is serious, until he quickly bursts into a fit of laughter. <i>“Hahaha... don’t be mad "+ GameControl.playerName +", but as I said before, you are not the first one to come here and try to change things. Cynicism seems to be all that’s left in the city these days.”</i>\n\nReading Abbadon is difficult; is he really joking about you, or does he have some traces of hope for the future? He says he is being cynical, yet "+  pronhisher +" spirits seem to be much higher than they were before. Whatever the case may be, the conversation has helped you to get more acquainted with him, and seems far more at ease than before. Perhaps you could find an opening to flirt with him, or just finish the meeting.\n\n";
			option0Name.text = "Flirt";
			option1Name.text = "End the meeting";
			confirmationControl = 2;
			NPCCharList.CharFollower [iAbbadon].charRelationship += 5;
			NPCCharList.CharFollower [iAbbadon].charLove += 5;

			return;
		}
		//ending
		if (selector == 1 && confirmationControl == 1) {
			Board.text = "Once you have finished discussing any relevant matters, you are ready to leave the place, and thank him for "+  pronhisher +" hospitality and time. <i>“Don’t worry, you may be an underdog in this city, but everyone deserves at least one chance.”</i>\n\nHe accompanies you to the door and you give him a short bow on your way out. You tell him that you’ll be back once you have completed your task. <i>“I’m eagerly awaiting your results, good luck "+ GameControl.playerName +".”</i>\n\nYou turn around, but before you can leave, Abbadon calls out to you. <i>“Wait! You might need some help to deal with them. As a token of our gratitude for your help, please take these. Just don’t waste them on anything stupid.”</i> He hands you a bag filled with 200 gold coins, and you thank him one last time before you turn and go.\n\nAs you leave, you walk past the Colosseum, and see several bands of drifters lingering around the area. They don't look particularly dangerous; at least no more than the beasts outside, but they are definitely creating a mess, and preventing any chance of resurrecting this commercial and touristic district. \n\nThe majority of them are just hanging around, trying to get by, but there is a small group that looks to be in charge of the rest. If what Abbadon said was correct, their leader probably is inside the Colosseum. You should get ready to face him later.  \n";
			GameControl.charGold += 200; 
			endTurnFun ();
			return;
		}

		///////////////////////////// Flirt / end

		if (selector == 0 && confirmationControl == 2) {
			Board.text = "You tell him that you are impressed with "+  pronhisher +" elegance and manners, truly outstanding in comparison to the general populace of the city. He pretends to be unaffected by your words, but "+  pronhisher +" slightly blushing cheeks betray him. <i>“I know "+ GameControl.playerName +", I know. Those are the traits that best describe my house. If you really want my favor you’re going to have to do better than stating the obvious.”</i> Although "+  pronhisher +" cup is empty, he pretends to sip at it, hiding "+  pronhisher +" smile and rose-tinted cheeks. \n\nBut you persist; informing him that, although you are indeed inexperienced in these matters, you can see the value of having a man of culture at your side, assisting you with the delicate task of governing. This time "+  pronhisher +" smile is different, showing more determination and understanding, having seen past your flattery. <i>“I see what you are trying to do "+ GameControl.playerName +", you want to earn my support by using less conventional methods.”</i> "+ pronhisher +" paranoid thoughts were not entirely accurate, but correcting him would lead nowhere. <i>“Now, that’s not a bad thing, you clearly know who the best bet for this city is, but words are cheap, especially in politics, and actions say a great deal more.” </i>\n\nHe is waiting for your answer. Clearly, he sees your flirting as a chance to improve "+  pronhisher +" own political standing. You could promise to support "+  pronhisher +" house over others, but you must be wary, as giving this promise to too many other people could backfire. ";
			option0Name.text = "Promise support";
			option1Name.text = "End the meeting";
			confirmationControl = 3;
			NPCCharList.CharFollower [iAbbadon].charRelationship += 5;
			NPCCharList.CharFollower [iAbbadon].charLove += 5;
			return;
		}

		if (selector == 1 && confirmationControl == 2) {
			confirmationControl = 1; 
			confirmFun (1);

			return;
		}


		///////////////////////////// promise // end

		if (selector == 0 && confirmationControl == 3) {
			if (NPCCharList.CharFollower [iAlba].politicalPower >= 800) {
				Board.text = "You nod and tell him that he is right, words are not enough, and that you’d be honored to support such a noble House in its future endeavors. He coughs, covering "+  pronhisher +" mouth to hide "+  pronhisher +" broad smile, and proceeds to thank you after regaining "+  pronhisher +" composure. <i>“That’ll be lovely "+ GameControl.playerName +", I’m sure that both of us can benefit from this alliance. Although you still need to do a great deal to prove yourself, you have earned my interest, for now.”</i>";
				NPCCharList.CharFollower [iAbbadon].charRelationship -= 5;
				NPCCharList.CharFollower [iAbbadon].charLove -= 5;
				NPCCharList.CharFollower [iAbbadon].charLoyalty -= 10;
			} else {
				Board.text = "You nod and tell him that he is right, words are not enough, and that you’d be honored to support such a noble House in its future endeavors. He coughs, covering "+  pronhisher +" mouth to hide "+  pronhisher +" broad smile, and proceeds to thank you after regaining "+  pronhisher +" composure. <i>“That’ll be lovely "+ GameControl.playerName +", but I’ve heard that you promised the same thing to Alba. How can I even trust you if you just go around telling everyone what they want to hear? Come on, don’t be so stupid.”</i>";
				NPCCharList.CharFollower [iAbbadon].charRelationship += 10;
				NPCCharList.CharFollower [iAbbadon].charLove += 5;
				NPCCharList.CharFollower [iAbbadon].charLoyalty += 10;
			}
			GameControl.charGold += 200; 
			Board.text += "\n\nOnce you have finished discussing any relevant matters, you are ready to leave the place, and thank him for "+  pronhisher +" hospitality and time. <i>“Don’t worry, you may be an underdog in this city, but everyone deserves at least one chance.”</i>\n\nHe accompanies you to the door and you give him a short bow on your way out. You tell him that you’ll be back once you have completed your task. <i>“I’m eagerly awaiting your results, good luck "+ GameControl.playerName +".”</i>\n\nYou turn around, but before you can leave, Abbadon calls out to you. <i>“Wait! You might need some help to deal with them. As a token of our gratitude for your help, please take these. Just don’t waste them on anything stupid.”</i> He hands you a bag filled with 200 gold coins, and you thank him one last time before you turn and go.\n\nAs you leave, you walk past the Colosseum, and see several bands of drifters lingering around the area. They don't look particularly dangerous; at least no more than the beasts outside, but they are definitely creating a mess, and preventing any chance of resurrecting this commercial and touristic district. \n\nThe majority of them are just hanging around, trying to get by, but there is a small group that looks to be in charge of the rest. If what Abbadon said was correct, their leader probably is inside the Colosseum. You should get ready to face him later.  \n";

			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 3) {
			confirmationControl = 1; 
			confirmFun (1);
			return;
		}
			

		///////////////////////////// deal // fight

		if (selector == 0 && confirmationControl == 4) {
			Board.text = "You sit with the group and begin to discuss the situation, asking what you can do to help them. You find out that most of them were farmers, or people living in neighboring towns, who fled to the city when the plague started. This caused a drastic rise in population which, coupled with the lack of trade and tourism, resulted in the current crisis. At first, all of them lived in parks and the streets, but when businesses such as the Colosseum eventually shut down, they took the vacant lots for themselves. \n\nAlthough the size of the population has been adjusted slightly, due to some deciding to emigrate, and others being expelled or enslaved after transforming into beasts, there are still no jobs available in the district. \n\nIt is difficult to come up with a solution, but you believe that you can ask to Abbadon to hire them, providing them with food and refuge, until the economy recovers and he can afford to pay wages again. You can hear some of them protest, claiming that such a thing would be slavery, but the old man quiets them. He tells them that if the city doesn’t recover, they will never recover either, and that they wouldn’t be property of Abbadon, but would simply be paid with goods instead of gold. This could, of course, anger Abbadon, since he would be required to care for all these people, greatly increasing the already substantial burden of managing "+  pronhisher +" own business.\n\nYou also inform them that another alternative is to leave the Colosseum, and take over the parks and other abandoned buildings and streets. That way, at least, this place could be used once again for trade and commerce, greatly improving the economy of the city. They aren’t as eager for this option, but it would be less of a burden upon Abbadon. \n\nLastly, if you have enough gold (around 200 gold coins), you could probably build enough equipment and food to give them some jobs as public servants; repairing streets and buildings, and creating housing, among other jobs. They seem very eager to work for you, and Abbadon would definitely take notice of your generosity.\n";
			option0Name.text = "Send to Abbadon";
			option1Name.text = "Allocate in parks";
			option2Name.text = "Hire them";
			confirmationControl = 5; 
			if (GameControl.charGold >= 200) {
				option2Butt.interactable = true;
			}
			return;
		}

		if (selector == 1 && confirmationControl == 4) {
			Board.text = "You don’t have time for this madness. You unsheathe your weapon, and get ready to strike. Two men jump at you but you easily take them out. The big guy throws a powerful attack at you, but you easily dodge out of the way. A few steps away from the fray, the old man stands stoically, just waiting for the battle to end.\n\nBefore confronting the big guy, you turn and face the old man, knowing that with a single strike, you could finish him, and this nonsense along with it. The big guy cries out to you, begging you to stop, the crowd around you doing the same, none daring to stand and fight against you.\n\nThey all scream out to you, pleading with you to stop, promising to leave the area. You could finish this without any more bloodshed, or make a point that defiance will be met with lethal force. Should you strike down the old man, or just let them go?";
			option0Name.text = "Strike";
			option1Name.text = "Leave them";
			confirmationControl = 6; 
			GameControl.attAlignment -= 2;

			return;
		}


		///////////////////////////// send to abbadon / allocate / hire 

		if (selector == 0 && confirmationControl == 5) {
			Board.text = "You tell them that you’ll ensure that house Abbadon is responsible for them, in exchange for their service to the house. Although some are reluctant, most of them cheer and are grateful for your decision. The hard part will be convincing Abbadon to feel the same way.\n\nWhen you leave, most of the people stay around the Colosseum, though some of them follow you to Abbadon’s house against your wishes. When you arrive you can see that he is already angrily awaiting you. <i>“What is this, "+ GameControl.playerName +"? What are these people doing here? Sh... Just come inside for a moment, we need to talk!”</i> you ask the people to wait, and you follow the patrician into "+  pronhisher +" living room. \n\n<i>“Seriously "+ GameControl.playerName +" when I told you to get rid of them, I didn’t mean bringing them to my home! Are you crazy? Explain what is going on!”</i> You explain the situation to Abbadon, telling him of the offer that you made. He doesn’t seem to be very happy about any of it. <i>“You did what? And without even asking? I don’t know why I trusted you. Now what am I supposed to do?”</i> You tell him that he can use the situation to "+  pronhisher +" advantage, as he now has a lot of new workers under "+  pronhisher +" command, and that cost to him will be only the bare minimum.\n\n<i>“Fine, they’ll all riot if I refuse, so you leave me with no choice. But I’ll deduct the cost from the taxes I pay!”</i> You shrug, knowing that at least you’ve done something. With this new workforce at Abbadon’s disposal, the rebuilding of the city should happen a lot faster.\n\n<i>“I’ve had a feast prepared, and although I don’t feel like celebrating, to waste it would be a shame, so join me "+ GameControl.playerName +".”</i> You enjoy a celebratory feast, and once dinner is over, and you have had a chance to rest, Abbadon begins to talk once again about business. <i>“This was a good first step "+ GameControl.playerName +", but you are not done yet. I still need some more help in getting the whole place running smoothly again. Now that the drifters are sticking around, at the very least we will need to improve on security. To do that, you need to find a captain of the guard. Don’t worry, I’ll provide some funds for soldiers and equipment, but you need to find the talent. Since there are very few good warriors in the city, and most of them are either unavailable, or simply uninterested in the job, it will not be an easy task.”</i>\n\nWhen your conversation is finished, he hands you a bag containing 100 gold coins. You get ready to leave to your castle, having agreed to find a suitable candidate to take on the role of captain of the guard.  ";
			NPCCharList.CharFollower [iAbbadon].charRelationship += 5;
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 5;
			CityControl.city100Happiness += 5;
			CityControl.city100Order += 5;
			CityControl.city100Prosperity += 1.5f; 
			QuestControl.abbadonQuest = 2;
			Quest AbbadonQuest3 = new Quest ();
			QuestsController.RemoveID (1001);
			QuestsController.createQuest (AbbadonQuest3, "Hunting talent", "You need to find someone to patroll and protect the district, to keep order and peace.", 14, 1002);
			endTurnFun ();
			GameControl.charGold += 100; 
			GameControl.attAlignment += 1;
			return;
		}

		if (selector == 1 && confirmationControl == 5) {
			Board.text = "You tell them that for now, the best thing for them to do would be to move to the parks and streets again. Once the city’s commerce begins to thrive again, they’ll have jobs and opportunities, but for now they are just standing in the way of progress. The old man nods, and they all begin to pack their belongings, leaving with a silence marred only by the sobs and the coughs of the sick.\n\nMost of them settle in parks, streets and other public spaces. Some, however, take on the risk of leaving the city, where they will likely end up as unfortunate additions to the monsters’ ranks. \n\nOnce you return to Abbadon, and inform him of the news, he seems very happy.<i>“A servant told me that you took care of the drifters, and without a single drop of blood spilled.”</i> He sounds happy about the last part; pleased that you were able to get things done without any unnecessary escalation. <i>“I am glad that I left the issue to your judgment, you did well. It’ll take weeks to get the area ready again, but at least this first matter is settled. That being said, you still have some tasks to complete. For now, though, please join me, my servants are about to serve dinner.</i>\n\nInside, the two of you enjoy a celebratory feast. Once dinner is over, and you have had a chance to rest, Abbadon begins to talks once again about business. <i>“This was a good first step "+ GameControl.playerName +", but you are not done yet. I still need some more help in getting the whole place running smoothly again. Now that the drifters are gone, we’ll need ensure that they won’t come back. For that, you’ll need to find a captain of the guard. Don’t worry, I’ll provide some funds for soldiers and equipment, but you’ll need to find the talent. Since there are very few good warriors in the city, and most of them are either unavailable, or simply uninterested in the job, it will not be an easy task.”</i>\n\nWhen your conversation is finished, he hands you a bag containing 100 gold coins. You get ready to leave to your castle, having agreed to find a suitable candidate to take on the role of captain of the guard. \n\n";
			NPCCharList.CharFollower [iAbbadon].charRelationship += 10;
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 10;
			CityControl.city100Happiness -= 5;
			CityControl.city100Order -= 5;
			CityControl.city100Prosperity += 3f; 
			QuestControl.abbadonQuest = 2;
			Quest AbbadonQuest3 = new Quest ();
			QuestsController.RemoveID (1001);
			QuestsController.createQuest (AbbadonQuest3, "Hunting talent", "You need to find someone to patroll and protect the district, to keep order and peace.", 14, 1002);
			endTurnFun ();
			GameControl.charGold += 100; 
			GameControl.attAlignment -= 1;
			return;
		}


		if (selector == 2 && confirmationControl == 5) {
			Board.text = "You tell them that you’ll take of them, providing them with accommodation, and enough gold to get them back into working condition. Although this will harm your finances for now, it could greatly boost them in the long-term. The old man nods, and they all begin to pack their belongings, cheerful to be finally leaving this place.\n\nMost of them settle in parks, streets and other public spaces. Some, however, take on the risk of leaving the city, where they will likely end up as unfortunate additions to the monsters’ ranks. \n\nOnce you return to Abbadon, and inform him of the news, he seems very happy.<i>“A servant told me that you took care of the drifters, and that you have agreed to personally care for them. I must admit that I’m impressed with how you handled things.”</i> He sounds delighted that you were able to get things done without any unnecessary escalation. <i>“I am glad that I left the issue to your judgment, you did well. It’ll take weeks to get the area ready again, but at least this first matter is settled. That being said, you still have some tasks to complete. For now, though, please join me. My servants are about to serve dinner.</i>\n\nInside, the two of you enjoy a celebratory feast. Once dinner is over, and you have had a chance to rest, Abbadon talks once again about business. <i>“This was a good first step "+ GameControl.playerName +", but you are not done yet. I still need some more help in getting the whole place running smoothly. Although the drifters have left the Colosseum, and have jobs, the streets still need to be safer. For that, you’ll need to find a captain of the guard. Don’t worry, I’ll provide some funds for soldiers and equipment, but you’ll need to find the talent. Since there are very few good warriors in the city, and most of them are either unavailable or simply uninterested in the job, it will not be an easy task.”</i>\n\nWhen your conversation is finished, he hands you a bag containing 100 gold coins. You get ready to leave to your castle, having agreed to find a suitable candidate to take on the role of captain of the guard. \n\n";
			NPCCharList.CharFollower [iAbbadon].charRelationship += 10;
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 10;
			CityControl.city100Happiness += 10;
			CityControl.city100Order += 5;
			CityControl.city100Prosperity += 1.5f; 
			QuestControl.abbadonQuest = 2;
			Quest AbbadonQuest3 = new Quest ();
			QuestsController.RemoveID (1001);
			QuestsController.createQuest (AbbadonQuest3, "Hunting talent", "You need to find someone to patroll and protect the district, to keep order and peace.", 14, 1002);
			GameControl.charGold -= 200;
			GameControl.charGold += 100; 
			GameControl.attAlignment += 3;
			endTurnFun ();
			return;
		}


		///////////////////////////// strike / leave

		if (selector == 0 && confirmationControl == 6) {
			Board.text = "Without hesitation, you deliver a fatal blow. The old man collapses, falling inelegantly to the ground, and you turn to face the crowd. Your bloody weapon still in hand, you tell them that this type of behavior will not be tolerated in the future, and that they will abide by the law and follow your word, lest they let the same fate befall the rest of them. The silence of the place is interrupted only by sobs, and the desperate coughs of the sick.\n\nYou raise your voice and tell them to leave, immediately. Demoralized and browbeaten, the crowd slowly turns around, and walks pitifully through the exit. \n\nWhere they would go is a mystery at first, but later that day you find that most of them have settled in parks, streets and other public spaces. Some have even taken the risk to leave the city, where they will likely end up as unfortunate additions to the monsters’ ranks. \n\nOnce you return to Abbadon, and inform him of the news, he seems mostly happy.<i>“A servant told me that you took care of the drifters, although you spilled unnecessary blood.”</i> He seems slightly unsettled by the last part, but just shrugs in acceptance. <i>“Well, I left it your judgment, and seeing as you still completed the job, I won’t complain. It’ll take weeks to get the area ready again, but at least this first matter is settled. That being said, you still have some tasks to complete. For now, though, please join me. My servants are about to serve dinner.</i>\n\nInside, the two of you enjoy a celebratory feast. Once dinner is over, and you have had a chance to rest, Abbadon talks once again about business. <i>“This was a good first step "+ GameControl.playerName +", but you are not done yet. I still need some more help in getting the whole place running smoothly again. Now that the drifters are gone, we’ll need to ensure that they won’t come back. For that, you’ll need to find a captain of the guard. Don’t worry, I’ll provide some funds for soldiers and equipment, but you need to find the talent. Since there are very few good warriors in the city, and most of them are either unavailable, or simply uninterested in this job, it will not be an easy task.”</i>\n\nWhen your conversation is finished, he hands you a bag containing 100 gold coins. You get ready to leave to your castle, having agreed to find a suitable candidate to take on the role of captain of the guard.";
			NPCCharList.CharFollower [iAbbadon].charRelationship += 5;
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 5;
			CityControl.city100Happiness -= 15;
			CityControl.city100Order += 5;
			CityControl.city100Prosperity += 3f; 
			QuestControl.abbadonQuest = 2;
			Quest AbbadonQuest3 = new Quest ();
			QuestsController.RemoveID (1001);
			QuestsController.createQuest (AbbadonQuest3, "Hunting talent", "You need to find someone to patroll and protect the district, to keep order and peace.", 14, 1002);
			GameControl.charGold += 100; 
			GameControl.attAlignment -= 2;
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 6) {
			Board.text = "You are ready to deliver the strike but hesitate at the last moment. You can see how the old man slowly opens "+  pronhisher +" eyes, and you tell him to just take "+  pronhisher +" people and go. He nods, and everyone else start to pack their belongings, leaving in a silence only interrupted by sobs and the coughs of the sick.\n\nWhere they would go is a mystery at first, but later that day you find that most of them have settled in parks, streets and other public spaces. Some have even taken the risk to leave the city, where they will likely end up as unfortunate additions to the monsters’ ranks. \n\nOnce you return to Abbadon, and inform him of the news, he seems very happy.<i>“A servant told me that you took care of the drifters, and without a single drop of blood spilled.”</i> He sounds happy about the last part; pleased that you were able to get things done without any unnecessary escalation. <i>“I am glad that I left the issue to your judgment, you did well. It’ll take weeks to get the area ready again, but at least this first matter is settled. That being said, you still have some tasks to complete. For now, though, please join me, my servants are about to serve dinner.</i>\n\nInside, the two of you enjoy a celebratory feast. Once dinner is over, and you have had a chance to rest, Abbadon begins to talks once again about business. <i>“This was a good first step "+ GameControl.playerName +", but you are not done yet. I still need some more help in getting the whole place running smoothly again. Now that the drifters are gone, we’ll need ensure that they won’t come back. For that, you’ll need to find a captain of the guard. Don’t worry, I’ll provide some funds for soldiers and equipment, but you’ll need to find the talent. Since there are very few good warriors in the city, and most of them are either unavailable, or simply uninterested in the job, it will not be an easy task.”</i>\n\nWhen your conversation is finished, he hands you a bag containing 100 gold coins. You get ready to leave to your castle, having agreed to find a suitable candidate to take on the role of captain of the guard. \n";
			NPCCharList.CharFollower [iAbbadon].charRelationship += 10;
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 10;
			CityControl.city100Happiness -= 10;
			CityControl.city100Order -= 5;
			CityControl.city100Prosperity += 3f; 
			QuestControl.abbadonQuest = 2;
			Quest AbbadonQuest3 = new Quest ();
			QuestsController.RemoveID (1001);
			QuestsController.createQuest (AbbadonQuest3, "Hunting talent", "You need to find someone to patroll and protect the district, to keep order and peace.", 14, 1002);
			GameControl.charGold += 100; 
			endTurnFun ();
			return;
		}


		///////////////////////////// Amazon // gladiator

		if (selector == 0 && confirmationControl == 7) {
			Board.text = "After a moment of deliberation, you decree the amazon to be the winner of the duel. As the crowd cheers and gathers around her, you can hear the gladiator mumbling something before leaving the scene. When the crowd eventually begins to disperse, you get closer to the woman, congratulating her. \n\n<i>“Gracias a ti por tu buen juicio! Fue un combate duro, pero al final yo gane.”</i> you look at her confused, not sure of what she just said, and she bursts into laughter. <i>“Sorry, I am exhausted from the battle. I come from foreign lands and for a moment there, I forgot that I wasn’t at home. I hope I don’t have a concussion...”</i> she jokingly taps her head a couple of times. <i>“What I meant to say is, thank you for your good judgment. It was obvious that I won the battle.”</i> She isn’t humble, but at least knows how to fight.\n\nYou ask her if she would be willing to accompany you, and talk about business. <i>“Business uh? Sure, I’ll go with you, but wouldn’t you like blow off some steam first?”</i> she walks towards you, exposing one of her breasts, offering herself to you. <i>“You know, when I battle I am always in control, but in other matters I like to be led, if you get what I mean...”</i> \n\nWould you like to go to the closest inn and have some fun with her, or just get on with business? \n\n";
			option0Name.text = "Have fun";
			option1Name.text = "Business";
			confirmationControl = 8; 
			npcCreator.charCreator (0, 0, 0, 12, 1, 3, 2, 80, 1000, 0, 0, false);
			WorldControl.NPCID = NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charID;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].isRecruited = false; 
			return;
		}

		if (selector == 1 && confirmationControl == 7) {
			npcCreator.charCreator (1, 0, 0, 12, 0, 3, 1, 80, 1000, 0, 0, false);
			WorldControl.NPCID = NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charID;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].isRecruited = false; 

			if (QuestControl.abbadonHelp) {
				Board.text = "After a moment of deliberation, you claim the gladiator as the winner of the duel, and the crowd cheers and moves around him. You can hear the amazon mumbling something before leaving the scene. When the crowd starts to disperse, you get closer to the man, congratulating him and inviting him to discuss some matters with you, to what he reluctantly agrees. \n\nOnce at your place the gladiator has kicked back on a chair, "+  pronhisher +" sandaled feet up on a nearby desk as you go through the details of what you have in mind for "+  pronhisher +" forthcoming employment. He’d taken off "+  pronhisher +" heavy steel helmet at some point, revealing a brutish, tanned face surprisingly devoid of scars.\n\nHe seems content to remain silent as you speak, occasionally nodding and giving monosyllabic replies when appropriate. You begin to wonder if he actually understands what you’re saying, but thankfully he clears "+  pronhisher +" throat as you’re approaching the topic of "+  pronhisher +" payment.\n\n<i>“Yeah, I was gonna say-”</i> he begins, only for the sound of the door opening behind you to interrupt him. You turn, furious at this unscheduled disruption, and glare at Helena, the maid, as she pokes her head through the doorway.\n\nShe blanches at the attention, clearly not expecting to encounter anyone, but steps through and curtsies nervously.\n\n<i>“Beg pardon my Liege, I didn’t think there was anyone in here. I’ll be going no-”</i>\n\n<i>“Wait,”</i> says the gladiator, causing you to look round. His eyes are fixed on your maid, running up and down her lithe, skinny body. <i>“I want her.”</i>\n\n<i>“Excuse me?”</i>\n\n<i>“For my payment. I want her to… serve me. Doesn’t even have to be for that long, I know she has a job here. A week would do.”</i>\n\nYou immediately refuse to "+  pronhisher +" offer, for Helena’s relief, and you dismiss her from the room. The gladiator’s blood boils for a moment, but calms down knowing that even himself cant’ get away from your entire guard. \n\n<i>“Have it your way. But you’re going to offer me something juicy then. I want a nobility title, so I can start my own House.”</i> You consider your options, and after an hour of negotiation he finally settles for either the titles, or 100 gold coins.<i>“I want an answer now, I don't have time to waste here anymore with an indecisive leader.”</i> \n\n";
				option0Name.text = "Title";
				option1Name.text = "Pay 100 gold";
				if (GameControl.charGold < 100) {
					option1Butt.interactable = false;
				}
				confirmationControl = 10;
			} else {
				Board.text = "After a moment of deliberation, you claim the gladiator as the winner of the duel, and the crowd cheers and moves around him. You can hear the amazon mumbling something before leaving the scene. When the crowd starts to disperse, you get closer to the man, congratulating him and inviting him to discuss some matters with you, to what he reluctantly agrees. \n\nOnce at your place the gladiator has kicked back on a chair, "+  pronhisher +" sandaled feet up on a nearby desk as you go through the details of what you have in mind for "+  pronhisher +" forthcoming employment. He’d taken off "+  pronhisher +" heavy steel helmet at some point, revealing a brutish, tanned face surprisingly devoid of scars.\n\nHe seems content to remain silent as you speak, occasionally nodding and giving monosyllabic replies when appropriate. You begin to wonder if he actually understands what you’re saying, but thankfully he clears "+  pronhisher +" throat as you’re approaching the topic of "+  pronhisher +" payment.\n\n<i>“Yeah, I was gonna say-”</i> he begins, only for the sound of the door opening behind you to interrupt him. You turn, furious at this unscheduled disruption, and glare at Helena, the maid, as she pokes her head through the doorway.\n\nShe blanches at the attention, clearly not expecting to encounter anyone, but steps through and curtsies nervously.\n\n<i>“Beg pardon my Liege, I didn’t think there was anyone in here. I’ll be going no-”</i>\n\n<i>“Wait,”</i> says the gladiator, causing you to look round. His eyes are fixed on your maid, running up and down her lithe, skinny body. <i>“I want her.”</i>\n\n<i>“Excuse me?”</i>\n\n<i>“For my payment. I want her to… serve me. Doesn’t even have to be for that long, I know she has a job here. A week would do.”</i>\n\nYou wonder for a moment, should you lend her Helena for a week, or refuse and offer him money? \n";
				option1Name.text = "Pay 50 Gold";
				option0Name.text = "Lend Helena";
				if (GameControl.charGold < 50) {
					option1Butt.interactable = false;
				}
				confirmationControl = 11; 
			}

			return;
		}


		///////////////////////////// Have fun / business

		if (selector == 0 && confirmationControl == 8) {
			string line1, line2, line3;
			if (GameControl.dick1Size > 0) {
				line1 = "By now your cock is straining at the front of your underclothes hard enough that you’re surprised it hasn’t ripped its way through entirely. As the amazon pulls your trousers down, it springs out, smacking her in the face.\n\nFor a moment she’s stunned, then chuckles warmly.\n\n<i> “Steady there. A woman might think you are disappointed by her.” </i>\n\nShe presses a lingering kiss onto the head, making your hips twitch involuntarily, then moves up to unbutton your shirt as you shuck off your outer coat.\n\n";
				line3 = " <i>”Turn around,”</i> you order.\n\nSmiling to herself, the amazon goes down onto all fours, turning away from you and pushing her firm backside into the air. You reach forwards and tug away her breechcloth entirely, exposing the dark-furred lips of her pussy. Between them, you glimpse a flash of glistening pink flesh.\n\nYour hands go to her hips, fingers digging into the squishy mixture of fat and muscle barding her pelvis, and you pull her in close. The head of your penis bumps against her pussy, sending a jolt through both of your overheated bodies and leaving a smear of juice on the fat head.\n\nYou release one of your hands from her hips to guide yourself in the last inch, a convulsive shudder passing through you as you sink into her gloriously wet warmth. Such is her hunger for you that her vagina almost seems to suck you in, the muscular walls clenching around your shaft as you slide inside her.\n\nThe amazon lets out a low moan, leaning on her elbows as her head droops down, her hair covering her face. You seize her hips and begin to thrust, feeling her slippery flesh clinging to your length as you pull out, then stretching around you as you push back in.\n\nEvidently the amazon’s mastery of her body extends even to her most intimate place, as you soon feel her muscles beginning to contract and release around your cock, squeezing it so hard you’re concerned you might lose it. Muffled groans and whispers of encouragement escape from behind the amazon’s curtain of hair, fresh sweat breaking out across her dark skin.\n\nYour hand goes between her legs, pulling and pinching at her swollen clit until she moans out loud, trembling in orgasm as you pound into her. Her walls close on you, gripping you tight enough that you can’t move, moulding into every last crevice on your dick.\n\nMuscles clench, your balls tightening, and you spurt into her, plastering her insides with your hot seed. You slump on top of the amazon as she lies down on her side, a slightly unfocused expression on her face.\n\nIt takes a while before the amazon is able to unclench her muscles enough that you can slip out of her, pearly-white cum oozing out from her swollen lower lips.\n\n<i>“Mmm,” </i> the amazon croons, looking back towards you.\n\n<i>”I can’t even remember how long it’s been since someone stood up to a pussy-milking like that. Consider me impressed.”</i>\n\n";
			} else {
				line1 = "You see a tremble go through her as the scent of your hungry cunt reaches her nostrils. The throbbing between your thighs is great enough that you’re surprised you’re not soaking through your underthings yet.\n\nGrinning, the amazon begins pulling the tiny scrap of cloth down your legs, leaving it to tangle around your knees as she presses a delicate kiss against your mound, before moving up to help unbutton your shirt as you cast off your outer coat.\n\n";
				line3 = " <i>”Turn around,”</i> you order.\n\nSmiling to herself, the amazon goes down onto all fours, turning away from you and pushing her firm backside into the air. You reach forwards and tug away her breechcloth entirely, exposing the dark-furred lips of her pussy. Between them, you glimpse a flash of glistening pink flesh.\n\nYour hands go to her hips, fingers digging into the squishy mixture of fat and muscle barding her pelvis, and you pull her in close. Your nose bumps against her pussy, her strong aroma filling your nostrils, sending a jolt through both of your overheated bodies and leaving a smear of juice on the your face.\n\nYou release one of your hands from her hips so it can find refuge in your muff, a convulsive shudder passing through you as you sink into your own wet warmth. Such is her hunger for you that her vagina presses with intensity against you, asphyxiating you for a moment before she allows you to breath again.\n\nThe amazon lets out a low moan, leaning on her elbows as her head droops down, her hair covering her face. You seize her hips and begin to thrust your tongue, feeling her slippery flesh clinging to its length as you pull out, then stretching around you as you push back in.\n\nEvidently the amazon’s mastery of her body extends even to her most intimate place, as you soon feel her muscles beginning to contract and release, begging for more. Muffled groans and whispers of encouragement escape from behind the amazon’s curtain of hair, fresh sweat breaking out across her dark skin.\n\nYour hand goes between her legs, pulling and pinching at her swollen clit until she moans out loud, trembling in orgasm as you pound your other hand into her. Her walls close on you, gripping you tight enough that you can’t move, moulding into every last crevice on your arm.\n\nMuscles clench, her walls tightening, and in moments you bath in her warm fluids, proof of her ecstasy. You slump on top of the amazon as she lies down on her side, a slightly unfocused expression on her face.\n\nIt takes a while before the amazon is able to unclench her muscles enough that you can slip out of her, clear liquid still oozing out from her swollen lower lips.\n\n<i>“Mmm,” </i> the amazon croons, looking back towards you.\n\n<i>”I can’t even remember how long it’s been since someone had handled me like that. Consider me impressed.”</i>\n\n";
			}
			if (GameControl.breast1Size > 5) {
				line2 = "The amazon pulls your shirt open, nuzzling into your firm breasts. You sigh and lean back, relaxing in the wonderful sensations of her kissing the soft skin on the underneath of each one.\n\nHelping you work the shirt down your arms so you can drop it onto the bed, the amazon latches onto your nipples, biting gently at the tiny nubs with her front teeth, teasing them with the tip of her tongue as she coaxes them into full hardness. Soon each one is glistening with saliva, poking out as though seeking to thrust themselves deeper into her warm, inviting mouth.\n\nAt some point your hands have come to rest on her collarbones, feeling the rock-hard muscle there shifting as she moves. Abruptly you firm your grip and push her away. Enough playing.\n\n";
			} else {
				line2 = "The amazon pulls your shirt open, sighing as she gazes on the smooth, sculpted planes of your chest and abdomen. She leans in as you drop the shirt behind you, leaving a firm kiss on your sternum, right over your heart, before moving to the side. A small smirk creases her cheeks as she nips at one of your nipples with her front teeth, gently teasing the point with her front teeth.\n\nAt some point your hands have come to rest on her collarbones, feeling the rock-hard muscle there shifting as she moves. Abruptly you firm your grip and push her away. Enough playing.\n\n";
			}

			Board.text = "It is a struggle to watch the Amazon pick up her armour and re-clothe herself, and not to simply take her then and there in the street. Somehow you manage to control yourself, leading her to a nearby inn.\n\nThe owner catches sight of you and quickly hands over the key to "+  pronhisher +" largest room, thanking you profusely for your patronage as you lead the amazon up the stairs. You lock the door behind you and turn to face her as she sits on the bed. The smirk is back on her full lips, and she strokes a hand idly through her glossy mane of hair.\n\n<i>“So,”</i> she croons. <i>“Where were we?”</i>\nYou surge forwards, seizing her wrists as you crush your lips against hers. The amazon sighs into your mouth, eyelids fluttering as you push her back and down, onto the bed. Her lips taste of sweat, under which hides a zesty, citrusy flavour that makes your mouth tingle.\n\nYou straddle her, her thick waist warm against your thighs as you lean back, pulling her cuirass open to expose her breasts a second time. The amazon’s shirt is dark with cooling sweat from her fight, and you barely even feel the need to bother pulling it open completely.\n\nHer breasts rise and fall on the amazon’s heaving chest, perfect despite the faint scars that criss-cross them, the only reminders of old wounds. Each is full, yet pert, enough to fill your hands as you cup them, tweaking the dark nipples with your thumbs.\n\nShe moans and squirms at your ministrations, hands still lying where you left them, making absolutely no move to attend to herself. Evidently she was serious about preferring to be lead.\n\nYou lean in, lapping up the sweat drying on her collarbones and working your way up, following the pulse you can feel pounding in her neck. At the same time, you tug and pinch at her nipples, reasoning that there’s little you can do to hurt her with just your hands.\n\nThe amazon grinds her body against yours, the feeling of her muscles flexing and contracting beneath their coating of fat making you shudder.\n\nSatisfied that she is ready, you lean back, pulling away her “skirt” of segmented leather strips and reaching under the hem of her shirt. Beneath that is nothing more than a breechcloth held up by a leather tie, and you can feel the wet heat of her waiting cunt beneath it. You palm it, grinding your hand against her covered mound until the amazon thrashes and pants beneath you, tossing her head from side to side.\n\nYou worm a finger under the front of the fabric and pull it away, exposing her to you. Her vagina glistens in the light coming through the window, the outer lips swollen and throbbing. You look back to the amazon, she looks at you with such need as you be almost painful.\n\n<i>“Undress me,”</i> you order, leaning back so that you’re kneeling on the bed, looking down at the supine amazon. She smiles in response, her teeth a flash of white against her dark cheeks, squirming around and crawling towards you. Her breasts hang beneath her as she makes her way towards you, bare bottom swaying from side to side as she moves in.\n\nCarefully she rears back and takes the front tie of your breeches in her teeth. Her dark eyes are on you as she pulls back, watching your expression as she undoes the front of your pants.\n\n";
			Board.text += line1 + line2 + line3;
			Board.text += "She props her head up with an arm.\n\n<i>“So, what did you want to talk to me about?”</i>\n\nAfter a moment of rest, you invite her to eat at the closest restaurant. She makes sure to order a much food and drinks as she can. <i>“I’m going need a whole feast after what you did to me.”</i> You smile and let her ask for anything she wants, waiting until she had eaten.\n\n<i>“So... Quieres... You want me to work for you? As captain of the guards?”</i> she gulps another beer before continuing. <i>“Look, I would usually say not for a silly job like that... But I already visited the whole island, it might be a good time to settle, and with you around I’m sure I’ll got all my needs covered...”</i> Although she has drink a lot, she is almost immune to alcohol. <i>“I tell you what, give me a fancy title, a good place to live, and I’ll make sure to make any sissy you send me into a man... And soldiers too, what do you say?”</i> You are hesitant about giving her a title, even if its a small one. You could offer her some properties and some gold, 50 gold coins should be more than enough to convince her to join you.\n";
			option0Name.text = "Titles";
			option1Name.text = "Gold (50)";
			if (GameControl.charGold < 50) {
				option1Butt.interactable = false; 
			}
			confirmationControl = 9;
			return;
		}

		if (selector == 1 && confirmationControl == 8) {
			Board.text = "You invite her to eat at the closest restaurant. She makes sure to order as much food and drink as she can. <i>“Oh yes, I’m going to ask for a whole feast.”</i> You smile and let her order as much as she pleases, waiting until she’s eaten and is half drunk.\n\n<i>“So... Quieres... You want me to work for you? As captain of the guard?”</i> she gulps down another beer before continuing. <i>“Look, I would usually say no to a silly job like that... But I’ve already visited the entire island, so it might be a good time to settle. Not to mention that with you around, I’m sure I’ll get all my needs covered...”</i> Although she has a lot to drink, she seems almost immune to the effects of alcohol. <i>“I’ll tell you what, give me a fancy title, a nice place to live, and I’ll be sure to turn all of the sissies you send me into men... and soldiers too. What do you say?”</i> You are hesitant about giving her any kind of title, even if it's a small one. You could offer her some properties and some gold, 50 gold coins should be more than enough to convince her to join you.\n";
			option0Name.text = "Titles";
			option1Name.text = "Gold (50)";
			if (GameControl.charGold < 50) {
				option1Butt.interactable = false; 
			}
			confirmationControl = 9;

			return;
		}

		///////////////////////////// Titles / Gold to the amazon

		if (selector == 0 && confirmationControl == 9) {
			Board.text = "You agree to her demands, promising to give her a title and all that comes with it. <i>“You won’t regret this... my liege. As soon as I establish myself in this town, I’ll begin with the training. The streets will be safe with me and my new team to patrol them.”</i> After another long hour of eating and drinking, she follows you to Abbadon, where you sign the papers required to make everything official.\n\nWhen the bureaucracy is done, a servant takes the woman to her new house, while Abbadon asks you to stay and talk. \n\n<i>“A foreigner as captain of the guard? What’s done is done, but are you sure this is a good idea? She could very well be a fine warrior, I don’t deny that, but her behavior and culture might contrast with ours a bit much. Just... pay attention to her, and make sure she doesn’t screw up.”</i> You assure Abbadon that everything will be fine, and that you’ll watch over her personally. \n\n<i>“Well of course you will, that is your job.”</i> Abbadon rubs "+  pronhisher +" temples for a moment, but after a deep sigh he seems to relax. <i>“Whatever. The streets will be safe, and that’s what really matters. I’ll invest in some shops and businesses around my district, so you can expect this zone to be a lot more crowded and productive again. I am sure that, thanks to several years of boredom, the other houses will happily pour their accumulated gold into our district. Speaking of which, I’ll have to talk to you about what our initial focus will be. We’ll have to choose between sports or the classic arts, since I don’t think it’s a good idea to open all of our buildings just yet. For now I need to rest, as I have an incredible headache, but you can come back later to take care of this issue. For now, begone.”</i>\n\nSports or the arts, that’s gonna be an interesting choice. ";

			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].isRecruited = true;

			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].cityJobs = NPCData.Jobs.CastleCaptain;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].attHappiness = 100;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charLoyalty = 80;

			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charRank = NPCData.CharRank.S;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].coreSkillMartial = 100;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].attPhysical = Random.Range (80, 100);

			fileRulesNPC npcrules = new fileRulesNPC();
			RulesNPC.savedRules.Add (npcrules);
			RulesNPC.savedRules [RulesNPC.savedRules.Count-1].id = NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charID; 
			RulesNPC.savedRules [RulesNPC.savedRules.Count-1].idx = NPCCharList.CharRetainers.Count - 1;
			Board.text += "\n\nYou can now access the barracks!";


			NPCCharList.CharRetainers[NPCCharList.CharRetainers.Count-1].charTitles.Add(new Gentlewoman());
			QuestControl.abbadonQuest = 3; 
			Quest AbbadonQuest4 = new Quest ();
			QuestsController.RemoveID (1002);
			QuestsController.createQuest (AbbadonQuest4, "A new dawn", "With the district under control, it's time to rebuild and make it stronger than before.", 14, 1003);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 9) {
			Board.text = "You inform her that while you can’t give her a title, you can provide her with 50 gold coins. <i>“Well, if you throw in a good place for me to stay, then it’s a deal. Don’t worry, you won’t regret it... my liege. As soon as I establish myself in this town, I’ll begin with the training. The streets will be safe with me and my new team patrolling them.”</i> After another long hour of eating and drinking, she follows you to Abbadon, where you sign the papers required to make everything official.\n\nWhen the bureaucracy is done, a servant takes the woman to her new house, while Abbadon asks you to stay and talk. \n\n<i>“A foreigner as captain of the guard? What’s done is done, but are you sure this is a good idea? She could very well be a fine warrior, I don’t deny that, but her behavior and culture might contrast with ours a bit much. Just... pay attention to her, and make sure she doesn’t screw up.”</i> You assure Abbadon that everything will be fine, and that you’ll watch over her personally. \n\n<i>“Well of course you will, that is your job.”</i> Abbadon rubs "+  pronhisher +" temples for a moment, but after a deep sigh he seems to relax. <i>“Whatever. The streets will be safe, and that’s what really matters. I’ll invest in some shops and businesses around my district, so you can expect this zone to be a lot more crowded and productive again. I am sure that, thanks to several years of boredom, the other houses will happily pour their accumulated gold into our district. Speaking of which, I’ll have to talk to you about what our initial focus will be. We’ll have to choose between sports or the classic arts, since I don’t think it’s a good idea to open all of our buildings just yet. For now I need to rest, as I have an incredible headache, but you can come back later to take care of this issue. For now, begone.”</i>\n\nSports or the arts, that’s gonna be an interesting choice. ";
			GameControl.charGold -= 50; 
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].isRecruited = true; 

			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].cityJobs = NPCData.Jobs.CastleCaptain;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].attHappiness = 100;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charLoyalty = 80;

			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charRank = NPCData.CharRank.S;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].coreSkillMartial = 100;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].attPhysical = Random.Range (80, 100);

			fileRulesNPC npcrules = new fileRulesNPC();
			RulesNPC.savedRules.Add (npcrules);
			RulesNPC.savedRules [RulesNPC.savedRules.Count-1].id = NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charID; 
			RulesNPC.savedRules [RulesNPC.savedRules.Count-1].idx = NPCCharList.CharRetainers.Count - 1;
			Board.text += "\n\nYou can now access the barracks!";


			QuestControl.abbadonQuest = 3; 
			Quest AbbadonQuest4 = new Quest ();
			QuestsController.RemoveID (1002);
			QuestsController.createQuest (AbbadonQuest4, "A new dawn", "With the district under control, it's time to rebuild and make it stronger than before.", 14, 1003);
			endTurnFun ();
			return;
		}

		///////////////////////////// Titles / gold gladiator

		if (selector == 0 && confirmationControl == 10) {
			Board.text = "At the end you give up and agree to give him the title of Gentleman, and all that it entails, including a small plot of land, and a house. <i>“You were smart today, and you won’t regret having me to train your sissy recruits into real soldiers. you can be sure of that.”</i>\n\nYou fetch your ink and quill and, once the official documents are signed, a servant escorts the man to "+  pronhisher +" new property. A few days later, you receive a message from Abbadon, requesting that you visit him. \n\n<i>“A gladiator as captain of the guard? What’s done is done, but are you sure that this is a good idea? I suppose that at least the people here will respect him though. Just be sure that he respects you.”</i> You assure Abbadon that everything will be fine, and that you’ll take care of it personally.\n\n<i>“Well of course you will, that is your job.”</i> Abbadon rubs "+  pronhisher +" temples for a moment, but after a deep sigh he seems to relax. <i>“Whatever. The streets are gonna be safe, and that’s what really matters. I’ll invest in some shops and businesses around my district, so you can expect this zone to be a lot more crowded and productive again. I am sure that, thanks to several years of boredom, the other houses will happily pour their accumulated gold into our district. Speaking of which, I’ll have to talk to you about what our initial focus will be. We’ll have to choose between sports or the classic arts, since I don’t think it’s a good idea to open all of our buildings just yet. For now I need to rest, as I have an incredible headache, but you can come back later to take care of this issue. For now, begone.”</i>\n";

			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].isRecruited = true; 

			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].cityJobs = NPCData.Jobs.CastleCaptain;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].attHappiness = 100;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charLoyalty = 80;

			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charRank = NPCData.CharRank.S;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].coreSkillMartial = 100;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].attPhysical = Random.Range (80, 100);

			fileRulesNPC npcrules = new fileRulesNPC();
			RulesNPC.savedRules.Add (npcrules);
			RulesNPC.savedRules [RulesNPC.savedRules.Count-1].id = NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charID; 
			RulesNPC.savedRules [RulesNPC.savedRules.Count-1].idx = NPCCharList.CharRetainers.Count - 1;
			Board.text += "\n\nYou can now access the barracks!";


			NPCCharList.CharRetainers[NPCCharList.CharRetainers.Count-1].charTitles.Add(new Gentleman());
			QuestControl.abbadonQuest = 3; 
			Quest AbbadonQuest4 = new Quest ();
			QuestsController.RemoveID (1002);
			QuestsController.createQuest (AbbadonQuest4, "A new dawn", "With the district under control, it's time to rebuild and make it stronger than before.", 14, 1003);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 10) {
			Board.text = "In the end, you decide to pay him with gold. <i>“It’s not really what I wanted, but I can’t complain. That money, alongside my salary, will give me a pretty luxurious life. You won’t regret having me to train your sissy recruits into real soldiers, you can be sure of that.”</i>\n\nYou fetch your ink and quill and, once the official documents are signed, a servant escorts the man to "+  pronhisher +" new property. A few days later, you receive a message from Abbadon, requesting that you visit him. \n\n<i>“A gladiator as captain of the guard? What’s done is done, but are you sure that this is a good idea? I suppose that at least the people here will respect him though. Just be sure that he respects you.”</i> You assure Abbadon that everything will be fine, and that you’ll take care of it personally.\n\n<i>“Well of course you will, that is your job.”</i> Abbadon rubs "+  pronhisher +" temples for a moment, but after a deep sigh he seems to relax. <i>“Whatever. The streets are gonna be safe, and that’s what really matters. I’ll invest in some shops and businesses around my district, so you can expect this zone to be a lot more crowded and productive again. I am sure that, thanks to several years of boredom, the other houses will happily pour their accumulated gold into our district. Speaking of which, I’ll have to talk to you about what our initial focus will be. We’ll have to choose between sports or the classic arts, since I don’t think it’s a good idea to open all of our buildings just yet. For now I need to rest, as I have an incredible headache, but you can come back later to take care of this issue. For now, begone.”</i>\n";
			GameControl.charGold -= 100;

			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].isRecruited = true; 

			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].cityJobs = NPCData.Jobs.CastleCaptain;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].attHappiness = 100;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charLoyalty = 80;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charRank = NPCData.CharRank.S;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].coreSkillMartial = 100;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].attPhysical = Random.Range (80, 100);

			fileRulesNPC npcrules = new fileRulesNPC();
			RulesNPC.savedRules.Add (npcrules);
			RulesNPC.savedRules [RulesNPC.savedRules.Count-1].id = NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charID; 
			RulesNPC.savedRules [RulesNPC.savedRules.Count-1].idx = NPCCharList.CharRetainers.Count - 1;
			Board.text += "\n\nYou can now access the barracks!";


			QuestControl.abbadonQuest = 3; 
			Quest AbbadonQuest4 = new Quest ();
			QuestsController.RemoveID (1002);
			QuestsController.createQuest (AbbadonQuest4, "A new dawn", "With the district under control, it's time to rebuild and make it stronger than before.", 14, 1003);
			endTurnFun ();
			return;
		}

		///////////////////////////// lend helena / Gold



		if (selector == 0 && confirmationControl == 11) {
			Board.text = "You pause, mulling the offer over for a moment, then nod firmly.\n\n<i>“What!?”</i> Helena protests. <i>“My Liege you can’t be serious! I-I have a job to do here, and besides which-”</i>\n\n<i>“-And if you want to keep that job,”</i> you break in, talking over her. <i>“Then you will comply with the instructions you are given, lest I find someone who will. Do I make myself clear?”</i>\n\nHelena inhales sharply, and seems as though she’s about to challenge you, before deflating.\n\n<i>“Yes my Liege,”</i> she says, defeated.\n\nYou turn back to the gladiator. His eyes are still on Helena.\n\n<i>“Do we have a deal?”</i>\n\nThe rugged pit-fighter eyes your outstretched hand for a moment before nodding and shaking it.\n\nYou scarcely feel "+  pronhisher +" rough, calloused palm against yours before he’s standing up and stepping around you towards Helena. Turning in your seat, you watch as he backs her up against the wall, Helena keeping her eyes fixed on her shoes as he leans in and sniffs at her face.\n\nSmirking, the gladiator wastes no time before seizing her by the hand and dragging her out of the room. You follow at a gentle pace, distantly feeling the desire to make sure he doesn’t damage her too much.\n\nYou pass into a hallway, hearing from one of the rooms the sound of Helena making half-hearted protests, then the sound of ripping fabric. You quicken your step, listening to Helena’s wavering voice.\n\n<i>“S-sir, please, that will come out of my salary, you can’t just-Ah!”</i> She yelps suddenly, and you hear a more masculine grunt. Pushing open the door, you look in on the drawing room, immediately taking in the sight of Helena being bent over the writing desk with her dress pulled up around her hips and the gladiator behind her. Said gladiator’s pants have tangled around "+  pronhisher +" knees, and you catch a glimpse of him pumping "+  pronhisher +" half-hard cock in the hand not digging into Helena’s hip.\n\nEvidently the ripping noise you heard was her hose being torn open, because as you watch, the gladiator thrusts into her, prompting another yelp of mingled surprise and pain.\n\nThen he’s off, pounding into the pinned servant with nary a care for her pleasure. The sounds of flesh slapping against flesh fill the air, and you watch as Helena buries her face in her arm, trying not to cry out as the gladiator saws into her.\n\nHis hand fists in her hair, jerking her head back painfully, hard enough that the soft headpiece falls away to one side. Helena grits her teeth, whimpering and groaning softly as she digs her nails into the edge of the desk to hold on.\n\nThe gladiator releases her hair, but before Helena can recover he’s torn away her white apron and wormed a hand inside the front of her dress to start pinching and squeezing at her breasts. The maid has her eye screwed shut by now, pain and humiliation etched across her face as the gladiator ploughs into her.\n\nHis pace increases, to the point where the desk starts to rock back and forth slightly, and then he hilts himself inside her and you hear a muffled snap of "+  pronhisher +" teeth that signals "+  pronhisher +" release. Helena lets out a muffled whimper as the gladiator holds himself within her for a moment, then lets go of her hips and pulls out, leaving her to sprawl across the desk.\n\nHe swaggers around towards you, pulling up "+  pronhisher +" pants as he comes.\n\n<i>“So,”</i> he says, as a blob of something white and slimy falls from between Helena’s legs and onto the carpet. <i>“When do we start?”</i>";
			NPCCharList.CharFollower [iHelena].charRelationship -= 10;
			NPCCharList.CharFollower [iHelena].charRelationship -= 5;

			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].isRecruited = true; 

			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].cityJobs = NPCData.Jobs.CastleCaptain;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].attHappiness = 100;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charLoyalty = 80;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charRank = NPCData.CharRank.S;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].coreSkillMartial = 100;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].attPhysical = Random.Range (80, 100);

			fileRulesNPC npcrules = new fileRulesNPC();
			RulesNPC.savedRules.Add (npcrules);
			RulesNPC.savedRules [RulesNPC.savedRules.Count-1].id = NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charID; 
			RulesNPC.savedRules [RulesNPC.savedRules.Count-1].idx = NPCCharList.CharRetainers.Count - 1;
			Board.text += "\n\nYou can now access the barracks!";


			QuestControl.abbadonQuest = 3; 
			Quest AbbadonQuest4 = new Quest ();
			QuestsController.RemoveID (1002);
			QuestsController.createQuest (AbbadonQuest4, "A new dawn", "With the district under control, it's time to rebuild and make it stronger than before.", 14, 1003);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 11) {
			confirmationControl = 10; 
			GameControl.charGold += 50;

			confirmFun (0);
			return;
		}

		///////////////////////////// arts / sports

		if (selector == 0 && confirmationControl == 12) {
			Board.text = "<i>“Glad you have some sense in you, "+ GameControl.playerName +". Now we need to think about the scope of the project. Should we invest heavily in this project, therefore increasing its impact on the population, or just the bare minimum to get things running?”</i> \n\nHe goes into detail telling you that a big investment would increase more significantly the impact on education and infrastructure of the city, improving happiness too, but the cost would be high and would therefore reduce the profits. <i>“I of course believe we need to invest as much as possible on this. These are not times to be greedy, but to invest all in our future.”</i>\n\nHe keeps pushing "+  pronhisher +" agenda for a while, until is time for you to decide. Should you invest heavily in this project, or just enough?";
			option0Name.text = "High investment";
			option1Name.text = "Low investment";
			confirmationControl = 13; 
			return;
		}

		if (selector == 1 && confirmationControl == 12) {
			Board.text = "<i>“I can see the benefits of this choice, "+ GameControl.playerName +", although I must admit that I am not entirely happy about it. Now, we need to think about the scope of the project. Should we invest heavily in this project, therefore increasing its impact on the population, or just spend the bare minimum required to get things running?”</i> \n\nHe goes into great detail about how a bigger investment would more significantly impact on the education and infrastructure of the city, therefore improving happiness too, but also explaining that the cost would be higher, and profits would be lower as a result. <i>“I, of course, believe that we need to invest as much as possible. This is an opportunity to invest in our future, not to be greedy.”</i>\n\nHe keeps pushing "+  pronhisher +" agenda for a while, until finally it is time for you to decide. Should you invest heavily in this project, or just the minimum amount that is required to fund it?";
			option0Name.text = "High investment";
			option1Name.text = "Low investment";
			confirmationControl = 15; 
			return;
		}

		///////////////////////////// Arts high investment / low inv

		if (selector == 0 && confirmationControl == 13) {
			if (NPCCharList.CharFollower [iAbbadon].charLove > 0) {
				Board.text = "<i>“You know, I must say that I am impressed with all that you have done. Perhaps we should pursue a more... intimate alliance.”</i> Abbadon stands in front of you, leaning forward, "+  pronhisher +" gaze locked to your own. He grabs one of your hands, and slowly approaches your face. Should you go ahead and embrace him, or step back and maintain this as strictly a business relationship? ";
				option0Name.text = "Flirt back";
				option1Name.text = "Else";
				confirmationControl = 14; 
			} else {
				Board.text = "<i>“Great, "+ GameControl.playerName +"! Your wisdom has truly earned my respect. I’ll be sure to take care of all of the coordination. It will take some time to get everything running, but now that I have the security and knowledge that my business will be producing again, I can repay all that I owe you. Please excuse me for a moment.”</i> \n\nHe steps away to speak with "+  pronhisher +" guards and servants. In a matter of minutes they return carrying a small coffer. Abbadon opens it, and you can see that it’s full of gold coins. <i>“This coffer holds 2000 gold coins, which should cover my part. Obviously, I’ll be sure to talk about your fine deeds to my friends and the other houses of the city. You’ll have our support in future matters, as long as you don't go crazy like your late uncle. Now, I need to get back to work, but feel free to visit me if you need my advice.”</i>";
				GameControl.charGold += 2000;
				QuestControl.abbadonQuest = 4;
				Quest AbbadonQuest5 = new Quest ();
				QuestsController.RemoveID (1003);
				QuestsController.createQuest (AbbadonQuest5, "The premier", "Abbadon has given you the honour to select those who will perform in the premier.", 14, 1004);
				CityControl.city100Infrastructure += 15;
				CityControl.city100Education += 15;
				CityControl.city100Happiness += 15;
				CityControl.city100Prosperity += 2.5f; 
				NPCCharList.CharFollower [iAbbadon].charLoyalty += 15;
				NPCCharList.CharFollower [iAbbadon].charRelationship += 15;
				LawController.EnactLaw (new LawArtsHigh());
				endTurnFun ();
			}


			return;
		}

		if (selector == 1 && confirmationControl == 13) {
			Board.text = "<i>“Our priorities don’t match, I can see that clearly. Still, you have truly earned my respect with your efforts. I’ll be sure to take care of all of the coordination. It will take some time to get everything running, but now that I have the security and knowledge that my business will be producing again, I can repay all that I owe you. Just excuse me for a moment.”</i> \n\nHe steps away to speak with "+  pronhisher +" guards and servants. In a matter of minutes they return carrying a small coffer. Abbadon opens it, and you can see that it’s full of gold coins. <i>“This coffer holds 2000 gold coins, which should cover my part. Obviously, I’ll be sure to talk about your fine deeds to my friends and the other houses of the city. You’ll have our support in future matters, as long as you don't go crazy like your late uncle.\n\n<i>“I must bid you farewell shortly "+ GameControl.playerName +", as I have many things to take care of, but before I leave, there is still one thing you can do to help me out. Why you don’t go ahead and pick the cast of performers, in preparation for when the theater opens? I am certain you’ll make a delightful choice. Take this task as an honor, not as a job.”</i> With a bright smile, he excuses himself and leaves. Shortly afterwards, a servant tells you that a caravan carrying the gold is ready to depart. You accompany them in order to ensure the gold arrives safely at your vault.\n";
			GameControl.charGold += 2000;
			CityControl.city100Infrastructure += 7.5f;
			CityControl.city100Education += 7.5f;
			CityControl.city100Happiness += 7.5f;
			CityControl.city100Prosperity += 5; 
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 7;
			NPCCharList.CharFollower [iAbbadon].charRelationship += 7;
			QuestControl.abbadonQuest = 4;
			Quest AbbadonQuest5 = new Quest ();
			QuestsController.RemoveID (1003);
			QuestsController.createQuest (AbbadonQuest5, "The premier", "Abbadon has given you the honour to select those who will perform in the premier.", 14, 1004);
			endTurnFun ();
			LawController.EnactLaw (new LawArtsLow());
			return;
		}


		///////////////////////////// Flirt back / else

		if (selector == 0 && confirmationControl == 14) {
			Board.text = "Without hesitation you push forward, embracing Abbadon, and assaulting "+  pronhisher +" mouth with your own. He grabs you by the neck and pulls you further into him, "+  pronhisher +" tongue playing fiercely with yours. You hug him tightly, and run your hands slowly down "+  pronhisher +" back to "+  pronhisher +" hips. You begin softly caressing "+  pronhisher +" ass, until you feel "+  pronhisher +" hand on top of yours, signalling for you to go harder.\n\nThe two of you stay like that for a while, exploring each other’s bodies for the first time, cementing your newly formed relationship with a deep, longing kiss.\n\nThings could have escalated further, if not for a servant interrupting you with a cough. <i>“Sir, the gold and caravan is ready.”</i> She steps back when she sees Abbadon’s fierce gaze upon her. <i>“Thank you Alicia, you can leave now.”</i> You wonder if he just subtly fired her or not, but the girl simply bows, and leaves the scene immediately. Abaddon turns again and gives you a short kiss. <i>“Well, you heard her, your reward is ready. We can continue our conversation another time, perhaps somewhere more intimate...”</i>\n\nYou nod and caress "+  pronhisher +" ass one last time before you turn around and walk to the exit. <i>“Oh before I forget "+ GameControl.playerName +", there is one last thing I need you to do for me. No, is not another task, it’s an honor actually. Would you mind casting the performers for the performance at the future inauguration?  I am certain you won’t disappoint me.”</i> You agree, and tell him that you’ll have it taken care of in due time. <i>“Thanks... darling.”</i> He winks at you, and leaves the room, with a bright smile on "+  pronhisher +" face. \n";
			QuestControl.abbadonQuest = 4;
			Quest AbbadonQuest5 = new Quest ();
			QuestsController.RemoveID (1003);
			QuestsController.createQuest (AbbadonQuest5, "The premier", "Abbadon has given you the honour to select those who will perform in the premier.", 14, 1004);
			CityControl.city100Infrastructure += 15;
			CityControl.city100Education += 15;
			CityControl.city100Happiness += 15;
			CityControl.city100Prosperity += 2.5f; 
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 20;
			NPCCharList.CharFollower [iAbbadon].charRelationship += 20;
			NPCCharList.CharFollower [iAbbadon].charLove += 10;
			endTurnFun ();
			LawController.EnactLaw (new LawArtsHigh());
			return;
		}

		if (selector == 1 && confirmationControl == 14) {
			Board.text = "You hesitate and step back. <i>“Oh...”</i> "+  pronhisher +" face is crimson, and he is clearly ashamed by your rejection, though he tries to recover "+  pronhisher +" composure. \n\n<i>“I... If you’ll excuse me "+ GameControl.playerName +", I have many things to take care of... although there is still one thing you can do to help me out. Why you don’t pick the show for the premier? I am certain you’ll make a delightful choice for that night. Take this task as an honor, not as a job.”</i> With an awkward smile, he excuses himself and leaves. Shortly afterwards, a servant tells you that a caravan carrying the gold is ready to depart. You accompany them in order to ensure the gold arrives safely at your vault.\n";
			QuestControl.abbadonQuest = 4;
			Quest AbbadonQuest5 = new Quest ();
			QuestsController.RemoveID (1003);
			QuestsController.createQuest (AbbadonQuest5, "The premier", "Abbadon has given you the honour to select those who will perform in the premier.", 14, 1004);
			CityControl.city100Infrastructure += 15;
			CityControl.city100Education += 15;
			CityControl.city100Happiness += 15;
			CityControl.city100Prosperity += 5; 
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 10;
			NPCCharList.CharFollower [iAbbadon].charRelationship += 10;
			NPCCharList.CharFollower [iAbbadon].charLove -= 10;
			endTurnFun ();
			LawController.EnactLaw (new LawArtsHigh());
			return;
		}

		///////////////////////////// high low inv sports

		if (selector == 0 && confirmationControl == 15) {
			Board.text = "<i>“Great, "+ GameControl.playerName +"! Your wisdom has truly earned my respect. I’ll be sure to take care of all of the coordination. It will take some time to get everything running, but now that I have the security and knowledge that my business will be producing again, I can repay all that I owe you. Please excuse me for a moment.”</i> \n\nHe steps away to speak with "+  pronhisher +" guards and servants. In a matter of minutes they return carrying a small coffer. Abbadon opens it, and you can see that it’s full of gold coins. <i>“This coffer holds 2000 gold coins, which should cover my part. Obviously, I’ll be sure to talk about your fine deeds to my friends and the other houses of the city. You’ll have our support in future matters, as long as you don't go crazy like your late uncle. \n\n<i>“Now If you’ll excuse me, "+ GameControl.playerName +", I have to take care of many things to take care of... although there is still one thing you can do to help me out. Why you don’t pick the show for the premier? I am certain you’ll make a delightful choice for that night. Take this task as an honor, not as a job.”</i> With a bright smile he excuses himself and leaves. Shortly afterwards, a servant tells you that a caravan carrying the gold is ready to depart. You accompany them in order to ensure the gold arrives safely at your vault.\n";
			GameControl.charGold += 2000;
			QuestControl.abbadonQuest = 4;
			Quest AbbadonQuest5 = new Quest ();
			QuestsController.RemoveID (1003);
			QuestsController.createQuest (AbbadonQuest5, "The premier", "Abbadon has given you the honour to select those who will perform in the premier.", 14, 1004);
			CityControl.city100Infrastructure += 15;
			CityControl.city100Defense += 10;
			CityControl.city100Order -= 5;
			CityControl.city100Happiness += 20;
			CityControl.city100Prosperity += 8; 
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 10;
			NPCCharList.CharFollower [iAbbadon].charRelationship += 10;
			endTurnFun ();
			LawController.EnactLaw (new LawSportsHigh());

			return;
		}

		if (selector == 1 && confirmationControl == 15) {
			Board.text = "<i>“Our priorities don’t match, I can see that clearly. Still, you have truly earned my respect with your efforts. I’ll be sure to take care of all of the coordination. It will take some time to get everything running, but now that I have the security and knowledge that my business will be producing again, I can repay all that I owe you. Just excuse me for a moment.”</i> \n\nHe steps away to speak with "+  pronhisher +" guards and servants. In a matter of minutes they return carrying a small coffer. Abbadon opens it, and you can see that it’s full of gold coins. <i>“This coffer holds 2000 gold coins, which should cover my part. Obviously, I’ll be sure to talk about your fine deeds to my friends and the other houses of the city. You’ll have our support in future matters, as long as you don't go crazy like your late uncle.\n\n<i>“I must bid you farewell shortly "+ GameControl.playerName +", as I have many things to take care of, but before I leave, there is still one thing you can do to help me out. Why you don’t go ahead and pick the cast of performers, in preparation for when the theater opens? I am certain you’ll make a delightful choice. Take this task as an honor, not as a job.”</i> With a bright smile, he excuses himself and leaves. Shortly afterwards, a servant tells you that a caravan carrying the gold is ready to depart. You accompany them in order to ensure the gold arrives safely at your vault.";
			GameControl.charGold += 2000;
			QuestControl.abbadonQuest = 4;
			Quest AbbadonQuest5 = new Quest ();
			QuestsController.RemoveID (1003);
			QuestsController.createQuest (AbbadonQuest5, "The premier", "Abbadon has given you the honour to select those who will perform in the premier.", 14, 1004);
			CityControl.city100Infrastructure += 7.5f;
			CityControl.city100Defense += 5;
			CityControl.city100Order -= 2.5f;
			CityControl.city100Happiness += 10;
			CityControl.city100Prosperity += 4; 
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 5;
			NPCCharList.CharFollower [iAbbadon].charRelationship += 5;
			endTurnFun ();
			LawController.EnactLaw (new LawSportsLow());
			return;
		}


		///////////////////////////// balette / operetta 

		if (selector == 0 && confirmationControl == 16) {
			WorldControl.day += 7;
			if (NPCCharList.CharFollower [iAbbadon].charLove > 0) {
				Board.text = "A week from your choosing, the stage is finally prepared for the first private demonstration, which you attend with Abbadon at your side.\n\nYou have a long chat with the team, who eagerly thank you for giving them chance to put their skills on display in Aurorum, as moving to a new city at this time is almost impossible. You comfort them by saying that Aurorum is very lucky to have them, and if the show is a success they can expect to have a prolific future under the protection of Abbadon. He nods in agreement <i>“I am certain that your act will be fantastic, I will indeed support it in the future.”</i> \n\n\nWithout further delay, they leave to get ready for the show. Shortly after the music starts, the group composed of both handsome men and beautiful women appear on stage. As you expected, the show is a true display of elegance and skill; a smooth, romantic, but fun story utilising the traditional folklore of the island. Although it’s probably not as livid and entertaining as the operetta, the choreography is well incredible, and you don’t doubt that it will be a success. \n\nHalf way through the show, watching their gorgeous bodies float in the air and jiggle around, your body begins to compensates your boredom with arousal. Your hand is clasped inside Abbadon’s, but you decide to place it on top of "+  pronhisher +" thigh. He keeps "+  pronhisher +" eyes on the play, but also smiles and moves "+  pronhisher +" hand on top of yours. \n\nIt’s dark and you are in the first row, and Abbadon seems to be eager to have some fun with you. Should you go ahead or would you rather stop?";
				option0Name.text = "Mutual masturbation";
				option1Name.text = "Stay put";
				confirmationControl = 17;
			} else {
				Board.text = "A week from your choosing, the stage is finally prepared for the first private demonstration, which you attend with Abbadon at your side.\n\nYou have a long chat with the team, who eagerly thank you for giving them chance to put their skills on display in Aurorum, as moving to a new city at this time is almost impossible. You comfort them by saying that Aurorum is very lucky to have them, and if the show is a success they can expect to have a prolific future under the protection of Abbadon. He nods in agreement <i>“I am certain that your act will be fantastic, I will indeed support it in the future.”</i> \n\n\nWithout further delay, they leave to get ready for the show. Shortly after the music starts, the group composed of both handsome men and beautiful women appear on stage. As you expected, the show is a true display of elegance and skill; a smooth, romantic, but fun story utilising the traditional folklore of the island. Although it’s probably not as livid and entertaining as the operetta, the choreography is well incredible, and you don’t doubt that it will be a success. \n\nHalf way through the show, watching their gorgeous bodies float in the air and jiggle around, your body begins to compensate your boredom with arousal. You can see that Abbadon is in the same state as you, hypnotized by one of the well hung dancers, who happens to be dressed in very tight pants. \n\nFinally there is an interlude, and Abbadon looks eager to leave "+  pronhisher +" seat.  <i>“"+ GameControl.playerName +" I believe we should go and have a private talk with these artists. Their delightful performance deserves a personal appraisal from their lords, don’t you think? It won’t take long, and it would be good to get more acquainted to them.”</i> \n\nGoing with Abbadon would provide a good opportunity to get better acquainted with him, and showing interest for what he likes is not a bad idea if you want to keep improving your relationship with such an important house. \n\n";
				option0Name.text = "Follow him";
				option1Name.text = "Stay";
				confirmationControl = 18; 
			}

			return;
		}



		if (selector == 1 && confirmationControl == 16) {
			Board.text = "A week from your choosing, they have finally prepared the stage for the first private demonstration to you.\n\nYou have a long chat with the conductor and composer, who excitedly thanks you for giving him the chance to finally put "+  pronhisher +" play, since it has been rejected throughout the whole island. You comfort him by saying that Aurorum is very lucky to have him now, and if the show is a success he can expect to have a prolific future under the protection of Abbadon. \n\nWithout further delay, he leaves to get ready for the show. Shortly aftewards the music starts, and a group of beautiful girls and handsome guys appear on stage. As you had expected, the show is a very fun performance, criticizing the old guard, the gods and other traditional institutions with both wit and charm. Although probably not as graceful as the dancers, the choreography is well done and very daring where it matters. \n\nWhen the show is over, the entire cast thanks you, and the conductor comes back to you again, telling you that the whole group would like to thank you with a gift. Before you can ask what it is, you can see that the crew is starting to get naked, and gestures towards you, inviting you to join them. \n\nThe conductor, too old to join you, winks at you and tells you to not miss the chance, while he goes away to rest. \n\nShould you go forward? Warning, the scene has bi content. ";
			option0Name.text = "Join them";
			option1Name.text = "Leave";
			confirmationControl = 19; 
			return;
		}

		///////////////////////////// mutual mast / stay put 

		if (selector == 0 && confirmationControl == 17) {
			WorldControl.day += 12;
			if (GameControl.dick1Size > 0) {
				Board.text = "You advance with your hand, reaching towards "+  pronhisher +" nether parts, but he stops you and whispers to you. <i>“No... Please, use my back door.”</i> He moves on "+  pronhisher +" seat, and with a single move of "+  pronhisher +" hand he unzips part of "+  pronhisher +" skirt, allowing you to touch "+  pronhisher +" bare butt. <i>“I recently commissioned this skirt for an occasion just like this one, "+ GameControl.playerName +". I’ve been wanting this for days.”</i> while he whispers, "+  pronhisher +" hand expertly frees your cock, holding your semi erect member in "+  pronhisher +" cold hands. \n\nHe tries to stay focused on the play while he slowly starts to jerk you off, and when your member is fully erect, he takes a second to give it a look, and smiles. <i>“You’ll soon have the chance to put this in my ass, but not today "+ GameControl.playerName +".”</i> he continues to stroke you, while you trace around "+  pronhisher +" butthole with one finger. You can feel it twitch, eager to receive some action, but before you can do anything more, Abbadon discretely hands you a tube of lube that was in "+  pronhisher +" purse. You don’t say a word, and apply it to your hand before you return to your task.\n\nWhen you put your first digit inside he shivers, "+  pronhisher +" spine trembling in anticipation. At first you go slow, and he matches your speed with "+  pronhisher +" hand. When you believe "+  pronhisher +" ass is ready, you insert a second digit. He reacts by slowly moving "+  pronhisher +" hips, trying to not make this act too obvious. "+ pronhisher+" arousal is such that even though "+  pronhisher +" face manages to remain stoic, he is jerking you at such speed that the sounds are echoing through the room. \n\nThe actors either don’t notice this or, as is most likely, just pretend that nothing is going on. It is not as though they would call him out on this act. Knowing this, Abbadon starts to be less subtle about "+  pronhisher +" hips movements, and you slip in a third finger.\n\nThe fun goes for almost ten minutes, before both of you are at your limits. He notices your incoming orgasm, and starts to pump you harder. You try to say something but he shushes you, and in no time you begin to cum load after load. The first one goes off with such strength that it lands on the stage, but Abbadon quickly puts "+  pronhisher +" hand on top of it, smearing "+  pronhisher +" skin and "+  pronhisher +" sleeves with your jizz. \n\nWhen you are done you can feel him trembling, enjoying an orgasm on "+  pronhisher +" own. At this point you can see the dancers are either erect or wet with excitement. As professionals, however, they continue their job appropriately. Abbadon shamelessly moves "+  pronhisher +" hand in front of "+  pronhisher +" face, taking a moment to gaze at the mass of sperm before he starts to lick it clean.\n\nWith the first lick he takes most of the thick cum from "+  pronhisher +" palm, closing "+  pronhisher +" eyes and enjoying its taste in "+  pronhisher +" month for a moment before swallowing. Next, he sucks each finger one by one, making sure to slurp up every single drop on them. When he has mostly finished cleaning "+  pronhisher +" hand, he takes a napkin and wipes away what is left on "+  pronhisher +" sleeve. He then uses the stained napkin to <i>clean</i> "+  pronhisher +" lips, although all this act achieves is to smear them with cum, which he happily leaves to dry.\n\nWhen the show is over, both of you congratulate the dancers for their incredible job; Abbadon happily and shamelessly saying that he is eager to see it again at the premier, with your cum still on "+  pronhisher +" face. ";

			} else {
				Board.text = "You advance with your hand, reaching towards "+  pronhisher +" nether parts, but he stops you and whispers to you. <i>“No... Please, use my back door.”</i> He moves on "+  pronhisher +" seat, and with a single move of "+  pronhisher +" hand he unzips part of "+  pronhisher +" skirt, allowing you to touch "+  pronhisher +" bare butt. <i>“I recently commissioned this skirt for an occasion just like this one, "+ GameControl.playerName +". I’ve been wanting this for days.”</i>. While he whispers, "+  pronhisher +" hand expertly slides through your legwear, reaching your nether parts with "+  pronhisher +" cold hands. \n\nHe tries to stay focus on the play while he slowly begins to finger you. When "+  pronhisher +" hands are wet enough, he takes a second to give you a look, and smiles. <i>“You’ll soon have the chance to put this on my face, but not today "+ GameControl.playerName +".”</i> he continues to penetrate you, while you trace around "+  pronhisher +" butthole with one finger. You can feel it twitch, eager to receive some action, but before you can do anything more, Abbadon discretely hands you a tube of lube that was in "+  pronhisher +" purse. You don’t say a word, and apply it to your hand before you return to your task.\n\nWhen you put your first digit inside he shivers, "+  pronhisher +" spine trembling in anticipation. At first you go slow, and he matches your speed with "+  pronhisher +" hand. When you believe "+  pronhisher +" ass is ready, you insert a second digit. He reacts by slowly moving "+  pronhisher +" hips, trying to not make this act too obvious. "+ pronhisher+ " arousal is such that even though "+  pronhisher +" face manages to remain stoic, he is penetrating you at such speed that the sounds are echoing through the room. \n\nThe actors either don’t notice this or, as is most likely, just pretend that nothing is going on. It is not as though they would call him out on this act. Knowing this, Abbadon starts to be less subtle about "+  pronhisher +" hips movements, and you slip in a third finger.\n\nThe fun goes for almost ten minutes, before both of you are at your limits. He notices your incoming orgasm, and starts to pump you harder. You try to say something but he shushes you, and in no time you begin to shake as your body is filled waves of pleasure. Your legs tremble, and you begin to squirt in ecstasy, coating both "+  pronhisher +" skin and sleeves with your fluids. \n\nWhen you are done you can feel him trembling, enjoying an orgasm on "+  pronhisher +" own. At this point you can see the dancers are either erect or wet with excitement. As professionals, however, they continue their job appropriately. Abbadon shamelessly moves "+  pronhisher +" hand in front of "+  pronhisher +" face, taking a moment to gaze at it before he starts to lick it clean.\n\nWith the first lick he takes most of the thick cum from "+  pronhisher +" palm, closing "+  pronhisher +" eyes and enjoying its taste in "+  pronhisher +" month for a moment before swallowing. Next, he sucks each finger one by one, making sure to slurp up every single drop on them. When he has mostly finished cleaning "+  pronhisher +" hand, he takes a napkin and wipes away what is left on "+  pronhisher +" sleeve. He then uses the stained napkin to <i>clean</i> "+  pronhisher +" lips, although all this act achieves is to coat "+  pronhisher +" lips with more of your essence. which he happily leaves to dry.\n\nWhen the show is over, both of you congratulate the dancers for their incredible job; Abbadon happily and shamelessly saying that he is eager to see it again at the premier, with your cum still on "+  pronhisher +" face. ";

			}
			Board.text += "\n\nWhen you go back to Abbadon’s house the first thing he does once inside is kissing <i>“"+ GameControl.playerName +"! I’m sorry for what we did, is just I got so excited I lost control of myself... It’s fine, I’m sure other nobles have done even worse, but I hope you are not angry for my lack of control and common sense.”</i> You tell him to not worry about that, that you had a great time with him. Relieved, he goes back to talk about business. <i>“I should say you have a great eye for this! The performance was great!... Well, maybe a little boring from time to time, but very elegant, I’m sure it’s gonna be a hit.”</i> he hugs you <i>“Thanks for doing this for me, now the city will have access again to great entertainment. Things are changing for the best, you should keep it up... Once the play premiers, I’ll start paying my taxes again... And come to see me again soon, I would like to have a better taste of you.”</i> he excuses himself and winks at you before going upstairs, while you walk back at your castle with your guards. \n\n\nFive days later the show premiers, and the elites of the city love it. The poorest and middle class of the city ignore it altogether, as the ticket prices are too high, and the show wasn’t to their taste. A week after the premier, the show continues to fill the theater with noblemen, and Abbadon decides to hire this group and composer to produce more scripts and plays.\n\n<i>“I’m loving this show, and you’ve really reinvigorated this district, I thank you for that.”</i> He invites you to "+  pronhisher +" study to arrange the future payments of "+  pronhisher +" house.\n\n<i>“You know, in the end you did a great job. Whether I like it or not, things are changing for the better. I said it before, and I will say it again, you have my support if you ever need it. Now that my family business is alive again, there is a lot of work for me to do, but please feel free to visit me, I won’t mind taking time off to hang with you.”</i>\n\nYou grab him by the waist and kiss him. He is slow to react, exhausted and still resentful of your choices, but finally he answers again. <i>“You silly... Please, come again soon and we’ll finish this business. But for now I need to get back to this.”</i> you smile and softly spank "+  pronhisher +" ass. You see that "+  pronhisher +" face is red with arousal, but you decide to take your leave. You promise to come back soon enough. \n";
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 20;
			NPCCharList.CharFollower [iAbbadon].attHappiness+= 20;
			NPCCharList.CharFollower [iAbbadon].charLove += 10;
			NPCCharList.CharFollower [iAbbadon].charRelationship += 10;
			QuestControl.abbadonQuest = 5;
			QuestsController.RemoveID (1004);
			if(QuestControl.albaQuest == 4){
				Quest HelenaQuest0 = new Quest();
				QuestsController.createQuest(HelenaQuest0, "Repairs", "With the two bigger Houses backing you, it's time to repair your castle", 13, 3000);
				LawController.RepealLaw (LawController.Get<LawTaxesLow> ());
				LawController.EnactLaw (new LawTaxesNormal ());
			} else {
				LawController.RepealLaw (LawController.Get<LawTaxesVeryLow> ());
				LawController.EnactLaw (new LawTaxesLow ());
			}
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 17) {
			WorldControl.day += 12;
			Board.text = "You remove your hands from Abbadon. He looks at you in disappointment but doesn’t say a thing, and continues to watch the play as if nothing happened.\n\nWhen the show is over both of you congratulate the dancers for their incredible job, Abbadon happily saying that he is eager to see it again at the premier. \n\nWhen you go back to Abbadon’s house you can see that he is happy, even if you ignored him at the theater. <i>“"+ GameControl.playerName +"! I should say you have a great eye for this! The performance was great! Well, maybe it got a little boring from time to time, but it was very elegant. I’m sure it’s gonna be a hit.”</i> he hugs you <i>“Thanks for doing this for me, now the city will have access to great entertainment again. Things are changing for the better, you should keep it up. Once the play premiers, I’ll start paying my taxes again.”</i>\n\nFive days later the show premiers, and the elites of the city love it. The poorest and middle class of the city ignore it altogether, as the ticket prices are too high, and the show wasn’t to their taste. A week after the premier, the show continues to fill the theater with noblemen, and Abbadon decides to hire this group and composer to produce more scripts and plays.\n\n<i>“I’m loving this show, and you’ve really reinvigorated this district, I thank you for that.”</i> He invites you to "+  pronhisher +" study to arrange the future payments of "+  pronhisher +" house.\n\n<i>“You know, in the end you did a great job. Whether I like it or not, things are changing for the better. I said it before, and I will say it again, you have my support if you ever need it. Now that my family business is alive again, there is a lot of work for me to do, but please feel free to visit me, I won’t mind taking time off to hang with you.”</i>\n\nYou grab him by the waist and kiss him. He is slow to react, exhausted and still resentful of your choices, but finally he answers again. <i>“You silly... Please, come again soon and we’ll finish this business. But for now I need to get back to this.”</i> you smile and softly spank "+  pronhisher +" ass. You see that "+  pronhisher +" face is red with arousal, but you decide to take your leave. You promise to come back soon enough. \n\n";
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 15;
			NPCCharList.CharFollower [iAbbadon].attHappiness+= 15;
			NPCCharList.CharFollower [iAbbadon].charLove += 0;
			NPCCharList.CharFollower [iAbbadon].charRelationship += 5;
			QuestControl.abbadonQuest = 5;
			QuestsController.RemoveID (1004);
			endTurnFun ();
			if(QuestControl.albaQuest == 4){
				Quest HelenaQuest0 = new Quest();
				QuestsController.createQuest(HelenaQuest0, "Repairs", "With the two bigger Houses backing you, it's time to repair your castle", 13, 3000);
				LawController.RepealLaw (LawController.Get<LawTaxesLow> ());
				LawController.EnactLaw (new LawTaxesNormal ());
			} else {
				LawController.RepealLaw (LawController.Get<LawTaxesVeryLow> ());
				LawController.EnactLaw (new LawTaxesLow ());
			}
			return;
		}

		///////////////////////////// follow / stay put 

		if (selector == 0 && confirmationControl == 18) {
			WorldControl.day += 12;
			Board.text = "You agree to follow him <i>“Delightful, let’s go meet them!”</i> You follow Abbadon and talk with the crew about their inspiration, history, among other things. When the show is over, the two of you thank the whole crew for their great work, and you finally leave with Abbadon at your side.\n\nYou see him cheerful and happy from the experience <i>“"+ GameControl.playerName +"! I should say you have a great eye for this! The performance was great! Well, maybe it got a little boring from time to time, but it was very elegant. I’m sure it’s gonna be a hit.”</i> he hugs you <i>“Thanks for doing this for me, now the city will have access to great entertainment again. Things are changing for the better, you should keep it up. Once the play premiers, I’ll start paying my taxes again.”</i>\n\nFive days later the show premiers and the elites of the city love it, while the poorest and middle class of the city ignored it altogether, since the ticket prices were too high, and the show wasn’t for their taste. \n\nFive days later the show premiers, and the elites of the city love it. The poorest and middle class of the city ignore it altogether, as the ticket prices are too high, and the show wasn’t to their taste.\n\nA week after the premier, the show continues to fill the theater with noblemen, and Abbadon decides to hire this group and composer to produce more scripts and plays.\n\n<i>“You know, at the end you did a great job, whatever I like it or not, things are changing for the better. I said it before, but I will say it again, you have my support if you ever need it, now that my family business is alive again, there is a lot of work for me to do, but please feel free to visit me, I won’t mind to take time off to hang with you.”</i>";
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 20;
			NPCCharList.CharFollower [iAbbadon].attHappiness+= 20;
			NPCCharList.CharFollower [iAbbadon].charLove += 5;
			NPCCharList.CharFollower [iAbbadon].charRelationship += 10;
			QuestControl.abbadonQuest = 5;
			QuestsController.RemoveID (1004);
			if(QuestControl.albaQuest == 4){
				Quest HelenaQuest0 = new Quest();
				QuestsController.createQuest(HelenaQuest0, "Repairs", "With the two bigger Houses backing you, it's time to repair your castle", 13, 3000);
				LawController.RepealLaw (LawController.Get<LawTaxesLow> ());
				LawController.EnactLaw (new LawTaxesNormal ());
			} else {
				LawController.RepealLaw (LawController.Get<LawTaxesVeryLow> ());
				LawController.EnactLaw (new LawTaxesLow ());
			}
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 18) {
			WorldControl.day += 12;
			Board.text = "<i>“Pfff... fine, as you wish.”</i> You let Abbadon go and talk with the crew. When the show is over, you finally go and thank the whole crew for their good work, but with so many tasks to complete, you promptly leave, with Abbadon at your side.\n\nYou expected him to be angry, but he is actually happy, even if you hurried him. <i>“"+ GameControl.playerName +"! I should say you have a great eye for this! The performance was great! Well, maybe it got a little boring from time to time, but it was very elegant. I’m sure it’s gonna be a hit.”</i> he hugs you <i>“Thanks for doing this for me, now the city will have access to great entertainment again. Things are changing for the better, you should keep it up. Once the play premiers, I’ll start paying my taxes again.”</i>\n\nFive days later the show premiers, and the elites of the city love it. The poorest and middle class of the city ignore it altogether, as the ticket prices are too high, and the show wasn’t to their taste.\n\nA week after the premier, the show continues to fill the theater with noblemen, and Abbadon decides to hire this group and composer to produce more scripts and plays.\n\n<i>“I’m loving this show, and you’ve really reinvigorated this district, I thank you for that.”</i> He invites you to "+  pronhisher +" study to arrange the future payments of "+  pronhisher +" house.\n\n<i>“You know, in the end you did a great job. Whether I like it or not, things are changing for the better. I said it before, and I will say it again, you have my support if you ever need it. Now that my family business is alive again, there is a lot of work for me to do, but please feel free to visit me, I won’t mind taking time off to hang with you.”</i>";
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 15;
			NPCCharList.CharFollower [iAbbadon].attHappiness+= 15;
			NPCCharList.CharFollower [iAbbadon].charLove += 0;
			NPCCharList.CharFollower [iAbbadon].charRelationship += 5;
			QuestControl.abbadonQuest = 5;
			QuestsController.RemoveID (1004);
			if(QuestControl.albaQuest == 4){
				Quest HelenaQuest0 = new Quest();
				QuestsController.createQuest(HelenaQuest0, "Repairs", "With the two bigger Houses backing you, it's time to repair your castle", 13, 3000);
				LawController.RepealLaw (LawController.Get<LawTaxesLow> ());
				LawController.EnactLaw (new LawTaxesNormal ());
			} else {
				LawController.RepealLaw (LawController.Get<LawTaxesVeryLow> ());
				LawController.EnactLaw (new LawTaxesLow ());
			}
			endTurnFun ();
			return;
		}

		///////////////////////////// join them // leave operetta orgy

		if (selector == 0 && confirmationControl == 19) {
			WorldControl.day += 12;
			string LINE1;
			if (GameControl.dick1Size > 0) {
				LINE1 = "You decide to switch your focus, leaning over the guy and having a mouthful of "+  pronhisher +" cock. You enjoy the taste of its salty fluids while the girl kneels in front of you and takes your full mast into her mouth with ease, as you would expect from a skilled prostitute as herself. \n\nYou grab her head and try to match her rhythm to the same speed that you are sucking the man off with. It doesn't take long until you feel a warm fluid flooding your mouth. Your body clenches, and you start to cum in the girl’s mouth, while at the same time you eagerly drink the man’s load.  \n\nThe three of you engage in a kiss when you are spent, sharing and swallowing the fluids of one another. <i>“Come on, let’s go to the main course now.”</i> says the bunny before hopping on your lap and jerking your cock. <i>“You can’t be done already, right?”</i> he playfully says. With "+  pronhisher +" and the girl’s help, you get hard again in no time.\n\n<i>“Get me ready”</i> he orders the girl, who immediately puts her head between you and "+  pronhisher +" ass, so she can lick it while he masturbates. Once "+  pronhisher +" back door is ready, she moves away, and he slowly starts to sit on top of you. <i>“Mmhh... Such a nice spear you have.”</i> he says when you are fully inside him. Taking this as a cue, the girl sits on top of him, using "+  pronhisher +" tool on her own pussy. <i>“Ahh!”</i> she moans, and you slowly start to move.\n\nWhile enjoying your own threesome, you can see that the entire crowd around you is trying to keep up with your rhythm, although many of them make it to climax before you do. \n\nAfter several minutes, you finally are at your limit. <i>“We are there too, my liege!”</i> says the man who is riding your cock. As you get closer to the edge, others from the crew approach you, kissing and caressing you. When you finally finish, deep inside the bunny’s ass, you can feel "+  pronhisher +" whole body clench as he repeats the favor for the wolf girl. The people start to cheer with joy, and once the couple fall to the side, others hastily come to clean you up. \n\n<i>“It was fantastic...”</i> you hear him saying, while the girl has passed out, exhausted after completing so many draining tasks.\n\n ";
			} else {
				LINE1 = "You decide to switch your focus, leaning over the guy and having a mouthful of "+  pronhisher +" cock. You enjoy the taste of its salty fluids while the girl kneels in front of you and dives into your nether parts, eating you out as though your fluids are made of honey. Her tongue expertly darts back and forth over your best spots, as you would expect from a skilled prostitute as herself. \n\nYou grab her head and try to match her rhythm to the same speed that you are sucking the man off with. It doesn't take long until you feel a warm fluid flooding your mouth. Your body clenches, and you start to cum in the girl’s mouth, while at the same time you eagerly drink the man’s loa\nThe three of you engage in a kiss when you are spent, sharing and swallowing the fluids of one another. <i>“Come on, let’s go to the main course now.”</i> says the bunny before hopping on your lap and fingering you. <i>“You can’t be done already, right?”</i> he playfully says while giving you a strap. With "+  pronhisher +" and the girl’s help,, they get you ready for action in short notice. \n\n<i>“Get me ready”</i> he orders the girl, who immediately puts her head between you and "+  pronhisher +" ass, so she can lick it while he masturbates. Once "+  pronhisher +" back door is ready, she moves away and he slowly starts to sit on top of you. <i>“Mmhh... Don’t be afraid to be rough, I can take a pounding.”</i> he says when you are fully inside him. Taking this as a cue, the girl now sits on top of him, taking "+  pronhisher +" tool in her own pussy. <i>“Ahh!”</i> she moans, and you slowly start to move.\n\nWhile enjoying your own threesome, you can see that the entire crowd around you is trying to keep up with your rhythm, although many of them make it to climax before you do. \n\nAfter several minutes, you finally are at your limit. <i>“We are too my Liege!”</i> says the man who is riding your strap-on. As you get closer to the edge, others from the crew approach you, kissing and caressing you. When you finally finish, while your toy is deep inside the bunny’s ass, you can feel how "+  pronhisher +" whole body clenches, as he repeats the favor for the wolf girl. The people start to cheer with joy, and once the couple fall to the side, others hastily come to clean you up. \n\n<i>“It was fantastic...”</i> you hear him saying, while the girl has passed out, exhausted after so many draining tasks.\n\n";
			}
			Board.text = "<i>“Come on! Don’t be shy! Join us!”</i> yells one of the actresses, who is dressed as a member of the clergy. <i>“It’ll be fun!”</i> says one dressed as a prostitute. Before you can give them an answer a couple; one skimpily dressed wolf girl, and a bunny man dressed as the major, run to you and grab you by the arms, walking you towards the crowd. \n\nThe group, still exhausted by their previous display, engage in foreplay, caressing and kissing each other, with those who are wearing uncomfortable clothing getting naked. Others bring mattresses that will be used soon, and the couple that was accompanying you helps you to get more comfortable by removing your attire. \n\nOnce you are naked, they take you to the middle of the stage, where someone else has installed a couch for you to sit and enjoy yourself, giving you a view of what’s going on. <i>“You like this?”</i> asks the wolf girl, displaying her breasts to you. <i>“Or maybe you prefer this?”</i> says the young man, showing "+  pronhisher +" almost fully erect member to you. Although the choice is hard, you dive upon her breasts, while with one of your hands you grab the hot rod of the bunny. You can feel it throbbing, and its considerable precum dripping over your hand. While your face enjoys the soft texture of the girl’s breasts,you eagerly suck her nipples. \n\nIt doesn’t take long before everyone is engaged in some kind of lewd act. A girl still dressed as a nun is being ravaged by a horse man, its testicles loudly slapping against her ass. To your right a threesome is taking place, the lucky girl in the middle barely visible. All around you can be heard moans, and the place has become hot from the warmth of your bodies.\n\n";
			Board.text += LINE1;
			Board.text = "You stay with them for several hours before you go back to Abbadon, who hadn’t had time until now to discuss your choice.\n\n<i>“"+ GameControl.playerName +"! I heard you hired a bunch of sluts for the show! Are you mental?! Don't answer that, it’s a rhetoric question!”</i> he desperately rubs "+  pronhisher +" temples, trying to calm down. <i>“It’s too late now to change the show, we’ll have to run with it. Pray that at least it becomes a success, otherwise you can forget about your taxes.”</i>\n\nFive days later the show premiers, and although the elites of the city hated it, the poorest and middle class of the city did everything they could to see the show at least once. Abbadon has decided to reduce the price in order to make it more affordable to the interested masses. \n\nA week after the premier, the show kept filling the theater, and Abbadon decides to hire this composer to produce more scripts and plays.\n\n<i>“Well, I personally hate this show, but you really reinvigorated this district, and I thank you for that.”</i> He invites you to "+  pronhisher +" study to arrange the future payments of "+  pronhisher +" house.\n\n<i>“You know, in the end you did a great job. Whether I like it or not, things are changing for the better. I said it before, and I will say it again, you have my support if you ever need it. Now that my family business is alive again, there is a lot of work for me to do, but please feel free to visit me, I won’t mind taking time off to hang with you.”</i>\n";

			QuestControl.abbadonQuest = 5;
			QuestsController.RemoveID (1004);
			if(QuestControl.albaQuest == 4){
				Quest HelenaQuest0 = new Quest();
				QuestsController.createQuest(HelenaQuest0, "Repairs", "With the two bigger Houses backing you, it's time to repair your castle", 13, 3000);
				LawController.RepealLaw (LawController.Get<LawTaxesLow> ());
				LawController.EnactLaw (new LawTaxesNormal ());
			} else {
				LawController.RepealLaw (LawController.Get<LawTaxesVeryLow> ());
				LawController.EnactLaw (new LawTaxesLow ());
			}
			endTurnFun ();
			if (QuestControl.abbadonHelp) {
				NPCCharList.CharFollower [iAbbadon].charLoyalty += 10;
				NPCCharList.CharFollower [iAbbadon].attHappiness+= 10;
				NPCCharList.CharFollower [iAbbadon].charLove += 0;
				NPCCharList.CharFollower [iAbbadon].charRelationship += 10;
			} else {
				NPCCharList.CharFollower [iAbbadon].charLoyalty += 5;
				NPCCharList.CharFollower [iAbbadon].attHappiness -= 20;
				NPCCharList.CharFollower [iAbbadon].attObedience += 20;
				NPCCharList.CharFollower [iAbbadon].charRelationship -= 5;
			}
			return;
		}

		if (selector == 1 && confirmationControl == 19) {
			if (QuestControl.abbadonHelp) {
				Board.text = "You thank the crew for their offer, but you tell them that having them in your city is more than enough reward for you, and that you have other matters to attend.\n\nThey sound disappointed when you turn around to leave, but before you leave the place you can hear their moanings, a clear indication that they got over it fast. \n\nYou go back with Abbadon, who hasn’t had time until now to discuss your choice until now.\n\n<i>“"+ GameControl.playerName +"! I heard you hired a bunch of sluts for the show! Are you mental?! Don't answer that, it’s a rhetoric question!”</i> he desperately rubs "+  pronhisher +" temples, trying to calm down. <i>“It’s too late now to change the show, we’ll have to run with it. Pray that at least it becomes a success, otherwise you can forget about your taxes.”</i>\n\nFive days later the show premiers, and although the elites of the city hated it, the poorest and middle class of the city did everything they could to see the show at least once. Abbadon has decided to reduce the price in order to make it more affordable to the interested masses. \n\nA week after the premier, the show kept filling the theater, and Abbadon decides to hire this composer to produce more scripts and plays.\n\n<i>“Well, I personally hate this show, but you really reinvigorated this district, and I thank you for that.”</i> He invites you to "+  pronhisher +" study to arrange the future payments of "+  pronhisher +" house.\n\n<i>“You know, in the end you did a great job. Whether I like it or not, things are changing for the better. I said it before, and I will say it again, you have my support if you ever need it. Now that my family business is alive again, there is a lot of work for me to do, but please feel free to visit me, I won’t mind taking time off to hang with you.”</i>";
				if (NPCCharList.CharFollower [iAbbadon].charLove > 0) {
					Board.text += "\n\nYou grab him by the waist and kiss him. He is slow to react, exhausted and still resentful of your choices, but finally he answers again. <i>“You silly... Please, come again soon and we’ll finish this business. But for now I need to get back to this.”</i> you smile and softly spank "+  pronhisher +" ass. You see that "+  pronhisher +" face is red with arousal, but you decide to take your leave. You promise to come back soon enough";
				}
			} else {
				Board.text = "You thank the crew for their offer, but you tell them that simply having them in your city is more than enough reward for you, and that you have other matters to attend to.\n\nThey sound disappointed when you turn around to leave. As you exit the place you can hear their moanings, a clear indication that they got over it fast. \n\nYou go back to Abbadon, who hasn’t had time to discuss your choice until now.\n\n<i>“"+ GameControl.playerName +"! I heard you hired a bunch of sluts for the show! Are you mental?! Don't answer that, it’s a rhetoric question!”</i> he desperately rubs "+  pronhisher +" temples, trying to calm down. <i>“It’s too late now to change the show, we’ll have to run with it. Pray that at least it becomes a success, otherwise you can forget about your taxes.”</i>\n\n\nFive days later the show premiers, and although the elites of the city hated it, the poorest and middle class of the city did everything they could to see the show at least once. Abbadon has decided to reduce the price in order to make it more affordable to the interested masses. \n\nA week after the premier, the show kept filling the theater, and Abbadon decides to hire this composer to produce more scripts and plays.\n\n<i>“Well, I personally hate this show, but you really reinvigorated this district, and I thank you for that.”</i> He invites you to "+  pronhisher +" study to arrange the future payments of "+  pronhisher +" house.\n\n\n<i>“What matters is that, in the end everything is running. Whether I like it or not, things are changing. Now that my family business is alive again, there is a lot of work for me to do, but if there are any important matters that need my consultation, do come back.”</i>\n";
			}

			WorldControl.day += 12;
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 10;
			NPCCharList.CharFollower [iAbbadon].attHappiness+= 10;
			NPCCharList.CharFollower [iAbbadon].charLove += 0;
			NPCCharList.CharFollower [iAbbadon].charRelationship += 10;
			QuestControl.abbadonQuest = 5;
			QuestsController.RemoveID (1004);
			if(QuestControl.albaQuest == 4){
				Quest HelenaQuest0 = new Quest();
				QuestsController.createQuest(HelenaQuest0, "Repairs", "With the two bigger Houses backing you, it's time to repair your castle", 13, 3000);
				LawController.RepealLaw (LawController.Get<LawTaxesLow> ());
				LawController.EnactLaw (new LawTaxesNormal ());
			} else {
				LawController.RepealLaw (LawController.Get<LawTaxesVeryLow> ());
				LawController.EnactLaw (new LawTaxesLow ());
			}
			endTurnFun ();
			return;
		}



		///////////////////////////// Gladiators / beasts

		if (selector == 0 && confirmationControl == 20) {
			WorldControl.day += 6;
			Board.text = "Several days pass before the inaugural game begins. Abbadon, not really content with the choice to host blood sports, is not present. You are glad to be the host today though, as it is a good opportunity to become known to the citizens.\n\nEarlier in the day, a bunch of smaller combats and events were held, getting the crowd ready for the main fight.\n\nWhen you are ready you give your speech, amidst the eager shouting of the crowd. They are  anxious to see the main fight begin. The first team to enter are the people from Abbadon, a group mainly composed of criminals and common hired blades. They don’t look very intimidating, and seem even less so when, across from them, the gladiators enter; making fierce gestures, and receiving the love of the crowd.\n\nThey all walk to the middle of the arena, where they bow to you as you welcome them. They then take their positions, and await your signal for the start of the fight. The crowd goes quiet in anticipation, and the moment your hand completes a small gesture, the two groups jump at each other. The combat is fierce and extreme, but it only takes ten minutes for the fighting to end, after which the gladiators emerge as clear winners. \n\nThe crowd is frothing in adoration for them and, with the final fight finished, servants rush into the area and begin preparing it for a feast, to which all of the city is invited.\n\nAfter you are done with the feast, you visit Abbadon’s house to tell him about the event. A servant opens the door for you, and leads you to the studio. <i>“Good evening "+ GameControl.playerName +", I heard the event was a success, is that correct?”</i> You nod and tell him about the events of the day. Abbadon doesn’t look too excited or involved with your story, and in the end you just give him a shortened version. \n\n<i>“I’m sorry "+ GameControl.playerName +". I don’t want to be rude, it’s just that these types of events are not my thing. Nonetheless, I am truly happy that it worked out. You have earned my respect and support once more, and you’ll be receiving your taxes very soon.”</i> When he is done speaking, he smiles at you <i>“You know, I am actually happy that everything is in motion again. It might not be what I had in mind, but it is working well, I really am thankful for you, and I’m glad to have at my side helping me.”</i> ";
			if (NPCCharList.CharFollower [iAbbadon].charLove > 0) {
				NPCCharList.CharFollower [iAbbadon].charLove += 5;
				Board.text += "\n\nHe stands up and kisses you. First soft and slow, but "+  pronhisher +" passion increases rapidly. <i>“There, that’s a small extra for your help. Tonight I’m really busy, but you can pick the rest of your booty tomorrow or when you please.”</i> he gives a playful slap to "+  pronhisher +" ass and winks at you. \n\n<i>“Now, I think both of us need to rest, you’ll receive your taxes daily as it should be.”</i> You excuse yourself and leave "+  pronhisher +" office, and then return to your home with your guards. ";
			} else {
				Board.text += "\n\n<i>“Now, I think that both of us need to rest. You’ll receive your taxes daily from now on, as it should be.”</i> You excuse yourself from "+  pronhisher +" office, and then return home with your guards. ";
			}

			if (QuestControl.abbadonHelp) {
				NPCCharList.CharFollower [iAbbadon].charLoyalty += 20;
				NPCCharList.CharFollower [iAbbadon].attHappiness+= 10;
				NPCCharList.CharFollower [iAbbadon].charRelationship += 10;
			} else {
				NPCCharList.CharFollower [iAbbadon].charLoyalty += 5;
				NPCCharList.CharFollower [iAbbadon].attHappiness -= 5;
				NPCCharList.CharFollower [iAbbadon].attObedience += 10;
			}
			endTurnFun ();
			QuestControl.abbadonQuest = 5;
			QuestsController.RemoveID (1004);
			if (QuestControl.albaQuest == 4) {
				Quest HelenaQuest0 = new Quest ();
				QuestsController.createQuest (HelenaQuest0, "Repairs", "With the two bigger Houses backing you, it's time to repair your castle", 13, 3000);
				LawController.RepealLaw (LawController.Get<LawTaxesLow> ());
				LawController.EnactLaw (new LawTaxesNormal ());
			} else {
				LawController.RepealLaw (LawController.Get<LawTaxesVeryLow> ());
				LawController.EnactLaw (new LawTaxesLow ());
			}
			return;
		}

		if (selector == 1 && confirmationControl == 20) {
			WorldControl.day += 6;
			Board.text = "Several days pass before the inaugural game begins. Abbadon, not really content with the choice to host blood sports, is not present. You are glad to be the host today though, as it is a good opportunity to become known to the citizens.\n\nEarlier in the day, a bunch of smaller combats and events were held, getting the crowd ready for the main fight.\n\nWhen you are ready, you give your speech, and everyone is yelling and eager to see the main fight begin. The first team to enter are the people from Abbadon, a group mainly composed by criminals and common hired blades. They don’t look very intimidating, and seem even less so when, across from them, the beasts enter; making fierce, grotesque and vulgar gestures, working the crowd into a frenzy. \n\nThey all walk to the middle of the arena. While the group sponsored by Abbadon bows and salutes you, the beasts growl impatiently, ready to jump on them and have their way. Knowing that you are already testing the discipline of the beasts, you give the signal to begin the fight without any further delay. They immediately jump at one another and, although the soldiers of Abbadon manage keep the beasts at bay for a while, in only ten minutes they find themselves pinned down.\n\nAlthough the beasts are the victors, they pay no attention to you or their trainer, too focused getting the other team naked, rubbing their own naked bodies against the others, and touching, grabbing and sucking them. To the dismay of many in the crowd, the combat rapidly becomes an orgy, with even the hesitant soldiers getting into it; sucking and licking anybody that gets close to them.\n\nYou wonder about sending your own soldiers to take care of them, but the crowd is slowly beginning to cheer for them, and you decide to let them continue the show. After more than an hour passes, they are all covered in fluids, but still going. New spectators begin to join the crowd, eager to watch the show. Eventually, the orgy extends beyond the arena, with many onlookers group fucking each other in the stands.\n\nWhen night falls, your guards eject the few people that remain, and you leave to report to Abbadon. Upon arriving, you can see that he is furious. <i>“"+ GameControl.playerName +"! What are these reports that you just hosted a huge orgy at the Colosseum?! This is not the red district, nor a brothel! Why would you allow something like this happen, and ruin my reputation in the process?!”</i> You try to calm him down, and explain to him that this wasn’t your fault, it’s just that the beasts are hard to tame. <i>“Then why allow them to be there in the first place?! Agh!”</i> He crosses "+  pronhisher +" arms in frustration. In an attempt to cheer him up, you tell him about how many visitors the colosseum had. \n\n<i>“That many? So how much money did you get from this?”</i> After doing some math, you come up with an estimate. <i>“Ngh...”</i> You know he won’t admit it, but the revenue is too good to be ignored. <i>“Fine, I’ll forgive you this time, but in the future, you’ll make sure the beasts don’t go out of control.”</i> When he is done, he smiles at you<i>“You know, I am actually happy that everything is in motion again. It might not be what I had in mind, but it is working well, I really am thankful for you, and I’m glad to have at my side helping me.”</i> ";
			if (NPCCharList.CharFollower [iAbbadon].charLove > 0) {
				Board.text += "\nHe stands up and kisses you. First it is soft and slow, but "+  pronhisher +" passion increases rapidly. <i>“There, that’s a small extra for your help. Tonight I’m really busy, but you can pick up the rest of your booty tomorrow, or whenever else you please.”</i> He gives himself a playful slap on the ass, and winks at you. \n\n<i>“Now, I think that both of us need to rest. You’ll receive your taxes daily from now on, as it should be.”</i> You excuse yourself from "+  pronhisher +" office, and then return home with your guards. ";
			} else {
				Board.text += "\n\n<i>“Now, I think that both of us need to rest. You’ll receive your taxes daily from now on, as it should be.”</i> You excuse yourself from "+  pronhisher +" office, and then return home with your guards. ";
			}

			if (QuestControl.abbadonHelp) {
				NPCCharList.CharFollower [iAbbadon].charLoyalty += 5;
				NPCCharList.CharFollower [iAbbadon].attHappiness -= 5;
				NPCCharList.CharFollower [iAbbadon].attObedience += 10;
			} else {
				NPCCharList.CharFollower [iAbbadon].charRelationship -= 10;
				NPCCharList.CharFollower [iAbbadon].attHappiness -= 20;
				NPCCharList.CharFollower [iAbbadon].attObedience += 20;
			}
			endTurnFun ();
			QuestControl.abbadonQuest = 5;
			QuestsController.RemoveID (1004);
			if(QuestControl.albaQuest == 4){
				Quest HelenaQuest0 = new Quest();
				QuestsController.createQuest(HelenaQuest0, "Repairs", "With the two bigger Houses backing you, it's time to repair your castle", 13, 3000);
				LawController.RepealLaw (LawController.Get<LawTaxesLow> ());
				LawController.EnactLaw (new LawTaxesNormal ());
			} else {
				LawController.RepealLaw (LawController.Get<LawTaxesVeryLow> ());
				LawController.EnactLaw (new LawTaxesLow ());
			}
			return;
		}

		///////////////////////////// temp for help

		if (selector == 0 && confirmationControl == 9999) {
			Board.text = "";

			return;
		}

		if (selector == 1 && confirmationControl == 9999) {
			Board.text = "";

			return;
		}
			
		///////////////////////////// apologize // keep pushing

		if (selector == 0 && confirmationControl == 100) {
			Board.text = "You back down and tell him you were only joking around. He still looks at you with murderous eyes, but he lets your insolence go unpunished. <i>“I understand that you are new to this, and still need to learn a great deal, but if you want to survive, you’ll need to be more refined than this.”</i> he finishes "+  pronhisher +" tea, allowing it to relax him slightly, and asks for another cup.<i>“If you want a role model to follow, you should keep your eye on me. You can even come back in the future for advice if you need it, but the most important thing right now is for you to work on your etiquette.”</i>\n\nYou thank him for "+  pronhisher +" patience, and ask what you could do to be of assistance. He can barely hide the smirk on "+  pronhisher +" face. ";
			Board.text += "\n\n<i>“Now that you’ve agreed to help me, let me tell you about the troubles we’re facing.”</i> He sips "+  pronhisher +" tea elegantly, clearing "+  pronhisher +" throat before continuing. <i>“You see, the city has been in turmoil for the past few years. There is no food, no money, and therefore no order. It is because of this lack of order that some of my properties have been seized by undesirable occupants. They’re merely punks, and should pose no threat to you, I’m sure. ”</i>\n\nYou ask why, if they are so easy to deal with, he hasn’t simply done it himself, nor ordered "+  pronhisher +" guards to do so for him. <i>“Your ignorance is... Never mind, if I haven’t it’s because I only have enough men to protect my house and the surrounding neighborhood, and I cannot risk my security or the security of other noble houses to take care of this. Also, it is not my job to keep this city safe and peaceful, this situation should be handled by anyone who claims to be entitled to the city lordship.”</i> \n\nAlthough you don't agree with him entirely, ridding the streets of crime strikes you as a good idea nonetheless. You accept "+  pronhisher +" task, and tell him that you will take care of the gang. <i>“Don’t worry, you don’t need to take every single one by hand, only their leader, who’s currently living in the Colosseum. A good beating should show them, and the city, that there is a new boss around. Doing this will help to remedy the situation, I’m sure of it.”</i>\n\nAbbadon pauses to eat a sweet pastry, and although you already know what your task is, you may wish to hang around with him for a little while longer and get to know him more. You might even learn something about the city along the way.";
			QuestControl.abbadonHelp = true; 
			option0Name.text = "Hang with Abbadon";
			option1Name.text = "End the meeting";
			confirmationControl = 1;
			NPCCharList.CharFollower [iAbbadon].charRelationship += 10;
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 5;
			QuestControl.abbadonQuest = 1; 
			return;
		}

		if (selector == 1 && confirmationControl == 100) {
			Board.text = "You shake your head and shush him before he can even start "+  pronhisher +" next sentence. You tell him that you know the entire city is in ruins, "+  pronhisher +" house included, and that if you were to promise "+  pronhisher +" territories and titles to other houses, they wouldn’t hesitate for a second before stabbing him in the back. \n\nHe is angry, biting "+  pronhisher +" lip furiously, and almost ripping the leather off "+  pronhisher +" armchair in "+  pronhisher +" rage, but he knows that even if you are powerless, the others are just waiting for any excuse to take him out.The risk is too great for him to ignore. <i>“Fine, what do you want?”</i> he finally gives in. \n\nWith a smile on your face you tell him that he still needs to pay the taxes he owes, including old taxes, but he quickly shakes "+  pronhisher +" head. <i>“Are you dumb? That money doesn’t exist. The whole city is bankrupt. If I can’t get my business running I cannot get you your money, even if I wanted to.”</i> You sigh in disappointment, but all things considered, it’s probably true that "+  pronhisher +" coffers don’t hold the gold needed to pay you. Still, you know that he should have something left to spare, and you ask him for it as a sign of goodwill. <i>“Good will my b... Whatever, I can give you some of the gold now, but you won’t get much from me, or anyone else, if the streets are full of drifters and criminals. Take care of that and I can pay you the rest.”</i>\n\nYou ask why he doesn’t just do it himself. <i>“You id... Look, I don’t have the resources to take care of the whole city, otherwise I would be the one living in that castle, not you. I can take care of a small part of this district, but with the city in disarray I can barely hold the line. You want to be the owner of these lands? Be my fucking guest, but this is no paradise, and if you want to earn more than just crumbs, you’ll have to earn it the same way as anyone else would.”</i>\n\nAbbadon is clearly at "+  pronhisher +" limit, but he’s agreed to pay you some of "+  pronhisher +" debt. You still have to deal with the problems of the city though, but that’s just part of the job.\n\nAlthough it is definitely not appropriate, you could ask him to use <i>something else</i> to pay part of "+  pronhisher +" debt, although you are certain that doing so would not help your future relationship with him. Your threats to take him down are little more than bluffs at this point, and the consequences of doing so could be dire in the future. You could, of course, just finish the meeting and leave with the gold he promised you.";
			option0Name.text = "Ask for more";
			option1Name.text = "End the meeting";
			confirmationControl = 101;
			NPCCharList.CharFollower [iAbbadon].charRelationship -= 10;
			NPCCharList.CharFollower [iAbbadon].charLoyalty -= 5;
			return;
		}



		///////////////////////////// ask for more // coerce end

		if (selector == 0 && confirmationControl == 101) {
			Board.text = "You walk to Abbadon’s side. He looks at you, both angry and confused <i>“What do you want now?”</i> you grab "+  pronhisher +" should and tell him that you had come here for what is owe to you, and that if he can’t pay with gold, there are other ways.\n\nAbbadon looks at you and smile, and you are compelled to return the gesture, but when you close your eyes you can feel hot tea burning your face. <i>“Are you out of your mind, "+ GameControl.playerName +"?”</i> you need to take step back and clean your face. <i>“Now you listen clearly, I already agreed to give you some of the money even if you have done nothing to own it, next time you try something like this I’ll get your sterilized. Now get ready to leave my property, or I’ll send the guards.”</i>\n\nAbbadon leaves the place while you recover from "+  pronhisher +" reaction. Minutes later a servant brings you a bag with 300 gold coins. \n\nAs you leave, you walk close to the Colosseum, and you can see several bands of drifters around there. They don't look particularly dangerous, at least not more than the beasts outside, but they are definitely creating a mess and stopping any chance of resurrecting this commercial and touristic district. \n\nAlmost all of them are just hanging around, trying to get by, but there is a small group that looks to be in charge. The busiest place is the Colosseum, where is obvious that the most dangerous group lives. You should go there later and confront their leader on a duel, a show of force will surely put most of these people in place and earn you some respect.";
			GameControl.charGold += 300; 
			NPCCharList.CharFollower [iAbbadon].charRelationship -= 10;
			NPCCharList.CharFollower [iAbbadon].charLoyalty -= 5;
			NPCCharList.CharFollower [iAbbadon].charLove -= 10;
			GameControl.attAlignment -= 4;
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 101) {
			GameControl.charGold += 300; 
			endTurnFun ();
			Board.text = "You got what you could, no point on pushing the issue further. You tell him that’ll be all and without even looking back Abbadon turns around and leaves the room, angry. Minutes later a servant brings you a bag with 300 gold coins. \n\nAs you leave, you walk close to the Colosseum, and you can see several bands of drifters around there. They don't look particularly dangerous, at least not more than the beasts outside, but they are definitely creating a mess and stopping any chance of resurrecting this commercial and touristic district. \n\nAlmost all of them are just hanging around, trying to get by, but there is a small group that looks to be in charge. The busiest place is the Colosseum, where is obvious that the most powerful group lives. You should go there later and confront their leader and take care of it, a show of force will surely put most of these people in place and earn you some respect.";
			return;
		}


		///////////////////////////// deal / kill

		if (selector == 0 && confirmationControl == 102) {
			Board.text = "Having decided to give them a chance, you patiently listen to their pleas. They tell you that most of them were farmers, or people living on the outskirts of the city, who were forced to migrate due to the rising beast population. They have been looking for jobs since they arrived, but the economy is stagnant thanks to the lack of trade and tourism, and all of the noble houses have turned them down.\n\nIt is difficult to come up with many solutions to their problem. Abbadon is struggling, but you could force him to take them under "+  pronhisher +" protection, providing them with accommodation, food, and water in exchange for work, at least until he can afford to pay their wages. They don’t seem very pleased with the idea, as they believe it to be dangerously close to slavery, but you tell them that the situation would be temporary, and that wages would be paid once the economic situation of the city improves.\n\nYou could also just force them out of this district. They have few places to go, and you expect them to take streets, parks, and other abandoned buildings. It would reduce the crime in this district, but overall things would be worse around the rest of the city. \n\nOne last thing you could do is to take them under your own protection. With an initial 200G you think you could afford enough tools, food and accommodation for them. Their loyalty and happiness would increase significantly, and you could put them to work in repairing and maintaining the city.\n\nAfter several hours of deliberation and discussion, you finally decide to...\n";
			option0Name.text = "Send to Abbadon";
			option1Name.text = "To the streets!";
			option2Name.text = "Hire them";
			confirmationControl = 103; 
			if (GameControl.charGold >= 200) {
				option2Butt.interactable = true;
			}
			return;
		}

		if (selector == 1 && confirmationControl == 102) {
			Board.text = "Without hesitation you pull out your weapon, and deliver a fatal blow. The old man falls dead to the ground, and you turn to face the crowd. Your bloody weapon still in hand, you tell them that this type of behavior will not be tolerated in the future, and that they will abide by the law and follow your word, lest they let the same fate befall the rest of them. The silence of the place is interrupted only by sobs, and the desperate coughs of the sick.\n\nYou raise your voice and tell them to leave, immediately. Demoralized and browbeaten, the crowd slowly turns around, and walks pitifully through the exit. \n\nWhere they would go is a mystery at first, but later that day you find that most of them have settled in parks, streets and other public spaces. Some have even taken the risk to leave the city, where they will likely end up as unfortunate additions to the monsters’ ranks. \n\nWhen you are done you pay a visit to Abbadon, who isn’t happy to see you. You explain to him that you decided to take care of the drifters living in the Colosseum, freeing the streets of the district from their unwanted presence. <i>“Is that so? A servant told me rumors about it. Bad rumors.”</i> he crosses "+  pronhisher +" arms and steps back <i>“Well, I suppose that what’s done is done. Clearing the streets will help me to get my business going again.”</i>\n\nAbbadon excuses himself for a minute and comes back with a small bag of 100 gold coins. <i>“Take this as a token of gratitude "+ GameControl.playerName + ". If you want my advice, you’ll be needing a captain of the guard very soon, or the drifters may return, or even riot. If you are smart, you will use this gold to pay for soldiers and equipment, but you’ll still need to look for someone talented to take on the position as captain. Since there are very few good warriors in the city, and most of them will either be unavailable, or simply uninterested in the job, you’re going to have your work cut out for you.”</i>\n\n<i>“Now, I have some matters to attend to, so please excuse me "+ GameControl.playerName + ". We can continue this conversation another time.”</i> He leaves you alone in the living room, and you return to your castle, using the journey to think about potential candidates for the role of captain of the guard.\n";
			NPCCharList.CharFollower [iAbbadon].charRelationship += 5;
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 5;
			CityControl.city100Happiness -= 15;
			CityControl.city100Order += 5;
			CityControl.city100Prosperity += 3f; 
			QuestControl.abbadonQuest = 2;
			Quest AbbadonQuest3 = new Quest ();
			QuestsController.RemoveID (1001);
			QuestsController.createQuest (AbbadonQuest3, "Hunting talent", "You need to find someone to patroll and protect the district, to keep order and peace.", 14, 1002);
			GameControl.charGold += 100; 
			GameControl.attAlignment -= 2;
			endTurnFun ();
			return;
		}


		///////////////////////////// abbadon / streets / you

		if (selector == 0 && confirmationControl == 103) {
			Board.text = "Well, if they are living in Abbadon’s district, they are definitely "+  pronhisher +" responsibility. You inform them that you’ll talk with Abbadon, and that he will take care of their accommodation and survival. The type of work they end up doing will be beyond your control.\n\nThey crowd has a mixture of reactions. Some of them cheer, and are happy with this solution. Others seem far less eager. Nevertheless, the old man agrees and most, if not all of the crowd will follow "+  pronhisher +" command.\n\nYou leave the place to visit Abbadon and talk to him about what you just did. When you tell him, he yells at you in frustration. <i>“Why?! Why would you do this?! And without even asking me first?! Come on "+ GameControl.playerName + ", what I am supposed to do with an army of useless drifters?”</i> he rubs "+  pronhisher +" temples, trying to figure out what to do next. <i>“Ngh... I guess I have no choice, if I don’t want them rioting across my district. I’ll deal with them, but this will cost me money, and your taxes will be lowered as a result,  just so you know.”</i>\n\nYou nod in acknowledgement. So long as the district is working again, any taxes are better than no taxes. You want to talk about other matters, but he shakes "+  pronhisher +" head. <i>“No, I have to many things to figure out now, just leave me alone.”</i> You shrug, ready to go, but he stops you. <i>“Oh right... before you leave "+ GameControl.playerName + ", let me give you some advice. Appoint a captain of the guard, or crime will stay high throughout the whole city. This is an issue you need to tackle as soon as you can. It’s gonna be hard, as there are very few good warriors left in the city, and most of them wouldn’t be interested in a job like this. You’ll figure it out, I’m sure. Take this, you may need it.”</i> as a token of gratitude, he gives you a bag of 100 gold coins. \n\nWith those last words, he turns around and leaves you alone in the living room. \n";
			NPCCharList.CharFollower [iAbbadon].charRelationship -= 5;
			NPCCharList.CharFollower [iAbbadon].charLoyalty -= 0;
			CityControl.city100Happiness += 5;
			CityControl.city100Order += 5;
			CityControl.city100Prosperity += 1.5f; 
			QuestControl.abbadonQuest = 2;
			Quest AbbadonQuest3 = new Quest ();
			QuestsController.RemoveID (1001);
			QuestsController.createQuest (AbbadonQuest3, "Hunting talent", "You need to find someone to patroll and protect the district, to keep order and peace.", 14, 1002);
			GameControl.charGold += 100; 
			GameControl.attAlignment += 1;
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 103) {
			Board.text = "You tell them that in order to help them, the city needs to earn money, and in their current location, they only serve to make such a thing more difficult. You can see them losing hope, but the old man slowly nods, disappointed but understanding. He and the crowd gather up their belongings, and leave the place.\n\nAs you’d expected, most of them settle in parks, streets and other public spaces. Some, however, take on the risk of leaving the city, where they will likely end up as unfortunate additions to the monsters’ ranks. \n\nYou leave the place to visit Abbadon and talk to him about what you just did. He seems relieved by the news . <i>“Very well, you took care of it. I hope they don’t cause much trouble out there, but now I can start working on the renovations.”</i> He looks pleased, although you still sense some resentment. <i>“Once everything is in working order, you’ll receive your taxes. Don't expect a fortune, but it should help you to rebuild the city.”</i>\n\nYou nod in acknowledgement. So long as the district is working again, any taxes are better than no taxes. You want to talk about other matters, but he shakes "+  pronhisher +" head. <i>“No, I have to many things to figure out now, just leave me alone.”</i> You shrug, ready to go, but he stops you. <i>“Oh right... before you leave "+ GameControl.playerName + ", let me give you some advice. Appoint a captain of the guard, or crime will stay high throughout the whole city. This is an issue you need to tackle as soon as you can. It’s gonna be hard, as there are very few good warriors left in the city, and most of them wouldn’t be interested in a job like this. You’ll figure it out, I’m sure. Take this, you may need it.”</i> as a token of gratitude, he gives you a bag of 100 gold coins. \n\nWith those last words, he turns around and leaves you alone in the living room. \n\n";
			NPCCharList.CharFollower [iAbbadon].charRelationship += 5;
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 5;
			CityControl.city100Happiness -= 10;
			CityControl.city100Order += 5;
			CityControl.city100Prosperity += 3f; 
			QuestControl.abbadonQuest = 2;
			Quest AbbadonQuest3 = new Quest ();
			QuestsController.RemoveID (1001);
			QuestsController.createQuest (AbbadonQuest3, "Hunting talent", "You need to find someone to patroll and protect the district, to keep order and peace.", 14, 1002);
			GameControl.charGold += 100; 
			GameControl.attAlignment -= 1;
			endTurnFun ();
			return;
		}


		if (selector == 2 && confirmationControl == 103) {
			Board.text = "You tell them that you’ll take care of them, and will provide them with tools, food and jobs. Many of them cheer, although some don’t sound too eager to work for you after what you just did to one of their people.\n\nThey start to leave to settle outside of your castle, while those unhappy with the deal either go to the parks, or take a risk and leave the city. Those outside the city will likely end up as unfortunate additions to the monster ranks.\n\nOnce you’ve given all the instructions needed to the old man, you go back to Abbadon’s place to pay him a visit and talk about your actions. He looks relieved with the news. <i>“Very well, you took care of it, and you even took on some responsibility. At the very least, that deserves praise. I hope they don’t cause much trouble out there, but now I can start working on the renovations.”</i> He looks pleased, although you still sense some resentment. <i>“Once everything is in working order, you’ll receive your taxes. Don't expect a fortune, but it should help you to rebuild the city.”</i>\n\nYou nod in acknowledgement. So long as the district is working again, any taxes are better than no taxes. You want to talk about other matters, but he shakes "+  pronhisher +" head. <i>“No, I have to many things to figure out now, just leave me alone.”</i> You shrug, ready to go, but he stops you. <i>“Oh right... before you leave "+ GameControl.playerName + ", let me give you some advice. Appoint a captain of the guard, or crime will stay high throughout the whole city. This is an issue you need to tackle as soon as you can. It’s gonna be hard, as there are very few good warriors left in the city, and most of them wouldn’t be interested in a job like this. You’ll figure it out, I’m sure. Take this, you may need it.”</i> as a token of gratitude, he gives you a bag of 100 gold coins. \n\nWith those last words, he turns around and leaves you alone in the living room. \n";
			NPCCharList.CharFollower [iAbbadon].charRelationship += 5;
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 5;
			CityControl.city100Happiness += 10;
			CityControl.city100Order += 10;
			CityControl.city100Prosperity += 1.5f; 
			QuestControl.abbadonQuest = 2;
			Quest AbbadonQuest3 = new Quest ();
			QuestsController.RemoveID (1001);
			QuestsController.createQuest (AbbadonQuest3, "Hunting talent", "You need to find someone to patroll and protect the district, to keep order and peace.", 14, 1002);
			GameControl.charGold -= 100; 
			GameControl.attAlignment += 3;
			endTurnFun ();
			return;
		}

		///////////////////////////// Arts / Sport

		if (selector == 0 && confirmationControl == 104) {
			Board.text = "<i>“That’s great "+ GameControl.playerName +", I’m glad you support my idea. But now we need to talk about funding, and your part in it. The city has always invested, and helped out with the development of the districts. If you invest heavily in my district, I can promise that you’ll see better results, although revenue will be reduced, and you should expect less profit in return. You could just spend the bare minimum to get things running, but as you can imagine, that’s not an idea that thrills me.”</i> \n\nHe goes into great detail about how a bigger investment would more significantly impact on the education and infrastructure of the city, therefore improving happiness too, but also explaining that the cost would be higher, and profits would be lower as a result.  <i>“The city needs changes and improvements, and I believe that this is an opportunity to invest in our future, not to be greedy.”</i>\n\nHe continues to push "+  pronhisher +" agenda for a while, until finally it is time for you to decide. Should you invest heavily in this project, or just the minimum amount that is required to fund it?";
			option0Name.text = "High investment";
			option1Name.text = "Low investment";
			confirmationControl = 105; 

			return;
		}

		if (selector == 1 && confirmationControl == 104) {
			Board.text = "Abbadon is clearly disgusted by your choice in putting profit over restoration, but he doesn’t fight you on it. <i>“It’s not that I can’t see the reasons behind your choice "+ GameControl.playerName +", but I must admit that I’m not entirely happy about it. Still, the district and city will need funding in order heal, so I won’t argue with you. Now, for the next matter of the day, how much funding do you want to allocate to this project? The more you do, the bigger its impact on the city will, but at the same time you should expect less in the way of profit. Will you invest heavily in this project, or just the bare minimum required to get things running?”</i> \n\nHe goes into great detail about how a bigger investment would more significantly impact on the education and infrastructure of the city, therefore improving happiness too, but also explaining that the cost would be higher, and profits would be lower as a result.  <i>“The city needs changes and improvements, and I believe that this is an opportunity to invest in our future, not to be greedy.”</i>\n\nHe continues to push "+  pronhisher +" agenda for a while, until finally it is time for you to decide. Should you invest heavily in this project, or just the minimum amount that is required to fund it?";
			option0Name.text = "High investment";
			option1Name.text = "Low investment";
			confirmationControl = 106; 
			return;
		}




		///////////////////////////// Art high / low inv 

		if (selector == 0 && confirmationControl == 105) {
			Board.text = "You see Abbadon smile for the first time since meeting him. <i>“Good choice "+ GameControl.playerName +", you’ve earn some of my respect for that.  I’ll be sure to take care of all of the coordination. It will take some time to get everything running, but now that I have the security and knowledge that my business will be producing again, I can repay all that I owe you. Please excuse me for a moment.”</i>\n\nHe steps away and talk with "+  pronhisher +" servants and guards. In a matter of minutes they return carrying a small coffer. Abbadon opens it, and you can see that it’s full of gold coins. <i>“This coffer holds 2000 gold coins; what was promised to you. I’ll be sure to recommend you to the other houses in the city, and you will have my support in future matters. Please, just don’t go crazy like your late uncle.”</i>\n\n<i>“Now If you’ll excuse me, "+ GameControl.playerName +", I have to take care of many things to take care of... although there is still one thing you can do to help me out. Why you don’t pick the show for the premier? I am certain you’ll make a delightful choice for that night. Take this task as an honor, not as a job.”</i> With a bright smile he excuses himself and leaves. Shortly afterwards, a servant tells you that a caravan carrying the gold is ready to depart. You accompany them in order to ensure the gold arrives safely at your vault.";
			GameControl.charGold += 2000;
			QuestControl.abbadonQuest = 4;
			Quest AbbadonQuest5 = new Quest ();
			QuestsController.RemoveID (1003);
			QuestsController.createQuest (AbbadonQuest5, "The premier", "Abbadon has given you the honour to select those who will perform in the premier.", 14, 1004);
			CityControl.city100Infrastructure += 15;
			CityControl.city100Education += 15;
			CityControl.city100Happiness += 15;
			CityControl.city100Prosperity += 2.5f; 
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 15;
			NPCCharList.CharFollower [iAbbadon].charRelationship += 15;
			endTurnFun ();
			LawController.EnactLaw (new LawArtsHigh());

			return;
		}

		if (selector == 1 && confirmationControl == 105) {
			Board.text = "Abbadon sighs with disappointment, but is not surprised by your choice. <i>“I’ll be sure take care of all of the coordination. You will see this place running soon, but for now I’ll give you what I owe you. Please excuse me for a moment.”</i>\n\nHe steps away and talk with "+  pronhisher +" servants and guards, and leave the living room. In short notice they come back with a small coffer. When Abbadon opens it, you can see its full of gold coins. <i>“This coffer holds 2000 gold coins; what was promised to you. I’ll be sure to recommend you to the other houses in the city, and you will have my support in future matters. As long as you don’t go crazy like your late uncle, everything will be fine.”</i>\n\n<i>“Now if you’d excuse me "+ GameControl.playerName +", I have many things to take care of...”</i> Before he leaves the room, you grab "+  pronhisher +" arm and tell him that you have one request to make of him. <i>“A request? And what that would be?”</i> You tell him that you want to pick which show plays at the premier. He doesn’t looks happy, but nods. <i>“Be my guest, I’m sure your pick will be delightful.”</i> "+pronhisher +" tone drips with sarcasm, and he quickly leaves. You wonder if he will even bother to see the play you pick.\n\n";
			GameControl.charGold += 2000;
			CityControl.city100Infrastructure += 7.5f;
			CityControl.city100Education += 7.5f;
			CityControl.city100Happiness += 7.5f;
			CityControl.city100Prosperity += 5; 
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 7;
			NPCCharList.CharFollower [iAbbadon].charRelationship += 7;
			QuestControl.abbadonQuest = 4;
			Quest AbbadonQuest5 = new Quest ();
			QuestsController.RemoveID (1003);
			QuestsController.createQuest (AbbadonQuest5, "The premier", "Abbadon has given you the honour to select those who will perform in the premier.", 14, 1004);
			endTurnFun ();
			LawController.EnactLaw (new LawArtsLow());

			return;
		}


		///////////////////////////// sport high low inv

		if (selector == 0 && confirmationControl == 106) {
			NPCCharList.CharFollower [iAbbadon].charLoyalty -= 2.5f;
			NPCCharList.CharFollower [iAbbadon].charRelationship -= 2.5f;
			confirmationControl = 15;
			confirmFun (0);
			LawController.EnactLaw (new LawSportsHigh());
			return;
		}

		if (selector == 1 && confirmationControl == 106) {
			NPCCharList.CharFollower [iAbbadon].charLoyalty -= 2.5f;
			NPCCharList.CharFollower [iAbbadon].charRelationship -= 2.5f;
			confirmationControl = 15;
			confirmFun (1);
			LawController.EnactLaw (new LawSportsLow());

			return;
		}


		///////////////////////////// ballet / oppereta

		if (selector == 0 && confirmationControl == 107) {
			Board.text = "A week from your choosing, they have finally prepared the stage for the first private demonstration to you.\n\nYou have a long chat with the team, who eagerly thank you for giving them chance to put their skills on display in Aurorum, as moving to a new city at this time is almost impossible. You comfort them by saying that Aurorum is very lucky to have them, and if the show is a success they can expect to have a prolific future under the protection of Abbadon. They all bow to you and thank you again. \n\nWithout further delay, they leave to get ready for the show. Shortly after the music starts, the group composed of both handsome men and beautiful women appear on stage. As you expected, the show is a true display of elegance and skill; a smooth, romantic, but fun story utilising the traditional folklore of the island. Although it’s probably not as livid and entertaining as the operetta, the choreography is well incredible, and you don’t doubt that it will be a success. \n\nHalf way through it, watching their gorgeous bodies float in the air and jiggle, their erotic movements and beautiful bodies begin to arouse you.\n\nFinally there is an interlude, and while most of the crew goes backstage to rest, you can see one of the dancers, a beautiful bunny girl, with brunette hair and dark eyes, with full lips and a gorgeous and toned figure is walking towards you.  <i>“"+ GameControl.playerName +" right? Would you mind if the two of us have a... private chat? It won’t take long...”</i>\n\nShould you take a break with her and blow off some steam? Or reject her and see the rest of the play undisturbed? \n";
			option0Name.text = "Blow steam";
			option1Name.text = "Reject her";
			confirmationControl = 108; 
			return;
		}

		if (selector == 1 && confirmationControl == 107) {
			confirmationControl = 16;
			confirmFun (1);
			return;
		}



		///////////////////////////// Blow steam / reject girl 

		if (selector == 0 && confirmationControl == 108) {
			Board.text = "You stand up, ready to follow her. She smirks, delighted about having a close encounter with such an important person as yourself. <i>“Let’s go to my dressing room, we’ll have some privacy there.”</i> \n\nShe grabs your hand and guides you to her room, a very small place that contains the bare minimum, though you are thankful that at least it has a bed. <i>“Not as impressive as your castle, but it’s all we can afford.”</i> she sits on the bed, which squeaks a lot under her body weight. <i>“It’s awful, but at least we can be noisy.”</i>\n\nNow that you have a closer look at her, you can glimpse her hard nipples through her white leotard. <i>“Do you like it? Everyone here does...”</i> you sit at her side and grab her neck, pulling her further into you. She doesn’t try to resist, and eagerly welcomes your tongue when you kiss her. \n\nYou explore her soft body while her lips close around your own, sucking on your tongue. You bite her lip and she gasps, shivering in excitement. <i>“Enough child's play...”</i> she softly pushes you and sits on top of you, and slowly removes her leotard, showing off her fair skin. She covers her breasts first, and laughs when you try to push her arms away. <i>“Don’t be so desperate, my Liege.”</i> smiling, she finally reveals her secrets to you. \n\nShe lies on top of you, her breasts just inches away from your face, and on impulse you push your face against them, taking them in your mouth, passionately sucking them. <i>“Ahh... You really like them...”</i> she purrs. While you are fixated on her breasts, you feel her small hands removing your own cloths. \n\nYou feel her warm body against yours, both of you craving each other. Her body tenses as she feels your hands traveling from her back to her derrière. She pushes her body towards yours, begging you to go further. You grab her firm rear end and play with it, until you venture deeper and find her wet place, twitching impatiently for you.\n\n";
			if (GameControl.dick1Size > 0) {
				Board.text += "You put your hands on her hips while she grabs your member. With your head ready at her entrance, you can feel her knees giving in as your member is embraced by her tight pussy. <i>“Mmhh...”</i> she moans when you are fully inside her, and she pauses for a second, getting used to your shape before moving up again.\n\nShe starts to ride you with the same passion she has for her art while you play with her breasts, her hair flying wildly around her face. She gives up at her first attempt to be quiet, and soon the noise of the bed and her groans of pleasure echo throughout the entire theater. \n\nAfter minutes of passion, both of you are covered in sweat and fluids, and you can feel her body shivering, close to orgasm. With an impulsive gesture, she moves down on you, assaulting your mouth as her whole body jolts with waves of pleasure. As you get closer, you start to pound her with increased fervor. The feeling of her body clenching against you is too much to resist, and you finish, shooting all your load inside her. \n\nAfter a long moment of pleasure the two of you are done, though she stays on top of you until you finally go soft again. <i>“Amazing my liege... you are truly deserving of your throne...”</i>\n\nWhen the two of you recover, you hastily dress again and go back to your places. Of course, the play starts late, but no one dares to comment on what just happened. \n\nDuring the play, you can see your seed dripping and staining her leotard, but she continues to dance and move proudly around, happy to show off her prize to her colleagues. ";
			} else {
				Board.text += "<i>“Let me help you out...”</i> from the side of the bed, she takes out a strap, upon which sits a very generous toy. <i>“I’m not easy to please, you see...”</i> she helps you out, making sure you are wearing it properly before sitting on top of you again.\n\nYou put your hands on her hips while she grabs the member you are wearing. With your head ready at her entrance, you can feel her knees giving in as your member is embraced by her tight pussy. <i>“Mmhh...”</i> she moans when you are fully inside her, and she pauses for a second, getting used to your shape before moving up again.\n\nShe starts to ride you with the same passion she has for her art while you play with her breasts, her hair flying wildly around her face. She gives up at her first attempt to be quiet, and soon the noise of the bed and her groans of pleasure echo throughout the entire theater. \n\nAfter minutes of passion, both of you are covered in sweat and fluids, and you can feel her body shivering, close to orgasm. With an impulsive gesture, she moves down on you, assaulting your mouth as her whole body jolts with waves of pleasure. As you get closer, you start to pound her with increased fervor. The feeling of her body clenching against you is too much to resist, and you give in to the bliss.\n\nAfter a long moment of pleasure the two of you are done, though she stays on top of you until you finally go soft again. <i>“Amazing my liege... you are truly deserving of your throne...”</i>\n\nWhen the two of you recover, you hastily dress again and go back to your places. Of course, the play starts late, but no one dares to comment on what just happened. \n\nHer tousled hair, and disordered make-up are a fun contrast to the rest of the crew, but you can see that she is proud of what she did, and is not ashamed to show that off to her colleagues. \n\n";
			}
			Board.text += "After the demonstration, you go back to Abbadon, who is happy about your choice. <i>“"+ GameControl.playerName +"! I should say you have a great eye for this! I heard all about the performance. This is something the city needed, I’m sure it’s gonna be a hit.”</i> he shakes your hand <i>“I’m glad you took care of this, now the city will have access to great entertainment again. Things are changing for the better, you should keep it up. Once the play premiers, I’ll start paying my taxes again.”</i>\n\nFive days later the show premiers, and the elites of the city love it. The poorest and middle class of the city ignore it altogether, as the ticket prices are too high, and the show wasn’t to their taste.\n\n A week after the premier, the show continues to fill the theater with noblemen, and Abbadon decides to hire this group and composer to produce more scripts and plays.\n\n<i>“I’m loving this show, and you’ve really reinvigorated this district, I thank you for that.”</i> He invites you to "+  pronhisher +" study to arrange the future payments of "+  pronhisher +" house.\n\n<i>“You know, in the end you did a great job. Whether I like it or not, things are changing for the better. I said it before, and I will say it again, you have my support if you ever need it. Now that my family business is alive again, there is a lot of work for me to do, but please feel free to visit me, I won’t mind taking time off to hang with you.”</i>";
			WorldControl.day += 12;
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 10;
			NPCCharList.CharFollower [iAbbadon].attHappiness+= 10;
			NPCCharList.CharFollower [iAbbadon].charRelationship += 5;
			QuestsController.RemoveID (1004);
			if(QuestControl.albaQuest == 4){
				Quest HelenaQuest0 = new Quest();
				QuestsController.createQuest(HelenaQuest0, "Repairs", "With the two bigger Houses backing you, it's time to repair your castle", 13, 3000);
				LawController.RepealLaw (LawController.Get<LawTaxesLow> ());
				LawController.EnactLaw (new LawTaxesNormal ());
			} else {
				LawController.RepealLaw (LawController.Get<LawTaxesVeryLow> ());
				LawController.EnactLaw (new LawTaxesLow ());
			}
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 108) {
			WorldControl.day += 12;
			Board.text = "You thank him for "+  pronhisher +" offer, but you pass <i>Oh, that’s a shame.“”</i> he shrugs and leaves back stage with the rest of the crew. \n\nThe play continues as planned, and nothing else of interest happens before it ends.\n\nAfter the demonstration, you go back to Abbadon, who is happy about your choice. <i>“"+ GameControl.playerName +"! I should say you have a great eye for this! I heard all about the performance. This is something the city needed, I’m sure it’s gonna be a hit.”</i> he shakes your hand <i>“I’m glad you took care of this, now the city will have access to great entertainment again. Things are changing for the better, you should keep it up. Once the play premiers, I’ll start paying my taxes again.”</i>\n\nFive days later the show premiers, and the elites of the city love it. The poorest and middle class of the city ignore it altogether, as the ticket prices are too high, and the show wasn’t to their taste.\n\n A week after the premier, the show continues to fill the theater with noblemen, and Abbadon decides to hire this group and composer to produce more scripts and plays.\n\n<i>“I’m loving this show, and you’ve really reinvigorated this district, I thank you for that.”</i> He invites you to "+  pronhisher +" study to arrange the future payments of "+  pronhisher +" house.\n\n<i>“You know, in the end you did a great job. Whether I like it or not, things are changing for the better. I said it before, and I will say it again, you have my support if you ever need it. Now that my family business is alive again, there is a lot of work for me to do, but please feel free to visit me, I won’t mind taking time off to hang with you.”</i>";
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 10;
			NPCCharList.CharFollower [iAbbadon].attHappiness+= 10;
			NPCCharList.CharFollower [iAbbadon].charRelationship += 5;
			QuestsController.RemoveID (1004);
			if(QuestControl.albaQuest == 4){
				Quest HelenaQuest0 = new Quest();
				QuestsController.createQuest(HelenaQuest0, "Repairs", "With the two bigger Houses backing you, it's time to repair your castle", 13, 3000);
				LawController.RepealLaw (LawController.Get<LawTaxesLow> ());
				LawController.EnactLaw (new LawTaxesNormal ());
			} else {
				LawController.RepealLaw (LawController.Get<LawTaxesVeryLow> ());
				LawController.EnactLaw (new LawTaxesLow ());
			}
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
	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


	void loadHelenaData(){
		iHelena = 0;

		while (iHelena < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iHelena].charID >= 3000 && NPCCharList.CharFollower [iHelena].charID < 4000){
				break; 
			}
			iHelena++;

		}

	}





	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void abbadonWelcome(){

		Board.text = "You see Abbadon minding "+ pronhimher +" own business. ";

	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	public void BeastQuest(){ 
		if (QuestControl.abbadonQuest == 10) {
			Board.text = "You now have unlocked the quest to transform Abbadon into "+ pronhisher +" inner beast!";

			QuestControl.abbadonQuest = 11;
			Quest AbbadonQuest11 = new Quest ();
			//QuestsController.RemoveID (1001);
			QuestsController.createQuest (AbbadonQuest11, "New horizons", "It's time to advance with the next step of your experiments!.", 61, 1011);
			endTurnFun ();
			return;
		}

		if (QuestControl.abbadonQuest < 16) {
			Board.text = "You are already in the process of changing Abbadon! check your quest log!";
			return;
		} else {
			Board.text = "You've already finished transforming Abbadon!";
			return;
		}



	}


	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	public void abbadonGenderSelector(int selector){
		if (selector == 0) {
			Board.text = "What? You want to use feminine pronouns with me? Very well, go ahead.";
			NPCCharList.CharFollower [iAbbadon].charGender = NPCData.CharGender.FEMALE;
		} else {
			Board.text = "What? You want to use masculine pronouns with me? Very well, go ahead.";
			NPCCharList.CharFollower [iAbbadon].charGender = NPCData.CharGender.MALE;

		}
	}

	public void abbadonMenuMessages(int selector){
		if (selector == 0) {
			//gender
			Board.text = "Do you want to ask Abbadon to change the pronouns that "+ pronheshe+" uses?";
		}
	}

	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	void charVirginity(){

		if(GameControl.isVirgin == true){
			Board.text += "\n\nYour character lost its virginity!";
			GameControl.isVirgin = false; 
		}

	}

	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void loadAbbadon(){

		iAbbadon = 0;
		while (iAbbadon < NPCCharList.CharFollower.Count) {
			if (NPCCharList.CharFollower [iAbbadon].charID >= 1000 && NPCCharList.CharFollower [iAbbadon].charID < 2000) {
				WorldControl.NPCID = NPCCharList.CharFollower [iAbbadon].charID;
				WorldControl.PortraitIDLayer0 = NPCCharList.CharFollower [iAbbadon].charPortraitLayer0;
				WorldControl.PortraitIDLayer1 = NPCCharList.CharFollower [iAbbadon].charPortraitLayer1;
				WorldControl.PortraitIDLayer2 = NPCCharList.CharFollower [iAbbadon].charPortraitLayer2;
				WorldControl.furryPic = NPCCharList.CharFollower [iAbbadon].isFurry;
				WorldControl.futaPic = NPCCharList.CharFollower [iAbbadon].isFuta;
				break; 
			}

			iAbbadon++;
		}

	}

	void loadAlba(){
		iAlba = 0;
		while (iAlba < NPCCharList.CharFollower.Count) {
			if (NPCCharList.CharFollower [iAlba].charID == 13000) {
				break; 
			}
			iAlba++;
		}

	}



	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		panEndTurn.sortingOrder = 500;
		mainPanel.sortingOrder = -500;
		panConfirmation.sortingOrder = -500;

	}

	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void cleanNeutralRetainers(){
		foreach (NPCData npcdata in NPCCharList.CharRetainers){
			if (npcdata.isRecruited == false) {
				NPCCharList.CharRetainers.Remove (npcdata);
			}

		}
	}





	void Awake(){

		loadAbbadon ();
		loadAlba ();
		//// portrait




		//load abbadon pronouns
		if (NPCCharList.CharFollower [iAbbadon].charGender == NPCData.CharGender.MALE) {
			pronheshe = "he";
			pronhimher = "him";
			pronhisher = "his";
		} else {
			pronheshe = "she";
			pronhimher = "her";
			pronhisher = "her";
		}


		if (GameControl.mcGender == GameControl.MCGender.FEMALE) {
			//mcpronoun = "Lady";
			//mcpronSonDau = "daughter";

		} else {
			//mcpronoun = "Lord"; 
			//mcpronSonDau = "son";
		}

		if (NPCCharList.CharFollower [iAbbadon].charCorruption < 80) {
			buttOutfitCorrupt1.interactable = false;
		}
		if (NPCCharList.CharFollower [iAbbadon].charCorruption < 100) {
			buttOutfitNaked.interactable = false; 
		}
		if (QuestControl.abbadonQuest  < 10) {
			buttItems.interactable = false; 
			buttBeastTransformation.interactable = false; 
			textBeastTransformation.text = "";
		}


		/*
		buttScene2.interactable = false; 
		if (NPCCharList.CharFollower[iAbbadon].charLove >= 35 || NPCCharList.CharFollower[iAbbadon].corruptionStage >= 2  ) {
			buttScene2.interactable = true; 
		}

		buttScene3.interactable = false; 
		if (NPCCharList.CharFollower[iAbbadon].charLove >= 60 || NPCCharList.CharFollower[iAbbadon].corruptionStage >= 3  ) {
			buttScene3.interactable = true; 
		}

		buttScene4.interactable = false; 
		if (NPCCharList.CharFollower[iAbbadon].charLove >= 85 || NPCCharList.CharFollower[iAbbadon].corruptionStage >= 4  ) {
			buttScene4.interactable = true; 
		}

		buttScene5.interactable = false; 
		buttScene6.interactable = false; 
		if (NPCCharList.CharFollower[iAbbadon].charLove >= 100 || NPCCharList.CharFollower[iAbbadon].corruptionStage >= 4  ) {
			buttScene5.interactable = true; 
			buttScene6.interactable = true; 
		}

		*/

		option0Name.text = ""; 
		option1Name.text = "";
		option2Name.text = "";

		option2Butt.interactable = true; 
		option2Butt.interactable = false; 
		abbadonStart ();

		if (QuestControl.abbadonQuest < 10) {
			buttGender.interactable = false; 
		}


	}



}
