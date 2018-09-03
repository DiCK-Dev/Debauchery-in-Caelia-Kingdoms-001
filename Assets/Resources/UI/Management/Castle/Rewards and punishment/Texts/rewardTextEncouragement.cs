using UnityEngine;
using System.Collections;

public class rewardTextEncouragement	{

	// divided in 6: Show gratitude (0), Praise, Compliments, Promise reward, Promise gift, Promise big reward 
	public static string sceneText(int selector){
		float randNum = Random.Range(0f, 100f);
		string toReturn = ""; 
		string heshe = "he", hisher = "his", himher = "him", HESHE = "He", HISHER = "His", HIMHER = "Him"; 
		if (NPCCharList.CharFollower [WorldControl.idx].charGender == NPCData.CharGender.FEMALE) {
			heshe = "she"; hisher = "her"; himher = "her"; HESHE = "She"; HISHER = "Her"; HIMHER = "Her"; 
		}

		switch (selector) {
		case 0:
			toReturn = "You’ve reports that "+ NPCCharList.CharFollower [WorldControl.idx].charName +" has been doing a good job lately and you decide to find "+himher+" and show "+himher+" gratitude personally. You turn up out of the blue where "+HESHE+" is working diligently.";
			if (NPCCharList.CharFollower [WorldControl.idx].attHappiness > 50) {
				toReturn += "\n\nAs expected "+heshe+" is doing "+hisher+" job. You wave in greeting and approach; "+HESHE+" appears nervous at your unexpected arrival, but once you begin with gratitude "+heshe+" relaxes a little. "+HESHE+" happily smiles and thanks you. \n\nYou tell "+himher+" to keep up the good work and return to your castle. \n";
			} else {
				toReturn += "\n\nAs expected "+heshe+" is doing "+hisher+" job. You wave in greeting and approach; "+HESHE+" appears nervous at your unexpected arrival, but once you begin with gratitude "+heshe+" relaxes a little. "+HESHE+" bows and thanks you, but doesn’t looks too happy. Maybe "+heshe+" needs to take a break from all this hard work? \n\nYou tell "+himher+" to keep up the good work and return to your castle. \n";
			}

			return toReturn;
		case 1:
			toReturn = ""+ NPCCharList.CharFollower [WorldControl.idx].charName +" has been doing a good job lately, and for that you summon "+himher+" to the throne room. There in front of your court, you praise "+himher+" and ensure that everyone around you is aware that "+heshe+" is doing a fantastic job.";
			if ((int)NPCCharList.CharFollower [WorldControl.idx].bgUpbring > 2) {
				toReturn += "\n\nSome of the people present applaud and cheer "+himher+", mostly other officials and high born people that understand the gravity of, and can relate to the work "+heshe+" is doing.\n";
			} else {
				toReturn += "\n\nSome of the people present applaud and cheer "+himher+", mostly other servants and low born people that understand how hard their work truly is.";
			}
			if (NPCCharList.CharFollower [WorldControl.idx].attHappiness > 50) {
				toReturn += "\n\n"+HESHE+" bows deeply and thanks you for your appreciation, apparently pleased and more than a little excited. "+HESHE+" swears to keep on doing their very best.\n\nWith that matter out of your way you dismiss "+himher+" to their duties and return to your own.";
			} else {
				toReturn += "\n\n"+HESHE+" bows deeply and thanks you for your appreciation, but there’s still a displeased air about "+himher+". Maybe you have been pushing them too hard… Whatever the case, "+heshe+" says that "+heshe+"’ll keep working hard, so that’s what matters.\n\nWith that matter out of your way you dismiss "+himher+" to their duties and return to your own.";
			}
			return toReturn;
		case 2:
			toReturn = "You are walking through your castle when you come across "+ NPCCharList.CharFollower [WorldControl.idx].charName +", walking to the other direction. You quickly run your mind over the reports you’ve seen, remembering how well "+heshe+" has supposedly been performing their tasks. You decide to use this chance to thank "+himher+" for "+hisher+" efforts.";
			if (NPCCharList.CharFollower [WorldControl.idx].attFear > 50) {
				toReturn += "\n\nWhen "+heshe+" is at your side you stop "+himher+". "+HESHE+" freezes in fear at first, expecting to be scolded or harshly punished as you’ve doled out over the past. Instead "+heshe+" brightens at your compliments, bowing their head politely.\n\nGlad that everything went fine, "+heshe+" bows deeply and thanks you for your commendation, before obediently returning to "+hisher+" job. ";
			}else{
				toReturn += "\n\nWhen "+heshe+" is at your side you stop "+himher+". "+HESHE+" smiles at you and asks what "+heshe+" can do for you. Smiling faintly back, you simply tell "+HIMHER+" you wanted to compliment their skills and work ethic. "+HISHER+" face brightens up at your compliments, and they bow their head politely before continuing on.";
			}
			return toReturn;
		case 3:
			toReturn = "You’ve summoned "+ NPCCharList.CharFollower [WorldControl.idx].charName +" to your studio because "+heshe+" has been reported to be doing a good job, and has been praised for "+hisher+" energy and talent. ";
			if (NPCCharList.CharFollower [WorldControl.idx].attFear > 50) {
				toReturn += "\n\nWhen "+heshe+" arrives they’re clearly afraid, expecting the worst from you. Instead you inform them proudly that you’ve heard about their good work, and that you intend to praise them. Not only that; if "+HESHE+" keeps up the good work you promise to reward "+himher+" properly.\n\n"+HESHE+" bows deeply before you and thanks you for your generous nature, before you dismiss "+himher+" so that "+heshe+" can go back to work. ";
			} else {
				toReturn += "\n\n"+HESHE+" looks very proud of "+himher+"self when she arrives, standing tall in front of you. You proudly tell them that you’ve heard about their good work, and that you intend to praise them. Not only that; if "+HESHE+" keeps up the good work you promise to reward "+himher+" properly.\n\n"+HESHE+" bows deeply before you and thanks you for your generous nature, before you dismiss "+himher+" so that "+heshe+" can go back to work. ";
			}
			return toReturn;
		case 4:
			toReturn = "You’ve summoned "+ NPCCharList.CharFollower [WorldControl.idx].charName +" to your studio because "+heshe+" has been reported to be doing a good job, and has been praised for "+hisher+" energy and talent. ";
			if (NPCCharList.CharFollower [WorldControl.idx].attFear > 50) {
				toReturn += "\n\nWhen "+heshe+" arrives they’re clearly afraid, expecting the worst from you. Instead you inform them proudly that you’ve heard about their good work, and that you intend to praise them. Not only that; if "+HESHE+" keeps up the good work you promise to give "+himher+" an expensive gift.\n\n"+HESHE+" bows deeply before you and thanks you for your generous nature, before you dismiss "+himher+" so that "+heshe+" can go back to work. ";
			} else {
				toReturn += "\n\n"+HESHE+" looks very proud of "+himher+"self when she arrives, standing tall in front of you. You proudly tell them that you’ve heard about their good work, and that you intend to praise them. Not only that; if "+HESHE+" keeps up the good work you promise to give "+himher+" an expensive gift.\n\n"+HESHE+" immediately bows and thanks you a lot for having such a generous nature, and promising not to disappoint you. With everything said, you dismiss "+himher+" so "+heshe+" can turn to eagerly to "+hisher+" tasks again. \n";
			}
			return toReturn;
		case 5:
			toReturn = "You’ve summoned "+ NPCCharList.CharFollower [WorldControl.idx].charName +" to your studio because "+heshe+" has been reported to be doing a good job, and has been praised for "+hisher+" energy and talent. ";
			if (NPCCharList.CharFollower [WorldControl.idx].attFear > 50) {
				toReturn += "\n\nWhen "+heshe+" arrives they’re clearly afraid, expecting the worst from you. Instead you inform them proudly that you’ve heard about their good work, and that you intend to praise them. Not only that; if "+HESHE+" keeps up the good work you promise to reward "+himher+" handsomely.\n\n"+HESHE+" bows deeply before you and thanks you for your generous nature, before you dismiss "+himher+" so that "+heshe+" can go back to work. ";
			} else {
				toReturn += "\n\n"+HESHE+" looks very proud of "+himher+"self when she arrives, standing tall in front of you. You proudly tell them that you’ve heard about their good work, and that you intend to praise them. Not only that; if "+HESHE+" keeps up the good work you promise to reward "+himher+" handsomely.\n\n"+HESHE+" immediately bows and thanks you a lot for having such a generous nature, and promising not to disappoint you. With everything said, you dismiss "+himher+" so "+heshe+" can turn to eagerly to "+hisher+" tasks again. ";
			}
			return toReturn;
		case 6:
			toReturn = "";
			if (NPCCharList.CharFollower [WorldControl.idx].attFear > 50) {
				toReturn += "\n\n";
			} else {
				toReturn += "\n\n";
			}
			return toReturn;
		default:
			/*if (randNum > 66) {
				toReturn += "\n\n";
			} else if (randNum > 33) {
				toReturn += "\n\n";
			} else {
				toReturn += "\n\n";
			}*/
			return "";
		}

	}

}
