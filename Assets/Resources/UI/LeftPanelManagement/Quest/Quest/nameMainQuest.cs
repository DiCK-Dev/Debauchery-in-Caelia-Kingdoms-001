using UnityEngine;
using System.Collections;

public class nameMainQuest : MonoBehaviour {




	public string retName()
	{
		
		if (QuestControl.helenaQuest < 10) {
			switch (QuestControl.helenaQuest) {
			case 0:
				return "Baby steps. ";
			case 1: 
				return "Earning her trust.";
			case 2: 
				return "The first choice.";
			case 3: 
				if (QuestControl.helenaCorrupt == true) {
					return "Helena’s corruption - The struggle. ";
				} else {
					return "Helena’s salvation - The importance of romance.";
				}

			case 4: 
				if (QuestControl.helenaCorrupt == true) {
					return "Helena’s corruption - Lust. ";
				} else {
					return "Helena’s salvation - Self-love.";
				}

			case 5: 
				return "Helena’s corruption - Deep desires.";
			case 6: 
				return "Helena’s corruption - The final push.";
			case 7: 
				if (QuestControl.helenaCorrupt == true) {
					return "Obedience.";
				} else {
					return "The spark.";
				}

			case 8: 
				if (QuestControl.helenaSlave == true) {
					return "Slave training.";
				} else if (QuestControl.helenaDominant == true) {
					return "Like a boss.";
				} else {
					return "Crushing her spirit.";
				}
			
			case 9: 
				return "What’s next? ";

			default: 
				return "This is the default on Helena's description, its a bug, report it.";

			}
		}


		if (QuestControl.abbadonQuest < 10) {
			switch (QuestControl.abbadonQuest) {
			case 0:
				return "Meeting Abbadon";
			case 1: 
				return "Abbadon’s past";
			case 2: 
				return "Abbadon’s identity";
			case 3: 
				return "The choice";
			case 4: 
				return "A step in the right direction";
			case 5: 
				if (QuestControl.abbadonCorrupt == true) {
					return "Corrupting Abbadon: Tormented";
				} else {
					return "Purifying Abbadon: Tormented";
				}

			case 6: 
				return "Corrupting Abbadon: Violence";
			case 7: 
				return "Abbadon the corrupter";
			case 8: 
				return "Family matters";
			case 9: 
				return "The next step ";

			default: 
				return "This is the default on Abbadon's description, its a bug, report it.";

			}
		}


		if (QuestControl.lucinaQuest < 9) {
			switch (QuestControl.lucinaQuest) {
			case 0:
				return "Reunion";
			case 1: 
				return "It has been a while…";
			case 2: 
				return "The Symbiote";
			case 3: 
				return "The City’s Shadow";
			case 4: 
				return "Winds of Change";
			case 5: 
				if (QuestControl.lucinaCorrupt) {
					return "Descent into Depravity";

				} else {
					return "The Long Road to Purity";

				}
			case 6: 
				if (QuestControl.lucinaCorrupt) {
					return "As the Defiling Rises";

				} else {
					return "The Light at the End";

				}
			case 7: 
				return "Transcend";
			case 8: 
				if (QuestControl.lucinaCorrupt) {
					return "Mother’s Instincts";

				} else {
					return "Mother’s Wisdom";

				}
			

			default: 
				return "This is the default on Helena's description, its a bug, report it.";

			}
		}



		if (QuestControl.itzelQuest < 7) {
			switch (QuestControl.itzelQuest) {
			case 0:
				return "A sweet encounter.";
			case 1: 
				return "The path of truth.";
			case 2: 
				return "Earning her loyalty.";
			case 3: 
				return "The last stone.";
			case 4: 
				return "Tuning the cog.";
			case 5: 
				if (QuestControl.itzelCorrupt) {
					return "Everything to help.";
				} else {
					return "The cost of sin.";
				}

			case 6: 
				return "The next piece.";

			default: 
				return "This is the default on Itzel description, its a bug, report it.";

			}
		}


		if (QuestControl.virgilQuest < 6) {
			switch (QuestControl.virgilQuest) {
			case 0:
				return "First steps.";
			case 1: 
				return "A lesson in attitude.";
			case 2: 
				return "The wingman.";
			case 3: 
				return "Learning time!";
			case 4: 
				return "Time out.";
			case 5: 
				return "Last session.";
				


			default: 
				return "This is the default on Itzel description, its a bug, report it.";

			}
		}


		if (QuestControl.celiaQuest < 7) {
			switch (QuestControl.celiaQuest) {
			case 0:
				return "New Curriculum";
			case 1: 
				if (QuestControl.celiaStartCorrupt) {
					return "The snake's den.";
				} else {

					return "Prologue";
				}

			case 2: 
				if (QuestControl.celiaStartCorrupt) {
					return "By the book";
				} else {

					return "Power";
				}

			case 3: 
				if (QuestControl.celiaStartCorrupt) {
					return "Out with the old";
				} else {

					return "Having fun";
				}

			case 4: 
				if (QuestControl.celiaStartCorrupt) {
					return "Crossroads";
				} else {

					return "Hidden truth";
				}

			case 5: 
				return "The elixir";
			case 6:
				return "Final grade";

			default: 
				return "This is the default on Itzel description, its a bug, report it.";

			}
		}

		if (QuestControl.lucretiusQuest < 7) {
			switch (QuestControl.lucretiusQuest) {
			case 0:
				return "Wrecking change.";
			case 1: 

				return "Recovery.";


			case 2: 

				return "The future.";

			case 3: 
				return "Lab rat.";

			case 4: 
				return "Results.";


			case 5: 
				return "Progress.";
			case 6:
				return "The last stand.";

			default: 
				return "This is the default on Lucretius description, if you see it it's a bug, report it.";

			}
		}

		if (QuestControl.faustinaQuest < 5) {
			switch (QuestControl.faustinaQuest) {
			case 0:
				return "First encounter.";
			case 1: 
				return "Inspecting the troops.";
			case 2: 
				return "Patrolling.";
			case 3: 
				return "Bottles of wine.";
			case 4: 
				return "Rebuilding Aurorum.";

			default: 
				return "This is the default on Faustina description, if you see it it's a bug, report it.";

			}
		}




		return "End of the content for now."; 


	}


}
