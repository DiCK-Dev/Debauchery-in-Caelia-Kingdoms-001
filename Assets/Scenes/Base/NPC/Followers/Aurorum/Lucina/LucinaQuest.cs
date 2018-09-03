using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LucinaQuest : MonoBehaviour {
	static int iLucina, iHelena, iAbbadon;
	public Text Board; 
	public Canvas endTurnPanel; 
	public Canvas panConfirmation;

	static int confirmationControl; 

	public Text option0Name;
	public Text option1Name;
	public Text option2Name;
	public Text option3Name;

	public Button option2Butt; 
	public Button option3Butt; 

	void questStart(){
		switch (QuestControl.lucinaQuest) {
		case 0://reunion
			NPCCharList.CharFollower [iLucina].charPortraitLayer0 = 6020;
			NPCCharList.CharFollower [iLucina].charPortraitLayer1 = 0;
			NPCCharList.CharFollower [iLucina].charPortraitLayer2 = 0;
			WorldControl.PortraitIDLayer0 = NPCCharList.CharFollower [iLucina].charPortraitLayer0;
			if (NPCCharList.CharFollower [iHelena].attWillpower >= 66) {
				Board.text = "You were working on the studio when suddenly Helena interrupts you, clearly angry with you. \n\n<i>“"+ GameControl.playerName+"! Haven’t you heard there is a monster in the castle? Go deal with it immediately!”</i> you nearly fall out of your chair at the sudden announcement… Although you heard some guards and servants yelling, such things aren’t unusual thanks to Helena daily punishments. \n\nReadying your weapon you ask Helena which kind of monster it is. <i>“It’s a slime girl. It looks very similar to your nanny too, and it’s not attacking anybody, just wandering the castle as if it was her own. Go investigate what it’s going on, now!”</i>\n\nAlthough you’re blinking in confusion, you nod at your mistress and hurry to face the mystery creature. Once in the courtyard you see a smiling woman… it’s true, the resemblance to your nanny is uncanny… at least as much as you remember from your childhood. \n\nAlthough she isn’t hostile she takes an instinctual combat stance when you try to approach her. Should you fight her or try to soothe her down?\n\n\n";
			} else {
				Board.text = "You can hear the hurried footsteps and yelling of Helena, who is rushing for your office. She slams the door open and tries to tell you something, but she is out of breath and too shocked to do so. You tell her to calm down and breath before she speaks again. \n\n<i>“Ahh.. Ah... My liege there is no time for that!... there is ah... a monster in the castle!”</i> Concerning sure, but you simply ask her to send guards to deal with it.\n\n<i>“N-No my liege you don’t understand! I think — I mean... it looks like it’s your late nanny!”</i> Blinking in surprise, you ask if Helena is absolutely certain of that. <i>“W-Well everything is weird... it definitely has her appearance. It isn’t attacking anyone either, just wandering around, but it’s apparent that she knows the place too. I really think you should go and check it out yourself my liege!”</i> \n\nYou agree with her and go face the creature. Once in the courtyard you see a smiling woman… it’s true, the resemblance to your nanny is uncanny… at least as much as you remember from your childhood. \n\nAlthough she isn’t hostile she takes an instinctual combat stance when you try to approach her. Should you fight her or try to soothe her down?";
			}
			option0Name.text = "Fight her";
			option1Name.text = "Soothe her";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 0;
			break;
		case 1:
			WorldControl.day += 5;
			Board.text = "You and the servants have taken care of the recently “captured” monster. Although not really in captivity, she has been very tame… albeit erratic in her behavior, unable to speak or say much beyond your name.\n\nThere hasn’t been a way to conclusively answer the question: Is this monster just a slime that’s consumed your nanny? Or is this monster quite literally her? Although uncommon, it’s not impossible for humans to turn to slimes. Being unsure of such a matter makes it far more challenging to decide what to do with her. You’ll just have to wait until you can develop some kind of proof. \n\nThis morning you wake up thanks to the alarmed scream of one of your servants. You rush out of your room to find the monster wandering around, attacking everyone on her path. Admittedly her batting hands do no real harm to any of them; you’re not even sure she raises a bruise on one of your small servant girls.\n\nYou confront her regardless, weapon ready to strike. She stops before you, form quivering as she starts to cry <i>“"+ GameControl.playerName+"... help me... save me...”</i> you can see that for a split second in her reflection fresh semblance of your nanny, before she collapses to the ground.\n\nFiguring that enough is enough, you gather any specialists in town you can find, consulting on the matter. The conclusion would be that this slime is <i>actually</i> your nanny but the process of transformation broke some portion of her mind.\n\nThere is no strict cure for amnesia sadly, the only hope you would have of restoring her memories or helping to rebuild her personality will involve doing things with her. Conversations, visiting locations that she knows well, and attempting to re-educate her may prove helpful. One of your court, however, has a slightly more sinister recommendation; why not educate the monstrous portion of her nature? She’s well connected to you, and would make for a very loyal beast.\n\nYou take a day to meditate upon your options. Right now she is of no use to anyone, and she is clearly in pain. You could try to make her a productive member of your city. Either helping her to recover her former memories or possibly re-educating her into something more suited to your needs, but still capable of talking and following orders. On the other hand, you could just tame her as the monster that she is and keep her as a glorified pet to use at will, with no more intelligence than a willing fuck-animal. \n\nWhich should you do? To help her recover her sanity? Or to reinforce her instincts? ";
			option0Name.text = "Sanity";
			option1Name.text = "Instincts";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 2;
			break;
		case 2:
			WorldControl.day += 2;
			Board.text = "It’s been a couple of days since you’ve started to help Lucina to recover her mind. The both of you had toured the castle many times while you’ve shared old and fond memories you have with her. Although she still mumbles her way through a number of these shared times she is more reactive now; laughing, smiling, crying. Important progress, you would say.\n\nToday when you visited her quarters you find that the place is a gooey mess, everything drenched in her bodily fluids. You find her resting on her bed, but she looks sick and dizzy. When you sit at her side, she gives you her hand and talks to you.\n\n<i>“Nhgg... what’s going on...”</i> The tone of her voice has you immediately bolting upright; standing and grabbing her by the shoulders you ask her to repeat herself. <i>“"+ GameControl.playerName+"? Is that you?! Is really you?! You... you are so old now!”</i> she embraces you, crying but finally a little bit conscious. \n\nYou tell her that yes, it’s you, and ask her what she can remember <i>“Oh my "+ GameControl.playerName+"! I’m so happy to see you! I... I don’t remember much... my memory is all foggy. I remember you, I remember leaving a city... a forest. It’s a little hazy but I remember a monster attacking me… and then I don’t know. It’s like I’ve been a prisoner in a very dark place. I don’t know how long for, but it felt like years.”</i> \n\nShe is shaken and likely on the verge of shock, but you hug her again, telling her she has nothing to worry about; she’s home. Once she finally seems to calm down you’re about to ask her a question, but she attempts to hug you before pausing in shock. <i>“No! W-What is this?! Why... why are my hands, my body, like this?! What’s going on?! I’m... I’m a monster now!”</i> she tries to stand up and run, but you grab her by the shoulders (as much as you can, at least) and keep her in place, telling her if she remembers anything about the past. \n\n<i>“N-No, I already told you everything I remember... yeah, that much...”</i> you tell her that years ago people started to transform and change into different beasts and monsters, and that she probably got caught by one and transformed too. \n\n<i>“Is... do you have a cure for this "+ GameControl.playerName+"?”</i> you shake your head, but tell her what matters now is to focus on recovering her memories, not her body. She starts to cry, and you let her do so until she finally vents her current emotions.\n\n<i>“I see "+ GameControl.playerName+"... you — you will help me right?”</i> you give her a reassuring smile and tell her that of course, that’s what you been doing these past days after all. \n\n<i>“Thanks "+ GameControl.playerName+", I knew I could count with you... I wish I could tell you more about what happened, maybe that would help! But I am of no use... just do your best to help me, and I’ll do my best to recover too.”</i>\n\nThe heart-warming moment is somewhat disturbed by a tentacle snaking around and starting to grope your ass. You realize it’s likely an unconscious action from her slime-body instincts. You could just let her touch you and maybe see how far you can go touching her too, or you could just leave the room and get ready for what will come next. \n";
			option0Name.text = "Grope";
			option1Name.text = "Part away";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 3;
			break;
		case 3: // fragmented memories
			WorldControl.day += 1;
			Board.text = "The first thing you need to do to help your mother/nanny is to remind her of who she was. Although you yourself don’t remember much, since you were a child when you had to escape to the forest.\n\nWhile looking for a cure for your mother in the laboratory you stumbled upon a diary with her name on it. Apparently some kind of trophy saved by your late uncle. Through it you’re able to glean her thoughts and feelings… at least up until her reaching the uprising, and your uncle’s takeover.\n\nObviously this would be the perfect tool to restore your mother/nanny’s memory, but a dark thought crosses your mind: What if you were to write a fake one, where you portray her as a slut? You could abuse her current mental state and alter her personality to one that may suit your needs more. \n\nYou sit and weigh out your options: Her real personality is royal and very motherly to those who are close to her. She was a respected and well-loved figure in the city. But you could turn her into a perfect concubine; a shape shifter mother/nanny that would be the envy of everyone, and ready to satiate your lust and needs whenever you want. Merely at the cost of a former self she doesn’t remember being.\n\nAfter meditating for an hour, you decide that the best thing to do would be...\n\nNOTE: There are 3 endings for these routes. If you pick her real personality you can still decide between keeping her pure or corrupt her, while changing her is a corrupt only story. Changing her also has public use (although this is either optional or can be disabled), so be aware. ";
			option0Name.text = "Real self";
			option1Name.text = "Change";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 4;
			break;
		case 4: // Tales from the past, royalty
			NPCCharList.CharFollower [iLucina].attMorality = 100;

			NPCCharList.CharFollower [iLucina].charPortraitLayer0 = 6000;

			WorldControl.day += 3;
			NPCCharList.CharFollower [iLucina].charCorruption = 25;
			panConfirmation.sortingOrder = 500;
			Board.text = "After Lucina finished reading her diary you can see clearly that her memory has become more stable, and her personality is clearly akin to her former self. She moves with a far more noble demeanor, and her expression is motherly and warm.\n\nHer current progress makes her cheerful and happy, but she is nervous again when you tell her that it’s time to visit the city. \n\n<i>“Y-you think... the city will accept me? Even if I’m a monster now?”</i> Smiling, you grab her hand and tell her that she should calm down, the city already has people that have been transformed. If they can tolerate a bitch like Alba, they would certainly accept a loving person like her.\n\n<i>“Thats reassuring, I think... then please, lead the way "+ GameControl.playerName +".”</i> the two of you leave the castle and walk through the city. You visit the market, park, and a number of other places. They don’t evoke any strong reactions out of her though until she sees the burned church. \n\n<i>“What... What happened here "+ GameControl.playerName +"? The church was beautiful and now it’s nothing but ashes...”</i> you tell her that you weren’t here when that happened, but you’ve been told that it was during the plague outbreak. There’s still plenty of work to do, and the city is still waiting for a pure soul to take care of rebuilding it again. \n\n<i>“That’s awful my dear! N-No wonder that the city is having such troubles without any spiritual guidance!”</i> You can see she is distressed, so you calm her with a hug and guide her back to the castle and into her chamber.\n\nThe church is till on her mind even once she’s settled down again though. <i>“I wish I could do something about it, about the church... But with this body, what kind of example would I be?”</i> she sits down on the bed, saddened. \n\nYou know this is a personal issue for her, but also an important opportunity for you. Should you console her and tell her that the church will be built again? Or tell her that she should just look forward? That the world is changing and there is no need to let the past hold us back?";
			option0Name.text = "Console";
			option1Name.text = "Changing world";
			confirmationControl = 5; 
			break;
		case 5: 
			NPCCharList.CharFollower [iLucina].charPortraitLayer0 = 6000;

			WorldControl.day += 2;
			Board.text = "You visit Lucina in her chamber. The last visit through the city helped her to remember part of her past. Even though the experience wasn’t as cheerful due to the current situation of the city, she is now eager to talk with you again and to learn more of the city’s state.\n\nWhen you knock at the door it immediately opens. Who knows for how long has Lucina been standing at the other side just waiting for you to come, but her excitement is proof of her steady recovery.\n\nYou enter and the two of you sit on her bed. \n\n<i>“"+ GameControl.playerName +", I have so many questions to ask, I hope you are not troubled by that.”</i> you shake your head and tell her that you’ll answer as best as you can, but you also didn’t live in the castle for a long time so a lot of your knowledge comes from books and hearsay. \n\nShe asks you about what happened to you after you had escaped the city when your uncle took over and you tell her about your life in the hut with your guardian, struggling to survive. \n\nAfter that she asks you about the outbreak, since she doesn’t remember much. You tell her that this happened many years after you went into hiding, and that no one knows exactly why it happened but it is obvious that it was the work of an alchemist. \n\nYou can see that she is uneasy when you talk about alchemy and you wonder if it has something to do with your uncle and his secret laboratory, but you’d rather not mention it... for now.";
			if (GameControl.charCorruption >= 50) {
				Board.text += "At this point you start to tell her about what happened to the city — or at least what you know — and how things have changed since your arrival. You follow up with how you’ve improved things, but she doesn’t trust you. <i>“Darling... Please don’t be mad at me but I feel like something in you has changed... is everything all right?”</i> \n\nYou start to sweat, has she realized that you’ve been corrupted? <i>“... darling?”</i> you ponder your options: Should you tell her that not only you but the whole world has changed, and she as everyone else needs to learn to adapt to it? Or should you keep her hopes to bring the old world back alive?";
			} else {
				Board.text += "At this point you start to tell her about what happened to the city — or at least what you know — and how things have changed since your arrival. You follow up with how you’ve improved things, and although she is distraught she is happy too to hear that you are taking care of everything. <i>“Darling... I’m very proud of what you’re doing, and I’m sure everyone in the kingdom feels the same way.”</i> she leans forwards and hugs you. \n\nHer gentle touch makes you feel serene, but you know that you have in front of you a very important choice: Should you tell her that even though you’re doing your best to fix everything, change is inevitable? Or do you simply reassure her that the world will one day become what it used to be?";
			}
			panConfirmation.sortingOrder = 500;
			option0Name.text = "Change";
			option1Name.text = "Old ways";
			confirmationControl = 6; 
			break;
		case 6:
			WorldControl.day += 2;
			Board.text = "Today you invite Lucina to sit at your side while you do audiences in the throne room, asking her to help you deal with your subjects.\n\nShe cheerfully accepts and the two of you hear the complaints and troubles of many nobles and peasants. <i>“Oh "+ GameControl.playerName +" this really brings up memories from the past.”</i>\n\nAlthough she is excited the truth is that this is nothing but your everyday duty, and you find yourself bored as usual. But everything changes when your guards bring up a young lady that’s half naked and accused of masturbating in the middle of the city square.\n\nShe struggles with the guards but they force her to kneel down <i>“My liege! This... This is not my fault! Y-you know how things are now! I just can’t control myself!”</i> You can see that Lucina is uneasy with the case, but you still ask for her opinion. <i>“W-Well... That may be true "+ GameControl.playerName +", but the law is the law… I hate dishing out punishments, but it would be unfair to others to let her go without… don’t you agree?”</i>\n\nShe is partially right. True, that’s the law, but its also true that you are the law. If you wanted to change it and forgive this woman for her crime, it’s truly up to you. The corruption has brought this effect on to a great many people afterall. <i>“But what she did is indecent, and not punishing her would encourage others to do the same!”</i>\n\nYou sigh and ponder your options. You could forgive the girl in exchange of servicing you, or punish her as the law says and keep the order in the city. ";
			panConfirmation.sortingOrder = 500;
			option0Name.text = "Forgive her";
			option1Name.text = "Punish her";
			confirmationControl = 7; 
			break;
		case 7: // corrupt ending
			loadHelenaData ();
			loadAbbadon ();
			panConfirmation.sortingOrder = 500;

			NPCCharList.CharFollower [iLucina].isRecruited = true;


			string A1 = "pussy", A2 = "hard on", A3 = "your cunt is drenched", A4 = "fucking her cunt"; 
			string A5 = "You can feel her tentacles pulling you over until your face lands in between her breasts, soft as pillows. There, she starts to caress your head while you feel her tentacles exploring your body from top to bottom, even your more intimate spots. Her tentacles start to play with your nipples and clit, and your nanny stats to kiss you, her emotions a mix of love and lust. ";
			string A6 = "She holds you tight against her but you can feel how her tentacles are making her way inside of you, filling both of your holes, while she uses her mouth to keep your own too busy to even moan.";
			string A7 = "Her hot and amorphous body is amazing, since she can perfectly fill your insides, and is able to touch every single weak spot you have, even some that you didn’t even know you had. She starts to fuck you at a wild pace, the two of you yelling in pleasure, waking up Helena from her short slumber, who starts to masturbate at the scene. ";
			string A8 = "You lose the ability to concentrate on your surroundings and focus instead on your pleasure,, your eager pussy dripping all over your nanny’s. You can feel how your back starts to arch, and a powerful orgasm strikes you, making you tremble with pleasure while your nanny holds you in her arms, playing with your hair and kissing you until your climax has ended. ";
			string A9 = "";
			if (NPCCharList.CharFollower [iHelena].dickSize > 0) {
				A1 = "cock";
				A4 = "jerking her cock and fondling her balls";
			}
			if (NPCCharList.CharFollower [iAbbadon].dickSize > 0) {
				A2 = "cunt";
			}
			if (GameControl.dick1Size > 0) {
				A3 = "you have a raging erection";
				A5 = "You can feel her tentacles pulling you over until your dick lands in between her breasts. <i>“Let me have a taste first...”</i> she says while using her hands to smash her tits together and give you a tit job. She uses her incredibly flexible body to please all of your length but she also makes sure to suck the precum from your tip every now and then, devouring your fluids as if they were the sweetest nectar.";
				A6 = "She leans backwards and spreads her legs wide open <i>“Come with nanny!”</i> she says, pulling you again with her tentacles until your stomachs slaps against her body, your dick buried as deep as it can be inside her.";
				A7 = "Her hot and amorphous body is amazing, perfectly taking the shape of your dick and pressing its weak points. At this moment you can’t do much but relax and let Lucina bounce you like a toy, making you fuck her at a wild peace. The two of you are yelling in pleasure, waking up Helena from her short slumber, who starts to masturbate at the scene.";
				A8 = "You lose the ability to concentrate on your surroundings and focus instead on your pleasure, until your throbbing mast is finally ready to unload <i>“Yes "+ GameControl.playerName +"! My love! Give it all to me! Fill me with your seed! Give it to nanny!”</i> she yells, and you answer her begging with the first shot of your cum.";
				A9 = "\n\nShe clings to you with a hard embrace and smothers your mouth with a sweet deep kiss, losing the count of how many shots you’ve actually put inside her.";
			}

			Board.text = "Today you invited many of your retainers to meet with your nanny. You go to Lucina’s room and lead her to the living room, where Abbadon, Alba, and Helena are waiting. ";
			if (NPCCharList.CharFollower [iHelena].charCorruption < 66) {
				Board.text += "\n\nLucina had met Helena when she was a child, but since she has come back your shy maid has kept her distance, fearing the new body of your nanny. Lucina, excited to see Helena again, gets close to her and kiss her cheek. <i>“Oh Helena! I’ve not seen you since you were a child, working here with your mother! You’ve changed so much, you are such a beautiful woman now!”</i>\n\nHelena’s face turns red, and you can barely hear her whispers. <i>“T-Thanks ma’am, its a pleasure to have you back!”</i> her voice is a mix of fear and happiness, but you are certain that she’ll get over the fear part very soon.";
			} else if (NPCCharList.CharFollower [iHelena].attWillpower < 66) {
				Board.text += "\n\nHelena is wearing her exposed outfit, showing her " + A1 + " and breasts. Although you expected that your nanny would be reluctant, she hugs Helena and kisses her in the cheek. <i>“Oh Helena! I’ve not seen you since you were a child, working here with your mother! You’ve changed so much, you are such a beautiful woman now!”</i>\n\n\nShe ogles her body from top to bottom, and you can see that this makes your maid aroused, although she is still too shy. <i>“T-Thank’s ma’am, I’m sure it will be a pleasure to have you back with us!”</i> her tone sounds suggestive, and you can see how Lucina softly pat’s the girl’s rear with one of her tentacles.\n\n<i>“We’ll catch up later honey.”</i> ";
			} else {
				Board.text += "\n\nHelena is wearing her exposed outfit, showing her " + A1 + " and breasts. Although you expected that your nanny would be reluctant, she hugs Helena and kisses her in the cheek. <i>“Oh Helena! I’ve not seen you since you were a child, working here with your mother! You’ve changed so much, you are such a beautiful woman now!”</i>\n\n\nShe ogles her body from top to bottom, and you can see that this makes your maid aroused. <i>“Like what you see?”</i> says your maid, striking a lewd pose for your nanny. <i>“As you can see, I’m no child anymore, we should catch up later, if you dont mind.”</i> says Helena, giving a slap to your nanny’s ass that sets her gooey booty to jiggling. ";
			}

			if (NPCCharList.CharFollower [iAbbadon].charCorruption >= 66) {
				Board.text += "\n\nLucina now turns around to face Abbadon, who is exposing hisher parts to your nanny. \n\n<i>“Oh Abbadon, you also have grown up so much...”</i> your nanny’s eyes are fixed on the " + A2 + " of your retainer. <i>“You can bet I’ve grown up. Maybe I could show you what I’ve learned until now.”</i> Abbadon starts to walks towards Lucina but you shake your head, heshe picks up on the gesture and seems to understand that heshe needs to wait a little bit longer.\n\n<i>“Well, its great to have you back Lucina, if you ever want to have a chat, or anything else please feel free to visit my estate.”</i> ";
			} else {
				Board.text += "\n\n<i>“Oh Abbadon, you also have grown up so much! I’m happy to see that you are helping "+ GameControl.playerName +" to take care of things around here, I’m certain the city owes you just as much as it owes "+ GameControl.playerName +".”</i>\n\n<i>“Oh yeah, I’ve helped "+ GameControl.playerName +" a lot, but I’m glad you are back to help to rule the kingdom. Trying to guide that schmuck off yours is hard you know?”</i> Lucina laughs at the jokes of Abbadon, and seems to cheer up a little bit. ";
			}

			Board.text += "\n\n<i>“You... do I know you?”</i> asks Lucina when facing Alba. <i>“I don’t think so, my house raised to its current power after you left the city. I’m Alba, known as the industrial queen of Aurorum and one of the hottest pieces of ass around it too.”</i> although you also queue her to stop, Alba ignores your signals and grabs your nanny’s butt and pulls her close in order to kiss her gooey lips. \n\nYou can see how Alba’s tongue enters your nanny’s body and plays with her for half a minute before they part ways <i>“Hmmmm... you have such a weird taste Lucina, but I like it.”</i> You can see that your nanny’s emotions are a mix of shame and arousal, and you take her away from Alba before she gets a chance to continue.\n\nThe five of you take a seat in the living room and start to have a pleasant conversation, everyone talking about their past and their experience with you as a ruler. In the meantime, you ask for a servant to bring tea, but what no one else in the room knows is that you made sure to spice it a little bit with your own special mix, perfect to soothe them and remove those pesky inhibitions.\n\nEveryone in the room drinks the tea, and you can see how everyone starts to feel the heat in their bodies. \n\n<i>“Is just me, or today is really hot?”</i> asks Helena.\n\n<i>“You’re right, it’s too hot. Excuse me but I’ll do something about it!”</i> without further ado Alba strips her top and bottom, wearing nothing but her thong now.\n\nYou can see that no one protests, actually, everyone else seems to take her cue and begins to undress as well. <i>“Well, nothing we haven’t seen before right?”</i> says Abbadon. Lucina has nothing to strip, but you can see how her nipples harden at the show.\n\nHelena is sitting with Lucina, while Abbadon and Alba are sharing the other couch. You are alone, but from your seat you have a great view of the whole group.\n\nMinutes go by and everyone keeps talking as if nothing was going on, but you can see Alba’s grabbing Abbadon’s thigh, her hands growing very close to hisher nether parts. Lucina on the other hand is happily hugging Helena, more in a friendly manner than a lewd one. Her touch still seems to get your maid excited, thanks to the large breasts pushing against her naked body.";
			Board.text += "\n\nThe scene escalates quickly thanks to the effects of the tea. At this point " + A3 + ", while Alba is already shamelessly masturbating both herself and Abbadon right in the open. It’s not as though anyone would complain to such sight. \n\nLucina is struggling to keep her composure, but her tentacles are too honest, and you can see how a couple of them are fondling your maids ass and breast while the other two play with her own body.";
			if (NPCCharList.CharFollower [iHelena].attWillpower < 66) {
				Board.text += "\n\nYou can see that Helena can’t take it anymore and spreads her legs open <i>“Please ma’am, take care of me...”</i> whispers your maid. At this point Lucina loses what’s left of her restraint and you can see a lecherous smile across her face. \n\n<i>“Oh Helena you have turned into a woman with needs... Fine my child, let me take care of you.”</i>";
			} else {
				Board.text += "\n\nYou can see that Helena needs more than the soft caresses of your nanny. <i>“Stop fooling around, I need the real thing!”</i> says your maid, before assaulting your nanny’s mouth with her own, a lecherous kiss that makes Lucina drop her restraint like a pair of panties. \n\n<i>“Ahh... Ah... that was intense Helena, you are truly a woman now... Fine my child, let me take care of you.”</i> ";
			}
			Board.text += "\n\nShe takes Helena and sits her on her lap. She fondles your maid’s breasts with her hands while her tentacles invade everyone of her holes; one of them is up Helena’s ass, while another is being sucked as if it was a delightful lollipop. The last two are devoted to " + A4 + ", and although you have already fantasized about what Lucina could do with so many limbs, you are still impressed to see it in the flesh.\n\n <i>“Is this all right?”</i> asks your nanny, but Helena can only answer with eager and lusty moans. <i>“Heh I thought so, why you don't kiss nanny as a reward?”</i> She pulls her tentacle off her mouth and pushes her lips against hers, their tongues fighting to invade each others mouth.\n\nHelena’s body is overloaded by Lucina’s efforts and can’t help it, being the first one to have an orgasm. Lucina makes sure to absorb all of your maid’s fluids before softly putting her aside, since the poor servant is out of breath.\n\nLucina, still not sated, looks at you, but she is reluctant for a moment <i>“Oh... "+ GameControl.playerName +"... are you all right? I... I know it may be wrong, but I could help you if you want... If you are interested in this old hag of course...”</i> she slowly and shyly spreads her legs to you, which contrasts with how lewd she was a minute ago with Helena.\n\nYou turn around just to see what the other two are doing and you are not disappointed: They are engaged in a fierce sixty-nine, and you can see how they are aggressively sucking each other. Knowing how they are you are certain that they probably have a bet about whom can make the other one cum first, but right now you have more pressing matters.\n\nYou stand up and walks towards Lucina, leaning down to give her a deep kiss to the mouth. <i>“Ahhh sweetheart, come here!”</i>";
			Board.text += "\n\n" + A5;
			Board.text += "\n\nLucina notices that your orgasm is building up, and stops before you release. <i>“Wait sweetheart, I can make you feel even better.”</i> ";
			Board.text += "\n\n" + A6;
			Board.text += "\n\n" + A7;
			Board.text += "\n\n" + A8;
			Board.text += A9;
			Board.text += "\n\nWhen you are finally finished you can see your fluids swimming inside of her, and you can hear Abbadon, Alba and Helena clapping and whistling at your performance. \n\n<i>“What a show!”</i> says Abbadon. You can see that the three of them are ready again for the next round… it seems all of them want a taste of your nanny, should you allow them to keep going or finish the party now? ";
			option0Name.text = "Keep going";
			option1Name.text = "Finish";
			confirmationControl = 8; 
			break;
		case 8: // pure ending
			loadHelenaData ();
			loadAbbadon ();
			string B1 = "pussy";


			Board.text = "Today you invited many of your retainers to meet with your nanny. You go to Lucina’s room and lead her to the living room, where Abbadon, Alba and Helena are waiting. ";
			if (NPCCharList.CharFollower [iHelena].charCorruption < 66) {
				Board.text += "\n\nLucina had met Helena when she was a child, but since she has come back your shy maid had kept her distance, fearing the new body of your nanny. Lucina doesn’t appear to notice this fact considering she’s so excited to see Helena again, immediately dipping in closely to give her a friendly kiss on her cheek. <i>“Oh Helena! I’ve not seen you since you were a child working here with your mother! You’ve changed so much, you are such a beautiful woman now! " + GameControl.playerName + " has told me how smart you are too!”</i>\n\nHelena’s face turns red, and you can barely hear her whispered. <i>“T-Thanks ma’am, its a pleasure to have you back! I-I d what I can!”</i> her voice is a mix of fear and happiness, but you are certain that she’ll get over the fear part soon enough.";
			} else if (NPCCharList.CharFollower [iHelena].attWillpower < 66) {
				Board.text += "\n\nHelena is wearing her exposed outfit, revealing her " + B1 + " and breasts. Your nanny keeps her distance, disturbed by how your maid is dressed up <i>“Oh Helena, you’ve changed so much, but you need to learn modesty! What are you wearing!”</i> she scolds her in a motherly tone, and although your maid enjoys exposing herself nowadays you can see she covers her breasts and nether parts and turns a deep red of shame. \n\n<i>“S-Sorry ma’am! It’s just how things are with me now...”</i> says Helena with a whisper.\n\n<i>“Don't worry darling, just you watch and wait. Eventually things will be changed to how they were, and you can behave like a lady again. We’ll catch up later honey.”</i> ";
			} else {
				Board.text += "\n\nHelena is wearing her exposed outfit, revealing her " + B1 + " and breasts. Your nanny keeps her distance, disturbed by how your maid is dressed up <i>“Oh Helena, you’ve changed so much, but you need to learn modesty! What are you wearing!”</i> she scolds her in a motherly tone, and although your maid enjoys exposing herself nowadays you can see she covers her breasts and nether parts and turns a deep red of shame. Helena’s moment of modesty doesn’t last long however.\n\n<i>“Oh come on old hag, get with the times, this is how things are now. And you yourself are naked, so don’t come to me with that crap.”</i>\n\n<i>“W-Well I can’t dress with this body! And taking other shapes is very tiresome... And who do you think you’re calling an old hag?! I see that I will have to teach you to respect my household again! We’ll catch up later!”</i>\n\nHelena stays quiet for once, realizing that messing with Lucina right at this moment would prove to be a terrible idea. It is clear now that the two of them will struggle for power, but for now the meeting continues.";
			}
			if (NPCCharList.CharFollower [iAbbadon].charCorruption < 66) {
				Board.text += "<i>“Oh Abbadon, you also have grown up so much! I’m happy to see that you are helping " + GameControl.playerName + " to take care of things around here, I’m certain the city owes you just as much as it owes " + GameControl.playerName + ".”</i>\n\n<i>“Oh yeah, I’ve helped " + GameControl.playerName + " a lot, but I’m glad you are back to help to rule the kingdom. Trying to guide that schmuck off yours is hard you know?”</i> Lucina laughs at the jokes of Abbadon, and seems to cheer up a little bit. ";
			} else {
				Board.text += "Lucina now turns around to face Abbadon, whose parts are already exposed clearly to your nanny.\n\n<i>“Oh Abbadon...”</i> your nanny covers her eyes and shakes her head. You can see how Abbadon is smirking. \n\n<i>“Don’t be a prude Lucina, this is the latest trend in the city. It’s just a matter of simple fashion.”</i> says Abbadon, swaying hisher hips from side-to-side. \n\n<i>“How... Nevermind, I see that there is a lot of work to do to get the city straight again. It’s a pleasure to have you here Abbadon.”</i> the last words of Lucina don’t sound too convincing, but she knows better than to outright insult one of your trusted inner circle.";
			}
			Board.text += "\n\n<i>“You... do I know you?”</i> asks Lucina when facing Alba. <i>“I don’t think so, my house raised to its current power after you left the city. I’m Alba, known as the industrial queen of Aurorum and one of the hottest pieces of ass around it too.”</i> Alba walks towards your nanny and tries to kiss her mouth, but your nanny stops her. \n\n<i>“Don’t worry girl, this is how I deal with everyone, just a little kiss.”</i> says Alba, trying to press Lucina closer.\n\n<i>“N-No, that be fine Alba, I’m sure " + GameControl.playerName + " would like you to stick to the old traditions.”</i> \n\nAlba steps back and shrugs. <i>“Things have changed, and I’m sure " + GameControl.playerName + " isn’t as innocent as you think they are. Don’t worry, you’ll realize this eventually.”</i>\n\nThe five of you take a seat in the living room and start to have a pleasant conversation, everyone talking about their past and their experience with you as a ruler. In the meantime, you ask for a servant to bring a relaxing tea. Specifically the tea is for Alba, and the hopes that it will keep Alba’s endless libido in check and reduce any conflicts.\n\nEveryone in the room drinks the tea, and the bonding experience with your nanny seems to pick up the pace. \n\nLucina is amazed by Helena’s smarts and although Abbadon is full of himherself, your nanny can appreciate the vast knowledge and love for culture of your retainer. \n\nShe isn’t as fond of Alba whose naturally disrespectful and lewd behavior proves to be insuppressible, even with special tea. Nevertheless she can recognize her industrious nature and how the constant efforts in trade and income have been key to keeping the city afloat during a grim time.\n\n<i>“You know " + GameControl.playerName + "”</i> Lucina whispers to you at some point during the evening <i>“Maybe we can help Alba to stop being this... Inappropriate.”</i> you nod to your nanny and tell her that you’ll try to figure out something. \n\nThe meeting goes by until late night, when everyone is exhausted and ready to return home. \n\n<i>“You don’t know how fortunate is the city to have you back Lucina.”</i> says Abbadon, and Alba laughs before Abaddon turns around and threatens her with a gesture.\n\n<i>“Thanks Abbadon, it’s wonderful to be back, I’m eager to get back to work and help the city. If any of you need support please visit me and I’ll be willing to help you out.”</i>\n\n<i>“It’s late, we need to get going now.”</i> Alba clearly isn’t that interested in your nanny’s continued company, and is the first to stand up ready to leave.\n\n<i>“Very well, we’ll see you around.”</i> Abbadon stands up too and bows. <i>“Good night. Lucina, " + GameControl.playerName + ".”</i>\n\nWhen they are gone Helena is already cleaning the table, and have left the room too. \n\n<i>“" + GameControl.playerName + " this has been a very fun night. All these people are great and interesting, but I also realize that there is a lot of things to change and fix.”</i> she embraces you and speaks to your ear <i>“Thanks for helping me get back on my feet, I’ll pay it back by helping you help the city. We will do this together!”</i>\n\nThe two of you go back to your chambers to rest, and from this point you know you can count with Lucina for help.";


			NPCCharList.CharFollower [iLucina].isRecruited = true;
			QuestControl.lucinaQuest = 500;
			QuestsController.RemoveID (6007);
			QuestsController.RemoveID (7000);
			Quest ItzelQuest1 = new Quest ();
			QuestsController.createQuest (ItzelQuest1, "Faith reborn.", "A new religious figure arrives to the city, bringing with it hope.", 63, 7000);
			endTurnFun ();
			break;
		case 50: // tales from the past, slut 
			NPCCharList.CharFollower [iLucina].attMorality = 0;
			NPCCharList.CharFollower [iLucina].charPortraitLayer0 = 6000;

			NPCCharList.CharFollower [iLucina].charCorruption = 50;
			WorldControl.day += 3;
			Board.text = "After Lucina finished reading her diary her memory and personality started to change to reflect this impressionable new self and its lusty ways. Her current progress has brought to the front a more alluring demeanor, but she has also grown more cheerful thanks to developing some purpose in her life.\n\n<i>“"+ GameControl.playerName +" you say the city has changed but do you think they will accept me?”</i> you calm her down by telling her that so long starts to properly behave as is required now, she should be fine.\n\n<i>“I’ll do my best!... I still somehow feel like there is something wrong with all of this but I trust your judgment.”</i> the two of you leave the castle and walk through the city. You visit the market, park, and a number of other places. They don’t evoke any strong reactions out of her though until she sees the burned church. \n\n<i>“What... What happened here "+ GameControl.playerName +"? The church was beautiful and now it’s nothing but ashes...”</i> you tell her that you weren’t here when that happened, but you’ve been told that it was during the plague outbreak. There’s still plenty of work to do, and the city is still waiting for a pure soul to take care of rebuilding it again. \n\n<i>“Well things are changing right? Maybe we could build something better here... or a new, different church right?”</i> You tell her that you like how she thinks, and if the opportunity arises you may look into that. \n\n<i>“Well, I think I’ve seen enough for today.”</i> You shake your head and tell her that there is still an important place to visit: the red district.\n\n<i>“Oh that sounds interesting... Sure, lets go!”</i> eager, the two of you arrive in no time. At this time of the day there aren’t as many girls and boys working on the streets, but more than enough to present a clear picture.\n\nYou tell her that she used to visit this place very often in the past, since there are many interesting stores and people to chat with.\n\n<i>“I can see that... I don’t recall much, but maybe I could come here on my own in the future and see if that helps with my memory.”</i>\n\nYou tell her that that’s a great idea, and that for now you pretty much have shown off the most important places in the city.\n\n<i>“Great "+ GameControl.playerName +"! You’ve been very helpful... Maybe you deserve a reward for your effort.”</i>\n\nShe leans forwards and kisses you on the lips, but she still shies away from turning it into anything serious.\n\n<i>“Let’s go back, you can keep teaching me tomorrow.”</i>\n\nThe two of you return to your castle, but with the performance of Lucina today you are almost certain that you will succeed in your training. ";
			endTurnFun ();
			QuestControl.lucinaQuest = 51;
			QuestsController.RemoveID (6004);
			Quest LucinaQuest6 = new Quest ();
			QuestsController.createQuest (LucinaQuest6, "Tales from the past II", "You decide to visit the city with Lucina, to help her remember.", 62, 6005);
			panConfirmation.sortingOrder = 500;

			break;
		case 51:
			WorldControl.day += 3;
			Board.text = "You visit Lucina in her chamber. The last visit through the city helped her change her mind, realizing how much its shape has changed. It also seems to have helped her come to terms with the changes of her own body.\n\nWhen you knock the door she immediately opens it, already waiting for the next session.  \n\nYou sit on the bed at her side. \n\n<i>“"+ GameControl.playerName +", I have so many questions to ask, I hope you are not troubled by that.”</i> you shake your head and tell her that you’ll answer as best as you can, but you also didn’t live in the castle for a long time so a lot of your knowledge comes from books and hearsay. \n\nShe asks you about what happened to you after you had escaped the city when your uncle took over and you tell her about your life in the hut with your guardian, struggling to survive. \n\nAfter that she asks you about the outbreak, since she doesn’t remember much. You tell her that this happened many years after you went into hiding, and that no one knows exactly why it happened but it is obvious that it was the work of an alchemist. \n\nYou can see that she is curious when you talk about alchemy, and although you’re tempted to tell her about the secret laboratory it may be too soon. ";
			if (GameControl.charCorruption >= 50) {
				Board.text += "\n\n<i>“Darling... I can see that not only myself and the city has changed, you too are different.”</i> \n\nYou nod slowly and tell her that no ones is really free of corruption in the city. As for now you have decided to embrace it, since there is not much you can do about it regardless.\n\n<i>“I see... Don’t worry sweetheart, I will be by your side to take care of you.”</i>";
			} else {
				Board.text += "\n\n<i>“You haven’t changed that much darling.”</i> you tell her that she is right, you have managed to keep yourself from changing too much.\n\n<i>“I see... Well sweetheart, isn’t it a little unfair that I’m the only one who experiences this change? Come, let me take care of you. ”</i>";
			}


			Board.text += "She leans forwards and embraces you, but you soon feel her hand on top of your crotch. <i>“I’m sorry darling, but I need this.”</i> before you can answer she starts kissing you, while her tentacles undress slip beneath your clothing until you’re rendered naked by their surprisingly expert touch.\n\nWith ease she pushes you until you are lying on the bed before sitting on your face; her heavy bottom makes it hard for you to breath.\n\n<i>“Start sucking darling, I wont move until I cum!”</i> she adds to the pressure and you have no choice but to start eating her asshole.\n\n<i>“Ahhh!... I didn’t mean that hole! But- ooh… oh your tongue feels so good...”</i>";

			if (GameControl.dick1Size > 0) {
				Board.text += "You feel one of her limbs jerking your cock. <i>“I told you I will take care of you, I wasn’t lying.”</i>\n\nShe leans forward and you can feel how her mouth presses against your mast. She gives it a whiff and a lick. <i>“Such a powerful smell... and it’s taste... I...”</i> before she finishes she engulfs your whole dick, deep throating you as no one else can. There’s no need for your gooey partner to breath, and the sshape of her willing throat conforms to your size perfectly. No matter how hard she clenches it’s possible to feel pleasure. \n\nShe moves her hips, her crotch now just inches away from your face, but she pauses.\n\n<i>“What do you want to eat "+ GameControl.playerName +"? My pussy or a strong dick like yours?”</i>";
			} else {
				Board.text += "You feel one of her limbs playing with your clit. <i>“I told you I will take care of you, I wasn’t lying.”</i>\n\nShe leans forward and you can feel how her mouth presses against your pussy. She drinks in the scent of you before giving you a small, slurping lick. <i>“Such a powerful smell... and it’s taste... I...”</i> before she finishes speaking her brain gives up and she dives into eating you out. Her tongue goes wild around your outside and inside, her shape shifting muscle perfect to reach even your most hidden spots. \n\nShe moves her hips, her crotch now just inches away from your face, but she pauses.\n\n<i>“What do you want to eat "+ GameControl.playerName +"? My pussy or a strong dick like yours?”</i>";
			}
			panConfirmation.sortingOrder = 500;
			confirmationControl = 50;
			option0Name.text = "Pussy";
			option1Name.text = "Dick";
			break;
		case 52:
			WorldControl.day += 7;
			Board.text = "You and Lucina have been in a fuck fest for the last week and at this point she is clearly developed to the point that you don’t think she requires any further training, so it’s time for the final test. \n\nShe is in her chamber, waiting for another day of exhausting sex. When you cross the door she jumps into your arms and kisses you <i>“I can’t wait "+ GameControl.playerName +", let’s do it right here!”</i> It’s a struggle to get her to hold still, but you manage to bring her to a stop before handing over a collar with a golden tag that says “SLUT” in it. \n\n<i>“For me? This is wonderful!”</i> It’s always interesting watching her body display its full potential. She absorbs the accessory into her body, before moving it around and letting it float to its proper place aruond her neck. <i>“Oops! It’s a little bit wet now, but it’s not a big deal.”</i> she says, realizing of the consequences of the process a little after. <i>“Well now let’s go back to-”</i> \n\nYou stop her and tell her that today you have something else in mind, grabbing her hand and walking towards the city. Lucina, obedient as she is now, follows your lead despite her curiosity about what’s to come next.\n\n<i>“What are we gonna do? Are we going shopping? Can we fuck in the dressing room?”</i> you tell her that she’ll see, and although she makes a pout she finally shuts up.\n\nThe two of you arrive at the center of the red district. You give her a sound slap on the ass, loud enough to make the people around you turn their heads towards you.\n\nWith a small crowd at your disposal, what do you want to do?\n\nFuck Lucina and show her to your people as your obedient sex slave?\n\nPimp her out, let the crowd have their way with her in exchange of gold?";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 51;
			option0Name.text = "Fuck her";
			option1Name.text = "Pimp her";
			break;
		case 100:
			WorldControl.day += 5;
			Board.text = "It’s been a couple of days since you decided to break what’s left of her mind apart. You’ve been wondering what would be the best course of action to do this, and the idea of reinforcing the more primal behavior it’s probably the best way to go.\n\nYou moved her to the dungeon and have been training her as if she was a pet, giving her treats when she follows your commands and punishing her when she doesn’t. \n\nAlthough there has been some good progress, you can see that from time to time she still tries to snap back to her older self. When she does so, you usually berate her to scare her, and day by day she starts to let go those memories drift away into the back of her mind. \n\nNow you can take her out of the dungeon and visit other places without the fear that she will try to escape. You’ve been thinking on whether to take her hunting in the forest to deal with beasts by using her charm… but you could also work up her charm, but you could also bring out her lustful nature by having sex or taking her to some grand orgy… Surely filling her with the fluids of dozens will fuck up her mind, but you know some drugs that could do the trick if you just want to take her for yourself. ";
			option0Name.text = "Hunt";
			option1Name.text = "Sex";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 100;
			break;
		case 101: // taming the beast
			WorldControl.day += 5;
			Board.text= "The primal instinct of Lucina has been awoken, but at this point in time it is too feral to free her around your castle, let alone the city.\n\nEveryone you stop supervising her she ends up causing havoc, and her oozy body has ruined your kitchen supplies many times, scared your horses from the stable or damaged your studio and laboratory. In short, she needs to be trained to behave. \n\nAlthough you are no expert, you have your fair experience dealing with animals, specially when you were young surviving in the shack with your guardian, where for a while you had pigs, dogs and even a cow. \n\nYou know you could train Lucina in two ways: Either making her more like a normal, loving pet; submissive to its master and very well behaved with anyone, or you could train her to be more possessive and aggressive, dominant indeed, like a guardian dog that lusts for you too. Of course she would be forceful, and she will have no qualms on abuse her physique on you.";
			option0Name.text = "Pet (sub)";
			option1Name.text = "Guardian (dom)";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 103;
			NPCCharList.CharFollower [iLucina].charPortraitLayer0 = 6050;

			break;
		case 102: // primal instinct
			WorldControl.day += 5;
			Board.text = "After the training you though that all your troubles with Lucina would be solved, but you were wrong. \n\nLately you’ve seen her stalking your servitude, although her stealth isn’t great. They feel unease, and they have asked you to do something about it, but you really don’t know why she does it, and so far has been harmless. \n\nEven though you scolded her a couple of times, you haven’t been able to stop her. Whatever, you think, it may be just a game for her.\n\nThen, one morning one of your guards informs you that one of your maids have disappeared. Alarmed, you send the servitude to throughly search around, and your guards to investigate in the city, in case she may have escaped.\n\nAfter many hours there are no signs of her. Finally, you decide to check your laboratory. No one really knows about, not even Lucina as far as you know, so its the only place left. \n\nBut you were wrong, Lucina not only knew about the place, but also made it her lair apparently.\n\nApparently her instinct to breed is too strong, or she just feel lonely being the only slime girl, and decided to take matters on her own hand.\n\nFrom the roof you see someone hanging, its whole body covered with the same viscous, blue, thick slime that Lucina is made off. \n\nYou can see two figures in the wall, one of them is your maid, she isn’t completely covered yet, but she is unable to yell, the other victim its covered like the one in the roof, from top to bottom.\n\nYou wonder who are they, since they certainly don’t work for you, did Lucina escaped to the city at night? Well, whatever the case, that’s not really the most urgent matter at this point.\n\nWithout wasting more time you free the maid, who takes a minute to recover and wake up. She thanks you and you tell her to go upstairs so a guard can help her.\n\nYou order Lucina to stay quiet while you poke the other two. Although at first they don’t react, one of them wakes up, a smaller slime girl with a more slim body than Lucina.\n\nShe looks more primitive and starts to attack you by instinct, but Lucina stops her before it’s too late. \n\nAlthough you could try to train Lucina and stop her to keep doing this, you could also encourage her to keep doing what she is doing. \n\nNOTE: For now this offers no new content, but it will in the future. This decision may be reversed in the future. ";
			option0Name.text = "Encourage";
			option1Name.text = "Scold";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 106;
			break;
		default:
			Board.text = "This is all the content available for Lucina for now!";
			endTurnFun ();
			break;

		}


	}


	public void confirmFun(int selector){

		//fight her
		if (selector == 0 && confirmationControl == 0) {
			Board.text = "You bring out your weapon, ready to face her. You slowly circle the beast that might be your family, looking for an opening. Although the situation is tense, you believe that dealing with her shouldn’t be different than dealing with a wild animal, using only its instinctual behavior to defend herself. \n\nYou use a couple of feints just to test her, and then a real attack that lands. With no armour or shield to protect herself, your sword cuts easily through her. Her arm drops from her body with a wet thud, but the slime-like material that makes up the rest of her absorbs the removed limb before rebuilding it once more.\n\nSuch a matter would make for a challenging opponent, but a slime such as her should still have a core within. All you’d need to do to actually harm her is strike that. The only issue is that the material seems thick and latex-y, making such an attempt pretty hard.\n\nLuckily for you the creature’s attacks are also pretty ineffective and weak. Nothing she does is stronger than a slap, but you fear what would happen if the creature decides to absorb you whole.\n\nAfter ten minutes of combat you finally strike her weak point, but her reaction surprises you; her body goes stock still. A mouth forms and a surprisingly familiar and human voice bubbles out. <i>“"+ GameControl.playerName+"?! "+ GameControl.playerName+"!”</i> she yells, before jumping on top of you. \n\nFearing the worst you struggle and brawl with her, but you can’t get her off. It takes a few moments to calm down once you realize that she isn’t trying to do you any harm… instead it would seem she’s hugging you. \n\n<i>“"+ GameControl.playerName+"...”</i> she keeps repeating your name while awkwardly pushing her naked body against yours. Although still a little confused, you could decide to let the woman keep rubbing herself to you, or stand up and try to reason with her. ";
			option0Name.text = "Let her";
			option1Name.text = "Stand up";
			confirmationControl = 1;
			return;
		}
		//soothe her
		if (selector == 1 && confirmationControl == 0) {
			Board.text = "No need to use violence against this harmless monster. You drop your weapons, using non-threatening gestures and ask her to calm down. \n\nThe monster seems reluctant at first, but once she realizes you are not a threat to her she approaches like a curious animal would.\n\nAs she gets closer and closer to you, you can actually see the shift in her expression grow more human. Suddenly an achingly familiar voice burbles out from her depths. <i>“"+ GameControl.playerName+"?! "+ GameControl.playerName+"?!”</i> she yells before jumping on top of you. At first you get startled and scared, fearing she will try to engulf you as slimes do, but instead she starts to hug you and rub her slimy body with yours, still yelling your name. \n\nWhen the confusion goes away you realize that you have trigged some memories in this monster and she poses no threat. Still, she continues to rub her naked form against your body. Although still a little confused, you could decide to let the woman keep doing what she is doing or stand up and try to reason with her. \n";
			option0Name.text = "Let her";
			option1Name.text = "Stand up";
			confirmationControl = 1;
			return;
		}

		///////////////////////////// let her // stand up

		if (selector == 0 && confirmationControl == 1) {
			Board.text = "The best way to deal with her is to let her do what she needs to do until she is satisfied. For some monsters a little ‘action’ grants them a little more understanding. Perhaps her memories will return.\n\nDuring the next ten minutes she keeps hugging you, kissing you and touching you. Although her actions aren’t explicitly sexual in manner, your body follows along and you can’t help yourself from ending up aroused. \n\nTo speed up the process you start to hug her and kiss her back, being a little more frisky than her, but trying not to go too far to the point you may scare her. \n\nYou end up having a dry orgasm, and shortly after that she finally grows tired with the exertion, resting on top of your body. \n\nWith her already asleep, you order some of your guards to take her to one of your empty rooms, before you return to your studio to figure out what to do with her.\n\nAfter thinking for many hours, you can’t shake the feeling that she truly might be your former nanny. Maybe she wasn’t as dead as people in the city believed…  Nonetheless you still haven’t got a clue about what to do with her next, or indeed if you even <i>can</i> do anything, or if she is a lost cause. For now you will keep an eye on her to see how she keeps behaving. ";
			QuestControl.lucinaQuest = 1;
			QuestsController.RemoveID (6000);
			Quest LucinaQuest2 = new Quest ();
			QuestsController.createQuest (LucinaQuest2, "Out of control", "Although not dangerous, Lucina's mind needs help.", 62, 6001);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 1) {
			Board.text = "You decide to stand up and try to reason with her, despite how she practically throws herself at you with attempts to hug and kiss you. Perhaps ten minutes of fruitless struggling follow before she grows sleepy enough, drooping to the floor in surrender and falling asleep.\n\nWith her already asleep, you order some of your guards to take her to one of your empty rooms, before you return to your studio to figure out what to do with her.\n\nAfter thinking for many hours, you can’t shake the feeling that she truly might be your former nanny. Maybe she wasn’t as dead as people in the city believed…  Nonetheless you still haven’t got a clue about what to do with her next, or indeed if you even <i>can</i> do anything, or if she is a lost cause. For now you will keep an eye on her to see how she keeps behaving. \n";
			QuestControl.lucinaQuest = 1;
			QuestsController.RemoveID (6000);
			Quest LucinaQuest2 = new Quest ();
			QuestsController.createQuest (LucinaQuest2, "Out of control", "Although not dangerous, Lucina's mind needs help.", 62, 6001);
			endTurnFun ();
			return;
		}

		///////////////////////////// sanity // instincts 

		if (selector == 0 && confirmationControl == 2) {
			Board.text = "Your final choice is to help Lucina to recover her mind. The task in front of you is daunting, and you don’t know if you’ll be successful, but you have to try and see if you can make her a normal individual again... Or as normal as a slime girl can be. ";

			QuestControl.lucinaQuest = 2;
			QuestsController.RemoveID (6001);
			Quest LucinaQuest3 = new Quest ();
			QuestsController.createQuest (LucinaQuest3, "Aftermath", "You'll now will take care of Lucina and help her to recover her mind.", 62, 6002);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 2) {
			Board.text = "Your final choice is to reinforce her instincts. Most of her memories are fragmented or lost, and an attempt at bringing her back looks unpleasant. You’ll use the relationship you have with her to make her an obedient servant of your will. ";

			QuestControl.lucinaQuest = 100;
			QuestsController.RemoveID (6001);
			Quest LucinaQuest3 = new Quest ();
			QuestsController.createQuest (LucinaQuest3, "Burying the past", "You'll now erase what's left of the Lucina's former self.", 62, 6002);
			endTurnFun ();
			return;
		}

		///////////////////////////// Grope / Part away

		if (selector == 0 && confirmationControl == 3) {
			Board.text = "Instead of rejecting her and leaving, you embrace her. She naively hugs you back, but you can feel how her tentacles start to touch and grope your chest and even your crotch, although Lucina herself doesn’t really act lustful in any way. \n\nYou start to caress her back and she gasps, but stays put <i>“I’ve been waiting for this moment for so long, the time I could find you and bring you home again...”</i> she whispers.\n\nAlthough it is obvious that there is a conflict between her feelings and her behavior, you’re still rooted to the spot enjoying both her lovely embrace and her increasingly daring tentacles. \n\nAroused, you try to see how far you can go and start to touch her butt, but apparently this was too much for her conscious mind <i>“Eeek!”</i> she yells while letting you go from her arms. \n\nYou pretend that nothing happened and ask what’s going on <i>“N-Nothing, it must be this new body, I still haven’t got used to it and I thought... never mind. I must be tired, would you mind to let me rest for today? We can continue tomorrow, I would love to catch up with you later and remember... well, everything. Who I was to start with.”</i> you nod and tell her not to worry, instead she should just rest. You’ll make sure to answer all of her questions tomorrow or whenever she wants.\n\n<i>“Thanks darling, I’m so lucky to have you at my side.”</i> your face turn red with embarrassment, and you bow out saying that it’s nothing before rushing for the door. You can swear that you hear her giggling on your way out.\n\nIt’s exciting to see how she is already beginning to recover.\n";
			QuestControl.lucinaQuest = 3;
			QuestsController.RemoveID (6002);
			Quest LucinaQuest4 = new Quest ();
			QuestsController.createQuest (LucinaQuest4, "Fragmented memories", "It's time to help her recover her former self, or trick her and change her personality.", 62, 6003);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 3) {
			Board.text = "You hug her one more time before standing up and tell her that you have to get ready for what comes next.\n \n<i>“Thanks darling, I’m so lucky to have you at my side.”</i> your face turn red with embarrassment, and you bow out saying that it’s nothing before rushing for the door. You can swear that you hear her giggling on your way out.\n\nIt’s exciting to see how she is already beginning to recover.\n\n";
			QuestControl.lucinaQuest = 3;
			QuestsController.RemoveID (6002);
			Quest LucinaQuest4 = new Quest ();
			QuestsController.createQuest (LucinaQuest4, "Fragmented memories", "It's time to help her recover her former self, or trick her and change her personality.", 62, 6003);
			endTurnFun ();
			return;
		}

		///////////////////////////// Real personality / Change her 

		if (selector == 0 && confirmationControl == 4) {
			Board.text = "No, changing her personality is not the right thing to do, regardless of whether this is best for your kingdom or not; she’s your mother/nanny and deserves herself back.\n\nYou take the diary with you and summon her into your studio. When she arrives you can see that she is dazed and on the verge of losing lucidity again, but when you show her the book she reacts immediately. \n\n<i>“Is... Is that my diary?”</i> she asks, recognizing it with a hopeful note to her voice. You smile and hand it to her, and she immediately starts to read it out loud. \n\nAfter she has finished reading a couple of pages she gulps audibly, looking up at you. <i>“I... I really loved you "+ GameControl.playerName +", you were so important to me... I... I feel bad for forgetting that for so long...”</i> You can practically see the tears welling up in her, and you give her a hug to settle her down. You tell her it’s not her fault, that she got into this situation trying to help you in the first place.\n\n<i>“Y-yes that’s true, but I still feel a little bit guilty...”</i> she embraces you back <i>“I’m really happy "+ GameControl.playerName +"! With the help of this maybe my memories will come back even faster! Even if that’s not the case at least I can understand our relationship properly now…”</i>\n\nShe gives you a kiss on the cheek and sits down, reading the diary from the beginning. Since she is too focused, you tell her that you have to go back to work. Perhaps once she’s finished the two of you could go to the city and visit some familiar places. \n\n<i>“That’ll be lovely "+ GameControl.playerName +", I appreciate your attention!”</i> you nod and leave her alone, happy with your current success. ";
			QuestControl.lucinaQuest = 4;
			QuestsController.RemoveID (6003);
			Quest LucinaQuest5 = new Quest ();
			QuestsController.createQuest (LucinaQuest5, "Tales from the past I", "You decide to visit the city with Lucina, to help her remember.", 62, 6004);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 4) {
			WorldControl.day += 4;
			Board.text = "It would better suit your purpose if you change her personality, and you spend the next days forging a copy of her diary, full of lewd remarks, thoughts and experiences. \n\nOnce you finish the forgery you summon her to your studio. When she arrives you can see that she is dazed and on the verge of losing lucidity again, but when you show her the book she reacts immediately. \n\n<i>“Is... Is that my diary?”</i> she asks, recognizing it with a hopeful note to her voice. You smile and hand it to her, and she immediately starts to read it out loud, but her tone quickly transforms into a whisper, and her face turns red in shame. \n\nShe pauses after she finishes the first page. <i>“D-Did you read it?”</i> she nervously asks, and you shake your head. <i>“That’s good... A diary should be a private thing right? I think I will read this later...”</i> you nod and she looks relieved that you aren’t pushing her to keep exposing herself.\n\n<i>“Well... I hope this helps me remember my past faster, I appreciate a lot that you found this for me, it makes me happy that you care so much for me.”</i> she embraces you and gives you a kiss on the cheek. You answer in kind and tell her that she should finish the diary as soon as possible, and once she is done you two can visit the city and see if that helps her too.\n\n<i>“That’ll be lovely "+ GameControl.playerName +", I’ll be happy to go with you!”</i> you smile once more before leaving her alone to finish the erotic tales that she has in her hands. ";
			QuestControl.lucinaQuest = 50;
			QuestsController.RemoveID (6003);
			Quest LucinaQuest5 = new Quest ();
			QuestsController.createQuest (LucinaQuest5, "Tales from the past I", "You decide to visit the city with Lucina, to help her remember.", 62, 6004);
			endTurnFun ();
			return;
		}

		///////////////////////////// Console / changing world

		if (selector == 0 && confirmationControl == 5) {
			Board.text = "You console her, telling her that it will be only matter of time until the church can be rebuilt and managed by a true man or woman of faith. Although she knows the promise is empty she also knows that she can trust you to do your best, and smiles.\n\n<i>“Thanks "+ GameControl.playerName +", I’m sure you’ll rebuild it.”</i> you grab her hand and sit at her side, enjoying the silence and calm of your quarters for a minute. \n\nWhen you are about to stand up you can feel you can feel her soft grip tighten for a moment, signaling you to stay a little bit longer. \n\n<i>“"+ GameControl.playerName +" today has been very helpful, and my memories are starting to come back, but they are still very foggy. Perhaps next time you come around we can sit down and talk about you, and the city during these years that I’ve been lost?”</i> you nod and her and tell her that that’s a great idea, but for today she needs to rest.\n\n<i>“Very well "+ GameControl.playerName +", I’ll do that. I know you are very busy, but I hope is not too much to ask to not delay our next meeting too much.”</i> you caress her cheek and tell her that she has nothing to worry about, that you’ll come back as soon as you can. \n\nShe cheerfully smiles <i>“You spoil me with your kindness but I’m very thankful of how you take care of me, it must be a burden.”</i> you shake your head and smile, telling her that she is being silly now; she’s not a hurdle nor never will be. \n\nYou finally stand up and she reluctantly lets you go, you reassure her one more time before leaving her in her room to rest. ";
			QuestControl.lucinaQuest = 5;
			QuestsController.RemoveID (6004);
			Quest LucinaQuest6 = new Quest ();
			QuestsController.createQuest (LucinaQuest6, "Tales from the past II", "Today you'll have a private conversation with Lucina, trying to remember the past together.", 62, 6005);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 5) {
			Board.text = "You tell her that although its understandable that she feels sad about what’s going on, the truth is that now is the time to look forward. Now that everything has been torn apart and burnt down, why not use this opportunity to build a better city? A better place? \n\nShe looks at you with anger in her eyes, as if you were betraying her. She clenches her hand into a fist, and it takes her a couple of minutes until she calms down enough to answer.\n\n<i>“That’s how I taught you "+ GameControl.playerName +"?! Did I teach you to let things go instead of fight for what you love? So you want to say to me that I should have stopped looking for you and stay here in the city because that was easier and safer?”</i> You are surprised at her reaction and tell her that that’s not what you meant to say, that she is taking this all wrong.\n\n<i>“Am I? Because your words sound like you meant that!”</i> You don't want to stay on the defensive and decide to counter attack her argument, telling her that perhaps she is right. That if you meant that, and if she hadn’t run off into the wilderness to look for you she would still be a human. Maybe she could have taken care of the kingdom instead, saved the church, and everyone else. Maybe looking forward would have been the right choice.\n\n<i>“I... I refuse to believe that "+ GameControl.playerName +"! That’s not the right thing to do! I... I need time alone, please.”</i> You want keep arguing but you realize this isn’t going to work, and tell her that you’ll come back soon to keep helping her with her memories.\n\n<i>“Thanks, I appreciate it.”</i> she says, although there is a sharp note to her voice. When closing the door after leaving the room you can catch a glimpse of her expression; sadness and regret play across her features. Even though the day ended on a sour note, you have some hope that your words may be seeds that can help her rethink the future of the city.\n";
			NPCCharList.CharFollower [iLucina].charCorruption += 25;
			QuestControl.lucinaQuest = 5;
			QuestsController.RemoveID (6004);
			Quest LucinaQuest6 = new Quest ();
			QuestsController.createQuest (LucinaQuest6, "Tales from the past II", "Today you'll have a private conversation with Lucina, trying to remember the past together.", 62, 6005);
			endTurnFun ();
			return;
		}

		///////////////////////////// change / old ways 

		if (selector == 0 && confirmationControl == 6) {
			if (GameControl.charCorruption >= 50) {
				Board.text = "You shake your head and tell her that indeed you’ve changed; so has she, and so has the whole world. She crosses her arm at looks at you with a mix of concern and disappointment. \n\n<i>“Yes "+ GameControl.playerName +", things have changed, but we can change them back if we try!”</i> she insists, but you tell her that if you could change her back, you would have done so by now. Sadly some things simply can’t be fixed, can’t be turned back, and she needs to accept that fact of life. \n\nShe sighs and look down, a sad smile across her face. <i>“You... You may be right "+ GameControl.playerName +", some things can’t be changed. I just wished deep inside me to turn things back to how they were before. I wanted to hold you in my arms as I used to when you were young, to play around and just be happy. But things have changed, you’ve matured and... and I will trust your judgment. If you believe there is no turning back we will have to do our best to keep on going, even if it hurts.”</i>\n\nYou try to hug her but she turns around and your hand slips through her body. <i>“I... I need some time to digest what you just said, that’s all.”</i> you stand up and apologize <i>“Is not your fault darling... You are just doing your best, and I support you. It doesn’t make the truth any easier to swallow though.”</i> you tell her that she should rest and then you’ll be back soon to keep helping her, and finally leave her be. \n";
			} else {
				Board.text = "You grab her and softly part away from her bust. You tell her that although her words make you happy, they can’t do change the world back to how it was. The truth is, the world is changing and if you don’t adapt with it, you’ll perish in the wave of change.\n\n<i>“Oh "+ GameControl.playerName +", don’t be that grim, if we work together we can do it!”</i> you smile at her, but you tell her that this is probably something that’s above any mortal. Instead the both of you should face the future and working to keep the kingdom safe as it alters.\n\nHer mood changes: Sad and distraught, but nods at you. <i>“You’re right darling, things have changed, and you’ve been taking care of the kingdom until now… so if this is your judgment, I trust you. You’ll have my support, and let’s do our best to keep this kingdom safe and happy, shall we?”</i> you nod and hug her, before telling her that she should rest now, because tomorrow the two of you are going back to the city to keep helping her with her health. \n\n<i>“Yes, that’s a good idea my darling, I’m tired, but I’m happy we had this chat. The truth is hard to swallow, but I’ll get over it with you at my side.”</i> you say goodbye one more time before you leave the room, getting ready for what’s next.\n";
			}
			NPCCharList.CharFollower [iLucina].charCorruption += 25;
			QuestControl.lucinaQuest = 6;
			QuestsController.RemoveID (6005);
			Quest LucinaQuest7 = new Quest ();
			QuestsController.createQuest (LucinaQuest7, "Tales from the past III", "Today Lucina will join you in the throne room, to help you sort out the different challenges that you face.", 62, 6006);
			endTurnFun ();

			return;
		}

		if (selector == 1 && confirmationControl == 6) {
			if (GameControl.charCorruption >= 50) {
				Board.text = "You tell her the truth, that yes, indeed you’ve changed, but not because you wanted, but because the world is harsh and unforgiving and you didn’t have a choice. \n\n<i>“My darling!”</i> she says while one of her tentacles grabs you and brings you into her arms, her heavy breasts pressing against your face. <i>“I’m sorry my love! I should had been there, helping you and taking care of you! This is my fault, I failed you!”</i> she says, sobbing, deeply disappointed with herself. \n\nYou embrace her and soothe her with your voice, telling her that this isn’t your fault. Instead now that she is back the two of you can work together to make the world a better place. <i>“Of course darling, I’ll do whatever it’s necessary to help you rebuild the city!”</i> You stay in her arms for a little bit longer but then tell her that she needs to rest now, because tomorrow the two of you are going back to the city to keep helping her with her health. \n\n<i>“Yes, that’s a good idea my darling, I’m a little bit tired already… but before you leave just remember that if you need my help, I’ll be there.”</i>";
				GameControl.charCorruption -= 15;
			} else {
				Board.text = "You reassure her that the two of you will take care of the city, turning it back to its former glory.\n\nWhether that’s true or not is a different matter.\n\n<i>“We’ll succeed darling, you’ll see!”</i>\n\nYou embrace her and soothe her with your voice, and you tell her that with her help the two of you can the world a better place. <i>“Of course darling, I’ll do whatever it’s necessary to help you rebuild the city!”</i> You stay in her arms for a little bit longer but then tell her that she needs to rest now, because tomorrow the two of you are going back to the city to keep helping her with her health. \n\n<i>“Yes, that’s a good idea my darling, I’m a little bit tired already... but before you leave just remember that if you need my help, I’ll be there.”</i>";
			}

			QuestControl.lucinaQuest = 6;
			QuestsController.RemoveID (6005);
			Quest LucinaQuest7 = new Quest ();
			QuestsController.createQuest (LucinaQuest7, "Tales from the past III", "Today Lucina will join you in the throne room, to help you sort out the different challenges that you face.", 62, 6006);
			endTurnFun ();
			return;
		}


		///////////////////////////// Forgive / punish

		if (selector == 0 && confirmationControl == 7) {
			CityControl.city100Corruption += 5;
			NPCCharList.CharFollower [iLucina].charCorruption += 25;

			Board.text = "You shake your head and say that during this time punishing this kind of behavior would be too harsh. Lucina may not be aware of the realities in full, but you would likely end up criminalizing the whole kingdom.\n\nThe girl sighs with relief while Lucina looks disappointed. Nonetheless, you say, the girl needs to have some kind of punishment for wasting both your time and the time of guards that could be taking care of more important business. She lets out a whine of protest, at least until she hears what her punishment is meant to be… she smirks and seems all too happy to comply now.";
			if (GameControl.dick1Size > 0) {
				Board.text += "\n\nShe walks towards you and takes out your cock. Lucina grows really nervous, squirming beside you. <i>“Is... Are you sure this is okay "+ GameControl.playerName +"?”</i> she says while the girl is already stuffing her mouth with your dick. You nod at your nanny and tell her that this girl still needs a release anyway. Judging by how she greedily fingers herself whilst busily attending you, you point out that she’s enjoying this as much as you are.\n\n<i>“Thats not what I meant... uh?!”</i> she is surprised when you hold her hand, and argue that this is how business are conducted nowadays. You feel successful when she holds your hand tighter instead of moving away, and you do your best to keep yourself from cumming as much as you can.\n\nMeanwhile Lucina is fixated on your cock and the girl sucking it. You can see that against her own will her tentacles start to act, subtly touching her breasts and pussy at first, but it doesn’t take long until the act is more obvious.\n\nWith the thirsty mouth working you down there and the sight of your nanny masturbating it becomes impossible to hold back. You let out a shuddered gasp before cumming all over the girl’s face.\n\nSatisfied, you tell her that she can go back to the city, but Lucina stops her. <i>“Wait! You can’t leave like that, its not proper!”</i> she grabs a napkin and starts to clean the face, but you realize that she is using this opportunity to absorb some of your cum too through her hands. \n\nThis gets you hard immediately. When Lucina turns around to face you she can’t miss your still exposed cock. <i>“Oh... That girl left a mess, let me help you darling.”</i> she uses the napkin to clean your cock, and although her hands are covered by a soft fabric, it is delightful to have her touch you with such care. Sadly she doesn’t go any further, dressing you again once she is done. \n\nWith the ordeal done, you tell to Lucina that you think that she is ready for the final step, and to be met the most important members of your court. \n\n<i>“Really "+ GameControl.playerName +"? That makes me very happy! I’m dying to see the old and new faces that lead the kingdom nowadays!”</i>\n\nYou nod and stand up, telling her that you are tired now and need to rest, but you are happy that she helped you to sort out today’s audiences. <i>“I’ll be always happy to help you, "+ GameControl.playerName +"!”</i> you thank her one more time and run towards your chamber, and the moment you close the door you start to jack off.\n\nIt surprises you that after a minute you can hear that someone is at the other side of the door. Is that Lucina? Or one of your horny servants? The truth is that it doesn’t matter and you turn around to face the door and give a show to whoever is at the other side.\n\nThe show is somewhat short, since you were already about to explode when Lucina caressed you downstairs, but you can’t deny that this has been a great and fulfilling orgasm considering it was spent alone.\n\nYou wait a couple of minutes before opening the door. As expected there is no one there, but you see that there is some blue gooey stuff in the ground. It was Lucina all along! Well, you can’t say that today you weren’t successful. ";
			} else {
				Board.text += "\n\nShe walks towards you and with skilled hands exposes your pussy. Lucina grows really nervous <i>“Is... Are you sure this is okay "+ GameControl.playerName +"?”</i> she says while the girl is already heading down towards your sex, stuffing her mouth with your nether parts and grinding your bud with the tip of her tongue. You nod at your nanny and tell her that this girl still needs a release anyway. Judging by how she greedily fingers herself whilst busily attending you, you point out that she’s enjoying this as much as you are.\n\n<i>“Thats not what I meant... uh?!”</i> she is surprised when you hold her hand, and argue that this is how business are conducted nowadays. You feel successful when she holds your hand tighter instead of moving away, and you do your best to keep yourself from cumming as much as you can.\n\nMeanwhile Lucina is fixated on your pussy and the girl licking it. You can see that against her own will her tentacles start to act, subtly touching her breasts and pussy at first, but it doesn’t take long until the act is more obvious.\n\nWith the thirsty mouth working you down there and the sight of your nanny masturbating it becomes impossible to hold back. You let out a shuddered gasp before cumming all over the girl’s face.\n\nSatisfied, you tell her that she can go back to the city, but Lucina stops her. <i>“Wait! You can’t leave like that, its not proper!”</i> she grabs a napkin and starts to clean the face, but you realize that she is using this opportunity to absorb some of your fluids too through her hands. \n\nThis gets you aroused again, your outfit drenched in saliva and your fluids at this point.  When Lucina turns around to face you she can’t miss your still exposed body. <i>“Oh... That girl left a mess, let me help you darling.”</i> she uses the napkin to clean your cunt, and although her hands are covered by a soft fabric, it is delightful to have her touch you with such care. Sadly she doesn’t go any further, dressing you again once she is done. \n\nWith the ordeal done, you tell to Lucina that you think that she is ready for the final step, and to be met the most important members of your court. \n\n<i>“Really "+ GameControl.playerName +"? That makes me very happy! I’m dying to see the old and new faces that lead the kingdom nowadays!”</i>\n\nYou nod and stand up, telling her that you are tired now and need to rest, but you are happy that she helped you to sort out today’s audiences. <i>“I’ll be always happy to help you, "+ GameControl.playerName +"!”</i> you thank her one more time and run towards your chamber, and the moment you close the door you start to plumb your slit with soaked fingers.\n\nIt surprises you that after a minute you can hear that someone is at the other side of the door. Is that Lucina? Or one of your horny servants? The truth is that it doesn’t matter and you turn around to face the door and give a show to whoever is at the other side.\n\nThe show is somewhat short, since you were already about to explode when Lucina caressed you downstairs, but you can’t deny that this has been a great and fulfilling orgasm considering it was spent alone.\n\nYou wait a couple of minutes before opening the door. As expected there is no one there, but you see that there is some blue gooey stuff in the ground. It was Lucina all along! Well, you can’t say that today you weren’t successful. ";

			}


			if (NPCCharList.CharFollower [iLucina].charCorruption > 50) {
				QuestControl.lucinaQuest = 7;
			} else {
				QuestControl.lucinaQuest = 8;
			}
			QuestsController.RemoveID (6006);
			Quest LucinaQuest8 = new Quest ();
			QuestsController.createQuest (LucinaQuest8, "The meeting.", "You decide to present Lucina to the rest of your retainers now that she has recovered.", 62, 6007);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 7) {
			CityControl.city100Corruption -= 5;

			Board.text = "You end up agreeing with Lucina and punishing the girl according to the law. Although not the most fun outcome, you are certain that you will send a message for those who love to expose themselves in the public.\n\n<i>“I’m glad that you did the right thing "+ GameControl.playerName +", we make a great team together, don’t you think?”</i> she smiles at you and holds your hand, you nod and agree with her.\n\nThe rest of the day goes by, with nothing noticeable for you.\n\nWith the whole ordeal done, you tell to Lucina that you think that she is ready for the final step and to meet the most important members of your court. \n\n<i>“Really "+ GameControl.playerName +"? That makes me very happy! I’m dying to see the old and new faces that lead the kingdom nowadays!”</i>\n\nYou are as excited as she is: Having Helena, Abbadon, and Alba meet her is an important step, and you can only hope that everything goes smoothly. It’s not like they haven’t have their own share of experience dealing with <i>special</i> circumstances, but you wonder if having a goo girl at your side would be too much for them to tolerate. \n\nYou tell Lucina that the two of you should go to rest and get ready for tomorrow. <i>“I agree my love, I’m really tired, but it’s been a productive day, we must keep going tomorrow!”</i> she gives you a kiss on the cheek before she leaves the throne room, while you go back to your chamber to rest. ";
			if (NPCCharList.CharFollower [iLucina].charCorruption > 50) {
				QuestControl.lucinaQuest = 7;
			} else {
				QuestControl.lucinaQuest = 8;
			}
			QuestsController.RemoveID (6006);
			Quest LucinaQuest8 = new Quest ();
			QuestsController.createQuest (LucinaQuest8, "The meeting.", "You decide to present Lucina to the rest of your retainers now that she has recovered.", 62, 6007);
			endTurnFun ();
			return;
		}

		///////////////////////////// Keep going / finish

		if (selector == 0 && confirmationControl == 8) {
			NPCCharList.CharFollower [iLucina].charCorruption = 100;

			int dickcount = 0;
			if (NPCCharList.CharFollower [iHelena].dickSize > 0) {
				dickcount += 1;
			}
			if (NPCCharList.CharFollower [iAbbadon].dickSize > 0) {
				dickcount += 1;
			}
			Board.text = "Helena brings out a box that’s loaded with sex toys, lube and strap-ons, handing them out to whoever needs them for what is about to come.";

			if (dickcount >= 1) {
				Board.text += "\n\nEveryone gets ready as quickly as possible, with their dicks and straps shinning with the special mix that will enhance the sensitivity of their skin. ";
			} else {
				Board.text += "\n\nEveryone gets ready as quickly as possible, with their straps shinning with the special mix that will enhance the sensitivity of their skin. ";
			}
			Board.text += "\n\nYou ask Lucina to kneel, while the group forms a circle around her.\n\n<i>“Y-yes darling.”</i> although she is aroused you can also see that she is nervous, unused to the idea of serving so many people at the same time.\n\n<i>“Don’t worry, you’ll be fine girl, just let us do our job!”</i> says Alba while she softly slaps Lucina’s face.\n\n<i>“What should I-”</i> before she can finish Abbadon has already pushed himherself inside her mouth, while Alba takes her hands and puts them to good use on herself and Helena. ";
			if (NPCCharList.CharFollower [iHelena].attWillpower >= 66) {
				Board.text += "\n\nJust before Lucina is about to service you Helena strikes you behind your leg, forcing you to kneel too. <i>“Come on "+ GameControl.playerName +", you know you want to serve us too!”</i>\n\nYou are about to protest but Lucina kisses you <i>“It’s fine darling, lets serve these beautiful girls.”</i>\n\nShe kisses you again but this time Helena’s gets in the way, forcing you and your nanny start to lick and suck your maid. \n\n<i>“That’s it, that’s a good slut. But that’s not enough, you have guests! Aren’t you also going to serve them? Bend over now and offer them your asses!”</i> you immediately follow her orders, presenting your ass to Alba. Lucina seems reluctant at first until she sees how you eagerly dance to Helena’s tune.\n\nThe other two waste no time and start to fuck the both of you hard, while Helena enjoys both of your mouths, more interested in being in control than anything else.\n\n<i>“Ahh... You have trained "+ GameControl.playerName +" very well Helena! This ass is delightful!”</i> Says Alba.\n\n<i>“And... Ahh... This woman isn’t bad at all... such a great addition to the kingdom!”</i> \n\nThe three of them share a kiss, and keep touching themselves and your bodies until they are ready for their climax.\n\n<i>“W-Wait, don’t cum yet! Let’s give them a welcome they wont forgive!”</i> says Helena and they stop, groaning with need.\n\nHelena holds Alba and starts to masturbate in front of you two. <i>“Come on open your mouth wide, you gonna hold it in your mouth until I say so!”</i>\n\nSeconds later Alba starts to unload her climax in both of your faces, and Helena forces you to clean each other and save every drop as she said. \n\nNext is Abbadon, who also can’t resist the expert hands of Helena for too long. <i>“Ahhh fuck Helena! W-when did you get this good?”</i> heshe says while drenching the two of you.\n\n<i>“Abbadon, so cute, but move aside, it’s my turn now.”</i> Alba shoves Abbadon and starts to get off on your faces.\n\n<i>“Here it comes, don’t waste it!”</i> Helena, even though is the one that has done the most this day, still shoots as much as Alba and Abbadon combined.\n\nWhen she is done you can’t even hold so much in your mouths, forced to swallow a little bit while some of it drips from your faces too.\n\n<i>“Such a wonderful sight.”</i> says Helena, mocking the poor state that you and Lucina are in <i>“Now kiss for a minute and make sure to mix it well. You gonna drink it all Lucina.”</i> before you can react Lucina is already on top of you, her lips pressed against you with such strength that nothing is spilling.\n\nThere’s a moment in the back of your head where you’re sure your mind will break. You don’t even bituce when your nanny starts to suck everything up, filling her body with the fluids of everyone.\n\nYou fall exhausted in Lucina’s arms. <i>“Ah... so cute!”</i> says Alba and they start to laugh.\n\n<i>“Well, this has been a great welcome party, but I don’t think we can keep going any further. Abbadon, Alba, feel free to come again, I may organize another party in the future, we’ll see…”</i> the three of them share a kiss again before they part ways.\n\n<i>“Lucina, take "+ GameControl.playerName +" to its chambers, stay there if you want, I’ll go back to my room and rest, I’m as tired as everyone else here.”</i>\n\nHelena leaves and you fall asleep with a smile on your face. ";
			} else {
				Board.text += "\n\nLucina turns around and starts to serve you too, but once her mouth has tasted everyone she is eager for more.\n\n<i>“Please, make use of my whole body!”</i> your nanny says while she lays down on the ground and spreads her legs open.\n\nAbbadon is the first to go since you’ve already had your own fun with Lucina, but Alba isn’t going to wait for her turn and she starts to use your nanny’s ass. Helena jumps on Lucina’s face and the eager tongue of your nanny serves her, while you sit on her lap and allow her four tentacles to take care of you.\n\nThe entire group switches many times, fondling each other and sharing kisses. When all of you are about to climax you stop them and tell them that you need to make this night unforgettable to Lucina.\n\nYour nanny kneels again in the middle of the florr while the others stand and take their places. You first hold Abbadon from behind and start to masturbate himher, playing with hisher chest and kissing hisher neck. When heshe is about to cum you command to Lucina to open her mouth. \n\nAbbadon starts to shoot all of hisher load in the face of your nanny, and you order her to hold everything that lands in her mouth until you say so.\n\nThe next one to cum is Alba, the most evidently perverse of them all. <i>“I wish I could kiss her right now and share all of that treasure...”</i>\n\nLastly, Helena and you mutually masturbate and climax at the same time in your nanny’s face, drenching it in your fluids. \n\nAt this point so much has landed on Lucina that she has been forced to swallow and spill a little bit, nonetheless you are happy that she has been able to hold most of it in her mouth.\n\nYou command her to gargle with the lurid mixture but she happily does so. When you think she’s had enough you tell her to swallow, and her body immediately absorbs the fluids. \n\nImpressed, you tell her to stand up and the five of you engage in a long kiss, sharing saliva and a little bit of the fluids that are still in Lucina’s mouth. \n\n<i>“Hmmm... This has been great "+ GameControl.playerName +", you need to make parties like this more often!”</i> says a very sweaty Alba. \n\n<i>“I agree, this has been a very intense experience... I hope we can keep going soon.”</i> agrees Abbadon while heshe starts to dress again, ready to leave. \n\n<i>“Ma’am its a pleasure to have you back.”</i> says Helena once more, before she leaves the room, looking out for servants to help her to clean the mess.\n\n<i>“Thank you all... It’s great to be back, the future is better than I expected, I don’t know why I was so fond to the past.”</i> Lucina laughs, and everyone shares her happiness. \n\nWith the ordeal done everyone leaves, and Lucina follows you to your chamber to sleep at your side. There, you fall asleep with a smile on your face in a minute.";
			}

			NPCCharList.CharFollower [iLucina].isRecruited = true;

			QuestControl.lucinaQuest = 500;
			QuestsController.RemoveID (6007);
			QuestsController.RemoveID (7000);
			Quest ItzelQuest1 = new Quest ();
			QuestsController.createQuest (ItzelQuest1, "Faith reborn.", "A new religious figure arrives to the city, bringing with it hope.", 63, 7000);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 8) {
			NPCCharList.CharFollower [iLucina].charCorruption = 100;

			Board.text = "You think that Lucina has had enough for a single day, but you are happy to see how things have turned out. You tell the crowd that this is all for today, but you are eager to invite them again and have some fun. \n\n<i>“Very well, I look forward to that!”</i> says Abbadon before heshe starts to dress up, getting ready to leave.\n\n<i>“Hey Lucina, we didn’t get the chance to have much fun today, but you should come to my estate! I’ll show you the place, </i>and<i> some really good tricks that you can use with "+ GameControl.playerName +" too.”</i> says Alba, slapping your nanny’s ass one last time before she leaves the place, still naked.";
			if (NPCCharList.CharFollower [iHelena].attWillpower >= 66) {
				Board.text += "\n\n<i>“Well Lucina, a lot of things have changed around here, you need to learn a couple of things about who’s the boss around now… but I’m certain that you will like it.”</i> Lucina, now more confident and corrupted, isn’t as eager to accept your maid’s commands, but she doesn’t seem to want a fight right away. Better to end the night on a pleasant note.";
			} else {
				Board.text += "\n\n<i>“It’s great to have you back ma’am, I’ll be ready to serve you whenever you need me.”</i> says Helena, bowing to your nanny before she slips away to look for servants to help her to clean the mess in the living room.";
			}
			Board.text += "\n\n<i>“Thank you all for your visit today, I hope you visit often, or I may go to your houses if "+ GameControl.playerName +" wants to come too.”</i> All of them say their final goodbyes and leave the place. \n\nYou stay with Lucina a little bit longer and talk about the evening. \n\n<i>“This... this new world is exciting, it’s not what we used to have, but I can see why you like it so much. I hope you can teach me everything that needs to be learned.”</i> she gives you a short kiss in the mouth, and when that’s done you tell her that you will do that with pleasure. \n\n<i>“Fine my darling, let’s go and rest now, I’m exhausted.”</i> you hold her by the hand and accompany her to her chamber, before parting ways.\n\nWhen you arrive to your room you pass out in barely a minute, with a big smile across your face in the knowledge that you’ve successfully gained a great ally for your cause. You are certain that your nanny will be a great asset in your quest to corrupt the city. ";
			NPCCharList.CharFollower [iLucina].isRecruited = true;

			QuestControl.lucinaQuest = 500;
			QuestsController.RemoveID (6007);
			QuestsController.RemoveID (7000);
			Quest ItzelQuest1 = new Quest ();
			QuestsController.createQuest (ItzelQuest1, "Faith reborn.", "A new religious figure arrives to the city, bringing with it hope.", 63, 7000);
			endTurnFun ();
			return;
		}

		///////////////////////////// Lucina pussy / Lucina dick 

		if (selector == 0 && confirmationControl == 50) {
			string C1 = "\n\nShe cuddles with you after you two are finished.";
			if (WorldControl.tagControl [5]) {
				C1 += "\n\n<i>“"+ GameControl.playerName +" that was great... I love my new body... Do you think next time we should invite the servitude in? I would love to know how many cunts and cocks I can handle at the same time...”</i>";
			} else {
				C1 += "\n\n<i>“"+ GameControl.playerName +" that was great... I really love my new body, it’s an experience so unique... we need to keep doing this.”</i>";
			}
			C1 += "\n\nYou tell her that you love the idea, and soon the two of you fall asleep. ";

			if (GameControl.dick1Size > 0) {
				Board.text = "<i>“I knew you couldn’t resist my natural charm, now eat it!”</i> she starts to grind her body against you again and you gladly start to serve her.\n\nYou keep fucking her throat while your hands join in too, driving a few fingers into her. Quickly though you realize there is no point on going with anything less than your whole fist; it’s not like it will harm her. \n\nThe two of you yell and enjoy yourselves very loudly, and you can hear that there is a small orgy developing on the other side of the door. Your servants are evidently put in the mood by your lurid antics.\n\nLucina orgasms at least three times thanks to you, and when you finally cum she creates the perfect sucking vacuum that manages to drain you to the last drop in one single, long climax. Without a doubt it’s the most powerful cum you’ve had thanks to her unique body.";
				Board.text += C1;
			} else {
				Board.text += "<i>“I knew you couldn’t resist my natural charm, now eat it!”</i> she starts to grind her body against you again and you gladly start to serve her.\n\nShe keeps fucking you with her tongue while your hands join in too, driving a few fingers into her. Quickly though you realize there is no point on going with anything less than your whole fist; it’s not like it will harm her. \n\nThe two of you yell and enjoy yourselves very loudly, and you can hear that there is a small orgy developing on the other side of the door. Your servants are evidently put in the mood by your lurid antics.\n\n\nLucina orgasms at least three times thanks to you, and when you finally cum she creates the perfect sucking vacuum that manages to drain you to the last drop in one single, long climax. Without a doubt it’s the most powerful cum you’ve had thanks to her unique body.";
				Board.text += C1;
			}
			QuestControl.lucinaQuest = 52;
			QuestsController.RemoveID (6005);
			Quest LucinaQuest7 = new Quest ();
			QuestsController.createQuest (LucinaQuest7, "Tales from the past III", "Today Lucina will join you in the throne room, to help you sort out the different challenges that you face.", 62, 6006);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 50) {
			string D1 = "\n\nShe cuddles with you after you two are finished.";
			if (WorldControl.tagControl [5]) {
				D1 += "\n\n<i>“"+ GameControl.playerName +" that was great... I love my new body... Do you think next time we should invite the servitude in? I would love to know how many cunts and cocks I can handle at the same time...”</i>";
			} else {
				D1 += "\n\n<i>“"+ GameControl.playerName +" that was great... I really love my new body, it’s an experience so unique... we need to keep doing this.”</i>";
			}
			D1 += "\n\nYou tell her that you love the idea, and soon the two of you fall asleep. ";
			if (GameControl.dick1Size > 0) {
				Board.text = "<i>“I see you still want to drink my milk...”</i> her body transforms rapidly, and in matter of seconds you have a big, hard cock slapping your face… with considerable testes too.\n\n<i>“Open wide darling!”</i> You open your mouth and allow her to push forward. Although you expected her to just shove it in she takes the initial penetration carefully, going slowly until her balls have a gently collide with your face.\n\nShe starts to slowly move her hips while her mouth continues servicing you. \n\nWanting to make her experience more unforgettable, you grab her by her butt and start to face fuck her. \n\n<i>“Ahh!... I didn’t think you could handle it! I apologize for my mistake "+ GameControl.playerName +"”</i>\n\nWithout further ado she starts to move her hips faster, the sound of her balls slapping your face loudly echoing the room. \n\nThe two of you yell and enjoy yourselves very loudly, and you can hear that there is a small orgy developing on the other side of the door. Your servants are evidently put in the mood by your lurid antics.\n\nYou can’t help yourself and cum first, her vacuum mouth too strong for any cock, and you can see how your seed travels through her body and mixes with her own fluids before she shoots them into your mouth, filling it until it spills on your face.\n\nLucina turns around and kisses you, sipping some of the sexual mixture back into her body. <i>“Delicious...”</i>";
				Board.text += D1;
			} else {
				Board.text = "<i>“I see you still want to drink my milk...”</i> her body transforms rapidly, and in matter of seconds you have a big, hard cock slapping your face… with considerable testes too.\n\n<i>“Open wide darling!”</i> You open your mouth and allow her to push forward. Although you expected her to just shove it in she takes the initial penetration carefully, going slowly until her balls have a gently collide with your face.\n\nShe starts to slowly move her hips while her mouth continues servicing you. \n\nWanting to make her experience more unforgettable, you grab her by her butt and start to face fuck her. \n\n<i>“Ahh!... I didn’t think you could handle it! I apologize for my mistake "+ GameControl.playerName +"”</i>\n\nWithout further ado she starts to move her hips faster, the sound of her balls slapping your face loudly echoing the room. \n\nThe two of you yell and enjoy yourselves very loudly, and you can hear that there is a small orgy developing on the other side of the door. Your servants are evidently put in the mood by your lurid antics.\n\nYou can’t help yourself and climax first, her mouth too skilled for anyone to resist, and you can see how your fluids travels through her body and mixes with her own fluids before she shoots them into your mouth, filling it until it spills on your face.\n\nLucina turns around and kisses you, sipping some of the sexual mixture back into her body. <i>“Delicious...”</i>";
				Board.text += D1;
			}

			QuestControl.lucinaQuest = 52;
			QuestsController.RemoveID (6005);
			Quest LucinaQuest7 = new Quest ();
			QuestsController.createQuest (LucinaQuest7, "Tales from the past III", "Today Lucina will join you in the throne room, to help you sort out the different challenges that you face.", 62, 6006);
			endTurnFun ();
			return;
		}

		///////////////////////////// Fuck her / pimp her

		if (selector == 0 && confirmationControl == 51) {
			Board.text = "\n\nYou decide to put on a show for your citizens, showing them that you’re so good you can even train your nanny into an utter slut. With a simple command the slut kneels in front of you, and with a loud voice you tell the people around that you are going to fuck her brains out… Or would, if she had any. Soon the crowd increases in size, and when you feel that enough have gathered up enough you decide its time to begin. ";

			if (GameControl.dick1Size > 0) {
				Board.text += "\n\nWithout further ado you take your cock out. Some people applaud or cheer at your lecherous act, and you can see that some people are also getting into the mood for some action of their own. \n\nYou grab Lucina by the neck <i>“Uhh w-”</i> before she can ask her question you shove your cock through her face. She rapidly adapts and changes so her mouth is actually surrounding your meat before loudly sucking you off, slurping her way to a total mess.\n\nAlthough she is intense in her ministrations, nothing beats grabbing her “hair” and face fucking her on your own terms. It doesn’t take long until you feed her the first doses of cum for the day. \n\n<i>“Ahhh... ahh... tasty!”</i> Lucina’s voice is breathless despite not needing to breathe at all, and she’s dripping wet after being used (and in preparation of what’s to come)\n\nYou push her to the ground and she raises her butt, and you drive your way into her ass. She starts to yell out, claiming she’s a bitch in heat. By this time the crowd around you has become an orgy, with the two of you at the center of it all.\n\nYou ride her ass and pussy, and the pleasure overcomes her, the excitement of being seen and fucked too much for her still feeble mind. \n\nShe starts to moan and ask for more, and after she has squirted over you at least three times your cock is ready to explode again.\n\n<i>“Yes "+ GameControl.playerName +"! I’ll take it all!”</i> her precious body tightens around your cock, creating nearly-painful pressure before releasing it. You start with a shout and fill her with your seed, until it swims around in her depths enough to changing her colour a little bit.\n\nShe creates a vacuum and sucks out everything left inside of you until it aches in your prostate, and exhausted you fall on top of her soft body. \n\n<i>“That was great sweetheart...”</i> she gives you a kiss and embraces you. The orgy around you keeps going for an hour, and when you recover you have your way with Lucina once more before the two of you finally return to your castle.\n\n<i>“Today was great "+ GameControl.playerName +", I really enjoy being your bitch, we need to repeat this in the future... maybe tomorrow?”</i> you kiss your nanny and tell her that you will think about it, since there is also a lot of work to do. \n\n<i>“I kinda forgot about the kingdom, but maybe I can help you with that?”</i> you tell her that she probably will be of use, but for now the two of you have to rest. \n\n<i>“Very well darling, we’ll continue tomorrow then.”</i> the insistent girl kisses you before going back to her chamber, and you back to yours, with your mind wondering about what you can do with her and how to advance your plans with the city using her. ";

			} else {
				Board.text += "\n\nWithout further ado you expose your cunt. Some people applaud or cheer at your lecherous act, and you can see that some people are also getting into the mood for some action of their own. \n\nYou wear one of your favorite long textured strap-ons and grab Lucina by the neck <i>“Uhh w-”</i> before she can ask her question you shove your strap through her face. She rapidly adapts and changes so her mouth is actually surrounding the fake phallus before loudly sucking you off, slurping her way to a total mess.\n\nAlthough she is intense in her ministrations, nothing beats grabbing her “hair” and face fucking her on your own terms. It doesn’t take long until you think that she is ready to get fucked for real. \n\n<i>“Ahhh... ahh... so harsh! I love it!”</i>  Lucina’s voice is breathless despite not needing to breathe at all, and she’s dripping wet after being used (and in preparation of what’s to come)\n\nYou push her to the ground and she raises her butt, and you drive your way into her ass. She starts to yell out, claiming she’s a bitch in heat. By this time the crowd around you has become an orgy, with the two of you at the center of it all.\n\nYou ride her ass and pussy, and the pleasure overcomes her, the excitement of being seen and fucked too much for her still feeble mind. \n\nShe starts to moan and ask for more, and after she has squirted over you at least three times your body is about to climax too.\n\n<i>“Yes "+ GameControl.playerName +"! Let’s cum together!”</i> she turns around and starts kissing you, her tentacles immediately find their way into your own cunt and start to fuck you up to your body’s utter limit before the both of you climax. Her body absorbs most of your fluids, and she shares them with you through her mouth. \n\nYou end up exhausted and falling on her arms, using her soft bosoms as pillows.\n\n<i>“That was great sweetheart...”</i> she gives you a kiss and embraces you. The orgy around you keeps going for an hour, and when you recover you have your way with Lucina once more before the two of you finally return to your castle.\n\n<i>“Today was great "+ GameControl.playerName +", I really enjoy being your bitch, we need to repeat this in the future... maybe tomorrow?”</i> you kiss your nanny and tell her that you will think about it, since there is also a lot of work to do. \n\n<i>“I kinda forgot about the kingdom, but maybe I can help you with that?”</i> you tell her that she probably will be of use, but for now the two of you have to rest. \n\n<i>“Very well darling, we’ll continue tomorrow then.”</i> the insistent girl kisses you before going back to her chamber, and you back to yours, with your mind wondering about what you can do with her and how to advance your plans with the city using her. ";

			}
			NPCCharList.CharFollower [iLucina].isRecruited = true;

			QuestControl.lucinaQuest = 500;
			QuestsController.RemoveID (6006);
			QuestsController.RemoveID (7000);
			Quest ItzelQuest1 = new Quest ();
			QuestsController.createQuest (ItzelQuest1, "Faith reborn.", "A new religious figure arrives to the city, bringing with it hope.", 63, 7000);
			endTurnFun ();

			return;
		}

		if (selector == 1 && confirmationControl == 51) {
			Board.text = "The best way to show to your people how good you are at training sluts is by giving them a personal taste. \n\nYou tell to the crowd around you that for a modest fee, they can enjoy the many delights that your whore can offer. \n\nThe people are curious thanks to the exotic nature of Lucina, but her voluptuous curves are tempting for anyone with a dick, and her long and agile tentacles are with no doubt something that any lady would like to try.\n\nIt doesn’t takes long until the first guy steps up and dumps a fistful of money into your waiting hands.\n\nHe walks towards Lucina but has trouble unzipping his pants, to his surprise she undresses him in an instant with her tentacles. Before he can finish thanking her she pulls him close and engulfs his still semi-erect cock with her hungry mouth, loudly slurping him. \n\nThe poor man is no challenge to Lucina’s vacuum mouth, who drives him to orgasm in only a minute. She absorbs the man’s seed and spreads her legs open, enticing the crowd to keep going. <i>“Who’s next?”</i> with these words you receive a golden shower... of coins, while the crowd start to jump on top of her, both men and women.\n\nShe struggles a little bit at first, trying to get used to handling so many people, but she is a natural, and with her four tentacles, hands, feet, mouth, breasts, pussy and ass she can take at least 8 people at the same time.\n\nA couple of girls are riding her tentacles and kissing, a beautiful lesbian scene, while two very big guys are hungrily double-team her, balls slapping loudly. \n\nMeanwhile she is taking care of a petite man, motherly taking his cock in her mouth while putting one of her fingers inside his ass and milking his cute little balls.\n\nIts amazing how fast she makes someone cum… and that’s great since the number of people that want their way with her is huge. If she took more than 5 minutes with each a single day wouldn’t be enough to handle them all. <i>“Ahh! Yes! Fuck this fucking whore! Fuck it good!”</i> she yells, enjoying two new bulking dicks that are working her pussy at the same time. \n\nHer typical blue color is turning white thanks for all the sperm that she has absorbed at this point, and her body has swelled a little bit too, but in all the good places. You put a stop to this when the sun sets.\n\n<i>“cocks... I love cocks... more...”</i> its the only thing that the broken mess of Lucina can mumble at this point.\n\nYou ask to a guard to take her to the castle while you count the money: Roughly 500 gold coins, not bad for a single day. \n\n The next day you talk with her once she has recovered.\n\n<i>“"+ GameControl.playerName +" yesterday was great, I never had so much pleasure in a single day... This new body, new life, is really exciting!”</i>\n\nShe kisses you, her mouth still reeking to all the sex she had yesterday. She grabs you with her tentacles and uses her mouth to eat you up, making you climax very fast.\n\n<i>“Please "+ GameControl.playerName +", keep using my body to enrich the kingdom.”</i> you smile and agree to her demands.\n\n<i>“Great! Now let’s celebrate with real sex!”</i> unable to refuse her the two of you spend the rest of the day fucking again.\n\nThat night, when you are back to your chambers, you are certain that Lucina is going to be the perfect asset to corrupt this city.\n\n";
			GameControl.charGold += 500;
			NPCCharList.CharFollower [iLucina].isRecruited = true;

			QuestControl.lucinaQuest = 500;
			QuestsController.RemoveID (6006);
			QuestsController.RemoveID (7000);
			Quest ItzelQuest1 = new Quest ();
			QuestsController.createQuest (ItzelQuest1, "Faith reborn.", "A new religious figure arrives to the city, bringing with it hope.", 63, 7000);
			endTurnFun ();
			return;
		}

		///////////////////////////// Hunt / Sex

		if (selector == 0 && confirmationControl == 100) {

			Board.text = "You get your gear ready and head to the forest with Lucina. On your way out a small crowd of citizens surround you two, curious about your latest acquisition. Although some of them sound scared or even offended by your choice, you can hear a lot of praise or envious remarks for having such exotic beauty at your side.\n\nWhen the two of you arrive at the peaceful outskirts of the city you realize Lucina is aroused, apparently thanks to the many looks and compliments she received minutes ago. At least she is still able to understand your language, even though she seems to have stopped speaking.\n\nCarefully, you venture into the forest with Lucina following you closely. It takes a while for you to find a beast wandering around; a thirsty wolf boy too distracted drinking to realize that you are stalking him, the perfect prey for Lucina.\n\nYou order her to attack and she immediately springs at the unaware victim. Although the wolf boy has some experience fighting, as most beasts that live in the wild, his attacks are useless against the gooey body of your mother/nanny, and she manages to pin him down.\n\nThe beast yells and insults you both, but Lucina calms him down with the gentle touch of her tentacles. It doesn’t take much until the beast submits to her.\n\nNow, you can see how Lucina’s primal urges are rising, and for now you think she’s had enough training. Then again, you’re already here. You could let her have fun with her prey, or return to your castle.";
			option0Name.text = "Let her";
			option1Name.text = "Return";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 101;
			return;
		}

		if (selector == 1 && confirmationControl == 100) {
			Board.text = "There is no better way to bring out her lustful and animal nature that by raw, wild, uncontrolled sex. The amount of sex she needs in order to be broken is probably too much to handle by yourself, but you know you can use some drugs that would make her extra sensitive to help you with this task. The other option of course would be to gather a group of willing participants to have a party with the two of you.\n\nIt comes down to taste, then; which kind of sex should you have with her?";
			option0Name.text = "Private";
			option1Name.text = "Group";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 102;
			return;
		}

		///////////////////////////// Let her / Return

		if (selector == 0 && confirmationControl == 101) {
			// CODE TO ADD A SEX WOLF BOY
			WorldControl.day += 4;
			Board.text = "There is no harm in letting her have some fun, and decide to wait for her to finish with the beast. \n\nUnrestrained, Lucina grabs the beast with her tentacles and lies it on the ground face up. Although more relaxed than before, the being still struggles and fights her a little bit, but when she grabs his balls he stops, fearing she might harm his jewels.\n\nLucina’s face isn’t threating at all however; after she calms him down a bright smile appears on her face, happy with what she’s found. She keeps exploring his body in depth, slowly jerking his semi flaccid cock while with her tentacles get dangerously close to his asshole. \n\n<i>“Mmmgh... w-what are you doing?!”</i> says the beast, talking for the first time, but Lucina just laughs when she starts to push inside him.\n\n<i>“Ahh!”</i> he yells with surprise, but apparently your nanny knows her way around the back door of men, because his cock immediately gets hard when she pushes his rectal pleasure-button. \n\nNow that he is ready she sits on top of him, ready to ride his cock. Although the scene is anatomically correct, you wonder if it does matter at all from where she is fucked, since pretty much you can fuck any part of her body with equal results, but this behavior has probably more to do with the former memories your trainee.\n\nFinally in position, she starts to haul her body up and down with deep thrusts until the beast’s balls slap loudly against her. The poor monster can’t withstand such energy and his first orgasm jets out with just the third or forth pound against his body. Thanks to Lucina’s expertize in anal-based tentacle-play, it seems she can keep him stiff and ready.\n\nThe lascivious scene continues for ten long minutes or ensuring every last precious drop of jizz is milked out of her monster-fuck-boy’s cock. By the time she finishes the entirety of her body has shifted to a lighter tone. She looks tired but satisfied while the beast, defeated and exhausted, is passed out. You decide to take it with you, probably the safest thing for him too in this state. \n\nShe tries to play with him on your way back, and you are happy to see that she is getting more comfortable with her new lifestyle, behaving freely and playing around like a simple minded animal. \n\nYou put the recently captured beast in your dungeon and take Lucina to her quarters, where you give her a treat for her good performance today. She hugs you and kisses you, thanking you in her own manner for the prize. \n\nAlthough she has now partially internalized her position, she is still far from being tamed, since she still misbehaves a lot, specially if you aren’t around, nonetheless you are happy with the progress you have so far. ";
			QuestControl.lucinaQuest = 101;
			QuestsController.RemoveID (6002);
			Quest LucinaQuest4 = new Quest ();
			QuestsController.createQuest (LucinaQuest4, "Taming the beast", "You'll now train Lucina into a loyal pet.", 62, 6003);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 101) {
			// CODE TO ADD A SEX WOLF BOY
			QuestControl.lucinaQuest = 101;
			QuestsController.RemoveID (6002);
			Quest LucinaQuest4 = new Quest ();
			QuestsController.createQuest (LucinaQuest4, "Taming the beast", "You'll now train Lucina into a loyal pet.", 62, 6003);
			Board.text = "You stop Lucina before its too late but before she let’s him go, you knock him out with a swift punch to the jaw, so that you can take him back to your castle with you. \n \nShe tries to play with him on your way back, and you are happy to see that she is getting more comfortable with her new lifestyle, behaving freely and playing around like a simple minded animal. \n\nYou put the recently captured beast in your dungeon and take Lucina to her quarters, where you give her a treat for her good performance today. She hugs you and kisses you, thanking you in her own manner for the prize. \n\nAlthough she has now partially internalized her position, she is still far from being tamed, since she still misbehaves a lot, specially if you aren’t around, nonetheless you are happy with the progress you have so far. \n";
			endTurnFun ();
			return;
		}

		///////////////////////////// Private  / Group

		if (selector == 0 && confirmationControl == 102) {
			Board.text = "This is a delicate task that only you can handle. You go to your laboratory and get one special potion ready: This one will make the whole body of Lucina erogenous, perfect to overwhelm her with pleasure and break her mind apart. \n\nWhen you have everything ready you take her to your chamber. There, you give her the potion to drink while you get yourself naked. When you are done you can see that Lucina is kneeling down and grabbing her stomach, panting, her body dripping ooze. You softly slap her face and she moans, almost orgasming with such casual act.";
			if (GameControl.dick1Size > 0) {
				Board.text += "\n\nYou smile and slap her face with your hard cock a couple of times, which causes Lucina’s first orgasm of the night. \n\nAlthough you would love to fool around with her you have a task to accomplish, and you can’t waste more time. You grab her by the back of her head and thrust your cock deep in her mouth. \n\n<i>“Ngggh!... Nggh!”</i> Lucina cant keep her voice down, every single thrust makes her climax, and each time she wants more and more. You face fuck her for five minutes until you feed her your first load. She happily swallows it and you can see how your sperm swims in her insides. \n\nBut at this point she craves too much to wait for you to rest and jumps on you, throwing you to the ground. There, her body engulfs your cock and she starts to ride you, desperately impaling herself with your rod. You try to stay in charge and grab her voluptuous breasts with your hands, giving them a hard massage and pinching them to the point that they break apart in your hands, just to reform seconds later. \n\nYou two fuck wildly for hours, until the effect of the drugs wear off and you are out of stamina. When you stand up, you can see her bluish body has become a near-white teal thanks to all the seed she absorbed from you, and her face seems to drip with raw eroticism.\n\nExhausted, you lie on the bed to rest, knowing that today you were successful in training your nanny. ";
			} else {
				Board.text += "\n\nYou smile and slap her breasts a couple of times, which causes Lucina’s first orgasm of the night. \n\nAlthough you would love to fool around with her you have a task to accomplish, and you can’t waste more time. You order her to stand up while you kneel, thrusting your whole hand into her dripping pussy.\n\n<i>“Ngggh!... Nggh!”</i> Lucina cant keep her voice down, every single thrust makes her climax, and each time she wants more and more. You keep fisting her for five minutes until her knees give up with the pleasure. She pretty much melts for a minute while she recovers from such experience.\n\nBut you shouldn’t have let your guard down, since your nanny is still craving for more.  With a surprise attack she throws you to the ground and sits on your face, forcing you to eat her out, drugging you too in the process. With the two of you highly sensitive now, the next two hours are just continuous pleasure and sex, using everything at your disposal to please each other; her tentacles ravaging every hole of you, and using your arms and legs to push deep inside her body. \n\nWhen the drugs finally wear off the two of you almost pass out of exhaustion, but you’ve never been this satisfied in your whole life, and you are glad that this experience was thanks to your current partner. \n\nYou stand up and fall to the bed, ready to rest, and knowing that today you were successful in training your nanny.\n";
			}

			QuestControl.lucinaQuest = 101;
			QuestsController.RemoveID (6002);
			Quest LucinaQuest4 = new Quest ();
			QuestsController.createQuest (LucinaQuest4, "Taming the beast", "You'll now train Lucina into a loyal pet.", 62, 6003);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 102) {
			Board.text = "The quest that lies ahead isn’t something you can do alone, and you decide to invite a group of friends to help you with such task. \n\nIt takes you few days to organize everything, but now a small but varied group of your friends and allies are gathering in your chamber, naked and ready to have their fun with Lucina. \n\nYou give a short speech encouraging them to do their best to break her mind, filling it only with lustful thoughts about being a terribly filthy beast. \n\nWhen that’s over they start to surround Lucina, who is on her knees with a confused look, still ignorant of what’s about to happen. With a hand gesture you signal them to start, and they rapidly approach her, waving their dicks and offering their pussies to her.\n\nShe acts shyly at first, overwhelmed by the caresses given by so many hands, but once she is in the mood she starts to take the initiative herself. She grabs and waves a number of the cocks, opening wide to slurp one of the girls’ pussies. Others see to using her gooey body in unconventional and exotic manners.\n\nNot wanting to be left behind, you eagerly join the group, who allow you to use her front in any way you want. You first start to play with her voluptuous breasts, a place that’s apparently specially sensitive for her, although you wonder if it’s just a psychological effect since her whole body is just goo.";
			if (GameControl.dick1Size > 0) {
				Board.text += "\n\nWith your throbbing cock eager for more, you make her open wide. You start to pull her by her “hair”, face fucking her until you feed her the first load of the night, and now you are ready for the main course; you lie down on a mattress and she immediately understands, sitting on top of you, your cock free in her insides. \n\nThe feeling is very unique: Although not as warm as a normal person, its morphing property means it can perfectly embrace your cock. Her semi-liquid body takes its shape, touching all your special spots at the same time. She starts to move her hips, and with each movement she takes you to heaven, devoting every part of her body to caring for your cock in a way that no regular person ever could.\n\nWithout slowing down even a little bit she bends down and kisses you, and offers you her breasts for you to grab while the two of you keep engaged. \n\nAlthough you are proud of your stamina, dealing with such a beast is too much for you, and you can only take her for minutes at a time before the inevitable happens, the white seed mixing with her blueish body.\n\nSpent for now, your friends practically carry you to a seat while they finally have their chance with your mother/nanny. \n\nYou can see that she accepts every cock and pussy offered to her, but it’s obvious she isn’t as meticulous or careful as she was with you, in this case mostly just using them for her own pleasure instead of their own satisfaction. \n\nDuring that night you would come back to her several times, and everyone would have used her at least thrice by the end of the orgy.\n\nWhen the show is over you can see how Lucina’s face is already changing, more lustful and exquisite than before. Also, you realize that filling her with cum is a great way to feed her too, and you think she is even a little more voluptuous than the last time you measured her.\n\nProud of your training, you fall asleep in your bed and dream about what comes next, since there is still a lot of work to do. ";
			} else {
				Board.text += "\n\nYou kneel in front of her while a couple of your friends help her stand up, keeping her in place. You start to fist her, thrusting your arm deep inside her. She is happy with your rough treatment, panting and moaning with pleasure. You are so focused on taking care of her that you don’t realize when she sneaks a couple of her tentacles behind you, assaulting your pussy and ass with them.\n\nAlthough at first startled by her touch, you soon find out how great these tentacles are for sex, filling every spot inside you like no one else ever could, careful but firm in her actions. \n\nWith such an assault your legs give up and the two of you fall on top of a mattress. Now it’s Lucina who is taking care of you, rubbing your whole body with her arms and tentacles while she sits on your face, an opportunity you use to please her with your mouth. \n\nAlthough you are proud of your stamina, dealing with such a lustful beast is too much for you, and you can only take her for minutes at a time before you’re driven to a hardcore orgasm.  \n\nSpent for now, your friends practically carry you to a seat while they finally have their chance with your mother/nanny. \n\nYou can see that she accepts every cock and pussy offered to her, but it’s obvious she isn’t as meticulous or careful as she was with you, in this case mostly just using them for her own pleasure instead of their own satisfaction. \n\nDuring that night you would come back to her several times, and everyone would have used her at least thrice by the end of the orgy.\n\nWhen the show is over you can see how Lucina’s face is already changing, more lustful and exquisite than before. Also, you realize that filling her with cum is a great way to feed her too, and you think she is even a little more voluptuous than the last time you measured her.\n\nProud of your training, you fall asleep in your bed and dream about what comes next, since there is still a lot of work to do. \n\n";
			}
			QuestControl.lucinaQuest = 101;
			QuestsController.RemoveID (6002);
			Quest LucinaQuest4 = new Quest ();
			QuestsController.createQuest (LucinaQuest4, "Taming the beast", "You'll now train Lucina into a loyal pet.", 62, 6003);
			endTurnFun ();
			return;
		}

		///////////////////////////// pet / guardian

		if (selector == 0 && confirmationControl == 103) {
			Board.text = "You decide that what you need is a loyal pet. Playful and loving, you’ll be proud to show her to your retainers and subjects.\n\nFor you to succeed she needs to learn to follow orders, to stay put against her own temptation. She needs to have only initiative when it’s about pleasing you and those who you order.\n\nAlthough you expected a daunting task on front of you, the truth is that Lucina keeps a lot of her intelligence, and it doesn’t takes too long until she understand that bad behavior gets punished and good behavior rewarded.\n\nUntil you you’ve been scolding her and praising her, but this won’t do for more advanced training, and you need to make a choice; should you use treats, or get close and personal with her rewards? ";
			option0Name.text = "Treats";
			option1Name.text = "Sex";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 104;


			NPCCharList.CharFollower [iLucina].attWillpower = 0; 

			QuestControl.lucinaQuest = 102;
			QuestsController.RemoveID (6003);
			Quest LucinaQuest5 = new Quest ();
			QuestsController.createQuest (LucinaQuest5, "Primal instinct", "You'll now train Lucina into a loyal pet.", 62, 6004);
			return;
		}

		if (selector == 1 && confirmationControl == 103) {
			Board.text = "You would benefit more from having a strong, loyal, unbreakable guardian than a pet; How important can be to entertain guests with your eccentricities, if you end up murdered on your sleep anyway?\n\nFor you to succeed she’ll have to follow your orders, to stay put against her own temptations, but also she needs to have initiative: To look for intruders, to jump in your defense, to take care of you when you’re injured or sick.\n\nAlthough you expected a daunting task on front of you, the truth is that Lucina keeps a lot of her intelligence, and it doesn’t takes too long until she understand that bad behavior gets punished and good behavior rewarded.\n\nUntil you you’ve been scolding her and praising her, but this won’t do for more advanced training, and you need to make a choice; should you use treats, or get close and personal with her rewards? ";
			option0Name.text = "Treats";
			option1Name.text = "Sex";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 105;

			NPCCharList.CharFollower [iLucina].attWillpower = 100;

			QuestControl.lucinaQuest = 102;
			QuestsController.RemoveID (6003);
			Quest LucinaQuest5 = new Quest ();
			QuestsController.createQuest (LucinaQuest5, "Primal instinct", "You'll now train Lucina into a loyal pet.", 62, 6004);
			return;
		}
		///////////////////////////// Treats / sex // from pet

		if (selector == 0 && confirmationControl == 104) {
			Board.text = "Although sex is an amazing act, it also would deplete your stamina too fast, and what you need is an actually efficient way to train her. \n\nYou ask to one of your cooks to prepare her favorite treats and once she has a full plate of them for you, you start your training.\n\n\nYou decide to skip all of the basics and go for something more advanced. Although she wasn’t an amazingly gracious dancer in the past, she at least could keep the pace. \n\nYou grab her hands and start to move around. She is confused at first, but after scolding her she understand she needs to be doing something, and starts to follow your rhythm.\n\nIt doesn't take long until her memory comes back and starts to actually do what she is supposed to do. \n\nPerfect, she earned a treat.\n\nThe next days follow the same pattern: Try a new trick and give her a treat if she does what’s expected, at the very end the task for self control is the most complicated: Putting a treat on the top of her head, the goal for her to stay put until you give the order. \n\nIt doesn’t help that she doesn’t actually needs her mouth to consume things, but can be absorbed from any part of her body. Nonetheless, after punishing many times and sending her to sit on a corner, she finally gets it.\n\nAt the end of the week you have a pet that, if needed, can imitate human behavior with certain tasks, most of them entertaining ones, a curiosity that nonetheless will impress many people in the city, since these creatures are usually mindless.\n\nWith the training done you also stop fearing that she may escape or cause trouble, which means you don’t need to have her on a short leash anymore and can again focus on ruling your kingdom. \n";


			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 104) {
			Board.text = "Considering the lustful nature of Lucina, it is obvious that sexual rewards are going to be the most efficient ones.\n\nThe first task that you give her is sitting. Nothing exciting or interesting. Her partial understanding of your language makes it an easy task. You pat her head in approval and she smiles happy to you, eager to receive more caresses. \n\nYou decide to skip all of the basics and go for something more advanced. Although she wasn’t an amazingly gracious dancer in the past, she at least could keep the pace. \n\nYou decide to skip all of the basics and go for something more advanced. Although she wasn’t an amazingly gracious dancer in the past, she at least could keep the pace. \n\nYou grab her hands and start to move around. She is confused at first, but after scolding her she understand she needs to be doing something, and starts to follow your rhythm.\n\nIt doesn't take long until her memory comes back and starts to actually do what she is supposed to do. \n\nPerfect, as a reward you sit her on a chair and start to fondle her breasts. The poor creature is getting too excited, and you cant resist her charm for too long, giving her a short but intense kiss at the end.\n\nYou fear that you may end up losing control of yourself, but for now you’ve managed to keep yourself calm. Which kind of master would you be otherwise? \n\nThe next days follow the same pattern: Try a new trick and give her a reward. These keep escalating depending on their difficulty: Fingering her, eating her out, playing with her tentacles. \n\nShe starts to correlate sex with good behavior, and considering how easy she is to arouse, she will try to behave like a good girl all the time. \n\nWhen she screws up you just edge her, denying her an orgasm or just isolating her in a corner for a while. Indeed typical punishments like spanking and others are of no use, she ends up enjoying them more, and your current goal isn't to train a masochist. \n\nAt the end of the week and after fucking her countless times she can now behave almost like an human if commanded, mostly for entertaining tasks but nonetheless something that will be an impressive display for your retainers and subjects, who are used to think about these monsters as mindless. \n\nWith the training done you also stop fearing that she may escape or cause trouble, which means you don’t need to have her on a short leash anymore and can again focus on ruling your kingdom. ";

			endTurnFun ();
			return;
		}

		///////////////////////////// treats / sex // from guardian

		if (selector == 0 && confirmationControl == 105) {
			Board.text = "Although sex is an amazing act, it also would deplete your stamina too fast, and what you need is an actually efficient way to train her. \n\nYou ask to one of your cooks to prepare her favorite treats and once she has a full plate of them for you, you start your training.\n\nYou decide to skip all the basic tricks and orders, and go for something more advanced. \n\nYou bring a guard and order her to attack him. The man embraces for impact but Lucina just gives him a friendly hug. Her mindset really needs to be adjusted.\n\nEvery time she fails you punish her; send her to sit on a dark corner for hours, delay her meals, refuse to talk to her. \n\nYou avoid physical punishments like spanking or slapping her; knowing her lustful nature, she may end up enjoying those and turning into a masochist. Not an awful thing in itself, but not your current goal. \n\nAt the end of the first day you’ve managed to attack the guard. She isn’t fierce, and she still hesitates a lot, but at least she managed to restrain him. \n\nThe next day she manages to punch him and kick him, but her oozing body isn’t great for that, so you focus on training her defensive skills.\n\nEvery time she succeeds she gets a delicious treat, and it isn’t long until she starts to understand the correlation.\n\nFor the next phase you bring Alba to your living room, and command her to yell and insult you. She does that without hesitation, actually enjoying herself a little bit too much, not like you’re surprised by that.\n\nAt first Lucina just runs scared, but overtime she learns to stay at your side, at first just behind you, then in front of you, and finally she threatens Alba with primitive sounds.\n\nHappy with the result for the day, you dismiss Alba.\n\nThe rest of the week is just improving her skills and initiative, and by the end she is becoming a fierce beast, a real threat even to veteran fighters. \n\nBut she has changed; overly protective, it’s hard to get approached by anyone she doesn’t already knows, and more often than not is the kind that attack first, although those attacks aren't lethal at least.\n\nYou give her more freedom to wander around, but she usually prefers to stick to your side. The new problem too is that if she wants to kiss you, or have sex with you, she’s really pushy, and you really end up giving up, letting her do whatever she wants with you. \n\nYou also don’t feel like rising the voice or your hand against her too much, and many people wonder if you’re in charge, or she is. Not like you care about that, so long she is at your side. ";
			endTurnFun ();

			return;
		}

		if (selector == 1 && confirmationControl == 105) {
			Board.text = "Considering the lustful nature of Lucina, it is obvious that sexual rewards are going to be the most efficient ones.\n\nThe first task that you give her is sitting. Nothing exciting or interesting. Her partial understanding of your language makes it an easy task. You pat her head in approval and she smiles happy to you, eager to receive more caresses. \nYou decide to skip all the basic tricks and orders, and go for something more advanced. \n\nYou bring a guard and order her to attack him. The man embraces for impact but Lucina just gives him a friendly hug. Her mindset really needs to be adjusted.\n\nEvery time she fails you punish her; you tease her but don’t let her touch herself, deny an orgasm, or give her an aphrodisiac and let her alone. \n\nYou avoid physical punishments like spanking or slapping her; knowing her lustful nature, she may end up enjoying those and turning into a masochist. Not an awful thing in itself, but not your current goal. \n\nAt the end of the first day you’ve managed to attack the guard. She isn’t fierce, and she still hesitates a lot, but at least she managed to restrain him. \n\nThe next day she manages to punch him and kick him, but her oozing body isn’t great for that, so you focus on training her defensive skills.\n\nEvery time she succeeds she gets some appreciation from you: A soft caress on her cheek or breast, masturbating her, or even eating her out or having sex if the task is truly difficult and she had a great performance.\n\nThe moment she correlates sex with good behavior the rest of the training starts to go smoother, not a surprise when dealing with an insatiable beast. \n\nFor the next phase you bring Alba to your living room, and command her to yell and insult you. She does that without hesitation, actually enjoying herself a little bit too much, not like you’re surprised by that.\n\nAt first Lucina just runs scared, but overtime she learns to stay at your side, at first just behind you, then in front of you, and finally she threatens Alba with primitive sounds.\n\nHappy with the result for the day, you dismiss Alba.\n\nThe rest of the week is just improving her skills and initiative, and by the end she is becoming a fierce beast, a real threat even to veteran fighters. \n\nBut she has changed; overly protective, it’s hard to get approached by anyone she doesn’t already knows, and more often than not is the kind that attack first, although those attacks aren't lethal at least.\n\nYou give her more freedom to wander around, but she usually prefers to stick to your side. The new problem too is that if she wants to kiss you, or have sex with you, she’s really pushy, and you really end up giving up, letting her do whatever she wants with you. \n\nYou also don’t feel like rising the voice or your hand against her too much, and many people wonder if you’re in charge, or she is. Not like you care about that, so long she is at your side. \n";
			endTurnFun ();

			return;
		}

		///////////////////////////// Encourage  / scold

		if (selector == 0 && confirmationControl == 106) {
			Board.text = "You decide to encourage her to keep going, not with the servitude of course, but maybe with homeless people, criminals... You’ll figure a good arrangement. \n\nYou praise Lucina for her good job and look at the new creatures. They are indeed beautiful, young and as eager as their creator. \n\nLucina cuddles with them and then pushes them towards you, suggesting you to cuddle with them too.\n\nOne of the girls reaches your crotch with one of her recently acquire tentacles, touching you awkwardly. \n\nYou sigh, they are definitely desperate for some love, and you could give them a basic lesson about how to behave, but you aren’t sure if you want or should have your way with them...";

			option0Name.text = "Teach";
			option1Name.text = "Refuse";
			confirmationControl = 107;
			LawController.EnactLaw (new LawSlimeServants());

			NPCCharList.CharFollower [iLucina].isRecruited = true;
			QuestControl.lucinaQuest = 500;
			QuestsController.RemoveID (6004);
			QuestsController.RemoveID (7000);
			Quest ItzelQuest1 = new Quest ();
			NPCCharList.CharFollower [iLucina].isRecruited = true;

			QuestsController.createQuest (ItzelQuest1, "Faith reborn.", "A new religious figure arrives to the city, bringing with it hope.", 63, 7000);
			return;
		}

		if (selector == 1 && confirmationControl == 106) {
			Board.text = "You decide to scold her and tell her to stop creating more creatures, before they infest the city. \n\nAlthough she is sad, she understand that she did wrong. Her puppy eyes aren’t enough to convince you yet.\n\nYou end up allowing the two creatures to stay with Lucina, wandering around the castle, harmless, and behaving as Lucina wants, making them quite tame.\n\nPlayful, you stay with them for a couple of hours assesing the situation. Once you decide where to accomodate them and how you’re gonna take care of them, you talk with Lucina once again and reinforce that she shouldnt keep doing this.\n\nWhen you are about to leave one of the creatures stars to caress your crotch. \n\nYou sigh, they are definitely desperate for some love, and you could give them a basic lesson about how to behave, but you aren’t sure if you want or should have your way with them...\n";

			option0Name.text = "Teach";
			option1Name.text = "Refuse";
			confirmationControl = 107;


			NPCCharList.CharFollower [iLucina].isRecruited = true;
			QuestControl.lucinaQuest = 500;
			QuestsController.RemoveID (6004);
			QuestsController.RemoveID (7000);
			Quest ItzelQuest1 = new Quest ();
			NPCCharList.CharFollower [iLucina].isRecruited = true;

			QuestsController.createQuest (ItzelQuest1, "Faith reborn.", "A new religious figure arrives to the city, bringing with it hope.", 63, 7000);
			return;
		}

		///////////////////////////// Teach / refuse

		if (selector == 0 && confirmationControl == 107) {
			Board.text = "You decide to take some action and teach these younglings a lesson.\n\nAfter undressing yourself and exposing your body they jump at you with voracious lust but you stop them. If they want to stay, they’ll need to learn to follow orders and keep their instincts in check.\n\nThey make a potty face and they beg you with their eyes, but you just tease them with your naked body.\n\nOnce you can see a small pool of oozing fluids on the floor you take a sit in an old chair, turn them around and sit them in your lap.\n\nYou love how their fluid body feels against your naked skin. It’s cold at first, but your own body heat and your caress make them warm in matter of minutes. \n\nAlthough you would love to just kiss their beautiful faces, like younger versions of Lucina, you shouldn’t hurry too much. You start by caressing their faces, butts and breasts.\n\nEvery time they want to make an advance on you you scold them and keep them away, soon enough they learn to keep your pace. \n\nOnce you can see desperation in their faces is when you reward them with a kiss, and finally your hands start to explore their bodies throughly until you arrive to their nether parts.\n\nTheir shameless and eager nature removes any hint of romance or love of the equation, their legs spread open like common whores just craving for pleasure.\n\nYou start to rub their clit and outer lips, softly, teasing them even more, making them moan.\n\nLucina is looking at the scene flustered, and unable to take it anymore she starts to touch herself with her tentacles. \n\nThey start to touch your body too, their tentacles are short but enough to touch your whole body with ease. \n\nYou let them do as they please now, and you start to go rougher and deeper with them. \n\nThe schliking sounds and their moans echo through the room, you wonder how many of your servants are listening to what’s going on. You don’t care though, the four of you are too immerse in the pleasure to take care of mundane things like the voyeurism of your servitude. \n\nThe masturbatory session doesn’t goes for too long, their bodies, still new to these new sensations, don’t take long until they are at the verge of climax.\n\nYou accelarate the speed of your hand and they can’t hold it anymore, painting blue the floor with her squirting fluids. \n\nAlthough they did their best to please you, is Lucina the one who will have take charge of this in the end. She hungrily jumps forwards and on top of you, throwing the girls to the ground, and starts to suck you off.\n\nAlmost no one can beat the pleasure and natural expertise of Lucina’s mouth, and soon you give up to the pleasure, giving her the precious load that she was looking for.\n\nWith the four of you pleased, at least for the moment, you take the rest of the day getting everything ready.\n\nYou gather Helena and the rest of your servants, explain to them what happened and tell them that, even though this shouldn’t get out of control, they should stay alert, at least for the next weeks, and inform you about any irregularity.\n\nThankfully, Lucina stops stalking everyone, there haven’t been more incidents and the new additions to her have been behaving. \n\nWith everything settled, you look forward to the next step in your quest for power.";
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 107) {
			Board.text = "You aren’t in the mood to deal with such creatures. You order Lucina to behave and take care of them.\n\nAfter that, you gather Helena and the rest of your servants, explain to them what happened and tell them that, even though this shouldn’t get out of control, they should stay alert, at least for the next weeks, and inform you about any irregularity.\n\nThankfully, Lucina stops stalking everyone, there haven’t been more incidents and the new additions to her have been behaving. \n\nWith everything settled, you look forward to the next step in your quest for power.";


			endTurnFun ();
			return;
		}

		///////////////////////////// temp

		if (selector == 0 && confirmationControl == 9999) {
			Board.text = "";
			return;
		}

		if (selector == 1 && confirmationControl == 9999) {
			Board.text = "";
			return;
		}
	}




	void Start () {
		loadLucina ();
		loadHelenaData ();
		questStart ();

	}



	void loadHelenaData(){
		iHelena = 0;
		while (iHelena < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iHelena].charID >= 3000 && NPCCharList.CharFollower [iHelena].charID < 4000){
				break; 
			}
			iHelena++;
		}
	}


	void loadLucina(){
		iLucina = 0;

		while (iLucina < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iLucina].charID == 6000){
				WorldControl.NPCID = NPCCharList.CharFollower [iLucina].charID;
				WorldControl.PortraitIDLayer0 = NPCCharList.CharFollower [iLucina].charPortraitLayer0;
				WorldControl.PortraitIDLayer1 = NPCCharList.CharFollower [iLucina].charPortraitLayer1;
				WorldControl.PortraitIDLayer2 = NPCCharList.CharFollower [iLucina].charPortraitLayer2;
				break; 
			}
			iLucina++;

		}

	}

	void loadAbbadon(){
		iAbbadon = 0;

		while (iAbbadon < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iAbbadon].charID == 1000){
				break; 
			}
			iAbbadon++;

		}

	}

	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		panConfirmation.sortingOrder = -500;
		endTurnPanel.sortingOrder = 500;


	}

}
