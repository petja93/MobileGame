using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathScript : MonoBehaviour {

	public GameObject DeathBlack;
	public GameObject DeathText;
	public GameObject TheRocket;
	public AudioSource crash;
	public GameObject mainAudio;
	public GameObject highScore;

	public Sprite sprite2;
	public Sprite sprite1;
	public Sprite sprite0;

	public Image image;


	public static int health = 3; //die beiden Variablen müssen statisch sein, da sonst die Rechnnung nicht funktioniert
	public static int amount = 1; //Ein weiterer Vorteil ist, wenn man die Variablen als static deklariert, kann man aus anderen Skripten darauf zugreifen

	public void OnTriggerEnter(Collider col){

		if (health <= 1) {
			health = health - amount;
			changeImage (health);
			Debug.Log (" anderes getriggered");
			NextAxes.theXAxis = -1.0F;
			highScore.SetActive (true);
			crash.Play ();
			mainAudio.SetActive (false);
			DeathBlack.SetActive (true);
			DeathText.SetActive (true);
			TheRocket.SetActive (false);
		} else {
			Debug.Log ("getriggered");
			health = health - amount;
			changeImage (health);
		}

	}

	public void changeImage(int health){
		if (health == 2) {
			image.sprite = sprite2;
		} else if (health == 1) {
			image.sprite = sprite1;
		} else if (health == 0) {
			image.sprite = sprite0;
		}
	}
}
