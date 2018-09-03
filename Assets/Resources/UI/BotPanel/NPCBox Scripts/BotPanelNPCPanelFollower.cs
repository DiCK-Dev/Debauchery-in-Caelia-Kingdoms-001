using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BotPanelNPCPanelFollower : MonoBehaviour {
	int tempSeletion;
	public Text NPCName;
	public Text NPCSex;
	public Text NPCloyalty;
	public Text NPCRelationship;
	public Text NPCCorruption;

	public Text statPhys, statMen, statSoc;
	public Text skill1, skill2, skill3, skill4, skill5, skill6, skill7, skill8, skill9;
	public Image imgphys, imgment, imgsoc;
	public Image imgskill1, imgskill2, imgskill3, imgskill4, imgskill5, imgskill6, imgskill7, imgskill8, imgskill9;	 

	public Slider sliHealth, sliArousal, sliMP;
	public Text currHP, currAro, currMP;

	static int i; 

	void loadNPC()
	{
		

		if (WorldControl.NPCID < 10000000) {

			i = 0;
			while (i < NPCCharList.CharFollower.Count) {
				if (NPCCharList.CharFollower [i].charID == WorldControl.NPCID) {

					break;
				}

				i++;
			}
		} else {
			i = 0;
			while (i < NPCCharList.CharRetainers.Count) {
				if (NPCCharList.CharRetainers [i].charID == WorldControl.NPCID) {

					break;
				}

				i++;
			}


		}



	}


	public void loadCharacterGeneral(){

		if (WorldControl.NPCID < 1000000) {

			sliHealth.value = (NPCCharList.CharFollower [i].currentHealth / NPCCharList.CharFollower [i].maxHealth)*100;
			sliArousal.value = (NPCCharList.CharFollower [i].currentArousal / NPCCharList.CharFollower [i].maxArousal)*100;
			sliMP.value = (NPCCharList.CharFollower [i].currentMP / NPCCharList.CharFollower [i].maxMP) *100;
		
			currHP.text = NPCCharList.CharFollower [i].currentHealth.ToString() + "/" +  NPCCharList.CharFollower [i].maxHealth.ToString() ;
			currMP.text = NPCCharList.CharFollower [i].currentMP.ToString() + "/" + NPCCharList.CharFollower [i].maxMP.ToString ();
			currAro.text = NPCCharList.CharFollower [i].currentArousal.ToString() + "/" + NPCCharList.CharFollower [i].maxArousal.ToString();

				
			NPCName.text = NPCCharList.CharFollower [i].charName + " " + NPCCharList.CharFollower [i].charSurname;

			NPCloyalty.text = Mathf.Round (NPCCharList.CharFollower [i].charLoyalty).ToString ();
			NPCloyalty.text = "Loy: " + NPCloyalty.text;

			NPCRelationship.text = Mathf.Round (NPCCharList.CharFollower [i].charRelationship).ToString ();
			NPCRelationship.text = "Rel: " + NPCRelationship.text;

			NPCCorruption.text = Mathf.Round (NPCCharList.CharFollower [i].charCorruption).ToString ();
			NPCCorruption.text = "Cor: " + NPCCorruption.text;

			statPhys.text = Mathf.Round (NPCCharList.CharFollower [i].attPhysical).ToString ();
			statMen.text = Mathf.Round (NPCCharList.CharFollower [i].attMental).ToString ();
			statSoc.text = Mathf.Round (NPCCharList.CharFollower [i].attSocial).ToString ();



			if (NPCCharList.CharFollower [i].charSex == NPCData.CharSex.Woman) {
				NPCSex.text = "Woman";
			}
			if (NPCCharList.CharFollower [i].charSex == NPCData.CharSex.Man) {
				NPCSex.text = "Man";
			}
			if (NPCCharList.CharFollower [i].charSex == NPCData.CharSex.Dickgirl) {
				NPCSex.text = "Dickgirl";
			}
			if (NPCCharList.CharFollower [i].charSex == NPCData.CharSex.Futanari) {
				NPCSex.text = "Futanari";
			}
			if (NPCCharList.CharFollower [i].charSex == NPCData.CharSex.Cuntboy) {
				NPCSex.text = "Cuntboy";
			}


		} else {

			sliHealth.value = (NPCCharList.CharRetainers [i].currentHealth / NPCCharList.CharRetainers [i].maxHealth)*100;
			sliArousal.value = (NPCCharList.CharRetainers [i].currentArousal / NPCCharList.CharRetainers [i].maxArousal) *100;
			sliMP.value = (NPCCharList.CharRetainers [i].currentMP / NPCCharList.CharRetainers [i].maxMP) * 100;
			currHP.text = NPCCharList.CharRetainers [i].currentHealth.ToString() + "/" +  NPCCharList.CharRetainers [i].maxHealth.ToString();
			currMP.text = NPCCharList.CharRetainers [i].currentMP.ToString() + "/"+ NPCCharList.CharRetainers [i].maxMP.ToString ();
			currAro.text = NPCCharList.CharRetainers [i].currentArousal.ToString() + "/"+ NPCCharList.CharRetainers [i].maxArousal.ToString();

			NPCName.text = NPCCharList.CharRetainers [i].charName + " " + NPCCharList.CharRetainers [i].charSurname;

			NPCloyalty.text = Mathf.Round (NPCCharList.CharRetainers [i].charLoyalty).ToString ();
			NPCloyalty.text = "Loy: " + NPCloyalty.text;

			NPCRelationship.text = Mathf.Round (NPCCharList.CharRetainers [i].charRelationship).ToString ();
			NPCRelationship.text = "Rel: " + NPCRelationship.text;

			NPCCorruption.text = Mathf.Round (NPCCharList.CharRetainers [i].charCorruption).ToString ();
			NPCCorruption.text = "Cor: " + NPCCorruption.text;

			statPhys.text = Mathf.Round (NPCCharList.CharRetainers [i].attPhysical).ToString ();
			statMen.text = Mathf.Round (NPCCharList.CharRetainers [i].attMental).ToString ();
			statSoc.text = Mathf.Round (NPCCharList.CharRetainers [i].attSocial).ToString ();



			if (NPCCharList.CharRetainers [i].charSex == NPCData.CharSex.Woman) {
				NPCSex.text = "Woman";
			}
			if (NPCCharList.CharRetainers [i].charSex == NPCData.CharSex.Man) {
				NPCSex.text = "Man";
			}
			if (NPCCharList.CharRetainers [i].charSex == NPCData.CharSex.Dickgirl) {
				NPCSex.text = "Dickgirl";
			}
			if (NPCCharList.CharRetainers [i].charSex == NPCData.CharSex.Futanari) {
				NPCSex.text = "Futanari";
			}
			if (NPCCharList.CharRetainers [i].charSex == NPCData.CharSex.Cuntboy) {
				NPCSex.text = "Cuntboy";
			}

		}

	}


	public void loadCoreSkills(){
		hoverSkills.pageSkill = 0;

		if (WorldControl.NPCID < 1000000) {
			skill1.text = Mathf.Round (NPCCharList.CharFollower [i].coreSkillMartial).ToString ();
			skill2.text = Mathf.Round (NPCCharList.CharFollower [i].coreSkillSecurity).ToString ();
			skill3.text = Mathf.Round (NPCCharList.CharFollower [i].coreSkillLabor).ToString ();
			skill4.text = Mathf.Round (NPCCharList.CharFollower [i].coreSkillTactics).ToString ();
			skill5.text = Mathf.Round (NPCCharList.CharFollower [i].coreSkillGovernance).ToString ();
			skill6.text = Mathf.Round (NPCCharList.CharFollower [i].coreSkillStewardship).ToString ();
			skill7.text = Mathf.Round (NPCCharList.CharFollower [i].coreSkillPersuasion).ToString ();
			skill8.text = Mathf.Round (NPCCharList.CharFollower [i].coreSkillIntrigue).ToString ();
			skill9.text = Mathf.Round (NPCCharList.CharFollower [i].coreSkillDiplomacy).ToString ();
		} else {

			skill1.text = Mathf.Round (NPCCharList.CharRetainers [i].coreSkillMartial).ToString ();
			skill2.text = Mathf.Round (NPCCharList.CharRetainers [i].coreSkillSecurity).ToString ();
			skill3.text = Mathf.Round (NPCCharList.CharRetainers [i].coreSkillLabor).ToString ();
			skill4.text = Mathf.Round (NPCCharList.CharRetainers [i].coreSkillTactics).ToString ();
			skill5.text = Mathf.Round (NPCCharList.CharRetainers [i].coreSkillGovernance).ToString ();
			skill6.text = Mathf.Round (NPCCharList.CharRetainers [i].coreSkillStewardship).ToString ();
			skill7.text = Mathf.Round (NPCCharList.CharRetainers [i].coreSkillPersuasion).ToString ();
			skill8.text = Mathf.Round (NPCCharList.CharRetainers [i].coreSkillIntrigue).ToString ();
			skill9.text = Mathf.Round (NPCCharList.CharRetainers [i].coreSkillDiplomacy).ToString ();





		}

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
	
		if (WorldControl.NPCID < 1000000) {
			skill1.text = Mathf.Round (NPCCharList.CharFollower [i].utilitySkillCrafting).ToString ();
			skill2.text = Mathf.Round (NPCCharList.CharFollower [i].utilitySkillHouseKeeping).ToString ();
			skill3.text = Mathf.Round (NPCCharList.CharFollower [i].utilitySkillFarmHand).ToString ();
			skill4.text = Mathf.Round (NPCCharList.CharFollower [i].utilitySkillMedicine).ToString ();
			skill5.text = Mathf.Round (NPCCharList.CharFollower [i].utilitySkillAlchemy).ToString ();
			skill6.text = Mathf.Round (NPCCharList.CharFollower [i].utilitySkillLearning).ToString ();
			skill7.text = Mathf.Round (NPCCharList.CharFollower [i].utilitySkillPerformance).ToString ();
			skill8.text = Mathf.Round (NPCCharList.CharFollower [i].utilitySkillEtiquette).ToString ();
			skill9.text = Mathf.Round (NPCCharList.CharFollower [i].utilitySkillStreetwise).ToString ();
		} else {

			skill1.text = Mathf.Round (NPCCharList.CharRetainers [i].utilitySkillCrafting).ToString ();
			skill2.text = Mathf.Round (NPCCharList.CharRetainers [i].utilitySkillHouseKeeping).ToString ();
			skill3.text = Mathf.Round (NPCCharList.CharRetainers [i].utilitySkillFarmHand).ToString ();
			skill4.text = Mathf.Round (NPCCharList.CharRetainers [i].utilitySkillMedicine).ToString ();
			skill5.text = Mathf.Round (NPCCharList.CharRetainers [i].utilitySkillAlchemy).ToString ();
			skill6.text = Mathf.Round (NPCCharList.CharRetainers [i].utilitySkillLearning).ToString ();
			skill7.text = Mathf.Round (NPCCharList.CharRetainers [i].utilitySkillPerformance).ToString ();
			skill8.text = Mathf.Round (NPCCharList.CharRetainers [i].utilitySkillEtiquette).ToString ();
			skill9.text = Mathf.Round (NPCCharList.CharRetainers [i].utilitySkillStreetwise).ToString ();



		}

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

		if (WorldControl.NPCID < 1000000) {
			skill1.text = Mathf.Round (NPCCharList.CharFollower [i].sexSkillMasseuse).ToString ();
			skill2.text = Mathf.Round (NPCCharList.CharFollower [i].sexSkillStripping).ToString ();
			skill3.text = Mathf.Round (NPCCharList.CharFollower [i].sexSkillBondage).ToString ();
			skill4.text = Mathf.Round (NPCCharList.CharFollower [i].sexSkillPetplay).ToString ();
			skill5.text = Mathf.Round (NPCCharList.CharFollower [i].sexSkillPetting).ToString ();
			skill6.text = Mathf.Round (NPCCharList.CharFollower [i].sexSkillGroupSex).ToString ();
			skill7.text = Mathf.Round (NPCCharList.CharFollower [i].sexSkillPenetration).ToString ();
			skill8.text = Mathf.Round (NPCCharList.CharFollower [i].sexSkillWhoring).ToString ();
			skill9.text = Mathf.Round (NPCCharList.CharFollower [i].sexSkillEscorting).ToString ();
		} else {

			skill1.text = Mathf.Round (NPCCharList.CharRetainers [i].sexSkillMasseuse).ToString ();
			skill2.text = Mathf.Round (NPCCharList.CharRetainers [i].sexSkillStripping).ToString ();
			skill3.text = Mathf.Round (NPCCharList.CharRetainers [i].sexSkillBondage).ToString ();
			skill4.text = Mathf.Round (NPCCharList.CharRetainers [i].sexSkillPetplay).ToString ();
			skill5.text = Mathf.Round (NPCCharList.CharRetainers [i].sexSkillPetting).ToString ();
			skill6.text = Mathf.Round (NPCCharList.CharRetainers [i].sexSkillGroupSex).ToString ();
			skill7.text = Mathf.Round (NPCCharList.CharRetainers [i].sexSkillPenetration).ToString ();
			skill8.text = Mathf.Round (NPCCharList.CharRetainers [i].sexSkillWhoring).ToString ();
			skill9.text = Mathf.Round (NPCCharList.CharRetainers [i].sexSkillEscorting).ToString ();


		}

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

	public void loadCharFun(){
		if (WorldControl.NPCID != 0 && WorldControl.NPCID != tempSeletion) {
			loadNPC ();
			loadCharacterGeneral ();
			loadUtilitySkills ();
			loadSexSkills ();
			loadCoreSkills ();
			tempSeletion = WorldControl.NPCID;
		}

	}


	void Update(){
		loadCharFun ();

	}

	void Awake()
	{


		if (Screen.height > 1024) {
			NPCName.fontSize = 25;
			NPCSex.fontSize = 20;
			NPCloyalty.fontSize = 20;
			NPCRelationship.fontSize = 20;
			NPCCorruption.fontSize = 20;

		}
		if (Screen.height > 1600) {
			NPCName.fontSize = 30;
			NPCSex.fontSize = 25;
			NPCloyalty.fontSize = 25;
			NPCRelationship.fontSize = 25;
			NPCCorruption.fontSize = 25;

		}

	}


	void Start(){
		loadCoreSkills ();
	}


}
