using UnityEngine;
using UnityEngine.SceneManagement; 
using System.Collections;
using UnityEngine.UI;

public class VisitLast : MonoBehaviour {

	public Button buttLastLoc;



	public void visitLast(){
		SceneManager.LoadScene (sceneChange.lastLocation);
	}

	void Update(){
		if (PanLeftManagement.endTurnControl == true) {
			buttLastLoc.interactable = false; 

		} else {
			buttLastLoc.interactable= true; 
		}
	}


}
