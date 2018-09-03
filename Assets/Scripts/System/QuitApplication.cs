using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuitApplication : MonoBehaviour {
	public Text Board; 
	public RectTransform panQuitQuestion;

	public void askQuit(){
		Board.text = "Do you really want to quit the game?"; 
		panQuitQuestion.SetAsLastSibling ();

	}


		public void Quit()
		{
			#if UNITY_STANDALONE
			// Quit application
			Application.Quit(); 
			#endif
			#if UNITY_EDITOR
			// Quit app in editor
			UnityEditor.EditorApplication.isPlaying = false; 
			#endif

		}

}
