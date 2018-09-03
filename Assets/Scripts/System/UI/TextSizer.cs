using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextSizer : MonoBehaviour {
	public Text BoardMenu; 
	public Text Board; 



	public void makeTextBigger(){
		if (WorldControl.fontSize < 30) {
			WorldControl.fontSize += 2;
			BoardMenu.text = "Size has increased by two points!";
			BoardMenu.fontSize = WorldControl.fontSize; 
			Board.fontSize = WorldControl.fontSize; 
		} else {
			BoardMenu.text = "What is this, a game for giants?????";

		}
	}

	public void makeTextSmaller(){
		if (WorldControl.fontSize > 10) {
			WorldControl.fontSize -= 2;
			BoardMenu.fontSize = WorldControl.fontSize; 
			Board.fontSize = WorldControl.fontSize;
		} else {
			BoardMenu.text = "What is this, a game for ants????????";
		}

	}

	public void makeTextBiggerMainMenu(){
		if (WorldControl.fontSize < 30) {
			WorldControl.fontSize += 2;
			BoardMenu.fontSize = WorldControl.fontSize; 
			Board.fontSize = WorldControl.fontSize; 
		} else {

		}
	}
	public void makeTextSmallerMainMenu(){
		if (WorldControl.fontSize > 10) {
			WorldControl.fontSize -= 2;
			BoardMenu.fontSize = WorldControl.fontSize; 
			Board.fontSize = WorldControl.fontSize;
		} else {
		}

	}







	// Use this for initialization
	void Start () {


		Board.fontSize = WorldControl.fontSize;
		BoardMenu.fontSize = WorldControl.fontSize; 
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
