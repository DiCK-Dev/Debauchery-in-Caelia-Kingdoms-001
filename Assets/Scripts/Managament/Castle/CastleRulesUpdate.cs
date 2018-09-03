using UnityEngine;
using System.Collections;

public class CastleRulesUpdate  {



	public static string rulesUpdate(int idx, int idxRL){
		string ret = "";
		if (RulesNPC.savedRules [idxRL].forceSilence) {
			ret += forceSilence (idx);
		}
		if (RulesNPC.savedRules [idxRL].forceHumility) {
			ret += forceHumility (idx);
		}
		if (RulesNPC.savedRules [idxRL].chastityBelt) {
			ret += forceChastity (idx);
		}
		if (RulesNPC.savedRules [idxRL].denyToileting) {
			ret += denyToileting (idx);
		}
		if (RulesNPC.savedRules [idxRL].behavePet) {
			ret += behavePet (idx);
		}
		if (RulesNPC.savedRules [idxRL].behaveAlarm) {
			ret += behaveAlarm (idx);
		}
		if (RulesNPC.savedRules [idxRL].genitalVibes) {
			ret += genitalVibes (idx, idxRL);
		}
		if (RulesNPC.savedRules [idxRL].analPlug) {
			ret += analPlug (idx, idxRL);
		}
		return ret;
	}



	static string forceSilence(int idx){
		if (NPCCharList.CharRetainers [idx].attObedience >= 70) {
			if (NPCCharList.CharRetainers [idx].attSpoiled > 0) {
				NPCCharList.CharRetainers [idx].attSpoiled -= 0.3f;
			}
			NPCCharList.CharRetainers [idx].attObedience += Random.Range (0.1f, 0.35f);

			return "";
		} else if (Random.Range (0, 100) + ((NPCCharList.CharRetainers [idx].attDignity + NPCCharList.CharRetainers [idx].attWillpower) / 10) - 5 < NPCCharList.CharRetainers [idx].attObedience) {
			NPCCharList.CharRetainers [idx].workReward += 1;
			NPCCharList.CharRetainers [idx].attHappiness -= 0.2f;
			NPCCharList.CharRetainers [idx].attObedience += Random.Range (0.2f, 0.7f);

			if (NPCCharList.CharRetainers [idx].attSpoiled > 0) {
				NPCCharList.CharRetainers [idx].attSpoiled -= 0.5f;
			}
			return "";
		} else {
			NPCCharList.CharRetainers [idx].workReward -= 2;
			string HESHE = "He";
			if (NPCCharList.CharRetainers [idx].charGender == NPCData.CharGender.FEMALE) {
				HESHE = "She";
			}
			return "\n\n" + HESHE + " has kept talking in front of you without your authorization, defying your rules!";
		}

	}


	static string forceHumility(int idx){
		if (NPCCharList.CharRetainers [idx].attObedience >= 75) {
			NPCCharList.CharRetainers [idx].attSpoiled -= 0.5f;
			NPCCharList.CharRetainers [idx].attObedience += Random.Range (0.2f, 0.6f);

			return "";
		} else if (Random.Range (0, 100) + ((NPCCharList.CharRetainers [idx].attDignity + NPCCharList.CharRetainers [idx].attWillpower) / 6)  < NPCCharList.CharRetainers [idx].attObedience) {
			NPCCharList.CharRetainers [idx].attHappiness -= 0.4f;
			NPCCharList.CharRetainers [idx].attSpoiled -= 1f;
			NPCCharList.CharRetainers [idx].attObedience += Random.Range (0.5f,2f );
			NPCCharList.CharRetainers [idx].workReward += 1;
			return "";
		} else {
			NPCCharList.CharRetainers [idx].workReward -= 2;
			string HESHE = "He";
			if (NPCCharList.CharRetainers [idx].charGender == NPCData.CharGender.FEMALE) {
				HESHE = "She";
			}
			return "\n\n" + HESHE + " isn't showing humility , defying your rules!";
		}

	}

	static string forceChastity(int idx){
		if (NPCCharList.CharRetainers [idx].charCorruption > 0) {
			NPCCharList.CharRetainers [idx].charCorruption -= 0.8f;
		}
		if (NPCCharList.CharRetainers [idx].attLibido > 0) {
			NPCCharList.CharRetainers [idx].attLibido -= 0.8f; 
		}
		if (NPCCharList.CharRetainers [idx].attStyle > 0) {
			NPCCharList.CharRetainers [idx].attStyle -= 0.8f; 
		}
		if (NPCCharList.CharRetainers [idx].attLibido > 70 || NPCCharList.CharRetainers [idx].charCorruption > 70) {
			NPCCharList.CharRetainers [idx].attHappiness -= 0.5f;
			string HESHE = "He";
			if (NPCCharList.CharRetainers [idx].charGender == NPCData.CharGender.FEMALE) {
				HESHE = "She";
			}
			return "\n\n" + HESHE + " is really unhappy to be forced to use a chastity belt.";

		}
		return "";
	}


