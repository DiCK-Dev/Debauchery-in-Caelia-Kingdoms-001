using UnityEngine;
using System.Collections;

public class SlaveRewardsTexts {



	public static string rewardsTexts(int selector){
		switch (selector) {
		case 0: return rewardTextEncouragement.sceneText (0);
		case 1: return rewardTextEncouragement.sceneText (1);
		case 2: return rewardTextEncouragement.sceneText (2);
		case 3: return rewardTextEncouragement.sceneText (3);
		case 4: return rewardTextEncouragement.sceneText (4);
		case 5: return rewardTextEncouragement.sceneText (5);
		case 100: return rewardTextFreeTime.sceneText (0);
		case 102: return rewardTextFreeTime.sceneText (1);
		case 104: return rewardTextFreeTime.sceneText (2);
		case 106: return rewardTextFreeTime.sceneText (3);
		case 108: return rewardTextFreeTime.sceneText (4);
		case 200: return rewardTextPersonal.sceneText (0);
		case 202: return rewardTextPersonal.sceneText (1);
		case 204: return rewardTextPersonal.sceneText (2);
		case 206: return rewardTextPersonal.sceneText (3);
		case 208: return rewardTextPersonal.sceneText (4);
		case 300: return rewardTextGift.sceneText(0);
		case 301: return rewardTextGift.sceneText(1);
		case 302: return rewardTextGift.sceneText(2);
		case 303: return rewardTextGift.sceneText(3);
		case 304: return rewardTextGift.sceneText(4);
		case 305: return rewardTextGift.sceneText(5);
		case 306: return rewardTextGift.sceneText(6);
		case 307: return rewardTextGift.sceneText(7);
		case 308: return rewardTextGift.sceneText(8);
		case 309: return rewardTextGift.sceneText(9);
		case 400: return rewardTextSexual.sceneText(0);
		case 402: return rewardTextSexual.sceneText(1);
		case 404: return rewardTextSexual.sceneText(2);
		case 1000: return punishmentTextPsychological.sceneText(0);
		case 1001: return punishmentTextPsychological.sceneText(3);
		case 1002: return punishmentTextPsychological.sceneText(1);
		case 1003: return punishmentTextPsychological.sceneText(4);
		case 1004: return punishmentTextPsychological.sceneText(2);
		case 1005: return punishmentTextPsychological.sceneText(5);
		case 1007: return punishmentTextPsychological.sceneText(6);
		case 1100: return punishmentTextPhysical.sceneText(0);
		case 1101: return punishmentTextPhysical.sceneText(1);
		case 1102: return punishmentTextPhysical.sceneText(2);
		case 1103: return punishmentTextPhysical.sceneText(3);
		case 1104: return punishmentTextPhysical.sceneText(4);
		case 1105: return punishmentTextPhysical.sceneText(5);
		case 1106: return punishmentTextPhysical.sceneText(6);
		case 1107: return punishmentTextPhysical.sceneText(7);
		case 1108: return punishmentTextPhysical.sceneText(8);
		case 1109: return punishmentTextPhysical.sceneText(9);
		case 1200: return "Grope (1) WIP"; //sex pun
		case 1202: return "Hand job (2) WIP";
		case 1204: return "Oral job (3) WIP";
		case 1206: return "Anal sex (4) WIP";
		case 1208: return "Monster sex (5) WIP";
		case 1300: return punishmentTextBondage.sceneText(0); // bondage
		case 1302: return punishmentTextBondage.sceneText(1);
		case 1304: return punishmentTextBondage.sceneText(2);
		case 1306: return punishmentTextBondage.sceneText(3);
		case 1308: return punishmentTextBondage.sceneText(4);
		case 1400: return punishmentTextSexual.sceneText (0); // public
		case 1402: return punishmentTextSexual.sceneText (1);
		case 1404: return "Living canvas (3) - WIP";
		case 1406: return punishmentTextSexual.sceneText (3);
		case 1408: return punishmentTextSexual.sceneText (4);
		default: return "";

		}
	}
}
