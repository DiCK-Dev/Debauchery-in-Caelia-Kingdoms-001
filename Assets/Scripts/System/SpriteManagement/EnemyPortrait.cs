using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyPortrait : MonoBehaviour {

	public Image enemyPortrait; 

	int localID; 

	// no change = furry/futa,  +3 = no furry/no futa, + 1 = no furra/yes futa, +2 = yes furry/no futa


	void spriteUpdater()
	{
		localID = WorldControl.enemyID; 
		if (WorldControl.furryOn == false & WorldControl.furryPic == true) {
			if (WorldControl.futaPic == true) {
				if (WorldControl.futaOn == false) {
					localID = localID + 3; //no furry, no futa
				} else {
					localID = localID + 1;
				}
			 
			}
			else 
			{
				localID = localID + 3; //no furry, no futa
			}


		}







		else 
		{
			if (WorldControl.futaOn == false & WorldControl.futaPic == true) {
				localID = localID + 2;
			}
		}


		enemyPortrait.sprite = Resources.Load<Sprite> ("Portraits/Enemies/" + localID) as Sprite;
	}





	void Awake ()
	{


	}


	void Start () {

	}


	void Update () {

		spriteUpdater ();
	}



}
