using UnityEngine;
using System.Collections;

public class OnClickCaseSlot03 : MonoBehaviour {




	public void executing()
	{
		switch (GameControl.invSlotArray [3, 0]) 
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
