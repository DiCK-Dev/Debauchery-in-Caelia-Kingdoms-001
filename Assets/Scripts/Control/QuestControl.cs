using UnityEngine;
using System.Collections;

public class QuestControl {

	//panel




	///// save version 1.0





	//Helena, first quests

	public static bool mainQuestFinished; 



	public static int helenaQuest; // this define in which stage she is. the max is  
	public static bool helenaCorrupt; 
	public static bool helenaSlave; 
	public static bool helenaDominant;

	public static int abbadonQuest; 
	public static bool abbadonGender; // true for male, false for female
	public static bool abbadonCorrupt; 
	public static bool abbadonHelp; 

	public static int lucinaQuest; 
	public static bool lucinaCorrupt; 
	public static bool lucinaSlimeQueen; 

	public static int itzelQuest; 
	public static bool itzelFollowerCornelia; //
	public static bool itzelChurchCornelia; 
	public static bool itzelCorrupt;

	public static int albaQuest; 
	public static bool albaHelp;


	public static int corruptionPoints; // used with the 3 followers only to define itzel start

	public static int vivicaCounter = 3; // it countdown begins when lucina is recruited and when it reaches 0 vivica appears. Check endturn
	public static int vivicaQuest;




	public static int virgilQuest;
	public static bool virgilCorruptMaid; // if true the futa maid, if not 
	public static bool virgilDrugs; 
	public static bool virgilNerdyGirl; // if false, it means he picked the slutty futa 
	public static bool virgilWhoreGirl;

	public static int celiaQuest;
	public static bool celiaStartCorrupt; // false is pure 
	public static bool celiaCheater; // 

	public static int lucretiusQuest;
	public static bool lucretiusStartCorrupt; // false is pure 



	///// save version 1.1

	public static int faustinaQuest; 
	public static bool faustinaStartCorrupt; 
	public static bool faustinaEqual;
	public static bool faustinaDom; // SHE IS THE DOM, NO YOUR DOM PATH
	public static bool faustinaSub; 



}
