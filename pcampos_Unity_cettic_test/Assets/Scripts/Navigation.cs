using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour {

	public GameObject panelSignIn, panelSignUp;
	public CanvasRenderer rende;
	public float t = 0;
	Color color1,color2;

	void Start()
	{	
		Time.timeScale = 1;
		t = 0;
		color2 = Color.white;
	}
	void Update () {
		
		t += Time.deltaTime;
		rende.SetColor (Color.Lerp (rende.GetColor(), color2, t / 50f));

		}
		
	public void ToSignUp()
	{
		panelSignIn.SetActive (false);
		panelSignUp.SetActive (true);

		t = 0;
		color2 = Color.red;

	}
	public void ToSignIn()
	{
		panelSignIn.SetActive (true);
		panelSignUp.SetActive (false);

		t = 0;
		color2 = Color.white;
	}
}




