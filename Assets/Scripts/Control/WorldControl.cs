using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WorldControl : MonoBehaviour {
	/// <summary>
	/// here you control both the state of the world, like loot, enemies, etc. to cities and generic NPCs. For main char go to GameControl and
	/// FollowersControl for followers 
	/// </summary>

	public static WorldControl control; 
	static WorldControl instance; // instance to only have one 
	// navigation


	// PARTY members
	public static int partyID1, partyID2, partyID3; 

	// SYS UI
	public static int fontSize = 18; 

	//SYSTEM - SAVE
	public static bool furryOn = true; // If true,furry portraits will load. 
	public static bool futaOn = true;
	public static bool furryPic;
	public static bool futaPic; 
	public static bool[] tagControl = new bool[20]; //0 Dominant, 1 Submissive, 2 Romantic, 3 Feral, 4 Cumslut, 5 Public use, 6 Cruel, 7 Incest

	// World info - SAVE 
	public static int day = 1; // day counter
	public static int dayTime = 0; // the day is divided in 6 phases, 3 days, 3 night. 
	public static string dayTimeName = "Morning"; 
	public static int escortNPC1 = 0; 


	// Map control SAVE
	public static bool[] storyChapter = new bool[6]; // 0 ch2, 1 ch3, 2 ch4, 3 ch5 an extra chap? aftermath?
	public static bool[] chapter1Locations = new bool[15]; //0 plains, 1 mountains, 2 town1, 3 town2, 4 town3, 5 town4, 6 town5, 7 city1, 8 kujiang, 9+ unused 

	//General - dont save 
	public static string location = "Scene"; // location of the player, this should not be saved but loaded at the awake of the scene 
	public static bool nightSummary = false; // this determines if you already had the night event to avoid changing everytime you enter the base



	//stash
	public static int[,] stashCons = new int[10,2];
	public static int[,] stashEquip = new int[10,2];
	public static bool stashFull = false; 

	/// ////////////////////////

	//loot and items 
	public static int invDelItem; // Var used to delete from invent
	public static int dropItem = 0; // Variable que se usa para recoger el loot, su valor 0 = nada
	public static int dropGold = 0; 
	public static bool invFull; 
	public static int switchItem = 0; 
	public static bool wasEquiped = false; 
	public static string itemUseText; 



	//Combat system
	public static int turnCounter; 
	public static int enemyID = 0; // to call the image 
	public static int skillID = 0; // used in SkillFun and LustFun to calculate the damage
		//follower in combat

	// combat phase and summary

	public static float charComDefense = 0f; // defense from the armour 
	public static float charLustDefense = 0f;  // defense from the armour 

	public static float charComAttackArmor = 0f; // Extra will attack from armour // all equipment, not just armor
	public static float charComAttackWeapon = 0f; // Extra will attack from weapon
	public static float charLustAttackArmor = 0f; // extra lust attack from armour // all equipment, not just armor
	public static float charLustAttackWeapon = 0f; // extra lust attack from weapon


	public static float enemyHP = 0; 
	public static float enemyLust = 0;
	public static float enemyMaxHP = 100; 
	public static float enemyMaxLust= 100;
	public static float enemyAttack;
	public static float enemyCombDefense= 0.2f; // dmg reduction
	public static float enemyLustDefense; 

	public static bool enemyStunned = false;
	public static int eneStunCounter = 0; 


	// enem data


	public static string eneName = ""; // name of the monster
	public static string eneRace = ""; // race of the enemy
	public static string eneComType = "Enemy Type";  // name for the UI
	public static string eneLustType = "Enemy LustType"; // name for the UI
	public static string eneDescription; // at the start of the scene
	public static string charAttackDescription; // here the description of your attack is stored, which will go to the summaruy
	public static string eneAttackDescription; // stored here just for the summaryu


	// combat end texts
	public static string textVictory = "victory text";
	public static string textDefeat = "defeat text"; 
	public static string textSubmit = "Submit text";


	//NPC 
	public static int NPCID; 
	public static int idx = -1; 
	public static int PortraitIDLayer0; 
	public static int PortraitIDLayer1;
	public static int PortraitIDLayer2;






	void Awake () 
	{
		WorldControl.NPCID = 0;

		if (instance != null) 
		{
			Destroy (this.gameObject);
			return; 

		}
		else 
		{
			instance = this; 
			GameObject.DontDestroyOnLoad (this.gameObject);
		}
			
	}
		
}
