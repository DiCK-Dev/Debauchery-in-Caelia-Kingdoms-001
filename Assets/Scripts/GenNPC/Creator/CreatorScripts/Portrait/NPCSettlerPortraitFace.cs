using UnityEngine;
using System.Collections;

public class NPCSettlerPortraitFace {


	static public void createFace(){
		createAccFront ();
		createHair ();
		createHeadAcc2 ();
		createEyes ();
		createHead ();
		createTorsoAcc ();

	}





	static void createHead(){
		NPCData.HeadType headType = NPCCreator.TempList [0].headType;

		createFaceDet ();

		switch (headType) {
		case NPCData.HeadType.HUMAN:
			if (NPCCreator.TempList [0].charGender == NPCData.CharGender.MALE) {
				NPCCreator.TempList [0].charPortraitLayer4 = 1500;
			} else {
				NPCCreator.TempList [0].charPortraitLayer4 = 1000;
			}
			break;
		case NPCData.HeadType.WOLF:
			if (NPCCreator.TempList [0].charGender == NPCData.CharGender.MALE) {
				NPCCreator.TempList [0].charPortraitLayer4 = 3500;
			} else {
				NPCCreator.TempList [0].charPortraitLayer4 = 3000;
			}
			break;
		case NPCData.HeadType.dragon:
			if (NPCCreator.TempList [0].charGender == NPCData.CharGender.MALE) {
				NPCCreator.TempList [0].charPortraitLayer4 = 4500;
			} else {
				NPCCreator.TempList [0].charPortraitLayer4 = 4000;
			}
			break;
		default:
			NPCCreator.TempList [0].charPortraitLayer4 = 0;
			break;
		}
		NPCCreator.TempList [0].charPortraitLayer4 += (int)NPCCreator.TempList [0].charSkinColor;
	}

	static void createAccFront(){
		NPCData.HeadAccesory1 headAcc1 = NPCCreator.TempList [0].headAccesory1;
		// add to ignore if update after creation
		switch (headAcc1) {
		case NPCData.HeadAccesory1.DemonicHorns:
			if (NPCCreator.TempList [0].headType != NPCData.HeadType.HUMAN) {
				NPCCreator.TempList [0].charPortraitLayer0 = 0;
				NPCCreator.TempList [0].charPortraitLayer0 = 0;
				break;
			}
			if (NPCCreator.TempList [0].charCorruption > 75) {
				NPCCreator.TempList [0].charPortraitLayer0 = 2003;
				NPCCreator.TempList [0].charPortraitLayer5 = 2003;
			} else if (NPCCreator.TempList [0].charCorruption > 50) {
				NPCCreator.TempList [0].charPortraitLayer0 = 2002;
				NPCCreator.TempList [0].charPortraitLayer5 = 2002;
			}  else if (NPCCreator.TempList [0].charCorruption > 25) {
				NPCCreator.TempList [0].charPortraitLayer0 = 2001;
				NPCCreator.TempList [0].charPortraitLayer5 = 2001;

			} else {
				NPCCreator.TempList [0].charPortraitLayer0 = 2000;
				NPCCreator.TempList [0].charPortraitLayer5 = 2000;

			}
			break;
		case NPCData.HeadAccesory1.dragonHorns:
			int randNum = Random.Range (0, 3);
			switch (randNum) {
			case 0:
				NPCCreator.TempList [0].charPortraitLayer0 = 4000;
				NPCCreator.TempList [0].charPortraitLayer5 = 4000;
				break;
			case 1:
				NPCCreator.TempList [0].charPortraitLayer0 = 4010;
				NPCCreator.TempList [0].charPortraitLayer5 = 4010;
				break;
			case 2:
				NPCCreator.TempList [0].charPortraitLayer0 = 4020;
				NPCCreator.TempList [0].charPortraitLayer5 = 4020;
				break;
			default:
				NPCCreator.TempList [0].charPortraitLayer0 = 4030;
				break;
			}
			break;
			
		default:
			NPCCreator.TempList [0].charPortraitLayer0 = 0;
			break;
		}
	}


