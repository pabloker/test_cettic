using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {

	public static EventManager eventInstance;

	public delegate void actions();
	public static event actions OnJump;
	public static event actions OnConsumable;
	public static event actions OnNight;
	public static event actions OnDay;

	void Awake()
	{
		if (eventInstance == null) 
		{
			eventInstance = this;
		}else if(eventInstance != this)
		{
			GameObjectUtil.Destroy (gameObject);
		}
	}

	void Update ()
	{
		if (GameManager.gameInstance.player != null) {
			if (Input.GetKey (KeyCode.Space) && GameManager.gameInstance.player.GetComponent<JumpController> ().jump == false) {
				if (OnJump != null) {	
					OnJump ();
				}
			}
			if (GameManager.gameInstance.player.GetComponent<PlayerMovementController> ().isConsumable) {
				if (OnConsumable != null) {
					OnConsumable ();
				}
			}
			if (Lightscript.instanceLight.isNight) {
				if (OnNight != null) {
					OnNight ();
				}
			}
			if (Lightscript.instanceLight.isDay) {
				if (OnDay != null) {
					OnDay ();
				}
			}
		}
	}
}
