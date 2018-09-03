using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharCreationDescription : MonoBehaviour {

	public Text summary;
	string Paragraph1;
	string lineP1L1;
	string lineP1L2;
	string lineP1L3;


	string Paragraph2; 
	string Paragraph3; 
	string Paragraph4; 
	string Paragraph5; 
	string Paragraph6; 
	string Paragraph7; 
	string Paragraph8; 
	string Paragraph9; 
	string Paragraph10; 
	string Paragraph11; 
	Parser myParser = new Parser ();







	public void charDescription()
	{
		string face = myParser.callCharFace();
		string arms = myParser.callCharArmsType();
		string legs = myParser.callCharLegsType();
		string race = myParser.callCharRace ();
		string gender = myParser.callCharGender ();
		string beardLength = myParser.callCharBeard();
		string beardStyle = myParser.callCharBeardStyle ();
		string physique = myParser.callCharPhysique();
		string skinColor = myParser.callSkinColor ();
		string skinType = myParser.callSkinType ();
		string build = myParser.callCharBuild();
		string eyesColor = myParser.callCharEyesColor();
		string eyesType = myParser.callCharEyesType();
		string hairColor = myParser.callCharHairColor();
		string hairLength = myParser.callCharHairLength ();
		string hairType = myParser.callCharHairType ();
		string hairStyle = myParser.callCharHairStyle ();
		string feminity = myParser.callFemininity ();
		string furColor = myParser.callFurColor(); 

		string waist = myParser.callWaist ();
		string hips = myParser.callHips ();
		string charAss = myParser.callAss ();
		string tail = myParser.callTail();

		string specialBody = myParser.callSpecialBody ();


		string headAccesory1 = myParser.callHeadAccesory1 ();
		string headAccesory2 = myParser.callHeadAccesory2 ();
		string shoulderAccesory = myParser.callShoulderAccesory ();
		string breastsName1 = myParser.callBreastsName1 ();
		string breastCup1 = myParser.callBreastCup1 ();
		string breastsName2 = myParser.callBreastsName2 ();
		string breastCup2 = myParser.callBreastCup2 ();
		string nipples1 = GameControl.areola1Size.ToString ();
		string nipples2 = GameControl.areola2Size.ToString ();
		string dick1Size = GameControl.dick1Size.ToString ();
		string dickType = myParser.callDickType ();
		string knot = "";

		string testiclesName = myParser.callTesticlesName ();
		string vaginaLooseness = myParser.callVaginaLooseness ();

		string hair;
		string beard;


		// equipment


		string weapon = ItemData.itemDataList [GameControl.charEquipment [0]].itemName; 
		string armour = ItemData.itemDataList [GameControl.charEquipment [1]].itemName; 
		string headGear = ItemData.itemDataList [GameControl.charEquipment [2]].itemName; 
		string faceGear = ItemData.itemDataList [GameControl.charEquipment [3]].itemName; 
		string neckGear = ItemData.itemDataList [GameControl.charEquipment [4]].itemName; 
		string shouldersGear = ItemData.itemDataList [GameControl.charEquipment [5]].itemName; 
		string armsGear = ItemData.itemDataList [GameControl.charEquipment [6]].itemName; 
		string legsGear = ItemData.itemDataList [GameControl.charEquipment [7]].itemName; 
		string faceMakeUp = ItemData.itemDataList [GameControl.charEquipment [8]].itemName; 

		if (GameControl.hasFur == true) {
			furColor = " with " + furColor + " fur";
		} else {
			furColor = ""; 
		}

		if (GameControl.mcTailType > 0) {
			tail = "with a " + tail + " tail at the end of your lowerback";
		} else {
			tail = "";
		}

		if (GameControl.hasKnot == true) {
			knot = "you have a knot"; 
		} else {
			knot = ""; 
		}
		// PARAGRAPH 7
		if (GameControl.dick1Size > 0) {
			Paragraph7 = "\nYou have a " + dickType + " dick that is " + GameControl.dick1Size + " cm long and " + GameControl.dick1Thick + " cm thick" + knot + ".";
		} else {
			Paragraph7 = "";
		}


		// PARAGRAPH 8
		if (GameControl.testiclesSize > 0) {
			Paragraph8 = "You have testicles that are " + testiclesName + " which are " + GameControl.testiclesSize + " cm wide.";

		} else {
			Paragraph8 = "";
		}
		// IF HAS KNOT THO
		if (GameControl.hasKnot == true) {
			Paragraph8 = "You have a knot."; 

		}


		// PARAGRAPH 6
		if (GameControl.breastRow > 1) {
			Paragraph6 = "\nYou have a second row of breast with " + breastsName2 + " tits that are " + breastCup2 + " cups with " + nipples2 + " cm nipples"; 
		} else {
			Paragraph6 = "";
		}
		// PARAGRAPH 9
		if (GameControl.hasVagina == true) {
			Paragraph9 = "\nYou have a " + vaginaLooseness + " cunt."; 
		} else {
			Paragraph9 = "";
		}
		// PARAGRAPH 5
		if (GameControl.breast1Size > 0) {
			Paragraph5 = "\nYou have " + breastsName1 + " tits that are " + breastCup1 + " cups with " + nipples1 + " cm nipples"; 
		} else {
			Paragraph5 = "\nYour are flat chested with " + nipples1 + " cm nipples" ; 
		}
		if (GameControl.mcHairLength == GameControl.MCHairLength.bald) {
			hair = " is bald."; 
		} else {
			hair = "your " + hairType + " " + hairColor + " hair is " + hairLength + " length with "  + hairStyle + ".";
		}
		/*
		if (GameControl.beardLength > 0){
			beard = beardLength + " with " + beardStyle + " style";

		}else {
			beard = "no beard"; 
		}
*/







		/////////////////
		// Equipment 
		////////////////
		if (GameControl.charEquipment [2] > 0) {
			headGear = ", with a " + headGear + " in your head"; 
		} else {
			headGear = ""; 
		}
		if (GameControl.charEquipment [3] > 0) {
			faceGear = ", wearing a " + faceGear; 
		} else {
			faceGear = ""; 
		}
		if (GameControl.charEquipment [4] > 0) {
			neckGear = ", a " + neckGear +  " in your neck"; 
		} else {
			neckGear = ""; 
		}
		if (GameControl.charEquipment [5] > 0) {
			shouldersGear = ", equiped with " + shouldersGear + " in your shoulders"; 
		} else {
			shouldersGear = ""; 
		}
		if (GameControl.charEquipment [6] > 0) {
			armsGear = ", wearing " + armsGear + " "; 
		} else {
			armsGear = ""; 
		}
		if (GameControl.charEquipment [7] > 0) {
			legsGear = ", and using " + legsGear; 
		} else {
			legsGear = ""; 
		}







		Paragraph1 = "You are a " + GameControl.mcHeightName.toDescription() + " " + gender + " " + specialBody + " " + race + ", with a " + face + " and you look " + feminity +  headAccesory1 + headAccesory2 
			+ ", with " + eyesType + " " + eyesColor + " eyes, sporting "/* + beard */+ " and " + hair;

		Paragraph2 = "\nYou are armed with " + weapon + " and wearing " + armour + headGear +  faceGear + neckGear + shouldersGear+ armsGear+ legsGear + "." ; 

		Paragraph3 = "\nYour body physique is " + physique + " and your build is " + build + " with a " + GameControl.mcBodyShape.toDescription () + " bodyshape, you have " + skinColor + " " + skinType + " " + furColor + " and your height is " + GameControl.heightChar + " cm tall.";

		Paragraph4 = "\nYou have " + arms + ", " + shoulderAccesory + " "+ waist + " waist, " + hips + " hips and a " + charAss  + " ass and " + legs + " " + tail + "."  ;






		summary.text = Paragraph1 + Paragraph2 + Paragraph3 + Paragraph4 + Paragraph5 + Paragraph6 + Paragraph7 + Paragraph8 + Paragraph9; 




		// you are a "heightname//only for petite, giant" "gender" "specialGoo,Phantasm,etc." "race", with "face" that has "feminity features" "Head accesory 1""Head accesory 2" "neck accesory" 
		//"eyes type" "eyesColor", sporting "Beard" and "lenght hair" "hair color" "hair type", "hair style". 

		//"Weapon", "Cloths/Armor" "helmet" "head accesory" "face accesory". You have "Shoulders" "arms" legs"
		//Your body is "built" and "weight" "BodyShape", "skin" "skintype" "furcolour" and "height". You have "arms" "shoulder accesory" "waist" "hips" "ass" "legs" "Tail". 
		//ROW 1You have "breastsDescription" "nipples" "cup"
		//ROW 2You have "breastsDescription" "nipples" "cup"
		//DICK 1You have a "Dick1SizeName" "DickType" "Dick1Size""Dick1Thick" "knot", "knot size" 
		//DICK 2You also have a "Dick2SizeName" "Dick2Type" "Dick2Size""Dick2Thick" "knot", "knot size" 
		//You have "ballsName" under "dickType". "Balls size".
		//Your count is "Looseness", with a "clitSize" clit,
		//Tentacles
		//
		//"Tatto1" "Tatto2" ... "tatto18" espalda baja, hombros 2, brazos 2, piernas 2, tobillos 2, cara 1, cuello 1, espalda 1, vientre, estomago 1,  pechos 2, torso 1, frente 1
		//"piercing1" "...""piercing17". 2 cejas, 3 nariz, lengua, boca 3, labios 2, orejas 4, pezones 2, dick, clit



	}




	void Update () {


	}
}
