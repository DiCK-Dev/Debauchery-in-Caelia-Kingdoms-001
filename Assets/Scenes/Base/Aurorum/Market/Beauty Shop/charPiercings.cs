using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class charPiercings : MonoBehaviour {


	public static string piercingDescription; 
	public static string piercingLocationName; // to create the text
	static string piercingMaterial;
	static string piercingModel; 
	static int piercingNumber; // for the array



	public RectTransform panPiercingMaterialQuestion; 
	public RectTransform panPiercingModelQuestion; 
	public RectTransform panPiercingNumbers; 
	public RectTransform panInitialQuestion;  // first panel
	public RectTransform panBuyQuestion; //Final panel
	public RectTransform panBack; 



	static string piercingQuantityUse; 
	public Text Board; 



	bool multiplePiercings; 
	int piercingMaxCounter; 
	public Button buttPiercingNum2; 
	public Button buttPiercingNum3; 
	public Button buttPiercingNum4; 
	public Button buttPiercingNum5; 
	public Button buttPiercingNum6; 

	public Button buttPenisTrue;
	public Button buttVaginaTrue;

	public Button buttCowRing;
	bool cowRing; 

	int priceNumber = 1;  // defined in number, if only 1 the price is 1 
	int priceMaterial; // defined in material...
	int priceTotal; 

	//0 Earl 
	//1 Left eyebrow
	//2 Right eyebrow
	//3 Left nostril
	//4 Right nostril
	//5 Septum Piercing
	//6 Left ear lobe 
	//7 right ear lobe
	//8 Lef ear helix
	//9 right ear helix 
	//10 left lip 
	//11 Right lip
	//12 Labret piercing 
	//13 Tongue piercing
	//14 upper lip frenum piercing
	//15 lower lip frenum piercing 
	//16 left nipple piercing
	//17 right nipple piercing 
	//18 Navel piercing 
	//19 Dick piercing
	//20 clitoris piercing
	//


	public void askPiercings(){
		Board.text = "Are you sure you ain't afraid of pain hon? Very well, what'll be? Where you want to be pierced?";
		panInitialQuestion.SetAsLastSibling ();

	}

	public void setPiercing(){
		GameControl.charGold -= priceTotal; 
		piercingDescription = "\nYou have " + piercingQuantityUse  + " " + piercingMaterial + " " + piercingModel + " in your " + piercingLocationName ;
		GameControl.piercings [piercingNumber] = piercingDescription;
		multiplePiercings = false; 
		Board.text = "She rapidly works on you, getting you ready in no time! You now have " + piercingQuantityUse  + " " + piercingMaterial + " " + piercingModel + " in your " + piercingLocationName; 
		panBack.SetAsLastSibling ();
		if (cowRing == true) 
		{
			cowRing = false; 
			buttCowRing.enabled = !buttCowRing.enabled;

		}


		if (piercingMaxCounter == 6) {
			buttPiercingNum2.enabled = !buttPiercingNum2.enabled;
			buttPiercingNum3.enabled = !buttPiercingNum3.enabled;
			buttPiercingNum4.enabled = !buttPiercingNum4.enabled;
			buttPiercingNum5.enabled = !buttPiercingNum5.enabled;
			buttPiercingNum6.enabled = !buttPiercingNum6.enabled;

		}
		if (piercingMaxCounter == 5) {
			buttPiercingNum2.enabled = !buttPiercingNum2.enabled;
			buttPiercingNum3.enabled = !buttPiercingNum3.enabled;
			buttPiercingNum4.enabled = !buttPiercingNum4.enabled;
			buttPiercingNum5.enabled = !buttPiercingNum5.enabled;

		}
		if (piercingMaxCounter == 4) {
			buttPiercingNum2.enabled = !buttPiercingNum2.enabled;
			buttPiercingNum3.enabled = !buttPiercingNum3.enabled;
			buttPiercingNum4.enabled = !buttPiercingNum4.enabled;

		}
		if (piercingMaxCounter == 3) {
			buttPiercingNum2.enabled = !buttPiercingNum2.enabled;
			buttPiercingNum3.enabled = !buttPiercingNum3.enabled;

		}
		if (piercingMaxCounter == 2) {
			buttPiercingNum2.enabled = !buttPiercingNum2.enabled;

		}
		piercingMaxCounter = 0; 




	}




	public void piercingLoc0(){
		piercingNumber = 0; 
		piercingLocationName = "earl";
		priceNumber = 1; 
		multiplePiercings = false; 
		panPiercingMaterialQuestion.SetAsLastSibling ();                
		Board.text = "What material will be? Metal is as cheap as it gets, 5 gold per piece, silver is 10, plain gold is 20 and we have rubies and gold at 40 and lastly precious diamonds at the affordable price of 80 gold per piece, a bargain!"; 

	}


	public void piercingLoc1(){
		piercingNumber = 1; 
		piercingLocationName = "left eyebrow";
		multiplePiercings = true;
		piercingMaxCounter = 3; 
		panPiercingMaterialQuestion.SetAsLastSibling ();                
		Board.text = "What material will be? Metal is as cheap as it gets, 5 gold per piece, silver is 10, plain gold is 20 and we have rubies and gold at 40 and lastly precious diamonds at the affordable price of 80 gold per piece, a bargain!"; 
		buttPiercingNum2.enabled = !buttPiercingNum2.enabled;
		buttPiercingNum3.enabled = !buttPiercingNum3.enabled;
	}

	public void piercingLoc2(){
		piercingNumber = 2; 
		piercingLocationName = "right eyebrow";
		multiplePiercings = true;
		piercingMaxCounter = 3; 
		panPiercingMaterialQuestion.SetAsLastSibling ();                
		Board.text = "What material will be? Metal is as cheap as it gets, 5 gold per piece, silver is 10, plain gold is 20 and we have rubies and gold at 40 and lastly precious diamonds at the affordable price of 80 gold per piece, a bargain!"; 
		buttPiercingNum2.enabled = !buttPiercingNum2.enabled;
		buttPiercingNum3.enabled = !buttPiercingNum3.enabled;
	}

	public void piercingLoc3(){
		piercingNumber = 3; 
		piercingLocationName = "left nostril";
		priceNumber = 1; 
		multiplePiercings = false; 
		panPiercingMaterialQuestion.SetAsLastSibling ();                
		Board.text = "What material will be? Metal is as cheap as it gets, 5 gold per piece, silver is 10, plain gold is 20 and we have rubies and gold at 40 and lastly precious diamonds at the affordable price of 80 gold per piece, a bargain!"; 
	}

	public void piercingLoc4(){
		piercingNumber = 4; 
		piercingLocationName = "right nostril";
		priceNumber = 1; 
		multiplePiercings = false; 
		panPiercingMaterialQuestion.SetAsLastSibling ();                
		Board.text = "What material will be? Metal is as cheap as it gets, 5 gold per piece, silver is 10, plain gold is 20 and we have rubies and gold at 40 and lastly precious diamonds at the affordable price of 80 gold per piece, a bargain!"; 
	}



	public void piercingLoc5(){
		piercingNumber = 5; 
		piercingLocationName = "septum";
		priceNumber = 1; 
		multiplePiercings = false; 
		buttCowRing.enabled = !buttCowRing.enabled;
		panPiercingMaterialQuestion.SetAsLastSibling ();               
		Board.text = "What material will be? Metal is as cheap as it gets, 5 gold per piece, silver is 10, plain gold is 20 and we have rubies and gold at 40 and lastly precious diamonds at the affordable price of 80 gold per piece, a bargain!"; 
		cowRing = true; 
	}

	public void piercingLoc6(){
		piercingNumber = 6; 
		piercingLocationName = "left earlobe";
		priceNumber = 1; 
		multiplePiercings = false; 
		panPiercingMaterialQuestion.SetAsLastSibling ();               
		Board.text = "What material will be? Metal is as cheap as it gets, 5 gold per piece, silver is 10, plain gold is 20 and we have rubies and gold at 40 and lastly precious diamonds at the affordable price of 80 gold per piece, a bargain!"; 
	}


	public void piercingLoc7(){
		piercingNumber = 7; 
		piercingLocationName = "right earlobe";
		priceNumber = 1; 
		multiplePiercings = false; 
		panPiercingMaterialQuestion.SetAsLastSibling ();                
		Board.text = "What material will be? Metal is as cheap as it gets, 5 gold per piece, silver is 10, plain gold is 20 and we have rubies and gold at 40 and lastly precious diamonds at the affordable price of 80 gold per piece, a bargain!"; 
	}

	public void piercingLoc8(){
		piercingNumber = 8; 
		piercingLocationName = "left ear helix";
		multiplePiercings = true;
		piercingMaxCounter = 6; 
		panPiercingMaterialQuestion.SetAsLastSibling ();               
		Board.text = "What material will be? Metal is as cheap as it gets, 5 gold per piece, silver is 10, plain gold is 20 and we have rubies and gold at 40 and lastly precious diamonds at the affordable price of 80 gold per piece, a bargain!"; 
		buttPiercingNum2.enabled = !buttPiercingNum2.enabled;
		buttPiercingNum3.enabled = !buttPiercingNum3.enabled;
		buttPiercingNum4.enabled = !buttPiercingNum4.enabled;
		buttPiercingNum5.enabled = !buttPiercingNum5.enabled;
		buttPiercingNum6.enabled = !buttPiercingNum6.enabled;
	}

	public void piercingLoc9(){
		piercingNumber = 9; 
		piercingLocationName = "right ear helix";
		multiplePiercings = true;
		piercingMaxCounter = 6; 
		panPiercingMaterialQuestion.SetAsLastSibling ();               
		Board.text = "What material will be? Metal is as cheap as it gets, 5 gold per piece, silver is 10, plain gold is 20 and we have rubies and gold at 40 and lastly precious diamonds at the affordable price of 80 gold per piece, a bargain!"; 
		buttPiercingNum2.enabled = !buttPiercingNum2.enabled;
		buttPiercingNum3.enabled = !buttPiercingNum3.enabled;
		buttPiercingNum4.enabled = !buttPiercingNum4.enabled;
		buttPiercingNum5.enabled = !buttPiercingNum5.enabled;
		buttPiercingNum6.enabled = !buttPiercingNum6.enabled;
	}

	public void piercingLoc10(){
		piercingNumber = 10; 
		piercingLocationName = "left lip";
		multiplePiercings = true;
		piercingMaxCounter = 3; 
		panPiercingMaterialQuestion.SetAsLastSibling ();                
		Board.text = "What material will be? Metal is as cheap as it gets, 5 gold per piece, silver is 10, plain gold is 20 and we have rubies and gold at 40 and lastly precious diamonds at the affordable price of 80 gold per piece, a bargain!"; 
		buttPiercingNum2.enabled = !buttPiercingNum2.enabled;
		buttPiercingNum3.enabled = !buttPiercingNum3.enabled;
	}

	public void piercingLoc11(){
		piercingNumber = 11; 
		piercingLocationName = "right lip";
		multiplePiercings = true;
		piercingMaxCounter = 3; 
		panPiercingMaterialQuestion.SetAsLastSibling ();                
		Board.text = "What material will be? Metal is as cheap as it gets, 5 gold per piece, silver is 10, plain gold is 20 and we have rubies and gold at 40 and lastly precious diamonds at the affordable price of 80 gold per piece, a bargain!"; 
		buttPiercingNum2.enabled = !buttPiercingNum2.enabled;
		buttPiercingNum3.enabled = !buttPiercingNum3.enabled;
	}


	public void piercingLoc12(){
		piercingNumber = 12; 
		piercingLocationName = "underlip";
		priceNumber = 1; 
		multiplePiercings = false; 
		panPiercingMaterialQuestion.SetAsLastSibling ();               
		Board.text = "What material will be? Metal is as cheap as it gets, 5 gold per piece, silver is 10, plain gold is 20 and we have rubies and gold at 40 and lastly precious diamonds at the affordable price of 80 gold per piece, a bargain!"; 
	}



	public void piercingLoc13(){
		piercingNumber = 13; 
		piercingLocationName = "tongue";
		multiplePiercings = true;
		piercingMaxCounter = 2; 
		panPiercingMaterialQuestion.SetAsLastSibling ();               
		Board.text = "What material will be? Metal is as cheap as it gets, 5 gold per piece, silver is 10, plain gold is 20 and we have rubies and gold at 40 and lastly precious diamonds at the affordable price of 80 gold per piece, a bargain!"; 
		buttPiercingNum2.enabled = !buttPiercingNum2.enabled;

	}


	public void piercingLoc14(){
		piercingNumber = 14; 
		piercingLocationName = "upper lip frenum";
		priceNumber = 1; 
		multiplePiercings = false; 
		panPiercingMaterialQuestion.SetAsLastSibling ();               
		Board.text = "What material will be? Metal is as cheap as it gets, 5 gold per piece, silver is 10, plain gold is 20 and we have rubies and gold at 40 and lastly precious diamonds at the affordable price of 80 gold per piece, a bargain!"; 
	}

	public void piercingLoc15(){
		piercingNumber = 15; 
		piercingLocationName = "lower lip frenum";
		priceNumber = 1; 
		multiplePiercings = false; 
		panPiercingMaterialQuestion.SetAsLastSibling ();                
		Board.text = "What material will be? Metal is as cheap as it gets, 5 gold per piece, silver is 10, plain gold is 20 and we have rubies and gold at 40 and lastly precious diamonds at the affordable price of 80 gold per piece, a bargain!"; 
	}

	public void piercingLoc16(){
		piercingNumber = 16; 
		piercingLocationName = "left nipple";
		priceNumber = 1; 
		multiplePiercings = false; 
		panPiercingMaterialQuestion.SetAsLastSibling ();               
		Board.text = "What material will be? Metal is as cheap as it gets, 5 gold per piece, silver is 10, plain gold is 20 and we have rubies and gold at 40 and lastly precious diamonds at the affordable price of 80 gold per piece, a bargain!"; 
	}



	public void piercingLoc17(){
		piercingNumber = 17; 
		piercingLocationName = "right nipple";
		priceNumber = 1; 
		multiplePiercings = false; 
		panPiercingMaterialQuestion.SetAsLastSibling ();             
		Board.text = "What material will be? Metal is as cheap as it gets, 5 gold per piece, silver is 10, plain gold is 20 and we have rubies and gold at 40 and lastly precious diamonds at the affordable price of 80 gold per piece, a bargain!"; 
	}


	public void piercingLoc18(){
		piercingNumber = 18; 
		piercingLocationName = "navel";
		priceNumber = 1; 
		multiplePiercings = false; 
		panPiercingMaterialQuestion.SetAsLastSibling ();               
		Board.text = "What material will be? Metal is as cheap as it gets, 5 gold per piece, silver is 10, plain gold is 20 and we have rubies and gold at 40 and lastly precious diamonds at the affordable price of 80 gold per piece, a bargain!"; 
	}

	public void piercingLoc19(){
		piercingNumber = 19; 
		piercingLocationName = "penis";
		multiplePiercings = true;
		piercingMaxCounter = 4; 
		panPiercingMaterialQuestion.SetAsLastSibling ();                
		Board.text = "What material will be? Metal is as cheap as it gets, 5 gold per piece, silver is 10, plain gold is 20 and we have rubies and gold at 40 and lastly precious diamonds at the affordable price of 80 gold per piece, a bargain!"; 
		buttPiercingNum2.enabled = !buttPiercingNum2.enabled;
		buttPiercingNum3.enabled = !buttPiercingNum3.enabled;
		buttPiercingNum4.enabled = !buttPiercingNum4.enabled;

	}


	public void piercingLoc20(){
		piercingNumber = 20; 
		piercingLocationName = "clitoris";
		priceNumber = 1; 
		multiplePiercings = false; 
		panPiercingMaterialQuestion.SetAsLastSibling ();               
		Board.text = "What material will be? Metal is as cheap as it gets, 5 gold per piece, silver is 10, plain gold is 20 and we have rubies and gold at 40 and lastly precious diamonds at the affordable price of 80 gold per piece, a bargain!"; 
	}

	/// <summary>
	/// Piercing material 
	/// </summary>

	public void piercingMaterial0(){
		piercingMaterial = "metal";
		priceMaterial = 5; 
		if (multiplePiercings == true) {
			panPiercingNumbers.SetAsLastSibling ();
			Board.text = "Well, how many piercings do you want? Remember, the cost is per piece, and we always ask full price even if you already have an old, rusty piece on you... Business, you know?";
		} else {
			
			panPiercingModelQuestion.SetAsLastSibling ();
		}

	}

	public void piercingMaterial1(){
		piercingMaterial = "silver";
		priceMaterial = 10;
		if (multiplePiercings == true) {
			panPiercingNumbers.SetAsLastSibling ();
			Board.text = "Well, how many piercings do you want? Remember, the cost is per piece, and we always ask full price even if you already have an old, rusty piece on you... Business, you know?";

		} else {
			panPiercingModelQuestion.SetAsLastSibling ();
			Board.text = "Well, what model you want? We have studs, rings... Even some special cow rings for your septum if you are into that"; 
 
		}

	}

	public void piercingMaterial2(){
		piercingMaterial = "gold";
		priceMaterial = 20;
		if (multiplePiercings == true) {
			panPiercingNumbers.SetAsLastSibling ();
			Board.text = "Well, how many piercings do you want? Remember, the cost is per piece, and we always ask full price even if you already have an old, rusty piece on you... Business, you know?";

		} else {
			panPiercingModelQuestion.SetAsLastSibling ();
			Board.text = "Well, what model you want? We have studs, rings... Even some special cow rings for your septum if you are into that"; 
 

		}

	}

	public void piercingMaterial3(){
		piercingMaterial = "gold and ruby";
		priceMaterial = 40; 
		if (multiplePiercings == true) {
			panPiercingNumbers.SetAsLastSibling ();
			Board.text = "Well, how many piercings do you want? Remember, the cost is per piece, and we always ask full price even if you already have an old, rusty piece on you... Business, you know?";

		} else {
			panPiercingModelQuestion.SetAsLastSibling ();
			Board.text = "Well, what model you want? We have studs, rings... Even some special cow rings for your septum if you are into that"; 
 

		}

	}
	public void piercingMaterial4(){
		piercingMaterial = "gold and diamond";
		priceMaterial = 80; 
		if (multiplePiercings == true) {
			panPiercingNumbers.SetAsLastSibling ();
			Board.text = "Well, how many piercings do you want? Remember, the cost is per piece, and we always ask full price even if you already have an old, rusty piece on you... Business, you know?";

		} else {
			panPiercingModelQuestion.SetAsLastSibling ();
			Board.text = "Well, what model you want? We have studs, rings... Even some special cow rings for your septum if you are into that"; 
 

		}

	}



	/// <summary>
	/// Piercing Quantity 
	/// </summary>


	public void piercingQuantity1(){
		priceNumber = 1; 
		piercingQuantityUse = "a"; 
		panPiercingModelQuestion.SetAsLastSibling ();
		Board.text = "Well, what model you want? We have studs, rings... Even some special cow rings for your septum if you are into that"; 
 


	}

	public void piercingQuantity2(){
		priceNumber = 2; 
		piercingQuantityUse = "two"; 

		panPiercingModelQuestion.SetAsLastSibling ();
		Board.text = "Well, what model you want? We have studs, rings... Even some special cow rings for your septum if you are into that"; 
 

	}

	public void piercingQuantity3(){
		priceNumber = 3; 
		piercingQuantityUse = "three"; 
		panPiercingModelQuestion.SetAsLastSibling ();
		Board.text = "Well, what model you want? We have studs, rings... Even some special cow rings for your septum if you are into that"; 
 

	}

	public void piercingQuantity4(){
		priceNumber = 4; 
		piercingQuantityUse = "four"; 
		panPiercingModelQuestion.SetAsLastSibling ();
		Board.text = "Well, what model you want? We have studs, rings... Even some special cow rings for your septum if you are into that"; 
 

	}


	public void piercingQuantity5(){
		priceNumber = 5; 
		piercingQuantityUse = "five"; 
		panPiercingModelQuestion.SetAsLastSibling ();
		Board.text = "Well, what model you want? We have studs, rings... Even some special cow rings for your septum if you are into that"; 
 

	}


	public void piercingQuantity6(){
		priceNumber = 6; 
		piercingQuantityUse = "six"; 
		panPiercingModelQuestion.SetAsLastSibling ();
		Board.text = "Well, what model you want? We have studs, rings... Even some special cow rings for your septum if you are into that"; 
 

	}




	 /// <summary>
	 /// Piercings models
	 /// </summary>
	public void piercingModel0(){
		if (priceNumber == 1) {
			piercingModel = "piercing";
		} else { 

			piercingModel = "piercings";
		}


		priceTotal = priceNumber * priceMaterial; 
		if (GameControl.charGold < priceTotal) {
			Board.text = "Uh darling... The cost of this is " + priceTotal + " and you dont have enough with you. Come with us again once you have the gold 'kay?"; 
			panBack.SetAsLastSibling ();
		} else {

			Board.text = "Fine darling, this work will cost you " + priceTotal + ". Do you want us to continue?";
			panBuyQuestion.SetAsLastSibling ();
		}
	}


	public void piercingModel1(){
		if (priceNumber == 1) {
			piercingModel = "ring";
		} else { 

			piercingModel = "rings";
		}

		priceTotal = priceNumber * priceMaterial; 
		if (GameControl.charGold < priceTotal) {
			Board.text = "Uh darling... The cost of this is " + priceTotal + " and you dont have enough with you. Come with us again once you have the gold 'kay?"; 
			panBack.SetAsLastSibling ();
		} else {

			Board.text = "Fine darling, this work will cost you " + priceTotal + ". Do you want us to continue?";
			panBuyQuestion.SetAsLastSibling ();
		}
	}




	public void piercingModel2(){
		piercingModel = "cow ring";
		priceTotal = priceNumber * priceMaterial; 
		if (GameControl.charGold < priceTotal) {
			Board.text = "Uh darling... The cost of this is " + priceTotal + " and you dont have enough with you. Come with us again once you have the gold 'kay?"; 
			panBack.SetAsLastSibling ();
		} else {

			Board.text = "Fine darling, this work will cost you " + priceTotal + ". Do you want us to continue?";
			panBuyQuestion.SetAsLastSibling ();
		}
	}



	/////////////////////////////////////////////// 
	/// THE ORDER IS: FIRST LOCATION, MATERIAL, NUMBER,  MODEL
	/// 
	/// 

	void Awake(){
		cowRing = false; 
		buttCowRing.enabled = !buttCowRing.enabled;
		buttPiercingNum2.enabled = !buttPiercingNum2.enabled;
		buttPiercingNum3.enabled = !buttPiercingNum3.enabled;
		buttPiercingNum4.enabled = !buttPiercingNum4.enabled;
		buttPiercingNum5.enabled = !buttPiercingNum5.enabled;
		buttPiercingNum6.enabled = !buttPiercingNum6.enabled;

		if (GameControl.dick1Size <= 0) {
			buttPenisTrue.enabled = !buttPenisTrue.enabled;
		}

		if (GameControl.hasVagina == false) {
			buttVaginaTrue.enabled = !buttVaginaTrue.enabled; 
		}


	}

	void Update (){




	}


}
