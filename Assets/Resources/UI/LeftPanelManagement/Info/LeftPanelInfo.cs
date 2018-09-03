using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LeftPanelInfo : MonoBehaviour {

	static int selectorInfo;
	static int infoPage;
	public Text Board; 
	public Text actualPage;
	public Text infoTitle;

	public void selectInfo(int selector){
		selectorInfo = selector; 
		infoPage = 0; 
		mainInfo ();

	}


	public void mainInfo()
	{
		if (selectorInfo == 0) 
		{
			Board.text = "PAGE 0 TEXT Example";
			infoTitle.text = "Title 0 Test";
			actualPage.text = "Page 0";
		}
	}


	public void nextPage(){
		if (selectorInfo == 0 && infoPage == 0) 
		{
			infoPage = 1;
			Board.text = "PAGE 1 TEXT";
			actualPage.text = "Page 1";

		}else if (selectorInfo == 0 && infoPage == 1)
		{
			infoPage = 2;
			Board.text = "PAGE 2 TEXT";
			actualPage.text = "Page 2";

		}else if (selectorInfo == 0 && infoPage == 2)
		{
			infoPage = 0;
			mainInfo ();

		}



	}

	public void previousPage(){
		
		if (selectorInfo == 0 && infoPage == 0)
		{
			infoPage = 1;
			nextPage ();
		}else if (selectorInfo == 0 && infoPage == 1) 
		{
			infoPage = 2;
			nextPage ();
		}else if (selectorInfo == 0 && infoPage == 2)
		{
			infoPage = 0;
			nextPage ();
		}



	}







}
