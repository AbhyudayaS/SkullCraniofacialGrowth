using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OccipitalBon: MonoBehaviour {
	public GameObject[] part;
	public bool a;
	bool b;
	public Button me;
	public Text me_txt;
	public static Color btn_start;
	public static Color btn_txt;
	int i;
	public Toggle colg;
	bool objstatus;
	bool ctgl;
	bool t;
	public Shader crossSection;
	float sldvalueS;
	Vector4 predeS;
		// Use this for initialization
	void Start () {
		btn_start = me.image.color;
		btn_txt = me_txt.color;
	
	}

	void Update(){

		if (me.image.sprite == MaxillaBon.HideGloble[0]) {
			a= false;
		}
		sldvalueS = crosSection.sldrvalue;
		predeS = crosSection.prede;
		
		if (ctgl == true) {
			predeS [3] = sldvalueS;
			foreach (GameObject go in part) {
				go.GetComponent<Renderer> ().material.shader = crossSection;
				go.GetComponent<Renderer>().material.SetVector ("_section", predeS);
			}		
		} else {
			foreach (GameObject go in part) {
				go.GetComponent<Renderer> ().material.shader = Shader.Find("Standard");
			}
		}
	}

	public void toogleCross(){
		
		if (t== false) {
			CrossOnOff.count = CrossOnOff.count +1;
			ctgl = true;
			t= true;
		} else {
			CrossOnOff.count = CrossOnOff.count -1;
			ctgl = false;
			t= false;
		}
		
	}

	public void toogle(){
		if (b == false) {
			showAll.a = true;
			foreach(GameObject go in part){
			go.SetActive (false);
			go.GetComponent<Renderer> ().material.color = Color.white;
			}

			b = true;

		} else {
			showAll.a = false;
			foreach(GameObject go in part){
				go.SetActive(true);
				go.GetComponent<Renderer>().material.color = overOut.startcolor;
				go.tag= "Finish";
			}

			me.image.sprite = MaxillaBon.HideGloble[0];
			me_txt.color = btn_txt;
			b = false;
		}
		
	}


	// Update is called once per frame
	public void OnMouseDown(){
		if (a == false && part[i].tag != "Player") {
			foreach(GameObject go in part){
			go.GetComponent<Renderer> ().material.color = overOut.msDownColor;
			go.tag = "Player";
			}
			a = true;
			me.image.sprite = MaxillaBon.HideGloble[1];
			//me.image.color = new Color (0.2f,0.2f,0.2f);
			me_txt.color = Color.white;

		} else {
			foreach(GameObject go in part){
			go.GetComponent<Renderer> ().material.color = overOut.startcolor;
			go.tag = "Finish";
			}
			me.image.sprite = MaxillaBon.HideGloble[0];
			//me.image.color = btn_start;
			me_txt.color = btn_txt;
			a = false;
		}
	}
}
