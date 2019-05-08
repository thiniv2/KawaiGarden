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

    public void ToggleEasy()
    {
        SpawnScript.Easy = true;
        SpawnScript.Medium = false;
        SpawnScript.Hard = false;

        //SpawnScript.spawnTime = 1.25f;
        //SpawnScript.SpawningTreshold = 80f;
    }

    public void ToggleMedium()
    {
        SpawnScript.Easy = false;
        SpawnScript.Medium = true;
        SpawnScript.Hard = false;

        //SpawnScript.spawnTime = 0.75f;
        //SpawnScript.SpawningTreshold = 50f;
    }

    public void ToggleHard()
    {
        SpawnScript.Easy = false;
        SpawnScript.Medium = false;
        SpawnScript.Hard = true;

        //SpawnScript.spawnTime = 0.45f;
        //SpawnScript.SpawningTreshold = 25f;
    }

}
