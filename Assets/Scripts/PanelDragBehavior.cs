using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform))]
public class PanelDragBehavior : MonoBehaviour
{
	private RectTransform rect;
	
	public void Awake()
	{
		rect = GetComponent<RectTransform>();
	}
	
	public void OnDrag(UnityEngine.EventSystems.BaseEventData eventData)
	{
		var pointerData = eventData as UnityEngine.EventSystems.PointerEventData;
		if (pointerData == null) { return; }
		
		
		var currentPosition = rect.position;
		currentPosition.x += pointerData.delta.x;
		currentPosition.y += pointerData.delta.y;
		rect.position = currentPosition;
	}
}