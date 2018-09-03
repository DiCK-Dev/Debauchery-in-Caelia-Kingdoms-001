using UnityEngine;
using System.Collections;

public class AlbaTransformation  {
	static int iAlba = 0;

	static public void increaseBreasts (){
		loadAlba ();
		NPCSettlerBody npcSettlerBody = new NPCSettlerBody();
		if (NPCCharList.CharFollower [iAlba].breast1Size < 20) {
			NPCCharList.CharFollower [iAlba].breast1Cup += 5;
			NPCCharList.CharFollower [iAlba].breast1Size += 5;
			NPCCharList.CharFollower [iAlba].breast1Name = npcSettlerBody.setBreastName (NPCCharList.CharFollower [iAlba].breast1Size);
			albaUpdatePortrait ();
		}
		albaUpdateSex ();


	}

	static public void increaseDick(){
		loadAlba ();
		NPCSettlerBody npcSettlerBody = new NPCSettlerBody();
		if (NPCCharList.CharFollower [iAlba].dickSizeCM < 50) {
			NPCCharList.CharFollower [iAlba].dickSizeCM += 10;
			NPCCharList.CharFollower [iAlba].dickSize= npcSettlerBody.setDickSize (NPCCharList.CharFollower [iAlba].dickSizeCM);
			albaUpdatePortrait ();
		}
		albaUpdateSex ();
	}

	static public void decreaseBreasts(){
		loadAlba ();
		NPCSettlerBody npcSettlerBody = new NPCSettlerBody();
		if (NPCCharList.CharFollower [iAlba].breast1Size > 0) {

			NPCCharList.CharFollower [iAlba].breast1Cup -= 5;
			NPCCharList.CharFollower [iAlba].breast1Size -= 5;
			NPCCharList.CharFollower [iAlba].breast1Name = npcSettlerBody.setBreastName (NPCCharList.CharFollower [iAlba].breast1Size);
			albaUpdatePortrait ();
		}
		albaUpdateSex ();
	}

	static public void decreaseDick(){
		loadAlba ();
		NPCSettlerBody npcSettlerBody = new NPCSettlerBody();
		if (NPCCharList.CharFollower [iAlba].dickSizeCM > 0) {
			NPCCharList.CharFollower [iAlba].dickSizeCM -= 10;
			NPCCharList.CharFollower [iAlba].dickSize = npcSettlerBody.setDickSize (NPCCharList.CharFollower [iAlba].dickSizeCM);
			albaUpdatePortrait ();
		}
		albaUpdateSex ();
	}

	public static void albaUpdateSex(){
		if (NPCCharList.CharFollower [iAlba].dickSizeCM > 0) {
			//futa
			NPCCharList.CharFollower[iAlba].charSex = NPCData.CharSex.Futanari;

		} else{
			//woman
			NPCCharList.CharFollower[iAlba].charSex = NPCData.CharSex.Woman;
		}


	}




	public static void albaUpdatePortrait(){
		


		//normal
		if (NPCCharList.CharFollower [iAlba].charPortraitLayer0 >= 13000 && NPCCharList.CharFollower [iAlba].charPortraitLayer0 < 13020) {

			if (NPCCharList.CharFollower [iAlba].breast1Size <= 4 && NPCCharList.CharFollower [iAlba].dickSizeCM <= 0) {
				NPCCharList.CharFollower [iAlba].charPortraitLayer0 = 13000;
			}else if (NPCCharList.CharFollower [iAlba].breast1Size < 5) {
				NPCCharList.CharFollower [iAlba].charPortraitLayer0 = 13001;
			} else if (NPCCharList.CharFollower [iAlba].breast1Size < 10) {
				NPCCharList.CharFollower [iAlba].charPortraitLayer0 = 13002;
			} else if (NPCCharList.CharFollower [iAlba].breast1Size < 15) {
				NPCCharList.CharFollower [iAlba].charPortraitLayer0 = 13003;
			} else if (NPCCharList.CharFollower [iAlba].breast1Size < 20) {
				NPCCharList.CharFollower [iAlba].charPortraitLayer0 = 13004;
			} else {
				NPCCharList.CharFollower [iAlba].charPortraitLayer0 = 13004;
			}


			if (NPCCharList.CharFollower [iAlba].dickSizeCM <= 0) {
				NPCCharList.CharFollower [iAlba].charPortraitLayer1 = 0;
			}else if (NPCCharList.CharFollower [iAlba].dickSizeCM < 20) {
				NPCCharList.CharFollower [iAlba].charPortraitLayer1 = 13010;
			}else if (NPCCharList.CharFollower [iAlba].dickSizeCM < 30) {
				NPCCharList.CharFollower [iAlba].charPortraitLayer1 = 13011;
			}else if (NPCCharList.CharFollower [iAlba].dickSizeCM < 40) {
				NPCCharList.CharFollower [iAlba].charPortraitLayer1 = 13012;
			}else {
				NPCCharList.CharFollower [iAlba].charPortraitLayer1 = 13013;
			}

		}
			

	}


	static void loadAlba(){
		iAlba = 0;
		while (iAlba < NPCCharList.CharFollower.Count)
		{
			if (NPCCharList.CharFollower [iAlba].charID == 13000 ) 
			{
				break; 
			}
			iAlba++;
		}
	}


}
