using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bushScript : MonoBehaviour {

	ParticleSystem bushFX;

	void Start () {

		bushFX = transform.Find ("LeafParticles").GetComponent<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{

		if (other.CompareTag ("kitsune"))
		{
			
			bushFX.Play ();
		}
	}
}
