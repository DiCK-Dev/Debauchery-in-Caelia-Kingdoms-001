using UnityEngine;
using UnityEngine.UI;  //DELETE at the end of debbuging
using System.Collections;

public class AddItemScript : MonoBehaviour {


	// this should be a global variable
	bool done = false; 
	bool full; 
	int i; 


	//// this is for debbuging, DELETE
	/// 

	public Text text1; 


	public void printText(){
		text1.text = "You just added the" + WorldControl.dropItem + "Item";  

	}


	public void addItemScript()
	{

		full = true; 
		done = false; 
		i = 0; 

		if (WorldControl.dropItem < 10000) 
		{
				
			while (i < 10) {

			
				if (GameControl.invSlotArray [i, 0] == WorldControl.dropItem) 
				{
					if (GameControl.invSlotArray [i, 1] < 5)
					{							
						GameControl.invSlotArray [i, 1] = GameControl.invSlotArray [i, 1] + 1;
						done = true; 
						full = false;

						Debug.Log ("You added an item to the slot " + i + "the ID was" + GameControl.invSlotArray [i, 0] + "You have this many in this slot: " + GameControl.invSlotArray [i, 1]);
						break;


					}
				}
				i++;
			}
				
			i = 0;
			if (done != true) {
				i = 0; 
					while (i < 10) 
					{
						if (GameControl.invSlotArray [i, 0] == 0) 
						{
							GameControl.invSlotArray [i, 0] = WorldControl.dropItem;
							GameControl.invSlotArray [i, 1] = 1; 
							full = false;

						Debug.Log ("You added an item to the slot " + i + "the ID was" + GameControl.invSlotArray [i, 0] + "You have this many in this slot: " + GameControl.invSlotArray [i, 1]);
							break; 

						}

						i++; 
					}				
				}
				done = false; 


		} 
		else 
		{
		i = 0; 
			while (i < 10) {
				if (GameControl.invSlotArray [i, 0] == 0)
				{
					GameControl.invSlotArray [i, 0] = WorldControl.dropItem;
					GameControl.invSlotArray [i, 1] = 1; 
						
					full = false; 
					Debug.Log ("You added an item to the slot " + i + "the ID was" + GameControl.invSlotArray [i, 0] + "You have this many in this slot: " + GameControl.invSlotArray [i, 1]);
					break; 
				}
				i++;
			}
				
		}


	}



	public static bool addReward(){

		bool full = true; 
		bool done = false; 
		int i = 0; 

		if (WorldControl.dropItem < 10000) 
		{

			while (i < 10) {


				if (GameControl.invSlotArray [i, 0] == WorldControl.dropItem) 
				{
					if (GameControl.invSlotArray [i, 1] < 5)
					{							
						GameControl.invSlotArray [i, 1] = GameControl.invSlotArray [i, 1] + 1;
						done = true; 
						full = false;
						Debug.Log ("You added an item to the slot " + i + "the ID was" + GameControl.invSlotArray [i, 0] + "You have this many in this slot: " + GameControl.invSlotArray [i, 1]);
						return true;



					}
				}
				i++;
			}

			i = 0;
			if (done != true) {
				i = 0; 
				while (i < 10) 
				{
					if (GameControl.invSlotArray [i, 0] == 0) 
					{
						GameControl.invSlotArray [i, 0] = WorldControl.dropItem;
						GameControl.invSlotArray [i, 1] = 1; 
						full = false;

						Debug.Log ("You added an item to the slot " + i + "the ID was" + GameControl.invSlotArray [i, 0] + "You have this many in this slot: " + GameControl.invSlotArray [i, 1]);
						return true; 

					}

					i++; 
				}				
			}
			done = false; 
			return false; 

		} 
		else 
		{
			i = 0; 
			while (i < 10) {
				if (GameControl.invSlotArray [i, 0] == 0)
				{
					GameControl.invSlotArray [i, 0] = WorldControl.dropItem;
					GameControl.invSlotArray [i, 1] = 1; 

					full = false; 
					Debug.Log ("You added an item to the slot " + i + "the ID was" + GameControl.invSlotArray [i, 0] + "You have this many in this slot: " + GameControl.invSlotArray [i, 1]);
					return true;
				}
				i++;
			}
			return false; 

		}

	}

}
