using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSections : MonoBehaviour {

	public GameObject section1;
	public GameObject section2;
	public GameObject section3;

	public float newXAxis = NextAxes.theXAxis;
	public int genSec;
	public GameObject newSec;
	public Vector3 nextPosition = new Vector3 (NextAxes.theXAxis, 0, 50); //1635 + 818 = 2453

	public void OnTriggerEnter(Collider col){
		nextPosition = new Vector3 (NextAxes.theXAxis, 0, 50);
		genSec = Random.Range (1, 4);
		newXAxis = NextAxes.theXAxis;

		if (genSec == 1) {
			newSec = section1;
		}
		if (genSec == 2) {
			newSec = section2;
		}
		if (genSec == 3) {
			newSec = section3;
		}

		Instantiate (newSec, nextPosition, Quaternion.identity);
		NextAxes.theXAxis += 818;
	}
}
