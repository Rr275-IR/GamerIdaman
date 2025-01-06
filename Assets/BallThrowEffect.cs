using UnityEngine;

public class BallThrowEffect : MonoBehaviour
{
    public ParticleSystem cometParticleSystem;
    public Rigidbody ballRigidbody;

    void Update()
    {
        if (cometParticleSystem != null && ballRigidbody != null)
        {
            // Update the particle system's position
            cometParticleSystem.transform.position = ballRigidbody.position;

            // Align the particle system to the ball's velocity
            Vector3 velocity = ballRigidbody.velocity;

            if (velocity.magnitude > 0.01f)
            {
                cometParticleSystem.transform.rotation = Quaternion.LookRotation(-velocity); // Negative to point the trail backward
            }
        }
    }
}
