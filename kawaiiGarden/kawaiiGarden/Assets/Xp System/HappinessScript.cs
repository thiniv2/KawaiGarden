using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HappinessScript : MonoBehaviour {

    private int level;

    public int xP;

    private int xPToLevelUp;

    public Slider levelBar;

    public Text levelText;
    
	// Use this for initialization
	void Start () {

        level = 0;

        xP = 0;

        xPToLevelUp = 30;

        levelBar.value = xP;
        levelBar.maxValue = xPToLevelUp;

        levelText.text = "Happiness";
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.H))
        {
            xP += 2;
            levelBar.value = xP;
        }

        //if(levelBar.value >= levelBar.maxValue)
        //{
        //    Inceaselevel();
        //}

	}
     
    void Inceaselevel()
    {
        xP = 0;
        levelBar.value = xP;

        if(level == 1)
        {
            xPToLevelUp += 30 / 2;
            levelBar.maxValue = xPToLevelUp;
        }

        else if (level == 2)
        {
            xPToLevelUp += 40 / 2;
            levelBar.maxValue = xPToLevelUp;
        }

       else if (level == 3)
        {
            xPToLevelUp += 50 / 2;
            levelBar.maxValue = xPToLevelUp;
        }

        level++;
        levelText.text = "Happiness" + level.ToString();
    }
}
