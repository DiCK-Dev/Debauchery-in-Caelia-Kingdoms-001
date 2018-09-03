using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class TextSizerIndividual : MonoBehaviour {
	public Text Board; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Board.fontSize = WorldControl.fontSize;

	
	}
}
