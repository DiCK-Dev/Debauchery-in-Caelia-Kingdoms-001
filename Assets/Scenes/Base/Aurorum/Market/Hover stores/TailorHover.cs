using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TailorHover : MonoBehaviour {
	public RectTransform panHover1;
	public RectTransform panHover2;
	public RectTransform panHover3;
	public RectTransform panHover4;
	public RectTransform panHover5;

	public Text hover1TextA;
	public Text hover1TextB;
	public Text hover2TextA;
	public Text hover2TextB;
	public Text hover3TextA;
	public Text hover3TextB;
	public Text hover4TextA;
	public Text hover4TextB;
	public Text hover5TextA;
	public Text hover5TextB;




	public void item1(){
		panHover1.SetAsLastSibling ();
		hover1TextA.text = ItemData.itemDataList[20008].itemDescription; 
		hover1TextB.text = ""; 
	}

	public void item2(){
		panHover2.SetAsLastSibling ();
		hover2TextA.text = ItemData.itemDataList[20009].itemDescription; 
		hover2TextB.text = ""; 
	}

	public void item3(){
		panHover3.SetAsLastSibling ();
		hover3TextA.text = ItemData.itemDataList[20012].itemDescription; 
		hover3TextB.text = ""; 
	}

	public void item4(){
		panHover4.SetAsLastSibling ();
		hover4TextA.text = ItemData.itemDataList[20005].itemDescription; 
		hover4TextB.text = ""; 
	}

	public void item5(){
		panHover5.SetAsLastSibling ();
		hover5TextA.text = ItemData.itemDataList[20007].itemDescription; 
		hover5TextB.text = ""; 
	}

	/// <summary>
	/// C////	/// </summary>

	public void cloth1(){
		panHover1.SetAsLastSibling ();
		hover1TextA.text = ItemData.itemDataList[20008].itemDescription; 
		hover1TextB.text = ""; 
	}

	public void cloth2(){
		panHover2.SetAsLastSibling ();
		hover2TextA.text = ItemData.itemDataList[20009].itemDescription; 
		hover2TextB.text = ""; 
	}

	public void cloth3(){
		panHover3.SetAsLastSibling ();
		hover3TextA.text = ItemData.itemDataList[20012].itemDescription; 
		hover3TextB.text = ""; 
	}

	public void cloth4(){
		panHover4.SetAsLastSibling ();
		hover4TextA.text = ItemData.itemDataList[20005].itemDescription; 
		hover4TextB.text = ""; 
	}

	public void cloth5(){
		panHover5.SetAsLastSibling ();
		hover5TextA.text = ItemData.itemDataList[20007].itemDescription; 
		hover5TextB.text = ""; 
	}

	public void cloth6(){
		panHover1.SetAsLastSibling ();
		hover1TextA.text = ItemData.itemDataList[20010].itemDescription; 
		hover1TextB.text = ""; 
	}

	public void cloth7(){
		panHover2.SetAsLastSibling ();
		hover2TextA.text = ItemData.itemDataList[20011].itemDescription; 
		hover2TextB.text = ""; 
	}

	public void cloth8(){
		panHover3.SetAsLastSibling ();
		hover3TextA.text = ItemData.itemDataList[20013].itemDescription; 
		hover3TextB.text = ""; 
	}



	public void head1(){
		panHover1.SetAsLastSibling ();
		hover1TextA.text = ItemData.itemDataList[30003].itemDescription; 
		hover1TextB.text = ""; 
	}

	public void head2(){
		panHover2.SetAsLastSibling ();
		hover2TextA.text = ItemData.itemDataList[30004].itemDescription; 
		hover2TextB.text = ""; 
	}

	public void face1(){
		panHover1.SetAsLastSibling ();
		hover1TextA.text = ItemData.itemDataList[40001].itemDescription; 
		hover1TextB.text = ""; 
	}

	public void face2(){
		panHover2.SetAsLastSibling ();
		hover2TextA.text = ItemData.itemDataList[40003].itemDescription; 
		hover2TextB.text = ""; 
	}

	public void face3(){
		panHover3.SetAsLastSibling ();
		hover3TextA.text = ItemData.itemDataList[40004].itemDescription; 
		hover3TextB.text = ""; 
	}


	public void neck1(){
		panHover1.SetAsLastSibling ();
		hover1TextA.text = ItemData.itemDataList[50001].itemDescription; 
		hover1TextB.text = ""; 
	}

	public void neck2(){
		panHover2.SetAsLastSibling ();
		hover2TextA.text = ItemData.itemDataList[50004].itemDescription; 
		hover2TextB.text = ""; 
	}

	public void neck3(){
		panHover3.SetAsLastSibling ();
		hover3TextA.text = ItemData.itemDataList[50005].itemDescription; 
		hover3TextB.text = ""; 
	}


	public void shoulders1(){
		panHover1.SetAsLastSibling ();
		hover1TextA.text = ItemData.itemDataList[60001].itemDescription; 
		hover1TextB.text = ""; 
	}

	public void shoulders2(){
		panHover2.SetAsLastSibling ();
		hover2TextA.text = ItemData.itemDataList[60002].itemDescription; 
		hover2TextB.text = ""; 
	}

	public void shoulders3(){
		panHover3.SetAsLastSibling ();
		hover3TextA.text = ItemData.itemDataList[60003].itemDescription; 
		hover3TextB.text = ""; 
	}


	public void hands1(){
		panHover1.SetAsLastSibling ();
		hover1TextA.text = ItemData.itemDataList[70002].itemDescription; 
		hover1TextB.text = ""; 
	}

	public void hands2(){
		panHover2.SetAsLastSibling ();
		hover2TextA.text = ItemData.itemDataList[70003].itemDescription; 
		hover2TextB.text = ""; 
	}

	public void hands3(){
		panHover3.SetAsLastSibling ();
		hover3TextA.text = ItemData.itemDataList[70004].itemDescription; 
		hover3TextB.text = ""; 
	}

	public void hands4(){
		panHover4.SetAsLastSibling ();
		hover4TextA.text = ItemData.itemDataList[70005].itemDescription; 
		hover4TextB.text = ""; 
	}

	public void hands5(){
		panHover5.SetAsLastSibling ();
		hover5TextA.text = ItemData.itemDataList[70006].itemDescription; 
		hover5TextB.text = ""; 
	}

	public void shoes1(){
		panHover1.SetAsLastSibling ();
		hover1TextA.text = ItemData.itemDataList[80003].itemDescription; 
		hover1TextB.text = ""; 
	}

	public void shoes2(){
		panHover2.SetAsLastSibling ();
		hover2TextA.text = ItemData.itemDataList[80004].itemDescription; 
		hover2TextB.text = ""; 
	}

	public void shoes3(){
		panHover3.SetAsLastSibling ();
		hover3TextA.text = ItemData.itemDataList[80005].itemDescription; 
		hover3TextB.text = ""; 
	}







}
