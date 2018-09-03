using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class BordelloScene : MonoBehaviour {

	public Text Board; 
	public RectTransform EndTurnPanel; 
	public Button bordelloRepairButt; 

	void BordelloStart (){
		if (CityControl.city100BordelloMeet == false) 
		{
			Board.text = "You enter the Bordello for the first time and are impressed"; 
			CityControl.city100BordelloMeet  = true; 
			EndTurnPanel.SetAsLastSibling ();
		}else
		{
			if (CityControl.city100Corruption >= 100) {
				Board.text = "the bordello scene of corruption at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption > 90) {
				Board.text = "the bordello scene of corruption at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption > 70) {
				Board.text = "the bordello scene of corruption at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption > 50) {
				Board.text = "the bordello scene of corruption att " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption > 30) {
				Board.text = "the bordello scene of corruption at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption > 10) {
				Board.text = "the bordello scene of corruption at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption >= 0) {
				Board.text = "the agora scene of corruption at " + CityControl.city100Corruption;
			} 

		}

	}



	public void BordelloRepairText(){
		if (CityControl.city100BordelloLevel == 0) {
			Board.text = "It will cost you 500 gold to repair this, proceed?"; 
		} else if (CityControl.city100BordelloLevel == 1){
			Board.text = "It will cost you 1500 gold to repair this, proceed?";
		} else if (CityControl.city100BordelloLevel == 2){
			Board.text = "It will cost you 2000 gold to repair this, proceed?";
		}else {
			Board.text = "This place is fully repaired"; 
		}

	}
	public void BordelloRepair(){


		if (CityControl.city100BordelloLevel == 0) {
			GameControl.charGold = GameControl.charGold - 500; 
			CityControl.city100ColosseumLevel = 1;
			EndTurnPanel.SetAsLastSibling ();
			Board.text = "You repaired the Bordello!"; 
		} else if (CityControl.city100BordelloLevel == 0) {
			GameControl.charGold = GameControl.charGold - 1500; 
			CityControl.city100BordelloLevel = 2;
			EndTurnPanel.SetAsLastSibling ();
			Board.text = "You repaired the Bordello!"; 

		}

	}



	void Awake (){
		BordelloStart ();
		WorldControl.location = "Aurorum - Bordello"; 


	}

	void Start () {
		if (CityControl.city100BordelloLevel == 0) 
		{
			if (GameControl.charGold >= 500) {

			} else {
				bordelloRepairButt.GetComponent<Button> ().interactable = false; 
			}
		}
		if (CityControl.city100BordelloLevel == 1) {
			if (GameControl.charGold >= 1500) {

			} else {
				bordelloRepairButt.GetComponent<Button> ().interactable = false; 
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
