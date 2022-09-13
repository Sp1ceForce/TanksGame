using System;
using UnityEngine;
public enum UpgradeType
{
    Damage,
    PickupRadius,
    MaxHealth,
    TowerLevel,
    Movespeed,
    RateOfFire
}
public class ShopItemInfo : MonoBehaviour
{
    [SerializeField] UpgradeType upgradeType;
    public UpgradeType UpgradeType { get => upgradeType;}
    [Multiline]
    [SerializeField] private string baseDescription;
    public string BaseDescription { get { return baseDescription; } }

    [SerializeField] private int price;
    public int Price { get { return price; } set { price = value; } }

    [SerializeField] private float additionalPower;
    public float AdditionalPower { get { return additionalPower; } }

    private float currentPower;
    public float CurrentPower { get { return currentPower; } }
    StatsComponent stats;
    private void Awake()
    {
        stats = StaticHelper.Instance.PlayerStats;
        stats.OnStatsChange += UpdateStats;
        UpdateStats();
        
    }
    public void UpdateStats()
    {
        switch (upgradeType)
        {
            case UpgradeType.Damage:
                currentPower = stats.Damage;
                break;
            case UpgradeType.PickupRadius:
                currentPower = stats.PickupRadius;
                break;
            case UpgradeType.MaxHealth:
                currentPower = stats.MaxHP;
                break;
            case UpgradeType.TowerLevel:
                currentPower = stats.TowerLevel;
                break;
            case UpgradeType.Movespeed:
                currentPower = stats.MovementSpeed;
                break;
            case UpgradeType.RateOfFire:
                currentPower = stats.RateOfFire;
                break;
        }
    }
}
