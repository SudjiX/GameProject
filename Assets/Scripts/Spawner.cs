using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float timeBetweenSpawns;
    float nextSpawnTime;

    public GameObject Enemy;

    public Transform[] SpawnPoints;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            nextSpawnTime = Time.time + timeBetweenSpawns;
            Transform randomSpawnPoints = SpawnPoints[Random.Range(0, SpawnPoints.Length)]; 
            Instantiate(Enemy, randomSpawnPoints.position, Quaternion.identity);
        }
        
    }
}
