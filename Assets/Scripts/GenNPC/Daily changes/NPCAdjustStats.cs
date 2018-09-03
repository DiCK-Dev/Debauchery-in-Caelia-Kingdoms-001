using UnityEngine;
using System.Collections;

public class NPCAdjustStats  {

	static public float adjustByRank(float stat, NPCData.CharRank rank){
		if (stat < 0) {
			return 0;
		}

		switch (rank) {
		case NPCData.CharRank.C:
			if (stat > 70) {
				return 70;
			} else {
				return stat;
			}
		case NPCData.CharRank.B:
			if (stat > 80) {
				return 80;
			} else {
				return stat;
			}
		case NPCData.CharRank.A:
			if (stat > 90) {
				return 90;
			} else {
				return stat;
			} 
		case NPCData.CharRank.S:
			if (stat > 100) {
				return 100;
			} else {
				return stat;
			}
		}

		return 0;
	}

	static public float adjustGeneralStat(float stat){
		if (stat < 0) {
			return 0;
		}

		if (stat > 100) {
			return 100;
		}
		return stat;
	}

	static public float adjustMoodStat(float stat){
		if (stat < -100) {
			return -100;
		}

		if (stat > 100) {
			return 100;
		}
		return stat;
	}

	static public float adjustVarStat(float max, float min, float stat){
		if (stat < min) {
			return min;
		}

		if (stat > max) {
			return max;
		}
		return stat;
	}

