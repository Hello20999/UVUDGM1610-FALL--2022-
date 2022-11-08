using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefab;
    private float spawnRangeX = 34f;
    private float spawnRangeZ = 30.6f;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;
    // Update is called once per frame
    private void Start()
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }
    /*SpawnRandomUFO()
     * calls upon the function within other functions
     */
    void SpawnRandomUFO()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
        int ufoIndex = Random.Range(0, ufoPrefab.Length);
        Instantiate(ufoPrefab[ufoIndex], spawnPos, ufoPrefab[ufoIndex].transform.rotation);
    }
}
