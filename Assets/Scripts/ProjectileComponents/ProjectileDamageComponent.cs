using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDamageComponent : MonoBehaviour
{
    [SerializeField] float bulletLifetime;
    [SerializeField] int damage = 30;
    void Start()
    {
        Destroy(gameObject,bulletLifetime);
    }
    public void Init(int damage)
    {
        this.damage = damage;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        HealthComponent healthC = other.gameObject.GetComponent<HealthComponent>();
        if (healthC != null)
        {
            healthC.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
