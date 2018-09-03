using UnityEngine;
using System; 
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary; 
using System.IO; 
using UnityEngine.UI; 


public class PanLeftLoadButtons : MonoBehaviour {
	//deact buttons if they have no file
	public Button loadSlot1;
	public Button loadSlot2;
	public Button loadSlot3;
	public Button loadSlot4;
	public Button loadSlot5;


	public void blockLoad(){

		loadSlot1.interactable = false;
		loadSlot2.interactable = false;
		loadSlot3.interactable = false;
		loadSlot4.interactable = false;
		loadSlot5.interactable = false;


		if(File.Exists(Application.persistentDataPath + "/playerInfo"+ 1 +".dat")) 
		{
			loadSlot1.interactable = true;
		}

		if(File.Exists(Application.persistentDataPath + "/playerInfo"+ 2 +".dat")) 
		{
			loadSlot2.interactable = true;
		}

		if(File.Exists(Application.persistentDataPath + "/playerInfo"+ 3 +".dat")) 
		{
			loadSlot3.interactable = true;
		}

		if(File.Exists(Application.persistentDataPath + "/playerInfo"+ 4 +".dat")) 
		{
			loadSlot4.interactable = true;
		}

		if(File.Exists(Application.persistentDataPath + "/playerInfo"+ 5 +".dat")) 
		{
			loadSlot5.interactable = true;
		}

	}

	void Awake(){
		blockLoad ();
	}

}
