using UnityEngine;
using System.Collections;

public class HelenaTransformation  {
	static int iHelena = 0;

	public static void helenaOutfitMaid(){
		loadHelena ();
		NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3000;
		if (NPCCharList.CharFollower [iHelena].attWillpower >= 66) {
			NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3220;

		}
		helenaUpdatePortrait ();

	}

	public static void helenaOutfitMaidOpen(){
		loadHelena ();
		NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3070;
		if (NPCCharList.CharFollower [iHelena].attWillpower >= 66) {
			NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3240;

		}
		helenaUpdatePortrait ();

	} 

	public static void helenaOutfitCorrupt0(){
		loadHelena ();
		NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3040;
		helenaUpdatePortrait ();
	}

	public static void helenaOutfitNaked(){
		loadHelena ();
		NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3020;
		if (NPCCharList.CharFollower [iHelena].attWillpower >= 66) {
			NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3200;

		}
		helenaUpdatePortrait ();
	}


	public static void helenaOutDominatrix(){
		loadHelena ();
		NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3250;
		helenaUpdatePortrait ();
	}


	public static void increaseBreasts(){
		loadHelena ();
		NPCSettlerBody npcSettlerBody = new NPCSettlerBody();
		if (NPCCharList.CharFollower [iHelena].breast1Size < 20) {
			NPCCharList.CharFollower [iHelena].breast1Cup += 5;
			NPCCharList.CharFollower [iHelena].breast1Size += 5;
			NPCCharList.CharFollower [iHelena].breast1Name = npcSettlerBody.setBreastName (NPCCharList.CharFollower [iHelena].breast1Size);
			helenaUpdatePortrait ();
		}
		helenaUpdateSex ();


	}

	public static void decreaseBreasts(){
		loadHelena ();
		NPCSettlerBody npcSettlerBody = new NPCSettlerBody();
		if (NPCCharList.CharFollower [iHelena].breast1Size > 0) {

			NPCCharList.CharFollower [iHelena].breast1Cup -= 5;
			NPCCharList.CharFollower [iHelena].breast1Size -= 5;
			NPCCharList.CharFollower [iHelena].breast1Name = npcSettlerBody.setBreastName (NPCCharList.CharFollower [iHelena].breast1Size);
			helenaUpdatePortrait ();
		}
		helenaUpdateSex ();
	}

	public static void increaseDick(){
		loadHelena ();
		NPCSettlerBody npcSettlerBody = new NPCSettlerBody();
		if (NPCCharList.CharFollower [iHelena].dickSizeCM < 50) {
			NPCCharList.CharFollower [iHelena].dickSizeCM += 13;
			NPCCharList.CharFollower [iHelena].dickSize= npcSettlerBody.setDickSize (NPCCharList.CharFollower [iHelena].dickSizeCM);
			helenaUpdatePortrait ();
		}
		helenaUpdateSex ();
	}

	public static void decreaseDick(){
		loadHelena ();
		NPCSettlerBody npcSettlerBody = new NPCSettlerBody();
		if (NPCCharList.CharFollower [iHelena].dickSizeCM > 0) {
			NPCCharList.CharFollower [iHelena].dickSizeCM -= 13;
			NPCCharList.CharFollower [iHelena].dickSize = npcSettlerBody.setDickSize (NPCCharList.CharFollower [iHelena].dickSizeCM);
			helenaUpdatePortrait ();
		}
		helenaUpdateSex ();
	}




