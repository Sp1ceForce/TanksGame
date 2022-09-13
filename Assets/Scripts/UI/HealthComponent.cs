using UnityEngine;
using UnityEngine.Events;

public class HealthComponent : MonoBehaviour
{
    [SerializeField] float maxHealth = 300f;
    StatsComponent stats;
    public float MaxHealth { get { return maxHealth; } }
    [SerializeField] float currentHealth;
    public float CurrentHealth { get { return currentHealth; } }
    [SerializeField] UnityEvent OnDeath;
    [SerializeField] UnityEvent OnCurrentHealthUpdate;

    private void Start()
    {
        if (gameObject.tag == "Player")
        {
        StartForPlayer();
        }
        currentHealth = maxHealth;
    }

    private void StartForPlayer()
    {
        stats = StaticHelper.Instance.PlayerStats;
        maxHealth = stats.MaxHP;
        stats.OnStatsChange += GetNewMaxHpFromStats;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        OnCurrentHealthUpdate?.Invoke();
        if (currentHealth <= 0)
        {
            OnDeath.Invoke();
        }
    }
    public void Heal(float heal)
    {
        currentHealth += heal;
        currentHealth = Mathf.Clamp(currentHealth,0, maxHealth);
        OnCurrentHealthUpdate?.Invoke();
    }
    public void GetNewMaxHpFromStats()
    {
        if (stats.MaxHP == maxHealth) return;
        SetNewMaxHP(stats.MaxHP);
    }
    public void SetNewMaxHP(float hp)
    {
        currentHealth = hp;
        maxHealth = hp;
    }
}
