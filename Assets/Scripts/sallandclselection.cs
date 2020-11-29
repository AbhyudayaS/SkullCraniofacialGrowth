using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class sallandclselection : MonoBehaviour {
	GameObject[] finish;
	public Button me;
	public Button[] allbtn;
	public Text[] alltxt;
	bool a;
	// Use this for initialization
	void Start () {
		finish = GameObject.FindGameObjectsWithTag ("Finish");
	}
	public void sectAll(){
		foreach (GameObject go in finish) {
			go.GetComponent<Renderer>().material.color = overOut.rolOvrColor;
		}
	}
	public void clearSelection(){

		foreach (GameObject go in finish) {
			go.GetComponent<Renderer>().material.color = overOut.startcolor;
		}
		foreach (Button go in allbtn) {
			go.image.sprite = MaxillaBon.HideGloble[0];
		}
		foreach (Text go in alltxt) {
			go.color = Mandible.btn_txt;
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
