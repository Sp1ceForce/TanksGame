using UnityEngine;
using UnityEngine.Events;

public class CoinBehaviour : MonoBehaviour
{
    [SerializeField] int coinValue = 25;
    [SerializeField] UnityEvent OnCoinPickup;

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayersCashComponent cashComponent = other.gameObject.GetComponentInParent<PlayersCashComponent>();
        if (cashComponent != null)
        {
            cashComponent.AddCash(coinValue);
            OnCoinPickup?.Invoke();
            Destroy(gameObject);
        }
    }
}
