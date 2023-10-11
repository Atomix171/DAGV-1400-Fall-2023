using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawnManager : MonoBehaviour
{
    public GameObject[] itemPrefabs; // Array to store Items
    private float spawnRangeX = 25f;
    private float spawnPosZ = 20f;
    
    private float startDelay = 15f;
    private float spawnInterval = 1.5f;
    
    void Start()
    {
        InvokeRepeating("SpawnRandomItem", startDelay, spawnInterval);
    }
    
    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRandomItem()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int itemIndex = Random.Range(0,itemPrefabs.Length); // Picks a random item from array
        Instantiate(itemPrefabs[itemIndex], spawnPos, itemPrefabs[itemIndex].transform.rotation); // Spawns in a item from the index
    }
}
