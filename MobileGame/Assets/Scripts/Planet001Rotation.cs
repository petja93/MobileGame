using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet001Rotation : MonoBehaviour {

	public int speed;

	void Update () {
		speed = 1;
		transform.Rotate (0, speed, 0, Space.World);
	}
}
