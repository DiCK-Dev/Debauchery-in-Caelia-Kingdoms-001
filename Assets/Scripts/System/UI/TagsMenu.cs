using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class TagsMenu : MonoBehaviour {
	//Tag toggle - 0 Dominant, 1 Submissive, 2 Romantic, 3 Feral, 4 Cumslut, 5 Public use, 6 Cruel, 7 Incest
	public Toggle tag0;
	public Toggle tag1; 
	public Toggle tag2;
	public Toggle tag3;
	public Toggle tag4;
	public Toggle tag5;
	public Toggle tag6;
	public Toggle tag7;

	public Text Board; 



	public void pickTags(){
		Board.text = "Change complete!"; 
		if (tag0.isOn) {
			WorldControl.tagControl [0] = true; 
		} else {
			WorldControl.tagControl [0] = false; 
		}

		if (tag1.isOn) {
			WorldControl.tagControl [1] = true; 
		}else {
			WorldControl.tagControl [1] = false; 
		}



		if (tag2.isOn) {
			WorldControl.tagControl [2] = true; 
		}else {
			WorldControl.tagControl [2] = false; 
		}


		if (tag3.isOn) {
			WorldControl.tagControl [3] = true; 
		}else {
			WorldControl.tagControl [3] = false; 
		}


		if (tag4.isOn) {
			WorldControl.tagControl [4] = true; 
		}else {
			WorldControl.tagControl [4] = false; 
		}


		if (tag5.isOn) {
			WorldControl.tagControl [5] = true; 
		}else {
			WorldControl.tagControl [5] = false; 
		}


		if (tag6.isOn) {
			WorldControl.tagControl [6] = true; 
		}else {
			WorldControl.tagControl [6] = false; 
		}


		if (tag7.isOn) {
			WorldControl.tagControl [7] = true; 
		}else {
			WorldControl.tagControl [7] = false; 
		}


	}

	public void loadTags(){
		if (WorldControl.tagControl [0] == false) {
			tag0.isOn = !tag0.isOn; 
		} else {
			tag0.isOn = tag0.isOn; 
		}
		if (WorldControl.tagControl [1] == false) {
			tag1.isOn = !tag1.isOn; 
		} else {
			tag1.isOn = tag1.isOn; 
		}
		if (WorldControl.tagControl [2] == false) {
			tag2.isOn = !tag2.isOn; 
		} else {
			tag2.isOn = tag2.isOn; 
		}
		if (WorldControl.tagControl [3] == false) {
			tag3.isOn = !tag3.isOn; 
		} else {
			tag3.isOn = tag3.isOn; 
		}
		if (WorldControl.tagControl [4] == false) {
			tag4.isOn = !tag4.isOn; 
		} else {
			tag4.isOn = tag4.isOn; 
		}
		if (WorldControl.tagControl [5] == false) {
			tag5.isOn = !tag5.isOn; 
		} else {
			tag5.isOn = tag5.isOn; 
		}
		if (WorldControl.tagControl [6] == false) {
			tag6.isOn = !tag6.isOn; 
		} else {
			tag6.isOn = tag6.isOn; 
		}
		if (WorldControl.tagControl [7] == false) {
			tag7.isOn = !tag7.isOn; 
		} else {
			tag7.isOn = tag7.isOn; 
		}



	}


	void Awake(){
		loadTags ();
	}


}
