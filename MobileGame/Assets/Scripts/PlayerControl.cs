using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public float speed = 6.0F; 
	public float jumpspeed = 15.0F;  
	public float gravity = 20.0F; 
	public Vector3 moveDirection = Vector3.zero;

	void Update () {

		CharacterController controller = GetComponent<CharacterController>(); //erstellt Controller-Objekt
		if(controller.isGrounded){ //wenn conrtoller-Objekt "Boden" berührt, dann
			moveDirection = new Vector3 (0, 0, Input.GetAxis ("Horizontal") + 3); //geh 3 Schritte nach rechts
			moveDirection = transform.TransformDirection(moveDirection); 
			moveDirection *= speed;

			if(Input.GetButtonDown("Jump")){
				moveDirection.y += jumpspeed;
			}
		//Wenn man den else-Zweig weglässt, kann man nicht mehrmals "springen"
		}else{
			if (Input.GetButtonDown ("Jump")) {
				moveDirection.y += jumpspeed;
			}
		}
		
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}
}
