using UnityEngine;
using System.Collections;
using System.Collections.Generic;


[System.Serializable]


public class NPCFamily {
	
	/*
	void createChar(){
		CharList.Add (new NPCSon (NPCCharList.CharList[0].charName, NPCCharList.CharList[0].charID)); 

	}
	*/

	//public static List<NPCFamily> familyList = new List<NPCFamily>();

	public string charName;
	public string charSurname;
	public int charID; 




	public NPCFamily(string charname, string charsurname, int charid){
		charName = charname;
		charSurname = charsurname; 
		charID = charid; 
	}



}
