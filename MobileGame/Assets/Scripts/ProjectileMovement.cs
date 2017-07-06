using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour {

	public int lifeTicks;
	private int aliveFor;

	private void FixedUpdate(){

		aliveFor++;
		if (aliveFor == lifeTicks) {
			Destroy (gameObject);
		}
	}
}
