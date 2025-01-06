using UnityEngine;

public class AudioManager2 : MonoBehaviour
{

    private static AudioManager2 instance;
    private AudioSource audioManagerSource;

    public static AudioManager2 Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            audioManagerSource = GetComponent<AudioSource>();
        }
    }

    public void PlaySound(AudioClip clip)
    {
        audioManagerSource.PlayOneShot(clip);
    }
}
