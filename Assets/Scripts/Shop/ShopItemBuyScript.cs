using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItemBuyScript : MonoBehaviour
{
    ShopItemInfo itemInfo;
    PlayersCashComponent playersCash;
    [SerializeField]
    [Range(0,10)]
    int remainingLevels = 0;
    ShopItemGFXController itemText;
    StatsComponent stats;
    void Start()
    {
        playersCash = StaticHelper.Instance.PlayerObject.GetComponent<PlayersCashComponent>();
        itemInfo = GetComponent<ShopItemInfo>();
        itemText = GetComponent<ShopItemGFXController>();
        stats = StaticHelper.Instance.PlayerStats;
    }

    public void TryToBuyItem()
    {
        if (playersCash.PlayersMoney >= itemInfo.Price)
        {
            playersCash.SpendCash(itemInfo.Price);
            itemInfo.Price = (int)(itemInfo.Price*1.5f);
            switch (itemInfo.UpgradeType)
            {
                case UpgradeType.Damage:
                    stats.Damage += (int)itemInfo.AdditionalPower;
                    break;
                case UpgradeType.PickupRadius:
                    stats.PickupRadius += itemInfo.AdditionalPower;
                    break;
                case UpgradeType.MaxHealth:
                    stats.MaxHP += (int)itemInfo.AdditionalPower;
                    break;
                case UpgradeType.TowerLevel:
                    stats.TowerLevel += int.Parse(itemInfo.AdditionalPower.ToString());
                    break;
                case UpgradeType.Movespeed:
                    stats.MovementSpeed += itemInfo.AdditionalPower;
                    break;
                case UpgradeType.RateOfFire:
                    stats.RateOfFire -= itemInfo.AdditionalPower;
                    break;
                default:
                    Debug.LogError($"Wrong UpgradeType of {gameObject.name}");
                    break;
            }
            remainingLevels--;
            if (remainingLevels <= 0) 
            {
                itemText.SetNotAvailable();
            }
            else
            {
                itemInfo.UpdateStats();
                itemText.UpdateInfo();
            }
        }
    }
}
