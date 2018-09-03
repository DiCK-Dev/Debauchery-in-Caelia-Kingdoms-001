using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HelenaHangout : MonoBehaviour {
	int hashcode = GameControl.playerName.GetHashCode();
	float randNum;

	static int iHelena = 0;
	public Text Board; 

	public Canvas PanHangout;
	public Canvas PanEndTurn; 


	public void hangOut(){


		loadHelena ();



		relationshipChange ();

		if (NPCCharList.CharFollower [iHelena].charRelationship < 33) {
			Board.text = hangoutLevel1();
		} else if (NPCCharList.CharFollower [iHelena].charRelationship < 50) {
			Board.text = hangoutLevel1();
		} else  {
			if (NPCCharList.CharFollower [iHelena].attWillpower < 66) {
				Board.text = hangoutLevel2 ();
			} else {
				Board.text = hangoutLevel1();
			}
		}


		endTurnFun ();

	}


	string hangoutLevel0(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (NPCCharList.CharFollower [iHelena].attWillpower >= 66) {
			if (randNum < 33) {
				toReturn = "";
				if (NPCCharList.CharFollower [iHelena].dickSize > 0) {
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
				toReturn = "";
				if (NPCCharList.CharFollower [iHelena].dickSize > 0) {
					toReturn += "";
				} else {
					toReturn += "";
				}
				toReturn += "";
				return toReturn;
			}
		} else {
			if (randNum < 33) {
				toReturn = "";
				if (NPCCharList.CharFollower [iHelena].dickSize > 0) {
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
				toReturn = "";
				if (NPCCharList.CharFollower [iHelena].dickSize > 0) {
					toReturn += "";
				} else {
					toReturn += "";
				}
				toReturn += "";
				return toReturn;
			}
		}
	}



	string hangoutLevel1(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (NPCCharList.CharFollower [iHelena].attWillpower >= 66) {
			if (randNum < 25) {
				toReturn = "You’ve been working hard for Helena, to the point you almost never have free time for yourself or anything else, but today she has been kind enough to give you some free time to spare with her.\n\n<i>“You’ll sit there and listen, I don’t care about what you think or want to say.”</i> after her orders, she starts to talk mostly to herself about things that anger her. Apparently having you around just means she gets to vent and rant to someone instead of being alone in your room.\n\nAfter many tangents and petty complains, she starts to talk about more intimate matters <i>“...And my family! Those old farts that never believed in me! You’ll never understand how much I despise them. If it weren’t for them, I probably would had been like this from the very beginning”</i>\n\nShe makes it clear that deep inside she has always had a bad relationship with them, since they had always forbid her from doing anything beyond domestic tasks.\n\nAfter the lengthy rant, she seems to have had enough talk for today.  \n\n<i>“Well, that’ll be all for today  "+ GameControl.playerName +", you can go and take the rest of the day off.”</i> she dismisses you without even thanking you, but her opening up to you is evidence that she is starting to trust you more.";
				WorldControl.dayTime = 5;
				if (NPCCharList.CharFollower [iHelena].dickSize > 0) {
					toReturn += "";
				} else {
					toReturn += "";
				}
				toReturn += "";
				return toReturn;
			} else if (randNum < 50) {
				toReturn = "Today Helena’s fed up with dealing with the subjects. A few are even sent to the dungeons.\n\n<i>“All these idiots, still complaining that the city is not like it used to be before the outbreak. Why they cant embrace the present and look to the future? I’m tired of them all.”</i>\n\nShe asks you to bring her wine, and once you served her orders you to serve some to yourself too. \n\n<i>“Life before the outbreak... What is it that they are even missing? Those years were even worse. All of them were just as poor. Maybe they miss living in an overcrowded city, or going to work their ass off to work the land without receiving even a gold coin a day. Or maybe it’s just that they want to keep living prude and boring lives? Nonetheless, I can’t see the appeal in looking back.”</i>\n\nAlthough daring, you ask her if there is nothing she misses from that time. \n\n<i>“Fuck no! Which kind of stupid question is that? I was no one and was destined to be no one for the rest of my life. Now with everything around them crumbling there are plenty of opportunities to raise up, but they are too incompetent or </i>weak<i> to realize that.”</i>\n\nShe sighs, clearly exhausted with the idea of being surrounded with people like that. \n\n<i>“At least you are not like them. For that matter, it’s thanks to you that I dared to use all my potential. Maybe I should give you a small reward for that. What do you think, would you like that?”</i>\n\nYou nod at her, happy for the kindness. <i>“Such a good pet. Very well, I’ll figure out later what you deserve for helping me out.”</i>\n\nShe ends up giving you a break and a proper meal; it seems your relationship with her has improved.";
				WorldControl.dayTime = 5;
				if (GameControl.dick1Size > 0) {
					toReturn += "";
				} else {
					toReturn += "";
				}

				toReturn += "";			
				return toReturn;
			} else if (randNum < 75) {
				toReturn = "One of the many uses Helena has for you is to be her company when she wants to rant about something, either about the problems she has to face with the kingdom or her personal history.\n\n<i>“Everyone complains as if they were the only ones to live through hell during the outbreak. I barely fucking survived by eating crumbs for months, I know how it was.”</i>\n\nShe keeps complaining about how ungrateful everyone is, even if things have improved so much.\n\n<i>“No wonder you couldn’t handle it, someone as weak as yourself don’t have the willpower to deal with so many dip shits.”</i> \n\nShe shakes her head and you can see how she becomes even more enraged <i>“They didn’t have to live with your useless uncle, someone who used everyone around him. He never said thanks a single time while I was working for him. And if he had any redeeming quality, I am unaware of it. Lazy, dumb, greedy and lustful are the first words that come to my mind when thinking about him, and I had to serve him for years.”</i>\n\nAfter going on length about the sins of your uncle, she finally vents all her rage, returning to her normal (albeit scary) mood. \n\n<i>“Well, that felt good, but now is time to get back to work. I’ll let you have dessert today for being so attentive.”</i>\n\nAlthough she always acts tough, you know that your bond with her has become stronger.";
				if (NPCCharList.CharFollower [iHelena].dickSize > 0) {
					toReturn += "";
				} else {
					toReturn += "";
				}
				toReturn += "";
				return toReturn;

			}else {
				toReturn = "You’ve been helping Helena to take care of the kingdom today. Since her changes, you’ve become the closest ally she has. Even if the only reason she still needs you around is to sign your name on the dotted lines. Or so she says, at least. Even if it’s subtle, there’s the occasional proof that she’s fond of you.\n\nToday is one of those days where she allows you to sit at her side at the table, enjoying a feast with her.\n\nIn a cheerful mood, something not seen often nowadays. She is remembering these last months, and all the good things that have come thanks to you and her. <i>“People here won’t appreciate it, but we together have changed many things, and will keep bringing more change in the future.”</i>\n\n<i>“I never knew when I was a child that I was destined for grandness, but when you opened my eyes I realized that all that curiosity, excitement and will to learn and improve had to paid off in the end. I’m happy with what you’ve done for me, and that’s why I allow you today to share this meal with me.”</i>\n\nShe starts to share anecdotes and stories about the recent past, snickering about how dumb and naive she was at the beginning. \n\nWhen the dinner is over you feel that the relationship that you have with her has significantly improved. ";
				WorldControl.dayTime = 5;
				if (NPCCharList.CharFollower [iHelena].dickSize > 0) {
					toReturn += "";
				} else {
					toReturn += "";
				}
				toReturn += "";
				return toReturn;
			}
		} else {
			if (randNum < 25) {
				toReturn = "Helena’s always working hard for you, to the point that she almost never takes a break. Today you decided to give her the day off and invite her to go to the city with you to relax and enjoy the day. \n\nAlthough everything is going fine she still doesn’t appear to see you as a close friend. The both of you take a couple of seats in a local coffee shop, drinking the hot beverage while waiting for food. \n\nThe conversation at first is very boring, just a daily report of her activities and news about the castle. To get closer to her, you decide to ask her about her family, just to tell you something about them. \n\n<i>“About my family?... I don't think there is much to tell. I don’t have any brothers or sisters. My mother was a servant for your late uncle too. Actually it was thanks to her that I ended up working for him too. My father was the assistant of a blacksmith.”</i>\n\nShe continues to talk about them with very basic and superficial information that doesn’t explains how was her relationship with them or any interesting or revealing detail. You would like to know more about that, but you realize that she feels uncomfortable with the topic, since it brings back painful memories.\n\nYou decide to go back to a casual conversation, leaving this topic for another occasion. \n\nAt the end of the day Helena thanks you for giving her the day off and treating her with coffee and sweets, and you can see how you are earning her trust. ";
				if (NPCCharList.CharFollower [iHelena].dickSize > 0) {
					toReturn += "";
				} else {
					toReturn += "";
				}
				toReturn += "";
				return toReturn;
			} else if (randNum < 50) {
				toReturn = "You’ve seen Helena sad and unfocused these past days, not an uncommon mood in the city, but you decide to try to do something about it to cheer her up and invite her to join you during dinner.\n\nAlthough she is usually with you during these hours, she is always at the sidelines, observing and making sure that everything is in order instead of enjoying the food with you. \n\nThe good food and wine have an effect, improving her mood a little bit, but that’s not going to be enough. Although you know this may be risky, knowing this may be the reason why she is sad in the first place, you still ask about her life before the outbreak. \n\nShe sighs, not happy with the question, but she still answers it. <i>“Life was good... Or, well, not </i>so<i> good. My family was still rather poor, but at least we didn’t had to worry about being attacked by beasts, or transformed into one.”</i> She goes on talking about the many sites and places that she enjoyed: The library, school, parks, or just strolling through the woods without fear. Times long forgotten to many in the city. \n\nYou tell her about your previous life too, the boring and unexciting life of living in a shack in the woods, taking care of fields and live stock, or training with your guardian. With the outbreak, you too had to fend off beasts and had to deal with scarcity, until you were invited to return to the city. But in comparison, you don’t have much of a reason to look back on those days.\n\n<i>“I see...”</i> she says, not really sure what the point is to this conversation. You smile and tell her that even though things might have been better before the outbreak, it doesn’t matter. What matters is, if anything, to look forward for a better tomorrow instead of being stuck with the past. \n\nShe smiles, and although she is not totally convinced you can see that your words give her something to mull over. To reassure her, you promise her that you’ll make sure to make a better future. \n\n<i>“That’s... Thank you my liege, I know you will, and that’s why I’m working hard too, even though I know I can’t do as much, everything counts right?”</i> you smile and nod at her, and her conversation for the rest of the dinner has significantly improved, dragging herself out of her poor mood. ";
				if (GameControl.dick1Size > 0) {
					toReturn += "";
				} else {
					toReturn += "";
				}

				toReturn += "";			
				return toReturn;
			} else if (randNum < 75) {
				toReturn = "Dealing with the kingdom has always been a complicated task for you, not living there during its more critical years is sometimes hard to relate to what’s going on with the people. \n\nToday during dinner you decided to ask Helena more about her past, specially about her life during the outbreak. \n\nAlthough she is uncomfortable, she starts talking <i>“Live during the outbreak was hell. The first year was the toughest of them all, since no one knew how to contain the disease, and is where most of the people either got transformed or had to get killed by their family or former friends.”</i> you can see how these memories are still painful, but she manages to keep her cool. \n\n<i>“My parents died before the outbreak, so at least they got spared that fate, but I still lost many friends. After the first year, a local alchemist and the king managed to get things under control, and the discovery of potions and other healing methods had helped the people to not lose their mind if they transformed, which is why nowadays there are some beasts around the city, like Alba.”</i>\n\nAlthough her information is useful, you ask how she survived. <i>“Your uncle survived quite a bit, he died just a couple of years before you came here, therefore I was under his protection for most of the time. When he died, there was a big riot and the castle got sacked and abandoned. People believe the place was haunted, so at least my life was peaceful, but earning gold to eat was tough. I worked for Abbadon, Alba and other nobles as a servant, or doing odd jobs. I never settled with any of them because they despised me for being the former head maid of your uncle, but now that I work for you I hope they have changed their mind.”</i>\n\nYou thank Helena for sharing her story with you and she smiles at you <i>“No need to thank me, my liege, I usually don't like to talk about this but I’m happy that you are worried about the city and myself. Also, it helps me to realize that things are not as bad nowadays. If anything I should be thanking you.”</i>\n\nSharing time and listening to her pays off, because the next day she looks more happy to be around you, earning her trust. ";
				WorldControl.dayTime = 5;
				WorldControl.dayTime = 5;
				if (NPCCharList.CharFollower [iHelena].dickSize > 0) {
					toReturn += "";
				} else {
					toReturn += "";
				}
				toReturn += "";
				return toReturn;
			}else {
				toReturn = "Helena’s been helping you with your tasks today. Since the very beginning, she has been not only a great maid, but also someone you can rely on when you need something well done. \n\nJust the fact she can read puts her at the top of your servants, not even mention all of the knowledge she has gathered in her time with your uncle. She has proved to be so useful she is virtually irreplaceable.\n\nToday during the break you decide to ask her about how she has accomplished all of this. <i>“What you mean how, my liege? With hard work and dedication, of course.”</i> you laugh at her remark, being more specific about her story. \n\n<i>“Well, since I was a young I’ve always been curious, but my parent’s weren’t interested in that, saying that learning was for rich boys. That bothered me a lot, so I had to sneak out whenever I could to go to the public library, where I asked the woman in charge if she could teach me.”</i> you can see how her face brightens when she talks about this librarian. <i>“She agreed, in exchange for an extra helping hand from time to time with her duties. Those were good but exhausting years, I barely had any time for myself, but thanks to her and her teachings a whole world was opened in front of me.”</i> she stands proud, something often absent in her.\n\n <i>“Everything else I learned by reading and practice. When your uncle found out I knew how to read, he gave me more work related to that, and after his death I had the chance to read everything in his library.”</i>\n\n\nWhen she is done explaining, she returns to her more humble self. <i>“Sorry my liege, I got carried away. But can I tell you something? If you have the chance, invest in the school and the library again, even knowing something as simple as reading can change everything for someone, and it would help the kingdom too.”</i>\n\nYou smile and thank her for sharing her story with you, and tell her to take the rest of the day off, she happily thanks you; it seems your relationship with her improved.";
				WorldControl.dayTime = 5;
				if (NPCCharList.CharFollower [iHelena].dickSize > 0) {
					toReturn += "";
				} else {
					toReturn += "";
				}
				toReturn += "";
				return toReturn;
			}
		}
	}



	string hangoutLevel2(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (NPCCharList.CharFollower [iHelena].attWillpower >= 66) {
			if (randNum < 25) {
				toReturn = "";
				if (NPCCharList.CharFollower [iHelena].dickSize > 0) {
					toReturn += "";
				} else {
					toReturn += "";
				}
				toReturn += "";
				return toReturn;
			} else if (randNum < 50) {
				toReturn = "";
				if (GameControl.dick1Size > 0) {
					toReturn += "";
				} else {
					toReturn += "";
				}

				toReturn += "";			
				return toReturn;
			} else if (randNum < 75) {
				toReturn = "";
				if (NPCCharList.CharFollower [iHelena].dickSize > 0) {
					toReturn += "";
				} else {
					toReturn += "";
				}
				toReturn += "";
				return toReturn;
			} else {
				toReturn = "";
				if (NPCCharList.CharFollower [iHelena].dickSize > 0) {
					toReturn += "";
				} else {
					toReturn += "";
				}
				toReturn += "";
				return toReturn;
			}
		} else {
			if (randNum < 25) {
				toReturn = "You’re enjoying tea with Helena. Although Helena used to be reserved and more quiet about her past, since you have become a closer friend to her she is more eager to talk, and when the two have some privacy she likes to share her story too, since she hasn’t had any real friends for years. \n\n<i>“"+ GameControl.playerName +"... Do you mind if I share something with you?”</i> by her nervous tone is hard to guess what’s the problem, but you nod and tell her to continue. \n\n<i>“Is about my family, I know they are not here anymore but... I am still resentful of them. I don’t think I ever told you, but they never believed in me, and scolded me when I wanted to learn to read or accomplish anything, saying that that’s for boys.”</i> \n\nHer eyes turn teary just at this brief mention, tugging open these old wounds. She sits at your side and hugs you before she continues <i>“I’m sorry if this comes out of nowhere, but I wanted to get this out of my system.”</i>\n\nShe clings to you for a couple of minutes, letting the room settle into silence while she pulls herself together. <i>“I... I wanted to thank you "+ GameControl.playerName +", for supporting and having faith in me, and giving me the chance to work with you.”</i> you smile at her and calm her by saying that you are the one grateful that you can have someone as capable as her at your side.\n\n<i>“Thanks "+ GameControl.playerName +"... That really means a lot to me.”</i>\n\nThe two of you stay like until she is feeling better. After that, her mood turns back to normal, and both of you go back to enjoy the tea and pastries during your break.";
				if (NPCCharList.CharFollower [iHelena].dickSize > 0) {
					toReturn += "";
				} else {
					toReturn += "";
				}
				toReturn += "";
				return toReturn;
			} else if (randNum < 50) {
				toReturn = "When working on plans to rebuild the city, Helena has always been an important source of information and ideas for you. \n\nAlthough right now you are taking a break, you invited Helena to join you and share some of her time and experience with you, asking her to tell you more about the history of the city, and what she would like to see improved.\n\n<i>“Thank you my liege for asking, but are you sure that you want to hear this from me?”</i> reluctant thanks to her humbleness, you insist that you want to hear her opinion on these matters. \n\n<i>“Very well my liege.”</i> she respectfully bows before proceeding. <i>“I’ve already talked about how was the city before, but if you want me to into more depth, you can say that the city is divided in districts. These districts are usually headed by a single, very powerful noble, although in some cases they are lead by guilds.”</i> she goes on about how Alba and Abbadon are the leaders of the formerly two most prolific districts, but the city is divided into many others. Admittedly many of them would be likened more to slums or ghost-towns nowadays.";
				if (NPCCharList.CharFollower[retFollower(7000)].isRecruited) {
					toReturn += "\n\n<i>“Itzel is doing a great job in the religious district, I believe you did a good job recruiting her my liege.”</i>";
				} else {
					toReturn += "\n\n<i>“The religious district is in shambles and it needs to be rebuilt and managed, but there are no priests or priestesses left in the city, or if they are, there isn't any temple working right now.”</i>";
				}
				if (NPCCharList.CharFollower [retFollower (10000)].isRecruited) {
					toReturn += "\n\n<i>“The school in the city really needs funding. I’ve heard the principal is named Celia, a woman that’s been transformed into a beast, but I don’t know much else about her. The only thing I know is that the school right now can barely handle a small group of students, so you probably need to go and talk with her to see what does she needs.”</i>";
				} else {
					toReturn += "\n\n<i>“You did a good job supporting Celia, who as far as I’ve heard she is doing an amazing job with the school, taking care of many students now. Although I’ve not had a chance to see it with my own eyes yet.”</i>";
				}
				if (NPCCharList.CharFollower [retFollower (7000)].isRecruited) {
					toReturn += "\n\n<i>“I have a friend named Virgil who takes care of the library. I used to work with him too before you arrived. I haven’t seen him in a couple of years, but if he is the same he should be a shy monster boy too. The library really needs some funding though, so maybe you could go there and help him?”</i>";
				} else {
					toReturn += "\n\n<i>“Well, you already took care of the library, and I’m really thankful for that.</i>";
				}

				toReturn += "\n\nShe tries to think in other places, but nothing else comes to mind. Sadly there is a lot of the city that a bookworm isn’t liable to visit. It’s a start, at least.\n\n<i>“Well, those were the places that I think are most important. Or at least they are to me.”</i> she smiles at you, cheerfully. <i>“Thanks for listening to my advice, and I hope you continue to do everything that you can for the city, I’m sure we will see change very soon thanks to you.”</i>";			
				return toReturn;
			} else if (randNum < 75) {
				WorldControl.dayTime = 5;
				toReturn = "You’ve to dealt with many subjects today that were complaining about the city and what you have done for it. You find yourself fed up of hearing so many complaints. To half of these people it’s as if you haven’t done anything for the city, when in fact it has improved a lot since your arrival. \n\nStill the fact that you didn’t grow up in the city is one of the biggest problems. Empathizing with people who lived here their entire lives makes it hard to understand their expectations, likewise they judge you just as harshly for not knowing.\n\nResting in the living room, Helena approaches you <i>“Having trouble my liege? You look stressed. Perhaps I should bring some tea?”</i> You thank her but dismiss the tea. Helena takes a seat at your side <i>“Something is bothering you, would you mind to share it with me?”</i> \n\nAlthough you don’t like to be pressured you know that she means well, and agree to tell her what happened earlier today. <i>“I see the problem, although this may not sound too comforting, should I speak up?”</i> \n\nYou thank her for the offer, and ask her to speak up. <i>“Well, I’ve already told you about my life during the outbreak, and how I felt about it. It should be said that people these days want to return to their regular life, even if it wasn’t so great. There is nothing you can do about this sentiment, except to keep on pushing, and keep up the good work. Thing’s aren’t great now but you’ve made a lot of progress. I’m certain soon enough they will start to change their minds and you’ll earn their trust. It probably sounds callous but the best thing you can do is to ignore any emotional complaints. Or at least avoid taking them personally.”</i>\n\nYou know she is right, but it doesn’t make things any easier. <i>“Well, if it helps, you have my loyalty and trust my liege, and you can count with me for anything.”</i> After she cheers you up, she bows and leaves, having to return to do her tasks, but the bond between you to has become stronger. \n\nSharing time and listening to her pays off, because the next day she looks more happy to be around you.";
				if (NPCCharList.CharFollower [iHelena].dickSize > 0) {
					toReturn += "";
				} else {
					toReturn += "";
				}
				toReturn += "";
				return toReturn;
			} else {
				toReturn = "Today both you and Helena have been sharing many thoughts and memories, enjoying some time together and getting a chance to know each other more. \n\nThe conversation has not been all cheerful and happy, something to be expected from the history that the two of you have, and now the conversation is about Helena’s fears the most about the future.";
				if (NPCCharList.CharFollower [iHelena].charCorruption >= 66) {
					GameControl.actualArousal += 15;
					toReturn += "\n\n<i>“You know, I used to fear change. I wanted to stay simple minded and naive. So dumb.”</i> she laughs while remembering her past self. \n\n<i>“Now I don’t know what I fear the most, but I know what I want: To help you to change and corrupt the city, to free them from their idiocy as you did with myself.”</i>\n\nShe goes into detail about her many plans to keep corrupting and changing the city, and how excited she gets at the thought of you helping her do so. \n\n<i>“This conversation got me all wet, maybe later we could have some fun, you know?”</i>\n\nShe suggestively touches her breasts and blows you a kiss, before standing up and going back to work.\n";
				} else {
					toReturn += "\n\n<i>“There are so many things that have me worried at night, is hard to say where to start.”</i> her nervous tone assures you that she is indeed speaking with the truth. <i>“I know this may sound selfish, but I’m worried about myself. Will I survive this? Or keep my sanity or my own self? Or will I end up changed?...”</i> she looks at the ground, a little hopeless. \n\n<i>“Well... and thats just the first thing. Of course I’m also worried about the kingdom. If it fails, we all go down with it, so I need to do my best to help it out— by supporting you of course.”</i>\n\nShe goes on in detail and length about these fears, but the most important thing is her will to survive, and maybe if luck is on her side she can secure a good life. It’s obvious that she’s toughened up though, in no part due to her poor experiences in the past.\n\nAt the end of the day, the bond between the two of you becomes stronger. \n";
				}
				toReturn += "";
				return toReturn;
			}
		}
	}



	void relationshipChange(){
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime +2); 

		NPCCharList.CharFollower[iHelena].charRelationship += Random.Range (1.5f, 5f);
		NPCCharList.CharFollower[iHelena].charLoyalty += Random.Range (0.5f, 2f);

		if (NPCCharList.CharFollower [iHelena].charRelationship > 100) {
			NPCCharList.CharFollower[iHelena].charRelationship = 100;
		} 
		if (NPCCharList.CharFollower [iHelena].charLoyalty > 100) {
			NPCCharList.CharFollower[iHelena].charLoyalty = 100;
		} 


	}

	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		PanHangout.sortingOrder = -500;
		PanEndTurn.sortingOrder = 500;
	}

	int retFollower(int selectorID){
		int i = 0;
		while (i < NPCCharList.CharFollower.Count) {
			if (NPCCharList.CharFollower [i].charID == selectorID) {
				return i;
			}
			i++;
		}
		Debug.Log ("Bug at retFollower in HelenaHangout.cs");
		return 0;
	}



	void loadHelena(){

		iHelena = 0;
		while (iHelena < NPCCharList.CharFollower.Count) {
			if (NPCCharList.CharFollower [iHelena].charID == 3000) {
				break; 
			}

			iHelena++;
		}
	}


}
