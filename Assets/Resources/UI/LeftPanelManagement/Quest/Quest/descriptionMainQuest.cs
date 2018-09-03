using UnityEngine;
using System.Collections;

public class descriptionMainQuest : MonoBehaviour  {



	public string retDescription()
	{

		if (QuestControl.helenaQuest < 10) {
			switch (QuestControl.helenaQuest) {
			case 0:
				return "You arrived to the city not long ago, but in order to earn enough political power to actually impose your will you require to earn the confidence of the leadership of the city. Although not a powerful person <i>per se</i>, the first thing you need to do is to be in control of your own home. Helena, as the head maid, and someone who is known by your servants from long ago, is a key part for your plans, in the end, if you are not even able to control your household you will never be able to control the city. ";
			case 1: 
				return "After several conversations with Helena you have earn her friendship, nonetheless she is still far from the confident that you need. You decide that the bast way to have her on your side is by getting to know her past and history. ";
			case 2: 
				return "Helena has become a good friend of you, helpful and trusting. Nonetheless, the status quo has failed and is up to you to shake things up. Which direction should the city, or the whole island, take? Should you take the path of order and self-control? To punish those too weak to resist the corruption and create a new world where the failures of the past need to be eradicated, or has civilization failed and it is time to let everything burn and chaos reign, recover that instinctual essence that lives inside everyone be free and return to our place in nature? \n";
			case 3: 
				if (QuestControl.helenaCorrupt == true) {
					return "The first thing to do is to find with what Helena is struggling, find those small openings that will help you open her to the new world. ";

				} else {
					return "Helena’s a good person, but still, the corruption that resides inside her make her behave inappropriately and makes her too careless from time to time. You need to educate her again and show her why it is important to take care of others. ";

				}


			case 4: 
				if (QuestControl.helenaCorrupt == true) {
					return "The next step is to make sure that Helena enjoys the pleasures of the flesh, to understand how the old world restrained her and even punished her just for doing what her nature dictates. ";
				} else {
					return "Helena has learned to be thoughtful about others, but still she doesn’t know what self-love is, and why it is important to behave appropriately, not because others require it, but because it is good for her too. ";

				}
			case 5: 
				return "The head maid has deep desires inside here, you can sense it, is just that the society that we live in has marked those feelings as impure and harmful. Far from the truth, you will teach her to let herself go, and to show her how that can in fact improve society.  \n";
			case 6: 
				return "Helena has changed a lot since you meet her: She isn’t afraid anymore of sex, and she can show her whole body naked without any second thoughts, but still there is something inside her that still restrains her, a lack of faith in the new world. The final part of your process is not to just make her the woman that you want as your servant, but the woman that you need for your cause.\n";
			case 7: 
				if (QuestControl.helenaCorrupt == true) {
					return "There are many perks to the corrupt mind of Helena: A good sense of debauchery helps you get what you need done, the problem sometimes is that she has too much initiative, and although that can help you from time to time, it can also create problems. As there is no doubt about her corruption, no one will object about making her a slave, and as such, and the proper training, you wouldn’t have to worry about she doing something you don’t want. ";
				} else {
					return "Helena has been purified, but still you can see that her mind is troubled. You can feel a spark that lives inside her, a very strong trait that requires the appropriate fuel to burn the old facade off. But it’s also small enough that you can turn it off before it’ too late. Do you want an extremely powerful woman bossing everyone around, probably even overtaking you a little, or do you need a submissive servant that knows it’s place? ";
				}
	
			case 8: 
				if (QuestControl.helenaSlave == true) {
					return "You will train Helena into an obedient slave, useful to you and your cause. ";

				} else if (QuestControl.helenaDominant == true) {
					return "You will fuel the fire inside Helena and make sure she becomes the leader that you need, but not that you deserve. ";
				} else {
					return "You will make sure that she will never become too bossy for your liking. There is only one boss in the city, and that one is you. ";
				}
			case 9: 
				if (QuestControl.helenaSlave == true) {
					return "After enslaving and training Helena, you have taken total control of your house hold, now it’s time to see what’s next, and since Helena is one of the most knowledgeable person you have around, it may not be a good idea to ask her… ";

				} else if (QuestControl.helenaCorrupt) {
					return "After corrupting Helena, you have taken total control of your house hold, now it’s time to see what’s next, and since Helena is one of the most knowledgeable person you have around, it may not be a good idea to ask her… "; 
				} else {
					return "After changing Helena, you have taken total control of your house hold, now it’s time to see what’s next, and since Helena is one of the most knowledgeable person you have around, it may not be a good idea to ask her… \n"; 
				}

			default: 
				return "This is the default on Helena's description, its a bug, report it.";

			}
		}

		if (QuestControl.abbadonQuest < 10) 
		{
			switch (QuestControl.abbadonQuest) {
			case 0:
				return "Helena recommended you to visit Abbadon, one of the most important patricians on the city, and owner of many buildings around the cultural district. \n";
			case 1:

				return "Well, your first encounter with the nobleman was not as smooth as you would had wished, but nonetheless you need to keep trying. Knowing about his past and earning his trust is key if you want him to talk about more pressing or personal matters.\n";
			case 2:

				return "You believe that he trust you enough to talk about the things that trouble him. It is clear that there is conflict inside him, and that his identity has to do with it.\n";
			case 3:

				return "Well, with all the recent talks and events you believe that it is time to push Abbadon to either embrace or reject his current situation, but being indecisive clearly isn't working. \n";
			case 4:

				return "With most of his personal problems resolved, it is time to decide what is best for Abbadon and the city, should you corrupt Abbadon’s mind or instead cleanse it from nonsense? \n";
			case 5:

				return "This is the first step to change Abbadon for the best.\n";
			case 6:

				return "Abbadon tries to resist it’s violent impulses, why do so? \n";
			case 7:

				return "Abbadon tries to resist it’s violent impulses, why do so? \n";
			case 8:

				return "There is only one barrier that still holds and needs to be destroyed to make sure that Abbadon is 100% on your side. \n";
			case 9:

				return "Abbadon is now a loyal servant, and you need now to look into the future. \n";
			default:

				return "This is a bug";


			}

		}


	

		if (QuestControl.lucinaQuest < 9) 
		{
			switch (QuestControl.lucinaQuest) {
			case 0:

				return "You’ve heard from one of the patricians, that someone claiming to be your mother has arrived at the city. This is something that shocks you a lot. It has been years since you’ve heard anything from your mother. It wouldn’t be strange that someone would try and trick the new Liege, but you still want to see it with your own eyes. After a bit, Helena sends a courier to you, that you must return quickly to the castle, as she found out something about your so-called mother.";
			case 1:

				return "After confirming the identity of your mother Lucina, you want to know what happened to her and to why you didn’t knew nothing about her, more than the scarce info that your guardian gave you. Perhaps in that information you can see what happened to her and the reason you were living in that cabin for most of your childhood.";
			case 2:

				return "As you hear about her past, you come with the fact that some sort of creature has latched to her skin for some kind of survival. She calls it a “symbiote” of some sorts. You want to know what that means and perhaps the most important thing: How can you help her to deal with that thing.";
			case 3:

				return "With the symbiote and her recent past dust settled, you ask her about the city and maybe to know about what happened about your father. It’s the best to hear the info from someone that was in the front row of the whole event rather than from some dusty book that got the wrong version altogether.";
			case 4:

				return "Now that your mother has filled you with most of the info that you require about her and what she knows about the city, you know that she requires some serious help with her “symbiote” thing. But first, you gotta make sure that her corruption is where you want it to be. And for that, you need to push her in the right direction.\n\n";
			case 5:
				if (QuestControl.lucinaCorrupt) {
					return "You can feel how her corruption has increased, as she is being more prone to listen to her more deviant side of her. You will push her and convert her into the woman that you want her to be. And you will push her to achieve that state, as it will be something you want after all.";

				} else {
					return "You can feel how her corruption has shifted one step in the right direction, but she is still halfway there. You will push her to her limits and see her become the person that she must be in the end. And you will help her achieve that, as she is family after all.";

				}
			case 6:
				if (QuestControl.lucinaCorrupt) {
					return "You finally see how she has been transforming into something greater than her original self. You know that she is almost ready for the transformation, but you need to see that she is ready for what is to come, so you continue shifting gears inside her to help her reach that mental state. And with that, you have some ultimate plans to achieve that goal.";

				} else {
					return "You see with glee that she has been converting into something more free and lewd than her original counterpart. You will push her into the transformation you crave so much, but her mind must be free from blockades, so you continue playing with her corruption to crush any resistance that she can have left in her body or mind.";

				}
			case 7:

				return "You know that she is ready for the final step in her transcendence. This time, she has to make a decision about her actual condition regarding the symbiote. She has been fighting it with all her mind and willpower, but is that the correct way of doing things? She hasn’t been improving in months from what she says. You must intervene in this matter and settle things once and for all, for her well-being and yours.";
			case 8:

				return "You are proud of what your mother has become. Now that she is better than her previous self, you finally feel satisfied with the results and decide to ask her about what should be your next step, so you decide to go and search for her and plan it according to her advice. \n";
			default:

				return "This is a bug";


			}

		}

		if (QuestControl.itzelQuest < 7) 
		{
			switch (QuestControl.itzelQuest) {
			case 0:

				return "You go to visit what’s left of the old church, where you will find a pleasant surprise.";
			case 1:

				return "It is time to be decisive: Which Goddess will oversight your city?";
			case 2:

				return "You need to get better acquainted with Itzel to be sure you can trust her in the future, and to be able to persuade her into getting in line with your goals.";
			case 3:

				return "Finally the church is complete, and the big opening is here.";
			case 4:

				return "With everything already in place, it is just matter of fine tunning Itzel to your purposes.";
			case 5:

				return "Itzel needs to be ready to do <i>anything</i> for the well being of the city, and you will make sure she learns that.";
			case 6:

				return "Itzel is already on your pocket, but the city still not on your side. ";
			case 7:
				
				return "With Itzel on your pocket, you lock your eyes in the university and its dean, Celia.";
			default:

				return "This is a bug";


			}
		
			
		}

		if (QuestControl.virgilQuest < 6) {
			switch (QuestControl.virgilQuest) {
			case 0:

				return "After your unsuccesful meeting with Celia, you decide to visit Virgil and learn the basics of the city.";
			case 1:

				return "Virgils attitude is of no use to you, you come up with a plan and a surprise that may help him change...";
			case 2:
				return "After giving Virgil some time to get used to his new life, you decide it's time to give the next step.";
			case 3:

				return "Hopefully he is ready to teach.";
			case 4:

				return "The young wallaby asks  you some time to talk in private.";
			case 5:

				return "Time to celebrate and depart.";

			default:

				return "This is a bug";


			}
		}



		if (QuestControl.virgilQuest < 6) {
			switch (QuestControl.virgilQuest) {
			case 0:
				return "First steps.";
			case 1: 
				return "A lesson in attitude.";
			case 2: 
				return "The wingman.";
			case 3: 
				return "Learning time!";
			case 4: 
				return "Time out.";
			case 5: 
				return "Last session.";



			default: 
				return "This is the default on Itzel description, its a bug, report it.";

			}
		}





		if (QuestControl.celiaQuest < 7) {
			switch (QuestControl.celiaQuest) {
			case 0:
				return "It's time to update the curriculum, and unleash the potential of education.";
			case 1: 
				if (QuestControl.celiaStartCorrupt) {
					return "You've done your part, now its time that she starts talking about the University.";
				} else {

					return "The first thing to do is to understand her before anything else.";
				}

			case 2: 
				if (QuestControl.celiaStartCorrupt) {
					return "You've been talking with Celia for a while. It seems that she has been searching for you to talk about something important...";
				} else {

					return "Now that you know a bit about her, you have a couple of questions on your own.";
				}

			case 3: 
				if (QuestControl.celiaStartCorrupt) {
					return "Now that the rules of the university are out of the question, perhaps you should talk about other matters at hand...";
				} else {

					return "You found out a way to keep her little secret safe and sound. you're sure that it will be fun for her too.";
				}

			case 4: 
				if (QuestControl.celiaStartCorrupt) {
					return "You've heard that something is happening between the students, so its best to check it out as soon as possible.";
				} else {

					return "You've heard from Virgil, that the Dean has something to hide. Time to follow the scholar's advice.";
				}

			case 5: 
				return "Now that you've dealt with her past, its time to take a look at her future.";
			case 6:
				return "You got her support, maybe its time to ask for some directions as perhaps she knows someone.";

			default: 
				return "This is the default on Itzel description, its a bug, report it.";

			}
		}


		if (QuestControl.lucretiusQuest < 7) {
			switch (QuestControl.lucretiusQuest) {
			case 0:
				return "Celia suggested you to visit the Grand Alchemist of Aurorum, hopefully he will be able to help you on your quest to change the city.";
			case 1: 
				return "Lucretius needs a helping hand to get used to his new body.";
			case 2: 
				return "Both of you take a break to think about what will come next.";
			case 3: 
				return "Is time for Lucretius to apply his research... On himself.";
			case 4: 
				return "After all these past experiences, what will be the state of Lucretius soul at the end?";
			case 5: 
				return "Lucretius has advanced in his research, and has something to show you.";
			case 6:
				return "You'll soon have to face the last obstacle that fights against your goals.";

			default: 
				return "";

			}
		}


		if (QuestControl.faustinaQuest < 5) {
			switch (QuestControl.lucretiusQuest) {
			case 0:
				return "You finally have an audience with the General in Aurorum, will be as bad as Lucretius said?";
			case 1: 
				return "You need to review the discipline and equipment of your army, but you have a bad feeling about it.";
			case 2: 
				return "You will join Faustina to patrol around Aurorum, will it be as dangerous as she said?";
			case 3: 
				return "After days of hard work, Faustina invites you to take a break with her.";
			case 4: 
				return "The time to rebuild Aurorum is now, and how you will use your new workforce is up you.";


			default: 
				return "";

			}
		}

		Debug.Log ("Bug");
		return "End of the content for now."; 





	}



}
