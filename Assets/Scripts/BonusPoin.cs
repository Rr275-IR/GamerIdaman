using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusPoin : MonoBehaviour
{
    public int points = 10; 

    private UpdateScore gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<UpdateScore>();

    }

    private void Update()
    {
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Cannonball"))
        {
            if (gameManager != null)
            {
                gameManager.AddPoints(points);
            }
        }
    }
}
