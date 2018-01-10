using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Lightscript : MonoBehaviour {

	public static Lightscript instanceLight;

	public float t;
	public bool isDawn;
	public bool isNight;
	public bool isDay;
	public bool isLate;

	private Color colorOrange = new Color(1F, 0.5F, 0.3F,1f);
	private Color colorOrange2 = new Color(1F, 0.5F, 0.3F,1f);
	private Color colorNight = new Color(0, 0, 0.2f,1f);
	private int count;
	private bool cycle;
	private Light luz;

	void Awake()
	{
		instanceLight = this;
	}

	void Start () 
	{
		cycle = true;
		count = 1;
		t = 0.1f;
		luz = GetComponent<Light> ();
		StartCoroutine ("DayCycle");
	}

	void Update () 
	{
		DawnToDay ();
		LateToNight ();
		NightToDawn ();
		DayToLate ();	    
	}

	IEnumerator DayCycle()
	{
		while(cycle) 
		{
			Debug.Log ("dia : "+count);
			yield return new WaitForSeconds (10f);
			isLate = true;
			yield return new WaitForSeconds (5f);
			isNight = true;
			yield return new WaitForSeconds (10f);
			isDawn = true;
			yield return new WaitForSeconds (5f);
			isDay = true;
			count = count + 1;
		}
	}

	void DawnToDay()
	 {
		if (isDay == true) 
		{
			t += Time.deltaTime;
			luz.color = Color.Lerp (colorOrange2, Color.white, t/5);
			if (luz.color == Color.white)
			{
				isDay = false;
				if (isDay == false) 
				{
					t = 0.1f;
				}
			}
		}
	}

	void LateToNight()
	{
		if (isNight == true)
		{
			t += Time.deltaTime;
			luz.color = Color.Lerp (colorOrange2, colorNight, t/5); 
			if (luz.color == colorNight)
			{
				isNight = false;
				if (isNight == false) 
				{
					t = 0.1f;
				}
			}
		}
	}

	void NightToDawn()
	{
		if (isDawn == true) 
		{
			t += Time.deltaTime;
			luz.color = Color.Lerp (colorNight, colorOrange2, t/5); 
			if (luz.color == colorOrange)
			{
				isDawn = false;
				if (isDawn == false) 
				{
					t = 0.1f;
				}
			}
		}
	}

	void DayToLate()
	{
		if (isLate == true) 
		{
			t += Time.deltaTime;
			luz.color = Color.Lerp (Color.white, colorOrange2, t/5); 
			if (luz.color == colorOrange)
			{
				isLate = false;
				if (isLate == false) 
				{
					t = 0.1f;
				}
			}
		}
	}
}
