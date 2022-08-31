using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    
    public GameObject[] objects;
    public float spawnTime;
    private Vector3 spawnPosition;
    
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }
   
    void Spawn()
    {
        spawnTime = Random.Range(1,6);
        spawnPosition.x = Random.Range(-19, 10);
        spawnPosition.y = Random.Range(6, 7);
        spawnPosition.z = Random.Range(0, 0);
        Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity); 
    }
}
