using UnityEngine;
using System.Collections;

public class CharSettler  {

	SetEquipment setEquip = new SetEquipment();
	CharSettlerBody setBody = new CharSettlerBody();
	CharSettlerSex setSex = new CharSettlerSex(); 



	public void updateCharacter(){

		setBody.setCharAss ();
		setBody.setCharHips ();
		setBody.setCharWaist ();
		setBody.setBodyShape ();

		setBody.setCharPhysique ();
		setBody.setCharBuild ();

		setBody.setBodyFeatures ();
		setBody.setFacialFeatures ();
		setBody.setGenderBehavior ();

		setBody.setHeigth ();

		setBody.setCharBreasts1 ();

		setBody.setCharDick1Name ();

		setBody.setTesticlesName ();

		setBody.setRace ();

		setSex.setCharGender ();

		setSex.setCharSex ();

		setEquip.setEquipModifiers ();



	}










}
