using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;




public class AimCamera : MonoBehaviour {
	//public Camera me;
	//public Transform target;
	Vector3 f0Dir= Vector3.zero;
	public static Vector3 upVal= Vector3.zero;
	Vector3 orthosize = Vector3.zero;
	float zoomDistance= 20;
	float mouseScroll1 = 8;
	float theta= 0.0F;
	float fai= 0F;
	float loc_x= 0.0F;
	float loc_y= 0.0F;
	float panWeight= 0.3F;
	float mouseScroll;
	Vector3 Rot;
	void Start(){

	
		Rot.y = 135;

	}
	void LateUpdate()
	{
		bool a = true;
		if (a == true) {
			mouseScroll = Input.GetAxis ("Mouse ScrollWheel") * 5f;
			mouseScroll1 = mouseScroll1- mouseScroll;
			mouseScroll1 = Mathf.Clamp(mouseScroll1,3,10);
			destroy.me.orthographicSize= mouseScroll1/2;

		}
	}
	public void Update() {
	
		if (!EventSystem.current.IsPointerOverGameObject ()) {

			if (Input.GetMouseButton (0) ) {
				f0Dir = new Vector3 (Input.GetAxis ("Mouse X") * 5.0F, -Input.GetAxis ("Mouse Y") * 5.0F, 0);
				
			} else {
				f0Dir = Vector3.zero;
				loc_x = 0.0F;
				loc_y = 0.0F;
			}
			if (Input.GetMouseButton (2)) {
				loc_x = -Input.GetAxis ("Mouse X") * panWeight;
				loc_y = -Input.GetAxis ("Mouse Y") * panWeight;
		} 
			theta += Mathf.Deg2Rad * f0Dir.x * 1;
			fai += -Mathf.Deg2Rad * f0Dir.y * 1;
			fai= Mathf.Clamp(fai,-1,1);
			//orthosize.z = zoomDistance * Mathf.Cos (theta) * Mathf.Sin (fai + Mathf.PI/2 );
			upVal.z = zoomDistance * Mathf.Cos (theta) * Mathf.Sin (fai + Mathf.PI /2);
			upVal.x = zoomDistance * Mathf.Sin (theta) * Mathf.Sin (fai + Mathf.PI /2);
			upVal.y = zoomDistance * Mathf.Cos (fai + Mathf.PI / 2);
			transform.position = upVal;
			destroy.target.transform.Translate (Camera.main.transform.up * loc_y + Camera.main.transform.right * (loc_x), Space.World);
			transform.position += destroy.target.position;
			Camera.main.transform.LookAt (destroy.target.position);

		}	
	}
}