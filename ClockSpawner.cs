using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockSpawner : MonoBehaviour
{

    public GameObject clock;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float timeBeforeSpawnStart;
    public float timeBetweenWaves;
    public bool clockSpawnStarted;


    // Use this for initialization
    void Start()
    {
        //StartCoroutine(SpawnWaves ());
    }

    void Update()
    {
        if (GameManager.instance.gameStarted == true && !clockSpawnStarted)
        {
            StartCoroutine(SpawnWaves());
            clockSpawnStarted = true;
        }
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(timeBeforeSpawnStart);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(clock, spawnPosition, spawnRotation);
               //// if (i == hazardCount - 1)
                //{
                 //   Instantiate(coin, spawnPosition, spawnRotation);
               // }
                yield return new WaitForSeconds(spawnWait);

            }
            yield return new WaitForSeconds(timeBetweenWaves);
        }
    }
}
