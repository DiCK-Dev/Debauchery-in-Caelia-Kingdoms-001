using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic; 

public class LustSet : MonoBehaviour {


	public float damageHP;
	public float damageLust;
	public float costHP;
	public float costLust;
	public int attackType; // 0 to 5
	public string skillName;
	public string skillDescription;
	public float criticalChance;
	public float accuracyAtt;



	public static Dictionary<int, LustSet> LustSetDictionary = new Dictionary<int, LustSet>(); 


	public LustSet(float dmghp, float dmglust, float costhp, float costlust, int attacktype, string skillname, string skilldescription, float criticalchance, float accuracyatt)
	{
		damageHP = dmghp; // base damage
		damageLust = dmglust; // base damage
		costHP = costhp; //  you lose or earn hp by using this
		costLust = costlust;  // you lose or earny hp by using this 
		attackType = attacktype; // type, from 0 to 6, 0 is normal  
		skillName = skillname;  // name
		skillDescription = skilldescription; // for the hover
		criticalchance = criticalChance; // critical chance 
		accuracyAtt = accuracyatt;  // chance to hit 



	}




	void Awake ()
	{
		LustSet skill0 = new LustSet (0, 0, 0, 0, 1, "Skill 0", "Error ", 0f, 0f );
		LustSetDictionary.Add (0, skill0);

		// 100  Flirty
		LustSet skillLust100 = new LustSet (0, 15, 0, 0, 1, "Indecent smile", "Low lust damage, at no cost but high accuracy.", 0.1f, 0.9f );
		LustSetDictionary.Add (100, skillLust100); // low critical damage

		LustSet skillLust110 = new LustSet (5, 20, 0, 5, 1, "Skin-show", "You reveal enough to tease, doing normal lust damage. Cost 5 will. ", 0.15f, 0.85f );
		LustSetDictionary.Add (110, skillLust110);

		LustSet skillLust120 = new LustSet (0, 25, 10, 0, 1, "Trip up", "You “fall”, revealing a little too much. Good lust damage. Cost 10 will." , 0.2f, 0.8f );
		LustSetDictionary.Add (120, skillLust120);

		LustSet skillLust130 = new LustSet (20, 35, 20, 10, 1, "Playful chase", "It take the enemy a minute to realize you are playing around with him. Great lust damage. Cost: 20 Will, 10 lust", 0.2f, 0.85f );
		LustSetDictionary.Add (130, skillLust130);

		// 200 Enticing
		LustSet skillLust200 = new LustSet (0, 15, 0, 5, 1, "Perfume", "You use a perfume to charm your opponent. Low lust damage, high critical. Cost: 5 Lust. ", 0.25f, 0.8f );
		LustSetDictionary.Add (200, skillLust200);

		LustSet skillLust210 = new LustSet (5, 25, 10, 5, 1, "Veil dance", "Moderate lust attack and high critical but with low accuracy. Cost: 5 Will, 5 Lust.", 0.2f, 0.7f );
		LustSetDictionary.Add (210, skillLust210);

		LustSet skillLust220 = new LustSet (10, 30, 15, 5, 1, "Self spanking", "Strong and reliable but expensive lust attack. Cost: 15 will, 5 lust ", 0.15f, 0.9f );
		LustSetDictionary.Add (220, skillLust220);

		LustSet skillLust230 = new LustSet (0, 45, 0, 20, 1, "Fondling", "You touch yourself, exciting both you and the enemy. Cost: 20 lust.", 0.1f, 0.8f );
		LustSetDictionary.Add (230, skillLust230);

		// 300 exhibitionist 

		LustSet skillLust300 = new LustSet (0, 20, 0, 5, 1, "Flashy bits", "Normal and consistent lust damage. Cost: 5 will", 0.1f, 0.9f );
		LustSetDictionary.Add (300, skillLust300);

		LustSet skillLust310 = new LustSet (5, 35, 10, 5, 1, "Striptease", "Very random lust damage that can have high critical damage. Cost: 10 will, 5 lust", 0.1f, 0.8f );
		LustSetDictionary.Add (310, skillLust310);

		LustSet skillLust320 = new LustSet (0, 40, 15, 10, 1, "Crotch strip", "High lust damage but pretty expensive. 15 will, 10 lust", 0.1f, 0.85f );
		LustSetDictionary.Add (320, skillLust320);


		LustSet skillLust330 = new LustSet (5, 60, 15, 15, 1, "Full moon", "Exceptional critical damage, but low accuracy. Very risky. Cost: 15 will, 15 lust ", 0.2f, 0.65f );
		LustSetDictionary.Add (330, skillLust330);

		// 400 Dominant

		LustSet skillLust400 = new LustSet (20, 0, 5, 0, 1, "Staredown", "Normal will damage, with good critical damage. Cost: 5 will", 0.05f, 0.85f );
		LustSetDictionary.Add (400, skillLust400);

		LustSet skillLust410 = new LustSet (30, 5, 15, 0, 1, "Humiliation", "Good will damage, but can backfire hard. Cost: 15 will", 0.1f, 0.8f );
		LustSetDictionary.Add (410, skillLust410);

		LustSet skillLust420 = new LustSet (20, 25, 10, 10, 1, "Showoff", "Decent will and lust damage, cost: 10 will, 10 lust. ", 0.1f, 0.8f );
		LustSetDictionary.Add (420, skillLust420);

		LustSet skillLust430 = new LustSet (50, 5, 20, 10, 1, "Command", "Very strong will damage, but somewhat low accuracy. Risky. Cost 20 will, 10 lust.. ", 0.2f, 0.75f );
		LustSetDictionary.Add (430, skillLust430);

		// 500 Slutty

		LustSet skillLust500 = new LustSet (0, 25, 0, 5, 1, "Teasing lick", "decent lust damage with low accuracy. Cost: 5 lust. ", 0.1f, 0.75f );
		LustSetDictionary.Add (500, skillLust500);

		LustSet skillLust510 = new LustSet (5, 30, 5, 10, 1, "Crotch grab", "Great lust damage and great critical, but high backfire if misses. Cost: 5 will, 10 lust", 0.1f, 0.8f );
		LustSetDictionary.Add (510, skillLust510);

		LustSet skillLust520 = new LustSet (15, 30, 10, 15, 1, "Boddy rubbing", "Good consistent lust damage, low critical chance. Cost: 5 will, 15 lust. ", 0.05f, 0.85f );
		LustSetDictionary.Add (520, skillLust520);

		LustSet skillLust530 = new LustSet (10, 45, 15, 15, 1, "Pervert show", "High but costly lust damage. Cost: 15 will, 15 lust.", 0.1f, 0.8f );
		LustSetDictionary.Add (530, skillLust530);

		// 600
		LustSet skillLust600 = new LustSet (25, 5, 20, 35, 1, "Groin shoving", "Decent will damage and some lust damage. Cost: 10 lust", 0.2f, 0.85f );
		LustSetDictionary.Add (600, skillLust600);

		LustSet skillLust610 = new LustSet (20, 0, 20, 35, 1, "Hold fast", "Normal will damage, can stun. Cost: 10 lust", 0.2f, 0.8f );
		LustSetDictionary.Add (610, skillLust610);

		LustSet skillLust620 = new LustSet (30, 5, 20, 35, 1, "Forced kissing", "Good will damage, but increases your lust. Cost: 15 lust ", 0.05f, 0.8f );
		LustSetDictionary.Add (620, skillLust620);

		LustSet skillLust630 = new LustSet (40, 15, 20, 35, 1, "Coerced touch", "Great will damage and some lust, critical miss hurt hard. Cost: 10 will, 20 lust" , 0.1f, 0.85f );
		LustSetDictionary.Add (630, skillLust630);




	}

}
