using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class hoverCustomText : MonoBehaviour {
	public static string msg; 
	public GameObject itemPrefab; 

	public void hoverText(string customtext){
		Debug.Log ("skill hover descr working");
		GameObject newPan  = Instantiate (itemPrefab) as GameObject;
		newPan.tag = "TempHover";
		newPan.GetComponentInChildren<Text> ().text = customtext + msg;

	}

	public void destroyTempHover(){
		msg = "";
		Debug.Log ("destroy hover descr working");
		GameObject[] tempHovers = GameObject.FindGameObjectsWithTag("TempHover");
		foreach(GameObject obj in tempHovers)
			GameObject.Destroy(obj);
	}

}
