using UnityEngine;
using System; 
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary; 
using System.IO; 
using UnityEngine.UI; 

public class SaveLoadTitles : MonoBehaviour {
	int loadNum; 

	public Text save1Name;
	string save1Day;

	public Text save2Name;
	string save2Day;

	public Text save3Name;
	string save3Day;

	public Text save4Name;
	string save4Day;

	public Text save5Name;
	string save5Day;






	public void loadName1(){
		save1Name.text = "Empty"; 
		loadNum = 1; 
		if(File.Exists(Application.persistentDataPath + "/playerInfo"+ loadNum +".dat")) 
		{
			loadNamesFiles (); 
		}

	}


	public void loadName2(){

		save2Name.text = "Empty"; 
		loadNum = 2; 
		if(File.Exists(Application.persistentDataPath + "/playerInfo"+ loadNum +".dat")) 
		{
			loadNamesFiles (); 
		}

	}


	public void loadName3(){

		save3Name.text = "Empty"; 
		loadNum = 3; 
		if(File.Exists(Application.persistentDataPath + "/playerInfo"+ loadNum +".dat")) 
		{

			loadNamesFiles (); 

		}

	}


	public void loadName4(){

		save4Name.text = "Empty"; 
		loadNum = 4; 
		if(File.Exists(Application.persistentDataPath + "/playerInfo"+ loadNum +".dat")) 
		{

			loadNamesFiles (); 

		}

	}

	public void loadName5(){

		save5Name.text = "Empty"; 
		loadNum = 5; 
		if(File.Exists(Application.persistentDataPath + "/playerInfo"+ loadNum +".dat")) 
		{

			loadNamesFiles (); 

		}

	}


	public void loadNameAll(){
		loadName1 ();
		loadName2 ();
		loadName3 ();
		loadName4 ();
		loadName5 ();
	}



	public void loadNamesFiles (){
		if(File.Exists(Application.persistentDataPath + "/playerInfo"+ loadNum +".dat")) 
		{

			BinaryFormatter binFor = new BinaryFormatter();
			FileStream file = File.Open (Application.persistentDataPath + "/playerInfo"+ loadNum +".dat", FileMode.Open); 
			PlayerData data = (PlayerData)binFor.Deserialize (file);
			file.Close();


			if (loadNum == 1) {
				save1Day = data.day.ToString (); 
				save1Name.text = data.playerName + " Day " + save1Day; 
			}

			if (loadNum == 2) {
				save2Day = data.day.ToString (); 
				save2Name.text = data.playerName + " Day " + save2Day; 

			}

			if (loadNum == 3) {
				save3Day = data.day.ToString (); 
				save3Name.text = data.playerName + " Day " + save3Day; 

			}

			if (loadNum == 4) {
				save4Day = data.day.ToString (); 
				save4Name.text = data.playerName + " Day " + save4Day; 

			}

			if (loadNum == 5) {
				save5Day = data.day.ToString (); 
				save5Name.text = data.playerName + " Day " + save5Day; 

			}



			//GameControl.playerName = data.playerName; 
		//	WorldControl.day = data.day; 

		}

	}



	void Awake () {

	
		loadName1 ();
		loadName2 ();
		loadName3 ();
		loadName4 ();
		loadName5 ();


	}

}
