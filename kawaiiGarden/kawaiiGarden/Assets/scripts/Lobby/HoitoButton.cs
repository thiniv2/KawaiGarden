using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoitoButton : MonoBehaviour
{
    public GameObject toggleHoito;
    public GameObject toggleGames;

    public XpScript xpScript;
    public HappinessScript happinessScript;
    public loadScene LoadScene;

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

            Invoke("CloseHoito", 0.7f);
        }

        if (toggleGames.activeSelf)
        {
            LoadScene.anim.SetBool("Close", true);

            LoadScene.Invoke("CloseGames", 0.7f);
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
