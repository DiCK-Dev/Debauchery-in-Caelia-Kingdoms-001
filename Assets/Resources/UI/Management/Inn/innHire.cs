using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class innHire : MonoBehaviour {
	static int selChanged = -1;
	public Text Board;
	public Button buttHire;

	public void showPrice(){
		hoverCustomText.msg = "This worker can be hired for " + workerValue ()+ "G.";

	}


	public void hireWorker(){
		if (GameControl.charGold >= workerValue ()) {
			GameControl.charGold -= workerValue ();
			Board.text = "You just hired " + NPCCharList.CharRetainers [WorldControl.idx].charName + " " + NPCCharList.CharRetainers [WorldControl.idx].charSurname + "!";
			NPCCharList.CharRetainers [WorldControl.idx].isNeutral = false;
			NPCCharList.CharRetainers [WorldControl.idx].isRecruited = true;
			NPCCharList.CharRetainers [WorldControl.idx].cityJobs = NPCData.Jobs.CastleRest;
			RightManCreatePanInn.listchanged = true;
			checkIfHirable ();

			fileRulesNPC npcrules = new fileRulesNPC();
			RulesNPC.savedRules.Add (npcrules);
			RulesNPC.savedRules [RulesNPC.savedRules.Count-1].id = NPCCharList.CharRetainers [WorldControl.idx].charID; 
			RulesNPC.savedRules [RulesNPC.savedRules.Count-1].idx = WorldControl.idx;

			return;
		} else {
			Board.text = "You don't have enough to hire this worker!";
		}
	}

	int workerValue(){
		float valAtt = (NPCCharList.CharRetainers [WorldControl.idx].attPhysical + NPCCharList.CharRetainers [WorldControl.idx].attSocial + NPCCharList.CharRetainers [WorldControl.idx].attMental) / 15;
		float skillVal = NPCCharList.CharRetainers [WorldControl.idx].coreSkillDiplomacy + NPCCharList.CharRetainers [WorldControl.idx].coreSkillGovernance + NPCCharList.CharRetainers [WorldControl.idx].coreSkillIntrigue + NPCCharList.CharRetainers [WorldControl.idx].coreSkillLabor + NPCCharList.CharRetainers [WorldControl.idx].coreSkillMartial + NPCCharList.CharRetainers [WorldControl.idx].coreSkillPersuasion + NPCCharList.CharRetainers [WorldControl.idx].coreSkillSecurity + NPCCharList.CharRetainers [WorldControl.idx].coreSkillStewardship + NPCCharList.CharRetainers [WorldControl.idx].coreSkillTactics; 
		skillVal = skillVal / 22;
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

	void checkIfHirable(){
		int i = 0;
		buttHire.interactable = false;
		while (i < NPCCharList.CharRetainers.Count) {
			if (NPCCharList.CharRetainers [i].isNeutral) {
				buttHire.interactable = true;
				break;
			}
			i++;
		}

	}

	void Start(){
		checkIfHirable ();

	}



	void Update(){
		if (selChanged != WorldControl.idx) {
			Board.text = ManNPCDescription.npcDescription();
			selChanged = WorldControl.idx;
		}

	}

}
