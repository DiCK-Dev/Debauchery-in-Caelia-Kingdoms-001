using UnityEngine;
using System.Collections;

public class NPCSettlerPosition : MonoBehaviour {
	static int iterator = 0;
	int hashcode = GameControl.playerName.GetHashCode();
	int randNum;


	public NPCData.Jobs setPosition(int selector){
		int nameCount = (int)NPCData.Jobs.Count -1;
		if (selector > nameCount) {
			selector = 0; 
		}

		if (selector == 1000) {
			return NPCData.Jobs.NONE;

		} else if (selector < nameCount) {
			return (NPCData.Jobs)selector;

		} else {
			return NPCData.Jobs.NONE;
		}

	}


	public float setCharReputation(NPCData.Jobs cityPos, NPCData.CharClass charClass){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
	
		float retvalue = 0;

		switch (cityPos) 
		{
		case NPCData.Jobs.GRANDPRIESTESS:
			retvalue = Random.Range (-300, 350);
			break; 
		case NPCData.Jobs.GRANDINQUISITOR:
			retvalue = Random.Range (-350, 300);
			break; 

		default:
			break;
		}

		switch (charClass) {
		case NPCData.CharClass.Alchemist:
			return retvalue += Random.Range (-50, 70);
		case NPCData.CharClass.Artist:
			return retvalue += Random.Range (-20, 50);
		case NPCData.CharClass.Barbarian:
			return retvalue += Random.Range (-50, 20);
		case NPCData.CharClass.Bureaucrat:
			return retvalue += Random.Range (-30, 30);
		case NPCData.CharClass.CommunityWorker:
			return retvalue += Random.Range (-10, 30);
		case NPCData.CharClass.DarkPaladin:
			return retvalue += Random.Range (-70, -10);
		case NPCData.CharClass.Diplomat:
			return retvalue += Random.Range (-50, 70);
		case NPCData.CharClass.Enforcer:
			return retvalue += Random.Range (-20, 20);
		case NPCData.CharClass.Feral:
			return retvalue += Random.Range (-50, 20);
		case NPCData.CharClass.Mystic:
			return retvalue += Random.Range (-50, 70);
		case NPCData.CharClass.Monk:
			return retvalue += Random.Range (-15, 30);
		case NPCData.CharClass.Paladin:
			return retvalue += Random.Range (10, 70);
		case NPCData.CharClass.Performer:
			return retvalue += Random.Range (-10, 30);
		case NPCData.CharClass.Politician:
			return retvalue += Random.Range (-90, 70);
		case NPCData.CharClass.Priest:
			return retvalue += Random.Range (-30, 70);
		case NPCData.CharClass.Scholar:
			return retvalue += Random.Range (-20, 90);
		case NPCData.CharClass.Soldier:
			return retvalue += Random.Range (-20, 20);
		case NPCData.CharClass.Warrior:
			return retvalue += Random.Range (-30, 30);
		case NPCData.CharClass.Whore:
			return retvalue += Random.Range (-50, 20);
		case NPCData.CharClass.Thief:
			return retvalue += Random.Range (-50, 70);

		default:
			
			return retvalue += retvalue + Random.Range (-10, 10) ;
		}



	}




	public float setPoliticalPower(NPCData.Jobs cityPos){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		float retvalue = 0;

		switch (cityPos) 
		{
		case NPCData.Jobs.GRANDPRIESTESS:
			return retvalue = Random.Range (20, 200);

		case NPCData.Jobs.GRANDINQUISITOR:
			return retvalue = Random.Range (30, 240);

		default:
			return 0;
		}

	}



}
