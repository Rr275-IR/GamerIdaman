using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusPoin : MonoBehaviour
{
    public int points = 10; // Points to award for hitting this target

    private UpdateScore gameManager;

    private void Start()
    {
        // Find the UpdateScore (GameManager) script in the scene
        gameManager = FindObjectOfType<UpdateScore>();

    }

    private void Update()
    {
    }

    private void OnTriggerEnter(Collider collision)
    {
        // Check if the colliding object has the "Cannonball" tag
        if (collision.gameObject.CompareTag("Cannonball"))
        {
            // Award points via the GameManager
            if (gameManager != null)
            {
                gameManager.AddPoints(points);
            }
        }
    }
}
