using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorsky1 : MonoBehaviour {

	public bool appear;
	private CanvasRenderer rende;
	private float t = 0;
	private Color color1,color2;

	void Start () 
	{
		color1 = Color.white;
		color2 = Color.blue;
		rende = GetComponent<CanvasRenderer> ();
	}

	void Update ()
	{
		if (appear) 
		{
			color1 = Color.white;
			color2 = Color.blue;
			t += Time.deltaTime;

			rende.SetColor (Color.Lerp (color1, color2, t / 5f));

				t = 0;
				color1 = Color.blue;
				color2 = Color.white;
				appear = false;
		}
	}
}
	
