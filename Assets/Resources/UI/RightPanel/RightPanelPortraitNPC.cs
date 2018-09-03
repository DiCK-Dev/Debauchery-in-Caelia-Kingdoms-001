using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RightPanelPortraitNPC : MonoBehaviour {

	public GameObject self; 

	/// <summary>
	/// update once you update the NPC class please
	/// </summary>
	int idxCurrent;
	//head
	int layer0ID; //accesory - horns (front)
	int layer1ID; //hair front 
	int layer2ID; // ears
	int layer3ID; // eyes
	int layer4ID; // face/head shape
	int layer5ID; // accesory - horns (back)
	int layer6ID; // hair chest 

	//outfit
	int layer7ID; // Lower leg 
	int layer8ID; // Tops
	int layer9ID; // Ballsack
	int layer10ID; // Bottom
	//body
	int layer11ID; // Dick
	int layer12ID; // breasts
	int layer13ID; // body shape
	//hair
	int layer14ID; // hair (back)
	//tail
	int layer15ID; // tail
	//wings 
	int layer16ID; // wings 

	public Image layer0, layer1, layer2, layer3, layer4,layer5, layer6, layer7, layer8, layer9, layer10, layer11, layer12,layer13, layer14, layer15,layer16; 

	public void selfDes(){
		Destroy (self);
	}


	void spriteUpdater()
	{

		Debug.Log (NPCCharList.CharRetainers [WorldControl.idx].charPortraitLayer0.ToString());
		Debug.Log (NPCCharList.CharRetainers [WorldControl.idx].charPortraitLayer1.ToString());
		Debug.Log (NPCCharList.CharRetainers [WorldControl.idx].charPortraitLayer2.ToString());


		layer0.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer0/" + NPCCharList.CharRetainers [WorldControl.idx].charPortraitLayer0) as Sprite;
		layer1.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer1/" + NPCCharList.CharRetainers [WorldControl.idx].charPortraitLayer1) as Sprite;
		layer2.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer2/" + NPCCharList.CharRetainers [WorldControl.idx].charPortraitLayer2) as Sprite;
		layer3.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer3/" + NPCCharList.CharRetainers [WorldControl.idx].charPortraitLayer3) as Sprite;
		layer4.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer4/" + NPCCharList.CharRetainers [WorldControl.idx].charPortraitLayer4) as Sprite;
		layer5.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer5/" + NPCCharList.CharRetainers [WorldControl.idx].charPortraitLayer5) as Sprite;
		layer6.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer6/" + NPCCharList.CharRetainers [WorldControl.idx].charPortraitLayer6) as Sprite;
		layer7.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer7/" + NPCCharList.CharRetainers [WorldControl.idx].charPortraitLayer7) as Sprite;
		layer8.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer8/" + NPCCharList.CharRetainers [WorldControl.idx].charPortraitLayer8) as Sprite;
		layer9.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer9/" + NPCCharList.CharRetainers [WorldControl.idx].charPortraitLayer9) as Sprite;
		layer10.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer10/"+NPCCharList.CharRetainers [WorldControl.idx].charPortraitLayer10) as Sprite;
		layer11.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer11/" + NPCCharList.CharRetainers [WorldControl.idx].charPortraitLayer11) as Sprite;
		layer12.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer12/" + NPCCharList.CharRetainers [WorldControl.idx].charPortraitLayer12) as Sprite;
		layer13.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer13/" + NPCCharList.CharRetainers [WorldControl.idx].charPortraitLayer13) as Sprite;
		layer14.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer14/" + NPCCharList.CharRetainers [WorldControl.idx].charPortraitLayer14) as Sprite;
		layer15.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer15/" + NPCCharList.CharRetainers [WorldControl.idx].charPortraitLayer15) as Sprite;
		layer16.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer16/" + NPCCharList.CharRetainers [WorldControl.idx].charPortraitLayer16) as Sprite;



		//enemyPortrait.sprite = Resources.Load<Sprite> ("Portraits/Enemies/" + localID) as Sprite;

		if (layer0.sprite == null) {
			layer0.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + 0)as Sprite;; 
		}
		if (layer1.sprite == null) {
			layer1.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + 0)as Sprite;; 
		}
		if (layer2.sprite == null) {
			layer2.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + 0)as Sprite;; 
		}
		if (layer3.sprite == null) {
			layer3.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + 0)as Sprite;; 
		}
		if (layer4.sprite == null) {
			layer4.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + 0)as Sprite;; 
		}
		if (layer5.sprite == null) {
			layer5.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + 0)as Sprite;; 
		}
		if (layer6.sprite == null) {
			layer6.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + 0)as Sprite;; 
		}
		if (layer7.sprite == null) {
			layer7.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + 0)as Sprite;; 
		}
		if (layer8.sprite == null) {
			layer8.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + 0)as Sprite;; 
		}
		if (layer9.sprite == null) {
			layer9.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + 0)as Sprite;; 
		}
		if (layer10.sprite == null) {
			layer10.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + 0)as Sprite;; 
		}
		if (layer11.sprite == null) {
			layer11.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + 0)as Sprite;; 
		}
		if (layer12.sprite == null) {
			layer12.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + 0)as Sprite;; 
		}
		if (layer13.sprite == null) {
			layer13.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + 0)as Sprite;; 
		}
		if (layer14.sprite == null) {
			layer14.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + 0)as Sprite;; 
		}
		if (layer15.sprite == null) {
			layer15.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + 0)as Sprite;; 
		}
		if (layer16.sprite == null) {
			layer16.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + 0)as Sprite;; 
		}



	}



	void Start (){
		Debug.Log ("worldidx is " + WorldControl.idx);
		idxCurrent = 10;
	}


	void Update () {

		spriteUpdater ();
		Debug.Log ("update Enemy Portrait 2");


	}


}
