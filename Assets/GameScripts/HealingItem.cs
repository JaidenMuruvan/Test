using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingItem : MonoBehaviour
{
    public float healAmount;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        
        {
            other.GetComponent<PlayerStats>().Heal(healAmount);
            Destroy(gameObject);
       
        }
    }

}
