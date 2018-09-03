using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SceneUI : MonoBehaviour {
	/// <summary>
	/// ITS THE UI FOR THE COMBAT 
	/// </summary>


	//top right panel
	public Text textDay; 
	public Text textTime;

	// top mid panel
	public Text location; 


	//middle left panel
	public Text physAtt;
	public Text mentAtt;
	public Text socAtt; 
	public Text comType;
	public Text lustType; 
	public Text charName; 

	//middle right panel
	public Text eneName; 
	public Text race;
	public Text eneComType;
	public Text eneLustType; 

	// Button panel

	public Text buttSkill1;
	public Text buttSkill2;
	public Text buttSkill3;
	public Text buttSkill4;
	public Text buttLust1;
	public Text buttLust2;
	public Text buttLust3;
	public Text buttLust4; 


	void Awake(){



	}


	void Start (){


		charName.text = GameControl.playerName; 

		location.text = WorldControl.location; 
		textDay.text = WorldControl.day.ToString ();
		textTime.text = WorldControl.dayTimeName; 
		eneComType.text = WorldControl.eneComType;
		eneLustType.text = WorldControl.eneLustType; 
		race.text = WorldControl.eneRace; 
		eneName.text = WorldControl.eneName; 

		buttSkill1.text = SkillSet.skillSetDictionary [GameControl.activeSkills [0]].skillName;
		buttSkill2.text = SkillSet.skillSetDictionary [GameControl.activeSkills [1]].skillName;
		buttSkill3.text = SkillSet.skillSetDictionary [GameControl.activeSkills [2]].skillName;
		buttSkill4.text = SkillSet.skillSetDictionary [GameControl.activeSkills [3]].skillName;

		buttLust1.text = LustSet.LustSetDictionary [GameControl.activeLust [0]].skillName; 
		buttLust2.text = LustSet.LustSetDictionary [GameControl.activeLust [1]].skillName; 
		buttLust3.text = LustSet.LustSetDictionary [GameControl.activeLust [2]].skillName; 
		buttLust4.text = LustSet.LustSetDictionary [GameControl.activeLust [3]].skillName; 
	}


	void Update () {



		physAtt.text = GameControl.attPhysical.ToString(); 
		mentAtt.text = GameControl.attMental.ToString();
		socAtt.text = GameControl.attSocial.ToString(); 
		comType.text = GameControl.charCorruption.ToString();
		lustType.text = GameControl.charGold.ToString(); 





	
	}
}
