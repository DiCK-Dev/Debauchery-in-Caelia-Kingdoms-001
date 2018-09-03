using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class buttRewardData : MonoBehaviour {

	public GameObject prefabText; //name 

	public void initFunName(int selector){
		Debug.Log ("init fun working");
		GameObject NPCName = Instantiate (prefabText) as GameObject;
		NPCName.name = gameObject.name + " NPCName";
		NPCName.transform.parent = gameObject.transform;

		Text NPCname = NPCName.GetComponent<Text> ();
		NPCname.text = createName(selector); 
		NPCname.alignment = TextAnchor.MiddleCenter;

	}

	string createName(int selector){
		switch (selector) {
		case 0: return "Show gratitude (1)";
		case 1: return "Promise reward (1)";
		case 2: return "Praise (2)";
		case 3: return "Promise gift (2)";
		case 4: return "Compliment (3)";
		case 5: return "Promise big reward (3)";
		case 100: return "Rest (1)";
		case 102: return "Visit park (2)";
		case 104: return "Visit colosseum (3)";
		case 106: return "Visit theater (4)";
		case 108: return "Visit spa (5)";
		case 200: return "Pleasant conversation (1)";
		case 202: return "Visit the city (2)";
		case 204: return "Go shopping (3)";
		case 206: return "Visit restaurant (4)";
		case 208: return "Visit theater (5)";
		case 300: return "Give flowers (1)";
		case 301: return "Offer Candies (1)";
		case 302: return "Give plush toys (2)";
		case 303: return "Offer Chocolate (2)";
		case 304: return "Give Perfume (3)";
		case 305: return "Offer cake (3)";
		case 306: return "Give jewelry (4)";
		case 307: return "Offer lavish desserts (4)";
		case 308: return "Give exotic pet (5)";
		case 309: return "Serve a banquet (5)";
		case 400: return "Give them a massage (1)";
		case 402: return "Masturbate them (2)";
		case 404: return "Give them head (3)";
		case 1000: return "Talk down (1)";
		case 1001: return "Threat w/ beating (2)";
		case 1002: return "Harshly scold (2)";
		case 1003: return "Threat w/ torture (3)";
		case 1004: return "Public humiliation (3)";
		case 1005: return "Threat w/ public use (4)";
		case 1007: return "Threat w/ death (5)";
		case 1100: return "Slap (1)";
		case 1101: return "Hot wax (1) ";
		case 1102: return "Spank (2)";
		case 1103: return "Zipper (2)";
		case 1104: return "Flogger whip (3)";
		case 1105: return "Pricking (3)";
		case 1106: return "Riding crop (4)";
		case 1107: return "Water barrel (4)";
		case 1108: return "Beating (5)";
		case 1109: return "Iron maiden (5)";
		case 1200: return "Grope (1)"; //sex pun
		case 1202: return "Hand job (2)";
		case 1204: return "Oral job (3)";
		case 1206: return "Anal sex (4)";
		case 1208: return "Monster sex (5)";
		case 1300: return "Gag ball (1)"; // bondage
		case 1302: return "Rope saddle (2)";
		case 1304: return "Hang by the legs (3)";
		case 1306: return "Painful bondage (4)";
		case 1308: return "Deprivation (5)";
		case 1400: return "Naked walk (1)"; // public
		case 1402: return "Cum walk (2)";
		case 1404: return "Living canvas (3)";
		case 1406: return "Public oral (4)";
		case 1408: return "Public sex (5)";
		default: return "";
		}


	}


}
