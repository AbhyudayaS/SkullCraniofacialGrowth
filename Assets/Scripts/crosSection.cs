using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class crosSection : MonoBehaviour {
	public GameObject[] main;
	GameObject[] leftcov;
	public Slider p;
	public static Vector4 prede;
	bool x;
	bool y;
	bool z;
	bool a;
	int flip;
	public static float sldrvalue;
	Color reed;
	public static float slidrMinValue;
	public static float slidrMaxValue;



	void Start(){
		reed = new Color (0.79f, 0.08f,0.08f,1);
		slidrMaxValue = 0.55f; 
		slidrMinValue = -0.3f;
		prede [0] = 1;
		prede [1] = 0;
		prede [2] = 0;
		//main = this.GetComponent<Renderer> ();
	}
	void Update(){
		p.maxValue = slidrMaxValue;
		p.minValue = slidrMinValue;
		sldrvalue = p.value;  
		foreach (GameObject go in main) {
			go.GetComponent<Renderer>().material.SetVector ("_section", prede);
		}
	}

	public void xaxis(){
		x = false;
		y = true;
		z = true;
		slidrMaxValue = 0.55f; 
		slidrMinValue = -0.3f;
		prede [0] = 1;
		prede [1] = 0;
		prede [2] = 0;
	}

	public void yaxis(){
		x = true;
		y = false;
		z = true;
		slidrMaxValue = 0.62f; 
		slidrMinValue = -0.6f;
		prede [0] = 0;
		prede [1] = 1;
		prede [2] = 0;
	}

	public void zaxis(){
		x = true;
		y = true;
		z = false;
		slidrMaxValue = 0.36f; 
		slidrMinValue = -0.45f;
		prede [0] = 0;
		prede [1] = 0;
		prede [2] = 1;
	}

	public void axizFlip(){
	
		if (a == false) {
			if (x == false) {
				prede [0] = -1;
			}
			if (y == false) {
				prede [1] = -1;
			}
			if (z == false) {
				prede [2] = -1;
			}
			a = true;
		} else {
			if (x == false) {
				prede [0] = 1;
			}
			if (y == false) {
				prede [1] = 1;
			}
			if (z == false) {
				prede [2] = 1;
			}
			a= false;
		}
	}
}