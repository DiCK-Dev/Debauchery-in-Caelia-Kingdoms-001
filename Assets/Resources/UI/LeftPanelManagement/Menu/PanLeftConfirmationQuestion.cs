using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class PanLeftConfirmationQuestion : MonoBehaviour {

	public Text confirmationQuestion;


	public void confQuestion(string question){
		confirmationQuestion.text = question; 

	}



}
