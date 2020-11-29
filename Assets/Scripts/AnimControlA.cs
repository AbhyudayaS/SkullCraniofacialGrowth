using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AnimControlA : MonoBehaviour {
	public Animation anim;
	public  Slider slider;


	//public AimCamera cameraScript;
	
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
	
	
			slider.value = anim ["Take 001"].time; 

	}
}

	
