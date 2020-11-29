using UnityEngine;
using System.Collections;

public class XRay : MonoBehaviour {

	public GameObject[] pk = new GameObject[15];
	public Material[] mk = new Material[2];
	public Material tk;
	public ReflectionProbe main;
	public Material white;
	public static bool c;
	public GameObject panle;
	bool b;

	int i;
	int t;


	void Update(){
		b = newTextureMode.d;
		t = CrossOnOff.count;

	}

	// Use this for initialization
	public void XrayModeOn(){
		if (t == 0) {
			c = true;
			main.enabled = true;
			foreach (GameObject go in pk) {
				Destroy (go.GetComponent<overOut> ());
				go.GetComponent<MeshCollider> ().enabled = false;
			}
			pk [0].GetComponent<Renderer> ().material = tk;
			pk [1].GetComponent<Renderer> ().material = tk;
			pk [2].GetComponent<Renderer> ().material = tk;
			pk [3].GetComponent<Renderer> ().material = tk;
			pk [4].GetComponent<Renderer> ().material = tk;
			pk [5].GetComponent<Renderer> ().material = tk;
			pk [6].GetComponent<Renderer> ().material = tk;
			pk [7].GetComponent<Renderer> ().material = tk;
			pk [8].GetComponent<Renderer> ().material = tk;
			pk [9].GetComponent<Renderer> ().material = tk;
			pk [10].GetComponent<Renderer> ().material = tk;
			pk [11].GetComponent<Renderer> ().material = tk;
			pk [12].GetComponent<Renderer> ().material = tk;
			pk [13].GetComponent<Renderer> ().material = tk;
			pk [14].GetComponent<Renderer> ().material = tk;

		} else {
			panle.SetActive(true);
		}
	}
	public void XrayModeOff(){
		c = false;
		foreach (GameObject go in pk) {
			go.AddComponent<overOut>();
			go.GetComponent<Renderer> ().material.color = overOut.startcolor;
			go.GetComponent<MeshCollider>().enabled = true;
		}

		if (b == false) {
			pk [0].GetComponent<Renderer> ().material = mk [0];
			pk [1].GetComponent<Renderer> ().material = mk [0];
			pk [2].GetComponent<Renderer> ().material = mk [0];
			pk [3].GetComponent<Renderer> ().material = mk [1];
			pk [4].GetComponent<Renderer> ().material = mk [1];
			pk [5].GetComponent<Renderer> ().material = mk [1];
			pk [6].GetComponent<Renderer> ().material = mk [1];
			pk [7].GetComponent<Renderer> ().material = mk [1];
			pk [8].GetComponent<Renderer> ().material = mk [1];
			pk [9].GetComponent<Renderer> ().material = mk [1];
			pk [10].GetComponent<Renderer> ().material = mk [1];
			pk [11].GetComponent<Renderer> ().material = mk [1];
			pk [12].GetComponent<Renderer> ().material = mk [2];
			pk [13].GetComponent<Renderer> ().material = mk [2];
			pk [14].GetComponent<Renderer> ().material = mk [2];
			main.enabled = true;
		} else {
			foreach(GameObject go in pk){
				go.GetComponent<Renderer>().material = white;
				main.enabled = false;
			}
		}

	}
}
