using UnityEngine;
using System.Collections;

public class enemySlaves : MonoBehaviour {

	//this will make them slaves once they are captured, the switch follows the enemy id
	public void makeEnemySlave(){
		switch(WorldControl.NPCID){
		case 100:
			//bunny girl
			CityControl.city100Slaves [0] += 1; 
			if (CityControl.city100Slaves [0] < 3) {
				CityControl.city100Prosperity += 1; 
			}
			break;
		case 110: 
			CityControl.city100Slaves[1] +=1; 
			//wolf
			break;
		case 120:
			CityControl.city100Slaves[2]+=1; 
			//plantgirl
			break;
		case 130:
			CityControl.city100Slaves [3] += 1;
			//dodo girl
			break;
		case 140:
			CityControl.city100Slaves [4] += 1;
			//equine
			break; 
		default:

			break;
		}




	}





	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
