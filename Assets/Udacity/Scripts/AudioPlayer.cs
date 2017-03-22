using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour {


	//public GameObject gameLogic;
	public GameObject audioHolder;

	public void playerSelection() {

		//gameLogic.GetComponent<GameLogic> ().playerSelection(this.gameObject);
		Debug.Log("play");
		audioHolder.GetComponent<GvrAudioSource>().Play();
	
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
