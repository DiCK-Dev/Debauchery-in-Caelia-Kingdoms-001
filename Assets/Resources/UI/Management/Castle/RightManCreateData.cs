using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RightManCreateData : MonoBehaviour {

	public GameObject itemPrefabName; 

	public GameObject image1, image2, image3; 

	public void initFunName(){

		GameObject NPCName = Instantiate (itemPrefabName) as GameObject;
		NPCName.name = gameObject.name + " NPCName";
		NPCName.transform.parent = gameObject.transform;

		Text NPCname = NPCName.GetComponent<Text> ();
		NPCname.text = NPCCharList.CharRetainers [RightManCreatePan.retainerIndex].charName + " " +  NPCCharList.CharRetainers [RightManCreatePan.retainerIndex].charNickname + " " + NPCCharList.CharRetainers [RightManCreatePan.retainerIndex].charSurname ; 

	}

	public void initFunImage1(){
		
		GameObject Image1 = Instantiate (image1) as GameObject;
		image1.name = gameObject.name + " NPCImage1"; 
		Image1.transform.parent = gameObject.transform;

		Image _Image1 = Image1.GetComponent<Image> ();

		_Image1.sprite = Resources.Load<Sprite> ("Icons/Workers/" + loadClass()) as Sprite;

	}


	public void initFunImage2(){

		GameObject Image2 = Instantiate (image2) as GameObject;
		image2.name = gameObject.name + " NPCImage2"; 
		Image2.transform.parent = gameObject.transform;

		Image _Image2 = Image2.GetComponent<Image> ();

		_Image2.sprite = Resources.Load<Sprite> ("Icons/Workers/" + loadMood()) as Sprite;

	}



	public void initFunImage3(){

		GameObject Image3 = Instantiate (image3) as GameObject;
		image3.name = gameObject.name + " NPCImage3"; 
		Image3.transform.parent = gameObject.transform;

		Image _Image3 = Image3.GetComponent<Image> ();

		_Image3.sprite = Resources.Load<Sprite> ("Icons/Workers/" + loadPerformance()) as Sprite;
		//RightManCreatePan.retainerIndex++;
	}



	string loadMood(){
		if (NPCCharList.CharRetainers [RightManCreatePan.retainerIndex].attHappiness >= 100) {
			return "ecstatic";
		} else if (NPCCharList.CharRetainers [RightManCreatePan.retainerIndex].attHappiness >= 75) {
			return "happy";
		} else if (NPCCharList.CharRetainers [RightManCreatePan.retainerIndex].attHappiness >= 50) {
			return "fine";
		} else if (NPCCharList.CharRetainers [RightManCreatePan.retainerIndex].attHappiness >= 25) {
			return "sad";
		} else {
			return "depressed";
		}


	}

	string loadClass(){
		
		NPCData.Jobs npcJob = NPCCharList.CharRetainers [RightManCreatePan.retainerIndex].cityJobs;

		switch (npcJob) {
		case NPCData.Jobs.CastleDomestic:
			return "domestic";
		case NPCData.Jobs.CastleCook:
			return "cook";
		case NPCData.Jobs.CastleHealer:
			return "healer";
		case NPCData.Jobs.CastleHunter:
			return "hunter";
		case NPCData.Jobs.CastleEntertainer:
			return "entertainer";
		case NPCData.Jobs.CastleArtisan:
			return "artisan";
		case NPCData.Jobs.CastleFarmhand:
			return "farmhand";
		case NPCData.Jobs.CastleScribe:
			return "scribe";
		case NPCData.Jobs.CastleAccountant:
			return "accountant";
		case NPCData.Jobs.CastleSlaveMaster:
			return "slavemaster";
		case NPCData.Jobs.CastleGuard:
			return "guard";
		case NPCData.Jobs.CastleCaptain:
			return "captain";
		case NPCData.Jobs.CastleCourtier:
			return "courtier";
		case NPCData.Jobs.CastleCounselor:
			return "counselor";
		case NPCData.Jobs.CastleProstitute:
			return "prostitute";
		default:
			return "0";
		}

	}

	string loadPerformance(){
		int rew = NPCCharList.CharRetainers [RightManCreatePan.retainerIndex].workReward;
		switch (rew) {
		case 5:
			return "rew5";
		case 4:
			return "rew4";
		case 3:
			return "rew3";
		case 2:
			return "rew2";
		case 1:
			return "rew1";
		case -1:
			return "pun1";
		case -2:
			return "pun2";
		case -3:
			return "pun3";
		case -4:
			return "pun4";
		case -5:
			return "pun5";
		default:
			return "0";

		}

	}

}
