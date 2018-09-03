using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class ForestEvents : MonoBehaviour {
	int randNum; 

	public void ForestRandomEvent()
	{
		sceneChange.lastLocation = 28;
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 100);

		SceneManager.LoadScene (28);
		/*if (randNum > 50) {
			SceneManager.LoadScene (34);
		} else {
			Random.InitState(System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 1000);
			//Debug.Log (randNum);
			if (randNum > 670)
			{
				SceneManager.LoadScene (28);
			} 
			else if (randNum > 330)
			{
				SceneManager.LoadScene (30);
			} 
			else
			{
				SceneManager.LoadScene (32);
			}




		}*/

	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
