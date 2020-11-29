using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class defimain : MonoBehaviour {

	public Text df_txt;
	public Text ttl_txt;
	public static string defination;
	public static string title;


	void Start(){

		title = "Part Defination";
		defination = "Select object.";

	}
	void Update(){

			df_txt.text = defination;
			ttl_txt.text = title;
	}
}