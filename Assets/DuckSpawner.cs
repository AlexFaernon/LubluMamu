using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckSpawner : MonoBehaviour
{
    [SerializeField] private float firstSpawnDelay;
    [SerializeField] private float spawnInterval;
    [SerializeField] private GameObject duck;

    private void Awake()
    {
        StartCoroutine(WaitToSpawn());
    }

    private IEnumerator WaitToSpawn()
    {
        yield return new WaitForSeconds(firstSpawnDelay);

        StartCoroutine(SpawnDucks());
    }
    
    private IEnumerator SpawnDucks()
    {
        Instantiate(duck, transform.position, Quaternion.identity);
        StartCoroutine(SpawnDucks());
        
        yield return new WaitForSeconds(spawnInterval);
    }
}
