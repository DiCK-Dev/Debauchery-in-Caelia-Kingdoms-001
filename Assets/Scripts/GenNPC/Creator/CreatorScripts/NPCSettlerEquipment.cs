using UnityEngine;
using System.Collections;

public class NPCSettlerEquipment {
	static int iterator = 0;
	int hashcode = GameControl.playerName.GetHashCode();
	int randNum;


	//1000 weapons, 2000 armor, 3000 head, 4000 face, 5000 neck, 6000 shoulders, 7000 arms, 8000 legs, 9000 make up, 10000 ring, 11000 amulet, 12000 trophy
	//public int[] charEquipment = new int[12];

	public int setCharEquipment(int selector, NPCData.BgUpgring upbring, NPCData.CharClass charClass, NPCData.CharRace charRace){
		iterator += 1;
		switch (selector) {
		case 0: 
			return setWeapon (upbring, charClass);
		case 1: 
			return setArmour (upbring, charClass, charRace);
		case 2: 
			return setHead (upbring, charClass);
		case 3: 
			return setFace (upbring, charClass);
		case 4: 
			return setNeck (upbring, charClass);
		case 5: 
			return setShoulder (upbring, charClass);
		case 6: 
			return setArms (upbring, charClass);
		case 7: 
			return setLegs (upbring, charClass);		
		case 8: 
			return setMakeUp (upbring, charClass);
		case 9: 
			return setRing (upbring, charClass);
		case 10: 
			return setAmulet (upbring, charClass);
		case 11: 
			return setTrophy (upbring, charClass);
		default: 
			return 0; 

		}



	}




	/// <summary>
	/// Sets the weapon.
	/// </summary>
	/// <returns>The weapon.</returns>
	/// <param name="upbring">Upbring.</param>
	/// <param name="charClass">Char class.</param>




	int setWeapon(NPCData.BgUpgring upbring, NPCData.CharClass charClass)
	{
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator + 50); 
		randNum = Random.Range (0, 100);