	static public void adjustAll(int idx){
		NPCCharList.CharRetainers [idx].attBeauty = adjustGeneralStat (NPCCharList.CharRetainers [idx].attBeauty);
		NPCCharList.CharRetainers [idx].attTemperament = adjustGeneralStat (NPCCharList.CharRetainers [idx].attTemperament);
		NPCCharList.CharRetainers [idx].attWillpower = adjustGeneralStat (NPCCharList.CharRetainers [idx].attWillpower);
		NPCCharList.CharRetainers [idx].attNature = adjustGeneralStat (NPCCharList.CharRetainers [idx].attNature);
		NPCCharList.CharRetainers [idx].attOpenness = adjustGeneralStat (NPCCharList.CharRetainers [idx].attOpenness);
		NPCCharList.CharRetainers [idx].attDignity = adjustGeneralStat (NPCCharList.CharRetainers [idx].attDignity);
		NPCCharList.CharRetainers [idx].attObedience = adjustGeneralStat (NPCCharList.CharRetainers [idx].attObedience);
		NPCCharList.CharRetainers [idx].attHappiness = adjustGeneralStat (NPCCharList.CharRetainers [idx].attHappiness);
		NPCCharList.CharRetainers [idx].attLibido = adjustGeneralStat (NPCCharList.CharRetainers [idx].attLibido);
		NPCCharList.CharRetainers [idx].attMorality = adjustGeneralStat (NPCCharList.CharRetainers [idx].attMorality);
		NPCCharList.CharRetainers [idx].attPiety = adjustGeneralStat (NPCCharList.CharRetainers [idx].attPiety);
		NPCCharList.CharRetainers [idx].attStyle = adjustGeneralStat (NPCCharList.CharRetainers [idx].attStyle);

		NPCCharList.CharRetainers [idx].attPhysical = adjustByRank (NPCCharList.CharRetainers [idx].attPhysical, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].attMental = adjustByRank (NPCCharList.CharRetainers [idx].attMental, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].attSocial = adjustByRank (NPCCharList.CharRetainers [idx].attSocial, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].attMagicPower = adjustByRank (NPCCharList.CharRetainers [idx].attMagicPower, NPCCharList.CharRetainers [idx].charRank);


		NPCCharList.CharRetainers [idx].coreSkillMartial = adjustByRank (NPCCharList.CharRetainers [idx].coreSkillMartial, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].coreSkillSecurity = adjustByRank (NPCCharList.CharRetainers [idx].coreSkillSecurity, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].coreSkillLabor = adjustByRank (NPCCharList.CharRetainers [idx].coreSkillLabor, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].coreSkillTactics = adjustByRank (NPCCharList.CharRetainers [idx].coreSkillTactics, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].coreSkillGovernance = adjustByRank (NPCCharList.CharRetainers [idx].coreSkillGovernance, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].coreSkillStewardship = adjustByRank (NPCCharList.CharRetainers [idx].coreSkillStewardship, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].coreSkillPersuasion = adjustByRank (NPCCharList.CharRetainers [idx].coreSkillPersuasion, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].coreSkillIntrigue = adjustByRank (NPCCharList.CharRetainers [idx].coreSkillIntrigue, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].coreSkillDiplomacy = adjustByRank (NPCCharList.CharRetainers [idx].coreSkillDiplomacy, NPCCharList.CharRetainers [idx].charRank);

		NPCCharList.CharRetainers [idx].utilitySkillCrafting = adjustByRank (NPCCharList.CharRetainers [idx].utilitySkillCrafting, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].utilitySkillHouseKeeping = adjustByRank (NPCCharList.CharRetainers [idx].utilitySkillHouseKeeping, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].utilitySkillFarmHand = adjustByRank (NPCCharList.CharRetainers [idx].utilitySkillFarmHand, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].utilitySkillMedicine = adjustByRank (NPCCharList.CharRetainers [idx].utilitySkillMedicine, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].utilitySkillAlchemy = adjustByRank (NPCCharList.CharRetainers [idx].utilitySkillAlchemy, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].utilitySkillLearning = adjustByRank (NPCCharList.CharRetainers [idx].utilitySkillLearning, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].utilitySkillPerformance = adjustByRank (NPCCharList.CharRetainers [idx].utilitySkillPerformance, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].utilitySkillEtiquette = adjustByRank (NPCCharList.CharRetainers [idx].utilitySkillEtiquette, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].utilitySkillStreetwise = adjustByRank (NPCCharList.CharRetainers [idx].utilitySkillStreetwise, NPCCharList.CharRetainers [idx].charRank);

		NPCCharList.CharRetainers [idx].sexSkillMasseuse = adjustByRank (NPCCharList.CharRetainers [idx].sexSkillMasseuse, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].sexSkillStripping = adjustByRank (NPCCharList.CharRetainers [idx].sexSkillStripping, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].sexSkillBondage = adjustByRank (NPCCharList.CharRetainers [idx].sexSkillBondage, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].sexSkillPetplay = adjustByRank (NPCCharList.CharRetainers [idx].sexSkillPetplay, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].sexSkillPetting = adjustByRank (NPCCharList.CharRetainers [idx].sexSkillPetting, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].sexSkillGroupSex = adjustByRank (NPCCharList.CharRetainers [idx].sexSkillGroupSex, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].sexSkillPenetration = adjustByRank (NPCCharList.CharRetainers [idx].sexSkillPenetration, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].sexSkillWhoring = adjustByRank (NPCCharList.CharRetainers [idx].sexSkillWhoring, NPCCharList.CharRetainers [idx].charRank);
		NPCCharList.CharRetainers [idx].sexSkillEscorting = adjustByRank (NPCCharList.CharRetainers [idx].sexSkillEscorting, NPCCharList.CharRetainers [idx].charRank);


		NPCCharList.CharRetainers [idx].attFear = adjustMoodStat (NPCCharList.CharRetainers [idx].attFear);
		NPCCharList.CharRetainers [idx].attSpoiled = adjustMoodStat (NPCCharList.CharRetainers [idx].attSpoiled);
		NPCCharList.CharRetainers [idx].attExpectation = adjustMoodStat (NPCCharList.CharRetainers [idx].attExpectation);

		NPCCharList.CharRetainers [idx].currentHealth = adjustVarStat (NPCCharList.CharRetainers [idx].maxHealth, -50, NPCCharList.CharRetainers [idx].currentHealth);
		NPCCharList.CharRetainers [idx].currentArousal = adjustVarStat (NPCCharList.CharRetainers [idx].maxArousal, 0, NPCCharList.CharRetainers [idx].currentArousal);
		NPCCharList.CharRetainers [idx].currentMP = adjustVarStat (NPCCharList.CharRetainers [idx].maxMP, 0, NPCCharList.CharRetainers [idx].currentMP);

		NPCCharList.CharRetainers [idx].charAddictions[0] = adjustGeneralStat (NPCCharList.CharRetainers [idx].charAddictions[0]);
		NPCCharList.CharRetainers [idx].charAddictions[1] = adjustGeneralStat (NPCCharList.CharRetainers [idx].charAddictions[1]);
		NPCCharList.CharRetainers [idx].charAddictions[2] = adjustGeneralStat (NPCCharList.CharRetainers [idx].charAddictions[2]);
		NPCCharList.CharRetainers [idx].charAddictions[3] = adjustGeneralStat (NPCCharList.CharRetainers [idx].charAddictions[3]);
		NPCCharList.CharRetainers [idx].charAddictions[4] = adjustGeneralStat (NPCCharList.CharRetainers [idx].charAddictions[4]);
		NPCCharList.CharRetainers [idx].charAddictions[5] = adjustGeneralStat (NPCCharList.CharRetainers [idx].charAddictions[5]);
		NPCCharList.CharRetainers [idx].charAddictions[6] = adjustGeneralStat (NPCCharList.CharRetainers [idx].charAddictions[6]);
		NPCCharList.CharRetainers [idx].charAddictions[7] = adjustGeneralStat (NPCCharList.CharRetainers [idx].charAddictions[7]);

		NPCCharList.CharRetainers [idx].charCorruption = adjustGeneralStat (NPCCharList.CharRetainers [idx].charCorruption);
		NPCCharList.CharRetainers [idx].charRelationship = adjustVarStat (100, -100, NPCCharList.CharRetainers [idx].charRelationship);
		NPCCharList.CharRetainers [idx].charLove = adjustVarStat (100, -100, NPCCharList.CharRetainers [idx].charLove);
		NPCCharList.CharRetainers [idx].charLoyalty = adjustVarStat (100, -100, NPCCharList.CharRetainers [idx].charLoyalty);

		NPCCharList.CharRetainers [idx].workReward = (int)adjustVarStat (5, -5, (float)NPCCharList.CharRetainers [idx].workReward);

		NPCCharList.CharRetainers [idx].charReputation = adjustVarStat (1000, -1000, NPCCharList.CharRetainers [idx].charReputation);
		NPCCharList.CharRetainers [idx].politicalPower = adjustVarStat (1000, -1000, NPCCharList.CharRetainers [idx].politicalPower);


	}


}
