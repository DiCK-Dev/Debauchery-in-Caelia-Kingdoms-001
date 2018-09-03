using UnityEngine;
using System.Collections;

public class rewardTextGift  {


	public static string sceneText(int selector){
		string toReturn = ""; 
		string heshe = "he", hisher = "his", himher = "him", HESHE = "He", HISHER = "His", HIMHER = "Him"; 
		if (NPCCharList.CharFollower [WorldControl.idx].charGender == NPCData.CharGender.FEMALE) {
			heshe = "she"; hisher = "her"; himher = "her"; HESHE = "She"; HISHER = "Her"; HIMHER = "Her"; 
		}
		float randNum = Random.Range(0f, 100f);
		switch (selector) {
		case 0:
			return "Since "+ NPCCharList.CharFollower [WorldControl.idx].charName +" has earned a reward, you think it would be nice to gift "+himher+" some flowers. You buy the biggest, most beautiful bouquet that the florist sells and go back to your castle.\n\nThere, you find "+ NPCCharList.CharFollower [WorldControl.idx].charName +"’s taking a break. You use the opportunity to get closer to "+himher+" and offer "+himher+" the flowers with a smile.\n\n"+ NPCCharList.CharFollower [WorldControl.idx].charName +" seems surprised and asks if these flowers are for "+himher+" and you nod, telling "+himher+" that "+heshe+" has been doing a great job and "+heshe+" deserves them. "+HESHE+" smiles at you and thanks you for the gift, apparently they’re some of their favorites on top of smelling delightful.\n\nYou return back to work after your small exchange. ";
		case 1:
			return "Since "+ NPCCharList.CharFollower [WorldControl.idx].charName +" has earned a reward, you think it would be nice to gift "+himher+" a plush toy. You buy the nicest one you can find at the market before returning to your castle.\n\nThere, you find "+ NPCCharList.CharFollower [WorldControl.idx].charName +"’s taking a break. You use the opportunity to get closer to "+himher+" and offer "+himher+" the toy with a smile.\n\n"+HESHE+" says that it is very cute and fluffy, perfect for "+hisher+" collection. "+HESHE+" smiles and thanks you for it, and with a happy face "+heshe+" turns back to work. \n";
		case 2:
			return "Since "+ NPCCharList.CharFollower [WorldControl.idx].charName +" has earned a reward, you think it would be nice to gift "+himher+" an expensive perfume that you got in the market.\n\nOnce you are back you find "+ NPCCharList.CharFollower [WorldControl.idx].charName +"’s working, but you tell "+himher+" to take a break since you want to give "+himher+" something. After a moment’s confusion on their part, you hand "+himher+" a box. "+HISHER+" face brightens in surprise at the gift, asking to try it out immediately.\n\n"+ NPCCharList.CharFollower [WorldControl.idx].charName +" is very pleased with the smell of your gift, bowing and thanking you for such a present before turning back to work. ";
		case 3:
			return "Since "+ NPCCharList.CharFollower [WorldControl.idx].charName +" has earned a reward, you think it would be nice to gift "+himher+" some luxurious jewelry.\n\nYou summon "+himher+" into your studio and once there you hand the present over, hidden inside a a beautiful wood box. When "+heshe+" opens it "+hisher+" face opens in a bright smile, "+heshe+" even apologizes for accepting such a precious gift.\n\nYou tell "+himher+" that "+heshe+" has earned it and "+heshe+" has nothing to worry about, so long as they keep up the good work. "+HESHE+" bows and says that "+heshe+" will do everything in their power to continue.\n\nWith the matter settled, you dismiss "+himher+" so "+heshe+" can turn back to work (and you to your own). ";
		case 4:
			return "Since "+ NPCCharList.CharFollower [WorldControl.idx].charName +" has earned a reward, you think it would be nice to gift "+himher+" a small pet.\n\nYou go to the market and find an exotic store that sells small little cute creatures. One of them appears to be particularly tame and unlikely to cause trouble, and you take it back to the castle.\n\nThere, you find "+ NPCCharList.CharFollower [WorldControl.idx].charName +" taking a short break. You approach, a small cage behind your back and out of sight. After telling "+himher+" that you are delighted with their performance and deserve a small gift, you hand over the cage with the pet within.\n\n"+HESHE+" falls in love with the cute little critter at first sight, thanking you deeply and promising to take great care of it and keep up the good work.\n\nGlad that "+heshe+" is happy, you tell "+himher+" to take some more free time to get acquainted with "+hisher+" new pet while you go back to work. \n";
		case 5:
			return "Since "+ NPCCharList.CharFollower [WorldControl.idx].charName +" has earned a reward, you think it would be nice to gift "+himher+" some candies. You go to the market and purchase a variety of them before heading back home. \n\nYou find "+himher+" in the castle, working hard. You call "+himher+" and "+heshe+" immediately approaches, respectfully bowing. You then hand "+himher+" the bag of candies, telling "+himher+" that "+heshe+" has earned these treats in appreciation for "+hisher+" continued efforts.\n\n"+HESHE+" takes them and eats one, and thanks you with a cheerful smile on "+hisher+" face, promising you that "+heshe+" will keep working hard. \n";
		case 6:
			return "You ordered your servants to bring you a seizable chocolate bar from one of the fancy shops in the market so you can reward "+ NPCCharList.CharFollower [WorldControl.idx].charName +" for "+hisher+" hard work\n\nIt doesn't take long before your servants return with the goods, and you summon "+ NPCCharList.CharFollower [WorldControl.idx].charName +" to your studio.\n\nWhen "+heshe+" arrives "+heshe+" asks what can "+heshe+" do for you, but you tell "+himher+" you just wanted to give them a gift. Excited, "+heshe+" thanks you before you even give "+himher+" anything, but when "+heshe+" sees the golden wrapper of the chocolate bar "+heshe+" breaks out into a bright smile. \n\nYou hand the treat to "+himher+" and tell "+himher+" that this is a reward for their good behavior. "+HESHE+" nods and thanks you, telling you that "+heshe+" will keep up the good work. \n";
		case 7:
			return "You’ve sent your servants to bring a beautiful small cake from one of the fanciest bakeries in the city, in order to reward "+ NPCCharList.CharFollower [WorldControl.idx].charName +" for their hard work.\n\nWhen they come back you summon "+ NPCCharList.CharFollower [WorldControl.idx].charName +" to the dinner room with your surprise sitting on top of the table, waiting to be eaten. "+HESHE+" asks what "+heshe+" can do for you, but instead you order "+himher+" to take a seat. "+HESHE+" does so, looking at the cake with hungry eyes. \n\nAlthough you would love to tease "+himher+" a little bit, you are in a hurry and proceed to tell "+himher+" that "+heshe+" has been working hard. Incredulous, "+heshe+" asks if this tasty reward is for "+himher+", and you nod an agreement.\n\n"+HESHE+" bows and thanks you, and you tell "+himher+" that so long as "+heshe+" keep working hard "+heshe+" will keep getting these kind of rewards.\n\nYou stand up and leave "+himher+" to enjoy the treat while you go back to work. ";
		case 8:
			toReturn = "Your servants have brought many lavish desserts from the best restaurants and bakeries in the city, all of them are served down the length of your dining-room table.\n\nYou summon "+ NPCCharList.CharFollower [WorldControl.idx].charName +", who doesn’t realize that this display has been prepared for "+himher+" and not for you. As "+heshe+" approaches you tell "+himher+" that you are actually very happy with "+hisher+" work, and you decided to prepare a surprise for them.\n\n"+HESHE+" asks what you have for "+himher+", thinking you may have some other gift for "+himher+". Smiling you gesture to the smorgasbord of desserts, inviting "+himher+" to take a seat.\n\nSurprised, "+heshe+" bows and thanks you before sitting down. ";
			if (NPCCharList.CharFollower [WorldControl.idx].attFear > 50) {
				toReturn += "\n\nYou know that "+heshe+" is still reluctant to spend an extended period of time in your presence, still fearing you. Realizing this would spoil their experience, you simply excuse yourself so that "+heshe+" can enjoy "+hisher+" reward.";
			} else {
				toReturn += "\n\nYou take a seat with "+himher+" and start to eat some of the desserts too, since it’s far too much for a single person. The two of you engage in a pleasant conversation and have a great time together. Even with the both of you consuming greedily there’s still plenty left, and "+ NPCCharList.CharFollower [WorldControl.idx].charName +" suggests the leftovers go to the servants who collected it. \n\nWith a shrug you agree, and once you’re both satisfied "+heshe+" bows and thanks you before returning to work.";
			}
			return toReturn;
		case 9:
			toReturn = "Your servants prepare a lavish banquet to give as a reward for "+ NPCCharList.CharFollower [WorldControl.idx].charName +". After sending a servant for "+himher+" to make sure that "+heshe+" is dressed properly for the occasion, "+heshe+" joins you once the table is almost ready. "+HISHER+" arrival is timed perfectly with the placement of the last dish.\n\nA display worthy of a king; "+heshe+" asks if this is for "+himher+".\n\nYou smile and invite "+himher+" to take a seat, which "+heshe+" excitedly does. "+HESHE+" takes a moment to marvel at the selection before one of your staff serve them.";
			if (NPCCharList.CharFollower [WorldControl.idx].attFear > 50) {
				toReturn += "\n\nSince you know that your presence makes "+himher+" nervous thanks to your… harsh treatment of "+himher+", you decide to excuse yourself early and allow "+himher+" to relax with the other servants while you return to work.\n";
			} else {
				toReturn += "\n\nYou take a seat at "+hisher+" side and encourage "+himher+" to pick a dish. Nervously, "+heshe+" ends up picking a roast beef and a salad, while you pick your favorite food.\n\nThe two of you have an enjoyable conversation while sampling the many options that lie in front of you, drinking wine and juices. When the both of you are finally full you spend an hour chatting and letting food digest before ending the pleasant evening.";
			}
			return toReturn;
		case 100:
			if (randNum > 66) {
				return "";
			} else if (randNum > 33) {
				return "";
			} else {
				return "";
			}
		default:
			return "bug in RewardTextGift.cs";
		}

	}
}
