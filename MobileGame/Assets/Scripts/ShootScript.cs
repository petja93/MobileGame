using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour {

	private bool isAttacking = false;
	public GameObject laserPrefab;
	public Transform spawnPoint;
	public int laserSpeed = 2000;


	void Update () {

		if (Input.GetButtonDown ("Fire1") && !isAttacking) {
			isAttacking = true;
		}
	}

	void FixedUpdate(){
		if (isAttacking) {
			GameObject laser = (GameObject)Instantiate (laserPrefab, spawnPoint.position, Quaternion.identity); 
			laser.GetComponent<Rigidbody> ().AddForce (Vector3.right * laserSpeed);
			isAttacking = false;
		}
	}
}