	static string denyToileting(int idx){
		if (NPCCharList.CharRetainers [idx].attObedience >= 80) {
			NPCCharList.CharRetainers [idx].attSpoiled -= 1.5f;
			NPCCharList.CharRetainers [idx].attDignity -= 0.2f;
			NPCCharList.CharRetainers [idx].attObedience += Random.Range (0, 0.3f);

			return "";
		} else if (Random.Range (0, 100) + (NPCCharList.CharRetainers [idx].attDignity / 6)  < NPCCharList.CharRetainers [idx].attObedience) {
			NPCCharList.CharRetainers [idx].attHappiness -= 0.5f;
			NPCCharList.CharRetainers [idx].attSpoiled -= 0.4f;
			NPCCharList.CharRetainers [idx].attDignity -= 0.2f;
			NPCCharList.CharRetainers [idx].attObedience += Random.Range (0, 0.6f);
			NPCCharList.CharRetainers [idx].workReward += 1;
			return "";
		} else {
			NPCCharList.CharRetainers [idx].workReward -= 1;
			string HESHE = "He";
			if (NPCCharList.CharRetainers [idx].charGender == NPCData.CharGender.FEMALE) {
				HESHE = "She";
			}
			return "\n\n" + HESHE + " isn't asking for permission to go to the bathroom, defying your rules!";
		}

	}

	static string behavePet(int idx){
		if (NPCCharList.CharRetainers [idx].attObedience >= 85) {
			NPCCharList.CharRetainers [idx].attSpoiled -= 0.4f;
			NPCCharList.CharRetainers [idx].attWillpower -= 0.5f;
			NPCCharList.CharRetainers [idx].attDignity -= 0.2f;
			NPCCharList.CharRetainers [idx].attObedience += Random.Range (0, 0.5f);
			return "";
		} else if (Random.Range (0, 100) + ((NPCCharList.CharRetainers [idx].attDignity+  NPCCharList.CharRetainers [idx].attWillpower)/ 4.5f)  < NPCCharList.CharRetainers [idx].attObedience) {
			NPCCharList.CharRetainers [idx].attHappiness -= 0.6f;
			NPCCharList.CharRetainers [idx].attSpoiled -= 0.4f;
			NPCCharList.CharRetainers [idx].attWillpower -= 0.5f;
			NPCCharList.CharRetainers [idx].attDignity -= 0.2f;
			NPCCharList.CharRetainers [idx].attObedience += Random.Range (0, 1);
			NPCCharList.CharRetainers [idx].workReward += 1;
			return "";
		} else {
			NPCCharList.CharRetainers [idx].workReward -= 1;
			string HESHE = "He";
			if (NPCCharList.CharRetainers [idx].charGender == NPCData.CharGender.FEMALE) {
				HESHE = "She";
			}
			return "\n\n" + HESHE + " isn't behaving like a pet!";
		}

	}

	static string behaveAlarm(int idx){
		if (NPCCharList.CharRetainers [idx].attObedience >= 90) {
			NPCCharList.CharRetainers [idx].attSpoiled -= 0.25f;
			NPCCharList.CharRetainers [idx].attWillpower -= 0.2f;
			NPCCharList.CharRetainers [idx].attDignity -= 0.3f;
			NPCCharList.CharRetainers [idx].attObedience += Random.Range (0, 0.5f);
			return "";
		} else if (Random.Range (0, 100) + ((NPCCharList.CharRetainers [idx].attDignity+  NPCCharList.CharRetainers [idx].attWillpower)/ 4)  < NPCCharList.CharRetainers [idx].attObedience) {
			NPCCharList.CharRetainers [idx].attHappiness -= 0.6f;
			NPCCharList.CharRetainers [idx].attSpoiled -= 0.4f;
			NPCCharList.CharRetainers [idx].attWillpower -= 0.35f;
			NPCCharList.CharRetainers [idx].attDignity -= 0.5f;
			NPCCharList.CharRetainers [idx].attObedience += Random.Range (0, 1);
			NPCCharList.CharRetainers [idx].workReward += 1;
			return "";
		} else {
			NPCCharList.CharRetainers [idx].workReward -= 1;
			string HESHE = "He";
			if (NPCCharList.CharRetainers [idx].charGender == NPCData.CharGender.FEMALE) {
				HESHE = "She";
			}
			return "\n\n" + HESHE + " isn't doing it's alarm duties!";
		}

	}

