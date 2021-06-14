using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour

{

    public GameObject car; 

    public float nextTimeToSpawn = 0f;
    public float spawnDelay = .99f;

    public Transform[] spawnerPoints;


    void Update()
    {
        if (nextTimeToSpawn <= Time.time)
        {
            spawnCar();
            nextTimeToSpawn = Time.time + spawnDelay; 
        }
    }
   void spawnCar()
    {
        int index = Random.Range(0, spawnerPoints.Length);
        Transform randomPoint = spawnerPoints[index]; 

        Instantiate(car, randomPoint.position, randomPoint.rotation);
    }
}
