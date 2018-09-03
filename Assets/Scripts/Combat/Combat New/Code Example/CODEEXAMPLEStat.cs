using UnityEngine;
using System.Collections;

public class Stat {
	float _value=0;
	// C# event setup
	public event  StatModifierDelegate OnGet;
	public delegate float StatModifierDelegate();

	float Value {
		get {
			var output = this._value;
			// This is hardly a standard thing to do, but it's useful.
			foreach(StatModifierDelegate subscriber in OnGet.GetInvocationList())
				output += subscriber();
			return output;
		}
		set { this._value = value; }
	}
}
