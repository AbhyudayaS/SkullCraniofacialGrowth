using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class xrayCrossLimits : MonoBehaviour {
	public Toggle[] crosTgl;
	bool a;

	void Update(){

		a = XRay.c;
		if (a == true) {
			foreach (Toggle go in crosTgl) {
				go.interactable = false;

			}
		} else {
			foreach (Toggle go in crosTgl) {
				go.interactable = true;
			}
		}
	}


}
