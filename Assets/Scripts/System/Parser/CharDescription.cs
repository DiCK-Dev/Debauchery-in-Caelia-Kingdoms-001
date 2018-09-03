using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CharDescription : MonoBehaviour {
	public Text Board; 
	string Paragraph1;
	string lineP1L1;
	string lineP1L2;
	string lineP1L3;
	string LineP10L1;
	string LineP10L2;

	int i;

	string LineP2L1;

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
	string Paragraph12; 
	Parser myParser = new Parser ();







	public void charDescription()
	{

		string head = GameControl.mcHead.toDescription();
		string arms = GameControl.mcArms.toDescription();
		string legs = GameControl.mcLegs.toDescription ();
		string race = GameControl.mcRace.toDescription ();
		string mcSex = GameControl.mcSex.toDescription ();
		string beardLength = GameControl.mcBeardLength.toDescription();
		string beardStyle = GameControl.mcBeardStyle.toDescription();
		string physique = GameControl.mcPhysique.toDescription();
		string skinColor = GameControl.mcSkinColor.toDescription ();
		string skinType = GameControl.mcSkinType.toDescription ();
		string build = GameControl.mcBuild.toDescription ();
		string eyesColor = GameControl.mcEyesColor.toDescription ();
		string eyesType = GameControl.mcEyesType.toDescription ();
		string hairColor = GameControl.mcHairColor.toDescription ();
		string hairLength = GameControl.mcHairLength.toDescription ();
		string hairType = GameControl.mcHairType.toDescription ();
		string hairStyle = GameControl.mcHairStyle.toDescription ();
		string facialFeatures = GameControl.mcFacialFeatures.toDescription ();
		string furColor = GameControl.mcFurColor.toDescription (); 
		string behavior = GameControl.mcGenderBehavior.toDescription(); 

		string waist = GameControl.mcWaistName.toDescription ();
		string hips = GameControl.mcHipsName.toDescription ();
		string charAss = GameControl.mcAssName.toDescription ();
		string tail = GameControl.mcTailType.toDescription ();

		string specialBody = "";

	
		string headAccesory1 = GameControl.mcHeadAccesory1.toDescription ();
		string headAccesory2 = GameControl.mcHeadAccesory2.toDescription ();
		string shoulderAccesory = GameControl.mcShoulderBlades.toDescription ();
		string breastsName1 = GameControl.mcBreast1Name.toDescription ();
		string breastCup1 = GameControl.mcBreast1Cup.toDescription ();
		string breastsName2 = GameControl.mcBreast2Name.toDescription ();
		string breastCup2 = GameControl.mcBreast2Cup.toDescription ();
		string nipples1 = GameControl.areola1Size.ToString ();
		string nipples2 = GameControl.areola2Size.ToString ();
		string dick1Size = GameControl.dick1Size.ToString ();
		string dickType = GameControl.mcDickType.toDescription ();
		string knot = "";
		string bodyShape = ""; 

		string testiclesName = GameControl.mcTesticlesName.toDescription (); 
		string vaginaLooseness = GameControl.mcVagLooseness.toDescription ();//for now solved as if virgin or not.

		if (GameControl.isVirgin == true) {
			vaginaLooseness = "virgin";
		} else {
			vaginaLooseness = "tight";
		}


		string hair;
		string beard = "";


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








		if (GameControl.mcTailType > 0) {
			tail = ", and with a " + tail + " tail at the end of your lowerback";
		} else {
			tail = "";
		}

		if (GameControl.hasKnot == true) {
			knot = "you have a knot"; 
		} else {
			knot = ""; 
		}

		//PARAGRAPH1
		if (GameControl.isGoo == true || GameControl.isPhantom == true) {
			if (GameControl.isGoo == true) {
				specialBody = "goo ";
			} else if (GameControl.isPhantom == true) {
				specialBody = "phantom ";
			}
		}

		if (GameControl.mcHeadAccesory1 == GameControl.MCHeadAccesory1.NONE) {
			headAccesory1 = "";
		} else {
			headAccesory1 = ", with " + headAccesory1; 
		}
		if (GameControl.mcHeadAccesory2 == GameControl.MCHeadAccesory2.NONE) {
			headAccesory2 = "";
		} else {
			headAccesory2 = " and with " + headAccesory2;
		}


		if (GameControl.mcBeardLength != GameControl.MCBeardLength.NONE && GameControl.mcBeardStyle != GameControl.MCBeardStyle.NONE) {
			beard = ", you are sporting a " + GameControl.mcBeardStyle;

		} else if (GameControl.mcBeardLength != GameControl.MCBeardLength.NONE) {
			beard = ", you are sporting a disheveled beard";
		}
		else {
			beard = ""; 
		}


		if (GameControl.mcHairLength == GameControl.MCHairLength.bald) {
			hair = ",  and you are bald."; 
		} else if (GameControl.mcHairLength == GameControl.MCHairLength.shaven) {
			hair = ", and your "  + hairColor + " " + hairType + " hair is shaven.";
		}else {
			hair = ", and  your " +  hairLength + " " + hairColor + " " + hairType + " hair has a "  + hairStyle + " hairstyle.";
		}


		//PARAGRAPH 1- BEHAVIOR 
		behavior = " that behaves in a " + behavior + " fashion";



		//PARAGRAPH 3 - BODY SHAPE
		if (GameControl.mcBodyShape == GameControl.MCBodyShape.apple) {
			bodyShape = "an apple";
		} else {
			bodyShape = "a " + bodyShape;
		}
		//PARAGRAPH 3 - SHOULDER
		if (GameControl.mcShoulderBlades == GameControl.MCShoulderBlades.NONE) {
			shoulderAccesory = "";
		} else {
			shoulderAccesory = shoulderAccesory + ", ";
		}


		//PARAGRAPH 3 - FUR, FEATHER AND MORE
		if (GameControl.hasFur == true) {
			furColor = " with " + furColor + " fur";
		}else if (GameControl.hasFeathers == true) {
			furColor = " with " + GameControl.mcFeatherColor.toDescription () + " feathers";
		}else if (GameControl.hasScales == true) {
			furColor = " with " + GameControl.mcFurColor.toDescription() + " scales";
		} else {
			furColor = ""; 
		}




		// PARAGRAPH 5 - FIRST BREAST ROW
		if (GameControl.breast1Size > 0) {
			Paragraph5 = "\n\nYou have " + breastsName1 + " tits that are " + breastCup1 + " cups with " + nipples1 + " cm areolas"; 
		} else {
			Paragraph5 = "\n\nYour are flat chested with " + nipples1 + " cm areolas" ; 
		}


		// PARAGRAPH 6 - SECOND BREAST ROW
		if (GameControl.breastRow > 1) {
			Paragraph6 = "\n\nYou have a second row of breast with " + breastsName2 + " tits that are " + breastCup2 + " cups with " + nipples2 + " cm nipples"; 
		} else {
			Paragraph6 = "";
		}

		// PARAGRAPH 7 - DICK
		if (GameControl.dick1Size > 0) {
			Paragraph7 = "\n\nYou have a " + dickType + " dick that is " + GameControl.dick1Size + " cm long and " + GameControl.dick1Thick + " cm thick" + knot + ".";
		} else {
			Paragraph7 = "";
		}
			

		// PARAGRAPH 8 - TESTICLES
		if (GameControl.testiclesSize > 0) {
			Paragraph8 = "You have testicles that are " + testiclesName + " which are " + GameControl.testiclesSize + " cm wide.";
		
		} else {
			Paragraph8 = "";
		}
		// IF HAS KNOT THO
		if (GameControl.hasKnot == true) {
			Paragraph8 = "You have a knot."; 
		
		}


		// PARAGRAPH 9 - VAG
		if (GameControl.hasVagina == true) {
			Paragraph9 = "\n\nYou have a " + vaginaLooseness + " cunt."; 
		} else {
			Paragraph9 = "";
		}

		// PARAGRAPH 10 - FLYING AND TENTACLES
		if (GameControl.isFlying == true) {
			LineP10L1 = "\n\nYou have the ability to fly!";
		}else{
			LineP10L1 = "";
		}

		if (GameControl.hasTentacles == true) {
			LineP10L2 = "\n\nYou have the ability to grow tentacles!";
		} else{
			LineP10L2 = "";
		}
		Paragraph10 = LineP10L1 + LineP10L2;


		/////////////////
		// Equipment 
		////////////////
		LineP2L1 = myParser.callStyle();


		/////////////////
		// Equipment 
		////////////////
		if (GameControl.charEquipment [0] > 0 && GameControl.charEquipment [0] != 10000  ) {
			
		} else {
			weapon = "nothing"; 
		}

		if (GameControl.charEquipment [1] > 0 && GameControl.charEquipment [1] != 20000  ) {
			armour = ItemData.itemDataList [GameControl.charEquipment [1]].itemName;
		} else {
			armour = "nothing"; 
		}




		if (GameControl.charEquipment [2] > 0 && GameControl.charEquipment [2] != 30000  ) {
			headGear = ", with a " + headGear + " in your head"; 
		} else {
			headGear = ""; 
		}
		if (GameControl.charEquipment [3] > 0 && GameControl.charEquipment [3] != 40000 ) {
			faceGear = ", wearing a " + faceGear; 
		} else {
			faceGear = ""; 
		}
		if (GameControl.charEquipment [4] > 0 && GameControl.charEquipment [4] != 50000 ) {
			neckGear = ", a " + neckGear +  " in your neck"; 
		} else {
			neckGear = ""; 
		}
		if (GameControl.charEquipment [5] > 0 && GameControl.charEquipment [5] != 60000 ) {
			shouldersGear = ", equiped with " + shouldersGear + " in your shoulders"; 
		} else {
			shouldersGear = ""; 
		}
		if (GameControl.charEquipment [6] > 0 && GameControl.charEquipment [6] != 70000 ) {
			armsGear = ", wearing " + armsGear + " "; 
		} else {
			armsGear = ""; 
		}
		if (GameControl.charEquipment [7] > 0 && GameControl.charEquipment [7] != 80000 ) {
			legsGear = ", and using " + legsGear; 
		} else {
			legsGear = ""; 
		}
		if (GameControl.charEquipment [8] > 0 && GameControl.charEquipment [8] != 90000 ) {
			faceMakeUp = ", and using " + faceMakeUp; 
		} else {
			faceMakeUp = ""; 
		}
			





		Paragraph1 = "You are a " + GameControl.mcHeightName.toDescription () + " " + race + " " + mcSex + "" + specialBody + behavior +   ", your facial features are " + head + " and " + facialFeatures + headAccesory1 + headAccesory2
			+ ". Your have " + eyesColor + " " + eyesType + " eyes" + beard + hair;

		Paragraph2 = "\n\n"+ LineP2L1 + " you are armed with " + weapon + " and wearing " + armour + headGear +  faceGear + neckGear + shouldersGear+ armsGear+ legsGear + faceMakeUp + "." ; 

		Paragraph3 = "\n\nYour body physique is "  + physique  + " and your build is "  + build + " with " + bodyShape + " bodyshape. Your body looks " + GameControl.mcBodyFeatures.toDescription() + ", and you have " + skinColor + " " + skinType + " " + furColor + " and your height is "  + GameControl.heightChar + " cm tall.";

		Paragraph4 = "\n\nYou have " + arms + ", " + shoulderAccesory + waist + " waist, " + hips + " hips and a " + charAss  + " ass, with " + legs + tail + "."  ;


		Paragraph11 = "\n"+ GameControl.piercings[0] + GameControl.piercings[1] + GameControl.piercings[2] + GameControl.piercings[3] + GameControl.piercings[4] + GameControl.piercings[5] + GameControl.piercings[6] + GameControl.piercings[7] + GameControl.piercings[8] + GameControl.piercings[9] + GameControl.piercings[10] + GameControl.piercings[11] + GameControl.piercings[12] + GameControl.piercings[13] + GameControl.piercings[14] + GameControl.piercings[15] + GameControl.piercings[16] + GameControl.piercings[17] + GameControl.piercings[18] + GameControl.piercings[19] + GameControl.piercings[20] ; 
	
		Paragraph12 = "\n" + GameControl.tattoo [0] + GameControl.tattoo [1] + GameControl.tattoo [2] + GameControl.tattoo [3] + GameControl.tattoo [4] + GameControl.tattoo [5] + GameControl.tattoo [6] + GameControl.tattoo [7] + GameControl.tattoo [8] + GameControl.tattoo [9] + GameControl.tattoo [10] + GameControl.tattoo [11] + GameControl.tattoo [12] + GameControl.tattoo [13] + GameControl.tattoo [14] + GameControl.tattoo [15] + GameControl.tattoo [16] + GameControl.tattoo [17] + GameControl.tattoo [18] + GameControl.tattoo [19] + GameControl.tattoo [20] + GameControl.tattoo [21] + GameControl.tattoo [22] + GameControl.tattoo [23] + GameControl.tattoo [24] + GameControl.tattoo [25];



	
		Board.text = Paragraph1 + Paragraph2 + Paragraph3 + Paragraph4 + Paragraph5 + Paragraph6 + Paragraph7 + Paragraph8 + Paragraph9 + Paragraph10 + Paragraph11 + Paragraph12; 




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

	public void attSummary(){
		float attBonus = GameControl.charCombatAttack * 100, defBonus = GameControl.charCombatDefense * 100, lustBonus = GameControl.charLustAttack * 100, lustDefense = GameControl.charLustDefense * 100;
		string toRet = "Martial bonus is used for physical attacks to enemies, persuasion for lust attacks, while tactics is used in certain special skills.";
		toRet += "\n\nAttack and defense are used against physical attacks by enemies, while lust attack and resistance is used to arouse and resist arousal.";
		toRet = "\nMartial bonus: " + GameControl.coreSkillBonus [0];
		toRet += "\nTactics bonus: " + GameControl.coreSkillBonus [3];
		toRet += "\nPersuasion bonus: " + GameControl.coreSkillBonus [6];
		toRet += "\n\nAttack and defense are used against physical attacks by enemies, while lust attack and resistance is used to arouse and resist arousal.";
		toRet += "\nAttack: " + GameControl.charCombatAttack + "%";
		toRet += "\nDefense: " + GameControl.charCombatDefense + "%";
		toRet += "\nLust attack: " + GameControl.charLustAttack+ "%";
		toRet += "\nLust resistance: " + GameControl.charLustDefense + "%";

		toRet += "\n\nHypnotism skill: " + GameControl.attHypnotism;

		toRet += "\n\n                                                                   \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t                                 \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t   \t\t\t\t            ";
		Board.text = toRet;
	}


	void Awake (){
		charDescription ();
	}

	void Update (){
		//charDescription ();
	}


}
