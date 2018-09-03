using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BotPanelNPCSliders : MonoBehaviour {

	/*public Slider sliderHP;
	public Slider sliderArousal;
	public Slider sliderMP;
	public Text textHP;
	public Text textArousal;
	public Text textMP;

	string intactualhp;
	string intmaxhp;
	string intactualarousal;
	string intmaxarousal;
	string intactualmp;
	string intmaxmp; */

	public Slider sliderHP;
	public Slider sliderArousal;
	public Slider sliderMP;
	public Text textHP;
	public Text textArousal;
	public Text textMP;

	static int i;

	/*
	public void loadNPC(){

		if (WorldControl.NPCID != 0) {
			

			i = 0;
			while (i < NPCCharList.CharRetainers.Count) {
				if (NPCCharList.CharRetainers[i].charID == WorldControl.NPCID) {

					break;
				}

				i++;
			}
			sliderHP.maxValue = NPCCharList.CharRetainers[i].maxHealth;
			sliderArousal.maxValue = NPCCharList.CharRetainers[i].maxArousal;
			sliderMP.maxValue = NPCCharList.CharRetainers[i].maxMP;
			sliderMP.maxValue = 0;
			intmaxhp = NPCCharList.CharRetainers[i].maxHealth.ToString ();
			intmaxarousal = NPCCharList.CharRetainers[i].maxArousal.ToString ();
			intmaxmp = NPCCharList.CharRetainers[i].maxMP.ToString ();
			intmaxmp = "0";


		}



	}*/



	void Start(){

		i = loadChar (WorldControl.NPCID);

		sliderHP.maxValue =  NPCCharList.CharFollower[i].maxHealth;
		sliderArousal.maxValue = NPCCharList.CharFollower[i].maxArousal;
		sliderMP.maxValue =  NPCCharList.CharFollower[i].maxMP;


	}

	void Update () {
		sliderHP.value = NPCCharList.CharFollower [i].currentHealth;
		sliderArousal.value = NPCCharList.CharFollower [i].currentArousal;
		sliderMP.value = NPCCharList.CharFollower [i].currentMP;

		textHP.text = Mathf.Round( NPCCharList.CharFollower [i].currentHealth).ToString() + "/" + NPCCharList.CharFollower [i].maxHealth.ToString ();
		textArousal.text = Mathf.Round(NPCCharList.CharFollower [i].currentArousal).ToString() + "/" + NPCCharList.CharFollower [i].maxArousal.ToString ();
		textMP.text = Mathf.Round(NPCCharList.CharFollower [i].currentMP).ToString()+ "/"+ NPCCharList.CharFollower [i].maxMP.ToString ();

		/*
		if (WorldControl.NPCID != 0) {

			//intactualhp =  GameControl.actualHealth.ToString ();
			intactualhp = "100";

			//intactualarousal = GameControl.actualArousal.ToString ();
			intactualarousal = "0";

			//intactualmp = GameControl.actualMP.ToString ();
			intactualmp = "0";

			sliderHP.value = 100; 
			//	sliderHP.value = NPCCharList.CharList [i].actualHealth; 


			sliderArousal.value = 0;
			//	sliderArousal.value = NPCCharList.CharList [i].actualArousal; 


			sliderMP.value = 0;
			//sliderMP.value = NPCCharList.CharList [i].actualMP;


			textHP.text = intactualhp + " / " + intmaxhp;
			textArousal.text = intactualarousal + " / " + intmaxarousal;
			textMP.text = intactualmp + " / " + intmaxmp; 
		}*/





	}


	int loadChar(int id){
		i = 0;
		while (i < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [i].charID == id){
				return i;
			}
			i++;

		}
		return 0;

	}
}
