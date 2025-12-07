using UnityEngine;

public class road_destroy : MonoBehaviour
{
    // Note: This script is attached to the "EndMarker" of each road chunk.

    private void OnTriggerEnter(Collider other)
    {
        // Check for Player for Spawning and Destruction
        if (other.CompareTag("Player"))
        {
            if (GameManager.instance != null)
            {
                GameManager.instance.spawnRoad_aftercollision();
            }
            // Destroy the parent object (the entire road chunk) after a delay
            Destroy(transform.parent.gameObject, 2f);
        }

        // Check for Coin for Collection
        if (other.CompareTag("Coin"))
        {
            if (GameManager.instance != null)
            {
                GameManager.instance.AddCoin(1);
            }
            // Destroy the coin object
            Destroy(other.gameObject);
        }
    }
}