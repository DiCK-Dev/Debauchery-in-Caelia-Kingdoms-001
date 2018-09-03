using UnityEngine;
using System.Collections;

public class NPCSettlerName {
	int hashcode = GameControl.playerName.GetHashCode();
	int randNum;
	static int iteration = 5;

	string[] maleNames = new string[] {"Aelius", "Agrippa", "Albanus", "Antonius", "Augustus", "Brutus", "Cassius", "Claudius", "Ignatius", "Flavius", "Gaius", "Horatius", "Junius", "Livius", "Lucilius", "Manius", "Marcellus", "Maximus", "Nero", "Octavius", "Petronius", "Porcius", "Priscus", "Regulus", "Rufus", "Septimus", "Tacitus", "Tiberius", "Vitus", "Akio", "Akira", "Daiki", "Daisuke", "Goro", "Hachirou", "Haruto", "Hayate", "Hibiki", "Hideki", "Hideyoshi", "Ichiro", "Isamu", "Kaito", "Katashi", "Katsu", "Ken", "Naoki", "Rokurou", "Ryuu", "Saburou", "Sho", "Susumu", "Takahiro", "Takuma", "Takeshi", "Yoshiro", "Yuudai", "Yuuma", "Adrian", "Gabriel", "Alfonso", "Alejandro", "Andres", "Anselmo", "Antonio", "Benito", "Bernardo", "Diego", "Dionisio", "Edmundo", "Elias", "Faustino", "Felix", "Fidel", "Francisco", "Gerardo", "Jeremias", "Manuel", "Marco", "Vicente", "Matias", "Maximiliano", "Miguel", "Nicolas", "Rafael", "Roberto", "Sebastian", "Acat", "Atl", "Amoxtli", "Bacab", "Bahlan", "Cipactli", "Chimalli", "Cuauhtli", "Coatl", "Coyotl", "Eztli", "Etalpal", "Hunab-ku", "Itzal", "Kukulcan", "Matlal", "Necalli", "Tenoch", "Tohil", "Tlacelel", "Tlaneztic", "Tonatiuh", "Tototl", "Ueman", "Yaotl", "Yolotli", "Yopat", "Zolin", "Zipana", "Agni", "Alfr", "Bjorn", "Brandr", "Eirik", "Brokk", "Fafnir", "Geir", "Gunnar", "Ingvar", "Harald", "Hakon" , "Hrolf", "Leif", "Logmar", "Olav", "Ormar", "Randolf", "Sigmund", "Skari", "Snorre", "Steinn", "Stiger", "Torstein", "Torir", "Ulf", "Vidar", "Vermund", "Aedelric", "Adair", "Aelred", "Alden", "Ash", "Bentley", "Beort", "Cenric", "Chadwick", "Cuthbert", "Deor", "Dunstan", "Edmund", "Eadwulf", "Elwyn", "Ethelbert", "Godric", "Kendrick", "Hrodgar", "Leofric", "Osborn", "Oswald", "Peyton", "Seward", "Siegebert", "Ulric", "Wilfred", "Wulfnod", "Adelard", "Alain", "Alphonse", "Ambroise", "Anatole", "Antoine", "Bastien", "Bernard", "Christopher", "Corneille", "Dimitri", "Enzo", "Eustach", "Florentin", "Gaston", "Geoffrey", "Ignace", "Jacques", "Jerome", "Julien", "Lazare", "Louis", "Nicholas", "Patrice", "Pierre", "Remy", "Renard", "Tristan"
	};

	string[] femaleNames = new string[] {"Alba", "Aemilia", "Antonina", "Aquila", "Aurelia", "Balbina", "Blandina", "Caelia", "Cloelia", "Decima", "Domitia", "Drusa", "Fabiana", "Fabricia", "Flaviana", "Glaucia", "Herminia", "Hortensia", "Laurentia", "Longina", "Lucretia", "Nona", "Quintina", "Sabina", "Titiana", "Valeriana", "Varinia", "Vibiana", "Virginia", "Aiko", "Akane", "Akiko", "Ami", "Atsuki", "Chiyo", "Hanae", "Haruka", "Hikari", "Hina", "Hiroko", "Hitomi", "Izumi", "Kaede", "Kaori", "Kasumi", "Keiko", "Kimiko", "Kohaku", "Mai", "Manami", "Megumi", "Midori", "Naomi", "Riko", "Sakura", "Tomoko", "Yukiko", "Yumi", "Adriana", "Alicia", "Amalia", "Ambar", "Angela", "Aurora", "Azucena", "Beatriz", "Carmen", "Claudia", "Cristina", "Daniela", "Esperanza", "Estrella", "Fabiana", "Fernanda", "Iris", "Isabel", "Isidora", "Joana", "Liliana", "Lourdes", "Marisa", "Melisa", "Monica", "Paola", "Rocio", "Sofia", "Veronica", "Centehua", "Alkaia", "Antianara", "Cihuaton", "Citlali", "Cozcal", "Cuical", "Eumache", "Hypsipyle", "Ifito", "Itzel", "Ixtli", "Mahuiz", "Marpesia", "Molpadia", "Nenetl", "Papan", "Polemusa", "Pentesilea", "Thalestris", "Tlaco", "Tlalli", "Tonali", "Toxaris", "Valasca", "Xochitl", "Xipil", "Xoco", "Zyan", "Astrid", "Alfhild", "Asa", "Berliot", "Brigitte", "Brynhild", "Dagmar", "Dagrun", "Sigrun", "Eir", "Eydis", "Freya", "Frigg", "Ingrid", "Helle", "Hilda", "Idunn", "Inker", "Nanna", "Runa", "Sagald", "Skadi", "Skuld", "Toril", "Turid", "Urd", "Ulla", "Verdandi", "Aedelyn", "Godiva", "Hilda", "Ainsley", "Ashley", "Audrey", "Beverly", "Chelsea", "Daana", "Daisy", "Dreda", "Aeba", "Edith", "Elvina", "Leda", "Ethel", "Frieda", "Fae", "Hailey", "Kendra", "Kym", "Kinrough", "Leann", "Lily", "Mildred", "Millie", "Winnie", "Ophelia", "Alexia", "Amelie", "Anastasie", "Angelique", "Antoinette", "Arlette", "Barbara", "Beatrice", "Bernardine", "Blanche", "Cerise", "Claire", "Colette", "Eveline", "Josephine", "Fleur", "Genevieve", "Leonore", "Gisele", "Joceline", "Lisette", "Ludivine", "Magalie", "Marceline", "Odette", "Prune", "Valerie", "Yvette"
	};

