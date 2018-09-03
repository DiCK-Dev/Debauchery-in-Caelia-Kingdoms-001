using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class hoverSkills : MonoBehaviour {

	public static int pageSkill;

	public GameObject itemPrefab; 

	public void skillDescription(int selector){
		string descr = ""; 


		switch (selector) {
		case 0: // physical skill
			descr = "Physical stat: \n\nThis attribute is used along with other skills to succeed in certain actions. Important for physical attacks in combat.";

			break; 
		case 1: // martial, crafting, masseuse 
			if (pageSkill == 0) {
				descr = "Martial skill: \n\nPhysical skill used mostly for combat and (soon) certain events.";
			} else if (pageSkill == 1) {
				descr = "Crafting skill: \n\nPhysical skill used to craft objects (not in use yet).";
			} else {
				descr = "Masseuse skill: \n\nUsed to relax and please other people without the need to get too intimate.";
			}
			break;
		case 2: // security, house keeping, stripping
			if (pageSkill == 0) {
				descr = "Security skill: \n\nPhysical skill used to protect the streets. Used by guards and watchmen.";
			} else if (pageSkill == 1) {
				descr = "House keeping: \n\nPhysical skill used for cleaning, cooking and other tasks related to take care of the house. Used by maids and servants.";
			} else {
				descr = "Stripping:\n\nHow skilled you are at taking your clothes in public, keeping their interest in you.";
			}
			break;
		case 3: // labor, farm hand, bondage
			if (pageSkill == 0) {
				descr = "Labor skill: \n\nPhysical skill used to take care of heavy work like in construction.";
			} else if (pageSkill == 1) {
				descr = "Farm hand: \n\nPhysical skill related to taking care of both the fields and livestock.";
			} else {
				descr = "Bondage: \n\nHow good you are at tying people and hitting them without unnecesary harm.";
			}
			break;
		case 4: //mental 
			descr = "Mental stat: \n\nThis attribute is used along with other skills to increase your chance to succeed in certain actions. Important for mental tasks and certain skills in combat.";

			break;
		case 5: // tactics, medicine, pet play
			if (pageSkill == 0) {
				descr = "Tactics: \n\nSkill used for certain attacks in combat and other events.";
			} else if (pageSkill == 1) {
				descr = "Medicine: \n\nSkill used to heal and take care of other people.";
			} else {
				descr = "Pet play:\n\nHow good you are both at managing people or taking the pet role.";
			}
			break;
		case 6: // governance, alchemy, petting 
			if (pageSkill == 0) {
				descr = "Governance: \n\nSkill used to govern and manage your people properly.";
			} else if (pageSkill == 1) {
				descr = "Alchemy: \n\nHow good you are at mixing ingredients to create potions and concotions with diverse use.";
			} else {
				descr = "Petting: \n\nHow good are you with your hands to take care of people sexual needs.";
			}
			break;
		case 7: // stewardship, learning, group sex 
			if (pageSkill == 0) {
				descr = "Stewardship: \n\nSkill used to properly manage the economy of a business or kingdom.";
			} else if (pageSkill == 1) {
				descr = "Learning: \n\nYour overall knowledge that comes from books and good education.";
			} else {
				descr = "Group sex: \n\nHow good you are at orgies, making sure to please as many people as possible, at the same time.";
			}
			break;
		case 8: // social skill
			descr = "Social attribute: \n\nUsed with other skills to befriend and persuade people. Used in combat with most of the skills that increase the enemie's lust.";
			break;
		case 9: // persuasion, performance, penetration
			if (pageSkill == 0) {
				descr = "Persuasion: \n\nYour skill to change people's mind.";
			} else if (pageSkill == 1) {
				descr = "Performance: \n\nHow good you are at dancing, playing theater, and other artistics tasks.";
			} else {
				descr = "Penetration: \n\nGeneral sexual skill, used in almost every vanilla act.";
			}
			break;
		case 10: // intrigue, etiquete, whoring 
			if (pageSkill == 0) {
				descr = "Intrigue: \n\nHow good you are at spreading gossip, plot, and other shady tasks.";
			} else if (pageSkill == 1) {
				descr = "Etiquette: \n\nHow good are your manners and how well you can deal with court matters.";
			} else {
				descr = "Whoring: \n\nThe knowledge to properly sell yourself and taking care of clients.";
			}
			break;
		case 11: // diplomacy, streetwise, escorting 
			if (pageSkill == 0) {
				descr = "Diplomacy: \n\nYour knowledge of politics and the skill to make deals with opposite parties. ";
			} else if (pageSkill == 1) {
				descr = "Streetwise: \n\nYour knowledge of the black market and the underground world.";
			} else {
				descr = "Escorting: \n\nProper manners with clients, great to have lenghty and interesting conversations with them.";
			}
			break;
		}


		GameObject newPan  = Instantiate (itemPrefab) as GameObject;
		newPan.tag = "TempHover";
		newPan.GetComponentInChildren<Text> ().text = descr;

	}

	public void destroyTempHover(){
		GameObject[] tempHovers = GameObject.FindGameObjectsWithTag("TempHover");
		foreach(GameObject obj in tempHovers)
			GameObject.Destroy(obj);
	}




	void Start(){
		pageSkill = 0;
	}

}
