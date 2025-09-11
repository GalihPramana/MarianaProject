using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ilumisoft.HealthSystem; // Import your health system namespace

public class BatteryOnTrigger : MonoBehaviour
{
    [Tooltip("Amount of health restored when player picks this up")]
    public float healAmount = 25f;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object is tagged as Player
        if (other.CompareTag("Player"))
        {
            // Try to find the Health component on the player
            Health playerHealth = other.GetComponent<Health>();

            if (playerHealth != null && playerHealth.IsAlive)
            {
                playerHealth.AddHealth(healAmount);
            }

            // Destroy the battery after being used
            Destroy(gameObject);
        }
    }
}
