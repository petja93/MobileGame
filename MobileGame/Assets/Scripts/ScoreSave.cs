using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ScoreSave : MonoBehaviour {

	public string fileName = "highscore.data";
	public int scoreAmount;

	public int highScore;

	// Use this for initialization
	void Start () {
		highScore = ScoreLoad.compareScore;
		if (scoreAmount >= highScore) {
			scoreAmount = ScoringSystem.theScore;
			StreamWriter ourfile = File.CreateText (fileName);
			ourfile.WriteLine(scoreAmount);
			ourfile.Close();
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
