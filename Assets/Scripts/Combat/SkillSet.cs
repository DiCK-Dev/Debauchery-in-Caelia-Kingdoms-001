using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class SkillSet : MonoBehaviour {

	public float damageHP;
	public float damageLust;
	public float costHP;
	public float costLust;
	public int attackType; // 0 to 5
	public string skillName;
	public string skillDescription;
	public float criticalChance;
	public float accuracyAtt;


	public static Dictionary<int, SkillSet> skillSetDictionary = new Dictionary<int, SkillSet>(); // dictionary


	public SkillSet(float dmghp, float dmglust, float costhp, float costlust, int attacktype, string skillname, string skilldescription, float criticalchance, float accuracyatt  )
	{
		damageHP = dmghp; // base damage
		damageLust = dmglust; // base damage
		costHP = costhp; //  you lose or earn hp by using this
		costLust = costlust;  // you lose or earny hp by using this 
		attackType = attacktype; // not in use anymore 
		skillName = skillname;  // name
		skillDescription = skilldescription; // for the hover
		criticalchance = criticalChance; // critical chance - not in use here 
		accuracyAtt = accuracyatt;  // chance to hit  - not in use here 

	}
		

	void Awake ()
	{
		// 0 skills - JUST FOR TESTING AND AVOID BUGS
		SkillSet skill0 = new SkillSet (0, 0, 0, 0, 0, " ", "skill 0 - error ", 0, 0 );
		skillSetDictionary.Add (0, skill0);

		// 100 skills - BALANCED
		SkillSet skill100 = new SkillSet (22, 0, 0, 0, 0, "Fast chop", "Balanced and consistent will damage, with low critical. No cost.", 0.1f, 0.85f );
		skillSetDictionary.Add (100, skill100);


		SkillSet skill110 = new SkillSet (20, 0, 0, 10, 0, "Healing rub", "Recover health but rises your lust. Cost: 10 lust.", 0.2f, 1 );
		skillSetDictionary.Add (110, skill110);

		SkillSet skill120 = new SkillSet (15, 10, 5, 5, 0, "Pin down", "Balanced will and lust damage with small chance of stun. Cost: 5 will, 5 lust.", 0.15f, 0.85f );
		skillSetDictionary.Add (120, skill120);

		SkillSet skill130 = new SkillSet (25, 5, 5, 15, 0, "Suplex", "Strong will damage with high chance of stun. Cost 5 will, 15 lust.", 0.3f, 0.85f );
		skillSetDictionary.Add (130, skill130);

		// 200 skills - MARTIAL ARTS
		SkillSet skill200 = new SkillSet (12, 10, 0, 0, 0, "High kick", "Balanced attack with both will and lust damage. No cost.", 0.15f, 0.85f );
		skillSetDictionary.Add (200, skill200);

		SkillSet skill210 = new SkillSet (20, 15, 5, 5, 0, "Flash kick", "A strong kick that also shows a little too much. Cost: 5 will, 5 lust ", 0.2f, 0.80f );
		skillSetDictionary.Add (210, skill210);

		SkillSet skill220 = new SkillSet (15, 5, 0, 10, 0, "Crotch toss", "Low accuracy, but high critical damage. Cost: 10 Lust.", 0.3f, 0.6f );
		skillSetDictionary.Add (220, skill220);

		SkillSet skill230 = new SkillSet (35, 15, 15, 15, 0, "Chokehold", "Very strong will damage that also increases the lust of both. Cost: 15 Will, 15 Lust", 0.1f, 0.8f );
		skillSetDictionary.Add (230, skill230);

		// 300 skills - Berserker
		SkillSet skill300 = new SkillSet (25, 5, 10, 0, 0, "Bodyslam", "Medium damage with lust damage. Cost: 10 will.", 0.15f, 0.85f );
		skillSetDictionary.Add (300, skill300);

		SkillSet skill310 = new SkillSet (30, 0, 0, 15, 0, "Carnal Rage", "Recovers 30 will but rises 15 lust.", 0.1f, 1f );
		skillSetDictionary.Add (310, skill310);

		SkillSet skill320 = new SkillSet (30, 5, 5, 10, 1, "Bear hug", "Strong will damage with low accuracy. If it fails it increases your lust. Cost: 5 will, 10 lust.", 0.1f, 0.7f );
		skillSetDictionary.Add (320, skill320);

		SkillSet skill330 = new SkillSet (40, 10, 15, 15, 1, "Reckless biting", "A very strong will that may stun the enemy. Cost: 15 will, 15 lust.", 0.15f, 0.8f );
		skillSetDictionary.Add (330, skill330);

		// 400 skills Alchemy

		SkillSet skill400 = new SkillSet (5, 20, 0, 0, 1, "Lust potion", "Good lust damage but low will damage. Critical failure does its damage to you. Cost 0.", 0.2f, 0.75f );
		skillSetDictionary.Add (400, skill400);

		SkillSet skill410 = new SkillSet (15, 15, 0, 0, 1, "Erotic Oils", "Very risky skill, only does critical hit but low accuracy, but good mixed damage. Cost: 0.", 0.70f, 0.70f );
		skillSetDictionary.Add (410, skill410);

		SkillSet skill420 = new SkillSet (10, 10, 0, 5, 1, "Sensitivity Dart", "Low will and lust damage, but critical hit increases the damage of your lust skills for the rest of the battle. Cost: 5 Lust.", 0.2f, 0.75f );
		skillSetDictionary.Add (420, skill420);

		SkillSet skill430 = new SkillSet (0, 40, 0, 20, 1, "Nympho concoction", "Very powerful potion, its fumes increase the lust of everyone around, even if it miss. Cost: 20 Lust", 0.1f, 0.7f );
		skillSetDictionary.Add (430, skill430);

		// 500 trickster
		SkillSet skill500 = new SkillSet (10, 10, 0, 5, 1, "Sabotage", "Low lust and will damage but high critical. Cost: 0. ", 0.35f, 0.8f );
		skillSetDictionary.Add (500, skill500);

		SkillSet skill510 = new SkillSet (15, 15, 0, 0, 1, "Bravery", "It succeeds you regain will and reduce lust, but you lose will if it faills. ", 0.15f, 0.8f );
		skillSetDictionary.Add (510, skill510);

		SkillSet skill520 = new SkillSet (30, 10, 0, 10, 1, "Surprise grab", "Strong will damage with low accuracy but high critical. Cost: 10 Lust", 0.3f, 0.75f );
		skillSetDictionary.Add (520, skill520);

		SkillSet skill530 = new SkillSet (35, 10, 10, 20, 1, "Innocent strike", "You deceive and taunt your opponent into attacking you, dealing a surprise attack, high critical. Cost: 10 will, 20 lust.", 0.3f, 0.8f );
		skillSetDictionary.Add (530, skill530);

		// 600 diplomat
		SkillSet skill600 = new SkillSet (15, 5, 0, 0, 1, "Soothing Message", "Mix low damage with high accuracy and no cost.", 0.2f, 0.9f );
		skillSetDictionary.Add (600, skill600);

		SkillSet skill610 = new SkillSet (0, 15, 10, 0, 1, "Lewd taunt", "Low lust damage, if critical increases combat skill damage for the rest of the battle. Cost: 10 will", 0.25f, 0.85f );
		skillSetDictionary.Add (610, skill610);

		SkillSet skill620 = new SkillSet (35, 5, 0, 20, 1, "Diplomatic immunity", "Strong damage to will to fight, but the powerplay increases your lust. Cost: 20 Lust", 0.1f, 0.8f );
		skillSetDictionary.Add (620, skill620);

		SkillSet skill630 = new SkillSet (15, 35, 15, 15, 1, "Erotic story", "High lust damage and moderate will damage. Cost: 15 will, 15 lust.", 0.2f, 0.9f );
		skillSetDictionary.Add (630, skill630);
		


	}
}
