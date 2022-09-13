using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealBehaviour : MonoBehaviour
{
    [SerializeField] int healValue = 25;
    [SerializeField] UnityEvent OnHealPickup;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        HealthComponent healComponent = other.gameObject.GetComponentInParent<HealthComponent>();
        if (healComponent != null)
        {
            healComponent.Heal(healValue);
            OnHealPickup?.Invoke();
            Destroy(gameObject);
        }
    }
}
