using UnityEngine;
using System.Collections;

public class NPCSettlerFertility : MonoBehaviour {

	static int iterator = 0;
	int hashcode = GameControl.playerName.GetHashCode();
	int randNum;

	int FurryOpen = (int)NPCData.CharRace.FURRYOPEN +1;
	int FurryClose = (int)NPCData.CharRace.FURRYCLOSE -1;
	int AvianOpen = (int)NPCData.CharRace.AVIANOPEN +1; 
	int AvianClose = (int)NPCData.CharRace.AVIANCLOSE -1;
	int AquaticOpen = (int)NPCData.CharRace.AQUATICOPEN +1;
	int AquaticClose = (int)NPCData.CharRace.AQUATICCLOSE -1;
	int ExoticOpen = (int)NPCData.CharRace.EXOTICOPEN +1;
	int ExoticClose = (int)NPCData.CharRace.EXOTICCLOSE -1;












	//genitals and fertility
	public bool setHasKnot(NPCData.CharRace charRace){
		iterator += 1;

		switch (charRace) {
		case NPCData.CharRace.Wolf:
			return true;
		case NPCData.CharRace.Fox:
			return true;
		case NPCData.CharRace.kobold:
			return true;
		default:
			return false; 
		}

	}



	public bool setHasVagina(NPCData.CharSex charSex){
		if (charSex == NPCData.CharSex.Woman || charSex == NPCData.CharSex.Cuntboy || charSex == NPCData.CharSex.Futanari) {
			return true;
		} else {
			return false; 
		}
	}



	public bool setIsVirgin(NPCData.CharRace charRace){
		iterator += 1;

		switch (charRace) {
		case NPCData.CharRace.angel:
			return true; 
		case NPCData.CharRace.succubus:
			return false; 
		default:
			break;
		}

		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		randNum = Random.Range (0, 100);

		if (randNum >= 90) {
			return true;
		} else {
			return false; 
		}

	}



	public bool setIsFertile(){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		randNum = Random.Range (0, 100);
		if (randNum > 90) {
			return false;
		} else {
			return true; 
		}

	}




	public float setCharFertility(){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		return Random.Range (0, 1f);

	}


	public bool isPregnant(bool pregnantselector, NPCData.CharSex charSex){
		if (charSex == NPCData.CharSex.Cuntboy || charSex == NPCData.CharSex.Futanari || charSex == NPCData.CharSex.Woman) {
			if (pregnantselector == true) {
				return true;
			} else {
				return false;
			}

		} else {
			return false; 
		}

	}

	public int setPregnantCD(bool isPregnant){
		if (isPregnant == true) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			return Random.Range (5, 10);
		} else {
			return 0;
		}

	}// turns until giving birth
	public string pregnantText(bool pregnantselector, NPCData.CharRace childRace){
		
		if (pregnantselector == true) {
			switch (childRace) {
			case NPCData.CharRace.Wolf:
				return "";
			case NPCData.CharRace.Human:
				return "";
			default:
				return "";
			}
		} else {
			return "";
		}
	}// 

	public NPCData.CharRace setChildRace(NPCData.CharRace momRace){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		randNum = Random.Range (0, 100);

		if (randNum >= 50) {
			return momRace; 
		} else if (randNum >= 10) {
			return NPCData.CharRace.Human; 
		} else {
			return childRandomRace ();
		}


	}


	NPCData.CharRace childRandomRace(){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		randNum = Random.Range (0, 100);


		if (randNum >= 70) {
			iterator += 1;
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			randNum = Random.Range (FurryOpen, FurryClose);
			return (NPCData.CharRace)randNum;
		} else if (randNum >= 40) {
			iterator += 1;
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			randNum = Random.Range (AvianOpen, AvianClose);
			return (NPCData.CharRace)randNum;
		} else if (randNum >= 10) {
			iterator += 1;
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			randNum = Random.Range (ExoticOpen, ExoticClose);
			return (NPCData.CharRace)randNum;
		} else {
			iterator += 1;
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
			randNum = Random.Range (AquaticOpen, AquaticClose);
			return (NPCData.CharRace)randNum;
		}

	}


	public float setLactationML(NPCData.CharRace charRace){
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
	
		switch (charRace) {

		default:
			return Random.Range (450, 1000);
		}

	}



	public NPCData.VagLoose setVagLoose (float loose){
		if (loose > 0 && loose <= 0.5f) {
			loose = 1; 
		}
		if (loose > 4) {
			loose = 4;
		}
		int retvalue = (int)loose; 
		return (NPCData.VagLoose)retvalue;

	}

	public float setVagLooseness(bool isVirgin)
	{
		iterator += 1;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iterator); 
		if (isVirgin == true) {
			return 0; 
		} else {
			return Random.Range (0f, 5f);

		}
	}




}
