using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class LeftPanelManagementControl : MonoBehaviour {

	static int selectBuilding;

	public Text buildingTxt1;
	public Text buildingTxt2;
	public Text buildingTxt3;
	public Text buildingTxt4;
	public Text buildingTxt5;
	public Text buildingTxt6;
	public Text buildingTxt7;
	public Text buildingTxt8;

	public Button buttbuild1;
	public Button buttbuild2;
	public Button buttbuild3;
	public Button buttbuild4;
	public Button buttbuild5;
	public Button buttbuild6;
	public Button buttbuild7;
	public Button buttbuild8;

	public void buildSelector(int selector){
		selectBuilding = selector;

	}


	public void buttBuild1(){
		if (selectBuilding == 0) {
			SceneManager.LoadScene (3); // here goes the scene
		}

		if (selectBuilding == 1) {
			SceneManager.LoadScene (3); // here goes the scene
		}


	}




	public void buttBuild2(){
		if (selectBuilding == 0) {
			SceneManager.LoadScene (3); // here goes the scene
		}

		if (selectBuilding == 1) {
			SceneManager.LoadScene (3); // here goes the scene
		}


	}


	public void buttBuild3(){
		if (selectBuilding == 0) {
			SceneManager.LoadScene (3); // here goes the scene
		}


	}


	public void buttBuild4(){
		if (selectBuilding == 0) {
			SceneManager.LoadScene (3); // here goes the scene
		}


	}



	public void buttBuild5(){
		if (selectBuilding == 0) {
			SceneManager.LoadScene (3); // here goes the scene
		}


	}



	public void buttBuild6(){
		if (selectBuilding == 1) {
			SceneManager.LoadScene (3); // here goes the scene
		}


	}



	public void buttBuild7(){
		if (selectBuilding == 1) {
			SceneManager.LoadScene (3); // here goes the scene
		}


	}


	public void buttBuild8(){
		if (selectBuilding == 1) {
			SceneManager.LoadScene (3); // here goes the scene
		}


	}












	public void loadBuilding(){
		deactButt ();

		if (selectBuilding == 0) {
			buildingTxt1.text = "Finance minister";
			buttbuild1.interactable = true;

			buildingTxt2.text = "Chancellor (not yet)";
			buildingTxt3.text = "Marshal (not yet)";
			buildingTxt4.text = "Shadow master (not yet)";
			buildingTxt5.text = "War Minister (not yet)";
			buildingTxt6.text = "";
			buildingTxt7.text = "";
			buildingTxt8.text = "";


		}

		if (selectBuilding == 1) {
			buildingTxt1.text = "Priest";
			buildingTxt2.text = "Grand Inquisitor";

			buttbuild1.interactable = true; 
			buttbuild2.interactable = true; 


			buildingTxt3.text = "Abbess (Not yet)";
			buildingTxt4.text = "Grand Master (Not yet)";
			buildingTxt5.text = "Acolytes (Not yet)";
			buildingTxt6.text = "Inquisitors (Not yet)";
			buildingTxt7.text = "Nuns and monks (Not yet)";
			buildingTxt8.text = "Order Knights (Not yet)";


		}

		if (selectBuilding == 2) {
			buildingTxt1.text = "Ex1";
			buildingTxt2.text = "Ex2";
			buildingTxt3.text = "Ex2";
			buildingTxt4.text = "Ex2";
			buildingTxt5.text = "Acolytes";
			buildingTxt6.text = "Inquisitors";
			buildingTxt7.text = "Nuns and monks";
			buildingTxt8.text = "Order knights";


		}

	}


	void deactButt(){
		buttbuild1.interactable = false;
		buttbuild2.interactable = false;
		buttbuild3.interactable = false;
		buttbuild4.interactable = false;
		buttbuild5.interactable = false;
		buttbuild6.interactable = false;
		buttbuild7.interactable = false;
		buttbuild8.interactable = false;


	}


}
