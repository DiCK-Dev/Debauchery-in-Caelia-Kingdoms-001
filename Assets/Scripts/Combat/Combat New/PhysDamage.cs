using UnityEngine;
using System.Collections;

public class PhysDamage : MonoBehaviour {

	static int iterator; 
	float damage = 0f; 
	int i; 
	float manaCost = 0f; 
	bool critfail; 
	bool fail; 
	float attackCost; // how much dmg the character loses if it has an HP cost, or used too if it critically fails. 
	int hashcode = GameControl.playerName.GetHashCode();


	public float attackCalculation(NPCData.CharAttacks attackid, int npcidATT, int npcidDEF, bool ATTAlly, float DEFPhys, float DEFLust, float DEFMag, float DEFDodge, float ATTPhys, float ATTLust, float ATTMent, float ATTMag, float accuracy, bool critical)
	{
		Debug.Log ("DEFPhys is " + DEFPhys.ToString ());
		Debug.Log ("ATTphys is " + ATTPhys.ToString ());
		damage = 0f; 
		critfail = false;
		fail = false; 
		iterator += 1;
		manaCost = 0f; 
		attackCost = 0f; 
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		if (DEFPhys > ATTPhys) {
			ATTPhys = 0.1f;
			DEFPhys = 0.0f;
		}

		switch (attackid) {
		case NPCData.CharAttacks.PrecisionStrike:
			if (critical) {
				damage = Random.Range (15f, 20f) * (Random.Range (1.5f, 2.0f) + (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 20) {
				damage = Random.Range (15f, 20f) * (0.5f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost += Random.Range (3, 7);
				fail = true; 
			} else {
				attackCost += Random.Range (7, 12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.HoldLine:
			damage = 0f; 
			attackCost = 5f; 
			break;
		case NPCData.CharAttacks.CombatManuevers:
			damage = 0f;
			attackCost = 5f; 
			break;
		case NPCData.CharAttacks.ReachingAttack:
			if (critical) {
				damage = Random.Range(10,15) * (Random.Range(0.5f, 1f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 25) {
				damage = Random.Range (10,15) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost += Random.Range(3,7);
				fail = true; 
			} else {
				attackCost += Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.BreakShield:
			if (critical) {
				damage = Random.Range(25,30) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 40) {
				damage = Random.Range (25,30) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 15) {
				attackCost += Random.Range(3,7);
				fail = true; 
			} else {
				attackCost += Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.Charge:
			if (critical) {
				damage = Random.Range(5,10) * (Random.Range(0.5f, 1f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 15) {
				damage = Random.Range (5,10) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 5) {
				attackCost += Random.Range(3,7);
				fail = true; 
			} else {
				attackCost += Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.WarCry:
			attackCost = Random.Range (-5f,-15f);
			break;
		case NPCData.CharAttacks.Disarm:
			if (critical) {
				damage = Random.Range(5,10) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 40) {
				damage = Random.Range (5,10) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 15) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break; 
		case NPCData.CharAttacks.Meditation:
			attackCost = Random.Range (-7f,-20f);
			break;
		case NPCData.CharAttacks.PalmStrike:
			if (critical) {
				damage = Random.Range(5,10) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 20) {
				damage = Random.Range (5,10) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 5) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.FluidStance:
			break;
		case NPCData.CharAttacks.UnexpectedGrapple:
			if (critical) {
				damage = Random.Range(10,15) * (Random.Range(0.35f, 0.7f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 30) {
				damage = Random.Range (10,15) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break; 
		case NPCData.CharAttacks.HulkingPotion:
			break;
		case NPCData.CharAttacks.ArousingFumes:
			break;
		case NPCData.CharAttacks.DebilitatingFumes:
			if (accuracy - DEFDodge >= 10 && accuracy - DEFDodge <= 20) {
				attackCost = Random.Range(5,15);
				fail = true; 
			} else {
				attackCost += Random.Range(10,20);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.PoisonDarts:
			if (critical) {
				damage = Random.Range(10,15) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 40) {
				damage = Random.Range (5,10) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 15) {
				attackCost = Random.Range(7,10);
				fail = true; 
			} else {
				attackCost = Random.Range(10,15);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.SmokeBombs:
			break;
		case NPCData.CharAttacks.ConcussiveStrike:
			if (critical) {
				damage = Random.Range(10,15) * (Random.Range(0.5f, 1f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 40) {
				damage = Random.Range (5,10) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 15) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.FoulPlay:
			if (critical) {
				damage = Random.Range(7,20) * (Random.Range(0.35f, 0.9f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 40) {
				damage = Random.Range (5,10) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 15) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.PoisonDagger:
			if (critical) {
				damage = Random.Range(10,20) * (Random.Range(0.6f, 1f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 30) {
				damage = Random.Range (10,15) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.ShadowStrike:
			if (critical) {
				damage = Random.Range(25,30) * (Random.Range(0.5f, 1f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 30) {
				damage = Random.Range (15,20) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(10,15);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.HitAndRun:
			if (critical) {
				damage = Random.Range(5,10) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 30) {
				damage = Random.Range (5,10) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.CloackAndDagger:
			if (critical) {
				damage = Random.Range(10,15) * (Random.Range(0.3f, 0.7f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 20) {
				damage = Random.Range (10,15) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 5) {
				attackCost = Random.Range(5,12);
				fail = true; 
			} else {
				attackCost = Random.Range(10,15);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.SexyDistraction:
			break;
		case NPCData.CharAttacks.Smite:
			if (critical) {
				damage = Random.Range(25,30) * (Random.Range(0.3f, 0.6f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 40) {
				damage = Random.Range (20,25) * (0.7f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 15) {
				attackCost = Random.Range(8,12);
				fail = true; 
			} else {
				attackCost = Random.Range(12,16);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.DivineFavor:
			break;
		case NPCData.CharAttacks.Banish:
			attackCost = 5f;
			if (critical) {
				damage = Random.Range(25,30) * (Random.Range(0.25f, 1.5f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 45) {
				damage = Random.Range (20,30) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 15) {
				attackCost += Random.Range(5,15);
				fail = true; 
			} else {
				attackCost += Random.Range(15,20);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.HealingPrayer:
			attackCost = -5f;
			break;
		case NPCData.CharAttacks.Temptation:
			break;
		case NPCData.CharAttacks.LifeSteal:
			if (critical) {
				damage = Random.Range(10,20) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				attackCost = -damage; 
				break; 
			} else if (accuracy - DEFDodge >= 40) {
				damage = Random.Range (5,15) * (0.1f + (ATTPhys - DEFPhys)); 
				attackCost = -damage;
			} else if (accuracy - DEFDodge >= 15) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.DarkIntervention:
			attackCost = 10f;
			break;
		case NPCData.CharAttacks.MindVision:
			attackCost = 10f; 
			break;
		case NPCData.CharAttacks.FeralCry:
			break;
		case NPCData.CharAttacks.PinDown:
			if (critical) {
				damage = Random.Range(5,10) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 30) {
				damage = Random.Range (5,10) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.InescapableGrab:
			if (critical) {
				damage = Random.Range(5,10) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 40) {
				damage = Random.Range (5,10) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 15) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.DominantPresence:
			break;
		case NPCData.CharAttacks.RecklessCharge:
			if (critical) {
				damage = Random.Range(20f,25f) * (Random.Range(0.5f, 0.8f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 40) {
				damage = Random.Range (20f,25f) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 15) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.MercilessAttack:
			if (critical) {
				damage = Random.Range(15,20) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 30) {
				damage = Random.Range (10,15) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.BleedingSwipe:
			if (critical) {
				damage = Random.Range(5,10) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 40) {
				damage = Random.Range (5,10) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 15) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.Taunt:
			break;
		case NPCData.CharAttacks.ArrowTraps:
			if (critical) {
				damage = Random.Range(15,20) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 20) {
				damage = Random.Range (15,20) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.Ambush:
			if (critical) {
				damage = Random.Range(15,25) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 30) {
				damage = Random.Range (15,20) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 15) {
				attackCost = Random.Range(15,20);
				fail = true; 
			} else {
				attackCost = Random.Range(15,25);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.TacticalRetreat:
			break;
		case NPCData.CharAttacks.Decoy:
			break;
		case NPCData.CharAttacks.TakeAim:
			break;
		case NPCData.CharAttacks.Headshot:
			if (critical) {
				damage = Random.Range(25,30) * (Random.Range(0.5f, 1.5f)+ (0.2f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 40) {
				damage = Random.Range (20,30) * (0.2f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 15) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.DoubleShot:
			if (critical) {
				damage = Random.Range(20,30) * (Random.Range(0.3f, 0.6f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 30) {
				damage = Random.Range (15,20) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.SupressingFire:
			if (critical) {
				damage = Random.Range(5,10) * (Random.Range(0.2f, 0.4f)+ (0.3f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 20) {
				damage = Random.Range (3,8) * (0.3f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 5) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.LitanyOfPain:
			if (critical) {
				damage = Random.Range(12,20) * (Random.Range(0.2f, 0.4f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 20) {
				damage = Random.Range (10,20) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 5) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.ImplacableSermon:
			break;
		case NPCData.CharAttacks.Scourge:
			attackCost = 5f;
			if (critical) {
				damage = Random.Range(10,15) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 20) {
				damage = Random.Range (10,15) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 5) {
				attackCost += Random.Range(3,7);
				fail = true; 
			} else {
				attackCost += Random.Range(5,10);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.IronResolve:
			attackCost = 5f; 
			break;
		case NPCData.CharAttacks.StunningBlow:
			if (critical) {
				damage = Random.Range(5,10) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 40) {
				damage = Random.Range (5,10) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 15) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.ShieldWall:
			break;
		case NPCData.CharAttacks.PepperGrenade:
			attackCost = 5f; 
			break;
		case NPCData.CharAttacks.ShieldCharge:
			if (critical) {
				damage = Random.Range(5,10) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 20) {
				damage = Random.Range (5,10) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 5) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.ElegantStance:
			break;
		case NPCData.CharAttacks.HypnoticDance:
			break;
		case NPCData.CharAttacks.GraciousAttack:
			if (critical) {
				damage = Random.Range(15,20) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 20) {
				damage = Random.Range (5,10) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 5) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.RiskyPerformance:
			break;
		case NPCData.CharAttacks.Striptease:
			break;
		case NPCData.CharAttacks.CrotchGrab:
			break;
		case NPCData.CharAttacks.ForcedKissing:
			break;
		case NPCData.CharAttacks.IndecentSmile:
			break;
		case NPCData.CharAttacks.Concentration:
			break;
		case NPCData.CharAttacks.ProtectiveRitual:
			break;
		case NPCData.CharAttacks.Hex:
			attackCost = 5f; 
			Debug.Log ("hex activated in phys damage with attackCost of " + attackCost);
			break;
		case NPCData.CharAttacks.IronWill:
			break;
		case NPCData.CharAttacks.HuntersMusk:
			break;
		case NPCData.CharAttacks.AlphasAura:
			attackCost = 5f;
			break;
		case NPCData.CharAttacks.Rending:
			if (critical) {
				damage = Random.Range(10,15) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 20) {
				damage = Random.Range (5,10) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 5) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.FeralBite:
			if (critical) {
				damage = Random.Range(20,25) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 25) {
				damage = Random.Range (15,20) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.DemonicAura:
			break;
		case NPCData.CharAttacks.SuccubusTouch:
			break;
		case NPCData.CharAttacks.EnticingShow:
			break;
		case NPCData.CharAttacks.Charm:
			break;
		case NPCData.CharAttacks.HornyLeap:
			break;
		case NPCData.CharAttacks.BouncyGrab:
			break;
		case NPCData.CharAttacks.BunnyHump:
			break;
		case NPCData.CharAttacks.MatingSeason:
			break;
		case NPCData.CharAttacks.EquineCharge:
			if (critical) {
				damage = Random.Range(20,30) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 40) {
				damage = Random.Range (20,25) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 15) {
				attackCost = Random.Range(5,15);
				fail = true; 
			} else {
				attackCost = Random.Range(15,25);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.WildRide:
			attackCost = 5f;
			if (critical) {
				damage = Random.Range(20,30) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 40) {
				damage = Random.Range (15,25) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 15) {
				attackCost += Random.Range(5,10);
				fail = true; 
			} else {
				attackCost += Random.Range(15,20);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.StallionsMusk:
			break;
		case NPCData.CharAttacks.ImpetiousKick:
			if (critical) {
				damage = Random.Range(15,30) * (Random.Range(0.3f, 0.6f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 40) {
				damage = Random.Range (15,20) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 15) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.Bash:
			if (critical) {
				damage = Random.Range(15,20) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 20) {
				damage = Random.Range (15,20) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 5) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.Slash:
			if (critical) {
				damage = Random.Range(25,30) * (Random.Range(0.5f, 0.8f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 40) {
				damage = Random.Range (20,30) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 15) {
				attackCost = Random.Range(3,10);
				fail = true; 
			} else {
				attackCost = Random.Range(10,15);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.HardBlow:
			if (critical) {
				damage = Random.Range(15,20) * (Random.Range(0.5f, 1f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 25) {
				damage = Random.Range (15,20) * (0.1f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.LoudSlap:
			if (critical) {
				damage = Random.Range(10,20) * (Random.Range(0.2f, 0.5f)+ (0.1f + (ATTPhys - DEFPhys))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 30) {
				damage = Random.Range (10,20) * (0.2f + (ATTPhys - DEFPhys)); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.PocketSand:
			break;
		case NPCData.CharAttacks.TakeCover:
			break;
		case NPCData.CharAttacks.TripUp:
			break;
		case NPCData.CharAttacks.Fondling:
			break;
		case NPCData.CharAttacks.BodyShowoff:
			break;
		case NPCData.CharAttacks.PlayfulChase:
			break;
		case NPCData.CharAttacks.SelfSpanking:
			break;
		case NPCData.CharAttacks.SeductiveGesture:
			break;
		case NPCData.CharAttacks.Heal:
			manaCost = 20f; 
			attackCost = Random.Range(-10f,-25f);
			break;
		case NPCData.CharAttacks.IceSpikes:
			manaCost = 20f;
			if (critical) {
				damage = Random.Range(20,25) * (Random.Range(0.3f, 0.6f)+ (1f + (DEFMag + ATTMag))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 30) {
				damage = Random.Range (20,25) * (1f + (DEFMag + ATTMag)); 
			} else if (accuracy - DEFDodge >= 10) {
				fail = true; 
			} else {
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.FireBall:
			manaCost = 25;
			if (critical) {
				damage = Random.Range(20,30) * (Random.Range(0.3f, 0.6f)+ (1f + (DEFMag + ATTMag))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 30) {
				damage = Random.Range (20,30) * (1f + (DEFMag + ATTMag)); 
			} else if (accuracy - DEFDodge >= 10) {
				fail = true; 
			} else {
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.ElectricShock:
			manaCost = 15f;
			if (critical) {
				damage = Random.Range(15,20) * (Random.Range(0.3f, 0.6f)+ (1f + (DEFMag + ATTMag))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 30) {
				damage = Random.Range (15,20) * (1f + (DEFMag + ATTMag)); 
			} else if (accuracy - DEFDodge >= 10) {
				fail = true; 
			} else {
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.AirBlast:
			manaCost = 10f; 
			if (critical) {
				damage = Random.Range(10,20) * (Random.Range(0.3f, 0.6f)+ (1f + (DEFMag + ATTMag))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 15) {
				damage = Random.Range (10,20) * (1f + (DEFMag + ATTMag)); 
			} else if (accuracy - DEFDodge >= 5) {
				fail = true; 
			} else {
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.Purification:
			manaCost = 20f;
			break;
		case NPCData.CharAttacks.PerverseVisions:
			manaCost = 30f;
			break;
		case NPCData.CharAttacks.MagicBinds:
			manaCost = 15f;
			break;
		case NPCData.CharAttacks.EtherealHands:
			manaCost = 20f;
			break;
		case NPCData.CharAttacks.ArousingWave:
			manaCost = 15f; 
			break;

		default:
			break;

		}

		//RECEIVING END, the one who suffers damage. loop through list with npcidDEF to change HP, lust, etc. 
		if (ATTAlly) {
			i = 0; 
			while (i < NPCCharList.CharMonster.Count) {
				if (NPCCharList.CharMonster [i].charID == npcidDEF) {
					NPCCharList.CharMonster [i].currentHealth -= damage; 
					Debug.Log ("mark 1 - damage = " + damage);
					break; 
				}
				i++;
			}
		} else if (npcidDEF >= 10000000) {
			i = 0; 
			while (i < NPCCharList.CharRetainers.Count) {
				if (NPCCharList.CharRetainers [i].charID == npcidDEF) {
					NPCCharList.CharRetainers [i].currentHealth -= damage; 
					Debug.Log ("mark 2 - damage = " + damage);

					break; 
				}
				i++;
			}
			
		} else if (npcidDEF == 0) {
			GameControl.actualHealth -= damage; 
			Debug.Log ("mark 3 - damage = " + damage);

		} else {
			while (i < NPCCharList.CharFollower.Count) {
				if (NPCCharList.CharFollower [i].charID == npcidDEF) {
					NPCCharList.CharFollower [i].currentHealth -= damage;
					Debug.Log ("mark 4 - damage = " + damage);

					break; 
				}
				i++;
			}
		}

		//ATTACKER loop through list with npcidaTT to change HP, lust, mana due to the cost of the skill
			if (ATTAlly && npcidATT >= 10000000) {
				i = 0; 
				while (i < NPCCharList.CharRetainers.Count) {
					if (NPCCharList.CharRetainers [i].charID == npcidATT) {
					Debug.Log ("mark 5 - attack Cost= " + attackCost);

						NPCCharList.CharRetainers [i].currentHealth -= attackCost; 
					if (NPCCharList.CharRetainers [i].currentMP < manaCost) {
						NPCCharList.CharRetainers [i].currentHealth += (NPCCharList.CharRetainers [i].currentMP - manaCost);
						NPCCharList.CharRetainers [i].currentMP = 0; 
					}
						break; 
					}
					i++;
				}
			} else if (ATTAlly && npcidATT == 0) {
				Debug.Log ("mark 6 - attack Cost= " + attackCost);

				if (GameControl.actualMP < manaCost) {
					GameControl.actualHealth += (GameControl.actualMP - manaCost);
					GameControl.actualMP = 0; 
				}
				GameControl.actualHealth -= attackCost;

			}else if (ATTAlly){
			i = 0; 
			while (i < NPCCharList.CharFollower.Count) {
				if (NPCCharList.CharFollower [i].charID == npcidATT) {
					Debug.Log ("mark 7 - attack Cost= " + attackCost);
		
					NPCCharList.CharFollower [i].currentHealth -= attackCost; 
					if (NPCCharList.CharFollower [i].currentMP < manaCost) {
						NPCCharList.CharFollower [i].currentHealth += (NPCCharList.CharFollower [i].currentMP - manaCost);
						NPCCharList.CharFollower [i].currentMP = 0; 
					}
					break; 
				}
				i++;
			}

			}else {
			i = 0; 
			while (i < NPCCharList.CharMonster.Count) {
				if (NPCCharList.CharMonster [i].charID == npcidATT) {
					Debug.Log ("mark 8 - attack Cost= " + attackCost);

					NPCCharList.CharMonster [i].currentHealth -= attackCost; 
					if (NPCCharList.CharMonster [i].currentMP < manaCost) {
						NPCCharList.CharMonster [i].currentHealth += (NPCCharList.CharMonster[i].currentMP - manaCost);
						NPCCharList.CharMonster[i].currentMP = 0; 
					}
					break; 
				}
				i++;
			}
		}



		if (fail || critfail) {
			Debug.Log ("mark 9 - returning attack Cost = " + attackCost);
			return attackCost; 

		}
		Debug.Log ("mark 10 - returning damage = " + damage);
		return damage; 

	}

}
