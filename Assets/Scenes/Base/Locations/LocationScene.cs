using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LocationScene : MonoBehaviour {
	public Text Board; 


	void Awake (){
		Board.text = "From here you can visit specific locations that you may find in the world, dungeons, and even specific people that dont live in a city, once you discover them."; 
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
