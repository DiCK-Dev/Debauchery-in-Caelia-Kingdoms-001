using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SceneName : MonoBehaviour {

	public Text location; 
	void Start () {
		location.text = WorldControl.location; 
	}
	

}
