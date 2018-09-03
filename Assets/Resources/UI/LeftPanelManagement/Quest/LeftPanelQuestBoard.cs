using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class LeftPanelQuestBoard : MonoBehaviour {

	public Text Board; 
	public static string description;

	void Awake (){
		description = "";
	}



	void Update () {
		Board.text = description; 
	}



}
