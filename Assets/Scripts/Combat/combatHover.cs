using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class combatHover : MonoBehaviour {





	public Text attackHover; 
	public Text skill0Hover; 
	public Text skill1Hover; 
	public Text skill2Hover; 
	public Text skill3Hover; 

	public Text lust0Hover;
	public Text lust1Hover;
	public Text lust2Hover;
	public Text lust3Hover;


	void Start(){
		//attackHover.text = "This attack will come from another dictionary"; 

		skill0Hover.text = SkillSet.skillSetDictionary [GameControl.activeSkills  [0]].skillDescription; 
		skill1Hover.text = SkillSet.skillSetDictionary [GameControl.activeSkills  [1]].skillDescription; 
		skill2Hover.text = SkillSet.skillSetDictionary [GameControl.activeSkills  [2]].skillDescription; 
		skill3Hover.text = SkillSet.skillSetDictionary [GameControl.activeSkills  [3]].skillDescription; 


		lust0Hover.text = LustSet.LustSetDictionary [GameControl.activeLust[0]].skillDescription; 
		lust1Hover.text = LustSet.LustSetDictionary [GameControl.activeLust[1]].skillDescription; 
		lust2Hover.text = LustSet.LustSetDictionary [GameControl.activeLust[2]].skillDescription; 
		lust3Hover.text = LustSet.LustSetDictionary [GameControl.activeLust[3]].skillDescription; 
	}



	void Update ()
	{



	}



}
