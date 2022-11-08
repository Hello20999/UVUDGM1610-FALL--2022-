using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawnManager : MonoBehaviour
{
    public GameObject[] PowerupPrefab;
    private float spawnRangeX = 35.6f;
    private float spawnRangeZ = 30.6f;
    private float startDelay = 0f;
    private float spawnInterval = 10f;
    // Update is called once per frame
    private void Start()
    {
        InvokeRepeating("SpawnRandomPowerUp", startDelay, spawnInterval);
    }
    /*SpawnRandomUFO()
     * calls upon the function within other functions
     */
    void SpawnRandomPowerUp()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
        int powerupIndex = Random.Range(0, PowerupPrefab.Length);
        Instantiate(PowerupPrefab[powerupIndex], spawnPos, PowerupPrefab[powerupIndex].transform.rotation);
    }
}
