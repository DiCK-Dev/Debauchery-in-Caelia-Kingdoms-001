using UnityEngine;
using System.Collections;
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 

public class MapChapter1 : MonoBehaviour {
	int randNum; 
	public Text SceneTitle;

	public Image mapImage; 
	public Image capital1Image;

	public Image capital2Image;

	public Image city1Image;

	public Image town1Image;
	public Image town2Image;
	public Image town3Image;
	public Image town4Image;
	public Image town5Image;


	public Button buttCapital2; 
	public Button buttCity1; 
	public Button buttTown1; 
	public Button buttTown2; 
	public Button buttTown3; 
	public Button buttTown4; 
	public Button buttTown5; 
	public Button buttLocPlains; 
	public Button buttLocMountains; 



	// cities
	public void capital1Hover(){
		capital1Image.sprite = Resources.Load<Sprite> ("MapAssets/capital1") as Sprite;
		SceneTitle.text = "Aurorum"; 

	}
		

	public void capital1HoverExit(){
		capital1Image.sprite = Resources.Load<Sprite> ("MapAssets/capital1s") as Sprite;
		SceneTitle.text = "Region 1"; 
	}



	public void capital2Hover(){
		if (WorldControl.chapter1Locations [8] == true) {
			capital2Image.sprite = Resources.Load<Sprite> ("MapAssets/capital1") as Sprite;
			SceneTitle.text = "Ku-Jiang"; 
		}
	}//


	public void capital2HoverExit(){
		if (WorldControl.chapter1Locations [8] == true) {
			capital2Image.sprite = Resources.Load<Sprite> ("MapAssets/capital1s") as Sprite;
			SceneTitle.text = "Region 1"; 
		}

	}



	// towns
	public void town1Hover(){
		if (WorldControl.chapter1Locations [2] == true) {


			town1Image.sprite = Resources.Load<Sprite> ("MapAssets/town1") as Sprite;
			SceneTitle.text = "Town 1"; 
		}

	}

	public void town1HoverExit(){
		if (WorldControl.chapter1Locations [2] == true) {
			town1Image.sprite = Resources.Load<Sprite> ("MapAssets/town1s") as Sprite;
			SceneTitle.text = "Region 1"; 
		}
	}

	public void town2Hover(){
		if (WorldControl.chapter1Locations [3] == true) {
			town2Image.sprite = Resources.Load<Sprite> ("MapAssets/town1") as Sprite;
			SceneTitle.text = "Town 2"; 
		}

	}

	public void town2HoverExit(){
		if (WorldControl.chapter1Locations [3] == true) {
			town1Image.sprite = Resources.Load<Sprite> ("MapAssets/town1s") as Sprite;
			SceneTitle.text = "Region 1";
		}
	}

	public void town3Hover(){
		if (WorldControl.chapter1Locations [4] == true) {
			town3Image.sprite = Resources.Load<Sprite> ("MapAssets/town1") as Sprite;
			SceneTitle.text = "Town 3"; 
		}


	}

	public void town3HoverExit(){
		if (WorldControl.chapter1Locations [4] == true) {
			town3Image.sprite = Resources.Load<Sprite> ("MapAssets/town1s") as Sprite;
			SceneTitle.text = "Region 1"; 
		}
	}


	public void town4Hover(){
		if (WorldControl.chapter1Locations [5] == true) {
			town4Image.sprite = Resources.Load<Sprite> ("MapAssets/town1") as Sprite;
			SceneTitle.text = "Town 4"; 
		}


	}

	public void town4HoverExit(){
		if (WorldControl.chapter1Locations [5] == true) {
			town4Image.sprite = Resources.Load<Sprite> ("MapAssets/town1s") as Sprite;
			SceneTitle.text = "Region 1"; 
		}
	}


	public void town5Hover(){
		if (WorldControl.chapter1Locations [6] == true) {
			town5Image.sprite = Resources.Load<Sprite> ("MapAssets/town1") as Sprite;
			SceneTitle.text = "Town 5"; 
		}


	}

	public void town5HoverExit(){
		if (WorldControl.chapter1Locations [6] == true) {
			town5Image.sprite = Resources.Load<Sprite> ("MapAssets/town1s") as Sprite;
			SceneTitle.text = "Region 1"; 
		}
	}


	//cities
	public void city1Hover(){
		if (WorldControl.chapter1Locations [7] == true) {
			city1Image.sprite = Resources.Load<Sprite> ("MapAssets/city1") as Sprite;
			SceneTitle.text = "City 1"; 
		}


	}

	public void city1HoverExit(){
		if (WorldControl.chapter1Locations [7] == true) {
			city1Image.sprite = Resources.Load<Sprite> ("MapAssets/city1s") as Sprite;
			SceneTitle.text = "Region 1"; 
		}
	}


	//






	public void forestHover(){
		mapImage.sprite = Resources.Load<Sprite> ("MapAssets/MapCh1Forest") as Sprite;
		SceneTitle.text = "Forest"; 
	}//

