using UnityEngine;
using System.Collections;

public class CityControl : MonoBehaviour {

	static CityControl instance; 



	// save v1.0

	/// <summary>
	/// 	//Aororum 100 /// ///////////////////////////////////
	/// </summary>

	public static float city100Prosperity = 3; 
	public static float city100ProsperityBonus = 0;
	public static float city100Order = 10;
	public static float city100Happiness = 15;
	public static float city100Corruption = 15; 
	//new
	public static float city100Infrastructure = 25;
	public static float city100Education = 10;
	public static float city100Defense = 35; 
	public static float city100Piety = 85;




	public static int[] city100Slaves = new int[90]; //  100 bunny(0), 110 wolf(1), 120 plant(2), 130 equine(3), 140 dodo(4), 150 chinchilla(5)


	public static bool city100DowntownMeet = false; 
	//agora
	public static bool city100AgoraMeet = false; 

	public static bool city100BathMeet = false; 
	public static int city100BathLevel = 0;

	public static bool city100ColosseumMeet = false; 
	public static int city100ColosseumLevel = 0;  

	public static bool city100GymMeet = false; 

	public static bool city100AmphitheatreMeet = false; 
	public static int city100AmphitheatreLevel = 0; 
	//market
	public static bool[] city100MarketMeet = new bool[10];  // Market[0], Potion store[1], tailor - 1000[2], Blacksmith[3], Inn[4], slave market[5], tattoo[6], gym[7]


	// Church
	public static bool city100ChapelMeet = false; 
	public static int city100ChapelLevel = 0; 
	public static int[] city100ChapelWorkers = new int[50]; // Here it saves the ID of the one who is working, 0 priest, 1 head inquisitor, 2 captain of the sisters, 3 Abbess, 10-14 acolyte, 15-19 nun/monk, 20-24 inquisitors, 25-29 sisters 
	public static int[] city100ChapelEfficiency = new int[10]; // it defines both the overall and specific efficiency. 0 all church, 1 priest job, 2 inquisitors, 3 sisters, 4 nuns/monsk. Goes from 0 to 100 
	public static float city100ChapelCorruption = 0;


	//Barn
	public static bool city100BarnMeet;

	//Bordello
	public static bool city100BordelloMeet;
	public static int city100BordelloLevel = 0; 



	// MANDATES
	public static bool mandateSkimpyServitude = false; 

	public static bool[] mandatesChurch = new bool[30]; // 0 corrupt the church, 1 skimpy attires 
	public static int[] mandatesMinistersFinance = new int[10]; // 0 public slaves quota, 1 (3)defaulter punishments


	public static int city100Taxes; 
	//taxes: 0 normal, 1 low, 2 high, 3 draconian

	// ministers
	public static int[] city100Ministers = new int[10]; // stores the IDs, 0 finances, 1 chancellor, 2 justice, 3 master of shadows, 4 marshall
	public static int[] city100MinistersEfficiency = new int[10];


	// NPC CHANGES
	public static bool experimentsBodyPure;
	public static bool experimentsBodyCorrupt;
	public static bool experimentsSoulPure;
	public static bool experimentsSoulCorrupt;

	// save v1.1
		//ARMY
	public static bool armyArmourHeavy; // if else is skimpy

		// city slaves
	public static bool slavesForcedLabor; // these are triggered in quest 4 of Faustina 
	public static bool slavesSexWork;
	public static bool slavesReeducation;


	/// <summary>
	/// 	// 200 /// ///////////////////////////////////
	/// </summary>

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
