using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class combatEnslave : MonoBehaviour {

	public Button buttCapture;
	EndTurn endTurn = new EndTurn();



	bool checkRetainers(){
		if (QuestControl.abbadonQuest < 3) {
			return false;
		}
		if (RulesNPC.savedRules.Count >= 50) {
			return false;
		}
		return true;
	}

	public void captureInfo(){
		if (QuestControl.abbadonQuest < 3) {
			hoverCustomText.msg = "You need to unlock the barracks before you can capture! Talk with Abbadon about getting a captain of the guard!";
		} else if (RulesNPC.savedRules.Count >= 50) {
			hoverCustomText.msg = "Your castle is full! You need to fire workers or sell slaves to make room for this capture!";

		}else {
			hoverCustomText.msg = "Enemies you capture will be send to your castle barracks";
		}

	}


	public void showPrice(){
		hoverCustomText.msg = "This monster can be sold as a  slave for " + slaveValue ()+ "G.";

	}

	public void captureSlave(){
		NPCCharList.CharRetainers.Add(NPCCharList.CharMonster [0]);
		NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].isSlave = true;
		NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].isRecruited = true;
		NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].isMonster = false;
		NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].cityJobs = NPCData.Jobs.CastleRest;
		NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].currentHealth = 10;

		fileRulesNPC npcrules = new fileRulesNPC();
		RulesNPC.savedRules.Add (npcrules);
		RulesNPC.savedRules [RulesNPC.savedRules.Count-1].id = NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charID; 
		RulesNPC.savedRules [RulesNPC.savedRules.Count-1].idx = NPCCharList.CharRetainers.Count - 1;

		NPCCharList.CharMonster.Clear ();

		endTurn.endTurn ();


	}

	public void sellSlave(){
		GameControl.charGold += slaveValue ();
		endTurn.endTurn ();
	}



	int slaveValue(){
		float valAtt = (NPCCharList.CharMonster [0].attPhysical + NPCCharList.CharMonster [0].attSocial + NPCCharList.CharMonster [0].attMental) / 6;
		float skillVal = NPCCharList.CharMonster [0].coreSkillDiplomacy + NPCCharList.CharMonster [0].coreSkillGovernance + NPCCharList.CharMonster [0].coreSkillIntrigue + NPCCharList.CharMonster [0].coreSkillLabor + NPCCharList.CharMonster [0].coreSkillMartial + NPCCharList.CharMonster [0].coreSkillPersuasion + NPCCharList.CharMonster [0].coreSkillSecurity + NPCCharList.CharMonster [0].coreSkillStewardship + NPCCharList.CharMonster [0].coreSkillTactics; 
		skillVal = skillVal / 9;
		float rankVal = 0.75f;
		NPCData.CharRank charRank = NPCCharList.CharMonster [0].charRank;
		switch (charRank) {
		case NPCData.CharRank.C:
			rankVal = 0.75f;
			break;
		case NPCData.CharRank.B:
			rankVal = 1.5f;
			break;
		case NPCData.CharRank.A:
			rankVal = 3;
			break;
		case NPCData.CharRank.S:
			rankVal = 6;
			break;
		}

		return (int)(((int)valAtt + (int)skillVal) * rankVal);
	}



	void Start () {

		buttCapture.interactable = checkRetainers ();

	}
	


}
