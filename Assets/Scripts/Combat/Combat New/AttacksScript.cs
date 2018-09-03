using UnityEngine;
using System.Collections;


public class AttacksScript : MonoBehaviour {
	int i; 


	static int iterator; 
	float accuracy; 
	int hashcode = GameControl.playerName.GetHashCode();

	AttackCritical attackCritical = new AttackCritical();
	CombatEffects combatEffects = new CombatEffects();
	PhysDamage physDamage = new PhysDamage();
	LustDamage lustDamage = new LustDamage();
	AttackText attackText = new AttackText();


	// ATT retainer is if the Attacker (the one doing damage) is a retainer (so the MC side) or an enemy, this is relevant because retainers are in a different list than enemies 
	public string attack (NPCData.CharAttacks attackid, int slotATT, int slotDEF, int npcidATT, int npcidDEF, bool ATTally, float DEFPhys, float DEFLust, float DEFMag, float DEFDodge, float ATTPhys, float ATTLust, float ATTMag, float ATTMent)
	{
		Debug.Log ("start of AttackScript - attack");
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		accuracy = Random.Range (30, 100); // also is accuracy for the attackdamage script

		if(combatEffects.effectAdd(attackid, accuracy, DEFDodge))
		{
			if (combatEffects.effectBuff (attackid, accuracy)) {
				switch (slotATT) {
				case 0:
					CombatScript.ch0Effects.Add (new CombatEffects ());
					CombatScript.ch0Effects [CombatScript.ch0Effects.Count - 1] = combatEffects.designEffects (attackid, CombatScript.ch0Effects [CombatScript.ch0Effects.Count - 1]); 
					Debug.Log ("AttackScript - attack: switch(slot) case 0");
					break;
				case 1:
					CombatScript.ch1Effects.Add (new CombatEffects ());
					CombatScript.ch1Effects [CombatScript.ch1Effects.Count - 1] = combatEffects.designEffects (attackid, CombatScript.ch1Effects [CombatScript.ch1Effects.Count - 1]); 
					break;
				case 2:
					CombatScript.ch2Effects.Add (new CombatEffects ());
					CombatScript.ch2Effects [CombatScript.ch2Effects.Count - 1] = combatEffects.designEffects (attackid, CombatScript.ch2Effects [CombatScript.ch2Effects.Count - 1]); 
					break;
				case 3:
					CombatScript.ch3Effects.Add (new CombatEffects ());
					CombatScript.ch3Effects [CombatScript.ch3Effects.Count - 1] = combatEffects.designEffects (attackid, CombatScript.ch3Effects [CombatScript.ch3Effects.Count - 1]); 
					break;
				case 4:
					CombatScript.ch4Effects.Add (new CombatEffects ());
					CombatScript.ch4Effects [CombatScript.ch4Effects.Count - 1] = combatEffects.designEffects (attackid, CombatScript.ch4Effects [CombatScript.ch4Effects.Count - 1]); 
					break;
				case 5:
					CombatScript.ch5Effects.Add (new CombatEffects ());
					CombatScript.ch5Effects [CombatScript.ch5Effects.Count - 1] = combatEffects.designEffects (attackid, CombatScript.ch5Effects [CombatScript.ch5Effects.Count - 1]); 
					break;
				case 6:
					CombatScript.ch6Effects.Add (new CombatEffects ());
					CombatScript.ch6Effects [CombatScript.ch6Effects.Count - 1] = combatEffects.designEffects (attackid, CombatScript.ch6Effects [CombatScript.ch6Effects.Count - 1]); 
					break;
				case 7:
					CombatScript.ch7Effects.Add (new CombatEffects ());
					CombatScript.ch7Effects [CombatScript.ch7Effects.Count - 1] = combatEffects.designEffects (attackid, CombatScript.ch7Effects [CombatScript.ch7Effects.Count - 1]); 
					break;

				}
			} else {

				switch (slotDEF) {
				case 0:
					CombatScript.ch0Effects.Add (new CombatEffects ());
					CombatScript.ch0Effects [CombatScript.ch0Effects.Count - 1] = combatEffects.designEffects (attackid, CombatScript.ch0Effects [CombatScript.ch0Effects.Count - 1]); 
					Debug.Log ("AttackScript - attack: switch(slot) case 0");
					break;
				case 1:
					CombatScript.ch1Effects.Add (new CombatEffects ());
					CombatScript.ch1Effects [CombatScript.ch1Effects.Count - 1] = combatEffects.designEffects (attackid, CombatScript.ch1Effects [CombatScript.ch1Effects.Count - 1]); 
					break;
				case 2:
					CombatScript.ch2Effects.Add (new CombatEffects ());
					CombatScript.ch2Effects [CombatScript.ch2Effects.Count - 1] = combatEffects.designEffects (attackid, CombatScript.ch2Effects [CombatScript.ch2Effects.Count - 1]); 
					break;
				case 3:
					CombatScript.ch3Effects.Add (new CombatEffects ());
					CombatScript.ch3Effects [CombatScript.ch3Effects.Count - 1] = combatEffects.designEffects (attackid, CombatScript.ch3Effects [CombatScript.ch3Effects.Count - 1]); 
					break;
				case 4:
					CombatScript.ch4Effects.Add (new CombatEffects ());
					CombatScript.ch4Effects [CombatScript.ch4Effects.Count - 1] = combatEffects.designEffects (attackid, CombatScript.ch4Effects [CombatScript.ch4Effects.Count - 1]); 
					break;
				case 5:
					CombatScript.ch5Effects.Add (new CombatEffects ());
					CombatScript.ch5Effects [CombatScript.ch5Effects.Count - 1] = combatEffects.designEffects (attackid, CombatScript.ch5Effects [CombatScript.ch5Effects.Count - 1]); 
					break;
				case 6:
					CombatScript.ch6Effects.Add (new CombatEffects ());
					CombatScript.ch6Effects [CombatScript.ch6Effects.Count - 1] = combatEffects.designEffects (attackid, CombatScript.ch6Effects [CombatScript.ch6Effects.Count - 1]); 
					break;
				case 7:
					CombatScript.ch7Effects.Add (new CombatEffects ());
					CombatScript.ch7Effects [CombatScript.ch7Effects.Count - 1] = combatEffects.designEffects (attackid, CombatScript.ch7Effects [CombatScript.ch7Effects.Count - 1]); 
					break;

				}

			}


		}




		bool critical = attackCritical.critical (attackid, DEFDodge, accuracy);
		float physDMG;
		float lustDMG; 
		physDMG = physDamage.attackCalculation(attackid, npcidATT, npcidDEF, ATTally, DEFPhys, DEFLust, DEFMag, DEFDodge, ATTPhys, ATTLust, ATTMent, ATTMag, accuracy, critical);
		lustDMG = lustDamage.attackCalculation(attackid, npcidATT, npcidDEF, ATTally, DEFPhys, DEFLust, DEFMag, DEFDodge, ATTPhys, ATTLust, ATTMag, ATTMent, accuracy, critical);

		if (ATTally) {
			return attackText.attackTextAlly(attackid, npcidATT, npcidDEF, critical, physDMG, lustDMG, accuracy, slotATT, slotDEF, DEFDodge);

		} else {
			return attackText.attackTextEnemy(attackid, npcidATT, npcidDEF, critical, physDMG, lustDMG, accuracy, slotATT, slotDEF, DEFDodge);

		}



		/*switch (attackid) {
		case NPCData.CharAttacks.PrecisionStrike:
			physDMG = physDamage.attackCalculation(attackid, npcidATT, npcidDEF, ATTally, DEFPhys, DEFLust, DEFMag, DEFDodge, ATTPhys, ATTLust, ATTMent, ATTMag, accuracy, critical);
			lustDMG = lustDamage.attackCalculation(attackid, npcidATT, npcidDEF, ATTally, DEFPhys, DEFLust, DEFMag, DEFDodge, ATTPhys, ATTLust, ATTMag, ATTMent, accuracy, critical);
			return attackText.attackText(attackid, npcidATT, npcidDEF, critical, physDMG, lustDMG, accuracy, slotATT, slotDEF);
		default:
			return "This is a bug in AttackScript, report it.";

		}*/
			
	}







}
