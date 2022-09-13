using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [SerializeField] float agroRadius = 10f;
    public float AgroRadius { get { return agroRadius; } }

    [SerializeField] float shootingRadius = 5f;
    public float ShootingRadius { get { return shootingRadius; } }
    [SerializeField] float fireRate = 2f;
    public float FireRate { get { return fireRate; } }
    [SerializeField] int damage = 30;
    public int Damage { get { return damage; } }
    [SerializeField] float maxHP = 300f;
    public float MaxHP { get { return maxHP; } }
    public void Init(float multiplier)
    {
        GetComponent<EnemyShootingComponent>().SetStats(Mathf.Clamp(FireRate/multiplier,0.5f,2f), (int)(damage * multiplier));
        GetComponent<HealthComponent>().SetNewMaxHP(MaxHP * multiplier);
    }
}
