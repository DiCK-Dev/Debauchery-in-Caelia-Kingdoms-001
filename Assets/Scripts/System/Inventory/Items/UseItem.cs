using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class UseItem : MonoBehaviour {

	public Text itemUseText; 

	AddItemScript addItem = new AddItemScript ();

	ItemFunction itemFun = new ItemFunction();



	//////////////////////////////////////////////////////

	public void invItemUse(int selector)
	{


		if (GameControl.invSlotArray [selector, 0] > 10000) {


			WorldControl.dropItem = GameControl.invSlotArray [selector, 0];
			useItem ();
			GameControl.invSlotArray [selector, 0] = 0;

			if (WorldControl.wasEquiped == true) {
				WorldControl.dropItem = WorldControl.switchItem;
				addItem.addItemScript ();
				WorldControl.wasEquiped = false; 
			}

		} 
		else 
		{

			WorldControl.dropItem = GameControl.invSlotArray [selector, 0];
			useItem ();

			GameControl.invSlotArray [selector, 1] = GameControl.invSlotArray [selector, 1] - 1;
			if (GameControl.invSlotArray [selector, 1] <= 0) 
			{
				GameControl.invSlotArray [selector, 0] = 0; 
			}

		}



	}

	//////////////////////////////////////////////////////////////////////////////////////////




	public void invButt0()
	{
		Debug.Log (GameControl.charEquipment [2]);


		if (GameControl.invSlotArray [0, 0] > 10000) {


			WorldControl.dropItem = GameControl.invSlotArray [0, 0];
			useItem ();
			itemUseText.text = WorldControl.itemUseText; 
			GameControl.invSlotArray [0, 0] = 0;

			if (WorldControl.wasEquiped == true) {
				WorldControl.dropItem = WorldControl.switchItem;
				addItem.addItemScript ();
				WorldControl.wasEquiped = false; 
			}

		} 
		else 
		{

			WorldControl.dropItem = GameControl.invSlotArray [0, 0];
			useItem ();
			itemUseText.text = WorldControl.itemUseText; 
			GameControl.invSlotArray [0, 1] = GameControl.invSlotArray [0, 1] - 1;
			if (GameControl.invSlotArray [0, 1] <= 0) 
			{
				GameControl.invSlotArray [0, 0] = 0; 
			}

		}



	}

	public void invButt1()
	{



		if (GameControl.invSlotArray [1, 0] > 10000) {


			WorldControl.dropItem = GameControl.invSlotArray [1, 0];
			useItem ();
			itemUseText.text = WorldControl.itemUseText; 
			GameControl.invSlotArray [1, 0] = 0;

			if (WorldControl.wasEquiped == true) {
				WorldControl.dropItem = WorldControl.switchItem;
				addItem.addItemScript ();
				WorldControl.wasEquiped = false; 
			}

		} 
		else 
		{

			WorldControl.dropItem = GameControl.invSlotArray [1, 0];
			useItem ();
			itemUseText.text = WorldControl.itemUseText; 
			GameControl.invSlotArray [1, 1] = GameControl.invSlotArray [1, 1] - 1;
			if (GameControl.invSlotArray [1, 1] <= 0) 
			{
				GameControl.invSlotArray [1, 0] = 0; 
			}

		}


	}




	public void invButt2()
	{



		if (GameControl.invSlotArray [2, 0] > 10000) {


			WorldControl.dropItem = GameControl.invSlotArray [2, 0];
			useItem ();
			itemUseText.text = WorldControl.itemUseText; 
			GameControl.invSlotArray [2, 0] = 0;

			if (WorldControl.wasEquiped == true) {
				WorldControl.dropItem = WorldControl.switchItem;
				addItem.addItemScript ();
				WorldControl.wasEquiped = false; 
			}

		} 
		else 
		{

			WorldControl.dropItem = GameControl.invSlotArray [2, 0];
			useItem ();
			itemUseText.text = WorldControl.itemUseText; 
			GameControl.invSlotArray [2, 1] = GameControl.invSlotArray [2, 1] - 1;
			if (GameControl.invSlotArray [2, 1] <= 0) 
			{
				GameControl.invSlotArray [2, 0] = 0; 
			}

		}


	}


	public void invButt3()
	{



		if (GameControl.invSlotArray [3, 0] > 10000) {


			WorldControl.dropItem = GameControl.invSlotArray [3, 0];
			useItem ();
			itemUseText.text = WorldControl.itemUseText; 
			GameControl.invSlotArray [3, 0] = 0;

			if (WorldControl.wasEquiped == true) {
				WorldControl.dropItem = WorldControl.switchItem;
				addItem.addItemScript ();
				WorldControl.wasEquiped = false; 
			}

		} 
		else 
		{

			WorldControl.dropItem = GameControl.invSlotArray [3, 0];
			useItem ();
			itemUseText.text = WorldControl.itemUseText; 
			GameControl.invSlotArray [3, 1] = GameControl.invSlotArray [3, 1] - 1;
			if (GameControl.invSlotArray [3, 1] <= 0) 
			{
				GameControl.invSlotArray [3, 0] = 0; 
			}

		}


	}

	public void invButt4()
	{



		if (GameControl.invSlotArray [4, 0] > 10000) {


			WorldControl.dropItem = GameControl.invSlotArray [4, 0];
			useItem ();
			itemUseText.text = WorldControl.itemUseText; 
			GameControl.invSlotArray [4, 0] = 0;

			if (WorldControl.wasEquiped == true) {
				WorldControl.dropItem = WorldControl.switchItem;
				addItem.addItemScript ();
				WorldControl.wasEquiped = false; 
			}

		} 
		else 
		{

			WorldControl.dropItem = GameControl.invSlotArray [4, 0];
			useItem ();
			itemUseText.text = WorldControl.itemUseText; 
			GameControl.invSlotArray [4, 1] = GameControl.invSlotArray [4, 1] - 1;
			if (GameControl.invSlotArray [4, 1] <= 0) 
			{
				GameControl.invSlotArray [4, 0] = 0; 
			}

		}


	}













	void useItem()
	{
		switch (WorldControl.dropItem)
		{
		case 100:
			itemFun.udderMaxW ();
			break; 
		case 101:
			itemFun.udderMax ();
			break;
		case 102:
			itemFun.udderMaxS ();
			break; 
		case 105:
			itemFun.virilitaxW ();
			break; 
		case 106:
			itemFun.virilitax ();
			break; 
		case 107:
			itemFun.virilitaxS ();
			break; 
		case 110:
			itemFun.gallantryAleW ();
			break; 
		case 111:
			itemFun.gallantryAle ();
			break; 
		case 112:
			itemFun.gallantryAleS ();
			break; 
		case 115:
			itemFun.gigantusW ();
			break; 
		case 116:
			itemFun.gigantus ();
			break; 
		case 117:
			itemFun.gigantusS ();
			break; 
		case 120:
			itemFun.pigmyW ();
			break;
		case 121:
			itemFun.pigmy ();
			break;
		case 122:
			itemFun.pigmyS ();
			break;
		case 125:
			itemFun.deathBosomW ();
			break; 
		case 126:
			itemFun.deathBosom ();
			break; 
		case 127:
			itemFun.deathBosomS ();
			break; 
		case 130:
			itemFun.betaXW();
			break; 
		case 131:
			itemFun.betaX();
			break; 
		case 132:
			itemFun.betaXS();
			break; 
		case 135: 
			itemFun.nutcrackerAleW ();
			break;
		case 136: 
			itemFun.nutcrackerAle ();
			break;
		case 137: 
			itemFun.nutcrackerAleS ();
			break;
		case 140:
			itemFun.nutcrackerAleW ();
			break;
		case 141:
			itemFun.nutcrackerAle ();
			break;
		case 142:
			itemFun.nutcrackerAleS ();
			break;
		case 145: 
			itemFun.fertilityPill ();
			break;
		case 146: 
			itemFun.infertilityPill ();
			break;
		case 150: 
			itemFun.darkElixirW ();
			break;
		case 151: 
			itemFun.darkElixir ();
			break;
		case 152: 
			itemFun.darkElixirS ();
			break;
		case 155:
			itemFun.pureElixirW ();
			break;
		case 156:
			itemFun.pureElixir ();
			break;
		case 157:
			itemFun.pureElixirS ();
			break;
		case 160:
			itemFun.aphrodisiac ();
			break;
		case 165:
			itemFun.vagAway ();
			break;
		case 200:
			itemFun.giftUse (200);
			break;
		case 201:
			itemFun.giftUse (201);
			break;
		case 202:
			itemFun.giftUse (202);
			break;
		case 203:
			itemFun.giftUse (203);
			break;
		case 204:
			itemFun.giftUse (204);
			break;
		case 205:
			itemFun.giftUse (205);
			break;
		case 206:
			itemFun.giftUse (206);
			break;
		case 1000:
			itemFun.rabbitConct ();
			break;
		case 1001:
			itemFun.rabbitMud ();
			break;
		case 1002:
			itemFun.rabbitLotion ();
			break;
		case 1003:
			itemFun.rabbitOil ();
			break;
		case 1004:
			itemFun.rabbitDist ();
			break;
		case 1005:
			itemFun.wolfConct ();
			break;
		case 1006:
			itemFun.wolfMud ();
			break;
		case 1007:
			itemFun.wolfLotion ();
			break;
		case 1008:
			itemFun.wolfOil ();
			break;
		case 1009:
			itemFun.wolfDist ();
			break;
		case 1010:
			itemFun.plantConct ();
			break;
		case 1011:
			itemFun.plantMud ();
			break;
		case 1012:
			itemFun.plantLotion ();
			break;
		case 1013:
			itemFun.plantOil ();
			break;
		case 1014:
			itemFun.plantDist ();
			break;
		case 1015:
			itemFun.felineConct ();
			break;
		case 1016:
			itemFun.felineMud ();
			break;
		case 1017:
			itemFun.felineLotion ();
			break;
		case 1018:
			itemFun.felineOil ();
			break;
		case 1019:
			itemFun.felineDist ();
			break;
		case 1020:
			itemFun.equineConct ();
			break;
		case 1021:
			itemFun.equineMud ();
			break;
		case 1022:
			itemFun.equineLotion ();
			break;
		case 1023:
			itemFun.equineOil ();
			break;
		case 1024:
			itemFun.equineDist ();
			break;
		case 1025:
			itemFun.dodoConct ();
			break;
		case 1026:
			itemFun.dodoMud ();
			break;
		case 1027:
			itemFun.dodoLotion ();
			break;
		case 1028:
			itemFun.dodoOil ();
			break;
		case 1029:
			itemFun.dodoDist ();
			break;
		case 1030:
			itemFun.lizardConct ();
			break;
		case 1031:
			itemFun.lizardMud ();
			break;
		case 1032:
			itemFun.lizardLotion ();
			break;
		case 1033:
			itemFun.lizardOil ();
			break;
		case 1034:
			itemFun.lizardDist ();
			break;
		case 1035:
			itemFun.lionConct ();
			break;
		case 1036:
			itemFun.lionMud ();
			break;
		case 1037:
			itemFun.lionLotion ();
			break;
		case 1038:
			itemFun.lionOil ();
			break;
		case 1039:
			itemFun.lionDist ();
			break;
		case 1040:
			itemFun.foxConct ();
			break;
		case 1041:
			itemFun.foxMud ();
			break;
		case 1042:
			itemFun.foxLotion ();
			break;
		case 1043:
			itemFun.foxOil ();
			break;
		case 1044:
			itemFun.foxDist ();
			break;
		case 1045:
			itemFun.cleanser ();
			break;


		case 10001:
			itemFun.weaponOldSword();
			break; 
		case 10002:
			itemFun.weaponGladius();
			break; 
		case 10003:
			itemFun.weaponVeil();
			break; 
		case 10004:
			itemFun.weaponLeatherWhip();
			break; 
		case 10005:
			itemFun.weaponLustick();
			break; 
		case 10006:
			itemFun.weaponHuntingBow();
			break; 
		case 10022:
			itemFun.weaponHeirloomSword();
			break;


	// armours
		case 20000:
			itemFun.armorNaked ();
			break;
		case 20001:
			itemFun.armorLegionary ();
			break; 
		case 20002:
			itemFun.armorCenturio ();
			break; 
		case 20003:
			itemFun.armorLegatus ();
			break; 
		case 20004:
			itemFun.armorCaesar ();
			break; 
		case 20005:
			itemFun.armorSexyConsul ();
			break; 
		case 20006:
			itemFun.armorCataprach ();
			break; 
		case 20007:
			itemFun.armorSexyFem1 ();
			break; 
		case 20008:
			itemFun.armorTraveling ();
			break; 
		case 20009:
			itemFun.armorReligiousHabit ();
			break; 
		case 20010:
			itemFun.armorPatricianSuit ();
			break; 
		case 20011:
			itemFun.armorSenator ();
			break; 
		case 20012:
			itemFun.armorSilkDress ();
			break; 
		case 20013:
			itemFun.armorSilkDressObs ();
			break; 
		case 20014:
			itemFun.armorLoveMaidenBikini ();
			break;

		case 20024:
			itemFun.armorHeirloomArmour ();
			break;
		case 20025:
			itemFun.armorElvenArmour ();
			break;
		case 20026:
			itemFun.armorElvenLightArmour ();
			break;
		case 20027:
			itemFun.armorElvenDress ();
			break;
		case 20028:
			itemFun.sexyLeatherOutfit ();
			break;
		case 20029:
			itemFun.maidDress ();
			break;

		case 20500:
			itemFun.armorOriginArmour ();
			break;






	// helmets
		case 30000:
			itemFun.helmetNone ();
			break; 
		case 30001:
			itemFun.helmetGalea ();
			break; 
		case 30002: 
			itemFun.helmetGladiator ();
			break; 
		case 30003: 
			itemFun.helmetDBHood ();
			break; 
		case 30004: 
			itemFun.helmetLaurelCrown ();
			break; 
		case 30500: 
			itemFun.faceOriginMask ();
			break; 


	// Face
		case 40000:
			itemFun.faceNone ();
			break;
		case 40001:
			itemFun.faceBandolier ();
			break;
		case 40002:
			itemFun.faceGladiatorMask ();
			break;
		case 40003:
			itemFun.faceLibrarianGlasses ();
			break;
		case 40004:
			itemFun.faceDarkShades ();
			break;

		case 40500:
			itemFun.faceOriginMask ();
			break;

	// Neck
		case 50000:
			itemFun.neckNone ();
			break;
		case 50001:
			itemFun.neckRScarf ();
			break;
		case 50002:
			itemFun.neckGorget ();
			break;
		case 50003:
			itemFun.neckSlaveCollar1 ();
			break;
		case 50004:
			itemFun.neckSpikedCollar ();
			break;
		case 50005:
			itemFun.neckGoldNecklace1 ();
			break;

		case 50500:
			itemFun.neckOriginGorget ();
			break;

//////////// Shoulders


		case 60000:
			itemFun.shouldersNone();
			break;
		case 60001:
			itemFun.shouldersRCape();
			break;
		case 60002:
			itemFun.shouldersSurvivalBackpack ();
			break;
		case 60003:
			itemFun.shouldersRSchoolBackpack ();
			break;
		case 60004:
			itemFun.shouldersPauldrons ();
			break;
		case 60005:
			itemFun.shouldersPauldronsRCape ();
			break;
		case 60500:
			itemFun.shouldersOriginCape ();
			break;

//////////// arms 70000

		case 70000:
			itemFun.armsNone ();
			break;
		case 70001:
			itemFun.armsGauntlet ();
			break;
		case 70002:
			itemFun.armsBFishnet ();
			break;
		case 70003:
			itemFun.armsPSpandex ();
			break;
		case 70004:
			itemFun.armsSpikedWristband ();
			break;
		case 70005:
			itemFun.armsFingerlessGloves ();
			break;
		case 70006:
			itemFun.armsBandages ();
			break;

		case 70500:
			itemFun.armsOriginGauntlet ();
			break;


//////////// legs 80000

		case 80000:
			itemFun.legsNone ();
			break;
		case 80001:
			itemFun.legsCombatBoots ();
			break;
		case 80002:
			itemFun.legsGreaves ();
			break;
		case 80003:
			itemFun.legsElegantSandals ();
			break;
		case 80004:
			itemFun.legsBandages ();
			break;
		case 80005:
			itemFun.legsBHighHeels ();
			break;

		case 80500:
			itemFun.legsOriginboots ();
			break;
		
		
//////////// makeup 90000

		case 90000:
			itemFun.makeupNone ();
			break;
		case 90001:
			itemFun.makeupNatural ();
			break;
		case 90002:
			itemFun.makeupSlutty ();
			break;
		case 90003:
			itemFun.makeupTrival ();
			break;
		case 90004:
			itemFun.makeupElegant ();
			break;

//////////// Amulet 110000

		case 110000:
			itemFun.amuletNone ();
			break;
		case 110001:
			//itemFun.makeupNatural ();
			break;
		case 110002:
			//itemFun.makeupSlutty ();
			break;
		case 110003:
			//itemFun.makeupTrival ();
			break;
		case 110004:
			itemFun.amuletFamilyHeirloom ();
			break;


			// am









		}

	}



	void Awake (){

	}

}

