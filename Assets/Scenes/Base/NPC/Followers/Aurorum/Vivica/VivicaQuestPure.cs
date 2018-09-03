using UnityEngine;
using System.Collections;

public class VivicaQuestPure {

	static int iVar;
	static string toRet; 

	public static string pureQuest(int selector){
		iVar = loadChar (8000);

		switch (selector) {
		case 0:
			iVar = loadChar (6000);

			toRet = "After you finished your duties, you decide to return to see what was all that fuss that she talked about last time. You weren’t sure what to say about it, but you decided to tackle the situation directly and deal with it as soon as possible. As you arrive at the castle, the maids are in disarray as they gossip, with commotion in the background. You ask one of the maids about what is going on but you get no answer at first, until one of them stands out and starts talking.\n\n<i>“Oh thank the gods you’re here, my liege”</i> she says. <i>Someone flew into the castle through one of the windows. We don’t know what to do! The guards were unable to deal with the situation, so your "+NPCCharList.CharFollower [iVar].relX+" decided to intervene…”</i> You’re surprised that your "+NPCCharList.CharFollower [iVar].relX+" decided to do such a thing. <i>“We tried to stop her, but she was too fast! Right now, she is trying to stop it at your studio.”</i> \n\nShe says, as you can hear two voices coming from the corridor that leads to your management studio. As you hurry through it, you notice that the entire environment is trashed. You pass through all the destroyed artwork and vases, as well as all the servants who are too afraid to move or flee. Arriving at the door to your studio, you force it open using your shoulder. What you stumble upon is your "+NPCCharList.CharFollower [iVar].relX+" trying to have a discussion with a woman, who was shouting at the top of her lungs.";
			if (NPCCharList.CharFollower [iVar].attMorality <= 0) {
				toRet += "\n\n<i>“Vivica! Oh my sweetheart! You’re back hun! I was so worried about you. Where have you been this whole time?,”</i> you can hear your "+NPCCharList.CharFollower [iVar].relX+" saying as she tried to approach the girl.";
			} else if (NPCCharList.CharFollower [iVar].attMorality >= 100 && NPCCharList.CharFollower [iVar].charCorruption >= 66) {
				toRet += "\n\n<i>“Vivica! Oh my dear "+NPCCharList.CharFollower [iVar].relCF+", you’re back. I was so worried about you. Where have you been this whole time?,”</i> You can hear your "+NPCCharList.CharFollower [iVar].relX+" saying as she slides with her slime body close to her, but that girl dodged her and point at your "+NPCCharList.CharFollower [iVar].relX+" with her index finger.";
			} else if (NPCCharList.CharFollower [iVar].attMorality >= 100 && NPCCharList.CharFollower [iVar].charCorruption < 66) {
				toRet += "\n\n<i>“Vivica! My "+NPCCharList.CharFollower [iVar].relCF+"! You’re back!”</i> You can hear your "+NPCCharList.CharFollower [iVar].relX+" saying in her guttural voice as she slides with her slime body close to her, but that girl dodged her and point at your "+NPCCharList.CharFollower [iVar].relX+" with her index finger.";
			} else {
				toRet += "\n\n<i>“Vivica! Vivica!”</i>  Lucina apparently has recognized the other girl, saying her name out loud. Your "+NPCCharList.CharFollower [iVar].relX+" slides and approaches her, but she dodges her and points at your "+NPCCharList.CharFollower [iVar].relX+" with her index finger.";
			}
			toRet += "\n\nYou start to remember that name, as you’re quite sure that is your "+  NPCCharList.CharFollower [loadChar(8000)].relSF +"’s name. There was a level of familiarity with this person, yet you never really knew anyone who had horns and wings. Has she been inflicted with corruption? At least she doesn’t seem to have lost her mind... yet <i>“What happened, "+NPCCharList.CharFollower [iVar].relX+"? What happened to you? Did my uncle did this to you?! That bastard! I’ll make him pay!”</i> she says in an infuriated tone, looking around obviously confused.  \n\nAfter a couple of seconds, both of them look at you as you approach. Your "+  NPCCharList.CharFollower [loadChar(8000)].relSF +" has bright red skin, white hair, yellow eyes, with horns coming out of her head and bat-like wings with a tail that looks dangerously sharp. A closer look shows you that she is wearing some cloth that is clasped to her back and barely covering her lady bits. At first, you can see that some sparks come out from her hand, surprising you. That’s magic… Your "+  NPCCharList.CharFollower [loadChar(8000)].relSF +" knows magic? Is that why she has been away for so long?. <i>“Who are you?! Are you one of those puny guards?”</i> she says in a demanding tone. You stand straight and point at her with your index finger, asking her if she was the one responsible of injuring your guards. After a couple of seconds of silence, your "+  NPCCharList.CharFollower [loadChar(8000)].relSF +" takes a good look at you and takes a step closer, her magic dwindling a bit. <i>“Is that you "+GameControl.playerName+"?!”</i>\n\nAfter that question, you lower your hand slowly and nods, with your body still rigid, refusing to back down. You’re not sure of her intentions for now, but you want to know them. After that, she stands straight as her magic disappears from her hand, her eyes fixed over you. After that, she uses her wings to propel herself in your direction as you get a hand over your weapon. But when you thought that she would strike you with magic, she hugs you with her delicate arms and presses herself against you. You can hear light, muffled sobbing from her before she speaks. <i>I thought you were dead, "+GameControl.playerName+"! Last time I saw you was that during that fateful night! I thought you were…</i> she says before rubbing her face against your chest, cleaning her tears in your clothes. You sigh and hug her back a bit, waiting for her to calm down.\n\nWhen you see that she finally calms down, you explain her that you must repair the damage that she did to the castle and to your servants, as you are now the ruler of the city. You tell her that she can take any room she likes and get some rest. There is much to talk about her time away from you, but you must tend to your workers first. She nods and cleans herself up before leaving, as your onlookers begin to avoid her as she draws near.";
			return toRet;

		}

		return "This is a bug";

	}



	static int loadChar(int id){
		int i = 0;
		while (i < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [i].charID == id){
				return i;
			}
			i++;

		}
		return 0;

	}

}
