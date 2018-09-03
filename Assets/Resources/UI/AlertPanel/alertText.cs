using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class alertText : MonoBehaviour {

	public static string alertMessage;
	public Text Board; 
	public Canvas alertCanvas;

	public void backCanvas(){
		alertCanvas.sortingOrder = -1000;

	}




	void Update(){
		Board.text = alertMessage;
	}


}
