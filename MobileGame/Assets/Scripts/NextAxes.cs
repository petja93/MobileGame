﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextAxes : MonoBehaviour {

	public static float theXAxis = 817.0F;
	public float internalAxis;

	void Update () {
		internalAxis = theXAxis;
	}
}
