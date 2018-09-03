using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CombatSexSceneDefeat : MonoBehaviour {

	public Text Board; 
	public Canvas endTurnPan, combatPan; 


	public void yield(){
		if (NPCCharList.CharMonster [0].charRace == NPCData.CharRace.Elf) {
			Board.text = CombatSexSceneDefeatElf.elfSexScene ();

		}else if (NPCCharList.CharMonster [0].charRace == NPCData.CharRace.Wolf) {
			Board.text = CombatSexSceneDefeatWolf.wolfSexScene ();
		}else if (NPCCharList.CharMonster [0].charRace == NPCData.CharRace.dragon) {
			Board.text = CombatSexSceneDefeatDragon.dragonSexScene ();
		}else {
			Board.text = CombatSexSceneDefeatGeneric.genericSexScene ();

		}
		combatPan.sortingOrder = -500;
		endTurnPan.sortingOrder = 500;
	}






}
