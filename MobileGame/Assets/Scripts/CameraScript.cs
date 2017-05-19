/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	public Transform target;
	public float distance = 15.0F;
	public float CameraY = 10.0F;

	//public GameObject other;
	//public Camera cam = other.GetComponent<Camera> ();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position.z = target.position.z - distance;
		transform.position.x = target.position.x + 5;
	}

	public void LateUpdate(){

		//cam.main.transform.position.y = CameraY;

		GetComponent.<Camera>().main.transform.position.y = CameraY;
	}
}*/
