using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	void Start () {
	}
	public void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		GameObjectUtil.Reset ();
	}
	public void Quit()
	{
		PlayerPrefs.DeleteKey ("username");
		GameObjectUtil.Reset ();
		SceneManager.LoadScene ("scene1");
	}
}
