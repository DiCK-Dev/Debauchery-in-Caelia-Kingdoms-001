using UnityEngine;
using System.Collections;

public class NPCSettlerRankAdjustment {


	public void rankAdjustment(){
		attAdjustments ();
		adjustMin ();
		if (NPCCreator.TempList [0].charRank == NPCData.CharRank.S) {
			rankMaxAd (100);
		}else if (NPCCreator.TempList [0].charRank == NPCData.CharRank.A) {
			rankMaxAd (90);
		}else if (NPCCreator.TempList [0].charRank == NPCData.CharRank.B) {
			rankMaxAd (80);
		}else {
			rankMaxAd (70);
		}


	}

	void rankMaxAd(int max){
		if (NPCCreator.TempList [0].attPhysical > max) {
			NPCCreator.TempList [0].attPhysical = max;
		}

		if (NPCCreator.TempList [0].attMental > max) {
			NPCCreator.TempList [0].attMental = max;
		}

		if (NPCCreator.TempList [0].attSocial > max) {
			NPCCreator.TempList [0].attSocial = max;
		}

		if (NPCCreator.TempList [0].attMagicPower > max) {
			NPCCreator.TempList [0].attMagicPower = max;
		}

		if (NPCCreator.TempList [0].coreSkillMartial > max) {
			NPCCreator.TempList [0].coreSkillMartial = max;
		}

		if (NPCCreator.TempList [0].coreSkillSecurity > max) {
			NPCCreator.TempList [0].coreSkillSecurity = max;
		}

		if (NPCCreator.TempList [0].coreSkillLabor > max) {
			NPCCreator.TempList [0].attMagicPower = max;
		}

		if (NPCCreator.TempList [0].coreSkillTactics > max) {
			NPCCreator.TempList [0].coreSkillTactics = max;
		}

		if (NPCCreator.TempList [0].coreSkillGovernance > max) {
			NPCCreator.TempList [0].coreSkillGovernance = max;
		}

		if (NPCCreator.TempList [0].coreSkillStewardship> max) {
			NPCCreator.TempList [0].coreSkillStewardship= max;
		}

		if (NPCCreator.TempList [0].coreSkillPersuasion > max) {
			NPCCreator.TempList [0].coreSkillPersuasion = max;
		}

		if (NPCCreator.TempList [0].coreSkillIntrigue > max) {
			NPCCreator.TempList [0].coreSkillIntrigue = max;
		}

		if (NPCCreator.TempList [0].coreSkillDiplomacy > max) {
			NPCCreator.TempList [0].coreSkillDiplomacy = max;
		}

		if (NPCCreator.TempList [0].utilitySkillCrafting > max) {
			NPCCreator.TempList [0].utilitySkillCrafting = max;
		}

		if (NPCCreator.TempList [0].utilitySkillHouseKeeping > max) {
			NPCCreator.TempList [0].utilitySkillHouseKeeping = max;
		}

		if (NPCCreator.TempList [0].utilitySkillFarmHand > max) {
			NPCCreator.TempList [0].utilitySkillFarmHand = max;
		}

		if (NPCCreator.TempList [0].utilitySkillMedicine > max) {
			NPCCreator.TempList [0].utilitySkillMedicine = max;
		}

		if (NPCCreator.TempList [0].utilitySkillAlchemy > max) {
			NPCCreator.TempList [0].utilitySkillAlchemy = max;
		}

		if (NPCCreator.TempList [0].utilitySkillLearning > max) {
			NPCCreator.TempList [0].utilitySkillLearning = max;
		}

		if (NPCCreator.TempList [0].utilitySkillPerformance > max) {
			NPCCreator.TempList [0].utilitySkillPerformance = max;
		}

		if (NPCCreator.TempList [0].utilitySkillEtiquette > max) {
			NPCCreator.TempList [0].utilitySkillEtiquette = max;
		}

		if (NPCCreator.TempList [0].utilitySkillStreetwise > max) {
			NPCCreator.TempList [0].utilitySkillStreetwise = max;
		}

		if (NPCCreator.TempList [0].sexSkillMasseuse > max) {
			NPCCreator.TempList [0].sexSkillMasseuse = max;
		}

		if (NPCCreator.TempList [0].sexSkillStripping > max) {
			NPCCreator.TempList [0].sexSkillStripping = max;
		}

		if (NPCCreator.TempList [0].sexSkillBondage > max) {
			NPCCreator.TempList [0].sexSkillBondage = max;
		}

		if (NPCCreator.TempList [0].sexSkillPetplay > max) {
			NPCCreator.TempList [0].sexSkillPetplay = max;
		}

		if (NPCCreator.TempList [0].sexSkillPetting > max) {
			NPCCreator.TempList [0].sexSkillPetting = max;
		}

		if (NPCCreator.TempList [0].sexSkillGroupSex > max) {
			NPCCreator.TempList [0].sexSkillGroupSex = max;
		}

		if (NPCCreator.TempList [0].sexSkillPenetration > max) {
			NPCCreator.TempList [0].sexSkillPenetration = max;
		}

		if (NPCCreator.TempList [0].sexSkillWhoring > max) {
			NPCCreator.TempList [0].sexSkillWhoring = max;
		}

		if (NPCCreator.TempList [0].sexSkillEscorting > max) {
			NPCCreator.TempList [0].sexSkillEscorting = max;
		}
	}

