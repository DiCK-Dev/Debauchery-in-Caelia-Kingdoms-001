using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

public class Parser : MonoBehaviour {

	/*  example of how to use the toDescription to change an enum description to a string
	void testing(){
	
		string charname = CityPosition.GRANDINQUISITOR.toDescription ();
	}

*/

	static Parser instance; 
	int i; 
	string rankName; 


	//0 human, 1 wolf, 2 bunny, 3 feline

	public string[] faceType0 = new string[] {"normal human face", "human face that has wolf features, as the ears and small fangs", "human face that has bunny features, like fluffy ears", "human face that has feline features, like its ears and whiskers", "human face that has dark green veins and small vines that decore it", "human face but with equine ears", "human face but it has small feathers that sprout and decore it", "human face but part of the neck and cheeks seem to have escales", "human face that has feline features, like its ears and whiskers", "human face but with fox ears", "human face but with chinchilla ears"};
	public string[] faceType1 = new string[] {"normal human face", "wolf face with muzzle ", "bunny face with snout", "feline face with muzzle", "human face that has dark green veins and small vines that decore it", "equine face with muzzle ", "avian face with a beak", "Lizard face with muzzle", "feline face with muzzle", "fox face with muzzle", "chinchilla face with snout"}; //0 human, 1 wolf, 2 bunny, 3 feline, 4 plant, 5 equine, 6 avian, 7 lizard, 8 lion, 9 fox, 10
	public string[] armsType0 = new string[] {"human arms, hands and fingers", "human arms with wolf claws ", "human arms with fluffy bunny hands", "human arms with feline claws", "human hands with a couple of small vines", "human arms with its hands covered in equine fur", "human arms decorated with feathers", "human arms that have scales in its shoulders", "human arms with feline claws", "human arms with fox claws"};
	public string[] armsType1 = new string[] {"human arms", "wolf hands", "bunny paws", "feline hands", "Human hands with dark veins and vines", "hands and arms covered in thick equine hair", "wings underneath your arms that are covered in feathers", "lizard hands and covered with scales", "feline hands", "fox hands", "mouselike hands"};
	public string[] legsType0 = new string[] {"normal legs", "human legs that below the knee transforms into wolf paws", "human legs that below the knee they transform into cute bunny feets", "human legs that below the knee they start to transform into feline paws", "human legs that have dark green veins and small vines", "human legs that below the knee they transform into equine hooves", "human legs that below the knee they transform into avian claws", "human legs with scales that below the knee they transform into lizard claws", "human legs that below the knee they start to transform into feline paws", "human legs that below the knee they transform into fox claws", "human legs that below the knee they transfor into mouselike paws"};
	public string[] legsType1 = new string[] {"human legs", "wolfish legs", "bunny-like legs", "feline-like legs", "human legs that have dark green veins and vines", "equine hooves", "avian legs with claws", "felinelike legs", "foxlike legs", "mouselike legs" };
	public string[] skinType = new string[] {"skin", "scales", "demon skin", "orc skin", "shark skin", "whale skin", "dolphin skin", "porcelain skin", "eldritch skin" };
	public string[] skinColor = new string[] {"pale", "white", "brown", "black", "light green", "purple", "blue", "dark blue", "dark green", "gray", "porcelain", "black with red", "black and white"};
	public string[] furColor = new string[] {"gray", "snow white", "white", "brown", "black", "pink"/*5*/, "blue", "dark chocolate", "dark gray with white", "yellow ocher", "dark red", /*10*/ "purple"};
	public string[] charRace = new string[] {"human", "wolf", "bunny", "feline", "plant", "equine", "avian", "lizard", "lion", "fox", "rodent"};
	public string[] charGender = new string[] {"asexual", "female", "male", "dickgirl", "futa", "cuntboy"};
	public string[] charBeard = new string[] {"no beard", "a short stubble", "a medium stubble", "a long stubble", "full beard", "long beard", "hip length beard" , "no beard", "no beard", "no beard" };
	public string[] charBeardStyle = new string[] {"no", "goatee", "ducktail", "van dyke", "chin curtain" };
	public string[] charPhysique = new string[] {"skinny", "slender", "thin", "slim", "average", "curvy"/*5*/, "plump", "chubby", "extra chubby"};
	public string[] charBuild = new string[] {"puny", "feeble", "weak", "average", "toned", "athletic"/*5*/, "beefy", "muscular", "hulking" };
	public string[] charHairColor = new string[] {"black", "red", "blonde", "brown", "auburn", "white"/*5*/, "gray", "chesnut", "yellow ochre", "blue", "pink"/*10*/, "green", "sky blue", "purple", "platinum"};
	public string[] charHairLength = new string[] {"bald", "shaven", "very short", "short", "shoulder", "above the shoulder", "mid-back", "lower back", "Knee length", "Feet length", "overgrown"};
	public string[] charHairStyle = new string[] {"no", "pixie", "sassy", "bob", "mowhawk", "comb over", "curly bob", "pompadour", "braids", "twist and bun", "elegant bun", "manly bun", "long ponytails", "long curls"};
	public string[] charHairType = new string[] {"normal", "serpent", "mane"};
	public string[] charEyesColor = new string[] {"dark brown", "black", "blue", "green", "hazel", "gray"/*5*/, "purple", "yellow", "red", "pink", "pink with yellow star pupils"/*10*/, "yellow slitted cat"/*P*/ };
	public string[] charEyesType = new string[] {"normal", "lizard", "Demonic", };
	public string[] dickType = new string[] {"human", "wolf", "bunny", "feline","plant",  "equine" , "avian", "lizard", "lion", "fox"};
	public string[] dickName = new string[] {"Tiny", "Small", "average", "big", "very big", "enormous", "arm length", "horse length", "humongous" };
	public string[] testiclesName = new string[] {"small like grapes ", "average size", "big as chestnuts", "big as apples", "big as grapefruits", "big as melons", "big as watermelons"};
	public string[] vagLooseness = new string[] {"virgin", "very thight", "thight", "loose", "very loose"};
	public string[] shoulderAccesory = new string[] {"", "angel wings", "demon wings", "dragon wings", "bird wings", "mosquito wings", "pixie wings", "gargoyle wings"};
	public string[] waistName = new string[] {"petite", "tiny", "slim", "average", "large", "big"/*5*/, "huge", "very wide", "enormous"}; //0-8
	public string[] hipsName = new string[] {"petite", "tiny", "slim", "average", "large", "big"/*5*/, "huge", "cowlike", "gigantic"}; // 0-8
	public string[] assName = new string[]{"non existant", "flat", "very small", "small", "regular", "ample"/*5*/, "full", "big", "plump", "vast", "enormous", "gigantic"}; //0-11
	public string[] breastName = new string[] { "flat", "very small", "small", "regular", "ample", "full"/*5*/, "big", "plump", "vast", "enormous", "gigantic"};  // 0 - 10
	public string[] breastCup = new string[] {"AA" /*0*/, "A", "B", "BB", "C", "CC" /*5*/, "D", "DD", "E", "EE", "F"/*10*/, "FF", "G", "GG", "H", "HH", "HHH", "I", "II", "III", "J" /*20*/, "JJ", "JJJ", "K", "KK", "L", "LL", "LLL", "M", "MM", "MMM"/*30*/, "N", "NN", "NNN", "O", "OO", "OOO", "P", "PP", "PPP", "Q"/*40*/, "QQ", "QQQ", "R", "RR", "RRR", "S", "SS", "SSS", "T", "TT"/*50*/, "TTT", "U", "UU", "UUU", "V", "VV", "VVV", "W", "WW", "WWW"/*60*/, "X", "XX", "XXX", "Y", "YY", "YYY", "Z", "ZZ", "ZZZ"/*69*/};  
	public string[] tailType = new string[]{"", "wolf", "bunny", "feline","plant", "equine"/*5*/, "avian", "lizard", "lion", "fox", "rodent"};



