using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ScoreSave : MonoBehaviour {

	public string fileName = "highscore.data";
	public int scoreAmount;
	//public int highScore;

	void Start () {
		//highScore = ScoreLoad.compareScore;
		//if (scoreAmount >= highScore) {
			scoreAmount = ScoringSystem.theScore;
			StreamWriter ourfile = File.CreateText (fileName); //von hier
			ourfile.WriteLine(scoreAmount);
			ourfile.Close(); //bis hier - Desktop-Version
			//PlayerPrefs.SetInt("Highscore", scoreAmount); //wird für die Android-Version benötigt
		//}
	}
}
