using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SessionRegisterDB : MonoBehaviour {

	private string URL = "http://localhost/website/data/sessions.php";

	void Start ()
	{
		StartCoroutine ("getValues");
	}

	IEnumerator getValues()
	{
		yield return new WaitUntil(() => GameManager.gameInstance.pauseMenu.activeSelf == true);
		WWWForm form = new WWWForm ();
		form.AddField ("UnityFinalScore", GameManager.gameInstance.scoreCollectableText.text);
		form.AddField ("UnityUser", PlayerPrefs.GetString("username"));
		WWW www = new WWW (URL, form);
		yield return www;
		Debug.Log (www.text);
		www.Dispose ();
	}
}
