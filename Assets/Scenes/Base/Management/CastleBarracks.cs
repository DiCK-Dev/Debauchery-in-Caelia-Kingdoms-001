using UnityEngine;
using System.Collections;

public class CastleBarracks : MonoBehaviour {

	public void suppliesInfo(){
		hoverCustomText.msg = "Base cost: 3G per unit. Supplies are used for food, drugs, among other things. Please make sure to have enough to fed your garrison and slaves! An accountant can buy it for you, and even bargain better prices! Make sure it has a good stewardship skill and mental attribute.";

	}

	public void buySupplies(int selector){
		if (selector == 0) { //100
			if (GameControl.charGold >= 300) {
				GameControl.charGold -= 300;
				CastleController.castleSupplies += 100;
			}
		}
		if (selector == 1) { //50
			if (GameControl.charGold >= 150) {
				GameControl.charGold -= 150;
				CastleController.castleSupplies += 50;
			}
		}
		if (selector == 2) { //10
			if (GameControl.charGold >= 30) {
				GameControl.charGold -= 30;
				CastleController.castleSupplies += 10;
			}
		}


	}

	void Awake(){
		WorldControl.idx = -1;
		WorldControl.NPCID = 0;



	}
}
