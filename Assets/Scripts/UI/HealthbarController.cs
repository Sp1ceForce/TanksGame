using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarController : MonoBehaviour
{
    Slider healthSlider;
    HealthComponent healthComponent;
    StatsComponent stats;
    void Start()
    {
        healthSlider = GetComponent<Slider>();  
        healthComponent = StaticHelper.Instance.PlayerObject.GetComponent<HealthComponent>();
        stats = StaticHelper.Instance.PlayerStats;
        healthSlider.maxValue = stats.MaxHP;
        healthSlider.value = stats.MaxHP;
        stats.OnStatsChange += SetNewMaxValue;
    }
    public void UpdateHealthbar()
    {
        healthSlider.value = healthComponent.CurrentHealth;
    }
    public void SetNewMaxValue()
    {
        if (stats.MaxHP == healthSlider.maxValue) return;
        healthSlider.maxValue = stats.MaxHP;
        healthSlider.value = stats.MaxHP;
    }
    
}
