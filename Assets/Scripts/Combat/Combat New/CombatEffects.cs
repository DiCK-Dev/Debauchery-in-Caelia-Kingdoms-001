using UnityEngine;
using System.Collections;

public class CombatEffects {

	int i;
	static int iterator; 
	float accuracy; 
	int hashcode = GameControl.playerName.GetHashCode();

	public int cooldown; 
	float healthMod;
	float lustMod;
	float physDMG = 0; 
	float lustDMG = 0; 
	float magDMG = 0;
	float physDEF = 0;
	float lustDEF = 0;
	float magDEF = 0;
	float dodge = 0;
	bool stunned = false; 


	public enum EFFECTS
	{
		STUN, POISONDMG, POISONLUST, DEFRED, DODGERED, MRRED, PHYSATTRED, LUSTATTRED, MAGATTRED, DEFBUFF, DODGEBUFF, MRBUFF, PHYSATTBUFF, LUSTATTBUFF, MAGATTBUFF 
	};
	public EFFECTS effect; 

	/// D////////////////////////////////////////
	public bool effectAdd(NPCData.CharAttacks attackid, float accuracy, float DEFDodge){
		
		switch (attackid) {
		case NPCData.CharAttacks.PrecisionStrike:
			return false;
		case NPCData.CharAttacks.HoldLine:
			return true; 
		case NPCData.CharAttacks.CombatManuevers:
			return true; 
		case NPCData.CharAttacks.ReachingAttack:
			if (accuracy - DEFDodge >=  25 ) {return true;}
			return false; 
		case NPCData.CharAttacks.BreakShield:
			if (accuracy - DEFDodge >=  40 ) {return true;}
			return false; 
		case NPCData.CharAttacks.Charge:
			if (accuracy - DEFDodge >=  15 ) {return true;}
			return false; 
		case NPCData.CharAttacks.WarCry:
			return false; 
		case NPCData.CharAttacks.Disarm:
			if (accuracy - DEFDodge >=  40 ) {return true;}
			return false;  
		case NPCData.CharAttacks.Meditation:
			return false; 
		case NPCData.CharAttacks.PalmStrike:
			if (accuracy - DEFDodge >=  20 ) {return true;}
			return false; 
		case NPCData.CharAttacks.FluidStance:
			return false; 
		case NPCData.CharAttacks.UnexpectedGrapple:
			if (accuracy - DEFDodge >=  30 ) {return true;}
			return false;  
		case NPCData.CharAttacks.HulkingPotion:
			return false; 
		case NPCData.CharAttacks.ArousingFumes:
			if (accuracy - DEFDodge >=  20 ) {return true;}
			return false; 
		case NPCData.CharAttacks.PoisonDarts:
			if (accuracy - DEFDodge >=  40 ) {return true;}
			return false; 
		case NPCData.CharAttacks.SmokeBombs:
			if (accuracy - DEFDodge >=  50 ) {return true;}
			return false; 
		case NPCData.CharAttacks.ConcussiveStrike:
			if (accuracy - DEFDodge >=  85 ) {return true;}
			return false; 
		case NPCData.CharAttacks.FoulPlay:
			if (accuracy - DEFDodge >=  85 ) {return true;}
			return false; 
		case NPCData.CharAttacks.PoisonDagger:
			if (accuracy - DEFDodge >=  30 ) {return true;}
			return false; 
		case NPCData.CharAttacks.ShadowStrike:
			return false; 
		case NPCData.CharAttacks.HitAndRun:
			return true; 
		case NPCData.CharAttacks.CloackAndDagger:
			if (accuracy - DEFDodge >=  20 ) {return true;}
			return false; 
		case NPCData.CharAttacks.SexyDistraction:
			if (accuracy - DEFDodge >=  20 ) {return true;}
			return false; 
		case NPCData.CharAttacks.Smite:
			return false; 
		case NPCData.CharAttacks.DivineFavor:
			return true; 
		case NPCData.CharAttacks.Banish:
			return false; 
		case NPCData.CharAttacks.HealingPrayer:
			return true; 
		case NPCData.CharAttacks.Temptation:
			if (accuracy - DEFDodge >=  20 ) {return true;}
			return false; 
		case NPCData.CharAttacks.LifeSteal:
			return false; 
		case NPCData.CharAttacks.DarkIntervention:
			if (accuracy - DEFDodge >=  30 ) {return true;}
			return false; 
		case NPCData.CharAttacks.MindVision:
			if (accuracy - DEFDodge >=  20 ) {return true;}
			return false; 
		case NPCData.CharAttacks.FeralCry:
			if (accuracy - DEFDodge >=  30 ) {return true;}
			return false; 
		case NPCData.CharAttacks.PinDown:
			if (accuracy - DEFDodge >=  30 ) {return true;}
			return false; 
		case NPCData.CharAttacks.InescapableGrab:
			if (accuracy - DEFDodge >=  85 ) {return true;}
			return false; 
		case NPCData.CharAttacks.DominantPresence:
			return true; 
		case NPCData.CharAttacks.RecklessCharge:
			if (accuracy - DEFDodge >=  40 ) {return true;}
			return false; 
		case NPCData.CharAttacks.MercilessAttack:
			if (accuracy - DEFDodge >=  30 ) {return true;}
			return false; 
		case NPCData.CharAttacks.BleedingSwipe:
			if (accuracy - DEFDodge >=  40 ) {return true;}
			return false; 
		case NPCData.CharAttacks.Taunt:
			if (accuracy - DEFDodge >=  40 ) {return true;}
			return false; 
		case NPCData.CharAttacks.ArrowTraps:
			return true; 
		case NPCData.CharAttacks.Ambush:
			if (accuracy - DEFDodge >=  85 ) {return true;}
			return false; 
		case NPCData.CharAttacks.TacticalRetreat:
			return true; 
		case NPCData.CharAttacks.Decoy:
			return true; 
		case NPCData.CharAttacks.TakeAim:
			return true; 
		case NPCData.CharAttacks.Headshot:
			if (accuracy - DEFDodge >=  85 ) {return true;}
			return false; 
		case NPCData.CharAttacks.DoubleShot:
			return false; 
		case NPCData.CharAttacks.SupressingFire:
			if (accuracy - DEFDodge >=  20 ) {return true;}
			return false; 
		case NPCData.CharAttacks.LitanyOfPain:
			if (accuracy - DEFDodge >=  85 ) {return true;}
			return false; 
		case NPCData.CharAttacks.ImplacableSermon:
			if (accuracy - DEFDodge >=  30 ) {return true;}
			return false; 
		case NPCData.CharAttacks.Scourge:
			return false; 
		case NPCData.CharAttacks.IronResolve:
			return true; 
		case NPCData.CharAttacks.StunningBlow:
			if (accuracy - DEFDodge >=  85 ) {return true;}
			return false; 
		case NPCData.CharAttacks.ShieldWall:
			return true; 
		case NPCData.CharAttacks.PepperGrenade:
			if (accuracy - DEFDodge >=  20 ) {return true;}
			return false; 
		case NPCData.CharAttacks.ShieldCharge:
			return true; 
		case NPCData.CharAttacks.ElegantStance:
			return true; 
		case NPCData.CharAttacks.HypnoticDance:
			if (accuracy - DEFDodge >=  80 ) {return true;}
			return false; 
		case NPCData.CharAttacks.GraciousAttack:
			if (accuracy - DEFDodge >=  75 ) {return true;}
			return false; 
		case NPCData.CharAttacks.RiskyPerformance:
			return false; 
		case NPCData.CharAttacks.Striptease:
			return true; 
		case NPCData.CharAttacks.CrotchGrab:
			if (accuracy - DEFDodge >=  40 ) {return true;}
			return false; 
		case NPCData.CharAttacks.ForcedKissing:
			return false; 
		case NPCData.CharAttacks.IndecentSmile:
			if (accuracy - DEFDodge >=  20 ) {return true;}
			return false; 
		case NPCData.CharAttacks.Concentration:
			return true; 
		case NPCData.CharAttacks.ProtectiveRitual:
			return true; 
		case NPCData.CharAttacks.Hex:
			return true; 
		case NPCData.CharAttacks.IronWill:
			return true; 
		case NPCData.CharAttacks.HuntersMusk:
			if (accuracy - DEFDodge >=  30 ) {return true;}
			return false; 
		case NPCData.CharAttacks.AlphasAura:
			if (accuracy - DEFDodge >=  30 ) {return true;}
			return false; 
		case NPCData.CharAttacks.Rending:
			return false; 
		case NPCData.CharAttacks.FeralBite:
			return false; 
		case NPCData.CharAttacks.DemonicAura:
			return true; 
		case NPCData.CharAttacks.SuccubusTouch:
			if (accuracy - DEFDodge >=  30 ) {return true;}
			return false; 
		case NPCData.CharAttacks.EnticingShow:
			return true; 
		case NPCData.CharAttacks.Charm:
			if (accuracy - DEFDodge >=  50 ) {return true;}
			return false; 
		case NPCData.CharAttacks.HornyLeap:
			if (accuracy - DEFDodge >=  20 ) {return true;}
			return false; 
		case NPCData.CharAttacks.BouncyGrab:
			return false; 
		case NPCData.CharAttacks.BunnyHump:
			return false; 
		case NPCData.CharAttacks.MatingSeason:
			if (accuracy - DEFDodge >=  25) {return true;}
			return false; 
		case NPCData.CharAttacks.EquineCharge:
			return false; 
		case NPCData.CharAttacks.WildRide:
			return false; 
		case NPCData.CharAttacks.StallionsMusk:
			if (accuracy - DEFDodge >=  30) {return true;}
			return false; 
		case NPCData.CharAttacks.ImpetiousKick:
			if (accuracy - DEFDodge >=  85 ) {return true;}
			return false; 
		case NPCData.CharAttacks.Bash:
			return false; 
		case NPCData.CharAttacks.Slash:
			return false; 
		case NPCData.CharAttacks.HardBlow:
			if (accuracy - DEFDodge >=  25 ) {return true;}
			return false; 
		case NPCData.CharAttacks.LoudSlap:
			if (accuracy - DEFDodge >=  85 ) {return true;}
			return false; 
		case NPCData.CharAttacks.PocketSand:
			if (accuracy - DEFDodge >=  40 ) {return true;}
			return false; 
		case NPCData.CharAttacks.TakeCover:
			return true; 
		case NPCData.CharAttacks.TripUp:
			return false; 
		case NPCData.CharAttacks.Fondling:
			return false; 
		case NPCData.CharAttacks.BodyShowoff:
			return false; 
		case NPCData.CharAttacks.PlayfulChase:
			return false; 
		case NPCData.CharAttacks.SelfSpanking:
			return true; 
		case NPCData.CharAttacks.SeductiveGesture:
			if (accuracy - DEFDodge >=  20 ) {return true;}
			return false; 
		case NPCData.CharAttacks.Heal:
			return false; 
		case NPCData.CharAttacks.IceSpikes:
			if (accuracy - DEFDodge >=  80 ) {return true;}
			return false; 
		case NPCData.CharAttacks.FireBall:
			if (accuracy - DEFDodge >=  80 ) {return true;}
			return false; 
		case NPCData.CharAttacks.ElectricShock:
			if (accuracy - DEFDodge >=  75 ) {return true;}
			return false; 
		case NPCData.CharAttacks.AirBlast:
			if (accuracy - DEFDodge >=  70 ) {return true;}
			return false; 
		case NPCData.CharAttacks.Purification:
			return false; 
		case NPCData.CharAttacks.PerverseVisions:
			return false; 
		case NPCData.CharAttacks.MagicBinds:
			if (accuracy - DEFDodge >=  80 ) {return true;}
			return false; 
		case NPCData.CharAttacks.EtherealHands:
			return false; 
		case NPCData.CharAttacks.ArousingWave:
			if (accuracy - DEFDodge >=  80 ) {return true;}
			return false; 

		default:
			return false; 
		}
		return false; 
	}

