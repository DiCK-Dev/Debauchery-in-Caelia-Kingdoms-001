using UnityEngine;
using System.Collections;

public class slidePanelTest : MonoBehaviour {

	public Animator panelSlide1;
	public Animator panelSlide2;
	bool isMouseOver;



	public void DisableBoolAnimator(){
		StartCoroutine ("waitSeconds");

	//	anim1.SetBool ("isDisplayed", false);
	//	panelSlide1.SetBool ("isDisplayed", false);

	}

	public void enableBoolAnimator(){
		isMouseOver = true; 
		panelSlide1.SetBool("isDisplayed", true);

	}

	public void slideControl2Enable(){
		isMouseOver = true; 

		panelSlide2.SetBool("isDisplayed2", true);

	}


	/*


	public void slideControl2Disable(Animator anim){

		panelSlide2.SetBool("isDisplayed2", false);
	}

	 * */

	public void slideControl2Disable(){

		panelSlide2.SetBool("isDisplayed2", false);
	}



	IEnumerator waitSeconds(){
		isMouseOver = false; 

		yield return new WaitForSeconds (1.25f);

		if (isMouseOver == false) {
			panelSlide1.SetBool ("isDisplayed", false);
			panelSlide2.SetBool ("isDisplayed2", false);
		}



	}



	void Update(){


	}



}
