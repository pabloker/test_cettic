using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OniAnimation : MonoBehaviour {

	public Animator oniAnim;
	public bool runningOni;
	public Vector2 delayRange;

	private InstantVelocity body;
	private float delay;

	void Awake () 
	{
		ResetDelay ();
		oniAnim = GetComponent<Animator> ();
		body = GetComponent<InstantVelocity> ();
	}
		
	void FixedUpdate () 
	{
		OniRunner ();
	}

	void OniRunner ()
	{
		if (runningOni) {
			if (transform.position.y < delay) 
			{
				body.speed.y = -220;
				oniAnim.SetInteger ("State", 1);
			}
		}
	}
		
	void ResetDelay()
	{
		delay = Random.Range (delayRange.x, delayRange.y);
	}

	void OnEnable()
	{
		ResetDelay ();
	}
}
