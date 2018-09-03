using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SceneFormat : MonoBehaviour {

	/// <summary>
	/// The basic format for doing scene scripts 
	/// </summary>
	/// 

	Parser myParser = new Parser(); 
	public Text textPrint;


	// add only those you need otherwise will be spamming missing elements 
	public Text sceneText;
	public Button mySceneButt1;
	public Button mySceneButt2;
	public Button mySceneButt3;
	public Button mySceneButt4;
	public Button mySceneButt5;
	public Button mySceneButt6;
	/*
	public Button mySceneButt7;
	public Button mySceneButt8;
	public Button mySceneButt9;
	public Button mySceneButt10;
	*/


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

	/*
	//HERE ITS ONLY AN EXAMPLE OF THE CONDITIONS TO RUN SCENES, THE ORDER IS IRRELEVANT 

	//Futa - exclusive for futa, only use if its very particular, otherwise use the man scene 
	public void deactScene1()
	{
		if (GameControl.charGender != 4) 
		{
			mySceneButt1.GetComponent<Button> ().interactable = false; 
		}

	}

		public void scene1()
	{

		sceneText.text = "Here goes the futa scene"; 
	}




	//Dick girl example - Can be seen by dick girl and futa (only use if its uses heavy female characteristics, otherwise use the man scene)  
	public void deactScene2()
	{
		if (GameControl.charGender < 3) 
		{
			mySceneButt2.GetComponent<Button> ().interactable = false;
		}

	}


	public void scene2()
	{
		sceneText.text = "Here goes the dickgirl scene"; 
	}


	//Man scene - can be seen by: Futa, dickgirl, man, unless very special, go for dickgirl scene 
	public void deactScene3()
	{
		if (GameControl.charGender < 2) 
		{
			mySceneButt3.GetComponent<Button> ().interactable = false;
		}
	}

	public void scene3()
	{
		sceneText.text = "Here goes the man scene"; 
	}

	//woman scene - can be seen by: Futa and woman

	public void deactScene4()
	{
		if (GameControl.mcSex == GameControl.MCSex.Man   || GameControl.charGender == 0 ) 
		{
			mySceneButt4.GetComponent<Button> ().interactable = false;
		}
	}

	public void scene4()
	{
		sceneText.text = "Here goes the woman  scene"; 
	}



	// Asexual scene - can be scene by all
	public void deactScene5()
	{
		if ( GameControl.mcGender == GameControl.MCGender.FEM  || GameControl.charGender ==4 ) 
		{
			mySceneButt5.GetComponent<Button> ().interactable = false;
		}
	}

	public void scene5()
	{
		sceneText.text = "Here goes the asexual  scene"; 
	}

	*/




	
	// Update is called once per frame
}

