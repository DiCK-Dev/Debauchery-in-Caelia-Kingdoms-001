using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NPCEquipmentNames : MonoBehaviour {
	public Text equip0, equip1, equip2, equip3, equip4, equip5, equip6, equip7, equip8, equip9, equip10, equip11;

	void updateNames(){
		if (WorldControl.idx >= 0) {
			equip0.text = ItemData.itemDataList [NPCCharList.CharRetainers [WorldControl.idx].charEquipment [0]].itemName;
			equip1.text = ItemData.itemDataList [NPCCharList.CharRetainers [WorldControl.idx].charEquipment [1]].itemName;
			equip2.text = ItemData.itemDataList [NPCCharList.CharRetainers [WorldControl.idx].charEquipment [2]].itemName;
			equip3.text = ItemData.itemDataList [NPCCharList.CharRetainers [WorldControl.idx].charEquipment [3]].itemName;
			equip4.text = ItemData.itemDataList [NPCCharList.CharRetainers [WorldControl.idx].charEquipment [4]].itemName;
			equip5.text = ItemData.itemDataList [NPCCharList.CharRetainers [WorldControl.idx].charEquipment [5]].itemName;
			equip6.text = ItemData.itemDataList [NPCCharList.CharRetainers [WorldControl.idx].charEquipment [6]].itemName;

			equip7.text = ItemData.itemDataList [NPCCharList.CharRetainers [WorldControl.idx].charEquipment [7]].itemName;
			equip8.text = ItemData.itemDataList [NPCCharList.CharRetainers [WorldControl.idx].charEquipment [8]].itemName;
			equip9.text = ItemData.itemDataList [NPCCharList.CharRetainers [WorldControl.idx].charEquipment [9]].itemName;
			equip10.text = ItemData.itemDataList [NPCCharList.CharRetainers [WorldControl.idx].charEquipment [10]].itemName;
			equip11.text = ItemData.itemDataList [NPCCharList.CharRetainers [WorldControl.idx].charEquipment [11]].itemName;
		}

	}



	void Update () {
		updateNames ();


	}
}
