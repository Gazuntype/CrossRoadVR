using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {
	public GameObject canvas;
	public GvrAudioSource jingle;

	public GameObject player;
	public GameObject mother;
	public GameObject kid;
	public GameObject sphere;

	public GvrAudioSoundfield jin;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartGame()
	{
		canvas.SetActive(false);
		jingle.Play();
	}

	public void MovePlayer()
	{
		jin.Play();
		iTween.MoveTo(player, iTween.Hash("position", new Vector3(sphere.transform.position.x, player.transform.position.y, sphere.transform.position.z),"time", 5, "easetype", iTween.EaseType.linear));
		iTween.MoveTo(mother, iTween.Hash("position", mother.transform.position + (mother.transform.forward * 13.7f),"time", 5, "easetype", iTween.EaseType.linear));
		mother.GetComponent<Animator>().SetBool("walking", true);
		iTween.MoveTo(kid, iTween.Hash("position", kid.transform.position + (kid.transform.forward * 13.7f),"time", 5, "easetype", iTween.EaseType.linear));
		kid.GetComponent<Animator>().SetBool("walking", true);
	}
}
