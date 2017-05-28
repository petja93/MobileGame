using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSections : MonoBehaviour {

	public GameObject section1;
	//public GameObject section2;
	//public GameObject section3;

	public float newXAxis = NextAxes.theXAxis;
	public int genSec;
	public GameObject newSec;
	public Vector3 nextPosition = new Vector3 (NextAxes.theXAxis, 100, 50);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter(Collider col){
		nextPosition = new Vector3 (NextAxes.theXAxis, 100, 50);
		genSec = Random.Range (1, 1);
		newXAxis = NextAxes.theXAxis;

		if (genSec == 1) {
			newSec = section1;
		}
		/*if (genSec == 2) {
			newSec = section2;
		}*/
		/*if (genSec == 3) {
			newSec = section3;
		}*/

		Instantiate (newSec, nextPosition, Quaternion.identity);
		NextAxes.theXAxis = 500;
	}
}
