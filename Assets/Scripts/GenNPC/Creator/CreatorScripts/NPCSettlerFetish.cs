using UnityEngine;
using System.Collections;

public class NPCSettlerFetish  {
	static int iterator = 0;
	int randNum;
	int hashcode = GameControl.playerName.GetHashCode();


	public NPCData.CharFetish setFetish(int selector){
		iterator += 1;
		int fetishcount = (int)NPCData.CharFetish.Count -1;


		if (selector == 1000) {
			return setRandomFetish ();
		} else if (selector >= 0 && selector <= fetishcount ) {
			return (NPCData.CharFetish)selector;
		}else{ 
			return (NPCData.CharFetish)0; 
		}



	}

	//	public enum CharFetish{None, Dominant, Submissive,[Description("Anal ahore")] AnalWhore, [Description("Group sex")] GroupSex, [Description("Cum slut")]CumSlut, 
	//Incest, Crossdressing, Exhibitionism, [Description("Pet play")]PetPlay, [Description("Rape fantasy")]RapeFantasy, Voyeurism, Monsters, [Description("Size difference")]SizeDifference}; 	


	NPCData.CharFetish setRandomFetish(){
		int fetishcount = (int)NPCData.CharFetish.Count -1;
		 

		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		randNum = Random.Range (0, fetishcount);
		return (NPCData.CharFetish)randNum; 

	}




}
