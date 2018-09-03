using UnityEngine;
using System.Collections;

public class CombatEnemyDescription : MonoBehaviour {
	string description;
	string HESHE, heshe;
	string HISHER, hisher;

	CombatEnemyDescriptionTexts combatEnemyDescriptionTexts = new CombatEnemyDescriptionTexts();

	public string enemyDescription(int selector){
		switch (selector) {
		case 0:
			return combatEnemyDescriptionTexts.genericEnemyDescription ();
		case 13000:
			return combatEnemyDescriptionTexts.genericEnemyDescription ();

			/*if (QuestControl.albaHelp) {
				return "";
			} else {
				return "";
			}*/
		default:
			return combatEnemyDescriptionTexts.genericEnemyDescription ();

		}

	
	}






}
