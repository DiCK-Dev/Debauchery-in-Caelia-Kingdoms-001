using UnityEngine;
using System.Collections;

public class SkillFun : MonoBehaviour {
	
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

	float calcSum;
	float calcSumFail; 
	float calcLust; 

	/// <summary>
	/// The maths should be tested always vs an average enemy (120 hp, 0.2 defense, 100 lust)
	/// Fight should be about 5-6 rounds with balanced attacks, risky moves will make the fight move faster, but at a cost
	/// 
	/// 
	/// Balanced attacks usually do 20-25 if single type, 25-30 (sum) if both, have little to no cost tho, and use different stats. If they have special effects they do even less damage
	/// 
	/// Strong attacks do more damage, but are cosnsitent and their critical are not a big deal, they cost some (around 5-10), and do around 30-35 damage or 35-45(sum) if both
	/// 
	/// Risky attacks have both a high critical chance for hit and fail, and does a 
	/// lot of damage if hits in both ways, tho their regular hit and miss are mediocre. base 15 but criticals of over 50. Regular cost 
	/// 
	/// Special: The last skill, it should be very strong but costs a lot. Over 50 damage but costs around half
	/// 
	/// 
	/// 
	/// 
	/// The damage uses the formula of: 
	/// 
	/// multiplierTotal = (attribute/500/1000/2000) + rand Multiplier2 (regular damage) IF CRITICAL + randmultiplier5 (for critical) 
	/// Base ranDamage 
	/// minus enemy defense.
	/// 
	/// Example: ((Mental/1000) + rand(0.8f, 1.2f) + (if critical - rand(0.6f, 0.8f)) - (enemyDefense)) * ranDamage 
	/// 
	/// Cost: Reduces your HP or increases your lust with a fixed cost, it should be loaded in hpCost or lustCost for the summary
	/// 
	/// Miss damage is also somewhat fixed
	/// failMultTotal = failMultiplier1 + failMultiplier1(if critical)
	/// failDmgRand 
	/// 
	/// Example: (failMultiplier((0.8f, 1.1f) + (if critical failMultiplier2(0.5f, 1f)) * failDmgRand
	/// 
	/// ALL OF THIS is similar to the lust skills, just with other stats, also these attacks use ONLY the combat defense, so even if the enemy is resistant to arousing attacks it 
	/// will be more suceptible to these 
	/// </summary>




	public void SkillUse(){
		multiplier3 = WorldControl.charComAttackArmor;
		multiplier4 = WorldControl.charComAttackWeapon;

		switch (WorldControl.skillID) 
		{
		case 100: 
			GameControl.skillSetCounter [0] += 1;
			skill100LevelUp ();
			GameControl.attPhysical += 0.3f;
			//statPhysLevelUp ();
			skill100 ();
			break;
		case 110:
			GameControl.skillSetCounter [0] += 1;
			skill100LevelUp ();
			GameControl.attPhysical += 0.3f;
			//statPhysLevelUp ();
			skill110 ();
			break;
		case 120:
			GameControl.skillSetCounter [0] += 1;
			skill100LevelUp ();
			GameControl.attPhysical += 0.3f;
			//statPhysLevelUp ();

			skill120 ();

			break;
		case 130:
			GameControl.skillSetCounter [0] += 1;
			skill100LevelUp ();
			GameControl.attPhysical += 0.3f;
			//statPhysLevelUp ();

			skill130 ();
			break;
		case 200:
			GameControl.skillSetCounter [1] += 1;
			skill200LevelUp ();
			GameControl.attPhysical += 0.3f;
			//statPhysLevelUp ();

			skill200 ();
			break;
		case 210:
			GameControl.skillSetCounter [1] += 1;
			skill200LevelUp ();
			GameControl.attPhysical += 0.3f;
			//statPhysLevelUp ();

			skill210 ();
			break;
		case 220:
			GameControl.skillSetCounter [1] += 1;
			skill200LevelUp ();
			GameControl.attPhysical += 0.3f;
			//statPhysLevelUp ();

			skill220 ();
			break;
		case 230:
			GameControl.skillSetCounter [1] += 1;
			skill200LevelUp ();
			GameControl.attPhysical += 0.3f;
			//statPhysLevelUp ();

			skill230 ();
			break;
		case 300:
			GameControl.skillSetCounter [2] += 1;
			skill300LevelUp ();
			GameControl.attPhysical += 0.3f;
			//statPhysLevelUp ();

			skill300 ();
			break;
		case 310:
			GameControl.skillSetCounter [2] += 1;
			skill300LevelUp ();
			GameControl.attSocial += 0.3f;
			//statSocLevelUp ();

			skill310 ();
			break;
		case 320:
			GameControl.skillSetCounter [2] += 1;
			skill300LevelUp ();
			GameControl.attPhysical += 0.3f;
			//statPhysLevelUp ();

			skill320 ();
			break;
		case 330:
			GameControl.skillSetCounter [2] += 1;
			skill300LevelUp ();
			GameControl.attPhysical += 0.3f;
			//statPhysLevelUp ();

			skill330 ();
			break;
		case 400:
			GameControl.skillSetCounter [3] += 1;
			skill400LevelUp ();
			GameControl.attMental += 0.3f;
			//statMentLevelUp ();

			skill400 ();
			break;
		case 410:
			GameControl.skillSetCounter [3] += 1;
			skill400LevelUp ();
			GameControl.attMental += 0.3f;
			//statMentLevelUp ();

			skill410 ();
			break;
		case 420:
			GameControl.skillSetCounter [3] += 1;
			skill400LevelUp ();
			GameControl.attMental += 0.3f;
			//statMentLevelUp ();

			skill420 ();
			break;
		case 430:
			GameControl.skillSetCounter [3] += 1;
			skill400LevelUp ();
			GameControl.attMental += 0.3f;
			//statMentLevelUp ();

			skill430 ();
			break;
		case 500:
			GameControl.skillSetCounter [4] += 1;
			skill500LevelUp ();
			GameControl.attMental += 0.3f;
			//statMentLevelUp ();

			skill500 ();
			break;
		case 510:
			GameControl.skillSetCounter [4] += 1;
			skill500LevelUp ();
			GameControl.attMental += 0.3f;
			//statMentLevelUp ();

			skill510 ();
			break;
		case 520:
			GameControl.skillSetCounter [4] += 1;
			skill500LevelUp ();
			GameControl.attMental += 0.3f;
			//statMentLevelUp ();

			skill520 ();
			break;
		case 530:
			GameControl.skillSetCounter [4] += 1;
			skill500LevelUp ();
			GameControl.attMental += 0.3f;
			//statMentLevelUp ();

			skill530 ();
			break;
		case 600:
			GameControl.skillSetCounter [5] += 1;
			skill600LevelUp ();
			GameControl.attSocial += 0.3f;
			//statSocLevelUp ();

			skill600 ();
			break;
		case 610:
			GameControl.skillSetCounter [5] += 1;
			skill600LevelUp ();
			GameControl.attSocial += 0.3f;
			//statSocLevelUp ();

			skill610 ();
			break;
		case 620:
			GameControl.skillSetCounter [5] += 1;
			skill600LevelUp ();
			GameControl.attSocial += 0.3f;
			//statSocLevelUp ();

			skill620 ();
			break;
		case 630:
			GameControl.skillSetCounter [5] += 1;
			skill600LevelUp ();
			GameControl.attSocial += 0.3f;
			//statSocLevelUp ();

			skill630 ();
			break;


		}



	}