	/// D////////////////////////////////////////
	//this is to cast the effect to the person doing the attack, like a buff 
	public bool effectBuff(NPCData.CharAttacks attackid, float accuracy){
		switch (attackid) {
		case NPCData.CharAttacks.PrecisionStrike:
			return false;
		case NPCData.CharAttacks.HoldLine:
			return true; 
		case NPCData.CharAttacks.CombatManuevers:
			return false; 
		case NPCData.CharAttacks.ReachingAttack:
			return true; 
		case NPCData.CharAttacks.BreakShield:
			return false; 
		case NPCData.CharAttacks.Charge:
			return false; 
		case NPCData.CharAttacks.WarCry:
			return true; 
		case NPCData.CharAttacks.Disarm:
			return false;  
		case NPCData.CharAttacks.Meditation:
			return true; 
		case NPCData.CharAttacks.PalmStrike:
			return false; 
		case NPCData.CharAttacks.FluidStance:
			return true; 
		case NPCData.CharAttacks.UnexpectedGrapple:
			return false;  
		case NPCData.CharAttacks.HulkingPotion:
			return true; 
		case NPCData.CharAttacks.ArousingFumes:
			return false; 
		case NPCData.CharAttacks.PoisonDarts:
			return false; 
		case NPCData.CharAttacks.SmokeBombs:
			return true; 
		case NPCData.CharAttacks.ConcussiveStrike:
			return false; 
		case NPCData.CharAttacks.FoulPlay:
			return false; 
		case NPCData.CharAttacks.PoisonDagger:
			return false; 
		case NPCData.CharAttacks.ShadowStrike:
			return false; 
		case NPCData.CharAttacks.HitAndRun:
			return true; 
		case NPCData.CharAttacks.CloackAndDagger:
			return true; 
		case NPCData.CharAttacks.SexyDistraction:
			return false; 
		case NPCData.CharAttacks.Smite:
			return false; 
		case NPCData.CharAttacks.DivineFavor:
			return true; 
		case NPCData.CharAttacks.Banish:
			return false; 
		case NPCData.CharAttacks.HealingPrayer:
			return true; 
		case NPCData.CharAttacks.Temptation:
			return false; 
		case NPCData.CharAttacks.LifeSteal:
			return false; 
		case NPCData.CharAttacks.DarkIntervention:
			return false; 
		case NPCData.CharAttacks.MindVision:
			return false; 
		case NPCData.CharAttacks.FeralCry:
			return false; 
		case NPCData.CharAttacks.PinDown:
			return false; 
		case NPCData.CharAttacks.InescapableGrab:
			return false; 
		case NPCData.CharAttacks.DominantPresence:
			return true; 
		case NPCData.CharAttacks.RecklessCharge:
			return false; 
		case NPCData.CharAttacks.MercilessAttack:
			return false; 
		case NPCData.CharAttacks.BleedingSwipe:
			return false; 
		case NPCData.CharAttacks.Taunt:
			return false; 
		case NPCData.CharAttacks.ArrowTraps:
			return true; 
		case NPCData.CharAttacks.Ambush:
			return false; 
		case NPCData.CharAttacks.TacticalRetreat:
			return true; 
		case NPCData.CharAttacks.Decoy:
			return false; 
		case NPCData.CharAttacks.TakeAim:
			return false; 
		case NPCData.CharAttacks.Headshot:
			return false; 
		case NPCData.CharAttacks.DoubleShot:
			return false; 
		case NPCData.CharAttacks.SupressingFire:
			return false; 
		case NPCData.CharAttacks.LitanyOfPain:
			return false; 
		case NPCData.CharAttacks.ImplacableSermon:
			return false; 
		case NPCData.CharAttacks.Scourge:
			return false; 
		case NPCData.CharAttacks.IronResolve:
			return true; 
		case NPCData.CharAttacks.StunningBlow:
			return false; 
		case NPCData.CharAttacks.ShieldWall:
			return true; 
		case NPCData.CharAttacks.PepperGrenade:
			return false; 
		case NPCData.CharAttacks.ShieldCharge:
			return true; 
		case NPCData.CharAttacks.ElegantStance:
			return true; 
		case NPCData.CharAttacks.HypnoticDance:
			return false; 
		case NPCData.CharAttacks.GraciousAttack:
			return false; 
		case NPCData.CharAttacks.RiskyPerformance:
			return false; 
		case NPCData.CharAttacks.Striptease:
			return true; 
		case NPCData.CharAttacks.CrotchGrab:
			return false; 
		case NPCData.CharAttacks.ForcedKissing:
			return false; 
		case NPCData.CharAttacks.IndecentSmile:
			return false; 
		case NPCData.CharAttacks.Concentration:
			return true; 
		case NPCData.CharAttacks.ProtectiveRitual:
			return true; 
		case NPCData.CharAttacks.Hex:
			return false; 
		case NPCData.CharAttacks.IronWill:
			return true; 
		case NPCData.CharAttacks.HuntersMusk:
			return false; 
		case NPCData.CharAttacks.AlphasAura:
			return false; 
		case NPCData.CharAttacks.Rending:
			return false; 
		case NPCData.CharAttacks.FeralBite:
			return false; 
		case NPCData.CharAttacks.DemonicAura:
			return true; 
		case NPCData.CharAttacks.SuccubusTouch:
			return false; 
		case NPCData.CharAttacks.EnticingShow:
			return true; 
		case NPCData.CharAttacks.Charm:
			return false; 
		case NPCData.CharAttacks.HornyLeap:
			return false; 
		case NPCData.CharAttacks.BouncyGrab:
			return false; 
		case NPCData.CharAttacks.BunnyHump:
			return false; 
		case NPCData.CharAttacks.MatingSeason:
			return false; 
		case NPCData.CharAttacks.EquineCharge:
			return false; 
		case NPCData.CharAttacks.WildRide:
			return false; 
		case NPCData.CharAttacks.StallionsMusk:
			return false; 
		case NPCData.CharAttacks.ImpetiousKick:
			return false; 
		case NPCData.CharAttacks.Bash:
			return false; 
		case NPCData.CharAttacks.Slash:
			return false; 
		case NPCData.CharAttacks.HardBlow:
			return false; 
		case NPCData.CharAttacks.LoudSlap:
			return false; 
		case NPCData.CharAttacks.PocketSand:
			return false; 
		case NPCData.CharAttacks.TakeCover:
			return true; 
		case NPCData.CharAttacks.TripUp:
			return false; 
		case NPCData.CharAttacks.Fondling:
			return false; 
		case NPCData.CharAttacks.BodyShowoff:
			return false; 
		case NPCData.CharAttacks.PlayfulChase:
			return false; 
		case NPCData.CharAttacks.SelfSpanking:
			return true; 
		case NPCData.CharAttacks.SeductiveGesture:
			return false; 
		case NPCData.CharAttacks.Heal:
			return true; 
		case NPCData.CharAttacks.IceSpikes:
			return false; 
		case NPCData.CharAttacks.FireBall:
			return false; 
		case NPCData.CharAttacks.ElectricShock:
			return false; 
		case NPCData.CharAttacks.AirBlast:
			return false; 
		case NPCData.CharAttacks.Purification:
			return true; 
		case NPCData.CharAttacks.PerverseVisions:
			return false; 
		case NPCData.CharAttacks.MagicBinds:
			return false; 
		case NPCData.CharAttacks.EtherealHands:
			return false; 
		case NPCData.CharAttacks.ArousingWave:
			return false; 

		default:
			return false; 
		}
	

	}



