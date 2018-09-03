using UnityEngine;
using UnityEngine.UI; 
using System.Collections.Generic;
using System.Collections;


public class OnClickCaseSlot00 : MonoBehaviour {


	/// when you click this, it takes the value of the item in the slot you have and checks its case, that case executes a function in another script, that function
	/// is the item



	public void executing()
	{
		switch (GameControl.invSlotArray [0, 0]) 
		{
		case 100:


			Debug.Log ("it worked case 100");
			break; 
	
		case 200:
			Debug.Log ("it worked case 200");
			break; 
		case 300:
			Debug.Log ("it worked case 300");
			break; 
		
		default:
			Debug.Log ("didnt found one!");
			break; 
		
		}
	
	
	}





}
