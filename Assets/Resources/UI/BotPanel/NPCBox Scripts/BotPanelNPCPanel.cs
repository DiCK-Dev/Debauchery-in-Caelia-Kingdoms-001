using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BotPanelNPCPanel : MonoBehaviour {

	public Text NPCName;
	public Text NPCSex;
	public Text NPCloyalty;
	public Text NPCRelationship;
	public Text NPCCorruption;

	public Text statPhys, statMen, statSoc;
	public Text skill1, skill2, skill3, skill4, skill5, skill6, skill7, skill8, skill9;
	public Image imgphys, imgment, imgsoc;
	public Image imgskill1, imgskill2, imgskill3, imgskill4, imgskill5, imgskill6, imgskill7, imgskill8, imgskill9;	 

	static int i; 

	void loadNPC()
	{
		i = 0;
		while (i < NPCCharList.CharRetainers.Count) {
			if (NPCCharList.CharRetainers[i].charID == WorldControl.NPCID) {

				break;
			}

			i++;
		}
	}


	public void loadCharacterGeneral(){
		
		Debug.Log ("i value is " + i);
		NPCName.text = NPCCharList.CharRetainers[i].charName;

		NPCloyalty.text = NPCCharList.CharRetainers[i].charLoyalty.ToString();
		NPCloyalty.text = "Loy: " + NPCloyalty.text;

		NPCRelationship.text = NPCCharList.CharRetainers[i].charRelationship.ToString();
		NPCRelationship.text = "Rel: " + NPCRelationship.text;

		NPCCorruption.text = NPCCharList.CharRetainers[i].charCorruption.ToString();
		NPCCorruption.text = "Cor: " + NPCCorruption.text;

		statPhys.text = NPCCharList.CharRetainers[i].attPhysical.ToString();
		statMen.text = NPCCharList.CharRetainers[i].attMental.ToString();
		statSoc.text = NPCCharList.CharRetainers[i].attSocial.ToString();



		if(NPCCharList.CharRetainers[i].charSex == NPCData.CharSex.Woman)
		{
			NPCSex.text = "Woman";
		}
		if(NPCCharList.CharRetainers[i].charSex == NPCData.CharSex.Man)
		{
			NPCSex.text = "Man";
		}
		if(NPCCharList.CharRetainers[i].charSex == NPCData.CharSex.Dickgirl)
		{
			NPCSex.text = "Dickgirl";
		}
		if(NPCCharList.CharRetainers[i].charSex == NPCData.CharSex.Futanari)
		{
			NPCSex.text = "Futanari";
		}
		if(NPCCharList.CharRetainers[i].charSex == NPCData.CharSex.Cuntboy)
		{
			NPCSex.text = "Cuntboy";
		}


	}


	public void loadCoreSkills(){

		skill1.text = NPCCharList.CharRetainers[i].coreSkillMartial.ToString ();
		skill2.text = NPCCharList.CharRetainers[i].coreSkillSecurity.ToString ();
		skill3.text = NPCCharList.CharRetainers[i].coreSkillLabor.ToString ();
		skill4.text = NPCCharList.CharRetainers[i].coreSkillTactics.ToString ();
		skill5.text = NPCCharList.CharRetainers[i].coreSkillGovernance.ToString ();
		skill6.text = NPCCharList.CharRetainers[i].coreSkillStewardship.ToString ();
		skill7.text = NPCCharList.CharRetainers[i].coreSkillPersuasion.ToString ();
		skill8.text = NPCCharList.CharRetainers[i].coreSkillIntrigue.ToString ();
		skill9.text = NPCCharList.CharRetainers[i].coreSkillDiplomacy.ToString ();
	

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

	
		skill1.text = NPCCharList.CharRetainers[i].utilitySkillCrafting.ToString ();
		skill2.text = NPCCharList.CharRetainers[i].utilitySkillHouseKeeping.ToString ();
		skill3.text = NPCCharList.CharRetainers[i].utilitySkillFarmHand.ToString ();
		skill4.text = NPCCharList.CharRetainers[i].utilitySkillMedicine.ToString ();
		skill5.text = NPCCharList.CharRetainers[i].utilitySkillAlchemy.ToString ();
		skill6.text = NPCCharList.CharRetainers[i].utilitySkillLearning.ToString ();
		skill7.text = NPCCharList.CharRetainers[i].utilitySkillPerformance.ToString ();
		skill8.text = NPCCharList.CharRetainers[i].utilitySkillEtiquette.ToString ();
		skill9.text = NPCCharList.CharRetainers[i].utilitySkillStreetwise.ToString ();


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


		skill1.text = NPCCharList.CharRetainers[i].sexSkillMasseuse.ToString ();
		skill2.text = NPCCharList.CharRetainers[i].sexSkillStripping.ToString ();
		skill3.text = NPCCharList.CharRetainers[i].sexSkillBondage.ToString ();
		skill4.text = NPCCharList.CharRetainers[i].sexSkillPetplay.ToString ();
		skill5.text = NPCCharList.CharRetainers[i].sexSkillPetting.ToString ();
		skill6.text = NPCCharList.CharRetainers[i].sexSkillGroupSex.ToString ();
		skill7.text = NPCCharList.CharRetainers[i].sexSkillPenetration.ToString ();
		skill8.text = NPCCharList.CharRetainers[i].sexSkillWhoring.ToString ();
		skill9.text = NPCCharList.CharRetainers[i].sexSkillEscorting.ToString ();


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
		if (WorldControl.NPCID != 0) {
			loadNPC ();
			loadCharacterGeneral ();
			loadCoreSkills ();
		}

	}


	void Start(){
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
	


}
