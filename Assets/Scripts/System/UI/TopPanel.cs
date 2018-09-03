using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TopPanel : MonoBehaviour {

	// top mid panel
	public Text location; 


	//top right panel
	public Text textDay; 
	public Text textTime;




	void Start () {


		location.text = WorldControl.location; 
		textDay.text = WorldControl.day.ToString ();
		textTime.text = WorldControl.dayTimeName; 
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
