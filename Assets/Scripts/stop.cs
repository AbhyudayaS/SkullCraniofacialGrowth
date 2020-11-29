using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class stop : MonoBehaviour {

	public Animation anim;


	public void OnMouseDown(){

		//play.anim.Stop("Take 001");
		anim ["Take 001"].speed = 0;

			
	}
}