﻿using UnityEngine;

public class Instance : MonoBehaviour
{

    public GameObject HoitoGroup;
    public GameObject GamesGroup;

    public HoitoButton hoito;
    public loadScene Games;


    void Start()
    {
        //PlayerPrefs.DeleteAll();
    }

   public void CloseAll()
    {
        if(GamesGroup.activeInHierarchy)
        {
            Games.anim.SetBool("Close", true);

            Games.Invoke("CloseGames", 0.7f);
        }
        
        if(HoitoGroup.activeInHierarchy)
        {
            hoito.anim.SetBool("CloseHoito", true);

            hoito.Invoke("CloseHoito", 0.7f);
        }
        
    }

}