	static string genitalVibes(int idx, int idxRL){
		string HESHE = "He";
		if (NPCCharList.CharRetainers [idx].charGender == NPCData.CharGender.FEMALE) {
			HESHE = "She";
		}

	
		if (NPCCharList.CharRetainers [idx].attObedience >= 75) {
			NPCCharList.CharRetainers [idx].currentArousal += Random.Range (5, 20);
			if (RulesNPC.savedRules[idxRL].denyOrgasm && NPCCharList.CharRetainers [idx].currentArousal >= NPCCharList.CharRetainers [idx].maxArousal && Random.Range(0,100) > NPCCharList.CharRetainers [idx].attWillpower ) {
				NPCCharList.CharRetainers [idx].workReward -= 2;
				NPCCharList.CharRetainers [idx].attLibido += 0.5f;
				NPCCharList.CharRetainers [idx].attOpenness += 0.2f;
				NPCCharList.CharRetainers [idx].currentArousal = 0;
				return "\n\n"+HESHE + " couldn't contain itself and had an orgasm, breaking your rules!";
			}
			NPCCharList.CharRetainers [idx].attLibido += 0.5f;
			NPCCharList.CharRetainers [idx].attOpenness += 0.2f;
			return "";
		} else if (Random.Range (0, 100) + ((NPCCharList.CharRetainers [idx].attDignity+  NPCCharList.CharRetainers [idx].attWillpower)/ 6.5)  < NPCCharList.CharRetainers [idx].attObedience) {
			NPCCharList.CharRetainers [idx].attLibido += 0.5f;
			NPCCharList.CharRetainers [idx].attOpenness += 0.2f;
			NPCCharList.CharRetainers [idx].workReward += 1;
			NPCCharList.CharRetainers [idx].attObedience += Random.Range (0, 0.5f);

			return "";
		} else {
			NPCCharList.CharRetainers [idx].workReward -= 1;
		
			return "\n\n" + HESHE + " has thrown it's vibes away!";
		}

	}


	static string analPlug(int idx, int idxRL){
		string HESHE = "He";
		if (NPCCharList.CharRetainers [idx].charGender == NPCData.CharGender.FEMALE) {
			HESHE = "She";
		}



		if (NPCCharList.CharRetainers [idx].attObedience >= 75) {

			if (NPCCharList.CharRetainers [idx].charCorruption > 75) {
				NPCCharList.CharRetainers [idx].currentArousal += Random.Range (5, 20);
			}
			if (RulesNPC.savedRules[idxRL].denyOrgasm && NPCCharList.CharRetainers [idx].currentArousal >= NPCCharList.CharRetainers [idx].maxArousal && Random.Range(0,100) > NPCCharList.CharRetainers [idx].attWillpower ) {
				NPCCharList.CharRetainers [idx].workReward -= 2;
				NPCCharList.CharRetainers [idx].attLibido += 0.5f;
				NPCCharList.CharRetainers [idx].attOpenness += 0.2f;
				NPCCharList.CharRetainers [idx].currentArousal = 0; 
				return "\n\n" +HESHE + " couldn't contain itself and had an anal orgasm, breaking your rules!";
			}
			NPCCharList.CharRetainers [idx].attLibido += 0.5f;
			NPCCharList.CharRetainers [idx].attOpenness += 0.2f;
			return "";
		} else if (Random.Range (0, 100) + ((NPCCharList.CharRetainers [idx].attDignity+  NPCCharList.CharRetainers [idx].attWillpower)/ 6.5)  < NPCCharList.CharRetainers [idx].attObedience) {
			if (NPCCharList.CharRetainers [idx].charCorruption > 75) {
				NPCCharList.CharRetainers [idx].currentArousal += Random.Range (5, 20);
			}
			if (RulesNPC.savedRules[idxRL].denyOrgasm && NPCCharList.CharRetainers [idx].currentArousal >= NPCCharList.CharRetainers [idx].maxArousal && Random.Range(0,100) > NPCCharList.CharRetainers [idx].attWillpower ) {
				NPCCharList.CharRetainers [idx].workReward -= 2;
				NPCCharList.CharRetainers [idx].attLibido += 0.5f;
				NPCCharList.CharRetainers [idx].attOpenness += 0.2f;
				NPCCharList.CharRetainers [idx].currentArousal = 0; 
				return "\n\n" +HESHE + " couldn't contain itself and had an anal orgasm, breaking your rules!";
			}
			NPCCharList.CharRetainers [idx].attLibido += 0.5f;
			NPCCharList.CharRetainers [idx].attOpenness += 0.2f;
			NPCCharList.CharRetainers [idx].attObedience += Random.Range (0, 0.5f);

			return "";
		} else {
			NPCCharList.CharRetainers [idx].workReward -= 1;

			return "\n\n" + HESHE + " has thrown it's anal plug away!";
		}

	}



}
