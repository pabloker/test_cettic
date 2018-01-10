using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	
	public static GameManager gameInstance;

	public Text scoreCollectableText, timerText, finalScore, username;
	public int count, collectableValue;
	public float timer; 
	public TimeManager timeManager;
	public GameObject playerPrefab, player, pauseMenu;

	private bool gameStarted;

	void Awake()
	{
		timeManager = GetComponent<TimeManager> ();
		Time.timeScale = 0f;
		if (gameInstance == null) 
		{
			gameInstance = this;
		} else if(gameInstance != this)
		{
			GameObjectUtil.Destroy (gameObject);
		}
	}
		
	void Start () 
	{
		username.text = "Logged as : " + PlayerPrefs.GetString ("username");
		timer = 1;
		StartGame();
	}

	void Update () 
	{
		ShowTimerScore ();
		ShowDeathPanel ();
	}

	void ShowDeathPanel()
	{
		var state = (!gameStarted && Time.timeScale == 0) ? true : false;
		pauseMenu.SetActive (state);
		finalScore.text = "Score: " + scoreCollectableText.text;
	}

	void ShowTimerScore()
	{
		scoreCollectableText.text =  count.ToString ();
		timerText.text = (timer -= Time.deltaTime).ToString ("0");
		if (timer <= 0) 
		{
			timerText.text = "0";
			OnPlayerKilled ();
			Time.timeScale = 0;
		}
	}

	void OnPlayerKilled()
	{
		var playerDestroyScript = player.GetComponent<DestroyOffscreen> ();
		playerDestroyScript.DestroyCallback -= OnPlayerKilled;
		timeManager.ManipulateTime (0, 5.5f);
		gameStarted = false;
	}

	public void StartGame()
	{
		player = GameObjectUtil.Instantiate(playerPrefab, new Vector3(0, (Screen.height/PixelPerfectCamera.pixelsToUnits)/2 -100, 0));
		gameStarted = true;
		timeManager.ManipulateTime(1f, 1f);
		var playerDestroyScript =  player.GetComponent<DestroyOffscreen> ();
		playerDestroyScript.DestroyCallback += OnPlayerKilled;
		count = 0;
	}
		
	IEnumerator StaminaTime()
	{
		yield return new WaitForSeconds (2f);
		StartCoroutine ("StaminaTime");
	}
}
