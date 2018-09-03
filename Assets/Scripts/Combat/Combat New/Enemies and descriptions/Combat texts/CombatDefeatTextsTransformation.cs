using UnityEngine;
using System.Collections;

public class CombatDefeatTextsTransformation  {

	public static string mcForcedTransformation(){
		int randNum = UnityEngine.Random.Range (0, 100);
		if (randNum < 30) { // bigger breasts
			GameControl.breast1Size = GameControl.breast1Size + 4; 
			CharacteristicsSettler.setCharBreasts1Static ();
			return "After drinking the potion your breasts get bigger! Now they are " + GameControl.mcBreast1Name.ToString() + "!";

		} else if (randNum < 60) { // bigger cock
			GameControl.dick1Size += 4;
			GameControl.dick1Thick += 1.5f;
			CharacteristicsSettler.setCharDick1NameStatic ();
			return "After drinking the potion your dick get bigger! Now it has " + GameControl.dick1Size.ToString () + " cm in length!";
		
		} else if (randNum < 80) { // taler
			GameControl.heightChar = GameControl.heightChar + 8;
			CharacteristicsSettler.setHeigthStatic ();
			return "The potion makes you taller! Now you are " + GameControl.heightChar.ToString() + " cm tall!";
		} else { // shorter
			GameControl.heightChar = GameControl.heightChar - 8;
			CharacteristicsSettler.setHeigthStatic ();
			return "The potion makes you shorter! Now you are " + GameControl.heightChar.ToString() + " cm tall!";
		}

	}

}
