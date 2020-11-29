using UnityEngine;
using System.Collections;

public class LineHide : MonoBehaviour {
	public static bool p;
	public DrawLines[] drawline;


	// Use this for initializatio
	void Start () {
		//p = true;
		drawline = GetComponents<DrawLines>();

		foreach (DrawLines go in drawline) {
			go.enabled=false;
		}
	}

	void Update()
	{
	}
	//Update is called once per frame
	public void lineOn(){
		foreach (DrawLines go in drawline) {
			go.enabled = true;
		}
	}
	public void lineOff(){
		foreach (DrawLines go in drawline) {
			go.enabled=false;
		}
	}
}