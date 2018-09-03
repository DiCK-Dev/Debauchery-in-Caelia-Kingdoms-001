using UnityEngine;
using System.Collections;

public class CombatVictoryTextsEnemyGeneric  {


	public static string textGeneric(){
		NPCData.CharClass charClass = NPCCharList.CharMonster [0].charClass;

		string heshe = "he", hisher = "his", himher = "him", HESHE = "He", HISHER = "His";

		if (NPCCharList.CharMonster [0].charGender == NPCData.CharGender.FEMALE) {
			heshe = "she"; hisher = "her"; himher = "him"; HESHE = "She"; HISHER = "Her";
		}

		if (NPCCharList.CharMonster [0].charCorruption > 50) {
			switch (charClass) {
			case NPCData.CharClass.Alchemist:
				return "As you take down the alchemist, "+ heshe +" promptly surrenders. Living in a laboratory and doing experiments only prepared "+ himher  +" to deal with weaklings, but now that "+ heshe +" has to face someone powerful like you "+ heshe +" can only yield.\n\nNow with "+ hisher +" fate in your hands, "+ heshe +" offers "+ himher  +"self to you. The corrupt being flaunts "+ hisher +" hips, eagerly inviting you to take "+ himher  +" in any way you want, almost begging you to do so to satiate "+ hisher +" insane lust.";
			case NPCData.CharClass.Artist:
				return "The artist can’t deal with a warrior such as yourself. Although you wonder why someone like "+ himher  +" would be in the wild, you can see that "+ heshe +" has been corrupted, "+ hisher +" mind filled with depraved thoughts. \n\nMaybe "+ heshe +" was looking to take someone for "+ himher  +"self, or maybe "+ hisher +" plan was to be taken by someone stronger than "+ himher  +". Whatever the case, you can see how "+ heshe +" subtly welcomes you to take "+ hisher +" body. ";
			case NPCData.CharClass.Barbarian:
				return "After a very tough fight the barbarian finally falls to "+ hisher +" knees, defeated.\n\nYou can see how "+ heshe +" accepts that you’ve showed "+ himher  +" who is superior, and now "+ heshe +" is waiting for you to take "+ hisher +" body. \n\n"+ HESHE  +"’s not reluctant in any way, if anything, you can see how "+ heshe +" is excited about the thought of being taken in all of "+ hisher +" holes, amusingly submissive for such a warrior, "+ hisher +" mind already corrupted. \n";				
			case NPCData.CharClass.Bureaucrat:
				return "The pathetic bureaucrat kneels and bows down. Deep down "+ heshe +" knows "+ heshe +" never had a chance against someone like you, and now that "+ heshe +" has been bested "+ heshe +" is begging you to forbid "+ himher  +", in exchange of "+ hisher +" body.\n\nNonetheless you can see there is a smile on "+ hisher +" face, and how "+ hisher +" face is red, excited. Is "+ heshe +" actually looking forward to this? Maybe "+ heshe +" left the city just for this to happen, since it is clear that corruption has rotten "+ hisher +" mind. \n";
			case NPCData.CharClass.Clerk:
				return "The poor clerk never had a chance against you. Defeated, "+ heshe +" raises "+ hisher +" hands and asks you to stop attacking "+ himher  +", that "+ heshe +" will do anything you want. \n\nWhile you ponder what to do you can see how "+ heshe +" licks "+ hisher +" lips, "+ hisher +" face red while imagining how you take "+ hisher +" body.\n\nClearly "+ heshe +" has been tainted by corruption, and with "+ hisher +" submissive nature "+ heshe +" can’t help "+ himher  +"self. \n";
			case NPCData.CharClass.CommunityWorker:
				return "The poor community worker never had a chance against you. Defeated, "+ heshe +" raises "+ hisher +" hands and asks you to stop attacking "+ himher  +", that "+ heshe +" will do anything you want. \n\nWhile you ponder what to do you can see how "+ heshe +" licks "+ hisher +" lips, "+ hisher +" face red while imagining how you take "+ hisher +" body.\n\nClearly "+ heshe +" has been tainted by corruption, and with "+ hisher +" submissive nature "+ heshe +" can’t help "+ himher  +"self. ";
			case NPCData.CharClass.DarkPaladin:
				return "The dark paladin falls on "+ hisher +" knees. Although you expect "+ himher  +" to be feisty, you can see how "+ heshe +" submits to you, offering you "+ hisher +" body to be defiled even more.\n\nThe aura of corruption that surrounds "+ himher  +" is powerful, and you can’t help yourself but to get a little bit aroused by it. \n";
			case NPCData.CharClass.Diplomat:
				return "Although an expert deal maker, this diplomat is no match for you in a combat. Defeated, "+ heshe +" begs you to forbid "+ himher  +", and eagerly submits to you even before you agree to it.\n\nYou can see how "+ hisher +" soul is already corrupted, and taking "+ hisher +" body for your own pleasure would be a win-win scenario for "+ himher  +".";
			case NPCData.CharClass.Enforcer:
				return "The former enforcer falls to the ground, no match to you. You can see that the once proud member of the guard is now begging for you to take "+ hisher +" body and spare "+ hisher +" fate. \n\nYou fill pity for "+ himher  +", until you realize how aroused "+ heshe +" actually is: "+ HISHER  +" mind and body corrupted, and a submissive nature making "+ himher  +" look forward for what’s next. \n";
			case NPCData.CharClass.Farmer:
				return "The poor farmer never had a chance against a real warrior, let alone one as experienced as yourself. "+ HESHE  +" turns around and bends over, asking you to take "+ hisher +" body.\n\nYou touch "+ hisher +" back and feel how "+ hisher +" body is incredibly hot and aroused. As you suspected, "+ heshe +" has been already fallen to corruption. ";
			case NPCData.CharClass.Feral:

				if (NPCCharList.CharMonster [0].charRace == NPCData.CharRace.Human) {
					return "How can a human be feral is beyond you. Maybe "+ heshe +" was thrown away into the woods when "+ heshe +" was a kid, or "+ hisher +" parents got attacked. \n\nWhatever the case, it’s almost a miracle that "+ heshe +" hasn’t been turned into a monster at this point, although "+ hisher +" mind has been corrupted.  \n\n"+ HESHE  +" has turned around and offered you "+ hisher +" ass to you, eagerly waiting for you to take whats yours. ";
				} else {
					return "You struggle to defeat the ferocious feral, but a wild beast is no match for you. \n\nAs a show of submission, "+ heshe +" has turned around and offered you "+ hisher +" ass to you, eagerly waiting for you to take whats yours. \n";
				}
			case NPCData.CharClass.GuildWorker:
				return "The poor guild worker never had a chance against a real warrior, let alone one as experienced as yourself. "+ HESHE  +" turns around and bends over, asking you to take "+ hisher +" body.\n\nYou touch "+ hisher +" back and feel how "+ hisher +" body is incredibly hot and aroused. As you suspected, "+ heshe +" has been already fallen to corruption. \t";
			case NPCData.CharClass.Infiltrator:
				return "The fact that a shady person ended up in a situation like this is no surprise. \n\n"+ HISHER  +" corrupted soul and "+ hisher +" submissive nature is blatant: "+ HESHE  +" quickly got naked and offer "+ hisher +" body to you, maybe just lusting for pleasure more than expecting forgiveness. \n";
			case NPCData.CharClass.Inquisitor:
				return "The corrupted inquisitor raises "+ hisher +" hands and asks you to stop. Although you would expect that such a former powerful person to be proud, "+ heshe +" easily submits to you, offering you "+ hisher +" body to be used in any way you want. \n\nYou tell "+ himher  +" to bend over and offer you "+ hisher +" ass, and "+ heshe +" does it without any reluctance, truly looking forward to what’s next. ";
			case NPCData.CharClass.Monk:
				return "The monk comes to term to "+ hisher +" fate, knowing that "+ heshe +" cant best someone like you.\n\nWithout any reluctance "+ heshe +" submits to you as if you were "+ hisher +" God. Although "+ heshe +" tries to hide "+ hisher +" perverse nature, you can see through "+ hisher +" peaceful smile how the corruption has filled "+ hisher +" soul, and now is waiting for you to take "+ hisher +" body and defile it in as many ways as you can.";
			case NPCData.CharClass.Mystic:
				return "The powerful mystic is defeated, no match for someone like you. \n\nYou can see that "+ heshe +" conjures a spell before you can stop "+ himher  +", but to your surprise what "+ heshe +" does is to get instantly naked, offering "+ hisher +" body to you. \n\nAlthough "+ heshe +" could had tried to escape, "+ hisher +" corrupt mind and submissive nature made "+ himher  +" to surrender "+ hisher +" body and fate to you. ";
			case NPCData.CharClass.Paladin:
				return "After a tough combat you finally best the paladin. Although "+ heshe +" was a warrior for justice and what’s right, "+ heshe +" has fallen to corruption not long ago, and now that "+ heshe +" has been defeated "+ hisher +" body is asking to be defiled. \n";
			case NPCData.CharClass.Performer:
				return "The performer can’t deal with a warrior such as yourself. Although you wonder why someone like "+ himher  +" would be in the wild, you can see that "+ heshe +" has been corrupted, "+ hisher +" mind filled with depraved thoughts. \n\nMaybe "+ heshe +" was looking to take someone for "+ himher  +"self, or maybe "+ hisher +" plan was to be taken by someone stronger than "+ himher  +". Whatever the case, you can see how "+ heshe +" subtly welcomes you to take "+ hisher +" body.";
			case NPCData.CharClass.Politician:
				return "The pathetic politician kneels and bows down. Deep down "+ heshe +" knows "+ heshe +" never had a chance against someone like you, and now that "+ heshe +" has been bested "+ heshe +" is begging you to forbid "+ himher  +", in exchange of "+ hisher +" body.\n\nNonetheless you can see there is a smile on "+ hisher +" face, and how "+ hisher +" face is red, excited. Is "+ heshe +" actually looking forward to this? Maybe "+ heshe +" left the city just for this to happen, since it is clear that corruption has rotten "+ hisher +" mind. \n";
			case NPCData.CharClass.Priest:
				return "The once pure faithful follower of the goddess has fallen. Not just from grace, but to "+ hisher +" knees. With a sinful smile on "+ hisher +" face, "+ heshe +" is begging you to take "+ hisher +" body, opening "+ hisher +" mouth so you can start to defile "+ himher  +" from top to bottom.\n\nWith "+ hisher +" soul already corrupted, the only thing that’s left is to take "+ hisher +" body. ";
			case NPCData.CharClass.Ranger:
				return "When you defeat the skill ranged "+ heshe +" throws "+ hisher +" weapons to the ground, and starts to take "+ hisher +" armour.\n\n"+ HESHE  +" gets naked, and sits on the ground to offer you "+ hisher +" body. You can see that if anything "+ heshe +" was looking forward to this, maybe from the beginning. That’s what happens when you have a submissive nature and a corrupted mind. ";
			case NPCData.CharClass.Scholar:
				return "The scholar was no match for you. Probably "+ heshe +" isn’t a match for anybody, but it’s not like that matters to "+ himher  +", since "+ heshe +" quickly offers "+ hisher +" whole body to be used and ravished, with "+ hisher +" mind full of lustful and corrupted thoughts, "+ hisher +" career as a bright scholar had probably ended time ago.\t\t\n";
			case NPCData.CharClass.Scout:
				return "When you defeat the skill scout "+ heshe +" throws "+ hisher +" weapons to the ground, and starts to take "+ hisher +" armour.\n\n"+ HESHE  +" gets naked, and sits on the ground to offer you "+ hisher +" body. You can see that if anything "+ heshe +" was looking forward to this, maybe from the beginning. That’s what happens when you have a submissive nature and a corrupted mind. ";
			case NPCData.CharClass.Soldier:
				return "When you defeat the skill soldier "+ heshe +" throws "+ hisher +" weapons to the ground, and starts to take "+ hisher +" armour.\n\n"+ HESHE  +" gets naked, and sits on the ground to offer you "+ hisher +" body. You can see that if anything "+ heshe +" was looking forward to this, maybe from the beginning. That’s what happens when you have a submissive nature and a corrupted mind. ";
			case NPCData.CharClass.Thief:
				return "You can only assume that the criminal career of this criminal never was too bright, because "+ heshe +" clearly knows that "+ heshe +" needs to submit to you after being defeated. \n\nThat, or maybe that "+ heshe +" is just a submissive, corrupted whore, but is not like you really care too much about details like that. ";
			case NPCData.CharClass.Warrior:
				return "Although an impressive fighter, the warrior is no match for you. "+ HESHE  +" shows proper respects and yields, offering you "+ hisher +" body as "+ hisher +" tradition commands, or that’s what "+ heshe +" says.\n\nYou’ve never heard about this tradition amongst warriors, but by how aroused "+ heshe +" is you are certain that "+ hisher +" soul has been corrupted, and this is probably just an excused to get used as the submissive bitch that "+ heshe +" is. ";
			case NPCData.CharClass.Whore:
				return "The whore throws her weapon, raises her hands and asks you to stop the fight. She knows "+ heshe +" can’t best you, and asks you for forgiveness in exchange of using her body, admitting that "+ heshe +" has been a naughty girl and needs you to punish her. \n\nWhile you think about it "+ heshe +" keeps making sultry moves, trying to entice you use "+ himher  +" and have a good time.";
			default:
				return "This is a bug in combatvictorytextenemy.cs";
			}



		} else {
			switch (charClass) {
			case NPCData.CharClass.Alchemist:
				return "The studious alchemist is no match for you, and at this point "+ heshe +" regrets that "+ heshe +" didn’t invested more time training in the field. \n\n"+ HESHE  +" has no choice but accept that you’ve bested "+ himher  +", and "+ heshe +" submissively waits for you to decide "+ hisher +" fate. \n";
			case NPCData.CharClass.Artist:
				return "The fashionable artist is no match for your combat skills. Defeated, "+ heshe +" submits to you. \n\nBy "+ hisher +" behavior you know that "+ heshe +" has been able to keep "+ hisher +" soul pure, at least enough.  ";
			case NPCData.CharClass.Barbarian:
				return "The mighty barbarian is a challenging foe, but you end up besting him.\n\nAlthough you expect "+ himher  +" to keep "+ hisher +" feisty attitude, "+ heshe +" submits to you, since is in "+ hisher +" nature to follow a stronger leader than "+ himher  +"self.";				
			case NPCData.CharClass.Bureaucrat:
				return "It’s no surprise that you end up defeating the poor and weak bureaucrat. "+ HESHE  +" quickly submits to you, accepting "+ hisher +" fate without more fight.\n\nStill pure, you wonder for how long "+ heshe +" has been out of the city, but you assume that not for that long. ";
			case NPCData.CharClass.Clerk:
				return "It’s no surprise that you end up defeating the poor and weak clerk. "+ HESHE  +" quickly submits to you, accepting "+ hisher +" fate without more fight.\n\nStill pure, you wonder for how long "+ heshe +" has been out of the city, but you assume that not for that long. ";
			case NPCData.CharClass.CommunityWorker:
				return "It’s no surprise that you end up defeating the poor and weak community worker. "+ HESHE  +" quickly submits to you, accepting "+ hisher +" fate without more fight.\n\nStill pure, you wonder for how long "+ heshe +" has been out of the city, but you assume that not for that long. ";
			case NPCData.CharClass.DarkPaladin:
				return "After a mighty fight you defeat the former dark paladin. Although "+ heshe +" still has a lot of dark knowledge, at some point "+ heshe +" or someone cleansed "+ hisher +" soul.\n\n"+ HESHE  +" submits to you, willing to do as you command.";
			case NPCData.CharClass.Diplomat:
				return "Doesn’t matter how good can this diplomat be at making trade deals, combat isn’t "+ hisher +" forte, and you defeat "+ himher  +" with ease.\n\nNow with "+ hisher +" fate at "+ hisher +" hands, "+ heshe +" submits to you, asking you to forbid "+ himher  +". ";
			case NPCData.CharClass.Enforcer:
				return "The ferocious enforcer is a tough opponent, but nothing you can’t handle. Defeated, "+ heshe +" has no choice but to submit to your will, something that "+ heshe +" eagerly does, since apparently that’s "+ hisher +" nature. ";
			case NPCData.CharClass.Farmer:
				return "The weak farmer is easily defeated by you. "+ HESHE  +" easily submits to you, willing to do anything you ask "+ himher  +" for, although you can see that "+ heshe +" is talking about actual labor and not sex, "+ hisher +" soul and mind still pure.";
			case NPCData.CharClass.Feral:
				if (NPCCharList.CharMonster [0].charRace == NPCData.CharRace.Human) {
					return "It is very weird to find a feral human, but even weirder to find one who hasn’t been corrupted and transformed into a lustful being.\n\n"+ HESHE  +" behaves submissive with you, playfully accepting you as "+ hisher +" new master, and whatever choice you take about "+ hisher +" fate.\t\t\t\t\n";
				} else {
					return "It is very weird to find a feral that hasn’t been tainted by corruption, but apparently this is the case. \n\nThe creature just lies down, waiting for you to act.";
				}
			case NPCData.CharClass.GuildWorker:
				return "The guild worker is easily defeated by you. Used to be exploited in the city, "+ hisher +" will power is crushed, and "+ heshe +" easily submits to you. \n\nYou notice that "+ heshe +" is still poor, and although "+ heshe +" would do whatever you ask "+ heshe +" is still reluctant to do anything close and personal. ";
			case NPCData.CharClass.Infiltrator:
				return "The shady opponent is defeated. Knowing that "+ heshe +" cant escape, "+ heshe +" submits to you.\n\nAlthough he is obviously a criminal, you can see that "+ heshe +" hasn’t been corrupted yet. ";
			case NPCData.CharClass.Inquisitor:
				return "After a mighty fight you defeated the inquisitor. "+ HESHE  +" is proud, and "+ heshe +" can’t in good conscience just give in, but "+ heshe +" knows that you’ve bested "+ himher  +", and has no other choice but to submit to you.\n\nMaybe not so surprising, "+ heshe +" is still uncorrupted, or at least enough to keep "+ hisher +" mind in one piece. ";
			case NPCData.CharClass.Monk:
				return "After a tough fight you defeat the monk. "+ HESHE  +" keeps a relaxed stance, waiting for you to decide about "+ hisher +" fate. \n\nIt is clear that "+ heshe +" keeps "+ hisher +" soul and mind clean of corruption, and that "+ hisher +" spirit is submissive.";
			case NPCData.CharClass.Mystic:
				return "The mystic tries to cast one last spell before you tackle "+ himher  +", shutting "+ hisher +" mouth.\n\nWith no other means to escape, "+ heshe +" gives up and waits for you to decide about "+ hisher +" future. \n\nBy "+ hisher +" somewhat calm and submissive behavior, you realize that "+ heshe +" has not been corrupted yet.";
			case NPCData.CharClass.Paladin:
				return "The mighty paladin its defeated by your might. Although "+ heshe +" is a proud warrior, "+ heshe +" stays calm, waiting for you to decide "+ hisher +" fate.\n\nNot surprising "+ heshe +" is still pure in mind and soul, but in this situation "+ heshe +" could do nothing but to accept whatever you wish, even if its wicked. \t";
			case NPCData.CharClass.Performer:
				return "The fashionable performer is no match for your combat skills. Defeated, "+ heshe +" submits to you. \n\nBy "+ hisher +" behavior you know that "+ heshe +" has been able to keep "+ hisher +" soul pure, at least enough.  ";
			case NPCData.CharClass.Politician:
				return "The weak and cowardly politician quickly submits to you after "+ heshe +" realizes that "+ heshe +" can’t best you, not like there was any chance to begin with. \n\n"+ HESHE  +" offers to do anything you want to spare "+ himher  +", and although "+ hisher +" soul isn’t corrupted by esoteric means, well, "+ heshe +" is a politician, so is this really a surprise? ";
			case NPCData.CharClass.Priest:
				return "The holy figure is no match in combat against you.\n\nWith little to no choice, "+ heshe +" sits and waits for you to decide "+ hisher +" fate. You can see that "+ heshe +" is docile, submissive, but also that "+ heshe +" still keeps "+ hisher +" soul pure, so "+ heshe +" may not be as eager to submit to wicked acts. ";
			case NPCData.CharClass.Ranger:
				return "The skilled ranger has many tricks under "+ hisher +" sleeves, but you manage to defeat "+ himher  +".\n\nEven though you disarmed "+ himher  +" you tie "+ himher  +" up, just to make sure "+ heshe +" doesn’t tries to attack you again, but to your surprise he is very docile. \n\nYou assess "+ himher  +" and believe that "+ heshe +" is still pure, or at least "+ heshe +" hasn’t attempt any lewd action to try to escape "+ hisher +" predicament. ";
			case NPCData.CharClass.Scholar:
				return "The pen is mightier than the sword, but only in theory. \n\nYou have no trouble submitting the weak scholar, who’s will to fight is null. You can see that "+ hisher +" mind is still clean from corruption, and is still able to focus on something else than perverse thoughts.";
			case NPCData.CharClass.Scout:
				return "The skilled scout has many tricks under "+ hisher +" sleeves, but you manage to defeat "+ himher  +".\n\nEven though you disarmed "+ himher  +" you tie "+ himher  +" up, just to make sure "+ heshe +" doesn’t tries to attack you again, but to your surprise he is very docile. \n\nYou assess "+ himher  +" and believe that "+ heshe +" is still pure, or at least "+ heshe +" hasn’t attempt any lewd action to try to escape "+ hisher +" predicament.";
			case NPCData.CharClass.Soldier:
				return "A skilled and agile soldier is always a challenge, but "+ heshe +" would benefit from being in formation with an unit, instead of on "+ hisher +" own. \n\nDefeated, you tie "+ himher  +" down and start to think what to do with "+ himher  +". By "+ hisher +" tame behavior, you know that "+ heshe +" will be easy to handle and that "+ heshe +" is not corrupt.";
			case NPCData.CharClass.Thief:
				return "The criminal is promptly defeated by you, not a real match for your combat skills.\n\n"+ HESHE  +" begs you for mercy, willing to submit to your whims. \n\nYou inspect "+ himher  +" and assess that, at least for now, "+ heshe +" is free from corruption, at least the supernatural one. ";
			case NPCData.CharClass.Warrior:
				return "The valiant warrior fights with all of "+ hisher +" might, but cant match you in the end.\n\n"+ HESHE  +" kneels in front of you, accepting that you’ve bested "+ himher  +", and is willing to do as you wish, since you’ve earned that right.\n\nYou’re happy to see that "+ heshe +" has managed to fend off corruption until now, and keeps "+ hisher +" traditions alive. ";
			case NPCData.CharClass.Whore:
				return "Unsurprisingly you take "+ himher  +" down, since "+ hisher +" skills are not really great for combat. \n\n"+ HESHE  +" quickly submits to you, eager to please you if you forbid "+ himher  +". Although "+ hisher +" soul hasn’t been corrupted by magical means, "+ heshe +"’s a natural slut.";
			default:
				return "This is a bug in combatvictorytextenemy.cs";
			}

		}
	}







