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

    void Awake () {

        xPToLevelUp = 20;

        levelBar.value = xP;

        levelBar.maxValue = xPToLevelUp;

    }

	void Update () {

        level = PlayerPrefs.GetInt("Level");

        levelText.text = "Level: " + PlayerPrefs.GetInt("Level");

        xP = PlayerPrefs.GetInt("XP");

        levelBar.value = xP;

        if (Input.GetKeyDown(KeyCode.T))
        {
            xP += 10;
            levelBar.value = xP;

            PlayerPrefs.SetInt("XP", xP);
        }

        if(levelBar.value >= levelBar.maxValue)
        {
            Increaselevel();

            PlayerPrefs.SetInt("Level", level);
        }

        if(level == 3)
        {
            levelBar.value = 0;
        }
	}

    void Increaselevel()
    {
        PlayerPrefs.SetInt("XP", 0);


         if (level < 1)
        {
            xPToLevelUp += 20 * 2 / 2;
            levelBar.maxValue = xPToLevelUp;

            level++;

            ParticleSystem.Play(true);

            levelBar.value = xP;
        }

        else if (level <= 2)
        {
            xPToLevelUp += 20 * 2 / 2;
            levelBar.maxValue = xPToLevelUp;

            level++;

            ParticleSystem.Play(true);

            levelBar.value = xP;
        }

        else if (level < 3)
        {
            xPToLevelUp += 20 * 2 / 2;
            levelBar.maxValue = xPToLevelUp;

            level++;

            ParticleSystem.Play(true);

            levelBar.value = xP;
        }

        levelText.text = "Level: " + level.ToString();

    }
}
