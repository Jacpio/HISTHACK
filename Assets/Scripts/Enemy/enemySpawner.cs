using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    [SerializeField] FighterAirCraft enemy;
    [SerializeField] Vector2[] spawnPoints;
    public int spawnCount;
    [SerializeField] bool autospawn;
    bool shouldSpawnNow;
    [SerializeField] float spawnDelay;
    private float _timer;
    int spawnPointIndex = 0;
    private void Start()
    {
        if (autospawn)
        {
            shouldSpawnNow = true;
        }
        enemy.player = FindObjectOfType<PlaneMovement>().transform;
    }

    private void Update()
    {
        EnemySpawnHandler();
        _timer += Time.deltaTime;
    }
    void EnemySpawnHandler ()
    {
        if (_timer > spawnDelay && spawnCount > 0 && shouldSpawnNow)
        {
            _timer = 0;
            spawnCount--;
            var spawnedEnemy = Instantiate(enemy, spawnPoints[spawnPointIndex], Quaternion.identity);
            if (spawnPointIndex < spawnPoints.Length - 1)
            {
                spawnPointIndex++;
            } 
            else spawnPointIndex = 0;
        }

    }
    public void SpawnEnemies ()
    {
        shouldSpawnNow = true;
    }



}
