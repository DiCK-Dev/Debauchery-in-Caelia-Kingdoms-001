using UnityEngine;
using System.Collections;

public class WeaponFun : MonoBehaviour {
	int randNum;

	float damageRand;
	float lustRand;

	float failDmgRand;
	float failLustRand; 

	float hpCost;
	float lustCost; 

	float multiplierTotal;
	float multiplier1;
	float multiplier2;
	float multiplier3; 

	float failMultTotal; 
	float failMultiplier1; 
	float failMultiplier2; 

	float charDamageTotal;
	float charLustTotal;


	/// <summary>
	/// CHECK SkillFun for more information! same
	/// </summary>


	public void WeaponUse(){
		switch (GameControl.charEquipment[0]) 
		{
		case 10000:
			weapon0 ();
			break; 
		case 10001: 
			weapon100 ();
			break;
		case 10002:
			weapon110 ();
			break;
		case 10003:
			weapon120 ();
			break;
		case 10004:
			weapon130 ();
			break;
		case 10005:
			weapon140 ();
			break;
		case 10006:
			weapon150 ();
			break;
		default:
			break;



		}



	}



	// // /// <summary>
	///  0 - "unnarmed", "A very reliable weapon, decent will damage", 200, 
	/// </summary>

	public void weapon0(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (8, 14);
		lustRand = Random.Range (0, 0);
		multiplier1 = (GameControl.attPhysical/500); // stat
		multiplier2 = Random.Range (0.1f, 0.4f); // random
		multiplier3 = Random.Range(0.1f, 0.4f);
		failDmgRand = Random.Range (4, 10);
		failLustRand = Random.Range (0, 0); 
		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		//GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 90)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust - charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You circled your opponent and punch it in the back of its head, sending it forward, staggering and with a lot of damage.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You circled your opponent and punch it in the back of its head, sending it forward, staggering and with a lot of damage.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You jumped and smashed your enemy’s face with your knee, dealing a lot of damage. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You jumped and smashed your enemy’s face with your knee, dealing a lot of damage. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 20)
		{
			multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust - charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You throw a high kick at your opponent, hitting it laterally, pushing it to the side.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You throw a high kick at your opponent, hitting it laterally, pushing it to the side.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You lunged forward at your enemy, punching him in the chin, pushing it back with force.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You lunged forward at your enemy, punching him in the chin, pushing it back with force.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		} 
		else if (randNum > 5) 
		{
			multiplierTotal = multiplier1 + multiplier2 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;

			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "Your kick is dodged as your enemy moved through the battlefield.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "Your kick is dodged as your enemy moved through the battlefield.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "Your punch is blocked by your opponent.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "Your punch is blocked by your opponent.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You kick your opponent low, but it landed on its shin, hurting you and forcing you a step back.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You kick your opponent low, but it landed on its shin, hurting you and forcing you a step back.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You throw a punch at your opponent, but hit its elbow, causing you a lot of pain and damage to your hand.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You throw a punch at your opponent, but hit its elbow, causing you a lot of pain and damage to your hand.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}



	// // /// <summary>
	///  100 - "Old sword", "It gets the job done... Better than your fists at leasts", 200, 
	/// </summary> - 10001



	public void weapon100(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (12, 17);
		lustRand = Random.Range (0, 0);
		multiplier1 = (GameControl.attPhysical/500); // stat
		multiplier2 = Random.Range (0.1f, 0.5f); // random
		multiplier3 = Random.Range(0.1f, 0.5f);
		failDmgRand = Random.Range (4, 10);
		failLustRand = Random.Range (0, 0); 
		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		//GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 95)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust - charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you saw your opponent off-guard, you didn’t missed your chance and pierced completely a part of its body, as your enemy cried in pain due to the precision of your attack. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you saw your opponent off-guard, you didn’t missed your chance and pierced completely a part of its body, as your enemy cried in pain due to the precision of your attack. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You saw an opening in the defense of your opponent, slashing the air with an oblique cut, damaging its neck and face.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You saw an opening in the defense of your opponent, slashing the air with an oblique cut, damaging its neck and face.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 20)
		{
			multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust - charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You took a step towards your opponent and thrusted your sword against it, piercing it body  .\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You took a step towards your opponent and thrusted your sword against it, piercing it body  .\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You lounged and swing your sword and made a horizontal cut, wounding your opponent in its torso  .\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You lounged and swing your sword and made a horizontal cut, wounding your opponent in its torso  .\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		} 
		else if (randNum > 5) 
		{
			multiplierTotal = multiplier1 + multiplier2 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;

			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You try to thrust your sword toward your enemy, but it dodged your attack in time.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "You try to thrust your sword toward your enemy, but it dodged your attack in time.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You swing your sword against your opponent, but fail to hit your intended target.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You swing your sword against your opponent, but fail to hit your intended target.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you try to slash your opponent, your enemy forced to take a step back as you attacked, making you slash your own leg in the process.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you try to slash your opponent, your enemy forced to take a step back as you attacked, making you slash your own leg in the process.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You attacked your opponent with a thrust, but your opponent dodged and counterattacked as you lunged forward, damaging you in your back, as you recovered from the failed attack.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You attacked your opponent with a thrust, but your opponent dodged and counterattacked as you lunged forward, damaging you in your back, as you recovered from the failed attack.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}



	// // /// <summary>
	///  110 - "Sword", "A very reliable weapon, decent will damage", 200, 
	/// </summary> 100002

	public void weapon110(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (17, 23);
		lustRand = Random.Range (0, 0);
		multiplier1 = (GameControl.attPhysical/500); // stat
		multiplier2 = Random.Range (0.1f, 0.4f); // random
		multiplier3 = Random.Range(0.1f, 0.6f);
		failDmgRand = Random.Range (4, 10);
		failLustRand = Random.Range (0, 0); 
		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		//GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 90)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust - charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you saw your opponent off-guard, you didn’t missed your chance and pierced completely a part of its body, as your enemy cried in pain due to the precision of your attack,  . \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you saw your opponent off-guard, you didn’t missed your chance and pierced completely a part of its body, as your enemy cried in pain due to the precision of your attack,  . \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You saw an opening in the defense of your opponent, slashing the air with an oblique cut, damaging its neck and face  .\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You saw an opening in the defense of your opponent, slashing the air with an oblique cut, damaging its neck and face  .\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 20)
		{
			multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust - charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You took a step towards your opponent and thrusted your sword against it, piercing it body  .\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You took a step towards your opponent and thrusted your sword against it, piercing it body  .\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You lounged and swing your sword and made a horizontal cut, wounding your opponent in its torso  .\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You lounged and swing your sword and made a horizontal cut, wounding your opponent in its torso  .\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		} 
		else if (randNum > 5) 
		{
			multiplierTotal = multiplier1 + multiplier2 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;

			randNum = Random.Range (0, 3);
			switch(randNum)
			{


			case 0:
				WorldControl.charAttackDescription = "You try to thrust your sword toward your enemy, but it dodged your attack in time.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "You try to thrust your sword toward your enemy, but it dodged your attack in time.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You swing your sword against your opponent, but fail to hit your intended target.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You swing your sword against your opponent, but fail to hit your intended target.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{


			case 0:
				WorldControl.charAttackDescription = "As you try to slash your opponent, your enemy forced to take a step back as you attacked, making you slash your own leg in the process.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you try to slash your opponent, your enemy forced to take a step back as you attacked, making you slash your own leg in the process.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You attacked your opponent with a thrust, but your opponent dodged and counterattacked as you lunged forward, damaging you in your back, as you recovered from the failed attack.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You attacked your opponent with a thrust, but your opponent dodged and counterattacked as you lunged forward, damaging you in your back, as you recovered from the failed attack.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}




	// // /// <summary>
	///  140 - Lustick", "A special lipstick that helps to charm your enemies. Consistent lust damage
	/// </summary>

	public void weapon140(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (0, 0);
		lustRand = Random.Range (15, 21);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0.1f, 0.5f); // random
		multiplier3 = Random.Range(0.1f, 0.5f);
		failDmgRand = Random.Range (3, 7);
		failLustRand = Random.Range (3, 7); 
		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		//GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 90)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You kiss your opponent in its mouth, letting the sexual stimulant to work inside its head.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You kiss your opponent in its mouth, letting the sexual stimulant to work inside its head.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You caught your opponent and kiss it in the neck, the aphrodisiacs flowing better into its body.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You caught your opponent and kiss it in the neck, the aphrodisiacs flowing better into its body.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 15)
		{
			multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You got the chance to kiss your opponent on one of its appendages, letting the lustick dry in it and increase its will to fuck. .\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You got the chance to kiss your opponent on one of its appendages, letting the lustick dry in it and increase its will to fuck. .\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You kiss seductively your opponent on its body, leaving a mark of lustick in its body, increasing its will to fuck due to its lust-increasing properties.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You kiss seductively your opponent on its body, leaving a mark of lustick in its body, increasing its will to fuck due to its lust-increasing properties.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		} 
		else if (randNum > 5) 
		{
			multiplierTotal = multiplier1 + multiplier2 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;

			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you try to deliver the lustick through a kiss, your opponent dodge your attempt.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "As you try to deliver the lustick through a kiss, your opponent dodge your attempt.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You try to touch your enemy with your lips, but fail to do it.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You try to touch your enemy with your lips, but fail to do it.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You failed to kiss your opponent in the face, as your opponent took the opportunity and hit you with its elbow in your chest, damaging you and pushing you back.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You failed to kiss your opponent in the face, as your opponent took the opportunity and hit you with its elbow in your chest, damaging you and pushing you back.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "As you try to kiss your opponent’s arm, it took the advantage to hit you in the face, pushing you back and dazing you for a second \nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "As you try to kiss your opponent’s arm, it took the advantage to hit you in the face, pushing you back and dazing you for a second \nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}


	// // /// <summary>
	///  120 - "Seductive veil", "A fine piece of cloth to perform some sexy moves. Good critical lust damage."
	/// </summary> 10003

	public void weapon120(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (0, 0);
		lustRand = Random.Range (13, 18);
		multiplier1 = (GameControl.attPhysical/500); // stat
		multiplier2 = Random.Range (0f, 0.3f); // random
		multiplier3 = Random.Range(0.4f, 0.8f);
		failDmgRand = Random.Range (2, 6);
		failLustRand = Random.Range (3, 8); 
		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		//GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 90)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 20)
		{
			multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		} 
		else if (randNum > 5) 
		{
			multiplierTotal = multiplier1 + multiplier2 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;

			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}



	// // /// <summary>
	///  130 - Whip", "A very versatile weapon, with mixed lust and will damage.", 200, ""
	/// </summary> 10004

	public void weapon130(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (10, 14);
		lustRand = Random.Range (10, 14);
		multiplier1 = (GameControl.attPhysical/500); // stat
		multiplier2 = Random.Range (0.1f, 0.5f); // random
		multiplier3 = Random.Range(0.1f, 0.5f);
		failDmgRand = Random.Range (3, 10);
		failLustRand = Random.Range (3, 10); 
		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		//GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 90)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You whip your opponent’s pubis, as your opponent makes a face full of pleasure, increasing its will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You whip your opponent’s pubis, as your opponent makes a face full of pleasure, increasing its will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You smack your opponent’s ass with your whip, hearing a small moan from its part, as it increased its will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You smack your opponent’s ass with your whip, hearing a small moan from its part, as it increased its will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 20)
		{
			multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "Your enemy’s belly got a smack by your whip in a seductive way, increasing its will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "Your enemy’s belly got a smack by your whip in a seductive way, increasing its will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You whip your opponent’s chest in a lusty way, increasing its will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You whip your opponent’s chest in a lusty way, increasing its will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		} 
		else if (randNum > 5) 
		{
			multiplierTotal = multiplier1 + multiplier2 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;

			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "Your whip failed its target by a small distance, as you miscalculated its location.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "Your whip failed its target by a small distance, as you miscalculated its location.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You try to hit with your whip to your opponent, but it dodges in the last second.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You try to hit with your whip to your opponent, but it dodges in the last second.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "The whip failed its target and wrapped around your leg, hitting it. It takes you a bit to unwrap it.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "The whip failed its target and wrapped around your leg, hitting it. It takes you a bit to unwrap it.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "As you tried to whip your enemy, the whip got stuck in a crack on the floor, and when you pull it back, you hit yourself.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "As you tried to whip your enemy, the whip got stuck in a crack on the floor, and when you pull it back, you hit yourself.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}


	/// // /// <summary>
	///  bow
	/// </summary>
	public void weapon150(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (10, 16);
		lustRand = Random.Range (0, 0);
		multiplier1 = (GameControl.attPhysical/500); // stat
		multiplier2 = Random.Range (0.1f, 0.5f); // random
		multiplier3 = Random.Range(0.8f, 1.2f);
		failDmgRand = Random.Range (4, 10);
		failLustRand = Random.Range (0, 0); 
		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		//GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 90)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust - charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "An arrow flew strong and pierced your opponent’s back. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "An arrow flew strong and pierced your opponent’s back.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "One of your arrow landed on your opponent’s chest, as it broke it and tossed the rest aside.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "One of your arrow landed on your opponent’s chest, as it broke it and tossed the rest aside.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 20)
		{
			multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust - charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You stretched your bow and fired an arrow, hitting your enemy on its shoulder.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You stretched your bow and fired an arrow, hitting your enemy on its shoulder.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You fire an arrow towards your opponent, hitting it in its side.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You fire an arrow towards your opponent, hitting it in its side.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		} 
		else if (randNum > 5) 
		{
			multiplierTotal = multiplier1 + multiplier2 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;

			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "Your opponent is faster than you thought, as you try to hit it with an arrow.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "Your opponent is faster than you thought, as you try to hit it with an arrow.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You shoot an arrow to your opponent, but missed your mark by a good distance.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You shoot an arrow to your opponent, but missed your mark by a good distance.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you try to tense the bow’s string, you do it too much, lashing the string and hitting you on your torso.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you try to tense the bow’s string, you do it too much, lashing the string and hitting you on your torso.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You fail your aim miserably, as you shoot the arrow but damage your hand in the process.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You fail your aim miserably, as you shoot the arrow but damage your hand in the process.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}







	// // // // // // // 


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
