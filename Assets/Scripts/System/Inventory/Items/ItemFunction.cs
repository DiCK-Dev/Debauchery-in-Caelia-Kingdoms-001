using UnityEngine;
using System.Collections;

public class ItemFunction : MonoBehaviour {

	Parser parser = new Parser();
	int switchEquip; 
	int randNum;
	CharacteristicsSettler charSettler = new CharacteristicsSettler(); 
	SetEquipment setEquipment = new SetEquipment(); 

	//CONSUMABLES 
	public void udderMaxW (){

		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.breast1Size <= 69) {
			if (randNum > 90)
			{
				if (GameControl.breastRow > 1) {
					GameControl.breast1Size = GameControl.breast1Size + 4; 
					GameControl.breast2Size = GameControl.breast1Size + 3; 
					charSettler.setCharBreasts1 ();
					charSettler.setCharBreasts2 ();
					WorldControl.itemUseText = "The taste of very sweet, fresh milk invades your mouth, and its effects act immediately, increase your bust size a significantly! Your first row of breasts is now " + GameControl.mcBreast1Cup.toDescription () + "cup and your second row is " + GameControl.mcBreast1Cup.toDescription () + " cup!" ;
				} else {
					GameControl.breast1Size = GameControl.breast1Size + 3; 
					charSettler.setCharBreasts1 ();
					WorldControl.itemUseText = "The taste of very sweet, fresh milk invades your mouth, and its effects act immediately, increase your bust size a significantly! they are now " + GameControl.mcBreast1Cup.toDescription () + " cup!";
				}

					
			} 
			else if (randNum > 10) 
			{
				if (GameControl.breastRow > 1) {
					GameControl.breast1Size = GameControl.breast1Size + 3; 
					GameControl.breast2Size = GameControl.breast1Size + 2; 
					charSettler.setCharBreasts1 ();
					charSettler.setCharBreasts2 ();
					WorldControl.itemUseText = "The taste of sweet milk invades your mouth, and its effects act immediately, increase your bust size a little!  Your first row of breasts is now " + GameControl.mcBreast1Cup.toDescription () + "cup and your second row is " + GameControl.mcBreast1Cup.toDescription () + " cup!" ;
				} else {
					GameControl.breast1Size = GameControl.breast1Size + 2; 
					charSettler.setCharBreasts1 ();
					WorldControl.itemUseText = "The taste of sweet milk invades your mouth, and its effects act immediately, increase your bust size a little! they are now " + GameControl.mcBreast1Cup.toDescription () + " cup!";
				
				}

			} 
			else
			{
				if (GameControl.breastRow > 1) {
					GameControl.breast1Size = GameControl.breast1Size + 2; 
					GameControl.breast2Size = GameControl.breast1Size + 1; 
					charSettler.setCharBreasts1 ();
					charSettler.setCharBreasts2 ();
					WorldControl.itemUseText = "The taste of bitter milk invades your mouth as its apparent that the bottle was old. Its effects act immediately, but your bust increases almost nothing. Your first row of breasts is now " + GameControl.mcBreast1Cup.toDescription () + "cup and your second row is " + GameControl.mcBreast1Cup.toDescription () + " cup!" ;
				} else {
					GameControl.breast1Size = GameControl.breast1Size + 1;
					charSettler.setCharBreasts1 ();
					WorldControl.itemUseText = "The taste of bitter milk invades your mouth as its apparent that the bottle was old. Its effects act immediately, but your bust increases almost nothing. They are now " + GameControl.mcBreast1Cup.toDescription ();
				}

			} 
		}else{
			GameControl.breast1Size = 69;
			charSettler.setCharBreasts1 ();
			WorldControl.itemUseText = "The potion isnt working! This is the maximum size!";
		}

	}

	public void udderMax () {
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (GameControl.breast1Size <= 69) {
			if (randNum > 90) {
				if (GameControl.breastRow > 1) {
					GameControl.breast1Size = GameControl.breast1Size + 4; 
					GameControl.breast2Size = GameControl.breast1Size + 3; 
					charSettler.setCharBreasts1 ();
					charSettler.setCharBreasts2 ();
					WorldControl.itemUseText = "The taste of very sweet, fresh milk invades your mouth, and its effects act immediately, increase your bust size a significantly! Your first row of breasts is now " + GameControl.mcBreast1Cup.toDescription() + "cup and your second row is " + GameControl.mcBreast1Cup.toDescription() + " cup!";
				} else {
					GameControl.breast1Size = GameControl.breast1Size + 3; 
					charSettler.setCharBreasts1 ();
					WorldControl.itemUseText = "The taste of very sweet, fresh milk invades your mouth, and its effects act immediately, increase your bust size a significantly! they are now " + GameControl.mcBreast1Cup.toDescription() + " cup!";
				}


			} else if (randNum > 10) {
				if (GameControl.breastRow > 1) {
					GameControl.breast1Size = GameControl.breast1Size + 3; 
					GameControl.breast2Size = GameControl.breast1Size + 2; 
					charSettler.setCharBreasts1 ();
					charSettler.setCharBreasts2 ();
					WorldControl.itemUseText = "The taste of sweet milk invades your mouth, and its effects act immediately, increase your bust size a little!  Your first row of breasts is now " + GameControl.mcBreast1Cup.toDescription() + "cup and your second row is " + GameControl.mcBreast1Cup.toDescription() + " cup!";
				} else {
					GameControl.breast1Size = GameControl.breast1Size + 2; 
					charSettler.setCharBreasts1 ();
					WorldControl.itemUseText = "The taste of sweet milk invades your mouth, and its effects act immediately, increase your bust size a little! they are now " + GameControl.mcBreast1Cup.toDescription() + " cup!";
				}

			} else {
				if (GameControl.breastRow > 1) {
					GameControl.breast1Size = GameControl.breast1Size + 2; 
					GameControl.breast2Size = GameControl.breast1Size + 1; 
					charSettler.setCharBreasts1 ();
					charSettler.setCharBreasts2 ();
					WorldControl.itemUseText = "The taste of bitter milk invades your mouth as its apparent that the bottle was old. Its effects act immediately, but your bust increases almost nothing. Your first row of breasts is now " + GameControl.mcBreast1Cup.toDescription() + "cup and your second row is " + GameControl.mcBreast1Cup.toDescription() + " cup!";
				} else {
					GameControl.breast1Size = GameControl.breast1Size + 1;
					charSettler.setCharBreasts1 ();
					WorldControl.itemUseText = "The taste of bitter milk invades your mouth as its apparent that the bottle was old. Its effects act immediately, but your bust increases almost nothing. They are now " + GameControl.mcBreast1Cup.toDescription();
				}

			} 
		}else{
			GameControl.breast1Size = 69;
			charSettler.setCharBreasts1 ();
			WorldControl.itemUseText = "The potion isnt working! This is the maximum size!";
		}

	}

	public void udderMaxS () {
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.breast1Size <= 690) {

			if (randNum > 90) {
				if (GameControl.breastRow > 1) {
					GameControl.breast1Size = GameControl.breast1Size + 14; 
					GameControl.breast2Size = GameControl.breast1Size + 8; 
					charSettler.setCharBreasts1 ();
					charSettler.setCharBreasts2 ();
					WorldControl.itemUseText = "The taste of very sweet, fresh milk invades your mouth, and its effects act immediately, increase your bust size a significantly! Your first row of breasts is now " + GameControl.mcBreast1Cup.toDescription () + "cup and your second row is " + GameControl.mcBreast1Cup.toDescription () + " cup!";
				} else {
					GameControl.breast1Size = GameControl.breast1Size + 15; 
					charSettler.setCharBreasts1 ();
					WorldControl.itemUseText = "The taste of very sweet, fresh milk invades your mouth, and its effects act immediately, increase your bust size a significantly! they are now " + GameControl.mcBreast1Cup.toDescription () + " cup!";
				}


			} else if (randNum > 10) {
				if (GameControl.breastRow > 1) {
					GameControl.breast1Size = GameControl.breast1Size + 10; 
					GameControl.breast2Size = GameControl.breast1Size + 6; 
					charSettler.setCharBreasts1 ();
					charSettler.setCharBreasts2 ();
					WorldControl.itemUseText = "The taste of sweet milk invades your mouth, and its effects act immediately, increase your bust size a little!  Your first row of breasts is now " + GameControl.mcBreast1Cup.toDescription () + "cup and your second row is " + GameControl.mcBreast1Cup.toDescription () + " cup!";
				} else {
					GameControl.breast1Size = GameControl.breast1Size + 12; 
					charSettler.setCharBreasts1 ();
					WorldControl.itemUseText = "The taste of sweet milk invades your mouth, and its effects act immediately, increase your bust size a little! they are now " + GameControl.mcBreast1Cup.toDescription () + " cup!";
				}

			} else {
				if (GameControl.breastRow > 1) {
					GameControl.breast1Size = GameControl.breast1Size + 6; 
					GameControl.breast2Size = GameControl.breast1Size + 4; 
					charSettler.setCharBreasts1 ();
					charSettler.setCharBreasts2 ();
					WorldControl.itemUseText = "The taste of bitter milk invades your mouth as its apparent that the bottle was old. Its effects act immediately, but your bust increases almost nothing. Your first row of breasts is now " + GameControl.mcBreast1Cup.toDescription () + "cup and your second row is " + GameControl.mcBreast1Cup.toDescription () + " cup!";
				} else {
					GameControl.breast1Size = GameControl.breast1Size + 8;
					charSettler.setCharBreasts1 ();
					WorldControl.itemUseText = "The taste of bitter milk invades your mouth as its apparent that the bottle was old. Its effects act immediately, but your bust increases almost nothing. They are now " + GameControl.mcBreast1Cup.toDescription ();
				}

			} 
		}else{
			GameControl.breast1Size = 690;
			charSettler.setCharBreasts1 ();
			WorldControl.itemUseText = "The potion isnt working! This is the maximum size!";
		}


	}

	public void virilitaxW () {
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (GameControl.dickNum <= 0) {
			GameControl.dickNum = 1;
			GameControl.dick1Size = 10;
			GameControl.dick2Size = 0; 
			GameControl.dick1Thick = 3; 
			charSettler.setCharDick1Name ();
			charSettler.setCharDick2Name ();
			WorldControl.itemUseText = "Immediately after taking the potion you start to feel a weird sensation around your crotch, and it doesn't take long before a small dick starts to grow up until its 10 cm long!";
		} else {
			
			if (randNum > 90) {


				if (GameControl.dickNum > 1) {
					GameControl.dick1Size = GameControl.dick1Size + 5; 
					GameControl.dick2Size = GameControl.dick2Size + 3; 
					charSettler.setCharDick1Name ();
					charSettler.setCharDick2Name ();
					WorldControl.itemUseText = "A very strong taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, increasing the size of your dick significantly! Your first dick increases in 5 cm and the second one 3 in length!";
				} else {
					GameControl.dick1Size = GameControl.dick1Size + 5; 
					charSettler.setCharDick1Name ();
					WorldControl.itemUseText = "A very strong taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, increasing the size of your dick 5 cm in length!";
				}


			} else if (randNum > 10) {
				if (GameControl.dickNum > 1) {
					GameControl.dick1Size = GameControl.dick1Size + 3; 
					GameControl.dick2Size = GameControl.dick2Size + 2; 
					charSettler.setCharDick1Name ();
					charSettler.setCharDick2Name ();
					WorldControl.itemUseText = "A strong taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, increasing the size of your dick significantly! Your first dick increases in 3 cm and the second one 2 in length!";
				} else {
					GameControl.dick1Size = GameControl.dick1Size + 3; 
					charSettler.setCharDick1Name ();
					WorldControl.itemUseText = "A very strong taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, increasing the size of your dick 3 cm in length!";
				}

			} else {
				if (GameControl.dickNum > 1) {
					GameControl.dick1Size = GameControl.dick1Size + 2; 
					GameControl.dick2Size = GameControl.dick2Size + 1; 
					charSettler.setCharDick1Name ();
					charSettler.setCharDick2Name ();
					WorldControl.itemUseText = "A weak taste fills your mouth. Clearly, the brew was pretty old, but still increases the size of your first dick in 2 cm and the second one just one in length.";
				} else {
					GameControl.dick1Size = GameControl.dick1Size + 2; 
					charSettler.setCharDick1Name ();
					WorldControl.itemUseText = "A weak taste fills your mouth. Clearly, the brew was pretty old, but still increases the size of your dick 2 cm in length.";
				}

			}
		}
		if (GameControl.dick1Size > 90 && GameControl.heightChar > 120 && GameControl.heightChar < 220) {
			GameControl.dick1Size = 90; 
			WorldControl.itemUseText = "Your dick can only be this big at this heigth!";
		}
		if (GameControl.dick1Size > 120 && GameControl.heightChar >= 220) {
			GameControl.dick1Size = 120; 
			WorldControl.itemUseText = "Your dick can only be this big at this heigth!";
		}
		if (GameControl.dick1Size > 60 && GameControl.heightChar <= 120) {
			GameControl.dick1Size = 60; 
			WorldControl.itemUseText = "Your dick can only be this big at this heigth!";
		}
	}




	public void virilitax () {
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.dickNum <= 0) {
			GameControl.dickNum = 1;
			GameControl.dick1Size = 13;
			GameControl.dick2Size = 0; 
			GameControl.dick1Thick = 3; 
			charSettler.setCharDick1Name ();
			charSettler.setCharDick2Name ();
			WorldControl.itemUseText = "Immediately after taking the potion you start to feel a weird sensation around your crotch, and it doesn't take long before a small dick starts to grow up until its 13 cm long!";
		} else {

			if (randNum > 90) {


				if (GameControl.dickNum > 1) {
					GameControl.dick1Size = GameControl.dick1Size + 8; 
					GameControl.dick2Size = GameControl.dick2Size + 5; 
					GameControl.dick1Thick = GameControl.dick1Thick + 1; 
					GameControl.dick2Thick = GameControl.dick2Thick + 1; 
					charSettler.setCharDick1Name ();
					charSettler.setCharDick2Name ();
					WorldControl.itemUseText = "A very strong taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, increasing the size of your dick significantly! Your first dick increases 8 cm and the second one 5 cm in length and 1 cm in thick each!";
				} else {
					GameControl.dick1Size = GameControl.dick1Size + 8; 
					GameControl.dick1Thick = GameControl.dick1Thick + 2; 
					charSettler.setCharDick1Name ();
					WorldControl.itemUseText = "A very strong taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, increasing the size of your dick 8 cm in length and 2 cm in thick!!";
				}


			} else if (randNum > 10) {
				if (GameControl.dickNum > 1) {
					GameControl.dick1Size = GameControl.dick1Size + 5; 
					GameControl.dick2Size = GameControl.dick2Size + 3; 
					GameControl.dick1Thick = GameControl.dick1Thick + 1; 
					GameControl.dick2Thick = GameControl.dick2Thick + 1; 
					charSettler.setCharDick1Name ();
					charSettler.setCharDick2Name ();
					WorldControl.itemUseText = "A strong taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, increasing the size of your dick significantly! Your first dick increases 5 cm and the second one 3 in length and 1 cm in thick each!";
				} else {
					GameControl.dick1Size = GameControl.dick1Size + 5; 
					GameControl.dick1Thick = GameControl.dick1Thick + 2; 
					charSettler.setCharDick1Name ();
					WorldControl.itemUseText = "A very strong taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, increasing the size of your dick 5 cm in length and 2 cm in thick!!";
				}

			} else {
				if (GameControl.dickNum > 1) {
					GameControl.dick1Size = GameControl.dick1Size + 3; 
					GameControl.dick2Size = GameControl.dick2Size + 2; 
					GameControl.dick1Thick = GameControl.dick1Thick + 1; 
					GameControl.dick2Thick = GameControl.dick2Thick + 1; 
					charSettler.setCharDick1Name ();
					charSettler.setCharDick2Name ();
					WorldControl.itemUseText = "A weak taste fills your mouth. Clearly, the brew was pretty old, but still increases the size of your first dick 3 cm and the second one just two in length and 1 cm in thick each!";
				} else {
					GameControl.dick1Size = GameControl.dick1Size + 3; 
					GameControl.dick1Thick = GameControl.dick1Thick + 1; 
					charSettler.setCharDick1Name ();
					WorldControl.itemUseText = "A weak taste fills your mouth. Clearly, the brew was pretty old, but still increases the size of your dick 3 cm in length and 1 cm in thick!";
				}

			}
		}
		if (GameControl.dick1Size > 90 && GameControl.heightChar > 120 && GameControl.heightChar < 220) {
			GameControl.dick1Size = 90; 
			WorldControl.itemUseText = "Your dick can only be this big at this heigth";
		}
		if (GameControl.dick1Size > 120 && GameControl.heightChar >= 220) {
			GameControl.dick1Size = 120; 
			WorldControl.itemUseText = "Your dick can only be this big at this heigth!";
		}
		if (GameControl.dick1Size > 60 && GameControl.heightChar <= 120) {
			GameControl.dick1Size = 60; 
			WorldControl.itemUseText = "Your dick can only be this big at this heigth!";
		}


	}

	public void virilitaxS () {
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (GameControl.dickNum <= 0) {
			GameControl.dickNum = 1;
			GameControl.dick1Size = 18;
			GameControl.dick2Size = 0; 
			charSettler.setCharDick1Name ();
			charSettler.setCharDick2Name ();
			WorldControl.itemUseText = "Immediately after taking the potion you start to feel a weird sensation around your crotch, and it doesn't take long before a small dick starts to grow up until its 18 cm long!";
		} else {

			if (randNum > 90) {


				if (GameControl.dickNum > 1) {
					GameControl.dick1Size = GameControl.dick1Size + 12; 
					GameControl.dick2Size = GameControl.dick2Size + 12; 
					charSettler.setCharDick1Name ();
					charSettler.setCharDick2Name ();
					WorldControl.itemUseText = "A very strong taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, increasing the size of your dick significantly! both dicks increase 12 cm in length!";
				} else {
					GameControl.dick1Size = GameControl.dick1Size + 12; 
					charSettler.setCharDick1Name ();
					WorldControl.itemUseText = "A very strong taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, increasing the size of your dick 5 cm in length!";
				}


			} else if (randNum > 10) {
				if (GameControl.dickNum > 1) {
					GameControl.dick1Size = GameControl.dick1Size + 8; 
					GameControl.dick2Size = GameControl.dick2Size + 8; 
					charSettler.setCharDick1Name ();
					charSettler.setCharDick2Name ();
					WorldControl.itemUseText = "A strong taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, increasing the size of your dick significantly! both dicks increase 8 cm in length!";
				} else {
					GameControl.dick1Size = GameControl.dick1Size + 8; 
					charSettler.setCharDick1Name ();
					WorldControl.itemUseText = "A very strong taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, increasing the size of your dick 3 cm in length!";
				}

			} else {
				if (GameControl.dickNum > 1) {
					GameControl.dick1Size = GameControl.dick1Size + 5; 
					GameControl.dick2Size = GameControl.dick2Size + 5; 
					charSettler.setCharDick1Name ();
					charSettler.setCharDick2Name ();
					WorldControl.itemUseText = "A weak taste fills your mouth. Clearly, the brew was pretty old, but still increases the size of both of your dicks 5 cm in length.";
				} else {
					GameControl.dick1Size = GameControl.dick1Size + 5; 
					charSettler.setCharDick1Name ();
					WorldControl.itemUseText = "A weak taste fills your mouth. Clearly, the brew was pretty old, but still increases the size of your dick 5 cm in length.";
				}

			}
		}
		if (GameControl.dick1Size > 90 && GameControl.heightChar > 120 && GameControl.heightChar < 220) {
			GameControl.dick1Size = 90; 
			WorldControl.itemUseText = "Your dick can only be this big at this heigth";
		}
		if (GameControl.dick1Size > 120 && GameControl.heightChar >= 220) {
			GameControl.dick1Size = 120; 
			WorldControl.itemUseText = "Your dick can only be this big at this heigth!";
		}
		if (GameControl.dick1Size > 60 && GameControl.heightChar <= 120) {
			GameControl.dick1Size = 60; 
			WorldControl.itemUseText = "Your dick can only be this big at this heigth!";
		}

	}


	public void gallantryAleW () {
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (GameControl.testiclesSize <= 0 && GameControl.dickNum >= 1) {
			GameControl.testiclesSize = 3;
			charSettler.setTesticlesName ();
			WorldControl.itemUseText = "You feel a weird sensation under your crotch, and after a couple of minutes you grow a pair of testicles 3 cm in size!";
		} else if (GameControl.dickNum >= 1) {

			if (randNum > 90)
			{
				GameControl.testiclesSize = GameControl.testiclesSize + 3;
				charSettler.setTesticlesName ();
				WorldControl.itemUseText = "The sticky substance stays in your mouth for a while, but afterwards you can see its powerful effects, increasing the size of your testicles 3cm more!";
			

			} 
			else if (randNum > 10) 
			{
				GameControl.testiclesSize = GameControl.testiclesSize + 2;
				charSettler.setTesticlesName ();
				WorldControl.itemUseText = "The sticky substance stays in your mouth for a while, but afterwards you can see its effects, increasing the size of your testicles 2cm more!";


			} 
			else 
			{
				GameControl.testiclesSize = GameControl.testiclesSize + 1;
				charSettler.setTesticlesName ();
				WorldControl.itemUseText = "The sticky substance stays in your mouth for a while, but afterwards you can see its weak effects, increasing the size of your testicles only 1cm more.";

			}
		} 
		else 
		{
			WorldControl.itemUseText = "You drink the potion but see no effect. After reading the instructions again it says that you need a dick to growth this!";
		}
		if (GameControl.testiclesSize > 60 && GameControl.heightChar > 120 && GameControl.heightChar < 220) {
			GameControl.testiclesSize = 50; 
			WorldControl.itemUseText = "Your testicles can only be this big at this heigth";
		}
		if (GameControl.testiclesSize > 80 && GameControl.heightChar >= 220 ) {
			GameControl.testiclesSize = 80; 
			WorldControl.itemUseText = "Your testicles can only be this big at this heigth";
		}
		if (GameControl.testiclesSize > 40 && GameControl.heightChar <= 120) {
			GameControl.testiclesSize = 40; 
			WorldControl.itemUseText = "Your testicles can only be this big at this heigth";
		}


	}




	public void gallantryAle () {
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (GameControl.testiclesSize <= 0 && GameControl.dickNum >= 1) {
			GameControl.testiclesSize = 4;
			charSettler.setTesticlesName ();
			WorldControl.itemUseText = "You feel a weird sensation under your crotch, and after a couple of minutes you grow a pair of testicles 4 cm in size!";
		} else if (GameControl.dickNum >= 1) {

			if (randNum > 90)
			{
				GameControl.testiclesSize = GameControl.testiclesSize + 4;
				charSettler.setTesticlesName ();
				WorldControl.itemUseText = "The sticky substance stays in your mouth for a while, but afterwards you can see its powerful effects, increasing the size of your testicles 4cm more!";


			} 
			else if (randNum > 10) 
			{
				GameControl.testiclesSize = GameControl.testiclesSize + 3;
				charSettler.setTesticlesName ();
				WorldControl.itemUseText = "The sticky substance stays in your mouth for a while, but afterwards you can see its effects, increasing the size of your testicles 3cm more!";


			} 
			else 
			{
				GameControl.testiclesSize = GameControl.testiclesSize + 2;
				charSettler.setTesticlesName ();
				WorldControl.itemUseText = "The sticky substance stays in your mouth for a while, but afterwards you can see its weak effects, increasing the size of your testicles only 2cm more.";

			}

		} 
		else 
		{
			WorldControl.itemUseText = "You drink the potion but see no effect. After reading the instructions again it says that you need a dick to growth this!";
		}
		if (GameControl.testiclesSize > 60 && GameControl.heightChar > 120 && GameControl.heightChar < 220) {
			GameControl.testiclesSize = 50; 
			WorldControl.itemUseText = "Your testicles can only be this big at this heigth";
		}
		if (GameControl.testiclesSize > 80 && GameControl.heightChar >= 220 ) {
			GameControl.testiclesSize = 80; 
			WorldControl.itemUseText = "Your testicles can only be this big at this heigth";
		}
		if (GameControl.testiclesSize > 40 && GameControl.heightChar <= 120) {
			GameControl.testiclesSize = 40; 
			WorldControl.itemUseText = "Your testicles can only be this big at this heigth";
		}

	}







	public void gallantryAleS () {
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (GameControl.testiclesSize <= 0 && GameControl.dickNum >= 1) {
			GameControl.testiclesSize = 5;
			charSettler.setTesticlesName ();
			WorldControl.itemUseText = "You feel a weird sensation under your crotch, and after a couple of minutes you grow a pair of testicles 5 cm in size!";
		} else if (GameControl.dickNum >= 1) {

			if (randNum > 90)
			{
				GameControl.testiclesSize = GameControl.testiclesSize + 6;
				charSettler.setTesticlesName ();
				WorldControl.itemUseText = "The sticky substance stays in your mouth for a while, but afterwards you can see its powerful effects, increasing the size of your testicles 6cm more!";


			} 
			else if (randNum > 10) 
			{
				GameControl.testiclesSize = GameControl.testiclesSize + 5;
				charSettler.setTesticlesName ();
				WorldControl.itemUseText = "The sticky substance stays in your mouth for a while, but afterwards you can see its effects, increasing the size of your testicles 5cm more!";


			} 
			else 
			{
				GameControl.testiclesSize = GameControl.testiclesSize + 4;
				charSettler.setTesticlesName ();
				WorldControl.itemUseText = "The sticky substance stays in your mouth for a while, but afterwards you can see its weak effects, increasing the size of your testicles only 14m more.";

			}
		} 
		else 
		{
			WorldControl.itemUseText = "You drink the potion but see no effect. After reading the instructions again it says that you need a dick to growth this!";
		}

		if (GameControl.testiclesSize > 60 && GameControl.heightChar > 120 && GameControl.heightChar < 220) {
			GameControl.testiclesSize = 50; 
			WorldControl.itemUseText = "Your testicles can only be this big at this heigth";
		}
		if (GameControl.testiclesSize > 80 && GameControl.heightChar >= 220 ) {
			GameControl.testiclesSize = 80; 
			WorldControl.itemUseText = "Your testicles can only be this big at this heigth";
		}
		if (GameControl.testiclesSize > 40 && GameControl.heightChar <= 120) {
			GameControl.testiclesSize = 40; 
			WorldControl.itemUseText = "Your testicles can only be this big at this heigth";
		}
	}



	public void gigantusW () {
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.heightChar <= 300) {
			if (randNum > 90) {
				GameControl.heightChar = GameControl.heightChar + 8;
				charSettler.setHeigth ();
				WorldControl.itemUseText = "You drank the potion and you felt dizzy for a moment, your surroundings spinning around. When everything came back to normal, you realize that you are now 8 cm taller!";

			} else if (randNum > 10) {
				GameControl.heightChar = GameControl.heightChar + 5;
				charSettler.setHeigth ();
				WorldControl.itemUseText = "You drank the potion and you felt dizzy for a moment, your surroundings spinning around. When everything came back to normal, you realize that you are now 5 cm taller!";

			} else {
				GameControl.heightChar = GameControl.heightChar + 3;
				charSettler.setHeigth ();
				WorldControl.itemUseText = "You drank the potion, which had an odd taste, and you felt dizzy for a moment, your surroundings spinning around. When everything came back to normal, you realize that you are now 3 cm taller!";

			} 
		} else {
			WorldControl.itemUseText = "You drank the potion but nothing happens, clearly the label is false advertising!";
		}
		

	}
	public void gigantus () {
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.heightChar <= 300) {
			if (randNum > 90) {
				GameControl.heightChar = GameControl.heightChar + 12;
				charSettler.setHeigth ();
				WorldControl.itemUseText = "You drank the potion and you felt dizzy for a moment, your surroundings spinning around. When everything came back to normal, you realize that you are now 12 cm taller!";

			} else if (randNum > 10) {
				GameControl.heightChar = GameControl.heightChar + 8;
				charSettler.setHeigth ();
				WorldControl.itemUseText = "You drank the potion and you felt dizzy for a moment, your surroundings spinning around. When everything came back to normal, you realize that you are now 8 cm taller!";

			} else {
				GameControl.heightChar = GameControl.heightChar + 5;
				charSettler.setHeigth ();
				WorldControl.itemUseText = "You drank the potion, which had an odd taste, and you felt dizzy for a moment, your surroundings spinning around. When everything came back to normal, you realize that you are now 5 cm taller!";

			} 
		} else {
			WorldControl.itemUseText = "You drank the potion but nothing happens, clearly the label is false advertising!";
		}

	}
	public void gigantusS () {
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.heightChar <= 300) {
			if (randNum > 90) {
				GameControl.heightChar = GameControl.heightChar + 16;
				charSettler.setHeigth ();
				WorldControl.itemUseText = "You drank the potion and you felt dizzy for a moment, your surroundings spinning around. When everything came back to normal, you realize that you are now 16 cm taller!";

			} else if (randNum > 10) {
				GameControl.heightChar = GameControl.heightChar + 12;
				charSettler.setHeigth ();
				WorldControl.itemUseText = "You drank the potion and you felt dizzy for a moment, your surroundings spinning around. When everything came back to normal, you realize that you are now 12 cm taller!";

			} else {
				GameControl.heightChar = GameControl.heightChar + 8;
				charSettler.setHeigth ();
				WorldControl.itemUseText = "You drank the potion, which had an odd taste, and you felt dizzy for a moment, your surroundings spinning around. When everything came back to normal, you realize that you are now 8 cm taller!";

			} 
		} else {
			WorldControl.itemUseText = "You drank the potion but nothing happens, clearly the label is false advertising!";
		}


	}
	public void pigmyW(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.heightChar >= 90) {
			if (randNum > 90) {
				GameControl.heightChar = GameControl.heightChar - 8;
				charSettler.setHeigth ();
				WorldControl.itemUseText = "You drank the potion and you felt dizzy for a moment, your surroundings spinning around. When everything came back to normal, you realize that you are now 8 cm shorter!";

			} else if (randNum > 10) {
				GameControl.heightChar = GameControl.heightChar - 5 ;
				charSettler.setHeigth ();
				WorldControl.itemUseText = "You drank the potion and you felt dizzy for a moment, your surroundings spinning around. When everything came back to normal, you realize that you are now 5 cm shorter!";

			} else {
				GameControl.heightChar = GameControl.heightChar - 3;
				charSettler.setHeigth ();
				WorldControl.itemUseText = "You drank the potion, which had an odd taste, and you felt dizzy for a moment, your surroundings spinning around. When everything came back to normal, you realize that you are now 3 cm shorter!";

			} 
		} else {
			WorldControl.itemUseText = "You drank the potion but nothing happens, clearly the label is false advertising!";
		}
	}


	public void pigmy (){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.heightChar >= 90) {
			if (randNum > 90) {
				GameControl.heightChar = GameControl.heightChar - 12;
				charSettler.setHeigth ();
				WorldControl.itemUseText = "You drank the potion and you felt dizzy for a moment, your surroundings spinning around. When everything came back to normal, you realize that you are now 12 cm shorter!";

			} else if (randNum > 10) {
				GameControl.heightChar = GameControl.heightChar - 8;
				charSettler.setHeigth ();
				WorldControl.itemUseText = "You drank the potion and you felt dizzy for a moment, your surroundings spinning around. When everything came back to normal, you realize that you are now 8 cm shorter!";

			} else {
				GameControl.heightChar = GameControl.heightChar - 5;
				charSettler.setHeigth ();
				WorldControl.itemUseText = "You drank the potion, which had an odd taste, and you felt dizzy for a moment, your surroundings spinning around. When everything came back to normal, you realize that you are now 5 cm shorter!";

			} 
		} else {
			WorldControl.itemUseText = "You drank the potion but nothing happens, clearly the label is false advertising!";
		}

	}
	public void pigmyS() {
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.heightChar >= 90) {
			if (randNum > 90) {
				GameControl.heightChar = GameControl.heightChar - 16;
				charSettler.setHeigth ();
				WorldControl.itemUseText = "You drank the potion and you felt dizzy for a moment, your surroundings spinning around. When everything came back to normal, you realize that you are now 16 cm shorter!";

			} else if (randNum > 10) {
				GameControl.heightChar = GameControl.heightChar - 12;
				charSettler.setHeigth ();
				WorldControl.itemUseText = "You drank the potion and you felt dizzy for a moment, your surroundings spinning around. When everything came back to normal, you realize that you are now 12 cm shorter!";

			} else {
				GameControl.heightChar = GameControl.heightChar - 8;
				charSettler.setHeigth ();
				WorldControl.itemUseText = "You drank the potion, which had an odd taste, and you felt dizzy for a moment, your surroundings spinning around. When everything came back to normal, you realize that you are now 8 cm shorter!";

			} 
		} else {
			WorldControl.itemUseText = "You drank the potion but nothing happens, clearly the label is false advertising!";
		}

	}
	public void deathBosomW (){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.breast1Size > 0) {

			if (randNum > 90) {
				if (GameControl.breastRow > 1) {
					GameControl.breast1Size = GameControl.breast1Size - 6; 
					GameControl.breast2Size = GameControl.breast1Size - 3; 
					charSettler.setCharBreasts1 ();
					charSettler.setCharBreasts2 ();
					WorldControl.itemUseText = "The taste of very sweet, fresh orange juice that reminds you of your youth invades your mouth, and its effects act immediately, reducing your bust size a significantly! Your first row of breasts is now " + GameControl.mcBreast1Cup.toDescription () + "cup and your second row is " + GameControl.mcBreast1Cup.toDescription () + " cup!";
				} else {
					GameControl.breast1Size = GameControl.breast1Size - 8; 
					charSettler.setCharBreasts1 ();
					WorldControl.itemUseText = "The taste of very sweet, fresh orange juice that reminds you of your youth invades your mouth, reducing your bust size a significantly! they are now " + GameControl.mcBreast1Cup.toDescription () + " cup!";
				}


			} else if (randNum > 10) {
				if (GameControl.breastRow > 1) {
					GameControl.breast1Size = GameControl.breast1Size - 4; 
					GameControl.breast2Size = GameControl.breast1Size - 2; 
					charSettler.setCharBreasts1 ();
					charSettler.setCharBreasts2 ();
					WorldControl.itemUseText = "The taste of sweet, orange juice that reminds you of your youth invades your mouth, reducing your bust size a little!  Your first row of breasts is now " + GameControl.mcBreast1Cup.toDescription () + "cup and your second row is " + GameControl.mcBreast1Cup.toDescription () + " cup!";
				} else {
					GameControl.breast1Size = GameControl.breast1Size - 5; 
					charSettler.setCharBreasts1 ();
					WorldControl.itemUseText = "The taste of sweet, orange juice that reminds you of your youth invades your mouth, reducing your bust size a little! they are now " + GameControl.mcBreast1Cup.toDescription () + " cup!";
				}

			} else {
				if (GameControl.breastRow > 1) {
					GameControl.breast1Size = GameControl.breast1Size - 2; 
					GameControl.breast2Size = GameControl.breast1Size - 1; 
					charSettler.setCharBreasts1 ();
					charSettler.setCharBreasts2 ();
					WorldControl.itemUseText = "The taste of bitter orange juice invades your mouth as its apparent that the bottle was old. Its effects act immediately, but your bust reduces its size almost nothing. Your first row of breasts is now " + GameControl.mcBreast1Cup.toDescription () + "cup and your second row is " + GameControl.mcBreast1Cup.toDescription () + " cup!";
				} else {
					GameControl.breast1Size = GameControl.breast1Size - 3;
					charSettler.setCharBreasts1 ();
					WorldControl.itemUseText = "The taste of bitter orange juice invades your mouth as its apparent that the bottle was old. Its effects act immediately, but your bust reduces its size almost nothing. They are now " + GameControl.mcBreast1Cup.toDescription ();
				}

			} 
		}else{
			GameControl.breast1Size = 0;
			charSettler.setCharBreasts1 ();
			WorldControl.itemUseText = "The potion isnt working! This is as flat as you can get!";
		}
	}
	public void deathBosom (){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.breast1Size > 0) {

			if (randNum > 90) {
				if (GameControl.breastRow > 1) {
					GameControl.breast1Size = GameControl.breast1Size - 4; 
					GameControl.breast2Size = GameControl.breast1Size - 3; 
					charSettler.setCharBreasts1 ();
					charSettler.setCharBreasts2 ();
					WorldControl.itemUseText = "The taste of very sweet, fresh orange juice that reminds you of your youth invades your mouth, and its effects act immediately, reducing your bust size a significantly! Your first row of breasts is now " + GameControl.mcBreast1Cup.toDescription () + "cup and your second row is " + GameControl.mcBreast1Cup.toDescription () + " cup!";
				} else {
					GameControl.breast1Size = GameControl.breast1Size - 3; 
					charSettler.setCharBreasts1 ();
					WorldControl.itemUseText = "The taste of very sweet, fresh orange juice that reminds you of your youth invades your mouth, reducing your bust size a significantly! they are now " + GameControl.mcBreast1Cup.toDescription () + " cup!";
				}


			} else if (randNum > 10) {
				if (GameControl.breastRow > 1) {
					GameControl.breast1Size = GameControl.breast1Size - 3; 
					GameControl.breast2Size = GameControl.breast1Size - 2; 
					charSettler.setCharBreasts1 ();
					charSettler.setCharBreasts2 ();
					WorldControl.itemUseText = "The taste of sweet, orange juice that reminds you of your youth invades your mouth, reducing your bust size a little!  Your first row of breasts is now " + GameControl.mcBreast1Cup.toDescription () + "cup and your second row is " + GameControl.mcBreast1Cup.toDescription () + " cup!";
				} else {
					GameControl.breast1Size = GameControl.breast1Size - 2; 
					charSettler.setCharBreasts1 ();
					WorldControl.itemUseText = "The taste of sweet, orange juice that reminds you of your youth invades your mouth, reducing your bust size a little! they are now " + GameControl.mcBreast1Cup.toDescription () + " cup!";
				}

			} else {
				if (GameControl.breastRow > 1) {
					GameControl.breast1Size = GameControl.breast1Size - 2; 
					GameControl.breast2Size = GameControl.breast1Size - 1; 
					charSettler.setCharBreasts1 ();
					charSettler.setCharBreasts2 ();
					WorldControl.itemUseText = "The taste of bitter orange juice invades your mouth as its apparent that the bottle was old. Its effects act immediately, but your bust reduces its size almost nothing. Your first row of breasts is now " + GameControl.mcBreast1Cup.toDescription () + "cup and your second row is " + GameControl.mcBreast1Cup.toDescription () + " cup!";
				} else {
					GameControl.breast1Size = GameControl.breast1Size - 1;
					charSettler.setCharBreasts1 ();
					WorldControl.itemUseText = "The taste of bitter orange juice invades your mouth as its apparent that the bottle was old. Its effects act immediately, but your bust reduces its size almost nothing. They are now " + GameControl.mcBreast1Cup.toDescription ();
				}

			} 
		}else{
			GameControl.breast1Size = 0;
			charSettler.setCharBreasts1 ();
			WorldControl.itemUseText = "The potion isnt working! This is as flat as you can get!";
		}

	}
	public void deathBosomS (){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.breast1Size > 0) {

			if (randNum > 90) {
				if (GameControl.breastRow > 1) {
					GameControl.breast1Size = GameControl.breast1Size - 14; 
					GameControl.breast2Size = GameControl.breast1Size - 10; 
					charSettler.setCharBreasts1 ();
					charSettler.setCharBreasts2 ();
					WorldControl.itemUseText = "The taste of very sweet, fresh orange juice that reminds you of your youth invades your mouth, and its effects act immediately, reducing your bust size a significantly! Your first row of breasts is now " + GameControl.mcBreast1Cup.toDescription () + "cup and your second row is " + GameControl.mcBreast1Cup.toDescription () + " cup!";
				} else {
					GameControl.breast1Size = GameControl.breast1Size - 15; 
					charSettler.setCharBreasts1 ();
					WorldControl.itemUseText = "The taste of very sweet, fresh orange juice that reminds you of your youth invades your mouth, reducing your bust size a significantly! they are now " + GameControl.mcBreast1Cup.toDescription () + " cup!";
				}


			} else if (randNum > 10) {
				if (GameControl.breastRow > 1) {
					GameControl.breast1Size = GameControl.breast1Size - 10; 
					GameControl.breast2Size = GameControl.breast1Size - 6; 
					charSettler.setCharBreasts1 ();
					charSettler.setCharBreasts2 ();
					WorldControl.itemUseText = "The taste of sweet, orange juice that reminds you of your youth invades your mouth, reducing your bust size a little!  Your first row of breasts is now " + GameControl.mcBreast1Cup.toDescription () + "cup and your second row is " + GameControl.mcBreast1Cup.toDescription () + " cup!";
				} else {
					GameControl.breast1Size = GameControl.breast1Size - 8; 
					charSettler.setCharBreasts1 ();
					WorldControl.itemUseText = "The taste of sweet, orange juice that reminds you of your youth invades your mouth, reducing your bust size a little! they are now " + GameControl.mcBreast1Cup.toDescription () + " cup!";
				}

			} else {
				if (GameControl.breastRow > 1) {
					GameControl.breast1Size = GameControl.breast1Size - 6; 
					GameControl.breast2Size = GameControl.breast1Size - 4; 
					charSettler.setCharBreasts1 ();
					charSettler.setCharBreasts2 ();
					WorldControl.itemUseText = "The taste of bitter orange juice invades your mouth as its apparent that the bottle was old. Its effects act immediately, but your bust reduces its size almost nothing. Your first row of breasts is now " + GameControl.mcBreast1Cup.toDescription () + "cup and your second row is " + GameControl.mcBreast1Cup.toDescription () + " cup!";
				} else {
					GameControl.breast1Size = GameControl.breast1Size - 8;
					charSettler.setCharBreasts1 ();
					WorldControl.itemUseText = "The taste of bitter orange juice invades your mouth as its apparent that the bottle was old. Its effects act immediately, but your bust reduces its size almost nothing. They are now " + GameControl.mcBreast1Cup.toDescription ();
				}

			} 
		}else{
			GameControl.breast1Size = 0;
			charSettler.setCharBreasts1 ();
			WorldControl.itemUseText = "The potion isnt working! This is as flat as you can get!";
		}

	}








	public void betaXW() {
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (GameControl.dickNum <= 0) {
			GameControl.dickNum = 0;
			GameControl.dick1Size = 0;
			GameControl.dick2Size = 0; 
			GameControl.testiclesSize = 0; 
			charSettler.setCharDick1Name ();
			charSettler.setCharDick2Name ();
			charSettler.setTesticlesName ();
			WorldControl.itemUseText = "The potion has no effect since you have no dick!";
		} else {

			if (randNum > 90) {


				if (GameControl.dickNum > 1) 
				{
					GameControl.dick1Size = GameControl.dick1Size - 5; 
					GameControl.dick2Size = GameControl.dick2Size - 3; 
					charSettler.setCharDick1Name ();
					charSettler.setCharDick2Name ();
					WorldControl.itemUseText = "A very strong taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, reducing the size of your dick significantly! Your first dick loses 5 cm and the second one 3 in length!";
					if (GameControl.dick1Size <= 0) {
						GameControl.dickNum = 0; 
						GameControl.dick1Size = 0; 
						GameControl.dick2Size = 0; 
						charSettler.setCharDick1Name ();
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = "Immediately after taking the potion you start to feel a weird sensation around your crotch, and it doesn't take long before a small dick starts to shrink until it disappears!";
					
						if (GameControl.testiclesSize >= 0) 
						{
							WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour testicles have shrink too until they are gone!"; 
							GameControl.testiclesSize = 0;
							GameControl.mcTesticlesName = GameControl.MCTesticleName.NONE; 
						}
					}else if (GameControl.dick2Size <= 0 && GameControl.dickNum > 1) {
						GameControl.dickNum = 1; 
						GameControl.dick2Size = 0; 
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour second dick has shrinked until it disappeared!"; 
					}
				} else 
				{
					GameControl.dick1Size = GameControl.dick1Size - 5; 
					charSettler.setCharDick1Name ();
					WorldControl.itemUseText = "A very strong taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, reducing the size of your dick 5 cm in length!";
					if (GameControl.dick1Size <= 0) {
						GameControl.dickNum = 0; 
						GameControl.dick1Size = 0; 
						GameControl.dick2Size = 0; 
						charSettler.setCharDick1Name ();
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = "Immediately after taking the potion you start to feel a weird sensation around your crotch, and it doesn't take long before a small dick starts to shrink until it disappears!";
						if (GameControl.testiclesSize > 0) 
						{
							WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour testicles have shrink too until they are gone!"; 
							GameControl.testiclesSize = 0;
							GameControl.mcTesticlesName =  GameControl.MCTesticleName.NONE; 
						}
					}
				}


			} else if (randNum > 10) 
			{

				if (GameControl.dickNum > 1) {
					GameControl.dick1Size = GameControl.dick1Size - 3; 
					GameControl.dick2Size = GameControl.dick2Size - 2; 
					charSettler.setCharDick1Name ();
					charSettler.setCharDick2Name ();
					WorldControl.itemUseText = "A strong taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, reducing the size of your dick! Your first dick loses 3 cm and the second one 2 in length!";
					if (GameControl.dick1Size <= 0) {
						GameControl.dickNum = 0; 
						GameControl.dick1Size = 0; 
						GameControl.dick2Size = 0; 
						charSettler.setCharDick1Name ();
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = "Immediately after taking the potion you start to feel a weird sensation around your crotch, and it doesn't take long before a small dick starts to shrink until it disappears!";
						if (GameControl.testiclesSize >= 0) 
						{
							WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour testicles have shrink too until they are gone!"; 
							GameControl.testiclesSize = 0;
							GameControl.mcTesticlesName =  GameControl.MCTesticleName.NONE; 
						}
					}else if (GameControl.dick2Size <= 0 && GameControl.dickNum > 1 ) {
						GameControl.dickNum = 1; 
						GameControl.dick2Size = 0; 
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour second dick has shrinked until it disappeared!"; 
					}
				} else {
					GameControl.dick1Size = GameControl.dick1Size - 3; 
					charSettler.setCharDick1Name ();
					WorldControl.itemUseText = "A strong taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, reducing the size of your dick 3 cm in length!";
					if (GameControl.dick1Size <= 0) {
						GameControl.dickNum = 0; 
						GameControl.dick1Size = 0; 
						GameControl.dick2Size = 0; 
						charSettler.setCharDick1Name ();
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = "Immediately after taking the potion you start to feel a weird sensation around your crotch, and it doesn't take long before a small dick starts to shrink until it disappears!";
						if (GameControl.testiclesSize >= 0) 
						{
							WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour testicles have shrink too until they are gone!"; 
							GameControl.testiclesSize = 0;
							GameControl.mcTesticlesName =  GameControl.MCTesticleName.NONE; 
						}
					}
				}

			} 
			else
			{

				if (GameControl.dickNum > 1) {
					GameControl.dick1Size = GameControl.dick1Size - 2; 
					GameControl.dick2Size = GameControl.dick2Size - 1; 
					charSettler.setCharDick1Name ();
					charSettler.setCharDick2Name ();
					WorldControl.itemUseText = "A weak taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, reducing the size of your dick. Your first dick loses 2 cm and the second one 1 in length!";
					if (GameControl.dick1Size <= 0) {
						GameControl.dickNum = 0; 
						GameControl.dick1Size = 0; 
						GameControl.dick2Size = 0; 
						charSettler.setCharDick1Name ();
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = "Immediately after taking the potion you start to feel a weird sensation around your crotch, and it doesn't take long before a small dick starts to shrink until it disappears!";
						if (GameControl.testiclesSize >= 0) 
						{
							WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour testicles have shrink too until they are gone!"; 
							GameControl.testiclesSize = 0;
							GameControl.mcTesticlesName =  GameControl.MCTesticleName.NONE; 
						}
					}else if (GameControl.dick2Size <= 0 && GameControl.dickNum > 1) {
						GameControl.dickNum = 1; 
						GameControl.dick2Size = 0; 
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour second dick has shrinked until it disappeared!"; 
					}

				} else {
					GameControl.dick1Size = GameControl.dick1Size - 2; 
					charSettler.setCharDick1Name ();
					WorldControl.itemUseText = "A weak taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, reducing the size of your dick only 2 cm of its length";
					if (GameControl.dick1Size <= 0) {
						GameControl.dickNum = 0; 
						GameControl.dick1Size = 0; 
						GameControl.dick2Size = 0; 
						charSettler.setCharDick1Name ();
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = "Immediately after taking the potion you start to feel a weird sensation around your crotch, and it doesn't take long before a small dick starts to shrink until it disappears!";
						if (GameControl.testiclesSize >= 0) 
						{
							WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour testicles have shrink too until they are gone!"; 
							GameControl.testiclesSize = 0;
							GameControl.mcTesticlesName =  GameControl.MCTesticleName.NONE; 
						}
					}
				}

			}
		}
		if (GameControl.dick2Size <= 0 && GameControl.dickNum > 1) {
			GameControl.dickNum = 1; 
			GameControl.dick2Size = 0; 
			charSettler.setCharDick2Name ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour second dick has shrinked until it disappeared!"; 
		}

	}


	public void betaX() {
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (GameControl.dickNum <= 0) {
			GameControl.dickNum = 0;
			GameControl.dick1Size = 0;
			GameControl.dick2Size = 0; 
			GameControl.testiclesSize = 0; 
			charSettler.setCharDick1Name ();
			charSettler.setCharDick2Name ();
			charSettler.setTesticlesName ();
			WorldControl.itemUseText = "The potion has no effect since you have no dick!";
		} else {

			if (randNum > 90) {


				if (GameControl.dickNum > 1) 
				{
					GameControl.dick1Size = GameControl.dick1Size - 8; 
					GameControl.dick2Size = GameControl.dick2Size - 5; 
					GameControl.dick1Thick = GameControl.dick1Thick - 1; 
					GameControl.dick2Thick = GameControl.dick2Thick - 1; 
					charSettler.setCharDick1Name ();
					charSettler.setCharDick2Name ();
					WorldControl.itemUseText = "A very strong taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, reducing the size of your dick significantly! Your first dick loses 8 cm and the second one 5 in length!";
					if (GameControl.dick1Size <= 0) {
						GameControl.dickNum = 0; 
						GameControl.dick1Size = 0; 
						GameControl.dick2Size = 0; 
						GameControl.dick1Thick = 0; 
						GameControl.dick2Thick = 0; 
						charSettler.setCharDick1Name ();
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = "Immediately after taking the potion you start to feel a weird sensation around your crotch, and it doesn't take long before a your dick starts to shrink until it disappears!";
						if (GameControl.testiclesSize > 0) 
						{
							WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour testicles have shrink too until they are gone!"; 
							GameControl.testiclesSize = 0;
							GameControl.mcTesticlesName =  GameControl.MCTesticleName.NONE; 
						}
					}else if (GameControl.dick2Size <= 0 && GameControl.dickNum > 1) {
						GameControl.dickNum = 1; 
						GameControl.dick2Size = 0; 
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour second dick has shrinked until it disappeared!"; 
					}

				} else 
				{
					GameControl.dick1Size = GameControl.dick1Size - 8; 
					GameControl.dick1Thick = GameControl.dick1Thick - 2; 
					charSettler.setCharDick1Name ();
					WorldControl.itemUseText = "A very strong taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, reducing the size of your dick 8 cm in length!";
					if (GameControl.dick1Size <= 0) {
						GameControl.dickNum = 0; 
						GameControl.dick1Size = 0; 
						GameControl.dick2Size = 0; 
						GameControl.dick1Thick = 0; 
						GameControl.dick2Thick = 0; 
						charSettler.setCharDick1Name ();
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = WorldControl.itemUseText + "\n\nImmediately after taking the potion you start to feel a weird sensation around your crotch, and it doesn't take long before your dick starts to shrink until it disappears!";
						if (GameControl.testiclesSize >= 0) 
						{
							WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour testicles have shrink too until they are gone!"; 
							GameControl.testiclesSize = 0;
							GameControl.mcTesticlesName =  GameControl.MCTesticleName.NONE; 
						}
					}
				}


			} else if (randNum > 10) 
			{

				if (GameControl.dickNum > 1) {
					GameControl.dick1Size = GameControl.dick1Size - 5; 
					GameControl.dick2Size = GameControl.dick2Size - 3; 
					GameControl.dick1Thick = GameControl.dick1Thick - 1; 
					GameControl.dick2Thick = GameControl.dick2Thick - 1; 
					charSettler.setCharDick1Name ();
					charSettler.setCharDick2Name ();
					WorldControl.itemUseText = "A strong taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, reducing the size of your dick! Your first dick loses 5 cm and the second one 3 in length!";
					if (GameControl.dick1Size <= 0)
					{
						GameControl.dickNum = 0; 
						GameControl.dick1Size = 0; 
						GameControl.dick2Size = 0; 
						charSettler.setCharDick1Name ();
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = "Immediately after taking the potion you start to feel a weird sensation around your crotch, and it doesn't take long before a small dick starts to shrink until it disappears!";
						if (GameControl.testiclesSize > 0) 
						{
							WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour testicles have shrink too until they are gone!"; 
							GameControl.testiclesSize = 0;
							GameControl.mcTesticlesName =  GameControl.MCTesticleName.NONE; 
						}
					}
					else if (GameControl.dick2Size <= 0 && GameControl.dickNum > 1) {
						GameControl.dickNum = 1; 
						GameControl.dick2Size = 0; 
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour second dick has shrinked until it disappeared!"; 
					}
				} else {
					GameControl.dick1Size = GameControl.dick1Size - 5; 
					GameControl.dick1Thick = GameControl.dick1Thick - 2; 
					charSettler.setCharDick1Name ();
					WorldControl.itemUseText = "A strong taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, reducing the size of your dick 5 cm in length!";
					if (GameControl.dick1Size <= 0) {
						GameControl.dickNum = 0; 
						GameControl.dick1Size = 0; 
						GameControl.dick2Size = 0; 
						charSettler.setCharDick1Name ();
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = "Immediately after taking the potion you start to feel a weird sensation around your crotch, and it doesn't take long before a small dick starts to shrink until it disappears!";
						if (GameControl.testiclesSize > 0) 
						{
							WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour testicles have shrink too until they are gone!"; 
							GameControl.testiclesSize = 0;
							GameControl.mcTesticlesName =  GameControl.MCTesticleName.NONE; 
						}
					}
				}

			} 
			else
			{

				if (GameControl.dickNum > 1) {
					GameControl.dick1Size = GameControl.dick1Size - 3; 
					GameControl.dick2Size = GameControl.dick2Size - 2; 
					GameControl.dick1Thick = GameControl.dick1Thick - 1; 
					GameControl.dick2Thick = GameControl.dick2Thick - 1; 
					charSettler.setCharDick1Name ();
					charSettler.setCharDick2Name ();
					WorldControl.itemUseText = "A weak taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, reducing the size of your dick. Your first dick loses 3 cm and the second one 2 in length!";
					if (GameControl.dick1Size <= 0) {
						GameControl.dickNum = 0; 
						GameControl.dick1Size = 0; 
						GameControl.dick2Size = 0; 
						GameControl.dick1Thick = 0; 
						GameControl.dick2Thick = 0; 
						charSettler.setCharDick1Name ();
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = "Immediately after taking the potion you start to feel a weird sensation around your crotch, and it doesn't take long before a small dick starts to shrink until it disappears!";
					}else if (GameControl.dick2Size <= 0) {
						GameControl.dickNum = 1; 
						GameControl.dick2Size = 0; 
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour second dick has shrinked until it disappeared!"; 
					}
				} 
				else {
					GameControl.dick1Size = GameControl.dick1Size - 3; 
					GameControl.dick1Thick = GameControl.dick1Thick - 1; 
					charSettler.setCharDick1Name ();
					WorldControl.itemUseText = "A weak taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, reducing the size of your dick only 3 cm of its length";
					if (GameControl.dick1Size <= 0) {
						GameControl.dickNum = 0; 
						GameControl.dick1Size = 0; 
						GameControl.dick2Size = 0; 
						GameControl.dick1Thick = 0; 
						GameControl.dick2Thick = 0; 
						charSettler.setCharDick1Name ();
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = "Immediately after taking the potion you start to feel a weird sensation around your crotch, and it doesn't take long before a small dick starts to shrink until it disappears!";
					}
				}

			}
		}
		if (GameControl.dick2Size <= 0 && GameControl.dickNum > 1) {
			GameControl.dickNum = 1; 
			GameControl.dick2Size = 0; 
			charSettler.setCharDick2Name ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour second dick has shrinked until it disappeared!"; 
		}

	}




	public void betaXS() {
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (GameControl.dickNum <= 0) {
			GameControl.dickNum = 0;
			GameControl.dick1Size = 0;
			GameControl.dick2Size = 0; 
			GameControl.testiclesSize = 0; 
			charSettler.setCharDick1Name ();
			charSettler.setCharDick2Name ();
			charSettler.setTesticlesName ();
			WorldControl.itemUseText = "The potion has no effect since you have no dick!";
		} else {

			if (randNum > 90) {


				if (GameControl.dickNum > 1) 
				{
					GameControl.dick1Size = GameControl.dick1Size - 12; 
					GameControl.dick2Size = GameControl.dick2Size - 12; 
					charSettler.setCharDick1Name ();
					charSettler.setCharDick2Name ();
					WorldControl.itemUseText = "A very strong taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, reducing the size of your dick significantly! both lose 12 cm in length!";
					if (GameControl.dick1Size <= 0)
					{
						GameControl.dickNum = 0; 
						GameControl.dick1Size = 0; 
						GameControl.dick2Size = 0; 
						charSettler.setCharDick1Name ();
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = "Immediately after taking the potion you start to feel a weird sensation around your crotch, and it doesn't take long before a small dick starts to shrink until it disappears!";

						if (GameControl.testiclesSize >= 0) 
						{
							WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour testicles have shrink too until they are gone!"; 
							GameControl.testiclesSize = 0;
							GameControl.mcTesticlesName =  GameControl.MCTesticleName.NONE; 
						}
					}else if (GameControl.dick2Size <= 0 && GameControl.dickNum > 1) {
						GameControl.dickNum = 1; 
						GameControl.dick2Size = 0; 
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour second dick has shrinked until it disappeared!"; 
					}

				}
				else 
				{
					GameControl.dick1Size = GameControl.dick1Size - 12; 
					charSettler.setCharDick1Name ();
					WorldControl.itemUseText = "A very strong taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, reducing the size of your dick 12 cm in length!";
					if (GameControl.dick1Size <= 0) {
						GameControl.dickNum = 0; 
						GameControl.dick1Size = 0; 
						GameControl.dick2Size = 0; 
						charSettler.setCharDick1Name ();
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = "Immediately after taking the potion you start to feel a weird sensation around your crotch, and it doesn't take long before a small dick starts to shrink until it disappears!";
						if (GameControl.testiclesSize >= 0) 
						{
							WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour testicles have shrink too until they are gone!"; 
							GameControl.testiclesSize = 0;
							GameControl.mcTesticlesName =  GameControl.MCTesticleName.NONE; 
						}
					}
				}


			} else if (randNum > 10) 
			{

				if (GameControl.dickNum > 1) {
					GameControl.dick1Size = GameControl.dick1Size - 8; 
					GameControl.dick2Size = GameControl.dick2Size - 8; 
					charSettler.setCharDick1Name ();
					charSettler.setCharDick2Name ();
					WorldControl.itemUseText = "A strong taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, reducing the size of your dick! Both lose 8 cm in length!";
					if (GameControl.dick1Size <= 0) {
						GameControl.dickNum = 0; 
						GameControl.dick1Size = 0; 
						GameControl.dick2Size = 0; 
						charSettler.setCharDick1Name ();
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = "Immediately after taking the potion you start to feel a weird sensation around your crotch, and it doesn't take long before a small dick starts to shrink until it disappears!";
						if (GameControl.testiclesSize >= 0) 
						{
							WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour testicles have shrink too until they are gone!"; 
							GameControl.testiclesSize = 0;
							GameControl.mcTesticlesName =  GameControl.MCTesticleName.NONE; 
						}
					} else if (GameControl.dick2Size <= 0) {
						GameControl.dickNum = 1; 
						GameControl.dick2Size = 0; 
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour second dick has shrinked until it disappeared!"; 
					}
				} else {
					GameControl.dick1Size = GameControl.dick1Size - 8; 
					charSettler.setCharDick1Name ();
					WorldControl.itemUseText = "A strong taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, reducing the size of your dick 8 cm in length!";
					if (GameControl.dick1Size <= 0) {
						GameControl.dickNum = 0; 
						GameControl.dick1Size = 0; 
						GameControl.dick2Size = 0; 
						charSettler.setCharDick1Name ();
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = "Immediately after taking the potion you start to feel a weird sensation around your crotch, and it doesn't take long before a small dick starts to shrink until it disappears!";
						if (GameControl.testiclesSize >= 0) 
						{
							WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour testicles have shrink too until they are gone!"; 
							GameControl.testiclesSize = 0;
							GameControl.mcTesticlesName =  GameControl.MCTesticleName.NONE; 
						}
					}
				}

			} 
			else
			{

				if (GameControl.dickNum > 1) {
					GameControl.dick1Size = GameControl.dick1Size - 5; 
					GameControl.dick2Size = GameControl.dick2Size - 5; 
					charSettler.setCharDick1Name ();
					charSettler.setCharDick2Name ();
					WorldControl.itemUseText = "A weak taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, reducing the size of your dick. Both lose 5 cm in length!";
					if (GameControl.dick1Size <= 0) {
						GameControl.dickNum = 0; 
						GameControl.dick1Size = 0; 
						GameControl.dick2Size = 0; 
						charSettler.setCharDick1Name ();
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = "Immediately after taking the potion you start to feel a weird sensation around your crotch, and it doesn't take long before a small dick starts to shrink until it disappears!";
						if (GameControl.testiclesSize >= 0) 
						{
							WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour testicles have shrink too until they are gone!"; 
							GameControl.testiclesSize = 0;
							GameControl.mcTesticlesName =  GameControl.MCTesticleName.NONE; 
						}
					}
				} else {
					GameControl.dick1Size = GameControl.dick1Size - 5; 
					charSettler.setCharDick1Name ();
					WorldControl.itemUseText = "A weak taste fills your mouth, but also fills your body with its same strenght, and its effects act immediately, reducing the size of your dick only 5 cm of its length";
					if (GameControl.dick1Size <= 0) {
						GameControl.dickNum = 0; 
						GameControl.dick1Size = 0; 
						GameControl.dick2Size = 0; 
						charSettler.setCharDick1Name ();
						charSettler.setCharDick2Name ();
						WorldControl.itemUseText = "Immediately after taking the potion you start to feel a weird sensation around your crotch, and it doesn't take long before a small dick starts to shrink until it disappears!";
						if (GameControl.testiclesSize >= 0) 
						{
							WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour testicles have shrink too until they are gone!"; 
							GameControl.testiclesSize = 0;
							GameControl.mcTesticlesName =  GameControl.MCTesticleName.NONE; 
						}
					}
				}

			}
		}



	}




	public void nutcrackerAleW(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (GameControl.testiclesSize > 0) {

			if (randNum > 90)
			{
				GameControl.testiclesSize = GameControl.testiclesSize - 3;
				charSettler.setTesticlesName ();
				WorldControl.itemUseText = "The sticky substance stays in your mouth for a while, but afterwards you can see its powerful effects, reducing the size of your testicles 3cm!";
				if (GameControl.testiclesSize <= 0) {
					GameControl.testiclesSize = 0;
					charSettler.setTesticlesName ();
					WorldControl.itemUseText = "You feel a weird sensation under your crotch, and after a couple of minutes you realize that you finally got rid of your balls!";
				}

			} 
			else if (randNum > 10) 
			{
				GameControl.testiclesSize = GameControl.testiclesSize - 2;
				charSettler.setTesticlesName ();
				WorldControl.itemUseText = "The sticky substance stays in your mouth for a while, but afterwards you can see its effects, reducing the size of your testicles 2cm!";
				if (GameControl.testiclesSize <= 0) {
					GameControl.testiclesSize = 0;
					charSettler.setTesticlesName ();
					WorldControl.itemUseText = "You feel a weird sensation under your crotch, and after a couple of minutes you realize that you finally got rid of your balls!";
				}

			} 
			else 
			{
				GameControl.testiclesSize = GameControl.testiclesSize - 1;
				charSettler.setTesticlesName ();
				WorldControl.itemUseText = "The sticky substance stays in your mouth for a while, but afterwards you can see its weak effects, reducing the size of your testicles only 1cm";
				if (GameControl.testiclesSize <= 0) {
					GameControl.testiclesSize = 0;
					charSettler.setTesticlesName ();
					WorldControl.itemUseText = "You feel a weird sensation under your crotch, and after a couple of minutes you realize that you finally got rid of your balls!";
				}
			}
		} 
		else 
		{
			WorldControl.itemUseText = "You have no balls! the potion obviously fails to do anything on you.";
		}


		if (GameControl.testiclesSize <= 0) {
			GameControl.testiclesSize = 0;
			charSettler.setTesticlesName ();
			WorldControl.itemUseText = "You feel a weird sensation under your crotch, and after a couple of minutes you realize that you finally got rid of your balls!";
		}


	}






	public void nutcrackerAle(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (GameControl.testiclesSize > 0) {

			if (randNum > 90)
			{
				GameControl.testiclesSize = GameControl.testiclesSize - 4;
				charSettler.setTesticlesName ();
				WorldControl.itemUseText = "The sticky substance stays in your mouth for a while, but afterwards you can see its powerful effects, reducing the size of your testicles 4cm!";
				if (GameControl.testiclesSize <= 0) {
					GameControl.testiclesSize = 0;
					charSettler.setTesticlesName ();
					WorldControl.itemUseText = "You feel a weird sensation under your crotch, and after a couple of minutes you realize that you finally got rid of your balls!";
				}

			} 
			else if (randNum > 10) 
			{
				GameControl.testiclesSize = GameControl.testiclesSize - 3;
				charSettler.setTesticlesName ();
				WorldControl.itemUseText = "The sticky substance stays in your mouth for a while, but afterwards you can see its effects, reducing the size of your testicles 3cm!";
				if (GameControl.testiclesSize <= 0) {
					GameControl.testiclesSize = 0;
					charSettler.setTesticlesName ();
					WorldControl.itemUseText = "You feel a weird sensation under your crotch, and after a couple of minutes you realize that you finally got rid of your balls!";
				}

			} 
			else 
			{
				GameControl.testiclesSize = GameControl.testiclesSize - 2;
				charSettler.setTesticlesName ();
				WorldControl.itemUseText = "The sticky substance stays in your mouth for a while, but afterwards you can see its weak effects, reducing the size of your testicles only 2cm.";
				if (GameControl.testiclesSize <= 0) {
					GameControl.testiclesSize = 0;
					charSettler.setTesticlesName ();
					WorldControl.itemUseText = "You feel a weird sensation under your crotch, and after a couple of minutes you realize that you finally got rid of your balls!";
				}
			}
		} 
		else 
		{
			WorldControl.itemUseText = "You have no balls! the potion obviously fails to do anything on you.";
		}




	}


	public void nutcrackerAleS(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (GameControl.testiclesSize > 0) {

			if (randNum > 90)
			{
				GameControl.testiclesSize = GameControl.testiclesSize - 6;
				charSettler.setTesticlesName ();
				WorldControl.itemUseText = "The sticky substance stays in your mouth for a while, but afterwards you can see its powerful effects, reducing the size of your testicles 6cm!";
				if (GameControl.testiclesSize <= 0) {
					GameControl.testiclesSize = 0;
					charSettler.setTesticlesName ();
					WorldControl.itemUseText = "You feel a weird sensation under your crotch, and after a couple of minutes you realize that you finally got rid of your balls!";
				}

			} 
			else if (randNum > 10) 
			{
				GameControl.testiclesSize = GameControl.testiclesSize - 5;
				charSettler.setTesticlesName ();
				WorldControl.itemUseText = "The sticky substance stays in your mouth for a while, but afterwards you can see its effects, reducing the size of your testicles 5cm!";
				if (GameControl.testiclesSize <= 0) {
					GameControl.testiclesSize = 0;
					charSettler.setTesticlesName ();
					WorldControl.itemUseText = "You feel a weird sensation under your crotch, and after a couple of minutes you realize that you finally got rid of your balls!";
				}

			} 
			else 
			{
				GameControl.testiclesSize = GameControl.testiclesSize - 3;
				charSettler.setTesticlesName ();
				WorldControl.itemUseText = "The sticky substance stays in your mouth for a while, but afterwards you can see its weak effects, reducing the size of your testicles only 3cm.";
				if (GameControl.testiclesSize <= 0) {
					GameControl.testiclesSize = 0;
					charSettler.setTesticlesName ();
					WorldControl.itemUseText = "You feel a weird sensation under your crotch, and after a couple of minutes you realize that you finally got rid of your balls!";
				}

			}
		} 
		else 
		{
			WorldControl.itemUseText = "You have no balls! the potion obviously fails to do anything on you.";
		}

	}
	public void mommaSurW(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (GameControl.testiclesSize > 0) {

			if (randNum > 90)
			{
				GameControl.lactating = true; 
				GameControl.lactatingTurns = GameControl.lactatingTurns + 10; 
				GameControl.milkProduction = GameControl.milkProduction + 80; 
				WorldControl.itemUseText = "A delicious and oddly familiar taste fills your mouth, and after some minutes you notice your chest all damped by your own milk. You are lactating now! Your milk production increased by 80 ml!";

			} 
			else if (randNum > 10) 
			{
				GameControl.lactating = true; 
				GameControl.lactatingTurns = GameControl.lactatingTurns + 5; 
				GameControl.milkProduction = GameControl.milkProduction + 60; 
				WorldControl.itemUseText = "An oddly familiar taste fills your mouth, and after some minutes you notice your chest all damped by your own milk. You are lactating now! Your milk production increased by 60 ml!";


			} 
			else 
			{
				GameControl.lactating = true; 
				GameControl.lactatingTurns = GameControl.lactatingTurns + 5; 
				GameControl.milkProduction = GameControl.milkProduction + 40; 
				WorldControl.itemUseText = "An odd taste fills your mouth, and after some minutes you notice your chest all damped by your own milk. You are lactating now! Your milk production increased by 40 ml!";


			}
		} 

	}

	public void mommaSur()
	{
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (GameControl.testiclesSize > 0) {

			if (randNum > 90)
			{
				GameControl.lactating = true; 
				GameControl.lactatingTurns = GameControl.lactatingTurns + 10; 
				GameControl.milkProduction = GameControl.milkProduction + 100; 
				WorldControl.itemUseText = "A delicious and oddly familiar taste fills your mouth, and after some minutes you notice your chest all damped by your own milk. You are lactating now! Your milk production increased by 100 ml!";

			} 
			else if (randNum > 10) 
			{
				GameControl.lactating = true; 
				GameControl.lactatingTurns = GameControl.lactatingTurns + 10; 
				GameControl.milkProduction = GameControl.milkProduction + 80; 
				WorldControl.itemUseText = "An oddly familiar taste fills your mouth, and after some minutes you notice your chest all damped by your own milk. You are lactating now! Your milk production increased by 80 ml!";


			} 
			else 
			{
				GameControl.lactating = true; 
				GameControl.lactatingTurns = GameControl.lactatingTurns + 10; 
				GameControl.milkProduction = GameControl.milkProduction + 60; 
				WorldControl.itemUseText = "An odd taste fills your mouth, and after some minutes you notice your chest all damped by your own milk. You are lactating now! Your milk production increased by 60 ml!";


			}
		} 

	}
	public void mommaSurS(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (GameControl.testiclesSize > 0) {

			if (randNum > 90)
			{
				GameControl.lactating = true; 
				GameControl.lactatingTurns = GameControl.lactatingTurns + 10; 
				GameControl.milkProduction = GameControl.milkProduction + 200; 
				WorldControl.itemUseText = "A delicious and oddly familiar taste fills your mouth, and after some minutes you notice your chest all damped by your own milk. You are lactating now! Your milk production increased by 200 ml!";

			} 
			else if (randNum > 10) 
			{
				GameControl.lactating = true; 
				GameControl.lactatingTurns = GameControl.lactatingTurns + 10; 
				GameControl.milkProduction = GameControl.milkProduction + 150; 
				WorldControl.itemUseText = "An oddly familiar taste fills your mouth, and after some minutes you notice your chest all damped by your own milk. You are lactating now! Your milk production increased by 150 ml!";


			} 
			else 
			{
				GameControl.lactating = true; 
				GameControl.lactatingTurns = GameControl.lactatingTurns + 10; 
				GameControl.milkProduction = GameControl.milkProduction + 100; 
				WorldControl.itemUseText = "An odd taste fills your mouth, and after some minutes you notice your chest all damped by your own milk. You are lactating now! Your milk production increased by 100 ml!";


			}
		} 

	}





	public void fertilityPill(){
		if (GameControl.fertile == false) {
			GameControl.fertile = true; 
			WorldControl.itemUseText = "You swallow the pill and you start to feel weird, as if your seed is powerful again";
		} else {
			WorldControl.itemUseText = "You swallow the pill but you don't feel any change.";
		}

	}
	public void infertilityPill(){
		if (GameControl.fertile == true) {
			GameControl.fertile = false; 
			WorldControl.itemUseText = "You swallow the pill and you start to feel weird, as if your seed has lost all of its power.";
		} else {
			WorldControl.itemUseText = "You swallow the pill but you don't feel any change.";
		}

	}

	public void darkElixirW(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (randNum > 90)
		{
			GameControl.charCorruption = GameControl.charCorruption + 10;
			WorldControl.itemUseText = "You take the cork out and drink the elixir, which tastes like rotten fruits and honey. Its powerful taste starts to corrupt you from within ";
		} 
		else if (randNum > 10) 
		{
			GameControl.charCorruption = GameControl.charCorruption + 6;
			WorldControl.itemUseText = "You take the cork out and drink the elixir, which tastes like rotten fruits and honey. Its powerful taste starts to corrupt you from within ";
		} 
		else 
		{
			GameControl.charCorruption = GameControl.charCorruption + 4;
			WorldControl.itemUseText = "You take the cork out and drink the elixir, which tastes like rotten fruits and honey. Its powerful taste starts to corrupt you from within ";
		}

	}


	public void darkElixir(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (randNum > 90)
		{
			GameControl.charCorruption = GameControl.charCorruption + 10;
			WorldControl.itemUseText = "You take the cork out and drink the elixir, which tastes like rotten fruits and honey. Its powerful taste starts to corrupt you from within ";
		} 
		else if (randNum > 10) 
		{
			GameControl.charCorruption = GameControl.charCorruption + 6;
			WorldControl.itemUseText = "You take the cork out and drink the elixir, which tastes like rotten fruits and honey. Its powerful taste starts to corrupt you from within ";
		} 
		else 
		{
			GameControl.charCorruption = GameControl.charCorruption + 4;
			WorldControl.itemUseText = "You take the cork out and drink the elixir, which tastes like rotten fruits and honey. Its powerful taste starts to corrupt you from within ";
		}
		if (GameControl.charCorruption > 100) {
			GameControl.charCorruption = 100; 
		}
	}



	public void darkElixirS(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (randNum > 90)
		{
			GameControl.charCorruption = GameControl.charCorruption + 14;
			WorldControl.itemUseText = "You take the cork out and drink the elixir, which tastes like rotten fruits and honey. Its powerful taste starts to corrupt you from within ";
		} 
		else if (randNum > 10) 
		{
			GameControl.charCorruption = GameControl.charCorruption + 10;
			WorldControl.itemUseText = "You take the cork out and drink the elixir, which tastes like rotten fruits and honey. Its powerful taste starts to corrupt you from within ";
		} 
		else 
		{
			GameControl.charCorruption = GameControl.charCorruption + 6;
			WorldControl.itemUseText = "You take the cork out and drink the elixir, which tastes like rotten fruits and honey. Its powerful taste starts to corrupt you from within ";
		}

	}



	public void pureElixirW(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (randNum > 90)
		{
			GameControl.charCorruption = GameControl.charCorruption - 10;
			WorldControl.itemUseText = "You take the cork out and drink the elixir, which tastes like fruits and honey. Its powerful taste starts to purify you from within ";
		} 
		else if (randNum > 10) 
		{
			GameControl.charCorruption = GameControl.charCorruption - 6;
			WorldControl.itemUseText = "You take the cork out and drink the elixir, which tastes like fruits and honey. Its powerful taste starts to purify you from within ";
		} 
		else 
		{
			GameControl.charCorruption = GameControl.charCorruption - 4;
			WorldControl.itemUseText = "You take the cork out and drink the elixir, which tastes like fruits and honey. Its powerful taste starts to purify you from within ";
		}
	}


	public void pureElixir(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (randNum > 90)
		{
			GameControl.charCorruption = GameControl.charCorruption - 14;
			WorldControl.itemUseText = "You take the cork out and drink the elixir, which tastes like fruits and honey. Its powerful taste starts to purify you from within ";
		} 
		else if (randNum > 10) 
		{
			GameControl.charCorruption = GameControl.charCorruption - 10;
			WorldControl.itemUseText = "You take the cork out and drink the elixir, which tastes like fruits and honey. Its powerful taste starts to purify you from within ";
		} 
		else 
		{
			GameControl.charCorruption = GameControl.charCorruption - 6;
			WorldControl.itemUseText = "You take the cork out and drink the elixir, which tastes like fruits and honey. Its powerful taste starts to purify you from within ";
		}		
		if (GameControl.charCorruption < 0) {
			GameControl.charCorruption = 0; 
		}

	}


	public void pureElixirS(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (randNum > 90)
		{
			GameControl.charCorruption = GameControl.charCorruption - 8;
			WorldControl.itemUseText = "You take the cork out and drink the elixir, which tastes like fruits and honey. Its powerful taste starts to purify you from within ";
		} 
		else if (randNum > 10) 
		{
			GameControl.charCorruption = GameControl.charCorruption - 6;
			WorldControl.itemUseText = "You take the cork out and drink the elixir, which tastes like fruits and honey. Its powerful taste starts to purify you from within ";
		} 
		else 
		{
			GameControl.charCorruption = GameControl.charCorruption - 4;
			WorldControl.itemUseText = "You take the cork out and drink the elixir, which tastes like fruits and honey. Its powerful taste starts to purify you from within ";
		}
		if (GameControl.charCorruption < 0) {
			GameControl.charCorruption = 0; 
		}

	}


	public void aphrodisiac(){
		GameControl.actualArousal = GameControl.actualArousal + 30; 
		WorldControl.itemUseText = "The scented potion increased your lust, getting you ready for some action.";

	}

	public void vagAway(){
		GameControl.hasVagina = false; 
		GameControl.isPregnant = false; 
		GameControl.pregnantCounter = 0; 
		charSettler.setCharGender ();
	}
		

	public void giftUse(int selector){
		int i = 0;

		while (i < 10) {
			if (GameControl.invSlotArray [i, 0] == selector && GameControl.invSlotArray [i, 1] < 5 ) {
				GameControl.invSlotArray [i, 1]++;
				WorldControl.itemUseText = "You have no use for this item, it can be used only as a gift!";
				return;
			}
			i++;
		}
		while (i < 10) {
			if (GameControl.invSlotArray [i, 0] == selector) {
				GameControl.invSlotArray [i, 1]++;
				WorldControl.itemUseText = "You have no use for this item, it can be used only as a gift!";
				return;
			}
			i++;
		}
	}




	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	///
	///
	/// <summary>
	/// RACES 
	/// </summary>
	/// 
	/// 
	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





	// bunny - ID 02 
	public void rabbitConct(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (randNum > 95) {
			rabbitMud ();
			rabbitLotion ();
			rabbitOil ();
			rabbitDist ();
			WorldControl.itemUseText = "Your full body starts to transform! After some minutes of excruciating pain your whole body starts to look more like a rabbit person!"; 
		} else if (randNum > 70) {
			rabbitLotion ();
		} else if (randNum > 45) {
			rabbitOil ();
		} else if (randNum > 25) {
			rabbitMud ();
		} else {
			rabbitDist ();
		} 

			
	}
		



	public void rabbitMud(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.mcHead != GameControl.MCHead.BUNNY) 
		{
			if (WorldControl.furryOn == true) 
			{
				GameControl.mcHead = GameControl.MCHead.BUNNY;
				WorldControl.itemUseText = "Your head hurts, though not as much as the first time: You can feel how soft fur begins to grow all around your face, while your nose and mouth become rabbit-like.  Seems like the transformation is complete!  "; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 
	
			}	else 
			{
				GameControl.mcHead = GameControl.MCHead.BUNNY;

				WorldControl.itemUseText = "Your face feels very strange: Bones moving around, muscles transforming left and right. Its an incredible headache, but after a couple of minutes is over. You dress at yourself in a mirror, and you can see now a nice couple of pink bunny ears sprouting from your head."; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 
			}

		} 



		if (randNum > 80) {

			GameControl.facialFeaturesStat = GameControl.facialFeaturesStat + 2; 
			charSettler.setCharFemininity ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour face becomes more softer and delicate, increasing its femininity significantly!"; 
		} else if (randNum > 60) {
			GameControl.facialFeaturesStat = GameControl.facialFeaturesStat + 1; 
			charSettler.setCharFemininity ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour face becomes sligthly more softer and delicate, increasing its femininity!";

		} else if (randNum > 50 && GameControl.hasFur) {
			GameControl.mcFurColor = GameControl.MCFurColor.Grey; 
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour fur becomes pink!";
		}
			

	}





	public void rabbitLotion(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.mcArms != GameControl.MCArms.BUNNY) 
		{
			if (WorldControl.furryOn == true) 
			{
				GameControl.mcArms = GameControl.MCArms.BUNNY;
				WorldControl.itemUseText = "Your arms hurts, although not as much as the first time: You can feel how soft fur begins to grow all around your arms and torso.  Seems like the transformation is complete! "; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 

			}	else 
			{
				
				GameControl.mcArms = GameControl.MCArms.BUNNY;
				WorldControl.itemUseText = "Your hands start to hurt and transform into pretty cute rabbit paws, both plushy and adorable."; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 
			}

		} 



		if (randNum > 80) {

			GameControl.breast1Size = GameControl.breast1Size - 8;
			charSettler.setCharBreasts1 ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour breast decrease their size significantly! I guess rabbits are usually kinda flat after all..."; 
		} else if (randNum > 60) {
			GameControl.breast1Size = GameControl.breast1Size - 4;
			charSettler.setCharBreasts1 ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour breast decrease their size! I guess rabbits are usually kinda flat after all...";

		} else if (randNum > 50 && GameControl.hasFur) {
			GameControl.mcFurColor = GameControl.MCFurColor.Grey; 
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour fur becomes pink!";
		}
	}




	public void rabbitOil()
	{
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.mcLegs != GameControl.MCLegs.BUNNY) 
		{
			if (WorldControl.furryOn == true) 
			{
				GameControl.mcLegs = GameControl.MCLegs.BUNNY;
				WorldControl.itemUseText = "Your legs hurts, although not as much as the first time: You can feel how soft fur begins to grow all around your legs. You have finish the transformation of your legs! "; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 
			}		else 
			{
				GameControl.mcLegs = GameControl.MCLegs.BUNNY;

				WorldControl.itemUseText = "Your legs start to hurt, and soon enough your feet transform into pretty cute rabbit paws, both plushy and adorable!"; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 
			}


		} 


		if (randNum > 80) {
			GameControl.hipsSize = GameControl.hipsSize + 8; 
			charSettler.setHips ();
			GameControl.assSize = GameControl.assSize + 8;
			charSettler.setCharAss ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour hips and ass increased their size significantly! I guess rabbits-girls are usually pack a nice ass..."; 
		} else if (randNum > 60) {
			GameControl.hipsSize = GameControl.hipsSize + 4; 
			charSettler.setHips ();
			GameControl.assSize = GameControl.assSize + 4;
			charSettler.setCharAss ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour hips and ass increased their size! I guess rabbits-girls are usually pack a nice ass..."; 

		} else if (randNum > 50 && GameControl.hasFur) {
			GameControl.mcFurColor = GameControl.MCFurColor.blue; 
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour fur becomes pink!";
		} else if (randNum > 30) {
			GameControl.mcTailType = GameControl.MCTailType.Bunny; 
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour back hurts a lot for a second, and when you turn around realize you have a bunny tail now! Cute!";
		}

	}




	public void rabbitDist(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (randNum > 95) 
		{
			GameControl.facialFeaturesStat = GameControl.facialFeaturesStat + 2; 
			charSettler.setCharFemininity ();
			GameControl.mcFurColor = GameControl.MCFurColor.blue;  
			GameControl.breast1Size = GameControl.breast1Size - 8;
			charSettler.setCharBreasts1 ();
			GameControl.hipsSize = GameControl.hipsSize + 8; 
			charSettler.setHips ();
			GameControl.assSize = GameControl.assSize + 8;
			charSettler.setCharAss ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = "The potion was very powerful! Your ass and hips increase their size significantly, while you are now more flat chested! Also it seems like your fur is now pink.";

		} else if (randNum > 90) {
			GameControl.mcFurColor = GameControl.MCFurColor.blue;  
			WorldControl.itemUseText =  "The potion wasnt that powerful, but your fur becomes pink!";

		}else if (randNum > 60) {
			GameControl.breast1Size = GameControl.breast1Size - 8;
			charSettler.setCharBreasts1 ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = "You have become more flat chested!";

		}else if (randNum > 30) {
			GameControl.hipsSize = GameControl.hipsSize + 8; 
			charSettler.setHips ();
			GameControl.assSize = GameControl.assSize + 8;
			charSettler.setCharAss ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = "Your hips and ass increase in size significantly!";
		}else if (randNum > 0) {
			GameControl.facialFeaturesStat = GameControl.facialFeaturesStat + 2; 
			charSettler.setCharFemininity ();
			WorldControl.itemUseText = "The potion was not so powerful but your face looks more femenine at least.";

		}


	}



	public void wolfConct(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (randNum > 85) {
			wolfMud ();
			wolfLotion ();
			wolfOil ();
			wolfDist ();
			WorldControl.itemUseText = "Your full body starts to transform! After some minutes of excruciating pain your whole body starts to look more like a werewolf!"; 
			MCRaceSettler.updateRace ();
		} else if (randNum > 60) {
			wolfLotion ();
		} else if (randNum > 35) {
			wolfOil ();
		} else if (randNum > 15) {
			wolfMud ();
		} else {
			wolfDist ();
		} 

	}


	public void wolfMud(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.mcHead != GameControl.MCHead.WOLF) 
		{
			if (WorldControl.furryOn == true) 
			{
				GameControl.mcHead = GameControl.MCHead.WOLF;
				WorldControl.itemUseText = "Your head hurts, though not as much as the first time: You can feel how fur begins to grow all around your face, while your nose and mouth become wolf like. You have finish the transformation of your head! "; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 

			}	else 
			{
				
				GameControl.mcHead = GameControl.MCHead.WOLF;
				WorldControl.itemUseText = "Your face feels very strange: Bones moving around, muscles transforming left and right. Its an incredible headache, but after a couple of minutes is over. You dress at yourself in a mirror, and you can see now a nice couple of wolf ears sprouting from your head."; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 
			}

		} 



		if (randNum > 80) {

			GameControl.facialFeaturesStat = GameControl.facialFeaturesStat - 2; 
			charSettler.setCharFemininity ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour face becomes way more tougher, increasing its masculinity significantly!"; 
		} else if (randNum > 60) {
			GameControl.facialFeaturesStat = GameControl.facialFeaturesStat - 1; 
			charSettler.setCharFemininity ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour face becomes tougher, increasing its masculinity.";

		} else if (randNum > 50 && GameControl.hasFur) {
			GameControl.mcFurColor = GameControl.MCFurColor.blue; 
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour fur becomes blue!";
		}
			
	}




	public void wolfLotion(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (GameControl.mcArms != GameControl.MCArms.WOLF) 
		{
			if (WorldControl.furryOn == true) 
			{
				GameControl.mcArms =  GameControl.MCArms.WOLF;
				WorldControl.itemUseText = "Your arms hurts, although not as much as the first time: You can feel how fur begins to grow all around your arms and torso. You have finish the transformation of this body part! "; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 
			}		else 
			{
				
				GameControl.mcArms =  GameControl.MCArms.WOLF;
				WorldControl.itemUseText = "Your hands start to hurt and transform into dangerous looking wolf claw!"; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 
			}

		} 



		if (randNum > 80) {

			GameControl.buildStat = GameControl.buildStat + 8;
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour feel more strong now! seems like your muscles are more toned now!"; 
		} else if (randNum > 50) {
			if (GameControl.physiqueStat < 30) {
				GameControl.physiqueStat = GameControl.physiqueStat + 8; 
				charSettler.setCharBreasts1 ();
				WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour weight goes up too!";
			}

		} else if (randNum > 40 && GameControl.hasFur) {
			GameControl.mcFurColor = GameControl.MCFurColor.blue; 
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour fur becomes blue!";
		}else if (randNum > 20 && GameControl.dickNum >= 1) {
			GameControl.mcDickType = GameControl.MCDickType.wolf; 
			GameControl.hasKnot = true; 
		

			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYou have a knot and a dick wolf now!";
		}

	}

	public void wolfOil()
	{
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.mcLegs != GameControl.MCLegs.WOLF) 
		{
			if (WorldControl.furryOn == true) 
			{
				GameControl.mcLegs = GameControl.MCLegs.WOLF;
				WorldControl.itemUseText = "Your legs hurts, although not as much as the first time: You can feel how fur begins to grow all around your legs. You have finish the transformation of your legs! "; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 
			}	else 
			{
				GameControl.mcLegs = GameControl.MCLegs.WOLF;

				WorldControl.itemUseText = "Your legs start to hurt, and soon enough your feet transform into pretty intimidating wolf claws paws!"; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 
			}

		} 



		if (randNum > 80) {

			GameControl.buildStat = GameControl.buildStat + 8;
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour feel more strong now! seems like your muscles are more toned now!"; 
		} else if (randNum > 50) {
			if (GameControl.physiqueStat < 30) {
				GameControl.physiqueStat = GameControl.physiqueStat + 8; 
				WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour weight goes up too!";
			}

		} else if (randNum > 40 && GameControl.hasFur) {
			GameControl.mcFurColor = GameControl.MCFurColor.blue;  
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour fur becomes blue!";
		}else if (randNum > 10) {
			GameControl.mcTailType = GameControl.MCTailType.Wolf; 
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour back hurts a lot for a second, and when you turn around realize you have a wolf tail now! Awesome!";
		}



	}
	public void wolfDist(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (randNum > 95) 
		{
			if (GameControl.physiqueStat < 30) {
				GameControl.physiqueStat = GameControl.physiqueStat + 8; 

			}
			GameControl.mcFurColor = GameControl.MCFurColor.blue;  
			GameControl.buildStat = GameControl.buildStat + 8;
			GameControl.facialFeaturesStat = GameControl.facialFeaturesStat - 2; 
			charSettler.setCharFemininity ();
			WorldControl.itemUseText = "The potion was very powerful! Your muscles look more toned, your face more masculine and your fur is now blue!";

		} else if (randNum > 90) {
			GameControl.mcFurColor = GameControl.MCFurColor.black; 
			WorldControl.itemUseText =  "The potion wasn't that powerful, but your fur becomes blue!";

		}else {
			GameControl.buildStat = GameControl.buildStat + 8;
			WorldControl.itemUseText = "Your drink the potion and in few minutes you note that your muscles become more toned! ";
			if (GameControl.physiqueStat < 30) {
				GameControl.physiqueStat = GameControl.physiqueStat + 8; 
				WorldControl.itemUseText = "Your drink the potion and in few minutes you note that your muscles become more toned and you also gained some weight! ";
			}
			GameControl.buildStat = GameControl.buildStat + 8;


		}

	}

	public void plantConct()
	{
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (randNum > 95) {
			plantMud ();
			plantLotion ();
			plantOil ();
			plantDist ();
			WorldControl.itemUseText = "Your full body starts to transform! After some minutes of excruciating pain your whole body starts to look more like a monster plant!"; 
		} else if (randNum > 70) {
			plantLotion ();
		} else if (randNum > 45) {
			plantOil ();
		} else if (randNum > 25) {
			plantMud ();
		} else {
			plantDist ();
		} 


	}



	public void plantMud()
	{
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.mcHead != GameControl.MCHead.PLANT) 
		{

				GameControl.mcHead = GameControl.MCHead.PLANT;
				WorldControl.itemUseText = "Your face feels very strange for a couple of minutes, although you dont feel any big change. When you go and look yourself at a mirror, you realize that most of your veins on your head have turned dark green, though the final look its kinda sexy."; 

		} 


		if (randNum > 80) {

			GameControl.facialFeaturesStat = GameControl.facialFeaturesStat + 2; 
			charSettler.setCharFemininity ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour face becomes way more delicate, increasing its feminity significantly!"; 
		} else if (randNum > 60) {
			GameControl.physiqueStat = GameControl.physiqueStat - 5;
			charSettler.setCharPhysique ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour also lost some weight!";

		} else if (randNum > 50) {
			GameControl.mcSkinColor = GameControl.MCSkinColor.lightGreen; 
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour skins changes its colour to a light green!";
		}

	}



	public void plantLotion(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.mcArms != GameControl.MCArms.PLANT) 
		{
			GameControl.mcArms = GameControl.MCArms.PLANT;
			WorldControl.itemUseText = "Your arms hurts, although not as much as the first time: You can feel how the vines in your arms and torse become thicker, and how your veins also turn dark green. Seems like the transformation is complete! "; 

		} 



		if (randNum > 80) {

			GameControl.breast1Size = GameControl.breast1Size + 8;
			charSettler.setCharBreasts1 ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour breast increase their size significantly! The abundance of nature..."; 
		} else if (randNum > 60) {
			GameControl.breast1Size = GameControl.breast1Size + 4;
			charSettler.setCharBreasts1 ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour breast increase their size! The abundance of...";

		} else if (randNum > 50) {
			GameControl.mcSkinColor = GameControl.MCSkinColor.lightGreen;  
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour skins changes its colour to a light green!";
		}

	}


	public void plantOil(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.mcLegs != GameControl.MCLegs.PLANT) 
		{
			if (WorldControl.furryOn == true) 
			{
				GameControl.mcLegs = GameControl.MCLegs.PLANT;
				WorldControl.itemUseText = "Your legs hurts, although not as much as the first time: You can feel how the veins get thicker all around your legs. Seems like the transformation is complete! "; 
			}

		} 



		if (randNum > 80) {
			GameControl.hipsSize = GameControl.hipsSize + 8; 
			charSettler.setHips ();
			GameControl.assSize = GameControl.assSize + 8;
			charSettler.setCharAss ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour hips and ass increased their size significantly! Mother nature always providing..."; 
		} else if (randNum > 20) {
			GameControl.waistSize = -5; 
			charSettler.setWaist ();
			GameControl.breast1Size = + 5;
			charSettler.setCharBreasts1 ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour waist became thinner while your breasts grow a little. Guess mother nature likes the hourglass figure..."; 

		} else {
			GameControl.mcSkinColor = GameControl.MCSkinColor.lightGreen;  
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour skins changes its colour to a light green!";
		} 


	}




	public void plantDist(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (randNum > 95) {
			GameControl.hipsSize = GameControl.hipsSize + 8; 
			charSettler.setHips ();
			GameControl.assSize = GameControl.assSize + 8;
			charSettler.setCharAss ();
			GameControl.mcSkinColor = GameControl.MCSkinColor.lightGreen;  
			GameControl.waistSize = -5; 
			charSettler.setWaist ();
			GameControl.breast1Size = +5;
			charSettler.setCharBreasts1 ();
			GameControl.facialFeaturesStat = GameControl.facialFeaturesStat + 2; 
			charSettler.setCharFemininity ();
			GameControl.physiqueStat = GameControl.physiqueStat - 5;
			charSettler.setCharPhysique ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = "The potion was very strong! Your breasts, ass, face femininity, and hips increased their size! Your waist got thinner and your skin turned light green!"; 





		} else if (randNum > 90) {
			GameControl.mcSkinColor = GameControl.MCSkinColor.lightGreen;  
			WorldControl.itemUseText = "The potion wasn't that powerful, but your skin changed to a light green colour!";

		} else if (randNum > 50) {

			GameControl.hipsSize = GameControl.hipsSize + 8; 
			charSettler.setHips ();
			GameControl.assSize = GameControl.assSize + 8;
			charSettler.setCharAss ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText =  "Your hips and ass increased their size significantly! Mother nature always providing..."; 


		} else {
			GameControl.waistSize = -5; 
			charSettler.setWaist ();
			GameControl.breast1Size = + 5;
			charSettler.setCharBreasts1 ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = "Your waist became thinner while your breasts grow a little. Guess mother nature likes the hourglass figure..."; 
		}


	}




	public void felineConct(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (randNum > 95) {
			felineMud ();
			felineLotion ();
			felineOil ();
			felineDist ();
			WorldControl.itemUseText = "Your full body starts to transform! After some minutes of excruciating pain your whole body starts to look more like a feline person!"; 
		} else if (randNum > 70) {
			felineLotion ();
		} else if (randNum > 45) {
			felineOil ();
		} else if (randNum > 25) {
			felineMud ();
		} else {
			felineDist ();
		} 


	}


	public void felineMud(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.mcHead != GameControl.MCHead.FELINE) 
		{
			if (WorldControl.furryOn == true) 
			{
				GameControl.mcHead = GameControl.MCHead.FELINE;
				WorldControl.itemUseText = "Your head hurts, though not as much as the first time: You can feel how soft fur begins to grow all around your face, while your nose and mouth become feline-like. You have finish the transformation of your head! "; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 

			}	else 
			{
				GameControl.mcHead = GameControl.MCHead.FELINE;
				WorldControl.itemUseText = "Your face feels very strange: Bones moving around, muscles transforming left and right. An incredible headache that thankfully is over after a couple of minutes. You dress at yourself in a mirror, and you can see now a nice couple of feline ears sprouting from your head, sporting also some long whiskers."; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 
			}


		} 


		if (randNum > 80) {

			GameControl.facialFeaturesStat = GameControl.facialFeaturesStat + 2; 
			charSettler.setCharFemininity ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour face becomes more softer and delicate, increasing its femininity significantly!"; 
		} else if (randNum > 60) {
			GameControl.facialFeaturesStat = GameControl.facialFeaturesStat + 1; 
			charSettler.setCharFemininity ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour face becomes sligthly more softer and delicate, increasing its femininity!";

		} else if (randNum > 50 && GameControl.hasFur) {
			GameControl.mcFurColor = GameControl.MCFurColor.blue;  
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour fur becomes black!";
		}

	}


	public void felineLotion(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.mcArms == GameControl.MCArms.FELINE) 
		{
			if (WorldControl.furryOn == true) 
			{
				GameControl.mcArms  = GameControl.MCArms.FELINE;
				WorldControl.itemUseText = "Your arms hurts, although not as much as the first time: You can feel how soft fur begins to grow all around your arms and torso. Seems like the transformation is complete! "; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 

			}	else 
			{
				GameControl.mcArms  = GameControl.MCArms.FELINE;
				WorldControl.itemUseText = "Your hands start to hurt and transform into dangerous looking feline claws!"; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false;  
			}

		} 



		if (randNum > 80) {

			GameControl.breast1Size = GameControl.breast1Size - 8;
			charSettler.setCharBreasts1 ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour breast decrease their size significantly! Well, breast are not great to bounce from roof to roof..."; 
		} else if (randNum > 60) {
			GameControl.physiqueStat = GameControl.physiqueStat - 5; 
			charSettler.setCharPhysique ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYou feel more light after drinking the potion, and you realize you lost some weight!";

		} else if (randNum > 50 && GameControl.hasFur) {
			GameControl.mcFurColor = GameControl.MCFurColor.blue;  
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour fur becomes black!";
		}

	}


	public void felineOil(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.mcLegs != GameControl.MCLegs.FELINE) 
		{
			if (WorldControl.furryOn == true) 
			{
				GameControl.mcLegs  = GameControl.MCLegs.FELINE;
				WorldControl.itemUseText = "Your legs hurts, although not as much as the first time: You can feel how soft fur begins to grow all around your legs. You have finish the transformation of your legs! "; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 
			}	else 
			{
				GameControl.mcLegs  = GameControl.MCLegs.FELINE;

				WorldControl.itemUseText = "Your legs start to hurt, and soon enough your feet transform into dangerous looking feline claws!"; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 
			}

		} 



		if (randNum > 80) {
			GameControl.hipsSize = GameControl.hipsSize - 8; 
			charSettler.setHips ();
			GameControl.assSize = GameControl.assSize - 8;
			charSettler.setCharAss ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour hips and ass reduced their size significantly! "; 
		} else if (randNum > 60) {
			GameControl.buildStat = GameControl.buildStat + 5; 
			charSettler.setCharBuild ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour muscles get more toned! "; 

		} else if (randNum > 50 && GameControl.hasFur) {
			GameControl.mcFurColor = GameControl.MCFurColor.blue;  
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour fur becomes black!";
		} else if (randNum > 30) {
			GameControl.mcTailType = GameControl.MCTailType.Feline; 
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour back hurts a lot for a second, and when you turn around realize you have a feline tail now! Cute!";
		}

	}




	public void felineDist(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (randNum > 95) 
		{
			GameControl.buildStat = GameControl.buildStat + 5; 
			charSettler.setCharBuild ();
			GameControl.mcFurColor = GameControl.MCFurColor.blue;  
			GameControl.hipsSize = GameControl.hipsSize - 8; 
			charSettler.setHips ();
			GameControl.assSize = GameControl.assSize - 8;
			charSettler.setCharAss ();
			charSettler.setBodyShape ();
			GameControl.breast1Size = GameControl.breast1Size - 8;
			charSettler.setCharBreasts1 ();
			GameControl.physiqueStat = GameControl.physiqueStat - 5; 
			charSettler.setCharPhysique ();
			charSettler.setBodyShape ();

			WorldControl.itemUseText = "The potion was very powerful! Your ass, hips and breasts decrease size significantly, while your muscles look more toned! Also it seems like your fur is now black.";

		} else if (randNum > 90) {
			GameControl.mcFurColor = GameControl.MCFurColor.blue;  
			WorldControl.itemUseText =  "The potion wasnt that powerful, but your fur becomes black!";

		}else if (randNum > 60) {
			GameControl.buildStat = GameControl.buildStat + 5; 
			charSettler.setCharBuild ();
			WorldControl.itemUseText = "The potion wasn't that powerful but now your muscles are more toned!";

		}else if (randNum > 30) {
			GameControl.hipsSize = GameControl.hipsSize + 8; 
			charSettler.setHips ();
			GameControl.assSize = GameControl.assSize + 8;
			charSettler.setCharAss ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = "Your hips and ass decrease in size significantly!";
		}else if (randNum > 0) {
			GameControl.breast1Size = GameControl.breast1Size - 8;
			charSettler.setCharBreasts1 ();
			GameControl.physiqueStat = GameControl.physiqueStat - 5; 
			charSettler.setCharPhysique ();
			WorldControl.itemUseText = "The potion was not so powerful but helps you to lose some weight and breasts.";

		}



	}
	public void equineConct(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (randNum > 95) {
			equineMud ();
			equineLotion ();
			equineOil ();
			equineDist ();
			WorldControl.itemUseText = "Your full body starts to transform! After some minutes of excruciating pain your whole body starts to look more like a equine person!"; 
		} else if (randNum > 70) {
			equineLotion ();
		} else if (randNum > 45) {
			equineOil ();
		} else if (randNum > 25) {
			equineMud ();
		} else {
			equineDist ();
		} 


	}
	public void equineMud(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.mcHead != GameControl.MCHead.EQUINE) 
		{
			if (WorldControl.furryOn == true) 
			{
				GameControl.mcHead = GameControl.MCHead.EQUINE;
				WorldControl.itemUseText = "Your head hurts, though not as much as the first time: You can feel how soft fur begins to grow all around your face, while your nose and mouth become horse-like.  Seems like the transformation is complete!  "; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 

			}		else 
			{
				GameControl.mcHead = GameControl.MCHead.EQUINE;
				WorldControl.itemUseText = "Your face feels very strange: Bones moving around, muscles transforming left and right. Its an incredible headache, but after a couple of minutes is over. You dress at yourself in a mirror, and you can see now a nice couple of horse ears sprouting from your head."; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 
			}

		} 



		if (randNum > 80) {

			GameControl.facialFeaturesStat = GameControl.facialFeaturesStat - 2; 
			charSettler.setCharFemininity ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour face becomes more tough, increasing its masculinity significantly!"; 
		} else if (randNum > 60) {
			GameControl.facialFeaturesStat = GameControl.facialFeaturesStat - 1; 
			charSettler.setCharFemininity ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour face also becomes more masculine!";

		} else if (randNum > 50 && GameControl.hasFur) {
			GameControl.mcFurColor = GameControl.MCFurColor.blue;  
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour fur color is now dark chocolate!";
		}


	}


	public void equineLotion(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.mcArms !=  GameControl.MCArms.EQUINE) 
		{
			if (WorldControl.furryOn == true) 
			{
				GameControl.mcArms = GameControl.MCArms.EQUINE;
				WorldControl.itemUseText = "You can feel how soft fur begins to grow all around your arms and torso.  Seems like the transformation is complete! "; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 

			}	else 
			{
				GameControl.mcArms = GameControl.MCArms.EQUINE;
				WorldControl.itemUseText = "Your feel how soft fur starts to grow around your hands!"; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 
			}

		} 



		if (randNum > 80) {
			GameControl.buildStat = GameControl.buildStat + 10; 
			charSettler.setCharBuild ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour muscles tone increases a lot!"; 


		} else if (randNum > 60) {
			GameControl.hairLength = GameControl.hairLength + 5;
			charSettler.setHairLength ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour hair length increases 5 cm!"; 

		} else if (randNum > 50 && GameControl.hasFur) {
			GameControl.mcFurColor = GameControl.MCFurColor.blue;  
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour fur colour is now dark chocolate!";
		}

	}


	public void equineOil(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.mcLegs != GameControl.MCLegs.EQUINE) 
		{
			if (WorldControl.furryOn == true) 
			{
				GameControl.mcLegs = GameControl.MCLegs.EQUINE; 
				WorldControl.itemUseText = "Your legs hurts, although not as much as the first time: You can feel how soft fur begins to grow all around your legs. You have finish the transformation of your legs! "; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 
			}	else 
			{
				
				GameControl.mcLegs = GameControl.MCLegs.EQUINE; 
				WorldControl.itemUseText = "Your legs start to hurt, and soon enough your feet transform into pretty cute rabbit paws, both plushy and adorable!"; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 
			}

		} 



		if (randNum > 80) {
			if (GameControl.dickNum >= 1) {
				GameControl.dick1Size = GameControl.dick1Size + 5; 
				charSettler.setCharDick1Name ();
				GameControl.testiclesSize = GameControl.testiclesSize + 3;
				charSettler.setTesticlesName ();
				WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour dick and testicles increas in size! "; 
			}
		} else if (randNum > 60) {
			if (GameControl.dickNum >= 1) {
				GameControl.mcDickType = GameControl.MCDickType.equine; 
				WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYou feel a sudden sensation of your crotch, both of pain and pleasure, and you realize you dick is changing! After a couple of minutes it transforms into a horse dick!";
			}
		} else if (randNum > 50 && GameControl.hasFur) {
			GameControl.mcFurColor = GameControl.MCFurColor.blue;  
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour fur colour is now dark chocolate!";
		} else if (randNum > 30) {
			GameControl.mcTailType = GameControl.MCTailType.Equine; 
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour back hurts a lot for a second, and when you turn around realize you have a horse tail now! Awesome!";
		}


	}


	public void equineDist(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (randNum > 95) 
		{
			WorldControl.itemUseText = "The potion was very powerful! Your muscles get a lot of tone while your face looks more masculine and you increased 5 cm in heigth! Also it seems like your fur colour is now dark chocolate!.";
			GameControl.mcFurColor = GameControl.MCFurColor.blue;  
			if (GameControl.dickNum >= 1) {
				GameControl.dick1Size = GameControl.dick1Size + 5; 
				charSettler.setCharDick1Name ();
				GameControl.testiclesSize = GameControl.testiclesSize + 3;
				charSettler.setTesticlesName ();
				WorldControl.itemUseText = "The potion was very powerful! Your muscles get a lot of tone while your face looks more masculine and you increased 5 cm in heigth! A Both your dick and balls are bigger, also your fur colour is now dark chocolate!.";
			}
			GameControl.heightChar = GameControl.heightChar + 5;
			charSettler.setHeigth ();
			GameControl.hairLength = GameControl.hairLength + 5;
			charSettler.setHairLength ();
			GameControl.facialFeaturesStat = GameControl.facialFeaturesStat - 2; 
			charSettler.setCharFemininity ();
			GameControl.buildStat = GameControl.buildStat + 10; 
			charSettler.setCharBuild ();



		} else if (randNum > 90) {
			GameControl.mcFurColor = GameControl.MCFurColor.blue;  
			WorldControl.itemUseText =  "The potion wasnt that powerful, but your fur colour becomes dark chocolate!";

		}else if (randNum > 60) {
			GameControl.heightChar = GameControl.heightChar + 5;
			charSettler.setHeigth ();
			WorldControl.itemUseText = "You become 5 cm taller!";

		}else if (randNum > 30) {
			GameControl.facialFeaturesStat = GameControl.facialFeaturesStat - 2; 
			charSettler.setCharFemininity ();
			GameControl.buildStat = GameControl.buildStat + 10; 
			charSettler.setCharBuild ();

			WorldControl.itemUseText = "Your muscles are more toned and your face looks more manly!";
		}else if (randNum > 0) {
			GameControl.hairLength = GameControl.hairLength + 10;
			charSettler.setHairLength ();
			WorldControl.itemUseText = "Your hair is now 10 cm longer!";

		}

	}


	public void dodoConct(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (randNum > 95) {
			dodoMud ();
			dodoLotion ();
			dodoOil ();
			dodoDist ();
			WorldControl.itemUseText = "Your full body starts to transform! After some minutes of excruciating pain your whole body starts to look more like an avian!"; 
		} else if (randNum > 70) {
			dodoLotion ();
		} else if (randNum > 45) {
			dodoOil ();
		} else if (randNum > 25) {
			dodoMud ();
		} else {
			dodoDist ();
		} 


	}



	public void dodoMud(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.mcHead != GameControl.MCHead.AVIAN) 
		{
			if (WorldControl.furryOn == true) 
			{
				GameControl.mcHead = GameControl.MCHead.AVIAN;
				WorldControl.itemUseText = "Your head hurts, though not as much as the first time: You can feel how soft feathers begins to grow all around your face, while your nose and mouth become avian-like.  Seems like the transformation is complete!  "; 
				GameControl.hasFur = false; 
				GameControl.hasFeathers = true; 

			}		else 
			{
				GameControl.mcHead = GameControl.MCHead.AVIAN;
				WorldControl.itemUseText = "Your face feels very strange: Bones moving around, muscles transforming left and right. Its an incredible headache, but after a couple of minutes is over. You dress at yourself in a mirror, and you can see now how colorful feathers decorate your head!"; 
				GameControl.hasFur = false; 
				GameControl.hasFeathers = true;  
			}

		} 



		if (randNum > 80) {

			GameControl.facialFeaturesStat = GameControl.facialFeaturesStat + 2; 
			charSettler.setCharFemininity ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour face becomes more softer and delicate, increasing its femininity significantly!"; 
		} else if (randNum > 60) {
			GameControl.facialFeaturesStat = GameControl.facialFeaturesStat + 1; 
			charSettler.setCharFemininity ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour face becomes sligthly more softer and delicate, increasing its femininity!";

		} else if (randNum > 50 && GameControl.hasFur) {
			GameControl.mcFurColor = GameControl.MCFurColor.blue;  
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour feathers become become dark gray with white!";
		}


	}
	public void dodoLotion(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.mcArms != GameControl.MCArms.AVIAN) 
		{
			if (WorldControl.furryOn == true) 
			{
				GameControl.mcArms = GameControl.MCArms.AVIAN;
				WorldControl.itemUseText = "Your arms hurts, although not as much as the first time: You can feel how longer feathers grow underneath your arms.  Seems like the transformation is complete! "; 
				GameControl.hasFur = false; 
				GameControl.hasFeathers = true;  

			}	else 
			{

				GameControl.mcArms = GameControl.MCArms.AVIAN;
				WorldControl.itemUseText = "Your arms and shoulders hurt a lot for a couple of minutes. Afterwards you can see how some good looking feathers decorate them! "; 
				GameControl.hasFur = false; 
				GameControl.hasFeathers = true;  
			}


		} 
	

		if (randNum > 80) {

			GameControl.breast1Size = GameControl.breast1Size - 8;
			charSettler.setCharBreasts1 ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour breast decrease their size significantly! Well they are not as aerodynamic as you may think..."; 
		} else if (randNum > 60) {
			GameControl.breast1Size = GameControl.breast1Size - 4;
			charSettler.setCharBreasts1 ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour breast decrease their size! Well they are not as aerodynamic as you may think...";

		} else if (randNum > 50 && GameControl.hasFeathers) {
			GameControl.mcFurColor = GameControl.MCFurColor.blue;  
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour feathers become dark gray with white!";
		}

	}
	public void dodoOil(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.mcLegs != GameControl.MCLegs.AVIAN) 
		{
			if (WorldControl.furryOn == true) 
			{
				GameControl.mcLegs = GameControl.MCLegs.AVIAN; 
				WorldControl.itemUseText = "Your legs hurts, although not as much as the first time: You can feel how feathers cover the rest of your legs. You have finish the transformation of your legs! "; 
				GameControl.hasFur = false; 
				GameControl.hasFeathers = true;  
			}		else 
			{
				GameControl.mcLegs = GameControl.MCLegs.AVIAN; 
				GameControl.mcLegs = GameControl.MCLegs.WOLF;
				WorldControl.itemUseText = "Your legs start to hurt, and soon enough your feet transform into avian talon, both impressive and dangerous! Above the knee your legs are still human"; 
				GameControl.hasFur = false; 
				GameControl.hasFeathers = true;  
			}


		} 


		if (randNum > 80) {
			GameControl.hipsSize = GameControl.hipsSize + 8; 
			charSettler.setHips ();
			GameControl.assSize = GameControl.assSize + 8;
			charSettler.setCharAss ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour hips and ass increased their size significantly! Well, Dodo's are flightless for a reason..."; 
		} else if (randNum > 60) {
			GameControl.heightChar = GameControl.heightChar - 5;
			charSettler.setHeigth ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour become 5 cm shorter! Cute!"; 

		} else if (randNum > 50 && GameControl.hasFeathers) {
			GameControl.mcFurColor = GameControl.MCFurColor.blue;  
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour feathers becomes dark gray with white!";
		} else if (randNum > 30) {
			GameControl.mcTailType = GameControl.MCTailType.Avian; 
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour back hurts a lot for a second, and when you turn around realize you have an avian tail now! Cute!";
		}


	}


	public void dodoDist(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (randNum > 95) 
		{
			WorldControl.itemUseText = "The potion was very powerful! Your ass and hips increase their size significantly, while you are now more flat chested and shorter!";
			GameControl.facialFeaturesStat = GameControl.facialFeaturesStat + 2; 
			charSettler.setCharFemininity ();
			GameControl.hipsSize = GameControl.hipsSize + 8; 
			charSettler.setHips ();
			GameControl.assSize = GameControl.assSize + 8;
			charSettler.setCharAss ();
			GameControl.heightChar = GameControl.heightChar - 5;
			charSettler.setHeigth ();
			GameControl.breast1Size = GameControl.breast1Size - 8;
			charSettler.setCharBreasts1 ();
			charSettler.setBodyShape ();
			if (GameControl.hasFeathers) {
				GameControl.mcFurColor = GameControl.MCFurColor.blue;  
				WorldControl.itemUseText = "The potion was very powerful! Your ass and hips increase their size significantly, while you are now more flat chested and shorter! Also it seems like your feathers are now dark gray with white.";
			} 



		} else if (randNum > 90) {
			if (GameControl.hasFeathers) {
				GameControl.mcFurColor = GameControl.MCFurColor.blue;  
				WorldControl.itemUseText = "Your feathers becomes dark gray with white!";
			} else {
				WorldControl.itemUseText = "The potion doesn't has an effect, maybe you need feathers...";
			}
				

		}else if (randNum > 60) {
			GameControl.breast1Size = GameControl.breast1Size - 8;
			charSettler.setCharBreasts1 ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = "You have become more flat chested!";

		}else if (randNum > 30) {
			GameControl.hipsSize = GameControl.hipsSize + 8; 
			charSettler.setHips ();
			GameControl.assSize = GameControl.assSize + 8;
			charSettler.setCharAss ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = "Your hips and ass increase in size significantly!";
		}else if (randNum > 0) {
			GameControl.facialFeaturesStat = GameControl.facialFeaturesStat + 2; 
			charSettler.setCharFemininity ();
			WorldControl.itemUseText = "The potion was not so powerful but your face looks more femenine at least.";

		}

	}



	public void lizardConct(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (randNum > 95) {
			lizardMud ();
			lizardLotion ();
			lizardOil ();
			lizardDist ();
			WorldControl.itemUseText = "Your full body starts to transform! After some minutes of excruciating pain your whole body starts to look more like a lizard person!"; 
		} else if (randNum > 70) {
			lizardLotion ();
		} else if (randNum > 45) {
			lizardOil ();
		} else if (randNum > 25) {
			lizardMud ();
		} else {
			lizardDist ();
		} 


	}


	public void lizardMud(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.mcHead != GameControl.MCHead.LIZARD) 
		{
			if (WorldControl.furryOn == true) 
			{
				GameControl.mcHead = GameControl.MCHead.LIZARD;
				WorldControl.itemUseText = "Your head hurts, though not as much as the first time: You can feel how scales begin to grow all around your face, while your nose and mouth become lizard-like.  Seems like the transformation is complete!  "; 


			}		else 
			{
				GameControl.mcHead = GameControl.MCHead.LIZARD;
				WorldControl.itemUseText = "Your face feels very strange: Bones moving around, muscles transforming left and right. Its an incredible headache, but after a couple of minutes is over. You dress at yourself in a mirror, and you can see now a nice couple of pink bunny ears sprouting from your head."; 

			}

		} 



		if (randNum > 80) {
			if (GameControl.facialFeaturesStat > 12) {
				GameControl.facialFeaturesStat = GameControl.facialFeaturesStat - 1; 
				WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour face becomes more androgynous!"; 
			}else if (GameControl.facialFeaturesStat < 8) {
				GameControl.facialFeaturesStat = GameControl.facialFeaturesStat + 1; 
				WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour face becomes more androgynous!"; 
			}

			charSettler.setCharFemininity ();

		} else if (randNum > 60) {
			GameControl.physiqueStat = GameControl.physiqueStat - 5;
			charSettler.setCharPhysique ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYou become more slender!"; 

		} else if (randNum > 50 ) {
			GameControl.mcSkinColor = GameControl.MCSkinColor.lightGreen;  
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour skins becomes light green!";
		}
	}

	public void lizardLotion(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.mcArms != GameControl.MCArms.LIZARD) 
		{
			if (WorldControl.furryOn == true) 
			{
				WorldControl.itemUseText = "Your arms hurts, although not as much as the first time: You can feel how scales grow all around your skin! Seems like the transformation is complete! "; 
				GameControl.mcArms = GameControl.MCArms.LIZARD;
				GameControl.hasScales = true;
				GameControl.hasFur = false;
				GameControl.hasFeathers = false; 
			}		else 
			{
				GameControl.mcArms = GameControl.MCArms.LIZARD;
				WorldControl.itemUseText = "The skin of your arms and hands starts to transform with scales, while your hands transform with dangerous claws!"; 

			}

		} 



		if (randNum > 80) {

			GameControl.breast1Size = GameControl.breast1Size - 4;
			charSettler.setCharBreasts1 ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour breast decrease their size! Well, reptiles are not mammals..."; 
		} else if (randNum > 60) {
			GameControl.breast1Size = GameControl.breast1Size - 4;
			charSettler.setCharBreasts1 ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour breast decrease their size! Well, reptiles are not mammals..."; 

		} else if (randNum > 50 ) {
			GameControl.mcSkinColor = GameControl.MCSkinColor.lightGreen;  
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour skins becomes light green!";
		}
	}


	public void lizardOil(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.mcLegs != GameControl.MCLegs.LIZARD) 
		{
			if (WorldControl.furryOn == true) 
			{
				GameControl.mcLegs  = GameControl.MCLegs.LIZARD;
				WorldControl.itemUseText = "Your legs hurts, although not as much as the first time: You can feel how soft fur begins to grow all around your legs. You have finish the transformation of your legs! "; 
				GameControl.hasScales = true; 
				GameControl.hasFur = false; 
				GameControl.hasFeathers = false; 
			}	else 
			{
				GameControl.mcLegs  = GameControl.MCLegs.LIZARD;

				WorldControl.itemUseText = "Your legs start to hurt, and soon enough your feet transform into pretty cute rabbit paws, both plushy and adorable!"; 
				GameControl.hasScales = true; 
				GameControl.hasFur = false; 
				GameControl.hasFeathers = false; 
			}

		} 



		if (randNum > 80) {
			GameControl.hipsSize = GameControl.hipsSize + 8; 
			charSettler.setHips ();
			GameControl.assSize = GameControl.assSize + 8;
			charSettler.setCharAss ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour hips and ass increased their size significantly! Well, laying eggs is a pain in the ass.."; 

		} else if (randNum > 60) {
			GameControl.hipsSize = GameControl.hipsSize + 4; 
			charSettler.setHips ();
			GameControl.assSize = GameControl.assSize + 4;
			charSettler.setCharAss ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour hips and ass increased their size! Well, laying eggs is a pain in the ass.."; 

		} else if (randNum > 50 ) {
			GameControl.mcSkinColor = GameControl.MCSkinColor.lightGreen;  
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour skins becomes light green!";
		}else if (randNum > 30) {
			GameControl.mcTailType = GameControl.MCTailType.Lizard; 
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour back hurts a lot for a second, and when you turn around realize you have a reptile tail now! Cool!";
		}

	}
	public void lizardDist(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (randNum > 95) 
		{
			WorldControl.itemUseText = "The potion was very powerful! Your ass and hips increase their size significantly, while you are now more flat chested! Also it seems like your skin colour is light green.";
			if (GameControl.facialFeaturesStat > 12) {
				GameControl.facialFeaturesStat = GameControl.facialFeaturesStat - 1; 
				WorldControl.itemUseText = "The potion was very powerful! Your ass and hips increase their size significantly, while you are now more flat chested! Your face is more androgynous now! Also it seems like your skin colour is light green.";
			}else if (GameControl.facialFeaturesStat < 8) {
				GameControl.facialFeaturesStat = GameControl.facialFeaturesStat + 1; 

				WorldControl.itemUseText = "The potion was very powerful! Your ass and hips increase their size significantly, while you are now more flat chested! Your face is more androgynous now! Also it seems like your skin colour is light green.";
			}
			GameControl.mcSkinColor = GameControl.MCSkinColor.lightGreen;  
			GameControl.breast1Size = GameControl.breast1Size - 8;
			charSettler.setCharBreasts1 ();
			GameControl.hipsSize = GameControl.hipsSize + 8; 
			charSettler.setHips ();
			GameControl.assSize = GameControl.assSize + 8;
			charSettler.setCharAss ();
			charSettler.setBodyShape ();


		} else if (randNum > 90) {
			GameControl.mcSkinColor = GameControl.MCSkinColor.lightGreen;  
			WorldControl.itemUseText = "You drink the potion, but its kinda weak. Still your skins becomes light green!";

		}else if (randNum > 60) {
			GameControl.breast1Size = GameControl.breast1Size - 8;
			charSettler.setCharBreasts1 ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = "You drink the potion, but its kinda weak. You have become more flat chested!";

		}else if (randNum > 30) {
			GameControl.hipsSize = GameControl.hipsSize + 8; 
			charSettler.setHips ();
			GameControl.assSize = GameControl.assSize + 8;
			charSettler.setCharAss ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = "You drink the potion, but its kinda weak. Your hips and ass increase in size significantly!";
		}else if (randNum > 0) {
			WorldControl.itemUseText = "The potion was very powerful! Your ass and hips increase their size significantly, while you are now more flat chested! Also it seems like your skin colour is light green.";
			if (GameControl.facialFeaturesStat > 12) {
				GameControl.facialFeaturesStat = GameControl.facialFeaturesStat - 1; 
				WorldControl.itemUseText = "You drink the potion, but its kinda weak. The potion was not so powerful but your face looks more androgynous at least.";
			}else if (GameControl.facialFeaturesStat < 8) {
				GameControl.facialFeaturesStat = GameControl.facialFeaturesStat + 1; 

				WorldControl.itemUseText = "You drink the potion, but its kinda weak. The potion was not so powerful but your face looks more androgynous at least.";
			}

			WorldControl.itemUseText = "You feel how the potion affects your face, but you are already androgynous!"; 

		}


	}



	public void lionConct(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (randNum > 95) {
			lionMud ();
			lionLotion ();
			lionOil ();
			lionDist ();
			WorldControl.itemUseText = "Your full body starts to transform! After some minutes of excruciating pain your whole body starts to look more like a rabbit person!"; 
		} else if (randNum > 70) {
			lionLotion ();
		} else if (randNum > 45) {
			lionOil ();
		} else if (randNum > 25) {
			lionMud ();
		} else {
			lionDist ();
		} 

	}


	public void lionMud(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.mcHead != GameControl.MCHead.LION) 
		{
			if (WorldControl.furryOn == true) 
			{
				GameControl.mcHead = GameControl.MCHead.LION;
				WorldControl.itemUseText = "Your head hurts, though not as much as the first time: You can feel how soft fur begins to grow all around your face, while your nose and mouth become feline-like. You have finish the transformation of your head! "; 
				GameControl.hasScales = false; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 

			}		else 
			{
				GameControl.mcHead = GameControl.MCHead.LION; 
				WorldControl.itemUseText = "Your face feels very strange: Bones moving around, muscles transforming left and right. An incredible headache that thankfully is over after a couple of minutes. You dress at yourself in a mirror, and you can see now a nice couple of feline ears sprouting from your head, sporting also some long whiskers."; 
				GameControl.hasScales = true; 
				GameControl.hasFur = false; 
				GameControl.hasFeathers = false; 
			}


		} 


		if (randNum > 80) {

			GameControl.facialFeaturesStat = GameControl.facialFeaturesStat - 2; 
			charSettler.setCharFemininity ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour face becomes more tough, increasing its masculinity significantly!"; 
		} else if (randNum > 60) {
			GameControl.facialFeaturesStat = GameControl.facialFeaturesStat - 1; 
			charSettler.setCharFemininity ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour face becomes more tough, increasing its masculinity!";

		} else if (randNum > 50 && GameControl.hasFur) {
			GameControl.mcFurColor = GameControl.MCFurColor.YellowOcher;
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nThe colour of your fur becomes yellow ocher!";
		} else if (randNum > 30) {
			 
			if (GameControl.mcHairType != GameControl.MCHairType.mane) {
				GameControl.mcHairType = GameControl.MCHairType.mane;
				WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour hair changed into a mane!";
			}
		}

	}


	public void lionLotion(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.mcArms != GameControl.MCArms.LION) 
		{
			if (WorldControl.furryOn == true) 
			{

				WorldControl.itemUseText = "Your arms hurts, although not as much as the first time: You can feel how soft fur begins to grow all around your arms and torso. Seems like the transformation is complete! "; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 
				GameControl.hasScales = false; 

			}		else 
			{
				GameControl.mcArms = GameControl.MCArms.LION;
				WorldControl.itemUseText = "Your hands start to hurt and transform into dangerous looking feline claws!"; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 
				GameControl.hasScales = false; 
			}

		} 



		if (randNum > 80) {

			GameControl.breast1Size = GameControl.breast1Size - 8;
			charSettler.setCharBreasts1 ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour breast decrease their size significantly! Well, breast are not great to bounce from roof to roof..."; 
		} else if (randNum > 60) {
			GameControl.physiqueStat = GameControl.physiqueStat - 5; 
			charSettler.setCharPhysique ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYou feel more light after drinking the potion, and you realize you lost some weight!";

		} else if (randNum > 50 && GameControl.hasFur) {
			GameControl.mcFurColor = GameControl.MCFurColor.YellowOcher; 
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nThe colour of your fur becomes yellow ochre!";
		}

	}
	public void lionOil(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.mcLegs != GameControl.MCLegs.LION) 
		{
			if (WorldControl.furryOn == true) 
			{
				GameControl.mcLegs = GameControl.MCLegs.LION;
				WorldControl.itemUseText = "Your legs hurts, although not as much as the first time: You can feel how soft fur begins to grow all around your legs. You have finish the transformation of your legs! "; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false;
				GameControl.hasScales = false; 
			}		else 
			{
				GameControl.mcLegs = GameControl.MCLegs.LION;

				WorldControl.itemUseText = "Your legs start to hurt, and soon enough your feet transform into dangerous looking feline claws!"; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false;
				GameControl.hasScales = false; 
			}

		} 



		if (randNum > 80) {
			GameControl.hipsSize = GameControl.hipsSize - 8; 
			charSettler.setHips ();
			GameControl.assSize = GameControl.assSize - 8;
			charSettler.setCharAss ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour hips and ass reduced their size significantly! "; 
		} else if (randNum > 60) {
			GameControl.buildStat = GameControl.buildStat + 5; 
			charSettler.setCharBuild ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour muscles get more toned! "; 

		} else if (randNum > 50 && GameControl.hasFur) {
			GameControl.mcFurColor = GameControl.MCFurColor.YellowOcher; 
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nThe colour of your fur becomes yellow ochre!";
		} else if (randNum > 30) {
			GameControl.mcTailType = GameControl.MCTailType.Lion; 
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour back hurts a lot for a second, and when you turn around realize you have a lion tail now! Awesome!";
		}

	}
	public void lionDist(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (randNum > 95) 
		{
			GameControl.buildStat = GameControl.buildStat + 5; 
			charSettler.setCharBuild ();
			GameControl.mcFurColor = GameControl.MCFurColor.blue;  
			GameControl.hipsSize = GameControl.hipsSize - 8; 
			charSettler.setHips ();
			GameControl.assSize = GameControl.assSize - 8;
			charSettler.setCharAss ();
			charSettler.setBodyShape ();
			GameControl.breast1Size = GameControl.breast1Size - 8;
			charSettler.setCharBreasts1 ();
			GameControl.physiqueStat = GameControl.physiqueStat - 5; 
			charSettler.setCharPhysique ();
			charSettler.setBodyShape ();

			WorldControl.itemUseText = "The potion was very powerful! Your ass, hips and breasts decrease size significantly, while your muscles look more toned! Also it seems like your fur is now black.";

		} else if (randNum > 90) {
			if (GameControl.hasFur == true) {
				GameControl.mcFurColor = GameControl.MCFurColor.YellowOcher;
				WorldControl.itemUseText = "The potion turned the colour of your fur to yellow ochre!";
			} else {
				GameControl.mcHairColor = GameControl.MCHairColor.yellowOchre; 
				WorldControl.itemUseText = "The potion turned the colour of your hair to yellow ochre!";
			}

		}else if (randNum > 60) {
			GameControl.buildStat = GameControl.buildStat + 5; 
			charSettler.setCharBuild ();
			WorldControl.itemUseText = "The potion wasn't that powerful but it helped to tone your muscles!";

		}else if (randNum > 30) {
			GameControl.hipsSize = GameControl.hipsSize + 8; 
			charSettler.setHips ();
			GameControl.assSize = GameControl.assSize + 8;
			charSettler.setCharAss ();
			charSettler.setBodyShape ();
			WorldControl.itemUseText = "The potion was pretty weak, but hat least helps to decrease the size of your hips and ass significantly!";
		}else if (randNum > 0) {
			GameControl.breast1Size = GameControl.breast1Size - 8;
			charSettler.setCharBreasts1 ();
			GameControl.physiqueStat = GameControl.physiqueStat - 5; 
			charSettler.setCharPhysique ();
			WorldControl.itemUseText = "The potion was pretty weak, but hat least helps you to lose some weight and breasts.";

		}


	}



	public void foxConct(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (randNum > 95) {
			foxMud ();
			foxLotion ();
			foxOil ();
			foxDist ();
			WorldControl.itemUseText = "Your full body starts to transform! After some minutes of excruciating pain your whole body starts to look more like a werefox!"; 
		} else if (randNum > 70) {
			foxLotion ();
		} else if (randNum > 45) {
			foxOil ();
		} else if (randNum > 25) {
			foxMud ();
		} else {
			foxDist ();
		} 


	}
	public void foxMud(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.mcHead != GameControl.MCHead.FOX) 
		{
			if (WorldControl.furryOn == true) 
			{
				WorldControl.itemUseText = "Your face feels very strange: Bones moving around, muscles transforming left and right. Its an incredible headache, but after a couple of minutes is over. You dress at yourself in a mirror, and you can see now a nice couple of fox ears sprouting from your head."; 
				GameControl.mcHead = GameControl.MCHead.FOX; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 
				GameControl.hasScales = false; 

			}else 
			{
				GameControl.mcHead = GameControl.MCHead.FOX; 
				WorldControl.itemUseText = "Your head hurts, though not as much as the first time: You can feel how fur begins to grow all around your face, while your nose and mouth become wolf like. You have finish the transformation of your head! "; 
				GameControl.hasFur = true; 
				GameControl.hasFeathers = false; 
				GameControl.hasScales = false; 
			}

		} 



		if (randNum > 80) {

			GameControl.facialFeaturesStat = GameControl.facialFeaturesStat - 2; 
			charSettler.setCharFemininity ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour face becomes way more tougher, increasing its masculinity significantly!"; 
		} else if (randNum > 60) {
			GameControl.facialFeaturesStat = GameControl.facialFeaturesStat - 1; 
			charSettler.setCharFemininity ();
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour face becomes tougher, increasing its masculinity.";

		} else if (randNum > 50 && GameControl.hasFur) {
			GameControl.mcFurColor = GameControl.MCFurColor.DarkRed;  
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour fur becomes dark red!";
		}


	}

	public void foxLotion(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);
		if (GameControl.mcArms != GameControl.MCArms.FOX) 
		{
			if (WorldControl.furryOn == true) 
			{
				GameControl.mcArms = GameControl.MCArms.FOX;
				WorldControl.itemUseText = "Your arms hurts, although not as much as the first time: You can feel how fur begins to grow all around your arms and torso. You have finish the transformation of this body part! "; 
				GameControl.hasFur = true; 
				GameControl.hasScales = false; 
				GameControl.hasFeathers = false; 
			}		else 
			{
				GameControl.mcArms = GameControl.MCArms.FOX;
				WorldControl.itemUseText = "Your hands start to hurt and transform into dangerous looking fox claw!"; 
				GameControl.hasFur = true; 
				GameControl.hasScales = false; 
				GameControl.hasFeathers = false; 
			}

		} 



		if (randNum > 80) {

			GameControl.buildStat = GameControl.buildStat + 8;
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour feel more strong now! seems like your muscles are more toned now!"; 
		} else if (randNum > 50) {
			if (GameControl.physiqueStat < 30) {
				GameControl.physiqueStat = GameControl.physiqueStat + 8; 
				charSettler.setCharBreasts1 ();
				WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour weight goes up too!";
			}

		} else if (randNum > 40 && GameControl.hasFur) {
			GameControl.mcFurColor = GameControl.MCFurColor.DarkRed;   
			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour fur becomes dark red!";
		}else if (randNum > 20 && GameControl.dickNum >= 1) {
			GameControl.mcDickType = GameControl.MCDickType.wolf; 
			GameControl.hasKnot = true; 

			WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYou have a canine dick now with a knot!";
		}

	}


	public void foxOil(){

		{
			Random.InitState (System.DateTime.Now.Millisecond);
			randNum = Random.Range (0, 101);
			if (GameControl.mcLegs != GameControl.MCLegs.FOX) {
				if (WorldControl.furryOn == true) {
					GameControl.mcLegs = GameControl.MCLegs.FOX;
					WorldControl.itemUseText = "Your legs hurts, although not as much as the first time: You can feel how fur begins to grow all around your legs. You have finish the transformation of your legs! "; 
					GameControl.hasFur = true; 
					GameControl.hasFeathers = false; 
					GameControl.hasScales = false; 
				} else {
					GameControl.mcLegs = GameControl.MCLegs.FOX;
					WorldControl.itemUseText = "Your legs start to hurt, and soon enough your feet transform into pretty intimidating wolf claws paws!"; 
					GameControl.hasFur = true; 
					GameControl.hasFeathers = false; 
					GameControl.hasScales = false; 
				}

			}


			if (randNum > 80) {

				GameControl.buildStat = GameControl.buildStat + 8;
				WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour feel more strong now! seems like your muscles are more toned now!"; 
			} else if (randNum > 50) {
				if (GameControl.physiqueStat < 30) {
					GameControl.physiqueStat = GameControl.physiqueStat + 8; 
					WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour weight goes up too!";
				}

			} else if (randNum > 40 && GameControl.hasFur) {
				GameControl.mcFurColor = GameControl.MCFurColor.DarkRed;   
				WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour fur becomes dark red!";
			} else if (randNum > 10) {
				GameControl.mcTailType = GameControl.MCTailType.Fox; 
				WorldControl.itemUseText = WorldControl.itemUseText + "\n\nYour back hurts a lot for a second, and when you turn around realize you have a fox tail now! Awesome!";
			}
		}

	}
	public void foxDist(){
		Random.InitState(System.DateTime.Now.Millisecond);
		randNum = Random.Range (0, 101);

		if (randNum > 95) 
		{
			if (GameControl.physiqueStat < 30) {
				GameControl.physiqueStat = GameControl.physiqueStat + 8; 

			}
			GameControl.mcFurColor = GameControl.MCFurColor.DarkRed;   
			GameControl.buildStat = GameControl.buildStat + 8;
			GameControl.facialFeaturesStat = GameControl.facialFeaturesStat - 2; 
			charSettler.setCharFemininity ();
			WorldControl.itemUseText = "The potion was very powerful! Your muscles look more toned, your face more masculine and your fur is now dark red!";

		} else if (randNum > 90) {
			GameControl.mcFurColor = GameControl.MCFurColor.DarkRed;   
			WorldControl.itemUseText =  "The potion wasn't that powerful, but your fur becomes dark red!";

		}else {
			GameControl.buildStat = GameControl.buildStat + 8;
			WorldControl.itemUseText = "Your drink the potion and in few minutes you note that your muscles become more toned! ";
			if (GameControl.physiqueStat < 30) {
				GameControl.physiqueStat = GameControl.physiqueStat + 8; 
				WorldControl.itemUseText = "Your drink the potion and in few minutes you note that your muscles become more toned and you also gained some weight! ";
			}
			GameControl.buildStat = GameControl.buildStat + 8;


		}



	}

	public void cleanser(){

		GameControl.hasFur = false;
		GameControl.hasFeathers = false;
		GameControl.hasKnot = false;
		GameControl.hasScales = false;
		GameControl.hasTentacles = false;

		GameControl.mcLegs = GameControl.MCLegs.HUMAN;
		GameControl.mcArms = GameControl.MCArms.HUMAN;
		GameControl.mcHead = GameControl.MCHead.HUMAN;
		GameControl.mcRace = GameControl.MCRace.Human;
		GameControl.mcShoulderBlades = GameControl.MCShoulderBlades.NONE;
		GameControl.mcSkinType = GameControl.MCSkinType.HUMAN;
		GameControl.mcTailType = GameControl.MCTailType.NONE;
		GameControl.mcDickType = GameControl.MCDickType.human;
		GameControl.mcHeadAccesory1 = GameControl.MCHeadAccesory1.NONE;
		GameControl.mcHeadAccesory2 = GameControl.MCHeadAccesory2.NONE;
		WorldControl.itemUseText = "You drink the cleanser, and you start to transform back into a human!";


	}

	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	///
	///
	/// <summary>
	/// EQUIP
	/// </summary>
	/// 
	/// 
	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	public void weaponUnnarmed(){
		WorldControl.itemUseText = "You are unarmed";

		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [0] != 10000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[0]; 
			GameControl.charEquipment [0] = 10000; 


		} else {
			GameControl.charEquipment [2] = 10000; 

		}
		setEquipment.setEquipModifiers ();

	}



	public void weaponOldSword(){
		WorldControl.itemUseText = "You equiped the old sword of your retainer. Although nostalgic and trustworthy, there are probably better items at the armory";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [0] != 10000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[0]; 
			GameControl.charEquipment [0] = 10001; 


		} else {
			GameControl.charEquipment [0] = 10001; 
		}
		setEquipment.setEquipModifiers ();

	}


	public void weaponGladius(){
		WorldControl.itemUseText = "You equip yourself with a gladius";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [0] != 10000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[0]; 
			GameControl.charEquipment [0] = 10002; 


		} else {
			GameControl.charEquipment [0] = 10002; 
		}
		setEquipment.setEquipModifiers ();

	}


	public void weaponVeil(){
		WorldControl.itemUseText = "You equip yourself with a very exotic veil.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [0] != 10000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[0]; 
			GameControl.charEquipment [0] = 10003; 


		} else {
			GameControl.charEquipment [0] = 10003; 
		}
		setEquipment.setEquipModifiers ();

	}


	public void weaponLeatherWhip(){
		WorldControl.itemUseText = "You equip the leather whip";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [0] != 10000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[0]; 
			GameControl.charEquipment [0] = 10004; 


		} else {
			GameControl.charEquipment [0] = 10004; 
		}
		setEquipment.setEquipModifiers ();

	}


	public void weaponLustick(){
		WorldControl.itemUseText = "You equip the Luststick";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [0] != 10000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[0]; 
			GameControl.charEquipment [0] = 10005; 


		} else {
			GameControl.charEquipment [0] = 10005; 
		}
		setEquipment.setEquipModifiers ();

	}


	public void weaponHuntingBow(){
		WorldControl.itemUseText = "You equip the hunting bow";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [0] != 10000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[0]; 
			GameControl.charEquipment [0] = 10006; 


		} else {
			GameControl.charEquipment [0] = 10006; 
		}
		setEquipment.setEquipModifiers ();

	}



	public void weaponHeirloomSword(){
		WorldControl.itemUseText = "You equip your heirloom sword";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [0] != 10000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[0]; 
			GameControl.charEquipment [0] = 10022; 


		} else {
			GameControl.charEquipment [0] = 10022; 
		}
		setEquipment.setEquipModifiers ();

	}


