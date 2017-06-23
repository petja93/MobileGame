using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour {

	private int cooldown;
	public int maxCooldown;

	public GameObject projectile;

	public float speed = 8.0F;
	public Vector3 moveDirection = Vector3.zero;

	// Use this for initialization
	void Start () {
		cooldown = maxCooldown; //Dont do this if we are count with cooldown++;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate(){
		cooldown--;

		if (Input.GetButton ("Fire2")) {
			if (cooldown <= 0) {
				GameObject bullet = PoolBehaviour.bulletPool.getObject ();

				moveDirection = new Vector3 (0, 0, Input.GetAxis ("Horizontal") + 3); //geh 3 Schritte nach rechts
				moveDirection = transform.TransformDirection(moveDirection); 
				moveDirection *= speed;

				bullet.transform.position = transform.position + transform.forward;
				bullet.transform.rotation = transform.rotation;
				cooldown = maxCooldown;
			}
		}
	}
}
