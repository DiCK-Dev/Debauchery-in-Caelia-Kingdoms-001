using UnityEngine;
using System.Collections;

public class NPCSettlerSide : MonoBehaviour {


	public bool recruitStatus(int selector){
		if (selector == 0 || selector == 4 || selector == 5) {
			return true; 
		} else {
			return false; 
		}
	}

	public bool enemyStatus(int selector){
		if (selector == 1) {
			return true; 
		} else {
			return false; 
		}
	}

	public bool monsterStatus(int selector){
		if (selector == 2) {
			return true; 
		} else {
			return false; 
		}
	}

	public bool neutralStatus(int selector){
		if (selector == 3) {
			return true; 
		} else {
			return false; 
		}
	}

	public bool prisonerStatus(int selector)
	{
		if (selector == 4) {
			return true; 
		} else {
			return false; 
		}
	}


	public bool slaveStatus(int selector)
	{
		if (selector == 5) {
			return true; 
		} else {
			return false; 
		}
	}




}
