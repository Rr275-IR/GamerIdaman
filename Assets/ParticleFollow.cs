using UnityEngine;

public class ParticleFollow : MonoBehaviour
{
    public Transform ball; // Assign the ball in the Inspector

    void Update()
    {
        if (ball != null)
        {
            // Update position to match the ball's position
            transform.position = ball.position;
        }
    }
}
