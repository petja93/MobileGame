using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour {

	public static int theScore;
	public GameObject scoreDisplay;

	void Start () {
		theScore = 0;
		InvokeRepeating ("addScore", 1, 0.1F);
	}

	public void addScore(){
		theScore += 0;
		scoreDisplay.GetComponent<Text>().text = "Score: " + theScore;
	}
}
