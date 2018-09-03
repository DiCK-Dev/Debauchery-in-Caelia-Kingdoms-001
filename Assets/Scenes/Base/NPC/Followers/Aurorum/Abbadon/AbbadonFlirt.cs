using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AbbadonFlirt : MonoBehaviour {
	int hashcode = GameControl.playerName.GetHashCode();
	float randNum;

	static string pronheshe;
	static string pronhimher;
	static string pronhisher; 

	static int iAbbadon = 0;
	public Text Board; 

	public Canvas PanEndTurn; 

	public Canvas PanRelationship;


	public void flirt(){


		loadAbbadon ();



		relationshipChange ();

		if (NPCCharList.CharFollower [iAbbadon].charCorruption < 33) {
			Board.text = flirtLevel1();
		} else if (NPCCharList.CharFollower [iAbbadon].charCorruption < 66) {
			Board.text = flirtLevel1();
		} else  {
			Board.text = flirtLevel2();
		}


		endTurnFun ();

	}





	string flirtLevel0(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum < 33) {
			toReturn = "";
			if (NPCCharList.CharFollower [iAbbadon].dickSize > 0) {
				toReturn += "";
			} else {
				toReturn += "";
			}
			toReturn += "";
			return toReturn;
		} else if (randNum < 66) {
			toReturn = "";
			if (GameControl.dick1Size> 0) {
				toReturn += "";
			} else {
				toReturn += "";
			}

			toReturn += "";			
			return toReturn;
		} else {
			return "";
		}

	}

	string flirtLevel1(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum < 33) {
			toReturn = "During one of your visits to Abbadon’s manor, you decide to roam through "+ pronhisher +" studio and inspect the cultural pieces collected over the years. Collections of books that sprawl through entire walls, and enough paintings to open an art museum litter the manor. While you may not have much knowledge on classic literature thanks to your rural childhood, you can respect the dedication it took to even collect this many novels. Some of the authors you recognize even, though many are only familiar from your late guardian or Helena mentioning them.\n\nAfter passing by a room of artifacts detailing pre-plague and even pre-kingdom life, you return to Abbadon to praise "+ pronhimher +" for their excellent taste and dedication "+ pronheshe +" put into creating this collection. <i>“Oh "+ GameControl.playerName +", I appreciate your observation. Indeed it has taken me many years to procure these rare bits and baubles, costing the manor many chests of gold in the process. In the end, I think it was well worth the trouble. Though I never did take you as one that would pursue the arts… did something here inspire you?”<i>\n\nYou tell Abbadon that "+ pronheshe +" could possibly help curate items for your own collection, which at this point is quite small. <i>“Oh, you wish to expand your collection? I would be delighted to assist you. Oh, and thanks for your recognition, "+ GameControl.playerName +".”<i>\n\nFor the rest of the meeting you can see that Abbadon is happy and cheerful around you, obviously delighted to have someone sharing "+ pronhisher +" tastes.";
			return toReturn;
		} else if (randNum < 66) {
			toReturn = "After a long day of discussion and revisions to your plans for the city, Abbadon asks you to go with "+ pronhimher +" to the park to relax. The two of you enjoy a pleasant stroll through the well kept gardens, the blooms a fleeting, but healthy reminder of what you are striving for in your kingdom.\n\nSuddenly Abbadon’s name is called from behind the both of you, and turning to the sound reveals one of Abbadon’s couriers declaring that there is a matter that needs "+ pronhisher +" orders relayed. <i>“Excuse me ten minutes "+ GameControl.playerName +", I need to give some instructions to my servant so she doesn’t screw up.”</i> Abbadon says with a hint of frustration. While "+ pronheshe +" is busy, you decide to wander off the regular path to one of the few secluded sections that Abbadon had showed you. Arriving at a clearing, you see what could only be the most beautiful and lonely rose you’ve ever seen. Not even your guardian could cultivate something as grand as this!\n\nEither the strings of destiny were pulled in your favor, or the alchemy used to reverse the corruption on the land caused this exceptional specimen to sprout. You decide that it would be a perfect gift for Abbadon, so you gently dig into the earth and extract the flower roots and all. Why let something this pretty wilt and decay when it could be replanted? When you return to Abbadon, "+ pronheshe +" is already dispatching "+ pronhisher +" servant when they turn to you. When you hold forth the plant, Abbadon’s face immediately bursts into a shade of scarlet.\n\n<i>“For me? It’s so exquisite and delicate! It’s much to early for these to be blooming…”<i> Abbadon doesn’t even mind the dirt on "+ pronhisher +" hands as "+ pronheshe +" inspects the rose, a warm smile stretching over their face. <i>“Thank you for extracting the whole plant "+ GameControl.playerName +", I know the perfect place for this…”<i> The last words are mumbled, but it is clear that "+ pronheshe +" is happy with the gesture.\n\nAbbadon’s smile doesn’t leave even after you two part ways. Upon returning to the castle, you find that your smile hasn’t left either.\n";
			return toReturn;
		} else {
			return "During one of your visits to Abbadon’s manor, you witness an incident where a maid ends up dropping a stack of several dishes. Abbadon is there in mere moments with a solid frown on "+ pronhisher +" face at the sight of the broken shards of dish wear. Throughout Abbadon’s disciplining you are surprised by how balanced "+ pronheshe +" is, remaining firm about how this accident should never have happened, yet fair when "+ pronheshe +" makes suggestions about how many plates the maids should carry at a time to avoid accident and injury. The poor girl apologizes for her mistake, promising to make up for the mistake as Abbadon only requests that the mess is cleaned up.\n\nThis is yet another example of Abbadon taking care of "+ pronhisher +" own people, "+ pronhisher +" youth being no handicap to taking care of matters professionally. You decide that Abbadon deserves to be commended for this, and during dinner when you two are alone, you praise "+ pronhimher +" for their tenacity and skill to handle the issues that pop up daily. You also suggest that you would be available to learn from "+ pronhisher +" methods.\n\nWhile "+ pronhisher +" face does take on a blush, you can see how Abbadon proudly puffs out "+ pronhisher +" chest with pride. <i>“I’m no stranger to discipline. After all, every heir to the title of Abbadon are brought up to be great leaders. I certainly have the capacity to teach you how to handle even the most rowdy servant or political opponent with utmost efficiency.\n\nThe next hour has Abbadon talking about "+ pronhisher +" methods of managing such a successful manor, and how some of these ideas could be applied to the kingdom. Although you somewhat question one of "+ pronhisher +" ideas of ‘sending them out to the forest with nothing but bindings on,’ "+ pronhisher +" attitude is almost overtly sweet towards you. You leave the manor on Abbadon’s good side, along with a wealth of "+ pronhisher +" wisdom.";
		}

	}


	string flirtLevel2(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum < 33) {
			toReturn = "Abbadon had sent "+ pronhisher +" fastest courier to you today. While you are immediately worried about an urgent matter, it turns out to be an invitation to a gathering. Apparently a fairly secretive group of playwrights have begun to host their events again, and that you are one of the selective few to be invited along with "+ pronhimher +". You accept the invitation, and the courier tells you that the event begins at dusk within the park before dashing off, presumably returning to the Abbadon manor.\n\nYou make sure to wear your favorite outfit before heading towards the park, a simple yet finely crafted royal garb adorned in the kingdom’s color palette. You arrive at the park and are immediately ushered by a costumed performer, your outfit speaking for itself and who wears it. You find a small performance stage had been assembled within the heart of the lush gardens, with many performers already practicing for the big act.\n\nIt doesn’t take you long to find Abbadon, who is seated on a bench fairly close to the front of the stage. You sit next to "+ pronhimher +" just as the event begins. The announcer informs the crowd that the story told tonight will be a love story that will both pull and tear at your heartstrings. Abbadon leans against you, idly sighing about how love stories are "+ pronhisher +" favorite.\n\nWhile the story is exceptional and quite romantic, it doesn’t hide the fact that the story is quite erotic, with many lewd undertones and plenty of on-stage nudity while managing to keep the show tasteful. In the middle of the second act, you can feel one of Abbadon’s hands snaking around your waist before "+ pronheshe +" snuggles close to you. <i>“It’s getting very cold, don’t you think "+ GameControl.playerName +"?”</i> You comment that the temperature has dropped since you’ve arrived, though you refuse to comment on how the nude performers are the worst off.\n\nAbbadon only presses closer by the third act, giving you an idea. During one of the slower scenes, you take Abbadon’s chin and twist "+ pronhimher +" to you, giving "+ pronhimher +" a surprise kiss on the lips. While "+ pronhisher +" eyes go wide, it is Abbadon that first pokes "+ pronhisher +" tongue through your lips. You can feel "+ pronhisher +" tongue explore your mouth, giving you a proper French kiss for a brief moment before moving back to resume watching the play.\n\nThe play continues into it’s final act, the surprise at the end shocking even Abbadon. "+ pronheshe +" is still gripped to you when the curtain call comes, only letting you go to applaud the wonderful performance. When the two of you walk back to "+ pronhisher +" manor, you end the manor with a last small peck and a few sweet words before departing for your home.";
			return toReturn;
		} else if (randNum < 66) {
			toReturn = "Abbadon looks quite different when you visit "+ pronhimher +" today. Instead of greeting you with relief, the only thing you receive is a very brief hello before Abbadon briskly ushers you inside, the path clearly set towards the living room. Once inside the room you are seated in Abbadon’s personal couch, which is considerably more fluffed than the one you usually sit in. "+ pronheshe +" joins you soon after, immediately spilling "+ pronhisher +" frustrations. Stubborn nobles and peasants at morn, bleak reports outside the walls at mid day, and just recently a report of how "+ pronhisher +" favorite tea will be hard to come by due to a fire burning a majority of the producer’s stock.\n\nYou lean over to Abbadon and give "+ pronhimher +" a hug, reassuring them that things will soon change for the better with you and "+ pronhimher +" in charge. <i>“I... thanks "+ GameControl.playerName +", I know you are right. While I may not feel it now, things are certain to change now that you are here.”</i> You play with Abbadon’s hair while "+ pronheshe +" leans on your chest, "+ pronhisher +" breathing slowing considerably while resting upon you. After about half an hour you worry that "+ pronheshe +" had fallen asleep on you before they suddenly pop up, giving you a quick peck.\n\n<i>“Thank you for coming "+ GameControl.playerName +". I know I may have wasted some of your time, but I really needed that rest.”<i> You lean forward and give "+ pronhimher +" a real kiss, to which "+ pronheshe +" happy answers in kind. After that you decide to stay for a few hours, accompanying Abbadon on "+ pronhisher +" meetings while cuddling "+ pronhimher +" in between sessions until dusk.";
			return toReturn;
		} else {
			return "The finest restaurant in the city has recently opened it’s doors to the public, and you find that it would be a perfect setting to invite Abbadon to. "+ pronheshe +" is almost jumping with excitement when you ask them to accompany you, remarking that "+ pronheshe +" will put on ‘the best dress in this entire kingdom!’ It takes an hour, but it is well worth the wait when you see Abbadon in an elegant blue dress, the bottom rippling like an ocean tide as "+ pronheshe +" walks towards you.\n\nYou’ve managed to reserved the entire third floor for tonight for just the two of you, a squad of staff at your beck and call. Being the ruler really does have it’s perks! Your mouth waters as each course of the meal only brings tastier and more exotic foods, some meats and desserts barely pronounceable nearing the end of the dinner. During the entire meal you and "+ pronhimher +" joke, tell stories and generally forget about the woes on the outside world. \n\nDuring one of the warmer moments of the night, you smoothly take "+ pronhisher +" hand into yours. Abbadon’s face turns red with sudden embarrassment, but says nothing and even holding your hand as well. After the meal, you accompany Abbadon back to "+ pronhisher +" manor. "+ pronheshe +" is still red from the restaurant, but manages to speak. <i>“Thanks "+ GameControl.playerName +", this time with you has been very pleasant, I’ll see you around.”</i> "+ pronheshe +" moves forward, pursing "+ pronhisher +" lips and offering them to you with closed eyes. You take Abbadon by the hips and embrace "+ pronhimher +", diving in and making your tongue dance with "+ pronhisher +"S. After a couple of minutes you finally move away, leaving Abbadon to wave with a hazy expression as you turn to walk back to the castle.\n";
		}

	}







	void relationshipChange(){
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime +2); 

		NPCCharList.CharFollower[iAbbadon].charRelationship += Random.Range (1.5f, 3f);
		NPCCharList.CharFollower[iAbbadon].charLoyalty += Random.Range (0.5f, 1.5f);
		NPCCharList.CharFollower[iAbbadon].charLove += Random.Range (1.5f, 5f);
		if (NPCCharList.CharFollower [iAbbadon].charRelationship > 100) {
			NPCCharList.CharFollower[iAbbadon].charRelationship = 100;
		} 
		if (NPCCharList.CharFollower [iAbbadon].charLoyalty > 100) {
			NPCCharList.CharFollower[iAbbadon].charLoyalty = 100;
		} 
		if (NPCCharList.CharFollower [iAbbadon].charLove > 100) {
			NPCCharList.CharFollower[iAbbadon].charLove = 100;
		} 


	}


	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		PanRelationship.sortingOrder = -500;
		PanEndTurn.sortingOrder = 500;
	}

	void loadAbbadon(){

		iAbbadon = 0;
		while (iAbbadon < NPCCharList.CharFollower.Count) {
			if (NPCCharList.CharFollower [iAbbadon].charID == 1000 ) {
				if (NPCCharList.CharFollower [iAbbadon].charGender == NPCData.CharGender.MALE) {
					pronheshe = "he";
					pronhisher = "his";
					pronhimher = "him";

				} else {
					pronheshe = "she";
					pronhisher = "her";
					pronhimher = "her";
				}
				break; 
			}

			iAbbadon++;
		}

	}



}