	// fast chop
	public void skill100(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (17, 21);
		multiplier1 = (GameControl.attPhysical/500); // stat
		multiplier2 = Random.Range (0f, 0.5f); // random
		multiplier5 = Random.Range(0.2f, 0.5f);
		failDmgRand = Random.Range (5, 9);
		failLustRand = Random.Range (0, 1); 



		// Balanced, low damage, high accuracy, 
		if (randNum > 90)
		{
			
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal;  
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 

			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You caught your enemy unaware for a second, chopping it in the back of its head, increasing the damage you do with it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You caught your enemy unaware for a second, chopping it in the back of its head, increasing the damage you do with it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You caught your opponent guard-off and chopped him in the neck, knocking him down for a second.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You caught your opponent guard-off and chopped him in the neck, knocking him down for a second.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 15)
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1  - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal;   
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
	

			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You focused all your strength in one of your arms, punching your opponent on its shoulder and pushing it back.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You focused all your strength in one of your arms, punching your opponent on its shoulder and pushing it back.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You prepared for the attack, focusing all your might in your opponent’s belly, sending him back to its original place with the recoil of your hit.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You prepared for the attack, focusing all your might in your opponent’s belly, sending him back to its original place with the recoil of your hit.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		} 
		else if (randNum > 6) 
		{
			multiplierTotal = multiplier1 + multiplier2 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "Your opponent moved faster than you, before you could knock him over.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "Your opponent moved faster than you, before you could knock him over.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You try to slam your opponent, but failed to hit it.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You try to slam your opponent, but failed to hit it.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 

			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you were trying to overpower your opponent, you trip into the ground and hit it with your face.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you were trying to overpower your opponent, you trip into the ground and hit it with your face.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You try to push your opponent into the ground, but instead you fell and hurting you in the process.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You try to push your opponent into the ground, but instead you fell and hurting you in the process.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;


			}
		}


	}



	// // // skill 110 - healing rub // // // 

	public void skill110(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (12, 20);
		multiplier1 = (0.1f); // stat
		multiplier2 = Random.Range (0f, 0.3f); // random
		multiplier5 = Random.Range(0.1f, 0.4f);
		failLustRand = Random.Range (5, 10); 
		// cost
		GameControl.actualArousal = GameControl.actualArousal + 10; 
		// Balanced, low damage, high accuracy, 
		if (randNum > 80)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1 ; 
			charDamageTotal = damageRand * multiplierTotal;  
			GameControl.actualHealth = GameControl.actualHealth + charDamageTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - failLustRand; 
			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You got filled with resolve to stand the combat, as you were eager to show the enemy your new moves.\nYou recovered " + charDamageTotal + " will!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You got filled with resolve to stand the combat, as you were eager to show the enemy your new moves.\nYou recovered " + charDamageTotal + " will!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You steeled yourself before the enemy attack and focused on you lustful counterattacks.\nYou recovered " + charDamageTotal + " will!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You steeled yourself before the enemy attack and focused on you lustful counterattacks.\nYou recovered " + charDamageTotal + " will!"; 
				break;


			}
		}
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + 1 ; 
			charDamageTotal = damageRand * multiplierTotal;  
			GameControl.actualHealth = GameControl.actualHealth + charDamageTotal; 

			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You got defensive, regaining some of your willpower before your opponent attacks. And if he does, you’ll be ready to rub yourself out of trouble.\nYou recovered " + charDamageTotal + " will!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You got defensive, regaining some of your willpower before your opponent attacks. And if he does, you’ll be ready to rub yourself out of trouble.\nYou recovered " + charDamageTotal + " will!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You started recuperating your will to fight and prepared to barely avoid your opponent attacks.\nYou recovered " + charDamageTotal + " will!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You started recuperating your will to fight and prepared to barely avoid your opponent attacks.\nYou recovered " + charDamageTotal + " will!"; 
				break;


			}
		} 
			
	}
		

	// // // // 120 - Pin down // // // // // 


	public void skill120(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (14, 18);
		lustRand = Random.Range (5,14);
		multiplier1 = (GameControl.attPhysical/500); // stat
		multiplier2 = Random.Range (0.1f, 0.4f); // random
		multiplier5 = Random.Range(0.2f, 0.5f);
		failDmgRand = Random.Range (5, 9);
		failLustRand = Random.Range (5, 10); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 5; 
		GameControl.actualArousal = GameControl.actualArousal - 5;

		if (randNum > 85)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 

			if(WorldControl.enemyStunned == false){
				WorldControl.enemyStunned = true;
				WorldControl.eneStunCounter = Random.Range (1, 4);
			}

			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You got a chance to push him down off-guard, dazing him for a second. You had the chance to sat over its crotch as you punched it in its face, before retreating once more.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You tackled your opponent from behind and started rubbing against its ass before standing up and moving back before he could retaliate.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You got a chance to push him down off-guard, dazing him for a second. You had the chance to sat over its crotch as you punched it in its face, before retreating once more.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You tackled your opponent from behind and started rubbing against its ass before standing up and moving back before he could retaliate.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You pushed your opponent into the ground and sat over him, punching him in the torso as it covered its face, before retreating back to your position.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You pushed your opponent into the ground and sat over him, punching him in the torso as it covered its face, before retreating back to your position.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You pinned down your opponent with a well-timed tackle, rubbing against it before you moved back into you starting position.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You pinned down your opponent with a well-timed tackle, rubbing against it before you moved back into you starting position.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		} 
		else if (randNum > 6) 
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
				WorldControl.charAttackDescription = "You try to pin your opponent down, but he dodged the attempt.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "You try to pin your opponent down, but he dodged the attempt.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You try to attack your opponent and pin him down, but you coulsn’t push him down.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You try to attack your opponent and pin him down, but you coulsn’t push him down.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;

			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You try to tackle your opponent to pin it down, but you barely moved him, before he hits you in the back and push you into the ground, as you bolted back as best as you could to your position.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You try to tackle your opponent to pin it down, but you barely moved him, before he hits you in the back and push you into the ground, as you bolted back as best as you could to your position.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You try to pin down your opponent, but you only hurted yourself in the process, as the enemy moved in the last second.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You try to pin down your opponent, but you only hurted yourself in the process, as the enemy moved in the last second.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;


			}
		}


	}

	// // // 130 - suplex // // // //


	public void skill130(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (18, 25);
		lustRand = Random.Range (2, 7);
		multiplier1 = (GameControl.attPhysical/500); // stat
		multiplier2 = Random.Range (0.1f, 0.4f); // random
		multiplier5 = Random.Range(0.2f, 0.5f);
		failDmgRand = Random.Range (7, 11);
		failLustRand = Random.Range (7, 15); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 5; 
		GameControl.actualArousal = GameControl.actualArousal - 15;

		if (randNum > 70)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 

			if(WorldControl.enemyStunned == false){
				WorldControl.enemyStunned = true;
				WorldControl.eneStunCounter = Random.Range (1, 4);
			}

			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You found an advantage and took it, as you grabbed him by his back and made a suplex of him, but you threw him in the air, sending it flying several meters away from you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You found an advantage and took it, as you grabbed him by his back and made a suplex of him, but you threw him in the air, sending it flying several meters away from you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "As you opponent got careless, you grabbed it by its back and made a perfect suplex, slamming it into the ground rather than just letting it fall.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "As you opponent got careless, you grabbed it by its back and made a perfect suplex, slamming it into the ground rather than just letting it fall.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You suplex your opponent from the side, just enough for it to hit the ground next to you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You suplex your opponent from the side, just enough for it to hit the ground next to you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You suplex your opponent from the front, lifting it in one swift motion before it hits the ground.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You suplex your opponent from the front, lifting it in one swift motion before it hits the ground.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "As you try your technique, your opponent moved too much for you to do it properly.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "As you try your technique, your opponent moved too much for you to do it properly.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You try to suplex your enemy, but you couldn’t lift him on time before he wriggled itself free.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You try to suplex your enemy, but you couldn’t lift him on time before he wriggled itself free.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You try to suplex him, but he freed from the grab and pushed you back with a punch in the belly.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You try to suplex him, but he freed from the grab and pushed you back with a punch in the belly.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You try a suplex, but when you try, your opponent took the advantage and did the suplex to you, hitting you in your back.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You try a suplex, but when you try, your opponent took the advantage and did the suplex to you, hitting you in your back.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;


			}
		}


	}
	// // /// <summary>
	///  200 - 12, 10, 0, 0, 0, "High kick", "Balanced attack with both will and lust damage. No cost.", 0.15f, 0.85f
	/// </summary>

	public void skill200(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (12, 16);
		lustRand = Random.Range (8, 12);
		multiplier1 = (GameControl.attPhysical/500); // stat
		multiplier2 = Random.Range (0.1f, 0.6f); // random
		multiplier5 = Random.Range(0.1f, 0.4f);
		failDmgRand = Random.Range (4, 9);
		failLustRand = Random.Range (4, 9); 
		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		//GameControl.actualArousal = GameControl.actualArousal - 15;

		if (randNum > 85)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You pushed your opponent backdown with your frontal kick and pinned it from its crotch with your feet for a second, pressing its genitals a bit. As it squirmed to break free, you jumped back into place.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You sweeped your opponent with your leg, and rub it over its body with force until it landed on its head, hitting it with force. The opponent stood up quickly so you moved back into position.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You sweeped your opponent with your leg, and rub it over its body with force until it landed on its head, hitting it with force. The opponent stood up quickly so you moved back into position.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You pushed your opponent backdown with your frontal kick and pinned it from its crotch with your feet for a second, pressing its genitals a bit. As it squirmed to break free, you jumped back into place.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "Your crude kick lands on your opponent’s pubis, rubbing it after your pulled your leg back to you. You never took your eyes from your opponent, as you moved back to place. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "Your crude kick lands on your opponent’s pubis, rubbing it after your pulled your leg back to you. You never took your eyes from your opponent, as you moved back to place. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "Your crude kick hits your opponent in its ass, making it jiggle a bit. After that, you cowered a bit as you retreated into your original position.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "Your crude kick hits your opponent in its ass, making it jiggle a bit. After that, you cowered a bit as you retreated into your original position.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You did a frontal kick with all your might, but the opponent had time to dodge to the side, so you missed completely. You took a step to the other side to take some distance.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "You did a frontal kick with all your might, but the opponent had time to dodge to the side, so you missed completely. You took a step to the other side to take some distance.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "Your high kick runs swift across the air towards your opponent, but it misses its intended target, so you took a step back to place before it can retaliate.\n\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "Your high kick runs swift across the air towards your opponent, but it misses its intended target, so you took a step back to place before it can retaliate.\n\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "Your opponent takes a step to the side and your leg barely reaches your opponent, just touching its ass, making you feel its softness in your feet, stimulating you. \nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "Your opponent takes a step to the side and your leg barely reaches your opponent, just touching its ass, making you feel its softness in your feet, stimulating you. \nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You try to stretch to hit your opponent, but something went awfully wrong, and your crotch only caressed the back of your opponent, turning you on.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You try to stretch to hit your opponent, but something went awfully wrong, and your crotch only caressed the back of your opponent, turning you on.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;


			}
		}


	}


	// // /// <summary>
	///  210 - flash kick
	/// </summary>

	public void skill210(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (17, 21);
		lustRand = Random.Range (11, 14);
		multiplier1 = (GameControl.attPhysical/500); // stat
		multiplier2 = Random.Range (0.1f, 0.6f); // random
		multiplier5 = Random.Range(0.1f, 0.4f);
		failDmgRand = Random.Range (6, 9);
		failLustRand = Random.Range (6, 12); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 5; 
		GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 85)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You do a cartwheel kick, flashing your genitals as you impact your opponent in its face, dazing it and shoving it back into the ground in front of you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You do a cartwheel kick, flashing your genitals as you impact your opponent in its face, dazing it and shoving it back into the ground in front of you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You make a jumping back kick, flashing your ass to your opponent just before hitting it in the head, sending it back and knocking it down for a second.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You make a jumping back kick, flashing your ass to your opponent just before hitting it in the head, sending it back and knocking it down for a second.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You do a roundhouse kick, exposing your groin for a second, before smashing your opponent on its torso, pushing it aside with force.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You do a roundhouse kick, exposing your groin for a second, before smashing your opponent on its torso, pushing it aside with force.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You do a back kick, showing your tight ass a bit, as it strongly slams your opponent to the side.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You do a back kick, showing your tight ass a bit, as it strongly slams your opponent to the side.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You try to kick your opponent, but it proved to be faster than you thought.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "You try to kick your opponent, but it proved to be faster than you thought.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You tried to reach your opponent’s face with one of your legs, but it dodged your attack before you could land it properly.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You tried to reach your opponent’s face with one of your legs, but it dodged your attack before you could land it properly.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You do a long kick, but lost your ground and slip, falling into the ground and damaging yourself. \nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You do a long kick, but lost your ground and slip, falling into the ground and damaging yourself. \nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You try to do a cartwheel kick, but failed to land and hit your body into the ground, damaging yourself.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You try to do a cartwheel kick, but failed to land and hit your body into the ground, damaging yourself.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;

			}
		}
	}

	/// <summary>
	/// 220 - 15, 5, 0, 10, 0, "Crotch toss", "Low accuracy, but high critical damage. Cost: 10 Lust.", 0.3f, 0.6f 
	/// </summary>

	public void skill220(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (12, 17);
		lustRand = Random.Range (3, 8);
		multiplier1 = (GameControl.attPhysical/500); // stat
		multiplier2 = Random.Range (0.1f, 0.6f); // random
		multiplier5 = Random.Range(0.8f, 1.2f);
		failDmgRand = Random.Range (6, 9);
		failLustRand = Random.Range (6, 12); 
		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		GameControl.actualArousal = GameControl.actualArousal + 10;

		if (randNum > 70)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You found a blind spot on your opponent, at which point you grabbed him by the head, placed between your legs, lifted his body until his groin was in front of your face and then slammed him like a powerbomb move.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You found a blind spot on your opponent, at which point you grabbed him by the head, placed between your legs, lifted his body until his groin was in front of your face and then slammed him like a powerbomb move.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You catched your opponent unaware, then grabbed him by his crotch and torso, lifted him off the ground and then slammed him into the ground along with you, feeling its body against yours, until you freed it and moved back.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You catched your opponent unaware, then grabbed him by his crotch and torso, lifted him off the ground and then slammed him into the ground along with you, feeling its body against yours, until you freed it and moved back.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;



			}
		}
		else if (randNum > 40)
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
				WorldControl.charAttackDescription = "You lunged towards your opponent and held him by his pubis and torso, then proceeded to threw him into the ground, close to you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You lunged towards your opponent and held him by his pubis and torso, then proceeded to threw him into the ground, close to you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You grabbed your opponent by the crotch and its chest, then you plunged him into the air and throw him as far as you could.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You grabbed your opponent by the crotch and its chest, then you plunged him into the air and throw him as far as you could.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;



			}
		} 
		else if (randNum > 10) 
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
				WorldControl.charAttackDescription = "As you were about to grab him, it dodged, leaving you empty-handed.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "As you were about to grab him, it dodged, leaving you empty-handed.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You try to grab him, but it was quicker than you and avoided the grab.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You try to grab him, but it was quicker than you and avoided the grab.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you grabbed and try to toss him away, you only made him to fall over you, rubbing its body against yours, getting you a bit worked up. You slipped off from below him and rose up again.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you grabbed and try to toss him away, you only made him to fall over you, rubbing its body against yours, getting you a bit worked up. You slipped off from below him and rose up again.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You try to grab your opponent by the crotch, but you slipped and hit it with your face instead turning you on and pushing him back at the same time.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You try to grab your opponent by the crotch, but you slipped and hit it with your face instead turning you on and pushing him back at the same time.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;

			}
		}
	}


	// // /// <summary>
	///  230 - 35, 15, 10, 15, 0, "Chokehold", "Very strong will damage that also increases the lust of both. Cost: 10 Will, 15 Lust", 0.1f, 0.8f
	/// </summary>

	public void skill230(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (30, 38);
		lustRand = Random.Range (13, 17);
		multiplier1 = (GameControl.attPhysical/500); // stat
		multiplier2 = Random.Range (0.1f, 0.5f); // random
		multiplier5 = Random.Range(0.1f, 0.4f);
		failDmgRand = Random.Range (9, 13);
		failLustRand = Random.Range (12, 18); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 15; 
		GameControl.actualArousal = GameControl.actualArousal + 15;

		if (randNum > 90)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You found a weak spot around your opponent and forced him against your torso, choking him with it. You continued smothering against it, as it try to force himself free, touching your whole body in the process, until it finally broke himself free.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You caught your opponent off-guard and began smothering him with your legs in a leglock around his head, forcing him to rub its face against your crotch, until it hits it with its face and forced you release the hold.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You caught your opponent off-guard and began smothering him with your legs in a leglock around his head, forcing him to rub its face against your crotch, until it hits it with its face and forced you release the hold.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You found a weak spot around your opponent and forced him against your torso, choking him with it. You continued smothering against it, as it try to force himself free, touching your whole body in the process, until it finally broke himself free.\n\n\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You got your opponent from the side and bend him a bit as you choked him, rubbing his ass with your genitals, until it pushed you enough to make you move back..\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You got your opponent from the side and bend him a bit as you choked him, rubbing his ass with your genitals, until it pushed you enough to make you move back..\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You caught your opponent from behind and started choking him, as your body started rubbing against its back, over and over until it repels you back to your position.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You caught your opponent from behind and started choking him, as your body started rubbing against its back, over and over until it repels you back to your position.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "Your opponent ducked when you try to held him in a chokehold, moving away from you.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "Your opponent ducked when you try to held him in a chokehold, moving away from you.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You try to grab your opponent on a chokehold, but it moved faster than you.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You try to grab your opponent on a chokehold, but it moved faster than you.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As the choke was being made, your opponent had time to interpose its arms to stop you from strangle him and hit you in the groin with one of its legs, leaving you sore as it repositions in front of you.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As the choke was being made, your opponent had time to interpose its arms to stop you from strangle him and hit you in the groin with one of its legs, leaving you sore as it repositions in front of you.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You grabbed him but it slipped your grasp and hits you in the groin as it moved away from you, as you just recovered from the pain from the hit.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You grabbed him but it slipped your grasp and hits you in the groin as it moved away from you, as you just recovered from the pain from the hit.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;

			}
		}
	}




	// // /// <summary>
	///  300 - 25, 5, 10, 0, 0, "Bodyslam", "Does medium damage to both, and can do lust damage. Cost: 10 will.", 0.15f, 0.85f
	/// </summary>

	public void skill300(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (18, 26);
		lustRand = Random.Range (3, 8);
		multiplier1 = (GameControl.attPhysical/500); // stat
		multiplier2 = Random.Range (0.0f, 0.3f); // random
		multiplier5 = Random.Range(0.1f, 0.3f);
		failDmgRand = Random.Range (6, 9);
		failLustRand = Random.Range (6, 12); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 10; 
		//GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 85)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You slammed your enemy on its back, slamming your groin and torso into its rear, almost humping it with great force into the ground in front of you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You slammed your enemy on its back, slamming your groin and torso into its rear, almost humping it with great force into the ground in front of you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You hit your opponent in its back, slamming your rear against the ass of it, feeling its softness as it forced it into the ground near you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You hit your opponent in its back, slamming your rear against the ass of it, feeling its softness as it forced it into the ground near you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You opponent felt the might of your physique, as you felt the softness of its flesh as it was being tendered by the slam, forcing him a good length away from the spot.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You opponent felt the might of your physique, as you felt the softness of its flesh as it was being tendered by the slam, forcing him a good length away from the spot.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You hit your opponent with your trunk, feeling the texture of its body as you launched it away from you a good distance.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You hit your opponent with your trunk, feeling the texture of its body as you launched it away from you a good distance.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You try to hit him with your body, but it ran out of the way in time, creating some space between him and you.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "You try to hit him with your body, but it ran out of the way in time, creating some space between him and you.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You try to slam him with force, but you missed your mark.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You try to slam him with force, but you missed your mark.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You try to hit your opponent with your body, but it just ducked and you tripped with him, touching its ass as you slammed into the ground with force.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You try to hit your opponent with your body, but it just ducked and you tripped with him, touching its ass as you slammed into the ground with force.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You try to slam your opponent, but it dodged in the last minute, forcing you to hit a hard surface that was nearby, shaking you for a second. \nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You try to slam your opponent, but it dodged in the last minute, forcing you to hit a hard surface that was nearby, shaking you for a second. \nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;

			}
		}
	}




	// // /// <summary>
	///  310 - 30, 0, 0, 15, 0, "Carnal Rage", "Recovers 30 will but rises 15 lust.", 0.1f, 1f
	/// </summary>

	public void skill310(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (28, 32);
		lustRand = Random.Range (0f, 0f);
		multiplier1 = (GameControl.attPhysical/500); // stat
		multiplier2 = Random.Range (0.1f, 0.6f); // random
		multiplier5 = Random.Range(0.1f, 0.4f);

		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		GameControl.actualArousal = GameControl.actualArousal + 15;

		if (randNum > 90)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1; 
			charDamageTotal = damageRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth + charDamageTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "Your libido found a thing you specially wanted to do to the body of your opponent, giving you renewed vigor for the combat.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "Your libido found a thing you specially wanted to do to the body of your opponent, giving you renewed vigor for the combat.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You found inspiration as you gaze at your opponent, as you cracked your knuckles and felt rejuvenated for the fight. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You found inspiration as you gaze at your opponent, as you cracked your knuckles and felt rejuvenated for the fight. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth + charDamageTotal; 
			GameControl.actualArousal = GameControl.actualArousal + lustRand; 

			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you focused on all the flesh that you can squeeze from your opponent, you could feel the will to fight to get it, returning.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you focused on all the flesh that you can squeeze from your opponent, you could feel the will to fight to get it, returning.\t\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You focused your libido on your opponent and all the things you could do to it, and with it, you recovered the will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You focused your libido on your opponent and all the things you could do to it, and with it, you recovered the will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;



			}
		} 

	}


	// // /// <summary>
	///  320 -30, 5, 5, 10, 1, "Bear hug", "Strong will damage with low accuracy. If it fails it increases your lust. Cost: 5 will, 10 lust.", 0.1f, 0.7f
	/// </summary>

	public void skill320(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (24, 30);
		lustRand = Random.Range (3, 6);
		multiplier1 = (GameControl.attPhysical/500); // stat
		multiplier2 = Random.Range (0.1f, 0.5f); // random
		multiplier5 = Random.Range(0.1f, 0.4f);
		failDmgRand = Random.Range (4, 7);
		failLustRand = Random.Range (10, 16); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 5; 
		GameControl.actualArousal = GameControl.actualArousal + 10;

		if (randNum > 90)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{
			case 0:
				WorldControl.charAttackDescription = "You grappled your enemy from the back of it and pulverized it between your arms, as it try to break free from the painful grab, until you gave a spin and threw him away from you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You grappled your enemy from the back of it and pulverized it between your arms, as it try to break free from the painful grab, until you gave a spin and threw him away from you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You grappled your opponent from the side and pressed it against your body, feeling how its puny body crumpled under your hug, until it limped into the ground for a second, after you tossed it close.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You grappled your opponent from the side and pressed it against your body, feeling how its puny body crumpled under your hug, until it limped into the ground for a second, after you tossed it close.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;



			}
		}
		else if (randNum > 30)
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
				WorldControl.charAttackDescription = "You accomplished a grapple and started squeezing it with all your strength, damaging your opponent before throwing it in front of you. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You accomplished a grapple and started squeezing it with all your strength, damaging your opponent before throwing it in front of you. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You grabbed him and crushed it with your arms against your firm torso, then toss him in front of you when your arms got tired of pressing for the moment.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You grabbed him and crushed it with your arms against your firm torso, then toss him in front of you when your arms got tired of pressing for the moment.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You try to grab him, but it was faster than you so you couldn’t get it into your deadly embrace.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "You try to grab him, but it was faster than you so you couldn’t get it into your deadly embrace.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You try to crush him with your arms, but it interposed its hands and endured enough to slip away from your grasp.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You try to crush him with your arms, but it interposed its hands and endured enough to slip away from your grasp.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you try to crush him between your arms, you smothered yourself on its torso as it hit your back with its arms, rubbing yourself against its crotch as you released it from your grip.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you try to crush him between your arms, you smothered yourself on its torso as it hit your back with its arms, rubbing yourself against its crotch as you released it from your grip.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "As you try to hug him and crush him, it kicks you in the groin as you felt your face against his genitals. you barely pushed back away from it and shook your head, visibly excited.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "As you try to hug him and crush him, it kicks you in the groin as you felt your face against his genitals. you barely pushed back away from it and shook your head, visibly excited.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;

			}
		}
	}


	// // /// <summary>
	///  330 - 40, 10, 15, 15, 1, "Reckless biting", "A very strong will that may stun the enemy. Cost: 15 will, 10 lust.", 0.15f, 0.8f 
	/// </summary>

	public void skill330(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (30, 40);
		lustRand = Random.Range (4, 9);
		multiplier1 = (GameControl.attPhysical/500); // stat
		multiplier2 = Random.Range (0.1f, 0.6f); // random
		multiplier5 = Random.Range(0f, 0.3f);
		failDmgRand = Random.Range (7, 15);
		failLustRand = Random.Range (0, 0); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 15; 
		GameControl.actualArousal = GameControl.actualArousal + 15;

		if (randNum > 85)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 

			if(WorldControl.enemyStunned == false){
				WorldControl.enemyStunned = true;
				WorldControl.eneStunCounter = Random.Range (1, 4);
			}


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You caught your enemy off guard and started biting it wildly several times, tasting it with your tongue every time you could, until it moved away enough for you to see several bite marks on its body. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You caught your enemy off guard and started biting it wildly several times, tasting it with your tongue every time you could, until it moved away enough for you to see several bite marks on its body. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You found the back of your opponent, so you got a chance to bite into its soft parts, especially its ass. More than strength to tear, you bited with passion every time, until your opponent pushed itself away from you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You found the back of your opponent, so you got a chance to bite into its soft parts, especially its ass. More than strength to tear, you bited with passion every time, until your opponent pushed itself away from you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You got a hold of your opponent and got to bite it twice, feeling the softness of its body as you left marks of your teeth on it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You got a hold of your opponent and got to bite it twice, feeling the softness of its body as you left marks of your teeth on it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You bite your opponent in a chance and pulled it close to you, before biting it once more with lust-driven savagery as it escaped away from you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You bite your opponent in a chance and pulled it close to you, before biting it once more with lust-driven savagery as it escaped away from you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You try to get close enough to your opponent for a bite, but it always kept enough distance from you.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "You try to get close enough to your opponent for a bite, but it always kept enough distance from you.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You try to bite your opponent with rage, but your enemy avoided your attacks until it was out of your danger zone. \nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You try to bite your opponent with rage, but your enemy avoided your attacks until it was out of your danger zone. \nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You try to wildly bite your opponent, but it managed to place one of your arms in front of you, which suffered from your own strong biting, damaging you strongly.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You try to wildly bite your opponent, but it managed to place one of your arms in front of you, which suffered from your own strong biting, damaging you strongly.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You try to bite your enemy, but you were too slow and bit one of your hands in the process, damaging yourself with it.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You try to bite your enemy, but you were too slow and bit one of your hands in the process, damaging yourself with it.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;

			}
		}
	}



	// // /// <summary>
	///  400 - 5, 20, 0, 0, 1, "Lust potion", "Good lust damage but low will damage. Critical failure does its damage to you. Cost 0.", 0.2f, 0.75f
	/// </summary>

	public void skill400(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (3, 6);
		lustRand = Random.Range (18, 22);
		multiplier1 = (GameControl.attMental/500); // stat
		multiplier2 = Random.Range (0.1f, 0.4f); // random
		multiplier5 = Random.Range(0.2f, 0.6f);
		failDmgRand = Random.Range (3, 6);
		failLustRand = Random.Range (18, 22); 
		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		//GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 80)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "The potion hit the tip of the head of your opponent, almost drenching it in the liquid, stimulating more visibly than the expected effect.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "The potion hit the tip of the head of your opponent, almost drenching it in the liquid, stimulating more visibly than the expected effect.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "The potion hit the head of your opponent, its contents filled the nostrils of your opponent, arousing it more than the usual effect.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "The potion hit the head of your opponent, its contents filled the nostrils of your opponent, arousing it more than the usual effect.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;



			}
		}
		else if (randNum > 25)
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
				WorldControl.charAttackDescription = "You saw how the potion broke into your opponent’s leg, seeing as the fumes started making effect over the will to fuck of your opponent, as you saw it in its eyes.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You saw how the potion broke into your opponent’s leg, seeing as the fumes started making effect over the will to fuck of your opponent, as you saw it in its eyes.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "The potion broke into your opponent's torso, its contents pouring all over it, making its head feel lighter than before.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "The potion broke into your opponent's torso, its contents pouring all over it, making its head feel lighter than before.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;



			}
		} 
		else if (randNum > 5) 
		{
			multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.charComDefense; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;

			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You threw the potion at your opponent, but it was faster than you thought and dodged enough to avoid its fumes.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "You threw the potion at your opponent, but it was faster than you thought and dodged enough to avoid its fumes.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You threw the potion at your opponent, but failed to hit it with the bottle, so it crashed away from it.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You threw the potion at your opponent, but failed to hit it with the bottle, so it crashed away from it.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1  - WorldControl.charComDefense;; 
			failDmgRand = failDmgRand * multiplierTotal ; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you were taking the potion from your bag, it fell into your feet and broke, the noxious fumes started working on your system, as you try to shake off its effects.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you were taking the potion from your bag, it fell into your feet and broke, the noxious fumes started working on your system, as you try to shake off its effects.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You try to toss the potion but it slips from your hand and breaks at your feet, as you started to feel its repercussions instead of the enemy.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You try to toss the potion but it slips from your hand and breaks at your feet, as you started to feel its repercussions instead of the enemy.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;

			}
		}
	}


	// // /// <summary>
	///  410 - 15, 15, 0, 0, 1, "Erotic Oils", "Very risky skill, only does critical hit and failure, but good mixed damage. Cost: 0.", 0.70f, 0.70f 
	/// </summary>

	public void skill410(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (13, 18);
		lustRand = Random.Range (13, 18);
		multiplier1 = (GameControl.attMental/500); // stat
		multiplier2 = Random.Range (0.1f, 0.6f); // random
		multiplier5 = Random.Range(0.1f, 0.4f);
		failDmgRand = Random.Range (6, 12);
		failLustRand = Random.Range (6, 12); 
		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		//GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 40)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "The oil bottle fell at the ground below your enemy, exploding and almost soaking it completely. Its eyes fell into a lustful haze, still looking at you, gasping a little bit more than before. Critical hit!\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "The oil bottle fell at the ground below your enemy, exploding and almost soaking it completely. Its eyes fell into a lustful haze, still looking at you, gasping a little bit more than before. Critical hit!\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You threw the oil at your opponent, as it exploded when landed on its torso, covering it with the substance that held, as You dressed how it gasped almost like a moan. It was working as intended.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You threw the oil at your opponent, as it exploded when landed on its torso, covering it with the substance that held, as You dressed how it gasped almost like a moan. It was working as intended.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;



			}
		}

		else if (randNum > 30) 
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
				WorldControl.charAttackDescription = "As you try to throw it, the oil slipped and exploded in the ground, covering you in its contents. You could feel the oil slipping through your clothing into your skin, creating a pleasant sensation that overflowed your senses for a second, raising your lust.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "As you try to throw it, the oil slipped and exploded in the ground, covering you in its contents. You could feel the oil slipping through your clothing into your skin, creating a pleasant sensation that overflowed your senses for a second, raising your lust.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "The fragile concoction broke as you try to throw it at your opponent, its contents drenching you almost completely, the sensation of the oil covering your skin felt amazing, as you felt how you were getting more and more excited with it.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "The fragile concoction broke as you try to throw it at your opponent, its contents drenching you almost completely, the sensation of the oil covering your skin felt amazing, as you felt how you were getting more and more excited with it.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = " As you try to throw it, the oil slipped and exploded in the ground, covering you in its contents. You could feel the oil slipping through your clothing into your skin, creating a pleasant sensation that overflowed your senses for a second, raising your lust.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = " As you try to throw it, the oil slipped and exploded in the ground, covering you in its contents. You could feel the oil slipping through your clothing into your skin, creating a pleasant sensation that overflowed your senses for a second, raising your lust.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = " As you try to throw it, the oil slipped and exploded in the ground, covering you in its contents. You could feel the oil slipping through your clothing into your skin, creating a pleasant sensation that overflowed your senses for a second, raising your lust.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = " As you try to throw it, the oil slipped and exploded in the ground, covering you in its contents. You could feel the oil slipping through your clothing into your skin, creating a pleasant sensation that overflowed your senses for a second, raising your lust.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;

			}
		}
	}




	// // /// <summary>
	///  420 - 5, 10, 0, 5, 1, "Sensitivity Dart", "Moderate lust damage. Critical hit increases lust damage for the rest of the battle. Cost: 5 Lust.", 0.2f, 0.75f 
	/// </summary>

	public void skill420(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (4, 8);
		lustRand = Random.Range (4, 8);
		multiplier1 = (GameControl.attMental/500); // stat
		multiplier2 = Random.Range (0.1f, 0.6f); // random
		multiplier5 = Random.Range(0.2f, 0.6f);
		failDmgRand = Random.Range (4, 8);
		failLustRand = Random.Range (0, 0); 
		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		GameControl.actualArousal = GameControl.actualArousal + 10;

		if (randNum > 80)
		{

			WorldControl.enemyCombDefense = WorldControl.enemyLustDefense - 0.15f;
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "The dart hit its face, as the formula started working on it. You saw him lay a knee on the ground, panting with its tongue out, getting heavily excited from the dart.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "The dart hit its face, as the formula started working on it. You saw him lay a knee on the ground, panting with its tongue out, getting heavily excited from the dart.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "The dart hit its neck, and you saw how your opponent had to hold his body for a moment, as the scent of fluids starts to fill the air around both of you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "The dart hit its neck, and you saw how your opponent had to hold his body for a moment, as the scent of fluids starts to fill the air around both of you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;



			}
		}
		else if (randNum > 25)
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
				WorldControl.charAttackDescription = "The dart hit one of its legs, and you saw how your enemy started gasping more and more, as you knew that his lust was betraying him at that moment.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "The dart hit one of its legs, and you saw how your enemy started gasping more and more, as you knew that his lust was betraying him at that moment.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "The dart hits home and you saw how your opponent hugged itself, his body getting flustered by the formula. It was obvious that it was getting hornier due to the attack.\n\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "The dart hits home and you saw how your opponent hugged itself, his body getting flustered by the formula. It was obvious that it was getting hornier due to the attack.\n\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You aimed for the torso of your opponent with your dart, but the opponent dodged it before it hits.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "You aimed for the torso of your opponent with your dart, but the opponent dodged it before it hits.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You shoot the dart, but missed your target completely\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You shoot the dart, but missed your target completely\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you loaded the dart, it fell from your hand. As you try to catch it in mid-air, it pinched your hand and passed the formula into you. Your body quickly started feeling hotter and hotter, as your libido increased with it.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you loaded the dart, it fell from your hand. As you try to catch it in mid-air, it pinched your hand and passed the formula into you. Your body quickly started feeling hotter and hotter, as your libido increased with it.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "When you try to throw the dart, you took a deep breath but the dart followed and got into your mouth, smearing your tongue with the formula. You started to feel your whole body more and more aroused by the sensation of the air that passed around it.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "When you try to throw the dart, you took a deep breath but the dart followed and got into your mouth, smearing your tongue with the formula. You started to feel your whole body more and more aroused by the sensation of the air that passed around it.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;

			}
		}
	}


	// // /// <summary>
	///  430 - 0, 40, 0, 20, 1, "Nympho concoction", "Very powerful potion, its fumes increase the lust of everyone around. Cost: 20 Lust", 0.1f, 0.8f
	/// </summary>

	public void skill430(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (0, 1f);
		lustRand = Random.Range (33, 41);
		multiplier1 = (GameControl.attMental/500); // stat
		multiplier2 = Random.Range (0.1f, 0.4f); // random
		multiplier5 = Random.Range(0.1f, 0.5f);
		failDmgRand = Random.Range (0, 1f);
		failLustRand = Random.Range (16, 21); 
		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		GameControl.actualArousal = GameControl.actualArousal + 20;

		if (randNum > 95)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "The vial smashed its head and poured over his face completely. You could see how the concoction seeped through its skin, making it gasp as its face was filled with desire to be fucked.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "The concoction flew swift and hit your opponent in its back, almost bathing it in the liquid. It started trembling and for a second started fondling itself from the arousal, but regained his senses after a second.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "The vial smashed its head and poured over his face completely. You could see how the concoction seeped through its skin, making it gasp as its face was filled with desire to be fucked.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "The vial smashed its head and poured over his face completely. You could see how the concoction seeped through its skin, making it gasp as its face was filled with desire to be fucked.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 30)
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
				WorldControl.charAttackDescription = "The concoction mixed with force flew across the battlefield and broke below your enemy, its contents soaking your opponent. Your opponent moaned for a second, as its body was trembling from all the pleasing sensations the concoction must’ve been doing to it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You threw the vial when it was ready and hit your opponent with it. As the concoction stained it, you could see that its eyes betrayed it as it darted from your erotic parts again and again.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You threw the vial when it was ready and hit your opponent with it. As the concoction stained it, you could see that its eyes betrayed it as it darted from your erotic parts again and again.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "The concoction mixed with force flew across the battlefield and broke below your enemy, its contents soaking your opponent. Your opponent moaned for a second, as its body was trembling from all the pleasing sensations the concoction must’ve been doing to it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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


			multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 



			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "When the concoction was mixed enough, you threw it at your opponent but it moved out of the way before it could affect it.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "When the concoction was mixed enough, you threw it at your opponent but it moved out of the way before it could affect it.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You mixed the concoction with all your might and threw it at your opponent with great force, but failed to hit it with the vial.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You mixed the concoction with all your might and threw it at your opponent with great force, but failed to hit it with the vial.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;

			multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 



			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You try to run close to hit it better, but your opponent avoided the vial and only you were close enough to feel the impact. Your mind was getting numb and the only thing you could think at the moment, was how to fuck the person that was in front of you.\n\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You try to run close to hit it better, but your opponent avoided the vial and only you were close enough to feel the impact. Your mind was getting numb and the only thing you could think at the moment, was how to fuck the person that was in front of you.\n\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "As you try to hit it, you mixed it before its time and exploded in front of you, soaking you in the concoction. Your body felt searing hot as you felt for a second at the verge of cumming. \nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "As you try to hit it, you mixed it before its time and exploded in front of you, soaking you in the concoction. Your body felt searing hot as you felt for a second at the verge of cumming. \nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;

			}
		}
	}



	// // /// <summary>
	///  500 - 10, 10, 0, 5, 1, "Sabotage", "Low lust and will damage but high critical. Cost: 0. ", 0.35f, 0.85f
	/// </summary>

	public void skill500(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (7, 11);
		lustRand = Random.Range (7, 11);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0f, 0.3f); // random
		multiplier5 = Random.Range(0.4f, 1f);
		failDmgRand = Random.Range (4, 7);
		failLustRand = Random.Range (0, 0); 
		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		//GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 65)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You pulled the leg and made it fall into the ground, then shoved your groin on the back of its head as it was still dazed by the fall.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You pulled the backside of your opponent and forced him to fall into its ass, confusing it for a pair of seconds.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You pulled the backside of your opponent and forced him to fall into its ass, confusing it for a pair of seconds.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;



			}
		}
		else if (randNum > 25)
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
				WorldControl.charAttackDescription = "You touched the ass of your opponent, as you pushed it to make it fall flat over its front side.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You touched the ass of your opponent, as you pushed it to make it fall flat over its front side.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You grabbed your enemy’s body as you made it trip over its own movement.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You grabbed your enemy’s body as you made it trip over its own movement.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You pushed the ass of your enemy trying to make it fall, but it didn’t had enough force for that. \nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "You pushed the ass of your enemy trying to make it fall, but it didn’t had enough force for that. \nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You try to force it to fail or trip as you moved next to it, but it regained its balance.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You try to force it to fail or trip as you moved next to it, but it regained its balance.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you try to force him to trip, you tripped instead and rolled your face to his thighs, trying your best not to inhale its scent, as you retreated from it.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you try to force him to trip, you tripped instead and rolled your face to his thighs, trying your best not to inhale its scent, as you retreated from it.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "As you try to sabotage your opponent, you made him trip over you, making him damage you as it was planned that you would damage him.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "As you try to sabotage your opponent, you made him trip over you, making him damage you as it was planned that you would damage him.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;

			}
		}
	}


	// // /// <summary>
	///  510 - 15, 15, 0, 0, 1, "Bravery", "It succeeds you regain will and reduce lust, but you lose will if it faills. ", 0.15f, 0.8f
	/// </summary>

	public void skill510(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (12, 17);
		lustRand = Random.Range (12, 17);
		multiplier1 = (GameControl.attPhysical/500); // stat
		multiplier2 = Random.Range (0.1f, 0.6f); // random
		multiplier5 = Random.Range(0.1f, 0.4f);
		failDmgRand = Random.Range (14, 17);
		failLustRand = Random.Range (0, 0); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 5; 
		GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 85)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth + charDamageTotal; 
			GameControl.actualArousal = GameControl.actualArousal - charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you were getting the clarity you wanted, you found out that the possibility of winning was high, so you focused on the prize: Your opponent’s body.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you were getting the clarity you wanted, you found out that the possibility of winning was high, so you focused on the prize: Your opponent’s body.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "As you understand the situation, you realize that you can win this, so you steel yourself a bit and focus on your enemy.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "As you understand the situation, you realize that you can win this, so you steel yourself a bit and focus on your enemy.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;



			}
		}
		else if (randNum > 20)
		{
			multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth + charDamageTotal; 
			GameControl.actualArousal = GameControl.actualArousal - charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You think that you don’t want to fight, but also don’t want to be ravaged, so you sharpen your senses for combat.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You think that you don’t want to fight, but also don’t want to be ravaged, so you sharpen your senses for combat.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You gather your thought and think about the dangers of losing, giving you a clearer head, but also the possibility of submitting came to mind.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You gather your thought and think about the dangers of losing, giving you a clearer head, but also the possibility of submitting came to mind.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;



			}
		} 
		else if (randNum > 5) 
		{
			multiplierTotal = multiplier1 + multiplier2 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You try to let the rational part of you take over, but the danger of the situation says otherwise, so you fail.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "You try to let the rational part of you take over, but the danger of the situation says otherwise, so you fail.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You try to think smart, but the combat heat isn’t allowing you.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You try to think smart, but the combat heat isn’t allowing you.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 



			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You try to think rationally, but the thought of being taken by your enemy to avoid more pain crosses your mind. You take some time to shake it off completely.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You try to think rationally, but the thought of being taken by your enemy to avoid more pain crosses your mind. You take some time to shake it off completely.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You try to pull yourself together in front of your foe, but you cannot think other thing than to surrender to it. That would be safer. You shook those thoughts quickly.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You try to pull yourself together in front of your foe, but you cannot think other thing than to surrender to it. That would be safer. You shook those thoughts quickly.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;

			}
		}
	}



	// // /// <summary>
	///  520 - 30, 10, 0, 10, 1, "Surprise grab", "Strong will damage with low accuracy but high critical. Cost: 10 Lust", 0.3f, 0.75f
	/// </summary>

	public void skill520(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (25, 32);
		lustRand = Random.Range (7, 11);
		multiplier1 = (GameControl.attPhysical/500); // stat
		multiplier2 = Random.Range (0.0f, 0.3f); // random
		multiplier5 = Random.Range(0.3f, 0.7f);
		failDmgRand = Random.Range (10, 14);
		failLustRand = Random.Range (0f, 1f); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 5; 
		GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 70)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "When your enemy was off guard, you had the chance to grab its ass and give it a good squeeze before it could retaliate.  \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "When your enemy was off guard, you had the chance to grab its ass and give it a good squeeze before it could retaliate.  \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You found your opponent unaware and had a chance to rub its crotch with expertise, when your enemy try to hit you, you were no longer there, like a crotch-touching shadow. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You found your opponent unaware and had a chance to rub its crotch with expertise, when your enemy try to hit you, you were no longer there, like a crotch-touching shadow. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;



			}
		}
		else if (randNum > 25)
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
				WorldControl.charAttackDescription = "You found the back of your opponent as you began touching its body almost in a pesky way. Your opponent try to get a hold of you, but you nimbly dodged them all until you were satisfied and moved out of its reach.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You found the back of your opponent as you began touching its body almost in a pesky way. Your opponent try to get a hold of you, but you nimbly dodged them all until you were satisfied and moved out of its reach.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You get to touch your opponent’s body from torso to thighs, as it tries to catch you but it can’t. It was surprisingly soft, until you have to return to your position for safety reasons.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You get to touch your opponent’s body from torso to thighs, as it tries to catch you but it can’t. It was surprisingly soft, until you have to return to your position for safety reasons.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You try to get closer to your opponent, but it was faster than you originally thought, so you return to your original position.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "You try to get closer to your opponent, but it was faster than you originally thought, so you return to your original position.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You try to touch your opponent but almost hits you and you think that its not worth the risk.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You try to touch your opponent but almost hits you and you think that its not worth the risk.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you were touching its whole body, your opponent gets a hand on you and toss you away from it with force, slamming you against the floor.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you were touching its whole body, your opponent gets a hand on you and toss you away from it with force, slamming you against the floor.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You try to touch the opponent’s body, the opponent turns in time and hits you with one of its arms, sending you flying a small distance.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You try to touch the opponent’s body, the opponent turns in time and hits you with one of its arms, sending you flying a small distance.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;

			}
		}
	}


	// // /// <summary>
	///  530 - 35, 15, 5, 20, 1, "Innocent strike", "You deceive and taunt your opponent into attacking you, dealing a surprise attack, high critical. Cost: 5 will, 20 lust.", 0.3f, 0.8f
	/// </summary>

	public void skill530(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (26, 30);
		lustRand = Random.Range (9, 13);
		multiplier1 = (GameControl.attPhysical/500); // stat
		multiplier2 = Random.Range (0f, 0.4f); // random
		multiplier5 = Random.Range(0.6f, 1.2f);
		failDmgRand = Random.Range (3, 7);
		failLustRand = Random.Range (9, 16); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 10; 
		GameControl.actualArousal = GameControl.actualArousal + 20;

		if (randNum > 70)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "When you played weak in front of your opponent, it try to get a hand of you, but you spring from your place and landed on its torso, making him fall over its back. You shoved your groin and rubbed it all over its face, filling its face with your scent, then retreated.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "When you played weak in front of your opponent, it try to get a hand of you, but you spring from your place and landed on its torso, making him fall over its back. You shoved your groin and rubbed it all over its face, filling its face with your scent, then retreated.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "When you exposed a weak spot, your opponent try to get to it, but you saw him trip just in time for you to give full attention to its body. You touch, grope and taste as much as you could, before your opponent had a chance to fight back.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "When you exposed a weak spot, your opponent try to get to it, but you saw him trip just in time for you to give full attention to its body. You touch, grope and taste as much as you could, before your opponent had a chance to fight back.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You exposed a bit of your tender parts, trying to get its attention. Your enemy try to get the advantage, but you expected that. You had a chance to smack its ass and give it a hump, as it try to regain its balance. When it did, you were back into position.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You exposed a bit of your tender parts, trying to get its attention. Your enemy try to get the advantage, but you expected that. You had a chance to smack its ass and give it a hump, as it try to regain its balance. When it did, you were back into position.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You showed a bit of skin, taunting him to attack you. Your opponent saw an opportunity and try to take it, but when it try, you took the chance to stroke its genitals with expertise as its attack failed completely. Flushed with arousal, your opponent took a step back.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You showed a bit of skin, taunting him to attack you. Your opponent saw an opportunity and try to take it, but when it try, you took the chance to stroke its genitals with expertise as its attack failed completely. Flushed with arousal, your opponent took a step back.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You try your best to lay a trap to your opponent, but it didn’t reacted to it as you expected.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "You try your best to lay a trap to your opponent, but it didn’t reacted to it as you expected.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You try to taunt your opponent but it didn’t fell into the trap.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You try to taunt your opponent but it didn’t fell into the trap.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You teased him to attack you as you showed yourself vulnerable. But you didn’t expected for him to react so quickly, and it hit you with one of its knees, knocking you on your back, but you recovered quickly.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You teased him to attack you as you showed yourself vulnerable. But you didn’t expected for him to react so quickly, and it hit you with one of its knees, knocking you on your back, but you recovered quickly.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You undressed slowly a part of your torso and teased for him to attack you swiftly. And so it did, hitting you with one of its arms and pushing you back several feet. \nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You undressed slowly a part of your torso and teased for him to attack you swiftly. And so it did, hitting you with one of its arms and pushing you back several feet. \nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;

			}
		}
	}


	// // /// <summary>
	///  600 - 15, 5, 0, 0, 1, "Soothing Message", "Mix low damage with high accuracy and no cost.", 0.2f, 0.9f 
	/// </summary>

	public void skill600(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (12, 16);
		lustRand = Random.Range (4, 7);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0.1f, 0.6f); // random
		multiplier5 = Random.Range(0.1f, 0.4f);
		failDmgRand = Random.Range (10, 15);
		//failLustRand = Random.Range (6, 12); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 5; 
		GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 90)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "Your enemy felt connected to you for a second, due to your motivating phrasing, its effects greatly increased.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "Your enemy felt connected to you for a second, due to your motivating phrasing, its effects greatly increased.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "Your selection of words are compelling to your opponent, working better than intended.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "Your selection of words are compelling to your opponent, working better than intended.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;



			}
		}
		else if (randNum > 10)
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
				WorldControl.charAttackDescription = "Your promises of calm and enjoyment seemed to be working, as your enemy was looking more compliant to your words, lowering its will to fight and increasing its will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "Your promises of calm and enjoyment seemed to be working, as your enemy was looking more compliant to your words, lowering its will to fight and increasing its will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You started using a calming tone of voice, showing that you meant to please and calm your enemy, damaging both will to fight and fuck.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You started using a calming tone of voice, showing that you meant to please and calm your enemy, damaging both will to fight and fuck.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You words and promises weren’t enough for your enemy.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "You words and promises weren’t enough for your enemy.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You try to make it relax, but your words weren’t working as intended.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You try to make it relax, but your words weren’t working as intended.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "Your words bothered your enemy, who answer with cutting words, hurting you a bit.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "Your words bothered your enemy, who answer with cutting words, hurting you a bit.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "Your poor word-picking on that phrase made you feel ashamed of yourself by a large amount, lowering your own will to fight.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "Your poor word-picking on that phrase made you feel ashamed of yourself by a large amount, lowering your own will to fight.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;

			}
		}
	}


	// // /// <summary>
	///  610 0, 15, 10, 0, 1, "Lewd taunt", "Low lust damage that can reduce the enemy defense for the rest of the battle. Cost: 10 will", 0.25f, 0.85f 
	/// </summary>

	public void skill610(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (5, 9);
		lustRand = Random.Range (11, 16);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0f, 0.3f); // random
		multiplier5 = Random.Range(0.3f, 0.9f);
		failDmgRand = Random.Range (4, 7);
		failLustRand = Random.Range (6, 15); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 10; 
		//GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 80)
		{
			WorldControl.enemyCombDefense = WorldControl.enemyCombDefense - 0.15f;
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As if it liked one of the lews things you said that you could do, its shoulders relaxed a bit and looked at you with a cautious interest.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As if it liked one of the lews things you said that you could do, its shoulders relaxed a bit and looked at you with a cautious interest.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "Your enemy seemed captivated about the erotic things that you were promising it to do to it. Its posture changed a bit, but it wasn’t completely sure of it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "Your enemy seemed captivated about the erotic things that you were promising it to do to it. Its posture changed a bit, but it wasn’t completely sure of it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "Some things you were saying that you would do to it if he surrendered made your opponent think, as it seemed a little bit more reluctant to keep fighting you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "Some things you were saying that you would do to it if he surrendered made your opponent think, as it seemed a little bit more reluctant to keep fighting you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "It seemed that you were having progress, as the creature seemed less hostile than before the start of the fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "It seemed that you were having progress, as the creature seemed less hostile than before the start of the fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "Most of the words you were saying seemed to be falling into deaf ears.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "Most of the words you were saying seemed to be falling into deaf ears.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You try to talk some sense into it, but it wasn’t good enough.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You try to talk some sense into it, but it wasn’t good enough.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you try to talk him out of the combat, you say something that sounded menacing, so the creature attacked as it thought that you were planning on attacking, hitting you menacingly.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you try to talk him out of the combat, you say something that sounded menacing, so the creature attacked as it thought that you were planning on attacking, hitting you menacingly.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You try to talk him of wonderful things that you would do, but something you said was touchy for your opponent, so he lashed out and damaged you.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You try to talk him of wonderful things that you would do, but something you said was touchy for your opponent, so he lashed out and damaged you.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;

			}
		}
	}



	// // /// <summary>
	///  620 - 35, 5, 0, 20, 1, "Diplomatic immunity", "Strong damage to will to fight, but the powerplay increases your lust. Cost: 20 Lust", 0.1f, 0.8f 
	/// </summary>

	public void skill620(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (30, 37);
		lustRand = Random.Range (4, 7);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0.1f, 0.4f); // random
		multiplier5 = Random.Range(0.3f, 0.7f);
		failDmgRand = Random.Range (10, 16);
		failLustRand = Random.Range (0, 0); 
		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		GameControl.actualArousal = GameControl.actualArousal + 20;

		if (randNum > 90)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "Your words strike at the heart of your enemy, relaxing it far more than you expected at first.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "Your words strike at the heart of your enemy, relaxing it far more than you expected at first.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You found a pivotal point between you and it, using it to your advantage and lowering its will to fight by a larger amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You found a pivotal point between you and it, using it to your advantage and lowering its will to fight by a larger amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You start to talk down your opponent with your powers of conviction, but the power over your opponent turns you on a bit.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You start to talk down your opponent with your powers of conviction, but the power over your opponent turns you on a bit.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "The words that came from your mouth were silky enough to calm down your opponent, but the thought of your control over your enemy, increased your will to fuck.\n\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "The words that came from your mouth were silky enough to calm down your opponent, but the thought of your control over your enemy, increased your will to fuck.\n\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
			GameControl.actualArousal = GameControl.actualArousal - 10;

			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "Your manipulative words fell into fall ears.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "Your manipulative words fell into fall ears.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You try to calm down your opponent, but it was in vain.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You try to calm down your opponent, but it was in vain.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;
			GameControl.actualArousal = GameControl.actualArousal - 5;

			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You said something that irritated your opponent, who jabbed at you in retaliation, dealing you damage.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You said something that irritated your opponent, who jabbed at you in retaliation, dealing you damage.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You slipped your tongue in a dangerous matter, enraging your enemy. He hit you in the belly without warning, pushing you back and dealing you damage.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You slipped your tongue in a dangerous matter, enraging your enemy. He hit you in the belly without warning, pushing you back and dealing you damage.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;

			}
		}
	}




	// // /// <summary>
	///  630 - 15, 35, 15, 15, 1, "Erotic story", "High lust damage and moderate will damage. Cost: 10 will, 15 lust.", 0.2f, 0.9f 
	/// </summary>

	public void skill630(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (10, 15);
		lustRand = Random.Range (30, 34);
		multiplier1 = (GameControl.attPhysical/500); // stat
		multiplier2 = Random.Range (0.1f, 0.6f); // random
		multiplier5 = Random.Range(0.1f, 0.4f);
		failDmgRand = Random.Range (10, 14);
		failLustRand = Random.Range (10, 14); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 15; 
		GameControl.actualArousal = GameControl.actualArousal + 15;

		if (randNum > 80)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1 - WorldControl.enemyCombDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you told your tale, you saw how your enemy started walking towards you, almost entranced by your anecdote. Its posture changed almost completely, but it still had its doubts.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you told your tale, you saw how your enemy started walking towards you, almost entranced by your anecdote. Its posture changed almost completely, but it still had its doubts.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "Something you said got the complete attention of your enemy, as he got closer to you only to hear the story properly. It looked like eager to know what other things you could do.\n\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "Something you said got the complete attention of your enemy, as he got closer to you only to hear the story properly. It looked like eager to know what other things you could do.\n\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "As you started telling your erotic narrative, your opponent lowered its shoulders as it continued hearing your anecdote. Its aversion against you, slowly drifted away from him.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you started telling your erotic narrative, your opponent lowered its shoulders as it continued hearing your anecdote. Its aversion against you, slowly drifted away from him.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "Your enemy got intrigued by your erotic story, hearing as best as it could from that distance. You could see his skin getting slowly flustered by the story, as it was getting more and more interested in the things you have done. Its hostility lowered in a large amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "Your enemy got intrigued by your erotic story, hearing as best as it could from that distance. You could see his skin getting slowly flustered by the story, as it was getting more and more interested in the things you have done. Its hostility lowered in a large amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "As you told your story, your enemy seemed to be not interested in it.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "As you told your story, your enemy seemed to be not interested in it.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "The story seems to be too simple (or too complex) to your opponent.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "The story seems to be too simple (or too complex) to your opponent.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you told the story, your opponent heard something that it didn’t liked and hit you with one of its knees in your chest, stopping you from continuing with that story and hurting you.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you told the story, your opponent heard something that it didn’t liked and hit you with one of its knees in your chest, stopping you from continuing with that story and hurting you.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You try to tell an erotic story, but it seemed to be that you touched something bad in it, as your enemy enraged and hit you with one of its arms, damaging you.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You try to tell an erotic story, but it seemed to be that you touched something bad in it, as your enemy enraged and hit you with one of its arms, damaging you.\nThe attack reduced your will in " + failDmgRand + " points and increased your lust in " + failLustRand + " points!"; 
				break;

			}
		}
	}


	//skills level up/// <summary>
	/// ////////////// NEED to update the rest of skills, same function but more clean////////////////////////////////////////////////////////////////////////////////////
	/// </summary>
	void skill100LevelUp(){
		if (GameControl.skillSetCounter [0] > 10 && GameControl.skillSetLevel [0] < 3) {
			if (GameControl.skillSetLevel [0] < 3)
			{
				GameControl.skillSetLevel [0] += 1;
				GameControl.skillSetCounter [0] = 0; 
				//CombatScript.levelUpTxt = "Your Balanced combat skill leveled up!";
			}
		}

	}

	void skill200LevelUp(){
		if (GameControl.skillSetCounter [1] > 10 && GameControl.skillSetLevel [1] < 3) {
			if (GameControl.skillSetLevel [1] < 3)
			{
				GameControl.skillSetLevel [1] += 1;
				GameControl.skillSetCounter [1] = 0; 
				//CombatScript.levelUpTxt = "You martial arts combat skill just leveled up!";
			}
		}

	}


	void skill300LevelUp(){
		if (GameControl.skillSetCounter [2] > 10 && GameControl.skillSetLevel [2] < 3) {
			if (GameControl.skillSetLevel [2] < 3)
			{
				GameControl.skillSetLevel [2] += 1;
				GameControl.skillSetCounter [2] = 0; 
				//CombatScript.levelUpTxt = "Your Berserker combat skill leveled up!";
			}
		}

	}

	void skill400LevelUp(){
		if (GameControl.skillSetCounter [3] > 10 && GameControl.skillSetLevel [3] < 3) {
			if (GameControl.skillSetLevel [3] < 3)
			{
				GameControl.skillSetLevel [3] += 1;
				GameControl.skillSetCounter [3] = 0; 
				//CombatScript.levelUpTxt = "Your Alchemist combat skill leveled up!";
			}
		}

	}

	void skill500LevelUp(){
		if (GameControl.skillSetCounter [4] > 10 && GameControl.skillSetLevel [4] < 3) {
			if (GameControl.skillSetLevel [4] < 3)
			{
				GameControl.skillSetLevel [4] += 1;
				GameControl.skillSetCounter [4] = 0; 
				//CombatScript.levelUpTxt = "Your Trickster combat skill leveled up!";
			}
		}

	}

	void skill600LevelUp(){
		if (GameControl.skillSetCounter [5] > 10 && GameControl.skillSetLevel [5] < 3)
		{

				GameControl.skillSetLevel [5] += 1;
				GameControl.skillSetCounter [5] = 0; 
				//CombatScript.levelUpTxt = "Your diplomatic combat skill leveled up!";

		}

	}

	/*
	void statPhysLevelUp(){
		if (GameControl.physicalCounter > 5 && GameControl.attPhysical < 100) {
			GameControl.attPhysical += 1; 
			GameControl.physicalCounter = 0; 
		}
	}

	void statMentLevelUp(){
		if (GameControl.mentalCounter > 5 && GameControl.attMental < 100) {
			GameControl.attMental += 1;
			GameControl.mentalCounter = 0;
		}

	}

	void statSocLevelUp(){
		if (GameControl.socialCounter > 5 && GameControl.attSocial < 100) {
			GameControl.attSocial += 1;
			GameControl.socialCounter = 0;
		}

	}
	*/










	// // // // // // // // // //


	public void Calculator(){
		int i = 0;
		while (i < 1000) {
			skill630 ();
			calcSum = calcSum + charDamageTotal;
			calcSumFail = calcSumFail + failDmgRand; 
			//calcSumFail = calcSumFail + failLustRand; 
			calcLust = calcLust + charLustTotal; 
			i++;
		}
		calcSum = calcSum / 1000; 
		calcSumFail = calcSumFail / 1000;
		calcLust = calcLust / 1000;
		Debug.Log("caclSum is " + calcSum);
		Debug.Log ("calcSumFail is " + calcSumFail);
		Debug.Log ("calcLust is " + calcLust);
	}


	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
