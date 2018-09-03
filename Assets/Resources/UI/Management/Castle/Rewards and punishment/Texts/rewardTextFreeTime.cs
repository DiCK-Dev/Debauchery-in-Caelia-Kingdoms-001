using UnityEngine;
using System.Collections;

public class rewardTextFreeTime  {




	public static string sceneText(int selector){
		string toReturn = ""; 
		string heshe = "he", hisher = "his", himher = "him", HESHE = "He", HISHER = "His", HIMHER = "Him"; 
		if (NPCCharList.CharFollower [WorldControl.idx].charGender == NPCData.CharGender.FEMALE) {
			heshe = "she"; hisher = "her"; himher = "her"; HESHE = "She"; HISHER = "Her"; HIMHER = "Her"; 
		}

		switch (selector) {
		case 0: // rest 
			toReturn = "Since "+ NPCCharList.CharFollower [WorldControl.idx].charName +" has been doing such a great job, you decide to give "+ himher +" the rest of the day off.";
			if (NPCCharList.CharFollower [WorldControl.idx].attFear > 50) {
				toReturn += "\n\nYou summon "+ himher +" to your studio. There, "+ heshe +" is clearly nervous, looking down and trembling a little bit. Smirking you tell "+ himher +" to calm down; they’ve been doing such a good job that they can even take the day off for "+ HIMHER +"self.\n\n"+ HESHE +" is visibly relieved, thanking you for your kindness.\n\nYou then dismiss "+ himher +" and tell them to rest and enjoy the day, since you expect that "+ heshe +" will keep working hard tomorrow. "+ HESHE +" nods and leaves, thanking you one last time before going to the city. ";
			} else {
				toReturn += "\n\nYou summon "+ himher +" to your studio. Cheerful, "+ heshe +" asks you what "+ heshe +" can do for you now, but you stop "+ HIMHER +" there. For the moment of his confusion you inform "+ himher +" that "+ heshe +" has earned a day off of work for their own enjoyment.\n\n"+ HESHE +" profusely thanks you for your kindness, and says that "+ heshe +" will continue to keep up the good work.\n\nYou then dismiss "+ himher +" and tell them to rest and enjoy the day, since you expect that "+ heshe +" will keep working hard tomorrow. "+ HESHE +" nods and leaves, thanking you one last time before going to the city. ";
			}
			return toReturn;
		case 1: // park
			toReturn = "Since "+ NPCCharList.CharFollower [WorldControl.idx].charName +" has been doing such a great job, you decide to allow "+ himher +" to visit the park on "+ hisher +" own to enjoy "+ hisher +" free time.\n\nYou summon "+ himher +" to your studio and tell "+ himher +" that "+ heshe +" has earned some free time, and that you’ll allow "+ himher +" to go to the park for some fresh air. "+ HESHE +" bows and thanks you, saying that this break will help to gift "+ himher +" with a little extra energy. "+ HESHE +" promises afterwards that "+ heshe +" will continue to put in their best effort.\n\nYou then dismiss "+ himher +" so "+ heshe +" can enjoy "+ hisher +" reward. \n";
			return toReturn;
		case 2: // colosseum
			toReturn = "Since "+ NPCCharList.CharFollower [WorldControl.idx].charName +" has been doing such a great job, you decide to allow "+ himher +" to visit the colosseum on "+ hisher +" own to enjoy "+ hisher +" free time.\n\nYou summon "+ himher +" to your studio and tell "+ himher +" that "+ heshe +" has earned some free time, and that you’ll allow "+ himher +" to go to the Colosseum to enjoy the fights and place bets, if "+ heshe +" wishes to do so. "+ HESHE +" bows and thanks you, saying that this break will help to gift "+ himher +" with a little extra energy. "+ HESHE +" promises afterwards that "+ heshe +" will continue to put in their best effort.\n\nYou then dismiss "+ himher +" so "+ heshe +" can enjoy "+ hisher +" reward. ";
			return toReturn;
		case 3: // theater
			toReturn = "Since "+ NPCCharList.CharFollower [WorldControl.idx].charName +" has been doing such a great job, you decide to allow "+ himher +" to visit the theater on "+ hisher +" own to enjoy "+ hisher +" free time.\n\nYou summon "+ himher +" to your studio and tell "+ himher +" that "+ heshe +" has earned some free time, and that you’ll allow "+ himher +" to go to the theater to enjoy a cultural break, and you give "+ himher +" enough money so "+ heshe +" can even buy tickets for a date to join "+ himher +". "+ HESHE +" bows and thanks you, saying that this break will help to gift "+ himher +" with a little extra energy. "+ HESHE +" promises afterwards that "+ heshe +" will continue to put in their best effort.\n\nYou then dismiss "+ himher +" so "+ heshe +" can enjoy "+ hisher +" reward. ";
			return toReturn;
		case 4: // spa
			toReturn = "Since "+ NPCCharList.CharFollower [WorldControl.idx].charName +" has been doing such a great job, you decide to allow "+ himher +" to visit the spa on "+ hisher +" own to enjoy "+ hisher +" free time.\n\nYou summon "+ himher +" to your studio and tell "+ himher +" that "+ heshe +" has earned some free time, and that you’ll allow "+ himher +" to go to the spa, so "+ heshe +" can relax and refresh "+ himher +"self. "+ HESHE +" bows and thanks you, saying that this break will help to gift "+ himher +" with a little extra energy. "+ HESHE +" promises afterwards that "+ heshe +" will continue to put in their best effort. \n\nYou then dismiss "+ himher +" so "+ heshe +" can enjoy "+ hisher +" reward. \n";
			return toReturn;
		case 5:
			toReturn = "";
			return toReturn;
		default:

			return "";
		}

		return "";

	}
}
