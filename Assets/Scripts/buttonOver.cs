using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class buttonOver : MonoBehaviour {
	Button me;
	Color startcol;
	Color rolov;
	// Use this for initialization
	void Start () {
		me = this.GetComponent<Button> ();
		startcol = me.image.color;
		rolov = new Color (0.36f, 0.75f, 0.76f, 1);
	}
	public void rollover(){
		me.image.color = rolov;
	}
	public void rollout(){
		me.image.color = startcol;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