	void adjustMin(){
		if (NPCCreator.TempList [0].attPhysical < 0) {
			NPCCreator.TempList [0].attPhysical = 0;
		}

		if (NPCCreator.TempList [0].attMental < 0) {
			NPCCreator.TempList [0].attMental = 0;
		}

		if (NPCCreator.TempList [0].attSocial < 0) {
			NPCCreator.TempList [0].attSocial = 0;
		}

		if (NPCCreator.TempList [0].attMagicPower < 0) {
			NPCCreator.TempList [0].attMagicPower = 0;
		}

		if (NPCCreator.TempList [0].coreSkillMartial < 0) {
			NPCCreator.TempList [0].coreSkillMartial = 0;
		}

		if (NPCCreator.TempList [0].coreSkillSecurity < 0) {
			NPCCreator.TempList [0].coreSkillSecurity = 0;
		}

		if (NPCCreator.TempList [0].coreSkillLabor < 0) {
			NPCCreator.TempList [0].attMagicPower = 0;
		}

		if (NPCCreator.TempList [0].coreSkillTactics < 0) {
			NPCCreator.TempList [0].coreSkillTactics = 0;
		}

		if (NPCCreator.TempList [0].coreSkillGovernance < 0) {
			NPCCreator.TempList [0].coreSkillGovernance = 0;
		}

		if (NPCCreator.TempList [0].coreSkillStewardship< 0) {
			NPCCreator.TempList [0].coreSkillStewardship= 0;
		}

		if (NPCCreator.TempList [0].coreSkillPersuasion < 0) {
			NPCCreator.TempList [0].coreSkillPersuasion = 0;
		}

		if (NPCCreator.TempList [0].coreSkillIntrigue < 0) {
			NPCCreator.TempList [0].coreSkillIntrigue = 0;
		}

		if (NPCCreator.TempList [0].coreSkillDiplomacy < 0) {
			NPCCreator.TempList [0].coreSkillDiplomacy = 0;
		}

		if (NPCCreator.TempList [0].utilitySkillCrafting < 0) {
			NPCCreator.TempList [0].utilitySkillCrafting = 0;
		}

		if (NPCCreator.TempList [0].utilitySkillHouseKeeping < 0) {
			NPCCreator.TempList [0].utilitySkillHouseKeeping = 0;
		}

		if (NPCCreator.TempList [0].utilitySkillFarmHand < 0) {
			NPCCreator.TempList [0].utilitySkillFarmHand = 0;
		}

		if (NPCCreator.TempList [0].utilitySkillMedicine < 0) {
			NPCCreator.TempList [0].utilitySkillMedicine = 0;
		}

		if (NPCCreator.TempList [0].utilitySkillAlchemy < 0) {
			NPCCreator.TempList [0].utilitySkillAlchemy = 0;
		}

		if (NPCCreator.TempList [0].utilitySkillLearning < 0) {
			NPCCreator.TempList [0].utilitySkillLearning = 0;
		}

		if (NPCCreator.TempList [0].utilitySkillPerformance < 0) {
			NPCCreator.TempList [0].utilitySkillPerformance = 0;
		}

		if (NPCCreator.TempList [0].utilitySkillEtiquette < 0) {
			NPCCreator.TempList [0].utilitySkillEtiquette = 0;
		}

		if (NPCCreator.TempList [0].utilitySkillStreetwise < 0) {
			NPCCreator.TempList [0].utilitySkillStreetwise = 0;
		}

		if (NPCCreator.TempList [0].sexSkillMasseuse < 0) {
			NPCCreator.TempList [0].sexSkillMasseuse = 0;
		}

		if (NPCCreator.TempList [0].sexSkillStripping < 0) {
			NPCCreator.TempList [0].sexSkillStripping = 0;
		}

		if (NPCCreator.TempList [0].sexSkillBondage < 0) {
			NPCCreator.TempList [0].sexSkillBondage = 0;
		}

		if (NPCCreator.TempList [0].sexSkillPetplay < 0) {
			NPCCreator.TempList [0].sexSkillPetplay = 0;
		}

		if (NPCCreator.TempList [0].sexSkillPetting < 0) {
			NPCCreator.TempList [0].sexSkillPetting = 0;
		}

		if (NPCCreator.TempList [0].sexSkillGroupSex < 0) {
			NPCCreator.TempList [0].sexSkillGroupSex = 0;
		}

		if (NPCCreator.TempList [0].sexSkillPenetration < 0) {
			NPCCreator.TempList [0].sexSkillPenetration = 0;
		}

		if (NPCCreator.TempList [0].sexSkillWhoring < 0) {
			NPCCreator.TempList [0].sexSkillWhoring = 0;
		}

		if (NPCCreator.TempList [0].sexSkillEscorting < 0) {
			NPCCreator.TempList [0].sexSkillEscorting = 0;
		}


		if (NPCCreator.TempList [0].attBeauty < 0) {
			NPCCreator.TempList [0].attBeauty = 0;
		}
		if (NPCCreator.TempList [0].attTemperament < 0) {
			NPCCreator.TempList [0].attTemperament = 0;
		}
		if (NPCCreator.TempList [0].attWillpower < 0) {
			NPCCreator.TempList [0].attWillpower = 0;
		}
		if (NPCCreator.TempList [0].attNature < 0) {
			NPCCreator.TempList [0].attNature = 0;
		}
		if (NPCCreator.TempList [0].attOpenness < 0) {
			NPCCreator.TempList [0].attOpenness = 0;
		}
		if (NPCCreator.TempList [0].attDignity < 0) {
			NPCCreator.TempList [0].attDignity = 0;
		}
		if (NPCCreator.TempList [0].attObedience < 0) {
			NPCCreator.TempList [0].attObedience = 0;
		}
		if (NPCCreator.TempList [0].attHappiness < 0) {
			NPCCreator.TempList [0].attHappiness = 0;
		}
		if (NPCCreator.TempList [0].attLibido < 0) {
			NPCCreator.TempList [0].attLibido = 0;
		}
		if (NPCCreator.TempList [0].attMorality < 0) {
			NPCCreator.TempList [0].attMorality = 0;
		}
		if (NPCCreator.TempList [0].attPiety < 0) {
			NPCCreator.TempList [0].attPiety = 0;
		}
		if (NPCCreator.TempList [0].attStyle < 0) {
			NPCCreator.TempList [0].attStyle = 0;
		}
	}

