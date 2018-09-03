using UnityEngine;
using System.Collections;

public class SpecialItemsControl : MonoBehaviour {

	static SpecialItemsControl instance; // helps to get ONLY ONE in the whole game
	public static SpecialItemsControl control; 



	//item 20014 Maidens of Love bikini armour
	public static bool item20014FirstUse = false;  









	void Awake () 
	{



		if (instance != null) 
		{
			Destroy (this.gameObject);
			return; 

		}
		else 
		{
			instance = this; 
			GameObject.DontDestroyOnLoad (this.gameObject);
		}



	}

}
