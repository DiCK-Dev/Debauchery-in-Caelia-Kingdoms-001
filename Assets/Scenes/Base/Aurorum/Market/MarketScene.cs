using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MarketScene : MonoBehaviour {

	public Text Board; 

	public RectTransform endTurnPanel;
	public RectTransform PanPotion1;
	public RectTransform PanPotion2;
	public RectTransform PanTailor1; 
	public RectTransform PanTailor2; 
	public RectTransform PanBlack1;
	public RectTransform PanBlack2;
	public RectTransform PanInn1;
	public RectTransform PanInn2;
	public RectTransform PanSlave1; 
	public RectTransform PanSlave2; 


	// SlaveMarket
	/// /////////////////////////////////////////////////////////////////////////////////////////////////
	public void SlaveMarketText() {
		// text that welcomes you to the store 
		if (CityControl.city100MarketMeet [5] == false) {
			Board.text = "You arrive at the Commercial District of the city. Despite the conditions of the outer parts of Aurorum, the Commercial District has always been a place full of bustle and life. People buying ingredients for their foods or other kind of wares and trinket for their everyday needs. You can see that there are a small amount of Plagued people buying, most of them are loading and unloading the carts as slaves.\n\nAs you approach the place, many of the peddlers around the district see that you are inspecting the place, so they approach to you and try to sell you different kinds of things. You dismiss them, even though the are persistent. You can see that the district has from a tailor to a blacksmith, but some of those buildings seems to be closed due to lack of staff. Perhaps you should visit some of them and make a list of what kind of people you would require to fill the gaps.\n\nOr you can see what the open stores have for sale. After all, you require some stuff for your travels.\n\n"; 
			endTurnPanel.SetAsLastSibling ();
			CityControl.city100MarketMeet [5] = true; 
		} else {
			PanSlave1.SetAsLastSibling ();
			
			if (CityControl.city100Corruption >= 100) {
				Board.text = "As you arrive at the commercial district, you can see that it’s a bit different from what you remember. Although the peddlers are still roaming the place, you can see that the merchants now are dressing in a more enticing way. And the things they sell are mixed with a couple of sex toys and collars. At least the market is still thriving. \n\nYou know that the stores that are around have been changing a bit lately, but maybe that requires a closer inspection into each of them.";
			} else if (CityControl.city100Corruption < 100) 
			{
				Board.text = "As you arrive at the commercial district, you can see that it’s a bit different from what you remember. Although the peddlers are still roaming the place, you can see that the merchants now are dressing in a more enticing way. And the things they sell are mixed with a couple of sex toys and collars. At least the market is still thriving. \n\nYou know that the stores that are around have been changing a bit lately, but maybe that requires a closer inspection into each of them.";
			} else if (CityControl.city100Corruption < 80) 
			{
				Board.text = "As you arrive at the commercial district, you can see that it’s a bit different from what you remember. Although the peddlers are still roaming the place, you can see that the merchants now are dressing in a more enticing way. And the things they sell are mixed with a couple of sex toys and collars. At least the market is still thriving. \n\nYou know that the stores that are around have been changing a bit lately, but maybe that requires a closer inspection into each of them.";
			} else if (CityControl.city100Corruption < 60) 
			{
				Board.text = "As you arrive at the commercial district, you can see that the place is still as lively as ever. Some of the merchants are gypsies, that supplied the stocks that the merchant have been missing for a while. The scent of spices and exotic foods mixes in the air around you, filling you with renewed energies, at least for a bit. But it has always been a good sign that the commerce is still moving inside the city.\n\n\nYou should check the places where you’ve improved the situation, just to see how they are going. Or maybe you should go and buy some things for your travels outside the city, as you never know what could happen.";
			} else if (CityControl.city100Corruption < 40) 
			{
				Board.text = "As you arrive at the commercial district, you can see that the place is still as lively as ever. Some of the merchants are gypsies, that supplied the stocks that the merchant have been missing for a while. The scent of spices and exotic foods mixes in the air around you, filling you with renewed energies, at least for a bit. But it has always been a good sign that the commerce is still moving inside the city.\n\n\nYou should check the places where you’ve improved the situation, just to see how they are going. Or maybe you should go and buy some things for your travels outside the city, as you never know what could happen.";
			} else if (CityControl.city100Corruption < 20) 
			{
				Board.text = "As you arrive at the commercial district, you can see that the place is still as lively as ever. Some of the merchants are gypsies, that supplied the stocks that the merchant have been missing for a while. The scent of spices and exotic foods mixes in the air around you, filling you with renewed energies, at least for a bit. But it has always been a good sign that the commerce is still moving inside the city.\n\n\nYou should check the places where you’ve improved the situation, just to see how they are going. Or maybe you should go and buy some things for your travels outside the city, as you never know what could happen.";
			} else if (CityControl.city100Corruption <= 0) 
			{
				Board.text = "As you arrive at the commercial district, you can see that the place is still as lively as ever. Some of the merchants are gypsies, that supplied the stocks that the merchant have been missing for a while. The scent of spices and exotic foods mixes in the air around you, filling you with renewed energies, at least for a bit. But it has always been a good sign that the commerce is still moving inside the city.\n\n\nYou should check the places where you’ve improved the situation, just to see how they are going. Or maybe you should go and buy some things for your travels outside the city, as you never know what could happen.";
			} 

		}

	}


	public void SlaveBuyPanel(){
		PanSlave1.SetAsLastSibling (); 
		Board.text = "So what you want to buy darling?"; 

	}
	public void SlaveFlirtPanel(){
		PanSlave2.SetAsLastSibling (); 
		Board.text = "So you wanna fuck darlin??"; 

	}


	/*

	// INN store 
	/// /////////////////////////////////////////////////////////////////////////////////////////////////
	public void InnText() {
		// text that welcomes you to the store 
		if (CityControl.city100MarketMeet [4] == false) {
			Board.text = "You arrive at the Commercial District of the city. Despite the conditions of the outer parts of Aurorum, the Commercial District has always been a place full of bustle and life. People buying ingredients for their foods or other kind of wares and trinket for their everyday needs. You can see that there are a small amount of Plagued people buying, most of them are loading and unloading the carts as slaves.\n\nAs you approach the place, many of the peddlers around the district see that you are inspecting the place, so they approach to you and try to sell you different kinds of things. You dismiss them, even though the are persistent. You can see that the district has from a tailor to a blacksmith, but some of those buildings seems to be closed due to lack of staff. Perhaps you should visit some of them and make a list of what kind of people you would require to fill the gaps.\n\nOr you can see what the open stores have for sale. After all, you require some stuff for your travels.\n\n"; 
			endTurnPanel.SetAsLastSibling ();
			CityControl.city100MarketMeet [4] = true; 
		} else {
			PanInn1.SetAsLastSibling ();
			if (CityControl.city100Corruption >= 100) {
				Board.text = "As you arrive at the commercial district, you can see that it’s a bit different from what you remember. Although the peddlers are still roaming the place, you can see that the merchants now are dressing in a more enticing way. And the things they sell are mixed with a couple of sex toys and collars. At least the market is still thriving. \n\nYou know that the stores that are around have been changing a bit lately, but maybe that requires a closer inspection into each of them.";
			} else if (CityControl.city100Corruption < 100) 
			{
				Board.text = "As you arrive at the commercial district, you can see that it’s a bit different from what you remember. Although the peddlers are still roaming the place, you can see that the merchants now are dressing in a more enticing way. And the things they sell are mixed with a couple of sex toys and collars. At least the market is still thriving. \n\nYou know that the stores that are around have been changing a bit lately, but maybe that requires a closer inspection into each of them.";
			} else if (CityControl.city100Corruption < 80) 
			{
				Board.text = "As you arrive at the commercial district, you can see that it’s a bit different from what you remember. Although the peddlers are still roaming the place, you can see that the merchants now are dressing in a more enticing way. And the things they sell are mixed with a couple of sex toys and collars. At least the market is still thriving. \n\nYou know that the stores that are around have been changing a bit lately, but maybe that requires a closer inspection into each of them.";
			} else if (CityControl.city100Corruption < 60) 
			{
				Board.text = "As you arrive at the commercial district, you can see that the place is still as lively as ever. Some of the merchants are gypsies, that supplied the stocks that the merchant have been missing for a while. The scent of spices and exotic foods mixes in the air around you, filling you with renewed energies, at least for a bit. But it has always been a good sign that the commerce is still moving inside the city.\n\n\nYou should check the places where you’ve improved the situation, just to see how they are going. Or maybe you should go and buy some things for your travels outside the city, as you never know what could happen.";
			} else if (CityControl.city100Corruption < 40) 
			{
				Board.text = "As you arrive at the commercial district, you can see that the place is still as lively as ever. Some of the merchants are gypsies, that supplied the stocks that the merchant have been missing for a while. The scent of spices and exotic foods mixes in the air around you, filling you with renewed energies, at least for a bit. But it has always been a good sign that the commerce is still moving inside the city.\n\n\nYou should check the places where you’ve improved the situation, just to see how they are going. Or maybe you should go and buy some things for your travels outside the city, as you never know what could happen.";
			} else if (CityControl.city100Corruption < 20) 
			{
				Board.text = "As you arrive at the commercial district, you can see that the place is still as lively as ever. Some of the merchants are gypsies, that supplied the stocks that the merchant have been missing for a while. The scent of spices and exotic foods mixes in the air around you, filling you with renewed energies, at least for a bit. But it has always been a good sign that the commerce is still moving inside the city.\n\n\nYou should check the places where you’ve improved the situation, just to see how they are going. Or maybe you should go and buy some things for your travels outside the city, as you never know what could happen.";
			} else if (CityControl.city100Corruption <= 0) 
			{
				Board.text = "As you arrive at the commercial district, you can see that the place is still as lively as ever. Some of the merchants are gypsies, that supplied the stocks that the merchant have been missing for a while. The scent of spices and exotic foods mixes in the air around you, filling you with renewed energies, at least for a bit. But it has always been a good sign that the commerce is still moving inside the city.\n\n\nYou should check the places where you’ve improved the situation, just to see how they are going. Or maybe you should go and buy some things for your travels outside the city, as you never know what could happen.";
			} 

		}

	}


	public void InnBuyPanel(){
		PanInn1.SetAsLastSibling (); 
		Board.text = "So what you want to buy darling?"; 

	}
	public void InnFlirtPanel(){
		PanInn2.SetAsLastSibling (); 
		Board.text = "So you wanna fuck darlin??"; 

	}


	// Blacksmith
	/// /////////////////////////////////////////////////////////////////////////////////////////////////
	public void BlacksmithStoreText() {
		// text that welcomes you to the store 
		if (CityControl.city100MarketMeet [3] == false) {
			Board.text = "You enter the blacksmith the first time and are impressed"; 
			CityControl.city100MarketMeet [3] = true; 
			endTurnPanel.SetAsLastSibling ();
		} else {
			PanBlack1.SetAsLastSibling ();
			if (CityControl.city100Corruption >= 100) {
				Board.text = "the  scene of corruption at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption > 90) 
			{
				Board.text = " the corruption at at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption > 70) 
			{
				Board.text = "the scene of corruption at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption > 50) 
			{
				Board.text = "the  scene of corruption at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption > 30) 
			{
				Board.text = "the  scene of corruption at" + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption > 10) 
			{
				Board.text = "the cene of corruption at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption >= 0) 
			{
				Board.text = "the scene of corruption at " + CityControl.city100Corruption;
			} 

		}

	}


	public void BlackBuyPanel(){
		PanBlack1.SetAsLastSibling (); 
		Board.text = "So what you want to buy darling?"; 

	}
	public void BlackFlirtPanel(){
		PanBlack2.SetAsLastSibling (); 
		Board.text = "So you wanna fuck darlin??"; 

	}

	// Tailor store 
	/// /////////////////////////////////////////////////////////////////////////////////////////////////
	public void TailorStoreText() {
		// text that welcomes you to the store 
		if (CityControl.city100MarketMeet [2] == false) {
			Board.text = "You enter the Tailor the first time and are impressed"; 
			CityControl.city100MarketMeet [2] = true; 
			endTurnPanel.SetAsLastSibling ();
		} else {
			PanTailor1.SetAsLastSibling ();
			if (CityControl.city100Corruption >= 100) {
				Board.text = "the  scene of corruption at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption > 90) 
			{
				Board.text = " the corruption at at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption > 70) 
			{
				Board.text = "the scene of corruption at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption > 50) 
			{
				Board.text = "the  scene of corruption at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption > 30) 
			{
				Board.text = "the  scene of corruption at" + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption > 10) 
			{
				Board.text = "the cene of corruption at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption >= 0) 
			{
				Board.text = "the scene of corruption at " + CityControl.city100Corruption;
			} 

		}

	}


	public void TailorBuyPanel(){
		PanTailor1.SetAsLastSibling (); 
		Board.text = "So what you want to buy darling?"; 

	}
	public void TailorFlirtPanel(){
		PanTailor2.SetAsLastSibling (); 
		Board.text = "So you wanna fuck darlin??"; 

	}

	// Potion store 
	/// /////////////////////////////////////////////////////////////////////////////////////////////////
	public void PotionStoreText() {
		// text that welcomes you to the store 
		if (CityControl.city100MarketMeet [1] == false) {
			Board.text = "You enter the Potion store the first time and are impressed"; 
			CityControl.city100MarketMeet [1] = true; 
			endTurnPanel.SetAsLastSibling ();
		} else {

			if (CityControl.city100Corruption >= 100) {
				Board.text = "the potion store scene of corruption at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption > 90) 
			{
				Board.text = " the potion store scene of corruption at at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption > 70) 
			{
				Board.text = "the potion store scene of corruption at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption > 50) 
			{
				Board.text = "the potion store scene of corruption at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption > 30) 
			{
				Board.text = "the potion store scene of corruption at" + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption > 10) 
			{
				Board.text = "the potion store scene of corruption at " + CityControl.city100Corruption;
			} else if (CityControl.city100Corruption >= 0) 
			{
				Board.text = "the potion store scene of corruption at " + CityControl.city100Corruption;
			} 

		}

	}


	public void PotionBuyPanel(){
		PanPotion1.SetAsLastSibling (); 
		Board.text = "So what you want to buy darling?"; 

	}
	public void PotionFlirtPanel(){
		PanPotion2.SetAsLastSibling (); 
		Board.text = "So you wanna fuck darlin??"; 

	}
	///////////BUYING AND SELLING IN OTHER SCRIPT SAME WITH SCENES 

	*/
	// market start scene texts
	/// /////////////////////////////////////////////////////////////////////////////////////////////////

	public void MarketStart (){
		if (CityControl.city100MarketMeet[0] == false) 
		{
			Board.text = "You arrive at the Commercial District of the city. Despite the conditions of the outer parts of Aurorum, the Commercial District has always been a place full of bustle and life. People buying ingredients for their foods or other kind of wares and trinket for their everyday needs. You can see that there are a small amount of Plagued people buying, most of them are loading and unloading the carts as slaves.\n\nAs you approach the place, many of the peddlers around the district see that you are inspecting the place, so they approach to you and try to sell you different kinds of things. You dismiss them, even though the are persistent. You can see that the district has from a tailor to a blacksmith, but some of those buildings seems to be closed due to lack of staff. Perhaps you should visit some of them and make a list of what kind of people you would require to fill the gaps.\n\nOr you can see what the open stores have for sale. After all, you require some stuff for your travels.\n\n"; 
			CityControl.city100MarketMeet[0] = true; 
			
		}else
		{
			if (CityControl.city100Corruption >= 100) {
				Board.text = "As you arrive at the commercial district, you can see that the place is still as lively as ever. Some of the merchants are gypsies, that supplied the stocks that the merchant have been missing for a while. The scent of spices and exotic foods mixes in the air around you, filling you with renewed energies, at least for a bit. But it has always been a good sign that the commerce is still moving inside the city.\n\n\nYou should check the places where you’ve improved the situation, just to see how they are going. Or maybe you should go and buy some things for your travels outside the city, as you never know what could happen.";
			} else if (CityControl.city100Corruption < 100) 
			{
				Board.text = "As you arrive at the commercial district, you can see that the place is still as lively as ever. Some of the merchants are gypsies, that supplied the stocks that the merchant have been missing for a while. The scent of spices and exotic foods mixes in the air around you, filling you with renewed energies, at least for a bit. But it has always been a good sign that the commerce is still moving inside the city.\n\n\nYou should check the places where you’ve improved the situation, just to see how they are going. Or maybe you should go and buy some things for your travels outside the city, as you never know what could happen.";
			} else if (CityControl.city100Corruption < 80) 
			{
				Board.text = "As you arrive at the commercial district, you can see that the place is still as lively as ever. Some of the merchants are gypsies, that supplied the stocks that the merchant have been missing for a while. The scent of spices and exotic foods mixes in the air around you, filling you with renewed energies, at least for a bit. But it has always been a good sign that the commerce is still moving inside the city.\n\n\nYou should check the places where you’ve improved the situation, just to see how they are going. Or maybe you should go and buy some things for your travels outside the city, as you never know what could happen.";
			} else if (CityControl.city100Corruption < 60) 
			{
				Board.text = "As you arrive at the commercial district, you can see that the place is still as lively as ever. Some of the merchants are gypsies, that supplied the stocks that the merchant have been missing for a while. The scent of spices and exotic foods mixes in the air around you, filling you with renewed energies, at least for a bit. But it has always been a good sign that the commerce is still moving inside the city.\n\n\nYou should check the places where you’ve improved the situation, just to see how they are going. Or maybe you should go and buy some things for your travels outside the city, as you never know what could happen.";
			} else if (CityControl.city100Corruption < 40) 
			{
				Board.text = "As you arrive at the commercial district, you can see that the place is still as lively as ever. Some of the merchants are gypsies, that supplied the stocks that the merchant have been missing for a while. The scent of spices and exotic foods mixes in the air around you, filling you with renewed energies, at least for a bit. But it has always been a good sign that the commerce is still moving inside the city.\n\n\nYou should check the places where you’ve improved the situation, just to see how they are going. Or maybe you should go and buy some things for your travels outside the city, as you never know what could happen.";
			} else if (CityControl.city100Corruption < 20) 
			{
				Board.text = "As you arrive at the commercial district, you can see that the place is still as lively as ever. Some of the merchants are gypsies, that supplied the stocks that the merchant have been missing for a while. The scent of spices and exotic foods mixes in the air around you, filling you with renewed energies, at least for a bit. But it has always been a good sign that the commerce is still moving inside the city.\n\n\nYou should check the places where you’ve improved the situation, just to see how they are going. Or maybe you should go and buy some things for your travels outside the city, as you never know what could happen.";
			} else if (CityControl.city100Corruption <= 0) 
			{
				Board.text = "As you arrive at the commercial district, you can see that the place is still as lively as ever. Some of the merchants are gypsies, that supplied the stocks that the merchant have been missing for a while. The scent of spices and exotic foods mixes in the air around you, filling you with renewed energies, at least for a bit. But it has always been a good sign that the commerce is still moving inside the city.\n\n\nYou should check the places where you’ve improved the situation, just to see how they are going. Or maybe you should go and buy some things for your travels outside the city, as you never know what could happen.";
			} 

		}

	}




	void Awake () {
		WorldControl.location = "Aurorum - Commercial District"; 

	}

	void Start () {
		MarketStart ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
