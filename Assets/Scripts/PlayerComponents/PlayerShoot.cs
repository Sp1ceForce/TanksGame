using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] UnityEvent OnShoot;
    [SerializeField] List<Transform> shootingPoints;
    [SerializeField] ProjectileDamageComponent bullet;
    [SerializeField] int playerDamage = 30;
    [SerializeField] float rateOfFire = 0.25f;
    float shootTimer = 0;
    StatsComponent stats;
    private void Start()
    {
        stats = StaticHelper.Instance.PlayerStats;
        playerDamage = stats.Damage;
        rateOfFire = stats.RateOfFire;
        stats.OnStatsChange += OnStatsUpdate;
    }
    void OnStatsUpdate()
    {
        playerDamage = stats.Damage;
        rateOfFire = stats.RateOfFire;
    }
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if (shootTimer <= 0)
            {
                foreach (var shootingPoint in shootingPoints)
                {
                var bulletObj = Instantiate(bullet, shootingPoint.position, transform.rotation);
                bulletObj.Init(playerDamage);
                OnShoot?.Invoke();
                shootTimer = rateOfFire;
                }
            }
        }
        if (shootTimer > 0) shootTimer -= Time.deltaTime;
    }
}
