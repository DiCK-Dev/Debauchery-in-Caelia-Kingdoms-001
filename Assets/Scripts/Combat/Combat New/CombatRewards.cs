using UnityEngine;
using System.Collections;

public class CombatRewards {

	// 0 nothing, 100 little money, 1000 good money, 10000 small fortune
	// human: 1-99, wolf 101-199

	static public int enemyReward(){
		int randNum = UnityEngine.Random.Range (0, 100);
		NPCData.CharRace charRace = NPCCharList.CharMonster[0].charRace;

		switch (charRace) {
		case NPCData.CharRace.Human:
			if (randNum < 20) {
				return 0; //0
			} else if (randNum < 70) {
				return 100; //100
			} else if (randNum < 95) {
				return 1;
			} else {
				if (NPCCharList.CharMonster [0].bgUpbring > NPCData.BgUpgring.VeryRich) {
					return 10000;
				} else {
					return 1000;
				}
			}
		case NPCData.CharRace.Wolf:
			if (randNum < 15) {
				return 0; 
			} else if (randNum < 30) {
				return 100; 
			} else if (randNum < 95) {
				return 101;
			} else {
				if (NPCCharList.CharMonster [0].bgUpbring > NPCData.BgUpgring.VeryRich) {
					return 10000;
				} else {
					return 1000;
				}
			}

		default:
			return 0;
		}


	}



}