	static string textTemplate(){
		NPCData.CharClass charClass = NPCCharList.CharMonster [0].charClass;

		if (NPCCharList.CharMonster [0].attWillpower > 50) {
			if (NPCCharList.CharMonster [0].charCorruption > 50) {
				switch (charClass) {
				case NPCData.CharClass.Alchemist:
					return "";
				case NPCData.CharClass.Artist:
					return "";
				case NPCData.CharClass.Barbarian:
					return "";				
				case NPCData.CharClass.Bureaucrat:
					return "";
				case NPCData.CharClass.Clerk:
					return "";
				case NPCData.CharClass.CommunityWorker:
					return "";
				case NPCData.CharClass.DarkPaladin:
					return "";
				case NPCData.CharClass.Diplomat:
					return "";
				case NPCData.CharClass.Enforcer:
					return "";
				case NPCData.CharClass.Farmer:
					return "";
				case NPCData.CharClass.Feral:
					return "";
				case NPCData.CharClass.GuildWorker:
					return "";
				case NPCData.CharClass.Infiltrator:
					return "";
				case NPCData.CharClass.Inquisitor:
					return "";
				case NPCData.CharClass.Monk:
					return "";
				case NPCData.CharClass.Mystic:
					return "";
				case NPCData.CharClass.Paladin:
					return "";
				case NPCData.CharClass.Performer:
					return "";
				case NPCData.CharClass.Politician:
					return "";
				case NPCData.CharClass.Priest:
					return "";
				case NPCData.CharClass.Ranger:
					return "";
				case NPCData.CharClass.Scholar:
					return "";
				case NPCData.CharClass.Scout:
					return "";
				case NPCData.CharClass.Soldier:
					return "";
				case NPCData.CharClass.Thief:
					return "";
				case NPCData.CharClass.Warrior:
					return "";
				case NPCData.CharClass.Whore:
					return "";
				default:
					return "This is a bug in combatvictorytextenemy.cs";
				}
			} else {
				switch (charClass) {
				case NPCData.CharClass.Alchemist:
					return "";
				case NPCData.CharClass.Artist:
					return "";
				case NPCData.CharClass.Barbarian:
					return "";				
				case NPCData.CharClass.Bureaucrat:
					return "";
				case NPCData.CharClass.Clerk:
					return "";
				case NPCData.CharClass.CommunityWorker:
					return "";
				case NPCData.CharClass.DarkPaladin:
					return "";
				case NPCData.CharClass.Diplomat:
					return "";
				case NPCData.CharClass.Enforcer:
					return "";
				case NPCData.CharClass.Farmer:
					return "";
				case NPCData.CharClass.Feral:
					return "";
				case NPCData.CharClass.GuildWorker:
					return "";
				case NPCData.CharClass.Infiltrator:
					return "";
				case NPCData.CharClass.Inquisitor:
					return "";
				case NPCData.CharClass.Monk:
					return "";
				case NPCData.CharClass.Mystic:
					return "";
				case NPCData.CharClass.Paladin:
					return "";
				case NPCData.CharClass.Performer:
					return "";
				case NPCData.CharClass.Politician:
					return "";
				case NPCData.CharClass.Priest:
					return "";
				case NPCData.CharClass.Ranger:
					return "";
				case NPCData.CharClass.Scholar:
					return "";
				case NPCData.CharClass.Scout:
					return "";
				case NPCData.CharClass.Soldier:
					return "";
				case NPCData.CharClass.Thief:
					return "";
				case NPCData.CharClass.Warrior:
					return "";
				case NPCData.CharClass.Whore:
					return "";
				default:
					return "This is a bug in combatvictorytextenemy.cs";
				}
			}
		} else {
			if (NPCCharList.CharMonster [0].charCorruption > 50) {
				switch (charClass) {
				case NPCData.CharClass.Alchemist:
					return "";
				case NPCData.CharClass.Artist:
					return "";
				case NPCData.CharClass.Barbarian:
					return "";				
				case NPCData.CharClass.Bureaucrat:
					return "";
				case NPCData.CharClass.Clerk:
					return "";
				case NPCData.CharClass.CommunityWorker:
					return "";
				case NPCData.CharClass.DarkPaladin:
					return "";
				case NPCData.CharClass.Diplomat:
					return "";
				case NPCData.CharClass.Enforcer:
					return "";
				case NPCData.CharClass.Farmer:
					return "";
				case NPCData.CharClass.Feral:
					return "";
				case NPCData.CharClass.GuildWorker:
					return "";
				case NPCData.CharClass.Infiltrator:
					return "";
				case NPCData.CharClass.Inquisitor:
					return "";
				case NPCData.CharClass.Monk:
					return "";
				case NPCData.CharClass.Mystic:
					return "";
				case NPCData.CharClass.Paladin:
					return "";
				case NPCData.CharClass.Performer:
					return "";
				case NPCData.CharClass.Politician:
					return "";
				case NPCData.CharClass.Priest:
					return "";
				case NPCData.CharClass.Ranger:
					return "";
				case NPCData.CharClass.Scholar:
					return "";
				case NPCData.CharClass.Scout:
					return "";
				case NPCData.CharClass.Soldier:
					return "";
				case NPCData.CharClass.Thief:
					return "";
				case NPCData.CharClass.Warrior:
					return "";
				case NPCData.CharClass.Whore:
					return "";
				default:
					return "This is a bug in combatvictorytextenemy.cs";
				}
			} else {
				switch (charClass) {
				case NPCData.CharClass.Alchemist:
					return "";
				case NPCData.CharClass.Artist:
					return "";
				case NPCData.CharClass.Barbarian:
					return "";				
				case NPCData.CharClass.Bureaucrat:
					return "";
				case NPCData.CharClass.Clerk:
					return "";
				case NPCData.CharClass.CommunityWorker:
					return "";
				case NPCData.CharClass.DarkPaladin:
					return "";
				case NPCData.CharClass.Diplomat:
					return "";
				case NPCData.CharClass.Enforcer:
					return "";
				case NPCData.CharClass.Farmer:
					return "";
				case NPCData.CharClass.Feral:
					return "";
				case NPCData.CharClass.GuildWorker:
					return "";
				case NPCData.CharClass.Infiltrator:
					return "";
				case NPCData.CharClass.Inquisitor:
					return "";
				case NPCData.CharClass.Monk:
					return "";
				case NPCData.CharClass.Mystic:
					return "";
				case NPCData.CharClass.Paladin:
					return "";
				case NPCData.CharClass.Performer:
					return "";
				case NPCData.CharClass.Politician:
					return "";
				case NPCData.CharClass.Priest:
					return "";
				case NPCData.CharClass.Ranger:
					return "";
				case NPCData.CharClass.Scholar:
					return "";
				case NPCData.CharClass.Scout:
					return "";
				case NPCData.CharClass.Soldier:
					return "";
				case NPCData.CharClass.Thief:
					return "";
				case NPCData.CharClass.Warrior:
					return "";
				case NPCData.CharClass.Whore:
					return "";
				default:
					return "This is a bug in combatvictorytextenemy.cs";
				}
			}
		}
	}


}
