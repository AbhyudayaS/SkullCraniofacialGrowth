using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Newplay : MonoBehaviour {
	public Animation anim;
	public Slider slider;



	void Start(){

		//anim.PlayQueued("Take 001",QueueMode.PlayNow ).speed = 0;
		//anim.PlayQueued("ExplodeOut",QueueMode.PlayNow ).speed = 0;

	}
	// Use this for initializatio

	void Update(){

		//anim.PlayQueued ("ExplodeOut", QueueMode.PlayNow).time = slider.value;			
	}

	public void OnMouseDown()
	{
		anim.Play("Take 001");


				 
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
