using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SlaveRewards : MonoBehaviour {

	public static int rewardSelector;
	public static string boardText; 
	public Text localBoard; 
	public Canvas BoardCanvas, rewardCanvas;
	public Text Board;
	public Canvas mainPanel, endTurnPan;
	public static int RewPunSelector;

	public Text textReward1, textReward2, textReward3, textReward4, textReward5, textRewpun;

	public void selectMainOption(int selector){
		if (RewPunSelector == 1) {
			selector += 10;
		}
		RewardsButton.selectedOption = selector; 

	}

	public void selectRewardPunishment(int selector){
		RewPunSelector = selector;
		if (selector == 0) {
			RewardsButton.selectedOption = 0;
			textReward1.text = "Encouragement";
			textReward2.text = "Free time";
			textReward3.text = "Personal rewards";
			textReward4.text = "Gifts";
			textReward5.text = "Erotic rewards";
			textRewpun.text = "Reward";
		} else {
			RewardsButton.selectedOption = 10;
			textReward1.text = "Phychological";
			textReward2.text = "Physical";
			textReward3.text = "Sexual";
			textReward4.text = "Bondage";
			textReward5.text = "Public";
			textRewpun.text = "Punish";

		}

	}

	void Update(){
		localBoard.text = boardText;
	}

	public void Reward(){
		Board.text = SlaveRewardsTexts.rewardsTexts(rewardSelector);
		runRewards ();
		BoardCanvas.sortingOrder = 500;
		rewardCanvas.sortingOrder = -500;
		PanLeftManagement.endTurnControl = true; 
		mainPanel.sortingOrder = -500;
		endTurnPan.sortingOrder = 500;


	}



	void runRewards(){
		switch (rewardSelector) {
		case 0:
			SlaveRewardsEffects.rewardsEffects (1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
			break;
		case 1:
			SlaveRewardsEffects.rewardsEffects (1, 1, 0, 0, 0, 0, 0, 0, 0, 5f, 0, 0, 0, 1);
			break;
		case 2:
			SlaveRewardsEffects.rewardsEffects (2, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
			break;
		case 3:
			SlaveRewardsEffects.rewardsEffects (2, 1, 0, 0, 0, 0, 0, 0, 0, 10f, 0, 0, 0, 1);
			break;
		case 4:
			SlaveRewardsEffects.rewardsEffects (3, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
			break;
		case 5:
			SlaveRewardsEffects.rewardsEffects (3, 1, 0, 0.2f, 0, 0, 0, 0, 0, 20f, 0, 0, 0, 1);
			break;
		case 100: //take rest, visit park, visit colosseum, visit theater, visit spa
			SlaveRewardsEffects.rewardsEffects (1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
			break;
		case 102: 
			SlaveRewardsEffects.rewardsEffects (2, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
			break;
		case 104:
			SlaveRewardsEffects.rewardsEffects (3, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
			break;
		case 106:
			SlaveRewardsEffects.rewardsEffects (4, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
			break;
		case 108:
			SlaveRewardsEffects.rewardsEffects (5, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
			break;
		case 200: //pleasant conv, visit the city, go shopping, go rest, go theat
			SlaveRewardsEffects.rewardsEffects (1, 1, 0, 0, 0, 0, 0.1f, 0, 0, 0, 0, 0, 1, 1);
			break;
		case 202: 
			SlaveRewardsEffects.rewardsEffects (2, 1, 0, 0, 0, 0, 0.15f, 0, 0, 0, 0, 0, 1, 1);
			break;
		case 204:
			SlaveRewardsEffects.rewardsEffects (3, 1, 0, 0, 0, 0, 0.25f, 0, 0, 0, 0, 0, 1, 1);
			break;
		case 206:
			SlaveRewardsEffects.rewardsEffects (4, 1, 0, 0, 0, 0, 0.35f, 0, 0, 0, 0, 0, 1, 1);
			break;
		case 208:
			SlaveRewardsEffects.rewardsEffects (5, 1, 0, 0, 0, 0, 0.45f, 0, 0, 0, 0, 0, 1, 1);
			break;
		case 300: //flower, plush, perfume, jewelry, exotic
			SlaveRewardsEffects.rewardsEffects (1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 1);
			break;
		case 301: //candies, chocolate, cake, lavish des, banquet
			SlaveRewardsEffects.rewardsEffects (1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 1);
			break;
		case 302:
			SlaveRewardsEffects.rewardsEffects (2, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 1);
			break;
		case 303:
			SlaveRewardsEffects.rewardsEffects (2, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 1);
			break;
		case 304:
			SlaveRewardsEffects.rewardsEffects (3, 1, 0, 0, 0, 0, 0, 0, 0, 3f, 0, 0, 2, 1);
			break;
		case 305: 
			SlaveRewardsEffects.rewardsEffects (3, 1, 0, 0, 0, 0, 0, 0, 0, 3f, 0, 0, 2, 1);
			break;
		case 306: 
			SlaveRewardsEffects.rewardsEffects (4, 1, 0, 0.1f, 0, 0, 0, 0, 0, 6f, 0, 0, 2, 1);
			break;
		case 307:
			SlaveRewardsEffects.rewardsEffects (4, 1, 0, 0.1f, 0, 0, 0, 0, 0, 6f, 0, 0, 2, 1);
			break;
		case 308:
			SlaveRewardsEffects.rewardsEffects (5, 1, 0, 0.2f, 0, 0, 0, 0, 0, 12f, 0, 0, 2, 1);
			break;
		case 309:
			SlaveRewardsEffects.rewardsEffects (5, 1, 0, 0.2f, 0, 0, 0, 0, 0, 12f, 0, 0, 2, 1);
			break;
		case 400: // message, petting, oral job
			SlaveRewardsEffects.rewardsEffects (1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 1);
			break;
		case 402: 
			SlaveRewardsEffects.rewardsEffects (2, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 1);
			break;
		case 404:
			SlaveRewardsEffects.rewardsEffects (3, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,3, 1);
			break;
		case 1000:
			SlaveRewardsEffects.rewardsEffects (-1, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
			break;
		case 1001:
			SlaveRewardsEffects.rewardsEffects (-1, -1, 0.3f, 0, 0.4f, 0, 0, 0, 0, -5f, 0, 0, 0, 1);
			break;
		case 1002:
			SlaveRewardsEffects.rewardsEffects (-2, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
			break;
		case 1003:
			SlaveRewardsEffects.rewardsEffects (-2, -1, 0.4f, 0, 0, 0, 0, 0, 0, -10f, 0, 0, 0, 1);
			break;
		case 1004:
			SlaveRewardsEffects.rewardsEffects (-3, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
			break;
		case 1005:
			SlaveRewardsEffects.rewardsEffects (-3, -1, 0.5f, 0, 0.5f, 0, 0.25f, 0.25f, 0.25f, -15f, 0, 0, 0, 1);
			break;
		case 1007:
			SlaveRewardsEffects.rewardsEffects (-4, -1, 2f, 0, 2f, 0, 0.5f, 0.5f, 0.5f, -35f, 0, 0, 0, 1);
			break;
		case 1100: //physical
			SlaveRewardsEffects.rewardsEffects (-1, -1, 0, 0, 0, 0, 0, 0, 0, 0, -3f, 0, 0, 1);
			break;
		case 1101:
			SlaveRewardsEffects.rewardsEffects (-1, -1, 0.1f, 0.2f, 0.2f, 0.2f, 0.2f, 0, 0.2f, -5f, -6f, 0, 0, 1);
			break;
		case 1102:
			SlaveRewardsEffects.rewardsEffects (-2, -1, 0, 0, 0, 0, 0, 0, 0, 0, -3f, 0, 0, 1);
			break;
		case 1103: //zippers
			SlaveRewardsEffects.rewardsEffects (-2, -1, 0.1f, 0.2f, 0.2f, 0.2f, 0.2f, 0, 0.2f, -5f, -6f, 0, 0, 1);
			break;
		case 1104:
			SlaveRewardsEffects.rewardsEffects (-3, -1, 0, 0, 0, 0, 0, 0, 0, 0, -3f, 0, 0, 1);
			break;
		case 1105: // pricking
			SlaveRewardsEffects.rewardsEffects (-3, -1, 0.125f, 0, 0, 0, 0, 0, 0.125f, -10f, -10f, 1000, 0, 1);
			break;
		case 1106:
			SlaveRewardsEffects.rewardsEffects (-4, -1, 0, 0, 0, 0, 0, 0, 0, 0, -5f, 0, 0, 1);
			break;
		case 1107:// water
			SlaveRewardsEffects.rewardsEffects (-4, -1, 0.25f, 0, 0, 0, 0, 0, 0.25f, -15f, -10f, 1000, 0, 1);
			break;
		case 1108:
			SlaveRewardsEffects.rewardsEffects (-5, -1, 0.25f, 0, 0.3f, 0.2f, 0.3f, 0.2f, 0.2f, 0, -15f, 0, 0, 1);
			break;
		case 1109:// iron
			SlaveRewardsEffects.rewardsEffects (-5, -1, 0.5f, 0.2f, 0.5f, 0.3f, 0.3f, 0.3f, 0.5f, -20f, -20f, 1000, 0, 1);
			break;
		case 1200: //sexual
			SlaveRewardsEffects.rewardsEffects (-1, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1001, 1);
			break;
		case 1202: 
			SlaveRewardsEffects.rewardsEffects (-2, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1001, 1);
			break;
		case 1204: 
			SlaveRewardsEffects.rewardsEffects (-3, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1001, 1);
			break;
		case 1206: 
			SlaveRewardsEffects.rewardsEffects (-4, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1001, 1);
			break;
		case 1208: 
			SlaveRewardsEffects.rewardsEffects (-5, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1001, 1);
			break;
		case 1300: // bondage
			SlaveRewardsEffects.rewardsEffects (-1, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1);
			break;
		case 1302: 
			SlaveRewardsEffects.rewardsEffects (-2, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1);
			break;
		case 1304: 
			SlaveRewardsEffects.rewardsEffects (-3, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1);
			break;
		case 1306: 
			SlaveRewardsEffects.rewardsEffects (-4, -1, 0, 0, 0, 0, 0, 0, 0, 0, -5f, 1000, 0, 1);
			break;
		case 1308: 
			SlaveRewardsEffects.rewardsEffects (-5, -1, 0, 0, 0, 0, 0, 0, 0, 0, -5f, 1000, 0, 1);
			break;
		case 1400: // public sexual
			SlaveRewardsEffects.rewardsEffects (-1, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1002, 1);
			break;
		case 1402: 
			SlaveRewardsEffects.rewardsEffects (-2, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1002, 1);
			break;
		case 1404: 
			SlaveRewardsEffects.rewardsEffects (-3, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1002, 1);
			break;
		case 1406: 
			SlaveRewardsEffects.rewardsEffects (-4, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1002, 1);
			break;
		case 1408: 
			SlaveRewardsEffects.rewardsEffects (-5, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1002, 1);
			break;
		}
		//SlaveRewardsEffects.rewardsEffects (rewardSelector);


	}

	void Start(){


	}

}
