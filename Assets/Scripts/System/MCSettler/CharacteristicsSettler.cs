using UnityEngine;
using System.Collections;

public class CharacteristicsSettler : MonoBehaviour {

	int i; 
	int rankNum; 
	RankSettler rankSettler = new RankSettler();

	public void setCharGender()
	{
		if (GameControl.dickNum > 0 && GameControl.breast1Size < 40 && GameControl.hasVagina == false) {
			GameControl.mcSex = GameControl.MCSex.Man; //man
		} else if (GameControl.dickNum > 0 && GameControl.breast1Size < 40 && GameControl.facialFeaturesStat > 70  && GameControl.hasVagina == false) {
			GameControl.mcSex = GameControl.MCSex.Trap;
		} else if (GameControl.dickNum <= 0 && GameControl.hasVagina == true && GameControl.testiclesSize <= 0) {
			GameControl.mcSex = GameControl.MCSex.Woman; // woman
		} else if (GameControl.dickNum <= 0 && GameControl.hasVagina == false) {
			GameControl.mcSex = GameControl.MCSex.Eunuch; //asexual
		} else if (GameControl.dickNum > 0 && GameControl.breast1Size >= 40 && GameControl.hasVagina == false) {
			GameControl.mcSex = GameControl.MCSex.Dickgirl;  // DickGirl
		} else if (GameControl.dickNum > 0 && GameControl.breast1Size >= 40 && GameControl.hasVagina == true) {
			GameControl.mcSex = GameControl.MCSex.Futanari;  // Futa
		} else if (GameControl.dickNum <= 0 && GameControl.breast1Size <= 40 && GameControl.hasVagina == true ) { 
			GameControl.mcSex = GameControl.MCSex.Cuntboy;  // herm-male
		}
	}


	//	public enum MCTesticleName{NONE, [Description("small like grapes")]smallgrapes, [Description("average size")]averageSize, [Description("big as chestnuts")]bigchestnuts, [Description("big as apples")]bigapples,[Description("big as grapefruits")]bigGrapefruits, [Description("big as melons")]bigMelons, [Description("big as watermelons")]bigWatermelon, Count};

	public void setTesticlesName(){
		if (GameControl.testiclesSize > 30) {
			GameControl.mcTesticlesName = GameControl.MCTesticleName.bigWatermelon;
		} else if (GameControl.testiclesSize > 21) {
			GameControl.mcTesticlesName = GameControl.MCTesticleName.bigMelons;
		} else if (GameControl.testiclesSize > 16) {
			GameControl.mcTesticlesName = GameControl.MCTesticleName.bigGrapefruits;
		} else if (GameControl.testiclesSize > 12) {
			GameControl.mcTesticlesName = GameControl.MCTesticleName.bigapples;
		} else if (GameControl.testiclesSize >= 7) {
			GameControl.mcTesticlesName = GameControl.MCTesticleName.bigchestnuts;
		} else if (GameControl.testiclesSize >= 3) {
			GameControl.mcTesticlesName = GameControl.MCTesticleName.averageSize;
		} else if (GameControl.testiclesSize > 0) {
			GameControl.mcTesticlesName = GameControl.MCTesticleName.smallgrapes;
		} else {
			GameControl.mcTesticlesName = GameControl.MCTesticleName.NONE;
		}
		if (GameControl.testiclesSize > 40) {
			GameControl.testiclesSize = 40; 
	
		}


	}



	public void setCharPhysique()
	{
		if (GameControl.physiqueStat > 80) {
			GameControl.mcPhysique = GameControl.MCPhysique.extraChubby; // not defined yet but should go and look at the parser the key word
		} else if (GameControl.physiqueStat > 70) {
			GameControl.mcPhysique = GameControl.MCPhysique.chubby;
		} else if (GameControl.physiqueStat > 60) {
			GameControl.mcPhysique = GameControl.MCPhysique.plump;
		} else if (GameControl.physiqueStat > 50) {
			GameControl.mcPhysique = GameControl.MCPhysique.curvy;
		} else if (GameControl.physiqueStat > 40) {
			GameControl.mcPhysique = GameControl.MCPhysique.average;
		} else if (GameControl.physiqueStat > 30) {
			GameControl.mcPhysique = GameControl.MCPhysique.slim;
		} else if (GameControl.physiqueStat > 20) {
			GameControl.mcPhysique = GameControl.MCPhysique.thin;
		} else if (GameControl.physiqueStat > 10) {
			GameControl.mcPhysique = GameControl.MCPhysique.slender;
		} else 
		{
			GameControl.mcPhysique = GameControl.MCPhysique.skinny;
		}
		if (GameControl.physiqueStat > 90) {
			GameControl.physiqueStat = 90; 
		}

	}



