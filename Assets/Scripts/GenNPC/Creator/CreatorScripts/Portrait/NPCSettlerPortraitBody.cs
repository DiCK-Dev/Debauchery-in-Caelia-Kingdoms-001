using UnityEngine;
using System.Collections;

public class NPCSettlerPortraitBody {

	static public void createBody(){
		createDick ();
		createBreasts ();
		createTorso ();
	}

	static void createDick(){
		NPCData.DickType dickType = NPCCreator.TempList [0].dickType;
		if (NPCCreator.TempList [0].dickSize <= 0) {
			NPCCreator.TempList [0].charPortraitLayer11 = 0;
			return;
		}

		switch (dickType) {
		case NPCData.DickType.human:
			NPCCreator.TempList [0].charPortraitLayer11 = 1000;
			break;
		case NPCData.DickType.wolf:
			NPCCreator.TempList [0].charPortraitLayer11 = 1000;
			break;
		case NPCData.DickType.dragon:
			NPCCreator.TempList [0].charPortraitLayer11 = 4000;
			break;
		default:
			NPCCreator.TempList [0].charPortraitLayer11 = 1000;
			break;
		}
		if (NPCCreator.TempList [0].dickSizeCM >= 34) {
			NPCCreator.TempList [0].charPortraitLayer11 += 150;
		} else if (NPCCreator.TempList [0].dickSizeCM >= 22) {
			NPCCreator.TempList [0].charPortraitLayer11 += 100;
		} else if (NPCCreator.TempList [0].dickSizeCM >= 12) {
			NPCCreator.TempList [0].charPortraitLayer11 += 50;
		}
		NPCCreator.TempList [0].charPortraitLayer11 += (int)NPCCreator.TempList [0].charSkinColor;
	}




	static void createBreasts(){
		if (NPCCreator.TempList [0].breast1Size <= 0) {
			NPCCreator.TempList [0].charPortraitLayer12 = 0;
			return;
		}

		NPCData.HeadType headType = NPCCreator.TempList [0].headType;

		switch (headType) {
		case NPCData.HeadType.HUMAN:
			NPCCreator.TempList [0].charPortraitLayer12 = 1000;
			break;
		case NPCData.HeadType.WOLF:
			NPCCreator.TempList [0].charPortraitLayer12 = 3000;

			break;
		case NPCData.HeadType.dragon:
			NPCCreator.TempList [0].charPortraitLayer12 = 4000;
			break;
		default:
			NPCCreator.TempList [0].charPortraitLayer12 = 0;
			break;
		}

		if (NPCCreator.TempList [0].breast1Size >= 14) {
			NPCCreator.TempList [0].charPortraitLayer12 += 150;
		} else if (NPCCreator.TempList [0].breast1Size >= 9) {
			NPCCreator.TempList [0].charPortraitLayer12 += 100;
		} else if (NPCCreator.TempList [0].breast1Size >= 4) {
			NPCCreator.TempList [0].charPortraitLayer12 += 50;
		}

		NPCCreator.TempList [0].charPortraitLayer12 += (int)NPCCreator.TempList [0].charSkinColor;

	}



	//This also include legs
	static void createTorso(){
		NPCData.LegsType legsType = NPCCreator.TempList [0].legsType;

		switch (legsType) {
		case NPCData.LegsType.HUMAN:
			if (NPCCreator.TempList [0].breast1Size >= 0) {
				NPCCreator.TempList [0].charPortraitLayer13 = 1000;
			} else {
				NPCCreator.TempList [0].charPortraitLayer13 = 1150;
			}
			break;
		case NPCData.LegsType.WOLF:
			if (NPCCreator.TempList [0].breast1Size >= 0) {
				NPCCreator.TempList [0].charPortraitLayer13 = 3000;
			} else {
				NPCCreator.TempList [0].charPortraitLayer13 = 3150;
			}
			break;
		case NPCData.LegsType.dragon:
			if (NPCCreator.TempList [0].breast1Size >= 0) {
				NPCCreator.TempList [0].charPortraitLayer13 = 4000;
			} else {
				NPCCreator.TempList [0].charPortraitLayer13 = 4150;
			}
			break;
		default:
			NPCCreator.TempList [0].charPortraitLayer13 = 0;
			break;
		}

		if (NPCCreator.TempList [0].hipsSize >= 8) {
			NPCCreator.TempList [0].charPortraitLayer13 += 100;
		} else if (NPCCreator.TempList [0].hipsSize >= 5) {
			NPCCreator.TempList [0].charPortraitLayer13 += 50;
		} 
		NPCCreator.TempList [0].charPortraitLayer13 +=  (int)NPCCreator.TempList [0].charSkinColor;

	}






}
