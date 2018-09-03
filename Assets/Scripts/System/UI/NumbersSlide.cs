using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumbersSlide : MonoBehaviour {


	public Text actualHP;
	public Text actualArousal; 



	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		actualHP.text = GameControl.actualHealth.ToString ();
		actualArousal.text = GameControl.actualArousal.ToString ();
	
	}
}
