using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public float stopThreshold = 0.1f;  // Kecepatan di bawah ini bola dianggap berhenti
    public float rollingFriction = 0.01f; // Friction rendah untuk menggelindingkan bola

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plane"))
        {
            // Set kecepatan vertikal menjadi 0 langsung (berhenti memantul)
            Vector3 velocity = rb.velocity;
            velocity.y = 0; // Hentikan pergerakan vertikal langsung

            // Tetap biarkan kecepatan horizontal agar bola bisa menggelinding
            rb.velocity = velocity;
        }
    }

    void FixedUpdate()
    {
        // Menambahkan rolling friction jika bola masih bergerak di atas plane
        if (rb.velocity.magnitude > stopThreshold)
        {
            Vector3 friction = rb.velocity.normalized * rollingFriction;
            rb.AddForce(-friction, ForceMode.Force);
        }
    }
}
