using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DefMinimise : MonoBehaviour {

	public GameObject plt;
	public GameObject Up;
	public GameObject Down;
	public GameObject drpdwn;
	bool a;
	Vector3 position1;
	Vector3 position2;
	void Start(){
		position1.y = 81.5f;
		position1.x = -366.0f;
		position2.y = 180;
		position2.x = -366.0f;
	}

	void Update(){
	
		a = plt.activeSelf;
	}

	public void DropDownMinimis(){

		if (a == true) {
			drpdwn.transform.localPosition = position2;
			plt.SetActive (false);
			Up.SetActive (false);
			Down.SetActive (true);
			a = false;
		} else {
			drpdwn.transform.localPosition = position1;
			plt.SetActive(true);
			Up.SetActive (true);
			Down.SetActive (false);
			a= true;
		}
	}
}
