using UnityEngine;
using System.Collections;

public class LustFun : MonoBehaviour {
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
	/// Check SkillFun for the logic behind this 
	/// </summary>




	public void SkillUse()
	{
		multiplier3 = WorldControl.charLustAttackArmor;
		multiplier4 = WorldControl.charLustAttackWeapon;

		switch (WorldControl.skillID) 
		{
		case 100: 
			GameControl.lustSetCounter [0] += 1;
			lust100LevelUp ();
			GameControl.attSocial += 0.3f;

			////statSocLevelUp ();

			Lust100 ();
			break;
		case 110:
			GameControl.lustSetCounter [0] += 1;
			lust100LevelUp ();
			GameControl.attSocial += 0.3f;
			////statSocLevelUp ();

			Lust110 ();
			break;
		case 120:
			GameControl.lustSetCounter [0] += 1;
			lust100LevelUp ();
			GameControl.attSocial += 0.3f;
			//statSocLevelUp ();

			Lust120 ();
			break;
		case 130:
			GameControl.lustSetCounter [0] += 1;
			lust100LevelUp ();
			GameControl.attSocial += 0.3f;
			//statSocLevelUp ();

			Lust130 ();
			break;
		case 200:
			GameControl.lustSetCounter [1] += 1;
			lust200LevelUp ();
			GameControl.attMental += 0.3f;
			//statMentLevelUp ();

			Lust200 ();
			break;
		case 210:
			GameControl.lustSetCounter [1] += 1;
			lust200LevelUp ();
			GameControl.attMental += 0.3f;
			//statMentLevelUp ();

			Lust210 ();
			break;
		case 220:
			GameControl.lustSetCounter [1] += 1;
			lust200LevelUp ();
			GameControl.attMental += 0.3f;
			//statMentLevelUp ();

			Lust220 ();
			break;
		case 230:
			GameControl.lustSetCounter [1] += 1;
			lust200LevelUp ();
			GameControl.attMental += 0.3f;
			//statMentLevelUp ();

			Lust230 ();
			break;
		case 300:
			GameControl.lustSetCounter [2] += 1;
			lust300LevelUp ();
			GameControl.attSocial += 0.3f;
			//statSocLevelUp ();

			Lust300 ();
			break;
		case 310:
			GameControl.lustSetCounter [2] += 1;
			lust300LevelUp ();
			GameControl.attSocial += 0.3f;
			//statSocLevelUp ();

			Lust310 ();
			break;
		case 320:
			GameControl.lustSetCounter [2] += 1;
			lust300LevelUp ();
			GameControl.attSocial += 0.3f;
			//statSocLevelUp ();

			Lust320 ();
			break;
		case 330:
			GameControl.lustSetCounter [2] += 1;
			lust300LevelUp ();
			GameControl.attSocial += 0.3f;
			//statSocLevelUp ();

			Lust330 ();
			break;
		case 400:
			GameControl.lustSetCounter [3] += 1;
			lust400LevelUp ();
			GameControl.attSocial += 0.3f;
			//statSocLevelUp ();

			Lust400 ();
			break;
		case 410:
			GameControl.lustSetCounter [3] += 1;
			lust400LevelUp ();
			GameControl.attSocial += 0.3f;
			//statSocLevelUp ();

			Lust410 ();
			break;
		case 420:
			GameControl.lustSetCounter [3] += 1;
			lust400LevelUp ();
			GameControl.attSocial += 0.3f;
			//statSocLevelUp ();

			Lust420 ();
			break;
		case 430:
			GameControl.lustSetCounter [3] += 1;
			lust400LevelUp ();
			GameControl.attSocial += 0.3f;
			//statSocLevelUp ();

			Lust430 ();
			break;
		case 500:
			GameControl.lustSetCounter [4] += 1;
			lust500LevelUp ();
			GameControl.attSocial += 0.3f;
			//statSocLevelUp ();

			Lust500 ();
			break;
		case 510:
			GameControl.lustSetCounter [4] += 1;
			lust500LevelUp ();
			GameControl.attSocial += 0.3f;
			//statSocLevelUp ();

			Lust510 ();
			break;
		case 520:
			GameControl.lustSetCounter [4] += 1;
			lust500LevelUp ();
			GameControl.attSocial += 0.3f;
			//statSocLevelUp ();

			Lust520 ();
			break;
		case 530:
			GameControl.lustSetCounter [4] += 1;
			lust500LevelUp ();
			GameControl.attSocial += 0.3f;
			//statSocLevelUp ();

			Lust530 ();
			break;
		case 600:
			GameControl.lustSetCounter [5] += 1;
			lust600LevelUp ();
			GameControl.attPhysical += 0.3f;
			//statPhysLevelUp ();

			Lust600 ();
			break;
		case 610:
			GameControl.lustSetCounter [5] += 1;
			lust600LevelUp ();
			GameControl.attPhysical += 0.3f;
			//statPhysLevelUp ();

			Lust610 ();
			break;
		case 620:
			GameControl.lustSetCounter [5] += 1;
			lust600LevelUp ();
			GameControl.attPhysical += 0.3f;
			//statPhysLevelUp ();

			Lust620 ();
			break;
		case 630:
			GameControl.lustSetCounter [5] += 1;
			lust600LevelUp ();
			GameControl.attPhysical += 0.3f;
			//statPhysLevelUp ();

			Lust630 ();
			break;
		}
	}



	// // /// <summary>
	///  100 - 0, 15, 0, 0, 1, "Indecent smile", "Low lust damage, at no cost and High accuracy.", 0.1f, 0.9f 
	/// </summary>

