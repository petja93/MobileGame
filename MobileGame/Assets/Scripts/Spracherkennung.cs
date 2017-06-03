using System;
using System.Text;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class Spracherkennung : MonoBehaviour
{
	[SerializeField]
	public string[] m_Keywords;

	public KeywordRecognizer m_Recognizer;

	public GameObject cube;

	public PlayerControl playercontrol;

	void Start()
	{
		m_Recognizer = new KeywordRecognizer(m_Keywords);
		m_Recognizer.OnPhraseRecognized += OnPhraseRecognized;
		m_Recognizer.Start();
	}

	private void OnPhraseRecognized(PhraseRecognizedEventArgs args)
	{
		StringBuilder builder = new StringBuilder();
		builder.AppendFormat("{0} ({1}){2}", args.text, args.confidence, Environment.NewLine);
		builder.AppendFormat("\tTimestamp: {0}{1}", args.phraseStartTime, Environment.NewLine);
		builder.AppendFormat("\tDuration: {0} seconds{1}", args.phraseDuration.TotalSeconds, Environment.NewLine);
		Debug.Log(builder.ToString());

		if (args.text == m_Keywords [0]) {
			//Instantiate (cube, new Vector3 (0, 0, 1), Quaternion.identity); //sorgt dafür das ein Cube erstellt wird
			playercontrol.moveDirection.y += playercontrol.jumpspeed;
		} else {
			playercontrol.moveDirection.y += playercontrol.jumpspeed;
		}
	}
}
