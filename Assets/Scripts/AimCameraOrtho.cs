using UnityEngine;
using System.Collections;



public class AimCameraOrtho : MonoBehaviour {
	public Camera me;
	public Transform target;
	public Transform target1;
	float loc_x= 0.0F;
	float loc_y= 0.0F;
	public float panWeight= 0.3F;
	float mouseScroll;
	float mouseScroll1 = 8;

	void Start(){

	
	
	}
	void LateUpdate()
	{
		bool a = true;
		if (a == true) {
			mouseScroll = Input.GetAxis ("Mouse ScrollWheel") * 5f;
			mouseScroll1 = mouseScroll1- mouseScroll;
			mouseScroll1 = Mathf.Clamp(mouseScroll1,3,10);
			me.orthographicSize= mouseScroll1/2;
			
		}
	}
	public void Update() {



			if (Input.GetMouseButton (2)) {
				loc_x = -Input.GetAxis ("Mouse X") * panWeight;
				loc_y = -Input.GetAxis ("Mouse Y") * panWeight;

			target.transform.Translate(Camera.main.transform.up * loc_y + Camera.main.transform.right * loc_x);
				}
			me.transform.position = target.position;

		}	
	}
