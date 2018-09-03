using UnityEngine;
using System.Collections;

public class VivicaQuestCorrupt  {
	static int iVar;
	static string toRet; 

	public static string corruptQuest(int selector){
		iVar = loadChar (8000);
		string lordlady = "Lord";
		if (GameControl.mcGender == GameControl.MCGender.FEMALE) {
			lordlady = "Lady";
		}
		return "This is a bug";
	}



	static int loadChar(int id){
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
