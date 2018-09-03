using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AbbadonDate : MonoBehaviour {
	static int iAbbadon; 
	public Text Board; 
	int randNum;
	public Canvas endTurnPanel; 
	public Canvas panMainPanel;
	static string pronhimher, pronheshe, pronhisher, pronHISHER, pronHESHE, pronHIMHER; 

	public void abbadonDate(){
		
		loadAbbadonData ();
		if (NPCCharList.CharFollower [iAbbadon].charRelationship < 50) {
			Board.text = "You need to improve your relationship with Abbadon before you can date "+pronhimher ;
		}

		Random.InitState (WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 

		if (NPCCharList.CharFollower [iAbbadon].charLove < 50) {
			randNum = Random.Range (0, 100);
			if (randNum > 50) {
				Board.text = date0 ();
			} else {
				Board.text = date1 ();
			}
		} else {
			if (randNum > 50) {
				Board.text = date2 ();
			} else {
				Board.text = date2 ();
			}
		}
		endTurnFun ();
	}


	string date0(){
		NPCCharList.CharFollower [iAbbadon].charLove += 20;
		return "While you’re visiting Abbadon’s house and having a casual but intimate talk with "+pronhimher+", you suddenly decide to ask "+pronhimher+" if "+pronheshe+"  wants to go on a date. "+pronHISHER+" face turns a bright red, and after a long, awkward pause "+pronheshe+"  finally decides to answer. <i>“… I-I don’t know, I don’t like you b-but...”</i> "+pronHESHE+" says, trying to convince himherself more than anyone else. <i>“But you are the Lord, right? So I guess it would be disrespectful to refuse such a grand offer. I guess you leave me with no choice but to accept.”</i> You smile and nod at "+pronhisher+" guarded attitude. Before you can even suggest anything "+pronheshe+"  cuts you off. <i>“But I will decide where! Otherwise, I may grow bored.”</i>\n\nYou struggle with "+pronhimher+" for a while, attempting to propose ideas of where to go, but eventually you give up. <i>“Very well, for this date I think I can arrange something at that arena! That would be fun!”</i> You roll your eyes, since the arena isn’t exactly a great place for a date, but the matter is settled. \n\nThe next day, you arrive early with a bouquet of flowers and an assortment chocolates. You see Abbadon coming, empty handed, and once "+pronheshe+"  is with you "+pronheshe+"  gives you a weird face. <i>“Wait, what is this?”</i> "+pronheshe+"  asks, pointing at your gifts, and you just hand them to himher. "+pronHESHE+" immediately throws the flowers away, to your dismay, but surprisingly keeps the chocolates. Opening the box, "+pronheshe+"  . <i>“Eh, I prefer dark chocolate, but this will do.”</i> "+pronHESHE+" just walks towards the arena without saying anything else.\n\nOnce inside, you realize the place is almost completely empty; it looks like Abbadon decided to make this event even more private. You follow "+pronhimher+" into the VIP balcony, while some slaves go to fetch you two refreshments while you wait for the first combat to start. "+pronHESHE+" is silent, uninterested of the arena’s surroundings as "+pronheshe+"  is eating the sweets you gave "+pronhimher+", so you decide to try and break the ice. You ask "+pronhimher+" who is going to fight. \n\n<i>“Today they have some boring fights that won’t matter, but the main show is apparently one former champion versus a rising star... I’ve heard plenty of wonderful things about this new guy, a very skilled warrior that can match any veteran, and from the ladies... They say "+pronhisher+" best weapon is the club, if you know what I mean.”</i> "+pronHESHE+" snickers and switches "+pronhisher+" focus to the arena, where the games are about to start. \n\nAlthough the first are ferocious and bloody, what amuses you the most is Abbadon’s mood and attitude. Clearly, "+pronheshe+"  enjoys the sport and "+pronheshe+"  doesn’t mind to shriek, cheer, or jump out of "+pronhisher+" chair to root to "+pronhisher+" favorite fighter, blowing off tons of steam, "+pronhisher+" usual petulant face nowhere to be seen.\n \nBefore the final fight starts and the slaves proceed to refresh the arena, you feel "+pronhimher+" taking your arm and resting "+pronhisher+" head in your shoulder. You turn your head and you can see that "+pronheshe+"  is somewhat tired, and you decide to rest your head on hisher, and ask if "+pronheshe+"  is having any fun. <i>“...Yeah, it’s been pretty good. I don't think you are that much into it but... I kinda enjoy your presence.”</i> "+pronHESHE+" says, with an almost sleepy voice.\n\nWhen the trumpets announce the final fight "+pronheshe+"  wakes up again, moving from your side, and salutes the fighters before they start. \n\nThe last fight is vicious, and although the former champion clearly has more experience and tricks, he ends up being disarmed and defeated by the younger star. Abbadon is so happy and pleased with the performance, that "+pronheshe+"  decides to pardon the life of the old veteran, and the very small crowd that was assisting starts to leave after the fight, while Abbadon itself looks pretty tired.\n\nYou ask Abbadon if "+pronheshe+"  enjoyed the date. <i>“Of c-... I mean, it was fine, but it was my idea to come here right? Maybe I’ll let you pick the next date... Maybe.”</i> You tell "+pronhimher+" that you didn’t mention anything about a next date and "+pronheshe+"  grows a shade of red, and tries to excuse himherself .<i>”Urg! I mean, it is obvious that you were going to ask me out again! It would be ridiculous if you didn’t! You just don’t know yet how lucky you are!”</i> \n\nHESHE resists you a little bit but in the end eases up and allows you accompany "+pronHIMHER+" home. Both of you stand at the doorsteps, stuck in an awkward silence. <i>“...Fine, I go first! I... I enjoyed our date, and I... I also hope we can go out soon again, okay?.... But don't get that over yourself yet! I’m still undecided about you!”</i> You smile and give "+pronhimher+" a hug. "+pronHESHE+" is stiff as a rock, and takes a minute to answer your appreciation. Before you leave "+pronhimher+", you say that you enjoyed your time with "+pronhimher+" too, and you also look forward towards the next time. "+pronHESHE+" stays at the doorsteps while you leave, looking at you until you are out of sight, slowly waving "+pronhisher+" hand. ";

	}

	string date1(){
		NPCCharList.CharFollower [iAbbadon].charLove += 20;

		return "You wonder what could be a good place to take Abbadon for your next date. Thinking about all of your interactions you had with "+pronHIMHER+" so far, at least something is clear: PRONHESHE has a weakness for sweets and good food, so you decide to contact the best cooks in the city, asking them to create a delicatessen banquet for the two of you. You are well aware that Abbadon is not fond of your castle, so you decide to decorate the garden with beautiful, stylish designs, bush statues, and new furniture for the gazebo, among other things. \n\nThe day you receive Abbadon at the gates, you give "+pronHIMHER+" your arm that PRONHESHE decidedly holds. <i>“You are more daring than I thought if you decided to pick this awful place for our second date.”</i> PRONHESHE immediately complains while both of you walk toward the garden, but you just ask "+pronHIMHER+" to wait and see, to which PRONHESHE answers just with a apprehensive sigh. \n\nWhen you finally arrive, you first hear a chuckle from Abbadon. <i>“Well… Not bad, not as bad as I expected at least.”</i> But although PRONHESHE jokes, PRONHISHER increased heartbeat and PRONHISHER tightened hold on your arm gives away PRONHISHER true feelings. \n\nYou both are seated at the gazebo, and immediately servants bring drinks for each of you. You decide to start the conversation asking about how PRONHESHE been doing and feeling lately. <i>“Things have been going well in my district at all, but to be honest… Nevermind.”</i> PRONHESHE puts PRONHISHER elbow in the table, rests PRONHISHER head in PRONHISHER hand, looking away listlessly while taking sips from a straw. You decide to poke "+pronHIMHER+" this time, telling "+pronHIMHER+" that if PRONHESHE has missed you. <i>“No! Of course not!... I mean, it’s just a boring city and that’s all, it's hard to find someone who isn't a complete, total idiot, so I have to settle with half an idiot like you.”</i> You smile, realizing that you can finally navigate between PRONHISHER lines. \n\nA waitress comes to inform that the food is ready, and you order them to proceed, as servants and chefs arrive to surround your table with a banquet of delights; From turkey, an entire piglet, exotic salads, breaded shrimp, and beautiful trays full of a variety of canape, the amount and quality surprises and makes Abbadon drool a little bit. <i>“Wow… Well, you may lack finesse when it comes down to decoration, but at least you can manage to prepare a proper banquet.”</i> Abbadon acknowledges with a short nod in your direction.\n\nWith PRONHISHER mood improved, you both engage in a more pleasant and casual chat. When the food is over and the dessert, ice cream with chocolate and fruits, is served, Abbadon starts to thank you for your invitation. <i>“At first I was reluctant to come...  It’s… It’s nothing personal, but after losing so many friends and family to that damned Plague, I think I was not prepared or eager to engage in any other significant human interaction.”</i> You silently nod, understanding how difficult it may have been for "+pronHIMHER+", and you tell "+pronHIMHER+" that you take no offense for it and that you understand. <i>“Ah… Thanks, but just to be clear… What I want to say is that I’d like to be with you.”</i> PRONHESHE closes PRONHISHER eyes and gives you a gentle smile as both stay silent until the date is finally over. \n\nYou take PRONHISHER hand and accompany "+pronHIMHER+" to PRONHISHER house, where you have to face again the awkward silence. Abbadon waits this time, looking deeply at you, and you decide to take PRONHISHER cheek and move forward, giving "+pronHIMHER+" a small kiss on PRONHISHER lips. Abbadon turns around ashamed, and opens PRONHISHER door, almost trying to escape the situation <i>“W-well, I’ll see you soon right?...”</i> You nod and start to leave, PRONHESHE waves PRONHISHER hand to you and you answer back, blowing "+pronHIMHER+" a kiss too.";

	}


	string date2(){
		string toReturn;

		toReturn = "During the last days you have been trying to find out what Abbadon dreams about, or at least a dear memory from the past that you would like "+pronhimher+" to relive. Although you don't have that much luck with "+pronhimher+", "+pronhisher+" servant gives you a hint: "+pronHESHE+" loved to go riding horses with "+pronhisher+" father, something "+pronheshe+"  hasn’t done since the Plague.\n\nThankfully, you already have some good studs already tamed, and decide to surprise Abbadon with a surprise date. That day you go to "+pronhisher+" house, and asks "+pronhimher+" to wear a blindfold. Once you make sure "+pronheshe+"  can't see, "+pronheshe+"  asks the obvious question. <i>Hey, but how I'm supposed to fol..ah!.”</i> But before "+pronheshe+"  can finish you scoop him her up and carry "+pronhimher+" with your arms. \n\nYou walk to the edge of the city, where there are miles of grassy fields before they meet up with the forest. When you reach your destination, you gently drop "+pronhimher+" to the ground and tell "+pronhimher+" to remove "+pronhisher+" blindfold. <i>“I hope this is...”</i> When "+pronheshe+"  finally sees the horses, Abaddon is speechless. "+pronHESHE+" slowly turns "+pronhisher+" head to you, eyes teary, and without any warning "+pronheshe+"  jumps into your arms, to give you a small, lovely kiss. <i>“I... Don't know what to say, how did... Ah, it doesn’t matter, come on!”</i>  "+pronHESHE+" laughs of happiness and runs toward the horse, giving small jumps of joy, being this the biggest display of hisher’s affection and true self that "+pronheshe+"  has ever given to you. \n \nYou help Abbadon get on the horse, since "+pronheshe+"  isn’t tall enough to get on it himherself, and you sit just behind himher. "+pronHESHE+" takes the saddles and you hold "+pronhisher+" hands, just to make sure "+pronheshe+"  doesn't let them go while you ride. "+pronHESHE+" leans backwards, resting on you while the horse trots around.";
		if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 0) {
			if (GameControl.dick1Size> 0) {
				toReturn += "\n\nThe rough movement makes Abbadon’s ass rubs against your crotch, and it doesn't take long until you have an erection/get aroused, which "+pronheshe+"  notices after a couple of minutes, but instead of complaining "+pronheshe+"  starts to dry humping you. At first it begins slowly, as if it were a mistake, but eventually "+pronheshe+"  increases the pace.\n\nYou slowly slide your dick out, and even if none of you say a word, there is an understanding. Abbadon moves closer to you until your dick is firm between "+pronhisher+" ass cheeks, while the movement of the horse makes "+pronhisher+" strokes more unpredictable, and at the same time more exciting.\n\nBut you believe that it is unfair that you are having all the fun, and you decide to move your hand under "+pronhisher+" dress, where "+pronhisher+" erect dick is pressing against the black tights and underwear. You go under all layers of "+pronhisher+" clothing with your hand until you can feel "+pronhisher+" hard cock in your hand. A small stroke of it makes "+pronhimher+" produce a small moan and makes "+pronhimher+" jump a bit.\n\nBoth of you keep massaging each other for a long time, enjoying the fresh air and solitude of the place, but eventually you are close to climax and tell Abbadon about your situation. \n\n<i>No! Wait, don't dirty my back or the skirt!”</i> You tell "+pronhimher+" that you can’t hold yourself forever, so what you are supposed to do? \n\nHESHE lifts the back of "+pronhisher+" skirt and stretches "+pronhisher+" tights and underwear. You take the hint and proceed to put your dick in between "+pronhisher+" soft skin and "+pronhisher+" intimate clothing, feeling "+pronhisher+" hot balls on your member.\n\n\nBoth of you increase your pace, and "+pronhisher+" soft moans aren’t that soft anymore. You can tell that the two of you are seconds away from orgasm and "+pronheshe+"  just turns and gives you a very deep kiss while you discharge everything you have, while "+pronhisher+" dick drenches your hand and "+pronhisher+" clothes.\n\n\nYou keep riding for a couple of minutes until both of you calm down and descend from the horse. <i>“You soaked my underwear with your fluids!”</i> \n\nYou apologize, and but "+pronheshe+"  just shakes "+pronhisher+" head. <i>“Don't worry, at least no one will notice... And I kinda like the warm feeling...”</i> "+pronheshe+"   grabs "+pronhisher+" crotch, smearing your seed, while letting go a small, erotic moan, and you can’t help yourself and have to lean forward to give "+pronhimher+" a deep kiss again, to which "+pronheshe+"  eagerly responds.\n\n After that, just to make sure, you ask "+pronhimher+" if "+pronheshe+"  would like to keep being your partner. <i>“Yes!... I mean, there are not many people in this city so... I will settle with you for a while, I think...”</i> You pat "+pronhisher+" head and give "+pronhimher+" your hand to hold, before returning to the city. ";
			} else {
				toReturn += "\n\nYou decide that Abbadon’s should have some fun, and you move your hand under "+pronhisher+" dress, where "+pronhisher+" throbing dick is waiting for you with excitement. You go under all of the layers of "+pronhisher+" clothing with your hand until you can feel "+pronhisher+" hard cock, something that makes "+pronhimher+" produce a small moan and makes "+pronhimher+" jump a bit.\n\nYou keep stroking "+pronhimher+" for a long time, enjoying the fresh air and solitude of the place, until "+pronheshe+"  is about to climax.\n\n <i>“No! wait! Ah... You’ll make me soil my clothing!</i> You ask "+pronhimher+" if "+pronheshe+"  really wants you to stop? When "+pronheshe+"  manages to stop panting "+pronheshe+"  just shakes "+pronhisher+" head. \n\n<i>“No... ah... okay keep going... Please! Make me cum!”</i> You increase your pace, and "+pronhisher+" soft moans grow violent. You can feel "+pronhisher+" orgasm seconds away and "+pronheshe+"  just turns and gives you a very deep kiss while "+pronheshe+"  discharges everything "+pronheshe+"  has, feeling "+pronhisher+" cock pulsating in your hand while it shoots its seed. \n \nYou keep riding for a couple of minutes until both of you calm down and descend from the horse. <i>“My underwear is soaking wet!”</i> You apologize, and but "+pronheshe+"  just shakes "+pronhisher+" head.\n\n <i>“Don't worry, at least no one will notice... And I kinda like the warm feeling...”</i> "+pronheshe+"  grabs "+pronhisher+" crotch, rubbing her juices, while letting go a small, erotic moan, and you can’t help yourself and lean forward to give "+pronhimher+" a deep kiss again, to what "+pronheshe+"  eagerly responds.\n\n After that, just to make sure, you ask "+pronhimher+" if "+pronheshe+"  would like to keep being your partner. <i>“Yes!... I mean, there are not many people in this city so... I guess I can settle with you for a while, I think...”</i> You pat "+pronhisher+" head and give "+pronhimher+" your hand to hold, before coming back to the city. ";
			}
		} else {
			if (GameControl.dick1Size> 0) {
				toReturn += "\n\nThe rough movement makes Abbadon’s ass rubs against your crotch, and it doesn't take long until you have an erection/get aroused, which "+pronheshe+"  notices after a couple of minutes, but instead of complaining "+pronheshe+"  starts to dry humping you. At first it begins slowly, as if it were a mistake, but eventually "+pronheshe+"  increases the pace.\n\nYou slowly slide your dick out, and even if none of you say a word, there is an understanding. Abbadon moves closer to you until your dick is firm between "+pronhisher+" ass cheeks, while the movement of the horse makes "+pronhisher+" strokes more unpredictable, and at the same time more exciting.\n\nBut you believe that it is unfair that you are having all the fun, and you decide to move your hand under "+pronhisher+" dress, where "+pronhisher+" humid nether parts are already soaking "+pronhisher+" black tights and underwear. You go under all of "+pronhisher+" layers of clothing with your hand until you can feel "+pronhisher+" hard, soaked clit. With each little touch, it makes "+pronhimher+" jump a bit, followed by a soft moan.\n\nBoth of you keep massaging each other for a long time, enjoying the fresh air and solitude of the place, but eventually you are close to climax and tell Abbadon about your situation. \n\n<i>No! Wait, don't dirty my back or the skirt!”</i> You tell "+pronhimher+" that you can’t hold yourself forever, so what you are supposed to do? \n\nHESHE lifts the back of "+pronhisher+" skirt and stretches "+pronhisher+" tights and underwear. You take the hint and proceed to put your dick in between "+pronhisher+" soft skin and "+pronhisher+" intimate clothing, feeling "+pronhisher+" hot balls on your member.\n\nBoth of you increase your pace, and "+pronhisher+" soft moans aren’t that soft anymore. You can tell that the two of you are seconds away from orgasm and "+pronheshe+"  just turns and gives you a very deep kiss while you discharge everything you have, "+pronhisher+" tight pussy clenching your fingers.\n\nYou keep riding for a couple of minutes until both of you calm down and descend from the horse. <i>“You soaked my underwear with your fluids!”</i> \n\nYou apologize, and but "+pronheshe+"  just shakes "+pronhisher+" head. <i>“Don't worry, at least no one will notice... And I kinda like the warm feeling...”</i> "+pronheshe+"   grabs "+pronhisher+" crotch, smearing your seed, while letting go a small, erotic moan, and you can’t help yourself and have to lean forward to give "+pronhimher+" a deep kiss again, to which "+pronheshe+"  eagerly responds.\n\n After that, just to make sure, you ask "+pronhimher+" if "+pronheshe+"  would like to keep being your partner. <i>“Yes!... I mean, there are not many people in this city so... I will settle with you for a while, I think...”</i> You pat "+pronhisher+" head and give "+pronhimher+" your hand to hold, before returning to the city. ";
			} else {
				toReturn += "\n\nThe rough movement makes Abbadon’s ass rubs against your crotch and body, and it doesn't take long until you get aroused by "+pronhisher+" soft touch, and even when "+pronheshe+"  notices that you are getting hot, "+pronheshe+"  doesn’t mind. For that matter, "+pronheshe+"  even moves closer to you. \n\nYou decide that Abbadon should have some fun, and you move your hand under "+pronhisher+" dress, where "+pronhisher+" humid nether parts are already soaking her black tights and underwear. You go under all of the layers of "+pronhisher+" clothing with your hand until you can feel "+pronhisher+" clit, something that makes "+pronhimher+" produce a small moan and makes "+pronhimher+" jump a bit.\n\nYou keep massaging "+pronhimher+" for a long time, enjoying the fresh air and solitude of the place, until "+pronheshe+"  is about to climax.\n\n <i>“No! wait! Ah... I will soil all my clothing!</i> You ask "+pronhimher+" if "+pronheshe+"  really wants you to stop? When "+pronheshe+"  manages to stop panting "+pronheshe+"  just desperately shakes "+pronhisher+" head. \n\n<i>“No... ah... okay keep going... Please! Make me cum!”</i> You increase your pace, and "+pronhisher+" soft moans grow violent. You can feel "+pronhisher+" orgasm seconds away and "+pronheshe+"  just turns and gives you a very deep kiss while "+pronheshe+"  discharges everything "+pronheshe+"  has, feeling "+pronhisher+" tight pussy clenching on your hands. \n\nYou keep riding for a couple of minutes until both of you calm down and descend from the horse. <i>“My underwear is soaking wet!”</i> You apologize, and but "+pronheshe+"  just shakes "+pronhisher+" head.\n\n <i>“Don't worry, at least no one will notice... And I kinda like the warm feeling...”</i> "+pronheshe+"  grabs "+pronhisher+" crotch, rubbing her juices, while letting go a small, erotic moan, and you can’t help yourself and lean forward to give "+pronhimher+" a deep kiss again, to what "+pronheshe+"  eagerly responds.\n\n After that, just to make sure, you ask "+pronhimher+" if "+pronheshe+"  would like to keep being your partner. <i>“Yes!... I mean, there are not many people in this city so... I guess I can settle with you for a while, I think...”</i> You pat "+pronhisher+" head and give "+pronhimher+" your hand to hold, before coming back to the city. ";
			}
		}
		NPCCharList.CharFollower [iAbbadon].charLove += 20;
		if (NPCCharList.CharFollower [iAbbadon].charLove > 100) {
			NPCCharList.CharFollower [iAbbadon].charLove = 100;

		}


		return toReturn;

	}

	string date3(){
		string toReturn;

		toReturn = "";
		if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 0) {
			if (GameControl.dick1Size> 0) {
				toReturn += "\n\n";
			} else {
				toReturn += "\n\n";
			}
		} else {
			if (GameControl.dick1Size> 0) {
				toReturn += "\n\n";
			} else {
				toReturn += "\n\n";
			}
		}

		NPCCharList.CharFollower [iAbbadon].charLove += 20;
		if (NPCCharList.CharFollower [iAbbadon].charLove > 100) {
			NPCCharList.CharFollower [iAbbadon].charLove = 100;

		}
		return toReturn;

	}

	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		panMainPanel.sortingOrder = -500; 
		endTurnPanel.sortingOrder = 500;


	}

	void loadAbbadonData(){
		iAbbadon = 0;

		while (iAbbadon < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iAbbadon].charID >= 1000 && NPCCharList.CharFollower [iAbbadon].charID < 2000){
				WorldControl.NPCID = NPCCharList.CharFollower [iAbbadon].charID;
				WorldControl.PortraitIDLayer0 = NPCCharList.CharFollower [iAbbadon].charPortraitLayer0;
				WorldControl.PortraitIDLayer1 = NPCCharList.CharFollower [iAbbadon].charPortraitLayer1;
				WorldControl.PortraitIDLayer2 = NPCCharList.CharFollower [iAbbadon].charPortraitLayer2;
				WorldControl.furryPic = NPCCharList.CharFollower [iAbbadon].isFurry;
				WorldControl.futaPic = NPCCharList.CharFollower [iAbbadon].isFuta;
				break; 
			}
			iAbbadon++;

		}

		pronheshe = "he";
		pronHESHE = "He";
		pronhisher = "His";
		pronHISHER = "his";
		pronhimher = "him";
		pronHIMHER = "Him";
		if (NPCCharList.CharFollower [iAbbadon].charGender == NPCData.CharGender.FEMALE) {
			pronheshe = "she";
			pronHESHE = "She";
			pronhisher = "Her";
			pronHISHER = "her";
			pronhimher = "her";
			pronHIMHER = "Her";
		}

	}


}
