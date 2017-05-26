using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour {

	public GameObject DeathBlack;
	public GameObject DeathText;
	public GameObject TheRocket;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter(Collider col){
		DeathBlack.SetActive (true);
		DeathText.SetActive (true);
		TheRocket.SetActive (false);
	}
}
