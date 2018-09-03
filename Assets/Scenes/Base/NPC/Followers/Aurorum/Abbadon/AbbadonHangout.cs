using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AbbadonHangout : MonoBehaviour {
	int hashcode = GameControl.playerName.GetHashCode();
	float randNum;

	static string pronheshe;
	static string pronhimher;
	static string pronhisher; 

	static int iAbbadon = 0;
	public Text Board; 

	public Canvas PanEndTurn; 

	public Canvas PanCorruption;


	public void hangOut(){


		loadAbbadon ();



		relationshipChange ();

		if (NPCCharList.CharFollower [iAbbadon].charCorruption < 33) {
			Board.text = hangoutLevel1();
		} else if (NPCCharList.CharFollower [iAbbadon].charCorruption < 66) {
			Board.text = hangoutLevel1();
		} else  {
			Board.text = hangoutLevel2();
		}


		endTurnFun ();

	}





	string hangoutLevel0(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum < 33) {
			toReturn = "";
			if (NPCCharList.CharFollower [iAbbadon].dickSize > 0) {
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
			return "";
		}

	}

	string hangoutLevel1(){
		string toReturn;
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		if (randNum > 80) {
			toReturn = "If you and Abbadon are going to be working together from now on, it would probably be best if you went and bonded with "+  pronhimher +" for a little. You decide to visit Abbadon’s manor to do exactly that, donning some formal wear before departing. A servant answers your knocking and allows you inside, making an audible note of how Abbadon has been working nearly non-stop as of late.\n\nOnce at "+  pronhisher +" studio, you can see Abbadon through the open door looking both half asleep and razor focused. Nearly half a dozen tea cups liter the desk, as well as documents, maps, and a stack of what you believe to be treaties and contracts. "+  pronheshe +" is so concentrated in their work that you are forced to tap their shoulder, causing Abbadon to whip "+  pronhisher +" head over in shock. <i>“Uh? "+ GameControl.playerName +"? How... when? Nevermind, just take a seat.”</i> You say that you’re here for some light chatting and perhaps to give "+  pronhimher +" a break, to which they graciously accept. Abbadon goes through two more cups of strong smelling tea before the topic lands upon the history of "+  pronhisher +" manor.\n\n<i>“I’d be glad to share that with you. If I were to explain the whole history of this manor, we would be here til dusk, so I will try to keep it brief. As one of the founding families of this city, this family has been including in many business ventures. However, one key area that my ancestors excelled in was the development of culture and the arts. I myself am not a performer or artist, but my family have come from a long line of scholars and poets.</i> "+  pronheshe +" points at a wall which is adorned with multiple portraits of what could only be "+  pronhisher +" family, as well as a plaque of their achievements underneath each painting.\n\n</i> “If you see a poetry house, bard’s college or any type of cultural architecture, then it is most likely the product of one of my family member’s ambitions. Although as you know, the circumstances that afflict this city from a decade ago have resulted in many of those buildings going into disrepair. Some of the oldest foundations have collapsed entirely, erasing a piece of my family’s legacy permanently. This is perhaps the last stronghold of culture available, and even keeping this much maintained is troublesome.” </i>\n\nAbbadon has a somber expression now, as if "+  pronheshe +" is looking back on better times. While you may not have been here, Abbadon must have witnessed the tumbling fall of this city firsthand. "+  pronheshe +" then looks straight at you, smiling.\n\n</i> “That is one of the reasons why I am willing to work with you. If you are successful, my legacy will not only be secured, but I will be known as the one that preserved the works of all those before me. The one who saved our family and the wonders they made for this city.” </i> It seems that despite "+  pronhisher +" cool demeanor, Abbadon is putting quite an amount of trust and hope into you. </i> “But enough about that. Let’s switch to a more jovial subject.” </i>\n\nYou stay with Abbadon for another hour, drinking tea while "+  pronheshe +" goes on to share the tales of "+  pronhisher +" deceased father in great length. Abbadon excuses you once "+  pronhisher +" yawns are too difficult to conceal, telling you that you are welcome to return at any time to chat. You return to the castle, knowing a great deal more about your ally and their motives.";
			return toReturn;
		} else if (randNum > 60) {
			toReturn = "Hours ago, you sent a sent one of your servants to see if Abbadon is willing to spend some quality time with you. They return with an approval and you set out, a cloudy sky threatening to rain above as you proceed to the manor. A house servant promptly guides you to the living room where you see hot drinks and pastries ready for your enjoyment. Abbadon is seated on the couch, now looking to you expectantly. </i> “Come "+ GameControl.playerName +", I’ve needed a time out from papers. All these new changes always come with a tree’s worth of parchment.” </i>\n\nYour conversation paths to what happened before your arrival, and Abbadon seems willing to talk about what happened during the infamous plague that had devastated the area.\n\n</i> “You know, I believe that the biggest change for me was that the plague had forced me to mature. I was barely a teenager when my parents succumbed to sickness, yet someone was needed to care for the household and it’s interests.” </i> You see the melancholy in "+  pronhisher +" eyes as they continue; </i> “For the longest time, my worries were only that of what I was to entertain myself with. Horseback riding, new concerts and plays that occurred each day, and bakeries that filled the streets with sweet scents. Those were the concerns of my childhood before…” </i>\n\nIt seems that they want to say more, but they restrict themselves, swallowing before finishing with, </i> “I believe it was raining when my childhood ended.” </i> Abbadon quickly changes the topic after this, switching to a more pleasant topic before it is time for you to return to the castle. It seems that "+  pronheshe +" is willing to share more with you, but perhaps when "+  pronheshe +" can trust you further.";		
			return toReturn;
		} else if (randNum > 40) {
			return "</i> “Checkmate! Goodness "+ GameControl.playerName +", not even my servants have lost three times in a row. Perhaps we should take a break for refreshments?” </i> Sighing from the previous defeats, you nod and leave the chessboard that has been cleaned of almost all of your pieces. In the living room is but more tea and baked goods for you and Abbadon, which helps you forget the embarrassment of the last hour or two.\n\nIt seems that Abbadon is quite passionate about chess. Despite your experience with it playing against your guardian, Abbadon is a true master of the game. When you inquire about where they learned to play, "+  pronhisher +" mood shifts from a cheerful look to a more somber one.\n\n</i> “It was my father who had taught me. If you thought I was good, then you should have seen him decimate the pieces of almost anyone that dared to challenge him.” </i> "+  pronheshe +" sighs, the nostalgic memories clearly afflicting "+  pronhimher +". </i> “We would play almost every night after his work was completed. He made sure to always reserve some time with me. I wish those times had lasted longer…” </i>\n\nAbbadon dwells on this topic for a considerable amount of time, the impact "+  pronhisher +" father having on them undeniably immense. This goes on for some time, by the time you depart you are left with a clear understanding of how Abbadon’s family had been with "+  pronhimher +". You feel ever closer to Abbadon now, the topics of your conversations becoming ever more personal.";
		} else if (randNum > 20) {
			return "Abbadon has been chatting your ear off about a new play as of late. Ever since you had developed the culture of the city, "+  pronheshe +" has gone to almost each and every performance with the intention of both entertainment and to make sure that "+  pronhisher +" investment was well placed. Knowing that "+  pronheshe +" usually attends these events alone or in "+  pronhisher +" personal loge, you ask if you could accompany them. </i> “I’m surprised that you’re interested in these matters "+ GameControl.playerName +". You are certainly welcome to join me.” </i>\n\nAbbadon has not dressed conservatively for this occasion, the beautiful royal blue dress "+  pronheshe +" wears today easily taking the eye of everyone who passes. The two of you proceed straight to the loge, guaranteeing that there will be no disturbances by anyone but the occasional servant bringing more refreshments. Abbadon leans against you as the show begins, the topic soon revealed to be a light comedy.\n\nThe content is easier to digest than the usual performances here, but no one seems to mind as laughter as cheers fill the theater. You and Abbadon are no exception, and by the time the short performance is over, both of you can’t help but hide smiles. The two of you stay in the loge well after the performance, reviewing the event and yammering about other meaningless topics until being told that the theater will be closing soon. You return home, content with your evening being well spent with good company.";
		} else {
			return "Although Abbadon is not a fan of the Colosseum and its blood sports, "+  pronheshe +" still visits occasionally to perceive the events and to inspect that "+  pronhisher +" investment was sound. Today there is a more innocent event; a 1500 meter horse race. Abbadon is quite the fan of horses by the look of "+  pronhisher +" excitement, and "+  pronheshe +" as invited you to join "+  pronhisher +" personal loge for the day. You agree, finding this a great opportunity to improve your relationship with Abbadon.\n\nYou arrive at the Colosseum to find Abbadon dressed in an appropriate but elegant outfit, a beautiful royal blue dress that even catches the eye if the race horses. The two of you head straight to the loge, where the only disturbance will be an occasional servant bringing cool drinks. Betting slips are held skyward in victory and ripped up in defeat as the races go on, though you have taken no part in it to instead pay attention to Abbadon.\n\nHalfway through the event, you realize that most, if not all the horses in this event have saddles with Abbadon’s family crest. When you ask, Abbadon admits that "+  pronheshe +" was required to use "+  pronhisher +" own stables for the event, as most other horses in the area were lost during the plague or unfit for racing. </i> “Though making them race is barbaric… I can see the appeal in it. Besides, they had been cooped up for far too long!” </i>\n\nAt the end of the day, Abbadon’s mood is very cheerful, happy for both the city and "+  pronhisher +" horses’ entertainment.";
		}

	}


	string hangoutLevel2(){
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime); 
		randNum = Random.Range (0, 100);
		randNum = Random.Range (0, 100);
		if (randNum > 75) {
			return "Today you are taking a stroll in the recently restored park with Abbadon, who requested another break from "+  pronhisher +" work to accompany you. Though the freshly planted flowers and renovated statues are extravagant compared to the rest of the city, you can see that Abbadon’s mood seems to have only depressed since "+  pronheshe +" left the manor. Though you try to avoid the topic at first, you soon see that Abbadon is at the verge of tears. Stopping at a bench to rest, you ask "+  pronhimher +" about their mood.\n\n <i>“Yes, it’s just today I was thinking about them. My parents.”</i> You remember "+  pronhimher +" talking about them before, and ask "+  pronhimher +" if "+  pronheshe +" misses them. <i> Yeah… the plague really changed everything. Even after a decade I don’t think that anyone has gotten over what was lost. I’ve kept myself busy enough to bury those problems away, but things have been changing.”<i>\n\nSeeing the questioning look on your face, Abbadon adds with a smile, <i> “I meant that things are changing for the better. Before your arrival, I had never seen my townsfolk so happy! But now that life has changed, I must accept that what was lost won’t return.”<i>\n\n You apologize for Abbadon’s plight, saying that you will give "+  pronhimher +" the time "+  pronheshe +" needs. <i> “Thanks "+ GameControl.playerName +". I just needed to talk about that, after bottling it inside for so long. Sorry if I took some of your time.”<i> You hug Abbadon with one arm, telling "+  pronhimher +" that this is what friend’s are for.\n\n<i>“Yeah, you are right. Thanks again "+ GameControl.playerName +", but I think we need to leave now, I’m sure the two of us have plenty of work ahead of us.”</i> You agree with Abbadon and you accompany "+  pronhimher +" to "+  pronhisher +" manor before going back to your castle, your friendship with Abbadon strengthened even further.\n";
		} else if (randNum > 50) {
			if (NPCCharList.CharFollower [iAbbadon].charGender == NPCData.CharGender.MALE) {
				return "You are having yet another long conversation with Abbadon in "+  pronhisher +" lounge, enjoying "+  pronhisher +" hospitality. This has become somewhat of a regular event now, but today’s conversation brings out a new personal issue of "+  pronhisher +"S.\n\n<i>“Since you haven’t lived in the kingdom for very long, it isn’t very surprising that you are puzzled about myself and my pronouns. Our family’s traditions state that the head of the house is to always be referred to as male, beyond the person’s actual sex or feelings. Though it’s not a very common issue since the first male born inherits the title, there have been exceptions to the norm like myself.”<i> "+  pronheshe +" pauses for a moment to take a drink, "+  pronhisher +" hands visibly trembling from nervousness.\n\n<i>“I am certain that had the plague never struck the city, my father would have sired other children. If that happened, I most certainly would not be the head of the manor right now.”<i> You can see how this thought could affect someone like Abbadon; "+  pronhisher +" love for being a leader clashing with the possibility of a luxurious normal life. <i>“Another tradition of ours is that the new heir is named Abbadon, and cannot change this until a new heir takes their place. I would have another name right now if I happened to have a brother; weird I know, but that is how this family works.”<i>\n\nIt seems that the tea is helping Abbadon, as "+  pronhisher +" hands have stopped shaking after the second cup. <i>“I’ve always wondered what it would be like, having my own name and being something other than a ruler, but I am the last surviving member of my family and it’s survival depends on me. If things were different I would consider ending that tradition, but during these dire times institutions may be the only thing keeping us sane.<i>\n\nYou stay and enjoy Abbadon’s company for a few more hours, occasionally switching between serious and casual matters until you are required to return to your castle. "+  pronheshe +" waves as you go, giving you a warm feeling of how far the relationship with Abbadon has progressed.";
			} else {
				return "You are having yet another long conversation with Abbadon in "+  pronhisher +" lounge, enjoying "+  pronhisher +" hospitality. This has become somewhat of a regular event now, but today’s conversation brings out a new personal issue of "+  pronhisher +"S. \n\n<i>“I’ve actually been investigating these old traditions of my house. Apparently naming and forcing heirs to be referred as male is due to one of my oldest ancestors. He happened to only ever have children who were girls, and when he neared the end of his life, there was no other option but to declare one of his daughters the heir. He then came to the decision to name every heir Abbadon, no matter their sex.”<i>\n\n<i>“Though I can’t entirely blame my ancestor. During that era it was forbidden for a woman to inherit anything, so this was his loophole to avoid losing the family legacy. Had he not done this, the family fortune and even this manor would have gone to the kingdom. While marriage was still an issue, having a bastard for one generation was a better prospect than losing everything.”<i> Abbadon doesn’t seem phased by any of this unpleasantness, a good indicator of how far you two have come.\n\n<i>“Perhaps if alchemy was as advanced as it is today, then they would have transformed the heir into a male. We may never know this, but I’d like to think that we wouldn’t be so cruel and barbaric as to go that far. I certainly wouldn’t after all.”<i>\n\n<i>“I wonder if alchemy was as advanced as it is today they would had forced transformed the first born into a male. I guess we’ll never know, but I like to think they wouldn’t be so cruel and barbaric as to go that far. I am certain I wouldn’t.”</i>\n\nYou stay and enjoy Abbadon’s company for a few more hours, occasionally switching between serious and casual matters until you are required to return to your castle. "+  pronheshe +" waves as you go, giving you a warm feeling of how far the relationship with Abbadon has progressed.";
			}
		} else if (randNum > 25) {
			return "Today you are taking a stroll in the recently restored park with Abbadon, who requested another break from "+  pronhisher +" work to accompany you. Abbadon does not carry the same sad look as before, now looking happy and cheerful around the robust trees and lush gardens. "+  pronheshe +" occasionally goes off the path and into the bushes, soon finding a nice spot that would be great for a picnic. <i>“I know this place as the palm of my hand. Though it’s changed a little since the renovation, I still had spent most of my childhood here. Alone, with friends and family, it didn’t matter to me as long as I was here. It’s truly an amazing part of the city and one of the few places that people could find refuge in after the plague.”<i>\n\nYou ask "+  pronhimher +" about the life here before the plague, since things were clearly never this bad before. <i>“Do you really wish to talk about that in this lovely park?”<i>“ "+  pronheshe +" sighs, now speaking in a frustrated tone. <i>“Fine, since you lived your whole life surrounded by nothing but dirt, you couldn’t have many fond memories.”<i> Ouch. You feel a sting to your pride as Abbadon mocks your past, the smug look on "+  pronhisher +" face showing that they feel better now.\n\n<i>“As you probably know by now, life in this kingdom was almost fantasy compared to today. The city itself was grand, but there were many small towns surrounding the walls filled with farmers and craftsmen and women of the like. The streets overflowed with tourists and merchants from all corners of the continent, pettling exotic wares and stories from kingdoms far away from this one. My household now looks like a common peddler’s home when I remember it from before. New plays at the theater almost every other day from the most signature playwrights of our time. The Colosseum not only held barbaric ritual, but shows of strength, dexterity, and sometimes even charisma without the bloodshed. There people could spend all day watching a new warrior test his mettle against a beast, lose their money betting on the wrong horse, or even participating in the community sporting events. While I doubt anything could top that golden age, I do so hope that we can return to a state even comparable to that of the past.”<i>\n\nYou can see that "+  pronheshe +" is saddened by that last statement, but "+  pronhisher +" face suddenly fills with hope. <i>“Who knows, with you in command things could very well change for the better, right?”<i> You nod and smile, deciding not to dash "+  pronhisher +" hopes with any doubts. <i>“I’m glad you think the same. Come now, let’s enjoy the fresh air and forget about our woes for awhile.”<i> "+  pronheshe +" lies back unto the grass, you joining "+  pronhisher +" side to enjoy the peace that can only be found in the park.";
		} else {
			if (NPCCharList.CharFollower [iAbbadon].charCorruption < 60) {
				return "While taking a break from a business meeting, you and Abbadon start a small conversation about the security of the city. <i>“While you think things might be bad today, they are but a shadow of what it was like during the height of the plague. At least now none expect the beasts to come beyond the city walls, where many of us were ambushed during those years.”<i>\n\nYou ask why Abbadon includes "+  pronhimher +"self in that category. <i>“Oh… shit.”<i>“ "+  pronheshe +" curses under "+  pronhisher +" breath, upset about how you noticed "+  pronhisher +" mistake in words. <i>“Well… considering how close you’ve become to me, there should be no harm in sharing this.”<i> "+  pronheshe +" takes a moment to drink of tea, "+  pronhisher +" hands trembling around the cup.\n\n<i>“It took a mere couple of years before the kingdom was torn apart by the plague. During that time, many people never even knew about the devastation beyond the walls, living our lives as usual even when the threats began to show just outside our doors. Being the stubborn child that I was, I never listened to the warnings from my parents and went off to ride in the forest.\n\nYou see Abbadon’s fist clench as "+  pronheshe +" continues. <i>“Now we had all known how the forests were plagued by beasts, but the rumors left many believing that there were only a handful. No one had even known about the skirmishes already occurring so close to the city walls. Suffice to say, I happened to be at the wrong place at the wrong time when this… horse man accosted me.”<i> "+  pronhisher +" voice wavers in anger, but Abbadon keeps their composure enough to continue.\n\n<i>“Things for me changed after that day. I didn’t dare leave the house for months, and even now I refuse to step beyond the city walls outside of an emergency situation. Not many of us have any business outside the city nowadays, but I absolutely detest the beasts out there for what they had done to me.”<i>\n\nYou decide not to push the subject anymore, instead mentioning that there is still work to be done. <i>“That would be for the best "+ GameControl.playerName +".”<i> When you two are done, you return to your home with a somber feeling in your gut. While the story was upsetting, it shows how much Abbadon trusts you now.\n";
			} else {
				string toret = "While taking a break from a business meeting, you and Abbadon start a small conversation about the security of the city. <i>“I can’t see why we all worried so much about beasts entering the city. The truth is that there is nothing to be afraid of.”<i>“ Abbadon seems completely relaxed right now, taking on a brazen attitude as "+  pronheshe +" continues. <i>“Have I ever told you of my first experience with a beast? It was years ago when the plague was first emerging, when even the people who knew about it like myself were very careless.”<i>\n\n";
				if (NPCCharList.CharFollower [iAbbadon].dickSizeCM > 0) {
					return toret + "Oddly enough, Abbadon seems to be supporting an erection, aroused as "+  pronheshe +" remembers the past. <i>“As the reckless child I was back then, I got the bright idea to go horseback riding in the forest despite the rumors of monsters plaguing them. I wasn’t paying much attention, enjoying the fresh air when suddenly horse man ambushed me. In the blink of an eye I was on the ground, begging for mercy as he tore my clothing apart.”<i>\n\nAbbadon shamelessly takes out "+  pronhisher +" cock, licking a hand before stroking "+  pronhisher +" member. <i>“You don’t mind if I relieve some tension do you? This story always gets me hot and bothered these days…”<i> Despite giving you the illusion of choice, Abbadon is well underway in pleasuring "+  pronhimher +"self and continuing the story. <i>“When he ripped my clothes off fully, I finally saw it. A huge, throbbing horse-cock that would put any in my stables to shame. His pre was as thick as cum on my rear, and I now regret not getting a taste.”<i> At this point Abbadon opens "+  pronhisher +" legs, lewdly presenting themselves to you as "+  pronheshe +" begins to prod their back door with a couple digits.\n\n<i>“So then I felt it, that big, flat-headed prick on my ass, ready to skewer me like a kabob. And he did! No foreplay, not even a warning, just raw and brutal sex. I will admit that I began to cry at first, and you must realize that my first experience with anal was a horse-cock as big as my arm going in with no lubrication. After an hour however, I was only crying for more and more inside me. I am not ashamed to say that the orgasm I had when he finally came was the strongest I’ve ever known. It was like a fountain turned on, and I ended up passing out from the feeling. When I came to I was drenched in cum, with so much still inside of me that I probably looked overweight!”<i>\n\n<i>“Although my body had eventually recovered physically, I believe that experience had changed me in another way. Since that day I could never get off without something being in my ass, and believe me when I say that I’ve used it a lot, even before I met you. I was just too shy to talk about it then, but nowadays I’m perfectly okay with you knowing my many sexual exploits.”<i>\n\nAbbadon’s hand jerks faster as "+  pronheshe +" approaches climax. <i>“Ahh, excuse me "+ GameControl.playerName +" but I need to unload… want to see a trick I learned?”<i> In an impressive feat of flexibility, Abbadon bends and contorts "+  pronhimher +"self to reach their crotch, managing to put "+  pronhisher +" own dick inside "+  pronhisher +" mouth and sucking it like a delightful candy. It doesn’t take long until "+  pronheshe +" grunts through "+  pronhisher +" own meat, cumming hard enough to bulge "+  pronhisher +" cheeks. When Abbadon finally lets go, the last few spurts of semen give "+  pronhimher +" a fine facial, semen slowly dripping down "+  pronhisher +" form.\n\n<i>“Ahhh… Apologies "+ GameControl.playerName +", but this story always really turns me on.”<i> With that out of the way, Abbadon decides to change the topic back to a more appropriate one, though throughout the rest of the day "+  pronheshe +" never cleans their face.";
				} else {
					return toret + "Abbadon quickly loosens "+  pronhisher +" clothing, face turning scarlet recalling "+  pronhisher +" past. <i>“As the reckless child I was back then, I got the bright idea to go horseback riding in the forest despite the rumors of monsters plaguing them. I wasn’t paying much attention, enjoying the fresh air when suddenly horse man ambushed me. In the blink of an eye I was on the ground, begging for mercy as he tore my clothing apart.”<i>\n\nAbbadon shamelessly strips "+  pronhisher +" leg wear, licking a hand before delving into "+  pronhisher +" pussy. <i>“You don’t mind if I relieve some tension do you? This story always gets me hot and bothered these days…”<i> Despite giving you the illusion of choice, Abbadon is well underway in pleasuring "+  pronhimher +"self and continuing the story. <i>“When he ripped my clothes off fully, I finally saw it. A huge, throbbing horse-cock that would put any in my stables to shame. His pre was as thick as cum on my rear, and I now regret not getting a taste.”<i> At this point Abbadon opens "+  pronhisher +" legs, lewdly presenting themselves to you as "+  pronheshe +" begins to prod their back door with a couple digits.\n\n<i>“So then I felt it, that big, flat-headed prick on my ass, ready to skewer me like a kabob. And he did! No foreplay, not even a warning, just raw and brutal sex. I will admit that I began to cry at first, and you must realize that my first experience with anal was a horse-cock as big as my arm going in with no lubrication. After an hour however, I was only crying for more and more inside me. I am not ashamed to say that the orgasm I had when he finally came was the strongest I’ve ever known. It was like a fountain turned on, and I ended up passing out from the feeling. When I came to I was drenched in cum, with so much still inside of me that I probably looked overweight!”<i>\n\n<i>“Although my body had eventually recovered physically, I believe that experience had changed me in another way. Since that day I could never get off without something being in my ass, and believe me when I say that I’ve used it a lot, even before I met you. I was just too shy to talk about it then, but nowadays I’m perfectly okay with you knowing my many sexual exploits.”<i>\n\nAbbadon’s fingers pump faster as "+  pronheshe +" approaches climax. <i>“Ahh, excuse me "+ GameControl.playerName +" but I need a moment… please watch!”<i> Abbadon closes "+  pronhisher +" eyes and arches "+  pronhisher +" back as the first wave of orgasm overcomes "+  pronhisher +" mind. The sight of one of the most powerful individuals in the kingdom orgasming while remembering "+  pronhisher +" first cock is truly remarkable, and now one of the great perks that come with your title.\n\n<i>“Ahhh… Apologies "+ GameControl.playerName +", but this story always really turns me on.”<i> With that out of the way, Abbadon decides to change the topic back to a more appropriate one, though throughout the rest of the day "+  pronheshe +" never covers "+  pronhisher +" dripping pussy.\n";
				}
			}
		} 

	}







	void relationshipChange(){
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + WorldControl.dayTime +2); 

		NPCCharList.CharFollower[iAbbadon].charRelationship += Random.Range (1.5f, 5f);
		NPCCharList.CharFollower[iAbbadon].charLoyalty += Random.Range (0.5f, 2f);

		if (NPCCharList.CharFollower [iAbbadon].charRelationship > 100) {
			NPCCharList.CharFollower[iAbbadon].charRelationship = 100;
		} 
		if (NPCCharList.CharFollower [iAbbadon].charLoyalty > 100) {
			NPCCharList.CharFollower[iAbbadon].charLoyalty = 100;
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



}
