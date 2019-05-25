using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour {

    private int score;

    public Text textl;

    public Text HighscoreText;

    public GameObject Panel;

    public GameObject player;

    public GameObject StartPanel;


    // Use this for initialization
    void Start()
    {
        score = 0;

        StartPanel.SetActive(true);

    }

    public void AddScore(int Addpoints)
    {
        score += Addpoints;
        UpdateScore();
    }

    void UpdateScore()
    {
        textl.text = "SCORE : " + score;
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Update()
    {
        if(Panel.activeInHierarchy)
        {
            Time.timeScale = 0f;
        }

        HighscoreText.text = "Highscore : " + PlayerPrefs.GetFloat("HighscoreFruity").ToString();

        // highscore system
        if (PlayerPrefs.GetFloat("HighscoreFruity") < score)
        {
            PlayerPrefs.SetFloat("HighscoreFruity", score);

        }
    }
}
