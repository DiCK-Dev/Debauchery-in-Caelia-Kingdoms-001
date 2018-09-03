using UnityEngine;
using System.Collections;

public class NPCSettlerHead {
	
	static int iterator = 0;
	int hashcode = GameControl.playerName.GetHashCode();
	int randNum;
	int count; 





	public NPCData.BeardStyle setBeardStyle(NPCData.CharSex charSex, NPCData.CharRace charRace){
		iterator += 1;
		// the race is only used for special races, maybe like dwarfs, none yet tho. Should use if

		if (charSex == NPCData.CharSex.Man) {
			count = (int)NPCData.BeardStyle.Count -1;
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return (NPCData.BeardStyle)Random.Range (0, count);
		} else {
			return NPCData.BeardStyle.NONE;
		}
	}


	public NPCData.BeardLength setBeardLength(NPCData.CharSex charSex, NPCData.CharRace charRace){
		iterator += 1;
		// the race is only used for special races, maybe like dwarfs, none yet tho. Should use if

		switch (charSex) {
		case NPCData.CharSex.Man:
			count = (int)NPCData.BeardLength.Count -1;
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return (NPCData.BeardLength)Random.Range (0, count);
		default:
			return NPCData.BeardLength.NONE;
		}


	}

	public NPCData.HairColor setHairColor(){
		iterator += 1;
		count = (int)NPCData.HairColor.Count -1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return (NPCData.HairColor)Random.Range (0, count);
	}

	public NPCData.HairStyle setHairStyle(){
		iterator += 1;
		count = (int)NPCData.HairStyle.Count -1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return (NPCData.HairStyle)Random.Range (0, count);

	}

	public NPCData.HairType setHairType(NPCData.CharRace charRace){
		switch (charRace) {
		case NPCData.CharRace.Lion:
			return NPCData.HairType.Mane;
		case NPCData.CharRace.GooGirl:
			return NPCData.HairType.GooHair;
		default:
			return NPCData.HairType.Normal;
		}



	}


	public float setHairLengthCM(){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		randNum = Random.Range (-20, 150);
		if(randNum < 0){
			randNum = 0; 
		}
		return randNum;


	}


	//{bald, shaven, [Description("very short")]VeryShort, [Description("short")]sshort, [Description("shoulder length")]shoulder, [Description("over the shoulder")]overshoulder, 
	//[Description("mid back length")]midback, [Description("knee length")]kneelength, [Description("feet length")]feetLength, overgrown,

	public NPCData.HairLength setHairLength(float hairLength){
		if (hairLength > 200) {
			return NPCData.HairLength.overgrown;
		} else if (hairLength > 170) {
			return NPCData.HairLength.feetLength;
		} else if (hairLength > 130) {
			return NPCData.HairLength.kneelength;
		} else if (hairLength > 100) {
			return NPCData.HairLength.midback;
		} else if (hairLength > 50) {
			return NPCData.HairLength.overshoulder;
		} else if (hairLength > 30) {
			return NPCData.HairLength.shoulder;
		} else if (hairLength > 15){
			return NPCData.HairLength.sshort;
		} else if (hairLength > 5){
			return NPCData.HairLength.VeryShort;
		} else if (hairLength > 0){
			return NPCData.HairLength.shaven;
		} else {
			return NPCData.HairLength.bald;
		}


	}


	public NPCData.EyesColor setEyesColor(NPCData.CharRace charRace){
		iterator += 1;
		count = (int)NPCData.EyesColor.Count -1;
		switch (charRace) {

		default:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return (NPCData.EyesColor)Random.Range (0, count);
		}

	}



	public float setFacialFeatStat(NPCData.CharGender charGender){
		iterator += 1;
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

	public NPCData.FacialFeatures setFacialFeat(float facialstat){
		if (facialstat >= 85) {
			return NPCData.FacialFeatures.VeryFeminine;
		} else if (facialstat  >= 65) {
			return NPCData.FacialFeatures.feminine;
		} else if (facialstat  >= 35) {
			return NPCData.FacialFeatures.androgynous;
		} else if (facialstat  >= 15) {
			return NPCData.FacialFeatures.masculine;
		} else{
			return NPCData.FacialFeatures.VeryMasculine;
		}

	}











}
