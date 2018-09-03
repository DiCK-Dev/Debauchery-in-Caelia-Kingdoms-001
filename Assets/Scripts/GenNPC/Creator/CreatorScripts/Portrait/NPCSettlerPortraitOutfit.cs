using UnityEngine;
using System.Collections;

public class NPCSettlerPortraitOutfit  {

	public static void createOutfit(){
		createLowerLeg ();
		createTop ();
		createBallsack ();
		createBottom ();
	}

	static void createLowerLeg(){
		NPCData.HeadType headType = NPCCreator.TempList [0].headType;
		int outfitID = NPCCreator.TempList [0].charEquipment [1];

		if (outfitID == 20000 || outfitID == 0) {
			NPCCreator.TempList [0].charPortraitLayer7 = 0; 
			return;
		}


		switch (outfitID) {
		case 20020:
			NPCCreator.TempList [0].charPortraitLayer7 = 0;

			break;
		case 20010:
			if (NPCCreator.TempList [0].headType == NPCData.HeadType.HUMAN || NPCCreator.TempList [0].headType == NPCData.HeadType.dragon ) {
				NPCCreator.TempList [0].charPortraitLayer7 = 2000;
			} else {
				NPCCreator.TempList [0].charPortraitLayer7 = 0;
			}
			break;
		case 20013:
			NPCCreator.TempList [0].charPortraitLayer7 = 0;
	
			break;
		case 20025:
			if (NPCCreator.TempList [0].legsType == NPCData.LegsType.HUMAN || NPCCreator.TempList [0].legsType == NPCData.LegsType.dragon) {
				NPCCreator.TempList [0].charPortraitLayer7 = 4000;
			} else {
				NPCCreator.TempList [0].charPortraitLayer7 = 0;
			}
			break;
		case 20026:
			if (NPCCreator.TempList [0].legsType == NPCData.LegsType.HUMAN || NPCCreator.TempList [0].legsType == NPCData.LegsType.dragon) {
				NPCCreator.TempList [0].charPortraitLayer7 = 5000;
			} else {
				NPCCreator.TempList [0].charPortraitLayer7 = 0;
			}
			break;
		case 20028:
			if (NPCCreator.TempList [0].legsType == NPCData.LegsType.HUMAN || NPCCreator.TempList [0].legsType == NPCData.LegsType.dragon) {
				NPCCreator.TempList [0].charPortraitLayer7 = 7000;
			} else {
				NPCCreator.TempList [0].charPortraitLayer7 = 0;
			}
			break;
		case 20029: // maid outfit
			if (NPCCreator.TempList [0].legsType == NPCData.LegsType.HUMAN || NPCCreator.TempList [0].legsType == NPCData.LegsType.dragon) {
				NPCCreator.TempList [0].charPortraitLayer7 = 6000;
			} else {
				NPCCreator.TempList [0].charPortraitLayer7 = 0;
			}
			if (NPCCreator.TempList [0].hipsSize >= 8) {
				NPCCreator.TempList [0].charPortraitLayer7 += 2;
			} else if (NPCCreator.TempList [0].hipsSize >= 5) {
				NPCCreator.TempList [0].charPortraitLayer7 += 1;
			} 
			break;
		case 20011: // senator
			if (NPCCreator.TempList [0].legsType == NPCData.LegsType.HUMAN || NPCCreator.TempList [0].legsType == NPCData.LegsType.dragon) {
				NPCCreator.TempList [0].charPortraitLayer7 = 8000;
			} else {
				NPCCreator.TempList [0].charPortraitLayer7 = 0;
			}
			break;
		default:
			NPCCreator.TempList [0].charPortraitLayer7 = 0;
			break;
		}
	}