	static void createHair(){
		NPCData.HeadType headType = NPCCreator.TempList [0].headType;
		NPCData.HairStyle hairstyle = NPCCreator.TempList [0].hairStyle;
		NPCCreator.TempList [0].charPortraitLayer1 = 0;
		NPCCreator.TempList [0].charPortraitLayer14 = 0;


		switch (headType) {
		case NPCData.HeadType.HUMAN:
			switch (hairstyle) {
			case NPCData.HairStyle.bob:
				NPCCreator.TempList [0].charPortraitLayer1 = 1060;
				NPCCreator.TempList [0].charPortraitLayer14 = 1060;

				break;
			case NPCData.HairStyle.disheveled:
				NPCCreator.TempList [0].charPortraitLayer1= 1000;
				break;
			case NPCData.HairStyle.bald:
				NPCCreator.TempList [0].charPortraitLayer1 = 0;
				break;
			case NPCData.HairStyle.pixie:
				NPCCreator.TempList [0].charPortraitLayer1 = 1120;
				NPCCreator.TempList [0].charPortraitLayer14 = 1120;

				break;
			case NPCData.HairStyle.ElegantBun:
				NPCCreator.TempList [0].charPortraitLayer1 = 1180;
				NPCCreator.TempList [0].charPortraitLayer14 = 1180;

				break;
			case NPCData.HairStyle.LongPonytails:
				NPCCreator.TempList [0].charPortraitLayer1 = 1240;
				NPCCreator.TempList [0].charPortraitLayer14 = 1240;

				break;
			default:
				NPCCreator.TempList [0].charPortraitLayer1 = 1000;
				break;
			}
			break;
		case NPCData.HeadType.WOLF:
			switch (hairstyle) {
			case NPCData.HairStyle.LongHair:
				NPCCreator.TempList [0].charPortraitLayer1 = 3260;
				NPCCreator.TempList [0].charPortraitLayer14 = 3260;

				break;
			case NPCData.HairStyle.disheveled:
				NPCCreator.TempList [0].charPortraitLayer1 = 3000;
				break;
			case NPCData.HairStyle.bald:
				NPCCreator.TempList [0].charPortraitLayer1 = 0;
				break;
			default:
				NPCCreator.TempList [0].charPortraitLayer1 = 3000;
				break;
			}
			break;
		case NPCData.HeadType.dragon:
			if (NPCCreator.TempList [0].charPortraitLayer0 == 4000) {
				NPCCreator.TempList [0].charPortraitLayer1 = 4000;
			} else {
				NPCCreator.TempList [0].charPortraitLayer1 = 0;
			}

			break;
		default:
			NPCCreator.TempList [0].charPortraitLayer1 = 0;
			break;
		}
		NPCCreator.TempList [0].charPortraitLayer1 +=  (int)NPCCreator.TempList [0].hairColor;
		NPCCreator.TempList [0].charPortraitLayer14 +=  (int)NPCCreator.TempList [0].hairColor;
	}


	static void createHeadAcc2(){
		NPCData.HeadAccesory2 headAcc2 = NPCCreator.TempList [0].headAccesory2;

		switch (headAcc2) {
		case NPCData.HeadAccesory2.elfEars:
			NPCCreator.TempList [0].charPortraitLayer2 = 2000;
			NPCCreator.TempList [0].charPortraitLayer2 = NPCCreator.TempList [0].charPortraitLayer2 + (int)NPCCreator.TempList [0].charSkinColor;
			break;
		case NPCData.HeadAccesory2.demonEars:
			NPCCreator.TempList [0].charPortraitLayer2 = 2000;
			NPCCreator.TempList [0].charPortraitLayer2 = NPCCreator.TempList [0].charPortraitLayer2 + (int)NPCCreator.TempList [0].charSkinColor;
			break;
		default:
			NPCCreator.TempList [0].charPortraitLayer2 = 0;
			break;
		}
	}

