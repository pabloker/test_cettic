using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RicebagAnim : MonoBehaviour {

	public Animator anim;

	void Start () 
	{
		anim = GetComponent<Animator> ();
	}
		
	void Update ()
	{
		anim.SetInteger ("State", 1);
	}
}