	void attAdjustments(){
		if (NPCCreator.TempList [0].attBeauty > 100) {
			NPCCreator.TempList [0].attBeauty = 100;
		}
		if (NPCCreator.TempList [0].attTemperament > 100) {
			NPCCreator.TempList [0].attTemperament = 100;
		}
		if (NPCCreator.TempList [0].attWillpower > 100) {
			NPCCreator.TempList [0].attWillpower = 100;
		}
		if (NPCCreator.TempList [0].attNature > 100) {
			NPCCreator.TempList [0].attNature = 100;
		}
		if (NPCCreator.TempList [0].attOpenness > 100) {
			NPCCreator.TempList [0].attOpenness = 100;
		}
		if (NPCCreator.TempList [0].attDignity > 100) {
			NPCCreator.TempList [0].attDignity = 100;
		}
		if (NPCCreator.TempList [0].attObedience > 100) {
			NPCCreator.TempList [0].attObedience = 100;
		}
		if (NPCCreator.TempList [0].attHappiness > 100) {
			NPCCreator.TempList [0].attHappiness = 100;
		}
		if (NPCCreator.TempList [0].attLibido > 100) {
			NPCCreator.TempList [0].attLibido = 100;
		}
		if (NPCCreator.TempList [0].attMorality > 100) {
			NPCCreator.TempList [0].attMorality = 100;
		}
		if (NPCCreator.TempList [0].attPiety > 100) {
			NPCCreator.TempList [0].attPiety = 100;
		}
		if (NPCCreator.TempList [0].attStyle > 100) {
			NPCCreator.TempList [0].attStyle = 100;
		}

	}

}
