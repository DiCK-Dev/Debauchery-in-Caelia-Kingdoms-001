using UnityEngine;
using System.Collections;

public class cityUpdatesEndTurn : MonoBehaviour {

	int i;
	int randNum;
	int hashcode; 

	EvidenceCreator evidenceCreator = new EvidenceCreator();










	////////////////////////////////////////////////////////////////////
	/// 
	void charMaxMinResets(){
		if(GameControl.charReputation > 1000){
			GameControl.charReputation = 1000;
		}

		if(GameControl.charReputation < -1000){
			GameControl.charReputation -= 1000;
		}

	}


	////////////////////////////////////////////////////////////////////
	 






	public void cityUpdater(){
		charMaxMinResets ();
		Taxes.dailyTax ();
	}




}
