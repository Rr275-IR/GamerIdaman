using UnityEngine;

public class Target : MonoBehaviour
{
    public int points = 10; // Points to award for hitting this target
    public float speed = 2f; // Speed of horizontal movement
    public float distance = 3f; // Maximum distance from the starting position
    public ParticleSystem hitEffect; // Optional: Particle effect on hit
    public AudioClip hitSound; // Optional: Sound effect on hit

    private UpdateScore gameManager;
    private AudioSource audioSource;
    private Vector3 startPosition;

    private void Start()
    {
        // Store the initial position of the target
        startPosition = transform.position;

        // Find the UpdateScore (GameManager) script in the scene
        gameManager = FindObjectOfType<UpdateScore>();

        // Add an AudioSource if hitSound is assigned
        //if (hitSound != null)
        //{
        //    audioSource = gameObject.AddComponent<AudioSource>();
        //    audioSource.clip = hitSound;
        //}
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        // Move the target left and right
        float offset = Mathf.Sin(Time.time * speed) * distance;
        transform.position = new Vector3(startPosition.x + offset, startPosition.y, startPosition.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object has the "Cannonball" tag
        if (collision.gameObject.CompareTag("Cannonball"))
        {
            // Award points via the GameManager
            if (gameManager != null)
            {
                gameManager.AddPoints(points);
            }

            // Trigger a particle effect, if assigned
            if (hitEffect != null)
            {
                Instantiate(hitEffect, transform.position, Quaternion.identity);
            }

            // Play the hit sound, if assigned
            if (hitSound != null)
            {
                AudioManager2.Instance.PlaySound(hitSound);
            }

            // Destroy the target (optional, you can remove this line if the target should remain)
            Destroy(gameObject);
        }
    }
}
