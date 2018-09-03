using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LeftPanelChar : MonoBehaviour {

	//middle left panel
	public Text physAtt;
	public Text mentAtt;
	public Text socAtt; 
	public Text comType;
	public Text lustType; 
	public Text charName; 





	
	// Update is called once per frame
	void Update () {

		physAtt.text = GameControl.attPhysical.ToString(); 
		mentAtt.text = GameControl.attMental.ToString();
		socAtt.text = GameControl.attSocial.ToString(); 
		comType.text = GameControl.charCorruption.ToString();
		lustType.text = GameControl.charGold.ToString(); 
	
	}
}
