using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AnimControl : MonoBehaviour {
	public Animation anim;
	public Slider slider;
	//public AimCamera cameraScript;
	
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//cameraScript.enabled = false;
		anim["Take 001"].time = slider.value;
	}
}