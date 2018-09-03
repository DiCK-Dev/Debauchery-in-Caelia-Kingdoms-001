using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SceneStart : MonoBehaviour {
	// THIS IS AN EXAMPLE OF HOW TO START A COMBAT, COPY PASTE IT AN CHANGE IT ACCORDINGLY THIS IS THE TEMPLATE


	/// <summary>
	/// TEMPLATE FOR COMBAT
	/// </summary>

	Parser myParser = new Parser(); 

	int randNum; 
	public Text defeatText; 
	public Text submitText; 
	public Text SceneText; 
	public Button buttScene1;
	public Button buttScene2;
	public Button buttScene3;
	public Button buttScene4;
	public Button buttScene5;
	public Button buttScene6;


	string face; 
	string arms; 
	string legs; 
	string race; 
	string gender;
	string beard;
	string physique;
	string build;
	string eyesColor;
	string hairColor;
	string dick; 
	string breasts;





	// this is used to SETTLE the scene, add a simple script that changes the global ID and this will do the rest
	void Awake () {


		// DELETE THIS IS JUST FOR TESTING 
		GameControl.activeSkills[0] = 100;
		GameControl.activeSkills[1] = 110;
		GameControl.activeSkills[2] = 120;
		GameControl.activeSkills[3] = 130;

		//



		// SET THE STATS OF THE ENEMY
		WorldControl.enemyID = 100; 
		WorldControl.enemyLust = 0; // starting lust48
		WorldControl.enemyHP = 100;
		WorldControl.enemyLust = 0;
		WorldControl.enemyMaxHP = 100;
		WorldControl.enemyMaxLust = 100; 

		WorldControl.enemyCombDefense = 0.2f; // dmg reduction %
		WorldControl.enemyLustDefense = 0.35f; // dmg reduction %


		// appears in the UI
		WorldControl.eneName = "Bunny example";
		WorldControl.eneRace = "Bunny Girl Ex"; 
		WorldControl.eneComType = "Combat style Ex"; 
		WorldControl.eneLustType = "Seductive style Ex"; 
		WorldControl.eneDescription = "This is how you describe the enemy at the first turn"; 




		// loot 
		randNum = Random.Range (0, 100);

		if (randNum > 90) {
			WorldControl.dropItem = 100;
		} else if (randNum > 50) {
			WorldControl.dropItem = 100;
		} else {
			WorldControl.dropItem = 100; 
		}
	}


	/*
	public void Scene1(){
		if (GameControl.charGender >= 2) {
			buttScene1.GetComponent<Button> ().interactable = false; 

		} else {
			SceneText.text = "scene goes here";


		}

	}*/





	void Start (){
		string face = myParser.callCharFace ();
		string arms = myParser.callCharArmsType ();
		string legs = myParser.callCharLegsType ();
		string race = myParser.callCharRace ();
		string gender = myParser.callCharGender ();
		string beard = myParser.callCharBeard ();
		string physique = myParser.callCharPhysique ();
		string build = myParser.callCharBuild ();
		string eyesColor = myParser.callCharEyesColor ();
		string hairColor = myParser.callCharHairColor ();
		string dick = myParser.callDickType ();
		string breasts = myParser.callBreastsName1 (); 


	}
	
	// Update is called once per frame
	void Update () {


	
	}
}
