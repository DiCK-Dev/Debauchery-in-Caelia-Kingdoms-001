using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CharSkillsChange : MonoBehaviour {

	public Text Board; 
	public Text charSkill1Txt; 
	public Text charSkill2Txt; 
	public Text charSkill3Txt; 
	public Text charSkill4Txt; 



	public static int skillSlot; // decides which skill you will change 

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


	public void selectSkillSlot(int selector){
		skillSlot = selector; 
	}




	public void addSkill(int selector){

		if (selector == 100) {
			GameControl.activeSkills [skillSlot] = 100;
			Board.text = "Your skill has been changed to Fast chop!" ;
		}

		if (selector == 110) {
			if (GameControl.skillSetLevel [0] >= 1) {
				GameControl.activeSkills [skillSlot] = 110;
				Board.text = "Your skill has been changed to Defensive Rubbing!" ;

			}

		}


		if (selector == 120) 
		{
			if (GameControl.skillSetLevel [0] >= 2) 
			{
				GameControl.activeSkills [skillSlot] = 120;
				Board.text = "Your skill has been changed to Pinning down!" ;
			}

		}

		if (selector == 130) 
		{
			if (GameControl.skillSetLevel [0] >= 3) 
			{
				GameControl.activeSkills [skillSlot] = 130;
				Board.text = "Your skill has been changed to Suplex!" ;

			}

		}



		if (selector == 200) 
		{
			GameControl.activeSkills [skillSlot] = 200;
			Board.text = "Your skill has been changed to High kick!" ;

		}


		if (selector == 210) 
		{
			if (GameControl.skillSetLevel [1] >= 1) 
			{
				GameControl.activeSkills [skillSlot] = 210;
				Board.text = "Your skill has been changed to Flash kick!" ;

			}

		}

		if (selector == 220) 
		{
			if (GameControl.skillSetLevel [1] >= 2) 
			{
				GameControl.activeSkills [skillSlot] = 220;
				Board.text = "Your skill has been changed to Crotch Toss!" ;

			}

		}

		if (selector == 230) 
		{
			if (GameControl.skillSetLevel [1] >= 3) 
			{
				GameControl.activeSkills [skillSlot] = 230;
				Board.text = "Your skill has been Chokehold!" ;

			}

		}

		if (selector == 300) 
		{
			GameControl.activeSkills [skillSlot] = 300;
			Board.text = "Your skill has been changed to Bodyslam!" ;

		}


		if (selector == 310) 
		{
			if (GameControl.skillSetLevel [2] >= 1) 
			{
				GameControl.activeSkills [skillSlot] = 310;
				Board.text = "Your skill has been changed to Carnal Rage!" ;

			}

		}

		if (selector == 320) 
		{
			if (GameControl.skillSetLevel [2] >= 2) 
			{
				GameControl.activeSkills [skillSlot] = 320;
				Board.text = "Your skill has been changed to Bear hug!" ;

			}

		}

		if (selector == 330) 
		{
			if (GameControl.skillSetLevel [2] >= 3) 
			{
				GameControl.activeSkills [skillSlot] = 330;
				Board.text = "Your skill has been changed to Reckless biting!" ;

			}

		}


		if (selector == 400) 
		{
			GameControl.activeSkills [skillSlot] = 400;
			Board.text = "Your skill has been changed to Lust potion!" ;

		}


		if (selector == 410) 
		{
			if (GameControl.skillSetLevel [3] >= 1) 
			{
				GameControl.activeSkills [skillSlot] = 410;
				Board.text = "Your skill has been changed to Erotic Oil!" ;

			}

		}

		if (selector == 420) 
		{
			if (GameControl.skillSetLevel [3] >= 2) 
			{
				GameControl.activeSkills [skillSlot] = 420;
				Board.text = "Your skill has been changed to Sensitivity dart!" ;

			}

		}

		if (selector == 430) 
		{
			if (GameControl.skillSetLevel [3] >= 3) 
			{
				GameControl.activeSkills [skillSlot] = 430;
				Board.text = "Your skill has been changed to Nympho conconction!" ;

			}

		}


		if (selector == 500) 
		{
			GameControl.activeSkills [skillSlot] = 500;
			Board.text = "Your skill has been changed to Sabotage!" ;

		}


		if (selector == 510) 
		{
			if (GameControl.skillSetLevel [4] >= 1) 
			{
				GameControl.activeSkills [skillSlot] = 510;
				Board.text = "Your skill has been changed to Bravery!" ;

			}

		}

		if (selector == 520) 
		{
			if (GameControl.skillSetLevel [4] >= 2) 
			{
				GameControl.activeSkills [skillSlot] = 520;
				Board.text = "Your skill has been changed to Surprise grab!" ;

			}

		}

		if (selector == 530) 
		{
			if (GameControl.skillSetLevel [4] >= 3) 
			{
				GameControl.activeSkills [skillSlot] = 530;
				Board.text = "Your skill has been changed to Innocent strike!" ;

			}

		}


		if (selector == 600) 
		{
			GameControl.activeSkills [skillSlot] = 600;
			Board.text = "Your skill has been changed to Soothing message!" ;

		}


		if (selector == 610) 
		{
			if (GameControl.skillSetLevel [5] >= 1) 
			{
				GameControl.activeSkills [skillSlot] = 610;
				Board.text = "Your skill has been changed to Lewd taunt!" ;

			}

		}

		if (selector == 620) 
		{
			if (GameControl.skillSetLevel [5] >= 2) 
			{
				GameControl.activeSkills [skillSlot] = 620;
				Board.text = "Your skill has been changed to Diplomatic immunity!" ;

			}

		}

		if (selector == 630) 
		{
			if (GameControl.skillSetLevel [6] >= 3) 
			{
				GameControl.activeSkills [skillSlot] = 630;
				Board.text = "Your skill has been changed to Erotic story!" ;

			}

		}



	}











	// Text for panels
	public void mainText()
	{
		Board.text = "Which skill do you want to change?"; 
	}
	public void skillPanelText()
	{
		Board.text = "Right know your level in different skills is: \n\nBalanced level: "+ GameControl.skillSetLevel[0] +".\nMartial arts level: "+ GameControl.skillSetLevel[1] + ".\nBerserker level: "+ GameControl.skillSetLevel[2] +".\nAlchemist level: "+ GameControl.skillSetLevel[3] +".\nTrickster level: "+ GameControl.skillSetLevel[4] +".\nDiplomat level: "+ GameControl.skillSetLevel[5] +".    \n\nPick which type of skill you want to change"; 
	}

	/*
	public void skillType100Panel(){
		Board.text = "Balanced skills are consistent and accurate, and although not as powerful as others, these attributes can be key in certain battles. \n\nRises physical attribute. "; 
	}
	public void skillType200Panel(){
		Board.text = "Good will damage with some lust increase to the opponent too, although that can go both ways… \n\nRises physical attribute."; 
	}
	public void skillType300Panel(){
		Board.text = "Very powerful will damage, but at the same time the recklessness of these attacks means they are risky to use, with low accuracy.\n\nRises physical attribute. "; 
	}
	public void skillType400Panel(){
		Board.text = "Very good at rising lust of the opponent, with both consistent attacks and risky ones, although failing with these attacks is somewhat catastrophic… \n\nRises: Mental. "; 
	}
	public void skillType500Panel(){
		Board.text = "Very risky attacks, for those who like to gamble. A good mix between lust and will damage, with high critical, but also high critical failure…\n\nRises: Mental."; 
	}
	public void skillType600Panel(){
		Board.text = "For those who rather stop the enemies with its impressive presence than by a show of their physical prowess. Does mixed damage, and failure usually reduces your will more than anything. \n\nRises: Social"; 
	}


*/



	void Start () {

		Board.text = "The skills in this section attack vs the enemy combat defense. Tough enemies, like the werewolves, will be very good at resisting these attacks, while others like the bunny girl or plant girl are susceptible to the rough treatment. \n\nFor more information about combat go to the court in your castle! \nWhich skill do you want to change?"; 
	
	}
	
	// Update is called once per frame
	void Update () {
		charSkill1Txt.text = "Change " + SkillSet.skillSetDictionary [GameControl.activeSkills[0]].skillName;
		charSkill2Txt.text = "Change " +SkillSet.skillSetDictionary [GameControl.activeSkills[1]].skillName;
		charSkill3Txt.text = "Change " + SkillSet.skillSetDictionary [GameControl.activeSkills[2]].skillName;
		charSkill4Txt.text = "Change " +SkillSet.skillSetDictionary [GameControl.activeSkills[3]].skillName;
	}
}
