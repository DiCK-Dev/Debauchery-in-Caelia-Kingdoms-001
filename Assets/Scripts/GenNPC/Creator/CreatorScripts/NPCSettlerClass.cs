using UnityEngine;
using System.Collections;

public class NPCSettlerClass : MonoBehaviour {
	int hashcode =  GameControl.playerName.GetHashCode();
	int randNum;
	static int iterator = 0; 

	public NPCData.CharClass setClass(int selector){
		
		iterator += 1;

		switch (selector) {
		case 1000:
			return setRandom ();
		case 0:
			return NPCData.CharClass.Soldier;
		case 1:
			return NPCData.CharClass.Warrior;
		case 2:
			return NPCData.CharClass.Clerk;
		case 3:
			return NPCData.CharClass.Bureaucrat;
		case 4:
			return NPCData.CharClass.Monk;
		case 5:
			return NPCData.CharClass.Priest;
		case 6:
			return NPCData.CharClass.Alchemist;
		case 7:
			return NPCData.CharClass.Mystic;
		case 8:
			return NPCData.CharClass.Thief;
		case 9:
			return NPCData.CharClass.Infiltrator;
		case 10:
			return NPCData.CharClass.Paladin;
		case 11: 
			return NPCData.CharClass.DarkPaladin;
		case 12:
			return NPCData.CharClass.Feral;
		case 13:
			return NPCData.CharClass.Barbarian;
		case 14:
			return NPCData.CharClass.Scout;
		case 15:
			return NPCData.CharClass.Ranger;
		case 16:
			return NPCData.CharClass.CommunityWorker;
		case 17: 
			return NPCData.CharClass.Whore;
		case 18:
			return NPCData.CharClass.Farmer;
		case 19:
			return NPCData.CharClass.GuildWorker;
		case 20:
			return NPCData.CharClass.Politician;
		case 21: 
			return NPCData.CharClass.Diplomat;
		case 22:
			return NPCData.CharClass.Inquisitor;
		case 23:
			return NPCData.CharClass.Enforcer;
		case 24:
			return NPCData.CharClass.Performer;
		case 25:
			return NPCData.CharClass.Artist;
		case 26:
			return NPCData.CharClass.Scholar;
		default: 
			return setRandom ();
		 


		}
			

	}


	// which class it is. // 0 soldier,1 warrior, 2 clerk, 3 bureaucrat, 4 monk/nun, 5 priest, 6 alchemist UNC, 7 mystic UNC, 8 thief, 9 infiltrator, 10 paladin, 11 dark paladin, 12 feral, 13 barbarian 
	//14 scout, 15 ranger, 16 community worker, 17 whore, 18 farmer, 19 industry worker, 20 politician, 21 diplomat, 22 inquisitor, 23 enforcer, 24 Performer, 25 Artist, 26 Scholar


	NPCData.CharClass setRandom()
	{

		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		randNum = Random.Range (0, 257);
		if (randNum >= 253) {
			return NPCData.CharClass.Alchemist;
		} else if (randNum >= 250) {
			return NPCData.CharClass.Mystic;
		}else if (randNum >= 240) {
			return NPCData.CharClass.Warrior;
		}else if (randNum >= 230) {
			return NPCData.CharClass.Artist;
		}else if (randNum >= 220) {
			return NPCData.CharClass.Barbarian;
		}else if (randNum >= 210) {
			return NPCData.CharClass.Bureaucrat;
		}else if (randNum >= 200) {
			return NPCData.CharClass.Clerk;
		}else if (randNum >= 190) {
			return NPCData.CharClass.CommunityWorker;
		}else if (randNum >= 180) {
			return NPCData.CharClass.Diplomat;
		}else if (randNum >= 170) {
			return NPCData.CharClass.DarkPaladin;
		}else if (randNum >= 160) {
			return NPCData.CharClass.Enforcer;
		}else if (randNum >= 150) {
			return NPCData.CharClass.Feral;
		}else if (randNum >= 140) {
			return NPCData.CharClass.Farmer;
		}else if (randNum >= 130) {
			return NPCData.CharClass.GuildWorker;
		}else if (randNum >= 120) {
			return NPCData.CharClass.Inquisitor;
		}else if (randNum >= 110) {
			return NPCData.CharClass.Infiltrator;
		}else if (randNum >= 100) {
			return NPCData.CharClass.Monk;
		}else if (randNum >= 90) {
			return NPCData.CharClass.Priest;
		}else if (randNum >= 80) {
			return NPCData.CharClass.Politician;
		}else if (randNum >= 70) {
			return NPCData.CharClass.Performer;
		}else if (randNum >= 60) {
			return NPCData.CharClass.Paladin;
		}else if (randNum >= 50) {
			return NPCData.CharClass.Ranger;
		}else if (randNum >= 40) {
			return NPCData.CharClass.Scout;
		}else if (randNum >= 30) {
			return NPCData.CharClass.Scholar;
		}else if (randNum >= 20) {
			return NPCData.CharClass.Soldier;
		}else if (randNum >= 10) {
			return NPCData.CharClass.Thief;
		}else{
			return NPCData.CharClass.Whore;
		}




	}

















}
