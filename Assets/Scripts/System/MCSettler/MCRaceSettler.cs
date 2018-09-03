using UnityEngine;
using System.Collections;

public class MCRaceSettler  {

	public static void updateRace(){

		if (GameControl.mcHead == GameControl.MCHead.HUMAN && GameControl.mcLegs == GameControl.MCLegs.HUMAN && GameControl.mcArms == GameControl.MCArms.HUMAN && GameControl.mcTailType == GameControl.MCTailType.NONE && GameControl.mcShoulderBlades == GameControl.MCShoulderBlades.NONE && GameControl.mcHeadAccesory1 == GameControl.MCHeadAccesory1.NONE && GameControl.mcHeadAccesory2 == GameControl.MCHeadAccesory2.NONE) {
			GameControl.mcRace = GameControl.MCRace.Human;
			return;
		} else if (GameControl.mcHead == GameControl.MCHead.WOLF && GameControl.mcLegs == GameControl.MCLegs.WOLF && GameControl.mcArms == GameControl.MCArms.WOLF && GameControl.mcTailType == GameControl.MCTailType.Wolf && GameControl.mcShoulderBlades == GameControl.MCShoulderBlades.NONE && GameControl.mcHeadAccesory1 == GameControl.MCHeadAccesory1.NONE && GameControl.mcHeadAccesory2 == GameControl.MCHeadAccesory2.NONE) {
			GameControl.mcRace = GameControl.MCRace.Wolf;
			return;
		} else {
			GameControl.mcRace = GameControl.MCRace.Hybrid;
			return;
		}

	}
}
