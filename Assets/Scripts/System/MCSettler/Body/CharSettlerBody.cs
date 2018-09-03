using UnityEngine;
using System.Collections;

public class CharSettlerBody {


	public void setTesticlesName(){

		if (GameControl.testiclesSize > 40) {
			GameControl.testiclesSize = 40; 

		} else if (GameControl.testiclesSize < 0) {
			GameControl.testiclesSize = 0;
		}

		if (GameControl.testiclesSize > 27 && GameControl.heightChar >= 180 && GameControl.heightChar < 220) {
			GameControl.testiclesSize = 27; //penis 70

		}
		if (GameControl.testiclesSize > 40 && GameControl.heightChar >= 220) {
			GameControl.testiclesSize = 40;  //dick 100
		}
		if (GameControl.testiclesSize > 22 && GameControl.heightChar >= 140 && GameControl.heightChar < 180) {
			GameControl.testiclesSize = 22; //dick 50

		}
		if (GameControl.testiclesSize > 17 && GameControl.heightChar >= 100 && GameControl.heightChar < 140) {
			GameControl.testiclesSize = 17; // dick 35

		}
		if (GameControl.testiclesSize > 13 && GameControl.heightChar >= 70 && GameControl.heightChar < 100) {
			GameControl.testiclesSize = 13; // dick 30

		}
		if (GameControl.testiclesSize > 8 && GameControl.heightChar >= 50 && GameControl.heightChar < 70) {
			GameControl.testiclesSize = 8; // dick 22

		}
		if (GameControl.testiclesSize > 6 && GameControl.heightChar >= 30 && GameControl.heightChar < 50) {
			GameControl.testiclesSize = 6; // dick 15 

		}
		if (GameControl.testiclesSize > 3.2f && GameControl.heightChar >= 20 && GameControl.heightChar < 30) {
			GameControl.testiclesSize = 3.2f; //dick 8

		}
		if (GameControl.testiclesSize > 2.5f && GameControl.heightChar >= 15 && GameControl.heightChar < 20) {
			GameControl.testiclesSize = 2.5f; // dick 6 

		}


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




	}








	public void setCharPhysique()
	{
		if (GameControl.physiqueStat > 8) {
			GameControl.physiqueStat = 8; 
		} else if (GameControl.physiqueStat < 0) {
			GameControl.physiqueStat = 0;
		}
		int physStat = (int)GameControl.physiqueStat;


		GameControl.mcPhysique = (GameControl.MCPhysique)physStat;



	}



	public void setCharBuild()
	{
		int buildStat = (int)GameControl.buildStat;

		if (buildStat > 8) {
			buildStat = 8;
		} else if (buildStat < 0) {
			buildStat = 0; 
		}

		GameControl.mcBuild = (GameControl.MCBuild)buildStat; 

		if (GameControl.buildStat > 8) {
			GameControl.buildStat = 8; 
		} else if (GameControl.buildStat < 0) {
			GameControl.buildStat = 0;
		}

	}

	//	public enum MCAssName{[Description("non existant")]nonexistant, flat, [Description("very small")]verysmall, small, average, ample/*5*/, full, big, plump, vast, enormous /*10*/, gigantic};



