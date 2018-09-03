using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ManSetPiercings : MonoBehaviour {

	public Dropdown ddPiercingLocation;
	public Dropdown ddPiercingMaterial;
	static int formerIdx = -1;
	public Text piercingPrev; 
	static bool piercingUpdated = true;
	static string strCharPiercing;


	public void setPiercing(){
		if (ddPiercingLocation.value == 20 && NPCCharList.CharRetainers [WorldControl.idx].hasVagina == false) {
			return;
		}
		if (ddPiercingLocation.value == 19 && NPCCharList.CharRetainers [WorldControl.idx].dickSizeCM <= 0) {
			return;
		}
		NPCCharList.CharRetainers [WorldControl.idx].charPiercings [ddPiercingLocation.value] = textPiercing ();
		piercingUpdated = true;
	}

	string textPiercing(){
		string _str1, _str2 = "", _material = "", HESHE, hisher;
		if (NPCCharList.CharRetainers [WorldControl.idx].charGender == NPCData.CharGender.FEMALE) {
			HESHE = "She";
			hisher = "her";
		} else if (NPCCharList.CharRetainers [WorldControl.idx].charGender == NPCData.CharGender.MALE) {
			HESHE = "He";
			hisher = "his";
		} else {
			HESHE = "They";
			hisher = "them";
		}

		if (ddPiercingLocation.value == 20 && NPCCharList.CharRetainers [WorldControl.idx].hasVagina == false) {
			return HESHE + " doesn't has a vagina!";
		}
		if (ddPiercingLocation.value == 19 && NPCCharList.CharRetainers [WorldControl.idx].dickSizeCM <= 0) {
			return HESHE + " doesn't has a penis!";
		}

		switch (ddPiercingMaterial.value) {
		case 0:
			_material = "iron";
			break;
		case 1:
			_material = "silver";
			break;
		case 2:
			_material = "gold";
			break;
		case 3:
			_material = "diamond";

			break;

		}


		_str1 = HESHE + " has a "+ _material +" piercing in her ";

		switch (ddPiercingLocation.value) {
		case 0:
			_str1 = HESHE + " has a " + _material + " bridge piercing."; 
			_str2 = "";
			break;
		case 1:
			_str2 = "left eyebrow.";
			break;
		case 2:

			_str2 = "right eyebrow.";
			break;
		case 3:

			_str2 = "left nostril.";
			break;
		case 4:
			_str2 = "right nostril.";
			break;
		case 5:
			_str1 = HESHE + " has a " + _material + " septum piercing."; 
			_str2 = "";
			break;
		case 6:

			_str2 = "left ear lobe.";
			break;
		case 7:

			_str2 = "right ear lobe.";
			break;
		case 8:

			_str2 = "left ear helix.";
			break;
		case 9:

			_str2 = "right ear helix.";
			break;
		case 10:

			_str2 = "left lip.";
			break;
		case 11:

			_str2 = "right lip.";
			break;
		case 12:
			_str1 = HESHE + " has a " + _material + " labret piercing."; 
			_str2 = "";
			break;
		case 13:
			_str2 = "tongue.";
			break;
		case 14:
			_str1 = HESHE + " has a " + _material + " upper lip frenum piercing."; 
			_str2 = "";
			break;
		case 15:
			_str1 = HESHE + " has a " + _material + " lower lip frenum piercing."; 
			_str2 = "";
			break;
		case 16:
			_str1 = HESHE + " has a " + _material + " left nipple piercing."; 
			_str2 = "";
			break;
		case 17:
			_str1 = HESHE + " has a " + _material + " right nipple piercing."; 
			_str2 = "";
			break;
		case 18:
			_str2 = "navel.";
			break;
		case 19:
			_str2 = "penis.";
			break;
		case 20:
			_str2 = "clitoris.";
			break;

		}
		return _str1 + _str2;
	}


	void loadPiercings(){


		if (piercingUpdated) {
			int i = 0;
			strCharPiercing = "";
			while (i < 21) {
				if (NPCCharList.CharRetainers [WorldControl.idx].charPiercings [i] != "") {
					strCharPiercing += "\n" + NPCCharList.CharRetainers[WorldControl.idx].charPiercings[i].ToString();
				}
				i++;
			}
			piercingUpdated = false;
		}

	}

	void Update(){
		if (WorldControl.idx < 0) {
			return;
		}
		if (formerIdx != WorldControl.idx) {
			piercingUpdated = true;
			formerIdx = WorldControl.idx;
		}
		loadPiercings ();
		piercingPrev.text = "<b>Preview: "+ textPiercing ()+ "</b>\n" + strCharPiercing;

	}
}
