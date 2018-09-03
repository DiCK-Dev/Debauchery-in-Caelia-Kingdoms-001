using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class AbbadonQuest : MonoBehaviour {

	static int iAbbadon = 0; // used to load abbadon 

	NPCCreator npcCreator = new NPCCreator();

	public Text Board; 
	//public Canvas mainPanel;
	public Canvas panEndTurn;

	static int confirmationControl; 
	public Canvas panConfirmation;

	public Text option0Name; 
	public Text option1Name;
	public Text option2Name;

	public Button option0Butt; 
	public Button option1Butt; 
	public Button option2Butt; 

	string pronhimher; 
	string pronhisher;
	string pronheshe; 

	public void abbadonStart(){
		switch (QuestControl.abbadonQuest) {
		case 5: // traditions
			
			Board.text = "Since you’ve met Abbadon you had the feeling that there is something that makes " + pronhimher + " unhappy, an issue that " + pronheshe + " has barely shared with you about " + pronhisher + " past and " + pronhisher + " current situation.\n\nWhat you know is that one of the tradition of the household is to address its head as a male, independently of the wishes of that particular person. \n\nYears ago Abbadon had to take the leadership of " + pronhisher + " House when " + pronhisher + " parents were killed by the plague. Since then, " + pronheshe + " has been struggling with " + pronhimher + "self.\n\nLately, with the city slowly changing, you realize that " + pronheshe + " has had more time to think about this, the seed of doubt growing fast in " + pronhimher + ". \n\nSince you became the new monarch, things have been changing a lot, giving Abbadon the hope that maybe " + pronheshe + " can change things too.\n\n";
			if (NPCCharList.CharFollower [iAbbadon].charRelationship < 40) {
				Board.text += "You’ve been wondering too if you should help \" + pronhimher + \" a little bit and push \" + pronhimher + \" in the right direction. You would need to strengthen your relationship with \" + pronhimher + \" if you want to convince \" + pronhimher + \" to follow along. \n\nOf course you could decide to be more forceful and push \" + pronhimher + \" to change according to what you want, but at the end of the day don’t expect Abbadon to be happy about it.";
			}else{
				Board.text += "You’ve been wondering too if you should help \" + pronhimher + \" a little bit and push \" + pronhimher + \" in the right direction. You could use your strong relationship with \" + pronhimher + \" to convince \" + pronhimher + \" to change, but you could also be more forceful and push \" + pronhimher + \", but at the end of the day don’t expect Abbadon to be happy if you take this route.";
			}

			option0Name.text = "Use friendship";
			option1Name.text = "Be forceful";
			panConfirmation.sortingOrder = 500; 
			confirmationControl = 0; 
			break;
		case 6: // the chains of tradition
			WorldControl.day += 3;
			Board.text = "After several days you return with Abbadon. You find "+ pronhimher +" in "+ pronhisher +" studio, trying to work, although "+ pronheshe +" is clearly distracted and unable to focus. You knock the door to make your presence known. \n\n<i>“Ah "+ GameControl.playerName +", you are back. Please take a seat.”</i> you can see "+ pronheshe +" is a little nervous, although not as much as the last time you visited "+ pronhimher +". \n\n<i>“Well, I’ve been thinking about this but I’m still troubled, I think I need your help on this.”</i> "+ pronheshe +" goes in length about the pros and the cons of this choice, knowing that leaving things as they are would keep "+ pronhisher +" family legacy intact, but since "+ pronheshe +" is the last living member of "+ pronhisher +" dynasty no one would really care if "+ pronheshe +" changed the rules right now. This would mean it’s the perfect time to make those changes. \n\nStill, "+ pronheshe +" is insecure about this, and "+ pronheshe +" asks for your opinion: Should "+ pronheshe +" push forward and change the rules and use "+ pronhisher +" former gender before the madness began? Or it is more important to keep the traditions intact? What should you suggest to "+ pronhimher +"?";
			option0Name.text = "Change the rules";
			option1Name.text = "Keep the traditions";
			panConfirmation.sortingOrder = 500; 
			confirmationControl = 1; 
			break;
		case 7: // a new temple
			
			WorldControl.day += 2;
			if (NPCCharList.CharFollower [iAbbadon].charGender == NPCData.CharGender.MALE) {
				Board.text = "You visit Abbadon again; "+ pronhisher +" mood has improved a little bit, although you can see "+ pronheshe +" is still troubled. When "+ pronheshe +" notices your presence, they run towards you.\n\n<i>“Oh "+ GameControl.playerName +" you came back just in the right moment! I’ve been thinking on this for the last couple of days.”</i> "+ pronheshe +" shows you a small bottle with the drawing of an almost adorably cartoon-y cock on it. <i>“I...”</i> "+ pronheshe +" is about to talk, but "+ pronhisher +" face turns red when "+ pronheshe +" realizes about what "+ pronheshe +" is about to ask. \n\n<i>“Well, you know, I was thinking that maybe I should change my whole body, fully turn into a man. What do you think about that "+ GameControl.playerName +"?”</i>\n\nIndeed that’s a possibility, although you are not sure if "+ pronheshe +" needs to go so far. <i>“Well, these days changing your body is a pretty easy thing right? Well, you have the money to pay for it. So you or I are not happy with it, you can always change later. Don’t you think?”</i>\n\nHe is right, changing right now or later shouldn’t be a big deal, but considering "+ pronheshe +" already has this potion at hand, should they drink it?";
			} else {
				Board.text = "You visit Abbadon again; "+ pronhisher +" mood has improved a little bit, although you can see "+ pronheshe +" is still troubled. When "+ pronheshe +" notices your presence, they run towards you.\n\n<i>“Oh "+ GameControl.playerName +" you came back just in the right moment! I’ve been thinking on this for the last couple of days.”</i> "+ pronheshe +" shows you a small bottle with the drawing of an almost adorably cartoon-y cock on it. <i>“I...”</i> "+ pronheshe +" is about to talk, but "+ pronhisher +" face turns red when "+ pronheshe +" realizes about what "+ pronheshe +" is about to ask. \n\n<i>“Well, you know, I was thinking that maybe I should change my whole body, fully turn into a man. What do you think about that "+ GameControl.playerName +"?”</i>\n\nIndeed that’s a possibility, although you are not sure if "+ pronheshe +" needs to go so far. <i>“Well, these days changing your body is a pretty easy thing right? Well, you have the money to pay for it. So you or I are not happy with it, you can always change later. Don’t you think?”</i>\n\nShe is right, changing right now or later shouldn’t be a big deal, but considering "+ pronheshe +" already has this potion at hand, should they drink it?\n";
			}

			option0Name.text = "Drink it";
			option1Name.text = "Don't drink it";
			panConfirmation.sortingOrder = 500; 
			confirmationControl = 2; 
			break;
		case 8: // wrecking the house
			WorldControl.day += 3;

			Board.text = "You give "+ pronhimher +" few days to get "+ pronhisher +" head in order before you come back to "+ pronhisher +" manor. You find "+ pronhimher +" in "+ pronhisher +" studio, still as undecided as the last time. You knock the door and ask how "+ pronheshe +" is doing.\n\n <i>“Not very well, but I guess my time is up.”</i> "+ pronheshe +" says. The tone of "+ pronhisher +" voice is a seething growl. <i>“Look, there are too many things to think about. There are as many points in favor as there are against it, that I just can’t decide.”</i> "+ pronheshe +" sighs, frustrated. \n\n<i>“I think a change would be fine, but what do you think "+ GameControl.playerName +"? What’s your opinion on the matter?”</i>\n\nShould you support "+ pronhimher +" to change, or you think "+ pronheshe +" should stay the same? ";
			option0Name.text = "Change";
			option1Name.text = "Stay the same";
			panConfirmation.sortingOrder = 500; 
			confirmationControl = 3; 
			break;
		case 9: // changing times
			WorldControl.day += 2;
			if (NPCCharList.CharFollower [iAbbadon].charGender == NPCData.CharGender.MALE) {
				Board.text = "A day ago you talked with Abbadon about "+ pronhisher +" body and how "+ pronheshe +" felt about it. <i>“I feel fine "+ GameControl.playerName +", nothing to complain.”</i> you ask again and push "+ pronhimher +" a little bit, to bring out the truth. <i>“Well... Thanks to alchemy I guess changing your body and having new experiences is easy, so long you can afford it. But I’m not sure what’s your point.”</i>\n\nYour point is that "+ pronheshe +" should think about it before you come back tomorrow. <i>“Right... So that’s what you wanted. I’ll do just that, not like I can say much about it, leave now.”</i> \n\nYou left "+ pronhisher +" manor and came back next the day. Once there, you visited "+ pronhimher +" at "+ pronhisher +" studio where "+ pronheshe +" is fooling around with a small bottle. <i>“"+ GameControl.playerName +"? Always sneaking around. Look, I thought about it and this is what I had in mind.”</i> "+ pronheshe +" shows you a potion with the drawing of an almost adorably cartoon-y dick. \n\n<i>“I think this would be the best thing to do if I’m gonna stay like this, to complete my transformation... or did you have something else in mind? I can always try something else later.”</i>\n\nShould you tell "+ pronhimher +" to drink this potion? Or to stay the same? For now. ";
			} else {
				Board.text= "A day ago you talked with Abbadon about "+ pronhisher +" body and how "+ pronheshe +" felt about it. <i>“What do you mean by that? I’m now a regular woman, this is not what you wanted?”</i> \n\nAbbadon is still angry at you, but after calming "+ pronhimher +" down you just tell "+ pronhimher +" that there is nothing wrong in experimenting. Alchemy gives everyone (who can afford it) the chance to change their body and try new things, why not have some fun now that "+ pronheshe +" is trying new things? \n\n<i>“I’ll think about it, now leave, I have things to do.”</i>\n\nYou left "+ pronhisher +" manor and came back next the day. Once there, you visit "+ pronhimher +" at "+ pronhisher +" studio where "+ pronheshe +" is fooling around with a small bottle. <i>“"+ GameControl.playerName +"? Always sneaking around. Look, I thought about it and this is what I had in mind.”</i> "+ pronheshe +" shows you a potion with the drawing of an almost adorably cartoon-y dick. \n\n<i>“Well, during years I wondered what would be like having one of these, now it sounds silly for me to try this now that I changed the rules of my House, but I can turn back to normal if I want in the future, so no harm done for trying it out. Or did you have something else in mind? I can always try something else in the future.”</i>\n\nShould you tell "+ pronhimher +" to drink this potion? Or to stay the same? For now. ";
			}


			option0Name.text = "Drink it";
			option1Name.text = "Don't drink it";
			panConfirmation.sortingOrder = 500; 
			confirmationControl = 4; 
			break;

		case 10:
			//nothing
			break;

		case 11: // new horizons
			WorldControl.day += 12;

			GameControl.utilitySkillAlchemy += 10;


			Board.text = "For a while you’ve been thinking about what you can do with alchemy. Knowing how to corrupt and change someone’s soul is definitely the first step, and whatever use you have for such knowledge is beyond the point.\n\nNow that you understand such basics of altering a soul, the logical next step would be to change the body. \n\nYou go to your uncle’s library and start to investigate the subject. It takes you a week of eye-aching research but the investment pays off with plenty of recipes and new knowledge. \n\nAs you find out transforming someone’s body is also related to the mind and soul of the person. \n\nSome people, specially those who don’t have any strong defined personality, are easier to transform and shape into different monsters and beasts, but some people can only be transformed to a particular animal. \n\nThere are many theories about why this happens here, but nothing conclusive. The reason for its being inconclusive isn’t clear, but there are a number of complaints in the margins about funding beginning to dry up. That would make for a pretty obvious explanation as to why these theories are only half-explored.\n\nNonetheless, some people have certain affinities. Knowing these affinities will make it easier to transform them and change them.\n\nYou do your first very basic experiments with prisoners, changing the size of their bodies or turning them into beasts. The results were mixed, but at the end you have come up with something viable. At the cost of many men and women, you have figured out how to bring out the inner beasthood of a person without shattering their minds (as would usually occur in the wild).\n\nAlthough for the most part your knowledge is still very basic, and what’s available in your laboratory is still very limited, you feel confident enough to change the people you know well enough to keep their sanity from splintering.";
			QuestControl.abbadonQuest = 12;
			Quest AbbadonQuest12 = new Quest ();
			QuestsController.RemoveID (1011);
			QuestsController.createQuest (AbbadonQuest12, "Patterns", "You need to learn more about Abbadon patterns to find out what’s its affinity, so you can create a stable potion.", 61, 1012);
			endTurnFun ();
			break;
		case 12: // Patterns

			if (NPCCharList.CharFollower [iAbbadon].charRelationship < 30) {
				option1Butt.interactable = false; 
			}

			option0Name.text = "Trick " + pronhimher;
			option1Name.text = "Convince " + pronhimher;
			panConfirmation.sortingOrder = 500; 
			confirmationControl = 5; 
			Board.text = "You’ve known Abbadon almost since your first arrival, and although you’ve learned a lot <i>about</i> "+ pronhimher +", you need to be sure of everything face-to-face before you proceed.\n\nFor the next few days you spend your time with "+ pronhimher +", starting conversations that allow you to better observe "+ pronhisher +" behaviour and tastes.\n\nAt first you can’t find anything unusual, but you realize in time that Abbadon’s stories reference a common animal; Horses.\n\nIn hindsight this is obvious, but you never paid too much attention to these elements: From riding with "+ pronhisher +" father to "+ pronhisher +" unfortunate first experience with a beast… Not to mention the decorations in "+ pronhisher +" home and "+ pronhisher +" favorite sport.\n\nThere is something in "+ pronhisher +" baring that would remind you of a horse, now that you think about it. Some proud and elegant beast…\n\nWith this knowledge you return to your laboratory and prepare a potion. It turns out to take you longer than expected to perfectly tune it to represent a beautiful horse, but finally it is ready.\n\nNow the question is: Should you convince "+ pronhimher +" to drink the potion, or should you trick "+ pronhimher +" into consuming it?\n\nNOTE: You need your relationship with Abbadon to be 30 or more to convince "+ pronhimher +". \n";

			break;
		case 13: // convincing abbadon
			WorldControl.day += 2;
			Board.text = "Now you intend to use your current relationship with "+ pronhimher +" (and "+ pronhisher +" new open mindedness) to your advantage. \n\nDuring one of your meetings with "+ pronhimher +", you ask if "+ pronheshe +" has a moment for a more personal topic.";
			string boygirl = "girl";
			if (NPCCharList.CharFollower [iAbbadon].charGender == NPCData.CharGender.MALE) {
				boygirl = "boy";
			}
			if (NPCCharList.CharFollower [iAbbadon].charLove >= 40) {
				if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 0) {
					Board.text += "\n\n<i>“Personal huh?... What do you have in mind, "+ GameControl.playerName +"?”</i> Abbadon starts to caress your leg, growing excited from the potential of some shared passions. You can already see how "+ pronhisher +" cock begins to bulge, ready for action.";
				} else {
					Board.text += "\n\n<i>“Personal huh?... What do you have in mind, "+ GameControl.playerName +"?”</i> Abbadon starts to caress your leg, growing excited from the potential of some shared passions.";
				}
			} else {
				Board.text += "\n\n<i>“Personal? I hope this isn’t going to be something awkward, "+ GameControl.playerName +".”</i> ";

			}
			Board.text += "\n\nYou shake your head and calm "+ pronhimher +" down, saying that you just want to talk about a personal project. \n\n<i>“Oh is that so? Very well, I’m listening.”</i> you explain to "+ pronhimher +" about your recent research and the progress you have made. You ensure to stress any parts in regards to how your previous experiments have perfected the safety of the process.\n\nAbbadon gives you an skeptical look <i>“I don’t know "+ GameControl.playerName +"... It sounds like an awful idea. Why would you even want more beasts in the city anyway? You don’t like humans?”</i> \n\nYou explain to "+ pronhimher +" that "+ pronheshe +" can think of this procedure as preventive: If they transform into beasts in a controlled manner that is no risk of insanity, or rampaging such as would happen in the wild. Day by day more people are changing. It’s not a question of <i>if</i> but <i>when</i>.\n\nAlthough Abbadon doesn’t appear convinced, "+ pronhisher +" trust in you is important <i>“Well... I guess you have a point... But there isn’t a way to stay human and <i>not</i> transform?”</i> You inform "+ pronhimher +" that to your knowledge? No… of course, you don’t mention that even if you <i>did</i> know of a way, it would certainly be omitted.\n\n<i>“Let’s say I agree with you, then what? I don’t want to transform into a dirty rat you know? Alba would never let </i>that<i> go!”</i> You reassure "+ pronhimher +". "+ pronheshe +" has nothing to worry about, with your skills you can craft a potion that would turn "+ pronhimher +" into something that properly resembles them; a horse beast.\n\nAbbadon’s expression changes totally when "+ pronheshe +" hears the news, even a little excited at the prospect now. \n\nIt’s funny how "+ pronheshe +" tries to regain "+ pronhisher +" composure and behave normally afterward <i>“I... see... Well, a horse is indeed a fine animal, better than a rat, no doubt.”</i> "+ pronheshe +" takes a sip of tea before continuing <i>“So... Are you sure this will be the result?”</i>\n\nYou smile and talk about the success of your last experiments. <i>“Well... I don’t know, I’m not convinced... At all... But you are my liege and you have earned my support, so if you insist, I will agree to the experiment.”</i> you thank Abbadon for "+ pronhisher +" support, satisfied with the agreement. <i>“But if you screw up, you’ll have to compensate me, and this won’t be anything cheap! So you better make sure that you transform me int-... that you succeed!”</i>\n\nAlthough you don’t like the idea of compensation, you agree to "+ pronhisher +" terms, confident that everything will turn out all right, and tell "+ pronhimher +" that you will shortly come back with the concoction ready. \n\n<i>“Very well, I’m exc-... I’ll be ready when you are.”</i>\n\nThe two of you go back to finish your business meeting before you return to your laboratory to get everything ready for the procedure. It’s amazing just how immediately "+ pronheshe +" flip-flopped on the issue at the mere mention of becoming some kind of sexy bestial Horse"+ boygirl +".";

			QuestControl.abbadonQuest = 14;
			Quest AbbadonQuest14 = new Quest ();
			QuestsController.RemoveID (1013);
			QuestsController.createQuest (AbbadonQuest14, "Procedure", "Abbadon has agreed to drink your potion, now you just need to get everything ready!", 61, 1014);
			endTurnFun ();
			break;
		case 14: // procedure
			WorldControl.day += 3;
			Board.text = "After a couple of days developing Abbadon’s concoction, you already have something ready to use on "+ pronhimher +", and go to "+ pronhisher +" house as soon as possible to test it out.\t\n\nOnce you arrive a hurried Abbadon welcomes you at the door. \n\n<i>“S-So "+ GameControl.playerName +"... Did you come with the potion? Or is there some other reason?”</i> you shake your head and tell "+ pronhimher +" that sadly, you will not be able to proceed with the experiment. Abbadon’s disappointment and sadness is palpable, and you let the moment drag it before smiling. You tell "+ pronhimher +" that you were just joking, that everything is ready. \n\n<i>“You!... Eh... I mean, good! I spent these last days getting everything ready, documents and legal things just in case, so I was... angry that you wasted my time. It was that.”</i> \n\nAbbadon’s spirit are raised up again and "+ pronheshe +" welcomes you inside the house and into "+ pronhisher +" chamber. Once there, you hand "+ pronhimher +" the potion. \n\nTrembling, so close to its goal but also full of doubt, Abbadon start to ask you questions <i>“I drink this and that’s all? I will change right? But... Is it painful? Will it take a lot of time?”</i> You reassure "+ pronhimher +" that it’s not painful and the process is very fast. You wave Abbadon on and encourage "+ pronhimher +" to just gulp it down in a single go and rest in the bed.\n\n<i>“Very well, but if you are lying you’ll face consequences!”</i> Abbadon hisses. "+ pronheshe +" takes one last, deep breath, and gulps down the potion before sitting on "+ pronhisher +" bed. \n\n<i>“It feels... Ahrg!”</i> Abbadon collapses on the bed and begins to convulse as "+ pronhisher +" body is wracked with transformation.\n\nAbbadon starts to tear away at "+ pronhisher +" clothes. For a moment you’re afraid the process is painful, but Abbadon isn’t screaming or yelling. In fact you can hear "+ pronhimher +" moaning from time to time during the couple of minutes that this change takes. \n\nWhen the process is finalized Abbadon lies on the bed, exhausted. "+ pronheshe +" is doubtlessly changed. Despite the sweat and nudity, "+ pronheshe +" seems as elegant as ever.\n\nAfter resting for a short period "+ pronheshe +" sits again <i>“Did... Did it work?”</i> you bring "+ pronhimher +" a mirror to see "+ pronhimher +"self <i>“Wow! This is... "+ GameControl.playerName +"! It’s great, thank you!”</i> "+ pronheshe +" takes you and throws you unto the bed before collapsing onto you with a series of kisses.";

			if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 0) {
				Board.text += "\n\n<i>“I... I think the potion also had a side effect.”</i> you can feel "+ pronhisher +" throbbing cock against your body. \n\n<i>“Come on "+ GameControl.playerName +", I need to do something with this, assist me!”</i>\n\nShould you assist Abbadon with "+ pronhisher +" needs?";
			} else {
				Board.text += "\n\n<i>I... I think the potion also had a side effect.“”</i> Abbadon takes your hand and slides your hand down to "+ pronhisher +" pussy, already drenched in fluids. \n\n<i>“Come on "+ GameControl.playerName +", I need to do something with this, assist me!”</i>\n\nShould you assist Abbadon with "+ pronhisher +" needs? ";
			}

			option0Name.text = "Assist " + pronhimher;
			option1Name.text = "Refuse " + pronhimher;
			panConfirmation.sortingOrder = 500; 
			confirmationControl = 6; 
			NPCCharList.CharFollower [iAbbadon].isFurry = true;
			NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1500;
			AbbadonTransformation.abbadonUpdatePortrait ();
			loadAbbadon ();
			break; 
		case 15:
			WorldControl.day += 4;

			Board.text = "You don’t believe you will be able to convince "+ pronhimher +" to agree to your experiments, so you need to find another way to do so.\n\nFor a couple of days you think about your options and many different cunning (and not so cunning) plans. At the end, the easiest way to trick Abbadon into consuming the potion would be with edibles like the sweets and chocolates "+ pronheshe +" loves so much.\n\nYou could mix the potion with liquor and fill chocolates with the result, but you don’t know if this process will have an undesirable side effect. After many hours thinking about it you reach to the conclusion that, if anything, this can’t be <i>that</i> dangerous, and proceed with the new plan.\n\nWhen everything is ready you send the gifts to Abbadon with one of your couriers, asking him to pressure Abbadon into at least trying one chocolate before coming back to the castle. When your servant returns, he reports you that Abbadon was pleased and immediately took one, even before he said anything, and Abbadon sent "+ pronhisher +" thanks for such delicious gift.\n\nAlthough you are certain that Abbadon will finish the box the same day, you need to wait for the next day to see if there is any result, since the potion would likely take longer to affect "+ pronhimher +" with this method.\n\nThe waiting is killing you, and you barely have any sleep during that night, but finally it is time to pay a visit to Abbadon. When you arrive one of "+ pronhisher +" servants tells you that "+ pronheshe +" is indisposed, but you force your way in, rushing to "+ pronhisher +" chamber.\n\nSadly, you are disappointed because Abbadon hasn’t changed, but is clearly sick for the chocolates. \n\n<i>“"+ GameControl.playerName +"... I’m... I’m going to die... Please bury me with all of my fortunes...”</i> you walk towards "+ pronhimher +" and touch "+ pronhisher +" forehead with your hand. No doubt Abbadon feels this bad, is almost as if "+ pronheshe +" had a fire inside "+ pronhimher +".\n\nInspecting "+ pronhisher +" body you can see that "+ pronheshe +" is changing a little bit, but at this rate "+ pronheshe +" will die before the potion finish its process, and what he needs is just a full dose of the original potion to finally transform and stop "+ pronhisher +" current illness.\n\nYou try to calm "+ pronhimher +" down and explain to "+ pronhimher +" that you can go for a remedy, but the problem is that this remedy may have side effects, like transforming "+ pronhisher +" body. \n\n<i>“I don’t care "+ GameControl.playerName +"! Just bring it now!”</i> "+ pronheshe +" yells at you with effort, and you rush to your castle for the potion.\n\nThankfully, Abbadon is still alive when you return, and "+ pronhisher +" health returns almost to normal the instant you administer the concoction.\n\nIt takes some minutes until "+ pronheshe +" starts to transform, and just a couple of minutes more before that process is complete and "+ pronheshe +" turns into the horse beast that you wanted to see. Your experiment seems to have been a success (near-death experiences aside).\n\n<i>“Ahhh... I feel alive again! I... I don’t know what you did to me but you just saved my live "+ GameControl.playerName +", thank you!... Uh...”</i>\n\nAbbadon’s face turns red.";

			if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 0) {
				Board.text += "\n\n<i>“I... I think the medicine also had a side effect.”</i> you can see "+ pronhisher +" throbbing cock, leaking pre. \n\n<i>“"+ GameControl.playerName +"... I need to do something about this, would you… assist me?”</i>\n\nShould you assist Abbadon with "+ pronhisher +" needs?";
			} else {
				Board.text += "\n\n<i>“I... I think the potion also had a side effect.”</i> Abbadon grimaces, adjusting "+ pronhisher +" underwear and revealing a pussy drenched in fluids. \n\n<i>“Come on "+ GameControl.playerName +", I need to do something with this, assist me!”</i>\n\nShould you assist Abbadon with "+ pronhisher +" needs? ";
			}
			option0Name.text = "Assist " + pronhimher;
			option1Name.text = "Refuse " + pronhimher;
			panConfirmation.sortingOrder = 500; 
			confirmationControl = 6; 
			NPCCharList.CharFollower [iAbbadon].isFurry = true;
			NPCCharList.CharFollower [iAbbadon].charPortraitLayer0 = 1500;
			AbbadonTransformation.abbadonUpdatePortrait ();
			loadAbbadon ();
			break;
		default:
			break; 

		}


	}

	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



	public void confirmFun(int selector){
		// corruption confirmations start at 100, pure at 0


		///////////////////////////// friendship / forceful

		if (selector == 0 && confirmationControl == 0) {
			Board.text = "You visit Abbadon in "+ pronhisher +" manor. Although your visit is unexpected, "+ pronheshe +" greets you and invites you to "+ pronhisher +" living room. \n\nDuring the first hour you are just hanging out with "+ pronhimher +", talking about the latests developments within the city. Eventually however you shift to matters more personal, and ask "+ pronhimher +" what worries them. <i>“Oh "+ GameControl.playerName +"... I’m happy for your attention, but you don’t have to worry about me.”</i> "+ pronheshe +" is calm, but there is a hint of nervousness in "+ pronhisher +" voice.\n\nYou grab "+ pronhimher +" by the shoulder and ask if "+ pronheshe +" is sure about that. <i>“I...”</i> "+ pronheshe +" hesitates, taking a moment to think. Thankfully, it would seem that "+ pronheshe +" feels reassured by your friendship. After a stretched out moment, "+ pronheshe +" finally opens up. <i>“Fine, there is no hiding this from you right? I’ve been thinking about many things... You know, related to myself, my House, these traditions... but I still haven't made up my mind. Just give me some time alone and we can talk about this later "+ GameControl.playerName +", is that okay?”</i> You nod, knowing that there is no point in hurrying. \n\n<i>“Very well, I promise you we’ll have a long talk soon then. Heh, you’ll regret having asked me this.”</i> "+ pronheshe +" jokes at the end and laughs before standing up. \n\n<i>“Well, excuse me for now then, have a nice day "+ GameControl.playerName +", see you soon.”</i> "+ pronheshe +" excuses "+ pronhimher +"self and leaves the room. You certainly will have to come back soon to see where this goes. \n\n";
			NPCCharList.CharFollower [iAbbadon].charRelationship += 5;
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 5;

			QuestsController.RemoveID (1010);
			Quest AbbadonQuest11 = new Quest ();
			QuestsController.createQuest (AbbadonQuest11, "Chains of tradition", "You'll have some time to talk with Abbadon about his House and it's traditions.", 61, 1011);
			QuestControl.abbadonQuest = 6;
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 0) {
			Board.text = "You visit Abbadon in "+ pronhisher +" manor. Although your visit is unexpected, "+ pronheshe +" greets you and invites you to "+ pronhisher +" living room. \n\nDuring the first hour you are just hanging out with "+ pronhimher +", talking about the latests developments within the city before you go personal and finally ask what’s bothering "+ pronhimher +". <i>“"+ GameControl.playerName +", I appreciate the attention but this is none of your business... Please, let me alone.”</i> "+ pronheshe +" is calm but firm, clearly pushing you away. \n\nBut you persist, telling "+ pronhimher +" that in "+ pronhisher +" current state "+ pronheshe +" is of no use for you or the city, and if "+ pronheshe +" wants to keep "+ pronhisher +" title "+ pronheshe +" will have to take action. \n\n\n<i>“You... Fine, I’ll take care of it. Leave me alone now, I need time for myself. And this is not negotiable!”</i> "+ pronheshe +" points at the door. You leave, but at least "+ pronheshe +" will do as you wish. You’ll come later to see what "+ pronhisher +" conclusions are and if you are happy with them. \n\n\n";
			NPCCharList.CharFollower [iAbbadon].charRelationship -= 20;
			NPCCharList.CharFollower [iAbbadon].charLoyalty -= 20;

			QuestsController.RemoveID (1010);
			Quest AbbadonQuest11 = new Quest ();
			QuestsController.createQuest (AbbadonQuest11, "Wrecking the house.", "Is time to bring some change to Abbadon household.", 61, 1011);
			QuestControl.abbadonQuest = 8;
			endTurnFun ();
			return;
		}

		///////////////////////////// change rules / keep the tradition

		if (selector == 0 && confirmationControl == 1) {
			Board.text = "You tell "+ pronhimher +" that there is no point on keeping old, outdated traditions that are no needed anymore, and if "+ pronheshe +" thinks they do more harm than good, "+ pronheshe +" should change them, especially now that no one will fight back.\n\n<i>“Yes, you are right "+ GameControl.playerName +", I really appreciate your advice, I think I’ll do that then.”</i> "+ pronheshe +" gets closer to you and gives you a hug. \n\n<i>“Well, I wont change my name, but at least I will ask the people call me as I want, and not as I’ve been forced to do.”</i>\n\nHer mood immediately changes, and you can see how happy she is now. <i>“Well I have too many things to change now, a lot of paperwork, so if you excuse me I’ll start with these tasks immediately, but please come back soon, I would like talk about other matters too.”</i>";

			NPCCharList.CharFollower [iAbbadon].charGender = NPCData.CharGender.FEMALE;
			NPCCharList.CharFollower [iAbbadon].charSex = NPCData.CharSex.Woman;
			NPCCharList.CharFollower [iAbbadon].charRelationship += 10;
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 10;
			QuestsController.RemoveID (1011);
			Quest AbbadonQuest12 = new Quest ();
			QuestsController.createQuest (AbbadonQuest12, "A new temple", "Should Abbadon fully commit to change?", 61, 1012);
			QuestControl.abbadonQuest = 7;

			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 1) {
			Board.text = "You tell "+ pronhimher +" that even if "+ pronheshe +" thinks this is a good moment to change things, what the city and "+ pronhisher +" household needs are stability and order, not change. \n\n<i>“You may be right, I shouldn’t be worrying about such silly things. This whole thing... It shouldn’t be a priority. Thanks for your advice "+ GameControl.playerName +", I think I feel better. But… there are still things I need to think about, would you mind coming back later so that we can have a chat about it?”</i>\n\nYou nod in agreement and tell "+ pronhimher +" that you’ll be back soon to help "+ pronhimher +" as much as you can. <i>“Thanks "+ GameControl.playerName +", I know I can count with you.”</i>\n\nYou leave, and although Abbadon is a little disappointed, "+ pronheshe +" knows this is the right call.\n\n";

			NPCCharList.CharFollower [iAbbadon].charRelationship += 5;
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 5;
			QuestsController.RemoveID (1011);
			Quest AbbadonQuest12 = new Quest ();
			QuestsController.createQuest (AbbadonQuest12, "A new temple", "Should Abbadon fully commit to change?", 61, 1012);
			QuestControl.abbadonQuest = 7;

			endTurnFun ();
			return;
		}

		///////////////////////////// drink it // dont drink it

		if (selector == 0 && confirmationControl == 2) {


			if (NPCCharList.CharFollower [iAbbadon].charGender == NPCData.CharGender.MALE) {
				NPCCharList.CharFollower [iAbbadon].charSex = NPCData.CharSex.Man;
				Board.text = "You tell "+ pronhimher +" to go ahead with it and transform "+ pronhimher +"self in a man. <i>“Yes, you are right, I am only one step away from it, no point in turning back now.”</i> "+ pronheshe +" uncorks the bottle and looks at it for a long minute, just trying to gather enough courage to do it.";
			} else {
				NPCCharList.CharFollower [iAbbadon].charSex = NPCData.CharSex.Futanari;
				Board.text = "You tell "+ pronhimher +" that a change would be a great opportunity to experience new things from another perspective, and if "+ pronheshe +" doesn’t like it "+ pronheshe +" can turn back to "+ pronhisher +" current state in the future. <i>“You’re right, I guess it will be fun.”</i> "+ pronheshe +" uncorks the bottle and looks at it for a long minute, just trying to gather enough courage to do it. ";
			}
			Board.text += "\n\n<i>“Here we go...”</i> "+ pronheshe +" slowly drinks the potion, when "+ pronheshe +" is done "+ pronheshe +" leaves the small bottle on the table and waits. \n\n<i>“The taste is horrible uhgg... And how long it takes to take eff-”</i> before "+ pronheshe +" can finish the phrase, "+ pronheshe +" falls on "+ pronhisher +" knees and starts to yell. <i>“Ahhh! It’s happening! Nghh!”</i> You can see how "+ pronhisher +" whole body trembles, and you catch "+ pronhimher +" just in time before "+ pronheshe +" blacks out, saving Abbadon from falling to the ground.\n\nIt takes a couple of minutes for "+ pronhimher +" to recover. <i>“Uhh... What happened? Is- is it done?”</i> "+ pronheshe +" jumps from your arms and stands up to look inside "+ pronhisher +" skirt. <i>“Ah yes! It worked! I’m changed!”</i> You congratulate "+ pronhimher +" for the change. "+ pronheshe +" bounces on "+ pronhisher +" heels, giving you quite the show of a flopping endowment. Abbadon blinks, turning red and looking mortified. <i>“Ehhh... I’m sorry, I wasn’t thinking, I got too excited.”</i> you laugh and tell "+ pronhimher +" that "+ pronheshe +" has nothing to worry about.\n\n<i>“I appreciate it, thanks again "+ GameControl.playerName +", this has really been an… uh, interesting experience? But I feel really tired now, must be the potion. Will you excuse me for today so I can have some rest? We can talk or share a moment after I’m rested.”</i>\n\nYou follow "+ pronhisher +" request and you tell "+ pronhimher +" you’ll come back soon. <i>“Thank you "+ GameControl.playerName +", see you around then!”</i> "+ pronheshe +" gives you a hug, and you can feel "+ pronhisher +" hardon against your body, even though "+ pronheshe +" doesn't seem to notice it. \n\nYou leave to your castle, happy for helping Abbadon in "+ pronhisher +" personal quest. ";
			NPCCharList.CharFollower [iAbbadon].dickSize = NPCData.DickSize.average;
			NPCCharList.CharFollower [iAbbadon].dickSizeCM = 13; 

			NPCCharList.CharFollower [iAbbadon].charRelationship += 5;
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 5;
			QuestsController.RemoveID (1012);
			QuestControl.abbadonQuest = 10;

			endTurnFun ();

			return;
		}

		if (selector == 1 && confirmationControl == 2) {
			Board.text = "";


			if (NPCCharList.CharFollower [iAbbadon].charGender == NPCData.CharGender.MALE) {
				Board.text = "You tell "+ pronhimher +" that "+ pronheshe +" shouldn’t bother with it for now, one change at the time is enough for the moment. \n\n<i>“Yeah, you’re right, maybe changing too many things right now is a bad idea. I think I was getting a little carried away with it. Still, I can try these kinds of things more in the future. Just let me know if you think it would be fun to do.”</i> "+ pronheshe +" smiles confidently, placing the bottle away.\n\nYou tell "+ pronhimher +" that for now, "+ pronheshe +" should relax and enjoy the day. <i>“I will "+ GameControl.playerName +", thanks for your support and counsel, I appreciate it. And if you need my help, please just ask.”</i> You nod and leave Abbadon’s manor, happy that "+ pronheshe +" is untroubled for now. \n";
			} else {
				Board.text = "You tell "+ pronhimher +" that "+ pronheshe +" shouldn’t do it, "+ pronheshe +" should take some time to think this more in depth. \n\n<i>“Yeah, you’re right, but it’s not like I cannot turn back to normal right? I do suppose I was getting a little carried away with it. Still, I can try these kinds of things more in the future. Just let me know if you think it would be fun to do.”</i>\n\nYou tell "+ pronhimher +" that for now, "+ pronheshe +" should relax and enjoy the day. <i>“I will "+ GameControl.playerName +", thanks for your support and counsel, I appreciate it. And if you need my help, please just ask.”</i> You nod and leave Abbadon’s manor, happy that "+ pronheshe +" is untroubled now. ";
			}



			NPCCharList.CharFollower [iAbbadon].charRelationship += 5;
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 5;
			QuestsController.RemoveID (1012);
			QuestControl.abbadonQuest = 10;
			endTurnFun ();
			return;
		}


		///////////////////////////// Change / stay the same 

		if (selector == 0 && confirmationControl == 3) {
			Board.text = "You agree, this city needs a change, and getting rid of those old traditions is a good start. <i>“Don’t be disrespectful! I like most of those traditions, it’s just this one that’s wrong, that’s all.”</i> although still angry, you can see that supporting "+ pronhisher +" choice has improved "+ pronhisher +" mood. \n\n<i>“Very well, it is settled then. I have a lot of paperwork to do now, so now that I did what you wanted I hope you are happy "+ GameControl.playerName +".”</i> You tell her that indeed you are glad that she finally has decided something, although you tell her that you are not done yet.\n\n<i>“What do you mean? Do you want something else from me?”</i> you nod, but for now you leave, she’ll know what you mean soon enough.\n\n<i>“I don’t like surprises "+ GameControl.playerName +". Now leave, I have work to do.”</i> \n\n\n";
			NPCCharList.CharFollower [iAbbadon].charSex = NPCData.CharSex.Woman;
			NPCCharList.CharFollower [iAbbadon].charGender = NPCData.CharGender.FEMALE;

			NPCCharList.CharFollower [iAbbadon].charRelationship += 5;
			NPCCharList.CharFollower [iAbbadon].charLoyalty += 5;
			QuestsController.RemoveID (1011);
			Quest AbbadonQuest12 = new Quest ();
			QuestsController.createQuest (AbbadonQuest12, "Changing times", "Should Abbadon fully commit to change?", 61, 1012);
			QuestControl.abbadonQuest = 9;

			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 3) {
			Board.text = "You give "+ pronhimher +" a short speech about why traditions should be respected and are the cornerstone of their civilization, and therefore there is no need to change anything.\n\n<i>“Always contradicting me. Very well, if that’s what you want I drop the issue. Now feel free to leave, I have a lot of work to do and I already wasted too much time with this.”</i> on your way out you tell "+ pronhimher +" that there is still something you want to talk about with him.\n\n<i>“What now? I don’t like surprises "+ GameControl.playerName +", I hope is not a stupid request.”</i> you smile but tell him that there is nothing to worry about, he’ll see soon enough.\n\n<i>“I don’t have a good feeling about this... But now leave me alone, I’ll deal with this later.”</i>";

			QuestsController.RemoveID (1011);
			Quest AbbadonQuest12 = new Quest ();
			QuestsController.createQuest (AbbadonQuest12, "Changing times", "Should Abbadon fully commit to change?", 61, 1012);
			QuestControl.abbadonQuest = 9;
			endTurnFun ();
			return;
		}



		///////////////////////////// Drink it / dont drink it 

		if (selector == 0 && confirmationControl == 4) {
			if (NPCCharList.CharFollower [iAbbadon].charGender == NPCData.CharGender.MALE) {
				NPCCharList.CharFollower [iAbbadon].charSex = NPCData.CharSex.Man;
				Board.text = "You tell "+ pronhimher +" to go forward with it and transform "+ pronhimher +"self in a man. <i>“Yes, you are right, I am only one step away from it, no point in turning back now.”</i> "+ pronheshe +" uncorks the bottle and looks at it for a long minute, just trying to gather enough courage to do it.";
			} else {
				NPCCharList.CharFollower [iAbbadon].charSex = NPCData.CharSex.Futanari;
				Board.text = "You tell "+ pronhimher +" that a change would be a great opportunity to experience new things from another perspective, and if "+ pronheshe +" doesn’t like it "+ pronheshe +" can turn back to "+ pronhisher +" current state in the future. <i>“You’re right, perhaps it will be fun.”</i> "+ pronheshe +" uncorks the bottle and looks at it for a long minute, just trying to gather enough courage to do it. \n";
			}
			Board.text += "\n\n<i>“Here we go...”</i> "+ pronheshe +" slowly drinks the potion, when "+ pronheshe +" is done "+ pronheshe +" leaves the small bottle on the table and waits. \n\n<i>“The taste is horrible uhgg... And how long it takes to take eff-”</i> before "+ pronheshe +" can finish the phrase, "+ pronheshe +" falls on "+ pronhisher +" knees and starts to yell. <i>“Ahhh! It’s happening! Nghh!”</i> You can see how "+ pronhisher +" whole body trembles, and you catch "+ pronhimher +" just in time before "+ pronheshe +" blacks out, saving Abbadon from falling to the ground.\n\nIt takes a couple of minutes for "+ pronhimher +" to recover. <i>“Uhh... What happened? Is- is it done?”</i> "+ pronheshe +" jumps from your arms and stands up to look inside "+ pronhisher +" skirt. <i>“Ah yes! It worked! I’m changed!”</i> You congratulate "+ pronhimher +" for the change. "+ pronheshe +" bounces on "+ pronhisher +" heels, giving you quite the show of a flopping endowment. Abbadon blinks, turning red and looking mortified. <i>“Ehhh... I’m sorry, I wasn’t thinking, I got too excited.”</i> you laugh and tell "+ pronhimher +" that "+ pronheshe +" has nothing to worry about.\n\n<i>“I appreciate it, thanks again "+ GameControl.playerName +", this has really been an… uh, interesting experience? But I feel really tired now, must be the potion. Will you excuse me for today so I can have some rest? We can talk or share a moment after I’m rested.”</i>\n\nYou follow "+ pronhisher +" request and you tell "+ pronhimher +" you’ll come back soon. <i>“Thank you "+ GameControl.playerName +", see you around then!”</i> "+ pronheshe +" gives you a hug, and you can feel "+ pronhisher +" hardon against your body, even though "+ pronheshe +" doesn't seem to notice it. \n\nYou leave to your castle, happy for helping Abbadon in "+ pronhisher +" personal quest. ";

			NPCCharList.CharFollower [iAbbadon].dickSize = NPCData.DickSize.average;
			NPCCharList.CharFollower [iAbbadon].dickSizeCM = 13; 

			QuestsController.RemoveID (1012);
			QuestControl.abbadonQuest = 10;

			endTurnFun ();

			return;
		}

		if (selector == 1 && confirmationControl == 4) {
			Board.text = "You tell "+ pronhimher +" that "+ pronheshe +" shouldn’t bother with it for now, one change at the time is enough for the moment. \n\n<i>“Yeah, you’re right, maybe changing too many things right now is a bad idea. I think I was getting a little carried away with it. Still, I can try these kinds of things more in the future. Just let me know if you think it would be fun to do.”</i> "+ pronheshe +" smiles confidently, placing the bottle away.\n\nYou thank "+ pronhimher +" for "+ pronhisher +" time, turn around, and leave Abbadon’s manor, with the knowledge that Abbadon will be untroubled from now on. \n\n";
			QuestsController.RemoveID (1012);
			QuestControl.abbadonQuest = 10;

			endTurnFun ();
			return;
		}

		///////////////////////////// trick him // convince him

		if (selector == 0 && confirmationControl == 5) {
			Board.text = "You believe that the best path of action is to trick Abbadon into consuming the potion. You go back to your castle and start to get everything ready for the task at hand.";
			QuestControl.abbadonQuest = 15;
			Quest AbbadonQuest15 = new Quest ();
			QuestsController.RemoveID (1012);
			QuestsController.createQuest (AbbadonQuest15, "Tricking Abbadon", "You need a cunning plan to get Abbadon to drink the potion without realizing." , 61, 1015);

			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 5) {
			Board.text = "You believe that the best path of action is to convince Abbadon into consuming the potion. You go back to your castle and start to get everything ready for the task at hand.";
			QuestControl.abbadonQuest = 13;
			Quest AbbadonQuest13 = new Quest ();
			QuestsController.RemoveID (1012);
			QuestsController.createQuest (AbbadonQuest13, "Convincing Abbadon", "You are on your way to Abbadon's house, ready to convince " + pronhimher + " of changing "+ pronhisher +" body once more." , 61, 1013);

			endTurnFun ();
			return;

		}

		///////////////////////////// Assist // refuse 

		if (selector == 0 && confirmationControl == 6) {
			Board.text = "You embrace Abbadon and kiss "+ pronhimher +" hungrily. \n\n<i>“I take that’s a yes...”</i> "+ pronheshe +" pulls you closer and assaults you with "+ pronhisher +" tongue, but judging by the way it grinds, "+ pronhisher +" body craves far more than just a deep kiss.";
			string l0 = "ass", l1 = "butt hole", l2 = "asshole", l3 = "prostate", l4 = "cum";
			string la0 = "", la1 = "Abbadon spreads "+ pronhisher +" legs open <i>“Come on "+ GameControl.playerName +", I need to be filled now!”</i>";

			if (NPCCharList.CharFollower [iAbbadon].dickSizeCM < 4) {
				l0 = "pussy"; l1 = "cunt"; l2 = "dripping twat"; l3 = "womb"; l4 = "femcum";
			}

			if (GameControl.dick1Size <= 0) {
				la0 = "inside "+ pronhimher +"";
				la1 = "Abbadon spreads "+ pronhisher +" legs open <i>“Come on "+ GameControl.playerName +", take that strap-on and fill me up!”</i>";
			}

			if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 0) {
				Board.text += "\n\n<i>“Come on, turn around, I have to put this somewhere!”</i> "+ pronheshe +" helps you to turn and bend over, offering your " + l0 + " to "+ pronhimher +".";
				Board.text += "\n\n<i>“That’s what I’m talking about. Sorry but I don’t have time for foreplay today!”</i> Abbadon immediately assaults your " + l1 + " with "+ pronhisher +" tool. "+ pronheshe +" wasn’t lying when they said they didn’t have time. "+ pronheshe +" manically pounds "+ pronhisher +" hips, desperate to find relief in your " + l2 + ".";
				Board.text += "\n\nYou can feel "+ pronhisher +" cock hitting your " + l3 + " over and over, hauling you brutally to the edge of a climax as fast as "+ pronheshe +" is reaching "+ pronhisher +" own. ";
				Board.text += "\n\n<i>“Ngh! Here it goes "+ GameControl.playerName +"! Take it! Take it all!”</i> "+ pronhisher +" hot seed starts to flow inside your body. The weight and warmth of it coupled with "+ pronhisher +" twitching cock helps bring you to climax at the same time, staining the bed with your " + l4 + ".";
				Board.text += "\n\n<i>“Ahh... Sorry if it was just a quicky "+ GameControl.playerName +"... The potion is... Too powerful. I need to take a rest now, but thanks for this... It felt great.”</i>\n\nYou give "+ pronhimher +" a kiss and let "+ pronhimher +" rest before you turn around and go back to your castle... leaving a trail of seed in your wake.\n";

			} else {
				Board.text += "\n\n"+ la1 +"\n\nYou can’t refuse the lascivious offering and after getting yourself ready you jump straight onto "+ pronhimher +". Abbadon craves you; there’s no need for foreplay, just a need for raw, unbridled fucking.\n\nThe two of you use each other as nothing more than a relief object, cavorting in each other’s grasps until your cockhead is pressed flush with "+ pronhisher +" womb.";
				Board.text += "\n\nThe sex is as brief as it’s intense; Abbadon’s face has tears of pleasure when you finally climax "+ la0 +", and you end up lying on top of "+ pronhimher +", exhausted.";
				Board.text += "\n\n<i>“Ahh... T-Thanks "+ GameControl.playerName +", just what I needed, but I think I’m going to take a nap now...”</i> Abbadon falls asleep after the words leave "+ pronhisher +" lips, with a happy smile on "+ pronhisher +" face.\n\nYou kiss "+ pronhimher +" on the forehead and leave "+ pronhisher +" house, back to your lab to clean up the mess you made whilst crafting the potion. Wouldn’t do to leave those dangerous chemicals around.";
			}





			QuestControl.abbadonQuest = 16;
			QuestsController.RemoveID (1014);
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 6) {
			Board.text = "You tell Abbadon that he has nothing to worry about, that the effects will fade rather quickly, you have some urgent business to see to.\n\n<i>“But!...”</i> "+ pronheshe +" sighs, visibly disappointed with you <i>“Very well! You did your thing. Leave me alone then, I need some privacy now”</i>\n\nHappy with your successful experiment, you go back to your castle to clean up the mess in your laboratory. It wouldn’t do to leave dangerous chemicals around.";


			QuestControl.abbadonQuest = 16;
			QuestsController.RemoveID (1014);
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


	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void loadAbbadon(){

		iAbbadon = 0;
		while (iAbbadon < NPCCharList.CharFollower.Count) {
			if (NPCCharList.CharFollower [iAbbadon].charID >= 1000 && NPCCharList.CharFollower [iAbbadon].charID < 2000) {
				WorldControl.NPCID = NPCCharList.CharFollower [iAbbadon].charID;
				WorldControl.PortraitIDLayer0 = NPCCharList.CharFollower [iAbbadon].charPortraitLayer0;
				WorldControl.PortraitIDLayer1 = NPCCharList.CharFollower [iAbbadon].charPortraitLayer1;
				WorldControl.PortraitIDLayer2 = NPCCharList.CharFollower [iAbbadon].charPortraitLayer2;
				WorldControl.furryPic = false;
				WorldControl.futaPic = NPCCharList.CharFollower [iAbbadon].isFuta;
				break; 
			}

			iAbbadon++;
		}

	}


	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		panEndTurn.sortingOrder = 500;
		//mainPanel.sortingOrder = -500;
		panConfirmation.sortingOrder = -500;

	}


	void Awake(){

		loadAbbadon ();





		//load abbadon pronouns
		if (NPCCharList.CharFollower [iAbbadon].charGender == NPCData.CharGender.MALE) {
			pronheshe = "he";
			pronhimher = "him";
			pronhisher = "his";
		} else {
			pronheshe = "she";
			pronhimher = "her";
			pronhisher = "her";
		}





		option0Name.text = ""; 
		option1Name.text = "";
		option2Name.text = "";

		option2Butt.interactable = true; 
		option2Butt.interactable = false; 
		abbadonStart ();




	}


}
