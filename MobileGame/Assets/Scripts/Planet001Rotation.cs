using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet001Rotation : MonoBehaviour {

	public int speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		speed = 1;
		transform.Rotate (0, speed, 0, Space.World);
	}
}
