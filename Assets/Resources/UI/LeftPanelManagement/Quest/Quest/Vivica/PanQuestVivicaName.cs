using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PanQuestVivicaName : MonoBehaviour {


	nameVivicaQuest nameQuest = new nameVivicaQuest();

	public GameObject itemPrefab; 

	void Start () {
		GameObject QuestName = Instantiate (itemPrefab) as GameObject;
		QuestName.name = gameObject.name + " QuestName";
		QuestName.transform.parent = gameObject.transform;

		Text questname = QuestName.GetComponent<Text> ();
		questname.text = nameQuest.retName();
	}

}
