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

    public int xpGained;

    public bool GiveXp = false;

    void Update()
    {
        HighScore.text = "HighScore : " + (int)PlayerPrefs.GetFloat("HighScore");

        // players score
        ScoreText.text = PlayerPos.position.x.ToString("0");

        if (!Player.activeInHierarchy)
        {
            if(GiveXp == false)
            {
                GiveXpToPlayer();
                GiveXp = true;
            }


            // move score text to end game screen
            ScoreText.transform.position = new Vector2(550, 1050);

            ScoreText.text = PlayerPos.position.x.ToString("0");

            // highscore system
            if(PlayerPrefs.GetFloat("HighScore") < PlayerPos.position.x)
            {
                PlayerPrefs.SetFloat("HighScore", PlayerPos.position.x);

                NewHighScoreText.SetActive(true);
            }

        }
    }
    public int  GiveXpToPlayer()
    {
        xpGained = PlayerPrefs.GetInt("XP") + 4;

        PlayerPrefs.SetInt("XP", xpGained);

        return PlayerPrefs.GetInt("XP");
    }

}