	//0 human, 1 wolf, 2 bunny, 3 feline, 4 plant, 5 equine, 6 avian, 7 lizard, 8 lion, 9 fox, 10 roedor


	//head transformation accesories
	public string[] headAccesory1 = new string[] {"", "demonic horns", "antlers", "minotaur horns", "colorful flowers"};
	public string[] headAccesory2 = new string[] {"", "SpiderEyes?", " "};
	//public string[] neckAccesory = new string[] {"", "Scarf", "Slave Collar"}; - outdated, used as equipment
	// feminity




	// specials
	public string[] charSpecialBody = new string[] {"", "Goo", "Phantom", "Snake"};  



	// // // // // // //



	public string callCharFace()
	{

		return GameControl.mcHead.toDescription(); 

	}


		//call the arms 
	public string callCharArmsType()
	{

		return GameControl.mcArms.toDescription(); 

	}


	public string callCharLegsType()
	{
		return GameControl.mcLegs.toDescription ();
	}

	public string callCharRace()
	{

		return GameControl.mcRace.toDescription ();
	}

	public string callCharGender()
	{
		return GameControl.mcGender.toDescription ();
	}

	public string callCharBeard()
	{
		return GameControl.mcBeardLength.toDescription();
	}
	public string callCharBeardStyle()
	{
		return GameControl.mcBeardStyle.toDescription();
	}

