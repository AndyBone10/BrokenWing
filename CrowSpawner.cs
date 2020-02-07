using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowSpawner : MonoBehaviour
{

    public GameObject crow;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float timeBeforeSpawnStart;
    public float timeBetweenWaves;
    public bool crowSpawnStarted;


    // Use this for initialization
    void Start()
    {
        //StartCoroutine(SpawnWaves ());
    }

    void Update()
    {
        if (GameManager.instance.gameStarted == true && !crowSpawnStarted)
        {
            StartCoroutine(SpawnWaves());
            crowSpawnStarted = true;
        }
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(timeBeforeSpawnStart);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(transform.position.x, Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(crow, spawnPosition, spawnRotation);
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
