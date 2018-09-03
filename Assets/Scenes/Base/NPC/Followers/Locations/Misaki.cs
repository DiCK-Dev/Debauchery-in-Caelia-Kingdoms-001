using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Misaki : MonoBehaviour {
	int i = 0; 
	public Text Board; 
	public Canvas endTurnPanel;
	public Canvas mainPanel;
	//public RectTransform panBack;


	public Button buttScene3; 
	public Button buttScene4; 
	public Button buttScene5; 

	public Text scene2title; 
	public Text scene3title; 

	string mcpronoun = ""; 

	static int iMisaki;
	/// <summary>
	/// MISAKI npc 4000
	/// </summary>



	public void startText(){
		if (NPCCharList.CharFollower[iMisaki].corruptionStage > 2) {
			Board.text = "The inn has been recovering quite well since Misaki took the reins of the forgotten building. The tables have been restored and they even placed a pole dancing area in the other side of the room, which has brought more customers to the inn. Some of the clients were pleasuring themselves without remorse as someone was dancing up that platform.\n\n\nAs you approach, you can see Misaki in the counter, attending to the customers as they got into the bar. When she sees you, she grooms herself a bit and blows you a playful kiss as you approached her. -You look so good that I could eat you on the spot. What brought you today to the Inn of the Aurorum? As you see, we have ways to cater to the needs of the customers. So, what can i get to you today?-";
		} else {
			Board.text = "You can see that the inn has been almost restored since Misaki has been working on it. The tables have been restored, as new diners appeared and now populated the place. The bar had several persons drinking happily. You can even see the usual couple in the corner of the room, probably making out.\n\n\nAs you approach, you can see Misaki in the counter, attending to the customers as they got into the bar. When she sees you, she grooms herself a bit and blows you a playful kiss as you approached her. -Aren’t you a cutie? What brought you today? Do you came for business, or do you came to see me?- She says in a teasing tone.";

		}
	}




	public void talkMisakiPast()
	{

		if (NPCControl.npc4000Talk [0, 0] == false) {
			Board.text = "Although the place is full of people, when Misaki notices you she asks to a waitress to take care her place and approaches you. <i>“Hey! Hi! Did you came to see me?”</i> You tell her that yes, you wanted to have some time with her to get to know her. <i>“I love the idea! Let’s go somewhere else… The park maybe? This place is definitely too busy for us right now.”</i> She doesn’t need to insist for you to agree with her idea, and you follow her into a very quiet and lonely spot in the big park. \n\n<i>“Tell me, what you want to know?”</i> She asks, with bedroom eyes, maybe expect for you to ask about her sexual life or a kinky question, but instead you ask her about her past, how was her life before the Plague.\n\nCuriously, even if you expected the question to worsen her mood a little, she seems to be as merry as before. <i>“Oh, that’s a good question… You know, most people almost always ask me about my sex life or things like that. Not that I dislike to talk about that, but you know, this it’s a weird… but refreshing change.”</i> She pauses for a second, trying to remember her past.\n\n<i>“Okay so, my past… I guess I can start with my childhood, my tribe, before the Plague. Actually, our tribe used to be waaaay bigger! At least, four times as big. Everything was easier and better in those times: We shared absolutely everything, and by that I mean literally everything! The food, drinks, tools, clothing, and even wives and husbands!... Those were simpler times too, our hunters brought great banquets, our gatherers returned hands full… But at the end of the day, we all fucked together as one. I doubt there was even a day without an orgy.”</i> She stops, her face is blushed, and the thoughts of those better times seem to be arousing her a bit. <i>“I was among the most popular girls, I remember people had to queue to be with me! Even when I serviced up to five people at the time!”</i> She is clearly proud of herself, her beauty and skill.\n\nThe former village sounds like a small paradise, well, so long you don't mind the dirt, cold, or dying from the mildest infection. Nonetheless, you ask what changed. <i>“Obvious: Then the Disease came. At first our bodies started to adopt these fox characteristics. We didn’t mind at first… The opposite, we thought this was a gift of the gods, that we were blessed, and we immediately embraced this new condition. But then our minds started to change… At first it was so gradual, so slow, that we just realized that there was something wrong until it was too late. We killed or kicked out most of the people, reducing our numbers significantly, and that's when the mood of the village changed:  We stop sharing and being kind to each other, it was now about survival.”</i> For the first time, her mien changes and saddens, at least for a second. You even wonder at this point if she is actually happy all the time, or is just a facade. Well, she looks like she is a deceiver in the end.\n\nYou think it would be foolish to push it more, and you tell her that it was enough for today. She thanks you for listening to her, and asks you to come back soon. <i>“You know, to talk or else…”</i> She runs a hand over her ass, making obvious what she means. ";
			NPCControl.npc4000Talk [0, 0] = true; 
			NPCCharList.CharFollower [iMisaki].charRelationship += 5; 
			NPCCharList.CharFollower [iMisaki].charLoyalty += 5;
				endTurnFun ();
		}  else if (NPCControl.npc4000Talk [0, 1] == false) {
			Board.text = "You reunite with Misaki again in the park, and you need to grant her that she is great at reading people's intentions, because she just goes straight to the point. <i>“So where I was the last time?… Oh yeah, my past and the village after the change... At this point, everyone was on their own, and things for me went from bad to worse. You see, I never got married… Not like that used to matter on our tribe, but women and men became jealous and greedy, and what was I supposed to do? To live in frustration from the lack of sex?”</i> \n\nShe sighs and looks at the vast sky before continuing. <i>“When you get to know me, you will realize that I'm not the kind of girl that just sits there and takes shit from others, so I kept visiting some people… Being fair, some people didn’t mind that I kept going, but the chief’s wife was mad at me because she was forbidden to have sex with others, and kept filling the chief’s head until I was finally kicked out.”</i> \n\nYou try to empathize, but she doesn’t seem to very affected by the situation. <i>“Don't worry about it, is not like I miss the place. You know, it was pretty bad in general, and after years of eating the same dicks and cunts, you get bored… I am glad to be in this city now. It’s definitely bigger.”</i> Well, you are glad to hear that, but you ask why she had to deceive you, that you would had given her a chance even if she said the truth.\n\n<i>“Aww… You are so cute to think that, but if I had learned something is that the truth will only take you so far.... Also, to be honest, I kinda feel a rush as I deceive people, it's a special kind of thrill, to wonder if they will call you out or not… To outsmart them”</i> Seems like that's part of her nature, and you don't think you will be able to change her, she is too stubborn for that. Still, you ask her why the necklace. <i>“Well, it ain't obvious? If that bitch wants to play me, it won't be for free. Look, I’m usually very forgiving, and almost never spiteful, but she really went overboard, don't you agree?”</i> You sigh and shrug in agreement, yeah, kicking her out almost in the middle of nowhere, surrounded by monsters, is almost a death sentence, losing a necklace can’t even start to compare to that. \n\nShe tells you that that's about everything about her past. <i>“Yeah, living in a village is only as exciting as that.”</i> She laughs and stands up, getting ready to leave. <i>“I guess for now this topic is over… But feel free to pay me a visit, I’m looking forward.”</i> She blows you a kiss, before she leaves walking in an alluring way.\n\n";
			NPCControl.npc4000Talk [0, 1] = true; 
			NPCCharList.CharFollower [iMisaki].charRelationship += 5; 
			NPCCharList.CharFollower [iMisaki].charLoyalty += 5;

			NPCCharList.CharFollower [iMisaki].charLove += 10;
			endTurnFun ();
			if (NPCCharList.CharFollower [iMisaki].charLove == 20) {
				
				Board.text += "\n\nAt this point, you have learned a lot about Misaki: What she likes to do, what she dreams about, how she relates to other people, and you have become more acquainted in general.  \n\nYou have several options: You know she is corrupted, but the process is only halfway through. You can, of course, decide to purify her or finish the job of the Plague (implemented soon). She seems to like you, and you can decide to date her, although you doubt she will be faithful to you, it’s not impossible to be in an open relationship with her. \n\nLastly, she seems to enjoy partying too much, and you can either encourage her to indulge in her vices or just try to moderate her more (This will be implemented soon) \n";
			}
		} else {
				Board.text = "Misaki tells you that there is nothing else to know about her past";
				mainPanel.sortingOrder = 500;

		}

	}

	public void talkMisakiHer()
	{


		if (NPCControl.npc4000Talk [1, 0] == false) {

			Board.text = "Today, when you arrive to the inn and tavern you see that the place is kinda empty, only a couple of people drinking beer and the staff. You can see Misaki with a very bored expression, listening to the mumblings of one of the drunkards. When she turns around and sees you, she immediately goes with you, leaving the poor bastard behind in the middle of a sentence.\n\n<i>“Hey! I’m so glad to see you! You don’t know how boring this place can be sometimes… Anyway, let’s take a seat!”</i> She goes to one of the empty tables and asks to the waitress to bring some beer for both of you. <i>“So… What is the reason behind your visit? Do you came to talk or to…”</i> Before she even finishes, you can feel her foot on your crotch, caressing it, but you just move it away. <i>“I see, to talk then.”</i> She rolls her eyes, disappointed but somehow full of resolve. Maybe she is starting to see you as a challenge. \n\nYou tell her that you want to get to know her more, and with a sweet smile she says that of course. Today you just want to know what she likes to do, does she has a hobby or something like that? <i>“You already know what I love to do… Hahaha, I’m joking. I mean, don’t get me wrong, I love to fuck, but I actually do have hobbies. Since I was a kid I always liked to cook, I was the best back in the village. This is why I eagerly accepted to work in this place too, although I don't spend as much time in the kitchen as I would like to.”</i> Well, that’s refreshing to know, but she proceeds before you ask anything else.  <i>“Also, since I have arrived here I enjoy to go through the commercial district and see all of their wares, and if I got some money on me well… Is not like we used to save our money back in my tribe either. But yes, this is fascinating, in my life I barely met any merchant, and this place is full of them!... I think people here doesn’t realize how lucky they are, just look at their faces.”</i> She points at the drunkard, who has a very sad face while talking to a unlucky waitress that has to bear with his presence. \n\nYou turn back at her when she continues. <i>“Oh! Oh! Also! I love this drinks! Beer, wine, whatever that sweet drink that is brewed with eggs is…”</i> Eggnog? You ask. <i>“Yes! There are so many! We had a special drink in my village, it had certain substance that helped you to get out of your body and see the spirits, but it was forbidden for everyone but the chief and his close friends, so I never had the chance to try it… These drinks, getting drunk… Is fun! Really just for these drinks alone is worth to leave that place.”</i> You laugh and celebrate with her, gulping almost half of your drink along with her. You never thought about alcohol that way, you just knew that it has been always there, but a second point of view is refreshing. \n\nYou stay with her, chit chatting for a while and getting drunk, until it becomes late and you need to go. You warn her to don't go overboard with the alcohol, or at least not while she is working <i>“D-don’t worry! *HIC* I-I never do!...”</i> You are not sure of how true that statement is, but whatever, is not like there is that much work right now.";
				NPCControl.npc4000Talk [1, 0] = true; 
				NPCCharList.CharFollower [iMisaki].charRelationship += 5; 
				NPCCharList.CharFollower [iMisaki].charLoyalty += 5;
				endTurnFun ();

		}  else if (NPCControl.npc4000Talk [1, 1] == false) {
			Board.text = "Today you decided to walk with her through the market: She is enjoying herself, excited by all the diverse things and trinkets that you can find in this place, you even buy her some jewelry and clothing in the meantime.\n\n<i>“Thanks a lot for all of this! I never owned so many things… And this place, the smell, its people, its something unique.”</i> Her thoughts amuse you, although not so long ago you also lived in the wild, and you don't really enjoy or love the strong smell of sweat and filthiness of the place. Përhaps your cabin was better than her hut.\n\nBoth of you get tired of walking and carrying bags with all the stuff that you bought, and both of you agree to enter to an establishment, a restaurant, to rest, eat and talk in peace. The thick glass and doors help to diminish the noise, and a musician plays a violin, creating a very comfortable environment. \n\nOnce the food is served: pasta, a salad and white wine, you ask her about what she dreams about, what she expects from the future. <i>“You surely are deep today, huh?”</i> She jokes as she plays a bit with her food. <i>“To be honest, I had never thought about the future that much… It’s not like there was even a future on my own in my former tribe. But now that you ask… I know that I don’t want to settle down, you know? I would like maybe to have a child, or several… Maybe, but I don't like the idea of being only with one person, I tried it a couple of times and... It doesn't work in the end.”</i> You can see her facade cracking, showing a sour face. It seems that she is probably saying the truth about her experience. <i>“But you know what I want now? What’s now my dream? To travel, to know those other cities, to explore new places, new food, new experiences, new lovers… There is an entire world out there, but you don't realize that when you live in a bubble…”</i> She stops talking, lost in her thoughts, but it was too much for her.\n\n<i>“Anyway, that’s enough thinking for a day, don’t you agree? Let’s change topic.”</i> You agree, since you don't want to force her, and both of you continue as her facade returns rather quickly, having a great time for the rest of the day.\n";
			NPCControl.npc4000Talk [1, 1] = true; 
			NPCCharList.CharFollower [iMisaki].charRelationship += 5; 
			NPCCharList.CharFollower [iMisaki].charLoyalty += 5;
			NPCCharList.CharFollower [iMisaki].charLove += 10;
			endTurnFun ();
			if (NPCCharList.CharFollower [iMisaki].charLove == 20) {
				Board.text += "\n\nAt this point, you have learned a lot about Misaki: What she likes to do, what she dreams about, how she relates to other people, and you have become more acquainted in general.  \n\nYou have several options: You know she is corrupted, but the process is only halfway through. You can, of course, decide to purify her or finish the job of the Plague (implemented soon). She seems to like you, and you can decide to date her, although you doubt she will be faithful to you, it’s not impossible to be in an open relationship with her. \n\nLastly, she seems to enjoy partying too much, and you can either encourage her to indulge in her vices or just try to moderate her more (This will be implemented soon) \n";
			}

		} else {
				Board.text = "Misaki tells you that there is nothing new about her to know";
				mainPanel.sortingOrder = 500;
		}

	}



	public void dateMisaki(){


		if (NPCCharList.CharFollower [iMisaki].charLove == 20) {
			Board.text = "Today you decide that you would like to know Misaki a little better. She is usually pretty open, and even when you barely knew her you knew that she is already up for some great sex with you, but there is something on her that attracts you, that allures you to try to get closer to her not just physically, but emotionally.\n\nYou go to the tavern with the intention to ask her out. You know that, although you don't expect to be his exclusive sexual partner, you aim to be the one that really caughts her heart. \n\nOnce at the site, you enter the tavern, and find the place almost empty today. You see find Misaki resting on one of the couches, lost in her thoughts. You knock the door a couple of times, to get her attention, startling her until she notices you. -Hey! What’s up! Sorry, I was dazing out, today the boredom has been agonizing!.- You go to sit with her and ask how she’s been doing. -Pretty well, this place is great, but from time to time we have this awful days that we have not a single soul to serve.- Obviously she ain’t busy, which is perfect for you.\n\nYou ask her if she wants to go out with you, to know the city, doing some tourism. -That sounds way better than this alternative, so sign me in. Just let me close this graveyard and we can go.- \n\nIn no time, you find yourself walking through the city with Mizaki holding your arm: You visit the historic old district, the cultural district, and from the richest to the poorest neighborhoods. Of course, you are not expert on the history of the city, and more than one time both of you get lost in the maze of alleys and streets. But it’s fine, because being accompanied by a woman like Misaki makes it all more interesting. \n\nShe acts quite playful as she gets excited when she learns or sees anything new and interesting, and more than one time she kisses you, either in the cheek or the mouth, always trying to tempt you with her seductive body, but you fight to hold on for now, since being caught with your pants down in a part of the city that you don’t know may be troublesome. \n\nThey day is almost over, and both of you are really tired when you return back to the inn, where you can see people already waiting for her to open the place up. She sighs. -I guess I need to come back to work... but I had a great time with you. Although, you know, next time we should also do…-She is touching your chest, but you can feel how her tail touches your crotch. -Is just an idea, think about it, okay sweetheart? See ya later then.- She leaves you aroused, and you know that she loves that. ";
			endTurnFun (); 
			NPCCharList.CharFollower [iMisaki].charRelationship += 2; 
			NPCCharList.CharFollower [iMisaki].charLoyalty += 2;
			NPCCharList.CharFollower [iMisaki].charLove = 40;

		}else if (NPCCharList.CharFollower [iMisaki].charLove == 40) {
			Board.text = "You know that since Misaki started to work on the inn, she loves to drink, but really all of her supplies are cheap and very low quality, so you decide to invite her to something more special. \n\nShe takes the day off at your command, and she follows you to a warehouse that is a mile away from the city, in one of the oldest vineyards of Aurorum. Once there, you greet the owner that is already expecting you. \n\nAfter talking some details of the arrangement, he gives you his keys and leaves the place to you, letting you both alone in the small house. -I don’t get what is special about this place.. Is an old, rusty house, not better than the Inn I already leave. I know that must have it’s history, but perhaps it’s a bit overrated?- She says, confused about your plans, but you tell her to follow you downstairs, to the basement. The place is dark, and it takes you some minutes to light the oil lamps. Although the house isn't that big, the basement in comparison is enormous, having a wide variety of wines, in bottlers and barrels. You think that maybe she is thinking that you are going there to fuck, but you have other plans.\n\n-Are these… Wine barrels?.-  You smile and nod. -Jeez! There is enough wine in this place for years!- She walks through the place, looking and inspecting everything in sight.-Some of this bottles and barrels seem to be very very old… They must be spoiled by now, what a waste!.- You laugh, and explain to her that wine tastes better, and is more expensive, the older it gets, so long it's well stored.  You also tell her that the wine that she sells is pretty young, and therefore cheap. You walk, looking for something to illustrate your point. Once you find a century old bottle, you blow the dust from it and show it to her. -Uh.. 100 years? That’s several generations! How… How much a bottle of this wine cost?.- You are not sure of the price, since they usually just give you the bottles, or if anything your servitude takes care of it, but it must be at last 600 gold coins. -600… Wait, 600?! That’s an insane fortune! I don't think I will ever have so much money, let alone use it in a drink like this! That much gold are a lot of jewelry...- You turn around, and notice that there are several bottles. She is right, this place is probably worth a small kingdom in itself, well, if they managed to sell everything in here at least.\n\nYou pick the bottle from her hands, and pick a couple of other wines too, although not as old, and both of you go back again to the first floor.  You see that the dinner room has some food served for you two, with cheese, lunch meat, and other appetizers. You invite her to take a seat, and you uncork the first bottle, which is only 5 years old, and serve your cup and hers. \n\nShe takes the cup and almost immediately goes to sniff the wine but you stop her, telling her that she should shake the cup a little before drinking it. -Okay… Let’s see.- She closes her eyes and does what you asked her to do, and she enjoys the sweet smell that has now.  -I never took my time to smell this after shaking, but is kinda good… Can I drink it now, or there is another ritual i don’t know?.- With a hand gesture you tell her to proceed, and she gulps it down. -Oh… It tastes better than expected, well, better than the cheap wine of my inn I guess, but i’m not sure if that is something hard to achieve. It’s less sweet, but it has something interesting in it.- \n\nBoth of you eat some food and taste the two regular bottlers, saving the best one to the end. You ask her if she is ready. -Nice, let’s see if this really tastes much better than the others… It has to, for its price- You take a couple of new cups and pour the wine in it. Both of you smell it, its strong aroma flooding your nostrils. You go first, as if she wants to see your reaction first. It’s very strong flavor is very distinct from the others, without any trace of the fruity flavors.\n\nShe goes after you, keeping the wine in her mouth for a moment, enjoying it, once she is done, she really has an approving expression. -Its really something special… The other wines almost taste like juice in comparison. Yeah, well, not sure if it’s worth a fortune, but at least it is really special.-  \n\nYou stay with her until all of the bottles and food are gone. You fall asleep for who knows how many hours, and when you wake up you find Misaki sleeping at your side. You have a good time to take a good look at her, even though her body is enticing, you think that she looks so beautiful when she is sleeping. You wonder what she thinks of you. Even if your head hurts, you still grab Misaki and take her home, before going back to your castle. \n"; 
			endTurnFun (); 
			NPCCharList.CharFollower [iMisaki].charRelationship += 5; 
			NPCCharList.CharFollower [iMisaki].charLoyalty += 5;
			NPCCharList.CharFollower [iMisaki].charLove = 60;

		}else if (NPCCharList.CharFollower [iMisaki].charLove == 60) {
			Board.text = "During this time, you have got closer to Misaki, to the point that she is looking at you as more than just a friend, that is for sure. You still are not sure how she understand love, but her increasing interest on you is a clear sign that she indeed cares for you in some kind of way. \n\nFor this date, you plan to invite her to your castle for the first time, so you ask to your servants to prepare the castle for her visit. \n\nYou wait for her at the gates, and after a while you can finally see her at the distance, wearing casual clothing and as cheerful as ever. -Wow, this place is bigger than I thought, at the distance it looks so small… Well, it was about time that you invited me here, heh? You surely took your time.- She jokingly pats you on your shoulder.\n\nYou give her a short tour through the place: The throne room, the training grounds, the garden, your studio, but the place that impresses her the most is your kitchen, which is even bigger than the whole tavern, and better equipped. -Do you know how many things I could cook here? Heck, back at the tavern we serve like what, ten different dishes? Here you can probably prepare something different every day of the year. So many flavors...- You smile, because you never thought about that, but she is right. \n\nSince you already showed her the whole place, you ask her what she wants to do. -Uh… You don’t have a plan?... With a place like this, I don’t blame you. There are so many things to do.- Yeah, maybe that looks sloppy, you tell her, but you didn't wanted to force her to do something she may not like. She shakes a hand, dismissing the matter. -It’s fine, you don't have to worry much about that. I mean, is not like it can be worse than back at that village. But if it's up to me, I will not be as indecise as you, since I would really like to idea to get to use your kitchen and cook some ideas I had in mind, but I never had time, or the ingredients, to do so on the Inn. That’s fine by you right?.- You shrug, this ain’t your idea of a romantic date, but you don't really mind. Actually, you kinda like the idea of doing something new. \n\n-I knew i could count with you!.- She grabs your hand and rushes inside. In no time, she has dressed you with an apron and a chef hat. You tell her that you don't really know much about cooking. Although you lived alone for some time, you usually cooked very simple meals. -Dont worry, just follow my directions. You may be " + mcpronoun + " of the city, but here I am the queen.- You let go a playful sigh, and agree to her terms.\n\nYou stay there for hours, almost the whole day, and you almost feel nostalgic: Since you came to the city you haven't worked as hard as this day. Not like that’s bad, if anything, is something humbling. To think that the servants have to do something like this every day. And her happiness and excitement really helps to make things feel better.\n\nWhen the task is finally over, there is almost an entire table prepared: Soups, different roasts, salads, a wide variety of desserts and even a cake. She looks at it, really proud of herself, and she has all the right to feel like that, the food looks really delicious and well done. You have the chance to see the truest part of her. You ask her how she even managed to be this good if she lived in a tribe. -Oh… Maybe I forgot to tell you, but for a while there was a foreign chef living with us. We provided him with resources to trade and he bought supplies with those. I was the one in charge of keeping an eye on him and helping him.... So he did teached me how to do these kind of things. Since I came to this city I had been continuing my training.- \n\nThat’s an interesting story, although you are still surprised by her natural talent. Both of you start to eat and enjoy the food: Yeah, is as good as it looks. If you didn’t needed her at the inn, you would probably move her as the one in charge of your kitchen. \n\nWhen both of you are bloated, you go and take a rest in your studio. -Whoa… We didn’t even finish a quarter of what we prepared. I think you went a bit overboard with the cooking.- You laugh, yeah, your fault. After some time relaxing, without feeling as full, you ask her if she enjoyed the day. -To be honest? It’s been one of the best days I ever had…  Not just a whole day to do one of the things I love, but with so many ingredients and in a place like this… I never even dreamed about something like this, it was an unique experience.- She advances and sits in your lap, giving you a soft kiss. -Thank you for that… Can I ask you something?.- She is blushing, avoiding your gaze a bit. This may be the first time she acts like this since you met her, but you are careful, you know that she is like this when she wants something, you don't want to be deceived again. \n\n-Is just… You know how I truly am, my needs, my hobbies and all of that. I don't really want to change any of that, or not yet, but I really like you… Would it be fine if we are like, something more than sex friends? I know that I’m risking myself once more, but...- You lean forward, giving her a french kiss, something that she answers slowly and with passion. Once you are finished, she looks quite relieved of your answer. - Heh… Guess that means you are not against the idea, even without signing anything. That makes me happy lady.- She is now the one that kisses you, with even more intensity than before, and you spend the rest of the day hanging out with her.\n";
			endTurnFun (); 
			NPCCharList.CharFollower [iMisaki].charRelationship += 5; 
			NPCCharList.CharFollower [iMisaki].charLoyalty += 5;
			NPCCharList.CharFollower [iMisaki].charLove = 80;

		}else if (NPCCharList.CharFollower [iMisaki].charLove == 80) {
			Board.text = "A block away from the old chapel there is the oldest restaurant of the city. Although the place is not the most luxurious one, it is one of the most iconics, and some people would say that it also serves as a museum because the place is decorated with ancient and interesting trinkets. \n\nYou arrange a deal with the owner, to lend you the place exclusively for you and Misaki for a romantic date, and without much room to refusal, he agrees to your terms. \n\nWhen the time comes, you can see Misaki with a more formal, beautiful dress and very cheerful demeanor. -Hi! I am so excited for tonight! You really did got that place only for the both of us? You shouldn’t have!... Not like I’m complaining at all.- She laughs and grabs your arm with both of hers as she forces you to walk with a fast pace towards the location. \n\nOnce you enter, you can see how everything is working as planned: Dim, romantic illumination, a single table for two in the middle, with a beautiful red and gold tablecloth, and a centerpiece with red flowers. The whole place smells with a little hint of roses, but the delicious food that’s being prepared is what really saturates the place, and there is a violinist in a corner, providing music. \n\nYou take her seat out and invite her to take it, and with a small bow to you she thanks your chivalry. The waitress serves wine, and tells you that the food will be ready soon, and you start to talk with her about her day, if she has already adapted to her new lifestyle, among other things. \n\nIn the middle of dinner she changes the topic of the conversation, to a more personal one. -You remember that time when I talked to you about my future? I wasn’t sure about anything at that point, i can remember as if it was yesterday… But now I have changed, but not everything though: I still want to be free, explore the world, met new lovers, try every food: In short, be myself. But now I realize, that I would like to have a partner too, someone to share all my experiences and to rely on. And after meeting you, after everything you have done for me, even though we started with the left foot you treated me nice, so I feel like I owe you. It’s thanks to you that I had the chance to move out, find a good place, a good life…- She pauses, trying to find out how to continue. -I’m sorry, I’m have never been a romantic woman, you know? But what I try to say is that I… I love you, and I would like you to be that partner.- She shrugs and looks at the table, probably scared of your answer.\n\nHer words touch you, specially because you wanted to declare your love for her first. But in a sense, you are glad that she did it first, because she is showing herself vulnerable. You think that it must be hard for her to lower her facade of seduction and calm. You hold her hand and look her in the eyes as you tell her that you love her too, and that of course you want to be his partner, to explore the world together with her. For the first time in the time you got to know her, her face goes soft with teary eyes as a smile hangs on from her lips, but you caress her hand trying to calm her. -I-I’m fine… It's just… I didn’t knew what to expect. Most people... All my life I had to deal with people that just wanted to be with me for one thing only. And after so many years, I learned to survive with them, but never felt like someone truly cared for me... until now…- You stand up and walk to her side and leaned to give her a kiss, a very soft, romantic kiss that's full of love instead of lust. When the kiss is over, you are caressing her cheek, and she just closes her eyes, accepting your affection. \n\nWhen you take your seat again, the mood improves significantly, and her whole attitude changes: You feel like she is finally being completely honest with you and with herself, for the first time in years, showing her true face and feelings. Both of you enjoy the rest of the dinner with hopes renewed, and when it’s over, she accompanies you back to your castle, where both of you act with passion until the dawn. \n\n";
			endTurnFun (); 
			NPCCharList.CharFollower [iMisaki].charRelationship += 5; 
			NPCCharList.CharFollower [iMisaki].charLoyalty += 5;
			NPCCharList.CharFollower [iMisaki].charLove = 100;
			NPCCharList.CharFollower [iMisaki].isLover = true; 

		}else if (NPCCharList.CharFollower [iMisaki].charLove == 100) {
			Board.text = "Both of you are already in love, no more dates available.";

		}else if (NPCCharList.CharFollower [iMisaki].charLove < 20){
			 
			Board.text = "You need to improve your relationship with her before dating, try talking with her.";
		}
		
	}


	public void Purify(){
		Board.text = "Comming soon"; 
	}

	public void Corruption(){
		Board.text = "Comming soon"; 

	}






	/// <summary>
	/// SCENES
	/// </summary>
	public void sexScene1(){


		if (GameControl.mcGender == GameControl.MCGender.FEMALE) 
		{
			mcpronoun = "she"; 
		} 
		else 
		{
			mcpronoun = "he"; 
		}

		GameControl.actualArousal = 0; 
		endTurnFun ();

		if (NPCCharList.CharFollower [iMisaki].slaveStage > 0)
		{
			// dick
			if (GameControl.mcSex == GameControl.MCSex.Man ) {
				Board.text = "."; 

			} else if ( GameControl.mcSex == GameControl.MCSex.Woman || GameControl.mcSex == GameControl.MCSex.Cuntboy) {
				Board.text = "."; 

			} else {
				Board.text = "."; 
			}

		} else {

			// dick
			Board.text = "You invite Misaki to go out and have dinner with you somewhere else, something that she eagerly accepts. <i>“Sure! Just let me talk to the waitress and tell her that she is in charge while I'm gone.”</i> It doesn't take long until she is back. She asks if you have any plan on mind, but you explain to her that you are improvising. <i>“Uh so you don't have a plan? Good to me, actually. There is a place that I’ve been dying to visit for a while, it's a very small place. Actually, I think they only have one table, but every time I pass in front of it the smell of food is great, are you up for it?”</i> Sure, you nod, it doesn't sounds like a bad idea.\n\nWhen you finally reach the place and enter, you realize that she wasn’t lying, it really has only one table for two, but at least that means both of you will have some privacy. Once both of you take a seat, someone comes to attends both of you, a very strong and tall bull-man that is apparently also the owner of the place. He doesn’t even gives you a menu, telling you that he only prepares a dish for the day, but ask which kind of wine or drink you will have. You notice that Misaki has her eyes fixed at his bulge, licking her lips and ignoring the man until he has to ask twice about which drinks both of you will have.  After you ask him for wine, he goes back to the kitchen again, and Misaki is now looking at his ass until he leaves.\n\nYou ask her if this is why she picked the place. <i>“Oww… Of course not!, well, I mean, the food smells good, right? The fact that once I saw him taking the trash is just a plus.”</i> You jokingly rolls your eyes, but you are not surprised at all about her behavior. \n\nWhile you are waiting for the food and talking about nothing relevant, you can feel her feet on you. First, on your legs, but she keeps climbing and climbing until she finally reaches your crotch. ";
			if (GameControl.dick1Size > 0 ) {
				Board.text += "\n\nShe starts caressing you over the clothing, giving you a lustful look even if she is talking as if nothing is going on. You are getting hard, and with expert skill she manages to open its way for your cock to be free. \n\nShe plays with you, her soft feet caressing your whole length. She moves slowly, which helps you to control yourself and avoid to moan, but after a couple of minutes you feel the soft fur of her tail on the head of your cock. \n\nWhen you start to really enjoy her footjob, the owner comes back with your food. He is careless and doesn’t notice what’s going on at first, but Misaki stops him and starts to ask him random questions.\n\nThis goes on for a while, until the point that he is already suspecting something. This is when Misaki does her move. <i>“...Sir, I’ve been told that you have one of the tastiest creams in the whole city… Maybe I could try that out?”</i> He initially refuses, being too obtuse to believe that she actually meant a real soup, but when she puts her hands on her crotch, it becomes obvious. He looks at you for a second, and then ask you don't mind. <i>“Oh dont worry, " +  mcpronoun + " knows about my appetite… And " +  mcpronoun + " is already enjoying it, right?”</i> She augments the rhythm, forcing you to produce a moan. \n\nHe shrugs, and without any shame removes his pants, taking out an enormous cock that is half erect. Misaki gets her face close and gives it a whiff. <i>“Such a strong smell… Love it!”</i> She engulfs the entirety of the cock in a single trust, showing to both of you how she lacks a gag reflex. \n\nShe leans back and relaxes, spreading her legs wide open and touching herself. The sound of sex surrounds the whole place, and when you want to stand up, she stops you with her feet. She murmurs something, but with her mouth full of cock is hard to understand. When she takes it out, she just tells you. <i>“Stay there, we are all enjoying ourselves, let’s keep it simple.”</i> And if she was going to say something else, you will never know, because the bull takes her head and pushes his cock through her mouth again. \n\nThe three of you continue for a while, until the bull says that he is close. She pauses and asks if you are almost there too, to what you nod. <i>“Great, me too, let's go the three of us at the same time!”</i> She jumps back at her task of blowing him, and her feet increases its intensity\n\nThe first to cum is the bull, which makes Misaki to open her eyes by the amount of cum that he is forcing through her throat, you then feel her tail around your cock, and you start to cum on her soft fur. Both of you are still unloading on her when she starts to spam and yell, indicating her own orgasm.\n\nWhen the three of you are spent, Misaki is a mess, her face dripping with cum, her eyes rolled back. When she recovers, she licks her lips. <i>“Ah...It’s a really good cream.”</i> but then she moves her tail to her face, and licks the jizz in her fur. She closes her eyes, and savors the substance. <i>“This ain’t that bad either.”</i>\n\nWhen both of you are done, you decide to leave the place. The owner is still tired and resting in the floor when you go, but he doesn’t say a word about paying. ";

			} else if ( GameControl.hasVagina == true ) {
				Board.text += "\n\nShe starts caressing you over the cloth, giving you a lustful look even if she is talking as if nothing is going on. You are getting wet, and with expert skill she haves, it manages to open its way for your pussy to be free. \n\nShe plays with you, her soft feet caressing your clit. She moves slowly, which helps you to control yourself and avoid to moan, but after a couple of minutes you feel the soft fur of her tail rubbing against your cunt too. \n\nWhen you start to really enjoy her footjob, the owner comes back with your food. He is careless and doesn’t notice what’s going on at first, but Misaki stops him and starts to ask him random questions.\n\nThis goes on for a while, until the point that he is already suspecting something. This is when Misaki does her move. <i>“...Sir, I’ve been told that you have one of the tastiest creams in the whole city… Maybe I could try that out?”</i> He initially refuses, being too obtuse to believe that she actually meant a real soup, but when she puts her hands on her crotch, it becomes obvious. He looks at you for a second, and then ask you don't mind. <i>“Oh dont worry, " +  mcpronoun + " knows about my appetite… And " +  mcpronoun + " is already enjoying it, right?”</i> She augments the rhythm, forcing you to produce a moan. \n\nHe shrugs, and without any shame removes his pants, taking out an enormous cock that is half erect. Misaki gets her face close and gives it a whiff. <i>“Such a strong smell… Love it!”</i> She engulfs the entirety of the cock in a single trust, showing to both of you how she lacks a gag reflex. \n\nShe leans back and relaxes, spreading her legs wide open and touching herself. The sound of sex surrounds the whole place, and when you want to stand up, she stops you with her feet. She murmurs something, but with her mouth full of cock is hard to understand. When she takes it out, she just tells you. <i>“Stay there, we are all enjoying ourselves, let’s keep it simple.”</i> And if she was going to say something else, you will never know, because the bull takes her head and pushes his cock through her mouth again. \n\nThe three of you continue for a while, until the bull says that he is close. She pauses and asks if you are almost there too, to what you nod. <i>“Great, me too, let's go the three of us at the same time!”</i> She jumps back at her task of blowing him, and her feet increase their intensity\n\nThe first to cum is the bull, which makes Misaki to open her eyes by the amount of cum that he is forcing through her throat, you then feel her tail moving faster, and you start to cum on her soft fur. Both of you are still unloading on her when she starts to spam and yell, indicating her own orgasm.\n\nWhen the three of you are spent, Misaki is a mess, her face dripping with cum, her eyes rolled back. When she recovers, she licks her lips. <i>“Ah...It’s a really good cream.”</i> but then she moves her tail to her face, and licks the squirt in her fur. She closes her eyes, and savors the substance. <i>“This ain’t that bad either.”</i>\n\nWhen both of you are done, you decide to leave the place. The owner is still tired and resting in the floor when you go, but he doesn’t say a word about paying. \n";
				//Board.text = "You invite Misaki to go out and have dinner with you somewhere else, something that she eagerly accepts. -Sure! Just let me talk to the waitress and tell her that she is in charge while I'm gone.- It doesn't take long until she is back. She asks if you have any plan on mind, but you explain to her that you are improvising. -Uh so you don't have a plan? Good to me, actually. There is a place that I’ve been dying to visit for a while, it's a very small place. Actually, I think they only have one table, but everytime I pass in front of it the smell of food is great, are you up for it?.- Sure, you nod, it doesn't sounds like a bad idea.\n\nWhen you finally reach the place and enter, you realize that she wasn’t lying, it really has only one table for two, but at least that means both of you will have some privacy. Once both of you take a seat, someone comes to attends both of you, a very strong and tall bull-man that is apparently also the owner of the place. He doesn’t even gives you a menu, telling you that he only prepares a dish for the day, but ask which kind of wine or drink you will have. You notice that Misaki has her eyes fixed at his bulge, licking her lips and ignoring the man until he has to ask twice about which drinks both of you will have.  After you ask him for wine, he goes back to the kitchen again, and Misaki is now looking at his ass until he leaves.\n\nYou ask her if this is why she picked the place. -Oww… Of course not!, well, I mean, the food smells good, right? The fact that once I saw him taking the trash is just a plus.- You jokingly rolls your eyes, but you are not surprised at all about her behavior. \n\nWhile you are waiting for the food and talking about nothing relevant, you can feel her feets on you. First, on your legs, but she keeps climbing and climbing until she finally reaches your crotch. \n\n";
				//Board.text = Board.text + "She starts caressing you over the cloth, giving you a lustful look even if she is talking as if nothing is going on. You are getting wet, and with expert skill she haves, it manages to open its way for your pussy to be free. \n\nShe plays with you, her soft feet caressing your clit. She moves slowly, which helps you to control yourself and avoid to moan, but after a couple of minutes you feel the soft fur of her tail rubbing against your cunt too. \n\nWhen you start to really enjoy her footjob, the owner comes back with your food. He is careless and doesn’t notice what’s going on at first, but Misaki stops him and starts to ask him random questions.\n\nThis goes on for a while, until the point that he is already suspecting something. This is when Misaki does her move. -...Sir, I’ve been told that you have one of the tastiest creams in the whole city… Maybe I could try that out?.- He initially refuses, being too obtuse to believe that she actually meant a real soup, but when she puts her hands on her crotch, it becomes obvious. He looks at you for a second, and then ask you don't mind. -Oh dont worry, " + mcpronoun + " knows about my appetite… And " + mcpronoun + " is already enjoying it, right?.- She augments the rhythm, forcing you to produce a moan. \n\nHe shrugs, and without any shame removes his pants, taking out an enormous cock that is half erect. Misaki gets her face close and gives it a whiff.- Such a strong smell… Love it!.- She engulfs the entirety of the cock in a single trust, showing to both of you how she lacks a gag reflex. \n\nShe leans back and relaxes, spreading her legs wide open and touching herself. The sound of sex surrounds the whole place, and when you want to stand up, she stops you with her feet. She murmurs something, but with her mouth full of cock is hard to understand. When she takes it out, she just tells you. -Stay there, we are all enjoying ourselves, let’s keep it simple.- And if she was going to say something else, you will never know, because the bull takes her head and pushes his cock through her mouth again. \n\nThe three of you continue for a while, until the bull says that he is close. She pauses and asks if you are almost there too, to what you nod. -Great, me too, let's go the three of us at the same time!.- She jumps back at her task of blowing him, and her feet increase their intensity\n\nThe first to cum is the bull, which makes Misaki to open her eyes by the amount of cum that he is forcing through her throat, you then feel her tail moving faster, and you start to cum on her soft fur. Both of you are still unloading on her when she starts to spam and yell, indicating her own orgasm.\n\nWhen the three of you are spent, Misaki is a mess, her face dripping with cum, her eyes rolled back. When she recovers, she licks her lips.-Ah...It’s a really good cream.- but then she moves her tail to her face, and licks the squirt in her fur. She closes her eyes, and savors the substance. -This ain’t that bad either.-\n\nWhen both of you are done, you decide to leave the place. The owner is still tired and resting in the floor when you go, but he doesn’t say a word about paying.";
			} else {
				Board.text += "No scene for asexuals yet, sorry."; 
			}


		}

	}


	public void sexScene2(){



		if (GameControl.mcGender == GameControl.MCGender.FEMALE) 
		{
			mcpronoun = "she"; 
		} 
		else 
		{
			mcpronoun = "he"; 
		}

		GameControl.actualArousal = 0; 

		endTurnFun ();


		if (NPCCharList.CharFollower [iMisaki].slaveStage > 1)
		{

			// dick
			if (GameControl.mcSex == GameControl.MCSex.Man  ) {
				Board.text = "."; 

			} else if ( GameControl.mcSex == GameControl.MCSex.Woman || GameControl.mcSex == GameControl.MCSex.Cuntboy) {
				Board.text = "."; 

			} else {
				Board.text = "."; 
			}

		}
		else 
		{


			// dick
			Board.text = "You pay a visit to Misaki, but when you get into the tavern, the place is almost empty, and you can see that the staff is taking care of the tavern while Misaki slacks off in a couch, talking with a friend of hers, a very voluptuous wolf girl with red hair and blue, beautiful eyes, dressed with a very short skirt and a very tight top that is sitting in front of her.  \n\nWhen she sees you she waves her hand and asks you to join them, and although this wasn't part of your plan, you go and sit at her side, and the three of you chit chat for a while, until the friend stands up to go to the bathroom. \n\nYou tell her that you actually came to see her in a more exclusive sense of a visit, and she laughs. <i>“Come on, why you didn’t said that from the start? It’s not like I would refuse to play with you…”</i> She looks at the sides, beyond the staff, there are at most 2 or 3 drunks. <i>“Well, you sit there, and enjoy.”</i> You try to stop her, telling her that you didn't meant this, well, not like this, but she moves fast under the table. \n\n";
			if (GameControl.dick1Size > 0 ) {
				Board.text += "She spreads your legs with her arms, and you can feel how she buries her face in your crotch, even if you are still wearing clothes. <i>“Let me start…”</i> She uses her mouth to undress you enough to get your cock out. Although at first you are enjoying the idea, you then remember that her friend will come back. <i>“Hey, if I’m not worrying about her, why are you?”</i> You want to discuss the situation further, but the sudden feeling of her warm mouth on the head of your dick makes you forget about it.\n\nThe warmth and wetness of her mouth is incredible and it doesn’t take long to get you erect. You slide your hand down and take the back of her head, setting the pace. You try to relax and enjoy the situation, and you see how the staff looks the scene. You are not sure, since they are behind the bar, but you can swear that they are moving back and forth… They are probably enjoying themselves as much as their boss. \n\nYou feel close to your climax when you hear the door of the bathroom open. Misaki stops blowing you, and you suddenly feel preoccupied. When the friend comes, is not hard for her to guess what is going on behind the table. <i>“Oh my, why you didn’t waited for me? I thought we were friends!”</i> Her friend burst into laughter at her own joke, and walks forward to you, sitting at your side and giving you a deep kiss.\n\n<i>“Don't worry, we all can have a good time, that’s right Misaki?”</i> She just nods, and her friend spreads her legs. You realize that she is not wearing anything under the skirt, and she gives you a smile. <i>“What you expect? I’m friends with this whore...”</i> She starts to masturbate herself, while Misaki turns between eating her and blowing you. \n\nHer friend gets turned on very fast, and in no time she has her first orgasm, while you still hold on for a while. When you are ready, Misaki grabs your dick, stopping you from cumming. <i>“Wait, let me give you a special treatment…”</i> She frees her ample breasts and spit on them. She positions your dick in the middle of them, using her hands to press your dick. The soft feeling is great, and she starts to pump you out faster and faster between them. When you tell her that you are really about to cum now, she puts her face in front of it, receiving all of your loads and bathing her face and big tits in your cum.\n\n<i>“Phew… That was great!”</i> She says while coming out from under the table, and sits in the couch, at the side of her friend. <i>“That looks good, let me take a taste of it.”</i> Says her friend, who immediately leans forward Misaki and starts to clean her face with her tongue, sharing your jizz in a wet kiss.\n\nYou stay with them for a while, enjoying the company, until its time for you to come back to your castle. \n";

			} else if ( GameControl.hasVagina == true) {
				Board.text += "She spreads your legs with her arms, and you can feel how she buries her face in your crotch, even if you are still wearing clothes. <i>“Let me start…”</i> She undress you enough to get to your pussy. Although at first you are enjoying the idea, you then remember that her friend will come back. <i>“Hey, if I’m not worrying about her, why are you?”</i> You want to discuss the situation further, but the sudden feeling of her warm tongue playing with your clit makes you forget about it.\n\nThe sensation of her mouth is incredible, and it doesn’t take long to get you as aroused as you can get. You slide your hand down and take the back of her head, setting the pace. You try to relax and enjoy the situation, and you see how the staff looks the scene. You are not sure, since they are behind the bar, but you can swear that they are moving back and forth… They are probably enjoying themselves as much as their boss. \n\nYou feel close to your climax when you hear the door of the bathroom open. Misaki stops eating you, and you suddenly feel preoccupied. When the friend comes, is not hard for her to guess what is going on. <i>“Oh my, why you didn’t waited for me? I thought we were friends!”</i> Her friend burst into laughter at her own joke, and walks forward to you, sitting at your side and giving you a deep kiss.\n\n<i>“Dont worry, we all can have a good time, that’s right Misaki?”</i> She just nods, and her friend spreads her legs. You realize that she is not wearing anything under the skirt, and she gives you a smile. <i>“What you expect? I’m friends with this whore...”</i> She starts to masturbate herself, while Misaki turns between eating her and you. \n\nHer friend gets turned on very fast, and in no time she has her first orgasm, while you still hold on for a while. When you are ready, Misaki pinches your clit, the pain stopping you from cumming. <i>“Wait, let me give you a special treatment…”</i> She frees her breasts and spit on them. She positions your dick in the middle of them, using her hands to press your dick. The soft feeling is great, and she starts to pump you out faster and faster. When you tell her that you are really about to cum now, she puts her face in front of it, receiving all of your loads and bathing in your cum.\n\n<i>“Phew… That was great!”</i> She says while coming out from under the table, and sits in the couch, at the side of her friend. <i>“That looks good, let me take a taste of it.”</i> Says her friend, who immediately leans forward Misaki and starts to clean her face with her tongue, sharing your jizz in a deep kiss.\n\nYou stay with them for a while, enjoying the company, until it’s time for you to come back to your castle. \n";

			} else {
				Board.text = "No scene for asexuals yet, sorry."; 
			}



		}

	}




	public void sexScene3(){



		GameControl.actualArousal = 0; 

		endTurnFun ();


		if (NPCCharList.CharFollower [iMisaki].slaveStage > 2)
		{
			if (GameControl.mcSex == GameControl.MCSex.Man  ) {


			} else if ( GameControl.mcSex == GameControl.MCSex.Woman || GameControl.mcSex == GameControl.MCSex.Cuntboy) {



			} else {
				Board.text = "No scene for asexuals yet, sorry."; 
			}




		} else {
			// dick

			Board.text = "Misaki asked you to join her on her shopping spree today, visiting boutiques and other fashionable stores around the city. Although she doesn't buy everything, she really loves to try out almost every dress available. She is not the only one tho, since she also gets you involved and forces you to try out clothing that she thinks will work on you. \n\nFinally, after several hours of trying clothing, she decides to take a break in one of the smallest and remote boutiques of the city. <i>“Great day, don't ya think?”</i> You agree with her, even if you are somewhat tired from all that walking. <i>“You know what we need?...”</i> She turns and looks at the sides, to see of the owner or anyone else is looking at you, but apparently is not the case. <i>“I think I need to try one dress more but… Be a sweetheart and help me out with this one, okay?”</i> She stands up, and both of you sneak into a dressing room. \n\n";
			if (GameControl.dick1Size > 0 && GameControl.charArmorTags[1] == false && GameControl.charArmorTags[2] == false) {
				Board.text += "In matter of seconds she takes her dress out and gets nude. You are not surprised that she is wearing nothing underneath her clothing. She kisses you and touches your crotch, until she feels that it's growing in her hand. <i>“Okay, I think it's time to free you down there… We run out of time”</i> She takes your cock out, and jerks you off while she kisses your neck. \n\nWhen you mast is fully erect, she turns around and puts her hands on the wall, slightly bending over. <i>“Come on… Just come in, no need to knock. I’ve been waiting you.”</i> You move and position yourself in her back, grab her hips, and thrust forward. Her cunt is already wet, and you can see on her face how she is trying her best not to moan. You slowly thrust inside her, and once you are in deep, you fuck her with a slow pacing.\n\nYou can see her biting her lips of pleasure, and her tail moving of excitement, slapping you in the face and annoying you. You keep going, but she gets tired of the slow rhythm. <i>“If you want to really please me, you will have to go harder than that…”</i> Okay, if that’s what she wants. You start to go faster and faster, until she starts to moan loudly, not caring anymore about the people that is in the store.\n\n<i>“Yes, yes! I needed this Ah!... Keep going, champion! Faster!”</i> You give her what she asks for, and after some minutes of intense fucking, you finally are on the edge. <i>“Oh shit, yes! Cum inside! Give it to me!”</i> She clenches her cunt, and you cannot resist anymore, filling her pussy with your hot jizz. She comes with you at the same time, and at the end of their lovemaking, there is a small pool of both of your fluids at the bottom. \n\nShe turns around and whispers you. <i>“I think we went a little bit overboard… Anyway, let's dress up and escape!”</i> She doesn't has to say that twice, once both of you are dressed you get the hell of out the place, without even looking back to the other people that were around them. She laughs while panting for air, once you are far from reach. <i>“That was great, hahaha… Let’s do it again next time!”</i> You answer to her with a kiss, yeah, that sounds like a good plan.";

				charVirginity();
			} else if ( GameControl.hasVagina == true) {
				Board.text += "In matter of seconds she takes her dress out and gets nude, but she takes her handbag and takes something out, a strap! She kisses you and touches your crotch, until she feels that you are wet.  <i>“Okay, I think it's time to free you down there, so we can get you ready…”</i> She removes your legwear, and fingers you while she kisses your neck. \n\nWhen you become dripping wet, she hands you the strap, turns around and puts her hands on the wall, slightly bending over. <i>“Come on… Just come in, you don’t need to knock. I’ve been waiting for you.”</i> You move and position yourself in her back, grab her hips, and thrust forward. Her cunt is already wet, and you can see on her face how she is trying her best not to moan. You slowly thrust inside her, and once you are in deep, you fuck her with a slow pacing.\n\nYou can see her biting her lips of pleasure, and her tail moves of excitement, slapping you in the face and annoying you. You keep going, but she gets tired of the slow rhythm. <i>“If you want to really please me, you will have to go harder than that…”</i> Okay, if that’s what she wants… You start to go faster and faster, until she starts to loudly moan, not caring anymore about the people that is in the store.\n\n<i>“Yes, yes! I needed this. Ah!... Keep going, champion! Faster!”</i> You give her what she asks for, and after some minutes of intense fucking, you finally are on the edge. <i>“Oh shit, yes! Lets cum together! Ahh!”</i> She clenches her cunt and starts to move her hips, and you cannot resist anymore, and you start to climax. She comes with you at the same time, and at the end there is a small pool of both of your fluids at the bottom. \n\nShe turns around and whispers you. <i>“I think we went a little bit overboard… Anyway, let's dress up and escape!”</i> She doesn't has to say that twice, once both of you are dressed you get the hell of out the place, without even looking back to the other people that were around them. She laughs while panting for air, once you are far from reach. <i>“That was great, hahaha… Let’s do it again next time!”</i> You answer to her with a kiss, yeah, that sounds like a good plan.";

			} else {
				Board.text = "No scene for eunuch or this armor yet, sorry!"; 
			}

		}



	}






	public void sexScene4(){


		GameControl.actualArousal = 0; 

		endTurnFun ();


		if (NPCCharList.CharFollower [iMisaki].slaveStage > 3)
		{

			// dick
			if (GameControl.dick1Size > 0 && GameControl.charArmorTags [1] == false && GameControl.charArmorTags [2] == false) {
				charVirginity();

			} else if (GameControl.hasVagina == true) {

			} else {
				Board.text = "No scene for asexuals or eunuch characters yet, sorry."; 

			}
				

		} else {
			// dick
			if  (GameControl.dick1Size > 0 && GameControl.charArmorTags[1] == false && GameControl.charArmorTags[2] == false) {
				Board.text = "You are bored in the throne room, dealing with issues related to the city, when a servant informs you about some visitors. Visitors? You ask, wondering who could be, but it doesn't take long until you see Misaki and a friend of her, a red haired, blue eyes, voluptuous wolf-girl friend, that’s wearing skimpy clothing. \n\nBoth of them wave at you <i>“Heeey! We were back at the tavern, but the place was almost dead and, you know, we said why we don’t go with our favorite "  +  mcpronoun + "and have some fun? And so, here we are.”</i> You laugh at her meddling, you even ask them if they even know other "  +  mcpronoun + ". <i>“Well, that’s why you can be sure that you are our favorite! Anyway, are you up for some fun? We brought some wine!”</i> Is not like you don't have an entire cellar with wine, but is the intention what matters. You look at them and nod, as taking a break sounds good at the moment so you tell them to follow you to the dining room. <i>“Well… That sounds fine by me, but my friend here doesn’t really know the place… Would you mind giving her a tour? Maybe show her your bedroom?”</i> She gives you a knowing smile. Well, they surely know what they want. \n\nFine, you ask them to follow you upstairs to your room. Once there, your two lady friends take a seat in a couch, leaving an empty space in the middle for you, while you bring cups for everyone. Misaki uncorks the wine and serve each cup to the brim, finishing the entire bottle. <i>“Lets toast! For a great banging!”</i> The three of you celebrate and finish the wine in a single gulp.\n\n<i>“What you think, should we start Misaki?”</i> Asks the wolf girl with a mischievous smile, and Misaki without even answering turns your head to her and kisses you, while you feel her friend hand removing your legwear, freeing your cock. <i>“Mmm… Let's see if the wine improve its taste.”</i> She goes down, engulfing your still limp cock, while you kiss passionately with Misaki. \n\nYou massage the now-free breasts of Misaki, her massive plush orbs resting over your hands while she spreads her legs, revealing her pussy. <i>“I think you should use your hand down there…”</i> She doesn’t need to ask twice before you start to finger her pussy, while Misaki moves her hand to the back of the head of her friend, and starts to push her down over and over, until she is already deepthroating you. \n\nIt doesn't take long until Misaki requires more than a helping hand. <i>“Sweetheart, I think is my turn, so move this amateur because I am going to give you the ride of your life.”</i> Her friend tries to protest, but you can’t understand anything, and with a push from her feet Misaki moves her away. <i>“Here I go, i hope you’re already warm-up, because I won’t go easy on you!”</i> She isn’t lying, she jumps and pretty much impales herself on your dick. Her friend, on the other hand, gets back and together have a three way kiss. The sight of Misaki and her friend drinking your saliva is glorious, and you are glad that you didn't turned off the offer to have fun together. \n\nMisaki keeps riding you hard, but this ain’t enough, and she turns to her friend. <i>“Hey I brought you here, so at the very least you should show me some respect!”</i> Her friend smiles. <i>“With pleasure…”</i> She kneels on the ground, and while you fuck Misaki’s pussy, she eats her ass, although she uses any chance she has to give a good lick to your rod too.\n\nThis can go only for so long until your first climax is close, and when you inform them of this, Misaki joins to her friend on the ground, waiting for you to bathe them in your cum. \n\nYou explode on their faces, staining her fur, hair, face and body. They clean each other, and share your cum in a single, wet kiss, doing a show for you.\n\nAlthough at first you take a rest, once you recover you keep fucking them until you are spent. It was a great day, that’s for sure. ";
				charVirginity();
			} else if ( GameControl.hasVagina == true ) {
				Board.text = "You are bored in the throne room, dealing with issues related to the city, when a servant informs you about some visitors. Visitors? You ask, wondering who could be, but it doesn't take long until you see Misaki and a friend of her, a red haired, green eyes, strong equine-man, that’s wearing just pants. \n\nBoth of them wave at you <i>“Heeey! We were back at the tavern, but the place was almost dead and, you know, we said why we don’t go with our favorite "  +  mcpronoun + "and have some fun? And so, here we are.”</i> You laugh at her meddling, you even ask them if they even know other "  +  mcpronoun + ". <i>“Well, that’s why you can be sure that you are our favorite! Anyway, are you up for some fun? We brought some wine!”</i> Is not like you don't have an entire cellar with wine, but is the intention what matters. You look at them and nod, as taking a break sounds good at the moment so you tell them to follow you to the dining room. <i>“Well… That sounds fine by me, but my friend here doesn’t really know the place… Would you mind giving her a tour? Maybe show him your bedroom?”</i> She gives you a knowing smile. Well, they surely know what they want. \n\nFine, you ask them to follow you upstairs, to your room. Once there your two friends take a seat in a couch, leaving an empty space in the side for you, while the stud sits on the middle, while you bring cups for everyone. Misaki uncorks the wine and serve each cup to the brim, finishing the entire bottle. <i>“Lets toast! For a great banging!”</i> The three of you celebrate and finish the wine in a single gulp.\n\n<i>“What you think, should we start Misaki?”</i> asks the equine with a mischievous smile, and Misaki without even answering starts to kiss him, while you feel her friend hand removing your legwear, freeing your pussy. He takes his cock out and looks at you <i>“Mmm… Wanna see if the wine improves the taste?”</i> And without waiting for your answer he grabs the back of your head and pushes you down, forcing his dick through you mouth and throat. You suck him until he becomes very hard, and Misaki pulls you and scolds him.\n\n<i>“Hey, you are not the only one who should have fun… Come on sweetheart, why don’t you go first and ride this big cock? I know you’ll love it, i brought it for you.”</i>  She doesn’t need to ask twice before you move and sit on it, slowly moving down and enjoying every inch of cock inside you, while Misaki moves and starts a three way kiss. \n\nMisaki let’s you get fucked while her friend fingers her, although he has other plans in his mind. <i>“Ey, Misaki, kneel down and eat my balls, mind you? They are bursting with cum and I would like to get every drop inside our "  +  mcpronoun + "here…”</i> The bitch smiles and does as he required, even after you protested. You can’t see her, but the slurping sounds are overwhelming, and you tell Misaki that the least she can do is to eat your ass and finger it. \n\n<i>“Sure "  +  mcpronoun + ", your wish is my command.”</i>  She says, and her tongue plays with your butthole until it's wet enough for her fingers. \n\nMisaki keeps going hard on you, but this can go only for so long until your first climax is close, and when you inform them of this, Misaki and his friend increase their pace, making you have the climax of your life, filling your womb with so much cum that your pussy is overflooded by it, dripping cum when he is done. \n\nMisaki doesn’t waste time, and starts to eating your pussy out, drinking as much cum as she can, while his friend takes care of your breasts and kisses you. \n\nAlthough at first you take a rest, once you recover you keep fucking with them until you are spent. It was a great day, that’s for sure. ";

			} else {
				Board.text = "No scene for eunuch yet, sorry."; 
			}

		}

	}







	public void sexScene5(){

		GameControl.actualArousal = 0; 

		endTurnFun ();


		if (NPCCharList.CharFollower [iMisaki].slaveStage > 3)
		{

			// dick
			if (GameControl.mcSex == GameControl.MCSex.Man  ) {


			} else if ( GameControl.mcSex == GameControl.MCSex.Woman || GameControl.mcSex == GameControl.MCSex.Cuntboy) {



			} else {
				Board.text = "No scene for asexuals yet, sorry."; 
			}


		} else {


			Board.text = "You are taking a walk through the streets, and as you walk close to the tavern you hear some loud cheers that come from inside that makes you feel curious about them. You take a peek through the dirty window, and you can see how two unknown persons are fucking on a table in the middle of the place, surrounded by a crowd. You decide to enter and inspect what happen, but the moment you set foot inside someone grabs you and kisses you. \n\nIt takes you a second to realize that the one kissing you is Misaki, and once she is done, you ask her what is going on. <i>“Oh you don't know? It's happy hour!”</i> You can feel a hand touching your crotch, and now that you inspect the place, you realize those on the middle are not the only ones doing lewd things: Pretty much everyone is doing something, either masturbating or fucking someone else, although most people is just half dressed instead of nude. You ask Misaki since when happy hour means orgy time, but she just gives you a confused expression. <i>“Wait, this isn’t what happy hour means?”</i> She shrugs and smiles. <i>“Well, too late… Not like anyone here complains about it, so… Will you join us?”</i>\n\n ";
			if  (GameControl.dick1Size > 0 && GameControl.charArmorTags[1] == false && GameControl.charArmorTags[2] == false) {
				Board.text += "Before you can even answer, the hands that were touching your crotch have already removed your legwear, and you feel the warm feeling of a mouth sucking you out. When you look down, you can see one of the waitress, a bunny girl, blowing you, and Misaki laughs. <i>“Just enjoy yourself sweetheart, i know i will.”</i> She leans forward and keeps kissing you while the rest of the staff get both of you naked.\n\nMisaki whistles loudly, and after it you can see how the people around you grab your body and lift you, taking you to an empty table in the middle, where they force you to lie down. Although you are not resisting anymore, they still hold your legs and arms. Another girl joins to the bunny girl, a petite lioness, and both of them fight over your cock, to see which one has more time with it in her mouth. Misaki isn't satisfied just by looking the performance though, and climbs the table. <i>”Since you are having fun down there… I call dibs on its mouth.”</i> And with the cheers of the crowd she descends, sitting in your face, and you start to both eat her pussy with passion. \n\nThe first load of the night doesn’t take that long, cumming in the mouth of the lion girl, which ensues a fight between the two girls. Misaki mediates it tho, and asks to the winner to give half of your load to the loser, cum swapping your fluids with a wet kiss. \n\nAfter this, the girls move out into the crowd, although it doesn’t take long until you hear their moans. Misaki just gives you a couple of minutes to recover. <i>“Okay, now is my turn to spar with your weapon.”</i>  She position your cock head at the entrance of her cunt, and jerks you off until you are hard enough to enter her. \n\nYour penis is still super sensitive, but your complains doesn't matter to her, who starts to ride you fast and hard. When you tell her that you are close again, she snaps her fingers, and one of the waitress brings a lace, and ties it around your dick, stopping you from climaxing. \n\n<i>“Ah!... Great! Y-You are even h-harder! Ah!... B-but I need m-more! Someone, fill my other hole!”</i> It doesn’t take long until someone takes her offer, a very tall wolf man, who places his cock on her ass. He pumps her very hard, setting a very strong pace, \n\nThe three of you moan and enjoy yourselfs, you keep kissing Misaki who keeps saying how much she loves you and thanking you to be with her today while her both holes are being crushed. When the three of you are already on edge, you can feel that someone frees your dick, and the three have a very strong orgasm, filling her entirely. \n\nThe strength of her orgasm makes her fall on you, and you just hug her, resting while the place keeps the orgy going. \n\n<i>“This was wonderful... Hope you liked round one sweetheart, because the night is young.”</i> She kisses you, and you get ready for a night of love and lust.";
				charVirginity();
			} else if ( GameControl.hasVagina == true  && GameControl.charArmorTags[1] == false && GameControl.charArmorTags[2] == false) {
				Board.text += "Before you can even answer, the hands that were touching your crotch have already removed your legwear, and you feel the warm feeling of a mouth eating you out. When you look down, you can see one of the waitress, a bunny girl, and Misaki laughs. <i>“Just enjoy yourself sweetheart.”</i> She leans forward and keeps kissing you while the rest of the staff get both of you naked.\n\nMisaki whistles loudly, and after it you can see how the people around you grab your body and lift you, taking you to an empty table in the middle, where they force you to lie down. Although you are not resisting anymore, they still hold your legs and arms. Another girl joins to the bunny girl, a petite lion girl, and both of them fight over your cunt, to see which one has more time with it in her mouth. Misaki isn't satisfied just by looking the performance though, and climbs the table. <i>“Since you are having fun down there… I call dibs on its mouth.”</i> And with the cheers of the crowd she descends, sitting in your face, and you start to both eat her pussy with passion.\n\nThe first climax of the night doesn’t take that long, cumming in the mouth of the lion girl, which ensues a fight between the two girls. Misaki mediates it tho, and asks them to just resolve the problem with a wet kiss. \n\nAfter this, the girls move out into the crowd, although it doesn’t take long until you hear their moans. Misaki just gives you a couple of minutes to recover. <i>“Okay, now is time to get the the good stuff.”</i>  She lies on you and snapping her fingers, you can see how the crowd gets closer. \n\n\nAn equine guy gets ready to fuck both of you up, while you can feel how they put dicks on both of your hands. Misaki is kissing you, and you suddenly feel an enormous cock penetrating your wet pussy. <i>“Just let yourself go.”</i> She says, and without even thinking about it you are already jerking those cocks off.\n\nThe equine man penetrates you hard, but he also switches holes and between you and Misaki. You have lost control of yourself, unfocused and overwhelmed by all the dicks around. A wolf man puts his dick between your face and Misaki, and while she sucks him out you eat his big balls. When he eventually finish, Misaki makes sure to share most of the spoils with you.\n\nYou cum again and again, everyone in the place is having their turn with both of you, and you lose count of how many people has cummed in your ass, cunt and mouth. \n\nWhen the night ends, both of you are bathed in cum, your holes and stomach so full of it that you can barely move. Misaki fell asleep on you, and you just play with her stick hair until she wakes up. <i>“...Great night right? Did you enjoyed it sweetheart?”</i> You answer her with a kiss, and you can still feel the taste of cum in her mouth, which arouses you enough to have a last love making session before you leave.  ";
				charVirginity();
			} else {
				Board.text = "No scene for eunuch or this armor yet, sorry."; 
			}

		}

	}



	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		endTurnPanel.sortingOrder = 500;
		mainPanel.sortingOrder = -500;

	}



	void loadMisakiData(){
		iMisaki = 0;

		while (iMisaki < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iMisaki].charID >= 4000 && NPCCharList.CharFollower [iMisaki].charID < 5000){
				WorldControl.NPCID = NPCCharList.CharFollower [iMisaki].charID;
				//WorldControl.PortraitID = NPCCharList.CharFollower [iMisaki].charPortrait;
				WorldControl.furryPic = NPCCharList.CharFollower [iMisaki].isFurry;
				WorldControl.futaPic = NPCCharList.CharFollower [iMisaki].isFuta;
				break; 
			}
			iMisaki++;

		}

	}






	void charVirginity(){

		if(GameControl.isVirgin == true){
			Board.text += "\n\nYour character lost its virginity!";
			GameControl.isVirgin = false; 
		}

	}






	void Awake(){
		loadMisakiData ();
		startText ();

		buttScene3.interactable = false; 
		if (NPCCharList.CharFollower[iMisaki].charLove >= 60 || NPCCharList.CharFollower[iMisaki].corruptionStage >= 3  ) {
			buttScene3.interactable = true; 
		}

		buttScene4.interactable = false; 
		if (NPCCharList.CharFollower[iMisaki].charLove >= 85 || NPCCharList.CharFollower[iMisaki].corruptionStage >= 4  ) {
			buttScene4.interactable = true; 
		}

		buttScene5.interactable = false; 
		if (NPCCharList.CharFollower[iMisaki].charLove >= 100 || NPCCharList.CharFollower[iMisaki].corruptionStage >= 4  ) {
			buttScene5.interactable = true; 
		}




		if (GameControl.mcGender == GameControl.MCGender.FEMALE) {
			mcpronoun = "Lady";
		} else {
			mcpronoun = "Lord"; 
		}

		if (GameControl.dick1Size <= 0) 
		{
			scene2title.text = "Eat you out";
		}

		if (GameControl.dick1Size <= 0) 
		{
			scene3title.text = "Get fucked";
		}

	}

}
