using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]

public class InstantVelocity : MonoBehaviour {

	public Vector2 speed;
	private Rigidbody2D body;

	void Awake()
	{
		body = GetComponent<Rigidbody2D> ();
	}

	void Start()
	{}

	void FixedUpdate()
	{
		body.velocity = new Vector2 (speed.x, speed.y);
	}
}
