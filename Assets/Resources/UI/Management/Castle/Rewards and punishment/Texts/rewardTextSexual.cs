using UnityEngine;
using System.Collections;

public class rewardTextSexual  {
	int hashcode = GameControl.playerName.GetHashCode();


	public static string sceneText(int selector){
		float randNum = Random.Range(0f, 100f);
		string toReturn = "";
		string heshe = "he", hisher = "his", himher = "him", HESHE = "He", HISHER = "His", HIMHER = "Him"; 
		if (NPCCharList.CharFollower [WorldControl.idx].charGender == NPCData.CharGender.FEMALE) {
			heshe = "she"; hisher = "her"; himher = "her"; HESHE = "She"; HISHER = "Her"; HIMHER = "Her"; 
		}
		switch (selector) {
		case 0:
			toReturn = "You’ve summoned "+ NPCCharList.CharFollower [WorldControl.idx].charName +" into your chamber. When "+heshe+" arrives, "+heshe+" is curious and asks what "+heshe+" can do for you.\n\nYou tell "+HIMHER+" that since "+heshe+" has been behaving appropriately, you’ll give "+HIMHER+" a massage as a reward. ";
			if (NPCCharList.CharFollower [WorldControl.idx].attFear > 50) {
				toReturn += "\n\nYou can see that "+heshe+" isn’t really that comfortable with the idea and nervously thanks you while "+heshe+" undresses "+hisher+" top and lies on the bed, waiting for you to do your thing. \n\nYou use your firm hands and oil to give "+HIMHER+" a very complete massage but "+heshe+" doesn’t seem any less tense than when you began, no doubt a symptom of "+HISHER+" fear for you.";
			} else {
				toReturn += "\n\n"+HESHE+" thanks you for the gesture and undresses "+hisher+" top and lies on the bed, waiting for your eager hands. \n\nYou give "+HIMHER+" a very complete and firm massage using oil, and "+heshe+" manages to relax and even fall asleep for a while. When you are done, "+heshe+" looks really refreshed, and thanks you for the release of stress. \n\nWith the massage concluded, "+HESHE+" redresses and returns to work after a final thank you.";
			}
			return toReturn;
		case 1:
			GameControl.actualArousal += 20;
			toReturn = "You decided to give a <i>hand</i>some reward to "+ NPCCharList.CharFollower [WorldControl.idx].charName +", and summoned "+HIMHER+" to your chamber. \n\nWhen "+heshe+" arrives, "+heshe+" is surprised that you are scantily dressed when you invite "+HIMHER+" to sit at your side.";
			if (NPCCharList.CharFollower [WorldControl.idx].attFear > 50) {
				toReturn += "\n\n"+HESHE+" nervously approaches you and asks what "+heshe+" can do for you, but you tell "+HIMHER+" that "+heshe+" should relax since you just want to thank "+HIMHER+" for "+hisher+" hard work.";
				if (NPCCharList.CharFollower [WorldControl.idx].dickSize > 0) {
					toReturn += "\n\n"+ NPCCharList.CharFollower [WorldControl.idx].charName +" reluctantly sits and stays put, waiting for you to take the initiative. You undress "+HIMHER+" from the waist-down and expose "+hisher+" dick, which is soft. You grab "+HIMHER+" by the hips and tell "+HIMHER+" to calm down, while with your free hand you grope "+hisher+" penis, caressing it until it begins to harden.\n\nWith "+hisher+" dick half erect now, its easier to jerk "+HIMHER+" off, fondling "+hisher+" balls while you grind your body against "+HIMHER+". It doesnt takes long for your expert hands to make "+HIMHER+" cum, though you continue to milk "+hisher+" cock until it goes soft again and you are sure you have drained "+hisher+" balls.\n\nAlthough still not totally comfortable "+heshe+" is more relaxed at the end, and thanks you before returning to "+hisher+" tasks. You clean your cum drenched hand before going back to work, aroused by the experience. ";
				} else {
					toReturn += "\n\n"+ NPCCharList.CharFollower [WorldControl.idx].charName +"reluctantly sits and stays put, waiting for you to take the initiative. You undress "+HIMHER+" from the waist-down and expose "+hisher+" pussy, which is dry. You grab "+HIMHER+" by the hips and tell "+HIMHER+" to calm down, while with your free hand yo caress "+hisher+" clit, until "+HESHE+" grows wet.\n\nWith "+hisher+" cunt wet now, its easier to sink your fingers into "+HIMHER+", using your thumb to play with "+hisher+" clit. "+HESHE+" lies down and tries to relax, until "+heshe+" starts to finally enjoy "+HIMHER+"self at your hands. She suddenly cries out in orgasmic delight, arching her back and then resting on the bed for few minutes until "+heshe+" recovers. \n\nAlthough still not totally comfortable "+heshe+" is more relaxed at the end, and thanks you before returning to "+hisher+" tasks. You clean your fluid drenched hand before going back to work, aroused by the experience. \n";
				}
			} else {
				toReturn += "\n\n"+HESHE+" eagerly approaches you and asks what "+heshe+" can do for you, but you tell "+HIMHER+" that "+heshe+" should relax since you just want to thank "+HIMHER+" for "+hisher+" hard work.";
				if (NPCCharList.CharFollower [WorldControl.idx].dickSize > 0) {
					toReturn += "\n\n"+ NPCCharList.CharFollower [WorldControl.idx].charName +" happily sits and stays put, waiting for you to take the initiative. You undress "+HIMHER+" from the waist-down and expose "+hisher+" dick, which is soft. You grab "+HIMHER+" by the hips and tell "+HIMHER+" to calm down, while with your free hand you grope "+hisher+" penis, caressing it until it begins to harden.\n\nWith "+hisher+" cunt wet now, its easier to sink your fingers into "+HIMHER+", using your thumb to play with "+hisher+" clit. "+HESHE+" lies down and tries to relax, until "+heshe+" starts to finally enjoy "+HIMHER+"self at your hands. She suddenly cries out in orgasmic delight, arching her back and then resting on the bed for few minutes until "+heshe+" recovers. \n\n"+HESHE+" is very satisfied, relaxed and content. "+HESHE+" thanks you profusely before redressing and returning to "+hisher+" tasks. You clean your cum drenched hand before going back to work, aroused from the experience.";
				} else {
					toReturn += "\n\n"+ NPCCharList.CharFollower [WorldControl.idx].charName +" happily sits and stays put, waiting for you to take the initiative. You undress "+HIMHER+" from the waist-down and expose "+hisher+" pussy, which is dry. You grab "+HIMHER+" by the hips and tell "+HIMHER+" to calm down, while with your free hand yo caress "+hisher+" clit, until "+HESHE+" grows wet.\n\nWith "+hisher+" cunt wet now, its easier to sink your fingers into "+HIMHER+", using your thumb to play with "+hisher+" clit. "+HESHE+" lies down and tries to relax, until "+heshe+" starts to finally enjoy "+HIMHER+"self at your hands. She suddenly cries out in orgasmic delight, arching her back and then resting on the bed for few minutes until "+heshe+" recovers. \n\n"+HESHE+" is very satisfied, relaxed and content. "+HESHE+" thanks you profusely before redressing and returning to "+hisher+" tasks. You clean your fluid drenched hand before going back to work, aroused from the experience.\n";
				}
			}
			return toReturn;
		case 2:
			toReturn = "You decided to give a more personal reward to "+ NPCCharList.CharFollower [WorldControl.idx].charName +", and summoned "+HIMHER+" to your chamber. \n\nWhen "+heshe+" arrives "+heshe+" is surprised that you are scantily dressed, and you invite "+HIMHER+" to sit at your side.";
			if (NPCCharList.CharFollower [WorldControl.idx].attFear > 50) {
				toReturn += "\n\n"+HESHE+" nervously approaches you and asks what "+heshe+" can do for you, but you tell "+HIMHER+" that "+heshe+" should relax since you just want to thank "+HIMHER+" for "+hisher+" hard work.";
				if (NPCCharList.CharFollower [WorldControl.idx].dickSize > 0) {
					toReturn += "\n\n"+ NPCCharList.CharFollower [WorldControl.idx].charName +" reluctantly sits and stays put, waiting for you to take the initiative. You undress "+hisher+" bottom and expose "+hisher+" dick/pussy, which is soft/dry. You kneel in front of "+HIMHER+", "+hisher+" nether parts just mere inches away. \n\nYou take "+hisher+" cock in your mouth and start to suck it, feeling it throb and harden in your mouth. Once "+ NPCCharList.CharFollower [WorldControl.idx].charName +" is at full mast you explore "+HISHER+" length and hunt out their weak spots.\n\n"+HESHE+" is panting, but it is clear that "+heshe+" needs more effort from your part if you want "+HIMHER+" to cum in your mouth. Your lips form a vacuum seal around "+HISHER+" prick and you suck even harder, noisily gulping and bobbing your head up and down.\n\nIt doesn’t take long with your increased work to reach the edge. "+ NPCCharList.CharFollower [WorldControl.idx].charName +" grabs you by the head and starts thrusting "+hisher+" hips, yelling when "+heshe+" releases "+hisher+" hot cum in your mouth while you fondle "+HISHER+" balls until they’re emptied.\n\nExhausted and relaxed, "+heshe+" thanks you before heading back to "+hisher+" tasks. You swallow most of "+hisher+" seed, but some still escapes. You sigh and change your outfit that’s smeared with saliva and cum before going back to work, aroused from the experience.";
				} else {
					toReturn += "\n\n"+ NPCCharList.CharFollower [WorldControl.idx].charName +" reluctantly sits and stays put, waiting for you to take the initiative. You undress "+hisher+" bottom and expose "+hisher+" pussy, which is dry. You kneel in front of "+HIMHER+", "+hisher+" nether parts just mere inches away. \n\nYou slowly lick "+hisher+" pussy and clit, and although "+heshe+" was reluctant at first "+heshe+" starts to get wet in no time. With "+HIMHER+" in the mood, you decide to go deeper and properly explore the insides of "+hisher+" cunt with your tongue. You hungrily penetrate "+HISHER+" box while you use your free fingers to please her pearl.\n\n"+HESHE+" starts to pant and ask for more, and you start to move faster, bobbing your head up and down while you grab her firmly by the legs. \n\n"+HISHER+" first orgasm arrives quickly, but you keep going until "+heshe+" has had a chance to soak your face with three orgasms. When "+HESHE+" finally gives in, her body flops to the mattress while she fights for breath.\n\nWhen she recovers she thanks you, saying that this has helped her a lot, before dressing back and returning to "+hisher+" tasks. You clean yourself up and change your outfit before going back to your throne room, aroused from the experience.";
				}
			} else {
				toReturn += "\n\n"+HESHE+" eagerly approaches you and asks what "+heshe+" can do for you, but you tell "+HIMHER+" that "+heshe+" should relax since you just want to thank "+HIMHER+" for "+hisher+" hard work.";
				if (NPCCharList.CharFollower [WorldControl.idx].dickSize > 0) {
					toReturn += "\n\n"+ NPCCharList.CharFollower [WorldControl.idx].charName +" happily sits and stays put, waiting for you to take the initiative. You undress "+hisher+" bottom and expose "+hisher+" dick, which is soft You kneel in front of "+HIMHER+", "+hisher+" nether parts just mere inches away. \n\nYou take "+hisher+" cock in your mouth and start to suck it, feeling it throb and harden in your mouth. Once "+ NPCCharList.CharFollower [WorldControl.idx].charName +" is at full mast you explore "+HISHER+" length and hunt out their weak spots.\n\n"+HESHE+" is panting, but it is clear that "+heshe+" needs more effort from your part if you want "+HIMHER+" to cum in your mouth. Your lips form a vacuum seal around "+HISHER+" prick and you suck even harder, noisily gulping and bobbing your head up and down.\n\nIt doesn’t take long with your increased work to reach the edge. "+ NPCCharList.CharFollower [WorldControl.idx].charName +" grabs you by the head and starts thrusting "+hisher+" hips, yelling when "+heshe+" releases "+hisher+" hot cum in your mouth while you fondle "+HISHER+" balls until they’re emptied.\n\nExhausted and relaxed, "+heshe+" thanks you before heading back to "+hisher+" tasks. You swallow most of "+hisher+" seed, but some still escapes. You sigh and change your outfit that’s smeared with saliva and cum before going back to work, aroused from the experience. ";
				} else {
					toReturn += "\n\n"+ NPCCharList.CharFollower [WorldControl.idx].charName +" happily sits and stays put, waiting for you to take the initiative. You undress "+hisher+" bottom and expose "+hisher+" pussy, which is dry. You kneel in front of "+HIMHER+", "+hisher+" nether parts just mere inches away. \n\nYou slowly lick "+hisher+" pussy and clit, and although "+heshe+" was reluctant at first "+heshe+" starts to get wet in no time. With "+HIMHER+" in the mood, you decide to go deeper and properly explore the insides of "+hisher+" cunt with your tongue. You hungrily penetrate "+HISHER+" box while you use your free fingers to please her pearl.\n\n"+HESHE+" starts to pant and ask for more, and you start to move faster, bobbing your head up and down while you grab her firmly by the legs. \n\n"+HISHER+" first orgasm arrives quickly, but you keep going until "+heshe+" has had a chance to soak your face with three orgasms. When "+HESHE+" finally gives in, her body flops to the mattress while she fights for breath.\n\nWhen she recovers she thanks you, saying that this has helped her a lot, before dressing back and returning to "+hisher+" tasks. You clean yourself up and change your outfit before going back to your throne room, aroused from the experience. ";
				}
			}
			return toReturn;
		case 3:
			if (randNum > 66) {
				return "";
			} else if (randNum > 33) {
				return "";
			} else {
				return "";
			}
		case 4:
			if (randNum > 66) {
				return "";
			} else if (randNum > 33) {
				return "";
			} else {
				return "";
			}
		default:
			return "";
		}

	}



}
