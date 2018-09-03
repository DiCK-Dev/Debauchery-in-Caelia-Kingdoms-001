using UnityEngine;
using System.Collections;

public class NPCSettlerCoreSkills : MonoBehaviour {

	int hashcode =  GameControl.playerName.GetHashCode();
	int randNum;
	static int iterator = 0; 


	public float setCoreMartial(NPCData.CharClass charClass){

		iterator += 1;
		if (charClass == NPCData.CharClass.Alchemist) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);
		}

		if (charClass == NPCData.CharClass.Artist) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);

		}
		if (charClass == NPCData.CharClass.Barbarian) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (55, 85);

		}
		if (charClass == NPCData.CharClass.Bureaucrat) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);

		}
		if (charClass == NPCData.CharClass.Clerk) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);

		}
		if (charClass == NPCData.CharClass.CommunityWorker) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);

		}
		if (charClass == NPCData.CharClass.Diplomat) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 35);

		}
		if (charClass == NPCData.CharClass.DarkPaladin) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (55, 80);

		}
		if (charClass == NPCData.CharClass.Enforcer) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (45, 70);

		}
		if (charClass == NPCData.CharClass.Farmer) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 25);

		}
		if (charClass == NPCData.CharClass.Feral) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (65, 90);

		}
		if (charClass == NPCData.CharClass.GuildWorker) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 30);

		}
		if (charClass == NPCData.CharClass.Inquisitor) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (45, 75);

		}
		if (charClass == NPCData.CharClass.Infiltrator) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 40);

		}
		if (charClass == NPCData.CharClass.Monk) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 35);

		}
		if (charClass == NPCData.CharClass.Mystic) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 30);

		}
		if (charClass == NPCData.CharClass.Paladin) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (60, 85);

		}
		if (charClass == NPCData.CharClass.Performer) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 30);

		}
		if (charClass == NPCData.CharClass.Politician) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 30);

		}
		if (charClass == NPCData.CharClass.Priest) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 30);

		}
		if (charClass == NPCData.CharClass.Ranger) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (35, 65);

		}
		if (charClass == NPCData.CharClass.Scholar) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);

		}
		if (charClass == NPCData.CharClass.Scout) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (35, 55);

		}
		if (charClass == NPCData.CharClass.Soldier) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (50, 75);

		}
		if (charClass == NPCData.CharClass.Thief) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 55);

		}
		if (charClass == NPCData.CharClass.Warrior) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (60, 80);

		}
		if (charClass == NPCData.CharClass.Whore) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 40);

		}


		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return Random.Range (35, 70);

	}

	public float setCoreSecurity(NPCData.CharClass charClass){

		iterator += 1;
		if (charClass == NPCData.CharClass.Alchemist) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		}

		if (charClass == NPCData.CharClass.Artist) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);

		}
		if (charClass == NPCData.CharClass.Barbarian) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 45);

		}
		if (charClass == NPCData.CharClass.Bureaucrat) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);

		}
		if (charClass == NPCData.CharClass.Clerk) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 20);

		}
		if (charClass == NPCData.CharClass.CommunityWorker) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 20);

		}
		if (charClass == NPCData.CharClass.Diplomat) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 35);

		}
		if (charClass == NPCData.CharClass.DarkPaladin) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (35, 60);

		}
		if (charClass == NPCData.CharClass.Enforcer) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (50, 80);

		}
		if (charClass == NPCData.CharClass.Farmer) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 25);

		}
		if (charClass == NPCData.CharClass.Feral) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 50);

		}
		if (charClass == NPCData.CharClass.GuildWorker) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 30);

		}
		if (charClass == NPCData.CharClass.Inquisitor) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (35, 65);

		}
		if (charClass == NPCData.CharClass.Infiltrator) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (55, 90);

		}
		if (charClass == NPCData.CharClass.Monk) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);

		}
		if (charClass == NPCData.CharClass.Mystic) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);

		}
		if (charClass == NPCData.CharClass.Paladin) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (35, 75);

		}
		if (charClass == NPCData.CharClass.Performer) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);

		}
		if (charClass == NPCData.CharClass.Politician) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 30);

		}
		if (charClass == NPCData.CharClass.Priest) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 30);

		}
		if (charClass == NPCData.CharClass.Ranger) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (35, 65);

		}
		if (charClass == NPCData.CharClass.Scholar) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);

		}
		if (charClass == NPCData.CharClass.Scout) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (40, 75);

		}
		if (charClass == NPCData.CharClass.Soldier) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (45, 70);

		}
		if (charClass == NPCData.CharClass.Thief) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (55, 85);

		}
		if (charClass == NPCData.CharClass.Warrior) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 50);

		}
		if (charClass == NPCData.CharClass.Whore) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 30);

		}


		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return Random.Range (35, 70);

	}


	// which class it is. // 0 soldier,1 warrior, 2 clerk, 3 bureaucrat, 4 monk/nun, 5 priest, 6 alchemist, 7 mystic, 8 thief, 9 infiltrator, 10 paladin, 11 dark paladin, 12 feral, 13 barbarian 
	//14 scout, 15 ranger, 16 community worker, 17 whore, 18 farmer, 19 industry worker, 20 politician, 21 diplomat, 22 inquisitor, 23 enforcer, 24 Performer, 25 Artist, 26 Scholar

	public float setCoreLabor(NPCData.CharClass charClass){
		iterator += 1;

		switch ((int)charClass) {
		case 0:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 45);
		case 1:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 35);
		case 2:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 25);
		case 3:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 4:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 55);
		case 5:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);
		case 6:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 7:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 8:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 35);
		case 9:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 30);
		case 10:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);
		case 11:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 12:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 45);
		case 13:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 35);
		case 14:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 35);
		case 15:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 35);
		case 16:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 45);
		case 17:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 35);
		case 18:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (50, 90);
		case 19:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (40, 75);
		case 20:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 21:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 22:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 23:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 24:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);
		case 25:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 26:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);


		default:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);

		}

	}

	public float setCoreTactics(NPCData.CharClass charClass){
		iterator += 1;

		switch ((int)charClass) {
		case 0:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (45, 75);
		case 1:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 45);
		case 2:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 3:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 4:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 35);
		case 5:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 35);
		case 6:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 35);
		case 7:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 35);
		case 8:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (35, 65);
		case 9:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (40, 70);
		case 10:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 11:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 45);
		case 12:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 13:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);
		case 14:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (55, 85);
		case 15:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (45, 70);
		case 16:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 35);
		case 17:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 18:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 19:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 20:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);
		case 21:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 45);
		case 22:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (45, 65);
		case 23:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (45, 75);
		case 24:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 25:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 26:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 35);


		default:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);

		}

	}


	public float setCoreGovernance(NPCData.CharClass charClass){
		iterator += 1;

		switch ((int)charClass) {
		case 0:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 35);
		case 1:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 2:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 45);
		case 3:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (30, 60);
		case 4:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 70);
		case 5:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 60);
		case 6:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 7:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 8:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 9:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 10:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 35);
		case 11:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 12:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 13:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 14:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 15:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 16:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (35, 70);
		case 17:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 18:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 19:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 20:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (50, 90);
		case 21:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (35, 60);
		case 22:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 65);
		case 23:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 25);
		case 24:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 25);
		case 25:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 25);
		case 26:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 25);


		default:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);

		}

	}


	public float setStewardship(NPCData.CharClass charClass){
		iterator += 1;

		switch ((int)charClass) {
		case 0:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 1:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 2:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (50, 90);
		case 3:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (45, 85);
		case 4:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 25);
		case 5:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 6:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 7:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 25);
		case 8:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 35);
		case 9:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 10:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 11:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 12:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 10);
		case 13:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 10);
		case 14:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 15:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 16:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 35);
		case 17:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 18:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 19:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);
		case 20:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (30, 65);
		case 21:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 45);
		case 22:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 23:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 24:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 25:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 26:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 40);


		default:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);

		}

	}



	public float setCorePersuasion(NPCData.CharClass charClass){
		iterator += 1;

		switch ((int)charClass) {
		case 0:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 40);
		case 1:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 35);
		case 2:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 3:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 4:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (45, 75);
		case 5:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (55, 90);
		case 6:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 7:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 25);
		case 8:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 45);
		case 9:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (50, 85);
		case 10:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (45, 65);
		case 11:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (35, 55);
		case 12:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 13:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 14:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 35);
		case 15:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 45);
		case 16:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (55, 85);
		case 17:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (55, 85);
		case 18:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 20);
		case 19:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 20:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (50, 80);
		case 21:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (60, 90);
		case 22:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (35, 75);
		case 23:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 24:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (50, 85);
		case 25:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (45, 75);
		case 26:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);


		default:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);

		}

	}


	public float setIntrigue(NPCData.CharClass charClass){
		iterator += 1;

		switch ((int)charClass) {
		case 0:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 1:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 2:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 3:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 35);
		case 4:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 5:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (35, 80);
		case 6:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 65);
		case 7:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 65);
		case 8:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 60);
		case 9:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (35, 75);
		case 10:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 11:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 35);
		case 12:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 13:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 14:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 15:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 16:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 17:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 65);
		case 18:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 19:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 20:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (50, 80);
		case 21:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (50, 80);
		case 22:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (55, 90);
		case 23:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 20);
		case 24:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 35);
		case 25:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 26:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 25);


		default:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);

		}

	} 


	public float setDiplomacy(NPCData.CharClass charClass){
		iterator += 1;

		switch ((int)charClass) {
		case 0:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 35);
		case 1:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 2:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 25);
		case 3:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);
		case 4:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (30, 60);
		case 5:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (35, 65);
		case 6:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 7:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 8:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 9:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 10:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 35);
		case 11:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 12:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 13:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 14:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 15:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 16:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 35);
		case 17:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 25);
		case 18:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 19:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 20:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (40, 80);
		case 21:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (55, 90);
		case 22:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 35);
		case 23:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 24:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);
		case 25:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 26:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);


		default:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);

		}

	}



	public float setPlaceholder(NPCData.CharClass charClass){
		iterator += 1;

		switch ((int)charClass) {
		case 0:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 1:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 2:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 3:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 4:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 5:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 6:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 7:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 8:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 9:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 10:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 11:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 12:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 13:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 14:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 15:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 16:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 17:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 18:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 19:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 20:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 21:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 22:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 23:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 24:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 25:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 26:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);


		default:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);

		}

	}








}
