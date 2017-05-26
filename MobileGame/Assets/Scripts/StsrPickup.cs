using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StsrPickup : MonoBehaviour {

	public int starScore = 5;
	public AudioSource starSound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter(Collider col){
		starSound.Play();
		ScoringSystem.theScore += starScore;
		this.transform.position = new Vector3(0, 1000, 0);
	}
}
