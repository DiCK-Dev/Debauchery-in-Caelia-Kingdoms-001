using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CharCreationScene : MonoBehaviour {


	static int raceSelector; 
	static int genderSelector;
	static int physiqueSelector;
	static int buildSelector;
	static int classSelector; 

	public Button buttFinish; 
	public Toggle penisToggle;
	public Toggle vaginaToggle;
	public Toggle TesticlesToggle;
	public Toggle breastToggle; 

	public Text Board;

	public Animator panConfirmation; 


	int attributeStrong;

	//CharacteristicsSettler charSettler = new CharacteristicsSettler();

	CharSettler charSettler = new CharSettler();
	public InputField inputName; 


	public void callConfirmation(){

		panConfirmation.SetBool ("isDisplayed", true);
 


	}

	public void noSelection(){
		panConfirmation.SetBool ("isDisplayed", false);

	}




	// // name // // 
	void settleName () {

		if (inputName.text == "") {
			buttFinish.interactable = false; 
			 
			//buttName.GetComponent<Button> ().enabled = false; 
		} else {
			buttFinish.interactable = true;  
	
		}

	}

	void setName()
	{
		GameControl.playerName = inputName.text;
	}



	// // Race // // // 

	public void selectRace(int selector){
		raceSelector = selector; 
		if (raceSelector == 0) {
			Board.text = "You will start the game as a human!"; 
		}
		if (raceSelector == 1) {
			Board.text = "You will start the game as a monster-bunny!"; 
		}
		if (raceSelector == 2) {
			Board.text = "You will start the game as a monster-wolf!"; 
		}
		if (raceSelector == 3) {
			Board.text = "You will start the game as a monster-feline!"; 
		}

	}

	void setRace(){
		if (raceSelector == 0) {
			GameControl.mcHead = GameControl.MCHead.HUMAN;
			GameControl.mcArms = GameControl.MCArms.HUMAN;
			GameControl.mcLegs = GameControl.MCLegs.HUMAN; 
			GameControl.mcTailType = GameControl.MCTailType.NONE; 
			Debug.Log ("Set as human");
			//Board.text = "What is your physique? Note that this is weight related, next is an option to decide how defined your muscles are!"; 
	

		}

		if (raceSelector == 1) {
			GameControl.mcHead = GameControl.MCHead.BUNNY;
			GameControl.mcArms = GameControl.MCArms.BUNNY;
			GameControl.mcLegs = GameControl.MCLegs.BUNNY;
			GameControl.mcTailType = GameControl.MCTailType.Bunny; 
			GameControl.hasFur = true;

		}

		if (raceSelector == 2) {


			GameControl.mcHead = GameControl.MCHead.WOLF;
			GameControl.mcArms = GameControl.MCArms.WOLF;
			GameControl.mcLegs = GameControl.MCLegs.WOLF;
			GameControl.mcTailType = GameControl.MCTailType.Wolf; 
			GameControl.hasFur = true;
		}

		if (raceSelector == 3) {
			GameControl.mcHead = GameControl.MCHead.FELINE;
			GameControl.mcArms = GameControl.MCArms.FELINE;
			GameControl.mcLegs = GameControl.MCLegs.FELINE;
			GameControl.mcTailType = GameControl.MCTailType.Feline;
			GameControl.hasFur = true;
		}


	}
		







	// // Gender // // // //// // // //// // // //// // // //// // // //// // // //// // // //// // // //


	public void selectSex(){
		if 	(penisToggle.isOn == true) {
			GameControl.dickNum = 1;

		}
		if 	(penisToggle.isOn == false) {
			GameControl.dickNum = 0;

		}
		if (breastToggle.isOn == true) {
			GameControl.breast1Size = 5;
		}
		if (breastToggle.isOn == false) {
			GameControl.breast1Size = 0;
		}
		if (vaginaToggle.isOn == true) {
			GameControl.hasVagina = true;
		}
		if (vaginaToggle.isOn == false) {
			GameControl.hasVagina = false;
		}
		Debug.Log ("Dicknum is " + GameControl.dickNum);
		Debug.Log ("breast size is " + GameControl.breast1Size);
		Debug.Log ("has vagina is " + GameControl.hasVagina);

		charSettler.updateCharacter ();


	}

	void setSexCharacteristics()
	{
		
		if (penisToggle.isOn) {
			GameControl.dickNum = 1;
			GameControl.dick1Size = 14; 
			GameControl.dick1Thick = 4; 

		}

		if (vaginaToggle.isOn) {
			GameControl.hasVagina = true;
			if (GameControl.isVirgin == true) {
				GameControl.vagLooseStat = 0;
				GameControl.mcVagLooseness = GameControl.MCVagLooseness.virgin;
			} else {
				GameControl.vagLooseStat = 1;
				GameControl.mcVagLooseness = GameControl.MCVagLooseness.verythight;
			}

		}
			
		if(breastToggle.isOn){
			GameControl.breast1Size = 6.2f; 
			GameControl.mcBreast1Cup = GameControl.MCBreastCup.D;
			GameControl.mcBreast1Name = GameControl.MCBreastName.full;
		}
		if (TesticlesToggle.isOn) {
			GameControl.testiclesSize = 4; 
			GameControl.mcTesticlesName = GameControl.MCTesticleName.averageSize;

		}



	}




	public void disableTesticlesToggle(){
		if (penisToggle.isOn == false) {
			TesticlesToggle.isOn = false; 
			TesticlesToggle.interactable = false; 
		} else {
			TesticlesToggle.interactable = true; 
		}

	}


	public void selectGender(int selector){
		genderSelector = selector;
		if (genderSelector == 0) {
			Board.text = "You selected very masculine! Your character behavior will be more masculine, and will have more masculine facial and body features. NOTE: Your sex may change from \"Trap\" to \"Man\" or \"Woman\" to \"Cuntboy\" (depending if you have breasts) once the game starts. ";
		}

		if (genderSelector == 1) {
			Board.text = "You selected masculine! Your character behavior will be more masculine, and will have more masculine facial and body features.  NOTE: Your sex may change from \"Trap\" to \"Man\" or from woman to \"cuntboy\"(depending if you have breasts) once the game starts. ";
				
		}

		if (genderSelector == 2) 
		{
			Board.text = "You selected very androgynous! Your character behavior will be more neutral, and will have more ambiguous facial and body features. NOTE: Your sex may be adjusted once the game starts. For now androgynous characters are defined by their sex, so you will defined as a man if you only have a dick or as a woman if you only have a vagina. ";
				
		}

		if (genderSelector == 3) {
			Board.text = "You selected feminine! Your character behavior will be more feminine, and will have more feminine facial and body features. NOTE: Your sex may change from \"Man\" to  \"Trap\" or from \"Cuntboy\" to \"Woman\" (depending if you have breasts) once the game starts. ";
				
		}

		if (genderSelector == 4) {
			Board.text = "You selected very feminine! Your character behavior will be more feminine, and will have more feminine facial and body features. NOTE: Your sex may change from \"Man\" to  \"Trap\" or from \"Cuntboy\" to \"Woman\" (depending if you have breasts) once the game starts.  ";

		}
	}

	public void setGender(){
		if (genderSelector == 0) {
			GameControl.facialFeaturesStat -= 30; 
			GameControl.bodyFeaturesStat -= 30;
			GameControl.genderBehaviorStat -= 30; 
		}

		if (genderSelector == 1) {
			GameControl.facialFeaturesStat -= 15; 
			GameControl.bodyFeaturesStat -= 15;
			GameControl.genderBehaviorStat -= 15; 
		}

		if (genderSelector == 2) 
		{
			GameControl.facialFeaturesStat = 50; 
			GameControl.bodyFeaturesStat = 50;

			if (GameControl.genderBehaviorStat > 50) {
				GameControl.genderBehaviorStat -= 5; 
			} else if (GameControl.genderBehaviorStat < 50) {
				GameControl.genderBehaviorStat += 5; 
			}
		}

		if (genderSelector == 3) {
			GameControl.facialFeaturesStat += 15; 
			GameControl.bodyFeaturesStat += 15;
			GameControl.genderBehaviorStat += 15; 
		}

		if (genderSelector == 4) {
			GameControl.facialFeaturesStat += 30; 
			GameControl.bodyFeaturesStat += 30;
			GameControl.genderBehaviorStat += 30; 
		}

	}


	// // skin // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //
	public void setSkin(int selector)
	{
		if (selector == 0) {
			GameControl.mcSkinColor = GameControl.MCSkinColor.paleWhite;
			Board.text = "Your skin will be pale white!";
		}

		if (selector == 1) {
			GameControl.mcSkinColor = GameControl.MCSkinColor.fair;
			Board.text = "Your skin will be fair!";
		}

		if (selector == 2) {
			GameControl.mcSkinColor = GameControl.MCSkinColor.olive;
			Board.text = "Your skin will be olive!";
		}

		if (selector == 3) {
			GameControl.mcSkinColor = GameControl.MCSkinColor.dark;
			Board.text = "Your skin will be dark!";
		}
		if (selector == 4) {
			GameControl.mcSkinColor = GameControl.MCSkinColor.ebony;
			Board.text = "Your skin will be ebony!";
		}
		if (selector == 5) {
			GameControl.mcSkinColor = GameControl.MCSkinColor.darkBrown;
			Board.text = "Your skin will be dark brown!";
		}
		if (selector == 6) {
			GameControl.mcSkinColor = GameControl.MCSkinColor.russet;
			Board.text = "Your skin will be russet!";
		}

	}



	// // set physique // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //

	public void selectPhysique(int selector){
		physiqueSelector = selector;

		if (physiqueSelector == 0) {
			Board.text = "Your physique is thin! You will have a very small ass, slim hips and waist.";
		}

		if (physiqueSelector == 1) {
			Board.text = "Your physique is average! You will have an average ass, hips and waist.";
		}
		if (physiqueSelector == 2) {
			Board.text = "Your physique is curvy! You will have an ample ass, large hips and waist.";
		}
		if (physiqueSelector == 3) {
			Board.text = "Your physique is chubby! You will have a big ass, hips and waist.";
		}


	}

	void setPhysique(){
		if (physiqueSelector == 0) {
			GameControl.physiqueStat = 2.2f; 
			GameControl.hipsSize = 2.2f; 
			GameControl.waistSize = 2.2f; 
			GameControl.assSize = 2.2f; 

		}

		if (physiqueSelector == 1) {
			GameControl.physiqueStat = 4.2f; 
			GameControl.hipsSize = 4.2f; 
			GameControl.waistSize = 4.2f; 
			GameControl.assSize = 4.2f; 

		}

		if (physiqueSelector == 2) {
			GameControl.physiqueStat = 5.2f; 
			GameControl.hipsSize = 5.2f; 
			GameControl.waistSize = 5.2f; 
			GameControl.assSize = 5.2f; 

		}

		if (physiqueSelector == 3) {
			GameControl.physiqueStat = 7.2f; 
			GameControl.hipsSize = 7.2f; 
			GameControl.waistSize = 7.2f; 
			GameControl.assSize = 7.2f; 

		}


	}


	// // Build  // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // 

	public void selectBuild (int selector){
		buildSelector = selector;

		if (buildSelector == 0) {
			Board.text = "You will have a feeble build!";
		}

		if (buildSelector == 1) {
			Board.text = "You will have an average build!";
		}

		if (buildSelector == 2) {
			Board.text = "You will have an athletic build!";
		}

		if (buildSelector == 3) {
			Board.text = "You will have a muscular build!";
		}
	}



	void setBuild(){
		if (buildSelector == 0) {
			GameControl.buildStat = 1.2f; 
		}

		if (buildSelector == 1) {
			GameControl.buildStat = 3.2f; 
		}


		if (buildSelector == 2) {
			GameControl.buildStat = 5.2f; 
		}

		if (buildSelector == 3) {
			GameControl.buildStat = 7.2f; 
		}

	}

	public void setEyes (int selector){
		if (selector == 0) {
			GameControl.mcEyesColor = GameControl.MCEyesColor.darkBrown;
			Board.text = "Your eyes will be dark brown.";
		}
		if (selector == 1) {
			GameControl.mcEyesColor = GameControl.MCEyesColor.black;
			Board.text = "Your eyes will be black.";
		}
		if (selector == 2) {
			GameControl.mcEyesColor = GameControl.MCEyesColor.blue;
			Board.text = "Your eyes will be blue.";
		}
		if (selector == 3) {
			GameControl.mcEyesColor = GameControl.MCEyesColor.green;
			Board.text = "Your eyes will be green.";
		}
		if (selector == 4) {
			GameControl.mcEyesColor = GameControl.MCEyesColor.hazel;
			Board.text = "Your eyes will be hazel.";
		}
		if (selector == 5) {
			GameControl.mcEyesColor = GameControl.MCEyesColor.gray;
			Board.text = "Your eyes will be gray.";
		}
		if (selector == 6) {
			GameControl.mcEyesColor = GameControl.MCEyesColor.amber;
			Board.text = "Your eyes will be amber.";
		}


	}

	void selectClass(){
		switch(classSelector){
		case 0:
			GameControl.MCClass = NPCData.CharClass.Soldier;
			GameControl.MCAttacks.Add (NPCData.CharAttacks.PrecisionStrike);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.HoldLine);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.CombatManuevers);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.ReachingAttack);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.Bash);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.PocketSand);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.BodyShowoff);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.Fondling);
			GameControl.coreSkillMartial += 5;
			GameControl.coreSkillTactics += 5;
			GameControl.attPhysical += 5;
			break;
		case 1:
			GameControl.MCClass = NPCData.CharClass.Warrior;
			GameControl.MCAttacks.Add (NPCData.CharAttacks.BreakShield);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.Charge);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.WarCry);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.Disarm);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.Slash);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.HardBlow);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.SeductiveGesture);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.Fondling);
			GameControl.coreSkillMartial += 5;
			GameControl.coreSkillTactics += 5;
			GameControl.attPhysical += 5;
			break;
		case 2:
			GameControl.MCClass = NPCData.CharClass.Barbarian;
			GameControl.MCAttacks.Add (NPCData.CharAttacks.RecklessCharge);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.MercilessAttack);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.BleedingSwipe);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.Taunt);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.Bash);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.Slash);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.HardBlow);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.LoudSlap);
			GameControl.coreSkillMartial += 8;
			GameControl.attPhysical += 7;
			break;
		case 3:
			GameControl.MCClass = NPCData.CharClass.Alchemist;
			GameControl.MCAttacks.Add (NPCData.CharAttacks.HulkingPotion);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.ArousingFumes);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.DebilitatingFumes);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.PoisonDarts);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.Bash);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.TakeCover);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.BodyShowoff);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.SeductiveGesture);
			GameControl.utilitySkillAlchemy += 5;
			GameControl.coreSkillTactics += 5;
			GameControl.attMental += 5;
			break;
		case 4:
			GameControl.MCClass = NPCData.CharClass.Thief;
			GameControl.MCAttacks.Add (NPCData.CharAttacks.SmokeBombs);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.ConcussiveStrike);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.FoulPlay);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.PoisonDagger);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.Bash);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.PocketSand);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.TakeCover);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.Disarm);
			GameControl.coreSkillTactics += 8;
			GameControl.attPhysical += 7;
			break;
		case 5:
			GameControl.MCClass = NPCData.CharClass.Feral;
			GameControl.MCAttacks.Add (NPCData.CharAttacks.FeralCry);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.PinDown);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.InescapableGrab);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.DominantPresence);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.Bash);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.HardBlow);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.Fondling);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.SeductiveGesture);
			GameControl.attSocial += 7;
			GameControl.attPhysical += 7;
			break;
		case 6:
			GameControl.MCClass = NPCData.CharClass.Ranger;
			GameControl.MCAttacks.Add (NPCData.CharAttacks.TakeAim);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.Headshot);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.DoubleShot);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.SupressingFire);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.LoudSlap);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.TakeCover);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.PocketSand);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.HardBlow);
			GameControl.coreSkillMartial += 5;
			GameControl.coreSkillTactics += 5;
			GameControl.attPhysical += 5;
			break;
		case 7:
			GameControl.MCClass = NPCData.CharClass.Inquisitor;
			GameControl.MCAttacks.Add (NPCData.CharAttacks.LitanyOfPain);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.ImplacableSermon);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.Scourge);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.IronResolve);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.LoudSlap);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.HardBlow);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.Fondling);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.Slash);
			GameControl.coreSkillPersuasion+= 8;
			GameControl.attPhysical += 7;
			break;
		case 8:
			GameControl.MCClass = NPCData.CharClass.Whore;
			GameControl.MCAttacks.Add (NPCData.CharAttacks.Striptease);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.CrotchGrab);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.ForcedKissing);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.IndecentSmile);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.LoudSlap);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.SeductiveGesture);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.Fondling);
			GameControl.MCAttacks.Add (NPCData.CharAttacks.BodyShowoff);
			GameControl.coreSkillPersuasion += 10;
			GameControl.attSocial+= 7;
			break;
		default:
			break;
		}

	}

	public void setClass(int selector){

		classSelector = selector; 
		switch (selector) {
		case 0:
			//Soldier
			Board.text = "You have been trained to be a soldier, to be disciplined in combat and use any tactical advantage at your disposal. The soldier class has these skills available to them (make sure to scroll down to see the whole list): \n\n "
				+ "Precision strike: A balanced attack that has high critical damage.\n"
				+ "Hold the Line: A defensive buff, increasing your defense significantly at the cost of some of your physical attack.\n"
				+ "Combat manuevers: This skill will reduce enemy dodge and its defense, increasing your chances to do a critical hit.\n"
				+ "Reaching attack: A weak attack that enhances your defense and dodge.\n"
				+ "Bash: A regular attack with good accuracy.\n"
				+ "Pocket sand: An attack that reduces your enemy physical attack significantly.\n"
				+ "Body showoff: This movement will slighly increase the arousal of your opponent, and leaving it more susceptible to further suggestive attacks.\n"
				+ "Fondling: This movement increase a lot the arousal of your opponent, but its hard to connect unless its dodge is low."
				+ "\n\nYou martial and tactics skills, along with your physical stat will also be improved."
				;
			break;
		case 1:
			//Warrior
			Board.text = "You have been trained to be a warrior, to be fierce in combat and use your martial skills to take down any dueling enemy. The warrior class has these skills available to them (make sure to scroll down to see the whole list): \n\n "
				+ "Break shield: A powerful attack with low accuracy, but that it reduces enemy defense significantly if it connects.\n"
				+ "Charge: Although the attack doesn't do as much damage, it has high accuracy and it will reduce the dodge attribute of your opponent for a few turns.\n"
				+ "Warcry: This warcry will increase your attack, heal you and reduce your arousal, but will reduce your defense and dodge for a few turns.\n"
				+ "Disarm: A weak attack with low accuracy, but that reduces enemy attack significantly if it connects.\n"
				+ "Slash: A high damage attack, but with low accuracy.\n"
				+ "Hard blow: Moderate damage and accuracy, but reduces enemy dodge.\n"
				+ "Seductive gesture: This movement will make your arousing movements more effective against your opponent.\n"
				+ "Fondling: This movement increase a lot the arousal of your opponent, but its hard to connect unless its dodge is low.\n"
				+ "\n\nYou martial and tactics skills, your and physical stat will also be improved."
				;
			break;
		case 2:
			//Barbarian
			Board.text = "You used your strenght and phyisical prowess to survive the harsh times, being brutal in combat to overcome your opponents. The barbarian class has these skills available to them  (make sure to scroll down to see the whole list): \n\n "
				+ "Reckless charge: A high damage attack with low accuracy, that reduces enemy defenses if it hits.\n"
				+ "Merciless attack: A high accuracy attack that reduces the dodge of your opponent.\n"
				+ "Bleeding swipe: An attack with low accuracy and damage, but that leaves the enemy bleeding, reducing its health for several turns and reducing its dodge.\n"
				+ "Taunt: A movement that reduces your opponent dodge and defenses, but increases its attack.\n"
				+ "Bash: A regular attack with good accuracy.\n"
				+ "Slash: A high damage attack, but with low accuracy.\n"
				+ "Hard blow: Moderate damage and accuracy, but reduces enemy dodge.\n"
				+ "Loud slap: A regular damage attack that stuns the enemy if it does critical damage.\n"
				+ "\n\nYou martial skill and physical stat will also be improved."

				;
			break;
		case 3:
			//Alchemist
			Board.text = "You've been learning the science behind alchemy for years, now you have some tricks under you sleeve to defend yourself (make sure to scroll down to see the whole list): \n\n "
				+ "Hulking potion: Significantly increases your damage and physical resistance, but makes you weaker against seductive attacks.\n"
				+ "Arousing fumes: An improvised grenade that will increase the arousal of your enemy for several turns, and reducing its resistance against seductive movements.\n"
				+ "Debilitating fumes: Reduce your enemy defense, attack and dodge for several turns.\n"
				+ "Poison darts: Low damage and accuracy, but it will do damage for several turns afterwards.\n"
				+ "Bash: A regular attack with good accuracy.\n"
				+ "Take cover: Increases your dodge significantly, but reduces your attack significantly too.\n"
				+ "Body showoff: This movement will slighly increase the arousal of your opponent, and leaving it more susceptible to further suggestive attacks.\n"
				+ "Seductive gesture: This movement will make your arousing movements more effective against your opponent.\n"
				+ "\n\nYour alchemy and tactics skill, along with your mental stat will be improved."

				;
			break;
		case 4:
			//Thief
			Board.text = "You have survived the streets by being sneaky and cunning, disabling your opponent. These are the skills available to you (make sure to scroll down to see the whole list): \n\n "
				+ "Smoke bomb: Create a bomb screen that increases your dodge significantly.\n"
				+ "Concussive strike: Low accuracy and skill, but stuns your opponent if it critically hits.\n"
				+ "Foul play: A low accuracy attack that will reduce your opponent attack, defense and dodge.\n"
				+ "Poison dagger: A low damage attack that leaves your opponent poisoned for several turns, reducing its defense and health.\n"
				+ "Bash: A regular attack with good accuracy.\n"
				+ "Pocket sand: An attack that reduces your enemy physical attack significantly.\n"
				+ "Take cover: Increases your dodge significantly, but reduces your attack significantly too.\n"
				+ "Disarm: A weak attack with low accuracy, but that reduces enemy attack significantly if it connects.\n"
				+ "\n\nYour tactics and physical stat will be improved."

				;
			break;
		case 5:
			//Feral
			Board.text = "You have learned to fight like the beasts, using both physical attacks and seductive movements to take care of your enemies. These are the skills available to you (make sure to scroll down to see the whole list): \n\n "
				+ "Feral cry: This movement will reduce your enemy attack and dodge.\n"
				+ "Pin down: A mix of damage and arousal, will reduce your opponent resistance to seductive attacks and its dodge for few turns.\n"
				+ "Inescapable grab: Low accuracy attack that does a little damage, but increases your opponent arousal.\n"
				+ "Dominant presence: Increases your attacks and defenses, but reduces your dodge.\n"
				+ "Bash: A regular attack with good accuracy.\n"
				+ "Hard blow: Moderate damage and accuracy, but reduces enemy dodge.\n"
				+ "Fondling: This movement increase a lot the arousal of your opponent, but its hard to connect unless its dodge is low.\n"
				+ "Seductive gesture: This movement will make your arousing movements more effective against your opponent.\n"
				+ "\n\nYour social and physical stat will also be improved."

				;
			break;
		case 6:
			//Ranger
			Board.text = "You have learned to fight with precise, lethal strikes, and keeping your distance from your enemy. These are the skills available to you (make sure to scroll down to see the whole list): \n\n "
				+ "Take aim: Reduces enemy dodge significantly, but also reduces you defenses.\n"
				+ "Headshot: An skill with very low accuracy but good damage, with exceptional critical damage that also reduces enemy attack for several turns.\n"
				+ "Doubleshot: A regular attack with good accuracy, with high critical damage.\n"
				+ "Supressing fire: Although this attack does little damage, it reduces the enemy attack significantly.\n"
				+ "Loud slap: A regular damage attack that stuns the enemy if it does critical damage.\n"
				+ "Take cover: Increases your dodge significantly, but reduces your attack significantly too.\n"
				+ "Pocket sand: An attack that reduces your enemy physical attack significantly.\n"
				+ "Hard blow: Moderate damage and accuracy, but reduces enemy dodge.\n"
				+ "\n\nYour martial and tactics skill, along with your physical stat will be improved."

				;
			break;
		case 7:
			//Inquisitor
			Board.text = "You have learned to use the power of persuasion and your cunning to defeat your opponents. These are the skills available to you (make sure to scroll down to see the whole list): \n\n "
				+ "Litany of pain: A consistent attack that harms the will to fight of your opponents, reflected as damage.\n"
				+ "Implacable sermon: A speech that significantly reduces your enemy defenses.\n"
				+ "Scourge: A mix attack that has an inusual arousing property to it.\n"
				+ "Iron resolve: A buff that increases both of your defenses significantly, but will inflict you some arousal and damage.\n"
				+ "Loud slap: A regular damage attack that stuns the enemy if it does critical damage.\n"
				+ "Hard blow: Moderate damage and accuracy, but reduces enemy dodge.\n"
				+ "Fondling: This movement increase a lot the arousal of your opponent, but its hard to connect unless its dodge is low.\n"
				+ "Slash: A high damage attack, but with low accuracy.\n"
				+ "\n\nYour persuasion skill, along with your social stat will also be improved."

				;
			break;
		case 8:
			//Whore
			Board.text = "You have learned to survive using less conventional fighting methods. These are the skills available to you (make sure to scroll down to see the whole list): \n "
				+ "Striptease: An effective seductive attack that'll increase your arousal a little bit and reduce your defense.\n"
				+ "Crotch grab: A movement that has low accuracy, but increases enemy arousal significantly and reduce its defense.\n"
				+ "Forced kissing: Although an effective move, it also increases you arousal significantly when used.\n"
				+ "Indecent smile: This move will reduce your opponents defenses significantly, leaving them more open to your other technics..\n"
				+ "Loud slap: A regular damage attack that stuns the enemy if it does critical damage.\n"
				+ "Seductive gesture: This movement will make your arousing movements more effective against your opponent.\n"
				+ "Fondling: This movement increase a lot the arousal of your opponent, but its hard to connect unless its dodge is low.\n"
				+ "Body showoff: This movement will slighly increase the arousal of your opponent, and leaving it more susceptible to further suggestive attacks.\n"
				+ "\n\nYour persuasive skill and social stat will also be improved."
				;
			break;
		}


	}


	public void setHairColor(int selector){
		if (selector == 0) {
			GameControl.mcHairColor = GameControl.MCHairColor.black;
			Board.text = "Your hair colour will be black!";
		}
		if (selector == 1) {
			GameControl.mcHairColor = GameControl.MCHairColor.brown;
			Board.text = "Your hair colour will be brown!";
		}
		if (selector == 2) {
			GameControl.mcHairColor = GameControl.MCHairColor.blonde;
			Board.text = "Your hair colour will be blonde!";
		}
		if (selector == 3) {
			GameControl.mcHairColor = GameControl.MCHairColor.auburn;
			Board.text = "Your hair colour will be auburn!";
		}
		if (selector == 4) {
			GameControl.mcHairColor = GameControl.MCHairColor.chesnut;
			Board.text = "Your hair colour will be chestnut!";
		}
		if (selector == 5) {
			GameControl.mcHairColor = GameControl.MCHairColor.platinum;
			Board.text = "Your hair colour will be platinum!";
		}
		if (selector == 6) {
			GameControl.mcHairColor = GameControl.MCHairColor.white;
			Board.text = "Your hair colour will be white!";
		}

	}


	public void finishCreation(){
		setBuild ();
		setPhysique ();
		setGender ();
		setSexCharacteristics ();
		setName ();
		setRace ();
		charSettler.updateCharacter ();
		selectClass ();
	}
		


	void Update () {
		settleName ();
		disableTesticlesToggle ();

	}
}
