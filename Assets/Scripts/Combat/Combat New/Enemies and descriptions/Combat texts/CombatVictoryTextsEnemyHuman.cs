using UnityEngine;
using System.Collections;

public class CombatVictoryTextsEnemyHuman {


	public static string enemyHumanVictory(){
		NPCData.CharClass charClass = NPCCharList.CharMonster [0].charClass;

		if (NPCCharList.CharMonster [0].attWillpower > 50) {
			if (NPCCharList.CharMonster [0].charCorruption > 50) {
				switch (charClass) {
				case NPCData.CharClass.Alchemist:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Artist:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Barbarian:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Bureaucrat:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Clerk:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.CommunityWorker:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.DarkPaladin:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Diplomat:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Enforcer:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Farmer:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Feral:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.GuildWorker:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Infiltrator:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Inquisitor:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Monk:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Mystic:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Paladin:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Performer:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Politician:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Priest:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Ranger:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Scholar:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Scout:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Soldier:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Thief:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Warrior:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Whore:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				default:
					return "This is a bug in combatvictorytextenemy.cs";
				}
			} else {
				switch (charClass) {
				case NPCData.CharClass.Alchemist:
					return "You just defeated an dominant, pure " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Artist:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Barbarian:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Bureaucrat:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Clerk:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.CommunityWorker:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.DarkPaladin:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Diplomat:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Enforcer:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Farmer:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Feral:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.GuildWorker:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Infiltrator:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Inquisitor:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Monk:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Mystic:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Paladin:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Performer:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Politician:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Priest:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Ranger:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Scholar:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Scout:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Soldier:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Thief:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Warrior:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				case NPCData.CharClass.Whore:
					return "You just defeated an dominant, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
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

	public static string enemyHumanDefeat(){
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
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Artist:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Barbarian:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				
				case NPCData.CharClass.Bureaucrat:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Clerk:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.CommunityWorker:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.DarkPaladin:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Diplomat:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Enforcer:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Farmer:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Feral:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.GuildWorker:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Infiltrator:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Inquisitor:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Monk:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Mystic:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Paladin:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Performer:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Politician:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Priest:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Ranger:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Scholar:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Scout:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Soldier:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Thief:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Warrior:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Whore:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				default:
					return "This is a bug in combatvictorytextenemy.cs";
				}
			} else {
				switch (charClass) {
				case NPCData.CharClass.Alchemist:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Artist:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Barbarian:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;
				
				case NPCData.CharClass.Bureaucrat:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Clerk:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.CommunityWorker:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.DarkPaladin:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Diplomat:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Enforcer:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Farmer:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Feral:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.GuildWorker:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Infiltrator:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Inquisitor:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Monk:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Mystic:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Paladin:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Performer:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Politician:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Priest:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Ranger:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Scholar:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Scout:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Soldier:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Thief:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Warrior:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				case NPCData.CharClass.Whore:
										return "You just defeated an submissive, corrupt " +  NPCCharList.CharMonster [0].charClass.ToString() ;

				default:
					return "This is a bug in combatvictorytextenemy.cs";
				}
			}
		}
	}


}
