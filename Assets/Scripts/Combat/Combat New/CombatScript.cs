using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class CombatScript : MonoBehaviour {
	int i; 
	int totalParty; // how many party members there are 
	static int iterator; 
	//int randNum;
	int hashcode = GameControl.playerName.GetHashCode();

	public int location; 
	public int enemyDescr;
	public int victoryText;
	public int defeatText;

	bool slot0alive, slot1alive, slot2alive, slot3alive, slot4alive, slot5alive, slot6alive, slot7alive; // change to bool instead 
	bool[] charAlive = new bool[8];
	public static bool[] stunned = new bool[8]; 

	public Text Board; 
	string combatresults; 

	public Canvas char0Pan, char1Pan, char2Pan, char3Pan, victoryPanel, rewardPanel, defeatPanel, endTurnPanel;


	CombatEffects combatEffects = new CombatEffects();
	CombatEnemyDescription combatEnemyDescription = new CombatEnemyDescription();
	CombatLocationDescription combatLocationDescription = new CombatLocationDescription();

	static public List<CombatEffects> ch0Effects = new List<CombatEffects> ();
	static public List<CombatEffects> ch1Effects = new List<CombatEffects> ();
	static public List<CombatEffects> ch2Effects = new List<CombatEffects> ();
	static public List<CombatEffects> ch3Effects = new List<CombatEffects> ();
	static public List<CombatEffects> ch4Effects = new List<CombatEffects> ();
	static public List<CombatEffects> ch5Effects = new List<CombatEffects> ();
	static public List<CombatEffects> ch6Effects = new List<CombatEffects> ();
	static public List<CombatEffects> ch7Effects = new List<CombatEffects> ();

	static public float[,] chMod = new float[8,7];


	int slot0id = 0, slot1id = WorldControl.partyID1, slot2id = WorldControl.partyID2, slot3id = WorldControl.partyID3, slot4id, slot5id, slot6id, slot7id; 
	int iSlot1, iSlot2, iSlot3, iSlot4, iSlot5, iSlot6, iSlot7; //where in their list they are 

	AttacksScript attackScript = new AttacksScript();

	

	static public int slotDEF;
	public void selectEnemy(int slotdef){
		slotDEF = slotdef; 
	}
	static public int slotATT; // this is the person who attacks, from 0 to 7
	public void selectAttacker(int slotatt){
		slotATT = slotatt; 
	}
		
	//main player turn 
	public void selectAttack(int skillselector){

		if (slotATT == 0) {
			Board.text = attackScript.attack (GameControl.MCAttacks [skillselector], slotATT, slotDEF,  0, NPCCharList.CharMonster [slotDEF-4].charID, true, NPCCharList.CharMonster [slotDEF-4].charCombatDefense + chMod[slotDEF,3], NPCCharList.CharMonster [slotDEF-4].charLustDefense + chMod[slotDEF,4], NPCCharList.CharMonster [slotDEF - 4].charMagicDefense + chMod[slotDEF,5], NPCCharList.CharMonster [slotDEF - 4].charDodge + chMod[slotDEF,6], (((GameControl.attPhysical + GameControl.attBonus[0])/100)+((GameControl.coreSkillMartial + GameControl.coreSkillBonus[0])/100)* GameControl.charCombatAttack) + chMod[0,0] /*attPhys*/, (((GameControl.attSocial + GameControl.attBonus[2])/100)+((GameControl.coreSkillPersuasion+ GameControl.coreSkillBonus[6])/100)* GameControl.charLustAttack) + chMod[0,1], ((GameControl.attMental + GameControl.attBonus[1])/100)+((GameControl.coreSkillTactics + GameControl.coreSkillBonus[3])/100) + chMod[0,0], ((GameControl.attMagicPower + GameControl.attBonus[3])/100) + chMod[0,2]);  
		}else if(slotATT == 1){
			if (slot1id <= 10000000) {
				Board.text = attackScript.attack (NPCCharList.CharFollower[iSlot1].charAttacks[skillselector], slotATT, slotDEF,  slot1id, NPCCharList.CharMonster [slotDEF - 4].charID, true, NPCCharList.CharMonster [slotDEF - 4].charCombatDefense + chMod[slotDEF,3], NPCCharList.CharMonster [slotDEF - 4].charLustDefense + chMod[slotDEF,4], NPCCharList.CharMonster [slotDEF - 4].charMagicDefense + chMod[slotDEF,5], NPCCharList.CharMonster [slotDEF - 4].charDodge + chMod[slotDEF,6], (((NPCCharList.CharFollower[iSlot1].attPhysical + NPCCharList.CharFollower[iSlot1].attBonus[0])/100)+((NPCCharList.CharFollower[iSlot1].coreSkillMartial + NPCCharList.CharFollower[iSlot1].coreSkillBonus[0])/100) * NPCCharList.CharFollower[iSlot1].charCombatAttack) + chMod[slotATT,0], ((NPCCharList.CharFollower[iSlot1].attSocial+NPCCharList.CharFollower[iSlot1].attBonus[2])/100)+ ((NPCCharList.CharFollower[iSlot1].coreSkillPersuasion + NPCCharList.CharFollower[iSlot1].coreSkillBonus[6])/100) + chMod[slotATT,1], ((NPCCharList.CharFollower[iSlot1].attMental+NPCCharList.CharFollower[iSlot1].attBonus[1])/100)+ ((NPCCharList.CharFollower[iSlot1].coreSkillTactics+ NPCCharList.CharFollower[iSlot1].coreSkillBonus[3])/100) + chMod[slotATT,0],((NPCCharList.CharFollower[iSlot1].attMagicPower + NPCCharList.CharFollower[iSlot1].attBonus[3])/100) + chMod[slotATT,2]);  
			} else {
				Board.text = attackScript.attack (NPCCharList.CharRetainers[iSlot1].charAttacks[skillselector], slotATT, slotDEF,  slot1id, NPCCharList.CharMonster [slotDEF - 4].charID, true, NPCCharList.CharMonster [slotDEF - 4].charCombatDefense + chMod[slotDEF,3], NPCCharList.CharMonster [slotDEF - 4].charLustDefense + chMod[slotDEF,4], NPCCharList.CharMonster [slotDEF - 4].charMagicDefense + chMod[slotDEF,5], NPCCharList.CharMonster [slotDEF - 4].charDodge + chMod[slotDEF,6], ((NPCCharList.CharRetainers[iSlot1].attPhysical + NPCCharList.CharRetainers[iSlot1].attBonus[0])/100)+((NPCCharList.CharRetainers[iSlot1].coreSkillMartial + NPCCharList.CharRetainers[iSlot1].coreSkillBonus[0])/100) + chMod[slotATT,0], ((NPCCharList.CharRetainers[iSlot1].attSocial+NPCCharList.CharRetainers[iSlot1].attBonus[2])/100)+ ((NPCCharList.CharRetainers[iSlot1].coreSkillPersuasion + NPCCharList.CharRetainers[iSlot1].coreSkillBonus[6])/100) + chMod[slotATT,1], ((NPCCharList.CharRetainers[iSlot1].attBonus[1])/100)+ ((NPCCharList.CharRetainers[iSlot1].coreSkillTactics+ NPCCharList.CharRetainers[iSlot1].coreSkillBonus[3])/100) + chMod[slotATT,0],((NPCCharList.CharRetainers[iSlot1].attMagicPower + NPCCharList.CharRetainers[iSlot1].attBonus[3])/100) + chMod[slotATT,2]);  
			}
			Debug.Log ("selectAttack at slot 0");

		}else if(slotATT == 2){
			if (slot2id <= 10000000) {
				Board.text = attackScript.attack (NPCCharList.CharFollower[iSlot2].charAttacks[skillselector], slotATT, slotDEF,  slot2id, NPCCharList.CharMonster [slotDEF - 4].charID, true, NPCCharList.CharMonster [slotDEF - 4].charCombatDefense + chMod[slotDEF,3], NPCCharList.CharMonster [slotDEF - 4].charLustDefense + chMod[slotDEF,4], NPCCharList.CharMonster [slotDEF - 4].charMagicDefense + chMod[slotDEF,5], NPCCharList.CharMonster [slotDEF - 4].charDodge + chMod[slotDEF,6], ((NPCCharList.CharFollower[iSlot2].attPhysical + NPCCharList.CharFollower[iSlot2].attBonus[0])/100)+((NPCCharList.CharFollower[iSlot2].coreSkillMartial + NPCCharList.CharFollower[iSlot2].coreSkillBonus[0])/100) + chMod[slotATT,0], ((NPCCharList.CharFollower[iSlot2].attSocial+NPCCharList.CharFollower[iSlot2].attBonus[2])/100)+ ((NPCCharList.CharFollower[iSlot2].coreSkillPersuasion + NPCCharList.CharFollower[iSlot2].coreSkillBonus[6])/100) + chMod[slotATT,1], ((NPCCharList.CharFollower[iSlot2].attMental+NPCCharList.CharFollower[iSlot2].attBonus[1])/100)+ ((NPCCharList.CharFollower[iSlot2].coreSkillTactics+ NPCCharList.CharFollower[iSlot2].coreSkillBonus[3])/100) + chMod[slotATT,0],((NPCCharList.CharFollower[iSlot2].attMagicPower + NPCCharList.CharFollower[iSlot2].attBonus[3])/100) + chMod[slotATT,2]);
			} else { 
				Board.text = attackScript.attack (NPCCharList.CharRetainers[iSlot2].charAttacks[skillselector], slotATT, slotDEF,  slot2id, NPCCharList.CharMonster [slotDEF - 4].charID, true, NPCCharList.CharMonster [slotDEF - 4].charCombatDefense + chMod[slotDEF,3], NPCCharList.CharMonster [slotDEF - 4].charLustDefense + chMod[slotDEF,4], NPCCharList.CharMonster [slotDEF - 4].charMagicDefense + chMod[slotDEF,5], NPCCharList.CharMonster [slotDEF - 4].charDodge + chMod[slotDEF,6], ((NPCCharList.CharRetainers[iSlot2].attPhysical + NPCCharList.CharRetainers[iSlot2].attBonus[0])/100)+((NPCCharList.CharRetainers[iSlot2].coreSkillMartial + NPCCharList.CharRetainers[iSlot2].coreSkillBonus[0])/100) + chMod[slotATT,0], ((NPCCharList.CharRetainers[iSlot2].attSocial+NPCCharList.CharRetainers[iSlot2].attBonus[2])/100)+ ((NPCCharList.CharRetainers[iSlot2].coreSkillPersuasion + NPCCharList.CharRetainers[iSlot2].coreSkillBonus[6])/100) + chMod[slotATT,1], ((NPCCharList.CharRetainers[iSlot2].attBonus[1])/100)+ ((NPCCharList.CharRetainers[iSlot2].coreSkillTactics+ NPCCharList.CharRetainers[iSlot2].coreSkillBonus[3])/100) + chMod[slotATT,0],((NPCCharList.CharRetainers[iSlot2].attMagicPower + NPCCharList.CharRetainers[iSlot2].attBonus[3])/100) + chMod[slotATT,2]);   
			}

		}else if(slotATT == 3){
			if (slot3id <= 10000000) {
				Board.text = attackScript.attack (NPCCharList.CharFollower[iSlot3].charAttacks[skillselector], slotATT, slotDEF,  slot3id, NPCCharList.CharMonster [slotDEF - 4].charID, true, NPCCharList.CharMonster [slotDEF - 4].charCombatDefense + chMod[slotDEF,3], NPCCharList.CharMonster [slotDEF - 4].charLustDefense + chMod[slotDEF,4], NPCCharList.CharMonster [slotDEF - 4].charMagicDefense + chMod[slotDEF,5], NPCCharList.CharMonster [slotDEF - 4].charDodge + chMod[slotDEF,6], ((NPCCharList.CharFollower[iSlot3].attPhysical + NPCCharList.CharFollower[iSlot3].attBonus[0])/100)+((NPCCharList.CharFollower[iSlot3].coreSkillMartial + NPCCharList.CharFollower[iSlot3].coreSkillBonus[0])/100) + chMod[slotATT,0], ((NPCCharList.CharFollower[iSlot3].attSocial+NPCCharList.CharFollower[iSlot3].attBonus[2])/100)+ ((NPCCharList.CharFollower[iSlot3].coreSkillPersuasion + NPCCharList.CharFollower[iSlot3].coreSkillBonus[6])/100) + chMod[slotATT,1], ((NPCCharList.CharFollower[iSlot3].attMental+NPCCharList.CharFollower[iSlot3].attBonus[1])/100)+ ((NPCCharList.CharFollower[iSlot3].coreSkillTactics+ NPCCharList.CharFollower[iSlot3].coreSkillBonus[3])/100) + chMod[slotATT,0],((NPCCharList.CharFollower[iSlot3].attMagicPower + NPCCharList.CharFollower[iSlot3].attBonus[3])/100) + chMod[slotATT,2]);  
			} else {
				Board.text = attackScript.attack (NPCCharList.CharRetainers[iSlot3].charAttacks[skillselector], slotATT, slotDEF,  slot3id, NPCCharList.CharMonster [slotDEF - 4].charID, true, NPCCharList.CharMonster [slotDEF - 4].charCombatDefense + chMod[slotDEF,3], NPCCharList.CharMonster [slotDEF - 4].charLustDefense + chMod[slotDEF,4], NPCCharList.CharMonster [slotDEF - 4].charMagicDefense + chMod[slotDEF,5], NPCCharList.CharMonster [slotDEF - 4].charDodge + chMod[slotDEF,6], ((NPCCharList.CharRetainers[iSlot3].attPhysical + NPCCharList.CharRetainers[iSlot3].attBonus[0])/100)+((NPCCharList.CharRetainers[iSlot3].coreSkillMartial + NPCCharList.CharRetainers[iSlot3].coreSkillBonus[0])/100) + chMod[slotATT,0], ((NPCCharList.CharRetainers[iSlot3].attSocial+NPCCharList.CharRetainers[iSlot3].attBonus[2])/100)+ ((NPCCharList.CharRetainers[iSlot3].coreSkillPersuasion + NPCCharList.CharRetainers[iSlot3].coreSkillBonus[6])/100) + chMod[slotATT,1], ((NPCCharList.CharRetainers[iSlot3].attBonus[1])/100)+ ((NPCCharList.CharRetainers[iSlot3].coreSkillTactics+ NPCCharList.CharRetainers[iSlot3].coreSkillBonus[3])/100) + chMod[slotATT,0],((NPCCharList.CharRetainers[iSlot3].attMagicPower + NPCCharList.CharRetainers[iSlot3].attBonus[3])/100) + chMod[slotATT,2]);   
			}

		}
			
		switch (slotATT) {
		case 0:
			if (slot1alive || slot2alive || slot3alive) {
				loadAttackMenu (slotATT+1);
			} else {
				combatPhase ();
			}
			break;
		case 1: 
			if (slot2alive || slot3alive) {
				loadAttackMenu (slotATT+1);
			} else {
				combatPhase ();
			}
			break;

		case 2:
			if (slot3alive) {
				loadAttackMenu (slotATT+1);
			} else {
				combatPhase ();
			}
			break;

		case 3:
			combatPhase ();
			break;
		}





	}


	void loadAttackMenu(int chturn){
		if (slot0alive || slot1alive || slot2alive || slot3alive) {
			switch (chturn) {
			case 0:
				if (stunned [0] && stunned [1] && stunned [2] && stunned [3]) {
					combatPhase ();
				}
				if (slot0alive) {
					hideAllPanel ();
					char0Pan.sortingOrder = 500; 
				} else { loadAttackMenu (1);}
				break;
			case 1:
				if (stunned [1] && stunned [2] && stunned [3]) {
					combatPhase ();
				}
				if (slot1alive) {
					hideAllPanel ();
					char1Pan.sortingOrder = 500; 
				} else { loadAttackMenu (2);}
				break;
			case 2:
				if (stunned [2] && stunned [3]) {
					combatPhase ();
				}
				if (slot2alive) {
					hideAllPanel ();
					char2Pan.sortingOrder = 500; 
				} else { loadAttackMenu (3);}
				break;
			case 3:
				if (stunned [3]) {
					combatPhase ();
					break;
				}
				if (slot3alive) {
					hideAllPanel ();
					char3Pan.sortingOrder = 500; 
				} else { loadAttackMenu (0);}
				break;
			}
		}


	}

	void hideAllPanel(){
		char0Pan.sortingOrder = -500;
		char1Pan.sortingOrder = -500;
		char2Pan.sortingOrder = -500;
		char3Pan.sortingOrder = -500;
		victoryPanel.sortingOrder = -500;
		defeatPanel.sortingOrder = -500;
		endTurnPanel.sortingOrder = -500;
	}



	void combatPhase()
	{
		Array.Clear(chMod, 0, chMod.Length);
		applyEffectEnemies ();
		if (checkEnemiesAlive() == false) {
			Victory ();
		} else {
			enemyAttack ();
		}

		applyEffectsAllies ();
		if (checkPartyAlive () == false) {
			Defeat ();
		} else {
			loadAttackMenu (0);
		}

		Debug.Log ("The MC dodge is " + GameControl.charDodge + " and its bonus is " + chMod[0,6]);
		Debug.Log ("The enemy dodge is " + NPCCharList.CharMonster[0].charDodge+ " and its bonus is " + chMod[4,6]);

	}

	void Victory(){
		Board.text = CombatVictoryText.victoryText (victoryText);
		hideAllPanel ();
		if (WorldControl.dropItem != 0) {
			rewardPanel.sortingOrder = 500;
		} else {
			victoryPanel.sortingOrder = 500;
		}
	}

	public void Defeat(){
		Board.text = CombatDefeatText.defeatText (defeatText);
		hideAllPanel ();
		defeatPanel.sortingOrder = 500; 

	}

	public void Flee(){
		Board.text = "You retreat from battle!";
		hideAllPanel ();
		endTurnPanel.sortingOrder = 500;

	}

	public void takeReward(){
		if (AddItemScript.addReward ()) {
			hideAllPanel ();
			victoryPanel.sortingOrder = 500;
		} else {
			Board.text = "Your inventory is full, throw away an item if you want to take this reward!";
		}
	}

	public void throwReward(){
		hideAllPanel ();
		victoryPanel.sortingOrder = 500;
	}



	void enemyAttack(){
		iterator += 1;
		UnityEngine.Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		//randNum = UnityEngine.Random.Range (0, 100); // also is accuracy for the attackdamage script

		int defslot = UnityEngine.Random.Range (0, totalParty);
		int defid = 0; 
		float defphys = 0;
		float deflust = 0;
		float defmag = 0; 
		float dodge = 0; 
		switch (defslot) {
		case 0: 
			defphys = GameControl.charCombatDefense;
			deflust = GameControl.charLustDefense;
			defmag = GameControl.charMagicDefense;
			dodge = GameControl.charDodge; 

			break;
		case 1:
			defid = slot1id;
			if (slot1id < 10000000) {
				defphys = NPCCharList.CharFollower [iSlot1].charCombatDefense;
				deflust = NPCCharList.CharFollower [iSlot1].charLustDefense;
				defmag = NPCCharList.CharFollower [iSlot1].charMagicDefense;
				dodge = NPCCharList.CharFollower [iSlot1].charDodge;
			} else {
				defphys = NPCCharList.CharRetainers[iSlot1].charCombatDefense;
				deflust = NPCCharList.CharRetainers [iSlot1].charLustDefense;
				defmag = NPCCharList.CharRetainers [iSlot1].charMagicDefense;
				dodge = NPCCharList.CharRetainers [iSlot1].charDodge;
			}

			break;
		case 2:
			defid = slot2id;
			if (slot2id < 10000000) {
				defphys = NPCCharList.CharFollower [iSlot2].charCombatDefense;
				deflust = NPCCharList.CharFollower [iSlot2].charLustDefense;
				defmag = NPCCharList.CharFollower [iSlot2].charMagicDefense;
				dodge = NPCCharList.CharFollower [iSlot2].charDodge;
			} else {
				defphys = NPCCharList.CharRetainers [iSlot2].charCombatDefense;
				deflust = NPCCharList.CharRetainers [iSlot2].charLustDefense;
				defmag = NPCCharList.CharRetainers [iSlot2].charMagicDefense;
				dodge = NPCCharList.CharRetainers [iSlot2].charDodge;
			}
			break; 
		case 3:
			defid = slot3id;
			if (slot3id < 10000000) {
				defphys = NPCCharList.CharFollower [iSlot3].charCombatDefense;
				deflust = NPCCharList.CharFollower [iSlot3].charLustDefense;
				defmag = NPCCharList.CharFollower [iSlot3].charMagicDefense;
				dodge = NPCCharList.CharFollower [iSlot3].charDodge;
			} else {
				defphys = NPCCharList.CharRetainers [iSlot3].charCombatDefense;
				deflust = NPCCharList.CharRetainers [iSlot3].charLustDefense;
				defmag = NPCCharList.CharRetainers [iSlot3].charMagicDefense;
				dodge = NPCCharList.CharRetainers [iSlot3].charDodge;
			}
			break; 
		default:
			break;
		}




		i = 0;
		while (i < NPCCharList.CharMonster.Count)
		{
			Board.text += "\n\n" + attackScript.attack (NPCCharList.CharMonster[i].charAttacks[UnityEngine.Random.Range (0, NPCCharList.CharMonster[i].charAttacks.Count)]/**/, i + 4 /**/,  defslot/**/, NPCCharList.CharMonster[i].charID/**/, defid, false, defphys, deflust, defmag, dodge, (((NPCCharList.CharMonster[i].attPhysical+NPCCharList.CharMonster[i].attBonus[0])/100)+((NPCCharList.CharMonster[i].coreSkillMartial+ NPCCharList.CharMonster[i].coreSkillBonus[0])/100)) + NPCCharList.CharMonster[i].charCombatAttack, ((NPCCharList.CharMonster[i].attSocial + NPCCharList.CharMonster[i].attBonus[2])/100) + ((NPCCharList.CharMonster[i].coreSkillPersuasion + NPCCharList.CharMonster[i].coreSkillBonus[6])/100) + + NPCCharList.CharMonster[i].charLustAttack,((NPCCharList.CharMonster[i].attMental + NPCCharList.CharMonster[i].attBonus[1])/100) +((NPCCharList.CharMonster[i].coreSkillTactics + NPCCharList.CharMonster[i].coreSkillBonus[3])/100) , (NPCCharList.CharMonster[i].attMagicPower + NPCCharList.CharMonster[i].attBonus[3])/100);  

			i++;
		}

	}

	void startingTurn()
	{
		//////////////////////////////////////////////////////////////
		Array.Clear(chMod, 0, chMod.Length);
		//Array.Clear(ch0mod, 0, ch0mod.Length); Array.Clear(ch1mod, 0, ch1mod.Length); Array.Clear(ch2mod, 0, ch2mod.Length); Array.Clear(ch3mod, 0, ch3mod.Length);
		//Array.Clear(ch4mod, 0, ch4mod.Length); Array.Clear(ch5mod, 0, ch5mod.Length); Array.Clear(ch6mod, 0, ch6mod.Length); Array.Clear(ch0mod, 0, ch7mod.Length);
	}

	void loadCharactersID(){


		totalParty = 1;

		i = 0;
		if (slot1id <= 10000000 || slot1id != 0) {
			while (i < NPCCharList.CharFollower.Count) {
				if (NPCCharList.CharFollower [i].charID == slot1id) {
					iSlot1 = i; 
					totalParty = 2; 
					break;
				}
				i++;
			}

		} else if(slot1id != 0) {
			while (i < NPCCharList.CharRetainers.Count) {
				if (NPCCharList.CharRetainers [i].charID == slot1id) {
					iSlot1 = i; 
					totalParty = 2; 
					break;
				}
				i++;
			}

		}


		i = 0;
		if (slot2id <= 10000000) {
			while (i < NPCCharList.CharFollower.Count) {
				if (NPCCharList.CharFollower [i].charID == slot2id) {
					iSlot2 = i; 
					totalParty = 3;
					break;
				}
				i++;
			}
	
		} else if(slot2id !=0) {
			while (i < NPCCharList.CharRetainers.Count) {
				if (NPCCharList.CharRetainers [i].charID == slot2id) {
					iSlot2 = i; 
					totalParty = 3; 
					break;
				}
				i++;
			}


		}



		i = 0;
		if (slot3id <= 10000000) {
			while (i < NPCCharList.CharFollower.Count) {
				if (NPCCharList.CharFollower [i].charID == slot3id) {
					iSlot3 = i; 
					totalParty = 4;
					break;
				}
				i++;
			}

		} else if(slot3id != 0) {
			while (i < NPCCharList.CharRetainers.Count) {
				if (NPCCharList.CharRetainers [i].charID == slot3id) {
					iSlot3 = i; 
					totalParty = 4; 
					break;
				}
				i++;

			}

		}




		//////////////////////////////
		i = 0; 
		while (i < NPCCharList.CharMonster.Count) {
			switch (i) {
			case 0:
				slot4id = NPCCharList.CharMonster [i].charID;
				iSlot4 = 0; 
				break;
			case 1:
				slot5id = NPCCharList.CharMonster [i].charID;
				iSlot5 = 1; 
				break;
			case 2:
				slot6id = NPCCharList.CharMonster [i].charID;
				iSlot6 = 2;
				break;
			case 3:
				slot7id = NPCCharList.CharMonster [i].charID;
				iSlot7 = 3;
				break;
			}
			i++;
		}

	}

	void applyEffectsAllies(){
		//////////////////////////////////////////////////////////////

		i = 0;
		while (i < ch0Effects.Count) 
		{
			ch0Effects [i].cooldown -= 1; 
			if (ch0Effects [i].cooldown < 1) {
				ch0Effects.RemoveAt (i);
				i--; 
			}
			i++; 
		}

		i = 0;
		while (i < ch0Effects.Count) {
			combatEffects.applyEffects (0, 0,  ch0Effects [i]);
			i++; 
		}
		//////////////////////////////////////////////////////////////

		i = 0;
		while (i < ch1Effects.Count) 
		{
			ch1Effects [i].cooldown -= 1; 
			if (ch1Effects [i].cooldown < 1) {
				ch1Effects.RemoveAt (i);
				i--; 
			}
			i++; 
		}

		i = 0;
		while (i < ch1Effects.Count) {
			combatEffects.applyEffects (1, slot1id,  ch1Effects [i]);
			i++; 
		}
		//////////////////////////////////////////////////////////////

		i = 0;
		while (i < ch2Effects.Count) 
		{
			ch2Effects [i].cooldown -= 1; 
			if (ch2Effects [i].cooldown < 1) {
				ch2Effects.RemoveAt (i);
				i--; 
			}
			i++; 
		}

		i = 0;
		while (i < ch2Effects.Count) {
			combatEffects.applyEffects (2, slot2id,  ch2Effects [i]);
			i++; 
		}
		//////////////////////////////////////////////////////////////
		i = 0;
		while (i < ch3Effects.Count) 
		{
			ch3Effects [i].cooldown -= 1; 
			if (ch3Effects [i].cooldown < 1) {
				ch3Effects.RemoveAt (i);
				i--; 
			}
			i++; 
		}

		i = 0;
		while (i < ch3Effects.Count) {
			combatEffects.applyEffects (3, slot3id,  ch3Effects [i]);
			i++; 
		}
	}




	void applyEffectEnemies(){
		//////////////////////////////////////////////////////////////
		i = 0;
		while (i < ch4Effects.Count) 
		{
			ch4Effects [i].cooldown -= 1; 
			if (ch4Effects [i].cooldown < 1) {
				ch4Effects.RemoveAt (i);
				i--; 
			}
			i++; 
		}

		i = 0;
		while (i < ch4Effects.Count) {
			combatEffects.applyEffects (4, slot4id,  ch4Effects [i]);
			i++; 
		}
		//////////////////////////////////////////////////////////////
		i = 0;
		while (i < ch5Effects.Count) 
		{
			ch5Effects [i].cooldown -= 1; 
			if (ch5Effects [i].cooldown < 1) {
				ch5Effects.RemoveAt (i);
				i--; 
			}
			i++; 
		}

		i = 0;
		while (i < ch5Effects.Count) {
			combatEffects.applyEffects (5, slot5id,  ch5Effects [i]);
			i++; 
		}
		//////////////////////////////////////////////////////////////
		i = 0;
		while (i < ch6Effects.Count) 
		{
			ch6Effects [i].cooldown -= 1; 
			if (ch6Effects [i].cooldown < 1) {
				ch6Effects.RemoveAt (i);
				i--; 
			}
			i++; 
		}

		i = 0;
		while (i < ch6Effects.Count) {
			combatEffects.applyEffects (6, slot6id,  ch6Effects [i]);
			i++; 
		}
		//////////////////////////////////////////////////////////////
		i = 0;
		while (i < ch7Effects.Count) 
		{
			ch7Effects [i].cooldown -= 1; 
			if (ch7Effects [i].cooldown < 1) {
				ch7Effects.RemoveAt (i);
				i--; 
			}
			i++; 
		}

		i = 0;
		while (i < ch7Effects.Count) {
			combatEffects.applyEffects (7, slot7id,  ch7Effects [i]);
			i++; 
		}
		//////////////////////////////////////////////////////////////
	}




	bool checkPartyAlive(){

		if (GameControl.actualHealth > 0 && GameControl.actualArousal < GameControl.maxArousal) {
			return true; 
		} else {
			slot0alive = false;
		}


		if (slot1id < 10000000 && slot1id !=0) {
			if (NPCCharList.CharFollower [iSlot1].currentHealth > 0 && NPCCharList.CharFollower [iSlot1].currentArousal < NPCCharList.CharFollower [iSlot1].maxArousal) {
				return true; 
			} else {
				slot1alive = false;
			}
		} else if(slot1id != 0){
			if (NPCCharList.CharRetainers [iSlot1].currentHealth > 0 && NPCCharList.CharFollower [iSlot1].currentArousal < NPCCharList.CharFollower [iSlot1].maxArousal) {
				return true; 
			} else {
				slot1alive = false;
			}
		}


		if (slot2id < 10000000 && slot2id != 0) {
			if (NPCCharList.CharFollower [iSlot2].currentHealth > 0 && NPCCharList.CharFollower [iSlot2].currentArousal < NPCCharList.CharFollower [iSlot2].maxArousal) {
				return true; 
			} else {
				slot2alive = false;
			}
		} else if(slot2id != 0){
			if (NPCCharList.CharRetainers [iSlot2].currentHealth > 0 && NPCCharList.CharFollower [iSlot2].currentArousal < NPCCharList.CharFollower [iSlot2].maxArousal) {
				return true; 
			} else {
				slot2alive = false;
			}
		}


		if (slot3id < 10000000 && slot3id != 0) {
			if (NPCCharList.CharFollower [iSlot3].currentHealth > 0 && NPCCharList.CharFollower [iSlot3].currentArousal < NPCCharList.CharFollower [iSlot3].maxArousal ) {
				return true; 
			} else {
				slot3alive = false;
			}
		} else if(slot3id != 0){
			if (NPCCharList.CharRetainers [iSlot3].currentHealth > 0 && NPCCharList.CharFollower [iSlot3].currentArousal < NPCCharList.CharFollower [iSlot3].maxArousal) {
				return true; 
			} else {
				slot3alive = false;
			}
		}

		return false; 

	}

	bool checkEnemiesAlive(){
		i = 0;
		while (i < NPCCharList.CharMonster.Count) {
			if (NPCCharList.CharMonster [i].currentHealth > 0 && NPCCharList.CharMonster[i].currentArousal < NPCCharList.CharMonster[i].maxArousal) {
				return true;
			} else {
				switch (i) {
				case 0:
					slot4alive = false;
					break;
				case 1:
					slot5alive = false;
					break;
				case 2:
					slot6alive = false;
					break;
				case 3:
					slot7alive = false; 
					break; 

				}

			}
			i++;
		}
		return false; 

	}


	void deleteEnemy(){
		NPCCharList.CharMonster.Clear ();

	}

	void Awake(){

	}


	void Start(){
		Debug.Log ("Start at CombatScript - Start");
		loadCharactersID ();
		Array.Clear(chMod, 0, chMod.Length);

		ch0Effects.Clear(); ch1Effects.Clear(); ch2Effects.Clear(); ch3Effects.Clear(); ch4Effects.Clear (); ch5Effects.Clear (); ch6Effects.Clear (); ch7Effects.Clear ();
	

		Board.text = combatLocationDescription.locationDescription(location); 
		Board.text += "\n\n" + combatEnemyDescription.enemyDescription (enemyDescr);




	}

}
