using UnityEngine;
using System.Collections;

public class NPCSettlerBackground {
	static int iterator = 0;
	int hashcode = GameControl.playerName.GetHashCode();
	int randNum;


	//public NPCData.BgUpgring bgUpbring;


	public NPCData.BgAdulthood setBGAdulthood(){
		iterator += 1;
		int count = (int)NPCData.BgAdulthood.Count -1;


		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return (NPCData.BgAdulthood) Random.Range (0, count); 


	}

	public NPCData.BgChildhood setBGChildhood(){
		iterator += 1;
		int count = (int)NPCData.BgChildhood.Count -1;


		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return (NPCData.BgChildhood) Random.Range (0, count); 


	}

	public NPCData.BgUpgring setUpbring(int selector){
		iterator += 1; 
		int count = (int)NPCData.BgUpgring.Count -1;



		if (selector == 1000) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			randNum = Random.Range (0, 100);
			if (randNum >= 98) {
				return NPCData.BgUpgring.Royal;
			} else if (randNum >= 94) {
				return NPCData.BgUpgring.Noble;
			} else if (randNum >= 89) {
				return NPCData.BgUpgring.VeryRich;
			} else if (randNum >= 82) {
				return NPCData.BgUpgring.Rich;
			} else if (randNum >= 67) {
				return NPCData.BgUpgring.MiddleClass;
			} else if (randNum >= 40) {
				return NPCData.BgUpgring.Poor;
			} else {
				return NPCData.BgUpgring.VeryPoor;
			}
				
		} else if (selector >= 0 && selector <= count) {
			return (NPCData.BgUpgring)selector; 
		} else {
			return NPCData.BgUpgring.VeryPoor;
		}





	}

	public float setGold(NPCData.BgUpgring upbring){
		iterator += 1; 
		int chargold; 

		switch (upbring) {
		case NPCData.BgUpgring.VeryPoor:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			chargold = Random.Range (0, 6);
			return (float)chargold;
		case NPCData.BgUpgring.Poor:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			chargold = Random.Range (4, 15);
			return (float)chargold;
		case NPCData.BgUpgring.MiddleClass:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			chargold = Random.Range (25, 50);
			return (float)chargold;
		case NPCData.BgUpgring.Rich:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			chargold = Random.Range (100, 200);
			return (float)chargold;
		case NPCData.BgUpgring.VeryRich:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			chargold = Random.Range (300, 700);
			return (float)chargold;
		case NPCData.BgUpgring.Noble:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			chargold = Random.Range (1000, 1500);
			return (float)chargold;
		case NPCData.BgUpgring.Royal:
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			chargold = Random.Range (2000, 3000);
			return (float)chargold;

		default:
			return 0f; 


		}

	}


	public string setChildStory(NPCData.BgChildhood childBG){
		return "";
	}

	public string setAdultStory( NPCData.BgAdulthood adultBG){
		return "";

	}

	public string setCurrentStory(NPCData.CharClass charClass){
		return "";


	}
}
