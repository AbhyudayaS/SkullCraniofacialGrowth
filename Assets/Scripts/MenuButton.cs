using UnityEngine;  
using System.Collections;  
using UnityEngine.EventSystems;  
using UnityEngine.UI;

public class MenuButton : MonoBehaviour{


	public Text theText;
	bool a;
	bool b;
	void Update(){
		b = this.gameObject.activeSelf;
		if (a==true) {
			theText.color = Color.white; //Or however you do your color
		} else {
			theText.color = Color.black;
		}
	}
	
	public void OnPointerEnter(PointerEventData eventData)
	{
		a = true;
		
	}
	
	public void OnPointerExit(PointerEventData eventData)
	{
		a = false;
		
	}
}