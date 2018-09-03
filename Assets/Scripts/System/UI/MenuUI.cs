using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuUI : MonoBehaviour {

	//top right panel
	public Text textDay; 
	public Text textTime;


	//middle left panel

	public Text physAtt;
	public Text mentAtt;
	public Text socAtt; 
	public Text charCorruption;
	public Text charGold; 
	public Text charName; 




	void Start () 
	{
		textDay.text = WorldControl.day.ToString();
		textTime.text = WorldControl.dayTimeName; 
		charName.text = GameControl.playerName;
	}

	void Update () {


		physAtt.text = GameControl.attPhysical.ToString(); 
		mentAtt.text = GameControl.attMental.ToString();
		socAtt.text = GameControl.attSocial.ToString(); 
		charCorruption.text = GameControl.charCorruption.ToString();
		charGold.text = GameControl.charGold.ToString();  // gold 


	}
}
