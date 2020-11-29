using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class showAll : MonoBehaviour {
	GameObject[] hs;
	GameObject[] hid;
	public GameObject me;
	public static bool a;
	public Text[] txt;
	public Button[] pk;

	void Awake () {

		hs = GameObject.FindGameObjectsWithTag("Finish");

	}
	void Update(){

		if (a== false) {
			me.SetActive (false);
		} else {
			me.SetActive (true);
		}
	}
	public void OnMouseDown () {
		foreach (Button go in pk) {
			go.image.sprite = MaxillaBon.HideGloble[0];
		}
		foreach (Text go in txt) {
			go.color = Color.black;
		}
		a = false;
		foreach (GameObject go in hs) {
		go.SetActive (true);
		go.tag = "Finish";
		go.GetComponent<Renderer> ().material.color = overOut.startcolor;
		}
	}
}

