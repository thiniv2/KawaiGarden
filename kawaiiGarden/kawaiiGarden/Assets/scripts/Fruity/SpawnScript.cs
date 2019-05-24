using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnScript : MonoBehaviour {

    public Transform[] FallingObjects;

    public float spawnTime;

    public bool Easy;

    public bool Medium;

    public bool Hard;

    public bool Insane;

    public float SpawningTreshold;

    public Transform SpawnpointL;

    public Transform SpawnpointR;

    private int SpawnTresholdEasy = 80;
    private int SpawnTresholdMedium = 50;
    private int SpawnTresholdHard = 30;

    // Use this for initialization

    //void Awake()
    //{
    //    Hard = false;
    //}

    public void Start () {

        Vector3 Randomspawn = new Vector3(Random.Range(SpawnpointL.position.x, SpawnpointR.position.x), SpawnpointL.position.y, SpawnpointL.position.z);

        if (Easy)
        {
            spawnTime = 1.25f;
            SpawningTreshold = SpawnTresholdEasy;
        }

        if (Medium)
        {
            spawnTime = 0.75f;
            SpawningTreshold = SpawnTresholdMedium;
        }

      else if (Hard)
        {
            spawnTime = 0.55f;
           // SpawningTreshold = SpawnTresholdHard;
            SpawningTreshold = 30;
        }

        //if (Insane)
        //{
        //    spawnTime = 0.35f;
        //    SpawningTreshold = 25;
        //}

        InvokeRepeating("Spawn", spawnTime, spawnTime);


    }

    

    public void SetEasy()
    {
        spawnTime = 1.25f;
        SpawningTreshold = SpawnTresholdEasy;

        Easy = true;
        Medium = false;
        Hard = false;
    }

   public void SetMedium()
    {
        spawnTime = 0.75f;
        SpawningTreshold = SpawnTresholdMedium;

        Easy = false;
        Medium = true;
        Hard = false;
    }

    public void SetHard()
    {
        spawnTime = 0.45f;
        SpawningTreshold = SpawnTresholdHard;

        Easy = false;
        Medium = false;
        Hard = true;
    }

    //public void SetInsane()
    //{
    //    spawnTime = 0.25f;
    //    SpawningTreshold = 20;

    //    Easy = false;
    //    Medium = false;
    //    Hard = true;
    //}

    public void Spawn()
    {
        Vector3 Randomspawn = new Vector3(Random.Range(SpawnpointL.position.x, SpawnpointR.position.x), SpawnpointL.position.y, SpawnpointL.position.z);

        int SpawnPointIndex = Random.Range(0, FallingObjects.Length);

        if (Random.Range(0f, 100f) < SpawningTreshold)
            SpawnPointIndex = 0; // Goodnes

            // these are the other fruits

        //else if (Random.Range(0f, 100f) < SpawningTreshold)
        //    SpawnPointIndex = 2; // Goodnes

        //else if (Random.Range(0f, 100f) < SpawningTreshold)
        //    SpawnPointIndex = 3; // Goodnes

        //else if (Random.Range(0f, 100f) < SpawningTreshold)
        //    SpawnPointIndex = 4; // Goodnes

        else
            SpawnPointIndex = 1; // Badness


        Instantiate(FallingObjects[SpawnPointIndex], Randomspawn, Quaternion.identity);
    }

    

}
