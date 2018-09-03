using UnityEngine;
using System.Collections;
using UnityEngine.UI; 


public class MapWorld : MonoBehaviour {
	public Text SceneTitle;

	static int chapterSelected; //selects which map appears, this stays when you come back so you dont need to check the map every time
	public Image MapImage; 
	public RectTransform panChapter1; 
	public RectTransform panChapter2; 
	public RectTransform panChapter3; 
	public RectTransform panChapter4; 
	public RectTransform panChapter5; 
	public RectTransform panWorldMap;


	public Button buttRegion1; 
	public Button buttRegion2; 
	public Button buttRegion3; 
	public Button buttRegion4; 
	public Button buttRegion5; 

	public void hoverMap0(){

		MapImage.sprite = Resources.Load<Sprite> ("MapAssets/Map0") as Sprite;
		SceneTitle.text = "World Map"; 
	}

	public void hoverMap1(){
		MapImage.sprite = Resources.Load<Sprite> ("MapAssets/Map1") as Sprite;
		SceneTitle.text = "Region 1"; 
	}

	public void hoverMap2(){
		if (WorldControl.storyChapter [1] == true) {
			MapImage.sprite = Resources.Load<Sprite> ("MapAssets/Map2") as Sprite;
			SceneTitle.text = "Region 2"; 
		}

	}

	public void hoverMap3(){
		if (WorldControl.storyChapter [2] == true) {
			MapImage.sprite = Resources.Load<Sprite> ("MapAssets/Map3") as Sprite;
			SceneTitle.text = "Region 3"; 
		}
	}

	public void hoverMap4(){
		if (WorldControl.storyChapter [3] == true) {
			MapImage.sprite = Resources.Load<Sprite> ("MapAssets/Map4") as Sprite;
			SceneTitle.text = "Region 4"; 
		}
	}

	public void hoverMap5(){
		if (WorldControl.storyChapter [4] == true) {
			MapImage.sprite = Resources.Load<Sprite> ("MapAssets/Map5") as Sprite;
			SceneTitle.text = "Region 5"; 
		}
	}


	public void selectCha1(){
		chapterSelected = 1; 
		loadChapter ();
	}
	public void selectCha2(){
		if (WorldControl.storyChapter [0] == true) {

			chapterSelected = 2; 
			loadChapter ();
		}
	}
	public void selectCha3(){
		if (WorldControl.storyChapter [1] == true) {
			chapterSelected = 3; 
			loadChapter ();
		}
	}
	public void selectCha4(){
		if (WorldControl.storyChapter [2] == true) {
			chapterSelected = 4; 
			loadChapter ();
		}
	}
	public void selectCha5(){
		if (WorldControl.storyChapter [3] == true) {
			chapterSelected = 5; 
			loadChapter ();
		}
	}



	public void loadChapter()
	{
		if (chapterSelected == 1) {
			panChapter1.SetAsLastSibling ();
		}

		if (chapterSelected == 2) {
			panChapter2.SetAsLastSibling ();
		}
		if (chapterSelected == 3) {
			panChapter3.SetAsLastSibling ();
		}
		if (chapterSelected == 4) {
			panChapter4.SetAsLastSibling ();
		}
		if (chapterSelected == 5) {
			panChapter5.SetAsLastSibling ();
		}

	}

	void Awake(){
		WorldControl.location = "World Map";
		loadChapter ();
		buttRegion2.enabled = !buttRegion2.enabled; 
		if (WorldControl.storyChapter [1] == true) {
			buttRegion2.enabled = !buttRegion2.enabled; 
		}


	}

	void Start () {

		MapImage.sprite = Resources.Load<Sprite> ("MapAssets/Map0") as Sprite;
	}





	void Update () {



	}
}
