using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour {

	public GameObject kitsunecamera;
	public GameObject foregroundcamera;

	void FixedUpdate ()
	{
		if (GameManager.gameInstance.player != null) {
			if (GameManager.gameInstance.player.transform.position.x < -35) {
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-15, transform.position.y, transform.position.z), 1);
				kitsunecamera.transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-25, transform.position.y, transform.position.z), 0.5f);
				foregroundcamera.transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-25, transform.position.y, transform.position.z), 0.5f);
			} else if (GameManager.gameInstance.player.transform.position.x > -20 && GameManager.gameInstance.player.transform.position.x < 0) {
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (0, transform.position.y, transform.position.z), 1);
				kitsunecamera.transform.position = Vector3.MoveTowards (transform.position, new Vector3 (0, transform.position.y, transform.position.z), 0.5f);
				foregroundcamera.transform.position = Vector3.MoveTowards (transform.position, new Vector3 (0, transform.position.y, transform.position.z), 0.5f);
			}

			if (GameManager.gameInstance.player.transform.position.x > 30) {
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (15, transform.position.y, transform.position.z), 1);
				kitsunecamera.transform.position = Vector3.MoveTowards (transform.position, new Vector3 (25, transform.position.y, transform.position.z), 0.5f);
				foregroundcamera.transform.position = Vector3.MoveTowards (transform.position, new Vector3 (25, transform.position.y, transform.position.z), 0.5f);
			} else if (GameManager.gameInstance.player.transform.position.x < 20 && GameManager.gameInstance.player.transform.position.x > 0) {
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (0, transform.position.y, transform.position.z), 1);
				kitsunecamera.transform.position = Vector3.MoveTowards (transform.position, new Vector3 (0, transform.position.y, transform.position.z), 0.5f);
				foregroundcamera.transform.position = Vector3.MoveTowards (transform.position, new Vector3 (0, transform.position.y, transform.position.z), 0.5f);
			}
		}
	}
	}
