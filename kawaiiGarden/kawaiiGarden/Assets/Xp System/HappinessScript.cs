using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HappinessScript : MonoBehaviour {

    public float xP;

    private int xPToLevelUp;

    public Slider levelBar;

    public Text levelText;

    public float MinusHappiness;

	// Use this for initialization
	void Start () {

       PlayerPrefs.DeleteAll();

        xPToLevelUp = 300;

        levelBar.maxValue = xPToLevelUp;

        levelText.text = "Happiness";
	}
	
	// Update is called once per frame
	void Update () {

        LoseHappiness();

        xP = PlayerPrefs.GetFloat("Happiness");

        levelBar.value = xP;

        // for debugging
        if (Input.GetKeyDown(KeyCode.H))
        {
            xP += 2;
            levelBar.value = xP;
        }

        if (xP < 0)
        {
            xP = 0;
        }

    }

    void LoseHappiness()
    {

        float value1 = PlayerPrefs.GetFloat("Happiness");
        float value2 = value1 - MinusHappiness * Time.deltaTime;

        PlayerPrefs.SetFloat("Happiness", value2);
    }
     
}
