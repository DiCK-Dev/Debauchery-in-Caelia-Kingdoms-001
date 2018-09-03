using UnityEngine;
using System.Collections;
using System.Collections.Generic;


[System.Serializable]
public class LawController  {



	// Every active law.
	public static List<Law> ActiveLaws = new List<Law>();

	/* Makes a Law rule of the land! */
	public static void EnactLaw(Law law) {
		ActiveLaws.Add(law);
	}

	/* Repeals the law, nobody follows it now. */
	public static void RepealLaw(Law law) {
		ActiveLaws.Remove(law);
	}
	/**
   *    This is used to see if a law is actually active.  The <T> is called a 
   * generic, lets you plug in a type directly without .GetType(). Just remember,
   * T's a raw type, NOT a variable. You'd have to call typeof() on it to compare
   * it against a Type object. It works just fine in `is` statements, though.
   *
   * if(LawController.IsEnacted<SomeLaw>()) {
   *   SomeLaw law = LawController.Get<SomeLaw>();
   *   ...
   * }
   */


	public static bool IsEnacted<T>() where T: Law {
		foreach(Law law in ActiveLaws) {
			if(law is T) {
				return true;

			}
		}
		return false;

	}

	/**
   *    Same deal as the above, but instead of returning a bool, returns the actual 
   * law.  I would use this instead of IsEnacted<>() when I need to do more than
   * just check if it's there.
   *
   * SomeLaw law;
   * if((law = LawController.Get<SomeLaw>()) != null) {
   *   ... do stuff with law
   * }
   *
   *    That second line in a doozy, but remember that assignments also return 
   * the part on the right! You can do a=b=c; and a and b will be set to c.
   *
   * SO, that second line actually looks like:
   *
   * Law a = (law = LawController.Get<SomeLaw>());
   * if(a != null) ...
   */

	public static T Get<T>() where T: Law {
		foreach(Law law in ActiveLaws) {
			if(law is T) {
				return (T)law;
			}
		}
		return null;
	}
		
}

// LawController.EnactLaw(new Militia());
[System.Serializable]
public class Law {
	public string description;

}


/*public class Militia : Law{
	//public string description = "Something";
}*/
[System.Serializable]
public class LawArtsHigh : Law{

}
[System.Serializable]
public class LawArtsLow : Law{

}
[System.Serializable]
public class LawSportsHigh : Law{

}
[System.Serializable]
public class LawSportsLow : Law{

}
[System.Serializable]
public class LawFreeMilitia : Law{

}
[System.Serializable]
public class LawPersonalMilitia : Law{

}
[System.Serializable]
public class LawNoMilitia : Law{

}
[System.Serializable]
public class LawDomesticEconomyCommoner : Law{

}

[System.Serializable]
public class LawDomesticEconomyElite : Law{

}

[System.Serializable]
public class LawWarEconomy : Law{

}

[System.Serializable]
public class LawUniformsFashionable : Law{

}

[System.Serializable]
public class LawUniformsModern : Law{

}

[System.Serializable]
public class LawUniformsOutdated : Law{

}

[System.Serializable]
public class LawTaxesVeryLow : Law{

}

[System.Serializable]
public class LawTaxesLow : Law{

}

[System.Serializable]
public class LawTaxesNormal : Law{

}

[System.Serializable]
public class LawTaxesHigh : Law{

}

[System.Serializable]
public class LawTaxesVeryHigh : Law{

}

[System.Serializable]
public class LawStaffProfessionals : Law{

}

[System.Serializable]
public class LawStaffWhores : Law{

}

[System.Serializable]
public class LawChurchOrder : Law{

}

[System.Serializable]
public class LawChurchLove : Law{

}

[System.Serializable]
public class LawSlimeServants : Law{

}