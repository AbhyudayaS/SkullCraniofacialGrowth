using UnityEngine;
using UnityEngine.UI;


public class MagnetLable : MonoBehaviour {
	public GameObject parnt;




	void Update(){

		this.tag = parnt.tag;
		Destroy (this.gameObject.GetComponent<overOut>());
	}
}

