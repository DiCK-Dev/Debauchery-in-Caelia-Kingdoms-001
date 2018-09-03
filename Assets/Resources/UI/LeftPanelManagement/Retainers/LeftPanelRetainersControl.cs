using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class LeftPanelRetainersControl : MonoBehaviour {

	public Button buttFollower1000; 
	public Text textFollower1000;

	public Button buttFollower3000; 
	public Text textFollower3000;

	public Button buttFollower4000; // deactivated for now 
	public Text textFollower4000; //

	public Button buttFollower5000; // deact for now
	public Text textFollower5000;

	public Button buttFollower6000; 
	public Text textFollower6000;

	public Button buttFollower7000; 
	public Text textFollower7000;

	public Button buttFollower8000; //vivica
	public Text textFollower8000;

	public Button buttFollower9000;  // virgil 
	public Text textFollower9000;

	public Button buttFollower10000; // celia 
	public Text textFollower10000;

	public Button buttFollower11000; // Lucretius
	public Text textFollower11000;

	public Button buttFollower12000; // Faustina
	public Text textFollower12000;

	public Button buttFollower13000; // Alba
	public Text textFollower13000;

	public Button buttFollower14000; // Luna
	public Text textFollower14000;


	void FollowerButtons()
	{
		int i = 0;
		hideFollowers ();

		while (i < NPCCharList.CharFollower.Count) 
		{


			if (NPCCharList.CharFollower [i].charID == 1000 && NPCCharList.CharFollower [i].isRecruited) {
				buttFollower1000.interactable = true; 
				textFollower1000.text = "Abbadon"; 
			}

			if (NPCCharList.CharFollower [i].charID == 3000 && NPCCharList.CharFollower [i].isRecruited) {
				buttFollower3000.interactable = true; 
				textFollower3000.text = "Helena"; 
			}
			/*
			if (NPCCharList.CharFollower [i].charID >= 4000 && NPCCharList.CharFollower [i].charID < 5000 && NPCCharList.CharFollower [i].isRecruited) {
				buttFollower4000.interactable = true; 
				textFollower4000.text = "Misaki"; 
			}
			if (NPCCharList.CharFollower [i].charID >= 5000 && NPCCharList.CharFollower [i].charID < 6000 && NPCCharList.CharFollower [i].isRecruited) {
				buttFollower5000.interactable = true; 
				textFollower5000.text = "Yoshika"; 
			}*/
			if (NPCCharList.CharFollower [i].charID >= 6000 && NPCCharList.CharFollower [i].charID < 7000 && NPCCharList.CharFollower [i].isRecruited) {
				buttFollower6000.interactable = true; 
				textFollower6000.text = "Lucina"; 
			}

			if (NPCCharList.CharFollower [i].charID == 7000 && NPCCharList.CharFollower [i].isRecruited) {
				buttFollower7000.interactable = true; 
				textFollower7000.text = "Itzel"; 
			}

			if (NPCCharList.CharFollower [i].charID == 8000 && NPCCharList.CharFollower [i].isRecruited) {
				buttFollower8000.interactable = true; 
				textFollower8000.text = "Vivica"; 
			}

			if (NPCCharList.CharFollower [i].charID == 9000 && NPCCharList.CharFollower [i].isRecruited) {
				buttFollower9000.interactable = true; 
				textFollower9000.text = "Virgil"; 
			}



			if (NPCCharList.CharFollower [i].charID == 10000 && NPCCharList.CharFollower [i].isRecruited) {
				buttFollower10000.interactable = true; 
				textFollower10000.text = "Celia"; 
			}

			if (NPCCharList.CharFollower [i].charID == 11000 && NPCCharList.CharFollower [i].isRecruited) {
				buttFollower11000.interactable = true; 
				textFollower11000.text = "Lucretius"; 
			}

			if (NPCCharList.CharFollower [i].charID == 12000 && NPCCharList.CharFollower [i].isRecruited) {
				buttFollower12000.interactable = true; 
				textFollower12000.text = "Faustina"; 
			}

			if (NPCCharList.CharFollower [i].charID == 13000 && NPCCharList.CharFollower [i].isRecruited) {
				buttFollower13000.interactable = true; 
				textFollower13000.text = "Alba"; 
			}

			if (NPCCharList.CharFollower [i].charID == 14000 && NPCCharList.CharFollower [i].isRecruited) {
				buttFollower14000.interactable = true; 
				textFollower14000.text = "Luna"; 
			}









			i++;

		}



	}

	void hideFollowers(){

		buttFollower1000.interactable = false; 
		textFollower1000.text = "???????"; 

		buttFollower3000.interactable = false; 
		textFollower3000.text = "???????"; 

		buttFollower4000.interactable = false; 
		textFollower4000.text = "???????"; 

		buttFollower5000.interactable = false; 
		textFollower5000.text = "???????"; 

		buttFollower6000.interactable = false; 
		textFollower6000.text = "???????"; 

		buttFollower7000.interactable = false; 
		textFollower7000.text = "???????"; 

		buttFollower8000.interactable = false; 
		textFollower8000.text = "???????"; 


		buttFollower9000.interactable = false; 
		textFollower9000.text = "???????"; 


		buttFollower10000.interactable = false; 
		textFollower10000.text = "???????"; 

		buttFollower11000.interactable = false; 
		textFollower11000.text = "???????"; 

		buttFollower12000.interactable = false; 
		textFollower12000.text = "???????"; 

		buttFollower13000.interactable = false; 
		textFollower13000.text = "???????"; 

		buttFollower14000.interactable = false; 
		textFollower14000.text = "???????"; 

	}



	void Start(){
		FollowerButtons();
	}

	void Awake(){

	}





}