	static void createTop(){
		NPCData.HeadType headType = NPCCreator.TempList [0].headType;
		int outfitID = NPCCreator.TempList [0].charEquipment [1];

		if (outfitID == 20000 || outfitID == 0) {
			NPCCreator.TempList [0].charPortraitLayer8 = 0; 
			return;
		}


		switch (outfitID) {
		case 20020:
			if (NPCCreator.TempList [0].headType == NPCData.HeadType.HUMAN ||NPCCreator.TempList [0].headType == NPCData.HeadType.WOLF || NPCCreator.TempList [0].headType == NPCData.HeadType.dragon) {
				NPCCreator.TempList [0].charPortraitLayer8 = 1000;
			} else {
				NPCCreator.TempList [0].charPortraitLayer8 = 0;
			}
			break;
		case 20010:
			if (NPCCreator.TempList [0].headType == NPCData.HeadType.HUMAN || NPCCreator.TempList [0].headType == NPCData.HeadType.WOLF || NPCCreator.TempList [0].headType == NPCData.HeadType.dragon) {
				NPCCreator.TempList [0].charPortraitLayer8 = 2000;
			} else {
				NPCCreator.TempList [0].charPortraitLayer8 = 0;
			}
			break;
		case 20013:
			if (NPCCreator.TempList [0].headType == NPCData.HeadType.HUMAN ||NPCCreator.TempList [0].headType == NPCData.HeadType.WOLF || NPCCreator.TempList [0].headType == NPCData.HeadType.dragon) {
				NPCCreator.TempList [0].charPortraitLayer8 = 3000;
			} else {
				NPCCreator.TempList [0].charPortraitLayer8 = 0;
			}
			break;
		case 20025:
			if (NPCCreator.TempList [0].headType == NPCData.HeadType.HUMAN ||NPCCreator.TempList [0].headType == NPCData.HeadType.WOLF || NPCCreator.TempList [0].headType == NPCData.HeadType.dragon ) {
				NPCCreator.TempList [0].charPortraitLayer8 = 4000;

				if (NPCCreator.TempList [0].breast1Size >= 14) {
					NPCCreator.TempList [0].charPortraitLayer12 -= 150;
				} else if (NPCCreator.TempList [0].breast1Size >= 9) {
					NPCCreator.TempList [0].charPortraitLayer12 -= 100;
				} else if (NPCCreator.TempList [0].breast1Size >= 4) {
					NPCCreator.TempList [0].charPortraitLayer12 -= 50;
				}
			} else {
				NPCCreator.TempList [0].charPortraitLayer8 = 0;
			}

			return;
		case 20026:
			if (NPCCreator.TempList [0].headType == NPCData.HeadType.HUMAN ||NPCCreator.TempList [0].headType == NPCData.HeadType.WOLF || NPCCreator.TempList [0].headType == NPCData.HeadType.dragon) {
				NPCCreator.TempList [0].charPortraitLayer8 = 5000;
			} else {
				NPCCreator.TempList [0].charPortraitLayer8 = 0;
			}
			break;
		case 20028:
			if (NPCCreator.TempList [0].headType == NPCData.HeadType.HUMAN ||NPCCreator.TempList [0].headType == NPCData.HeadType.WOLF || NPCCreator.TempList [0].headType == NPCData.HeadType.dragon) {
				NPCCreator.TempList [0].charPortraitLayer8 = 7000;
			} else {
				NPCCreator.TempList [0].charPortraitLayer8 = 0;
			}
			break;
		case 20029:
			if (NPCCreator.TempList [0].headType == NPCData.HeadType.HUMAN ||NPCCreator.TempList [0].headType == NPCData.HeadType.WOLF || NPCCreator.TempList [0].headType == NPCData.HeadType.dragon) {
				NPCCreator.TempList [0].charPortraitLayer8 = 6000;
			} else {
				NPCCreator.TempList [0].charPortraitLayer8 = 0;
			}
			return;
		case 20011:
			if (NPCCreator.TempList [0].headType == NPCData.HeadType.HUMAN || NPCCreator.TempList [0].headType == NPCData.HeadType.dragon) {
				NPCCreator.TempList [0].charPortraitLayer8 = 8000;
			} else {
				NPCCreator.TempList [0].charPortraitLayer8 = 1000;
			}
			break;
		case 20009:
			NPCCreator.TempList [0].charPortraitLayer8 = 9000;
			return;
		case 20017:
			NPCCreator.TempList [0].charPortraitLayer8 = 9000;
			return;
		case 20021:
			NPCCreator.TempList [0].charPortraitLayer8 = 9000;
			return;

		default:
			NPCCreator.TempList [0].charPortraitLayer8 = 1000;
			break;
		}

		if (NPCCreator.TempList [0].breast1Size >= 18) {
			NPCCreator.TempList [0].charPortraitLayer8 += 4;
		} else if (NPCCreator.TempList [0].breast1Size >= 12) {
			NPCCreator.TempList [0].charPortraitLayer8 += 3;
		} else if (NPCCreator.TempList [0].breast1Size >= 8) {
			NPCCreator.TempList [0].charPortraitLayer8 += 2;

		} else if (NPCCreator.TempList [0].breast1Size > 0) {
			NPCCreator.TempList [0].charPortraitLayer8 += 1;
		}
	}



