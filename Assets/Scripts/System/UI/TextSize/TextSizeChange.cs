using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextSizeChange : MonoBehaviour {

	public Text textFeedback; 



	public void makeTextBigger(){
		if (WorldControl.fontSize < 30) {
			WorldControl.fontSize += 2;
			textFeedback.text = "Size: " + WorldControl.fontSize;
		}

	}

	public void makeTextSmaller(){
		if (WorldControl.fontSize > 12) {
			WorldControl.fontSize -= 2;
			textFeedback.text = "Size: " + WorldControl.fontSize;

		}
	}

	void Awake(){
		textFeedback.text = "Size: " + WorldControl.fontSize;
	}

	void Update(){
		
	}


}
