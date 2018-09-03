using UnityEngine;
using System.Collections;

public class LustDamage : MonoBehaviour {

	static int iterator; 
	float damage = 0f; 
	int i; 
	bool critfail; 
	bool fail; 
	float attackCost; // how much dmg the character loses if it has an HP cost, or used too if it critically fails. 
	int hashcode = GameControl.playerName.GetHashCode();


	public float attackCalculation(NPCData.CharAttacks attackid, int npcidATT, int npcidDEF, bool ATTretainer, float DEFPhys, float DEFLust, float DEFMag, float DEFDodge, float ATTPhys, float ATTLust, float ATTMag, float ATTMent, float accuracy, bool critical)
	{
		damage = 0f; 
		critfail = false;
		fail = false; 
		attackCost = 0f; 
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 

		if (DEFLust > ATTLust) {
			ATTLust = 0.1f;
			DEFLust = 0f;
		}

		switch (attackid) {

		case NPCData.CharAttacks.PrecisionStrike:
			break;
		case NPCData.CharAttacks.HoldLine:
			break;
		case NPCData.CharAttacks.CombatManuevers:
			break;
		case NPCData.CharAttacks.ReachingAttack:
			break;
		case NPCData.CharAttacks.BreakShield:
			break;
		case NPCData.CharAttacks.Charge:
			break;
		case NPCData.CharAttacks.WarCry:
			attackCost = -10f; 
			break;
		case NPCData.CharAttacks.Disarm:
			break; 
		case NPCData.CharAttacks.Meditation:
			attackCost = Random.Range(-7,-20);
			break;
		case NPCData.CharAttacks.PalmStrike:
			break;
		case NPCData.CharAttacks.FluidStance:
			break;
		case NPCData.CharAttacks.UnexpectedGrapple:
			attackCost = Random.Range (5,10);
			break; 
		case NPCData.CharAttacks.HulkingPotion:
			break;
		case NPCData.CharAttacks.ArousingFumes:
			if (accuracy - DEFDodge >= 10 && accuracy - DEFDodge <= 20) {
				attackCost = Random.Range(5,15);
				fail = true; 
			} else {
				attackCost += Random.Range(10,25);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.DebilitatingFumes:
			break; 
		case NPCData.CharAttacks.PoisonDarts:
			break;
		case NPCData.CharAttacks.SmokeBombs:
			break;
		case NPCData.CharAttacks.ConcussiveStrike:
			break;
		case NPCData.CharAttacks.FoulPlay:
			if (critical) {
				damage = Random.Range(-5,-15) * (Random.Range(0.35f, 0.9f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 40) {
				damage = Random.Range (-5,-10) * (0.1f + (ATTLust - DEFLust )); 
			} 
			break;
		case NPCData.CharAttacks.PoisonDagger:
			break;
		case NPCData.CharAttacks.ShadowStrike:
			break;
		case NPCData.CharAttacks.HitAndRun:
			break;
		case NPCData.CharAttacks.CloackAndDagger:
			break;
		case NPCData.CharAttacks.SexyDistraction:
			attackCost = 10f; 
			if (critical) {
				damage = Random.Range(5,15) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 20) {
				damage = Random.Range (5,10) * (0.1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.Smite:
			break;
		case NPCData.CharAttacks.DivineFavor:
			break;
		case NPCData.CharAttacks.Banish:
			break;
		case NPCData.CharAttacks.HealingPrayer:
			break;
		case NPCData.CharAttacks.Temptation:
			attackCost = 10f; 
			if (critical) {
				damage = Random.Range(15,20) * (Random.Range(0.5f, 1f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 20) {
				damage = Random.Range (15,20) * (0.1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(5,10);
				fail = true; 
			} else {
				attackCost = Random.Range(10,15);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.LifeSteal:
			break;
		case NPCData.CharAttacks.DarkIntervention:
			break;
		case NPCData.CharAttacks.MindVision:
			if (critical) {
				damage = Random.Range(5,10) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 20) {
				damage = Random.Range (5,10) * (0.1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.FeralCry:
			attackCost = 5f; 
			break;
		case NPCData.CharAttacks.PinDown:
			attackCost = 5f; 
			break;
		case NPCData.CharAttacks.InescapableGrab:
			attackCost = 5f;
			break;
		case NPCData.CharAttacks.DominantPresence:
			attackCost = 5f; 
			break;
		case NPCData.CharAttacks.RecklessCharge:
			break;
		case NPCData.CharAttacks.MercilessAttack:
			break;
		case NPCData.CharAttacks.BleedingSwipe:
			break;
		case NPCData.CharAttacks.Taunt:
			break;
		case NPCData.CharAttacks.ArrowTraps:
			break;
		case NPCData.CharAttacks.Ambush:
			break;
		case NPCData.CharAttacks.TacticalRetreat:
			break;
		case NPCData.CharAttacks.Decoy:
			break;
		case NPCData.CharAttacks.TakeAim:
			break;
		case NPCData.CharAttacks.Headshot:
			break;
		case NPCData.CharAttacks.DoubleShot:
			break;
		case NPCData.CharAttacks.SupressingFire:
			break;
		case NPCData.CharAttacks.LitanyOfPain:
			break;
		case NPCData.CharAttacks.ImplacableSermon:
			break;
		case NPCData.CharAttacks.Scourge:
			attackCost = 7f; 
			if (critical) {
				damage = Random.Range(10f,15f) * (Random.Range(0.5f, 0.8f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 20) {
				damage = Random.Range (10f,15f) * (0.1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost += Random.Range(3f,7f);
				fail = true; 
			} else {
				attackCost += Random.Range(7f,12f);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.IronResolve:
			break;
		case NPCData.CharAttacks.StunningBlow:
			break;
		case NPCData.CharAttacks.ShieldWall:
			break;
		case NPCData.CharAttacks.PepperGrenade:
			break;
		case NPCData.CharAttacks.ShieldCharge:
			break;
		case NPCData.CharAttacks.ElegantStance:
			break;
		case NPCData.CharAttacks.HypnoticDance:
			attackCost = 5f;
			if (critical) {
				damage = Random.Range(10,20) * (Random.Range(0.4f, 0.7f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 30) {
				damage = Random.Range (10,15) * (0.1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.GraciousAttack:
			attackCost = 5f;
			if (critical) {
				damage = Random.Range(10,25) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 20) {
				damage = Random.Range (10,20) * (0.1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 5) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.RiskyPerformance:
			attackCost = 10f;
			if (critical) {
				damage = Random.Range(15,30) * (Random.Range(0.5f, 0.8f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 25) {
				damage = Random.Range (15,25) * (0.1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.Striptease:
			attackCost = 5f; 
			if (critical) {
				damage = Random.Range(10,20) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 20) {
				damage = Random.Range (10,20) * (0.1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.CrotchGrab:
			attackCost = 5f; 
			if (critical) {
				damage = Random.Range(15,30) * (Random.Range(0.4f, 0.7f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 40) {
				damage = Random.Range (15,25) * (0.1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 15) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.ForcedKissing:
			attackCost = 10f;
			if (critical) {
				damage = Random.Range(15,25) * (Random.Range(0.25f, 1f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 25) {
				damage = Random.Range (15,20) * (0.7f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.IndecentSmile:
			attackCost = 5f;
			if (critical) {
				damage = Random.Range(5,15) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 15) {
				damage = Random.Range (5,10) * (0.1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 5) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.Concentration:
			break;
		case NPCData.CharAttacks.ProtectiveRitual:
			break;
		case NPCData.CharAttacks.Hex:
			break;
		case NPCData.CharAttacks.IronWill:
			break;
		case NPCData.CharAttacks.HuntersMusk:
			attackCost = 5f;
			if (critical) {
				damage = Random.Range(10,20) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 30) {
				damage = Random.Range (10,20) * (0.1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.AlphasAura:
			if (critical) {
				damage = Random.Range(5,15) * (Random.Range(0.5f, 1f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 20) {
				damage = Random.Range (5,15) * (0.1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.Rending:
			if (critical) {
				damage = Random.Range(10,20) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 20) {
				damage = Random.Range (5,10) * (0.1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.FeralBite:
			break;
		case NPCData.CharAttacks.DemonicAura:
			break;
		case NPCData.CharAttacks.SuccubusTouch:
			attackCost = 5f;
			if (critical) {
				damage = Random.Range(15,20) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 30) {
				damage = Random.Range (10,15) * (0.75f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.EnticingShow:
			attackCost = Random.Range(-5f,-15f);
			if (critical) {
				damage = Random.Range(10,20) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 30) {
				damage = Random.Range (10,15) * (0.6f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(1f,5f);
				fail = true; 
			} else {
				attackCost = Random.Range(5f,10f);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.Charm:
			attackCost = 5f;
			if (critical) {
				damage = Random.Range(5,15) * (Random.Range(0.4f, 0.9f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 40) {
				damage = Random.Range (5,10) * (0.8f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.HornyLeap:
			attackCost = 5f;
			if (critical) {
				damage = Random.Range(5,15) * (Random.Range(0.5f, 0.9f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 20) {
				damage = Random.Range (5,10) * (1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 5) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.BouncyGrab:
			attackCost = 10f;
			if (critical) {
				damage = Random.Range(15,25) * (Random.Range(0.3f, 0.5f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 30) {
				damage = Random.Range (15,20) * (0.1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.BunnyHump:
			attackCost = 10f;
			if (critical) {
				damage = Random.Range(20,35) * (Random.Range(0.2f, 0.4f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 40) {
				damage = Random.Range (15,20) * (0.1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.MatingSeason:
			attackCost = 5f;
			if (critical) {
				damage = Random.Range(15,25) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 25) {
				damage = Random.Range (15,20) * (0.1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.EquineCharge:
			break;
		case NPCData.CharAttacks.WildRide:
			attackCost = 5f;
			if (critical) {
				damage = Random.Range(20,30) * (Random.Range(0.4f, 0.7f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 40) {
				damage = Random.Range (15,25) * (0.7f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 15) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.StallionsMusk:
			attackCost = 5f;
			if (critical) {
				damage = Random.Range(10,15) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 30) {
				damage = Random.Range (5,15) * (0.1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.ImpetiousKick:
			break;
		case NPCData.CharAttacks.Bash:
			break;
		case NPCData.CharAttacks.Slash:
			break;
		case NPCData.CharAttacks.HardBlow:
			break;
		case NPCData.CharAttacks.LoudSlap:
			break;
		case NPCData.CharAttacks.PocketSand:
			break;
		case NPCData.CharAttacks.TakeCover:
			break;
		case NPCData.CharAttacks.TripUp:
			if (critical) {
				damage = Random.Range(10,20) * (Random.Range(0.5f, 0.6f)+ (0.8f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 30) {
				damage = Random.Range (10,20) * (0.8f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.Fondling:
			attackCost = 10f;
			if (critical) {
				damage = Random.Range(25,30) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 40) {
				damage = Random.Range (20,25) * (0.1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 15) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.BodyShowoff:
			attackCost = 2f;
			if (critical) {
				damage = Random.Range(5,15) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 20) {
				damage = Random.Range (5,15) * (0.1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 5) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.PlayfulChase:
			attackCost = 5f;
			if (critical) {
				damage = Random.Range(15,25) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 30) {
				damage = Random.Range (10,20) * (0.1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.SelfSpanking:
			attackCost = -2f;
			if (critical) {
				damage = Random.Range(5,15) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 30) {
				damage = Random.Range (5,10) * (0.1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 10) {
				attackCost = Random.Range(1,3);
				fail = true; 
			} else {
				attackCost = Random.Range(1,5);
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.SeductiveGesture:
			attackCost = 10f;

			break;
		case NPCData.CharAttacks.Heal:
			break;
		case NPCData.CharAttacks.IceSpikes:
			break;
		case NPCData.CharAttacks.FireBall:
			break;
		case NPCData.CharAttacks.ElectricShock:
			break;
		case NPCData.CharAttacks.AirBlast:
			break;
		case NPCData.CharAttacks.Purification:
			attackCost = Random.Range (-10f, -25f);
			break; 
		case NPCData.CharAttacks.PerverseVisions:
			attackCost = 10f;
			if (critical) {
				damage = Random.Range(25,30) * (Random.Range(0.3f, 0.6f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 20) {
				damage = Random.Range (15,25) * (0.1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 5) {
				fail = true; 
			} else {
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.MagicBinds:
			if (critical) {
				damage = Random.Range(10,20) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 30) {
				damage = Random.Range (10,15) * (0.1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 10) {
				fail = true; 
			} else {

				critfail = true;
			}
			break;
		case NPCData.CharAttacks.EtherealHands:
			if (critical) {
				damage = Random.Range(15f,20f) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 25) {
				damage = Random.Range (15f,20f) * (0.1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 10) {
				fail = true; 
			} else {
				critfail = true;
			}
			break;
		case NPCData.CharAttacks.ArousingWave:
			attackCost = 5f;
			if (critical) {
				damage = Random.Range(10,20) * (Random.Range(0.25f, 0.5f)+ (0.1f + (ATTLust - DEFLust ))); // max dmg or something
				break; 
			} else if (accuracy - DEFDodge >= 20) {
				damage = Random.Range (5,15) * (0.1f + (ATTLust - DEFLust )); 
			} else if (accuracy - DEFDodge >= 5) {
				attackCost = Random.Range(3,7);
				fail = true; 
			} else {
				attackCost = Random.Range(7,12);
				critfail = true;
			}
			break;

		default:
			break;
		}






		//RECEIVING END, the one who suffers damage. loop through list with npcidDEF to change HP, lust, etc. 

		if (ATTretainer) {
			i = 0; 
			while (i < NPCCharList.CharMonster.Count) {
				if (NPCCharList.CharMonster [i].charID == npcidDEF) {
					NPCCharList.CharMonster [i].currentArousal += damage; 
					Debug.Log ("mark 1 - damage = " + damage);
					break; 
				}
				i++;
			}
		} else if (npcidDEF >= 10000000) {
			i = 0; 
			while (i < NPCCharList.CharRetainers.Count) {
				if (NPCCharList.CharRetainers [i].charID == npcidDEF) {
					NPCCharList.CharRetainers [i].currentArousal += damage; 
					Debug.Log ("mark 2 - damage = " + damage);

					break; 
				}
				i++;
			}

		} else if (npcidDEF == 0) {
			GameControl.actualArousal += damage; 
			Debug.Log ("mark 3 - damage = " + damage);

		} else {
			while (i < NPCCharList.CharFollower.Count) {
				if (NPCCharList.CharFollower [i].charID == npcidDEF) {
					NPCCharList.CharFollower [i].currentArousal += damage;
					Debug.Log ("mark 4 - damage = " + damage);

					break; 
				}
				i++;
			}
		}


		/*if (ATTretainer) {
			i = 0; 
			while (i < NPCCharList.CharMonster.Count) {
				if (NPCCharList.CharMonster [i].charID == npcidDEF) {
					NPCCharList.CharMonster [i].currentArousal += damage; 
					break; 
				}
				i++;
			}
		} else {
			i = 0; 
			while (i < NPCCharList.CharRetainers.Count) {
				if (NPCCharList.CharRetainers [i].charID == npcidDEF) {
					NPCCharList.CharRetainers [i].currentArousal += damage; 
					break; 
				}
				i++;
			}

		}*/



		//ATTACKER loop through list with npcidaTT to change HP, lust, mana due to the cost of the skill




		if (fail || critfail) {
			return attackCost; 
		}

		return damage; 

	}


}
