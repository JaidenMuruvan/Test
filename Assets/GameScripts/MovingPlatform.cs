using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject Player;
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject == Player)
        {
            Player.transform.parent = transform;
            Debug.Log("Attached");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.parent = null;
            Debug.Log("off");
        }
    }



}
