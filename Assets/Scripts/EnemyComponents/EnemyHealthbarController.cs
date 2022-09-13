using UnityEngine;
using UnityEngine.UI;

//Component that set-ups and controls enemy's healthbar above their head
public class EnemyHealthbarController : MonoBehaviour
{
    HealthComponent healthComponent;
    Slider healthSlider;
    void Start()
    {
        healthSlider = GetComponentInChildren<Slider>();
        healthComponent = GetComponent<HealthComponent>();
        healthSlider.maxValue = healthComponent.MaxHealth;
        healthSlider.value = healthComponent.CurrentHealth;
        healthSlider.gameObject.SetActive(false);
    }

    public void UpdateHealth()
    {
        if (!healthSlider.gameObject.activeSelf) healthSlider.gameObject.SetActive(true);
        healthSlider.value = healthComponent.CurrentHealth;
    }
}
