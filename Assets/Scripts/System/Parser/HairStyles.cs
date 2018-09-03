using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class HairStyles : MonoBehaviour {


	public static Dictionary<int, HairStyles> hairStyleList = new Dictionary<int, HairStyles>(); 
	public string hairName; 



	public HairStyles(string hairname){
		hairName = hairname;


	}


	void startDictionary (){
		//0-999 short hairstyles


		HairStyles style0 = new HairStyles ("no haircut");
		hairStyleList.Add (0, style0);

		HairStyles style100 = new HairStyles ("shaven");
		hairStyleList.Add (100, style100);

		HairStyles style101 = new HairStyles ("Sassy short");
		hairStyleList.Add (101, style101);

		HairStyles style102 = new HairStyles ("Bob haircut");
		hairStyleList.Add (102, style102);

		HairStyles style103 = new HairStyles ("Pixie haircut");
		hairStyleList.Add (103, style103);

		HairStyles style104 = new HairStyles ("short mowhawk");
		hairStyleList.Add (104, style104);

		HairStyles style105 = new HairStyles ("comb over");
		hairStyleList.Add (105, style105);

		HairStyles style106 = new HairStyles ("curly bob haircut");
		hairStyleList.Add (106, style106);

		HairStyles style107 = new HairStyles ("Ivy League haircut");
		hairStyleList.Add (107, style107);

		HairStyles style108 = new HairStyles ("pompadour");
		hairStyleList.Add (108, style108);

		HairStyles style109 = new HairStyles ("short braids");
		hairStyleList.Add (109, style109);

		HairStyles style110 = new HairStyles ("haircut1");
		hairStyleList.Add (110, style110);


		//1000 - 1999

		HairStyles style1000 = new HairStyles ("twist-in bun");
		hairStyleList.Add (1000, style1000);

		HairStyles style1001 = new HairStyles ("elegant bun");
		hairStyleList.Add (1001, style1001);

		HairStyles style1002 = new HairStyles ("mohawk");
		hairStyleList.Add (1002, style1002);

		HairStyles style1003 = new HairStyles ("braids");
		hairStyleList.Add (1003, style1003);

		HairStyles style1004 = new HairStyles ("dreadlocks");
		hairStyleList.Add (1004, style1004);

		HairStyles style1005 = new HairStyles ("braided ponytail");
		hairStyleList.Add (1005, style1005);

		HairStyles style1006 = new HairStyles ("curly style");
		hairStyleList.Add (1006, style1006);

		HairStyles style1007 = new HairStyles ("haircut1");
		hairStyleList.Add (1007, style1007);

		HairStyles style1008 = new HairStyles ("haircut1");
		hairStyleList.Add (1008, style1008);

		HairStyles style1009 = new HairStyles ("haircut1");
		hairStyleList.Add (1009, style1009);

		HairStyles style1010 = new HairStyles ("haircut1");
		hairStyleList.Add (1010, style1010);
	

		//2000+ 
		HairStyles style2000 = new HairStyles ("long ponytails");
		hairStyleList.Add (2000, style2000);

		HairStyles style2001 = new HairStyles ("beehive hairstyle");
		hairStyleList.Add (2001, style2001);

		HairStyles style2002 = new HairStyles ("long mohawk");
		hairStyleList.Add (2002, style2002);

		HairStyles style2003 = new HairStyles ("long brides");
		hairStyleList.Add (2003, style2003);

		HairStyles style2004 = new HairStyles ("long dreadlocks");
		hairStyleList.Add (2004, style2004);

		HairStyles style2005 = new HairStyles ("long braided ponytails");
		hairStyleList.Add (2005, style2005);

		HairStyles style2006 = new HairStyles ("long curls");
		hairStyleList.Add (2006, style2006);

		HairStyles style2007 = new HairStyles ("haircut1");
		hairStyleList.Add (2007, style2007);

		HairStyles style2008 = new HairStyles ("haircut1");
		hairStyleList.Add (2008, style2008);

		HairStyles style2009 = new HairStyles ("haircut1");
		hairStyleList.Add (2009, style2009);

		HairStyles style2010 = new HairStyles ("haircut1");
		hairStyleList.Add (2010, style2010);

	
	}



	void Awake () {
		startDictionary ();
	}

	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
