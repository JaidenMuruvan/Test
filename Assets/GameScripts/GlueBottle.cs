using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* 
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
*/

public class GlueBottle : MonoBehaviour
{
    public float stunDuration = 5f; // Duration of the health glue in seconds

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StuffingEffects stuffingEffects = other.GetComponent<StuffingEffects>();

            if (stuffingEffects != null)
            {
                stuffingEffects.StopStuffingEffect();
                StartCoroutine(RestartStuffingEffectAfterDelay(stuffingEffects, stunDuration));
            }

            Destroy(gameObject);
        }
    }

    private IEnumerator RestartStuffingEffectAfterDelay(StuffingEffects stuffingEffects, float delay)
    {
        yield return new WaitForSeconds(delay);
        stuffingEffects.HandleStuffingEffects(); // start health drain again after glue finishes
    }
}
