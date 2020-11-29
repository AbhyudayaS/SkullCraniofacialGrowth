using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {

	 AimCamera aimcam;
	public Camera main;
	public static Camera me;
	public static Transform target;
	public GameObject pk;
	public static Transform newtar;
	Vector3 posi = new Vector3(0,-8.742278e-07f,20);
	Vector3 startrot = new Vector3 (-2.504478e-06f, 180, 0);

	bool a;
	//private MonoBehaviour mymono;
	// Use this for initialization

	void Start () { 
		me = main;
		target = pk.transform;
	}

	void Update()
	{

		if(Input.GetKey(KeyCode.F)){

			target.position = newtar.position;
	}
		aimcam = main.gameObject.GetComponent<AimCamera> ();
	}
	
	// Update is called once per frame
	public void OnMouseDown () {
		Destroy (aimcam);
		pk.transform.position = new Vector3(0.0f,0.0f,0.0f);
		main.transform.localPosition = posi;
		main.transform.eulerAngles = startrot;
		target = pk.transform;
		main.gameObject.AddComponent<AimCamera>();
	}

}
