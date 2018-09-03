using UnityEngine;
using System.Collections;

public class EnemyAttacks : MonoBehaviour {

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


	public void enemyAttack()
	{
		Debug.Log ("Enemy attack working");
		switch (WorldControl.enemyID) 
		{
		case 100:
			enemy100 ();
			break;
		case 110:
			enemy110 ();
			break;
		case 120:
			enemy120 ();
			break;
		case 130:
			enemy130 ();
			break;
		case 140:
			enemy140();
			break; 



		}

	}



	public void enemy100(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		//GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 85) //Bunny leap
		{				
			Random.InitState (System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 101); 
			damageRand = Random.Range (10, 16);
			lustRand = Random.Range (18, 28);
			multiplier1 = (0.15f); // stat
			multiplier2 = Random.Range (0.05f, 0.4f); // random
			failDmgRand = Random.Range (9,15);
			failLustRand = Random.Range (0, 0); 
			
			if (randNum > 25) {



				multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.charComDefense; 
				charDamageTotal = damageRand * multiplierTotal; 
				charLustTotal = lustRand * multiplierTotal; 
				charDamageTotal = Mathf.Round (charDamageTotal * 100f) / 100f;
				charLustTotal = Mathf.Round (charLustTotal * 100f) / 100f; 
				GameControl.actualHealth =GameControl.actualHealth  - charDamageTotal; 
				GameControl.actualArousal = GameControl.actualArousal + charLustTotal; 


				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" + "You just felt how the rabbit beat you strongly with her meaty hips in your torso, forcing you back. \n The attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" + "The rabbit girl run towards you and jumped to slam you, hitting you with her soft and tender ass in your chest, pushing you to the side. \nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" + "The rabbit run into your position and take a leap against you, hitting your body with her chest, pushing its perky tits against your body as it pushes you away.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" + "The rabbit run into your position and take a leap against you, hitting your body with her chest, pushing its perky tits against your body as it pushes you away.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;


				}
			} else {
				multiplierTotal = multiplier1 + multiplier2 + 1; 
				failDmgRand = failDmgRand * multiplierTotal; 
				failLustRand = failLustRand * multiplierTotal; 

				failDmgRand = Mathf.Round (failDmgRand * 100f) / 100f;
				failLustRand = Mathf.Round (failLustRand * 100f) / 100f; 
				WorldControl.enemyHP = WorldControl.enemyHP - failDmgRand; 
				WorldControl.enemyLust = WorldControl.enemyLust + failLustRand;

				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The bunny darted from her position and tried to slam her breasts against you, but you moved out of the way just in time to avoid damage.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The rabbit takes some space to run before leaping towards you, but you had enough time to dodge it before it hits.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "Your enemy spring from her step and jumps in your direction, but narrowly failed.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "Your enemy spring from her step and jumps in your direction, but narrowly failed.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;


				}


			}
		}



		else if (randNum > 50) // bouncy grab 
		{
			
			Random.InitState (System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 101); 
			damageRand = Random.Range (10, 18);
			lustRand = Random.Range (14, 20);
			multiplier1 = (0.15f); // stat
			multiplier2 = Random.Range (0.1f, 0.5f); // random
			failDmgRand = Random.Range (6,10);
			failLustRand = Random.Range (0, 0); 

			if (randNum > 30) {
				
				multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.charLustDefense; 
				charDamageTotal = damageRand * multiplierTotal; 
				charLustTotal = lustRand * multiplierTotal; 
				charDamageTotal = Mathf.Round (charDamageTotal * 100f) / 100f;
				charLustTotal = Mathf.Round (charLustTotal * 100f) / 100f; 
				GameControl.actualHealth =GameControl.actualHealth  - charDamageTotal; 
				GameControl.actualArousal = GameControl.actualArousal + charLustTotal; 


				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "\nYou saw the bunny run in your direction, before jumping and holding herself from your body, rubbing her cunt and chin against you, smearing you with her lustful fluids.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "\nYou saw the bunny run in your direction, before jumping and holding herself from your body, rubbing her cunt and chin against you, smearing you with her lustful fluids.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "\nThe bunny held herself from your body and started groping any place of it that she can get a hold of, from your torso to your pubis, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You saw the bunny run in your direction, before jumping and holding herself from your body, rubbing her cunt and chin against you, smearing you with her lustful fluids.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;


				}
			} 
			else 
			{
				multiplierTotal = multiplier1 + multiplier2 + 1; 
				failDmgRand = failDmgRand * multiplierTotal; 
				failLustRand = failLustRand * multiplierTotal; 

				failDmgRand = Mathf.Round (failDmgRand * 100f) / 100f;
				failLustRand = Mathf.Round (failLustRand * 100f) / 100f; 
				WorldControl.enemyHP = WorldControl.enemyHP - failDmgRand; 
				WorldControl.enemyLust = WorldControl.enemyLust + failLustRand;

				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The Lost bunny lunged in your direction and extended her hands to grab you, but she missed you as you dodged her moving to the side.\nThe attack did " + failDmgRand + " will damage and increased her lust in " + failLustRand + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "Your rabbit enemy did a long jump and tried to land on you, but you moved out of the way before the could get a hand on you.\nThe attack did " + failDmgRand + " will damage and increased her lust in " + failLustRand + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The bunny tries to get a hold of you but missed its jump and lands in front of you.\nThe attack did " + failDmgRand +" will damage and increased her lust in " + failLustRand + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The bunny tries to get a hold of you but missed its jump and lands in front of you.\nThe attack did " + failDmgRand + " will damage and increased her lust in " + failLustRand + " points!"; 
					break;


				}

			}
		} 


		else // Rabbit tease
		{

			Random.InitState (System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 101); 
			damageRand = Random.Range (4, 7);
			lustRand = Random.Range (15, 23);
			multiplier1 = (0.15f); // stat
			multiplier2 = Random.Range (0.1f, 0.3f); // random
			failDmgRand = Random.Range (4,8);
			failLustRand = Random.Range (5, 10); 

			if (randNum > 20) {

				multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.charLustDefense; 
				charDamageTotal = damageRand * multiplierTotal; 
				charLustTotal = lustRand * multiplierTotal; 
				charDamageTotal = Mathf.Round (charDamageTotal * 100f) / 100f;
				charLustTotal = Mathf.Round (charLustTotal * 100f) / 100f; 
				GameControl.actualHealth =GameControl.actualHealth  - charDamageTotal; 
				GameControl.actualArousal = GameControl.actualArousal + charLustTotal; 

				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You can see how she ran a hand across her silhouette, stopping at her ass. “I’ll make you love it… Come on...”, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  " The rabbit slaps one of her tender asscheeks then looks at you in a lustful way. “You can bounce me all the time you want”, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The bunny rubs one of her tits in a seductive way and says: “We’ll mate all night long. Don’t you want to?”, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The bunny rubs one of her tits in a seductive way and says: “We’ll mate all night long. Don’t you want to?”, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;


				}
			} 
			else 
			{
				multiplierTotal = multiplier1 + multiplier2 + 1; 
				failDmgRand = failDmgRand * multiplierTotal; 
				failLustRand = failLustRand * multiplierTotal; 

				failDmgRand = Mathf.Round (failDmgRand * 100f) / 100f;
				failLustRand = Mathf.Round (failLustRand * 100f) / 100f; 
				WorldControl.enemyHP = WorldControl.enemyHP - failDmgRand; 
				WorldControl.enemyLust = WorldControl.enemyLust + failLustRand;

				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The lustful dance of your female enemy wasn’t hard enough to increase your libido.\nShe did to herself " + failDmgRand + " will damage and increased her lust in " + failLustRand + " points!" ; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "As you saw the bunny trying to get your attention, you dismiss it as not interesting enough.\nShe did to herself " + failDmgRand + " will damage and increased her lust in " + failLustRand + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The moves that the bunny does to entice you are not enough to turn you on.\nShe did to herself " + failDmgRand + " will damage and increased her lust in " + failLustRand + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The moves that the bunny does to entice you are not enough to turn you on.\nShe did to herself " + failDmgRand + " will damage and increased her lust in " + failLustRand + " points!"; 
					break;


				}

			}


		} 


	}

	/// <summary>/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	/// Werewolf
	/// </summary>


	public void enemy110(){
		Random.InitState(System.DateTime.Now.Millisecond);

		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		//GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 85) //Hunter's musk
		{				
			Random.InitState (System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 101); 
			damageRand = Random.Range (15, 20);
			lustRand = Random.Range (15, 20);
			multiplier1 = (0.15f); // stat
			multiplier2 = Random.Range (0.3f, 0.6f); // random
			failDmgRand = Random.Range (5,10);
			failLustRand = Random.Range (10, 15); 

			if (randNum > 25) {



				multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.charLustDefense; 
				charDamageTotal = damageRand * multiplierTotal; 
				charLustTotal = lustRand * multiplierTotal; 
				charDamageTotal = Mathf.Round (charDamageTotal * 100f) / 100f;
				charLustTotal = Mathf.Round (charLustTotal * 100f) / 100f; 
				GameControl.actualHealth =GameControl.actualHealth  - charDamageTotal; 
				GameControl.actualArousal = GameControl.actualArousal + charLustTotal; 


				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" + "Faster than you thought, the werewolf pinned your face against a rock and proceeded to rub its dick against your back, smelling a strong-scented liquid tainting your back, its inebriating smell increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points! ";
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" + "Faster than you thought, the werewolf pinned your face against a rock and proceeded to rub its dick against your back, smelling a strong-scented liquid tainting your back, its inebriating smell increasing your will to fuck. \nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!";
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" + "The werewolf jumped at you, pinning you against a tree. Then he started rubbing his cock all over your body, smearing his fluids all over your body. Its scent was intoxicating, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!";
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" + "The werewolf jumped at you, pinning you against a tree. Then he started rubbing his cock all over your body, smearing his fluids all over your body. Its scent was intoxicating, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;


				}
			} else {
				multiplierTotal = multiplier1 + multiplier2 + 1; 
				failDmgRand = failDmgRand * multiplierTotal; 
				failLustRand = failLustRand * multiplierTotal; 

				failDmgRand = Mathf.Round (failDmgRand * 100f) / 100f;
				failLustRand = Mathf.Round (failLustRand * 100f) / 100f; 
				WorldControl.enemyHP = WorldControl.enemyHP - failDmgRand; 
				WorldControl.enemyLust = WorldControl.enemyLust + failLustRand;

				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The werewolf tried to ram you against a tree, but you rolled to the side and avoided the attack\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The werewolf tried to ram you against a tree, but you rolled to the side and avoided the attack\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You saw how the werewolf tries to lunge at you from the side, but you duck and take a step to the other side, maintaining your distance.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You saw how the werewolf tries to lunge at you from the side, but you duck and take a step to the other side, maintaining your distance.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;


				}


			}
		}
		else if (randNum > 50) // Alpha’s Aura  
		{

			Random.InitState (System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 101); 
			damageRand = Random.Range (6, 26);
			lustRand = Random.Range (0, 0);
			multiplier1 = (0.15f); // stat
			multiplier2 = Random.Range (0.1f, 0.35f); // random
			failDmgRand = Random.Range (5,10);
			failLustRand = Random.Range (0, 1); 

			if (randNum > 30) {

				multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.charComDefense; 
				charDamageTotal = damageRand * multiplierTotal; 
				charLustTotal = lustRand * multiplierTotal; 
				charDamageTotal = Mathf.Round (charDamageTotal * 100f) / 100f;
				charLustTotal = Mathf.Round (charLustTotal * 100f) / 100f; 
				GameControl.actualHealth =GameControl.actualHealth  - charDamageTotal; 
				GameControl.actualArousal = GameControl.actualArousal + charLustTotal; 


				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "Your canine enemy howled for a pair of seconds then looked at you with a savage look in its face. That display of dominance made your body tremble for a second, lowering your will to fight.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "Your canine enemy howled for a pair of seconds then looked at you with a savage look in its face. That display of dominance made your body tremble for a second, lowering your will to fight.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The werewolf cornered you for a second, growling at you menacingly with his bare pointy teeth and his big throbbing cock, its aura of dominance starting to instill fear into your body, lowering your will to fight.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The werewolf cornered you for a second, growling at you menacingly with his bare pointy teeth and his big throbbing cock, its aura of dominance starting to instill fear into your body, lowering your will to fight.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;


				}
			} 
			else 
			{
				multiplierTotal = multiplier1 + multiplier2 + 1; 
				failDmgRand = failDmgRand * multiplierTotal; 
				failLustRand = failLustRand * multiplierTotal; 

				failDmgRand = Mathf.Round (failDmgRand * 100f) / 100f;
				failLustRand = Mathf.Round (failLustRand * 100f) / 100f; 
				WorldControl.enemyHP = WorldControl.enemyHP - failDmgRand; 
				WorldControl.enemyLust = WorldControl.enemyLust + failLustRand;

				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You saw the werewolf close to you, but its intimidation techniques meant nothing to you.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You saw the werewolf close to you, but its intimidation techniques meant nothing to you.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The wolf howls in front of you, trying to force fear into you, but your resolve stopped it from working.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The wolf howls in front of you, trying to force fear into you, but your resolve stopped it from working.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;


				}

			}
		} 


		else // rending
		{

			Random.InitState (System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 101); 
			damageRand = Random.Range (15, 22);
			lustRand = Random.Range (0, 0);
			multiplier1 = (0.15f); // stat
			multiplier2 = Random.Range (0.1f, 0.3f); // random
			failDmgRand = Random.Range (5,10);
			failLustRand = Random.Range (0, 1); 

			if (randNum > 20) {

				multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.charComDefense; 
				charDamageTotal = damageRand * multiplierTotal; 
				charLustTotal = lustRand * multiplierTotal; 
				charDamageTotal = Mathf.Round (charDamageTotal * 100f) / 100f;
				charLustTotal = Mathf.Round (charLustTotal * 100f) / 100f; 
				GameControl.actualHealth =GameControl.actualHealth  - charDamageTotal; 
				GameControl.actualArousal = GameControl.actualArousal + charLustTotal; 

				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "Your wolf enemy decides to jump at you and take a bite, landing on your arm. His teeth were keen as they sink over your skin, lowering your will to fight. \nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The werewolf lunged at you and tried to claw your clothes out of the way, making your bleed a bit and lowering your will to fight.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The werewolf lunged at you and tried to claw your clothes out of the way, making your bleed a bit and lowering your will to fight.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "Your wolf enemy decides to jump at you and take a bite, landing on your arm. His teeth were keen as they sink over your skin, lowering your will to fight. \nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;


				}
			} 
			else 
			{
				multiplierTotal = multiplier1 + multiplier2 + 1; 
				failDmgRand = failDmgRand * multiplierTotal; 
				failLustRand = failLustRand * multiplierTotal; 

				failDmgRand = Mathf.Round (failDmgRand * 100f) / 100f;
				failLustRand = Mathf.Round (failLustRand * 100f) / 100f; 
				WorldControl.enemyHP = WorldControl.enemyHP - failDmgRand; 
				WorldControl.enemyLust = WorldControl.enemyLust + failLustRand;

				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You saw through the enemy as it tried to bite you, so you step aside before it’s too late.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You saw through the enemy as it tried to bite you, so you step aside before it’s too late.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You saw the wolf’s intentions as it tried to rend you, so you dodged his claw without losing your sight of him.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You saw the wolf’s intentions as it tried to rend you, so you dodged his claw without losing your sight of him.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;


				}

			}


		} 


	}


	/// <summary>/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	/// plant girl - 120
	/// </summary>

	public void enemy120(){
		Random.InitState(System.DateTime.Now.Millisecond);

		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		//GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 85) //Tentacles
		{				
			Random.InitState (System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 101); 
			damageRand = Random.Range (5, 10);
			lustRand = Random.Range (15, 28);
			multiplier1 = (0.15f); // stat
			multiplier2 = Random.Range (0.1f, 0.8f); // random
			failDmgRand = Random.Range (5,10);
			failLustRand = Random.Range (3, 6); 

			if (randNum > 65) {



				multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.charLustDefense; 
				charDamageTotal = damageRand * multiplierTotal; 
				charLustTotal = lustRand * multiplierTotal; 
				charDamageTotal = Mathf.Round (charDamageTotal * 100f) / 100f;
				charLustTotal = Mathf.Round (charLustTotal * 100f) / 100f; 
				GameControl.actualHealth =GameControl.actualHealth  - charDamageTotal; 
				GameControl.actualArousal = GameControl.actualArousal + charLustTotal; 


				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You couldn’t avoid the tentacles in time, as they grab you and rub themselves all over your naughty bits and staining you with its fluids, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You couldn’t avoid the tentacles in time, as they grab you and rub themselves all over your naughty bits and staining you with its fluids, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The flower girl throws her tentacles at you, surrounding you with them and touching your body in a lascivious way, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The flower girl throws her tentacles at you, surrounding you with them and touching your body in a lascivious way, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;


				}
			} else {
				multiplierTotal = multiplier1 + multiplier2 + 1; 
				failDmgRand = failDmgRand * multiplierTotal; 
				failLustRand = failLustRand * multiplierTotal; 

				failDmgRand = Mathf.Round (failDmgRand * 100f) / 100f;
				failLustRand = Mathf.Round (failLustRand * 100f) / 100f; 
				WorldControl.enemyHP = WorldControl.enemyHP - failDmgRand; 
				WorldControl.enemyLust = WorldControl.enemyLust + failLustRand;

				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You saw the tentacles lashing at you, dodging them just in the last second.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You saw the tentacles lashing at you, dodging them just in the last second.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The tentacles move fast in your direction, but you duck and move away, avoiding them for the time being.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The tentacles move fast in your direction, but you duck and move away, avoiding them for the time being.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;


				}


			}
		}
		else if (randNum > 50) // Aphrodisiac Perfume
		{

			Random.InitState (System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 101); 
			damageRand = Random.Range (2, 5);
			lustRand = Random.Range (14, 20);
			multiplier1 = (0.15f); // stat
			multiplier2 = Random.Range (0.0f, 0.2f); // random
			failDmgRand = Random.Range (7,20);
			failLustRand = Random.Range (0, 0); 

			if (randNum > 10) {

				multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.charLustDefense; 
				charDamageTotal = damageRand * multiplierTotal; 
				charLustTotal = lustRand * multiplierTotal; 
				charDamageTotal = Mathf.Round (charDamageTotal * 100f) / 100f;
				charLustTotal = Mathf.Round (charLustTotal * 100f) / 100f; 
				GameControl.actualHealth =GameControl.actualHealth  - charDamageTotal; 
				GameControl.actualArousal = GameControl.actualArousal + charLustTotal; 


				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You see a puff of dust that appears from the flower girl when she claps in front of her. The dust gets into your nose, as it made your body getting hotter and hotter, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You see a puff of dust that appears from the flower girl when she claps in front of her. The dust gets into your nose, as it made your body getting hotter and hotter, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The flower girl blows something from her hands in your direction, a cloud of red dust that surrounds you. Its smell turns you on, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The flower girl blows something from her hands in your direction, a cloud of red dust that surrounds you. Its smell turns you on, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;


				}
			} 
			else 
			{
				multiplierTotal = multiplier1 + multiplier2 + 1; 
				failDmgRand = failDmgRand * multiplierTotal; 
				failLustRand = failLustRand * multiplierTotal; 

				failDmgRand = Mathf.Round (failDmgRand * 100f) / 100f;
				failLustRand = Mathf.Round (failLustRand * 100f) / 100f; 
				WorldControl.enemyHP = WorldControl.enemyHP - failDmgRand; 
				WorldControl.enemyLust = WorldControl.enemyLust + failLustRand;

				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You see a cloud of dust getting out from the flower girl. You ran away from the way of it, before it surrounds you.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You see a cloud of dust getting out from the flower girl. You ran away from the way of it, before it surrounds you.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You see a red dust getting in your direction, so you cover your nose and move away from it, before it's too late.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You see a red dust getting in your direction, so you cover your nose and move away from it, before it's too late.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;


				}

			}
		} 


		else // Flowery Nectar - Lust
		{

			Random.InitState (System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 101); 
			damageRand = Random.Range (8, 14);
			lustRand = Random.Range (12, 25);
			multiplier1 = (0.15f); // stat
			multiplier2 = Random.Range (0.1f, 0.3f); // random
			failDmgRand = Random.Range (4,8);
			failLustRand = Random.Range (5, 10); 

			if (randNum > 20) {

				multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.charLustDefense; 
				charDamageTotal = damageRand * multiplierTotal; 
				charLustTotal = lustRand * multiplierTotal; 
				charDamageTotal = Mathf.Round (charDamageTotal * 100f) / 100f;
				charLustTotal = Mathf.Round (charLustTotal * 100f) / 100f; 
				GameControl.actualHealth =GameControl.actualHealth  - charDamageTotal; 
				GameControl.actualArousal = GameControl.actualArousal + charLustTotal; 

				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The flower girl grabbed you from behind, rubbing her bountiful breasts against your back and smearing her nectar all over your body, making your skin more sensitive to her caressing, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The flower girl grabbed you from behind, rubbing her bountiful breasts against your back and smearing her nectar all over your body, making your skin more sensitive to her caressing, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The flower girl rubs herself against you, the sweet substance that surrounded her started staining your body and making your senses more sensitive as she continued rubbing her ample ass against your body, increasing your will to fuck.\n\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The flower girl rubs herself against you, the sweet substance that surrounded her started staining your body and making your senses more sensitive as she continued rubbing her ample ass against your body, increasing your will to fuck.\n\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;


				}
			} 
			else 
			{
				multiplierTotal = multiplier1 + multiplier2 + 1; 
				failDmgRand = failDmgRand * multiplierTotal; 
				failLustRand = failLustRand * multiplierTotal; 

				failDmgRand = Mathf.Round (failDmgRand * 100f) / 100f;
				failLustRand = Mathf.Round (failLustRand * 100f) / 100f; 
				WorldControl.enemyHP = WorldControl.enemyHP - failDmgRand; 
				WorldControl.enemyLust = WorldControl.enemyLust + failLustRand;

				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "She tried to rub her body against you, but you took a step back before she could do it.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "She tried to rub her body against you, but you took a step back before she could do it.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You see her trying to sneak on your back, but you took a step aside to avoid her contact.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You see her trying to sneak on your back, but you took a step aside to avoid her contact.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;


				}

			}


		} 


	}



	public void enemy130(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		//GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 65) //overpower
		{				
			Random.InitState (System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 101); 
			damageRand = Random.Range (16, 24);
			lustRand = Random.Range (0, 1);
			multiplier1 = (0.15f); // stat
			multiplier2 = Random.Range (0.1f, 0.4f); // random
			failDmgRand = Random.Range (10,18);
			failLustRand = Random.Range (0, 0); 

			if (randNum > 25) {



				multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.charComDefense; 
				charDamageTotal = damageRand * multiplierTotal; 
				charLustTotal = lustRand * multiplierTotal; 
				charDamageTotal = Mathf.Round (charDamageTotal * 100f) / 100f;
				charLustTotal = Mathf.Round (charLustTotal * 100f) / 100f; 
				GameControl.actualHealth =GameControl.actualHealth  - charDamageTotal; 
				GameControl.actualArousal = GameControl.actualArousal + charLustTotal; 


				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" + "The stallion proved to be faster than expected, as it headbutts you before you could react properly.\n The attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" + "The stallion proved to be faster than expected, as it headbutts you before you could react properly.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" + "Even thought it was on two legs, the stallion proved to be faster than you thought, as it kicked you with great force with one of his legs.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" + "Even thought it was on two legs, the stallion proved to be faster than you thought, as it kicked you with great force with one of his legs.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;


				}
			} else {
				multiplierTotal = multiplier1 + multiplier2 + 1; 
				failDmgRand = failDmgRand * multiplierTotal; 
				failLustRand = failLustRand * multiplierTotal; 

				failDmgRand = Mathf.Round (failDmgRand * 100f) / 100f;
				failLustRand = Mathf.Round (failLustRand * 100f) / 100f; 
				WorldControl.enemyHP = WorldControl.enemyHP - failDmgRand; 
				WorldControl.enemyLust = WorldControl.enemyLust + failLustRand;

				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The stallion was fast, but it was harder for him to aim, so you just move out of the way.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The stallion was fast, but it was harder for him to aim, so you just move out of the way.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The enemy tried to ram you at high speed, but you rolled out to safety.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The enemy tried to ram you at high speed, but you rolled out to safety.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;


				}


			}
		}



		else if (randNum > 25) // Equine tongue
		{

			Random.InitState (System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 101); 
			damageRand = Random.Range (5, 10);
			lustRand = Random.Range (12, 20);
			multiplier1 = (0.15f); // stat
			multiplier2 = Random.Range (0.1f, 0.5f); // random
			failDmgRand = Random.Range (3,6);
			failLustRand = Random.Range (4, 8); 

			if (randNum > 30) {

				multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.charLustDefense; 
				charDamageTotal = damageRand * multiplierTotal; 
				charLustTotal = lustRand * multiplierTotal; 
				charDamageTotal = Mathf.Round (charDamageTotal * 100f) / 100f;
				charLustTotal = Mathf.Round (charLustTotal * 100f) / 100f; 
				GameControl.actualHealth =GameControl.actualHealth  - charDamageTotal; 
				GameControl.actualArousal = GameControl.actualArousal + charLustTotal; 


				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The stallion lifted you from the ground, and used its long tongue to taste your groin and chest in a lustful craze, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The stallion lifted you from the ground, and used its long tongue to taste your groin and chest in a lustful craze, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "Your equine enemy got a hold of you, lifting you from the ground and using its large tongue to lick your body in a lascivious way, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "Your equine enemy got a hold of you, lifting you from the ground and using its large tongue to lick your body in a lascivious way, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;


				}
			} 
			else 
			{
				multiplierTotal = multiplier1 + multiplier2 + 1; 
				failDmgRand = failDmgRand * multiplierTotal; 
				failLustRand = failLustRand * multiplierTotal; 

				failDmgRand = Mathf.Round (failDmgRand * 100f) / 100f;
				failLustRand = Mathf.Round (failLustRand * 100f) / 100f; 
				WorldControl.enemyHP = WorldControl.enemyHP - failDmgRand; 
				WorldControl.enemyLust = WorldControl.enemyLust + failLustRand;

				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You got yourself trapped by the stallion’s big hands, but squirmed enough to break yourself free before he can do anything.\nThe attack did " + failDmgRand + " will damage and increased her lust in " + failLustRand + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You got yourself trapped by the stallion’s big hands, but squirmed enough to break yourself free before he can do anything.\nThe attack did " + failDmgRand + " will damage and increased her lust in " + failLustRand + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "Your enemy tries to get a hold of you, but you didn’t give him the chance to grab you.\nThe attack did " + failDmgRand +" will damage and increased her lust in " + failLustRand + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "Your enemy tries to get a hold of you, but you didn’t give him the chance to grab you.\nThe attack did " + failDmgRand + " will damage and increased her lust in " + failLustRand + " points!"; 
					break;


				}

			}
		} 


		else // cockslap
		{

			Random.InitState (System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 101); 
			damageRand = Random.Range (4, 7);
			lustRand = Random.Range (12, 24);
			multiplier1 = (0.15f); // stat
			multiplier2 = Random.Range (0.1f, 0.3f); // random
			failDmgRand = Random.Range (4,12);
			failLustRand = Random.Range (5, 10); 

			if (randNum > 25) {

				multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.charLustDefense; 
				charDamageTotal = damageRand * multiplierTotal; 
				charLustTotal = lustRand * multiplierTotal; 
				charDamageTotal = Mathf.Round (charDamageTotal * 100f) / 100f;
				charLustTotal = Mathf.Round (charLustTotal * 100f) / 100f; 
				GameControl.actualHealth =GameControl.actualHealth  - charDamageTotal; 
				GameControl.actualArousal = GameControl.actualArousal + charLustTotal; 

				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The stallion hit your hands out of the way and jammed its enormous cock in your face, smearing its sex fluids all over you, its enticing scent increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The stallion hit your hands out of the way and jammed its enormous cock in your face, smearing its sex fluids all over you, its enticing scent increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "Your enemy used his big equine cock to slap your face, filling your face with cock juice and increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "Your enemy used his big equine cock to slap your face, filling your face with cock juice and increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;


				}
			} 
			else 
			{
				multiplierTotal = multiplier1 + multiplier2 + 1; 
				failDmgRand = failDmgRand * multiplierTotal; 
				failLustRand = failLustRand * multiplierTotal; 

				failDmgRand = Mathf.Round (failDmgRand * 100f) / 100f;
				failLustRand = Mathf.Round (failLustRand * 100f) / 100f; 
				WorldControl.enemyHP = WorldControl.enemyHP - failDmgRand; 
				WorldControl.enemyLust = WorldControl.enemyLust + failLustRand;

				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You see his cock going in your direction, at which point you narrowly dodged it.\nShe did to herself " + failDmgRand + " will damage and increased her lust in " + failLustRand + " points!" ; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You see his cock going in your direction, at which point you narrowly dodged it.\nShe did to herself " + failDmgRand + " will damage and increased her lust in " + failLustRand + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "Your equine enemy pushed your hands out of the way, but you quickly lunged yourself backwards, looking how his cock fanned in front of you, missing your face.\nShe did to herself " + failDmgRand + " will damage and increased her lust in " + failLustRand + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "Your equine enemy pushed your hands out of the way, but you quickly lunged yourself backwards, looking how his cock fanned in front of you, missing your face.\nShe did to herself " + failDmgRand + " will damage and increased her lust in " + failLustRand + " points!"; 
					break;


				}

			}


		} 


	}

	/// <summary>
	/// dodo
	/// </summary>


	public void enemy140(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101); 
		// cost
		//GameControl.actualHealth = GameControl.actualHealth - 5; 
		//GameControl.actualArousal = GameControl.actualArousal + 5;

		if (randNum > 85) //bossom dive
		{				
			Random.InitState (System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 101); 
			damageRand = Random.Range (13, 23);
			lustRand = Random.Range (6, 9);
			multiplier1 = (0.15f); // stat
			multiplier2 = Random.Range (0.05f, 0.4f); // random
			failDmgRand = Random.Range (9,15);
			failLustRand = Random.Range (0, 0); 

			if (randNum > 25) {



				multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.charComDefense; 
				charDamageTotal = damageRand * multiplierTotal; 
				charLustTotal = lustRand * multiplierTotal; 
				charDamageTotal = Mathf.Round (charDamageTotal * 100f) / 100f;
				charLustTotal = Mathf.Round (charLustTotal * 100f) / 100f; 
				GameControl.actualHealth =GameControl.actualHealth  - charDamageTotal; 
				GameControl.actualArousal = GameControl.actualArousal + charLustTotal; 


				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" + "Your flying adversary dived from the sky and tackled you with her bosom, pushing you back\n The attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" + "Your flying adversary dived from the sky and tackled you with her bosom, pushing you back\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" + "Your avian enemy dived from above and hit you with her rear, dealing you X damage to your will to fight.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" + "Your avian enemy dived from above and hit you with her rear, dealing you X damage to your will to fight.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;


				}
			} else {
				multiplierTotal = multiplier1 + multiplier2 + 1; 
				failDmgRand = failDmgRand * multiplierTotal; 
				failLustRand = failLustRand * multiplierTotal; 

				failDmgRand = Mathf.Round (failDmgRand * 100f) / 100f;
				failLustRand = Mathf.Round (failLustRand * 100f) / 100f; 
				WorldControl.enemyHP = WorldControl.enemyHP - failDmgRand; 
				WorldControl.enemyLust = WorldControl.enemyLust + failLustRand;

				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The bird dived swift but you were ready for her, nimbly dodging her attack.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The bird dived swift but you were ready for her, nimbly dodging her attack.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You saw her curvy silhouette diving in your direction, so you sidestepped before she could get to you.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "You saw her curvy silhouette diving in your direction, so you sidestepped before she could get to you.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;


				}


			}
		}



		else if (randNum > 50) // Flying Fondling - Lust
		{

			Random.InitState (System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 101); 
			damageRand = Random.Range (4, 10);
			lustRand = Random.Range (16, 23);
			multiplier1 = (0.15f); // stat
			multiplier2 = Random.Range (0.1f, 0.5f); // random
			failDmgRand = Random.Range (6,15);
			failLustRand = Random.Range (0, 0); 

			if (randNum > 30) {

				multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.charLustDefense; 
				charDamageTotal = damageRand * multiplierTotal; 
				charLustTotal = lustRand * multiplierTotal; 
				charDamageTotal = Mathf.Round (charDamageTotal * 100f) / 100f;
				charLustTotal = Mathf.Round (charLustTotal * 100f) / 100f; 
				GameControl.actualHealth =GameControl.actualHealth  - charDamageTotal; 
				GameControl.actualArousal = GameControl.actualArousal + charLustTotal; 


				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The dodo landed on your back, using her velvety feet to rub your torso and waist from her position, as her ass was pressing against your shoulders, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The dodo landed on your back, using her velvety feet to rub your torso and waist from her position, as her ass was pressing against your shoulders, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "Your flying enemy reached you from above, using her legs to fondle your body, rubbing it with her plumed feet, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "Your flying enemy reached you from above, using her legs to fondle your body, rubbing it with her plumed feet, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;


				}
			} 
			else 
			{
				multiplierTotal = multiplier1 + multiplier2 + 1; 
				failDmgRand = failDmgRand * multiplierTotal; 
				failLustRand = failLustRand * multiplierTotal; 

				failDmgRand = Mathf.Round (failDmgRand * 100f) / 100f;
				failLustRand = Mathf.Round (failLustRand * 100f) / 100f; 
				WorldControl.enemyHP = WorldControl.enemyHP - failDmgRand; 
				WorldControl.enemyLust = WorldControl.enemyLust + failLustRand;

				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The dodo tried to land on you, but you pushed her aside and moved in the other direction.\nThe attack did " + failDmgRand + " will damage and increased her lust in " + failLustRand + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "The dodo tried to land on you, but you pushed her aside and moved in the other direction.\nThe attack did " + failDmgRand + " will damage and increased her lust in " + failLustRand + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "Your feathery enemy tried to fondle your body, but you deflected her attempts.\nThe attack did " + failDmgRand +" will damage and increased her lust in " + failLustRand + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "Your feathery enemy tried to fondle your body, but you deflected her attempts.\nThe attack did " + failDmgRand + " will damage and increased her lust in " + failLustRand + " points!"; 
					break;


				}

			}
		} 


		else // Feather Tease - Lust
		{

			Random.InitState (System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 101); 
			damageRand = Random.Range (0, 3);
			lustRand = Random.Range (13, 22);
			multiplier1 = (0.15f); // stat
			multiplier2 = Random.Range (0.0f, 0.7f); // random
			failDmgRand = Random.Range (4,8);
			failLustRand = Random.Range (5, 10); 

			if (randNum > 20) {

				multiplierTotal = multiplier1 + multiplier2 + 1 - WorldControl.charLustDefense; 
				charDamageTotal = damageRand * multiplierTotal; 
				charLustTotal = lustRand * multiplierTotal; 
				charDamageTotal = Mathf.Round (charDamageTotal * 100f) / 100f;
				charLustTotal = Mathf.Round (charLustTotal * 100f) / 100f; 
				GameControl.actualHealth =GameControl.actualHealth  - charDamageTotal; 
				GameControl.actualArousal = GameControl.actualArousal + charLustTotal; 

				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "She got closer to you and teased you with her breasts and arms, using the feathers from the latter to taunt you, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "She got closer to you and teased you with her breasts and arms, using the feathers from the latter to taunt you, increasing your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "She rubbed your body in a sensual manner with her soft feathers from her arms, its delightful touch increases your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "She rubbed your body in a sensual manner with her soft feathers from her arms, its delightful touch increases your will to fuck.\nThe attack did " + charDamageTotal + " will damage and increased your lust in " + charLustTotal + " points!"; 
					break;


				}
			} 
			else 
			{
				multiplierTotal = multiplier1 + multiplier2 + 1; 
				failDmgRand = failDmgRand * multiplierTotal; 
				failLustRand = failLustRand * multiplierTotal; 

				failDmgRand = Mathf.Round (failDmgRand * 100f) / 100f;
				failLustRand = Mathf.Round (failLustRand * 100f) / 100f; 
				WorldControl.enemyHP = WorldControl.enemyHP - failDmgRand; 
				WorldControl.enemyLust = WorldControl.enemyLust + failLustRand;

				randNum = Random.Range (0, 4);
				switch (randNum) {

				case 0:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "She tried to get her feathers to you, but you preferred to avoid her contact, moving away from her.\nShe did to herself " + failDmgRand + " will damage and increased her lust in " + failLustRand + " points!" ; 
					break;
				case 1: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "She tried to get her feathers to you, but you preferred to avoid her contact, moving away from her.\nShe did to herself " + failDmgRand + " will damage and increased her lust in " + failLustRand + " points!"; 
					break;
				case 2:
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "She tried to dive and get to you, but you rolled away to safety.\nShe did to herself " + failDmgRand + " will damage and increased her lust in " + failLustRand + " points!"; 
					break;
				default: 
					WorldControl.charAttackDescription = WorldControl.charAttackDescription + "\n\n" +  "She tried to dive and get to you, but you rolled away to safety.\nShe did to herself " + failDmgRand + " will damage and increased her lust in " + failLustRand + " points!"; 
					break;


				}

			}


		} 


	}








}
