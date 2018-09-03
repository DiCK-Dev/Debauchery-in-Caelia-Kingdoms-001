using UnityEngine;
using System.Collections;

public class AbbadonTransformation {
	static int iAbbadon = 0;

	public static void increaseBreasts(){
		loadAbbadon ();
		NPCSettlerBody npcSettlerBody = new NPCSettlerBody();
		if (NPCCharList.CharFollower [iAbbadon].breast1Size < 15) {
			NPCCharList.CharFollower [iAbbadon].breast1Cup += 5;
			NPCCharList.CharFollower [iAbbadon].breast1Size += 5;
			NPCCharList.CharFollower [iAbbadon].breast1Name = npcSettlerBody.setBreastName (NPCCharList.CharFollower [iAbbadon].breast1Size);
			abbadonUpdatePortrait ();
		}
		abbadonUpdateSex ();


	}

	public static void decreaseBreasts(){
		loadAbbadon ();
		NPCSettlerBody npcSettlerBody = new NPCSettlerBody();
		if (NPCCharList.CharFollower [iAbbadon].breast1Size > 0) {
			
			NPCCharList.CharFollower [iAbbadon].breast1Cup -= 5;
			NPCCharList.CharFollower [iAbbadon].breast1Size -= 5;
			NPCCharList.CharFollower [iAbbadon].breast1Name = npcSettlerBody.setBreastName (NPCCharList.CharFollower [iAbbadon].breast1Size);
			abbadonUpdatePortrait ();
		}
		abbadonUpdateSex ();
	}

	public static void increaseDick(){
		loadAbbadon ();
		NPCSettlerBody npcSettlerBody = new NPCSettlerBody();
		if (NPCCharList.CharFollower [iAbbadon].dickSizeCM < 50) {
			NPCCharList.CharFollower [iAbbadon].dickSizeCM += 13;
			NPCCharList.CharFollower [iAbbadon].dickSize= npcSettlerBody.setDickSize (NPCCharList.CharFollower [iAbbadon].dickSizeCM);
			abbadonUpdatePortrait ();
		}
		abbadonUpdateSex ();
	}

