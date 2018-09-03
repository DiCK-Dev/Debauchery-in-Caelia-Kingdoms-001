using UnityEngine;
using System.Collections;

public class NPCSettlerBody  {

	static int iterator = 0;
	int hashcode = GameControl.playerName.GetHashCode();
	int randNum;
	int count;


	// this define how masculine or not is the body
	public NPCData.BodyFeatures bodyFeaturesC; 
	public float bodyFeaturesStat; 



	public float setBodyFeatStat(NPCData.CharGender charGender){
		if (charGender == NPCData.CharGender.MALE) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (0, 60);
		} else if (charGender == NPCData.CharGender.FEMALE) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (40, 100);
		} else {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 80);
		}

	}

	public NPCData.BodyFeatures setBodyFeatures(float bodystat){
		if (bodystat >= 85) {
			return NPCData.BodyFeatures.VeryFeminine;
		} else if (bodystat >= 65) {
			return NPCData.BodyFeatures.feminine;
		} else if (bodystat >= 35) {
			return NPCData.BodyFeatures.androgynous;
		} else if (bodystat >= 15) {
			return NPCData.BodyFeatures.masculine;
		} else {
			return NPCData.BodyFeatures.VeryMasculine;
		}

	}


	public float heightChar; // in cm

	public float SetHeightChar(NPCData.CharRace charRace){
		iterator += 1;
		switch (charRace) {
		case NPCData.CharRace.goblin:
			return Mathf.Round(Random.Range (70, 120));
		case NPCData.CharRace.Dodo:
			return Mathf.Round(Random.Range (125, 165));
		case NPCData.CharRace.Equine:
			return  Mathf.Round(Random.Range (135, 220));

		default:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Mathf.Round(Random.Range (125, 210));
		}


	}




	public NPCData.HeightName setHeightName(float heigth){
		if (heigth > 230) {
			return NPCData.HeightName.Giant;
		} else if (heigth > 190) {
			return NPCData.HeightName.VeryTall;
		} else if (heigth > 178) {
			return NPCData.HeightName.Tall;
		} else if (heigth > 163) {
			return NPCData.HeightName.Average;
		} else if (heigth > 150) {
			return NPCData.HeightName.Short;
		} else if (heigth > 140) {
			return NPCData.HeightName.VeryShort;
		} else if (heigth >= 100) {
			return NPCData.HeightName.Petite;
		} else if (heigth > 50) {
			return NPCData.HeightName.Tiny;
		} else  {
			return NPCData.HeightName.Minuscule;
		}

	}


	public NPCData.BodyPhysique setBodyPhysique(float bodystat){
		int retvalue = (int)bodystat;

		return (NPCData.BodyPhysique)retvalue;
		

	}



	public float SetBodyPhysStat(){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return Random.Range (0f, 9f);


	}


	public float setBodyBuildStat(){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return Random.Range (0f, 9f);

	} // to change it
	//"skinny", "slender", "thin", "slim", "average", "curvy"/*5*/, "plump", "chubby", "extra chubby"
	public NPCData.BodyBuild setBodyBuild(float bodystat){
		int retvalue = (int)bodystat;

		return (NPCData.BodyBuild)retvalue;
		

	} 


	public int setDickNum(NPCData.CharSex charSex){
		if (charSex == NPCData.CharSex.Woman || charSex == NPCData.CharSex.Eunuch || charSex == NPCData.CharSex.Cuntboy) {
			return 0;
		} else {
			return 1; 
		}
	}

	public float setDickSizeCM (float height, NPCData.CharSex charSex){
		iterator += 1;
		if (charSex == NPCData.CharSex.Woman || charSex == NPCData.CharSex.Cuntboy || charSex == NPCData.CharSex.Eunuch) {
			return 0; 
		}


		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		if (height >= 230) {
			randNum = Random.Range (9, 52);
			if(randNum < 16)
			{
				randNum = 16; 
			}
			return randNum;
		} else if (height >= 200) {
			randNum = Random.Range (6, 40);
			if(randNum < 12)
			{
				randNum = 12; 
			}
			return randNum;
		} else if (height >= 170) {
			randNum = Random.Range (5, 30);
			if(randNum < 10)
			{
				randNum = 10; 
			}
			return randNum;
		} else if (height >= 140) 
		{
			randNum = Random.Range (3, 24);
			if(randNum < 9)
			{
				randNum = 9; 
			}
			return randNum;
		} else if (height >= 110) {
			randNum = Random.Range (0, 18);
			if(randNum < 8)
			{
				randNum = 8; 
			}
			return randNum;
		} else if (height >= 80) {
			randNum = Random.Range (0, 16);
			if(randNum < 7)
			{
				randNum = 7; 
			}
			return randNum;
		} else if (height >= 50) {
			randNum = Random.Range (0, 14);
			if(randNum < 5)
			{
				randNum = 5; 
			}
			return randNum;

		} else if (height >= 25) {
			randNum = Random.Range (0, 10);
			if(randNum < 4)
			{
				randNum = 4; 
			}
			return randNum;

		} else {
			randNum = Random.Range (0, 8); // unlikely to create stuff smaller than 30 cm tho...
			if(randNum < 2)
			{
				randNum = 2; 
			}
			return randNum;
		}


	}

	public NPCData.DickSize setDickSize(float dickSize){
		if (dickSize > 70) {
			return NPCData.DickSize.humongous;

		} else if (dickSize > 50) {
			return NPCData.DickSize.horseLength;

		} else if (dickSize > 40) {
			return NPCData.DickSize.armLength;

		} else if (dickSize > 34) {
			return NPCData.DickSize.enormous;

		} else if (dickSize > 26) {
			return NPCData.DickSize.veryBig;

		} else if (dickSize > 17) {
			return NPCData.DickSize.big;

		} else if (dickSize > 12) {
			return NPCData.DickSize.average;

		} else if (dickSize > 9) {
			return NPCData.DickSize.small;

		} else if (dickSize > 0) {
			return NPCData.DickSize.tiny;

		} else {
			return NPCData.DickSize.NONE;
		}


	}


	public float setTesticleSizeCM(NPCData.CharSex charSex, float height)
	{
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 

		float randNum; 
		if (charSex == NPCData.CharSex.Woman || charSex == NPCData.CharSex.Eunuch || charSex == NPCData.CharSex.Cuntboy) {
			return 0; 
		}


		if (height >= 230) {
			randNum = Random.Range (9, 32);
			if(randNum < 13)
			{
				randNum = 13; 
			}
			return randNum;
		} else if (height >= 200) {
			randNum = Random.Range (8, 26);
			if(randNum < 10)
			{
				randNum = 10; 
			}
			return randNum;
		} else if (height >= 170) {
			randNum = Random.Range (4, 14);
			if(randNum < 7)
			{
				randNum = 7; 
			}
			return randNum;
		} else if (height >= 140) 
		{
			randNum = Random.Range (2, 12);
			if(randNum < 6)
			{
				randNum = 6; 
			}
			return randNum;
		} else if (height >= 110) {
			randNum = Random.Range (3, 10);
			if(randNum < 5)
			{
				randNum = 5; 
			}
			return randNum;
		} else if (height >= 80) {
			randNum = Random.Range (2, 8);
			if(randNum < 4)
			{
				randNum = 4; 
			}
			return randNum;
		} else if (height >= 50) {
			randNum = Random.Range (2, 8);
			if(randNum < 4)
			{
				randNum = 4; 
			}
			return randNum;

		} else if (height >= 25) {
			randNum = Random.Range (0, 6);
			if(randNum < 2.5f)
			{
				randNum = 2.5f; 
			}
			return randNum;

		} else {
			randNum = Random.Range (0, 4); // unlikely to create stuff smaller than 30 cm tho...
			if(randNum < 1)
			{
				randNum = 1; 
			}
			return randNum;
		}

	


	}


	//e{NONE, [Description("small like grapes")]smallgrapes, [Description("average size")]averageSize, [Description("big as chestnuts")]bigchestnuts, [Description("big as apples")]bigapples,
	//[Description("big as grapefruits")]bigGrapefruits, [Description("big as melons")]bigMelons, [Description("big as watermelons")]bigWatermelon, Count

	public NPCData.TesticleSize setTesticlesSize(float testSize) {
		if (testSize > 40) {
			return  NPCData.TesticleSize.bigWatermelon;
		} else if (testSize > 30) {
			return  NPCData.TesticleSize.bigMelons;

		} else if (testSize > 24) {
			return  NPCData.TesticleSize.bigGrapefruits;

		} else if (testSize > 18) {
			return  NPCData.TesticleSize.bigapples;

		} else if (testSize > 14) {
			return  NPCData.TesticleSize.bigchestnuts;

		} else if (testSize > 8) {
			return  NPCData.TesticleSize.averageSize;

		} else if (testSize > 0) {
			return  NPCData.TesticleSize.smallgrapes;

		} else {
			return  NPCData.TesticleSize.NONE;
		}

	}




	public float setClitorisSize(){
		iterator += 1;
		float randNumf;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return randNumf = Random.Range (1f,2.5f);
	}




	public int setBreastRow(NPCData.CharRace charRace){
		switch (charRace) {
		default:
			return 1; 
		}

	}


	public float setBreast1Size(NPCData.CharSex charSex, NPCData.CharRace charRace)
	{
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 

		float finalsize = 0;
		if (charSex == NPCData.CharSex.Man || charSex == NPCData.CharSex.Maleherm) {
			finalsize = 0f; 
		} else if (charSex == NPCData.CharSex.Trap) {
			finalsize = Random.Range (0f, 2.5f); 
		} else if (charSex == NPCData.CharSex.Cuntboy) {
			finalsize = 0f; 
		}else if (charSex == NPCData.CharSex.Eunuch) {
			finalsize = Random.Range (0, 6f); 
		} else {
			finalsize = Random.Range (3f, 20f); 
		}

		switch (charRace) {
		case NPCData.CharRace.succubus:
			finalsize += 3f;
			break; 
		case NPCData.CharRace.Dodo:
			finalsize -= 2f;
			break;
		case NPCData.CharRace.Equine:
			finalsize -= 1f;
			break; 
		default:
			break;
		}


		if (finalsize < 0) {
			finalsize = 0; 
		}


		return finalsize;
	}




	public float setBreast2Size(int breastRow){
		float finalsize = 0;
	

		return finalsize;
	}


	//public enum BreastName{flat, [Description("very small")]verySmall, small, regular, ample, full, big, plump, vast, enormous, gigantic, Count};
	//public enum BreastCup{AA /*0*/, A, B, BB, C, CC /*5*/, D, DD, E, EE, F/*10*/, FF, G, GG, H 15, HH, HHH, I, II, III, J /*20*/, JJ, JJJ, K, KK, 25 L, LL, LLL, M, MM, MMM/*30*/, N, NN, NNN, O, OO, OOO, P, PP, PPP, Q/*40*/, QQ, QQQ, R, RR, RRR, S, SS, SSS, T, TT/*50*/, TTT, U, UU, UUU, V, VV, VVV, W, WW, WWW/*60*/, X, XX, XXX, Y, YY, YYY, Z, ZZ, ZZZ/*69*/};



	public NPCData.BreastName setBreastName(float breastSize)
	{
		if (breastSize < 0) {
			breastSize = 0;
		}


		if (breastSize >= 0 && breastSize < 2) {
			return NPCData.BreastName.flat;
		}else if (breastSize >= 2 && breastSize < 4) {
			return NPCData.BreastName.verySmall;
		}else if (breastSize >= 4 && breastSize < 6) {
			return NPCData.BreastName.small;
		}else if (breastSize >= 6 && breastSize < 8) {
			return NPCData.BreastName.regular;
		}else if (breastSize >= 8 && breastSize < 10) {
			return NPCData.BreastName.ample;
		}else if (breastSize >= 10 && breastSize < 12) {
			return NPCData.BreastName.full;
		}else if (breastSize >= 12 && breastSize < 15) {
			return NPCData.BreastName.big;
		}else if (breastSize >= 15 && breastSize < 18) {
			return	NPCData.BreastName.plump;
		}else if (breastSize >= 18 && breastSize < 24) {
			return NPCData.BreastName.vast;
		}else if (breastSize >= 25 && breastSize < 30) {
			return NPCData.BreastName.enormous;
		}else  {
			return NPCData.BreastName.gigantic;
		}

	}


	public NPCData.BreastCup setBreastCup(float breastSize){
		int size;
		size = Mathf.RoundToInt (breastSize);
		if (size > 69) {
			size = 69;
		}
		if (size < 0) {
			size = 0;
		}
		return (NPCData.BreastCup)size; 
	}




	public float setAureoleSize(){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return Random.Range (2f,5f);
	}




	public float waistSize(){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return Random.Range (0f, 11f);

	}


	public NPCData.WaistName setWaistName(float size){
		size = Mathf.Round (size);
		int sizefinal = (int)size;
		return(NPCData.WaistName)sizefinal;

	}


	public float setHipsSize(float waist){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 

		float returnNum = Random.Range (0f, 11f);

		if (returnNum < waist) {
			returnNum = waist; 
		}

		return returnNum;

	}


	public NPCData.HipsName setHipsName(float hips){
		hips = Mathf.Round (hips);
		int sizefinal = (int)hips;
		return(NPCData.HipsName)sizefinal;

	}




	public float setAssSize(float hips){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 

		float returnNum = Random.Range (0f, 11f);

		if (returnNum < hips) {
			returnNum = hips; 
		}

		return returnNum;
	}


	public NPCData.AssName setAssName(float assSize){
		assSize = Mathf.Round (assSize);
		int sizefinal = (int)assSize;
		return(NPCData.AssName)sizefinal;

	}




}
