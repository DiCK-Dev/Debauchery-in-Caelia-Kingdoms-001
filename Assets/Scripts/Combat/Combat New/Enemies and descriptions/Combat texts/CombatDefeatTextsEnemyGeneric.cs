using UnityEngine;
using System.Collections;

public class CombatDefeatTextsEnemyGeneric {


	public static string defeatGeneric(){
		string toRet;
		int randNum;

		string heshe = "he", hisher = "his", himher = "him", HESHE = "He", HISHER = "His";

		if (NPCCharList.CharMonster [0].charGender == NPCData.CharGender.FEMALE) {
			heshe = "she"; hisher = "her"; himher = "him"; HESHE = "She"; HISHER = "Her";
		}

		if (NPCCharList.CharMonster [0].charCorruption >= 50) {
			NPCData.CharClass charClass = NPCCharList.CharMonster [0].charClass;
			switch (charClass) {
			case NPCData.CharClass.Alchemist:
				return "You were no match for such a powerful alchemist! You can see a deviant smile across "+ hisher +" face, who knows what "+ heshe +" has in mind for you, but it can’t be good!\n\n"+ HESHE +" walks towards you, but "+ heshe +" is distracted, looking for something in a pouch, do you want to use this opportunity to escape? Or yield to "+ himher +"?";
			case NPCData.CharClass.Artist:
				return "Defeated by an artist! Such a shame! And by the look on "+ hisher +" face, who knows what deviant thing "+ heshe +" is about to do to you!\n\nStill, "+ heshe +" is so fascinated by the fact that "+ heshe +" won a fight, that "+ heshe +" is day dreaming about what to do to you, an opportunity that you can use to escape! \n";
			case NPCData.CharClass.Barbarian:
				return "After a fierce fight you end up bested by the barbarian. No shame in that, "+ heshe +" lives to fight, and this is what "+ heshe +" lives for.\n\nYou can see how "+ heshe +" is corrupted, and is thinking about how to abuse you now, but while "+ heshe +" fantasizes about what’s next, you see a small window of opportunity to escape from "+ hisher +" grasp. ";				
			case NPCData.CharClass.Bureaucrat:
				return "The perverse bureaucrat can’t believe that "+ heshe +" won a fight, and for that matter, you either. While "+ heshe +" celebrates and thinks about how much fun "+ heshe +" will have with your body now, you have plenty opportunities to just stand up and leave before "+ heshe +" even notices. \n";
			case NPCData.CharClass.Clerk:
				return "The perverse clerk can’t believe that "+ heshe +" won a fight, and for that matter, you either. While "+ heshe +" celebrates and thinks about how much fun "+ heshe +" will have with your body now, you have plenty opportunities to just stand up and leave before "+ heshe +" even notices. \n";
			case NPCData.CharClass.CommunityWorker:
				return "The perverse community worker can’t believe that "+ heshe +" won a fight, and for that matter, you either. While "+ heshe +" celebrates and thinks about how much fun "+ heshe +" will have with your body now, you have plenty opportunities to just stand up and leave before "+ heshe +" even notices.";
			case NPCData.CharClass.DarkPaladin:
				return "After an intense fight, the dark paladin bests you. You can "+ hisher +" powerful corrupt aura, and who knows what "+ heshe +" is about to do to you. \n\nThankfully, the goddess of luck is on your side, and a big boar appears and starts to attack "+ himher +". Of course the animal is no match for the skilled fighter, but this gives you a chance to escape from your fate.\n";
			case NPCData.CharClass.Diplomat:
				return "The skilled diplomat may not be a formidable foe, but "+ heshe +" has managed to best you.\n\nNow, who knows what sadistic ideas "+ heshe +" has in "+ hisher +" mind, but you can see how "+ heshe +" is getting ready to use you in many ways. \n\nThankfully, the fight has been too much for "+ himher +" and you see that "+ heshe +" is out of breath, an opportunity you can use to escape.\n";
			case NPCData.CharClass.Enforcer:
				return "The fierce fight with the enforcer ends with your defeat. Almost crippled, you can’t really do much to avoid your fate, and you can see how "+ heshe +" is getting ready to continue with "+ hisher +" police brutality. \n\nBut you’re lucky, before "+ heshe +" gets to you "+ heshe +" is attacked by a wild wolf, although you’re battered, you can use this opportunity to escape. ";
			case NPCData.CharClass.Farmer:
				return "To your surprise the farmer has managed to defeat you in combat! Not only that, but it is clear that "+ heshe +" has a naughty mind, "+ hisher +" soul already corrupted.\n\n"+ HESHE +" has tied you and now is thinking about what to do. Thankfuly, "+ heshe +" is very clumsy, not really used to do this kind of things, an opportunity that you could use to escape from "+ hisher +" grasp.\n";
			case NPCData.CharClass.Feral:
				return "You’ve been defeated by a filthy feral! Now who knows what this creature will do to you, but you can only imagine!\n\nThere is no doubt that "+ heshe +" is corrupt, "+ hisher +" naked body already aroused and ready to get "+ hisher +" way with you. Nonetheless, you aren’t tied and "+ heshe +" isn’t particularly alert to what you’re doing, so you could probably escape from "+ hisher +" grasp. \n\n";
			case NPCData.CharClass.GuildWorker:
				return "The guild worker has take you down! A surprise for both of you! \n\n"+ HESHE +" is thinking about what to do with you now, but "+ heshe +" isn’t used to deal with prisoners, and you find plenty of opportunities to escape. ";
			case NPCData.CharClass.Infiltrator:
				return "The shady and corrupt infiltrator defeats you using "+ hisher +" gimmicks. Now that you are at "+ hisher +" mercy, you really can expect only the worst, but you still could attempt to struggle one last time and escape from "+ hisher +" grasp. \n";
			case NPCData.CharClass.Inquisitor:
				return "The corrupt inquisitor smiles, thinking about what "+ heshe +" is about to do with you. \n\nYou really can’t do much to help yourself, nonetheless fate is on your side: A brigand appears from the shadows and starts to attack "+ himher +", probably an old foe that have been waiting for an opportunity to strike the malevolent fiend.\n\nWhile your captor is distracted you can use this chance to escape!";
			case NPCData.CharClass.Monk:
				return "The corrupt monk is smiling, what "+ heshe +" has in "+ hisher +" mind? Who knows, but you know it’s not going to be a lesson about kindness and love. \n\nBut thankfully for you "+ heshe +" sits down and starts to meditate, probably a ritual that "+ heshe +" usually does before engaging in wicked acts. \n\nNo doubt "+ heshe +" is used to deal with the mindless beasts of the forest, because even though "+ heshe +" has tied you well, you know you can manage to escape while "+ heshe +" isn’t paying attention. ";
			case NPCData.CharClass.Mystic:
				return "You were no challenge for such a powerful mystic. Now that you are at "+ hisher +" mercy, "+ heshe +" shows "+ hisher +" perverted face, and no doubt that "+ heshe +" will love to abuse you in many ways. \n\nBut lucky you, "+ heshe +" is too tired after the battle: "+ HESHE +" ties you up and turns around to meditate and recover some of "+ hisher +" strength. \n\nYou’re glad that "+ heshe +" used a normal rope to tie you instead of magic, and "+ hisher +" lack of experience using a primitive method to capture someone is showing: you could easily escape while "+ heshe +" is distracted.";
			case NPCData.CharClass.Paladin:
				return "Your struggle with the Paladin comes to an end after a swift blow to your head. \n\nStunned, you can see "+ hisher +" lewd face once "+ heshe +" removes "+ hisher +" helmet, no doubt "+ heshe +" has fallen to corruption.\n\n"+ HESHE +" is about to abuse you, but "+ heshe +" falls on "+ hisher +" knees for a moment: Is this an act of one of the goddess? Maybe a punishment for "+ hisher +" deviation? Whatever the case, it gives you the chance to turn around and escape.";
			case NPCData.CharClass.Performer:
				return "Defeated by an performer! Such a shame! And by the look on "+ hisher +" face, who knows what deviant thing "+ heshe +" is about to do to you!\n\nStill, "+ heshe +" is so fascinated by the fact that "+ heshe +" won a fight, that "+ heshe +" is day dreaming about what to do to you, an opportunity that you can use to escape! ";
			case NPCData.CharClass.Politician:
				return "Defeated by a politician! You’ve never feel such shame before! And "+ heshe +" has never felt so proud either! \n\nBy the look on "+ hisher +" face you can tell that "+ heshe +" is corrupt, and not in the political way, but "+ hisher +" soul is actually filled with lust. \n\n"+ HESHE +" jumps at you and starts to grope you, but "+ heshe +" is tired and can barely hold you up. If you wish, you could easily escape from "+ himher +". ";
			case NPCData.CharClass.Priest:
				return "With the help of "+ hisher +" goddess you’ve been defeated! \n\nBut to which kind of goddess does "+ heshe +" prays? You can see how "+ heshe +" smiles while getting undressed, ready to ravage you. \n\n"+ HESHE +" starts to perform a small ritual to thank "+ hisher +" goddess. You could, of course, respectfully stay until "+ heshe +" is done with it and accept what "+ heshe +" is about to give you, but you could also just escape before "+ heshe +" is finished. \n";
			case NPCData.CharClass.Ranger:
				return "The skilled ranger takes you down! You can see a perverted smile across "+ hisher +" face, "+ hisher +" corruption showing.\n\nYou know that you’re about to be used, but before that happens "+ heshe +" is interrupted by another brigand that’s been hiding, probably waiting for you two to be done and weaken for "+ himher +" to take all the spoils. \n\nWhatever the case, this is an opportunity that you can use to escape! ";
			case NPCData.CharClass.Scholar:
				return "Amusingly you’ve been bested by a scholar. "+ HESHE +" is happy, taunting you with stupid phrases like “The pen is mightier than the sword, uh?” Well, you can’t blame "+ himher +", it’s probably "+ hisher +" first time actually defeating anyone!\n\n"+ HESHE +" is celebrating this fact too much, and you could easily sucker punch "+ himher +" and escape from this situation if you want.";
			case NPCData.CharClass.Scout:
				return "The skilled scout takes you down! You can see a perverted smile across "+ hisher +" face, "+ hisher +" corruption showing.\n\nYou know that you’re about to be used, but before that happens "+ heshe +" is interrupted by another brigand that’s been hiding, probably waiting for you two to be done and weaken for "+ himher +" to take all the spoils. \n\nWhatever the case, this is an opportunity that you can use to escape! \t";
			case NPCData.CharClass.Soldier:
				return "The skilled soldier takes you down! You can see a perverted smile across "+ hisher +" face, "+ hisher +" corruption showing.\n\nYou know that you’re about to be used, but before that happens "+ heshe +" is interrupted by another brigand that’s been hiding, probably waiting for you two to be done and weaken for "+ himher +" to take all the spoils. \n\nWhatever the case, this is an opportunity that you can use to escape! \t\t\t\t\t\n";
			case NPCData.CharClass.Thief:
				return "The lowlife criminal manages to defeat you using dirty tricks and tactics!\n\nThere is no doubt that such foul and corrupt creature is ready to abuse you, but lucky for you "+ hisher +" greed is too much, and "+ heshe +" takes a moment to count the spoils that "+ heshe +" just got, an opportunity that you can use to escape! ";
			case NPCData.CharClass.Warrior:
				return "The powerful warrior has defeated you in combat! All "+ hisher +" training and experience made "+ himher +" a formidable foe, and now you are at "+ hisher +" mercy.\n\nYou don’t know their traditions very well, but you are certain that undressing and getting lube shouldn’t be one of them, leaving you no doubt that "+ heshe +" is corrupt and about to wreck you!\n\nStill, "+ heshe +" is too busy oiling "+ himher +"self out, that you may use this brief chance to escape!";
			case NPCData.CharClass.Whore:
				return "There is no shame on being defeated by a whore.\n\nWell, there is, but there’s nothing you can do about it right now. After an intense battle, the corrupt prostitute is looking forward to release "+ hisher +" stress with your body, but thankfully she isn't good at dealing with prisoners, and you know that you could sneak away from "+ hisher +" grasp before its too late.";
			default:
				return "This is a bug in combatvictorytextenemy.cs";
			}
		} else {
			NPCData.CharClass charClass = NPCCharList.CharMonster [0].charClass;
			switch (charClass) {
			case NPCData.CharClass.Alchemist:
				toRet = "Although "+ heshe +" doesn’t has lewd intentions, "+ heshe +" definitely will use this opportunity to experiment with you.\n\n"+ HESHE +" ties you up and before you can react, "+ heshe +" forces you to drink a potion. ";
				toRet += "\n\n" + CombatDefeatTextsTransformation.mcForcedTransformation ();
				return toRet;
			case NPCData.CharClass.DarkPaladin:
				return ""+ HISHER +" instinct is to take you down and has "+ hisher +" way with you, but since "+ hisher +" soul has been cleansed "+ heshe +" doesn’t can do that, and instead asks you to leave. ";
			case NPCData.CharClass.Inquisitor:
				GameControl.charCorruption -= UnityEngine.Random.Range (1, 5);
				return "Defeated, the inquisitor takes matters on "+ hisher +" own hands and starts to perform a ritual on you, purifying your soul against your own will!\n\nWhen "+ heshe +" is done, "+ heshe +" lets you go unscathed... beyond the injures you received during combat, of course.\n\n";
			case NPCData.CharClass.Monk:
				GameControl.charCorruption -= UnityEngine.Random.Range (1, 5);
				return "When the battle is over the monk forces you to sit with "+ himher +" and meditate. Although you don’t initially want to, a feeling of peace soon fills your soul, and you stay with "+ himher +" for an hour before "+ heshe +" lets you go, your soul purer than before. \n";
			case NPCData.CharClass.Paladin:
				GameControl.charCorruption -= UnityEngine.Random.Range (1, 5);
				return "The white knight starts to perform a ritual on you after "+ heshe +" has defeated you, praying for your soul.\n\nAfter a moment, you start to feel different, and your soul starts to get cleansed from evil thoughts. \n\nOnce "+ heshe +" is done, "+ heshe +" lets you go. ";
			case NPCData.CharClass.Priest:
				GameControl.charCorruption -= UnityEngine.Random.Range (1, 5);
				return "The holy figure starts to perform a ritual on you after "+ heshe +" has defeated you, praying for your soul.\n\nAfter a moment, you start to feel different, and your soul starts to get cleansed from evil thoughts. \n\nOnce "+ heshe +" is done, "+ heshe +" lets you go. ";
			case NPCData.CharClass.Thief:
				randNum = UnityEngine.Random.Range (10, 120);
				GameControl.charGold -= randNum;
				return "When the criminal is done with you "+ heshe +" quickly takes one of your pouches with gold and runs away, knowing that other beasts and bandits will soon come here. \n\nYou lost "+ randNum.ToString() +" gold";
			case NPCData.CharClass.Whore:
				randNum = UnityEngine.Random.Range (10, 120);
				GameControl.charGold -= randNum;
				return "When the whore is done with you "+ heshe +" quickly takes one of your pouches with gold and runs away, knowing that other beasts and bandits will soon come here. \n\nYou lost "+ randNum +" gold.";
			default:
				return "You’ve been defeated by the "+ NPCCharList.CharMonster[0].charClass.ToString() +". Although you expect the worst from "+ himher +", "+ heshe +" really isn’t interested on doing anything to you, maybe because "+ hisher +" soul is still pure, or wants to escape knowing that the battle you two just had will probably attract predators and bandits. ";
			}
		}


	

	}





}
