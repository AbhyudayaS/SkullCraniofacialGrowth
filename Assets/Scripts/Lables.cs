using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Lables : MonoBehaviour {

	public GameObject[] pr;
	bool p;
	public static bool lbsts;

	void Start () {
		p = true;
			foreach (GameObject go in pr) {
			go.SetActive (false);
		}
	}


	public void lableOn(){
		lbsts = true;
		foreach (GameObject go in pr) {
			go.SetActive (true);
			p = false;
		}
	}

	public void lableOff(){
		lbsts = false;
		foreach (GameObject go in pr) {
			go.SetActive (false);
			p=true;;
		
		}
	}
}