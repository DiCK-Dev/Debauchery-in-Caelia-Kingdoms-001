using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CeliaQuest : MonoBehaviour {

	public Text Board; 
	static int iCelia;

	int iVar; 

	static int confirmationControl; 
	static int continueControl; 

	public Canvas endTurnPanel; 
	public Canvas panConfirmation;


	public Text option0Name;
	public Text option1Name;
	public Text option2Name;
	public Text option3Name;

	public Button option2Butt; 
	public Button option3Butt; 


	void questStart(){
		int i = 0;
		switch (QuestControl.celiaQuest) {
		case 0:

			WorldControl.day += 2; 
			QuestsController.RemoveID (10000);
			Quest celiaQuest2 = new Quest ();


			if (NPCCharList.CharFollower [iCelia].charCorruption >= 50) {
				Board.text = "After you finally acquired the basic information about the city that the dean Celia asked you to acquire, you return to her, knocking the door once more. You expected to hear the echoes of lewd actions, but not this time. You can hear her voice from inside, telling you that she is busy at the moment, that you should make an appointment with her secretary. You frown and tell her that you’ve waited enough time, and that you already fulfilled her task. There is a moment of silence, before she speaks again. \n\n<i>“Go ahead. You may enter then.”</i>Entering the room, you watch Celia take dainty sips from a small teacup on her desk, before rising up and approaching you in a confident and seductive manner. She motions you to sit in one of the chairs in front of her. You oblige her, mentioning that you finally finalized the course with Virgil. She rests in one of armchairs next to you, and nods at your answer. You think she flashed you a small smile as well. \n\n<i>“Damn, It’s good to see that you have enough skill to deal with someone as incompetent and perverted as Virgil. At least I knew I could place you with one of our youngest, and unreliable instructors and you would still produce results, my liege. You must have good blood in your family, or at least a better pedigree than your uncle. It seems that you have more spine than him as well, not that it’s something really hard to achieve, if you ask me.”</i> she says, condescendingly.\n\nIt seems that your uncle was a nuisance to her, which doesn’t surprise you at all, but you tell her that you’re here to do something better than that, that you want to erase the failures of your uncle within this city, and bring about new prosperity. Yes, you know that sounds something quite hard to do, but someone has to start somewhere.\n\nShe leans onto the arm of your chair, gracefully as ever. <i>“I’m not gonna be able to get you off my back, am I? You do have the blood of your uncle after all, it’s just a matter of time before you screw up and become just like him. Then again, I’m not one to go against the liege’s wishes. This city is at the brink of extinction, who am I to stop the last push to the abyss?”</i> After saying that, she places a hand over her forehead in an overly dramatic way.\n\nShe sighs heavily. <i>“Your uncle was instructed by the Citadel, the kingdom of the Elves, that the education had to be changed from their original ways, into something completely different. You should have seen my face when I saw the Curriculum from the Citadel. It was complete trash and we were nothing more than tools for them. I know that most of the people on this city are nothing more than that, but you know that you can’t throw the bright ones into the same box as the dull bulbs.”</i> She glares at you from the side. \n\n<i>“Your uncle was someone that wouldn’t stop thinking with his dick. You should have seen the times that he tried to coerce me into fucking him. Oh dear, he thought that I was like the other ladies, but I managed to bore him to death. Now here you are, of his same bloodline, trying to get on my good side. I’ll tell you what! I’m not gonna let an no-name brat tells me what to do just because it has a pinch of blood from someone with status. He was better dead than alive, anyways.”</i>\n\nShe stands up from the side of your chair.  You can’t help but see that her body is well-endowed. <i>“And with that being said, I would prefer to meet you somewhere else. Next time we will go to the gardens of the university. I’m getting tired of talking here with someone who doesn’t even know this facility properly.”</i> she says, as you tell her that it’s a great idea but that you have some matters to attend before that. You thank her for her time as you excuse yourself from the place. Looks like this will be harder than you initially thought.";
				QuestControl.celiaQuest = 100;
				QuestsController.createQuest (celiaQuest2, "The snake's den", "You've done your part, now its time that she starts talking about the University.", 67, 10001);

			} else {
				Board.text = "After you’re done with Virgil’s classes, you believe to be ready to go and face Celia again. You return to her, knocking the door once more. She invites you inside. As you enter you watch Celia take delicate sips from a cup with one hand as she touches up her makeup with another. A queen of multitasking. She motions you to sit on one of the chairs that are in front of her and you quickly inform her that you have finalized the course with Virgil. She nods and places the small mirror in the desk, just before taking a good look at you.\n\nPleased with your performance, or so it seems, she welcomes you. <i>“Very well, you’ve earned this fair and square. I’m quite surprised that you took your time to do the proper protocol within the university. That wasn’t something that your so-called uncle used to do. Usually, sending him to do anything that could be remotely called work was enough to get him off my back.”</i> she says with a condescending tone. It seems that your uncle was a nuisance to her, which doesn’t surprise you at all, but you tell her that you’re here to do something better than that, that you want to erase the failures of your uncle within this city, and bring about new prosperity. Yes, you know that sounds something quite hard to do, but someone has to start somewhere.\n\nShe meditates on the subject. <i>“I’m not gonna be able to get you off my back, am I? You do have the blood of your uncle after all, it’s just a matter of time before you screw up and become just like him.”</i> After saying that, she sighs and stands up from the chair, walking across the room without looking at you directly. You ask her what your uncle did to her and the university to get so much animosity on her behalf.\n\nShe crossed her arms with a hint of disgust, probably dredging up bad memories of your uncle. There  could be no other reason to make such a face.  <i>“Your uncle was instructed by the Citadel, the kingdom of the Elves, that the education had to be changed from their original ways, into something completely different. When I saw the curriculum from the Citadel, I feel that they wanted to use us more for manpower than the original focus of the university, that its something more focused on increasing a broad set of skills, rather than just becoming the toolbox of the Citadel. Our institution would have be reduced to expendable grunt work.”</i>\n\nThen she looks at you. <i>“But I didn’t allowed him to coerce me, even when he tried to do it from time to time. I’ve heard the rumors, you’re not from the Citadel and you’re off their influence. But I’m not gonna let that an unknown brat tells me what to do just because it has a pinch of blood from someone that was better off dead than alive”</i>\n\nCelia places her back against a wall nearby, and you can’t help but notice that she is well-endowed. <i>”With that being said, I would prefer to meet you somewhere else. Next time we will go to the gardens of the university. I’m getting tired of talking here with someone who doesn’t even know this facility properly.”</i> she says, as you tell her that it’s a great idea, although you have some matters to attend to before that. You thank her for her time as you excuse yourself from the place. Looks like this will be harder than you initially thought.";
				QuestControl.celiaQuest = 1;
				QuestsController.createQuest (celiaQuest2, "Educational reform", "The first step to change the education in Aurorum is to understand Celia's agenda.", 67, 10001);

			}


			endTurnFun ();
			break;
		case 1: // prologue 
			WorldControl.day += 2; 
			Board.text = "On this occasion, you want to understand how is that someone as bitter as her has become the way she is now. So, you send someone to notify her of your arrival, so she could prepare properly and you don’t have to deal with her cutting words this time because you’ve felt entitled with the power that you in fact, have. You’re the leader of this city, and you’ll make sure that she understands that at the end of this interactions with her. You have other matters to attend and you can’t keep playing her games forever. She says that her remark about the walk through the park is still in the air, so you send someone to tell her that you’ll be ready for an specific time, as you are someone that is also busy.\n\nAfter a couple of hours of getting yourself ready for the occasion, you arrive at the bench where you agreed to meet at. There she was, peacefully reading a book, which she closes when she sees you out of the corner of her eye. You greet her formally as she stands from the bench. \n\n<i>“Walk with me, “my liege”.”</i> she says, as she starts walking through the roads of the garden. \n\n<i>“I’ve heard what you did with Virgil. You decided to take him out of my hands and from behind my back. You didn’t even tell me about it. He’s got a title and everything! Talk about trying to strip my authority within the university.”</i> She says in a acidic tone. <i>“Good to know I wasn’t wrong about the failures and mischief of your blood”</i> You frown towards that comment. You just thought that she was being an asshole with that whole scheme towards Virgil. Yeah, he has a place to sleep and work, but that was almost indentured servitude.\n\n <i>“Look, I know why you’re here. I may be old, but I can still see things clearly.”</i> She stops walking for a second, before shaking her head and starting again. <i>“I’ll  see to whatever it is you need for you to get out of here as fast as possible and leave me alone without causing me any more problems.”</i> Well, that sure saves you a lot of negotiation.\n\nYou can see that there are several students doing all kinds of things in those gardens. You predominantly hear the echoes of debates, speeches, and the occasional physical training. As you proceed, the scent of arousal in the air catches you from from time to time, with the soft faint sounds of moaning coming from behind walls or bushes. At least these students have a place to practice their hiding skills. <i>“This university holds most of the noble sons and daughters of Aurorum. While some nobles have tutors, everyone with power ends up being connected here, one way or another. I know that you’re visiting the important places to see that “things gets done correctly”, to win your legitimacy with the support from everyone involved in the important things of the city.”</i> She is smart enough to see the political implications.\n\n<i>“If I want to make sure that you understand the needs of the university, I need to make sure that you understand the requirements of the place. And in exchange for my support, I would like for you to assist in some classes and workshops as an audit and perhaps talk with be about the things you found. With that, I would be sure that you would be informed. That would separate you quite a lot from your predecessor. You would enter into a place of knowledge and get out of it knowing a little bit more. It seems that you require that a lot.”</i> She sure enjoys fooling around with your lack of education.\n\nAssisting at the university. At first you can remember how you were being home-schooled by your mother, then it was the Guardian that she prepared for you. You tell her that its the first time that you would set a foot in a classroom. She smiles a bit. <i>“It’s never late to attend school, even if its temporary. So… do you agree to my terms or we should start hostilities just like the old days?.”</i> You think that she has something stuck up her ass, but you take it as an opportunity to understand more of the place and to have an excuse to talk with Celia and see if you can remove it from inside her. You accept her terms, something that pleases her. <i>“Then it’s settled. You’ll start tomorrow. I’ll look forward to see how this sorts out, “my liege”. ”</i> And with that, you tell her that you must get ready for attending that, so you retire from the place, leaving her walking through the trees as you retire from there.\n\nThe first day of classes its something that you couldn’t forget. It was weird to see too many students sitting in the same place, hearing just one person. You had a hard time fighting against the slumbering powers of some of the classes. After the appointed classes finished, you went straight to Celia’s office and knocked a couple of times, before seeing a couple of students opening the door and walking fast through the corridor. They were in a hurry as they didn’t stop to wave or say anything else, then you can hear Celia’s voice coming from inside. <i>”Hmm. "+GameControl.playerName+"? You are still here? Still want to continue?”</i>\n\nYou enter and start talking with her about the class structure and how the teachers have a hard time doing their jobs, which gives you a strange look, as if she is confused by the fact that you’ve been paying attention. You ask her if she has been teaching before her actual post of Dean, and she look at you as if the very question insulted her. <i>“Of course! Its pivotal to know the job of learning before applying to the position of dean. I am a great teacher, but it’s a hard job, especially after the outbreak. I enjoy being the dean, as I can do more for the university than I the one I was doing as a teacher, which is good in the end. How about that? Do you understand me? Its only been what, a few months since you got your actual position? How can I be so sure that you love your job and you’re not only doing it because it pays your vices?”</i> You sigh, she has a point. You explain her that the only way you can prove it to her is by doing your job, that’s all.\n\nAfter a couple of hours, you keep talking about the things that you noticed about the place, and how some of the students were intimidated by the presence of the city’s liege itself. At all times, it seems as if your fellow students kept their distance from you at all angles, as if you had an invisible barrier around you. You tell her that there are some things that could be improved for sure, but you’re quite curious, as she seems to know a lot of the university. For how long she has been the dean, you ask <i>“Well… I’ve been the dean for quite some time. One… decade, almost two.”</i> she says with a hint of shame. You tell her that she looks quite young for being that long in there. She ran a hand through her face as you say that, her face beaming with pride. <i>“Of course. I take care of myself a lot. No one would respect me if I looked like some kind of old hag!”</i> You are curious a bit about what she could do to keep herself so young and beaming. <i>“I may be old, but I don’t have to look old”</i> \n\nIt seems that she is somewhat focused in her actual looks. Perhaps this is a good moment to start talking with her on a more personal level. \n\nI could comfort her, a friendly approach to insist her that looks aren’t everything, and what matters is if she is good at heart. Or I could tell her that looks matters; even if they are superficial, the image of an institution, and those who lead it, are key to its reputation, something she can’t overlook. Such trivial obsessions could lead to unwanted practices. ";
			option0Name.text = "Comfort";
			option1Name.text = "Looks matter";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 0;


			break;
		case 2: // knowledge is power 
			WorldControl.day += 2; 
			Board.text = "You arrive as intended and started seeing to the most important issues that the university had at the moment, while enduring the verbal abuse of Celia, as she enjoys throwing punches below the belt every time she can. She knows that your knowledge about the university is limited and she doesn’t leave a chance to remind you of that. You can see that she does it in a small basis, so you cut her sentences off whenever you can, as she has to stop herself from continuing ahead, adjusting to your response towards her snide remarks. All of the things that both of you work towards at the university go smoothly, even though she has to bite her tongue more times than you notice, trying to adjust to your pace of handling matters.\n\nYou think that her strict behavior is quite beneficial for the university, as it seems that her behavior keeps itself quite stable in their rules and the way they enforce it. You know that you’ll regret it later, but you say that she is good at adapting the university to these new times. <i>“I know that we’ve been taking longer than the expected time, but since most of the students are too busy trying to get into each others pants, it’s hard to make them focus enough to force them to learn something properly, so we had to enforce some of the classes on the students. The sex class was a complete failure, so we don’t mention the sex class anymore”</i> As she mentions the sex class, you can see that her face gets red and she gulps a second. Sounds like an interesting story for later.\n\n<i>“We allowed the students to sate their urges inside their bedrooms, as long as they keep it in their dormitories and no one gets bothered by it.”</i> She smiles at that remark. <i>“but I’ve been having some problems with the students as of late and I... I thought that maybe you can help me with taking such an important decision.”</i> At least this time she agrees to help you participate in the changing of things. She takes out a couple of papers that are waiting for her signal from what you can see. <i>“The students have been protesting against the unfair laws that we’ve been enforcing on the last weeks. Even thought we have been more relaxed on some of the laws, we’ve been more strict on some others to compensate. I think that’s a fair trade”</i> She points at one of the papers that seems to be more full of text. <i>“They have been sending letter after letter with their own set of rules. And oh boy, most of them are quite scandalous, at least according to the traditional standards.”</i> She sighs as she takes out the papers and gives them a look for one second, before leaving them on their original place. <i>“I don’t know what to do with them, as they are more than a wild bunch of students, they are almost a parade of them trying to get to me to concede. It’s the first time in all these years that the students are this bothered. What do you suggest, liege?”</i> \n\nYou have two ideas that could prove useful for her. It would also be an example for Celia on how to deal with these problems in the future. So you suggest to her...";
			option0Name.text = "Concede";
			option1Name.text = "Contain";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 1;

			break; 
		case 3: // have fun
			WorldControl.day += 5; 
			Board.text = "You arrive inside Celia’s office. You can see her sitting in her usual armchair, drinking a glass of what you think is wine. She looks a bit more relaxed than the usual, but she straightens her posture when she see that you enter the office. Surprisingly, her traditionally found stack of paperwork is notably absent from her desk. You wonder if it’s because of the last decision you made about the course of the university or if it is just because she had less work on that day. <i>“Liege! I was wondering when you would show up. I was just about to send someone to check if you weren’t lost in the campus hallways... You know, with you living in the forest for so long, I thought that maybe this kind of big structures must be something quite different for you, I suppose.”</i> Now you wonder if it was a good idea of telling her about your humble beginnings. Regret fills your mind as you make a note to not tell any more of your childhood past.\n\nYou ask her what else she does when she is not working, a question that confuses her for a second. You continue explaining that you only has seen her working and nothing else. She doesn’t have any other kind of things she likes to do? You can see that question piercing through her chest, because she is speechless for a second. <i>“...O-Of course. I like to do other things, like studying and investigating about my field of research”</i> \n\nSo, she does nothing that isn’t related to her job?. <i>“When you put it like that...”</i> You can see that she is thinking a bit. <i>“I have a husband. Sometimes we do a couple things together. It isn’t an active marriage if you ask me. Its just that he is... common and a bit tame. Maybe a little bit less than that.”</i>  She seems to be the type of person that is more married to her job than anything else in her life. You can only wonder the life of her husband, probably he has his only way of living, or maybe he is always waiting for her at their house but she doesn’t pay much attention to him. Who could blame him when he has to deal with someone as obnoxious as her. \n\n<i>“We’ve been trying to conceive a child, but its quite hard for me it seems. We’ve tried everything!”</i> You raise both eyebrows. You didn’t knew that she was trying to get pregnant. You tell her if they have already tried different positions, something that makes her take a sip of the cup probably to stop her from saying something too inappropriate to her position.";
			if (WorldControl.futaOn) {
				Board.text += "\n\nI think that it may be related to the fact that I’m a hermaphrodite, she says as she shifts her legs. Her face portrays a level of discomfort and uncertainty, not sure if she can truly trust you. You tell her that it might be something related to that, but you are not sure. <i>“Of course. You’re no alchemist... Who could have thought.”</i> ";
			}
			Board.text += "\n\nYou tell her that maybe its because she is too stressed, as she is always knee deep in work, as if everything is something that must be put in their place just because she wants to. After that, you invite her to come and go with you to somewhere else where she could relax a bit. <i>“Are you saying that I’m not good at relaxing?”</i> She almost spills her cup when she moves her hands due to the gesture that she did. You only point at the cup that was still trembling in the desk and give her a look of obviousness. She crosses her arms and looks aside for a second. <i>“What do you have in mind, Liege? I’m sure that you know how to have a good time, as maybe its the only thing you do in this city. Am I wrong?”</i> You sigh at her attempts to  talk down to you as you think of a good place where you can show her to relax.";
			Board.text += "\n\nYou could take her to somewhere unique outside of the city. Dangerous, of course, but an unique experience nowadays, or you could take her to a <i>fun</i> place, a place that she would never go on her own.";


			option0Name.text = "Let's leave the city!";
			option1Name.text = "Let's go wild!";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 2;

			break; 
		case 100:

			WorldControl.day += 2; 
			Board.text = "This time, you want to understand better how is that she got at the level of corruption that you saw in her last time. Its obvious that she doesn’t mind being the manipulative woman that she is. She is quite different from what you expected from the dean of the university. This time you decide to go with her and confront whatever she could have up her sleeve prepared for you. You’re the liege of this city, so no self-entitled dean would be able to get to you. She says that her remark about the walk through the park is still in the air and its up to you if you want to continue talking to the dean, so you tell her that you accept it with a sigh.\n\nAfter a couple of hours of getting yourself ready for the occasion, you arrive at the bench where you agreed to meet at. There she was, peacefully reading a book, which she closes when she sees you out of the corner of her eye. You greet her formally as she stands from the bench. \n\n<i>“Walk with me, “my liege”.”</i> she says, as she starts walking through the roads of the garden. \n\nYou tell her to stop, as now that you have her in front of you, decided that you got the perfect place for both of you to talk. She frowns at your answer and stares at you for a while. After a bit of holding her gaze with your own, she sighs. <i>“…You seem to have more spine than I thought at first. Can you tell me where are we heading then, “my liege”?”</i> ";
			option0Name.text = "Romantic setting";
			option1Name.text = "Common setting";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 100;

			break;

		case 101: // by the book
			WorldControl.day += 5; 
			Board.text = "This time you go with her as you two agreed to, and dealing with the many issues that the university has,  she enjoys bothering you every time she can. She often mocks your lack of knowledge about the university and its protocols, all in “jest” of course. Nonetheless at least she also uses these opportunities to teach you more. Yet you really won’t let her disrespect you as she is doing as you begin to talk back to her.. \n\nEvery time you had the chance, you used some snarky remarks about how old she is, based upon the age estimate she gave you in the past. You’re not sure how much, but when you see that it somehow bothers her, you don’t let the subject up. After a while, you can see that every element within the administration of the university becomes an opportunity to show the others how good they are at undermining the other’s progresses in the best way.\n\nYou can see that despite being the bitchy teacher that she is, her structure of the university seems to be quite capable of sustaining itself. You know that you’ll regret it later, but you say that she is good at adapting the university to these new times. <i>“Ha! Of fucking course! It has been taking a while, but since most of the students are too busy trying to get into each others’ pants,  it’s hard to make them focus enough to force some knowledge into their skulls, so we had to improvise. The sex class was a success at first, but after there wasn’t a teacher that was able to deal with the students, we decided that he had to do something on a larger scale”</i> As she mentions the sex class, you can see that her breathing gets heavier, probably remembering a good past experience.\n\n<i>“We allowed the students to sate their urges inside their bedrooms, as long as they keep it in their dormitories and no one else gets bothered by it.”</i> She smiles at that remark. <i>“But I’ve been thinking about something for a while, and maybe your lack of focus on the university matters can help me on this one.”</i> She takes out a couple of papers that are waiting for her signal from what you can see. <i>“The traditional rules aren’t fit for this kind of city and I have two options.”</i> She points at one of the papers that seems to be more full of text. \n\n<i>“By having looser rules that takes into account the corrupt states of the students, I can save me a lot of time and effort. They are already corrupt and I can rest assured that they’ll keep themselves in that way. They may even shape their studies with new ways of learning and as long as they learn something new in these events, we are good to go. We require less staff enforcing the laws and everyone’s happy”</i> Then she points at the other paper, which seems to be the shorter of the two. <i>“This one removes most of the rules. This one is what is happening right now after all, as we don’t have enough staff to enforce the rules that we already have. The staff will be free to work on other parts of the university and we’ll have a more uniform mindset of students, if you get my drift.”</i> After that, she thinks for a moment then takes a good look at you. <i>“What do you think? Looser laws or no Laws?”</i> \n\nLooser laws isn’t a great choice, but it’s still better than no laws, and will help to hold off corruption. No laws will only ensure chaos... ";

			option0Name.text = "Looser laws";
			option1Name.text = "Virtually no laws";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 102;

			break; 

		case 102: //out with the old
			WorldControl.day += 3; 
			Board.text = "This time, you want to know more about her. There is a level of curiosity that grips you, making you wonder what is that behind her shield of cynicism and bitterness. There has to be something underneath all that, something soft and approachable. She is cleaning her face off as she enters her office when you arrive. <i>“Oh, you’re here. Today is a slow day, with the adminstration being sandbagged with a wait for approvals and lack of staffing. We have some time to kill.”</i> She says. You notice that her skin is tender and soft from the look of it. You take the opportunity and ask about her. <i>“Me? Of course, what do you want to know about me? Anything about me is interesting.”</i> She says as she sits on the desk and crosses her legs.\n\nYou ask her who she is, if she is from Aurorum, anything about her. You have been wondering those things about her but you never give them a good thought and now that both of you have some time, you finally can ask..  \n\n<i>“I’m not from here, as you can imagine. I’m from Wissenham, one of the closest cities to the elf citadel. Something happened and my mother and me moved from the city. Aurorum was the best choice for both of us. Aurorum is the type of place that places emphasis on culture, education, and tradition, so I was enamored with our relocation. At first it was amazing, but after the plague everything went south fast, yet we didn’t lose our drive or spirit. Since then, a lot of people has lost all their inhibitions, yet there is always something new around the corner for people to meet and enjoy in different ways.”</i> \n\nShe looks like a completely different person when reminiscing. <i>“I’ve learned the ropes from the philosophers and the other teachers that I had at the time. The citadel had it’s hands full due to the problems of the other cities, to come and reclaim some far and small town quite close to the shore. During that time I met my actual husband, he’s a philosopher from the city, so we documented a marriage so I could get some way to get into the university as he gained a wife. He’s… nice and comfy. [HERM]At least he doesn’t mind that I’m a herm…”</i> \n\nYou can see that she says it with a tone of dissatisfaction in her voice, as she shifts her legs a bit. You tell her that you didn’t know that she was a hermaphrodite. <i>“Well, its something interesting for some kind of people. But it pops out here and there, in all the senses of the word…”[/HERM]</i> \n\nShe says as she coughs a bit, adjusting her skirt, probably moving everything with it. <i>“But I kept floating this ship even through the murky waters of the Plague, if I can brag about it. That’s why I’m the Dean. No one else had the balls to push this place afloat. I dare to say that I made a goddamn job out of that”</i> And with other places almost in shambles, the fact that the university is up and going, even in a sorry state is truly something surprising. But you can see that the classes are crammed with students and the classrooms can be barely be called like that. Still, better having a ruined classroom than no classroom at all.\n\nAfter that, her secretary enters the office with a folder that she places on top of the desk. By the look of her, you can see that she is being careful with the Dean. You can see that Celia barely notices that she is there while she keeps talking about her past and the past events of the university. After the secretary finally leaves the place, Celia turns and takes the folder. <i>“Oh, right. I remember telling her that she should bring this up in case that you arrive. It’s something that I would require your undivided attention, my liege. It’s about the teachers of the university”</i> After that, she points at the paper that she has in her hands.\n\n<i>“After deciding about the rules inside the university, it was just a matter of time before the teachers of the different classes would come and bitch about it. I dealt with them with the utmost efficiency as you can imagine, but that won’t help in the long run. I can reach an agreement with them over time, as they are quite knowledgeable and reliable, but I’m not sure if I should do it. They are after all, guided by the old laws of the university.”</i> She looks at you carefully and smiles maliciously. \n\n<i>“Maybe it’s a good opportunity to make some changes to the faculty? Maybe new classes with new teachers? All the things that the Citadel fought to suppress after they conquered us can be reworked, and we could even explore new options. The freedom from the old guard could do wonders for this place and the students. With that being said,  I would like to have the good side of the authority with me on this. So… what do you recommend?”</i> She presents good points for both options. On one hand there are the reliable teachers from an old age, that can hopefully teach our youth. On the other side there are the rebels of the Citadel, bringing up a new kind of city with them, and with that, a new mindset that can occupy schools, but their influence may be dangerous in these dark times where corruption lurks everywhere.";

			option0Name.text = "Old guard";
			option1Name.text = "New teachers";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 103;


			break;
		default:
			Board.text = "This is all the content available for now, look forward the next update!";
			endTurnFun ();
			break;
		}
	}

	public void confirmFun(int selector){

		///////////////////////////// Comfort looks matter

		if (selector == 0 && confirmationControl == 0) {
			Board.text = "You tell her that she shouldn’t worry too much about her appearance, as she looks fine. Looks aren’t that important after all, especially since looks can’t keep the university running. A smile peeks through her face when she hears that. <i>“I know, you don’t have to tell me that. I admit that I like how I see myself now and how the other people see me. Maybe you don’t understand it completely as you haven’t felt the curse of beauty casted upon you”</i> She says with a the usual hint of disrespect that she loves to use with you. <i>“But its good to know that someone isn’t mad with how I should look and I think that’s fine. It helps me to get down to business without overthinking”</i> \n\nYou tell her that you didn’t had too much social interaction with others, as probably she already knows, seeing how you grew in the middle of the forest. <i>“Oh yeah. Is that true? I thought that it was some made-up story to make us feel sympathy for you”</i> You shake your head in denial, telling her that its completely true. You can even return to the cabin in the woods where you grew up. <i>“No thanks, my liege. I think that I’ll have your word for it. I don’t want to get into the woods in these times. Its full of Lost and monsters.”</i> You tell her that you’re more used to deal with those kind of people. <i>“I figured as much, it’s a miracle that you’re not some kind of feral boy wearing nothing more than a thong made of vines. I am very relieved by this.”</i> You frown at her and she shrugs as if she didn’t said anything strange.\n\nThe conversation run smoothly until you felt that you’ve talked with her enough, especially because you have other matters to attend as a Liege. <i>“Don’t be late. I will place students to see that you’re there in time”</i> She waves you goodbye, her eyes look at you with interest for one second, just before returning to the desk and act as if you weren’t even there. She surely knows how to get on your nerves. ";
			QuestsController.RemoveID (10001);
			Quest celiaQuest3 = new Quest ();

			QuestControl.celiaQuest = 2;
			QuestsController.createQuest (celiaQuest3, "Knowledge is power", "Now that you know a bit about her, you have a couple of questions on your own.", 67, 10002);

			NPCCharList.CharFollower [iCelia].charCorruption -= 25;

			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 0) {
			Board.text = "After she says that, you tell her that while appearance isn’t everything, one should always keep oneself looking good and well groomed. How is everyone else supposed to like us if we look like trash or smell like it? Sometimes your image can be used as an advantage, and within our line of work, any advantage is important to us. <i>“I know, I know. It’s just too hard”</i> You tell her that you understand, but continue to dwell on the subject. You eventually mention that it really is no big deal to you.  <i>“How I envy you, that you are not cursed with the beauty that weights heavy on my shoulders…”</i> She says almost in a dramatic tone, something that makes you frown at her, to which she just shrugs. <i>“It is what it is. But thanks for reminding me that I shouldn’t surrender it just because it’s hard. I don’t want to slack”</i> \n\nYou tell her that since you got into the city, you have seen creatures that you’ve never seen before. <i>“Oh right, you’re the “savage boy” that miraculously appeared in the middle of nowhere to reclaim the title! How original…”</i> You wave both hands and tell her that its completely true, but she only winks at you and nods. <i>“Of course it is, my liege! I would never say that my liege is lying! Don’t worry”</i> To which you sigh, your origin falling onto deaf ears. Perhaps you can explain it to her later.\n\nThe conversation run smoothly until you felt that you’ve talked with her enough, especially because you have other matters to attend as a Liege. <i>“Don’t be late. I will place students to see that you’ll be there on time”</i> She waves you goodbye, her eyes look at you with interest for one second, just before returning to the desk and act as if you weren’t even there. She surely knows how to get on your nerves. ";

			NPCCharList.CharFollower [iCelia].charCorruption += 25;

			QuestsController.RemoveID (10001);
			Quest celiaQuest3 = new Quest ();

			QuestControl.celiaQuest = 2;
			QuestsController.createQuest (celiaQuest3, "Knowledge is power", "Now that you know a bit about her, you have a couple of questions on your own.", 67, 10002);
			endTurnFun ();
			return;
		}

		///////////////////////////// Concede / Contain

		if (selector == 0 && confirmationControl == 1) {
			Board.text = "You tell her that it’s time that you listen to the voice of the students. They have some thoughts about the rules of the university and it’s their right for their voices to be heard. <i>“I’m not planning on becoming a puppet for the masses. That’s stupid”</i>  You aren’t telling her that she should subjugate to them, but that you should make a reunion with the most important of them and try to reach more of an agreement. You grab the paper and see that most of the laws that they are changing are the ones that stops them from being chaotic and corrupted. You tell her that it should be a university that is more in contact with their students. She doesn’t need more enemies around their students, nor does she need to make enemies out of her students.\n\nShe surprisingly ends up agreeing with you. <i>“I think you’re right. They have the right to explain their complaints. I think that the plague has made me more into a dictator than I am willing to admit”</i> You tell her that the outbreak has changed everyone’s life, that it’s not her fault. But there is still time to change that. It will take a bit of her pride out of her in the process, but you think that its a good thing in the long run. With that, you tell her the things that she should hear about their pleas and what things she should set in stone, to keep them just like they are. <i>“Who could have thought that you got what it takes to take good decisions about a large group of people?”</i> You smile at her remark. Even upon agreeing on a decision, she still won’t let up with the remarks.";
			NPCCharList.CharFollower [iCelia].charCorruption += 25;
			if (NPCCharList.CharFollower [iCelia].charCorruption > 100) {
				NPCCharList.CharFollower [iCelia].charCorruption = 100;
			}

			QuestsController.RemoveID (10002);
			Quest celiaQuest4 = new Quest ();

			QuestControl.celiaQuest = 3;
			QuestsController.createQuest (celiaQuest4, "A well deserved break", "After so much work, you and Celia take some time off.", 67, 10003);

			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 1) {
			Board.text = "Your suggestion to her is that you have to keep her authority untainted. That she couldn’t allow that kind of rules to get into the laws of the university. She knows what the laws are capable of, as the university seems to be less tainted from the seed of chaos that permeates the city. <i>“You’re right about that. I don’t want this place to fall into the depravity of these new kind of deviations. I’ve been taking care of it for a long time now for this Plague to come and take everything I’ve been fighting for.”</i> It seems that the seed of control was already bearing fruit in her soul, it just needed the right push. You tell her that she should call the instigators and check if they are too anarchist. Try and strike a deal with the ones that are pure and she should contain the ones that are too chaotic and send them to the guards, for their own good and the ones around them.\n\nYou can see that she seems a bit too ecstatic from the thought of imposing her will over others. It’s likely that this is something that she is used to do on a smaller scale, as she is the Dean. <i>“Yeah, I’ll see if the ones being contained are able to recover their senses after a couple of days of containment. Let’s hope for the best then”</i> She says with a glint of good will in her eyes. You hope that she keeps her gaze that way after whatever happens in that meeting. <i>“I knew that after a couple of days talking with me, you would become truly a Liege of worth”</i> You almost roll your eyes at the statement but instead you maintain your composure and take the compliment, instead of drawing more complications.";
			NPCCharList.CharFollower [iCelia].charCorruption -= 25;
			if(NPCCharList.CharFollower [iCelia].charCorruption < 0){
				NPCCharList.CharFollower [iCelia].charCorruption = 0;
			}

			QuestsController.RemoveID (10002);
			Quest celiaQuest4 = new Quest ();

			QuestControl.celiaQuest = 3;
			QuestsController.createQuest (celiaQuest4, "A well deserved break", "After so much work, you and Celia take some time off.", 67, 10003);


			endTurnFun ();
			return;
		}

		///////////////////////////// Leave city / go wild 

		if (selector == 0 && confirmationControl == 2) {
			Board.text = "You tell her that you know just the right place to take her, and that it will be somewhere interesting for her field but not in her comfort zone. You tell her that there is no place inside this city that is interesting to you, but outside of it... \n\nShe frowns at your remark, but you feel quite sure about it. It was a place that you found out in the way to the city, but you sure want her to see it with her own eyes. So, Celia tells her secretary that she will take the rest of the day off and follows you across the city on her horse. \n\nYou guide her to the road that leads outside the city, something that alarms her when she realizes what you’re planning. <i>“Where are you taking me? Isn’t it dangerous?”</i>  To which you tell her that it isn’t that far from the city. She knows that if she wants to experience something new, she has to try new roads after all. If anything happens, you are armed and ready to deal with anything. <i>“Are you sure that you can stop the Lost with that thing?”</i> You smile and nod several times, that’s what you did on a daily basis. You didn’t tell her that the traps that your guardian used helped you with that, but you didn’t want to scare her right now. You feel compelled to help her have a good time. Maybe in that way, she can finally stop being so bitchy about everything. <i>“Okay, but if anything weird happens, I won’t think twice about leaving you behind, my liege.”</i> You wouldn’t think otherwise from her, so you tell her that its okay, you can fend off for yourself if needed.\n\nYou both leave the city on that note. The way is clear of anything and you can see that the guards have been doing their job properly. You can remember a couple of them in the healing camps, but they are fine after all. She is wary of everything that moves around her, almost twitchy in her way of looking around. You can’t help but see her a bit more humble from the way she is behaving, as you know that she doesn’t have the upper hand out in the wild. You guide her through a small trail made by some couriers, as you can only think that this road was made so they could reach your house in the middle of the forest. <i>“So... you used this road to get into the city?”</i> To which you nod, as you tell her that its more strange returning than it was getting into the city at first.\n\nFinally, both of you arrive at some big tree that is laying in the middle of a small clear. You point at that tree and tell her to inspect it closely, something that she does as she notices that the bark is covered in strange markings and symbols. <i>“What is that?”</i> You explain that you found this tree when you were moving to the city. You tell her about the cultists that are surrounding the forest.\n\n<i>“Oh, you’ve had encounters with them? I know that they follow the old gods that were revered in this city, long before the Citadel conquered the place. They exiled themselves to the forest and continue doing their strange rituals. It must be something quite interesting to see, but with these marks... It seems that they are trying to recruit, as it seems to be pointing at somewhere more deep into the forest.”</i> She looks at you. <i>“You win. This is surely interesting. Perhaps I’ll send a teacher to investigate further into the matter. But first I’ll need to find someone that is willing to have an adventure with an scholar”</i> You nod at her words, partially taken aback by the fact that Celia mentioned something nice to you, and all it took was dragging her into the wilderness to do so.\n\nWith that small adventure finished, both of you return to the university, where she waves you goodbye for the first time in your interactions with her. You call that a victory, and with that you return to your castle. ";

			NPCCharList.CharFollower [iCelia].charCorruption -= 25;
			if(NPCCharList.CharFollower [iCelia].charCorruption < 0){
				NPCCharList.CharFollower [iCelia].charCorruption = 0;
			}


			QuestsController.RemoveID (10003);
			Quest celiaQuest5 = new Quest ();

			QuestControl.celiaQuest = 4;
			QuestsController.createQuest (celiaQuest5, "Hidden truth", "You've heard from Virgil, that Celia has something to hide. Time to follow the scholar's advice.", 67, 10004);

			Quest vivicaQuest1 = new Quest ();
			NPCCharList.CharFollower [loadChar (8000)].questControl = 0;
			QuestsController.createQuest (vivicaQuest1, "An explosive meeting", "After a busy day you go back to your castle, just to find out there is an uninvited guest.", 68, 8000);


			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 2) {
			Board.text = "You have the perfect location for a moment like this. It should be a place that Celia doesn’t go very often, or else your entire idea for the day is completely ruined. <i>“That will be hard, this city has only so many things to do for a lady like me. Believe me, if you have thought of it by now, I have probably done it.”</i> She says with a smile. You get worried, hopefully she is wrong on this one. You mention to her that someone with such high standards and expectations for lifestyle should be able to relax and cut loose every once in a while. You want her to leave some of her expectations and standards behind for this. She frowns but accepts, telling her secretary that she will return eventually, that she must send anyone who could be searching for her, away, and with that being said, she follows you on a horse.\n\nThe two of you arrive at a bit of a hidden spot within the town, a den of sin. From dancing to sex, a person of power or importance could do anything they wanted here, for the right price . <i>“What kind of place is this one?”</i> she asks, somewhat intrigued while trying to feign confusion. You mention to her that someone of her power could have a real good time in a place like this. You procure two drinks from the bar, offering Celia one. She frowns for a second and takes the one that you offered her, gives it a sip and looks surprised from their taste. <i>“It has a good taste. It isn’t wine, but I can get behind this. Let’s see what else there is here.”</i> \n\nAs she begins to loosen up, the two of you start to enjoy this place as she overlooks the crowds of people enjoying themselves. She spots some traditionally uptight nobles give into the atmosphere and have a great time. The rules and traditions that prevent people from who they truly want to be no longer apply down here, as you begin to mention to her the assorted activities she could take part in. <i>“Oh yeah, that’s right.  So many of those rules and expectations can be so restrictive, I don’t blame anyone here for trying to have a good time.”</i> You give her a nudge to let her enjoy herself here. Everyone has agreed to secrecy regarding the events here, and as long as she agrees to do the same, she has nothing to worry about. <i>“Well, I guess having some fun once in a while doesn’t seems to be that bad. I am surprised that the Liege of this city knows of such a place.”</i> You tell her that being on top of things leads to fun little discoveries such as this.\n\nYou know that there is another place where she could release her lusty urges, and maybe you could as well, but this place is already quite fun and you don’t want to push your luck with Celia too hard.";
			Board.text += "\n\nLusty lesson it's public use!";
			option0Name.text = "No sex";
			option1Name.text = "Lusty lesson";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 3;

			return;
		}


		///////////////////////////// No sex / lusty lesson

		if (selector == 0 && confirmationControl == 3) {
			Board.text = "You dismiss the idea of trying to get inside Celia’s pants, with the looming threat of tense work relations being a very real consequence once you leave this place. Besides, it would be good to let her have her own fun here, without you butting in. She only needs to tell you when she feels that she had enough. <i>“It’s the first time that I’ve been able to let loose for a while, so I might be here for a bit. If you want to go home without me, be my guest, don’t wait for me.”</i> She says, as she begins to feel the music. For someone so uptight, she begins to relax rather naturally in public.\n\nTime begins to become lost, as you observe her habits. Her dancing isn’t half bad, and she amazingly can handle her liquor well amongst peers. Her smile clearly tells you that she has waited a long time for an experience such as this. Her bookish appearance is misleading, rather than tiring out and avoiding the crowd, she spends the whole event feeding off of the energy of the room. You relax a bit, as you thought that you also earned the rest. When she finally looks tired, she has to hold herself from the wall next to you for a second, tipsy not just from the alcohol, but from the aura of the room itself. <i>“It’s good to see that you’re still here. I thought that you would have left already. Sadly, I think we should depart. We have a long day ahead of us tomorrow.”</i> \n\nAnd with that, both of you leave the small celebration cove and return to the university. You realize that this whole time, you never knew exactly where she lived. You begin to inquire this with her, mentioning how knowing her address could be helpful in the future. <i>“Ask my secretary, but I must go, for now I would like to rest my head a bit...”</i>  You sigh and accept that, leaving her at the university before returning to your castle. She blows you a kiss as she goes into her office as you enjoy the afterglow of the night’s event.";

			NPCCharList.CharFollower [iCelia].charCorruption += 25;
			if (NPCCharList.CharFollower [iCelia].charCorruption > 100) {
				NPCCharList.CharFollower [iCelia].charCorruption = 100;
			}

			QuestsController.RemoveID (10003);
			Quest celiaQuest5 = new Quest ();

			QuestControl.celiaQuest = 4;
			QuestsController.createQuest (celiaQuest5, "Hidden truth", "You've heard from Virgil, that Celia has something to hide. Time to follow the scholar's advice.", 67, 10004);

			Quest vivicaQuest1 = new Quest ();
			NPCCharList.CharFollower [loadChar (8000)].questControl = 0;
			QuestsController.createQuest (vivicaQuest1, "An explosive meeting", "After a busy day you go back to your castle, just to find out there is an uninvited guest.", 68, 8000);


			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 3) {
			Board.text = "With this being her first time here, you decide to show Celia the whole extent of this party. After arranging some details with someone managing the rooms, you return to Celia. <i>“What kind of place do you want to take me to?”</i> You mention to her that everyone here has agreed to secrecy in regards to the events here, but if she wants to truly let loose on her own, you have just the area for that. You can see that she is thinking about it, but after a bit she nods. <i>“Fuck this, I’m in.”</i> \n\nWith that statement, the two of you glide through the crowd and past the bouncer you talked to. The music fades as the door closes, revealing a hall up ahead.The isolated location has one feature that makes Celia’s jaw drop, as she realizes that the walls of the hallway are adorned with an assortment of gloryholes. \n\nShe turns to see you after that. <i>“But what if anyone else see me?”</i> You wave a hand, dismissing the remark, as you tell her that the point of this place is its secrecy. That she has nothing to worry about, that she doesn’t know the identity of them and they don’t know the identity of her. You can see that her face is red but she doesn’t stop glaring at the holes as many of them start to get filled with cocks from various sizes and lengths.";
			if (WorldControl.futaOn) {
				Board.text += "\n\nShe doesn’t waste a second, as she takes off her blouse and releases her cock as if you weren’t even there, her pent up frustrations fueling her actions. She grabs a couple of cocks with her hands as she starts sucking them with delight. Her skillful hands stroke the shafts as her tongue circles them with a hint of desperation as you can see how her own cock begins to stand with excitement from the environment. ";
			} else {
				Board.text += "\n\nShe doesn’t waste a second, as she takes off her blouse, her pent up frustrations fueling her actions. She grabs a couple of cocks with her hands as she starts sucking them with delight. Her skillful hands stroke the shafts as her tongue circles them with a hint of desperation. ";
			}

			Board.text += "\n\nAfter a few minutes of servicing the gloryholes, the cocks begin to twitch and erupt with a torrent of spunk all over Celia. She desperately tries to catch everything in her mouth, to no avail. Before she realizes it, she is covered in the seed of many men, the fluid soaking itself into her remaining clothing. As the climax continues, Celia daydreams for a brief second, getting lost in the bukkake bath, no longer trying to contain the explosive orgasms within her mouth.";

			if (WorldControl.futaOn) {
				Board.text += "\n\nYou can see that her own dick is pouring its contents all over herself as well, proof of the pleasure that is overflowing in her head.";
			}

			option0Name.text = "Sate her";
			option1Name.text = "Not interested";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 4;

			return;
		}

		///////////////////////////// Sate her / Not interested

		if (selector == 0 && confirmationControl == 4) {
			

			if (GameControl.dick1Size > 0) {
				Board.text = "As you see that, you can’t help but feel the urge of helping her with her predicament. You approach her slowly, undoing your garments and expose your [DICKRACE] cock shaft to her. You don’t need to say anything on the subject, as she hungrily devours your dick with desire, as if this is the first time in ages, drunk with enjoyment. You can feel her deft tongue wrapping around your cock, trying to squeeze out your juices. You take her head as you start thrusting your penis inside her mouth again and again. She doesn’t seems to mind at the moment, her eyes rolling into her head as she plays with her own cock and tits.";
				if (WorldControl.futaOn) {
					Board.text += "\n\nFinally, your orgasm arrives and you pull out of her mouth, icing her head with your frosty cum as her face is being soaked in it.  As her dick spurts whats left of it’s contents onto the floor below her, mixing with her own vaginal fluids, she cums a second time. ";
				} else {
					Board.text += "\n\nFinally, your orgasm arrives and you pull out of her mouth, icing her head with your frosty cum as her face is being soaked in it as she cums a second time. ";
				}
				Board.text += "\n\nShe was surely pent up! She continues to clean your cock even when slumped over on the ground. <i>“I think that this is enough... for today...”</i> She says with a grin on her face, her eyes looking at the vials resting next to her chest. You help her with the collection of cum before the two of you decide to clean your bodies off. <i>“If I had just known of this place before, everything would be so much better in life.”</i>. Celia is still lost in the moment as you both part ways, but not before she gives you a surprise kiss on the lips. <i>“Thanks for the help, champ.”</i> She says, before leaving the place.";
			} else {
				Board.text = "As you see that, you can’t help but feel the urge of helping her with her predicament. You approach her slowly, undoing your garments and expose you wet cunt, presenting it to her. You don’t need to say anything on the subject, as she begins eating you out with desire, as if she has craved this the entire time. You can feel her deft tongue darting inside your snatch, trying to taste as much of your juices as she can. You take her head as you start rubbing your pussy against her nose and mouth deeper and deeper. She doesn’t seems to mind at the moment, her eyes rolling into her head as she plays with her own cock and tits.";
				if (WorldControl.futaOn) {
					Board.text += "\n\nFinally, your orgasm arrives and you pull yourself out from her mouth, soaking her face with your vaginal juices. As her dick spurts whats left of it’s contents onto the floor below her, mixing with her own vaginal fluids, she cums a second time.. She was surely pent up! She continues to lick your cunt clean as she slumps down onto the ground. ";
				} else {
					Board.text += "\n\nFinally, your orgasm arrives and you pull yourself out from her mouth, soaking her face with your vaginal juices. She cums a second time.. And she was surely pent up! She continues to lick your cunt clean as she slumps down onto the ground. ";
				}
				Board.text += "\n\n<i>“I needed this so badly... I’ve almost forgotten what it was to do something like this...”</i> She says with a grin on her face, her eyes looking at her own body soaked in those perverted fluids. You help her to stand once more and to clean herself with the best of your ability, even thought she doesn’t seems to be worried about it. <i>“If I had just known of this place before, everything would be so much better in life.”</i>. Celia is still lost in the moment as you both part ways, but not before she gives you a surprise kiss on the lips. <i>“Thanks for the help, champ.”</i> She says, before leaving the place.";
			}


			NPCCharList.CharFollower [iCelia].charCorruption += 25;
			if (NPCCharList.CharFollower [iCelia].charCorruption > 100) {
				NPCCharList.CharFollower [iCelia].charCorruption = 100;
			}

			QuestsController.RemoveID (10003);
			Quest celiaQuest5 = new Quest ();

			QuestControl.celiaQuest = 4;
			QuestsController.createQuest (celiaQuest5, "Hidden truth", "You've heard from Virgil, that Celia has something to hide. Time to follow the scholar's advice.", 67, 10004);

			Quest vivicaQuest1 = new Quest ();
			NPCCharList.CharFollower [loadChar (8000)].questControl = 0;
			QuestsController.createQuest (vivicaQuest1, "An explosive meeting", "After a busy day you go back to your castle, just to find out there is an uninvited guest.", 68, 8000);


			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 4) {
			Board.text = " <i>“I needed this so badly... I’ve almost forgotten what it was to do something like this...”</i> She says with a grin on her face, her eyes looking at her own body soaked in those perverted fluids. You help her to stand once more and to clean herself with the best of your ability, even thought she doesn’t seems to be worried about it. <i>“If I had just known of this place before, everything would be so much better in life.”</i>. Celia is still lost in the moment as you both part ways, but not before she gives you a surprise kiss on the lips. <i>“Thanks for the help, champ.”</i> She says, before leaving the place.";

			NPCCharList.CharFollower [iCelia].charCorruption += 25;
			if (NPCCharList.CharFollower [iCelia].charCorruption > 100) {
				NPCCharList.CharFollower [iCelia].charCorruption = 100;
			}

			QuestsController.RemoveID (10003);
			Quest celiaQuest5 = new Quest ();

			QuestControl.celiaQuest = 4;
			QuestsController.createQuest (celiaQuest5, "Hidden truth", "You've heard from Virgil, that Celia has something to hide. Time to follow the scholar's advice.", 67, 10004);

			Quest vivicaQuest1 = new Quest ();
			NPCCharList.CharFollower [loadChar (8000)].questControl = 0;
			QuestsController.createQuest (vivicaQuest1, "An explosive meeting", "After a busy day you go back to your castle, just to find out there is an uninvited guest.", 68, 8000);

			endTurnFun ();
			return;
		}

		///////////////////////////// romantic common setting

		if (selector == 0 && confirmationControl == 100) {
			Board.text = "This time, you decide to take her to a place with a little more intimacy. With that in mind, the two of you arrive at the merchant district. The two of you find a small park located within, with the hopes of some privacy. You know that this isn’t protocol, but you prefer a bit of seclusion go with the etiquette. You can see that she is interested in your risky proposal, as she follows you with a hint of satisfaction on her face. <i>“Well, at least I know that you aren’t scared of the town that you’re supposed to guide…”</i> She says as you can see that there are some citizens moving in and out of that park at some distance from where both of you are right now. You know how your people tick and enjoy how they are becoming more and more free, it would be stupid if you were afraid of them just because they look different than before.\n\nShe turns to see you after you sit next to her, as she leans over your shoulder. <i>“I’ve heard what you did with Virgil. You decided to take him out of my grasp and from behind my back. You didn’t even tell me about it. He’s got a title and everything! You sure got some balls to come back after that and ask for help.”</i> She says with an acidic tone. <i>“And I respect people with that kind of attitude, at least. I hope that you had that in mind when you come to see me and not some kind of naive thought of taming this fine lady with only nice words”</i> You frown with her behavior, you just thought that she was being an asshole with that whole scheme regarding Virgil. Yeah, he had a place to sleep and work, but her manipulation of the situation was a dick move.\n\n <i>“Look, I know why you’re here. I may be old, but I can see things clearly.”</i> She stops talking for a second, before shaking her head and restarting her conversation. <i>“And maybe we can arrange some other meetings where we can discuss more interesting things other than work, of course… But I would rather finish the work in front of us now before we can start talking about the pleasure. So, the first thing that I want to make clear is that I’m interested in your way of doing things across the city.”</i> Well, that sure saved you a whole explanation.\n\nThat park seems to be full of people from the city. You can feel how your works and edicts have started  working on the people of the city. As you can hear how some of them are enjoying more than a walk in the park. The scent of arousal is in the air too, as the people are getting less worried about who is watching. But you have more pressings on the matter at hand. <i>“This university holds most of the noble sons and daughters of Aurorum. There are some that have a tutor instead, usually its someone that is connected to this place one way or the other. I know that you’re visiting the important places to see that “things gets done correctly”, to win your legitimacy with the support from everyone involved in the important things of the city. You’re new in all of this, so I’ll take it that you don’t have any experience in this kind of things…”</i> She is smart enough to see the political implications, but if you could be honest, it’s not alchemy to think that the new liege would require to do that in the first place. Any ruler worth their salt would try these basic approaches…";

			NPCCharList.CharFollower [iCelia].charLove = 10;

			option0Name.text = "Draw the line";
			option1Name.text = "Challenge her";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 101;

			return;
		}

		if (selector == 1 && confirmationControl == 100) {
			NPCCharList.CharFollower [iCelia].charLove = 0;
			Board.text = "In an attempt to keep even ground within the conversation, you take her to the outskirts of the university that its just for the both of you. There still is access to the general public, but the outskirts are such a widespread area that no one should bother the two of you. Celia notices this idea and proceeds to wear an irritated look. <i>“You’re sure someone that takes care of the details, but you’re no fun at all. Has anyone told you that before?”</i> She says as you smile a bit from her reaction. You can see that she dislikes being in the same terms than the other party that she is talking to. While you would prefer things to be in your favor, even grounds for both parties can be just as good.\n\nShe turns to see you after you sit close to her, crossing her legs. <i>“I’ve heard what you did with Virgil. You decided to take him out of my grasp and from behind my back. You didn’t even tell me about it. He’s got a title and everything! You sure got some balls to come back after that and ask for help.”</i> She says with an acidic tone. <i>“And I respect people with that kind of attitude, at least. I hope that you had that in mind when you come to see me and not some kind of naive thought of taming this fine lady with only nice words”</i> You frown with her behavior, you just thought that she was being an asshole with that whole scheme regarding Virgil. Yeah, he had a place to sleep and work, but her manipulation of the situation was a dick move.\n\n  <i>“Look, I know why you’re here. I may be old, but I can see things clearly.”</i> She stops talking for a second, before shaking her head and restarting her conversation. <i>“And maybe we can arrange some other meetings where we can discuss more interesting things other than work, of course… But I would rather finish the work in front of us now before we can start talking about the pleasure. So, the first thing that I want to make clear is that I’m interested in your way of doing things across the city.”</i> Well, that sure saved you a whole explanation.\n\nThe two of you proceed to look upon a small gazebo close to the university. It is filled with a mixture of students and workers mingling. While some of these minds have already been affected by your plans, there are others that still remain untainted and completely brainwashed by the current status quo. Some of the students have already begun to experiment with their clothing and fashion sense, going for riskier outfits to match their growing curiosities. <i>“This university holds most of the noble sons and daughters of Aurorum. There are some that have a tutor instead, usually its someone that is connected to this place one way or the other. I know that you’re visiting the important places to see that “things gets done correctly”, to win your legitimacy with the support from everyone involved in the important things of the city. You’re new in all of this, so I’ll take it that you don’t have any experience in this kind of things…”</i> She is smart enough to see the political implications, but if you could be honest, it’s not alchemy to think that the new liege would require to do that in the first place. Any ruler worth their salt would try these basic approaches…";

			option0Name.text = "Draw the line";
			option1Name.text = "Challenge her";
			panConfirmation.sortingOrder = 500;
			confirmationControl = 101;

			return;
		}

		///////////////////////////// draw the line challenge her 

		if (selector == 0 && confirmationControl == 101) {
			NPCCharList.CharFollower [iCelia].charCorruption -= 25;


			QuestsController.RemoveID (10001);
			Quest celiaQuest3 = new Quest ();

			QuestControl.celiaQuest = 101;
			QuestsController.createQuest (celiaQuest3, "By the book", "You've been talking with Celia for a while. It seems that she has been searching for you to talk about something important...", 67, 10002);



			Board.text = "You tell her that despite what she thinks or have heard about you, as a matter of fact you don’t appreciate nor will tolerate that kind of behavior. <i>“What you mean by “that” "+GameControl.playerName+"? Come on, speak as an adult.”</i>  you smile, amused by how fierce she is, and tell her that she should tone down her perverted behavior.\n\n<i>“Oh, you mean this?”</i>  and with an alluring expression she flashes you her juicy tits for a brief moment before covering herself up. <i>“Well, it’s your loss "+GameControl.playerName+", but why should you forbid others to enjoy these wonders?”</i>  You tell her that this behavior is not in line with what you want with your city, and tell her that if you don’t see changes, you may take action.\n\n<i>“Don’t be stupid, “my liege”, as your late uncle was, and don’t try to restrict me so much. I’ll do what I want in my university, and that’s it.”</i> she smirks before turning around and leaving with firm steps, although you can feel nervousness in her tone.";
			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 101) {
			NPCCharList.CharFollower [iCelia].charCorruption += 25;

			QuestsController.RemoveID (10001);
			Quest celiaQuest3 = new Quest ();

			QuestControl.celiaQuest = 101;
			QuestsController.createQuest (celiaQuest3, "By the book", "You've been talking with Celia for a while. It seems that she has been searching for you to talk about something important...", 67, 10002);


			Board.text = "You tell her that you love what she’s been doing with the university, specially how everyone is free to “express themselves” in the campus, like with their uniforms and their relationships, but yet you feel as if there is still a lot of restraint left. <i>“Ha, I didn’t think we both would agree on this, but I’m glad to be proven wrong. Yes, indeed I have pushed for a lot of “progressive” policies here, but this is as far as I’ve been able to go.”</i>  \n\nYou congratulate her for her vision, and tell her that if anything, she has your support to push this vision even further than before. <i>“Is that so? Duly noted then, I’ll keep this in mind for future meetings and plans.”</i>  \n\nDone with her for the day, you tell her that you will head back to attend other matters. <i>“Before you leave, want a preview of what I have in mind for the school?”</i> before you answer she flashes you her juicy breasts and laughs. Amused, you tell her that you look forward to these changes, as you leave for the day.";

			endTurnFun ();
			return;
		}

		///////////////////////////// Looser laws / no laws 

		if (selector == 0 && confirmationControl == 102) {
			Board.text = "You think that you can help her with the fact that they aren’t able to enforce their laws. You point at the “Looser Laws” edict. She is a bit surprised about your answer. You tell her that despite all the fun that they could get, you don’t want them to be loose cannons on the city, as you’ll have to deal with them sooner or later. You want them to be free, but they have to learn to respect authority, especially when you’re that authority and by extension, the Dean… why not? It would be a plus. After all, she must be a figure of respect, as she is probably as old as the university itself. You ask her for how long she has worked as a dean. <i>“A decade or two, something without importance. I have my own ways to keep myself young”</i> Once again, speaking about her age seems to press the wrong buttons on her, as her face twists into egotistical denial.\n\nAfter that, you help her to weed out the useless rules. University uniform? Stays. Laws of decency on the campus? Leaves. Discipline against violence? Stays. And so on and so on. After a couple of hours, both of you have a set of easier rules to enforce around the students of the university. Celia calls for her secretary, which quickly arrives. <i>“Take this and send it to the scribes. I want this ruling get as soon as possible in all the important places of the university. Call the head of the student council! Scram!”</i> She says out loud, as the secretary leaves the office rather quickly, making Celia laugh from her response. <i>“Hahahahaha. I know why I have her. Despite all this time, she is able to be scared of me nonetheless.”</i> \n\nAnd with your job finished, you tell her that you’ll see her sooner or later. She waves a hand as she starts to accomodate the papers in the place, as if you didn’t existed anymore.";

			NPCCharList.CharFollower [iCelia].charCorruption -= 25;
			if(NPCCharList.CharFollower [iCelia].charCorruption < 0){
				NPCCharList.CharFollower [iCelia].charCorruption = 0;
			}

			QuestsController.RemoveID (10002);
			Quest celiaQuest4 = new Quest ();

			QuestControl.celiaQuest = 102;
			QuestsController.createQuest (celiaQuest4, "Out With The Old...", "Now that the rules of the university are out of the question, perhaps you should talk about other matters at hand...", 67, 10003);


			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 102) {
			Board.text = "You think that the fact that there isn’t any way to enforce the laws just points out that there must be no laws after all. The students seems to be just fine, and if some kind of turmoil happens, you’ll be happy to provide some guards to judge the situation if the time comes. That will leave the place easier for her to deal with, but deep inside you know that this option will bring a lot of chaos and corruption to the younger minds inside the university. If all of the people are chaotic, then no one is and everyone is equalized. That is something she doesn’t have to worry about, as well as the possibility that they’ll respect her, as she is probably as old as the university itself. But all jokes aside, you ask her for how much she has been the Dean of the university of Aurorum. <i>“A decade or two, something without importance. I have my own ways to keep myself young”</i> \n\nBoth of you start weeding out almost all the rulings in the original rulebook of the university, only leaving laws that reference figures of authoritative power. The weeding out takes longer than expected as there were a lot of prude laws that had to go. Both of you laughed at some of them as they are quite obsolete in these days. <i>“ “Holding hands is something that is frowned upon.” As they are screwing each other, I think that their hands held against each other is the last place where I’ll place my eyes, that’s for sure.”</i>  When you finished with that ruling, Celia calls for her secretary, which quickly arrives. <i>“Take this and send it to the scribes. I want this ruling get as soon as possible in all the important places of the university. Call the head of the student council! Scram!”</i> She says out loud, as the secretary leaves the office rather quickly, making Celia laugh from her response. <i>“Hahahahaha. I know why I have her. Despite all this time, she is able to be scared of me nonetheless.”</i> \n\nAnd with your job finished, you tell her that you’ll see her sooner or later. She waves a hand as she starts to accomodate the papers in the place, as if you didn’t existed anymore.";

			NPCCharList.CharFollower [iCelia].charCorruption += 25;
			if (NPCCharList.CharFollower [iCelia].charCorruption > 100) {
				NPCCharList.CharFollower [iCelia].charCorruption = 100;
			}

			QuestsController.RemoveID (10002);
			Quest celiaQuest4 = new Quest ();

			QuestControl.celiaQuest = 102;
			QuestsController.createQuest (celiaQuest4, "Out With The Old...", "Now that the rules of the university are out of the question, perhaps you should talk about other matters at hand...", 67, 10003);

			endTurnFun ();
			return;
		}

		///////////////////////////// old guard / new teachers

		if (selector == 0 && confirmationControl == 103) {
			Board.text = "After taking a moment to decide, you rule in favor of experience developed over time, by keeping the old teachers. The laws and rules might change, but the classes of today have been perfected by generations of scholars and professors. It would be truly a waste to drop them just like that. So, you tell Celia that she should keep the original faculty, as you know that there will be tough times ahead, and she requires a reliable staff in times to come. Besides, they can help her to keep her ground and stop getting too far into the corruption that seems to be seeping through all the high spheres of the city. She raises both of her eyebrows.\n\n<i>“It seems that my liege has a plan already for the city. Mmmmm. Okay, if that’s what you think then it’s settled. I’ll make sure to keep them in the line.”</i> She nods and waves a hand. <i>“And the thing about keeping my ground, I’ll see what happens. Maybe I’ll unbalance the whole scale. I tend to change things when I’m involved in everything”</i> She runs a hand over her other arm slowly.\n\nThe door sounds a couple of times, the distinct echo of someone knocking it mildly. Both of you turn to see as the door opens, revealing a small figure of a man sheepishly opening the door. When he sees both of you, he says in a barely audible tone. <i>“A-Are you busy then?”</i> To which Celia sighs and nods. <i>“Yeah, of course I’m busy, I’m at work after all, Mus.”</i> You can see that there was a man that is the living image of the weak willed. Lower shoulder-line, avoiding eyes, his shrunken body over itself. \n\n<i>“I wanted you to know that I found out another method… But I’ll tell you at a better moment. Excuse me…”</i> He says before closing the door slowly, without making much sound. Celia places one hand over her forehead as you ask her who he is and what method he was talking about. <i>“Oh right. That is my husband, the one I talked to you about…”</i> You can see why she said that he is comfy. <i>“And the method… We’ve had some troubles conceiving and we’re been trying everything for it. I blame him for it, that’s one thing for sure. ”</i>  To which she turns to you, as if she just noticed something. \n\n<i>“But you’re the liege of the city. Maybe you can help us with that. If someone must have the most qualified alchemist in the city, it must be the liege. So, if you know anything about a treatment that could prove useful for both of us, then I’ll make sure that its properly paid”</i> She says with a wink. After that, both of you take your time in finishing the details of the deal with the old teachers before you call it a day and return to your castle.";

			QuestsController.RemoveID (10003);
			Quest celiaQuest5 = new Quest ();

			QuestControl.celiaQuest = 103;
			QuestsController.createQuest (celiaQuest5, "Crossroads", "You've heard that something is happening between the students, so its best to check it out as soon as possible.", 67, 10004);


			Quest vivicaQuest1 = new Quest ();
			NPCCharList.CharFollower [loadChar (8000)].questControl = 0;
			QuestsController.createQuest (vivicaQuest1, "An explosive meeting", "After a busy day you go back to your castle, just to find out there is an uninvited guest.", 68, 8000);

			endTurnFun ();
			return;
		}

		if (selector == 1 && confirmationControl == 103) {
			Board.text = "You think that it’s about time the university has a new change of course. New teachers are the best way to get into that path with the students. There are new fields of study and ways of teaching that could spark the rebellious nature of the young people in the city. In the times ahead, you will encounter more people that shall be unhappy with the situation in the Citadel. So, you tell Celia that its time to change most of the faculty, that maybe she should see who of them are able to adapt to the new times and fire the other ones. \n\nYou tell her that there will be times ahead when the Citadel is going to try and recover their conquered city, and maybe if they have students that are rebellious by nature, they will be less influenced by the ways of the capital. That she has the liberty to continue doing what she loves to do in the university, and that you encourage her new course of action. She claps several times. <i>“That’s what I wanted to hear, my liege! I knew that I could count on you on that. I knew that you had that edge for doing the most interesting things around here.”</i> \n\nThe door sounds a couple of times, the distinct echo of someone knocking it mildly. Both of you turn to see as the door opens, revealing a small figure of a man sheepishly opening the door. When he sees both of you, he says in a barely audible tone. <i>“A-Are you busy then?”</i> To which Celia sighs and nods. <i>“Yeah, of course I’m busy, I’m at work after all, Mus.”</i> You can see that there was a man that is the living image of the weak willed. Lower shoulder-line, avoiding eyes, his shrunken body over itself. \n\n<i>“I wanted you to know that I found out another method… But I’ll tell you at a better moment. Excuse me…”</i> He says before closing the door slowly, without making much sound. Celia places one hand over her forehead as you ask her who he is and what method he was talking about. <i>“Oh right. That is my husband, the one I talked to you about…”</i> You can see why she said that he is comfy. <i>“And the method… We’ve had some troubles conceiving and we’re been trying everything for it. I blame him for it, that’s one thing for sure. ”</i>  To which she turns to you, as if she just noticed something. \n\n<i>“But you’re the liege of the city. Maybe you can help us with that. If someone must have the most qualified alchemist in the city, it must be the liege. So, if you know anything about a treatment that could prove useful for both of us, then I’ll make sure that its properly paid”</i> She says with a wink. After that, both of you take your time in finishing the details of the deal with the old teachers before you call it a day and return to your castle.";

			QuestsController.RemoveID (10003);
			Quest celiaQuest5 = new Quest ();

			QuestControl.celiaQuest = 103;
			QuestsController.createQuest (celiaQuest5, "Crossroads", "You've heard that something is happening between the students, so its best to check it out as soon as possible.", 67, 10004);


			Quest vivicaQuest1 = new Quest ();
			NPCCharList.CharFollower [loadChar (8000)].questControl = 0;
			QuestsController.createQuest (vivicaQuest1, "An explosive meeting", "After a busy day you go back to your castle, just to find out there is an uninvited guest.", 68, 8000);


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
		loadCelia ();
		questStart ();


	}


	void endTurnFun(){
		PanLeftManagement.endTurnControl = true; 
		panConfirmation.sortingOrder = -500;
		endTurnPanel.sortingOrder = 500;


	}



	void loadCelia(){
		iCelia = 0;

		while (iCelia < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [iCelia].charID == 10000){
				WorldControl.NPCID = NPCCharList.CharFollower [iCelia].charID;
				WorldControl.PortraitIDLayer0 = NPCCharList.CharFollower [iCelia].charPortraitLayer0;
				WorldControl.PortraitIDLayer1 = NPCCharList.CharFollower [iCelia].charPortraitLayer1;
				WorldControl.PortraitIDLayer2 = NPCCharList.CharFollower [iCelia].charPortraitLayer2;
				break; 
			}
			iCelia++;

		}

	}


	int loadChar(int id){
		int i = 0;
		while (i < NPCCharList.CharFollower.Count) {
			if(NPCCharList.CharFollower [i].charID == id){
				return i;
			}
			i++;

		}
		return 0;

	}

}
