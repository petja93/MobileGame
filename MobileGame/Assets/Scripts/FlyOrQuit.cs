using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyOrQuit : MonoBehaviour {

	public void OnGUI(){
		if (GUI.Button (new Rect (Screen.width / 2 - 120, Screen.height/2 - 50, 100, 30), "Fly Again")) {
			Application.LoadLevel (2);
		}

		if (GUI.Button (new Rect (Screen.width / 2, Screen.height/2 - 50, 100, 30), "Main Menu")) {
			Application.LoadLevel (0);
		}
	}
}
