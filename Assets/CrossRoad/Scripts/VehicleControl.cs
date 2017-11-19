using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleControl : MonoBehaviour {

	public GameObject[] vehicle;
	public Transform[] spawnPoint;
	float time = 2;
	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnVehicle());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator SpawnVehicle()
	{
		while (true)
		{
			yield return new WaitForSeconds(time);
			time = Random.Range(2, 5);
			int index = Random.Range(0, vehicle.Length - 1);
			int side = Random.Range(0, 2);
			Transform spawn;
			VehicleMover.RoadSide roadSide;
			if (side == 0)
			{
				spawn = spawnPoint[0];
				roadSide = VehicleMover.RoadSide.right;
			}
			else
			{
				spawn = spawnPoint[1];
				roadSide = VehicleMover.RoadSide.left;
			}
			GameObject vehicleInstance = Instantiate(vehicle[index], spawn.position, spawn.rotation);
			VehicleMover mover = vehicleInstance.GetComponent<VehicleMover>();
			mover.roadSide = roadSide;
			mover.MoveCar();
		}
	}
}
