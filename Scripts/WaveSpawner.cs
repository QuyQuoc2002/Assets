using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;

    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    private int waveIndex = 0;
    //private List<int> rands = new List<int>();

    void Update()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;
    }

    IEnumerator SpawnWave()
    {
        waveIndex++;
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }

    }

    void SpawnEnemy()
    {
        int rand = Random.Range(1, 4);
        switch (rand)
        {
            case 1:
                Instantiate(enemyPrefab, spawnPoint1.position, spawnPoint1.rotation);
                break;
            case 2:
                Instantiate(enemyPrefab, spawnPoint2.position, spawnPoint2.rotation);
                break;
            case 3:
                Instantiate(enemyPrefab, spawnPoint3.position, spawnPoint3.rotation);
                break;
        }
        //rands.Add(rand);
    }

}
