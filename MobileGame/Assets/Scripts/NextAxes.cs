using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextAxes : MonoBehaviour {

	public static float theXAxis = -1.0F;
	public float internalAxis;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		internalAxis = theXAxis;
	}
}
