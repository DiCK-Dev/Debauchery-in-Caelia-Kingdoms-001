using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CanvasReset : MonoBehaviour {

	public GameObject board;
	static string currentText;
	static string oldText;
	public Scrollbar scroll; 
	public Slider slider; 
	void autoReset(){
		currentText = board.GetComponent<Text>().text;  
		if (currentText != oldText) {
			scroll.value = 0; 
			slider.value = 0; 
			oldText = currentText;
		}


	}

	void Update(){
		autoReset ();
	}
}
