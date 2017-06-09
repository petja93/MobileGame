using System;
using System.Text;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class Spracherkennung1 : MonoBehaviour
{
	[SerializeField]
	public string[] keywords = new string[]{"springen"};
	public ConfidenceLevel confidence = ConfidenceLevel.Medium;
	public float speed = 8f;

	public PlayerControl playercontrol;

	public Texture results;
	public GameObject target;

	protected PhraseRecognizer recognizer;
	protected string word = "hallo";

	//public float speed = 8.0F; 
	public float jumpspeed = 20.5F;  
	public float gravity = 20.0F; 
	public Vector3 moveDirection = Vector3.zero;

	//public GameObject cube;
	//public PlayerControl playercontrol;

	void Start()
	{
		if (keywords != null) {
			recognizer = new KeywordRecognizer (keywords, confidence);
			recognizer.OnPhraseRecognized += OnPhraseRecognized;
			recognizer.Start ();
		}
	}

	private void OnApplicationQuit(){
		if (recognizer != null && recognizer.IsRunning) {
			recognizer.OnPhraseRecognized -= OnPhraseRecognized;
			recognizer.Stop ();
		}
	}

	private void OnPhraseRecognized(PhraseRecognizedEventArgs args)
	{
		word = args.text;
		//results.text = "You said: <b>" + word + "</b>";
	}

	private void Update(){

		CharacterController controller = GetComponent<CharacterController>(); //erstellt Controller-Objekt
		if(controller.isGrounded){ //wenn conrtoller-Objekt "Boden" berührt, dann
			moveDirection = new Vector3 (0, 0, Input.GetAxis ("Horizontal") + 3); //geh 3 Schritte nach rechts
			moveDirection = transform.TransformDirection(moveDirection); 
			moveDirection *= speed;

			if(word == "springen"){
				moveDirection.y += jumpspeed;
			}
			//Wenn man den else-Zweig weglässt, kann man nicht mehrmals "springen"
		}else{
			if (word == "springen") {
				moveDirection.y += jumpspeed;
			}
		}

		moveDirection.y -= gravity * Time.deltaTime;

		controller.Move(moveDirection * Time.deltaTime);


		/*var x = target.transform.position.x;
		var y = target.transform.position.y;

		switch (word) {
		case "springen":
			y += speed;
			break;
		}

		target.transform.position = new Vector3 (x, y, 35);*/
	}
}

