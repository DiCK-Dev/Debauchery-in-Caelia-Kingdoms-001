using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ManSetTattoos : MonoBehaviour {

	public Dropdown ddTattoos;
	public InputField ifTattoo; 
	public Text tattooPrev; 
	static bool tattooUpdated = true;
	static int formerIdx = -1;
	static string strCharTattoos;

	public void setTattoo(){
		NPCCharList.CharRetainers [WorldControl.idx].charTattoos [ddTattoos.value] = textTattoo ();
		tattooUpdated = true;
	}

	string textTattoo(){
		string _str1, _str2 = "", HESHE, hisher;
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

		_str1 = HESHE + " has a tattoo of ";

		switch (ddTattoos.value) {
		case 0:
			_str2 = " on " + hisher + " forehead.";
			break;
		case 1:
			  _str2 = " on " + hisher + " left cheek.";
			break;
		case 2:
			  
			  _str2 = " on " + hisher + " right cheek.";
			break;
		case 3:
			  
			  _str2 = " on " + hisher + " neck.";
			break;
		case 4:
			  
			  _str2 = " on " + hisher + " upper chest.";
			break;
		case 5:
			  
			  _str2 = " on " + hisher + " left breast.";
			break;
		case 6:
			  
			  _str2 = " on " + hisher + " right breast.";
			break;
		case 7:
			  
			  _str2 = " on " + hisher + " belly.";
			break;
		case 8:
			  
			  _str2 = " on " + hisher + " low belly.";
			break;
		case 9:
			  
			  _str2 = " on " + hisher + " upper back.";
			break;
		case 10:
			  
			  _str2 = " on " + hisher + " lower back.";
			break;
		case 11:
			  
			  _str2 = " on " + hisher + " left arm.";
			break;
		case 12:
			  
			  _str2 = " on " + hisher + " right arm.";
			break;
		case 13:
			  
			  _str2 = " on " + hisher + " left ass cheek.";
			break;
		case 14:
			  
			  _str2 = " on " + hisher + " right ass cheek.";
			break;
		case 15:
			  
			  _str2 = " on " + hisher + " left leg.";
			break;
		case 16:
			  _str2 = " on " + hisher + " right leg.";
			break;
		case 17:
			_str2 = " on " + hisher + " anus.";
			break;
		}
		return _str1 + ifTattoo.text + _str2;
	}

	void loadTattoos(){


		if (tattooUpdated) {
			int i = 0;
			strCharTattoos = "";
			while (i < 18) {
				if (NPCCharList.CharRetainers [WorldControl.idx].charTattoos [i] != "") {
					strCharTattoos += "\n" + NPCCharList.CharRetainers[WorldControl.idx].charTattoos[i].ToString();
				}
				i++;
			}
			tattooUpdated = false;
		}

	}

	void Update(){
		if (WorldControl.idx < 0) {
			return;
		}
		if (formerIdx != WorldControl.idx) {
			tattooUpdated = true;
			formerIdx = WorldControl.idx;
		}
		loadTattoos ();

		tattooPrev.text = "<b>Preview: "+textTattoo ()+ "</b>\n" + strCharTattoos;
	}
}
