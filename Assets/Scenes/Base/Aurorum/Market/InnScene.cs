using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InnScene : MonoBehaviour {
	public Text Board; 

	void Awake () {
		WorldControl.location = "Aurorum - Inn"; 

	}
	// Use this for initialization
	void Start () {
		Board.text = "Here you can hire new free citizens to work at your castle. They change every few days.";
	}



}
