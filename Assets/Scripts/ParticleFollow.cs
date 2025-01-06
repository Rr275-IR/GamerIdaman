using UnityEngine;

public class ParticleFollow : MonoBehaviour
{
    public Transform ball;

    void Update()
    {
        if (ball != null)
        {
            transform.position = ball.position;
        }
    }
}
