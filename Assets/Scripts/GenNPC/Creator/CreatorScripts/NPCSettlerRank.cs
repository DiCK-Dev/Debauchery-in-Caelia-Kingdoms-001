using UnityEngine;
using System.Collections;

public class NPCSettlerRank  {
	static int iterator = 0;
	int randNum;
	int hashcode = GameControl.playerName.GetHashCode();

	public NPCData.CharRank setRank(int selector)
	{
		iterator += 1;
		switch (selector) {
		case 0:
			return NPCData.CharRank.C;
		case 1:
			return NPCData.CharRank.B;
		case 2:
			return NPCData.CharRank.A;
		case 3:
			return NPCData.CharRank.S;
		case 1000:
			return randomRank ();
		default:
			return NPCData.CharRank.C;

		}



	}


	NPCData.CharRank randomRank(){
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		randNum = Random.Range (0, 100);

		if (randNum > 95) {
			return NPCData.CharRank.S;
		} else if (randNum > 80) {
			return NPCData.CharRank.A;
		} else if (randNum > 50) {
			return NPCData.CharRank.B;
		} else {
			return NPCData.CharRank.C;
		}



	}



}
