using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class play : MonoBehaviour {
	public Animation anim;
	public Slider sldr;
	public AnimControl manual;
	public AnimControlA auto;
	public GameObject playBtn;
	public GameObject stopBtn;
	AnimationState state1;
	AnimationState state2;
	bool a;
	void Start(){

		state1 = anim ["Take 001"];
		state2 = anim ["ExplodeOut"];

		state1.layer = 1;
		state2.layer = 2;

		state1.enabled = true;
		state1.weight = 0.5f;

		state2.enabled = true;
		state2.weight = 0.5f;

		anim ["Take 001"].speed = 0;
		anim ["ExplodeOut"].speed = 0;

	}
	void Update(){


			anim ["ExplodeOut"].time = sldr.value;
		if (anim ["Take 001"].time > 4) {
			anim ["Take 001"].speed = 0;
			manual.enabled = true;
			auto.enabled = false;
			playBtn.SetActive(true);
			stopBtn.SetActive(false);
			a= true;
		}
	}

	public void OnMouseDown()
	{
		if (anim ["Take 001"].time < 3.9) {

			anim.Play ("Take 001");
			anim ["Take 001"].speed = 1;

		} else {
			anim ["Take 001"].time = 0;
			anim.Play ("Take 001");
			anim ["Take 001"].speed = 1;
		}
	}

	public void speedPlus(){

		if(anim ["Take 001"].speed <=4){
			Debug.Log("plus" + anim ["Take 001"].speed);
			anim ["Take 001"].speed += 1;
		}
	}

	public void speedMinus(){

		if(anim ["Take 001"].speed >=2){
			Debug.Log("plus" + anim ["Take 001"].speed);
			anim ["Take 001"].speed -= 1;
		}
	}

}
