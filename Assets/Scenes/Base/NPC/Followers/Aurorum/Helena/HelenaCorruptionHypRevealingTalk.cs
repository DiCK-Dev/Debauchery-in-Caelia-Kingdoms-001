using UnityEngine;
using System.Collections;
using UnityEngine.UI; 


public class HelenaCorruptionHypRevealingTalk : MonoBehaviour {

	int hashcode = GameControl.playerName.GetHashCode();
	float randNum;

	static int iHelena = 0;
	public Text Board; 

	public Canvas PanEndTurn; 

	public Canvas PanCorruptionHypno;

	public void hypnotismTalk(){

		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);

		loadHelena ();


		//difficulty 
		//float difficulty = NPCCharList.CharFollower[iHelena].attWillpower - (NPCCharList.CharFollower[iHelena].charCorruption*0.25f) - 50f - (GameControl.attHypnotism*0.8f);  
		//float difficulty = 5;

		/*if (GameControl.attHypnotism < 90) {
			randNum += 90; 
		}*/


		if(NPCCharList.CharFollower [iHelena].attWillpower == 0){
			if (GameControl.attHypnotism >= 30) {
				Board.text = "Although you have a fair knowledge about the art of hypnotism by now, Helena is still a great subject to keep honing your skills, since she’ll agree to be hypnotized, making her the perfect test subject. ";
			} else {
				Board.text = "You’re still new in the art of hypnotism, but since Helena will follow your orders no matter, making her agreeing to be hypnotized should be no challenge, which makes her the perfect test subject to keep learning your skill. ";
			}

			Board.text += "\n\nThe two of you are in the privacy of your study, and although you didn’t told her exactly what you are about to do, she is obediently following your orders, staying quiet and focus on your voice and the moving pendulum that’s in front of her face. \n\nIt doesn’t take much until she is under your control for the first time. After a couple of simple commands, just to make sure that this is working, you start to ask her questions about her past, secrets, among other revealing things. \n\nInteresting enough, by her answers you realize that there is something about her personality that’s been hidden, buried in her youth, a dominant personality that just needs the enough amount of fuel to grow.\n\nBut after trying to dig deeper on her you realize that to truly change her on this way you’ll need to corrupt her, and only then force her to do tasks like punishing servants until her current personality breaks away. \n\nHappy with the results, you finally snap your fingers and she comes back to normal, not knowing what just happened. ";
			NPCCharList.CharFollower [iHelena].attWillpower = 5;
			endTurnFun ();
			return;
		}

		if (NPCCharList.CharFollower [iHelena].attWillpower < 66) {
			Board.text = talkFeelingsSub ();
		} else {
			Board.text = talkFeelingsDom ();
		}

		Board.text += "\n\nFor now this is the only hypnotism scene for Helena for now.";

		endTurnFun ();

