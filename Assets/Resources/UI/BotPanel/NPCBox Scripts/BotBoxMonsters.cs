using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BotBoxMonsters : MonoBehaviour {


	public Text NPCName;
	public Text NPCSex;
	public Text NPCCorruption;


	public Text statPhys, statMen, statSoc;
	public Text skill1, skill2, skill3, skill4, skill5, skill6, skill7, skill8, skill9;
	public Image imgphys, imgment, imgsoc;
	public Image imgskill1, imgskill2, imgskill3, imgskill4, imgskill5, imgskill6, imgskill7, imgskill8, imgskill9;	 



	public void loadCharacterGeneral(){
		NPCName.text = NPCCharList.CharMonster [0].charName + " - " + NPCCharList.CharMonster[0].charClass.ToString(); 

		/*
		NPCloyalty.text = Mathf.Round(NPCCharList.CharMonster [0].charLoyalty.ToString();
		NPCloyalty.text = "Loy: " + NPCloyalty.text;

		NPCRelationship.text = Mathf.Round(NPCCharList.CharMonster [0].charRelationship.ToString();
		NPCRelationship.text = "Rel: " + NPCRelationship.text;
		*/


		NPCCorruption.text = "Cor: " + Mathf.Round(NPCCharList.CharMonster [0].charCorruption).ToString();

		statPhys.text = Mathf.Round(NPCCharList.CharMonster [0].attPhysical).ToString();
		statMen.text = Mathf.Round(NPCCharList.CharMonster [0].attMental).ToString();
		statSoc.text = Mathf.Round(NPCCharList.CharMonster [0].attSocial).ToString();


		NPCSex.text = NPCCharList.CharMonster [0].charSex.toDescription ();




	}

	public void loadCoreSkills(){
		hoverSkills.pageSkill = 0;
		skill1.text = Mathf.Round(NPCCharList.CharMonster [0].coreSkillMartial).ToString ();
		skill2.text = Mathf.Round(NPCCharList.CharMonster [0].coreSkillSecurity).ToString ();
		skill3.text = Mathf.Round(NPCCharList.CharMonster [0].coreSkillLabor).ToString ();
		skill4.text = Mathf.Round(NPCCharList.CharMonster [0].coreSkillTactics).ToString ();
		skill5.text = Mathf.Round(NPCCharList.CharMonster [0].coreSkillGovernance).ToString ();
		skill6.text = Mathf.Round(NPCCharList.CharMonster [0].coreSkillStewardship).ToString ();
		skill7.text = Mathf.Round(NPCCharList.CharMonster [0].coreSkillPersuasion).ToString ();
		skill8.text = Mathf.Round(NPCCharList.CharMonster [0].coreSkillIntrigue).ToString ();
		skill9.text = Mathf.Round(NPCCharList.CharMonster [0].coreSkillDiplomacy).ToString ();


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
		hoverSkills.pageSkill = 1;

		skill1.text = Mathf.Round(NPCCharList.CharMonster [0].utilitySkillCrafting).ToString ();
		skill2.text = Mathf.Round(NPCCharList.CharMonster [0].utilitySkillHouseKeeping).ToString ();
		skill3.text = Mathf.Round(NPCCharList.CharMonster [0].utilitySkillFarmHand).ToString ();
		skill4.text = Mathf.Round(NPCCharList.CharMonster [0].utilitySkillMedicine).ToString ();
		skill5.text = Mathf.Round(NPCCharList.CharMonster [0].utilitySkillAlchemy).ToString ();
		skill6.text = Mathf.Round(NPCCharList.CharMonster [0].utilitySkillLearning).ToString ();
		skill7.text = Mathf.Round(NPCCharList.CharMonster [0].utilitySkillPerformance).ToString ();
		skill8.text = Mathf.Round(NPCCharList.CharMonster [0].utilitySkillEtiquette).ToString ();
		skill9.text = Mathf.Round(NPCCharList.CharMonster [0].utilitySkillStreetwise).ToString ();


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
		hoverSkills.pageSkill = 2;

		skill1.text = Mathf.Round(NPCCharList.CharMonster [0].sexSkillMasseuse).ToString ();
		skill2.text = Mathf.Round(NPCCharList.CharMonster [0].sexSkillStripping).ToString ();
		skill3.text = Mathf.Round(NPCCharList.CharMonster [0].sexSkillBondage).ToString ();
		skill4.text = Mathf.Round(NPCCharList.CharMonster [0].sexSkillPetplay).ToString ();
		skill5.text = Mathf.Round(NPCCharList.CharMonster [0].sexSkillPetting).ToString ();
		skill6.text = Mathf.Round(NPCCharList.CharMonster [0].sexSkillGroupSex).ToString ();
		skill7.text = Mathf.Round(NPCCharList.CharMonster [0].sexSkillPenetration).ToString ();
		skill8.text = Mathf.Round(NPCCharList.CharMonster [0].sexSkillWhoring).ToString ();
		skill9.text = Mathf.Round(NPCCharList.CharMonster [0].sexSkillEscorting).ToString ();


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
		loadCoreSkills ();
		loadCharacterGeneral ();
	}

	/*void Update(){
		loadCharacterGeneral ();

	}*/
}
