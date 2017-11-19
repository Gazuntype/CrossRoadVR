using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMover : MonoBehaviour {
	public enum RoadSide { left, right };

	[HideInInspector]
	public RoadSide roadSide;

	Vector3[] destination = new Vector3[2];
	// Use this for initialization
	void Start()
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MoveCar()
	{
		destination[0] = new Vector3(48.8f, 0.4214594f, 3.6f);
		destination[1] = new Vector3(-49.8f, 0.4214594f, 9.2f);
		Vector3 actualDestination;
		if (roadSide == RoadSide.left)
		{
			actualDestination = destination[1];
		}
		else
		{
			actualDestination = destination[0];
		}
		iTween.MoveTo(gameObject, iTween.Hash("position", actualDestination, "speed", 6, "easetype", iTween.EaseType.linear, "oncomplete", "DestroySelf"));
	}

	void DestroySelf()
	{
		Destroy(gameObject);
	}
}
