using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NPCPortrait : MonoBehaviour {

	int localID; 
	public Image followerPortrait; 

	void spriteUpdater()
	{
		localID = WorldControl.NPCID; 
		if (WorldControl.furryOn == false & WorldControl.furryPic == true) {
			if (WorldControl.futaPic == true) {
				if (WorldControl.futaOn == false) {
					localID = localID + 3;
				} else {
					localID = localID + 1;
				}

			}
			else 
			{
				localID = localID + 3;
			}


		}




		else 
		{
			if (WorldControl.futaOn == false & WorldControl.futaPic == true) {
				localID = localID + 2;
			}
		}


		followerPortrait.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/" + localID) as Sprite;
		//enemyPortrait.sprite = Resources.Load<Sprite> ("Portraits/Enemies/" + localID) as Sprite;
	}





	void Update () {
		spriteUpdater ();
		//followerPortrait.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + WorldControl.NPCID ) as Sprite;
	}



}