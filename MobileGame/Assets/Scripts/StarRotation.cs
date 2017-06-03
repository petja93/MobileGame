using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarRotation : MonoBehaviour {

	public int speed;

	void Update () {
		speed = 2;
		transform.Rotate (0, speed, 0, Space.World);
	}
}
