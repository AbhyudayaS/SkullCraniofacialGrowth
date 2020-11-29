using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ImageGallary : MonoBehaviour {
	public Image showcase;
	public Sprite[] collection = new Sprite[6];

	// Use this for initialization
	public void A(){
		showcase.sprite = collection [0];
	}

	public void B(){
		showcase.sprite = collection [1];
	}
	public void C(){
		showcase.sprite = collection [2];
	}
	public void D(){
		showcase.sprite = collection [3];
	}
	public void E(){
		showcase.sprite = collection [4];
	}
	public void F(){
		showcase.sprite = collection [5];
	}

}
