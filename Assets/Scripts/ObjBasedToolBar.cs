using UnityEngine;
using System.Collections;

public class ObjBasedToolBar : MonoBehaviour {

	GameObject[] pk;
	public GameObject Hide;
	public GameObject Isola;

	void Update(){

		pk = GameObject.FindGameObjectsWithTag ("Player");

		if (pk.Length > 0) {
			Hide.SetActive (true);
			Isola.SetActive (true);
		} else {
			Hide.SetActive (false);
			Isola.SetActive (false);
		}
	}
}
