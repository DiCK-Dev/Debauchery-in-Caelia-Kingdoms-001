using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FakeScrollbar : MonoBehaviour {

	public Slider realSlider;
	public Scrollbar RealScrollBar;

	public void sliderChange(float scrollValue){
		realSlider.value = scrollValue;


	}

	public void scrollBarChange(float sliderValue){
		RealScrollBar.value = sliderValue;
	}

}