	/// D////////////////////////////////////////
	public CombatEffects designEffects(NPCData.CharAttacks attackid, CombatEffects combatEffect){
		switch(attackid)
		{
		case NPCData.CharAttacks.PrecisionStrike:
			break;
		case NPCData.CharAttacks.HoldLine:
			combatEffect.cooldown = Random.Range (2,4); 
			combatEffect.physDEF = 0.3f; 
			combatEffect.physDMG = -0.15f;
			break;
		case NPCData.CharAttacks.CombatManuevers:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.dodge = -5;
			combatEffect.physDEF = -0.2f; 
			break;
		case NPCData.CharAttacks.ReachingAttack:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.dodge = 5;
			combatEffect.physDEF = 0.2f;
			break;
		case NPCData.CharAttacks.BreakShield:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDEF = -0.5f;
			break;
		case NPCData.CharAttacks.Charge:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.dodge = -10;

			break;
		case NPCData.CharAttacks.WarCry:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDMG = 0.2f;
			combatEffect.physDEF = -0.2f;
			combatEffect.dodge = -5;
			break;
		case NPCData.CharAttacks.Disarm:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDMG = -0.5f;
			break; 
		case NPCData.CharAttacks.Meditation:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.dodge = -5;
			combatEffect.physDEF = 0.2f;
			break;
		case NPCData.CharAttacks.PalmStrike:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDEF = -0.2f;
			combatEffect.dodge = -5;
			break;
		case NPCData.CharAttacks.FluidStance:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.dodge = 15;
			break;
		case NPCData.CharAttacks.UnexpectedGrapple:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDMG = -0.5f;
			combatEffect.dodge = -10;
			break; 
		case NPCData.CharAttacks.HulkingPotion:
			combatEffect.cooldown = Random.Range (3, 4);
			combatEffect.physDMG = 0.5f;
			combatEffect.physDEF = 0.5f;
			combatEffect.lustDEF = -0.5f;
			break;
		case NPCData.CharAttacks.ArousingFumes:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.lustMod = Random.Range(3,10);
			combatEffect.lustDEF = -0.2f;
			break;
		case NPCData.CharAttacks.DebilitatingFumes:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.lustDMG = -0.2f;
			combatEffect.physDEF = -0.2f;
			combatEffect.dodge = -5;
			break; 
		case NPCData.CharAttacks.PoisonDarts:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.healthMod = Random.Range(-5,-10);
			break;
		case NPCData.CharAttacks.SmokeBombs:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.dodge = 20;
			break;
		case NPCData.CharAttacks.ConcussiveStrike:
			combatEffect.cooldown = Random.Range (2, 3);
			combatEffect.stunned = true;
			break;
		case NPCData.CharAttacks.FoulPlay:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDMG = -0.2f;
			combatEffect.physDEF = -0.2f;
			combatEffect.dodge = -5;
			combatEffect.lustDEF = 0.5f;
			break;
		case NPCData.CharAttacks.PoisonDagger:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.healthMod = Random.Range(-5,-15);
			break;
		case NPCData.CharAttacks.ShadowStrike:
			break;
		case NPCData.CharAttacks.HitAndRun:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.dodge = 15;
			break;
		case NPCData.CharAttacks.CloackAndDagger:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.dodge = 5;
			break;
		case NPCData.CharAttacks.SexyDistraction:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.dodge = -5;

			break;
		case NPCData.CharAttacks.Smite:
			break;
		case NPCData.CharAttacks.DivineFavor:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDEF = 0.4f;
			combatEffect.lustDEF = 0.4f;
			break;
		case NPCData.CharAttacks.Banish:
			break;
		case NPCData.CharAttacks.HealingPrayer:
			combatEffect.cooldown = Random.Range (2, 5);
			combatEffect.healthMod = Random.Range(3,8);
			combatEffect.physDEF = -0.2f;
			combatEffect.lustDEF = -0.2f;
			break;
		case NPCData.CharAttacks.Temptation:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.lustDEF = -0.3f; 
			break;
		case NPCData.CharAttacks.LifeSteal:
			break;
		case NPCData.CharAttacks.DarkIntervention:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDMG = -0.2f;
			combatEffect.physDEF = -0.1f;
			combatEffect.lustDEF = -0.1f;
			break;
		case NPCData.CharAttacks.MindVision:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.lustMod = Random.Range(3,7);
			combatEffect.lustDEF = -0.1f;
			break;
		case NPCData.CharAttacks.FeralCry:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDMG = -0.2f;
			combatEffect.dodge = -5;
			break;
		case NPCData.CharAttacks.PinDown:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.lustDEF = -0.3f;
			combatEffect.dodge = -5;
			break;
		case NPCData.CharAttacks.InescapableGrab:
			break;
		case NPCData.CharAttacks.DominantPresence:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDEF = 0.3f;
			combatEffect.lustDEF = 0.3f;
			combatEffect.physDMG = 0.3f;
			combatEffect.dodge = -15;
			break;
		case NPCData.CharAttacks.RecklessCharge:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDEF = -0.2f;
			break;
		case NPCData.CharAttacks.MercilessAttack:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.dodge = -7;
			break;
		case NPCData.CharAttacks.BleedingSwipe:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.healthMod = Random.Range (3,8);
			combatEffect.dodge = -3;
			break;
		case NPCData.CharAttacks.Taunt:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDEF = -0.4f;
			combatEffect.dodge = -5;
			combatEffect.lustDEF = 0.2f;
			break;
		case NPCData.CharAttacks.ArrowTraps:
			combatEffect.cooldown = Random.Range (2, 5);
			combatEffect.physDEF = -0.2f;
			break;
		case NPCData.CharAttacks.Ambush:
			combatEffect.cooldown = Random.Range (2, 3);
			combatEffect.stunned = true;
			break;
		case NPCData.CharAttacks.TacticalRetreat:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.lustDMG = -0.5f;
			combatEffect.physDMG = -0.5f;
			combatEffect.dodge = 25;
			break;
		case NPCData.CharAttacks.Decoy:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDMG = -0.4f;
			combatEffect.physDEF = 0.2f;
			combatEffect.lustDMG = -0.4f;
			combatEffect.lustDEF = 0.2f;
			break;
		case NPCData.CharAttacks.TakeAim:
			combatEffect.cooldown = Random.Range (2, 3);
			combatEffect.dodge = -20;
			combatEffect.physDMG = 0.3f;
			break;
		case NPCData.CharAttacks.Headshot:
			combatEffect.cooldown = Random.Range (2, 3);
			combatEffect.physDMG = -0.3f;
			break;
		case NPCData.CharAttacks.DoubleShot:
			break;
		case NPCData.CharAttacks.SupressingFire:
			combatEffect.cooldown = Random.Range (2, 3);
			combatEffect.physDMG = -0.4f;
			combatEffect.lustDMG = -0.4f;
			break;
		case NPCData.CharAttacks.LitanyOfPain:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDMG = -0.5f;
			break;
		case NPCData.CharAttacks.ImplacableSermon:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDEF = -0.2f;
			combatEffect.lustDEF = 0.5f;
			break;
		case NPCData.CharAttacks.Scourge:

			break;
		case NPCData.CharAttacks.IronResolve:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDEF = 0.35f;
			combatEffect.lustDEF = 0.35f;
			break;
		case NPCData.CharAttacks.StunningBlow:
			combatEffect.cooldown = Random.Range (2, 3);
			combatEffect.stunned = true;
			break;
		case NPCData.CharAttacks.ShieldWall:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDEF = 1f;
			combatEffect.lustDEF = -0.4f;
			combatEffect.dodge = -10;
			break;
		case NPCData.CharAttacks.PepperGrenade:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDMG = -0.3f;
			combatEffect.lustDMG = -0.3f;
			break;
		case NPCData.CharAttacks.ShieldCharge:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDEF = 0.3f;
			break;
		case NPCData.CharAttacks.ElegantStance:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDMG = -0.3f;
			combatEffect.lustDMG = -0.3f;
			combatEffect.physDEF = -0.5f;
			combatEffect.dodge = 25;
			break;
		case NPCData.CharAttacks.HypnoticDance:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.stunned = true;
			combatEffect.physDEF = -0.3f;
			break;
		case NPCData.CharAttacks.GraciousAttack:
			break;
		case NPCData.CharAttacks.RiskyPerformance:

			break;
		case NPCData.CharAttacks.Striptease:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDEF = -0.2f;
			break;
		case NPCData.CharAttacks.CrotchGrab:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDEF = -0.2f;
			break;
		case NPCData.CharAttacks.ForcedKissing:
			break;
		case NPCData.CharAttacks.IndecentSmile:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.lustDEF = -0.5f;
			break;
		case NPCData.CharAttacks.Concentration:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.magDMG = 0.4f;
			combatEffect.physDEF = -0.2f;
			combatEffect.dodge = -5;

			break;
		case NPCData.CharAttacks.ProtectiveRitual:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDMG = -0.2f;
			combatEffect.physDEF = 0.4f;
			combatEffect.magDEF = 0.4f;
			combatEffect.dodge = -5;
			break;
		case NPCData.CharAttacks.Hex:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.magDEF = -0.3f;
			combatEffect.dodge = -7;
			break;
		case NPCData.CharAttacks.IronWill:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.lustDEF = 0.3f;
			combatEffect.magDEF = 0.3f;
			combatEffect.dodge = -7;
			break;
		case NPCData.CharAttacks.HuntersMusk:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.lustDEF = -0.4f;
			break;
		case NPCData.CharAttacks.AlphasAura:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDEF = -0.2f;
			combatEffect.lustDEF = 0.2f;
			break;
		case NPCData.CharAttacks.Rending:

			break;
		case NPCData.CharAttacks.FeralBite:
			break;
		case NPCData.CharAttacks.DemonicAura:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.lustDEF = 0.3f;
			combatEffect.lustDMG = 0.3f;
			break;
		case NPCData.CharAttacks.SuccubusTouch:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.lustDEF = 0.3f;
			break;
		case NPCData.CharAttacks.EnticingShow:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDEF = -0.2f;
			combatEffect.lustDEF = -0.2f;
			break;
		case NPCData.CharAttacks.Charm:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.stunned = true;
			combatEffect.lustDEF = -0.15f;
			break;
		case NPCData.CharAttacks.HornyLeap:
			combatEffect.cooldown = Random.Range (2, 6);
			combatEffect.lustDEF = -0.1f;
			break;
		case NPCData.CharAttacks.BouncyGrab:

			break;
		case NPCData.CharAttacks.BunnyHump:

			break;
		case NPCData.CharAttacks.MatingSeason:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.lustDEF = -0.5f;
			break;
		case NPCData.CharAttacks.EquineCharge:
			break;
		case NPCData.CharAttacks.WildRide:

			break;
		case NPCData.CharAttacks.StallionsMusk:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.lustDEF = -0.2f;
			combatEffect.physDEF = -0.2f;
			break;
		case NPCData.CharAttacks.ImpetiousKick:
			combatEffect.cooldown = Random.Range (2, 3);
			combatEffect.stunned = true;
			break;
		case NPCData.CharAttacks.Bash:
			break;
		case NPCData.CharAttacks.Slash:
			break;
		case NPCData.CharAttacks.HardBlow:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.dodge = -10;
			break;
		case NPCData.CharAttacks.LoudSlap:
			combatEffect.cooldown = 2;
			combatEffect.stunned = true;
			break;
		case NPCData.CharAttacks.PocketSand:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDMG = -0.6f;
			break;
		case NPCData.CharAttacks.TakeCover:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDEF = 0.8f;
			combatEffect.physDMG = -0.5f;
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
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.lustDEF = 0.4f;
			break;
		case NPCData.CharAttacks.SeductiveGesture:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.lustDEF = -0.6f;
			break;
		case NPCData.CharAttacks.Heal:
			combatEffect.cooldown = Random.Range (2, 7);
			combatEffect.physDEF = -0.1f;
			break;
		case NPCData.CharAttacks.IceSpikes:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDEF = -0.6f;
			combatEffect.lustDEF = 0.3f;
			break;
		case NPCData.CharAttacks.FireBall:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.healthMod = Random.Range(-4f,-8f);
			break;
		case NPCData.CharAttacks.ElectricShock:
			combatEffect.cooldown = Random.Range (2, 3);
			combatEffect.stunned = true;
			break;
		case NPCData.CharAttacks.AirBlast:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.physDMG = -0.3f;
			break;
		case NPCData.CharAttacks.Purification:
			combatEffect.cooldown = Random.Range (2, 7);
			combatEffect.physDEF = -0.1f;
			break; 
		case NPCData.CharAttacks.PerverseVisions:

			break;
		case NPCData.CharAttacks.MagicBinds:

			break;
		case NPCData.CharAttacks.EtherealHands:

			break;
		case NPCData.CharAttacks.ArousingWave:
			combatEffect.cooldown = Random.Range (2, 4);
			combatEffect.lustMod = Random.Range(3,7);
			break;

		default:
			break;

		}
		return combatEffect; 

	}
		
