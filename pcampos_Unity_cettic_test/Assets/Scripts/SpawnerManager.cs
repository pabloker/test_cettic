using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour {

	public GameObject spawnerDay,spawnerNight;
	private bool spawnerActive;

	void Start ()
	{
		spawnerActive = true;
	}

	void Update () 
	{
		if (Lightscript.instanceLight.isNight && spawnerActive) {
				StartCoroutine ("ActivateSpawner");
				spawnerActive = false;
		}  
		if (Lightscript.instanceLight.isDay) {
				spawnerDay.GetComponent<Spawner> ().active = true;
				spawnerNight.GetComponent<Spawner> ().active = false;
				spawnerActive = true;
		}
	}
	IEnumerator ActivateSpawner()
	{
		spawnerDay.GetComponent<Spawner> ().active = false;
		yield return new WaitForSeconds (2);
		spawnerNight.GetComponent<Spawner> ().active = true;
	}
}