	public void setCharBreasts1() {

		if (GameControl.breast1Size < 0) {
			GameControl.breast1Size = 0; 
		}
		if (GameControl.breast1Size > 69) {
			GameControl.breast1Size = 69; 
		}

		int breastsize = (int)GameControl.breast1Size;

		GameControl.mcBreast1Cup = (GameControl.MCBreastCup)breastsize;

		if (GameControl.breast1Size > 36) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.gigantic;
		} else if (GameControl.breast1Size > 26) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.enormous;
		} else if (GameControl.breast1Size > 20) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.vast;
		} else if (GameControl.breast1Size > 16) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.plump;
		} else if (GameControl.breast1Size > 12) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.big;
		} else if (GameControl.breast1Size > 9) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.full;
		} else if (GameControl.breast1Size > 6) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.ample;
		} else if (GameControl.breast1Size > 5) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.regular;
		} else if (GameControl.breast1Size > 3) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.small;
		} else if (GameControl.breast1Size > 2) {
			GameControl.mcBreast1Name = GameControl.MCBreastName.verySmall;
		} else {
			GameControl.mcBreast1Name = GameControl.MCBreastName.flat;
		}
			
	}




	public void setRace()
	{
		int i = 0;

		while (i < 2) {
			
			if (GameControl.mcSkinType == GameControl.MCSkinType.DEMON && GameControl.mcShoulderBlades == GameControl.MCShoulderBlades.DemonWings && GameControl.mcTailType == GameControl.MCTailType.DEMON && GameControl.mcEyesType == GameControl.MCEyesType.demon) {
				if (GameControl.mcHeadAccesory1 == GameControl.MCHeadAccesory1.DemonicHorns || GameControl.mcHeadAccesory1 == GameControl.MCHeadAccesory1.DemonicHornsSmall || GameControl.mcHeadAccesory1 == GameControl.MCHeadAccesory1.DemonicHornsBig) {
					GameControl.mcRace = GameControl.MCRace.DEMON;
					break;
				}

			}


			if (GameControl.isGoo) {
				//break;
			}

/*		if (GameControl.mcLegs = GameControl.MCLegs.CENTAUR) {
			GameControl.isCentaur;
			break;
		}	*/


			if ((int)GameControl.mcHead == (int)GameControl.mcArms && (int)GameControl.mcArms == (int)GameControl.mcLegs) {
				GameControl.mcRace = (GameControl.MCRace)(int)GameControl.mcHead;
			} else {
			
				GameControl.mcRace = GameControl.MCRace.Hybrid;
			}

			break; 
			i++;
		}


	}



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
		if (GameControl.heightChar > 300) {
			GameControl.heightChar = 300;
		} else if (GameControl.heightChar < 100 /*&& GameControl.mcRace != GameControl.MCRace.Pixie*/) {
			GameControl.heightChar = 100; // add exceptions for race when we add them
		}

		if (GameControl.heightChar >= 230) {
			GameControl.mcHeightName = GameControl.MCHeightName.Giant;

		} else if (GameControl.heightChar >= 190) {
			GameControl.mcHeightName = GameControl.MCHeightName.VeryTall; 
		} else if (GameControl.heightChar >= 178) {
			GameControl.mcHeightName = GameControl.MCHeightName.Tall;
		} else if (GameControl.heightChar >= 163) {
			GameControl.mcHeightName = GameControl.MCHeightName.Average;
		} else if (GameControl.heightChar >= 150) {
			GameControl.mcHeightName = GameControl.MCHeightName.Short;
		} else if (GameControl.heightChar <= 140) {
			GameControl.mcHeightName = GameControl.MCHeightName.VeryShort;
		} else if (GameControl.heightChar >= 100) {
			GameControl.mcHeightName = GameControl.MCHeightName.Petite;
		} else if (GameControl.heightChar >= 50) {
			GameControl.mcHeightName = GameControl.MCHeightName.Tiny;
		} else {
			GameControl.mcHeightName = GameControl.MCHeightName.Minuscule;
		}
	

	}



	public void setCharAss()
	{
		int Stat = (int)GameControl.assSize;

		if (Stat > 11) {
			Stat = 11;
		} else if (Stat < 0) {
			Stat = 0; 
		}

		GameControl.mcAssName = (GameControl.MCAssName)Stat; 

		if (GameControl.assSize > 11) {
			GameControl.assSize = 11; 
		} else if (GameControl.assSize < 0) {
			GameControl.assSize = 0;
		}

	}

	public void setCharWaist()
	{

		int Stat = (int)GameControl.waistSize;

		if (Stat > 11) {
			Stat = 11;
		} else if (Stat < 0) {
			Stat = 0; 
		}

		GameControl.mcWaistName = (GameControl.MCWaistName)Stat; 

		if (GameControl.waistSize > 11) {
			GameControl.waistSize = 11; 
		} else if (GameControl.waistSize < 0) {
			GameControl.waistSize = 0;
		}

	}



	public void setCharHips()
	{

		int Stat = (int)GameControl.hipsSize;

		if (Stat > 11) {
			Stat = 11;
		} else if (Stat < 0) {
			Stat = 0; 
		}

		GameControl.mcHipsName = (GameControl.MCHipsName)Stat; 

		if (GameControl.hipsSize > 11) {
			GameControl.hipsSize = 11; 
		} else if (GameControl.hipsSize < 0) {
			GameControl.hipsSize = 0;
		}

	}




	public void setCharDick1Name(){

		// max penis size
		if (GameControl.dick1Size > 70 && GameControl.heightChar >= 180 && GameControl.heightChar < 220) {
			GameControl.dick1Size = 70; 

		}
		if (GameControl.dick1Size > 100 && GameControl.heightChar >= 220) {
			GameControl.dick1Size = 100; 
		}
		if (GameControl.dick1Size > 50 && GameControl.heightChar >= 140 && GameControl.heightChar < 180) {
			GameControl.dick1Size = 50; 

		}
		if (GameControl.dick1Size > 35 && GameControl.heightChar >= 100 && GameControl.heightChar < 140) {
			GameControl.dick1Size = 35; 

		}
		if (GameControl.dick1Size > 30 && GameControl.heightChar >= 70 && GameControl.heightChar < 100) {
			GameControl.dick1Size = 30; 

		}
		if (GameControl.dick1Size > 22 && GameControl.heightChar >= 50 && GameControl.heightChar < 70) {
			GameControl.dick1Size = 22; 

		}
		if (GameControl.dick1Size > 15 && GameControl.heightChar >= 30 && GameControl.heightChar < 50) {
			GameControl.dick1Size = 15; 

		}
		if (GameControl.dick1Size > 8 && GameControl.heightChar >= 20 && GameControl.heightChar < 30) {
			GameControl.dick1Size = 8; 

		}
		if (GameControl.dick1Size > 6 && GameControl.heightChar >= 15 && GameControl.heightChar < 20) {
			GameControl.dick1Size = 6; 

		}

		//thick
		if (GameControl.dick1Thick > 25 && GameControl.heightChar >= 180 && GameControl.heightChar < 220) {
			GameControl.dick1Thick = 25; //penis 70

		}
		if (GameControl.dick1Thick > 35 && GameControl.heightChar >= 220) {
			GameControl.dick1Thick = 35;  //dick 100
		}
		if (GameControl.dick1Thick > 20 && GameControl.heightChar >= 140 && GameControl.heightChar < 180) {
			GameControl.dick1Thick = 20; //dick 50

		}
		if (GameControl.dick1Thick > 16 && GameControl.heightChar >= 100 && GameControl.heightChar < 140) {
			GameControl.dick1Thick = 16; // dick 35

		}
		if (GameControl.dick1Thick > 12 && GameControl.heightChar >= 70 && GameControl.heightChar < 100) {
			GameControl.dick1Thick = 12; // dick 30

		}
		if (GameControl.dick1Thick > 8 && GameControl.heightChar >= 50 && GameControl.heightChar < 70) {
			GameControl.dick1Thick = 8; // dick 22

		}
		if (GameControl.dick1Thick > 6 && GameControl.heightChar >= 30 && GameControl.heightChar < 50) {
			GameControl.dick1Thick = 6; // dick 15 

		}
		if (GameControl.dick1Thick > 3.2f && GameControl.heightChar >= 20 && GameControl.heightChar < 30) {
			GameControl.dick1Thick = 3.2f; //dick 8

		}
		if (GameControl.dick1Thick > 2.5f && GameControl.heightChar >= 15 && GameControl.heightChar < 20) {
			GameControl.dick1Thick = 2.5f; // dick 6 

		}

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

	



	}


	public void setGenderBehavior(){
		if (GameControl.genderBehaviorStat > 100) {
			GameControl.genderBehaviorStat = 100;
		} else if (GameControl.genderBehaviorStat < 0) {
			GameControl.genderBehaviorStat = 0;
		}

		if (GameControl.genderBehaviorStat >= 80) {
			GameControl.mcGenderBehavior = GameControl.MCGenderBehavior.VeryFeminine;
		} else if (GameControl.genderBehaviorStat >= 60) {
			GameControl.mcGenderBehavior = GameControl.MCGenderBehavior.feminine;
		} else if (GameControl.genderBehaviorStat >= 40) {
			GameControl.mcGenderBehavior = GameControl.MCGenderBehavior.androgynous;
		} else if (GameControl.genderBehaviorStat >= 20) {
			GameControl.mcGenderBehavior = GameControl.MCGenderBehavior.masculine;
		} else {
			GameControl.mcGenderBehavior = GameControl.MCGenderBehavior.VeryMasculine;
		}

	}

	public void setFacialFeatures(){
		if (GameControl.facialFeaturesStat > 100) {
			GameControl.facialFeaturesStat = 100;
		} else if (GameControl.facialFeaturesStat < 0) {
			GameControl.facialFeaturesStat = 0;
		}

		if (GameControl.facialFeaturesStat >= 80) {
			GameControl.mcFacialFeatures = GameControl.MCFacialFeatures.VeryFeminine;
		} else if (GameControl.facialFeaturesStat >= 60) {
			GameControl.mcFacialFeatures = GameControl.MCFacialFeatures.feminine;
		} else if (GameControl.facialFeaturesStat >= 60) {
			GameControl.mcFacialFeatures = GameControl.MCFacialFeatures.androgynous;
		} else if (GameControl.facialFeaturesStat >= 60) {
			GameControl.mcFacialFeatures = GameControl.MCFacialFeatures.masculine;
		} else {
			GameControl.mcFacialFeatures = GameControl.MCFacialFeatures.VeryMasculine;
		}

	}


	public void setBodyFeatures(){
		if (GameControl.bodyFeaturesStat > 100) {
			GameControl.bodyFeaturesStat = 100;
		} else if (GameControl.bodyFeaturesStat < 0) {
			GameControl.bodyFeaturesStat = 0; 
		}

		if (GameControl.bodyFeaturesStat >= 80) {
			GameControl.mcBodyFeatures = GameControl.MCBodyFeatures.VeryFeminine; 
		} else if (GameControl.bodyFeaturesStat >= 60) {
			GameControl.mcBodyFeatures = GameControl.MCBodyFeatures.feminine;
		} else if (GameControl.bodyFeaturesStat >= 40) {
			GameControl.mcBodyFeatures = GameControl.MCBodyFeatures.androgynous;
		} else if (GameControl.bodyFeaturesStat >= 20) {
			GameControl.mcBodyFeatures = GameControl.MCBodyFeatures.masculine;
		} else {
			GameControl.mcBodyFeatures = GameControl.MCBodyFeatures.VeryMasculine;
		}

	}



}
