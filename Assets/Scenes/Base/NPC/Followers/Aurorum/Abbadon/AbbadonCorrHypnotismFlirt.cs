using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class AbbadonCorrHypnotismFlirt : MonoBehaviour {

	int hashcode = GameControl.playerName.GetHashCode();
	float randNum;

	static string pronheshe;
	static string pronhimher;
	static string pronhisher; 

	static int iAbbadon = 0;
	public Text Board; 

	public Canvas PanEndTurn; 

	public Canvas PanCorruption;


	public void hypnotismFlirt(){

		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);

		loadAbbadon ();

		//difficulty 
		float difficulty = NPCCharList.CharFollower[iAbbadon].attWillpower - (NPCCharList.CharFollower[iAbbadon].charCorruption*0.25f) - 10f - (GameControl.attHypnotism*0.8f);  


		if (GameControl.attHypnotism < 75) {
			randNum += 75; 
		}

		//succeed
		if (randNum > difficulty) {
			corruptionChanges ();

			if (NPCCharList.CharFollower [iAbbadon].charCorruption < 25) {
				Board.text = flirtLevel0();
			} else if (NPCCharList.CharFollower [iAbbadon].charCorruption < 50) {
				Board.text = flirtLevel1();
			} else if (NPCCharList.CharFollower [iAbbadon].charCorruption < 75) {
				Board.text = flirtLevel2();
			} else if (NPCCharList.CharFollower [iAbbadon].charCorruption < 100) {
				Board.text = flirtLevel3();
			} else {
				Board.text = flirtLevel4();
			}

		} else { //failure
			if (NPCCharList.CharFollower [iAbbadon].charCorruption <= 60) {
				Board.text = failureLowCorr ();
			} else {
				Board.text = failureHighCorr ();
			}

		}
		endTurnFun ();

	}




	string flirtLevel0(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum < 33) {
			toReturn = "During your last visit with Abbadon you had the chance to use your hypnotism skills on "+ pronhimher +", and gave "+ pronhimher +" the command to go to a local restaurant and flirt with the waitress, and ignore you if "+ pronheshe +" sees you. \n\nYou finish the meeting and leave the house. Shortly afterward you see "+ pronhimher +" leaving "+ pronhisher +" home and making for the restaurant, following your previous instructions. \n\nKnowing "+ pronheshe +" wont notice you, you stick close to "+ pronhimher +", and once inside you settle into a seat not too far from "+ pronhimher +" in the VIP section. Admittedly it’s a rather lonely second floor, reserved only for the most important noblemen and women of the city.";
			if (WorldControl.futaOn) {
				toReturn += "\n\nAs opposed to seeing to Abbadon, a pretty young waitress comes to you first. Although it’s obvious she recognizes your status, she does nothing but smile innocently, bouncing on her heels in a way that sets her impressively large chest to quaking. With a gently shrug you just ask for wine and some peace and quiet.\n\nShe smiles and nods, leaving to fetch your drink. You almost didn’t notice it, but as your eyes are drawn to her heart-shaped ass as she saunters away, you can make out the hint of a cock sticking out beneath her short skirt. Looks like they employ a rather stacked futanari here…";
			} else {
				toReturn += "\n\nAs opposed to seeing to Abbadon, a pretty young waitress comes to you first. Although it’s obvious she recognizes your status, she does nothing but smile innocently, bouncing on her heels in a way that sets her impressively large chest to quaking. With a gently shrug you just ask for wine and some peace and quiet.\n\nShe smiles and nods, leaving to fetch your drink.";
			}
			toReturn += "\n\nShe pauses at Abbadon’s table on the way out; "+ pronheshe +" is the only other person in this area after all. She goes to Abbadon and asks if there’s anything she’d like. You await with baited breath for "+ pronhimher +" to ask the waitress out, but you can see the way "+ pronheshe +" struggles to get out the words. <i>“I would like you...”</i> "+ pronheshe +" begins awkwardly, before immediately pausing. It’s obvious that "+ pronheshe +" has stubbornly broken through their hypnotic order.\n\nThe moment draws out with the waitress looking "+ pronhimher +" over, before Abbadon coughs, apologizing for the discomfort. <i>“Your best dish! I would like that, please.”</i> The waitress nods and leaves, immediately putting a smile back on. \n\nYou sigh and lean back in your chair, waiting for your drink. It’s a pathetic attempt on Abbadon’s part, but at least "+ pronheshe +" got this far.";
			return toReturn;
		} else if (randNum < 66) {
			toReturn = "During a meeting at your castle you took the chance to hypnotize Abbadon. Although "+ pronheshe +" proved to be exceptionally stubborn, you managed to wrest "+ pronhisher +" mind into your control. You look away from Abbadon and to your window, before spotting a viable target; a young, strong horseman. One of your stable-hands, likely. \n\nWithout much hesitation you order Abbadon to go and flirt with the man, and to ignore your presence. When "+ pronheshe +" stands up you follow on "+ pronhisher +" heels, watching with interest.\n\nIt begins well enough; Abbadon approaches obediently, but once "+ pronheshe +" reaches the stable-hand, "+ pronheshe +" hesitates, as though unsure of what to say. Nervously Abbadon eyes the man from top to bottom, lingering on the bulge in the man’s pants; it looks like it could put the stallions to shame.\n\n<i>“Ehhh... This is a very big...”</i> "+ pronheshe +" awkwardly tries to compliment his size, but freezes partway through. The horse-man frowns, asking if "+ pronheshe +" could repeat herself. With a blink to re-orient herself, you can see the moment your hypnotic order fails, and "+ pronheshe +" claps "+ pronhisher +" hands together. <i>“These are very big horses! Yes, amazing the collection that "+ GameControl.playerName +" has!”</i>\n\nWith that said, Abbadon departs, leaving the stable-hand looking awkwardly in your direction, lost for words. It’s a pathetic attempt on Abbadon’s part, but at least "+ pronheshe +" got this far. ";
			return toReturn;
		} else {
			toReturn = "You were in a business meeting with Abbadon, but during a break you took the chance to hypnotize "+ pronhimher +". Although "+ pronheshe +" proved to be exceptionally stubborn, you managed to wrest "+ pronhisher +" mind into your control. While wondering what to do, an idea finally took shape. You order "+ pronhimher +" to flirt with one of "+ pronhisher +" servants during an unscheduled uniform inspection.\n\nAs soon as you finish the command "+ pronheshe +" calls to one of "+ pronhisher +" servants, a very pretty young girl. She doesn’t look to be very experienced, but she clears her throat and steps up. <i>“Do you need me? How can I serve you?”</i> she asks when she arrives. Abbadon just closes the door behind her and commands the servant to stand in the middle of the room. \n\n<i>“Time for an inspection, let’s see if you are properly dressed!”</i> says Abbadon. The woman stands and keeps quiet while Abbadon walks around her, observing every detail on her uniform. When "+ pronheshe +" is behind the servant, "+ pronheshe +" holds the girl by the waist and feels her a little bit, before releasing her. <i>“All good, very good in fact... Dismissed.”</i>\n\nMuch to your disappointment, your hypnotism doesn’t appear to have pushed Abbadon quite far enough although she did manage to get hands-on. It’s a pathetic attempt on Abbadon’s part, but at least "+ pronheshe +" got this far.\n\n";

			return toReturn;
		}

	}

	string flirtLevel1(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum < 33) {
			toReturn = "With the shift in Abbadon’s behaviour, it’s become far easier to hypnotize "+ pronhimher +". During your last visit with Abbadon you had the chance to use your skills on "+ pronhimher +" again. Interested in seeing if "+ pronheshe +" has improved at all, you give "+ pronhimher +" the command to go to a local restaurant and flirt with the waitress, and ignore you if "+ pronheshe +" sees you. \n\nYou finish the meeting and leave the house. Shortly afterward you see "+ pronhimher +" leaving "+ pronhisher +" home and making for the restaurant, following your previous instructions. \n\nKnowing "+ pronheshe +" wont notice you, you stick close to "+ pronhimher +", and once inside you settle into a seat not too far from "+ pronhimher +" in the VIP section. Admittedly it’s a rather lonely second floor, reserved only for the most important noblemen and women of the city.";
			if (WorldControl.futaOn) {
				toReturn += "\n\nAs opposed to seeing to Abbadon, a pretty young waitress comes to you first. Although it’s obvious she recognizes your status, she does nothing but smile innocently, bouncing on her heels in a way that sets her impressively large chest to quaking. With a gently shrug you just ask for wine and some peace and quiet.\n\nShe smiles and nods, leaving to fetch your drink. You almost didn’t notice it, but as your eyes are drawn to her heart-shaped ass as she saunters away, you can make out the hint of a cock sticking out beneath her short skirt. Looks like they employ a rather stacked futanari here…";

			} else {
				toReturn += "\n\nAs opposed to seeing to Abbadon, a pretty young waitress comes to you first. Although it’s obvious she recognizes your status, she does nothing but smile innocently, bouncing on her heels in a way that sets her impressively large chest to quaking. With a gently shrug you just ask for wine and some peace and quiet.\n\nShe smiles and nods, leaving to fetch your drink.";

			}
			toReturn += "\n\nShe pauses at Abbadon’s table on the way out; "+ pronheshe +" is the only other person in this area after all. She goes to Abbadon and asks if there’s anything she’d like. You await with baited breath for "+ pronhimher +" to ask the waitress out. Abbadon’s sheer mannerisms have changed a little bit; there is a little more confidence, and "+ pronheshe +" proves to be more assertive when acting on your order.\n\nSadly not quite as brazen or bold as you would like, but it is an improvement. That’s why her next words bring you so much delight. <i>“I would like to have a piece of that.”</i> "+ pronheshe +" looks at her body, devouring her with "+ pronhisher +" eyes.\n\nYou see how the woman is embarrassed. Her face goes red and she slowly gulps. She sounds a little confused and mumbles softly again, asking what Abbadon would like to eat. It’s as though someone had whispered magical words in the way that it snaps Abbadon’s trance. <i>“Just bring me a salad and wine.”</i> "+ pronheshe +" asks. After that point, "+ pronheshe +" doesn’t make any more attempts on the wait-staff (although it is <i>quite</i> delicious wine).\n\nAlthough it’s still not a great result, it’s a vast improvement over what you would have expected from "+ pronhimher +" before.\n";
			return toReturn;
		} else if (randNum < 66) {
			toReturn = "With the shift in Abbadon’s behaviour, it’s become far easier to hypnotize "+ pronhimher +". You look away from Abbadon and to your window, before spotting a viable target; your young stable-hand. The horseman is just begging for the attention.\n\nWithout much hesitation you order Abbadon to go and flirt with the man, and to ignore your presence. When "+ pronheshe +" stands up you follow on "+ pronhisher +" heels, watching with interest.\n\nAbbadon does as you command obediently, going downstairs and walking towards the man. <i>“Nice horses you have here”</i> Just that simple question seems to be said more boldly. There’s an assertive tone to her voice that’s reflected in the way the stable-hand responds, standing proudly.\n\n<i>“Yes, the biggest stallions in the kingdom.”</i> the boy says, proud of the beasts that he takes care of. <i>“Are you sure they are the biggest?”</i> Abbadon gets dangerously close to him. You have to bite your knuckle to keep from grinning as "+ pronheshe +" makes the boy blush. His nervousness fades once Abbadon softly, and subtly strokes against his crotch, opting to just play along.\n\nThe two of them talk for a while; it isn’t an interesting conversation, although it is laden with innuendo. Eventually Abbadon turns away and leaves, leaving the poor guy standing around with a nearly painfully-hard tent.\n\nYou are definitely making some progress with Abbadon.  \n";
			return toReturn;
		} else {
			toReturn = "With the shift in Abbadon’s behaviour, it’s become far easier to hypnotize "+ pronhimher +". During one of your business meetings, you settle "+ pronhimher +" into a trance. There had been a moment’s tense struggle before "+ pronheshe +" gave in, and you cast your eyes about the room, humming.\n\nYou then command "+ pronhimher +" to call one of "+ pronhisher +" servants and flirt with her while "+ pronheshe +" inspects her uniform. \n\nAs soon as you finish the command "+ pronheshe +" calls to one of "+ pronhisher +" servants, a very pretty young girl. She doesn’t look to be very experienced, but she clears her throat and steps up. <i>“Do you need me? How can I serve you?”</i> she asks when she arrives. Abbadon just closes the door behind her and commands the servant to stand in the middle of the room. \n\n<i>“Time for an inspection, let’s see if you are properly dressed!”</i> says Abbadon. The woman stands and keeps quiet while Abbadon walks around her, using "+ pronhisher +" hands to feel her butt and breasts. The servant shivers for a moment, chewing on her lip and watching Abbadon. <i>“Is this necessary?”</i> she asks, growing a little uncomfortable. <i>“Shut up! Who are you to question how I do my inspection?!”</i> says Abbadon, putting her in her place. The servant blanches, going a little pale before clearing her throat. <i>“Yes my liege...”</i> is the only thing she says, before Abbadon returns to her ‘inspection’.\n\nAfter ten long minutes, Abbadon is finally done with her <i>“Everything is in order, you can leave sweetie.”</i> "+ pronheshe +" says before giving her a good slap in her ass. <i>“Dismissed.”</i>\n\nThe girl leaves the room, a mixture of confused and scared, perhaps even a little ashamed. You don’t notice; you’re just happy to see that Abbadon carried out the order with surprising ease. Something about being talked back to by a lesser seems to trigger her dominant side.";
			return toReturn;
		}

	}


	string flirtLevel2(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum < 33) {
			toReturn = "You are half way through changing Abbadon. There is a clear corruption to "+ pronhisher +" soul, although there is still plenty of room for change. There is no challenge for you to draw "+ pronhimher +" under your control. Now you get a chance to see just how far she will go.\n\nYou order her to go back to "+ pronhisher +" favorite restaurant, and flirt with the VIP waitress.";
			if (WorldControl.futaOn) {
				toReturn += "\n\nThe two of you take your favorite seats in the VIP room, just in front of each other. Soon enough a waitress comes to take "+ pronhisher +" order. It’s the pretty young waitress with the massive chest. Her heart-shaped ass sways enticingly, although her innocent face is belied by a cock so large it’s visible beneath her skirt’s rim. No wonder why she was hired.";

			} else {
				toReturn += "\n\nThe two of you take your favorite seats in the VIP room, just in front of each other. Soon enough a waitress comes to take "+ pronhisher +" order. It’s the pretty young waitress with the massive chest. Her heart-shaped ass sways enticingly, and her innocent face is bound to draw attention. No wonder why she was hired.";
			}
			if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 0) {
				toReturn += "\n\nShe first asks Abbadon what "+ pronheshe +"’ll want. You feel a little smug as Abbadon confidently leans back, revealing a half-forming tent. <i>“I would like to have a piece of that ass ma’am, what you say? I’ll give you a nice tip.”</i> "+ pronheshe +" playfully grabs "+ pronhisher +" half erect cock, offering it to her. ";
			} else {
				toReturn += "\n\nShe first asks Abbadon what "+ pronheshe +"’ll want. You feel a little smug as Abbadon confidently leans back, trailing a finger down "+ pronhisher +" chest. <i>“I would like to have a piece of that ass ma’am, what you say? I’ll give you a nice tip.”</i> "+ pronheshe +" puts a handful of gold coins on the table, probably worth several months of her salary. ";
			}
			toReturn += "\n\nThe pickup line is awful, and some instinct of the woman has her talking a half-step back, suspecting a trap. Of course, getting on the bad side of a noble, specially one as important as Abbadon, would be unwise. She makes an attempt at backing out of the situation though, and much to your disappointment this seems to be the limit of Abbadon’s current hypnotism. "+ pronheshe +" orders tea and dinner, settling back into the role of a regular customer.\n\nProgress at least.\n";
			return toReturn;
		} else if (randNum < 66) {
			toReturn = "You are half way through changing Abbadon. There is a clear corruption to "+ pronhisher +" soul, although there is still plenty of room for change. There is no challenge for you to draw "+ pronhimher +" under your control. Now you get a chance to see just how far she will go. You look away from Abbadon and to your window, before spotting a viable target; your young stable-hand. The horseman is just begging for the attention.\n\nWithout much hesitation you order Abbadon to go and flirt with the man, and to ignore your presence. When "+ pronheshe +" stands up you follow on "+ pronhisher +" heels, watching with interest.\n\nAbbadon does as you command obediently, but "+ pronhisher +" walk is already far more seductive. There’s a pointed sway to "+ pronhisher +" hips that makes it far more fun to watch. "+ pronheshe +" takes a stance in front of the stable-hand, pouting seductively. <i>“Nice horses you have here. I’m sure it’s great to ride them.”</i>  You can see how now "+ pronheshe +" is more assertive and bold than before, something that’s reflected from how "+ pronheshe +" walks to how "+ pronheshe +" interacts with him.\n\n<i>“I bet so, but I’m not really allowed to ride them.”</i> he says, albeit a little sheepishly. <i>“Is that so? That’s a real shame. Maybe one day you can come to my manor for a ride...”</i> Abbadon saunters dangerously close, fluttering "+ pronhisher +" lashes. You can see the boy is nervous, fully aware of the stature of the person flirting with him, but Abbadon keeps advancing. "+ pronheshe +" places "+ pronhisher +" hand on the fabric that separates skin from cock before dipping in for a kiss. You can actually see blood rushing into his monstrously horse-like cock, growing hard enough to form a mighty tent in his clothing. He returns the kiss with fervor, taking "+ pronhisher +" ass in his hands and giving it a firm squeeze.\n\nUnfortunately, Abbadon stops at simple teasing, leaving the poor stable-hand to deal with a mighty erection and no way to find release.\n\nProgress at least.\n";

			return toReturn;
		} else {
			toReturn = "You are half way through changing Abbadon. There is a clear corruption to "+ pronhisher +" soul, although there is still plenty of room for change. There is no challenge for you to draw "+ pronhimher +" under your control. Now you get a chance to see just how far she will go. You then command "+ pronhimher +" to call one of "+ pronhisher +" servants and flirt with her while "+ pronheshe +" inspects her uniform. \n\nAs soon as you finish the command "+ pronheshe +" calls to one of "+ pronhisher +" servants, a very pretty young girl. She doesn’t look to be very experienced, but she clears her throat and steps up. <i>“Do you need me? How can I serve you?”</i> she asks when she arrives. Abbadon just closes the door behind her and commands the servant to stand in the middle of the room. \n\n<i>“Time for an inspection, let’s see if you are properly dressed!”</i> says Abbadon. The woman stands and keeps quiet while Abbadon walks around her, using "+ pronhisher +" hands to feel her butt and breasts. The servant shivers for a moment, chewing on her lip and watching Abbadon. <i>“So far so good...”</i> says Abbadon, before standing behind her and putting "+ pronhisher +" hand on her crotch, putting "+ pronhisher +" face against the maid’s neck and taking a deep breath. The breath she lets out is a shudder of hungry need. <i>“You smell so nice... As if you were using my perfume. Have you been playing with my things dear?”</i> The question has the girl so nervous she can barely shake her head in a no. Unfortunately for her Abbadon doesn’t believe it.\n\n<i>“Come on, don’t lie to me. What you’ve just done is stealing, and a bad girl gets punished.”</i> Abbadon’s hand goes back, and she lays a slap across the servant’s ass. To the small servant’s credit, she muffles the pained yelp, settling for just trembling as her body is played and toyed with. Abbadon seems delighted with the freedom to grope and squeeze the servant, licking her neck, nibbling her ears. For a brief, intimate moment, her hand slips down the servant’s dress, revealing a neatly-trimmed tuft of pubic hair before it’s hidden behind an exploring hand.\n\nThe servant whimpers and gasps, and you can hear a soft ‘schlick’ as Abbadon’s fingers plunge into her, revealing the girl to be rather wet from the rough play. Abbadon finally releases her, licking "+ pronhisher +" fingers clean. <i>“Fine, I’m going soft with you this time...”</i> says Abbadon before retreating.\n\n<i>“Dismissed. Go on, leave before I regret it.”</i>\n\nThe girl leaves the room, a mixture of confused and scared, perhaps even a little ashamed. You don’t notice; you’re just happy to see that Abbadon carried out the order with surprising ease. Something about being talked back to by a lesser seems to trigger her dominant side.\n\n";
			return toReturn;
		}

	}



	string flirtLevel3(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum < 33) {
			toReturn = "Abbadon soul is now almost fully corrupt, getting into "+ pronhisher +" mind has become an easy task to you. As such, you find plenty of opportunities to put "+ pronhimher +" under your control and to play little games.\n\nYou order her to go back to "+ pronhisher +" favorite restaurant, and flirt with the VIP waitress. As expected, she practically leaps to the chance.";
			if (WorldControl.futaOn) {
				toReturn += "\n\nThe two of you take your favorite seats in the VIP room, just in front of each other. Soon enough a waitress comes to take "+ pronhisher +" order. It’s the pretty young waitress with the massive chest. Her heart-shaped ass sways enticingly, although her innocent face is belied by a cock so large it’s visible beneath her skirt’s rim. No wonder why she was hired.";

			} else {
				toReturn += "\n\nThe two of you take your favorite seats in the VIP room, just in front of each other. Soon enough a waitress comes to take "+ pronhisher +" order. It’s the pretty young waitress with the massive chest. Her heart-shaped ass sways enticingly, and her innocent face is bound to draw attention. No wonder why she was hired.";
			}
			if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 0) {
				toReturn += "\n\nShe goes and asks Abbadon what "+ pronheshe +"’ll want. Abbadon, bold and brazen, just slaps her butt and starts to caress it <i>“What you think about having some fun? Do you want to get a big tip?”</i> unashamed Abbadon exposes "+ pronhisher +" erect cock to her, the head already covered in precum. \n\nThe girl smiles and teases "+ pronhimher +", trying to get a good and <i>real</i> tip from Abbadon, not just sex.\n\n<i>“Such a hard girl, fine!”</i> "+ pronheshe +" takes a bunch of gold coins from "+ pronhisher +" bag and throws it into the table, an amount that surely accounts for more than what she earns in a month.\n\nThe girl smiles at the generous gift that Abbadon is offering, and without saying anything else she kneels down. With her warm hands grabs Abbadon’s throbbing mast, playfully slapping it against her lips and face a little bit first, but Abbadon, impatient, grabs her by the back of the head and pulls her towards "+ pronhimher +" <i>“Come on bitch, get to work!”</i> \n\nShe gets as much as she can in her mouth before she starts coughing, moving back and for at the pace set by Abbadon’s hand. You enjoy a show that goes for around ten minutes before you can hear the noble growl before releasing "+ pronhisher +" seed deep inside the girls throat, forcing her to swallow all.\n\nAbbadon doesn’t lets her go until "+ pronhisher +" dick is soft again, but is not like the girl minds much being in between her client’s legs. <i>“Good job girl, I may come more often here.”</i>\n\nAfter their little adventure, Abbadon asks for some food and wine to recover "+ pronhisher +" energy, the rest of the evening is pretty casual, as if nothing had happened. ";
			} else {
				toReturn += "\n\nShe goes and asks Abbadon what "+ pronheshe +"’ll want. Abbadon, bold and brazen, just slaps her butt and starts to caress it <i>“What you say about having some fun? Do you want to leave this place with a bonus?”</i> unashamed Abbadon exposes "+ pronhisher +" wet pussy to her, "+ pronhisher +" cave ready to receive some love. \n\nThe girl smiles and teases "+ pronhimher +", wanting to know how much of a bonus "+ pronheshe +" is talking about.\n\n<i>“Such a hard girl, you have no faith! Fine!”</i> "+ pronheshe +" takes a bunch of gold coins from "+ pronhisher +" bag and throws it into the table, an amount that surely accounts for more than what she earns in a month.\n\nThe girl smiles at the generous gift that Abbadon is offering, and without saying anything else she kneels down. With her warm hands grabs Abbadon’s legs and spreads them more, giving a good whiff to "+ pronhisher +" nether parts and licking her lips before going down to business. She starts by licking "+ pronhisher +" clit, but Abbadon, as impatient as "+ pronheshe +" is, grabs her by the back of the head and pulls her towards "+ pronhimher +" <i>“Come on bitch, get to work!”</i> \n\nThe move takes her by surprise, but once the shock is gone she starts to get into it and use her tongue, cleaning the noble’s pussy before going in with her tongue. She makes sure to go as deep as she can, her nose already against Abbadon’s belly, barely able to breath. \n\nYou enjoy a show that goes for around ten minutes before you can hear the noble growl before releasing in the girls mouth, forcing her to drink "+ pronhisher +" fluids and at the end spraying her face and uniform with them.\n\nAbbadon doesn’t lets her go until "+ pronheshe +" is done with "+ pronhisher +" orgasm, but is not like the girl minds much being in between her client’s legs. <i>“Good job girl, I may come more often here.”</i>\n\nAfter their little adventure, Abbadon asks for some food and wine to recover "+ pronhisher +" energy, the rest of the evening is pretty casual, as if nothing had happened. \n";
			}

			return toReturn;
		} else if (randNum < 66) {
			toReturn = "Abbadon’s mind has weakened a lot, "+ pronhisher +" soul almost fully corrupt. During a private meeting with "+ pronhimher +" in your castle you got "+ pronhimher +" under your control without effort. As usual you can see the stable boy, a strong and handsome horseman, is taking a break.\n\nWhile Abbadon is in a trance you command "+ pronhimher +" to go down there and flirt with the boy, ignoring your presence while "+ pronheshe +" does so.\n\nAbbadon, totally under your control, does as you command, going downstairs and walking towards the worker. Abbadon’s corruption shows up significantly more now, just by the sexy way "+ pronheshe +" walks, and the way "+ pronheshe +" makes sure to reveal "+ pronhisher +" chest a little more. <i>“Hey sweetheart, can I give a good look to these horses?”</i> the man, knowing Abbadon is an important noble, agrees to "+ pronhisher +" request. \n\n<i>“Oh but this fence is to tall, do you mind? I’m sure you can lift me with ease boy.”</i> carefully the man stands behind Abbadon and grabs "+ pronhimher +" by the waist, lifting them up and placing "+ pronhimher +" on a bench so "+ pronheshe +" can see better, but before he lets Abbadon go, "+ pronheshe +" grabs "+ pronhisher +" hands.\n\n<i>“You can leave them there big boy. Don’t be scared, get closer.”</i> Abbadon starts to flaunt "+ pronhisher +" ass, pushing it towards the man’s body, his now-erect cock trapped in between Abbadon’s ass cheeks.\n\nBut this is not enough for Abbadon, who starts to move "+ pronhisher +" butt up and down, masturbating the worker. With swift hand motions, Abbadon manages to unzip the pants of the boy and free his generous horse dick, smearing Abbadon’s back with thick pre. \n\nNone of them utter a word, but Abbadon’s keeps hotdogging the boy for several minutes, until he finally has to release his seed on top of the noble, tainting "+ pronhisher +" hair, back and ass with cum. You can hear Abbadon laugh, pleased and amused by the peasant, scooping a handful of cum and drinking it. \n\n<i>“Such a thick load, maybe next time I let you fill me up.”</i> "+ pronheshe +" says with a sultry smile. Done for today, Abbadon turns away and leaves to "+ pronhisher +" manor, still drenched in cum.";
			return toReturn;
		} else {
			toReturn = "Abbadon has changed, almost fully corrupt at this point. During one of the business meetings you had with "+ pronhimher +" in "+ pronhisher +" manor you took the chance to put "+ pronhimher +" under your control.\n\nEffortlessly you put "+ pronhimher +" in a trance, ready to follow your orders. You then command "+ pronhimher +" to call one of "+ pronhisher +" servants and have "+ pronhisher +" way with her while "+ pronheshe +" inspects her uniform. \n\nWhen you snap your fingers, Abbadon carries on with your order, calling one of "+ pronhisher +" youngest servants, a girl that’s pretty but very shy.  <i>“Y-yes? How can I serve you?”</i> she asks when she arrives. Abbadon just closes the door behind her and commands her to stand in the middle of the room, order that she follows as she has been taught. ";
			if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 0) {
				toReturn += "\n\nAbbadon stands behind the servant and grabs her by the waist, pushing "+ pronhisher +" hard cock against her ass. <i>“Is time for your inspection, let’s see if everything is in order sweetheart.”</i> Abbadon starts to kiss her neck and grope her breasts, ass and pussy while dry humping her until "+ pronheshe +" is fully turned on. \n\n<i>“So fine so good, but I need to check your underwear too.”</i> without waiting for her Abbadon starts to torn her clothes away, leaving her only with a cute bra and panties. Abbadon smiles at the sight of the poor girl <i>“Oh no, I think you are missing something, let me help you with that...”</i> Abbadon spreads her legs a little bit and slips "+ pronhisher +" dick in the crack between her panties and soft skin, before closing the servant’s legs together again, trapping "+ pronhisher +" cock between them. <i>“How have you forgotten to have semen in your panties dear? Oh well, we’ll have that fixed in a moment.”</i> Abbadon grabs her by the hips and starts to use her as a sex toy, nothing but a tool for "+ pronhisher +" masturbation.\n\nAbbadon keeps kissing and licking her back and neck, groping her body for several minutes until "+ pronheshe +" is ready to release. <i>“Here it is girl!”</i> "+ pronheshe +" says seconds before cumming in her underwear, drenching both it and the girl’s body with cum. \n\nAbbadon steps away, shooting one last time in her ass before being done, and telling her to dress up. <i>“Now go and proudly show to the rest how you need to be properly dressed, girl.”</i>\n\nThe girl leaves the room with haste, and you are glad to see that Abbadon is carrying out your orders with ease now. ";

			} else {
				toReturn += "\n\nAbbadon removes "+ pronhisher +" clothes, stands behind her and grabs her hand, pulling it until its touching "+ pronhisher +" pussy. <i>“Let’s see how dexterous you are now sweetheart.”</i> Abbadon starts to kiss the servent’s neck and grope her breasts and ass, occasionally teasingher pussy while "+ pronheshe +" uses the servant’s hand to please "+ pronhimher +"self. \n\n<i>“Do you want to fail the test? Put some effort girl.”</i> Abbadon starts to tear her clothes away, leaving her only with a cute bra and panties. Abbadon smiles at the sight of the poor girl <i>“That’s better, but you need to continue...”</i> the maid starts to move her fingers avidly, encouraged by the threat. <i>“Mhmm... Yes, that’s better, you doing fine now.”</i> Abbadon keeps playing with her body, but for "+ pronhimher +" she is nothing but a tool for "+ pronhisher +" own pleasure.\n\nAbbadon keeps kissing and licking her back and neck, groping her body for several minutes until "+ pronhisher +" body starts to tremble at the edge of an orgasm. <i>“Here it is girl! Keep going!”</i> "+ pronheshe +" says seconds before cuming on her hand, drenching it and her body with "+ pronhisher +" fluids. \n\nAbbadon steps away, satisfied for now, telling her to dress up. <i>“Now go and proudly show to the rest how you need to be properly dressed, girl.”</i>\n\nThe girl leaves the room with haste, and you are glad to see that Abbadon is carrying out your orders with ease now. \n\n";

			}
			return toReturn;
		}

	}



	string flirtLevel4(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum < 33) {
			toReturn = "Abbadon soul is now fully corrupt, getting into "+ pronhisher +" mind has become an easy task with no challenge. You find plenty of opportunities to put "+ pronhimher +" under your control and to play with "+ pronhimher +". \n\nToday after a business meeting you had with "+ pronhimher +" you decided to put "+ pronhimher +" into a trance and to command "+ pronhimher +" to go to "+ pronhisher +" local restaurant and has "+ pronhisher +" way with one of the waitress there. \n\nAs expected, "+ pronheshe +" does so without any hesitation. You follow "+ pronhimher +" until the two of you are in the VIP room, a place exclusive for a selected few and where you can enjoy the show without interruptions. \n\nIt doesn’t takes long until one girl comes to take Abbadon’s order. The young girl has a very short, almost skimpy uniform, giving you a good view to her legs and breasts, with an easy going attitude and probably eager to serve in more than one way.";
			if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 0) {
				toReturn += "\n\nShe goes and asks Abbadon what "+ pronheshe +"’ll want. Abbadon, bold and brazen, just slaps the waitress’ butt and starts to caress it <i>“I would like to have a piece of that ass ma’am, what you say? Do you want to get a big tip?”</i> unashamed Abbadon exposes "+ pronhisher +" erect cock to her, the head already covered in precum. \n\nThe girl smiles and teases "+ pronhimher +", trying to get a good and <i>real</i> tip from Abbadon, not just sex.\n\n<i>“Such a hard girl, fine!”</i> "+ pronheshe +" draws a fistful of gold coins from "+ pronhisher +" bag and throws it into the table, an amount that surely accounts for more than what she earns in a month.\n\nThe girl smiles at the generous gift that Abbadon is offering, and without saying anything else she turns around, allowing Abbadon to have the best sight of her ass. After another loud slap, Abbadon lifts the girl’s skirt. To your surprise, there’s no underwear to be found. \n\n<i>“Do you like it?”</i> she asks while bending over. <i>“Sure I do, time to earn that money.”</i> Abbadon stands and aims "+ pronhisher +" dick towards her cunt. No love or foreplay, just raw sex and lusting for satisfaction. \n\nThe two of them start to fuck loudly, making sure everyone in the restaurant will hear them. The show doesn’t go for long, as the girl proves to be good at what she does. Soon enough the noble cums and fills her to the brim with burning-hot seed.\n\n<i>“Ahhh... That was a good fuck, you really earned your gold. Now hurry and bring me food and wine, I’m starving.”</i> The girl nods and goes downstairs to bring "+ pronhisher +" order, leaving a trail of cum behind her. \n\nAlthough during the rest of the evening Abbadon keeps teasing and flirting with her, nothing more happens until "+ pronheshe +" is done. ";

			} else {
				toReturn += "\n\nShe goes and asks Abbadon what "+ pronheshe +"’ll want. Abbadon, bold and brazen, just slaps her butt and starts to caress it <i>“I would like to have a piece of that ass ma’am, what you say? Do you want to leave this place with a bonus?”</i> unashamed Abbadon exposes "+ pronhisher +" wet pussy to her, "+ pronhisher +" cave ready to receive some love. \n\nThe girl smiles and teases "+ pronhimher +", wanting to know how much of a bonus "+ pronheshe +" is talking about.\n\n<i>“Such a hard girl, you have no faith! Fine!”</i> "+ pronheshe +" draws a fistful of gold coins from "+ pronhisher +" bag and throws it into the table, an amount that surely accounts for more than what she earns in a month..\n\nThe girl smiles at the generous gift that Abbadon is offering, and without saying anything else she turns around, allowing Abbadon to have the best sight of her ass. After another loud slap, Abbadon lifts the girl’s skirt. To your surprise, there’s no underwear to be found.\n\n<i>“Do you like it?”</i> she asks while bending over. <i>“Sure I do, but it’s time to earn that money, come here.”</i> Abbadon forces her to kneel and grabs her by the back of her head, pulling her towards "+ pronhisher +" netherparts. The girl doesn’t resist, going along with Abbadon desires.\n\nYou can hear the loud slurping sound that she is making, and Abbadon moans so hard you are certain that everyone in the restaurant knows what "+ pronheshe +" is doing.  \n\nThe girl has an experienced mouth that is no match for the horny and eager Abbadon, who starts to orgasm just ten minutes after she has started. \n\nEven after "+ pronheshe +" is done the girl stays down there, making sure to clean "+ pronhimher +" up before standing again. <i>“Ahhh... That’s a good job, you earned your gold. Now hurry and bring me food and wine, I’m starving.”</i> The girl nods and goes downstairs to bring "+ pronhisher +" order, leaving behind her a trail of her own fluids, aroused. \n\nAlthough during the rest of the evening Abbadon keeps teasing and flirting with her, nothing more happens until "+ pronheshe +" is done. ";

			}
			return toReturn;
		} else if (randNum < 66) {
			toReturn = "Abbadon’s soul is fully corrupt. During a private meeting with "+ pronhimher +" in your castle you got "+ pronhimher +" under your control without effort, and commanded "+ pronhimher +" to go with the stable boy downstairs and have "+ pronhisher +" way with him. \n\nObediently Abbadon follows your command, at this point unable to fight against your will. Abbadon’s new behavior is bold, brazen and lewd. <i>“Hey sweetheart, aren’t you tired of riding horses? Why you don’t take a break and ride this.”</i> Abbadon turns around and lifts "+ pronhisher +" dress, showing him "+ pronhisher +" bare ass. The man, cautious, asks if they should go to a more private place. <i>“Are you a man or a boy? Just fucking take me!”</i> \n\nThe worker doesn’t waste anymore time, and his big horse cock flops out, quickly growing hard and ready for action.\n\nAbbadon helps him by grabbing his cock and aiming it to "+ pronhisher +" ass, <i>“Mmmh yes, I love cocks like yours.”</i> says the noble before pushing the mast inside "+ pronhimher +". \n";
			if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 0) {
				toReturn += "\n\nWith his strong hands the man grabs Abbadon by the waist and starts to pound "+ pronhimher +" hard. <i>“Ahh! Yes! Keep it like that champ!”</i> Abbadon mutters while "+ pronhisher +" dick flops around, leaking precum everywhere.\n\nThe horseman plays with Abbadon, touching "+ pronhisher +" whole body and kissing "+ pronhimher +" while he keeps pounding "+ pronhimher +" right in the open, to the delight of servants and guards.\n\nIt doesn’t take long until your servant can’t hold anymore against the tight ass of Abbadon, groaning like crazy when his body gives up, filling Abbadon’s ass with his seed.\n\n<i>“Yes! Fill me up! Ngh!”</i> the noble starts to cum hands free once "+ pronhisher +" ass is filling up with sperm. "+ pronhisher +" wildly-flopping dick sprays spunk wildly in the air. Although most of it falls to the ground, some of it hits Abbadon in the face and chest, adding to the mess.\n\nWhen the man is done he releases Abbadon, who falls to the ground exhausted from the brutal fucking.\n\nIt takes an hour until Abbadon finally wakes up and goes back to "+ pronhisher +" manor, drenched in sperm for the amusement of the city.\n ";
			} else {
				toReturn += "\n\nWith his strong hands the man grabs Abbadon by the waist and starts to pound "+ pronhimher +" hard. <i>“Ahh! Yes! Keep it like that champ!”</i> Abbadon mutters while "+ pronheshe +" starts to play with "+ pronhisher +" overflowing pussy.\n\nThe horseman plays with Abbadon, touching "+ pronhisher +" whole body and kissing "+ pronhimher +" while he keeps pounding "+ pronhimher +" right in the open, to the delight of servants and guards.\n\nIt doesn’t take long until your servant can’t hold anymore against the tight ass of Abbadon, groaning like crazy when his body gives up, filling Abbadon’s ass with his seed.\n\n<i>“Yes! Fill me up! Ngh!”</i> the noble starts to orgasm, squirting all over the ground and around his knuckles, adding to the mess.\n\nWhen the man is done he releases Abbadon, who falls to the ground exhausted from the brutal fucking.\n\nIt takes an hour until Abbadon finally wakes up and goes back to "+ pronhisher +" manor, drenched in sperm for the amusement of the city.";

			}
			return toReturn;
		} else {
			toReturn = "Abbadon has changed, "+ pronhisher +" soul fully corrupt at this point. During one of the business meetings you had with "+ pronhimher +" in "+ pronhisher +" manor you took the chance to put "+ pronhimher +" under your control and command "+ pronhimher +" to call one of the servants and have "+ pronhisher +" way with her while "+ pronheshe +" inspects her uniform. \n\nWhen you snap your fingers, Abbadon carries on with your order, calling one of "+ pronhisher +" youngest servants, a girl that’s pretty but very shy.  <i>“Y-yes? How can I serve you?”</i> she asks when she arrives. Abbadon just closes the door behind her and commands her to stand in the middle of the room, order that she follows as she has been taught. ";
			if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 0) {
				toReturn += "\n\nAbbadon stands behind her and grabs her by the waist, pushing "+ pronhisher +" hard cock against her ass. <i>“Is time for your inspection, let’s see if everything is in order sweetheart.”</i> Abbadon starts to kiss her neck and grope her breasts, ass and pussy while dry humping her until "+ pronheshe +" is fully turned on. \n\n<i>“So far so good, but I need to make sure everything is in order, you’ll get naked.”</i> without waiting for her Abbadon starts to torn her clothes away, removing all of her clothes. Abbadon smiles at the sight of the poor girl <i>“Oh you look great, but there is still something missing, let me help you with that...”</i> Abbadon spreads her legs a little bit and touches her pussy. <i>“Getting wet huh? I knew you liked this, bitch.”</i> Abbadon shoves two of "+ pronhisher +" fingers inside her and she gasps. Although she fights a little bit, you realize that this is part of a ritual between the two, a subtle smile on the servant’s face revealing her true feelings. \n\nAbbadon undresses "+ pronhimher +"self and puts "+ pronhisher +" dick her sultry entrance. <i>“Ready sweetheart?”</i> "+ pronheshe +" asks the maid, who nods in response. Without further delay Abbadon goes pushes forward, "+ pronhisher +" throbbing dick submerging inside her.\n\nThe previous silence of the room is replaced by the sound of bodies slapping together, the wet noise of their sexes and the moanings of pleasure of the noble and "+ pronhisher +" servant. Abbadon grabs her by the hips and starts to pump into her, focusing on "+ pronhisher +" pleasure and enjoyment. \n\nIt doesn’t take long until Abbadon’s body is begging for release, and unable to contain "+ pronhimher +"self anymore "+ pronheshe +" finally explodes inside the maid’s cunt, filling it with "+ pronhisher +" seed until it starts dripping to the floor. \n\nAbbadon steps away, shooting one last time on to the servant’s ass, tainting her beautiful skin with "+ pronhisher +" sperm. Once done, she commands her to dress up but not clean up. <i>“Now go and proudly show to the rest how you need to be properly dressed, girl.”</i>\n\nThe girl smiles and nods before leaving the room, and you leave the manor happy to know that Abbadon has been changed. ";

			} else {
				toReturn += "\n\nAbbadon removes "+ pronhisher +" clothes, stands behind her and grabs her hand, pulling it until its touching "+ pronhisher +" pussy. <i>“Let’s see how dexterous you are now sweetheart.”</i> Abbadon starts to kiss her neck and grope her breasts, ass and pussy while "+ pronheshe +" uses the servant’s hand to please "+ pronhimher +"self. \n\nAbbadon moves away for a moment and goes to "+ pronhisher +" desk, where she takes a big strap-on out <i>“Ready for this sweetheart?”</i> "+ pronheshe +" says while wearing the sex toy. The maid, who you can see is enjoying this more than she intends to let on nods in response, trying to keep the subtle smile off of her face. Without further delay Abbadon goes back to her and puts "+ pronhisher +" toy at her wet entrance, just to immediately push forward and submerging the fake cock inside her.\n\nAlthough Abbadon starts to move, the girl is mostly passive <i>“Do you want to fail the test? Put some effort girl.”</i> Abbadon starts to torn her clothes away until she is naked. Abbadon smiles at the sight of the poor girl <i>“That’s better, but you need to continue... Come on, move your body!”</i> the maid starts to move her hips avidly, encouraged by the threat. <i>“Mhmm... Yes, that’s better, you doing fine now.”</i> Abbadon keeps playing with her body, but for "+ pronhimher +" she is nothing but a tool for "+ pronhisher +" own pleasure.\n\nAbbadon keeps kissing and licking her back and neck, groping her body for several minutes until both of them start to tremble at the edge of an orgasm. <i>“Here it is girl! Keep going!”</i> "+ pronheshe +" says seconds before losing control of "+ pronhisher +" body, a strong orgasm overcoming "+ pronhisher +" mind.  \n\nThey stay together for a couple of minutes while they recover, but when Abbadon has strenght again "+ pronheshe +" steps away, satisfied for now, telling her to dress up. <i>“Now go and proudly show to the rest how you need to be properly dressed, girl.”</i>\n\nThe girl smiles and nods before leaving the room, and you leave the manor happy to know that Abbadon has been changed. ";

			}
			return toReturn;
		}

	}


	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		PanCorruption.sortingOrder = -500;
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





	string failureHighCorr(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);

		if (randNum < 33) {
			return "You visited Abbadon today, but "+ pronhisher +" reception was anything but warm. <i>“What do you want "+ GameControl.playerName +"? I’m too busy today to deal with you. Next time warm me about your visits!”</i> "+ pronheshe +" then slammed the door in your face.\n\nAnnoyed, you have no other option but to return to your castle and visit Abbadon later. ";
		} else if (randNum < 66) {
			return "Today you attempted to corrupt Abbadon again with your special concoction, but this is not your lucky day. When you arrive to "+ pronhisher +" home, a maid informs you that "+ pronheshe +" had to leave early to deal with some business. You ask to the young lady if you can wait for "+ pronhimher +" inside, but she refuses, saying that Abbadon may not even come today.\n\nDisappointed, you go back to your castle. ";
		} else {

			return "Today you attempted to corrupt Abbadon again with your special concoction, but this is not your lucky day. When you arrive to "+ pronhisher +" home, a maid informs you that "+ pronheshe +" had to leave early to deal with some business. You ask to the young lady if you can wait for "+ pronhimher +" inside, but she refuses, saying that Abbadon may not even come today.\n\nDisappointed, you go back to your castle. ";
		}
		if (randNum < 33) {
			toReturn = "";
			if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 0) {
				toReturn += "\n\n";
			} else {
				toReturn += "\n\n";
			}
			toReturn += "\n\n";
			return toReturn;
		} else if (randNum < 66) {
			toReturn = "";
			if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 0) {
				toReturn += "\n\n";
			} else {
				toReturn += "\n\n";
			}
			toReturn += "\n\n";
			return toReturn;
		} else {
			toReturn = "";
			if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 0) {
				toReturn += "\n\n";
			} else {
				toReturn += "\n\n";
			}
			toReturn += "\n\n";
			return toReturn;
		}
	}

	string failureLowCorr(){
		string toReturn = "";
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum < 33) {
			return "You visited Abbadon today, but "+pronhisher+" reception was anything but warm. <i>“What do you want "+ GameControl.playerName +"? I’m too busy today to deal with you. Next time warm me about your visits!”</i> "+ pronheshe +" then slammed the door in your face.\n\nAnnoyed, you have no other option but to return to your castle and visit Abbadon later. ";
		} else if (randNum < 66) {
			return "Today you attempted to corrupt Abbadon again with your special concoction, but this is not your lucky day. When you arrive to "+ pronhisher +" home, a maid informs you that "+ pronheshe +" had to leave early to deal with some business. You ask to the young lady if you can wait for "+ pronhimher +" inside, but she refuses, saying that Abbadon may not even come today.\n\nDisappointed, you go back to your castle. ";
		} else {

			return "Today you attempted to corrupt Abbadon again with your special concoction, but this is not your lucky day. When you arrive to "+ pronhisher +" home, a maid informs you that "+ pronheshe +" had to leave early to deal with some business. You ask to the young lady if you can wait for "+ pronhimher +" inside, but she refuses, saying that Abbadon may not even come today.\n\nDisappointed, you go back to your castle. ";
		}
	}

	void corruptionChanges(){
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime +2); 

		NPCCharList.CharFollower[iAbbadon].charCorruption += Random.Range (1.2f, 4f);
		NPCCharList.CharFollower[iAbbadon].charRelationship += Random.Range (0.5f, 2.5f);
		NPCCharList.CharFollower[iAbbadon].charLoyalty += Random.Range (0.5f, 2.5f);

		if (NPCCharList.CharFollower [iAbbadon].charCorruption < 50) {
			GameControl.charCorruption += Random.Range (1.5f, 3f);

		} else {
			GameControl.charCorruption += Random.Range (2.5f, 6f);

		}

		if (GameControl.attHypnotism < 30) {
			GameControl.attHypnotism += Random.Range (2f, 4f);
		} else if (GameControl.attHypnotism < 50) {
			GameControl.attHypnotism += Random.Range (1f, 3f);
		} else {
			GameControl.attHypnotism += Random.Range (0.2f, 1f);
		}
	}



}
