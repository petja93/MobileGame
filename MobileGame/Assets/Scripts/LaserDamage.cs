using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserDamage : MonoBehaviour {

	public float damage = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D other){
		if (!other.CompareTag ("Player")) {
			//other.SendMessage("ApplayDamage", damage.SendM
			Destroy(gameObject);
		}
	}
}
