using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayGame(){
		Application.LoadLevel (1);
	}

	public void QuitGame(){
		Application.Quit ();
	}
}
