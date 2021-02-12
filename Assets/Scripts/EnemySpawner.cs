using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float xPositionLimit;
    public float SpawnRate;
    void Start()
    {
        //SpawnSpike();
        StartSpawning();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnSpike()
    {
        float randomX = Random.Range(-xPositionLimit, xPositionLimit);
        Vector2 spawnPosition = new Vector2(randomX, transform.position.y);

        Instantiate(enemy,spawnPosition, Quaternion.identity); 
    }
      public void StartSpawning()
    {
        InvokeRepeating("SpawnSpike", 1f, SpawnRate);
    }
     public void StopSpawning()
    {
        CancelInvoke("SpawnSpike");
    }
}
