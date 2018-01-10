using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsumeCollectable : MonoBehaviour {

	public Transform wallet;
	public bool touch;
	private float movespeed;
	private int count;

	void OnEnable()
	{
		EventManager.OnConsumable += ConsumeItem;
	}

	void OnDisable()
	{
		EventManager.OnConsumable -= ConsumeItem;
	}

	void ConsumeItem ()
	{
		if (touch) 
		{
			GameObject.Find("Ricebag").GetComponent<Animator> ().SetInteger ("State", 0);
			movespeed += 0.7f;
			transform.position = Vector2.MoveTowards (transform.position, wallet.position, movespeed);
			if (transform.position.y == wallet.position.y) 
			{
				movespeed = 0f;
				touch = false;
				gameObject.GetComponent<InstantVelocity> ().speed.y = -80;
				GameObject.Find("Ricebag").GetComponent<Animator> ().SetInteger ("State", 1);
				GameObjectUtil.Destroy (this.gameObject);
				GameManager.gameInstance.count += GameManager.gameInstance.collectableValue ;
			}
		}
	}
}
