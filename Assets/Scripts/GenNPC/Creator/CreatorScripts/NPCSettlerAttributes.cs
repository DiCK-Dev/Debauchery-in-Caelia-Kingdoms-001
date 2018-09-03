using UnityEngine;
using System.Collections;

public class NPCSettlerAttributes : MonoBehaviour {
	int hashcode =  GameControl.playerName.GetHashCode();
	int randNum;
	static int iterator = 0; 

	float attPhysical;  
	float attMental; 
	float attSocial; 

	public float setPhysical(NPCData.CharClass charClass){
		iterator += 1;
		if (charClass == NPCData.CharClass.Alchemist) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 40);
		}

		if (charClass == NPCData.CharClass.Artist) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 40);

		}
		if (charClass == NPCData.CharClass.Barbarian) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (60, 90);

		}
		if (charClass == NPCData.CharClass.Bureaucrat) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 40);

		}
		if (charClass == NPCData.CharClass.Clerk) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 40);

		}
		if (charClass == NPCData.CharClass.CommunityWorker) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 55);

		}
		if (charClass == NPCData.CharClass.Diplomat) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 45);

		}
		if (charClass == NPCData.CharClass.DarkPaladin) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (60, 85);

		}
		if (charClass == NPCData.CharClass.Enforcer) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (50, 80);

		}
		if (charClass == NPCData.CharClass.Farmer) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (30, 90);

		}
		if (charClass == NPCData.CharClass.Feral) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (70, 95);

		}
		if (charClass == NPCData.CharClass.GuildWorker) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (30, 70);

		}
		if (charClass == NPCData.CharClass.Inquisitor) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (30, 60);

		}
		if (charClass == NPCData.CharClass.Infiltrator) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (30, 60);

		}
		if (charClass == NPCData.CharClass.Monk) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (30, 60);

		}
		if (charClass == NPCData.CharClass.Mystic) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 40);

		}
		if (charClass == NPCData.CharClass.Paladin) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (60, 85);

		}
		if (charClass == NPCData.CharClass.Performer) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (50, 80);

		}
		if (charClass == NPCData.CharClass.Politician) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 40);

		}
		if (charClass == NPCData.CharClass.Priest) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 40);

		}
		if (charClass == NPCData.CharClass.Ranger) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (50, 80);

		}
		if (charClass == NPCData.CharClass.Scholar) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 40);

		}
		if (charClass == NPCData.CharClass.Scout) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (50, 80);

		}
		if (charClass == NPCData.CharClass.Soldier) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (0, 100);

		}
		if (charClass == NPCData.CharClass.Thief) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (50, 80);

		}
		if (charClass == NPCData.CharClass.Warrior) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (60, 85);

		}
		if (charClass == NPCData.CharClass.Whore) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 50);

		}




		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return Random.Range (35, 70);



	}







	public float setMental(NPCData.CharClass charClass)
	{
		iterator += 1;
		if (charClass == NPCData.CharClass.Alchemist) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (50, 90);
		}

		if (charClass == NPCData.CharClass.Artist) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (40, 65);

		}
		if (charClass == NPCData.CharClass.Barbarian) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 40);

		}
		if (charClass == NPCData.CharClass.Bureaucrat) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (40, 80);

		}
		if (charClass == NPCData.CharClass.Clerk) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (40, 80);

		}
		if (charClass == NPCData.CharClass.CommunityWorker) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (30, 60);

		}
		if (charClass == NPCData.CharClass.Diplomat) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (30, 60);

		}
		if (charClass == NPCData.CharClass.DarkPaladin) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (30, 65);

		}
		if (charClass == NPCData.CharClass.Enforcer) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 45);

		}
		if (charClass == NPCData.CharClass.Farmer) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 50);

		}
		if (charClass == NPCData.CharClass.Feral) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (10, 30);

		}
		if (charClass == NPCData.CharClass.GuildWorker) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (40, 65);

		}
		if (charClass == NPCData.CharClass.Inquisitor) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (50, 85);

		}
		if (charClass == NPCData.CharClass.Infiltrator) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (30, 50);

		}
		if (charClass == NPCData.CharClass.Monk) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (40, 70);

		}
		if (charClass == NPCData.CharClass.Mystic) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (60, 90);

		}
		if (charClass == NPCData.CharClass.Paladin) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 55);

		}
		if (charClass == NPCData.CharClass.Performer) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 80);

		}
		if (charClass == NPCData.CharClass.Politician) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (35, 70);

		}
		if (charClass == NPCData.CharClass.Priest) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (35, 70);

		}
		if (charClass == NPCData.CharClass.Ranger) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 45);

		}
		if (charClass == NPCData.CharClass.Scholar) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (60, 90);

		}
		if (charClass == NPCData.CharClass.Scout) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (30, 60);

		}
		if (charClass == NPCData.CharClass.Soldier) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 50);

		}
		if (charClass == NPCData.CharClass.Thief) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 50);

		}
		if (charClass == NPCData.CharClass.Warrior) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 45);

		}
		if (charClass == NPCData.CharClass.Whore) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (15, 40);

		}




		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return Random.Range (35, 70);
	}










	public float setSocial(NPCData.CharClass charClass)
	{
		
		iterator += 1;
		if (charClass == NPCData.CharClass.Alchemist) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 60);
		}

		if (charClass == NPCData.CharClass.Artist) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (50, 90);

		}
		if (charClass == NPCData.CharClass.Barbarian) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 55);

		}
		if (charClass == NPCData.CharClass.Bureaucrat) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 50);

		}
		if (charClass == NPCData.CharClass.Clerk) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 50);

		}
		if (charClass == NPCData.CharClass.CommunityWorker) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (55, 90);

		}
		if (charClass == NPCData.CharClass.Diplomat) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (60, 90);

		}
		if (charClass == NPCData.CharClass.DarkPaladin) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (35, 60);

		}
		if (charClass == NPCData.CharClass.Enforcer) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 60);

		}
		if (charClass == NPCData.CharClass.Farmer) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 60);

		}
		if (charClass == NPCData.CharClass.Feral) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 50);

		}
		if (charClass == NPCData.CharClass.GuildWorker) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 50);

		}
		if (charClass == NPCData.CharClass.Inquisitor) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (40, 75);

		}
		if (charClass == NPCData.CharClass.Infiltrator) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (50, 90);

		}
		if (charClass == NPCData.CharClass.Monk) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (55, 85);

		}
		if (charClass == NPCData.CharClass.Mystic) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 60);

		}
		if (charClass == NPCData.CharClass.Paladin) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (40, 70);

		}
		if (charClass == NPCData.CharClass.Performer) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (55, 90);

		}
		if (charClass == NPCData.CharClass.Politician) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (55, 90);

		}
		if (charClass == NPCData.CharClass.Priest) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (55, 90);

		}
		if (charClass == NPCData.CharClass.Ranger) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (30, 60);

		}
		if (charClass == NPCData.CharClass.Scholar) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 55);

		}
		if (charClass == NPCData.CharClass.Scout) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 55);

		}
		if (charClass == NPCData.CharClass.Soldier) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 50);

		}
		if (charClass == NPCData.CharClass.Thief) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (30, 60);

		}
		if (charClass == NPCData.CharClass.Warrior) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (20, 50);

		}
		if (charClass == NPCData.CharClass.Whore) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (40, 90);

		}


		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return Random.Range (35, 70);
	}



	public float setMagicPower(NPCData.CharClass charClass)
	{

		iterator += 1;
		if (charClass == NPCData.CharClass.Alchemist) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (0, 21);
		}


		if (charClass == NPCData.CharClass.DarkPaladin) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 21);

		}
			
		if (charClass == NPCData.CharClass.Monk) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (0, 11);

		}
		if (charClass == NPCData.CharClass.Mystic) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (25, 95);

		}


		if (charClass == NPCData.CharClass.Priest) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (0, 11);

		}

		if (charClass == NPCData.CharClass.Scholar) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (0, 26);

		}
		if (charClass == NPCData.CharClass.Inquisitor) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (0, 16);

		}




	
		return 0;
	}








}
