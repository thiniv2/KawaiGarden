using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject Player;

    public GameObject NewHighScoreText;

    public Transform PlayerPos;

    public Text ScoreText;

    public Text HighScore;

    public XpScript xpScript;

    void Awake()
    {
        
    }

    void Update()
    {
        HighScore.text = "HighScore : " + (int)PlayerPrefs.GetFloat("HighScore");

        ScoreText.text = PlayerPos.position.x.ToString("0");

        if (!Player.activeInHierarchy)
        {
            ScoreText.transform.position = new Vector2(550, 1050);

            ScoreText.text = PlayerPos.position.x.ToString("0");

            if(PlayerPrefs.GetFloat("HighScore") < PlayerPos.position.x)
            {
                PlayerPrefs.SetFloat("HighScore", PlayerPos.position.x);

                NewHighScoreText.SetActive(true);
            }

            //xpScript.xP += 5;

            //xpScript.levelBar.value = xpScript.xP;

            //PlayerPrefs.SetInt("xP", xpScript.xP);

        }
    }
}