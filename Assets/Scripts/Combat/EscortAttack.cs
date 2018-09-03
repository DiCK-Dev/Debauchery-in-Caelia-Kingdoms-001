using UnityEngine;
using System.Collections;

public class EscortAttack : MonoBehaviour {

	int randNum;

	float damageRand;
	float lustRand;

	float failDmgRand;
	float failLustRand; 

	float hpCost;
	float lustCost; 

	float multiplierTotal;
	float multiplier1; // stat multiplier 
	float multiplier2; // random multiplier 
	float multiplier3; // weapon extra multiplier 
	float multiplier4; // armour extra multiplier
	float multiplier5; // critical multiplier


	float failMultTotal; 
	float failMultiplier1; 
	float failMultiplier2; 

	float charDamageTotal;
	float charLustTotal;


	public void escortAttack()
	{
		Debug.Log ("Helena attack working 1");
		switch (WorldControl.escortNPC1) 
		{
		case 1000:
			//enemy100 ();
			break;
		case 3000:
			NPC3000 ();
			break;
		case 5000:
		//	enemy120 ();
			break;


		}

	}

	public void NPC3000(){
		Debug.Log ("Helena attack working 2");
		Random.InitState(System.DateTime.Now.Millisecond);
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 


		if (NPCControl.npc3000Corruption <= 50) {

			Random.InitState (System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 101); 
			damageRand = Random.Range (10, 21);
			multiplier1 = (GameControl.attPhysical / 500); // stat
			multiplier2 = Random.Range (0f, 0.5f); // random
			multiplier5 = Random.Range (0.2f, 0.5f);
			failDmgRand = Random.Range (5, 9);
			failLustRand = Random.Range (0, 1); 



			// Balanced, low damage, high accuracy, 
			if (randNum > 90) {

				multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1 - WorldControl.enemyCombDefense; 
				charDamageTotal = damageRand * multiplierTotal;  
				WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 

				randNum = Random.Range (0, 3);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription += "\nHelena did a critical attack! \nThe attack from Helena did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription += "\nHelena did a critical attack! \nThe attack from Helena did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription += "\nHelena did a critical attack! \nThe attack from Helena did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription += "\nHelena did a critical attack! \nThe attack from Helena did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;


				}
			} else if (randNum > 15) {
				multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1 - WorldControl.enemyCombDefense; 
				charDamageTotal = damageRand * multiplierTotal;   
				WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 


				randNum = Random.Range (0, 3);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription += "\nHelena Attack did hit! \nThe attack from Helena did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription += "\nHelena Attack did hit! \nThe attack from Helena did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription += "\nHelena Attack did hit! \nThe attack from Helena did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription += "\nHelena Attack did hit! \nThe attack from Helena did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;


				}
			} else if (randNum > 6) {
				multiplierTotal = multiplier1 + multiplier2 + 1; 
				failDmgRand = failDmgRand * multiplierTotal; 
				GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 


				randNum = Random.Range (0, 3);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription += "\nHelena missed her attack and you had to block the oponent, receiving some damage!. \nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
					break;
				case 1: 

					WorldControl.charAttackDescription += "\nHelena missed her attack and you had to block the oponent, receiving some damage!. \nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

					break;
				case 2:

					WorldControl.charAttackDescription += "\nHelena missed her attack and you had to block the oponent, receiving some damage!. \nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

					break;
				default: 

					WorldControl.charAttackDescription += "\nHelena missed her attack and you had to block the oponent, receiving some damage!. \nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

					break;


				}
			} else {
				multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
				failDmgRand = failDmgRand * multiplierTotal; 
				GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 

				randNum = Random.Range (0, 3);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription += "\nHelena missed her attack critically and you had to block the oponent, receiving some damage!. \nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription += "\nHelena missed her attack critically and you had to block the oponent, receiving some damage!. \nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription += "\nHelena missed her attack critically and you had to block the oponent, receiving some damage!. \nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription += "\nHelena missed her attack critically and you had to block the oponent, receiving some damage!. \nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
					break;


				}
			}

		} else {


		}

	}/////////







}
