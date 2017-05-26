using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour {

	public static int theScore;
	public GameObject scoreDisplay;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("addScore", 1, 0.1F);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void addScore(){
		theScore += 0;
		scoreDisplay.GetComponent<Text>().text = "Score: " + theScore;
	}
}
