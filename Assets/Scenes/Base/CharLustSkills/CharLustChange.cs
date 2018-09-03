using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CharLustChange : MonoBehaviour {
	public Text Board; 
	public Text charSkill1Txt; //name of 
	public Text charSkill2Txt; 
	public Text charSkill3Txt; 
	public Text charSkill4Txt; 


	public static int skillSlot; // decides which skill you will change 
	/*
	public void slot1(){
		skillSlot = 0;
	}
	public void slot2(){
		skillSlot = 1;
	}

	public void slot3(){
		skillSlot = 2;
	}

	public void slot4(){
		skillSlot = 3;
	}
*/
	public void selectSkillSlot(int selector){
		skillSlot = selector; 
	}




	public void addSkill(int selector){

			if (selector == 100) {
				GameControl.activeLust [skillSlot] = 100;
				Board.text = "Your skill has been changed to Indecent smile!" ;
			}

			if (selector == 110) {
				if (GameControl.lustSetLevel [0] >= 1) {
					GameControl.activeLust[skillSlot] = 110;
					Board.text = "Your skill has been changed to Skin show!" ;

				}

			}


			if (selector == 120) 
			{
				if (GameControl.lustSetLevel [0] >= 2) 
				{
				GameControl.activeLust[skillSlot] = 120;
				Board.text = "Your skill has been changed to Trip up!" ;
				}

			}

			if (selector == 130) 
			{
				if (GameControl.lustSetLevel [0] >= 3) 
				{
				GameControl.activeLust[skillSlot] = 130;
				Board.text = "Your skill has been changed to Playful chase!" ;

				}

			}



		if (selector == 200) 
		{
			GameControl.activeLust[skillSlot] = 200;
			Board.text = "Your skill has been changed to Perfumed!" ;

		}


		if (selector == 210) 
		{
			if (GameControl.lustSetLevel [1] >= 1) 
			{
				GameControl.activeLust[skillSlot] = 210;
				Board.text = "Your skill has been changed to Veil dance!" ;

			}

		}

		if (selector == 220) 
		{
			if (GameControl.lustSetLevel [1] >= 2) 
			{
				GameControl.activeLust[skillSlot] = 220;
				Board.text = "Your skill has been changed to Self-Spanking!" ;

			}

		}

		if (selector == 230) 
		{
			if (GameControl.lustSetLevel [1] >= 3) 
			{
				GameControl.activeLust[skillSlot] = 230;
				Board.text = "Your skill has been changed to Fondling!" ;

			}

		}

		if (selector == 300) 
		{
			GameControl.activeLust[skillSlot] = 300;
			Board.text = "Your skill has been changed to Flashy bits!" ;

		}


		if (selector == 310) 
		{
			if (GameControl.lustSetLevel [2] >= 1) 
			{
				GameControl.activeLust[skillSlot] = 310;
				Board.text = "Your skill has been changed to Striptease!" ;

			}

		}

		if (selector == 320) 
		{
			if (GameControl.lustSetLevel [2] >= 2) 
			{
				GameControl.activeLust[skillSlot] = 320;
				Board.text = "Your skill has been changed to Crotch strip!" ;

			}

		}

		if (selector == 330) 
		{
			if (GameControl.lustSetLevel [2] >= 3) 
			{
				GameControl.activeLust[skillSlot] = 330;
				Board.text = "Your skill has been changed to Full moon!" ;

			}

		}


		if (selector == 400) 
		{
			GameControl.activeLust[skillSlot] = 400;
			Board.text = "Your skill has been changed to Staredown!" ;

		}


		if (selector == 410) 
		{
			if (GameControl.lustSetLevel [3] >= 1) 
			{
				GameControl.activeLust[skillSlot] = 410;
				Board.text = "Your skill has been changed to Humiliation!" ;

			}

		}

		if (selector == 420) 
		{
			if (GameControl.lustSetLevel [3] >= 2) 
			{
				GameControl.activeLust[skillSlot] = 420;
				Board.text = "Your skill has been changed to Body showoff!" ;

			}

		}

		if (selector == 430) 
		{
			if (GameControl.lustSetLevel [3] >= 3) 
			{
				GameControl.activeLust[skillSlot] = 430;
				Board.text = "Your skill has been changed to Command!" ;

			}

		}


		if (selector == 500) 
		{
			GameControl.activeLust[skillSlot] = 500;
			Board.text = "Your skill has been changed to Teasing lick!" ;

		}


		if (selector == 510) 
		{
			if (GameControl.lustSetLevel [4] >= 1) 
			{
				GameControl.activeLust[skillSlot] = 510;
				Board.text = "Your skill has been changed to Crotch grab!" ;

			}

		}

		if (selector == 520) 
		{
			if (GameControl.lustSetLevel [4] >= 2) 
			{
				GameControl.activeLust[skillSlot] = 520;
				Board.text = "Your skill has been changed to Body rubbing!" ;

			}

		}

		if (selector == 530) 
		{
			if (GameControl.lustSetLevel [4] >= 3) 
			{
				GameControl.activeLust[skillSlot] = 530;
				Board.text = "Your skill has been changed to Pervert show!" ;

			}

		}


		if (selector == 600) 
		{
			GameControl.activeLust[skillSlot] = 600;
			Board.text = "Your skill has been changed to Groin shoving!" ;

		}


		if (selector == 610) 
		{
			if (GameControl.lustSetLevel [5] >= 1) 
			{
				GameControl.activeLust[skillSlot] = 610;
				Board.text = "Your skill has been changed to Hold fast!" ;

			}

		}

		if (selector == 620) 
		{
			if (GameControl.lustSetLevel [5] >= 2) 
			{
				GameControl.activeLust[skillSlot] = 620;
				Board.text = "Your skill has been changed to Forced kissing!" ;

			}

		}

		if (selector == 630) 
		{
			if (GameControl.lustSetLevel [6] >= 3) 
			{
				GameControl.activeLust[skillSlot] = 630;
				Board.text = "Your skill has been changed to Coerced touch!" ;

			}

		}



	}





	public void sceneTexts(int selector){
		if (selector == 0) {
			Board.text = "Pick a skill type."; 
			Board.text += "\n\nRight know your level in different skills is: \n\nFlirty level: "+ GameControl.lustSetLevel[0] +".\nEnticing level: "+ GameControl.lustSetLevel[1] + ".\nExhibitionist level: "+ GameControl.lustSetLevel[2] +".\nDominant level: "+ GameControl.lustSetLevel[3] +".\nSlutty level: "+ GameControl.lustSetLevel[4] +".\nForceful level: "+ GameControl.lustSetLevel[5] +".    \n\nPick which type of skill you want to change"; 

		}
		if (selector == 1) {
			//skill 100
			Board.text = "For those who love to tease without going too far! Balanced reducing both the will to fight of the opponent and increasing its lust. \n\nRises: Social \n"; 

		}
		if (selector == 2) {
			//skill 200
			Board.text = "A mix of sophistication and daring acts, which has its own risks. These skills focus on increasing lust and alluring enemies to their demise. \n\nRises: Mental"; 

		}
		if (selector == 3) {
			//skill 300
			Board.text = "The boldest approach of them all, since there is nothing more dangerous than uncovering yourself in the middle of battle. Then again, these movements are also very powerful and great at increasing the lust of the enemy. \n\nRises: Social"; 

		}
		if (selector == 4) {
			//skill 400
			Board.text = "Arousing the enemy is not the only way to get them where you want. These skills focus more on reducing the will to fight of the opponent, although the power play may increase your own lust in exchange…\n\nRises: Social"; 

		}
		if (selector == 5) {
			//skill 500
			Board.text = "For those who can’t wait until the fight is over, this style is both sexy and powerful, but all that foreplay has a cost…\n\nRises: Social"; 

		}
		if (selector == 6) {
			//skill 600
			Board.text = "For those who just care about themselves. Forceful affects both the will and lust of the opponents in a powerful manner. But careful, failing may demoralize you, reducing your will.\n\nRises: Physical "; 

		}


	}


	// Text for panels
	/*
	public void mainText()
	{
	//	Board.text = "Which skill do you want to change?"; 
	}
	public void skillPanelText()
	{
	//	Board.text = "Right know your level in different skills is: \n\nFlirty level: "+ GameControl.lustSetLevel[0] +".\nEnticing level: "+ GameControl.lustSetLevel[1] + ".\nExhibitionist level: "+ GameControl.lustSetLevel[2] +".\nDominant level: "+ GameControl.lustSetLevel[3] +".\nSlutty level: "+ GameControl.lustSetLevel[4] +".\nForceful level: "+ GameControl.lustSetLevel[5] +".    \n\nPick which type of skill you want to change"; 
	}
	public void skillType100Panel(){
	//	Board.text = "For those who love to tease without going too far! Balanced reducing both the will to fight of the opponent and increasing its lust. \n\nRises: Social \n"; 
	}
	public void skillType200Panel(){
//		Board.text = "A mix of sophistication and daring acts, which has its own risks. These skills focus on increasing lust and alluring enemies to their demise. \n\nRises: Mental"; 
	}
	public void skillType300Panel(){
	//	Board.text = "The boldest approach of them all, since there is nothing more dangerous than uncovering yourself in the middle of battle. Then again, these movements are also very powerful and great at increasing the lust of the enemy. \n\nRises: Social"; 
	}
	public void skillType400Panel(){
	//	Board.text = "Arousing the enemy is not the only way to get them where you want. These skills focus more on reducing the will to fight of the opponent, although the power play may increase your own lust in exchange…\n\nRises: Social"; 
	}
	public void skillType500Panel(){
	//	Board.text = "For those who can’t wait until the fight is over, this style is both sexy and powerful, but all that foreplay has a cost…\n\nRises: Social"; 
	}
	public void skillType600Panel(){
	//	Board.text = "For those who just care about themselves. Forceful affects both the will and lust of the opponents in a powerful manner. But careful, failing may demoralize you, reducing your will.\n\nRises: Physical "; 
	}


*/


	void Start () {

		Board.text = "The skills in this section attack vs the enemy seduction defense. Lustful enemies, like the bunny girl, will be very good at resisting these attacks, while others like the werewolf are more susceptible to the alluring treatment. \n\nFor more information go to the court in your castle!\nWhich skill do you want to change?"; 

	}

	// Update is called once per frame
	void Update () {

		charSkill1Txt.text = "Change " + LustSet.LustSetDictionary [GameControl.activeLust[0]].skillName;
		charSkill2Txt.text = "Change " + LustSet.LustSetDictionary [GameControl.activeLust[1]].skillName;
		charSkill3Txt.text = "Change " + LustSet.LustSetDictionary [GameControl.activeLust[2]].skillName;
		charSkill4Txt.text = "Change " + LustSet.LustSetDictionary [GameControl.activeLust[3]].skillName;

	}
}