	public void Lust100(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (0, 0);
		lustRand = Random.Range (13, 18);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0.1f, 0.5f); // random
		multiplier5 = Random.Range(0.3f, 0.8f);
		failDmgRand = Random.Range (3, 8);
		failLustRand = Random.Range (0, 0); 
		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		//GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 90)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + multiplier5 + 1 -  WorldControl.enemyLustDefense;
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You played playfully with your lips as you looked at your opponent, which found it very suggestive and stared at you, visually more aroused than you expected.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You played playfully with your lips as you looked at your opponent, which found it very suggestive and stared at you, visually more aroused than you expected.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "Your face gestures found a soft spot in your opponent’s gaze as it almost took a step towards you, almost in a trance state, apparently getting excited by your display.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "Your face gestures found a soft spot in your opponent’s gaze as it almost took a step towards you, almost in a trance state, apparently getting excited by your display.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 10)
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1 -  WorldControl.enemyLustDefense;
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "Your indecent smile strikes home and turns on your enemy a bit, as lets it to wonder of what was in your mind.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "Your indecent smile strikes home and turns on your enemy a bit, as lets it to wonder of what was in your mind.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "Your smile caught the attention of your opponent, who somehow wonders what is that smile hiding, having lustful thoughts about it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "Your smile caught the attention of your opponent, who somehow wonders what is that smile hiding, having lustful thoughts about it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "Your mischievous smile wasn’t working with your opponent right now.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "Your mischievous smile wasn’t working with your opponent right now.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
			
				break;
			case 2:

				WorldControl.charAttackDescription = "Your opponent seems to be uninterested in your smiling.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "Your opponent seems to be uninterested in your smiling.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "Your smile went out funnier than you expected, making you feel stupid and embarassed of yourself.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "Your smile went out funnier than you expected, making you feel stupid and embarassed of yourself.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "Your smile went out more sinister than you expected, making the opponent to give you an oddly look.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "Your smile went out more sinister than you expected, making the opponent to give you an oddly look.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}

	// // /// <summary>
	///  110 - 5, 20, 0, 5, 1, "Skin-show", "You reveal enough to tease, doing normal lust damage. Cost 5 will. ", 0.15f, 0.85f
	/// </summary>

	public void Lust110(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (4, 7);
		lustRand = Random.Range (15, 21);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0.1f, 0.6f); // random
		multiplier5 = Random.Range(0.1f, 0.4f);
		failDmgRand = Random.Range (4, 8);
		failLustRand = Random.Range (0, 0); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 5; 
		//GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 85)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1 - WorldControl.enemyLustDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You pulled a bigger fake skin-revealing, as your opponent took a step towards you and gulped, its eyes were getting full of lust due to your show. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You pulled a bigger fake skin-revealing, as your opponent took a step towards you and gulped, its eyes were getting full of lust due to your show. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "As you faked a mistake, even your worried voice sounded completely real. The soft skin that you showed, grabbed the attention of your opponent, as it looked like that it was one of his favorite parts of the body. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "As you faked a mistake, even your worried voice sounded completely real. The soft skin that you showed, grabbed the attention of your opponent, as it looked like that it was one of his favorite parts of the body. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 20)
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1 -  WorldControl.enemyLustDefense;
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You faked a cloth malfunction, showing off some skin. Your opponent wasn’t expecting that and its body jerked for a moment, trying to get a grab of you, but you kept your distance. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You faked a cloth malfunction, showing off some skin. Your opponent wasn’t expecting that and its body jerked for a moment, trying to get a grab of you, but you kept your distance. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You showed a delightful part of your body, as if it was a mistake, and your opponent caught it, gulping as it was unexpected, its face blushed a bit for arousal.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You showed a delightful part of your body, as if it was a mistake, and your opponent caught it, gulping as it was unexpected, its face blushed a bit for arousal.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You faked a cloth ripping, but your opponent wasn’t interested about that part of your body.\n\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "You faked a cloth ripping, but your opponent wasn’t interested about that part of your body.\n\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You conveniently showed some skin, but your opponent was looking at other part of you. \nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You conveniently showed some skin, but your opponent was looking at other part of you. \nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you try to falsify the show of some skin, you failed to free your aesthetically pleasing flesh and tripped as you try for one last time, this time in was completely real.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you try to falsify the show of some skin, you failed to free your aesthetically pleasing flesh and tripped as you try for one last time, this time in was completely real.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "As you try to fake a wardrobe malfunction, you got yourself stuck. When you unstuck, you fell to the ground, slamming the ground in an uncomfortable position.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "As you try to fake a wardrobe malfunction, you got yourself stuck. When you unstuck, you fell to the ground, slamming the ground in an uncomfortable position.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}

	// // /// <summary>
	///  120 - 0, 25, 20, 35, 1, "Trip up", "You “fall”, revealing a little too much. Good lust damage. Cost 10 will." , 0.2f, 0.8f 
	/// </summary>

	public void Lust120(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (0, 0);
		lustRand = Random.Range (20, 26);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0.1f, 0.4f); // random
		multiplier5 = Random.Range(0.2f, 0.7f);
		failDmgRand = Random.Range (8, 14);
		failLustRand = Random.Range (0, 0); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 10; 
		//GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 80)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1 - WorldControl.enemyLustDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "When you faked one of your trips, you tripped in your opponent legs, falling over a part of it, pushing your naughty bits against an opponent’s part of its body. You retreated as fast as possible, leaving your opponent noticeably more aroused than before.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "When you faked one of your trips, you tripped in your opponent legs, falling over a part of it, pushing your naughty bits against an opponent’s part of its body. You retreated as fast as possible, leaving your opponent noticeably more aroused than before.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "As you faked your trip, it seemed to be that you exposed a part that your opponent loved, because its eyes filled with lust and try to get a hold of you, but you easily escaped. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "As you faked your trip, it seemed to be that you exposed a part that your opponent loved, because its eyes filled with lust and try to get a hold of you, but you easily escaped. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 20)
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1 -  WorldControl.enemyLustDefense;
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You faked a trip during an attack, exposing your appealing ass towards your opponent. It thought that you were presenting yourself, so it got turned on by it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You faked a trip during an attack, exposing your appealing ass towards your opponent. It thought that you were presenting yourself, so it got turned on by it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You tripped in a playful manner during an escape, your opponent thought that you were surrendering and got excited, before you pulled away just in time to escape.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You tripped in a playful manner during an escape, your opponent thought that you were surrendering and got excited, before you pulled away just in time to escape.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You faked a tripping, but your opponent didn’t thought it was lustful enough.\n\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "You faked a tripping, but your opponent didn’t thought it was lustful enough.\n\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You tripped playfully, but the opponent wasn’t looking at you at that second.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You tripped playfully, but the opponent wasn’t looking at you at that second.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You hit your face in the ground with a funny sound. It hurted a lot and it didn’t worked as intended.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You hit your face in the ground with a funny sound. It hurted a lot and it didn’t worked as intended.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You tripped up for real, hitting your back in a painful way, it wasn’t erotic at all and you hurt yourself in the process.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You tripped up for real, hitting your back in a painful way, it wasn’t erotic at all and you hurt yourself in the process.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}




	// // /// <summary>
	///  130 - 20, 35, 20, 10, 1, "Playful chase", "It take the enemy a minute to realize you are playing around with him. Great lust damage. Cost: 20 Will, 10 lust", 0.2f, 0.85f 
	/// </summary>

	public void Lust130(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (14, 19);
		lustRand = Random.Range (27, 33);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0.1f, 0.5f); // random
		multiplier5 = Random.Range(0.1f, 0.5f);
		failDmgRand = Random.Range (9, 15);
		failLustRand = Random.Range (0, 0); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 20; 
		GameControl.actualArousal = GameControl.actualArousal + 10;

		if (randNum > 80)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1 - WorldControl.enemyLustDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "When you got him to chase you, he tripped and fell, which gave you time to play with its body a bit, until he stood up once more, visibly more excited than before. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "When you got him to chase you, he tripped and fell, which gave you time to play with its body a bit, until he stood up once more, visibly more excited than before. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "As you made it chase you, you had the chance to rub its body with your hands or body, making him moan with arousal, until he had to stop due to the sensations\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "As you made it chase you, you had the chance to rub its body with your hands or body, making him moan with arousal, until he had to stop due to the sensations\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 20)
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1 -  WorldControl.enemyLustDefense;
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You lured him into a chase around the place, as you toned the muscles of your ass, to keep it interested. Your enemy try its best to catch you, the chase getting him more and more worked on, until it couldn’t run more, so you kept your distance of him once more.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You lured him into a chase around the place, as you toned the muscles of your ass, to keep it interested. Your enemy try its best to catch you, the chase getting him more and more worked on, until it couldn’t run more, so you kept your distance of him once more.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You started running while looking at him in a playful manner, your opponent getting more and more excited as it was always at the edge of grabbing you, but you always escaped at the last moment. He finally got tired and stopped chasing you, visibly more aroused by it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You started running while looking at him in a playful manner, your opponent getting more and more excited as it was always at the edge of grabbing you, but you always escaped at the last moment. He finally got tired and stopped chasing you, visibly more aroused by it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You try to get him to follow you, but he wasn’t committing to a chase.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "You try to get him to follow you, but he wasn’t committing to a chase.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You ran around him, but it seemed uninterested abour chasing you.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You ran around him, but it seemed uninterested abour chasing you.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you retreated in an almost whimsical way, your opponent got you cornered and lunged at you, groping all your naughty parts with passion. You escaped from his grasp, visibly aroused by the ordeal.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you retreated in an almost whimsical way, your opponent got you cornered and lunged at you, groping all your naughty parts with passion. You escaped from his grasp, visibly aroused by the ordeal.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You try to lure him to chase you, as you playfully moved away from him, but tripped. Your opponent got the change to rub itself against your body for a second, as you wriggled yourself free and retreated to a safe position.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You try to lure him to chase you, as you playfully moved away from him, but tripped. Your opponent got the change to rub itself against your body for a second, as you wriggled yourself free and retreated to a safe position.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}

	// // /// <summary>
	///  200 - 0, 15, 0, 5, 1, "Perfume", "You use a perfume to charm your opponent. Low lust damage, high critical. Cost: 5 Lust. ", 0.25f, 0.8f
	/// </summary>

	public void Lust200(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (0, 0);
		lustRand = Random.Range (12, 17);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0.1f, 0.4f); // random
		multiplier5 = Random.Range(0.5f, 0.8f);
		failDmgRand = Random.Range (4, 9);
		failLustRand = Random.Range (0, 0); 
		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 75)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1 - WorldControl.enemyLustDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "It seemed that the perfume hit your opponent when it was taking a deep breath, filling its lungs with your appealing scent and perfume. You could see it getting even more aroused than you expected.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "It seemed that the perfume hit your opponent when it was taking a deep breath, filling its lungs with your appealing scent and perfume. You could see it getting even more aroused than you expected.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "The perfume imbued your opponent’s face and overwhelmed its senses for a second, as you smelled a bit of arousal coming from it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "The perfume imbued your opponent’s face and overwhelmed its senses for a second, as you smelled a bit of arousal coming from it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 20)
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1 -  WorldControl.enemyLustDefense;
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "The perfume got into your opponent’s body, impregnating a bit in it, getting its head a bit lighter.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "The perfume got into your opponent’s body, impregnating a bit in it, getting its head a bit lighter.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "The perfume hit your opponent’s face. It made him a bit more aroused than before, as it brought its attention to you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "The perfume hit your opponent’s face. It made him a bit more aroused than before, as it brought its attention to you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "The perfume dispersed before getting to your target.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "The perfume dispersed before getting to your target.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "The perfume flew too far from your opponent.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "The perfume flew too far from your opponent.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As the perfume flew over towards your opponent, you coughed and had to breath, taking the perfume for yourself, turning you on a little.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As the perfume flew over towards your opponent, you coughed and had to breath, taking the perfume for yourself, turning you on a little.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You try to blow your perfume over your opponent’s face, but it floated back and got on your own face, making you feel a bit dizzy and relaxed.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You try to blow your perfume over your opponent’s face, but it floated back and got on your own face, making you feel a bit dizzy and relaxed.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}


	// // /// <summary>
	///  210 - 5, 25, 10, 5, 1, "Veil dance", "Moderate lust attack and high critical but with low accuracy. Cost: 5 Will, 5 Lust.", 0.2f, 0.7f 
	/// </summary>

	public void Lust210(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (4, 7);
		lustRand = Random.Range (14, 20);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0.1f, 0.4f); // random
		multiplier5 = Random.Range(0.8f, 1.2f);
		failDmgRand = Random.Range (6, 11);
		failLustRand = Random.Range (3, 7); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 5; 
		GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 80)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1 - WorldControl.enemyLustDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As your gaze meet your enemy’s, you knew that it was seduced by the sexyness of your moves. It danced slowly with you as you touched it as much as you wanted, feeling its naughty bits until you got tired, rubbing a hand on its cheek as you moved back.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As your gaze meet your enemy’s, you knew that it was seduced by the sexyness of your moves. It danced slowly with you as you touched it as much as you wanted, feeling its naughty bits until you got tired, rubbing a hand on its cheek as you moved back.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "Your exotic dance got your opponent almost in a lustful trance, following your whims on the movements, as you teased every part of its body that you could get a hand on, leaving him wanting more as you walked away from it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "Your exotic dance got your opponent almost in a lustful trance, following your whims on the movements, as you teased every part of its body that you could get a hand on, leaving him wanting more as you walked away from it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 30)
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1 -  WorldControl.enemyLustDefense;
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "The veil dance is succesful in getting its attention. It follows your movements as you barely rub its body, feeling its getting warmer, until you pull away from it.\n\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "The veil dance is succesful in getting its attention. It follows your movements as you barely rub its body, feeling its getting warmer, until you pull away from it.\n\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "Your veil dance lures your opponent’s attention, taking steps as you guide it through the erotic dance, you felt how its arousal starts to rise.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "Your veil dance lures your opponent’s attention, taking steps as you guide it through the erotic dance, you felt how its arousal starts to rise.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "As you try to dance, your opponent snapped of it and pushed you back.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "As you try to dance, your opponent snapped of it and pushed you back.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "Your dance failed to turn on your opponent enough.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "Your dance failed to turn on your opponent enough.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As your charms started working on your opponent, you lost your concentration as your lust betrayed you. Your enemy took the advantage and headbutt you to push you back from it.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As your charms started working on your opponent, you lost your concentration as your lust betrayed you. Your enemy took the advantage and headbutt you to push you back from it.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "As you try to entice your opponent with a teasing dance around it, it got out of your charms and hit you with its shoulder, pushing you back and hurting you.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "As you try to entice your opponent with a teasing dance around it, it got out of your charms and hit you with its shoulder, pushing you back and hurting you.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}



	// // /// <summary>
	///  220 -10, 30, 20, 35, 1, "Self spanking", "Strong and reliable but expensive lust attack. Cost: 15 will, 5 lust ", 0.15f, 0.9f 
	/// </summary>

	public void Lust220(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (8, 12);
		lustRand = Random.Range (28, 32);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0.1f, 0.4f); // random
		multiplier5 = Random.Range(0.1f, 0.4f);
		failDmgRand = Random.Range (4, 8);
		failLustRand = Random.Range (4, 8); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 15; 
		GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 85)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1 - WorldControl.enemyLustDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you butt-flesh started to jiggle, your opponent’s body trembled as it gulped, surely more aroused than you thought it would be by it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you butt-flesh started to jiggle, your opponent’s body trembled as it gulped, surely more aroused than you thought it would be by it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "When you self-spanked, your opponent felt the compulsion of doing it itself, notably more aroused than you expected, but you moved out of the way in time.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "When you self-spanked, your opponent felt the compulsion of doing it itself, notably more aroused than you expected, but you moved out of the way in time.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 10)
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1 -  WorldControl.enemyLustDefense;
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As it heard the loud spank, your opponent couldn’t help but feel more horny than before.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As it heard the loud spank, your opponent couldn’t help but feel more horny than before.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You saw you opponent getting aroused by the minute, when it saw your ass flesh moving after you hit it. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You saw you opponent getting aroused by the minute, when it saw your ass flesh moving after you hit it. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "As you spanked yourself, you see that you opponent is unimpressed by it.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "As you spanked yourself, you see that you opponent is unimpressed by it.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "Your butt-slaping failed to incite your opponent’s passions.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "Your butt-slaping failed to incite your opponent’s passions.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you slapped your own ass, you took too much momentum and it truly hurted.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you slapped your own ass, you took too much momentum and it truly hurted.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You spank you too hard at the point that you felt true pain, leaving you a bit sore and a bit excited.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You spank you too hard at the point that you felt true pain, leaving you a bit sore and a bit excited.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}

	// // /// <summary>
	///  230 - 0, 45, 0, 20, 1, "Fondling", "You touch yourself, exciting both you and the enemy. Cost: 20 lust.", 0.1f, 0.8f 
	/// </summary>

	public void Lust230(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (0, 0);
		lustRand = Random.Range (35, 46);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0f, 0.4f); // random
		multiplier5 = Random.Range(0.2f, 0.7f);
		failDmgRand = Random.Range (12, 16);
		failLustRand = Random.Range (5, 12); 
		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		GameControl.actualArousal = GameControl.actualArousal + 20;

		if (randNum > 90)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1 - WorldControl.enemyLustDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you fondled yourself, your opponent’s stance changed as it took a step closer to you in a lust-filled gaze, the scent of arousal getting from it into your nose.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you fondled yourself, your opponent’s stance changed as it took a step closer to you in a lust-filled gaze, the scent of arousal getting from it into your nose.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "As you gasped by your show, your opponent couldn’t help but fondle itself a bit, mimicking your movements and moaning a bit.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "As you gasped by your show, your opponent couldn’t help but fondle itself a bit, mimicking your movements and moaning a bit.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 20)
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1 -  WorldControl.enemyLustDefense;
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you rubbed and touched your body and naughty parts, your opponent panted a bit, visibly flustered by your exhibition.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you rubbed and touched your body and naughty parts, your opponent panted a bit, visibly flustered by your exhibition.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "As you pinched and rubbed your own body, you could see that your opponent couldn’t get its eyes off you by one second, as it got visible excited by the show.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "As you pinched and rubbed your own body, you could see that your opponent couldn’t get its eyes off you by one second, as it got visible excited by the show.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "Your fondling was somehow boring for your enemy.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "Your fondling was somehow boring for your enemy.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "Your own fondling wasn’t interesting for your opponent.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "Your own fondling wasn’t interesting for your opponent.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "With all that fondling, you felt so good that you lost track of why you were doing it, pleasuring yourself until you halted before you get any hornier.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "With all that fondling, you felt so good that you lost track of why you were doing it, pleasuring yourself until you halted before you get any hornier.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "As you fondled yourself, your lust betrayed you and you started playing with your own body for your own pleasure, rather than enticing your opponent, stopping when you realized what was happening.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "As you fondled yourself, your lust betrayed you and you started playing with your own body for your own pleasure, rather than enticing your opponent, stopping when you realized what was happening.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}

	// // /// <summary>
	///  300 - 0, 20, 10, 5, 1, "Flashy bits", "Normal and consistent lust damage. Cost: 5 will", 0.15f, 0.9f
	/// </summary>

	public void Lust300(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (0, 0);
		lustRand = Random.Range (18, 21);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0f, 0.3f); // random
		multiplier5 = Random.Range(0.2f, 0.4f);
		failDmgRand = Random.Range (6, 9);
		failLustRand = Random.Range (0, 0); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 5; 
		//GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 90)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1 - WorldControl.enemyLustDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);


			if (GameControl.charArmorTags [1] == true) 
			{
				switch (randNum) {
				case 0:
					WorldControl.charAttackDescription = "You pushed your naughty bits almost in front of him, exciting him more than you expected.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				case 1:
					WorldControl.charAttackDescription = "You pushed your naughty bits almost in front of him, exciting him more than you expected.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				case 2:
					WorldControl.charAttackDescription = "The way that you play with yourself seemed to be your opponent's favorite, as it increases its lust by a larger amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				default:
					WorldControl.charAttackDescription = "The way that you play with yourself seemed to be your opponent's favorite, as it increases its lust by a larger amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				}
			}else{

				switch(randNum)
				{

				case 0:
					WorldControl.charAttackDescription = "The lustful skin that you showed that your opponent seemed to be its favorite, as it increased its lust by a larger amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = "The lustful skin that you showed that your opponent seemed to be its favorite, as it increased its lust by a larger amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = "You pushed your flashed naughty skin almost in front of him, exciting him more than you expected.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = "You pushed your flashed naughty skin almost in front of him, exciting him more than you expected.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				}


			}//



		}
		else if (randNum > 10)
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1 -  WorldControl.enemyLustDefense;
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);

			if (GameControl.charArmorTags [1] == true) {
				switch (randNum) {
				case 0:
					WorldControl.charAttackDescription = "Your enemy didn’t expected for you to be so daring, touching yourself in front of him, so it got a bit aroused at the sudden show of naughty flesh.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				case 1:
					WorldControl.charAttackDescription = "Your enemy didn’t expected for you to be so daring, touching yourself in front of him, so it got a bit aroused at the sudden show of naughty flesh.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				case 2:
					WorldControl.charAttackDescription = "Your opponent was surprised to see how you rub your groin with your hands. It got flustered a bit.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				default:
					WorldControl.charAttackDescription = "Your opponent was surprised to see how you rub your groin with your hands. It got flustered a bit.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				}
			} else {


				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = "Your enemy didn’t expected for you to show some skin, so it got a bit aroused at the sudden show of naughty flesh.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = "Your enemy didn’t expected for you to show some skin, so it got a bit aroused at the sudden show of naughty flesh.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = "Your opponent was surprised to see that part of your body so suddenly. It got flustered a bit.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = "Your opponent was surprised to see that part of your body so suddenly. It got flustered a bit.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;


				}

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

			if (GameControl.charArmorTags [1] == true) {
				switch (randNum) {
				case 0:
					WorldControl.charAttackDescription = "Your exposed skin play isn’t working as intended this time.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				case 1:
					WorldControl.charAttackDescription = "Your exposed skin play isn’t working as intended this time.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				case 2:
					WorldControl.charAttackDescription = "Your play with your lewd bits failed to surprise your opponent.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				default:
					WorldControl.charAttackDescription = "Your play with your lewd bits failed to surprise your opponent.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				}
			} else {


				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = "Your bits flashed aren’t working as intended this time.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 

					WorldControl.charAttackDescription = "Your bits flashed aren’t working as intended this time.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

					break;
				case 2:

					WorldControl.charAttackDescription = "Your revealed skin failed to surprise your opponent.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

					break;
				default: 

					WorldControl.charAttackDescription = "Your revealed skin failed to surprise your opponent.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

					break;


				}
			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);


			if (GameControl.charArmorTags [1] == true) {
				switch (randNum) {
				case 0:
					WorldControl.charAttackDescription = "An specific way of rubbing yourself made your opponent more aggressive, hitting you back and pushing you away from it.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				case 1:
					WorldControl.charAttackDescription = "An specific way of rubbing yourself made your opponent more aggressive, hitting you back and pushing you away from it.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				case 2:
					WorldControl.charAttackDescription = "As you try to entice your enemy with an exposed part of your naughty bits, your opponent didn’t fall for it and hit you with one of its arms, forcing you back.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				default:
					WorldControl.charAttackDescription = "As you try to entice your enemy with an exposed part of your naughty bits, your opponent didn’t fall for it and hit you with one of its arms, forcing you back.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				}
			} else 
			{


				switch(randNum)
				{

			case 0:
				WorldControl.charAttackDescription = "An specific flashed part of your skin only made your opponent more aggresive, hitting you back and pushing you away from it.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "An specific flashed part of your skin only made your opponent more aggresive, hitting you back and pushing you away from it.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "As you try to flash a soft part of your skin, your opponent didn’t fall for it and hit you with one of its arms, forcing you back.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "As you try to flash a soft part of your skin, your opponent didn’t fall for it and hit you with one of its arms, forcing you back.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

				}//
			}
		}
	}


	// // /// <summary>
	///  310 - 5, 35, 10, 5, 1, "Striptease", "Very random lust damage that can have high critical damage. Cost: 10 will, 5 lust", 0.1f, 0.8f 
	/// </summary>

	public void Lust310(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (4, 6);
		lustRand = Random.Range (22, 27);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0f, 0.4f); // random
		multiplier5 = Random.Range(0.6f, 1.3f);
		failDmgRand = Random.Range (8, 16);
		failLustRand = Random.Range (0, 0); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 15; 
		GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 90)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1 - WorldControl.enemyLustDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			if (GameControl.charArmorTags [1] == true) {
				switch (randNum) {
				case 0:
					WorldControl.charAttackDescription = "Your opponent seemed interested in one of the parts of your exposed skin that you moved with your teasing dance, its will to fuck increasing substantially.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				case 1:
					WorldControl.charAttackDescription = "Your opponent seemed interested in one of the parts of your exposed skin that you moved with your teasing dance, its will to fuck increasing substantially.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				case 2:
					WorldControl.charAttackDescription = "You feel inspired at that moment, as your bared dance is hotter than usual, your lewd moves waking up the libido of your opponent, increasing its will to fuck by a large amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				default:
					WorldControl.charAttackDescription = "You feel inspired at that moment, as your bared dance is hotter than usual, your lewd moves waking up the libido of your opponent, increasing its will to fuck by a large amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				}
			} else{

			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "Your opponent seemed interested in one of the pieces of clothing that you started to strip, its will to fuck increasing substantially.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "Your opponent seemed interested in one of the pieces of clothing that you started to strip, its will to fuck increasing substantially.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You felt inspired that moment, as your striptease was hotter than usual, your moves wake up the libido of your opponent, increasing its will to fuck by a large amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You felt inspired that moment, as your striptease was hotter than usual, your moves wake up the libido of your opponent, increasing its will to fuck by a large amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}//
			}
		}
		else if (randNum > 20)
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1 -  WorldControl.enemyLustDefense;
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			if (GameControl.charArmorTags [1] == true) {
				switch (randNum) {
				case 0:
					WorldControl.charAttackDescription = "You ran a hand over an exposed part of your armor, and started playing with it as you moved from one to another, getting your opponent turned on by the exhibition.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				case 1:
					WorldControl.charAttackDescription = "You ran a hand over an exposed part of your armor, and started playing with it as you moved from one to another, getting your opponent turned on by the exhibition.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				case 2:
					WorldControl.charAttackDescription = "You began dancing in a sensual way, accentuating the exposed parts of your armor. Your opponent is getting more aroused by the show.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				default:
					WorldControl.charAttackDescription = "You began dancing in a sensual way, accentuating the exposed parts of your armor. Your opponent is getting more aroused by the show.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				}
			} else {

				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = "You ran a hand over a piece of your clothing, and started playing with it as you started removing it, making your opponent getting turned on by the exhibition.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = "You ran a hand over a piece of your clothing, and started playing with it as you started removing it, making your opponent getting turned on by the exhibition.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = "You started stripteasing in a sensual way, slowly removing one of your clothing. Your opponent was getting more aroused by the show.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = "You started stripteasing in a sensual way, slowly removing one of your clothing. Your opponent was getting more aroused by the show.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;


				}
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
			if (GameControl.charArmorTags [1] == true) {
				switch (randNum) {
				case 0:
					WorldControl.charAttackDescription = "Even when you were playing with your naked body, you aren’t getting your enemy’s attention.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				case 1:
					WorldControl.charAttackDescription = "Even when you were playing with your naked body, you aren’t getting your enemy’s attention.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				case 2:
					WorldControl.charAttackDescription = "Your lustful tease of your exposed skin wasn’t appealing enough for your opponent.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				default:
					WorldControl.charAttackDescription = "Your lustful tease of your exposed skin wasn’t appealing enough for your opponent.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				}
			} else {

				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = "Your striptease wasn’t getting your enemy’s attention.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 

					WorldControl.charAttackDescription = "Your striptease wasn’t getting your enemy’s attention.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

					break;
				case 2:

					WorldControl.charAttackDescription = "Your striptease wasn’t appealing enough for your opponent.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

					break;
				default: 

					WorldControl.charAttackDescription = "Your striptease wasn’t appealing enough for your opponent.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

					break;


				}
			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			if (GameControl.charArmorTags [1] == true) {
				switch (randNum) {
				case 0:
					WorldControl.charAttackDescription = "As you were dancing with you naughty bits on the air, some of your armor got in the way and make you fall into a compromising position in front of your enemy, which didn’t lost time in touching you as you rise from the floor and return to your original position.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				case 1:
					WorldControl.charAttackDescription = "As you were dancing with you naughty bits on the air, some of your armor got in the way and make you fall into a compromising position in front of your enemy, which didn’t lost time in touching you as you rise from the floor and return to your original position.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				case 2:
					WorldControl.charAttackDescription = "You try to make an alluring dance with your exposed bits to your opponent, but a part of your armor got stuck, which made you fall over your opponent, which didn’t lost time in groping you until you returned.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				default:
					WorldControl.charAttackDescription = "You try to make an alluring dance with your exposed bits to your opponent, but a part of your armor got stuck, which made you fall over your opponent, which didn’t lost time in groping you until you returned.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				}
			} else {
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = "As you were stripteasing, some of your clothing malfunctioned and make you fall into a compromising position in front of your enemy, which didn’t lost time in touching you as you recovered and returned to your original position.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = "As you were stripteasing, some of your clothing malfunctioned and make you fall into a compromising position in front of your enemy, which didn’t lost time in touching you as you recovered and returned to your original position.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = "You try to make a good striptease to your opponent, but clothing got stuck and it made you fall into your opponent, which didn’t lost time in groping you until you escaped back..\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = "You try to make a good striptease to your opponent, but clothing got stuck and it made you fall into your opponent, which didn’t lost time in groping you until you escaped back..\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
					break;

				}
			}
		}
	}

	// // /// <summary>
	///  320 - 0, 40, 20, 35, 1, "Crotch strip", "High lust damage but pretty expensive. 15 will, 10 lust", 0.1f, 0.85f 
	/// </summary>

	public void Lust320(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (0, 0);
		lustRand = Random.Range (32, 40);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0f, 0.4f); // random
		multiplier5 = Random.Range(0.1f, 0.4f);
		failDmgRand = Random.Range (6, 12);
		failLustRand = Random.Range (4, 8); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 15; 
		GameControl.actualArousal = GameControl.actualArousal + 10;

		if (randNum > 95)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1 - WorldControl.enemyLustDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);

			if (GameControl.charArmorTags [1] == true) {
				switch (randNum) {
				case 0:
					WorldControl.charAttackDescription = "You have the chance to rub your groin to your opponent close to him, getting him to get your sex juices smell on their face, filling them with more will to fuck than usual.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				case 1:
					WorldControl.charAttackDescription = "You have the chance to rub your groin to your opponent close to him, getting him to get your sex juices smell on their face, filling them with more will to fuck than usual.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				case 2:
					WorldControl.charAttackDescription = "As you rub your groin, you move closer to your opponent, giving them a good look at it. They couldn’t keep their eyes off it for a moment, their will to fuck rising by a lot.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				default:
					WorldControl.charAttackDescription = "As you rub your groin, you move closer to your opponent, giving them a good look at it. They couldn’t keep their eyes off it for a moment, their will to fuck rising by a lot.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				}
			} else {
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = "As you flashed your groin, you moved closer to your opponent, giving them a good look at it. They couldn’t keep their eyes off it for a moment, their will to fuck rising by a lot.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = "As you flashed your groin, you moved closer to your opponent, giving them a good look at it. They couldn’t keep their eyes off it for a moment, their will to fuck rising by a lot.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = "You had the chance to flash your groin to your opponent close to him, getting him to get its smell to their faces, filling them with more will to fuck than usual.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = "You had the chance to flash your groin to your opponent close to him, getting him to get its smell to their faces, filling them with more will to fuck than usual.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;


				}
			}
		}
		else if (randNum > 15)
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1 -  WorldControl.enemyLustDefense;
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);

			if (GameControl.charArmorTags [1] == true) {
				switch (randNum) {
				case 0:
					WorldControl.charAttackDescription = "You rub your genitals at your enemy, and it couldn’t get its eyes off it for a bit, increasing its will to fuck by a good amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				case 1:
					WorldControl.charAttackDescription = "You rub your genitals at your enemy, and it couldn’t get its eyes off it for a bit, increasing its will to fuck by a good amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				case 2:
					WorldControl.charAttackDescription = "You rub your crotch in front of your opponent, as it increased its will to fuck as it can’t look away..\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				default:
					WorldControl.charAttackDescription = "You rub your crotch in front of your opponent, as it increased its will to fuck as it can’t look away..\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				}
			} else {
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = "You flashed your genitals at your enemy, and it couldn’t get its eyes off it for a bit, increasing its will to fuck by a good amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = "You flashed your genitals at your enemy, and it couldn’t get its eyes off it for a bit, increasing its will to fuck by a good amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = "Your opponent wasn’t paying attention to your crotch at that second.\n\tHit: You flashed your crotch to your opponent, as it increased its will to fuck to see it so suddenly.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = "Your opponent wasn’t paying attention to your crotch at that second.\n\tHit: You flashed your crotch to your opponent, as it increased its will to fuck to see it so suddenly.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;


				}
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
			if (GameControl.charArmorTags [1] == true) {
				switch (randNum) {
				case 0:
					WorldControl.charAttackDescription = "Your opponent wasn’t paying attention to your exposed genital patch of your armor as you rubbed it.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				case 1:
					WorldControl.charAttackDescription = "Your opponent wasn’t paying attention to your exposed genital patch of your armor as you rubbed it.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				case 2:
					WorldControl.charAttackDescription = "Your groin rubbing isn’t appealing to your opponent.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				default:
					WorldControl.charAttackDescription = "Your groin rubbing isn’t appealing to your opponent.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				}
			} else{
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "Your opponent wasn’t paying attention to your crotch at that second.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "Your opponent wasn’t paying attention to your crotch at that second.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You were too slow to do a good flash of your crotch to your opponent.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You were too slow to do a good flash of your crotch to your opponent.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


				} 
			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			if (GameControl.charArmorTags [1] == true) {
				switch (randNum) {
				case 0:
					WorldControl.charAttackDescription = "As you rubbed your genitals with your hand, one of your hands presses too hard, cutting your action short and stopping you for a second.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				case 1:
					WorldControl.charAttackDescription = "As you rubbed your genitals with your hand, one of your hands presses too hard, cutting your action short and stopping you for a second.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				case 2:
					WorldControl.charAttackDescription = "As you try to rub your groin, you tripped and fell into the ground. That really made you feel ashamed in front of your enemy.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				default:
					WorldControl.charAttackDescription = "As you try to rub your groin, you tripped and fell into the ground. That really made you feel ashamed in front of your enemy.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				}
			} else {
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = "As you stripped your lower garment, you painfully pulled part of the \nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = "As you stripped your lower garment, you painfully pulled part of the \nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = "As you try to strip your lower clothing, you failed to keep your balance and fell into the ground, half naked. That really let you ashamed in front of your enemy.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = "As you try to strip your lower clothing, you failed to keep your balance and fell into the ground, half naked. That really let you ashamed in front of your enemy.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
					break;

				}
			}
		}
	}


	// // /// <summary>
	///  330 - 5, 60, 15, 15, 1, "Full moon", "Exceptional critical damage, but low accuracy. Very risky. Cost: 15 will, 15 lust ", 0.2f, 0.65f 
	/// </summary>

	public void Lust330(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (0, 0);
		lustRand = Random.Range (32, 37);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0f, 0.4f); // random
		multiplier5 = Random.Range(0.6f, 1.2f);
		failDmgRand = Random.Range (8, 15);
		failLustRand = Random.Range (8, 15); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 15; 
		GameControl.actualArousal = GameControl.actualArousal + 15;

		if (randNum > 80) {

			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1 - WorldControl.enemyLustDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			if (GameControl.charArmorTags [1] == true) {
				switch (randNum) {
				case 0:
					WorldControl.charAttackDescription = "You play with your whole body next to your opponent, letting your scent from your groin and warmth of your body get to your opponent’s face and fill him with the will to fuck by a huge amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				case 1:
					WorldControl.charAttackDescription = "You play with your whole body next to your opponent, letting your scent from your groin and warmth of your body get to your opponent’s face and fill him with the will to fuck by a huge amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				case 2:
					WorldControl.charAttackDescription = "You rub your whole body almost in your opponent’s reach. It tries to get a hold of you, but you dodged in time but you touch him with your body for only a second, letting it feel you for a moment, increasing its will to fuck by a huge amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				default:
					WorldControl.charAttackDescription = "You rub your whole body almost in your opponent’s reach. It tries to get a hold of you, but you dodged in time but you touch him with your body for only a second, letting it feel you for a moment, increasing its will to fuck by a huge amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				}
			} else {
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = "You got naked in one second next to your enemy, letting your scent from your groin get to your opponent’s face and fill him with the will to fuck by a huge amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = "You got naked in one second next to your enemy, letting your scent from your groin get to your opponent’s face and fill him with the will to fuck by a huge amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = "You flashed your whole body almost in your opponent’s reach. It try to get a hold of you, but you dodged in time and dressed in a second, letting it feel your body for a moment, increasing its will to fuck by a huge amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = "You flashed your whole body almost in your opponent’s reach. It try to get a hold of you, but you dodged in time and dressed in a second, letting it feel your body for a moment, increasing its will to fuck by a huge amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;


				}
			}
		} else if (randNum > 40) {
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1 - WorldControl.enemyLustDefense;
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			if (GameControl.charArmorTags [1] == true) {
				switch (randNum) {
				case 0:
					WorldControl.charAttackDescription = "As you rub all of your lewd bits, covered or not as your opponent gets excited by a large amount of will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				case 1:
					WorldControl.charAttackDescription = "As you rub all of your lewd bits, covered or not as your opponent gets excited by a large amount of will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				case 2:
					WorldControl.charAttackDescription = "Your opponent got entranced by your body rub on all your lewd parts, its body betraying it with the smell of its sexual fluids filling the air.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				default:
					WorldControl.charAttackDescription = "Your opponent got entranced by your body rub on all your lewd parts, its body betraying it with the smell of its sexual fluids filling the air.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!";
					break;
				}
			} else
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = "When you got completely naked, your opponent got excited by a large amount of will to fuck, but you got out of the way in time to avoid it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = "When you got completely naked, your opponent got excited by a large amount of will to fuck, but you got out of the way in time to avoid it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = "Your opponent got entranced by your sudden nakedness, its body betraying it with the smell of sexual fluids filling the air.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = "Your opponent got entranced by your sudden nakedness, its body betraying it with the smell of sexual fluids filling the air.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
					break;


				}
		} else if (randNum > 5) {
			multiplierTotal = multiplier1 + multiplier2 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;

			randNum = Random.Range (0, 3);
			if (GameControl.charArmorTags [1] == true) {
				switch (randNum) {
				case 0:
					WorldControl.charAttackDescription = "Your opponent thought that you would attack it and covered its head.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				case 1:
					WorldControl.charAttackDescription = "Your opponent thought that you would attack it and covered its head.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				case 2:
					WorldControl.charAttackDescription = "Your full body rub wasn’t that impacting to your opponent at that time.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				default:
					WorldControl.charAttackDescription = "Your full body rub wasn’t that impacting to your opponent at that time.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				}
			} else {
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = "Your opponent thought that you would attack it and covered its head.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 

					WorldControl.charAttackDescription = "Your opponent thought that you would attack it and covered its head.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

					break;
				case 2:

					WorldControl.charAttackDescription = "Your full strip wasn’t as impactating to your opponent at that time.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

					break;
				default: 

					WorldControl.charAttackDescription = "Your full strip wasn’t as impactating to your opponent at that time.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

					break;


				}
			} 

		} else {
			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			if (GameControl.charArmorTags [1] == true) {
				switch (randNum) {
				case 0:
					WorldControl.charAttackDescription = "As you got tease your whole body to your opponent, one of your hands got stuck into the armor and failed completely the objective to entice it.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				case 1:
					WorldControl.charAttackDescription = "As you got tease your whole body to your opponent, one of your hands got stuck into the armor and failed completely the objective to entice it.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				case 2:
					WorldControl.charAttackDescription = "You tease your whole body to your opponent, but got caught in the armor and fall into the ground with it, as you are feeling aroused by half the move.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				default:
					WorldControl.charAttackDescription = "You tease your whole body to your opponent, but got caught in the armor and fall into the ground with it, as you are feeling aroused by half the move.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!";
					break;
				}
			} else {


				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = "As you got naked in a movement, the clothing flew into your face and pushed you back a bit, covering partially your body to your opponent and failing to flash it.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = "As you got naked in a movement, the clothing flew into your face and pushed you back a bit, covering partially your body to your opponent and failing to flash it.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = "You try to full strip in a movement, but got caught in the clothing and got into the ground with it, only you getting aroused by half the move.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = "You try to full strip in a movement, but got caught in the clothing and got into the ground with it, only you getting aroused by half the move.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
					break;

				}
			}
		}
	}



	// // /// <summary>
	///  400 - 20, 0, 5, 0, 1, "Staredown", "Normal will damage, with good critical damage. Cost: 5 will", 0.05f, 0.85f 
	/// </summary>

	public void Lust400(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (16, 20);
		lustRand = Random.Range (0, 0);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0.1f, 0.5f); // random
		multiplier5 = Random.Range(0.3f, 0.8f);
		failDmgRand = Random.Range (4, 8);
		failLustRand = Random.Range (0, 0); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 5; 
		//GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 95)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1 - WorldControl.enemyLustDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "Your gaze made your opponent tremble for a second, it's mind filled with thought of submission.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "Your gaze made your opponent tremble for a second, it's mind filled with thought of submission.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "Your eyes chilled the spirit of your opponent, filling its mind with the thought that it was futile to resist you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "Your eyes chilled the spirit of your opponent, filling its mind with the thought that it was futile to resist you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 20)
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1 -  WorldControl.enemyLustDefense;
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "Your enemy looked into your dominant eyes, and started feeling drained from its will to fight you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "Your enemy looked into your dominant eyes, and started feeling drained from its will to fight you.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You look into the eyes of your enemy, as it feels intimidated by it, his will to fight slowly seeping from it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You look into the eyes of your enemy, as it feels intimidated by it, his will to fight slowly seeping from it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "Your gaze wasn’t enough to debilitate your opponent this time.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "Your gaze wasn’t enough to debilitate your opponent this time.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "Your opponent looks away just in time to avoid your gaze.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "Your opponent looks away just in time to avoid your gaze.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you keep your gaze over you enemy’s eyes, you felt somehow less potente than usual, and your enemy takes the advantage and stares at you, as you felt with less will to fight.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you keep your gaze over you enemy’s eyes, you felt somehow less potente than usual, and your enemy takes the advantage and stares at you, as you felt with less will to fight.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You lock your gaze with your opponent, but you feel its gaze stronger than yours, feeling a bit demoralized by it.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You lock your gaze with your opponent, but you feel its gaze stronger than yours, feeling a bit demoralized by it.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}

	// // /// <summary>
	///  410 - 30, 5, 20, 35, 1, "Humilation", "Good will damage, but can backfire hard. Cost: 15 will", 0.1f, 0.8f 
	/// </summary>

	public void Lust410(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (22, 26);
		lustRand = Random.Range (3, 6);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0.1f, 0.5f); // random
		multiplier5 = Random.Range(0.1f, 0.4f);
		failDmgRand = Random.Range (10, 18);
		failLustRand = Random.Range (0, 0); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 15; 
		//GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 90)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1 - WorldControl.enemyLustDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "Your cutting words pummel your enemy’s spirit like a hammer, shaming them by a lot. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "Your cutting words pummel your enemy’s spirit like a hammer, shaming them by a lot. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "As you ashamed your enemy, something you said sting hard into your enemy, as it makes it take a step back and cover its face, utterly humiliated.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "As you ashamed your enemy, something you said sting hard into your enemy, as it makes it take a step back and cover its face, utterly humiliated.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 20)
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1 -  WorldControl.enemyLustDefense;
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "Your strong words hit your enemy hard, making them feel embarassed, lowering their will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "Your strong words hit your enemy hard, making them feel embarassed, lowering their will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "Your words strike shame in the heart of your enemy, lowering their will to fight. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "Your words strike shame in the heart of your enemy, lowering their will to fight. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You try to humiliate your opponent, but your words weren’t enough to cause an effect in your enemy.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "You try to humiliate your opponent, but your words weren’t enough to cause an effect in your enemy.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You try to disgrace your opponent, but fall into deaf ears.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You try to disgrace your opponent, but fall into deaf ears.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You try to be humiliating to your enemy, but ended up shaming yourself by mistake.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You try to be humiliating to your enemy, but ended up shaming yourself by mistake.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You try to say things to humiliate your opponent, but you slipped your tongue and said something embarassing about you.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You try to say things to humiliate your opponent, but you slipped your tongue and said something embarassing about you.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}

	// // /// <summary>
	///  420 - 20, 25, 10, 10, 1, "Showoff", "Decent will and lust damage, cost: 10 will, 10 lust. ", 0.1f, 0.8f
	/// </summary>

	public void Lust420(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (14, 18);
		lustRand = Random.Range (18, 22);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0.1f, 0.6f); // random
		multiplier5 = Random.Range(0.1f, 0.4f);
		failDmgRand = Random.Range (8, 12);
		failLustRand = Random.Range (0, 0); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 10; 
		GameControl.actualArousal = GameControl.actualArousal + 10;

		if (randNum > 90)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1 - WorldControl.enemyLustDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "Your imposition over your opponent by your muscle display, strikes meekness in your enemy, lowering its will to fight by a large amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "Your imposition over your opponent by your muscle display, strikes meekness in your enemy, lowering its will to fight by a large amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "Your supreme muscular showoff was too much to bear to your opponent, who covered itself in shame, lowering its will to fight by a large amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "Your supreme muscular showoff was too much to bear to your opponent, who covered itself in shame, lowering its will to fight by a large amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 20)
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1 -  WorldControl.enemyLustDefense;
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "Your display of dominance with your body made your opponent cower in submission for a second, lowering its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "Your display of dominance with your body made your opponent cower in submission for a second, lowering its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You show your enemy your muscles and tighten them up, your opponent feeling overpowered by your superiority, losing will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You show your enemy your muscles and tighten them up, your opponent feeling overpowered by your superiority, losing will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "Your muscles weren’t enough to impose yourself over your enemy, for the moment.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "Your muscles weren’t enough to impose yourself over your enemy, for the moment.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You try to dominate your opponent with your showoff, but it wasn’t effective this time.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You try to dominate your opponent with your showoff, but it wasn’t effective this time.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You try to show off your body strength, but you pull one of your muscles, damaging it a bit and forcing you back into position.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You try to show off your body strength, but you pull one of your muscles, damaging it a bit and forcing you back into position.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You try to impose your dominance by showing off your muscles, but as you do it, you stretch one of your muscles too much, causing you pain.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You try to impose your dominance by showing off your muscles, but as you do it, you stretch one of your muscles too much, causing you pain.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}

	// // /// <summary>
	///  430 - 50, 5, 0, 30, 1, "Command", "Very strong will damage, but somewhat low accuracy. Risky. Cost 20 will, 10 lust. ", 0.2f, 0.75f
	/// </summary>

	public void Lust430(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (3, 6);
		lustRand = Random.Range (36, 42);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0f, 0.4f); // random
		multiplier5 = Random.Range(0.1f, 0.6f);
		failDmgRand = Random.Range (10, 14);
		failLustRand = Random.Range (0, 0); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 20; 
		GameControl.actualArousal = GameControl.actualArousal + 10;

		if (randNum > 85)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1 - WorldControl.enemyLustDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You saw your opponent with low resistance, so you commanded it to fondle its genitals. Your enemy complied and started moaning as it touched itself, it's fluids filling the floor below it.\n\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You saw your opponent with low resistance, so you commanded it to fondle its genitals. Your enemy complied and started moaning as it touched itself, it's fluids filling the floor below it.\n\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You saw your opponent weak, so you commanded it to kiss your feet. Your enemy couldn't resist and kissed it slowly, losing its desire to keep fighting.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You saw your opponent weak, so you commanded it to kiss your feet. Your enemy couldn't resist and kissed it slowly, losing its desire to keep fighting.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 25)
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1 -  WorldControl.enemyLustDefense;
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You commanded your enemy to submit already, imposing your dominant voice over it. Your opponent felt the sudden urge to surrender, lowering its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You commanded your enemy to submit already, imposing your dominant voice over it. Your opponent felt the sudden urge to surrender, lowering its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You commanded your opponent to touch itself. The enemy try to resist, but your aura was too strong, as they started to touch itself, feeling futile and aroused.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You commanded your opponent to touch itself. The enemy try to resist, but your aura was too strong, as they started to touch itself, feeling futile and aroused.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "Your command was resisted by your opponent, at least this time.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "Your command was resisted by your opponent, at least this time.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "Your command got lost in the heat of the fight.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "Your command got lost in the heat of the fight.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You gave a command to your opponent, but it refused your authority with such force, that you felt futile for a second.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You gave a command to your opponent, but it refused your authority with such force, that you felt futile for a second.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You try to command your opponent, but it's defiance is supreme, filling you with doubts.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You try to command your opponent, but it's defiance is supreme, filling you with doubts.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}


	// // /// <summary>
	///  500 - 0, 25, 0, 5, 1, "Teasing lick", "decent lust damage with low accuracy. Cost: 5 lust. ", 0.1f, 0.75f
	/// </summary>

	public void Lust500(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (0, 0);
		lustRand = Random.Range (17, 23);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0.1f, 0.6f); // random
		multiplier5 = Random.Range(0.1f, 0.4f);
		failDmgRand = Random.Range (4, 8);
		failLustRand = Random.Range (0, 0); 
		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 90)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1 - WorldControl.enemyLustDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You darted your tongue with expertise through your opponent's body, making it gasp and raising its will to fuck by a large amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You darted your tongue with expertise through your opponent's body, making it gasp and raising its will to fuck by a large amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You ran your tongue through your opponent ear, making it blush a bit and raising its will to fuck by a large amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You ran your tongue through your opponent ear, making it blush a bit and raising its will to fuck by a large amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 25)
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1 -  WorldControl.enemyLustDefense;
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You ran your tongue on tender parts of your opponent’s body, increasing its will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You ran your tongue on tender parts of your opponent’s body, increasing its will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You teased your opponent with your tongue on different parts of its body, raising its will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You teased your opponent with your tongue on different parts of its body, raising its will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You licked your enemy teasingly, but it wasn't enough to turn it on.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "You licked your enemy teasingly, but it wasn't enough to turn it on.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You try to lick your opponent, but it got away before you could.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You try to lick your opponent, but it got away before you could.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "Your tongue teased your enemy, but licked a part sensitive to your opponent, who jerked with a punch against you, pushing you away.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "Your tongue teased your enemy, but licked a part sensitive to your opponent, who jerked with a punch against you, pushing you away.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "As you try to lick your opponent, your enemy resisted its urges and kicked you away.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "As you try to lick your opponent, your enemy resisted its urges and kicked you away.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}


	// // /// <summary>
	///  510 - 5, 30, 5, 10, 1, "Crotch grab", "Great lust damage and great critical, but may backfire if misses. Cost: 5 will, 10 lust", 0.1f, 0.8f
	/// </summary>

	public void Lust510(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (4, 7);
		lustRand = Random.Range (20, 25);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0.1f, 0.4f); // random
		multiplier5 = Random.Range(0.3f, 0.7f);
		failDmgRand = Random.Range (12, 16);
		failLustRand = Random.Range (0, 0); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 5; 
		GameControl.actualArousal = GameControl.actualArousal + 10;

		if (randNum > 85)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1 - WorldControl.enemyLustDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You held your opponent in place with one arm, and with the other you fondled its genitals as you pressed your body against it, increasing its will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You held your opponent in place with one arm, and with the other you fondled its genitals as you pressed your body against it, increasing its will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You held your opponent against the floor, as you were over it, rubbing its genitals with your hands, as you looked at its eyes with a sexy gaze, increasing its lust by a large amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You held your opponent against the floor, as you were over it, rubbing its genitals with your hands, as you looked at its eyes with a sexy gaze, increasing its lust by a large amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 20)
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1 -  WorldControl.enemyLustDefense;
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You got closer to your opponent and started rubbing its crotch with one of your legs, turning him on by a good amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You got closer to your opponent and started rubbing its crotch with one of your legs, turning him on by a good amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You grabbed your opponent by the crotch, rubbing it seductively with your hand, raising its will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You grabbed your opponent by the crotch, rubbing it seductively with your hand, raising its will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You try to get to your enemy’s crotch but failed your target.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "You try to get to your enemy’s crotch but failed your target.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You reached for your enemy’s groin, but it was faster than you.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You reached for your enemy’s groin, but it was faster than you.s\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You almost get a hold of your opponent’s crotch, but your opponent saw you off-guard and kicked you in your belly, pushing you back into position.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You almost get a hold of your opponent’s crotch, but your opponent saw you off-guard and kicked you in your belly, pushing you back into position.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "As you try to get a grab of its crotch, you failed as your opponent hit you in your face with its head, forcing you back.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "As you try to get a grab of its crotch, you failed as your opponent hit you in your face with its head, forcing you back.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}

	// // /// <summary>
	///  520 - 15, 30, 10, 15, 1, "Boddy rubbing", "Good consistent lust damage, low critical chance. Cost: 5 will, 15 lust. ", 0.05f, 0.85f 
	/// </summary>

	public void Lust520(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (9, 14);
		lustRand = Random.Range (20, 25);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0.2f, 0.5f); // random
		multiplier5 = Random.Range(0.2f, 0.5f);
		failDmgRand = Random.Range (10, 14);
		failLustRand = Random.Range (0, 0); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 5; 
		GameControl.actualArousal = GameControl.actualArousal + 15;

		if (randNum > 95)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1 - WorldControl.enemyLustDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You pushed your back against your enemy, rubbing your ass against it as your hands ran teasingly through its body, as you could feel the scent of sexual fluids filling the air.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You pushed your back against your enemy, rubbing your ass against it as your hands ran teasingly through its body, as you could feel the scent of sexual fluids filling the air.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You held your opponent from behind, as you rubbed your body against it and your hands ran across its physique, turning him on by a large amount\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You held your opponent from behind, as you rubbed your body against it and your hands ran across its physique, turning him on by a large amount\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 15)
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1 -  WorldControl.enemyLustDefense;
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You held your opponent with both arms, as you rubbed your body against it as you used every part available of your body to tease it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You held your opponent with both arms, as you rubbed your body against it as you used every part available of your body to tease it.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You trapped your opponent with your body, rubbing it with your own in a lascivious way, increasing its lust.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You trapped your opponent with your body, rubbing it with your own in a lascivious way, increasing its lust.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You try to rub yourself against your enemy, but he moved away faster than you.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "You try to rub yourself against your enemy, but he moved away faster than you.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "Your rubbing wasn’t energetic enough for your enemy.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "Your rubbing wasn’t energetic enough for your enemy.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you rubbed against your enemy, the way you did it somehow bothered it, as he hit you with one of its arms, making you fall back into your initial place.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you rubbed against your enemy, the way you did it somehow bothered it, as he hit you with one of its arms, making you fall back into your initial place.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You try to rub your body against your opponent, but it forced you back with both arms, pushing you into the ground in front of it.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You try to rub your body against your opponent, but it forced you back with both arms, pushing you into the ground in front of it.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}



	// // /// <summary>
	///  530 - 10, 45, 15, 15, 1, "Pervert show", "High but costly lust damage. Cost: 15 will, 15 lust.", 0.1f, 0.8f
	/// </summary>

	public void Lust530(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (4, 7);
		lustRand = Random.Range (32, 38);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0.1f, 0.6f); // random
		multiplier5 = Random.Range(0.1f, 0.4f);
		failDmgRand = Random.Range (6, 12);
		failLustRand = Random.Range (6, 12); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 15; 
		GameControl.actualArousal = GameControl.actualArousal + 15;

		if (randNum > 90)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1 - WorldControl.enemyLustDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You placed your back against your enemy’s body as you stretched your clothing to tease him with your ass against it, raising its will to fuck by a large amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You placed your back against your enemy’s body as you stretched your clothing to tease him with your ass against it, raising its will to fuck by a large amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You stretched your clothing as your opponent couldn’t help but feel your contour with its own arms, raising its will to fuck by a large amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You stretched your clothing as your opponent couldn’t help but feel your contour with its own arms, raising its will to fuck by a large amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 20)
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1 -  WorldControl.enemyLustDefense;
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You pulled your clothing to its limit, showing your delightful silhouette to your enemy.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You pulled your clothing to its limit, showing your delightful silhouette to your enemy.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You were almost over your opponent, grabbing your clothes and stretching them to show your silhouette as you teased your body close to your enemy.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You were almost over your opponent, grabbing your clothes and stretching them to show your silhouette as you teased your body close to your enemy.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "Your sexy teasing wasn’t enough for your opponent.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "Your sexy teasing wasn’t enough for your opponent.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "Your cloth show failed to get the attention of your enemy.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "Your cloth show failed to get the attention of your enemy.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "After you try to tease your opponent with your clothing, you tripped against it, rubbing your body against the arms of your enemy, increasing your own will to fuck.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "After you try to tease your opponent with your clothing, you tripped against it, rubbing your body against the arms of your enemy, increasing your own will to fuck.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "As you try to do a show to him, you tripped and pulled your opponent over you, as he took the chance to get a good grab of you, until you slipped off its grasp.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "As you try to do a show to him, you tripped and pulled your opponent over you, as he took the chance to get a good grab of you, until you slipped off its grasp.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}

	// // /// <summary>
	///  600 - 25, 5, 20, 35, 1, "Groin shoving", "Decent will damage and some lust damage. Cost: 10 lust", 0.2f, 0.85f 
	/// </summary>

	public void Lust600(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (15, 19);
		lustRand = Random.Range (3, 7);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0.1f, 0.6f); // random
		multiplier5 = Random.Range(0.1f, 0.4f);
		failDmgRand = Random.Range (4, 8);
		failLustRand = Random.Range (0, 0); 
		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		GameControl.actualArousal = GameControl.actualArousal + 10;

		if (randNum > 85)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1 - WorldControl.enemyLustDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You shoved your crotch against your opponent’s ass, as this powerful display lowered your enemy’s will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You shoved your crotch against your opponent’s ass, as this powerful display lowered your enemy’s will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You caught your opponent off-guard, so you jammed your groin into its face, as your scent got caught into its face, lowering its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You caught your opponent off-guard, so you jammed your groin into its face, as your scent got caught into its face, lowering its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 20)
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1 -  WorldControl.enemyLustDefense;
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You shoved your groin into a tender part of your enemy’s body, and the sensation of your genitals in its body lowered its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You shoved your groin into a tender part of your enemy’s body, and the sensation of your genitals in its body lowered its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You pushed your groin against your opponent’s body, and this display of force decreased its will to fight by a small amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You pushed your groin against your opponent’s body, and this display of force decreased its will to fight by a small amount.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "As you try your shove, your enemy dodged the technique in time.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "As you try your shove, your enemy dodged the technique in time.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "Your shoving missed its intended target.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "Your shoving missed its intended target.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you try to cram your groin into your opponent’s, you were hit by one of your opponent’s arms, pushing you away and damaging you a bit.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you try to cram your groin into your opponent’s, you were hit by one of your opponent’s arms, pushing you away and damaging you a bit.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You try to shove your groin towards your opponent, but he hit it with a headbutt, damaging you a bit.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You try to shove your groin towards your opponent, but he hit it with a headbutt, damaging you a bit.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}



	// // /// <summary>
	///  610 - 20, 0, 20, 35, 1, "Hold fast", "Normal will damage, can stun. Cost: 10 lust", 0.2f, 0.8f
	/// </summary>

	public void Lust610(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (15, 19);
		lustRand = Random.Range (0, 0);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0.1f, 0.4f); // random
		multiplier5 = Random.Range(0.1f, 0.4f);
		failDmgRand = Random.Range (6, 10);
		failLustRand = Random.Range (0, 0); 
		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		GameControl.actualArousal = GameControl.actualArousal + 10;

		if (randNum > 80)
		{


			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1 - WorldControl.enemyLustDefense; 
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
				WorldControl.charAttackDescription = "You held your enemy’s head and pressed it against your groin, letting it smell it. Its defenselessness lowered its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You held your enemy’s head and pressed it against your groin, letting it smell it. Its defenselessness lowered its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You held your opponent’s head and pressed it against your chest, without releasing it. It slapped and kicked to free itself, but it was futile, which lowered its will to fight..\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You held your opponent’s head and pressed it against your chest, without releasing it. It slapped and kicked to free itself, but it was futile, which lowered its will to fight..\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 20)
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1 -  WorldControl.enemyLustDefense;
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You get a hold of your opponent’s body and you pressed hard against yours, without letting it go. Its incapability of escaping, lowered its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You get a hold of your opponent’s body and you pressed hard against yours, without letting it go. Its incapability of escaping, lowered its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You grabbed your opponent by its shoulder, pulling it to you and pressing its body against yours. Such display of might lowered its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You grabbed your opponent by its shoulder, pulling it to you and pressing its body against yours. Such display of might lowered its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "Your opponent was too fast for you on this occasion, making you miss.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "Your opponent was too fast for you on this occasion, making you miss.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You try to grab any part of your opponent, but your maneuver miss.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You try to grab any part of your opponent, but your maneuver miss.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "Your powers of coercion weren’t enough because when you pulled your opponent, it welcomes you with an elbow in your belly, making you fall back.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "Your powers of coercion weren’t enough because when you pulled your opponent, it welcomes you with an elbow in your belly, making you fall back.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "As you try to coerce your opponent’s face into your body, it bites you and forced you to release it and take a step back.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "As you try to coerce your opponent’s face into your body, it bites you and forced you to release it and take a step back.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}

	// // /// <summary>
	///  620 - 30, 5, 20, 35, 1, "Forced kissing", "Good will damage, but increases your lust. Cos: 15 lust ", 0.05f, 0.8f
	/// </summary>

	public void Lust620(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (23, 28);
		lustRand = Random.Range (3, 7);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0.1f, 0.4f); // random
		multiplier5 = Random.Range(0.4f, 0.8f);
		failDmgRand = Random.Range (4, 8);
		failLustRand = Random.Range (0, 0); 
		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		GameControl.actualArousal = GameControl.actualArousal + 15;

		if (randNum > 95)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1 - WorldControl.enemyLustDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "Your kiss was so overbearing, that your opponent couldn’t help but follow your kiss, as it was hard to resist your forcefulness, lowering its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "Your kiss was so overbearing, that your opponent couldn’t help but follow your kiss, as it was hard to resist your forcefulness, lowering its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You caught your enemy unaware and kissed it with force, as it couldn’t help but submit to your kiss, which lowered its will to fight as you felt his body getting warmer.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You caught your enemy unaware and kissed it with force, as it couldn’t help but submit to your kiss, which lowered its will to fight as you felt his body getting warmer.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 20)
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1 -  WorldControl.enemyLustDefense;
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You grab your enemy it by its neck and kissed it with tongue included, as your enemy couldn’t do anything to stop it, which lowered its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You grab your enemy it by its neck and kissed it with tongue included, as your enemy couldn’t do anything to stop it, which lowered its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You get a hold of its head and kiss it passionately, as it tries to push you away, without success. Your display of ownership lowered its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You get a hold of its head and kiss it passionately, as it tries to push you away, without success. Your display of ownership lowered its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "You try to get a hold of your enemy’s head, but it ducks and weaves to avoid you.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "You try to get a hold of your enemy’s head, but it ducks and weaves to avoid you.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You try to kiss your opponent, but it turned its head in the nick of time.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You try to kiss your opponent, but it turned its head in the nick of time.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "As you tried to kiss your opponent without consent, your opponent gave you a headbutt, moving you out of your position.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "As you tried to kiss your opponent without consent, your opponent gave you a headbutt, moving you out of your position.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You try to kiss your opponent by force, but it bites you back, interrupting your maneuver.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You try to kiss your opponent by force, but it bites you back, interrupting your maneuver.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}

	// // /// <summary>
	///  630 - 40, 15, 20, 35, 1, "Coerced touch", "Great will damage and some lust, critical miss hurt hard. Cost: 10 will, 20 lust" , 0.1f, 0.85f 
	/// </summary>

	public void Lust630(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		damageRand = Random.Range (33, 38);
		lustRand = Random.Range (8, 13);
		multiplier1 = (GameControl.attSocial/500); // stat
		multiplier2 = Random.Range (0.1f, 0.4f); // random
		multiplier5 = Random.Range(0.2f, 0.6f);
		failDmgRand = Random.Range (15, 22);
		failLustRand = Random.Range (0, 0); 
		// cost
		GameControl.actualHealth = GameControl.actualHealth - 5; 
		//GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 90)
		{

			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1 - WorldControl.enemyLustDefense; 
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You took the advantage, as you saw your enemy off-guard, coercing their whole body around yours as you forced it to touch you in the places you wanted it to touch. Your enemy started to follow your orders with obedience, lowering its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You took the advantage, as you saw your enemy off-guard, coercing their whole body around yours as you forced it to touch you in the places you wanted it to touch. Your enemy started to follow your orders with obedience, lowering its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You caught your opponent tired, forcing its arms and body to touch yours without much resistance, as you felt its body trembling in submission, lowering its will to fight by a lot.. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You caught your opponent tired, forcing its arms and body to touch yours without much resistance, as you felt its body trembling in submission, lowering its will to fight by a lot.. \nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;


			}
		}
		else if (randNum > 20)
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier3 + multiplier4 + 1 -  WorldControl.enemyLustDefense;
			charDamageTotal = damageRand * multiplierTotal; 
			charLustTotal = lustRand * multiplierTotal; 
			WorldControl.enemyHP = WorldControl.enemyHP - charDamageTotal; 
			WorldControl.enemyLust = WorldControl.enemyLust + charLustTotal; 


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "You grabbed your enemy’s arms, as you pulled them to all your naughty bits, forcing it to rub them just the way you like it, as it was impossible for it to stop you, lowering its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "You grabbed your enemy’s arms, as you pulled them to all your naughty bits, forcing it to rub them just the way you like it, as it was impossible for it to stop you, lowering its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "You got a hold of your opponent arms, forcing it to please you as much as you wanted. It tried to fight back but it couldn’t, which lowered its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "You got a hold of your opponent arms, forcing it to please you as much as you wanted. It tried to fight back but it couldn’t, which lowered its will to fight.\nThe attack did " + charDamageTotal + " will damage and increased the enemy lust in " + charLustTotal + " points!"; 
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
				WorldControl.charAttackDescription = "Your opponent showed to be faster than you thought, as you couldn’t caught it. \nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 

				WorldControl.charAttackDescription = "Your opponent showed to be faster than you thought, as you couldn’t caught it. \nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			case 2:

				WorldControl.charAttackDescription = "You tried to get a hold of your opponent’s arms, but you missed to get them.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;
			default: 

				WorldControl.charAttackDescription = "You tried to get a hold of your opponent’s arms, but you missed to get them.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 

				break;


			}
		} 
		else 
		{
			multiplierTotal = multiplier1 + multiplier2 + multiplier5 + 1; 
			failDmgRand = failDmgRand * multiplierTotal; 
			failLustRand = failLustRand * multiplierTotal; 
			GameControl.actualHealth = GameControl.actualHealth - failDmgRand; 
			GameControl.actualArousal = GameControl.actualArousal + failLustRand;


			randNum = Random.Range (0, 3);
			switch(randNum)
			{

			case 0:
				WorldControl.charAttackDescription = "While you tried to force your opponent arms over you, it took the chance to hit you in the genitals, leaving a painful sensation as it retreated from you.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 1: 
				WorldControl.charAttackDescription = "While you tried to force your opponent arms over you, it took the chance to hit you in the genitals, leaving a painful sensation as it retreated from you.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			case 2:
				WorldControl.charAttackDescription = "As you got one of your opponent’s shoulders, it kicked you in your face just to force you to release it.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;
			default: 
				WorldControl.charAttackDescription = "As you got one of your opponent’s shoulders, it kicked you in your face just to force you to release it.\nThe attack reduced your will in " + charDamageTotal + " points and increased your lust in " + charLustTotal + " points!"; 
				break;

			}
		}
	}



	/// <summary>
	/// //////////////////////////////////////////////////////////////////////////
	/// </summary>



	void lust100LevelUp(){
		if (GameControl.lustSetCounter [0] > 20 && GameControl.lustSetLevel [0] < 3)
		{

			GameControl.lustSetLevel [0] += 1;
			GameControl.lustSetCounter [0] = 0; 
			//CombatScript.levelUpTxt = "You are better at flirting now!";

		}

	}




	void lust200LevelUp(){
		if (GameControl.lustSetCounter [1] > 20 && GameControl.lustSetLevel [1] < 3)
		{

			GameControl.lustSetLevel [1] += 1;
			GameControl.lustSetCounter [1] = 0; 
			//CombatScript.levelUpTxt = "You are better at enticing now!";

		}

	}


	void lust300LevelUp(){
		if (GameControl.lustSetCounter [2] > 20 && GameControl.lustSetLevel [2] < 3)
		{

			GameControl.lustSetLevel [2] += 1;
			GameControl.lustSetCounter [2] = 0; 
			//CombatScript.levelUpTxt = "You are more bold now! Your exhibitionism level has increased!";

		}

	}

	void lust400LevelUp(){
		if (GameControl.lustSetCounter [3] > 20 && GameControl.lustSetLevel [3] < 3)
		{

			GameControl.lustSetLevel [3] += 1;
			GameControl.lustSetCounter [3] = 0; 
			//CombatScript.levelUpTxt = "You are more dominant now!";

		}

	}

	void lust500LevelUp(){
		if (GameControl.lustSetCounter [4] > 20 && GameControl.lustSetLevel [4] < 3)
		{

			GameControl.lustSetLevel [4] += 1;
			GameControl.lustSetCounter [4] = 0; 
			//CombatScript.levelUpTxt = "Nice! You are more slutty now!";

		}

	}

	void lust600LevelUp(){
		if (GameControl.lustSetCounter [5] > 20 && GameControl.lustSetLevel [5] < 3)
		{

			GameControl.lustSetLevel [5] += 1;
			GameControl.lustSetCounter [5] = 0; 
			//CombatScript.levelUpTxt = "You are more forcefull now!";

		}

	}


	/*
	void statPhysLevelUp(){
		if (GameControl.physicalCounter > 7 && GameControl.attPhysical < 100) {
			GameControl.attPhysical += 1; 
			GameControl.physicalCounter = 0; 
		}
	}

	void statMentLevelUp(){
		if (GameControl.mentalCounter > 7 && GameControl.attMental < 100) {
			GameControl.attMental += 1;
			GameControl.mentalCounter = 0;
		}

	}

	void statSocLevelUp(){
		if (GameControl.socialCounter > 7 && GameControl.attSocial < 100) {
			GameControl.attSocial += 1;
			GameControl.socialCounter = 0;
		}

	}
	*/



	// // // // // // // // // // //

	public void Calculator(){
		int i = 0;
		while (i < 1000) {
			Lust630 ();
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





	void Start () {
		Calculator ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
