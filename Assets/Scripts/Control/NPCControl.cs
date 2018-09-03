using UnityEngine;
using System.Collections;

public class NPCControl : MonoBehaviour {

	static NPCControl instance; 



	//
	public static int dateCD = 0; // all of these are outdated, wont be used in the future
	public static int purifyCD = 0; 
	public static int corruptCD = 0; 

	//
	public static int NPCGenID = 10000000; //10 mill+ is for gen procedural NPC, 1 mill + is for generic NPC, 1000+ is for followers

	// Abbadon - Agora manager ID 1000 - Abbadon
	//public static bool npc1000Meet = false; 
//	public static int npc1000Corruption = 25; 
	public static int npc1000Relationship = 0;

	public static bool[,] npc1000Talk = new bool[3,3]; //0-past, 1-agora, 2-fashion

		//new Abbadon
	public static bool npc1000CorruptingPath; // means its being corrupted
	public static bool npc1000PurifyingPath; // this is to detect that purifycation has started
	public static int npc1000CorruptingPathStage;
	public static int npc1000PurifyingPathStage;


	// Junia - Barn manager ID 2000 - Junia
	public static bool npc200Meet = false; 
	public static bool[,] npc200Talk = new bool[5,5]; //0-past, 1-Barn, 2- Something
	public static int npc200Corruption = 25; 
	public static int npc200Relationship = 0;
	public static int npc200Issue = 0; 

	// Helena - Maid ID 3000 - Helena

	public static bool[,] npc3000Talk = new bool[3,3]; //0-past, 1-Barn, 2- Something
	public static int npc3000Corruption = 25;  // outdated  changed by corruptionStage
	public static int npc3000Relationship = 0; // outdated - changed by ingame charLove

	public static bool[] npc3000CorruptionPath = new bool[5];
	public static bool[] npc3000PurifyPath = new bool[5];
	public static bool[] npc3000EnslavePath = new bool[5];
	public static bool npc3000Broken = false; // outdated. used isBroken 
	public static bool npc3000Slave = false; // outdated, used isSlave
	public static bool[] npc3000Dominance = new bool[4];
	public static bool[] npc3000Submission = new bool[4];



	// Misaki - ID 4000
	public static bool npc4000Meet = false;
	public static bool npc4000follower = false; // when you do her quest and becomes follower
	public static bool[,] npc4000Talk= new bool[2,2]; // 0 - Past, 1 Her 
	public static int npc4000Corruption = 50; 
	public static int npc4000Relationship = 0;


	// Yoshika - ID - 5000 yoshika
	public static bool npc5000Meet = false;
	//public static bool npc5000Follower = false; // when you do his quest and becomes follower 
	public static bool[,] npc5000Talk= new bool[3,3]; // 0 - Past, 1 Her  
	//public static int npc5000Corruption = 75; 
	public static int npc5000Relationship = 0;
	public static bool[] npc5000CorruptionPath = new bool[5];
	public static bool[] npc5000PurifyPath = new bool[5];

	// Lucina - ID - 6000 
	//public static bool npc6000Incest = false; 
	public static bool npc6000CorruptPath; // means its being corrupted
	public static bool npc6000PurifyPath; // this is to detect that purifycation has started
	public static int npc6000CorruptPathStage;
	public static int npc6000PurifyPathStage;
	public static bool[] npc6000slimeQueen = new bool[5];
	public static bool[] npc6000Symbiote = new bool[5];
	public static bool[,] npc6000Talk= new bool[3,3];




	void Awake () {

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



	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