	public static void decreaseDick(){
		loadAbbadon ();
		NPCSettlerBody npcSettlerBody = new NPCSettlerBody();
		if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 0) {
			NPCCharList.CharFollower [iAbbadon].dickSizeCM -= 13;
			NPCCharList.CharFollower [iAbbadon].dickSize = npcSettlerBody.setDickSize (NPCCharList.CharFollower [iAbbadon].dickSizeCM);
			abbadonUpdatePortrait ();
		}
		abbadonUpdateSex ();
	}


	public static void abbadonOutfitNormal(){
		loadAbbadon ();
		NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1000;
		if (NPCCharList.CharFollower [iAbbadon].isFurry) {
			NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1510;
		}
		abbadonUpdatePortrait ();

	}

	public static void abbadonOutfitCorrupt0(){
		loadAbbadon ();
		NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1020;

		if (NPCCharList.CharFollower [iAbbadon].isFurry) {
			NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1520;
		}
		abbadonUpdatePortrait ();
	}

	public static void abbadonOutfitNaked(){
		loadAbbadon ();
		NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1040;

		if (NPCCharList.CharFollower [iAbbadon].isFurry) {
			NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1500;
		}
		abbadonUpdatePortrait ();
	}



	public static void abbadonUpdatePortrait(){
		loadAbbadon ();
		NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 0;
		NPCCharList.CharFollower [iAbbadon].charPortraitLayer2 = 0;
		//normal
		if (NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 >= 1000 && NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 < 1020) {
			if (NPCCharList.CharFollower [iAbbadon].breast1Size <= 4) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1000;
			} else if (NPCCharList.CharFollower [iAbbadon].breast1Size > 4 && NPCCharList.CharFollower [iAbbadon].breast1Size < 10) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1001;
			} else if (NPCCharList.CharFollower [iAbbadon].breast1Size >= 10 && NPCCharList.CharFollower [iAbbadon].breast1Size < 15) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1002;
			} else {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1003;
			}


			if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 40) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 1010;
			}else {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 0;
			}

		}

		// corrupt
		if (NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 >= 1020 && NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 < 1040) {
			if (NPCCharList.CharFollower [iAbbadon].breast1Size <= 4) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1020;
			} else if (NPCCharList.CharFollower [iAbbadon].breast1Size > 4 && NPCCharList.CharFollower [iAbbadon].breast1Size < 10) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1021;
			} else if (NPCCharList.CharFollower [iAbbadon].breast1Size >= 10 && NPCCharList.CharFollower [iAbbadon].breast1Size < 15) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1022;
			} else {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1023;
			}


			if (NPCCharList.CharFollower [iAbbadon].dickSizeCM <= 4) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 0;
			} else if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 4 && NPCCharList.CharFollower [iAbbadon].dickSizeCM < 15) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 1030;
			} else if (NPCCharList.CharFollower [iAbbadon].dickSizeCM >= 15 && NPCCharList.CharFollower [iAbbadon].dickSizeCM < 30) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 1031;
			} else if (NPCCharList.CharFollower [iAbbadon].dickSizeCM>= 30 && NPCCharList.CharFollower [iAbbadon].dickSizeCM < 45) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 1032;
			}  else {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 1033;
			}
		}

		//naked
		if (NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 >= 1040 && NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 < 1060) {
			if (NPCCharList.CharFollower [iAbbadon].breast1Size <= 4) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1040;
			} else if (NPCCharList.CharFollower [iAbbadon].breast1Size > 4 && NPCCharList.CharFollower [iAbbadon].breast1Size < 10) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1041;
			} else if (NPCCharList.CharFollower [iAbbadon].breast1Size >= 10 && NPCCharList.CharFollower [iAbbadon].breast1Size < 15) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1042;
			} else {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1043;
			}

			if (NPCCharList.CharFollower [iAbbadon].dickSizeCM <= 4) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 0;
			} else if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 4 && NPCCharList.CharFollower [iAbbadon].dickSizeCM < 15) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 1050;
			} else if (NPCCharList.CharFollower [iAbbadon].dickSizeCM >= 15 && NPCCharList.CharFollower [iAbbadon].dickSizeCM < 30) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 1051;
			} else if (NPCCharList.CharFollower [iAbbadon].dickSizeCM>= 30 && NPCCharList.CharFollower [iAbbadon].dickSizeCM < 45) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 1052;
			}  else {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 1053;
			}
		}


		//naked furry
		if (NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 >= 1500 && NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 < 1510) {
			if (NPCCharList.CharFollower [iAbbadon].breast1Size <= 4) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1500;
			} else if (NPCCharList.CharFollower [iAbbadon].breast1Size > 4 && NPCCharList.CharFollower [iAbbadon].breast1Size < 10) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1501;
			} else if (NPCCharList.CharFollower [iAbbadon].breast1Size >= 10 && NPCCharList.CharFollower [iAbbadon].breast1Size < 15) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1502;
			} else {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1503;
			}

			if (NPCCharList.CharFollower [iAbbadon].dickSizeCM <= 4) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 0;
			} else if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 4 && NPCCharList.CharFollower [iAbbadon].dickSizeCM < 15) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 1505;
			} else if (NPCCharList.CharFollower [iAbbadon].dickSizeCM >= 15 && NPCCharList.CharFollower [iAbbadon].dickSizeCM < 30) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 1506;
			} else if (NPCCharList.CharFollower [iAbbadon].dickSizeCM>= 30 && NPCCharList.CharFollower [iAbbadon].dickSizeCM < 45) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 1507;
			}  else {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 1508;
			}
		}

		//normal furry
		if (NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 >= 1510 && NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 < 1520) {
			if (NPCCharList.CharFollower [iAbbadon].breast1Size <= 4) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1510;
			} else if (NPCCharList.CharFollower [iAbbadon].breast1Size > 4 && NPCCharList.CharFollower [iAbbadon].breast1Size < 10) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1511;
			} else if (NPCCharList.CharFollower [iAbbadon].breast1Size >= 10 && NPCCharList.CharFollower [iAbbadon].breast1Size < 15) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1512;
			} else {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1513;
			}


			if (NPCCharList.CharFollower [iAbbadon].dickSizeCM < 45) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 0;
			}  else {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 1515;
			}
		}


		//corrupt furry
		if (NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 >= 1520 && NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 < 1530) {

			if (NPCCharList.CharFollower [iAbbadon].dickSizeCM <= 4) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1520;
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 0;
			} else if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 4 && NPCCharList.CharFollower [iAbbadon].dickSizeCM < 15) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1525;
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 1505;
			} else if (NPCCharList.CharFollower [iAbbadon].dickSizeCM >= 15 && NPCCharList.CharFollower [iAbbadon].dickSizeCM < 30) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1525;
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 1506;
			} else if (NPCCharList.CharFollower [iAbbadon].dickSizeCM>= 30 && NPCCharList.CharFollower [iAbbadon].dickSizeCM < 45) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1525;
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 1507;
			}  else {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1525;
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer1 = 1508;
			}

			if (NPCCharList.CharFollower [iAbbadon].breast1Size <= 4) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer2 = 0;
			} else if (NPCCharList.CharFollower [iAbbadon].breast1Size > 4 && NPCCharList.CharFollower [iAbbadon].breast1Size < 10) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer2 = 1521;
			} else if (NPCCharList.CharFollower [iAbbadon].breast1Size >= 10 && NPCCharList.CharFollower [iAbbadon].breast1Size < 15) {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer2 = 1522;
			} else {
				NPCCharList.CharFollower [iAbbadon].charPortraitLayer2 = 1523;
			}


		}


	}


	public static void abbadonUpdateSex(){
		loadAbbadon ();
		if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 0 && NPCCharList.CharFollower [iAbbadon].breast1Size > 4) {
			//futa
			NPCCharList.CharFollower[iAbbadon].charSex = NPCData.CharSex.Futanari;

		} else if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 0 && NPCCharList.CharFollower [iAbbadon].breast1Size < 5 && NPCCharList.CharFollower[iAbbadon].charGender == NPCData.CharGender.MALE) {
			//man
			NPCCharList.CharFollower[iAbbadon].charSex = NPCData.CharSex.Man;

		}else if(NPCCharList.CharFollower[iAbbadon].dickSizeCM < 5 && NPCCharList.CharFollower[iAbbadon].breast1Size < 5 && NPCCharList.CharFollower[iAbbadon].charGender == NPCData.CharGender.MALE){
			// cuntboy
			NPCCharList.CharFollower[iAbbadon].charSex = NPCData.CharSex.Cuntboy;

		}else{
			//woman
			NPCCharList.CharFollower[iAbbadon].charSex = NPCData.CharSex.Woman;
		}


	}


	static void loadAbbadon(){
		iAbbadon = 0;
		while (iAbbadon < NPCCharList.CharFollower.Count)
		{
			if (NPCCharList.CharFollower [iAbbadon].charID == 1000 ) 
			{
				break; 
			}
			iAbbadon++;
		}
	}



}

