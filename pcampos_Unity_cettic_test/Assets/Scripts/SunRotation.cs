using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotation : MonoBehaviour {

	void Start ()
	{}

	void Update () 
	{
		gameObject.transform.Rotate (Vector3.forward * - .5f);
	}
}
