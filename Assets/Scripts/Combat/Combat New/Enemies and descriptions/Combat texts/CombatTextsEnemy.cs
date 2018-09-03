using UnityEngine;
using System.Collections;

public class CombatTextsEnemy  {

	public static string textVictory(){
		NPCData.CharRace charRace = NPCCharList.CharMonster[0].charRace;
		switch (charRace) {
		case NPCData.CharRace.Human:
			return CombatVictoryTextsEnemyGeneric.textGeneric ();
			//return CombatVictoryTextsEnemyHuman.enemyHumanVictory();
		case NPCData.CharRace.Wolf:
			return CombatVictoryTextsEnemyWolf.enemyWolfVictory();
		default:
			return CombatVictoryTextsEnemyGeneric.textGeneric ();
		}

	}

	// NEED TO ADD NON GENERIC ONES
	public static string textDefeat(){
		NPCData.CharRace charRace = NPCCharList.CharMonster[0].charRace;
		switch (charRace) {
		case NPCData.CharRace.Human:
			return CombatDefeatTextsEnemyGeneric.defeatGeneric ();
		case NPCData.CharRace.Wolf:
			return CombatDefeatTextsEnemyGeneric.defeatGeneric ();

		default:
			return CombatDefeatTextsEnemyGeneric.defeatGeneric ();
		}

	}








}
