using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KasviHuone : MonoBehaviour
{

    public GameObject text;

    public GameObject Teal;
    public GameObject Purple;
    public GameObject Green;

    string SelectedKasvi;

     void Start()
    {
        SelectedKasvi = PlayerPrefs.GetString("KasviValittu");

       if(SelectedKasvi == ("Teal"))
        {
            Teal.SetActive(true);
            Purple.SetActive(false);
            Green.SetActive(false);

            text.transform.position = new Vector3(-1.60f, .5f, 1);
        }

       else if (SelectedKasvi == ("Purple"))
        {
            Teal.SetActive(false);
            Purple.SetActive(true);
            Green.SetActive(false);

            text.transform.position = new Vector3(-0.1f, .5f, 1);
        }

       else if (SelectedKasvi == ("Green"))
        {
            Teal.SetActive(false);
            Purple.SetActive(false);
            Green.SetActive(true);

            text.transform.position = new Vector3(1.50f, .5f, 1);
        }
    }

    public void ActivateTeal()
    {

        // activates teal and deactivates other selections
        Teal.SetActive(true);
        Purple.SetActive(false);
        Green.SetActive(false);

        // move ''selected'' -text under the image
        text.transform.position = new Vector3 (-1.60f, .5f, 1);

        PlayerPrefs.SetString("KasviValittu", ("Teal"));
    }

    public void ActivatePurple()
    {
        // activates purple and deactivates other selections
        Teal.SetActive(false);
        Purple.SetActive(true);
        Green.SetActive(false);

        // move ''selected'' -text under the image
        text.transform.position = new Vector3 (-0.1f, .5f, 1);

        PlayerPrefs.SetString("KasviValittu", ("Purple"));
    }

    public void ActivateGreen()
    {
        // activates green and deactivates other selections
        Teal.SetActive(false);
        Purple.SetActive(false);
        Green.SetActive(true);

        // move ''selected'' -text under the image
        text.transform.position = new Vector3 (1.50f, .5f, 1);

        PlayerPrefs.SetString("KasviValittu", ("Green"));

    }

    void deletePrefs()
    {
        PlayerPrefs.DeleteAll();
    }
}
