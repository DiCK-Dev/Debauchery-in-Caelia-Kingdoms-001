using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class MapScene : MonoBehaviour {
	public Text Board; 


	void Awake (){
		Board.text = "From this place you can travel to any big city and geographical region from the island once you discover it"; 
		WorldControl.location = "World"; 
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
