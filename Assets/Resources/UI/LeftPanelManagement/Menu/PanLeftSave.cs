using UnityEngine;
using System; 




public class PanLeftSave : MonoBehaviour {

	public static int saveSelection; 
	public static int loadSelection; 



	// 0 to 4

	public void selectSave(int selector){
		saveSelection = selector;


	}

	public void selectLoad(int selector){
		loadSelection = selector;

	}



}
