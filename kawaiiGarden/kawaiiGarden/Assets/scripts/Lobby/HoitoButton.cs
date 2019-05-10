﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoitoButton : MonoBehaviour
{
    public GameObject toggleHoito;
    public GameObject toggleGames;

    public XpScript xpScript;
    public HappinessScript happinessScript;

    public Animator anim;

    public void togglehoito()
    {
        if (!toggleHoito.activeInHierarchy)
        {
            toggleHoito.SetActive(true);
        }

        else
        {
            anim.SetBool("CloseHoito", true);

            Invoke("CloseHoito", 0.4f);
        }

        if (toggleGames.activeSelf)
        {
            toggleGames.SetActive(false);
        }

    }

    public void CloseHoito()
    {
        toggleHoito.SetActive(false);
    }

    public void GiveXP()
    {
        xpScript.xP += 2;
        xpScript.levelBar.value = xpScript.xP;

        PlayerPrefs.SetInt("XP", xpScript.xP);
    }

    public void GiveHappiness()
    {
        happinessScript.xP += 10;
        happinessScript.levelBar.value = happinessScript.xP;

        PlayerPrefs.SetFloat("Happiness", happinessScript.xP);
    }

}
