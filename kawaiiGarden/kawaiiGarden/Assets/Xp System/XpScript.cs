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

        //PlayerPrefs.DeleteAll();

        xPToLevelUp = 30;

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
        PlayerPrefs.SetInt("XP", 0);
        
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
            xPToLevelUp += 4000 * 4 / 2;
            levelBar.maxValue = xPToLevelUp;
        }

        level++;
        levelText.text = "Level: " + level.ToString();

    }
}
