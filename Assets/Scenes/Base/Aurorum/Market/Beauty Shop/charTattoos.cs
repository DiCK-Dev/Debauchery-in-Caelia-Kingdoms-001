using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class charTattoos : MonoBehaviour {

	public static string tattooDescription; 
	public static string tattooLocation; // to create the text
	static int tattooNumber; // for the array
	public RectTransform panTattooDesign;
	public RectTransform panFinalQuestion;
	public RectTransform panTattooLocation; 
	public RectTransform panBack;



	public Button buttQuestion; 


	public InputField tattooName; 	
	public string tattooFinalDesign; 

	public Text Board; 
	public Text lineQuestion1;

	//0 Forehead 
	//1 left cheek
	//2 righ cheek
	//3 neck
	//4 upper chest 
	//5 left breast
	//6 right breast
	//7 belly
	//8 low belly
	//9 upper back
	//10 lower back
	//11 left upper arm 
	//12 left forearm
	//13 left wrist
	//14 right upper arm
	//15 rught forearm
	//16 right wrist 
	//17 left ass cheek
	//18 right ass cheek
	//19 left upper leg
	//20 left calf leg
	//21 left ankle
	//22right upper leg
	//23 right calf leg
	//24 right ankle
	//25 anus


	public void askTattoo(){
		if (GameControl.charGold >= 50) {
			panTattooLocation.SetAsLastSibling ();
			Board.text = "Oh you want a tattoo? Sure darling, any tattoo costs 50 gold. Dont worry, thanks to alchemy we can change them easily. So, where you want it?";
		} else {
			panBack.SetAsLastSibling ();
			Board.text = "Oh you want a tattoo? Sure darling, but you are low on money, the job costs 50 gold, but come back when you get the money 'kay? I will make sure it doesn't hurt much...";
		}
	}


	public void setDesign(){
		tattooFinalDesign = tattooName.text; 
		Board.text = "Okay so you want a tattoo of " + tattooFinalDesign + " on your " + tattooLocation + " is that right? Want to continue?"; 
		panTattooDesign.SetAsFirstSibling ();
		panFinalQuestion.SetAsLastSibling ();
	}

	public void setTattoo(){
		GameControl.charGold -= 50; 
		tattooDescription = tattooFinalDesign; 
		tattooDescription = "\nYou have a tattoo of " + tattooDescription + " on your " + tattooLocation ;
		GameControl.tattoo [tattooNumber] = tattooDescription;
		tattooName.text = ""; 
		panBack.SetAsLastSibling ();
		Board.text = "Thanks to both alchemy and her expert hands, she gets the job done in no time!";
	}



	public void activeButtonQuesion()
	{
		if (tattooName.text == "") {
			buttQuestion.GetComponent<Button> ().enabled = false; 
		} else {
			buttQuestion.GetComponent<Button> ().enabled = true; 

		}
	}


	public void Tattoo0(){
		tattooLocation = "forehead"; 
		tattooNumber = 0;
		panTattooDesign.SetAsLastSibling ();              
		lineQuestion1.text = " on your " + tattooLocation;


	}


	public void Tattoo1(){
		tattooLocation = "left cheek"; 
		tattooNumber = 1;
			panTattooDesign.SetAsLastSibling ();              
		lineQuestion1.text = " on your " + tattooLocation;

	}

	public void Tattoo2(){
		tattooLocation = "right cheek"; 
		tattooNumber = 2;
			panTattooDesign.SetAsLastSibling ();              
		lineQuestion1.text = " on your " + tattooLocation;
	}

	public void Tattoo3(){
		tattooLocation = "neck"; 
		tattooNumber = 3;
		panTattooDesign.SetAsLastSibling ();              
		lineQuestion1.text = " on your " + tattooLocation;
	}

	public void Tattoo4(){
		tattooLocation = "upper chest"; 
		tattooNumber = 4;
			panTattooDesign.SetAsLastSibling ();              
		lineQuestion1.text = " on your " + tattooLocation;
	}


	public void Tattoo5(){
		tattooLocation = "left breast"; 
		tattooNumber = 5;
			panTattooDesign.SetAsLastSibling ();             
		lineQuestion1.text = " on your " + tattooLocation;
	}


	public void Tattoo6(){
		tattooLocation = "right breast"; 
		tattooNumber = 6;
			panTattooDesign.SetAsLastSibling ();            
		lineQuestion1.text = " on your " + tattooLocation;
	}




	public void Tattoo7(){
		tattooLocation = "belly"; 
		tattooNumber = 7;
			panTattooDesign.SetAsLastSibling ();             
		lineQuestion1.text = " on your " + tattooLocation;
	}
	public void Tattoo8(){
		tattooLocation = "lower belly"; 
		tattooNumber = 8;
			panTattooDesign.SetAsLastSibling ();              
		lineQuestion1.text = " on your " + tattooLocation;
	}
	public void Tattoo9(){
		tattooLocation = "upper back"; 
		tattooNumber = 9;
			panTattooDesign.SetAsLastSibling ();             
		lineQuestion1.text = " on your " + tattooLocation;
	}


	public void Tattoo10(){
		tattooLocation = "lower back"; 
		tattooNumber = 10;
			panTattooDesign.SetAsLastSibling ();            
		lineQuestion1.text = " on your " + tattooLocation;
	}
	public void Tattoo11(){
		tattooLocation = "left upper arm"; 
		tattooNumber = 11;
			panTattooDesign.SetAsLastSibling ();              
		lineQuestion1.text = " on your " + tattooLocation;
	}
	public void Tattoo12(){
		tattooLocation = "left forearm"; 
		tattooNumber = 12;
			panTattooDesign.SetAsLastSibling ();           
		lineQuestion1.text = " on your " + tattooLocation;
	}


	public void Tattoo13(){
		tattooLocation = "left wrist"; 
		tattooNumber = 13;
			panTattooDesign.SetAsLastSibling ();             
		lineQuestion1.text = " on your " + tattooLocation;
	}
	public void Tattoo14(){
		tattooLocation = "right upper arm"; 
		tattooNumber = 14;
			panTattooDesign.SetAsLastSibling ();             
		lineQuestion1.text = " on your " + tattooLocation;
	}
	public void Tattoo15(){
		tattooLocation = "right forearm"; 
		tattooNumber = 15;
			panTattooDesign.SetAsLastSibling ();              
		lineQuestion1.text = " on your " + tattooLocation;
	}

	public void Tattoo16(){
		tattooLocation = "right wrist"; 
		tattooNumber = 16;
			panTattooDesign.SetAsLastSibling ();            
		lineQuestion1.text = " on your " + tattooLocation;
	}



	public void Tattoo17(){
		tattooLocation = "left buttock"; 
		tattooNumber = 17;
			panTattooDesign.SetAsLastSibling ();            
		lineQuestion1.text = " on your " + tattooLocation;
	}

	public void Tattoo18(){
		tattooLocation = "right buttock"; 
		tattooNumber = 18;
			panTattooDesign.SetAsLastSibling ();              
		lineQuestion1.text = " on your " + tattooLocation;
	}




	public void Tattoo19(){
		tattooLocation = "left upper leg"; 
		tattooNumber = 19;
			panTattooDesign.SetAsLastSibling ();             
		lineQuestion1.text = " on your " + tattooLocation;
	}



	public void Tattoo20(){
		tattooLocation = "left calf"; 
		tattooNumber = 20;
			panTattooDesign.SetAsLastSibling ();             
		lineQuestion1.text = " on your " + tattooLocation;
	}

	public void Tattoo21(){
		tattooLocation = "left ankle"; 
		tattooNumber = 21;
			panTattooDesign.SetAsLastSibling ();          
		lineQuestion1.text = " on your " + tattooLocation;
	}



	public void Tattoo22(){
		tattooLocation = "right upper leg"; 
		tattooNumber = 22;
			panTattooDesign.SetAsLastSibling ();        
		lineQuestion1.text = " on your " + tattooLocation;
	}



	public void Tattoo23(){
		tattooLocation = "right calf"; 
		tattooNumber = 23;
			panTattooDesign.SetAsLastSibling ();         
		lineQuestion1.text = " on your " + tattooLocation;
	}

	public void Tattoo24(){
		tattooLocation = "right ankle"; 
		tattooNumber = 24;
			panTattooDesign.SetAsLastSibling ();       
		lineQuestion1.text = " on your " + tattooLocation;
	}

	public void Tattoo25(){
		tattooLocation = "anus"; 
		tattooNumber = 25;
			panTattooDesign.SetAsLastSibling ();        
		lineQuestion1.text = " on your " + tattooLocation;
	}



	//Location, Design, Final question

	void Awake (){
		tattooDescription = "";
	}

	void Update(){
		activeButtonQuesion ();
	}

}
