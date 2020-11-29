using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class newTextureMode : MonoBehaviour {
	public GameObject[] allgmobjt = new GameObject[54];
	public Material[] allmat = new Material[54];
	//public GameObject[] forXRay = new GameObject[0];
	//public Material[] xraymat = new Material[15];
	public Material transp;
	public Material white;
	public  Light mainLight;
	public  Light[] fillLight;
	public static bool d;
	bool a;
	int i;

	void Start(){
	
		for (i = 0; i<54; i++) {
			allmat [i] = allgmobjt [i].GetComponent<Renderer> ().material;
		}
		/*for (i = 0; i<15; i++) {
			xraymat [i] = forXRay [i].GetComponent<Renderer> ().material;
		}*/

	}

	public void texture(){
		d = false;
	
		if (a == true) {
			foreach(GameObject go in allgmobjt){
				go.AddComponent<overOut>();
				go.GetComponent<MeshCollider> ().enabled = true;
				XRayNew.xstatus = false;
			}
		}
	
		mainLight.intensity = 1f;
		for (i = 0; i<54; i++) {
			allgmobjt [i].GetComponent<Renderer> ().material = allmat [i];
		}
		/*for (i = 0; i<15; i++) {
			forXRay [i].GetComponent<Renderer> ().material = xraymat [i];
		}
		if (a == true) {
			foreach (GameObject go in forXRay) {

				go.GetComponent<Renderer> ().material = transp;
			}
		} else {
			for (i = 0; i<15; i++) {
				forXRay [i].GetComponent<Renderer> ().material = xraymat [i];
			}
		}*/
	}


	public void whitee(){
		d = true;
		if (a == true) {
			foreach(GameObject go in allgmobjt){
				go.AddComponent<overOut>();
				go.GetComponent<MeshCollider> ().enabled = true;
				XRayNew.xstatus = false;
			}
		}

		mainLight.intensity = 0.5f;
		foreach (GameObject go in allgmobjt) {
			
			go.GetComponent<Renderer> ().material = white;
		}
		/*if (a == true) {
			foreach (GameObject go in forXRay) {
				prob.enabled = true;	
				go.GetComponent<Renderer> ().material = transp;
			}
		} else {
			foreach (GameObject go in forXRay) {
				prob.enabled = false;
				go.GetComponent<Renderer> ().material = white;
			}
		}*/
	}
	void Update(){
		a = XRayNew.xstatus;
	}

}