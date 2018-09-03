using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class AbbadonCorruption : MonoBehaviour {

	static int iAbbadon = 0;


	public Canvas panEndTurn;
	public Canvas mainMenu;
	public Canvas corruptionMenu; 

	public Button buttAlchemyDrink;

	public Button buttHypnotismPubFlirt; 

	public Button buttHypnotismPriCaress; 




	public Text Board; 

	public void openAlchemyMenu(){
		Board.text = "Decide how you want to deliver the drugs.";

	}

	public void openHypnotismMenu(){
		Board.text = "There are two types of commands, private and public. With private commands Abbadon will do things only to you, while with public favors Abbadon will take care of other people, not just you.";

	}

	public void openMenu(){
		if (GameControl.attHypnotism == 0) {
			Board.text = "You still haven't learn how to change people's mind and soul. Check your journal for more information.";
			
		} else {
			Board.text = "You can corrupt someone using different methods:\n\nHypnosis will help you corrupt a person and increase their relationship and loyalty with you at the same time. The success is your hypnosis skill against the will of your victim and its corruption. The higher the corruption, the easier it will be for you to get them under your control, while the higher their will the hardest it will be. \n\nEventually you’ll be able to erode their will, making them docile and submissive. \n\nAlchemy relies on getting more close and personal, and therefore the stronger the relationship you have with them, the better. A high alchemy skill will reduce the difficulty to succeed, and the more corrupt the subject is the easier it will be to get them to consume your concoctions. ";
			mainMenu.sortingOrder = -500; 
			corruptionMenu.sortingOrder = 500;
			if (NPCCharList.CharFollower [iAbbadon].attWillpower <= 100) {
				int will = (int)NPCCharList.CharFollower [iAbbadon].attWillpower;
				Board.text += "\n\nAbbadon current willpower is " + will.ToString ();
			} else {
				Board.text += "\n\nYou don't know yet what's the current willpower of Abbadon, you need to use your skill at least once to know this.";
			}
			Board.text += "\n\nYour hypnotism skill is " + GameControl.attHypnotism.ToString() + " and your alchemy skill is " + GameControl.utilitySkillAlchemy.ToString() + ".";
		}


	}

	void Start(){

		loadAbbadon ();
		if (NPCCharList.CharFollower[iAbbadon].attWillpower > 100) {
			//buttAlchemyDrink.interactable = false;
			buttHypnotismPubFlirt.interactable = false;
			buttHypnotismPriCaress.interactable = false;
		}

	}

	void loadAbbadon(){

		iAbbadon = 0;
		while (iAbbadon < NPCCharList.CharFollower.Count) {
			if (NPCCharList.CharFollower [iAbbadon].charID == 1000 ) {
				break; 
			}

			iAbbadon++;
		}

	}





}
