using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tParser : MonoBehaviour {



	public Text story;

	public int currentPg = 0;

	public GameObject introContainer;
	public GameObject[] introPath;

	public GameObject sxgContainer;
	public GameObject[] sxgPath;

	public GameObject sxgxbContainer;
	public GameObject[] sxgxbPath;

	public GameObject gxgxbContainer;
	public GameObject[] gxgxbPath;

	public GameObject sxgxwContainer;
	public GameObject[] sxgxwPath;

	public GameObject gxgxwContainer;
	public GameObject[] gxgxwPath;









	// Use this for initialization
	void Start () {




		Intro1();


	}
	
	// Update is called once per frame
	void Update () {

		paths();


		
	}

	void paths(){
		switch (currentPg) {
		case 09:
			introContainer.SetActive (false);
			sxgContainer.SetActive (true);
			sxgPath [0].SetActive (true);
			break;

		case 08:
			introContainer.SetActive (false);
			gxgxbContainer.SetActive (true);
			gxgxbPath [0].SetActive (true);
			break;

		case 11:
			introContainer.SetActive (false);
			sxgxbContainer.SetActive (true);
			sxgxbPath [0].SetActive (true);
			break;

		}
	}



	//intro-files
	public void Intro1(){
		TextAsset src = Resources.Load("pxtxs-intro/pxtxs-day1") as TextAsset;
		story.text = src.text;
		currentPg = 00;
		introPath [0].SetActive (true);

	}

	public void Intro2(){
		TextAsset src =  (TextAsset)Resources.Load("pxtxs-intro/pxtxs-day2") as TextAsset;
		story.text = src.text;
		currentPg = 01;
		introPath [0].SetActive (false);
		introPath [1].SetActive (true);
		introPath [2].SetActive (true);
		introPath [3].SetActive (true);

	}

	public void Intro3g(){
		TextAsset src = (TextAsset)Resources.Load("pxtxs-intro/pxtxs-day3g") as TextAsset;
		story.text = src.text;
		currentPg = 02;
		introPath [1].SetActive (false);
		introPath [2].SetActive (false);
		introPath [3].SetActive (false);
		introPath [4].SetActive (true);


	}

	public void Intro3n(){
		TextAsset src =  (TextAsset)Resources.Load("pxtxs-intro/pxtxs-day3n") as TextAsset;
		story.text = src.text;
		currentPg = 03;
		introPath [1].SetActive (false);
		introPath [2].SetActive (false);
		introPath [3].SetActive (false);
		introPath [5].SetActive (true);

	}

	public void Intro3b(){
		TextAsset src =  (TextAsset)Resources.Load("pxtxs-intro/pxtxs-day3b") as TextAsset;
		story.text = src.text;
		currentPg = 04;
		introPath [1].SetActive (false);
		introPath [2].SetActive (false);
		introPath [3].SetActive (false);

	}

	public void Intro4g(){
		TextAsset src =  (TextAsset)Resources.Load("pxtxs-intro/pxtxs-day4g") as TextAsset;
		story.text = src.text;
		currentPg = 05;
		introPath [4].SetActive (false);
		introPath [6].SetActive (true);
		introPath [7].SetActive (true);
		introPath [8].SetActive (true);


	}

	public void Intro4n(){
		TextAsset src =  (TextAsset)Resources.Load("pxtxs-intro/pxtxs-day4n") as TextAsset;
		story.text = src.text;
		currentPg = 06;
		introPath [5].SetActive (false);
		introPath [9].SetActive (true);

	}

	public void Intro4b(){
		TextAsset src =  (TextAsset)Resources.Load("pxtxs-intro/pxtxs-day4b") as TextAsset;
		story.text = src.text;
		currentPg = 07;

	}

	public void Intro5g(){
		TextAsset src =  (TextAsset)Resources.Load("pxtxs-intro/pxtxs-day5g") as TextAsset;
		story.text = src.text;
		currentPg = 08;

	}

	public void Intro5n(){
		TextAsset src =  (TextAsset)Resources.Load("pxtxs-intro/pxtxs-day5n") as TextAsset;
		story.text = src.text;
		currentPg = 09;

	}

	public void Intro5b(){
		TextAsset src =  (TextAsset)Resources.Load("pxtxs-intro/pxtxs-day5b") as TextAsset;
		story.text = src.text;
		currentPg = 010;

	}

	public void Int5ns(){
		TextAsset src = (TextAsset)Resources.Load("pxtxs-intro/pxtxs-day5n-s") as TextAsset;
		story.text = src.text;
		currentPg = 011;

	}

	//Solo-Gun
	//Main
	public void sxg6(){
		TextAsset src = (TextAsset)Resources.Load("solo-gun/pxtxs-day6") as TextAsset;
		story.text = src.text;
		currentPg = 012;
		sxgPath [0].SetActive (false);
		sxgPath [1].SetActive (true);

	}
	

	//Elevator
	public void sxg7e(){
		TextAsset src = (TextAsset)Resources.Load("solo-gun/Elevator/pxtxs-Day7-E") as TextAsset;
		story.text = src.text;
		currentPg = 013;
		sxgPath [1].SetActive (false);
		sxgPath [12].SetActive (true);

	
	}

	public void sxg8e(){
		TextAsset src = (TextAsset)Resources.Load("solo-gun/Elevator/pxtxs-Day8-E") as TextAsset;
		story.text = src.text;
		currentPg = 014;

	}

	public void sxg9e(){
		TextAsset src = (TextAsset)Resources.Load("solo-gun/Elevator/pxtxs-Day9-E") as TextAsset;
		story.text = src.text;
		currentPg = 015;

	}


	//Stairs
	public void sxg7s(){
		TextAsset src = (TextAsset)Resources.Load("solo-gun/Stairs/pxtxs-Day7-S") as TextAsset;
		story.text = src.text;
		currentPg = 016;
		
	}

	public void sxg8s(){
		TextAsset src = (TextAsset)Resources.Load("solo-gun/Stairs/pxtxs-Day8-Floor1") as TextAsset;
		story.text = src.text;
		currentPg = 017;


	}

	public void sxg10s(){
		TextAsset src = (TextAsset)Resources.Load("solo-gun/Stairs/pxtxs-Day10-S") as TextAsset;
		story.text = src.text;
		currentPg = 018;


	}

	public void sxg11s(){
		TextAsset src = (TextAsset)Resources.Load("solo-gun/Stairs/pxtxs-Day11-S") as TextAsset;
		story.text = src.text;
		currentPg = 019;


	}

	public void sxg12s(){
		TextAsset src = (TextAsset)Resources.Load("solo-gun/Stairs/pxtxs-Day12-S") as TextAsset;
		story.text = src.text;
		currentPg = 020;


	}

	public void sxg13s(){
		TextAsset src = (TextAsset)Resources.Load("solo-gun/Stairs/pxtxs-Day13-S") as TextAsset;
		story.text = src.text;
		currentPg = 021;


	}


	//Fire Escape
	public void sxg10f(){
		TextAsset src = (TextAsset)Resources.Load("solo-gun/Fire Escape/pxtxs-Day10-F") as TextAsset;
		story.text = src.text;
		currentPg = 022;

		
	}

	public void sxg11f(){
		TextAsset src = (TextAsset)Resources.Load("solo-gun/Fire Escape/pxtxs-Day11-F") as TextAsset;
		story.text = src.text;
		currentPg = 023;


	}

	public void sxg12f(){
		TextAsset src = (TextAsset)Resources.Load("solo-gun/Fire Escape/pxtxs-Day12-F") as TextAsset;
		story.text = src.text;
		currentPg = 024;


	}

	public void sxg13f(){
		TextAsset src = (TextAsset)Resources.Load("solo-gun/Fire Escape/pxtxs-Day13-F") as TextAsset;
		story.text = src.text;
		currentPg = 025;


	}



	//End
	public void sxgEnd8s(){
		TextAsset src = (TextAsset)Resources.Load("solo-gun/Stairs/Day8-End/pxtxs-Day8-S-End") as TextAsset;
		story.text = src.text;
		currentPg = 026;

		
	}

	public void sxgEnd11s(){
		TextAsset src = (TextAsset)Resources.Load("solo-gun/Stairs/Day11-End/pxtxs-Day11-S-End") as TextAsset;
		story.text = src.text;
		currentPg = 027;


	}

	public void sxgEnd11f(){
		TextAsset src = (TextAsset)Resources.Load("solo-gun/Fire Escape/Day11-End/pxtxs-Day11-F-End") as TextAsset;
		story.text = src.text;
		currentPg = 028;

		
	}

	public void sxgEnd13(){
		TextAsset src = (TextAsset)Resources.Load("solo-gun/pxtxs-Day13-End") as TextAsset;
		story.text = src.text;
		currentPg = 029;


	}


	//Solo-Gun-Bat
	//Main
	public void sxgxbMain1(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxbat/pxtxs-day6") as TextAsset;
		story.text = src.text;
		currentPg = 112;

	}



	//Elevator
	public void sxgxb7e(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxbat/Elevator/pxtxs-Day7-E") as TextAsset;
		story.text = src.text;
		currentPg = 113;

	}

	public void sxgxb8e(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxbat/Elevator/pxtxs-Day8(g)-E") as TextAsset;
		story.text = src.text;
		currentPg = 114;

	}

	public void sxgxb9e(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxbat/Elevator/pxtxs-Day9-E") as TextAsset;
		story.text = src.text;
		currentPg = 115;

	}


	//Stairs
	public void sxgxb7s(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxbat/Stairs/pxtxs-Day7") as TextAsset;
		story.text = src.text;
		currentPg = 116;

	}

	public void sxgxb8s(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxbat/Stairs/pxtxs-Day8-Floor1") as TextAsset;
		story.text = src.text;
		currentPg = 117;


	}

	public void sxgxb10s(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxbat/Stairs/pxtxs-Day10-S") as TextAsset;
		story.text = src.text;
		currentPg = 118;


	}

	public void sxgxb11s(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxbat/Stairs/pxtxs-Day11(g)-S") as TextAsset;
		story.text = src.text;
		currentPg = 119;


	}

	public void sxgxb12s(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxbat/Stairs/pxtxs-Day12-S") as TextAsset;
		story.text = src.text;
		currentPg = 120;


	}

	public void sxgxb13s(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxbat/Stairs/pxtxs-Day13-S") as TextAsset;
		story.text = src.text;
		currentPg = 121;


	}


	//Fire Escape
	public void sxgxb10f(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxbat/Fire Escape/pxtxs-Day10-F") as TextAsset;
		story.text = src.text;
		currentPg = 122;


	}

	public void sxgxb11f(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxbat/Fire Escape/pxtxs-Day11-F") as TextAsset;
		story.text = src.text;
		currentPg = 123;


	}

	public void sxgxb12f(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxbat/Fire Escape/pxtxs-Day12-F") as TextAsset;
		story.text = src.text;
		currentPg = 124;


	}

	public void sxgxb13f(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxbat/Fire Escape/pxtxs-Day13-F") as TextAsset;
		story.text = src.text;
		currentPg = 125;


	}



	//End
	public void sxgxbEnd8s(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxbat/Day8-End/pxtxs-Day8-S-End") as TextAsset;
		story.text = src.text;
		currentPg = 126;


	}

	public void sxgxbEnd11s(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxbat/Day11-End/pxtxs-Day11-S-End") as TextAsset;
		story.text = src.text;
		currentPg = 127;


	}

	public void sxgxbEnd11f(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxbat/Day11-End/pxtxs-Day11-F-End") as TextAsset;
		story.text = src.text;
		currentPg = 128;


	}

	public void sxgxbEnd13(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxbat/pxtxs-Day13-End") as TextAsset;
		story.text = src.text;
		currentPg = 129;


	}

	//Girl-Gun-Bat
	//Main
	public void gxgxbMain1(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxbat/pxtxs-day6") as TextAsset;
		story.text = src.text;
		currentPg = 212;

	}



	//Elevator
	public void gxgxb7e(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxbat/Elevator/pxtxs-Day7-E") as TextAsset;
		story.text = src.text;
		currentPg = 213;

	}

	public void gxgxb8e(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxbat/Elevator/pxtxs-Day8(g)-E") as TextAsset;
		story.text = src.text;
		currentPg = 214;

	}

	public void gxgxb9e(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxbat/Elevator/pxtxs-Day9-E") as TextAsset;
		story.text = src.text;
		currentPg = 215;

	}


	//Stairs
	public void gxgxb7s(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxbat/Stairs/pxtxs-Day7") as TextAsset;
		story.text = src.text;
		currentPg = 216;

	}

	public void gxgxb8s(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxbat/Stairs/pxtxs-Day8-Floor1") as TextAsset;
		story.text = src.text;
		currentPg = 217;


	}

	public void gxgxb10s(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxbat/Stairs/pxtxs-Day10-S") as TextAsset;
		story.text = src.text;
		currentPg = 218;


	}

	public void gxgxb11s(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxbat/Stairs/pxtxs-Day11(g)-S") as TextAsset;
		story.text = src.text;
		currentPg = 219;


	}

	public void gxgxb12s(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxbat/Stairs/pxtxs-Day12-S") as TextAsset;
		story.text = src.text;
		currentPg = 220;


	}

	public void gxgxb13s(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxbat/Stairs/pxtxs-Day13-S") as TextAsset;
		story.text = src.text;
		currentPg = 221;


	}


	//Fire Escape
	public void gxgxb10f(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxbat/Fire Escape/pxtxs-Day10-F") as TextAsset;
		story.text = src.text;
		currentPg = 222;


	}

	public void gxgxb11f(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxbat/Fire Escape/pxtxs-Day11-F") as TextAsset;
		story.text = src.text;
		currentPg = 223;


	}

	public void gxgxb12f(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxbat/Fire Escape/pxtxs-Day12-F") as TextAsset;
		story.text = src.text;
		currentPg = 224;


	}

	public void gxgxb13f(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxbat/Fire Escape/pxtxs-Day13-F") as TextAsset;
		story.text = src.text;
		currentPg = 225;

	}



	//End
	public void gxgxbEnd8s(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxbat/Day8-End/pxtxs-Day8-S-End") as TextAsset;
		story.text = src.text;
		currentPg = 226;


	}

	public void gxgxbEnd11s(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxbat/Day11-End/pxtxs-Day11-S-End") as TextAsset;
		story.text = src.text;
		currentPg = 227;


	}

	public void gxgxbEnd11f(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxbat/Day11-End/pxtxs-Day11-F-End") as TextAsset;
		story.text = src.text;
		currentPg = 228;


	}

	public void gxgxbEnd13(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxbat/pxtxs-Day13-End") as TextAsset;
		story.text = src.text;
		currentPg = 229;


	}

	//Solo-Gun-Wounded
	//Elevator
	public void sxgxw8be(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxwound/Elevator/pxtxs-Day8(b)-E") as TextAsset;
		story.text = src.text;
		currentPg = 312;
	}

	public void sxgxw9e(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxwound/Elevator/pxtxs-Day9-E") as TextAsset;
		story.text = src.text;
		currentPg = 313;
	}


	//Stairs
	public void sxgxw10s(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxwound/Stairs/pxtxs-Day10-S") as TextAsset;
		story.text = src.text;
		currentPg = 314;

	}

	public void sxgxw11s(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxwound/Stairs/pxtxs-Day11-S") as TextAsset;
		story.text = src.text;
		currentPg = 315;

	}

	public void sxgxw12s(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxwound/Stairs/pxtxs-Day12-S") as TextAsset;
		story.text = src.text;
		currentPg = 316;

	}

	public void sxgxw13s(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxwound/Stairs/pxtxs-Day13-S") as TextAsset;
		story.text = src.text;
		currentPg = 317;

	}


	//Fire Escape
	public void sxgxw10f(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxwound/Fire Escape/pxtxs-Day10-F") as TextAsset;
		story.text = src.text;
		currentPg = 318;

	}

	public void sxgxw11f(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxwound/Fire Escape/pxtxs-Day11-F") as TextAsset;
		story.text = src.text;
		currentPg = 319;
	}

	public void sxgxw12f(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxwound/Fire Escape/pxtxs-Day12-F") as TextAsset;
		story.text = src.text;
		currentPg = 320;
	}

	public void sxgxw13f(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxwound/Fire Escape/pxtxs-Day13-F") as TextAsset;
		story.text = src.text;
		currentPg = 321;
	}



	//End
	public void sxgxwEnd8s(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxwound/Day8-End/pxtxs-Day8-S-End") as TextAsset;
		story.text = src.text;
		currentPg = 322;

	}

	public void sxgxwEnd11s(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxwound/Day11-End/pxtxs-Day11-S-End") as TextAsset;
		story.text = src.text;
		currentPg = 323;

	}

	public void sxgxwEnd11f(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxwound/Day11-End/pxtxs-Day11-F-End") as TextAsset;
		story.text = src.text;
		currentPg = 324;

	}

	public void sxgxwEnd13f(){
		TextAsset src = (TextAsset)Resources.Load("solo-gunxwound/pxtxs-Day13-F-End") as TextAsset;
		story.text = src.text;
		currentPg = 325;

	}

	//Girl-Gun-Wounded
	//Elevator
	public void gxgxw8be(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxwound/Elevator/pxtxs-Day8(b)-E") as TextAsset;
		story.text = src.text;
		currentPg = 412;
	}

	public void gxgxw9e(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxwound/Elevator/pxtxs-Day9-E") as TextAsset;
		story.text = src.text;
		currentPg = 413;
	}

	//Stairs
	public void gxgxw10s(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxwound/Stairs/pxtxs-Day10-S") as TextAsset;
		story.text = src.text;
		currentPg = 414;

	}

	public void gxgxw11s(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxwound/Stairs/pxtxs-Day11-S") as TextAsset;
		story.text = src.text;
		currentPg = 415;

	}

	public void gxgxw12s(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxwound/Stairs/pxtxs-Day12-S") as TextAsset;
		story.text = src.text;
		currentPg = 416;

	}

	public void gxgxw13s(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxwound/Stairs/pxtxs-Day13-S") as TextAsset;
		story.text = src.text;
		currentPg = 417;

	}

	//Fire Escape
	public void gxgxw10f(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxwound/Fire Escape/pxtxs-Day10-F") as TextAsset;
		story.text = src.text;
		currentPg = 418;

	}

	public void gxgxw11f(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxwound/Fire Escape/pxtxs-Day11-F") as TextAsset;
		story.text = src.text;
		currentPg = 419;
	}

	public void gxgxw12f(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxwound/Fire Escape/pxtxs-Day12-F") as TextAsset;
		story.text = src.text;
		currentPg = 420;
	}

	public void gxgxw13f(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxwound/Fire Escape/pxtxs-Day13-F") as TextAsset;
		story.text = src.text;
		currentPg = 421;
	}



	//End
	public void gxgxwEnd8s(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxwound/Day8-End/pxtxs-Day8-S-End") as TextAsset;
		story.text = src.text;
		currentPg = 422;

	}

	public void gxgxwEnd11s(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxwound/Day11-End/pxtxs-Day11-S-End") as TextAsset;
		story.text = src.text;
		currentPg = 423;

	}

	public void gxgxwEnd11f(){
		TextAsset src = (TextAsset)Resources.Load("girl-gunxwound/Day11-End/pxtxs-Day11-F-End") as TextAsset;
		story.text = src.text;
		currentPg = 424;

	}

	public void gxgxwEnd13f(){
		TextAsset src = (TextAsset)Resources.Load ("girl-gunxwound/pxtxs-Day13-F-End") as TextAsset;
		story.text = src.text;
		currentPg = 425;
	}
	}