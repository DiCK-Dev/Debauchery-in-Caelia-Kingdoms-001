using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class FollowersSpecialEvents : MonoBehaviour {

	/// <summary>
	/// THIS script is used for special events for specific characters, they run in the end turn usually at the end of the night, but can be used for other occasions
	/// </summary>



	//NPC 6000 lucina
	public void lucinaEncounter(){
			int i = 0;
			while (i < NPCCharList.CharFollower.Count) 
			{
				if(NPCCharList.CharFollower[i].charID >= 6000 && NPCCharList.CharFollower[i].charID < 7000)
				{
					if(NPCCharList.CharFollower[i].isRecruited == false)
					{
						SceneManager.LoadScene (52);
					}
				}
				i++;
			}

	}

	////////////////////////////////////////////////////////////////////////





	void Awake (){

	}

}