		/*
		//succeed
		if (randNum > difficulty) {
			corruptionChanges ();
			if (NPCCharList.CharFollower [iHelena].charCorruption < 33) {
				Board.text = talkLevel0 ();
			} else if (NPCCharList.CharFollower [iHelena].charCorruption < 66) {
				Board.text = talkLevel1 ();
			} else if (NPCCharList.CharFollower [iHelena].charCorruption < 100) {
				Board.text = talkLevel2 ();
			} else {
				Board.text = talkLevel3 ();
			}

		} else { //failure
			Board.text = failureLowCorr ();
		}*/

	}

	string talkFeelingsSub(){

		string P1 = "You order Helena into your chambers. Once she’s there you drive her once more under your control. It takes very little time; her feeble mind no match for your talents. \n\nIn this suggestive state, you order her to tell you how she feels about you. "; 
		string P2; 

		if (NPCCharList.CharFollower [iHelena].charRelationship < 0 && NPCCharList.CharFollower [iHelena].charLove <= 0) {
			P2 = "\n\n<i>“I am afraid of you. I don’t enjoy your presence, but I have no choice but to be obedient if I want to keep working here. I just hope you can improve your attitude.”</i> ";
		} else if (NPCCharList.CharFollower [iHelena].charRelationship < 0 && NPCCharList.CharFollower [iHelena].charLove > 0 && NPCCharList.CharFollower [iHelena].charLove < 50) {
			P2 = "\n\n<i>“I like many things about you, but you are far too harsh with me sometimes. It’s nothing that couldn’t be fixed however. If you were nicer to me I am sure things would be better for both of us...”</i>";
		} else if (NPCCharList.CharFollower [iHelena].charRelationship < 0 && NPCCharList.CharFollower [iHelena].charLove >= 50) {
			P2 = "\n\n<i>“I really love you, but you’ve been too harsh with me lately! Sometimes even though I know in my heart I love you, I fear you just as much…”</i> Helena spaces out for a moment, her conflicted mind trying to pull the strands of reality together again. <i>”I just want you to be nicer, I hope that’s not asking too much...”</i>\n\nHelena sounds sad despite her trance.";
		} else if (NPCCharList.CharFollower [iHelena].charRelationship >= 0 && NPCCharList.CharFollower [iHelena].charRelationship < 50 && NPCCharList.CharFollower [iHelena].charLove <= 0) {
			P2 = "\n\n<i>“I like working for you. You treat me nicely… at least better than many other rich people around the city would. There are things you could improve still, but I don’t really have any genuine complaints.”</i>";
		} else if (NPCCharList.CharFollower [iHelena].charRelationship >= 0 && NPCCharList.CharFollower [iHelena].charRelationship < 50 && NPCCharList.CharFollower [iHelena].charLove > 0 && NPCCharList.CharFollower [iHelena].charLove < 50) {
			P2 = "\n\n<i>“I like working for you and I think you are very nice...”</i> Helena spaces out for a moment, her face red with embarrassment even in this suggestive state. \n\n<i>“I think I like you... But I still need to know you more, and it’s not as though you would reciprocate the feelings of a poor servant anyway…”</i>";
		} else if (NPCCharList.CharFollower [iHelena].charRelationship >= 0 && NPCCharList.CharFollower [iHelena].charRelationship < 50 && NPCCharList.CharFollower [iHelena].charLove > 50) {
			P2 = "\n\n<i>“I really like you!”</i> she says, her face red and shy. <i>“But... But I don’t think the feeling is mutual, at least you haven’t been nice to me in a while, I think we need to get closer and know each other better... It would be like a dream come true if we were together.”</i>";
		} else if (NPCCharList.CharFollower [iHelena].charRelationship >= 50 && NPCCharList.CharFollower [iHelena].charLove <= 0) {
			P2 = "\n\n<i>“You’ve been very nice to me and I really appreciate it. You are more than a boss to me… You are a friend, and I truly care for what will happen to you and your kingdom.”</i>";
		} else if (NPCCharList.CharFollower [iHelena].charRelationship >= 50 && NPCCharList.CharFollower [iHelena].charLove > 0 && NPCCharList.CharFollower [iHelena].charLove < 50) {
			P2 = "\n\n<i>“You are always very nice and kind to me and my feelings to you keep growing day by day. I hope the two of us feel the same way and maybe... one day... be more than a servant to you...”</i>";
		} else if (NPCCharList.CharFollower [iHelena].charRelationship >= 50 && NPCCharList.CharFollower [iHelena].charLove >= 50) {
			P2 = "\n\nHelena’s face blushes unconsciously <i>“Y-You know I’m in love with you "+ GameControl.playerName +"... I think it’s pretty obvious. I can’t add much else to this except that I am truly happy when I’m serving you… in any way I can.”</i>";
		} else {
			P2 = "\n\nThis is a bug report it!";
		}

		string P3 = "\n\nAfter she is done, you command her to forget about the meeting you two had today.";
		return P1 + P2 + P3;
	}

	string talkFeelingsDom(){

		string P1 = "You manage to bring Helena into your chamber and put her into a trance. It took a lot longer and far more effort to break the strong mind she has developed.\n\nIn this suggestive state, you order her to tell you how she feels about you. "; 
		string P2; 

		if (NPCCharList.CharFollower [iHelena].charRelationship < 0 && NPCCharList.CharFollower [iHelena].charLove <= 0) {
			P2 = "\n\n<i>“You are a pathetic loser, I would get rid of you if I legally could. For now you are nothing but a figurehead kept for necessity.”</i> ";
		} else if (NPCCharList.CharFollower [iHelena].charRelationship < 0 && NPCCharList.CharFollower [iHelena].charLove > 0 && NPCCharList.CharFollower [iHelena].charLove < 50) {
			P2 = "\n\n<i>“You have some features that I enjoy or find amusing. I could care less about your personal life however. Perhaps if you showed a little more effort, and treated me with the respect I deserved I would care a little.”</i>";
		} else if (NPCCharList.CharFollower [iHelena].charRelationship < 0 && NPCCharList.CharFollower [iHelena].charLove >= 50) {
			P2 = "\n\n<i>“You have so many qualities that I appreciate and like, but you are a stranger to me. I despise strangers.You need to make up for being an ass with me and maybe then I will give you some amount of respect. Even if you deserve very little.”</i>";
		} else if (NPCCharList.CharFollower [iHelena].charRelationship >= 0 && NPCCharList.CharFollower [iHelena].charRelationship < 50 && NPCCharList.CharFollower [iHelena].charLove <= 0) {
			P2 = "\n\n<i>“You are a fine servant... Respectful enough I suppose, but I don’t care much beyond that.”</i>";
		} else if (NPCCharList.CharFollower [iHelena].charRelationship >= 0 && NPCCharList.CharFollower [iHelena].charRelationship < 50 && NPCCharList.CharFollower [iHelena].charLove > 0 && NPCCharList.CharFollower [iHelena].charLove < 50) {
			P2 = "\n\n<i>“You are a fine servant. You are both respectful and somewhat interesting, but I don’t care much beyond that. Maybe you can prove to be more interesting in the future. If so, maybe I will notice you, but until then you aren’t anything other than a necessary figurehead whose presence I tolerate.”</i>";
		} else if (NPCCharList.CharFollower [iHelena].charRelationship >= 0 && NPCCharList.CharFollower [iHelena].charRelationship < 50 && NPCCharList.CharFollower [iHelena].charLove > 50) {
			P2 = "\n\n<i>“You are truly amusing and interesting to me, and you are respectful enough to tolerate, but you still need to work on your obedience to me.”</i>\n";
		} else if (NPCCharList.CharFollower [iHelena].charRelationship >= 50 && NPCCharList.CharFollower [iHelena].charLove <= 0) {
			P2 = "\n\n<i>“A faithful and obedient servant. I appreciate that, but I have no personal interest in you.”</i>";
		} else if (NPCCharList.CharFollower [iHelena].charRelationship >= 50 && NPCCharList.CharFollower [iHelena].charLove > 0 && NPCCharList.CharFollower [iHelena].charLove < 50) {
			P2 = "\n\n<i>“You are always very nice and kind to me and my feelings for you grow day by day. I hope the two of us feel the same way and maybe... one day... be more than a servant to you...”</i>\n\n<i>“A faithful and obedient servant. I appreciate that... and although I hesitate to add I find you amusing and interesting at times, I lack any strong feelings about you one way or the other.”</i>\n\n";
		} else if (NPCCharList.CharFollower [iHelena].charRelationship >= 50 && NPCCharList.CharFollower [iHelena].charLove >= 50) {
			P2 = "\n\n<i>“A servant that’s faithful in every way.”</i> although Helena’s composure doesn’t shift even a hair’s breadth, her cheeks turn a deep red, hinting at some inner monologue. <i>“I guess you are okay to keep around.”</i>\n";
		} else {
			P2 = "\n\nThis is a bug report it!";
		}

		string P3 = "\n\nAfter she is done, you command her to forget about the meeting the two of you had today. ";
		return P1 + P2 + P3;
	}

	string talkLevel0 (){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum < 33) {
			toReturn = "";
			if (NPCCharList.CharFollower [iHelena].dickSizeCM > 0) {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			} else {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			}
			toReturn += "\n\n";
			return toReturn;
		} else if (randNum < 66) {
			toReturn = "";
			if (NPCCharList.CharFollower [iHelena].dickSizeCM > 0) {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			} else {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			}
			toReturn += "\n\n";
			return toReturn;
		} else {
			toReturn = "";
			if (NPCCharList.CharFollower [iHelena].dickSizeCM > 0) {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			} else {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			}
			toReturn += "\n\n";
			return toReturn;
		}

	}






	string talkLevel1 (){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum < 33) {
			toReturn = "";
			if (NPCCharList.CharFollower [iHelena].dickSizeCM > 0) {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			} else {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			}
			toReturn += "\n\n";
			return toReturn;
		} else if (randNum < 66) {
			toReturn = "";
			if (NPCCharList.CharFollower [iHelena].dickSizeCM > 0) {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			} else {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			}
			toReturn += "\n\n";
			return toReturn;
		} else {
			toReturn = "";
			if (NPCCharList.CharFollower [iHelena].dickSizeCM > 0) {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			} else {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			}
			toReturn += "\n\n";
			return toReturn;
		}

	}

	string talkLevel2 (){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum < 33) {
			toReturn = "";
			if (NPCCharList.CharFollower [iHelena].dickSizeCM > 0) {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			} else {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			}
			toReturn += "\n\n";
			return toReturn;
		} else if (randNum < 66) {
			toReturn = "";
			if (NPCCharList.CharFollower [iHelena].dickSizeCM > 0) {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			} else {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			}
			toReturn += "\n\n";
			return toReturn;
		} else {
			toReturn = "";
			if (NPCCharList.CharFollower [iHelena].dickSizeCM > 0) {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			} else {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			}
			toReturn += "\n\n";
			return toReturn;
		}

	}

	string talkLevel3 (){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum < 33) {
			toReturn = "";
			if (NPCCharList.CharFollower [iHelena].dickSizeCM > 0) {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			} else {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			}
			toReturn += "\n\n";
			return toReturn;
		} else if (randNum < 66) {
			toReturn = "";
			if (NPCCharList.CharFollower [iHelena].dickSizeCM > 0) {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			} else {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			}
			toReturn += "\n\n";
			return toReturn;
		} else {
			toReturn = "";
			if (NPCCharList.CharFollower [iHelena].dickSizeCM > 0) {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			} else {
				toReturn += "\n\n";
				if (GameControl.dick1Size> 0) {
					toReturn += "\n\n";
				} else {
					toReturn += "\n\n";
				}
			}
			toReturn += "\n\n";
			return toReturn;
		}

	}


	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		PanCorruptionHypno.sortingOrder = -500;
		PanEndTurn.sortingOrder = 500;
	}


	string failureLowCorr(){
		string toReturn = "";
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum < 33) {
			return " ";
		} else if (randNum < 66) {
			return " ";
		} else {
			return " ";
		}
	}

	void corruptionChanges(){
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime +2); 

		NPCCharList.CharFollower[iHelena].charCorruption += Random.Range (0f, 1.5f);
		NPCCharList.CharFollower[iHelena].charRelationship += Random.Range (0.5f, 1.5f);
		NPCCharList.CharFollower[iHelena].charLoyalty += Random.Range (0.5f, 1.5f);

		if (NPCCharList.CharFollower [iHelena].charCorruption < 80) {
			GameControl.charCorruption += Random.Range (0f, 1.5f);

		} else {
			GameControl.charCorruption += Random.Range (0.5f, 2f);

		}

		if (GameControl.attHypnotism < 20) {
			GameControl.attHypnotism += Random.Range (2f, 6f);
		} else if (GameControl.attHypnotism < 50) {
			GameControl.attHypnotism += Random.Range (0.5f, 1.5f);
		}

	}



	void loadHelena(){

		iHelena = 0;
		while (iHelena < NPCCharList.CharFollower.Count) {
			if (NPCCharList.CharFollower [iHelena].charID == 1000 ) {
				break; 
			}

			iHelena++;
		}

	}



}