	public string callCharPhysique()
	{
		return GameControl.mcPhysique.ToString();
	}

	public string callCharBuild()
	{
		return GameControl.mcBuild.toDescription ();
	}

	public string callCharHairColor()
	{
		return  GameControl.mcHairColor.toDescription ();
	}
	public string callCharHairLength()
	{
		return GameControl.mcHairLength.toDescription ();
	}
	public string callCharHairType(){
		return GameControl.mcHairType.toDescription ();
	}
	public string callCharHairStyle(){
		// Bald should be called from the description itself not from here, if (hairlength == 0) hair = bald 
		return  GameControl.mcHairStyle.toDescription();
	}





	public string callCharEyesColor()
	{
		return GameControl.mcEyesColor.toDescription ();
	}
	public string callCharEyesType()
	{
		return GameControl.mcEyesType.toDescription ();
	}

	public string callDickType()
	{
		return GameControl.mcDickType.toDescription (); 
	}

	public string callDickName()
	{
		return GameControl.mcDick1Name.toDescription();
	}
	public string callBreastsName1()
	{
		return GameControl.mcBreast1Name.toDescription ();
	}
	public string callBreastCup1(){
		return GameControl.mcBreast1Cup.toDescription ();
	}

	public string callBreastsName2()
	{
		return GameControl.mcBreast2Name.toDescription ();
	}
	public string callBreastCup2(){
		return  GameControl.mcBreast2Cup.toDescription ();
	}
	public string callSpecialBody()
	{
		return charSpecialBody [GameControl.specialBody];
	}

	public string callFemininity()
	{
		Debug.Log (GameControl.facialFeaturesStat);
		if (GameControl.facialFeaturesStat >= 80) {
			return "Very femenine"; 
		} else if (GameControl.facialFeaturesStat >= 60) {
			return "femenine"; 
		}  else if (GameControl.facialFeaturesStat >= 40) {
			return "androgynous"; 
		} else if (GameControl.facialFeaturesStat >= 20) {
			return "masculine"; 
		} else {
			return "very masculine";
		} 

	}

	public string callHeadAccesory1(){
		return GameControl.mcHeadAccesory1.toDescription ();
	}
	public string callHeadAccesory2(){
		return GameControl.mcHeadAccesory2.toDescription ();
	}



	public string callSkinColor(){
		return GameControl.mcSkinColor.toDescription ();
	}

	public string callSkinType(){
		return GameControl.mcSkinType.toDescription ();
	}

	public string callFurColor(){
		return GameControl.mcFurColor.toDescription ();
	}
	public string callShoulderAccesory(){
		return GameControl.mcShoulderBlades.toDescription(); 	
	}
	public string callWaist(){
		return GameControl.mcWaistName.toDescription();

	}
	public string callHips(){
		return GameControl.mcHipsName.toDescription();
	}

	public string callAss(){
		return GameControl.mcAssName.toDescription();
	}
	public string callTail(){
		return GameControl.mcTailType.toDescription();
	}
	public string callTesticlesName(){
		return 	GameControl.mcTesticlesName.toDescription ();
	}
	public string callVaginaLooseness(){
		return GameControl.mcVagLooseness.toDescription ();
	}