	static void createBallsack(){
		NPCData.HeadType headType = NPCCreator.TempList [0].headType;
		int outfitID = NPCCreator.TempList [0].charEquipment [1];

		if (outfitID == 20000 || outfitID == 0 || NPCCreator.TempList [0].dickSize <= 0) {
			NPCCreator.TempList [0].charPortraitLayer9 = 0; 
			return;
		}


		switch (outfitID) {
		case 20020:
			if (NPCCreator.TempList [0].headType == NPCData.HeadType.HUMAN || NPCCreator.TempList [0].headType == NPCData.HeadType.WOLF || NPCCreator.TempList [0].headType == NPCData.HeadType.dragon) {
				NPCCreator.TempList [0].charPortraitLayer9 = 1000;
			} else {
				NPCCreator.TempList [0].charPortraitLayer9 = 0;
			}
			break;
		case 20010:
			if (NPCCreator.TempList [0].headType == NPCData.HeadType.HUMAN || NPCCreator.TempList [0].headType == NPCData.HeadType.WOLF || NPCCreator.TempList [0].headType == NPCData.HeadType.dragon) {
				NPCCreator.TempList [0].charPortraitLayer9 = 2000;
			} else {
				NPCCreator.TempList [0].charPortraitLayer9 = 0;
			}
			break;
		case 20025:
			NPCCreator.TempList [0].charPortraitLayer9 = 0;
			break;
		case 20026:
			NPCCreator.TempList [0].charPortraitLayer9 = 0;
			break; 
		case 20028:
			NPCCreator.TempList [0].charPortraitLayer9 = 7000;
			break; 
		case 20011:
			NPCCreator.TempList [0].charPortraitLayer9 = 8000;
			break; 

		default:
			NPCCreator.TempList [0].charPortraitLayer9 = 0;
			break;
		}
			
	}


