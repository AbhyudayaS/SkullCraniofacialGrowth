using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class overOutTeeth : MonoBehaviour {
	GameObject[] pk;
	GameObject[] fk;
	public static Color startcolor;
	public static Color rolOvrColor;
	public static Color msDownColor;
	bool a;



	void Start()
	{
		//pk = this.gameObject;
		rolOvrColor = new Color(0.5f,0.9f,0.9f,0);
		msDownColor = new Color (0.34f, 0.56f, 1f,0);
		startcolor = this.GetComponent<Renderer> ().material.color;

	
		//startcolor = new Color (0.89f, 0.90f, 0.88f);
	}
	void Update()
	{

		pk = GameObject.FindGameObjectsWithTag ("Player");

		if (this.GetComponent<Renderer> ().material.color == msDownColor) {
			this.tag = "Player";
			a= true;
		}

		if (this.GetComponent<Renderer> ().material.color == startcolor) {
			this.tag = "Finish";
			a= false;
		}
		if (Input.GetKey (KeyCode.LeftShift) || Input.GetKey (KeyCode.RightShift)) {
			pk= fk;
		}
	}


	 void OnMouseEnter()
	{
		if (a == false) {
			GetComponent<Renderer> ().material.color = rolOvrColor;
		}
	}

	void OnMouseExit()
	{
		if (a == false) {
			GetComponent<Renderer> ().material.color = startcolor;
		}
	}

	void OnMouseDown()
	{
		if (a == false ) {
			GetComponent<Renderer> ().material.color = msDownColor;
			a = true;
		} else {
			GetComponent<Renderer> ().material.color = startcolor;
			a= false;

		
		}
		foreach(GameObject go in pk){
			
			go.GetComponent<Renderer>().material.color = startcolor;
		}
		destroy.newtar =this.gameObject.transform;
	}
}

