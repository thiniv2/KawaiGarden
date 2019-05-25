using UnityEngine;
using UnityEngine.UI;

public class HoitoButton : MonoBehaviour
{
    public GameObject toggleHoito;
    public GameObject toggleGames;

    public XpScript xpScript;
    public HappinessScript happinessScript;
    public loadScene LoadScene;

    public ParticleSystem particleSystemB;

    public Button MusicButton;

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

    public void Music()
    {
        MusicButton.interactable = false;

        Invoke("GiveHappiness", 2f);

    }

    public void GiveHappiness()
    {
        happinessScript.xP += 30;
        happinessScript.levelBar.value = happinessScript.xP;

        PlayerPrefs.SetFloat("Happiness", happinessScript.xP);

        particleSystemB.Play(true);

        MusicButton.interactable = true;
    }

}
