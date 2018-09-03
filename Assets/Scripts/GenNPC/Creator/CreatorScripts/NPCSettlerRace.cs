using UnityEngine;
using System.Collections;

public class NPCSettlerRace : MonoBehaviour {
	static int iterator = 0;
	int randNum;
	int hashcode = GameControl.playerName.GetHashCode();



	public NPCData.CharRace setRace(int selector, int specificselector){
		iterator += 1;

		switch (selector) {
		case 0:
			return NPCData.CharRace.Human;
		case 1: 
			return setFurry (specificselector);
		case 2:
			return setAvian (specificselector);
		case 3:
			return setAquatic (specificselector);
		case 4:
			return setExotic (specificselector);
		default:
			return setRandomRace ();
		}
			

	}

	NPCData.CharRace setRandomRace(){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		randNum = Random.Range (0, 100);
		if (randNum >= 70) {
			return NPCData.CharRace.Human;
		} else if (randNum >= 40) {
			return setFurry (1000);
		} else if (randNum >= 20) {
			return setAvian (1000);
		} else if (randNum >= 5) {
			return setExotic (1000);

		} else {
			return setFurry (1000);
			//return setAquatic ();
		}
	}

	NPCData.CharRace setFurry(int selector){
		iterator += 1;
		int min = (int)NPCData.CharRace.FURRYOPEN + 1;
		int max = (int)NPCData.CharRace.FURRYCLOSE -1; 
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 

		if (selector >= min && selector <= max) {
			return (NPCData.CharRace)selector;

		}
		randNum = Random.Range (min, max);
		return (NPCData.CharRace)randNum;
	}

	NPCData.CharRace setAvian(int selector){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		int min = (int)NPCData.CharRace.AVIANOPEN + 1;
		int max = (int)NPCData.CharRace.AVIANCLOSE; 

		if (selector >= min && selector <= max) {
			return (NPCData.CharRace)selector;
		}
		randNum = Random.Range (min, max);
		return (NPCData.CharRace)randNum;

	}


	NPCData.CharRace setAquatic(int selector){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		int min = (int)NPCData.CharRace.AQUATICOPEN + 1;
		int max = (int)NPCData.CharRace.AQUATICCLOSE; 

		if (selector >= min && selector <= max) {
			return (NPCData.CharRace)selector;
		}
		randNum = Random.Range (min, max);
		return (NPCData.CharRace)randNum;

	}

	NPCData.CharRace setExotic(int selector){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		int min = (int)NPCData.CharRace.EXOTICOPEN + 1;
		int max = (int)NPCData.CharRace.EXOTICCLOSE; 

		if (selector >= min && selector <= max) {
			return (NPCData.CharRace)selector;
		}
		randNum = Random.Range (min, max);
		return (NPCData.CharRace)randNum;

	}







	public NPCData.CharRace adjustRaceGender(NPCData.CharRace charRace, NPCData.CharSex charSex){
		if (charSex == NPCData.CharSex.Man && charRace == NPCData.CharRace.succubus || charSex == NPCData.CharSex.Trap && charRace == NPCData.CharRace.succubus) {
			return NPCData.CharRace.incubus;
		}

		if (charSex == NPCData.CharSex.Woman && charRace == NPCData.CharRace.incubus || charSex == NPCData.CharSex.Dickgirl   && charRace == NPCData.CharRace.incubus || charSex == NPCData.CharSex.Futanari && charRace == NPCData.CharRace.incubus) {
			return NPCData.CharRace.succubus;
		}

		return charRace; 

	}










}
