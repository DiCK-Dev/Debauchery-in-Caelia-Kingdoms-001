using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AlbaItems : MonoBehaviour {

	static int iAlba; 

	public Text Board; 
	public Canvas panEndTurn;
	public Canvas panItems;

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




	public void giveItem(int slot){
		loadAlba ();

		if (NPCCharList.CharFollower [iAlba].charLove < 100) {
			Board.text = "Alba is reluctant to accept gifts or items from me right now, I need to keep dating her before she changes her mind! ";
			return; 
		}

		int selItem = GameControl.invSlotArray [slot, 0];
		bool itemRemove = false;
		switch (selItem) {
		case 101: //udder max
			if (NPCCharList.CharFollower [iAlba].breast1Size >= 20) { // over max size 
				Board.text = "I love big tits as much as you do, but forget about it! I need to be able to move you know?!";
				return;
			}
			if (NPCCharList.CharFollower [iAlba].breast1Size >= 15) {// max size 
				Board.text = "Today Alba invited you to her home. You went on your way there as soon as she invited you. As you enter the gates of her castle you see her in one of the gardens, supervising her servants as they cut some of the flowers in it. She sees you and gives you a sly smile.\n \n<i>“It’s good to have you here. I was told you have something that interests me. Why didn’t you tell me sooner?”</i> You know exactly what she is talking about. It’s about that magic potion you possess that’ll make her breasts bigger. You wanted to use it with her but didn’t know how to bring it up. Now someone else told her and you couldn’t be happier. It doesn’t even cross your mind to wonder about the methods used to have such information. All you think now is how into it Alba is.\n \nShe makes you follow her deeper into the garden into a neatly decorated gazebo. You sit on one of metal chairs on it and she does the same while making her servants bring her some tea. <i>“I don’t even like tea that much.”</i> She tells you. <i>“But it fits the place, I guess. I only made them construct this area because some of my investors are weak for this flowery decorations. It is never bad to have the upper hand in business.”</i> You can’t imagine what kind of clients would like a place like this taking on account the kind of products Alba sells, but you figure they must be important if she took the effort to make a garden just for that reason.\n \nHer servants finally arrive with a tea pot and cup. They serve Alba hot, freshly made tea while she removes her shirt. She grabs her tits and push them up for you. <i>“I wonder how much more they’ll weight after.”</i> She grins. <i>“Why don’t you grab them first?”</i> You take her breasts in both hands and give them one last squeeze before Alba drinks her tea already with the potion on it. She must have taken it while you were distracted with her boobs.\n \nAs soon as Alba drank the last drop of tea, her boobs started growing in your hands more and more until they became bigger than your head. You couldn’t help yourself and started licking between them, almost asphyxiating yourself while at it.\n \nAlba pulled you out of her chest and laughed. <i>“You can’t just do that, there is no way you can breathe in there. But I know someone that doesn’t need oxygen.”</i> She said, shamelessly caressing your dick. Your hands acted fast and unwrapped your half erected dick. <i>“Come here.”</i> Alba gets on her knees in front of your chair and places your dick between her boobs, pressing them together to squish your cock with them.\n \nYou moan, making her now you love that and she continues lifting her chest with her hands and dropping it on you, creating delicious friction on your now fully hard cock. It felt so great to have those two heavy and soft spheres making pressure on your dick at the same time. You could see how the precum started drenching her breasts as she kept moving up and down.\n \nHer eyes never left the head of your dick. She gave it the smallest of licks every time it came close to her face. You noticed how she caressed her own nipples every time she licked you as some sort of reward for herself.\n \nYou caressed away the hair form her face and gave pats in between her horns, to encourage her to continue. Then you grabbed her by the horns to ensure that every time your dick got close to her face she would take the entire tip inside her mouth. The pressure of her breasts and the warm moist touch of her mouth made you feel in paradise. You didn’t even noticed how time flew until you came, drenching her face and part of her breasts with your seed.\n \n<i>“Amazing.”</i> Alba said cleaning herself with a nearby napkin that her servants brought with the tea. <i>“I would ask if you like how I look, but I can tell by the volume of your load that you did.”</i> You blush slightly. You knew it was obvious you liked it but who wouldn’t? <i>“Well, I have to go now. This girls just gave me a few ideas for a new project. And I know just who to taste it with.”</i> She winks at you at leaves to her room to make some planning.  You get dressed and escorted to the exit.\n \nKnowing Alba that new invention could take long, but it didn’t matter because as you knew, planning gets her horny, and she always calls you to help her with that.";

			}else { // normal tme 
				Board.text = "Oh you like girls with big tits? Well that's something we both have in common! So give me that, I appreciate the gift!";
			}
			itemRemove = true;
			AlbaTransformation.increaseBreasts ();
			break;
		case 106: // virilitax
			if (NPCCharList.CharFollower [iAlba].dickSizeCM >= 50) {// over max size 
				Board.text = "Sorry "+GameControl.playerName+" but even if it would look like a third leg, I wouldn't be able to walk if it gets any bigger.";
				return;
			} else if (NPCCharList.CharFollower [iAlba].dickSizeCM < 5) { // first time 
				Board.text = "Today, after thinking about it for a long time, you invited Alba to your castle. She agreed happily. In her words: ‘Visiting you was always interesting.’ This time was not going to be the exception. You had acquired a special potion to spice things up in bed with her.\n \nYou were waiting in your living room for her to arrive, she did so right on time. Alba was thirsty and ready to drink any kind of fluid you had ready for her. Luckily you had favorite beer already poured in a cold glass. Before she even greeted you she took the glass and drank it completely, sitting on the table while she did so.\n \nShe drank every last drop and left the glass aside, opening her legs for you to see her crotch. <i>“Delicious! I’m sure you are thirsty too.”</i> She winked at you, and unzipped her shorts to remove them, presenting you her moist pussy. <i>“Drink up.”</i>\n \nYou rested your cheek on the inner side of her leg and licked her slit while paying close attention to her clitoris. You felt her tremble when your tongue caressed her. The potion was working, she was already more sensitive. She noticed this as well.\n \n<i>“Playing tricks aren’t you? What did you put on my beer?”</i> That potion was something you and her had agreed on using before, but you never said when. You wanted it to be a surprise. You smile at her and continued licking her cunt without revealing your plans.\n \nAlba felt waves of pleasure too strong to keep a sitting position. She lay on the table and open her legs more for you. Your tongue was deep inside her but your eyes were fixated on her clitoris. Finally you saw it move a little, you gave it a small lick to encourage its transformation. The contact with your tongue was the catalyst needed for it to grow bigger and bigger, changing its shape to one of a hard cock.  \n \n<i>“Would you look at that?!”</i> Alba said excited and moaning between words. <i>“You finally found the thing.”</i> You gave her a proud look and continued licking from base of her new cock to its reddened tip.\n \nYour hands started massaging Alba’s length while you pushed the head of her cock down your throat, sucking non-stop. You were amazed by how much this dick tasted and felt like any other common dick. You briefly wondered if Alba’s delicious dick could also be able to quench your enormous thirst. You decided you would not stop licking until you find out.\n \nAlba used her claws to grab the back of your head and pull you closer to her pelvis. Her dick violently slammed deeper inside your throat and with a loud scream, Alba filled your insides with her newly acquired cum.\n \n<i>“How do I taste?”</i> She asks you still grabbing onto your head not letting you pull her dick out of your mouth. <i>“I bet you love it.”</i> You really did, and spend the next few hours showing her just how much that cock meant to you.\n";

			} else if (NPCCharList.CharFollower [iAlba].dickSizeCM >= 36) { // max size 
				Board.text = "Unlike the last time you met, this time it was Alba who had invited you over to her castle. When you arrived she was in her room, already naked and massaging the dick you had given her with that one special potion some time ago. Surely she had been enjoying it wildly.\n \nAs you entered to her room she looked at you and made more emphasis in the movements of her hands. She wanted you to enjoy the little show she was posing. Looking at her wet dick, dripping with lube made you forget you had yet another proposition for her. Instead you sat next to her on the bed and took your clothes off. She smiled at your obvious desire to mate with her, and her hands abandoned her dick to caress your cheeks while she leaned to kiss you.\n \nWhile kissing, her furry paws slid through your back and chest. Alba was slowly pushing your body with hers to have you flat on your back. Once she had you completely lying on the bed, she stopped kissing your mouth to focus on your neck. She gave you soft bites, marking your skin while her hands were separating your legs.\n \n<i>“I know this is what you what you came here for.”</i> She says in a low sensual voice while placing the tip of her dick over your entrance. <i>“Last time you were so thirsty for me that you didn’t even take a ride on it.”</i> You gulped, worrying your evident desire would turn her off. But your worries were in vain as she was already pushing her hard cock inside you. You gasped, feeling how her length stretched you inner walls. You had come prepared, your insides were already ready to take her but still, your fingers and her cock were a world of difference.\n \nStill in only a few pushes inside you, you already got accustomed to her size. She moved in a slow pace, very unlike her, her softness gave you pleasure but not the usual. When you saw her face you understood why. Being inside you felt so good to her it was difficult for her to move. It was there when you remembered what you came here for. You reached into your discarded clothing and fetched a vial with yet another potion.\n \n<i>“What is that?”</i> Alba panted, still trying to keep moving inside you. <i>“You want me to drink it? Ok, I hope you know what you are doing.”</i> She took the potion and drank in completely, tossing the empty vial away. \n\nThe change was immediate. First she began moaning in ecstasy and came on the spot. Then her claws clasped your hips and she started moving forcefully inside you, pushing her cum deeper, you couldn’t help to notice how each time she rammed against you felt different. Her dick was growing to monstrous proportions stretching you more than ever, you could feel and even see her tip elevating your stomach with each movement.\n \nYou didn’t know when she was going to stop growing, the only thing you knew was that with every passing second she moved faster and faster. You and she couldn’t moan any louder than you were. The newness of the experience was too much to keep your minds clear. You kept going despite your own body telling you to stop.\n \nAlba went full berserk on you, scratching your skin, biting you all over and still plowing your body with her new giant dick. This was the Alba you knew, the one with endless energy to ravish you and make you crazy. Both of you were close to the end, you could feel her cock pulsating inside you. In only two more minutes she let out her seed with such power it forced her dick to get out of you. Her still spraying dick cover your entire body with her sperm as you reached your orgasm as well. Alba lay beside you, tired and panting softly.\n \n<i>“You always know how to have fun, huh?”</i> She tells you with a smile before passing out. Before you could decide whether or not to sleep, you passed out as well, and took a long deserved rest.";

			}else {
				Board.text = "\"<i>So is this size not enough for you? Heh you greedy bastard...</i>\"";
			}
			itemRemove = true;
			AlbaTransformation.increaseDick();
			break;
		case 126: // death bosom
			if (NPCCharList.CharFollower [iAlba].breast1Size <= 0) {
				Board.text = "<i>“"+GameControl.playerName+" I'm already flat as it is, and I refuse to make them any smaller!”</i>";
				return;
			} else {
				Board.text = "<i>“Huh you don't like them this big anymore? That's great, I also got tired of them... Literally! Or do you think having big boobs is easy "+GameControl.playerName+"?”</i>";
			}
			itemRemove = true;
			AlbaTransformation.decreaseBreasts();
			break;
		case 131: // betaX
			if (NPCCharList.CharFollower [iAlba].dickSizeCM <= 0) {
				Board.text = "<i>“Are you mental? Do you see any dick down there?”</i>";
				return;
			} else {
				Board.text = "<i>“You don't want to suck on this? Tsk such a shame... but don't worry, this time I'll please you, give me the potion!”</i>";
			}
			itemRemove = true;
			AlbaTransformation.decreaseDick();
			break;
		/*case 200: // jewelry
			if (NPCCharList.CharFollower [iAlba].charRelationship < 50) {
				Board.text = "<i>“This is for me " + GameControl.playerName + "? Thanks a lot! You shouldn't have!”</i>\n";
				relationshipChange (0);
			} else {
				Board.text = "<i>“Thanks a lot for the gift! But you have gave me so much that I feel like embarassed that I can't give you anything back...”</i>";
				relationshipChange (1);
			}
			itemRemove = true;
			break;
		case 201: // fancy
			if (NPCCharList.CharFollower [iAlba].charRelationship < 50) {
				Board.text = "<i>“These are amazing " + GameControl.playerName + "! I'll wear them right now!”</i>\n";
				relationshipChange (0);
			} else {
				Board.text = "<i>“" + GameControl.playerName + " you have bought me so many clothes and things! You don't have to worry about it! Still, I'm really happy for this!”</i>";
				relationshipChange (1);
			}
			itemRemove = true;
			break;
		case 202: // luxury goods 
			if (NPCCharList.CharFollower [iAlba].charRelationship < 50) {
				Board.text = "<i>“These things are so pretty " + GameControl.playerName + "! Thanks a lot!”</i>\n";
				relationshipChange (0);
			} else {
				Board.text = "<i>“You don't have to worry " + GameControl.playerName + "! I have a lot of things already! Still, I'm happy that you are so considerate with me!”</i>";
				relationshipChange (1);
			}
			itemRemove = true;
			break;
		case 203: // perfume
			if (NPCCharList.CharFollower [iAlba].charRelationship < 50) {
				Board.text = "<i>“This smells fantastic " + GameControl.playerName + "! I will use this right now! Thanks for the gift!”</i>\n";
				relationshipChange (0);
			} else {
				Board.text = "<i>“This smells very good " + GameControl.playerName + "! But you are drowning me in care and gifts! You don't have to worry this much!”</i>\n";
				relationshipChange (1);
			}
			itemRemove = true;
			break;
		case 204: // plus toy
			Board.text = "<i>“This is a very cute plush toy " + GameControl.playerName + "! I will add it to my collection!”</i>\n";

			if (NPCCharList.CharFollower [iAlba].charRelationship < 50) {
				relationshipChange (0);
			} else {
				relationshipChange (1);
			}
			itemRemove = true;
			break;
		case 205: // chocolate box 
			Board.text = "<i>“Ah chocolates! They look great " + GameControl.playerName + "! I'm going to eat them right now!”</i>\n";

			if (NPCCharList.CharFollower [iAlba].charRelationship < 50) {
				relationshipChange (0);
			} else {
				relationshipChange (1);
			}
			itemRemove = true;
			break;
		case 206:
			Board.text = "<i>“Oh... I don't know much about wines, but this looks very fancy! I appreciate the gesture " + GameControl.playerName + "!”</i>\n";
			relationshipChange (2);
			itemRemove = true;
			break;
		case 116: // gigantus
			if (NPCCharList.CharFollower [iAlba].heightChar < 365) {
				Board.text = "Do you want me to be bigger? Okay, I'll drink it.";
				itemRemove = true; 
				NPCCharList.CharFollower [iAlba].heightChar += 30; 
			} else {
				Board.text = "I cannot grow taller, "+ GameControl.playerName+".";
			}
			break;*/
		default:
			Board.text = "<i>“What you want me to do with this? Forget about it "+ GameControl.playerName +"!”</i>\n";
			return;

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





	void Awake(){
		loadItems ();
	}


	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		panItems.sortingOrder = -500;
		panEndTurn.sortingOrder = 500;
	}


	void loadItems(){

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


	void loadAlba(){
		iAlba = 0;

		while (iAlba < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iAlba].charID == 13000){
				WorldControl.NPCID = NPCCharList.CharFollower [iAlba].charID;
				break; 
			}
			iAlba++;
		}
	}








}
