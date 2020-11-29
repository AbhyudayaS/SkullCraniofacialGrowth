using UnityEngine;
using System.Collections;

public class rightClick : MonoBehaviour {
	public GameObject rghtCMenu;
	Vector3 posn;
	float x;
	float y;

	public void Update(){
		x = Input.mousePosition.x;
		y = Input.mousePosition.y;
		posn = new Vector3 (x, y, 0);
		
		if (Input.GetMouseButtonDown (1)) {
			rghtCMenu.SetActive(true);
			rghtCMenu.transform.position = posn;
		}
	}

}
