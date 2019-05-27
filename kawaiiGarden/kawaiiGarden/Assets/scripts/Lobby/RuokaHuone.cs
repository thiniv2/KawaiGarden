using UnityEngine;

public class RuokaHuone : MonoBehaviour
{
    public Animator anim;

    public GameObject RuokaHuoneUI;

    public GameObject TealCakeobj;
    public GameObject GreenCakeobj;
    public GameObject BrownCakeobj;

    public HoitoButton hoitoScript;

    public void TealCake()
    {
        Invoke("TealCakeEat", 0.6f);

        TealCakeobj.SetActive(false);
    }

    public void TealCakeEat()
    {
        TealCakeobj.SetActive(true);
        anim.SetBool("TealCake", true);

        hoitoScript.GiveHappiness();
    }

    public void GreenCake()
    {
        Invoke("GreenCakeEat", 0.6f);

        TealCakeobj.SetActive(false);
    }

    public void GreenCakeEat()
    {
        TealCakeobj.SetActive(true);
        anim.SetBool("GreenCake", true);

        hoitoScript.GiveHappiness();
    }

    public void BrownCake()
    {
        Invoke("BrownCakeEat", 0.6f);

        TealCakeobj.SetActive(false);
    }

    public void BrownCakeEat()
    {
        TealCakeobj.SetActive(true);
        anim.SetBool("BrownCake", true);

        hoitoScript.GiveHappiness();
    }

    public void Close()
    {
        RuokaHuoneUI.SetActive(false);
    }

   

}
