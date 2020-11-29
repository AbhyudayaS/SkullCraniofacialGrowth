using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class explode : MonoBehaviour {
	public Animation anim1;
	public Animation anim2;
	bool b;
	void Start(){
		anim1 ["ExplodeOut"].speed = 0; 
		anim2 ["ExplodeIn"].speed = 0; 
	}
	// Use this for initializatio

	void Update(){



	}

	public void OnMouseDown()
	{
		if (b == false) {
			anim1.Play ("ExplodeOut");
			anim1 ["ExplodeOut"].speed = 1; 
			b= true;
		} else {
			b= false;
			anim2.Play ("ExplodeIn");
			anim2 ["ExplodeIn"].speed = 1; 
		}
	}
}
