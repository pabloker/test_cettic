using UnityEngine;
using System.Collections;

public class PixelPerfectCamera : MonoBehaviour {

	public static float pixelsToUnits = 100f;
	public static float scale = 100f;

	public Vector2 nativeResolution = new Vector2 (960, 240);

	void Start () {
		var camera = GetComponent<Camera> ();

		if (camera.orthographic) {
			scale = Screen.height/nativeResolution.y;
			pixelsToUnits *= scale;
			camera.orthographicSize = (Screen.height / 2.0f) / pixelsToUnits;
		}
	}

}
