using System;
using UnityEngine;
/*Component that stores some other stats which are not used directly by the player
Current stats:
1)Pickup radius - how far you can pickup your coins
2)Damage - How much damage your bullet deals
3)Max HP - Maximum health of the player
4)Tower Level - Level of your shooting tower
5)Movement Speed - How fast player is moving
6)Rate of fire - how fast player     can shoot
*/
public class StatsComponent : MonoBehaviour
{
    [SerializeField] float pickupRadius;
    public float PickupRadius
    {
        get => pickupRadius;
        set
        {
            pickupRadius = value;
            OnStatsChange?.Invoke();
        }
    }
    [SerializeField] float rateOfFire;
    public float RateOfFire
    {
        get => rateOfFire;
        set
        {
            rateOfFire = value;
            OnStatsChange?.Invoke();
        }
    }
    [SerializeField] float movementSpeed;
    public float MovementSpeed
    {
        get => movementSpeed;
        set
        {
            movementSpeed = value;
            OnStatsChange?.Invoke();
        }
    }
    [SerializeField] int damage;
    public int Damage
    {
        get => damage;
        set
        {
            damage = value;
            OnStatsChange?.Invoke();
        }
    }
    [SerializeField] int maxHP;
    public int MaxHP
    {
        get => maxHP;
        set
        {
            maxHP = value;
            OnStatsChange?.Invoke();
        }
    }
    [SerializeField] int towerLevel;
    public int TowerLevel
    {
        get => towerLevel;
        set
        {
            towerLevel = value;
            OnStatsChange?.Invoke();
        }
    }

    public Action OnStatsChange;
}
