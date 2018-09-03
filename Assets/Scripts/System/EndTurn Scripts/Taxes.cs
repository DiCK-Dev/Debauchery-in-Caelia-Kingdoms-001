using UnityEngine;
using System.Collections;

public class Taxes : MonoBehaviour {



	static public void dailyTax(){
		
		float sum = 0;

		if (LawController.IsEnacted<LawTaxesVeryLow>()) {
			GameControl.charGold += (int)(CityControl.city100Prosperity * 2);
			Debug.Log("Taxes are very low");
		}

		if (LawController.IsEnacted<LawTaxesLow>()) {
			GameControl.charGold += (int)(CityControl.city100Prosperity * 4);
			Debug.Log("Taxes are low");
		}

		if (LawController.IsEnacted<LawTaxesNormal>()) {
			GameControl.charGold += (int)(CityControl.city100Prosperity * 8);
			Debug.Log("Taxes are normal");
		}

		if (LawController.IsEnacted<LawTaxesHigh>()) {
			GameControl.charGold += (int)(CityControl.city100Prosperity * 14);
		}

		if (LawController.IsEnacted<LawTaxesVeryHigh>()) {
			GameControl.charGold += (int)(CityControl.city100Prosperity * 20);
		}

		/*
		if(CityControl.city100Taxes == 0){
			sum = CityControl.city100Prosperity + CityControl.city100ProsperityBonus; 
			sum = sum * 3; 

		}

		if(CityControl.city100Taxes == 1){
			sum = CityControl.city100Prosperity + CityControl.city100ProsperityBonus; 
			sum = sum * 2; 

			CityControl.city100Happiness += 0.2f;
			CityControl.city100Order += 0.1f;
		}

		if(CityControl.city100Taxes == 2){
			sum = CityControl.city100Prosperity + CityControl.city100ProsperityBonus; 
			sum = sum * 4;

			CityControl.city100Happiness -= 0.2f;
			CityControl.city100Order -= 0.1f;
		}

		if(CityControl.city100Taxes == 3){
			sum = CityControl.city100Prosperity + CityControl.city100ProsperityBonus; 
			sum = sum * 5; 
			CityControl.city100Happiness -= 0.4f;
			CityControl.city100Order -= 0.2f;
		}*/



		//calcf = CityControl.city100MinistersEfficiency [0] / 1000;


		GameControl.charGold += (int)sum; 



	}


}
