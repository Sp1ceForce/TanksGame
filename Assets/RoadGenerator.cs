using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    [SerializeField] GameObject ShopObject;
    [SerializeField] RoadPartController DefaultRoad;
    [SerializeField] List<EnemyStats> enemies;
    [SerializeField] List<RoadPartController> roads;
    [SerializeField] Vector3 spawnOffset;
    [SerializeField] int roadCounter;
    [SerializeField] float multiplierStep = 0.05f;
    float dificultyMultiplier = 1;
    private void Start()
    {
        roadCounter= roads.Count;
        roads[roads.Count - 1].OnTriggerEnter += OnRoadCross;
    }

    void OnRoadCross()
    {
        RoadPartController newRoad = Instantiate(DefaultRoad, roads[roads.Count - 1].transform.position + spawnOffset, Quaternion.identity);
        newRoad.OnTriggerEnter+=OnRoadCross;    
        if(roadCounter % 5 == 0)
        {
            newRoad.SpawnShop(ShopObject);
        }
        else
        {
            newRoad.SpawnEnemies(enemies,dificultyMultiplier);
        }
        RoadPartController destroyedRoad = roads[0];
        roads.Remove(destroyedRoad);
        Destroy(destroyedRoad.gameObject);
        roads.Add(newRoad);
        roadCounter++;
        dificultyMultiplier += multiplierStep;
    }
}
