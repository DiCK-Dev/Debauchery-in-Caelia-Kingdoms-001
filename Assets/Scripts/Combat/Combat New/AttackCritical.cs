using UnityEngine;
using System.Collections;

public class AttackCritical : MonoBehaviour {




	public bool critical(NPCData.CharAttacks attackid, float DEFDodge, float randNum){

		if (randNum >= 99) {
			return true; 
		}
		// base dodge is 10 for regular races 
		switch (attackid) {
		case NPCData.CharAttacks.PrecisionStrike:
			if (randNum > 80 + DEFDodge) {return true;}
			return false;
		case NPCData.CharAttacks.HoldLine:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.CombatManuevers:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.ReachingAttack:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.BreakShield:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.Charge:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.WarCry:
			return false; 
		case NPCData.CharAttacks.Disarm:
			if (randNum > 85 + DEFDodge) {return true;}
			return false;  
		case NPCData.CharAttacks.Meditation:
			return false; 
		case NPCData.CharAttacks.PalmStrike:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.FluidStance:
			return false; 
		case NPCData.CharAttacks.UnexpectedGrapple:
			if (randNum > 80 + DEFDodge) {return true;}
			return false;  
		case NPCData.CharAttacks.HulkingPotion:
			return false; 
		case NPCData.CharAttacks.ArousingFumes:
			if (randNum > 85 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.PoisonDarts:
			if (randNum > 85 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.SmokeBombs:
			return false; 
		case NPCData.CharAttacks.ConcussiveStrike:
			if (randNum > 85 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.FoulPlay:
			if (randNum > 85 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.PoisonDagger:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.ShadowStrike:
			if (randNum > 85 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.HitAndRun:
			return false; 
		case NPCData.CharAttacks.CloackAndDagger:
			if (randNum > 75 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.SexyDistraction:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.Smite:
			if (randNum > 85 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.DivineFavor:
			return false; 
		case NPCData.CharAttacks.Banish:
			if (randNum > 85 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.HealingPrayer:
			return false; 
		case NPCData.CharAttacks.Temptation:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.LifeSteal:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.DarkIntervention:
			return false; 
		case NPCData.CharAttacks.MindVision:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.FeralCry:
			return false; 
		case NPCData.CharAttacks.PinDown:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.InescapableGrab:
			if (randNum > 85 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.DominantPresence:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.RecklessCharge:
			if (randNum > 85 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.MercilessAttack:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.BleedingSwipe:
			if (randNum > 85 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.Taunt:
			return false; 
		case NPCData.CharAttacks.ArrowTraps:
			if (randNum > 75 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.Ambush:
			if (randNum > 85 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.TacticalRetreat:
			return false; 
		case NPCData.CharAttacks.Decoy:
			return false; 
		case NPCData.CharAttacks.TakeAim:
			return false; 
		case NPCData.CharAttacks.Headshot:
			if (randNum > 85 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.DoubleShot:
			if (randNum > 90 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.SupressingFire:
			if (randNum > 75 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.LitanyOfPain:
			if (randNum > 85 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.ImplacableSermon:
			return false; 
		case NPCData.CharAttacks.Scourge:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.IronResolve:
			return false; 
		case NPCData.CharAttacks.StunningBlow:
			if (randNum > 85 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.ShieldWall:
			return false; 
		case NPCData.CharAttacks.PepperGrenade:
			if (randNum > 75 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.ShieldCharge:
			if (randNum > 75 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.ElegantStance:
			return false; 
		case NPCData.CharAttacks.HypnoticDance:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.GraciousAttack:
			if (randNum > 75 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.RiskyPerformance:
			if (randNum > 85 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.Striptease:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.CrotchGrab:
			if (randNum > 85 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.ForcedKissing:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.IndecentSmile:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.Concentration:
			return false; 
		case NPCData.CharAttacks.ProtectiveRitual:
			return false; 
		case NPCData.CharAttacks.Hex:
			return false; 
		case NPCData.CharAttacks.IronWill:
			return false; 
		case NPCData.CharAttacks.HuntersMusk:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.AlphasAura:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.Rending:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.FeralBite:
			if (randNum > 85 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.DemonicAura:
			return false; 
		case NPCData.CharAttacks.SuccubusTouch:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.EnticingShow:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.Charm:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.HornyLeap:
			if (randNum > 75 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.BouncyGrab:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.BunnyHump:
			if (randNum > 85 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.MatingSeason:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.EquineCharge:
			if (randNum > 85 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.WildRide:
			if (randNum > 85 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.StallionsMusk:
			if (randNum > 85+ DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.ImpetiousKick:
			if (randNum > 85+ DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.Bash:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.Slash:
			if (randNum > 85 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.HardBlow:
			if (randNum > 85 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.LoudSlap:
			if (randNum > 85 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.PocketSand:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.TakeCover:
			return false; 
		case NPCData.CharAttacks.TripUp:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.Fondling:
			if (randNum > 85 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.BodyShowoff:
			if (randNum > 75 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.PlayfulChase:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.SelfSpanking:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.SeductiveGesture:
			return false; 
		case NPCData.CharAttacks.Heal:
			return false; 
		case NPCData.CharAttacks.IceSpikes:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.FireBall:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.ElectricShock:
			if (randNum > 75 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.AirBlast:
			if (randNum > 70 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.Purification:
			return false; 
		case NPCData.CharAttacks.PerverseVisions:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.MagicBinds:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.EtherealHands:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 
		case NPCData.CharAttacks.ArousingWave:
			if (randNum > 80 + DEFDodge) {return true;}
			return false; 

		default:
			return false; 


		}


	}




}
