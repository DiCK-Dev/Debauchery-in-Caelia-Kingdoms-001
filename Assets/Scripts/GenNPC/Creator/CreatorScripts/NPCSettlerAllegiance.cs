using UnityEngine;
using System.Collections;

public class NPCSettlerAllegiance : MonoBehaviour {

	public NPCData.CityFaction setFaction(int selector)
	{
		if (selector == 0) {
			return NPCData.CityFaction.NONE;
		} else if (selector == 1) {
			return NPCData.CityFaction.ABBADON;
		} else if (selector == 2) {
			return NPCData.CityFaction.JUNIA;
		} else {
			return NPCData.CityFaction.NONE;

		}



	}


}
