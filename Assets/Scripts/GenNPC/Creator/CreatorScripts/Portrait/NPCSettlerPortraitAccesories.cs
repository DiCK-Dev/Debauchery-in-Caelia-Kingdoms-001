using UnityEngine;
using System.Collections;

public class NPCSettlerPortraitAccesories{

	static public void createAccesories(){
		createLowerBack ();
		createShoulderBlades ();

	}

	static void createLowerBack(){
		NPCData.LowerBack lowerBack = NPCCreator.TempList [0].lowerBack;

		switch (lowerBack) {
		case NPCData.LowerBack.wolf:
			NPCCreator.TempList [0].charPortraitLayer15 = 3000 + (int)NPCCreator.TempList [0].charSkinColor;
			break;
		case NPCData.LowerBack.demon:
			NPCCreator.TempList [0].charPortraitLayer15 = 2000;
			break;
		case NPCData.LowerBack.dragon:
			NPCCreator.TempList [0].charPortraitLayer15 = 4000 + (int)NPCCreator.TempList [0].charSkinColor;
			break;
		default:
			NPCCreator.TempList [0].charPortraitLayer15 = 0;
			break;
		}

	}

	static void createShoulderBlades(){
		NPCData.ShoulderBlades shoulderBlades = NPCCreator.TempList [0].shoulderBlades;

		switch (shoulderBlades) {
		case NPCData.ShoulderBlades.DemonWings:
			NPCCreator.TempList [0].charPortraitLayer16 = 2000;
			return;
		case NPCData.ShoulderBlades.DragonWings:
			NPCCreator.TempList [0].charPortraitLayer16 = 4000;
			break;
		default:
			NPCCreator.TempList [0].charPortraitLayer16 = 0;
			return;
		}
		NPCCreator.TempList [0].charPortraitLayer16 += (int)NPCCreator.TempList [0].charSkinColor;

	}


}
