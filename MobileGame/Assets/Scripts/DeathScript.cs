using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour {

	public GameObject DeathBlack;
	public GameObject DeathText;
	public GameObject TheRocket;
	public AudioSource crash;
	public GameObject mainAudio;
	public GameObject highScore;

	public void OnTriggerEnter(Collider col){
		NextAxes.theXAxis = -1.0F;
		highScore.SetActive (true);
		crash.Play ();
		mainAudio.SetActive (false);
		DeathBlack.SetActive (true);
		DeathText.SetActive (true);
		TheRocket.SetActive (false);
	}
}
