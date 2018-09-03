using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PanLeftPlayerSkills : MonoBehaviour {


	public Text attPhysical;
	public Text attMental;
	public Text attSocial;

	public Text skillCore1;
	public Text skillCore2;
	public Text skillCore3;
	public Text skillCore4;
	public Text skillCore5;
	public Text skillCore6;
	public Text skillCore7;
	public Text skillCore8;
	public Text skillCore9;

	public Text skillUtility1;
	public Text skillUtility2;
	public Text skillUtility3;
	public Text skillUtility4;
	public Text skillUtility5;
	public Text skillUtility6;
	public Text skillUtility7;
	public Text skillUtility8;
	public Text skillUtility9;

	public Text skillSex1;
	public Text skillSex2;
	public Text skillSex3;
	public Text skillSex4;
	public Text skillSex5;
	public Text skillSex6;
	public Text skillSex7;
	public Text skillSex8;
	public Text skillSex9;



	public void loadSkills(){

		attPhysical.text = GameControl.attPhysical.ToString ();
		attMental.text = GameControl.attMental.ToString ();
		attSocial.text = GameControl.attSocial.ToString ();

		float skillcore1 = GameControl.coreSkillMartial + GameControl.coreSkillBonus[0];
		skillCore1.text = skillcore1.ToString();

		float skillcore2 = GameControl.coreSkillSecurity +  GameControl.coreSkillBonus[1];
		skillCore2.text = skillcore2.ToString();

		float  skillcore3 = GameControl.coreSkillLabor +  GameControl.coreSkillBonus[2];
		skillCore3.text = skillcore3.ToString();

		float  skillcore4 = GameControl.coreSkillTactics +  GameControl.coreSkillBonus[3];
		skillCore4.text = skillcore4.ToString();

		float  skillcore5 = GameControl.coreSkillGovernance +  GameControl.coreSkillBonus[4];
		skillCore5.text = skillcore5.ToString();

		float  skillcore6 = GameControl.coreSkillStewardship +  GameControl.coreSkillBonus[5];
		skillCore6.text = skillcore6.ToString();

		float  skillcore7 = GameControl.coreSkillPersuasion +  GameControl.coreSkillBonus[6];
		skillCore7.text = skillcore7.ToString();

		float  skillcore8 = GameControl.coreSkillIntrigue +  GameControl.coreSkillBonus[7];
		skillCore8.text = skillcore8.ToString();

		float  skillcore9 = GameControl.coreSkillDiplomacy +  GameControl.coreSkillBonus[8];
		skillCore9.text = skillcore9.ToString();


		float skillutility1 = GameControl.utilitySkillCrafting+ GameControl.utilitySkillBonus[0];
		skillUtility1.text = skillutility1.ToString();

		float skillutility2 = GameControl.utilitySkillHouseKeeping +  GameControl.utilitySkillBonus[1];
		skillUtility2.text = skillutility2.ToString();

		float  skillutility3 = GameControl.utilitySkillFarmHand +  GameControl.utilitySkillBonus[2];
		skillUtility3.text = skillutility3.ToString();

		float  skillutility4 = GameControl.utilitySkillMedicine +  GameControl.utilitySkillBonus[3];
		skillUtility4.text = skillutility4.ToString();

		float  skillutility5 = GameControl.utilitySkillAlchemy +  GameControl.utilitySkillBonus[4];
		skillUtility5.text = skillutility5.ToString();

		float  skillutility6 = GameControl.utilitySkillLearning +  GameControl.utilitySkillBonus[5];
		skillUtility6.text = skillutility6.ToString();

		float  skillutility7 = GameControl.utilitySkillPerformance +  GameControl.utilitySkillBonus[6];
		skillUtility7.text = skillutility7.ToString();

		float  skillutility8 = GameControl.utilitySkillEtiquette +  GameControl.utilitySkillBonus[7];
		skillUtility8.text = skillutility8.ToString();

		float  skillutility9 = GameControl.utilitySkillStreetwise +  GameControl.utilitySkillBonus[8];
		skillUtility9.text = skillutility9.ToString();
	


		float skillsex1 = GameControl.sexSkillMasseuse + GameControl.sexSkillBonus[0];
		skillSex1.text = skillsex1.ToString();

		float skillsex2 = GameControl.sexSkillStripping +  GameControl.sexSkillBonus[1];
		skillSex2.text = skillsex2.ToString();

		float  skillsex3 = GameControl.sexSkillBondage +  GameControl.sexSkillBonus[2];
		skillSex3.text = skillsex3.ToString();

		float  skillsex4 = GameControl.sexSkillPetplay +  GameControl.sexSkillBonus[3];
		skillSex4.text = skillsex4.ToString();

		float  skillsex5 = GameControl.sexSkillPetting +  GameControl.sexSkillBonus[4];
		skillSex5.text = skillsex5.ToString();

		float  skillsex6 = GameControl.sexSkillGroupSex +  GameControl.sexSkillBonus[5];
		skillSex6.text = skillsex6.ToString();

		float  skillsex7 = GameControl.sexSkillPenetration +  GameControl.sexSkillBonus[6];
		skillSex7.text = skillsex7.ToString();

		float  skillsex8 = GameControl.sexSkillWhoring +  GameControl.sexSkillBonus[7];
		skillSex8.text = skillsex8.ToString();

		float  skillsex9 = GameControl.sexSkillEscorting +  GameControl.sexSkillBonus[8];
		skillSex9.text = skillsex9.ToString();
	}



	void Update(){
		loadSkills ();
	}


}
