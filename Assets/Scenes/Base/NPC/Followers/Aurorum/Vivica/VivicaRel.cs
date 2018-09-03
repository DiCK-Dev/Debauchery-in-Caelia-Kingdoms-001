using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VivicaRel : MonoBehaviour {
	public InputField _vivicaRel;  // how you call her 
	public InputField _vivicaRelYou; // how she calls you
	public InputField _lucinaRel;  // how you call her 
	public InputField _lucinaRelYou; 
	public InputField _lucinaRelVivica; 


	public void updateRels(){ 
		NPCCharList.CharFollower [loadChar (8000)].relSF = _vivicaRel.text; // HOW YOU CALL HER 

		NPCCharList.CharFollower [loadChar (8000)].relSN = _vivicaRelYou.text;// how she calls you

		NPCCharList.CharFollower [loadChar (6000)].relX = _lucinaRel.text;// how you call her 

		NPCCharList.CharFollower [loadChar (6000)].relCN = _lucinaRelYou.text;// how she calls you

		NPCCharList.CharFollower [loadChar (6000)].relCF = _lucinaRelVivica.text;// how she calls Vivica

		Debug.Log ("Relationships in order: " + NPCCharList.CharFollower [loadChar (8000)].relSF + " "+ NPCCharList.CharFollower [loadChar (8000)].relSN + " " + NPCCharList.CharFollower [loadChar (6000)].relX + " " + NPCCharList.CharFollower [loadChar (6000)].relSN  + " " +  NPCCharList.CharFollower [loadChar (6000)].relSF  );
	}

	int loadChar(int id){
		int i = 0;
		while (i < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [i].charID == id){
				return i;
			}
			i++;

		}
		return 0;

	}
}
