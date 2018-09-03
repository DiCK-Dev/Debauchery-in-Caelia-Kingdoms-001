using UnityEngine;
using System.Collections;

public class EvidenceCreator : MonoBehaviour {
	int hashcode; 
	int randNum; 
	int i; 
	string evidence = "";

	public string inquisitionEvidenceCreator(int isel){
		i = isel;

		hashcode = GameControl.playerName.GetHashCode (); 
	

		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 783); 
		randNum = Random.Range (0, 100);

		if (randNum > 66) {
			evidenceFetish ();
		} else if (randNum > 33) {
			evidenceTrait2 ();
		} else {
			evidenceTrait1 ();
		}





		if (evidence == "") {
			evidence = "Basic evidence - Report as bug please! line 32 EvidenceCreator.cs";
		}

		return evidence; 
	}

	//////////////////////////////////////////////////////////////////////////////////////////////////////

	void evidenceTrait1(){
		/*
		evidence = "";
		hashcode = GameControl.playerName.GetHashCode (); 
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 836); 
		randNum = Random.Range (0, 100);

		int x = 0;

		while (x < 15)
		{
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 836 + x); 
			randNum = Random.Range (0, 15);
			switch(x)
			{
			case 0:
				
				if (NPCCharList.CharList [i].charTrait1 == 2)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 3);
					switch(randNum){
					case 0:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " before it's vows of celibacy was a complete whore, recognized for it's sucking skills in it's natal town.";
						break;
					case 1:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " before it's vows of celibacy was a complete whore, recognized for it's anal skills in it's natal town.";
						break;
					case 2:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " before it's vows of celibacy was a complete whore, recognized for slutting with married people in it's natal town.";
						break;
					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " before it's vows of celibacy was a complete whore, recognized for it's handjobs skills in it's natal town.";
						break;
					}
				
				}
				break;

			case 1:
				if (NPCCharList.CharList [i].charTrait1 == 3)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " practices black magic in private. ";
						break;
					case 1:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " practices white magic in private. ";
						break;
					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " practices black magic in private. ";
						break;
					}

				}
				break;

			case 2:
				if (NPCCharList.CharList [i].charTrait1 == 4) {
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch (randNum) {
					case 0:
						evidence = "The file says that " + NPCCharList.CharList [i].charName + " killed by mistake someone in a non lethal duel. ";
						break;
					case 1:
						evidence = "The file says that " + NPCCharList.CharList [i].charName + " killed someone in cold blood in a non lethal duel. ";
						break;
					default:
						evidence = "The file says that even if " + NPCCharList.CharList [i].charName + " has a great record as a duelist, it's been found that it has escaped some of them, such a coward! ";
						break;
					}

				}
				break;
			case 3:
				if (NPCCharList.CharList [i].charTrait1 == 5)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " has a fame of impaling it's enemies!  ";
						break;
					case 1:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " has a fame of impaling innocents after a battle, such a monster!  ";
						break;
					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " has a fame of impaling only people from other races than it's own, such a monster!  ";
						break;
	
					}

				}
				break;
			case 4:
				if (NPCCharList.CharList [i].charTrait1 == 6)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 3);
					switch(randNum){
					case 0:
						evidence = "The file says that beyond "  +  NPCCharList.CharList[i].charName + " fame of being a diligent person, it has some driking habits that make are problematic.   ";
						break;
					case 1:
						evidence = "The file says that beyond "  +  NPCCharList.CharList[i].charName + " fame of being a diligent person, it actually takes the credit from others.";
						break;
					default:
						evidence = "The file says that beyond "  +  NPCCharList.CharList[i].charName + " fame of being a diligent person, it actually takes the credit from others.";
						break;

					}

				}
				break;

			case 5:
				if (NPCCharList.CharList [i].charTrait1 == 1)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " is not as vigorous in the bed as people may think... ";
						break;
					case 1:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " is not as potent in the bed as people may think... ";
						break;

					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " is not as good in the bed as people may think... ";
						break;
					}

				}
				break;
			case 6:
				if (NPCCharList.CharList [i].charTrait1 == 0)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " uses it's genius for pervert purposes too. ";
						break;
					case 1:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " experimented with people when it was young. ";
						break;

					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " experimented with animals when it was young. ";
						break;
					}

				}
				break;

			case 7:
				if (NPCCharList.CharList [i].charTrait1 == 7)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " is only disciplined in parades and in front of officers, but in reality it's all just pretend.";
						break;
					case 1:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " was forced by it's parents to be disciplined after it failed school several times.";
						break;
					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " a bottle of booze makes it undisciplined very fast.";
						break;
					}

				}
				break;
			case 8:
				if (NPCCharList.CharList [i].charTrait1 == 8)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 3);
					switch(randNum){
					case 0:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " this person is only humble in public, in private it loves to brag about it's deeds.";
						break;
					case 1:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " this person learned to be humble only after losing a fortune for bragging on it's gambling skills.";
						break;
					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " this person is only humble in public, in private it loves to brag about it's deeds.";
						break;
					}

				}
				break;
			case 9:
				if (NPCCharList.CharList [i].charTrait1 == 9)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " it's not so honest when it talks about it's savings... ";
						break;
					case 1:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " it's not so honest when is about it sexual prowesss... ";
						break;
					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " it's not so honest about it's dirty past. ";
						break;
					}

				}
				break;
			case 10:
				if (NPCCharList.CharList [i].charTrait1 == 10)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " has earned it's fame of brave just by braving and fake stories about it's deeds. ";
						break;
					case 1:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " the stories about it's bravery in the 10 years war are, in fact, all fake. ";
						break;
					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " the stories about it hunting monsters are, in fact, all fake. ";
						break;
					}

				}
				break;
			case 11:
				if (NPCCharList.CharList [i].charTrait1 == 11)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " is not the great lover most people think it is. ";
						break;
					case 1:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " actually was a virgin until a couple of years ago.";
						break;
					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " is an awful lover. ";
						break;

					}

				}
				break;
			case 12:
				if (NPCCharList.CharList [i].charTrait1 == 12)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " is only efficient when is about managing it's booze... ";
						break;
					case 1:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " always move some money to a sleazy special fund. ";
						break;
					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " hates charity, and always try to move money away from those institutions. ";
						break;

					}

				}
				break;
			case 13:
				if (NPCCharList.CharList [i].charTrait1 == 13)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 3);
					switch(randNum){
					case 0:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " even if it has a fame of great strategist, it has more loses than victories in it's real record.  ";
						break;
					case 1:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " has no regard about the life of the soldiers under it's command.  ";
						break;
					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " has no regard about civilian casualties.  ";
						break;

					}

				}
				break;
			case 14:
				if (NPCCharList.CharList [i].charTrait1 == 14)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 3);
					switch(randNum){
					case 0:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " has studied heretic texts!  ";
						break;
					case 1:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " has preached heresy! ";
						break;
					case 2:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " has tried to invoke demons! ";
						break;
					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " does not actually believe in the gods anymore! ";
						break;
					}

				}
				break;

			default:
				evidence = "Failed to generate evidence, line 360 in EvidenceCreator.cs, evidenceTrait1();, report as bug.";
				break; 



			}

			if (evidence != "") {
				break;
			}

			x++;

		}
		*/
	}


	//////////////////////////////////////////////////////////////////////////////////////////////////////
	void evidenceTrait2(){
		/*

		evidence = "";
		hashcode = GameControl.playerName.GetHashCode (); 
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 836); 
		randNum = Random.Range (0, 100);

		int x = 0;

		while (x < 15)
		{
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 836 + x); 
			randNum = Random.Range (0, 15);
			switch(x)
			{
			case 0:
				if (NPCCharList.CharList [i].charTrait2 == 2)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 3);
					switch(randNum){
					case 0:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " before it's vows of celibacy was a complete whore, recognized for it's sucking skills in it's natal town.";
						break;
					case 1:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " before it's vows of celibacy was a complete whore, recognized for it's anal skills in it's natal town.";
						break;
					case 2:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " before it's vows of celibacy was a complete whore, recognized for slutting with married people in it's natal town.";
						break;
					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " before it's vows of celibacy was a complete whore, recognized for it's handjobs skills in it's natal town.";
						break;
					}

				}
				break;

			case 1:
				if (NPCCharList.CharList [i].charTrait2 == 3)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " practices black magic in private. ";
						break;
					case 1:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " practices white magic in private. ";
						break;
					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " practices black magic in private. ";
						break;
					}

				}
				break;

			case 2:
				if (NPCCharList.CharList [i].charTrait2 == 4) {
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch (randNum) {
					case 0:
						evidence = "The file says that " + NPCCharList.CharList [i].charName + " killed by mistake someone in a non lethal duel. ";
						break;
					case 1:
						evidence = "The file says that " + NPCCharList.CharList [i].charName + " killed someone in cold blood in a non lethal duel. ";
						break;
					default:
						evidence = "The file says that even if " + NPCCharList.CharList [i].charName + " has a great record as a duelist, it's been found that it has escaped some of them, such a coward! ";
						break;
					}

				}
				break;
			case 3:
				if (NPCCharList.CharList [i].charTrait2 == 5)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " has a fame of impaling it's enemies!  ";
						break;
					case 1:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " has a fame of impaling innocents after a battle, such a monster!  ";
						break;
					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " has a fame of impaling only people from other races than it's own, such a monster!  ";
						break;

					}

				}
				break;
			case 4:
				if (NPCCharList.CharList [i].charTrait2 == 6)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 3);
					switch(randNum){
					case 0:
						evidence = "The file says that beyond "  +  NPCCharList.CharList[i].charName + " fame of being a diligent person, it has some driking habits that make are problematic.   ";
						break;
					case 1:
						evidence = "The file says that beyond "  +  NPCCharList.CharList[i].charName + " fame of being a diligent person, it actually takes the credit from others.";
						break;
					default:
						evidence = "The file says that beyond "  +  NPCCharList.CharList[i].charName + " fame of being a diligent person, it actually takes the credit from others.";
						break;

					}

				}
				break;

			case 5:
				if (NPCCharList.CharList [i].charTrait2 == 1)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " is not as vigorous in the bed as people may think... ";
						break;
					case 1:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " is not as potent in the bed as people may think... ";
						break;

					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " is not as good in the bed as people may think... ";
						break;
					}

				}
				break;
			case 6:
				if (NPCCharList.CharList [i].charTrait2 == 0)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " uses it's genius for pervert purposes too. ";
						break;
					case 1:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " experimented with people when it was young. ";
						break;

					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " experimented with animals when it was young. ";
						break;
					}

				}
				break;

			case 7:
				if (NPCCharList.CharList [i].charTrait2 == 7)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " is only disciplined in parades and in front of officers, but in reality it's all just pretend.";
						break;
					case 1:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " was forced by it's parents to be disciplined after it failed school several times.";
						break;
					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " a bottle of booze makes it undisciplined very fast.";
						break;
					}

				}
				break;
			case 8:
				if (NPCCharList.CharList [i].charTrait2 == 8)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 3);
					switch(randNum){
					case 0:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " this person is only humble in public, in private it loves to brag about it's deeds.";
						break;
					case 1:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " this person learned to be humble only after losing a fortune for bragging on it's gambling skills.";
						break;
					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " this person is only humble in public, in private it loves to brag about it's deeds.";
						break;
					}

				}
				break;
			case 9:
				if (NPCCharList.CharList [i].charTrait2 == 9)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " it's not so honest when it talks about it's savings... ";
						break;
					case 1:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " it's not so honest when is about it sexual prowesss... ";
						break;
					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " it's not so honest about it's dirty past. ";
						break;
					}

				}
				break;
			case 10:
				if (NPCCharList.CharList [i].charTrait2 == 10)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " has earned it's fame of brave just by braving and fake stories about it's deeds. ";
						break;
					case 1:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " the stories about it's bravery in the 10 years war are, in fact, all fake. ";
						break;
					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " the stories about it hunting monsters are, in fact, all fake. ";
						break;
					}

				}
				break;
			case 11:
				if (NPCCharList.CharList [i].charTrait2 == 11)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " is not the great lover most people think it is. ";
						break;
					case 1:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " actually was a virgin until a couple of years ago.";
						break;
					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " is an awful lover. ";
						break;

					}

				}
				break;
			case 12:
				if (NPCCharList.CharList [i].charTrait2 == 12)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " is only efficient when is about managing it's booze... ";
						break;
					case 1:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " always move some money to a sleazy special fund. ";
						break;
					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " hates charity, and always try to move money away from those institutions. ";
						break;

					}

				}
				break;
			case 13:
				if (NPCCharList.CharList [i].charTrait2 == 13)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 3);
					switch(randNum){
					case 0:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " even if it has a fame of great strategist, it has more loses than victories in it's real record.  ";
						break;
					case 1:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " has no regard about the life of the soldiers under it's command.  ";
						break;
					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " has no regard about civilian casualties.  ";
						break;

					}

				}
				break;
			case 14:
				if (NPCCharList.CharList [i].charTrait2 == 14)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 3);
					switch(randNum){
					case 0:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " has studied heretic texts!  ";
						break;
					case 1:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " has preached heresy! ";
						break;
					case 2:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " has tried to invoke demons! ";
						break;
					default:
						evidence = "The file says that "  +  NPCCharList.CharList[i].charName + " does not actually believe in the gods anymore! ";
						break;
					}

				}
				break;

			default:
				evidence = "Evidence generator failed, line 697, evidenceTrait2(); at EvidenceGenerator.cs";
				break; 



			}

			if (evidence != "") {
				break;
			}

			x++;

		}

		*/
	}

	void evidenceFetish(){
		/*
		evidence = "";
		hashcode = GameControl.playerName.GetHashCode (); 

		int x = 0;

		while (x < 11)
		{
			switch(x)
			{
			case 0:
				if (NPCCharList.CharList [i].charFetishID == 0)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " is dominant, and likes to abuse of anyone who shows a weak character.";
						break;
					case 1:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " is dominant tendencies make it an abusive person to it's underlings.";
						break;
					default:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " is dominant, and likes to abuse of those who are weaker than it.";
						break;
					}

				}
				break;

			case 1:
				if (NPCCharList.CharList [i].charFetishID == 1)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " is submissive, and it likes to be abused by anyone who shows a strong character.";
						break;
					case 1:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " has submissive tendencies, and it loves to be abused by strong willed characters. ";
						break;
					default:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " is submissive, and it loves to be bossed around.";
						break;
					}

				}
				break;

			case 2:
				if (NPCCharList.CharList [i].charFetishID == 2)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " is an anal whore, and is pretty known in it native town by it's skills.";
						break;
					case 1:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " is an anal whore, and it has been seen with things up it ass in public places. ";
						break;
					default:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " is an anal whore, and it visit glory holes to use it every night.";
						break;
					}

				}
				break;
			case 3:
				if (NPCCharList.CharList [i].charFetishID == 3)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " is into group sex, and is pretty known in it native town for organizing orgies.";
						break;
					case 1:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " is into group sex, and witness say it loves to have all it holes full at the same time. ";
						break;
					default:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " is into group sex, specifically bukkake's. Seem like it loves to bath in cum frequently.";
						break;
					}

				}
				break;
			case 4:
				if (NPCCharList.CharList [i].charFetishID == 4)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " is a cumslut, and that it usually adds a dose of jizz to it's early coffee every day.";
						break;
					case 1:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " is a cumslut, and it's been reported that this person had a taste of pretty much every dick in it's native town. ";
						break;
					default:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " is a cumslut, and it's been reported that it visits glory holes every night to have it's dinner. ";
						break;
					}

				}
				break;

			case 5:
				if (NPCCharList.CharList [i].charFetishID == 5)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " is incestous, and it is known in it native town by the orgies that it family had.";
						break;
					case 1:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " is incestous, and it used to have it's way with it's brothers and sisters back in it's native town. ";
						break;
					default:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " is incestous, and it's been reported that it had it's way with it's mother every so often. ";
						break;
					}

				}
				break;
			case 6:
				if (NPCCharList.CharList [i].charFetishID == 6)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " is a crossdresser, and it loves to go to sex parties doing this.";
						break;
					case 1:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " is a crossdresser, and it loves to visit pub's and taverns while crossdressing.";
						break;
					default:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " is a crossdresser, and it loves to entice people at public places. ";
						break;
					}

				}
				break;

			case 7:

				if (NPCCharList.CharList [i].charFetishID == 7)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " is an exhibitionist, and it loves to flash people at the park at night.";
						break;
					case 1:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " is an exhibitionist, and it loves to flash people at tpub's and taverns.";
						break;
					default:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " is an exhibitionist, and it loves to flash restaurants and locals from the street. ";
						break;
					}

				}
				break;

			case 8:
				if (NPCCharList.CharList [i].charFetishID == 8)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " loves pet play, and it loves to act like a bitch.";
						break;
					case 1:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " loves pet play, and it loves to act like a horse.";
						break;
					default:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " loves pet play, and it loves to act like a cat. ";
						break;
					}

				}
				break;
			case 9:
				if (NPCCharList.CharList [i].charFetishID == 9)
				{
					Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond * 366 + x); 
					randNum = Random.Range (0, 2);
					switch(randNum){
					case 0:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " has rape fantasies, and it loves to walk through dark alleys during the night, hoping...";
						break;
					case 1:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " has rape fantasies, and it loves to walk with skimpy clothes during the night through the park, hoping...";
						break;
					default:
						evidence = "The file says that " +  NPCCharList.CharList[i].charName + " has rape fantasies, and it loves to walk with skimpy clothes during the night through the park, hoping...";
						break;
					}

				}
				break;
			

			default:
				evidence = "Report bug, line 927, evidenceFetish() in EvidenceCreator.cs";
				break; 



			}

			if (evidence != "") {
				break;
			}

			x++;

		}

		*/
	}

	void evidenceAdultBackground(){


	}

	void evidenceChildhoodBackground(){


	}




}
