using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class SlaveMarketHover : MonoBehaviour {
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
		hover1TextA.text = ItemData.itemDataList[20001].itemDescription; 
		hover1TextB.text = ""; 
	}

	public void item2(){
		panHover2.SetAsLastSibling ();
		hover2TextA.text = ItemData.itemDataList[20001].itemDescription; 
		hover2TextB.text = ""; 
	}

	public void item3(){
		panHover3.SetAsLastSibling ();
		hover3TextA.text = ItemData.itemDataList[20001].itemDescription; 
		hover3TextB.text = ""; 
	}

	public void item4(){
		panHover4.SetAsLastSibling ();
		hover4TextA.text = ItemData.itemDataList[20001].itemDescription; 
		hover4TextB.text = ""; 
	}

	public void item5(){
		panHover5.SetAsLastSibling ();
		hover5TextA.text = ItemData.itemDataList[20001].itemDescription; 
		hover5TextB.text = ""; 
	}

	public void Elixir1(){
		panHover1.SetAsLastSibling ();
		hover1TextA.text = ItemData.itemDataList[151].itemDescription; 
		hover1TextB.text = ""; 
	}

	public void Elixir2(){
		panHover2.SetAsLastSibling ();
		hover2TextA.text = ItemData.itemDataList[156].itemDescription; 
		hover2TextB.text = ""; 
	}

	public void Weap1(){
		panHover1.SetAsLastSibling ();
		hover1TextA.text = ItemData.itemDataList[10003].itemDescription; 
		hover1TextB.text = ""; 
	}

	public void Weap2(){
		panHover2.SetAsLastSibling ();
		hover2TextA.text = ItemData.itemDataList[10005].itemDescription; 
		hover2TextB.text = ""; 
	}




	public void potion1(){
		panHover1.SetAsLastSibling ();
		hover1TextA.text = ItemData.itemDataList[1000].itemDescription; 
		hover1TextB.text = ""; 
	}

	public void potion2(){
		panHover2.SetAsLastSibling ();
		hover2TextA.text = ItemData.itemDataList[1004].itemDescription; 
		hover2TextB.text = ""; 
	}

	public void potion3(){
		panHover3.SetAsLastSibling ();
		hover3TextA.text = ItemData.itemDataList[1005].itemDescription; 
		hover3TextB.text = ""; 
	}

	public void potion4(){
		panHover4.SetAsLastSibling ();
		hover4TextA.text = ItemData.itemDataList[1009].itemDescription; 
		hover4TextB.text = ""; 
	}

	public void potion5(){
		panHover5.SetAsLastSibling ();
		hover5TextA.text = ItemData.itemDataList[1010].itemDescription; 
		hover5TextB.text = ""; 
	}

	public void potion6(){
		panHover1.SetAsLastSibling ();
		hover1TextA.text = ItemData.itemDataList[1014].itemDescription; 
		hover1TextB.text = ""; 
	}

	public void potion7(){
		panHover2.SetAsLastSibling ();
		hover2TextA.text = ItemData.itemDataList[1015].itemDescription; 
		hover2TextB.text = ""; 
	}

	public void potion8(){
		panHover3.SetAsLastSibling ();
		hover3TextA.text = ItemData.itemDataList[1019].itemDescription; 
		hover3TextB.text = ""; 
	}

	public void potion9(){
		panHover4.SetAsLastSibling ();
		hover4TextA.text = ItemData.itemDataList[1020].itemDescription; 
		hover4TextB.text = ""; 
	}

	public void potion10(){
		panHover5.SetAsLastSibling ();
		hover5TextA.text = ItemData.itemDataList[1024].itemDescription; 
		hover5TextB.text = ""; 
	}
	public void potion11(){
		panHover1.SetAsLastSibling ();
		hover1TextA.text = ItemData.itemDataList[1025].itemDescription; 
		hover1TextB.text = ""; 
	}

	public void potion12(){
		panHover2.SetAsLastSibling ();
		hover2TextA.text = ItemData.itemDataList[1029].itemDescription; 
		hover2TextB.text = ""; 
	}

	public void potion1a(){
		panHover1.SetAsLastSibling ();
		hover1TextA.text = ItemData.itemDataList[1030].itemDescription; 
		hover1TextB.text = ""; 
	}

	public void potion2a(){
		panHover2.SetAsLastSibling ();
		hover2TextA.text = ItemData.itemDataList[1034].itemDescription; 
		hover2TextB.text = ""; 
	}

	public void potion3a(){
		panHover3.SetAsLastSibling ();
		hover3TextA.text = ItemData.itemDataList[1035].itemDescription; 
		hover3TextB.text = ""; 
	}

	public void potion4a(){
		panHover4.SetAsLastSibling ();
		hover4TextA.text = ItemData.itemDataList[1039].itemDescription; 
		hover4TextB.text = ""; 
	}

	public void potion5a(){
		panHover5.SetAsLastSibling ();
		hover5TextA.text = ItemData.itemDataList[1040].itemDescription; 
		hover5TextB.text = ""; 
	}

	public void potion6a(){
		panHover1.SetAsLastSibling ();
		hover1TextA.text = ItemData.itemDataList[1044].itemDescription; 
		hover1TextB.text = ""; 
	}





}
