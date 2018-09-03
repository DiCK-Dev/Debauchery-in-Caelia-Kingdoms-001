using UnityEngine;
using System.Collections;

public class NPCSettlerUtilitySkill  {

	int hashcode =  GameControl.playerName.GetHashCode();
	int randNum;
	static int iterator = 0; 



	public float setUtilityCrafting(NPCData.CharClass charClass){
		iterator += 1;

		switch ((int)charClass) {
		case 0:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);
		case 1:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);
		case 2:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 3:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 4:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 35);
		case 5:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 6:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 60);
		case 7:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 50);
		case 8:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 20);
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
			return Random.Range (5, 20);
		case 13:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 14:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 55);
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
			return Random.Range (5, 25);
		case 19:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (55, 90);
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
			return Random.Range (35, 55);
		case 26:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);


		default:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);

		}

	}



	public float setUtilityFarm(NPCData.CharClass charClass){
		iterator += 1;

		switch ((int)charClass) {
		case 0:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 55);
		case 1:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 25);
		case 2:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 3:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 4:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 45);
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
			return Random.Range (5, 25);
		case 13:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 35);
		case 14:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 15:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 50);
		case 16:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);
		case 17:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 25);
		case 18:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (55, 90);
		case 19:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 25);
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
			return Random.Range (5, 20);


		default:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);

		}

	}




	public float setHouseKeeping(NPCData.CharClass charClass){
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
			return Random.Range (5, 25);
		case 3:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 4:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 75);
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
			return Random.Range (10, 45);
		case 17:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 75);
		case 18:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 55);
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




	public float setUtilityMedicine(NPCData.CharClass charClass){
		iterator += 1;

		switch ((int)charClass) {
		case 0:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 30);
		case 1:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 25);
		case 2:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 3:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 4:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 65);
		case 5:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 35);
		case 6:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 7:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 8:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 20);
		case 9:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 10:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 35);
		case 11:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 20);
		case 12:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 20);
		case 13:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 20);
		case 14:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 25);
		case 15:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 35);
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
			return Random.Range (15, 35);
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
			return Random.Range (45, 90);


		default:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);

		}

	}



	public float setUtilityAlchemy(NPCData.CharClass charClass){
		iterator += 1;

		switch ((int)charClass) {

		case 6:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (50, 90);
		case 7:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 35);
		case 11:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (0, 15);
		case 22:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (0, 35);
		case 26:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 45);
		default:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (0, 1);

		}

	}



	public float setUtilityLearning(NPCData.CharClass charClass){
		iterator += 1;

		switch ((int)charClass) {
		case 2:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 50);
		case 3:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 50);
		case 4:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (30, 75);
		case 5:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (30, 75);
		case 6:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (40, 75);
		case 7:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (40, 75);
		case 10:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 35);
		case 11:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 45);
		case 16:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 55);
		case 19:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 20);
		case 20:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 50);
		case 21:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 55);
		case 22:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (45, 80);
		case 24:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 50);
		case 25:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 50);
		case 26:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (55, 90);
		default:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (0, 10);

		}

	}



	public float setUtilityPerformance(NPCData.CharClass charClass){
		iterator += 1;

		switch ((int)charClass) {
		case 5:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 25);
		case 9:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 60);
		case 16:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 30);
		case 17:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 55);
		case 21:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 25);
		case 24:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (55, 90);
		case 25:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 25);
		

		default:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (0, 15);

		}

	}



	public float setUtilityEtiquette(NPCData.CharClass charClass){
		iterator += 1;

		switch ((int)charClass) {
		case 0:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 25);
		case 1:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (0, 10);
		case 2:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 40);
		case 3:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 40);
		case 4:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 60);
		case 5:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 65);
		case 6:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);
		case 7:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);
		case 8:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 9:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (35, 75);
		case 10:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 65);
		case 11:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 25);
		case 12:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (0, 1);
		case 13:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (0, 1);
		case 14:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);
		case 15:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);
		case 16:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (45, 65);
		case 17:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (0, 75);
		case 18:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (0, 5);
		case 19:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 20);
		case 20:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (45, 80);
		case 21:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (55, 90);
		case 22:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (35, 65);
		case 23:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 15);
		case 24:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (45, 75);
		case 25:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 45);
		case 26:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 45);


		default:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (0, 5);

		}

	}




	public float setUtilityStreetwise(NPCData.CharClass charClass){
		iterator += 1;

		switch ((int)charClass) {
		case 0:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 25);
		case 8:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (55, 90);
		case 9:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (45, 75);
		case 11:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 45);
		case 16:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 35);
		case 17:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (35, 85);
		case 19:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 25);
		case 20:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 50);
		case 21:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 55);
		case 22:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (35, 75);
		case 23:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (35, 75);
		case 24:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 55);
		case 25:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 35);



		default:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (0, 15);

		}

	}





}
