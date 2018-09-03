using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class PlainsEvents : MonoBehaviour {
	int randNum; 


	public void PlainsRandomEvent()
	{
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 100);

		if (randNum > 50) {
			SceneManager.LoadScene (36);
		} else {
			Random.InitState(System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 1000);
			//ADAPT TO NEW ENEMY,check forest
			if (randNum > 500)
			{
				SceneManager.LoadScene (37);
			} 
			else
			{
				SceneManager.LoadScene (39);
			} 





		}

	}


}
