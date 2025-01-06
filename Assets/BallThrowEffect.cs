using UnityEngine;

public class BallThrowEffect : MonoBehaviour
{
    public ParticleSystem cometParticleSystem;
    public Rigidbody ballRigidbody;

    void Update()
    {
        if (cometParticleSystem != null && ballRigidbody != null)
        {
            cometParticleSystem.transform.position = ballRigidbody.position;
            Vector3 velocity = ballRigidbody.velocity;

            if (velocity.magnitude > 0.01f)
            {
                cometParticleSystem.transform.rotation = Quaternion.LookRotation(-velocity); // Negative to point the trail backward
            }
        }
    }
}
