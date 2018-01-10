using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UserLoginDB : MonoBehaviour {

	private string loginURL = "http://localhost/test_cettic/data/login.php";

	public InputField username, password;
	public Text warningMsg;

	public void CheckLogin()
	{
		StartCoroutine ("LoginToDB");
	}	

	IEnumerator LoginToDB()
	{
		WWWForm form = new WWWForm ();
		form.AddField ("usernamePost", username.text);
		form.AddField ("passwordPost", password.text);
		WWW www = new WWW (loginURL, form);
		yield return www;
		warningMsg.text = www.text;
		Debug.Log (www.text);

		if (www.text == "login success") {
			www.Dispose ();
			PlayerPrefs.SetString ("username", username.text);
			SceneManager.LoadScene ("scene2");
		}
	}
}
