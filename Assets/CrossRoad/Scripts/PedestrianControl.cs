using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrianControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		iTween.MoveTo(gameObject, iTween.Hash("position", transform.position + (transform.forward * 100), "speed", 1, "easetype", iTween.EaseType.linear, "oncomplete", "DestroySelf"));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void DestroySelf()
	{
		Destroy(gameObject);	}
}
