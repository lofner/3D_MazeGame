using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoresManager.instance.CoinsScore += 1;

            /*
             * Play sound
             */

            Destroy(gameObject);
        }
    }
}
