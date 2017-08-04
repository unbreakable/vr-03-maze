using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	public static int score;

	Text text;

	// Use this for initialization
	void Awake () {
		// Set up the reference
		text = GetComponent <Text> ();

		score = 0;
	}

	void Update () {
		text.text = "Score: " + score;
	}
}
