using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour {

    HealthScript healthscript;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision) {
		Debug.Log ("collided");
		//healthscript.looseHealth(1);
		//Vector3 scale = transform.localScale;
		//scale.y /= 2;
		//transform.localScale = scale;
	}



}