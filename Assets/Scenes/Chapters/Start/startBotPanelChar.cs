using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class startBotPanelChar : MonoBehaviour {

	public Text NPCName;
	public Text NPCSex;
	public Text NPCCorruption;
	public Text inputFieldName; 

	public Text statPhys, statMen, statSoc;
	public Text skill1, skill2, skill3, skill4, skill5, skill6, skill7, skill8, skill9;
	public Image imgphys, imgment, imgsoc;
	public Image imgskill1, imgskill2, imgskill3, imgskill4, imgskill5, imgskill6, imgskill7, imgskill8, imgskill9;	 



	public void loadCharacterGeneral(){

		NPCName.text = inputFieldName.text;

		/*
		NPCloyalty.text = GameControl.charLoyalty.ToString();
		NPCloyalty.text = "Loy: " + NPCloyalty.text;

		NPCRelationship.text = GameControl.charRelationship.ToString();
		NPCRelationship.text = "Rel: " + NPCRelationship.text;
		*/


		NPCCorruption.text = GameControl.charCorruption.ToString();
		NPCCorruption.text = "Cor: " + NPCCorruption.text;

		statPhys.text = GameControl.attPhysical.ToString();
		statMen.text = GameControl.attMental.ToString();
		statSoc.text = GameControl.attSocial.ToString();


		NPCSex.text = GameControl.mcSex.toDescription ();




	}


	public void loadCoreSkills(){

		skill1.text = GameControl.coreSkillMartial.ToString ();
		skill2.text = GameControl.coreSkillSecurity.ToString ();
		skill3.text = GameControl.coreSkillLabor.ToString ();
		skill4.text = GameControl.coreSkillTactics.ToString ();
		skill5.text = GameControl.coreSkillGovernance.ToString ();
		skill6.text = GameControl.coreSkillStewardship.ToString ();
		skill7.text = GameControl.coreSkillPersuasion.ToString ();
		skill8.text = GameControl.coreSkillIntrigue.ToString ();
		skill9.text = GameControl.coreSkillDiplomacy.ToString ();


		imgskill1.sprite = Resources.Load<Sprite> ("Icons/Skills/skillMartial") as Sprite;
		imgskill2.sprite = Resources.Load<Sprite> ("Icons/Skills/skillSecurity") as Sprite;
		imgskill3.sprite = Resources.Load<Sprite> ("Icons/Skills/skillLabor") as Sprite;
		imgskill4.sprite = Resources.Load<Sprite> ("Icons/Skills/skillTactics") as Sprite;
		imgskill5.sprite = Resources.Load<Sprite> ("Icons/Skills/skillGovernance") as Sprite;
		imgskill6.sprite = Resources.Load<Sprite> ("Icons/Skills/skillStewardship") as Sprite;
		imgskill7.sprite = Resources.Load<Sprite> ("Icons/Skills/skillPersuasion") as Sprite;
		imgskill8.sprite = Resources.Load<Sprite> ("Icons/Skills/skillIntrigue") as Sprite;
		imgskill9.sprite = Resources.Load<Sprite> ("Icons/Skills/skillDiplomacy") as Sprite;


		//	followerPortrait.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/" + localID) as Sprite;
	}

	public void loadUtilitySkills(){


		skill1.text = GameControl.utilitySkillCrafting.ToString ();
		skill2.text = GameControl.utilitySkillHouseKeeping.ToString ();
		skill3.text = GameControl.utilitySkillFarmHand.ToString ();
		skill4.text = GameControl.utilitySkillMedicine.ToString ();
		skill5.text = GameControl.utilitySkillAlchemy.ToString ();
		skill6.text = GameControl.utilitySkillLearning.ToString ();
		skill7.text = GameControl.utilitySkillPerformance.ToString ();
		skill8.text = GameControl.utilitySkillEtiquette.ToString ();
		skill9.text = GameControl.utilitySkillStreetwise.ToString ();


		imgskill1.sprite = Resources.Load<Sprite> ("Icons/Skills/skillCrafting") as Sprite;
		imgskill2.sprite = Resources.Load<Sprite> ("Icons/Skills/skillHouse") as Sprite;
		imgskill3.sprite = Resources.Load<Sprite> ("Icons/Skills/skillFarmHand") as Sprite;
		imgskill4.sprite = Resources.Load<Sprite> ("Icons/Skills/skillMedicine") as Sprite;
		imgskill5.sprite = Resources.Load<Sprite> ("Icons/Skills/skillAlchemy") as Sprite;
		imgskill6.sprite = Resources.Load<Sprite> ("Icons/Skills/skillLearning") as Sprite;
		imgskill7.sprite = Resources.Load<Sprite> ("Icons/Skills/skillPerformance") as Sprite;
		imgskill8.sprite = Resources.Load<Sprite> ("Icons/Skills/skillEtiquette") as Sprite;
		imgskill9.sprite = Resources.Load<Sprite> ("Icons/Skills/skillStreetwise") as Sprite;
	}

	public void loadSexSkills(){


		skill1.text = GameControl.sexSkillMasseuse.ToString ();
		skill2.text = GameControl.sexSkillStripping.ToString ();
		skill3.text = GameControl.sexSkillBondage.ToString ();
		skill4.text = GameControl.sexSkillPetplay.ToString ();
		skill5.text = GameControl.sexSkillPetting.ToString ();
		skill6.text = GameControl.sexSkillGroupSex.ToString ();
		skill7.text = GameControl.sexSkillPenetration.ToString ();
		skill8.text = GameControl.sexSkillWhoring.ToString ();
		skill9.text = GameControl.sexSkillEscorting.ToString ();


		imgskill1.sprite = Resources.Load<Sprite> ("Icons/Skills/skillMasseuse") as Sprite;
		imgskill2.sprite = Resources.Load<Sprite> ("Icons/Skills/skillStripping") as Sprite;
		imgskill3.sprite = Resources.Load<Sprite> ("Icons/Skills/skillBondage") as Sprite;
		imgskill4.sprite = Resources.Load<Sprite> ("Icons/Skills/skillPetPlay") as Sprite;
		imgskill5.sprite = Resources.Load<Sprite> ("Icons/Skills/skillPetting") as Sprite;
		imgskill6.sprite = Resources.Load<Sprite> ("Icons/Skills/skillGroupSex") as Sprite;
		imgskill7.sprite = Resources.Load<Sprite> ("Icons/Skills/skillPenetration") as Sprite;
		imgskill8.sprite = Resources.Load<Sprite> ("Icons/Skills/skillWhoring") as Sprite;
		imgskill9.sprite = Resources.Load<Sprite> ("Icons/Skills/skillEscorting") as Sprite;

	}









	void Awake()
	{


		if (Screen.height > 1024) {
			NPCName.fontSize = 25;
			NPCSex.fontSize = 20;
			//NPCloyalty.fontSize = 20;
			//NPCRelationship.fontSize = 20;
			NPCCorruption.fontSize = 20;

		}
		if (Screen.height > 1600) {
			NPCName.fontSize = 30;
			NPCSex.fontSize = 25;
			//NPCloyalty.fontSize = 25;
			//NPCRelationship.fontSize = 25;
			NPCCorruption.fontSize = 25;

		}

	}

	void Start(){

	}

	void Update(){

			loadCharacterGeneral ();


	}
}
