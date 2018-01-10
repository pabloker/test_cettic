using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallAttributesDB : MonoBehaviour {

	private string URL = "http://localhost/test_cettic/data/callattributes.php";
	private string[] array;

	void Awake()
	{
		StartCoroutine ("getValues");
	}	

	void Start()
	{
	}

	IEnumerator getValues()
	{
		WWW www = new WWW (URL);
		yield return www;
		array = www.text.Split ('.');
		GameManager.gameInstance.timer = int.Parse(array[0]);
		GameManager.gameInstance.collectableValue = int.Parse(array[1]);
		GameManager.gameInstance.player.GetComponent<PlayerMovementController>().kitsuSpeed = float.Parse(array[2]);
		www.Dispose ();
	}
}
