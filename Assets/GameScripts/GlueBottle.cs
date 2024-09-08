using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlueBottle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<StuffingEffects>().StopStuffingEffect();

            Destroy (gameObject);
        }
    }
}
