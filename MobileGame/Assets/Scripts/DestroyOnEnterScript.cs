using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnEnterScript : MonoBehaviour {

	public void OnTriggerEnter(Collider other){
		if (other.CompareTag ("Laser")) { 
			Destroy(gameObject);
		}
	}
}
