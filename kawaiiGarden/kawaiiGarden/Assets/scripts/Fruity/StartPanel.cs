using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPanel : MonoBehaviour
{
    public SpawnScript SpawnScript;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClosePanel()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
        
    }

}
