using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyOrQuit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnGUI(){
		if (GUI.Button (new Rect (Screen.width / 2 , Screen.height/2 - 50, 100, 30), "Fly Again")) {
			Application.LoadLevel (2);
		}

		if (GUI.Button (new Rect (Screen.width / 2, Screen.height/2 + 50, 100, 30), "Main Menu")) {
			Application.LoadLevel (0);
		}
	}
}
