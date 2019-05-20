using UnityEngine;

public class Instance : MonoBehaviour
{

    public GameObject HoitoGroup;
    public GameObject GamesGroup;

    public HoitoButton hoito;
    public loadScene Games;


   public void CloseAll()
    {
        Games.anim.SetBool("Close", true);

        Games.Invoke("CloseGames", 0.7f);

        hoito.anim.SetBool("CloseHoito", true);

        hoito.Invoke("CloseHoito", 0.7f);
    }

}
