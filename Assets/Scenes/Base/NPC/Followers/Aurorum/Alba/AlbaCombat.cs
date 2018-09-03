using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AlbaCombat : MonoBehaviour {
	public Text Board; 

	static int confirmationControl; 

	public Canvas endTurnPanel; 

	public Canvas panConfirmation;


	public Text option0Name;
	public Text option1Name;




	static int confirmationNegotiationControl; 

	public Canvas panNegotiation;
	public Canvas panCombat;


	public Text optionNeg0Name;
	public Text optionNeg1Name;
	public Text optionNeg2Name;

	public Button optionNeg1Butt; 
	public Button optionNeg2Butt; 

	void sceneStart(){
		if (QuestControl.albaHelp) {
			panCombat.sortingOrder = 500;
			confirmationControl = 0;
			option0Name.text = "Enslave";
			option1Name.text = "Put down";

		} else {
			panNegotiation.sortingOrder = 700; 
			panCombat.sortingOrder = -500;
			confirmationControl = 100;
			optionNeg0Name.text = "Fight them!";
			optionNeg1Name.text = "Titles";
			optionNeg2Name.text = "Gold (100)";
			if (GameControl.charGold < 100) {
				optionNeg2Butt.interactable = false; 
			}

		}



	}


	public void confirmFun(int selector){

		///////////////////////////// Enslave / put down

		if (selector == 0 && confirmationControl == 0) {
			Board.text = "You agree with Alba. She could make a very productive slave, which is definitely something that’s needed these days. <i>“I’m glad that you agree "+GameControl.playerName+", it would be a waste otherwise. You heard the order boys, restrain her and take her back to the city.”</i>\n\nAlba congratulates you for the success. <i>“Things will all run smoothly soon. With the mines in our hands, we’ll be able to start producing once again. I’ve got to get back to town, but this is not done yet. We still need to decide how I will conduct business from now on. There are many details to discuss, and I’m sure you are tired from the battle, so let’s head back.Just come to my place once you are ready to talk.”</i>\n";

			NPCCharList.CharRetainers.Add (NPCCharList.CharMonster [0]);
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].isRecruited = true; 
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].isSlave = true;

			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].cityJobs = NPCData.Jobs.CastleRest;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].attHappiness = 75;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charRank = NPCData.CharRank.S;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].coreSkillMartial = Random.Range(65,100);
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].attPhysical = Random.Range (80, 100);

			fileRulesNPC npcrules = new fileRulesNPC();
			RulesNPC.savedRules.Add (npcrules);
			RulesNPC.savedRules [RulesNPC.savedRules.Count-1].id = NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charID; 
			RulesNPC.savedRules [RulesNPC.savedRules.Count-1].idx = NPCCharList.CharRetainers.Count - 1;


			QuestControl.albaQuest = 3;
			QuestsController.RemoveID (13002);
			Quest AlbaQuest4 = new Quest(); 

			QuestsController.createQuest (AlbaQuest4, "Forging the future", "Alba wants you to see her new plans for her district, and ask your opinion about it.", 59, 13003);
			endTurnFun ();
			 

			return;
		}

		if (selector == 1 && confirmationControl == 0) {
			Board.text = "You can’t risk having a beast like this in the city, especially if there’s any chance that you could lose control of it. You command the soldiers to take her out, and they act immediately. The girl screams for a moment, but her pain ends quickly. <i>“Awww, that’s such a waste "+GameControl.playerName+". Come on boys, let’s go back to the city.”</i>\n\nAlba congratulates you for the success. <i>“Things will all run smoothly soon. With the mines in our hands, we’ll be able to start producing once again. I’ve got to get back to town, but this is not done yet. We still need to decide how I will conduct business from now on. There are many details to discuss, and I’m sure you are tired from the battle, so let’s head back.Just come to my place once you are ready to talk.”</i>";

			QuestControl.albaQuest = 3;
			QuestsController.RemoveID (13002);
			Quest AlbaQuest4 = new Quest(); 
			QuestsController.createQuest (AlbaQuest4, "Forging the future", "Alba wants you to see her new plans for her district, and ask your opinion about it.", 59, 13003);
			endTurnFun ();
			 

			return;
		}

		///////////////////////////// Fight / Titles / Gold

		if (selector == 0 && confirmationControl == 100) {
			Board.text = "You reject her proposal and ready your weapon. <i>“So be it! Get ready then!”</i> she leaps at you with her weapon in hand, and you manage to parry her first strike. <i>“Let’s see how strong you are!”</i>";
			panCombat.sortingOrder = 500;
			panNegotiation.sortingOrder = -500;
			confirmationControl = 101;
			option0Name.text = "Kill her";
			option1Name.text = "Enslave her";
			return;
		}

		if (selector == 1 && confirmationControl == 100) {
			Board.text = "<i>“Smart choice. Now come on boys, take your things and let’s join them.”</i> Your soldiers and theirs all sheathe their weapons, and the brigands start to gather up what little belongings they have. <i>“"+GameControl.playerName+" right? I’m glad you accepted us into your ranks. We have experience dealing with beasts, and know this forest like the palm of our hands. We’ll be pretty useful to you.”</i> You begin explaining to her what her new duties will entail, when Alba interrupts you. \n\n<i>“"+GameControl.playerName+"?! What are you doing? You were supposed to be fighting them, not having a friendly chat!”</i> You quickly calm her down, and explain to her what you are doing. <i>“Taking them under your protection? Are you crazy? These people have been robbing our population for years, the city is going to hate you for this!”</i> You tell her that things are changing, and that everybody should be allowed a second chance.\n\n<i>“It’s not like these guys haven’t had many second chances already. Fine, do as you wish. You’ll be the one to deal with the consequences though, I won’t accept responsibility for anything they do.”</i> You nod, and she leaves furiously. \n\n<i>“Such a feisty girl... maybe we should take care of her first.”</i> You shake your head, knowing that it would be the end of the both of you. <i>“Fine, I’ll play by the rules... for now.”</i> She turns around and begins to organize her group. After a moment, you start to wonder whether you made the right choice or not. \n";
			QuestsController.RemoveID (13001);
			Quest AlbaQuest3 = new Quest(); 
			QuestsController.createQuest (AlbaQuest3, "Riots", "Your new recruits are causing mayhem on the city, and people is discontet with it! You need to deal with them, one way or the other.", 59, 13002);
			QuestControl.albaQuest = 2;
			NPCCharList.CharRetainers.Add (NPCCharList.CharMonster [0]);
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].isRecruited = true;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].isSlave = false;

			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].cityJobs = NPCData.Jobs.CastleGuard;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].attHappiness = 85;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charRank = NPCData.CharRank.S;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].coreSkillMartial = Random.Range(65,100);
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].attPhysical = Random.Range (60, 85);

			fileRulesNPC npcrules = new fileRulesNPC();
			RulesNPC.savedRules.Add (npcrules);
			RulesNPC.savedRules [RulesNPC.savedRules.Count-1].id = NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charID; 
			RulesNPC.savedRules [RulesNPC.savedRules.Count-1].idx = NPCCharList.CharRetainers.Count - 1;

			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charID = 1000100;


			NPCCharList.CharRetainers[NPCCharList.CharRetainers.Count-1].charTitles.Add(new Gentlewoman());
			endTurnFun ();
			 

			return;
		}

		if (selector == 2 && confirmationControl == 100) {
			Board.text = "<i>“Smart choice. Now come on boys, take your things and let’s join them.”</i> Your soldiers and theirs all sheathe their weapons, and the brigands start to gather up what little belongings they have. <i>“"+GameControl.playerName+" right? I’m glad you accepted us into your ranks. We have experience dealing with beasts, and know this forest like the palm of our hands. We’ll be pretty useful to you.”</i> You begin explaining to her what her new duties will entail, when Alba interrupts you. \n\n<i>“"+GameControl.playerName+"?! What are you doing? You were supposed to be fighting them, not having a friendly chat!”</i> You quickly calm her down, and explain to her what you are doing. <i>“Taking them under your protection? Are you crazy? These people have been robbing our population for years, the city is going to hate you for this!”</i> You tell her that things are changing, and that everybody should be allowed a second chance.\n\n<i>“It’s not like these guys haven’t had many second chances already. Fine, do as you wish. You’ll be the one to deal with the consequences though, I won’t accept responsibility for anything they do.”</i> You nod, and she leaves furiously. \n\n<i>“Such a feisty girl... maybe we should take care of her first.”</i> You shake your head, knowing that it would be the end of the both of you. <i>“Fine, I’ll play by the rules... for now.”</i> She turns around and begins to organize her group. After a moment, you start to wonder whether you made the right choice or not. \n";
			QuestsController.RemoveID (13001);
			Quest AlbaQuest3 = new Quest(); 
			QuestsController.createQuest (AlbaQuest3, "Riots", "Your new recruits are causing mayhem on the city, and people is discontet with it! You need to deal with them, one way or the other.", 59, 13002);
			QuestControl.albaQuest = 2;
			NPCCharList.CharRetainers.Add (NPCCharList.CharMonster [0]);
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].isRecruited = true; 

			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].cityJobs = NPCData.Jobs.CastleGuard;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].attHappiness = 85;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charRank = NPCData.CharRank.S;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].coreSkillMartial = Random.Range(65,100);
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].attPhysical = Random.Range (60, 85);

			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charID = 1000100;

			endTurnFun ();
			GameControl.charGold -= 100;

			return;
		}


		///////////////////////////// kill / enslave

		if (selector == 0 && confirmationControl == 101) {
			Board.text = "You can’t take the risk of having a bandit like her in the city, especially with the potential for rebellion. You command the soldiers to take her out, and they act immediately. The girl screams for a moment, but her pain ends quickly. <i>“Excellent choice "+GameControl.playerName+". We are done here. Come on boys, take what you can and let’s head back to the city.”</i>\n\nOn your way back, she congratulates you. <i>“You took care of the problem very quickly, so we should be able to start producing very soon. When you are ready, just come and visit me at my house. There is one more issue to discuss, but in the meantime, I’m going to start organizing my part of the city.”</i>\n\nYou thank her for her support in the mines. <i>“Don’t worry, this is just business. There’s no sense in leaving you alone when I need you to succeed.”</i> \n\nOnce back at the city, she bows to you, and the two of you part ways.\n";
			QuestControl.albaQuest = 3;
			QuestsController.RemoveID (13001);
			Quest AlbaQuest4 = new Quest(); 
			QuestsController.createQuest (AlbaQuest4, "Forging the future", "Alba wants you to see her new plans for her district, and ask your opinion about it.", 59, 13003);
			endTurnFun ();
			 
			return;
		}

		if (selector == 1 && confirmationControl == 101) {
			Board.text = "You believe that she will be more useful to you alive than dead, and command your guards to restrain her and get her ready to take home. <i>“Thank you "+GameControl.playerName+"! You won’t regret this!”</i> The thief thanks you, but you dismiss her words with a curt hand gesture.  \n\n <i>“It looks like we are done here, I just hope you can deal with her "+GameControl.playerName+". Come on boys, take what you can and let’s get back to the city.”</i>\n\nOn your way back, she congratulates you. <i>“You took care of the problem very quickly, so we should be able to start producing very soon. When you are ready, just come and visit me at my house. There is one more issue to discuss, but in the meantime, I’m going to start organizing my part of the city.”</i>\n\nYou thank her for her support in the mines. <i>“Don’t worry, this is just business. There’s no sense in leaving you alone when I need you to succeed.”</i> \n\nOnce back at the city, she bows to you, and the two of you part ways.\n";
			QuestControl.albaQuest = 3;
			QuestsController.RemoveID (13001);
			Quest AlbaQuest4 = new Quest(); 
			QuestsController.createQuest (AlbaQuest4, "Forging the future", "Alba wants you to see her new plans for her district, and ask your opinion about it.", 59, 13003);
			NPCCharList.CharRetainers.Add (NPCCharList.CharMonster [0]);
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].isRecruited = true; 

			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].isSlave = true;

			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].cityJobs = NPCData.Jobs.CastleRest;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].attHappiness = 65;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].charRank = NPCData.CharRank.S;
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].coreSkillMartial = Random.Range(65,100);
			NPCCharList.CharRetainers [NPCCharList.CharRetainers.Count - 1].attPhysical = Random.Range (60, 85);


			endTurnFun ();
			 

			return;
		}


		///////////////////////////// temp

		if (selector == 0 && confirmationControl == 9999) {
			Board.text = "";
			return;
		}

		if (selector == 1 && confirmationControl == 9999) {
			Board.text = "";
			return;
		}

	}




	void endTurnFun(){
		//panContinue.sortingOrder = -500;
		panConfirmation.sortingOrder = -500;
		panCombat.sortingOrder = -500;
		panNegotiation.sortingOrder = -500;
		PanLeftManagement.endTurnControl = true; 
		endTurnPanel.sortingOrder = 500;


	}


	void Start(){
		sceneStart ();


	}


}
