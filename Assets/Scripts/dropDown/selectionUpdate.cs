using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class selectionUpdate : MonoBehaviour {
	public GameObject[] fb = new GameObject[1]; 
	public GameObject[] pb = new GameObject[2]; 
	public GameObject[] ob = new GameObject[1]; 
	public GameObject[] tb = new GameObject[2]; 
	public GameObject[] m = new GameObject[1]; 
	public GameObject[] t = new GameObject[32]; 
	public GameObject[] mb = new GameObject[2]; 
	public GameObject[] s = new GameObject[1]; 
	public GameObject[] z = new GameObject[2]; 
	public GameObject[] o = new GameObject[10]; 
	public Button[] parnt = new Button[10];
	public Text[] panttxt = new Text[10];
	Color objColor;
	Color SobjColor;
	bool a;
	GameObject clicked;
	GameObject clicked1;
	string nm;
	public GameObject[] Dot = new GameObject[10];
	// Use this for initialization

	void Start(){
		clicked = t [0];
		clicked1 = o [0];

	}

	// Update is called once per frame
	void Update () {
	
		if (fb [0].GetComponent<Renderer> ().material.color == overOut.msDownColor) {
			Dot[0].SetActive (true);
		}else{
			Dot[0].SetActive (false);
			parnt[0].image.sprite = MaxillaBon.HideGloble[0];
			panttxt[0].color = Mandible.btn_txt;
		}
		/////
		if (pb [0].GetComponent<Renderer> ().material.color == overOut.msDownColor) {
			Dot [1].SetActive (true);
		} else if (pb [1].GetComponent<Renderer> ().material.color == overOut.msDownColor) {
			Dot [1].SetActive (true);
		}
		else{
			Dot[1].SetActive (false);
			parnt[1].image.sprite = MaxillaBon.HideGloble[0];
			panttxt[1].color = Mandible.btn_txt;
		}
		/////
		if (ob [0].GetComponent<Renderer> ().material.color == overOut.msDownColor) {
			Dot[2].SetActive (true);
		}else{
			Dot[2].SetActive (false);
			parnt[2].image.sprite = MaxillaBon.HideGloble[0];
			panttxt[2].color = Mandible.btn_txt;
		}
		////
		if (tb [0].GetComponent<Renderer> ().material.color == overOut.msDownColor) {
			Dot [3].SetActive (true);
		} else if (tb [1].GetComponent<Renderer> ().material.color == overOut.msDownColor) {
			Dot [3].SetActive (true);
		}
		else{
			Dot[3].SetActive (false);
			parnt[3].image.sprite = MaxillaBon.HideGloble[0];
			panttxt[3].color = Mandible.btn_txt;
		}
		////
		
		if (m [0].GetComponent<Renderer> ().material.color == overOut.msDownColor) {
			Dot[4].SetActive (true);
		}else{
			Dot[4].SetActive (false);
			parnt[4].image.sprite = MaxillaBon.HideGloble[0];
			panttxt[4].color = Mandible.btn_txt;
		}
		///
		if (mb [0].GetComponent<Renderer> ().material.color == overOut.msDownColor) {
			Dot [6].SetActive (true);
		} else if (mb[1].GetComponent<Renderer> ().material.color == overOut.msDownColor) {
			Dot [6].SetActive (true);
		}
		else{
			Dot[6].SetActive (false);
			parnt[6].image.sprite = MaxillaBon.HideGloble[0];
			panttxt[6].color = Mandible.btn_txt;
		}
		////
		if (s[0].GetComponent<Renderer> ().material.color == overOut.msDownColor) {
			Dot[7].SetActive (true);
		}else{
			Dot[7].SetActive (false);
			parnt[7].image.sprite = MaxillaBon.HideGloble[0];
			panttxt[7].color = Mandible.btn_txt;
		}
		///
		if (z [0].GetComponent<Renderer> ().material.color == overOut.msDownColor) {
			Dot [8].SetActive (true);
		} else if (z[1].GetComponent<Renderer> ().material.color == overOut.msDownColor) {
			Dot [8].SetActive (true);
		}
		else{
			Dot[8].SetActive (false);
			parnt[8].image.sprite = MaxillaBon.HideGloble[0];
			panttxt[8].color = Mandible.btn_txt;
		}
		///
		for (int i =0; i<32; i++) {
			SobjColor = t [i].GetComponent<Renderer> ().material.color;
			if (SobjColor == overOut.msDownColor) {
				clicked = t[i];
			}

		}

		if (clicked.GetComponent<Renderer>().material.color == overOut.msDownColor) {
			Dot [5].SetActive (true);
		} else {
			Dot[5].SetActive(false);
		}
	///

		for (int i =0; i<10; i++) {
			SobjColor =o[i].GetComponent<Renderer> ().material.color;
			if (SobjColor == overOut.msDownColor) {
				clicked1 = o[i];
			}
			
		}
		
		if (clicked1.GetComponent<Renderer>().material.color == overOut.msDownColor) {
			Dot [9].SetActive (true);
		} else {
			Dot[9].SetActive(false);
		}
	}

}
