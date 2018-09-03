using UnityEngine;
using System.Collections;

public class SetEquipment : MonoBehaviour {

	//int itemID; 
	int i; 

	setAttStyle setStyle = new setAttStyle();


	public void setEquipModifiers(){
		GameControl.charCombatDefense= 0.5f;
		GameControl.charLustDefense = 0.5f;
		GameControl.charCombatAttack = 0.5f;
		GameControl.charLustAttack = 0.5f;

		GameControl.coreSkillBonus[0] = 0f; // extra damage to com skills, from weapon
		GameControl.coreSkillBonus[6] = 0f; // extra lust from lust skills, from weapon

		GameControl.attBonus [0] = 0;
		GameControl.attBonus [1] = 0;
		GameControl.attBonus [2] = 0;
		GameControl.attBonus [3] = 0;

		GameControl.coreSkillBonus[0] = 0;
		GameControl.coreSkillBonus[1] = 0;
		GameControl.coreSkillBonus[2] = 0;
		GameControl.coreSkillBonus[3] = 0;
		GameControl.coreSkillBonus[4] = 0;
		GameControl.coreSkillBonus[5] = 0;
		GameControl.coreSkillBonus[6] = 0;
		GameControl.coreSkillBonus[7] = 0;
		GameControl.coreSkillBonus[8] = 0;

		GameControl.statusEffect[0] = false; 

		GameControl.attStyle = 0; 

		resetEquip ();

		i = 0;
		while (i < 50) {
			GameControl.charArmorTags [i] = false;
			i++;
		}


		i = 0;


		while (i < 12) {



			//itemID = GameControl.charEquipment [i]; 
			setEquipSwitch (GameControl.charEquipment [i]);
			//setStyle.styleItem (GameControl.charEquipment [i]);

			i++;
		}

	}




