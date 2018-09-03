using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BotPanelKeyInput : MonoBehaviour {

	public Canvas buttCanvas; 
	static bool buttClicked; 

	public Button butt1row1; //1
	public Button butt2row1;
	public Button butt3row1;
	public Button butt4row1;
	public Button butt5row1; // 5
	public Button butt1row2;
	public Button butt2row2;
	public Button butt3row2;
	public Button butt4row2;
	public Button butt5row2;
	public Button butt1row3;
	public Button butt2row3;
	public Button butt3row3;
	public Button butt4row3;
	public Button butt5row3;

	IEnumerator waitSecond(){
		if (buttClicked == true) {
			yield return new WaitForSeconds (0.8f);
			buttClicked = false; 

		}

	}


	void Update ()
	{

		if (buttCanvas.sortingOrder > 0) {

			bool KeyDown1 = Input.GetKey (KeyCode.Alpha1);
			bool KeyDown2 = Input.GetKey (KeyCode.Alpha2);
			bool KeyDown3 = Input.GetKey (KeyCode.Alpha3);
			bool KeyDown4 = Input.GetKey (KeyCode.Alpha4);
			bool KeyDown5 = Input.GetKey (KeyCode.Alpha5);

			bool KeyDownQ = Input.GetKey (KeyCode.Q);
			bool KeyDownW = Input.GetKey (KeyCode.W);
			bool KeyDownE = Input.GetKey (KeyCode.E);
			bool KeyDownR = Input.GetKey (KeyCode.R);
			bool KeyDownT = Input.GetKey (KeyCode.T);

			bool KeyDownA = Input.GetKey (KeyCode.A);
			bool KeyDownS = Input.GetKey (KeyCode.S);
			bool KeyDownD = Input.GetKey (KeyCode.D);
			bool KeyDownF = Input.GetKey (KeyCode.F);
			bool KeyDownG = Input.GetKey (KeyCode.G);


			if (KeyDown1 == true) {
				if (butt1row1.interactable == true) {
					if (buttClicked == false) {
						butt1row1.onClick.Invoke ();
						buttClicked = true; 
						StartCoroutine ("waitSecond");
					}

				}
			}


			if (KeyDown2 == true) {
				if (butt2row1.interactable == true) {
					if (buttClicked == false) {
						butt2row1.onClick.Invoke ();
						buttClicked = true; 
						StartCoroutine ("waitSecond");
					}
				}

			}


			if (KeyDown3 == true) {
				if (butt3row1.interactable == true) {
					if (buttClicked == false) {
						butt3row1.onClick.Invoke ();
						buttClicked = true; 
						StartCoroutine ("waitSecond");
					}
				}


			}


			if (KeyDown4 == true) {
				if (butt4row1.interactable == true) {
					if (buttClicked == false) {
						butt4row1.onClick.Invoke ();
						buttClicked = true; 
						StartCoroutine ("waitSecond");
					}
				}

			}



			if (KeyDown5 == true) {

				if (butt5row1.interactable == true) {
					if (buttClicked == false) {
						butt5row1.onClick.Invoke ();
						buttClicked = true; 
						StartCoroutine ("waitSecond");
					}
				}

			}


			if (KeyDownQ == true) {
				if (butt1row2.interactable == true) {

					if (buttClicked == false) {
						butt1row2.onClick.Invoke ();
						buttClicked = true; 
						StartCoroutine ("waitSecond");
					}
				}

			}



			if (KeyDownW == true) {
				if (butt2row2.interactable == true) {
					if (buttClicked == false) {
						butt2row2.onClick.Invoke ();
						buttClicked = true; 
						StartCoroutine ("waitSecond");
					}
				}
			}


			if (KeyDownE == true) {
				if (butt3row2.interactable == true) {
					if (buttClicked == false) {
						butt3row2.onClick.Invoke ();
						buttClicked = true; 
						StartCoroutine ("waitSecond");
					}
				}

			}


			if (KeyDownR == true) {
				if (butt4row2.interactable == true) {
					if (buttClicked == false) {
						butt4row2.onClick.Invoke ();
						buttClicked = true; 
						StartCoroutine ("waitSecond");
					}
				}

			}


			if (KeyDownT == true) {
				if (butt5row2.interactable == true) {
					if (buttClicked == false) {
						butt5row2.onClick.Invoke ();
						buttClicked = true; 
						StartCoroutine ("waitSecond");
					}
				}

			}


			if (KeyDownA == true) {

				if (butt1row3.interactable == true) {
					if (buttClicked == false) {
						butt1row3.onClick.Invoke ();
						buttClicked = true; 
						StartCoroutine ("waitSecond");
					}
				}

			}

			if (KeyDownS == true) {
				if (butt2row3.interactable == true) {
					if (buttClicked == false) {
						butt2row3.onClick.Invoke ();
						buttClicked = true; 
						StartCoroutine ("waitSecond");
					}
				}

			}


			if (KeyDownD == true) {
				if (butt3row3.interactable == true) {
					if (buttClicked == false) {
						butt3row3.onClick.Invoke ();
						buttClicked = true; 
						StartCoroutine ("waitSecond");
					}
				}

			}



			if (KeyDownF == true) {
				if (butt4row3.interactable == true) {
					if (buttClicked == false) {
						butt4row3.onClick.Invoke ();
						buttClicked = true; 
						StartCoroutine ("waitSecond");
					}
				}

			}

			if (KeyDownG == true) {
				if (butt5row3.interactable == true) {
					if (buttClicked == false) {
						butt5row3.onClick.Invoke ();
						buttClicked = true; 
						StartCoroutine ("waitSecond");
					}
				}

			}

		}

	}


	void Awake(){
		buttClicked = false; 
	}

}
