using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemData : MonoBehaviour {


	public int itemID; 
	public string itemName;
	public string itemDescription;
	public int itemCost; 
	public string itemUseText; 

	public static Dictionary<int, ItemData> itemDataList = new Dictionary<int, ItemData>(); 



	public ItemData(int itemId, string itemname, string itemdescription, int itemcost, string itemusetext){
		itemID = itemId;
		itemName = itemname;
		itemDescription = itemdescription;
		itemCost = itemcost; // sell price
		itemUseText = itemusetext; 

	}



	void startLibrary(){

		//100 a 999 consumables 

		//breast 100-104
		ItemData Item0 = new ItemData (0, "Empty", "", 0, ""); 
		itemDataList.Add (0, Item0); 

		ItemData Item100 = new ItemData (100, "weak Udder Max", "A bottle that has the form of a very voluptuous woman holding her two enormous breasts.", 15, ""); 
		itemDataList.Add (100, Item100); 

		ItemData Item101 = new ItemData (101, "Udder Max", "A bottle that has the form of a very voluptuous woman holding her two enormous breasts.", 15, ""); 
		itemDataList.Add (101, Item101); 

		ItemData Item102 = new ItemData (102, "Strong Udder Max", "A bottle that has the form of a very voluptuous woman holding her two enormous breasts.", 250, ""); 
		itemDataList.Add (102, Item102); 
		/*
		ItemData Item103 = new ItemData (103, "Dick reducion potion", "This is a balls potion that increases breasts", 2300, ""); 
		itemDataList.Add (103, Item103); 

		ItemData Item104 = new ItemData (104, "Testicles increase potion", "This is a vagina potion that increases breasts", 10, ""); 
		itemDataList.Add (104, Item104); 
		*/

		//Dick 105-109
		ItemData Item105 = new ItemData (105, "weak Virilitax", "The bottle has the form of a man sporting an enormous cock, very proud of himself.", 10, ""); 
		itemDataList.Add (105, Item105); 

		ItemData Item106 = new ItemData (106, "Virilitax", "The bottle has the form of a man sporting an enormous cock.", 15, ""); 
		itemDataList.Add (106, Item106); 

		ItemData Item107 = new ItemData (107, "Strong Virilitax", "The bottle has the form of a man sporting an enormous cock.", 15, ""); 
		itemDataList.Add (107, Item107); 
		/*
		ItemData Item108 = new ItemData (108, "Height increase potion", "This is a vagina potion that increases breasts", 10, ""); 
		itemDataList.Add (108, Item108); 

		ItemData Item109 = new ItemData (109, "Height increase potion", "This is a vagina potion that increases breasts", 10, ""); 
		itemDataList.Add (109, Item109); 
		*/

		// testicles 110-114
		ItemData Item110 = new ItemData (110, "weak Ale of Gallantry", "The bottle has the print of a man posing proud of his two, enormous testicles. The instructions say that you need a penis for this to work.", 10, ""); 
		itemDataList.Add (110, Item110); 

		ItemData Item111 = new ItemData (111, "Ale of Gallantry", "The bottle has the print of a man posing proud of his two, enormous testicles. The instructions say that you need a penis for this to work.", 15, ""); 
		itemDataList.Add (111, Item111); 

		ItemData Item112 = new ItemData (112, "Strong Ale of Gallantry", "The bottle has the print of a man posing proud of his two, enormous testicles. The instructions say that you need a penis for this to work.", 10, ""); 
		itemDataList.Add (112, Item112); 

		/*
		ItemData Item113 = new ItemData (113, "Height increase potion", "This is a vagina potion that increases breasts", 10, ""); 
		itemDataList.Add (113, Item113); 

		ItemData Item114 = new ItemData (114, "Height increase potion", "This is a vagina potion that increases breasts", 10, ""); 
		itemDataList.Add (114, Item114); 
		*/
		// more height
		ItemData Item115 = new ItemData (115, "weak Gigantus tonic", "The bottle has the print of a person that's as big as a mountain", 10, ""); 
		itemDataList.Add (115, Item115); 

		ItemData Item116 = new ItemData (116, "Gigantus tonic", "The bottle has the print of a person that's as big as a mountain", 15, ""); 
		itemDataList.Add (116, Item116); 

		ItemData Item117 = new ItemData (117, "Strong Gigantus tonic", "The bottle has the print of a person that's as big as a mountain", 10, ""); 
		itemDataList.Add (117, Item117); 

		// less height
		ItemData Item120 = new ItemData (120, "weak Pigmy tonic", "The bottle has the print of a person that's as small as a mouse", 10, ""); 
		itemDataList.Add (120, Item120); 

		ItemData Item121 = new ItemData (121, "Pigmy tonic", "The bottle has the print of a person that's as small as a mouse", 15, ""); 
		itemDataList.Add (121, Item121); 

		ItemData Item122 = new ItemData (122, "Strong Pigmy tonic", "The bottle has the print of a person that's as small as a mouse", 10, ""); 
		itemDataList.Add (122, Item122); 


		// breast reduction  
		ItemData Item125 = new ItemData (125, "weak Death Bosom", "The bottle has the form of a plain girl with the arms at her side, not shy of her small breasts", 10, ""); 
		itemDataList.Add (125, Item125); 

		ItemData Item126 = new ItemData (126, "Death Bosom",  "The bottle has the form of a plain girl with the arms at her side", 15, ""); 
		itemDataList.Add (126, Item126); 

		ItemData Item127 = new ItemData (127, "Strong Death Bosom",  "The bottle has the form of a plain girl with the arms at her side", 10, ""); 
		itemDataList.Add (127, Item127); 

		// Dick reduction
		ItemData Item130 = new ItemData (130, "Weak BetaX",  "The bottle has the form of weak man, with a very small dick. This potion will reduce the size of your dick!", 10, ""); 
		itemDataList.Add (130, Item130); 

		ItemData Item131 = new ItemData (131, "BetaX", "The bottle has the form of weak man, with a very small dick. This potion will reduce the size of your dick!", 15, ""); 
		itemDataList.Add (131, Item131);

		ItemData Item132 = new ItemData (132, "Strong BetaX","The bottle has the form of weak man, with a very small dick. This potion will reduce the size of your dick!", 10, ""); 
		itemDataList.Add (132, Item132); 

		// Balls reduction
		ItemData Item135 = new ItemData (135, "Weak Nutcracker Ale",  "The bottle has the print of someone covering his balls in shame. This potion will reduce the size of your testicles!", 10, ""); 
		itemDataList.Add (135, Item135);

		ItemData Item136 = new ItemData (136, "Nutcracker Ale",  "The bottle has the print of someone covering his balls in shame. This potion will reduce the size of your testicles!", 15, ""); 
		itemDataList.Add (136, Item136);

		ItemData Item137 = new ItemData (137, "Strong Nutcracker Ale",  "The bottle has the print of someone covering his balls in shame. This potion will reduce the size of your testicles!", 10, ""); 
		itemDataList.Add (137, Item137);

		// lactating potion

		ItemData Item140 = new ItemData (140, "weak Momma's Surplus Tonic",  "The bottle has the print of a woman breastfeeding a petite boy.", 10, ""); 
		itemDataList.Add (140, Item140);

		ItemData Item141 = new ItemData (141, "Momma's Surplus Tonic",  "The bottle has the print of a woman breastfeeding a petite boy.", 15, ""); 
		itemDataList.Add (141, Item141);

		ItemData Item142 = new ItemData (142, "Strong Momma's Surplus Tonic",  "The bottle has the print of a woman breastfeeding a petite boy.", 10, ""); 
		itemDataList.Add (142, Item142);

		//Fertility both
		ItemData Item145 = new ItemData (145, "Fertily treatment pill",  "This pill will make you fertile again.", 50, ""); 
		itemDataList.Add (145, Item145);

		ItemData Item146 = new ItemData (146, "Infertily treatment pill",  "A pill for those who dont want to have kids.", 50, ""); 
		itemDataList.Add (146, Item146);

		//Corruption 
		ItemData Item150 = new ItemData (150, "weak Dark Elixir",  "A very weak elixir that will corrupt the mind of those who consume it, good for starting corruption.", 10, ""); 
		itemDataList.Add (150, Item150);

		ItemData Item151 = new ItemData (151, "Dark Elixir",  "An elixir that will corrupt the mind of those who consume it, good to corrupt almost anyones mind.", 250, ""); 
		itemDataList.Add (151, Item151);

		ItemData Item152 = new ItemData (152, "Potent Dark Elixir",  "An elixir that will corrupt the mind of those who consume it. Very strong concoction, good for finish the job of corruptiong someone. Warning, it may break those of weak soul.", 10, ""); 
		itemDataList.Add (152, Item152);


		// purity 
		ItemData Item155 = new ItemData (155, "weak Pure Elixir",  "An elixir that will clear up the mind of someone who is corrupt. good to start the process of purifying someone without harming them.", 10, ""); 
		itemDataList.Add (155, Item155);

		ItemData Item156 = new ItemData (156, "Pure Elixir",  "An elixir that will clear up the mind of someone who is corrupt. good for most of the process of purification.", 250, ""); 
		itemDataList.Add (156, Item156);

		ItemData Item157 = new ItemData (157, "Potent Pure Elixir",  "An elixir that will clear up the mind of someone who is corrupt. good for the last rites of purification.", 100, ""); 
		itemDataList.Add (157, Item157);

		// Lust 

		ItemData Item160 = new ItemData (160, "Aphro Concoction",  "No, it doesn't gives you an afro, it's actually an aphrodisiac. The marketing department was fired shortly after this campaign.", 10, ""); 
		itemDataList.Add (160, Item160);

		//removes vagina 

		ItemData Item165 = new ItemData (165, "VagAway",  "This potion will remove your vagina. WARNING: This will also stop your pregnancy!", 50, ""); 
		itemDataList.Add (165, Item165);

		// gifts 
		ItemData Item200 = new ItemData (200, "Jewelry",  "Beautiful casual jewelry, perfect for a gift.", 100, ""); 
		itemDataList.Add (200, Item200);

		ItemData Item201 = new ItemData (201, "Fancy clothing",  "Elegant and comfortable clothes. (gift)", 85, ""); 
		itemDataList.Add (201, Item201);

		ItemData Item202 = new ItemData (202, "Luxury goods",  "From music boxes, beautiful snowballs or vases, these luxury goods are great to give as a gift.", 70, ""); 
		itemDataList.Add (202, Item202);

		ItemData Item203 = new ItemData (203, "Perfume",  "A perfume made by the best alchemist in the city, a great gift for those you love.", 70, ""); 
		itemDataList.Add (203, Item203);

		ItemData Item204 = new ItemData (204, "Plush toy",  "A very cute but childish gift.", 30, ""); 
		itemDataList.Add (204, Item204);

		ItemData Item205 = new ItemData (205, "Chocolate box",  "An elegant box full of delicious chocolates, ready to be gifted.", 45, ""); 
		itemDataList.Add (205, Item205);

		ItemData Item206 = new ItemData (206, "Luxurious wine",  "Very fine and old wine, a certainly good gift to those who can appreciate it's taste..", 120, ""); 
		itemDataList.Add (206, Item206);

		// races 1000 // // // // // // // // // //

		// rabbit 
		ItemData Item1000 = new ItemData (1000, "Rabbit Concoction",  "A bottle with the print of a cute bunny. A mix that can transform parts of you body at random.", 10, ""); 
		itemDataList.Add (1000, Item1000);

		ItemData Item1001 = new ItemData (1001, "Rabbit facial mud",  "A small jar with mud, has the print of a cute bunny in the front, used to change your face and head.", 10, ""); 
		itemDataList.Add (1001, Item1001);

		ItemData Item1002 = new ItemData (1002, "Rabbit body lotion",  "A small bottle with lotion, has the print of a cute bunny at the front, used to change your torso and body.", 10, ""); 
		itemDataList.Add (1002, Item1002);

		ItemData Item1003 = new ItemData (1003, "Rabbit legs oil",  "A small bottle with oil for your legs, has the print of a cute bunny at the front, used to change your legs, may also change your tail!", 10, ""); 
		itemDataList.Add (1003, Item1003);

		ItemData Item1004 = new ItemData (1004, "Rabbit distilled potion",  "A small bottle with a distilled rabbit conconction, it will change your body characteristics but wont transform you into a bunny. May change fur color and body sizes!", 10, ""); 
		itemDataList.Add (1004, Item1004);

		// wolf 
		ItemData Item1005 = new ItemData (1005, "Wolf Concoction",  "A bottle with the print of a strong feral wolf. A mix that can transform parts of you body at random.", 10, ""); 
		itemDataList.Add (1005, Item1005);

		ItemData Item1006 = new ItemData (1006, "Wolf facial mud",  "A small jar with mud, has the print of a strong feral wolf, use to change your face and head.", 10, ""); 
		itemDataList.Add (1006, Item1006);

		ItemData Item1007 = new ItemData (1007, "Wolf body lotion",  "A small bottle with lotion, has the print of a strong feral wolf at the front, used to change your torso and body.", 10, ""); 
		itemDataList.Add (1007, Item1007);

		ItemData Item1008 = new ItemData (1008, "Wolf legs oil",  "A small bottle with oil for your legs, has the print of a strong feral wolf at the front, used to change your legs, may also change your tail and genitals!", 10, ""); 
		itemDataList.Add (1008, Item1008);

		ItemData Item1009 = new ItemData (1009, "Wolf distilled potion",  "A small bottle with a distilled Wolf conconction, it will change your body characteristics but wont transform you into a wolf.", 10, ""); 
		itemDataList.Add (1009, Item1009);


		// plant
		ItemData Item1010 = new ItemData (1010, "Plant Monster Concoction",  "A bottle with the print of a plant girl surrounded by vines. A mix that can transform parts of you body at random.", 10, ""); 
		itemDataList.Add (1010, Item1010);

		ItemData Item1011 = new ItemData (1011, "Plant Monster facial mud",  "A small jar with mud, has the print of a plant girl surrounded by vines, use to change your face and head.", 10, ""); 
		itemDataList.Add (1011, Item1011);

		ItemData Item1012 = new ItemData (1012, "Plant Monster lotion",  "A small bottle with lotion, has the print of a plant girl surrounded by vines at the front, used to change your torso and body.", 10, ""); 
		itemDataList.Add (1012, Item1012);

		ItemData Item1013 = new ItemData (1013, "Plant Monster legs oil",  "A small bottle with oil for your legs, has the print of a plant girl surrounded by vines at the front, used to change your legs, may also change your tail.", 10, ""); 
		itemDataList.Add (1013, Item1013);

		ItemData Item1014 = new ItemData (1014, "Plant Monster distilled potion",  "A small bottle with a distilled Plant Monster conconction, it will change your body characteristics but wont transform you into a wolf.", 10, ""); 
		itemDataList.Add (1014, Item1014);


		// Feline
		ItemData Item1015 = new ItemData (1015, "Feline Concoction",  "A bottle with the print of a feline figure running. A mix that can transform parts of you body at random.", 10, ""); 
		itemDataList.Add (1015, Item1015);

		ItemData Item1016 = new ItemData (1016, "Feline facial mud",  "A small jar with mud, has the print of a feline figure running, use to change your face and head.", 10, ""); 
		itemDataList.Add (1016, Item1016);

		ItemData Item1017 = new ItemData (1017, "Feline lotion",  "A small bottle with lotion, has the print of a feline figure running at the front, used to change your torso and body.", 10, ""); 
		itemDataList.Add (1017, Item1017);

		ItemData Item1018 = new ItemData (1018, "Feline legs oil",  "A small bottle with oil for your legs, has the print of a feline figure running at the front, used to change your legs, may also change your tail.", 10, ""); 
		itemDataList.Add (1018, Item1018);

		ItemData Item1019 = new ItemData (1019, "Feline distilled potion",  "A small bottle with a distilled Feline conconction, it will change your body characteristics but wont transform you into a feline.", 10, ""); 
		itemDataList.Add (1019, Item1019);


		// Equine
		ItemData Item1020 = new ItemData (1020, "Equine Concoction",  "A bottle with the print of a strong equine crossing his arms. A mix that can transform parts of you body at random.", 10, ""); 
		itemDataList.Add (1020, Item1020);

		ItemData Item1021 = new ItemData (1021, "Equine facial mud",  "A small jar with mud, has the print of a strong equine crossing his arms, use to change your face and head.", 10, ""); 
		itemDataList.Add (1021, Item1021);

		ItemData Item1022 = new ItemData (1022, "Equine lotion",  "A small bottle with lotion, has the print of a strong equine crossing his arms at the front, used to change your torso and body.", 10, ""); 
		itemDataList.Add (1022, Item1022);

		ItemData Item1023 = new ItemData (1023, "Equine legs oil",  "A small bottle with oil for your legs, has the print of a strong equine crossing his arms, used to change your legs, may also change your tail and genitals!", 10, ""); 
		itemDataList.Add (1023, Item1023);

		ItemData Item1024 = new ItemData (1024, "Equine distilled potion",  "A small bottle with a distilled equine conconction, it will change your body characteristics but wont transform you into a equine.", 10, ""); 
		itemDataList.Add (1024, Item1024);

		// Dodo
		ItemData Item1025 = new ItemData (1025, "Dodo Concoction",  "A bottle with the print of a small dodo girl smiling. A mix that can transform parts of you body at random.", 10, ""); 
		itemDataList.Add (1025, Item1025);

		ItemData Item1026 = new ItemData (1026, "Dodo facial mud",  "A small jar with mud, has the print of a small dodo girl smiling, use to change your face and head.", 10, ""); 
		itemDataList.Add (1026, Item1026);

		ItemData Item1027 = new ItemData (1027, "Dodo lotion",  "A small bottle with lotion, has the print of a small dodo girl smiling at the front, used to change your torso and body. The arms are winged!", 10, ""); 
		itemDataList.Add (1027, Item1027);

		ItemData Item1028 = new ItemData (1028, "Dodo legs oil",  "A small bottle with oil for your legs, has the print of a small dodo girl smiling, used to change your legs, may also change your tail.", 10, ""); 
		itemDataList.Add (1028, Item1028);

		ItemData Item1029 = new ItemData (1029, "Dodo distilled potion",  "A small bottle with a distilled dodo conconction, it will change your body characteristics but wont transform you into a dodo.", 10, ""); 
		itemDataList.Add (1029, Item1029);

		// Lizard
		ItemData Item1030 = new ItemData (1030, "Lizard Concoction",  "A bottle with the print of a gecko. A mix that can transform parts of you body at random. It may change your skin!", 10, ""); 
		itemDataList.Add (1030, Item1030);

		ItemData Item1031 = new ItemData (1031, "Lizard facial mud",  "A small jar with mud, has the print of a gecko, use to change your face and head.", 10, ""); 
		itemDataList.Add (1031, Item1031);

		ItemData Item1032 = new ItemData (1032, "Lizard lotion",  "A small bottle with lotion, has the print of a gecko at the front, used to change your torso and body. It may change your skin!", 10, ""); 
		itemDataList.Add (1032, Item1032);

		ItemData Item1033 = new ItemData (1033, "Lizard legs oil",  "A small bottle with oil for your legs, has the print of a gecko, used to change your legs, may also change your tail.", 10, ""); 
		itemDataList.Add (1033, Item1033);

		ItemData Item1034 = new ItemData (1034, "Lizard distilled potion",  "A small bottle with a distilled Lizard conconction, it will change your body characteristics but wont transform your race. It may change the colour of your skin!", 10, ""); 
		itemDataList.Add (1034, Item1034);


		// lion
		ItemData Item1035 = new ItemData (1035, "Lion Concoction",  "A bottle with the print of a roaring lion. A mix that can transform parts of you body at random. It may change your hair into a mane!", 10, ""); 
		itemDataList.Add (1035, Item1035);

		ItemData Item1036 = new ItemData (1036, "Lion facial mud",  "A small jar with mud, has the print of aroaring lion, use to change your face and head. It may change your hair into a mane!", 10, ""); 
		itemDataList.Add (1036, Item1036);

		ItemData Item1037 = new ItemData (1037, "Lion lotion",  "A small bottle with lotion, has the print of a roaring lion at the front, used to change your torso and body.", 10, ""); 
		itemDataList.Add (1037, Item1037);

		ItemData Item1038 = new ItemData (1038, "Lion legs oil",  "A small bottle with oil for your legs, has the print of a roaring lion, used to change your legs, may also change your tail.", 10, ""); 
		itemDataList.Add (1038, Item1038);

		ItemData Item1039 = new ItemData (1039, "Lion distilled potion",  "A small bottle with a distilled Lion conconction, it will change your body characteristics but wont transform you into a lion.", 10, ""); 
		itemDataList.Add (1039, Item1039);

		// Fox
		ItemData Item1040 = new ItemData (1040, "Fox Concoction",  "A bottle with the print of a fox doing a smug face. A mix that can transform parts of you body at random.", 10, ""); 
		itemDataList.Add (1040, Item1040);

		ItemData Item1041 = new ItemData (1041, "Fox facial mud",  "A small jar with mud, has the print of a fox doing a smug face, use to change your face and head.", 10, ""); 
		itemDataList.Add (1041, Item1041);

		ItemData Item1042 = new ItemData (1042, "Fox lotion",  "A small bottle with lotion, has the print of a fox doing a smug face at the front, used to change your torso and body.", 10, ""); 
		itemDataList.Add (1042, Item1042);

		ItemData Item1043 = new ItemData (1043, "Fox legs oil",  "A small bottle with oil for your legs, has the print of a fox doing a smug faceg, used to change your legs, may also change your tail.", 10, ""); 
		itemDataList.Add (1043, Item1043);

		ItemData Item1044 = new ItemData (1044, "Fox distilled potion",  "A small bottle with a distilled Fox conconction, it will change your body characteristics but wont transform you into a fox.", 10, ""); 
		itemDataList.Add (1044, Item1044);

		// Human
		ItemData Item1045 = new ItemData (1045, "Cleanser",  "This potion will transform you back into a human! A very rare and powerful item!", 350, ""); 
		itemDataList.Add (1045, Item1045);




		///////////////////////////////////////////////////////////////////////////////////////////////////
		//10000 weapons, 20000 armor, 30000 head, 40000 face, 50000 neck, 60000 shoulders, 70000 arms, 80000 legs, 90000 make up, 100000 ring, 110000 amulet, 120000 trophy
		///////////////////////////////////////////////////////////////////////////////////////////////////
		ItemData Item10000 = new ItemData (10000, "fists", "naked", 200, "");  // 0
		itemDataList.Add (10000, Item10000); 

		ItemData Item10001 = new ItemData (10001, "Old Sword", "It gets the job done... Better than your fists at least. +15% combat damage.", 100, ""); // 100, cost: 200 
		itemDataList.Add (10001, Item10001); 

		ItemData Item10002 = new ItemData (10002, "Gladius", "A very reliable weapon, decent will damage. +20% combat damage.", 125, ""); // 110 , cost: 250
		itemDataList.Add (10002, Item10002); 

		ItemData Item10003 = new ItemData (10003, "Seductive veil", "A fine piece of cloth to perform some sexy moves. +15% lust damage.", 100, ""); //120, cost: 200
		itemDataList.Add (10003, Item10003); 

		ItemData Item10004 = new ItemData (10004, "Leather whip", "A very versatile weapon, with mixed lust and will damage. +10% combat damage and lust damage.", 125, ""); //130, cost: 250
		itemDataList.Add (10004, Item10004); 

		ItemData Item10005 = new ItemData (10005, "Lustick", "A special lipstick that helps to charm your enemies. +20% lust damage, +5 persuasion bonus.", 200, ""); //140, cost 200
		itemDataList.Add (10005, Item10005); 

		ItemData Item10006 = new ItemData (10006, "Hunting bow", "A hunting bow. +20% to combat damage, +5 martial bonus.", 125, ""); //140, cost 125
		itemDataList.Add (10006, Item10006); 

		ItemData Item10007 = new ItemData (10007, "Battle Axe", "A  very sturdy axe perfect for cutting people in half. +24% combat damage, +5 martial bonus, -5% defense.", 180, ""); //140, cost 125
		itemDataList.Add (10007, Item10007); 

		ItemData Item10008 = new ItemData (10008, "Naginata", "A wooden pole with a curved blade on the end. Excelent both on the offense and defense.  +20% combat damage. +15% defense, +3 martial bonus.", 230, ""); //140, cost 125
		itemDataList.Add (10008, Item10008); 

		ItemData Item10009 = new ItemData (10009, "Fancy rapier", "A very elegant sword. Fast, effective attacks with great defense.  +15% combat damage. +15% defense bonus. +5 martial bonus", 200, ""); //140, cost 125
		itemDataList.Add (10009, Item10009); 

		ItemData Item10010 = new ItemData (10010, "Gladius and towershield", "A gladius and it's accompanying shield, a great bonus and defense attack.  +10% combat damage, +30% defense, +7 martial bonus.", 270, ""); //140, cost 125
		itemDataList.Add (10010, Item10010); 

		ItemData Item10011 = new ItemData (10011, "Hatchet", "A tool used commonly to chop wood, but a common weapon among poor recruits. +10% combat damage.", 50, ""); //140, cost 125
		itemDataList.Add (10011, Item10011); 

		ItemData Item10012 = new ItemData (10012, "Crossbow", "A powerful range weapon, equiped by wealthy militias.  +35% combat damage, -20% defense, +3 martial bonus. ", 350, ""); //140, cost 125
		itemDataList.Add (10012, Item10012); 

		ItemData Item10013 = new ItemData (10013, "Flail", "A prefered weapon among the priesthood.  +20% combat damage, -10% defense, +3 martial bonus.", 170, ""); //140, cost 125
		itemDataList.Add (10013, Item10013); 

		ItemData Item10014 = new ItemData (10014, "Warhammer", "A very heavy and powerful weapon, if it hits the enemy. +45% combat bonus, -30% defense, +5 martial bonus.", 500, ""); //140, cost 125
		itemDataList.Add (10014, Item10014); 

		ItemData Item10015 = new ItemData (10015, "Arming sword", "A sword typically used by knights and well equiped soldiers. +15% combat damage, +10% defense, +3 martial bonus.", 160, ""); //140, cost 125
		itemDataList.Add (10015, Item10015); 

		ItemData Item10016 = new ItemData (10016, "Dagger", "A very basic weapon, but better than nothing. +10% combat damage.", 70, ""); //140, cost 125
		itemDataList.Add (10016, Item10016); 

		ItemData Item10017 = new ItemData (10017, "Club", "A very primitive weapon, for when you have nothing else. +5% combat damage.", 25, ""); //140, cost 125
		itemDataList.Add (10017, Item10017); 

		ItemData Item10018 = new ItemData (10018, "Sickle", "A tool used for farmers, and typical weapon of those who are recruited and can't afford a real one. +8% combat damage", 60, ""); //140, cost 125
		itemDataList.Add (10018, Item10018); 

		ItemData Item10019 = new ItemData (10019, "Halberd", "A powerful pole weapon, great against cavalry. 20% combat damage, +35% defense, +5 martial", 390, ""); //140, cost 125
		itemDataList.Add (10019, Item10019); 

		ItemData Item10020 = new ItemData (10020, "Fancy broadsword", "A very elegant broadsword. Both effective and good looking. +30% combat damage, +5% defense, +5 martial.", 650, ""); //140, cost 125
		itemDataList.Add (10020, Item10020); 

		ItemData Item10021 = new ItemData (10021, "Fancy claymore", "A very elegant claymore used by royalty. Both effective and good looking. +35% combat damage, +5% defense, +7 martial bonus.", 800, ""); //140, cost 125
		itemDataList.Add (10021, Item10021); 

		ItemData Item10022 = new ItemData (10022, "Heirloom Sword", "A beautiful sword. Easy to handle, great for both offense and defense. +15 martial, +5 Physical , +50% combat damage, +50% defense bonus.", 2000, ""); //140, cost 125
		itemDataList.Add (10022, Item10022); 


		/// 2000 armour /////////////////////////////////////////////////////////////////////// 
		/// 2000 armour /////////////////////////////////////////////////////////////////////// 
		ItemData Item20000 = new ItemData (20000, "no clothes", "Just naked. Armour level: 0, Rank: -30", 0, ""); 
		itemDataList.Add (20000, Item20000); 

		ItemData Item20001 = new ItemData (20001, "Legionary armour", "Regular armour used by the common army of Aurorum. Will defense: 2, lust defense: 1. Rank: 3. Tag: Military", 100, "");  // cost 200
		itemDataList.Add (20001, Item20001); 

		ItemData Item20002 = new ItemData (20002, "Centurio armour", "Armour used by low rank officers in the army of Aurorum. Martial: +2, +5% bonus to combat skill. Will Def: 2.5, Lust Def: 1. Rank: 6, Tag: Military", 225, ""); // cost 450
		itemDataList.Add (20002, Item20002); 

		ItemData Item20003 = new ItemData (20003, "Legatus armour", "A heavy armour used by the generals of the army of Aurorum. Martial: +4; +10% bonus to combat skill. Armour level: 3, lust defense: 1.5 Rank: 11. Tag: Military.", 400, ""); // cost 800
		itemDataList.Add (20003, Item20003); 

		ItemData Item20004 = new ItemData (20004, "Caesar armour", "The most luxurious armour used only by the richest lords of Aurorum. Martial: +4, Diplomacy +2, +20% bonus to combat skill. Defense bonus: 3, lust defense: 2 Rank: 40. Tag: Military, Royal.", 1000, ""); // cost 2000
		itemDataList.Add (20004, Item20004); 

		ItemData Item20005 = new ItemData (20005, "Sexy consul clothing", "This is what consuls of aurorum usually use... Well, but done with less cloth. Seduction: 2, +5% lust skill damage. Will defense: 2, lust defense: 2. Rank: 6. Tag: Sexy.", 175, ""); // cost 350
		itemDataList.Add (20005, Item20005); 

		ItemData Item20006 = new ItemData (20006, "Cataprach armour", "An exotic armour from foreign lands, it is pretty sturdy and has more standing than your regular armour. Diplomacy: +4, Martial: +4, Will defense: 2, lust defense: 1. Rank: 8. Tag: Exotic.", 250, "");  // cost 500
		itemDataList.Add (20006, Item20006); 

		ItemData Item20007 = new ItemData (20007, "Sexy femenine clothing", "Very short skirt, tight top, clothing that fills you with confidence, but susceptible to a quickie. Seduction: +2, +10% bonus to seductive skills. Will defense: 1.5, lust defense: 1. Rank: 1. Tag: Sexy.", 60, "");  // cost 120
		itemDataList.Add (20007, Item20007); 

		ItemData Item20008 = new ItemData (20008, "Traveling clothes", "Very sturdy and practical clothing, not the best to combat but good to resist lust. Labor: +5, Will defense: 1, lust defense: 2. Rank: 3", 90, ""); // cost 180 
		itemDataList.Add (20008, Item20008); 

		ItemData Item20009 = new ItemData (20009, "Religious habit", "Fine and sturdy cloths that fill your spirit with will and also protect you from lustful attacks. Stewardship: -2, Governance: +4, Will defense: 2, lust defense: 2.5. Rank: 5. Tag: Holy.", 150, ""); // cost 300
		itemDataList.Add (20009, Item20009); 

		ItemData Item20010 = new ItemData (20010, "Patrician suit", "Very fine and elegant clothing, great to impress the commoners. Stewardship: +5, +5% combat skill bonus. Will defense: 2.5, lust defense: 1.5. Rank: 12. Tag: Royal.", 300, ""); // cost 600
		itemDataList.Add (20010, Item20010); 

		ItemData Item20011 = new ItemData (20011, "Senator clothing", "One of the best appareal that you can get in Aurorum reserver only for those with the higher status. Governance: +5, +10% combat skill bonus. Will defense: 2.5, lust defense: 1.5. Rank: 16. Tag: Royal.", 350, ""); // cost 700
		itemDataList.Add (20011, Item20011); 

		ItemData Item20012 = new ItemData (20012, "Sexy silk dress", "This dress is usually used by prostitutes, which degrades you a little but helps to seduce the enemy. Seduction: +5, +15% lust skill bonus. Will defense: 1.5, lust defense: 1.5. Rank: -5. Tag: Sexy.", 110, ""); // cost 220
		itemDataList.Add (20012, Item20012); 

		ItemData Item20013 = new ItemData (20013, "Obsene silk dress", "A very lewd version of this dress. Its almost transparent and leaves your crotch, breasts and ass totally open to its use, that makes more easy to seduce the enemy. Seduction: +5, +25% lust skill bonus. Will defense: 1, lust defense: 1. Rank: -8. Tag: Whore, exhibitionist.", 150, ""); // cost 300
		itemDataList.Add (20013, Item20013); 

		ItemData Item20014 = new ItemData (20014, "Maidens of Love bikini armour", "A very exposed Bikini armour that is blessed by the Love Goddess, Servilia. It's magic makes it a great combat armour, but your lust cannot go lower than 30. +10% lust skill bonus. Will defense: 2, lust defense: 4. Rank: 20. Tags: Holy, chastitity, exhibitionist", 750, ""); // cost 1500
		itemDataList.Add (20014, Item20014); 

		ItemData Item20015 = new ItemData (20015, "Leather armour", "An armour that offers basic protection. Combat defense: 2, lust defense: 4. Rank: 20. ", 250, ""); // cost 1500
		itemDataList.Add (20015, Item20015); 

		ItemData Item20016 = new ItemData (20016, "Padded armour", "The most basic armour provided to militias and recruirts. Combat defense: 2, lust defense: 4. Rank: 20. ", 350, ""); // cost 1500
		itemDataList.Add (20016, Item20016); 

		ItemData Item20017 = new ItemData (20017, "Inquisitorial robes", "Menacing robes used by the inquisition. Combat defense: 2, lust defense: 2. Rank: 5. ", 400, ""); // cost 1500
		itemDataList.Add (20017, Item20017); 

		ItemData Item20018 = new ItemData (20018, "Magical robes", "Robes done with special fabric, used by mystics and other magic users to increase their power. Combat defense: 2, lust defense: 2. Rank: 5. ", 900, ""); // cost 1500
		itemDataList.Add (20018, Item20018); 

		ItemData Item20019 = new ItemData (20019, "Plate armour", "Heavy armour used by knights and elite heavy infantry. Combat defense: 5, lust defense: 0. Rank: 5. ", 1100, ""); // cost 1500
		itemDataList.Add (20019, Item20019); 

		ItemData Item20020 = new ItemData (20020, "Peasant clothes", "Typical clothes among commoners. Combat defense: 0, lust defense: 0. Rank: 0. ", 50, ""); 
		itemDataList.Add (20020, Item20020); 

		ItemData Item20021 = new ItemData (20021, "Scholar robes", "Typical clothes among university teachers. Combat defense: 0, lust defense: 4. Rank: 2. ", 200, ""); // cost 1500
		itemDataList.Add (20021, Item20021); 

		ItemData Item20022 = new ItemData (20022, "Old Plate armour", "Heavy armour used by knights and elite heavy infantry. Combat defense: 4, lust defense: 0. Rank: 4. ", 750, ""); // cost 1500
		itemDataList.Add (20022, Item20022); 

		ItemData Item20023 = new ItemData (20023, "Rusty Plate armour", "More a relic than an actual armour, it still provides with more defense than other light alternatives, but is far from being a fancy option. Combat defense: 3, lust defense: 0. Rank: 2. ", 650, ""); // cost 1500
		itemDataList.Add (20023, Item20023); 

		ItemData Item20024 = new ItemData (20024, "Heirloom armour", "A familiar relic, a sturdy and beautiful armour, providing great defense for any circumstance. Combat defense: +20%, Lust defense: +20%0. Rank: 10. ", 3000, ""); // cost 1500
		itemDataList.Add (20024, Item20024); 

		ItemData Item20025 = new ItemData (20025, "Elven armour", "A beautiful elven armour, as fancy as sturdy. Provides great protection.", 1500, ""); // cost 1500
		itemDataList.Add (20025, Item20025); 

		ItemData Item20026 = new ItemData (20026, "Elven light armour", "A beautiful light armour, fitting for the proud elves.", 800, ""); // cost 1500
		itemDataList.Add (20026, Item20026); 

		ItemData Item20027 = new ItemData (20027, "Elven dress", "A beautiful outfit fitting for the proud elves.", 800, ""); // cost 1500
		itemDataList.Add (20027, Item20027); 

		ItemData Item20028 = new ItemData (20028, "Sexy leather outfit", "A very exposing outfit, and very popular in underground clubs of Aurorum.", 500, ""); // cost 1500
		itemDataList.Add (20028, Item20028); 

		ItemData Item20029 = new ItemData (20029, "Maid dress", "Typically used by servants. More sexy than it should.", 300, ""); // cost 1500
		itemDataList.Add (20029, Item20029); 



		ItemData Item20500 = new ItemData (20500, "Origin armour", "A special armour.", 2000, ""); // cost 1500
		itemDataList.Add (20500, Item20500); 

		//3000 helmets ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		ItemData Item30000 = new ItemData (30000, "No helmet", "", 0, ""); 
		itemDataList.Add (30000, Item30000); 

		ItemData Item30001 = new ItemData (30001, "Galea helmet", "Very sturdy helmet used by the regular army of aurorum, with a nice red crest at the top. Security: +2. Combat defense: 0.5 Rank: 2", 75, ""); // cost 150
		itemDataList.Add (30001, Item30001); 

		ItemData Item30002 = new ItemData (30002, "Gladiator helmet", "A helmet that its designed to look intimidating. Martial: +2. Combat defense: 0.5 Rank: 2", 100, ""); // cost 200
		itemDataList.Add (30002, Item30002); 

		ItemData Item30003 = new ItemData (30003, "Dark brown hood", "A hoodie used usually to be unnoticed. Intrigue: +3. Rank: 0 ", 25, ""); // cost 50
		itemDataList.Add (30003, Item30003); 
		 
		ItemData Item30004 = new ItemData (30004, "Laurel crown", "A crown that its used by mandataries and the elite. Diplomacy: +1. Rank: 2", 50, ""); // cost 100
		itemDataList.Add (30004, Item30004); 

		ItemData Item30005 = new ItemData (30005, "Gold circlet", "An elegant circlet used by fashionable, rich ladies. Diplomacy: +1. Rank: 2", 70, ""); // cost 100
		itemDataList.Add (30005, Item30005); 

		ItemData Item30006 = new ItemData (30006, "Golden crown", "An elegant crown used by kings and queens. Diplomacy: +5. Rank: 2", 200, ""); // cost 100
		itemDataList.Add (30006, Item30006); 

		ItemData Item30007 = new ItemData (30007, "Bascinet", "A combat helmet used by knights and elite heavy infantry.  Rank: 2", 120, ""); // cost 100
		itemDataList.Add (30007, Item30007); 

		ItemData Item30008 = new ItemData (30008, "Chaperon", "An elegant hat used casually by the rich and powerful. Rank: 2", 140, ""); // cost 100
		itemDataList.Add (30008, Item30008); 

		ItemData Item30009 = new ItemData (30009, "Bycocket", "A pointy hat famously used by bandits.  Rank: 2", 50, ""); // cost 100
		itemDataList.Add (30009, Item30009); 

		ItemData Item30500 = new ItemData (30500, "Origin Helmet", "A special helmet.", 500, ""); // cost 100
		itemDataList.Add (30500, Item30500); 

		//4000 face  ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		ItemData Item40000 = new ItemData (40000, "No face gear", "", 0, ""); 
		itemDataList.Add (40000, Item40000); 

		ItemData Item40001 = new ItemData (40001, "Red bandolier", "A red bandolier that helps to cover most your face... But makes you suspicious. Security +3, Intrigue -2  Rank: -2", 15, ""); // cost 30
		itemDataList.Add (40001, Item40001); 

		ItemData Item40002 = new ItemData (40002, "Gladiator mask", "A mask that has the shape of a dangerous beast. Martial: +2", 50, ""); // cost 100
		itemDataList.Add (40002, Item40002); 

		ItemData Item40003 = new ItemData (40003, "Librarian glasses", "Thick frame glasses that are popular among librarians and intellectuals. Stewardship: +2.  Rank: 2", 35, ""); // cost 70 
		itemDataList.Add (40003, Item40003); 

		ItemData Item40004 = new ItemData (40004, "Dark shades", "Used regularly by cool people, imported from exotic lands! Seduction +3. Rank: 4", 150, ""); // cost 300
		itemDataList.Add (40004, Item40004); 

		ItemData Item40005 = new ItemData (40005, "Carnival mask", "An exotic and colorful mask used for festivals. Persuasion +3. ", 150, ""); // cost 300
		itemDataList.Add (40005, Item40005); 

		ItemData Item40500 = new ItemData (40500, "Origin mask", "An special mask.", 200, ""); // cost 300
		itemDataList.Add (40500, Item40500); 




		//5000 neck ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		ItemData Item50000 = new ItemData (50000, "No neck wear", "", 0, ""); 
		itemDataList.Add (50000, Item50000); 

		ItemData Item50001 = new ItemData (50001, "Red scarf", "A sturdy red scarf, great for style and cold weather. Labor: +2. Rank: 0", 20, ""); // cost 40
		itemDataList.Add (50001, Item50001); 

		ItemData Item50002 = new ItemData (50002, "Steel gorget", "An elegant gorget to protect your neck, polished and with elegant engravings. Combat defense: 0.5 Rank: 2", 60, ""); // cost 120
		itemDataList.Add (50002, Item50002); 

		ItemData Item50003 = new ItemData (50003, "Slave collar", "The most used collar; Sturdy and hard to remove without the key, and as plain as it gets. Rank: -120. Tag: Slave.", 15, ""); // cost 30
		itemDataList.Add (50003, Item50003); 

		ItemData Item50004 = new ItemData (50004, "Spiked collar", "Intimidating, it has also a ring to add a leash to it. Rank: -2", 25, ""); // cost 50
		itemDataList.Add (50004, Item50004); 

		ItemData Item50005 = new ItemData (50005, "Simple gold necklace", "A very simple and good looking gold necklace, good to complement an elegant outfit. Diplomacy: +2. Rank: 2", 35, ""); // cost 70
		itemDataList.Add (50005, Item50005); 

		ItemData Item50006 = new ItemData (50006, "Fancy gold necklace", "A very fashionable gold necklace, great to complement an elegant outfit. Diplomacy: +2.", 35, ""); // cost 70
		itemDataList.Add (50006, Item50006); 

		ItemData Item50007 = new ItemData (50007, "Blue pashmina", "A very soft and good looking pashmina. Diplomacy: +2.", 35, ""); // cost 70
		itemDataList.Add (50007, Item50007); 

		ItemData Item50008 = new ItemData (50008, "Gold slave collar", "Not better way to show off than wasting so much gold on a slave. Diplomacy: +2. Rank: 2", 35, ""); // cost 70
		itemDataList.Add (50008, Item50008); 

		ItemData Item50500 = new ItemData (50500, "Origin gorget", "Soecial gorget", 35, ""); // cost 70
		itemDataList.Add (50500, Item50500); 

		//6000 shoulders  ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		ItemData Item60000 = new ItemData (60000, "No shoulder gear", "", 0, ""); 
		itemDataList.Add (60000, Item60000); 

		ItemData Item60001 = new ItemData (60001, "Red cape", "A red cape, used regularly by adventurers and nobility. Martial: +2. Rank: 1", 50, ""); // cost 100
		itemDataList.Add (60001, Item60001);

		ItemData Item60002 = new ItemData (60002, "Survival backpack", "A pretty big backpack used by explorers. Tactics: +2 Note: It doesn't change your inventory. Rank: 1", 40, ""); // cost 80
		itemDataList.Add (60002, Item60002);

		ItemData Item60003 = new ItemData (60003, "Red school backpack", "Pretty small backpack usually used for elementary school. Stewardship: +1, Diplomacy: -2. Rank: 0", 20, ""); // cost 40
		itemDataList.Add (60003, Item60003);

		ItemData Item60004 = new ItemData (60004, "Steel pauldrons", "Heavy piece of armour to protect your shoulders, with elegant engravings. Combat defense: 0.5 Rank: 2", 60, ""); // cost 120
		itemDataList.Add (60004, Item60004);

		ItemData Item60005 = new ItemData (60005, "Steel pauldrons with red cape", "Heavy piece of armour to protect your shoulders, with elegant engravings, and a red cape for your back. Martial: +2, Combat defense: 0.5Rank: 3", 100, ""); // cost 200
		itemDataList.Add (60005, Item60005);

		ItemData Item60006 = new ItemData (60006, "Hussar wings", "Heavy wooden wings used by some mounted knights. Martial: +2, Combat defense: 0.5Rank: 3", 100, ""); // cost 200
		itemDataList.Add (60006, Item60006);

		ItemData Item60007 = new ItemData (60007, "Horo", "A cloak used by cavalry that expands like a balloon and protects it's wearer from arrows that come from the back and sides.. Martial: +2, Combat defense: 0.5Rank: 3", 100, ""); // cost 200
		itemDataList.Add (60007, Item60007);

		ItemData Item60500 = new ItemData (60500, "Origin cape", "A special cape", 100, ""); // cost 200
		itemDataList.Add (60500, Item60500);


		//7000 arms  ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		ItemData Item70000 = new ItemData (70000, "No armwear", "", 0, ""); 
		itemDataList.Add (70000, Item70000); 

		ItemData Item70001 = new ItemData (70001, "Steel gauntlets", "Heavy piece of armour to protect your hands and arms, with elegant engravings. Combat defense: 0.5 Rank: 2", 70, ""); // cost 140
		itemDataList.Add (70001, Item70001); 

		ItemData Item70002 = new ItemData (70002, "B. Fishnet arm sleeves", "Black fishnets for your casual apparel. Seduction: +1. Rank: -1.", 25, ""); // cost 50
		itemDataList.Add (70002, Item70002); 

		ItemData Item70003 = new ItemData (70003, "P. spandex arm sleeves", "Pink spandex arm sleeves used usually for exercise, imported from foreign lands. Labor: +1. Rank: 0", 30, ""); // cost 60
		itemDataList.Add (70003, Item70003); 

		ItemData Item70004 = new ItemData (70004, "Spiked wristband", "Intimidating wristbands used to show your character. Security: +1, Diplomacy: -1. Rank: -2", 50, ""); // cost 100
		itemDataList.Add (70004, Item70004); 

		ItemData Item70005 = new ItemData (70005, "Fingerless gloves", "Good sturdy gloves, that dont hinder your hands. Martial: +1. Rank: 0", 40, ""); // cost 80
		itemDataList.Add (70005, Item70005); 

		ItemData Item70006 = new ItemData (70006, "Arm bandages", "Used by martial artist and some of the people around the E.R. Rank: -1", 15, ""); // cost 30
		itemDataList.Add (70006, Item70006); 

		ItemData Item70007 = new ItemData (70007, "Leather bracers", "Leather armour that offers light protection. Rank: -1", 15, ""); // cost 30
		itemDataList.Add (70007, Item70007); 

		ItemData Item70500 = new ItemData (70500, "Origin gauntlets", "Special gauntlets", 15, ""); // cost 30
		itemDataList.Add (70500, Item70500); 


		//8000 legs  ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		ItemData Item80000 = new ItemData (80000, "No shoes", "", 0, ""); 
		itemDataList.Add (80000, Item80000);

		ItemData Item80001 = new ItemData (80001, "Combat boots", "Sturdy boots for an intrepid adventurer. Martial: +1 Rank: 0", 40, ""); // cost 80
		itemDataList.Add (80001, Item80001);

		ItemData Item80002 = new ItemData (80002, "Steel Greaves", "Heavy piece of armour to protect your legs, with elegant engravings. Combat defense: 0.5 Rank: 1", 50, ""); // cost 100
		itemDataList.Add (80002, Item80002);

		ItemData Item80003 = new ItemData (80003, "Elegant sandals", "A pair of comfy sandals, decorated with some jewels. Diplomacy: +1. Rank: 1", 25, "");  // cost 50
		itemDataList.Add (80003, Item80003);

		ItemData Item80004 = new ItemData (80004, "Bandages", "Footwear. Used usually by martial artists and in the E.R. Rank: -1", 15, ""); // cost 30
		itemDataList.Add (80004, Item80004);

		ItemData Item80005 = new ItemData (80005, "Black high heels", "Elegant and very femenine shoes. Seduction: +2. Rank: 2", 40, ""); // cost 80
		itemDataList.Add (80005, Item80005);

		ItemData Item80006 = new ItemData (80006, "Elegant shoes", "A pair of elegant shoes, decorated with gold. Diplomacy: +1. Rank: 1", 25, "");  // cost 50
		itemDataList.Add (80006, Item80006);

		ItemData Item80007 = new ItemData (80007, "Normal shoes", "A pair of shoes. Not fancy, but get the job done.  Diplomacy: +1. Rank: 1", 25, "");  // cost 50
		itemDataList.Add (80007, Item80007);

		ItemData Item80500 = new ItemData (80500, "Origin combat boots", "Special boots", 200, "");  // cost 50
		itemDataList.Add (80500, Item80500);


		//9000 Face  ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		ItemData Item90000 = new ItemData (90000, "No makeup", "", 0, ""); 
		itemDataList.Add (90000, Item90000);

		ItemData Item90001 = new ItemData (90001, "natural makeup", "Simple makeup", 0, ""); 
		itemDataList.Add (90001, Item90001);

		ItemData Item90002 = new ItemData (90002, "slutty makeup", "You'll look sluttier and with no class!", 0, ""); 
		itemDataList.Add (90002, Item90002);

		ItemData Item90003 = new ItemData (90003, "trival makeup", "Not classy, but intimidating", 0, ""); 
		itemDataList.Add (90003, Item90003);

		ItemData Item90004 = new ItemData (90004, "elegant makeup", "Perfect for waltz.", 0, ""); 
		itemDataList.Add (90004, Item90004);


		//100 000  rings
		ItemData Item100000 = new ItemData (100000, "No ring", "", 15, ""); // cost 30
		itemDataList.Add (100000, Item100000); 

		ItemData Item100001 = new ItemData (100001, "Silver ring", "Elegant silver ring ", 35, ""); // cost 30
		itemDataList.Add (100001, Item100001); 

		ItemData Item100002 = new ItemData (100002, "Gold ring", "Elegant gold ring", 70, ""); // cost 30
		itemDataList.Add (100002, Item100002); 

		ItemData Item100003 = new ItemData (100003, "Golden ring of power", "A powerful ring that will increase your magic power.", 200, ""); // cost 30
		itemDataList.Add (100003, Item100003); 


		//110 000  amulets
		ItemData Item110000 = new ItemData (110000, "No amulet", "", 15, ""); // cost 30
		itemDataList.Add (110000, Item110000); 

		ItemData Item110001 = new ItemData (110001, "Golden amulet of power", "A powerful amulet that increases your magic power.  ", 200, ""); // cost 30
		itemDataList.Add (110001, Item110001); 

		ItemData Item110002 = new ItemData (110002, "Golden amulet of combat", "A powerful amulet that increases your combat damage.  ", 200, ""); // cost 30
		itemDataList.Add (110002, Item110002); 

		ItemData Item110003 = new ItemData (110003, "Golden amulet of Lust", "A powerful amulet that increases your lust damage.  ", 200, ""); // cost 30
		itemDataList.Add (110003, Item110003); 

		ItemData Item110004 = new ItemData (110004, "Heirloom amulet", "An amulet given from generation to generation, with strong magic.", 1000, ""); // cost 30
		itemDataList.Add (110004, Item110004); 


		//120 000  trophy
		ItemData Item120000 = new ItemData (120000, "No trophy", "", 15, ""); // cost 30
		itemDataList.Add (120000, Item120000); 

		ItemData Item120001 = new ItemData (120001, "Trophy of ever breeding", "placeholder  ", 500, ""); // cost 30
		itemDataList.Add (120001, Item120001); 

		ItemData Item120002 = new ItemData (120002, "Trophy of dominance", "A powerful amulet that increases your combat damage.  ", 500, ""); // cost 30
		itemDataList.Add (120002, Item120002); 

		ItemData Item120003 = new ItemData (120003, "Trophy of nature.", "A powerful amulet that increases your lust damage.  ", 500, ""); // cost 30
		itemDataList.Add (120003, Item120003); 


			


	}

	void Awake(){
		DontDestroyOnLoad (this.gameObject);
		startLibrary ();

	}
	void Start(){
		
	}



}
