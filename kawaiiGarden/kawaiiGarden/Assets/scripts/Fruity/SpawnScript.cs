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

    public float SpawningTreshold;

    public Transform SpawnpointL;

    public Transform SpawnpointR;

    public int SpawnTresholdEasy = 80;
    public int SpawnTresholdMedium = 50;
    public int SpawnTresholdHard = 25;

    // Use this for initialization
    public void Start () {

        Vector3 Randomspawn = new Vector3(Random.Range(SpawnpointL.position.x, SpawnpointR.position.x), SpawnpointL.position.y, SpawnpointL.position.z);



        //Instantiate(RB, SpawnPoint.position, transform.rotation);

        //Instantiate(Fruit, Randomspawn, Quaternion.identity);

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

        if (Hard)
        {
            spawnTime = 0.45f;
            SpawningTreshold = SpawnTresholdHard;
        }

        InvokeRepeating("Spawn", spawnTime, spawnTime);


    }

    void Update()
    {
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

        if (Hard)
        {
            spawnTime = 0.45f;
            SpawningTreshold = SpawnTresholdHard;
        }

    }

    public void Spawn()
    {
        Vector3 Randomspawn = new Vector3(Random.Range(SpawnpointL.position.x, SpawnpointR.position.x), SpawnpointL.position.y, SpawnpointL.position.z);

        int SpawnPointIndex = Random.Range(0, FallingObjects.Length);
        if (Random.Range(0f, 100f) < SpawningTreshold)
            SpawnPointIndex = 0; // Goodnes
        else
            SpawnPointIndex = 1; // Badness

        Instantiate(FallingObjects[SpawnPointIndex], Randomspawn, Quaternion.identity);
    }

    

}
