using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Isolate: MonoBehaviour {
	//public Button isolate;
	//Color btnStartcolor;
	//public Text text;
	private GameObject[] pr;
	private GameObject[] fk;
	public static bool p;
	private GameObject[] po;
	public GameObject me;
	//public Button ply;
	public Text[] txt;
	public static bool iso;
	public Button[] pk;
	bool a;


	// Use this for initialization
	void Start () 
	{
		//p = true;

		fk = GameObject.FindGameObjectsWithTag("Finish");
					
	}

	
	// Update is called once per frame
	void Update () 
	{
		if (a == true) {
			me.SetActive (true);
		} else {
			me.SetActive (false);
		}
		//p = iso;
		po = GameObject.FindGameObjectsWithTag("Finish");
		pr = GameObject.FindGameObjectsWithTag("Player");
		}
	public void Isolatee()
	{	
		a = true;
		fk = po;
				//ply.image.color =Lables.btnStartcolor;
			foreach (GameObject go in po) {
				go.SetActive (false);
				go.GetComponent<Renderer> ().material.color = Color.white;

			}
			foreach (GameObject go in pr) {
				go.SetActive (true);
				//go.tag="Finish";
				go.GetComponent<Renderer> ().material.color = overOut.startcolor;
				Destroy (go.GetComponent<overOut> ());
				go.AddComponent<overOut> ();
			}
		foreach (Button go in pk) {
			go.image.sprite = MaxillaBon.HideGloble[0];
		}
		foreach (Text go in txt) {
			go.color = Color.black;
		}
	}

	public void UnIsolatee(){
		a = false;
		foreach (GameObject go in fk) {
			go.SetActive (true);
			go.GetComponent<Renderer> ().material.color = overOut.startcolor;
			Destroy (go.GetComponent<overOut> ());
			go.AddComponent<overOut> ();
		}
	}
}