		if (upbring == NPCData.BgUpgring.Royal)
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Inquisitor:
				return 10014;
			case NPCData.CharClass.Barbarian:
				return 10007;
			case NPCData.CharClass.DarkPaladin:
				return 10015;
			case NPCData.CharClass.Paladin:
				return 10015;
			case NPCData.CharClass.Enforcer:
				return 10008; 
			case NPCData.CharClass.Monk:
				return 10014;
			default:
				if (randNum > 66) {
					return 10020; 
				} else if (randNum > 33) {
					return 10021; 
				} else {
					return 10009; 
				}
				

			}

		}
		//////////



		if (upbring == NPCData.BgUpgring.Rich || upbring == NPCData.BgUpgring.VeryRich || upbring == NPCData.BgUpgring.Noble) 
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Inquisitor:
				return 10014;
			case NPCData.CharClass.Barbarian:
				return 10007;
			case NPCData.CharClass.DarkPaladin:
				return 10015;
			case NPCData.CharClass.Paladin:
				return 10015;
			case NPCData.CharClass.Enforcer:
				return 10008; 
			case NPCData.CharClass.Soldier:
				return 10019;
			case NPCData.CharClass.Monk:
				return 10014;

			default:
				if (randNum > 66) {
					return 10020; 
				} else if (randNum > 33) {
					return 10015; 
				} else {
					return 10007; 
				}

			}

		}



		//////////

		if (upbring == NPCData.BgUpgring.MiddleClass)
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Soldier:
				return 10019;
			case NPCData.CharClass.Inquisitor:
				return 10013;
			case NPCData.CharClass.Monk:
				return 10013;

			default:
				if (randNum > 66) {
					return 10002; 
				} else if (randNum > 33) {
					return 10001; 
				} else {
					return 10010; 
				}

			}

		}

		//////////

		if (upbring == NPCData.BgUpgring.Poor || upbring == NPCData.BgUpgring.VeryPoor)
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Soldier:
				return 10001;
			case NPCData.CharClass.Warrior:
				return 10001;
			case NPCData.CharClass.Barbarian:
				return 10017;
			case NPCData.CharClass.Inquisitor:
				return 10013;
			case NPCData.CharClass.Monk:
				return 10013;

			default:
				if (randNum > 66) 
				{
					return 10016; 
				} else if (randNum > 33)
				{
					return 10018; 
				} else 
				{
					return 10017; 
				}
			}
		}

		return 10001;

	}


	/// <summary>
	/// Sets the armour.
	/// </summary>
	/// <returns>The armour.</returns>
	/// <param name="upbring">Upbring.</param>
	/// <param name="charClass">Char class.</param>




	int setArmour(NPCData.BgUpgring upbring, NPCData.CharClass charClass, NPCData.CharRace charRace)
	{
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator + 50); 
		randNum = Random.Range (0, 100);

		switch (charRace) {
		case NPCData.CharRace.Elf:
			if (charClass == NPCData.CharClass.DarkPaladin || charClass == NPCData.CharClass.Paladin || charClass == NPCData.CharClass.Warrior || charClass == NPCData.CharClass.Soldier || charClass == NPCData.CharClass.Inquisitor) {
				return 20025; // we need to add the armor
			} else {
				if (randNum > 80) {
					return 20028;
				} else {
					return 20026; // we need to add the armor
				}

			}
		default:
			break;
		}


		if (upbring == NPCData.BgUpgring.Rich || upbring == NPCData.BgUpgring.VeryRich || upbring == NPCData.BgUpgring.Noble) 
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Soldier:
				return 20002;
			case NPCData.CharClass.Inquisitor:
				return 20017;
			case NPCData.CharClass.Paladin:
				return 20019;
			case NPCData.CharClass.Monk:
				return 20009;
			case NPCData.CharClass.Priest:
				return 20009;
			case NPCData.CharClass.Scholar:
				return 20009;
			case NPCData.CharClass.DarkPaladin:
				if (randNum > 50) {
					return 20028;
				} else {
					return 20019; // we need to add the armor
				}

			default:
				if (randNum > 95) {
					return 20028; 
				}else if (randNum > 80) {
					if (charRace == NPCData.CharRace.Wolf) {
						return 20010;
					}
					return 20011; 
				}else if (randNum > 50) {
					return 20003; 
				} else {
					return 20010; 
				}


			}

		}

		//////////

		if (upbring == NPCData.BgUpgring.Royal)
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Soldier:
				return 20003;
			case NPCData.CharClass.Inquisitor:
				return 20017;
			case NPCData.CharClass.Paladin:
				return 20019;
			case NPCData.CharClass.DarkPaladin:
				return 20019;
			case NPCData.CharClass.Monk:
				return 20009;
			case NPCData.CharClass.Priest:
				return 20009;
			case NPCData.CharClass.Scholar:
				return 20009;

			default:
				if (randNum > 90) {
					return 20028; 
				}else if (randNum > 75) {
					return 20004; 
				} else {
					if (charRace == NPCData.CharRace.Wolf) {
						return 20004;
					}
					return 20011; 
				}
			}

		}

		//////////

		if (upbring == NPCData.BgUpgring.MiddleClass)
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Soldier:
				return 20001;
			case NPCData.CharClass.Inquisitor:
				return 20017;
			case NPCData.CharClass.Paladin:
				return 20022;
			case NPCData.CharClass.DarkPaladin:
				return 20022;
			case NPCData.CharClass.Monk:
				return 20009;
			case NPCData.CharClass.Priest:
				return 20009;
			case NPCData.CharClass.Scholar:
				return 20009;

			default:
				if (randNum > 90) {
					return 20028; 
				} else if (randNum > 70) {
					return 20021; 
				} else if (randNum > 65) {
					return 20029; 
				} else {
					return 20008; 
				} 
			}

		}

		//////////

		if (upbring == NPCData.BgUpgring.Poor || upbring == NPCData.BgUpgring.VeryPoor)
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Soldier:
				return 20015;
			case NPCData.CharClass.Inquisitor:
				return 20017;
			case NPCData.CharClass.Paladin:
				return 20023;
			case NPCData.CharClass.DarkPaladin:
				return 20023;
			case NPCData.CharClass.Monk:
				return 20009;
			case NPCData.CharClass.Priest:
				return 20009;
			case NPCData.CharClass.Scholar:
				return 20009;


			default:
				if (randNum > 90) {
					return 20028; 
				}else if (randNum > 75) {
					return 20016; 
				} else if (randNum > 60) {
					return 20029; 
				}  else {
					return 20020; 
				}
			}
		}

		return 20001;

	}



	/// <summary>
	/// Sets the head.
	/// </summary>
	/// <returns>The head.</returns>
	/// <param name="upbring">Upbring.</param>
	/// <param name="charClass">Char class.</param>



	int setHead(NPCData.BgUpgring upbring, NPCData.CharClass charClass)
	{

		if (upbring == NPCData.BgUpgring.Royal)
		{
			switch (charClass) 
			{

			case NPCData.CharClass.Inquisitor:
				return 30008;
			case NPCData.CharClass.Politician:
				return 30006;

			default:
				if (randNum > 80) 
				{
					return 30006; 
				} else 
				{
					return 30005; 
				}
			}

		}
		//////////

		if (upbring == NPCData.BgUpgring.Rich || upbring == NPCData.BgUpgring.VeryRich || upbring == NPCData.BgUpgring.Noble) 
		{
			switch (charClass) 
			{

			case NPCData.CharClass.Inquisitor:
				return 30008;
			case NPCData.CharClass.Politician:
				return 30005;
			default:
				if (randNum > 80) 
				{
					return 30005; 
				} else 
				{
					return 30004; 
				}
			}

		}




		//////////

		if (upbring == NPCData.BgUpgring.MiddleClass)
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Inquisitor:
				return 30008;
			case NPCData.CharClass.Politician:
				return 30008;

			default:
				if (randNum > 80) 
				{
					return 30008; 
				} else 
				{
					return 30009; 
				} 
			}

		}

		//////////

		if (upbring == NPCData.BgUpgring.Poor || upbring == NPCData.BgUpgring.VeryPoor)
		{
			switch (charClass) 
			{

			case NPCData.CharClass.Inquisitor:
				return 30008;
			case NPCData.CharClass.Politician:
				return 30009;
			default:
				if (randNum > 80) 
				{
					return 30003; 
				} else 
				{
					return 30000; 
				} 
			}
		}

		return 30001;

	}

	/// <summary>
	/// Sets the face.
	/// </summary>
	/// <returns>The face.</returns>
	/// <param name="upbring">Upbring.</param>
	/// <param name="charClass">Char class.</param>



	int setFace(NPCData.BgUpgring upbring, NPCData.CharClass charClass)
	{

		if (upbring == NPCData.BgUpgring.Royal)
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Scholar:
				return 40003;
			case NPCData.CharClass.Warrior:
				return 40002;

			default:
				if (randNum > 80) 
				{
					return 40005; 
				} else 
				{
					return 40000; 
				} 
			}

		}


		//////////


		if (upbring == NPCData.BgUpgring.Rich || upbring == NPCData.BgUpgring.VeryRich || upbring == NPCData.BgUpgring.Noble) 
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Scholar:
				return 40003;
			case NPCData.CharClass.Warrior:
				return 40002;

			default:
				if (randNum > 80) 
				{
					return 40005; 
				} else 
				{
					return 40000; 
				} 
			}

		}





		//////////

		if (upbring == NPCData.BgUpgring.MiddleClass)
		{
			switch (charClass) 
			{

			default:
				if (randNum > 80) 
				{
					return 40001; 
				} else 
				{
					return 40000; 
				} 
			}

		}

		//////////

		if (upbring == NPCData.BgUpgring.Poor || upbring == NPCData.BgUpgring.VeryPoor)
		{
			switch (charClass) 
			{

			default:
				if (randNum > 80) 
				{
					return 40001; 
				} else 
				{
					return 40000; 
				} 
			}
		}

		return 40001;

	}


	/// <summary>
	/// Sets the neck.
	/// </summary>
	/// <returns>The neck.</returns>
	/// <param name="upbring">Upbring.</param>
	/// <param name="charClass">Char class.</param>

	int setNeck(NPCData.BgUpgring upbring, NPCData.CharClass charClass)
	{


		if (upbring == NPCData.BgUpgring.Royal)
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Soldier:
				return 50002;
			case NPCData.CharClass.DarkPaladin:
				return 50002;
			case NPCData.CharClass.Paladin:
				return 50002; 
			default:
				if (randNum > 80) 
				{
					return 50006; 
				} else 
				{
					return 50007; 
				} 
			}

		}

		//////////

		if (upbring == NPCData.BgUpgring.Rich || upbring == NPCData.BgUpgring.VeryRich || upbring == NPCData.BgUpgring.Noble) 
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Soldier:
				return 50002;
			case NPCData.CharClass.DarkPaladin:
				return 50002;
			case NPCData.CharClass.Paladin:
				return 50002; 

			default:
				if (randNum > 80) 
				{
					return 50006; 
				} else 
				{
					return 50007; 
				} 
			}

		}



		//////////

		if (upbring == NPCData.BgUpgring.MiddleClass)
		{
			switch (charClass) 
			{

			default:
				if (randNum > 80) 
				{
					return 50005; 
				} else 
				{
					return 50000; 
				} 
			}

		}

		//////////

		if (upbring == NPCData.BgUpgring.Poor || upbring == NPCData.BgUpgring.VeryPoor)
		{
			switch (charClass) 
			{

			default:
				if (randNum > 80) 
				{
					return 50003; 
				} else 
				{
					return 50000; 
				} 
			}
		}

		return 10001;

	}

	/// <summary>
	/// Sets the shoulder.
	/// </summary>
	/// <returns>The shoulder.</returns>
	/// <param name="upbring">Upbring.</param>
	/// <param name="charClass">Char class.</param>


	int setShoulder(NPCData.BgUpgring upbring, NPCData.CharClass charClass)
	{


		if (upbring == NPCData.BgUpgring.Royal)
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Soldier:
				return 60007;
			case NPCData.CharClass.DarkPaladin:
				return 60005;
			case NPCData.CharClass.Paladin:
				return 60005; 

			default:
				if (randNum > 80) 
				{
					return 60001; 
				} else 
				{
					return 60000; 
				} 
			}

		}

		//////////

		if (upbring == NPCData.BgUpgring.Rich || upbring == NPCData.BgUpgring.VeryRich || upbring == NPCData.BgUpgring.Noble) 
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Soldier:
				return 60006;
			case NPCData.CharClass.DarkPaladin:
				return 60005;
			case NPCData.CharClass.Paladin:
				return 60005; 

			default:
				if (randNum > 80) 
				{
					return 60001; 
				} else 
				{
					return 60000; 
				} 
			}

		}




		//////////

		if (upbring == NPCData.BgUpgring.MiddleClass)
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Soldier:
				return 60004;
			case NPCData.CharClass.DarkPaladin:
				return 60004;
			case NPCData.CharClass.Paladin:
				return 60004; 

			default:
				if (randNum > 80) 
				{
					return 60002; 
				} else 
				{
					return 60000; 
				} 
			}

		}

		//////////

		if (upbring == NPCData.BgUpgring.Poor || upbring == NPCData.BgUpgring.VeryPoor)
		{
			switch (charClass) 
			{

			default:
				return 60000; 
			}
		}

		return 60001;

	}




	/// <summary>
	/// Sets the arms.
	/// </summary>
	/// <returns>The arms.</returns>
	/// <param name="upbring">Upbring.</param>
	/// <param name="charClass">Char class.</param>

	int setArms(NPCData.BgUpgring upbring, NPCData.CharClass charClass)
	{

		if (upbring == NPCData.BgUpgring.Royal)
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Soldier:
				return 70001;
			case NPCData.CharClass.DarkPaladin:
				return 70001;
			case NPCData.CharClass.Paladin:
				return 70001; 

			default:
				if (randNum > 80) 
				{
					return 70000; 
				} else 
				{
					return 70000; 
				} 
			}

		}

		//////////
		/// 
		if (upbring == NPCData.BgUpgring.Rich || upbring == NPCData.BgUpgring.VeryRich || upbring == NPCData.BgUpgring.Noble) 
		{
			switch (charClass) 
			{

			case NPCData.CharClass.Soldier:
				return 70001;
			case NPCData.CharClass.DarkPaladin:
				return 70001;
			case NPCData.CharClass.Paladin:
				return 70001; 
			default:
				if (randNum > 80) 
				{
					return 70000; 
				} else 
				{
					return 70000; 
				} 
			}

		}





		//////////

		if (upbring == NPCData.BgUpgring.MiddleClass)
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Soldier:
				return 70001;
			case NPCData.CharClass.DarkPaladin:
				return 70001;
			case NPCData.CharClass.Paladin:
				return 70001; 

			default:
				if (randNum > 80) 
				{
					return 70007; 
				} else 
				{
					return 70000; 
				} 
			}

		}

		//////////

		if (upbring == NPCData.BgUpgring.Poor || upbring == NPCData.BgUpgring.VeryPoor)
		{
			switch (charClass) 
			{

			default:
				if (randNum > 80) 
				{
					return 70006; 
				} else 
				{
					return 70000; 
				} 
			}
		}

		return 70000;

	}



	/// <summary>
	/// Sets the legs.
	/// </summary>
	/// <returns>The legs.</returns>
	/// <param name="upbring">Upbring.</param>
	/// <param name="charClass">Char class.</param>

	int setLegs(NPCData.BgUpgring upbring, NPCData.CharClass charClass)
	{
		if (upbring == NPCData.BgUpgring.Royal)
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Soldier:
				return 80002;
			case NPCData.CharClass.DarkPaladin:
				return 80002;
			case NPCData.CharClass.Paladin:
				return 80002; 

			default:
				if (randNum > 80) 
				{
					return 80003; 
				} else 
				{
					return 80006; 
				} 
			}

		}


		//////////

		if (upbring == NPCData.BgUpgring.Rich || upbring == NPCData.BgUpgring.VeryRich || upbring == NPCData.BgUpgring.Noble) 
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Soldier:
				return 80002;
			case NPCData.CharClass.DarkPaladin:
				return 80002;
			case NPCData.CharClass.Paladin:
				return 80002; 
			default:
				if (randNum > 80) 
				{
					return 80003; 
				} else 
				{
					return 80006; 
				} 
			}

		}




		//////////

		if (upbring == NPCData.BgUpgring.MiddleClass)
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Soldier:
				return 80002;
			case NPCData.CharClass.DarkPaladin:
				return 80002;
			case NPCData.CharClass.Paladin:
				return 80002; 

			default:
				if (randNum > 80) 
				{
					return 80007; 
				} else 
				{
					return 80007; 
				} 
			}

		}

		//////////

		if (upbring == NPCData.BgUpgring.Poor || upbring == NPCData.BgUpgring.VeryPoor)
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Soldier:
				return 80001;
			case NPCData.CharClass.DarkPaladin:
				return 80001;
			case NPCData.CharClass.Paladin:
				return 80001; 

			default:
				if (randNum > 80) 
				{
					return 80007; 
				} else 
				{
					return 80000; 
				} 
			}
		}

		return 80007;

	}



	/// <summary>
	/// Sets the make up.
	/// </summary>
	/// <returns>The make up.</returns>
	/// <param name="upbring">Upbring.</param>
	/// <param name="charClass">Char class.</param>

	int setMakeUp(NPCData.BgUpgring upbring, NPCData.CharClass charClass)
	{


		if (upbring == NPCData.BgUpgring.Royal)
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Barbarian:
				return 90003;
			case NPCData.CharClass.Feral:
				return 90003;
			case NPCData.CharClass.Whore:
				return 90002;

			default:
				if (randNum > 80) 
				{
					return 90000; 
				} else 
				{
					return 90004; 
				} 
			}

		}

		//////////


		if (upbring == NPCData.BgUpgring.Rich || upbring == NPCData.BgUpgring.VeryRich || upbring == NPCData.BgUpgring.Noble) 
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Barbarian:
				return 90003;
			case NPCData.CharClass.Feral:
				return 90003;
			case NPCData.CharClass.Whore:
				return 90002;

			default:
				if (randNum > 80) 
				{
					return 90000; 
				} else 
				{
					return 90004; 
				} 
			}

		}




		//////////

		if (upbring == NPCData.BgUpgring.MiddleClass)
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Barbarian:
				return 90003;
			case NPCData.CharClass.Feral:
				return 90003;
			case NPCData.CharClass.Whore:
				return 90002;


			default:
				if (randNum > 80) 
				{
					return 90004; 
				} else 
				{
					return 90000; 
				} 
			}

		}

		//////////

		if (upbring == NPCData.BgUpgring.Poor || upbring == NPCData.BgUpgring.VeryPoor)
		{
			switch (charClass) 
			{
			case NPCData.CharClass.Barbarian:
				return 90003;
			case NPCData.CharClass.Feral:
				return 90003;
			case NPCData.CharClass.Whore:
				return 90002;


			default:
				if (randNum > 80) 
				{
					return 90001; 
				} else 
				{
					return 90000; 
				}
			}
		}

		return 90000;

	}


	/// <summary>
	/// Sets the ring.
	/// </summary>
	/// <returns>The ring.</returns>
	/// <param name="upbring">Upbring.</param>
	/// <param name="charClass">Char class.</param>



	int setRing(NPCData.BgUpgring upbring, NPCData.CharClass charClass)
	{
		if (upbring == NPCData.BgUpgring.Rich || upbring == NPCData.BgUpgring.VeryRich || upbring == NPCData.BgUpgring.Noble) 
		{
			switch (charClass) 
			{

			default:
				return 100000; 
			}

		}

		//////////

		if (upbring == NPCData.BgUpgring.Royal)
		{
			switch (charClass) 
			{

			default:
				return 100000; 
			}

		}

		//////////

		if (upbring == NPCData.BgUpgring.MiddleClass)
		{
			switch (charClass) 
			{

			default:
				return 100000; 
			}

		}

		//////////

		if (upbring == NPCData.BgUpgring.Poor || upbring == NPCData.BgUpgring.VeryPoor)
		{
			switch (charClass) 
			{

			default:
				return 100000; 
			}
		}

		return 100000; 

	}



	/// <summary>
	/// Sets the amulet.
	/// </summary>
	/// <returns>The amulet.</returns>
	/// <param name="upbring">Upbring.</param>
	/// <param name="charClass">Char class.</param>


	int setAmulet(NPCData.BgUpgring upbring, NPCData.CharClass charClass)
	{
		if (upbring == NPCData.BgUpgring.Rich || upbring == NPCData.BgUpgring.VeryRich || upbring == NPCData.BgUpgring.Noble) 
		{
			switch (charClass) 
			{

			default:
				return 110000; 
			}

		}

		//////////

		if (upbring == NPCData.BgUpgring.Royal)
		{
			switch (charClass) 
			{

			default:
				return 110000; 
			}

		}

		//////////

		if (upbring == NPCData.BgUpgring.MiddleClass)
		{
			switch (charClass) 
			{

			default:
				return 110000; 
			}

		}

		//////////

		if (upbring == NPCData.BgUpgring.Poor || upbring == NPCData.BgUpgring.VeryPoor)
		{
			switch (charClass) 
			{

			default:
				return 110000; 
			}
		}

		return 110000; 

	}




	/// <summary>
	/// Sets the trophy.
	/// </summary>
	/// <returns>The trophy.</returns>
	/// <param name="upbring">Upbring.</param>
	/// <param name="charClass">Char class.</param>


	int setTrophy(NPCData.BgUpgring upbring, NPCData.CharClass charClass)
	{
		if (upbring == NPCData.BgUpgring.Rich || upbring == NPCData.BgUpgring.VeryRich || upbring == NPCData.BgUpgring.Noble) 
		{
			switch (charClass) 
			{

			default:
				return 120000;  
			}

		}

		//////////

		if (upbring == NPCData.BgUpgring.Royal)
		{
			switch (charClass) 
			{

			default:
				return 120000;
			}

		}

		//////////

		if (upbring == NPCData.BgUpgring.MiddleClass)
		{
			switch (charClass) 
			{

			default:
				return 120000;
			}

		}

		//////////

		if (upbring == NPCData.BgUpgring.Poor || upbring == NPCData.BgUpgring.VeryPoor)
		{
			switch (charClass) 
			{

			default:
				return 120000;
			}
		}

		return 120000;

	}












}
