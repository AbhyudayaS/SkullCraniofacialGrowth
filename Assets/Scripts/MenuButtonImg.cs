using UnityEngine;  
using System.Collections;  
using UnityEngine.EventSystems;  
using UnityEngine.UI;

public class MenuButtonImg : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
	
	public Image theText;
	bool a;
	void Update(){

		if (a==true) {
			theText.color = Color.black; //Or however you do your color
		} else {
			theText.color = Color.white;
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