	public static void helenaUpdatePortrait(){
		loadHelena ();



		//normal
		if (NPCCharList.CharFollower [iHelena].charPortraitLayer0 >= 3000 && NPCCharList.CharFollower [iHelena].charPortraitLayer0 < 3020) {
				
				if (NPCCharList.CharFollower [iHelena].breast1Size <= 4) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3000;
				} else if (NPCCharList.CharFollower [iHelena].breast1Size > 0 && NPCCharList.CharFollower [iHelena].breast1Size <= 5) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3001;
				} else if (NPCCharList.CharFollower [iHelena].breast1Size > 5 && NPCCharList.CharFollower [iHelena].breast1Size <= 10) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3002;
				} else if (NPCCharList.CharFollower [iHelena].breast1Size > 10 && NPCCharList.CharFollower [iHelena].breast1Size <= 15) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3003;
				} else {
					NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3004;
				}


				if (NPCCharList.CharFollower [iHelena].dickSizeCM > 40) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 3010;
				}else {
					NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 0;
				}

		}
		//normal dom 
		if (NPCCharList.CharFollower [iHelena].charPortraitLayer0 >= 3220 && NPCCharList.CharFollower [iHelena].charPortraitLayer0 < 3230) {

			if (NPCCharList.CharFollower [iHelena].breast1Size <= 4) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3220;
			} else if (NPCCharList.CharFollower [iHelena].breast1Size > 0 && NPCCharList.CharFollower [iHelena].breast1Size <= 5) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3221;
			} else if (NPCCharList.CharFollower [iHelena].breast1Size > 5 && NPCCharList.CharFollower [iHelena].breast1Size <= 10) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3222;
			} else if (NPCCharList.CharFollower [iHelena].breast1Size > 10 && NPCCharList.CharFollower [iHelena].breast1Size <= 15) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3223;
			} else {
				NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3224;
			}


			if (NPCCharList.CharFollower [iHelena].dickSizeCM > 40) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 3230;
			}else {
				NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 0;
			}

		}

		//maid open dom 
		if (NPCCharList.CharFollower [iHelena].charPortraitLayer0 >= 3240 && NPCCharList.CharFollower [iHelena].charPortraitLayer0 < 3250) {

			if (NPCCharList.CharFollower [iHelena].breast1Size <= 4) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3240;
			} else if (NPCCharList.CharFollower [iHelena].breast1Size > 0 && NPCCharList.CharFollower [iHelena].breast1Size <= 5) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3241;
			} else if (NPCCharList.CharFollower [iHelena].breast1Size > 5 && NPCCharList.CharFollower [iHelena].breast1Size <= 10) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3242;
			} else if (NPCCharList.CharFollower [iHelena].breast1Size > 10 && NPCCharList.CharFollower [iHelena].breast1Size <= 15) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3243;
			} else {
				NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3244;
			}


			if (NPCCharList.CharFollower [iHelena].dickSizeCM > 40) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 3230;
			}else {
				NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 0;
			}

		}
		//maid open
		if (NPCCharList.CharFollower [iHelena].charPortraitLayer0 >= 3070 && NPCCharList.CharFollower [iHelena].charPortraitLayer0 < 3090) {

				if (NPCCharList.CharFollower [iHelena].breast1Size <= 4) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3070;
				} else if (NPCCharList.CharFollower [iHelena].breast1Size > 0 && NPCCharList.CharFollower [iHelena].breast1Size <= 5) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3071;
				} else if (NPCCharList.CharFollower [iHelena].breast1Size > 5 && NPCCharList.CharFollower [iHelena].breast1Size <= 10) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3072;
				} else if (NPCCharList.CharFollower [iHelena].breast1Size > 10 && NPCCharList.CharFollower [iHelena].breast1Size <= 15) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3073;
				} else {
					NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3074;
				}


				if (NPCCharList.CharFollower [iHelena].dickSizeCM > 40) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 3010;
				}else {
					NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 0;
				}

			}


		//naked dom
		if (NPCCharList.CharFollower [iHelena].charPortraitLayer0 >= 3200 && NPCCharList.CharFollower [iHelena].charPortraitLayer0 < 3210) {

			if (NPCCharList.CharFollower [iHelena].breast1Size <= 4) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3200;
			} else if (NPCCharList.CharFollower [iHelena].breast1Size > 0 && NPCCharList.CharFollower [iHelena].breast1Size <= 5) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3201;
			} else if (NPCCharList.CharFollower [iHelena].breast1Size > 5 && NPCCharList.CharFollower [iHelena].breast1Size <= 10) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3202;
			} else if (NPCCharList.CharFollower [iHelena].breast1Size > 10 && NPCCharList.CharFollower [iHelena].breast1Size <= 15) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3203;
			} else {
				NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3204;
			}


			if (NPCCharList.CharFollower [iHelena].dickSizeCM <= 4) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 0;
			} else if (NPCCharList.CharFollower [iHelena].dickSizeCM > 4 && NPCCharList.CharFollower [iHelena].dickSizeCM < 15) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 3210;
			} else if (NPCCharList.CharFollower [iHelena].dickSizeCM >= 15 && NPCCharList.CharFollower [iHelena].dickSizeCM < 30) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 3211;
			} else if (NPCCharList.CharFollower [iHelena].dickSizeCM>= 30 && NPCCharList.CharFollower [iHelena].dickSizeCM < 45) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 3212;
			}  else {
				NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 3213;
			}
		}


			// naked
		if (NPCCharList.CharFollower [iHelena].charPortraitLayer0 >= 3020 && NPCCharList.CharFollower [iHelena].charPortraitLayer0 < 3040) {

				if (NPCCharList.CharFollower [iHelena].breast1Size <= 4) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3020;
				} else if (NPCCharList.CharFollower [iHelena].breast1Size > 0 && NPCCharList.CharFollower [iHelena].breast1Size <= 5) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3021;
				} else if (NPCCharList.CharFollower [iHelena].breast1Size > 5 && NPCCharList.CharFollower [iHelena].breast1Size <= 10) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3022;
				} else if (NPCCharList.CharFollower [iHelena].breast1Size > 10 && NPCCharList.CharFollower [iHelena].breast1Size <= 15) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3023;
				} else {
					NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3024;
				}


				if (NPCCharList.CharFollower [iHelena].dickSizeCM <= 4) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 0;
				} else if (NPCCharList.CharFollower [iHelena].dickSizeCM > 4 && NPCCharList.CharFollower [iHelena].dickSizeCM < 15) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 3030;
				} else if (NPCCharList.CharFollower [iHelena].dickSizeCM >= 15 && NPCCharList.CharFollower [iHelena].dickSizeCM < 30) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 3031;
				} else if (NPCCharList.CharFollower [iHelena].dickSizeCM>= 30 && NPCCharList.CharFollower [iHelena].dickSizeCM < 45) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 3032;
				}  else {
					NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 3033;
				}
			}

			//naked
		if (NPCCharList.CharFollower [iHelena].charPortraitLayer0 >= 3040 && NPCCharList.CharFollower [iHelena].charPortraitLayer0 < 3060) {

				if (NPCCharList.CharFollower [iHelena].breast1Size <= 4) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3040;
				} else if (NPCCharList.CharFollower [iHelena].breast1Size > 0 && NPCCharList.CharFollower [iHelena].breast1Size <= 5) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3041;
				} else if (NPCCharList.CharFollower [iHelena].breast1Size > 5 && NPCCharList.CharFollower [iHelena].breast1Size <= 10) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3042;
				} else if (NPCCharList.CharFollower [iHelena].breast1Size > 10 && NPCCharList.CharFollower [iHelena].breast1Size <= 15) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3043;
				} else {
					NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3044;
				}

				if (NPCCharList.CharFollower [iHelena].dickSizeCM <= 4) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 0;
				} else if (NPCCharList.CharFollower [iHelena].dickSizeCM > 4 && NPCCharList.CharFollower [iHelena].dickSizeCM < 15) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 3030;
				} else if (NPCCharList.CharFollower [iHelena].dickSizeCM >= 15 && NPCCharList.CharFollower [iHelena].dickSizeCM < 30) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 3031;
				} else if (NPCCharList.CharFollower [iHelena].dickSizeCM>= 30 && NPCCharList.CharFollower [iHelena].dickSizeCM < 45) {
					NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 3032;
				}  else {
					NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 3033;
				}
			}

		//dominatrix 
		if (NPCCharList.CharFollower [iHelena].charPortraitLayer0 >= 3250 && NPCCharList.CharFollower [iHelena].charPortraitLayer0 < 3260) {

			if (NPCCharList.CharFollower [iHelena].breast1Size <= 4) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3250;
			} else if (NPCCharList.CharFollower [iHelena].breast1Size > 0 && NPCCharList.CharFollower [iHelena].breast1Size <= 5) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3251;
			} else if (NPCCharList.CharFollower [iHelena].breast1Size > 5 && NPCCharList.CharFollower [iHelena].breast1Size <= 10) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3252;
			} else if (NPCCharList.CharFollower [iHelena].breast1Size > 10 && NPCCharList.CharFollower [iHelena].breast1Size <= 15) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3253;
			} else {
				NPCCharList.CharFollower [iHelena].charPortraitLayer0 = 3254;
			}


			if (NPCCharList.CharFollower [iHelena].dickSizeCM <= 4) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 0;
			} else if (NPCCharList.CharFollower [iHelena].dickSizeCM > 4 && NPCCharList.CharFollower [iHelena].dickSizeCM < 15) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 3260;
			} else if (NPCCharList.CharFollower [iHelena].dickSizeCM >= 15 && NPCCharList.CharFollower [iHelena].dickSizeCM < 30) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 3261;
			} else if (NPCCharList.CharFollower [iHelena].dickSizeCM>= 30 && NPCCharList.CharFollower [iHelena].dickSizeCM < 45) {
				NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 3262;
			}  else {
				NPCCharList.CharFollower [iHelena].charPortraitLayer1 = 3263;
			}

		}
		

	
	}


	public static void helenaUpdateSex(){
		loadHelena ();
		if (NPCCharList.CharFollower [iHelena].dickSizeCM > 0) {
			//futa
			NPCCharList.CharFollower[iHelena].charSex = NPCData.CharSex.Futanari;

		} else{
			//woman
			NPCCharList.CharFollower[iHelena].charSex = NPCData.CharSex.Woman;
		}


	}


	static void loadHelena(){
		iHelena = 0;
		while (iHelena < NPCCharList.CharFollower.Count)
		{
			if (NPCCharList.CharFollower [iHelena].charID == 3000 ) 
			{
				break; 
			}
			iHelena++;
		}
	}

}
