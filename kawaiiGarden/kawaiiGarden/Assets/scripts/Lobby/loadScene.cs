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

    public Animator anim;
    public Animator animHoito;

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

            Invoke("CloseGames", 0.4f);
        }

        if (toggleHoito.activeSelf)
		{
			toggleHoito.SetActive(false);
		}
    }

    public void CloseGames()
    {
        toggleGames.SetActive(false);
    }




}
