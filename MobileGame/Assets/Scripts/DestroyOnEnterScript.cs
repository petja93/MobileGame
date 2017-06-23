using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnEnterScript : MonoBehaviour {

	void Start () {


    }
	
	void Update () {
	    
	}

	public void OnTriggerEnter(Collider other){
		if (other.CompareTag ("Projectile")) {
			//other.SendMessage("ApplayDamage", damage.SendM
			Destroy(gameObject);
		}
	}
}