	public void plainsHover(){
		Debug.Log ("plains hover");

		//if (WorldControl.chapter1Locations [0] == true) {
			mapImage.sprite = Resources.Load<Sprite> ("MapAssets/MapCh1Plains") as Sprite;
			SceneTitle.text = "Plains"; 
		//}


	}//



	public void mountainHover(){
		if (WorldControl.chapter1Locations [1] == true) {
			mapImage.sprite = Resources.Load<Sprite> ("MapAssets/MapCh1Mountains") as Sprite;
			SceneTitle.text = "Mountains"; 
		}

	}//

	public void mapHover(){
		mapImage.sprite = Resources.Load<Sprite> ("MapAssets/MapCh1") as Sprite;
		SceneTitle.text = "Region 1"; 
	}//







	public void goAurorum(){
		SceneManager.LoadScene (13);
	}





	/// L//////////////////////////////////////////	/// </summary>

	public void lockLocations()
	{

		/*
		buttLocPlains.enabled = !buttLocPlains.enabled; 
		if (WorldControl.chapter1Locations [0] == true) {
			buttLocPlains.enabled = !buttLocPlains.enabled; 
		}


		buttLocMountains.enabled = !buttLocMountains.enabled; 
		if (WorldControl.chapter1Locations [1] == true) {
			buttLocPlains.enabled = !buttLocPlains.enabled; 
		}
			
*/




		buttCapital2.enabled = !buttCapital2.enabled; 
		capital2Image.sprite = Resources.Load<Sprite> ("MapAssets/capital1d") as Sprite;
		if (WorldControl.chapter1Locations [8] == true) {
			buttCapital2.enabled = !buttCapital2.enabled; 
			capital2Image.sprite = Resources.Load<Sprite> ("MapAssets/capital1s") as Sprite;
		}





		buttCity1.enabled = !buttCity1.enabled; 
		city1Image.sprite = Resources.Load<Sprite> ("MapAssets/city1d") as Sprite;
		if (WorldControl.chapter1Locations[7] == true){
			buttCity1.enabled = !buttCity1.enabled; 
			city1Image.sprite = Resources.Load<Sprite> ("MapAssets/city1") as Sprite;
		}

		buttTown1.enabled = !buttTown1.enabled;
		town1Image.sprite = Resources.Load<Sprite> ("MapAssets/empty") as Sprite;
		if (WorldControl.chapter1Locations [2] == true) {
			town1Image.sprite = Resources.Load<Sprite> ("MapAssets/town1") as Sprite;
			buttTown1.enabled = !buttTown1.enabled;
		}

		buttTown2.enabled = !buttTown2.enabled;
		town2Image.sprite = Resources.Load<Sprite> ("MapAssets/empty") as Sprite;
		if (WorldControl.chapter1Locations [3] == true) {
			town2Image.sprite = Resources.Load<Sprite> ("MapAssets/town1") as Sprite;
			buttTown2.enabled = !buttTown2.enabled;
		}


		buttTown3.enabled = !buttTown3.enabled;
		town3Image.sprite = Resources.Load<Sprite> ("MapAssets/empty") as Sprite;
		if (WorldControl.chapter1Locations [4] == true) {
			town1Image.sprite = Resources.Load<Sprite> ("MapAssets/town1") as Sprite;
			buttTown3.enabled = !buttTown3.enabled;
		}

		buttTown4.enabled = !buttTown4.enabled;
		town4Image.sprite = Resources.Load<Sprite> ("MapAssets/empty") as Sprite;
		if (WorldControl.chapter1Locations [5] == true) {
			town4Image.sprite = Resources.Load<Sprite> ("MapAssets/town1") as Sprite;
			buttTown4.enabled = !buttTown4.enabled;
		}


		buttTown5.enabled = !buttTown5.enabled;
		town5Image.sprite = Resources.Load<Sprite> ("MapAssets/empty") as Sprite;
		if (WorldControl.chapter1Locations [6] == true) {
			town5Image.sprite = Resources.Load<Sprite> ("MapAssets/town1") as Sprite;
			buttTown5.enabled = !buttTown5.enabled;
		}




	}









	public void ForestRandomEvent()
	{
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 100);

		if (randNum > 50) {
			SceneManager.LoadScene (34);
		} else {
			Random.InitState(System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 1000);
			//Debug.Log (randNum);
			if (randNum > 670)
			{
				SceneManager.LoadScene (28);
			} 
			else if (randNum > 330)
			{
				SceneManager.LoadScene (30);
			} 
			else
			{
				SceneManager.LoadScene (32);
			}




		}

	}////////


	public void PlainsRandomEvent()
	{
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 100);

		if (randNum > 50) {
			SceneManager.LoadScene (36);
		} else {
			Random.InitState(System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 1000);
			//ADAPT TO NEW ENEMY,check forest
			if (randNum > 500)
			{
				SceneManager.LoadScene (37);
			} 
			else
			{
				SceneManager.LoadScene (39);
			} 





		}

	}////////




	void Awake (){

		lockLocations ();
	}





}
