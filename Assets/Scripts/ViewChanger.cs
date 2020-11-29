using UnityEngine;
using System.Collections;

public class ViewChanger : MonoBehaviour {
	public GameObject orth;
	public Camera ortho;
	public GameObject prnt;
	public AimCameraOrtho aimcamarth;
	public Camera main;
	Vector3[] rot = new Vector3[6];
	int i;
	bool a;


	void Start(){
	
		rot[0].y = 90;
		rot[1].y = 270;
		rot[2].y = 180;
		rot[3].y = 0;
		rot[4].x = 90;
		rot[4].y = 0;
		rot[5].x = -90;
		rot[5].y = 0;
	
	}
	public void front(){	main.tag = "Untagged";
		main.GetComponent<AimCamera> ().enabled = false;
		ortho.tag = "MainCamera";
		main.enabled = false;
		ortho.enabled = true;
		aimcamarth.enabled = true;
		prnt.transform.localRotation =  Quaternion.Euler(rot[0]);
	}
	public void back(){
		main.tag = "Untagged";
		main.GetComponent<AimCamera> ().enabled = false;
		ortho.tag = "MainCamera";
		main.enabled = false;
		ortho.enabled = true;
		aimcamarth.enabled = true;
		prnt.transform.localRotation =  Quaternion.Euler(rot[1]);
	}
	public void left(){
		main.tag = "Untagged";
		main.GetComponent<AimCamera> ().enabled = false;
		ortho.tag = "MainCamera";
		main.enabled = false;
		ortho.enabled = true;
		aimcamarth.enabled = true;
		prnt.transform.localRotation =  Quaternion.Euler(rot[2]);
	}
	public void right(){
		main.tag = "Untagged";
		main.GetComponent<AimCamera> ().enabled = false;
		ortho.tag = "MainCamera";
		main.enabled = false;
		ortho.enabled = true;
		aimcamarth.enabled = true;
		prnt.transform.localRotation =  Quaternion.Euler(rot[3]);
	}
	public void top(){
		main.tag = "Untagged";
		main.GetComponent<AimCamera> ().enabled = false;
		ortho.tag = "MainCamera";
		main.enabled = false;
		ortho.enabled = true;
		aimcamarth.enabled = true;
		prnt.transform.localRotation =  Quaternion.Euler(rot[4]);
	}
	public void bottom(){
		main.tag = "Untagged";
		main.GetComponent<AimCamera> ().enabled = false;
		ortho.tag = "MainCamera";
		main.enabled = false;
		ortho.enabled = true;
		aimcamarth.enabled = true;
		prnt.transform.localRotation =  Quaternion.Euler(rot[5]);
	}
	public void view(){

		main.enabled = true;
		ortho.enabled = false;
	}
	public void iso(){
		main.tag = "MainCamera";
		main.GetComponent<AimCamera> ().enabled = true;
		aimcamarth.enabled = false;
		ortho.tag = "Untagged";
		ortho.enabled = false;
		main.enabled = true;

	}
}
