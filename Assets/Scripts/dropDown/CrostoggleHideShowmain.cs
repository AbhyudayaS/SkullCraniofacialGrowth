using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CrostoggleHideShowmain : MonoBehaviour {
	public Toggle[] alltog;
	public Toggle me;
	bool a;
	bool mevalue;
	int i;

	void Update(){


	}

	public void OnMOuseDown(){

		if (a == false) {
				foreach(Toggle go in alltog){
					go.isOn = true;
				}
				
				a= true;
			} else {
				foreach(Toggle go in alltog){
					go.isOn = false;
				}
				
				a=false;
			}
	}
}
