using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class TitlesController  {

	public static List<Titles> UniqueTitles = new List<Titles>();


	public static void giveTitles(Titles titles){
		UniqueTitles.Add (titles);

	}


	public static void removeTitles(Titles titles){
		UniqueTitles.Remove (titles);
	}


	public static bool isGiven<T>() where T: Titles {
		foreach (Titles titles in UniqueTitles) {
			if (titles is T) {
				return true; 
			}
		}
		return false;
	}



	public static T Get<T>() where T: Titles {
		foreach (Titles titles in UniqueTitles) {
			if(titles is T){
				return (T)titles; 
			}
		}
		return null; 
	}


}



[System.Serializable]
public class Titles {
	public int charID; 
	public string charName;
	public string titleName;
}

[System.Serializable]
public class Gentleman : Titles{
	public string titleName = "Gentleman";
}

[System.Serializable]
public class Gentlewoman : Titles{
	public string titleName = "Gentlewoman";
}

[System.Serializable]
public class Esquire : Titles{
	public string titleName = "Esquire";
}