	public void setCharBuild()
	{
		if (GameControl.buildStat >80 ) {
			GameControl.mcBuild = GameControl.MCBuild.hulking;
		}else if (GameControl.buildStat >70){
			GameControl.mcBuild = GameControl.MCBuild.muscular;
		}else if (GameControl.buildStat >60){
			GameControl.mcBuild = GameControl.MCBuild.beefy;
		}else if (GameControl.buildStat >50){
			GameControl.mcBuild = GameControl.MCBuild.athletic;
		}else if (GameControl.buildStat >40){
			GameControl.mcBuild = GameControl.MCBuild.toned;
		}else if (GameControl.buildStat >30){
			GameControl.mcBuild = GameControl.MCBuild.average;
		}else if (GameControl.buildStat >20){
			GameControl.mcBuild = GameControl.MCBuild.weak;
		}else if (GameControl.buildStat >10){
			GameControl.mcBuild = GameControl.MCBuild.feeble;
		}else{
			GameControl.mcBuild = GameControl.MCBuild.puny;
		}

		if (GameControl.buildStat > 90) {
			GameControl.buildStat = 90; 
		}
	}


	//	public enum MCAssName{[Description("non existant")]nonexistant, flat, [Description("very small")]verysmall, small, average, ample/*5*/, full, big, plump, vast, enormous /*10*/, gigantic};


	public void setCharAss(){
		
		 if (GameControl.assSize > 9) 
		{
			GameControl.mcAssName = GameControl.MCAssName.gigantic; 
		} else if (GameControl.assSize > 8) {
			GameControl.mcAssName = GameControl.MCAssName.enormous;
		} else if (GameControl.assSize > 7) {
			GameControl.mcAssName = GameControl.MCAssName.vast;
		} else if (GameControl.assSize > 6) {
			GameControl.mcAssName = GameControl.MCAssName.plump;
		} else if (GameControl.assSize > 5) {
			GameControl.mcAssName = GameControl.MCAssName.full;
		} else if (GameControl.assSize > 4) {
			GameControl.mcAssName = GameControl.MCAssName.ample;
		} else if (GameControl.assSize > 3) {
			GameControl.mcAssName = GameControl.MCAssName.average;
		} else if (GameControl.assSize > 2) {
			GameControl.mcAssName = GameControl.MCAssName.small;
		} else if (GameControl.assSize > 1) {
			GameControl.mcAssName = GameControl.MCAssName.verysmall;
		} else if (GameControl.assSize > 0) {
			GameControl.mcAssName = GameControl.MCAssName.tiny;
		} else {
			GameControl.mcAssName = GameControl.MCAssName.flat;
		}
		if (GameControl.assSize > 120) {
			GameControl.assSize = 120; 
		}
		if (GameControl.assSize < 0) {
			GameControl.assSize = 0; 
		}

	}



	//	public enum MCBreastName{flat, [Description("very small")]verySmall, small, regular, ample, full, big, plump, vast, enormous, gigantic, Count};


