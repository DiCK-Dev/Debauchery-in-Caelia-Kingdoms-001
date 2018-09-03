using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CombatLoadSkillsPan : MonoBehaviour {


	int i;
	int x; 
	public Text[] skill = new Text[8]; 
	public Button[] skillButt = new Button[8];

	public int selector;

	public void loadSkillPanels()
	{
		if (selector == 0) {
			i = 0;
			while (i < GameControl.MCAttacks.Count) {
				skill [i].text = GameControl.MCAttacks [i].toDescription ();
				i++; 
				if (i > 7) {
					break; 
				}
			}

		} else if (selector == 1) {
			if (WorldControl.partyID1 < 10000000 && WorldControl.partyID1 != 0) 
			{
				i = 0; 
				while (i < NPCCharList.CharFollower.Count) {
					if (NPCCharList.CharFollower [i].charID == WorldControl.partyID1) 
					{
						x = 0; 
						while (x < NPCCharList.CharFollower [i].charAttacks.Count) {
							skill [x].text = NPCCharList.CharFollower [i].charAttacks [x].toDescription ();
							x++;
							if (x > 7) {
								break; 
							}
						}
						break;

					}

					i++;
				}
			} else if(WorldControl.partyID1 != 0)
			{
				i = 0; 
				while (i < NPCCharList.CharRetainers.Count) {
					if (NPCCharList.CharRetainers [i].charID == WorldControl.partyID1) 
					{
						x = 0; 
						while (x < NPCCharList.CharRetainers [i].charAttacks.Count) {
							skill [x].text = NPCCharList.CharRetainers[i].charAttacks [x].toDescription ();
							x++;
							if (x > 7) {
								break; 
							}
						}
						break;

					}

					i++;
				}
			}

		} else if (selector == 2) {
			if (WorldControl.partyID2 < 10000000 && WorldControl.partyID2 != 0) 
			{
				i = 0; 
				while (i < NPCCharList.CharFollower.Count) {
					if (NPCCharList.CharFollower [i].charID == WorldControl.partyID2) 
					{
						x = 0; 
						while (x < NPCCharList.CharFollower [i].charAttacks.Count) {
							skill [x].text = NPCCharList.CharFollower [i].charAttacks [x].toDescription ();
							x++;
							if (x > 7) {
								break; 
							}
						}
						break;

					}

					i++;
				}

			} else if(WorldControl.partyID2 != 0)
			{
				i = 0; 
				while (i < NPCCharList.CharRetainers.Count) {
					if (NPCCharList.CharRetainers [i].charID == WorldControl.partyID2) 
					{
						x = 0; 
						while (x < NPCCharList.CharRetainers [i].charAttacks.Count) {
							skill [x].text = NPCCharList.CharRetainers[i].charAttacks [x].toDescription ();
							x++;
							if (x > 7) {
								break; 
							}
						}
						break;

					}

					i++;
				}
			}

		} else if (selector == 3)
		{
			if (WorldControl.partyID3 < 10000000 && WorldControl.partyID3 != 0) 
			{
				i = 0; 
				while (i < NPCCharList.CharFollower.Count) {
					if (NPCCharList.CharFollower [i].charID == WorldControl.partyID3) 
					{
						x = 0; 
						while (x < NPCCharList.CharFollower [i].charAttacks.Count) {
							skill [x].text = NPCCharList.CharFollower [i].charAttacks [x].toDescription ();
							x++;
							if (x > 7) {
								break; 
							}
						}
						break;

					}

					i++;
				}

			} else if(WorldControl.partyID3 != 0)
			{
				i = 0; 
				while (i < NPCCharList.CharRetainers.Count) {
					if (NPCCharList.CharRetainers [i].charID == WorldControl.partyID2) 
					{
						x = 0; 
						while (x < NPCCharList.CharRetainers [i].charAttacks.Count) {
							skill [x].text = NPCCharList.CharRetainers[i].charAttacks [x].toDescription ();
							x++;
							if (x > 7) {
								break; 
							}
						}
						break;

					}

					i++;
				}
			}


		}


	}


	public void loadSkillButtons()
	{
		if (selector == 0) {
			i = 0;
			while (i < GameControl.MCAttacks.Count) {
				skillButt[i].interactable = true; 
				i++; 
				if (i > 7) {
					break; 
				}
			}

		} else if (selector == 1) {
			if (WorldControl.partyID1 < 10000000 && WorldControl.partyID1 != 0) 
			{
				i = 0; 
				while (i < NPCCharList.CharFollower.Count) {
					if (NPCCharList.CharFollower [i].charID == WorldControl.partyID1) 
					{
						x = 0; 
						while (x < NPCCharList.CharFollower [i].charAttacks.Count) {
							skillButt[x].interactable = true; 
							x++;
							if (x > 7) {
								break; 
							}
						}
						break;

					}

					i++;
				}
			} else if(WorldControl.partyID1 != 0)
			{
				i = 0; 
				while (i < NPCCharList.CharRetainers.Count) {
					if (NPCCharList.CharRetainers [i].charID == WorldControl.partyID1) 
					{
						x = 0; 
						while (x < NPCCharList.CharRetainers [i].charAttacks.Count) {
							skillButt[x].interactable = true; 
							x++;
							if (x > 7) {
								break; 
							}
						}
						break;

					}

					i++;
				}
			}

		} else if (selector == 2) {
			if (WorldControl.partyID2 < 10000000 && WorldControl.partyID2 != 0) 
			{
				i = 0; 
				while (i < NPCCharList.CharFollower.Count) {
					if (NPCCharList.CharFollower [i].charID == WorldControl.partyID2) 
					{
						x = 0; 
						while (x < NPCCharList.CharFollower [i].charAttacks.Count) {
							skillButt[x].interactable = true; 
							x++;
							if (x > 7) {
								break; 
							}
						}
						break;

					}

					i++;
				}

			} else if(WorldControl.partyID2 != 0)
			{
				i = 0; 
				while (i < NPCCharList.CharRetainers.Count) {
					if (NPCCharList.CharRetainers [i].charID == WorldControl.partyID2) 
					{
						x = 0; 
						while (x < NPCCharList.CharRetainers [i].charAttacks.Count) {
							skillButt[x].interactable = true; 
							x++;
							if (x > 7) {
								break; 
							}
						}
						break;

					}

					i++;
				}
			}

		} else if (selector == 3)
		{
			if (WorldControl.partyID3 < 10000000 && WorldControl.partyID3 != 0) 
			{
				i = 0; 
				while (i < NPCCharList.CharFollower.Count) {
					if (NPCCharList.CharFollower [i].charID == WorldControl.partyID3) 
					{
						x = 0; 
						while (x < NPCCharList.CharFollower [i].charAttacks.Count) {
							skillButt[x].interactable = true; 
							x++;
							if (x > 7) {
								break; 
							}
						}
						break;

					}

					i++;
				}

			} else if(WorldControl.partyID3 != 0)
			{
				i = 0; 
				while (i < NPCCharList.CharRetainers.Count) {
					if (NPCCharList.CharRetainers [i].charID == WorldControl.partyID2) 
					{
						x = 0; 
						while (x < NPCCharList.CharRetainers [i].charAttacks.Count) {
							skillButt[x].interactable = true; 
							x++;
							if (x > 7) {
								break; 
							}
						}
						break;

					}

					i++;
				}
			}


		}


	}



	void Start (){
		loadSkillPanels ();
		loadSkillButtons ();

	}



}