	static void createEyes(){ // make ignore if updating
		NPCData.EyesType eyeType = NPCCreator.TempList [0].eyesType;

		switch (eyeType) {
		case NPCData.EyesType.human0:
			NPCCreator.TempList [0].charPortraitLayer3 = 1000;
			NPCCreator.TempList [0].charPortraitLayer3 = NPCCreator.TempList [0].charPortraitLayer3 + (int)NPCCreator.TempList [0].eyesColor;
			break;
		case NPCData.EyesType.human1:
			NPCCreator.TempList [0].charPortraitLayer3 = 1020;
			NPCCreator.TempList [0].charPortraitLayer3 = NPCCreator.TempList [0].charPortraitLayer3 + (int)NPCCreator.TempList [0].eyesColor;
			break;
		case NPCData.EyesType.demon0:
			NPCCreator.TempList [0].charPortraitLayer3 = 1000;
			NPCCreator.TempList [0].charPortraitLayer3 = NPCCreator.TempList [0].charPortraitLayer3 + (int)NPCCreator.TempList [0].eyesColor;
			break;
		case NPCData.EyesType.demon1:
			NPCCreator.TempList [0].charPortraitLayer3 = 1020;
			NPCCreator.TempList [0].charPortraitLayer3 = NPCCreator.TempList [0].charPortraitLayer3 + (int)NPCCreator.TempList [0].eyesColor;
			break;
		case NPCData.EyesType.wolf0:
			NPCCreator.TempList [0].charPortraitLayer3 = 3000;
			NPCCreator.TempList [0].charPortraitLayer3 = NPCCreator.TempList [0].charPortraitLayer3 + (int)NPCCreator.TempList [0].eyesColor;
			break;
		case NPCData.EyesType.wolf1:
			NPCCreator.TempList [0].charPortraitLayer3 = 3020;
			NPCCreator.TempList [0].charPortraitLayer3 = NPCCreator.TempList [0].charPortraitLayer3 + (int)NPCCreator.TempList [0].eyesColor;
			break;
		case NPCData.EyesType.dragon:
			int randNum = Random.Range (0, 4);
			switch (randNum) {
			case 0:
				NPCCreator.TempList [0].charPortraitLayer3 = 4020 + (int)NPCCreator.TempList [0].eyesColor;
				break;
			case 1:
				NPCCreator.TempList [0].charPortraitLayer3 = 4040 + (int)NPCCreator.TempList [0].eyesColor;
				break;
			case 2:
				NPCCreator.TempList [0].charPortraitLayer3 = 4060 + (int)NPCCreator.TempList [0].eyesColor;
				break;
			case 3:
				NPCCreator.TempList [0].charPortraitLayer3 = 4080 + (int)NPCCreator.TempList [0].eyesColor;
				break;
			default:
				NPCCreator.TempList [0].charPortraitLayer3 = 4000 + (int)NPCCreator.TempList [0].eyesColor;
				break;
			}

			break;
		default:
			NPCCreator.TempList [0].charPortraitLayer3 = 0;
			break;
		}
	}

	//used for special, naked accesories, like the wolf chest hair
	static void createTorsoAcc(){
		NPCData.HeadType headType = NPCCreator.TempList [0].headType;
		NPCCreator.TempList [0].charPortraitLayer6 = 0;

		switch (headType) {
		case NPCData.HeadType.WOLF:
			if(NPCCreator.TempList [0].charEquipment[1] == 20000 || NPCCreator.TempList [0].charEquipment[1] == 0 ){
				NPCCreator.TempList [0].charPortraitLayer6 = 3000 + (int)NPCCreator.TempList [0].charSkinColor;
			}
			break;
		default:
			NPCCreator.TempList [0].charPortraitLayer6 = 0;

			break;
		}
	}


	static void createFaceDet(){
		NPCData.HeadType headType = NPCCreator.TempList [0].headType;

		NPCCreator.TempList [0].charPortraitLayer3a = 0;
		int randNum = Random.Range (0, 5);

		switch (headType) {
		case NPCData.HeadType.dragon:
			switch (randNum) {
			case 0:
				NPCCreator.TempList [0].charPortraitLayer3a = 4000;
				break;
			case 1:
				NPCCreator.TempList [0].charPortraitLayer3a = 4001;
				break;
			case 2:
				NPCCreator.TempList [0].charPortraitLayer3a = 4002;
				break;
			case 3:
				NPCCreator.TempList [0].charPortraitLayer3a = 4003;
				break;
			case 4:
				NPCCreator.TempList [0].charPortraitLayer3a = 4004;
				break;
			default:
				NPCCreator.TempList [0].charPortraitLayer3a = 4000;
				break;
			}
			break;
		default:
			NPCCreator.TempList [0].charPortraitLayer3a = 0;

			break;
		}
	}




}
