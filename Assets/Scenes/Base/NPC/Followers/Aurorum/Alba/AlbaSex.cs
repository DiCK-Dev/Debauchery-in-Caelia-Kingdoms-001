using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AlbaSex : MonoBehaviour {

	int iAlba; 
	public Text Board; 
	int randNum;
	public Canvas endTurnPanel; 
	public Canvas panMainPanel;

	public void sexSceneSelector(int selector){



		loadAlba ();


		if (NPCCharList.CharFollower [iAlba].charLove < 100) {
			Board.text = "You need to improve your relationship with Alba first! Go out with her on dates and have a fun time.";
			return; 
		}

		switch (selector) {
		case 0:
			if (GameControl.dick1Size > 0) {
				Board.text = AlbaSexSceneCasual.sexScene1 ();
			} else {
				Board.text = "You need to have a penis to engage in this act!";
			}

			break;
		case 1:
			//Board.text = Scene1 ();
			break;
		case 2:
			
			break;
		case 3:
			
			break;
		case 4:
			
			break;
		}
		endTurnFun ();

	}


	void loadAlba(){
		iAlba = 0;
		while (iAlba < NPCCharList.CharFollower.Count)
		{
			if (NPCCharList.CharFollower [iAlba].charID == 13000 ) 
			{
				break; 
			}
			iAlba++;
		}
	}

	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		panMainPanel.sortingOrder = -500; 
		endTurnPanel.sortingOrder = 500;


	}

}
