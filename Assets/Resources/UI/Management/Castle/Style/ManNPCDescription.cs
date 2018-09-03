using UnityEngine;
using System.Collections;

public class ManNPCDescription  {



	static public string npcDescription(){
		string ret, HESHE = "He", heshe = "he", HISHER = "His", hisher = "his", HIMHER = "Him", himher = "him";
		string P1= "", P2 = "", P3 = "", P4 = "", P5 = "", P6 = "";
		if (NPCCharList.CharRetainers [WorldControl.idx].charGender == NPCData.CharGender.FEMALE) {
			HESHE = "She"; heshe = "she"; HISHER = "Her"; hisher = "her"; HIMHER = "Her"; himher = "her";
		}


		string P1L1 = "", P1L2 = "";
		if (NPCCharList.CharRetainers [WorldControl.idx].headAccesory1 != NPCData.HeadAccesory1.NONE) {
			P1L1 = " and " +NPCCharList.CharRetainers [WorldControl.idx].headAccesory1.toDescription ();
		}
		if (NPCCharList.CharRetainers [WorldControl.idx].headAccesory2 != NPCData.HeadAccesory2.NONE) {
			P1L1 = " and " +NPCCharList.CharRetainers [WorldControl.idx].headAccesory2.toDescription ();
		}


		string P2L1 = " is unarmed", P2L2 = " and naked";
		if (NPCCharList.CharRetainers [WorldControl.idx].charEquipment [0] != 10000 || NPCCharList.CharRetainers [WorldControl.idx].charEquipment [0] != 0) {
			P2L1 = " is armed with a " + ItemData.itemDataList[NPCCharList.CharRetainers [WorldControl.idx].charEquipment[0]].itemName;
		}
		if (NPCCharList.CharRetainers [WorldControl.idx].charEquipment [1] != 20000 || NPCCharList.CharRetainers [WorldControl.idx].charEquipment [1] != 0) {
			P2L2 = " and is dressed with " + ItemData.itemDataList[NPCCharList.CharRetainers [WorldControl.idx].charEquipment[1]].itemName + ".";
		}


		string P3L1 = "";
		if (NPCCharList.CharRetainers [WorldControl.idx].hasFur && WorldControl.furryOn) {
			P3L1 = " with " + NPCCharList.CharRetainers [WorldControl.idx].charFurColor.toDescription() + " fur";
		}

		string P4L1 = "", P4L2 = "";
		if (NPCCharList.CharRetainers [WorldControl.idx].shoulderBlades != NPCData.ShoulderBlades.NONE) {
			P4L1 = ", " +NPCCharList.CharRetainers [WorldControl.idx].shoulderBlades.toDescription() ;
		}

		if (NPCCharList.CharRetainers [WorldControl.idx].lowerBack != NPCData.LowerBack.NONE) {
			P4L2 = " and an " +NPCCharList.CharRetainers [WorldControl.idx].lowerBack.toDescription() + " tail" ;
		}


		P1 = NPCCharList.CharRetainers [WorldControl.idx].charName + " is a "+ NPCCharList.CharRetainers [WorldControl.idx].genderBehavior.toDescription()  + " "+ NPCCharList.CharRetainers [WorldControl.idx].heightName.toDescription() + " " + NPCCharList.CharRetainers [WorldControl.idx].charRace.toDescription()
			+ " " +NPCCharList.CharRetainers [WorldControl.idx].charSex.toDescription() + ", " + heshe + " has a " + NPCCharList.CharRetainers [WorldControl.idx].headType.toDescription() + " head with " + NPCCharList.CharRetainers [WorldControl.idx].facialFeatures.toDescription() + " features" + P1L1 + P1L2+ ".";

		P2 = HESHE + P2L1 + P2L2;

		P3 = HISHER + " body physique is " + NPCCharList.CharRetainers [WorldControl.idx].bodyPhysique.toDescription () + ", " + hisher + " build is "  +NPCCharList.CharRetainers [WorldControl.idx].bodyBuild.toDescription() + ". " + HISHER + " body looks " + NPCCharList.CharRetainers [WorldControl.idx].bodyFeatures.toDescription() + " and " + heshe +  " have "
			+ NPCCharList.CharRetainers [WorldControl.idx].charSkinColor.toDescription() + " " + NPCCharList.CharRetainers [WorldControl.idx].charSkinType.toDescription() +  " skin " + P3L1 + " and " + hisher + " height is " + NPCCharList.CharRetainers [WorldControl.idx].heightChar.ToString() + " cm." ;

		P4 = HESHE + " have " + NPCCharList.CharRetainers [WorldControl.idx].armsType.toDescription() +  P4L1 + ", "+ NPCCharList.CharRetainers [WorldControl.idx].waistName.toDescription() + " waist and a " +NPCCharList.CharRetainers [WorldControl.idx].assName.toDescription() + " ass with " + NPCCharList.CharRetainers [WorldControl.idx].legsType.toDescription() + " legs" + P4L2  + "."  ;


		int i = 0;
		while (i < 18) {
			if (NPCCharList.CharRetainers [WorldControl.idx].charTattoos [i] != "") {
				P5 += "\n\n" + NPCCharList.CharRetainers [WorldControl.idx].charTattoos [i]; 
			}
			i++;
		}

		i = 0;
		while (i < 21) {
			if (NPCCharList.CharRetainers [WorldControl.idx].charPiercings [i] != "") {
				P6 += "\n\n" + NPCCharList.CharRetainers [WorldControl.idx].charPiercings[i]; 
			}
			i++;
		}
		return P1 + "\n\n" +P2 + "\n\n"+ P3 + "\n\n"+ P4 + P5 + P6;
	}
}
