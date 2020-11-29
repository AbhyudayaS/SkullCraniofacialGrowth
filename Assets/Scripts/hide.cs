using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class hide : MonoBehaviour {
	GameObject[] hs;
	GameObject[] pr;




	void Update () {

		hs = GameObject.FindGameObjectsWithTag("Player");

	}


	public void OnMoseDown(){
		showAll.a = true;
		foreach (GameObject go in hs) {
		go.tag = "Hide";
		go.GetComponent<Renderer> ().material.color = Color.white;
		Destroy (go.GetComponent<overOut> ());
		go.AddComponent<overOut> ();
		go.SetActive (false);
		}
	}
}