	static void createBottom(){
		NPCData.HeadType headType = NPCCreator.TempList [0].headType;
		int outfitID = NPCCreator.TempList [0].charEquipment [1];

		if (outfitID == 20000 || outfitID == 0) {
			NPCCreator.TempList [0].charPortraitLayer10 = 0; 
			return;
		}


		switch (outfitID) {
		case 20020: //peasant 
			if (NPCCreator.TempList [0].legsType == NPCData.LegsType.HUMAN || NPCCreator.TempList [0].legsType == NPCData.LegsType.WOLF  || NPCCreator.TempList [0].legsType == NPCData.LegsType.dragon ) {
				NPCCreator.TempList [0].charPortraitLayer10 = 1000;
				NPCCreator.TempList [0].charPortraitLayer11 = 0;
			} else {
				NPCCreator.TempList [0].charPortraitLayer10 = 0;
			}
			break;
		case 20010: // noble
			if (NPCCreator.TempList [0].legsType == NPCData.LegsType.HUMAN || NPCCreator.TempList [0].legsType == NPCData.LegsType.WOLF || NPCCreator.TempList [0].legsType == NPCData.LegsType.dragon) {
				NPCCreator.TempList [0].charPortraitLayer10 = 2000;
				NPCCreator.TempList [0].charPortraitLayer11 = 0;

			} else {
				NPCCreator.TempList [0].charPortraitLayer10 = 0;
			}
			break;
		case 20013: // exotic 
			if (NPCCreator.TempList [0].legsType == NPCData.LegsType.HUMAN || NPCCreator.TempList [0].legsType == NPCData.LegsType.WOLF || NPCCreator.TempList [0].legsType == NPCData.LegsType.dragon) {
				NPCCreator.TempList [0].charPortraitLayer10 = 3000;
			} else {
				NPCCreator.TempList [0].charPortraitLayer10 = 0;
			}
			break;
		case 20025: // elven heavy
			if (NPCCreator.TempList [0].legsType == NPCData.LegsType.HUMAN || NPCCreator.TempList [0].legsType == NPCData.LegsType.WOLF || NPCCreator.TempList [0].legsType == NPCData.LegsType.dragon) {
				NPCCreator.TempList [0].charPortraitLayer10 = 4000;
				NPCCreator.TempList [0].charPortraitLayer11 = 0;
			} else {
				NPCCreator.TempList [0].charPortraitLayer10 = 0;
			}
			if (NPCCreator.TempList [0].hipsSize >= 8) {
				NPCCreator.TempList [0].charPortraitLayer13 -= 100;
			} else if (NPCCreator.TempList [0].hipsSize >= 5) {
				NPCCreator.TempList [0].charPortraitLayer13 -= 50;
			} 
			return;
		case 20026: // elven light 
			if (NPCCreator.TempList [0].legsType == NPCData.LegsType.HUMAN || NPCCreator.TempList [0].legsType == NPCData.LegsType.WOLF || NPCCreator.TempList [0].legsType == NPCData.LegsType.dragon) {
				NPCCreator.TempList [0].charPortraitLayer10 = 5000;
				NPCCreator.TempList [0].charPortraitLayer11 = 0;
			} else {
				NPCCreator.TempList [0].charPortraitLayer10 = 0;
			}
			if (NPCCreator.TempList [0].hipsSize >= 8) {
				NPCCreator.TempList [0].charPortraitLayer13 -= 100;
			} else if (NPCCreator.TempList [0].hipsSize >= 5) {
				NPCCreator.TempList [0].charPortraitLayer13 -= 50;
			} 
			return;
		case 20028: // leather outfit
			if (NPCCreator.TempList [0].legsType == NPCData.LegsType.HUMAN || NPCCreator.TempList [0].legsType == NPCData.LegsType.WOLF || NPCCreator.TempList [0].legsType == NPCData.LegsType.dragon) {
				NPCCreator.TempList [0].charPortraitLayer10 = 7000;
				NPCCreator.TempList [0].charPortraitLayer11 = 0;
			} else {
				NPCCreator.TempList [0].charPortraitLayer10 = 0;
			}
			break;
		case 20029: // maid
			if (NPCCreator.TempList [0].legsType == NPCData.LegsType.HUMAN || NPCCreator.TempList [0].legsType == NPCData.LegsType.WOLF || NPCCreator.TempList [0].legsType == NPCData.LegsType.dragon) {
				NPCCreator.TempList [0].charPortraitLayer10 = 6000;
				NPCCreator.TempList [0].charPortraitLayer11 = 0;
			} else {
				NPCCreator.TempList [0].charPortraitLayer10 = 660;
			}
			return;
		case 20011: // leather outfit
			if (NPCCreator.TempList [0].legsType == NPCData.LegsType.HUMAN || NPCCreator.TempList [0].legsType == NPCData.LegsType.dragon) {
				NPCCreator.TempList [0].charPortraitLayer10 = 8000;
				NPCCreator.TempList [0].charPortraitLayer11 = 0;
			} else {
				NPCCreator.TempList [0].charPortraitLayer10 = 1000;
			}
			break;
		case 20009:
			return;
		case 20017:
			return;
		case 20021:
			return;

		default:
			NPCCreator.TempList [0].charPortraitLayer10 = 1000;
			NPCCreator.TempList [0].charPortraitLayer11 = 0;
			break;
		}

		if (NPCCreator.TempList [0].hipsSize >= 8) {
			NPCCreator.TempList [0].charPortraitLayer10 += 2;
		} else if (NPCCreator.TempList [0].hipsSize >= 5) {
			NPCCreator.TempList [0].charPortraitLayer10 += 1;
		} 
	}

}
