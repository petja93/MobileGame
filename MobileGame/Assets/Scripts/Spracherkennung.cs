using System;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;

public class Spracherkennung : MonoBehaviour
{
	[SerializeField]
	public string[] m_Keywords;
	public KeywordRecognizer m_Recognizer;

	public AudioSource song1;
	public AudioSource song2;
	public AudioSource song3;
	public AudioSource song4;
	public AudioSource song5;

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
			song2.Stop ();
			song3.Stop ();
			song4.Stop ();
			song5.Stop ();
			song1.Play ();
		}else if(args.text == m_Keywords [1]) {
			song1.Stop ();
			song3.Stop ();
			song4.Stop ();
			song5.Stop ();
			song2.Play ();
		}else if(args.text == m_Keywords [2]) {
			song1.Stop ();
			song2.Stop ();
			song4.Stop ();
			song5.Stop ();
			song3.Play ();
		}else if(args.text == m_Keywords [3]) {
			song1.Stop ();
			song2.Stop ();
			song3.Stop ();
			song5.Stop ();
			song4.Play ();
		}else if(args.text == m_Keywords [4]) {
			song1.Stop ();
			song2.Stop ();
			song3.Stop ();
			song4.Stop ();
			song5.Play ();
		}
	}
}
