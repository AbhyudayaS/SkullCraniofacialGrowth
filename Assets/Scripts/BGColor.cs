using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BGColor : MonoBehaviour {
	public Camera main;
	public Camera ortho;

	void Update(){
	
	}

	public void Black()
	{
	
		main.backgroundColor = new Color (0.11f, 0.11f, 0.11f);
		ortho.backgroundColor = new Color (0.11f, 0.11f, 0.11f);
	}

	public void White()
	{
		main.backgroundColor = new Color (0.90f, 0.90f, 0.90f);
		ortho.backgroundColor = new Color (0.90f, 0.90f, 0.90f);
	}
}