/// <summary>
/// Armour 20000
/// </summary>

	public void armorNaked()
	{
		WorldControl.itemUseText = "You get yourself naked";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [1] != 20000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[1]; 
			GameControl.charEquipment [1] = 20000; 


		} else {
			GameControl.charEquipment [1] = 20000; 
		}
		setEquipment.setEquipModifiers ();

	}


	public void armorLegionary()
	{
		WorldControl.itemUseText = "You equip the legionary armour.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [1] != 20000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[1]; 
			GameControl.charEquipment [1] = 20001; 
			WorldControl.charComDefense = 0.2f;
			WorldControl.charLustDefense = 0.1f;
			 

		} else {
			GameControl.charEquipment [1] = 20001; 
		}
		 
		setEquipment.setEquipModifiers ();
	}



	public void armorCenturio()
	{
		WorldControl.itemUseText = "You equip the centurio armour.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [1] != 20000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[1]; 
			GameControl.charEquipment [1] = 20002; 
			WorldControl.charComAttackArmor = 0.05f; 
			WorldControl.charComDefense = 0.25f;
			WorldControl.charLustDefense = 0.1f;
		

		} else {
			GameControl.charEquipment [2] = 20002; 
		}
		 
		setEquipment.setEquipModifiers ();
	}






	public void armorLegatus()
	{
		WorldControl.itemUseText = "You equip the legatus armour. ";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [1] != 20000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[1]; 
			GameControl.charEquipment [1] = 20003; 
			WorldControl.charComAttackArmor = 0.1f; 
			WorldControl.charComDefense = 0.3f;
			WorldControl.charLustDefense = 0.15f;
			 

		} else {
			GameControl.charEquipment [1] = 20003; 
		}
		 
		setEquipment.setEquipModifiers ();
	}


	public void armorCaesar()
	{
		WorldControl.itemUseText = "You equip the Caesar armour.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [1] != 20000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[1]; 
			GameControl.charEquipment [1] = 20004; 
			WorldControl.charComAttackArmor = 0.2f; 
			WorldControl.charComDefense = 0.3f;
			WorldControl.charLustDefense = 0.2f;
			 

		} else {
			GameControl.charEquipment [1] = 20004; 
		}
		 
		setEquipment.setEquipModifiers ();

	}


	public void armorSexyConsul()
	{
		WorldControl.itemUseText = "You are now wearing sexy consul clothes.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [1] != 20000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[1]; 
			GameControl.charEquipment [1] = 20005; 
			WorldControl.charLustAttackArmor = 0.05f; 
			WorldControl.charComDefense = 0.2f;
			WorldControl.charLustDefense = 0.2f;
			 

		} else {
			GameControl.charEquipment [1] = 20005; 
		}
		 
		setEquipment.setEquipModifiers ();

	}


	public void armorCataprach()
	{
		WorldControl.itemUseText = "You equip the Cataprach armour.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [1] != 20000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[1]; 
			GameControl.charEquipment [1] = 20006; 
			WorldControl.charComDefense = 0.2f;
			WorldControl.charLustDefense = 0.1f;
			 

		} else {
			GameControl.charEquipment [1] = 20006; 
		}
		 
		setEquipment.setEquipModifiers ();
	}



	public void armorSexyFem1()
	{
		WorldControl.itemUseText = "You are now wearing sexy femenine clothes! ";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [1] != 20000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[1]; 
			GameControl.charEquipment [1] = 20007; 
			WorldControl.charLustAttackArmor = 0.1f; 
			WorldControl.charComDefense = 0.15f;
			WorldControl.charLustDefense = 0.1f;
			 

		} else {
			GameControl.charEquipment [1] = 20007; 
		}
		 
		setEquipment.setEquipModifiers ();
	}


	public void armorTraveling()
	{
		WorldControl.itemUseText = "You are now wearing traveling clothes.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [1] != 20000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[1]; 
			GameControl.charEquipment [1] = 20008; 
			WorldControl.charComDefense = 0.1f;
			WorldControl.charLustDefense = 0.2f;


		} else {
			GameControl.charEquipment [1] = 20008; 
		}
		 
		setEquipment.setEquipModifiers ();
	}



	public void armorReligiousHabit(){
		WorldControl.itemUseText = "You are now wearing a religious habit.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [1] != 20000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[1]; 
			GameControl.charEquipment [1] = 20009; 
			WorldControl.charComDefense = 0.2f;
			WorldControl.charLustDefense = 0.25f;
			 


		} else {
			GameControl.charEquipment [1] = 20009; 
		}
		 
		setEquipment.setEquipModifiers ();
	}


	public void armorPatricianSuit()
	{
		WorldControl.itemUseText = "You are now wearing a patrician suit. ";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [1] != 20000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[1]; 
			GameControl.charEquipment [1] = 20010; 
			WorldControl.charComAttackArmor = 0.05f; 
			WorldControl.charComDefense = 0.25f;
			WorldControl.charLustDefense = 0.15f;
			 

		} else {
			GameControl.charEquipment [1] = 20010; 
		}
		 
		setEquipment.setEquipModifiers ();
	}


	public void armorSenator()
	{
		WorldControl.itemUseText = "You are now wearing senator clothes.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [1] != 20000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[1]; 
			GameControl.charEquipment [1] = 20011; 
			WorldControl.charComAttackArmor = 0.1f; 
			WorldControl.charComDefense = 0.25f;
			WorldControl.charLustDefense = 0.15f;
			 

		} else {
			GameControl.charEquipment [1] = 20011; 
		}
		 
		setEquipment.setEquipModifiers ();
	}


	public void armorSilkDress()
	{
		WorldControl.itemUseText = "You are now wearing a silk dress!";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [1] != 20000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[1]; 
			GameControl.charEquipment [1] = 20012; 
			WorldControl.charLustAttackArmor = 0.15f;
			WorldControl.charComDefense = 0.15f;
			WorldControl.charLustDefense = 0.15f;


		} else {
			GameControl.charEquipment [1] = 20012; 
		}
		 
		setEquipment.setEquipModifiers ();
	}


	public void armorSilkDressObs()
	{
		WorldControl.itemUseText = "You are now wearing an obscene silk dress!";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [1] != 20000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[1]; 
			GameControl.charEquipment [1] = 20013; 



			 

		} else {
			GameControl.charEquipment [1] = 20013; 
		}
		 
		setEquipment.setEquipModifiers ();
	}


	public void armorLoveMaidenBikini()
	{
		string mcpronoun; 
		if (GameControl.facialFeaturesStat > 10) {
			mcpronoun = "Lady";
		} else {
			mcpronoun = "Lord";
		}
		string line1 =""; 
		if (GameControl.hasVagina == true) {
			line1 = "You ran a couple of fingers over your own moist pussy, as its getting wet as you feel exposed to the other two persons in the room, as you can see through the reflection that their faces are getting flustered by the sight of your naked lewd flesh.";
		} else if(GameControl.dick1Size > 0) {
			line1 = "You ran a hand over your cock, as you can feel the precum flashing on the tip of it as you feel exposed to the other two persons in the room, as you can see through the reflection that their faces are getting flustered by the sight of your naked lewd flesh.";

		}

		string line2 = "";
		if (GameControl.hasVagina == true) {
			line2 = "It starts to lick your pussy, as it enjoys the fluids of your presented womanhood, as if it’s trying to calm its own lust.";
		} else if (GameControl.dick1Size > 0) {
			line2 = "It starts to run its tongue through all the length of your cock, as it slurps the precum that comes out after that, as if it’s trying to calm its own lust.";
		}



		if (GameControl.isVirgin != true) {
			WorldControl.itemUseText = "You try to equip the armour but you can't! Your body isn't pure enough for it! It looks like you need to be a virgin to wear it, shame...";
			WorldControl.wasEquiped = false; //cleans var
			if (GameControl.charEquipment [1] != 20000) {
				WorldControl.wasEquiped = true; 
				WorldControl.switchItem = 20014; 



			}
			WorldControl.switchItem = 20014; 


		} else {

			if (SpecialItemsControl.item20014FirstUse == false) {
				SpecialItemsControl.item20014FirstUse = true; 


				WorldControl.itemUseText = "After you acquire the armor, you brought it with you to the castle, calling for Helena as you tell her that you will require some help with it. <i>”Right away, my "+ mcpronoun +".”</i> she says, before calling for another servant. After both of them arrive to your bedroom, they close the door behind them as you undress. After you’re completely naked, they help you equip that piece of bikini armor.";
				WorldControl.itemUseText += "After you’re wearing it, you stand in front of the mirror and take a look at your new appearance. You slowly touch your chest, feeling its naked skin with the tip of your fingers. You can feel how your face is getting red rather quickly, as you can see how your servants are staring at your almost naked body. You ran your hands through your exposed skin, going lower as you get closer to your groin. " + line1 +" You tell the servants of how exposed you’re feeling, and how it feels really good. ";
				WorldControl.itemUseText += "<i>“If I can add, my "+ mcpronoun +", you look gorgeous,”</i> Helena says, without taking her eyes off you. You can see that the other servant is nodding shyly to Helena’s remark, and without any further warning they ran their hands over your naked skin, as Helena’s quickly gets closer to your face, giving you a passionate kiss, as her tongue wraps itself around your own. You can see through the mirror, that the other servant kneels in front of you, as she runs her hands through your hips as she gets closer to your groin. "+ line2 +"But, after a couple of seconds of making out, they take a step back and clean their mouths of your fluids.";
				WorldControl.itemUseText += "You can see that both of them are blushing, probably ashamed of their sudden behavior. <i>“Perhaps one day we can get our own suit like that,”</i> you can hear from Helena, talking to the other servant, as the other smiles in excitement probably from the thought of having one like yours. \n\nAfter that, you can feel your own body prepared for anything that could be thrown at you, as you can see how Helena and the other servant jump into each other as they can’t control their lusts, playing with their genitals with their hands, their moans can be heard as you leave the room, ready for anything.";


			} else {
				WorldControl.itemUseText = "When you wear the bikini armor, you feel even more exposed than just walking naked. The way the clothing is made, emphasizes your naughty bits, as you can see that you’re blushing by the sight of your bared body. After that, you feel ready for anything.";
			}
				
			WorldControl.wasEquiped = false; //cleans var
			if (GameControl.charEquipment [1] != 20000) {
				WorldControl.wasEquiped = true; 
				WorldControl.switchItem = GameControl.charEquipment [1]; 
				GameControl.charEquipment [1] = 20014; 
				 
				setEquipment.setEquipModifiers ();
			} else {
				GameControl.charEquipment [1] = 20014; 
				 
				setEquipment.setEquipModifiers ();
			}
	


		}




	}

	public void armorHeirloomArmour()
	{
		WorldControl.itemUseText = "You are now wearing your heirloom armour! Your parents would be proud!";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [1] != 20000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[1]; 
			GameControl.charEquipment [1] = 20024; 


		} else {
			GameControl.charEquipment [1] = 20024; 
		}

		setEquipment.setEquipModifiers ();
	}

	public void armorElvenArmour()
	{
		WorldControl.itemUseText = "You are now wearing an elven armour!";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [1] != 20000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[1]; 
			GameControl.charEquipment [1] = 20025; 


		} else {
			GameControl.charEquipment [1] = 20025; 
		}

		setEquipment.setEquipModifiers ();
	}

	public void armorElvenLightArmour()
	{
		WorldControl.itemUseText = "You are now wearing an elven armour!";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [1] != 20000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[1]; 
			GameControl.charEquipment [1] = 20026; 


		} else {
			GameControl.charEquipment [1] = 20026; 
		}

		setEquipment.setEquipModifiers ();
	}

	public void armorElvenDress()
	{
		WorldControl.itemUseText = "You are now wearing an elven armour!";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [1] != 20000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[1]; 
			GameControl.charEquipment [1] = 20027; 


		} else {
			GameControl.charEquipment [1] = 20027; 
		}

		setEquipment.setEquipModifiers ();
	}


	public void sexyLeatherOutfit() // NO MODIFIERS YET 
	{
		WorldControl.itemUseText = "You are now wearing a sexy leather outfit!";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [1] != 20000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[1]; 
			GameControl.charEquipment [1] = 20028; 


		} else {
			GameControl.charEquipment [1] = 20028; 
		}

		setEquipment.setEquipModifiers ();
	}

	public void maidDress() // NO MODIFIERS YET 
	{
		WorldControl.itemUseText = "You are now wearing a maid dress!";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [1] != 20000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[1]; 
			GameControl.charEquipment [1] = 20029; 


		} else {
			GameControl.charEquipment [1] = 20029; 
		}

		setEquipment.setEquipModifiers ();
	}



	public void armorOriginArmour()
	{
		WorldControl.itemUseText = "You are now wearing the Origin armour";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [1] != 20000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[1]; 
			GameControl.charEquipment [1] = 20500; 


		} else {
			GameControl.charEquipment [1] = 20500; 
		}

		setEquipment.setEquipModifiers ();
	}

	/// <summary>
	/// Helmets 30000
	/// </summary>


	public void helmetNone()
	{
		WorldControl.itemUseText = "You have nothing equiped";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [2] != 30000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[2]; 
			GameControl.charEquipment [2] = 30000; 


		} else {
			GameControl.charEquipment [2] = 30000; 
		}
		 
		setEquipment.setEquipModifiers ();
	}

	public void helmetGalea () 
	{
		WorldControl.itemUseText = "You equiped the Galea helmet.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [2] != 30000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[2]; 
			GameControl.charEquipment [2] = 30001; 


		} else {
			GameControl.charEquipment [2] = 30001; 
		}
		 
		setEquipment.setEquipModifiers ();


	}
	public void helmetGladiator () // 30002
	{
		WorldControl.itemUseText = "You equip the gladiator helmet.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [2] != 30000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[2]; 
			GameControl.charEquipment [2] = 30002; 
		} else {
			GameControl.charEquipment [2] = 30002; 
		}
		 
		setEquipment.setEquipModifiers ();
	}

	public void helmetDBHood ()
	{
		WorldControl.itemUseText = "You are wearing a red hood.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [2] != 30000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[2]; 
			GameControl.charEquipment [2] = 30003; 


		} else {
			GameControl.charEquipment [2] = 30003; 
		}
		 
		setEquipment.setEquipModifiers ();
	}

	public void helmetLaurelCrown()
	{
		WorldControl.itemUseText = "You are now wearing a laurel crown.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [2] != 30000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[2]; 
			GameControl.charEquipment [2] = 30004; 


		} else {
			GameControl.charEquipment [2] = 30004; 
		}
		 
		setEquipment.setEquipModifiers ();
	}

	public void helmetOriginMask()
	{
		WorldControl.itemUseText = "You are now wearing the Origin Mask.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [2] != 30000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[2]; 
			GameControl.charEquipment [2] = 30500; 


		} else {
			GameControl.charEquipment [2] = 30500; 
		}

		setEquipment.setEquipModifiers ();
	}

	/// <summary>
	/// Face 40000
	/// </summary>

	public void faceNone()
	{
		WorldControl.itemUseText = "";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [3] != 40000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[3]; 
			GameControl.charEquipment [3] = 40000; 


		} else {
			GameControl.charEquipment [3] = 40000; 
		}
		 
		setEquipment.setEquipModifiers ();
	}


	public void faceBandolier()
	{
		WorldControl.itemUseText = "You are now wearing a bandolier.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [3] != 40000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[3]; 
			GameControl.charEquipment [3] = 40001; 


		} else {
			GameControl.charEquipment [3] = 40001; 
		}
		 
		setEquipment.setEquipModifiers ();
	}


	public void faceGladiatorMask()
	{
		WorldControl.itemUseText = "You are now wearing a gladiator mask.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [3] != 40000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[3]; 
			GameControl.charEquipment [3] = 40002; 


		} else {
			GameControl.charEquipment [3] = 40002; 
		}
		 
		setEquipment.setEquipModifiers ();
	}


	public void faceLibrarianGlasses()
	{
		WorldControl.itemUseText = "You are now wearing librarian glasses.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [3] != 40000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[3]; 
			GameControl.charEquipment [3] = 40003; 


		} else {
			GameControl.charEquipment [3] = 40003; 
		}
		 
		setEquipment.setEquipModifiers ();
	}


	public void faceDarkShades()
	{
		WorldControl.itemUseText = "You are now wearing dark shades.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [3] != 40000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[3]; 
			GameControl.charEquipment [3] = 40004; 


		} else {
			GameControl.charEquipment [3] = 40004; 
		}
		 
		setEquipment.setEquipModifiers ();
	}


	public void faceOriginMask()
	{
		WorldControl.itemUseText = "You are now wearing the Origin mask.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [3] != 40000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[3]; 
			GameControl.charEquipment [3] = 40500; 


		} else {
			GameControl.charEquipment [3] = 40500; 
		}

		setEquipment.setEquipModifiers ();
	}

	/// <summary>
	/// Neck 50000
	/// </summary>


	public void neckNone()
	{
		WorldControl.itemUseText = "";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [4] != 50000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[4]; 
			GameControl.charEquipment [4] = 50000; 


		} else {
			GameControl.charEquipment [4] = 50000; 
		}
		 
		setEquipment.setEquipModifiers ();
	}
	public void neckRScarf()
	{
		WorldControl.itemUseText = "You are now wearing a red scarf.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [4] != 50000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[4]; 
			GameControl.charEquipment [4] = 50001; 


		} else {
			GameControl.charEquipment [4] = 50001; 
		}
		 
		setEquipment.setEquipModifiers ();
	}


	public void neckGorget()
	{
		WorldControl.itemUseText = "You are now wearing a steel gorget.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [4] != 50000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[4]; 
			GameControl.charEquipment [4] = 50002; 


		} else {
			GameControl.charEquipment [4] = 50002; 
		}
		 
		setEquipment.setEquipModifiers ();
	}


	public void neckSlaveCollar1()
	{
		WorldControl.itemUseText = "You are now wearing a slave collar. You are now at the bottom of the social ladder.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [4] != 50000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[4]; 
			GameControl.charEquipment [4] = 50003; 


		} else {
			GameControl.charEquipment [4] = 50003; 
		}
		 
		setEquipment.setEquipModifiers ();
	}


	public void neckSpikedCollar()
	{
		WorldControl.itemUseText = "You are now wearing a spiked collar.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [4] != 50000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[4]; 
			GameControl.charEquipment [4] = 50004; 


		} else {
			GameControl.charEquipment [4] = 50004; 
		}
		 
		setEquipment.setEquipModifiers ();
	}


	public void neckGoldNecklace1()
	{
		WorldControl.itemUseText = "You are now wearing a golden necklace.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [4] != 50000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[4]; 
			GameControl.charEquipment [4] = 50005; 


		} else {
			GameControl.charEquipment [4] = 50005; 
		}
		 
		setEquipment.setEquipModifiers ();
	}


	public void neckOriginGorget()
	{
		WorldControl.itemUseText = "You are now wearing the Origin gorget.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [4] != 50000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[4]; 
			GameControl.charEquipment [4] = 50500; 


		} else {
			GameControl.charEquipment [4] = 50500; 
		}

		setEquipment.setEquipModifiers ();
	}



	/// <summary>
	/// shoulders 60000
	/// </summary>
	public void shouldersNone()
	{
		WorldControl.itemUseText = "";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [5] != 60000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[5]; 
			GameControl.charEquipment [5] = 60000; 


		} else {
			GameControl.charEquipment [5] = 60000; 
		}
		 
		setEquipment.setEquipModifiers ();
	}



	public void shouldersRCape()
	{
		WorldControl.itemUseText = "You are now wearing a red cape.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [5] != 60000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[5]; 
			GameControl.charEquipment [5] = 60001; 


		} else {
			GameControl.charEquipment [5] = 60001; 
		}
		 
		setEquipment.setEquipModifiers ();
	}



	public void shouldersSurvivalBackpack()
	{
		WorldControl.itemUseText = "You are now wearing a survival backpack.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [5] != 60000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[5]; 
			GameControl.charEquipment [5] = 60002; 


		} else {
			GameControl.charEquipment [5] = 60002; 
		}
		 
		setEquipment.setEquipModifiers ();
	}



	public void shouldersRSchoolBackpack()
	{
		WorldControl.itemUseText = "You are now wearing a red school backpack.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [5] != 60000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[5]; 
			GameControl.charEquipment [5] = 60003; 


		} else {
			GameControl.charEquipment [5] = 60003; 
		}
		 
		setEquipment.setEquipModifiers ();
	}



	public void shouldersPauldrons()
	{
		WorldControl.itemUseText = "You are now wearing steel pauldrons.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [5] != 60000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[5]; 
			GameControl.charEquipment [5] = 60004; 


		} else {
			GameControl.charEquipment [5] = 60004; 
		}
		 
		setEquipment.setEquipModifiers ();
	}



	public void shouldersPauldronsRCape()
	{
		WorldControl.itemUseText = "You are now wearing steel pauldrons and a red cape.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [5] != 60000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[5]; 
			GameControl.charEquipment [5] = 60005; 


		} else {
			GameControl.charEquipment [5] = 60005; 
		}
		 
		setEquipment.setEquipModifiers ();
	}


	public void shouldersOriginCape()
	{
		WorldControl.itemUseText = "You are now wearing the Origin cape.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [5] != 60000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[5]; 
			GameControl.charEquipment [5] = 60500; 


		} else {
			GameControl.charEquipment [5] = 60500; 
		}

		setEquipment.setEquipModifiers ();
	}




	/// <summary>
	/// arms 70000
	/// </summary>

	public void armsNone()
	{
		WorldControl.itemUseText = "";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [6] != 70000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[6]; 
			GameControl.charEquipment [6] = 70000; 


		} else {
			GameControl.charEquipment [6] = 70000; 
		}
		 
		setEquipment.setEquipModifiers ();
	}


	public void armsGauntlet()
	{
		WorldControl.itemUseText = "You are now wearing steel gauntlets.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [6] != 70000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[6]; 
			GameControl.charEquipment [6] = 70001; 


		} else {
			GameControl.charEquipment [6] = 70001; 
		}
		 
		setEquipment.setEquipModifiers ();
	}


	public void armsBFishnet()
	{
		WorldControl.itemUseText = "You are now wearing black fishnets.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [6] != 70000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[6]; 
			GameControl.charEquipment [6] = 70002; 


		} else {
			GameControl.charEquipment [6] = 70002; 
		}
		 
		setEquipment.setEquipModifiers ();
	}



	public void armsPSpandex()
	{
		WorldControl.itemUseText = "You are now wearing pink spandex armsleeves.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [6] != 70000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[6]; 
			GameControl.charEquipment [6] = 70003; 


		} else {
			GameControl.charEquipment [6] = 70003; 
		}
		 
		setEquipment.setEquipModifiers ();
	}



	public void armsSpikedWristband()
	{
		WorldControl.itemUseText = "You are now wearing a spiked wristband.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [6] != 70000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[6]; 
			GameControl.charEquipment [6] = 70004; 


		} else {
			GameControl.charEquipment [6] = 70004; 
		}
		 
		setEquipment.setEquipModifiers ();
	}



	public void armsFingerlessGloves()
	{
		WorldControl.itemUseText = "You are now wearing fingerless gloves.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [6] != 70000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[6]; 
			GameControl.charEquipment [6] = 70005; 


		} else {
			GameControl.charEquipment [6] = 70005; 
		}
		 
		setEquipment.setEquipModifiers ();
	}



	public void armsBandages()
	{
		WorldControl.itemUseText = "You are now wearing arm bandages.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [6] != 70000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[6]; 
			GameControl.charEquipment [6] = 70006; 


		} else {
			GameControl.charEquipment [6] = 70006; 
		}
		 
		setEquipment.setEquipModifiers ();
	}

	public void armsOriginGauntlet()
	{
		WorldControl.itemUseText = "You are now wearing the Origin Gauntlets.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [6] != 70000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[6]; 
			GameControl.charEquipment [6] = 70500; 


		} else {
			GameControl.charEquipment [6] = 70500; 
		}

		setEquipment.setEquipModifiers ();
	}


	/// <summary>
	/// legs 80000
	/// </summary>

	public void legsNone()
	{
		WorldControl.itemUseText = "";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [7] != 80000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[7]; 
			GameControl.charEquipment [7] = 80000; 


		} else {
			GameControl.charEquipment [7] = 80000; 
		}
		 
		setEquipment.setEquipModifiers ();
	}



	public void legsCombatBoots()
	{		
		WorldControl.itemUseText = "You are now wearing combat boots.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [7] != 80000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[7]; 
			GameControl.charEquipment [7] = 80001; 


		} else {
			GameControl.charEquipment [7] = 80001; 
		}
		 
		setEquipment.setEquipModifiers ();
	}



	public void legsGreaves()
	{
		WorldControl.itemUseText = "You are now wearing steel greaves.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [7] != 80000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[7]; 
			GameControl.charEquipment [7] = 80002; 


		} else {
			GameControl.charEquipment [7] = 80002; 
		}
		 
		setEquipment.setEquipModifiers ();
	}



	public void legsElegantSandals()
	{
		WorldControl.itemUseText = "You are now wearing elegant sandals. ";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [7] != 80000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[7]; 
			GameControl.charEquipment [7] = 80003; 


		} else {
			GameControl.charEquipment [7] = 80003; 
		}
		 
		setEquipment.setEquipModifiers ();
	}



	public void legsBandages()
	{
		WorldControl.itemUseText = "You are now wearing leg bandages.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [7] != 80000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[7]; 
			GameControl.charEquipment [7] = 80004; 


		} else {
			GameControl.charEquipment [7] = 80004; 
		}
		 
		setEquipment.setEquipModifiers ();
	}
		

	public void legsBHighHeels()
	{
		WorldControl.itemUseText = "You are now wearing black high heels.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [7] != 80000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[7]; 
			GameControl.charEquipment [7] = 80005; 


		} else {
			GameControl.charEquipment [7] = 80005; 
		}
		 
		setEquipment.setEquipModifiers ();
	}

	public void legsOriginboots()
	{
		WorldControl.itemUseText = "You are now wearing origin boots.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [7] != 80000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[7]; 
			GameControl.charEquipment [7] = 80500; 


		} else {
			GameControl.charEquipment [7] = 80500; 
		}

		setEquipment.setEquipModifiers ();
	}

	/// <summary>
	/// Makeup 90000
	/// </summary>
	public void makeupNone()
	{
		WorldControl.itemUseText = "";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [8] != 90000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[8]; 
			GameControl.charEquipment [8] = 90000; 


		} else {
			GameControl.charEquipment [8] = 90000; 
		}
		 

	}


	public void makeupNatural()
	{
		WorldControl.itemUseText = "";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [8] != 90000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[8]; 
			GameControl.charEquipment [8] = 90001; 


		} else {
			GameControl.charEquipment [8] = 90001; 
		}
		 

	}


	public void makeupSlutty()
	{
		WorldControl.itemUseText = "";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [8] != 90000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[8]; 
			GameControl.charEquipment [8] = 90002; 


		} else {
			GameControl.charEquipment [8] = 90002; 
		}
		 
	}
		
	public void makeupTrival()
	{
		WorldControl.itemUseText = "";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [8] != 90000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[8]; 
			GameControl.charEquipment [8] = 90003; 


		} else {
			GameControl.charEquipment [8] = 90003; 
		}
		 
	}
		
	public void makeupElegant()
	{
		WorldControl.itemUseText = "";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [8] != 90000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[8]; 
			GameControl.charEquipment [8] = 90004; 


		} else {
			GameControl.charEquipment [8] = 90004; 
		}
		 
	}

	/// <summary>
	/// Amulet 100000
	/// </summary>
	public void amuletNone()
	{
		WorldControl.itemUseText = "";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [10] != 100000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[10]; 
			GameControl.charEquipment [10] = 100000; 


		} else {
			GameControl.charEquipment [10] = 100000; 
		}
		 
		setEquipment.setEquipModifiers ();

	}


	public void amuletFamilyHeirloom()
	{
		WorldControl.itemUseText = "You equip your family's amulet, feeling it's powerful magic making you stronger.";
		WorldControl.wasEquiped = false; 
		if (GameControl.charEquipment [10] != 110000) {
			WorldControl.wasEquiped = true; 
			WorldControl.switchItem = GameControl.charEquipment[10]; 
			GameControl.charEquipment [10] = 110004; 


		} else {
			GameControl.charEquipment [10] = 110004; 
		}
		 
		setEquipment.setEquipModifiers ();

	}




}
