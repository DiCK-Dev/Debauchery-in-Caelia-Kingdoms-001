 using UnityEngine;
using System.Collections;

public class CombatDefeatText {



	public static string defeatText(int selector){
		switch (selector) {
		case 0:
			return CombatTextsEnemy.textDefeat ();
			// I need a generic like return combatEnemyDescriptionTexts.genericEnemyDescription ();
		case 13000:
			if (QuestControl.albaHelp) {
				return "She defeats you, and leaves you unconscious on the ground. When you recover, you can hear Alba asking if you are okay. <i>“"+ GameControl.playerName +"? "+ GameControl.playerName +"? Are you still alive?”</i> You head is pounding, but you manage to nod. <i>“That’s great, we took care of the minotaur. It was a fierce battle, so you should be glad that we arrived just in time to save your ass.”</i>\n\n\nShe commands her soldiers to surround the monster. <i>“Go on "+ GameControl.playerName +", give the order to finish her off.”</i> The injured minotaur tries to stand up, but the soldiers keep her in her place. <i>“No! Don’t do that! Take me as your prisoner, I’ll be your slave, but please don't do that!”</i>\n\nAlba walks around her, examining her body. <i>“Well, she is certainly strong. She could be a great slave for labor, although I do have other uses for her in mind. What you think, "+ GameControl.playerName +"?”</i>\n\nBoth of them look at you, anxious for your answer. Should you capture her and enslave her, or is she too dangerous, and should be put down?\n";	
			} else {
				return "She leaves you unconscious on the ground. When recover, the first thing you hear is Alba calling out to you. <i>“"+ GameControl.playerName +"? "+ GameControl.playerName +"? Come on, wake up. We took care of her for you.”</i>\n\nWhen you open your eyes, you see the girl tied up and begging for mercy <i>“I yield! Please!”</i> defeated, she kneels awkwardly in front of you. You can see that Alba’s soldiers have also taken care of the other brigands. <i>“Please spare my life! I’ll do anything, I’ll become your slave, please just let me live!”</i> Alba looks at you <i>“Well I did capture her, but I’ll leave her fate in your hands. I don’t really care about what you do with her.”</i> \n\nYou consider your options for a few minutes until Alba interrupts you again. <i>“If you want my opinion, enslaving her would be fun, and it will teach the population to not mess with you. But if you don’t want to deal with her, or any of the trouble she might cause, just let her body rot in this place. It’s not like she doesn’t deserve it..”</i> Upon hearing those words, the thief begins to crawl desperately towards you. <i>“No! Don’t listen to her! I’ll be nice, I swear!”</i> Alba kicks out at her, annoyed. <i>“These disgusting people. Come on, die with some dignity!”</i>\n\nBoth of them look at you, anxious for an answer.";
			}
		default:
			return "You have been defeated! Should you yield or escape?";

		}


	}

}
