using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ManSetStyle : MonoBehaviour {
	public Text localBoard;
	static int currentSel = -100;
	public Text isBranded; 
	public Dropdown ddHairstyle;
	public Text textHairstyle;
	static bool loading;

	public void brand(){

		if (NPCCharList.CharRetainers [WorldControl.idx].isSlave) {
			NPCCharList.CharRetainers [WorldControl.idx].isBranded = true;
			currentSel = -1;
		} else {
			localBoard.text = "Can't brand! " + NPCCharList.CharRetainers [WorldControl.idx].charName + " is not a slave!\n\n" + localBoard.text; 
		}

	}

	public void setHairstyle(){
		/*
disheveled, pixie, sassy, bob, mowhawk, [Description("comb over")]CombOver, [Description("curly bob")]CurlyBob, pompadour, braids, [Description("twist and bun")]twistbun, 
		[Description("elegant bun")]ElegantBun, [Description("manly bun")]ManlyBun, [Description("long ponytails")]LongPonytails, [Description("plain long hair")]LongHair, [Description("long curls")]LongCurls
*/
		if (loading) {
			return;
		}
		NPCCharList.CharRetainers [WorldControl.idx].hairStyle = (NPCData.HairStyle)ddHairstyle.value;

	}

	string charResume(){
		return ManNPCDescription.npcDescription ();

	}


	void startDescr(){
		loading = true;
		if (NPCCharList.CharRetainers [RulesNPC.savedRules[0].idx].isBranded) {
			isBranded.text = "Branded.";
		} else if (NPCCharList.CharRetainers [RulesNPC.savedRules[0].idx].isSlave) {
			isBranded.text = "Not branded.";
		} else {
			isBranded.text = "Can't brand.";
		}
		currentSel = RulesNPC.savedRules[0].idx; 
		localBoard.text = charResume ();
		ddHairstyle.value = 1;
		ddHairstyle.value = 0;
		ddHairstyle.value = (int)NPCCharList.CharRetainers [RulesNPC.savedRules[0].idx].hairStyle;
		loading = false;

	}


	void updateDescr(){
		if (WorldControl.idx != currentSel) {
			loading = true;
			if (NPCCharList.CharRetainers [WorldControl.idx].isBranded) {
				isBranded.text = "Branded.";
			} else if (NPCCharList.CharRetainers [WorldControl.idx].isSlave) {
				isBranded.text = "Not branded.";
			} else {
				isBranded.text = "Can't brand.";
			}
			currentSel = WorldControl.idx; 
			localBoard.text = charResume ();
			ddHairstyle.value = 1;
			ddHairstyle.value = 0;
			ddHairstyle.value = (int)NPCCharList.CharRetainers [WorldControl.idx].hairStyle;
			loading = false;
		}
		textHairstyle.text = NPCCharList.CharRetainers [WorldControl.idx].hairStyle.toDescription ();
	}

	void Update(){

		updateDescr ();


	}

}
