using UnityEngine;
using System.Collections;

public class MidManChangeJob : MonoBehaviour {

	// Use this for initialization
	public void changeJob (int job){
		int i = 0;
		if (WorldControl.NPCID != 0) {
			while (i < NPCCharList.CharRetainers.Count) {
				if (NPCCharList.CharRetainers [i].charID == WorldControl.NPCID) {
					NPCCharList.CharRetainers [i].cityJobs = (NPCData.Jobs)job;
					break;
				}
				i++;
			}
			MidManCreatePan.listchanged = true;
		}

	
	
	}



}
