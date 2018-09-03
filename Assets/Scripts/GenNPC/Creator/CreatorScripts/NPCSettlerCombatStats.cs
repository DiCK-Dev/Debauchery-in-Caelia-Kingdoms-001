using UnityEngine;
using System.Collections;

public class NPCSettlerCombatStats : MonoBehaviour {
	static int iterator = 0;
	int hashcode = GameControl.playerName.GetHashCode();
	int randNum;



	public float setMaxHealth(NPCData.CharRace charRace){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 

		switch (charRace) {
		case NPCData.CharRace.Wolf:
			return Random.Range (90, 130);
		case NPCData.CharRace.Equine:
			return Random.Range (110, 170);
		case NPCData.CharRace.succubus:
			return Random.Range (70, 110);
		case NPCData.CharRace.incubus:
			return Random.Range (70, 110);
		case NPCData.CharRace.Bunny:
			return Random.Range (60, 100);
		default:
			return Random.Range (80, 130);
		}

	}
		

	public float setMaxArousal(NPCData.CharRace charRace){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 

		switch (charRace) {
		case NPCData.CharRace.Wolf:
			return Random.Range (70, 120);
		case NPCData.CharRace.Equine:
			return Random.Range (60, 100);
		case NPCData.CharRace.succubus:
			return Random.Range (100, 160);
		case NPCData.CharRace.incubus:
			return Random.Range (100, 160);
		case NPCData.CharRace.Bunny:
			return Random.Range (80, 150);
		default:
			return Random.Range (80, 130);
		}

	}


	public float setMaxMP(NPCData.CharRace charRace, NPCData.CharClass charClass){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		float retvalue = 1; 

		switch (charClass) {
		case NPCData.CharClass.Alchemist:
			retvalue += Random.Range (30, 70);
			break;
		case NPCData.CharClass.Mystic:
			retvalue += Random.Range (70, 140);
			break;
		case NPCData.CharClass.DarkPaladin:
			retvalue += Random.Range (40, 90);
			break;
		case NPCData.CharClass.Inquisitor:
			retvalue += Random.Range (30, 80);
			break;
		case NPCData.CharClass.Paladin:
			retvalue += Random.Range (40, 80);
			break;
		case NPCData.CharClass.Priest:
			retvalue += Random.Range (10, 100);
			break;
		case NPCData.CharClass.Scholar:
			retvalue += Random.Range (20, 50);
			break;
		case NPCData.CharClass.Monk:
			retvalue += Random.Range (30, 70);
			break;
		default:
			retvalue += Random.Range (10, 50);
			break;  
		}



		switch (charRace) {
		case NPCData.CharRace.succubus:
			return retvalue += Random.Range (50, 150);
		case NPCData.CharRace.incubus:
			return retvalue += Random.Range (50, 150);
		case NPCData.CharRace.angel:
			return retvalue += Random.Range (50, 150);
		default:
			return retvalue += Random.Range (0, 30);
		}


	}



}
