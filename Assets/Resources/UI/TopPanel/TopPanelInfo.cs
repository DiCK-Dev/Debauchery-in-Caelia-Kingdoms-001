using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TopPanelInfo : MonoBehaviour {

	public Text textLocation;
	public Text textName;
	public Text textGold;
	public Text textCorruption;

	public Text textDay;
	public Text textTime;
	public Text textSupplies; 

	string strgold;
	string strcorruption;
	string strday; 


	void Start () {

		textTime.text = WorldControl.dayTimeName;

		textName.text = GameControl.playerName;
		textLocation.text = WorldControl.location;
		strday = WorldControl.day.ToString ();
		textDay.text = "Day: " + strday;
		textSupplies.text = "Castle supplies: " + CastleController.castleSupplies.ToString();

	
	}

	void Update(){
		strgold = GameControl.charGold.ToString ();
		int charCorr = (int)GameControl.charCorruption;
		strcorruption = charCorr.ToString ();


		textGold.text = "Gold: " + strgold;
		textCorruption.text = "Corruption: " + strcorruption;
		textSupplies.text = "Castle supplies: " + CastleController.castleSupplies.ToString();

	}
	




}
