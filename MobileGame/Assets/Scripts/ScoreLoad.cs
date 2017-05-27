using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ScoreLoad : MonoBehaviour {

	public string filename = "highscore.data";
	public string scoreLoad;
	public GameObject highScoreDisplay;

	public string line;

	// Use this for initialization
	void Start () {
		StreamReader sr = new StreamReader (filename);

		line = sr.ReadLine ();
		while (line != null) {
			scoreLoad = line;
			line = sr.ReadLine ();
		}
		sr.Close ();

		highScoreDisplay.GetComponent<Text>().text = "" + scoreLoad;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
