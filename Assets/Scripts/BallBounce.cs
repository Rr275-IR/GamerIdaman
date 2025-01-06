using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public float stopThreshold = 0.1f;  
    public float rollingFriction = 0.01f; 

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plane"))
        {
            Vector3 velocity = rb.velocity;
            velocity.y = 0; 
            rb.velocity = velocity;
        }
    }

    void FixedUpdate()
    {
        if (rb.velocity.magnitude > stopThreshold)
        {
            Vector3 friction = rb.velocity.normalized * rollingFriction;
            rb.AddForce(-friction, ForceMode.Force);
        }
    }
}
