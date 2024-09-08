using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
   
    public float damage;
    public GameObject GameObject;

    

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerStats>().TakeDamage(damage);
            //StartCoroutine(OnDamageRoutine());
        }
    }

   /* IEnumerator OnDamageRoutine()
    {
        GameObject.SetActive(true);

        yield return new WaitForSeconds(10);

        GameObject.SetActive(false);

        GameObject.SetActive(true);

        yield return new WaitForSeconds(10);

        GameObject.SetActive(false);
    }*/
}
