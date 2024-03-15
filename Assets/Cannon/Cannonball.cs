using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cannonball : MonoBehaviour
{
    public string destroyTag; // Tag of the objects you want to destroy on collision

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(destroyTag))
        {
            Destroy(collision.gameObject);
            RockManager.RockDestroyed(); // Call RockDestroyed method when a rock is destroyed
        }

        AmmoManager ammoManager = GameObject.FindObjectOfType<AmmoManager>();
        if (ammoManager != null)
        { 
            ammoManager.FireCannonball();
        }
        else
        {
            Debug.LogWarning("AmmoManager not found in the scene.");
        }

        



        // Destroy the cannonball itself
        Destroy(gameObject);
    }
}