	public string callStyle()
	{// // /// //
		i = 0; 
		while (i < 2)
		{ // // //
			
			if (GameControl.attStyle>= 350) {
				if (GameControl.mcGender == GameControl.MCGender.FEMALE) {
					rankName = "You dress majestously, looking like a true Empress because of your clothing, ";
					break;
				} else {
					rankName = "You dress majestously, looking like a true Emperor because of your clothing, ";
					break; 
				}
	
			} else if (GameControl.attStyle>= 300) {
				if (GameControl.mcGender == GameControl.MCGender.FEMALE) {
					rankName = "You dress majestously, looking like a true Queen because of your clothing, "; 
					break; 
				} else {
					rankName = "You dress majestously, looking like a true King because of your clothing, "; 
					break; 
				}


			} else if (GameControl.attStyle>= 250) {
				if (GameControl.mcGender == GameControl.MCGender.FEMALE) {
					rankName = "You dress majestously, like an Archduchess because of your clothing, "; 
					break; 
				} else {
					rankName = "You dress majestously, like an Archduke because of your clothing, "; 
					break; 
				}


			} else if (GameControl.attStyle>= 200) {
				if (GameControl.mcGender == GameControl.MCGender.FEMALE) {
					rankName = "You dress impeccable, like a Duchess because of your clothing, "; 
					break; 
				} else {
					rankName = "You dress impeccable, like a Duke because of your clothing, "; 
					break; 
				}


			} else if (GameControl.attStyle>= 150) {
				if (GameControl.mcGender == GameControl.MCGender.FEMALE) {
					rankName = "You dress impeccable, like a princess because of your clothing, "; 
					break; 
				} else {
					rankName = "You dress impeccable, like a prince because of your clothing, "; 
					break; 
				}


			} else if (GameControl.attStyle>= 100) {
				if (GameControl.mcGender == GameControl.MCGender.FEMALE) {
					rankName = "You dress gracefully, like a Countess because of your clothing, "; 
					break; 
				} else {
					rankName = "You dress gracefully, like a Count because of your clothing, "; 
					break; 
				}


			} else if (GameControl.attStyle>= 50) {
				if (GameControl.mcGender == GameControl.MCGender.FEMALE) {
					rankName = "You dress gracefully, like a Baroness because of your clothing, "; 
					break; 
				} else {
					rankName = "You dress gracefully, like a Baron because of your clothing, "; 
					break; 
				}


			} else if (GameControl.attStyle>= 30) {
				if (GameControl.mcGender == GameControl.MCGender.FEMALE) {
					rankName = "You dress imponent, like a Knightess because of your clothing, "; 
					break; 
				} else {
					rankName = "You dress imponent, like a Knight because of your clothing, "; 
					break; 
				}


			} else if (GameControl.attStyle>= 20) {
				if (GameControl.mcGender == GameControl.MCGender.FEMALE) {
					rankName = "You dress elegant, like a Patrician because of your clothing, "; 
					break; 
				} else {
					rankName = "You dress elegant, like a Patrician because of your clothing, "; 
					break; 
				}


			} else if (GameControl.attStyle>= 15) {
				if (GameControl.mcGender == GameControl.MCGender.FEMALE) {
					rankName = "People treat you like a squiress because of your clothing, "; 
					break; 
				} else {
					rankName = "People treat you like a squire because of your clothing, "; 
					break; 
				}


			} else if (GameControl.attStyle>= 10) {
				if (GameControl.mcGender == GameControl.MCGender.FEMALE) {
					rankName = "People treat you like a citizen because of your clothing, "; 
					break; 
				} else {
					rankName = "People treat you like a citizen because of your clothing, "; 
					break; 
				}


			} else if (GameControl.attStyle>= 5) {
				if (GameControl.mcGender == GameControl.MCGender.FEMALE) {
					rankName = "People treat you like a Yeowoman because of your clothing, "; 
					break; 
				} else {
					rankName = "People treat you like a Yeoman because of your clothing, "; 
					break; 
				}


			} else if (GameControl.attStyle>= 0) {
				if (GameControl.mcGender == GameControl.MCGender.FEMALE) {
					rankName = "People treat you like a commoner because of your clothing, "; 
					break; 
				} else {
					rankName = "People treat you like a commoner because of your clothing, "; 
					break; 
				}


			} else if (GameControl.attStyle>= -10) {
				if (GameControl.mcGender == GameControl.MCGender.FEMALE) {
					rankName = "People treat you like a serf because of your clothing, "; 
					break; 
				} else {
					rankName = "People treat you like a serf because of your clothing, "; 
					break; 
				}


			} else if (GameControl.attStyle>= -100) {
				rankName = "People look at you as a criminal or scum because of your clothing, "; 
				break; 

			} else {
				return "People treat you like a homeless because of your clothing, "; 


			}



		}// // //

		return rankName; 

	}// // // // 











	void Awake () 
	{
		if (instance != null) 
		{
			Destroy (this.gameObject);
			return; 
		}
		else 
		{
			instance = this; 
			GameObject.DontDestroyOnLoad (this.gameObject);
		}
	}







}
