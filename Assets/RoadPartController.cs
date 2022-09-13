
using System;
using System.Collections.Generic;
using UnityEngine;

public class RoadPartController : MonoBehaviour
{
    [SerializeField] GameObject InvisibleWall;
    [SerializeField] List<Transform> AvailableSpawnPoints;
    [SerializeField] Transform ShopSpawn;
    public Action OnTriggerEnter;
    bool hasCrossed = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;
        if (hasCrossed) return;
        OnTriggerEnter?.Invoke();
        hasCrossed = true;
        InvisibleWall.SetActive(true);
    }
    public void SpawnEnemies(List<EnemyStats> enemies, float multiplier)
    {
        int totalEnemies = UnityEngine.Random.Range(1, AvailableSpawnPoints.Count);
        for (int i = 0; i < totalEnemies; i++)
        {
            int randomIndex = UnityEngine.Random.Range(0, enemies.Count);
            int spawnpointIndex = UnityEngine.Random.Range(0, AvailableSpawnPoints.Count - 1);
            EnemyStats enemy = Instantiate(enemies[randomIndex], AvailableSpawnPoints[spawnpointIndex].position,Quaternion.identity,transform);
            enemy.Init(multiplier);
        }
    }
    public void SpawnShop(GameObject ShopObject)
    {
        Instantiate(ShopObject, ShopSpawn.transform,false);
    }
}
