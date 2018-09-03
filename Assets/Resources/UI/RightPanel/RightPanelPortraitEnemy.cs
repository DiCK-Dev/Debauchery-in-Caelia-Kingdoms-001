using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RightPanelPortraitEnemy : MonoBehaviour {

	public GameObject self; 
	/// <summary>
	/// update once you update the NPC class please
	/// </summary>
	static int idxCurrent;
	//head
	int layer0ID; //accesory - horns (front)
	int layer1ID; //hair front 
	int layer2ID; // ears
	int layer3ID; // eyes
	int layer3aID; // face feat
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

	public Image layer0, layer1, layer2, layer3, layer3a, layer4,layer5, layer6, layer7, layer8, layer9, layer10, layer11, layer12,layer13, layer14, layer15,layer16; 

	public void selfDes(){
		Destroy (self);
	}

	void spriteUpdater()
	{
		Debug.Log ("sprite updated start");

		Debug.Log (NPCCharList.CharMonster [0].charPortraitLayer0.ToString());
		Debug.Log (NPCCharList.CharMonster [0].charPortraitLayer1.ToString());
		Debug.Log (NPCCharList.CharMonster [0].charPortraitLayer2.ToString());

		layer0.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer0/" + NPCCharList.CharMonster [0].charPortraitLayer0) as Sprite;
		layer1.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer1/" + NPCCharList.CharMonster [0].charPortraitLayer1) as Sprite;
		layer2.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer2/" + NPCCharList.CharMonster [0].charPortraitLayer2) as Sprite;
		layer3.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer3/" + NPCCharList.CharMonster [0].charPortraitLayer3) as Sprite;
		layer3a.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer3a/" + NPCCharList.CharMonster [0].charPortraitLayer3a) as Sprite;
		layer4.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer4/" + NPCCharList.CharMonster [0].charPortraitLayer4) as Sprite;
		layer5.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer5/" + NPCCharList.CharMonster [0].charPortraitLayer5) as Sprite;
		layer6.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer6/" + NPCCharList.CharMonster [0].charPortraitLayer6) as Sprite;
		layer7.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer7/" + NPCCharList.CharMonster [0].charPortraitLayer7) as Sprite;
		layer8.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer8/" + NPCCharList.CharMonster [0].charPortraitLayer8) as Sprite;
		layer9.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer9/" + NPCCharList.CharMonster [0].charPortraitLayer9) as Sprite;
		layer10.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer10/"+NPCCharList.CharMonster [0].charPortraitLayer10) as Sprite;
		layer11.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer11/" + NPCCharList.CharMonster [0].charPortraitLayer11) as Sprite;
		layer12.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer12/" + NPCCharList.CharMonster [0].charPortraitLayer12) as Sprite;
		layer13.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer13/" + NPCCharList.CharMonster [0].charPortraitLayer13) as Sprite;
		layer14.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer14/" + NPCCharList.CharMonster [0].charPortraitLayer14) as Sprite;
		layer15.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer15/" + NPCCharList.CharMonster [0].charPortraitLayer15) as Sprite;
		layer16.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer16/" + NPCCharList.CharMonster [0].charPortraitLayer16) as Sprite;
		/*

		layer0ID = NPCCharList.CharMonster [0].charPortraitLayer0;
		layer1ID =  NPCCharList.CharMonster [0].charPortraitLayer1;
		layer2ID =  NPCCharList.CharMonster [0].charPortraitLayer2;
		layer3ID =  NPCCharList.CharMonster [0].charPortraitLayer3;
		layer4ID =  NPCCharList.CharMonster [0].charPortraitLayer4;
		layer5ID =  NPCCharList.CharMonster [0].charPortraitLayer5;
		layer6ID =  NPCCharList.CharMonster [0].charPortraitLayer6; 
		layer7ID =  NPCCharList.CharMonster [0].charPortraitLayer7;
		layer8ID =  NPCCharList.CharMonster [0].charPortraitLayer8;
		layer9ID =  NPCCharList.CharMonster [0].charPortraitLayer9; 
		layer10ID =  NPCCharList.CharMonster [0].charPortraitLayer10;
		layer11ID =  NPCCharList.CharMonster [0].charPortraitLayer11;
		layer12ID =  NPCCharList.CharMonster [0].charPortraitLayer12; 
		layer13ID =  NPCCharList.CharMonster [0].charPortraitLayer13;
		layer14ID = NPCCharList.CharMonster [0].charPortraitLayer14;
		layer15ID =  NPCCharList.CharMonster [0].charPortraitLayer15; 
		layer16ID =  NPCCharList.CharMonster [0].charPortraitLayer16;

		layer0.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer0/" + layer0ID) as Sprite;
		layer1.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer1/" + layer1ID) as Sprite;
		layer2.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer2/" + layer2ID) as Sprite;
		layer3.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer3/" + layer3ID) as Sprite;
		layer4.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer4/" + layer4ID) as Sprite;
		layer5.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer5/" + layer5ID) as Sprite;
		layer6.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer6/" + layer6ID) as Sprite;
		layer7.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer7/" + layer7ID) as Sprite;
		layer8.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer8/" + layer8ID) as Sprite;
		layer9.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer9/" + layer9ID) as Sprite;
		layer10.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer10/" + layer10ID) as Sprite;
		layer11.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer11/" + layer11ID) as Sprite;
		layer12.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer12/" + layer12ID) as Sprite;
		layer13.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer13/" + layer13ID) as Sprite;
		layer14.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer14/" + layer14ID) as Sprite;
		layer15.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer15/" + layer15ID) as Sprite;
		layer16.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer16/" + layer16ID) as Sprite;
		*/


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
		if (layer3a.sprite == null) {
			layer3a.sprite = Resources.Load<Sprite> ("Portraits/NPC/Followers/" + 0)as Sprite;; 
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
		Debug.Log ("Start Enemy Portrait");

		idxCurrent = 10;
	}


	void Update () {
		Debug.Log ("update Enemy Portrait 1");

		if (idxCurrent != 0) {
			Debug.Log ("update Enemy Portrait 2");

			spriteUpdater ();
			idxCurrent--;
		}
		//layer0.sprite = Resources.Load<Sprite> ("Portraits/NPC/Generic/Layer0/" + WorldControl.NPCID ) as Sprite;
	}



}
