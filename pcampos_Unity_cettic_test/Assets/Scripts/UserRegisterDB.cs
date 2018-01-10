using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserRegisterDB : MonoBehaviour {

	private	string createUserURL = "http://localhost/website/data/register.php";

	public InputField inputUsername, inputPassword;
	public Text warningMsg;

	public void CheckCreateUser()
	{
		StartCoroutine ("CreateUsertoDB");
	}	

	IEnumerator CreateUsertoDB()
	{
		WWWForm form = new WWWForm ();
		form.AddField ("usernamePost", inputUsername.text);
		form.AddField ("passwordPost", inputPassword.text);
		WWW www = new WWW (createUserURL, form);
		yield return www;
		warningMsg.text = www.text;
		Debug.Log (www.text);
		www.Dispose ();
	}
}
