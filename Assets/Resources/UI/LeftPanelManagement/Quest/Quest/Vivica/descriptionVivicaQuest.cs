using UnityEngine;
using System.Collections;

public class descriptionVivicaQuest : MonoBehaviour {

	static int iVivica; 

	void loadVivica(){
		iVivica = 0;

		while (iVivica < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iVivica].charID == 8000){
				WorldControl.NPCID = NPCCharList.CharFollower [iVivica].charID;
				WorldControl.PortraitIDLayer0 = NPCCharList.CharFollower [iVivica].charPortraitLayer0;
				WorldControl.PortraitIDLayer1 = NPCCharList.CharFollower [iVivica].charPortraitLayer1;
				WorldControl.PortraitIDLayer2 = NPCCharList.CharFollower [iVivica].charPortraitLayer2;
				WorldControl.furryPic = NPCCharList.CharFollower [iVivica].isFurry;
				WorldControl.futaPic = NPCCharList.CharFollower [iVivica].isFuta;
				break; 
			}
			iVivica++;

		}

	}


	public string retDescription(){

		if (QuestControl.vivicaQuest < 14) 
		{
			switch (QuestControl.vivicaQuest) 
			{
			case 0:
				return "One of your servants called you, because something urgent happened in the castle and they require your assistance. Someone said something about \"Magic\". What does it mean?";
			case 1:
				return "Your sister has finally returned home. You want to talk a bit with her, before inquiring about her past. To rebuild the bridges burned due to the passages of time.";
			case 2: 
				return "You can see that she has changed since the last time you've seen her. It was the Plague? She doesn't seems to be Plagued. It has something to do with her magic? There are a lot of questions and the only one who has the answers, shares your blood.";
			case 3:
				return "You've been wondering about the magic that your sister wields, and you want to see if she could be able to teach you more about it, as you are quite curious about it. ";
			case 4:
				return "Vivica told you that maybe you can be a spellcaster after all. The first step is to be able to understand magic, as knowledge seems to be the key to success.";
			case 5:
				return "The first School is Destruction, your sister's favorite. It seems to be the easiest one. You wonder if you'll be able to learn it properly.";
			case 6:
				return "The School of Persuasión seems to be one of the most interesting to learn. To be able to control your opponent's urges and emotions seems to be quite useful in your travels.";
			case 7:
				return "As your comprehension of magic grows, so does your curiosity about the School of Restoration, the magic that affects your own body. You only can wonder about the limits of its magic.";
			case 8:
				return "Finally, the School of Entropy. From what you've heard, its the most abstract school and one of the hardest to master. You feel confident in your abilities, so you tackle the subject as fast as you can.";
			case 9:
				return "";
			case 10:
				return "You know that your sister is bound to something unknown. It influences her more than you can imagine. Its time to do something about it.";
			case 11:
				loadVivica ();
				if (NPCCharList.CharFollower [iVivica].corruptionStage >= 4) {
					return "She is on the right path, but being a paws of someone else is dangerous. Time to change the one who is influencing her.";
				} else {
					return "You know that she is getting too corrupted by that creature. You must convince her to cut the feeding bond that anchors her to it or lose her forever. ";
				}
			case 12:
				loadVivica ();
				if (NPCCharList.CharFollower [iVivica].corruptionStage >= 4) {
					return "As both of you investigate further on the matter, you found out that you have to make a very important choice on the outcome of the ritual.";
				} else {
					return "Now that she accepted your help. Its time to show her something that is stronger than any spell she can cast at the moment.";
				}
			case 13:
				loadVivica ();
				if (NPCCharList.CharFollower [iVivica].corruptionStage >= 4) {
					return "Everyone is ready. Now its time to show that creature who that it shouldn't meddle with you and your sister.";
				} else {
					return "Every piece already fell into its place, now its time to free your sister once and for all from this demonic taint, with the help of your mother.";
				}
			case 14:
				return "quest 14 - bug";
			}
		}

		return "bug";
	}


}
