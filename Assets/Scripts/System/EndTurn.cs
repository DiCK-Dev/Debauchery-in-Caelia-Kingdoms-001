using UnityEngine;
using UnityEngine.SceneManagement; 
using System.Collections;

public class EndTurn : MonoBehaviour {
	CharacteristicsSettler charSettler = new CharacteristicsSettler ();

	GenNPCEndTurn genNPCendturn = new GenNPCEndTurn();
	CreateHireableWorkers createWorks = new CreateHireableWorkers ();
	cityUpdatesEndTurn cityupdatesendturn = new cityUpdatesEndTurn();

	// Use this for initialization
	public void endTurn () {

		WorldControl.PortraitIDLayer0 = 0; 
		WorldControl.PortraitIDLayer1 = 0; 
		WorldControl.PortraitIDLayer2 = 0; 

		WorldControl.NPCID = 0;
		WorldControl.idx = -1;
		//Effects
		alwaysLustEffect();

		//






		WorldControl.dayTime++;
		if(WorldControl.dayTime > 5){
			WorldControl.day++;
			WorldControl.dayTime = 0; 
		}
		GameControl.actualHealth = GameControl.actualHealth + 40; 
		if (GameControl.actualHealth > GameControl.maxHealth) {
			GameControl.actualHealth = GameControl.maxHealth;
		}
		if (GameControl.actualHealth < 0) {
			GameControl.actualHealth = 40;
		}

		switch(WorldControl.dayTime)
		{
		case 0:
			WorldControl.dayTimeName = "Morning";
			break;

		case 1:
			WorldControl.dayTimeName = "Noon"; 
			break;
		case 2:
			WorldControl.dayTimeName = "Afternoon"; 
			break;
		case 3:
			WorldControl.dayTimeName = "Evening"; 
			break;
		case 4:
			WorldControl.dayTimeName = "Night"; 
			break;
		case 5:
			TurnSummary.dreamCD = 0; 
			createWorks.createNewWorkers ();

			WorldControl.dayTimeName = "Late night"; 
			if (CityControl.mandateSkimpyServitude == true) {
				CityControl.city100Corruption += 0.1f; 
			}

			if (CityControl.city100Corruption > 100) {
				CityControl.city100Corruption = 100; 
			}
			dailyChanges ();
			if (QuestControl.helenaQuest >= 5) {
				CastleUpdate.updateCastle (); 
			}
			CastleUpdate.updateCastle ();
			break;
		default:
			break;
		}


		cleanUnrecruitedRetainers ();





			
		SceneManager.LoadScene (3);
	
	}



	void dailyChanges(){

		////////////////GEN NPC
		//genNPCendturn.GenNPCCDRed();

		cityupdatesendturn.cityUpdater ();


		//hair
		/*if (GameControl.hairGrow == true) {
			GameControl.hairLength = GameControl.hairLength + 1; 
			charSettler.setHairLength ();
			//charSettler.setHairStyle ();
		}*/

		//beard 
		/*
		if (GameControl.beardGrow == true) {
			//GameControl.beardLength = GameControl.beardLength + 1;
			//charSettler.setBeard ();
		}*/
		// pregnancy 

		if (GameControl.isPregnant == true) 
		{
			GameControl.pregnantCounter = GameControl.pregnantCounter - 1; 
			if (GameControl.pregnantCounter <= 0) {
				GameControl.isPregnant = false; 
			}
		}

		// lactating 
		if(GameControl.lactating == true)
		{
			GameControl.lactatingTurns = GameControl.lactatingTurns - 1;
			if (GameControl.lactatingTurns <= 0) {
				GameControl.lactating = false; 
			}
		}

		//QUESTS 
		if (QuestControl.vivicaCounter > 0 && QuestControl.lucinaQuest >= 9) {
			QuestControl.vivicaCounter -= 1;
		}



	}


	void cleanUnrecruitedRetainers(){
		foreach (NPCData npcdata in NPCCharList.CharRetainers){
			if (npcdata.isRecruited == false && npcdata.isNeutral == false) {
				NPCCharList.CharRetainers.Remove (npcdata);
			}

		}
	}

	void alwaysLustEffect(){
		if (GameControl.statusEffect[0] == true && GameControl.actualArousal < 30) {
			GameControl.actualArousal = 30; 
		}

	}
	

}
