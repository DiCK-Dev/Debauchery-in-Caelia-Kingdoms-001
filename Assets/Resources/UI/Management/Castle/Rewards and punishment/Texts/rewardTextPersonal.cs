using UnityEngine;
using System.Collections;

public class rewardTextPersonal  {



	public static string sceneText(int selector){
		string toReturn = ""; 
		float randNum = Random.Range(0f, 100f);
		string heshe = "he", hisher = "his", himher = "him", HESHE = "He", HISHER = "His", HIMHER = "Him"; 
		if (NPCCharList.CharFollower [WorldControl.idx].charGender == NPCData.CharGender.FEMALE) {
			heshe = "she"; hisher = "her"; himher = "her"; HESHE = "She"; HISHER = "Her"; HIMHER = "Her"; 
		}

		switch (selector) {
		case 0:
			toReturn = "You have scheduled a meeting with "+ NPCCharList.CharFollower [WorldControl.idx].charName +" since "+ heshe +" has earned a reward. They arrive promptly and ask "+ himher +" to take a seat on the couch.\n\nYou sit down once "+ heshe +" has taken "+ hisher +" seat, making yourself comfortable before telling "+ himher +" that you are pleased with "+ hisher +" performance. All things considered; "+ HESHE +" has earned a break.";
			if (NPCCharList.CharFollower [WorldControl.idx].attFear > 50) {
				toReturn += "\n\nYou offer "+ himher +" snacks and you try to engage a conversation with "+ himher +", but "+ heshe +" is very reluctant and cautious thanks to the fear you have fostered in "+ himher +".\n\nYou decide to end the meeting sooner than expected and give "+ himher +" free time instead. ";
			} else {
				toReturn += "\n\nYou offer "+ himher +" snacks and engage in a casual conversation, having a pleasant time together until the meeting is over.\n\n"+ HESHE +" thanks you for inviting "+ himher +" to spend some time with you, and adds that "+ heshe +" would like the chance to do so again.";
			}
			return toReturn;
		case 1:
			if (randNum > 75) {
				toReturn = "Today you’ll be visiting the city with "+ NPCCharList.CharFollower [WorldControl.idx].charName +" as a reward.";
				if (NPCCharList.CharFollower [WorldControl.idx].attFear > 50) {
					toReturn += "\n\nYou summon "+ himher +" into your studio first and you congratulate "+ himher +" on performing a good job, and you ask "+ himher +" if "+ heshe +" wants to go to the city with you. You can tell that initially "+ HESHE +" is reluctant, but eventually they thank you and agree… possibly too afraid to deny you.\n\nThe two of you visit the city, taking a stroll through the park and enjoying the many vistas that the city has. Many times you try to engage "+ HIMHER +" in conversation but "+ NPCCharList.CharFollower [WorldControl.idx].charName +" spends most of their time overthinking each potential answer "+ HESHE +" gives, too cautious to act naturally around you.\n\nWhen you return to the castle "+ heshe +" bows and thanks you for your time, before returning to "+ hisher +" tasks. ";
				} else {
					toReturn += "\n\nYou summon "+ himher +" into your studio first and you congratulate "+ himher +" on performing a good job, and you ask "+ himher +" if "+ heshe +" wants to go to the city with you. "+ HESHE +" bows and profusely thanks you for offering your time, and gladly accepts the offer to join you. \n\nThe two of you visit the city, taking a stroll through the park and enjoying the many vistas that the city has. You both enjoy a pleasant time with each other until you return to your castle, at which point "+ HESHE +" bows and thanks you again for giving "+ himher +" this reward.";
				}
			} else if (randNum > 50) {
				toReturn = "After deciding to reward "+ NPCCharList.CharFollower [WorldControl.idx].charName +", you consider your options and decide it would be best to take "+ HIMHER +" to the city’s park.";
				if (NPCCharList.CharFollower [WorldControl.idx].attFear > 50) {
					toReturn += "\n\nYou summon "+ himher +" into your studio first and you congratulate "+ himher +" on performing a good job. "+ HESHE +" nervously nods and thanks you, and asks if you need something else. You shake your head and tell "+ himher +" that today you decided the both of you would spend some time together in the park as a reward.\n\nAlthough clearly uncomfortable thanks to spending "+ hisher +" time in your less-than-kind company, "+ heshe +" nods and tries to not enrage you. \n\nThe two of you visit the park and have an stroll for the most part in silence. Clearly you need to earn the thrust of this person first if you want to have a more lively time, but at least the fresh air has energized the both of you. ";
				} else {
					toReturn += "\n\nYou summon "+ himher +" into your studio first and you congratulate "+ himher +" on performing a good job. "+ HESHE +" happily thanks you and tell you that "+ heshe +" will keep doing "+ hisher +" best, before asking if "+ heshe +" can do something else for you. You shake your head and tell "+ himher +" that today you decided the both of you would spend some time together in the park as a reward.\n\n"+ HESHE +" bows and thanks you for sparing some of your precious time with "+ himher +". You tell "+ himher +" that "+ heshe +" should calm down a little bit, and that "+ heshe +" has earned it. The two of you eventually visit the park, enjoying a pleasant stroll through the entirety of it and soaking in the warm weather. \n\nAfter having some fresh air and a peaceful break the two of you return, feeling energized and prepared for another long day.\n";
				}
			} else if (randNum > 25) {
				toReturn = "After deciding to reward "+ NPCCharList.CharFollower [WorldControl.idx].charName +", you think what’s best is to have some fun with "+ himher +" in the city’s spa. ";
				if (NPCCharList.CharFollower [WorldControl.idx].attFear > 50) {
					toReturn += "\n\nYou summon "+ himher +" and tell "+ himher +" that you are happy with the work "+ HESHE +" is performing. "+ HESHE +" nervously nods and thanks you, and asks if you need something else. You shake your head and tell "+ himher +" that today you decided to head to the spa, and that they were welcome to join you as part of a reward.\n\nThe spa is one of the best places to relax in the city, but still "+ NPCCharList.CharFollower [WorldControl.idx].charName +" doesn’t look too convinced. "+ HESHE +" still nods and thanks you for the invitation.\n\nOnce there the two of you enjoy massages and other treatments, but since "+ heshe +" fears you too much "+ heshe +" never seems truly at ease, always cautious with what "+ heshe +" says.\n\nAt the end of the day you were the one who enjoyed yourself the most, but "+ NPCCharList.CharFollower [WorldControl.idx].charName +" definitely appreciated the break from "+ hisher +" hard work.";
				} else {
					toReturn += "\n\nYou summon "+ himher +" and tell "+ himher +" that you are happy with the work "+ HESHE +" is performing and tell "+ himher +" that today you decided to head to the spa, and that they were welcome to join you as part of a reward. \n\n"+ HESHE +" thanks you a lot for this invitation, and says how much "+ heshe +" appreciates the opportunity; work is pretty stressful at times. \n\nOnce there the two of you enjoy massages and other treatments that prove relaxing and reinvigorating both of you. \n\nWhen you come back home "+ heshe +" thanks you once more before stretching out slowly and announcing "+ HESHE +" is ready to dive back into "+ HISHER +" work extra hard. With a final bow "+ HESHE +" departs for "+ HISHER +" daily duties.";
				}
			} else {			
				toReturn = "After deciding to reward "+ NPCCharList.CharFollower [WorldControl.idx].charName +", you think what’s best is to have some fun with "+ himher +" in the city’s colosseum.";
				if (NPCCharList.CharFollower [WorldControl.idx].attFear > 50) {
					toReturn += "\n\nYou summon "+ himher +" and tell "+ himher +" that you are happy with what "+ heshe +" is doing. "+ HESHE +" nervously nods and thanks you, and asks if you need something else. You shake your head and tell "+ himher +" that today you decided the both of you would spend some time together in the colosseum as a reward.\n\nThe idea of visiting the Colosseum to witness bloody games is perceived as threatening for "+ NPCCharList.CharFollower [WorldControl.idx].charName +", who fears you a lot as it is. They seem not to feel they have a choice though, considering the hurried nod "+ HESHE +" gives you.\n\nThe two of you enjoy many fights. While you are cheering your favorite fighters, "+ NPCCharList.CharFollower [WorldControl.idx].charName +" is rather passive. At the end of the day the only one who enjoyed the trip was yourself, but at least "+ NPCCharList.CharFollower [WorldControl.idx].charName +" got to take a break from "+ hisher +" daily duties.";
				} else {
					toReturn += "\n\nYou summon "+ himher +" and tell "+ himher +" that you are happy with what "+ heshe +" is doing and tell "+ himher +" that today you decided the both of you would spend some time together in the colosseum as a reward. \n\n"+ HESHE +" thanks you a lot for inviting "+ himher +" and excitedly talks about placing bets, buying snacks, and cheering along with the crowd. \n\nThe two of you view many fights, and the event doesn’t disappoint for a single fight. When the two of you are back, "+ heshe +" profusely bows and thanks you for giving "+ himher +" this reward before returning to "+ hisher +" daily duties. ";
				}
			}
			return toReturn;
		case 2:
			toReturn = "Today you’ll be visiting the city to do some shopping with "+ NPCCharList.CharFollower [WorldControl.idx].charName +" as a reward.";
			if (NPCCharList.CharFollower [WorldControl.idx].attFear > 50) {
				toReturn += "\n\nYou summon "+ himher +" into your studio first and you congratulate "+ himher +" on performing a good job, and you ask "+ himher +" if "+ heshe +" wants to go to shopping with you. You can tell that initially "+ heshe +" is reluctant, but eventually they thank you and agree… possibly too afraid to deny you.\n\nThe two of you visit the market looking for trinkets and buying new clothes, and take a break to eat at a local restaurant.  Many times you try to engage "+ himher +" in conversation but "+ NPCCharList.CharFollower [WorldControl.idx].charName +" spends most of their time overthinking each potential answer "+ heshe +" gives, too cautious to act naturally around you.\n\nWhen you return to the castle "+ heshe +" bows and thanks you for your time, before returning to "+ hisher +" tasks. ";
			} else {
				toReturn += "\n\nYou summon "+ himher +" into your studio first and you congratulate "+ himher +" on performing a good job, and you ask "+ himher +" if "+ heshe +" wants to go shopping with you. "+ HESHE +" bows and profusely thanks you for offering your time, and gladly accepts the offer to join you. \n\nThe two of you visit the market looking for trinkets and buying new clothes, and take a break to eat at a local restaurant. You both enjoy a pleasant time with each other until you return to your castle, at which point "+ heshe +" bows and thanks you again for giving "+ himher +" this reward.";
			}
			return toReturn;
		case 3:
			toReturn = "As a reward for "+ NPCCharList.CharFollower [WorldControl.idx].charName +", you’ll be visiting one of the fanciest restaurants in the city. ";
			if (NPCCharList.CharFollower [WorldControl.idx].attFear > 50) {
				toReturn += "\n\nYou summon "+ himher +" and tell "+ himher +" that today the two of you will be going to a very special place. You can see that "+ heshe +" is reluctant, but doesn’t protest the point. Since the place is refined, you tell "+ himher +" that "+ heshe +" should dress appropriately before commanding one of your servants to bring them a decent outfit.\n\nWhen you’re both finally ready you mount a waiting carriage and settle in. The journey proves to be silent thanks to "+ HISHER +" passive fear of you, or saying the wrong thing and being scolded.\n\nThe carriage finally arrives at its destination. The luxurious nature of this restaurant is noted by your partner for the evening, who is clearly impressed. A beautiful waitress leads you inside, guiding the both of you to a private VIP booth.\n\nBut even though the setting is great not much happens, and beyond the delicious food you could say that the experience was awkward. \n\nWhen the two of you return to your castle "+ NPCCharList.CharFollower [WorldControl.idx].charName +"’s profusely bows and thanks you for inviting "+ himher +" to such an exclusive place. Although you know "+ heshe +" liked the overall experience, it would have been better if "+ heshe +" hadn’t spent the entire time low-key afraid all the time. ";
			} else {
				toReturn += "\n\nYou summon "+ himher +" and tell "+ himher +" that today the two of you will be going to a very special place. You can tell "+ HESHE +" is excited and curious, but before "+ HESHE +" gets a chance to ask you where you’re headed you dismiss them. Afterwards you order a servant in to provide "+ HIMHER +" with the appropriate outfit.\n\nWhen you’re both finally ready you mount a waiting carriage and settle in. The journey is very cheerful, with "+ himher +" thanking you between pleasant conversation despite not knowing where you’re headed.\n\nThe carriage finally arrives at its destination. The luxurious nature of this restaurant is noted by your partner for the evening, who is clearly impressed. A beautiful waitress leads you inside while you’re thanked once again, guiding the both of you to a private VIP booth.\n\nThe great atmosphere coupled with amazing food, and the great conversation the two of you have ends up being a great experience. "+ NPCCharList.CharFollower [WorldControl.idx].charName +" seems hugely pleased, leaning back and rubbing "+ HISHER +" belly on the ride back home.\n\nOnce back "+ heshe +" says that "+ heshe +" will keep doing "+ hisher +" best to earn these kind of rewards again, and you encourage "+ himher +" to do so. \n";
			}
			return toReturn;
		case 4:
			if (randNum > 50) {
				toReturn = "As a reward for "+ NPCCharList.CharFollower [WorldControl.idx].charName +", you’ll be visiting one of the fanciest places in the city.";
				if (NPCCharList.CharFollower [WorldControl.idx].attFear > 50) {
					toReturn += "\n\nYou summon "+ himher +" and tell "+ himher +" that today the two of you will be going to a very special place. You can see that "+ heshe +" is reluctant, but doesn’t protest the point. Since the place is refined, you tell "+ himher +" that "+ heshe +" should dress appropriately before commanding one of your servants to bring them a decent outfit.\n\nWhen you’re both finally ready you mount a waiting carriage and settle in. The journey proves to be silent thanks to "+ hisher +" passive fear of you, or saying the wrong thing and being scolded.\n\nThe carriage finally arrives at its destination; the beautiful exterior of the theater welcoming you to enjoy one of its plays. "+ HESHE +" isn’t as excited despite the show being great; it’s obvious "+ heshe +" doesn’t enjoy "+ himher +"self as much because your presence threatens "+ himher +", even though you’re relaxed.\n\nWhen the two of you return to your castle "+ NPCCharList.CharFollower [WorldControl.idx].charName +"’s profusely bows and thanks you for inviting "+ himher +" to such an exclusive place. Although you know "+ heshe +" liked the overall experience, it would have been better if "+ heshe +" hadn’t spent the entire time low-key afraid all the time. ";
				} else {
					toReturn += "\n\nYou summon "+ himher +" and tell "+ himher +" that today the two of you will be going to a very special place. You can tell "+ heshe +" is excited and curious, but before "+ heshe +" gets a chance to ask you where you’re headed you dismiss them. Afterwards you order a servant in to provide "+ himher +" with the appropriate outfit.\n\nWhen you’re both finally ready you mount a waiting carriage and settle in. The journey is very cheerful, with "+ himher +" thanking you between pleasant conversation despite not knowing where you’re headed.\n\nThe carriage finally arrives at its destination; the beautiful exterior of the theater welcoming you to enjoy one of its plays. "+ HESHE +" is really excited about the current play, and when it finally comes to an end "+ heshe +" all but springs from the chair in applause. It would definitely be a great experience worth repeating.\n\nOnce back "+ heshe +" says that "+ heshe +" will keep doing "+ hisher +" best to earn these kind of rewards again, and you encourage "+ himher +" to do so. ";
				}
				return toReturn;
			} else {
				toReturn = "After deciding to reward "+ NPCCharList.CharFollower [WorldControl.idx].charName +", you think what’s best is to have some fun with "+ himher +" in the city’s theater.";
				if (NPCCharList.CharFollower [WorldControl.idx].attFear > 50) {
					toReturn += "\n\nYou summon "+ himher +" and tell "+ himher +" that you are happy with what "+ heshe +" is doing. "+ HESHE +" nervously nods and thanks you, and asks if you need something else. You shake your head and tell "+ himher +" that today you decided to spend some time together in the theater as a reward.\n\nAlthough the theater is a sophisticated and enjoyable experience, "+ NPCCharList.CharFollower [WorldControl.idx].charName +" doesn’t look too excited. "+ HESHE +" bows and thanks you, but "+ HESHE +" clearly fears you too much to feel happy about going anywhere with you.\n\nThe two of you enjoy the play of the day, and although you and "+ NPCCharList.CharFollower [WorldControl.idx].charName +" loved it, you two barely talk about it on your way home.\n\nOnce in the castle, "+ heshe +" returns to "+ hisher +" daily duties, admittedly relaxed and rested after the cultural break. ";
				} else {
					toReturn += "\n\nYou summon "+ himher +" and tell "+ himher +" that you are happy with what "+ heshe +" is doing. "+ HESHE +" nervously nods and thanks you, and asks if you need something else. You shake your head and tell "+ himher +" that today you decided to spend some time together in the theater as a reward.\n\n"+ HESHE +" thanks you a lot for inviting "+ himher +", and excitedly talks about the current play in the theater right now. Apparently "+ HESHE +" had been dying to see it for a long time.\n\nThe two of you sit comfortably as the play begins and love the show the whole way through, excitedly talking about it on the journey home afterward.\n\nOnce in the castle "+ heshe +" thanks you once more before returning to "+ hisher +" daily duties, relaxed and rested after the cultural break. ";
				}
				return toReturn;
			}
		default:
			return "";
		}

	}
}
