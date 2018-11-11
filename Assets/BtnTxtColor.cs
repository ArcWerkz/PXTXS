using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BtnTxtColor : MonoBehaviour {

	private TextMeshPro mm_Text;


	// Use this for initialization
	void Awake () {
		TextMeshPro mm_Text = GetComponent<TextMeshPro>();
		mm_Text.faceColor = Color.white;
	}
	

	void clickedTxt(){
		mm_Text.faceColor = Color.white;
	}

	void outTxt(){
		mm_Text.faceColor = Color.red;
	}


}
