using UnityEngine;
using System.Collections;

public class CharSettlerSex {


	public void setCharSex()
	{
		
		if (GameControl.dickNum > 0 && GameControl.breast1Size < 4 &&  GameControl.hasVagina == false && GameControl.mcGender == GameControl.MCGender.MALE || GameControl.dickNum > 0 && GameControl.breast1Size < 4 &&  GameControl.hasVagina == false && GameControl.mcGender == GameControl.MCGender.ANDROGYNOUS) {
			GameControl.mcSex = GameControl.MCSex.Man; //man
		} else if (GameControl.dickNum > 0 && GameControl.breast1Size < 4 && GameControl.mcGender == GameControl.MCGender.FEMALE && GameControl.hasVagina == false) {
			GameControl.mcSex = GameControl.MCSex.Trap;
		} else if (GameControl.dickNum <= 0 && GameControl.hasVagina == true  && GameControl.mcGender == GameControl.MCGender.FEMALE  || GameControl.dickNum <= 0 && GameControl.hasVagina == true  && GameControl.mcGender == GameControl.MCGender.ANDROGYNOUS ) {
			GameControl.mcSex = GameControl.MCSex.Woman; // woman
		} else if (GameControl.dickNum <= 0 && GameControl.hasVagina == false) {
			GameControl.mcSex = GameControl.MCSex.Eunuch; //eunuch
		} else if (GameControl.dickNum > 0 && GameControl.breast1Size >= 4 && GameControl.hasVagina == false) {
			GameControl.mcSex = GameControl.MCSex.Dickgirl;  // DickGirl
		} else if (GameControl.dickNum > 0 && GameControl.breast1Size >= 4 && GameControl.hasVagina == true) {
			GameControl.mcSex = GameControl.MCSex.Futanari;  // Futa
		} else if (GameControl.dickNum <= 0 && GameControl.breast1Size < 4 && GameControl.hasVagina == true  && GameControl.mcGender == GameControl.MCGender.MALE) { 
			GameControl.mcSex = GameControl.MCSex.Cuntboy;  // 
		} else if (GameControl.dickNum <= 0 && GameControl.breast1Size < 4 && GameControl.hasVagina == true  && GameControl.mcGender == GameControl.MCGender.FEMALE && GameControl.mcGender == GameControl.MCGender.ANDROGYNOUS ) { 
			GameControl.mcSex = GameControl.MCSex.Woman;  // 
		} else if (GameControl.dickNum > 0 && GameControl.breast1Size < 4 && GameControl.hasVagina == true){
			GameControl.mcSex = GameControl.MCSex.Maleherm;
		}else {
			//GameControl.mcSex = GameControl.MCSex.Woman;
			Debug.Log ("setCharSex didnt found an actual sex");
		}
	}


	public void setCharGender(){
		float sum; 

		float genitaliaSum = GameControl.dick1Size + GameControl.testiclesSize +1;
		genitaliaSum = genitaliaSum / 2.5f; 
		genitaliaSum = GameControl.breast1Size - genitaliaSum; 

		float featuresSum = GameControl.genderBehaviorStat + GameControl.facialFeaturesStat + GameControl.bodyFeaturesStat +1;
		featuresSum = featuresSum / 3;

		sum = featuresSum + genitaliaSum;

		if (sum > 50) {
			GameControl.mcGender = GameControl.MCGender.FEMALE;
		} else {
			GameControl.mcGender = GameControl.MCGender.MALE; 
		}





	}





}
