using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CharPortrait : MonoBehaviour {
	int localID; 


	/*
	public Image NPCportrait; 

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
		Debug.Log ("Works + local id" + localID);
		NPCportrait.sprite = Resources.Load<Sprite> ("Portraits/Character/" + localID) as Sprite;

	}
		

	void Awake ()
	{


	}


	void Start () {

	}


	void Update () {
		spriteUpdater ();
		//followerPortrait.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + WorldControl.NPCID ) as Sprite;
	}

	*/

}