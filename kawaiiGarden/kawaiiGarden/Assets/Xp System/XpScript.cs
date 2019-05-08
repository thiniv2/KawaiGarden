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


    private void Awake()
    {
        // PlayerPrefs.DeleteAll();

       
    }

    void Start () {

        xPToLevelUp = 30;

         xP = 0;

        levelBar.value = xP;

        levelBar.maxValue = xPToLevelUp;

    }

	void Update () {

        level = PlayerPrefs.GetInt("Level");

        levelText.text = "Level: " + PlayerPrefs.GetInt("Level");

         levelBar.value = xP;

        if (Input.GetKeyDown(KeyCode.T))
        {
            xP += 2;
            levelBar.value = xP;

            PlayerPrefs.SetInt("XP", xP);
        }

        if(levelBar.value >= levelBar.maxValue)
        {
            Inceaselevel();

            PlayerPrefs.SetInt("Level", level);
        }
	}

    void Inceaselevel()
    {
        xP = 0;
        levelBar.value = xP;

        ParticleSystem.Play(true);

        level++;
        levelText.text = "Level: " + level.ToString();

        if (level < 1)
        {
            xPToLevelUp += 30 / 2;
            levelBar.maxValue = xPToLevelUp;
        }

        else if (level < 2)
        {
            xPToLevelUp += 40 / 2;
            levelBar.maxValue = xPToLevelUp;
        }

       else if (level < 3)
        {
            xPToLevelUp += 50 / 2;
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


        
    }
}
