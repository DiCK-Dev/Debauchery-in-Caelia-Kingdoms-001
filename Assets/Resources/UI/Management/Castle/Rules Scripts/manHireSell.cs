using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class manHireSell : MonoBehaviour {
	public Text sellHire;

	public void showPrice(){
		if (NPCCharList.CharRetainers [WorldControl.idx].isSlave) {
			hoverCustomText.msg = "This slave can be sold at " + slaveValue ()+ "G.";

		}else{
			hoverCustomText.msg = "Fire this worker, you will never be able to get it back!";
		}
	}

	public void sellFire(){
		if (NPCCharList.CharRetainers [WorldControl.idx].isSlave) {
			sellSlave ();
		}else{
			fireWorker ();
		}

	}

	public void sellSlave(){
		GameControl.charGold += slaveValue ();
		int i = 0;
		while (i < RulesNPC.savedRules.Count) {
			if (RulesNPC.savedRules [i].idx == WorldControl.idx) {
				RulesNPC.savedRules.RemoveAt (i);
			}
			i++;
		}
		NPCCharList.CharRetainers.RemoveAt (WorldControl.idx);
		WorldControl.idx = 0;
		RightManCreatePan.listchanged = true;
	}

	void fireWorker(){
		int i = 0;
		while (i < RulesNPC.savedRules.Count) {
			if (RulesNPC.savedRules [i].idx == WorldControl.idx) {
				RulesNPC.savedRules.RemoveAt (i);
			}
			i++;
		}
		NPCCharList.CharRetainers.RemoveAt (WorldControl.idx);
		WorldControl.idx = 0;
		RightManCreatePan.listchanged = true;

	}




	int slaveValue(){
		float valAtt = (NPCCharList.CharRetainers [WorldControl.idx].attPhysical + NPCCharList.CharRetainers [WorldControl.idx].attSocial + NPCCharList.CharRetainers [WorldControl.idx].attMental) / 6;
		float skillVal = NPCCharList.CharRetainers [WorldControl.idx].coreSkillDiplomacy + NPCCharList.CharRetainers [WorldControl.idx].coreSkillGovernance + NPCCharList.CharRetainers [WorldControl.idx].coreSkillIntrigue + NPCCharList.CharRetainers [WorldControl.idx].coreSkillLabor + NPCCharList.CharRetainers [WorldControl.idx].coreSkillMartial + NPCCharList.CharRetainers [WorldControl.idx].coreSkillPersuasion + NPCCharList.CharRetainers [WorldControl.idx].coreSkillSecurity + NPCCharList.CharRetainers [WorldControl.idx].coreSkillStewardship + NPCCharList.CharRetainers [WorldControl.idx].coreSkillTactics; 
		skillVal = skillVal / 9;
		float rankVal = 0.75f;
		NPCData.CharRank charRank = NPCCharList.CharRetainers [WorldControl.idx].charRank;
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

	void Update(){
		if (NPCCharList.CharRetainers [WorldControl.idx].isSlave) {
			sellHire.text = "Sell";
		} else {
			sellHire.text = "Fire";

		}
	}

}
