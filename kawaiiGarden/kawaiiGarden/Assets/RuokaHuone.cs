using UnityEngine;

public class RuokaHuone : MonoBehaviour
{
    public Animator anim;

    public GameObject RuokaHuoneUI;

    public GameObject TealCakeobj;

    public HoitoButton hoitoScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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

   public void Close()
    {
        RuokaHuoneUI.SetActive(false);
    }

}
