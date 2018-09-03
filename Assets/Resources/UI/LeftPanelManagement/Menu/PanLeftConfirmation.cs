using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PanLeftConfirmation : MonoBehaviour {

	public Animator panConfirmation; 


	QuitApplication quitApp = new QuitApplication();
	SaveInformation saveInformation = new SaveInformation();
	LoadInformation loadInformation = new LoadInformation();
	AddItemScript addItem = new AddItemScript();
	CharacteristicsSettler charSettler = new CharacteristicsSettler();
	SetEquipment setEquip = new SetEquipment();

	static int conSelector; // used to select the case 

	public void noSelection(){
		panConfirmation.SetBool ("isDisplayed", false);

	}


	// used only to bring the panel, it also decides the case to execute
	public void callConfirmation(int selector){

		panConfirmation.SetBool ("isDisplayed", true);
		conSelector = selector; 


	}




	public void callConfirmationUnequip(){
		if (LeftPanelEquipmentLoad.invFull == true) {

		} else {
			
			panConfirmation.SetBool ("isDisplayed", true);
			conSelector = 4; 

		}


	}

	public void callConfirmationThrow(int selector){

		if (GameControl.invSlotArray [LeftPanelInventoryItemUse.itemSelect, 0] == 0) {

		} else {
			panConfirmation.SetBool ("isDisplayed", true);
			conSelector = selector; 
		}

	}



	public void yesSelection()
	{

		if (conSelector == 0) {
			quitApp.Quit ();
		}

		// Save file 
		if (conSelector == 1) {
			panConfirmation.SetBool ("isDisplayed", false);
			saveInformation.saveGame (PanLeftSave.saveSelection);

		}

		if (conSelector == 2) {
			panConfirmation.SetBool ("isDisplayed", false);
			loadInformation.loadGame (PanLeftSave.loadSelection);
		}

		if (conSelector == 3) {
			// throwing items

				GameControl.invSlotArray [LeftPanelInventoryItemUse.itemSelect, 0] = 0; 
				GameControl.invSlotArray [LeftPanelInventoryItemUse.itemSelect, 1] = 0; 
				panConfirmation.SetBool ("isDisplayed", false);

		}

		if (conSelector == 4) {
			// unequip items

			addItem.addItemScript ();
			GameControl.charEquipment[LeftPanelEquipmentLoad.itemSelection] = 0; 
			charSettler.setWeapon ();
			charSettler.setArmour ();
			charSettler.setHeadEquip ();
			charSettler.setFaceEquip ();
			charSettler.setNeckEquip ();
			charSettler.setShouldersEquip ();
			charSettler.setArmsEquip ();
			charSettler.setLegsEquip ();
			charSettler.setMakeUpEquip ();
			setEquip.setEquipModifiers ();

		
			panConfirmation.SetBool ("isDisplayed", false);

		}






	}




}
