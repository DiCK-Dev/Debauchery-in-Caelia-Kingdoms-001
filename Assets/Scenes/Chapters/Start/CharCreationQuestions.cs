using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CharCreationQuestions : MonoBehaviour {


	public Text Board;

	public void selectQuestion(int selector){


		switch (selector) {
		case 0:

			Board.text = "After leaving the city, you lived in a cabin far into the woods with your Guardian. The initial conditions were rough, always under attack by wild animals, and at the mercy of the weather. Both of you survived this toughs time, and you always helped your Guardian by…";
			GameControl.attSocial += 10; 
			GameControl.coreSkillPersuasion += 10;
			GameControl.coreSkillIntrigue += 10;
			GameControl.coreSkillDiplomacy += 10;
			GameControl.utilitySkillPerformance += 10;
			GameControl.utilitySkillEtiquette += 10;
			GameControl.utilitySkillStreetwise += 10;
			GameControl.sexSkillPetting += 10;
			break;
		case 1:

			Board.text = "After leaving the city, you lived in a cabin far into the woods with your Guardian. The initial conditions were rough, always under attack by wild animals, and at the mercy of the weather. Both of you survived this toughs time, and you always helped your Guardian by…";
			GameControl.attSocial += 10; 
			GameControl.attPhysical += 10;
			GameControl.coreSkillMartial += 10;
			GameControl.coreSkillSecurity += 10;
			GameControl.coreSkillTactics += 10;
			GameControl.utilitySkillMedicine += 10;
			GameControl.utilitySkillCrafting += 10;
			GameControl.utilitySkillPerformance += 10;
			GameControl.genderBehaviorStat -= 5; 
			break;
		case 2:

			Board.text = "After leaving the city, you lived in a cabin far into the woods with your Guardian. The initial conditions were rough, always under attack by wild animals, and at the mercy of the weather. Both of you survived this toughs time, and you always helped your Guardian by…";
			GameControl.attSocial += 10; 
			GameControl.attMental += 10;
			GameControl.coreSkillGovernance += 10;
			GameControl.coreSkillStewardship += 10;
			GameControl.coreSkillPersuasion += 10;
			GameControl.utilitySkillLearning += 10;
			GameControl.utilitySkillAlchemy += 10;
			GameControl.utilitySkillEtiquette += 10;
			break;
		case 3:

			Board.text = "After leaving the city, you lived in a cabin far into the woods with your Guardian. The initial conditions were rough, always under attack by wild animals, and at the mercy of the weather. Both of you survived this toughs time, and you always helped your Guardian by…";
			GameControl.attSocial += 10; 
			GameControl.attPhysical += 3;
			GameControl.attMental += 2;
			GameControl.coreSkillLabor += 15;
			GameControl.coreSkillSecurity += 10;
			GameControl.coreSkillGovernance += 10;
			GameControl.utilitySkillFarmHand += 10;
			GameControl.utilitySkillFarmHand += 10;
			GameControl.utilitySkillHouseKeeping += 10;
			GameControl.maxHealth += 30;
			GameControl.actualHealth += 30;
			break;
		case 10:
			Board.text = "A year has passed since you left your home, and finally, there is some contact with the civilized world: A courier who was an old friend of your Guardian finally finds your location. He was sent to explore and help your mother find you both, but your mother herself disappeared not long before the courier set out.\n\nHe promised to help you with goods and trade. You usually ask him for…\n";
			GameControl.attSocial += 5;
			GameControl.coreSkillPersuasion += 10;
			GameControl.coreSkillGovernance += 10;
			GameControl.utilitySkillPerformance += 15;
			GameControl.utilitySkillEtiquette += 5;
			GameControl.sexSkillEscorting += 5;	
			break;
		case 11:

			Board.text = "A year has passed since you left your home, and finally, there is some contact with the civilized world: A courier who was an old friend of your Guardian finally finds your location. He was sent to explore and help your mother find you both, but your mother herself disappeared not long before the courier set out.\n\nHe promised to help you with goods and trade. You usually ask him for…\n";
			GameControl.attPhysical += 5;
			GameControl.coreSkillMartial += 5;
			GameControl.coreSkillTactics += 5;
			GameControl.coreSkillSecurity += 10;
			GameControl.utilitySkillFarmHand += 5;
			GameControl.utilitySkillCrafting += 15;
			GameControl.genderBehaviorStat -= 3;
			break;
		case 12:

			Board.text = "A year has passed since you left your home, and finally, there is some contact with the civilized world: A courier who was an old friend of your Guardian finally finds your location. He was sent to explore and help your mother find you both, but your mother herself disappeared not long before the courier set out.\n\nHe promised to help you with goods and trade. You usually ask him for…\n";
			GameControl.attMental += 5;
			GameControl.coreSkillStewardship += 10;
			GameControl.coreSkillTactics += 10;
			GameControl.utilitySkillLearning += 10;
			GameControl.utilitySkillCrafting += 5;
			GameControl.utilitySkillAlchemy += 5;

			break;
		case 13:

			Board.text = "A year has passed since you left your home, and finally, there is some contact with the civilized world: A courier who was an old friend of your Guardian finally finds your location. He was sent to explore and help your mother find you both, but your mother herself disappeared not long before the courier set out.\n\nHe promised to help you with goods and trade. You usually ask him for…\n";
			GameControl.attPhysical += 2;
			GameControl.attMental += 3;
			GameControl.coreSkillLabor += 5;
			GameControl.coreSkillSecurity += 5;
			GameControl.coreSkillStewardship += 10;
			GameControl.utilitySkillFarmHand += 10;
			GameControl.utilitySkillHouseKeeping += 10;
			GameControl.genderBehaviorStat += 5;
			break;
		case 20:
			Board.text = "It takes difficult years to establish a good farm with a couple of animals and crops. Once you did, your life in the forest became sustainable. It’s time for you to learn about being royalty from your Guardian, who was known at the court for being...\n";
			GameControl.attSocial += 5;
			GameControl.coreSkillPersuasion += 10;
			GameControl.coreSkillDiplomacy += 5;
			GameControl.utilitySkillStreetwise += 10;
			GameControl.utilitySkillEtiquette += 10;
			break;
		case 21:

			Board.text = "It takes difficult years to establish a good farm with a couple of animals and crops. Once you did, your life in the forest became sustainable. It’s time for you to learn about being royalty from your Guardian, who was known at the court for being...\n";
			GameControl.attPhysical += 5;
			GameControl.coreSkillMartial += 10;
			GameControl.coreSkillSecurity += 5;
			GameControl.utilitySkillCrafting += 5;
			GameControl.utilitySkillHouseKeeping += 10;
			GameControl.coreSkillLabor += 5;
			break;
		case 22:

			Board.text = "It takes difficult years to establish a good farm with a couple of animals and crops. Once you did, your life in the forest became sustainable. It’s time for you to learn about being royalty from your Guardian, who was known at the court for being...\n";
			GameControl.attMental += 5;
			GameControl.coreSkillStewardship += 5;
			GameControl.coreSkillGovernance += 5;
			GameControl.coreSkillTactics += 5;
			GameControl.utilitySkillAlchemy += 10;
			GameControl.utilitySkillLearning += 10;
			break;
		case 23:

			Board.text = "It takes difficult years to establish a good farm with a couple of animals and crops. Once you did, your life in the forest became sustainable. It’s time for you to learn about being royalty from your Guardian, who was known at the court for being...\n";
			GameControl.attSocial += 5;
			GameControl.coreSkillIntrigue += 10;
			GameControl.coreSkillDiplomacy += 5;
			GameControl.utilitySkillStreetwise += 15;
			GameControl.utilitySkillPerformance += 5;
			GameControl.sexSkillStripping += 10;
			break;
		case 30:
			Board.text = "Finally, after 5 years in the lonely forest, your Guardian thought it safe enough to get out and visit a neighboring city. Even though it wasn’t the city of your birth, you are excited about this trip. After arriving, your Guardian gives you a pouch with gold and leaves you to do your own thing for a while. You decide too…";
			GameControl.attSocial += 5;
			GameControl.coreSkillIntrigue += 15;
			GameControl.utilitySkillEtiquette += 15;
			GameControl.genderBehaviorStat += 5;

			break;
		case 31:

			Board.text = "Finally, after 5 years in the lonely forest, your Guardian thought it safe enough to get out and visit a neighboring city. Even though it wasn’t the city of your birth, you are excited about this trip. After arriving, your Guardian gives you a pouch with gold and leaves you to do your own thing for a while. You decide too…";
			GameControl.attPhysical += 5;
			GameControl.coreSkillMartial += 15;
			GameControl.utilitySkillEtiquette += 10;
			GameControl.utilitySkillPerformance += 5;
			GameControl.genderBehaviorStat += 5;
			break;
		case 32:

			Board.text = "Finally, after 5 years in the lonely forest, your Guardian thought it safe enough to get out and visit a neighboring city. Even though it wasn’t the city of your birth, you are excited about this trip. After arriving, your Guardian gives you a pouch with gold and leaves you to do your own thing for a while. You decide too…";
			GameControl.attMental += 5;
			GameControl.coreSkillStewardship += 15;
			GameControl.utilitySkillLearning += 15;
			break;
		case 33:

			Board.text = "Finally, after 5 years in the lonely forest, your Guardian thought it safe enough to get out and visit a neighboring city. Even though it wasn’t the city of your birth, you are excited about this trip. After arriving, your Guardian gives you a pouch with gold and leaves you to do your own thing for a while. You decide too…";
			GameControl.attSocial += 5;
			GameControl.coreSkillPersuasion += 5;
			GameControl.coreSkillSecurity += 5;
			GameControl.coreSkillStewardship += 5;
			GameControl.utilitySkillStreetwise += 15;
			GameControl.coreSkillLabor += 5;
			GameControl.sexSkillWhoring += 50;
			GameControl.sexSkillStripping += 15;
			GameControl.sexSkillPenetration += 15;
			GameControl.sexSkillEscorting += 5;
			GameControl.charCorruption += 5;
			break;
		case 40:
			Board.text = "There is something strange in the air: A very sweet smell that's unusual for this time of the year. After both you and your Guardian look for guidance in the books you have, you find this is the likely the result of an alchemical experiment and a very massive one. Days later, you and your Guardian find yourselves aroused all the time, with impure thoughts dominating your head. You decide to…";
			GameControl.attSocial += 5;
			GameControl.coreSkillDiplomacy += 5;
			GameControl.coreSkillPersuasion += 5;
			GameControl.utilitySkillStreetwise += 5;
			GameControl.utilitySkillEtiquette += 5;
			GameControl.utilitySkillPerformance += 5;
			break;
		case 41:

			Board.text = "There is something strange in the air: A very sweet smell that's unusual for this time of the year. After both you and your Guardian look for guidance in the books you have, you find this is the likely the result of an alchemical experiment and a very massive one. Days later, you and your Guardian find yourselves aroused all the time, with impure thoughts dominating your head. You decide to…";
			GameControl.attPhysical += 5;
			GameControl.coreSkillTactics += 10;
			GameControl.utilitySkillStreetwise += 5;
			GameControl.utilitySkillPerformance += 5;
			GameControl.utilitySkillMedicine += 5;
			GameControl.genderBehaviorStat -= 5;

			break;
		case 42:

			Board.text = "There is something strange in the air: A very sweet smell that's unusual for this time of the year. After both you and your Guardian look for guidance in the books you have, you find this is the likely the result of an alchemical experiment and a very massive one. Days later, you and your Guardian find yourselves aroused all the time, with impure thoughts dominating your head. You decide to…";
			GameControl.attMental += 5;
			GameControl.coreSkillStewardship += 5;
			GameControl.coreSkillGovernance += 5;
			GameControl.utilitySkillMedicine += 20;
			GameControl.utilitySkillAlchemy += 5;
			break;
		case 43:

			Board.text = "There is something strange in the air: A very sweet smell that's unusual for this time of the year. After both you and your Guardian look for guidance in the books you have, you find this is the likely the result of an alchemical experiment and a very massive one. Days later, you and your Guardian find yourselves aroused all the time, with impure thoughts dominating your head. You decide to…";
			GameControl.attStyle += 3;
			GameControl.attPhysical += 2;
			GameControl.coreSkillPersuasion += 5;
			GameControl.coreSkillIntrigue += 5;
			GameControl.utilitySkillEtiquette += 5;
			GameControl.isVirgin = false;
			GameControl.sexSkillMasseuse += 10;
			GameControl.sexSkillWhoring += 5;
			GameControl.sexSkillStripping += 10;
			GameControl.sexSkillGroupSex += 10;
			break;
		case 50:
			Board.text = "Not long after, winter arrived. A heavy snow storm trapped both of you in the house for months. Thankfully, you had enough food reserves to survive this, but the long, boring days were atrocious. After doing everything you could to entertain yourself, you decide to use your free time with… ";
			GameControl.attSocial += 5;
			GameControl.coreSkillPersuasion += 5;
			GameControl.utilitySkillPerformance += 5;
			GameControl.genderBehaviorStat += 5;
			GameControl.sexSkillStripping += 10;
			GameControl.charCorruption += 5;
			break;
		case 51:

			Board.text = "Not long after, winter arrived. A heavy snow storm trapped both of you in the house for months. Thankfully, you had enough food reserves to survive this, but the long, boring days were atrocious. After doing everything you could to entertain yourself, you decide to use your free time with… ";
			GameControl.attPhysical += 5;
			GameControl.coreSkillMartial += 5;
			GameControl.utilitySkillMedicine += 5;
			GameControl.genderBehaviorStat -= 5;
			GameControl.sexSkillBondage += 10;
			GameControl.charCorruption += 10;
			GameControl.attPiety -= 20;
			GameControl.isVirgin = false; 
			break;
		case 52:

			Board.text = "Not long after, winter arrived. A heavy snow storm trapped both of you in the house for months. Thankfully, you had enough food reserves to survive this, but the long, boring days were atrocious. After doing everything you could to entertain yourself, you decide to use your free time with… ";
			GameControl.attMental += 5;
			GameControl.coreSkillGovernance += 5;
			GameControl.utilitySkillAlchemy += 5;
			GameControl.charCorruption -= 5;
			break;
		case 53:

			Board.text = "Not long after, winter arrived. A heavy snow storm trapped both of you in the house for months. Thankfully, you had enough food reserves to survive this, but the long, boring days were atrocious. After doing everything you could to entertain yourself, you decide to use your free time with… ";
			GameControl.attPhysical += 5;
			GameControl.coreSkillIntrigue += 5;
			GameControl.coreSkillLabor += 5;
			GameControl.utilitySkillHouseKeeping += 5;
			GameControl.sexSkillPenetration += 10;
			GameControl.charCorruption += 5;
			break;
		case 60:
			Board.text = "The Courier informs you that a big plague swept through the Capitol months ago when you were affected by the arousing fragrance. The whole island is now under siege by monsters and creatures, making trade pretty difficult. You find your gold reserves running dry pretty soon, and you propose to…";
			GameControl.attSocial += 5;
			GameControl.coreSkillDiplomacy += 5;
			GameControl.utilitySkillEtiquette += 5;
			break;
		case 61:

			Board.text = "The Courier informs you that a big plague swept through the Capitol months ago when you were affected by the arousing fragrance. The whole island is now under siege by monsters and creatures, making trade pretty difficult. You find your gold reserves running dry pretty soon, and you propose to…";
			GameControl.attPhysical += 5;
			GameControl.coreSkillSecurity += 5;
			GameControl.utilitySkillLearning += 5;
			break;
		case 62:

			Board.text = "The Courier informs you that a big plague swept through the Capitol months ago when you were affected by the arousing fragrance. The whole island is now under siege by monsters and creatures, making trade pretty difficult. You find your gold reserves running dry pretty soon, and you propose to…";
			GameControl.attMental += 5;
			GameControl.coreSkillGovernance += 5;
			GameControl.utilitySkillLearning += 5;
			GameControl.attPiety += 20;
			GameControl.charCorruption -= 5;
			break;
		case 63:

			Board.text = "The Courier informs you that a big plague swept through the Capitol months ago when you were affected by the arousing fragrance. The whole island is now under siege by monsters and creatures, making trade pretty difficult. You find your gold reserves running dry pretty soon, and you propose to…";
			GameControl.attPhysical += 3;
			GameControl.attSocial += 2;
			GameControl.coreSkillPersuasion += 5;
			GameControl.utilitySkillPerformance += 5;
			GameControl.charAddictions [7] += 50;  
			GameControl.charCorruption += 10;
			GameControl.sexSkillWhoring += 5;
			GameControl.sexSkillPetting += 5;
			GameControl.isVirgin = false;
			break;
		case 70:
			Board.text = "Your Guardian has died. When he began to transform into a beast, he killed himself. You didn’t even have the chance to stop him or even talk before it was too late. Normally you had let your Guardian decide how to fight the monsters, but now it’s up to you. You decide to…";
			GameControl.attSocial += 5;
			GameControl.coreSkillGovernance += 5;
			GameControl.coreSkillStewardship += 5;
			GameControl.utilitySkillHouseKeeping += 5;
			break;
		case 71:

			Board.text = "Your Guardian has died. When he began to transform into a beast, he killed himself. You didn’t even have the chance to stop him or even talk before it was too late. Normally you had let your Guardian decide how to fight the monsters, but now it’s up to you. You decide to…";
			GameControl.attPhysical += 5;
			GameControl.coreSkillTactics += 5;
			GameControl.coreSkillMartial += 5;
			GameControl.utilitySkillFarmHand += 5;
			break;
		case 72:

			Board.text = "Your Guardian has died. When he began to transform into a beast, he killed himself. You didn’t even have the chance to stop him or even talk before it was too late. Normally you had let your Guardian decide how to fight the monsters, but now it’s up to you. You decide to…";
			GameControl.attMental += 5;
			GameControl.coreSkillPersuasion += 5;
			GameControl.coreSkillLabor += 5;
			GameControl.utilitySkillCrafting += 5;

			break;
		case 73:

			Board.text = "Your Guardian has died. When he began to transform into a beast, he killed himself. You didn’t even have the chance to stop him or even talk before it was too late. Normally you had let your Guardian decide how to fight the monsters, but now it’s up to you. You decide to…";
			GameControl.attSocial += 5;
			GameControl.coreSkillPersuasion += 5;
			GameControl.coreSkillLabor += 5;
			GameControl.utilitySkillPerformance += 5;
			GameControl.sexSkillMasseuse += 10;
			GameControl.sexSkillPetting += 10;
			GameControl.charCorruption += 10;
			break;
		case 80:
			Board.text = "The Courier finally came again with great news. Apparently, you are welcome back to the Capitol you left behind as a child. Not only that, but you also have inherited the lordship of the city. He gives you a map and waits for you to gather your belongings. While getting ready, you find a hidden stash left by your late Guardian, with a note for you. Apparently, this was a gift from your parents for when you were ready, and the gift is…";
			GameControl.attSocial += 5;
			GameControl.coreSkillPersuasion += 5;
			GameControl.coreSkillTactics += 5;
			GameControl.utilitySkillPerformance += 5;
			break;
		case 81:

			Board.text = "The Courier finally came again with great news. Apparently, you are welcome back to the Capitol you left behind as a child. Not only that, but you also have inherited the lordship of the city. He gives you a map and waits for you to gather your belongings. While getting ready, you find a hidden stash left by your late Guardian, with a note for you. Apparently, this was a gift from your parents for when you were ready, and the gift is…";
			GameControl.attPhysical += 5;
			GameControl.coreSkillMartial += 5;
			GameControl.coreSkillSecurity += 5;
			GameControl.coreSkillLabor += 5;
			break;
		case 82:

			Board.text = "The Courier finally came again with great news. Apparently, you are welcome back to the Capitol you left behind as a child. Not only that, but you also have inherited the lordship of the city. He gives you a map and waits for you to gather your belongings. While getting ready, you find a hidden stash left by your late Guardian, with a note for you. Apparently, this was a gift from your parents for when you were ready, and the gift is…";
			GameControl.attMental += 5;
			GameControl.coreSkillTactics += 5;
			GameControl.coreSkillIntrigue += 5;
			GameControl.utilitySkillCrafting += 5;
			break;
		case 83:

			Board.text = "The Courier finally came again with great news. Apparently, you are welcome back to the Capitol you left behind as a child. Not only that, but you also have inherited the lordship of the city. He gives you a map and waits for you to gather your belongings. While getting ready, you find a hidden stash left by your late Guardian, with a note for you. Apparently, this was a gift from your parents for when you were ready, and the gift is…";
			GameControl.attSocial += 5;
			GameControl.coreSkillPersuasion += 5;
			GameControl.sexSkillWhoring += 10;
			GameControl.charCorruption += 10;
			break;
		case 90:
			GameControl.invSlotArray [0,0] = 10022; // change for item
			GameControl.invSlotArray [0,1] = 1;

			if (GameControl.attPhysical < 20) {
				GameControl.attPhysical = 20;
			}
			if (GameControl.attMental < 20) {
				GameControl.attMental = 20;
			}
			if (GameControl.attSocial < 20) {
				GameControl.attSocial = 20;
			}
			break;
		case 91:

			GameControl.invSlotArray [0,0] = 20024; // change for item
			GameControl.invSlotArray [0,1] = 1;

			if (GameControl.attPhysical < 20) {
				GameControl.attPhysical = 20;
			}
			if (GameControl.attMental < 20) {
				GameControl.attMental = 20;
			}
			if (GameControl.attSocial < 20) {
				GameControl.attSocial = 20;
			}
			break;
		case 92:

			GameControl.utilitySkillAlchemy += 15;
			GameControl.utilitySkillLearning += 10;
			GameControl.utilitySkillCrafting += 5;

			if (GameControl.attPhysical < 20) {
				GameControl.attPhysical = 20;
			}
			if (GameControl.attMental < 20) {
				GameControl.attMental = 20;
			}
			if (GameControl.attSocial < 20) {
				GameControl.attSocial = 20;
			}
			break;
		case 93:

			GameControl.invSlotArray [0,0] = 110004; // change for item
			GameControl.invSlotArray [0,1] = 1;
			if (GameControl.attPhysical < 20) {
				GameControl.attPhysical = 20;
			}
			if (GameControl.attMental < 20) {
				GameControl.attMental = 20;
			}
			if (GameControl.attSocial < 20) {
				GameControl.attSocial = 20;
			}
			break;

		case 1000:
			Board.text = "As a kid, you remember you lived in a big castle, but for some reason that up to this day you don’t know you had to escape with your guardian, leaving your family behind. You don’t remember much about these years, but you still remember that your parents were proud of...";
			break;
		default:
			break;

		}

	}

	void Awake(){
		GameControl.charEquipment [0] = 10001;
		GameControl.charEquipment [1] = 20008;
		GameControl.activeSkills [0] = 100;
		GameControl.activeSkills [1] = 200;
		GameControl.activeSkills [2] = 300;
		GameControl.activeSkills [3] = 400;
		GameControl.activeLust [0] = 100; 
		GameControl.activeLust [1] = 200; 
		GameControl.activeLust [2] = 300; 
		GameControl.activeLust [3] = 400; 



	}

}
