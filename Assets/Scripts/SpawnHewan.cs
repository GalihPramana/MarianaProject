using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHewan : MonoBehaviour
{
    [Header("Spawner Settings")]
    public GameObject[] seaCreatures;
    public Transform player;          
    public float spawnRadius = 30f;   
    public float spawnHeight = 10f;  
    public float spawnInterval = 3f;  
    public int maxCreatures = 20;     

    private int currentCount = 0;

    void Start()
    {
        InvokeRepeating(nameof(SpawnCreature), 1f, spawnInterval);
    }

    void SpawnCreature()
    {
        if (currentCount >= maxCreatures || seaCreatures.Length == 0) return;

        // prefab random
        GameObject prefab = seaCreatures[Random.Range(0, seaCreatures.Length)];

        // posisi spawn sekitar player
        Vector3 spawnPos = player.position + new Vector3(
            Random.Range(-spawnRadius, spawnRadius),
            Random.Range(-spawnHeight, spawnHeight),
            Random.Range(-spawnRadius, spawnRadius)
        );

        // Spawn hewan laut
        GameObject creature = Instantiate(prefab, spawnPos, Quaternion.identity);
        currentCount++;

        //  destroy 
        Destroy(creature, 30f);
        currentCount--;
    }
}
