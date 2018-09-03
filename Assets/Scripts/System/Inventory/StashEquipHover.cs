using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StashEquipHover : MonoBehaviour {

	public GameObject hover1; 
	public GameObject hover2; 
	public GameObject hover3; 
	public GameObject hover4; 
	public GameObject hover5; 


	public Text itemDescription1;
	public Text itemDescription2;
	public Text itemDescription3;
	public Text itemDescription4;
	public Text itemDescription5;

	public Text itemName1;
	public Text itemName2;
	public Text itemName3;
	public Text itemName4;
	public Text itemName5;
	int i; 

	public void textHover1()
	{
		itemName1.text = ItemData.itemDataList [WorldControl.stashEquip [0, 0]].itemName; 
		itemDescription1.text = ItemData.itemDataList [WorldControl.stashEquip [0, 0]].itemDescription; 

	}
	public void textHover2(){

		itemName2.text = ItemData.itemDataList [WorldControl.stashEquip [1, 0]].itemName; 
		itemDescription2.text = ItemData.itemDataList [WorldControl.stashEquip [1, 0]].itemDescription; 
	}
	public void textHover3(){
		itemName3.text = ItemData.itemDataList [WorldControl.stashEquip [2, 0]].itemName; 
		itemDescription3.text = ItemData.itemDataList [WorldControl.stashEquip [2, 0]].itemDescription; 

	}
	public void textHover4(){
		itemName4.text = ItemData.itemDataList [WorldControl.stashEquip [3, 0]].itemName; 
		itemDescription4.text = ItemData.itemDataList [WorldControl.stashEquip [3, 0]].itemDescription; 
	}
	public void textHover5(){
		itemName5.text = ItemData.itemDataList [WorldControl.stashEquip [4, 0]].itemName; 
		itemDescription5.text = ItemData.itemDataList [WorldControl.stashEquip [4, 0]].itemDescription; 
	}


	public void deactHover()
	{
		if (WorldControl.stashEquip [0, 0] == 0) {
			hover1.SetActive (false);
		} else {
			hover1.SetActive (true);
		}
		if (WorldControl.stashEquip [1, 0] == 0) {
			hover2.SetActive (false);
		} else {
			hover2.SetActive (true);
		}
		if (WorldControl.stashEquip [2, 0] == 0) {
			hover3.SetActive (false);
		} else {
			hover3.SetActive (true);
		}
		if (WorldControl.stashEquip [3, 0] == 0) {
			hover4.SetActive (false);
		} else {
			hover4.SetActive (true);
		}
		if (WorldControl.stashEquip [4, 0] == 0) {
			hover5.SetActive (false);
		} else {
			hover5.SetActive (true);
		}


	}


	void awake () {


	}
	void Start () {


	}


	void Update () {
		deactHover ();
		textHover1 ();
		textHover2 ();
		textHover3 ();
		textHover4 ();
		textHover5 ();

	}
}
