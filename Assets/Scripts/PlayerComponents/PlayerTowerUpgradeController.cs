using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTowerUpgradeController : MonoBehaviour
{
    StatsComponent stats;
    [SerializeField] List<PlayerShoot> Towers;
    int towerLevel = 0;
    private void Start()
    {
        stats = StaticHelper.Instance.PlayerStats;
        towerLevel = stats.TowerLevel;
        foreach (var tower in Towers)
        {
            tower.gameObject.SetActive(false);
        }
        Towers[towerLevel].gameObject.SetActive(true);
        stats.OnStatsChange += OnStatsUpdate;
    }
    void OnStatsUpdate()
    {
        if (stats.TowerLevel != towerLevel && stats.TowerLevel<Towers.Count)
        {
            Towers[towerLevel].gameObject.SetActive(false);
            towerLevel=stats.TowerLevel;
            Towers[towerLevel].gameObject.SetActive(true);
        }
    }
}
