using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PanLeftPlayerName : MonoBehaviour {

	public Text Board; 


	void Awake(){
		Board.text = GameControl.playerName;


	}


}
