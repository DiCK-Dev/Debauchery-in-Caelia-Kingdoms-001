using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RightPanelPortrait : MonoBehaviour {

	/// <summary>
	/// update once you update the NPC class please
	/// </summary>

	int layer0ID;
	int layer1ID;
	int layer2ID;
	public Image layer0; 
	public Image layer1; 
	public Image layer2; 


	void spriteUpdater()
	{

		layer0ID = WorldControl.PortraitIDLayer0; 
		layer1ID = WorldControl.PortraitIDLayer1;
		layer2ID = WorldControl.PortraitIDLayer2;

		layer0.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + layer0ID) as Sprite;
		layer1.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + layer1ID) as Sprite;
		layer2.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + layer2ID) as Sprite;
		//enemyPortrait.sprite = Resources.Load<Sprite> ("Portraits/Enemies/" + localID) as Sprite;

		if (layer0.sprite == null) {
			layer0.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + 0)as Sprite;; 
		}
		if (layer1.sprite == null) {
			layer1.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + 0)as Sprite;; 
		}
		if (layer2.sprite == null) {
			layer2.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + 0)as Sprite;; 
		}


	}






	void Update () {
		spriteUpdater ();
		//layer0.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + WorldControl.NPCID ) as Sprite;
	}

/*
	void spriteUpdater()
	{







		localID = WorldControl.PortraitID; 




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


		layer0.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + localID) as Sprite;
		//enemyPortrait.sprite = Resources.Load<Sprite> ("Portraits/Enemies/" + localID) as Sprite;

		if (layer0.sprite == null) {

			layer0.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + 0)as Sprite;; 
		}
	}


*/

}
