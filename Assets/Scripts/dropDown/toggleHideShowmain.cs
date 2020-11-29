using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class toggleHideShowmain : MonoBehaviour {
	public GameObject[] main;
	public Toggle[] alltog;
	public Toggle me;
	bool a;
	bool mevalue;
	int i;

	void Update(){


		mevalue = alltog [i].isOn;
		if (mevalue== true) {
			me.isOn = true;
		}
	
	}

	public void OnMOuseDown(){

		if (a == false) {
				foreach(Toggle go in alltog){
					go.isOn = false;
				}
				foreach(GameObject go in main){
					go.SetActive (false);
				}
				a= true;
			} else {
				foreach(Toggle go in alltog){
					go.isOn = true;
				}
				foreach(GameObject go in main){
					go.SetActive (true);
				}
				a=false;
			}
	}
}
