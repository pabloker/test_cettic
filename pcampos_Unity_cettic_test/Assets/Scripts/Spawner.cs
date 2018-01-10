using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject[] prefabs;
	public bool active, inLine, ordenLayer, randomSpeed;
	public Vector2 delayRange, spawnPositionRange, newSpeedX, newSpeedY;
	public int itemAmount;
	public float waveWait;

	private float delay;
	private Vector2 newPosition;
	private GameObject newInstance;

	void Start () 
	{
		ResetDelay ();
		StartCoroutine (EnemyGenerator ());
	}
		
	IEnumerator EnemyGenerator()
	{
		yield return new WaitForSeconds (delay);
		if (active) 
		{
			for (int i = 0; i < itemAmount; i++)
			{
				newPosition = new Vector2 (Random.Range (spawnPositionRange.x, spawnPositionRange.y), transform.position.y);
				newInstance = GameObjectUtil.Instantiate (prefabs [Random.Range (0, prefabs.Length)], newPosition);
				newInstance.GetComponent<SpriteRenderer>().sortingOrder = 0;

				if (randomSpeed) 
				{
					newInstance.GetComponent<InstantVelocity> ().speed.x = Random.Range (newSpeedX.x, newSpeedX.y);
					newInstance.GetComponent<InstantVelocity> ().speed.y = Random.Range(newSpeedY.x,newSpeedY.y);
				}
			
				if (!inLine) 
				{
					yield return new WaitForSeconds (delay);
				}
				ResetDelay ();
			}
			yield return new WaitForSeconds (waveWait);	
		}
		StartCoroutine (EnemyGenerator ());
	}

	void ResetDelay()
	{
		delay = Random.Range (delayRange.x, delayRange.y);
	}
}
