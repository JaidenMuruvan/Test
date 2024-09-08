using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private StuffingEffects stuffingEffects;

    [SerializeField] private float maxHealth;


    private float currentHealth;

    public HealthBar healthBar;
    //public float WaitForSeconds = 50; 

    private void Start()
    {
        stuffingEffects = GetComponent<StuffingEffects>();

        currentHealth = maxHealth; 

        healthBar.SetSliderMax(maxHealth);

    }

    public float GetCurrentHealth()
    {
        return currentHealth;
    }

    public void DecreaseHealth(float amount)
    {
        currentHealth -= amount;
    }

    public void IncreaseHealth(float amount)
    {
        currentHealth += amount;
    }
    public void TakeDamage(float amount)
    {
        stuffingEffects.HandleStuffingEffects();
        currentHealth -= amount;
        healthBar.SetSlider(currentHealth);
    }

   
    public void Heal(float amount)
    {
        currentHealth += amount;
        healthBar.SetSlider(currentHealth);
    }
}