	public void setEquipSwitch(int itemID){
		switch (itemID) {
		case 0:
			break;
		case 10000:
			break;
		case 10001:
			GameControl.coreSkillBonus [0] += 2; 
			GameControl.charCombatAttack += 0.15f;
			break;
		case 10002:
			GameControl.coreSkillBonus[0] += 5; 
			GameControl.charCombatAttack += 0.2f;
			break;
		case 10003: // veil
			GameControl.coreSkillBonus [6] += 5; 
			GameControl.charLustAttack += 0.15f; 
			break;
		case 10004:
			GameControl.coreSkillBonus[6] += 3; 
			GameControl.coreSkillBonus[0] += 3; 
			GameControl.charCombatAttack += 0.1f;
			GameControl.charLustAttack += 0.1f;
			break;
		case 10005:
			GameControl.coreSkillBonus[6] += 5; 
			GameControl.charLustAttack += 0.2f;
			break; 
		case 10006:
			GameControl.coreSkillBonus[0] += 5; 
			GameControl.charCombatAttack += 0.2f;
			break;
		case 10007:
			GameControl.coreSkillBonus[0] += 5; 
			GameControl.charCombatAttack += 0.24f;
			GameControl.charCombatDefense -= 0.05f;
			break;
		case 10008:
			GameControl.coreSkillBonus [0] += 3; 
			GameControl.charCombatAttack += 0.2f;
			GameControl.charCombatDefense += 0.15f;

			break;
		case 10009:
			GameControl.coreSkillBonus [0] += 5; 
			GameControl.charCombatAttack += 0.15f;
			GameControl.charCombatDefense += 0.15f;

			break;
		case 10010:
			GameControl.coreSkillBonus [0] += 7; 
			GameControl.charCombatAttack += 0.1f;
			GameControl.charCombatDefense += 0.3f;

			break;
		case 10011:
			GameControl.charCombatAttack += 0.1f;
			break;
		case 10012:
			GameControl.coreSkillBonus [0] += 3; 
			GameControl.charCombatAttack += 0.35f;
			GameControl.charCombatDefense -= 0.20f;

			break;
		case 10013:
			GameControl.coreSkillBonus [0] += 3; 
			GameControl.charCombatAttack += 0.2f;
			GameControl.charCombatDefense -= 0.1f;

			break;
		case 10014:
			GameControl.coreSkillBonus [0] += 5; 
			GameControl.charCombatAttack += 0.45f;
			GameControl.charCombatDefense -= 0.3f;

			break;
		case 10015:
			GameControl.coreSkillBonus [0] += 3; 
			GameControl.charCombatAttack += 0.15f;
			GameControl.charCombatDefense += 0.1f;

			break;
		case 10016:
			GameControl.charCombatAttack += 0.1f;
			break;
		case 10017:
			GameControl.charCombatAttack += 0.05f;
			break;
		case 10018:
			GameControl.charCombatAttack += 0.08f;
			break;
		case 10019:
			GameControl.coreSkillBonus [0] += 5; 
			GameControl.charCombatAttack += 0.2f;
			GameControl.charCombatDefense += 0.35f;

			break;
		case 10020:
			GameControl.coreSkillBonus [0] += 5; 
			GameControl.charCombatAttack += 0.3f;
			GameControl.charCombatDefense += 0.05f;

			break;
		case 10021:
			GameControl.coreSkillBonus [0] += 7; 
			GameControl.charCombatAttack += 0.35f;
			GameControl.charCombatDefense += 0.05f;

			break;
		case 10022:
			GameControl.attBonus [0] += 5; 
			GameControl.coreSkillBonus [0] += 15; 
			GameControl.attStyle += 10; 
			GameControl.charCombatDefense+= 0.5f;
			GameControl.charCombatAttack += 0.5f;
			break;
		case 20000:
			GameControl.attStyle-= 30; 
			break;
		case 20001:
			GameControl.attStyle+= 1; 
			GameControl.charCombatDefense+= 0.2f;

			GameControl.charLustDefense += 0.1f;
			GameControl.charArmorTags [7] = true; 
			break;
		case 20002:
			GameControl.attStyle+= 2; 
			GameControl.charCombatDefense+= 0.2f;

			GameControl.charLustDefense += 0.1f;
			GameControl.coreSkillBonus[0]+= 5f;
			GameControl.coreSkillBonus[6] += 0f;
			GameControl.coreSkillBonus[0] += 2;
			GameControl.charArmorTags [7] = true; 
			break;
		case 20003:
			GameControl.attStyle+= 3;
			GameControl.charCombatDefense+= 0.3f;
			GameControl.charLustDefense += 0.15f;
			GameControl.coreSkillBonus[0]+= 1f;
			GameControl.coreSkillBonus[3] += 5;
			GameControl.coreSkillBonus[6] += 4;
			GameControl.charArmorTags [7] = true;
			break;
		case 20004:
			GameControl.attStyle+= 6; 
			GameControl.charCombatDefense+= 0.3f;
			 GameControl.charLustDefense += 0.2f;
			GameControl.coreSkillBonus[0]+= 2f;
			GameControl.coreSkillBonus[6] += 5;
			GameControl.coreSkillBonus[0] += 4;
			GameControl.coreSkillBonus[8] += 2;
			GameControl.charArmorTags [7] = true; 
			GameControl.charArmorTags [4] = true;
			break;
		case 20005:
			GameControl.attStyle+= 6; 
			GameControl.charCombatDefense+= 0.2f;
			 GameControl.charLustDefense += 0.2f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 5f;
			GameControl.coreSkillBonus[6] += 2;
			GameControl.charArmorTags [10] = true;
			break;
		case 20006:
			GameControl.attStyle+= 8; 
			GameControl.charCombatDefense+= 0.2f;
			 GameControl.charLustDefense += 0.1f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			GameControl.coreSkillBonus[8] += 4;
			GameControl.coreSkillBonus[0] += 4;
			GameControl.charArmorTags [9] = true;
			break;
		case 20007:
			GameControl.attStyle+= 1; 
			GameControl.charCombatDefense+= 0.15f;
			 GameControl.charLustDefense += 0.1f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 11f;
			GameControl.coreSkillBonus[6] += 2;
			GameControl.charArmorTags [10] = true; 
			break;
		case 20008:
			GameControl.attStyle+= 0; 
			GameControl.charCombatDefense+= 0.1f;
			GameControl.charLustDefense += 0.2f;
			GameControl.coreSkillBonus[0]+= 5f;
			GameControl.coreSkillBonus[6] += 5f;
			GameControl.coreSkillBonus[2] += 5;
			break;
		case 20009:
			GameControl.attStyle+= 5; 
			GameControl.charCombatDefense+= 0.2f;
			 GameControl.charLustDefense += 0.25f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			GameControl.charArmorTags [2] = true;
			GameControl.coreSkillBonus[5]-= 2;
			GameControl.coreSkillBonus[4] += 4;
			break;
		case 20010:
			GameControl.attStyle+= 12; 
			GameControl.charCombatDefense+= 0.25f;
			 GameControl.charLustDefense += 0.15f;
			GameControl.coreSkillBonus[0]+= 05f;
			GameControl.coreSkillBonus[6] += 0f;
			GameControl.charArmorTags [4] = true;
			GameControl.coreSkillBonus[5] += 5;
			break;
		case 20011:
			GameControl.attStyle+= 16; 
			GameControl.charCombatDefense+= 0.25f;
			 GameControl.charLustDefense += 0.15f;
			GameControl.coreSkillBonus[0]+= 1f;
			GameControl.coreSkillBonus[6] += 0f;
			GameControl.charArmorTags [4] = true;
			GameControl.coreSkillBonus[4] += 5;
			break;
		case 20012:
			GameControl.attStyle-= 5; 
			GameControl.charCombatDefense+= 0.15f;
			 GameControl.charLustDefense += 0.15f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 115f;
			GameControl.charArmorTags [10] = true; 
			GameControl.coreSkillBonus[6] += 5;
			break;
		case 20013:
			GameControl.attStyle+= -8; 
			GameControl.charCombatDefense+= 0.1f;
			 GameControl.charLustDefense += 0.1f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 125f;
			GameControl.coreSkillBonus[6] += 5;
			GameControl.charArmorTags [1] = true;
			GameControl.charArmorTags [5] = true; 
			break;
		case 20014:
			GameControl.attStyle+= 20;
			GameControl.charCombatDefense+= 0.2f;
			 GameControl.charLustDefense += 0.4f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 11f;
			GameControl.statusEffect[0] = true; 
			GameControl.charArmorTags [1] = true;
			GameControl.charArmorTags [2] = true;
			GameControl.charArmorTags [11] = true; // celibate
			break;
		case 20015:
			GameControl.attStyle+= 3;
			GameControl.charCombatDefense+= 0.2f;
			GameControl.charLustDefense += 0.4f;
			GameControl.coreSkillBonus[0]+= 2f;
			GameControl.coreSkillBonus[3] += 2f;
			GameControl.coreSkillBonus[6] += 2f;
			break;
		case 20016:
			GameControl.attStyle+= 4;
			GameControl.charCombatDefense+= 0.2f;
			GameControl.charLustDefense += 0.4f;
			GameControl.coreSkillBonus[0]+= 2f;
			GameControl.coreSkillBonus[3] += 3f;
			GameControl.coreSkillBonus[6] += 3f;
			break;
		case 20017:
			GameControl.attStyle+= 5;
			GameControl.charCombatDefense+= 0.2f;
			GameControl.charLustDefense += 0.2f;
			GameControl.coreSkillBonus[0]+= 2f;
			GameControl.coreSkillBonus[3] += 2f;
			GameControl.coreSkillBonus[6] += 5f;
			break;

		case 20018:
			GameControl.attStyle+= 5;
			GameControl.charCombatDefense+= 0.2f;
			GameControl.charLustDefense += 0.2f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[3] += 10f;
			GameControl.coreSkillBonus[6] += 5f;
			break;
		case 20019:
			GameControl.attStyle+= 5;
			GameControl.charCombatDefense+= 0.5f;
			GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 6f;
			GameControl.coreSkillBonus[3] += 4f;
			GameControl.coreSkillBonus[6] += 2f;
			break;
		case 20020:
			GameControl.attStyle+= 0;
			GameControl.charCombatDefense+= 0f;
			GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 1f;
			GameControl.coreSkillBonus[3] += 1f;
			GameControl.coreSkillBonus[6] += 0f;
			break;
		case 20021:
			GameControl.attStyle+= 3;
			GameControl.charCombatDefense+= 0f;
			GameControl.charLustDefense += 0.4f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[3] += 2f;
			GameControl.coreSkillBonus[6] += 4f;
			break;
		case 20022:
			GameControl.attStyle+= 4;
			GameControl.charCombatDefense+= 0.4f;
			GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 4f;
			GameControl.coreSkillBonus[3] += 3f;
			GameControl.coreSkillBonus[6] += 0f;
			break;
		case 20023:
			GameControl.attStyle+= 3;
			GameControl.charCombatDefense+= 0.3f;
			GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 3f;
			GameControl.coreSkillBonus[3] += 2f;
			GameControl.coreSkillBonus[6] += 0f;
			break;
		case 20024:
			GameControl.attStyle+= 10; 
			GameControl.charCombatDefense+= 0.21f;
			GameControl.charLustDefense += 0.21f;
			GameControl.coreSkillBonus[0]+= 10f;
			GameControl.coreSkillBonus[3] += 10f;
			GameControl.coreSkillBonus[6] += 10f;
			break;
		case 20025:
			GameControl.attStyle+= 5;
			GameControl.charCombatDefense+= 0.35f;
			GameControl.charLustDefense += 0.2f;
			GameControl.coreSkillBonus[0]+= 3f;
			GameControl.coreSkillBonus[3] += 3f;
			GameControl.coreSkillBonus[6] += 6f;
			break;
		case 20026:
			GameControl.attStyle+= 5;
			GameControl.charCombatDefense+= 0.25f;
			GameControl.charLustDefense += 0.2f;
			GameControl.coreSkillBonus[0]+= 2f;
			GameControl.coreSkillBonus[3] += 3f;
			GameControl.coreSkillBonus[6] += 7f;
			break;
		case 20027:
			GameControl.attStyle+= 5;
			GameControl.charCombatDefense+= 0.05f;
			GameControl.charLustDefense += 0.3f;
			GameControl.coreSkillBonus[0]+= 1f;
			GameControl.coreSkillBonus[3] += 4f;
			GameControl.coreSkillBonus[6] += 8f;
			break;
		case 20500:
			GameControl.attStyle+= 10; 
			GameControl.charCombatDefense+= 2f;
			GameControl.charLustDefense += 2f;
			break;
		case 30001:
			GameControl.attStyle+= 2; 
			GameControl.charCombatDefense+= 0.05f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			GameControl.coreSkillBonus[1] += 2;
			break;
		case 30002:
			GameControl.attStyle+= 2; 
			GameControl.charCombatDefense+= 0.05f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			GameControl.coreSkillBonus[0] += 2;
			break;
		case 30003:
			GameControl.charCombatDefense+= 0f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			GameControl.coreSkillBonus[7] += 3;
			break;
		case 30004:
			GameControl.attStyle+= 2; 
			GameControl.charCombatDefense+= 0f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			GameControl.coreSkillBonus[8] += 3;
			break;
		case 30005://gold circlet 
			GameControl.attStyle+= 3; 
			GameControl.charCombatDefense+= 0.05f;
			GameControl.charLustDefense += 0.05f;
			GameControl.coreSkillBonus[9] += 1f;
			break;
		case 30006://golden crown
			GameControl.attStyle+= 5; 
			GameControl.charCombatDefense+= 0.08f;
			GameControl.charLustDefense += 0.05f;
			GameControl.coreSkillBonus[9] += 3f;
			break;
		case 30007://Bascinet
			GameControl.attStyle+= 1; 
			GameControl.charCombatDefense+= 0.1f;
			GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0] += 1;
			break;
		case 30008://chaperon
			GameControl.attStyle+= 4; 
			GameControl.charCombatDefense+= 0f;
			GameControl.charLustDefense += 0.08f;
			GameControl.coreSkillBonus[9] += 2f;
			break;
		case 30009://bycocket
			GameControl.attStyle+= 0; 
			GameControl.charCombatDefense+= 0.03f;
			GameControl.charLustDefense += 0.03f;
			break;
		case 30500:
			GameControl.attStyle+= 2; 
			GameControl.charCombatDefense+= 2f;
			GameControl.charLustDefense += 2f;
			break;
		case 40001:
			GameControl.attStyle-= 2; 
			GameControl.charCombatDefense+= 0f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[7] -= 2;
			GameControl.coreSkillBonus[1] += 3;
			break;

		case 40002:
			GameControl.attStyle+= 1; 
			GameControl.charCombatDefense+= 0f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			GameControl.coreSkillBonus[0]+= 2; 
			break;

		case 40003:
			GameControl.attStyle+= 2; 
			GameControl.charCombatDefense+= 0f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			GameControl.coreSkillBonus[5]+= 2;
			break;
		case 40004:
			GameControl.attStyle+= 3; 
			GameControl.charCombatDefense+= 0f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 3;
			break;
		case 40005:
			GameControl.attStyle+= 3; 
			GameControl.charCombatDefense+= 0.02f;
			GameControl.charLustDefense += 0.04f;
			GameControl.coreSkillBonus[6] += 3;
			break;
		case 40500:
			GameControl.attStyle+= 4; 
			GameControl.charCombatDefense+= 2f;
			GameControl.charLustDefense += 2f;
			break;
		case 50001:
			GameControl.charCombatDefense+= 0f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			GameControl.coreSkillBonus[2] += 2;
			break;
		case 50002:
			GameControl.attStyle+= 2; 
			GameControl.charCombatDefense+= 0.05f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			break;
		case 50003:
			GameControl.attStyle -= 120; 
			GameControl.charCombatDefense+= 0f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			GameControl.charArmorTags [0] = true;
			break;
		case 50004:
			GameControl.attStyle-= 2; 
			GameControl.charCombatDefense+= 0f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			GameControl.coreSkillBonus[8] += 2;
			break;
		case 50005:
			GameControl.attStyle += 2; 
			break;
		case 50006:
			GameControl.attStyle += 1; 
			GameControl.coreSkillBonus[9]+= 2f;
			break;
		case 50007:
			GameControl.attStyle += 1; 
			GameControl.coreSkillBonus[9]+= 2f;
			break;
		case 50008:
			GameControl.attStyle -= 100; 
			GameControl.coreSkillBonus[9]+= 2f;
			break;
		case 50500:
			GameControl.attStyle += 2; 
			GameControl.charCombatDefense+= 2f;
			GameControl.charLustDefense += 2f;
			break;
		case 60001:
			GameControl.attStyle+= 1; 
			GameControl.charCombatDefense+= 0f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			GameControl.coreSkillBonus[0] += 2;
			break;
		case 60002:
			GameControl.attStyle+= 1; 
			GameControl.charCombatDefense+= 0f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			GameControl.coreSkillBonus[3] += 2;
			break;
		case 60003:
			GameControl.charCombatDefense+= 0f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			GameControl.coreSkillBonus[5]+= 1;
			GameControl.coreSkillBonus[8] -= 2;
			break;
		case 60004:
			GameControl.attStyle+= 2; 
			GameControl.charCombatDefense+= 0.05f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;

			break;
		case 60005:
			GameControl.attStyle+= 3; 
			GameControl.charCombatDefense+= 0.05f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			GameControl.coreSkillBonus[0] += 2;
			break;

		case 60006:
			GameControl.charCombatDefense+= 0.05f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			break;
		case 60007:
			GameControl.charCombatDefense+= 0.15f;
			GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 2f;
			GameControl.coreSkillBonus[6] += 0f;
			break;
		case 60500:
			GameControl.charCombatDefense+= 2f;
			GameControl.charLustDefense += 2f;
			GameControl.coreSkillBonus[0]+= 2f;
			GameControl.coreSkillBonus[6] += 2f;
			break;
		case 70001:
			GameControl.attStyle+= 2; 
			GameControl.charCombatDefense+= 0.05f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			break;
		case 70002:
			GameControl.attStyle-= 1; 
			GameControl.charCombatDefense+= 0f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			GameControl.coreSkillBonus[6] += 1;
			break;
		case 70003:
			GameControl.charCombatDefense+= 0f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			GameControl.coreSkillBonus[2] += 1;
			break;
		case 70004:
			GameControl.attStyle-= 2; 
			GameControl.charCombatDefense+= 0f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			GameControl.coreSkillBonus[8] -= 1;
			GameControl.coreSkillBonus[1] += 1;
			break;
		case 70005:
			GameControl.charCombatDefense+= 0f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			GameControl.coreSkillBonus[0] += 1;
			break;
		case 70006:
			GameControl.attStyle-= 1; 
			GameControl.charCombatDefense+= 0f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			break;
		case 70007:
			GameControl.attStyle-= 1; 
			GameControl.charCombatDefense+= 0.05f;
			GameControl.charLustDefense += 0.02f;
			break;
		case 70500:
			GameControl.attStyle += 1; 
			GameControl.charCombatDefense+= 2f;
			GameControl.charLustDefense += 2f;
			GameControl.coreSkillBonus[0]+= 2f;
			GameControl.coreSkillBonus[6] += 2f;
			break;
		case 80001: 
			GameControl.charCombatDefense+= 0f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			GameControl.coreSkillBonus[0] += 1;
			break;
		case 80002:
			GameControl.attStyle+= 1; 
			GameControl.charCombatDefense+= 0.05f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;

			break;
		case 80003:
			GameControl.attStyle+= 1; 
			GameControl.charCombatDefense+= 0f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			GameControl.coreSkillBonus[8] += 1;
			break;
		case 80004:
			GameControl.charCombatDefense+= 0f;
			 GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 0f;
			GameControl.coreSkillBonus[6] += 0f;
			break;
		case 80005:
			GameControl.attStyle+= 2;
			GameControl.charCombatDefense+= 0f;
			GameControl.charLustDefense += 0f;
			GameControl.coreSkillBonus[0]+= 2f;
			GameControl.coreSkillBonus[6] += 2;
			break;
		case 80006:
			GameControl.attStyle+= 3;
			GameControl.charCombatDefense+= 0f;
			GameControl.charLustDefense += 0.015f;
			GameControl.coreSkillBonus[9]+= 2f;
			GameControl.coreSkillBonus[6] += 2;
			break;
		case 80007:
			GameControl.attStyle+= 1;
			GameControl.charCombatDefense+= 0f;
			GameControl.charLustDefense += 0f;
			break;
		case 80500:
			GameControl.attStyle+= 2;
			GameControl.charCombatDefense+= 2f;
			GameControl.charLustDefense += 2f;
			GameControl.coreSkillBonus[0]+= 2f;
			GameControl.coreSkillBonus[6] += 2;
			break;
		case 90001:
			GameControl.attStyle += 2;
			break;
		case 90002:
			GameControl.attStyle -= 5;
			break;
		case 90003:
			GameControl.attStyle += 1;
			break;
		case 90004:
			GameControl.attStyle += 5;
			break;
		case 100001:
			GameControl.attStyle += 1;
			break;
		case 100002:
			GameControl.attStyle += 2;
			break;
		case 100003:
			GameControl.attStyle += 3;
			break;
		case 110004:
			GameControl.charCombatDefense += 0.1f;
			GameControl.charLustDefense += 0.1f;
			GameControl.attBonus [0] += 5;
			GameControl.attBonus [1] += 5;
			GameControl.attBonus [2] += 5;
			GameControl.attBonus [3] += 5;
			break;
		case 110001:
			GameControl.attStyle += 3;
			//magic bonus
			break;
		case 110002:
			GameControl.attStyle += 3;
			GameControl.charCombatDefense += 0.15f;
			GameControl.attBonus [0] += 5;
			GameControl.charCombatAttack += 0.15f;
			break;
		case 110003:
			GameControl.attStyle += 3;
			GameControl.charCombatDefense += 0.1f;
			GameControl.charLustDefense += 0.1f;
			GameControl.attBonus [6] += 5;
			GameControl.charLustAttack += 0.1f;
			break;

		default:
			break;

		}

	}



	void resetEquip(){
		if (GameControl.charEquipment [0] == 0) {
			GameControl.charEquipment [0] = 10000;
		}
		if (GameControl.charEquipment [1] == 0) {
			GameControl.charEquipment [1] = 20000;
		}
		if (GameControl.charEquipment [2] == 0) {
			GameControl.charEquipment [2] = 30000;
		}
		if (GameControl.charEquipment [3] == 0) {
			GameControl.charEquipment [3] = 40000;
		}
		if (GameControl.charEquipment [4] == 0) {
			GameControl.charEquipment [4] = 50000;
		}
		if (GameControl.charEquipment [5] == 0) {
			GameControl.charEquipment [5] = 60000;
		}
		if (GameControl.charEquipment [6] == 0) {
			GameControl.charEquipment [6] = 70000;
		}
		if (GameControl.charEquipment [7] == 0) {
			GameControl.charEquipment [7] = 80000;
		}
		if (GameControl.charEquipment [8] == 0) {
			GameControl.charEquipment [8] = 90000;
		}
		if (GameControl.charEquipment [9] == 0) {
			GameControl.charEquipment [9] = 100000;
		}
		if (GameControl.charEquipment [10] == 0) {
			GameControl.charEquipment [10] = 110000;
		}
		if (GameControl.charEquipment [11] == 0) {
			GameControl.charEquipment [11] = 120000;
		}
	}












}