	/// D////////////////////////////////////////
	public CombatEffects(){

	}

	/// D////////////////////////////////////////
	public void applyEffects(int charslot, int charid, CombatEffects combatEffect){
		CombatScript.chMod [charslot, 0] += combatEffect.physDMG;
		CombatScript.chMod  [charslot, 1] += combatEffect.lustDMG;
		CombatScript.chMod  [charslot, 2] += combatEffect.magDMG;
		CombatScript.chMod [charslot, 3] += combatEffect.physDEF;
		CombatScript.chMod  [charslot, 4] += combatEffect.lustDEF;
		CombatScript.chMod  [charslot, 5] += combatEffect.magDEF;
		CombatScript.chMod  [charslot, 6] += combatEffect.dodge;

		//we look through the list to add certain effects, just HP and Lust changes
		CombatScript.stunned [charslot] = combatEffect.stunned;
		/*switch (charslot) {
		case 0: 
			Debug.Log ("Apply effect case 0");
			CombatScript.ch0mod [0] += combatEffect.physDMG;
			CombatScript.ch0mod [1] += combatEffect.lustDMG;
			CombatScript.ch0mod [2] += combatEffect.magDMG;
			CombatScript.ch0mod [3] += combatEffect.physDEF;
			CombatScript.ch0mod [4] += combatEffect.lustDEF;
			CombatScript.ch0mod [5] += combatEffect.magDEF;
			CombatScript.ch0mod [6] += combatEffect.dodge;

			break; 
		case 1:
			CombatScript.ch1mod [0] += combatEffect.physDMG;
			CombatScript.ch1mod [1] += combatEffect.lustDMG;
			CombatScript.ch1mod [2] += combatEffect.magDMG;
			CombatScript.ch1mod [3] += combatEffect.physDEF;
			CombatScript.ch1mod [4] += combatEffect.lustDEF;
			CombatScript.ch1mod [5] += combatEffect.magDEF;
			CombatScript.ch1mod [6] += combatEffect.dodge;
			break;
		case 2:
			CombatScript.ch2mod [0] += combatEffect.physDMG;
			CombatScript.ch2mod [1] += combatEffect.lustDMG;
			CombatScript.ch2mod [2] += combatEffect.magDMG;
			CombatScript.ch2mod [3] += combatEffect.physDEF;
			CombatScript.ch2mod [4] += combatEffect.lustDEF;
			CombatScript.ch2mod [5] += combatEffect.magDEF;
			CombatScript.ch2mod [6] += combatEffect.dodge;

			break;
		case 3:
			CombatScript.ch3mod [0] += combatEffect.physDMG;
			CombatScript.ch3mod [1] += combatEffect.lustDMG;
			CombatScript.ch3mod [2] += combatEffect.magDMG;
			CombatScript.ch3mod [3] += combatEffect.physDEF;
			CombatScript.ch3mod [4] += combatEffect.lustDEF;
			CombatScript.ch3mod [5] += combatEffect.magDEF;
			CombatScript.ch3mod [6] += combatEffect.dodge;
			break;
		case 4:
			CombatScript.ch4mod [0] += combatEffect.physDMG;
			CombatScript.ch4mod [1] += combatEffect.lustDMG;
			CombatScript.ch4mod [2] += combatEffect.magDMG;
			CombatScript.ch4mod [3] += combatEffect.physDEF;
			CombatScript.ch4mod [4] += combatEffect.lustDEF;
			CombatScript.ch4mod [5] += combatEffect.magDEF;
			CombatScript.ch4mod [6] += combatEffect.dodge;
			break;
		case 5:
			CombatScript.ch5mod [0] += combatEffect.physDMG;
			CombatScript.ch5mod [1] += combatEffect.lustDMG;
			CombatScript.ch5mod [2] += combatEffect.magDMG;
			CombatScript.ch5mod [3] += combatEffect.physDEF;
			CombatScript.ch5mod [4] += combatEffect.lustDEF;
			CombatScript.ch5mod [5] += combatEffect.magDEF;
			CombatScript.ch5mod [6] += combatEffect.dodge;
			break;
		case 6:
			CombatScript.ch6mod [0] += combatEffect.physDMG;
			CombatScript.ch6mod [1] += combatEffect.lustDMG;
			CombatScript.ch6mod [2] += combatEffect.magDMG;
			CombatScript.ch6mod [3] += combatEffect.physDEF;
			CombatScript.ch6mod [4] += combatEffect.lustDEF;
			CombatScript.ch6mod [5] += combatEffect.magDEF;
			CombatScript.ch6mod [6] += combatEffect.dodge;
			break;
		case 7:
			CombatScript.ch7mod [0] += combatEffect.physDMG;
			CombatScript.ch7mod [1] += combatEffect.lustDMG;
			CombatScript.ch7mod [2] += combatEffect.magDMG;
			CombatScript.ch7mod [3] += combatEffect.physDEF;
			CombatScript.ch7mod [4] += combatEffect.lustDEF;
			CombatScript.ch7mod [5] += combatEffect.magDEF;
			CombatScript.ch7mod [6] += combatEffect.dodge;
			break;
		default:
			break;
		}*/




		i = 0;
		if (charslot == 0) {
			GameControl.actualHealth += combatEffect.healthMod;
			GameControl.actualArousal += combatEffect.lustMod; 
			Debug.Log ("apply effect to mc, modifying health, his new health is " + GameControl.actualHealth);

		} else if (charid < 1000000) {

			while(i < NPCCharList.CharFollower.Count){
				if (NPCCharList.CharFollower [i].charID == charid) {
					NPCCharList.CharFollower [i].currentHealth += combatEffect.healthMod;
					NPCCharList.CharFollower [i].currentArousal += combatEffect.lustMod;
					break;
				}
				i++; 
			}
		} else if (charslot <= 3) {
			while(i < NPCCharList.CharRetainers.Count){
				if (NPCCharList.CharRetainers [i].charID == charid) {
					NPCCharList.CharRetainers [i].currentHealth += combatEffect.healthMod;
					NPCCharList.CharRetainers [i].currentArousal += combatEffect.lustMod;
					break;
				}
				i++; 
			}
		} else {
			while(i < NPCCharList.CharMonster.Count){
				if (NPCCharList.CharMonster [i].charID == charid) {
					NPCCharList.CharMonster [i].currentHealth += combatEffect.healthMod;
					NPCCharList.CharMonster [i].currentArousal += combatEffect.lustMod;
					Debug.Log ("apply effect to an enemy in slot 0, modifying health, his new health is " + NPCCharList.CharMonster [i].currentHealth);
					break;
				}
				i++; 
			}
		}
			

	}

		

}
