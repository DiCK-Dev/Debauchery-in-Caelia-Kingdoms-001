using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LeftPanelQuestCreateName : MonoBehaviour {

	nameMainQuest nameQuest = new nameMainQuest();

	public GameObject itemPrefab; 

	public void initFun(){
		Debug.Log ("createname and questindex is "+ QuestsController.questIndex.ToString() );



		GameObject QuestName = Instantiate (itemPrefab) as GameObject;
		QuestName.name = gameObject.name + " QuestName";
		QuestName.transform.parent = gameObject.transform;

		Text questname = QuestName.GetComponent<Text> ();
		questname.text = QuestsController.ActiveQuests[QuestsController.questIndex].name;
		Debug.Log ("questname.text is "+ QuestsController.ActiveQuests[QuestsController.questIndex].name );


	}


	void Start () {



		/*GameObject QuestName = Instantiate (itemPrefab) as GameObject;
		QuestName.name = gameObject.name + " QuestName";
		QuestName.transform.parent = gameObject.transform;

		Text questname = QuestName.GetComponent<Text> ();
		questname.text = nameQuest.retName ();*/



	}



}
