using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuffingEffects : MonoBehaviour
{
    private PlayerStats playerStats;
    public GameObject GameObject;

    public void Start()
    {
        playerStats = GetComponent<PlayerStats>();
    }
    public void HandleStuffingEffects()
    {
        StartCoroutine(StuffingDamage());
    }

    private IEnumerator StuffingDamage()
    {
        float amount = 2f;
        float interval = 1f;

        while (playerStats.GetCurrentHealth() > 0)
        {
            playerStats.DecreaseHealth(amount);
            playerStats.healthBar.SetSlider(playerStats.GetCurrentHealth());

            yield return new WaitForSeconds(interval);
        }
    }

    public void StopStuffingEffect()
    {
        StopCoroutine(StuffingDamage());
        StartCoroutine(Stop());
        Debug.Log("Working");
    }

    IEnumerator Stop()
    {
        GameObject.SetActive(true);

        yield return new WaitForSeconds(10);

        GameObject.SetActive(false);
    }
}

