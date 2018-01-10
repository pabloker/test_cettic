using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour {

	public int count;
	public Camera foreground, kitsune, background;
	public bool jump, staminaFull;

	private Animator kitsuneAnim;
	private float jumpReach, jumpLand, sceneReach;

	void Awake () 
	{
		background = GameObject.Find ("BackgroundCamera").GetComponent<Camera>();
		foreground = GameObject.Find ("ForegroundCamera").GetComponent<Camera>();
		kitsune = GameObject.Find ("KitsuneCamera").GetComponent<Camera>();
		kitsuneAnim = GetComponent<Animator> ();
		kitsune.depth = 3;
		jumpReach = 100;
		jumpLand = 120;
		sceneReach = 135;
	}

	void OnDisable()
	{
		EventManager.OnJump -= ToJump;
	}
	void OnEnable()
	{
		staminaFull = true;
		EventManager.OnJump += ToJump;
	}

	public void ToJump()
	{
		if (staminaFull == true)
		{
			jump = true;
			StartCoroutine ("JumpAction");
		}
	}

	void FixedUpdate ()
	{
		if (jump)
		{
			GetComponent<InstantVelocity> ().speed = Vector2.zero;
			kitsuneAnim.SetInteger ("State", 1);
			gameObject.GetComponent<CapsuleCollider2D> ().enabled = false;
			transform.Find ("HeadCollider").GetComponent<CapsuleCollider2D> ().enabled = false;
			transform.position = Vector2.MoveTowards (transform.position, new Vector2 (transform.position.x, transform.position.y + 150f), 1f);

			kitsune.orthographicSize = Mathf.Lerp (kitsune.orthographicSize, jumpReach, 10f * Time.deltaTime);
			background.orthographicSize = Mathf.Lerp (background.orthographicSize, sceneReach, 4f * Time.deltaTime);
			foreground.orthographicSize = Mathf.Lerp (foreground.orthographicSize, sceneReach, 4f * Time.deltaTime);
		} else if (!jump) 
		{
			kitsuneAnim.SetInteger ("State", 0);
			transform.Find ("HeadCollider").GetComponent<CapsuleCollider2D> ().enabled = true;
			gameObject.GetComponent<CapsuleCollider2D> ().enabled = true;

			kitsune.orthographicSize = Mathf.Lerp (kitsune.orthographicSize, jumpLand, 10f * Time.deltaTime);
			background.orthographicSize = Mathf.Lerp (background.orthographicSize, jumpLand, 2f * Time.deltaTime);
			foreground.orthographicSize = Mathf.Lerp (foreground.orthographicSize, jumpLand, 2f * Time.deltaTime);
		}
	}
	IEnumerator JumpAction()
	{
		yield return new WaitForSeconds (0.6f);
		jump = false;
		staminaFull = false;
		yield return new WaitForSeconds (1f);
		staminaFull = true;
	}
}

