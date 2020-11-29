using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CrossOnOff : MonoBehaviour {
	public static int count;
	int b;
	public GameObject CrossPanel;
	public static bool a;
	// Use this for initialization


	// Update is called once per frame
	void Update () {

		b = count;

		if (b != 0) {
			a= true;
			CrossPanel.SetActive (true);

		} else {
			a= false;
			CrossPanel.SetActive(false);
		}
	}
}
