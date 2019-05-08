using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

    private int score;

    public Text textl;

	// Use this for initialization
	void Start () {
        score = 0;
	}

    public void AddScore(int Addpoins)
    {
        score += Addpoins;
        UpdateScore();
    }

    void UpdateScore()
    {
        textl.text = "score: " + score;
    }
}
