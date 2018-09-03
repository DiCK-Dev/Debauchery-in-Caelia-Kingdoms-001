using UnityEngine;
using UnityEngine.SceneManagement; 
using System.Collections;

public class sceneChange : MonoBehaviour {
	public int scene; 
	public static int lastLocation = 3; 

	public void changeScene(){
		if (scene > 3 && scene != 60 && scene != 61 && scene != 62 && scene != 63 && scene != 64 && scene != 65) {
			lastLocation = scene;
		}
	
		SceneManager.LoadScene (scene);
	}

	public void changeSceneSel(int selector){
		if (scene > 3 && scene != 60 && scene != 61 && scene != 62 && scene != 63 && scene != 64 && scene != 65) {
			lastLocation = selector;
		}
		SceneManager.LoadScene (selector);
	}








}
