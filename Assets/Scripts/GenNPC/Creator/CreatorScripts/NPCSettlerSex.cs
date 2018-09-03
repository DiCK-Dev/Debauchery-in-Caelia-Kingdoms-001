using UnityEngine;
using System.Collections;

public class NPCSettlerSex  {

	int hashcode = GameControl.playerName.GetHashCode();
	int randNum;
	static int iteration = 0;

	//public enum CharSex { Woman, Man, Dickgirl, Futanari, Cuntboy, Trap, Eunuch }; // 0 female, trap 5

	public NPCData.CharSex setSex(int selector)
	{
		int nameCount = (int)NPCData.CharSex.Count;
		nameCount -= 1; 
		iteration += 1;

		if (selector == 1000) {
			return setRandomSex ();
		} else if (selector < nameCount) {
			return (NPCData.CharSex)selector;
		} else {
			return setRandomSex ();

		}



	}


	public NPCData.CharGender setGender(NPCData.CharSex charSexC)
	{
		if (charSexC == NPCData.CharSex.Cuntboy || charSexC == NPCData.CharSex.Man) {
			return NPCData.CharGender.MALE;
		} else {
			return NPCData.CharGender.FEMALE;
		}

	}

	NPCData.CharSex setRandomSex(){

		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iteration); 
		randNum = Random.Range (0, 60);
		if (randNum > 50) {
			return NPCData.CharSex.Woman;
		} else if (randNum > 40) {
			return NPCData.CharSex.Man; 
		} else if (randNum > 30) {
			if (WorldControl.futaOn) {
				return NPCData.CharSex.Dickgirl; 
			} else {
				return NPCData.CharSex.Man; 
			}

		} else if (randNum > 20) {
			if (WorldControl.futaOn) {
				return NPCData.CharSex.Futanari;
			} else {
				return NPCData.CharSex.Woman;
			}

		} else if (randNum > 10) {
			return NPCData.CharSex.Trap; 

		} else {
			return NPCData.CharSex.Cuntboy; 

		}

	}








}
