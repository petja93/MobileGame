using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StsrPickup : MonoBehaviour {

	public int starScore = 5;
	public AudioSource starSound;

	public void OnTriggerEnter(Collider col){
		starSound.Play();
		ScoringSystem.theScore += starScore;
		this.transform.position = new Vector3(0, 1000, 0);
	}
}
