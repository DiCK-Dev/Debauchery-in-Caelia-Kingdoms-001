using UnityEngine;
using System.Collections;

public class punishmentTextPsychological {


	public static string sceneText(int selector){
		float randNum = Random.Range(0f, 100f);
		string toReturn = ""; 
		string heshe = "he", hisher = "his", himher = "him", HESHE = "He", HISHER = "His", HIMHER = "Him"; 
		if (NPCCharList.CharFollower [WorldControl.idx].charGender == NPCData.CharGender.FEMALE) {
			heshe = "she"; hisher = "her"; himher = "her"; HESHE = "She"; HISHER = "Her"; HIMHER = "Her"; 
		}

		switch (selector) {
		case 0:
			toReturn = "You’ve heard that "+ NPCCharList.CharFollower [WorldControl.idx].charName +" has not been as productive as needed lately. You call "+himher+" to your main hall to discuss their recent issue and how to return to former productivity.\n\nAs you begin to discuss their failures, "+heshe+" begins to offer weak excuses regarding "+hisher+" situations, but these are things that you have heard before, from the laziest of workers. You do not feel anger at these excuses, just disappointment. You tell "+himher+" to straighten up and get it together or else you may have to begin punishments for "+hisher+" inability to properly work.\n\nAs "+ NPCCharList.CharFollower [WorldControl.idx].charName +" begins to leave, you call them a fool to let this become a problem.";
			return toReturn;
		case 1:
			toReturn = ""+ NPCCharList.CharFollower [WorldControl.idx].charName +" once again is brought to your hall upon demerit from "+ NPCCharList.CharFollower [WorldControl.idx].charName +"’s boss.  The look in "+hisher+" eyes was that of pure fear. This was not the first time you had to lecture "+himher+", but this time, you feel a little bit of anger mixed with your disappointment. You look down upon "+himher+", who barely can look you in the eyes.\n\nYou begin to call "+ NPCCharList.CharFollower [WorldControl.idx].charName +" a complete fool for letting the same problems continue again and again. Your voice begins to grow as you start letting the insults towards them fly. You immediately take away their food privileges for the night, threatening to lock "+himher+" up with the horses over the night. "+ NPCCharList.CharFollower [WorldControl.idx].charName +" begins to show remorse, which is barely enough for you to enact these threats fully, instead sending "+himher+" back to their "+hisher+" quarters for the rest of the day.\n\nYou begin to wonder if "+ NPCCharList.CharFollower [WorldControl.idx].charName +" is a lost cause…";
			return toReturn;
		case 2:
			toReturn = ""+ NPCCharList.CharFollower [WorldControl.idx].charName +"’s poor work ethic has begun to affect the other workers, and word of this has begun to spread amongst the working class that serve you immediately. When word reaches you, you pick several members of your personal guard to accompany you to the workplace of "+ NPCCharList.CharFollower [WorldControl.idx].charName +".\n\nArriving there, you immediately walk past the other workers and supervising foreman, and instead go directly to "+ NPCCharList.CharFollower [WorldControl.idx].charName +". Looking them in the eyes, you slap them across the face as hard you can, putting in good measure so the other workers see your discipline. You circle around "+ NPCCharList.CharFollower [WorldControl.idx].charName +", telling and reminding "+himher+" of your last lecture and what this means. You call "+himher+" trash amongst all others who work and make sure that all your other workers take note that this could happen if they follow the footsteps of "+ NPCCharList.CharFollower [WorldControl.idx].charName +".\n\nYou end your lecture by spitting on "+ NPCCharList.CharFollower [WorldControl.idx].charName +", right in the eye as you turn your back to them and begin your hike back to the palace.";
			return toReturn;
		case 3:
			toReturn = ""+ NPCCharList.CharFollower [WorldControl.idx].charName +" continues to be unproductive and slow within their field of work. You call "+himher+" to your hall once again. When "+heshe+" arrives, "+heshe+" is confronted with the view of one of your guards beating a worker ruthlessly for your viewing pleasure.\n\nYou notice "+ NPCCharList.CharFollower [WorldControl.idx].charName +" has arrived and you greet "+himher+", asking how work has been. Heshe is hesitant to answer the question, eyes glued to the violence happening at "+hisher+" side. You take notice of that and mention that this is something that happens to those who do not work well within the kingdom or disobey your orders. "+ NPCCharList.CharFollower [WorldControl.idx].charName +" continues to stare but seems to understand your words as they begin to sweat profusely.\n\nYou excuse "+ NPCCharList.CharFollower [WorldControl.idx].charName +", who proceeds to run back to their working quarters, hopefully to be more productive.";
			return toReturn;
		case 4:
			toReturn = ""+ NPCCharList.CharFollower [WorldControl.idx].charName +"’s foolish and lazy work ethic continues. Once word of this travels to you, you have your guards bring the fool to you and drag them down to the dungeons. You wait for "+himher+" to arrive there, and do your best to greet "+himher+" as the guards chain the lazy fool to the walls. "+ NPCCharList.CharFollower [WorldControl.idx].charName +" begins to sweat and panic, knowing how badly they have messed up doing their job over the last few instances.\n\nYou know that you will not be torturing them today, but these failures "+ NPCCharList.CharFollower [WorldControl.idx].charName +"commits is something that you cannot just ignore anymore. "+ NPCCharList.CharFollower [WorldControl.idx].charName +" tries to speak but doesn’t manage to get any words out as "+heshe+" looks around at the dungeon and all those who are suffering within it. You begin to lecture "+himher+" about how failure within your land can be seen as heresy against you, and that those who work against yourself get sentenced to punishments down here. ";
			return toReturn;
		case 5:
			toReturn = "You’ve summoned "+ NPCCharList.CharFollower [WorldControl.idx].charName +" once again to your hall on the accounts of "+hisher+" failure to "+hisher+" job. Your guards present "+ NPCCharList.CharFollower [WorldControl.idx].charName +" in chains, and you approach them, closely examining their body. While "+ NPCCharList.CharFollower [WorldControl.idx].charName +" continues to poorly do "+hisher+" job, "+hisher+" body has managed to be well taken care of, muscular yet soft, and extremely beautiful.\n\nYou look at "+ NPCCharList.CharFollower [WorldControl.idx].charName +" and say that "+heshe+" is perfect. You mention that you have the urge to strip "+himher+" and parade "+himher+" around the town, exemplifying what a fool looks like. At the end of that day, you even tease "+himher+" with the prospect of being fucked amongst the common folk, used as a series of holes as a gift to your people.\n\n"+ NPCCharList.CharFollower [WorldControl.idx].charName +" begins to object, but you remind "+ NPCCharList.CharFollower [WorldControl.idx].charName +" of all the chances you have bestowed upon "+himher+", and that your everlasting patience is nonexistent at this point. Heshe realizes that this is "+hisher+" last chance that you will give out, and that you have always upheld your punishment deals to everyone who have defied or misbehaved within your rule. "+ NPCCharList.CharFollower [WorldControl.idx].charName +" silently agrees to the future punishment, and you cheerfully remind them to “keep up the good work” before sending "+himher+" back out into the public. Part of you hopes that "+heshe+" fails again, for you will have quite the show…";
			return toReturn;
		case 6:
			toReturn = "You will not stand for foolishness of this magnitude to continue within the kingdom. "+ NPCCharList.CharFollower [WorldControl.idx].charName +" has gotten away with too much for too long. Upon hearing of "+hisher+" latest actions and failures, you have the royal guard obtain "+himher+" through a quick arrest. Heshe is presented to you in chains as you begin to approach them in the dungeon.\n\nNo more games, no more intimidation. Should "+ NPCCharList.CharFollower [WorldControl.idx].charName +" continue to be a foolish peasant that disobeys your word, you will have them put to death. Hisher face goes pale when you say that. You leave upon saying this, letting "+himher+" rot down below for a few hours before a guard undoes the chains. This is the last chance for "+ NPCCharList.CharFollower [WorldControl.idx].charName +".";
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
