using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PointerTest : MonoBehaviour {
	public RectTransform panHover; 
	public RectTransform panHover2; 
	public Button buttTest; 
	bool onMouseBool; 

	void onMouseOver(){
		onMouseBool = true;
		Debug.Log ("work");
	}

	void onMouseExit(){
		onMouseBool = false; 
	}


	public void button1hover(){
		Debug.Log ("work1");
		if (onMouseBool == true) {
			panHover.SetAsLastSibling ();
		} else {
			panHover.SetAsFirstSibling ();
		}


	}


	public void button2hover(){
		Debug.Log ("work2");
		if (onMouseBool == true) {
			panHover2.SetAsLastSibling ();
		} else {
			panHover2.SetAsFirstSibling ();
		}


	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
