using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
	public GameObject toggleGames;
	public GameObject toggleHoito;
    public GameObject Settings;
    public GameObject KasviHuone;
    public GameObject RuokaHuone;

    public HoitoButton hoitoButton;

    public Animator anim;
    
    public void LoadLobby()
	{
        Time.timeScale = 1f;
		SceneManager.LoadScene(0);
	}

	public void LoadFlappy()
    {
        SceneManager.LoadScene(1);
    }

	public void LoadSettings()
	{
        Settings.SetActive(true);
	}

	public void LoadKasviHuone()
	{
        KasviHuone.SetActive(true);
	}
 
    public void LoadRengasPeli()
    {
        SceneManager.LoadScene("rengasPeli");
    }

    public void LoadFruity()
    {
        SceneManager.LoadScene("fruity");
    }

    public void LoadBallGame()
    {
        SceneManager.LoadScene("PalloPeli");
    }

    public void LoadThis()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void CloseKasviHuone()
    {
        KasviHuone.SetActive(false);
    }

    public void CloseSettings()
    {
        Settings.SetActive(false);
    }

	public void togglePelit()
	{
        if (!toggleGames.activeInHierarchy)
        {
            toggleGames.SetActive(true);
        }

        else
        {
            anim.SetBool("Close", true);

            Invoke("CloseGames", 0.7f);
        }

        if (toggleHoito.activeSelf)
		{
            hoitoButton.anim.SetBool("CloseHoito", true);

            hoitoButton.Invoke("CloseHoito", 0.7f);
		}
    }

    public void OpenRuokaHuone()
    {
        RuokaHuone.SetActive(true);
    }

    public void CloseGames()
    {
        toggleGames.SetActive(false);
    }

    public void DeletePrefs()
    {
        PlayerPrefs.DeleteAll();
    }

}
