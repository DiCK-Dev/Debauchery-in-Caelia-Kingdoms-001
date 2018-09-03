using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;


[System.Serializable]
public class RulesNPC {
	public static List<fileRulesNPC> savedRules = new List<fileRulesNPC>();

}


[System.Serializable]

public class fileRulesNPC {
	public int id; 
	public string reportOld;
	public string reportNew;
	public int idx; 

	//////////////////////////////////////////////////////////////////

	public enum Wages { None, Low, Average, Good, High, Exorbitant}; // 0, 1, 3, 5, 10, 20
	public Wages wage; 
	public enum Sleeping { Ground, Barracks, [Description("Private room")]PrivateRoom, Boudoir, [Description("Your room")] MCRoom, Dungeon };
	public Sleeping sleeping;
	public enum Diet { [Description("Rancid food")]RancidFood, [Description("Cheap food")]CheapFood, [Description("Fresh food")]FreshFood,  [Description("Left overs")]LeftOvers, [Description("Beasts cum")]BeastsCum};
	public Diet diet; // cost: 0, 1, 3, 0, 0  
	public bool foodAphrodisiacs;

	//////////////////////////////////////////////////////////////////
	public bool forceSilence;
	public bool forceHumility;
	public bool chastityBelt;
	public bool denyOrgasm;
	public bool denyToileting;
	public bool behavePet;
	public bool behaveAlarm;
	public bool genitalVibes;
	public bool analPlug;
	//////////////////////////////////////////////////////////////////
	public bool privateBath;
	public bool privPhysician;
	public bool persStylist;
	public bool freeTime;
	//////////////////////////////////////////////////////////////////
	public bool drugForcedUse;
	public bool drugTobacco;
	public bool drugAlcohol;
	public bool drugDevilsFire;
	public bool drugDust;
	public bool drugBlueCapShroom; 

}