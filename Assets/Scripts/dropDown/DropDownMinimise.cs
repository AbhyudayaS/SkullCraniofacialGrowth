using UnityEngine;
using System.Collections;

public class DropDownMinimise : MonoBehaviour {

	public GameObject plt;
	public GameObject pltCross;
	public GameObject Up;
	public GameObject Down;
	bool a;

	void Update(){
	
		a = plt.activeSelf;
	}

	public void DropDownMinimis(){

		if (a == true) {
			plt.SetActive (false);
			pltCross.SetActive (false);
			Up.SetActive (false);
			Down.SetActive (true);
			a = false;
		} else {
			plt.SetActive(true);
			pltCross.SetActive (true);
			Up.SetActive (true);
			Down.SetActive (false);
			a= true;
		}
	}
}
