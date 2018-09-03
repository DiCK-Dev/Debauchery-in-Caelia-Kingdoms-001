using UnityEngine;
using System.Collections;

public class CombatEnemyDescriptionTexts : MonoBehaviour {

	string description;
	string HESHE, heshe;
	string HISHER, hisher;

	public string genericEnemyDescription(){
		string P0, P1, P2, P3, P4;

		if (NPCCharList.CharMonster [0].charGender == NPCData.CharGender.MALE) {
			HESHE = "He";
			heshe = "he";
			HISHER = "His";
			hisher = "his";
		}else if(NPCCharList.CharMonster [0].charGender == NPCData.CharGender.FEMALE){
			heshe = "she";
			HESHE = "She";
			hisher = "her";
			HISHER = "Her";
		}else{
			heshe = "its";
			hisher = "its";
			HESHE = "Its";
			HISHER = "Its";
		}

		P0 = "In front of you lies a "+ NPCCharList.CharMonster[0].charRace.toDescription() +" " + NPCCharList.CharMonster[0].charClass.toDescription()  + ", equipped with a "+ ItemData.itemDataList[NPCCharList.CharMonster[0].charEquipment[0]].itemName +" and wearing "+ ItemData.itemDataList[NPCCharList.CharMonster[0].charEquipment[1]].itemName  +".\n\n";
		P1 = HISHER + " attitude is "+ NPCCharList.CharMonster[0].charPersonality.toDescription() +".\n\n";

		if (NPCCharList.CharMonster [0].isFurry) {
			P2 = HESHE + " stands "+ NPCCharList.CharMonster[0].heightChar +" cm tall, with "+ NPCCharList.CharMonster[0].facialFeatures.toDescription() +" facial features, " + NPCCharList.CharMonster[0].eyesColor.toDescription() + " eyes and "+ NPCCharList.CharMonster[0].hairColor.toDescription() +" "+ NPCCharList.CharMonster[0].hairStyle.toDescription()  +" haircut.  "+ HISHER +" body looks "+ NPCCharList.CharMonster[0].bodyFeatures.toDescription() +" with a "+ NPCCharList.CharMonster[0].bodyPhysique.toDescription() +" physique and "+ hisher +" build is "+ NPCCharList.CharMonster[0].bodyBuild.toDescription()  +", with "+ NPCCharList.CharMonster[0].charFurColor.toDescription() +" fur.\n\n ";
		} else {
			P2 = HESHE + " stands "+ NPCCharList.CharMonster[0].heightChar +" cm tall, with "+ NPCCharList.CharMonster[0].facialFeatures.toDescription() +" facial features, " + NPCCharList.CharMonster[0].eyesColor.toDescription() + " eyes and "+ NPCCharList.CharMonster[0].hairColor.toDescription() +" "+ NPCCharList.CharMonster[0].hairStyle.toDescription()  +" haircut.  "+ HISHER +" body looks "+ NPCCharList.CharMonster[0].bodyFeatures.toDescription() +" with a "+ NPCCharList.CharMonster[0].bodyPhysique.toDescription() +" physique and "+ hisher +" build is "+ NPCCharList.CharMonster[0].bodyBuild.toDescription()  +", with "+ NPCCharList.CharMonster[0].charSkinColor.toDescription() +" skin.\n\n ";
		}

		P3 = "You can see "+ hisher +" behavior is "+ NPCCharList.CharMonster[0].genderBehavior.toDescription() +".";


		if (NPCCharList.CharMonster [0].dickSizeCM > 0) {
			P4 = "You estimate " +hisher+ " breasts are "+ NPCCharList.CharMonster[0].breast1Cup.toDescription() +" in cup, with a "+ NPCCharList.CharMonster[0].assName.toDescription() +" ass, "+ NPCCharList.CharMonster[0].waistName.toDescription() +" waist and "+ NPCCharList.CharMonster[0].hipsName.toDescription() +" hips. Thanks to the bulge on "+ hisher +" pants, you think "+ hisher +" cock is probably "+ NPCCharList.CharMonster[0].dickSize.toDescription() +" in size, with "+ NPCCharList.CharMonster[0].testiclesSize.toDescription() +" balls.";
		} else {
			P4 = "You estimate "+hisher +"breasts are "+ NPCCharList.CharMonster[0].breast1Cup.toDescription() +" in cup, with a "+ NPCCharList.CharMonster[0].assName.toDescription() +" ass, "+ NPCCharList.CharMonster[0].waistName.toDescription() +" waist and "+ NPCCharList.CharMonster[0].hipsName.toDescription() +" hips.";
		}


		Debug.Log ("CombatEnemyDescription script");
		return P0 + P1 + P2 + P3 + P4;
	}

	public string enemyMonsterRace()
	{
		switch (NPCCharList.CharMonster[0].charRace)
		{
		case NPCData.CharRace.harpy:

			return Harpy();
		default:
			return "";

		}


	}




	string Harpy(){
		return "";


	}

	string Cockatrice(){
		return "";
	}









}
