using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HappinessScript : MonoBehaviour {

    public int xP;

    private int xPToLevelUp;

    public Slider levelBar;

    public Text levelText;
    
	// Use this for initialization
	void Start () {

       // PlayerPrefs.DeleteAll();

        xPToLevelUp = 30;

        
        levelBar.maxValue = xPToLevelUp;

        levelText.text = "Happiness";
	}
	
	// Update is called once per frame
	void Update () {

        xP = PlayerPrefs.GetInt("Happiness");

        levelBar.value = xP;

        if (Input.GetKeyDown(KeyCode.H))
        {
            xP += 2;
            levelBar.value = xP;
        }

	}
     
}
