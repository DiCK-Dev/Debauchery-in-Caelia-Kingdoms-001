using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AbbadonItems : MonoBehaviour {


	static int iAbbadon = 0; // used to load abbadon 

	public Text Board; 
	public Canvas transformationPanel;
	public Canvas outfitPanel;
	public Canvas panEndTurn;

	public Button buttItem0; // buttons for items
	public Button buttItem1; 
	public Button buttItem2; 
	public Button buttItem3; 
	public Button buttItem4; 
	public Button buttItem5; 
	public Button buttItem6; 
	public Button buttItem7; 
	public Button buttItem8; 
	public Button buttItem9; 



	public Text item0Name; 
	public Text item1Name;
	public Text item2Name;
	public Text item3Name;
	public Text item4Name;
	public Text item5Name;
	public Text item6Name;
	public Text item7Name;
	public Text item8Name;
	public Text item9Name;



	string pronhimher; 
	string pronhisher;
	string pronheshe; 

	public void giveItem(int slot){
		loadAbbadon ();
		if (NPCCharList.CharFollower [iAbbadon].charRelationship < 40) {
			Board.text = "<i>“I don’t think so "+ GameControl.playerName +", right now I don’t feel like taking anything from you.”</i>\n";
			return;
		}

		int selItem = GameControl.invSlotArray [slot, 0];
		bool itemRemove = false;
		switch (selItem) {
		case 101: //udder max
			if (NPCCharList.CharFollower [iAbbadon].breast1Size >= 15) {
				Board.text = "<i>“I don’t think so " + GameControl.playerName + "! Bigger than this and I will not be able to walk!”</i>\n";
				break;
			} else if (NPCCharList.CharFollower [iAbbadon].breast1Size >= 9) {
				if (NPCCharList.CharFollower [iAbbadon].charCorruption >= 66) {
					Board.text = "Today you are visiting Abbadon in "+pronhisher+" own house. As of late, your visits have only been for sex with himher, since "+pronhisher+" mind has been perverted and corrupted.\n\nIt must be said that although at first "+pronheshe+" was reluctant to increase the size of "+pronhisher+" breasts, as of late, Abbadon’s obsession with "+pronhisher+" chest has begun to change "+pronhisher+" opinon of the topic. You often find "+pronhimher+" walking with them exposed through "+pronhisher+" house.\n\nToday is not an exception, and after barely getting any work done you find yourself playing with "+pronhisher+" big tits.\n\n<i>“Ah! You’re so good at this "+ GameControl.playerName+"! None of my servants is as diligent as you are!”</i> "+pronheshe+" praises you, but before you continue you decide to show "+pronhimher+" a present, an alchemic potion used for chest expansion.\n\n<i>“You never have enough uh? Well, me neither, give me that!”</i> "+pronheshe+" gulps it in a single go, and you only have to wait few minutes before "+pronhisher+" breasts grow to be like enormous balloons. ";
					if (GameControl.dick1Size > 0) {
						Board.text += "\n\n<i>“Damn, these are amazing! Now bring your dick right here "+ GameControl.playerName+"!”</i> you don’t make "+pronhimher+" wait and quickly offer "+pronhimher+" your dick, which "+pronheshe+" quickly puts in between "+pronhisher+" big jugs.\n\nAbbadon spits on top of it and starts to giving you the tit job of your life <i>“This feels great! I may even come myself by doing this!”</i> \n\nWhen your cock manages to slip out, Abbadon takes it in "+pronhisher+" mouth and starts to suck you. \n\nYou’re delighted by how excited is Abbadon to use "+pronhisher+" new body to please you, and it doesn’t takes "+pronhimher+" much time before "+pronheshe+" gets you close to release.\n\n<i>“Feed me with it "+ GameControl.playerName+"!”</i> "+pronheshe+" asks you, and although "+pronheshe+" keeps moving "+pronhisher+" breasts up and down, "+pronheshe+" makes sure to have "+pronhisher+" mouth as close as it can be to your cock.\n\nYou warn "+pronhimher+" just seconds before you cum, just enough so "+pronheshe+" can move "+pronhisher+" face and take the tip of your dick inside. \n\nIn ecstasy, you spurt load after load of cum, so much that even the gluttonous Abbadon is satisfied by the amount, spilling some of it over "+pronhisher+" face and chest, and making a small pool of cum on top of her newly acquired assets.\n\n<i>“Heh among the many treats I love, your cum is one of them.”</i> "+pronheshe+" teasingly says while smearing the cum all over "+pronhisher+" body.\n\n<i>“So, what you want to do with me now "+ GameControl.playerName+"?”</i> "+pronheshe+" says before the two of you start to fuck again, over the course of the whole day. ";
					} else {
						Board.text += "\n\n<i>“Go on "+GameControl.playerName+", touch them, enjoy them as much as I will!”</i> you smile and leap forward, putting your face in between them.\n\nAbbadon laughs and giggles <i>“Haha! Keep going! You’re so fun!”</i> you can feel "+pronhisher+" hand in the back of your head, pressing you closer.\n\n<i>“Ahh... this feels too good, this potion really makes my tits sensitive. Don’t stop now "+ GameControl.playerName+"!”</i> At that insistence, you begin sucking on one of them while you pinch the other with your free hand.\n\nYou keep touching and groping her massive breasts for few minutes, until "+pronheshe+" starts to moan louder <i>“Ahh... y-yes, just a little more!”</i> you increase the intensity of your movements, and soon enough Abbadon starts to pant and moan with more intensity.\n\n<i>“Ahh! Y-Yes!”</i> "+pronheshe+" yells before climaxing <i>“Ahhh... I-I didn’t knew I could have an orgasm by just playing with my tits... this was better than I expected...”</i> Abbadon basks in the afterglow of the orgasm before giving you a deep kiss and starting to get dressed again.\n\n<i>“So, what you want to do with me now "+ GameControl.playerName+"?”</i> "+pronheshe+" says before the two of you start to fuck over the course of the whole day. ";
					}
				} else {
					Board.text = "You’re visiting Abbadon today, just a normal, friendly meeting. While you did intend to do some work at the venue, you also did come with a small present, one of your alchemic potions used for body augmentation. You figure that Abbadon would gain some interest and pleasure from something like this.\n\n<i>“So you want me to drink this? You said something along the lines of it would make my chest swell up? I mean, aren’t these already big enough? I’m not complaining, but your lust just is insatiable "+ GameControl.playerName+".”</i> "+pronheshe+" says, kinda surprised that you still want "+pronhimher+" to have even bigger tits.\n\n<i>“*sigh* Fine, screw it. Give it here.”</i> "+pronheshe+" reluctantly agrees to take the potion, mostly just to please you. It doesn’t takes long until "+pronheshe+" has to undress "+pronhimher+"self to make way for "+pronhisher+" new body. \n\n<i>“Oh my... these are getting really big! Like two enormous balloons!”</i> The two of you stand there in amazement at the recent development. Part of you is shocked that there was no painful reaction that usually occurs with use of potions such as this.\n\n<i>“So... I bet you’re dying to touch them, am I wrong?”</i> you smile and leap forward, burying your face between them. Abbadon laughs and giggles <i>“Haha! Stop it "+ GameControl.playerName+"! You’re so silly!”</i> but you keep going, until you can feel "+pronhisher+" hand in the back of your head, pressing you closer.\n\n<i>“Ahh... it may be the potion’s effect but... this feels rather good, please keep going "+ GameControl.playerName+"...”</i> At that insistence, you begin sucking on one of them while you pinch the other with your free hand.\n\nYou keep touching and fondling her massive breasts for few minutes, as "+pronheshe+" starts to moan louder <i>“Ahh... y-yes, just a little more!”</i> you increase the intensity of your movements, and soon enough Abbadon starts to pant and moan louder.\n\n<i>“Ahh! Y-Yes!”</i> "+pronheshe+" yells before climaxing <i>“Ahhh... I-I didn’t knew I could have an orgasm by just playing with my tits... this was better than I expected...”</i> "+pronheshe+" gives you a kiss and thanks you, before "+pronheshe+" starts to dress again.\n\n<i>“Well, now that you’re here, maybe we can talk business!”</i> oh crap...";
				}
			}else {
				Board.text = "<i>“Uh? Do you want me to have bigger breasts? Can’t blame you for that, give me the potion, I’ll drink it.”</i>\n";
			}
			itemRemove = true;
			AbbadonTransformation.increaseBreasts ();
			break;
		case 106: // virilitax
			if (NPCCharList.CharFollower [iAbbadon].dickSizeCM >= 50) {
				Board.text = "<i>“I don’t think this will work out " + GameControl.playerName + ", this is already as big as it gets you know.”</i>";
				break;
			} else if (NPCCharList.CharFollower [iAbbadon].dickSizeCM >= 36) {
				if (NPCCharList.CharFollower [iAbbadon].charCorruption > 66) {
					Board.text = "Today you are visiting Abbadon in "+pronhisher+" own house. As of late, your visits have only been for sex with himher, since "+pronhisher+" mind has been perverted and corrupted.\n\nIt must be said that although at first "+pronheshe+" was reluctant to increase the size of "+pronhisher+" breasts, as of late, Abbadon’s obsession with "+pronhisher+" chest has begun to change "+pronhisher+" opinon of the topic. You often find "+pronhimher+" walking with them exposed through "+pronhisher+" house.\n\nToday is not an exception, and after barely getting any work done you find yourself playing with "+pronhisher+" big tits.\n\n<i>“Ah! You’re so good at this "+ GameControl.playerName+"! None of my servants is as diligent as you are!”</i> "+pronheshe+" praises you, but before you continue you decide to show "+pronhimher+" a present, an alchemic potion used for chest expansion.\n\n<i>“You never have enough uh? Well, me neither, give me that!”</i> "+pronheshe+" gulps it in a single go, and you only have to wait few minutes before "+pronhisher+" breasts grow to be like enormous balloons. ";

					if (GameControl.dick1Size > 0) {
						Board.text += "\n\n<i>“Damn, these are amazing! Now bring your dick right here "+ GameControl.playerName+"!”</i> you don’t make "+pronhimher+" wait and quickly offer "+pronhimher+" your dick, which "+pronheshe+" quickly puts in between "+pronhisher+" big jugs.\n\nAbbadon spits on top of it and starts to giving you the tit job of your life <i>“This feels great! I may even come myself by doing this!”</i> \n\nWhen your cock manages to slip out, Abbadon takes it in "+pronhisher+" mouth and starts to suck you. \n\nYou’re delighted by how excited is Abbadon to use "+pronhisher+" new body to please you, and it doesn’t takes "+pronhimher+" much time before "+pronheshe+" gets you close to release.\n\n<i>“Feed me with it "+ GameControl.playerName+"!”</i> "+pronheshe+" asks you, and although "+pronheshe+" keeps moving "+pronhisher+" breasts up and down, "+pronheshe+" makes sure to have "+pronhisher+" mouth as close as it can be to your cock.\n\nYou warn "+pronhimher+" just seconds before you cum, just enough so "+pronheshe+" can move "+pronhisher+" face and take the tip of your dick inside. \n\nIn ecstasy, you spurt load after load of cum, so much that even the gluttonous Abbadon is satisfied by the amount, spilling some of it over "+pronhisher+" face and chest, and making a small pool of cum on top of her newly acquired assets.\n\n<i>“Heh among the many treats I love, your cum is one of them.”</i> "+pronheshe+" teasingly says while smearing the cum all over "+pronhisher+" body.\n\n<i>“So, what you want to do with me now "+ GameControl.playerName+"?”</i> "+pronheshe+" says before the two of you start to fuck again, over the course of the whole day. ";
					} else {
						Board.text += "\n\n<i>“Go on "+ GameControl.playerName+", touch them, enjoy them as much as I will!”</i> you smile and leap forward, putting your face in between them.\n\nAbbadon laughs and giggles <i>“Haha! Keep going! You’re so fun!”</i> you can feel "+pronhisher+" hand in the back of your head, pressing you closer.\n\n<i>“Ahh... this feels too good, this potion really makes my tits sensitive. Don’t stop now "+ GameControl.playerName+"!”</i> At that insistence, you begin sucking on one of them while you pinch the other with your free hand.\n\nYou keep touching and groping her massive breasts for few minutes, until "+pronheshe+" starts to moan louder <i>“Ahh... y-yes, just a little more!”</i> you increase the intensity of your movements, and soon enough Abbadon starts to pant and moan with more intensity.\n\n<i>“Ahh! Y-Yes!”</i> "+pronheshe+" yells before climaxing <i>“Ahhh... I-I didn’t knew I could have an orgasm by just playing with my tits... this was better than I expected...”</i> Abbadon basks in the afterglow of the orgasm before giving you a deep kiss and starting to get dressed again.\n\n<i>“So, what you want to do with me now "+ GameControl.playerName+"?”</i> "+pronheshe+" says before the two of you start to fuck over the course of the whole day. ";
					}
				} else {
					Board.text = "You’re visiting Abbadon today, just a normal, friendly meeting. While you did intend to do some work at the venue, you also did come with a small present, one of your alchemic potions used for body augmentation. You figure that Abbadon would gain some interest and pleasure from something like this.\n\n<i>“So you want me to drink this? You said something along the lines of it would make my chest swell up? I mean, aren’t these already big enough? I’m not complaining, but your lust just is insatiable "+ GameControl.playerName+".”</i> "+pronheshe+" says, kinda surprised that you still want "+pronhimher+" to have even bigger tits.\n\n<i>“*sigh* Fine, screw it. Give it here.”</i> "+pronheshe+" reluctantly agrees to take the potion, mostly just to please you. It doesn’t takes long until "+pronheshe+" has to undress "+pronhimher+"self to make way for "+pronhisher+" new body. \n\n<i>“Oh my... these are getting really big! Like two enormous balloons!”</i> The two of you stand there in amazement at the recent development. Part of you is shocked that there was no painful reaction that usually occurs with use of potions such as this.\n\n<i>“So... I bet you’re dying to touch them, am I wrong?”</i> you smile and leap forward, burying your face between them. Abbadon laughs and giggles <i>“Haha! Stop it "+ GameControl.playerName+"! You’re so silly!”</i> but you keep going, until you can feel "+pronhisher+" hand in the back of your head, pressing you closer.\n\n<i>“Ahh... it may be the potion’s effect but... this feels rather good, please keep going "+ GameControl.playerName+"...”</i> At that insistence, you begin sucking on one of them while you pinch the other with your free hand.\n\nYou keep touching and fondling her massive breasts for few minutes, as "+pronheshe+" starts to moan louder <i>“Ahh... y-yes, just a little more!”</i> you increase the intensity of your movements, and soon enough Abbadon starts to pant and moan louder.\n\n<i>“Ahh! Y-Yes!”</i> "+pronheshe+" yells before climaxing <i>“Ahhh... I-I didn’t knew I could have an orgasm by just playing with my tits... this was better than I expected...”</i> "+pronheshe+" gives you a kiss and thanks you, before "+pronheshe+" starts to dress again.\n\n<i>“Well, now that you’re here, maybe we can talk business!”</i> oh crap...";

				}
			}else {
				Board.text = "<i>“Uh? Is my dick not big enough for you? Very well, give me that and I’ll make sure to give it a good use.”</i>\n";
			}
			itemRemove = true;
			AbbadonTransformation.increaseDick();
			break;
		case 126: // death bosom
			if (NPCCharList.CharFollower [iAbbadon].breast1Size <= 0) {
				Board.text = "<i>“I don’t think so "+ GameControl.playerName +"! I’m already flat!”</i>";
				break;
			} else {
				Board.text = "<i>“Uh? You don’t like the size of my breasts? Well, nothing I can do right? Give me that potion then.”</i>";
			}
			itemRemove = true;
			AbbadonTransformation.decreaseBreasts();
			break;
		case 131: // betaX
			if (NPCCharList.CharFollower [iAbbadon].dickSizeCM <= 0) {
				Board.text = "<i>“What are you talking about "+ GameControl.playerName +"? I don’t have a dick!”</i>\n";
				break;
			} else {
				Board.text = "<i>“Uh? Is my dick too much for you? Very well, give me that and I’ll make sure to don’t go too hard on you in the future.”</i>";
			}
			itemRemove = true;
			AbbadonTransformation.decreaseDick();
			break;
		case 200: // jewelry
			Board.text = "<i>“Well, I'm not a big fan of jewelry, but I guess I can use this from time to time. Thanks for the gesture, " + GameControl.playerName + ".”</i>\n";
			relationshipChange (2);
			itemRemove = true;
			break;
		case 201: // fancy
			Board.text = "<i>“No! Please dont " + GameControl.playerName + "! I am very picky with my clothes, please give this to someone else!”</i>\n";
			return;
		case 202: // luxury goods 
			if (NPCCharList.CharFollower [iAbbadon].charRelationship < 50) {
				Board.text = "<i>“You have good taste, " + GameControl.playerName + ", I really appreciate the gesture.”</i>\n";
				relationshipChange (0);
			} else {
				Board.text = "<i>“You don't have to worry " + GameControl.playerName + ", I have a lot of trinkets already, but I appreciate the attempt.”</i>";
				relationshipChange (1);
			}
			itemRemove = true;
			break;
		case 203: // perfume
			Board.text = "<i>“Well, I'm very selective with my perfumes, but I guess I can use this from time to time. Thanks for the gesture, " + GameControl.playerName + ".”</i>\n";
			relationshipChange (2);
			itemRemove = true;
			break;
		case 204: // plus toy
			Board.text = "Abbadon grabs the gift and torns it apart, clearly angry.\n\n <i>“" + GameControl.playerName + "! I know I can be childish at times, but this is too much! Don't mock me!”</i>\n";
			itemRemove = true;
			NPCCharList.CharFollower[iAbbadon].charRelationship -= Random.Range (0.5f, 2f);
			break;
		case 205: // chocolate box 
			if (NPCCharList.CharFollower [iAbbadon].charRelationship < 50) {
				Board.text = "<i>“Ah chocolates! Nothing like a sweet treat after work! Thanks a lot " + GameControl.playerName + "!”</i>\n";
				relationshipChange (0);
			} else {
				Board.text = "<i>“Thanks for the chocolates " + GameControl.playerName + "! But maybe next time you could take me to a nice place if you want to treat me!”</i>";
				relationshipChange (1);
			}
			itemRemove = true;
			break;
		case 206:
			if (NPCCharList.CharFollower [iAbbadon].charRelationship < 50) {
				Board.text = "<i>“Ah, this is an excelent wine! Thanks a lot " + GameControl.playerName + ", you really know what to get!”</i>\n";
				relationshipChange (0);
			} else {
				Board.text = "<i>“An excelent wine indeed, but what's the point if I'm going to end up drinking it alone " + GameControl.playerName + "? Maybe next time you could take me to a nice place.”</i>";
				relationshipChange (1);
			}
			itemRemove = true;
			break;
		default:
			Board.text = "<i>“What you want me to do with this? Forget about it "+ GameControl.playerName +"!”</i>\n";
			break;

		}

		if (itemRemove) {
			GameControl.invSlotArray [slot, 1] -= 1;
			if(GameControl.invSlotArray [slot, 1] <= 0){
				GameControl.invSlotArray [slot, 0] = 0;
				GameControl.invSlotArray [slot, 1] = 0;
			}
		}

		endTurnFun ();
	}


	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		transformationPanel.sortingOrder = -500;
		outfitPanel.sortingOrder = -500;
		panEndTurn.sortingOrder = 500;
	}


	public void Outfits(int selection){
		loadAbbadon ();
		switch (selection) {
		case 0:
			AbbadonTransformation.abbadonOutfitNormal ();

			if (NPCCharList.CharFollower [iAbbadon].charCorruption < 66) {
				Board.text = "My favorite dress, perfect for every occasion if you ask me.";
			} else {
				Board.text = "This dress again? Don't you think it is too boring? Well, if you insist.";
			}
			endTurnFun ();
			break;
		case 1:

			if (NPCCharList.CharFollower [iAbbadon].charCorruption < 66) {
				Board.text = "I refuse "+ GameControl.playerName +"! This is too improper for someone of my status!";
			} else {
				AbbadonTransformation.abbadonOutfitCorrupt0 ();
				Board.text = "You want me to dress with this?... That's a wonderful idea, I'll go and change immediately.";
				endTurnFun ();
			}
			break;
		case 2:
			if (NPCCharList.CharFollower [iAbbadon].charCorruption < 100) {
				Board.text = "I refuse "+ GameControl.playerName +"! I cannot run naked through the city!";
			} else {
				AbbadonTransformation.abbadonOutfitNaked ();
				Board.text = "I love to go naked, I feel so free...";
				endTurnFun ();
			}
				
			break;
		default:
			break;
		}
	}


	void Awake(){
		item0Name.text = "Empty";
		item1Name.text = "Empty";
		item2Name.text = "Empty";
		item3Name.text = "Empty";
		item4Name.text = "Empty";
		item5Name.text = "Empty";
		item6Name.text = "Empty";
		item7Name.text = "Empty";
		item8Name.text = "Empty";
		item9Name.text = "Empty";
		buttItem0.interactable = false;
		buttItem1.interactable = false;
		buttItem2.interactable = false;
		buttItem3.interactable = false;
		buttItem4.interactable = false;
		buttItem5.interactable = false;
		buttItem6.interactable = false;
		buttItem7.interactable = false;
		buttItem8.interactable = false;
		buttItem9.interactable = false;

		if (GameControl.invSlotArray [0, 0] != 0 && GameControl.invSlotArray [0, 1] != 0) {
			item0Name.text = ItemData.itemDataList [GameControl.invSlotArray [0, 0]].itemName + " x" + GameControl.invSlotArray [0, 1].ToString ();
			buttItem0.interactable = true;
		}
		if (GameControl.invSlotArray [1, 0] != 0 && GameControl.invSlotArray [1, 1] != 0) {
			item1Name.text = ItemData.itemDataList [GameControl.invSlotArray [1, 0]].itemName + " x" + GameControl.invSlotArray [1, 1].ToString ();
			buttItem1.interactable = true;
		}
		if (GameControl.invSlotArray [2, 0] != 0 && GameControl.invSlotArray [2, 1] != 0) {
			item2Name.text = ItemData.itemDataList [GameControl.invSlotArray [2, 0]].itemName + " x" + GameControl.invSlotArray [2, 1].ToString ();
			buttItem2.interactable = true;
		}
		if (GameControl.invSlotArray [3, 0] != 0 && GameControl.invSlotArray [3, 1] != 0) {
			item3Name.text = ItemData.itemDataList [GameControl.invSlotArray [3, 0]].itemName + " x" + GameControl.invSlotArray [3, 1].ToString ();
			buttItem3.interactable = true;
		}
		if (GameControl.invSlotArray [4, 0] != 0 && GameControl.invSlotArray [4, 1] != 0) {
			item4Name.text = ItemData.itemDataList [GameControl.invSlotArray [4, 0]].itemName + " x" + GameControl.invSlotArray [4, 1].ToString ();
			buttItem4.interactable = true;
		}
		if (GameControl.invSlotArray [5, 0] != 0 && GameControl.invSlotArray [5, 1] != 0) {
			item5Name.text = ItemData.itemDataList [GameControl.invSlotArray [5, 0]].itemName + " x" + GameControl.invSlotArray [5, 1].ToString ();
			buttItem5.interactable = true;
		}
		if (GameControl.invSlotArray [6, 0] != 0 && GameControl.invSlotArray [6, 1] != 0) {
			item6Name.text = ItemData.itemDataList [GameControl.invSlotArray [6, 0]].itemName + " x" + GameControl.invSlotArray [6, 1].ToString ();
			buttItem6.interactable = true;
		}
		if (GameControl.invSlotArray [7, 0] != 0 && GameControl.invSlotArray [7, 1] != 0) {
			item7Name.text = ItemData.itemDataList [GameControl.invSlotArray [7, 0]].itemName + " x" + GameControl.invSlotArray [7, 1].ToString ();
			buttItem7.interactable = true;
		}
		if (GameControl.invSlotArray [8, 0] != 0 && GameControl.invSlotArray [8, 1] != 0) {
			item8Name.text = ItemData.itemDataList [GameControl.invSlotArray [8, 0]].itemName + " x" + GameControl.invSlotArray [8, 1].ToString ();
			buttItem8.interactable = true;
		}
		if (GameControl.invSlotArray [9, 0] != 0 && GameControl.invSlotArray [9, 1] != 0) {
			item9Name.text = ItemData.itemDataList [GameControl.invSlotArray [9, 0]].itemName + " x" + GameControl.invSlotArray [9, 1].ToString ();
			buttItem9.interactable = true;
		}


	}




	void relationshipChange(int selector){
		Random.InitState (WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime +2); 

		if (selector == 0) { // for when rel is low
			NPCCharList.CharFollower[iAbbadon].charRelationship += Random.Range (1.5f, 5f);
			NPCCharList.CharFollower[iAbbadon].charLoyalty += Random.Range (0.5f, 2f);
		}

		if (selector == 1) { // for when rel is high 
			NPCCharList.CharFollower[iAbbadon].charRelationship += Random.Range (1f, 3f);
			NPCCharList.CharFollower[iAbbadon].charLoyalty += Random.Range (0.5f, 1.5f);
			NPCCharList.CharFollower[iAbbadon].charLove += Random.Range (0.5f, 1.5f);
		}

		if (selector == 2) { // shitty gift 
			NPCCharList.CharFollower[iAbbadon].charRelationship += Random.Range (0.3f, 2f);
			NPCCharList.CharFollower[iAbbadon].charLoyalty += Random.Range (0f, 1f);
		}

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


	void loadAbbadon(){
		iAbbadon = 0;
		while (iAbbadon < NPCCharList.CharFollower.Count)
		{
			if (NPCCharList.CharFollower [iAbbadon].charID == 1000 ) 
			{
				break; 
			}
			iAbbadon++;
		}
	}




}
