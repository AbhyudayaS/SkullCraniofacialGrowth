using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class XRayNew : MonoBehaviour {
	public Button xray;
	public GameObject[] pk;
	public Material tk;
	bool b;
	public static bool xstatus;


	void Update(){
		b = CrossOnOff.a;
		if (b == false) {
			xray.enabled = true;
		} else {
			xray.enabled = false;
		}
	}
	// Use this for initialization
	public  void XrayModeOn(){
		xstatus = true;
			foreach (GameObject go in pk) {
				Destroy (go.GetComponent<overOut> ());
				go.GetComponent<MeshCollider> ().enabled = false;
				go.GetComponent<Renderer> ().material = tk;
			}
		
		}
}