	public void setCharBreasts1() {
		// THIS ISNT WORKING IT NEED TO BE CHANGED FOR SIZE CASE, LIKE IF > 69 = GIGANTIC
		int breastsize = (int)GameControl.breast1Size;
		if (breastsize > 68) {
			breastsize = 68;
		}
		GameControl.mcBreast1Cup = (GameControl.MCBreastCup)breastsize;

		if (GameControl.breast1Size > 36) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.gigantic;
		} else if (GameControl.breast1Size > 26) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.enormous;
		} else if (GameControl.breast1Size > 19) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.vast;
		} else if (GameControl.breast1Size > 15) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.plump;
		} else if (GameControl.breast1Size > 11) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.big;
		} else if (GameControl.breast1Size > 8) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.full;
		} else if (GameControl.breast1Size > 6) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.ample;
		} else if (GameControl.breast1Size > 4) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.regular;
		} else if (GameControl.breast1Size > 2) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.small;
		} else if (GameControl.breast1Size > 1) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.verySmall;
		} else {
			GameControl.mcBreast1Name = GameControl.MCBreastName.flat;
		}

		if (GameControl.breast1Size < 0) {
			GameControl.breast1Size = 0; 
		}
		if (GameControl.breast1Size > 69) {
			GameControl.breast1Size = 69; 
		}
	}

	public void setCharBreasts2() {
		int breastsize = (int)GameControl.breast2Size;
		GameControl.mcBreast2Name = (GameControl.MCBreastName)breastsize;
		GameControl.mcBreast2Cup = (GameControl.MCBreastCup)breastsize;


	}





	public void setRace()
	{
		/*
		if (GameControl.mcHead == GameControl.mcArms && GameControl.mcArms == GameControl.mcLegs) 
		{
			GameControl.charRace = GameControl.MCHead;
		}else
		{
			GameControl.charRace = 100; // special "anything" race
		}
		*/


	}
	/*
	public void setBeard()
	{
		if (GameControl.beardLength <= 0) 
		{
			GameControl.beardLengthName = 0; // shaven
		}else if(GameControl.beardLength <= 5) {
			GameControl.beardLengthName = 1;  // short stubble
		}else if(GameControl.beardLength <= 10) {
			GameControl.beardLengthName  = 2;  //medium stubble
		}else if(GameControl.beardLength <= 15) {
			GameControl.beardLengthName  = 3;  // long stubble
		}else if(GameControl.beardLength <= 25) {
			GameControl.beardLengthName = 4;  // full beard
		}else if(GameControl.beardLength <= 40) {
			GameControl.beardLengthName = 5;  // long beard
		}else if(GameControl.beardLength <= 80) {
			GameControl.beardLengthName = 6;  // hip lenght beard 
		}

		if (GameControl.beardLength > 80) {
			//GameControl.beardLength = 80;
		}
		if (GameControl.beardLength < 0) {
			//GameControl.beardLength = 0; 
		}

	}

*/
	public void setHairLength(){
		if (GameControl.hairLength <= 0) {
			GameControl.mcHairLength = GameControl.MCHairLength.bald;
		} else if (GameControl.hairLength > 0 && GameControl.hairLength < 10) {
			GameControl.mcHairLength = GameControl.MCHairLength.shaven;
		} else if (GameControl.hairLength >= 10  && GameControl.hairLength < 20) {
			GameControl.mcHairLength = GameControl.MCHairLength.VeryShort;
		} else if (GameControl.hairLength >= 20  && GameControl.hairLength < 30) {
			GameControl.mcHairLength = GameControl.MCHairLength.sshort;
		}else if (GameControl.hairLength >= 30  && GameControl.hairLength < 40) {
			GameControl.mcHairLength = GameControl.MCHairLength.shoulder;
		}else if (GameControl.hairLength >= 40  && GameControl.hairLength < 50) {
			GameControl.mcHairLength = GameControl.MCHairLength.overshoulder;
		}else if (GameControl.hairLength >= 50  && GameControl.hairLength < 60) {
			GameControl.mcHairLength = GameControl.MCHairLength.midback;
		}else if (GameControl.hairLength >= 60  && GameControl.hairLength < 70) {
			GameControl.mcHairLength = GameControl.MCHairLength.lowerback;
		}else if (GameControl.hairLength >= 70  && GameControl.hairLength < 80) {
			GameControl.mcHairLength = GameControl.MCHairLength.kneelength;
		}else if (GameControl.hairLength >= 80 ) {
			GameControl.mcHairLength = GameControl.MCHairLength.overgrown;
		}

		if (GameControl.hairLength > 90) {
			GameControl.hairLength = 90; 
		}
		if (GameControl.hairLength < 0) {
			GameControl.hairLength = 0; 
		}

	}

	/*
	public void setHairStyle(){
		if (GameControl.hairLength < 10 && GameControl.hairLength > 0 ) {
			GameControl.hairStyle = 0; // 
		} else if (GameControl.hairLength >= 10 && GameControl.hairLength < 40  && GameControl.hairStyle >= 1000) {
			GameControl.hairStyle = 0; // no haircut
		}else if (GameControl.hairLength >= 40 && GameControl.hairLength < 60  && GameControl.hairStyle >= 2000 || GameControl.hairStyle < 1000) {
			GameControl.hairStyle = 0; // no haircut
		}else if (GameControl.hairLength >= 60 && GameControl.hairStyle < 2000) {
			GameControl.hairStyle = 0; // no haircut
		}
	}
*/

	/// <summary>
	/// Sets equipment
	/// </summary>

	public void setWeapon(){
		if (GameControl.charEquipment [0] == 0) {
			GameControl.charEquipment [0] = 10000;
		}
	}
		
	public void setArmour(){
		if (GameControl.charEquipment [1] == 0) {
			GameControl.charEquipment [1] = 20000;
		}
	}

	//weapon, armor, head, face, neck, shoulders, arms, legs, makeup
	public void setHeadEquip(){
		if (GameControl.charEquipment [2] == 0) {
			GameControl.charEquipment [2] = 30000;
		}

	}

	public void setFaceEquip(){
		if (GameControl.charEquipment [3] == 0) {
			GameControl.charEquipment [3] = 40000;
		}

	}

	public void setNeckEquip(){
		if (GameControl.charEquipment [4] == 0) {
			GameControl.charEquipment [4] = 50000;
		}

	}

	public void setShouldersEquip(){
		if (GameControl.charEquipment [5] == 0) {
			GameControl.charEquipment [5] = 60000;
		}

	}

	public void setArmsEquip(){
		if (GameControl.charEquipment [6] == 0) {
			GameControl.charEquipment [6] = 70000;
		}

	}

	public void setLegsEquip(){
		if (GameControl.charEquipment [7] == 0) {
			GameControl.charEquipment [7] = 80000;
		}

	}

	public void setMakeUpEquip(){
		if (GameControl.charEquipment [8] == 0) {
			GameControl.charEquipment [8] = 90000;
		}

	}

	public void setRingEquip(){
		if (GameControl.charEquipment [9] == 0) {
			GameControl.charEquipment [9] = 100000;
		}

	}
	public void setRingAmulet(){
		if (GameControl.charEquipment [10] == 0) {
			GameControl.charEquipment [10] = 110000;
		}

	}	public void setRingTrophy(){
		if (GameControl.charEquipment [11] == 0) {
			GameControl.charEquipment [11] = 120000;
		}

	}






	//////////////////////////////////////////////////

	public void setBodyShape(){
		if ((int)GameControl.mcBreast1Name > (int)GameControl.mcWaistName && (int)GameControl.mcAssName >(int)GameControl.mcWaistName) {
			GameControl.mcBodyShape = GameControl.MCBodyShape.hourglass;
		} else if ((int)GameControl.mcBreast1Name < (int)GameControl.mcWaistName && (int)GameControl.mcAssName > (int)GameControl.mcWaistName) {
			GameControl.mcBodyShape = GameControl.MCBodyShape.pear;
		} else if ((int)GameControl.mcBreast1Name > (int)GameControl.mcWaistName && (int)GameControl.mcAssName < (int)GameControl.mcWaistName) {
			GameControl.mcBodyShape = GameControl.MCBodyShape.invertedTriangle; 
		} else if ((int)GameControl.mcBreast1Name == (int)GameControl.mcWaistName && (int)GameControl.mcAssName == (int)GameControl.mcWaistName) {
			GameControl.mcBodyShape = GameControl.MCBodyShape.rectangle;
		} else if ((int)GameControl.mcBreast1Name < (int)GameControl.mcWaistName&& (int)GameControl.mcAssName == (int)GameControl.mcWaistName) {
			GameControl.mcBodyShape = GameControl.MCBodyShape.apple;
		} else {
			GameControl.mcBodyShape = GameControl.MCBodyShape.normal; 
		}

	}

	public void setHeigth(){
		if (GameControl.heightChar >= 230) {
			GameControl.mcHeightName = GameControl.MCHeightName.Giant;

		} else if (GameControl.heightChar >= 190) {
			GameControl.mcHeightName = GameControl.MCHeightName.VeryTall; 
		}
		else if (GameControl.heightChar <= 140) {
			GameControl.mcHeightName = GameControl.MCHeightName.Petite;
		} else {
			GameControl.mcHeightName = GameControl.MCHeightName.Average;
		}
		// max penis size
		if (GameControl.dick1Size > 80 && GameControl.heightChar > 120 && GameControl.heightChar < 220) {
			GameControl.dick1Size = 90; 
	
		}
		if (GameControl.dick1Size > 120 && GameControl.heightChar >= 220) {
			GameControl.dick1Size = 120; 
		}
		if (GameControl.dick1Size > 60 && GameControl.heightChar <= 120) {
			GameControl.dick1Size = 60; 
		}
		//thick
		if (GameControl.dick1Thick > 20 && GameControl.heightChar > 120 && GameControl.heightChar < 220) {
			GameControl.dick1Thick = 20; 

		}
		if (GameControl.dick1Thick > 30 && GameControl.heightChar >= 220) {
			GameControl.dick1Thick = 30; 
		}
		if (GameControl.dick1Thick > 10 && GameControl.heightChar <= 120) {
			GameControl.dick1Thick = 10; 
		}

	}

	public void setWaist(){
		if (GameControl.waistSize > 10) {
			GameControl.mcWaistName = GameControl.MCWaistName.immense; 
		}
		else if (GameControl.waistSize > 9) {
			GameControl.mcWaistName = GameControl.MCWaistName.enormous;
		}
		else if (GameControl.waistSize > 8) {
			GameControl.mcWaistName = GameControl.MCWaistName.veryWide;
		}
		else if (GameControl.waistSize > 7) {
			GameControl.mcWaistName = GameControl.MCWaistName.huge;
		}
		else if (GameControl.waistSize > 6) {
			GameControl.mcWaistName = GameControl.MCWaistName.big;
		}
		else if (GameControl.waistSize > 5) {
			GameControl.mcWaistName = GameControl.MCWaistName.ample;
		}
		else if (GameControl.waistSize > 4) {
			GameControl.mcWaistName = GameControl.MCWaistName.large;
		}
		else if (GameControl.waistSize > 3) {
			GameControl.mcWaistName = GameControl.MCWaistName.average;
		}
		else if (GameControl.waistSize > 2) {
			GameControl.mcWaistName = GameControl.MCWaistName.small;
		}
		else if (GameControl.waistSize > 1) {
			GameControl.mcWaistName = GameControl.MCWaistName.slim;
		}
		else if (GameControl.waistSize > 0) {
			GameControl.mcWaistName = GameControl.MCWaistName.tiny;
		}	
		else {
			GameControl.mcWaistName = GameControl.MCWaistName.petite;
		
		}
		if (GameControl.waistSize > 90) {
			GameControl.waistSize = 90;
		}
		if (GameControl.waistSize < 0) {
			GameControl.waistSize = 0;
		}
	}

	//	public enum MCWaistName{petite, tiny, slim, small, average, large /*5*/, ample,  big, huge, [Description("very wide")]veryWide, enormous /*10*/, immense};


	//	public enum MCHipsName{petite, tiny, slim, small, average, large /*5*/, ample, big, huge, vast, cowlike /*10*/, gigantic};

	public void setHips(){
		if (GameControl.hipsSize > 10) {
			GameControl.mcHipsName = GameControl.MCHipsName.gigantic;
		}else if (GameControl.hipsSize > 9) {
			GameControl.mcHipsName = GameControl.MCHipsName.cowlike;
		}else if (GameControl.hipsSize > 8) {
			GameControl.mcHipsName = GameControl.MCHipsName.vast;
		}else if (GameControl.hipsSize > 7) {
			GameControl.mcHipsName = GameControl.MCHipsName.huge;
		}else if (GameControl.hipsSize > 6) {
			GameControl.mcHipsName = GameControl.MCHipsName.big;
		} else if (GameControl.hipsSize > 5) {
			GameControl.mcHipsName = GameControl.MCHipsName.ample;
		} else if (GameControl.hipsSize > 4) {
			GameControl.mcHipsName = GameControl.MCHipsName.large;
		} else if (GameControl.hipsSize > 3) {
			GameControl.mcHipsName = GameControl.MCHipsName.average;
		} else if (GameControl.hipsSize > 2) {
			GameControl.mcHipsName = GameControl.MCHipsName.small;
		} else if (GameControl.hipsSize > 1) {
			GameControl.mcHipsName = GameControl.MCHipsName.slim;
		} else if (GameControl.hipsSize > 0) {
			GameControl.mcHipsName = GameControl.MCHipsName.tiny;
		} else {
			GameControl.mcHipsName = GameControl.MCHipsName.petite;
		}

		if (GameControl.hipsSize > 90) {
			GameControl.hipsSize = 90;
		}
		if (GameControl.hipsSize < 0) {
			GameControl.hipsSize = 0;
		}

	}



	public void setCharDick1Name(){
		if (GameControl.dick1Size >= 80) {
			GameControl.mcDick1Name = GameControl.MCDickSize.humongous; 
		} else if (GameControl.dick1Size > 60) {
			GameControl.mcDick1Name = GameControl.MCDickSize.horseLength;
		} else if (GameControl.dick1Size > 45) {
			GameControl.mcDick1Name = GameControl.MCDickSize.armLength;
		} else if (GameControl.dick1Size > 30) {
			GameControl.mcDick1Name = GameControl.MCDickSize.enormous;
		} else if (GameControl.dick1Size >= 25) {
			GameControl.mcDick1Name = GameControl.MCDickSize.veryBig;
		} else if (GameControl.dick1Size > 20) {
			GameControl.mcDick1Name = GameControl.MCDickSize.big;
		} else if (GameControl.dick1Size > 12) {
			GameControl.mcDick1Name = GameControl.MCDickSize.average;
		} else if (GameControl.dick1Size > 8) {
			GameControl.mcDick1Name = GameControl.MCDickSize.small;
		} else
		{
			GameControl.mcDick1Name = GameControl.MCDickSize.tiny;
		}

		if (GameControl.dick1Size > 80 && GameControl.heightChar > 120 && GameControl.heightChar < 220) {
			GameControl.dick1Size = 80; 

		}
		if (GameControl.dick1Size > 120 && GameControl.heightChar >= 220) {
			GameControl.dick1Size = 120; 

		}
		if (GameControl.dick1Size > 60 && GameControl.heightChar <= 120) {
			GameControl.dick1Size = 60; 
	
		}

		//thick
		if (GameControl.dick1Thick > 20 && GameControl.heightChar > 120 && GameControl.heightChar < 220) {
			GameControl.dick1Thick = 20; 

		}
		if (GameControl.dick1Thick > 30 && GameControl.heightChar >= 220) {
			GameControl.dick1Thick = 30; 
		}
		if (GameControl.dick1Thick > 10 && GameControl.heightChar <= 120) {
			GameControl.dick1Thick = 10; 
		}


	}

	//	public enum MCDickSize{NONE, tiny, small, average, big, [Description("very big")]veryBig, enormous, [Description("arm length")]armLength, [Description("horse length")]horseLength, humongous}; 

	public void setCharDick2Name(){
		if (GameControl.dick2Size > 80) {
			GameControl.mcDick2Name = GameControl.MCDickSize.humongous; 
		} else if (GameControl.dick2Size > 60) {
			GameControl.mcDick2Name = GameControl.MCDickSize.horseLength;
		} else if (GameControl.dick2Size > 45) {
			GameControl.mcDick2Name = GameControl.MCDickSize.armLength;
		} else if (GameControl.dick2Size > 30) {
			GameControl.mcDick2Name = GameControl.MCDickSize.enormous;
		} else if (GameControl.dick2Size > 25) {
			GameControl.mcDick2Name = GameControl.MCDickSize.veryBig;
		} else if (GameControl.dick2Size > 20) {
			GameControl.mcDick2Name = GameControl.MCDickSize.big;
		} else if (GameControl.dick2Size > 12) {
			GameControl.mcDick2Name = GameControl.MCDickSize.average;
		} else if (GameControl.dick2Size > 8) {
			GameControl.mcDick2Name = GameControl.MCDickSize.small;
		} else
		{
			GameControl.mcDick2Name = GameControl.MCDickSize.tiny;
		}
		if (GameControl.dick1Size > 80 && GameControl.heightChar > 120 && GameControl.heightChar < 220) {
			GameControl.dick1Size = 80; 
			WorldControl.itemUseText = "Your dick can only be this big at this heigth";
		}
		if (GameControl.dick1Size > 120 && GameControl.heightChar >= 220) {
			GameControl.dick1Size = 120; 
			WorldControl.itemUseText = "Your dick can only be this big at this heigth!";
		}
		if (GameControl.dick1Size > 60 && GameControl.heightChar <= 120) {
			GameControl.dick1Size = 60; 
			WorldControl.itemUseText = "Your dick can only be this big at this heigth!";
		}

	}

	public void setCharFemininity(){
		 
	}
	/*
	public void setStyle() // add this at the function of the armour itself in itemFunction.cs 
	{
		i = 0; 
		GameControl.attStyle= 0;
		while (i < 12) {
			rankNum = GameControl.charEquipment [i];
			rankSettler.rankItem (rankNum);
			i++;
		}

	}*/

	/// <summary>
	/// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	/// </summary>

	public static void setHeigthStatic(){
		if (GameControl.heightChar >= 230) {
			GameControl.mcHeightName = GameControl.MCHeightName.Giant;

		} else if (GameControl.heightChar >= 190) {
			GameControl.mcHeightName = GameControl.MCHeightName.VeryTall; 
		}
		else if (GameControl.heightChar <= 140) {
			GameControl.mcHeightName = GameControl.MCHeightName.Petite;
		} else {
			GameControl.mcHeightName = GameControl.MCHeightName.Average;
		}
		// max penis size
		if (GameControl.dick1Size > 80 && GameControl.heightChar > 120 && GameControl.heightChar < 220) {
			GameControl.dick1Size = 90; 

		}
		if (GameControl.dick1Size > 120 && GameControl.heightChar >= 220) {
			GameControl.dick1Size = 120; 
		}
		if (GameControl.dick1Size > 60 && GameControl.heightChar <= 120) {
			GameControl.dick1Size = 60; 
		}
		//thick
		if (GameControl.dick1Thick > 20 && GameControl.heightChar > 120 && GameControl.heightChar < 220) {
			GameControl.dick1Thick = 20; 

		}
		if (GameControl.dick1Thick > 30 && GameControl.heightChar >= 220) {
			GameControl.dick1Thick = 30; 
		}
		if (GameControl.dick1Thick > 10 && GameControl.heightChar <= 120) {
			GameControl.dick1Thick = 10; 
		}

	}


	public static void setCharBreasts1Static() {
		// THIS ISNT WORKING IT NEED TO BE CHANGED FOR SIZE CASE, LIKE IF > 69 = GIGANTIC
		int breastsize = (int)GameControl.breast1Size;
		if (breastsize > 68) {
			breastsize = 68;
		}
		GameControl.mcBreast1Cup = (GameControl.MCBreastCup)breastsize;

		if (GameControl.breast1Size > 36) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.gigantic;
		} else if (GameControl.breast1Size > 26) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.enormous;
		} else if (GameControl.breast1Size > 19) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.vast;
		} else if (GameControl.breast1Size > 15) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.plump;
		} else if (GameControl.breast1Size > 11) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.big;
		} else if (GameControl.breast1Size > 8) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.full;
		} else if (GameControl.breast1Size > 6) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.ample;
		} else if (GameControl.breast1Size > 4) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.regular;
		} else if (GameControl.breast1Size > 2) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.small;
		} else if (GameControl.breast1Size > 1) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.verySmall;
		} else {
			GameControl.mcBreast1Name = GameControl.MCBreastName.flat;
		}

		if (GameControl.breast1Size < 0) {
			GameControl.breast1Size = 0; 
		}
		if (GameControl.breast1Size > 69) {
			GameControl.breast1Size = 69; 
		}

		setCharGenderStatic ();
	}


	public static void setCharDick1NameStatic(){
		if (GameControl.dick1Size >= 80) {
			GameControl.mcDick1Name = GameControl.MCDickSize.humongous; 
		} else if (GameControl.dick1Size > 60) {
			GameControl.mcDick1Name = GameControl.MCDickSize.horseLength;
		} else if (GameControl.dick1Size > 45) {
			GameControl.mcDick1Name = GameControl.MCDickSize.armLength;
		} else if (GameControl.dick1Size > 30) {
			GameControl.mcDick1Name = GameControl.MCDickSize.enormous;
		} else if (GameControl.dick1Size >= 25) {
			GameControl.mcDick1Name = GameControl.MCDickSize.veryBig;
		} else if (GameControl.dick1Size > 20) {
			GameControl.mcDick1Name = GameControl.MCDickSize.big;
		} else if (GameControl.dick1Size > 12) {
			GameControl.mcDick1Name = GameControl.MCDickSize.average;
		} else if (GameControl.dick1Size > 8) {
			GameControl.mcDick1Name = GameControl.MCDickSize.small;
		} else
		{
			GameControl.mcDick1Name = GameControl.MCDickSize.tiny;
		}

		if (GameControl.dick1Size > 80 && GameControl.heightChar > 120 && GameControl.heightChar < 220) {
			GameControl.dick1Size = 80; 

		}
		if (GameControl.dick1Size > 120 && GameControl.heightChar >= 220) {
			GameControl.dick1Size = 120; 

		}
		if (GameControl.dick1Size > 60 && GameControl.heightChar <= 120) {
			GameControl.dick1Size = 60; 

		}

		//thick
		if (GameControl.dick1Thick > 20 && GameControl.heightChar > 120 && GameControl.heightChar < 220) {
			GameControl.dick1Thick = 20; 

		}
		if (GameControl.dick1Thick > 30 && GameControl.heightChar >= 220) {
			GameControl.dick1Thick = 30; 
		}
		if (GameControl.dick1Thick > 10 && GameControl.heightChar <= 120) {
			GameControl.dick1Thick = 10; 
		}

		setCharGenderStatic ();
	}


	public static void setCharGenderStatic()
	{
		if (GameControl.dickNum > 0 && GameControl.breast1Size < 40 && GameControl.hasVagina == false) {
			GameControl.mcSex = GameControl.MCSex.Man; //man
		} else if (GameControl.dickNum > 0 && GameControl.breast1Size < 40 && GameControl.facialFeaturesStat > 70  && GameControl.hasVagina == false) {
			GameControl.mcSex = GameControl.MCSex.Trap;
		} else if (GameControl.dickNum <= 0 && GameControl.hasVagina == true && GameControl.testiclesSize <= 0) {
			GameControl.mcSex = GameControl.MCSex.Woman; // woman
		} else if (GameControl.dickNum <= 0 && GameControl.hasVagina == false) {
			GameControl.mcSex = GameControl.MCSex.Eunuch; //asexual
		} else if (GameControl.dickNum > 0 && GameControl.breast1Size >= 40 && GameControl.hasVagina == false) {
			GameControl.mcSex = GameControl.MCSex.Dickgirl;  // DickGirl
		} else if (GameControl.dickNum > 0 && GameControl.breast1Size >= 40 && GameControl.hasVagina == true) {
			GameControl.mcSex = GameControl.MCSex.Futanari;  // Futa
		} else if (GameControl.dickNum <= 0 && GameControl.breast1Size <= 40 && GameControl.hasVagina == true ) { 
			GameControl.mcSex = GameControl.MCSex.Cuntboy;  // herm-male
		}
	}

}
