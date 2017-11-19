using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrianSpawn : MonoBehaviour {
	public GameObject[] pedestrian;
	public Transform[] spawnPoint;
	float time = 3;
	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnPedestrian());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator SpawnPedestrian()
	{
		while (true)
		{
			yield return new WaitForSeconds(time);
			time = Random.Range(2, 5);
			int index = Random.Range(0, pedestrian.Length - 1);
			int side = Random.Range(0, 4);
			Transform spawn;
			spawn = spawnPoint[side];
			GameObject pedestrianInstance = Instantiate(pedestrian[index], spawn.position, spawn.rotation);
		}	}
}
