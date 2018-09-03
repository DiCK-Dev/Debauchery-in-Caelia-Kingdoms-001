using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BlacksmithHover : MonoBehaviour {
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


	public void weap1(){
		panHover1.SetAsLastSibling ();
		hover1TextA.text = ItemData.itemDataList[10002].itemDescription; 
		hover1TextB.text = ""; 
	}

	public void weap2(){
		panHover2.SetAsLastSibling ();
		hover2TextA.text = ItemData.itemDataList[10004].itemDescription; 
		hover2TextB.text = ""; 
	}

	public void weap3(){
		panHover3.SetAsLastSibling ();
		hover3TextA.text = ItemData.itemDataList[10006].itemDescription; 
		hover3TextB.text = ""; 
	}


	public void helm1(){
		panHover1.SetAsLastSibling ();
		hover1TextA.text = ItemData.itemDataList[30001].itemDescription; 
		hover1TextB.text = ""; 
	}

	public void helm2(){
		panHover2.SetAsLastSibling ();
		hover2TextA.text = ItemData.itemDataList[30002].itemDescription; 
		hover2TextB.text = ""; 
	}


	public void face1(){
		panHover1.SetAsLastSibling ();
		hover1TextA.text = ItemData.itemDataList[40002].itemDescription; 
		hover1TextB.text = ""; 
	}

	public void Neck1(){
		panHover1.SetAsLastSibling ();
		hover1TextA.text = ItemData.itemDataList[50002].itemDescription; 
		hover1TextB.text = ""; 
	}

	public void Neck2(){
		panHover2.SetAsLastSibling ();
		hover2TextA.text = ItemData.itemDataList[50003].itemDescription; 
		hover2TextB.text = ""; 
	}

	public void Shoulders1(){
		panHover1.SetAsLastSibling ();
		hover1TextA.text = ItemData.itemDataList[60004].itemDescription;  
		hover1TextB.text = ""; 
	}

	public void Shoulders2(){
		panHover2.SetAsLastSibling ();
		hover2TextA.text = ItemData.itemDataList[60005].itemDescription; 
		hover2TextB.text = ""; 
	}
	public void Hands1(){
		panHover1.SetAsLastSibling ();
		hover1TextA.text = ItemData.itemDataList[70001].itemDescription; 
		hover1TextB.text = ""; 
	}
	public void Shoes1(){
		panHover1.SetAsLastSibling ();
		hover1TextA.text = ItemData.itemDataList[80001].itemDescription; 
		hover1TextB.text = ""; 
	}

	public void Shoes2(){
		panHover2.SetAsLastSibling ();
		hover2TextA.text = ItemData.itemDataList[80002].itemDescription; 
		hover2TextB.text = ""; 
	}

	public void Armour1(){
		panHover1.SetAsLastSibling ();
		hover1TextA.text = ItemData.itemDataList[20001].itemDescription; 
		hover1TextB.text = ""; 
	}

	public void Armour2(){
		panHover2.SetAsLastSibling ();
		hover2TextA.text = ItemData.itemDataList[20002].itemDescription; 
		hover2TextB.text = ""; 
	}

	public void Armour3(){
		panHover3.SetAsLastSibling ();
		hover3TextA.text = ItemData.itemDataList[20003].itemDescription; 
		hover3TextB.text = ""; 
	}

	public void Armour4(){
		panHover4.SetAsLastSibling ();
		hover4TextA.text = ItemData.itemDataList[20004].itemDescription; 
		hover4TextB.text = ""; 
	}

	public void Armour5(){
		panHover1.SetAsLastSibling ();
		hover5TextA.text = ItemData.itemDataList[20006].itemDescription; 
		hover5TextB.text = ""; 
	}

	public void Armour6(){
		panHover2.SetAsLastSibling ();
		hover2TextA.text = ItemData.itemDataList[20014].itemDescription; 
		hover2TextB.text = ""; 

	}

	void Awake (){

	}




}
