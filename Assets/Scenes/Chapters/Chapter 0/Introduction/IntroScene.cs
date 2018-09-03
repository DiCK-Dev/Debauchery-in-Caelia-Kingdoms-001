using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class IntroScene : MonoBehaviour {

	public Text Board; 
	public Canvas endTurnPanel; // use change scene only 
	static int iHelena; 

	static int confirmationControl; 
	public Canvas panConfirmation;

	public Text option0Name; 
	public Text option1Name;


	public void introStart(){
		if (GameControl.charCorruption < 0) {
			GameControl.charCorruption = 0;
		}

		Board.text = "You travel through the forest until you arrive to the city. Aurorum lies before you, its tall stone walls protecting it from any external harm. But the place is nothing but a shadow of its former glory. The first signs of its decay are obvious even from the outside, the fields surrounding it full of weeds, and abandoned. On the other side of those walls, no street is free of the jobless citizens who struggle to survive day to day. The green parks and thriving commerce that you once knew as a child are long gone. At the center of the city, upon a small hill, you can vaguely make out the silhouette of a great castle. Once you get closer, however, you can see that it is faring no better than the rest of the city. Your new home is almost in ruins, barely an improvement over your old shack. \n\nTwo soldiers await you at the gates of the castle. They look at each other and nod before opening the door, already anticipating your arrival. The first good surprise you get is that, although the castle is in ruins, someone has been taking care of it; or at least keeping the dust away. You call out, to see if you can meet the person who has been cleaning the place. Almost immediately you hear the noise of footsteps, and a feminine voice calling back to you. <i>\"On my way!\"</i> It doesn’t take long until a clumsy looking girl hurries downstairs to greet you. \n\nShe immediately stands in front of you and bows <i>“I’m sorry! I tried to get the house clean before your arrival, but it’s not ready yet. Please forgive me, but this place is too big for a single servant!”</i> You detect a glimpse of fear in her voice.\n\nThe girl stands in front of you, awaiting your command, and for the first time you have that feeling of authority. You realize that you have a great deal of power, but also that you must be careful with it. Should you instill fear in the heart of your servant? Or you should be benevolent and permissive, earning her loyalty? ";
		option0Name.text = "Instill loyalty";
		option1Name.text = "Instill fear";
		confirmationControl = 0; 
		LawController.EnactLaw(new LawTaxesVeryLow());
	}



	public void confirmFun(int selector){
		string king = "King"; 
		if (GameControl.mcGender == GameControl.MCGender.FEMALE) {
			king = "Queen";
		}

		// Loyalty / Fear 
		if (selector == 0 && confirmationControl == 0) {
			Board.text = "You ask the girl to ease up and present herself, but instead of relaxing she just becomes more nervous. <i>\"I apologize for my dreadful manners, my Liege, my name is Helena and I...\"</i> She loses her composure for a moment, terrified of how you might react <i>\"and I could serve you, my Liege. I've been taking care of this castle since the late lord passed away.\"</i> You can see the desperate pleading within her begging eyes. <i>\"I am skilled at various tasks, I am even literate and can do all of your accounting! I've been vital to maintaining this place... just don't kick me to the streets, this place is my home!\"</i> You stand still for a moment, trying to process all the information, before accepting her offer. Her whole body relaxes, and she sighs with relief. \n\nYou tell her that she may stay, but that you will need her support for what lies ahead. You are a total stranger to the city and know little to nothing about its history or politics. You don't say it aloud, but without a guide, you’d be completely lost. <i>\"Don't worry my liege, I know a lot about what is going on, I can advise you on any matters related to the city, and its inner workings.\"</i> \n\nAfter the brief introduction, she gives you a tour of the house. As expected, the ruinous castle is doing no better than the rest of the city. Helena explains that the place was looted a while ago, and the only furniture left is destroyed or improvised. The tour ends at the throne room, where you take a seat on a stone throne that only exists due to its being a part of the castle in itself.\n\nYou notice that the maid is the only person living in the castle, and you ask her why is that. <i>\"Well, it’s just... I don't really have any choice in the matter. I have no family, nor anyone else who would be willing to take me in. I work for other noblemen and women doing odd jobs, but here is the only place I can live for free. Ever since the late lord passed away, they’ve believed it to be haunted, but I can assure you, that's a lie. It is, however, a very useful lie that's kept away anyone who tried to enter.\"</i>\n\nNow that she feels more comfortable, she is more eager to talk, having been dying to have a proper conversation, possibly for months, or even years. Would you like to spend this time getting to know her some more and increase your relationship, or just get straight to business?";
			option0Name.text = "Talk with her";
			option1Name.text = "Current affairs";
			confirmationControl = 1;

			return; 
		}
		if (selector == 1 && confirmationControl == 0) {
			Board.text = "You ask the girl to stand up straight and present herself. She immediately follows your command, as though she had been through this countless times in the past. <i>“My name is Helena, my Liege, I work to keep this castle clean and in order.”</i> You laugh and mock her work, telling her that she hasn’t been doing a very good job of it. She stumbles slightly in panic before answering. <i>“I do what I can my Liege, but there is no money, nor is there anyone else left to help with the tasks.”</i> You ignore her answer and walk around her in a circle, inspecting the maid like some common chattel.\n\nHer clothes were luxurious and pristine in the past, but now they are nothing but old and tattered rags. You can see that she is still in good shape to work, although you will need more servitude if you wish to keep the place in working order. You ask if she has any skills, or anything that makes her useful to you, and this time she answers in a more mechanical manner. <i> \"I can read, I can handle finances, I can assist with history and offer advice about the different houses in the city.\"</i> Granted that she is more skilled than half the city, you tell her she can stick around so long she works hard and correctly refers to you by your new title. <i> \"Thank you,  my Liege, you won't regret your choice.\" </i>\n\nWhen your inspection is over, you order her to give you a tour of the place. As expected, the near abandoned castle is doing no better than the rest of the city. Almost all of the furniture is either improvised or broken apart, though you are glad that the rock solid walls still hold up. The tour ends at a studio within one of the towers of the castle, a vantage point from which you can view the entire city. \n\nYou could try to test Helena and see how far she is willing to go to keep her position, or just go back to business.\n";
			option0Name.text = "Ask her to knee";
			option1Name.text = "Current affairs";
			confirmationControl = 100;

			return; 
		}


		///////////////////////////// Talk with her / current affairs 

		if (selector == 0 && confirmationControl == 1) {
			Board.text = "Knowing more about your servant and get more acquainted with her is an important step towards getting this place running. You ask about her experience these past years, and her story. <i>“Eh… There is not much to say… I’ve been taking care of the castle as best as I can these past years, but this place is kinda lonely, given that no one bothers to come here anymore...”</i> She pauses, trying to remember a tale worth telling, but it seems as though nothing comes to her mind. Finally, she says <i>“Well, you know there was a big monster just a week ago! An enormous spider!”</i> with her hands she makes a gesture to show how big it was, and although it was as big as a melon, it’s definitely not a monster. You asked her if she killed it. <i>“Oh... Fight it? Not really, I just kept my distance... I think it eventually got bored and left this haunting place too.”</i> You smirk and try to cheer her up, telling her that your life was as exciting as hers only a few days ago.\n\nYou ask when it was that everything started to fall apart. <i>“You don’t know? It all started with this plague that transformed people into beasts a few years ago. On top of that, people have been changing not just physically but their souls are… different too. The late lord was affected by it, becoming more and more depraved and erratic; neglecting the city in favour of his own personal and earthly desires. His carelessness resulted in a cynical city, where everyone just care about himself and no one else.”</i> You tell her that you’ll take care of the city, improving its current situation. She gives you a hopeless smile and nods; you can’t blame her for her lack of enthusiasm after these tough years. \n \nAlthough a simple girl, you can see some potential in her. She could be a fine ally, concubine or maybe even wife, but every relationship has a start. You could flirt with her and see if there is an opening you could use. \n\n";
			option0Name.text = "Flirt with her";
			option1Name.text = "Current affairs";
			confirmationControl = 2;
			GameControl.attAlignment += 2;
			return;
		}

		if (selector == 1 && confirmationControl == 1) {
			Board.text = "When you ask about the current situation of the state, Helena leads you back to the old studio, in one of the towers of the castle. The place has few books left, among other things such as a tattered map of the island, and another map of the city that rests on top of an old table. \n\n<i>\"My Liege, if you don't mind, I think your first priority is to get your home repaired and with enough servants and guards to keep it. If not, most of the city will see you as another one of those drifters that roam the streets.\"</i> You agree, even if that's not the case you don't see the point of being the "+ king +" of some ruins in a derelict city.\n\nHelena walks towards the table, and points at the map <i>\"Here my Liege, the city has not changed much in several years, this map will suffice for your purposes.\"</i> the map of the city is divided into sectors, each one owned or led by a noble house. Although there are several small homes, two big ones stand out. One is House Abbadon, that takes over all the cultural district, while House Furius is in charge of the industrial district. <i>\"As you can see, these two noble houses are de facto the leadership of the city right now. They try to garner as much power as they can, but the crisis in Aurorum had led to stagnation, every house struggling just to not fall apart. With their support, you can build this place again, and have some money to improve the city.\"</i> When you ask if they will support you, she awkwardly pauses, before shaking her head. <i>\"It's unlikely they will support you just because you have a title, you'll have to earn their respect.\"</i> You sigh but nod in agreement, if only it were that easy. \n\n<i>\"Each house has its own traditions and hierarchies you should be aware of. The head of Abbadon House adopts the name of Abbadon as its own and only, and you need to refer to its head as 'him' at all times. Abbadon is still young and not as experienced as the former heads of the house, and I've heard he can be quite challenging to deal with, however, in his current situation he is very vulnerable. With the way things have been going, he doesn't have much to offer in a bargain. House Furius is lead by Alba, a hot headed woman that I'm sure will give you plenty of headaches and stress. As for coming to an understanding with her, she is also a woman of... Needs. That is her primary weakness, but just like Abbadon, her house isn't in the best of circumstances. With plenty of pressure, I guarantee they'll fall in line in time.\"</i>\n\nYou ask her what you need to get everything going. <i>\"The castle and our lack of servants are the major obstacles we need to overcome. I believe I can take care of both of those issues with 3000 gold coins. It's a considerable amount of money I know, but with both housing backing you, you'll have plenty to cover the costs. Either way, at the end of the day, without their support, the other houses will refuse to aid us.\"</i>\n\nYou thank her and tell her that'll be all for now. <i>\"Thank you, my Liege, I  am pleased to be of assistance, if you need anything I'll be available at any time, just call.\"</i>";
			NPCCharList.CharFollower [iHelena].charLoyalty += 10;
			NPCCharList.CharFollower [iHelena].charRelationship += 10;
			NPCCharList.CharFollower [iHelena].attHappiness += 10;
			GameControl.attAlignment += 1;
			endTurnFun ();
			return;
		}



		///////////////////////////// flirt with her / current affairs

		if (selector == 0 && confirmationControl == 2) {
			Board.text = "While Helena is setting up the map with figures shaped as the big houses, you tell her that you are happy to have such a capable and cute girl like her helping you with everything. <i>“Thanks my Liege, it took me years of study and practice to be this good, I’m glad I can be of service.”</i> You smile at her. \n\nNow that you look at her with more detail, you see that her clothes, although of great quality, are really in tattered, and you couldn’t see a single bed in the whole castle, so her living conditions are very poor. You ask how she has managed to get going and if she has any friends or someone else that has helped her. <i>“I do what I can to survive, and at least most of the ceiling holds up enough to protect me from the weather. I don’t really have friends, most of the ones I had either became beasts, crazy, or left the city, and a relationship... I haven’t had a chance to think about that really.”</i>\n\nYou keep talking with her, listening to her story, you use any chance you have to compliment her and cheer her up, telling her everything is going to be fine, and at the end her mood has lighten up, you can see she is more comfortable with your presence, but now is time to go back to business.\n\n";
			Board.text += "When you ask about the current situation of the state, Helena leads you back to the old studio, in one of the towers of the castle. The place has few books left, among other things such as a tattered map of the island, and another map of the city that rests on top of an old table. \n\n<i>\"My Liege, if you don't mind, I think your first priority is to get your home repaired and with enough servants and guards to keep it. If not, most of the city will see you as another one of those drifters that roam the streets.\"</i> You agree, even if that's not the case you don't see the point of being the "+ king +" of some ruins in a derelict city.\n\nHelena walks towards the table, and points at the map <i>\"Here my Liege, the city has not changed much in several years, this map will suffice for your purposes.\"</i> the map of the city is divided into sectors, each one owned or led by a noble house. Although there are several small homes, two big ones stand out. One is House Abbadon, that takes over all the cultural district, while House Furius is in charge of the industrial district. <i>\"As you can see, these two noble houses are de facto the leadership of the city right now. They try to garner as much power as they can, but the crisis in Aurorum had led to stagnation, every house struggling just to not fall apart. With their support, you can build this place again, and have some money to improve the city.\"</i> When you ask if they will support you, she awkwardly pauses, before shaking her head. <i>\"It's unlikely they will support you just because you have a title, you'll have to earn their respect.\"</i> You sigh but nod in agreement, if only it were that easy. \n\n<i>\"Each house has its own traditions and hierarchies you should be aware of. The head of Abbadon House adopts the name of Abbadon as its own and only, and you need to refer to its head as 'him' at all times. Abbadon is still young and not as experienced as the former heads of the house, and I've heard he can be quite challenging to deal with, however, in his current situation he is very vulnerable. With the way things have been going, he doesn't have much to offer in a bargain. House Furius is lead by Alba, a hot headed woman that I'm sure will give you plenty of headaches and stress. As for coming to an understanding with her, she is also a woman of... Needs. That is her primary weakness, but just like Abbadon, her house isn't in the best of circumstances. With plenty of pressure, I guarantee they'll fall in line in time.\"</i>\n\nYou ask her what you need to get everything going. <i>\"The castle and our lack of servants are the major obstacles we need to overcome. I believe I can take care of both of those issues with 3000 gold coins. It's a considerable amount of money I know, but with both housing backing you, you'll have plenty to cover the costs. Either way, at the end of the day, without their support, the other houses will refuse to aid us.\"</i>\n\nYou thank her and tell her that'll be all for now. <i>\"Thank you, my Liege, I  am pleased to be of assistance, if you need anything I'll be available at any time, just call.\"</i>";
			NPCCharList.CharFollower [iHelena].charLove += 5;
			NPCCharList.CharFollower [iHelena].charLoyalty += 20;
			NPCCharList.CharFollower [iHelena].charRelationship += 20;
			NPCCharList.CharFollower [iHelena].attHappiness += 20;
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 2) {
			NPCCharList.CharFollower [iHelena].charLoyalty += 5;
			NPCCharList.CharFollower [iHelena].charRelationship += 5;
			NPCCharList.CharFollower [iHelena].attHappiness += 5;
			confirmationControl = 1;
			confirmFun (1);
			endTurnFun ();
			return;
		}

		///////////////////////////// ask her to knee / current affairs 

		if (selector == 0 && confirmationControl == 100) {
			Board.text = "You command Helena to stand in front of you again, and without hesitation she follows your command. Next, you tell her to kneel down. <i>“My Liege?”</i> You give her a heavy slap and tell her that she needs to do your bidding as soon as you command it. With teary eyes she finally does as you say, and kneels down. You remove your legwear, exposing yourself.\n\n<i>“My Liege, please... I beg you!”</i> Though she hasn’t yet done anything, at this point you know she’ll do what you ask even though she doesn’t wants to, but you want to keep pushing her or just go back to business? \n";
			option0Name.text = "Pardon her";
			option1Name.text = "Keep going";
			confirmationControl = 101;
			return;
		}

		if (selector == 1 && confirmationControl == 100) {
			Board.text = "When you ask about the current situation of the state, Helena walks towards the old table in the middle of the studio. The place has a few books left, amongst other things; such as a tattered map of the island, and another map of the city which rests upon an old table. \n\n<i>\"My Liege, I... The castle should be a priority, to get your home repaired and with enough servants and guards to keep it. Otherwise most of the nobles of the city will refuse to help you.\"</i> You agree, even if that's not the case you don't see the point of being the "+ king +" of some ruin in a derelict city.\n\nHelena points at the map <i>\"The city has not changed much in several years, this map will suffice for your purposes.\"</i> the map of the city is divided into sectors, each one owned or led by a noble house. Although there are several small homes, two large ones stand out. One is House Abbadon, which takes over all of the cultural district, while House Furius is in charge of the industrial district. <i>\"As you can see, these two noble houses are the de facto leadership of the city right now. They try to garner as much power as they can, but the crisis in Aurorum had led to stagnation, and every house is struggling not to fall apart. With their support, you can build this place again, and have some money to improve the city.\"</i> When you ask if they will support you, she awkwardly pauses before shaking her head. <i>\"It's unlikely that they will support you just because of your title. You'll have to earn their respect.\"</i> You sigh but nod in agreement, if only it were that easy. \n\n<i>\"Each house has its own traditions and hierarchies that you should be aware of. The head of Abbadon House adopts the name of Abbadon as his own and only, and therefore you need to refer to the head of the house as 'him' at all times. Abbadon is still young and not as experienced as the former heads of the house, and I've heard he can be quite challenging to deal with. However, in his current situation he is very vulnerable. With the way things have been going, he doesn't have much to offer in a bargain. House Furius is lead by Alba, a hot headed woman that I'm sure will give you plenty of headaches and stress. As for coming to an understanding with her, she is also a woman of... Needs. That is her primary weakness, but just like Abbadon, her house isn't in the greatest of circumstances. With plenty of pressure, I guarantee they'll fall in line eventually.\"</i>\n\nYou ask her what it would take to get everything going again. <i>\"The castle and our lack of servants are the major obstacles we need to overcome. I believe I can take care of both of those issues with 3000 gold coins. It's a considerable amount of money I know, but with both houses backing you, you'll have more than enough to cover the costs. Either way, at the end of the day, without their support, the other houses will refuse to aid us.\"</i>\n\nYou nod and dismiss her. <i>\"Thank you, my Liege, I am pleased to have been of assistance, if you need anything I'll be available at any time, waiting for your call.\"</i>\n";
			NPCCharList.CharFollower [iHelena].charLoyalty -= 5;
			NPCCharList.CharFollower [iHelena].charRelationship -= 5;
			NPCCharList.CharFollower [iHelena].attHappiness -= 10;
			NPCCharList.CharFollower [iHelena].attObedience += 10;
			GameControl.attAlignment -= 2;
			NPCCharList.CharFollower [iHelena].charLove -= 5;
			endTurnFun ();
			return;
		}


		///////////////////////////// Pardon her / keep going

		if (selector == 0 && confirmationControl == 101) {
			Board.text = "You dress yourself again and tell her to stand up, that she has proved enough. <i>“Thanks my Liege, thanks!”</i> she gets on her feet again in matter of seconds.\n\nAlthough the mood is awkward, you can see she is more relieved after you let her go, and proceed to go back to business. \n\n";
			Board.text += "When you ask about the current situation of the state, Helena walks towards the old table in the middle of the studio. The place has few books left, amongst other things; such as a tattered map of the island, and another map of the city which rests upon an old table. \n\n<i>\"My Liege, I... The castle should be a priority, to get your home repaired and with enough servants and guards to keep it. Otherwise most of the nobles of the city will refuse to help you.\"</i> You agree, even if that's not the case you don't see the point of being the "+ king +" of some ruin in a derelict city.\n\nHelena points at the map <i>\"The city has not changed much in several years, this map will suffice for your purposes.\"</i> the map of the city is divided into sectors, each one owned or led by a noble house. Although there are several small homes, two large ones stand out. One is House Abbadon, which takes over all of the cultural district, while House Furius is in charge of the industrial district. <i>\"As you can see, these two noble houses are the de facto leadership of the city right now. They try to garner as much power as they can, but the crisis in Aurorum had led to stagnation, and every house is struggling not to fall apart. With their support, you can build this place again, and have some money to improve the city.\"</i> When you ask if they will support you, she awkwardly pauses before shaking her head. <i>\"It's unlikely that they will support you just because of your title. You'll have to earn their respect.\"</i> You sigh but nod in agreement, if only it were that easy. \n\n<i>\"Each house has its own traditions and hierarchies that you should be aware of. The head of Abbadon House adopts the name of Abbadon as his own and only, and therefore you need to refer to the head of the house as 'him' at all times. Abbadon is still young and not as experienced as the former heads of the house, and I've heard he can be quite challenging to deal with. However, in his current situation he is very vulnerable. With the way things have been going, he doesn't have much to offer in a bargain. House Furius is lead by Alba, a hot headed woman that I'm sure will give you plenty of headaches and stress. As for coming to an understanding with her, she is also a woman of... Needs. That is her primary weakness, but just like Abbadon, her house isn't in the greatest of circumstances. With plenty of pressure, I guarantee they'll fall in line eventually.\"</i>\n\nYou ask her what it would take to get everything going again. <i>\"The castle and our lack of servants are the major obstacles we need to overcome. I believe I can take care of both of those issues with 3000 gold coins. It's a considerable amount of money I know, but with both houses backing you, you'll have more than enough to cover the costs. Either way, at the end of the day, without their support, the other houses will refuse to aid us.\"</i>\n\nYou nod and dismiss her. <i>\"Thank you, my Liege, I am pleased to have been of assistance, if you need anything I'll be available at any time, waiting for your call.\"</i>\n";
			NPCCharList.CharFollower [iHelena].charLoyalty -= 7;
			NPCCharList.CharFollower [iHelena].charRelationship -= 7;
			NPCCharList.CharFollower [iHelena].attHappiness -= 13;
			NPCCharList.CharFollower [iHelena].attObedience += 13;
			GameControl.attAlignment -= 3;
			NPCCharList.CharFollower [iHelena].charLove -= 7;
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 101) {
			Board.text = "You give her permission to stand <i>“Really my liege? Thanks!”</i> Before she finishes her sentence, she is already standing, but you explain to her that you will now have to find someone who is able to complete the job appropriately. \n\n<i>“I... no my liege, I can do this...”</i> She slowly gets back to her knees again, her watery eyes showing defeat. You stand proudly above her, a smirk on your face, and hands on your hips. She remains passive, waiting for you to make the first move, but you hurry her into action. Slowly, her hands approach your crotch. ";
			if (GameControl.dick1Size > 0) {
				Board.text = "\n\nShe timidly removes your legwear, exposing your half erect cock. She turns her head to the side, disgusted by your nakedness, but you hurry her along, threatening to fire her if she doesn’t speed up. It’s enough to get her hands into motion, though her touch is harsh, jerking you without any passion or care.\n\nYou order her to turn her head and look you in the eyes. She hesitates for a moment, wondering if this is even worth it, but to be out with the beasts or living on the streets would be no better. She would end raped there too, and at least here she has food and shelter.\n\nWhen she finally turns around, you can see tears running down her cheeks, and her eyes beg silently for you to stop. Your lust gets the better of you however, and you are unmoved by her pleas. \n\nAlthough she is bad at this, you haven’t had the company of anyone else in a while, and it doesn’t take long for your body to reach its limit. You pull her closer, her face just inches away from your cock, and when your balls are close to bursting you command her to open her mouth. <i>“Mmhh!”</i> She mutters, challenging you, but you pull her hair, the pain causing her to yell at the same moment as you shoot your first load, which hits her full strength on the upper lip and mouth.\n\nShe immediately closes her mouth and eyes while the rest of your load coats her face, hair and neck. When you are finally done, she is completely covered in your seed. The first thing she does when you release her is to spit your cum out.\n\nYou compliment her work, and tell her that she has earned the position, at least for now. You then redress yourself, while she cleans her face on her skirt.\n\nThe two of you rest for a few minutes, before returning to business.";
			} else {
				Board.text = "\n\nShe timidly removes your legwear, exposing your wet cunt. She turns her head to the side, disgusted by your nakedness, but you hurry her along, threatening to fire her if she doesn’t speed up. It’s enough to get her hands into motion, though her touch is harsh, fingering you without any passion or care.\n\nYou order her to turn her head and look you in the eyes. She hesitates for a moment, wondering if this is even worth it, but to be out with the beasts or living on the streets would be no better. She would end raped there too, and at least here she has food and shelter.\n\nWhen she finally turns around, you can see tears running down her cheeks, and her eyes beg silently for you to stop. Your lust gets the better of you however, and you are unmoved by her pleas. \n\nAlthough she is bad at this, you haven’t had the company of anyone else in a while, and it doesn’t take long for your body to reach its limit. You pull her closer, her face just inches away from your pussy, and when are just moments from the edge, you command her to open her mouth. <i>“Mmhh!”</i> she mutters, challenging you, but you pull her hair, the pain causing her to yell. You use the opportunity to pull her over, discharging yourself, with the feel of her warm mouth and desperate breath against your pussy.\n\nShe tries to move away, but just ends up with her face, hair, and neck coated in the rest of your juices. When you finish, she is completely soaked in fluids, and upon releasing her, she immediately spits and coughs, trying desperately to remove your flavour from her mouth.\n\nYou compliment her work, and tell her that she has earned the position, at least for now. You then redress yourself, while she cleans her face on her skirt.\n\nThe two of you rest for a few minutes, before returning to business.  \n";

			}
			Board.text += "When you ask about the current situation of the state, Helena walks towards the old table in the middle of the studio. The place has few books left, amongst other things; such as a tattered map of the island, and another map of the city which rests upon an old table. \n\n<i>\"My Liege, I... The castle should be a priority, to get your home repaired and with enough servants and guards to keep it. Otherwise most of the nobles of the city will refuse to help you.\"</i> You agree, even if that's not the case you don't see the point of being the "+ king +" of some ruin in a derelict city.\n\nHelena points at the map <i>\"The city has not changed much in several years, this map will suffice for your purposes.\"</i> the map of the city is divided into sectors, each one owned or led by a noble house. Although there are several small homes, two large ones stand out. One is House Abbadon, which takes over all of the cultural district, while House Furius is in charge of the industrial district. <i>\"As you can see, these two noble houses are the de facto leadership of the city right now. They try to garner as much power as they can, but the crisis in Aurorum had led to stagnation, and every house is struggling not to fall apart. With their support, you can build this place again, and have some money to improve the city.\"</i> When you ask if they will support you, she awkwardly pauses before shaking her head. <i>\"It's unlikely that they will support you just because of your title. You'll have to earn their respect.\"</i> You sigh but nod in agreement, if only it were that easy. \n\n<i>\"Each house has its own traditions and hierarchies that you should be aware of. The head of Abbadon House adopts the name of Abbadon as his own and only, and therefore you need to refer to the head of the house as 'him' at all times. Abbadon is still young and not as experienced as the former heads of the house, and I've heard he can be quite challenging to deal with. However, in his current situation he is very vulnerable. With the way things have been going, he doesn't have much to offer in a bargain. House Furius is lead by Alba, a hot headed woman that I'm sure will give you plenty of headaches and stress. As for coming to an understanding with her, she is also a woman of... Needs. That is her primary weakness, but just like Abbadon, her house isn't in the greatest of circumstances. With plenty of pressure, I guarantee they'll fall in line eventually.\"</i>\n\nYou ask her what it would take to get everything going again. <i>\"The castle and our lack of servants are the major obstacles we need to overcome. I believe I can take care of both of those issues with 3000 gold coins. It's a considerable amount of money I know, but with both houses backing you, you'll have more than enough to cover the costs. Either way, at the end of the day, without their support, the other houses will refuse to aid us.\"</i>\n\nYou nod and dismiss her. <i>\"Thank you, my Liege, I am pleased to have been of assistance, if you need anything I'll be available at any time, waiting for your call.\"</i>\n";

			NPCCharList.CharFollower [iHelena].charLoyalty -= 15;
			NPCCharList.CharFollower [iHelena].charRelationship -= 15;
			NPCCharList.CharFollower [iHelena].attHappiness -= 20;
			NPCCharList.CharFollower [iHelena].attObedience += 20;
			GameControl.attAlignment -= 4;
			NPCCharList.CharFollower [iHelena].charLove -= 15;
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

	void endTurnFun(){
		endTurnPanel.sortingOrder = 500;
		panConfirmation.sortingOrder = -500; 
	}

	void loadHelenaData(){
		iHelena = 0;
		while (iHelena < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iHelena].charID >= 3000 && NPCCharList.CharFollower [iHelena].charID < 4000){
				WorldControl.NPCID = NPCCharList.CharFollower [iHelena].charID;
				WorldControl.PortraitIDLayer0 = NPCCharList.CharFollower [iHelena].charPortraitLayer0;
				WorldControl.PortraitIDLayer1 = NPCCharList.CharFollower [iHelena].charPortraitLayer1;
				WorldControl.PortraitIDLayer2 = NPCCharList.CharFollower [iHelena].charPortraitLayer2;

				WorldControl.furryPic = NPCCharList.CharFollower [iHelena].isFurry;
				WorldControl.futaPic = NPCCharList.CharFollower [iHelena].isFuta;
				break; 
			}
			iHelena++;
		}
	}


	void Awake (){
		loadHelenaData ();
		introStart ();
		Cheats.cheatItems ();
		//WorldControl.PortraitIDLayer0 = 3000; 
		Quest AbbadonQuest1 = new Quest();
		Quest AlbaQuest1 = new Quest(); 
		QuestsController.createQuest (AbbadonQuest1, "Meeting the elite: Abbadon.", "Following your head maid advice, you decide to meet one of the lords of one of the most important houses in the city, Abbadon's House.", 14, 1000); 
		QuestsController.createQuest (AlbaQuest1, "Meeting the elite: Alba", "You'll have to face one of leaders of one of the most important houses in Aurorum, and get them to support you cause", 59, 13000); 
	}


}
