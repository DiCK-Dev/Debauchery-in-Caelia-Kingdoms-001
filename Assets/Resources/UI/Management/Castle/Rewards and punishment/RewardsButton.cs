using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RewardsButton : MonoBehaviour {

	public static int selectedOption = 0;
	static int formerSelectedOption = 0;

	public GameObject buttPrefab; 
	public GameObject[] buttList;



	void mainManagement(){
		int i;

		switch (selectedOption) {
		case 0:
			i = 0; 
			while (i < 6) {
				GameObject selectButt = Instantiate (buttPrefab) as GameObject;
				selectButt.name = "buttReward";
				selectButt.tag = "buttReward";
				selectButt.transform.parent = gameObject.transform;
				int selector = i; 
				Button buttonCtrl = selectButt.GetComponent<Button> ();

				/*
				buttonCtrl.interactable = false;
				Image buttImage = selectButt.GetComponent <Image> ();
				var tempColor = buttImage.color; 
				tempColor.a = 0.5f;
				buttImage.color = tempColor;
				*/	

				buttonCtrl.onClick.AddListener (() => buttonSelect (selector));

				selectButt.GetComponent<buttRewardData> ().initFunName (selector);
				i++;
			}
			break;
		case 1:
			i = 100; 
			while (i < 109) {
				GameObject selectButt = Instantiate (buttPrefab) as GameObject;
				selectButt.name = "buttReward";
				selectButt.tag = "buttReward";
				selectButt.transform.parent = gameObject.transform;
				int selector = i; 
				Button buttonCtrl = selectButt.GetComponent<Button> ();

				if (i == 101 || i == 103 || i == 105 || i == 107) {
					buttonCtrl.interactable = false;
					Image buttImage = selectButt.GetComponent <Image> ();
					var tempColor = buttImage.color; 
					tempColor.a = 0f;
					buttImage.color = tempColor;

				}


				buttonCtrl.onClick.AddListener (() => buttonSelect (selector));

				selectButt.GetComponent<buttRewardData> ().initFunName (selector);
				i++;
			}
			break;
		case 2:
			i = 200; 
			while (i < 209) {
				GameObject selectButt = Instantiate (buttPrefab) as GameObject;
				selectButt.name = "buttReward";
				selectButt.tag = "buttReward";
				selectButt.transform.parent = gameObject.transform;
				int selector = i; 
				Button buttonCtrl = selectButt.GetComponent<Button> ();

				if (i == 201 || i == 203 || i == 205 || i == 207) {
					buttonCtrl.interactable = false;
					Image buttImage = selectButt.GetComponent <Image> ();
					var tempColor = buttImage.color; 
					tempColor.a = 0f;
					buttImage.color = tempColor;

				}

				buttonCtrl.onClick.AddListener (() => buttonSelect (selector));

				selectButt.GetComponent<buttRewardData> ().initFunName (selector);
				i++;
			}
			break;
		case 3:
			i = 300; 
			while (i < 310) {
				GameObject selectButt = Instantiate (buttPrefab) as GameObject;
				selectButt.name = "buttReward";
				selectButt.tag = "buttReward";
				selectButt.transform.parent = gameObject.transform;
				int selector = i; 
				Button buttonCtrl = selectButt.GetComponent<Button> ();

				buttonCtrl.onClick.AddListener (() => buttonSelect (selector));

				selectButt.GetComponent<buttRewardData> ().initFunName (selector);
				i++;
			}
			break;
		case 4:
			i = 400; 
			while (i < 405) {
				GameObject selectButt = Instantiate (buttPrefab) as GameObject;
				selectButt.name = "buttReward";
				selectButt.tag = "buttReward";
				selectButt.transform.parent = gameObject.transform;
				int selector = i; 
				Button buttonCtrl = selectButt.GetComponent<Button> ();

				if (i == 401 || i == 403 || i == 405 || i == 407) {
					buttonCtrl.interactable = false;
					Image buttImage = selectButt.GetComponent <Image> ();
					var tempColor = buttImage.color; 
					tempColor.a = 0f;
					buttImage.color = tempColor;

				}

				buttonCtrl.onClick.AddListener (() => buttonSelect (selector));

				selectButt.GetComponent<buttRewardData> ().initFunName (selector);
				i++;
			}
			break;
		case 10:
			i = 1000; 
			while (i < 1008) {
				GameObject selectButt = Instantiate (buttPrefab) as GameObject;
				selectButt.name = "buttReward";
				selectButt.tag = "buttReward";
				selectButt.transform.parent = gameObject.transform;
				int selector = i; 
				Button buttonCtrl = selectButt.GetComponent<Button> ();

				if (i == 1006) {
					buttonCtrl.interactable = false;
					Image buttImage = selectButt.GetComponent <Image> ();
					var tempColor = buttImage.color; 
					tempColor.a = 0f;
					buttImage.color = tempColor;

				}

				buttonCtrl.onClick.AddListener (() => buttonSelect (selector));

				selectButt.GetComponent<buttRewardData> ().initFunName (selector);
				i++;
			}
			break;
		case 11:
			i = 1100; 
			while (i < 1110) {
				GameObject selectButt = Instantiate (buttPrefab) as GameObject;
				selectButt.name = "buttReward";
				selectButt.tag = "buttReward";
				selectButt.transform.parent = gameObject.transform;
				int selector = i; 
				Button buttonCtrl = selectButt.GetComponent<Button> ();

				buttonCtrl.onClick.AddListener (() => buttonSelect (selector));

				selectButt.GetComponent<buttRewardData> ().initFunName (selector);
				i++;
			}
			break;
		case 12:

			i = 1200; 
			while (i < 1209) {
				GameObject selectButt = Instantiate (buttPrefab) as GameObject;
				selectButt.name = "buttReward";
				selectButt.tag = "buttReward";
				selectButt.transform.parent = gameObject.transform;
				int selector = i; 
				Button buttonCtrl = selectButt.GetComponent<Button> ();

				if (i == 1201 || i == 1203 || i == 1205 || i == 1207) {
					buttonCtrl.interactable = false;
					Image buttImage = selectButt.GetComponent <Image> ();
					var tempColor = buttImage.color; 
					tempColor.a = 0f;
					buttImage.color = tempColor;

				}

				buttonCtrl.onClick.AddListener (() => buttonSelect (selector));

				selectButt.GetComponent<buttRewardData> ().initFunName (selector);
				i++;
			}
			break;
		case 13: // bondage
			i = 1300; 
			while (i < 1309) {
				GameObject selectButt = Instantiate (buttPrefab) as GameObject;
				selectButt.name = "buttReward";
				selectButt.tag = "buttReward";
				selectButt.transform.parent = gameObject.transform;
				int selector = i; 
				Button buttonCtrl = selectButt.GetComponent<Button> ();

				if (i == 1301 || i == 1303 || i == 1305 || i == 1307) {
					buttonCtrl.interactable = false;
					Image buttImage = selectButt.GetComponent <Image> ();
					var tempColor = buttImage.color; 
					tempColor.a = 0f;
					buttImage.color = tempColor;

				}

				buttonCtrl.onClick.AddListener (() => buttonSelect (selector));

				selectButt.GetComponent<buttRewardData> ().initFunName (selector);
				i++;
			}
			break;
		case 14: // public
			i = 1400; 
			while (i < 1409) {
				GameObject selectButt = Instantiate (buttPrefab) as GameObject;
				selectButt.name = "buttReward";
				selectButt.tag = "buttReward";
				selectButt.transform.parent = gameObject.transform;
				int selector = i; 
				Button buttonCtrl = selectButt.GetComponent<Button> ();

				if (i == 1401 || i == 1403 || i == 1405 || i == 1407) {
					buttonCtrl.interactable = false;
					Image buttImage = selectButt.GetComponent <Image> ();
					var tempColor = buttImage.color; 
					tempColor.a = 0f;
					buttImage.color = tempColor;

				}

				buttonCtrl.onClick.AddListener (() => buttonSelect (selector));

				selectButt.GetComponent<buttRewardData> ().initFunName (selector);
				i++;
			}
			break;

		}




	}





	string rewardDescription(int selector){
		switch (selector) {
		case 0: return "Say how much you appreciate them.";
		case 1: return "Promise to give them a good reward in the future.";
		case 2: return "Praise they good work.";
		case 3: return "Promise to give them a nice gift in the future.";
		case 4: return "Wholeheartedly compliment they good work and efforts.";
		case 5: return "Promise an expensive gift or reward. Don't promise too often before delivering or they may distrust you!";
		case 100: return "Give them some time to rest and have fun.";
		case 102: return "Allow them to visit the park, accompained by one of your guards.";
		case 104: return "Allow them to visit the colosseum, accompained by one of your guards.";
		case 106: return "Give them tickets for the theater, accompained by one of your guards.";
		case 108: return "Give them gold to visit the spa, accompained by one of your guards.";
		case 200: return "Take a break and have a deep talk with your servant.";
		case 202: return "Visit the park together.";
		case 204: return "Visit the market together and go shopping.";
		case 206: return "Go to a fancy restaurant with your servant.";
		case 208: return "Go to the theater together.";
		case 300: return "Give them a bouquet of flowers. Cost: 2G.";
		case 301: return "Give them a bag of candies. Cost: 3G.";
		case 302: return "Give them a cute plush toy. Cost 5G.";
		case 303: return "Give them a box of chocolates. Cost: 7G.";
		case 304: return "Give them a bottle of perfume. Cost: 15 G.";
		case 305: return "Offer them a big cake. Cost: 15 G.";
		case 306: return "Give them nice jewelry. Cost: 30 G.";
		case 307: return "Offer them a delicious and expensive lavish dessert. Cost: 20 G.";
		case 308: return "Give them an exotic and beautiful pet. Cost: 50 G.";
		case 309: return "Serve them a banquet with all they can eat. Cost: 40 G.";
		case 400: return "Give them a nice, relaxing massage.";
		case 402: return "Give them a hand, and help them relax. Make sure you don't deny them to orgasm!";
		case 404: return "Serve them with your mouth and let them enjoy themselves. Make sure you don't deny them to orgasm!";
		case 1000: return "Talk down and show it it's place.";
		case 1001: return "Threaten it with a beating, will increase it's fear towards you.";
		case 1002: return "Scold it until it understands what it did wrong.";
		case 1003: return "Threat with torture, making it fear you significantly more and make it behave.";
		case 1004: return "Scold it in front of all of your servants and slaves, and encourage them to mock and laugh for it's failures.";
		case 1005: return "Threaten to take it to the city square to be used by anyone in the city.";
		case 1007: return "Threaten it with death. This action will definitely terrify the person and make it unhappy, be careful.";
		case 1100: return "Slap it across the face to teach it a lesson.";
		case 1101: return "Use hot wax in it's back until it begs you to stop. More effective than a slap, but also will hate you more.";
		case 1102: return "Spank it hard until it's butt is red.";
		case 1103: return "Use clothespins to hold it's skin together for an hour.";
		case 1104: return "Use a flogger whip against it's back, hurting it until it learns.";
		case 1105: return "Prick it's skin with needles. This technique is highly effective, but also makes it really unhappy, careful.";
		case 1106: return "Hit it with a riding crop for an hour until it learns.";
		case 1107: return "Hang it by the feet and slowly immerse its head in the water, taking it out just when its about to drown. Careful with this technique.";
		case 1108: return "Give it a beating until it can't stand. Good and effective, but will make it really unhappy and harm it's health.";
		case 1109: return "Put it inside the iron maiden for a couple of hours. This will affect its mood a lot.";
		case 1200: return "Grope it, making sure to have a good feel of it's whole body."; //sex pun
		case 1202: return "Make it give you a hand job.";
		case 1204: return "Make it give you oral sex.";
		case 1206: return "Use it's backdoor as your own personal onahole.";
		case 1208: return "Make it mate with a monster in the dungeon.";
		case 1300: return "Make it use a gag ball for a couple of hours, teaching it to stay quiet."; // bondage
		case 1302: return "Use a rope saddle to tie it up and immobilize it for a couple of hours.";
		case 1304: return "Hang it by the legs for a couple of hours or until it faints.";
		case 1306: return "Use painful bondage and immobilize it for a couple of hours to teach it a lesson.";
		case 1308: return "Make it use a deprivation suit for a couple of hours as a punishment.";
		case 1400: return "Make it walk naked through the city."; // public
		case 1402: return "Organize a short bukkake with your servants and guards and make it walk through the city.";
		case 1404: return "Sit it in the middle of the street and let people use it's body as a canvas to write obscenities";
		case 1406: return "Sit it in the middle of the city and allow people to use it's mouth for their pleasure.";
		case 1408: return "Sit it in the middle of the city and allow people to use it's body in any way they please.";

		default: return "";
		}


	}


	public void buttonSelect(int selector)
	{
		SlaveRewards.rewardSelector = selector; 
		SlaveRewards.boardText = rewardDescription(selector);
	}


	void Start () {
		selectedOption = 0; 
		mainManagement ();
		buttList = GameObject.FindGameObjectsWithTag ("buttReward");
	}

	void Update(){
		if (selectedOption != formerSelectedOption) {
			foreach (GameObject go in buttList) {
				Destroy (go);

			}
			mainManagement ();
			buttList = GameObject.FindGameObjectsWithTag ("buttReward");
			formerSelectedOption = selectedOption; 
		}



	}


}
