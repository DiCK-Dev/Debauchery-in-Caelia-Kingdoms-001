using UnityEngine;
using System.Collections;

public class CombatLocationDescription : MonoBehaviour {


	static int iterator; 
	int hashcode = GameControl.playerName.GetHashCode();
	int randNum; 

	public string locationDescription(int location){
		
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		iterator++; 


		switch (location) {
			case 0:
				randNum = Random.Range (0, 2); // also is accuracy for the attackdamage script
				if (randNum == 0) {
					return "Tired of your daily duties, you decide to take some time off and have a stroll through the neighboring forest. You are relaxing at the river when you hear someone running behind you, and you immediately unsheathe your weapon and get ready to fight. ";
				} else {
					return "You are walking through the forest, scouting for new locations to expand your territories when suddenly you hear the war cry of an enemy. ";
				}


			case 13000:
				if (QuestControl.albaHelp) {
					return "You and a group of soldiers venture out of the city. In order to reach the mines, you first need to traverse the woods, where you face several ambushes by beasts, losing several of your men in the process. Eventually, you arrive at your destination, though it is with a smaller party than you set out with. You divide your diminished group in two, one led by you and the other by Alba, as it would otherwise take days to cover the long tunnels that lie ahead of you.\n\nAfter a couple of hours, you hear a soldier that you sent ahead scream. You and the group hurry forward and find him unconscious on the ground, an enormous and robust minotaur girl standing above him. The monster girl charges at you, and you order your soldiers to take defensive positions. Unfortunately, you can see that they are quivering with fear, and the woman takes them out before they can land a single damaging blow.\n\n<i>“It’s just you and me now, let’s see what you got!”</i>\n";

				} else {
				return "You take a group of soldiers to escort you and Alba to the mines. On your journey through the woods, you encounter two ambushes led by the beasts which call the place home. After defeating both however, you encounter no further trouble. Once you reach the mine, you are immediately greeted by the sight of a recently abandoned encampment.<i>”It looks like they fled into the mines. We should divide the group in two, otherwise they may escape from us.”</i> You agree, and split the group in half.\n\nAfter a couple of hours, you hear a soldier that you sent ahead scream. You and the group hurry forward and find him unconscious on the ground, surrounded by bandits.\n\nIn the middle of the room stands their leader; a fierce bunny thief who looks ready for some action <i>“Oh, are you that new blue blood taking over the city? I would be lying if I said I’ve heard much about you. You aren’t the first to waste their time trying to take over, or save that city.”</i>\n\nYour can that see your soldiers match the number of brigands, and both sides are ready to jump upon one another. \n\nShe smirks at the scene <i>“Look, there is no need for a blood bath. Maybe you can prove that you are smarter than your predecessors. Give us 100 gold coins, and we’ll join you and help you to, you know, take care of your population. If you don’t have the gold, you could just give me a fancy title, and a nice house for me and my boys to stay in.”</i>\n\nShould you employ these brigands as guards and retainers? They may create trouble in the city, and the population definitely won’t be happy. That being said, they could help you to get the city in check. Instead of this, you could just do what you had originally planned, and fiht them.\n";
				}
			default:
				return "Tired of your daily duties, you decide to take some time off and have a stroll through the neighboring forest. You are relaxing at the river when you hear someone running behind you, and you immediately unsheathe your weapon and get ready to fight. ";


		}

		




		return "Bug in CombatLocationDescription, report it";

	}




}
