using UnityEngine;
using System.Collections;

public class AttackText : MonoBehaviour {

	string nameATT;
	string nameDEF;
	int i; 

	public string attackTextAlly(NPCData.CharAttacks attackid, int npcidATT, int npcidDEF, bool critical, float physDMG, float lustDMG, float accuracy, int slotATT, int slotDEF, float DEFDodge){

		nameATT = loadNameATT (slotATT, npcidATT);
		nameDEF = loadNameDEF (slotDEF, npcidDEF);
		switch (attackid) {

		case NPCData.CharAttacks.PrecisionStrike:
			if (critical) {
				return "You did a critical attack and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "Your attack did " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.HoldLine:
			return "You used Hold the line, improving your defense!"; 
		case NPCData.CharAttacks.CombatManuevers:
			return "You used Combat Maneuvers, reducing enemy dodge and defense!"; 
		case NPCData.CharAttacks.ReachingAttack:
			if (critical) {
				return "Your reaching attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 25) {
				return "Your reaching attack did " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.BreakShield:
			if (critical) {
				return "Your attack was critical and " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + " and reduced its defense!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "Your attack did " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + " and reduced its defense!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			} 
		case NPCData.CharAttacks.Charge:
			if (critical) {
				return "Your charge was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + " and reducing its dodge!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "Your succesfully charged your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "and reducing its dodge!"; 
			} else if (accuracy - DEFDodge >= 5) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.WarCry:
			return "You let out a powerful War Cry, increasing your attack!"; 
		case NPCData.CharAttacks.Disarm:
			if (critical) {
				return "Your succesfully disarmed your opponent, reducing its attack, and inflicted a critical hit doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "Your succesfully disarmed your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "and reducing its attack!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.Meditation:
			return "You meditated, recovering some health and reducing your lust, and increasing your defense too! Although your dodge has been reduced."; 
		case NPCData.CharAttacks.PalmStrike:
			if (critical) {
				return "Your inflicted a critical hit and did " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + " and reducing its dodge and defense!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "Your succesfully hit your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "and reducing its dodge and defense!"; 
			} else if (accuracy - DEFDodge >= 5) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.FluidStance:
			return "You adopt a fluid stance. increasing your dodge significantly."; 
		case NPCData.CharAttacks.UnexpectedGrapple:
			if (critical) {
				return "Your grapple was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + " and reducing its dodge and attack significantly!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "Your succesfully hit your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "and reducing its dodge and attack significantly!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.HulkingPotion:
			return "You feel more physically powerful, but somehow more sensitive to pervert thoughts."; 
		case NPCData.CharAttacks.ArousingFumes:
			if (accuracy - DEFDodge >= 20) {
				return "The fumes start to affect the enemy, increasing its by " + Mathf.Round(lustDMG).ToString()  + " to " + nameDEF + "and reducing its lust resistance!"; 
			}else {
				return "You critically missed your attack and the fumes increased your lust by " + Mathf.Round(lustDMG).ToString()  + "!";
			}
		case NPCData.CharAttacks.DebilitatingFumes:
			if (accuracy - DEFDodge >= 20) {
				return "The fumes start to affect " + nameDEF + "and reducing its defense, dodge and attack!"; 
			}else {
				return "You critically missed your attack and the fumes did " + Mathf.Round(physDMG).ToString()  + " damage to you!";
			} 
		case NPCData.CharAttacks.PoisonDarts:
			if (critical) {
				return "Your darts critical hit the enemy and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", poisoning it!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "Your succesfully hit your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "and poisoning it!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.SmokeBombs:
			return "You use smoke bombs to hide yourself, increasing your dodge significantly."; 
		case NPCData.CharAttacks.ConcussiveStrike:
			if (critical) {
				return "Your concussive strike is critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", stunning it!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "Your concussive strike hit your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.FoulPlay:
			if (critical) {
				return "Your attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", also reducing its dodge, defense and attack!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "Your succesfully striked your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "and reducing its dodge, defense and attack!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.PoisonDagger:
			if (critical) {
				return "Your attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", poisoning it too!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "Your succesfully striked your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", poisoning it too!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.ShadowStrike:
			if (critical) {
				return "Your attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "Your succesfully striked your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.HitAndRun:
			if (critical) {
				return "Your attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", increasing your dodge too!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "Your succesfully striked your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", increasing your dodge too!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.CloackAndDagger:
			if (critical) {
				return "Your attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", increasing your dodge too!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "Your succesfully striked your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", increasing your dodge too!"; 
			} else if (accuracy - DEFDodge >= 5) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.SexyDistraction:
			if (critical) {
				return "Your attack was critical and increased its lust in " + Mathf.Round(lustDMG).ToString()  + ", also reducing its dodge!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "Your increased its lust in " + Mathf.Round(lustDMG).ToString()  + ", also reducing its dodge!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.Smite:
			if (critical) {
				return "Your attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "Your succesfully striked your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.DivineFavor:
			return "You pray for a higher power for its divine favor, increasing your defenses!"; 
		case NPCData.CharAttacks.Banish:
			if (critical) {
				return "Your attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 45) {
				return "Your succesfully striked your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.HealingPrayer:
			return "You pray and ask for higher powers to help you, healing you."; 
		case NPCData.CharAttacks.Temptation:
			if (critical) {
				return "Your attack was critical and increased its lust in " + Mathf.Round(lustDMG).ToString()  + " points, also reducing its resistance to lust!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "Your succesfully striked your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points and reducing its resistance to lust!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.LifeSteal:
			if (critical) {
				return "Your attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", healing you that amount!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "Your succesfully striked your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", healing you that amount!"; 
			} else if (accuracy - DEFDodge >= 16) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.DarkIntervention:
		    if (accuracy - DEFDodge >= 30) {
				return "You succesfuly reduced your enemy attack and defenses!";
			} else {
				return "No higher power helped you on this occasion!";
			}
		case NPCData.CharAttacks.MindVision:
			if (critical) {
				return "Your attack was critical and increased its lust in " + Mathf.Round(lustDMG).ToString()  + " points. Its mind is going to be affected by visions for several turns, reducing its lust defense and increasing its arousal!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points. Its mind is going to be affected by visions for several turns, reducing its lust defense and increasing its arousal!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.FeralCry:
			if (accuracy - DEFDodge >= 30) {
				return "Your roar has intimidated the opponent, reducing its attack and dodge.";
			} else {
				return "You couldn't affect your opponent!";
			}
		case NPCData.CharAttacks.PinDown:
			if (critical) {
				return "Your attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", also reducing its dodge and lust defense!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "Your succesfully striked your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "and reducing its dodge and lust defense!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.InescapableGrab:
			if (critical) {
				return "Your attack was critical, increasing its lust in "+ Mathf.Round(lustDMG).ToString()  + " points and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "Your attack has been succesful, increasing its lust in " + Mathf.Round(lustDMG).ToString()  +" points and inflicting" + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.DominantPresence:
			return "You use your dominant presence, increasing your defenses and attacks, but reducing your dodge."; 
		case NPCData.CharAttacks.RecklessCharge:
			if (critical) {
				return "Your attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", also reducing its dodge, defense and attack!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "Your succesfully striked your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "and reducing its dodge, defense and attack!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.MercilessAttack:
			if (critical) {
				return "Your attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", also reducing its dodge, defense and attack!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "Your succesfully striked your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "and reducing its dodge, defense and attack!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.BleedingSwipe:
			if (critical) {
				return "Your attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", also reducing its dodge and a bleeding effect!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "Your succesfully striked your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "and reducing its dodge and a bleeding effect!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.Taunt:
			if (accuracy - DEFDodge >= 40) {
				return "You succesfuly taunted your opponent, reducing its defense and dodge!";
			} else {
				return "You couldn't taunt your opponent!";
			} 
		case NPCData.CharAttacks.ArrowTraps:
			if (critical) {
				return "Your attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "Your succesfully striked your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.Ambush:
			if (critical) {
				return "Your attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", stunning for some turns too!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "Your succesfully striked your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.TacticalRetreat:
			return "You make a tactical retreat, increasing your dodge but reducing your attacks too!"; 
		case NPCData.CharAttacks.Decoy:
			return "You deploy a decoy, confusing your opponent and reducing its attack!"; 
		case NPCData.CharAttacks.TakeAim:
			return "You take aim, significantly reducing the enemy dodge but increasing its attacks!"; 
		case NPCData.CharAttacks.Headshot:
			if (critical) {
				return "Your attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", also reducing its attack!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "Your succesfully striked your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.DoubleShot:
			if (critical) {
				return "Your attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "Your succesfully striked your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.SupressingFire:
			if (critical) {
				return "Your attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", also reducing its attacks!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "Your succesfully striked your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "and reducing its attacks!"; 
			} else if (accuracy - DEFDodge >= 5) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.LitanyOfPain:
			if (critical) {
				return "Your attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", also reducing its defenses significantly!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "Your succesfully striked your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 5) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.ImplacableSermon:
		if (accuracy - DEFDodge >= 30) {
				return "Your sermon has make your enemy more vulnerable to your attacks and your persuasion.";
			} else {
				return "You couldn't persuade your opponent!";
			}
		case NPCData.CharAttacks.Scourge:
			if (critical) {
				return "Your attack was critical and increased its lust in " + Mathf.Round(physDMG).ToString()  + " points and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "Your attack was succesful and increased its lust in " + Mathf.Round(physDMG).ToString()  + " points and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.IronResolve:
			return "You increase your defenses, getting ready for the worst."; 
		case NPCData.CharAttacks.StunningBlow:
			if (critical) {
				return "Your attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", stunning it for some turns!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "Your succesfully striked your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.ShieldWall:
			return "You prepare for incoming attacks, increasing your defense significantly, but reducing your dodge!"; 
		case NPCData.CharAttacks.PepperGrenade:
		 if (accuracy - DEFDodge >= 20) {
				return "The gas of the grenade is reducing the enemy attack.";
			} else {
				return "The enemy got out of the way on time, the grenade had no effect on him!";
			}
		case NPCData.CharAttacks.ShieldCharge:
			if (critical) {
				return "Your attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", also increasing your defense!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "Your succesfully striked your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", also increasing your defense!"; 
			} else if (accuracy - DEFDodge >= 5) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.ElegantStance:
			return "You take an elegant combat stance, significantly increasing your dodge in exchange of your attack."; 
		case NPCData.CharAttacks.HypnoticDance:

			if (critical) {
				return "Your attack was critical and increased its lust in " + Mathf.Round(lustDMG).ToString()  + " points, also stunning it for one turn!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points !"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.GraciousAttack:
			if (critical) {
				return "Your attack was critical, increasing its lust in "+ Mathf.Round(lustDMG).ToString()  +" and inflicted " + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "Your attack was succesful, increasing its lust in "+ Mathf.Round(lustDMG).ToString()  +" and inflicted " + Mathf.Round(physDMG).ToString()  + " damage!"; 

			} else if (accuracy - DEFDodge >= 5) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
			return ""; 
		case NPCData.CharAttacks.RiskyPerformance:
			if (critical) {
				return "Your attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 25) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.Striptease:
			if (critical) {
				return "Your attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 25) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.CrotchGrab:
			if (critical) {
				return "Your attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points, reducing its lust defense too!"; 
			} else if (accuracy - DEFDodge >= 25) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points, reducing its lust defense too!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.ForcedKissing:
			if (critical) {
				return "Your attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 25) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.IndecentSmile:
			if (critical) {
				return "Your attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points, reducing its lust defense significatly!"; 
			} else if (accuracy - DEFDodge >= 25) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points, reducing its lust defense significantly!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString() + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.Concentration:
			return "You concentrate your power, increasing your magical ability but leaving you more vulnerable to attacks!"; 
		case NPCData.CharAttacks.ProtectiveRitual:
			return "You use a ritual to increase your defenses, but your dodge has been reduced."; 
		case NPCData.CharAttacks.Hex:
			return "You use a hex on your opponent, reducing its magic defense and dodge!"; 
		case NPCData.CharAttacks.IronWill:
			return "You focus to increase your magic resistance, making your mind more strong against seductive attacks, but reducing your dodge."; 
		case NPCData.CharAttacks.HuntersMusk:
			if (critical) {
				return "Your attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points and reducing its lust defense!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString() + " points and redcing its lust defense!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.AlphasAura:
			if (critical) {
				return "Your attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points and reducing the defenses of your enemy!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points and reducing the defenses of your enemy!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.Rending:
			if (critical) {
				return "Your attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points and "+ Mathf.Round(physDMG).ToString()  +" points of damage!"; 
			} else if (accuracy - DEFDodge >= 25) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points and "+ Mathf.Round(physDMG).ToString()  +" points of damage!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}; 
		case NPCData.CharAttacks.FeralBite:
			if (critical) {
				return "Your attack was critical and did " + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 25) {
				return "Your succesfully striked your opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.DemonicAura:
			return "A demonic aura starts to surround you, increasing your persuasion and defense against persuasive attacks."; 
		case NPCData.CharAttacks.SuccubusTouch:
			if (critical) {
				return "Your attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points and reducing its lust defense!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points and reducing its lust defense!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.EnticingShow:
			if (critical) {
				return "Your attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points! You reduced some of your lust, but your body feels extra sensitive right now!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points! You reduced some of your lust, but your body feels extra sensitive right now!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.Charm:
			if (critical) {
				return "Your attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points, stunning it too!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.HornyLeap:
			if (critical) {
				return "Your attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points, reducing its lust defense!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points, reducing its lust defense!"; 
			} else if (accuracy - DEFDodge >= 5) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.BouncyGrab:
			if (critical) {
				return "Your attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.BunnyHump:
			if (critical) {
				return "Your attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.MatingSeason:
			if (critical) {
				return "Your attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points, reducing your lust resistance too!"; 
			} else if (accuracy - DEFDodge >= 25) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points, reducing your lust resistance too!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.EquineCharge:
			if (critical) {
				return "Your attack was critical and did " + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "Your succesfully striked your opponent, doing" + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.WildRide:
			if (critical) {
				return "Your attack was critical and did " + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "Your succesfully striked your opponent, doing" + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.StallionsMusk:
			if (critical) {
				return "Your attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points, reducing its defenses too!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points, reducing its defenses too!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			} 
		case NPCData.CharAttacks.ImpetiousKick:
			if (critical) {
				return "Your attack was critical and did " + Mathf.Round(physDMG).ToString()  + " damage, stunning it too!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "Your succesfully striked your opponent, doing" + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			} 
		case NPCData.CharAttacks.Bash:
			if (critical) {
				return "Your attack was critical and did " + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "Your succesfully striked your opponent, doing" + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 5) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.Slash:
			if (critical) {
				return "Your attack was critical and did " + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "Your succesfully striked your opponent, doing" + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.HardBlow:
			if (critical) {
				return "Your attack was critical and did " + Mathf.Round(physDMG).ToString()  + " damage, reducing its dodge too!"; 
			} else if (accuracy - DEFDodge >= 25) {
				return "Your succesfully striked your opponent, doing" + Mathf.Round(physDMG).ToString()  + " damage, reducing its dodge too!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.LoudSlap:
			if (critical) {
				return "Your attack was critical and did " + Mathf.Round(physDMG).ToString()  + " damage, stunning it for a turn!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "Your succesfully striked your opponent, doing" + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.PocketSand:
		 if (accuracy - DEFDodge >= 40) {
				return "You throwed sand to your enemy face, reducing its attack significantly!";
			} else {
				return "You throwed sand to your enemy but he dodged the attack!";
			}
		case NPCData.CharAttacks.TakeCover:
			return "You run away and take cover, increasing your dodge significantly but reducing your attacks too!"; 
		case NPCData.CharAttacks.TripUp:
			if (critical) {
				return "Your attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.Fondling:
			if (critical) {
				return "Your attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.BodyShowoff:
			if (critical) {
				return "Your attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 5) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.PlayfulChase:
			if (critical) {
				return "Your attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.SelfSpanking:
			if (critical) {
				return "Your attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.SeductiveGesture:
			if (accuracy - DEFDodge >= 20) {
				return "You seductive gestures work on your opponent, reducing its lust defenses!";
			} else {
				return "Your gestures had no impact on your opponent!";
			}
		case NPCData.CharAttacks.Heal:
			return "You heal yourself " + Mathf.Round(physDMG).ToString() ; 
		case NPCData.CharAttacks.IceSpikes:
			if (critical) {
				return "Your attack was critical and did " + Mathf.Round(physDMG).ToString()  + " damage, reducing its defenses too!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "Your succesfully striked your opponent, doing" + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.FireBall:
			if (critical) {
				return "Your attack was critical and did " + Mathf.Round(physDMG).ToString()  + " damage, burning it too!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "Your succesfully striked your opponent, doing" + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.ElectricShock:
			if (critical) {
				return "Your attack was critical and did " + Mathf.Round(physDMG).ToString()  + " damage, stunning it too!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "Your succesfully striked your opponent, doing" + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.AirBlast:
			if (critical) {
				return "Your attack was critical and did " + Mathf.Round(physDMG).ToString()  + " damage, reducing its attacks too!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "Your succesfully striked your opponent, doing" + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 5) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.Purification:
			return "You reduced " + Mathf.Round(lustDMG).ToString()  + " points of lust!";  
		case NPCData.CharAttacks.PerverseVisions:
			if (critical) {
				return "Your attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 5) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.MagicBinds:
			if (critical) {
				return "Your attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points, reducing its defenses too!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points, reducing its defenses!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.EtherealHands:
			if (critical) {
				return "Your attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 25) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}
		case NPCData.CharAttacks.ArousingWave:
			if (critical) {
				return "Your attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points, leaving perverted thoughts in its mind!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "Your succesfully influenced your opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 5) {
				return "You missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself.";
			} else {
				return "You critically missed your attack and did " + Mathf.Round(physDMG).ToString()  + " damage to yourself!";
			}

		default:
			return "default AttackText, report as a bug";
		}


	}

	public string attackTextEnemy(NPCData.CharAttacks attackid, int npcidATT, int npcidDEF, bool critical, float physDMG, float lustDMG, float accuracy, int slotATT, int slotDEF, float DEFDodge){

		nameATT = loadNameATT (slotATT, npcidATT);
		nameDEF = loadNameDEF (slotDEF, npcidDEF);
		switch (attackid) 
		{
		case NPCData.CharAttacks.PrecisionStrike:
			if (critical) {
				return "The enemy did a critical attack and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "The enemy attack did " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.HoldLine:
			return "The enemy used Hold the line, improving its defense!"; 
		case NPCData.CharAttacks.CombatManuevers:
			return "The enemy used Combat Maneuvers, reducing enemy dodge and defense!"; 
		case NPCData.CharAttacks.ReachingAttack:
			if (critical) {
				return "The enemy reaching attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 25) {
				return "The enemy reaching attack did " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.BreakShield:
			if (critical) {
				return "The enemy attack was critical and " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + " and reduced its defense!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "The enemy attack did " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + " and reduced its defense!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			} 
		case NPCData.CharAttacks.Charge:
			if (critical) {
				return "The enemy charge was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + " and reducing its dodge!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "The enemy succesfully charged its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "and reducing its dodge!"; 
			} else if (accuracy - DEFDodge >= 5) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.WarCry:
			return "The enemy let out a powerful War Cry, increasing its attack!"; 
		case NPCData.CharAttacks.Disarm:
			if (critical) {
				return "The enemy succesfully disarmed its opponent, reducing its attack, and inflicted a critical hit doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "The enemy succesfully disarmed its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "and reducing its attack!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.Meditation:
			return "The enemy meditated, recovering some health and reducing its lust, and increasing its defense too! Although its dodge has been reduced."; 
		case NPCData.CharAttacks.PalmStrike:
			if (critical) {
				return "The enemy inflicted a critical hit and did " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + " and reducing its dodge and defense!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "The enemy succesfully hit its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "and reducing its dodge and defense!"; 
			} else if (accuracy - DEFDodge >= 5) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.FluidStance:
			return "The enemy adopt a fluid stance. increasing its dodge significantly."; 
		case NPCData.CharAttacks.UnexpectedGrapple:
			if (critical) {
				return "The enemy grapple was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + " and reducing its dodge and attack significantly!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "The enemy succesfully hit its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "and reducing its dodge and attack significantly!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.HulkingPotion:
			return "The enemy feel more physically powerful, but somehow more sensitive to pervert thoughts."; 
		case NPCData.CharAttacks.ArousingFumes:
			if (accuracy - DEFDodge >= 20) {
				return "The fumes start to affect the enemy, increasing its by " + Mathf.Round(lustDMG).ToString()  + " to " + nameDEF + "and reducing its lust resistance!"; 
			}else {
				return "The enemy critically missed its attack and the fumes increased its lust by " + Mathf.Round(lustDMG).ToString()  + "!";
			}
		case NPCData.CharAttacks.DebilitatingFumes:
			if (accuracy - DEFDodge >= 20) {
				return "The fumes start to affect " + nameDEF + "and reducing its defense, dodge and attack!"; 
			}else {
				return "The enemy critically missed its attack and the fumes did " + Mathf.Round(physDMG).ToString()  + " damage to you!";
			} 
		case NPCData.CharAttacks.PoisonDarts:
			if (critical) {
				return "The enemy darts critical hit the enemy and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", poisoning it!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "The enemy succesfully hit its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "and poisoning it!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.SmokeBombs:
			return "The enemy use smoke bombs to hide itself, increasing its dodge significantly."; 
		case NPCData.CharAttacks.ConcussiveStrike:
			if (critical) {
				return "The enemy concussive strike is critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", stunning it!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "The enemy concussive strike hit its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.FoulPlay:
			if (critical) {
				return "The enemy attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", also reducing its dodge, defense and attack!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "The enemy succesfully striked its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "and reducing its dodge, defense and attack!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.PoisonDagger:
			if (critical) {
				return "The enemy attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", poisoning it too!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "The enemy succesfully striked its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", poisoning it too!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.ShadowStrike:
			if (critical) {
				return "The enemy attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "The enemy succesfully striked its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.HitAndRun:
			if (critical) {
				return "The enemy attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", increasing its dodge too!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "The enemy succesfully striked its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", increasing its dodge too!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.CloackAndDagger:
			if (critical) {
				return "The enemy attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", increasing its dodge too!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "The enemy succesfully striked its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", increasing its dodge too!"; 
			} else if (accuracy - DEFDodge >= 5) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.SexyDistraction:
			if (critical) {
				return "The enemy attack was critical and increased its lust in " + Mathf.Round(lustDMG).ToString()  + ", also reducing its dodge!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "The enemy increased its lust in " + Mathf.Round(lustDMG).ToString()  + ", also reducing its dodge!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.Smite:
			if (critical) {
				return "The enemy attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "The enemy succesfully striked its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.DivineFavor:
			return "The enemy pray for a higher power for its divine favor, increasing its defenses!"; 
		case NPCData.CharAttacks.Banish:
			if (critical) {
				return "The enemy attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 45) {
				return "The enemy succesfully striked its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.HealingPrayer:
			return "The enemy pray and ask for higher powers to help you, healing you."; 
		case NPCData.CharAttacks.Temptation:
			if (critical) {
				return "The enemy attack was critical and increased its lust in " + Mathf.Round(lustDMG).ToString()  + " points, also reducing its resistance to lust!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "The enemy succesfully striked its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points and reducing its resistance to lust!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.LifeSteal:
			if (critical) {
				return "The enemy attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", healing you that amount!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "The enemy succesfully striked its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", healing you that amount!"; 
			} else if (accuracy - DEFDodge >= 16) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.DarkIntervention:
			if (accuracy - DEFDodge >= 30) {
				return "The enemy succesfuly reduced its enemy attack and defenses!";
			} else {
				return "No higher power helped you on this occasion!";
			}
		case NPCData.CharAttacks.MindVision:
			if (critical) {
				return "The enemy attack was critical and increased its lust in " + Mathf.Round(lustDMG).ToString()  + " points. Its mind is going to be affected by visions for several turns, reducing its lust defense and increasing its arousal!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points. Its mind is going to be affected by visions for several turns, reducing its lust defense and increasing its arousal!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.FeralCry:
			if (accuracy - DEFDodge >= 30) {
				return "The enemy roar has intimidated the opponent, reducing its attack and dodge.";
			} else {
				return "The enemy couldn't affect its opponent!";
			}
		case NPCData.CharAttacks.PinDown:
			if (critical) {
				return "The enemy attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", also reducing its dodge and lust defense!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "The enemy succesfully striked its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "and reducing its dodge and lust defense!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.InescapableGrab:
			if (critical) {
				return "The enemy attack was critical, increasing its lust in "+ Mathf.Round(lustDMG).ToString()  + " points and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "The enemy attack has been succesful, increasing its lust in " + Mathf.Round(lustDMG).ToString()  +" points and inflicting" + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.DominantPresence:
			return "The enemy use its dominant presence, increasing its defenses and attacks, but reducing its dodge."; 
		case NPCData.CharAttacks.RecklessCharge:
			if (critical) {
				return "The enemy attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", also reducing its dodge, defense and attack!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "The enemy succesfully striked its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "and reducing its dodge, defense and attack!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.MercilessAttack:
			if (critical) {
				return "The enemy attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", also reducing its dodge, defense and attack!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "The enemy succesfully striked its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "and reducing its dodge, defense and attack!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.BleedingSwipe:
			if (critical) {
				return "The enemy attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", also reducing its dodge and a bleeding effect!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "The enemy succesfully striked its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "and reducing its dodge and a bleeding effect!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.Taunt:
			if (accuracy - DEFDodge >= 40) {
				return "The enemy succesfuly taunted its opponent, reducing its defense and dodge!";
			} else {
				return "The enemy couldn't taunt its opponent!";
			} 
		case NPCData.CharAttacks.ArrowTraps:
			if (critical) {
				return "The enemy attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "The enemy succesfully striked its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.Ambush:
			if (critical) {
				return "The enemy attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", stunning for some turns too!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "The enemy succesfully striked its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.TacticalRetreat:
			return "The enemy make a tactical retreat, increasing its dodge but reducing its attacks too!"; 
		case NPCData.CharAttacks.Decoy:
			return "The enemy deploy a decoy, confusing its opponent and reducing its attack!"; 
		case NPCData.CharAttacks.TakeAim:
			return "The enemy take aim, significantly reducing the enemy dodge but increasing its attacks!"; 
		case NPCData.CharAttacks.Headshot:
			if (critical) {
				return "The enemy attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", also reducing its attack!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "The enemy succesfully striked its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.DoubleShot:
			if (critical) {
				return "The enemy attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "The enemy succesfully striked its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.SupressingFire:
			if (critical) {
				return "The enemy attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", also reducing its attacks!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "The enemy succesfully striked its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "and reducing its attacks!"; 
			} else if (accuracy - DEFDodge >= 5) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.LitanyOfPain:
			if (critical) {
				return "The enemy attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", also reducing its defenses significantly!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "The enemy succesfully striked its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 5) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.ImplacableSermon:
			if (accuracy - DEFDodge >= 30) {
				return "The enemy sermon has make its enemy more vulnerable to its attacks and its persuasion.";
			} else {
				return "The enemy couldn't persuade its opponent!";
			}
		case NPCData.CharAttacks.Scourge:
			if (critical) {
				return "The enemy attack was critical and increased its lust in " + Mathf.Round(physDMG).ToString()  + " points and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "The enemy attack was succesful and increased its lust in " + Mathf.Round(physDMG).ToString()  + " points and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.IronResolve:
			return "The enemy increase its defenses, getting ready for the worst."; 
		case NPCData.CharAttacks.StunningBlow:
			if (critical) {
				return "The enemy attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", stunning it for some turns!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "The enemy succesfully striked its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + "!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.ShieldWall:
			return "The enemy prepare for incoming attacks, increasing its defense significantly, but reducing its dodge!"; 
		case NPCData.CharAttacks.PepperGrenade:
			if (accuracy - DEFDodge >= 20) {
				return "The gas of the grenade is reducing the enemy attack.";
			} else {
				return "The enemy got out of the way on time, the grenade had no effect on him!";
			}
		case NPCData.CharAttacks.ShieldCharge:
			if (critical) {
				return "The enemy attack was critical and inflicted " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", also increasing its defense!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "The enemy succesfully striked its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage to " + nameDEF + ", also increasing its defense!"; 
			} else if (accuracy - DEFDodge >= 5) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.ElegantStance:
			return "The enemy take an elegant combat stance, significantly increasing its dodge in exchange of its attack."; 
		case NPCData.CharAttacks.HypnoticDance:

			if (critical) {
				return "The enemy attack was critical and increased its lust in " + Mathf.Round(lustDMG).ToString()  + " points, also stunning it for one turn!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points !"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.GraciousAttack:
			if (critical) {
				return "The enemy attack was critical, increasing its lust in "+ Mathf.Round(lustDMG).ToString()  +" and inflicted " + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "The enemy attack was succesful, increasing its lust in "+ Mathf.Round(lustDMG).ToString()  +" and inflicted " + Mathf.Round(physDMG).ToString()  + " damage!"; 

			} else if (accuracy - DEFDodge >= 5) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
			return ""; 
		case NPCData.CharAttacks.RiskyPerformance:
			if (critical) {
				return "The enemy attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 25) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.Striptease:
			if (critical) {
				return "The enemy attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 25) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.CrotchGrab:
			if (critical) {
				return "The enemy attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points, reducing its lust defense too!"; 
			} else if (accuracy - DEFDodge >= 25) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points, reducing its lust defense too!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.ForcedKissing:
			if (critical) {
				return "The enemy attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 25) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.IndecentSmile:
			if (critical) {
				return "The enemy attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points, reducing its lust defense significatly!"; 
			} else if (accuracy - DEFDodge >= 25) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points, reducing its lust defense significantly!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.Concentration:
			return "The enemy concentrate its power, increasing its magical ability but leaving you more vulnerable to attacks!"; 
		case NPCData.CharAttacks.ProtectiveRitual:
			return "The enemy use a ritual to increase its defenses, but its dodge has been reduced."; 
		case NPCData.CharAttacks.Hex:
			return "The enemy use a hex on its opponent, reducing its magic defense and dodge!"; 
		case NPCData.CharAttacks.IronWill:
			return "The enemy focus to increase its magic resistance, making its mind more strong against seductive attacks, but reducing its dodge."; 
		case NPCData.CharAttacks.HuntersMusk:
			if (critical) {
				return "The enemy attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points and reducing its lust defense!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points and redcing its lust defense!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.AlphasAura:
			if (critical) {
				return "The enemy attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points and reducing the defenses of its enemy!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points and reducing the defenses of its enemy!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.Rending:
			if (critical) {
				return "The enemy attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points and "+ Mathf.Round(physDMG).ToString()  +" points of damage!"; 
			} else if (accuracy - DEFDodge >= 25) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points and "+ Mathf.Round(physDMG).ToString()  +" points of damage!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}; 
		case NPCData.CharAttacks.FeralBite:
			if (critical) {
				return "The enemy attack was critical and did " + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 25) {
				return "The enemy succesfully striked its opponent, doing " + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.DemonicAura:
			return "A demonic aura starts to surround you, increasing its persuasion and defense against persuasive attacks."; 
		case NPCData.CharAttacks.SuccubusTouch:
			if (critical) {
				return "The enemy attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points and reducing its lust defense!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points and reducing its lust defense!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.EnticingShow:
			if (critical) {
				return "The enemy attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points! The enemy reduced some of its lust, but its body feels extra sensitive right now!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points! The enemy reduced some of its lust, but its body feels extra sensitive right now!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.Charm:
			if (critical) {
				return "The enemy attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points, stunning it too!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.HornyLeap:
			if (critical) {
				return "The enemy attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points, reducing its lust defense!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points, reducing its lust defense!"; 
			} else if (accuracy - DEFDodge >= 5) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.BouncyGrab:
			if (critical) {
				return "The enemy attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.BunnyHump:
			if (critical) {
				return "The enemy attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.MatingSeason:
			if (critical) {
				return "The enemy attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points, reducing its lust resistance too!"; 
			} else if (accuracy - DEFDodge >= 25) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points, reducing its lust resistance too!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.EquineCharge:
			if (critical) {
				return "The enemy attack was critical and did " + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "The enemy succesfully striked its opponent, doing" + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.WildRide:
			if (critical) {
				return "The enemy attack was critical and did " + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "The enemy succesfully striked its opponent, doing" + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.StallionsMusk:
			if (critical) {
				return "The enemy attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points, reducing its defenses too!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points, reducing its defenses too!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			} 
		case NPCData.CharAttacks.ImpetiousKick:
			if (critical) {
				return "The enemy attack was critical and did " + Mathf.Round(physDMG).ToString()  + " damage, stunning it too!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "The enemy succesfully striked its opponent, doing" + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			} 
		case NPCData.CharAttacks.Bash:
			if (critical) {
				return "The enemy attack was critical and did " + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "The enemy succesfully striked its opponent, doing" + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 5) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.Slash:
			if (critical) {
				return "The enemy attack was critical and did " + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "The enemy succesfully striked its opponent, doing" + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.HardBlow:
			if (critical) {
				return "The enemy attack was critical and did " + Mathf.Round(physDMG).ToString()  + " damage, reducing its dodge too!"; 
			} else if (accuracy - DEFDodge >= 25) {
				return "The enemy succesfully striked its opponent, doing" + Mathf.Round(physDMG).ToString()  + " damage, reducing its dodge too!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.LoudSlap:
			if (critical) {
				return "The enemy attack was critical and did " + Mathf.Round(physDMG).ToString()  + " damage, stunning it for a turn!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "The enemy succesfully striked its opponent, doing" + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.PocketSand:
			if (accuracy - DEFDodge >= 40) {
				return "The enemy throwed sand to its enemy face, reducing its attack significantly!";
			} else {
				return "The enemy throwed sand to its enemy but he dodged the attack!";
			}
		case NPCData.CharAttacks.TakeCover:
			return "The enemy run away and take cover, increasing its dodge significantly but reducing its attacks too!"; 
		case NPCData.CharAttacks.TripUp:
			if (critical) {
				return "The enemy attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.Fondling:
			if (critical) {
				return "The enemy attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 40) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.BodyShowoff:
			if (critical) {
				return "The enemy attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 5) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.PlayfulChase:
			if (critical) {
				return "The enemy attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.SelfSpanking:
			if (critical) {
				return "The enemy attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.SeductiveGesture:
			if (accuracy - DEFDodge >= 20) {
				return "The enemy seductive gestures work on its opponent, reducing its lust defenses!";
			} else {
				return "The enemy gestures had no impact on its opponent!";
			}
		case NPCData.CharAttacks.Heal:
			return "The enemy heal itself " + Mathf.Round(physDMG).ToString() ; 
		case NPCData.CharAttacks.IceSpikes:
			if (critical) {
				return "The enemy attack was critical and did " + Mathf.Round(physDMG).ToString()  + " damage, reducing its defenses too!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "The enemy succesfully striked its opponent, doing" + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.FireBall:
			if (critical) {
				return "The enemy attack was critical and did " + Mathf.Round(physDMG).ToString()  + " damage, burning it too!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "The enemy succesfully striked its opponent, doing" + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.ElectricShock:
			if (critical) {
				return "The enemy attack was critical and did " + Mathf.Round(physDMG).ToString()  + " damage, stunning it too!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "The enemy succesfully striked its opponent, doing" + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.AirBlast:
			if (critical) {
				return "The enemy attack was critical and did " + Mathf.Round(physDMG).ToString()  + " damage, reducing its attacks too!"; 
			} else if (accuracy - DEFDodge >= 15) {
				return "The enemy succesfully striked its opponent, doing" + Mathf.Round(physDMG).ToString()  + " damage!"; 
			} else if (accuracy - DEFDodge >= 5) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.Purification:
			return "The enemy reduced " + Mathf.Round(lustDMG).ToString()  + " points of lust!";  
		case NPCData.CharAttacks.PerverseVisions:
			if (critical) {
				return "The enemy attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 5) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.MagicBinds:
			if (critical) {
				return "The enemy attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points, reducing its defenses too!"; 
			} else if (accuracy - DEFDodge >= 30) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points, reducing its defenses!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.EtherealHands:
			if (critical) {
				return "The enemy attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 25) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 10) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}
		case NPCData.CharAttacks.ArousingWave:
			if (critical) {
				return "The enemy attack was critical and increased the enemy lust in " + Mathf.Round(lustDMG).ToString()  + " points, leaving perverted thoughts in its mind!"; 
			} else if (accuracy - DEFDodge >= 20) {
				return "The enemy succesfully influenced its opponent, increasing its lust in " + Mathf.Round(lustDMG).ToString()  + " points!"; 
			} else if (accuracy - DEFDodge >= 5) {
				return "The enemy missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself.";
			} else {
				return "The enemy critically missed its attack and did " + Mathf.Round(physDMG).ToString()  + " damage to itself!";
			}

		default:
			return "default AttackText, report as a bug";

		}


	}




	string loadNameATT(int slotATT, int npcidATT){


		i = 0;
		if (slotATT == 0) {
			Debug.Log ("Looking for MC name at attack text");
			return GameControl.playerName;

		} else if (slotATT <= 3) {
			if (npcidATT >= 10000000) {
				while (i < NPCCharList.CharRetainers.Count) {
					if (NPCCharList.CharRetainers [i].charID == npcidATT) {
						return NPCCharList.CharRetainers [i].charName;

					}
					i++; 
				}
			} else {
				while (i < NPCCharList.CharFollower.Count) {
					if (NPCCharList.CharFollower [i].charID == npcidATT) {
						return NPCCharList.CharFollower [i].charName;
					}
					i++; 
				}

			}
		} else {
			while(i < NPCCharList.CharMonster.Count){
				if (NPCCharList.CharMonster [i].charID == npcidATT) {
					return NPCCharList.CharMonster [i].charName;
				}
				i++; 
			}
		}
		return "this is a bug on loadNameATT at AttackText";
	}


	string loadNameDEF(int slot, int npcidDEF){


		i = 0;
		if (slot == 0) {
			Debug.Log ("Looking for MC name at attack text");
			return GameControl.playerName;

		} else if (slot <= 3) {
			if (npcidDEF >= 10000000) {
				while (i < NPCCharList.CharRetainers.Count) {
					if (NPCCharList.CharRetainers [i].charID == npcidDEF) {
						return NPCCharList.CharRetainers [i].charName;

					}
					i++; 
				}
			} else {
				while (i < NPCCharList.CharFollower.Count) {
					if (NPCCharList.CharFollower [i].charID == npcidDEF) {
						return NPCCharList.CharFollower [i].charName;
					}
					i++; 
				}

			}
		} else {
			while(i < NPCCharList.CharMonster.Count){
				if (NPCCharList.CharMonster [i].charID == npcidDEF) {
					return NPCCharList.CharMonster [i].charName;
				}
				i++; 
			}
		}
		return "this is a bug on loadNameDEF at AttackText";
	}






}
