using UnityEngine;

public class Target : MonoBehaviour
{
    public int points = 10;
    public float speed = 2f;
    public float distance = 3f;
    public ParticleSystem hitEffect; 
    public AudioClip hitSound; 

    private UpdateScore gameManager;
    private AudioSource audioSource;
    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
        gameManager = FindObjectOfType<UpdateScore>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        float offset = Mathf.Sin(Time.time * speed) * distance;
        transform.position = new Vector3(startPosition.x + offset, startPosition.y, startPosition.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cannonball"))
        {
            if (gameManager != null)
            {
                gameManager.AddPoints(points);
            }
            if (hitEffect != null)
            {
                Instantiate(hitEffect, transform.position, Quaternion.identity);
            }

            if (hitSound != null)
            {
                AudioManager2.Instance.PlaySound(hitSound);
            }
            Destroy(gameObject);
        }
    }
}
