using UnityEngine;
using System.Collections;

public class SomeEffect {

	public Stat attphys;
	public void AttachTo(NPCData creature) {
		//this.attphys = creature.attPhysical; // = new Stat();
		attphys.OnGet += this.HandleAttPhysGet; 


	}
	public void DetachFrom(NPCData creature) {
		this.attphys.OnGet -= this.HandleAttPhysGet;
	}
	float HandleAttPhysGet() {
		return 5f; // Added to Strength.Value
	}


}


//THIS SHOULD BE HERE BUT IS HOW I SHOULD DO CREATURE CLASSES 
class Creature {
	public Stat attPhysical;
	public Stat attMental; 
}
