using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnScript : MonoBehaviour {

    public Transform[] FallingObjects;

    public bool Easy;

    public bool Medium;

    public bool Hard;

    public float SpawningTreshold;

    public Transform SpawnpointL;

    public Transform SpawnpointR;

    public float SpawnTime;

    public float SpawnTimeEasy = 3f;
    public float SpawnTimeMedium = 2f;
    public float SpawnTimeHard = 1f;

    private int SpawnTresholdEasy = 80;
    private int SpawnTresholdMedium = 40;
    private int SpawnTresholdHard = 20;

    // checkmarks
    public GameObject EasyMark;
    public GameObject MediumMark;
    public GameObject HardMark;


    public bool keepSpawning = true;

    IEnumerator SpawnAtIntervals(float secondsBetweenSpawns)
    {
        // Repeat until keepSpawning == false or this GameObject is disabled/destroyed.
        while (keepSpawning)
        {
            // Put this coroutine to sleep until the next spawn time.
            yield return new WaitForSeconds(secondsBetweenSpawns);

            // Now it's time to spawn again.
            Spawn();
        }
    }


    public void Start () {

        Vector3 Randomspawn = new Vector3(Random.Range(SpawnpointL.position.x, SpawnpointR.position.x), SpawnpointL.position.y, SpawnpointL.position.z);

        if (Easy)
        {
            SpawnTime = SpawnTimeEasy;

            SpawningTreshold = SpawnTresholdEasy;

            StopAllCoroutines();
            StartCoroutine(SpawnAtIntervals(SpawnTime));
        }

        if (Medium)
        {
            SpawnTime = SpawnTimeMedium;

            SpawningTreshold = SpawnTresholdMedium;

            StopAllCoroutines();
            StartCoroutine(SpawnAtIntervals(SpawnTime));
        }

        else if (Hard)
        {
            SpawnTime = SpawnTimeHard;

            SpawningTreshold = SpawnTresholdHard;

            StopAllCoroutines();
            StartCoroutine(SpawnAtIntervals(SpawnTime));

        }


        
        //  InvokeRepeating("Spawn", 2, spawnTime);

    }

    void Update()
    {
        

        if (Easy)
        {
            EasyMark.SetActive(true);
            MediumMark.SetActive(false);
            HardMark.SetActive(false);
        }

       else if (Medium)
        {
            EasyMark.SetActive(false);
            MediumMark.SetActive(true);
            HardMark.SetActive(false);
        }

        else if (Hard)
        {
            EasyMark.SetActive(false);
            MediumMark.SetActive(false);
            HardMark.SetActive(true);
        }
    }

    public void SetEasy()
    {
        SpawnTime = SpawnTimeEasy;
        SpawningTreshold = SpawnTresholdEasy;

        Easy = true;
        Medium = false;
        Hard = false;

        StopAllCoroutines();
        StartCoroutine(SpawnAtIntervals(SpawnTime));
    }

   public void SetMedium()
    {
        SpawnTime = SpawnTimeMedium;
        SpawningTreshold = SpawnTresholdMedium;

        Easy = false;
        Medium = true;
        Hard = false;

        StopAllCoroutines();
        StartCoroutine(SpawnAtIntervals(SpawnTime));

    }

    public void SetHard()
    {
        SpawnTime = SpawnTimeHard;
        SpawningTreshold = SpawnTresholdHard;

        Easy = false;
        Medium = false;
        Hard = true;

        StopAllCoroutines();
        StartCoroutine(SpawnAtIntervals(SpawnTime));
    }

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
