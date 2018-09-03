using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class PanLeftManagement : MonoBehaviour {

	public Animator leftPanelB0; // menu
	public Animator leftPanelB2; // Location
	public Animator leftPanelB3; // Character
	public Animator leftPanelB4; // Inventory
	public Animator leftPanelB5; // Retainers
	public Animator leftPanelB6a; // Management list 1
	public Animator leftPanelB6b; // Management list 2
	public Animator leftPanelB6c; // Management list 3
	public Animator leftPanelB7; // Journal
	public Animator leftPanelB8; // Info


	public Animator leftPanelC0a; // saves
	public Animator leftPanelC0b; // load
	public Animator leftPanelC0c; // font size
	public Animator leftPanelC0d; // tag
	public Animator leftPanelC0e; // cheats


	public Animator leftPanelC2a1; // aurorum
	public Animator leftPanelC2a2; // aurorum
	public Animator leftPanelC2f; // region 1

	public Animator leftPanelC4a; // inv 
	public Animator leftPanelC4b; // equip
	public Animator leftPanelC4c; // acc

	public Animator leftPanelC5a; // retainers extra list 1
	public Animator leftPanelC5b; // retainers extra list 1

	public Animator leftPanelC6a; // Loads the buildings for managemenet, requires a lot of controls

	public Animator	leftPanelC8a;

	bool isMouseOverB = false;
	bool isMouseOverC = false;

	bool panAButt0 = false; // menu
	bool panAButt2 = false; // locations
	bool panAButt3 = false; // Character
	bool panAButt4 = false; // Inventory
	bool panAButt5 = false; // Retainers
	bool panAButt6 = false; // management
	bool panAButt7 = false; // journal
	bool panAButt8 = false; // info


	bool panBButt0a = false;  // save
	bool panBButt0b = false;  // load
	bool panBButt0c = false;  // font size
	bool panBButt0d = false;  // tag
	bool panBButt0e = false;  // cheats
	bool panBButt0f = false;  // quit


	bool panBButt2a = false;  // aurorum
	bool panBButt2f = false;  // region 1

	bool panBButt4a = false;  // inventory screen - used for all, loads with code
	bool panBButt4b = false;  // inv equipment
	bool panBButt4c = false; // inv acc

	bool panBButt5a = false; 
	bool panBButt5b = false;  

	bool panBButt6a = false; 

	bool panBButt8a = false;

	//first row





	EndTurn endTurn = new EndTurn();
	public static bool endTurnControl; 



	//menu button
	public void actAPanel(int selector){
		// selections 0 to 999 are panelB, 1000+ are panel C

		if (selector == 0)  //activate menu
		{ 
			isMouseOverB = true; 
			if (panAButt0 == false) {
				panButtFalse ();
				panAllBack ();
				leftPanelB0.SetBool ("isDisplayed", true);
				panAButt0 = true; 
			

			} else {
				isMouseOverB = false; 
				panButtFalse ();
				panAllBack ();

			}
		}

		//////////////////////////////////////////////////

		if (selector == 1)
		{ //
				goBase ();
		} //

		//////////////////////////////////////////////////

		if (selector == 2)  //activate locations
		{ 
			isMouseOverB = true; 
			if (panAButt2 == false) {
				
				panAllBack ();
				panButtFalse ();
				leftPanelB2.SetBool ("isDisplayed", true);
				panAButt2 = true; 


			} else {
				isMouseOverB = false; 
				panAllBack ();
				panAButt2 = false; 

			}
		}

		//////////////////////////////////////////////////


		if (selector == 3)  //activate character
		{ 
			isMouseOverB = true; 
			if (panAButt3 == false) {

				panAllBack ();
				panButtFalse ();
				leftPanelB3.SetBool ("isDisplayed", true);
				panAButt3 = true; 


			} else {
				isMouseOverB = false; 
				panAllBack ();
				panAButt3 = false; 

			}
		}

		//////////////////////////////////////////////////


		if (selector == 4)  //activate inventory
		{ 
			isMouseOverB = true; 
			if (panAButt4 == false) {

				panAllBack ();
				panButtFalse ();
				leftPanelB4.SetBool ("isDisplayed", true);
				panAButt4 = true; 


			} else {
				isMouseOverB = false; 
				panAllBack ();
				panAButt4 = false; 

			}
		}

		//////////////////////////////////////////////////


		if (selector == 5)  //activate retainrs
		{ 
			isMouseOverB = true; 
			if (panAButt5 == false) {

				panAllBack ();
				panButtFalse ();
				leftPanelB5.SetBool ("isDisplayed", true);
				panAButt5 = true; 


			} else {
				isMouseOverB = false; 
				panAllBack ();
				panAButt5 = false; 

			}
		}

		//////////////////////////////////////////////////


		if (selector == 6)  //activate management
		{ 
			isMouseOverB = true; 
			if (panAButt6 == false) {

				panAllBack ();
				panButtFalse ();
				leftPanelB6a.SetBool ("isDisplayed", true);
				panAButt6 = true; 



			} else {
				isMouseOverB = false; 
				panAllBack ();
				panAButt6 = false; 

			}
		}

		//////////////////////////////////////////////////

		if (selector == 7)  //activate journal
		{ 
			isMouseOverB = true; 
			if (panAButt7 == false) {

				panAllBack ();
				panButtFalse ();
				leftPanelB7.SetBool ("isDisplayed", true);
				panAButt7 = true; 



			} else {
				isMouseOverB = false; 
				panAllBack ();
				panAButt7 = false; 

			}
		}

		//////////////////////////////////////////////////

		if (selector == 8)  //activate journal
		{ 
			isMouseOverB = true; 
			if (panAButt8 == false) {

				panAllBack ();
				panButtFalse ();
				leftPanelB8.SetBool ("isDisplayed", true);
				panAButt8 = true; 



			} else {
				isMouseOverB = false; 
				panAllBack ();
				panAButt8 = false; 

			}
		}



		//////////////////////////////////////////////////


		if (selector == 1000)  //activate menu save
		{ // 
			isMouseOverC = true; 

			if (panBButt0a == false) {
				panButtFalse ();
				panCBack ();
				leftPanelC0a.SetBool ("isDisplayed", true);
				panAButt0 = true; 
				panBButt0a = true;




			} else {
				isMouseOverC = false; 

				panCBack ();
				panBButt0a = false; 

			}
		} //

		if (selector == 1001)  //activate menu load
		{ // 
			isMouseOverC = true; 

			if (panBButt0b == false) {
				panButtFalse ();
				panCBack ();
				leftPanelC0b.SetBool ("isDisplayed", true);
				panAButt0 = true; 
				panBButt0b = true; 
	


			} else {
				isMouseOverC = false; 

				panCBack ();
				panBButt0b = false;  


			}
		} //

		if (selector == 1002)  //activate menu font size
		{ // 
			isMouseOverC = true; 

			if (panBButt0c == false) {
				panButtFalse ();
				panCBack ();
				leftPanelC0c.SetBool ("isDisplayed", true);
				panAButt0 = true; 
				panBButt0c = true; 



			} else {
				isMouseOverC = false; 

				panCBack ();
				panBButt0c = false;  


			}
		} //

		if (selector == 1003)  //activate menu tag
		{ // 
			isMouseOverC = true; 

			if (panBButt0d == false) {
				panButtFalse ();
				panCBack ();
				leftPanelC0d.SetBool ("isDisplayed", true);
				panAButt0 = true; 
				panBButt0d = true; 



			} else {
				isMouseOverC = false; 

				panCBack ();
				panBButt0d = false;  


			}
		} //

		if (selector == 1004)  //activate menu cheats
		{ // 
			isMouseOverC = true; 

			if (panBButt0e == false) {
				panButtFalse ();
				panCBack ();
				leftPanelC0e.SetBool ("isDisplayed", true);
				panAButt0 = true; 
				panBButt0e = true; 



			} else {
				isMouseOverC = false; 

				panCBack ();
				panBButt0e = false;  


			}
		} //


		if (selector == 1100)  //activate menu aurorum
		{ // 
			isMouseOverC = true; 

			if (panBButt2a == false) {
				panButtFalse ();
				panCBack ();
				leftPanelC2a1.SetBool ("isDisplayed", true);
				panAButt2 = true; 
				//panBButt2a = true; 



			} else {
				/*
				isMouseOverC = false; 

				panCBack ();
				panBButt2a = false; 
				*/


			}
		} //
		if (selector == 1101)  //activate menu aurorum
		{ // 
			isMouseOverC = true; 

			if (panBButt2a == false) {
				panButtFalse ();
				panCBack ();
				leftPanelC2a2.SetBool ("isDisplayed", true);
				panAButt2 = true; 
				//panBButt2a = true; 



			} else {
				/*
				isMouseOverC = false; 

				panCBack ();
				panBButt2a = false;  
				*/


			}
		} //

		if (selector == 1150)  //activate menu region
		{ // 
			isMouseOverC = true; 

			if (panBButt2f == false) {
				panButtFalse ();
				panCBack ();

				leftPanelC2f.SetBool ("isDisplayed", true);
				panAButt2 = true; 
				panBButt2f = true; 



			} else {
				isMouseOverC = false; 
				panCBack ();

				panBButt2f = false;  


			}
		} //

		////////////////////////////////////////////////////////////////////////////

		if (selector == 1200)  //activate inv slot 0
		{ // 
			isMouseOverC = true; 

			if (panBButt4a == false) {
				panButtFalse ();
				panCBack ();

				leftPanelC4a.SetBool ("isDisplayed", true);
				panAButt4 = true; 
				panBButt4a = true; 





			} else {

				/*
				isMouseOverC = false; 
				panCBack ();

				panBButt2f = false;  
				*/


			}
		} //

		if (selector == 1201)  //activate equipslot 
		{ // 
			isMouseOverC = true; 

			if (panBButt4b == false) {
				panButtFalse ();
				panCBack ();

				leftPanelC4b.SetBool ("isDisplayed", true);
				panAButt4 = true; 
				panBButt4b = true;




			} else {
		

				isMouseOverC = false; 
				panCBack ();

				panBButt4b = false;  



			}
		} //


		if (selector == 1202)  //activate acc slot 
		{ // 
			isMouseOverC = true; 

			if (panBButt4c == false) {
				panButtFalse ();
				panCBack ();

				leftPanelC4c.SetBool ("isDisplayed", true);
				panAButt4 = true; 
				panBButt4c = true;




			} else {


				isMouseOverC = false; 
				panCBack ();

				panBButt4c = false;  



			}
		} //


		////////////////////////////////////////////////////////////////////

		if (selector == 1300)  //activate retainers list 2
		{ // 
			isMouseOverC = true; 

			if (panBButt5a == false) {
				panButtFalse ();
				panCBack ();

				leftPanelC5a.SetBool ("isDisplayed", true);
				panAButt5 = true; 
				panBButt5a = true;




			} else {

		
				isMouseOverC = false; 
				panCBack ();

				panBButt5a = false;  



			}
		} //

		if (selector == 1301)  //activate retainers list3
		{ // 
			isMouseOverC = true; 

			if (panBButt5b == false) {
				panButtFalse ();
				panCBack ();

				leftPanelC5b.SetBool ("isDisplayed", true);
				panAButt5 = true; 
				panBButt5b = true;




			} else {


				isMouseOverC = false; 
				panCBack ();

				panBButt5b = false;  



			}
		} //

		//////////////////////////////////////////////////////////////////////////////////////////////////////

		if (selector == 1400)  //activate management list 1
		{ // 
			isMouseOverC = true; 
			leftPanelB6a.SetBool ("isDisplayed", true);
			leftPanelB6b.SetBool ("isDisplayed", false);
			leftPanelB6c.SetBool ("isDisplayed", false);
			 

		} //

		if (selector == 1401)  //activate management list 2
		{ // 
			isMouseOverC = true; 
			leftPanelB6a.SetBool ("isDisplayed", false);
			leftPanelB6b.SetBool ("isDisplayed", true);
			leftPanelB6c.SetBool ("isDisplayed", false);


		} //

		if (selector == 1402)  //activate management list 3
		{ // 
			isMouseOverC = true; 
			leftPanelB6a.SetBool ("isDisplayed", false);
			leftPanelB6b.SetBool ("isDisplayed", false);
			leftPanelB6c.SetBool ("isDisplayed", true);
		 

		} //
			

		if (selector == 1410)  //activate church
		{ // 
			isMouseOverC = true; 

			if (panBButt6a == false) {
				panButtFalse ();
				panCBack ();

				leftPanelC6a.SetBool ("isDisplayed", true);
				panAButt6 = true; 
			//	panBButt6a = true;
	

			} else {
				isMouseOverC = false; 
				panCBack ();
				panBButt6a = false;  

			}
		} //
			

		////////////////////////////////////

		if (selector == 1500)  //activate info
		{ // 
			isMouseOverC = true; 

			if (panBButt8a == false) {
				panButtFalse ();
				panCBack ();
				leftPanelC8a.SetBool ("isDisplayed", true);
				panAButt8 = true; 
				panBButt8a = true;




			} else {
				isMouseOverC = false; 

			

			}
		} //


		if (selector == 1501)  //activate info
		{ // 
			isMouseOverC = true; 

			if (panBButt8a == false) {
				panButtFalse ();
				panCBack ();
				leftPanelC8a.SetBool ("isDisplayed", true);
				panAButt8 = true; 
				panBButt8a = true;




			} else {
				isMouseOverC = false; 



			}
		} //











	}





	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void panAllBack(){
		leftPanelB0.SetBool ("isDisplayed", false);
		leftPanelB2.SetBool ("isDisplayed", false);
		leftPanelB3.SetBool ("isDisplayed", false);
		leftPanelB4.SetBool ("isDisplayed", false);
		leftPanelB5.SetBool ("isDisplayed", false);
		leftPanelB6a.SetBool ("isDisplayed", false);
		leftPanelB6b.SetBool ("isDisplayed", false);
		leftPanelB6c.SetBool ("isDisplayed", false);
		leftPanelB7.SetBool ("isDisplayed", false);
		leftPanelB8.SetBool ("isDisplayed", false);

		panCBack ();

	}
	////////////////////////////////////////////////////////
	void panCBack(){
		leftPanelC0a.SetBool ("isDisplayed", false);
		leftPanelC0b.SetBool ("isDisplayed", false);
		leftPanelC0c.SetBool ("isDisplayed", false);
		leftPanelC0d.SetBool ("isDisplayed", false);
		leftPanelC0e.SetBool ("isDisplayed", false);


		leftPanelC2a1.SetBool ("isDisplayed", false);
		leftPanelC2a2.SetBool ("isDisplayed", false);
		leftPanelC2f.SetBool ("isDisplayed", false);

		leftPanelC4a.SetBool ("isDisplayed", false);
		leftPanelC4b.SetBool ("isDisplayed", false);
		leftPanelC4c.SetBool ("isDisplayed", false);

		leftPanelC5a.SetBool ("isDisplayed", false);
		leftPanelC5b.SetBool ("isDisplayed", false);

		leftPanelC6a.SetBool ("isDisplayed", false);

		leftPanelC8a.SetBool ("isDisplayed", false);

	}




	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void panButtFalse(){
		panAButt0 = false;
		panAButt2 = false; 
		panAButt3 = false; 
		panAButt4 = false; 
		panAButt5 = false; 
		panAButt6 = false; 
		panAButt7 = false;
		panAButt8 = false;

		//////////////////
		panBButt0a = false; 
		panBButt0b = false; 
		panBButt0c = false; 
		panBButt0d = false; 
		panBButt0e = false; 
		panBButt0f = false; 

		panBButt2a = false;
		panBButt2f = false; 

		panBButt4a = false; 
		panBButt4b = false; 
		panBButt4c = false; 

		panBButt5a = false; 
		panBButt5b = false;  

		panBButt6a = false; 

		panBButt8a = false; 


	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



	public void mouseOverB(){
		isMouseOverB = true;
		isMouseOverC = false;
	}

	public void mouseExitB(){
		StartCoroutine ("waitSecondsPanB");
	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	public void mouseOverC(){
		isMouseOverB = true;
		isMouseOverC = true;
	}

	public void mouseExitC(){
		StartCoroutine ("waitSecondsPanC");
	}


	//////////////////////////////////////////////////////////////////////////

	IEnumerator waitSecondsPanB(){
		isMouseOverB = false; 

		yield return new WaitForSeconds (2.15f);

		if (isMouseOverB == false) {
			panAllBack ();
			panButtFalse ();
		}



	}

	IEnumerator waitSecondsPanC(){
		isMouseOverC = false; 

		yield return new WaitForSeconds (2.15f);

		if (isMouseOverC == false) {

			panCBack ();
			panButtFalse ();
		}



	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


	void goBase(){

		if (endTurnControl == false) {

			SceneManager.LoadScene (3);

		} else {
			endTurnControl = false; 
			endTurn.endTurn ();
		}

	}


	void Awake(){
		endTurnControl = false; 
	}

}
