using UnityEngine;
using System.Collections;

public class CombatVictoryText {




	public static string victoryText(int selector){
		switch (selector) {
		case 0:
			return CombatVictoryTextsReward.textReward(CombatRewards.enemyReward());

		case 13000:
			if (QuestControl.albaHelp) {
				return "When she realizes that the combat is over, she tries to retreat, but you cut in front of her way out. <i>“No, please! I yield!”</i> she is kneeling in front of you begging for forgiveness when Alba and her soldiers finally arrive. \n\n<i>“Amazing, I must admit that I’m impressed "+ GameControl.playerName +". Taking this beast out by yourself.”</i> She commands her soldiers to surround the monster. <i>“Go on "+ GameControl.playerName +", give the order to finish her off.”</i> The injured minotaur tries to stand up, but the soldiers keep her in her place. <i>“No! Don’t do that! Take me as your prisoner, I’ll be your slave, but please don't do that!”</i>\n\nAlba walks around her, examining her body. <i>“Well, she is certainly strong. She could be a great slave for labor, although I do have other uses for her in mind. What you think, "+ GameControl.playerName +"?”</i>\n\nBoth of them look at you, anxious for your answer. Should you capture her and enslave her, or is she too dangerous, and should be put down?\n";
			} else {
				return "<i>“I yield! Please!”</i> Defeated, the thief kneels in front of you. You can see your soldiers have also taken care of the other brigands. <i>“Please spare my life! I’ll do anything! I’ll become your slave, just please let me live!”</i> You consider your options for a few minutes, until Alba comes back\n\n<i>“So, you already took care of them? Good job "+ GameControl.playerName +", you’ve surprised me.”</i> Alba walks towards the girl, examining her <i>“So, I overheard what she said to you... What’re you gonna do? Enslaving her would be fun, and it will teach the population not to mess with you. But if you don’t want to deal with her, or any of the trouble she might cause, just let her body rot in this place. It’s not like she doesn’t deserve it.”</i> Upon hearing those words, the thief begins to crawl desperately towards you. <i>“No! Don’t listen to her! I’ll be nice, I swear!”</i> Alba kicks out at her, annoyed. <i>“These disgusting people. Come on, die with some dignity!”</i>\n\nBoth of them look at you, anxious for an answer.";
			}
		default:
			return "You stand victorious! Time to decide what to do with the spoils of war. ";

		}


	}



}
