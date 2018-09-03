using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HelenaItems : MonoBehaviour {


	static int iHelena = 0; // used to load abbadon 

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













	public void giveItem(int slot){
		loadHelena ();



		int selItem = GameControl.invSlotArray [slot, 0];
		bool itemRemove = false;
		switch (selItem) {
		case 101: //udder max
			if (NPCCharList.CharFollower [iHelena].breast1Size >= 20) {
				Board.text = "<i>“My liege I wouldn't be able to work if they become any bigger! I'm not even sure if I could even walk!...”</i>\n";
				return;
			}
			if (NPCCharList.CharFollower [iHelena].breast1Size >= 15) {
				if (NPCCharList.CharFollower [iHelena].charCorruption >= 66 && NPCCharList.CharFollower [iHelena].attWillpower >= 66) {
					Board.text = "Helena’s breasts are big and generous, but still, they can always be bigger!\n\nOnce you call her it doesn’t takes long until she arrives into your chamber.\n\n<i>“What’s the reason to disturb me? You better have a good excuse to make me come here "+ GameControl.playerName+"!”</i> although annoyed, when she sees the bottle in our hand she changes her tone. \n\n<i>“A breast growth potion, huh? I guess I could use that, these still aren’t big enough.”</i> she takes the potion from your hand and gulps it in a single go. \nIt takes a minute, but once it starts to affect her she exposes her chests and grabs her breasts.\n\n<i>“Ugh! It hurts! But at least this won’t take long!”</i> the pain in her face is obvious, but she can take it.\n\nYou love to see these changes, and it always amazes you than in just few minutes they can grow so fast. When done, she can barely grab them with her hands.\n\n<i>“Ah... now these are truly impressive. Do you want to grab them?”</i> you happily nod. \n\n<i>“Fine, just this once because you bought the potion.”</i>\n\nShe removes her hands and stands straight. You immediately start to play with them: They are heavy, nice and soft, and her nipples have become really sensitive, to the point that she can’t help herself but moan when you pinch one of them. ";
					if (GameControl.dick1Size > 0) {
						Board.text += "\n\n<i>“What are you? A kid? Let’s do something more interesting.”</i> she says, pointing at your dick. \n\nWithout further ado you agree with her suggestion and remove your clothes, showing her your raised mast. \n\n<i>“Always aroused, like some sort of filthy animal... Fine, I’ll indulge you.”</i>\n\nShe kneels down and starts to jerk you off first, using the pre and her own saliva to lubricate her tits. \n\nOnce they are nice and wet, she takes your cock and puts it in between them.\n\n<i>“You better enjoy this, or I’ll punish you hard afterward.”</i> but there is no denying she is gaining pleasure from this as well. You softly mention your enjoyment of her silky, warm skin. \n\n<i>“Hah! I haven’t even started yet!”</i> she pushes her breasts together with her hands and starts to move them up and down. \n\nHelena, as with everything else in her life, is very diligent with her tit job, and when the your cock manages to slip away from her tits for a brief moment she makes sure to lick it before going back to please you with her bosoms. \n\nAfter few minutes of raw pleasure,you tell her that you want to cum.\n\n<i>“Jeez, so fast? Fine, just do it, filthy scum.”</i>\n\nShe increases her pace, and in a minute you start to spurt your load all over her. \n\nThe first two jets of cum hit her in the face, which make her giggle, while the others start to hit her in the neck and upper chest, making a small pool of cum in between her chests. \n\n<i>“Ugh...  damn, that was a lot, you’re so easily pleased.”</i> \n\nShe keeps your dick in it’s current place until it goes soft again, fully relieved. \n\nAlthough drenched in cum, she doesn’t mind much.\n\n<i>“Now I need to take a bath, alright. You already got your treat, so go back to your duties.”</i> she orders you before going away. ";
					} else {
						Board.text += "\n\n<i>“Come on, suck on them!”</i> she asks, urging you to be more agressive.\n\nWithout further ado you lean forward and start to suck on one while playing with the other. Helena moans, her sensitive body reacting strongly to your caresses. \n\nYou make sure to suck and play with both nipples, massaging its silky and warm skin, and complimenting her beautiful body. \n\n<i>“Heh, of course you love me and my body, now keep going!”</i> \n\nExcited by your words, she grabs you by the head and pulls you closer to her, smothering you with her breasts for a moment. \n\nYou start to play faster and harder, and not long after she has a brief, intense climax.\n\n<i>“Ahhh... Good. That was good. Now that you got your treat go back to your daily duties.”</i> satisfied, she turns around and goes away. She doesn’t show it, but she is clearly pleased with these recent developments, and you can’t wait to have more fun with her later on.";
					}
				} else {
					Board.text = "Helena’s breasts are big and generous, but still, they can always be bigger!\n\nOnce you call her it doesn’t takes long until she arrives into your chamber.\n\n<i>“My liege, how should I serve you today?”</i> She bows, and although she has a nice cleavage, you start to day dream about how big that’s about to get.\n\nYou tell her that you have something for her. \n\n<i>“Oh? What it is?”</i> she opens her eyes, excited, until you hand her the potion. <i>“Oh, this again? But aren’t these already too big?”</i> she says while holding her breasts with her hands.\n\nYou tell her that what she has is nice, but they could even be nicer. <i>“W-Well, if you insist...”</i> she takes the potion from your hand and gulps it, with a little bit of hesitation.\n\nIt takes a minute, but once it starts to affect her she exposes her chests and grabs her breasts. \n\n<i>“D-Don’t worry! It’s not that bad!”</i> she tells you, although you can see the pain in her face. \n\nYou love to see these changes, and it always amazes you than in just few minutes they can grow so fast. When done, she can barely grab them with her hands.\n\n<i>“Ahhh... t-this is what you wanted "+ GameControl.playerName+"?”</i> you nod happily, and ask if you can grab them. \n\n<i>“W-Well, if that’s what you want...”</i> \n\nShe removes her hands and stands straight. You immediately start to play with them: They are heavy, nice and soft, and her nipples have become really sensitive, to the point that she can’t help herself but moan when you pinch one of them. ";
					if (GameControl.dick1Size > 0) {
						Board.text += "\n\n<i>“W-Want me to use them to... you know...”</i> she says, pointing at your dick.\n\nWithout further ado you agree with her suggestion and remove your clothes, showing her your raised mast. \n\n<i>“Oh, you really love big breasts my liege... very well, let me indulge you.”</i> \n\nShe kneels down and starts to jerk you off first, using the pre and her own saliva to lubricate her tits. \n\nOnce they are nice and wet, she takes your cock and puts it in between them.\n\n<i>“Do you like how it feels?”</i> you love how silky and soft its her skin, and its warm keeps you aroused.\n\n<i>“Heh, then let me do something that will feel even better...”</i> she pushes her breasts together with her hands and starts to move them up and down. \n\nHelena, as with everything else in her life, is very diligent with her tit job, and when the your cock manages to slip away from her tits for a brief moment she makes sure to lick it before going back to please you with her bosoms. \n\nAfter few minutes of gentle pleasure, you tell her that you want to cum. \n\n<i>“Please my liege, just release when you need to.”</i> \n\nShe increases her pace, and in a minute you start to spurt your load all over her. \n\nThe first two jets of cum hit her in the face, which make her giggle, while the others start to hit her in the neck and upper chest, making a small pool of cum in between her chests. \n\n<i>“Heh, that was a lot, I’m glad you liked that my liege.”</i> \n\nShe keeps your dick in it’s current place until it goes soft again, fully relieved. \n\nAlthough drenched in cum, she doesn’t mind much.\n\n<i>“Don't worry my liege, I’ll take a bath, you can go back to your duties... and thank you again for this gift.”</i> She smiles, before going away. ";
					} else {
						Board.text += "\n\n<i>“D-Do you want to suck on them?”</i> she shyly asks, and you nod. \n\nWithout further ado you lean forward and start to suck on one while playing with the other. Helena moans, her sensitive body reacting strongly to your caresses. \n\nYou make sure to suck and play with both nipples, massaging its silky and warm skin, and complimenting her beautiful body. \n\n<i>“Ah! T-Thanks my liege, it makes me happy that you like them!”</i> you can see how red she is, both by her arousal and ashamed by your kind words. \n\nYou are happily surprised when you feel her hand at the back of your head, running her fingers through your hair.\n\nEncouraged, you keep groping her with tongues and hands, with a little bit of biting until, not long after, she has a brief, intense climax. \n\n<i>“Ahh... m-my liege, that felt great... thanks for giving me this body...”</i> satisfied, you tell her to go back to her duties.";
					}
				}
			}else {
				Board.text = "<i>“Do you want me to have bigger breasts? Very well my liege, if you insist.”</i>\n";
			}
			itemRemove = true;
			HelenaTransformation.increaseBreasts ();
			break;
		case 106: // virilitax
			if (NPCCharList.CharFollower [iHelena].dickSizeCM >= 50) {
				Board.text = "<i>“My liege my dick is as big as it can get! I barely can walk as it is!”</i>";
				return;
			} else if (NPCCharList.CharFollower [iHelena].dickSizeCM < 5) {
				if (NPCCharList.CharFollower [iHelena].charCorruption >= 66 && NPCCharList.CharFollower [iHelena].attWillpower >= 66) {
					Board.text = "Helena has changed, but still there is something missing, something that could add to her new more lewd and twisted personality.\n\nWith her new dominant personality she already sodomizes half of the castle, so why not give her an actual cock to take care of these things personally instead of using a strap? ";

					if (WorldControl.tagControl [5]) {
						Board.text += "\n\nYou call her into your chambers: When she arrives you can see that she is smeared with cum, and before she addresses you she takes a handful of cum from her face and licks it in front of you. \n\n<i>“Open wide, bitch.”</i> you open your mouth and let her spit the cum from who knows who right into it. \n\n<i>“Swallow.”</i> with a loud gulp you do as she says. \n\nShe laughs <i>“Now, what do you need me for?”</i>";
					} else {
						Board.text += "\n\nYou call her into your chambers: When she arrives you can see she already has her strap ready to go. \n\nShe smiles <i>“Hope you have called me her to get your ass wrecked, otherwise don’t waste my time.”</i>";
					}
					Board.text += "\n\nYou hand her the potion <i>“Oh, is this?... This is such a nice gift, I definitely will take it.”</i> she immediately opens the bottle and drinks its contents. \n\nShe twists in pain, but manages to hold herself up, bearing it all. You ask if she is fine, but she cuts you off before you can finish. <i>“S-Shut up! D-Don’t distract me now!”</i> she rips her skirt apart, exposing her pussy, and you can see how a dick starts to grow above it.\n\nAt first it just looks like an immense clitoris, but soon it begins to form a phallic shape, while two considerable balls grow underneath it. \n\nThe dick is sizable, and although it definitely could satisfy anyone, it just maintains an average size, and nothing more. \n\nYou would think the effort from growing a penis would exhaust anyone,but Helena is very excited; her new cock is rigid and throbbing, and you can see thick drops of precum at it’s tip. \n\n<i>“Ahh... Ahh... Now bend over "+ GameControl.playerName+", right now, I’m going to take your ass!”</i>\n\nYou quickly turn around and before you can undress yourself she rips your clothes apart, exposing your anus.\n\n<i>“Here I go!”</i> there is no foreplay nor love, just primal lust. Her cock is dripping so much precum that she doesn’t need to lube up before drilling inside of you.\n\nShe furiously thrusts you with her erect cock, panting, the lewd noises loud enough to keep anyone who hears them to stay out of the room.\n\n<i>“Ngh! T-This is great! If I knew a having a cock felt this good, I would had got one time ago!”</i> she relentlessly fucks you, but it doesn't takes long until her new sensible dick is on the edge. \n\n<i>“Here it goes! My first load of cum! I’m gonna get your ass pregnant!”</i> and just like that, you feel globs of cum flood your rectum.\n\nHer amount produced is amazing, and you manage to climax as Helena expends herself.\n\nAfter a minute of pleasure, the two of you fall on top of each other, exhausted, but happy. ";
				} else if (NPCCharList.CharFollower [iHelena].charCorruption >= 66) {
					Board.text = "Helena has changed: The once prude and shy maid has now become one of your lewdest servants.\n\nGranted, she is still very quiet, but that’s because of her submissive personality, not because she is afraid of exhibit herself. \n\nStill, there is something missing, something that could still improve her current self, and you have just the right thing.";

					if (WorldControl.tagControl [5]) {
						Board.text += "\n\nYou call her into your chambers: When she arrives you can see that she is smeared with cum, no doubt the result of servicing half of your castle with all her tools at her disposal. ";
					} else {
						Board.text += "\n\nYou call her into your chambers: When she arrives you can see her face is red and her hands shaking a little bit. Since she got corrupted, she’s aroused all the time, and you’re the only thing that can satiate her.";
					}
					Board.text += "\n\nShe respectfully bows, showing you her cleavage <i>“What can I do for you my liege?”</i>\n\nYou hand her the potion. <i>“O-Oh... this is... you want me to drink this?”</i> you happily nod.\n\n<i>“Very well my liege, if this is your wish...”</i>\n\n<i>“Well, Here it goes...”</i> she finishes the sour tasting liquid in a single gulp. At first, nothing happens, but it doesn’t takes long until she falls to her knees.\n\nYou immediately ask if she is in pain and try to take her, but she raises her hand <i>“I-I’m fine! D-Don’t worry "+ GameControl.playerName+"!”</i> she rips her skirt apart, exposing her pussy, and you can see how a dick starts to grow above it.\n\nAt first it just looks like an immense clitoris, but soon it begins to form a phallic shape, while two considerable balls grow underneath it. \n\nThe dick is sizable, and although it definitely could satisfy anyone, it just maintains an average size, and nothing more. \n\nYou would think the effort from growing a penis would exhaust anyone,but Helena is very excited; her new cock is rigid and throbbing, and you can see thick drops of precum at it’s tip. \n\n<i>“Ahhh... P-Please "+ GameControl.playerName+", it... It feels weird! W-What should I do?”</i> considering her state right now, having her jerk off might not be a good idea. You kneel in front of her. \n\n<i>“W-What are you doing?”</i> you smile and tell her to calm down, and you laugh when a shot of precum hits you in the face; apparently right now even your breath its too much for her new body. \n\nWithout further ado you decide to get your hands dirty, or in this case your mouth, by taking her tip in your mouth. \n\nYou enjoy the taste of her precum while you pleasure her cock for the first time, taking her whole length until her balls slap against your chin.\n\n<i>“Ahh! T-This is too much! It feels too good "+ GameControl.playerName+"!”</i> she yells while you service her, and soon you feel her throbbing cock at it’s limit: your skill too much for the young maid. \n\n<i>“Ahh! T-Take it out! S-Something’s coming!”</i> she kindly warns you, but you ignore her and keep going.\n\nYou feel the salty and warm nectar coming from her new balls straight into your mouth, and enjoy swallowing her first true load of cum. \n\nIt’s thickness and flavor is something else, no doubt thanks to the alchemy involved, and you can’t help but to use your tongue to play with it for a minute before you gulp it all.\n\nWhen done, you can see Helena’s asleep, with a broad smile on her face: No doubt she enjoyed this first time.\n\nYou take her and put her on the bed, letting her recover herself while you go back to your daily duties.";

				} else {
					Board.text = "You’ve been thinking about Helena, and although you find her fascinating, you think there is something missing. \n\nAfter getting all the supplies you need, you call her into your chamber. <i>“My liege, what is what you need?”</i> she asks, wondering what task you have for her, still unaware of what you’re about to ask.\n\nWith a smile on your face you hand her the potion. \n\n<i>“What is this? Is this?... Ohh...”</i> her face turns red, and she almost drops the small bottle. \n\n<i>“W-What is this for?”</i> she nervously asks. You tell her that what you desire is obvious, and if she is fine with it.\n\n<i>“W-Well, I never thought about it... but if this is what you want, I’ll do it...”</i> she opens the bottle, and reluctantly brings the bottle to her lips.\n\n<i>“Well, Here it goes...”</i> she finishes the sour tasting liquid in a single gulp. At first, nothing happens, but it doesn’t takes long until she falls to her knees.\n\nYou immediately ask if she is in pain and try to take her, but she raises her hand <i>“I-I’m fine! D-Don’t worry "+ GameControl.playerName+"!”</i> she rips her skirt apart, exposing her pussy, and you can see how a dick starts to grow above it.\n\nAt first it just looks like an immense clitoris, but soon it begins to form a phallic shape, while two considerable balls grow underneath it. \n\nThe dick is sizable, and although it definitely could satisfy anyone, it just maintains an average size, and nothing more. \n\nYou would think the effort from growing a penis would exhaust anyone,but Helena is very excited; her new cock is rigid and throbbing, and you can see thick drops of precum at it’s tip. \n\n<i>“Ahhh... P-Please "+ GameControl.playerName+", it... It feels weird! W-What should I do?”</i> considering her state right now, having her jerk off might not be a good idea. You kneel in front of her. \n\n<i>“W-What are you doing?”</i> you smile and tell her to calm down, and you laugh when a shot of precum hits you in the face; apparently right now even your breath its too much for her new body. \n\nWithout further ado you decide to get your hands dirty, or in this case your mouth, by taking her tip in your mouth. \n\nYou enjoy the taste of her precum while you pleasure her cock for the first time, taking her whole length until her balls slap against your chin.\n\n<i>“Ahh! T-This is too much! It feels too good "+ GameControl.playerName+"!”</i> she yells while you service her, and soon you feel her throbbing cock at it’s limit: your skill too much for the young maid. \n\n<i>“Ahh! T-Take it out! S-Something’s coming!”</i> she kindly warns you, but you ignore her and keep going.\n\nYou feel the salty and warm nectar coming from her new balls straight into your mouth, and enjoy swallowing her first true load of cum. \n\nIt’s thickness and flavor is something else, no doubt thanks to the alchemy involved, and you can’t help but to use your tongue to play with it for a minute before you gulp it all.\n\nWhen done, you can see Helena’s asleep, with a broad smile on her face: No doubt she enjoyed this first time.\n\nYou take her and put her on the bed, letting her recover herself while you go back to your daily duties.";
				}
			} else if (NPCCharList.CharFollower [iHelena].dickSizeCM >= 36) {
				if (NPCCharList.CharFollower [iHelena].charCorruption >= 66 && NPCCharList.CharFollower [iHelena].attWillpower >= 66) {
					Board.text = "You know Helena’s dick pretty big, but it can be even bigger, though not by much. \n\nAfter acquiring one of these growth potions you call Helena into your chambers. The maid arrives in to time, yet maintains a slightly irritable personality.\n\n<i>“You better have a good reason for-”</i> she enters the room angry, but pauses when she sees the potion in your hand <i>“So is that so? You want me to be packing even more? You’re a truly insatiable fucker.”</i> \n\nHelena takes the potion from your hand and drinks it, almost with glee. \n\nThis time the pain is not as extreme as when she growth it for the first time, and although Helena looks uncomfortable it’s nothing she can’t handle.\n\nSoon enough her cock has becomes bulged and erect, as big as it will get, dripping precum, her balls filled to the brim with jizz. \n\nShe has a lecherous smile across her face when her dick is done growing <i>“Ahhh... It feels great, but now is time to put it to work. Come on, you know what to do.”</i>\n\nOf course thinking you could change Helena like this and not getting your ass fucked is out of the question, although you’re starting to think maybe she could be too big for you...\n\nA minute later you are naked and bending over, and this time actually Helena is actually using <b>a lot</b> of lube, just to make sure you don’t get <i>too</i> hurt in the process.\n\n<i>“That’s how I like it: submissive and tamed!”</i> she approaches you from behind and puts the tip on your back door entrance.\n\n<i>“Afraid? You shouldn’t be, this is what you wanted!”</i> she starts to push forward.\n\nSlowly, she makes way through your anus, her tip is so thick that you can barely take it, but somehow it doesn’t hurts as much as you thought it would, maybe it has something to do with the alchemy used. \n\n<i>“Nghh! You’re so tight! L-Let’s see if I can fit the whole thing inside!”</i> she grabs you from your hips and starts to thrust again.\n\nWhen half of it is inside you feel as full as you could be, and you’re afraid you wouldn’t be able to take more, even if it doesn’t hurts <i>much</i>.\n\n<i>“Ahh... Come on, I’ll go full in now, and you better enjoy it!”</i>\n\nShe grabs you with force and starts to move again, eagerly trying to go all the way in. You can feel how your stomach bulges, and you can’t believe it when you finally feel her balls hitting your ass. The size of her starts to actually concern you slightly.\n\n<i>“See! Told ya! Now comes the fun part!”</i> you freeze for a moment, and before you can react Helena is already taking half of it out just so she can put it back inside in a single thrust.\n\n<i>“Ngh! This is amazing! I never felt something like this! I’ll fuck you all night long "+ GameControl.playerName+"!”</i> she starts to increase her pace, faster and faster. \n\nThe slapping sound of her balls against you sound so loud, and you can’t contain your own moans. It’s an amazing show how your stomach deforms with each assault, just to take it’s normal shape a moment later. The pain endured is worth it for the amazing pleasure gained.\n\nAlthough Helena promised you to fuck you for the whole night, after few minutes she is already on the edge of her climax, and unable to contain herself more, she releases inside you. The potion’s effects on her sensitivity has clearly knocked her endurance down.\n\n<i>“Take my cum "+ GameControl.playerName+"! I’m going to cum so much I’ll get your fucking ass pregnant!”</i> she yells when the first spurt of jizz starts to fill you, and although she may not get your ass pregnant, there is no doubt that she is cumming like a hose, even inflating your stomach a little bit when she fills you to the brim, the perversity of such act making you climax too. \n\nWhen Helena is finally done she steps aside and let’s you fall to the ground; your asshole is wide open, oozing cum spilling from it.\n\n<i>“Ahh... T-That’s a nice view...”</i> says Helena, before collapsing onto your bed, exhausted by the experience.\n\nYou, not faring any better, pass out on the ground. \n\nAt least you can’t deny this is another level of satisfaction.";
				} else {
					Board.text = "You know Helena’s dick pretty big, but it can be even bigger, though not by much. \n\nAfter acquiring one of these growth potions you call Helena into your chambers. The maid arrives in to time, always thoughtful about your needs.\n\n<i>“Yes my liege, is there- oh...”</i> she notices the small bottle in your hand. <i>“Want me to drink that again? B-But I’m not too big, am I? Won’t it hurt you?”</i> you tell her that she has nothing to worry about.\n\n<i>“W-Well, if you insist...”</i> As she knows how this goes, she removes her skirt and quickly gulps the potion, taking only a minute to make her body change.\n\nThis time the pain is not as extreme as when she growth it for the first time, and although Helena looks uncomfortable it’s nothing she can’t handle.\n\nSoon enough her cock has becomes bulged and erect, as big as it will get, dripping precum, her balls filled to the brim with jizz. \n\n<i>“P-Please help me out "+ GameControl.playerName+"!”</i>\n\nShe help her stand straight before you kneel in front of her. \n\nHer cock is so big now that your two hands can grab onto it and still not completely cover it.\n\nOf course, having such a wonderful cock in your hands is not enough, and you begin to envelop it with your mouth. \n\nYou struggle with the oral ordeal, taking only the tip in your mouth and playing with it with your tongue while your hands take care of jerking her off. \n\n<i>“Ah! T-That’s nice "+ GameControl.playerName+"! That feels good!”</i> Helena praises your skills while you keep toying with her meat, which doesn’t takes long until it’s ready to spurt.\n\n<i>“I-I’m cumming "+ GameControl.playerName+"!”</i> you keep jerking her but take some distance, aiming the tip to your face while you open your mouth.\n\nAs expected, the first enormous load shoots right into your face, drenching you all over. You’re forced to swallow an entire mouthful of her jelly-like cum, and when she is done, your whole head and chest are covered in jizz.\n\n<i>“Ah... T-Thank you a lot "+ GameControl.playerName+", that really helped...”</i>\n\nYou take her to your bed and let her rest there, while you go an take a shower.";
				}
			}else {
				Board.text = "<i>“If this is what you want, I'll do it, my liege.”</i>\n";
			}
			itemRemove = true;
			HelenaTransformation.increaseDick();
			break;
		case 126: // death bosom
			if (NPCCharList.CharFollower [iHelena].breast1Size <= 0) {
				Board.text = "<i>“I don't have any breasts! Using this potion right now would be a waste!”</i>";
				return;
			} else {
				Board.text = "<i>“Are my breasts too big? Well, at least is easier to clean without these in my way.”</i>";
			}
			itemRemove = true;
			HelenaTransformation.decreaseBreasts();
			break;
		case 131: // betaX
			if (NPCCharList.CharFollower [iHelena].dickSizeCM <= 0) {
				Board.text = "<i>“My liege drinking this potion would be a waste, I don't have anything to remove!”</i>";
				return;
			} else {
				Board.text = "<i>“You don't like it's current size? Let me fix it for you then.”</i>";
			}
			itemRemove = true;
			HelenaTransformation.decreaseDick();
			break;
		case 200: // jewelry
			if (NPCCharList.CharFollower [iHelena].charRelationship < 50) {
				Board.text = "<i>“This is for me " + GameControl.playerName + "? Thanks a lot! You shouldn't have!”</i>\n";
				relationshipChange (0);
			} else {
				Board.text = "<i>“Thanks a lot for the gift! But you have gave me so much that I feel like embarassed that I can't give you anything back...”</i>";
				relationshipChange (1);
			}
			itemRemove = true;
			break;
		case 201: // fancy
			if (NPCCharList.CharFollower [iHelena].charRelationship < 50) {
				Board.text = "<i>“These are amazing " + GameControl.playerName + "! I'll wear them right now!”</i>\n";
				relationshipChange (0);
			} else {
				Board.text = "<i>“" + GameControl.playerName + " you have bought me so many clothes and things! You don't have to worry about it! Still, I'm really happy for this!”</i>";
				relationshipChange (1);
			}
			itemRemove = true;
			break;
		case 202: // luxury goods 
			if (NPCCharList.CharFollower [iHelena].charRelationship < 50) {
				Board.text = "<i>“These things are so pretty " + GameControl.playerName + "! Thanks a lot!”</i>\n";
				relationshipChange (0);
			} else {
				Board.text = "<i>“You don't have to worry " + GameControl.playerName + "! I have a lot of things already! Still, I'm happy that you are so considerate with me!”</i>";
				relationshipChange (1);
			}
			itemRemove = true;
			break;
		case 203: // perfume
			if (NPCCharList.CharFollower [iHelena].charRelationship < 50) {
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

			if (NPCCharList.CharFollower [iHelena].charRelationship < 50) {
				relationshipChange (0);
			} else {
				relationshipChange (1);
			}
			itemRemove = true;
			break;
		case 205: // chocolate box 
			Board.text = "<i>“Ah chocolates! They look great " + GameControl.playerName + "! I'm going to eat them right now!”</i>\n";

			if (NPCCharList.CharFollower [iHelena].charRelationship < 50) {
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
			if (NPCCharList.CharFollower [iHelena].heightChar < 365) {
				Board.text = "Do you want me to be bigger? Okay, I'll drink it.";
				itemRemove = true; 
				NPCCharList.CharFollower [iHelena].heightChar += 30; 
			} else {
				Board.text = "I cannot grow taller, "+ GameControl.playerName+".";
			}
			break;
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



	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		transformationPanel.sortingOrder = -500;
		outfitPanel.sortingOrder = -500;
		panEndTurn.sortingOrder = 500;
	}

	void relationshipChange(int selector){
		Random.InitState (WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime +2); 

		if (selector == 0) { // for when rel is low
			NPCCharList.CharFollower[iHelena].charRelationship += Random.Range (1.5f, 5f);
			NPCCharList.CharFollower[iHelena].charLoyalty += Random.Range (0.5f, 2f);
		}

		if (selector == 1) { // for when rel is high 
			NPCCharList.CharFollower[iHelena].charRelationship += Random.Range (1f, 3f);
			NPCCharList.CharFollower[iHelena].charLoyalty += Random.Range (0.5f, 1.5f);
			NPCCharList.CharFollower[iHelena].charLove += Random.Range (0.5f, 1.5f);
		}

		if (selector == 2) { // shitty gift 
			NPCCharList.CharFollower[iHelena].charRelationship += Random.Range (0.3f, 2f);
			NPCCharList.CharFollower[iHelena].charLoyalty += Random.Range (0f, 1f);
		}

		if (NPCCharList.CharFollower [iHelena].charRelationship > 100) {
			NPCCharList.CharFollower[iHelena].charRelationship = 100;
		} 
		if (NPCCharList.CharFollower [iHelena].charLoyalty > 100) {
			NPCCharList.CharFollower[iHelena].charLoyalty = 100;
		} 
		if (NPCCharList.CharFollower [iHelena].charLove > 100) {
			NPCCharList.CharFollower[iHelena].charLove = 100;
		} 

	}


	public void Outfits(int selection){
		loadHelena ();
		switch (selection) {
		case 0: // maid normal
			HelenaTransformation.helenaOutfitMaid ();

			if (NPCCharList.CharFollower [iHelena].attWillpower >= 66) {
				Board.text = "Dressing like a proper lady from time to time isn't that wrong. I'll do it just because you got me in a good mood today, so don't get used to it.";
				endTurnFun ();
				return;
			}
			if (NPCCharList.CharFollower [iHelena].charCorruption < 66) {
				Board.text = "<i>The most proper uniform, but of course my liege.</i>";
			} else {
				Board.text = "<i>Isn't this a little too boring? Well, you're the boss.</i>";
			}
			endTurnFun ();
			break;
		case 1: // maid open
			if (NPCCharList.CharFollower [iHelena].attWillpower >= 66) {
				Board.text = "I love to show some skin, I feel so free and liberated. I'll follow this suggestion, but just because I like it.";
				HelenaTransformation.helenaOutfitMaidOpen ();
				endTurnFun ();
				return;
			}
			
			if (NPCCharList.CharFollower [iHelena].charCorruption < 40) {
				Board.text = "<i>My liege! This isn't proper for a lady like me! What would think the rest of the servitude?!</i>";
			} else {
				HelenaTransformation.helenaOutfitMaidOpen ();
				Board.text = "<i>Do you want me to expose my breasts? That would be lovely! Of course my liege!</i>";
				endTurnFun ();
			}
			break;
		case 2: // corrupt outfit 0
			if (NPCCharList.CharFollower [iHelena].attWillpower >= 66) {
				Board.text = "I’m sure you would like me to use a slave dress right? Sorry, you are the bitch now, but don’t worry I’ll get a proper dominatrix suit very soon, just for you...";
				return;
			}
			if (NPCCharList.CharFollower [iHelena].charCorruption < 66) {
				Board.text = "<i>My liege! I cannot wear this! It would disgrace me in front of the city and your other servants!</i>";
			} else {
				HelenaTransformation.helenaOutfitCorrupt0 ();
				Board.text = "<i>Do you want me to use something this kinky? Well, but of course my liege, it will be a pleasure...</i>";
				endTurnFun ();
			}

			break;
		case 3: // naked 
			if (NPCCharList.CharFollower [iHelena].attWillpower >= 66) {
				Board.text = "Nothing shows more confidence that being naked, I'll definitely will do it, but not because you are asked.";
				HelenaTransformation.helenaOutfitNaked ();
				endTurnFun ();
				return;
			}
			if (NPCCharList.CharFollower [iHelena].charCorruption < 100) {
				Board.text = "<i>My liege! I cannot go naked through the city! Imagine what will happen to me?! I just simply refuse!</i>";
			} else {
				HelenaTransformation.helenaOutfitNaked ();
				Board.text = "<i>Yes my liege! I love to be naked!</i>";
				endTurnFun ();
			}

			break;
		case 4: // Dominatrix
			if (NPCCharList.CharFollower [iHelena].attWillpower >= 66) {
				Board.text = "At least something fitting to me new self.";
				HelenaTransformation.helenaOutDominatrix ();
				endTurnFun ();
				return;
			}else {
				Board.text = "<i>S-Sorry my Liege, but I don't think this suits me!</i>";

			}

			break;

		default:
			break;
		}
	}



	void loadHelena(){
		iHelena = 0;
		while (iHelena < NPCCharList.CharFollower.Count)
		{
			if (NPCCharList.CharFollower [iHelena].charID == 3000 ) 
			{
				break; 
			}
			iHelena++;
		}
	}



}
