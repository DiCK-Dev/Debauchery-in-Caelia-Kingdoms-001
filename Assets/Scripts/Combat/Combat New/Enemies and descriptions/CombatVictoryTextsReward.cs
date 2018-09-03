using UnityEngine;
using System.Collections;

public class CombatVictoryTextsReward {

	static public string textReward(int selector){
		float randNum;
		WorldControl.dropItem = 0;

		switch (selector) {
		case 0:
			return "The enemy didn't had any meaningful possessions, so you leave empty handed.";
		case 100:
			randNum = UnityEngine.Random.Range (5, 30);
			GameControl.charGold += randNum;
			return CombatTextsEnemy.textVictory() + "\n\nYou find a small pouch with " + randNum.ToString () +" gold coins.";
		case 1000:
			randNum = UnityEngine.Random.Range (70, 250);
			GameControl.charGold += randNum;
			return CombatTextsEnemy.textVictory() + "\n\nYour opponent have a stash of gold coins! In it there are " + randNum.ToString () +" gold coins!";
		case 10000:
			randNum = UnityEngine.Random.Range (300, 1000);
			GameControl.charGold += randNum;
			return CombatTextsEnemy.textVictory() + "\n\nYour opponent have a big stash of gold coins! In it there are " + randNum.ToString () +" gold coins!";
		case 1:// human 1st reward
			randNum = UnityEngine.Random.Range (0, 100);
			if (randNum < 48) {
				WorldControl.dropItem = 106;
				return CombatTextsEnemy.textVictory() + "\n\nThe enemy has a Virilitax in its bag!";
			} else if (randNum < 98) {
				WorldControl.dropItem = 101;
				return CombatTextsEnemy.textVictory() + "\n\nThe enemy has a Udder max in its bag!";
			} else {
				WorldControl.dropItem = 1045;
				return CombatTextsEnemy.textVictory() + "\n\nThe enemy had a cleanser in its bag!";
			}
		case 101: // wolf reward
			randNum = UnityEngine.Random.Range (0, 100);
			if (randNum < 15) {
				WorldControl.dropItem = 106;
				return CombatTextsEnemy.textVictory() + "\n\nThe enemy has a Virilitax in its bag!";
			} else if (randNum < 30) {
				WorldControl.dropItem = 101;
				return CombatTextsEnemy.textVictory() + "\n\nThe enemy has a Udder max in its bag!";
			} else {
				WorldControl.dropItem = 1005;
				return CombatTextsEnemy.textVictory() + "\n\nThe enemy had a wolf concoction in its bag!";
			}




		}
		WorldControl.dropItem = 0;
		return "The enemy didn't had any meaningful possessions, so you go empty handed.";

	}

}
