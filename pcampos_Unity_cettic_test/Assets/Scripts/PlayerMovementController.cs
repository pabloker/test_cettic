using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour {

	public GameObject startPosition;
	public float kitsuSpeed;
	public bool isConsumable;

	private InstantVelocity body;
	private float forwardSpeed;

	void Awake ()
	{
		kitsuSpeed = 90;
		body = GetComponent<InstantVelocity> ();
	}
		
	void FixedUpdate()     
	{
		body.speed = Vector2.zero;
		KeyboardControl();
		BackToLine();
	}

	void BackToLine()
	{
		forwardSpeed = 1f;
		if (transform.position.y < startPosition.transform.position.y  || transform.position.y > startPosition.transform.position.y) 
		{
			transform.position = Vector2.MoveTowards (transform.position, new Vector2 (transform.position.x, startPosition.transform.position.y), forwardSpeed);
		}
	}
	void KeyboardControl()
	{
		if (Input.GetKey (KeyCode.A))
		{
			body.speed = new Vector2 (-kitsuSpeed , 0);
		} else if (Input.GetKey (KeyCode.D))
		{
			body.speed = new Vector2 (kitsuSpeed , 0);
		}
	}
		
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("ricebranch")) 
		{
			isConsumable = true;
			other.gameObject.GetComponent<ConsumeCollectable> ().touch = true;
			other.gameObject.GetComponent<InstantVelocity> ().speed.y = 0;
		}
	}

	void OnCollisionStay2D(Collision2D other)
	{
		if (other.collider.CompareTag ("youkai")) 
		{
			other.gameObject.GetComponent<OniAnimation> ().oniAnim.SetInteger ("State", 1);
			other.gameObject.GetComponent<InstantVelocity> ().speed = new Vector2 (0, -150);
		}
	}
}

		