	string[] surnames = new string[] { "Appuleia", "Artorius", "Ateia", "Balventia", "Bantia", "Barbatia", "Blossia", "Calavia", "Canidia", "Calidia", "Consentia", "Desticius", "Duronius", "Furia", "Gellia", "Herennia", "Juventia", "Lartia", "Lutatia", "Memnia", "Minucia", "Naevia", "Peltrasia", "Pinarius", "Pollia", "Salonia", "Trebatia", "Vergonius", "Volcatia", "Sato", "Suzuki", "Takahashi", "Tanaka", "Watanabe", "Ito", "Yamamoto", "Nakamura", "Kobayashi", "Kato", "Yoshida", "Saito", "Matsumoto", "Mori", "Ikeda", "Goto", "Hasegawa", "Endo", "Nishimura", "Fujiwara", "Ishida", "Ueda", "Uchida", "Ando", "Murata", "Masuda", "Kubo", "Noguchi", "Iwasaki", "Garcia", "Rodriguez", "Martinez", "Hernandez", "Lopez", "Rivera", "Diaz", "Reyes", "Ortiz", "Morales", "Herrera", "Aguilar", "Ramos", "Castro", "Salazar", "Soto", "Rios", "Vasquez", "Espinoza", "Marquez", "Robles", "Rosales", "Villarreal", "Rangel", "Galvan", "Velazquez", "Palacios", "Villalobos", "Gallardo", "Baas", "Batun", "Baak", "Canek", "Canul", "Camal", "Cetz", "Canche", "Catzim", "Ceh", "Cob", "Cocom", "Chable", "Chay", "Cupul", "Chim", "Chel", "Ek", "Euan", "Huchim", "Kuyoc", "Och", "Tah", "Tulum", "Xol", "Yoc", "Tzab", "Tlatil", "Tzul", "Ahlberg", "Akerman", "Albertsen", "Almsted", "Andersson", "Anker", "Bergfalk", "Bjork", "Blomgren", "Brams", "Breiner", "Eklund", "Eriksen", "Falk", "Fisker", "Grahn", "Haugen", "Kron", "Landvik", "Lindholm", "Nass", "Nordskov", "Olander", "Rask", "Stenger", "Strand", "Vang", "Vollan", "Addington", "Ainsworth", "Alston", "Barlow", "Benson", "Berkeley", "Bradshaw", "Clifford", "Coombs", "Cromwell", "Denholm", "Enfield", "Graham", "Halewell", "Hartford", "Huxley", "Lancaster", "Livingstone", "Nash", "Oakes", "Prescott", "Ramsey", "Remington", "Sherwood", "Stanton", "Tindall", "Wellington", "York", "Arnaud", "Auger", "Bauer", "Benoit", "Bergerac", "Bouvier", "Chirac", "Cloutier", "Danton", "Dubois", "Dumas", "Dupont", "Eisenberg", "Fournier", "Gaillard", "Gerard", "Guillaume", "Klein", "Monfort", "Montcourt", "Nagant", "Olivier", "Pinard", "Poisson", "Rousseau", "Schmidt", "Strauss", "Trudeau"
	};

	public string setName(NPCData.CharSex charSex)
	{
		iteration += 1;
		if (charSex == NPCData.CharSex.Man || charSex == NPCData.CharSex.Cuntboy) {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iteration); 
			randNum = Random.Range (0, 200);
			return maleNames [randNum];
		} else {
			Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iteration); 
			randNum = Random.Range (0, 200);
			return femaleNames [randNum];


		}

	}

	public string setSurname(){
		Random.InitState (hashcode + WorldControl.day * System.DateTime.Now.Millisecond + iteration); 
		randNum = Random.Range (0, 200);
		return surnames[randNum];
	}


}
