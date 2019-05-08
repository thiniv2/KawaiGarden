using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XpScript : MonoBehaviour {

    private int level;

    public int xP;

    private int xPToLevelUp;

    public Slider levelBar;

    public Text levelText;

    public ParticleSystem ParticleSystem;

    void Start () {

        //PlayerPrefs.DeleteAll();

        xPToLevelUp = 30;

        // dont get levels when xp is 0
       // xP = 0;

        levelBar.value = xP;

        levelBar.maxValue = xPToLevelUp;

    }

	void Update () {

       // xP = PlayerPrefs.GetInt("XP");

        level = PlayerPrefs.GetInt("Level");

        levelText.text = "Level: " + PlayerPrefs.GetInt("Level");

        xP = PlayerPrefs.GetInt("XP");

        levelBar.value = xP;

        if (Input.GetKeyDown(KeyCode.T))
        {
            xP += 2;
            levelBar.value = xP;

            PlayerPrefs.SetInt("XP", xP);
        }

        if(levelBar.value >= levelBar.maxValue)
        {
            Increaselevel();

            PlayerPrefs.SetInt("Level", level);
        }
	}

    void Increaselevel()
    {
        xP = 0;

        PlayerPrefs.SetInt("XP", xP);
        
        levelBar.value = xP;

        ParticleSystem.Play(true);

        if (level < 1)
        {
            xPToLevelUp += 20 * 2 / 2;
            levelBar.maxValue = xPToLevelUp;
        }

        else if (level < 2)
        {
            xPToLevelUp += 30 * 3 / 2;
            levelBar.maxValue = xPToLevelUp;
        }

       else if (level < 3)
        {
            xPToLevelUp += 40 * 4 / 2;
            levelBar.maxValue = xPToLevelUp;
        }

        //else if(level < 20)
        //{
        //    xPToLevelUp += 70 * 7 / 2;
        //    levelBar.maxValue = xPToLevelUp;
        //}
        //else if (level < 30)
        //{
        //    xPToLevelUp += 110 * 8 / 2;
        //    levelBar.maxValue = xPToLevelUp;
        //}

        //else if (level < 40)
        //{
        //    xPToLevelUp += 200 * 9 / 2;
        //    levelBar.maxValue = xPToLevelUp;
        //}
        //else if (level < 50)
        //{
        //    xPToLevelUp += 500 * 11 / 2;
        //    levelBar.maxValue = xPToLevelUp;
        //}
        //else if (level < 60)
        //{
        //    xPToLevelUp += 1000 * 12 / 2;
        //    levelBar.maxValue = xPToLevelUp;
        //}
        //else if (level < 70)
        //{
        //    xPToLevelUp += 5000 * 12 / 2;
        //    levelBar.maxValue = xPToLevelUp;
        //}
        //else if (level < 80)
        //{
        //    xPToLevelUp += 7500 * 14 / 2;
        //    levelBar.maxValue = xPToLevelUp;
        //}
        //else if (level < 90)
        //{
        //    xPToLevelUp += 10000 * 15 / 2;
        //    levelBar.maxValue = xPToLevelUp;
        //}
        //else if (level < 100)
        //{
        //    xPToLevelUp += 5000 * 17 / 2;
        //    levelBar.maxValue = xPToLevelUp;
        //}

        level++;
        levelText.text = "Level: " + level.ToString();

    }
}
