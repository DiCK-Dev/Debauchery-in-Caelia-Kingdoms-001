using UnityEngine;
using System.Collections;

public class NPCSettlerAttacks : MonoBehaviour {
	static int iterator = 0;
	int hashcode = GameControl.playerName.GetHashCode();
	int randNum; 

	public NPCData.CharAttacks classAttacks(NPCData.CharClass charClass, NPCData.CharRace charRace){
		iterator += 1; 
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		switch (charClass) {
		case NPCData.CharClass.Soldier:
			return (NPCData.CharAttacks)Random.Range (1, 4);
		case NPCData.CharClass.Warrior:
			return (NPCData.CharAttacks)Random.Range (5, 8);
		case NPCData.CharClass.Monk:
			return (NPCData.CharAttacks)Random.Range (9, 12);
		case NPCData.CharClass.Alchemist:
			return (NPCData.CharAttacks)Random.Range (13, 16);
		case NPCData.CharClass.Thief:
			return (NPCData.CharAttacks)Random.Range (17, 20);
		case NPCData.CharClass.Infiltrator:
			return (NPCData.CharAttacks)Random.Range (21, 24);
		case NPCData.CharClass.Paladin:
			iterator += 1; 
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			randNum = Random.Range (0, 100);
			if (randNum > 85) {
				return magicAttacks();
			}
			return (NPCData.CharAttacks)Random.Range (25, 28);
		case NPCData.CharClass.DarkPaladin:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			randNum = Random.Range (0, 100);
			if (randNum > 85) {
				return magicAttacks();
			}
			return (NPCData.CharAttacks)Random.Range (29, 32);
		case NPCData.CharClass.Feral:
			return (NPCData.CharAttacks)Random.Range (33, 36);
		case NPCData.CharClass.Barbarian:
			return (NPCData.CharAttacks)Random.Range (37, 40);
		case NPCData.CharClass.Scout:
			return (NPCData.CharAttacks)Random.Range (41, 44);
		case NPCData.CharClass.Ranger:
			return (NPCData.CharAttacks)Random.Range (45, 48);
		case NPCData.CharClass.Inquisitor:
			return (NPCData.CharAttacks)Random.Range (49, 52);
		case NPCData.CharClass.Enforcer:
			return (NPCData.CharAttacks)Random.Range (53, 56);
		case NPCData.CharClass.Performer:
			return (NPCData.CharAttacks)Random.Range (57, 60);
		case NPCData.CharClass.Whore:
			return (NPCData.CharAttacks)Random.Range (61, 64);
		case NPCData.CharClass.Mystic:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			randNum = Random.Range (0, 100);
			if (randNum > 30) {
				return magicAttacks();
			}
			return (NPCData.CharAttacks)Random.Range (65, 68);
		default:
			return raceAttacks (charRace);
		}


	}

	public NPCData.CharAttacks raceAttacks(NPCData.CharRace charRace){
		iterator += 1; 
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 

		switch (charRace) {
		case NPCData.CharRace.Wolf:
			return (NPCData.CharAttacks)Random.Range (85, 89);
		case NPCData.CharRace.Bunny:
			return (NPCData.CharAttacks)Random.Range (94, 97);
		case NPCData.CharRace.succubus:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			randNum = Random.Range (0, 100);
			if (randNum > 80) {
				return magicAttacks();
			}
			return (NPCData.CharAttacks)Random.Range (90, 93);
		case NPCData.CharRace.Equine:
			return (NPCData.CharAttacks)Random.Range (98, 101);
		default: 
			return genericAttacks ();
		}


	}

	public NPCData.CharAttacks genericAttacks(){
		iterator += 1; 
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return (NPCData.CharAttacks)Random.Range (71, 82);
	}



	public NPCData.CharAttacks randomClassAttacks(){
		iterator += 1; 
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return (NPCData.CharAttacks)Random.Range (1, 68);
	}

	public NPCData.CharAttacks magicAttacks(){
		iterator += 1; 
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return (NPCData.CharAttacks)Random.Range(((int)NPCData.CharAttacks.MAGICOPEN) + 1, ((int)NPCData.CharAttacks.MagicBinds) - 1);


	}


}
