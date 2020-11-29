using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class showallDropDown : MonoBehaviour {
	public Text[] drdw_txt;
	public Button[] drdw_btn;
	public Toggle[] all_tgl;
	// Use this for initialization

	
	// Update is called once per frame
	public void OnMouseDown () {
		foreach (Toggle go in all_tgl) {
			go.isOn = true;
		}
		foreach (Text go in drdw_txt) {
			go.color = Mandible.btn_txt;
		}
		foreach (Button go in drdw_btn) {
			go.image.color = Mandible.btn_start;
		}
	}
}
