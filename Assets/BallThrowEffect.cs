using UnityEngine;

public class BallThrowEffect : MonoBehaviour
{
    public ParticleSystem ballTrailParticle; // Drag & drop Particle System
    private Vector3 previousPosition;

    void Start()
    {
        previousPosition = transform.position;
        if (ballTrailParticle != null)
        {
            ballTrailParticle.Stop(); // Pastikan partikel tidak aktif di awal
        }
    }

    void Update()
    {
        // Hitung kecepatan bola berdasarkan perubahan posisi
        float movementSpeed = (transform.position - previousPosition).magnitude / Time.deltaTime;

        // Jika bola bergerak cepat, nyalakan partikel
        if (movementSpeed > 0.1f) // Sesuaikan threshold ini
        {
            if (ballTrailParticle != null && !ballTrailParticle.isPlaying)
            {
                ballTrailParticle.Play();
            }
        }
        else
        {
            if (ballTrailParticle != null && ballTrailParticle.isPlaying)
            {
                ballTrailParticle.Stop();
            }
        }

        // Simpan posisi sebelumnya
        previousPosition = transform.position;
    }
}
