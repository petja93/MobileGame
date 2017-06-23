using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour {

	public float movement;
	public int lifeTicks;

	private int aliveFor;

	public float speed = 8.0F;
	public Vector3 moveDirection = Vector3.zero;

	void Awake(){
		transform.parent = GameObject.Find ("BulletContainer").transform;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate(){
		/*moveDirection = new Vector3 (0, 0, Input.GetAxis ("Horizontal") + 3); //geh 3 Schritte nach rechts
		moveDirection = transform.TransformDirection(moveDirection); 
		moveDirection *= speed;*/

		//transform.Translate (Vector3.forward * movement);

		aliveFor++;
		if (aliveFor == lifeTicks) {
			Destroy (gameObject);
			PoolBehaviour.bulletPool.releaseObject (gameObject);
		}
	}
}
